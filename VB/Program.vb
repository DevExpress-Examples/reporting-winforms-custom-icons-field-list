Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace FieldListCustomIcons
	Friend Module Program

		<STAThread>
		Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub
	End Module
End Namespace