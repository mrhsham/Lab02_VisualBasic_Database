Public Class Report

    Dim rpt As New CrystalReport1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox3.Text = "" Then
            MessageBox.Show("กรุณาป้อนข้อมูล 'ตัวเลข' ลงในกล่องข้อความ .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox3.Text = "0"
        End If

        rpt.RecordSelectionFormula = "{StudentDetail.SNo} = " & TextBox3.Text
        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox1.Text = "" Then
            MessageBox.Show("กรุณาป้อนข้อมูล 'ตัวเลข' ลงในกล่องข้อความ .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Text = "0"
        End If

        If TextBox2.Text = "" Then
            TextBox2.Text = "0"
        End If


        rpt.RecordSelectionFormula = "{StudentDetail.SNo} in " & TextBox1.Text & " to " & TextBox2.Text
        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        rpt.RecordSelectionFormula = "{StudentDetail.SNo} > 1 "
        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If IsNumeric(TextBox3.Text) = False And TextBox3.Text <> "" Then
            MessageBox.Show("ป้อนข้อมูลเฉพาะตัวเลขเท่านั้น.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox3.Text = ""
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(TextBox1.Text) = False And TextBox1.Text <> "" Then
            MessageBox.Show("ป้อนข้อมูลเฉพาะตัวเลขเท่านั้น.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If IsNumeric(TextBox2.Text) = False And TextBox2.Text <> "" Then
            MessageBox.Show("ป้อนข้อมูลเฉพาะตัวเลขเท่านั้น.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox2.Text = ""
        End If
    End Sub
End Class