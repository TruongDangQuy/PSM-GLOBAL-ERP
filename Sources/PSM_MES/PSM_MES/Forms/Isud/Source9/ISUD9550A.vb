Public Class ISUD9550A

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As Boolean
    Private FIRST_LINE_CHK As Boolean

    Private privS1_SCOL As Integer

    Private Dsu01 As Integer
    Private Dsu02 As Integer
    Private Dsu04 As Integer


    Private W9550 As T9550_AREA
    Private M9550 As T9550_AREA
    Private L9550 As T9550_AREA

    Private priJOB_CHK As String

    Private CHK(0 To 5) As String
    Private loop_check As Boolean
    Private formA As Boolean
    Private _strValue As String

    Private _K9272_BasicSel As String
    Private _K9272_BasicCode As String
    Private _K9272_SEQ As String
    Private _FileName As String
    Private _FileType As String
#End Region

#Region "Link"
    Public Function Link_ISUD9550A(job As Integer, cdWorkFlow As String, Value As String, Optional FormName As String = "") As Boolean
        Me.Tag = FormName
        _strValue = Value

        D9550.cdWorkFlow = cdWorkFlow

        If READ_PFK7171(ListCode("WorkFlow"), cdWorkFlow) Then
            txt_cdWorkFlow.Code = D7171.BasicCode
            txt_cdWorkFlow.Data = D7171.BasicName
        End If


        wJOB = job : L9550 = D9550 : L9550 = D9550

        txt_cdWorkFlow.Code = cdWorkFlow

        formA = False
        Link_ISUD9550A = False

        Me.ShowDialog()

        Link_ISUD9550A = isudCHK

        Exit Function
Error_Message:
        Call Error_Message("37", WordConv("Link_ISUD9550A"))
    End Function

    Public Function Link_ISUD9550A_ISUD7171(job As Integer, cdWorkFlow As String, Value As String, K9272_BasicSel As String, K9272_BasicCode As String, K9272_SEQ As String, ByVal FileName As String, ByVal FileType As String, Optional FormName As String = "") As Boolean
        Try


            Me.Tag = FormName
            _strValue = Value

            D9550.cdWorkFlow = cdWorkFlow

            If READ_PFK7171(ListCode("WorkFlow"), cdWorkFlow) Then
                txt_cdWorkFlow.Code = D7171.BasicCode
                txt_cdWorkFlow.Data = D7171.BasicName
            End If

            _K9272_BasicSel = K9272_BasicSel
            _K9272_BasicCode = K9272_BasicCode
            _K9272_SEQ = K9272_SEQ
            _FileName = FileName
            _FileType = FileType

            wJOB = job : L9550 = D9550 : L9550 = D9550

            txt_cdWorkFlow.Code = cdWorkFlow

            formA = False
            Link_ISUD9550A_ISUD7171 = False

            Me.ShowDialog()

            Link_ISUD9550A_ISUD7171 = isudCHK

            Exit Function

        Catch ex As Exception

        End Try

    End Function

#End Region

