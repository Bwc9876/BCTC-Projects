<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesTax
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesTax))
        Me.lblHomeDepot = New System.Windows.Forms.Label()
        Me.grpOutput = New System.Windows.Forms.Panel()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblTotalLabel = New System.Windows.Forms.Label()
        Me.lblTaxLabel = New System.Windows.Forms.Label()
        Me.lblCostLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpInput = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNameError = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPriceError = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.grpInfo = New System.Windows.Forms.Panel()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.grpOutput.SuspendLayout()
        Me.grpInput.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHomeDepot
        '
        Me.lblHomeDepot.AutoSize = True
        Me.lblHomeDepot.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeDepot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.lblHomeDepot.Location = New System.Drawing.Point(12, 13)
        Me.lblHomeDepot.Name = "lblHomeDepot"
        Me.lblHomeDepot.Size = New System.Drawing.Size(196, 37)
        Me.lblHomeDepot.TabIndex = 0
        Me.lblHomeDepot.Text = "Home Depot"
        '
        'grpOutput
        '
        Me.grpOutput.BackgroundImage = CType(resources.GetObject("grpOutput.BackgroundImage"), System.Drawing.Image)
        Me.grpOutput.Controls.Add(Me.lblHint)
        Me.grpOutput.Controls.Add(Me.lblTotal)
        Me.grpOutput.Controls.Add(Me.lblTax)
        Me.grpOutput.Controls.Add(Me.lblCost)
        Me.grpOutput.Controls.Add(Me.lblTotalLabel)
        Me.grpOutput.Controls.Add(Me.lblTaxLabel)
        Me.grpOutput.Controls.Add(Me.lblCostLabel)
        Me.grpOutput.Controls.Add(Me.Label2)
        Me.grpOutput.Location = New System.Drawing.Point(520, 8)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(466, 486)
        Me.grpOutput.TabIndex = 4
        '
        'lblHint
        '
        Me.lblHint.AutoSize = True
        Me.lblHint.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHint.ForeColor = System.Drawing.Color.White
        Me.lblHint.Location = New System.Drawing.Point(30, 206)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(394, 25)
        Me.lblHint.TabIndex = 15
        Me.lblHint.Text = "Output Will Appear When You Click Calculate"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(308, 367)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(144, 31)
        Me.lblTotal.TabIndex = 14
        Me.lblTotal.Text = "$$$$$$"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTotal.Visible = False
        '
        'lblTax
        '
        Me.lblTax.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.ForeColor = System.Drawing.Color.White
        Me.lblTax.Location = New System.Drawing.Point(308, 239)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(144, 31)
        Me.lblTax.TabIndex = 13
        Me.lblTax.Text = "$$$$$$"
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTax.Visible = False
        '
        'lblCost
        '
        Me.lblCost.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.Color.White
        Me.lblCost.Location = New System.Drawing.Point(308, 105)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(144, 31)
        Me.lblCost.TabIndex = 12
        Me.lblCost.Text = "$$$$$$"
        Me.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCost.Visible = False
        '
        'lblTotalLabel
        '
        Me.lblTotalLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.lblTotalLabel.Location = New System.Drawing.Point(13, 367)
        Me.lblTotalLabel.Name = "lblTotalLabel"
        Me.lblTotalLabel.Size = New System.Drawing.Size(289, 31)
        Me.lblTotalLabel.TabIndex = 11
        Me.lblTotalLabel.Text = "The Total For A Name:"
        Me.lblTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalLabel.Visible = False
        '
        'lblTaxLabel
        '
        Me.lblTaxLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.lblTaxLabel.Location = New System.Drawing.Point(13, 239)
        Me.lblTaxLabel.Name = "lblTaxLabel"
        Me.lblTaxLabel.Size = New System.Drawing.Size(289, 31)
        Me.lblTaxLabel.TabIndex = 10
        Me.lblTaxLabel.Text = "The Tax For A Name:"
        Me.lblTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTaxLabel.Visible = False
        '
        'lblCostLabel
        '
        Me.lblCostLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.lblCostLabel.Location = New System.Drawing.Point(13, 105)
        Me.lblCostLabel.Name = "lblCostLabel"
        Me.lblCostLabel.Size = New System.Drawing.Size(289, 31)
        Me.lblCostLabel.TabIndex = 9
        Me.lblCostLabel.Text = "The Price Of A Name:"
        Me.lblCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCostLabel.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(167, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 45)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Results"
        '
        'grpInput
        '
        Me.grpInput.BackgroundImage = CType(resources.GetObject("grpInput.BackgroundImage"), System.Drawing.Image)
        Me.grpInput.Controls.Add(Me.Label3)
        Me.grpInput.Controls.Add(Me.lblNameError)
        Me.grpInput.Controls.Add(Me.Label1)
        Me.grpInput.Controls.Add(Me.lblPriceError)
        Me.grpInput.Controls.Add(Me.lblPrice)
        Me.grpInput.Controls.Add(Me.txtPrice)
        Me.grpInput.Controls.Add(Me.lblName)
        Me.grpInput.Controls.Add(Me.txtName)
        Me.grpInput.Location = New System.Drawing.Point(238, 63)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(276, 431)
        Me.grpInput.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 37)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "$"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNameError
        '
        Me.lblNameError.BackColor = System.Drawing.Color.OrangeRed
        Me.lblNameError.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameError.ForeColor = System.Drawing.Color.Maroon
        Me.lblNameError.Location = New System.Drawing.Point(16, 206)
        Me.lblNameError.Name = "lblNameError"
        Me.lblNameError.Size = New System.Drawing.Size(243, 35)
        Me.lblNameError.TabIndex = 9
        Me.lblNameError.Text = "Error Text"
        Me.lblNameError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNameError.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 45)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter Item Info"
        '
        'lblPriceError
        '
        Me.lblPriceError.BackColor = System.Drawing.Color.OrangeRed
        Me.lblPriceError.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceError.ForeColor = System.Drawing.Color.Maroon
        Me.lblPriceError.Location = New System.Drawing.Point(16, 375)
        Me.lblPriceError.Name = "lblPriceError"
        Me.lblPriceError.Size = New System.Drawing.Size(243, 35)
        Me.lblPriceError.TabIndex = 8
        Me.lblPriceError.Text = "Error Text"
        Me.lblPriceError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPriceError.Visible = False
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.lblPrice.Location = New System.Drawing.Point(59, 253)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(163, 45)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "Item Price"
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.White
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.ForeColor = System.Drawing.Color.Black
        Me.txtPrice.Location = New System.Drawing.Point(30, 314)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(229, 37)
        Me.txtPrice.TabIndex = 6
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(52, 102)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(179, 45)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Item Name"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(18, 163)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(241, 37)
        Me.txtName.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnCalculate)
        Me.Panel1.Controls.Add(Me.lblHomeDepot)
        Me.Panel1.Controls.Add(Me.picLogo)
        Me.Panel1.Location = New System.Drawing.Point(12, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 431)
        Me.Panel1.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(28, 375)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(164, 35)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(28, 319)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(166, 35)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnCalculate.Enabled = False
        Me.btnCalculate.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btnCalculate.Location = New System.Drawing.Point(28, 263)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(166, 35)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(16, 60)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(188, 181)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 1
        Me.picLogo.TabStop = False
        '
        'grpInfo
        '
        Me.grpInfo.BackgroundImage = Global.SalesTax.My.Resources.Resources.Panel_Background_Fixed
        Me.grpInfo.Controls.Add(Me.lblSalesTax)
        Me.grpInfo.Controls.Add(Me.lblInfo)
        Me.grpInfo.Location = New System.Drawing.Point(12, 8)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(502, 49)
        Me.grpInfo.TabIndex = 5
        '
        'lblSalesTax
        '
        Me.lblSalesTax.AutoSize = True
        Me.lblSalesTax.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesTax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.lblSalesTax.Location = New System.Drawing.Point(138, 12)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(226, 25)
        Me.lblSalesTax.TabIndex = 16
        Me.lblSalesTax.Text = "The Current Sales Tax Is:"
        Me.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.lblInfo.Location = New System.Drawing.Point(8, 6)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(70, 37)
        Me.lblInfo.TabIndex = 3
        Me.lblInfo.Text = "Info"
        '
        'frmSalesTax
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(995, 503)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.grpInput)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSalesTax"
        Me.Text = "Sales Tax Calculator"
        Me.grpOutput.ResumeLayout(False)
        Me.grpOutput.PerformLayout()
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblHomeDepot As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents grpInput As Panel
    Friend WithEvents grpOutput As Panel
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPriceError As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblTotalLabel As Label
    Friend WithEvents lblTaxLabel As Label
    Friend WithEvents lblCostLabel As Label
    Friend WithEvents lblHint As Label
    Friend WithEvents lblNameError As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents grpInfo As Panel
    Friend WithEvents lblSalesTax As Label
    Friend WithEvents lblInfo As Label
End Class
