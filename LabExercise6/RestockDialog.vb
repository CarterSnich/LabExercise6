Imports LabExercise4.AppGlobals

Public Class RestockDialog

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ProdBarcodeLabel.Text = StocksForm.selectedProductItem
    End Sub

    Private Sub UpdateStockBtn_Click(sender As Object, e As EventArgs) Handles UpdateStockBtn.Click
        Dim newStockCount As String = StockCountTextBox.Text

        If newStockCount = "" Then
            MessageBox.Show(Me, "Please, fill-up all fields.", "Update stock count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            StockCountTextBox.Text = ""
        Else
            Dim dummy As Integer
            If Not Integer.TryParse(newStockCount, dummy) Then
                MessageBox.Show(Me, "Enter valid stock count value.", "Update stock count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                products.Item(StocksForm.selectedProductItem).Quantity = newStockCount

                MessageBox.Show(Me, "Stock count updated successfully.", "Update stock count", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
            End If
        End If
    End Sub
End Class