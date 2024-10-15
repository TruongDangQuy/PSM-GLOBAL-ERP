Public Class PFP40732
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Protected prg As E_PRG

    Private W4073 As New T4073_AREA

    Private Form_Close As Boolean
    Private SizeChk As Boolean = False
#End Region

#Region "load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Cms_additem(Cms_1,
                     "SETBALANCE 1 CONTROL - " & "(F7)")

        Call Cms_additem(Cms_2,
                      "LINE PLANNING CONTROL - INSERT " & "(F7)",
                     "LINE PLANNING CONTROL - SEARCH " & "(F8)",
                     "LINE PLANNING CONTROL - UPDATE " & "(F9)",
                     "LINE PLANNING CONTROL - DELETE " & "(F10)")

        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)

        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
    Private Sub PFP40732_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub
    Private Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey
                
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FORM_INIT()
        txt_DatePlan.Data = System_Date_8()
        txt_cdMainProcess.Code = "002"

        If READ_PFK7171(ListCode("MainProcess"), txt_cdMainProcess.Code) Then
            txt_cdMainProcess.Data = D7171.BasicName
            txt_cdMainProcess.Enabled = False
        End If

        
    End Sub

    Private Sub DATA_INIT()

    End Sub

#End Region

#Region "Link"

    Private Sub MAIN_JOB01()

        Dim cdFactory As String
        Dim cdMainProcess As String
        Dim cdLineProd As String
        Dim LineTno As String
        Dim SetKey As String
        Dim Jobcard As String

        If Vs10.Focused Then
            cdFactory = txt_cdFactory.Code
            cdMainProcess = txt_cdMainProcess.Code
            cdFactory = getData(Vs10, getColumIndex(Vs10, "KEY_cdFactory"), Vs10.ActiveSheet.ActiveRowIndex)
            cdLineProd = getData(Vs10, getColumIndex(Vs10, "KEY_cdLineProd"), Vs10.ActiveSheet.ActiveRowIndex)
            LineTno = getData(Vs10, getColumIndex(Vs10, "KEY_LineTno"), Vs10.ActiveSheet.ActiveRowIndex)
            Jobcard = getData(Vs10, getColumIndex(Vs10, "Jobcard"), Vs10.ActiveSheet.ActiveRowIndex)
            If Jobcard = "" Then Exit Sub

            Try
                If ISUD4367A.Link_ISUD4367A(1, "", Jobcard, "050", cdFactory, cdLineProd, Me.Name) Then
                End If

            Catch ex As Exception

            Finally

            End Try

        End If

        If VS20.Focused Then
            cdFactory = txt_cdFactory.Code
            cdMainProcess = txt_cdMainProcess.Code
            cdFactory = getData(VS20, getColumIndex(VS20, "KEY_cdFactory"), VS20.ActiveSheet.ActiveRowIndex)
            SetKey = ""

            cdLineProd = getData(VS20, getColumIndex(VS20, "KEY_cdLineProd"), VS20.ActiveSheet.ActiveRowIndex)
            LineTno = getData(VS20, getColumIndex(VS20, "KEY_LineTno"), VS20.ActiveSheet.ActiveRowIndex)
            'If cdFactory = "" Or cdMainProcess = "" Or cdLineProd = "" Then Exit Sub

            Try
                If ISUD4367A.Link_ISUD4367A(1, SetKey, "", "050", "", "", Me.Name) Then

                End If

            Catch ex As Exception

            Finally

            End Try

        End If

    End Sub

    Private Sub MAIN_JOB02()
        If Date_Check() = False Then Exit Sub

        Dim cdFactory As String
        Dim cdMainProcess As String
        Dim cdLineProd As String
        Dim LineTno As String
        Dim SetKey As String
        Dim JobCard As String

        cdFactory = txt_cdFactory.Code
        cdMainProcess = txt_cdMainProcess.Code

        cdFactory = getData(VS20, getColumIndex(VS20, "KEY_cdFactory"), VS20.ActiveSheet.ActiveRowIndex)
        SetKey = getData(VS20, getColumIndex(VS20, "KEY_SetKey"), VS20.ActiveSheet.ActiveRowIndex)

        cdLineProd = getData(VS20, getColumIndex(VS20, "KEY_cdLineProd"), VS20.ActiveSheet.ActiveRowIndex)
        LineTno = getData(VS20, getColumIndex(VS20, "KEY_LineTno"), VS20.ActiveSheet.ActiveRowIndex)
        JobCard = getData(VS20, getColumIndex(VS20, "KEY_JobCard"), VS20.ActiveSheet.ActiveRowIndex)

        Try
            If ISUD4367A.Link_ISUD4367A(2, SetKey, JobCard, "050", cdFactory, cdLineProd, Me.Name) Then

            End If

        Catch ex As Exception

        Finally

        End Try

    End Sub


    Private Sub MAIN_JOB03()
        If Date_Check() = False Then Exit Sub

        Dim cdFactory As String
        Dim cdMainProcess As String
        Dim cdLineProd As String
        Dim LineTno As String
        Dim SetKey As String
        Dim JobCard As String

        cdFactory = txt_cdFactory.Code
        cdMainProcess = txt_cdMainProcess.Code
        cdFactory = getData(VS20, getColumIndex(VS20, "KEY_cdFactory"), VS20.ActiveSheet.ActiveRowIndex)
        SetKey = getData(VS20, getColumIndex(VS20, "KEY_SetKey"), VS20.ActiveSheet.ActiveRowIndex)

        cdLineProd = getData(VS20, getColumIndex(VS20, "KEY_cdLineProd"), VS20.ActiveSheet.ActiveRowIndex)
        LineTno = getData(VS20, getColumIndex(VS20, "KEY_LineTno"), VS20.ActiveSheet.ActiveRowIndex)
        JobCard = getData(VS20, getColumIndex(VS20, "KEY_JobCard"), VS20.ActiveSheet.ActiveRowIndex)

        Try
            If ISUD4367A.Link_ISUD4367A(3, SetKey, JobCard, "050", cdFactory, cdLineProd, Me.Name) Then

            End If

        Catch ex As Exception

        Finally

        End Try


    End Sub

    Private Sub MAIN_JOB04()
        If Date_Check() = False Then Exit Sub

        Dim cdFactory As String
        Dim cdMainProcess As String
        Dim cdLineProd As String
        Dim LineTno As String
        Dim SetKey As String
        Dim JobCard As String

        cdFactory = txt_cdFactory.Code
        cdMainProcess = txt_cdMainProcess.Code
        cdFactory = getData(VS20, getColumIndex(VS20, "KEY_cdFactory"), VS20.ActiveSheet.ActiveRowIndex)
        SetKey = getData(VS20, getColumIndex(VS20, "KEY_SetKey"), VS20.ActiveSheet.ActiveRowIndex)

        cdLineProd = getData(VS20, getColumIndex(VS20, "KEY_cdLineProd"), VS20.ActiveSheet.ActiveRowIndex)
        LineTno = getData(VS20, getColumIndex(VS20, "KEY_LineTno"), VS20.ActiveSheet.ActiveRowIndex)
        JobCard = getData(VS20, getColumIndex(VS20, "KEY_JobCard"), VS20.ActiveSheet.ActiveRowIndex)

        Try
            If ISUD4367A.Link_ISUD4367A(4, SetKey, JobCard, "050", cdFactory, cdLineProd, Me.Name) Then
                Call DATA_SEARCH_VS20()
            End If

        Catch ex As Exception

        Finally

        End Try


    End Sub

    Private Sub MAIN_JOB05()
      

    End Sub





