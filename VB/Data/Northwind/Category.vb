Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations.Schema

Namespace DataMappings.Data.Northwind

    Public Partial Class Category

        Public Sub New()
            Products = New HashSet(Of Product)()
        End Sub

        Public Property CategoryId As Integer

        Public Property CategoryName As String

        Public Property Description As String

        Public Property Picture As Byte()

        <NotMapped>
        Public Property HasProducts As Boolean = True

        Public Overridable Property Products As ICollection(Of Product)
    End Class
End Namespace
