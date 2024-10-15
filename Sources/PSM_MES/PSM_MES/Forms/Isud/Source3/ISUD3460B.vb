Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Net
Imports System.IO
Imports System.Data
Imports System.Xml
Imports Microsoft.Office.Interop
Imports System.Text
Imports System.Text.RegularExpressions

Public Class ISUD3460B

#Region "Variable"
    Private wJOB As Integer
    Private WcheckType As Integer

    Private W3460 As New T3460_AREA
    Private L3460 As New T3460_AREA

    Private W3461 As New T3461_AREA
    Private L3461 As New T3461_AREA

    Private WRITE_CHK As String
    Private ImportTax As Decimal
    Private EnvironmentTax As Decimal
    Private VatTax As Decimal
    Private formA As Boolean
    Private CHK(0 To 5) As String
    Private cdSemiGroupMaterial As String

#End Region

#Region "Link"
    Public Function Link_ISUD3460B(job As Integer, InvoiceNo As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D3460.InvoiceNo = InvoiceNo
        L3460.InvoiceNo = InvoiceNo

        wJOB = job : L3460 = D3460

        Link_ISUD3460B = False
        Try

            Select Case job
                Case 1
                Case Else
                    'If D3460.CheckComplete = "1" Then wJOB = 2

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD3460B = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("PAYABLE PROCESSING"))
        End Try

    End Function

    Private strValue As String = ""
    Public Function Link_ISUD3460B_AUTO(job As Integer, InvoiceNo As String, checkType As Integer, _strValue As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D3460.InvoiceNo = InvoiceNo
        L3460.InvoiceNo = InvoiceNo

        strValue = _strValue

        wJOB = job : L3460 = D3460
        WcheckType = checkType

        Link_ISUD3460B_AUTO = False
        Try

            Select Case job
                Case 1
                Case Else

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD3460B_AUTO = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("PAYABLE PROCESSING"))
        End Try

    End Function

#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        'Me.Form_Initial()
        Me.Form_KeyDown()

        Call DATA_INIT()
        Call FORM_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1                                                      'ÀÔ·Â
                Me.Text = Me.Text & " - INSERT"
                Frame1.Enabled = True
                tst_iDelete.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()
                Call DATA_SEARCH_vS1()

            Case 2
                Me.Text = Me.Text & " - SEARCH"

                Frame1.Enabled = True
                tst_iDelete.Visible = False
                tst_iSave.Visible = False

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_vS1()

            Case 3
                Me.Text = Me.Text & " - UPDATE"

                Frame1.Enabled = True
                txt_InvoiceNo.Enabled = False

                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        Me.Dispose()
                        formA = True
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else

                        Me.Text = Me.Text & " - SEARCH"
                        isudCHK = False
                        formA = True
                        wJOB = 2
                        tst_iDelete.Visible = False
                        Call MsgBoxP("Only Search !") : tst_iSave.Visible = False
                    End If
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_vS1()

            Case 4
                Me.Text = Me.Text & " - DELETE"

                tst_iSave.Visible = False


                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_vS1()

            Case 11                                                      'ÀÔ·Â
                Me.Text = Me.Text & " - INSERT INTERFACE"
                Frame1.Enabled = True
                tst_iDelete.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()
                Call DATA_SEARCH_vS1_AUTO()

                wJOB = 1

        End Select

        formA = True
    End Sub
#End Region

