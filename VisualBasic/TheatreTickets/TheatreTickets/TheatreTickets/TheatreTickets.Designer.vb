<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TheatreTickets
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtAdultCost = New Fields.TextField()
        Me.txtChildCost = New Fields.TextField()
        Me.lblAdultResults = New System.Windows.Forms.Label()
        Me.lblChildResults = New System.Windows.Forms.Label()
        Me.lblTotalResults = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.grpInputs = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.grpInputs.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.MintCream
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(808, 24)
        Me.MenuStrip1.TabIndex = 0
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
        'txtAdultCost
        '
        Me.txtAdultCost.Location = New System.Drawing.Point(15, 14)
        Me.txtAdultCost.Name = "txtAdultCost"
        Me.txtAdultCost.Size = New System.Drawing.Size(183, 96)
        Me.txtAdultCost.TabIndex = 1
        '
        'txtChildCost
        '
        Me.txtChildCost.Location = New System.Drawing.Point(15, 116)
        Me.txtChildCost.Name = "txtChildCost"
        Me.txtChildCost.Size = New System.Drawing.Size(183, 96)
        Me.txtChildCost.TabIndex = 3
        '
        'lblAdultResults
        '
        Me.lblAdultResults.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdultResults.Location = New System.Drawing.Point(6, 18)
        Me.lblAdultResults.Name = "lblAdultResults"
        Me.lblAdultResults.Size = New System.Drawing.Size(550, 92)
        Me.lblAdultResults.TabIndex = 5
        Me.lblAdultResults.Text = "Adult costs Will Appear Here"
        Me.lblAdultResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAdultResults.Visible = False
        '
        'lblChildResults
        '
        Me.lblChildResults.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChildResults.Location = New System.Drawing.Point(6, 110)
        Me.lblChildResults.Name = "lblChildResults"
        Me.lblChildResults.Size = New System.Drawing.Size(550, 89)
        Me.lblChildResults.TabIndex = 6
        Me.lblChildResults.Text = "Child costs Will Appear Here"
        Me.lblChildResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblChildResults.Visible = False
        '
        'lblTotalResults
        '
        Me.lblTotalResults.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalResults.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lblTotalResults.Location = New System.Drawing.Point(4, 206)
        Me.lblTotalResults.Name = "lblTotalResults"
        Me.lblTotalResults.Size = New System.Drawing.Size(552, 97)
        Me.lblTotalResults.TabIndex = 7
        Me.lblTotalResults.Text = "Total costs will appear here"
        Me.lblTotalResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTotalResults.Visible = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(9, 329)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(211, 57)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Begin"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(6, 18)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(311, 25)
        Me.lblInfo.TabIndex = 9
        Me.lblInfo.Text = "Percent kept after Movie Company: "
        '
        'grpInputs
        '
        Me.grpInputs.Controls.Add(Me.txtChildCost)
        Me.grpInputs.Controls.Add(Me.txtAdultCost)
        Me.grpInputs.Location = New System.Drawing.Point(9, 83)
        Me.grpInputs.Name = "grpInputs"
        Me.grpInputs.Size = New System.Drawing.Size(211, 227)
        Me.grpInputs.TabIndex = 10
        Me.grpInputs.TabStop = False
        Me.grpInputs.Text = "Inputs"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblChildResults)
        Me.GroupBox1.Controls.Add(Me.lblAdultResults)
        Me.GroupBox1.Controls.Add(Me.lblTotalResults)
        Me.GroupBox1.Location = New System.Drawing.Point(226, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(567, 311)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Results"
        '
        'grpInfo
        '
        Me.grpInfo.Controls.Add(Me.lblInfo)
        Me.grpInfo.Location = New System.Drawing.Point(9, 25)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(784, 52)
        Me.grpInfo.TabIndex = 12
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Info"
        '
        'TheatreTickets
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(808, 406)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpInputs)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "TheatreTickets"
        Me.ShowIcon = False
        Me.Text = "Theatre Tickets"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpInputs.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnClear As ToolStripMenuItem
    Friend WithEvents btnExit As ToolStripMenuItem
    Friend WithEvents txtAdultCost As Fields.TextField
    Friend WithEvents txtChildCost As Fields.TextField
    Friend WithEvents lblAdultResults As Label
    Friend WithEvents lblChildResults As Label
    Friend WithEvents lblTotalResults As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents grpInputs As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grpInfo As GroupBox
End Class
