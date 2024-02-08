Public Class DriverRegistration
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtName.KeyDown, mskICNumberDriver.KeyDown, mskPhoneNumber.KeyDown, cboGender.KeyDown, txtUsername.KeyDown, txtPassword.KeyDown, txtConfirmPassword.KeyDown
        'to allow the user fill in the information smoothly and easily
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True

    End Sub
    Private Sub btnEditPicture_Click(sender As Object, e As EventArgs) Handles btnEditPicture.Click
        'to allow the user to append the picture
        Dim openphoto As New OpenFileDialog
        openphoto.Filter = ("Picture file|*.jpg;*.gif;*.png:*.bmp;*.jpeg")
        openphoto.ShowDialog()
        pcbPhoto_User.ImageLocation = openphoto.FileName
        'check_booking.pcbUser_pic1.Image = Me.pcbPhoto_User.Image


    End Sub

    Private Sub btnEditLicence_Click(sender As Object, e As EventArgs) Handles btnEditLicence.Click
        Dim openphoto As New OpenFileDialog
        openphoto.Filter = ("Picture file|*.jpg;*.gif;*.png:*.bmp;*.jpeg")
        openphoto.ShowDialog()
        pcbLicense.ImageLocation = openphoto.FileName
        'check_booking.pcbUser_pic1.Image = Me.pcbPhoto_User.Image

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
        'to ensure the user fill in the same password
        If (txtPassword.Text = "") = False Then
            If txtConfirmPassword.Text = txtPassword.Text Then
                lblPassword.Text = "Password match!"
            Else
                lblPassword.Text = "Password dont match!"
            End If
        End If

    End Sub

    Private Sub mskICNumber_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskICNumberDriver.MaskInputRejected
        'error checking which only allow numbers only
        If IsNumeric(mskICNumberDriver.Text) = False Then
            If (mskICNumberDriver.Text = "") = False Then
                MsgBox("Enter numbers only!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Operator")
            End If
        End If
    End Sub


    Private Sub mskPhoneNumber_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskPhoneNumber.MaskInputRejected
        If IsNumeric(mskICNumberDriver.Text) = False Then
            If (mskICNumberDriver.Text = "") = False Then
                MsgBox("Enter numbers only!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Operator")
            End If
        End If
    End Sub

    Private Sub chkConfirmPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkConfirmPassword.CheckedChanged
        If chkConfirmPassword.Checked = True Then
            txtConfirmPassword.UseSystemPasswordChar = False
        Else
            txtConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub


    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'to assign the value into public class which allow other class to access the information
        DriverDetails.DriverUserName = txtName.Text
        DriverDetails.DriverUserPhoneNum = mskPhoneNumber.Text
        DriverDetails.DriverUserIDNum = mskICNumberDriver.Text
        DriverDetails.DriverUserEmail = txtUsername.Text
        DriverDetails.DriverUserPassword = txtPassword.Text
        DriverDetails.DriverUserGender = cboGender.SelectedItem

        'for error checking to prevent the user from leaving the text boxes empty
        If (txtName.Text = "") OrElse (mskICNumberDriver.Text = "") OrElse (mskPhoneNumber.Text = "") OrElse (cboGender.Text = "") OrElse (txtPassword.Text = "") OrElse (txtConfirmPassword.Text = "") OrElse (txtUsername.Text = " ") Then
            MsgBox("Please enter your information completely", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Operator")
        Else
            'to save information in the driver database
            Me.Validate()
            Me.DriverBindingSource.EndEdit()
            Me.DriverTableAdapter.Update(Me.TROVAdatabaseDataSet.Driver)
            Me.DriverTableAdapter.Fill(Me.TROVAdatabaseDataSet.Driver)
            MsgBox("Data Saved!")
            Driver_Log_In.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub pcbProfileIcon_Click(sender As Object, e As EventArgs) Handles pcbProfileIcon.Click
        MsgBox("PLEASE LOG IN FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub pcbPlacesIcon_Click(sender As Object, e As EventArgs) Handles pcbPlacesIcon.Click
        MsgBox("PLEASE LOG IN FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub pcbBook_Click(sender As Object, e As EventArgs) Handles pcbBook.Click
        MsgBox("PLEASE LOG IN FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'to clear the text boxes
        txtName.Clear()
        mskICNumberDriver.Clear()
        mskPhoneNumber.Clear()
        cboGender.SelectedIndex = -1
        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        pcbPhoto_User.Image = Nothing
        pcbLicense.Image = Nothing


    End Sub

    Private Sub DriverRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TROVAdatabaseDataSet.Driver' table. You can move, or remove it, as needed.
        Me.DriverTableAdapter.Fill(Me.TROVAdatabaseDataSet.Driver)
        Me.DriverBindingSource.AddNew()

    End Sub

    Private Sub pcbHome_Click(sender As Object, e As EventArgs) Handles pcbHome.Click
        mainPage.Show()
        Me.Close()

    End Sub
End Class