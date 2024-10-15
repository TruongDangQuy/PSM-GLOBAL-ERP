Imports System.IO
Public Module M_G_FILE

#Region "Variable"

#End Region

#Region "Methods"
    Public Function READ_TO_STR(ByVal FileName As String) As String

        Dim FileNumber As Integer = 0
        Dim strText As String = ""

        Try

            If File.Exists(FileName) = False Then

                Return ""

            Else

                FileNumber = FreeFile()

                FileOpen(FileNumber, FileName, OpenMode.Input)

                Do Until EOF(FileNumber)

                    strText = strText + LineInput(FileNumber) + ControlChars.CrLf

                Loop

                FileClose(FileNumber)

                Return strText

            End If

        Catch ex As Exception



            Return ""

        End Try

    End Function
    Public Function WRITE_FROM_CBO(ByVal FileName As String, ByRef cbo As ComboBox) As Boolean

        Dim i As Integer
        Dim FileNumber As Integer
        Dim strText As String

        Try

            strText = cbo.Text

            For i = 1 To cbo.Items.Count

                If cbo.Items.Item(i - 1) = strText Then

                    Return False

                End If

            Next

            FileNumber = FreeFile()

            FileOpen(FileNumber, FileName, OpenMode.Append)

            For i = 1 To cbo.Items.Count

                WriteLine(FileNumber, cbo.Items.Item(i - 1))

            Next

            Return True

        Catch ex As Exception



            Return False

        End Try

    End Function
    Public Function READ_TO_CBO(ByVal FileName As String, ByRef cbo As ComboBox) As Boolean

        Dim FileNumber As Integer

        Try

            If File.Exists(FileName) = False Then

                Return False

            Else

                FileNumber = FreeFile()

                FileOpen(FileNumber, FileName, OpenMode.Input)

                Do Until EOF(FileNumber)

                    cbo.Items.Add(LineInput(FileNumber))

                Loop

                Return True

            End If

        Catch ex As Exception


            Return False

        End Try

    End Function
    Public Function CHK2CBO(ByVal FileName As String, ByRef cbo As ComboBox) As Boolean

        Dim FileNumber As Integer
        Dim strText As String = ""

        Try

            If File.Exists(FileName) = False Then

                Return False

            Else

                FileNumber = FreeFile()

                FileOpen(FileNumber, FileName, OpenMode.Input)

                Do Until EOF(FileNumber)

                    strText = strText + LineInput(FileNumber) + ControlChars.CrLf

                Loop

                cbo.SelectedIndex = CInt(strText) - 1

                Return True

            End If

        Catch ex As Exception


            Return False

        End Try

    End Function
#End Region

End Module
