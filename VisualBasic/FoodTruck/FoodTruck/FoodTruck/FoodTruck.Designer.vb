<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FoodTruck
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FoodTruck))
        Me.menMain = New System.Windows.Forms.MenuStrip()
        Me.btnFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstMenu = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lstCart = New System.Windows.Forms.ListBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.grpMenu = New System.Windows.Forms.GroupBox()
        Me.grpCart = New System.Windows.Forms.GroupBox()
        Me.btnCartClear = New System.Windows.Forms.Button()
        Me.txtTip = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.menMain.SuspendLayout()
        Me.grpMenu.SuspendLayout()
        Me.grpCart.SuspendLayout()
        CType(Me.txtTip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menMain
        '
        Me.menMain.BackColor = System.Drawing.Color.Bisque
        Me.menMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFile})
        Me.menMain.Location = New System.Drawing.Point(0, 0)
        Me.menMain.Name = "menMain"
        Me.menMain.Size = New System.Drawing.Size(822, 24)
        Me.menMain.TabIndex = 0
        Me.menMain.Text = "menMain"
        '
        'btnFile
        '
        Me.btnFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EndToolStripMenuItem, Me.btnExit})
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(37, 20)
        Me.btnFile.Text = "File"
        '
        'EndToolStripMenuItem
        '
        Me.EndToolStripMenuItem.Name = "EndToolStripMenuItem"
        Me.EndToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.EndToolStripMenuItem.Text = "End"
        '
        'btnExit
        '
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 22)
        Me.btnExit.Text = "Exit"
        '
        'lstMenu
        '
        Me.lstMenu.BackColor = System.Drawing.Color.SeaShell
        Me.lstMenu.FormattingEnabled = True
        Me.lstMenu.Location = New System.Drawing.Point(11, 15)
        Me.lstMenu.Name = "lstMenu"
        Me.lstMenu.Size = New System.Drawing.Size(278, 199)
        Me.lstMenu.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.FlatAppearance.BorderSize = 2
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(318, 78)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(186, 37)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add to Cart"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lstCart
        '
        Me.lstCart.BackColor = System.Drawing.Color.SeaShell
        Me.lstCart.FormattingEnabled = True
        Me.lstCart.Location = New System.Drawing.Point(11, 15)
        Me.lstCart.Name = "lstCart"
        Me.lstCart.Size = New System.Drawing.Size(278, 199)
        Me.lstCart.TabIndex = 3
        '
        'btnRemove
        '
        Me.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRemove.FlatAppearance.BorderSize = 2
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Location = New System.Drawing.Point(318, 133)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(186, 37)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "Remove From Cart"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'grpMenu
        '
        Me.grpMenu.Controls.Add(Me.lstMenu)
        Me.grpMenu.Location = New System.Drawing.Point(12, 44)
        Me.grpMenu.Name = "grpMenu"
        Me.grpMenu.Size = New System.Drawing.Size(300, 232)
        Me.grpMenu.TabIndex = 5
        Me.grpMenu.TabStop = False
        Me.grpMenu.Text = "Menu"
        '
        'grpCart
        '
        Me.grpCart.Controls.Add(Me.lstCart)
        Me.grpCart.Location = New System.Drawing.Point(510, 48)
        Me.grpCart.Name = "grpCart"
        Me.grpCart.Size = New System.Drawing.Size(300, 228)
        Me.grpCart.TabIndex = 6
        Me.grpCart.TabStop = False
        Me.grpCart.Text = "Cart"
        '
        'btnCartClear
        '
        Me.btnCartClear.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCartClear.FlatAppearance.BorderSize = 2
        Me.btnCartClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCartClear.Location = New System.Drawing.Point(318, 188)
        Me.btnCartClear.Name = "btnCartClear"
        Me.btnCartClear.Size = New System.Drawing.Size(186, 37)
        Me.btnCartClear.TabIndex = 7
        Me.btnCartClear.Text = "Clear Cart"
        Me.btnCartClear.UseVisualStyleBackColor = True
        '
        'txtTip
        '
        Me.txtTip.Location = New System.Drawing.Point(84, 20)
        Me.txtTip.Name = "txtTip"
        Me.txtTip.Size = New System.Drawing.Size(120, 22)
        Me.txtTip.TabIndex = 8
        Me.txtTip.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTip)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 282)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 62)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Tip (%)"
        '
        'btnCheckout
        '
        Me.btnCheckout.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCheckout.FlatAppearance.BorderSize = 2
        Me.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckout.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.Location = New System.Drawing.Point(510, 358)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(300, 62)
        Me.btnCheckout.TabIndex = 10
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'lblSubTotal
        '
        Me.lblSubTotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(507, 279)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(303, 21)
        Me.lblSubTotal.TabIndex = 11
        Me.lblSubTotal.Text = "Sub Total: $0.00"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(507, 321)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(303, 34)
        Me.lblTotal.TabIndex = 12
        Me.lblTotal.Text = "Total: $0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTax
        '
        Me.lblTax.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(507, 300)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(303, 21)
        Me.lblTax.TabIndex = 13
        Me.lblTax.Text = "Tip: $0.00 (20%)"
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInfo
        '
        Me.lblInfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(9, 347)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(492, 70)
        Me.lblInfo.TabIndex = 14
        Me.lblInfo.Text = resources.GetString("lblInfo.Text")
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'FoodTruck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(822, 433)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCartClear)
        Me.Controls.Add(Me.grpCart)
        Me.Controls.Add(Me.grpMenu)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.menMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.menMain
        Me.MaximizeBox = False
        Me.Name = "FoodTruck"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Food Truck"
        Me.menMain.ResumeLayout(False)
        Me.menMain.PerformLayout()
        Me.grpMenu.ResumeLayout(False)
        Me.grpCart.ResumeLayout(False)
        CType(Me.txtTip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menMain As MenuStrip
    Friend WithEvents btnFile As ToolStripMenuItem
    Friend WithEvents btnExit As ToolStripMenuItem
    Friend WithEvents lstMenu As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lstCart As ListBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents grpMenu As GroupBox
    Friend WithEvents grpCart As GroupBox
    Friend WithEvents btnCartClear As Button
    Friend WithEvents EndToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtTip As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCheckout As Button
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblInfo As Label
End Class
