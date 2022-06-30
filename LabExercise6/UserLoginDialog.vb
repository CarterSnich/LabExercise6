Imports LabExercise4.AppGlobals

Public Class UserLoginDialog

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UsernameTextBox.Focus()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim username As String = UsernameTextBox.Text
        Dim password As String = PasswordTextBox.Text

        If username = "" Or password = "" Then
            MessageBox.Show(Me, "Please, fill-up all fields.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If cashiers.ContainsKey(username) Then
                Dim cashierPassword As String = cashiers.Item(username)
                If cashierPassword = password Then
                    currentCashierUsername = username
                    DialogResult = DialogResult.OK
                Else
                    MessageBox.Show(Me, "Incorrect password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    PasswordTextBox.Text = ""
                    PasswordTextBox.Focus()
                End If
            Else
                MessageBox.Show(Me, "Username not found.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
                UsernameTextBox.Focus()
            End If
        End If

    End Sub
End Class