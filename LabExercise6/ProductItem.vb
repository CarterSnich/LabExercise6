Public Class ProductItem

    Public Barcode As String
    Public ItemName As String
    Public Price As Decimal
    Public Quantity As Integer

    Sub New(mBarcode As String, mItemName As String, mPrice As Decimal, mQuantity As Integer)
        Barcode = mBarcode
        ItemName = mItemName
        Price = mPrice
        Quantity = mQuantity
    End Sub

End Class
