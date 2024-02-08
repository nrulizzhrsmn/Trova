Public Class admin_user
    Private Sub admin_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TROVAdatabaseDataSet.profile' table. You can move, or remove it, as needed.
        Me.ProfileTableAdapter.Fill(Me.TROVAdatabaseDataSet.profile)

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.ProfileBindingSource.EndEdit()
        Me.ProfileTableAdapter.Update(Me.TROVAdatabaseDataSet.profile)
        Me.ProfileTableAdapter.Fill(Me.TROVAdatabaseDataSet.profile)
        MsgBox("DATA SAVED SUCCESSFULLY")
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.ProfileBindingSource.MovePrevious()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.ProfileBindingSource.MoveNext()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.ProfileBindingSource.RemoveCurrent()

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