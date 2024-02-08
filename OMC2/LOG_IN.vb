Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Imports System.Data
Imports OMC2.UserDetails
Public Class LOG_IN
    Dim attempt As Integer = 0
    Dim connection As New OleDbConnection(My.Settings.TROVAdatabaseConnectionString)

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        Else
            Exit Sub

        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        'allow the admin to log in into administration interface
        If txtUsername.Text <> "" And txtPassword.Text <> "" Then
            Dim user As String
            user = txtPassword.Text
            If txtUsername.Text = "adminTrova@gmail.com" And txtPassword.Text = "Trova12" Then
                MsgBox("admin log in succeed")
                admin_mainPage.Show()
                Me.Hide()

            Else
                'to link with the database and only allow the registered user to log in
                'to open the connect with the database
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If
                Dim cmd As New OleDbCommand("select count(*) from [Profile] where U_Email=? and U_Password=?", connection)
                cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtUsername.Text
                cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = txtPassword.Text
                Dim count = Convert.ToInt32(cmd.ExecuteScalar())

                If (count > 0) Then
                    UserDetails.UserEmail = txtUsername.Text
                    MsgBox("Login succeed!", MsgBoxStyle.Information)
                    UserDetails.user_Profile = txtUsername.Text
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    Me.Hide()
                    main_page_user.Show()
                Else
                    MsgBox("Account not found. Check your credentials!", MsgBoxStyle.Critical, "Error!")
                End If
            End If

        Else
            If txtUsername.Text = "" Then
                MsgBox("please enter username", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "USERNAME ERROR ")
            Else
                MsgBox("please enter password", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "PASSWORD ERROR ")
            End If
            'to avoid the user from log in without typing username and password
        End If
    End Sub



    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub lblSignUp_Click(sender As Object, e As EventArgs) Handles lblSignUp.Click
        FormRegister.Show()
        Me.Hide()

    End Sub

    Private Sub lblForgot_Click(sender As Object, e As EventArgs) Handles lblForgot.Click
        forgotPassword.Show()
        txtPassword.Text = ""
        txtUsername.Text = ""
    End Sub

    Private Sub pcbBooking_Click_1(sender As Object, e As EventArgs) Handles pcbBooking.Click
        MsgBox("PLEASE LOG IN FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub pcbPlaces_Click_1(sender As Object, e As EventArgs) Handles pcbPlaces.Click
        MsgBox("PLEASE LOG IN FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub pcbTopUp_Click(sender As Object, e As EventArgs) Handles pcbTopUp.Click
        MsgBox("PLEASE LOG IN FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub pcbProfile_Click(sender As Object, e As EventArgs) Handles pcbProfile.Click
        MsgBox("PLEASE LOG IN FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub pcbSettings_Click(sender As Object, e As EventArgs) Handles pcbSettings.Click
        MsgBox("PLEASE LOG IN FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub pcbHome_Click(sender As Object, e As EventArgs) Handles pcbHome.Click
        mainPage.Show()
        Me.Close()
    End Sub
End Class