<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NestEgg
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
        Me.txtTarget = New Fields.TextField()
        Me.txtCurrent = New Fields.TextField()
        Me.txtInterest = New Fields.TextField()
        Me.txtYears = New Fields.TextField()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lstYears = New System.Windows.Forms.ListBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblMetGoal = New System.Windows.Forms.Label()
        Me.mesMenu = New System.Windows.Forms.MenuStrip()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpResults = New System.Windows.Forms.GroupBox()
        Me.mesMenu.SuspendLayout()
        Me.grpResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTarget
        '
        Me.txtTarget.BackColor = System.Drawing.Color.GhostWhite
        Me.txtTarget.Location = New System.Drawing.Point(200, 37)
        Me.txtTarget.Name = "txtTarget"
        Me.txtTarget.Size = New System.Drawing.Size(181, 96)
        Me.txtTarget.TabIndex = 1
        '
        'txtCurrent
        '
        Me.txtCurrent.BackColor = System.Drawing.Color.GhostWhite
        Me.txtCurrent.Location = New System.Drawing.Point(11, 37)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.Size = New System.Drawing.Size(181, 96)
        Me.txtCurrent.TabIndex = 0
        '
        'txtInterest
        '
        Me.txtInterest.BackColor = System.Drawing.Color.GhostWhite
        Me.txtInterest.Location = New System.Drawing.Point(11, 139)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(181, 96)
        Me.txtInterest.TabIndex = 2
        '
        'txtYears
        '
        Me.txtYears.BackColor = System.Drawing.Color.GhostWhite
        Me.txtYears.Location = New System.Drawing.Point(200, 139)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(181, 96)
        Me.txtYears.TabIndex = 3
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.GhostWhite
        Me.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.btnSubmit.FlatAppearance.BorderSize = 2
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(11, 241)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(370, 49)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Calculate"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lstYears
        '
        Me.lstYears.BackColor = System.Drawing.Color.GhostWhite
        Me.lstYears.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstYears.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstYears.FormattingEnabled = True
        Me.lstYears.ItemHeight = 21
        Me.lstYears.Location = New System.Drawing.Point(6, 16)
        Me.lstYears.Name = "lstYears"
        Me.lstYears.Size = New System.Drawing.Size(168, 170)
        Me.lstYears.TabIndex = 5
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.GhostWhite
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(180, 16)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(184, 52)
        Me.lblResult.TabIndex = 6
        Me.lblResult.Text = "RESULTS"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMetGoal
        '
        Me.lblMetGoal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMetGoal.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMetGoal.Location = New System.Drawing.Point(180, 78)
        Me.lblMetGoal.Name = "lblMetGoal"
        Me.lblMetGoal.Size = New System.Drawing.Size(184, 108)
        Me.lblMetGoal.TabIndex = 7
        Me.lblMetGoal.Text = "MET GOAL"
        Me.lblMetGoal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mesMenu
        '
        Me.mesMenu.BackColor = System.Drawing.Color.AliceBlue
        Me.mesMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.mesMenu.Location = New System.Drawing.Point(0, 0)
        Me.mesMenu.Name = "mesMenu"
        Me.mesMenu.Size = New System.Drawing.Size(393, 24)
        Me.mesMenu.TabIndex = 8
        Me.mesMenu.Text = "MenuStrip1"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'grpResults
        '
        Me.grpResults.Controls.Add(Me.lblMetGoal)
        Me.grpResults.Controls.Add(Me.lblResult)
        Me.grpResults.Controls.Add(Me.lstYears)
        Me.grpResults.Location = New System.Drawing.Point(11, 296)
        Me.grpResults.Name = "grpResults"
        Me.grpResults.Size = New System.Drawing.Size(370, 194)
        Me.grpResults.TabIndex = 9
        Me.grpResults.TabStop = False
        Me.grpResults.Text = "Results"
        Me.grpResults.Visible = False
        '
        'NestEgg
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(393, 498)
        Me.Controls.Add(Me.grpResults)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtYears)
        Me.Controls.Add(Me.txtInterest)
        Me.Controls.Add(Me.txtCurrent)
        Me.Controls.Add(Me.txtTarget)
        Me.Controls.Add(Me.mesMenu)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.mesMenu
        Me.Name = "NestEgg"
        Me.ShowIcon = False
        Me.Text = "Nest Egg Calculator"
        Me.mesMenu.ResumeLayout(False)
        Me.mesMenu.PerformLayout()
        Me.grpResults.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTarget As Fields.TextField
    Friend WithEvents txtCurrent As Fields.TextField
    Friend WithEvents txtInterest As Fields.TextField
    Friend WithEvents txtYears As Fields.TextField
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lstYears As ListBox
    Friend WithEvents lblResult As Label
    Friend WithEvents lblMetGoal As Label
    Friend WithEvents mesMenu As MenuStrip
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpResults As GroupBox
End Class
