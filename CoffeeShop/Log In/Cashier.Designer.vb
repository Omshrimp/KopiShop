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
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.pnlOption = New System.Windows.Forms.Panel()
        Me.rbTakeOut = New System.Windows.Forms.RadioButton()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.Btn_report = New System.Windows.Forms.Button()
        Me.pnlOnBtnPosition = New System.Windows.Forms.Panel()
        Me.btnMilk = New System.Windows.Forms.Button()
        Me.btnChoco = New System.Windows.Forms.Button()
        Me.btnCoffee = New System.Windows.Forms.Button()
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
        Me.pnlCoffee.Location = New System.Drawing.Point(203, 131)
        Me.pnlCoffee.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlCoffee.Name = "pnlCoffee"
        Me.pnlCoffee.Size = New System.Drawing.Size(1113, 348)
        Me.pnlCoffee.TabIndex = 63
        '
        'pic
        '
        Me.pic.Location = New System.Drawing.Point(21, 71)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(235, 241)
        Me.pic.TabIndex = 27
        Me.pic.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(690, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Search Product Name:"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(844, 32)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(246, 22)
        Me.txt_search.TabIndex = 37
        '
        'lblprice
        '
        Me.lblprice.BackColor = System.Drawing.Color.Transparent
        Me.lblprice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblprice.Location = New System.Drawing.Point(18, 325)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(77, 20)
        Me.lblprice.TabIndex = 34
        '
        'lbldesc
        '
        Me.lbldesc.BackColor = System.Drawing.Color.Transparent
        Me.lbldesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbldesc.Location = New System.Drawing.Point(104, 327)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(77, 20)
        Me.lbldesc.TabIndex = 35
        '
        'lbl_orderno
        '
        Me.lbl_orderno.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_orderno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_orderno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_orderno.Location = New System.Drawing.Point(125, 14)
        Me.lbl_orderno.Name = "lbl_orderno"
        Me.lbl_orderno.Size = New System.Drawing.Size(184, 18)
        Me.lbl_orderno.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Order Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Order No:"
        '
        'lbl_OrderDate
        '
        Me.lbl_OrderDate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_OrderDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_OrderDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_OrderDate.Location = New System.Drawing.Point(125, 39)
        Me.lbl_OrderDate.Name = "lbl_OrderDate"
        Me.lbl_OrderDate.Size = New System.Drawing.Size(184, 18)
        Me.lbl_OrderDate.TabIndex = 30
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(15, 60)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1075, 256)
        Me.FlowLayoutPanel1.TabIndex = 29
        '
        'rbDineIn
        '
        Me.rbDineIn.AutoSize = True
        Me.rbDineIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDineIn.Location = New System.Drawing.Point(12, 27)
        Me.rbDineIn.Margin = New System.Windows.Forms.Padding(4)
        Me.rbDineIn.Name = "rbDineIn"
        Me.rbDineIn.Size = New System.Drawing.Size(110, 29)
        Me.rbDineIn.TabIndex = 7
        Me.rbDineIn.TabStop = True
        Me.rbDineIn.Text = "DINE IN"
        Me.rbDineIn.UseVisualStyleBackColor = True
        '
        'lbl_total
        '
        Me.lbl_total.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lbl_total.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_total.Location = New System.Drawing.Point(1223, 486)
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
        Me.DataGridView1.Location = New System.Drawing.Point(0, 41)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(889, 165)
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
        Me.pnlOrder.Location = New System.Drawing.Point(203, 487)
        Me.pnlOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlOrder.Name = "pnlOrder"
        Me.pnlOrder.Size = New System.Drawing.Size(893, 206)
        Me.pnlOrder.TabIndex = 65
        '
        'lblOption
        '
        Me.lblOption.BackColor = System.Drawing.Color.Brown
        Me.lblOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOption.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblOption.Location = New System.Drawing.Point(120, 9)
        Me.lblOption.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOption.Name = "lblOption"
        Me.lblOption.Size = New System.Drawing.Size(133, 28)
        Me.lblOption.TabIndex = 3
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.Color.Brown
        Me.Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label.Location = New System.Drawing.Point(0, 0)
        Me.Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(893, 39)
        Me.Label.TabIndex = 2
        Me.Label.Text = "ORDER |"
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(8, 15)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 44)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "HOME"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(269, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(501, 76)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COFFEE TALK"
        '
        'btnCheckout
        '
        Me.btnCheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.Location = New System.Drawing.Point(612, 12)
        Me.btnCheckout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(259, 54)
        Me.btnCheckout.TabIndex = 1
        Me.btnCheckout.Text = "PROCEED CHECKOUT"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'pnlOption
        '
        Me.pnlOption.Controls.Add(Me.rbTakeOut)
        Me.pnlOption.Controls.Add(Me.rbDineIn)
        Me.pnlOption.Controls.Add(Me.btnCheckout)
        Me.pnlOption.Controls.Add(Me.btnCancelOrder)
        Me.pnlOption.Location = New System.Drawing.Point(218, 714)
        Me.pnlOption.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlOption.Name = "pnlOption"
        Me.pnlOption.Size = New System.Drawing.Size(893, 80)
        Me.pnlOption.TabIndex = 66
        '
        'rbTakeOut
        '
        Me.rbTakeOut.AutoSize = True
        Me.rbTakeOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTakeOut.Location = New System.Drawing.Point(161, 27)
        Me.rbTakeOut.Margin = New System.Windows.Forms.Padding(4)
        Me.rbTakeOut.Name = "rbTakeOut"
        Me.rbTakeOut.Size = New System.Drawing.Size(137, 29)
        Me.rbTakeOut.TabIndex = 8
        Me.rbTakeOut.TabStop = True
        Me.rbTakeOut.Text = "TAKEOUT"
        Me.rbTakeOut.UseVisualStyleBackColor = True
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelOrder.Location = New System.Drawing.Point(324, 12)
        Me.btnCancelOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(259, 54)
        Me.btnCancelOrder.TabIndex = 0
        Me.btnCancelOrder.Text = "CANCEL ORDER"
        Me.btnCancelOrder.UseVisualStyleBackColor = True
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.SaddleBrown
        Me.pnlTop.Controls.Add(Me.Button6)
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(180, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1147, 123)
        Me.pnlTop.TabIndex = 62
        '
        'pnlLeft
        '
        Me.pnlLeft.Controls.Add(Me.btnProducts)
        Me.pnlLeft.Controls.Add(Me.Btn_report)
        Me.pnlLeft.Controls.Add(Me.pnlOnBtnPosition)
        Me.pnlLeft.Controls.Add(Me.btnMilk)
        Me.pnlLeft.Controls.Add(Me.btnChoco)
        Me.pnlLeft.Controls.Add(Me.btnCoffee)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(180, 974)
        Me.pnlLeft.TabIndex = 64
        '
        'btnProducts
        '
        Me.btnProducts.BackColor = System.Drawing.Color.Transparent
        Me.btnProducts.FlatAppearance.BorderSize = 0
        Me.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProducts.Location = New System.Drawing.Point(-4, 410)
        Me.btnProducts.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(180, 54)
        Me.btnProducts.TabIndex = 50
        Me.btnProducts.Text = "PRODUCTS"
        Me.btnProducts.UseVisualStyleBackColor = False
        '
        'Btn_report
        '
        Me.Btn_report.Location = New System.Drawing.Point(29, 631)
        Me.Btn_report.Name = "Btn_report"
        Me.Btn_report.Size = New System.Drawing.Size(75, 23)
        Me.Btn_report.TabIndex = 44
        Me.Btn_report.Text = "Btn_report"
        Me.Btn_report.UseVisualStyleBackColor = True
        '
        'pnlOnBtnPosition
        '
        Me.pnlOnBtnPosition.BackColor = System.Drawing.Color.SaddleBrown
        Me.pnlOnBtnPosition.Location = New System.Drawing.Point(0, 122)
        Me.pnlOnBtnPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlOnBtnPosition.Name = "pnlOnBtnPosition"
        Me.pnlOnBtnPosition.Size = New System.Drawing.Size(15, 54)
        Me.pnlOnBtnPosition.TabIndex = 44
        '
        'btnMilk
        '
        Me.btnMilk.BackColor = System.Drawing.Color.Transparent
        Me.btnMilk.FlatAppearance.BorderSize = 0
        Me.btnMilk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMilk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMilk.Location = New System.Drawing.Point(0, 273)
        Me.btnMilk.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMilk.Name = "btnMilk"
        Me.btnMilk.Size = New System.Drawing.Size(180, 54)
        Me.btnMilk.TabIndex = 49
        Me.btnMilk.Text = "MILK"
        Me.btnMilk.UseVisualStyleBackColor = False
        '
        'btnChoco
        '
        Me.btnChoco.BackColor = System.Drawing.Color.Transparent
        Me.btnChoco.FlatAppearance.BorderSize = 0
        Me.btnChoco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChoco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChoco.Location = New System.Drawing.Point(0, 348)
        Me.btnChoco.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChoco.Name = "btnChoco"
        Me.btnChoco.Size = New System.Drawing.Size(180, 54)
        Me.btnChoco.TabIndex = 47
        Me.btnChoco.Text = "CHOCOLATE"
        Me.btnChoco.UseVisualStyleBackColor = False
        '
        'btnCoffee
        '
        Me.btnCoffee.BackColor = System.Drawing.Color.Transparent
        Me.btnCoffee.FlatAppearance.BorderSize = 0
        Me.btnCoffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCoffee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCoffee.Location = New System.Drawing.Point(0, 123)
        Me.btnCoffee.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCoffee.Name = "btnCoffee"
        Me.btnCoffee.Size = New System.Drawing.Size(180, 54)
        Me.btnCoffee.TabIndex = 5
        Me.btnCoffee.Text = "COFFEE"
        Me.btnCoffee.UseVisualStyleBackColor = False
        '
        'Btn_NewOrder
        '
        Me.Btn_NewOrder.Location = New System.Drawing.Point(1161, 632)
        Me.Btn_NewOrder.Name = "Btn_NewOrder"
        Me.Btn_NewOrder.Size = New System.Drawing.Size(75, 23)
        Me.Btn_NewOrder.TabIndex = 61
        Me.Btn_NewOrder.Text = "Button6"
        Me.Btn_NewOrder.UseVisualStyleBackColor = True
        '
        'Btn_CancelOrder
        '
        Me.Btn_CancelOrder.Location = New System.Drawing.Point(1161, 661)
        Me.Btn_CancelOrder.Name = "Btn_CancelOrder"
        Me.Btn_CancelOrder.Size = New System.Drawing.Size(75, 23)
        Me.Btn_CancelOrder.TabIndex = 60
        Me.Btn_CancelOrder.Text = "Button4"
        Me.Btn_CancelOrder.UseVisualStyleBackColor = True
        '
        'Btn_Pay
        '
        Me.Btn_Pay.Location = New System.Drawing.Point(1161, 603)
        Me.Btn_Pay.Name = "Btn_Pay"
        Me.Btn_Pay.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Pay.TabIndex = 59
        Me.Btn_Pay.Text = "Button3"
        Me.Btn_Pay.UseVisualStyleBackColor = True
        '
        'btn_ManageCoffee
        '
        Me.btn_ManageCoffee.Location = New System.Drawing.Point(1161, 574)
        Me.btn_ManageCoffee.Name = "btn_ManageCoffee"
        Me.btn_ManageCoffee.Size = New System.Drawing.Size(75, 23)
        Me.btn_ManageCoffee.TabIndex = 58
        Me.btn_ManageCoffee.Text = "manageC"
        Me.btn_ManageCoffee.UseVisualStyleBackColor = True
        '
        'Btn_Exit
        '
        Me.Btn_Exit.Location = New System.Drawing.Point(1161, 545)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Exit.TabIndex = 57
        Me.Btn_Exit.Text = "exit"
        Me.Btn_Exit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1176, 483)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Total:"
        '
        'Cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Log_In.My.Resources.Resources._6
        Me.ClientSize = New System.Drawing.Size(1327, 974)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents Button6 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCheckout As Button
    Friend WithEvents pnlOption As Panel
    Friend WithEvents rbTakeOut As RadioButton
    Friend WithEvents btnCancelOrder As Button
    Friend WithEvents pnlTop As Panel
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents btnProducts As Button
    Friend WithEvents Btn_report As Button
    Friend WithEvents pnlOnBtnPosition As Panel
    Friend WithEvents btnMilk As Button
    Friend WithEvents btnChoco As Button
    Friend WithEvents btnCoffee As Button
    Friend WithEvents Btn_NewOrder As Button
    Friend WithEvents Btn_CancelOrder As Button
    Friend WithEvents Btn_Pay As Button
    Friend WithEvents btn_ManageCoffee As Button
    Friend WithEvents Btn_Exit As Button
    Friend WithEvents Label5 As Label
End Class
