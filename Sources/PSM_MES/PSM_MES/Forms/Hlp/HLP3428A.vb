Public Class HLP3428A

#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Protected prg As E_PRG

    Private W3421 As New T3421_AREA
    Private L3421 As New T3421_AREA

    Private W3422 As New T3422_AREA
    Private L3422 As New T3422_AREA

    Private Form_Close As Boolean
    Private PayableType As Integer
    Private cdSeason As String
    Private SupplierCode As String

#End Region

#Region "Form_load"
    Friend Function Link_HLP3428A(Chk_PayType As Integer, hlp_cdSeason As String, hlp_SupplierCode As String) As Boolean

        Link_HLP3428A = False
        PayableType = Chk_PayType
        cdSeason = hlp_cdSeason
        SupplierCode = hlp_SupplierCode

        Try
            Me.ShowDialog()

            Link_HLP3428A = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_HLP2331Material"))
        End Try


    End Function

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.KeyPreview = True

        Call DATA_INIT()

        SdateEdate.text1 = System_Date_Add(-3)
        SdateEdate.text2 = System_Date_8()

    End Sub
    Private Sub HLP2331A_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub
    Overrides Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey

            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DATA_INIT()
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        If cdSeason <> "" Then
            If READ_PFK7171(ListCode("Season"), cdSeason) = True Then
                txt_cdSeason.Code = D7171.BasicCode
                txt_cdSeason.Data = D7171.BasicName
            End If
        End If

        If SupplierCode <> "" Then
            If READ_PFK7101(SupplierCode) = True Then
                txt_SupplierCode.Code = D7101.CustomerCode
                txt_SupplierCode.Data = D7101.CustomerName
            End If
        End If

    End Sub

#End Region

#Region "Function"

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH01(Optional ByVal xsort As String = "1") As Boolean

        DATA_SEARCH01 = False

        PeacePanalSeach.Enabled = False

        Select Case True

            Case PayableType = 1

                DS1 = PrcDSVN("HLP_PFP34281_SEARCH_VS1", cn, SdateEdate.text1, SdateEdate.text2,
                                                                    txt_cdSeason.Code,
                                                                    txt_SupplierCode.Code,
                                                                "*" & txt_PONO.Data,
                                                                "*" & txt_MaterialName.Data
                                                                )

                If GetDsRc(DS1) = 0 Then
                    SPR_PRO_NEW(PeacePanalSeach, DS1, "HLP_PFP34281_SEARCH_VS1", "Vs1")
                    PeacePanalSeach.Enabled = True

                    Exit Function
                End If

                SPR_PRO_NEW(PeacePanalSeach, DS1, "HLP_PFP34281_SEARCH_VS1", "Vs1")
                DATA_SEARCH01 = True

            Case PayableType = 2

                DS1 = PrcDSVN("HLP_PFP34281_SEARCH_VS1_01", cn, SdateEdate.text1, SdateEdate.text2,
                                                                    txt_cdSeason.Code,
                                                                    txt_SupplierCode.Code,
                                                                "*" & txt_PONO.Data,
                                                                "*" & txt_MaterialName.Data
                                                                )

                If GetDsRc(DS1) = 0 Then
                    SPR_PRO_NEW(PeacePanalSeach, DS1, "HLP_PFP34281_SEARCH_VS1_01", "Vs1")
                    PeacePanalSeach.Enabled = True

                    Exit Function
                End If

                SPR_PRO_NEW(PeacePanalSeach, DS1, "HLP_PFP34281_SEARCH_VS1_01", "Vs1")
                DATA_SEARCH01 = True

        End Select

        PeacePanalSeach.Enabled = True
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

    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles PeacePanalSeach.GotFocus


    End Sub

    Private Sub chk_FSEL_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click


        Call DATA_SEARCH01()
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Try
            hlp0000SeVa = ""
            hlp0000SeVaTt = ""
            Dim i As Integer
            Dim CheckValue As Boolean = False

            For i = 0 To PeacePanalSeach.ActiveSheet.RowCount - 1
                If getDataM(PeacePanalSeach, getColumIndex(PeacePanalSeach, "DCHK"), i) = "1" Then
                    CheckValue = True
                    Select Case True
                        Case PayableType = "1"
                            hlp0000SeVa &= getData(PeacePanalSeach, getColumIndex(PeacePanalSeach, "KEY_FactOrderNo"), i) & ","
                            hlp0000SeVa &= getData(PeacePanalSeach, getColumIndex(PeacePanalSeach, "KEY_FactOrderSeq"), i) & "|"
                        Case PayableType = "2"
                            hlp0000SeVa &= getData(PeacePanalSeach, getColumIndex(PeacePanalSeach, "KEY_MaterialInBoundNo"), i) & ","
                            hlp0000SeVa &= getData(PeacePanalSeach, getColumIndex(PeacePanalSeach, "KEY_MaterialInBoundSeq"), i) & "|"
                    End Select

                End If
            Next

            hlp0000SeVa = Strings.Left(hlp0000SeVa, Len(hlp0000SeVa) - 1)
            hlp0000SeVaTt = hlp0000SeVa
            isudCHK = True

            If CheckValue = False Then
                hlp0000SeVa = ""
                hlp0000SeVaTt = ""
                isudCHK = False
            End If
            Me.Dispose()
        Catch ex As Exception
            MsgBoxP("cmd_OK_Click!", vbCritical)
        End Try
    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        isudCHK = False
        Me.Dispose()
    End Sub

#End Region

End Class