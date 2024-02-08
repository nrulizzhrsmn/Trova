Public Class registrationDriver
    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        FormRegister.Show()
        Me.Hide()

    End Sub

    Private Sub btnDriver_Click(sender As Object, e As EventArgs) Handles btnDriver.Click
        DriverRegistration.Show()
        Me.Hide()

    End Sub

    Private Sub pcbUser_Click(sender As Object, e As EventArgs) Handles pcbUser.Click
        FormRegister.Show()
        Me.Hide()
    End Sub

    Private Sub pcbDriver_Click(sender As Object, e As EventArgs) Handles pcbDriver.Click
        DriverRegistration.Show()
        Me.Hide()
    End Sub

    Private Sub pcbProfile_Click(sender As Object, e As EventArgs) Handles pcbProfile.Click
        MsgBox("PLEASE LOG IN FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub pcbPlaces_Click(sender As Object, e As EventArgs) Handles pcbPlaces.Click
        MsgBox("PLEASE LOG IN FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub pcbTopUp_Click(sender As Object, e As EventArgs) Handles pcbTopUp.Click
        MsgBox("PLEASE LOG IN FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub pcbBooking_Click(sender As Object, e As EventArgs) Handles pcbBooking.Click
        MsgBox("PLEASE LOG IN FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub pcbSettings_Click(sender As Object, e As EventArgs) Handles pcbSettings.Click
        MsgBox("PLEASE LOG IN FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub


    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        mainPage.Show()
        Me.Close()
    End Sub
End Class