Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Runtime.Remoting.Lifetime
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class LogIn
    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call database_connection()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If txtUserName.Text = "" And txtPass.Text = "" And cboRole.Text = "" Then
            MsgBox("All Fields are Required!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Log In")
        ElseIf txtUserName.Text = "" Then
            MsgBox("Please Enter Username", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Invalid Log In")
        ElseIf txtPass.Text = "" Then
            MsgBox("Please Enter Password", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Invalid Log In")
        ElseIf cboRole.Text = "" Then
            MsgBox("Please Select Role", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Invalid Log In")
        Else
            ' Corrected SQL command with positional parameters
            dbCMD = New OleDbCommand("select * from tblAccounts where Username=? and Password=? and Role=?", dbCON)

            ' Add parameters in the correct order (Username, Password, Role)
            dbCMD.Parameters.AddWithValue("?", txtUserName.Text)
            dbCMD.Parameters.AddWithValue("?", txtPass.Text)
            dbCMD.Parameters.AddWithValue("?", cboRole.Text)

            Dim result As Object = dbCMD.ExecuteScalar()

            ' Check if a result is returned
            If result IsNot Nothing AndAlso Convert.ToInt32(result) > 0 Then
                If cboRole.Text = "ADMIN" Then
                    Administrator.Show()
                    Me.Hide()
                ElseIf cboRole.Text = "CASHIER" Then
                    Cashier.Show()
                    Me.Hide()
                End If
            Else
                MsgBox("Invalid Username or Password.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Invalid Log In")
            End If

            ' Clear the input fields after login attempt

        End If

        ' Close connection after operation
        dbCON.Close()
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
