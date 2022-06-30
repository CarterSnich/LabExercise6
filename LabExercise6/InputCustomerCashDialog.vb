Public Class InputCustomerCashDialog

    Public totalPayment As Decimal
    Public customerCash As Decimal

    Sub New(mTotalPayment As Decimal)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        totalPayment = mTotalPayment
        PaymentLabel.Text = String.Format("P {0}", totalPayment)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim customerCashInput As String = CustomerCashTextbox.Text

        If Decimal.TryParse(customerCashInput, customerCash) Then
            If customerCash >= totalPayment Then
                DialogResult = DialogResult.OK
            Else
                MessageBox.Show(Me, "Insufficient amount.", "Input payment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                CustomerCashTextbox.Text = ""
            End If
        Else
            MessageBox.Show(Me, "Please, enter a valid cash value.", "Input payment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CustomerCashTextbox.Text = ""
        End If

    End Sub

    Private Sub InputCustomerCashForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If DialogResult = DialogResult.OK Then
            Return
        End If

        Dim result As DialogResult = MessageBox.Show(Me, "Cancel transaction?", "Input payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            DialogResult = DialogResult.Cancel
        Else
            CustomerCashTextbox.Focus()
        End If
    End Sub
End Class