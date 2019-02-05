Imports DevExpress.Mvvm

Namespace CellStyleExample
    Public Class Order
        Inherits BindableBase


        Protected _OrderId As Integer
        Public Property OrderId() As Integer
            Get
                Return Me._OrderId
            End Get
            Set(ByVal value As Integer)
                Me.SetProperty(Me._OrderId, value, "OrderId")
            End Set
        End Property

        Protected _CustomerName As String
        Public Property CustomerName() As String
            Get
                Return Me._CustomerName
            End Get
            Set(ByVal value As String)
                Me.SetProperty(Me._CustomerName, value, "CustomerName")
            End Set
        End Property


        Protected _Quantity As Integer
        Public Property Quantity() As Integer
            Get
                Return Me._Quantity
            End Get
            Set(ByVal value As Integer)
                Me.SetProperty(Me._Quantity, value, "Quantity")
            End Set
        End Property


        Protected _Price As Double
        Public Property Price() As Double
            Get
                Return Me._Price
            End Get
            Set(ByVal value As Double)
                Me.SetProperty(Me._Price, value, "Price")
            End Set
        End Property

    End Class
End Namespace
