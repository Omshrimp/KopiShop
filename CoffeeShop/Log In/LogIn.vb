Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Runtime.Remoting.Lifetime
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class LogIn
    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call database_connection()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If txtUserName.Text = Nothing And txtPass.Text = Nothing And cboRole.Text = Nothing Then
            MsgBox("All Fields are Required!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Log In")
        ElseIf txtUserName.Text = Nothing Then
            MsgBox("Please Enter Username", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Invalid Log In")
        ElseIf txtPass.Text = Nothing Then
            MsgBox("Please Enter Password", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Invalid Log In")
        ElseIf cboRole.Text = Nothing Then
            MsgBox("Please Select Role", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Invalid Log In")
        Else
            dbCMD = New OleDbCommand("select * from tblAccounts where Username=? and Password=? and Role=?", dbCON)
            dbCMD.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = txtUserName.Text
            dbCMD.Parameters.AddWithValue("@3", OleDbType.VarChar).Value = txtPass.Text
            dbCMD.Parameters.AddWithValue("@5", OleDbType.VarChar).Value = cboRole.Text

            Dim result As Integer = Convert.ToInt32(dbCMD.ExecuteScalar())
            If result = 0 Then
                MsgBox("Invalid Username or Password.")
                Me.Show()
            ElseIf cboRole.Text = "ADMIN" Then
                Administrator.Show()
                Me.Hide()
            ElseIf cboRole.Text = "CASHIER" Then
                Cashier.Show()
                Me.Hide()
            Else
                MsgBox("Please Select Role", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Invalid Log In")
            End If

            txtUserName.Clear()
            txtPass.Clear()
            cboRole.Text = Nothing
        End If
    End Sub

    Private Sub lblSignUp_Click(sender As Object, e As EventArgs) Handles lblSignUp.Click
        SignUp.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to terminate the application?",
        "Terminate Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
