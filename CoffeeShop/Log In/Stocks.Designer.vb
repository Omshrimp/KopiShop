<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stocks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stocks))
        Me.dgSRecords = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtPName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.pbLogOut = New System.Windows.Forms.PictureBox()
        Me.pbHome = New System.Windows.Forms.PictureBox()
        Me.pbStocks = New System.Windows.Forms.PictureBox()
        Me.pbCashier = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.pbTerminate = New System.Windows.Forms.PictureBox()
        Me.pbUsers = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gpbToggle = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mnuCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        CType(Me.dgSRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCashier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbTerminate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbToggle.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgSRecords
        '
        Me.dgSRecords.AllowUserToResizeColumns = False
        Me.dgSRecords.AllowUserToResizeRows = False
        Me.dgSRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgSRecords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgSRecords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgSRecords.ColumnHeadersHeight = 29
        Me.dgSRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgSRecords.Enabled = False
        Me.dgSRecords.Location = New System.Drawing.Point(169, 316)
        Me.dgSRecords.Name = "dgSRecords"
        Me.dgSRecords.ReadOnly = True
        Me.dgSRecords.RowHeadersWidth = 51
        Me.dgSRecords.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgSRecords.RowTemplate.Height = 24
        Me.dgSRecords.Size = New System.Drawing.Size(862, 317)
        Me.dgSRecords.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Garamond", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Linen
        Me.Label6.Location = New System.Drawing.Point(468, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Stocks:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Garamond", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Linen
        Me.Label5.Location = New System.Drawing.Point(468, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Garamond", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Linen
        Me.Label4.Location = New System.Drawing.Point(18, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Product Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Garamond", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Linen
        Me.Label3.Location = New System.Drawing.Point(43, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Product ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Garamond", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Linen
        Me.Label2.Location = New System.Drawing.Point(27, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Search By ID:"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(544, 122)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(248, 22)
        Me.txtStock.TabIndex = 4
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(544, 77)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(248, 22)
        Me.txtPrice.TabIndex = 3
        '
        'txtPName
        '
        Me.txtPName.Location = New System.Drawing.Point(157, 122)
        Me.txtPName.Name = "txtPName"
        Me.txtPName.Size = New System.Drawing.Size(248, 22)
        Me.txtPName.TabIndex = 2
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(158, 77)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(248, 22)
        Me.txtID.TabIndex = 1
        '
        'pbLogOut
        '
        Me.pbLogOut.BackColor = System.Drawing.Color.Transparent
        Me.pbLogOut.Image = CType(resources.GetObject("pbLogOut.Image"), System.Drawing.Image)
        Me.pbLogOut.InitialImage = CType(resources.GetObject("pbLogOut.InitialImage"), System.Drawing.Image)
        Me.pbLogOut.Location = New System.Drawing.Point(18, 600)
        Me.pbLogOut.Margin = New System.Windows.Forms.Padding(0)
        Me.pbLogOut.Name = "pbLogOut"
        Me.pbLogOut.Size = New System.Drawing.Size(43, 39)
        Me.pbLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogOut.TabIndex = 21
        Me.pbLogOut.TabStop = False
        '
        'pbHome
        '
        Me.pbHome.BackColor = System.Drawing.Color.Transparent
        Me.pbHome.Image = CType(resources.GetObject("pbHome.Image"), System.Drawing.Image)
        Me.pbHome.InitialImage = CType(resources.GetObject("pbHome.InitialImage"), System.Drawing.Image)
        Me.pbHome.Location = New System.Drawing.Point(6, 18)
        Me.pbHome.Margin = New System.Windows.Forms.Padding(0)
        Me.pbHome.Name = "pbHome"
        Me.pbHome.Size = New System.Drawing.Size(69, 53)
        Me.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHome.TabIndex = 21
        Me.pbHome.TabStop = False
        '
        'pbStocks
        '
        Me.pbStocks.BackColor = System.Drawing.Color.Transparent
        Me.pbStocks.Image = CType(resources.GetObject("pbStocks.Image"), System.Drawing.Image)
        Me.pbStocks.InitialImage = CType(resources.GetObject("pbStocks.InitialImage"), System.Drawing.Image)
        Me.pbStocks.Location = New System.Drawing.Point(6, 241)
        Me.pbStocks.Margin = New System.Windows.Forms.Padding(0)
        Me.pbStocks.Name = "pbStocks"
        Me.pbStocks.Size = New System.Drawing.Size(55, 45)
        Me.pbStocks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbStocks.TabIndex = 7
        Me.pbStocks.TabStop = False
        '
        'pbCashier
        '
        Me.pbCashier.BackColor = System.Drawing.Color.Transparent
        Me.pbCashier.Image = CType(resources.GetObject("pbCashier.Image"), System.Drawing.Image)
        Me.pbCashier.InitialImage = CType(resources.GetObject("pbCashier.InitialImage"), System.Drawing.Image)
        Me.pbCashier.Location = New System.Drawing.Point(6, 309)
        Me.pbCashier.Margin = New System.Windows.Forms.Padding(0)
        Me.pbCashier.Name = "pbCashier"
        Me.pbCashier.Size = New System.Drawing.Size(55, 43)
        Me.pbCashier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCashier.TabIndex = 6
        Me.pbCashier.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtStock)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.txtPName)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(169, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(862, 181)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stock Details"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(158, 30)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(248, 22)
        Me.txtSearch.TabIndex = 0
        '
        'pbTerminate
        '
        Me.pbTerminate.BackColor = System.Drawing.Color.Transparent
        Me.pbTerminate.Image = CType(resources.GetObject("pbTerminate.Image"), System.Drawing.Image)
        Me.pbTerminate.Location = New System.Drawing.Point(1064, 9)
        Me.pbTerminate.Name = "pbTerminate"
        Me.pbTerminate.Size = New System.Drawing.Size(37, 33)
        Me.pbTerminate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTerminate.TabIndex = 25
        Me.pbTerminate.TabStop = False
        '
        'pbUsers
        '
        Me.pbUsers.BackColor = System.Drawing.Color.Transparent
        Me.pbUsers.Image = CType(resources.GetObject("pbUsers.Image"), System.Drawing.Image)
        Me.pbUsers.InitialImage = CType(resources.GetObject("pbUsers.InitialImage"), System.Drawing.Image)
        Me.pbUsers.Location = New System.Drawing.Point(6, 165)
        Me.pbUsers.Margin = New System.Windows.Forms.Padding(0)
        Me.pbUsers.Name = "pbUsers"
        Me.pbUsers.Size = New System.Drawing.Size(72, 56)
        Me.pbUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUsers.TabIndex = 1
        Me.pbUsers.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(169, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gpbToggle
        '
        Me.gpbToggle.Controls.Add(Me.pbLogOut)
        Me.gpbToggle.Controls.Add(Me.pbHome)
        Me.gpbToggle.Controls.Add(Me.pbStocks)
        Me.gpbToggle.Controls.Add(Me.pbCashier)
        Me.gpbToggle.Controls.Add(Me.pbUsers)
        Me.gpbToggle.Cursor = System.Windows.Forms.Cursors.Default
        Me.gpbToggle.Location = New System.Drawing.Point(9, 10)
        Me.gpbToggle.Margin = New System.Windows.Forms.Padding(0)
        Me.gpbToggle.Name = "gpbToggle"
        Me.gpbToggle.Size = New System.Drawing.Size(79, 654)
        Me.gpbToggle.TabIndex = 1
        Me.gpbToggle.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Sienna
        Me.Panel1.Controls.Add(Me.gpbToggle)
        Me.Panel1.Location = New System.Drawing.Point(1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(102, 674)
        Me.Panel1.TabIndex = 23
        '
        'mnuCancel
        '
        Me.mnuCancel.Name = "mnuCancel"
        Me.mnuCancel.Size = New System.Drawing.Size(196, 26)
        Me.mnuCancel.Text = "Cancel"
        '
        'mnuDelete
        '
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(196, 26)
        Me.mnuDelete.Text = "&Delete Product"
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(196, 26)
        Me.mnuSave.Text = "&Save Product"
        '
        'mnuUpdate
        '
        Me.mnuUpdate.Name = "mnuUpdate"
        Me.mnuUpdate.Size = New System.Drawing.Size(196, 26)
        Me.mnuUpdate.Text = "&Update Product"
        '
        'mnuEdit
        '
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(196, 26)
        Me.mnuEdit.Text = "&Edit Product"
        '
        'mnuAdd
        '
        Me.mnuAdd.Name = "mnuAdd"
        Me.mnuAdd.Size = New System.Drawing.Size(196, 26)
        Me.mnuAdd.Text = "&Add Product"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuUpdate, Me.mnuSave, Me.mnuDelete, Me.mnuCancel})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Garamond", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(356, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(489, 53)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Add New Stock Details"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(1113, 28)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Stocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1113, 673)
        Me.Controls.Add(Me.dgSRecords)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbTerminate)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Stocks"
        Me.Text = "Stocks"
        CType(Me.dgSRecords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCashier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbTerminate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbToggle.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgSRecords As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtPName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents pbLogOut As PictureBox
    Friend WithEvents pbHome As PictureBox
    Friend WithEvents pbStocks As PictureBox
    Friend WithEvents pbCashier As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents pbTerminate As PictureBox
    Friend WithEvents pbUsers As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents gpbToggle As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents mnuCancel As ToolStripMenuItem
    Friend WithEvents mnuDelete As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuUpdate As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuAdd As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
