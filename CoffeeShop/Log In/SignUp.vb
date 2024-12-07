
Public Class SignUp
    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call database_connection()
    End Sub
    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        If txtName.Text = Nothing And txtUserName.Text = Nothing And txtPass.Text = Nothing And cboRole.Text = Nothing Then
            MsgBox("All Fields are Required!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Log In")
        ElseIf txtName.Text = Nothing Then
            MsgBox("Please Enter Name", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Invalid Sign Up")
        ElseIf txtUserName.Text = Nothing Then
            MsgBox("Please Enter Username", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Invalid Sign Up")
        ElseIf txtPass.Text = Nothing Then
            MsgBox("Please Enter Password", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Invalid Sign Up")
        ElseIf txtPass.Text = Nothing Then
            MsgBox("Please Select Role", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Invalid Sign Up")
        Else
            dbCMD = New OleDb.OleDbCommand
            dbCMD.Connection = dbCON
            dbCMD.CommandText = "Insert into tblAccounts([Full Name],[Username],[Password],[Contact],[Role]) Values ('" & txtName.Text & "','" & txtUserName.Text & "','" & txtPass.Text & "','" & txtContact.Text & "','" & cboRole.SelectedItem & "')"
            dbCMD.ExecuteNonQuery()

            Dim result As Integer = Convert.ToInt32(dbCMD.ExecuteScalar())
            If result < 0 Then
                MsgBox("Account already existed!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Invalid Sign Up")
                Me.Show()
            Else
                MsgBox("You now have an Account" + vbCrLf + "Please Go Back To Log In To Coninue", MsgBoxStyle.OkOnly, "Account Created")
            End If
            txtName.Clear()
            txtUserName.Clear()
            txtPass.Clear()
            cboRole.Text = Nothing
        End If
    End Sub

    Private Sub lblLogIn_Click(sender As Object, e As EventArgs) Handles lblLogIn.Click
        LogIn.Show()
        Me.Hide()
    End Sub
End Class