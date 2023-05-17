<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penny_A_Day
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
        Me.grpPayType = New System.Windows.Forms.GroupBox()
        Me.radNickel = New System.Windows.Forms.RadioButton()
        Me.radPenny = New System.Windows.Forms.RadioButton()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.grpPayType.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPayType
        '
        Me.grpPayType.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.grpPayType.Controls.Add(Me.radNickel)
        Me.grpPayType.Controls.Add(Me.radPenny)
        Me.grpPayType.Location = New System.Drawing.Point(12, 27)
        Me.grpPayType.Name = "grpPayType"
        Me.grpPayType.Size = New System.Drawing.Size(224, 100)
        Me.grpPayType.TabIndex = 1
        Me.grpPayType.TabStop = False
        Me.grpPayType.Text = "Pay Amount"
        '
        'radNickel
        '
        Me.radNickel.AutoSize = True
        Me.radNickel.Location = New System.Drawing.Point(63, 59)
        Me.radNickel.Name = "radNickel"
        Me.radNickel.Size = New System.Drawing.Size(56, 17)
        Me.radNickel.TabIndex = 1
        Me.radNickel.Text = "Nickel"
        Me.radNickel.UseVisualStyleBackColor = True
        '
        'radPenny
        '
        Me.radPenny.AutoSize = True
        Me.radPenny.Checked = True
        Me.radPenny.Location = New System.Drawing.Point(63, 24)
        Me.radPenny.Name = "radPenny"
        Me.radPenny.Size = New System.Drawing.Size(56, 17)
        Me.radPenny.TabIndex = 0
        Me.radPenny.TabStop = True
        Me.radPenny.Text = "Penny"
        Me.radPenny.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(12, 175)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(224, 111)
        Me.lblResult.TabIndex = 2
        Me.lblResult.Text = "Result Will Appear Here"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(248, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Location = New System.Drawing.Point(12, 133)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(224, 39)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Begin"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Penny_A_Day
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(248, 296)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.grpPayType)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Penny_A_Day"
        Me.ShowIcon = False
        Me.Text = "Penny A Day"
        Me.grpPayType.ResumeLayout(False)
        Me.grpPayType.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpPayType As GroupBox
    Friend WithEvents radNickel As RadioButton
    Friend WithEvents radPenny As RadioButton
    Friend WithEvents lblResult As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSubmit As Button
End Class
