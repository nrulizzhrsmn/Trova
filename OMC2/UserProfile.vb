
Imports OMC2.UserDetails

Public Class UserProfile
    Private Sub UserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Show = From profile In TROVAdatabaseDataSet.profile
                   Where profile.U_Email Like UserDetails.user_Profile & "*"
                   Select profile

        ProfileBindingSource.DataSource = Show.AsDataView



        'TODO: This line of code loads data into the 'DatabaseOMCDataSet.Profile' table. You can move, or remove it, as needed.
        Me.ProfileTableAdapter.Fill(Me.TROVAdatabaseDataSet.profile)

    End Sub

    Private Sub btnChangeName_Click(sender As Object, e As EventArgs) Handles btnChangeName.Click
        txtNewName.Enabled = True
        txtNewName.Text = UCase(txtNewName.Text)

    End Sub

    Private Sub btnChangePhone_Click(sender As Object, e As EventArgs) Handles btnChangePhone.Click
        mskNewPhoneNum.Enabled = True
        If IsNumeric(mskNewPhoneNum.Text) = False Then
            MsgBox("Enter numbers only!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Operator")
        End If
    End Sub

    Private Sub btnChangeIC_Click(sender As Object, e As EventArgs) Handles btnChangeIC.Click
        mskNewICnum.Enabled = True
        If IsNumeric(mskNewICnum.Text) = False Then
            MsgBox("Enter numbers only!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Operator")
        End If
    End Sub

    Private Sub btnChangeEmail_Click(sender As Object, e As EventArgs) Handles btnChangeEmail.Click
        txtNewEmail.Enabled = True

    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        txtNewPassword.Enabled = True

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If txtNewName.Text = "" OrElse txtNewEmail.Text = "" OrElse txtNewPassword.Text = "" OrElse mskNewPhoneNum.Text = "" OrElse mskNewICnum.Text = "" Then
            MsgBox("please complete the information", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR")
        Else

            Me.Validate() 'to save in the user database
            Me.ProfileBindingSource.EndEdit()
            Me.ProfileTableAdapter.Update(Me.TROVAdatabaseDataSet.profile)
            Me.ProfileTableAdapter.Fill(Me.TROVAdatabaseDataSet.profile)
            MsgBox("DATA SAVED SUCCESSFULLY")

            UserDetails.UserName = UCase(txtNewName.Text) 'to save in the public class
            UserDetails.UserPhoneNum = mskNewPhoneNum.Text
            UserDetails.UserIDNum = mskNewICnum.Text
            UserDetails.UserEmail = txtNewEmail.Text
            UserDetails.UserPassword = txtNewPassword.Text
            UserDetails.UserGender = txtGender.Text

            txtNewName.Enabled = False
            txtNewEmail.Enabled = False
            mskNewPhoneNum.Enabled = False
            mskNewICnum.Enabled = False
            txtNewPassword.Enabled = False
            txtGender.Enabled = False

            main_page_user.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub pcbHome_Click(sender As Object, e As EventArgs) Handles pcbHome.Click
        MsgBox("PLEASE SAVE ALL THE INFORMATION THAT YOU HAVE CHANGED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "INFORMATION CHANGE ALERT!")
    End Sub

    Private Sub pcbBooking_Click(sender As Object, e As EventArgs) Handles pcbBooking.Click
        MsgBox("PLEASE SAVE ALL THE INFORMATION THAT YOU HAVE CHANGED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "INFORMATION CHANGE ALERT!")


    End Sub

    Private Sub pcbPlaces_Click(sender As Object, e As EventArgs) Handles pcbPlaces.Click
        MsgBox("PLEASE SAVE ALL THE INFORMATION THAT YOU HAVE CHANGED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "INFORMATION CHANGE ALERT!")
    End Sub

    Private Sub pcbTopUp_Click(sender As Object, e As EventArgs) Handles pcbTopUp.Click
        MsgBox("PLEASE SAVE ALL THE INFORMATION THAT YOU HAVE CHANGED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "INFORMATION CHANGE ALERT!")
    End Sub

    Private Sub pcbSettings_Click(sender As Object, e As EventArgs) Handles pcbSettings.Click
        MsgBox("PLEASE SAVE ALL THE INFORMATION THAT YOU HAVE CHANGED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "INFORMATION CHANGE ALERT!")
    End Sub
End Class