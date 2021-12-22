Public Class Form1
    Private Sub BtnPepperoniPizza_Click(sender As Object, e As EventArgs) Handles BtnPepperoniPizza.Click
        AddItem("PepperoniPizza", 1, 3)
    End Sub

    Private Sub BtnVeggiePizza_Click(sender As Object, e As EventArgs) Handles BtnVeggiePizza.Click
        AddItem("VeggiePizza", 1, 3)
    End Sub

    Private Sub BtnChickenBurger_Click(sender As Object, e As EventArgs) Handles BtnChickenBurger.Click
        AddItem("Chicken Burger", 1, 3)
    End Sub

    Private Sub BtnBeefBurger_Click(sender As Object, e As EventArgs) Handles BtnBeefBurger.Click
        AddItem("Beef Burger", 1, 3)
    End Sub

    Private Sub BtnChickenWrap_Click(sender As Object, e As EventArgs) Handles BtnChickenWrap.Click
        AddItem("Chicken Wrap", 1, 3)
    End Sub

    Private Sub BtnVeggieWrap_Click(sender As Object, e As EventArgs) Handles BtnVeggieWrap.Click
        AddItem("Veggie Wrap", 1, 3)
    End Sub

    Private Sub BtnPepsi_Click(sender As Object, e As EventArgs) Handles BtnPepsi.Click
        AddItem("Pepsi", 1, 3)
    End Sub

    Private Sub BtnFanta_Click(sender As Object, e As EventArgs) Handles BtnFanta.Click
        AddItem("Fanta", 1, 3)
    End Sub

    Private Sub BtnChai_Click(sender As Object, e As EventArgs) Handles BtnChai.Click
        AddItem("Chai", 1, 3)
    End Sub

    Private Sub BtnCoffee_Click(sender As Object, e As EventArgs) Handles BtnCoffee.Click
        AddItem("Coffee", 1, 3)
    End Sub

    Private Sub BtnWater_Click(sender As Object, e As EventArgs) Handles BtnWater.Click
        AddItem("Water", 1, 3)
    End Sub

    Private Sub BtnJuice_Click(sender As Object, e As EventArgs) Handles BtnJuice.Click
        AddItem("Juice", 1, 3)
    End Sub

    Private Sub BtnLavaCake_Click(sender As Object, e As EventArgs) Handles BtnLavaCake.Click
        AddItem("Lava Cake", 1, 3)
    End Sub

    Private Sub BtnButterCake_Click(sender As Object, e As EventArgs) Handles BtnButterCake.Click
        AddItem("Butter Cake", 1, 3)
    End Sub

    Private Sub BtnChoclateIcecream_Click(sender As Object, e As EventArgs) Handles BtnChoclateIcecream.Click
        AddItem("Choclate Icecream", 1, 3)

    End Sub

    Private Sub BtnVanillaIcecream_Click(sender As Object, e As EventArgs) Handles BtnVanillaIcecream.Click
        AddItem("VanillaIcecream", 1, 3)

    End Sub

    Private Sub BtnMangoCustard_Click(sender As Object, e As EventArgs) Handles BtnMangoCustard.Click
        AddItem("MangoCustard", 1, 3)

    End Sub

    Private Sub BtnMixfruitCustard_Click(sender As Object, e As EventArgs) Handles BtnMixfruitCustard.Click
        AddItem("MixFruit Custard", 1, 3)
    End Sub

    Private Sub AddItem(name As String, quantity As Integer, price As Double)
        DataGridView1.Rows.Add(name, quantity, price)
        UpdateTotal()
    End Sub

    Private Sub UpdateTotal()
        Dim Total = 0
        For Each aItem In DataGridView1.Rows
            Dim quantity = Convert.ToInt32(DataGridView1.Rows(aItem.Index).Cells(1).Value)
            Dim price = Convert.ToInt32(DataGridView1.Rows(aItem.Index).Cells(2).Value)
            Total = Total + (quantity * price)
        Next
        txtTotal.Text = Total
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            For Each aItem In DataGridView1.SelectedRows
                DataGridView1.Rows.RemoveAt(aItem.Index)
            Next
        End If
        UpdateTotal()

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Dim response As Integer

        response = MsgBox("Are you sure you wish to cancel the order?", vbQuestion + vbYesNo + vbDefaultButton2, "Confirm Cancel")

        If (response = vbYes) Then
            DataGridView1.Rows.Clear()
            txtTotal.Text = 0
        Else

        End If


    End Sub

    Private Sub BtnPay_Click(sender As Object, e As EventArgs) Handles BtnPay.Click
        Dim aform As PaymentForm = New PaymentForm()
        aform.TotalAmount = txtTotal.Text
        aform.ShowDialog()
    End Sub
End Class