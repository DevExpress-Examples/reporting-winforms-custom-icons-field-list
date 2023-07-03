Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

' ...
Namespace FieldListCustomIcons

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            DevExpress.Data.Browsing.Design.ColumnImageProvider.Instance = New CustomColumnImageProvider()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim report As XtraReport1 = New XtraReport1()
            Dim designTool As ReportDesignTool = New ReportDesignTool(report)
            designTool.ShowDesignerDialog()
        End Sub
    End Class
End Namespace
