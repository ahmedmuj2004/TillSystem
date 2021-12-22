Public Class PaymentForm

    Public TotalAmount As Double

    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTotal.Text = TotalAmount
    End Sub

    Private Sub BtnPay0_Click(sender As Object, e As EventArgs) Handles BtnPay0.Click
        AddItem(0)
    End Sub

    Private Sub BtnPay1_Click(sender As Object, e As EventArgs) Handles BtnPay1.Click
        AddItem(1)

    End Sub

    Private Sub BtnPay2_Click(sender As Object, e As EventArgs) Handles BtnPay2.Click
        AddItem(2)

    End Sub
    Private Sub AddItem(price As String)
        TxtGivenAmount.Text = TxtGivenAmount.Text & price

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TxtGivenAmount.Text = ""
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        Me.Close()
    End Sub

    Private Sub BtnPay3_Click(sender As Object, e As EventArgs) Handles BtnPay3.Click
        AddItem(3)
    End Sub

    Private Sub BtnPay4_Click(sender As Object, e As EventArgs) Handles BtnPay4.Click
        AddItem(4)
    End Sub

    Private Sub BtnPay5_Click(sender As Object, e As EventArgs) Handles BtnPay5.Click
        AddItem(5)
    End Sub

    Private Sub BtnPay6_Click(sender As Object, e As EventArgs) Handles BtnPay6.Click
        AddItem(6)
    End Sub

    Private Sub BtnPay7_Click(sender As Object, e As EventArgs) Handles BtnPay7.Click
        AddItem(7)
    End Sub

    Private Sub BtnPay8_Click(sender As Object, e As EventArgs) Handles BtnPay8.Click
        AddItem(8)
    End Sub

    Private Sub BtnPay9_Click(sender As Object, e As EventArgs) Handles BtnPay9.Click
        AddItem(9)
    End Sub

    Private Sub BtnPayPoint_Click(sender As Object, e As EventArgs) Handles BtnPayPoint.Click
        AddItem(".")
    End Sub
End Class