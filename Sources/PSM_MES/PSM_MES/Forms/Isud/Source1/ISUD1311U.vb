Imports DevExpress.Pdf

Imports System.Drawing

Public Class ISUD1311U
#Region "Variable"
    Private wJOB As Integer


    Private W7325 As T7325_AREA
    Private L7325 As T7325_AREA

    Private W7326 As T7326_AREA
    Private L7326 As T7326_AREA

    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String

    Private W1311 As T1311_AREA
    Private W7106 As T7106_AREA

    Private LLine As New List(Of T1312_AREA)
    Private LLineSize As New List(Of T1313_AREA)

    Private Enum OrderBase
        PONO = 0
        PODATE = 1
        SEASON = 2
        CUSTOMER = 3
        FCUSTNO = 4
        JOBCARDNO = 5
        SEALNO = 6
        DEST = 7
        BUYER = 8
        TTL = 9
        HANGTAG = 10
        ARTNO = 11
        MCODE = 12
        CCODE = 13
        COLORNAME = 14
        LSD = 15
        CFMXFACDATE = 16
        GENDER = 17
        SIZERUN = 18
        CTRY = 19
        LINE = 20
        REMARK = 21
        TTLPRS = 22
        TTCTONS = 23
        PRSCTON = 24
        SZ01 = 25
        QT01 = 26
        SZ02 = 27
        QT02 = 28
        SZ03 = 29
        QT03 = 30
        SZ04 = 31
        QT04 = 32
        SZ05 = 33
        QT05 = 34
        SZ06 = 35
        QT06 = 36
        SZ07 = 37
        QT07 = 38
        SZ08 = 39
        QT08 = 40
        SZ09 = 41
        QT09 = 42
        SZ10 = 43
        QT10 = 44
        SZ11 = 45
        QT11 = 46
        SZ12 = 47
        QT12 = 48
        SZ13 = 49
        QT13 = 50
        SZ14 = 51
        QT14 = 52
        SZ15 = 53
        QT15 = 54
        SZ16 = 55
        QT16 = 56
        SZ17 = 57
        QT17 = 58
        SZ18 = 59
        QT18 = 60
        SZ19 = 61
        QT19 = 62
        SZ20 = 63
        QT20 = 64
        SZ21 = 65
        QT21 = 66
        SZ22 = 67
        QT22 = 68
        SZ23 = 69
        QT23 = 70
        SZ24 = 71
        QT24 = 72
        SZ25 = 73
        QT25 = 74
        SZ26 = 75
        QT26 = 76
        SZ27 = 77
        QT27 = 78
        SZ28 = 79
        QT28 = 80
        SZ29 = 81
        QT29 = 82
        SZ30 = 83
        QT30 = 84
    End Enum
#End Region

#Region "Link"
    Public Function Link_ISUD1311U(ByRef _Header As Object, ByRef _Line As Object, ByRef _Size As Object) As Boolean
        Me.Tag = Tag
        Link_ISUD1311U = False
        _Header = Nothing
        _Line = Nothing
        _Size = Nothing

        Try
            formA = False
            Me.ShowDialog()

            Link_ISUD1311U = isudCHK

            _Header = W1311
            _Line = LLine
            _Size = LLineSize

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("ProcessBOMCode"))
        End Try


    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_KeyDown()

        Call DATA_INIT()
        Call FORM_INIT()

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Try

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()

    End Sub
#End Region

#Region "Data_Search"

#End Region

#Region "Function"

#End Region

