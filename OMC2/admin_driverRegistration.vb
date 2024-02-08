Public Class admin_driverRegistration

    'to allow the user to edit the database

    Private Sub admin_driverRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TROVAdatabaseDataSet.Driver' table. You can move, or remove it, as needed.
        Me.DriverTableAdapter.Fill(Me.TROVAdatabaseDataSet.Driver)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.DriverBindingSource.EndEdit()
        Me.DriverTableAdapter.Update(Me.TROVAdatabaseDataSet.Driver)
        Me.DriverTableAdapter.Fill(Me.TROVAdatabaseDataSet.Driver)
        MsgBox("DATA SAVED SUCCESSFULLY")
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.DriverBindingSource.MovePrevious()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.DriverBindingSource.MoveNext()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.DriverBindingSource.RemoveCurrent()

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