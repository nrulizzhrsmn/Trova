Public Class main_page_user

    Private Sub pcbPlacesIcon_Click(sender As Object, e As EventArgs) Handles pcbPlacesIcon.Click
        booking.Show()
        Me.Close()
    End Sub

    Private Sub btnInterestingPlaces_Click(sender As Object, e As EventArgs) Handles btnDriver.Click
        booking.Show()
        Me.Close()
    End Sub

    Private Sub pcbPlaces_Click(sender As Object, e As EventArgs) Handles pcbDriver.Click
        booking.Show()
        Me.Close()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        'exit confimation
        Dim result As String
        result = MsgBox("are you sure to log out?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "EXIT CONFIRMATION")
        If result = MsgBoxResult.Yes Then
            MsgBox("Thank you for using our application", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "THANK YOU")
            mainPage.Show()
            Me.Close()
        End If

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

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        rentCarDetails.Show()
        Me.Hide()
    End Sub

    Private Sub pcbBooking_Click(sender As Object, e As EventArgs) Handles pcbBooking.Click
        rentCarDetails.Show()
        Me.Hide()

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pcbBook.Click
        rentCarDetails.Show()
        Me.Hide()
    End Sub


    Private Sub main_page_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTrovaPay.Text = "You have RM" & trovaPayPayment.amount & " in TrovaPay"
    End Sub


    Private Sub btnTopUp_Click(sender As Object, e As EventArgs) Handles btnTopUp.Click
        ' to call the public class to execute the program
        Call trovaPayPayment.trovPayIcon()
        Me.Show()
        lblTrovaPay.Text = "You have RM" & trovaPayPayment.amount & " in TrovaPay"
    End Sub

    Private Sub pcbTopUp_Click(sender As Object, e As EventArgs) Handles pcbTopUp.Click

        Call trovaPayPayment.trovPayIcon()
        Me.Show()
        lblTrovaPay.Text = "You have RM" & trovaPayPayment.amount & " in TrovaPay"

    End Sub

    Private Sub pcbTopUpIcon_Click(sender As Object, e As EventArgs) Handles pcbTopUpIcon.Click
        Call trovaPayPayment.trovPayIcon()
        Me.Show()
        lblTrovaPay.Text = "You have RM" & trovaPayPayment.amount & " in TrovaPay"
    End Sub

    Private Sub main_page_user_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        lblTrovaPay.Text = "You have RM" & trovaPayPayment.amount & " in TrovaPay"
    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        ReportPage.Show()
        Me.Hide()

    End Sub
    Private Sub pcbSetting_Click(sender As Object, e As EventArgs) Handles pcbReport.Click
        ReportPage.Show()
        Me.Hide()

    End Sub
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        UserProfile.Show()
        Me.Hide()

    End Sub

    Private Sub pcbProfile_Click(sender As Object, e As EventArgs) Handles pcbProfile.Click
        UserProfile.Show()
        Me.Hide()
    End Sub

    Private Sub pcbProfileIcon_Click(sender As Object, e As EventArgs) Handles pcbProfileIcon.Click
        UserProfile.Show()
        Me.Hide()


    End Sub

    Private Sub pcbSettings_Click(sender As Object, e As EventArgs) Handles pcbReports.Click
        ReportPage.Show()
        Me.Hide()
    End Sub



End Class