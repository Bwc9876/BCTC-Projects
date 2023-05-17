<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EvenOdd
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
        Me.grpFileSelect = New System.Windows.Forms.GroupBox()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lstEven = New System.Windows.Forms.ListBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.grpEven = New System.Windows.Forms.GroupBox()
        Me.grpOdd = New System.Windows.Forms.GroupBox()
        Me.lstOdd = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpFileSelect.SuspendLayout()
        Me.grpEven.SuspendLayout()
        Me.grpOdd.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpFileSelect
        '
        Me.grpFileSelect.Controls.Add(Me.txtFilePath)
        Me.grpFileSelect.Controls.Add(Me.btnBrowse)
        Me.grpFileSelect.Location = New System.Drawing.Point(12, 37)
        Me.grpFileSelect.Name = "grpFileSelect"
        Me.grpFileSelect.Size = New System.Drawing.Size(316, 68)
        Me.grpFileSelect.TabIndex = 3
        Me.grpFileSelect.TabStop = False
        Me.grpFileSelect.Text = "Select Data File"
        '
        'txtFilePath
        '
        Me.txtFilePath.BackColor = System.Drawing.Color.FloralWhite
        Me.txtFilePath.Location = New System.Drawing.Point(108, 23)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.ReadOnly = True
        Me.txtFilePath.Size = New System.Drawing.Size(182, 22)
        Me.txtFilePath.TabIndex = 1
        Me.txtFilePath.Text = "No File Selected"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(27, 23)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 22)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lstEven
        '
        Me.lstEven.BackColor = System.Drawing.Color.FloralWhite
        Me.lstEven.FormattingEnabled = True
        Me.lstEven.Location = New System.Drawing.Point(18, 26)
        Me.lstEven.Name = "lstEven"
        Me.lstEven.Size = New System.Drawing.Size(120, 147)
        Me.lstEven.TabIndex = 4
        Me.lstEven.Visible = False
        '
        'btnExport
        '
        Me.btnExport.Enabled = False
        Me.btnExport.Location = New System.Drawing.Point(12, 317)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(316, 23)
        Me.btnExport.TabIndex = 6
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'grpEven
        '
        Me.grpEven.Controls.Add(Me.lstEven)
        Me.grpEven.Location = New System.Drawing.Point(12, 113)
        Me.grpEven.Name = "grpEven"
        Me.grpEven.Size = New System.Drawing.Size(156, 198)
        Me.grpEven.TabIndex = 7
        Me.grpEven.TabStop = False
        Me.grpEven.Text = "Even"
        '
        'grpOdd
        '
        Me.grpOdd.Controls.Add(Me.lstOdd)
        Me.grpOdd.Location = New System.Drawing.Point(172, 113)
        Me.grpOdd.Name = "grpOdd"
        Me.grpOdd.Size = New System.Drawing.Size(156, 198)
        Me.grpOdd.TabIndex = 8
        Me.grpOdd.TabStop = False
        Me.grpOdd.Text = "Odd"
        '
        'lstOdd
        '
        Me.lstOdd.BackColor = System.Drawing.Color.FloralWhite
        Me.lstOdd.FormattingEnabled = True
        Me.lstOdd.Location = New System.Drawing.Point(18, 26)
        Me.lstOdd.Name = "lstOdd"
        Me.lstOdd.Size = New System.Drawing.Size(120, 147)
        Me.lstOdd.TabIndex = 4
        Me.lstOdd.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.PapayaWhip
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(338, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnClear, Me.btnExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'btnClear
        '
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(101, 22)
        Me.btnClear.Text = "Clear"
        '
        'btnExit
        '
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 22)
        Me.btnExit.Text = "Exit"
        '
        'EvenOdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(338, 353)
        Me.Controls.Add(Me.grpOdd)
        Me.Controls.Add(Me.grpEven)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.grpFileSelect)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "EvenOdd"
        Me.ShowIcon = False
        Me.Text = "Even Odd Sorter"
        Me.grpFileSelect.ResumeLayout(False)
        Me.grpFileSelect.PerformLayout()
        Me.grpEven.ResumeLayout(False)
        Me.grpOdd.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpFileSelect As GroupBox
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lstEven As ListBox
    Friend WithEvents btnExport As Button
    Friend WithEvents grpEven As GroupBox
    Friend WithEvents grpOdd As GroupBox
    Friend WithEvents lstOdd As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnClear As ToolStripMenuItem
    Friend WithEvents btnExit As ToolStripMenuItem
End Class
