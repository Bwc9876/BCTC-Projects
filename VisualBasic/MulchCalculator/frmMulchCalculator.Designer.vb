<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMulchCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMulchCalculator))
        Me.grpInputs = New System.Windows.Forms.GroupBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpResults = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalLabel = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblSubTotalLabel = New System.Windows.Forms.Label()
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.lblVolumeLabel = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.lblDeliveryFee = New System.Windows.Forms.Label()
        Me.lblPricePerFoot = New System.Windows.Forms.Label()
        Me.grpDepth = New MulchCalculator.InputField()
        Me.grpWidth = New MulchCalculator.InputField()
        Me.grpLength = New MulchCalculator.InputField()
        Me.grpInputs.SuspendLayout()
        Me.grpResults.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpInputs
        '
        Me.grpInputs.BackColor = System.Drawing.Color.MediumTurquoise
        Me.grpInputs.Controls.Add(Me.grpDepth)
        Me.grpInputs.Controls.Add(Me.grpWidth)
        Me.grpInputs.Controls.Add(Me.grpLength)
        Me.grpInputs.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInputs.Location = New System.Drawing.Point(12, 61)
        Me.grpInputs.Name = "grpInputs"
        Me.grpInputs.Size = New System.Drawing.Size(190, 426)
        Me.grpInputs.TabIndex = 4
        Me.grpInputs.TabStop = False
        Me.grpInputs.Text = "Input Values"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.DarkGray
        Me.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.Cyan
        Me.btnCalculate.FlatAppearance.BorderSize = 3
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Location = New System.Drawing.Point(212, 379)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(242, 32)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'grpResults
        '
        Me.grpResults.BackColor = System.Drawing.Color.MediumTurquoise
        Me.grpResults.Controls.Add(Me.lblTotal)
        Me.grpResults.Controls.Add(Me.lblTotalLabel)
        Me.grpResults.Controls.Add(Me.lblSubTotal)
        Me.grpResults.Controls.Add(Me.lblSubTotalLabel)
        Me.grpResults.Controls.Add(Me.lblVolume)
        Me.grpResults.Controls.Add(Me.lblVolumeLabel)
        Me.grpResults.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpResults.Location = New System.Drawing.Point(464, 61)
        Me.grpResults.Name = "grpResults"
        Me.grpResults.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpResults.Size = New System.Drawing.Size(190, 426)
        Me.grpResults.TabIndex = 6
        Me.grpResults.TabStop = False
        Me.grpResults.Text = "Results"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.LightCyan
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(72, 332)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(112, 20)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "Value"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTotal.Visible = False
        '
        'lblTotalLabel
        '
        Me.lblTotalLabel.AutoSize = True
        Me.lblTotalLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLabel.Location = New System.Drawing.Point(4, 332)
        Me.lblTotalLabel.Name = "lblTotalLabel"
        Me.lblTotalLabel.Size = New System.Drawing.Size(42, 20)
        Me.lblTotalLabel.TabIndex = 4
        Me.lblTotalLabel.Text = "Total"
        Me.lblTotalLabel.Visible = False
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.Color.LightCyan
        Me.lblSubTotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(72, 203)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(112, 20)
        Me.lblSubTotal.TabIndex = 3
        Me.lblSubTotal.Text = "Value"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSubTotal.Visible = False
        '
        'lblSubTotalLabel
        '
        Me.lblSubTotalLabel.AutoSize = True
        Me.lblSubTotalLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotalLabel.Location = New System.Drawing.Point(2, 203)
        Me.lblSubTotalLabel.Name = "lblSubTotalLabel"
        Me.lblSubTotalLabel.Size = New System.Drawing.Size(71, 20)
        Me.lblSubTotalLabel.TabIndex = 2
        Me.lblSubTotalLabel.Text = "Sub Total"
        Me.lblSubTotalLabel.Visible = False
        '
        'lblVolume
        '
        Me.lblVolume.BackColor = System.Drawing.Color.LightCyan
        Me.lblVolume.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolume.Location = New System.Drawing.Point(66, 45)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(118, 20)
        Me.lblVolume.TabIndex = 1
        Me.lblVolume.Text = "Value"
        Me.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblVolume.Visible = False
        '
        'lblVolumeLabel
        '
        Me.lblVolumeLabel.AutoSize = True
        Me.lblVolumeLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolumeLabel.Location = New System.Drawing.Point(1, 45)
        Me.lblVolumeLabel.Name = "lblVolumeLabel"
        Me.lblVolumeLabel.Size = New System.Drawing.Size(59, 20)
        Me.lblVolumeLabel.TabIndex = 0
        Me.lblVolumeLabel.Text = "Volume"
        Me.lblVolumeLabel.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DarkGray
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Cyan
        Me.btnClear.FlatAppearance.BorderSize = 3
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(212, 417)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(242, 32)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DarkGray
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Cyan
        Me.btnExit.FlatAppearance.BorderSize = 3
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(212, 455)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(242, 32)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.MulchCalculator.My.Resources.Resources.Playground
        Me.PictureBox1.Location = New System.Drawing.Point(212, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(242, 311)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'grpInfo
        '
        Me.grpInfo.BackColor = System.Drawing.Color.MediumTurquoise
        Me.grpInfo.Controls.Add(Me.lblDeliveryFee)
        Me.grpInfo.Controls.Add(Me.lblPricePerFoot)
        Me.grpInfo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInfo.Location = New System.Drawing.Point(12, 11)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(642, 44)
        Me.grpInfo.TabIndex = 10
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Info"
        '
        'lblDeliveryFee
        '
        Me.lblDeliveryFee.AutoSize = True
        Me.lblDeliveryFee.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeliveryFee.Location = New System.Drawing.Point(378, 11)
        Me.lblDeliveryFee.Name = "lblDeliveryFee"
        Me.lblDeliveryFee.Size = New System.Drawing.Size(130, 30)
        Me.lblDeliveryFee.TabIndex = 1
        Me.lblDeliveryFee.Text = "Delivery Fee:"
        '
        'lblPricePerFoot
        '
        Me.lblPricePerFoot.AutoSize = True
        Me.lblPricePerFoot.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPricePerFoot.Location = New System.Drawing.Point(41, 11)
        Me.lblPricePerFoot.Name = "lblPricePerFoot"
        Me.lblPricePerFoot.Size = New System.Drawing.Size(203, 30)
        Me.lblPricePerFoot.TabIndex = 0
        Me.lblPricePerFoot.Text = "Price Per Cubic Foot:"
        '
        'grpDepth
        '
        Me.grpDepth.blnIsValid = False
        Me.grpDepth.clrInvalidColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grpDepth.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDepth.funValidityHandler = Nothing
        Me.grpDepth.Location = New System.Drawing.Point(20, 326)
        Me.grpDepth.Name = "grpDepth"
        Me.grpDepth.Size = New System.Drawing.Size(150, 90)
        Me.grpDepth.strValue = ""
        Me.grpDepth.TabIndex = 3
        Me.grpDepth.TabStop = False
        Me.grpDepth.Text = "Depth (ft)"
        '
        'grpWidth
        '
        Me.grpWidth.blnIsValid = False
        Me.grpWidth.clrInvalidColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grpWidth.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpWidth.funValidityHandler = Nothing
        Me.grpWidth.Location = New System.Drawing.Point(20, 180)
        Me.grpWidth.Name = "grpWidth"
        Me.grpWidth.Size = New System.Drawing.Size(150, 90)
        Me.grpWidth.strValue = ""
        Me.grpWidth.TabIndex = 2
        Me.grpWidth.TabStop = False
        Me.grpWidth.Text = "Width (ft)"
        '
        'grpLength
        '
        Me.grpLength.blnIsValid = False
        Me.grpLength.clrInvalidColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grpLength.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLength.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpLength.funValidityHandler = Nothing
        Me.grpLength.Location = New System.Drawing.Point(20, 28)
        Me.grpLength.Name = "grpLength"
        Me.grpLength.Size = New System.Drawing.Size(150, 90)
        Me.grpLength.strValue = ""
        Me.grpLength.TabIndex = 0
        Me.grpLength.TabStop = False
        Me.grpLength.Text = "Length (ft)"
        '
        'frmMulchCalculator
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(666, 499)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.grpResults)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpInputs)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMulchCalculator"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mulch Calculator"
        Me.grpInputs.ResumeLayout(False)
        Me.grpResults.ResumeLayout(False)
        Me.grpResults.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpLength As InputField
    Friend WithEvents grpWidth As InputField
    Friend WithEvents grpDepth As InputField
    Friend WithEvents grpInputs As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents grpResults As GroupBox
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblSubTotalLabel As Label
    Friend WithEvents lblVolume As Label
    Friend WithEvents lblVolumeLabel As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalLabel As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpInfo As GroupBox
    Friend WithEvents lblPricePerFoot As Label
    Friend WithEvents lblDeliveryFee As Label
End Class
