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
        Me.txtEmployee = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.cboRole = New System.Windows.Forms.ComboBox()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.pbLogOut.Location = New System.Drawing.Point(14, 529)
        Me.pbLogOut.Margin = New System.Windows.Forms.Padding(0)
        Me.pbLogOut.Name = "pbLogOut"
        Me.pbLogOut.Size = New System.Drawing.Size(32, 32)
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
        Me.dgRecords.Location = New System.Drawing.Point(113, 287)
        Me.dgRecords.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgRecords.Name = "dgRecords"
        Me.dgRecords.ReadOnly = True
        Me.dgRecords.RowHeadersWidth = 51
        Me.dgRecords.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgRecords.RowTemplate.Height = 24
        Me.dgRecords.Size = New System.Drawing.Size(676, 261)
        Me.dgRecords.TabIndex = 24
        '
        'txtEmployee
        '
        Me.txtEmployee.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployee.Location = New System.Drawing.Point(468, 123)
        Me.txtEmployee.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEmployee.Name = "txtEmployee"
        Me.txtEmployee.Size = New System.Drawing.Size(188, 25)
        Me.txtEmployee.TabIndex = 4
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(468, 46)
        Me.txtContact.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(188, 25)
        Me.txtContact.TabIndex = 7
        '
        'cboRole
        '
        Me.cboRole.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRole.FormattingEnabled = True
        Me.cboRole.Items.AddRange(New Object() {"ADMIN", "CASHIER"})
        Me.cboRole.Location = New System.Drawing.Point(468, 84)
        Me.cboRole.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(188, 26)
        Me.cboRole.TabIndex = 6
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(105, 122)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(188, 25)
        Me.txtPass.TabIndex = 2
        '
        'txtUname
        '
        Me.txtUname.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUname.Location = New System.Drawing.Point(105, 84)
        Me.txtUname.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUname.Name = "txtUname"
        Me.txtUname.Size = New System.Drawing.Size(188, 25)
        Me.txtUname.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(105, 46)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(188, 25)
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
        Me.GroupBox1.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(113, 51)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(672, 204)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'pbHome
        '
        Me.pbHome.BackColor = System.Drawing.Color.Transparent
        Me.pbHome.Image = CType(resources.GetObject("pbHome.Image"), System.Drawing.Image)
        Me.pbHome.InitialImage = CType(resources.GetObject("pbHome.InitialImage"), System.Drawing.Image)
        Me.pbHome.Location = New System.Drawing.Point(2, 15)
        Me.pbHome.Margin = New System.Windows.Forms.Padding(0)
        Me.pbHome.Name = "pbHome"
        Me.pbHome.Size = New System.Drawing.Size(52, 43)
        Me.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHome.TabIndex = 11
        Me.pbHome.TabStop = False
        '
        'pbStocks
        '
        Me.pbStocks.BackColor = System.Drawing.Color.Transparent
        Me.pbStocks.Image = CType(resources.GetObject("pbStocks.Image"), System.Drawing.Image)
        Me.pbStocks.InitialImage = CType(resources.GetObject("pbStocks.InitialImage"), System.Drawing.Image)
        Me.pbStocks.Location = New System.Drawing.Point(4, 225)
        Me.pbStocks.Margin = New System.Windows.Forms.Padding(0)
        Me.pbStocks.Name = "pbStocks"
        Me.pbStocks.Size = New System.Drawing.Size(41, 37)
        Me.pbStocks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbStocks.TabIndex = 10
        Me.pbStocks.TabStop = False
        '
        'pbCashier
        '
        Me.pbCashier.BackColor = System.Drawing.Color.Transparent
        Me.pbCashier.Image = CType(resources.GetObject("pbCashier.Image"), System.Drawing.Image)
        Me.pbCashier.InitialImage = CType(resources.GetObject("pbCashier.InitialImage"), System.Drawing.Image)
        Me.pbCashier.Location = New System.Drawing.Point(4, 280)
        Me.pbCashier.Margin = New System.Windows.Forms.Padding(0)
        Me.pbCashier.Name = "pbCashier"
        Me.pbCashier.Size = New System.Drawing.Size(41, 35)
        Me.pbCashier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCashier.TabIndex = 9
        Me.pbCashier.TabStop = False
        '
        'pbUsers
        '
        Me.pbUsers.BackColor = System.Drawing.Color.Transparent
        Me.pbUsers.Image = CType(resources.GetObject("pbUsers.Image"), System.Drawing.Image)
        Me.pbUsers.InitialImage = CType(resources.GetObject("pbUsers.InitialImage"), System.Drawing.Image)
        Me.pbUsers.Location = New System.Drawing.Point(4, 163)
        Me.pbUsers.Margin = New System.Windows.Forms.Padding(0)
        Me.pbUsers.Name = "pbUsers"
        Me.pbUsers.Size = New System.Drawing.Size(54, 46)
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
        Me.gpbToggle.Location = New System.Drawing.Point(7, 8)
        Me.gpbToggle.Margin = New System.Windows.Forms.Padding(0)
        Me.gpbToggle.Name = "gpbToggle"
        Me.gpbToggle.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gpbToggle.Size = New System.Drawing.Size(58, 570)
        Me.gpbToggle.TabIndex = 1
        Me.gpbToggle.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Sienna
        Me.Panel1.Controls.Add(Me.gpbToggle)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(72, 585)
        Me.Panel1.TabIndex = 21
        '
        'mnuCancel
        '
        Me.mnuCancel.Name = "mnuCancel"
        Me.mnuCancel.Size = New System.Drawing.Size(151, 22)
        Me.mnuCancel.Text = "Cancel"
        '
        'mnuDelete
        '
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(151, 22)
        Me.mnuDelete.Text = "Delete"
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(151, 22)
        Me.mnuSave.Text = "Save"
        '
        'mnuUpdate
        '
        Me.mnuUpdate.Name = "mnuUpdate"
        Me.mnuUpdate.Size = New System.Drawing.Size(151, 22)
        Me.mnuUpdate.Text = "Update"
        '
        'mnuEdit
        '
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(151, 22)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuAdd
        '
        Me.mnuAdd.Name = "mnuAdd"
        Me.mnuAdd.Size = New System.Drawing.Size(151, 22)
        Me.mnuAdd.Text = "Add Employee"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuUpdate, Me.mnuSave, Me.mnuDelete, Me.mnuCancel})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'pbTerminate
        '
        Me.pbTerminate.BackColor = System.Drawing.Color.Transparent
        Me.pbTerminate.Image = CType(resources.GetObject("pbTerminate.Image"), System.Drawing.Image)
        Me.pbTerminate.Location = New System.Drawing.Point(786, 7)
        Me.pbTerminate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbTerminate.Name = "pbTerminate"
        Me.pbTerminate.Size = New System.Drawing.Size(28, 27)
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
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(823, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(41, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(8, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(13, 122)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(362, 50)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Contact # :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(412, 89)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Role:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(344, 122)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Employee # :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(823, 584)
        Me.Controls.Add(Me.dgRecords)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbTerminate)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
    Friend WithEvents txtEmployee As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents cboRole As ComboBox
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
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
