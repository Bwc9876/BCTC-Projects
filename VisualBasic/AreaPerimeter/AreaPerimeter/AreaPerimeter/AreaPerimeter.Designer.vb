<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AreaPerimeter
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
        Me.menMain = New System.Windows.Forms.MenuStrip()
        Me.btnFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSide2 = New Fields.TextField()
        Me.txtSide1 = New Fields.TextField()
        Me.cmbSelector = New System.Windows.Forms.ComboBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.menMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'menMain
        '
        Me.menMain.BackColor = System.Drawing.Color.MintCream
        Me.menMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFile})
        Me.menMain.Location = New System.Drawing.Point(0, 0)
        Me.menMain.Name = "menMain"
        Me.menMain.Size = New System.Drawing.Size(402, 24)
        Me.menMain.TabIndex = 0
        Me.menMain.Text = "menMain"
        '
        'btnFile
        '
        Me.btnFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnClear, Me.btnExit})
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(37, 20)
        Me.btnFile.Text = "File"
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
        'txtSide2
        '
        Me.txtSide2.Location = New System.Drawing.Point(201, 41)
        Me.txtSide2.Name = "txtSide2"
        Me.txtSide2.Size = New System.Drawing.Size(183, 82)
        Me.txtSide2.TabIndex = 1
        '
        'txtSide1
        '
        Me.txtSide1.Location = New System.Drawing.Point(12, 41)
        Me.txtSide1.Name = "txtSide1"
        Me.txtSide1.Size = New System.Drawing.Size(183, 82)
        Me.txtSide1.TabIndex = 0
        '
        'cmbSelector
        '
        Me.cmbSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelector.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelector.FormattingEnabled = True
        Me.cmbSelector.Items.AddRange(New Object() {"Area", "Perimeter"})
        Me.cmbSelector.Location = New System.Drawing.Point(74, 157)
        Me.cmbSelector.Name = "cmbSelector"
        Me.cmbSelector.Size = New System.Drawing.Size(121, 38)
        Me.cmbSelector.TabIndex = 2
        '
        'btnCalculate
        '
        Me.btnCalculate.Enabled = False
        Me.btnCalculate.Location = New System.Drawing.Point(201, 157)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(104, 38)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblResults
        '
        Me.lblResults.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(74, 215)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(231, 77)
        Me.lblResults.TabIndex = 4
        Me.lblResults.Text = "Results"
        Me.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblResults.Visible = False
        '
        'AreaPerimeter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(402, 321)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.cmbSelector)
        Me.Controls.Add(Me.txtSide1)
        Me.Controls.Add(Me.txtSide2)
        Me.Controls.Add(Me.menMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.menMain
        Me.MaximizeBox = False
        Me.Name = "AreaPerimeter"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Area And Perimeter Calculator"
        Me.menMain.ResumeLayout(False)
        Me.menMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menMain As MenuStrip
    Friend WithEvents btnFile As ToolStripMenuItem
    Friend WithEvents btnClear As ToolStripMenuItem
    Friend WithEvents btnExit As ToolStripMenuItem
    Friend WithEvents txtSide2 As Fields.TextField
    Friend WithEvents txtSide1 As Fields.TextField
    Friend WithEvents cmbSelector As ComboBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblResults As Label
End Class
