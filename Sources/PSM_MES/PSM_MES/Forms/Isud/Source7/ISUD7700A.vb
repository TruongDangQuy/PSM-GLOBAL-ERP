
Public Class ISUD7700A

#Region "Variable"
    Private wJOB As Integer

    Private KEY_CHK As String
    Private WRITE_CHK As String

    Private W7700 As T7700_AREA
    Private L7700 As T7700_AREA

    Private formA As Boolean

    Private checkisud As Boolean

    Private CHK(0 To 5) As String

    Private strFormName As String
    Private Value As String = ""

    Private Enum colvS20
        cdMainProcess = 0
        cdMainProcessName = 1
        cdFactory = 2
        cdFactoryName = 3
        cdOSLineProd = 4
        cdOSLineProdName = 5

    End Enum
#End Region

#Region "Link_ISUD"
    Public Function Link_ISUD7700A(job As Integer, cdMainProcess As String, Optional CheckName As String = "") As Boolean
        If strFormName = "" Then strFormName = Me.Text
        Me.Tag = CheckName

        D7700.cdMainProcess = cdMainProcess

        If READ_PFK7171(ListCode("MainProcess"), cdMainProcess) Then
            txt_cdMainProcess.Code = D7171.BasicCode
            txt_cdMainProcess.Data = D7171.BasicName
        End If

        wJOB = job : L7700 = D7700

        Link_ISUD7700A = False

        Select Case job
            Case 1, 5, 6

            Case Else


        End Select

        formA = False
        Me.Show()

        Link_ISUD7700A = isudCHK
    End Function


#End Region

#Region "Form_load"

    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Activated
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_KeyDown()
        Call DATA_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

begin:
        Select Case wJOB
            Case 1
                Me.Text = strFormName & " - INSERT"
                checkisud = False
                Call KEY_COUNT()
                Call KEY_COUNT_NO()
                cmd_DEL.Visible = False

                Call DATA_SEARCH_VS00()
                Call DATA_SEARCH_VS10()
                Call DATA_SEARCH_VS20()

                Setfocus(txt_cdMainProcess)

                If CHK(1) <> "1" Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If
                wJOB = 3
                checkisud = True
            Case 2
                Me.Text = strFormName & " - SEARCH"
                checkisud = True
                cmd_DEL.Visible = False
                cmd_OK.Visible = False

                'Call DisableAllType()

                If CHK(2) <> "1" Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_DETAIL()
                Call DATA_SEARCH_VS00()
                Call DATA_SEARCH_VS10()
                Call DATA_SEARCH_VS20()

            Case 3
NEXT1:
                Me.Text = strFormName & " - UPDATE"
                checkisud = True
                cmd_DEL.Visible = False

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_DETAIL()
                Call DATA_SEARCH_VS00()
                Call DATA_SEARCH_VS10()
                Call DATA_SEARCH_VS20()

                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        formA = True
                        Me.Dispose()
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else
                        Me.Text = strFormName & " - SEARCH"
                        isudCHK = False
                        wJOB = 2
                        cmd_DEL.Visible = False
                        GoTo Begin
                    End If
                End If

            Case 4
                Me.Text = strFormName & " - DELETE"
                cmd_DEL.Visible = True

                checkisud = True
                cmd_OK.Visible = False

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_DETAIL()
                Call DATA_SEARCH_VS00()
                Call DATA_SEARCH_VS10()
                Call DATA_SEARCH_VS20()

                If CHK(4) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        formA = True
                        Me.Dispose()
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else
                        Me.Text = strFormName & " - SEARCH"
                        isudCHK = False
                        wJOB = 2
                        cmd_DEL.Visible = False
                        GoTo Begin
                    End If
                End If

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Me.WindowState = FormWindowState.Maximized
        KEY_CHK = ""

        Call Cms_additem(Cms_2, _
                  "PLANNING WORKING PROCESSING - " & WordConv("INSERT") & "(F5)", _
                  "PLANNING WORKING PROCESSING - " & WordConv("DELETE") & "(F6)")

        Vs10.ContextMenuStrip = Cms_2

        txt_SdateEdate.text1 = Pub.DAT
        txt_SdateEdate.text2 = Function_Date_Add(CDate(FSDate(Pub.DAT)), 0, 30)

    End Sub

