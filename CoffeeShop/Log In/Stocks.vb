Imports System.Data.OleDb
Imports Microsoft.VisualBasic.Logging

Public Class Stocks
    Private Sub Stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.Padding = New Padding(70, 10, 70, 10)
        Call get_records()

    End Sub
    Sub get_records()
        Call database_connection()

        dbADAP = New OleDb.OleDbDataAdapter("select * from tblStocks", dbCON)
        dbDS = New DataSet
        dbADAP.Fill(dbDS, "tblStocks")

        RecPointer = 0
        TotalRec = dbDS.Tables("tblStocks").Rows.Count

        Call display_records()
    End Sub
    Sub display_records()
        dbDS.Tables("tblStocks").AcceptChanges()
        dgSRecords.DataSource = Nothing
        dgSRecords.DataSource = dbDS.Tables("tblStocks")
        dgSRecords.Enabled = True


        Call Clear_Textboxes()
        Call Lock_Textboxes()
        Call MenuStrip()
    End Sub
    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        dbADAP = New OleDb.OleDbDataAdapter("select * from tblStocks where [Employee ID] = " & txtID.Text, dbCON)
        dbDS = New DataSet
        dbADAP.Fill(dbDS, "tblStocks")
        dgSRecords.DataSource = dbDS.Tables("tblStocks")

        Call Unlock_Textboxes()
        mnuAdd.Visible = False
        mnuEdit.Visible = False
        mnuDelete.Visible = False
        mnuUpdate.Visible = True
        mnuSave.Visible = False
        mnuCancel.Visible = True
    End Sub
    Private Sub mnuDelete_Click(sender As Object, e As EventArgs) Handles mnuDelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to permanent delete this record?",
            "Deleting Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Call Connection_State()
            dbCMD = New OleDb.OleDbCommand("delete from tblStocks where [Product ID] = @ProductID", dbCON)
            dbCMD.Parameters.AddWithValue("@ProductID", txtID.Text)
            dbCMD.ExecuteNonQuery()
            dbCON.Close()

            Call Clear_Textboxes()
            Call get_records()
        End If
    End Sub
    Private Sub mnuCancel_Click(sender As Object, e As EventArgs) Handles mnuCancel.Click
        Call get_records()

    End Sub
    Private Sub mnuUpdate_Click(sender As Object, e As EventArgs) Handles mnuUpdate.Click
        Call Connection_State()

        If txtID.Text = "" Or txtPName.Text = "" Or txtPrice.Text Or txtStock.Text = "" Then
            MsgBox("Please supply all the information needed!", MsgBoxStyle.Information, "Required")
            Exit Sub
        End If

        If Not IsNumeric(txtID.Text) And Not IsNumeric(txtPrice.Text) And Not IsNumeric(txtStock.Text) Then
            MsgBox("It should be a number", MsgBoxStyle.Information, "Invalid")
            Exit Sub
        End If

        If MsgBox("Do you want to save the changes you made to this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Updating...") = MsgBoxResult.Yes Then
            dbCMD = New OleDb.OleDbCommand("UPDATE tblStocks SET [Product Name] = ?, [Price] = ?, [Stocks] = ? WHERE [Product ID] = ?", dbCON)
            dbCMD.Parameters.AddWithValue("?", txtPName.Text)
            dbCMD.Parameters.AddWithValue("?", txtPrice.Text)
            dbCMD.Parameters.AddWithValue("?", txtStock.Text)
            dbCMD.Parameters.AddWithValue("?", txtID.Text)
            dbCMD.ExecuteNonQuery()
            MsgBox("Record updated successfully!", MsgBoxStyle.Information, "Updated")
        End If
        Call Clear_Textboxes()
        Call get_records()
    End Sub
    Private Sub mnuAdd_Click(sender As Object, e As EventArgs) Handles mnuAdd.Click
        SaveOnly = True

        Call Unlock_Textboxes()
        Call Clear_Textboxes()

        mnuAdd.Visible = False
        mnuEdit.Visible = False
        mnuDelete.Visible = False
        mnuUpdate.Visible = False
        mnuSave.Visible = True
        mnuCancel.Visible = True
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        If txtID.Text = Nothing Or txtPName.Text = Nothing Or txtPrice.Text = Nothing Or txtStock.Text = Nothing Then
            MsgBox("All Fields are Required!", MsgBoxStyle.Exclamation & MsgBoxStyle.Critical, "Validation Error")
        ElseIf txtID.Text = Nothing Then
            MsgBox("Name field is required!", MsgBoxStyle.Exclamation & MsgBoxStyle.Critical, "Validation Error")
        ElseIf txtPName.Text = Nothing Then
            MsgBox("Username field is required!", MsgBoxStyle.Exclamation & MsgBoxStyle.Critical, "Validation Error")
        ElseIf txtPrice.Text = Nothing Then
            MsgBox("Password field is required!", MsgBoxStyle.Exclamation & MsgBoxStyle.Critical, "Validation Error")
        ElseIf txtStock.Text = Nothing Then
            MsgBox("Contact field is required!", MsgBoxStyle.Exclamation & MsgBoxStyle.Critical, "Validation Error")
        ElseIf Not IsNumeric(txtID.Text) And Not IsNumeric(txtPrice.Text) And Not IsNumeric(txtStock.Text) Then
            MsgBox("Please enter a valid numeric value for the contact.", MsgBoxStyle.Exclamation & MsgBoxStyle.Critical, "Validation Error")
        Else
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to Save this Record?",
            "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                dbADAP = New OleDb.OleDbDataAdapter("SELECT * FROM tblStocks WHERE [Product ID] = @ProductID", dbCON)
                dbADAP.SelectCommand.Parameters.AddWithValue("@ProductID", txtID.Text.Trim())
                dbDS = New DataSet
                dbDS.Clear()
                dbADAP.Fill(dbDS, "tblStocks")
                If dbDS.Tables("tblStocks").Rows.Count > 0 Then
                    MsgBox("Product already exists!", MsgBoxStyle.Exclamation, "Error")
                Else
                    Call Connection_State()

                    dbCMD = New OleDb.OleDbCommand("INSERT INTO tblStocks([Product ID],[Product Name],[Price],[Stocks])Values(@ProductID, @ProductName, @Price, @Stocks)", dbCON)
                    dbCMD.Parameters.AddWithValue("@ProductID", OleDbType.VarChar).Value = txtID.Text
                    dbCMD.Parameters.AddWithValue("@ProductName", OleDbType.VarChar).Value = txtPName.Text
                    dbCMD.Parameters.AddWithValue("@Price", OleDbType.VarChar).Value = txtPrice.Text
                    dbCMD.Parameters.AddWithValue("@Stocks", OleDbType.VarChar).Value = txtStock.Text
                    dbCMD.ExecuteNonQuery()

                    MsgBox("Product added successfully!", MsgBoxStyle.Information, "Success")
                End If


                mnuAdd.Visible = True
                mnuEdit.Visible = True
                mnuDelete.Visible = True
                mnuUpdate.Visible = False
                mnuSave.Visible = False
                mnuCancel.Visible = True

                Call database_connection()
                Call get_records()
            End If
        End If
    End Sub

    Private Sub dgSRecords_SelectionChanged(sender As Object, e As EventArgs) Handles dgSRecords.SelectionChanged
        If dgSRecords.CurrentRow IsNot Nothing Then
            Dim selectedRow As DataGridViewRow = dgSRecords.CurrentRow

            txtID.Text = selectedRow.Cells("Product ID").Value?.ToString()
            txtPName.Text = selectedRow.Cells("Product Name").Value?.ToString()
            txtPrice.Text = selectedRow.Cells("Price").Value?.ToString()
            txtStock.Text = selectedRow.Cells("Stocks").Value?.ToString()
        End If
    End Sub
    Private Sub pbTerminate_Click(sender As Object, e As EventArgs) Handles pbTerminate.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to terminate the application?",
            "Terminate Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Sub panel()
        Panel1.Width = 60
        gpbToggle.Width = 50
        MenuStrip1.Visible = True
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
        txtID.ReadOnly = True
        txtPName.ReadOnly = True
        txtPrice.ReadOnly = True
        txtStock.ReadOnly = True
    End Sub
    Sub Unlock_Textboxes()
        txtID.ReadOnly = False
        txtPName.ReadOnly = False
        txtPrice.ReadOnly = False
        txtStock.ReadOnly = False
    End Sub
    Sub Clear_Textboxes()
        txtID.Clear()
        txtPName.Clear()
        txtPrice.Clear()
        txtStock.Clear()
    End Sub

    Private Sub pbTerminate_Click_1(sender As Object, e As EventArgs) Handles pbTerminate.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to terminate the application?",
        "Terminate Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub pbHome_Click(sender As Object, e As EventArgs)
        Me.Close()
        Administrator.Show()
    End Sub
    Private Sub pbUsers_Click_1(sender As Object, e As EventArgs) Handles pbUsers.Click
        Me.Close()
        Users.Show()
    End Sub

    Private Sub pbStocks_Click_1(sender As Object, e As EventArgs) Handles pbStocks.Click
        Me.Show()

    End Sub

    Private Sub pbCashier_Click_1(sender As Object, e As EventArgs) Handles pbCashier.Click
        Me.Close()
        Cashier.Show()
    End Sub

    Private Sub pbLogOut_Click(sender As Object, e As EventArgs) Handles pbLogOut.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Log Out?",
        "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
            LogIn.Show()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dbADAP = New OleDb.OleDbDataAdapter("select * from tblStocks where [Product ID] like '%" & txtSearch.Text & "%' ", dbCON)
        dbDS = New DataSet
        dbADAP.Fill(dbDS, "tblStocks")
        If dbDS.Tables("tblStocks").Rows.Count > 0 Then
            TotalRec = dbDS.Tables("tblStocks").Rows.Count
            Call display_records()
            Dim row As DataRow = dbDS.Tables("tblStocks").Rows(0)
            txtID.Text = row("Product ID").ToString()
            txtPName.Text = row("Product Name").ToString()
            txtPrice.Text = row("Price").ToString()
            txtStock.Text = row("Stocks").ToString()
        Else
            dgSRecords.DataSource = Nothing
            Call Clear_Textboxes()
            MsgBox("No Record Found")
        End If
    End Sub
End Class
