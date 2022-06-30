Public Class CartItem

    Private iProductItem As ProductItem
    Private iQuantity As Integer
    Private iSubTotal As Decimal

    Sub New(mProductItem As ProductItem, mQuantity As Integer, mSubtotal As Decimal)
        iProductItem = mProductItem
        iQuantity = mQuantity
        iSubTotal = mSubtotal
    End Sub

    Public Property ProductItem As ProductItem
        Get
            Return iProductItem
        End Get
        Set(value As ProductItem)
            iProductItem = value
        End Set
    End Property

    Public Property Quantity As Integer
        Get
            Return iQuantity
        End Get
        Set(value As Integer)
            iQuantity = value
        End Set
    End Property

    Public Property SubTotal As Decimal
        Get
            Return iSubTotal
        End Get
        Set(value As Decimal)
            iSubTotal = value
        End Set
    End Property

End Class
