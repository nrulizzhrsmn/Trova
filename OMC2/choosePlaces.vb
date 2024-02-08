Public Class choosePlaces

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim places As String = cbxStates.SelectedItem
        Select Case places
            Case "JOHOR"
                JOHOR_BAHRU.Show()
                Me.Hide()
            Case "MELAKA"
                MELAKA.Show()
                Me.Hide()
            Case "NEGERI SEMBILAN"
                N9.Show()
                Me.Hide()
            Case "PERAK"
                PERAK.Show()
                Me.Hide()
            Case "PERLIS"
                PERLIS.Show()
                Me.Hide()
            Case "PAHANG"
                PAHANG.Show()
                Me.Hide()
            Case "KEDAH"
                KEDAH.Show()
                Me.Hide()
            Case "KELANTAN"
                KELANTAN.Show()
                Me.Hide()
            Case "KUALA LUMPUR"
                KL.Show()
                Me.Hide()
            Case "PENANG"
                PENANG.Show()
                Me.Hide()
            Case "TERENGGANU"
                TERENGGANU.Show()
                Me.Hide()
            Case "SELANGOR"
                SELANGOR.Show()
                Me.Hide()


        End Select

        If cbxStates.SelectedItem = "" Then
            MsgBox("please select the states before proceed")
        End If
        cbxStates.SelectedIndex = -1
    End Sub



    Private Sub pcbPrevious_Click(sender As Object, e As EventArgs) Handles pcbPrevious.Click
        booking.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
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

    Private Sub pcbTopUp_Click(sender As Object, e As EventArgs) Handles pcbTopUp.Click
        Dim confirmation As String
        confirmation = MsgBox("You are in the middle of booking session. Do you want to leave this page?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "EXIT CONFIRMATION")
        If confirmation = MsgBoxResult.Yes Then
            Call trovaPayPayment.trovPayIcon()
            Me.Hide()
        End If
    End Sub

    Private Sub cbxStates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxStates.SelectedIndexChanged

    End Sub
End Class