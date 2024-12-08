Public Class Cashier

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
        MessageBox.Show("Are you sure you want to cancel the order?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click

    End Sub

    Private Sub btnEspre_Click(sender As Object, e As EventArgs) Handles btnEspre.Click

    End Sub

    Private Sub Cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Administrator.Show()
    End Sub
End Class