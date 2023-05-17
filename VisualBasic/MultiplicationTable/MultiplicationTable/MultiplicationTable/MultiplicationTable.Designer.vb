<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiplicationTable
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
        Me.txtMultiplier = New Fields.TextField()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMultiplier
        '
        Me.txtMultiplier.Location = New System.Drawing.Point(16, 12)
        Me.txtMultiplier.Name = "txtMultiplier"
        Me.txtMultiplier.Size = New System.Drawing.Size(183, 88)
        Me.txtMultiplier.TabIndex = 0
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(16, 143)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(183, 82)
        Me.lstResults.TabIndex = 1
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(16, 106)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(183, 31)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Calculate"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'MultiplicationTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 238)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.txtMultiplier)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MultiplicationTable"
        Me.ShowIcon = False
        Me.Text = "MultiplicationTable"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtMultiplier As Fields.TextField
    Friend WithEvents lstResults As ListBox
    Friend WithEvents btnSubmit As Button
End Class
