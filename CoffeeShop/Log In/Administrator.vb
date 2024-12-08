Imports System.Reflection.Emit

Public Class Administrator
    Dim Toggle As Boolean

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
    Sub lblUsers_Click(sender As Object, e As EventArgs) Handles lblUsers.Click
        If LoggedInUserRole <> "Admin" Then
            MessageBox.Show("Access Denied: This feature is available only to admins.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Users.Show()
        Me.Close()
    End Sub
    Private Sub pbUsers_Click(sender As Object, e As EventArgs) Handles pbUsers.Click
        If LoggedInUserRole <> "Admin" Then
            MessageBox.Show("Access Denied: This feature is available only to admins.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Users.Show()
        Me.Close()
    End Sub

    Private Sub lblStocks_Click(sender As Object, e As EventArgs) Handles lblStocks.Click
        If LoggedInUserRole <> "Admin" Then
            MessageBox.Show("Access Denied: This feature is available only to admins.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Stocks.Show()
        Me.Close()
    End Sub
    Private Sub pbStocks_Click(sender As Object, e As EventArgs) Handles pbStocks.Click
        If LoggedInUserRole <> "Admin" Then
            MessageBox.Show("Access Denied: This feature is available only to admins.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Stocks.Show()
        Me.Close()
    End Sub

    Private Sub lblCashier_Click(sender As Object, e As EventArgs) Handles lblCashier.Click
        Cashier.Show()
        Me.Close()
    End Sub

    Private Sub pbCashier_Click(sender As Object, e As EventArgs) Handles pbCashier.Click
        Cashier.Show()
        Me.Close()
    End Sub

    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        Call panel_toggle()
    End Sub
    Sub panel_toggle()
        If Toggle Then
            Panel1.Width = 200
            gpbToggle.Width = 190
            Toggle = False
            Label1.Visible = True
            Label2.Visible = True
        Else
            Panel1.Width = 60
            gpbToggle.Width = 50
            Toggle = True
            Label1.Visible = False
            Label2.Visible = False
        End If
    End Sub
    Sub panel()
        Panel1.Width = 200
        gpbToggle.Width = 190
        Label1.Visible = True
        Label2.Visible = True
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to terminate the application?",
        "Terminate Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class