Imports System.Reflection.Emit

Public Class Administrator
    Dim Toggle As Boolean
    Private Sub lblUsers_Click(sender As Object, e As EventArgs) Handles lblUsers.Click
        Users.Show()
        Me.Close()
    End Sub
    Private Sub pbUsers_Click(sender As Object, e As EventArgs) Handles pbUsers.Click
        Users.Show()
        Me.Close()
    End Sub

    Private Sub lblStocks_Click(sender As Object, e As EventArgs) Handles lblStocks.Click
        Stocks.Show()
        Me.Close()
    End Sub
    Private Sub pbStocks_Click(sender As Object, e As EventArgs) Handles pbStocks.Click
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

    Private Sub lblReports_Click(sender As Object, e As EventArgs) Handles lblReports.Click
        Reports.Show()
        Me.Close()
    End Sub

    Private Sub pbReports_Click(sender As Object, e As EventArgs) Handles pbReports.Click
        Reports.Show()
        Me.Close()
    End Sub

    Private Sub Administrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call panel()
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