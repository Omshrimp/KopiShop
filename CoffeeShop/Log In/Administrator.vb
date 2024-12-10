Imports System.Reflection.Emit

Public Class Administrator


    Private Sub Administrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call panel()
        If LoggedInUserRole = "ADMIN" Then
            pbUsers.Enabled = True
            pbCashier.Enabled = True
            pbProducts.Enabled = True
            lblUsers.Enabled = True
            lblCashier.Enabled = True
            lblProducts.Enabled = True
        ElseIf LoggedInUserRole = "CASHIER" Then
            pbUsers.Enabled = False
            pbCashier.Enabled = True
            pbProducts.Enabled = False
            lblUsers.Enabled = False
            lblCashier.Enabled = True
            lblProducts.Enabled = False
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

    Private Sub lblProducts_Click(sender As Object, e As EventArgs) Handles lblProducts.Click
        If LoggedInUserRole = "ADMIN" Then
            MessageBox.Show("Access Denied: This feature is available only to admins.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.Close()
            frmCoffeeManageEntry.Show()
        End If
    End Sub

    Private Sub pbProducts_Click(sender As Object, e As EventArgs) Handles pbProducts.Click
        If LoggedInUserRole = "ADMIN" Then
            MessageBox.Show("Access Denied: This feature is available only to admins.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.Close()
            frmCoffeeManageEntry.Show()
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

    Private Sub pbTerminate_Click_1(sender As Object, e As EventArgs) Handles pbTerminate.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to terminate the application?",
      "Terminate Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class