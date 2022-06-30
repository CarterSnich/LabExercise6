Public Class ReportsForm
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For Each reportKvp As KeyValuePair(Of String, Report) In AppGlobals.reports
            ReportsDataGrid.Rows.Add(
                New String() {
                    reportKvp.Key,
                    reportKvp.Value.TransactionDateTime.ToString(),
                    reportKvp.Value.CustomerName
                }
            )
        Next
    End Sub

    Private Sub ReportsDataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ReportsDataGrid.CellDoubleClick
        Dim selectionRowIndex As Integer = ReportsDataGrid.SelectedCells(0).RowIndex
        Dim transactionCode As String = ReportsDataGrid.Rows.Item(selectionRowIndex).Cells(0).Value
        Dim receipt As String

        If selectionRowIndex >= 0 Then
            receipt = AppGlobals.reports.Item(transactionCode).Receipt
            ReceiptLabel.Text = receipt
        End If
    End Sub
End Class