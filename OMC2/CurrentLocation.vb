Imports System.Text
Imports OMC2.Total_cost

Public Class CurrentLocation
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub txtState_KeyUp(sender As Object, e As KeyEventArgs) Handles txtState.KeyUp, txtPlace.KeyUp, txtPoscode.KeyUp, txtCity.KeyUp

        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim place As String = txtPlace.Text
        Dim state As String = txtState.Text
        Dim city As String = txtCity.Text
        Dim poscode As String = txtPoscode.Text

        Try
            Dim querryAddress As New StringBuilder
            querryAddress.Append("https://maps.google.com/maps?q=")


            If txtPlace.Text <> String.Empty Then
                querryAddress.Append(place + "," & "+")
            End If
            If txtCity.Text <> String.Empty Then
                querryAddress.Append(city + "," & "+")
            End If
            If txtPoscode.Text <> String.Empty Then
                querryAddress.Append(poscode + "," & "+")
            End If
            If txtState.Text <> String.Empty Then
                querryAddress.Append(state + "," & "+")
            End If


            WebBrowser1.Navigate(querryAddress.ToString)

        Catch ex As Exception
            MsgBox("Unable to retrive data", MsgBoxStyle.Critical, "Operator")

        End Try
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If (txtCity.Text = "") = True Or (txtPlace.Text = "") = True Or (txtState.Text = "") = True OrElse (txtPoscode.Text = "") = False Then
            MsgBox("Confirm the location address is correct?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Confirm Location")
            If vbYes Then
                state_current = UCase(txtState.Text)
                city_current = UCase(txtCity.Text)
                poscode_current = UCase(txtPoscode.Text)
                place_current = UCase(txtPlace.Text)

                Preference.Show()
                Me.Hide()

            Else

            End If
        Else
            MsgBox("Please full fill the address information!", MsgBoxStyle.OkOnly, "Operator")
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtCity.Clear()
        txtPlace.Clear()
        txtPoscode.Clear()
        txtState.Clear()

    End Sub
End Class