<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CookTurkey
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstResults
        '
        Me.lstResults.BackColor = System.Drawing.Color.Salmon
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(12, 65)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(186, 173)
        Me.lstResults.TabIndex = 0
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.RosyBrown
        Me.btnEnter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnter.Location = New System.Drawing.Point(38, 12)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(134, 38)
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Text = "Calculate"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'CookTurkey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(210, 261)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lstResults)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CookTurkey"
        Me.ShowIcon = False
        Me.Text = "CookTurkey"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstResults As ListBox
    Friend WithEvents btnEnter As Button
End Class
