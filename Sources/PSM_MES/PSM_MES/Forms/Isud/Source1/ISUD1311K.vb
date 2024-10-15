Imports System.Net.Mail
Imports System.Text
Imports System.IO.Ports

Public Class ISUD1311K

#Region "Variable"
    'Private wJOB As Integer
    Private W7106 As T7106_AREA

    Private W0102 As New T0102_AREA

    Private W1311 As New T1311_AREA
    Private L1311 As New T1311_AREA

    Private W1312 As New T1312_AREA
    Private L1312 As New T1312_AREA

    Private W1313 As New T1313_AREA
    Private L1313 As New T1313_AREA

    Private W1314 As New T1314_AREA
    Private L1314 As New T1314_AREA

    Private W1315 As New T1315_AREA
    Private L1315 As New T1315_AREA

    Private W1316 As New T1316_AREA
    Private L1316 As New T1316_AREA

    Private W7156 As New T7156_AREA
    Private W7104 As New T7104_AREA

    Private W0111 As T0111_AREA
    Private L0111 As T0111_AREA

    Private WRITE_CHK As String
    Private ImportTax As Decimal
    Private EnvironmentTax As Decimal
    Private VatTax As Decimal
    Private formA As Boolean
    Private CHK(0 To 5) As String

    Private sizeInfo As Boolean = False
    Private specInfo As Boolean = False
    Private schedulaInfo As Boolean = False
    Private remarkInfo As Boolean = False

    Private OrderNoSeq As String = ""

    Private Schedula As String = ""

    Private Link_W1311 As T1311_AREA
    Private Link_W1312 As List(Of T1312_AREA)

    Dim rowList As Integer
    Dim rowChk As Integer
    Dim List1312KW As New List(Of T1312_AREA)

#End Region

#Region "Link"
    Public Function Link_ISUD1311K(job As Integer, OrderNo As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D1311.OrderNo = OrderNo

        wJOB = job : L1311 = D1311

        Link_ISUD1311K = False
        Try

            Select Case job
                Case 1, 11

                Case 5, 6
                    If READ_PFK1312_APPROVAL(OrderNo) = False Then
                        MsgBoxEx("Not Approval Order ! Can not revise ! ")
                        Exit Function
                    End If

                Case Else

                  

            End Select

            If wJOB <> 3 Then
                txt_Clear.Visible = False
                txt_MasterBom.Visible = False
            End If


            formA = False
            Me.ShowDialog()
            Application.DoEvents()
            Cursor = Cursors.Default

            Link_ISUD1311K = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try

    End Function
    Private Check_AutoLink As Boolean = False
    Private str_AutoLink As String
    Public Function Link_ISUD1311A_AUTO(job As Integer, Value As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        Check_AutoLink = True
        str_AutoLink = Value
        wJOB = job : L1311 = D1311

        Link_ISUD1311A_AUTO = False

        Try

            Select Case job
                Case 1, 11
                Case Else

            End Select


            formA = False
            Me.ShowDialog()
            Application.DoEvents()
            Cursor = Cursors.Default

            Link_ISUD1311A_AUTO = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try

    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_KeyDown()

        Call DATA_INIT()
        Call FORM_INIT()

        If GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5)) = False Then
            isudCHK = False
            Me.Dispose()
            formA = True

            Call MsgBoxP("You have no right is this program !")
            Exit Sub
        End If

        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"

                tst_iDelete.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()

                If Check_AutoLink = False Then
                    Call DATA_SEARCH_vS10()

                ElseIf Check_AutoLink = True Then
                    Call DATA_SEARCH_vS10()
                    Call DATA_SEARCH_vS10_AUTO()

                End If

                txt_DateOrder.Data = Pub.DAT

                Setfocus(txt_CustomerCode)

            Case 2
                Me.Text = Me.Text & " - SEARCH"

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If


                Call DATA_SEARCH01()
                Call DATA_SEARCH_vS10()

                tst_iDelete.Visible = False
                tst_iSave.Visible = False

            Case 3
                Me.Text = Me.Text & " - UPDATE"

                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                End If

                txt_OrderNo.Enabled = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_vS10()


                tst_iDelete.Visible = False

            Case 4
                Me.Text = Me.Text & " - DELETE"

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_vS10()

                tst_iDelete.Visible = True
                tst_iSave.Visible = False

            Case 5
                Me.Text = Me.Text & " - REVISE"

                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                End If

                txt_OrderNo.Enabled = False

                txt_cdSite.Enabled = False
                txt_CustPoNo.Enabled = False
                txt_CustomerCode.Enabled = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_vS10()


                tst_iDelete.Visible = False

            Case 6
                Me.Text = Me.Text & " - REVISE ALL"

                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                End If

                txt_OrderNo.Enabled = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_vS10()


                tst_iDelete.Visible = False

        End Select

        formA = True
    End Sub

    Private Sub DATA_INIT()
        Try
            txt_OrderNo.Enabled = False
            txt_QtyTotal.Data = ""
            txt_Qty1.Data = ""
            txt_Qty2.Data = ""
            txt_Qty3.Data = ""
            txt_Qty4.Data = ""
            txt_Qty5.Data = ""
            txt_Qty6.Data = ""
            txt_Qty7.Data = ""
            txt_Qty8.Data = ""
            txt_Qty9.Data = ""
            txt_Qty10.Data = ""

            txt_QtyTotal.Enabled = True
            txt_Qty1.Enabled = True
            txt_Qty2.Enabled = True
            txt_Qty3.Enabled = True
            txt_Qty4.Enabled = True
            txt_Qty5.Enabled = True
            txt_Qty6.Enabled = True
            txt_Qty7.Enabled = True
            txt_Qty8.Enabled = True
            txt_Qty9.Enabled = True
            txt_Qty10.Enabled = True












            Call D1311_CLEAR()
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try
    End Sub

    Private Sub FORM_INIT()
        vS10.InsChk = True
        Me.chk_Attach = False
    End Sub

