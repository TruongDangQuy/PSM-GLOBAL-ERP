Public Class PFP13850

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)

        Vs1.ContextMenuStrip = Cms_1
        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
    Private Sub PFP17811_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
                Case Keys.F10 : Call MAIN_JOB06()
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FORM_INIT()


    End Sub

    Private Sub DATA_INIT()
        Try
            pnr_Year.Value = CDecp(Strings.Left(Pub.DAT, 4))

            pnr_Week.Value = DatePart(DateInterval.WeekOfYear, CDate(FSDate(Pub.DAT)))



        Catch ex As Exception

        End Try



    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()
      

    End Sub

    Private Sub MAIN_JOB02()
      
    End Sub

    Private Sub MAIN_JOB03()
       
    End Sub

    Private Sub MAIN_JOB04()
       
    End Sub


    Private Sub KEY_COUNT()

       
    End Sub

    Private Sub MAIN_JOB05()
      
    End Sub

    Private Sub MAIN_JOB06()
       
    End Sub

    Private Sub MAIN_JOB08()
        
    End Sub

    Private Sub MAIN_JOB09()
        
    End Sub

    Private Sub MAIN_JOB10()
  
    End Sub


    Private Sub MAIN_JOB11()
      
    End Sub

#End Region

#Region "Data_search"
    Public Function DATA_SEARCH_HEAD_vs_Season() As Boolean
       
    End Function

    Public Function DATA_SEARCH_HEAD_vS_Line() As Boolean
  
    End Function

    Private Function DATA_SEARCH_VS1(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS1 = False

        Vs1.Enabled = False


        Try
            DS1 = PrcDS("USP_PFP13850_SEARCH_VS1", cn, txt_cdSite.Code, pnr_Year.Value, pnr_Week.Value)


            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_PFP13850_SEARCH_VS1", "Vs1")
                Vs1.ActiveSheet.RowCount = 0
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_PFP13850_SEARCH_VS1", "Vs1")
            DATA_SEARCH_VS1 = True

            Vs1.Enabled = True



        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try

    End Function


#End Region

#Region "Event"



    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        Dim OrderNo As String

        OrderNo = getData(Vs1, getColumIndex(Vs1, "KEY_OrderNo"), Vs1.ActiveSheet.ActiveRowIndex)

    End Sub

    Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click, tst_5.Click, tst_6.Click
 
    End Sub


    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Try

            Call DATA_SEARCH_VS1()

        Catch ex As Exception
            Call MsgBoxP("35", "cmd_SEARCH_Click")
        End Try
    End Sub


#End Region






End Class