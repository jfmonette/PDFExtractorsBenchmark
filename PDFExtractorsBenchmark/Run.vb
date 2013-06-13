Public Class Run
    Public Property LibraryName As String
    Public Property NumberOfDocumentsProcessed As Integer
    Public Property ProcessingTime As TimeSpan

    Sub New(ByVal libraryName As String, ByVal numberOfDocumentsProcessed As Integer, ByVal processingTime As TimeSpan)
        Me.LibraryName = libraryName
        Me.NumberOfDocumentsProcessed = numberOfDocumentsProcessed
        Me.ProcessingTime = processingTime
    End Sub
End Class