#End Region

#Region "Search"

    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Try
            DS1 = READ_PFK1311(L1311.OrderNo, cn)

            If GetDsRc(DS1) = 0 Then
                Exit Function
                isudCHK = False
            End If

            READER_MOVE(Me, DS1)

            DATA_SEARCH01 = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH01")
        End Try

    End Function

    Private Function DATA_SEARCH02(SpecNo As String, SpecNoSeq As String) As Boolean

        DATA_SEARCH02 = False
        Try

            DS1 = PrcDS("USP_ISU1311A_SEARCH_HEAD_SPECINFO", cn, SpecNo, SpecNoSeq)

            If GetDsRc(DS1) = 0 Then
                DS2 = READ_PFK0102(SpecNo, SpecNoSeq, cn)

                If GetDsRc(DS2) > 0 Then
                    Call READER_MOVE(Me, DS2)
                End If

                Exit Function
                isudCHK = False
            End If

            STORE_MOVE(Me, DS1)

            DATA_SEARCH02 = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH02")
        End Try

    End Function

    Private Function DATA_SEARCH03(OrderNo As String) As Boolean

        DATA_SEARCH03 = False
        Try

            DS1 = PrcDS("USP_ISU1311A_SEARCH_HEAD_SPECINFO_SUM", cn, OrderNo)

            If GetDsRc(DS1) = 0 Then
                DS2 = READ_PFK0102_OrderNo(OrderNo, cn)

                If GetDsRc(DS2) > 0 Then
                    Call READER_MOVE(Me, DS2)
                End If

                Exit Function
                isudCHK = False
            End If

            STORE_MOVE(Me, DS1)

            DATA_SEARCH03 = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH02")
        End Try

    End Function

    Private Function DATA_SEARCH_vS10() As Boolean
        DATA_SEARCH_vS10 = False
        Try

            DS1 = PrcDS("USP_ISU1311K_SEARCH_VS10", cn, L1311.OrderNo)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS10, DS1, "USP_ISU1311K_SEARCH_VS10", "VS10")
                vS10.ActiveSheet.RowCount = 1
                vS10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS10, DS1, "USP_ISU1311K_SEARCH_VS10", "Vs10")
          

            DATA_SEARCH_vS10 = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH_vS10")
        End Try

    End Function
    Private Function DATA_SEARCH_vS10_AUTO() As Boolean
        DATA_SEARCH_vS10_AUTO = False
        Try

            DS1 = PrcDS("USP_ISU1311A_SEARCH_VS10_AUTO", cn, str_AutoLink)
            'SPR_PRO_NEW(vS10, DS1, "USP_ISU1311A_SEARCH_VS10", "Vs10")
            Call READ_SPREAD_N(vS10, DS1, vS10.ActiveSheet.ActiveRowIndex, GetDsRc(DS1), "USP_ISU1311A_SEARCH_VS10", "VS10")

            Dim ShoesCode As String
            ShoesCode = getData(vS10, getColumIndex(vS10, "ShoesCode"), 0)

            If READ_PFK7106(ShoesCode) Then
                txt_CustomerCode.Code = D7106.Customercode

                If READ_PFK7101(D7106.Customercode) Then

                    txt_CustomerCode.Data = D7101.CustomerName

                 

                End If

            End If

            DATA_SEARCH_vS10_AUTO = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH_vS10")
        End Try

    End Function

    Private Function DATA_SEARCH_CHECK_SPECNO()
        Try
            Dim i As Integer
            Dim SpecNo As String
            Dim SpecNoSeq As String
            Dim CF As String

            For i = 0 To vS10.ActiveSheet.RowCount - 1
                SpecNo = getData(vS10, getColumIndex(vS10, "SpecNo"), i)
                SpecNoSeq = getData(vS10, getColumIndex(vS10, "SpecNoseq"), i)

                If SpecNo = "" Then GoTo next1

                Dim StrMsg = " SELECT TOP 1 K0102_SpecNoSeq AS CF FROM PFK0102"
                StrMsg &= "  WHERE K0102_SpecNo = '" + SpecNo + "'  "
                StrMsg &= "	AND		K0102_SpecNoSeq	>	'" + SpecNoSeq + "'"
                StrMsg &= "		ORDER	BY	K0102_SpecNoSeq DESC"

                cmd = New SqlClient.SqlCommand(StrMsg, cn)
                rd = cmd.ExecuteReader
                rd.Read()

                If rd.HasRows Then
                    CF = rd!CF
                    If READ_PFK7401(Pub.SAW, SpecNo, CF) Then
                        If D7401.CheckConfirm = "1" Then rd.Close() : GoTo next1

                        Dim StrYesNo As String = MsgBox("New SpecSheet has been created! From Specno " & SpecNo & "-" & SpecNoSeq & " to " _
                                                        & SpecNo & "-" & CF & " .Do you accept this change and view it ?", vbYesNo)

                        If StrYesNo <> vbYes Then rd.Close() : GoTo next1

                        D7401.CheckConfirm = "1"
                        D7401.TimeConfirm = System_Date_time()
                        D7401.DateConfirm = Pub.DAT

                        Call REWRITE_PFK7401(D7401)


                    Else
                        Dim StrYesNo As String = MsgBox("New SpecSheet has been created! From Specno " & SpecNo & "-" & SpecNoSeq & " to " _
                                                      & SpecNo & "-" & CF & " .Do you accept this change and view it ?", vbYesNo)

                        If StrYesNo <> vbYes Then rd.Close() : GoTo next1

                        D7401.CheckConfirm = "1"
                        D7401.TimeConfirm = System_Date_time()
                        D7401.DateConfirm = Pub.DAT
                        D7401.IDNO = Pub.SAW
                        D7401.SpecNo = SpecNo
                        D7401.SpecNoSeq = CF

                        Call WRITE_PFK7401(D7401)


                    End If

                End If

                rd.Close()

