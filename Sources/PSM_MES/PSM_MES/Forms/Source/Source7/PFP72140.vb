Public Class PFP72140

#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Protected prg As E_PRG

    Private W7214 As T7214_AREA
    Private L7214 As T7214_AREA

    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INPUT") & "(F5)")
        Me.KeyPreview = True
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

    End Sub
    Private Sub MAIN_JOB02()

    End Sub
    Private Sub MAIN_JOB03()
      
    End Sub
    Private Sub MAIN_JOB04()
    
    End Sub
    Private Sub MAIN_JOB05()
        
    End Sub


    Public Function DATA_SEARCH_HEAD_vS_Line() As Boolean
        DATA_SEARCH_HEAD_vS_Line = False
        Dim cdSeason As String
        Dim CustomerCode As String
        CustomerCode = txt_Customercode.Code


        Try
            DS1 = PrcDS("USP_PFP72140_SEARCH_vS_Line", cn, CustomerCode)
            SPR_PRO_NEW(vS3, DS1, "USP_PFP72140_SEARCH_vS_Line", "vS3")


        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function



#End Region

#Region "Data_search"


    Private Function DATA_SEARCH01() As Boolean

        Dim CustomerCode, Article As String

        DATA_SEARCH01 = False

        CustomerCode = getData(vS3, getColumIndex(vS3, "CustomerCode"), vS3.ActiveSheet.ActiveRowIndex)
        Article = getData(vS3, getColumIndex(vS3, "Article"), vS3.ActiveSheet.ActiveRowIndex)

        DS1 = PrcDS("USP_PFP72140_SEARCH_VS4", cn, CustomerCode, Article)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS4, DS1, "USP_PFP72140_SEARCH_VS4", "Vs4")
            vS4.ActiveSheet.RowCount = "1"
            Exit Function
        End If

        SPR_PRO_NEW(vS4, DS1, "USP_PFP72140_SEARCH_VS4", "Vs4")

        DATA_SEARCH01 = True

    End Function
    Private Function LINE_MOVE_DISPLAY01() As Boolean
      
    End Function
#End Region

#Region "Event"

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click

        Call DATA_SEARCH_HEAD_vS_Line()

    End Sub

    

    Private Sub vS1_GotFocus(sender As Object, e As EventArgs)

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False, WordConv("INPUT") & "(F5)", WordConv("CHANGE") & "(F6)")

    End Sub
    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.Focus()
        End Select
    End Sub
    Private Sub vS1_LostFocus(sender As Object, e As EventArgs)

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INPUT") & "(F5)")

    End Sub


#End Region

   


  

    Private Function DATA_SEARCH_VS3() As Boolean
        DATA_SEARCH_VS3 = False

        vS4.Enabled = False

        Dim Article As String

        Article = getData(vS3, getColumIndex(vS3, "Article"), vS3.ActiveSheet.ActiveRowIndex)


        DS1 = PrcDS("USP_PFP72140_SEARCH_VS1", cn, Article, txt_Customercode.Code)

        If GetDsRc(DS1) = 0 Then
            vS4.Enabled = True
            SPR_PRO_NEW(vS4, DS1, "USP_PFP72140_SEARCH_VS1", "vS4")
        End If

        SPR_PRO_NEW(vS4, DS1, "USP_PFP72140_SEARCH_VS1", "vS4")

        vS4.Enabled = True

        vS4.ActiveSheet.RowCount = vS4.ActiveSheet.RowCount + 1

        DATA_SEARCH_VS3 = True


    End Function

    Private Sub vS4_Change(sender As Object, e As ChangeEventArgs) Handles vS4.Change

        If getData(vS4, getColumIndex(vS4, "Key_Autokey"), vS4.ActiveSheet.ActiveRowIndex) <> "0" Then

            If READ_PFK7214(getData(vS4, getColumIndex(vS4, "Key_Autokey"), vS4.ActiveSheet.ActiveRowIndex)) = True Then

                W7214 = D7214

                W7214.SizeWeight01 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight01"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight02 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight02"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight03 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight03"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight04 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight04"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight05 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight05"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight06 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight06"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight07 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight07"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight08 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight08"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight09 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight09"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight10 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight10"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight11 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight11"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight12 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight12"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight13 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight13"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight14 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight14"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight15 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight15"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight16 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight16"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight17 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight17"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight18 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight18"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight19 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight19"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight20 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight20"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight21 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight21"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight22 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight22"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight23 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight23"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight24 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight24"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight25 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight25"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight26 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight26"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight27 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight27"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight28 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight28"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight29 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight29"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight30 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight30"), vS4.ActiveSheet.ActiveRowIndex))

                Call REWRITE_PFK7214(W7214)

            Else
                W7214 = D7214

                W7214.SizeWeight01 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight01"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight02 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight02"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight03 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight03"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight04 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight04"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight05 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight05"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight06 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight06"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight07 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight07"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight08 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight08"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight09 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight09"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight10 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight10"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight11 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight11"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight12 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight12"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight13 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight13"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight14 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight14"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight15 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight15"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight16 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight16"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight17 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight17"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight18 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight18"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight19 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight19"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight20 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight20"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight21 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight21"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight22 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight22"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight23 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight23"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight24 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight24"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight25 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight25"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight26 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight26"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight27 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight27"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight28 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight28"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight29 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight29"), vS4.ActiveSheet.ActiveRowIndex))
                W7214.SizeWeight30 = CDecp(getData(vS4, getColumIndex(vS4, "SizeWeight30"), vS4.ActiveSheet.ActiveRowIndex))

                Dim Article As String
                Dim Season As String
                Dim Customercode As String

                Article = getData(vS3, getColumIndex(vS3, "Article"), vS3.ActiveSheet.ActiveRowIndex)
                Season = getData(vS3, getColumIndex(vS3, "cdSeason"), vS3.ActiveSheet.ActiveRowIndex)
                Customercode = getData(vS3, getColumIndex(vS3, "CustomerCode"), vS3.ActiveSheet.ActiveRowIndex)

                W7214.Article = Article
                W7214.cdSeason = Season
                W7214.CustomerCode = Customercode

                If WRITE_PFK7214(W7214) Then
                    Call DATA_SEARCH01()

                End If


            End If

        End If

    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click

        Dim Article As String
        Dim Season As String
        Dim Customercode As String

        Article = getData(vS3, getColumIndex(vS3, "Article"), vS3.ActiveSheet.ActiveRowIndex)
        Season = getData(vS3, getColumIndex(vS3, "cdSeason"), vS3.ActiveSheet.ActiveRowIndex)
        Customercode = getData(vS3, getColumIndex(vS3, "CustomerCode"), vS3.ActiveSheet.ActiveRowIndex)

        Call PrcExeNoError("USP_PFP72140_WEIGHTCAL", cn, Article, Customercode, Season)

        Call MsgBox("successfully!")

    End Sub

    
    Private Sub vS3_CellClick(sender As Object, e As CellClickEventArgs) Handles vS3.CellClick
        Call DATA_SEARCH01()
    End Sub
End Class