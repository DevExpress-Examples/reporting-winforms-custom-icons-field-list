Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.XtraReports.UserDesigner

Namespace FieldListCustomIcons

	Friend Class CustomFieldListService
		Inherits FieldListService
		Private categoryNameIndex As Integer

		Public Overrides Function GetColumnImageIndex(ByVal [property] As PropertyDescriptor, ByVal dataMember As String, ByVal isList As Boolean) As Integer

			If dataMember.Contains("CategoryName") Then
				Return categoryNameIndex
			End If

			Return MyBase.GetColumnImageIndex([property], dataMember, isList)
		End Function

		Public Overrides Function CreateImageCollection() As DevExpress.Utils.ImageCollection
			Dim result As ImageCollection = MyBase.CreateImageCollection()
			Dim image As Image = ResourceImageHelper.CreateBitmapFromResources("FieldListCustomIcons.DataPickerImage.png", GetType(CustomFieldListService).Assembly)

			result.AddImage(image)
			categoryNameIndex = result.Images.Count - 1

			Return result
		End Function
	End Class
End Namespace
