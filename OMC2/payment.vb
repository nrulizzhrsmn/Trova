Imports OMC2.Total_cost
Public Class payment

    Private Sub txtCardNumber_TextChanged(sender As Object, e As EventArgs)
        txtCardNumber.AutoSize = False
        txtCardNumber.Height = 37


    End Sub
    'show certain textbox and label for selected payment method
    Private Sub rbtOnline_Banking_CheckedChanged(sender As Object, e As EventArgs) Handles rbtOnline_Banking.CheckedChanged
        If rbtOnline_Banking.Checked = True Then
            lbl1.Text = "Bank Name"
            lbl1.Visible = True
            cboBank_Name.Visible = True

            lbl2.Text = "Type of Account"
            lbl2.Visible = True
            cboAccount_Type.Visible = True

            lbl3.Text = "Account Number"
            lbl3.Visible = True
            txtAccount_Number.Visible = True

            lbl4.Text = "Account Username"
            lbl4.Visible = True
            txtAccount_Username.Visible = True



        Else
            lbl1.Text = ""
            lbl2.Text = ""
            lbl3.Text = ""
            lbl4.Text = ""
            cboBank_Name.Visible = False
            txtAccount_Number.Visible = False
            txtAccount_Username.Visible = False
            cboAccount_Type.Visible = False


        End If
    End Sub

    Private Sub rbtCreditDebit_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCreditDebit.CheckedChanged

        If rbtCreditDebit.Checked = True Then
            lbl1.Text = "Type of Card"
            lbl1.Visible = True
            cboTypes_Card.Visible = True

            lbl2.Text = "Card Number"
            lbl2.Visible = True
            txtCardNumber.Visible = True

            lbl3.Text = "Expired Date"
            lbl3.Visible = True
            mskExpired_Card.Visible = True

            lbl4.Text = "CW2/CVC2"
            lbl4.Visible = True
            txtCW2_CVC2.Visible = True

        Else
            lbl1.Text = ""
            lbl2.Text = ""
            lbl3.Text = ""
            lbl4.Text = ""
            cboTypes_Card.Visible = False
            txtCardNumber.Visible = False
            mskExpired_Card.Visible = False
            txtCW2_CVC2.Visible = False


        End If
    End Sub


    Private Sub rbtEWallet_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbtTrovaPay.CheckedChanged

        If rbtTrovaPay.Checked = True Then

            lbl3.Text = "Phone Number"
            lbl3.Visible = True
            txtPhone_Number.Visible = True

            lbl4.Text = "Username"
            lbl4.Visible = True
            txtUsername.Visible = True

            pcbTrova.Visible = True

        Else
            lbl1.Text = ""
            lbl2.Text = ""
            lbl3.Text = ""
            lbl4.Text = ""
            txtUsername.Visible = False
            txtPhone_Number.Visible = False
            pcbTrova.Visible = False


        End If
    End Sub

    Private Sub rbtCashCOD_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCashCOD.CheckedChanged

        If rbtCashCOD.Checked = True Then

            lbl3.Text = "Phone Number"
            lbl3.Visible = True
            txtPhoneNum_COD.Visible = True

            lbl4.Text = "Address"
            lbl4.Visible = True
            txtAddress.Visible = True

            pcbTrova.Visible = True

        Else

            lbl3.Text = ""
            lbl4.Text = ""
            txtAddress.Visible = False
            txtPhoneNum_COD.Visible = False
            pcbTrova.Visible = False



        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'error checking

        If rbtCashCOD.Checked = True Then
            If txtPhoneNum_COD.Text = "" OrElse txtAddress.Text = "" Then
                MsgBox("please complete the required information", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "INCOMPLETE INFORMATION")
            Else
                phone_number_cod = txtPhoneNum_COD.Text
                COD_Cash.Show()
                Me.Hide()
            End If

        ElseIf rbtCreditDebit.Checked = True Then
            If cboTypes_Card.SelectedIndex = -1 OrElse txtCardNumber.Text = "" OrElse mskExpired_Card.Text = "" OrElse txtCW2_CVC2.Text = "" Then
                MsgBox("please complete the required information", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "INCOMPLETE INFORMATION")
            Else
                from_cardnumber = txtCardNumber.Text
                CreditDebit.Show()
                Me.Hide()
            End If
        ElseIf rbtTrovaPay.Checked = True Then
            If txtPhone_Number.Text = "" OrElse txtUsername.Text = "" Then
                MsgBox("please complete the required information", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "INCOMPLETE INFORMATION")
            Else
                from_phone = txtPhone_Number.Text
                from_username = txtUsername.Text
                TrovaPay.Show()
                Me.Hide()
            End If
        ElseIf rbtOnline_Banking.Checked = True Then
            If cboBank_Name.SelectedIndex = -1 OrElse cboAccount_Type.SelectedIndex = -1 OrElse txtAccount_Number.Text = "" OrElse txtAccount_Username.Text = "" Then
                MsgBox("please complete the required information", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "INCOMPLETE INFORMATION")
            Else
                bank_account = cboBank_Name.SelectedItem
                from_account = txtAccount_Number.Text
                Online_Banking.Show()
                Me.Hide()
            End If
        End If
    End Sub


    Private Sub payment_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        txtAccount_Number.Clear()
        txtAccount_Username.Clear()
        txtAddress.Clear()
        txtCardNumber.Clear()
        txtPhoneNum_COD.Clear()
        txtPhone_Number.Clear()
        txtUsername.Clear()
        txtCW2_CVC2.Clear()
        cboAccount_Type.SelectedIndex = -1
        cboBank_Name.SelectedIndex = -1
        cboTypes_Card.SelectedIndex = -1
        mskExpired_Card.Clear()

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "REVIEW")

    End Sub

    Private Sub pcbBooking_Click(sender As Object, e As EventArgs) Handles pcbBooking.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "REVIEW")

    End Sub

    Private Sub pcbPlaces_Click(sender As Object, e As EventArgs) Handles pcbPlaces.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "REVIEW")
    End Sub

    Private Sub pcbTopUp_Click(sender As Object, e As EventArgs) Handles pcbTopUp.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "REVIEW")
    End Sub

    Private Sub pcbSettings_Click(sender As Object, e As EventArgs) Handles pcbSettings.Click
        MsgBox("YOU HAVE MADE THE CONFIRMATION, PLEASE PROCEED", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "REVIEW")
    End Sub

End Class