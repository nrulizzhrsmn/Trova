Public Class ChooseDriver

    'the information of related driver will be access from the public class car selected
    Private Sub btnSaga_Click(sender As Object, e As EventArgs) Handles btnVeronica.Click
        CarSelected.choosenCar = "Veronica"
        Total_Price.Show()
        Me.Hide()

    End Sub

    Private Sub btnWira_Click(sender As Object, e As EventArgs) Handles btnGan.Click
        CarSelected.choosenCar = "Gan"
        Total_Price.Show()
        Me.Hide()
    End Sub

    Private Sub btnCivic_Click(sender As Object, e As EventArgs) Handles btnSofea.Click
        CarSelected.choosenCar = "Sofea"
        Total_Price.Show()
        Me.Hide()
    End Sub

    Private Sub btnMyvi_Click(sender As Object, e As EventArgs) Handles btnNg.Click
        CarSelected.choosenCar = "Ng"
        Total_Price.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")

    End Sub

    Private Sub pcbBooking_Click(sender As Object, e As EventArgs) Handles pcbBooking.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")

    End Sub

    Private Sub pcbPlaces_Click(sender As Object, e As EventArgs) Handles pcbPlaces.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")
    End Sub

    Private Sub pcbTopUp_Click(sender As Object, e As EventArgs) Handles pcbTopUp.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")
    End Sub

    Private Sub pcbSettings_Click(sender As Object, e As EventArgs) Handles pcbSettings.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")
    End Sub

    Private Sub pcbPrevious_Click(sender As Object, e As EventArgs) Handles pcbPrevious.Click
        Preference.Show()
        Me.Close()

    End Sub
End Class