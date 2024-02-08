Public Class admin_UserLocation
    Private Sub admin_UserLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TROVAdatabaseDataSet.UserLocation' table. You can move, or remove it, as needed.
        Me.UserLocationTableAdapter.Fill(Me.TROVAdatabaseDataSet.UserLocation)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.UserLocationBindingSource.EndEdit()
        Me.UserLocationTableAdapter.Update(Me.TROVAdatabaseDataSet.UserLocation)
        Me.UserLocationTableAdapter.Fill(Me.TROVAdatabaseDataSet.UserLocation)
        MsgBox("DATA SAVED SUCCESSFULLY")
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.UserLocationBindingSource.MovePrevious()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.UserLocationBindingSource.MoveNext()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.UserLocationBindingSource.RemoveCurrent()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        admin_mainPage.Show()
        Me.Close()

    End Sub

    Private Sub pcbHome_Click(sender As Object, e As EventArgs) Handles pcbHome.Click
        admin_mainPage.Show()
        Me.Hide()

    End Sub
End Class