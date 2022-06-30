Imports LabExercise4.AppGlobals

Public Class StocksForm

    Public Shared selectedProductItem As String

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PopulateDataGridView()
    End Sub

    Private Sub NewItemBtn_Click(sender As Object, e As EventArgs) Handles NewItemBtn.Click
        Dim addProdItemForm As New AddProductItemDialog()
        Dim result As DialogResult = addProdItemForm.ShowDialog(Me)

        If result = DialogResult.OK Then
            PopulateDataGridView()
        End If
    End Sub

    Private Sub PopulateDataGridView()
        ProductDataGridView.Rows.Clear()
        For Each prodItemKvp As KeyValuePair(Of String, ProductItem) In products
            Dim prodItem As ProductItem = prodItemKvp.Value
            Dim rowValue() As String = {prodItem.Barcode, prodItem.ItemName, prodItem.Price, prodItem.Quantity}
            ProductDataGridView.Rows.Add(rowValue)
        Next
    End Sub

    Private Sub ProductDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles ProductDataGridView.SelectionChanged
        Dim selectedIndex As Integer = ProductDataGridView.SelectedRows.Count
        EditItemBtn.Enabled = selectedIndex > 0
        DeleteItemBtn.Enabled = selectedIndex > 0
        RestockBtn.Enabled = selectedIndex > 0
    End Sub

    Private Sub RestockBtn_Click(sender As Object, e As EventArgs) Handles RestockBtn.Click
        Dim selectedIndex As Integer = ProductDataGridView.SelectedRows(0).Index

        If selectedIndex >= 0 Then
            selectedProductItem = ProductDataGridView.Rows(selectedIndex).Cells(0).Value
            Dim result As DialogResult = New RestockDialog().ShowDialog(Me)

            If result = DialogResult.OK Then
                PopulateDataGridView()
            End If
        End If
    End Sub

    Private Sub EditItemBtn_Click(sender As Object, e As EventArgs) Handles EditItemBtn.Click
        Dim selectedIndex As Integer = ProductDataGridView.SelectedRows(0).Index

        If selectedIndex >= 0 Then
            selectedProductItem = ProductDataGridView.Rows(selectedIndex).Cells(0).Value
            Dim result As DialogResult = New EditStockDialog().ShowDialog(Me)

            If result = DialogResult.OK Then
                PopulateDataGridView()
            End If
        End If
    End Sub

    Private Sub DeleteItemBtn_Click(sender As Object, e As EventArgs) Handles DeleteItemBtn.Click
        Dim selectedIndex As Integer = ProductDataGridView.SelectedRows(0).Index

        If selectedIndex >= 0 Then
            selectedProductItem = ProductDataGridView.Rows(selectedIndex).Cells(0).Value

            Dim result As DialogResult = MessageBox.Show(Me, "Remove product item " + selectedProductItem + "?", "Remove product item", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                If products.Remove(selectedProductItem) Then
                    MessageBox.Show(Me, "Product item removed successfully.", "Remove product item", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PopulateDataGridView()
                Else
                    MessageBox.Show(Me, "Failed to remove product item.", "Remove product item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End If
    End Sub

End Class