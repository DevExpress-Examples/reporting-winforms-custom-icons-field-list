Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.XtraReports.UserDesigner

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
		Public Overrides Function CreateImageCollection() As DevExpress.Utils.ImageCollection
			Dim result As ImageCollection = MyBase.CreateImageCollection()
			Dim image As Image = ResourceImageHelper.CreateBitmapFromResources("FieldListCustomIcons.DataPickerImage.png", GetType(CustomColumnImageProvider).Assembly)

			result.AddImage(image)
			categoryNameIndex = result.Images.Count - 1

			Return result
		End Function
	End Class
End Namespace
