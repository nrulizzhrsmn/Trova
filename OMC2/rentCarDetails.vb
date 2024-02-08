Public Class rentCarDetails
    Dim typeSeat As String
    Dim selectedStates As String
    Dim addressPoint As String


    Private Sub lblHome_Click(sender As Object, e As EventArgs)
        main_page_user.Show()
        Me.Hide()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        typeSeat = cbxCarSeat.SelectedItem
        selectedStates = cbxStates.SelectedItem

        'error checking to ensure the user has filled all the information required
        If selectedStates = "" Then
            MsgBox("please select the states before proceed", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "NOT ENOUGH INFORMATION")
        End If
        If typeSeat = "" Then
            MsgBox("please select the car seat before proceed", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "NOT ENOUGH INFORMATION")
        End If

        If lblDays.Text <> "" And lblDays.Text <> "0" And CStr(txtPoint.Text) <> String.Empty Then
            Select Case typeSeat
                Case "4-seated car"
                    FourSeated.Show()
                Case "6-seated cars"
                    SixSeated.Show()
            End Select
            addressPoint = txtPoint.Text
            CarSelected.Address = addressPoint 'append the information in the public class variable
            Me.Close()

        Else
            If lblDays.Text = "" Then
                MsgBox("please select the date before proceed", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "NOT ENOUGH INFORMATION")
            End If
            If lblDays.Text = "0" Then
                MsgBox("number of days cannot be 0, please re enter the date", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "NOT ENOUGH INFORMATION")
            End If
            If CStr(txtPoint.Text) = String.Empty Then
                MsgBox("please enter the pick up and return point before proceed", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "NOT ENOUGH INFORMATION")
            End If
        End If

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        'append the information in the public class
        CarSelected.PickUpDate = dtpPickUp.Value.Date
        CarSelected.ReturnDate = dtpReturn.Value.Date
        CarSelected.days = DateDiff(DateInterval.Day, dtpPickUp.Value.Date, dtpReturn.Value.Date)
        lblDays.Text = CarSelected.days



    End Sub

    Private Sub rentCarDetails_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'to reset the text boxes
        cbxStates.SelectedIndex = -1
        cbxCarSeat.SelectedIndex = -1
        lblDays.Text = ""
        txtPoint.Clear()

    End Sub


    Private Sub pcbTopUp_Click(sender As Object, e As EventArgs) Handles pcbTopUp.Click
        'confirmation for the user before proceed to other forms
        Dim confirmation As String
        confirmation = MsgBox("You are in the middle of booking session. Do you want to leave this page?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "EXIT CONFIRMATION")
        If confirmation = MsgBoxResult.Yes Then
            Call trovaPayPayment.trovPayIcon()
            Me.Hide()
        End If


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim confirmation As String
        confirmation = MsgBox("You are in the middle of booking session. Do you want to leave this page?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "EXIT CONFIRMATION")
        If confirmation = MsgBoxResult.Yes Then
            main_page_user.Show()
            Me.Hide()
        End If

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

End Class