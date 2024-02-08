Public Class forgotPassword2
    Private Sub forgotPassword2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TROVAdatabaseDataSet.profile' table. You can move, or remove it, as needed.
        Me.ProfileTableAdapter.Fill(Me.TROVAdatabaseDataSet.profile)
        Dim Show = From Profile In TROVAdatabaseDataSet.profile
                   Where Profile.U_Email Like UserDetails.user_Forgot & "*"
                   Select Profile

        ProfileBindingSource.DataSource = Show.AsDataView

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPress.Click
        txtPassword.Clear()
        Dim password As String = InputBox("Please enter new password: ", "Change Password")
        If password = "" Then
            MsgBox("Please enter input!", MsgBoxStyle.Information, "Operator")
        Else

            'txtPassword.ForeColor = Color.Black
            txtPassword.Text = password
            txtPasswordConfirmation.Text = password
            UserDetails.UserPassword = password
        End If

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If txtPasswordConfirmation.Text = "" Then
            MsgBox("please enter new password", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "NEW PASSWORD REQUIRED")
        Else

            Me.Validate()
            Me.ProfileBindingSource.EndEdit()
            Me.ProfileTableAdapter.Update(Me.TROVAdatabaseDataSet.profile)
            Me.ProfileTableAdapter.Fill(Me.TROVAdatabaseDataSet.profile)
            MsgBox("DATA SAVED SUCCESSFULLY")

            UserDetails.UserPassword = txtPassword.Text
            LOG_IN.Show()
            Me.Hide()
        End If

    End Sub

End Class