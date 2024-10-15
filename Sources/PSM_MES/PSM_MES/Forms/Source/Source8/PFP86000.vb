Imports System.Data.SqlClient
Imports System.IO
Public Class PFP86000

#Region "Variable"
    Protected prg As E_PRG
    Private Dsu01 As Long     'Data Su
    Private Dsu02 As Long     'Data Su
    Private Dsu03 As Long     'Data Su
    Private KEY_SEQ As String

    Private Form_Close As Boolean
#End Region

#Region "Formload"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)
        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()

        SdateEdate.text1 = System_Date_Add(-1)
        SdateEdate.text2 = System_Date_8()


    End Sub

    Private Sub PFP17811_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub

    Private Sub FORM_INIT()

        DS1 = PrcDS("USP_PFP86000_SEARCH_HEAD", cn)
        Dim i As Integer

        Vs1.Sheets.Count = GetDsRc(DS1)

        For i = 0 To GetDsRc(DS1) - 1
            Vs1.Sheets(i).SheetName = GetDsData(DS1, i, "SheetName")
            Vs1.Sheets(i).Tag = GetDsData(DS1, i, "ChkSizeRange")
        Next

    End Sub


    Private Sub DATA_INIT()

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
        If getData(Vs1, 12, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
    End Sub

#End Region

#Region "PFP_SEARCH"
    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        Dim i As Integer

        Vs1.Enabled = False

        Dim ProcName As String

        ProcName = "USP_PFP86000_SEARCH_VS1_" & Vs1.ActiveSheetIndex.ToString("00")

        DS1 = PrcDS(ProcName, cn, SdateEdate.text1, SdateEdate.text2, txt_cdFactory.Code, txt_cdLineProd.Code)

        Vs1.ActiveSheet.GrayAreaBackColor = Color.White

        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            SPR_PRO_NEW(Vs1, DS1, ProcName, "Vs1" & Vs1.ActiveSheetIndex.ToString("00"))
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, ProcName, "Vs1" & Vs1.ActiveSheetIndex.ToString("00"))

        Vs1.Enabled = True
        DATA_SEARCH_VS1 = True


    End Function

    Private Sub DATA_SEARC_VS1_ALL()
        Dim i As Integer

        Try
            Vs1.Enabled = False


            Dim ProcName As String

            For IntAs As Integer = 0 To Vs1.Sheets.Count - 1
                Vs1.ActiveSheetIndex = IntAs

                ProcName = "USP_PFP86000_SEARCH_VS1_" & Vs1.ActiveSheetIndex.ToString("00")

                DS1 = PrcDS(ProcName, cn, SdateEdate.text1, SdateEdate.text2)

                If GetDsRc(DS1) = 0 Then
                    Vs1.Enabled = True
                    SPR_PRO_NEW(Vs1, DS1, ProcName, "Vs1" & Vs1.ActiveSheetIndex.ToString("00"))
                    Exit Sub
                End If

                SPR_PRO_NEW(Vs1, DS1, ProcName, "Vs1" & Vs1.ActiveSheetIndex.ToString("00"))

            Next

            Vs1.Enabled = True

        Catch ex As Exception

        End Try
    End Sub






    Private Sub Vs1_ActiveSheetChanged(sender As Object, e As EventArgs) Handles Vs1.ActiveSheetChanged
        Exit Sub

        Dim Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

        Try

            Call DATA_SEARCH_VS1()

        Catch ex As Exception

        Finally
            Starting.close()
        End Try
    End Sub




    Private Sub Vs1_SheetTabDoubleClick(sender As Object, e As SheetTabDoubleClickEventArgs) Handles Vs1.SheetTabDoubleClick
        Dim Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

        Try

            If chk_All.Checked = False Then Call DATA_SEARCH_VS1()
            If chk_All.Checked = True Then Call DATA_SEARC_VS1_ALL()

        Catch ex As Exception

        Finally
            Starting.close()
        End Try

    End Sub

#End Region

#Region "EVENT"

    'GOTFOCUS
    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False, WordConv("INSERT") & "(F5)")
    End Sub

    'LOSTFOCUS
    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles Vs1.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INSERT") & "(F5)")
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        If chk_All.Checked = False Then Call DATA_SEARCH_VS1()
        If chk_All.Checked = True Then Call DATA_SEARC_VS1_ALL()

    End Sub

#End Region



End Class