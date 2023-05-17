<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StringFest
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
        Me.txtInputName = New System.Windows.Forms.TextBox()
        Me.lblEnterName = New System.Windows.Forms.Label()
        Me.btnProccess = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblOutputName = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtInputName
        '
        Me.txtInputName.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.txtInputName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.txtInputName.Location = New System.Drawing.Point(16, 35)
        Me.txtInputName.Name = "txtInputName"
        Me.txtInputName.Size = New System.Drawing.Size(396, 27)
        Me.txtInputName.TabIndex = 0
        '
        'lblEnterName
        '
        Me.lblEnterName.AutoSize = True
        Me.lblEnterName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblEnterName.Location = New System.Drawing.Point(92, 12)
        Me.lblEnterName.Name = "lblEnterName"
        Me.lblEnterName.Size = New System.Drawing.Size(245, 20)
        Me.lblEnterName.TabIndex = 1
        Me.lblEnterName.Text = "Enter Your Name (First Middle Last):"
        '
        'btnProccess
        '
        Me.btnProccess.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnProccess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnProccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProccess.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProccess.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnProccess.Location = New System.Drawing.Point(16, 68)
        Me.btnProccess.Name = "btnProccess"
        Me.btnProccess.Size = New System.Drawing.Size(490, 37)
        Me.btnProccess.TabIndex = 2
        Me.btnProccess.Text = "Proccess"
        Me.btnProccess.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(418, 35)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(88, 27)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblOutputName
        '
        Me.lblOutputName.AutoSize = True
        Me.lblOutputName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblOutputName.Location = New System.Drawing.Point(12, 116)
        Me.lblOutputName.Name = "lblOutputName"
        Me.lblOutputName.Size = New System.Drawing.Size(99, 20)
        Me.lblOutputName.TabIndex = 4
        Me.lblOutputName.Text = "Output Name"
        Me.lblOutputName.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(418, 111)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 32)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'StringFest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(518, 152)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblOutputName)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnProccess)
        Me.Controls.Add(Me.lblEnterName)
        Me.Controls.Add(Me.txtInputName)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "StringFest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInputName As TextBox
    Friend WithEvents lblEnterName As Label
    Friend WithEvents btnProccess As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblOutputName As Label
    Friend WithEvents btnExit As Button
End Class
