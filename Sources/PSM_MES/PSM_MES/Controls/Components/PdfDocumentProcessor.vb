Imports DevExpress.Pdf
Imports System.Drawing

Namespace DocumentCreationAPI
    Class Program

        Private Shared Sub Main(args As String())

            Using processor As New PdfDocumentProcessor()
                ' Create an empty document using PDF creation options.
                processor.CreateEmptyDocument("..\..\Result.pdf")

                ' Create and draw PDF graphics.
                Using graph As PdfGraphics = processor.CreateGraphics()
                    DrawGraphics(graph)

                    ' Render a page with graphics.
                    processor.RenderNewPage(PdfPaperSize.Letter, graph)
                End Using
            End Using
        End Sub

        Private Shared Sub DrawGraphics(graph As PdfGraphics)
            ' Draw an image on the page. 
            Using image As New Bitmap("..\..\DevExpress.png")
                Dim width As Single = image.Width
                Dim height As Single = image.Height
                graph.DrawImage(image, New RectangleF(20, 40, width / 2, height / 2))
            End Using

            ' Draw text lines on the page. 
            Dim black As SolidBrush = DirectCast(Brushes.Black, SolidBrush)
            Using font1 As New Font("Times New Roman", 32, FontStyle.Bold)
                graph.DrawString("PDF Document Processor", font1, black, 180, 150)
            End Using
            Using font2 As New Font("Arial", 20)
                graph.DrawString("Display, Print and Export PDF Documents", font2, black, 168, 230)
            End Using
            Using font3 As New Font("Arial", 10)
                graph.DrawString("The PDF Document Processor is a non-visual component " & "that provides the application programming interface of the PDF Viewer.", font3, black, 16, 300)
            End Using
        End Sub
    End Class
End Namespace