#Region "Form_Load"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        Me.Form_KeyDown()


        Call FORM_INIT()
        Call DATA_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"
                priJOB_CHK = "INSERT"

                tst_iDelete.Visible = False

                Call DATA_SEARCH_VS1_INSERT()

            Case 2
                Me.Text = Me.Text & " - SEARCH"

                Frm_MAIN_HEAD.Enabled = False

                Call DATA_SEARCH_VS1()

                tst_iDelete.Visible = False
                tst_iSave.Visible = False

                Setfocus(tst_iClose)

            Case 3
                Me.Text = Me.Text & " - UPDATE"

                priJOB_CHK = "UPDATE"

                Call DATA_SEARCH_VS1()

                Frm_MAIN_HEAD.Enabled = True


                Setfocus(tst_iSave)

            Case 4
                Me.Text = Me.Text & " - DELETE"

                Call DATA_SEARCH_VS1()

                Frm_MAIN_HEAD.Enabled = False
                Frm_MAIN_HEAD.Enabled = False


                tst_iDelete.Visible = True
                tst_iSave.Visible = False

                tst_iClose.Select()

            Case 5
                Me.Text = Me.Text & " - INTERFACE"

                priJOB_CHK = "INTERFACE"

                Call DATA_SEARCH_VS1()
                Call downLoadFile(_K9272_BasicSel, _K9272_BasicCode, _K9272_SEQ, _FileName, _FileType)

                Frm_MAIN_HEAD.Enabled = True


                Setfocus(tst_iSave)
                tst_iSave.Select()

                If Bol_AutoInsert = True Then tst_iSave.PerformClick()

            Case 11
                Me.Text = Me.Text & " - COPY"

                Call DATA_SEARCH_VS1()
                wJOB = 1
                Frm_MAIN_HEAD.Enabled = True

                tst_iDelete.Visible = False

                tst_iSave.Select()

        End Select

        formA = True
    End Sub

    Private Sub FORM_INIT()
        FIRST_LINE_CHK = False
        vS2.Visible = False
        If wJOB = 1 Then txt_cdWorkFlow.Data = "" : txt_cdWorkFlow.Code = ""

        Me.WindowState = FormWindowState.Maximized
        vS1.AllowRowMove = True
    End Sub

    Private Sub DATA_INIT()
        If wJOB = "1" Then
            L9550.DateAccept = Pub.DAT
            L9550.DateAccept = Pub.DAT
        End If

        vS1.AllowRowMove = True

        WRITE_CHK = False
    End Sub
#End Region

#Region "DATA_SEARCH"
    Private Function HEAD_SEARCH() As Boolean
        HEAD_SEARCH = False

        HEAD_SEARCH = True
    End Function

    Private Function HEAD_SEARCH_SANO(tmpcdWorkFlow As String, tmpcdSubProcess As String, tmpDateAccept As String, tmpcdLineProd As String, tmpSeqJob As String) As Boolean
        HEAD_SEARCH_SANO = False

        HEAD_SEARCH_SANO = True

    End Function

    Private Function HEAD_SEARCH_DATE_TOTAL() As Boolean
        HEAD_SEARCH_DATE_TOTAL = False

        DS1 = PrcDS("USP_ISUD9550A_SEARCH_HEAD_TOTAL", cn, txt_cdWorkFlow.Code, L9550.DateAccept)

        If GetDsRc(DS1) = 0 Then
            Exit Function
            isudCHK = False
        End If

        HEAD_SEARCH_DATE_TOTAL = True
    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        If L9550.cdWorkFlow <> "" Then txt_cdWorkFlow.Code = L9550.cdWorkFlow

        If READ_PFK7171(ListCode("WorkFlow"), txt_cdWorkFlow.Code) Then
            txt_cdWorkFlow.Code = D7171.BasicCode
            txt_cdWorkFlow.Enabled = False
            txt_cdWorkFlow.Data = D7171.BasicName
        End If

        Try
            Dim i As Integer

            DS1 = PrcDS("USP_ISUD9550A_SEARCH_VS1", cn, txt_cdWorkFlow.Code)
            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS1, DS1, "USP_ISUD9550A_SEARCH_VS1", "Vs1")
                vS1.ActiveSheet.RowCount = 1
                vS1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS1, DS1, "USP_ISUD9550A_SEARCH_VS1", "Vs1")

            If chk_Full.Checked Then
                SPR_TEXTBOXWARP(vS1, getColumIndex(vS1, "Description"))
                SPR_TEXTBOXWARP(vS1, getColumIndex(vS1, "Receiver"))

                SPR_TEXTBOXWARP(vS1, getColumIndex(vS1, "ExceptionName"))

                SPR_TEXTBOXWARP(vS1, getColumIndex(vS1, "JobCardList"))
                SPR_TEXTBOXWARP(vS1, getColumIndex(vS1, "ReportList"))
                SPR_TEXTBOXWARP(vS1, getColumIndex(vS1, "FilesName"))

                For i = 0 To vS1.ActiveSheet.RowCount - 1
                    vS1.ActiveSheet.Rows(i).Height = vS1.ActiveSheet.Rows(i).GetPreferredHeight
                    If vS1.ActiveSheet.Rows(i).Height < 80 Then vS1.ActiveSheet.Rows(i).Height = 80


                    'Dim nc As New FarPoint.Win.Spread.CellType.TextCellType
                    'nc.WordWrap = True
                    'nc.MaxLength = 10000
                    'nc.Multiline = True
                    'vS1.ActiveSheet.Cells(i, getColumIndex(vS1, "Description")).CellType = nc


                Next
            End If



            DATA_SEARCH_VS1 = True

        Catch ex As Exception

        End Try
    End Function

    Private Function DATA_SEARCH_VS1_INSERT() As Boolean
        DATA_SEARCH_VS1_INSERT = False
        Try
            Dim i As Integer
            If _strValue = "" Then DATA_SEARCH_VS1() : Exit Function

            DS1 = PrcDS("USP_ISUD9550A_SEARCH_VS1_INSERT", cn, _strValue)
            If GetDsRc(DS1) = 0 Then
                MsgBoxP("No Choose Data!")
                Me.Dispose()
                Exit Function
            End If

            SPR_PRO_NEW(vS1, DS1, "USP_ISUD9550A_SEARCH_VS1_INSERT", "Vs1")

            DATA_SEARCH_VS1_INSERT = True

        Catch ex As Exception

        End Try
    End Function
