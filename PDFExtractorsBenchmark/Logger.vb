Imports System.Text

Public Class Logger
    Public Sub Log(ByVal run As Run)
        Dim logEntry As String = Me.GetLogEntry(run)
        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.CurrentDirectory + "\PDFExtractorsBenchmarkLog.txt", logEntry, True)
    End Sub

    Private Function GetLogEntry(ByVal run As Run) As String
        Dim logEntry As New StringBuilder()
        logEntry.Append("Library name : ")
        logEntry.Append(run.LibraryName)
        logEntry.Append(" // Number of documents processed : ")
        logEntry.Append(run.NumberOfDocumentsProcessed)
        logEntry.Append(" // Processing time : ")
        logEntry.Append(run.ProcessingTime)
        logEntry.AppendLine()

        Return logEntry.ToString()
    End Function
End Class