#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH_IMAGE() As Boolean
        Dim ds As New DataSet
        DATA_SEARCH_IMAGE = False

        DATA_SEARCH_IMAGE = True

    End Function
    Private Function DATA_SEARCH_HEAD() As Boolean
        DATA_SEARCH_HEAD = False
        'DS1 = READ_PFK7700(L7700.cdMainProcess, cn)

        If GetDsRc(DS1) = 0 Then Exit Function

        Call READER_MOVE(Me, DS1)

        DS1 = Nothing

        DATA_SEARCH_HEAD = True

    End Function
    Private Function DATA_SEARCH_DETAIL() As Boolean
        DATA_SEARCH_DETAIL = False

        DATA_SEARCH_DETAIL = True
    End Function
    Private Sub DATA_SEARCH_LINE(Type As String, XROW As Integer, ByVal ParamArray strPara() As String)
        Try
            Select Case Type.ToUpper
                Case "VS00"

                Case "VS10"
                    DS1 = PrcDS("USP_ISUD7700A_SEARCH_VS10_LINE", cn, strPara)
                    If GetDsRc(DS1) = 0 Then Exit Sub

                    Call READ_SPREAD(Vs10, DS1, "USP_ISUD7700A_SEARCH_VS10", "VS10", XROW)
                    DS1 = Nothing

                Case "VS20"
                    DS1 = PrcDS("USP_ISUD7700A_SEARCH_VS20_LINE", cn, strPara)
                    If GetDsRc(DS1) = 0 Then Exit Sub

                    Call READ_SPREAD(vS20, DS1, "USP_ISUD7700A_SEARCH_VS20", "VS20", XROW)
                    DS1 = Nothing

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataTransfer(Value As Boolean, Xcol As Integer, Xrow As Integer)

    End Sub
    Private Function DATA_SEARCH_VS00() As Boolean
        DATA_SEARCH_VS00 = False

        DATA_SEARCH_VS00 = True
    End Function

    Private Function DATA_SEARCH_VS10() As Boolean
        DATA_SEARCH_VS10 = False

        DS1 = PrcDS("USP_ISUD7700A_SEARCH_VS10", cn, txt_cdMainProcess.Code, txt_SdateEdate.text1, txt_SdateEdate.text2)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs10, DS1, "USP_ISUD7700A_SEARCH_VS10", "VS10")
            Vs10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs10, DS1, "USP_ISUD7700A_SEARCH_VS10", "VS10")
        Vs10.Enabled = True

        DATA_SEARCH_VS10 = True
    End Function


    Private Function DATA_SEARCH_VS20() As Boolean
        DATA_SEARCH_VS20 = False
        Dim Sdate As Date
        Dim Edate As Date
        Dim Value1 As String = ""
        Dim Value2 As String = "IN ("
        Dim i, ColC As Integer
        Dim cdFactory As String

        cdFactory = getData(Vs10, getColumIndex(Vs10, "cdFactory"), Vs10.ActiveSheet.ActiveRowIndex)

        Sdate = New Date(Strings.Left(txt_SdateEdate.text1, 4), Mid(txt_SdateEdate.text1, 5, 2), Strings.Right(txt_SdateEdate.text1, 2))
        Edate = New Date(Strings.Left(txt_SdateEdate.text2, 4), Mid(txt_SdateEdate.text2, 5, 2), Strings.Right(txt_SdateEdate.text2, 2))

        vS20.ActiveSheet.RowCount = 0

        Dim xTimeSpan As TimeSpan
        xTimeSpan = Edate - Sdate

        ColC = xTimeSpan.Days + 1
        If ColC < 0 Then Exit Function

        If ColC > 91 Then MsgBoxP("Can not search over 90 days! Please adjust schedule date...") : Exit Function

        For i = 0 To ColC - 1
            Value1 += ",ISNULL(SUM([" + Function_Date_Add(Sdate, 0, i) + "]),0) AS [" + FSDate(Function_Date_Add(Sdate, 0, i)) + "] "
            Value2 += "[" + Function_Date_Add(Sdate, 0, i) + "]"
            If i < (ColC - 1) Then Value2 += ","
        Next
        Value2 += ")"
        Value1 = Value1.Trim
        Value2 = Value2.Trim

        DS1 = PrcDS("USP_ISUD7700A_SEARCH_DATE_PIVOT", cn, txt_SdateEdate.text1, txt_SdateEdate.text2, txt_cdMainProcess.Code, cdFactory, Value1, Value2)

        SPR_SET(vS20, 7, , , OperationMode.Normal)

        vS20.ActiveSheet.DataSource = DS1.Tables(0)

        vS20.ActiveSheet.ColumnHeader.Rows(0).Height = cSprRowHeaderHeight
        ColC = vS20.ActiveSheet.ColumnCount - 1

        For i = 6 To ColC
            vS20.ActiveSheet.Columns(i).VerticalAlignment = CellVerticalAlignment.Center
            vS20.ActiveSheet.Columns(i).HorizontalAlignment = CellHorizontalAlignment.Right
        Next

        SPR_NUMBERCELL(6, ColC, vS20, 0)
        vS20.ActiveSheet.ColumnHeader.RowCount = 2

        setDataCH(vS20, colvS20.cdMainProcess, 0, "cdMainProcess")
        setDataCH(vS20, colvS20.cdMainProcessName, 0, "cdMainProcessName")
        setDataCH(vS20, colvS20.cdFactory, 0, "Code")
        setDataCH(vS20, colvS20.cdFactoryName, 0, "Factory")
        setDataCH(vS20, colvS20.cdOSLineProd, 0, "Code")
        setDataCH(vS20, colvS20.cdOSLineProdName, 0, "Line")

        vS20.ActiveSheet.Columns(colvS20.cdMainProcessName).Visible = False
        vS20.ActiveSheet.Columns(colvS20.cdFactory).Visible = False
        vS20.ActiveSheet.Columns(colvS20.cdOSLineProd).Visible = False



        Dim j As Integer
        For i = 7 To ColC
            If Sdate.AddDays(i - 7).DayOfWeek = DayOfWeek.Sunday Then setDataCH(vS20, i, 1, "SUN")
            If Sdate.AddDays(i - 7).DayOfWeek = DayOfWeek.Monday Then setDataCH(vS20, i, 1, "MON")
            If Sdate.AddDays(i - 7).DayOfWeek = DayOfWeek.Tuesday Then setDataCH(vS20, i, 1, "TUE")
            If Sdate.AddDays(i - 7).DayOfWeek = DayOfWeek.Wednesday Then setDataCH(vS20, i, 1, "WED")
            If Sdate.AddDays(i - 7).DayOfWeek = DayOfWeek.Thursday Then setDataCH(vS20, i, 1, "THU")
            If Sdate.AddDays(i - 7).DayOfWeek = DayOfWeek.Friday Then setDataCH(vS20, i, 1, "FRI")
            If Sdate.AddDays(i - 7).DayOfWeek = DayOfWeek.Saturday Then setDataCH(vS20, i, 1, "SAT")

            setDataCH(vS20, i, 0, Sdate.AddDays(i - 7).Month.ToString("00") & "/" & Sdate.AddDays(i - 6).Day.ToString("00"))

            For j = 0 To vS20.ActiveSheet.RowCount - 1
                If CIntp(getData(vS20, i, j)) > 0 Then
                    'SPR_BACKCOLORCELL(vS20, Color.LightGreen, i, j)
                Else
                    setData(vS20, i, j, Nothing)
                End If
            Next
        Next

        SPR_TOTALHEAD(vS20, 6, vS20.ActiveSheet.ColumnCount - 1)

        vS20.ActiveSheet.ColumnHeader.Cells(0, colvS20.cdMainProcess).RowSpan = 2
        vS20.ActiveSheet.ColumnHeader.Cells(0, colvS20.cdFactoryName).RowSpan = 2
        vS20.ActiveSheet.ColumnHeader.Cells(0, colvS20.cdOSLineProdName).RowSpan = 2

        DATA_SEARCH_VS20 = True



    End Function



