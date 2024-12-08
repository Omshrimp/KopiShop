<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Users))
        Me.pbLogOut = New System.Windows.Forms.PictureBox()
        Me.dgRecords = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmployee = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUname = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.ofdUserPic = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pbHome = New System.Windows.Forms.PictureBox()
        Me.pbStocks = New System.Windows.Forms.PictureBox()
        Me.pbCashier = New System.Windows.Forms.PictureBox()
        Me.pbUsers = New System.Windows.Forms.PictureBox()
        Me.gpbToggle = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mnuCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbTerminate = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        CType(Me.pbLogOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCashier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbToggle.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbTerminate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbLogOut
        '
        Me.pbLogOut.BackColor = System.Drawing.Color.Transparent
        Me.pbLogOut.Image = CType(resources.GetObject("pbLogOut.Image"), System.Drawing.Image)
        Me.pbLogOut.InitialImage = CType(resources.GetObject("pbLogOut.InitialImage"), System.Drawing.Image)
        Me.pbLogOut.Location = New System.Drawing.Point(18, 651)
        Me.pbLogOut.Margin = New System.Windows.Forms.Padding(0)
        Me.pbLogOut.Name = "pbLogOut"
        Me.pbLogOut.Size = New System.Drawing.Size(43, 39)
        Me.pbLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogOut.TabIndex = 12
        Me.pbLogOut.TabStop = False
        '
        'dgRecords
        '
        Me.dgRecords.AllowUserToResizeColumns = False
        Me.dgRecords.AllowUserToResizeRows = False
        Me.dgRecords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgRecords.ColumnHeadersHeight = 29
        Me.dgRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgRecords.Enabled = False
        Me.dgRecords.Location = New System.Drawing.Point(151, 370)
        Me.dgRecords.Name = "dgRecords"
        Me.dgRecords.ReadOnly = True
        Me.dgRecords.RowHeadersWidth = 51
        Me.dgRecords.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgRecords.RowTemplate.Height = 24
        Me.dgRecords.Size = New System.Drawing.Size(901, 321)
        Me.dgRecords.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Employee No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Role:"
        '
        'txtEmployee
        '
        Me.txtEmployee.Location = New System.Drawing.Point(147, 218)
        Me.txtEmployee.Name = "txtEmployee"
        Me.txtEmployee.Size = New System.Drawing.Size(250, 22)
        Me.txtEmployee.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Contact No."
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(147, 145)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(250, 22)
        Me.txtContact.TabIndex = 7
        '
        'cboRole
        '
        Me.cboRole.FormattingEnabled = True
        Me.cboRole.Items.AddRange(New Object() {"ADMIN", "CASHIER"})
        Me.cboRole.Location = New System.Drawing.Point(147, 179)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(250, 24)
        Me.cboRole.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name:"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(147, 109)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(250, 22)
        Me.txtPass.TabIndex = 2
        '
        'txtUname
        '
        Me.txtUname.Location = New System.Drawing.Point(147, 69)
        Me.txtUname.Name = "txtUname"
        Me.txtUname.Size = New System.Drawing.Size(250, 22)
        Me.txtUname.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(147, 32)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(250, 22)
        Me.txtName.TabIndex = 0
        '
        'ofdUserPic
        '
        Me.ofdUserPic.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtEmployee)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtContact)
        Me.GroupBox1.Controls.Add(Me.cboRole)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPass)
        Me.GroupBox1.Controls.Add(Me.txtUname)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(151, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(896, 279)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'pbHome
        '
        Me.pbHome.BackColor = System.Drawing.Color.Transparent
        Me.pbHome.Image = CType(resources.GetObject("pbHome.Image"), System.Drawing.Image)
        Me.pbHome.InitialImage = CType(resources.GetObject("pbHome.InitialImage"), System.Drawing.Image)
        Me.pbHome.Location = New System.Drawing.Point(2, 18)
        Me.pbHome.Margin = New System.Windows.Forms.Padding(0)
        Me.pbHome.Name = "pbHome"
        Me.pbHome.Size = New System.Drawing.Size(69, 53)
        Me.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHome.TabIndex = 11
        Me.pbHome.TabStop = False
        '
        'pbStocks
        '
        Me.pbStocks.BackColor = System.Drawing.Color.Transparent
        Me.pbStocks.Image = CType(resources.GetObject("pbStocks.Image"), System.Drawing.Image)
        Me.pbStocks.InitialImage = CType(resources.GetObject("pbStocks.InitialImage"), System.Drawing.Image)
        Me.pbStocks.Location = New System.Drawing.Point(6, 277)
        Me.pbStocks.Margin = New System.Windows.Forms.Padding(0)
        Me.pbStocks.Name = "pbStocks"
        Me.pbStocks.Size = New System.Drawing.Size(55, 45)
        Me.pbStocks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbStocks.TabIndex = 10
        Me.pbStocks.TabStop = False
        '
        'pbCashier
        '
        Me.pbCashier.BackColor = System.Drawing.Color.Transparent
        Me.pbCashier.Image = CType(resources.GetObject("pbCashier.Image"), System.Drawing.Image)
        Me.pbCashier.InitialImage = CType(resources.GetObject("pbCashier.InitialImage"), System.Drawing.Image)
        Me.pbCashier.Location = New System.Drawing.Point(6, 345)
        Me.pbCashier.Margin = New System.Windows.Forms.Padding(0)
        Me.pbCashier.Name = "pbCashier"
        Me.pbCashier.Size = New System.Drawing.Size(55, 43)
        Me.pbCashier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCashier.TabIndex = 9
        Me.pbCashier.TabStop = False
        '
        'pbUsers
        '
        Me.pbUsers.BackColor = System.Drawing.Color.Transparent
        Me.pbUsers.Image = CType(resources.GetObject("pbUsers.Image"), System.Drawing.Image)
        Me.pbUsers.InitialImage = CType(resources.GetObject("pbUsers.InitialImage"), System.Drawing.Image)
        Me.pbUsers.Location = New System.Drawing.Point(6, 201)
        Me.pbUsers.Margin = New System.Windows.Forms.Padding(0)
        Me.pbUsers.Name = "pbUsers"
        Me.pbUsers.Size = New System.Drawing.Size(72, 56)
        Me.pbUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUsers.TabIndex = 8
        Me.pbUsers.TabStop = False
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
        Me.gpbToggle.Size = New System.Drawing.Size(78, 702)
        Me.gpbToggle.TabIndex = 1
        Me.gpbToggle.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Sienna
        Me.Panel1.Controls.Add(Me.gpbToggle)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(96, 720)
        Me.Panel1.TabIndex = 21
        '
        'mnuCancel
        '
        Me.mnuCancel.Name = "mnuCancel"
        Me.mnuCancel.Size = New System.Drawing.Size(190, 26)
        Me.mnuCancel.Text = "Cancel"
        '
        'mnuDelete
        '
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(190, 26)
        Me.mnuDelete.Text = "Delete"
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(190, 26)
        Me.mnuSave.Text = "Save"
        '
        'mnuUpdate
        '
        Me.mnuUpdate.Name = "mnuUpdate"
        Me.mnuUpdate.Size = New System.Drawing.Size(190, 26)
        Me.mnuUpdate.Text = "Update"
        '
        'mnuEdit
        '
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(190, 26)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuAdd
        '
        Me.mnuAdd.Name = "mnuAdd"
        Me.mnuAdd.Size = New System.Drawing.Size(190, 26)
        Me.mnuAdd.Text = "Add Employee"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuUpdate, Me.mnuSave, Me.mnuDelete, Me.mnuCancel})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'pbTerminate
        '
        Me.pbTerminate.BackColor = System.Drawing.Color.Transparent
        Me.pbTerminate.Image = CType(resources.GetObject("pbTerminate.Image"), System.Drawing.Image)
        Me.pbTerminate.Location = New System.Drawing.Point(1048, 9)
        Me.pbTerminate.Name = "pbTerminate"
        Me.pbTerminate.Size = New System.Drawing.Size(37, 33)
        Me.pbTerminate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTerminate.TabIndex = 22
        Me.pbTerminate.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(1097, 28)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1097, 719)
        Me.Controls.Add(Me.dgRecords)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbTerminate)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Users"
        CType(Me.pbLogOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCashier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbToggle.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbTerminate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbLogOut As PictureBox
    Friend WithEvents dgRecords As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmployee As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents ofdUserPic As OpenFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pbHome As PictureBox
    Friend WithEvents pbStocks As PictureBox
    Friend WithEvents pbCashier As PictureBox
    Friend WithEvents pbUsers As PictureBox
    Friend WithEvents gpbToggle As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents mnuCancel As ToolStripMenuItem
    Friend WithEvents mnuDelete As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuUpdate As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuAdd As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pbTerminate As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
