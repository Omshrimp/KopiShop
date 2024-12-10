Imports System.Data.OleDb

Public Class Cashier

    Dim dr As OleDbDataReader
    Dim i As Integer
        Dim _filter As String = ""
        Dim dbADAP As New OleDb.OleDbDataAdapter
        Dim dbDS As DataSet
        Dim overtotal As Decimal

    Private Sub Cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call database_connection()

        lbl_OrderDate.Text = Date.Now.ToString("dd/MM/yyyy")
        lbl_orderno.Text = getorderno()
        imageload()

        ' Define DataGridView columns here
        DataGridView1.Columns.Clear() ' Clear existing columns (if any)
        DataGridView1.Columns.Add("OrderNo", "Order No")
        DataGridView1.Columns.Add("CoffeeCode", "Coffee Code")
        DataGridView1.Columns.Add("CoffeeName", "Coffee Name")
        DataGridView1.Columns.Add("Price", "Price")
        DataGridView1.Columns.Add("Quantity", "Quantity")

        dbADAP = New OleDb.OleDbDataAdapter("select * from OrderMaster", dbCON)
        dbDS = New DataSet
        dbADAP.Fill(dbDS, "OrderMaster")
    End Sub

    Function getorderno() As String
            Try
                Dim sdate As String = Now.ToString("yyyy")

            Dim cmd As New OleDb.OleDbCommand("select * from OrderMaster where orderno like '" & sdate & "%' order by id desc", dbCON)
            dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    getorderno = CLng(dr.Item("orderno").ToString) + 1
                Else
                    getorderno = sdate & "0001"
                End If



        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        End Function

        Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
            If MessageBox.Show("Are You Sure Exit", "CMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                End
            Else
                Return
            End If
        End Sub


    Sub imageload()
        Dim cmd As New OleDb.OleDbCommand("SELECT `img`,`coffeecode`,`coffeename`,`size`,`price`,`status` FROM coffeeMaster", dbCON)
        dr = cmd.ExecuteReader
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Controls.Clear()

        While dr.Read
            Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
            Dim array(CInt(len)) As Byte
            dr.GetBytes(0, 0, array, 0, CInt(len))

            pic = New PictureBox
            pic.Width = 120
            pic.Height = 150
            pic.BackgroundImageLayout = ImageLayout.Stretch
            pic.Tag = dr.Item("coffeecode").ToString

            lbldesc = New Label
            lbldesc.ForeColor = Color.White
            lbldesc.BackColor = Color.DodgerBlue
            lbldesc.TextAlign = ContentAlignment.MiddleCenter
            lbldesc.Dock = DockStyle.Top
            lbldesc.Font = New Font("Segoe UI", 8, FontStyle.Bold)
            lbldesc.Tag = dr.Item("coffeecode").ToString

            lblprice = New Label
            lblprice.ForeColor = Color.White
            lblprice.BackColor = Color.DarkOrange
            lblprice.Dock = DockStyle.Bottom
            lblprice.TextAlign = ContentAlignment.MiddleCenter
            lblprice.AutoSize = False
            lblprice.Font = New Font("Segoe UI", 12, FontStyle.Bold)
            lblprice.Tag = dr.Item("coffeecode").ToString

            Dim ms As New System.IO.MemoryStream(array)
            Dim bitmap As New System.Drawing.Bitmap(ms)
            pic.BackgroundImage = bitmap
            lbldesc.Text = dr.Item("coffeename").ToString
            lblprice.Text = dr.Item("price").ToString

            pic.Controls.Add(lbldesc)
            pic.Controls.Add(lblprice)
            FlowLayoutPanel1.Controls.Add(pic)

            AddHandler pic.Click, AddressOf Selectimg_Click
            AddHandler lbldesc.Click, AddressOf Selectimg_Click
            AddHandler lblprice.Click, AddressOf Selectimg_Click

        End While
        dr.Dispose()
    End Sub

    Public Sub Selectimg_Click(sender As Object, e As EventArgs)
        Dim cmd As New OleDb.OleDbCommand("select * from coffeeMaster where coffeecode like '" & sender.tag.ToString & "%' ", dbCON)
        dr = cmd.ExecuteReader
        While dr.Read = True
            ' Before adding rows, ensure columns are defined in DataGridView
            If DataGridView1.Columns.Count = 0 Then
                ' Add columns dynamically if not defined yet
                DataGridView1.Columns.Add("OrderNo", "Order No")
                DataGridView1.Columns.Add("CoffeeCode", "Coffee Code")
                DataGridView1.Columns.Add("CoffeeName", "Coffee Name")
                DataGridView1.Columns.Add("Price", "Price")
                DataGridView1.Columns.Add("Quantity", "Quantity")
            End If

            ' Add rows now that columns are defined
            DataGridView1.Rows.Add(New String() {DataGridView1.Rows.Count + 1, dr.Item("coffeecode").ToString, dr.Item("coffeename").ToString, dr.Item("price"), 1})
        End While

    End Sub

    Sub overalltotal()
            Dim i As Decimal
            Dim sum As Decimal = 0
            For i = 0 To DataGridView1.Rows.Count - 1
                sum += DataGridView1.Rows(i).Cells(3).Value * DataGridView1.Rows(i).Cells(4).Value
            Next
            lbl_total.Text = CDec(sum)
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As EventArgs)
            overalltotal()
        End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs)
        Dim cmd As New OleDb.OleDbCommand("SELECT `img`,`coffeecode`,`coffeename`,`size`,`price`,`status` FROM coffeeMaster Where coffeecode like '%" & txt_search.Text & "%' or coffeename like '%" & txt_search.Text & "%'", dbCON)
        dr = cmd.ExecuteReader
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Controls.Clear()

        While dr.Read
            Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
            Dim array(CInt(len)) As Byte
            dr.GetBytes(0, 0, array, 0, CInt(len))

            pic = New PictureBox
            pic.Width = 120
            pic.Height = 150
            pic.BackgroundImageLayout = ImageLayout.Stretch
            pic.Tag = dr.Item("coffeecode").ToString

            lbldesc = New Label
            lbldesc.ForeColor = Color.White
            lbldesc.BackColor = Color.DodgerBlue
            lbldesc.TextAlign = ContentAlignment.MiddleCenter
            lbldesc.Dock = DockStyle.Top
            lbldesc.Font = New Font("Segoe UI", 8, FontStyle.Bold)
            lbldesc.Tag = dr.Item("coffeecode").ToString

            lblprice = New Label
            lblprice.ForeColor = Color.White
            lblprice.BackColor = Color.DarkOrange
            lblprice.Dock = DockStyle.Bottom
            lblprice.TextAlign = ContentAlignment.MiddleCenter
            lblprice.AutoSize = False
            lblprice.Font = New Font("Segoe UI", 12, FontStyle.Bold)
            lblprice.Tag = dr.Item("coffeecode").ToString

            Dim ms As New System.IO.MemoryStream(array)
            Dim bitmap As New System.Drawing.Bitmap(ms)
            pic.BackgroundImage = bitmap
            lbldesc.Text = dr.Item("coffeename").ToString
            lblprice.Text = dr.Item("price").ToString

            pic.Controls.Add(lbldesc)
            pic.Controls.Add(lblprice)
            FlowLayoutPanel1.Controls.Add(pic)

            AddHandler pic.Click, AddressOf Selectimg_Click
            AddHandler lbldesc.Click, AddressOf Selectimg_Click
            AddHandler lblprice.Click, AddressOf Selectimg_Click

        End While
        dr.Dispose()

    End Sub


    Private Sub btn_ManageCoffee_Click(sender As Object, e As EventArgs) Handles btn_ManageCoffee.Click
        frmManageCoffee.ShowDialog()
    End Sub


End Class
