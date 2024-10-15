Public Class HLP3011R

#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Protected prg As E_PRG

    Private W2356 As T2356_AREA
    Private Form_Close As Boolean
#End Region

#Region "Form_load"

    Public Function Link_ISUD3011B(job As Integer, Autokey As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG


        txt_Autokey.Data = Autokey


        If READ_PFK3011(Autokey) Then

            Call READ_PFK7231(D3011.Materialcode)
            txt_MaterialName.Data = D7231.MaterialName
            txt_ColorName.Data = D3011.ColorName

        End If

        Link_ISUD3011B = False
        Try

            Me.ShowDialog()

            Link_ISUD3011B = isudCHK


        Catch ex As Exception
            '       Call MsgBoxP("61", WordConv("GroupComponentBOM"))
        End Try


    End Function

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()


    End Sub
    Private Sub PFP23516_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
                Case Keys.F9 : Call MAIN_JOB05()
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FORM_INIT()
        chk_FSEL.CheckState = 1
        chk_FSEL.BackColor = clrCheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("CLOSE")
        ssp_WHERE.Visible = True
    End Sub

    Private Sub DATA_INIT()

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

    Private Sub MAIN_JOB05()

    End Sub

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS10 = False

        vS10.Enabled = False

        DS1 = PrcDS("USP_HLP3011R_SEARCH_vS10", cn, txt_cdSite.Code, "*" & txt_MaterialName.Data, txt_ColorName.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS10, DS1, "USP_HLP3011R_SEARCH_vS10", "vS10")

            vS10.ActiveSheet.RowCount = 0
            vS10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS10, DS1, "USP_HLP3011R_SEARCH_vS10", "vS10")
        DATA_SEARCH_VS10 = True

        vS10.Enabled = True
    End Function



    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False

    End Function
    Private Function CustomerPurchasing_CHK() As String
        CustomerPurchasing_CHK = "1"
        Return CustomerPurchasing_CHK
    End Function


#End Region

#Region "Event"


    Private Sub chk_FSEL_Click(sender As Object, e As EventArgs) Handles chk_FSEL.CheckedChanged
        If chk_FSEL.CheckState = 0 Then                  '
            chk_FSEL.BackColor = clrUncheck
            chk_FSEL.ForeColor = Color.Black

            chk_FSEL.Text = WordConv("OPEN")
            ssp_WHERE.Visible = False
        Else                                        '
            chk_FSEL.BackColor = clrCheck
            chk_FSEL.ForeColor = Color.Black

            chk_FSEL.Text = WordConv("CLOSE")
            ssp_WHERE.Visible = True
        End If
    End Sub
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

        Call DATA_SEARCH_VS10()
    End Sub




    Private Sub vS10_CellDoubleClick(sender As Object, e As CellClickEventArgs)

    End Sub

    Private Sub vS10_ButtonClicked(sender As Object, e As EditorNotifyEventArgs)


        'vSChange(e.Row)
    End Sub


#End Region


    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click

        Msg_Result = MsgBox("This is important confirmation ! Please be careful to save ! Đây là thông tin cực kỳ quan trọng để mua hàng. Xin lưu ý ! Bấm Yes để tiếp tục !", vbYesNo)
        If Msg_Result <> vbYes Then Exit Sub


        Try
            Dim xCOL As Integer
            Dim xROW As Integer
            Dim i As Integer
            Dim Value1() As String
            Dim Value2(5) As String


            Dim QtyInBound As String
            Dim KEY_MaterialInBoundNo As String
            Dim KEY_MaterialInBoundSeq As String
            Dim KEY_MaterialInBoundSno As String
            Dim QtyInBoundAllocation As Decimal


            For i = 0 To vS10.ActiveSheet.RowCount - 1

                If getDataM(vS10, getColumIndex(vS10, "DCHK"), i) = "1" Then

                    KEY_MaterialInBoundNo = getData(vS10, getColumIndex(vS10, "KEY_MaterialInBoundNo"), i)
                    KEY_MaterialInBoundSeq = getData(vS10, getColumIndex(vS10, "KEY_MaterialInBoundSeq"), i)
                    KEY_MaterialInBoundSno = getData(vS10, getColumIndex(vS10, "KEY_MaterialInBoundSno"), i)

                    Call PrcExeNoError("USP_PFK2352_UPDATE_PFK3011", cn, txt_Autokey.Data, KEY_MaterialInBoundNo, KEY_MaterialInBoundSeq, KEY_MaterialInBoundSno, Pub.SAW, CDecp(getData(vS10, getColumIndex(vS10, "QtyBooking"), i)), "*" & txt_Remark.Text)

                End If

            Next

            Me.Dispose()

        Catch ex As Exception

        End Try
    End Sub
End Class