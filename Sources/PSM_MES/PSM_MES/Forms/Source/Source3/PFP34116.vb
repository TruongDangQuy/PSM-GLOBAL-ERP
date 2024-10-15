Public Class PFP34116
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Protected prg As E_PRG

    Private W2351 As T2351_AREA
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
    Private Sub PFP17811_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

        Me.chk_FormEnterkey = False

    End Sub

    Private Sub DATA_INIT()
        SdateEdate.text1 = System_Date_8()
        SdateEdate.text2 = System_Date_8()

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

    Private Sub MAIN_JOB31()
 
    End Sub

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS1(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS1 = False

        vS1.Enabled = False


        DS1 = PrcDS("USP_PFP34116_SEARCH_vS1", cn, SdateEdate.text1, _
                                                    SdateEdate.text2, _
                                                   txt_cdSite.Code, _
                                                    txt_FactOrderNo.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS1, DS1, "USP_PFP34116_SEARCH_vS1", "vS1")
            vS1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS1, DS1, "USP_PFP34116_SEARCH_vS1", "vS1")
        DATA_SEARCH_VS1 = True

        vS1.Enabled = True
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

        Call DATA_SEARCH_VS1()
    End Sub


    Private Sub cmd_Save_Click(sender As Object, e As EventArgs) Handles cmd_Save.Click
        Try
            Dim intRow As Integer
            Dim KEY_MaterialInboundNo As String
            Dim KEY_MaterialInboundSeq As String

            For intRow = 0 To Vs1.ActiveSheet.RowCount - 1
                If getDataM(Vs1, getColumIndex(Vs1, "DCHK"), intRow) = "1" Then
                    KEY_MaterialInboundNo = getData(vS1, getColumIndex(vS1, "KEY_MaterialInboundNo"), intRow)
                    KEY_MaterialInboundSeq = getData(vS1, getColumIndex(vS1, "KEY_MaterialInboundSeq"), intRow)

                    If READ_PFK2351(KEY_MaterialInboundNo, KEY_MaterialInboundSeq) Then
                        D2351.InchargeTrading = Pub.SAW
                        D2351.TradingDate = getData(vS1, getColumIndex(vS1, "TradingDate"), intRow)
                        D2351.QtyInBoundTrading = CDecp(getData(vS1, getColumIndex(vS1, "QtyInBoundTrading"), intRow))
                        D2351.TradingCode = getData(vS1, getColumIndex(vS1, "TradingCode"), intRow)
                        D2351.TradingNo = getData(vS1, getColumIndex(vS1, "TradingNo"), intRow)
                        D2351.TradingGroup = getData(vS1, getColumIndex(vS1, "TradingGroup"), intRow)

                        D2351.PriceTrading = CDecp(getData(vS1, getColumIndex(vS1, "PriceTrading"), intRow))
                        D2351.AMTTradingNet = CDecp(getData(vS1, getColumIndex(vS1, "AMTTradingNet"), intRow))
                        D2351.AMTTradingVAT = CDecp(getData(vS1, getColumIndex(vS1, "AMTTradingVAT"), intRow))
                        D2351.AMTTrading = CDecp(getData(vS1, getColumIndex(vS1, "AMTTrading"), intRow))

                        D2351.cdUnitPrice = getData(vS1, getColumIndex(vS1, "cdUnitPrice"), intRow)
                        D2351.seUnitMaterial = ListCode("UnitMaterial")


                        Call REWRITE_PFK2351(D2351)
                    End If

                End If
            Next


            Call DATA_SEARCH_VS1()

        Catch ex As Exception

        End Try
    End Sub


#End Region


End Class