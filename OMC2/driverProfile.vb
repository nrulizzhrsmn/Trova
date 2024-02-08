Public Class driverProfile
    Dim strName As String
    Private Sub driverProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'to find to row of the information in the driver profile database
        Dim Show = From Driver In TROVAdatabaseDataSet.Driver
                   Where Driver.D_Email Like DriverDetails.driver_profile & "*"
                   Select Driver

        DriverBindingSource.DataSource = Show.AsDataView
        'TODO: This line of code loads data into the 'TROVAdatabaseDataSet.Driver' table. You can move, or remove it, as needed.
        Me.DriverTableAdapter.Fill(Me.TROVAdatabaseDataSet.Driver)

    End Sub

    Private Sub btnChangeName_Click(sender As Object, e As EventArgs) Handles btnChangeName.Click
        txtNewName.Enabled = True
        strName = UCase(txtNewEmail.Text)

    End Sub

    Private Sub btnChangePhone_Click(sender As Object, e As EventArgs) Handles btnChangePhone.Click
        mskNewPhoneNum.Enabled = True
        If IsNumeric(mskNewPhoneNum.Text) = False Then 'to ensure the user only insert numbers only
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
            'to save updated info in the database
            Me.Validate()
            Me.DriverBindingSource.EndEdit()
            Me.DriverTableAdapter.Update(Me.TROVAdatabaseDataSet.Driver)
            Me.DriverTableAdapter.Fill(Me.TROVAdatabaseDataSet.Driver)
            MsgBox("DATA SAVED SUCCESSFULLY")

            DriverDetails.DriverUserName = strName ' to save the info in the public class
            DriverDetails.DriverUserPhoneNum = mskNewPhoneNum.Text
            DriverDetails.DriverUserIDNum = mskNewICnum.Text
            DriverDetails.DriverUserEmail = txtNewEmail.Text
            DriverDetails.DriverUserPassword = txtNewPassword.Text


            main_Page_Driver.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub pcbHome_Click(sender As Object, e As EventArgs) Handles pcbHome.Click
        main_Page_Driver.Show()
        Me.Hide()

    End Sub

    Private Sub pcbBooking_Click(sender As Object, e As EventArgs) Handles pcbBooking.Click
        status.Show()
        Me.Hide()

    End Sub

    Private Sub pcbPlaces_Click(sender As Object, e As EventArgs) Handles pcbPlaces.Click
        History.Show()
        Me.Hide()

    End Sub
End Class