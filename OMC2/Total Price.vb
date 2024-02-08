
Imports OMC2.Total_cost

Public Class Total_Price
    Dim remarks As String
    Dim estimated_distance As String
    Dim price As Double
    Dim estimated_hours As String
    Dim driver As String

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        btnPayment.Enabled = True
        Select Case CarSelected.choosenCar 'from the selected driver
            Case "Veronica"
                Call CarSelected.Veronica()
                lblDriver.Text = "DRIVER NAME : " & CarSelected.DriverName & vbLf & "CAR DETAILS : " & CarSelected.Colour & ", " & CarSelected.Brand & ", " & CarSelected.Plate

            Case "Gan"
                Call CarSelected.Gan()
                lblDriver.Text = "DRIVER NAME : " & CarSelected.DriverName & vbLf & "CAR DETAILS : " & CarSelected.Colour & ", " & CarSelected.Brand & ", " & CarSelected.Plate
            Case "Sofea"
                Call CarSelected.Sofea()
                lblDriver.Text = "DRIVER NAME : " & CarSelected.DriverName & vbLf & "CAR DETAILS : " & CarSelected.Colour & ", " & CarSelected.Brand & ", " & CarSelected.Plate
            Case "Ng"
                Call CarSelected.Ng()
                lblDriver.Text = "DRIVER NAME : " & CarSelected.DriverName & vbLf & "CAR DETAILS : " & CarSelected.Colour & ", " & CarSelected.Brand & ", " & CarSelected.Plate
            Case "Feliq"
                Call CarSelected.Feliq()
                lblDriver.Text = "DRIVER NAME : " & CarSelected.DriverName & vbLf & "CAR DETAILS : " & CarSelected.Colour & ", " & CarSelected.Brand & ", " & CarSelected.Plate
            Case "Asyraff"
                Call CarSelected.Asyraff()
                lblDriver.Text = "DRIVER NAME : " & CarSelected.DriverName & vbLf & "CAR DETAILS : " & CarSelected.Colour & ", " & CarSelected.Brand & ", " & CarSelected.Plate
            Case "Wan"
                Call CarSelected.Wan()
                lblDriver.Text = "DRIVER NAME : " & CarSelected.DriverName & vbLf & "CAR DETAILS : " & CarSelected.Colour & ", " & CarSelected.Brand & ", " & CarSelected.Plate
            Case "Alvin"
                Call CarSelected.Alvin()
                lblDriver.Text = "DRIVER NAME : " & CarSelected.DriverName & vbLf & "CAR DETAILS : " & CarSelected.Colour & ", " & CarSelected.Brand & ", " & CarSelected.Plate
            Case "Joseph"
                Call CarSelected.Joseph()
                lblDriver.Text = "DRIVER NAME : " & CarSelected.DriverName & vbLf & "CAR DETAILS : " & CarSelected.Colour & ", " & CarSelected.Brand & ", " & CarSelected.Plate
        End Select

        lblLocation.Text = (UCase(place_current) & " ---> " & UCase(place_travel))
        If UCase(state_current) = UCase(state_travel) Then
            If UCase(city_current) = UCase(city_travel) Then
                remarks = "Within the same state and city"
                lblRemarks.Text = remarks
            Else
                remarks = "Within the same state but different city"
                lblRemarks.Text = remarks
            End If
        Else
            remarks = "Crossing different state and city"
            lblRemarks.Text = remarks

        End If

        Select Case remarks
            Case "Within the same state and city"
                price = 15
                estimated_distance = "Less than 10 kilometres"
                estimated_hours = "Less than 1 hours"

            Case "Within the same state but different city"
                price = 75
                estimated_distance = "More than 30 kilometres"
                estimated_hours = "More than 2 hours"

            Case "Crossing different state and city"
                price = 130
                estimated_distance = "More than 100 kilometres"
                estimated_hours = "More than 3 hours"

        End Select
        lblEstimated_Distance.Text = estimated_distance
        lblEstimated_hours.Text = estimated_hours
        lblTotal_Cost.Text = Format(price, "currency")
        lblCurrentPlace.Text = place_current & ", " & city_current & ", " & state_current
        lblTravel.Text = place_travel & ", " & city_travel & ", " & state_travel
        lblStatus.Text = UserDetails.confirmation
        lblPhoneNum.Text = UserDetails.UserPhoneNum


    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        'to save the data in the user location database
        Me.Validate()
        Me.UserLocationBindingSource.EndEdit()
        Me.UserLocationTableAdapter.Update(Me.TROVAdatabaseDataSet.UserLocation)
        Me.UserLocationTableAdapter.Fill(Me.TROVAdatabaseDataSet.UserLocation)

        price_booking = price
        payment.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")

    End Sub

    Private Sub pcbBooking_Click(sender As Object, e As EventArgs) Handles pcbBooking.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")

    End Sub

    Private Sub pcbPlaces_Click(sender As Object, e As EventArgs) Handles pcbPlaces.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")
    End Sub

    Private Sub pcbTopUp_Click(sender As Object, e As EventArgs) Handles pcbTopUp.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")
    End Sub

    Private Sub pcbSettings_Click(sender As Object, e As EventArgs) Handles pcbSettings.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR")
    End Sub


    Private Sub Total_Price_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TROVAdatabaseDataSet.UserLocation' table. You can move, or remove it, as needed.
        Me.UserLocationTableAdapter.Fill(Me.TROVAdatabaseDataSet.UserLocation)
        Me.UserLocationBindingSource.AddNew()

    End Sub

    Private Sub Total_Price_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'to clear the label after the form close
        lblDriver.Text = ""
        lblEstimated_Distance.Text = ""
        lblEstimated_hours.Text = ""
        lblLocation.Text = ""
        lblRemarks.Text = ""
        lblTotal_Cost.Text = ""
    End Sub
End Class