Public Class FrmStudentDB

    Private Sub addCombo()
        With cbxTitle
            .Items.Clear()
            .Items.Add("นาย")
            .Items.Add("นาง")
            .Items.Add("นางสาว")
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub FrmStudentDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        addCombo()
    End Sub
End Class
