Imports LabExercise4.AppGlobals

Public Class AddUserDialog
    Private Sub SaveUserBtn_Click(sender As Object, e As EventArgs) Handles SaveUserBtn.Click
        Dim username As String = UsernameTextBox.Text
        Dim password As String = PasswordTextBox.Text
        Dim confirmPassword As String = ConfPwTextbox.Text

        If username = "" Or password = "" Or confirmPassword = "" Then
            MessageBox.Show(Me, "Please, fill-up all fields.", "Add cashier", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf cashiers.ContainsKey(username) = True Then
            MessageBox.Show(Me, "Username already exist.", "Add cashier", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            ConfPwTextbox.Text = ""
        Else
            If password = confirmPassword Then
                cashiers.Add(username, password)

                MessageBox.Show(Me, "Cashier saved successfully.", "Add cashier", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = DialogResult.OK
            Else
                MessageBox.Show(Me, "Password does not match.", "Add cashier", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                PasswordTextBox.Text = ""
                ConfPwTextbox.Text = ""
            End If
        End If
    End Sub
End Class