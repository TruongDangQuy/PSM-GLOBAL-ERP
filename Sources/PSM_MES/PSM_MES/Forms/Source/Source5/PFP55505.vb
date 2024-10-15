Public Class PFP55505

#Region "Variable"
    Protected prg As E_PRG
    Private Dsu01 As Long
    Private Dsu02 As Long
    Private Dsu03 As Long
    Private a7171() As T7171_AREA
    Private b7171() As T7171_AREA
    Private Form_Close As Boolean

    Private CheckChild As Boolean = False
    Private StrSchild As String
#End Region

#Region "Formload"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)
        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()

    End Sub

    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub

    Private Sub FORM_INIT()
        Try
            SdateEdate.text1 = Strings.Left(Pub.DAT, 6) & "01"
            SdateEdate.text2 = Function_Date_Add(CDate(SdateEdate.text1), 1, -1)
        Catch ex As Exception
            SdateEdate.text1 = Strings.Left(Pub.DAT, 6) & "01"
            SdateEdate.text2 = Pub.DAT
        End Try
    End Sub
    Private Sub DATA_INIT()
        StrSchild = "505"
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
                Case Keys.F9 : Call MAIN_JOB05()
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
    End Sub

    Private Sub MAIN_JOB01()

    End Sub

    Private Sub MAIN_JOB02()

    End Sub

    Private Sub MAIN_JOB03()
        If getData(Vs2, 13, Vs2.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
    End Sub

    Private Sub MAIN_JOB04()
        If getData(Vs2, 13, Vs2.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
    End Sub

    Private Sub MAIN_JOB05()
        If getData(Vs2, 12, Vs2.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
    End Sub

#End Region

#Region "PFP_SEARCH"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        Vs1.Enabled = False

        Dim opt_CHK As Long

        DS1 = PrcDS("USP_PFP55505_SEARCH_VS1", cn, StrSchild)

        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            Vs1.ActiveSheet.RowCount = 0
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_PFP55505_SEARCH_VS1", "Vs1")

        Vs1.Enabled = True
        DATA_SEARCH01 = True
    End Function

    Private Function DATA_SEARCH02_LINE(BasicSel As String, BasicCode As String) As Boolean
        Dim DSNEW As New DataSet

        DATA_SEARCH02_LINE = False

        Try
            DSNEW = PrcDS("USP_PFP55505_SEARCH_vS2_LINE", cn, BasicSel, BasicCode)

            If GetDsRc(DSNEW) = 0 Then
                Exit Function
            End If

            READ_SPREAD(Vs2, DSNEW, "USP_PFP55505_SEARCH_VS2", "Vs2", Vs2.ActiveSheet.ActiveRowIndex)

            DATA_SEARCH02_LINE = True
        Catch ex As Exception

        End Try
    End Function
    Private Function DATA_SEARCH02(KSEL As String, Optional KNAME As String = Nothing) As Boolean
        Dim DSNEW As New DataSet

        DATA_SEARCH02 = False

        Try
            If READ_PFK7171(getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex), getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex)) Then
                If FormatCut(D7171.ForeignName2) <> "" Then

                    Call PrcExeNoError("USP_COPY_STORE_PROCEDURE", cn, D7171.ForeignName2, "USP_PFP55505_SEARCH_VS2" & "_" & KSEL)
                    DSNEW = PrcDS("USP_PFP55505_SEARCH_VS2" & "_" & KSEL, cn, SdateEdate.text1, SdateEdate.text2)

                    If GetDsRc(DSNEW) = 0 Then
                        Vs2.ActiveSheet.RowCount = 0
                        Exit Function
                    End If

                    SPR_PRO_NEW(Vs2, DSNEW, "USP_PFP55505_SEARCH_VS2" & "_" & KSEL, "Vs2")

                    DATA_SEARCH02 = True
                Else

                    D7171.ForeignName2 = "USP_PFP71710_SEARCH_VS2"

                    Call PrcExeNoError("USP_COPY_STORE_PROCEDURE", cn, D7171.ForeignName2, "USP_PFP55505_SEARCH_VS2" & "_" & KSEL)
                    DSNEW = PrcDS("USP_PFP55505_SEARCH_VS2" & "_" & KSEL, cn, SdateEdate.text1, SdateEdate.text2)

                    If GetDsRc(DSNEW) = 0 Then
                        Vs2.ActiveSheet.RowCount = 0
                        Exit Function
                    End If

                    SPR_PRO_NEW(Vs2, DSNEW, "USP_PFP55505_SEARCH_VS2" & "_" & KSEL, "Vs2")

                    DATA_SEARCH02 = True

                End If


            End If

        Catch ex As Exception

        End Try
    End Function


#End Region

#Region "EVENT"

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
        Vs1.Enabled = False
        DATA_SEARCH02(getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex))
        Vs1.Enabled = True
    End Sub

    'GOTFOCUS
    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False, WordConv("INSERT") & "(F5)")
    End Sub

    Private Sub Vs2_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs2.CellDoubleClick
        Try
            Dim col As Integer
            Dim Code As String

            Code = getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex)
            col = e.Column

            If CheckData() = False Then Exit Sub
            Dim Row As Integer = e.Row


            Select Case Code
                Case "001"
                    If READ_PFK7101(getData(Vs2, getColumIndex(sender, "KEY_CustomerCode"), Row)) Then
                        Call ISUD7101B.Link_ISUD7101A(3, D7101.CustomerCode, "PFP71010")
                    End If

                Case "002"
                    If READ_PFK7101(getData(Vs2, getColumIndex(sender, "KEY_CustomerCode"), Row)) Then
                        Call ISUD7101B.Link_ISUD7101A(3, D7101.CustomerCode, "PFP71010")
                    End If

                Case "003"
                    If READ_PFK7155(getData(Vs2, getColumIndex(sender, "KEY_MachineCode"), Row)) Then
                        Call ISUD7155A.Link_ISUD7155A(3, D7155.MachineCode, "PFP71550")
                    End If

                Case "004"
                    If READ_PFK7411(getData(Vs2, getColumIndex(sender, "KEY_IDNO"), Row)) Then
                        Call ISUD7411A.Link_ISUD7411A(3, D7411.IDNO, "PFP71550")
                    End If

                Case "006"
                    If READ_PFK7101(getData(Vs2, getColumIndex(sender, "KEY_CustomerCode"), Row)) Then
                        Call ISUD7101B.Link_ISUD7101A(3, D7101.CustomerCode, "PFP71010")
                    End If

                Case Else
                    If READ_PFK7171(getData(Vs2, getColumIndex(sender, "KEY_BasicSel"), Row), getData(Vs2, getColumIndex(sender, "KEY_BasicCode"), Row)) Then
                        Call ISUD7171A.Link_ISUD7171A(3, D7171.BasicSel, D7171.BasicCode, "PFP71710")
                    End If

            End Select

        Catch ex As Exception

        End Try
    End Sub

    Private Sub vS2_GotFocus(sender As Object, e As EventArgs) Handles Vs2.GotFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False, WordConv("INSERT") & "(F5)", WordConv("UPDATE") & "(F6)")
    End Sub

    'LOSTFOCUS
    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles Vs1.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False, WordConv("INSERT") & "(F5)")
    End Sub

    Private Sub Vs1_KeyUp(sender As Object, e As KeyEventArgs) Handles Vs1.KeyUp
        Select Case e.KeyCode
            Case Keys.Down, Keys.Up, Keys.PageDown, Keys.PageUp
                Call vS1_Click(Vs1.ActiveSheet.ActiveColumnIndex, Vs1.ActiveSheet.ActiveRowIndex)
        End Select
    End Sub

    Private Sub vs2_LostFocus(sender As Object, e As EventArgs) Handles Vs2.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INSERT") & "(F5)")
    End Sub

    Private Sub vS1_Click(ByVal Col As Long, ByVal Row As Long)
        If Row < 0 Then Exit Sub
        If getData(Vs1, 12, Row) = "" Then Exit Sub
        Call DATA_SEARCH02(getData(Vs1, 0, Row), getData(Vs1, 1, Row))
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        If DATA_SEARCH01() = True Then
        End If
    End Sub

