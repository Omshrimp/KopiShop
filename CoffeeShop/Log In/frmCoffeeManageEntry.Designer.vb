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
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.btn_Browse = New System.Windows.Forms.Button()
        Me.Pic_Coffeeimg = New System.Windows.Forms.PictureBox()
        Me.Check_Status = New System.Windows.Forms.CheckBox()
        Me.Combo_size = New System.Windows.Forms.ComboBox()
        Me.txt_Coffeename = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_coffeeCode = New System.Windows.Forms.TextBox()
        CType(Me.Pic_Coffeeimg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(553, 394)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(80, 35)
        Me.btn_Delete.TabIndex = 29
        Me.btn_Delete.Text = "delete"
        Me.btn_Delete.UseVisualStyleBackColor = True
        '
        'Btn_Edit
        '
        Me.Btn_Edit.Location = New System.Drawing.Point(467, 394)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(80, 35)
        Me.Btn_Edit.TabIndex = 28
        Me.Btn_Edit.Text = "Edit"
        Me.Btn_Edit.UseVisualStyleBackColor = True
        '
        'Btn_Save
        '
        Me.Btn_Save.Location = New System.Drawing.Point(381, 394)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(80, 35)
        Me.Btn_Save.TabIndex = 27
        Me.Btn_Save.Text = "save"
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Browse
        '
        Me.btn_Browse.Location = New System.Drawing.Point(282, 394)
        Me.btn_Browse.Name = "btn_Browse"
        Me.btn_Browse.Size = New System.Drawing.Size(80, 35)
        Me.btn_Browse.TabIndex = 26
        Me.btn_Browse.Text = "browse"
        Me.btn_Browse.UseVisualStyleBackColor = True
        '
        'Pic_Coffeeimg
        '
        Me.Pic_Coffeeimg.Location = New System.Drawing.Point(266, 143)
        Me.Pic_Coffeeimg.Name = "Pic_Coffeeimg"
        Me.Pic_Coffeeimg.Size = New System.Drawing.Size(222, 174)
        Me.Pic_Coffeeimg.TabIndex = 25
        Me.Pic_Coffeeimg.TabStop = False
        '
        'Check_Status
        '
        Me.Check_Status.AutoSize = True
        Me.Check_Status.Location = New System.Drawing.Point(588, 311)
        Me.Check_Status.Name = "Check_Status"
        Me.Check_Status.Size = New System.Drawing.Size(97, 20)
        Me.Check_Status.TabIndex = 24
        Me.Check_Status.Text = "CheckBox1"
        Me.Check_Status.UseVisualStyleBackColor = True
        '
        'Combo_size
        '
        Me.Combo_size.FormattingEnabled = True
        Me.Combo_size.Items.AddRange(New Object() {"Large", "Small"})
        Me.Combo_size.Location = New System.Drawing.Point(581, 254)
        Me.Combo_size.Name = "Combo_size"
        Me.Combo_size.Size = New System.Drawing.Size(164, 24)
        Me.Combo_size.TabIndex = 23
        '
        'txt_Coffeename
        '
        Me.txt_Coffeename.Location = New System.Drawing.Point(581, 171)
        Me.txt_Coffeename.Name = "txt_Coffeename"
        Me.txt_Coffeename.Size = New System.Drawing.Size(164, 22)
        Me.txt_Coffeename.TabIndex = 22
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(581, 209)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(164, 22)
        Me.txt_price.TabIndex = 21
        '
        'txt_coffeeCode
        '
        Me.txt_coffeeCode.Location = New System.Drawing.Point(581, 132)
        Me.txt_coffeeCode.Name = "txt_coffeeCode"
        Me.txt_coffeeCode.Size = New System.Drawing.Size(164, 22)
        Me.txt_coffeeCode.TabIndex = 20
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 560)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.Btn_Edit)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.btn_Browse)
        Me.Controls.Add(Me.Pic_Coffeeimg)
        Me.Controls.Add(Me.Check_Status)
        Me.Controls.Add(Me.Combo_size)
        Me.Controls.Add(Me.txt_Coffeename)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_coffeeCode)
        Me.Name = "Reports"
        Me.Text = "Reports"
        CType(Me.Pic_Coffeeimg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Delete As Button
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents Btn_Save As Button
    Friend WithEvents btn_Browse As Button
    Friend WithEvents Pic_Coffeeimg As PictureBox
    Friend WithEvents Check_Status As CheckBox
    Friend WithEvents Combo_size As ComboBox
    Friend WithEvents txt_Coffeename As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_coffeeCode As TextBox
End Class
