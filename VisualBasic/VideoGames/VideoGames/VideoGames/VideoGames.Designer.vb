<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VideoGames
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
        Me.btnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstGames = New System.Windows.Forms.ListBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.grpDownloads = New System.Windows.Forms.GroupBox()
        Me.lblDownloads = New System.Windows.Forms.Label()
        Me.grpTotal = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnAlpha = New System.Windows.Forms.Button()
        Me.menMain.SuspendLayout()
        Me.grpDownloads.SuspendLayout()
        Me.grpTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'menMain
        '
        Me.menMain.BackColor = System.Drawing.Color.AliceBlue
        Me.menMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFile})
        Me.menMain.Location = New System.Drawing.Point(0, 0)
        Me.menMain.Name = "menMain"
        Me.menMain.Size = New System.Drawing.Size(298, 24)
        Me.menMain.TabIndex = 0
        Me.menMain.Text = "menMain"
        '
        'btnFile
        '
        Me.btnFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnExit})
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(37, 20)
        Me.btnFile.Text = "File"
        '
        'btnExit
        '
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 22)
        Me.btnExit.Text = "Exit"
        '
        'lstGames
        '
        Me.lstGames.BackColor = System.Drawing.Color.Lavender
        Me.lstGames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstGames.FormatString = "N0"
        Me.lstGames.FormattingEnabled = True
        Me.lstGames.Location = New System.Drawing.Point(12, 71)
        Me.lstGames.Name = "lstGames"
        Me.lstGames.Size = New System.Drawing.Size(274, 184)
        Me.lstGames.TabIndex = 1
        '
        'lblHeader
        '
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(12, 24)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(274, 44)
        Me.lblHeader.TabIndex = 2
        Me.lblHeader.Text = "Top Games!!!"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpDownloads
        '
        Me.grpDownloads.Controls.Add(Me.lblDownloads)
        Me.grpDownloads.Location = New System.Drawing.Point(12, 263)
        Me.grpDownloads.Name = "grpDownloads"
        Me.grpDownloads.Size = New System.Drawing.Size(274, 76)
        Me.grpDownloads.TabIndex = 3
        Me.grpDownloads.TabStop = False
        Me.grpDownloads.Text = "Downloads"
        '
        'lblDownloads
        '
        Me.lblDownloads.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDownloads.Location = New System.Drawing.Point(6, 18)
        Me.lblDownloads.Name = "lblDownloads"
        Me.lblDownloads.Size = New System.Drawing.Size(262, 55)
        Me.lblDownloads.TabIndex = 0
        Me.lblDownloads.Text = "DOWNLOADS"
        Me.lblDownloads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDownloads.Visible = False
        '
        'grpTotal
        '
        Me.grpTotal.Controls.Add(Me.lblTotal)
        Me.grpTotal.Location = New System.Drawing.Point(12, 345)
        Me.grpTotal.Name = "grpTotal"
        Me.grpTotal.Size = New System.Drawing.Size(274, 76)
        Me.grpTotal.TabIndex = 4
        Me.grpTotal.TabStop = False
        Me.grpTotal.Text = "Total Downloads"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(6, 18)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(262, 55)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "DOWNLOADS"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAlpha
        '
        Me.btnAlpha.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnAlpha.FlatAppearance.BorderColor = System.Drawing.Color.Cyan
        Me.btnAlpha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlpha.Location = New System.Drawing.Point(12, 427)
        Me.btnAlpha.Name = "btnAlpha"
        Me.btnAlpha.Size = New System.Drawing.Size(274, 38)
        Me.btnAlpha.TabIndex = 5
        Me.btnAlpha.Text = "Show Alphabetical"
        Me.btnAlpha.UseVisualStyleBackColor = False
        '
        'VideoGames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(298, 474)
        Me.Controls.Add(Me.btnAlpha)
        Me.Controls.Add(Me.grpTotal)
        Me.Controls.Add(Me.grpDownloads)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lstGames)
        Me.Controls.Add(Me.menMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.menMain
        Me.MaximizeBox = False
        Me.Name = "VideoGames"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VideoGames"
        Me.menMain.ResumeLayout(False)
        Me.menMain.PerformLayout()
        Me.grpDownloads.ResumeLayout(False)
        Me.grpTotal.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menMain As MenuStrip
    Friend WithEvents btnFile As ToolStripMenuItem
    Friend WithEvents btnExit As ToolStripMenuItem
    Friend WithEvents lstGames As ListBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents grpDownloads As GroupBox
    Friend WithEvents lblDownloads As Label
    Friend WithEvents grpTotal As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnAlpha As Button
End Class
