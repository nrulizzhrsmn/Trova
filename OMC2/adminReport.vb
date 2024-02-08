Public Class adminReport
    Private Sub pcbHome_Click(sender As Object, e As EventArgs) Handles pcbHome.Click
        admin_mainPage.Show()
        Me.Close()

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim readData As System.IO.StreamReader 'to read from text file
        Dim rec, strRec() As String
        lstReport.Items.Clear() 'to ensure the list is clear

        readData = New System.IO.StreamReader("C:\Users\USer\Desktop\fonts\OMC2\AA_TROVA REPORT.txt")
        Do Until (readData.Peek = -1) 'to read until there is no information
            rec = readData.ReadLine
            strRec = rec.Split(",") ' to make the infomation written like in a table
            lstReport.Items.Add(strRec(0) & vbTab & vbTab & strRec(1) & vbTab & vbTab & vbTab & strRec(2) & vbTab & vbTab & vbTab & strRec(3))
        Loop
        readData.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        admin_mainPage.Show()
        lstReport.Items.Clear()
        Me.Close()
    End Sub
End Class