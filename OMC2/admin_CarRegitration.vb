Public Class admin_CarRegitration

    'to allow the admin to register the available car for the application in rental car features
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBrand.KeyDown, txtNumPlate.KeyDown, txtColour.KeyDown, mskRoadTax.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True

    End Sub

    Private Sub admin_CarRegitration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TROVAdatabaseDataSet.carRegistration' table. You can move, or remove it, as needed.
        Me.CarRegistrationTableAdapter.Fill(Me.TROVAdatabaseDataSet.carRegistration)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtBrand.Enabled = True
        txtColour.Enabled = True
        txtNumPlate.Enabled = True
        mskRoadTax.Enabled = True

        Me.CarRegistrationBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.CarRegistrationBindingSource.EndEdit()
        Me.CarRegistrationTableAdapter.Update(Me.TROVAdatabaseDataSet.carRegistration)
        Me.CarRegistrationTableAdapter.Fill(Me.TROVAdatabaseDataSet.carRegistration)
        MsgBox("DATA SAVED SUCCESSFULLY")
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.CarRegistrationBindingSource.MovePrevious()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.CarRegistrationBindingSource.MoveNext()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.CarRegistrationBindingSource.RemoveCurrent()

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