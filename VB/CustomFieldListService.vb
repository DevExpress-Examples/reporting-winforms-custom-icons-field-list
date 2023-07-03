Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.XtraReports.UserDesigner
Imports DevExpress.Utils.Svg

Namespace FieldListCustomIcons

	Friend Class CustomColumnImageProvider
		Inherits DevExpress.Data.Browsing.Design.ColumnImageProvider

		Private categoryNameIndex As Integer

		Public Overrides Function GetColumnImageIndex(ByVal [property] As PropertyDescriptor, ByVal specifics As DevExpress.Data.Browsing.Design.TypeSpecifics) As Integer
			If [property].Name.Equals("CategoryName") Then
				Return categoryNameIndex
			End If
			Return MyBase.GetColumnImageIndex([property], specifics)
		End Function
		Public Overrides Function CreateSvgImageCollection() As SvgImageCollection
			Dim result As SvgImageCollection = MyBase.CreateSvgImageCollection()
			Dim image = SvgImage.FromResources("FieldListCustomIcons.StarIcon.svg", GetType(CustomColumnImageProvider).Assembly)

			result.Add(image)
			categoryNameIndex = result.Count - 1

			Return result
		End Function

	End Class
End Namespace
