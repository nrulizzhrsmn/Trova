Public Class History

    'to check the past activities
    Private Sub pcbPrevious_Click(sender As Object, e As EventArgs) Handles pcbPrevious.Click
        main_Page_Driver.Show()
        Me.Hide()

    End Sub

    Private Sub pcbHome_Click(sender As Object, e As EventArgs) Handles pcbHome.Click
        main_Page_Driver.Show()
        Me.Hide()

    End Sub

    Private Sub pcbBook_Click(sender As Object, e As EventArgs) Handles pcbBook.Click
        status.Show()
        Me.Hide()

    End Sub

    Private Sub pcbProfileIcon_Click(sender As Object, e As EventArgs) Handles pcbProfileIcon.Click
        driverProfile.Show()
        Me.Hide()

    End Sub
End Class