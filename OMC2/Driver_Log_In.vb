Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Imports System.Data
Imports OMC2.DriverDetails

Public Class Driver_Log_In
    Dim connection As New OleDbConnection(My.Settings.TROVAdatabaseConnectionString)
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If txtUsername.Text <> "" And txtPassword.Text <> "" Then
            Dim user As String
            user = txtPassword.Text
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim cmd As New OleDbCommand("select count(*) from [Driver] where D_Email=? and D_Password=?", connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtUsername.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = txtPassword.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                DriverDetails.DriverUserEmail = txtUsername.Text
                MsgBox("Login succeed!", MsgBoxStyle.Information)
                DriverDetails.driver_profile = txtUsername.Text
                txtUsername.Text = ""
                txtPassword.Text = ""
                Me.Hide()
                main_Page_Driver.Show()
            Else
                MsgBox("Account not found. Check your credentials!", MsgBoxStyle.Critical, "Error!")
            End If
        Else
            If txtUsername.Text = "" Then
                MsgBox("please enter username", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "USERNAME ERROR ")
            Else
                MsgBox("please enter password", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "PASSWORD ERROR ")
            End If
        End If

    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        Else
            Exit Sub

        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub lblSignUp_Click(sender As Object, e As EventArgs) Handles lblSignUp.Click
        DriverRegistration.Show()
        Me.Hide()

    End Sub

    Private Sub pcbBook_Click(sender As Object, e As EventArgs) Handles pcbBook.Click
        MsgBox("PLEASE LOG IN FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub pcbPlacesIcon_Click(sender As Object, e As EventArgs) Handles pcbPlacesIcon.Click
        MsgBox("PLEASE LOG IN FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub pcbProfileIcon_Click(sender As Object, e As EventArgs) Handles pcbProfileIcon.Click
        MsgBox("PLEASE LOG IN FIRST", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ERROR")
    End Sub

    Private Sub pcbHome_Click(sender As Object, e As EventArgs) Handles pcbHome.Click
        mainPage.Show()
        Me.Close()
    End Sub

    Private Sub lblForgot_Click(sender As Object, e As EventArgs) Handles lblForgot.Click
        MsgBox("please contact the admin of Trova application", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "LOG IN ERROR")
    End Sub
End Class