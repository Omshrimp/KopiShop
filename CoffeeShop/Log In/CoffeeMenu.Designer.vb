<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CoffeeMenu
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
        Me.btnIcedCof = New System.Windows.Forms.Button()
        Me.btnCap = New System.Windows.Forms.Button()
        Me.btnAme = New System.Windows.Forms.Button()
        Me.btnEspre = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnIcedCof
        '
        Me.btnIcedCof.Font = New System.Drawing.Font("quaver", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIcedCof.Location = New System.Drawing.Point(495, 42)
        Me.btnIcedCof.Name = "btnIcedCof"
        Me.btnIcedCof.Size = New System.Drawing.Size(152, 156)
        Me.btnIcedCof.TabIndex = 30
        Me.btnIcedCof.Text = "ICED COFFEE"
        Me.btnIcedCof.UseVisualStyleBackColor = True
        '
        'btnCap
        '
        Me.btnCap.Font = New System.Drawing.Font("quaver", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCap.Location = New System.Drawing.Point(339, 42)
        Me.btnCap.Name = "btnCap"
        Me.btnCap.Size = New System.Drawing.Size(152, 156)
        Me.btnCap.TabIndex = 29
        Me.btnCap.Text = "CAPPUCCINO"
        Me.btnCap.UseVisualStyleBackColor = True
        '
        'btnAme
        '
        Me.btnAme.Font = New System.Drawing.Font("quaver", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAme.Location = New System.Drawing.Point(183, 42)
        Me.btnAme.Name = "btnAme"
        Me.btnAme.Size = New System.Drawing.Size(152, 156)
        Me.btnAme.TabIndex = 28
        Me.btnAme.Text = "AMERICANO"
        Me.btnAme.UseVisualStyleBackColor = True
        '
        'btnEspre
        '
        Me.btnEspre.Font = New System.Drawing.Font("quaver", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEspre.Location = New System.Drawing.Point(27, 42)
        Me.btnEspre.Name = "btnEspre"
        Me.btnEspre.Size = New System.Drawing.Size(152, 156)
        Me.btnEspre.TabIndex = 27
        Me.btnEspre.Text = "ESPRESSO"
        Me.btnEspre.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("quaver", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "COFFEE"
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Himalaya", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(34, 215)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(29, 28)
        Me.Button7.TabIndex = 34
        Me.Button7.Text = "-"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Himalaya", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(132, 216)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(29, 28)
        Me.Button6.TabIndex = 33
        Me.Button6.Text = "+"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("quaver", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(69, 216)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(57, 27)
        Me.TextBox1.TabIndex = 32
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("quaver", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(183, 210)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(149, 33)
        Me.Button5.TabIndex = 31
        Me.Button5.Text = "ADD  TO ORDER"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'CoffeeMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 257)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnIcedCof)
        Me.Controls.Add(Me.btnCap)
        Me.Controls.Add(Me.btnAme)
        Me.Controls.Add(Me.btnEspre)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CoffeeMenu"
        Me.Text = "CoffeeMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIcedCof As Button
    Friend WithEvents btnCap As Button
    Friend WithEvents btnAme As Button
    Friend WithEvents btnEspre As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button5 As Button
End Class