#Region "Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        DS1 = PrcDS("USP_ISUD3460B_SEARCH_HEAD", cn, L3460.InvoiceNo)
        If GetDsRc(DS1) = 0 Then

            Exit Function
            isudCHK = False
        End If

        STORE_MOVE(Me, DS1)
        txt_InvoiceNo.Data = L3460.InvoiceNo

        txt_cdSite.Code = GetDsData(DS1, 0, "cdSite")
        txt_cdSite.Data = GetDsData(DS1, 0, "SiteName")

        txt_InchargeInvoice.Code = GetDsData(DS1, 0, "InchargePurchasingCode")
        txt_InchargeInvoice.Data = GetDsData(DS1, 0, "InchargePurchasingName")

        txt_CustomerCode.Code = GetDsData(DS1, 0, "SupplierCode")
        txt_CustomerCode.Data = GetDsData(DS1, 0, "SupplierName")

        txt_cdUnitPrice.Code = GetDsData(DS1, 0, "cdUnitPrice")
        txt_cdUnitPrice.Data = GetDsData(DS1, 0, "UnitPriceName")

        If READ_PFK7171(ListCode("PaymentTerm"), GetDsData(DS1, 0, "cdPaymentTerm")) Then
            txt_cdPaymentTerm.Data = D7171.BasicName
            txt_cdPaymentTerm.Code = D7171.BasicCode
        End If


        If READ_PFK7101(txt_CustomerCode.Code) = True Then
            txt_CustomerCode.Data = D7101.CustomerName
        End If


        DATA_SEARCH01 = True

    End Function

    Private Function DATA_SEARCH_vS1() As Boolean
        DATA_SEARCH_vS1 = False
        Try

            DS1 = PrcDS("USP_ISUD3460B_SEARCH_VS1", cn, L3460.InvoiceNo)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO(Vs1, DS1, "USP_ISUD3460B_SEARCH_VS1", "Vs1")
                Vs1.ActiveSheet.RowCount = 1
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO(Vs1, DS1, "USP_ISUD3460B_SEARCH_VS1", "Vs1")

            DATA_SEARCH_vS1 = True
        Catch ex As Exception

        End Try
    End Function
    Private Function DATA_SEARCH_vS1_AUTO() As Boolean
        DATA_SEARCH_vS1_AUTO = False
        Try
            DS1 = PrcDS("USP_ISUD3460B_SEARCH_VS1_AUTO", cn, strValue)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO(Vs1, DS1, "USP_ISUD3460B_SEARCH_VS1", "Vs1")

                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO(Vs1, DS1, "USP_ISUD3460B_SEARCH_VS1", "Vs1")

            DATA_SEARCH_vS1_AUTO = True
        Catch ex As Exception

        End Try
    End Function


    Private Function DATA_SEARCH_vS3() As Boolean
        DATA_SEARCH_vS3 = False
        DATA_SEARCH_vS3 = True

    End Function
#End Region

#Region "Function"
    Private Sub CheckMarketType()

    End Sub

    Private Sub DATA_MOVE()

    End Sub

    Private Sub DATA_MOVE_DEFAULT()

    End Sub

    Private Function DATA_MOVE_WRITE01() As Boolean
        DATA_MOVE_WRITE01 = False
        Try
            Dim i As Integer
            Dim j As Integer

            For i = 0 To Vs1.ActiveSheet.RowCount - 1


                If K3461_MOVE(Vs1, i, W3461, L3460.InvoiceNo, getData(Vs1, getColumIndex(Vs1, "InvoiceSeq"), i)) = True Then

                    Call DATA_MOVE_DEFAULT()

                    Call REWRITE_PFK3461(W3461)
                    isudCHK = True
                Else

                    Call KEY_COUNT_PFK3461()
                    Call DATA_MOVE_DEFAULT()

                    W3461.InvoiceNo = L3460.InvoiceNo

                    If WRITE_PFK3461(W3461) Then
                        wJOB = 3
                        isudCHK = True
                    End If
                End If

