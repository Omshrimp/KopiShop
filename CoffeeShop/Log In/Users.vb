Imports System.Data.OleDb

Public Class Users
    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call get_records()
        Call panel()

        MenuStrip1.Padding = New Padding(60, 10, 60, 10)
    End Sub

    Sub get_records()
        Call database_connection()

        dbADAP = New OleDb.OleDbDataAdapter("select * from tblAccounts", dbCON)
        dbDS = New DataSet
        dbADAP.Fill(dbDS, "tblAccounts")

        RecPointer = 0
        TotalRec = dbDS.Tables("tblAccounts").Rows.Count

        Call display_records()
    End Sub
    Sub display_records()
        dbDS.Tables("tblAccounts").AcceptChanges()
        dgRecords.DataSource = Nothing
        dgRecords.DataSource = dbDS.Tables("tblAccounts")
        dgRecords.Enabled = True


        Call Clear_Textboxes()
        Call Lock_Textboxes()
        Call MenuStrip()

    End Sub

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        dbADAP = New OleDb.OleDbDataAdapter("select * from tblAccounts where [Employee ID] = " & txtEmployee.Text, dbCON)
        dbDS = New DataSet
        dbADAP.Fill(dbDS, "tblAccounts")
        dgRecords.DataSource = dbDS.Tables("tblAccounts")

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
            dbCMD = New OleDb.OleDbCommand("delete from tblAccounts where [Employee ID] = @EmployeeID", dbCON)
            dbCMD.Parameters.AddWithValue("@EmployeeID", txtEmployee.Text)
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

        If txtName.Text = "" Or txtUname.Text = "" Or txtPass.Text = "" Then
            MsgBox("Please supply all the information needed!", MsgBoxStyle.Information, "Required")
            Exit Sub
        End If

        If Not IsNumeric(txtContact.Text) Then
            MsgBox("Please check the age inputted", MsgBoxStyle.Information, "Invalid")
            txtContact.SelectAll()
            Exit Sub
        End If

        If MsgBox("Do you want to save the changes you made to this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Updating...") = MsgBoxResult.Yes Then
            dbCMD = New OleDb.OleDbCommand("UPDATE tblAccounts SET [Full Name] = ?, [Username] = ?, [Password] = ?, [Contact] = ?, [Role] = ? WHERE [Employee ID] = ?", dbCON)
            dbCMD.Parameters.AddWithValue("?", txtName.Text)
            dbCMD.Parameters.AddWithValue("?", txtUname.Text)
            dbCMD.Parameters.AddWithValue("?", txtPass.Text)
            dbCMD.Parameters.AddWithValue("?", txtContact.Text)
            dbCMD.Parameters.AddWithValue("?", cboRole.Text)
            dbCMD.Parameters.AddWithValue("?", txtEmployee.Text)
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
        If txtName.Text = Nothing Or txtUname.Text = Nothing Or txtPass.Text = Nothing Or txtContact.Text = Nothing Or cboRole.Text = Nothing Then
            MsgBox("All Fields are Required!", MsgBoxStyle.Exclamation & MsgBoxStyle.Critical, "Validation Error")
        ElseIf txtName.Text = Nothing Then
            MsgBox("Name field is required!", MsgBoxStyle.Exclamation & MsgBoxStyle.Critical, "Validation Error")
        ElseIf txtUname.Text = Nothing Then
            MsgBox("Username field is required!", MsgBoxStyle.Exclamation & MsgBoxStyle.Critical, "Validation Error")
        ElseIf txtPass.Text = Nothing Then
            MsgBox("Password field is required!", MsgBoxStyle.Exclamation & MsgBoxStyle.Critical, "Validation Error")
        ElseIf txtContact.Text = Nothing Then
            MsgBox("Contact field is required!", MsgBoxStyle.Exclamation & MsgBoxStyle.Critical, "Validation Error")
        ElseIf Not IsNumeric(txtContact.Text) Then
            MsgBox("Please enter a valid numeric value for the contact.", MsgBoxStyle.Exclamation & MsgBoxStyle.Critical, "Validation Error")
        ElseIf cboRole.Text = Nothing Then
            MsgBox("Role selection is required!", MsgBoxStyle.Exclamation & MsgBoxStyle.Critical, "Validation Error")
        Else

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to Save this Record?",
        "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                dbADAP = New OleDb.OleDbDataAdapter("SELECT * FROM tblAccounts WHERE [Employee ID] = @EmployeeID", dbCON)
                dbADAP.SelectCommand.Parameters.AddWithValue("@EmployeeID", txtEmployee.Text.Trim())
                dbDS = New DataSet
                dbDS.Clear()
                dbADAP.Fill(dbDS, "tblAccounts")
                If dbDS.Tables("tblAccounts").Rows.Count = 0 Then
                    MsgBox("Employee already exists!", MsgBoxStyle.Exclamation, "Error")
                Else
                    Call Connection_State()
                    dbCMD = New OleDb.OleDbCommand("INSERT INTO tblAccounts([Full Name],[Username],[Password],[Contact],[Role])Values(@FullName, @Username, @Password, @Contact, @Role)", dbCON)
                    dbCMD.Parameters.AddWithValue("@FullName", OleDbType.VarChar).Value = txtName.Text.Trim()
                    dbCMD.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txtUname.Text.Trim()
                    dbCMD.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtPass.Text.Trim()
                    dbCMD.Parameters.AddWithValue("@Contact", OleDbType.VarChar).Value = txtContact.Text.Trim()
                    dbCMD.Parameters.AddWithValue("@Role", OleDbType.VarChar).Value = cboRole.Text.Trim()
                    dbCMD.ExecuteNonQuery()

                    MsgBox("Employee added successfully!", MsgBoxStyle.Information, "Success")
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
        txtName.ReadOnly = True
        txtUname.ReadOnly = True
        txtPass.ReadOnly = True
        txtContact.ReadOnly = True
        txtEmployee.ReadOnly = True
        cboRole.Enabled = False
    End Sub
    Sub Unlock_Textboxes()
        txtName.ReadOnly = False
        txtUname.ReadOnly = False
        txtPass.ReadOnly = False
        txtContact.ReadOnly = False
        txtEmployee.ReadOnly = True
        cboRole.Enabled = True
    End Sub
    Sub Clear_Textboxes()
        txtName.Clear()
        txtUname.Clear()
        txtPass.Clear()
        txtContact.Clear()
        txtEmployee.Clear()
        cboRole.Text = Nothing
    End Sub
    Private Sub pbHome_Click(sender As Object, e As EventArgs)
        Me.Close()
        Administrator.Show()
    End Sub
    Private Sub pbUsers_Click_1(sender As Object, e As EventArgs) Handles pbUsers.Click
        Me.Show()
    End Sub

    Private Sub pbStocks_Click_1(sender As Object, e As EventArgs) Handles pbStocks.Click
        Me.Close()
        frmCoffeeManageEntry.Show()
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
End Class


