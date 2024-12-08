Imports System.Reflection.Emit

Public Class Administrator


    Private Sub Administrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call panel()
        If LoggedInUserRole = "ADMIN" Then
            pbUsers.Enabled = True
            pbCashier.Enabled = True
            pbStocks.Enabled = True
            lblUsers.Enabled = True
            lblCashier.Enabled = True
            lblStocks.Enabled = True
        ElseIf LoggedInUserRole = "CASHIER" Then
            pbUsers.Enabled = False
            pbCashier.Enabled = True
            pbStocks.Enabled = False
            lblUsers.Enabled = False
            lblCashier.Enabled = True
            lblStocks.Enabled = False
        End If
    End Sub
    Sub panel()
        Panel1.Width = 200
        gpbToggle.Width = 190
        Label1.Visible = True
        Label2.Visible = True

        pbToggleFull.Visible = False
        pbTogglePic.Visible = True
    End Sub
    Private Sub pbToggleFull_Click(sender As Object, e As EventArgs) Handles pbToggleFull.Click
        Call panel()
        pbToggleFull.Visible = False
        pbTogglePic.Visible = True
    End Sub

    Private Sub pbTogglePic_Click(sender As Object, e As EventArgs) Handles pbTogglePic.Click
        Panel1.Width = 60
        gpbToggle.Width = 50
        Toggle = True
        Label1.Visible = False
        Label2.Visible = False

        pbTogglePic.Visible = False
        pbToggleFull.Visible = True

    End Sub

    Private Sub pbLogOut_Click(sender As Object, e As EventArgs) Handles pbLogOut.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Log Out?",
       "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
            LogIn.Show()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to terminate the application?",
        "Terminate Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub lblUsers_Click_1(sender As Object, e As EventArgs) Handles lblUsers.Click
        If LoggedInUserRole = "ADMIN" Then
            MessageBox.Show("Access Denied: This feature is available only to admins.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.Close()
            Users.Show()
        End If
    End Sub

    Private Sub pbUsers_Click(sender As Object, e As EventArgs) Handles pbUsers.Click
        If LoggedInUserRole = "ADMIN" Then
            MessageBox.Show("Access Denied: This feature is available only to admins.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.Close()
            Users.Show()
        End If
    End Sub

    Private Sub lblStocks_Click(sender As Object, e As EventArgs) Handles lblStocks.Click
        If LoggedInUserRole = "ADMIN" Then
            MessageBox.Show("Access Denied: This feature is available only to admins.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.Close()
            Stocks.Show()
        End If
    End Sub

    Private Sub pbStocks_Click(sender As Object, e As EventArgs) Handles pbStocks.Click
        If LoggedInUserRole = "ADMIN" Then
            MessageBox.Show("Access Denied: This feature is available only to admins.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.Close()
            Stocks.Show()
        End If
    End Sub

    Private Sub lblCashier_Click_1(sender As Object, e As EventArgs) Handles lblCashier.Click
        Cashier.Show()
        Me.Close()
    End Sub

    Private Sub pbCashier_Click_1(sender As Object, e As EventArgs) Handles pbCashier.Click
        Cashier.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub
End Class