Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace BindWinFormsControl
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub PreviewButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PreviewButton.Click
			Dim report As New XtraReport1()

			Dim printTool As New ReportPrintTool(report)
			printTool.ShowPreview()
		End Sub
	End Class
End Namespace