Module PDFExtractorsBenchmark

    Private extractors As New List(Of Extractor) From {New TET()}
    Private pdfFile As New String(My.Computer.FileSystem.CurrentDirectory + "\Test.pdf")
    Private numberOfTimesToProcessFile As Integer = 200
    Private timer As New Timer()
    Dim logger As New Logger()

    Sub Main()
        For Each extractorItem As Extractor In extractors
            timer.StartTimer()
            For index = 1 To numberOfTimesToProcessFile
                extractorItem.Extract(pdfFile)
            Next
            timer.StopTimer()
            logger.Log(New Run(extractorItem.GetType.ToString, numberOfTimesToProcessFile, timer.GetElapsedTime))
        Next
    End Sub

End Module
