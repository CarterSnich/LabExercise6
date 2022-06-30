Imports LabExercise4.AppGlobals

Public Class EditStockDialog
    Private ReadOnly productItemBarcode As String = StocksForm.selectedProductItem
    Private ReadOnly productItemDetails As ProductItem

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        productItemDetails = products.Item(productItemBarcode)
        BarcodeTextBox.Text = productItemDetails.Barcode
        ItemNameTextBox.Text = productItemDetails.ItemName
        PriceTextBox.Text = productItemDetails.Price
        QtyTextBox.Text = productItemDetails.Quantity
    End Sub

    Private Sub UpdateStockBtn_Click(sender As Object, e As EventArgs) Handles UpdateStockBtn.Click
        Dim newItemName As String = ItemNameTextBox.Text
        Dim newPrice As String = PriceTextBox.Text
        Dim newQty As String = QtyTextBox.Text
        Dim dummy As Integer

        If newItemName = "" Or newPrice = "" Or newQty = "" Then
            MessageBox.Show(Me, "Please, fill-up all fields.", "Update stock information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If Not IsNumeric(newPrice) Then
                MessageBox.Show(Me, "Please, enter valid price value.", "Update stock information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                PriceTextBox.Text = ""
            ElseIf Not Integer.TryParse(newQty, dummy) Then
                MessageBox.Show(Me, "Please, enter valid quantity value.", "Update stock information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                QtyTextBox.Text = ""
            Else
                products.Item(productItemBarcode).ItemName = newItemName
                products.Item(productItemBarcode).Price = newPrice
                products.Item(productItemBarcode).Quantity = newQty

                MessageBox.Show(Me, "Stock details updated successfully.", "Update stock information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
            End If
        End If

    End Sub
End Class