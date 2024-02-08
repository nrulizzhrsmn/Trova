Public Class admin_Car
    Private Sub admin_Car_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TROVAdatabaseDataSet.rentalCar' table. You can move, or remove it, as needed.
        Me.RentalCarTableAdapter.Fill(Me.TROVAdatabaseDataSet.rentalCar)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.RentalCarBindingSource.EndEdit()
        Me.RentalCarTableAdapter.Update(Me.TROVAdatabaseDataSet.rentalCar)
        Me.RentalCarTableAdapter.Fill(Me.TROVAdatabaseDataSet.rentalCar)
        MsgBox("DATA SAVED SUCCESSFULLY")
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.RentalCarBindingSource.MovePrevious()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.RentalCarBindingSource.MoveNext()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.RentalCarBindingSource.RemoveCurrent()

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