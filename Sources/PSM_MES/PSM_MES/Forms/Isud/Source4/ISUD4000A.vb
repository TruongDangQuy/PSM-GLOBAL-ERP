Imports System.Media
Imports System.Runtime.InteropServices
Public Class ISUD4000A
    <DllImport("kernel32.dll")>
    Public Shared Function Beep(ByVal freq As Integer, ByVal duration As Integer) As Boolean

    End Function

#Region "Variable"
    Private wJOB As Integer

    Private wDateProd As String
    Private wcdFactory As String
    Private wcdMainProcess As String
    Private wcdSubProcess As String
    Private wcdLineProd As String
    Private wBatchGroup As String

    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String

    Private ListBarcode As List(Of String)
    Private DSScanOnffline As DataSet
#End Region

#Region "Form"

    Public Function Link_ISUD4000A() As Boolean
        Me.Tag = Tag

        wDateProd = ""
        wcdFactory = ""
        wcdMainProcess = ""
        wcdLineProd = ""
        wBatchGroup = ""
        wcdSubProcess = "001"

        wJOB = 900
        Dim job As Integer = 900

        Link_ISUD4000A = False
        Try

            'Select Case job
            '    Case 3
            '        txt_Barcode_Box.Enabled = False
            '    Case Else
            '        txt_Barcode_Box.Enabled = True
            'End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD4000A = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_ISUD4000A"))
        End Try

    End Function
    Public Function Link_ISUD4000A(job As Integer, DateProd As String, cdFactory As String, cdMainProcess As String, cdLineProd As String, BatchGroup As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        wDateProd = DateProd
        wcdFactory = cdFactory
        wcdMainProcess = cdMainProcess
        wcdLineProd = cdLineProd
        wBatchGroup = BatchGroup
        wcdSubProcess = "001"

        wJOB = job

        Link_ISUD4000A = False
        Try

            'Select Case job
            '    Case 3
            '        txt_Barcode_Box.Enabled = False
            '    Case Else
            '        txt_Barcode_Box.Enabled = True
            'End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD4000A = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_ISUD4000A"))
        End Try

    End Function
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load

        Control.CheckForIllegalCrossThreadCalls = False
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_KeyDown()

        Call DATA_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Me.Show()

                Call DATA_SEARCH_HEAD_INSERT()

                'txt_Barcode_Box.Enabled = True

                Application.DoEvents()

                cmd_OK.Visible = True
                cmd_OK.Enabled = True

                cmd_HIS.Visible = False

                'Setfocus(txt_Barcode_Box)

            Case 2
                Me.Text = Me.Text & " - SEARCH"

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH_HEAD_INSERT()


                'txt_Barcode_Box.Data = wBatchGroup
                'txt_Barcode_Box.Enabled = False

                Call DATA_SEARCH_VS1()

                cmd_HIS.Visible = False
                cmd_OK.Visible = False
            Case 3
                Me.Text = Me.Text & " - UPDATE"

                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        Me.Dispose()
                        formA = True
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else

                        Me.Text = Me.Text & " - SEARCH"
                        isudCHK = False
                        formA = True
                        wJOB = 2
                        cmd_HIS.Visible = False
                        Call MsgBoxP("Only Search !") : cmd_OK.Visible = False
                    End If
                End If

                'txt_Barcode_Box.Data = wBatchGroup
                'txt_Barcode_Box.Enabled = False

                If DATA_SEARCH_HEAD_INSERT() = True Then
                    Call DATA_SEARCH_VS1()
                End If

                cmd_OK.Visible = False
                cmd_HIS.Visible = False
            Case 4
                Me.Text = Me.Text & " - DELETE"

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                'txt_Barcode_Box.Data = wBatchGroup
                'txt_Barcode_Box.Enabled = False

                Call DATA_SEARCH_HEAD_INSERT()
                Call DATA_SEARCH_VS1()
                cmd_HIS.Visible = True

                cmd_OK.Visible = False
            Case 11

            Case 900
                Me.Text = "Kho thành phẩm - INSERT"

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Me.Show()

                Call DATA_SEARCH_HEAD_INSERT_ThanhPham()

                'txt_Barcode_Box.Enabled = True

                Application.DoEvents()

                cmd_OK.Visible = True
                cmd_OK.Enabled = True

                cmd_HIS.Visible = False

                'Setfocus(txt_Barcode_Box)

        End Select

        formA = True
    End Sub

#End Region

#Region "Search"
    Private Function DATA_SEARCH_HEAD_INSERT_ThanhPham() As Boolean
        DATA_SEARCH_HEAD_INSERT_ThanhPham = False

        'Me.vS1.Enabled = False

        txt_DateProd.Data = System_Date_8()
        txt_cdFactory_ScanOffline.Enabled = True
        txt_cdMainProcess_ScanOffline.Enabled = True
        txt_cdLineProd_ScanOffline.Enabled = True
        txt_InchargeProdution_ScanOffline.Enabled = True

        txt_cdFactory_ScanOffline.Code = ""
        txt_cdFactory_ScanOffline.Data = ""
        txt_cdMainProcess_ScanOffline.Code = ""
        txt_cdMainProcess_ScanOffline.Data = ""
        txt_cdLineProd_ScanOffline.Code = ""
        txt_cdLineProd_ScanOffline.Data = ""
        txt_InchargeProdution_ScanOffline.Code = ""
        txt_InchargeProdution_ScanOffline.Data = ""


        txt_InchargeProdution_ScanOffline.Data = ""
        txt_InchargeProdution_ScanOffline.Code = ""

        DATA_SEARCH_HEAD_INSERT_ThanhPham = True

    End Function
    Private Function DATA_SEARCH_HEAD_INSERT() As Boolean
        DATA_SEARCH_HEAD_INSERT = False


        If READ_PFK7171("300", wcdFactory) = True Then
            txt_cdFactory_ScanOffline.Data = D7171.BasicName
            txt_cdFactory_ScanOffline.Code = D7171.BasicCode
        End If

        If READ_PFK7171("301", wcdLineProd) = True Then
            txt_cdLineProd_ScanOffline.Data = D7171.BasicName
            txt_cdLineProd_ScanOffline.Code = D7171.BasicCode
        End If

        If READ_PFK7171("001", wcdMainProcess) = True Then
            txt_cdMainProcess_ScanOffline.Data = D7171.BasicName
            txt_cdMainProcess_ScanOffline.Code = D7171.BasicCode
        End If

        txt_InchargeProdution_ScanOffline.Data = Pub.SSER
        txt_InchargeProdution_ScanOffline.Code = ""

        DATA_SEARCH_HEAD_INSERT = True

    End Function

    Private Function DATA_INSERT_CUTTING(Szno As String, DateProduction As String, cdSubProcess As String, cdFactory As String, cdLineProd As String, InchargeProdution As String, BatchGroup As String, Optional Qty_Job As Integer = 0) As Boolean
        DATA_INSERT_CUTTING = False

        Try
            'DS1 = PrcDS("USP_ISUD4000A_INSERT_BATCHGROUP", cn, Szno, _
            '                                                    DateProduction,
            '                                                    cdSubProcess,
            '                                                    cdFactory,
            '                                                    cdLineProd,
            '                                                    InchargeProdution,
            '                                                    BatchGroup,
            '                                                    Qty_Job)
            DATA_INSERT_CUTTING = True

        Catch ex As Exception

        End Try
    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        Try
            'DS1 = PrcDS("USP_ISUD4000A_SEARCH_vS1", cn, wDateProd, _
            '                                            wcdFactory, _
            '                                            wcdLineProd, _
            '                                            wcdSubProcess, _
            '                                            txt_Barcode_Box.Data)


            'If GetDsRc(DS1) = 0 Then
            '    SPR_SET(vS1, , , , OperationMode.Normal)
            '    SPR_PRO(vS1, DS1, "USP_ISUD4000A_SEARCH_vS1", "vS1")

            '    vS1.ActiveSheet.RowCount = 1
            '    vS1.Enabled = True

            '    Exit Function
            'End If

            'SPR_SET(vS1, , , , OperationMode.Normal)
            'SPR_PRO(vS1, DS1, "USP_ISUD4000A_SEARCH_vS1", "vS1")

            'Call DATA_SEARCH_VS1_INSERT_MATERIALNAME(txt_Barcode_Box.Data)

            DATA_SEARCH_VS1 = True


            'Setfocus(txt_Barcode_Box)

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function

    Private Function DATA_SEARCH_VS1_INSERT(BatchGroup As String) As Boolean
        DATA_SEARCH_VS1_INSERT = False


        Try
            'DS1 = PrcDS("USP_ISUD4000A_SEARCH_vS1_INSERT", cn, wDateProd, _
            '                                            wcdFactory, _
            '                                            wcdLineProd, _
            '                                            wcdSubProcess, _
            '                                            BatchGroup)


            'If GetDsRc(DS1) = 0 Then
            '    SPR_SET(vS1, , , , OperationMode.Normal)
            '    SPR_PRO(vS1, DS1, "USP_ISUD4000A_SEARCH_vS1_INSERT", "vS1")

            '    vS1.ActiveSheet.RowCount = 0
            '    vS1.Enabled = True

            '    'txt_Mess.Text = "KHÔNG TÌM THẤY SỐ LƯỢNG CỦA BARCODE"
            '    'txt_Mess.ForeColor = Color.Red

            '    Setfocus(txt_Barcode_Box)

            '    Exit Function
            'End If

            'SPR_SET(vS1, , , , OperationMode.Normal)
            'SPR_PRO(vS1, DS1, "USP_ISUD4000A_SEARCH_vS1_INSERT", "vS1")

            ''txt_Mess.Text = ""

            'vS1.Focus()

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1_INSERT")
        End Try
    End Function

    Private Function DATA_SEARCH_VS1_INSERT_MATERIALNAME(BatchGroup As String) As Boolean
        DATA_SEARCH_VS1_INSERT_MATERIALNAME = False


        Try
            'DS1 = PrcDS("USP_ISUD43670_SEARCH_vS1_INSERT_MATERIALNAME", cn, BatchGroup)


            'If GetDsRc(DS1) = 0 Then
            '    'txt_MaterialName.Text = ""
            '    Exit Function
            'End If

            ''txt_MaterialName.Text = CStrp(GetDsData(DS1, 0, 0))
            DATA_SEARCH_VS1_INSERT_MATERIALNAME = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1_INSERT_MATERIALNAME")
        End Try
    End Function

#End Region

#Region "Function"

    Private Sub DATA_INIT()
        Try
            txt_DateProd.Data = FormatCut(wDateProd)
            txt_DateProd.Code = FormatCut(wDateProd)

            vS1.InsChk = False

            DSScanOnffline = New DataSet

            Dim dt As DataTable = New DataTable("ResultScanOffline")

            Dim cl As DataColumn = New DataColumn()
            cl.ColumnName = "Color_ScanOffline"
            dt.Columns.Add(cl)

            cl = New DataColumn()
            cl.ColumnName = "Result_ScanOffline"
            dt.Columns.Add(cl)

            cl = New DataColumn()
            cl.ColumnName = "BatchNo_ScanOffline"
            dt.Columns.Add(cl)

            cl = New DataColumn()
            cl.ColumnName = "Messgase_ScanOffline"
            dt.Columns.Add(cl)

            cl = New DataColumn()
            cl.ColumnName = "TimeInsert_ScanOffline"
            dt.Columns.Add(cl)

            cl = New DataColumn()
            cl.ColumnName = "QtyProd_ScanOffline"
            dt.Columns.Add(cl)

            DSScanOnffline.Tables.Add(dt)


            SPR_PRO_NEW(vS1, DSScanOnffline, "USP_ISUD4000A_TEXTBOX_INSERT_MinhDuy", "Vs1")


        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private CntS As Integer
    Private Function DATA_INSERT() As Boolean
        DATA_INSERT = False
        Try
            'ListBarcode = New List(Of String)

            Dim EDate As String = ""
            Dim cdFactory As String = ""
            Dim cdMainProcess As String = ""
            Dim cdSubProcess As String = ""
            Dim cdLineProd As String = ""
            Dim Incharge As String = ""
            Dim DSV1 As DataSet

            EDate = txt_DateProd.Data
            cdFactory = txt_cdFactory_ScanOffline.Code
            cdMainProcess = txt_cdMainProcess_ScanOffline.Code
            'cdSubProcess = txt_su.Code
            cdLineProd = txt_cdLineProd_ScanOffline.Code
            Incharge = txt_InchargeProdution_ScanOffline.Code

            If cdFactory = "" Then MsgBoxP("Vui lòng chọn Xưởng!") : Exit Function
            If cdMainProcess = "" Then MsgBoxP("Vui lòng chọn Công đoạn!") : Exit Function
            If cdFactory = "" Then MsgBoxP("Vui lòng chọn Xưởng!") : Exit Function
            If cdLineProd = "" Then MsgBoxP("Vui lòng chọn Chuyền!") : Exit Function
            If Incharge = "" Then MsgBoxP("Vui lòng chọn Người thực hiện công việc!") : Exit Function

            If MsgBoxP("Xóa dữ liệu cũ ?", MsgBoxStyle.OkCancel, "Thông báo") = MsgBoxResult.Ok Then
                DSScanOnffline.Tables(0).Rows.Clear()
                SPR_PRO_NEW(vS1, DSScanOnffline, "USP_ISUD4000A_TEXTBOX_INSERT_MinhDuy", "Vs1")
            End If

            For Each BatchNo As String In txt_Barcode.Text.Trim().Split(New Char() {Environment.NewLine, " "c})
                BatchNo = BatchNo.Trim()
                Try
                    If String.IsNullOrEmpty(BatchNo) = False Then
                        CDblp(BatchNo)

                        DSV1 = New DataSet
                        DSV1 = PrcDS("USP_ISUD4000A_TEXTBOX_INSERT_MinhDuy", cn, EDate, _
                                                                    cdFactory, _
                                                                    cdMainProcess, _
                                                                    cdSubProcess, _
                                                                    cdLineProd, _
                                                                    Incharge, _
                                                                    BatchNo)

                        If DSV1.Tables(0).Rows.Count > 0 Then
                            Dim dr As DataRow = DSScanOnffline.Tables(0).NewRow
                            dr(0) = DSV1.Tables(0)(0)(0)
                            dr(1) = DSV1.Tables(0)(0)(1)
                            dr(2) = DSV1.Tables(0)(0)(2)
                            dr(3) = DSV1.Tables(0)(0)(3)
                            dr(4) = DSV1.Tables(0)(0)(4)
                            dr(5) = DSV1.Tables(0)(0)(5)
                            DSScanOnffline.Tables(0).Rows.Add(dr)
                            'vS1 = New PeaceFarpoint
                            vS1.DataSource = Nothing
                            SPR_PRO_NEW(vS1, DSScanOnffline, "USP_ISUD4000A_TEXTBOX_INSERT_MinhDuy", "Vs1")

                            Dim i As Integer
                            For i = 0 To vS1.ActiveSheet.RowCount - 1

                                If Trim$(getData(vS1, getColumIndex(vS1, "Color_ScanOffline"), i)) <> "" Then
                                    Dim cShare As System.Drawing.Color


                                    If Trim$(getData(vS1, getColumIndex(vS1, "Color_ScanOffline"), i)) = "cButtomHelpColor" Then
                                        cShare = cButtomHelpColor
                                    ElseIf Trim$(getData(vS1, getColumIndex(vS1, "Color_ScanOffline"), i)) = "cSprSealNo" Then
                                        cShare = cSprSealNo
                                    ElseIf Trim$(getData(vS1, getColumIndex(vS1, "Color_ScanOffline"), i)) = "cSprBalance" Then
                                        cShare = cSprBalance
                                    ElseIf Trim$(getData(vS1, getColumIndex(vS1, "Color_ScanOffline"), i)) = "cSprProduction" Then
                                        cShare = cSprProduction
                                    ElseIf Trim$(getData(vS1, getColumIndex(vS1, "Color_ScanOffline"), i)) = "cSprSetBalance" Then
                                        cShare = cSprSetBalance
                                    Else
                                        cShare = New System.Drawing.Color
                                        Dim ColorRGB() As String = Trim$(getData(vS1, getColumIndex(vS1, "Color_ScanOffline"), i)).Split(New Char() {":"c})
                                        cShare = System.Drawing.Color.FromArgb(CType(CInt(ColorRGB(0)), Integer), CType(CInt(ColorRGB(1)), Integer), CType(CInt(ColorRGB(2)), Integer))
                                    End If
                                    Call SPR_BACKCOLOR(vS1, cShare, i)
                                End If

                            Next
                        End If
                    End If

                Catch ex As Exception

                End Try

            Next
            txt_Barcode.Text = ""

            DATA_INSERT = True
        Catch ex As Exception
            'txt_Mess.Text = "QUÉT SẢN LƯỢNG CÓ LỖI VUI LÒNG KIỂM TRA LẠI!"
            'txt_Mess.ForeColor = Color.Red
        End Try

    End Function

    Private Function DATA_DELETE() As Boolean
        DATA_DELETE = False

        Try
            DSScanOnffline.Tables(0).Rows.Clear()
            SPR_PRO_NEW(vS1, DSScanOnffline, "USP_ISUD4000A_TEXTBOX_INSERT_MinhDuy", "Vs1")
            DATA_DELETE = True

        Catch ex As Exception
            'txt_Mess.Text = "XÓA SẢN LƯỢNG CÓ LỖI VUI LÒNG KIỂM TRA LẠI!"
            'txt_Mess.ForeColor = Color.Red
        End Try

    End Function

    Private Function DATA_DELETE_LINE(xRow As Integer) As Boolean
        DATA_DELETE_LINE = False

        Dim Szno As String

        Dim Autokey As String = 0

        Szno = getData(vS1, getColumIndex(vS1, "Szno"), xRow)
        Autokey = getData(vS1, getColumIndex(vS1, "KEY_Autokey"), xRow)

        Try


            DATA_DELETE_LINE = True

        Catch ex As Exception
            'txt_Mess.Text = "XÓA SẢN LƯỢNG CÓ LỖI VUI LÒNG KIỂM TRA LẠI!"
            'txt_Mess.ForeColor = Color.Red
        End Try

    End Function


#End Region

#Region "Event"

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        'Select Case wJOB
        '    Case 1
        '        Call DATA_INSERT()
        '        'Setfocus(txt_Barcode_Box)
        '    Case 2
        '        Me.Dispose()
        '    Case 3
        '        Me.Dispose()
        '    Case 4
        '        Me.Dispose()
        'End Select
        Call DATA_INSERT()
    End Sub

    Private Sub cmd_CLE_Click(sender As Object, e As EventArgs) Handles cmd_CLE.Click
        Call DATA_DELETE()
    End Sub
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs)
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub

    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs)

        If txt_DateProd.Data <> Pub.DAT Then
            MsgBoxP("Not today! Can't delete!")
            Exit Sub
        Else
            Call DATA_DELETE()
            Me.Dispose()
        End If


    End Sub


    'Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles vS1.KeyDown
    '    Dim xCol As Long
    '    Dim xRow As Long

    '    xCol = vS1.ActiveSheet.ActiveColumnIndex
    '    xRow = vS1.ActiveSheet.ActiveRowIndex

    '    Select Case e.KeyCode
    '        Case Keys.Delete

    '            Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)
    '            If Msg_Result <> vbYes Then Exit Sub
    '            If txt_DateProd.Data <> Pub.DAT Then
    '                MsgBoxP("Not today! Can't delete!")
    '                Exit Sub
    '            Else

    '                If getData(vS1, getColumIndex(vS1, "KEY_Autokey"), xRow) <> "0" Then
    '                    Call DATA_DELETE_LINE(xRow)
    '                End If
    '                Call SPR_DEL(vS1, 0, xRow)
    '            End If

    '    End Select

    'End Sub

    Private Sub txt_cdFactory_ScanOffline_btnTitleClick(sender As Object, e As EventArgs) Handles txt_cdFactory_ScanOffline.btnTitleClick
        If HLP7171D_SCANOFFLINE.Link_HLP7171D("999", "", "", "", "999", "") = True Then
            txt_cdFactory_ScanOffline.Code = hlp0000SeVaTt
            txt_cdFactory_ScanOffline.Data = hlp0000SeVa
        End If

    End Sub

    Private Sub txt_cdMainProcess_ScanOffline_btnTitleClick(sender As Object, e As EventArgs) Handles txt_cdMainProcess_ScanOffline.btnTitleClick
        If txt_cdFactory_ScanOffline.Code = "" Then
            MsgBoxP("Vui lòng chọn Xưởng!")
            Exit Sub
        End If
        If HLP7171D_SCANOFFLINE.Link_HLP7171D("999", "", txt_cdFactory_ScanOffline.Code, "", "999", "") = True Then
            txt_cdMainProcess_ScanOffline.Code = hlp0000SeVaTt
            txt_cdMainProcess_ScanOffline.Data = hlp0000SeVa
        End If

    End Sub

    Private Sub txt_cdLineProd_ScanOffline_btnTitleClick(sender As Object, e As EventArgs) Handles txt_cdLineProd_ScanOffline.btnTitleClick
        If HLP7171ALL.Link_HLP7171A("301", "") Then
            txt_cdLineProd_ScanOffline.Code = hlp0000SeVaTt
            txt_cdLineProd_ScanOffline.Data = hlp0000SeVa
        End If
    End Sub

    Private Sub txt_InchargeProdution_ScanOffline_btnTitleClick(sender As Object, e As EventArgs) Handles txt_InchargeProdution_ScanOffline.btnTitleClick
        If HLP7411A.Link_HLP7411A("") Then
            txt_InchargeProdution_ScanOffline.Code = hlp0000SeVaTt
            txt_InchargeProdution_ScanOffline.Data = hlp0000SeVa
        End If
    End Sub

    Private Sub txt_InchargeProdution_ScanOffline_KeyDown(sender As Object, e As KeyPressEventArgs) Handles txt_InchargeProdution_ScanOffline.txtTextKeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If HLP7411A.Link_HLP7411A(txt_InchargeProdution_ScanOffline.Data) Then
                txt_InchargeProdution_ScanOffline.Code = hlp0000SeVaTt
                txt_InchargeProdution_ScanOffline.Data = hlp0000SeVa
            End If
        End If
    End Sub


#End Region



   
End Class