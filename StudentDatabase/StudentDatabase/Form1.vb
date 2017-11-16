
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
        Try
            con = New OdbcConnection()
            Dim conStr As String = "Driver={Microsoft Access Driver (*.mdb)}; DBQ=TestDB.mdb;UID=;PWD=;"
            con.ConnectionString = conStr
            con.Open()
        Catch ex As Exception
            rslRtn = False
            MessageBox.Show("ไม่สามารถเชื่อมต่อกับฐานข้อมูลได้ เนื่องจาก : " & ex.Message.ToString &
                            vbCrLf & "โปรแกรมจะปิดตัวเองอัตโนมัติ")
        End Try
        Return rslRtn
    End Function

    Private Sub CheckConnection()
        If con Is Nothing OrElse con.State = ConnectionState.Closed Then
            CreateConnection()
        End If
    End Sub

    Private Function GetDataTable(ByVal mySQL As String) As DataTable
        CheckConnection()

        Dim cmd As OdbcCommand = New OdbcCommand(mySQL, con)
        Dim table As DataTable = New DataTable

        Dim da As OdbcDataAdapter = New OdbcDataAdapter(cmd)

        da.Fill(table)

        Return table
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

    Private Sub enableAllControl(isEnable As Boolean)
        tbxID.Enabled = isEnable
        cbxTitle.Enabled = isEnable
        tbxName.Enabled = isEnable
        tbxSirname.Enabled = isEnable
        tbxTelephone.Enabled = isEnable
        tbxLineID.Enabled = isEnable
        tbxMemo.Enabled = isEnable
        DataGridView1.Enabled = isEnable
        btnCreate.Enabled = isEnable
        btnEdit.Enabled = isEnable
        BtnSave.Enabled = isEnable

    End Sub

    Private Sub enableButton(isCreate As Boolean, isEdit As Boolean, isSave As Boolean, isDelete As Boolean)
        btnCreate.Enabled = isCreate
        btnEdit.Enabled = isEdit
        BtnSave.Enabled = isSave
        btnDelete.Enabled = isDelete
    End Sub

    Private Sub clearDataInControl()
        tbxID.Text = ""
        cbxTitle.SelectedIndex = 0
        tbxName.Text = ""
        tbxSirname.Text = ""
        tbxTelephone.Text = ""
        tbxLineID.Text = ""
        tbxMemo.Text = ""

    End Sub

    Private Sub selectDatagridRow(index As Integer)
        With DataGridView1
            .Rows(index).Selected = True
            tbxID.Text = .Rows(index).Cells("DGVID").Value
            cbxTitle.Text = .Rows(index).Cells("DGVTitle").Value
            tbxName.Text = .Rows(index).Cells("DGVName").Value
            tbxSirname.Text = .Rows(index).Cells("DGVSirname").Value
            tbxTelephone.Text = .Rows(index).Cells("DGVTelephone").Value
            tbxLineID.Text = .Rows(index).Cells("DGVLineID").Value
            tbxMemo.Text = .Rows(index).Cells("DGVMemo").Value
        End With
    End Sub

    Private Function LoadDBData() As Integer
        Dim _tmpTbl As DataTable
        Dim myQuery As String = "SELECT * FROM StudentDetail ORDER BY SID"

        _tmpTbl = Nothing
        _tmpTbl = GetDataTable(myQuery)

        Dim rowCount As Integer = 1
        With DataGridView1
            .Rows.Clear()
            For Each dtRow In _tmpTbl.Rows
                .Rows.Add()
                .Rows(.RowCount - 1).Cells("DGVIndex").Value = rowCount.ToString()
                .Rows(.RowCount - 1).Cells("DGVID").Value = dtRow("SID").ToString()
                .Rows(.RowCount - 1).Cells("DGVTitle").Value = dtRow("STitle").ToString()
                .Rows(.RowCount - 1).Cells("DGVName").Value = dtRow("SName").ToString()
                .Rows(.RowCount - 1).Cells("DGVSirname").Value = dtRow("SSirname").ToString()
                .Rows(.RowCount - 1).Cells("DGVTelephone").Value = dtRow("STelephone").ToString()
                .Rows(.RowCount - 1).Cells("DGVLineID").Value = dtRow("SLineID").ToString()
                .Rows(.RowCount - 1).Cells("DGVMemo").Value = dtRow("SMemo").ToString()

                rowCount += 1
            Next
            rowCount -= 1
            .ClearSelection()
        End With
        Return rowCount
    End Function

    Private Sub reloadDatabase()
        enableAllControl(False)
        If LoadDBData() > 0 Then
            selectDatagridRow(0)
            DataGridView1.Enabled = True
            enableButton(True, True, False, True)
        Else
            clearDataInControl()
            enableButton(True, False, False, False)
        End If
    End Sub

    Private Sub FrmStudentDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        addCombo()

        If CreateConnection() = False Then
            End
        End If

        reloadDatabase()
    End Sub


End Class
