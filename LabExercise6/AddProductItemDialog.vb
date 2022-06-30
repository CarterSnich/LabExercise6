Imports LabExercise4.AppGlobals

Public Class AddProductItemDialog
    Private Sub AddItemBtn_Click(sender As Object, e As EventArgs) Handles AddItemBtn.Click
        Dim barcode As String = BarcodeTextBox.Text
        Dim itemName As String = ItemNameTextBox.Text
        Dim price As String = PriceTextBox.Text
        Dim quantity As String = QtyTextBox.Text
        Dim dummy As Integer

        If barcode = "" Or itemName = "" Or price = "" Or quantity = "" Then
            MessageBox.Show(Me, "Please, fill-up all fields.", "Add new product item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If Not IsNumeric(price) Then
                MessageBox.Show(Me, "Enter valid price value.", "Add new product item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Not Integer.TryParse(quantity, dummy) Then
                MessageBox.Show(Me, "Enter valid quantity value.", "Add new product item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim newProdItem As New ProductItem(barcode, itemName, price, quantity)
                products.Add(barcode, newProdItem)

                MessageBox.Show(Me, "New product item added.", "Add product item", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
            End If
        End If

    End Sub
End Class