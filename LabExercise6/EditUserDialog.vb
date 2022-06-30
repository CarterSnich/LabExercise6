Imports LabExercise4.AppGlobals

Public Class EditUserDialog
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim username As String = UsersMgmtForm.rowSelectedUsername
        Dim oldPassword As String = OldPasswordTextBox.Text
        Dim newPassword As String = NewPasswordTextBox.Text
        Dim confirmPassword As String = ConfPwTextBox.Text

        Dim currentPassword As String = cashiers.Item(username)

        If oldPassword = "" Or newPassword = "" Or confirmPassword = "" Then
            MessageBox.Show(Me, "Please, fill-up all fields.", "Edit cashier", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If newPassword = confirmPassword Then
                If oldPassword = currentPassword Then
                    cashiers.Item(username) = newPassword

                    MessageBox.Show(Me, "Cashier '" + username + "' saved successfully.", "Edit cashier", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DialogResult = DialogResult.OK
                Else
                    MessageBox.Show(Me, "Incorrect password.", "Edit cashier", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show(Me, "Password does not match.", "Edit cashier", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

        OldPasswordTextBox.Text = ""
        NewPasswordTextBox.Text = ""
        ConfPwTextBox.Text = ""
    End Sub
End Class