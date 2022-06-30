Imports LabExercise4.AppGlobals

Public Class UsersMgmtForm
    Public Shared rowSelectedUsername As String

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PopulateDataGridView()
    End Sub

    Public Sub PopulateDataGridView()
        UsersDataGridView.Rows.Clear()

        Dim i As Integer = 1
        For Each cashierUsername As String In cashiers.Keys
            UsersDataGridView.Rows.Add(New String() {i, cashierUsername})
            i += 1
        Next
    End Sub

    Private Sub UsersDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles UsersDataGridView.SelectionChanged
        Dim enable As Boolean = UsersDataGridView.SelectedRows.Count > 0
        EditUserBtn.Enabled = enable
        DeleteUserBtn.Enabled = enable
    End Sub

    Private Sub NewUserBtn_Click(sender As Object, e As EventArgs) Handles NewUserBtn.Click
        Dim addUserForm As New AddUserDialog()
        Dim result As DialogResult = addUserForm.ShowDialog(Me)

        If result = DialogResult.OK Then
            PopulateDataGridView()
        End If
    End Sub

    Private Sub EditUserBtn_Click(sender As Object, e As EventArgs) Handles EditUserBtn.Click
        If UsersDataGridView.SelectedRows.Count > 0 Then
            Dim rowIndex As Integer = UsersDataGridView.SelectedRows.Item(0).Index
            rowSelectedUsername = UsersDataGridView.Rows(rowIndex).Cells(1).Value

            Dim result As DialogResult = New EditUserDialog().ShowDialog(Me)
            If result = DialogResult.OK Then
                PopulateDataGridView()
            End If
        End If
    End Sub

    Private Sub DeleteUserBtn_Click(sender As Object, e As EventArgs) Handles DeleteUserBtn.Click
        If UsersDataGridView.SelectedRows.Count > 0 Then
            Dim rowIndex As Integer = UsersDataGridView.SelectedRows.Item(0).Index
            Dim username = UsersDataGridView.Rows(rowIndex).Cells(1).Value

            Dim result As DialogResult = MessageBox.Show(Me, String.Format("Delete {0}?", username), "Delete cashier", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                cashiers.Remove(username)
                PopulateDataGridView()
            End If
        End If
    End Sub
End Class