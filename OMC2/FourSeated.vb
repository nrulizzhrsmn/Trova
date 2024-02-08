Public Class FourSeated

    'to append the car name into choosencar varible in car selected public class 
    Private Sub btnSaga_Click(sender As Object, e As EventArgs) Handles btnSaga.Click
        CarSelected.choosenCar = "Saga"
        carRentConfirmation.Show()
        Me.Hide()

    End Sub

    Private Sub btnWira_Click(sender As Object, e As EventArgs) Handles btnWira.Click
        CarSelected.choosenCar = "Wira"
        carRentConfirmation.Show()
        Me.Hide()
    End Sub

    Private Sub btnCivic_Click(sender As Object, e As EventArgs) Handles btnCivic.Click
        CarSelected.choosenCar = "Civic"
        carRentConfirmation.Show()
        Me.Hide()
    End Sub

    Private Sub btnMyvi_Click(sender As Object, e As EventArgs) Handles btnMyvi.Click
        CarSelected.choosenCar = "Myvi"
        carRentConfirmation.Show()
        Me.Hide()
    End Sub

    Private Sub btnJazz_Click(sender As Object, e As EventArgs) Handles btnJazz.Click
        CarSelected.choosenCar = "Jazz"
        carRentConfirmation.Show()
        Me.Hide()
    End Sub

    Private Sub btnHilux_Click(sender As Object, e As EventArgs) Handles btnHilux.Click
        CarSelected.choosenCar = "Hilux"
        carRentConfirmation.Show()
        Me.Hide()
    End Sub

    Private Sub btnAxia_Click(sender As Object, e As EventArgs) Handles btnAxia.Click
        CarSelected.choosenCar = "Axia"
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

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub FourSeated_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class