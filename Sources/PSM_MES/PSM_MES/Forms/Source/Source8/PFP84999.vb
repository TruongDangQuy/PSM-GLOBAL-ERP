Imports System.Data.SqlClient
Imports System.IO
Public Class PFP84999

#Region "Variable"
    Protected prg As E_PRG
    Private Dsu01 As Long     'Data Su
    Private Dsu02 As Long     'Data Su
    Private Dsu03 As Long     'Data Su
    Private KEY_SEQ As String

    Private Form_Close As Boolean
    Private Pre_FormName As String

#End Region

#Region "Formload"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)
        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()


    End Sub

    Private Sub PFP17811_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub

    Private Sub FORM_INIT()


    End Sub


    Private Sub DATA_INIT()
        txt_Year.Value = CIntp(Pub.DAT.Substring(0, 4))
        txt_Month.Value = CIntp(Pub.DAT.Substring(4, 2))
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
        Dim Pre_FormName As String

        Pre_FormName = Strings.Right(Me.Name, 2)

        ProcName = "USP_PFP84000_SEARCH_VS1_" & Pre_FormName

        DS1 = PrcDS(ProcName, cn, txt_Year.Value.ToString("0000") & txt_Month.Value.ToString("00"))

        Vs1.ActiveSheet.GrayAreaBackColor = Color.White

        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            SPR_PRO_NEW(Vs1, DS1, ProcName, "Vs1" & Pre_FormName)
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, ProcName, "Vs1" & Pre_FormName)

        Vs1.Enabled = True
        DATA_SEARCH_VS1 = True
    End Function



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

            DATA_SEARCH_VS1()

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
        Call DATA_SEARCH_VS1()
    End Sub

#End Region



End Class