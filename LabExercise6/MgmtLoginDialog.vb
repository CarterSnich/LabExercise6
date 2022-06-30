Imports LabExercise4.AppGlobals

Public Class MgmtLoginDialog

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim password As String = PasswordTextbox.Text

        If password = "" Then
            MessageBox.Show(Me, "Please, fill-up all fields.", "Administrator login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If PasswordTextbox.Text = AdminPassword Then
                DialogResult = DialogResult.OK
            Else
                MessageBox.Show(Me, "Incorrect password.", "Administrator login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

End Class