skip:

            Next

            DATA_MOVE_WRITE01 = True
        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE01")
        End Try

    End Function

    Private Sub DATA_INSERT()

        Try

            If K3460_MOVE(Me, W3460, 1, L3460.InvoiceNo) = False Then
                Call KEY_COUNT()

                W3460.seSite = ListCode("Site")
                W3460.cdSite = txt_cdSite.Code

                W3460.seUnitPrice = ListCode("UnitPrice")

                W3460.cdUnitPrice = txt_cdUnitPrice.Code
                W3460.DestinationID = txt_DestinationID.Code
                W3460.InchargeInvoice = txt_InchargeInvoice.Code

                Call DATA_MOVE()
                If WRITE_PFK3460(W3460) = True Then
                    Call DATA_MOVE_WRITE01()

                    isudCHK = True : WRITE_CHK = "*"
                    wJOB = 3
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub DATA_UPDATE()
        Try
            If K3460_MOVE(Me, W3460, 3, L3460.InvoiceNo) = True Then
                If REWRITE_PFK3460(W3460) = True Then

                    Call DATA_MOVE_WRITE01()

                    isudCHK = True
                End If
            End If
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Try
            Dim i As Integer

            If READ_PFK3460(txt_InvoiceNo.Data) = True Then
                W3460 = D3460
                If DELETE_PFK3460(W3460) = True Then
                    isudCHK = True
                    Me.Dispose()
                End If
            End If
        Catch ex As Exception

            Call MsgBoxP("38", "DATA_DELETE")
        End Try
    End Sub

    Private Sub KEY_COUNT()
        Dim YRNO As Integer
        Dim MaxChk As Boolean = False

        YRNO = Mid(System_Date_8(), 3, 4)

        Try
            SQL = "SELECT MAX(CAST(SUBSTRING(K3460_InvoiceNo,7,3) AS DECIMAL)) AS MAX_MCODE FROM PFK3460 "
            SQL = SQL & " WHERE SUBSTRING(K3460_InvoiceNo,3,4) = '" & YRNO.ToString & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then

            Else
                If rd!MAX_MCODE = 999 Then
                    MaxChk = True
                    YRNO += 1
                End If

            End If
            rd.Close()


            SQL = "SELECT MAX(CAST(SUBSTRING(K3460_InvoiceNo,7,3) AS DECIMAL)) AS MAX_MCODE FROM PFK3460 "
            SQL = SQL & " WHERE SUBSTRING(K3460_InvoiceNo,3,4) = '" & YRNO.ToString & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W3460.InvoiceNo = "IC" & YRNO & "001"
            Else
                W3460.InvoiceNo = "IC" & YRNO & Format(CInt(rd!MAX_MCODE + 1), "000")

            End If

            rd.Close()

            L3460.InvoiceNo = W3460.InvoiceNo
            txt_InvoiceNo.Data = W3460.InvoiceNo


        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub DATA_INIT()
        Try
            txt_InvoiceNo.Enabled = False
            Call D3460_CLEAR()
            txt_DateInvoice.Data = System_Date_8()

            If READ_PFK7411(Pub.SAW) Then
                txt_InchargeInvoice.Data = D7411.Name
                txt_InchargeInvoice.Code = D7411.IDNO
            End If

            txt_cdUnitPrice.Code = "001"
            txt_cdUnitPrice.Data = "VND"


            txt_DateETA.Data = Pub.DAT
            W3460 = D3460

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()


    End Sub

    Private Function READ_SHEETPRINT_MATCHING(PROG As String) As Boolean
        READ_SHEETPRINT_MATCHING = False
        Try
            SQL = "SELECT *  FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MATCHING] "
            SQL = SQL + " WHERE [PROG] = '" + PROG + "'"

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = False Then GoTo pass
            READ_SHEETPRINT_MATCHING = True
        Catch ex As Exception

        End Try
pass:
        rd.Close()
    End Function

    Private Function READ_SHEETPRINT_MATCHING_MULTI(PROG As String, SheetReportName As String) As Boolean
        READ_SHEETPRINT_MATCHING_MULTI = False
        Try
            SQL = "SELECT *  FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MATCHING_MULTI] "
            SQL = SQL + " WHERE [PROG]          = '" + PROG + "'"
            SQL = SQL + "   AND [SHEETREPORT]   = '" + SheetReportName + "'"

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = False Then GoTo pass
            READ_SHEETPRINT_MATCHING_MULTI = True
        Catch ex As Exception

        End Try
