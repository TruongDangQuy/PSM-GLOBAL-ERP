Imports Spire.Barcode
Imports System.Net
Imports System.IO
Imports FarPoint.Excel
Imports System.Diagnostics
Imports Microsoft.Office.Interop.Excel

Public Class PFW74110

#Region "Variable"
    Protected prg As E_PRG
    Private Dsu01 As Long
    Private Form_Close As Boolean

    Private CheckChild As Boolean = False
    Private StrSchild As String
#End Region

#Region "Formload"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False, WordConv("INSERT") & "(F5)")

        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()

    End Sub

    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub

    Private Sub FORM_INIT()

    End Sub
    Private Sub DATA_INIT()
        Try
            If Me.PeaceFormType.Contains("_") Then
                Select Case Strings.Right(Me.PeaceFormType, 3)

                End Select

            End If

        Catch ex As Exception

        End Try



    End Sub

#End Region

#Region "Link_ISUD"
    Overrides Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey
                Case Keys.F5 : Call MAIN_JOB01()
                Case Keys.F6 : Call MAIN_JOB02()
                Case Keys.F7 : Call MAIN_JOB03()
                Case Keys.F8 : Call MAIN_JOB04()
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click, tst_5.Click, tst_6.Click
        If sender.Equals(tst_1) Then
            MAIN_JOB01()
        End If
        If sender.Equals(tst_2) Then
            MAIN_JOB02()
        End If
        If sender.Equals(tst_3) Then
            MAIN_JOB03()
        End If
        If sender.Equals(tst_4) Then
            MAIN_JOB04()
        End If
    End Sub

    Private Sub MAIN_JOB01()   ' Insert

    End Sub
    Private Sub MAIN_JOB02()   ' Insert

    End Sub
    Private Sub MAIN_JOB03()   ' Insert

    End Sub
    Private Sub MAIN_JOB04()   ' Insert

    End Sub

#End Region

#Region "PFP_SEARCH"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        Vs10.Enabled = False

        DS1 = PrcDS("PSM_USP_PFW74110_SEARCH_VS10", cn)

        If GetDsRc(DS1) = 0 Then
            Vs10.Enabled = True
            Vs10.ActiveSheet.RowCount = 0
            Exit Function
        End If

        SPR_PRO_NEW(Vs10, DS1, "PSM_USP_PFW74110_SEARCH_VS10", "Vs10")

        For iRow As Integer = 0 To Vs10.ActiveSheet.RowCount - 1
            Vs10.ActiveSheet.Rows(iRow).Height = 120
            Vs10.ActiveSheet.Columns(getColumIndex(Vs10, "QRCode")).Width = 120
        Next




        Vs10.Enabled = True

    End Function

    Private Function ReadFile(ByVal sPath As String) As Byte()

        'Initialize byte array with a null value initially. 
        Dim data As Byte() = Nothing

        'Use FileInfo object to get file size. 
        Dim fInfo As New FileInfo(sPath)
        Dim numBytes As Long = fInfo.Length

        'Open FileStream to read file 
        Dim fStream As New FileStream(sPath, FileMode.Open, FileAccess.Read)

        'Use BinaryReader to read file stream into byte array. 
        Dim br As New BinaryReader(fStream)

        'When you use BinaryReader, you need to supply number of bytes to read from file. 
        'In this case we want to read entire file. So supplying total number of bytes. 
        data = br.ReadBytes(CInt(numBytes))

        br.Dispose()
        fStream.Dispose()

        Return data
    End Function

    Private Function AUTOUPDATEIMAGE() As Boolean

        AUTOUPDATEIMAGE = False

        Dim SqlCom As System.Data.SqlClient.SqlCommand
        Dim _ds1 As DataSet
        Dim _ds2 As DataSet

        _ds2 = PrcDS("PSM_USP_PFW74110_SEARCH_QRCode", cn)

        Dim _IDNO As String = ""
        Dim _IDCard As String = ""
        Dim settings As BarcodeSettings = New BarcodeSettings()
        BarcodeSettings.ApplyKey("0H8YP-M0FO1-9O9ZJ-441BF-WJ1NA")

        'Dim iColIDNO As Integer = 0
        'Dim iColIDCard As Integer = 0
        'iColIDNO = DS1.Tables(0).Columns.IndexOf("IDNO")
        'iColIDNO = DS1.Tables(0).Columns.IndexOf("IDCard")

        For iRow As Integer = 0 To _ds2.Tables(0).Rows.Count - 1
            _IDNO = GetDsData(_ds2, iRow, "IDNO")
            _IDCard = GetDsData(_ds2, iRow, "IDCard")

            _ds1 = PrcDS("PSM_USP_PFW74110_SEARCH_QRCode_CheckData", cn, _IDNO, _IDCard)

            If _ds1.Tables(0).Rows(0)("IsInsert") = "1" Then
                If String.IsNullOrWhiteSpace(_IDCard) = False Then
                    _IDCard = _IDCard.Trim
                    Dim barc As New FarPoint.Win.Spread.CellType.BarCodeCellType

                    settings.Type = BarCodeType.QRCode
                    settings.Unit = GraphicsUnit.Pixel
                    settings.ShowText = False
                    settings.ResolutionType = ResolutionType.UseDpi
                    settings.Data = _IDCard

                    settings.ForeColor = Color.Black
                    settings.BackColor = Color.White
                    settings.QRCodeECL = QRCodeECL.L
                    settings.LeftMargin = 10
                    settings.RightMargin = 10
                    settings.BottomMargin = 10
                    settings.TopMargin = 10
                    settings.X = 10
                    'settings.BarHeight = Height_Qrcode
                    settings.ResolutionType = ResolutionType.UseDpi
                    settings.DpiX = 96
                    settings.DpiY = 96

                    Dim generator As BarCodeGenerator = New BarCodeGenerator(settings)
                    Dim QRbarcode As Image = generator.GenerateImage

                    Dim Path As String = App_Path & "\QRCode"

                    If System.IO.Directory.Exists(Path) = False Then
                        System.IO.Directory.CreateDirectory(Path)
                    End If

                    Path = Path & "\" & _IDCard & ".png"

                    QRbarcode.Save(Path)

                    Dim dataimage As Byte() = Nothing

                    dataimage = ReadFile(Path)

                    Dim qry As String = ""
                    qry = "INSERT INTO PFW9999_QRCode( W9999_IDNO, W9999_IDCard, W9999_FileName, W9999_ImageData, W9999_FileType)" & _
                         " VALUES( @IDNO, @IDCard, @FileName, @ImageData, @FileType)"

                    'Initialize SqlCommand object for insert. 
                    SqlCom = New System.Data.SqlClient.SqlCommand(qry, cn)

                    SqlCom.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IDNO", _IDNO))
                    SqlCom.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IDCard", _IDCard))
                    SqlCom.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FileName", _IDCard))
                    SqlCom.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ImageData", DirectCast(dataimage, Object)))
                    SqlCom.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FileType", "png"))

                    SqlCom.ExecuteNonQuery()

                    System.IO.File.Delete(Path)

                End If
            End If


        Next

        Vs10.Enabled = True

    End Function
#End Region

#Region "EVENT"

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        If DATA_SEARCH01() = True Then
        End If
    End Sub

    Private Sub cmd_QRCode_Click(sender As Object, e As EventArgs) Handles cmd_QRCode.Click
        If AUTOUPDATEIMAGE() = True Then
        End If
    End Sub

#End Region

End Class