
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

    Private Function isIDinDatabase(myID As String) As Boolean
        Dim _tmpTbl As DataTable
        Dim myQuery As String = "SELECT * FROM StudentDetail WHERE SID = '" & tbxID.Text & "'"

        _tmpTbl = Nothing
        _tmpTbl = GetDataTable(myQuery)

        If _tmpTbl.Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

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

    Private Sub ExecuteQuery(ByVal SQL As String)
        CheckConnection()
        Dim cmd As New OdbcCommand(SQL, con)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub Delete()
        With DataGridView1
            If .SelectedRows.Count = 0 Then
                MessageBox.Show("กรุณาเลือกเรคอร์ดที่ต้องการลบ!", "Student Database",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            If MessageBox.Show("ต้องการลบหรือไม่?", "ลบเรคอร์ด", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim query = "DELETE FROM StudentDetail WHERE SID = '" & .Rows(.CurrentRow.Index).Cells("DGVID").Value & "'"
                ExecuteQuery(query)
                MessageBox.Show("ลบชื่อข้อมูลเรียบร้อยแล้ว!", "Student Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
                reloadDatabase()
            End If
        End With
    End Sub

    Private Sub Save()
        With DataGridView1
            Dim myQuery As String = String.Empty
            If myCommand = commandStatusEnum.Create Then
                myQuery = "INSERT INTO StudentDetail(SID, STitle, SName, SSirname, STelephone, SLineID, SMemo)"
                myQuery &= " VALUES ('" & tbxID.Text & "','" & cbxTitle.Text & "','" & tbxName.Text & "','"
                myQuery &= tbxSirname.Text & "','" & tbxTelephone.Text & "','" & tbxLineID.Text & "','" & tbxMemo.Text & "')"
                ExecuteQuery(myQuery)
                MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว!", "Student Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf myCommand = commandStatusEnum.Edit Then
                myQuery = "UPDATE StudentDetail SET STitle = '" & cbxTitle.Text & "',SName = '"
                myQuery &= tbxName.Text & "', SSirname = '" & tbxSirname.Text & "', STelephone = '"
                myQuery &= tbxTelephone.Text & "', SLineID = '" & tbxLineID.Text & "', SMemo = '" & tbxMemo.Text & "'"
                myQuery &= " WHERE SID = '" & tbxID.Text & "'"

                ExecuteQuery(myQuery)
                MessageBox.Show("ปรับปรุงข้อมูลเรียบร้อยแล้ว!", "Student Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
                .Enabled = True
            End If
        End With
        myCommand = commandStatusEnum.None
        reloadDatabase()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            With DataGridView1
                If DataGridView1.CurrentRow IsNot Nothing Then
                    selectDatagridRow(.CurrentRow.Index)
                    enableButton(True, True, False, True)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Student Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        clearDataInControl()
        enableAllControl(True)
        enableButton(False, False, True, False)
        DataGridView1.Enabled = False
        myCommand = commandStatusEnum.Create
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        enableAllControl(True)
        DataGridView1.Enabled = False
        enableButton(False, False, True, False)
        tbxID.Enabled = False
        myCommand = commandStatusEnum.Edit
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If myCommand = commandStatusEnum.Create Then
            If tbxID.Text <> "" Then
                If isIDinDatabase(tbxID.Text) = True Then
                    MessageBox.Show("รหัสนักศึกษา " & tbxID.Text & "นี้ มีในฐานข้อมูลแล้ว กรุณาระบุใหม่", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    tbxID.Focus()
                    tbxID.SelectionStart = 0
                    tbxID.SelectionLength = tbxID.Text.Length
                Else
                    Save()
                End If
            Else
                Dim dlg As DialogResult
                dlg = MessageBox.Show("คลิกปุ่ม Yes เพื่อยกเลิก" & vbCrLf & "คลิกปุ่ม No เพื่อแก้ไขรหัสนักศึกษาใหม่",
                                  "ยกเลิก", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dlg = DialogResult.Yes Then
                    reloadDatabase()
                Else
                    tbxID.Focus()
                End If
            End If
        ElseIf myCommand = commandStatusEnum.Edit Then
            Save()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Delete()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub FrmStudentDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        addCombo()

        If CreateConnection() = False Then
            End
        End If

        reloadDatabase()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Report.Show()
    End Sub

    Private Sub pbxImage_Click(sender As Object, e As EventArgs) Handles pbxImage.Click

    End Sub
End Class
