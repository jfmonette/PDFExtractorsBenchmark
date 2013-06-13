Imports BitMiracle.Docotic.Pdf
Imports System.IO

Public Class Docotic
    Implements Extractor

    Public Sub Extract(ByVal filename As String) Implements Extractor.Extract
        Using pdf As New PdfDocument(filename)

            Dim documentTextFile As String = "Docotic - ExtractedText.txt"
            Using writer As New StreamWriter(documentTextFile)
                writer.Write(pdf.GetText())
            End Using
        End Using
    End Sub
End Class