next1:
            Next

        Catch ex As Exception

        End Try
    End Function


#End Region

#Region "Function"
    Private Sub DATA_MOVE_DEFAULT()
        Try

            W1311.seSeason = ListCode("Season")
            W1311.seStateOfficial = ListCode("StateOfficial")
            W1311.seOrderGroup = ListCode("OrderGroup")
            W1311.seOrderKind = ListCode("OrderKind")
            W1311.seOrderType = ListCode("OrderType")
            W1311.seOrderKind = ListCode("OrderKind")
            W1311.seOrderWork = ListCode("OrderWork")
            W1311.seStateSample = ListCode("StateSample")
            W1311.seDepartment = ListCode("Department")
            W1311.seBrand = ListCode("Brand")
            W1311.seDeliveryTerm = ListCode("DeliveryTerm")
            W1311.sePaymentTerm = ListCode("PaymentTerm")
            W1311.sePaymentCondition = ListCode("PaymentCondition")
            W1311.sePaymentTime = ListCode("PaymentTime")
            W1311.sePaymentDay = ListCode("PaymentDay")
            W1311.seUnitPrice = ListCode("UnitPrice")
            W1311.seShippingTerm = ListCode("ShippingTerm")
            W1311.seMarketType = ListCode("MarketType")

            W1311.seSite = ListCode("Site")
            'PFK1312
            W1312.seSpecStatus = ListCode("SpecStatus")
            W1312.seUnitMaterial = ListCode("UnitMaterial")
            W1312.seUnitPacking = ListCode("UnitPacking")

            'PFK1314
            W1314.seOrderProcess = ListCode("OrderProcess")
            W1314.seProcessState = ListCode("ProcessState")

            'PFK1316
            W1316.seProcessType = ListCode("ProcessType")

        Catch ex As Exception
            Call Error_Message("62", "DATA_MOVE_DEFAULT")
        End Try

    End Sub
    Private Function DATA_MOVE_WRITE01() As Boolean
        DATA_MOVE_WRITE01 = False
        Try

            DATA_MOVE_WRITE01 = True
        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE01")
        End Try
    End Function
    Private Function DATA_MOVE_WRITE02() As Boolean
        DATA_MOVE_WRITE02 = False
        Try
            Dim i As Integer
            Dim j As Integer

            j = 0
            For i = 0 To vS10.ActiveSheet.RowCount - 1
                j = j + 1

                If K1312_MOVE(vS10, i, W1312, txt_OrderNo.Data, getData(vS10, getColumIndex(vS10, "KEY_OrderNoSeq"), i)) = True Then

                    DATA_MOVE_DEFAULT()

                    W1312.DateUpdate = Pub.DAT
                    W1312.InchargeUpdate = Pub.SAW
                    W1312.DateOrder = txt_DateOrder.Data

                    W1312.SizeRange = getData(vS10, getColumIndex(vS10, "SizeRange"), i)
                    Call REWRITE_PFK1312(W1312)

                    isudCHK = True
                Else
                    W1312.OrderNo = L1311.OrderNo

                    Call KEY_COUNT_PFK1312()

                    DATA_MOVE_DEFAULT()

                    W1312.SizeRange = getData(vS10, getColumIndex(vS10, "SizeRange"), i)
                    W1312.OrderDetailStatus = "1"

                    W1312.DateOrder = txt_DateOrder.Data

                    W1312.DateInsert = Pub.DAT
                    W1312.InchargeInsert = Pub.SAW

                    Call WRITE_PFK1312(W1312)

                    isudCHK = True
                End If
