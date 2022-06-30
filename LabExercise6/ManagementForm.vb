Public Class ManagementForm

    Private currentForm As Type = Nothing

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Application.EnableVisualStyles()
    End Sub

    Private Sub PosBtn_Click(sender As Object, e As EventArgs) Handles PosBtn.Click
        If Not currentForm = PosForm.GetType() Then
            If New UserLoginDialog().ShowDialog(Me) = DialogResult.OK Then
                DisplayForm(New PosForm())
            End If
        End If
    End Sub

    Private Sub StocksBtn_Click(sender As Object, e As EventArgs) Handles StocksBtn.Click
        If Not currentForm = StocksForm.GetType() Then
            If New MgmtLoginDialog().ShowDialog(Me) = DialogResult.OK Then
                DisplayForm(New StocksForm())
            End If
        End If
    End Sub

    Private Sub MngUsersBtn_Click(sender As Object, e As EventArgs) Handles MngUsersBtn.Click
        If Not currentForm = UsersMgmtForm.GetType() Then
            If New MgmtLoginDialog().ShowDialog(Me) = DialogResult.OK Then
                DisplayForm(New UsersMgmtForm())
            End If
        End If
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Close()
    End Sub

    Private Sub ManagementForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show(Me, "Are you sure to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        e.Cancel = True
        If result = DialogResult.OK Then
            e.Cancel = False
        End If
    End Sub

    Private Sub ReportsBtn_Click(sender As Object, e As EventArgs) Handles ReportsBtn.Click
        If Not currentForm = ReportsForm.GetType() Then
            If New MgmtLoginDialog().ShowDialog(Me) = DialogResult.OK Then
                DisplayForm(New ReportsForm())
            End If
        End If
    End Sub

    Private Sub DisplayForm(form As Object)
        currentForm = form.GetType()
        form.TopLevel = False
        form.AutoScroll = True
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = WindowState.Maximized

        FormPanel.Controls.Clear()
        FormPanel.Controls.Add(form)
        form.Show()
    End Sub
End Class