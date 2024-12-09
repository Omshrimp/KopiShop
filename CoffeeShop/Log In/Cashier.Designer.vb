<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cashier
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cashier))
        Me.pnlCoffee = New System.Windows.Forms.Panel()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.lbldesc = New System.Windows.Forms.Label()
        Me.lbl_orderno = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_OrderDate = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.rbDineIn = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlOrder = New System.Windows.Forms.Panel()
        Me.lblOption = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.pnlOption = New System.Windows.Forms.Panel()
        Me.rbTakeOut = New System.Windows.Forms.RadioButton()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.pbCashierHome = New System.Windows.Forms.PictureBox()
        Me.Btn_report = New System.Windows.Forms.Button()
        Me.Btn_NewOrder = New System.Windows.Forms.Button()
        Me.Btn_CancelOrder = New System.Windows.Forms.Button()
        Me.Btn_Pay = New System.Windows.Forms.Button()
        Me.btn_ManageCoffee = New System.Windows.Forms.Button()
        Me.Btn_Exit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlCoffee.SuspendLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOrder.SuspendLayout()
        Me.pnlOption.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        CType(Me.pbCashierHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCoffee
        '
        Me.pnlCoffee.Controls.Add(Me.pic)
        Me.pnlCoffee.Controls.Add(Me.Label4)
        Me.pnlCoffee.Controls.Add(Me.txt_search)
        Me.pnlCoffee.Controls.Add(Me.lblprice)
        Me.pnlCoffee.Controls.Add(Me.lbldesc)
        Me.pnlCoffee.Controls.Add(Me.lbl_orderno)
        Me.pnlCoffee.Controls.Add(Me.Label3)
        Me.pnlCoffee.Controls.Add(Me.Label2)
        Me.pnlCoffee.Controls.Add(Me.lbl_OrderDate)
        Me.pnlCoffee.Controls.Add(Me.FlowLayoutPanel1)
        Me.pnlCoffee.Location = New System.Drawing.Point(152, 106)
        Me.pnlCoffee.Name = "pnlCoffee"
        Me.pnlCoffee.Size = New System.Drawing.Size(835, 283)
        Me.pnlCoffee.TabIndex = 63
        '
        'pic
        '
        Me.pic.Location = New System.Drawing.Point(16, 58)
        Me.pic.Margin = New System.Windows.Forms.Padding(2)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(176, 196)
        Me.pic.TabIndex = 27
        Me.pic.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("quaver", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(474, 32)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Search Product Name:"
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("quaver", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(633, 26)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(186, 24)
        Me.txt_search.TabIndex = 37
        '
        'lblprice
        '
        Me.lblprice.BackColor = System.Drawing.Color.Transparent
        Me.lblprice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblprice.Location = New System.Drawing.Point(14, 264)
        Me.lblprice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(58, 16)
        Me.lblprice.TabIndex = 34
        '
        'lbldesc
        '
        Me.lbldesc.BackColor = System.Drawing.Color.Transparent
        Me.lbldesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbldesc.Location = New System.Drawing.Point(78, 266)
        Me.lbldesc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(58, 16)
        Me.lbldesc.TabIndex = 35
        '
        'lbl_orderno
        '
        Me.lbl_orderno.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_orderno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_orderno.Font = New System.Drawing.Font("quaver", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_orderno.Location = New System.Drawing.Point(103, 10)
        Me.lbl_orderno.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_orderno.Name = "lbl_orderno"
        Me.lbl_orderno.Size = New System.Drawing.Size(138, 15)
        Me.lbl_orderno.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("quaver", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 32)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Order Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("quaver", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Order No:"
        '
        'lbl_OrderDate
        '
        Me.lbl_OrderDate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_OrderDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_OrderDate.Font = New System.Drawing.Font("quaver", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_OrderDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_OrderDate.Location = New System.Drawing.Point(103, 32)
        Me.lbl_OrderDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_OrderDate.Name = "lbl_OrderDate"
        Me.lbl_OrderDate.Size = New System.Drawing.Size(138, 15)
        Me.lbl_OrderDate.TabIndex = 30
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 56)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(806, 208)
        Me.FlowLayoutPanel1.TabIndex = 29
        '
        'rbDineIn
        '
        Me.rbDineIn.AutoSize = True
        Me.rbDineIn.Font = New System.Drawing.Font("quaver", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDineIn.Location = New System.Drawing.Point(9, 22)
        Me.rbDineIn.Name = "rbDineIn"
        Me.rbDineIn.Size = New System.Drawing.Size(94, 20)
        Me.rbDineIn.TabIndex = 7
        Me.rbDineIn.TabStop = True
        Me.rbDineIn.Text = "DINE IN"
        Me.rbDineIn.UseVisualStyleBackColor = True
        '
        'lbl_total
        '
        Me.lbl_total.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_total.Font = New System.Drawing.Font("quaver", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_total.Location = New System.Drawing.Point(891, 392)
        Me.lbl_total.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(93, 20)
        Me.lbl_total.TabIndex = 67
        '
        'Column4
        '
        Me.Column4.HeaderText = "TOTAL"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "PRICE"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "Product"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.Location = New System.Drawing.Point(0, 33)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(667, 134)
        Me.DataGridView1.TabIndex = 4
        '
        'Column3
        '
        Me.Column3.HeaderText = "QTY"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'pnlOrder
        '
        Me.pnlOrder.Controls.Add(Me.DataGridView1)
        Me.pnlOrder.Controls.Add(Me.lblOption)
        Me.pnlOrder.Controls.Add(Me.Label)
        Me.pnlOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlOrder.Location = New System.Drawing.Point(152, 396)
        Me.pnlOrder.Name = "pnlOrder"
        Me.pnlOrder.Size = New System.Drawing.Size(670, 167)
        Me.pnlOrder.TabIndex = 65
        '
        'lblOption
        '
        Me.lblOption.BackColor = System.Drawing.Color.Brown
        Me.lblOption.Font = New System.Drawing.Font("quaver", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOption.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblOption.Location = New System.Drawing.Point(90, 7)
        Me.lblOption.Name = "lblOption"
        Me.lblOption.Size = New System.Drawing.Size(100, 23)
        Me.lblOption.TabIndex = 3
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.Color.Brown
        Me.Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label.Font = New System.Drawing.Font("quaver", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label.Location = New System.Drawing.Point(0, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(670, 32)
        Me.Label.TabIndex = 2
        Me.Label.Text = "ORDER |"
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(202, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(396, 61)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COFFEE TALK"
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.SystemColors.Control
        Me.btnCheckout.Font = New System.Drawing.Font("quaver", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.Location = New System.Drawing.Point(461, 10)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(194, 44)
        Me.btnCheckout.TabIndex = 1
        Me.btnCheckout.Text = "PROCEED CHECKOUT"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'pnlOption
        '
        Me.pnlOption.Controls.Add(Me.rbTakeOut)
        Me.pnlOption.Controls.Add(Me.rbDineIn)
        Me.pnlOption.Controls.Add(Me.btnCheckout)
        Me.pnlOption.Controls.Add(Me.btnCancelOrder)
        Me.pnlOption.Location = New System.Drawing.Point(152, 569)
        Me.pnlOption.Name = "pnlOption"
        Me.pnlOption.Size = New System.Drawing.Size(670, 65)
        Me.pnlOption.TabIndex = 66
        '
        'rbTakeOut
        '
        Me.rbTakeOut.AutoSize = True
        Me.rbTakeOut.Font = New System.Drawing.Font("quaver", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTakeOut.Location = New System.Drawing.Point(121, 22)
        Me.rbTakeOut.Name = "rbTakeOut"
        Me.rbTakeOut.Size = New System.Drawing.Size(106, 20)
        Me.rbTakeOut.TabIndex = 8
        Me.rbTakeOut.TabStop = True
        Me.rbTakeOut.Text = "TAKEOUT"
        Me.rbTakeOut.UseVisualStyleBackColor = True
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancelOrder.Font = New System.Drawing.Font("quaver", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelOrder.Location = New System.Drawing.Point(243, 10)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(194, 44)
        Me.btnCancelOrder.TabIndex = 0
        Me.btnCancelOrder.Text = "CANCEL ORDER"
        Me.btnCancelOrder.UseVisualStyleBackColor = False
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.SaddleBrown
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(135, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(860, 100)
        Me.pnlTop.TabIndex = 62
        '
        'pnlLeft
        '
        Me.pnlLeft.Controls.Add(Me.pbCashierHome)
        Me.pnlLeft.Controls.Add(Me.Btn_report)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(135, 791)
        Me.pnlLeft.TabIndex = 64
        '
        'pbCashierHome
        '
        Me.pbCashierHome.BackColor = System.Drawing.Color.Transparent
        Me.pbCashierHome.Image = CType(resources.GetObject("pbCashierHome.Image"), System.Drawing.Image)
        Me.pbCashierHome.InitialImage = CType(resources.GetObject("pbCashierHome.InitialImage"), System.Drawing.Image)
        Me.pbCashierHome.Location = New System.Drawing.Point(33, 9)
        Me.pbCashierHome.Margin = New System.Windows.Forms.Padding(0)
        Me.pbCashierHome.Name = "pbCashierHome"
        Me.pbCashierHome.Size = New System.Drawing.Size(52, 43)
        Me.pbCashierHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCashierHome.TabIndex = 45
        Me.pbCashierHome.TabStop = False
        '
        'Btn_report
        '
        Me.Btn_report.Font = New System.Drawing.Font("quaver", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_report.Location = New System.Drawing.Point(8, 512)
        Me.Btn_report.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_report.Name = "Btn_report"
        Me.Btn_report.Size = New System.Drawing.Size(125, 30)
        Me.Btn_report.TabIndex = 44
        Me.Btn_report.Text = "Btn_report"
        Me.Btn_report.UseVisualStyleBackColor = True
        '
        'Btn_NewOrder
        '
        Me.Btn_NewOrder.Font = New System.Drawing.Font("quaver", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_NewOrder.Location = New System.Drawing.Point(871, 523)
        Me.Btn_NewOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_NewOrder.Name = "Btn_NewOrder"
        Me.Btn_NewOrder.Size = New System.Drawing.Size(56, 19)
        Me.Btn_NewOrder.TabIndex = 61
        Me.Btn_NewOrder.Text = "Button6"
        Me.Btn_NewOrder.UseVisualStyleBackColor = True
        '
        'Btn_CancelOrder
        '
        Me.Btn_CancelOrder.Font = New System.Drawing.Font("quaver", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CancelOrder.Location = New System.Drawing.Point(871, 546)
        Me.Btn_CancelOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_CancelOrder.Name = "Btn_CancelOrder"
        Me.Btn_CancelOrder.Size = New System.Drawing.Size(56, 19)
        Me.Btn_CancelOrder.TabIndex = 60
        Me.Btn_CancelOrder.Text = "Button4"
        Me.Btn_CancelOrder.UseVisualStyleBackColor = True
        '
        'Btn_Pay
        '
        Me.Btn_Pay.Font = New System.Drawing.Font("quaver", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Pay.Location = New System.Drawing.Point(871, 494)
        Me.Btn_Pay.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Pay.Name = "Btn_Pay"
        Me.Btn_Pay.Size = New System.Drawing.Size(68, 19)
        Me.Btn_Pay.TabIndex = 59
        Me.Btn_Pay.Text = "pay"
        Me.Btn_Pay.UseVisualStyleBackColor = True
        '
        'btn_ManageCoffee
        '
        Me.btn_ManageCoffee.Font = New System.Drawing.Font("quaver", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ManageCoffee.Location = New System.Drawing.Point(871, 468)
        Me.btn_ManageCoffee.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_ManageCoffee.Name = "btn_ManageCoffee"
        Me.btn_ManageCoffee.Size = New System.Drawing.Size(68, 19)
        Me.btn_ManageCoffee.TabIndex = 58
        Me.btn_ManageCoffee.Text = "manageC"
        Me.btn_ManageCoffee.UseVisualStyleBackColor = True
        '
        'Btn_Exit
        '
        Me.Btn_Exit.Font = New System.Drawing.Font("quaver", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Exit.Location = New System.Drawing.Point(871, 441)
        Me.Btn_Exit.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(68, 19)
        Me.Btn_Exit.TabIndex = 57
        Me.Btn_Exit.Text = "exit"
        Me.Btn_Exit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("quaver", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(826, 397)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Total:"
        '
        'Cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Log_In.My.Resources.Resources._6
        Me.ClientSize = New System.Drawing.Size(995, 791)
        Me.Controls.Add(Me.pnlCoffee)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.pnlOrder)
        Me.Controls.Add(Me.pnlOption)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.Btn_NewOrder)
        Me.Controls.Add(Me.Btn_CancelOrder)
        Me.Controls.Add(Me.Btn_Pay)
        Me.Controls.Add(Me.btn_ManageCoffee)
        Me.Controls.Add(Me.Btn_Exit)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cashier"
        Me.Text = "Cashier"
        Me.pnlCoffee.ResumeLayout(False)
        Me.pnlCoffee.PerformLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOrder.ResumeLayout(False)
        Me.pnlOption.ResumeLayout(False)
        Me.pnlOption.PerformLayout()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlLeft.ResumeLayout(False)
        CType(Me.pbCashierHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlCoffee As Panel
    Private WithEvents pic As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_search As TextBox
    Private WithEvents lblprice As Label
    Private WithEvents lbldesc As Label
    Friend WithEvents lbl_orderno As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_OrderDate As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents rbDineIn As RadioButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl_total As Label
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents pnlOrder As Panel
    Friend WithEvents lblOption As Label
    Friend WithEvents Label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCheckout As Button
    Friend WithEvents pnlOption As Panel
    Friend WithEvents rbTakeOut As RadioButton
    Friend WithEvents btnCancelOrder As Button
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents Btn_report As Button
    Friend WithEvents Btn_NewOrder As Button
    Friend WithEvents Btn_CancelOrder As Button
    Friend WithEvents Btn_Pay As Button
    Friend WithEvents btn_ManageCoffee As Button
    Friend WithEvents Btn_Exit As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents pbCashierHome As PictureBox
End Class
