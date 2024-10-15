
Public Class ISUD4064B
    Private formA As Boolean
    Private _SizeRange As String
    Private _JobCard As String
    Private _MoldCode As String
    Private W4064 As T4064_AREA
    Private L4064 As T4064_AREA

    Public Function Link_ISUD4064B(job As Integer, sDate As String, eDate As String, JobCard As String, cdMainProcess As String, Optional CheckName As String = "") As Boolean
        Batch_1 = Nothing

        _JobCard = ""
        _JobCard = JobCard

        txt_SealNo.Data = JobCard
        txt_SealNo.Code = JobCard

        txt_cdMainProcess.Code = cdMainProcess

        txt_SdateEdate.text1 = sDate
        txt_SdateEdate.text2 = eDate

        If READ_PFK7171(ListCode("MainProcess"), cdMainProcess) Then
            txt_cdMainProcess.Data = D7171.BasicName
            txt_cdMainProcess.Code = D7171.BasicCode
        End If

        If READ_PFK4010(_JobCard) Then
            txt_QtyOrder.Data = D4010.QtyOrder
        End If

        Link_ISUD4064B = False
        Me.Tag = CheckName

        wJOB = job

        Select Case job
            Case 1, 5, 6

            Case Else
                If READ_PFK4010(_JobCard) Then
                    txt_SdateEdate.text1 = D4010.DateStart
                    txt_SdateEdate.text2 = D4010.DateFinish
                End If
        End Select

        formA = False
        Me.ShowDialog()

        Link_ISUD4064B = isudCHK
    End Function
    Public Function Link_ISUD4064B_AUTO(job As Integer, sDate As String, eDate As String, JobCard As String, cdMainProcess As String, cdFactory As String, cdLineProd As String, QtyBase As String, Optional CheckName As String = "") As Boolean
        Batch_1 = Nothing

        _JobCard = ""
        _JobCard = JobCard

        txt_SealNo.Data = JobCard
        txt_SealNo.Code = JobCard

        txt_cdMainProcess.Code = cdMainProcess

        txt_SdateEdate.text1 = sDate
        txt_SdateEdate.text2 = eDate

        txt_QtyDate.Data = QtyBase

        If READ_PFK7171(ListCode("MainProcess"), cdMainProcess) Then
            txt_cdMainProcess.Data = D7171.BasicName
            txt_cdMainProcess.Code = D7171.BasicCode
        End If

        If READ_PFK7171(ListCode("Factory"), cdFactory) Then
            txt_cdFactory.Data = D7171.BasicName
            txt_cdFactory.Code = D7171.BasicCode
        End If

        If READ_PFK7171(ListCode("LineProd"), cdLineProd) Then
            txt_cdLineProd.Data = D7171.BasicName
            txt_cdLineProd.Code = D7171.BasicCode
        End If

        If READ_PFK4010(_JobCard) Then
            txt_QtyOrder.Data = D4010.QtyOrder
        End If

        Link_ISUD4064B_AUTO = False

        Me.Tag = CheckName

        wJOB = job

        Select Case job
            Case 1, 5, 6

            Case Else
                If READ_PFK4010(_JobCard) Then
                    txt_SdateEdate.text1 = D4010.DateStart
                    txt_SdateEdate.text2 = D4010.DateFinish
                End If

        End Select

        formA = False
        Me.ShowDialog()

        Link_ISUD4064B_AUTO = isudCHK
    End Function


    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Activated
        If formA = True Then Exit Sub

        Me.Form_KeyDown()
        Call DATA_INIT()
        Call DATA_SEARCH_VS1()

        formA = True
    End Sub

    Private Sub DATA_INIT()
        txt_Article.Enabled = False
        txt_cdMainProcess.Enabled = False
        txt_SealNo.Enabled = False
        txt_QtyOrder.Enabled = False
    End Sub

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        Dim Sdate1 As String = ""
        Dim Edate1 As String = ""

        If READ_PFK4064_MIN(_JobCard, txt_cdMainProcess.Code) Then
            Sdate1 = D4064.DatePlan
            txt_cdFactory.Code = D4064.cdFactory
            txt_cdLineProd.Code = D4064.cdLineProd
        Else
            Sdate1 = txt_SdateEdate.text1
        End If

        If READ_PFK4064_MAX(_JobCard, txt_cdMainProcess.Code) Then
            Edate1 = D4064.DatePlan
            txt_cdFactory.Code = D4064.cdFactory
            txt_cdLineProd.Code = D4064.cdLineProd
        Else
            Edate1 = txt_SdateEdate.text2
        End If


        If READ_PFK7171(ListCode("Factory"), txt_cdFactory.Code) Then
            txt_cdFactory.Data = D7171.BasicName
            txt_cdFactory.Code = D7171.BasicCode
            txt_cdFactory.Enabled = False
        End If

        If READ_PFK7171(ListCode("LineProd"), txt_cdLineProd.Code) Then
            txt_cdLineProd.Data = D7171.BasicName
            txt_cdLineProd.Code = D7171.BasicCode
            txt_cdLineProd.Enabled = False
        End If

        Dim Sdate As Date
        Dim Edate As Date
        Dim Value1 As String = ""
        Dim Value2 As String = "IN ("
        Dim i, ColC As Integer

        Sdate = New Date(Strings.Left(Sdate1, 4), Mid(Sdate1, 5, 2), Strings.Right(Sdate1, 2))
        Edate = New Date(Strings.Left(Edate1, 4), Mid(Edate1, 5, 2), Strings.Right(Edate1, 2))

        Dim xTimeSpan As TimeSpan
        xTimeSpan = Edate - Sdate

        ColC = xTimeSpan.Days + 1
        If ColC < 0 Then Exit Function

        If ColC > 90 Then MsgBoxP("Can not search over 3 months! Please adjust schedule date...") : Exit Function

        For i = 0 To ColC - 1
            Value1 += ",ISNULL(SUM([" + Function_Date_Add(Sdate, 0, i) + "]),0) AS [" + FSDate(Function_Date_Add(Sdate, 0, i)) + "] "
            Value2 += "[" + Function_Date_Add(Sdate, 0, i) + "]"
            If i < (ColC - 1) Then Value2 += ","
        Next
        Value2 += ")"
        Value1 = Value1.Trim
        Value2 = Value2.Trim

        DS1 = PrcDS("USP_ISUD4064A_SEARCH_VS10", cn, _JobCard, txt_cdMainProcess.Code, Value1, Value2)

        If GetDsRc(DS1) = 0 Then
            Call DATA_SEARCH_VS1_INSERT()
            Exit Function
        End If

        Dim SCol As Integer

        SPR_PRO_NEW_NO_PFK9911(vS1, DS1, "USP_ISUD4064A_SEARCH_VS10", "Vs1")
        SCol = 3 ' getColumIndex(vS1, "QtyOrder") + 1

        SPR_NUMBERCOLUMN(vS1, 0, SCol, GetDsCc(DS1) - 1)
        SPR_WIDTHCOLRANGE(vS1, 80, SCol, GetDsCc(DS1) - 1)

        vS1.ActiveSheet.Rows.Add(0, 1)

        For i = 0 To ColC - 4
            If Sdate.AddDays(i).DayOfWeek = DayOfWeek.Sunday Then SPR_BACKCOLORCELL(vS1, Color.Red, 4 + i, 0) : GoTo next2
            If Sdate.AddDays(i).DayOfWeek = DayOfWeek.Saturday Then SPR_BACKCOLORCELL(vS1, Color.Blue, 4 + i, 0) Else SPR_BACKCOLORCELL(vS1, Color.Empty, 4 + i, 0)
