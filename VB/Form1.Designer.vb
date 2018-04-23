Imports Microsoft.VisualBasic
Imports System
Namespace BindWinFormsControl
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.PreviewButton = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' PreviewButton
			' 
			Me.PreviewButton.Location = New System.Drawing.Point(75, 82)
			Me.PreviewButton.Name = "PreviewButton"
			Me.PreviewButton.Size = New System.Drawing.Size(131, 83)
			Me.PreviewButton.TabIndex = 0
			Me.PreviewButton.Text = "Preview"
			Me.PreviewButton.UseVisualStyleBackColor = True
'			Me.PreviewButton.Click += New System.EventHandler(Me.PreviewButton_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(284, 264)
			Me.Controls.Add(Me.PreviewButton)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents PreviewButton As System.Windows.Forms.Button
	End Class
End Namespace

