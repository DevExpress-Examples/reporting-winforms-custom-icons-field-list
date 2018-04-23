Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
' ...

Namespace FieldListCustomIcons
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			DevExpress.Data.Browsing.Design.ColumnImageProvider.Instance = New CustomColumnImageProvider()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim report As New XtraReport1()
			Dim designTool As New ReportDesignTool(report)
			designTool.ShowDesignerDialog()
		End Sub
	End Class
End Namespace