skip:
            Next

            DATA_MOVE_WRITE02 = True

        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE02")
        End Try

    End Function

    Private Function DATA_MOVE_WRITE02_AFTER() As Boolean
        DATA_MOVE_WRITE02_AFTER = False
        Try
            Dim i As Integer
            Dim j As Integer

            j = 0
            For i = 0 To vS10.ActiveSheet.RowCount - 1
                j = j + 1

                If K1312_MOVE(vS10, i, W1312, txt_OrderNo.Data, getData(vS10, getColumIndex(vS10, "KEY_OrderNoSeq"), i)) = True Then

                    DATA_MOVE_DEFAULT()

                    W1312.RemarkCustomer = Pub.DAT
                    W1312.InchargeUpdate = Pub.SAW
                    W1312.DateOrder = txt_DateOrder.Data

                    W1312.SizeRange = getData(vS10, getColumIndex(vS10, "SizeRange"), i)
                    Call REWRITE_PFK1312(W1312)

                    isudCHK = True
                Else
                    W1312.OrderNo = L1311.OrderNo

                    Call KEY_COUNT_PFK1312()

                    DATA_MOVE_DEFAULT()

                    W1312.SizeRange = getData(vS10, getColumIndex(vS10, "SizeRange"), i)
                    W1312.OrderDetailStatus = "1"

                    W1312.DateOrder = txt_DateOrder.Data

                    W1312.DateInsert = Pub.DAT
                    W1312.InchargeInsert = Pub.SAW

                    Call WRITE_PFK1312(W1312)

                    isudCHK = True
                End If
