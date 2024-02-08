Public Class main_Page_Driver
    Private Sub main_Page_Driver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        driverStatus.present = "unavailable as a driver" 'to show the availability, if the driver log out the application it will automatically set as unavailable
        lblStatus.Text = "You are currently " & driverStatus.present & ". Change your availability by clicking the button status"
        btnBookChecking.Enabled = False
        pcbBookChecking.Enabled = False
    End Sub

    Private Sub main_Page_Driver_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        lblStatus.Text = "You are currently " & driverStatus.present & ". Change your availability by clicking the button status"
        If driverStatus.present = "unavailable as a driver " Then
            btnBookChecking.Enabled = False
        End If
        If driverStatus.present = "available as a driver " Then
            btnBookChecking.Enabled = True
        End If

    End Sub

    Private Sub btnStatus_Click(sender As Object, e As EventArgs) Handles btnStatus.Click
        status.Show()
        Me.Hide()

    End Sub

    Private Sub pcbStatus_Click(sender As Object, e As EventArgs) Handles pcbStatus.Click
        status.Show()
        Me.Hide()
    End Sub

    Private Sub pcbBookChecking_Click(sender As Object, e As EventArgs) Handles pcbBookChecking.Click
        check_booking.Show()
        Me.Hide()

    End Sub

    Private Sub btnBookChecking_Click(sender As Object, e As EventArgs) Handles btnBookChecking.Click
        check_booking.Show()
        Me.Hide()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        History.Show()
        Me.Hide()

    End Sub

    Private Sub pcbHistory_Click(sender As Object, e As EventArgs) Handles pcbHistory.Click
        History.Show()
        Me.Hide()
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

    Private Sub pcbLogOut_Click(sender As Object, e As EventArgs) Handles pcbLogOut.Click
        Dim result As String
        result = MsgBox("are you sure to log out?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "EXIT CONFIRMATION")
        If result = MsgBoxResult.Yes Then
            MsgBox("Thank you for using our application", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "THANK YOU")
            mainPage.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        driverProfile.Show()
        Me.Hide()

    End Sub

    Private Sub pcbProfile_Click(sender As Object, e As EventArgs) Handles pcbProfile.Click
        driverProfile.Show()
        Me.Hide()

    End Sub

    Private Sub pcbBook_Click(sender As Object, e As EventArgs) Handles pcbBook.Click
        status.Show()
        Me.Hide()

    End Sub

    Private Sub pcbPlacesIcon_Click(sender As Object, e As EventArgs) Handles pcbPlacesIcon.Click
        History.Show()
        Me.Hide()

    End Sub

    Private Sub pcbProfileIcon_Click(sender As Object, e As EventArgs) Handles pcbProfileIcon.Click
        driverProfile.Show()
        Me.Close()

    End Sub
End Class