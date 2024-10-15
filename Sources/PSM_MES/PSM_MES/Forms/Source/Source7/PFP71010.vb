Imports Spire.Barcode
Imports System.Net
Imports System.IO
Imports FarPoint.Excel
Imports System.Diagnostics
Imports Microsoft.Office.Interop.Excel
Public Class PFP71010
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Protected prg As E_PRG


    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INPUT") & "(F5)")
        Me.KeyPreview = True

        Dim xISUD7101B As String
        Dim xISUD7101P As String

        xISUD7101B = ISUD7101B.Text
        xISUD7101P = ISUD7101P.Text

        Call Cms_additem(Cms_1, xISUD7101B & "-" & WordConv("INPUT") & "(F5)",
                                xISUD7101B & "-" & WordConv("SEARCH") & "(F6)",
                                xISUD7101B & "-" & WordConv("UPDATE") & "(F7)",
                                xISUD7101B & "-" & WordConv("DELETE") & "(F8)")


        Vs1.ContextMenuStrip = Cms_1

        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub
    Overrides Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey
                Case Keys.F5 : Call MAIN_JOB01()
                Case Keys.F6 : Call MAIN_JOB02()
                Case Keys.F7 : Call MAIN_JOB03()
                Case Keys.F8 : Call MAIN_JOB04()
                Case Keys.F9 : Call MAIN_JOB05()
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FORM_INIT()
        chk_FSEL.CheckState = 1
        chk_FSEL.BackColor = clrCheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("CLOSE")
        ssp_WHERE.Visible = True
    End Sub

    Private Sub DATA_INIT()

    End Sub
#End Region

