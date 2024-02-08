Public Class top_up_confirmation
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' to save the information in the database
        Me.Validate()
        Me.TrovaPayBindingSource.EndEdit()
        Me.TrovaPayTableAdapter.Update(Me.TROVAdatabaseDataSet.TrovaPay)
        Me.TrovaPayTableAdapter.Fill(Me.TROVAdatabaseDataSet.TrovaPay)
        Me.Close()

    End Sub

    Private Sub top_up_confirmation_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'to append the info into the database
        lblValue.Text = trovaPayPayment.value
        lblPhoneNum.Text = UserDetails.UserPhoneNum
        lblStatus.Text = UserDetails.confirmation
    End Sub

    Private Sub top_up_confirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TROVAdatabaseDataSet.TrovaPay' table. You can move, or remove it, as needed.
        Me.TrovaPayTableAdapter.Fill(Me.TROVAdatabaseDataSet.TrovaPay)
        Me.TrovaPayBindingSource.AddNew()


    End Sub

End Class