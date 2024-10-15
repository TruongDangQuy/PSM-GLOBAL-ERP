
Public Class ISUD7700B
    Private formA As Boolean
    Private _SizeRange As String
    Private _cdFactory As String
    Private _MoldCode As String
    Private W7700 As T7700_AREA
    Private L7700 As T7700_AREA

    Private Enum colvS1
        cdFactory = 0
        cdFactoryName = 1
        cdOSLineProd = 2
        cdOSLineProdName = 3
        QtyStandard = 4
        Title = 5
    End Enum

    Public Function Link_ISUD7700B(job As Integer, sDate As String, eDate As String, cdMainProcess As String, cdFactory As String, Optional CheckName As String = "") As Boolean
        Batch_1 = Nothing

        _cdFactory = ""
        _cdFactory = cdFactory

        txt_cdMainProcess.Code = cdMainProcess

        txt_SdateEdate.text1 = sDate
        txt_SdateEdate.text2 = eDate

        If READ_PFK7171(ListCode("Factory"), cdFactory) Then
            txt_cdFactory.Data = D7171.BasicName
            txt_cdFactory.Code = D7171.BasicCode
        End If

        If READ_PFK7171(ListCode("MainProcess"), cdMainProcess) Then
            txt_cdMainProcess.Data = D7171.BasicName
            txt_cdMainProcess.Code = D7171.BasicCode
        End If

        Link_ISUD7700B = False
        Me.Tag = CheckName

        wJOB = job

        Select Case job
            Case 1, 5, 6

            Case Else

        End Select

        formA = False
        Me.Show()

        Link_ISUD7700B = isudCHK
    End Function


    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Activated
        If formA = True Then Exit Sub

        Me.Form_KeyDown()
        Call DATA_INIT()
        Call DATA_SEARCH_VS1()

        formA = True
    End Sub

    Private Sub DATA_INIT()
        txt_cdMainProcess.Enabled = False
        txt_cdFactory.Enabled = False
    End Sub

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        Dim Sdate1 As String = ""
        Dim Edate1 As String = ""

        Sdate1 = txt_SdateEdate.text1
        Edate1 = txt_SdateEdate.text2

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

        If ColC > 91 Then MsgBoxP("Can not search over 3 months! Please adjust schedule date...") : Exit Function

        For i = 0 To ColC - 1
            Value1 += ",ISNULL(SUM([" + Function_Date_Add(Sdate, 0, i) + "]),0) AS [" + FSDate(Function_Date_Add(Sdate, 0, i)) + "] "
            Value2 += "[" + Function_Date_Add(Sdate, 0, i) + "]"
            If i < (ColC - 1) Then Value2 += ","
        Next
        Value2 += ")"
        Value1 = Value1.Trim
        Value2 = Value2.Trim

        DS1 = PrcDS("USP_ISUD7700B_SEARCH_VS10", cn, Sdate1, Edate1, txt_cdMainProcess.Code, _cdFactory, Value1, Value2)

        If GetDsRc(DS1) = 0 Then
            Call DATA_SEARCH_VS1_INSERT()
            Exit Function
        End If

        SPR_PRO_NEW(vS1, DS1, "USP_ISUD7700B_SEARCH_VS10", "VS1")
        vS1.ActiveSheet.Rows.Add(0, 1)

        For i = 0 To ColC - 5
            If Sdate.AddDays(i).DayOfWeek = DayOfWeek.Sunday Then SPR_BACKCOLORCELL(vS1, Color.Red, 5 + i, 0) : GoTo next2
            If Sdate.AddDays(i).DayOfWeek = DayOfWeek.Saturday Then SPR_BACKCOLORCELL(vS1, Color.Blue, 5 + i, 0) Else SPR_BACKCOLORCELL(vS1, Color.Empty, 5 + i, 0)