#End Region

#Region "search"
    Public Function DATA_SEARCH_VS10() As Boolean
        DATA_SEARCH_VS10 = False
        Dim i As Integer
        Dim X1 As Integer

        Try
            DS1 = PrcDS("USP_PFP40732_SEARCH_VS10", cn, txt_cdSeason.Code, txt_cdFactory.Code, txt_cdMainProcess.Code, txt_cdLineProd.Code)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs10, DS1, "USP_PFP40732_SEARCH_VS10", "VS10")
                Vs10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs10, DS1, "USP_PFP40732_SEARCH_VS10", "VS10")

            DS1 = Nothing
            DATA_SEARCH_VS10 = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Private Function DATA_SEARCH_VS11(Optional ByVal xsort As String = "1") As Boolean
        Dim cdFactory As String
        Dim cdMainProcess As String
        Dim cdLineProd As String
        Dim LineTno As String

        DATA_SEARCH_VS11 = False

        cdFactory = txt_cdFactory.Code
        cdMainProcess = txt_cdMainProcess.Code
        cdFactory = getData(Vs10, getColumIndex(Vs10, "KEY_cdFactory"), Vs10.ActiveSheet.ActiveRowIndex)
        cdLineProd = getData(Vs10, getColumIndex(Vs10, "KEY_cdLineProd"), Vs10.ActiveSheet.ActiveRowIndex)
        LineTno = getData(Vs10, getColumIndex(Vs10, "KEY_LineTno"), Vs10.ActiveSheet.ActiveRowIndex)

        If cdLineProd = "" Then Exit Function
        VS11.Enabled = False

        DS1 = PrcDS("USP_PFP40732_SEARCH_VS11", cn, cdFactory,
                                                    cdMainProcess,
                                                    cdLineProd,
                                                    LineTno)

        If GetDsRc(DS1) = 0 Then
            VS11.Enabled = True
            Exit Function
        End If

        SPR_PRO(vS11, DS1, "USP_PFP40732_SEARCH_VS11", "VS11")

        DATA_SEARCH_VS11 = True

        vS11.Enabled = True
    End Function

    Public Function DATA_SEARCH_VS20() As Boolean
        DATA_SEARCH_VS20 = False
        Dim i As Integer
        Dim X1 As Integer

        Try
            DS1 = PrcDS("USP_PFP40732_SEARCH_VS20", cn, txt_cdSeason.Code, txt_cdFactory.Code, txt_cdMainProcess.Code, txt_cdLineProd.Code, txt_DatePlan.Data)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(VS20, DS1, "USP_PFP40732_SEARCH_VS20", "VS20")
                VS20.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(VS20, DS1, "USP_PFP40732_SEARCH_VS20", "VS20")

            DS1 = Nothing
            DATA_SEARCH_VS20 = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function


    Private Function DATA_SEARCH_VS21(Optional ByVal xsort As String = "1") As Boolean
        Dim JobCard As String
        Dim SetKey As String

        DATA_SEARCH_VS21 = False

        JobCard = getData(VS20, getColumIndex(VS20, "KEY_JobCard"), VS20.ActiveSheet.ActiveRowIndex)
        SetKey = getData(VS20, getColumIndex(VS20, "KEY_SetKey"), VS20.ActiveSheet.ActiveRowIndex)
        If JobCard = "" Then Exit Function
        VS21.Enabled = False

        DS1 = PrcDS("USP_PFP40732_SEARCH_VS21", cn, JobCard, SetKey)

        If GetDsRc(DS1) = 0 Then
            VS21.Enabled = True
            Exit Function
        End If

        SPR_PRO(VS21, DS1, "USP_PFP40732_SEARCH_VS20", "VS21")

        DATA_SEARCH_VS21 = True

        VS21.Enabled = True
    End Function

