Imports System.Drawing.Drawing2D
Imports System.Threading
Imports LabExercise4.AppGlobals

Public Class PosForm

    ' Transaction session variables
    Private customerName As String
    Private currentProduct As ProductItem = Nothing
    Private transactionDateTime As Date
    Private purchases As New List(Of CartItem)
    Private totalPayment As Decimal
    Private customerCash As Decimal
    Private customerChange As Decimal

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DateTimeWorker.RunWorkerAsync()

        CashierNameLabel.Text = currentCashierUsername
        TransIdTextbox.Text = Date.Now.ToString("SAL-yyyyMdHHmmss-ffffff")
        transactionDateTime = Date.Now()
        TransDateTimeTextbox.Text = transactionDateTime.ToString()

        CustNameTexbox.Focus()
    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal pevent As System.Windows.Forms.PaintEventArgs)
        'Define starters (the point [0,0] is the top-left corner of the form)
        Dim yStart As Integer = 0
        Dim xStart As Integer = 0
        'Define the dimension (here it depends on your form dimension)
        Dim yEnd As Integer = yStart + Width
        Dim xEnd As Integer = xEnd + Height
        'Color definitions
        Dim init_color = Color.FromArgb(17, 28, 36)
        Dim end_color = Color.FromArgb(35, 12, 22)
        ' Apply brush
        Dim red_green_brush As New LinearGradientBrush(New Point(xStart, yStart), New Point(xEnd, yEnd), init_color, end_color)
        pevent.Graphics.FillRectangle(red_green_brush, xStart, yStart, Width, Height)
        red_green_brush.Dispose()
    End Sub

    Private Sub DateTimeWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DateTimeWorker.DoWork
        While True
            Dim dt As String = Date.Now.ToString("MMMM d, yyyy HH:mm:ss")
            If DateTimeLabel.InvokeRequired Then
                DateTimeLabel.Invoke(
                    Sub()
                        DateTimeLabel.Text = dt
                    End Sub
                )
            Else
                DateTimeLabel.Text = dt
            End If
            Threading.Thread.Sleep(1000)
        End While
    End Sub

    Private Sub BarcodeSearchBtn_Click(sender As Object, e As EventArgs) Handles BarcodeSearchBtn.Click
        Dim productBarcode As String = BarcodeTextbox.Text

        If products.ContainsKey(productBarcode) Then
            currentProduct = products.Item(productBarcode)
            ItemNameTextbox.Text = currentProduct.ItemName
            ProductPriceTextbox.Text = currentProduct.Price
            ProductStockQtyLabel.Text = currentProduct.Quantity

            ProdQtyTextbox.Enabled = True
            InsertItemBtn.Enabled = True

            ProdQtyTextbox.Focus()
        Else
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
        End If
    End Sub

    Private Sub InsertItemBtn_Click(sender As Object, e As EventArgs) Handles InsertItemBtn.Click
        Dim itemBarcode As String
        Dim itemName As String
        Dim itemPrice As String
        Dim itemQty As Integer
        Dim itemSubtotal As String
        Dim newRow() As String
        Dim existingItem As Boolean = False
        Dim existingItemRow As Integer
        Dim newItemQty As Integer
        Dim newPriceSubtotal As Decimal


        If IsNothing(currentProduct) Then
            MessageBox.Show(Me, "Please, enter a product before inserting to purchases.", "Add to purchase", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If Integer.TryParse(ProdQtyTextbox.Text, itemQty) Then
                If itemQty > 0 Then
                    itemBarcode = currentProduct.Barcode
                    itemName = currentProduct.ItemName
                    itemPrice = currentProduct.Price
                    itemSubtotal = ProdSubtotalTextbox.Text

                    For Each row As DataGridViewRow In CartItemsDatagrid.Rows
                        If itemBarcode = row.Cells(0).Value Then
                            existingItem = True
                            existingItemRow = row.Cells(0).RowIndex
                            newItemQty = Integer.Parse(CartItemsDatagrid.Rows(existingItemRow).Cells(3).Value) + itemQty
                            newPriceSubtotal = Decimal.Parse(CartItemsDatagrid.Rows(existingItemRow).Cells(4).Value) + Decimal.Parse(itemSubtotal)
                            CartItemsDatagrid.Rows(existingItemRow).Cells(3).Value = newItemQty
                            CartItemsDatagrid.Rows(existingItemRow).Cells(4).Value = newPriceSubtotal
                            Exit For
                        End If
                    Next

                    If Not existingItem Then
                        newRow = {itemBarcode, itemName, itemPrice, itemQty, itemSubtotal}
                        CartItemsDatagrid.Rows.Add(newRow)
                    End If

                    ' Reset
                    currentProduct = Nothing
                    BarcodeTextbox.Text = ""
                    ProdQtyTextbox.Text = ""
                    ProductStockQtyLabel.Text = "0"
                    ProductPriceTextbox.Text = ""
                    ProdSubtotalTextbox.Text = ""
                    ItemNameTextbox.Text = ""
                    ProdQtyTextbox.Enabled = False
                    InsertItemBtn.Enabled = False
                Else
                    MessageBox.Show(Me, "Product quantity cannot be lower than 1.", "Add to purchase", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    ProdQtyTextbox.Text = ""
                End If
            Else
                MessageBox.Show(Me, "Please, enter a valid product quantity value.", "Add to purchase", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ProdQtyTextbox.Text = ""
            End If
        End If
    End Sub

    Private Sub ProdQtyTextbox_TextChanged(sender As Object, e As EventArgs) Handles ProdQtyTextbox.TextChanged
        Dim itemQty As Integer
        Dim itemTotal As Decimal

        If (Not IsNothing(currentProduct)) And Integer.TryParse(ProdQtyTextbox.Text, itemQty) Then
            itemTotal = itemQty * currentProduct.Price
            ProdSubtotalTextbox.Text = itemTotal
        Else
            ProdQtyTextbox.Text = ""
        End If

    End Sub

    Private Sub CartItemsDatagrid_SelectionChanged(sender As Object, e As EventArgs) Handles CartItemsDatagrid.SelectionChanged
        RemoveItemBtn.Enabled = CartItemsDatagrid.SelectedRows.Count > 0
    End Sub

    Private Sub CartItemsDatagrid_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles CartItemsDatagrid.RowsAdded
        CheckoutBtn.Enabled = CartItemsDatagrid.Rows.Count > 0
    End Sub

    Private Sub CartItemsDatagrid_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles CartItemsDatagrid.RowsRemoved
        CheckoutBtn.Enabled = CartItemsDatagrid.Rows.Count > 0
    End Sub

    Private Sub RemoveItemBtn_Click(sender As Object, e As EventArgs) Handles RemoveItemBtn.Click
        Dim selectionIndex As Integer = CartItemsDatagrid.SelectedRows(0).Index

        If selectionIndex >= 0 Then
            CartItemsDatagrid.Rows.RemoveAt(selectionIndex)
        End If
    End Sub

    Private Sub CheckoutBtn_Click(sender As Object, e As EventArgs) Handles CheckoutBtn.Click
        customerName = CustNameTexbox.Text

        If customerName = "" Then
            MessageBox.Show(Me, "Enter customer name.", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CustNameTexbox.Focus()
        Else
            Dim result As DialogResult = MessageBox.Show(Me, "Checkout and finalize pruchases?", "Checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                TransDetailsContainer.Enabled = False
                ProdItemDetailsContainer.Enabled = False
                CartItemsDatagrid.Enabled = False

                Dim loadingDialog As New LoadingDialog("Finalizing purchases. Please wait...")

                Dim checkoutThread As New Thread(
                    Sub()
                        Dim barCode As String
                        Dim quantity As Integer
                        Dim subtotal As Decimal

                        For Each cartRow As DataGridViewRow In CartItemsDatagrid.Rows
                            barCode = cartRow.Cells(0).Value
                            quantity = cartRow.Cells(3).Value
                            subtotal = cartRow.Cells(4).Value

                            purchases.Add(New CartItem(products.Item(barCode), quantity, subtotal))
                            totalPayment += subtotal
                        Next

                        Thread.Sleep(100 * CartItemsDatagrid.Rows.Count)

                        loadingDialog.Invoke(
                            Sub()
                                loadingDialog.CloseDialog(CloseReason.ApplicationExitCall)
                            End Sub
                        )
                    End Sub
                )

                checkoutThread.Start()
                loadingDialog.ShowDialog(Me)

                Using inputCashDialogForm As New InputCustomerCashDialog(totalPayment)
                    Dim retResult As DialogResult = inputCashDialogForm.ShowDialog(Me)

                    If retResult = DialogResult.OK Then
                        customerCash = CDec(Val(inputCashDialogForm.CustomerCashTextbox.Text))
                        customerChange = customerCash - totalPayment

                        For Each purchase As CartItem In purchases
                            products.Item(purchase.ProductItem.Barcode).Quantity -= purchase.Quantity
                        Next

                        GenerateReceipt()
                    Else
                        MessageBox.Show(Me, "Transaction cancelled.", "Finalizing purchases.")
                    End If
                End Using

            End If
        End If
    End Sub

    Private Sub GenerateReceipt()
        Dim itemsForReceipt As String = ""
        Dim receipt As String = ""

        Dim totalStringed As String = String.Format("{0:0.00}", totalPayment)
        Dim cashStringed As String = String.Format("{0:0.00}", customerCash)
        Dim changeStringed As String = String.Format("{0:0.00}", customerChange)

        For Each purchasedItem As CartItem In purchases
            Dim qty As Integer = purchasedItem.Quantity
            Dim itemName As String = purchasedItem.ProductItem.ItemName
            Dim subtotal As Decimal = purchasedItem.SubTotal

            itemsForReceipt += String.Format(
                My.Resources.ItemReceiptLineTemplate,
                qty.ToString().PadRight(6, " "),
                itemName.PadRight(24 - subtotal.ToString().Length, " "),
                String.Format("{0:0.00}", subtotal)
            )
        Next

        receipt = String.Format(
            My.Resources.ReceiptTemplate,
            customerName.PadLeft(23),
            currentCashierUsername.PadLeft(24),
            transactionDateTime.ToString(" yyyy/MM/dd               hh:ss tt "),
            itemsForReceipt,
            totalStringed.PadLeft(28),
            cashStringed.PadLeft(29),
            changeStringed.PadLeft(27)
        )
        Dim loadingDialog As New LoadingDialog("Generating receipt. Please wait...")

        Dim thread As New Thread(
            Sub()
                For Each line As String In receipt.Split(Environment.NewLine)
                    If ReceiptLabel.InvokeRequired Then
                        ReceiptLabel.Invoke(
                            Sub()
                                ReceiptLabel.Text += line & Environment.NewLine
                            End Sub
                        )
                    Else
                        ReceiptLabel.Text += line & Environment.NewLine
                    End If

                    Thread.Sleep(500)
                Next

                loadingDialog.Invoke(
                Sub()
                    loadingDialog.CloseDialog(CloseReason.ApplicationExitCall)
                End Sub
            )
            End Sub
        )

        thread.Start()
        loadingDialog.ShowDialog(Me)

        MessageBox.Show(Me, String.Format("Customer change is P {0:0.00}.", customerChange), "Finishing transaction", MessageBoxButtons.OK, MessageBoxIcon.Information)
        reports.Add(
            TransIdTextbox.Text,
            New Report(
                TransIdTextbox.Text,
                customerName,
                transactionDateTime,
                currentCashierUsername,
                purchases,
                totalPayment,
                customerCash,
                customerChange,
                receipt
            )
        )
        Reset()
    End Sub

    Private Sub Reset()
        ' variables reset
        customerName = Nothing
        currentProduct = Nothing
        transactionDateTime = Date.Now()
        purchases.Clear()
        totalPayment = Nothing
        customerCash = Nothing
        customerChange = Nothing

        ' Empty UI
        CustNameTexbox.Text = ""
        BarcodeTextbox.Text = ""
        ProdQtyTextbox.Text = ""
        ProductPriceTextbox.Text = ""
        ProdSubtotalTextbox.Text = ""
        ItemNameTextbox.Text = ""
        ReceiptLabel.Text = ""
        CartItemsDatagrid.Rows.Clear()

        ' UI reset
        TransDetailsContainer.Enabled = True
        ProdItemDetailsContainer.Enabled = True
        CartItemsDatagrid.Enabled = True

        InsertItemBtn.Enabled = False
        RemoveItemBtn.Enabled = False
        CheckoutBtn.Enabled = False
        ProdQtyTextbox.Enabled = False

        ' Populate UI with new values
        TransIdTextbox.Text = Date.Now.ToString("SAL-yyyyMdHHmmss-ffffff")
        transactionDateTime = Date.Now()
        TransDateTimeTextbox.Text = transactionDateTime.ToString()

        CustNameTexbox.Focus()
    End Sub

    Private Sub ResetTransBtn_Click(sender As Object, e As EventArgs) Handles ResetTransBtn.Click
        Reset()
    End Sub
End Class
