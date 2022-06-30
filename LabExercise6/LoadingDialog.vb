Public Class LoadingDialog

    Private ReasonToClose As Integer = CloseReason.None

    Sub New(mMessage As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ControlBox = False
        MessageLabel.Text = mMessage
    End Sub

    Public Sub CloseDialog(reason As CloseReason)
        ReasonToClose = reason
        Close()
    End Sub

    Private Sub LoadingDialog_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = Not ReasonToClose = CloseReason.ApplicationExitCall
    End Sub

End Class