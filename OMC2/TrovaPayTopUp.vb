Public Class TrovaPayTopUp
    Private Sub btnOther_Click(sender As Object, e As EventArgs) Handles btnOther.Click
        Dim topUpMoney As Double
        topUpMoney = InputBox("enter the amount of money", "TROVA PAYMENT METHOD")
        MsgBox("are you sure to top up your Trova Pay?", MsgBoxStyle.Information, "TOP-UP CONFIRMATION")
        If MsgBoxResult.Yes Then
            trovaPayPayment.value = topUpMoney 'to append the value to ensure the value is updated on the user main page
            Call trovaPayPayment.topUp(topUpMoney) 'using public sub top up in trovapaypayment public class to do the calculation
        End If
        top_up_confirmation.Show()
            Me.Hide()



    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click

        MsgBox("are you sure to top up your Trova Pay?", MsgBoxStyle.Information, "TOP-UP CONFIRMATION")
        If MsgBoxResult.Yes Then
            trovaPayPayment.value = 10
            Call trovaPayPayment.topUp(10)
        End If
        top_up_confirmation.Show()
            Me.Hide()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button20.Click

        MsgBox("are you sure to top up your Trova Pay?", MsgBoxStyle.Information, "TOP-UP CONFIRMATION")
        If MsgBoxResult.Yes Then
            trovaPayPayment.value = 20
            Call trovaPayPayment.topUp(20)
        End If
        top_up_confirmation.Show()
            Me.Hide()

    End Sub

    Private Sub btn500_Click(sender As Object, e As EventArgs) Handles btn500.Click

        MsgBox("are you sure to top up your Trova Pay?", MsgBoxStyle.Information, "TOP-UP CONFIRMATION")
        If MsgBoxResult.Yes Then
            trovaPayPayment.value = 500
            Call trovaPayPayment.topUp(500)
        End If
        top_up_confirmation.Show()
            Me.Hide()

    End Sub

    Private Sub btn50_Click(sender As Object, e As EventArgs) Handles btn50.Click

        MsgBox("are you sure to top up your Trova Pay?", MsgBoxStyle.Information, "TOP-UP CONFIRMATION")
        If MsgBoxResult.Yes Then
            trovaPayPayment.value = 50
            Call trovaPayPayment.topUp(50)
        End If
        top_up_confirmation.Show()
            Me.Hide()

    End Sub

    Private Sub btn100_Click(sender As Object, e As EventArgs) Handles btn100.Click
        MsgBox("are you sure to top up your Trova Pay?", MsgBoxStyle.Information, "TOP-UP CONFIRMATION")
        If MsgBoxResult.Yes Then
            trovaPayPayment.value = 100
            Call trovaPayPayment.topUp(100)
        End If
        top_up_confirmation.Show()
            Me.Hide()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MsgBox("PLEASE PROCEED THE PAYMENT", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")

    End Sub

    Private Sub pcbBooking_Click(sender As Object, e As EventArgs) Handles pcbBooking.Click
        MsgBox("PLEASE PROCEED THE PAYMENT", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")

    End Sub

    Private Sub pcbPlaces_Click(sender As Object, e As EventArgs) Handles pcbPlaces.Click
        MsgBox("PLEASE PROCEED THE PAYMENT", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")
    End Sub

    Private Sub pcbTopUp_Click(sender As Object, e As EventArgs) Handles pcbTopUp.Click
        MsgBox("PLEASE PROCEED THE PAYMENT", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")
    End Sub

    Private Sub pcbSettings_Click(sender As Object, e As EventArgs) Handles pcbSettings.Click
        MsgBox("PLEASE PROCEED THE PAYMENT", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")
    End Sub
End Class