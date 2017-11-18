Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestDBDataSet.StudentDetail' table. You can move, or remove it, as needed.
        Me.StudentDetailTableAdapter.Fill(Me.TestDBDataSet.StudentDetail)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class