<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmStudentDB
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DGVIndex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVSirname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVTelephone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVLineID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVMemo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pbxImage = New System.Windows.Forms.PictureBox()
        Me.cbxTitle = New System.Windows.Forms.ComboBox()
        Me.tbxMemo = New System.Windows.Forms.TextBox()
        Me.tbxLineID = New System.Windows.Forms.TextBox()
        Me.tbxTelephone = New System.Windows.Forms.TextBox()
        Me.tbxSirname = New System.Windows.Forms.TextBox()
        Me.tbxName = New System.Windows.Forms.TextBox()
        Me.tbxID = New System.Windows.Forms.TextBox()
        Me.lbxMemo = New System.Windows.Forms.Label()
        Me.lblLineID = New System.Windows.Forms.Label()
        Me.lbxTelephone = New System.Windows.Forms.Label()
        Me.lbxSirname = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGVIndex, Me.DGVID, Me.DGVTitle, Me.DGVName, Me.DGVSirname, Me.DGVTelephone, Me.DGVLineID, Me.DGVMemo})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 349)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(758, 211)
        Me.DataGridView1.TabIndex = 50
        '
        'DGVIndex
        '
        Me.DGVIndex.HeaderText = "ลำดับที่"
        Me.DGVIndex.Name = "DGVIndex"
        Me.DGVIndex.ReadOnly = True
        Me.DGVIndex.Width = 80
        '
        'DGVID
        '
        Me.DGVID.HeaderText = "รหัสนักศึกษา"
        Me.DGVID.Name = "DGVID"
        Me.DGVID.ReadOnly = True
        Me.DGVID.Width = 110
        '
        'DGVTitle
        '
        Me.DGVTitle.HeaderText = "คำนำหน้า"
        Me.DGVTitle.Name = "DGVTitle"
        Me.DGVTitle.ReadOnly = True
        '
        'DGVName
        '
        Me.DGVName.HeaderText = "ชื่อ"
        Me.DGVName.Name = "DGVName"
        Me.DGVName.ReadOnly = True
        Me.DGVName.Width = 180
        '
        'DGVSirname
        '
        Me.DGVSirname.HeaderText = "สกุล"
        Me.DGVSirname.Name = "DGVSirname"
        Me.DGVSirname.ReadOnly = True
        '
        'DGVTelephone
        '
        Me.DGVTelephone.HeaderText = "หมายเลขโทรศัพท์"
        Me.DGVTelephone.Name = "DGVTelephone"
        Me.DGVTelephone.ReadOnly = True
        Me.DGVTelephone.Width = 230
        '
        'DGVLineID
        '
        Me.DGVLineID.HeaderText = "หมายเลข Line"
        Me.DGVLineID.Name = "DGVLineID"
        Me.DGVLineID.ReadOnly = True
        Me.DGVLineID.Width = 150
        '
        'DGVMemo
        '
        Me.DGVMemo.HeaderText = "Memo"
        Me.DGVMemo.Name = "DGVMemo"
        Me.DGVMemo.ReadOnly = True
        Me.DGVMemo.Width = 140
        '
        'pbxImage
        '
        Me.pbxImage.BackColor = System.Drawing.Color.PaleGreen
        Me.pbxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxImage.Location = New System.Drawing.Point(578, 19)
        Me.pbxImage.Name = "pbxImage"
        Me.pbxImage.Size = New System.Drawing.Size(196, 216)
        Me.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxImage.TabIndex = 63
        Me.pbxImage.TabStop = False
        '
        'cbxTitle
        '
        Me.cbxTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbxTitle.FormattingEnabled = True
        Me.cbxTitle.Location = New System.Drawing.Point(14, 98)
        Me.cbxTitle.Name = "cbxTitle"
        Me.cbxTitle.Size = New System.Drawing.Size(97, 28)
        Me.cbxTitle.TabIndex = 44
        '
        'tbxMemo
        '
        Me.tbxMemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxMemo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbxMemo.Location = New System.Drawing.Point(14, 242)
        Me.tbxMemo.Multiline = True
        Me.tbxMemo.Name = "tbxMemo"
        Me.tbxMemo.Size = New System.Drawing.Size(760, 93)
        Me.tbxMemo.TabIndex = 49
        '
        'tbxLineID
        '
        Me.tbxLineID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxLineID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbxLineID.Location = New System.Drawing.Point(172, 171)
        Me.tbxLineID.Name = "tbxLineID"
        Me.tbxLineID.Size = New System.Drawing.Size(166, 26)
        Me.tbxLineID.TabIndex = 48
        '
        'tbxTelephone
        '
        Me.tbxTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbxTelephone.Location = New System.Drawing.Point(14, 171)
        Me.tbxTelephone.Name = "tbxTelephone"
        Me.tbxTelephone.Size = New System.Drawing.Size(152, 26)
        Me.tbxTelephone.TabIndex = 47
        '
        'tbxSirname
        '
        Me.tbxSirname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxSirname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbxSirname.Location = New System.Drawing.Point(300, 99)
        Me.tbxSirname.Name = "tbxSirname"
        Me.tbxSirname.Size = New System.Drawing.Size(214, 26)
        Me.tbxSirname.TabIndex = 46
        '
        'tbxName
        '
        Me.tbxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbxName.Location = New System.Drawing.Point(117, 99)
        Me.tbxName.Name = "tbxName"
        Me.tbxName.Size = New System.Drawing.Size(177, 26)
        Me.tbxName.TabIndex = 45
        '
        'tbxID
        '
        Me.tbxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbxID.Location = New System.Drawing.Point(18, 39)
        Me.tbxID.Name = "tbxID"
        Me.tbxID.Size = New System.Drawing.Size(148, 26)
        Me.tbxID.TabIndex = 43
        '
        'lbxMemo
        '
        Me.lbxMemo.AutoSize = True
        Me.lbxMemo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbxMemo.Location = New System.Drawing.Point(12, 215)
        Me.lbxMemo.Name = "lbxMemo"
        Me.lbxMemo.Size = New System.Drawing.Size(44, 20)
        Me.lbxMemo.TabIndex = 62
        Me.lbxMemo.Text = "อื่นๆ :"
        '
        'lblLineID
        '
        Me.lblLineID.AutoSize = True
        Me.lblLineID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblLineID.Location = New System.Drawing.Point(170, 148)
        Me.lblLineID.Name = "lblLineID"
        Me.lblLineID.Size = New System.Drawing.Size(108, 20)
        Me.lblLineID.TabIndex = 61
        Me.lblLineID.Text = "หมายเลข Line :"
        '
        'lbxTelephone
        '
        Me.lbxTelephone.AutoSize = True
        Me.lbxTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbxTelephone.Location = New System.Drawing.Point(10, 148)
        Me.lbxTelephone.Name = "lbxTelephone"
        Me.lbxTelephone.Size = New System.Drawing.Size(127, 20)
        Me.lbxTelephone.TabIndex = 60
        Me.lbxTelephone.Text = "หมายเลขโทรศัพท์ :"
        '
        'lbxSirname
        '
        Me.lbxSirname.AutoSize = True
        Me.lbxSirname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbxSirname.Location = New System.Drawing.Point(296, 76)
        Me.lbxSirname.Name = "lbxSirname"
        Me.lbxSirname.Size = New System.Drawing.Size(42, 20)
        Me.lbxSirname.TabIndex = 59
        Me.lbxSirname.Text = "สกุล :"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblName.Location = New System.Drawing.Point(115, 76)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(34, 20)
        Me.lblName.TabIndex = 58
        Me.lblName.Text = "ชื่อ :"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblTitle.Location = New System.Drawing.Point(12, 76)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(74, 20)
        Me.lblTitle.TabIndex = 57
        Me.lblTitle.Text = "คำนำหน้า :"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblID.Location = New System.Drawing.Point(14, 16)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(93, 20)
        Me.lblID.TabIndex = 56
        Me.lblID.Text = "รหัสนักศึกษา :"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnExit.Location = New System.Drawing.Point(641, 580)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(133, 45)
        Me.btnExit.TabIndex = 55
        Me.btnExit.Text = "ออก"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnDelete.Location = New System.Drawing.Point(472, 580)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(133, 45)
        Me.btnDelete.TabIndex = 54
        Me.btnDelete.Text = "ลบ"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnSave.Location = New System.Drawing.Point(300, 580)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(133, 45)
        Me.BtnSave.TabIndex = 53
        Me.BtnSave.Text = "บันทึก"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnEdit.Location = New System.Drawing.Point(157, 580)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(133, 45)
        Me.btnEdit.TabIndex = 52
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnCreate.Location = New System.Drawing.Point(18, 580)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(133, 45)
        Me.btnCreate.TabIndex = 51
        Me.btnCreate.Text = "สร้าง"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnPrint.Location = New System.Drawing.Point(472, 195)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 40)
        Me.btnPrint.TabIndex = 64
        Me.btnPrint.Text = "พิมพ์"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'FrmStudentDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 641)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.pbxImage)
        Me.Controls.Add(Me.cbxTitle)
        Me.Controls.Add(Me.tbxMemo)
        Me.Controls.Add(Me.tbxLineID)
        Me.Controls.Add(Me.tbxTelephone)
        Me.Controls.Add(Me.tbxSirname)
        Me.Controls.Add(Me.tbxName)
        Me.Controls.Add(Me.tbxID)
        Me.Controls.Add(Me.lbxMemo)
        Me.Controls.Add(Me.lblLineID)
        Me.Controls.Add(Me.lbxTelephone)
        Me.Controls.Add(Me.lbxSirname)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnCreate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmStudentDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลนักศึกษา"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DGVIndex As DataGridViewTextBoxColumn
    Friend WithEvents DGVID As DataGridViewTextBoxColumn
    Friend WithEvents DGVTitle As DataGridViewTextBoxColumn
    Friend WithEvents DGVName As DataGridViewTextBoxColumn
    Friend WithEvents DGVSirname As DataGridViewTextBoxColumn
    Friend WithEvents DGVTelephone As DataGridViewTextBoxColumn
    Friend WithEvents DGVLineID As DataGridViewTextBoxColumn
    Friend WithEvents DGVMemo As DataGridViewTextBoxColumn
    Friend WithEvents pbxImage As PictureBox
    Friend WithEvents cbxTitle As ComboBox
    Friend WithEvents tbxMemo As TextBox
    Friend WithEvents tbxLineID As TextBox
    Friend WithEvents tbxTelephone As TextBox
    Friend WithEvents tbxSirname As TextBox
    Friend WithEvents tbxName As TextBox
    Friend WithEvents tbxID As TextBox
    Friend WithEvents lbxMemo As Label
    Friend WithEvents lblLineID As Label
    Friend WithEvents lbxTelephone As Label
    Friend WithEvents lbxSirname As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblID As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnPrint As Button
End Class
