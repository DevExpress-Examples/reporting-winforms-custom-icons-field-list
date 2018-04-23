Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UserDesigner

Namespace FieldListCustomIcons
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			FieldListService.Instance = New CustomFieldListService()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			CType(New XtraReport1(), XtraReport1).ShowDesignerDialog()
		End Sub
	End Class
End Namespace