#End Region

#Region "Function"
    Private Function Date_Check() As Boolean
        Date_Check = False
        If txt_DatePlan.Data = System_Date_8() Then
            Date_Check = True
        End If
        Date_Check = True
    End Function

    Private Function CustomerPurchasing_CHK() As String
        CustomerPurchasing_CHK = "1"
        Return CustomerPurchasing_CHK
    End Function

    Private Function GetLineTno(cdFactory As String, cdMainProcess As String, cdLineProd As String) As String
        GetLineTno = ""

        Try
            SQL = "SELECT TOP 1     K4073_LineTno "
            SQL = SQL & "   FROM        PFK4073 "
            SQL = SQL & "   WHERE       K4073_cdFactory    =   '" & cdFactory & "' "
            SQL = SQL & "       AND     K4073_cdMainProcess       =   '" & cdMainProcess & "' "
            SQL = SQL & "       AND     K4073_cdLineProd       =   '" & cdLineProd & "' "
            SQL = SQL & "       AND     K4073_CheckComplete  <>  '2'"
            SQL = SQL & "   ORDER	BY	K4073_LineTno "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then
                GetLineTno = "00"
            Else
                GetLineTno = rd!K4073_LineTno
            End If

            rd.Close()
        Catch ex As Exception
            MsgBoxP("GetLineTno")
        End Try
    End Function


    Private Function KEY_TSEQ(cdFactory As String, cdLineProd As String) As String
        KEY_TSEQ = ""
        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 4)

        Try
            SQL = "SELECT MAX(CAST(K4073_LineTno AS DECIMAL)) AS MAX_MCODE FROM PFK4073 "
            SQL = SQL & " WHERE K4073_cdFactory = '" & cdFactory & "' "
            SQL = SQL & " AND K4073_cdLineProd = '" & cdLineProd & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                rd.Close()
                Exit Function
            Else
                KEY_TSEQ = Format(CInt(rd!MAX_MCODE), "00")
            End If

            rd.Close()
        Catch ex As Exception
            Call MsgBoxP("35", "KEY_TSEQ")
        End Try
    End Function


#End Region

#Region "Event"
    Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click, tst_5.Click, tst_6.Click
     

    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        If ItemMain.SelectedIndex = 0 Then Call DATA_SEARCH_VS10()
        If ItemMain.SelectedIndex = 1 Then Call DATA_SEARCH_VS20()
    End Sub

    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked
        If Cms_1.Items(0).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB01() '1
        End If

    End Sub
    Private Sub Cms_2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_2.ItemClicked
        If Cms_2.Items(0).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB01() '0

        ElseIf Cms_2.Items(1).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB02() '1

        ElseIf Cms_2.Items(2).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB03() '2

        ElseIf Cms_2.Items(3).Selected = True Then
            Cms_2.Hide()
            MAIN_JOB04() '3

        End If
    End Sub

    Private Sub PFP40732_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If SizeChk = False Then Exit Sub
        Try

        Catch ex As Exception
            SizeChk = False
        End Try
    End Sub
    Private Sub Vs10_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellClick
        Call DATA_SEARCH_VS11()

    End Sub

    Private Sub Vs20_CellClick(sender As Object, e As CellClickEventArgs) Handles VS20.CellClick
        Call DATA_SEARCH_VS21()

    End Sub

#End Region




    
End Class