skip:
            Next

            DATA_MOVE_WRITE02_AFTER = True

        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE02")
        End Try

    End Function
    Private Function DATA_MOVE_WRITE02_ROW(i As Integer) As Boolean
        DATA_MOVE_WRITE02_ROW = False
        Try

            Dim j As Integer

            j = 0

            If Trim(getData(vS10, getColumIndex(vS10, "MaterialCode"), i)) = "" Then Exit Function

            j = j + 1

            If K1312_MOVE(vS10, i, W1312, txt_OrderNo.Data, getData(vS10, getColumIndex(vS10, "KEY_OrderNoSeq"), i)) = True Then

                W1312.PKO = getData(vS10, getColumIndex(vS10, "PKO"), i)
                W1312.cdSpecStatus = getData(vS10, getColumIndex(vS10, "cdSpecStatus"), i)

                W1312.SizeRange = getData(vS10, getColumIndex(vS10, "SizeRange"), i)
                W1312.SpeciticSize = getData(vS10, getColumIndex(vS10, "SpeciticSize"), i)

                W1312.cdUnitMaterial = getData(vS10, getColumIndex(vS10, "cdUnitMaterial"), i)
                W1312.cdUnitPacking = getData(vS10, getColumIndex(vS10, "cdUnitPacking"), i)

                W1312.cdUnitPacking = getData(vS10, getColumIndex(vS10, "SpecNo"), i)
                W1312.cdUnitPacking = getData(vS10, getColumIndex(vS10, "SpecNoSeq"), i)

                DATA_MOVE_DEFAULT()
                W1312.DateOrder = txt_DateOrder.Data

                Call REWRITE_PFK1312(W1312)

                isudCHK = True
            Else
                W1312.OrderNo = L1311.OrderNo

                Call KEY_COUNT_PFK1312()

                W1312.PKO = getData(vS10, getColumIndex(vS10, "PKO"), i)
                W1312.cdSpecStatus = getData(vS10, getColumIndex(vS10, "cdSpecStatus"), i)

                W1312.SizeRange = getData(vS10, getColumIndex(vS10, "SizeRange"), i)
                W1312.SpeciticSize = getData(vS10, getColumIndex(vS10, "SpeciticSize"), i)
                W1312.cdUnitMaterial = getData(vS10, getColumIndex(vS10, "cdUnitMaterial"), i)
                W1312.cdUnitPacking = getData(vS10, getColumIndex(vS10, "cdUnitPacking"), i)

                W1312.SpecNo = getData(vS10, getColumIndex(vS10, "SpecNo"), i)
                W1312.SpecNoSeq = getData(vS10, getColumIndex(vS10, "SpecNoSeq"), i)

                W1312.DateOrder = txt_DateOrder.Data


                DATA_MOVE_DEFAULT()
                W1312.OrderDetailStatus = "1"

                Call WRITE_PFK1312(W1312)

                isudCHK = True
            End If

            DATA_MOVE_WRITE02_ROW = True

        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE02_ROW")
        End Try

    End Function

    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim i As Integer

        Try
            For i = 0 To vS10.ActiveSheet.RowCount - 1
                If getData(vS10, getColumIndex(vS10, "ShoesCode"), i).ToString.Trim = "" Then MsgBoxP("ITEM CODE at Row " & (i + 1)) : Exit Function


                If CDecp(getData(vS10, getColumIndex(vS10, "QtyOrder"), i)) = 0 Then MsgBoxP("Zero qty at Row " & (i + 1)) : Exit Function

            Next

            Data_Check = True
        Catch ex As Exception

        End Try
    End Function
    Private Function Data_Check_UPDATE() As Boolean
        Data_Check_UPDATE = False
        Dim i As Integer

        Try

            Data_Check_UPDATE = True
        Catch ex As Exception

        End Try
    End Function
    Private Sub DATA_INSERT()
        Try


        Catch ex As Exception
            MsgBoxP("DATA_INSERT")
        End Try

    End Sub
    Private Sub DATA_UPDATE()
        Try
            Call DATA_MOVE_WRITE02_AFTER()

           

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_UPDATE_AFTER()
       
    End Sub
    Private Sub DATA_DELETE()
      
    End Sub
    Private Function DELETE_T1312() As Boolean
      
    End Function
    Private Function DELETE_T1313() As Boolean
        DELETE_T1313 = False
        Dim DSNEW As New DataSet
        Try
            DSNEW = READ_PFK1313_ORDERNO(L1311.OrderNo, cn)
            For Each Row As DataRow In DSNEW.Tables(0).Rows
                If READ_PFK1313(Row!K1313_OrderNo, Row!K1313_OrderNoSeq) = True Then
                    W1313 = D1313
                    DELETE_PFK1313(W1313)
                End If
            Next
            If GetDsRc(READ_PFK1313_ORDERNO(L1311.OrderNo, cn)) = 0 Then DELETE_T1313 = True
        Catch ex As Exception

        End Try
    End Function
    Private Function DELETE_T1314() As Boolean
        DELETE_T1314 = False
        Dim DSNEW As New DataSet
        Try
            DSNEW = READ_PFK1314_ORDERNO(L1311.OrderNo, cn)
            For Each Row As DataRow In DSNEW.Tables(0).Rows
                If READ_PFK1314(Row!K1314_OrderNo, Row!K1314_OrderNoSeq, Row!K1314_ProcessOrder) = True Then
                    W1314 = D1314
                    DELETE_PFK1314(W1314)
                End If
            Next
            If GetDsRc(READ_PFK1314_ORDERNO(L1311.OrderNo, cn)) = 0 Then DELETE_T1314 = True
        Catch ex As Exception

        End Try
    End Function
    Private Function DELETE_T1315() As Boolean
        DELETE_T1315 = False
        Dim DSNEW As New DataSet
        Try
            DSNEW = READ_PFK1315_ORDERNO(L1311.OrderNo, cn)
            For Each Row As DataRow In DSNEW.Tables(0).Rows
                If READ_PFK1315(Row!K1315_OrderNo, Row!K1315_OrderNoSeq) = True Then
                    W1315 = D1315
                    DELETE_PFK1315(W1315)
                End If
            Next
            If GetDsRc(READ_PFK1315_ORDERNO(L1311.OrderNo, cn)) = 0 Then DELETE_T1315 = True
        Catch ex As Exception

        End Try
    End Function
    Private Function DELETE_T1316() As Boolean
        DELETE_T1316 = False
        Dim DSNEW As New DataSet
        Try
            DSNEW = READ_PFK1316_ORDERNO(L1316.OrderNo, cn)
            For Each Row As DataRow In DSNEW.Tables(0).Rows
                If READ_PFK1316(Row!K1316_ScheduleID) = True Then
                    W1316 = D1316
                    DELETE_PFK1316(W1316)
                End If
            Next
            If GetDsRc(READ_PFK1316_ORDERNO(L1311.OrderNo, cn)) = 0 Then DELETE_T1316 = True
        Catch ex As Exception

        End Try
    End Function
    Private Sub KEY_COUNT_PFK1312()
        Try
            SQL = "SELECT MAX(CAST(K1312_OrderNoSeq AS DECIMAL)) AS MAX_MCODE FROM PFK1312 "
            SQL = SQL & " WHERE K1312_OrderNo = '" & txt_OrderNo.Data & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W1312.OrderNoSeq = "001"
            Else
                W1312.OrderNoSeq = CIntp(rd!MAX_MCODE + 1).ToString("000")
            End If

            rd.Close()

            L1312.OrderNoSeq = W1312.OrderNoSeq

            ' -------------------------------------------------------------------------------

            'Dim lENsLNO As String

            'Call READ_PFK7101(txt_CustomerCode.Code)
            'Call READ_PFK7171(ListCode("StateOfficial"), txt_cdStateOfficial.Code)

            'lENsLNO = D7101.CustomerNameSimply.Length

            'SQL = "SELECT MAX( CAST (RIGHT([K1312_SLNo], LEN([K1312_SLNo]) - " & lENsLNO & " - LEN( ISNULL(K7171_NameSimply,'')) ) AS INT) ) AS MAX_MCODE "
            'SQL = SQL & "  FROM  [PFK1312] "
            'SQL = SQL & "  INNER JOIN PFK1311 ON K1312_OrderNo = K1311_OrderNo "
            'SQL = SQL & "  INNER JOIN PFK7101 ON	K1311_CustomerCode = K7101_CustomerCode "
            'SQL = SQL & "  INNER JOIN PFK7171 ON  K7171_BasicCode = K1311_cdStateOfficial AND K7171_BasicSel  = K1311_seStateOfficial "
            'SQL = SQL & " WHERE K1311_CustomerCode = '" & txt_CustomerCode.Code & "' "
            'SQL = SQL & "  AND ISNULL(K7101_CustomerNameSimply,'') = LEFT([K1312_SLNo]," & lENsLNO & " )  "
            'SQL = SQL & "  AND SUBSTRING([K1312_SLNo]," & lENsLNO + 1 & " ,LEN( ISNULL(K7171_NameSimply,'')) ) = ISNULL(K7171_NameSimply,'') "
            'SQL = SQL & "  AND K1311_cdSeason           = '" & txt_cdSeason.Code & "' "
            'SQL = SQL & "  AND K1311_cdStateOfficial    = '" & txt_cdStateOfficial.Code & "' "

            'cmd = New SqlClient.SqlCommand(SQL, cn)
            'rd = cmd.ExecuteReader
            'rd.Read()

            'If IsDBNull(rd!MAX_MCODE) Then
            '    W1312.SLNoSys = "0001"
            'Else
            '    W1312.SLNoSys = CIntp(rd!MAX_MCODE + 1).ToString("0000")
            'End If



            'W1312.SLNoSys = D7101.CustomerNameSimply & D7171.NameSimply & W1312.SLNoSys
            'W1312.SLNoSys = Trim(W1312.SLNoSys)

            'L1312.SLNoSys = W1312.SLNoSys


            'W1312.SLNo = W1312.SLNoSys
            'L1312.SLNo = W1312.SLNoSys

            rd.Close()

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT_PFK1312")
        End Try
    End Sub
    Private Sub KEY_COUNT_PFK1316()
        Try
            SQL = "SELECT MAX(CAST(K1316_ScheduleID AS DECIMAL)) AS MAX_MCODE FROM PFK1316 "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W1316.ScheduleID = "000001"
            Else
                W1316.ScheduleID = FormatP(CIntp(rd!MAX_MCODE + 1), "000000")
            End If

            rd.Close()

            L1316.ScheduleID = W1316.ScheduleID

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT_PFK1316")
        End Try
    End Sub
    Private Sub KEY_COUNT()

        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 4)

        Try
            SQL = "SELECT MAX(CAST(SUBSTRING(K1311_OrderNo,7,3) AS DECIMAL)) AS MAX_MCODE FROM PFK1311 "
            SQL = SQL & " WHERE SUBSTRING(K1311_OrderNo,3,4) = '" & YRNO.ToString & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W1311.OrderNo = "SO" & YRNO & "001"
            Else
                W1311.OrderNo = "SO" & YRNO & FormatP(CInt(rd!MAX_MCODE + 1), "000")
            End If

            rd.Close()

            txt_OrderNo.Data = W1311.OrderNo
            L1311.OrderNo = W1311.OrderNo

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub
    Private Sub KEY_COUNT_PFK1316(OrderNo As String, OrderNoSeq As String)
        Try
            SQL = "SELECT MAX(CAST(K1316_Seq AS DECIMAL)) AS MAX_MCODE FROM PFK1316 "
            SQL = SQL & " WHERE K1316_OrderNo = '" & OrderNo & "' "
            SQL = SQL & " AND K1316_OrderNoSeq = '" & OrderNoSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W1316.Seq = 1
            Else
                W1316.Seq = CIntp(rd!MAX_MCODE + 1)
            End If

            rd.Close()

            L1316.Seq = W1316.Seq

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT_PFK1316")
        End Try
    End Sub
    Private Function GetOpenFileDialog() As OpenFileDialog

        Dim openFileDialog As New OpenFileDialog

        openFileDialog.CheckFileExists = True
        openFileDialog.Multiselect = False
        openFileDialog.AddExtension = True
        openFileDialog.ValidateNames = True
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        Return openFileDialog


    End Function
    Private Sub KEY_COUNT_K7106()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader


        SQL = "SELECT MAX(CAST(K7106_ShoesCode AS DECIMAL)) AS MAX_CODE FROM PFK7106 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            W7106.ShoesCode = "000001"
        Else
            W7106.ShoesCode = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If

    End Sub
    Private Function CheckListContaint(ListSizeRangeString As String, ListSizeL As String)
        CheckListContaint = True
        Dim ListSizeLArray() As String
        Dim ListSizeLArray_Origin() As String

        ListSizeLArray = ListSizeL.Split(",")
        ListSizeLArray_Origin = ListSizeRangeString.Split(",")



        Try
            Dim i As Integer

            For i = 0 To ListSizeLArray.Count - 1
                If ListSizeLArray_Origin.Contains(ListSizeLArray(i)) = False And ListSizeLArray(i) <> "" Then
                    CheckListContaint = False

                End If
            Next

        Catch ex As Exception
            CheckListContaint = True
        End Try

    End Function

