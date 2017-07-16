Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DT As New DataTable
        DT.Columns.Add("اسامي نفرات")
        For i = 1 To 50
            DT.Rows().Add("شماره  " & i)
        Next
        TransparentDGV1.DataSource = DT
    End Sub
    Private Sub TransparentDGV1_Scroll_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles TransparentDGV1.Scroll
        TransparentDGV1.SelectAll()
    End Sub
End Class