Public Class frmCoffeeManageEntry

    Private Sub frmManageCoffeeEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mnuFile.Padding = New Padding(70, 10, 70, 10)
        btn_Browse.Visible = False
        pbProducts.BackColor = Color.Brown

        Call get_records()
        Call Lock_Textboxes()
        Call MenuStrip()

    End Sub
    Sub get_records()
        Call database_connection()

        dbADAP = New OleDb.OleDbDataAdapter("select * from tblProducts", dbCON)
        dbDS = New DataSet
        dbADAP.Fill(dbDS, "tblProducts")

        RecPointer = 0
        TotalRec = dbDS.Tables("tblProducts").Rows.Count

        Call display_records()
    End Sub
    Sub display_records()
        dbDS.Tables("tblProducts").AcceptChanges()
        dgProducts.DataSource = Nothing
        dgProducts.DataSource = dbDS.Tables("tblProducts")
        dgProducts.Enabled = True


        Call Clear_Textboxes()
        Call Lock_Textboxes()
        Call MenuStrip()
    End Sub

    Private Sub btn_Browse_Click(sender As Object, e As EventArgs) Handles btn_Browse.Click
            Dim pop As OpenFileDialog = New OpenFileDialog
            If pop.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                Pic_Coffeeimg.Image = Image.FromFile(pop.FileName)
            End If
        End Sub
    Sub clear()
        txt_coffeeCode.Clear()
        txt_Coffeename.Clear()
        txt_price.Clear()
        Pic_Coffeeimg.Image = Nothing
    End Sub
    Sub save()
        Try
            Dim cmd As New OleDb.OleDbCommand("insert into tblProducts(`coffeecode`,`coffeename`,`price`,`img`) values (@coffeecode,@coffeename,@price,@img)", dbCON)
            Dim i As New Integer
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@coffeecode", txt_coffeeCode.Text)
            cmd.Parameters.AddWithValue("@coffeename", txt_Coffeename.Text)
            cmd.Parameters.AddWithValue("@price", txt_price.Text)
            Dim FileSize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            Pic_Coffeeimg.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.GetBuffer
            FileSize = mstream.Length
            mstream.Close()
            cmd.Parameters.AddWithValue("@img", picture)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New Coffee Register Success !", vbInformation)
            Else
                MsgBox("New Coffee Register Failed !", vbCritical)
            End If

            'Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
            End Try
        dbCON.Close()
        Cashier.imageload()
        Call get_records()
    End Sub

    Sub update()
        Dim cmd As New OleDb.OleDbCommand("UPDATE tblProducts SET `coffeename`=@coffeename,`price`=@price,`img`=@img WHERE `coffeecode`=@coffeecode", dbCON)
        Dim i As New Integer
        cmd.Parameters.Clear()

        cmd.Parameters.AddWithValue("@coffeename", txt_Coffeename.Text)
        cmd.Parameters.AddWithValue("@price", txt_price.Text)
        'image convert to binary format

        Dim FileSize As New UInt32
        Dim mstream As New System.IO.MemoryStream
        Pic_Coffeeimg.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim picture() As Byte = mstream.GetBuffer
        FileSize = mstream.Length
        mstream.Close()
        cmd.Parameters.AddWithValue("@img", picture)
        cmd.Parameters.AddWithValue("@coffeecode", txt_coffeeCode.Text)
        i = cmd.ExecuteNonQuery
        If i > 0 Then
            MsgBox("New Coffee Update Success !", vbInformation)
        Else
            MsgBox("New Coffee Update Failed !", vbCritical)
        End If

        dbCON.Close()
        Cashier.imageload()
        Call get_records()
    End Sub


    Sub delete()

        If MsgBox("Are you Sure Delete This Record?", vbQuestion + vbYesNo) = vbYes Then

            Dim cmd As New OleDb.OleDbCommand("DELETE FROM tblProducts WHERE coffeecode = @coffeecode", dbCON)
            Dim i As New Integer
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@coffeecode", txt_coffeeCode.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Coffee Deleted Successfully !", vbInformation)
            Else
                MsgBox("Coffee Deleted Failed !", vbCritical)
            End If

            dbCON.Close()
            Cashier.imageload()
        End If
        Call get_records()

    End Sub
    Private Sub txt_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_price.KeyPress
            Select Case Asc(e.KeyChar)
                Case 48 To 57
                Case 46
                Case 8
                Case Else
                    e.Handled = True
            End Select
        End Sub

    Private Sub dgProducts_SelectionChanged(sender As Object, e As EventArgs) Handles dgProducts.SelectionChanged

        If dgProducts.CurrentRow IsNot Nothing Then
            Dim selectedRow As DataGridViewRow = dgProducts.CurrentRow

            txt_coffeeCode.Text = selectedRow.Cells("coffeecode").Value?.ToString()
            txt_Coffeename.Text = selectedRow.Cells("coffeename").Value?.ToString()
            txt_price.Text = selectedRow.Cells("price").Value?.ToString()

            If Not IsDBNull(selectedRow.Cells("img").Value) AndAlso selectedRow.Cells("img").Value IsNot Nothing Then
                Dim imageData As Byte() = CType(selectedRow.Cells("img").Value, Byte())

                ' Convert Byte array to Image
                Using mstream As New System.IO.MemoryStream(imageData)
                    Pic_Coffeeimg.Image = Image.FromStream(mstream)
                End Using
            Else
                ' If no image, clear the PictureBox
                Pic_Coffeeimg.Image = Nothing
            End If
        End If
    End Sub

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        Clear_Textboxes()
        Unlock_Textboxes()
        btn_Browse.Visible = True
        mnuAdd.Visible = False
        mnuEdit.Visible = False
        mnuDelete.Visible = False
        mnuUpdate.Visible = True
        mnuSave.Visible = False
        mnuCancel.Visible = True
    End Sub

    Private Sub mnuUpdate_Click(sender As Object, e As EventArgs) Handles mnuUpdate.Click
        Clear_Textboxes()
        update()
    End Sub

    Private Sub mnuDelete_Click(sender As Object, e As EventArgs) Handles mnuDelete.Click
        Clear_Textboxes()
        delete()
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        Clear_Textboxes()
        save()
    End Sub
    Sub MenuStrip()
        mnuAdd.Visible = True
        mnuEdit.Visible = True
        mnuDelete.Visible = True
        mnuUpdate.Visible = False
        mnuSave.Visible = False
        mnuCancel.Visible = True
    End Sub
    Sub Lock_Textboxes()
        txt_coffeeCode.ReadOnly = True
        txt_Coffeename.ReadOnly = True
        txt_price.ReadOnly = True
    End Sub
    Sub Unlock_Textboxes()
        txt_coffeeCode.ReadOnly = False
        txt_Coffeename.ReadOnly = False
        txt_price.ReadOnly = False
    End Sub
    Sub Clear_Textboxes()
        txt_coffeeCode.Clear()
        txt_Coffeename.Clear()
        txt_price.Clear()
    End Sub

    Private Sub mnuAdd_Click(sender As Object, e As EventArgs) Handles mnuAdd.Click
        mnuAdd.Visible = False
        mnuEdit.Visible = False
        mnuDelete.Visible = False
        mnuUpdate.Visible = False
        mnuSave.Visible = True
        mnuCancel.Visible = True
        btn_Browse.Visible = True

        Unlock_Textboxes()

    End Sub

    Private Sub pbHome_Click(sender As Object, e As EventArgs)
        Me.Close()
        Administrator.Show()
    End Sub

    Private Sub pbUsers_Click_1(sender As Object, e As EventArgs) Handles pbUsers.Click
        Me.Close()
        Users.Show()
    End Sub

    Private Sub pbCashier_Click_1(sender As Object, e As EventArgs) Handles pbCashier.Click
        Cashier.Show()
        Me.Close()
    End Sub

    Private Sub pbLogOut_Click(sender As Object, e As EventArgs) Handles pbLogOut.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Log Out?",
       "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
            LogIn.Show()
        End If
    End Sub

    Private Sub pbTerminate_Click(sender As Object, e As EventArgs) Handles pbTerminate.Click

    End Sub
End Class
