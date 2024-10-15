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

Public Class ISUD3474A

    '#Region "Variable"
    '    Private wJOB As Integer
    '    Private WcheckType As Integer

    '    Private W3471 As New T3471_AREA
    '    Private L3471 As New T3471_AREA

    '    Private W3474 As New T3474_AREA
    '    Private L3474 As New T3474_AREA

    '    Private M3474 As New T3474_AREA

    '    Private WRITE_CHK As String
    '    Private ImportTax As Decimal
    '    Private EnvironmentTax As Decimal
    '    Private VatTax As Decimal
    '    Private formA As Boolean
    '    Private CHK(0 To 5) As String
    '    Private cdSemiGroupMaterial As String

    '#End Region

    '#Region "Link"
    '    Public Function Link_ISUD3474A(job As Integer, InvoiceNo As String, Optional ByVal TAG As String = "") As Boolean
    '        Me.Tag = TAG
    '        D3471.InvoiceNo = InvoiceNo
    '        L3471.InvoiceNo = InvoiceNo

    '        wJOB = job : L3471 = D3471

    '        Link_ISUD3474A = False
    '        Try

    '            Select Case job
    '                Case 1
    '                Case Else

    '            End Select

    '            formA = False
    '            Me.ShowDialog()

    '            Link_ISUD3474A = isudCHK


    '        Catch ex As Exception
    '            Call MsgBoxP("61", WordConv("PAYABLE PROCESSING"))
    '        End Try

    '    End Function

    '    Private strValue As String = ""
    '    Public Function Link_ISUD3474A_AUTO(job As Integer, InvoiceNo As String, checkType As Integer, _strValue As String, Optional ByVal TAG As String = "") As Boolean
    '        Me.Tag = TAG
    '        D3471.InvoiceNo = InvoiceNo
    '        L3471.InvoiceNo = InvoiceNo

    '        strValue = _strValue

    '        wJOB = job : L3471 = D3471
    '        WcheckType = checkType

    '        Link_ISUD3474A_AUTO = False
    '        Try

    '            Select Case job
    '                Case 1
    '                Case Else

    '            End Select

    '            formA = False
    '            Me.ShowDialog()

    '            Link_ISUD3474A_AUTO = isudCHK


    '        Catch ex As Exception
    '            Call MsgBoxP("61", WordConv("PAYABLE PROCESSING"))
    '        End Try

    '    End Function

    '#End Region

    '#Region "Form"
    '    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
    '        If formA = True Then Exit Sub

    '        WRITE_CHK = ""
    '        'Me.Form_Initial()
    '        Me.Form_KeyDown()

    '        Call DATA_INIT()
    '        Call FORM_INIT()

    '        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

    '        Select Case wJOB
    '            Case 1                                                      'ÀÔ·Â
    '                Me.Text = Me.Text & " - INSERT"
    '                Frame1.Enabled = True
    '                tst_iDelete.Visible = False

    '                If CHK(1) <> "1" Then
    '                    isudCHK = False
    '                    Me.Dispose()
    '                    formA = True
    '                    Call MsgBoxP("You have no right is this program !")
    '                    Exit Sub
    '                End If

    '                Call KEY_COUNT()
    '                Call DATA_SEARCH_vS1()

    '            Case 2
    '                Me.Text = Me.Text & " - SEARCH"

    '                Frame1.Enabled = True
    '                tst_iDelete.Visible = False
    '                tst_iSave.Visible = False

    '                If CHK(2) <> "1" Then
    '                    isudCHK = False
    '                    Me.Dispose()
    '                    formA = True
    '                    Call MsgBoxP("You have no right is this program !")
    '                    Exit Sub
    '                End If

    '                Call DATA_SEARCH01()
    '                Call DATA_SEARCH_vS1()
    '                Call DATA_SEARCH_vS2()

    '            Case 3
    '                Me.Text = Me.Text & " - UPDATE"

    '                Frame1.Enabled = True
    '                txt_InvoiceNo.Enabled = False

    '                If CHK(3) <> "1" Then
    '                    If CHK(2) <> "1" Then
    '                        isudCHK = False
    '                        Me.Dispose()
    '                        formA = True
    '                        Call MsgBoxP("You have no right is this program !")
    '                        Exit Sub
    '                    Else

    '                        Me.Text = Me.Text & " - SEARCH"
    '                        isudCHK = False
    '                        formA = True
    '                        wJOB = 2
    '                        tst_iDelete.Visible = False
    '                        Call MsgBoxP("Only Search !") : tst_iSave.Visible = False
    '                    End If
    '                End If

    '                Call DATA_SEARCH01()
    '                Call DATA_SEARCH_vS1()
    '                Call DATA_SEARCH_vS2()

    '            Case 4
    '                Me.Text = Me.Text & " - DELETE"

    '                tst_iSave.Visible = False


    '                If CHK(4) <> "1" Then
    '                    isudCHK = False
    '                    Me.Dispose()
    '                    formA = True
    '                    Call MsgBoxP("You have no right is this program !")
    '                    Exit Sub
    '                End If

    '                Call DATA_SEARCH01()
    '                Call DATA_SEARCH_vS1()
    '                Call DATA_SEARCH_vS2()

    '            Case 11                                                      'ÀÔ·Â
    '                Me.Text = Me.Text & " - INSERT INTERFACE"
    '                Frame1.Enabled = True
    '                tst_iDelete.Visible = False

    '                If CHK(1) <> "1" Then
    '                    isudCHK = False
    '                    Me.Dispose()
    '                    formA = True
    '                    Call MsgBoxP("You have no right is this program !")
    '                    Exit Sub
    '                End If

    '                Call KEY_COUNT()
    '                Call DATA_SEARCH_vS1_AUTO()
    '                Call DATA_SEARCH_vS2()

    '                wJOB = 1

    '            Case 12                                                      'ÀÔ·Â
    '                Me.Text = Me.Text & " - INSERT INTERFACE"
    '                Frame1.Enabled = True
    '                tst_iDelete.Visible = False

    '                If CHK(1) <> "1" Then
    '                    isudCHK = False
    '                    Me.Dispose()
    '                    formA = True
    '                    Call MsgBoxP("You have no right is this program !")
    '                    Exit Sub
    '                End If

    '                Call DATA_SEARCH01()
    '                Call DATA_SEARCH_vS1_AUTO()
    '                Call DATA_SEARCH_vS2()

    '                wJOB = 12

    '        End Select

    '        formA = True
    '    End Sub
    '#End Region

    '#Region "Search"
    '    Private Function DATA_SEARCH01() As Boolean
    '        DATA_SEARCH01 = False

    '        DS1 = READ_PFK3471(L3471.InvoiceNo, cn)
    '        If GetDsRc(DS1) = 0 Then

    '            Exit Function
    '            isudCHK = False
    '        End If

    '        READER_MOVE(Me, DS1)

    '        If GetDsData(DS1, 0, "K3471_Status") = "1" Then chk_IsPosted.Checked = True : wJOB = "2" : tst_iDelete.Visible = False : tst_iSave.Visible = False
    '        If GetDsData(DS1, 0, "K3471_Status") <> "1" Then chk_IsPosted.Checked = False

    '        If GetDsData(DS1, 0, "K3471_CheckMarketType") = "1" Then chk_AllLines.Checked = True
    '        If GetDsData(DS1, 0, "K3471_CheckMarketType") <> "1" Then chk_AllLines.Checked = False

    '        If READ_PFK7101(GetDsData(DS1, 0, "K3471_DestinationID")) Then
    '            txt_DestinationID.Data = D7171.BasicName
    '            txt_DestinationID.Code = D7171.BasicCode

    '        End If

    '        DATA_SEARCH01 = True

    '    End Function

    '    Private Function DATA_SEARCH_vS1() As Boolean
    '        DATA_SEARCH_vS1 = False

    '        Dim i As Integer

    '        Try

    '            DS1 = PrcDS("USP_ISUD3474A_SEARCH_VS1", cn, L3471.InvoiceNo)

    '            If GetDsRc(DS1) = 0 Then
    '                SPR_PRO(Vs1, DS1, "USP_ISUD3474A_SEARCH_VS1", "Vs1")
    '                Vs1.Enabled = True
    '                Exit Function
    '            End If

    '            SPR_PRO(Vs1, DS1, "USP_ISUD3474A_SEARCH_VS1", "Vs1")

    '            If chk_TradingExportColor Then
    '                DS3 = PrcDS("USP_HLP7171_LISTCOLOR", cn, ListCode("StatusExport"))

    '                Dim Xcol As Integer = getColumIndex(Vs1, "CheckStatus_TD")
    '                Dim XcolsEL As Integer = getColumIndex(Vs1, "CheckStatus_TD_Sel")


    '                For i = 0 To Vs1.ActiveSheet.RowCount - 1
    '                    SPR_BACKCOLORCELL(Vs1, FUNCTION_TRADING_BACK(getData(Vs1, Xcol, i)), XcolsEL, i)
    '                Next
    '            End If


    '            DATA_SEARCH_vS1 = True
    '        Catch ex As Exception

    '        End Try
    '    End Function
    '    Private Function DATA_SEARCH_vS2() As Boolean
    '        DATA_SEARCH_vS2 = False
    '        Try
    '            Dim i As Integer

    '            DS1 = PrcDS("USP_ISUD3474A_SEARCH_vS2", cn, L3471.InvoiceNo)

    '            If GetDsRc(DS1) = 0 Then
    '                DS2 = PrcDS("USP_ISUD3474A_SEARCH_vS2_INSERT", cn, L3471.InvoiceNo)

    '                SPR_PRO(vS2, DS2, "USP_ISUD3474A_SEARCH_vS2", "vS2")
    '                SPR_TEXTBOXM(vS2, getColumIndex(vS2, "Content"))
    '                SPR_TEXTBOXM(vS2, getColumIndex(vS2, "Content1"))
    '                For i = 0 To vS2.ActiveSheet.RowCount - 1
    '                    If vS2.ActiveSheet.Rows(i).GetPreferredHeight > D9914.Rowheight Then vS2.ActiveSheet.Rows(i).Height = vS2.ActiveSheet.Rows(i).GetPreferredHeight
    '                Next

    '                vS2.Enabled = True
    '                Exit Function
    '            End If

    '            SPR_PRO(vS2, DS1, "USP_ISUD3474A_SEARCH_vS2", "vS2")
    '            SPR_TEXTBOXM(vS2, getColumIndex(vS2, "Content"))
    '            SPR_TEXTBOXM(vS2, getColumIndex(vS2, "Content1"))
    '            For i = 0 To vS2.ActiveSheet.RowCount - 1
    '                If vS2.ActiveSheet.Rows(i).GetPreferredHeight > D9914.Rowheight Then vS2.ActiveSheet.Rows(i).Height = vS2.ActiveSheet.Rows(i).GetPreferredHeight
    '            Next


    '            DATA_SEARCH_vS2 = True
    '        Catch ex As Exception

    '        End Try
    '    End Function

    '    Private Function DATA_SEARCH_vS3() As Boolean
    '        DATA_SEARCH_vS3 = False
    '        Try
    '            Dim i As Integer

    '            DS1 = PrcDS("USP_ISUD3474A_SEARCH_vS3", cn, L3471.InvoiceNo)

    '            If GetDsRc(DS1) = 0 Then
    '                SPR_PRO(vS3, DS1, "USP_ISUD3474A_SEARCH_vS3", "vS3")

    '                vS3.Enabled = True
    '                Exit Function
    '            End If

    '            SPR_PRO(vS3, DS1, "USP_ISUD3474A_SEARCH_vS3", "vS3")



    '            DATA_SEARCH_vS3 = True
    '        Catch ex As Exception

    '        End Try
    '    End Function

    '    Private Function DATA_SEARCH_vS1_AUTO() As Boolean
    '        DATA_SEARCH_vS1_AUTO = False
    '        Try
    '            DS1 = PrcDS("USP_ISUD3474A_SEARCH_VS1_AUTO", cn, strValue)

    '            If GetDsRc(DS1) = 0 Then
    '                SPR_PRO(Vs1, DS1, "USP_ISUD3474A_SEARCH_VS1", "Vs1")

    '                Vs1.Enabled = True
    '                Exit Function
    '            End If

    '            SPR_PRO(Vs1, DS1, "USP_ISUD3474A_SEARCH_VS1", "Vs1")

    '            DATA_SEARCH_vS1_AUTO = True
    '        Catch ex As Exception

    '        End Try
    '    End Function



    '#End Region

    '#Region "Function"
    '    Private Sub CheckMarketType()

    '    End Sub

    '    Private Sub DATA_MOVE()
    '        If chk_IsPosted.Checked Then W3471.Status = "1" Else W3471.Status = "2"
    '        If chk_AllLines.Checked Then W3471.CheckMarketType = "1" Else W3471.CheckMarketType = "2"
    '    End Sub

    '    Private Sub DATA_MOVE_DEFAULT()

    '    End Sub

    '    Private Function DATA_MOVE_WRITE01() As Boolean
    '        DATA_MOVE_WRITE01 = False
    '        Try
    '            Dim i As Integer
    '            Dim j As Integer
    '            Dim chk_Line As Boolean = False

    '            D3474_CLEAR()
    '            M3474 = D3474

    '            If PeaceTabControl1.SelectedIndex = 0 Then
    '                For i = 0 To Vs1.ActiveSheet.RowCount - 1
    '                    If K3474_MOVE(Vs1, i, W3474, L3471.InvoiceNo, getData(Vs1, getColumIndex(Vs1, "InvoiceSeq"), i)) = True Then

    '                        Call DATA_MOVE_DEFAULT()

    '                        If chk_Line = True And chk_AllLines.Checked Then
    '                            W3474.SONo = M3474.SONo
    '                            W3474.BookingNo = M3474.BookingNo
    '                            W3474.DateEXFac = M3474.DateEXFac
    '                            W3474.DateETD = M3474.DateETD
    '                            W3474.DateETA = M3474.DateETA
    '                            W3474.ChkDeclare = M3474.ChkDeclare
    '                            W3474.ChkDocsBuyer = M3474.ChkDocsBuyer
    '                            W3474.ChkDocsHK = M3474.ChkDocsHK
    '                            W3474.ChkLocalCharge = M3474.ChkLocalCharge
    '                            W3474.ChkSMDocs = M3474.ChkSMDocs
    '                            W3474.ChkUploadDocs = M3474.ChkUploadDocs
    '                            W3474.ShipmentType = M3474.ShipmentType
    '                            W3474.BLNo = M3474.BLNo
    '                            W3474.VesselName = M3474.VesselName


    '                        End If


    '                        If REWRITE_PFK3474(W3474) And chk_AllLines.Checked Then
    '                            If chk_Line = False Then
    '                                M3474 = W3474
    '                                chk_Line = True
    '                            End If
    '                        End If

    '                        isudCHK = True
    '                    Else

    '                        Call KEY_COUNT_PFK3474()
    '                        Call DATA_MOVE_DEFAULT()

    '                        W3474.InvoiceNo = L3471.InvoiceNo

    '                        If chk_Line = True And chk_AllLines.Checked Then
    '                            W3474.SONo = M3474.SONo
    '                            W3474.BookingNo = M3474.BookingNo
    '                            W3474.DateEXFac = M3474.DateEXFac
    '                            W3474.DateETD = M3474.DateETD
    '                            W3474.DateETA = M3474.DateETA
    '                            W3474.ChkDeclare = M3474.ChkDeclare
    '                            W3474.ChkDocsBuyer = M3474.ChkDocsBuyer
    '                            W3474.ChkDocsHK = M3474.ChkDocsHK
    '                            W3474.ChkLocalCharge = M3474.ChkLocalCharge
    '                            W3474.ChkSMDocs = M3474.ChkSMDocs
    '                            W3474.ChkUploadDocs = M3474.ChkUploadDocs
    '                            W3474.ShipmentType = M3474.ShipmentType
    '                            W3474.BLNo = M3474.BLNo
    '                            W3474.VesselName = M3474.VesselName
    '                        End If


    '                        If WRITE_PFK3474(W3474) Then

    '                            If chk_Line = False And chk_AllLines.Checked Then
    '                                M3474 = W3474
    '                                chk_Line = True
    '                            End If

    '                            wJOB = 3
    '                            isudCHK = True
    '                        End If
    '                    End If

    'skip:

    '                Next


    '            ElseIf PeaceTabControl1.SelectedIndex = 1 Then
    '                Dim strList As New List(Of String)

    '                strList.Add(L3471.InvoiceNo)

    '                For i = 0 To vS2.ActiveSheet.RowCount - 1
    '                    strList.Add(getData(vS2, 1, i))

    '                Next

    '                For i = 0 To vS2.ActiveSheet.RowCount - 1
    '                    strList.Add(getData(vS2, 2, i))

    '                Next

    '                Call PrcExeNoError("EXP_PFK3474_UPDATE_INVOICE_INFORMATION", cn, strList.ToArray)


    '            ElseIf PeaceTabControl1.SelectedIndex = 2 Then

    '                For i = 0 To vS3.ActiveSheet.RowCount - 1


    '                    If READ_PFK3474(L3471.InvoiceNo, getData(vS3, getColumIndex(vS3, "InvoiceSeq"), i)) = True Then
    '                        W3474 = D3474
    '                        W3474.ContName1 = getData(vS3, getColumIndex(vS3, "ContName1"), i)
    '                        W3474.ContName2 = getData(vS3, getColumIndex(vS3, "ContName2"), i)
    '                        W3474.ContName3 = getData(vS3, getColumIndex(vS3, "ContName3"), i)
    '                        W3474.ContName4 = getData(vS3, getColumIndex(vS3, "ContName4"), i)
    '                        W3474.ContName5 = getData(vS3, getColumIndex(vS3, "ContName5"), i)
    '                        W3474.ContName6 = getData(vS3, getColumIndex(vS3, "ContName6"), i)
    '                        W3474.ContName7 = getData(vS3, getColumIndex(vS3, "ContName7"), i)
    '                        W3474.ContName8 = getData(vS3, getColumIndex(vS3, "ContName8"), i)
    '                        W3474.ContName9 = getData(vS3, getColumIndex(vS3, "ContName9"), i)
    '                        W3474.ContName10 = getData(vS3, getColumIndex(vS3, "ContName10"), i)

    '                        W3474.QtyPL1 = CDecp(getData(vS3, getColumIndex(vS3, "QtyPL1"), i))
    '                        W3474.QtyPL2 = CDecp(getData(vS3, getColumIndex(vS3, "QtyPL2"), i))
    '                        W3474.QtyPL3 = CDecp(getData(vS3, getColumIndex(vS3, "QtyPL3"), i))
    '                        W3474.QtyPL4 = CDecp(getData(vS3, getColumIndex(vS3, "QtyPL4"), i))
    '                        W3474.QtyPL5 = CDecp(getData(vS3, getColumIndex(vS3, "QtyPL5"), i))
    '                        W3474.QtyPL6 = CDecp(getData(vS3, getColumIndex(vS3, "QtyPL6"), i))
    '                        W3474.QtyPL7 = CDecp(getData(vS3, getColumIndex(vS3, "QtyPL7"), i))
    '                        W3474.QtyPL8 = CDecp(getData(vS3, getColumIndex(vS3, "QtyPL8"), i))
    '                        W3474.QtyPL9 = CDecp(getData(vS3, getColumIndex(vS3, "QtyPL9"), i))
    '                        W3474.QtyPL10 = CDecp(getData(vS3, getColumIndex(vS3, "QtyPL10"), i))

    '                        Call REWRITE_PFK3474(W3474)

    '                    End If
    '                Next


    '            End If


    '            DATA_MOVE_WRITE01 = True
    '        Catch ex As Exception
    '            MsgBoxP("DATA_MOVE_WRITE01")
    '        End Try

    '    End Function

    '    Private Sub DATA_INSERT()

    '        Try

    '            If K3471_MOVE(Me, W3471, 1, L3471.InvoiceNo) = False Then
    '                Call KEY_COUNT()

    '                W3471.seSite = ListCode("Site")
    '                W3471.cdSite = txt_cdSite.Code

    '                W3471.seUnitPrice = ListCode("UnitPrice")

    '                W3471.InchargeInvoice = txt_InchargeInvoice.Code

    '                Call DATA_MOVE()
    '                If WRITE_PFK3471(W3471) = True Then
    '                    Call DATA_MOVE_WRITE01()

    '                    isudCHK = True : WRITE_CHK = "*"
    '                    wJOB = 3
    '                End If
    '            End If
    '        Catch ex As Exception

    '        End Try

    '    End Sub
    '    Private Sub DATA_UPDATE()
    '        Try
    '            If K3471_MOVE(Me, W3471, 3, L3471.InvoiceNo) = True Then
    '                Call DATA_MOVE()

    '                If REWRITE_PFK3471(W3471) = True Then

    '                    Call DATA_MOVE_WRITE01()

    '                    isudCHK = True
    '                End If
    '            End If
    '        Catch ex As Exception
    '            Call MsgBoxP("35", "DATA_UPDATE")
    '        End Try
    '    End Sub

    '    Private Sub DATA_DELETE()
    '        Try
    '            Dim i As Integer

    '            If READ_PFK3471(txt_InvoiceNo.Data) = True Then
    '                W3471 = D3471
    '                If DELETE_PFK3471(W3471) = True Then
    '                    isudCHK = True
    '                    Me.Dispose()
    '                End If
    '            End If
    '        Catch ex As Exception

    '            Call MsgBoxP("38", "DATA_DELETE")
    '        End Try
    '    End Sub

    '    Private Sub KEY_COUNT()
    '        Dim YRNO As Integer
    '        Dim MaxChk As Boolean = False

    '        YRNO = Mid(System_Date_8(), 3, 4)

    '        Try
    '            SQL = "SELECT MAX(CAST(SUBSTRING(K3471_InvoiceNo,7,3) AS DECIMAL)) AS MAX_MCODE FROM PFK3471 "
    '            SQL = SQL & " WHERE SUBSTRING(K3471_InvoiceNo,3,4) = '" & YRNO.ToString & "' "
    '            cmd = New SqlClient.SqlCommand(SQL, cn)
    '            rd = cmd.ExecuteReader
    '            rd.Read()

    '            If IsDBNull(rd!MAX_MCODE) Then

    '            Else
    '                If rd!MAX_MCODE = 999 Then
    '                    MaxChk = True
    '                    YRNO += 1
    '                End If

    '            End If
    '            rd.Close()


    '            SQL = "SELECT MAX(CAST(SUBSTRING(K3471_InvoiceNo,7,3) AS DECIMAL)) AS MAX_MCODE FROM PFK3471 "
    '            SQL = SQL & " WHERE SUBSTRING(K3471_InvoiceNo,3,4) = '" & YRNO.ToString & "' "
    '            cmd = New SqlClient.SqlCommand(SQL, cn)
    '            rd = cmd.ExecuteReader
    '            rd.Read()

    '            If IsDBNull(rd!MAX_MCODE) Then
    '                W3471.InvoiceNo = "IC" & YRNO & "001"
    '            Else
    '                W3471.InvoiceNo = "IC" & YRNO & Format(CInt(rd!MAX_MCODE + 1), "000")

    '            End If

    '            rd.Close()

    '            L3471.InvoiceNo = W3471.InvoiceNo
    '            txt_InvoiceNo.Data = W3471.InvoiceNo


    '        Catch ex As Exception
    '            Call MsgBoxP("35", "KEY_COUNT")
    '        End Try
    '    End Sub

    '    Private Sub DATA_INIT()
    '        Try
    '            txt_InvoiceNo.Enabled = False
    '            Call D3471_CLEAR()
    '            txt_DateInvoice.Data = System_Date_8()

    '            If READ_PFK7411(Pub.SAW) Then
    '                txt_InchargeInvoice.Data = D7411.Name
    '                txt_InchargeInvoice.Code = D7411.IDNO
    '            End If


    '            W3471 = D3471

    '        Catch ex As Exception
    '            Call MsgBoxP("35", "DATA_INIT")
    '        End Try

    '    End Sub

    '    Private Sub FORM_INIT()


    '    End Sub



    '#End Region

    '#Region "Event"
    '    Private Function Data_Check() As Boolean
    '        Data_Check = False
    '        Dim i As Integer
    '        Dim qtyOrder As Decimal
    '        Dim OrderNo As String
    '        Dim OrderNoSeq As String

    '        Try
    '            For i = 0 To Vs1.ActiveSheet.RowCount - 1

    '                qtyOrder = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyOrder"), i))
    '                OrderNo = getData(Vs1, getColumIndex(Vs1, "OrderNo"), i)
    '                OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "OrderNoSeq"), i)


    '                Dim strMsg As String

    '                strMsg = PrcExeNoError_ValueVN(" EXP_CLOSSING_PFK3471_CHECK_QTYORDER", cn, OrderNo, OrderNoSeq, qtyOrder)

    '                If strMsg <> "" Then
    '                    Call MsgBoxP(strMsg)
    '                    Exit Function
    '                End If


    '                'If READ_PFK1312(OrderNo, OrderNoSeq) Then
    '                '    If CDecp(getData(Vs1, getColumIndex(Vs1, "QtyOrder"), i)) > D1312.QtyOrder Then


    '                '        MsgBoxP("Dư số lượng ở dòng " & (i + 1)) : Exit Function
    '                '    End If
    '                'End If



    'skip:
    '            Next

    '            Data_Check = True
    '        Catch ex As Exception

    '        End Try
    '    End Function

    '    Private Sub KEY_COUNT_PFK3474()
    '        Try
    '            SQL = "SELECT MAX(CAST(K3474_InvoiceSeq AS DECIMAL)) AS MAX_MCODE FROM PFK3474 "
    '            SQL = SQL & " WHERE K3474_InvoiceNo = '" & L3471.InvoiceNo & "' "
    '            cmd = New SqlClient.SqlCommand(SQL, cn)
    '            rd = cmd.ExecuteReader
    '            rd.Read()

    '            If IsDBNull(rd!MAX_MCODE) Then
    '                W3474.InvoiceSeq = "0001"
    '            Else
    '                W3474.InvoiceSeq = CIntp(rd!MAX_MCODE + 1).ToString("0000")
    '            End If

    '            rd.Close()

    '            L3474.InvoiceSeq = W3474.InvoiceSeq


    '            rd.Close()

    '        Catch ex As Exception
    '            Call MsgBoxP("35", "KEY_COUNT_PFK3474")
    '        End Try
    '    End Sub

    '    Private Sub DATA_CLOSE()
    '        Try
    '            Dim strMsg As String

    '            strMsg = PrcExeNoError_ValueVN(" EXP_CLOSSING_PFK3471_CHECK", cn, txt_InvoiceNo.Data)

    '            If strMsg <> "" Then
    '                Call MsgBoxP(strMsg)
    '                Exit Sub
    '            End If

    '            Call PrcExeNoError(" EXP_CLOSSING_PFK3471", cn, txt_InvoiceNo.Data)

    '        Catch ex As Exception

    '        End Try
    '    End Sub
    '    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
    '        Select Case wJOB
    '            Case 1
    '                If Data_Check() = False Then Exit Sub
    '                'If DataCheck(Me, "PFK3471") = False Then Exit Sub

    '                Call KEY_COUNT()
    '                Call DATA_INSERT()
    '                Call DATA_CLOSE()

    '                If PeaceTabControl1.SelectedIndex = 0 Then Call DATA_SEARCH_vS1()
    '                If PeaceTabControl1.SelectedIndex = 1 Then Call DATA_SEARCH_vS2()
    '                If PeaceTabControl1.SelectedIndex = 2 Then Call DATA_SEARCH_vS3()

    '                Call MsgBoxP("Update Successully!", vbInformation)
    '                wJOB = 3

    '            Case 2
    '                Me.Dispose()

    '            Case 3
    '                If Data_Check() = False Then Exit Sub
    '                'If DataCheck(Me, "PFK3471") = False Then Exit Sub

    '                Call DATA_UPDATE()
    '                Call DATA_CLOSE()
    '                Call MsgBoxP("Update Successully!", vbInformation)

    '                If PeaceTabControl1.SelectedIndex = 0 Then Call DATA_SEARCH_vS1()
    '                If PeaceTabControl1.SelectedIndex = 1 Then Call DATA_SEARCH_vS2()
    '                If PeaceTabControl1.SelectedIndex = 2 Then Call DATA_SEARCH_vS3()

    '            Case 4
    '                Call DATA_DELETE()
    '                Call DATA_CLOSE()
    '                Me.Dispose()

    '            Case 11
    '                If Data_Check() = False Then Exit Sub
    '                'If DataCheck(Me, "PFK3471") = False Then Exit Sub

    '                Call DATA_INSERT()
    '                Call DATA_CLOSE()
    '                If PeaceTabControl1.SelectedIndex = 0 Then Call DATA_SEARCH_vS1()
    '                If PeaceTabControl1.SelectedIndex = 1 Then Call DATA_SEARCH_vS2()
    '                If PeaceTabControl1.SelectedIndex = 2 Then Call DATA_SEARCH_vS3()
    '            Case 12
    '                If Data_Check() = False Then Exit Sub
    '                'If DataCheck(Me, "PFK3471") = False Then Exit Sub

    '                Call DATA_MOVE_WRITE01()
    '                Call DATA_CLOSE()
    '                If PeaceTabControl1.SelectedIndex = 0 Then Call DATA_SEARCH_vS1()
    '                If PeaceTabControl1.SelectedIndex = 1 Then Call DATA_SEARCH_vS2()
    '                If PeaceTabControl1.SelectedIndex = 2 Then Call DATA_SEARCH_vS3()
    '                wJOB = 3
    '        End Select
    '    End Sub
    '    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles tst_iClose.Click
    '        If WRITE_CHK = "*" Then
    '            isudCHK = True
    '        Else
    '            isudCHK = False
    '        End If

    '        Me.Dispose()
    '    End Sub

    '    Private Sub tst_iDelete_Click(sender As Object, e As EventArgs) Handles tst_iDelete.Click
    '        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

    '        If CHK(4) <> "1" Then
    '            Call MsgBoxP("4", "tst_iDelete_Click")
    '            Exit Sub
    '        End If

    '        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

    '        If str <> vbYes Then Exit Sub

    '        Call DATA_DELETE()
    '        Call DATA_CLOSE()
    '        Me.Dispose()
    '    End Sub

    '    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change
    '        Dim xCOL As Long
    '        Dim xROW As Long

    '        Try

    '            xROW = e.Row
    '            xCOL = e.Column

    '            vSChange(xROW)

    '        Catch ex As Exception

    '        End Try

    '    End Sub

    '    Private Sub vSChange(xROW As Integer)
    '        Try

    '            Dim QtyOrder As Decimal
    '            Dim PriceOrderFOB As Decimal
    '            Dim TotalAMTFOB As Decimal
    '            Dim PriceOrder As Decimal
    '            Dim TotalAMT As Decimal

    '            QtyOrder = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyOrder"), xROW))
    '            PriceOrderFOB = Math.Round(CDecp(getData(Vs1, getColumIndex(Vs1, "PriceOrderFOB"), xROW)), 2)

    '            PriceOrder = Math.Round(CDecp(getData(Vs1, getColumIndex(Vs1, "PriceOrder"), xROW)), 2)

    '            TotalAMTFOB = PriceOrderFOB * QtyOrder
    '            TotalAMT = PriceOrder * QtyOrder

    '            setData(Vs1, getColumIndex(Vs1, "QtyOrder"), xROW, QtyOrder)
    '            setData(Vs1, getColumIndex(Vs1, "PriceOrderFOB"), xROW, PriceOrderFOB)
    '            setData(Vs1, getColumIndex(Vs1, "PriceOrder"), xROW, PriceOrder)
    '            setData(Vs1, getColumIndex(Vs1, "TotalAMTFOB"), xROW, TotalAMTFOB)
    '            setData(Vs1, getColumIndex(Vs1, "TotalAMT"), xROW, TotalAMT)

    '        Catch ex As Exception

    '        End Try
    '    End Sub


    '    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
    '        If wJOB = 2 Then Exit Sub
    '        Dim xCOL As Long
    '        Dim xROW As Long

    '        xCOL = Vs1.ActiveSheet.ActiveColumnIndex
    '        xROW = Vs1.ActiveSheet.ActiveRowIndex

    '        Select Case e.KeyCode
    '            Case Keys.Insert

    '                If xROW = sender.ActiveSheet.RowCount - 1 Then
    '                    Vs1.ActiveSheet.RowCount += 1
    '                    Vs1.ActiveSheet.ActiveRowIndex = xROW + 1
    '                Else
    '                    Vs1.ActiveSheet.AddRows(xROW + 1, 1)
    '                End If

    '            Case Keys.Delete

    '                Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)

    '                If Msg_Result <> vbYes Then Exit Sub

    '                If getData(Vs1, getColumIndex(Vs1, "KEY_InvoiceSeq"), xROW) <> "0" Then

    '                    If READ_PFK3474(txt_InvoiceNo.Data, getData(Vs1, getColumIndex(Vs1, "KEY_InvoiceSeq"), xROW)) Then
    '                        W3474.InvoiceNo = txt_InvoiceNo.Data
    '                        W3474.InvoiceSeq = getDataM(Vs1, getColumIndex(Vs1, "KEY_InvoiceSeq"), xROW)
    '                        Call DELETE_PFK3474(W3474)
    '                    End If
    '                End If


    '                SPR_DEL(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
    '                Vs1.Focus()


    '            Case Keys.Enter
    '                vSChange(xROW)
    '        End Select
    '    End Sub


    '    Private Sub Vs1_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles Vs1.ButtonClicked

    '    End Sub


    '#End Region



    '    Private Sub PeaceTabControl1_DoubleClick(sender As Object, e As EventArgs) Handles PeaceTabControl1.DoubleClick
    '        If PeaceTabControl1.SelectedIndex = 0 Then Call DATA_SEARCH_vS1()
    '        If PeaceTabControl1.SelectedIndex = 1 Then Call DATA_SEARCH_vS2()
    '        If PeaceTabControl1.SelectedIndex = 2 Then Call DATA_SEARCH_vS3()
    '    End Sub

    '    Private Sub chk_IsPosted_CheckedChanged(sender As Object, e As EventArgs) Handles chk_IsPosted.CheckedChanged
    '        Try
    '            If formA = False Then Exit Sub

    '            If chk_IsPosted.Checked = False Then
    '                If READ_PFK3471(txt_InvoiceNo.Data) Then
    '                    W3471 = D3471
    '                    If W3471.Status <> "1" Then Exit Sub

    '                    If MsgBoxPPW("Please type the password to uncomplete!", const_pwDeleteLiq) = False Then Exit Sub

    '                    If W3471.Status = "1" Then Call PrcExeNoError("EXP_CLOSSING_PFK3471_UNCOMPLETE", cn, txt_InvoiceNo.Data)


    '                End If
    '            End If


    '        Catch ex As Exception

    '        End Try
    '    End Sub
End Class