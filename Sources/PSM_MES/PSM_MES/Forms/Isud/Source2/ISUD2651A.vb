Imports System.Net.Mail
Imports System.Text
Imports System.IO.Ports

Public Class ISUD2651A

#Region "Variable"
    Private wJOB As Integer

    Private W0102 As New T0102_AREA

    Private W2651 As New T2651_AREA
    Private L2651 As New T2651_AREA

    Private W2652 As New T2652_AREA
    Private L2652 As New T2652_AREA

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

    Private ProductInboundSeq As String = ""

    Private Schedula As String = ""
    Private CheckValue As Boolean = False
    Private CheckValue_String As String

#End Region

#Region "Link"
    Public Function Link_ISUD2651A(job As Integer, ProductInboundNo As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D2651.ProductInboundNo = ProductInboundNo

        wJOB = job : L2651 = D2651

        Link_ISUD2651A = False
        Try

            Select Case job
                Case 1
                Case Else

            End Select


            formA = False
            Me.ShowDialog()
            Application.DoEvents()
            Cursor = Cursors.Default

            Link_ISUD2651A = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try

    End Function

    Public Function Link_ISUD2651A_AUTO(job As Integer, FactOrderNo As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        D2651.FactOrderNo = FactOrderNo

        If READ_PFK3451(FactOrderNo) Then D2651.CheckInBoundMaterial = D2651.CheckInBoundMaterial : cmb_CheckInBoundMaterial.InSelected = CIntp_S(D2651.CheckInBoundMaterial) - 1 : cmb_CheckInBoundMaterial.Enabled = False

        wJOB = job : L2651 = D2651

        Link_ISUD2651A_AUTO = False
        Try

            Select Case job
                Case 1
                Case 5

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD2651A_AUTO = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try

    End Function


    Public Function Link_ISUD2651A_AUTO_CHOOSE(job As Integer, Value As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        CheckValue = True
        CheckValue_String = Value
        wJOB = job : L2651 = D2651

        Link_ISUD2651A_AUTO_CHOOSE = False
        Try

            Select Case job
                Case 1
                Case 5

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD2651A_AUTO_CHOOSE = isudCHK


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
                Call DATA_SEARCH01()
                Call DATA_SEARCH_vS10()
                Call DATA_SEARCH_vS20()
                Setfocus(txt_cdFactory)

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
                Call DATA_SEARCH_vS10()
                Call DATA_SEARCH_vS20()

            Case 3
                Me.Text = Me.Text & " - UPDATE"
                txt_ProductInboundNo.Enabled = False

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
                        Call MsgBoxP("Only Search !") : cmd_OK.Visible = False
                    End If
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_vS10()
                Call DATA_SEARCH_vS20()

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
                Call DATA_SEARCH_vS10()
                Call DATA_SEARCH_vS20()

            Case 11
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
                Call DATA_SEARCH01()
                Call DATA_SEARCH_vS10()
                Call DATA_SEARCH_vS20()
                Setfocus(txt_cdFactory)
                wJOB = 1

        End Select

        formA = True
    End Sub

    Private Sub DATA_INIT()
        Try
            txt_ProductInboundNo.Enabled = False
            txt_DateExchange.Data = Pub.DAT

            txt_DateInbound.Data = Pub.DAT
            txt_DatePosted.Data = Pub.DAT

            Call D2651_CLEAR()
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try
    End Sub

    Private Sub FORM_INIT()
    End Sub

#End Region

#Region "Search"
    Private Sub CheckInBoundMaterial(Process As String)
        Select Case Process
            Case "1" : rad_CheckInBoundMaterial1.Checked = True
            Case "2" : rad_CheckInBoundMaterial2.Checked = True
            Case Else : rad_CheckInBoundMaterial1.Checked = True
        End Select
    End Sub
    Private Sub CheckInBoundMaterial()
        If rad_CheckInBoundMaterial1.Checked = True Then W2651.CheckInBoundMaterial = "1"
        If rad_CheckInBoundMaterial2.Checked = True Then W2651.CheckInBoundMaterial = "2"

    End Sub
    Private Sub CheckMarketType(Market As String)
        Select Case Market
            Case "1" : rad_CheckMarketType1.Checked = True
            Case "2" : rad_CheckMarketType2.Checked = True
            Case Else : rad_CheckMarketType1.Checked = True
        End Select
    End Sub

    Private Sub CheckMarketType()
        If rad_CheckMarketType1.Checked = True Then W2651.CheckMarketType = "1"
        If rad_CheckMarketType2.Checked = True Then W2651.CheckMarketType = "2"
    End Sub

    Private Sub CheckMaterialType(Market As String)
        Select Case Market
            Case "1" : rad_CheckMaterialType1.Checked = True
            Case "2" : rad_CheckMaterialType2.Checked = True
            Case Else : rad_CheckMaterialType1.Checked = True
        End Select
    End Sub

    Private Sub CheckMaterialType()
        If rad_CheckMaterialType1.Checked = True Then W2651.CheckMaterialType = "1"
        If rad_CheckMaterialType2.Checked = True Then W2651.CheckMaterialType = "2"
    End Sub


    Private Function DATA_SEARCH03(ProductInboundNo As String) As Boolean

        DATA_SEARCH03 = False

    End Function

    Private Function DATA_SEARCH01() As Boolean

        DATA_SEARCH01 = False

        DS1 = PrcDS("USP_ISUD2651A_SEARCH_HEAD", cn, L2651.ProductInboundNo)


        If GetDsRc(DS1) = 0 Then
            DS2 = READ_PFK3451(L2651.FactOrderNo, cn)

            If GetDsRc(DS2) > 0 Then
                Call READER_MOVE(Me, DS2)
                Call CheckInBoundMaterial(GetDsData(DS2, 0, "CheckInPurchasingOrder"))
                Call CheckMarketType(GetDsData(DS2, 0, "CheckMarketType"))
                Call CheckMaterialType(GetDsData(DS2, 0, "CheckMaterialType"))
            End If

            Exit Function
            isudCHK = False
        End If

        STORE_MOVE(Me, DS1)

        Call CheckInBoundMaterial(GetDsData(DS1, 0, "CheckInBoundMaterial"))
        Call CheckMarketType(GetDsData(DS1, 0, "CheckMarketType"))
        Call CheckMaterialType(GetDsData(DS1, 0, "CheckMaterialType"))

        If READ_PFK7101(txt_CustomerCode.Code) = True Then
            txt_CustomerCode.Data = D7101.CustomerName
        End If

        DATA_SEARCH01 = True

    End Function

    Private Function DATA_SEARCH_vS10() As Boolean
        DATA_SEARCH_vS10 = False
        Try

            DS1 = PrcDS("USP_ISUD2651A_SEARCH_VS10", cn, L2651.ProductInboundNo)

            If GetDsRc(DS1) = 0 Then
                If CheckValue = False Then
                    DS2 = PrcDS("USP_ISUD2651A_SEARCH_VS10_INSERT", cn, L2651.FactOrderNo)
                Else
                    DS2 = PrcDS("USP_ISUD2651A_SEARCH_VS10_INSERT_VALUE", cn, CheckValue_String)

                    If GetDsRc(DS2) > 0 Then
                        L2651.FactOrderNo = GetDsData(DS2, 0, "FactOrderNo")

                        DS3 = READ_PFK3451(L2651.FactOrderNo, cn)

                        If GetDsRc(DS3) > 0 Then
                            Call READER_MOVE(Me, DS3)
                            Call CheckInBoundMaterial(GetDsData(DS3, 0, "CheckInPurchasingOrder"))
                            Call CheckMarketType(GetDsData(DS3, 0, "CheckMarketType"))
                            Call CheckMaterialType(GetDsData(DS3, 0, "CheckMaterialType"))
                        End If

                    End If
                End If


                SPR_SET(vS10, , , , OperationMode.Normal)
                SPR_PRO(vS10, DS2, "USP_ISUD2651A_SEARCH_VS10", "vS10")
                SPR_INSERT(vS10)

                vS10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS10, DS1, "USP_ISUD2651A_SEARCH_VS10", "Vs10")
            Call DATA_SEARCH_CHECK_SPECNO()

            DATA_SEARCH_vS10 = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH_vS10")
        End Try

    End Function

    Private Function DATA_SEARCH_vS20() As Boolean
        DATA_SEARCH_vS20 = False
        Dim DSNEW As New DataSet

        Try
            DATA_SEARCH_vS20 = False
            Try

                DS1 = PrcDS("USP_ISUD2651A_SEARCH_vS20", cn, L2651.ProductInboundNo)

                If GetDsRc(DS1) = 0 Then

                    If CheckValue = False Then
                        DS2 = PrcDS("USP_ISUD2651A_SEARCH_VS20_INSERT", cn, L2651.FactOrderNo)
                        SPR_SET(vS20, , , , OperationMode.Normal)
                        SPR_PRO(vS20, DS2, "USP_ISUD2651A_SEARCH_vS20", "VS20")
                        SPR_INSERT(vS20)
                        Call VsSizeRange(vS20, "USP_ISUD2651A_SEARCH_VS20_HEAD_INSERT", L2651.FactOrderNo)
                    Else
                        DS2 = PrcDS("USP_ISUD2651A_SEARCH_VS20_INSERT_VALUE", cn, CheckValue_String)
                        SPR_SET(vS20, , , , OperationMode.Normal)
                        SPR_PRO(vS20, DS2, "USP_ISUD2651A_SEARCH_vS20", "VS20")
                        SPR_INSERT(vS20)
                        Call VsSizeRange(vS20, "USP_ISUD2651A_SEARCH_VS20_HEAD_INSERT_VALUE", CheckValue_String)
                    End If



                    vS20.Enabled = True
                    Exit Function
                End If

                SPR_PRO_NEW(vS20, DS1, "USP_ISUD2651A_SEARCH_vS20", "vS20")
                Call VsSizeRange(vS20, "USP_ISUD2651A_SEARCH_VS20_HEAD", L2651.ProductInboundNo)

                DATA_SEARCH_vS20 = True

            Catch ex As Exception
                Call MsgBoxP("35", "DATA_SEARCH_vS20")
            End Try
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH_vS20")
        End Try

    End Function

    Private Sub DATA_SEARCH_CHECK_SPECNO()

    End Sub


#End Region

#Region "Function"

    Private Sub DATA_MOVE_DEFAULT()
        Try
            W2651.seUnitPrice = ListCode("UnitPrice")
            W2651.seUnitPacking = ListCode("UnitPacking")
            W2651.seFactory = ListCode("Factory")
            W2651.seUnitMaterial = ListCode("UnitMaterial")
        Catch ex As Exception
            Call Error_Message("62", "DATA_MOVE_DEFAULT")
        End Try

    End Sub

    Private Function DATA_MOVE_WRITE01() As Boolean
        DATA_MOVE_WRITE01 = False
        Dim ProductInboundNo As String
        Dim ProductInboundSeq As String

        Try

            If READ_PFK2651(txt_ProductInboundNo.Data, ProductInboundSeq) = True Then

                DATA_MOVE_DEFAULT()

                Call REWRITE_PFK2651(W2651)
                isudCHK = True
            Else
                W2651.ProductInboundNo = L2651.ProductInboundNo
                W2651.CustomerCode = txt_CustomerCode.Code

                DATA_MOVE_DEFAULT()

                Call WRITE_PFK2651(W2651)

                isudCHK = True
            End If

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

                If K2651_MOVE(vS10, i, W2651, txt_ProductInboundNo.Data, getData(vS10, getColumIndex(vS10, "KEY_ProductInboundSeq"), i)) = True Then

                    DATA_MOVE_DEFAULT()

                    W2651.DateUpdate = Pub.DAT
                    W2651.InchargeUpdate = Pub.SAW

                    Call CheckInBoundMaterial()
                    Call CheckMarketType()
                    Call CheckMaterialType()

                    W2651.CheckInBoundMaterial = CIntp(cmb_CheckInBoundMaterial.InSelected) + 1
                    W2651.CheckProduct = "1"
                    W2651.CheckComplete = "1"
                    W2651.KindProduct = "1"

                    W2651.DatePosted = FormatCut(txt_DatePosted.Data)
                    W2651.InchargeInbound = txt_InchargeInBound.Code

                    W2651.DateExchange = FormatCut(txt_DateExchange.Data)
                    W2651.PriceExchange = CDecp(txt_PriceExchange.Data)
                    W2651.cdFactory = txt_cdUnitPrice.Code
                    W2651.cdUnitPrice = txt_cdUnitPrice.Code

                    W2651.FactOrderNo = getData(vS10, getColumIndex(vS10, "FactOrderNo"), i)
                    W2651.FactOrderSeq = getData(vS10, getColumIndex(vS10, "FactOrderSeq"), i)


                    Call REWRITE_PFK2651(W2651)

                    isudCHK = True
                Else
                    W2651.ProductInboundNo = L2651.ProductInboundNo

                    Call KEY_COUNT_PFK2651()

                    DATA_MOVE_DEFAULT()

                    W2651.DateInbound = Pub.DAT
                    W2651.DateInsert = Pub.DAT
                    W2651.InchargeInsert = Pub.SAW

                    Call CheckInBoundMaterial()
                    Call CheckMarketType()
                    Call CheckMaterialType()

                    W2651.FactOrderNo = getData(vS10, getColumIndex(vS10, "FactOrderNo"), i)
                    W2651.FactOrderSeq = getData(vS10, getColumIndex(vS10, "FactOrderSeq"), i)


                    W2651.CheckInBoundMaterial = CIntp(cmb_CheckInBoundMaterial.InSelected) + 1
                    W2651.CheckProduct = "1"
                    W2651.CheckComplete = "1"
                    W2651.KindProduct = "1"

                    W2651.InchargeInbound = txt_InchargeInBound.Code
                    W2651.DatePosted = FormatCut(txt_DatePosted.Data)

                    W2651.DateExchange = FormatCut(txt_DateExchange.Data)
                    W2651.PriceExchange = CDecp(txt_PriceExchange.Data)
                    W2651.cdFactory = txt_cdUnitPrice.Code
                    W2651.cdUnitPrice = txt_cdUnitPrice.Code

                    W2651.CustomerCode = txt_CustomerCode.Code


                    Call WRITE_PFK2651(W2651)

                    isudCHK = True
                End If
skip:
            Next

            DATA_MOVE_WRITE02 = True

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

            If K2651_MOVE(vS10, i, W2651, txt_ProductInboundNo.Data, getData(vS10, getColumIndex(vS10, "KEY_ProductInboundSeq"), i)) = True Then

                W2651.cdUnitMaterial = getData(vS10, getColumIndex(vS10, "cdUnitMaterial"), i)
                W2651.cdUnitPacking = getData(vS10, getColumIndex(vS10, "cdUnitPacking"), i)

                Call CheckInBoundMaterial()
                Call CheckMarketType()
                Call CheckMaterialType()

                Call DATA_MOVE_DEFAULT()
                Call REWRITE_PFK2651(W2651)

                isudCHK = True
            Else
                W2651.ProductInboundNo = L2651.ProductInboundNo

                Call KEY_COUNT_PFK2651()

                Call CheckInBoundMaterial()
                Call CheckMarketType()
                Call CheckMaterialType()

                W2651.cdUnitMaterial = getData(vS10, getColumIndex(vS10, "cdUnitMaterial"), i)
                W2651.cdUnitPacking = getData(vS10, getColumIndex(vS10, "cdUnitPacking"), i)
                W2651.CheckComplete = "1"

                Call DATA_MOVE_DEFAULT()
                Call WRITE_PFK2651(W2651)

                isudCHK = True
            End If

            DATA_MOVE_WRITE02_ROW = True

        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE02_ROW")
        End Try

    End Function

    Private Function DATA_MOVE_WRITE03() As Boolean
        DATA_MOVE_WRITE03 = False
        Try
            Dim i As Integer
            Dim j As Integer

            Dim colstart As Integer

            j = 0

            colstart = getColumIndex(vS20, "SizeQtyInbound01")

            For i = 0 To vS20.ActiveSheet.RowCount - 1
                If Trim(getData(vS10, getColumIndex(vS10, "KEY_ProductInboundNo"), i)) = "" Then GoTo skip

                j = j + 1

                If K2652_MOVE(vS20, i, W2652, txt_ProductInboundNo.Data, getData(vS10, getColumIndex(vS10, "KEY_ProductInboundSeq"), i)) = True Then
                    W2652.ProductInboundNo = txt_ProductInboundNo.Data
                    W2652.ProductInboundSeq = getData(vS10, getColumIndex(vS10, "KEY_ProductInboundSeq"), i)

                    W2652.SizeQtyInbound01 = CDblp(getData(vS20, colstart, i))
                    W2652.SizeQtyInbound02 = CDblp(getData(vS20, colstart + 1, i))
                    W2652.SizeQtyInbound03 = CDblp(getData(vS20, colstart + 2, i))
                    W2652.SizeQtyInbound04 = CDblp(getData(vS20, colstart + 3, i))
                    W2652.SizeQtyInbound05 = CDblp(getData(vS20, colstart + 4, i))
                    W2652.SizeQtyInbound06 = CDblp(getData(vS20, colstart + 5, i))
                    W2652.SizeQtyInbound07 = CDblp(getData(vS20, colstart + 6, i))
                    W2652.SizeQtyInbound08 = CDblp(getData(vS20, colstart + 7, i))
                    W2652.SizeQtyInbound09 = CDblp(getData(vS20, colstart + 8, i))
                    W2652.SizeQtyInbound10 = CDblp(getData(vS20, colstart + 9, i))
                    W2652.SizeQtyInbound11 = CDblp(getData(vS20, colstart + 10, i))
                    W2652.SizeQtyInbound12 = CDblp(getData(vS20, colstart + 11, i))
                    W2652.SizeQtyInbound13 = CDblp(getData(vS20, colstart + 12, i))
                    W2652.SizeQtyInbound14 = CDblp(getData(vS20, colstart + 13, i))
                    W2652.SizeQtyInbound15 = CDblp(getData(vS20, colstart + 14, i))
                    W2652.SizeQtyInbound16 = CDblp(getData(vS20, colstart + 15, i))
                    W2652.SizeQtyInbound17 = CDblp(getData(vS20, colstart + 16, i))
                    W2652.SizeQtyInbound18 = CDblp(getData(vS20, colstart + 17, i))
                    W2652.SizeQtyInbound19 = CDblp(getData(vS20, colstart + 18, i))
                    W2652.SizeQtyInbound20 = CDblp(getData(vS20, colstart + 19, i))
                    W2652.SizeQtyInbound21 = CDblp(getData(vS20, colstart + 20, i))
                    W2652.SizeQtyInbound22 = CDblp(getData(vS20, colstart + 21, i))
                    W2652.SizeQtyInbound23 = CDblp(getData(vS20, colstart + 22, i))
                    W2652.SizeQtyInbound24 = CDblp(getData(vS20, colstart + 23, i))
                    W2652.SizeQtyInbound25 = CDblp(getData(vS20, colstart + 24, i))
                    W2652.SizeQtyInbound26 = CDblp(getData(vS20, colstart + 25, i))
                    W2652.SizeQtyInbound27 = CDblp(getData(vS20, colstart + 26, i))
                    W2652.SizeQtyInbound28 = CDblp(getData(vS20, colstart + 27, i))
                    W2652.SizeQtyInbound29 = CDblp(getData(vS20, colstart + 28, i))
                    W2652.SizeQtyInbound30 = CDblp(getData(vS20, colstart + 29, i))

                    If REWRITE_PFK2652(W2652) Then
                        'Call PrcExe("USP_PFK2651_UPDATE_SIZEQTY", cn, W2652.ProductInboundNo)
                    End If
                    isudCHK = True

                Else

                    W2652.ProductInboundNo = L2651.ProductInboundNo
                    W2652.ProductInboundSeq = getData(vS10, getColumIndex(vS10, "KEY_ProductInboundSeq"), i)

                    W2652.SizeQtyInbound01 = 0
                    W2652.SizeQtyInbound02 = 0
                    W2652.SizeQtyInbound03 = 0
                    W2652.SizeQtyInbound04 = 0
                    W2652.SizeQtyInbound05 = 0
                    W2652.SizeQtyInbound06 = 0
                    W2652.SizeQtyInbound07 = 0
                    W2652.SizeQtyInbound08 = 0
                    W2652.SizeQtyInbound09 = 0
                    W2652.SizeQtyInbound10 = 0
                    W2652.SizeQtyInbound11 = 0
                    W2652.SizeQtyInbound12 = 0
                    W2652.SizeQtyInbound13 = 0
                    W2652.SizeQtyInbound14 = 0
                    W2652.SizeQtyInbound15 = 0
                    W2652.SizeQtyInbound16 = 0
                    W2652.SizeQtyInbound17 = 0
                    W2652.SizeQtyInbound18 = 0
                    W2652.SizeQtyInbound19 = 0
                    W2652.SizeQtyInbound20 = 0
                    W2652.SizeQtyInbound21 = 0
                    W2652.SizeQtyInbound22 = 0
                    W2652.SizeQtyInbound23 = 0
                    W2652.SizeQtyInbound24 = 0
                    W2652.SizeQtyInbound25 = 0
                    W2652.SizeQtyInbound26 = 0
                    W2652.SizeQtyInbound27 = 0
                    W2652.SizeQtyInbound28 = 0
                    W2652.SizeQtyInbound29 = 0
                    W2652.SizeQtyInbound30 = 0

                    If WRITE_PFK2652(W2652) Then
                        'Call PrcExe("USP_PFK2651_UPDATE_SIZEQTY", cn, W2652.ProductInboundNo)
                    End If

                    isudCHK = True

                End If
skip:
            Next

            DATA_MOVE_WRITE03 = True

        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE03")
        End Try

    End Function

    Private Function DATA_MOVE_WRITE03_ROW(i As Integer) As Boolean
        DATA_MOVE_WRITE03_ROW = False
        Try

            Dim j As Integer
            Dim colstart As Integer

            j = 0

            For xxx As Integer = 0 To vS20.ActiveSheet.ColumnCount - 1
                If getDataCH(vS20, xxx, 0) <> "" Then
                    colstart = xxx
                    Exit For
                End If
            Next

            If Trim(getData(vS20, getColumIndex(vS20, "KEY_ProductInboundNo"), i)) = "" Then Exit Function

            j = j + 1
            colstart += 1
            If K2652_MOVE(vS20, i, W2652, txt_ProductInboundNo.Data, getData(vS20, getColumIndex(vS20, "KEY_ProductInboundSeq"), i)) = True Then

                W2652.SizeQtyInbound01 = CDblp(getData(vS20, colstart, i))
                W2652.SizeQtyInbound02 = CDblp(getData(vS20, colstart + 1, i))
                W2652.SizeQtyInbound03 = CDblp(getData(vS20, colstart + 2, i))
                W2652.SizeQtyInbound04 = CDblp(getData(vS20, colstart + 3, i))
                W2652.SizeQtyInbound05 = CDblp(getData(vS20, colstart + 4, i))
                W2652.SizeQtyInbound06 = CDblp(getData(vS20, colstart + 5, i))
                W2652.SizeQtyInbound07 = CDblp(getData(vS20, colstart + 6, i))
                W2652.SizeQtyInbound08 = CDblp(getData(vS20, colstart + 7, i))
                W2652.SizeQtyInbound09 = CDblp(getData(vS20, colstart + 8, i))
                W2652.SizeQtyInbound10 = CDblp(getData(vS20, colstart + 9, i))
                W2652.SizeQtyInbound11 = CDblp(getData(vS20, colstart + 10, i))
                W2652.SizeQtyInbound12 = CDblp(getData(vS20, colstart + 11, i))
                W2652.SizeQtyInbound13 = CDblp(getData(vS20, colstart + 12, i))
                W2652.SizeQtyInbound14 = CDblp(getData(vS20, colstart + 13, i))
                W2652.SizeQtyInbound15 = CDblp(getData(vS20, colstart + 14, i))
                W2652.SizeQtyInbound16 = CDblp(getData(vS20, colstart + 15, i))
                W2652.SizeQtyInbound17 = CDblp(getData(vS20, colstart + 16, i))
                W2652.SizeQtyInbound18 = CDblp(getData(vS20, colstart + 17, i))
                W2652.SizeQtyInbound19 = CDblp(getData(vS20, colstart + 18, i))
                W2652.SizeQtyInbound20 = CDblp(getData(vS20, colstart + 19, i))
                W2652.SizeQtyInbound21 = CDblp(getData(vS20, colstart + 20, i))
                W2652.SizeQtyInbound22 = CDblp(getData(vS20, colstart + 21, i))
                W2652.SizeQtyInbound23 = CDblp(getData(vS20, colstart + 22, i))
                W2652.SizeQtyInbound24 = CDblp(getData(vS20, colstart + 23, i))
                W2652.SizeQtyInbound25 = CDblp(getData(vS20, colstart + 24, i))
                W2652.SizeQtyInbound26 = CDblp(getData(vS20, colstart + 25, i))
                W2652.SizeQtyInbound27 = CDblp(getData(vS20, colstart + 26, i))
                W2652.SizeQtyInbound28 = CDblp(getData(vS20, colstart + 27, i))
                W2652.SizeQtyInbound29 = CDblp(getData(vS20, colstart + 28, i))
                W2652.SizeQtyInbound30 = CDblp(getData(vS20, colstart + 29, i))

                Call REWRITE_PFK2652(W2652)
                isudCHK = True

            Else

                W2652.ProductInboundNo = L2651.ProductInboundNo
                W2652.ProductInboundSeq = getData(vS20, getColumIndex(vS20, "KEY_ProductInboundSeq"), i)

                W2652.SizeQtyInbound01 = CDblp(getData(vS20, colstart, i))
                W2652.SizeQtyInbound02 = CDblp(getData(vS20, colstart + 1, i))
                W2652.SizeQtyInbound03 = CDblp(getData(vS20, colstart + 2, i))
                W2652.SizeQtyInbound04 = CDblp(getData(vS20, colstart + 3, i))
                W2652.SizeQtyInbound05 = CDblp(getData(vS20, colstart + 4, i))
                W2652.SizeQtyInbound06 = CDblp(getData(vS20, colstart + 5, i))
                W2652.SizeQtyInbound07 = CDblp(getData(vS20, colstart + 6, i))
                W2652.SizeQtyInbound08 = CDblp(getData(vS20, colstart + 7, i))
                W2652.SizeQtyInbound09 = CDblp(getData(vS20, colstart + 8, i))
                W2652.SizeQtyInbound10 = CDblp(getData(vS20, colstart + 9, i))
                W2652.SizeQtyInbound11 = CDblp(getData(vS20, colstart + 10, i))
                W2652.SizeQtyInbound12 = CDblp(getData(vS20, colstart + 11, i))
                W2652.SizeQtyInbound13 = CDblp(getData(vS20, colstart + 12, i))
                W2652.SizeQtyInbound14 = CDblp(getData(vS20, colstart + 13, i))
                W2652.SizeQtyInbound15 = CDblp(getData(vS20, colstart + 14, i))
                W2652.SizeQtyInbound16 = CDblp(getData(vS20, colstart + 15, i))
                W2652.SizeQtyInbound17 = CDblp(getData(vS20, colstart + 16, i))
                W2652.SizeQtyInbound18 = CDblp(getData(vS20, colstart + 17, i))
                W2652.SizeQtyInbound19 = CDblp(getData(vS20, colstart + 18, i))
                W2652.SizeQtyInbound20 = CDblp(getData(vS20, colstart + 19, i))
                W2652.SizeQtyInbound21 = CDblp(getData(vS20, colstart + 20, i))
                W2652.SizeQtyInbound22 = CDblp(getData(vS20, colstart + 21, i))
                W2652.SizeQtyInbound23 = CDblp(getData(vS20, colstart + 22, i))
                W2652.SizeQtyInbound24 = CDblp(getData(vS20, colstart + 23, i))
                W2652.SizeQtyInbound25 = CDblp(getData(vS20, colstart + 24, i))
                W2652.SizeQtyInbound26 = CDblp(getData(vS20, colstart + 25, i))
                W2652.SizeQtyInbound27 = CDblp(getData(vS20, colstart + 26, i))
                W2652.SizeQtyInbound28 = CDblp(getData(vS20, colstart + 27, i))
                W2652.SizeQtyInbound29 = CDblp(getData(vS20, colstart + 28, i))
                W2652.SizeQtyInbound30 = CDblp(getData(vS20, colstart + 29, i))

                Call WRITE_PFK2652(W2652)

                isudCHK = True

            End If
            DATA_MOVE_WRITE03_ROW = True

        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE03_ROW")
        End Try

    End Function


    Private Sub DATA_INSERT()
        Try
            Call KEY_COUNT()

            If DATA_MOVE_WRITE02() = True Then
                Call DATA_SEARCH_vS10()
                Call DATA_MOVE_WRITE03()
                Call DATA_SEARCH_vS20()
                Call MsgBoxP("Insert Sucessfully !!!", vbInformation)
                isudCHK = True : WRITE_CHK = "*"
            End If

        Catch ex As Exception
            MsgBoxP("DATA_INSERT")
        End Try

    End Sub

    Private Sub DATA_UPDATE()
        Try
            If DATA_MOVE_WRITE02() = True Then
                Call DATA_SEARCH_vS10()
                Call DATA_MOVE_WRITE03()
                Call DATA_SEARCH_vS20()
                Call MsgBoxP("Update Sucessfully !!!", vbInformation)
                isudCHK = True : WRITE_CHK = "*"
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Dim ProductInboundSeq As String

        ProductInboundSeq = getData(vS10, getColumIndex(vS10, "KEY_ProductInboundSeq"), vS10.ActiveSheet.ActiveRowIndex)

        Try
            If READ_PFK2651(L2651.ProductInboundNo, ProductInboundSeq) = True Then
                W2651 = D2651
                DELETE_PFK2651(W2651)
                isudCHK = True
                Call DATA_SEARCH_vS10()
            End If
            MsgBoxP("DATA_DELETE Order!")

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub


    Private Sub KEY_COUNT_PFK2651()
        Try
            SQL = "SELECT MAX(CAST(K2651_ProductInboundSeq AS DECIMAL)) AS MAX_MCODE FROM PFK2651 "
            SQL = SQL & " WHERE K2651_ProductInboundNo = '" & txt_ProductInboundNo.Data & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W2651.ProductInboundSeq = "001"
            Else
                W2651.ProductInboundSeq = CIntp(rd!MAX_MCODE + 1).ToString("000")
            End If

            rd.Close()

            L2651.ProductInboundSeq = W2651.ProductInboundSeq

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT_PFK2651")
        End Try
    End Sub


    Private Sub KEY_COUNT()

        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 4)

        Try
            SQL = "SELECT MAX(CAST(SUBSTRING(K2651_ProductInboundNo,7,3) AS DECIMAL)) AS MAX_MCODE FROM PFK2651 "
            SQL = SQL & " WHERE SUBSTRING(K2651_ProductInboundNo,3,4) = '" & YRNO.ToString & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W2651.ProductInboundNo = "FG" & YRNO & "001"
            Else
                W2651.ProductInboundNo = "FG" & YRNO & FormatP(CInt(rd!MAX_MCODE + 1), "000")
            End If

            rd.Close()

            txt_ProductInboundNo.Data = W2651.ProductInboundNo
            L2651.ProductInboundNo = W2651.ProductInboundNo

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub
    Private Sub vS10_CellClick(sender As Object, e As CellClickEventArgs) Handles vS10.CellDoubleClick
        If e.Column = getColumIndex(sender, "Slno") Then
            If READ_PFK2651(getData(vS10, getColumIndex(vS10, "ProductInboundNo"), e.Row), getData(vS10, getColumIndex(vS10, "ProductInboundSeq"), e.Row)) Then
                If txt_CustomerCode.Code = "000001" Then
                    If ISUD4958A.Link_ISUD4958A_SLNO_GX(1, D2651.ProductInboundNo, D2651.ProductInboundSeq, D2651.FactOrderNo, D2651.FactOrderSeq, Me.Name) Then
                        Call DATA_SEARCH_vS20()
                        Call DATA_SEARCH_vS10()
                    End If
                Else
                    If ISUD4958A.Link_ISUD4958A_SLNO(1, D2651.ProductInboundNo, D2651.ProductInboundSeq, Me.Name) Then
                        Call DATA_SEARCH_vS20()
                        Call DATA_SEARCH_vS10()
                    End If
                End If
               
            End If
        End If

    End Sub



#End Region

#Region "Event"
    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim i As Integer

        Try
            For i = 0 To vS10.ActiveSheet.RowCount - 1
                If getData(vS10, getColumIndex(vS10, "CustomerCode"), i).ToString.Trim = "" Then MsgBoxP("CustomerCode at Row " & (i + 1)) : Exit Function
                If getData(vS10, getColumIndex(vS10, "ShoesCode"), i).ToString.Trim = "" Then MsgBoxP("ShoesCode at Row " & (i + 1)) : Exit Function
         

            Next

            Data_Check = True
        Catch ex As Exception

        End Try
    End Function


    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Try
            Select Case wJOB
                Case 1
                    If data_check = False Then Exit Sub
                    If DataCheck(Me, "PFK2651") = False Then Exit Sub
                    Call DATA_INSERT()
                    wJOB = 3
                Case 2
                    Me.Dispose()
                Case 3
                    If data_check = False Then Exit Sub
                    If DataCheck(Me, "PFK2651") = False Then Exit Sub
                    Call DATA_UPDATE()
                Case 4
            End Select
        Catch ex As Exception
            MsgBoxP("cmd_OK_Click")
        End Try

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
        Try
            Call DATA_DELETE()
        Catch ex As Exception
            MsgBoxP("cmd_DEL_Click")
        End Try

    End Sub



    Private Sub vS10_KeyDown(sender As Object, e As KeyEventArgs) Handles vS10.KeyDown
        If wJOB = 2 Then Exit Sub
        Dim xCOL As Long
        Dim xROW As Long

        xCOL = vS10.ActiveSheet.ActiveColumnIndex
        xROW = vS10.ActiveSheet.ActiveRowIndex
        Try

            Select Case e.KeyCode
                Case Keys.Delete

                    Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)

                    If Msg_Result <> vbYes Then Exit Sub
                    Try

                        If K2651_MOVE(vS10, xROW, W2651, txt_ProductInboundNo.Data, getData(vS10, getColumIndex(vS10, "KEY_ProductInboundSeq"), xROW)) = True Then

                            W2651 = D2651
                            If W2651.QtyProductOutbound > 0 Then MsgBoxP("Data Already") : Exit Sub

                            Call DELETE_PFK2652(W2652)

                        End If

                        SPR_DEL(vS10, 0, vS10.ActiveSheet.ActiveRowIndex)
                        vS10.Focus()

                    Catch ex As Exception
                        Call MsgBoxP("Vs10 Keys.Delete!")
                    End Try
                Case Keys.Enter


            End Select

        Catch ex As Exception
            Call MsgBoxP("vS10_KeyDown")
        End Try
    End Sub

    Private Sub VS10_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles vS10.ButtonClicked
        Dim xCOL As Integer
        Dim xROW As Integer

        xROW = e.Row
        xCOL = e.Column

    End Sub

