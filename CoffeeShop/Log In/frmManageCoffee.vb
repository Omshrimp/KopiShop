Imports System.Data.OleDb
Imports System.IO

Public Class frmManageCoffee
    Dim dr As OleDbDataReader
    Dim dbADAP As New OleDb.OleDbDataAdapter
    Dim dbDS As DataSet
    Private Sub frmManageCoffee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Adding columns to DataGridView
        DataGridView1.Columns.Add("Column1", "Order No")
        DataGridView1.Columns.Add("Column2", "Coffee Code")
        DataGridView1.Columns.Add("Column3", "Coffee Name")
        DataGridView1.Columns.Add("Column4", "Price")
        DataGridView1.Columns.Add("Column5", "Quantity")

        ' Load Data into DataGridView
        DGV_load()
    End Sub

    Sub DGV_load()
        ' Clear any existing rows to ensure fresh load
        DataGridView1.Rows.Clear()

        Try
            ' Open connection
            dbCON.Open()

            ' Execute query to load coffee data
            Dim cmd As New OleDb.OleDbCommand("SELECT * FROM coffeeMaster", dbCON)
            dr = cmd.ExecuteReader

            ' Loop through the data and add it to DataGridView
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("coffeecode"), dr.Item("coffeename"), dr.Item("size"), dr.Item("price"), CBool(dr.Item("status")), dr.Item("img"))
            End While
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            ' Close connection
            dbCON.Close()
        End Try
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        ' Open the manage coffee entry form
        frmCoffeeManageEntry.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Check if any row is selected and data is available\
        dbCON.Open()

        If DataGridView1.CurrentRow IsNot Nothing Then
            ' Check if the row has at le
            ' ast 6 columns with valid data
            If DataGridView1.CurrentRow.Cells.Count >= 6 Then
                ' Ensure that each cell has valid data before proceeding
                With frmCoffeeManageEntry
                    .txt_coffeeCode.Text = If(DataGridView1.CurrentRow.Cells(0).Value?.ToString(), String.Empty)
                    .txt_Coffeename.Text = If(DataGridView1.CurrentRow.Cells(1).Value?.ToString(), String.Empty)
                    .Combo_size.Text = If(DataGridView1.CurrentRow.Cells(2).Value?.ToString(), String.Empty)
                    .txt_price.Text = If(DataGridView1.CurrentRow.Cells(3).Value?.ToString(), String.Empty)
                    .Check_Status.Checked = CBool(If(DataGridView1.CurrentRow.Cells(4).Value, False))

                    ' Handle image loading safely
                    Dim bytes As Byte() = TryCast(DataGridView1.CurrentRow.Cells(5).Value, Byte())
                    If bytes IsNot Nothing Then
                        Dim ms As New MemoryStream(bytes)
                        .Pic_Coffeeimg.Image = Image.FromStream(ms)
                    Else
                        .Pic_Coffeeimg.Image = Nothing
                    End If

                    ' Disable the save button and make coffee code readonly
                    .Btn_Save.Enabled = False
                    .txt_coffeeCode.ReadOnly = True

                    ' Show the coffee entry form
                    .ShowDialog()
                End With
            Else
                ' If the row doesn't have enough data
                MsgBox("Selected row does not have enough data.", MsgBoxStyle.Exclamation, "Error")
            End If
        Else
            ' If no row is selected
            MsgBox("No row selected. Please select a valid row.", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

End Class