<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BMI
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
        Me.txtWeight = New Fields.TextField()
        Me.txtHeight = New Fields.TextField()
        Me.cmbSelector = New System.Windows.Forms.ComboBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblBMI = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.menMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'menMain
        '
        Me.menMain.BackColor = System.Drawing.Color.MintCream
        Me.menMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFile})
        Me.menMain.Location = New System.Drawing.Point(0, 0)
        Me.menMain.Name = "menMain"
        Me.menMain.Size = New System.Drawing.Size(395, 24)
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
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(12, 27)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(183, 96)
        Me.txtWeight.TabIndex = 1
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(201, 27)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(183, 96)
        Me.txtHeight.TabIndex = 2
        '
        'cmbSelector
        '
        Me.cmbSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelector.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelector.FormattingEnabled = True
        Me.cmbSelector.Items.AddRange(New Object() {"Imperial (lbs/in)", "Metric (kg/m)"})
        Me.cmbSelector.Location = New System.Drawing.Point(12, 150)
        Me.cmbSelector.Name = "cmbSelector"
        Me.cmbSelector.Size = New System.Drawing.Size(183, 38)
        Me.cmbSelector.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Enabled = False
        Me.btnCalculate.Location = New System.Drawing.Point(201, 150)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(183, 38)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblBMI
        '
        Me.lblBMI.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBMI.Location = New System.Drawing.Point(12, 209)
        Me.lblBMI.Name = "lblBMI"
        Me.lblBMI.Size = New System.Drawing.Size(183, 41)
        Me.lblBMI.TabIndex = 5
        Me.lblBMI.Text = "BMI"
        Me.lblBMI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblBMI.Visible = False
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(201, 209)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(183, 41)
        Me.lblMessage.TabIndex = 6
        Me.lblMessage.Text = "Message"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblMessage.Visible = False
        '
        'BMI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(395, 257)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblBMI)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.cmbSelector)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.menMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.menMain
        Me.MaximizeBox = False
        Me.Name = "BMI"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BMI Calculator"
        Me.menMain.ResumeLayout(False)
        Me.menMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menMain As MenuStrip
    Friend WithEvents btnFile As ToolStripMenuItem
    Friend WithEvents btnClear As ToolStripMenuItem
    Friend WithEvents btnExit As ToolStripMenuItem
    Friend WithEvents txtWeight As Fields.TextField
    Friend WithEvents txtHeight As Fields.TextField
    Friend WithEvents cmbSelector As ComboBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblBMI As Label
    Friend WithEvents lblMessage As Label
End Class
