<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CommuteCost
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
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.lblDirections = New System.Windows.Forms.Label()
        Me.pnlCar = New System.Windows.Forms.Panel()
        Me.txtGas = New Fields.TextField()
        Me.txtParking = New Fields.TextField()
        Me.txtMaintenance = New Fields.TextField()
        Me.txtMileage = New Fields.TextField()
        Me.txtDays = New Fields.TextField()
        Me.txtRoundtrip = New Fields.TextField()
        Me.pnlOther = New System.Windows.Forms.Panel()
        Me.txtDaysWorked = New Fields.TextField()
        Me.txtFare = New Fields.TextField()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlCar.SuspendLayout()
        Me.pnlOther.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbType
        '
        Me.cmbType.BackColor = System.Drawing.Color.PapayaWhip
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbType.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Car", "Bus", "Train"})
        Me.cmbType.Location = New System.Drawing.Point(248, 31)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(186, 38)
        Me.cmbType.TabIndex = 0
        '
        'lblDirections
        '
        Me.lblDirections.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirections.Location = New System.Drawing.Point(12, 31)
        Me.lblDirections.Name = "lblDirections"
        Me.lblDirections.Size = New System.Drawing.Size(230, 38)
        Me.lblDirections.TabIndex = 1
        Me.lblDirections.Text = "Select Mode Of Transport:"
        Me.lblDirections.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlCar
        '
        Me.pnlCar.Controls.Add(Me.txtGas)
        Me.pnlCar.Controls.Add(Me.txtParking)
        Me.pnlCar.Controls.Add(Me.txtMaintenance)
        Me.pnlCar.Controls.Add(Me.txtMileage)
        Me.pnlCar.Controls.Add(Me.txtDays)
        Me.pnlCar.Controls.Add(Me.txtRoundtrip)
        Me.pnlCar.Location = New System.Drawing.Point(12, 75)
        Me.pnlCar.Name = "pnlCar"
        Me.pnlCar.Size = New System.Drawing.Size(422, 336)
        Me.pnlCar.TabIndex = 2
        Me.pnlCar.Visible = False
        '
        'txtGas
        '
        Me.txtGas.Location = New System.Drawing.Point(236, 122)
        Me.txtGas.Name = "txtGas"
        Me.txtGas.Size = New System.Drawing.Size(183, 96)
        Me.txtGas.TabIndex = 3
        '
        'txtParking
        '
        Me.txtParking.Location = New System.Drawing.Point(236, 232)
        Me.txtParking.Name = "txtParking"
        Me.txtParking.Size = New System.Drawing.Size(183, 98)
        Me.txtParking.TabIndex = 5
        '
        'txtMaintenance
        '
        Me.txtMaintenance.Location = New System.Drawing.Point(3, 232)
        Me.txtMaintenance.Name = "txtMaintenance"
        Me.txtMaintenance.Size = New System.Drawing.Size(183, 98)
        Me.txtMaintenance.TabIndex = 4
        '
        'txtMileage
        '
        Me.txtMileage.Location = New System.Drawing.Point(3, 122)
        Me.txtMileage.Name = "txtMileage"
        Me.txtMileage.Size = New System.Drawing.Size(183, 96)
        Me.txtMileage.TabIndex = 2
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(236, 12)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(183, 96)
        Me.txtDays.TabIndex = 1
        '
        'txtRoundtrip
        '
        Me.txtRoundtrip.Location = New System.Drawing.Point(3, 12)
        Me.txtRoundtrip.Name = "txtRoundtrip"
        Me.txtRoundtrip.Size = New System.Drawing.Size(183, 96)
        Me.txtRoundtrip.TabIndex = 0
        '
        'pnlOther
        '
        Me.pnlOther.Controls.Add(Me.txtDaysWorked)
        Me.pnlOther.Controls.Add(Me.txtFare)
        Me.pnlOther.Location = New System.Drawing.Point(12, 75)
        Me.pnlOther.Name = "pnlOther"
        Me.pnlOther.Size = New System.Drawing.Size(422, 335)
        Me.pnlOther.TabIndex = 3
        Me.pnlOther.Visible = False
        '
        'txtDaysWorked
        '
        Me.txtDaysWorked.Location = New System.Drawing.Point(120, 172)
        Me.txtDaysWorked.Name = "txtDaysWorked"
        Me.txtDaysWorked.Size = New System.Drawing.Size(183, 96)
        Me.txtDaysWorked.TabIndex = 1
        '
        'txtFare
        '
        Me.txtFare.Location = New System.Drawing.Point(120, 30)
        Me.txtFare.Name = "txtFare"
        Me.txtFare.Size = New System.Drawing.Size(183, 96)
        Me.txtFare.TabIndex = 0
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnSubmit.Enabled = False
        Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.Black
        Me.btnSubmit.Location = New System.Drawing.Point(12, 417)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(422, 49)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Calculate"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblResult
        '
        Me.lblResult.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(12, 469)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(422, 79)
        Me.lblResult.TabIndex = 5
        Me.lblResult.Text = "Cost for commuting one year via METHOD: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "COST"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblResult.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(449, 24)
        Me.MenuStrip1.TabIndex = 7
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
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'CommuteCost
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(449, 557)
        Me.Controls.Add(Me.pnlCar)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.pnlOther)
        Me.Controls.Add(Me.lblDirections)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CommuteCost"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Commute Cost Calculator"
        Me.pnlCar.ResumeLayout(False)
        Me.pnlOther.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbType As ComboBox
    Friend WithEvents lblDirections As Label
    Friend WithEvents pnlCar As Panel
    Friend WithEvents txtParking As Fields.TextField
    Friend WithEvents txtMaintenance As Fields.TextField
    Friend WithEvents txtMileage As Fields.TextField
    Friend WithEvents txtDays As Fields.TextField
    Friend WithEvents txtRoundtrip As Fields.TextField
    Friend WithEvents txtGas As Fields.TextField
    Friend WithEvents pnlOther As Panel
    Friend WithEvents txtDaysWorked As Fields.TextField
    Friend WithEvents txtFare As Fields.TextField
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