next2:
        Next

        vS1.ActiveSheet.Columns(colvS1.QtyStandard + 1, vS1.ActiveSheet.ColumnCount - 1).Locked = False
        SPR_NUMBERCELL(5, vS1.ActiveSheet.ColumnCount - 1, vS1, 0)

        setDataCH(vS1, colvS1.cdFactory, 0, "cdFactory")
        setDataCH(vS1, colvS1.cdFactoryName, 0, "Factory")
        setDataCH(vS1, colvS1.cdOSLineProd, 0, "Code")
        setDataCH(vS1, colvS1.cdOSLineProdName, 0, "Line")

        DATA_SEARCH_VS1 = True
    End Function

    Private Function DATA_SEARCH_VS1_INSERT() As Boolean
        DATA_SEARCH_VS1_INSERT = False
        Dim Sdate As Date
        Dim Edate As Date
        Dim Value1 As String = ""
        Dim Value2 As String = "IN ("
        Dim i, ColC As Integer
        Dim Sdate1 As String = ""
        Dim Edate1 As String = ""

        Sdate1 = txt_SdateEdate.text1
        Edate1 = txt_SdateEdate.text2

        Sdate = New Date(Strings.Left(txt_SdateEdate.text1, 4), Mid(txt_SdateEdate.text1, 5, 2), Strings.Right(txt_SdateEdate.text1, 2))
        Edate = New Date(Strings.Left(txt_SdateEdate.text2, 4), Mid(txt_SdateEdate.text2, 5, 2), Strings.Right(txt_SdateEdate.text2, 2))

        Dim xTimeSpan As TimeSpan
        xTimeSpan = Edate - Sdate

        ColC = xTimeSpan.Days + 1
        If ColC < 0 Then Exit Function

        If ColC > 91 Then MsgBoxP("Can not search over 3 months! Please adjust schedule date...") : Exit Function

        For i = 0 To ColC - 1
            Value1 += ",ISNULL(SUM([" + Function_Date_Add(Sdate, 0, i) + "]),0) AS [" + FSDate(Function_Date_Add(Sdate, 0, i)) + "] "
            Value2 += "[" + Function_Date_Add(Sdate, 0, i) + "]"
            If i < (ColC - 1) Then Value2 += ","
        Next
        Value2 += ")"
        Value1 = Value1.Trim
        Value2 = Value2.Trim

        vS1.ActiveSheet.RowCount = 0
        DS1 = PrcDS("USP_ISUD7700B_SEARCH_VS10_INSERT_F1", cn, Sdate1, Edate1, txt_cdMainProcess.Code, _cdFactory, Value1, Value2)

        SPR_SET(vS1, 6, 1, , OperationMode.Normal, False)

        vS1.ActiveSheet.DataSource = DS1.Tables(0)

        vS1.ActiveSheet.ColumnHeader.Rows(0).Height = cSprRowHeaderHeight
        ColC = vS1.ActiveSheet.ColumnCount - 1

        For i = 1 To ColC
            vS1.ActiveSheet.Columns(i).VerticalAlignment = CellVerticalAlignment.Center
            vS1.ActiveSheet.Columns(i).HorizontalAlignment = CellHorizontalAlignment.Right
        Next

        SPR_NUMBERCELL(6, ColC, vS1, 0)

        vS1.ActiveSheet.Rows.Add(0, 1)

        Dim j As Integer
        For i = 5 To ColC


            For j = 0 To vS1.ActiveSheet.RowCount - 1
                If CIntp(getData(vS1, i, j)) > 0 Then
                    SPR_BACKCOLORCELL(vS1, Color.LightGreen, i, j)
                Else
                    setData(vS1, i, j, Nothing)
                End If
            Next


        Next


        Dim CntSunday As Integer

        For i = 0 To ColC - 6
            If Sdate.AddDays(i).DayOfWeek = DayOfWeek.Sunday Then CntSunday += 1
        Next

        DATA_SEARCH_VS1_INSERT = True

        For i = 0 To ColC - 6
            If i = ColC - 6 Then
                If Sdate.AddDays(i).DayOfWeek = DayOfWeek.Sunday Then SPR_BACKCOLORCELL(vS1, Color.Red, 6 + i, 0)
            End If

            If Sdate.AddDays(i).DayOfWeek = DayOfWeek.Sunday Then SPR_BACKCOLORCELL(vS1, Color.Red, 6 + i, 0) : GoTo next1
            If Sdate.AddDays(i).DayOfWeek = DayOfWeek.Saturday Then SPR_BACKCOLORCELL(vS1, Color.Blue, 6 + i, 0) Else SPR_BACKCOLORCELL(vS1, Color.Empty, 6 + i, 0)

            For j = 0 To vS1.ActiveSheet.RowCount - 1
                setData(vS1, i + 6, j, getData(vS1, colvS1.QtyStandard, j))
            Next