#End Region

#Region "Event"

    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Try
           
        Catch ex As Exception
            MsgBoxP("tst_iSave_Click")
        End Try

    End Sub
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles tst_iClose.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub


#End Region

#Region "Search Line"

    Private Function DATA_SEARCH_VS10_LINE(OrderNo As String, OrderNoSeq As String) As Boolean
        Dim DSNEW As New DataSet

        DATA_SEARCH_VS10_LINE = False

        Try
            DSNEW = PrcDS("USP_ISU1311A_SEARCH_VS10_LINE", cn, OrderNo, OrderNoSeq)

            If GetDsRc(DSNEW) = 0 Then
                Exit Function
            End If
            READ_SPREAD(vS10, DSNEW, "USP_ISU1311A_SEARCH_VS10", "vS10", vS10.ActiveSheet.ActiveRowIndex)

            DATA_SEARCH_VS10_LINE = True
        Catch ex As Exception
            Call MsgBoxP("DATA_SEARCH_VS10_LINE")
        End Try
    End Function




#End Region

#Region "Keydown"

    Private Function CheckAprroval(OrderNo As String, OrderNoSeq As String) As Boolean
        CheckAprroval = False
        Try
            If READ_PFK1312(OrderNo, OrderNoSeq) = True Then
                W1312 = D1312
                If W1312.OrderDetailStatus = "1" Then CheckAprroval = True Else CheckAprroval = False
            End If
        Catch ex As Exception
            MsgBoxP("CheckAprroval")
        End Try
    End Function