#End Region

#Region "Search Line"

    Private Function DATA_SEARCH_VS10_LINE(ProductInboundNo As String, ProductInboundSeq As String) As Boolean
        Dim DSNEW As New DataSet

        DATA_SEARCH_VS10_LINE = False

        Try
            DSNEW = PrcDS("USP_ISUD2651A_SEARCH_VS10_LINE", cn, ProductInboundNo, ProductInboundSeq)

            If GetDsRc(DSNEW) = 0 Then
                Exit Function
            End If
            READ_SPREAD(vS10, DSNEW, "USP_ISUD2651A_SEARCH_VS10", "vS10", vS10.ActiveSheet.ActiveRowIndex)

            DATA_SEARCH_VS10_LINE = True
        Catch ex As Exception
            Call MsgBoxP("DATA_SEARCH_VS10_LINE")
        End Try
    End Function

    Private Function DATA_SEARCH_VS20_LINE(ProductInboundNo As String, ProductInboundSeq As String) As Boolean
        Dim DSNEW As New DataSet

        DATA_SEARCH_VS20_LINE = False

        Try
            DSNEW = PrcDS("USP_ISUD2651A_SEARCH_VS20_LINE", cn, ProductInboundNo, ProductInboundSeq)

            If GetDsRc(DSNEW) = 0 Then
                Exit Function
            End If
            READ_SPREAD(vS20, DSNEW, "USP_ISUD2651A_SEARCH_VS20", "vS20", vS20.ActiveSheet.ActiveRowIndex)

            DATA_SEARCH_VS20_LINE = True
        Catch ex As Exception
            Call MsgBoxP("DATA_SEARCH_VS20_LINE")
        End Try
    End Function


#End Region

#Region "Keydown"


    Private Function CheckAprroval(ProductInboundNo As String, ProductInboundSeq As String) As Boolean
        CheckAprroval = False
        Try
            If READ_PFK2651(ProductInboundNo, ProductInboundSeq) = True Then
                W2651 = D2651
                If W2651.QtyProductOutbound > 0 Then CheckAprroval = True Else CheckAprroval = False
            End If
        Catch ex As Exception
            MsgBoxP("CheckAprroval")
        End Try
    End Function


#End Region

#Region "Sheet Change"

    Private Sub vS10_Change(sender As Object, e As ChangeEventArgs) Handles vS10.Change
        Try


        Catch ex As Exception
            Call MsgBoxP("vS10_Change")
        End Try
    End Sub

    Private Sub vS20_Change(sender As Object, e As ChangeEventArgs) Handles vS20.Change
        Try


        Catch ex As Exception
            Call MsgBoxP("vS20_Change")
        End Try
    End Sub


#End Region



End Class