#Region "Event"
    Private Sub Header()
        W1311.DateAccept = getDataCSV(Vs1, OrderBase.PODATE, 1)

        If READ_PFK7171_NAME(ListCode("Season"), getDataCSV(Vs1, OrderBase.SEASON, 1)) Then
            W1311.seSeason = D7171.BasicSel
            W1311.cdSeason = D7171.BasicCode
        End If

        If READ_PFK7101_SIMPLENAME(getDataCSV(Vs1, OrderBase.CUSTOMER, 1)) Then
            W1311.CustomerCode = D7101.CustomerCode
        End If

        W1311.DateOrder = getDataCSV(Vs1, OrderBase.PODATE, 1)
        W1311.Buyer = getDataCSV(Vs1, OrderBase.BUYER, 1)

        If IsDate(W1311.DateAccept) Then
            W1311.DateAccept = FormatDateP(CDate(W1311.DateAccept))
            W1311.DateOrder = W1311.DateAccept
            W1311.DateInsert = Pub.DAT
        Else
            W1311.DateAccept = Pub.DAT
            W1311.DateOrder = Pub.DAT
            W1311.DateInsert = Pub.DAT
        End If

    End Sub
    Private Sub KEY_COUNT()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader


        SQL = "SELECT MAX(CAST(K7106_ShoesCode AS DECIMAL)) AS MAX_CODE FROM PFK7106 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            W7106.ShoesCode = "000001"
        Else
            W7106.ShoesCode = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If


        rd.Close()
    End Sub
    Private Function Line() As Boolean
        Line = False

        Try
            Dim i As Integer

            For i = 1 To Vs1.ActiveSheet.RowCount - 1
                D1312.cdSpecStatus = "002"
                D1312.seSpecStatus = ListCode("SpecStatus")

                D7106.cdSpecState = "004"
                D7106.Article = getDataCSV(Vs1, OrderBase.ARTNO, i)
                D7106.Line = getDataCSV(Vs1, OrderBase.LINE, i)
                D7106.ColorCode = getDataCSV(Vs1, OrderBase.CCODE, i)
                D7106.cdSeason = getDataCSV(Vs1, OrderBase.SEASON, i)


                If READ_PFK7106_1(D7106.cdSeason, D7106.cdSpecState, D7106.Article, D7106.Line, D7106.ColorCode) = False Then
                    W7106.cdSpecState = "004"
                    W7106.Article = getDataCSV(Vs1, OrderBase.ARTNO, i)
                    W7106.Line = getDataCSV(Vs1, OrderBase.LINE, i)

                    W7106.ColorName = getDataCSV(Vs1, OrderBase.COLORNAME, i)

                    W7106.ColorCode = getDataCSV(Vs1, OrderBase.CCODE, i)
                    W7106.MCODE = getDataCSV(Vs1, OrderBase.MCODE, i)

                    W7106.Customercode = W1311.CustomerCode
                    W7106.seSeason = W1311.seSeason
                    W7106.cdSeason = W1311.cdSeason

                    W7106.seGender = ListCode("Gender")
                    W7106.seSeason = ListCode("Season")
                    W7106.seSpecState = ListCode("SpecState")

                    W7106.CheckUse = "2"

                    Call KEY_COUNT()
                    Call WRITE_PFK7106(W7106)
                End If

                If READ_PFK7106_1(D7106.cdSeason, D7106.cdSpecState, D7106.Article, D7106.Line, D7106.ColorCode) = True Then
                    D1312.ShoesCode = D7106.ShoesCode
                End If

                D1312.TotalQty = getDataCSV(Vs1, OrderBase.TTL, i)

                D1312.Datedelivery = getDataCSV(Vs1, OrderBase.LSD, i)

                If IsDate(D1312.Datedelivery) Then
                    D1312.Datedelivery = FormatDateP(D1312.Datedelivery)
                Else
                    D1312.Datedelivery = ""
                End If

                D1312.DateOrder = W1311.DateOrder
                D1312.DateInsert = Pub.DAT

                D1313.SizeQty01 = CDecp(getDataCSV(Vs1, OrderBase.QT01, i))
                D1313.SizeQty02 = CDecp(getDataCSV(Vs1, OrderBase.QT02, i))
                D1313.SizeQty03 = CDecp(getDataCSV(Vs1, OrderBase.QT03, i))
                D1313.SizeQty04 = CDecp(getDataCSV(Vs1, OrderBase.QT04, i))
                D1313.SizeQty05 = CDecp(getDataCSV(Vs1, OrderBase.QT05, i))
                D1313.SizeQty06 = CDecp(getDataCSV(Vs1, OrderBase.QT06, i))
                D1313.SizeQty07 = CDecp(getDataCSV(Vs1, OrderBase.QT07, i))
                D1313.SizeQty08 = CDecp(getDataCSV(Vs1, OrderBase.QT08, i))
                D1313.SizeQty09 = CDecp(getDataCSV(Vs1, OrderBase.QT09, i))
                D1313.SizeQty10 = CDecp(getDataCSV(Vs1, OrderBase.QT10, i))
                D1313.SizeQty11 = CDecp(getDataCSV(Vs1, OrderBase.QT11, i))
                D1313.SizeQty12 = CDecp(getDataCSV(Vs1, OrderBase.QT12, i))
                D1313.SizeQty13 = CDecp(getDataCSV(Vs1, OrderBase.QT13, i))
                D1313.SizeQty14 = CDecp(getDataCSV(Vs1, OrderBase.QT14, i))
                D1313.SizeQty15 = CDecp(getDataCSV(Vs1, OrderBase.QT15, i))
                D1313.SizeQty16 = CDecp(getDataCSV(Vs1, OrderBase.QT16, i))
                D1313.SizeQty17 = CDecp(getDataCSV(Vs1, OrderBase.QT17, i))
                D1313.SizeQty18 = CDecp(getDataCSV(Vs1, OrderBase.QT18, i))
                D1313.SizeQty19 = CDecp(getDataCSV(Vs1, OrderBase.QT19, i))
                D1313.SizeQty20 = CDecp(getDataCSV(Vs1, OrderBase.QT20, i))
                D1313.SizeQty21 = CDecp(getDataCSV(Vs1, OrderBase.QT21, i))
                D1313.SizeQty22 = CDecp(getDataCSV(Vs1, OrderBase.QT22, i))
                D1313.SizeQty23 = CDecp(getDataCSV(Vs1, OrderBase.QT23, i))
                D1313.SizeQty24 = CDecp(getDataCSV(Vs1, OrderBase.QT24, i))
                D1313.SizeQty25 = CDecp(getDataCSV(Vs1, OrderBase.QT25, i))
                D1313.SizeQty26 = CDecp(getDataCSV(Vs1, OrderBase.QT26, i))
                D1313.SizeQty27 = CDecp(getDataCSV(Vs1, OrderBase.QT27, i))
                D1313.SizeQty28 = CDecp(getDataCSV(Vs1, OrderBase.QT28, i))
                D1313.SizeQty29 = CDecp(getDataCSV(Vs1, OrderBase.QT29, i))
                D1313.SizeQty30 = CDecp(getDataCSV(Vs1, OrderBase.QT30, i))

                LLine.Add(D1312)
                LLineSize.Add(D1313)

                Line = True
            Next

        Catch ex As Exception

        End Try

    End Function

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Call Header()
        If Line() = True Then
            isudCHK = True
            WRITE_CHK = "*"
        End If
        Me.Dispose()
    End Sub

    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub
    Private Function GetOpenFileDialog() As OpenFileDialog

        Dim openFileDialog As New OpenFileDialog

        openFileDialog.CheckFileExists = True
        openFileDialog.Multiselect = False
        openFileDialog.AddExtension = True
        openFileDialog.ValidateNames = True
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        Return openFileDialog


    End Function
    'Private Sub txt_cdBaseBOM_Load(sender As Object, e As EventArgs) Handles txt_cdBaseBOM.btnTitleClick
    '    Try

    '        Using OpenFileDialog As OpenFileDialog = Me.GetOpenFileDialog()

    '            'Open the File Dialog to select the file
    '            If (OpenFileDialog.ShowDialog(Me) = DialogResult.OK) Then
    '                If IO.Path.GetExtension(OpenFileDialog.FileName).ToUpper = ".CSV" Then
    '                    Dim strEx As String
    '                    strEx = IO.Path.GetExtension(OpenFileDialog.FileName).ToUpper

    '                    Vs1.Reset()
    '                    Vs1.DataSource = ReadCSV(OpenFileDialog.FileName)

    '                Else
    '                    Vs1.OpenExcel(OpenFileDialog.FileName)
    '                End If



    '            Else 'Cancel

    '                Exit Sub

    '            End If

    '        End Using


    '    Catch ex As Exception

    '    End Try
    'End Sub
  
    Private Sub txt_cdBaseBOM_Load(sender As Object, e As EventArgs) Handles txt_cdBaseBOM.btnTitleClick
        Try
            Dim ListDs As New List(Of String)
            Using OpenFileDialog As OpenFileDialog = Me.GetOpenFileDialog()

                'Open the File Dialog to select the file
                If (OpenFileDialog.ShowDialog(Me) = DialogResult.OK) Then
                    If IO.Path.GetExtension(OpenFileDialog.FileName).ToUpper = ".PDF" Then

                        Using documentProcessor As New PdfDocumentProcessor()
                            documentProcessor.LoadDocument(OpenFileDialog.FileName)

                            ListDs.AddRange(documentProcessor.Text.Split(Chr(13)))



                            Vs1.Reset()
                            Vs1.DataSource = documentProcessor.Text ' ReadCSV(OpenFileDialog.FileName)
                        End Using

                      

                    Else
                        Vs1.OpenExcel(OpenFileDialog.FileName)
                    End If



                Else 'Cancel

                    Exit Sub

                End If

            End Using


        Catch ex As Exception

        End Try
    End Sub

    Function ReadCSV(ByVal path As String) As System.Data.DataTable

        Try

            Dim sr As New System.IO.StreamReader(path)

            Dim fullFileStr As String = sr.ReadToEnd()

            sr.Close()

            sr.Dispose()

            Dim lines As String() = fullFileStr.Split(ControlChars.Lf)

            Dim recs As New System.Data.DataTable()

            Dim sArr As String() = lines(0).Split(","c)

            For Each s As String In sArr

                recs.Columns.Add(New DataColumn())

            Next

            Dim row As DataRow

            Dim finalLine As String = ""

            For Each line As String In lines

                row = recs.NewRow()

                finalLine = line.Replace(Convert.ToString(ControlChars.Cr), "")

                row.ItemArray = finalLine.Split(","c)

                recs.Rows.Add(row)

            Next

            Return recs

        Catch ex As Exception

            Throw ex

        End Try

    End Function
#End Region

End Class