#End Region

#Region "Sheet Change"



    Private Function CheckExist(OrderNo As String, OrderNoSeq As String) As Boolean
        CheckExist = False

        Dim RC As Integer
        Try
            rd = PrcDR("USP_ISUD1311A_SEARCH_VS00_CHECKEXIST", cn, OrderNo, OrderNoSeq)

            If rd.HasRows = True Then
                rd.Read()
                RC = rd!RC
                If RC > 0 Then MsgBoxP("Next Data Already!") : rd.Close() : CheckExist = True : Exit Function
            End If

            rd.Close()
        Catch ex As Exception

        Finally

            If rd IsNot Nothing Then
                If rd.IsClosed = False Then
                    rd.Close()
                End If
            End If
        End Try

    End Function


    Private Sub vS10_CellClick(sender As Object, e As CellClickEventArgs) Handles vS10.CellClick
        Dim i, j As Integer
        txt_ShoesCode.Data = ""
        txt_Qty1.Data = ""
        txt_Qty2.Data = ""
        txt_Qty3.Data = ""
        txt_Qty4.Data = ""
        txt_Qty5.Data = ""
        txt_Qty6.Data = ""
        txt_Qty7.Data = ""
        txt_Qty8.Data = ""
        txt_Qty9.Data = ""
        txt_Qty10.Data = ""


        txt_ShoesCode.Data = FormatCut(getData(vS10, getColumIndex(vS10, "PINO"), e.Row))

        If txt_ShoesCode.Data = "" Then Exit Sub

        Try
            For i = 0 To vS10.ActiveSheet.RowCount - 1
                If getDataM(vS10, getColumIndex(vS10, "PINO"), i) = txt_ShoesCode.Data Then
                    j = j + 1

                    If j = 1 Then txt_Qty1.Data = getData(vS10, getColumIndex(vS10, "QtyPcsPoly"), i)
                    If j = 2 Then txt_Qty2.Data = getData(vS10, getColumIndex(vS10, "QtyPcsPoly"), i)
                    If j = 3 Then txt_Qty3.Data = getData(vS10, getColumIndex(vS10, "QtyPcsPoly"), i)
                    If j = 4 Then txt_Qty4.Data = getData(vS10, getColumIndex(vS10, "QtyPcsPoly"), i)
                    If j = 5 Then txt_Qty5.Data = getData(vS10, getColumIndex(vS10, "QtyPcsPoly"), i)
                    If j = 6 Then txt_Qty6.Data = getData(vS10, getColumIndex(vS10, "QtyPcsPoly"), i)
                    If j = 7 Then txt_Qty7.Data = getData(vS10, getColumIndex(vS10, "QtyPcsPoly"), i)
                    If j = 8 Then txt_Qty8.Data = getData(vS10, getColumIndex(vS10, "QtyPcsPoly"), i)
                    If j = 9 Then txt_Qty9.Data = getData(vS10, getColumIndex(vS10, "QtyPcsPoly"), i)
                    If j = 10 Then txt_Qty10.Data = getData(vS10, getColumIndex(vS10, "QtyPcsPoly"), i)

                End If

            Next

            txt_ShoesCode.Data = ""
        Catch ex As Exception

        End Try

    End Sub


#End Region

    Private Sub txt_MasterBom_btnTitleClick(sender As Object, e As EventArgs) Handles txt_MasterBom.btnTitleClick
        Try
            Dim i As Integer
            Dim j As Integer
            Dim ShoesCode As String

            j = 0
            For i = 0 To vS10.ActiveSheet.RowCount - 1
                If getDataM(vS10, getColumIndex(vS10, "dchk"), i) = "1" Then


                    If FormatCut(getDataM(vS10, getColumIndex(vS10, "PINo"), i)) <> "" Then
                        Msg_Result = MsgBox("Packing already ! Do you want to revise ?", vbYesNo)

                        If Msg_Result = MsgBoxResult.No Then Exit Sub
                        GoTo NEXT1
                    End If

                    If getDataM(vS10, getColumIndex(vS10, "dchk"), i) = "1" Then
                        j = j + 1

                        If j = 1 Then If CDecp(txt_Qty1.Data) = 0 Then MsgBoxEx("Wrong format 1!") : Exit Sub
                        If j = 2 Then If CDecp(txt_Qty2.Data) = 0 Then MsgBoxEx("Wrong format 2!") : Exit Sub
                        If j = 3 Then If CDecp(txt_Qty3.Data) = 0 Then MsgBoxEx("Wrong format 3!") : Exit Sub
                        If j = 4 Then If CDecp(txt_Qty4.Data) = 0 Then MsgBoxEx("Wrong format 4!") : Exit Sub
                        If j = 5 Then If CDecp(txt_Qty5.Data) = 0 Then MsgBoxEx("Wrong format 5!") : Exit Sub
                        If j = 6 Then If CDecp(txt_Qty6.Data) = 0 Then MsgBoxEx("Wrong format 6!") : Exit Sub
                        If j = 7 Then If CDecp(txt_Qty7.Data) = 0 Then MsgBoxEx("Wrong format 7!") : Exit Sub
                        If j = 8 Then If CDecp(txt_Qty8.Data) = 0 Then MsgBoxEx("Wrong format 8!") : Exit Sub
                        If j = 9 Then If CDecp(txt_Qty9.Data) = 0 Then MsgBoxEx("Wrong format 9!") : Exit Sub
                        If j = 10 Then If CDecp(txt_Qty10.Data) = 0 Then MsgBoxEx("Wrong format 10!") : Exit Sub

                    End If
                End If

            Next

