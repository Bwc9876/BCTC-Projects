<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKitchenPaint
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
        Me.txtFloorWidth = New System.Windows.Forms.TextBox()
        Me.txtFloorLength = New System.Windows.Forms.TextBox()
        Me.txtCeilingHeight = New System.Windows.Forms.TextBox()
        Me.txtGallonPrice = New System.Windows.Forms.TextBox()
        Me.lblFloorWidth = New System.Windows.Forms.Label()
        Me.lblFloorLength = New System.Windows.Forms.Label()
        Me.lblCeilingHeight = New System.Windows.Forms.Label()
        Me.lblGallonPrice = New System.Windows.Forms.Label()
        Me.lblFeet1 = New System.Windows.Forms.Label()
        Me.lblFeet2 = New System.Windows.Forms.Label()
        Me.lblFeet3 = New System.Windows.Forms.Label()
        Me.lblDollar = New System.Windows.Forms.Label()
        Me.lblGallon = New System.Windows.Forms.Label()
        Me.picThumbnail = New System.Windows.Forms.PictureBox()
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCoverage = New System.Windows.Forms.TextBox()
        Me.lblCoverage = New System.Windows.Forms.Label()
        Me.grpResults = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblGallons = New System.Windows.Forms.Label()
        Me.lblSurfaceArea = New System.Windows.Forms.Label()
        Me.lblTotalLabel = New System.Windows.Forms.Label()
        Me.lblTaxLabel = New System.Windows.Forms.Label()
        Me.lblGallonsLabel = New System.Windows.Forms.Label()
        Me.lblSurfaceAreaLabel = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.picThumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInput.SuspendLayout()
        Me.grpResults.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFloorWidth
        '
        Me.txtFloorWidth.BackColor = System.Drawing.Color.LightCyan
        Me.txtFloorWidth.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFloorWidth.Location = New System.Drawing.Point(17, 65)
        Me.txtFloorWidth.Name = "txtFloorWidth"
        Me.txtFloorWidth.Size = New System.Drawing.Size(86, 22)
        Me.txtFloorWidth.TabIndex = 0
        '
        'txtFloorLength
        '
        Me.txtFloorLength.BackColor = System.Drawing.Color.LightCyan
        Me.txtFloorLength.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFloorLength.Location = New System.Drawing.Point(17, 156)
        Me.txtFloorLength.Name = "txtFloorLength"
        Me.txtFloorLength.Size = New System.Drawing.Size(86, 22)
        Me.txtFloorLength.TabIndex = 1
        '
        'txtCeilingHeight
        '
        Me.txtCeilingHeight.BackColor = System.Drawing.Color.LightCyan
        Me.txtCeilingHeight.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCeilingHeight.Location = New System.Drawing.Point(17, 240)
        Me.txtCeilingHeight.Name = "txtCeilingHeight"
        Me.txtCeilingHeight.Size = New System.Drawing.Size(86, 22)
        Me.txtCeilingHeight.TabIndex = 2
        '
        'txtGallonPrice
        '
        Me.txtGallonPrice.BackColor = System.Drawing.Color.LightCyan
        Me.txtGallonPrice.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGallonPrice.Location = New System.Drawing.Point(24, 330)
        Me.txtGallonPrice.Name = "txtGallonPrice"
        Me.txtGallonPrice.Size = New System.Drawing.Size(73, 22)
        Me.txtGallonPrice.TabIndex = 3
        '
        'lblFloorWidth
        '
        Me.lblFloorWidth.AutoSize = True
        Me.lblFloorWidth.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFloorWidth.Location = New System.Drawing.Point(17, 43)
        Me.lblFloorWidth.Name = "lblFloorWidth"
        Me.lblFloorWidth.Size = New System.Drawing.Size(80, 17)
        Me.lblFloorWidth.TabIndex = 4
        Me.lblFloorWidth.Text = "Floor Width"
        '
        'lblFloorLength
        '
        Me.lblFloorLength.AutoSize = True
        Me.lblFloorLength.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFloorLength.Location = New System.Drawing.Point(18, 133)
        Me.lblFloorLength.Name = "lblFloorLength"
        Me.lblFloorLength.Size = New System.Drawing.Size(85, 17)
        Me.lblFloorLength.TabIndex = 5
        Me.lblFloorLength.Text = "Floor Length"
        '
        'lblCeilingHeight
        '
        Me.lblCeilingHeight.AutoSize = True
        Me.lblCeilingHeight.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCeilingHeight.Location = New System.Drawing.Point(18, 220)
        Me.lblCeilingHeight.Name = "lblCeilingHeight"
        Me.lblCeilingHeight.Size = New System.Drawing.Size(93, 17)
        Me.lblCeilingHeight.TabIndex = 6
        Me.lblCeilingHeight.Text = "Ceiling Height"
        '
        'lblGallonPrice
        '
        Me.lblGallonPrice.AutoSize = True
        Me.lblGallonPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGallonPrice.Location = New System.Drawing.Point(17, 307)
        Me.lblGallonPrice.Name = "lblGallonPrice"
        Me.lblGallonPrice.Size = New System.Drawing.Size(103, 17)
        Me.lblGallonPrice.TabIndex = 7
        Me.lblGallonPrice.Text = "Price Per Gallon"
        '
        'lblFeet1
        '
        Me.lblFeet1.AutoSize = True
        Me.lblFeet1.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeet1.Location = New System.Drawing.Point(103, 68)
        Me.lblFeet1.Name = "lblFeet1"
        Me.lblFeet1.Size = New System.Drawing.Size(15, 13)
        Me.lblFeet1.TabIndex = 8
        Me.lblFeet1.Text = "ft."
        '
        'lblFeet2
        '
        Me.lblFeet2.AutoSize = True
        Me.lblFeet2.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeet2.Location = New System.Drawing.Point(104, 159)
        Me.lblFeet2.Name = "lblFeet2"
        Me.lblFeet2.Size = New System.Drawing.Size(15, 13)
        Me.lblFeet2.TabIndex = 9
        Me.lblFeet2.Text = "ft."
        '
        'lblFeet3
        '
        Me.lblFeet3.AutoSize = True
        Me.lblFeet3.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeet3.Location = New System.Drawing.Point(104, 243)
        Me.lblFeet3.Name = "lblFeet3"
        Me.lblFeet3.Size = New System.Drawing.Size(15, 13)
        Me.lblFeet3.TabIndex = 10
        Me.lblFeet3.Text = "ft."
        '
        'lblDollar
        '
        Me.lblDollar.AutoSize = True
        Me.lblDollar.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDollar.Location = New System.Drawing.Point(9, 333)
        Me.lblDollar.Name = "lblDollar"
        Me.lblDollar.Size = New System.Drawing.Size(13, 13)
        Me.lblDollar.TabIndex = 11
        Me.lblDollar.Text = "$"
        '
        'lblGallon
        '
        Me.lblGallon.AutoSize = True
        Me.lblGallon.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGallon.Location = New System.Drawing.Point(103, 339)
        Me.lblGallon.Name = "lblGallon"
        Me.lblGallon.Size = New System.Drawing.Size(39, 13)
        Me.lblGallon.TabIndex = 12
        Me.lblGallon.Text = "/Gallon"
        '
        'picThumbnail
        '
        Me.picThumbnail.BackColor = System.Drawing.Color.SlateGray
        Me.picThumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picThumbnail.Image = Global.KitchenPaint.My.Resources.Resources.KitchenPaint
        Me.picThumbnail.Location = New System.Drawing.Point(160, 38)
        Me.picThumbnail.Name = "picThumbnail"
        Me.picThumbnail.Size = New System.Drawing.Size(481, 374)
        Me.picThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picThumbnail.TabIndex = 13
        Me.picThumbnail.TabStop = False
        '
        'grpInput
        '
        Me.grpInput.BackColor = System.Drawing.Color.Plum
        Me.grpInput.Controls.Add(Me.Label1)
        Me.grpInput.Controls.Add(Me.txtCoverage)
        Me.grpInput.Controls.Add(Me.lblCoverage)
        Me.grpInput.Controls.Add(Me.lblGallon)
        Me.grpInput.Controls.Add(Me.lblFeet3)
        Me.grpInput.Controls.Add(Me.lblDollar)
        Me.grpInput.Controls.Add(Me.lblFeet2)
        Me.grpInput.Controls.Add(Me.lblFeet1)
        Me.grpInput.Controls.Add(Me.lblGallonPrice)
        Me.grpInput.Controls.Add(Me.lblCeilingHeight)
        Me.grpInput.Controls.Add(Me.lblFloorLength)
        Me.grpInput.Controls.Add(Me.lblFloorWidth)
        Me.grpInput.Controls.Add(Me.txtGallonPrice)
        Me.grpInput.Controls.Add(Me.txtCeilingHeight)
        Me.grpInput.Controls.Add(Me.txtFloorLength)
        Me.grpInput.Controls.Add(Me.txtFloorWidth)
        Me.grpInput.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInput.Location = New System.Drawing.Point(-2, -1)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(160, 458)
        Me.grpInput.TabIndex = 14
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Enter Values"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 415)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ft.²/Gallon"
        '
        'txtCoverage
        '
        Me.txtCoverage.BackColor = System.Drawing.Color.LightCyan
        Me.txtCoverage.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCoverage.Location = New System.Drawing.Point(17, 406)
        Me.txtCoverage.Name = "txtCoverage"
        Me.txtCoverage.Size = New System.Drawing.Size(86, 22)
        Me.txtCoverage.TabIndex = 14
        '
        'lblCoverage
        '
        Me.lblCoverage.AutoSize = True
        Me.lblCoverage.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoverage.Location = New System.Drawing.Point(17, 385)
        Me.lblCoverage.Name = "lblCoverage"
        Me.lblCoverage.Size = New System.Drawing.Size(65, 17)
        Me.lblCoverage.TabIndex = 13
        Me.lblCoverage.Text = "Coverage"
        '
        'grpResults
        '
        Me.grpResults.BackColor = System.Drawing.Color.Plum
        Me.grpResults.Controls.Add(Me.lblTotal)
        Me.grpResults.Controls.Add(Me.lblTax)
        Me.grpResults.Controls.Add(Me.lblGallons)
        Me.grpResults.Controls.Add(Me.lblSurfaceArea)
        Me.grpResults.Controls.Add(Me.lblTotalLabel)
        Me.grpResults.Controls.Add(Me.lblTaxLabel)
        Me.grpResults.Controls.Add(Me.lblGallonsLabel)
        Me.grpResults.Controls.Add(Me.lblSurfaceAreaLabel)
        Me.grpResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpResults.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpResults.Location = New System.Drawing.Point(643, -1)
        Me.grpResults.Name = "grpResults"
        Me.grpResults.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpResults.Size = New System.Drawing.Size(195, 458)
        Me.grpResults.TabIndex = 15
        Me.grpResults.TabStop = False
        Me.grpResults.Text = "Results"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.LightCyan
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(9, 381)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotal.Size = New System.Drawing.Size(72, 34)
        Me.lblTotal.TabIndex = 19
        Me.lblTotal.Text = "Value"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblTotal.Visible = False
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.BackColor = System.Drawing.Color.LightCyan
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(9, 282)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTax.Size = New System.Drawing.Size(72, 34)
        Me.lblTax.TabIndex = 18
        Me.lblTax.Text = "Value"
        Me.lblTax.Visible = False
        '
        'lblGallons
        '
        Me.lblGallons.AutoSize = True
        Me.lblGallons.BackColor = System.Drawing.Color.LightCyan
        Me.lblGallons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGallons.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGallons.Location = New System.Drawing.Point(9, 171)
        Me.lblGallons.Name = "lblGallons"
        Me.lblGallons.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblGallons.Size = New System.Drawing.Size(72, 34)
        Me.lblGallons.TabIndex = 17
        Me.lblGallons.Text = "Value"
        Me.lblGallons.Visible = False
        '
        'lblSurfaceArea
        '
        Me.lblSurfaceArea.AutoSize = True
        Me.lblSurfaceArea.BackColor = System.Drawing.Color.LightCyan
        Me.lblSurfaceArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSurfaceArea.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurfaceArea.Location = New System.Drawing.Point(9, 65)
        Me.lblSurfaceArea.Name = "lblSurfaceArea"
        Me.lblSurfaceArea.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSurfaceArea.Size = New System.Drawing.Size(72, 34)
        Me.lblSurfaceArea.TabIndex = 16
        Me.lblSurfaceArea.Text = "Value"
        Me.lblSurfaceArea.Visible = False
        '
        'lblTotalLabel
        '
        Me.lblTotalLabel.AutoSize = True
        Me.lblTotalLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLabel.Location = New System.Drawing.Point(6, 351)
        Me.lblTotalLabel.Name = "lblTotalLabel"
        Me.lblTotalLabel.Size = New System.Drawing.Size(80, 20)
        Me.lblTotalLabel.TabIndex = 7
        Me.lblTotalLabel.Text = "Total Price"
        '
        'lblTaxLabel
        '
        Me.lblTaxLabel.AutoSize = True
        Me.lblTaxLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxLabel.Location = New System.Drawing.Point(6, 251)
        Me.lblTaxLabel.Name = "lblTaxLabel"
        Me.lblTaxLabel.Size = New System.Drawing.Size(32, 20)
        Me.lblTaxLabel.TabIndex = 6
        Me.lblTaxLabel.Text = "Tax"
        '
        'lblGallonsLabel
        '
        Me.lblGallonsLabel.AutoSize = True
        Me.lblGallonsLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGallonsLabel.Location = New System.Drawing.Point(6, 141)
        Me.lblGallonsLabel.Name = "lblGallonsLabel"
        Me.lblGallonsLabel.Size = New System.Drawing.Size(118, 20)
        Me.lblGallonsLabel.TabIndex = 5
        Me.lblGallonsLabel.Text = "Gallons Of Paint"
        '
        'lblSurfaceAreaLabel
        '
        Me.lblSurfaceAreaLabel.AutoSize = True
        Me.lblSurfaceAreaLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurfaceAreaLabel.Location = New System.Drawing.Point(6, 36)
        Me.lblSurfaceAreaLabel.Name = "lblSurfaceAreaLabel"
        Me.lblSurfaceAreaLabel.Size = New System.Drawing.Size(96, 20)
        Me.lblSurfaceAreaLabel.TabIndex = 4
        Me.lblSurfaceAreaLabel.Text = "Surface Area"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Brown
        Me.lblError.Location = New System.Drawing.Point(160, 6)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(118, 30)
        Me.lblError.TabIndex = 16
        Me.lblError.Text = "Error Text"
        Me.lblError.Visible = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.SpringGreen
        Me.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.btnCalculate.FlatAppearance.BorderSize = 3
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.btnCalculate.Location = New System.Drawing.Point(3, 2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(167, 29)
        Me.btnCalculate.TabIndex = 17
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.IndianRed
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.btnExit.FlatAppearance.BorderSize = 3
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DarkRed
        Me.btnExit.Location = New System.Drawing.Point(331, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(145, 29)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Cyan
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnClear.FlatAppearance.BorderSize = 3
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnClear.Location = New System.Drawing.Point(176, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(149, 29)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnCalculate)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Location = New System.Drawing.Point(160, 416)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(481, 34)
        Me.Panel1.TabIndex = 20
        '
        'frmKitchenPaint
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(836, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.grpResults)
        Me.Controls.Add(Me.grpInput)
        Me.Controls.Add(Me.picThumbnail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmKitchenPaint"
        Me.ShowIcon = False
        Me.Text = "Kitchen Paint"
        CType(Me.picThumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.grpResults.ResumeLayout(False)
        Me.grpResults.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFloorWidth As TextBox
    Friend WithEvents txtFloorLength As TextBox
    Friend WithEvents txtCeilingHeight As TextBox
    Friend WithEvents txtGallonPrice As TextBox
    Friend WithEvents lblFloorWidth As Label
    Friend WithEvents lblFloorLength As Label
    Friend WithEvents lblCeilingHeight As Label
    Friend WithEvents lblGallonPrice As Label
    Friend WithEvents lblFeet1 As Label
    Friend WithEvents lblFeet2 As Label
    Friend WithEvents lblFeet3 As Label
    Friend WithEvents lblDollar As Label
    Friend WithEvents lblGallon As Label
    Friend WithEvents picThumbnail As PictureBox
    Friend WithEvents grpInput As GroupBox
    Friend WithEvents grpResults As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblGallons As Label
    Friend WithEvents lblSurfaceArea As Label
    Friend WithEvents lblTotalLabel As Label
    Friend WithEvents lblTaxLabel As Label
    Friend WithEvents lblGallonsLabel As Label
    Friend WithEvents lblSurfaceAreaLabel As Label
    Friend WithEvents lblError As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCoverage As TextBox
    Friend WithEvents lblCoverage As Label
End Class
