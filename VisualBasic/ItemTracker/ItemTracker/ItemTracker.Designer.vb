<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemTracker
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
        Me.lstCurrent = New System.Windows.Forms.ListBox()
        Me.lblCurrentItems = New System.Windows.Forms.Label()
        Me.lblUpdatedItems = New System.Windows.Forms.Label()
        Me.lstUpdated = New System.Windows.Forms.ListBox()
        Me.txtItemAdd = New System.Windows.Forms.TextBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.grpItemAdd = New System.Windows.Forms.GroupBox()
        Me.lblFireWarning = New System.Windows.Forms.Label()
        Me.lblDirections = New System.Windows.Forms.Label()
        Me.lblExample = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpItemAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstCurrent
        '
        Me.lstCurrent.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lstCurrent.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCurrent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.lstCurrent.FormattingEnabled = True
        Me.lstCurrent.ItemHeight = 21
        Me.lstCurrent.Location = New System.Drawing.Point(12, 36)
        Me.lstCurrent.Name = "lstCurrent"
        Me.lstCurrent.Size = New System.Drawing.Size(131, 277)
        Me.lstCurrent.TabIndex = 0
        '
        'lblCurrentItems
        '
        Me.lblCurrentItems.AutoSize = True
        Me.lblCurrentItems.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblCurrentItems.Location = New System.Drawing.Point(12, 9)
        Me.lblCurrentItems.Name = "lblCurrentItems"
        Me.lblCurrentItems.Size = New System.Drawing.Size(105, 21)
        Me.lblCurrentItems.TabIndex = 1
        Me.lblCurrentItems.Text = "Current Items"
        '
        'lblUpdatedItems
        '
        Me.lblUpdatedItems.AutoSize = True
        Me.lblUpdatedItems.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdatedItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblUpdatedItems.Location = New System.Drawing.Point(490, 9)
        Me.lblUpdatedItems.Name = "lblUpdatedItems"
        Me.lblUpdatedItems.Size = New System.Drawing.Size(111, 21)
        Me.lblUpdatedItems.TabIndex = 3
        Me.lblUpdatedItems.Text = "Updated Items"
        '
        'lstUpdated
        '
        Me.lstUpdated.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lstUpdated.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUpdated.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.lstUpdated.FormattingEnabled = True
        Me.lstUpdated.ItemHeight = 21
        Me.lstUpdated.Location = New System.Drawing.Point(470, 36)
        Me.lstUpdated.Name = "lstUpdated"
        Me.lstUpdated.Size = New System.Drawing.Size(131, 277)
        Me.lstUpdated.TabIndex = 2
        '
        'txtItemAdd
        '
        Me.txtItemAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtItemAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtItemAdd.Location = New System.Drawing.Point(6, 21)
        Me.txtItemAdd.Name = "txtItemAdd"
        Me.txtItemAdd.Size = New System.Drawing.Size(303, 29)
        Me.txtItemAdd.TabIndex = 5
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnAddItem.Location = New System.Drawing.Point(6, 58)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(303, 23)
        Me.btnAddItem.TabIndex = 6
        Me.btnAddItem.Text = "Add"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'btnProcess
        '
        Me.btnProcess.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcess.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnProcess.Location = New System.Drawing.Point(149, 232)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(315, 23)
        Me.btnProcess.TabIndex = 7
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = False
        '
        'grpItemAdd
        '
        Me.grpItemAdd.Controls.Add(Me.txtItemAdd)
        Me.grpItemAdd.Controls.Add(Me.btnAddItem)
        Me.grpItemAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.grpItemAdd.Location = New System.Drawing.Point(149, 124)
        Me.grpItemAdd.Name = "grpItemAdd"
        Me.grpItemAdd.Size = New System.Drawing.Size(315, 88)
        Me.grpItemAdd.TabIndex = 8
        Me.grpItemAdd.TabStop = False
        Me.grpItemAdd.Text = "Add Item"
        '
        'lblFireWarning
        '
        Me.lblFireWarning.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblFireWarning.Location = New System.Drawing.Point(183, 77)
        Me.lblFireWarning.Name = "lblFireWarning"
        Me.lblFireWarning.Size = New System.Drawing.Size(247, 32)
        Me.lblFireWarning.TabIndex = 9
        Me.lblFireWarning.Text = "Wharehouse HOUSE Is On fire, Items In It Will Be Moved To TARGET_HOUSE"
        Me.lblFireWarning.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDirections
        '
        Me.lblDirections.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblDirections.Location = New System.Drawing.Point(157, 9)
        Me.lblDirections.Name = "lblDirections"
        Me.lblDirections.Size = New System.Drawing.Size(301, 48)
        Me.lblDirections.TabIndex = 10
        Me.lblDirections.Text = "Item Identifiers are 12 characters where the first 5 letters are the description," &
    " the next 3 is the description, the next 2 is the shelf number, and the last 2 i" &
    "s the bin number"
        Me.lblDirections.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblExample
        '
        Me.lblExample.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExample.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblExample.Location = New System.Drawing.Point(235, 57)
        Me.lblExample.Name = "lblExample"
        Me.lblExample.Size = New System.Drawing.Size(146, 20)
        Me.lblExample.TabIndex = 11
        Me.lblExample.Text = "Ex: Pizza52A4356"
        Me.lblExample.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(149, 261)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(315, 23)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(149, 290)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(315, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'ItemTracker
        '
        Me.AcceptButton = Me.btnAddItem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(613, 321)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblExample)
        Me.Controls.Add(Me.lblDirections)
        Me.Controls.Add(Me.lblFireWarning)
        Me.Controls.Add(Me.grpItemAdd)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.lblUpdatedItems)
        Me.Controls.Add(Me.lstUpdated)
        Me.Controls.Add(Me.lblCurrentItems)
        Me.Controls.Add(Me.lstCurrent)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ItemTracker"
        Me.ShowIcon = False
        Me.Text = "Item Tracker"
        Me.grpItemAdd.ResumeLayout(False)
        Me.grpItemAdd.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstCurrent As ListBox
    Friend WithEvents lblCurrentItems As Label
    Friend WithEvents lblUpdatedItems As Label
    Friend WithEvents lstUpdated As ListBox
    Friend WithEvents txtItemAdd As TextBox
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnProcess As Button
    Friend WithEvents grpItemAdd As GroupBox
    Friend WithEvents lblFireWarning As Label
    Friend WithEvents lblDirections As Label
    Friend WithEvents lblExample As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
