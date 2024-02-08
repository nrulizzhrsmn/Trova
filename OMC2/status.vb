Public Class status
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If rbtAvailable.Checked = True Then
            driverStatus.Available()

        ElseIf rbtNotAvailble.Checked = True Then
            driverStatus.NotAvailable()

        End If
        main_Page_Driver.Show()
        Me.Close()
    End Sub
End Class