Imports OMC2.Total_cost
Public Class TrovaPay

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim amountHave As Double = trovaPayPayment.amount
        Dim result As String
        Dim topUpChoice As String
        'to ensure that the trovapay have enough money to pay and if they do not have enough money they need to top up their trovapay or use other method
        If Total_cost.price_booking > amountHave Then
            topUpChoice = MsgBox("Your trovaPay does not have enough money. Do you want to top-up your trovaPay", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "NOT ENOUGH MONEY")
            If topUpChoice = MsgBoxResult.Yes Then
                trovaPayPayment.TrovaTopUpMiddle()
            Else
                payment.Show()
                Me.Close()
            End If

        Else
            Call trovaPayPayment.deduction(price_booking)
            result = MsgBox("RM" & price_booking & " will be deducted from your TrovaPay account", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "TRANSACTION CONFIRMATION")
            If result = MsgBoxResult.Ok Then
                TROVAPAYinterface.Show()
                Me.Close()
            End If
        End If

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "REVIEW")

    End Sub

    Private Sub pcbBooking_Click(sender As Object, e As EventArgs) Handles pcbBooking.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "REVIEW")

    End Sub

    Private Sub pcbPlaces_Click(sender As Object, e As EventArgs) Handles pcbPlaces.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "REVIEW")
    End Sub

    Private Sub pcbTopUp_Click(sender As Object, e As EventArgs) Handles pcbTopUp.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "REVIEW")
    End Sub

    Private Sub pcbSettings_Click(sender As Object, e As EventArgs) Handles pcbSettings.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "REVIEW")
    End Sub

    Private Sub TrovaPay_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        lblAmount.Text = Format(price_booking, "Currency")
        lblFrom_Account.Text = from_username
        lblTo_Account.Text = "Trova Enterprise - 7877675241"
    End Sub

    Private Sub TrovaPay_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        lblAmount.Text = ""
        lblFrom_Account.Text = ""
        lblTo_Account.Text = ""
    End Sub
End Class