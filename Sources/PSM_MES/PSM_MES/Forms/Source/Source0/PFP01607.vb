Public Class PFP01607
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Private Form_Close As Boolean
    Private SizeChk As Boolean = False
#End Region

#Region "load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)

        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
    Private Sub PFP01607_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub
    Private Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey
                Case Keys.F5 : Call MAIN_JOB06()
                Case Keys.F6 : Call MAIN_JOB11()
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FORM_INIT()
        Me.chk_FormEnterkey = False
    End Sub

    Private Sub DATA_INIT()
        'Psc_1.Panel1Collapsed = True
        'Psc_2.Panel1Collapsed = True
        'Psc_3.Panel1Collapsed = True

        'Psc_0.Panel2Collapsed = False
    End Sub

#End Region

#Region "Link"

    Private Sub MAIN_JOB01()
       
    End Sub

    Private Sub MAIN_JOB02()
       
    End Sub


    Private Sub MAIN_JOB03()
       
    End Sub

    Private Sub MAIN_JOB04()
       
    End Sub

    Private Sub MAIN_JOB05()
       
    End Sub

    Private Sub MAIN_JOB06()


    End Sub
    Private Sub MAIN_JOB06_1()


    End Sub

    Private Sub MAIN_JOB07()
        
    End Sub

    Private Sub MAIN_JOB08()
      
    End Sub

    Private Sub MAIN_JOB09()
       
    End Sub

    Private Sub MAIN_JOB11()
     
    End Sub

    Private Sub MAIN_JOB12()
       
    End Sub

    Private Sub MAIN_JOB13()
     
    End Sub

    Private Sub MAIN_JOB14()
      
    End Sub


    Private Sub MAIN_JOB02_1()
       
    End Sub


    Private Sub MAIN_JOB03_1()
      

    End Sub

    Private Sub MAIN_JOB04_1()
        
    End Sub

    Private Sub MAIN_JOB05_1()
       
    End Sub

#End Region

