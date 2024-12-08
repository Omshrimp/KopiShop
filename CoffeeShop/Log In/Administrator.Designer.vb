<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Administrator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administrator))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gpbToggle = New System.Windows.Forms.GroupBox()
        Me.btnToggle = New System.Windows.Forms.Button()
        Me.pbStocks = New System.Windows.Forms.PictureBox()
        Me.pbCashier = New System.Windows.Forms.PictureBox()
        Me.pbUsers = New System.Windows.Forms.PictureBox()
        Me.lblCashier = New System.Windows.Forms.Label()
        Me.lblStocks = New System.Windows.Forms.Label()
        Me.lblUsers = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.gpbToggle.SuspendLayout()
        CType(Me.pbStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCashier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Sienna
        Me.Panel1.Controls.Add(Me.gpbToggle)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(275, 720)
        Me.Panel1.TabIndex = 0
        '
        'gpbToggle
        '
        Me.gpbToggle.Controls.Add(Me.btnToggle)
        Me.gpbToggle.Controls.Add(Me.pbStocks)
        Me.gpbToggle.Controls.Add(Me.pbCashier)
        Me.gpbToggle.Controls.Add(Me.pbUsers)
        Me.gpbToggle.Controls.Add(Me.lblCashier)
        Me.gpbToggle.Controls.Add(Me.lblStocks)
        Me.gpbToggle.Controls.Add(Me.lblUsers)
        Me.gpbToggle.Controls.Add(Me.Label2)
        Me.gpbToggle.Controls.Add(Me.Label1)
        Me.gpbToggle.Cursor = System.Windows.Forms.Cursors.Default
        Me.gpbToggle.Location = New System.Drawing.Point(9, 10)
        Me.gpbToggle.Margin = New System.Windows.Forms.Padding(0)
        Me.gpbToggle.Name = "gpbToggle"
        Me.gpbToggle.Size = New System.Drawing.Size(249, 702)
        Me.gpbToggle.TabIndex = 1
        Me.gpbToggle.TabStop = False
        '
        'btnToggle
        '
        Me.btnToggle.Location = New System.Drawing.Point(0, 9)
        Me.btnToggle.Name = "btnToggle"
        Me.btnToggle.Size = New System.Drawing.Size(58, 35)
        Me.btnToggle.TabIndex = 17
        Me.btnToggle.Text = "Button1"
        Me.btnToggle.UseVisualStyleBackColor = True
        '
        'pbStocks
        '
        Me.pbStocks.BackColor = System.Drawing.Color.Transparent
        Me.pbStocks.Image = CType(resources.GetObject("pbStocks.Image"), System.Drawing.Image)
        Me.pbStocks.InitialImage = CType(resources.GetObject("pbStocks.InitialImage"), System.Drawing.Image)
        Me.pbStocks.Location = New System.Drawing.Point(15, 221)
        Me.pbStocks.Margin = New System.Windows.Forms.Padding(0)
        Me.pbStocks.Name = "pbStocks"
        Me.pbStocks.Size = New System.Drawing.Size(40, 36)
        Me.pbStocks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbStocks.TabIndex = 7
        Me.pbStocks.TabStop = False
        '
        'pbCashier
        '
        Me.pbCashier.BackColor = System.Drawing.Color.Transparent
        Me.pbCashier.Image = CType(resources.GetObject("pbCashier.Image"), System.Drawing.Image)
        Me.pbCashier.InitialImage = CType(resources.GetObject("pbCashier.InitialImage"), System.Drawing.Image)
        Me.pbCashier.Location = New System.Drawing.Point(15, 264)
        Me.pbCashier.Margin = New System.Windows.Forms.Padding(0)
        Me.pbCashier.Name = "pbCashier"
        Me.pbCashier.Size = New System.Drawing.Size(40, 33)
        Me.pbCashier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCashier.TabIndex = 6
        Me.pbCashier.TabStop = False
        '
        'pbUsers
        '
        Me.pbUsers.BackColor = System.Drawing.Color.Transparent
        Me.pbUsers.Image = CType(resources.GetObject("pbUsers.Image"), System.Drawing.Image)
        Me.pbUsers.InitialImage = CType(resources.GetObject("pbUsers.InitialImage"), System.Drawing.Image)
        Me.pbUsers.Location = New System.Drawing.Point(15, 178)
        Me.pbUsers.Margin = New System.Windows.Forms.Padding(0)
        Me.pbUsers.Name = "pbUsers"
        Me.pbUsers.Size = New System.Drawing.Size(51, 43)
        Me.pbUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUsers.TabIndex = 1
        Me.pbUsers.TabStop = False
        '
        'lblCashier
        '
        Me.lblCashier.AutoSize = True
        Me.lblCashier.BackColor = System.Drawing.Color.Sienna
        Me.lblCashier.Font = New System.Drawing.Font("Garamond", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashier.ForeColor = System.Drawing.Color.Wheat
        Me.lblCashier.Location = New System.Drawing.Point(66, 269)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(87, 26)
        Me.lblCashier.TabIndex = 4
        Me.lblCashier.Text = "Cashier"
        '
        'lblStocks
        '
        Me.lblStocks.AutoSize = True
        Me.lblStocks.BackColor = System.Drawing.Color.Sienna
        Me.lblStocks.Font = New System.Drawing.Font("Garamond", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStocks.ForeColor = System.Drawing.Color.Wheat
        Me.lblStocks.Location = New System.Drawing.Point(71, 228)
        Me.lblStocks.Name = "lblStocks"
        Me.lblStocks.Size = New System.Drawing.Size(76, 26)
        Me.lblStocks.TabIndex = 3
        Me.lblStocks.Text = "Stocks"
        '
        'lblUsers
        '
        Me.lblUsers.AutoSize = True
        Me.lblUsers.BackColor = System.Drawing.Color.Sienna
        Me.lblUsers.Font = New System.Drawing.Font("Garamond", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsers.ForeColor = System.Drawing.Color.Wheat
        Me.lblUsers.Location = New System.Drawing.Point(75, 186)
        Me.lblUsers.Name = "lblUsers"
        Me.lblUsers.Size = New System.Drawing.Size(68, 26)
        Me.lblUsers.TabIndex = 1
        Me.lblUsers.Text = "Users"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Garamond", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Wheat
        Me.Label2.Location = New System.Drawing.Point(83, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 53)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Talk"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Garamond", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Wheat
        Me.Label1.Location = New System.Drawing.Point(24, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 53)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Coffee"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1082, 9)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(37, 33)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 16
        Me.PictureBox5.TabStop = False
        '
        'Administrator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1131, 720)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Administrator"
        Me.Text = "Administrator"
        Me.Panel1.ResumeLayout(False)
        Me.gpbToggle.ResumeLayout(False)
        Me.gpbToggle.PerformLayout()
        CType(Me.pbStocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCashier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents gpbToggle As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCashier As Label
    Friend WithEvents lblStocks As Label
    Friend WithEvents lblUsers As Label
    Friend WithEvents pbUsers As PictureBox
    Friend WithEvents pbStocks As PictureBox
    Friend WithEvents pbCashier As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnToggle As Button
End Class
