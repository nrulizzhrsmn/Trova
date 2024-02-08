Imports OMC2.Total_cost
Public Class COD_Cash
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        TROVAPAYinterface.Show()
        Me.Close()

    End Sub

    Private Sub lblAmount_Click(sender As Object, e As EventArgs) Handles lblAmount.Click

    End Sub

    Private Sub COD_Cash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'to show the payment details
        lblAmount.Text = Format(price_booking, "currency")
        lblFrom_Account.Text = phone_number_cod
        lblTo_Account.Text = "Trova Enterprise - 7877675241"
    End Sub


    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")

    End Sub

    Private Sub pcbBooking_Click(sender As Object, e As EventArgs) Handles pcbBooking.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")

    End Sub

    Private Sub pcbPlaces_Click(sender As Object, e As EventArgs) Handles pcbPlaces.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "REVIEW")
    End Sub

    Private Sub pcbTopUp_Click(sender As Object, e As EventArgs) Handles pcbTopUp.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")
    End Sub

    Private Sub pcbSettings_Click(sender As Object, e As EventArgs) Handles pcbSettings.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")
    End Sub

    Private Sub COD_Cash_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        lblAmount.Text = ""
        lblFrom_Account.Text = ""
        lblTo_Account.Text = ""
    End Sub
End Class