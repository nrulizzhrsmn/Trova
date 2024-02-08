Public Class N9
    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        Total_cost.state_travel = "NEGERI SEMBILAN"
        Total_cost.city_travel = "SEREMBAN"
        Total_cost.poscode_travel = "70200"
        Total_cost.place_travel = "NEGERI SEMBILAN MINANGKABAU STATE MUSEUM"
        CurrentLocation.Show()
        Me.Hide()
    End Sub



    Private Sub pcbBook_Click(sender As Object, e As EventArgs) Handles pcbBook.Click
        Total_cost.state_travel = "NEGERI SEMBILAN"
        Total_cost.city_travel = "SEREMBAN"
        Total_cost.poscode_travel = "70200"
        Total_cost.place_travel = "NEGERI SEMBILAN MINANGKABAU STATE MUSEUM"
        CurrentLocation.Show()
        Me.Hide()
    End Sub

    Private Sub pcbPrevious_Click(sender As Object, e As EventArgs) Handles pcbPrevious.Click
        choosePlaces.Show()
        Me.Hide()
    End Sub

    Private Sub pcbHome_Click(sender As Object, e As EventArgs) Handles pcbHome.Click
        Dim confirmation As String
        confirmation = MsgBox("You are in the middle of booking session. Do you want to leave this page?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "EXIT CONFIRMATION")
        If confirmation = MsgBoxResult.Yes Then
            main_page_user.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub pcbProfile_Click(sender As Object, e As EventArgs) Handles pcbProfile.Click
        Dim confirmation As String
        confirmation = MsgBox("You are in the middle of booking session. Do you want to leave this page?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "EXIT CONFIRMATION")
        If confirmation = MsgBoxResult.Yes Then
            UserProfile.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub pcbSettings_Click(sender As Object, e As EventArgs) Handles pcbSettings.Click
        Dim confirmation As String
        confirmation = MsgBox("You are in the middle of booking session. Do you want to leave this page?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "EXIT CONFIRMATION")
        If confirmation = MsgBoxResult.Yes Then
            ReportPage.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub pcbBooking_Click(sender As Object, e As EventArgs) Handles pcbBooking.Click
        Dim confirmation As String
        confirmation = MsgBox("You are in the middle of booking session. Do you want to leave this page?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "EXIT CONFIRMATION")
        If confirmation = MsgBoxResult.Yes Then
            rentCarDetails.Show()
            Me.Hide()
        End If
    End Sub
End Class