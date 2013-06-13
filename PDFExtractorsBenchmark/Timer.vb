Public Class Timer
    Private Property StartTime As DateTime
    Private Property StopTime As DateTime

    Public Sub StartTimer()
        Me.StartTime = DateAndTime.Now
    End Sub

    Public Sub StopTimer()
        Me.StopTime = DateAndTime.Now
    End Sub

    Public Function GetElapsedTime() As TimeSpan
        Return StopTime - StartTime
    End Function
End Class
