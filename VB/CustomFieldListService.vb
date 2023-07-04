Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.Utils.Svg

Namespace FieldListCustomIcons

    Friend Class CustomColumnImageProvider
        Inherits DevExpress.Data.Browsing.Design.ColumnImageProvider

        Private categoryNameIndex As Integer

        Public Overrides Function GetColumnImageIndex(ByVal [property] As PropertyDescriptor, ByVal specifics As DevExpress.Data.Browsing.Design.TypeSpecifics) As Integer
            If [property].Name.Equals("CategoryName") Then Return categoryNameIndex
            Return MyBase.GetColumnImageIndex([property], specifics)
        End Function

        Public Overrides Function CreateSvgImageCollection() As SvgImageCollection
            Dim result As SvgImageCollection = MyBase.CreateSvgImageCollection()
            Dim image As SvgImage = New SvgImage(GetType(CustomColumnImageProvider), "FieldListCustomIcons.StarIcon.svg")
            result.Add(image)
            categoryNameIndex = result.Count - 1
            Return result
        End Function
    End Class
End Namespace
