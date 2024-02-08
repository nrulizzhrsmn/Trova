Public Class Review
    Dim rating As String

    Private Sub chkNotHappy_CheckedChanged(sender As Object, e As EventArgs) Handles chkNotHappy.CheckedChanged
        If chkNotHappy.Checked = True Then
            chkMad.Enabled = False
            chkHappy.Enabled = False
        Else
            chkMad.Enabled = True
            chkHappy.Enabled = True
        End If
        rating = "not satisfied"
    End Sub

    Private Sub chkHappy_CheckedChanged(sender As Object, e As EventArgs) Handles chkHappy.CheckedChanged
        If chkHappy.Checked = True Then
            chkMad.Enabled = False
            chkNotHappy.Enabled = False
        Else
            chkMad.Enabled = True
            chkNotHappy.Enabled = True
        End If
        rating = "happy"
    End Sub

    Private Sub chkMad_CheckedChanged(sender As Object, e As EventArgs) Handles chkMad.CheckedChanged
        If chkMad.Checked = True Then
            chkNotHappy.Enabled = False
            chkHappy.Enabled = False
        Else
            chkHappy.Enabled = True
            chkNotHappy.Enabled = True
        End If
        rating = "mad"
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        main_page_user.Show()

        Me.Hide()

    End Sub


    Private Sub Review_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        chkHappy.Checked = False
        chkMad.Checked = False
        chkNotHappy.Checked = False
        txtFeedback.Clear()
    End Sub

    Private Sub pcbHome_Click(sender As Object, e As EventArgs) Handles pcbHome.Click
        MsgBox("WE WOULD APPRECIATE YOU TO GIVE REVIEW ON OUR SERVICE", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "REVIEW")

    End Sub

    Private Sub pcbBooking_Click(sender As Object, e As EventArgs) Handles pcbBooking.Click
        MsgBox("WE WOULD APPRECIATE YOU TO GIVE REVIEW ON OUR SERVICE", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "REVIEW")

    End Sub

    Private Sub pcbPlaces_Click(sender As Object, e As EventArgs) Handles pcbPlaces.Click
        MsgBox("WE WOULD APPRECIATE YOU TO GIVE REVIEW ON OUR SERVICE", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "REVIEW")
    End Sub

    Private Sub pcbTopUp_Click(sender As Object, e As EventArgs) Handles pcbTopUp.Click
        MsgBox("WE WOULD APPRECIATE YOU TO GIVE REVIEW ON OUR SERVICE", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "REVIEW")
    End Sub

    Private Sub pcbSettings_Click(sender As Object, e As EventArgs) Handles pcbSettings.Click
        MsgBox("WE WOULD APPRECIATE YOU TO GIVE REVIEW ON OUR SERVICE", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "REVIEW")
    End Sub


End Class