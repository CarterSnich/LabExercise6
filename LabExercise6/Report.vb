Public Class Report

    Private _transactionCode As String
    Private _customerName As String
    Private _transactionDateTime As Date
    Private _cashierAttendee As String
    Private _purchases As List(Of CartItem)
    Private _totalPayment As Decimal
    Private _customerCash As Decimal
    Private _customerChange As Decimal
    Private _receipt As String

    Public Sub New(transactionCode As String, customerName As String, transactionDateTime As Date, cashierAttendee As String, purchases As List(Of CartItem), totalPayment As Decimal, customerCash As Decimal, customerChange As Decimal, receipt As String)
        _transactionCode = transactionCode
        _customerName = customerName
        _transactionDateTime = transactionDateTime
        _cashierAttendee = cashierAttendee
        _purchases = purchases
        _totalPayment = totalPayment
        _customerCash = customerCash
        _customerChange = customerChange
        _receipt = receipt
    End Sub

    Public Property CustomerName As String
        Get
            Return _customerName
        End Get
        Set(value As String)
            _customerName = value
        End Set
    End Property

    Public Property TransactionDateTime As Date
        Get
            Return _transactionDateTime
        End Get
        Set(value As Date)
            _transactionDateTime = value
        End Set
    End Property

    Public Property CashierAttendee As String
        Get
            Return _cashierAttendee
        End Get
        Set(value As String)
            _cashierAttendee = value
        End Set
    End Property

    Public Property Purchases As List(Of CartItem)
        Get
            Return _purchases
        End Get
        Set(value As List(Of CartItem))
            _purchases = value
        End Set
    End Property

    Public Property TotalPayment As Decimal
        Get
            Return _totalPayment
        End Get
        Set(value As Decimal)
            _totalPayment = value
        End Set
    End Property

    Public Property CustomerCash As Decimal
        Get
            Return _customerCash
        End Get
        Set(value As Decimal)
            _customerCash = value
        End Set
    End Property

    Public Property CustomerChange As Decimal
        Get
            Return _customerChange
        End Get
        Set(value As Decimal)
            _customerChange = value
        End Set
    End Property

    Public Property Receipt As String
        Get
            Return _receipt
        End Get
        Set(value As String)
            _receipt = value
        End Set
    End Property

    Public Property TransactionCode As String
        Get
            Return _transactionCode
        End Get
        Set(value As String)
            _transactionCode = value
        End Set
    End Property
End Class
