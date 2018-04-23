Public Class XtraReport1

    Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
        Button1.Text = GetCurrentColumnValue("CategoryName").ToString()
    End Sub
End Class