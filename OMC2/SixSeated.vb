Public Class SixSeated
    ' to append the car name into choosencar variable in the car selected public class
    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnEstima.Click
        CarSelected.choosenCar = "Estima"
        carRentConfirmation.Show()
        Me.Hide()

    End Sub

    Private Sub btnNissanGL_Click(sender As Object, e As EventArgs) Handles btnNissanGL.Click
        CarSelected.choosenCar = "GrandLivina"
        carRentConfirmation.Show()
        Me.Hide()
    End Sub

    Private Sub btnAlphard_Click(sender As Object, e As EventArgs) Handles btnAlphard.Click
        CarSelected.choosenCar = "Alphard"
        carRentConfirmation.Show()
        Me.Hide()
    End Sub

    Private Sub btnAlza_Click(sender As Object, e As EventArgs) Handles btnAlza.Click
        CarSelected.choosenCar = "Alza"
        carRentConfirmation.Show()
        Me.Hide()
    End Sub

    Private Sub btnExora_Click(sender As Object, e As EventArgs) Handles btnExora.Click
        CarSelected.choosenCar = "Exora"
        carRentConfirmation.Show()
        Me.Hide()
    End Sub

    Private Sub pcbPlaces_Click(sender As Object, e As EventArgs) Handles pcbPlaces.Click
        Dim confirmation As String
        confirmation = MsgBox("You are in the middle of booking session. Do you want to leave this page?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "EXIT CONFIRMATION")
        If confirmation = MsgBoxResult.Yes Then
            booking.Show()
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

    Private Sub pcbBook_Click(sender As Object, e As EventArgs) Handles pcbBook.Click
        Dim confirmation As String
        confirmation = MsgBox("You are in the middle of booking session. Do you want to leave this page?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "EXIT CONFIRMATION")
        If confirmation = MsgBoxResult.Yes Then
            main_page_user.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub pcbTopUp_Click(sender As Object, e As EventArgs) Handles pcbTopUp.Click
        Dim confirmation As String
        confirmation = MsgBox("You are in the middle of booking session. Do you want to leave this page?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "EXIT CONFIRMATION")
        If confirmation = MsgBoxResult.Yes Then
            Call trovaPayPayment.trovPayIcon()
            Me.Hide()
        End If
    End Sub
End Class