#End Region

#Region "Function"

    Private Sub KEY_COUNT()

    End Sub

    Private Sub KEY_COUNT_JOBCARD()

    End Sub
    Private Sub KEY_COUNT_NO()

    End Sub

    Private Sub KEY_COUNT_SNO()
        If KEY_CHK = "*" Then Exit Sub
        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 2)

    End Sub

    Private Function DATA_DELETE_MATERIAL() As Boolean
        DATA_DELETE_MATERIAL = False
    End Function

    Private Function DATA_DELETE_PROCESS() As Boolean
        DATA_DELETE_PROCESS = False
    End Function

    Private Function DATA_DELETE_COST() As Boolean
        DATA_DELETE_COST = False
    End Function

    Private Function DATA_DELETE_REMARK() As Boolean
        DATA_DELETE_REMARK = False
    End Function



    Private Function DATA_MOVE_K7700() As Boolean
        DATA_MOVE_K7700 = False

        Try


            DATA_MOVE_K7700 = True
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INSERT")
        End Try

    End Function
    Private Function CheckExist(cdMainProcess As String, cdMainProcessSeq As String) As Boolean
        CheckExist = False

        Dim RC As Integer
        Try
            rd = PrcDR("USP_ISUD7700A_SEARCH_VS00_CHECKEXIST", cn, cdMainProcess, cdMainProcessSeq)

            If rd.HasRows = True Then
                rd.Read()
                RC = rd!RC
                If RC > 0 Then MsgBoxP("Next Data Already!") : rd.Close() : CheckExist = True : Exit Function
            End If

            rd.Close()
        Catch ex As Exception

        Finally
            If rd IsNot Nothing Then
                If rd.IsClosed = False Then
                    rd.Close()
                End If
            End If
        End Try

    End Function


    Private Sub DATA_MOVE_DEFAULT()
        W7700.seMainProcess = ListCode("MainProcess")
    End Sub