next2:
        Next

        DATA_SEARCH_VS1 = True
    End Function

    Private Function DATA_SEARCH_VS1_INSERT() As Boolean
        DATA_SEARCH_VS1_INSERT = False
        Dim Sdate As Date
        Dim Edate As Date
        Dim Value1 As String = ""
        Dim Value2 As String = "IN ("
        Dim i, ColC As Integer

        Sdate = New Date(Strings.Left(txt_SdateEdate.text1, 4), Mid(txt_SdateEdate.text1, 5, 2), Strings.Right(txt_SdateEdate.text1, 2))
        Edate = New Date(Strings.Left(txt_SdateEdate.text2, 4), Mid(txt_SdateEdate.text2, 5, 2), Strings.Right(txt_SdateEdate.text2, 2))

        Dim xTimeSpan As TimeSpan
        xTimeSpan = Edate - Sdate

        ColC = xTimeSpan.Days + 1
        If ColC < 0 Then Exit Function

        If ColC > 90 Then MsgBoxP("Can not search over 3 months! Please adjust schedule date...") : Exit Function

        For i = 0 To ColC - 1
            Value1 += ",ISNULL(SUM([" + Function_Date_Add(Sdate, 0, i) + "]),0) AS [" + FSDate(Function_Date_Add(Sdate, 0, i)) + "] "
            Value2 += "[" + Function_Date_Add(Sdate, 0, i) + "]"
            If i < (ColC - 1) Then Value2 += ","
        Next
        Value2 += ")"
        Value1 = Value1.Trim
        Value2 = Value2.Trim

        DS1 = PrcDS("USP_ISUD4061A_SEARCH_VS10_INSERT", cn, txt_cdMainProcess.Code, Value1, Value2)

        SPR_SET(vS1, 5, , , OperationMode.Normal)

        vS1.ActiveSheet.DataSource = DS1.Tables(0)

        vS1.ActiveSheet.ColumnHeader.Rows(0).Height = cSprRowHeaderHeight
        ColC = vS1.ActiveSheet.ColumnCount - 1

        For i = 1 To ColC
            vS1.ActiveSheet.Columns(i).VerticalAlignment = CellVerticalAlignment.Center
            vS1.ActiveSheet.Columns(i).HorizontalAlignment = CellHorizontalAlignment.Right
        Next

        SPR_NUMBERCELL(2, ColC, vS1, 0)

        vS1.ActiveSheet.RowCount = 2

        Dim j As Integer
        For i = 4 To ColC


            For j = 0 To vS1.ActiveSheet.RowCount - 1
                If CIntp(getData(vS1, i, j)) > 0 Then
                    SPR_BACKCOLORCELL(vS1, Color.LightGreen, i, j)
                Else
                    setData(vS1, i, j, Nothing)
                End If
            Next


        Next

        Dim TotalQty As Integer
        Dim CntSunday As Integer

        For i = 0 To ColC - 4
            If Sdate.AddDays(i).DayOfWeek = DayOfWeek.Sunday Then CntSunday += 1
        Next

        SPR_HIDE(vS1, False, 0, 1, 2, 3)

        DATA_SEARCH_VS1_INSERT = True

        For i = 0 To ColC - 4
            If i = ColC - 4 Then
                If Sdate.AddDays(i).DayOfWeek = DayOfWeek.Sunday Then SPR_BACKCOLORCELL(vS1, Color.Red, 4 + i, 0)
                If Sdate.AddDays(i).DayOfWeek = DayOfWeek.Sunday Then setData(vS1, 4 + i - 1, 1, CIntp(txt_QtyOrder.Data) - TotalQty + CIntp(txt_QtyOrder.Data) / (ColC - 3 - CntSunday)) : Exit For

                If CIntp(txt_QtyOrder.Data) > TotalQty Then
                    setData(vS1, 4 + i, 1, CIntp(txt_QtyOrder.Data) - TotalQty) : Exit For
                Else
                    setData(vS1, 4 + i, 1, 0) : Exit For
                End If

                'setData(vS1, 4 + i, 1, txt_QtyDate.Data) : Exit For

            End If

                If Sdate.AddDays(i).DayOfWeek = DayOfWeek.Sunday Then SPR_BACKCOLORCELL(vS1, Color.Red, 4 + i, 0) : GoTo next1
                If Sdate.AddDays(i).DayOfWeek = DayOfWeek.Saturday Then SPR_BACKCOLORCELL(vS1, Color.Blue, 4 + i, 0) Else SPR_BACKCOLORCELL(vS1, Color.Empty, 4 + i, 0)

                TotalQty += CIntp(txt_QtyDate.Data)

                If CIntp(txt_QtyOrder.Data) > TotalQty Then
                    setData(vS1, 4 + i, 1, CIntp(txt_QtyDate.Data))
                Else
                    setData(vS1, 4 + i, 1, 0)
                End If


                'TotalQty += CIntp(txt_QtyOrder.Data) / (ColC - 3 - CntSunday)
                'setData(vS1, 4 + i, 1, CIntp(txt_QtyOrder.Data) / (ColC - 3 - CntSunday))
