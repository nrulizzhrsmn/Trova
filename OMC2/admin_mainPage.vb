Public Class admin_mainPage


    Private Sub btnUserProfile_Click(sender As Object, e As EventArgs) Handles btnUserProfile.Click
        admin_user.Show()
        Me.Hide()

    End Sub

    Private Sub pcbUser_Click(sender As Object, e As EventArgs) Handles pcbUser.Click
        admin_user.Show()
        Me.Hide()
    End Sub

    Private Sub pcbBook_Click(sender As Object, e As EventArgs) Handles pcbBook.Click
        admin_UserLocation.Show()
        Me.Hide()
    End Sub

    Private Sub btnDriver_Click(sender As Object, e As EventArgs) Handles btnDriver.Click
        admin_UserLocation.Show()
        Me.Hide()
    End Sub

    Private Sub pcbCar_Click(sender As Object, e As EventArgs) Handles pcbCar.Click
        admin_Car.Show()
        Me.Hide()
    End Sub

    Private Sub btnCarRent_Click(sender As Object, e As EventArgs) Handles btnCarRent.Click
        admin_Car.Show()
        Me.Hide()
    End Sub

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        admin_DriverRegistration.Show()
        Me.Hide()

    End Sub

    Private Sub pcbBooking_Click(sender As Object, e As EventArgs) Handles pcbBooking.Click
        admin_DriverRegistration.Show()
        Me.Hide()
    End Sub

    Private Sub btnTrovaPay_Click(sender As Object, e As EventArgs) Handles btnTrovaPay.Click
        admin_TrovaPay.Show()
        Me.Hide()

    End Sub

    Private Sub pcbTrovaPay_Click(sender As Object, e As EventArgs) Handles pcbTrovaPay.Click
        admin_TrovaPay.Show()
        Me.Hide()

    End Sub

    Private Sub btnCarRegistration_Click(sender As Object, e As EventArgs) Handles btnCarRegistration.Click
        admin_CarRegitration.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        admin_CarRegitration.Show()
        Me.Hide()

    End Sub

    Private Sub pcbLogOut_Click(sender As Object, e As EventArgs) Handles pcbLogOut.Click
        Dim result As String
        result = MsgBox("are you sure to log out?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "EXIT CONFIRMATION")
        If result = MsgBoxResult.Yes Then
            MsgBox("Thank you for using our application", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "THANK YOU")

            mainPage.Show()
            Me.Close()
        End If

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim result As String
        result = MsgBox("are you sure to log out?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "EXIT CONFIRMATION")
        If result = MsgBoxResult.Yes Then
            MsgBox("Thank you for using our application", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "THANK YOU")

            mainPage.Show()
            Me.Close()
        End If

    End Sub

    Private Sub pcbReport_Click(sender As Object, e As EventArgs) Handles pcbReport.Click
        adminReport.Show()
        Me.Hide()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        adminReport.Show()
        Me.Hide()
    End Sub
End Class