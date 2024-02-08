
Imports OMC2.UserDetails
Public Class ReportPage
    Dim rating As String
    Dim report As System.IO.StreamWriter
    Dim userReport As String

    Private Sub ReportPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        report = New System.IO.StreamWriter("C:\Users\USer\Desktop\fonts\OMC2\AA_TROVA REPORT.txt", True)
        grbREPORT.Visible = False

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        grbREPORT.Visible = True
        Dim category As String = cboReport.SelectedItem
        lblName.Text = UserDetails.UserName
        lblReportCategory.Text = category
        lblDetails.Text = RichTextBox1.Text
        lblRating.Text = rating
        userReport = UserDetails.UserName + "," + category + "," + rating + "," + RichTextBox1.Text
        report.WriteLine(userReport)
        report.Close()


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        MsgBox("Are you sure want to submit the report?", MsgBoxStyle.Question, "Operator")
        If vbOK Then
            main_page_user.Show()
            Me.Hide()

        End If
    End Sub


    Private Sub pcb4_Click(sender As Object, e As EventArgs) Handles pcb4.Click
        pcb1.BackColor = Color.Yellow
        pcb2.BackColor = Color.Yellow
        pcb3.BackColor = Color.Yellow
        pcb4.BackColor = Color.Yellow

        pcb1.Enabled = False
        pcb2.Enabled = False
        pcb3.Enabled = False
        pcb5.Enabled = False

        rating = "4 Stars"
        lblReportCategory.Text = rating
    End Sub

    Private Sub pcb3_Click(sender As Object, e As EventArgs) Handles pcb3.Click
        pcb1.BackColor = Color.Yellow
        pcb2.BackColor = Color.Yellow
        pcb3.BackColor = Color.Yellow

        pcb1.Enabled = False
        pcb2.Enabled = False
        pcb4.Enabled = False
        pcb5.Enabled = False


        rating = "3 Stars"
        lblReportCategory.Text = rating
    End Sub

    Private Sub pcb2_Click(sender As Object, e As EventArgs) Handles pcb2.Click
        pcb1.BackColor = Color.Yellow
        pcb2.BackColor = Color.Yellow

        pcb1.Enabled = False
        pcb3.Enabled = False
        pcb4.Enabled = False
        pcb5.Enabled = False

        rating = "2 Stars"
        lblReportCategory.Text = rating
    End Sub

    Private Sub pcb1_Click(sender As Object, e As EventArgs) Handles pcb1.Click
        pcb1.BackColor = Color.Yellow

        pcb3.Enabled = False
        pcb2.Enabled = False
        pcb4.Enabled = False
        pcb5.Enabled = False

        rating = "1 Stars"
        lblReportCategory.Text = rating
    End Sub

    Private Sub pcb5_Click(sender As Object, e As EventArgs) Handles pcb5.Click
        pcb1.BackColor = Color.Yellow
        pcb2.BackColor = Color.Yellow
        pcb3.BackColor = Color.Yellow
        pcb4.BackColor = Color.Yellow
        pcb5.BackColor = Color.Yellow

        pcb1.Enabled = False
        pcb2.Enabled = False
        pcb3.Enabled = False
        pcb4.Enabled = False

        rating = "5 Stars"
        lblReportCategory.Text = rating
    End Sub

    Private Sub pcbTopUp_Click(sender As Object, e As EventArgs) Handles pcbTopUp.Click
        Dim confirmation As String
        confirmation = MsgBox("You are in the middle of booking session. Do you want to leave this page?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "EXIT CONFIRMATION")
        If confirmation = MsgBoxResult.Yes Then
            Call trovaPayPayment.trovPayIcon()
            Me.Hide()
        End If


    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim confirmation As String
        confirmation = MsgBox("You are in the middle of report session. Do you want to leave this page?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "EXIT CONFIRMATION")
        If confirmation = MsgBoxResult.Yes Then
            main_page_user.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub pcbPlaces_Click(sender As Object, e As EventArgs) Handles pcbPlaces.Click
        Dim confirmation As String
        confirmation = MsgBox("You are in the middle of report session. Do you want to leave this page?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "EXIT CONFIRMATION")
        If confirmation = MsgBoxResult.Yes Then
            booking.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub pcbProfile_Click(sender As Object, e As EventArgs) Handles pcbProfile.Click
        Dim confirmation As String
        confirmation = MsgBox("You are in the middle of report session. Do you want to leave this page?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "EXIT CONFIRMATION")
        If confirmation = MsgBoxResult.Yes Then
            UserProfile.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub
End Class