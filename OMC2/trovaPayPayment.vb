Public Class trovaPayPayment
    Public Shared value As Double
    Public Shared amount As Double


    Public Shared Sub topUp(a)
        amount += a

    End Sub

    Public Shared Sub deduction(b)
        amount -= b
    End Sub


    Public Shared Sub trovPayIcon()
        Dim result As String

        result = MsgBox("you have RM" & trovaPayPayment.amount & " in TrovaPay." & vbLf & "Do you want to Top Up?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "TOP UP TROVAPAY")
        If result = MsgBoxResult.Yes Then
            TrovaPayTopUp.Show()
            'main_page_user.Show()
        End If
    End Sub

    Public Shared Function TrovaTopUpMiddle()
        TrovaPayTopUp.Show()

    End Function



End Class
