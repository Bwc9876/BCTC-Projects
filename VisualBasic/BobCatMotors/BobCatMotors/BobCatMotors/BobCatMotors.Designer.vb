<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BobCatMotors
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
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.grpFileSelect = New System.Windows.Forms.GroupBox()
        Me.grpCode = New System.Windows.Forms.GroupBox()
        Me.cmbCode = New System.Windows.Forms.ComboBox()
        Me.grpResults = New System.Windows.Forms.GroupBox()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpFileSelect.SuspendLayout()
        Me.grpCode.SuspendLayout()
        Me.grpResults.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(45, 23)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 22)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFilePath
        '
        Me.txtFilePath.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtFilePath.Location = New System.Drawing.Point(126, 23)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.ReadOnly = True
        Me.txtFilePath.Size = New System.Drawing.Size(182, 22)
        Me.txtFilePath.TabIndex = 1
        Me.txtFilePath.Text = "No File Selected"
        '
        'grpFileSelect
        '
        Me.grpFileSelect.Controls.Add(Me.txtFilePath)
        Me.grpFileSelect.Controls.Add(Me.btnBrowse)
        Me.grpFileSelect.Location = New System.Drawing.Point(12, 27)
        Me.grpFileSelect.Name = "grpFileSelect"
        Me.grpFileSelect.Size = New System.Drawing.Size(352, 68)
        Me.grpFileSelect.TabIndex = 2
        Me.grpFileSelect.TabStop = False
        Me.grpFileSelect.Text = "Select Data File"
        '
        'grpCode
        '
        Me.grpCode.Controls.Add(Me.cmbCode)
        Me.grpCode.Location = New System.Drawing.Point(12, 101)
        Me.grpCode.Name = "grpCode"
        Me.grpCode.Size = New System.Drawing.Size(352, 68)
        Me.grpCode.TabIndex = 3
        Me.grpCode.TabStop = False
        Me.grpCode.Text = "Select Employee Code"
        '
        'cmbCode
        '
        Me.cmbCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCode.Enabled = False
        Me.cmbCode.FormattingEnabled = True
        Me.cmbCode.Location = New System.Drawing.Point(115, 24)
        Me.cmbCode.Name = "cmbCode"
        Me.cmbCode.Size = New System.Drawing.Size(123, 21)
        Me.cmbCode.TabIndex = 0
        '
        'grpResults
        '
        Me.grpResults.Controls.Add(Me.lstResults)
        Me.grpResults.Location = New System.Drawing.Point(12, 175)
        Me.grpResults.Name = "grpResults"
        Me.grpResults.Size = New System.Drawing.Size(352, 231)
        Me.grpResults.TabIndex = 4
        Me.grpResults.TabStop = False
        Me.grpResults.Text = "Results"
        '
        'lstResults
        '
        Me.lstResults.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(84, 23)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(184, 186)
        Me.lstResults.TabIndex = 0
        Me.lstResults.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.MintCream
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(376, 24)
        Me.MenuStrip1.TabIndex = 5
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
        'BobCatMotors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(376, 417)
        Me.Controls.Add(Me.grpResults)
        Me.Controls.Add(Me.grpCode)
        Me.Controls.Add(Me.grpFileSelect)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "BobCatMotors"
        Me.ShowIcon = False
        Me.Text = "BobCat Motors Employees "
        Me.grpFileSelect.ResumeLayout(False)
        Me.grpFileSelect.PerformLayout()
        Me.grpCode.ResumeLayout(False)
        Me.grpResults.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents grpFileSelect As GroupBox
    Friend WithEvents grpCode As GroupBox
    Friend WithEvents cmbCode As ComboBox
    Friend WithEvents grpResults As GroupBox
    Friend WithEvents lstResults As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnClear As ToolStripMenuItem
    Friend WithEvents btnExit As ToolStripMenuItem
End Class
