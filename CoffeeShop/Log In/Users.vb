Imports System.Data.OleDb
Imports System.Reflection.Emit

Public Class Users
    Dim Toggle As Boolean
    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call database_connection()
        Call get_records()
        Call panel()
        MenuStrip1.Padding = New Padding(60, 10, 60, 10)
    End Sub

    Sub panel()
        Panel1.Width = 60
        gpbToggle.Width = 50
        MenuStrip1.Visible = True
    End Sub

    Public Sub get_records()
        dbADAP = New OleDb.OleDbDataAdapter("select * from tblAccounts", dbCON)
        dbDS = New DataSet
        dbADAP.Fill(dbDS, "tblAccounts")

        RecPointer = 0
        TotalRec = dbDS.Tables("tblAccounts").Rows.Count

        Call display_records()
    End Sub
    Public Sub display_records()
        dbDS.Tables("tblAccounts").AcceptChanges()
        dgRecords.DataSource = Nothing
        dgRecords.DataSource = dbDS.Tables("tblAccounts")
        dgRecords.Enabled = True
    End Sub

    Sub Lock_Textboxes()
        txtName.ReadOnly = True
        txtUname.ReadOnly = True
        txtPass.ReadOnly = True
        txtContact.ReadOnly = True
        cboRole.Enabled = False
    End Sub

    Sub Unlock_Textboxes()
        txtName.ReadOnly = False
        txtUname.ReadOnly = False
        txtPass.ReadOnly = False
        txtContact.ReadOnly = False
        cboRole.Text = Nothing
    End Sub

    Sub Clear_Textboxes()
        txtName.Clear()
        txtUname.Clear()
        txtPass.Clear()
        txtContact.Clear()
        cboRole.Text = Nothing
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
        dbADAP = New OleDb.OleDbDataAdapter("SELECT * FROM tblAccounts WHERE [Employee Number] = @EmployeeNumber", dbCON)
        dbADAP.SelectCommand.Parameters.AddWithValue("@EmployeeNumber", txtEmployee.Text.Trim())
        dbDS = New DataSet
        dbADAP.Fill(dbDS, "tblAccounts")

        If dbDS.Tables("tblAccounts").Rows.Count < 0 Then
            MsgBox("Employee already exists!", MsgBoxStyle.Exclamation, "Error")
        Else
            dbCMD = New OleDb.OleDbCommand("INSERT INTO tblAccounts([Full Name],[Username],[Password],[Contact],[Role])Values(@FullName, @Username, @Password, @Contact, @Role)", dbCON)
            dbCMD.Parameters.AddWithValue("@Full Name", OleDbType.VarChar).Value = txtName.Text
            dbCMD.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txtUname.Text
            dbCMD.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtPass.Text
            dbCMD.Parameters.AddWithValue("@Contact", OleDbType.VarChar).Value = txtContact.Text
            dbCMD.Parameters.AddWithValue("@Role", OleDbType.VarChar).Value = cboRole.Text
            dbCMD.ExecuteNonQuery()

            MsgBox("Employee added successfully!", MsgBoxStyle.Information, "Success")
        End If
        Call Clear_Textboxes()
        Call database_connection()
        Call get_records()
    End Sub

    Private Sub mnuDelete_Click(sender As Object, e As EventArgs) Handles mnuDelete.Click
        dbCMD = New OleDb.OleDbCommand("delete from tblAccounts where [Employee Number] = @EmployeeNumber", dbCON)
        dbCMD.Parameters.AddWithValue("@EmployeeNumber", txtEmployee.Text)
        dbCMD.ExecuteNonQuery()
        dbCON.Close()
        Call Clear_Textboxes()
        Call database_connection()
        Call get_records()
    End Sub

    Private Sub dgRecords_SelectionChanged(sender As Object, e As EventArgs) Handles dgRecords.SelectionChanged
        If dgRecords.CurrentRow IsNot Nothing Then
            Dim selectedRow As DataGridViewRow = dgRecords.CurrentRow

            txtEmployee.Text = selectedRow.Cells("Employee Number").Value?.ToString()
            txtName.Text = selectedRow.Cells("Full Name").Value?.ToString()
            txtUname.Text = selectedRow.Cells("Username").Value?.ToString()
            txtPass.Text = selectedRow.Cells("Password").Value?.ToString()
            txtContact.Text = selectedRow.Cells("Contact").Value?.ToString()
            cboRole.SelectedItem = selectedRow.Cells("Role").Value?.ToString()
        End If
    End Sub
End Class