#Region "search"

    Public Function DATA_SEARCH01(MachineType As String) As Boolean
      
    End Function


    Private Function DATA_SEARCH_vS1(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_vS1 = False

        Dim KEY_OrderNo As String
        Dim KEY_OrderNoSeq As String
        Dim KEY_JobCard As String

        KEY_OrderNo = getData(vs_Job, getColumIndex(vs_Job, "KEY_OrderNo"), vs_Job.ActiveSheet.ActiveRowIndex)
        KEY_OrderNoSeq = getData(vs_Job, getColumIndex(vs_Job, "KEY_OrderNoSeq"), vs_Job.ActiveSheet.ActiveRowIndex)
        KEY_JobCard = getData(vs_Job, getColumIndex(vs_Job, "KEY_JobCard"), vs_Job.ActiveSheet.ActiveRowIndex)


        vS1.Enabled = True

        If READ_PFK1312(KEY_OrderNo, KEY_OrderNoSeq) = False Then Exit Function

        Try
            DS1 = PrcDS("USP_PFP01607_SEARCH_vS1_F1", cn, KEY_OrderNo, KEY_OrderNoSeq, KEY_JobCard)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS1, DS1, "USP_PFP01607_SEARCH_vS1_F1", "vS1")
                vS1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS1, DS1, "USP_PFP01607_SEARCH_vS1_F1", "vS1")

            Call VsSizeRangeTitle_FixColumn(vS1, "USP_PFP01607_SEARCH_vS1_HEAD", "QtyTotal", D1312.ShoesCode)

            DATA_SEARCH_vS1 = True

            vS1.Enabled = True

        Catch ex As Exception

        End Try

    End Function

    'Private Function DATA_SEARCH_vS1(Optional ByVal xsort As String = "1") As Boolean
    '    Dim cdSeason As String
    '    Dim CustomerCode As String
    '    Dim JobCard As String
    '    Dim MoldCode As String

    '    MoldCode = getData(vS_Line, getColumIndex(vS_Line, "MoldCode"), vS_Line.ActiveSheet.ActiveRowIndex)
    '    cdSeason = getData(vs_Season, getColumIndex(vs_Season, "BasicCode"), vs_Season.ActiveSheet.ActiveRowIndex)
    '    CustomerCode = getData(vS_Cus, getColumIndex(vS_Cus, "CustomerCode"), vS_Cus.ActiveSheet.ActiveRowIndex)
    '    JobCard = getData(vs_Job, getColumIndex(vs_Job, "KEY_JobCard"), vs_Job.ActiveSheet.ActiveRowIndex)

    '    Dim i As Integer

    '    DATA_SEARCH_vS1 = False

    '    DS1 = PrcDS("USP_PFP01607_SEARCH_vS1", cn, cdSeason, CustomerCode, MoldCode, JobCard)

    '    If GetDsRc(DS1) = 0 Then
    '        SPR_PRO_NEW(vS1, DS1, "USP_PFP01607_SEARCH_vS1", "vS1")
    '        vS1.Enabled = True
    '        Exit Function
    '    End If

    '    SPR_PRO_NEW(vS1, DS1, "USP_PFP01607_SEARCH_vS1", "vS1")
    '    DATA_SEARCH_vS1 = True

    '    vS1.Enabled = True
    'End Function


    Private Sub DATA_SEARCH_ALL()

    End Sub

    Public Function DATA_SEARCH_HEAD_vs_Season() As Boolean
        DATA_SEARCH_HEAD_vs_Season = False

        Try
            DS1 = PrcDS("USP_PFP01607_SEARCH_VS_SEASON", cn, ListCode("Season"))
            SPR_PRO_NEW(vs_Season, DS1, "USP_PFP01607_SEARCH_VS_SEASON", "vs_Season")

            DS1 = Nothing
            DATA_SEARCH_HEAD_vs_Season = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS_Cus() As Boolean
        DATA_SEARCH_HEAD_vS_Cus = False

        Dim cdSeason As String
        cdSeason = getData(vs_Season, getColumIndex(vs_Season, "BasicCode"), vs_Season.ActiveSheet.ActiveRowIndex)

        Dim CustomerCode As String
        CustomerCode = getData(vS_Cus, getColumIndex(vS_Cus, "CustomerCode"), vS_Cus.ActiveSheet.ActiveRowIndex)


        Try
            DS1 = PrcDS("USP_PFP01607_SEARCH_vS_Cus", cn, CustomerCode, cdSeason)
            SPR_PRO_NEW(vS_Cus, DS1, "USP_PFP01607_SEARCH_vS_Cus", "vS_Cus")

            DS1 = Nothing
            DATA_SEARCH_HEAD_vS_Cus = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function

    Public Function DATA_SEARCH_HEAD_vS_Line() As Boolean
        DATA_SEARCH_HEAD_vS_Line = False
        Dim cdSeason As String
        Dim CustomerCode As String

        cdSeason = getData(vs_Season, getColumIndex(vs_Season, "BasicCode"), vs_Season.ActiveSheet.ActiveRowIndex)
        CustomerCode = getData(vS_Cus, getColumIndex(vS_Cus, "CustomerCode"), vS_Cus.ActiveSheet.ActiveRowIndex)


        Try
            DS1 = PrcDS("USP_PFP01607_SEARCH_vS_Line", cn, cdSeason, CustomerCode)
            SPR_PRO_NEW(vS_Line, DS1, "USP_PFP01607_SEARCH_vS_Line", "vS_Line")

            DS1 = Nothing
            DATA_SEARCH_HEAD_vS_Line = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function


    Public Function DATA_SEARCH_HEAD_vs_Job() As Boolean
        DATA_SEARCH_HEAD_vs_Job = False
        Dim cdSeason As String
        Dim CustomerCode As String
        Dim MoldCode As String

        cdSeason = getData(vs_Season, getColumIndex(vs_Season, "BasicCode"), vs_Season.ActiveSheet.ActiveRowIndex)
        CustomerCode = getData(vS_Cus, getColumIndex(vS_Cus, "CustomerCode"), vS_Cus.ActiveSheet.ActiveRowIndex)
        MoldCode = getData(vS_Line, getColumIndex(vS_Line, "MoldCode"), vS_Line.ActiveSheet.ActiveRowIndex)

        Try
            DS1 = PrcDS("USP_PFP01607_SEARCH_vs_Job", cn, cdSeason, CustomerCode, MoldCode)
            SPR_PRO_NEW(vs_Job, DS1, "USP_PFP01607_SEARCH_vs_Job", "vs_Job")
            DS1 = Nothing
            DATA_SEARCH_HEAD_vs_Job = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function


    Private Sub vs_Season_CellClick(sender As Object, e As CellClickEventArgs) Handles vs_Season.CellDoubleClick

        vS_Cus.ActiveSheet.RowCount = 0
        vS_Line.ActiveSheet.RowCount = 0
        vs_Job.ActiveSheet.RowCount = 0

        Call DATA_SEARCH_HEAD_vS_Cus()

    End Sub
    Private Sub vS_Cus_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Cus.CellDoubleClick

        vS_Line.ActiveSheet.RowCount = 0
        vs_Job.ActiveSheet.RowCount = 0

        Call DATA_SEARCH_HEAD_vS_Line()

    End Sub
    Private Sub vS_Line_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Line.CellDoubleClick

        vs_Job.ActiveSheet.RowCount = 0

        Call DATA_SEARCH_HEAD_vs_Job()
    End Sub

    Private Sub vS_Job_CellClick(sender As Object, e As CellClickEventArgs) Handles vs_Job.CellDoubleClick
        Call DATA_SEARCH_vS1()
    End Sub


#End Region

#Region "Function"
    Private Function Date_Check() As Boolean
        Date_Check = False
   
    End Function

    Private Function CustomerPurchasing_CHK() As String
        CustomerPurchasing_CHK = "1"
        Return CustomerPurchasing_CHK
    End Function


#End Region

#Region "Event"
    Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click, tst_5.Click, tst_6.Click

    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles vS1.CellClick
        If e.ColumnHeader = True Or e.RowHeader = True Then Exit Sub
        If e.Button = Windows.Forms.MouseButtons.Left Then
            DATA_SEARCH_ALL()
            vS1.ActiveSheet.AddSelection(e.Row, e.Column, 1, 1)
        End If
    End Sub

    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles vS1.GotFocus

        'Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False, WordConv("INPUT") & "(F5)", WordConv("SEARCH") & "(F6)", WordConv("CHANGE") & "(F7)", WordConv("DELETE") & "(F8)")

    End Sub
    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.Focus()
        End Select
    End Sub
    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles vS1.LostFocus

        'Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INPUT") & "(F5)")

    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Call DATA_SEARCH_HEAD_vs_Season()

    End Sub


#End Region


 
End Class