next1:
        Next


        setDataCH(vS1, colvS1.cdFactory, 0, "cdFactory")
        setDataCH(vS1, colvS1.cdFactoryName, 0, "Factory")
        setDataCH(vS1, colvS1.cdOSLineProd, 0, "Code")
        setDataCH(vS1, colvS1.cdOSLineProdName, 0, "Line")

        
        For i = 0 To vS1.ActiveSheet.RowCount - 1
            setData(vS1, colvS1.Title, i, FUNCTION_PLANNING_TITLE(getData(vS1, colvS1.Title, i)))
        Next

        SPR_MERGEALWAYS(vS1, 0, 1, 2, 3)

        SPR_HIDE(vS1, False, colvS1.cdFactory, colvS1.cdOSLineProd)

        DATA_SEARCH_VS1_INSERT = True
    End Function

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If txt_cdFactory.Code = "" Then MsgBoxP("Factory,pls!") : Exit Sub

        Dim Sdate As Date
        Dim Edate As Date
        Dim i, j, ColC As Integer
        Dim xTimeSpan As TimeSpan
        Dim DateTarget As String

        Dim ChkWrite As Boolean = False

        Sdate = New Date(Strings.Left(txt_SdateEdate.text1, 4), Mid(txt_SdateEdate.text1, 5, 2), Strings.Right(txt_SdateEdate.text1, 2))
        Edate = New Date(Strings.Left(txt_SdateEdate.text2, 4), Mid(txt_SdateEdate.text2, 5, 2), Strings.Right(txt_SdateEdate.text2, 2))


        xTimeSpan = Edate - Sdate

        ColC = xTimeSpan.Days + 1


        Try

            For j = 1 To vS1.ActiveSheet.RowCount - 1
                For i = 0 To ColC - 1

                    'DateTarget = Sdate.AddDays(i).Year.ToString("0000")
                    'DateTarget &= Sdate.AddDays(i).Month.ToString("00")
                    'DateTarget &= Sdate.AddDays(i).Day.ToString("00")

                    DateTarget = getColumName(vS1, i + 5)
                    DateTarget = FormatCut(DateTarget)

                    If DELETE_PFK7700_1(DateTarget, txt_cdMainProcess.Code, txt_cdFactory.Code, getData(vS1, colvS1.cdOSLineProd, j)) Then
                        If READ_PFK7700_1(DateTarget, txt_cdMainProcess.Code, txt_cdFactory.Code, getData(vS1, colvS1.cdOSLineProd, j)) = False Then
                            W7700.DateTarget = DateTarget
                            W7700.cdMainProcess = txt_cdMainProcess.Code
                            W7700.cdOSLineProd = getData(vS1, colvS1.cdOSLineProd, j)
                            W7700.cdFactory = txt_cdFactory.Code

                            W7700.seMainProcess = ListCode("MainProcess")
                            W7700.seFactory = ListCode("Factory")
                            W7700.seOSLineProd = ListCode("OSLineProd")

                            W7700.QtyTarget = CDecp(getData(vS1, i + 5, j))

                            If W7700.QtyTarget >= 0 Then
                                If WRITE_PFK7700(W7700) = True Then
                                    ChkWrite = True
                                End If
                            End If


                        End If
                    End If
                Next
            Next

            isudCHK = True
            Me.Dispose()


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

        Catch ex As Exception

        End Try
    End Sub


    Private Sub cmd_Search_Click(sender As Object, e As EventArgs) Handles cmd_Search.Click
        Call DATA_SEARCH_VS1()

    End Sub

    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles vS1.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete

                Call Select_Message("3", WordConv("PROCESSING"), 2)

                If Msg_Result <> vbYes Then Exit Sub
                Dim DateTarget As String
                Dim cdOSLineProd As String

                DateTarget = getColumName(vS1, vS1.ActiveSheet.ActiveColumnIndex)
                DateTarget = FormatCut(DateTarget)
                cdOSLineProd = getData(vS1, colvS1.cdOSLineProd, vS1.ActiveSheet.ActiveRowIndex)

                If DELETE_PFK7700_1(DateTarget, txt_cdMainProcess.Code, txt_cdFactory.Code, cdOSLineProd) Then
                    setData(vS1, vS1.ActiveSheet.ActiveColumnIndex, vS1.ActiveSheet.ActiveRowIndex, 0)
                End If



        End Select

    End Sub
End Class