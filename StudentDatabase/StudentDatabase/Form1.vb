Imports System.Data.Odbc

Public Class FrmStudentDB
    Enum commandStatusEnum
        None = 0
        Create = 1
        Edit = 2
    End Enum

    Dim con As OdbcConnection
    Dim myCommand As commandStatusEnum = commandStatusEnum.None

    Private Function CreateConnection() As Boolean
        Dim rslRtn As Boolean = True
        con = New OdbcConnection()
            Dim conStr As String = "Driver={Microsoft Access Driver (*.mdb)}; DBQ=TestDB.mdb;UID=;PWD=;"
            con.ConnectionString = conStr
        con.Open()
        Return rslRtn
    End Function

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

        If CreateConnection() = False Then
            End
        End If
    End Sub
End Class
