Public Class admin_TrovaPay
    Private Sub admin_TrovaPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TROVAdatabaseDataSet.TrovaPay' table. You can move, or remove it, as needed.
        Me.TrovaPayTableAdapter.Fill(Me.TROVAdatabaseDataSet.TrovaPay)

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.TrovaPayBindingSource.EndEdit()
        Me.TrovaPayTableAdapter.Update(Me.TROVAdatabaseDataSet.TrovaPay)
        Me.TrovaPayTableAdapter.Fill(Me.TROVAdatabaseDataSet.TrovaPay)
        MsgBox("DATA SAVED SUCCESSFULLY")
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.TrovaPayBindingSource.MovePrevious()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.TrovaPayBindingSource.MoveNext()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.TrovaPayBindingSource.RemoveCurrent()

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