#End Region

#Region "Function"
    Private Sub downLoadFile(K9272_BasicSel As String, K9272_BasicCode As String, K9272_SEQ As String, ByVal FileName As String, ByVal FileType As String)

        Dim strSql As String

        'For Document
        Try
            'Get image data from gridview column. 
            strSql = "Select K9272_ImageData from [PFK9272] "
            strSql = strSql & "WHERE [K9272_BasicSel]= '" + K9272_BasicSel + "'"
            strSql = strSql & "AND   [K9272_BasicCode]= '" + K9272_BasicCode + "'"
            strSql = strSql & "AND   [K9272_SEQ]= '" + K9272_SEQ + "'"

            Dim sqlCmd As New SqlClient.SqlCommand(strSql, cn)

            'Get image data from DB
            Dim fileData As Byte() = DirectCast(sqlCmd.ExecuteScalar(), Byte())
            Dim xrow2 As Integer
            Dim xcol1 As Integer
            Dim sFileName As String

            sFileName = FileName
            sFileName &= "." & FileType

            Dim sTempFileName As String = System.IO.Path.GetTempPath & "\" & sFileName

            If Not fileData Is Nothing Then

                'Read image data into a file stream 
                Using fs As New System.IO.FileStream(sFileName, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write)
                    fs.Write(fileData, 0, fileData.Length)
                    'Set image variable value using memory stream. 
                    fs.Flush()
                    fs.Close()

                    vS2.OpenExcel(sFileName)
                    IO.File.Delete(sFileName)
                    vS1.ActiveSheet.RowCount = 0
                    vS2.Visible = False
                    For xrow2 = 7 To 100
                        If FormatCut(getData(vS2, 1, xrow2)) <> "" Then
                            vS1.ActiveSheet.RowCount += 1
                            For xcol1 = 0 To vS1.ActiveSheet.ColumnCount - 1
                                If TypeOf (vS1.ActiveSheet.Columns(xcol1).CellType) Is FarPoint.Win.Spread.CellType.CheckBoxCellType Then
                                    setData(vS1, xcol1, vS1.ActiveSheet.RowCount - 1, IIf(getData(vS2, xcol1 + 1, xrow2) = "Y", "1", "2"), , True)
                                Else
                                    setData(vS1, xcol1, vS1.ActiveSheet.RowCount - 1, getData(vS2, xcol1 + 1, xrow2))

                                End If

                            Next
                        End If
                    Next

                End Using



            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Function KEY_COUNT() As Boolean

    End Function
    Private Sub DATA_MOVE_WRITE_INSERT()
        Try
            Call D9550_CLEAR() : W9550 = D9550

            W9550.cdWorkFlow = txt_cdWorkFlow.Code

            Dim xrow As Integer


            For xrow = 0 To vS1.ActiveSheet.RowCount - 1
                If K9550_MOVE(vS1, xrow, W9550, txt_cdWorkFlow.Code, CDecp(getData(vS1, getColumIndex(vS1, "AutoKey_PFK9500_S"), xrow))) = False Then
                    W9550.seCheckFlow = ListCode("CheckFlow")
                    W9550.seWorkFlow = ListCode("WorkFlow")
                    W9550.cdCheckFlow = getData(vS1, getColumIndex(vS1, "cdCheckFlow"), xrow)

                    W9550.AutoKey_PFK9500_S = CDecp(getData(vS1, getColumIndex(vS1, "AutoKey_PFK9500_S"), xrow))
                    W9550.AutoKey_PFK9500_E = CDecp(getData(vS1, getColumIndex(vS1, "AutoKey_PFK9500_E"), xrow))
                    W9550.Dseq = xrow + 1
                    W9550.cdWorkFlow = txt_cdWorkFlow.Code

                    W9550.CheckCP = getDataM(vS1, getColumIndex(vS1, "CheckCP"), xrow)
                    W9550.CheckSC = getDataM(vS1, getColumIndex(vS1, "CheckSC"), xrow)

                    W9550.Description = getData(vS1, getColumIndex(vS1, "Description"), xrow)
                    W9550.Dseq = xrow + 1
                    W9550.DseqName = getData(vS1, getColumIndex(vS1, "DseqName"), xrow)
                    W9550.DseqTo = CDecp(getData(vS1, getColumIndex(vS1, "DseqTo"), xrow))

                    Call WRITE_PFK9550(W9550)
                End If
            Next

        Catch ex As Exception

        End Try


    End Sub
    Private Sub DATA_MOVE_WRITE()
        Try
            'Call D9550_CLEAR() : W9550 = D9550
            WRITE_CHK = False

            SQL = " DELETE FROM PFK9550 "
            SQL = SQL & " WHERE K9550_cdWorkFlow         = '" & txt_cdWorkFlow.Code & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn) : cmd.ExecuteNonQuery()


            W9550.cdWorkFlow = txt_cdWorkFlow.Code

            Dim xrow As Integer


            For xrow = 0 To vS1.ActiveSheet.RowCount - 1
                If CDecp(getData(vS1, getColumIndex(vS1, "Dseq"), xrow)) < 0 Then GoTo next1

                D9550_CLEAR()

                W9550 = D9550
                W9550.seCheckFlow = ListCode("CheckFlow")
                W9550.cdCheckFlow = getData(vS1, getColumIndex(vS1, "cdCheckFlow"), xrow)

                W9550.seWorkFlow = ListCode("WorkFlow")
                W9550.AutoKey_PFK9500_S = xrow
                W9550.AutoKey_PFK9500_E = xrow
                W9550.Dseq = CDecp(getData(vS1, getColumIndex(vS1, "Dseq"), xrow))
                W9550.cdWorkFlow = txt_cdWorkFlow.Code

                W9550.cdDepartmentName = getData(vS1, getColumIndex(vS1, "cdDepartmentName"), xrow)
                W9550.cdFrequencyName = getData(vS1, getColumIndex(vS1, "cdFrequencyName"), xrow)
                W9550.ActionName = getData(vS1, getColumIndex(vS1, "ActionName"), xrow)
                W9550.Receiver = getData(vS1, getColumIndex(vS1, "Receiver"), xrow)
                W9550.FilesName = getData(vS1, getColumIndex(vS1, "FilesName"), xrow)
                W9550.JobCardList = getData(vS1, getColumIndex(vS1, "JobCardList"), xrow)
                W9550.ReportList = getData(vS1, getColumIndex(vS1, "ReportList"), xrow)

                W9550.Purpose = getData(vS1, getColumIndex(vS1, "Purpose"), xrow)

                W9550.Description = getData(vS1, getColumIndex(vS1, "Description"), xrow)
                W9550.DseqName = getData(vS1, getColumIndex(vS1, "DseqName"), xrow)
                W9550.DseqTo = CDecp(getData(vS1, getColumIndex(vS1, "DseqTo"), xrow))

                W9550.CheckCP = getDataM(vS1, getColumIndex(vS1, "CheckCP"), xrow)
                W9550.CheckSC = getDataM(vS1, getColumIndex(vS1, "CheckSC"), xrow)

                Call WRITE_PFK9550(W9550)

                If CDecp(getData(vS1, getColumIndex(vS1, "Dseq"), xrow)) = 99 Then Exit Sub

