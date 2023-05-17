<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Asterisks
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
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtIterator = New Fields.TextField()
        Me.txtEnd = New Fields.TextField()
        Me.txtStart = New Fields.TextField()
        Me.SuspendLayout()
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(23, 148)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(360, 290)
        Me.lstResults.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(23, 87)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(360, 42)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtIterator
        '
        Me.txtIterator.Location = New System.Drawing.Point(267, 12)
        Me.txtIterator.Name = "txtIterator"
        Me.txtIterator.Size = New System.Drawing.Size(116, 69)
        Me.txtIterator.TabIndex = 2
        '
        'txtEnd
        '
        Me.txtEnd.Location = New System.Drawing.Point(145, 12)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(116, 69)
        Me.txtEnd.TabIndex = 1
        '
        'txtStart
        '
        Me.txtStart.Location = New System.Drawing.Point(23, 12)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(116, 69)
        Me.txtStart.TabIndex = 0
        '
        'Asterisks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 450)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.txtIterator)
        Me.Controls.Add(Me.txtEnd)
        Me.Controls.Add(Me.txtStart)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Asterisks"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asterisks"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtStart As Fields.TextField
    Friend WithEvents txtEnd As Fields.TextField
    Friend WithEvents txtIterator As Fields.TextField
    Friend WithEvents lstResults As ListBox
    Friend WithEvents btnCalculate As Button
End Class
