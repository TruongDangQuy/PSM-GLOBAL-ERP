Public Class PFP42670
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
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
    Private Sub PFP40735_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub
    Private Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey
                Case Keys.F5 : Call MAIN_JOB01()
                Case Keys.F6 : Call MAIN_JOB02()
                Case Keys.F7 : Call MAIN_JOB03()
                Case Keys.F8 : Call MAIN_JOB04()
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FORM_INIT()
        txt_DateProd.Data = System_Date_8()
        txt_DateProd.Enabled = True

    End Sub

    Private Sub DATA_INIT()

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

#End Region

#Region "search"


    Public Function DATA_SEARCH_VS1() As Boolean
        Dim DateProd As String
        Dim cdFactory As String
        Dim cdLineProd As String
        Dim cdMainProcess As String


        DATA_SEARCH_VS1 = False

        DateProd = txt_DateProd.Data
        cdFactory = txt_cdFactory.Code
        cdMainProcess = txt_cdSubProcess.Code
        cdLineProd = txt_cdLineProd.Code

        vS1.Enabled = False

        DS1 = PrcDS("USP_PFP42670_SEARCH_vS1", cn, DateProd,
                                                    cdFactory,
                                                    cdLineProd,
                                                    cdMainProcess)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(vS1, , , , OperationMode.SingleSelect)
            SPR_PRO(vS1, DS1, "USP_PFP42670_SEARCH_vS1", "vs2")
            vS1.Enabled = True
            Exit Function
        End If

        SPR_SET(vS1, , , , OperationMode.SingleSelect)
        SPR_PRO(vS1, DS1, "USP_PFP42670_SEARCH_vS1", "vs2")

        DATA_SEARCH_VS1 = True

        vS1.Enabled = True

    End Function

#End Region

#Region "Function"


#End Region

#Region "Event"
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

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Call DATA_SEARCH_VS1()
    End Sub

    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked
        If Cms_1.Items(0).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB01()

        ElseIf Cms_1.Items(1).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB02()

        ElseIf Cms_1.Items(2).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB03()

        ElseIf Cms_1.Items(3).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB04()
        End If

    End Sub

#End Region

    Private Sub cmd_Save_Click(sender As Object, e As EventArgs) Handles cmd_Save.Click
        Try
            Dim Autokey As String
            Dim UniqueKey As String
            Dim UniqueKeyReference As String
            Dim JobCard As String
            Dim Szno As String
            Dim KindProduction As String
            Dim ComponentName As String
            Dim MaterialCode As String
            Dim ColorCode As String
            Dim Option1 As String
            Dim Option2 As String
            Dim Option3 As String
            Dim Option4 As String
            Dim Option5 As String
            Dim ProdDate As String
            Dim cdSubProcess As String
            Dim cdFactory As String
            Dim cdLineProd As String
            Dim CheckBL As String
            Dim OrderNo As String
            Dim OrderNoSeq As String
            Dim QtyProduction As String
            Dim TimeBegin As String
            Dim TimeEnd As String

            Autokey = getData(vS1, getColumIndex(vS1, "Autokey"), vS1.ActiveSheet.ActiveRowIndex)
            UniqueKey = getData(vS1, getColumIndex(vS1, "UniqueKey"), vS1.ActiveSheet.ActiveRowIndex)
            UniqueKeyReference = getData(vS1, getColumIndex(vS1, "UniqueKeyReference"), vS1.ActiveSheet.ActiveRowIndex)
            JobCard = getData(vS1, getColumIndex(vS1, "JobCard"), vS1.ActiveSheet.ActiveRowIndex)
            Szno = getData(vS1, getColumIndex(vS1, "Szno"), vS1.ActiveSheet.ActiveRowIndex)
            KindProduction = getData(vS1, getColumIndex(vS1, "KindProduction"), vS1.ActiveSheet.ActiveRowIndex)
            ComponentName = "*" & getData(vS1, getColumIndex(vS1, "ComponentName"), vS1.ActiveSheet.ActiveRowIndex)
            MaterialCode = getData(vS1, getColumIndex(vS1, "MaterialCode"), vS1.ActiveSheet.ActiveRowIndex)
            ColorCode = getData(vS1, getColumIndex(vS1, "ColorCode"), vS1.ActiveSheet.ActiveRowIndex)
            Option1 = "*" & getData(vS1, getColumIndex(vS1, "Option1"), vS1.ActiveSheet.ActiveRowIndex)
            Option2 = "*" & getData(vS1, getColumIndex(vS1, "Option2"), vS1.ActiveSheet.ActiveRowIndex)
            Option3 = "*" & getData(vS1, getColumIndex(vS1, "Option3"), vS1.ActiveSheet.ActiveRowIndex)
            Option4 = "*" & getData(vS1, getColumIndex(vS1, "Option4"), vS1.ActiveSheet.ActiveRowIndex)
            Option5 = "*" & getData(vS1, getColumIndex(vS1, "Option5"), vS1.ActiveSheet.ActiveRowIndex)
            ProdDate = FormatCut(getData(vS1, getColumIndex(vS1, "ProdDate"), vS1.ActiveSheet.ActiveRowIndex))
            cdSubProcess = getData(vS1, getColumIndex(vS1, "cdSubProcess"), vS1.ActiveSheet.ActiveRowIndex)
            cdFactory = getData(vS1, getColumIndex(vS1, "cdFactory"), vS1.ActiveSheet.ActiveRowIndex)
            cdLineProd = getData(vS1, getColumIndex(vS1, "cdLineProd"), vS1.ActiveSheet.ActiveRowIndex)
            CheckBL = getData(vS1, getColumIndex(vS1, "CheckBL"), vS1.ActiveSheet.ActiveRowIndex)
            OrderNo = getData(vS1, getColumIndex(vS1, "OrderNo"), vS1.ActiveSheet.ActiveRowIndex)
            OrderNoSeq = getData(vS1, getColumIndex(vS1, "OrderNoSeq"), vS1.ActiveSheet.ActiveRowIndex)
            QtyProduction = getData(vS1, getColumIndex(vS1, "QtyProduction"), vS1.ActiveSheet.ActiveRowIndex)

            TimeBegin = getData(vS1, getColumIndex(vS1, "TimeBegin"), vS1.ActiveSheet.ActiveRowIndex)
            TimeEnd = getData(vS1, getColumIndex(vS1, "TimeEnd"), vS1.ActiveSheet.ActiveRowIndex)

            Dim strMes As String
            strMes = PrcExeNoError_ValueVN("USP_PFK4267_UPDATE_AUTOKEY", cn, Autokey, ComponentName, Option1, Option2, Option3, Option4, Option5, cdLineProd, QtyProduction, Pub.SAW, System_Date_time, TimeBegin, TimeEnd, ProdDate)

            Call MsgBoxP(strMes, vbInformation)
        Catch ex As Exception

        End Try
    End Sub
End Class