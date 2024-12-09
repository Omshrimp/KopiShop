<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCoffeeManageEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCoffeeManageEntry))
        Me.btn_Browse = New System.Windows.Forms.Button()
        Me.Pic_Coffeeimg = New System.Windows.Forms.PictureBox()
        Me.txt_Coffeename = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_coffeeCode = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgProducts = New System.Windows.Forms.DataGridView()
        Me.mnuFile = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gpbToggle = New System.Windows.Forms.GroupBox()
        Me.pbLogOut = New System.Windows.Forms.PictureBox()
        Me.pbHome = New System.Windows.Forms.PictureBox()
        Me.pbProducts = New System.Windows.Forms.PictureBox()
        Me.pbCashier = New System.Windows.Forms.PictureBox()
        Me.pbUsers = New System.Windows.Forms.PictureBox()
        Me.pbTerminate = New System.Windows.Forms.PictureBox()
        CType(Me.Pic_Coffeeimg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuFile.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gpbToggle.SuspendLayout()
        CType(Me.pbLogOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCashier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTerminate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Browse
        '
        Me.btn_Browse.FlatAppearance.BorderSize = 0
        Me.btn_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Browse.Font = New System.Drawing.Font("Garamond", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Browse.Location = New System.Drawing.Point(566, 188)
        Me.btn_Browse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_Browse.Name = "btn_Browse"
        Me.btn_Browse.Size = New System.Drawing.Size(80, 28)
        Me.btn_Browse.TabIndex = 26
        Me.btn_Browse.Text = "browse"
        Me.btn_Browse.UseVisualStyleBackColor = True
        '
        'Pic_Coffeeimg
        '
        Me.Pic_Coffeeimg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Coffeeimg.Location = New System.Drawing.Point(457, 16)
        Me.Pic_Coffeeimg.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Pic_Coffeeimg.Name = "Pic_Coffeeimg"
        Me.Pic_Coffeeimg.Size = New System.Drawing.Size(169, 168)
        Me.Pic_Coffeeimg.TabIndex = 25
        Me.Pic_Coffeeimg.TabStop = False
        '
        'txt_Coffeename
        '
        Me.txt_Coffeename.Location = New System.Drawing.Point(149, 128)
        Me.txt_Coffeename.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_Coffeename.Name = "txt_Coffeename"
        Me.txt_Coffeename.Size = New System.Drawing.Size(188, 20)
        Me.txt_Coffeename.TabIndex = 22
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(149, 165)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(188, 20)
        Me.txt_price.TabIndex = 21
        '
        'txt_coffeeCode
        '
        Me.txt_coffeeCode.Location = New System.Drawing.Point(149, 93)
        Me.txt_coffeeCode.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_coffeeCode.Name = "txt_coffeeCode"
        Me.txt_coffeeCode.Size = New System.Drawing.Size(188, 20)
        Me.txt_coffeeCode.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btn_Browse)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Pic_Coffeeimg)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.txt_Coffeename)
        Me.GroupBox1.Controls.Add(Me.txt_coffeeCode)
        Me.GroupBox1.Controls.Add(Me.txt_price)
        Me.GroupBox1.Location = New System.Drawing.Point(104, 37)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(650, 233)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(97, 165)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(30, 131)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Product Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(55, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Product ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(40, 40)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Search By ID:"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(150, 38)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(187, 20)
        Me.txtSearch.TabIndex = 0
        '
        'dgProducts
        '
        Me.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProducts.Location = New System.Drawing.Point(100, 279)
        Me.dgProducts.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgProducts.Name = "dgProducts"
        Me.dgProducts.RowHeadersWidth = 51
        Me.dgProducts.RowTemplate.Height = 24
        Me.dgProducts.Size = New System.Drawing.Size(659, 200)
        Me.dgProducts.TabIndex = 31
        '
        'mnuFile
        '
        Me.mnuFile.BackColor = System.Drawing.Color.Transparent
        Me.mnuFile.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuFile.Location = New System.Drawing.Point(0, 0)
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.mnuFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mnuFile.Size = New System.Drawing.Size(818, 24)
        Me.mnuFile.TabIndex = 34
        Me.mnuFile.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuUpdate, Me.mnuSave, Me.mnuDelete, Me.mnuCancel})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuAdd
        '
        Me.mnuAdd.Name = "mnuAdd"
        Me.mnuAdd.Size = New System.Drawing.Size(157, 22)
        Me.mnuAdd.Text = "&Add Product"
        '
        'mnuEdit
        '
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(157, 22)
        Me.mnuEdit.Text = "&Edit Product"
        '
        'mnuUpdate
        '
        Me.mnuUpdate.Name = "mnuUpdate"
        Me.mnuUpdate.Size = New System.Drawing.Size(157, 22)
        Me.mnuUpdate.Text = "&Update Product"
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(157, 22)
        Me.mnuSave.Text = "&Save Product"
        '
        'mnuDelete
        '
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(157, 22)
        Me.mnuDelete.Text = "&Delete Product"
        '
        'mnuCancel
        '
        Me.mnuCancel.Name = "mnuCancel"
        Me.mnuCancel.Size = New System.Drawing.Size(157, 22)
        Me.mnuCancel.Text = "&Cancel"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Sienna
        Me.Panel1.Controls.Add(Me.gpbToggle)
        Me.Panel1.Location = New System.Drawing.Point(-1, -2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(76, 511)
        Me.Panel1.TabIndex = 35
        '
        'gpbToggle
        '
        Me.gpbToggle.Controls.Add(Me.pbLogOut)
        Me.gpbToggle.Controls.Add(Me.pbHome)
        Me.gpbToggle.Controls.Add(Me.pbProducts)
        Me.gpbToggle.Controls.Add(Me.pbCashier)
        Me.gpbToggle.Controls.Add(Me.pbUsers)
        Me.gpbToggle.Cursor = System.Windows.Forms.Cursors.Default
        Me.gpbToggle.Location = New System.Drawing.Point(7, 8)
        Me.gpbToggle.Margin = New System.Windows.Forms.Padding(0)
        Me.gpbToggle.Name = "gpbToggle"
        Me.gpbToggle.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gpbToggle.Size = New System.Drawing.Size(59, 495)
        Me.gpbToggle.TabIndex = 1
        Me.gpbToggle.TabStop = False
        '
        'pbLogOut
        '
        Me.pbLogOut.BackColor = System.Drawing.Color.Transparent
        Me.pbLogOut.Image = CType(resources.GetObject("pbLogOut.Image"), System.Drawing.Image)
        Me.pbLogOut.InitialImage = CType(resources.GetObject("pbLogOut.InitialImage"), System.Drawing.Image)
        Me.pbLogOut.Location = New System.Drawing.Point(13, 448)
        Me.pbLogOut.Margin = New System.Windows.Forms.Padding(0)
        Me.pbLogOut.Name = "pbLogOut"
        Me.pbLogOut.Size = New System.Drawing.Size(32, 32)
        Me.pbLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogOut.TabIndex = 21
        Me.pbLogOut.TabStop = False
        '
        'pbHome
        '
        Me.pbHome.BackColor = System.Drawing.Color.Transparent
        Me.pbHome.Image = CType(resources.GetObject("pbHome.Image"), System.Drawing.Image)
        Me.pbHome.InitialImage = CType(resources.GetObject("pbHome.InitialImage"), System.Drawing.Image)
        Me.pbHome.Location = New System.Drawing.Point(4, 15)
        Me.pbHome.Margin = New System.Windows.Forms.Padding(0)
        Me.pbHome.Name = "pbHome"
        Me.pbHome.Size = New System.Drawing.Size(52, 43)
        Me.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHome.TabIndex = 21
        Me.pbHome.TabStop = False
        '
        'pbProducts
        '
        Me.pbProducts.BackColor = System.Drawing.Color.Transparent
        Me.pbProducts.Image = CType(resources.GetObject("pbProducts.Image"), System.Drawing.Image)
        Me.pbProducts.InitialImage = CType(resources.GetObject("pbProducts.InitialImage"), System.Drawing.Image)
        Me.pbProducts.Location = New System.Drawing.Point(4, 196)
        Me.pbProducts.Margin = New System.Windows.Forms.Padding(0)
        Me.pbProducts.Name = "pbProducts"
        Me.pbProducts.Size = New System.Drawing.Size(41, 37)
        Me.pbProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProducts.TabIndex = 7
        Me.pbProducts.TabStop = False
        '
        'pbCashier
        '
        Me.pbCashier.BackColor = System.Drawing.Color.Transparent
        Me.pbCashier.Image = CType(resources.GetObject("pbCashier.Image"), System.Drawing.Image)
        Me.pbCashier.InitialImage = CType(resources.GetObject("pbCashier.InitialImage"), System.Drawing.Image)
        Me.pbCashier.Location = New System.Drawing.Point(4, 251)
        Me.pbCashier.Margin = New System.Windows.Forms.Padding(0)
        Me.pbCashier.Name = "pbCashier"
        Me.pbCashier.Size = New System.Drawing.Size(41, 35)
        Me.pbCashier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCashier.TabIndex = 6
        Me.pbCashier.TabStop = False
        '
        'pbUsers
        '
        Me.pbUsers.BackColor = System.Drawing.Color.Transparent
        Me.pbUsers.Image = CType(resources.GetObject("pbUsers.Image"), System.Drawing.Image)
        Me.pbUsers.InitialImage = CType(resources.GetObject("pbUsers.InitialImage"), System.Drawing.Image)
        Me.pbUsers.Location = New System.Drawing.Point(4, 134)
        Me.pbUsers.Margin = New System.Windows.Forms.Padding(0)
        Me.pbUsers.Name = "pbUsers"
        Me.pbUsers.Size = New System.Drawing.Size(54, 46)
        Me.pbUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUsers.TabIndex = 1
        Me.pbUsers.TabStop = False
        '
        'pbTerminate
        '
        Me.pbTerminate.BackColor = System.Drawing.Color.Transparent
        Me.pbTerminate.Image = CType(resources.GetObject("pbTerminate.Image"), System.Drawing.Image)
        Me.pbTerminate.Location = New System.Drawing.Point(781, 6)
        Me.pbTerminate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbTerminate.Name = "pbTerminate"
        Me.pbTerminate.Size = New System.Drawing.Size(28, 27)
        Me.pbTerminate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTerminate.TabIndex = 34
        Me.pbTerminate.TabStop = False
        '
        'frmCoffeeManageEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(818, 509)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbTerminate)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.mnuFile)
        Me.Controls.Add(Me.dgProducts)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmCoffeeManageEntry"
        Me.Text = "Reports"
        CType(Me.Pic_Coffeeimg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuFile.ResumeLayout(False)
        Me.mnuFile.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.gpbToggle.ResumeLayout(False)
        CType(Me.pbLogOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCashier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTerminate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Browse As Button
    Friend WithEvents Pic_Coffeeimg As PictureBox
    Friend WithEvents txt_Coffeename As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_coffeeCode As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgProducts As DataGridView
    Friend WithEvents mnuFile As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAdd As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuUpdate As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuDelete As ToolStripMenuItem
    Friend WithEvents mnuCancel As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents gpbToggle As GroupBox
    Friend WithEvents pbLogOut As PictureBox
    Friend WithEvents pbHome As PictureBox
    Friend WithEvents pbProducts As PictureBox
    Friend WithEvents pbCashier As PictureBox
    Friend WithEvents pbUsers As PictureBox
    Friend WithEvents pbTerminate As PictureBox
End Class
