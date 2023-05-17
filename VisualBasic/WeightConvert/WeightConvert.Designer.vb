<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeightConvert
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
        Me.grpInputs = New System.Windows.Forms.GroupBox()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.lblConvertedWeight = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpInputs.SuspendLayout()
        Me.grpOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpInputs
        '
        Me.grpInputs.Controls.Add(Me.cmbUnit)
        Me.grpInputs.Controls.Add(Me.txtWeight)
        Me.grpInputs.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInputs.Location = New System.Drawing.Point(12, 12)
        Me.grpInputs.Name = "grpInputs"
        Me.grpInputs.Size = New System.Drawing.Size(352, 101)
        Me.grpInputs.TabIndex = 0
        Me.grpInputs.TabStop = False
        Me.grpInputs.Text = "Enter Patient Weight"
        '
        'cmbUnit
        '
        Me.cmbUnit.BackColor = System.Drawing.Color.MintCream
        Me.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnit.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Items.AddRange(New Object() {"lbs.", "kg."})
        Me.cmbUnit.Location = New System.Drawing.Point(233, 39)
        Me.cmbUnit.MaxDropDownItems = 2
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(51, 33)
        Me.cmbUnit.TabIndex = 2
        '
        'txtWeight
        '
        Me.txtWeight.BackColor = System.Drawing.Color.MintCream
        Me.txtWeight.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(69, 27)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(158, 46)
        Me.txtWeight.TabIndex = 0
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.LightGreen
        Me.btnConvert.Enabled = False
        Me.btnConvert.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.btnConvert.FlatAppearance.BorderSize = 3
        Me.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConvert.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(12, 119)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(354, 37)
        Me.btnConvert.TabIndex = 1
        Me.btnConvert.Text = "Please Select A Unit First"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.lblConvertedWeight)
        Me.grpOutput.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOutput.Location = New System.Drawing.Point(12, 162)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(352, 98)
        Me.grpOutput.TabIndex = 2
        Me.grpOutput.TabStop = False
        Me.grpOutput.Tag = ""
        Me.grpOutput.Text = "Converted Weight"
        '
        'lblConvertedWeight
        '
        Me.lblConvertedWeight.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvertedWeight.Location = New System.Drawing.Point(6, 20)
        Me.lblConvertedWeight.Name = "lblConvertedWeight"
        Me.lblConvertedWeight.Size = New System.Drawing.Size(336, 59)
        Me.lblConvertedWeight.TabIndex = 0
        Me.lblConvertedWeight.Text = "Converted Weight"
        Me.lblConvertedWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblConvertedWeight.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightGreen
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.btnClear.FlatAppearance.BorderSize = 3
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(12, 266)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(174, 31)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightGreen
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.btnExit.FlatAppearance.BorderSize = 3
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(192, 266)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(174, 31)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'WeightConvert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(376, 307)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.grpInputs)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "WeightConvert"
        Me.ShowIcon = False
        Me.Text = "Weight Converter"
        Me.grpInputs.ResumeLayout(False)
        Me.grpInputs.PerformLayout()
        Me.grpOutput.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpInputs As GroupBox
    Friend WithEvents cmbUnit As ComboBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents grpOutput As GroupBox
    Friend WithEvents lblConvertedWeight As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
