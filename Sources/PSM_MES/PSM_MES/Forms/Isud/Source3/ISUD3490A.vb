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

Public Class ISUD3490A

#Region "Variable"
    Private wJOB As Integer
    Private WcheckType As Integer

    Private W3490 As New T3490_AREA
    Private L3490 As New T3490_AREA

    Private W3491 As New T3491_AREA
    Private L3491 As New T3491_AREA

    Private M3491 As New T3491_AREA

    Private WRITE_CHK As String
    Private ImportTax As Decimal
    Private EnvironmentTax As Decimal
    Private VatTax As Decimal
    Private formA As Boolean
    Private CHK(0 To 5) As String
    Private cdSemiGroupMaterial As String

#End Region

#Region "Link"
    Public Function Link_ISUD3490A(job As Integer, WIPNo As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D3490.WIPNo = WIPNo
        L3490.WIPNo = WIPNo

        wJOB = job : L3490 = D3490

        Link_ISUD3490A = False
        Try

            Select Case job
                Case 1
                Case Else

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD3490A = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("PAYABLE PROCESSING"))
        End Try

    End Function

    Private strValue As String = ""
    Public Function Link_ISUD3490A_AUTO(job As Integer, WIPNo As String, checkType As Integer, _strValue As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D3490.WIPNo = WIPNo
        L3490.WIPNo = WIPNo

        strValue = _strValue

        wJOB = job : L3490 = D3490
        WcheckType = checkType

        Link_ISUD3490A_AUTO = False
        Try

            Select Case job
                Case 1
                Case Else

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD3490A_AUTO = isudCHK


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
                Call DATA_SEARCH_vS2()

            Case 3
                Me.Text = Me.Text & " - UPDATE"

                Frame1.Enabled = True
                txt_WIPNo.Enabled = False

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
                Call DATA_SEARCH_vS2()

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
                Call DATA_SEARCH_vS2()

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
                Call DATA_SEARCH_vS2()

                wJOB = 1

            Case 12                                                      'ÀÔ·Â
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

                Call DATA_SEARCH01()
                Call DATA_SEARCH_vS1_AUTO()
                Call DATA_SEARCH_vS2()

                wJOB = 12

        End Select

        formA = True
    End Sub
#End Region

#Region "Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        DS1 = READ_PFK3490(L3490.WIPNo, cn)
        If GetDsRc(DS1) = 0 Then

            Exit Function
            isudCHK = False
        End If

        READER_MOVE(Me, DS1)

        If GetDsData(DS1, 0, "K3490_Status") = "1" Then chk_IsPosted.Checked = True : wJOB = "2" : tst_iDelete.Visible = False : tst_iSave.Visible = False
        If GetDsData(DS1, 0, "K3490_Status") <> "1" Then chk_IsPosted.Checked = False

        If GetDsData(DS1, 0, "K3490_CheckMarketType") = "1" Then chk_AllLines.Checked = True
        If GetDsData(DS1, 0, "K3490_CheckMarketType") <> "1" Then chk_AllLines.Checked = False

        If READ_PFK7101(GetDsData(DS1, 0, "K3490_DestinationID")) Then
            txt_DestinationID.Data = D7171.BasicName
            txt_DestinationID.Code = D7171.BasicCode

        End If

        DATA_SEARCH01 = True

    End Function

    Private Function DATA_SEARCH_vS1() As Boolean
        DATA_SEARCH_vS1 = False

        Dim i As Integer

        Try

            DS1 = PrcDS("USP_ISUD3490A_SEARCH_VS1", cn, L3490.WIPNo)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO(Vs1, DS1, "USP_ISUD3490A_SEARCH_VS1", "Vs1")
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO(Vs1, DS1, "USP_ISUD3490A_SEARCH_VS1", "Vs1")

            If chk_TradingExportColor Then
                DS3 = PrcDS("USP_HLP7171_LISTCOLOR", cn, ListCode("StatusExport"))

                Dim Xcol As Integer = getColumIndex(Vs1, "CheckStatus_TD")
                Dim XcolsEL As Integer = getColumIndex(Vs1, "CheckStatus_TD_Sel")


                For i = 0 To Vs1.ActiveSheet.RowCount - 1
                    SPR_BACKCOLORCELL(Vs1, FUNCTION_TRADING_BACK(getData(Vs1, Xcol, i)), XcolsEL, i)
                Next
            End If


            DATA_SEARCH_vS1 = True
        Catch ex As Exception

        End Try
    End Function
    Private Function DATA_SEARCH_vS2() As Boolean

        DATA_SEARCH_vS2 = False

        Try
            Dim i As Integer

            DS1 = PrcDS("USP_ISUD3490A_SEARCH_vS2", cn, L3490.WIPNo)

            If GetDsRc(DS1) = 0 Then
               
                SPR_PRO(vS2, DS1, "USP_ISUD3490A_SEARCH_vS2", "vS2")
               
                vS2.Enabled = True
                Exit Function
            End If

            SPR_PRO(vS2, DS1, "USP_ISUD3490A_SEARCH_vS2", "vS2")
          

            DATA_SEARCH_vS2 = True
        Catch ex As Exception

        End Try
    End Function

    Private Function DATA_SEARCH_vS3() As Boolean
        DATA_SEARCH_vS3 = False
        Try
            Dim i As Integer

            DS1 = PrcDS("USP_ISUD3490A_SEARCH_vS3", cn, L3490.WIPNo)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO(vS3, DS1, "USP_ISUD3490A_SEARCH_vS3", "vS3")

                vS3.Enabled = True
                Exit Function
            End If

            SPR_PRO(vS3, DS1, "USP_ISUD3490A_SEARCH_vS3", "vS3")



            DATA_SEARCH_vS3 = True
        Catch ex As Exception

        End Try
    End Function

    Private Function DATA_SEARCH_vS1_AUTO() As Boolean
        DATA_SEARCH_vS1_AUTO = False
        Try
            DS1 = PrcDS("USP_ISUD3490A_SEARCH_VS1_AUTO", cn, strValue)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO(Vs1, DS1, "USP_ISUD3490A_SEARCH_VS1", "Vs1")

                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO(Vs1, DS1, "USP_ISUD3490A_SEARCH_VS1", "Vs1")

            DATA_SEARCH_vS1_AUTO = True
        Catch ex As Exception

        End Try
    End Function



#End Region

#Region "Function"
    Private Sub CheckMarketType()

    End Sub

    Private Sub DATA_MOVE()
        If chk_IsPosted.Checked Then W3490.Status = "1" Else W3490.Status = "2"
        If chk_AllLines.Checked Then W3490.CheckMarketType = "1" Else W3490.CheckMarketType = "2"
    End Sub

    Private Sub DATA_MOVE_DEFAULT()

    End Sub

    Private Function DATA_MOVE_WRITE01() As Boolean
        DATA_MOVE_WRITE01 = False
        Try
            Dim i As Integer
            Dim j As Integer
            Dim chk_Line As Boolean = False

            D3491_CLEAR()
            M3491 = D3491

            If PeaceTabControl1.SelectedIndex = 0 Then
                For i = 0 To Vs1.ActiveSheet.RowCount - 1
                    If K3491_MOVE(Vs1, i, W3491, L3490.WIPNo, getData(Vs1, getColumIndex(Vs1, "WIPSeq"), i)) = True Then

                        Call DATA_MOVE_DEFAULT()

                        'If chk_Line = True And chk_AllLines.Checked Then
                        '    W3491.SONo = M3491.SONo
                        '    W3491.BookingNo = M3491.BookingNo
                        '    W3491.DateEXFac = M3491.DateEXFac
                        '    W3491.DateETD = M3491.DateETD
                        '    W3491.DateETA = M3491.DateETA
                        '    W3491.ChkDeclare = M3491.ChkDeclare
                        '    W3491.ChkDocsBuyer = M3491.ChkDocsBuyer
                        '    W3491.ChkDocsHK = M3491.ChkDocsHK
                        '    W3491.ChkLocalCharge = M3491.ChkLocalCharge
                        '    W3491.ChkSMDocs = M3491.ChkSMDocs
                        '    W3491.ChkUploadDocs = M3491.ChkUploadDocs
                        '    W3491.ShipmentType = M3491.ShipmentType
                        '    W3491.BLNo = M3491.BLNo
                        '    W3491.VesselName = M3491.VesselName


                        'End If


                        If REWRITE_PFK3491(W3491) And chk_AllLines.Checked Then
                            If chk_Line = False Then
                                M3491 = W3491
                                chk_Line = True
                            End If
                        End If

                        isudCHK = True
                    Else

                        Call KEY_COUNT_PFK3491()
                        Call DATA_MOVE_DEFAULT()

                        W3491.WIPNo = L3490.WIPNo

                        'If chk_Line = True And chk_AllLines.Checked Then
                        '    W3491.SONo = M3491.SONo
                        '    W3491.BookingNo = M3491.BookingNo
                        '    W3491.DateEXFac = M3491.DateEXFac
                        '    W3491.DateETD = M3491.DateETD
                        '    W3491.DateETA = M3491.DateETA
                        '    W3491.ChkDeclare = M3491.ChkDeclare
                        '    W3491.ChkDocsBuyer = M3491.ChkDocsBuyer
                        '    W3491.ChkDocsHK = M3491.ChkDocsHK
                        '    W3491.ChkLocalCharge = M3491.ChkLocalCharge
                        '    W3491.ChkSMDocs = M3491.ChkSMDocs
                        '    W3491.ChkUploadDocs = M3491.ChkUploadDocs
                        '    W3491.ShipmentType = M3491.ShipmentType
                        '    W3491.BLNo = M3491.BLNo
                        '    W3491.VesselName = M3491.VesselName
                        'End If


                        If WRITE_PFK3491(W3491) Then

                            If chk_Line = False And chk_AllLines.Checked Then
                                M3491 = W3491
                                chk_Line = True
                            End If

                            wJOB = 3
                            isudCHK = True
                        End If
                    End If

skip:

                Next


            ElseIf PeaceTabControl1.SelectedIndex = 1 Then
                'Dim strList As New List(Of String)

                'strList.Add(L3490.WIPNo)

                'For i = 0 To vS2.ActiveSheet.RowCount - 1
                '    strList.Add(getData(vS2, 1, i))

                'Next

                'For i = 0 To vS2.ActiveSheet.RowCount - 1
                '    strList.Add(getData(vS2, 2, i))

                'Next

                'Call PrcExeNoError("EXP_PFK3491_UPDATE_WIP_INFORMATION", cn, strList.ToArray)


            ElseIf PeaceTabControl1.SelectedIndex = 2 Then

                'For i = 0 To vS3.ActiveSheet.RowCount - 1


                '    If READ_PFK3491(L3490.WIPNo, getData(vS3, getColumIndex(vS3, "WIPSeq"), i)) = True Then
                '        W3491 = D3491
                '        W3491.ContName1 = getData(vS3, getColumIndex(vS3, "ContName1"), i)
                '        W3491.ContName2 = getData(vS3, getColumIndex(vS3, "ContName2"), i)
                '        W3491.ContName3 = getData(vS3, getColumIndex(vS3, "ContName3"), i)
                '        W3491.ContName4 = getData(vS3, getColumIndex(vS3, "ContName4"), i)
                '        W3491.ContName5 = getData(vS3, getColumIndex(vS3, "ContName5"), i)
                '        W3491.ContName6 = getData(vS3, getColumIndex(vS3, "ContName6"), i)
                '        W3491.ContName7 = getData(vS3, getColumIndex(vS3, "ContName7"), i)
                '        W3491.ContName8 = getData(vS3, getColumIndex(vS3, "ContName8"), i)
                '        W3491.ContName9 = getData(vS3, getColumIndex(vS3, "ContName9"), i)
                '        W3491.ContName10 = getData(vS3, getColumIndex(vS3, "ContName10"), i)

                '        W3491.QtyPL1 = CDecp(getData(vS3, getColumIndex(vS3, "QtyPL1"), i))
                '        W3491.QtyPL2 = CDecp(getData(vS3, getColumIndex(vS3, "QtyPL2"), i))
                '        W3491.QtyPL3 = CDecp(getData(vS3, getColumIndex(vS3, "QtyPL3"), i))
                '        W3491.QtyPL4 = CDecp(getData(vS3, getColumIndex(vS3, "QtyPL4"), i))
                '        W3491.QtyPL5 = CDecp(getData(vS3, getColumIndex(vS3, "QtyPL5"), i))
                '        W3491.QtyPL6 = CDecp(getData(vS3, getColumIndex(vS3, "QtyPL6"), i))
                '        W3491.QtyPL7 = CDecp(getData(vS3, getColumIndex(vS3, "QtyPL7"), i))
                '        W3491.QtyPL8 = CDecp(getData(vS3, getColumIndex(vS3, "QtyPL8"), i))
                '        W3491.QtyPL9 = CDecp(getData(vS3, getColumIndex(vS3, "QtyPL9"), i))
                '        W3491.QtyPL10 = CDecp(getData(vS3, getColumIndex(vS3, "QtyPL10"), i))

                '        Call REWRITE_PFK3491(W3491)

                '    End If
                'Next


            End If


            DATA_MOVE_WRITE01 = True
        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE01")
        End Try

    End Function

    Private Sub DATA_INSERT()

        Try

            If K3490_MOVE(Me, W3490, 1, L3490.WIPNo) = False Then
                Call KEY_COUNT()

                W3490.seSite = ListCode("Site")
                W3490.cdSite = txt_cdSite.Code

                W3490.seUnitPrice = ListCode("UnitPrice")

                W3490.InchargeWIP = txt_InchargeWIP.Code

                Call DATA_MOVE()
                If WRITE_PFK3490(W3490) = True Then
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
            If K3490_MOVE(Me, W3490, 3, L3490.WIPNo) = True Then
                Call DATA_MOVE()

                If REWRITE_PFK3490(W3490) = True Then

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

            If READ_PFK3490(txt_WIPNo.Data) = True Then
                W3490 = D3490
                If DELETE_PFK3490(W3490) = True Then
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
            SQL = "SELECT MAX(CAST(SUBSTRING(K3490_WIPNo,7,3) AS DECIMAL)) AS MAX_MCODE FROM PFK3490 "
            SQL = SQL & " WHERE SUBSTRING(K3490_WIPNo,3,4) = '" & YRNO.ToString & "' "
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


            SQL = "SELECT MAX(CAST(SUBSTRING(K3490_WIPNo,7,3) AS DECIMAL)) AS MAX_MCODE FROM PFK3490 "
            SQL = SQL & " WHERE SUBSTRING(K3490_WIPNo,3,4) = '" & YRNO.ToString & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W3490.WIPNo = "WP" & YRNO & "001"
            Else
                W3490.WIPNo = "WP" & YRNO & Format(CInt(rd!MAX_MCODE + 1), "000")

            End If

            rd.Close()

            L3490.WIPNo = W3490.WIPNo
            txt_WIPNo.Data = W3490.WIPNo


        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub DATA_INIT()
        Try
            txt_WIPNo.Enabled = False
            Call D3490_CLEAR()
            txt_DateWIP.Data = System_Date_8()

            If READ_PFK7411(Pub.SAW) Then
                txt_InchargeWIP.Data = D7411.Name
                txt_InchargeWIP.Code = D7411.IDNO
            End If


            W3490 = D3490

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()
        PeaceTabControl1.TabPages.RemoveAt(2)
        PeaceTabControl1.TabPages.RemoveAt(2)
        PeaceTabControl1.TabPages.RemoveAt(2)

    End Sub



#End Region

#Region "Event"
    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim i As Integer
        Dim qtyOrder As Decimal
        Dim OrderNo As String
        Dim OrderNoSeq As String
        Dim WIPNo As String
        Dim WIPSeq As String

        Try
            For i = 0 To Vs1.ActiveSheet.RowCount - 1

                qtyOrder = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyOrder"), i))
                OrderNo = getData(Vs1, getColumIndex(Vs1, "OrderNo"), i)
                OrderNoSeq = getData(Vs1, getColumIndex(Vs1, "OrderNoSeq"), i)

                WIPNo = getData(Vs1, getColumIndex(Vs1, "KEY_WIPNo"), i)
                WIPSeq = getData(Vs1, getColumIndex(Vs1, "KEY_WIPSeq"), i)

                Dim strMsg As String

                strMsg = PrcExeNoError_ValueVN(" EXP_CLOSSING_PFK3490_CHECK_QTYORDER", cn, OrderNo, OrderNoSeq, qtyOrder, WIPNo, WIPSeq)

                If strMsg <> "" Then
                    Call MsgBoxP(strMsg)
                    Exit Function
                End If


                'If READ_PFK1312(OrderNo, OrderNoSeq) Then
                '    If CDecp(getData(Vs1, getColumIndex(Vs1, "QtyOrder"), i)) > D1312.QtyOrder Then


                '        MsgBoxP("Dư số lượng ở dòng " & (i + 1)) : Exit Function
                '    End If
                'End If



skip:
            Next

            Data_Check = True
        Catch ex As Exception

        End Try
    End Function

    Private Sub KEY_COUNT_PFK3491()
        Try
            SQL = "SELECT MAX(CAST(K3491_WIPSeq AS DECIMAL)) AS MAX_MCODE FROM PFK3491 "
            SQL = SQL & " WHERE K3491_WIPNo = '" & L3490.WIPNo & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W3491.WIPSeq = "0001"
            Else
                W3491.WIPSeq = CIntp(rd!MAX_MCODE + 1).ToString("0000")
            End If

            rd.Close()

            L3491.WIPSeq = W3491.WIPSeq


            rd.Close()

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT_PFK3491")
        End Try
    End Sub

    Private Sub DATA_CLOSE()
        Try
            Dim strMsg As String

            strMsg = PrcExeNoError_ValueVN(" EXP_CLOSSING_PFK3490_CHECK", cn, txt_WIPNo.Data)

            If strMsg <> "" Then
                Call MsgBoxP(strMsg)
                Exit Sub
            End If

            Call PrcExeNoError(" EXP_CLOSSING_PFK3490", cn, txt_WIPNo.Data)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Sub
                'If DataCheck(Me, "PFK3490") = False Then Exit Sub

                Call KEY_COUNT()
                Call DATA_INSERT()
                Call DATA_CLOSE()

                If PeaceTabControl1.SelectedIndex = 0 Then Call DATA_SEARCH_vS1()
                If PeaceTabControl1.SelectedIndex = 1 Then Call DATA_SEARCH_vS2()
                If PeaceTabControl1.SelectedIndex = 2 Then Call DATA_SEARCH_vS3()

                Call MsgBoxP("Update Successully!", vbInformation)
                wJOB = 3

            Case 2
                Me.Dispose()

            Case 3
                If Data_Check() = False Then Exit Sub
                'If DataCheck(Me, "PFK3490") = False Then Exit Sub

                Call DATA_UPDATE()
                Call DATA_CLOSE()
                Call MsgBoxP("Update Successully!", vbInformation)

                If PeaceTabControl1.SelectedIndex = 0 Then Call DATA_SEARCH_vS1()
                If PeaceTabControl1.SelectedIndex = 1 Then Call DATA_SEARCH_vS2()
                If PeaceTabControl1.SelectedIndex = 2 Then Call DATA_SEARCH_vS3()

            Case 4
                Call DATA_DELETE()
                Call DATA_CLOSE()
                Me.Dispose()

            Case 11
                If Data_Check() = False Then Exit Sub
                'If DataCheck(Me, "PFK3490") = False Then Exit Sub

                Call DATA_INSERT()
                Call DATA_CLOSE()
                If PeaceTabControl1.SelectedIndex = 0 Then Call DATA_SEARCH_vS1()
                If PeaceTabControl1.SelectedIndex = 1 Then Call DATA_SEARCH_vS2()
                If PeaceTabControl1.SelectedIndex = 2 Then Call DATA_SEARCH_vS3()
            Case 12
                If Data_Check() = False Then Exit Sub
                'If DataCheck(Me, "PFK3490") = False Then Exit Sub

                Call DATA_MOVE_WRITE01()
                Call DATA_CLOSE()
                If PeaceTabControl1.SelectedIndex = 0 Then Call DATA_SEARCH_vS1()
                If PeaceTabControl1.SelectedIndex = 1 Then Call DATA_SEARCH_vS2()
                If PeaceTabControl1.SelectedIndex = 2 Then Call DATA_SEARCH_vS3()
                wJOB = 3
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

            Dim QtyOrder As Decimal
            Dim PriceOrderFOB As Decimal
            Dim TotalAMTFOB As Decimal
            Dim PriceOrder As Decimal
            Dim TotalAMT As Decimal

            QtyOrder = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyOrder"), xROW))
            PriceOrderFOB = Math.Round(CDecp(getData(Vs1, getColumIndex(Vs1, "PriceOrderFOB"), xROW)), 2)

            PriceOrder = Math.Round(CDecp(getData(Vs1, getColumIndex(Vs1, "PriceOrder"), xROW)), 2)

            TotalAMTFOB = PriceOrderFOB * QtyOrder
            TotalAMT = PriceOrder * QtyOrder

            setData(Vs1, getColumIndex(Vs1, "QtyOrder"), xROW, QtyOrder)
            setData(Vs1, getColumIndex(Vs1, "PriceOrderFOB"), xROW, PriceOrderFOB)
            setData(Vs1, getColumIndex(Vs1, "PriceOrder"), xROW, PriceOrder)
            setData(Vs1, getColumIndex(Vs1, "TotalAMTFOB"), xROW, TotalAMTFOB)
            setData(Vs1, getColumIndex(Vs1, "TotalAMT"), xROW, TotalAMT)

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

                If getData(Vs1, getColumIndex(Vs1, "KEY_WIPSeq"), xROW) <> "0" Then

                    If READ_PFK3491(txt_WIPNo.Data, getData(Vs1, getColumIndex(Vs1, "KEY_WIPSeq"), xROW)) Then
                        W3491.WIPNo = txt_WIPNo.Data
                        W3491.WIPSeq = getDataM(Vs1, getColumIndex(Vs1, "KEY_WIPSeq"), xROW)
                        Call DELETE_PFK3491(W3491)
                    End If
                End If


                SPR_DEL(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
                Vs1.Focus()


            Case Keys.Enter
                vSChange(xROW)
        End Select
    End Sub


    Private Sub Vs1_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles Vs1.ButtonClicked

    End Sub


#End Region



    Private Sub PeaceTabControl1_DoubleClick(sender As Object, e As EventArgs) Handles PeaceTabControl1.DoubleClick
        If PeaceTabControl1.SelectedIndex = 0 Then Call DATA_SEARCH_vS1()
        If PeaceTabControl1.SelectedIndex = 1 Then Call DATA_SEARCH_vS2()
        If PeaceTabControl1.SelectedIndex = 2 Then Call DATA_SEARCH_vS3()
    End Sub

    Private Sub chk_IsPosted_CheckedChanged(sender As Object, e As EventArgs) Handles chk_IsPosted.CheckedChanged
        Try
            If formA = False Then Exit Sub

            If chk_IsPosted.Checked = False Then
                If READ_PFK3490(txt_WIPNo.Data) Then
                    W3490 = D3490
                    If W3490.Status <> "1" Then Exit Sub

                    If MsgBoxPPW("Please type the password to uncomplete!", const_pwDeleteLiq) = False Then Exit Sub

                    If W3490.Status = "1" Then Call PrcExeNoError("EXP_CLOSSING_PFK3490_UNCOMPLETE", cn, txt_WIPNo.Data)


                End If
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_GetRM_Click(sender As Object, e As EventArgs) Handles cmd_GetRM.Click
        Try
            If READ_PFK3490(txt_WIPNo.Data) Then
                W3490 = D3490
                If W3490.Status = "1" Then Exit Sub

                
                If W3490.Status <> "1" Then Call PrcExeNoError("EXP_CLOSSING_PFK3490_GETDATA", cn, txt_WIPNo.Data)


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If READ_PFK3490(txt_WIPNo.Data) Then
                W3490 = D3490
                If W3490.Status = "1" Then Exit Sub

                Dim i As Integer
                Dim j As Integer
                Dim chk_Line As Boolean = False

            
                For i = 0 To Vs1.ActiveSheet.RowCount - 1
                    If READ_PFK3491(txt_WIPNo.Data, getData(Vs1, getColumIndex(Vs1, "WIPSeq"), i)) = True Then
                        W3491 = D3491

                        Call PrcExeNoError("USP_PFK3019_ROW_NUMBER_F2", cn, W3491.OrderNo, W3491.OrderNoSeq)

                    End If

                Next

                If W3490.Status <> "1" Then Call PrcExeNoError("EXP_CLOSSING_PFK3490_GETDATA_RND", cn, txt_WIPNo.Data)



            End If
        Catch ex As Exception

        End Try
    End Sub
End Class