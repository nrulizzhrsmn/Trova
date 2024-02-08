Public Class driverStatus
    Public Shared present As String

    Public Shared Sub Available()
        present = "available as a driver "
    End Sub

    Public Shared Sub NotAvailable()
        present = "unavailable as a driver "
    End Sub
End Class
