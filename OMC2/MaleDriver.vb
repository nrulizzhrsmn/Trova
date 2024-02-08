Public Class MaleDriver
    'to access the information from public class
    Private Sub btnFeliq_Click(sender As Object, e As EventArgs) Handles btnFeliq.Click
        CarSelected.choosenCar = "Feliq"
        Total_Price.Show()
        Me.Hide()

    End Sub

    Private Sub btnAsyraff_Click(sender As Object, e As EventArgs) Handles btnAsyraff.Click
        CarSelected.choosenCar = "Asyraff"
        Total_Price.Show()
        Me.Hide()

    End Sub

    Private Sub btnWan_Click(sender As Object, e As EventArgs) Handles btnWan.Click
        CarSelected.choosenCar = "Wan"
        Total_Price.Show()
        Me.Hide()

    End Sub

    Private Sub btnJoseph_Click(sender As Object, e As EventArgs) Handles btnJoseph.Click
        CarSelected.choosenCar = "Joseph"
        Total_Price.Show()
        Me.Hide()

    End Sub

    Private Sub btnJazz_Click(sender As Object, e As EventArgs) Handles btnAlvin.Click
        CarSelected.choosenCar = "Alvin"
        Total_Price.Show()
        Me.Hide()

    End Sub

    Private Sub pcbPrevious_Click(sender As Object, e As EventArgs) Handles pcbPrevious.Click
        Preference.Show()
        Me.Close()

    End Sub

    Private Sub pcbBooking_Click(sender As Object, e As EventArgs) Handles pcbBooking.Click
        MsgBox("PLEASE PROCEED THE PAYMENT", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        MsgBox("PLEASE PROCEED THE BOOKING PROCESS", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")
    End Sub

    Private Sub pcbTopUp_Click(sender As Object, e As EventArgs) Handles pcbTopUp.Click
        MsgBox("PLEASE PROCEED THE PAYMENT", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")
    End Sub

    Private Sub pcbProfile_Click(sender As Object, e As EventArgs) Handles pcbProfile.Click
        MsgBox("PLEASE PROCEED THE PAYMENT", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")
    End Sub

    Private Sub pcbSettings_Click(sender As Object, e As EventArgs) Handles pcbSettings.Click
        MsgBox("PLEASE PROCEED THE PAYMENT", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")
    End Sub
End Class
