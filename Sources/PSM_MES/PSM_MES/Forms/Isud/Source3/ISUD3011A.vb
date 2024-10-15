Public Class ISUD3011A

#Region "Variable"
    Private wJOB As Integer

    Private W3011 As New T3011_AREA
    Private L3011 As New T3011_AREA

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String

    Private Chk_AutoLink As Boolean = False

    Private L_CustomerCode As String
    Private L_cdSeason As String
    Private L_Line As String
    Private L_cdLargeGroupMaterial As String
    Private L_cdSemiGroupMaterial As String
    Private L_checkSample As String

#End Region

#Region "Link"
    Public Function Link_ISUD3011A(job As Integer, PRNo As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        D3011.PRNo = PRNo

        wJOB = job : L3011 = D3011

        Link_ISUD3011A = False
        Try

            Select Case job
                Case 1
                Case Else
                    If READ_PFK3011_1(L3011.PRNo) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    Else
                        L3011 = D3011
                    End If
                    txt_DateOrderMaterialAccept.Enabled = False

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD3011A = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Request Order Processing"))
        End Try


    End Function
    Public Function Link_ISUD3011A_AUTO(job As Integer, cdSeason As String, CustomerCode As String, _Line As String, _cdLargeGroupMaterial As String, _cdSemiGroupMaterial As String, _checkSample As String, PRNo As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        Chk_AutoLink = True

        D3011.CustomerCode = CustomerCode
        D3011.cdSeason = cdSeason
        D3011.PRNo = PRNo

        L_CustomerCode = CustomerCode
        L_cdSeason = cdSeason
        L_Line = _Line
        L_cdLargeGroupMaterial = _cdLargeGroupMaterial
        L_cdSemiGroupMaterial = _cdSemiGroupMaterial
        L_checkSample = _checkSample

        If READ_PFK7101(CustomerCode) Then
            txt_CustomerCode.Data = D7101.CustomerName
            txt_CustomerCode.Code = D7101.CustomerCode
        End If

        If READ_PFK7171(ListCode("Season"), cdSeason) Then
            txt_cdSeason.Data = D7171.BasicName
            txt_cdSeason.Code = D7171.BasicCode
        End If


        wJOB = job : L3011 = D3011

        Link_ISUD3011A_AUTO = False
        Try

            Select Case job
                Case 1
                Case Else
                    If READ_PFK3011_1(L3011.PRNo) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    Else
                        L3011 = D3011
                    End If
                    txt_DateOrderMaterialAccept.Enabled = False

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD3011A_AUTO = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Request Order Processing"))
        End Try


    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Call DATA_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"
                cmd_DEL.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()
                Call KEY_COUNT_SEQ()

                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

                Setfocus(txt_CustomerCode)
            Case 2
                Me.Text = Me.Text & " - SEARCH"

                cmd_DEL.Visible = False
                cmd_OK.Visible = False

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

            Case 3
                Me.Text = Me.Text & " - UPDATE"
                txt_PRNo.Enabled = False
                cmd_DEL.Visible = False

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
                        cmd_DEL.Visible = False
                        cmd_OK.Visible = False
                        Call Error_Message("16", "Form_Activate")
                    End If
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

            Case 4
                Me.Text = Me.Text & " - DELETE"

                cmd_OK.Visible = False


                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

            Case 5
                Me.Text = Me.Text & " - ADD"
                cmd_DEL.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call KEY_COUNT_SEQ()
                Call DATA_SEARCH_VS2()

                Setfocus(txt_CustomerCode)

        End Select

        formA = True

    End Sub
#End Region

#Region "Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        DS1 = READ_PFK3011_LINE(L3011.PRNo, cn)

        If GetDsRc(DS1) = 0 Then
            isudCHK = False
            Exit Function
        End If

        READER_MOVE(Me, DS1)


        txt_CustomerCode.Enabled = False
        txt_cdDepartment.Enabled = False
        txt_cdSeason.Enabled = False
    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        Try
            DS1 = PrcDS("USP_ISUD3011A_SEARCH_VS1", cn, L3011.PRNo)
            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3011A_SEARCH_VS1", "Vs1")
                Vs1.ActiveSheet.RowCount = 10
                Vs1.Enabled = True
                Exit Function
            End If

            Call SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3011A_SEARCH_VS1", "Vs1")


            DATA_SEARCH_VS1 = True
        Catch ex As Exception

        End Try

    End Function
    Private Function DATA_SEARCH_VS2() As Boolean
        DATA_SEARCH_VS2 = False
        Try

            If Chk_AutoLink = True Then
                DS2 = PrcDS("USP_ISUD3011A_SEARCH_VS2_INSERT_AUTO", cn, L_cdSeason, L_CustomerCode, L_Line, L_cdLargeGroupMaterial, L_cdSemiGroupMaterial, L_checkSample)
                SPR_PRO_NEW(vS2, DS2, "USP_ISUD3011A_SEARCH_VS2", "VS2")

                vS2.Enabled = True
                Exit Function
            End If

            DS1 = PrcDS("USP_ISUD3011A_SEARCH_VS2", cn, L3011.PRNo, L3011.PRNoSeq)
            If GetDsRc(DS1) = 0 Then
                DS2 = PrcDS("USP_ISUD3011A_SEARCH_VS2_INSERT_AUTO", cn, L3011.cdSeason, L3011.CustomerCode, L_Line, L_cdLargeGroupMaterial, L_cdSemiGroupMaterial, L_checkSample)
                SPR_PRO_NEW(vS2, DS2, "USP_ISUD3011A_SEARCH_VS2", "VS2")

                vS2.Enabled = True
                Exit Function
            End If

            Call SPR_PRO_NEW(vS2, DS1, "USP_ISUD3011A_SEARCH_VS2", "VS2")
            Dim i As Integer

            For i = 0 To vS2.ActiveSheet.RowCount - 1

                If getData(vS2, getColumIndex(vS2, "CheckOrderMaterial"), i) <> "1" Then
                    Call SPR_LOCK(vS2, i)
                    Call SPR_BACKCOLOR(vS2, Color.Pink, i)
                    Call DisableAllType()
                End If

            Next

            If L3011.PRNoSeq <> "" Then
                For i = 0 To Vs1.ActiveSheet.RowCount - 1
                    If L3011.PRNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_PRNoSeq"), i) Then
                        setData(Vs1, getColumIndex(Vs1, "CheckUse"), i, "1", , True)
                    End If
                Next
            End If

            DATA_SEARCH_VS2 = True
        Catch ex As Exception

        End Try
    End Function
#End Region

#Region "Function"
    Private Sub DATA_MOVE()

    End Sub

    Private Sub DATA_INSERT()

        Try
            Call KEY_COUNT()
            Call KEY_COUNT_SEQ()
            Dim i As Integer

            For i = 0 To vS2.ActiveSheet.RowCount - 1
                If K3011_MOVE(vS2, i, W3011, getData(vS2, getColumIndex(vS2, "AutoKey"), i)) = True Then
                    W3011.PRNo = L3011.PRNo
                    W3011.PRNoSeq = L3011.PRNoSeq

                    If FormatCut(W3011.PRName) = "" Then W3011.PRName = W3011.PRNo & "-" & W3011.PRNoSeq

                    W3011.DateOrderMaterialAccept = FormatCut(txt_DateOrderMaterialAccept.Data)
                    W3011.Remark = txt_Remark.Data
                    W3011.QtyRequest = CDecp(getData(vS2, getColumIndex(vS2, "QtyRequest"), i)) 'W3011.QtyOrder - W3011.QtyBooking
                    If W3011.QtyRequest < 0 Then W3011.QtyRequest = 0

                    W3011.CheckOrderMaterial = "1"
                    W3011.DateDelivery = FormatCut(getData(vS2, getColumIndex(vS2, "DateDelivery"), i))

                    W3011.cdDepartment = txt_cdDepartment.Code
                    W3011.seDepartment = ListCode("Department")

                    W3011.InchargeRequest = txt_InchargeRequest.Code

                    If FormatCut(W3011.DateDelivery) = "" Then W3011.DateDelivery = txt_DateDelivery.Data

                    If REWRITE_PFK3011(W3011) = True Then
                        isudCHK = True : WRITE_CHK = "*"
                    End If
                End If

            Next

            Call MsgBoxP("Insert Succesfully!", vbInformation)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub UPDATE_INFORMATION()

        W3011.cdDepartment = txt_cdDepartment.Code
        W3011.seDepartment = ListCode("Department")

        W3011.PRName = txt_PRName.Data
        W3011.InchargeRequest = txt_InchargeRequest.Code

        Call REWRITE_PFK3011_MASTER(W3011)

        If READ_PFK1312(W3011.OrderNo, W3011.OrderNoSeq) = True Then
            D1312.MaterialStatus = "1"
            Call REWRITE_PFK1312(D1312)
        End If

    End Sub

    Private Sub DATA_ADD()

        Try
            Call KEY_COUNT_SEQ()
            Dim i As Integer

            For i = 0 To vS2.ActiveSheet.RowCount - 1
                If K3011_MOVE(vS2, i, W3011, getData(vS2, getColumIndex(vS2, "AutoKey"), i)) = True Then
                    W3011.PRNo = L3011.PRNo
                    W3011.PRNoSeq = L3011.PRNoSeq

                    If FormatCut(W3011.PRName) = "" Then W3011.PRName = W3011.PRNo & "-" & W3011.PRNoSeq

                    W3011.DateOrderMaterialAccept = FormatCut(txt_DateOrderMaterialAccept.Data)
                    W3011.Remark = txt_Remark.Data
                    W3011.QtyRequest = CDecp(getData(vS2, getColumIndex(vS2, "QtyRequest"), i)) 'W3011.QtyOrder - W3011.QtyBooking
                    If W3011.QtyRequest < 0 Then W3011.QtyRequest = 0

                    W3011.CheckOrderMaterial = "1"
                    W3011.DateDelivery = FormatCut(getData(vS2, getColumIndex(vS2, "DateDelivery"), i))

                    W3011.cdDepartment = txt_cdDepartment.Code
                    W3011.seDepartment = ListCode("Department")

                    W3011.InchargeRequest = txt_InchargeRequest.Code

                    If FormatCut(W3011.DateDelivery) = "" Then W3011.DateDelivery = txt_DateDelivery.Data


                    If REWRITE_PFK3011(W3011) = True Then
                        isudCHK = True : WRITE_CHK = "*"
                    End If
                End If

            Next

            Call MsgBoxP("Insert Succesfully!", vbInformation)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub DATA_UPDATE()
        Try
            Dim i As Integer

            For i = 0 To vS2.ActiveSheet.RowCount - 1
                If K3011_MOVE(vS2, i, W3011, getData(vS2, getColumIndex(vS2, "AutoKey"), i)) = True Then
                    If (W3011.CheckOrderMaterial = "" Or W3011.CheckOrderMaterial = "1") Then
                        If W3011.PRNo = "" Then W3011.PRNo = txt_PRNo.Data
                        If W3011.CheckOrderMaterial = "" Then W3011.CheckOrderMaterial = "1"
                        If W3011.DateOrderMaterialAccept = "" Then W3011.DateOrderMaterialAccept = FormatCut(txt_DateOrderMaterialAccept.Data)

                        If FormatCut(W3011.PRName) = "" Then W3011.PRName = W3011.PRNo & "-" & W3011.PRNoSeq

                        W3011.DateOrderMaterialAccept = FormatCut(txt_DateOrderMaterialAccept.Data)
                        W3011.Remark = txt_Remark.Data
                        W3011.QtyRequest = CDecp(getData(vS2, getColumIndex(vS2, "QtyRequest"), i)) 'W3011.QtyOrder - W3011.QtyBooking
                        If W3011.QtyRequest < 0 Then W3011.QtyRequest = 0

                        W3011.CheckOrderMaterial = "1"
                        W3011.DateDelivery = FormatCut(getData(vS2, getColumIndex(vS2, "DateDelivery"), i))

                        W3011.cdDepartment = txt_cdDepartment.Code
                        W3011.seDepartment = ListCode("Department")

                        W3011.InchargeRequest = txt_InchargeRequest.Code

                        If FormatCut(W3011.DateDelivery) = "" Then W3011.DateDelivery = txt_DateDelivery.Data

                        If REWRITE_PFK3011(W3011) = True Then
                            isudCHK = True : WRITE_CHK = "*"
                        End If
                    End If


                End If

            Next

            Call MsgBoxP("Update Succesfully!", vbInformation)
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Dim i As Integer

        Try
            For i = 0 To vS2.ActiveSheet.RowCount - 1
                If getDataM(vS2, getColumIndex(vS2, "checkUse"), i) = "1" Then
                    If DATA_LINE_DELETE(i) = False Then Exit Sub
                    isudCHK = True
                End If
            Next

            If isudCHK = True Then Call MsgBoxP("Delete Succesfully!", vbInformation)

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

    Private Function DATA_LINE_DELETE(xrow As Integer) As Boolean
        DATA_LINE_DELETE = False

        Try
            If READ_PFK3011(getData(vS2, getColumIndex(vS2, "AutoKey"), xrow)) = True Then

                W3011 = D3011

                If W3011.CheckOrderMaterial <> "1" Then MsgBoxP("Can not delete this ! This is Valided order !") : Exit Function
                If W3011.QtyPurchasing > 0 Then MsgBoxP("Can not Delete because of PO Data") : Exit Function

                W3011.CheckOrderMaterial = "1"
                W3011.PRName = ""
                W3011.PRNo = ""
                W3011.PRNoSeq = ""

                W3011.DateDelivery = ""
                W3011.DateOrderMaterialApproval = ""
                W3011.DateOrderMaterialCancel = ""
                W3011.DateOrderMaterialComplete = ""

                W3011.QtyRequest = 0
                W3011.QtyPurchasing = 0
                W3011.QtyBooking = 0

                If REWRITE_PFK3011(W3011) = True Then
                    isudCHK = True
                    WRITE_CHK = "*"
                End If
            End If
            DATA_LINE_DELETE = True
        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Function

    Private Function CheckSamePO(OrderNo As String) As Boolean
        CheckSamePO = True
        Dim i As Integer
        Try
            For i = 0 To vS2.ActiveSheet.RowCount - 1
                If getData(vS2, getColumIndex(vS2, "OrderNo"), i) = OrderNo Then
                    CheckSamePO = False
                    MsgBoxP("Already Data! No again!") : Exit Function
                End If
            Next

        Catch ex As Exception

        End Try
    End Function
    Private Sub KEY_COUNT()
        Dim Type As String
        Type = "MPO"

        If READ_PFK3011(getData(vS2, getColumIndex(vS2, "AutoKey"), 0)) Then
            If READ_PFK1311(D3011.OrderNo) Then
                If D1311.cdOrderGroup = "001" Then Type = "RDO"
            End If
        End If

        If L_checkSample = "1" Then Type = "RDO"

        If READ_PFK7101(txt_CustomerCode.Code) Then
            If D7101.CustomerNameSimply = "" Then If ISUD7101B.Link_ISUD7101A(3, D7101.CustomerCode, "PFP71010") = False Then isudCHK = False : Exit Sub : Me.Dispose()



            Type = Type + D7101.CustomerNameSimply

        Else
            Exit Sub
        End If

        Try

            SQL = "SELECT MAX(CAST(RIGHT(K3011_PRNo,3) AS DECIMAL)) AS MAX_MCODE FROM PFK3011 "
            SQL = SQL + " WHERE ISNULL(K3011_PRNo,'') <> '' "
            SQL = SQL + " AND LEFT(K3011_PRNo,5) = '" + Type + "' "
            SQL = SQL + " AND SUBSTRING(K3011_PRNo,6,2) = '" + Strings.Mid(Pub.DAT, 3, 2) + "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W3011.PRNo = Type & Strings.Mid(Pub.DAT, 3, 2) & "001"
            Else
                W3011.PRNo = Type & Strings.Mid(Pub.DAT, 3, 2) & Format(CInt(rd!MAX_MCODE + 1), "000")
            End If

            rd.Close()

            L3011.PRNo = W3011.PRNo
            txt_PRNo.Data = L3011.PRNo
            txt_PRName.Data = L3011.PRNo & "-" & L3011.PRNoSeq
        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub KEY_COUNT_SEQ()
        Try

            SQL = "SELECT MAX(CAST(K3011_PRNoSeq AS DECIMAL)) AS MAX_MCODE FROM PFK3011 "
            SQL = SQL + " WHERE K3011_PRNo = '" + L3011.PRNo + "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W3011.PRNoSeq = "001"
            Else
                W3011.PRNoSeq = Format(CInt(rd!MAX_MCODE + 1), "000")
            End If

            rd.Close()

            W3011.PRNo = L3011.PRNo
            L3011.PRNoSeq = W3011.PRNoSeq
            txt_PRNoSeq.Data = L3011.PRNoSeq
            txt_PRName.Data = L3011.PRNo & "-" & L3011.PRNoSeq
        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub
    Private Sub DATA_INIT()
        Try
            txt_PRNo.Enabled = False
            isudCHK = False
            txt_DateOrderMaterialAccept.Data = System_Date_8()
            txt_DateDelivery.Data = System_Date_8()



            txt_InchargeRequest.Data = Pub.NAM
            txt_InchargeRequest.Code = Pub.SAW
          
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()

    End Sub

    Private Function Data_Check() As Boolean
        Data_Check = True

        Try
            'For i = 0 To Vs2.ActiveSheet.RowCount - 1
            '    If getData(Vs2, getColumIndex(Vs2, "FactPRNo"), i) = "" _
            '        And getData(Vs2, getColumIndex(Vs2, "FactPurchasingOrderMaterialSeq"), i) = "" Then
            '        Data_Check = False
            '        MsgBoxP("No Data! Pls Input!") : Exit Function
            '    End If
            'Next

        Catch ex As Exception

        End Try
    End Function

#End Region

#Region "Event"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                If DataCheck(Me, "PFK3011") = False Then Exit Sub
                If Data_Check() = False Then Exit Sub
                Call KEY_COUNT()
                Call DATA_INSERT()
                Call UPDATE_INFORMATION()
                Chk_AutoLink = False
                wJOB = 3
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

            Case 2
                Me.Dispose()

            Case 3
                If DataCheck(Me, "PFK3011") = False Then Exit Sub
                If Data_Check = False Then Exit Sub

                Call DATA_UPDATE()
                Call UPDATE_INFORMATION()
                Chk_AutoLink = False
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
            Case 4
                Call DATA_DELETE()

            Case 5
                If DataCheck(Me, "PFK3011") = False Then Exit Sub
                If Data_Check() = False Then Exit Sub
                Call DATA_ADD()
                Call UPDATE_INFORMATION()
                Chk_AutoLink = False
                wJOB = 3
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

        End Select
    End Sub

    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub

    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs) Handles cmd_DEL.Click
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "cmd_DEL_Click")
            Exit Sub
        End If

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

        Call DATA_DELETE()
        Me.Dispose()
    End Sub

    Private Sub Vs2_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles vS2.ButtonClicked
        Dim xCOL As Integer
        Dim xROW As Integer
        Dim i As Integer
        Dim Value1() As String
        Dim Value2(5) As String
        Dim Type As String = ""

        xROW = e.Row
        xCOL = e.Column

        Select Case xCOL
            Case getColumIndex(Vs2, "cdPRCode")
                'TEST 2017/07/03
                If HLP3011A.Link_HLP3011Material(Type) = True Then
                    hlp0000SeVa = hlp0000SeVa.Replace("|", ",")
                    DS1 = PrcDS("USP_ISUD3011A_SEARCH_VS2_INSERT", cn, hlp0000SeVa)
                    Call READ_SPREAD_N(vS2, DS1, xROW, GetDsRc(DS1), "USP_ISUD3011A_SEARCH_VS2", "VS2")

                    Exit Sub
                End If
              
                Exit Sub

                If HLP3011A.Link_HLP3011Material(Type) = True Then
                    If hlp0000SeVa = "" Then Exit Sub
                    Value1 = hlp0000SeVa.Split("|")

                    For i = 0 To Value1.Length - 1
                        Value2 = Value1(i).Split(",")
                        If READ_PFK3011(Value2(0)) = True Then
                            vS2.ActiveSheet.RowCount += 1

                            If READ_PFK7231(D3011.Materialcode) = True Then
                                setData(sender, getColumIndex(vS2, "MaterialCode"), xROW, D7231.MaterialCode)
                                setData(sender, getColumIndex(vS2, "MaterialName"), xROW, D7231.MaterialName)

                                setData(sender, getColumIndex(vS2, "OrderNo"), xROW, D3011.OrderNo)
                                setData(sender, getColumIndex(vS2, "OrderNoSeq"), xROW, D3011.OrderNoSeq)

                                setData(sender, getColumIndex(vS2, "Autokey"), xROW, D3011.Autokey)

                                setData(sender, getColumIndex(vS2, "seUnitMaterial"), xROW, D3011.seUnitMaterial)
                                setData(sender, getColumIndex(vS2, "cdUnitMaterial"), xROW, D3011.cdUnitMaterial)
                                setData(sender, getColumIndex(vS2, ""), xROW, D3011.Autokey)

                                setData(sender, getColumIndex(vS2, "QtyOrder"), xROW, D3011.QtyOrder)
                                setData(sender, getColumIndex(vS2, "QtyBooking"), xROW, D3011.QtyBooking)
                                setData(sender, getColumIndex(vS2, "QtyRequest"), xROW, D3011.QtyRequest)

                                setData(sender, getColumIndex(vS2, "QtyPurchasing"), xROW, 0)

                                setData(sender, getColumIndex(vS2, "DateDelivery"), xROW, txt_DateDelivery.Data)

                                vS2.ActiveSheet.ActiveColumnIndex += 1 : vS2.ActiveSheet.ActiveRowIndex = xROW
                            End If

                            xROW = xROW + 1
                        End If
                    Next

                End If
                vS2.Focus()

        End Select

        vSChange(e.Row)
    End Sub

    Private Sub Vs2_Change(sender As Object, e As ChangeEventArgs) Handles vS2.Change
        Dim xCOL As Integer
        Dim xROW As Integer

        Try
            xROW = e.Row
            xCOL = e.Column

            vSChange(xROW)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub vSChange(xROW As Integer)
        If wJOB = 2 Then Exit Sub
        Dim QtyOrder As Decimal
        Dim QtyAdjust As Decimal
        Dim QtyBooking As Decimal
        Dim QtyRequest As Decimal

        QtyOrder = CDecp(getData(vS2, getColumIndex(vS2, "QtyOrder"), xROW))
        QtyAdjust = CDecp(getData(vS2, getColumIndex(vS2, "QtyOrder"), xROW))

        If QtyAdjust <> 0 Then QtyOrder = QtyAdjust
        QtyBooking = CDecp(getData(vS2, getColumIndex(vS2, "QtyBooking"), xROW))

        If QtyBooking > QtyOrder Then QtyBooking = QtyOrder

        QtyRequest = QtyOrder - QtyBooking

        setData(vS2, getColumIndex(vS2, "QtyRequest"), xROW, QtyRequest)

    End Sub
    Private Sub Vs2_CellClick1(sender As Object, e As CellClickEventArgs) Handles vS2.CellClick

        If txt_PRName.Data = "" Then Setfocus(txt_PRName) : MsgBoxP("Pls fill the PR Name!") : Exit Sub
        If txt_InchargeRequest.Data = "" Then Setfocus(txt_InchargeRequest) : MsgBoxP("Pls fill the Incharge Name!") : Exit Sub

    End Sub


    Private Sub vS2_KeyDown(sender As Object, e As KeyEventArgs) Handles vS2.KeyDown
        If wJOB = 2 Then Exit Sub
        Dim xCOL As Long
        Dim xROW As Long
        Dim i As Integer
        Dim Value1() As String
        Dim Value2(5) As String
        Dim Type As String = ""

        xCOL = vS2.ActiveSheet.ActiveColumnIndex
        xROW = vS2.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode

            Case Keys.Delete

                Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)

                If Msg_Result <> vbYes Then Exit Sub

                W3011.PRNo = txt_PRNo.Data
                W3011.Autokey = getData(vS2, getColumIndex(vS2, "AutoKey"), xROW)

                If READ_PFK3011(W3011.Autokey) = True Then
                    If D3011.CheckOrderMaterial <> "1" Then MsgBoxP("Check condition at row " & xROW) : Exit Sub
                    If CDblp(D3011.QtyPurchasing) > 0 Then MsgBoxP("Check condition at row " & xROW) : Exit Sub

                    Call DATA_LINE_DELETE(xROW)

                End If

                SPR_DEL(vS2, 0, vS2.ActiveSheet.ActiveRowIndex)
                vS2.Focus()

            Case Keys.Enter
                Select Case xCOL
                    Case getColumIndex(sender, "cdPRCode")
                        If HLP3011A.Link_HLP3011Material(Type) = True Then
                            hlp0000SeVa = hlp0000SeVa.Replace("|", ",")
                            DS1 = PrcDS("USP_ISUD3011A_SEARCH_VS2_INSERT", cn, hlp0000SeVa)
                            Call READ_SPREAD_N(vS2, DS1, xROW, GetDsRc(DS1), "USP_ISUD3011A_SEARCH_VS2", "VS2")

                            Exit Sub
                        End If

                        vS2.Focus()

                End Select
        End Select
        Call vSChange(xROW)
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Dim xCOL As Integer
        Dim xROW As Integer
        Dim Value As String

        xROW = sender.ActiveSheet.ActiveRowIndex
        xCOL = sender.ActiveSheet.ActiveColumnIndex

        If xCOL <> getColumIndex(sender, "CheckUse") Then Exit Sub

        Value = getData(sender, xCOL, xROW)

        setDataChkCol(sender, xCOL, "2")

        If Value <> "1" Then
            setData(sender, xCOL, xROW, "1", , True)

            L3011.PRNoSeq = getData(Vs1, getColumIndex(Vs1, "KEY_PRNoSeq"), xROW)
            Call DATA_SEARCH_VS2()
        Else
            setData(sender, xCOL, xROW, "0", , True)
            L3011.PRNoSeq = ""
            Call DATA_SEARCH_VS2()
        End If

    End Sub
#End Region

  
End Class
