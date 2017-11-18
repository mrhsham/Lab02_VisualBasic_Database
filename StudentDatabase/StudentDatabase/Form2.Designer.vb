<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TestDBDataSet = New StudentDatabase.TestDBDataSet()
        Me.StudentDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentDetailTableAdapter = New StudentDatabase.TestDBDataSetTableAdapters.StudentDetailTableAdapter()
        CType(Me.TestDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "TestDBData"
        ReportDataSource1.Value = Me.StudentDetailBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "StudentDatabase.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(411, 402)
        Me.ReportViewer1.TabIndex = 0
        '
        'TestDBDataSet
        '
        Me.TestDBDataSet.DataSetName = "TestDBDataSet"
        Me.TestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentDetailBindingSource
        '
        Me.StudentDetailBindingSource.DataMember = "StudentDetail"
        Me.StudentDetailBindingSource.DataSource = Me.TestDBDataSet
        '
        'StudentDetailTableAdapter
        '
        Me.StudentDetailTableAdapter.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 402)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.TestDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents StudentDetailBindingSource As BindingSource
    Friend WithEvents TestDBDataSet As TestDBDataSet
    Friend WithEvents StudentDetailTableAdapter As TestDBDataSetTableAdapters.StudentDetailTableAdapter
End Class