next1:
            Next

        Catch ex As Exception

        End Try


    End Sub

    Private Function DATA_MOVE_COPY_WRITE() As Boolean

        DATA_MOVE_COPY_WRITE = False

        DATA_MOVE_COPY_WRITE = True

    End Function

    Private Sub DATA_INSERT()
        If DataCheck() = False Then Exit Sub

        Call DATA_MOVE_WRITE_INSERT()


    End Sub

    Private Sub DATA_INSERT_COPY()
        If DataCheck = False Then Exit Sub

        If DATA_MOVE_COPY_WRITE = False Then Exit Sub

        If HEAD_SEARCH = True Then
            If DATA_SEARCH_VS1 = True Then Call HEAD_SEARCH_DATE_TOTAL()
        End If


        wJOB = 3

        Frm_MAIN_HEAD.Enabled = True

        Call KEY_COUNT()

    End Sub

    Private Sub DATA_UPDATE()
        Call DATA_MOVE_WRITE()

        isudCHK = WRITE_CHK
    End Sub

    Private Sub DATA_DELETE()
        WRITE_CHK = False

        SQL = " DELETE FROM PFK9550 "
        SQL = SQL & " WHERE K9550_cdWorkFlow         = '" & W9550.cdWorkFlow & "' "
        SQL = SQL & "   AND K9550_DateAccept       = '" & W9550.DateAccept & "' "

        cmd = New SqlClient.SqlCommand(SQL, cn) : cmd.ExecuteNonQuery()


        WRITE_CHK = True
        isudCHK = WRITE_CHK
    End Sub

    Private Function DataCheck() As Boolean
        DataCheck = False
        If txt_cdWorkFlow.Code = "" Then MsgBoxP("cdWorkFlow Please!") : Exit Function

        DataCheck = True
    End Function

    Private Function DATA_CONDITION_CHK() As Boolean
        DATA_CONDITION_CHK = False

        If txt_cdWorkFlow.Code = "" Then MsgBoxP("Workflow Pls!") : Exit Function

        DATA_CONDITION_CHK = True

    End Function

    Private Function DATA_PERSON_FORMATION_CHK() As Boolean
        DATA_PERSON_FORMATION_CHK = False

        DATA_PERSON_FORMATION_CHK = True

    End Function