#End Region

    Private Sub btn_Rearrange_Click(sender As Object, e As EventArgs) Handles btn_Approval.Click
        Try
            Dim Code As String
            Dim PayableNo As String
            Dim i As Integer

            Code = getData(Vs1, getColumIndex(Vs1, "BasicCode"), Vs1.ActiveSheet.ActiveRowIndex)
            PayableNo = getData(Vs2, getColumIndex(Vs2, "PayableNo"), Vs2.ActiveSheet.ActiveRowIndex)

        

            Select Case Code
                Case "002"
                    Msg_Result = MsgBoxP("Do you want to sync data for Payable " & PayableNo, vbYesNo)
                    If Msg_Result = vbNo Then Exit Sub

                    Call PrcExe("SHV_AIS.DBO.PSM_FDT" & Code, cn, pMa_cty, SdateEdate.text1, SdateEdate.text2, PayableNo, Pub.SAW, pIsAll)

                    For i = 0 To Vs2.ActiveSheet.RowCount - 1
                        If PayableNo = getData(Vs2, getColumIndex(Vs2, "PayableNo"), i) Then
                            SPR_CLEAR(Vs2, i, 0, i, Vs2.ActiveSheet.ColumnCount - 1)
                        End If

                    Next


                Case "006"
                    Msg_Result = MsgBoxP("Do you want to clear advance data for Payable " & PayableNo, vbYesNo)
                    If Msg_Result = vbNo Then Exit Sub

                    PayableNo = getData(Vs2, getColumIndex(Vs2, "PayableNo"), Vs2.ActiveSheet.ActiveRowIndex)
                    NewPACount = ""
                    If ISUD3428A.Link_ISUD3428A_AUTO("5", PayableNo, "0", "", "PFP34281") Then

                    End If

                    Call PrcExe("SHV_AIS.DBO.PSM_FDT" & Code, cn, pMa_cty, SdateEdate.text1, SdateEdate.text2, NewPACount, Pub.SAW, pIsAll)

                    For i = 0 To Vs2.ActiveSheet.RowCount - 1
                        If PayableNo = getData(Vs2, getColumIndex(Vs2, "PayableNo"), i) Then
                            SPR_CLEAR(Vs2, i, 0, i, Vs2.ActiveSheet.ColumnCount - 1)
                        End If
                    Next

                Case "010"
                    PayableNo = getData(Vs2, getColumIndex(Vs2, "OrderNo"), Vs2.ActiveSheet.ActiveRowIndex) + getData(Vs2, getColumIndex(Vs2, "OrderNoSeq"), Vs2.ActiveSheet.ActiveRowIndex)

                    Call PrcExe("SHV_AIS.DBO.PSM_FDT" & Code, cn, pMa_cty, Pub.SAW, PayableNo, pIsAll)

                Case "100"
                    PayableNo = getData(Vs2, getColumIndex(Vs2, "Key_CustomerCode"), Vs2.ActiveSheet.ActiveRowIndex)
                    Call PrcExe("SHV_AIS.DBO.PSM_FDT" & Code, cn, pMa_cty, Pub.SAW, PayableNo, pIsAll)

                Case Else
                    Call PrcExe("SHV_AIS.DBO.PSM_FDT" & Code, cn, pMa_cty, SdateEdate.text1, SdateEdate.text2, Pub.SAW, pIsAll)

            End Select

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Vs2_Change(sender As Object, e As ChangeEventArgs) Handles Vs2.Change
        Try
            Dim Code As String
            Dim PayableNo As String
            Dim SeriInvoice As String
            Dim DienGiai As String
            Dim PurchaseInvoice1 As String

            Dim i As Integer

            Code = getData(Vs1, getColumIndex(Vs1, "BasicCode"), Vs1.ActiveSheet.ActiveRowIndex)
            PayableNo = getData(Vs2, getColumIndex(Vs2, "PayableNo"), Vs2.ActiveSheet.ActiveRowIndex)
            PurchaseInvoice1 = getData(Vs2, getColumIndex(Vs2, "PurchaseInvoice1"), Vs2.ActiveSheet.ActiveRowIndex)

            SeriInvoice = getData(Vs2, getColumIndex(Vs2, "SeriInvoice"), Vs2.ActiveSheet.ActiveRowIndex)
            DienGiai = getData(Vs2, getColumIndex(Vs2, "DienGiai"), Vs2.ActiveSheet.ActiveRowIndex)

            Select Case Code
                Case "002"
                    If READ_PFK3428(PayableNo) Then
                        SQL = " UPDATE PFK3429 SET "
                        SQL = SQL & "    K3429_SeriInvoice      =  '" & FormatSQL(SeriInvoice) & "', "
                        SQL = SQL & "    K3429_DienGiai      = N'" & FormatSQL(DienGiai) & "' "

                        SQL = SQL & " WHERE K3429_PayableNo		 = '" & PayableNo & "' "
                        SQL = SQL & "   AND K3429_PurchaseInvoice1		 =  '" & FormatSQL(PurchaseInvoice1) & "'  "
                        cmd = New SqlClient.SqlCommand(SQL, cn)
                        cmd.ExecuteNonQuery()

                    End If

                Case "006"
                    If READ_PFK3428(PayableNo) Then
                        SQL = " UPDATE PFK3429 SET "
                        SQL = SQL & "    K3429_SeriInvoice      =  '" & FormatSQL(SeriInvoice) & "', "
                        SQL = SQL & "    K3429_DienGiai      = N'" & FormatSQL(DienGiai) & "' "

                        SQL = SQL & " WHERE K3429_PayableNo		 = '" & PayableNo & "' "
                        SQL = SQL & "   AND K3429_PurchaseInvoice1		 =  '" & FormatSQL(PurchaseInvoice1) & "'  "
                        cmd = New SqlClient.SqlCommand(SQL, cn)
                        cmd.ExecuteNonQuery()

                    End If

                Case "010"


                Case "100"


                Case Else


            End Select

        Catch ex As Exception

        End Try
    End Sub
    Private Function CheckData() As Boolean
        CheckData = False
        Dim i As Integer
        Dim j As Integer = 1
        Dim GroupCol As List(Of Integer)

        Dim ArrStr As List(Of String)

        Dim Row As Integer = Vs1.ActiveSheet.ActiveRowIndex

        For i = 0 To Vs2.ActiveSheet.ColumnCount - 1
            If getColumName(Vs2, i).Contains("KEY_") Then
                GroupCol.Add(i)
            End If
        Next

        Try
            If READ_PFK7171(getData(Vs1, 0, Row), getData(Vs1, 1, Row)) Then

                For i = 0 To Vs2.ActiveSheet.RowCount - 1
                    If getDataM(Vs2, getColumIndex(Vs2, "DCHK"), i) = "1" Then
                        ArrStr = GetDataArr(i, GroupCol)
                        rd = PrcDR(D7171.ForeignName1, cn, "0", ArrStr)

                        If rd.HasRows Then
                            rd.Read()
                            MsgBoxP(rd(0))
                            rd.Close()
                            Exit Function

                        End If

                        rd.Close()

                    End If

                Next

            End If
            CheckData = True

        Catch ex As Exception

        End Try

    End Function
    Private Sub cmd_NotApproval_Click(sender As Object, e As EventArgs)
        Dim i As Integer
        Dim j As Integer = 1

        Dim GroupCol As List(Of Integer)
        Dim ArrStr As List(Of String)
        Dim Row As Integer = Vs1.ActiveSheet.ActiveRowIndex

        If CheckData() = False Then Exit Sub

        For i = 0 To Vs2.ActiveSheet.ColumnCount - 1
            If getColumName(Vs2, i).Contains("KEY_") Then
                GroupCol.Add(i)
            End If
        Next

        Try
            If READ_PFK7171(getData(Vs1, 0, Row), getData(Vs1, 1, Row)) Then

                For i = 0 To Vs2.ActiveSheet.RowCount - 1
                    If getDataM(Vs2, getColumIndex(Vs2, "DCHK"), i) = "1" Then
                        ArrStr = GetDataArr(i, GroupCol)
                        Call PrcExeNoError(D7171.ForeignName1, cn, "1", ArrStr)
                    End If

                Next

            End If

            Call MsgBoxP("Sucessfully Update!", vbInformation)

        Catch ex As Exception

        End Try
    End Sub
    Private Function GetDataArr(xrow As Integer, _GroupCol As List(Of Integer)) As List(Of String)
        GetDataArr = Nothing

        Try
            Dim i As Integer
            GetDataArr = New List(Of String)

            For i = 0 To _GroupCol.Count - 1
                GetDataArr.Add(getData(Vs2, _GroupCol(i), xrow))
            Next

            Return GetDataArr
        Catch ex As Exception

        End Try

    End Function


    Private Sub Vs2_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs2.CellClick

    End Sub
End Class