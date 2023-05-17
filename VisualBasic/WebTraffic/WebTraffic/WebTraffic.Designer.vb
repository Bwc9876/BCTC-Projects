<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebTraffic
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
        Me.lstMetrics = New System.Windows.Forms.ListBox()
        Me.btnEnterData = New System.Windows.Forms.Button()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstMetrics
        '
        Me.lstMetrics.BackColor = System.Drawing.Color.OldLace
        Me.lstMetrics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstMetrics.FormattingEnabled = True
        Me.lstMetrics.ItemHeight = 17
        Me.lstMetrics.Location = New System.Drawing.Point(179, 12)
        Me.lstMetrics.Name = "lstMetrics"
        Me.lstMetrics.Size = New System.Drawing.Size(116, 172)
        Me.lstMetrics.TabIndex = 0
        '
        'btnEnterData
        '
        Me.btnEnterData.BackColor = System.Drawing.Color.OldLace
        Me.btnEnterData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnterData.Location = New System.Drawing.Point(13, 84)
        Me.btnEnterData.Name = "btnEnterData"
        Me.btnEnterData.Size = New System.Drawing.Size(160, 30)
        Me.btnEnterData.TabIndex = 1
        Me.btnEnterData.Text = "Enter Analytics"
        Me.btnEnterData.UseVisualStyleBackColor = False
        '
        'lblResults
        '
        Me.lblResults.BackColor = System.Drawing.Color.OldLace
        Me.lblResults.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(16, 12)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(157, 25)
        Me.lblResults.TabIndex = 2
        Me.lblResults.Text = "RESULTS"
        Me.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblResults.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.OldLace
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(13, 120)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(160, 30)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.OldLace
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(13, 154)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(160, 30)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'WebTraffic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(307, 198)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.btnEnterData)
        Me.Controls.Add(Me.lstMetrics)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "WebTraffic"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Website Traffic"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstMetrics As ListBox
    Friend WithEvents btnEnterData As Button
    Friend WithEvents lblResults As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
