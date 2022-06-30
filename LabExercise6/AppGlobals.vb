Public Class AppGlobals

    Public Shared ReadOnly cashiers As New Dictionary(Of String, String)
    Public Shared ReadOnly products As New Dictionary(Of String, ProductItem)
    Public Shared ReadOnly reports As New Dictionary(Of String, Report)

    Public Shared ReadOnly AdminPassword As String = "admin"

    Public Shared currentCashierUsername As String

    Public Shared ReadOnly dummy As New AppGlobals()

    Sub New()
        cashiers.Add("joemar", "123")
        products.Add("APP-001", New ProductItem("APP-001", "Apple", 20.0, 1000))
        products.Add("ORA-002", New ProductItem("ORA-002", "Orange", 30.0, 500))
    End Sub

End Class
