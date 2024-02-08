Imports OMC2.Total_cost
Imports OMC2.UserDetails
Public Class check_booking

    Private Sub check_booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'it will show the information of the user and whether to accept or not
        lblName_User.Text = UserDetails.UserName
        lblLocation_User.Text = place_current & "--->" & place_travel
        lblPhone_Number.Text = UserDetails.UserPhoneNum


    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub btnSaga_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        driverDone.Show()
        Me.Close()

    End Sub


    Private Sub pcbPlacesIcon_Click(sender As Object, e As EventArgs) Handles pcbPlacesIcon.Click
        History.Show()
        Me.Hide()

    End Sub

    Private Sub pcbProfileIcon_Click(sender As Object, e As EventArgs) Handles pcbProfileIcon.Click
        driverProfile.Show()
        Me.Hide()

    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        main_Page_Driver.Show()
        Me.Hide()

    End Sub

End Class