#Region "Function"
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
    Private Sub MAIN_JOB01()
        If ISUD7101B.Link_ISUD7101A(1, "000000", Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01()

    End Sub
    Private Sub MAIN_JOB02()
        If getData(Vs1, getColumIndex(Vs1, "Key_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub


        If ISUD7101B.Link_ISUD7101A(2, getData(Vs1, getColumIndex(Vs1, "Key_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

    End Sub
    Private Sub MAIN_JOB03()
        Dim xJOB As String

        xJOB = "3"
        If getData(Vs1, getColumIndex(Vs1, "Key_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If ISUD7101B.Link_ISUD7101A(xJOB, getData(Vs1, getColumIndex(Vs1, "Key_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub
        Call LINE_MOVE_DISPLAY01()

    End Sub
    Private Sub MAIN_JOB04()
        Dim xJOB As String

        If getData(Vs1, getColumIndex(Vs1, "Key_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        xJOB = "4"

        If ISUD7101B.Link_ISUD7101A(xJOB, getData(Vs1, getColumIndex(Vs1, "Key_CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub
        Call LINE_MOVE_DISPLAY01()

    End Sub
    Private Sub MAIN_JOB05()

    End Sub

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Dim xSort As String = "1"
        Vs1.Enabled = False

        If opt_SortName.Checked = True Then xSort = "1"
        If opt_SortCode.Checked = True Then xSort = "2"

        DS1 = PrcDS("USP_PFP71010_SEARCH_VS1_F1", cn, "*" & txt_GNAME.Data,
                                                    chk_CheckCustomer.CheckState,
                                                    chk_CheckSupplier.CheckState,
                                                    chk_CheckEmployee.CheckState,
                                                    chk_CheckInside.CheckState,
                                                    chk_CheckOutside.CheckState,
                                                    chk_CheckOther.CheckState,
                                                    rad_CheckCustomerStatus1.CheckState,
                                                    rad_CheckCustomerStatus2.CheckState,
                                                    rad_CheckCustomerStatus3.CheckState,
                                                    rad_CheckCustomerStatus4.CheckState,
                                                    rad_CheckCustomerStatus5.CheckState,
                                                    rad_CheckCustomerStatus6.CheckState,
                                                    chk_CheckUse1.CheckState,
                                                    chk_CheckUse2.CheckState, "1")

        If GetDsRc(DS1) = 0 Then
            Vs1.ActiveSheet.RowCount = 0
            Vs1.Enabled = True
            Exit Function
        End If
        SPR_PRO_NEW(Vs1, DS1, "USP_PFP71010_SEARCH_VS1_F1", "Vs1")
        DATA_SEARCH01 = True

        Vs1.Enabled = True
    End Function
    Private Function LINE_MOVE_DISPLAY01() As Boolean
        Dim CustomerCode As String
        Dim xrow As Integer
        LINE_MOVE_DISPLAY01 = False
        Try
            xrow = Vs1.ActiveSheet.ActiveRowIndex
            CustomerCode = getData(Vs1, getColumIndex(Vs1, "CustomerCode"), xrow)
            DS1 = PrcDS("USP_PFP71010_SEARCH_VS1_LINE", cn, CustomerCode)

            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If
            READ_SPREAD(Vs1, DS1, "USP_PFP71010_SEARCH_VS1_F1", "Vs1", xrow)

            LINE_MOVE_DISPLAY01 = True
        Catch ex As Exception

        End Try
    End Function
#End Region

#Region "Event"
    Private Sub Cms_1_Click(sender As Object, e As EventArgs) Handles Cms_1.ItemClicked
        Select Case True
            Case Cms_1.Items(0).Selected
                Cms_1.Hide()
                Call MAIN_JOB01()
            Case Cms_1.Items(1).Selected
                Cms_1.Hide()
                Call MAIN_JOB02()
            Case Cms_1.Items(2).Selected
                Cms_1.Hide()
                Call MAIN_JOB03()

            Case Cms_1.Items(3).Selected
                Cms_1.Hide()
                Call MAIN_JOB04()

            Case Cms_1.Items(5).Selected
                Cms_1.Hide()
                Call MAIN_JOB05()
        End Select
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If e.ColumnHeader = False Then
            Call MAIN_JOB02()
        End If
    End Sub

    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False, WordConv("INPUT") & "(F5)", WordConv("CHANGE") & "(F6)")

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub
    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_GNAME.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.Focus()
        End Select
    End Sub
    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles Vs1.LostFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INPUT") & "(F5)")

    End Sub
    Private Sub chk_FSEL_Click(sender As Object, e As EventArgs) Handles chk_FSEL.CheckedChanged
        If chk_FSEL.CheckState = 0 Then                  '
            chk_FSEL.BackColor = clrUncheck
            chk_FSEL.ForeColor = Color.Black

            chk_FSEL.Text = WordConv("OPEN")
            ssp_WHERE.Visible = False
        Else                                        '
            chk_FSEL.BackColor = clrCheck
            chk_FSEL.ForeColor = Color.Black

            chk_FSEL.Text = WordConv("CLOSE")
            ssp_WHERE.Visible = True
        End If
    End Sub
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

        Call DATA_SEARCH01()

    End Sub

    Private Function AUTOUPDATEIMAGE() As Boolean

        AUTOUPDATEIMAGE = False

        Dim SqlCom As System.Data.SqlClient.SqlCommand

        Dim _ds2 As DataSet

        _ds2 = PrcDS("USP_PFP71010_SEARCH_VS1_QRCODE", cn)

        Dim _IDNO As String = ""
        Dim _IDCard As String = ""
        Dim settings As BarcodeSettings = New BarcodeSettings()
        BarcodeSettings.ApplyKey("0H8YP-M0FO1-9O9ZJ-441BF-WJ1NA")
        Dim faceid As String = ""
        Dim CustomerCode As String = ""

        For iRow As Integer = 0 To _ds2.Tables(0).Rows.Count - 1
            faceid = GetDsData(_ds2, iRow, "faceid")
            CustomerCode = GetDsData(_ds2, iRow, "CustomerCode")

            _IDCard = _IDCard.Trim
            Dim barc As New FarPoint.Win.Spread.CellType.BarCodeCellType

            settings.Type = BarCodeType.QRCode
            settings.Unit = GraphicsUnit.Pixel
            settings.ShowText = False
            settings.ResolutionType = ResolutionType.UseDpi
            settings.Data = "http://61.28.231.43:6848/thankyou.aspx?id=" & faceid

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
            qry = "UPDATE PFK7101 SET K7101_QRCode = @ImageData  where K7101_CustomerCode  = @CustomerCode"

            'Initialize SqlCommand object for insert. 
            SqlCom = New System.Data.SqlClient.SqlCommand(qry, cn)

            SqlCom.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CustomerCode", CustomerCode))
            SqlCom.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ImageData", DirectCast(dataimage, Object)))


            SqlCom.ExecuteNonQuery()

            System.IO.File.Delete(Path)



        Next

        Vs1.Enabled = True

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
#End Region



    Private Sub btn_Print_Click(sender As Object, e As EventArgs) Handles btn_Print.Click
        Call AUTOUPDATEIMAGE()
    End Sub
End Class