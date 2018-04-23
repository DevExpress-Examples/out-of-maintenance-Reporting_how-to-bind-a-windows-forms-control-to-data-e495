Public Class Form1

    Private Sub PreviewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviewButton.Click
        Dim report As New XtraReport1()
        report.ShowPreview()
    End Sub
End Class
