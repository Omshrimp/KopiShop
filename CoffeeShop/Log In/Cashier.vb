Public Class Cashier
    Dim Total, Amount As Integer

    Private Sub rbDineIn_CheckedChanged(sender As Object, e As EventArgs) Handles rbDineIn.CheckedChanged
        lblOption.Text = rbDineIn.Text

    End Sub

    Private Sub rbTakeOut_CheckedChanged(sender As Object, e As EventArgs) Handles rbTakeOut.CheckedChanged
        lblOption.Text = rbTakeOut.Text
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        CashierCheckout.Show()
        Me.Close()
    End Sub

    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel the order?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then


        End If
    End Sub

    Private Sub btnCoffee_Click(sender As Object, e As EventArgs) Handles btnCoffee.Click
        pnlOnBtnPosition.Height = btnCoffee.Height
        pnlOnBtnPosition.Top = btnCoffee.Top
        pnlCoffee.Visible = True
        pnlTea.Visible = False
        pnlMIlk.Visible = False
        pnlChocolate.Visible = False

    End Sub

    Private Sub btnTea_Click(sender As Object, e As EventArgs) Handles btnTea.Click
        pnlOnBtnPosition.Height = btnTea.Height
        pnlOnBtnPosition.Top = btnTea.Top
        pnlCoffee.Visible = False
        pnlTea.Visible = True
        pnlMIlk.Visible = False
        pnlChocolate.Visible = False
    End Sub

    Private Sub btnMilk_Click(sender As Object, e As EventArgs) Handles btnMilk.Click
        pnlOnBtnPosition.Height = btnMilk.Height
        pnlOnBtnPosition.Top = btnMilk.Top
        pnlCoffee.Visible = False
        pnlTea.Visible = False
        pnlMIlk.Visible = True
        pnlChocolate.Visible = False
    End Sub

    Private Sub btnChoco_Click(sender As Object, e As EventArgs) Handles btnChoco.Click
        pnlOnBtnPosition.Height = btnChoco.Height
        pnlOnBtnPosition.Top = btnChoco.Top
        pnlCoffee.Visible = False
        pnlTea.Visible = False
        pnlMIlk.Visible = False
        pnlChocolate.Visible = True
    End Sub

    Private Sub btnSubEspresso_Click(sender As Object, e As EventArgs) Handles btnSubEspresso.Click
        txtEspressoQty.Text -= 1
        If txtEspressoQty.Text <= 0 Then
            txtEspressoQty.Text = 0
        End If
    End Sub

    Private Sub btnSubAmericano_Click(sender As Object, e As EventArgs) Handles btnSubAmericano.Click
        txtAmericanoQty.Text -= 1
        If txtAmericanoQty.Text <= 0 Then
            txtAmericanoQty.Text = 0
        End If
    End Sub

    Private Sub btnSubCappuccino_Click(sender As Object, e As EventArgs) Handles btnSubCappuccino.Click
        txtCappuccinoQty.Text -= 1
        If txtCappuccinoQty.Text <= 0 Then
            txtCappuccinoQty.Text = 0
        End If
    End Sub

    Private Sub btnSubIcedCoffee_Click(sender As Object, e As EventArgs) Handles btnSubIcedCoffee.Click
        txtIcedCoffeeQty.Text -= 1
        If txtIcedCoffeeQty.Text <= 0 Then
            txtIcedCoffeeQty.Text = 0
        End If
    End Sub

    Private Sub btnAddEspresso_Click(sender As Object, e As EventArgs) Handles btnAddEspresso.Click
        txtEspressoQty.Text += 1
    End Sub

    Private Sub btnAddAmericano_Click(sender As Object, e As EventArgs) Handles btnAddAmericano.Click
        txtAmericanoQty.Text += 1
    End Sub

    Private Sub btnAddCappuccino_Click(sender As Object, e As EventArgs) Handles btnAddCappuccino.Click
        txtCappuccinoQty.Text += 1
    End Sub

    Private Sub btnAddIcedCoffee_Click(sender As Object, e As EventArgs) Handles btnAddIcedCoffee.Click
        txtIcedCoffeeQty.Text += 1
    End Sub

    Private Sub btnEspre_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Administrator.Show()
    End Sub
End Class