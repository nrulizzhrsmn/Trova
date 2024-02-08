Public Class UserDriver
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        LOG_IN.Show()
        Me.Hide()
    End Sub

    Private Sub pcbPlaces_Click(sender As Object, e As EventArgs) Handles pcbPlaces.Click
        MsgBox("PLEASE LOG IN FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub pcbBooking_Click(sender As Object, e As EventArgs) Handles pcbBooking.Click
        MsgBox("PLEASE LOG IN FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub pcbTopUp_Click(sender As Object, e As EventArgs) Handles pcbTopUp.Click
        MsgBox("PLEASE LOG IN FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub pcbProfile_Click(sender As Object, e As EventArgs) Handles pcbProfile.Click
        MsgBox("PLEASE LOG IN FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub pcbSettings_Click(sender As Object, e As EventArgs) Handles pcbSettings.Click
        MsgBox("PLEASE LOG IN FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub btnDriver_Click(sender As Object, e As EventArgs) Handles btnDriver.Click
        Driver_Log_In.Show()
        Me.Hide()

    End Sub
End Class