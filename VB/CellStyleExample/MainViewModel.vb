Imports DevExpress.Mvvm
Imports System
Imports System.Collections.ObjectModel
Imports System.Linq

Namespace CellStyleExample
    Public Class MainViewModel
        Inherits ViewModelBase


        Protected _Items As ObservableCollection(Of Order)
        Public ReadOnly Property Items() As ObservableCollection(Of Order)
            Get
                If Me._Items Is Nothing Then
                    Dim r As New Random()
                    Me._Items = New ObservableCollection(Of Order)(Enumerable.Range(0, 10).Select(Function(c) New Order() With { _
                        .OrderId = 1000 + c, _
                        .CustomerName = "Customer #" & c, _
                        .Price = Math.Round(r.NextDouble() * 100, 2), _
                        .Quantity = r.Next(5) + 1 _
                    }))
                End If

                Return Me._Items
            End Get
        End Property

    End Class
End Namespace
