
Imports OMC2.UserDetails
Public Class FormRegister

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown, txtPassword.KeyDown, txtName.KeyDown, txtConfirmPassword.KeyDown, mskPhoneNumber.KeyDown, mskICNumber.KeyDown, cboGender.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True
    End Sub

    Private Sub txtName_Leave(sender As Object, e As EventArgs) Handles txtName.Leave
        txtName.Text = UCase(txtName.Text)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then

            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged


        If (txtPassword.Text = "") = False Then
            If txtConfirmPassword.Text = txtPassword.Text Then
                lblPassword.Text = "Password match!"
            Else
                lblPassword.Text = "Password dont match!"
            End If
        End If

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        UserName = txtName.Text
        UserPhoneNum = mskPhoneNumber.Text
        UserIDNum = mskICNumber.Text
        UserEmail = txtUsername.Text
        UserPassword = txtPassword.Text
        UserGender = cboGender.SelectedItem
        If (txtName.Text = "") OrElse (mskICNumber.Text = "") OrElse (mskPhoneNumber.Text = "") OrElse (cboGender.Text = "") OrElse (txtPassword.Text = "") OrElse (txtConfirmPassword.Text = "") OrElse (txtUsername.Text = " ") Then
            MsgBox("Please enter your information completely", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Operator")
        Else
            'to save information in the user profile database
            Me.Validate()
            Me.ProfileBindingSource.EndEdit()
            Me.ProfileTableAdapter.Update(Me.TROVAdatabaseDataSet.profile)
            Me.ProfileTableAdapter.Fill(Me.TROVAdatabaseDataSet.profile)
            MsgBox("Data Saved!")
            LOG_IN.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub mskICNumber_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskICNumber.MaskInputRejected

        If IsNumeric(mskICNumber.Text) = False Then
            If (mskICNumber.Text = "") = False Then
                MsgBox("Enter numbers only!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Operator")
            End If
        End If
    End Sub

    Private Sub mskPhoneNumber_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskPhoneNumber.MaskInputRejected
        If IsNumeric(mskICNumber.Text) = False Then
            If (mskICNumber.Text = "") = False Then
                MsgBox("Enter numbers only!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Operator")
            End If
        End If
    End Sub

    Private Sub chkConfirmPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkConfirmPassword.CheckedChanged
        'to synchronize the password and the confirm password
        If chkConfirmPassword.Checked = True Then
            txtConfirmPassword.UseSystemPasswordChar = False
        Else
            txtConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub


    Private Sub btnEditPicture_Click(sender As Object, e As EventArgs) Handles btnEditPicture.Click
        'to open file dialog to append photo
        Dim openphoto As New OpenFileDialog
        openphoto.Filter = ("Picture file|*.jpg;*.gif;*.png:*.bmp;*.jpeg")
        openphoto.ShowDialog()
        pcbPhoto_User.ImageLocation = openphoto.FileName
        'check_booking.pcbUser_pic1.Image = Me.pcbPhoto_User.Image

    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'to clear the text box
        txtName.Clear()
        mskICNumber.Clear()
        mskPhoneNumber.Clear()
        cboGender.SelectedIndex = -1
        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        pcbPhoto_User.Image = Nothing
    End Sub

    Private Sub FormRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TROVAdatabaseDataSet.profile' table. You can move, or remove it, as needed.
        Me.ProfileTableAdapter.Fill(Me.TROVAdatabaseDataSet.profile)
        Me.ProfileBindingSource.AddNew()

    End Sub

    Private Sub pcbBooking_Click(sender As Object, e As EventArgs) Handles pcbBooking.Click
        MsgBox("PLEASE SIGN UP FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub pcbPlaces_Click(sender As Object, e As EventArgs) Handles pcbPlaces.Click
        MsgBox("PLEASE SIGN UP FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub pcbTopUp_Click(sender As Object, e As EventArgs) Handles pcbTopUp.Click
        MsgBox("PLEASE SIGN UP FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub pcbProfile_Click(sender As Object, e As EventArgs) Handles pcbProfile.Click
        MsgBox("PLEASE SIGN UP FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub pcbSettings_Click(sender As Object, e As EventArgs) Handles pcbSettings.Click
        MsgBox("PLEASE SIGN UP FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        mainPage.Show()
        Me.Close()
    End Sub
End Class