NEXT1:
            If j > 10 Then MsgBoxP("Over 10 rows ! Quá 10 dòng !") : Exit Sub
            j = 0

            For i = 0 To vS10.ActiveSheet.RowCount - 1
                If getDataM(vS10, getColumIndex(vS10, "dchk"), i) = "1" Then
                    j = j + 1
                    If ShoesCode = "" Then ShoesCode = txt_OrderNo.Data & getData(vS10, getColumIndex(vS10, "KEY_OrderNoSeq"), i)

                    If READ_PFK1312(txt_OrderNo.Data, getData(vS10, getColumIndex(vS10, "KEY_OrderNoSeq"), i)) = True Then
                        W1312 = D1312
                        W1312.PINo = ShoesCode

                        If j = 1 Then W1312.QtyPcsPoly = CDecp(txt_Qty1.Data)
                        If j = 2 Then W1312.QtyPcsPoly = CDecp(txt_Qty2.Data)
                        If j = 3 Then W1312.QtyPcsPoly = CDecp(txt_Qty3.Data)
                        If j = 4 Then W1312.QtyPcsPoly = CDecp(txt_Qty4.Data)
                        If j = 5 Then W1312.QtyPcsPoly = CDecp(txt_Qty5.Data)
                        If j = 6 Then W1312.QtyPcsPoly = CDecp(txt_Qty6.Data)
                        If j = 7 Then W1312.QtyPcsPoly = CDecp(txt_Qty7.Data)
                        If j = 8 Then W1312.QtyPcsPoly = CDecp(txt_Qty8.Data)
                        If j = 9 Then W1312.QtyPcsPoly = CDecp(txt_Qty9.Data)
                        If j = 10 Then W1312.QtyPcsPoly = CDecp(txt_Qty10.Data)


                        If PrcExe("USP_PFK1312_UPDATE_PACKING_INSTRUCTION", cn, W1312.OrderNo, W1312.OrderNoSeq, W1312.PINo, W1312.QtyPcsPoly) Then
                            setData(vS10, getColumIndex(vS10, "PINO"), i, ShoesCode)
                            setData(vS10, getColumIndex(vS10, "QtyPcsPoly"), i, W1312.QtyPcsPoly)
                            setData(vS10, getColumIndex(vS10, "dchk"), i, "2", , True)
                        End If

                        isudCHK = True

                    End If
                End If

skip:
            Next

            Call DATA_SEARCH_vS10()

        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE02")
        End Try

    End Sub
    Private Sub txt_Clear_btnTitleClick(sender As Object, e As EventArgs) Handles txt_Clear.btnTitleClick
        Try
            Dim i As Integer
            Dim j As Integer
            Dim ShoesCode As String

            j = 0
            For i = 0 To vS10.ActiveSheet.RowCount - 1
                If getDataM(vS10, getColumIndex(vS10, "dchk"), i) = "1" Then


                    If FormatCut(getDataM(vS10, getColumIndex(vS10, "PINo"), i)) <> "" Then
                        Msg_Result = MsgBox("Packing already ! Do you want to revise ?", vbYesNo)

                        If Msg_Result = MsgBoxResult.No Then Exit Sub
                        GoTo NEXT1

                    End If


                End If

            Next
NEXT1:


            For i = 0 To vS10.ActiveSheet.RowCount - 1
                If getDataM(vS10, getColumIndex(vS10, "dchk"), i) = "1" Then
                    j = j + 1
                    If READ_PFK1312(txt_OrderNo.Data, getData(vS10, getColumIndex(vS10, "KEY_OrderNoSeq"), i)) = True Then
                        W1312 = D1312
                        W1312.PINo = ""

                        W1312.QtyPcsPoly = 0

                        If PrcExe("USP_PFK1312_UPDATE_PACKING_INSTRUCTION", cn, W1312.OrderNo, W1312.OrderNoSeq, W1312.PINo, W1312.QtyPcsPoly) Then
                            setData(vS10, getColumIndex(vS10, "PINO"), i, "")
                            setData(vS10, getColumIndex(vS10, "QtyPcsPoly"), i, 0)
                            setData(vS10, getColumIndex(vS10, "dchk"), i, "2", , True)
                        End If

                        isudCHK = True

                    End If
                End If

skip:
            Next

            Call DATA_SEARCH_vS10()
        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE02")
        End Try

    End Sub
End Class