next1:
        Next


        DATA_SEARCH_VS1_INSERT = True
    End Function

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If txt_cdFactory.Code = "" Then MsgBoxP("Factory,pls!") : Exit Sub
        If txt_cdLineProd.Code = "" Then MsgBoxP("Line Prod,pls!") : Exit Sub

        Dim Sdate As Date
        Dim Edate As Date
        Dim i, ColC As Integer
        Dim xTimeSpan As TimeSpan
        Dim DatePlan As String

        Dim ChkWrite As Boolean = False

        Sdate = New Date(Strings.Left(txt_SdateEdate.text1, 4), Mid(txt_SdateEdate.text1, 5, 2), Strings.Right(txt_SdateEdate.text1, 2))
        Edate = New Date(Strings.Left(txt_SdateEdate.text2, 4), Mid(txt_SdateEdate.text2, 5, 2), Strings.Right(txt_SdateEdate.text2, 2))


        xTimeSpan = Edate - Sdate
        ColC = xTimeSpan.Days + 1

        If ColC < 0 Then MsgBoxP("Wrong Date!") : Exit Sub

        Try

            If DELETE_PFK4064_PROCESS(txt_SealNo.Code, txt_cdMainProcess.Code, txt_cdFactory.Code, txt_cdLineProd.Code) Then

                For i = 0 To ColC - 1
                    DatePlan = Sdate.AddDays(i).Year.ToString("0000")
                    DatePlan &= Sdate.AddDays(i).Month.ToString("00")
                    DatePlan &= Sdate.AddDays(i).Day.ToString("00")

                    If READ_PFK4064_1(txt_SealNo.Code, DatePlan, txt_cdMainProcess.Code, txt_cdFactory.Code, txt_cdLineProd.Code) = False Then
                        W4064.JobCard = txt_SealNo.Code
                        W4064.DatePlan = DatePlan
                        W4064.cdMainProcess = txt_cdMainProcess.Code
                        W4064.cdLineProd = txt_cdLineProd.Code
                        W4064.cdFactory = txt_cdFactory.Code

                        W4064.seMainProcess = ListCode("MainProcess")
                        W4064.seFactory = ListCode("Factory")
                        W4064.seLineProd = ListCode("LineProd")

                        W4064.QtyPlan = CDecp(getData(vS1, i + 4, 1))

                        If W4064.QtyPlan > 0 Then
                            If WRITE_PFK4064(W4064) = True Then

                            End If
                        End If


                    End If
                Next


                If READ_PFK4010(txt_SealNo.Code) Then
                    D4010.DateStart = txt_SdateEdate.text1
                    D4010.DateFinish = txt_SdateEdate.text2
                    Call REWRITE_PFK4010(D4010)
                End If

                Call PrcExeNoError("USP_PFP40160_CLOSSING_FACTORY_LINE", cn, txt_SealNo.Code)
                isudCHK = True
                Me.Dispose()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        Batch_1 = Nothing

        isudCHK = False
        Me.Dispose()
    End Sub

    Private Sub vS1_Change(sender As Object, e As ChangeEventArgs) Handles vS1.Change
        Try
            Dim QtyBatch As Integer
            Dim BatchQty As Integer
            Dim QtySeal As Integer

            QtyBatch = CIntp(getData(sender, e.Column, 2))
            QtySeal = CIntp(getData(sender, e.Column, 1))

            If QtyBatch > 0 Then
                BatchQty = QtySeal / QtyBatch
            Else
                BatchQty = Nothing
                QtyBatch = Nothing
            End If

            setData(sender, e.Column, 3, BatchQty)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub cmd_Search_Click(sender As Object, e As EventArgs) Handles cmd_Search.Click
        Call DATA_SEARCH_VS1_INSERT()
    End Sub

    Private Sub txt_SdateEdate_txtTextChange(sender As Object, e As EventArgs) Handles txt_SdateEdate.txtTextChange
        'If formA = False Then Exit Sub
        'Dim i, ColC As Integer
        'Dim Sdate As Date
        'Dim Edate As Date

        'Sdate = New Date(Strings.Left(txt_SdateEdate.text1, 4), Mid(txt_SdateEdate.text1, 5, 2), Strings.Right(txt_SdateEdate.text1, 2))
        'Edate = New Date(Strings.Left(txt_SdateEdate.text2, 4), Mid(txt_SdateEdate.text2, 5, 2), Strings.Right(txt_SdateEdate.text2, 2))

        'Dim xTimeSpan As TimeSpan
        'xTimeSpan = Edate - Sdate

        'ColC = xTimeSpan.Days + 1

        'If ColC < 0 Then MsgBoxP("Wrong Date!") : Exit Sub

        'Call DATA_SEARCH_VS1()
    End Sub

    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs) Handles cmd_DEL.Click
        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

        If DELETE_PFK4064_PROCESS(txt_SealNo.Code, txt_cdMainProcess.Code, txt_cdFactory.Code, txt_cdLineProd.Code) Then
            Call PrcExeNoError("USP_PFP40160_CLOSSING_FACTORY_LINE", cn, txt_SealNo.Code)
            isudCHK = True
            Me.Dispose()
        End If


    End Sub
End Class