pass:
        rd.Close()
    End Function

#End Region

#Region "Event"
    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim i As Integer



        Try
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                'If getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i) = "" Then MsgBoxP("Sai vật tư ở dòng " & (i + 1)) : Exit Function

skip:
            Next

            Data_Check = True
        Catch ex As Exception

        End Try
    End Function

    Private Sub KEY_COUNT_PFK3461()
        Try
            SQL = "SELECT MAX(CAST(K3461_InvoiceSeq AS DECIMAL)) AS MAX_MCODE FROM PFK3461 "
            SQL = SQL & " WHERE K3461_InvoiceNo = '" & L3460.InvoiceNo & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W3461.InvoiceSeq = "0001"
            Else
                W3461.InvoiceSeq = CIntp(rd!MAX_MCODE + 1).ToString("0000")
            End If

            rd.Close()

            L3461.InvoiceSeq = W3461.InvoiceSeq


            rd.Close()

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT_PFK3461")
        End Try
    End Sub

    Private Sub DATA_CLOSE()
        Try
            Call PrcExeNoError(" EXP_CLOSSING_PFK3460", cn, txt_InvoiceNo.Data)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Sub
                'If DataCheck(Me, "PFK3460") = False Then Exit Sub

                Call KEY_COUNT()
                Call DATA_INSERT()
                Call DATA_CLOSE()

                Call DATA_SEARCH_vS1()

                Call MsgBoxP("Update Successully!", vbInformation)
                wJOB = 3

            Case 2
                Me.Dispose()

            Case 3
                If Data_Check() = False Then Exit Sub
                'If DataCheck(Me, "PFK3460") = False Then Exit Sub

                Call DATA_UPDATE()
                Call DATA_CLOSE()
                Call MsgBoxP("Update Successully!", vbInformation)
            Case 4
                Call DATA_DELETE()
                Call DATA_CLOSE()
                Me.Dispose()

            Case 11
                If Data_Check() = False Then Exit Sub
                'If DataCheck(Me, "PFK3460") = False Then Exit Sub

                Call DATA_INSERT()
                Call DATA_CLOSE()
        End Select
    End Sub
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles tst_iClose.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub

    Private Sub tst_iDelete_Click(sender As Object, e As EventArgs) Handles tst_iDelete.Click
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "tst_iDelete_Click")
            Exit Sub
        End If

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

        Call DATA_DELETE()
        Call DATA_CLOSE()
        Me.Dispose()
    End Sub

    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change
        Dim xCOL As Long
        Dim xROW As Long

        Try

            xROW = e.Row
            xCOL = e.Column

            vSChange(xROW)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub vSChange(xROW As Integer)
        Try

            Dim PricePurchasing As Decimal
            Dim PricePurchasingEX As Decimal
            Dim PriceExchange As Decimal
            Dim PricePurchasingVND As Decimal

            Dim QtyPurchasing As Decimal

            Dim AmountPurchasingEX As Decimal
            Dim AmountPurchasingVND As Decimal
            Dim AmountTaxEX As Decimal
            Dim AmountTaxVND As Decimal
            Dim PerTax3 As Decimal
            Dim AmountTax3 As Decimal

            Dim AmountEX As Decimal
            Dim AmountVND As Decimal

            PriceExchange = CDecp(txt_PriceExchange.Data)
            PricePurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "PricePurchasing"), xROW))
            PricePurchasingEX = PricePurchasing
            PricePurchasingVND = PricePurchasing * PriceExchange

            QtyPurchasing = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), xROW))
            AmountPurchasingEX = PricePurchasingEX * QtyPurchasing
            AmountPurchasingVND = PricePurchasingVND * QtyPurchasing

            PerTax3 = CDecp(getData(Vs1, getColumIndex(Vs1, "cdTax3Name"), xROW))
            AmountTax3 = CDecp(getData(Vs1, getColumIndex(Vs1, "cdTax3Name"), xROW)) * AmountPurchasingVND
            AmountTaxVND = AmountTax3
            AmountTaxEX = AmountTax3

            AmountEX = AmountTaxEX + AmountPurchasingEX
            AmountVND = AmountTaxVND + AmountPurchasingVND

            setData(Vs1, getColumIndex(Vs1, "PricePurchasing"), xROW, PricePurchasing)
            setData(Vs1, getColumIndex(Vs1, "PricePurchasingEX"), xROW, PricePurchasingEX)
            setData(Vs1, getColumIndex(Vs1, "PricePurchasingVND"), xROW, PricePurchasingVND)

            setData(Vs1, getColumIndex(Vs1, "AmountPurchasingEX"), xROW, AmountPurchasingEX)
            setData(Vs1, getColumIndex(Vs1, "AmountPurchasingVND"), xROW, AmountPurchasingVND)
            setData(Vs1, getColumIndex(Vs1, "AmountTaxEX"), xROW, AmountTaxEX)
            setData(Vs1, getColumIndex(Vs1, "AmountTaxVND"), xROW, AmountTaxVND)
            setData(Vs1, getColumIndex(Vs1, "PerTax3"), xROW, PerTax3)
            setData(Vs1, getColumIndex(Vs1, "AmountTax3"), xROW, AmountTax3)
            setData(Vs1, getColumIndex(Vs1, "QtyPurchasing"), xROW, QtyPurchasing)

            setData(Vs1, getColumIndex(Vs1, "AmountEX"), xROW, AmountEX)
            setData(Vs1, getColumIndex(Vs1, "AmountVND"), xROW, AmountVND)

        Catch ex As Exception

        End Try
    End Sub


    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        If wJOB = 2 Then Exit Sub
        Dim xCOL As Long
        Dim xROW As Long

        xCOL = Vs1.ActiveSheet.ActiveColumnIndex
        xROW = Vs1.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Insert

                If xROW = sender.ActiveSheet.RowCount - 1 Then
                    Vs1.ActiveSheet.RowCount += 1
                    Vs1.ActiveSheet.ActiveRowIndex = xROW + 1
                Else
                    Vs1.ActiveSheet.AddRows(xROW + 1, 1)
                End If

            Case Keys.Delete

                Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)

                If Msg_Result <> vbYes Then Exit Sub

                If getData(Vs1, getColumIndex(Vs1, "KEY_LoadingNo"), xROW) <> "0" Then

                    If READ_PFK3461(txt_InvoiceNo.Data, getData(Vs1, getColumIndex(Vs1, "KEY_LoadingNo"), xROW)) Then
                        W3461.InvoiceNo = txt_InvoiceNo.Data
                        W3461.LoadingNo = getDataM(Vs1, getColumIndex(Vs1, "LoadingNo"), xROW)
                        Call DELETE_PFK3461(W3461)
                    End If
                End If


                SPR_DEL(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
                Vs1.Focus()


            Case Keys.Enter
                vSChange(xROW)
        End Select
    End Sub

    Public Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        gpp = e.Graphics
        Call TAG_PRINT_MATERIAL_NEW_F1()
    End Sub

    Private Sub Vs1_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles Vs1.ButtonClicked
        Dim xCOL As Integer
        Dim xROW As Integer
        Dim i As Integer
        Dim Value1() As String
        Dim Value2 As String
        Dim Chk_PayType As Integer
        Dim hlp_cdSite As String
        Dim hlp_SupplierCode As String


        xROW = e.Row
        xCOL = e.Column

        Select Case xCOL
            Case getColumIndex(Vs1, "clInvoiceNo")

                Chk_PayType = "3"

                If txt_CustomerCode.Data <> "" Then hlp_SupplierCode = txt_CustomerCode.Code


        End Select

        Vs1.Focus()

        vSChange(e.Row)
    End Sub


#End Region



End Class