#End Region

#Region "Event"
    Private Sub cmd_Refresh_Click(sender As Object, e As EventArgs) Handles cmd_Search.Click
        Call DATA_SEARCH_VS00()
        Call DATA_SEARCH_VS10()
        Call DATA_SEARCH_VS20()
        Call DATA_SEARCH_DETAIL()
    End Sub
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Try

            Select Case wJOB
                Case 1 ' Insert

                    If checkisud = False Then
                        If DataCheck(Me, "PFK7700") = False Then MsgBoxP("Fill correct data !") : Exit Sub
                        Call KEY_COUNT()

                        If DATA_MOVE_K7700() = True Then
                            checkisud = True
                        End If

                    End If
                Case 2 ' Search
                    Me.Dispose()

                Case 3 ' Update
                    If checkisud = False Then
                        If DataCheck(Me, "PFK7700") = False Then MsgBoxP("Fill correct data !") : Exit Sub

                        If DATA_MOVE_K7700() = True Then

                        End If
                        checkisud = True
                    Else
                        If DataCheck(Me, "PFK7700") = False Then Exit Sub

                        If DATA_MOVE_K7700() = True Then

                        End If

                        checkisud = True
                    End If


            End Select
        Catch ex As Exception
            MsgBoxP("Has error in saving this item!")
        End Try

    End Sub

    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        If wJOB = 2 Then
            isudCHK = False
            Me.Dispose()
        Else
            isudCHK = True
            Me.Dispose()
        End If
    End Sub

    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs) Handles cmd_DEL.Click
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "cmd_DEL_Click")
            Exit Sub
        End If
        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

    End Sub

    Private Sub Vs10_CellClick1(sender As Object, e As CellClickEventArgs) Handles Vs10.CellClick
        If e.Column = getColumIndex(Vs10, "DateStart") Or e.Column = getColumIndex(Vs10, "DateFinish") Then
            If getData(Vs10, e.Column, e.Row) = "" Then Exit Sub
            Call vS_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.Enter))
        End If
    End Sub


    Private Sub vS_Change(sender As Object, e As ChangeEventArgs) Handles Vs10.Change, vS20.Change
        Call vS_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.Enter))
    End Sub

    Private Sub vS_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs10.KeyDown, vS20.KeyDown
        Dim xCOL As Integer
        Dim xROW As Integer

        xCOL = sender.ActiveSheet.ActiveColumnIndex
        xROW = sender.ActiveSheet.ActiveRowIndex

        'If xCOL = getColumIndex(sender, "CheckUse") Then Exit Sub

        If e.Shift = True Then Exit Sub

        Select Case e.KeyCode
            Case Keys.Delete

                Call Select_Message("3", WordConv("PROCESSING"), 2)

                If Msg_Result <> vbYes Then Exit Sub

                Select Case True
                    Case sender Is Vs10


                    Case sender Is vS20
                End Select

                sender.ActiveSheet.ActiveColumnIndex = xCOL
                sender.ActiveSheet.ActiveRowIndex = xROW
                sender.Focus()

            Case Keys.Enter
                If wJOB = 2 Then Exit Sub

                sender.ActiveSheet.ActiveColumnIndex = xCOL
                sender.ActiveSheet.ActiveRowIndex = xROW
                sender.Focus()

        End Select
    End Sub

    Private Sub cmd_AttachID_Click(sender As Object, e As EventArgs) Handles cmd_AttachID.Click
        Call DATA_SEARCH_HEAD()
    End Sub

    Private Sub Cms_2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_2.ItemClicked
        Cms_2.Hide()
        If txt_cdMainProcess.Code = "" Then MsgBoxP("Process Pls!") : Exit Sub
        Dim DateStart As String
        Dim DateFinish As String
        Dim cdFactory As String

        DateStart = txt_SdateEdate.text1
        DateFinish = txt_SdateEdate.text2
        cdFactory = getData(Vs10, getColumIndex(Vs10, "cdFactory"), Vs10.ActiveSheet.ActiveRowIndex)

        If ISUD7700B.Link_ISUD7700B("1", DateStart, DateFinish, txt_cdMainProcess.Code, cdFactory, Me.Tag) = False Then Exit Sub

        Call DATA_SEARCH_VS20()
    End Sub

#End Region

#Region "Print"
#End Region





End Class