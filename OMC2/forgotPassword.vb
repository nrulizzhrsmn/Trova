Public Class forgotPassword
    Private Sub forgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TROVAdatabaseDataSet.profile' table. You can move, or remove it, as needed.
        Me.ProfileTableAdapter.Fill(Me.TROVAdatabaseDataSet.profile)

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        UserDetails.user_Forgot = txtEmail.Text
        forgotPassword2.Show()
        Me.Hide()
    End Sub


End Class