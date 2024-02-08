Public Class carRentConfirmation
    Dim confirmation As String = "successful"
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'to save the booking details into the database
        Me.Validate()
        Me.RentalCarBindingSource.EndEdit()
        Me.RentalCarTableAdapter.Update(Me.TROVAdatabaseDataSet.rentalCar)
        Me.RentalCarTableAdapter.Fill(Me.TROVAdatabaseDataSet.rentalCar)
        payment.Show()
        Me.Close()

    End Sub

    Private Sub carRentConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TROVAdatabaseDataSet.rentalCar' table. You can move, or remove it, as needed.
        Me.RentalCarTableAdapter.Fill(Me.TROVAdatabaseDataSet.rentalCar)
        Me.RentalCarBindingSource.AddNew()


    End Sub

    Private Sub pcbHome_Click(sender As Object, e As EventArgs) Handles pcbHome.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "REVIEW")

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        'with the appended variable, the program will take the details(from the public class) for the selected car and put it into the label
        Select Case CarSelected.choosenCar
            Case "Estima"
                Call CarSelected.Estima()
                lblBrand.Text = CarSelected.Brand
                lblPlateNumber.Text = CarSelected.Plate
                lblPickUpDate.Text = CarSelected.PickUpDate
                lblReturn.Text = CarSelected.ReturnDate
                CarSelected.totalPrice = CInt(CarSelected.CarPrice) * CInt(CarSelected.days)
                lblPrice.Text = CarSelected.totalPrice
                lblColour.Text = CarSelected.Colour

            Case "GrandLivina"
                Call CarSelected.GrandLivina()
                lblBrand.Text = CarSelected.Brand
                lblPlateNumber.Text = CarSelected.Plate
                lblPickUpDate.Text = CarSelected.PickUpDate
                lblReturn.Text = CarSelected.ReturnDate
                CarSelected.totalPrice = CInt(CarSelected.CarPrice) * CInt(CarSelected.days)
                lblPrice.Text = CarSelected.totalPrice
                lblColour.Text = CarSelected.Colour

            Case "Alphard"
                Call CarSelected.Alphard()
                lblBrand.Text = CarSelected.Brand
                lblPlateNumber.Text = CarSelected.Plate
                lblPickUpDate.Text = CarSelected.PickUpDate
                lblReturn.Text = CarSelected.ReturnDate
                CarSelected.totalPrice = CInt(CarSelected.CarPrice) * CInt(CarSelected.days)
                lblPrice.Text = CarSelected.totalPrice
                lblColour.Text = CarSelected.Colour

            Case "Alza"
                Call CarSelected.Alza()
                lblBrand.Text = CarSelected.Brand
                lblPlateNumber.Text = CarSelected.Plate
                lblPickUpDate.Text = CarSelected.PickUpDate
                lblReturn.Text = CarSelected.ReturnDate
                CarSelected.totalPrice = CInt(CarSelected.CarPrice) * CInt(CarSelected.days)
                lblPrice.Text = CarSelected.totalPrice
                lblColour.Text = CarSelected.Colour

            Case "Exora"
                Call CarSelected.Exora()
                lblBrand.Text = CarSelected.Brand
                lblPlateNumber.Text = CarSelected.Plate
                lblPickUpDate.Text = CarSelected.PickUpDate
                lblReturn.Text = CarSelected.ReturnDate
                CarSelected.totalPrice = CInt(CarSelected.CarPrice) * CInt(CarSelected.days)
                lblPrice.Text = CarSelected.totalPrice
                lblColour.Text = CarSelected.Colour

            Case "Saga"
                Call CarSelected.Saga()
                lblBrand.Text = CarSelected.Brand
                lblPlateNumber.Text = CarSelected.Plate
                lblPickUpDate.Text = CarSelected.PickUpDate
                lblReturn.Text = CarSelected.ReturnDate
                CarSelected.totalPrice = CInt(CarSelected.CarPrice) * CInt(CarSelected.days)
                lblPrice.Text = CarSelected.totalPrice
                lblColour.Text = CarSelected.Colour

            Case "Wira"
                Call CarSelected.Wira()
                lblBrand.Text = CarSelected.Brand
                lblPlateNumber.Text = CarSelected.Plate
                lblPickUpDate.Text = CarSelected.PickUpDate
                lblReturn.Text = CarSelected.ReturnDate
                CarSelected.totalPrice = CInt(CarSelected.CarPrice) * CInt(CarSelected.days)
                lblPrice.Text = CarSelected.totalPrice
                lblColour.Text = CarSelected.Colour

            Case "Civic"
                Call CarSelected.Civic()
                lblBrand.Text = CarSelected.Brand
                lblPlateNumber.Text = CarSelected.Plate
                lblPickUpDate.Text = CarSelected.PickUpDate
                lblReturn.Text = CarSelected.ReturnDate
                CarSelected.totalPrice = CInt(CarSelected.CarPrice) * CInt(CarSelected.days)
                lblPrice.Text = CarSelected.totalPrice
                lblColour.Text = CarSelected.Colour

            Case "Myvi"
                Call CarSelected.Myvi()
                lblBrand.Text = CarSelected.Brand
                lblPlateNumber.Text = CarSelected.Plate
                lblPickUpDate.Text = CarSelected.PickUpDate
                lblReturn.Text = CarSelected.ReturnDate
                CarSelected.totalPrice = CInt(CarSelected.CarPrice) * CInt(CarSelected.days)
                lblPrice.Text = CarSelected.totalPrice
                lblColour.Text = CarSelected.Colour

            Case "Jazz"
                Call CarSelected.Jazz()
                lblBrand.Text = CarSelected.Brand
                lblPlateNumber.Text = CarSelected.Plate
                lblPickUpDate.Text = CarSelected.PickUpDate
                lblReturn.Text = CarSelected.ReturnDate
                CarSelected.totalPrice = CInt(CarSelected.CarPrice) * CInt(CarSelected.days)
                lblPrice.Text = CarSelected.totalPrice
                lblColour.Text = CarSelected.Colour

            Case "Hilux"
                Call CarSelected.Hilux()
                lblBrand.Text = CarSelected.Brand
                lblPlateNumber.Text = CarSelected.Plate
                lblPickUpDate.Text = CarSelected.PickUpDate
                lblReturn.Text = CarSelected.ReturnDate
                CarSelected.totalPrice = CInt(CarSelected.CarPrice) * CInt(CarSelected.days)
                lblPrice.Text = CarSelected.totalPrice
                lblColour.Text = CarSelected.Colour

            Case "Axia"
                Call CarSelected.Axia()
                lblBrand.Text = CarSelected.Brand
                lblPlateNumber.Text = CarSelected.Plate
                lblPickUpDate.Text = CarSelected.PickUpDate
                lblReturn.Text = CarSelected.ReturnDate
                CarSelected.totalPrice = CInt(CarSelected.CarPrice) * CInt(CarSelected.days)
                lblPrice.Text = CarSelected.totalPrice
                lblColour.Text = CarSelected.Colour


        End Select
        lblAddress.Text = CarSelected.Address
        Total_cost.price_booking = CarSelected.totalPrice 'to append the information into the total cost public class for payment details
        lblUserPhone.Text = UserDetails.UserPhoneNum
        lblStatus.Text = confirmation
        btnConfirm.Enabled = True

    End Sub

    Private Sub carRentConfirmation_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        lblBrand.Text = ""
        lblPlateNumber.Text = ""
        lblPickUpDate.Text = ""
        lblReturn.Text = ""
        lblPrice.Text = ""
        lblAddress.Text = ""
        lblStatus.Text = ""
        lblUserPhone.Text = ""
    End Sub
End Class