#End Region

#Region "Events"
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 1
                If DATA_CONDITION_CHK() = False Then Exit Sub

                Call DATA_UPDATE() '
                Call DATA_SEARCH_VS1()
                wJOB = 3
                priJOB_CHK = "INSERT"
                FIRST_LINE_CHK = True

            Case 2 : Me.Dispose()
            Case 3
                Call DATA_UPDATE() '
                priJOB_CHK = "UPDATE"
                Call DATA_SEARCH_VS1()
            Case 11
                Call DATA_INSERT_COPY()
                If WRITE_CHK = True Then
                    priJOB_CHK = "UPDATE"
                    FIRST_LINE_CHK = False
                Else

                End If
            Case 5
                If DATA_CONDITION_CHK() = False Then Exit Sub

                Call DATA_UPDATE() '

                priJOB_CHK = "INSERT"
                FIRST_LINE_CHK = True

                If Bol_AutoInsert = True Then tst_iClose.PerformClick()
        End Select
    End Sub

    Private Sub tst_iDelete_Click(sender As Object, e As EventArgs) Handles tst_iDelete.Click
        Call Select_Message("5", "tst_iDelete_Click", "2")
        If Msg_Result <> vbYes Then Exit Sub

        SQL = " DELETE FROM PFK9550 "
        SQL = SQL & " WHERE K9550_cdWorkFlow         = '" & txt_cdWorkFlow.Code & "' "

        cmd = New SqlClient.SqlCommand(SQL, cn) : cmd.ExecuteNonQuery()

        isudCHK = True
        Me.Dispose()
    End Sub

    Private Sub tst_iClose_Click(sender As Object, e As EventArgs) Handles tst_iClose.Click
        If loop_check = True Then
            Call Select_Message("38", "tst_iClose_Click", "2")
            If Msg_Result <> vbYes Then Exit Sub
        End If

        If WRITE_CHK = True Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub

    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles vS1.KeyDown
        Dim xCOL As Integer
        Dim xRow As Integer

        xCOL = vS1.ActiveSheet.ActiveColumnIndex
        xRow = vS1.ActiveSheet.ActiveRowIndex


        Select Case e.KeyCode
            Case Keys.Delete
                Call Select_Message("5", "tst_iDelete_Click", "2")
                If Msg_Result <> vbYes Then Exit Sub

                If getData(vS1, getColumIndex(vS1, "DateAccept"), xRow) <> "" Then
                    Call Select_Message("3", WordConv("BARCODE"), 2)

                    If Msg_Result <> vbYes Then Exit Sub

                    If Trim(W9550.DateAccept) = "" Then Exit Sub

                    Call SPR_DEL(vS1, xCOL, xRow)
                Else
                    Call SPR_DEL(vS1, xCOL, xRow)

                End If

            Case Keys.Insert
                If xRow = vS1.ActiveSheet.RowCount - 1 Then
                    vS1.ActiveSheet.RowCount += 1
                    vS1.ActiveSheet.ActiveRowIndex = xRow + 1


                Else
                    vS1.ActiveSheet.AddRows(xRow + 1, 1)
                    vS1.ActiveSheet.ActiveRowIndex = xRow + 1

                End If

        End Select
    End Sub

    Private Sub txt_QtyRateSecondJob_txtTextKeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            tst_iSave.Select()
        End If
    End Sub

    Private Sub cmd_Reup_Click(sender As Object, e As EventArgs) Handles cmd_Reup.Click
        Call DATA_SEARCH_VS1()
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

    Private Sub cmd_LoadingExcel_Click(sender As Object, e As EventArgs) Handles cmd_LoadingExcel.Click
        Try

            Dim xrow2 As Integer
            Dim xcol1 As Integer

            Using OpenFileDialog As OpenFileDialog = Me.GetOpenFileDialog()
                OpenFileDialog.ReadOnlyChecked = True
                OpenFileDialog.RestoreDirectory = True

                If _FileExt <> "" Then OpenFileDialog.InitialDirectory = _FileExt

                If (OpenFileDialog.ShowDialog(Me) = DialogResult.OK) Then


                    If _FileExt = "" Then _FileExt = OpenFileDialog.FileName

                    Dim strEx As String

                    Dim File As String
                    Dim DestTemp As String = OpenFileDialog.FileName + ".temp"

                    IO.File.Copy(OpenFileDialog.FileName, DestTemp)


                    vS2.OpenExcel(DestTemp)
                    IO.File.Delete(DestTemp)
                    vS1.ActiveSheet.RowCount = 0
                    vS2.Visible = False
                    For xrow2 = 7 To 100
                        If FormatCut(getData(vS2, 1, xrow2)) <> "" Then
                            vS1.ActiveSheet.RowCount += 1
                            For xcol1 = 0 To vS1.ActiveSheet.ColumnCount - 1
                                If TypeOf (vS1.ActiveSheet.Columns(xcol1).CellType) Is FarPoint.Win.Spread.CellType.CheckBoxCellType Then
                                    setData(vS1, xcol1, vS1.ActiveSheet.RowCount - 1, IIf(getData(vS2, xcol1 + 1, xrow2) = "Y", "1", "2"), , True)
                                Else
                                    setData(vS1, xcol1, vS1.ActiveSheet.RowCount - 1, getData(vS2, xcol1 + 1, xrow2))

                                End If

                            Next
                        End If
                    Next


                Else 'Cancel

                    Exit Sub

                End If

            End Using

        Catch ex As Exception

        End Try

    End Sub
#End Region

End Class