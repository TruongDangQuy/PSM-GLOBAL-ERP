Public Class ISUD2351C

#Region "Variable"
    Private wJOB As Integer

    Private W2351 As New T2351_AREA
    Private L2351 As New T2351_AREA

    Private W2352 As New T2352_AREA
    Private L2352 As New T2352_AREA
    Private WRITE_CHK As String
    Private ImportTax As Decimal
    Private EnvironmentTax As Decimal
    Private VatTax As Decimal
    Private formA As Boolean
    Private CHK(0 To 5) As String
    Private cdSemiGroupMaterial As String

#End Region

#Region "Link"
    Public Function Link_ISUD2351C(job As Integer, CheckInBoundMaterial As String, MaterialInBoundNo As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D2351.MaterialInBoundNo = MaterialInBoundNo
        D2351.CheckInBoundMaterial = CheckInBoundMaterial

        wJOB = job : L2351 = D2351

        Link_ISUD2351C = False
        Try

            Select Case job
                Case 1
                Case 5

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD2351C = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try


    End Function

    Public Function Link_ISUD2351C_AUTO(job As Integer, FactOrderNo As String, FactOrderSeq As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        D2351.FactOrderNo = FactOrderNo
        D2351.FactOrderSeq = FactOrderSeq

        If READ_PFK3421(FactOrderNo) Then D2351.CheckInBoundMaterial = D3421.CheckInPurchasingOrder : cmb_CheckInBoundMaterial.InSelected = CIntp_S(D3421.CheckInPurchasingOrder) - 1

        wJOB = job : L2351 = D2351

        Link_ISUD2351C_AUTO = False
        Try

            Select Case job
                Case 1
                Case 5

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD2351C_AUTO = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try


    End Function

    'Public Function Link_ISUD2351C_AUTO(job As Integer, _cdSemiGroupMaterial As String, FactOrderNo As String, Optional ByVal TAG As String = "") As Boolean
    'Me.Tag = TAG

    'D2351.FactOrderNo = FactOrderNo
    'cdSemiGroupMaterial = _cdSemiGroupMaterial

    'If READ_PFK3421(FactOrderNo) Then D2351.CheckInBoundMaterial = D3421.CheckInPurchasingOrder : cmb_CheckInBoundMaterial.InSelected = CIntp_S(D3421.CheckInPurchasingOrder) - 1

    'wJOB = job : L2351 = D2351

    'Link_ISUD2351C_AUTO = False
    'Try

    '    Select Case job
    '        Case 1
    '        Case 5

    '    End Select

    '    formA = False
    '    Me.ShowDialog()

    '    Link_ISUD2351C_AUTO = isudCHK


    'Catch ex As Exception
    '    Call MsgBoxP("61", WordConv("YARN PROCESSING"))
    'End Try


    'End Function
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
                cmd_DEL.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()
                Call DATA_SEARCH_vS1()
                Call DATA_SEARCH_vS2()
                Call DATA_SEARCH_vS3()
            Case 2
                Me.Text = Me.Text & " - SEARCH"

                Frame1.Enabled = True
                cmd_DEL.Visible = False
                cmd_OK.Visible = False
                cmd_UpdateRoll.Visible = False

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
                Call DATA_SEARCH_vS3()
            Case 3
                Me.Text = Me.Text & " - UPDATE"

                Frame1.Enabled = True
                txt_MaterialInBoundNo.Enabled = False

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
                Call DATA_SEARCH_vS1()
                Call DATA_SEARCH_vS2()
                Call DATA_SEARCH_vS3()

            Case 4                                                      '»èÁ¦
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
                Call DATA_SEARCH_vS1()
                Call DATA_SEARCH_vS2()
                Call DATA_SEARCH_vS3()
            Case 11                                                   'ÀÔ·Â
                Me.Text = Me.Text & " - INSERT INTERFACE"
                Frame1.Enabled = True
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
                If cdSemiGroupMaterial = "" Then Call DATA_SEARCH_vS1() Else DATA_SEARCH_vS1_Semi()

                Call DATA_SEARCH_vS2()
                Call DATA_SEARCH_vS3()
        End Select

        formA = True
    End Sub
#End Region

#Region "Search"
    Private Function DATA_SEARCH01() As Boolean

        DATA_SEARCH01 = False

        DS1 = PrcDS("USP_ISUD2351C_SEARCH_HEAD", cn, L2351.MaterialInBoundNo)


        If GetDsRc(DS1) = 0 Then
            DS2 = READ_PFK3421(L2351.FactOrderNo, cn)

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

        If READ_PFK7101(txt_SupplierCode.Code) = True Then
            txt_SupplierCode.Data = D7101.CustomerName
        End If

        DATA_SEARCH01 = True

    End Function

    Private Function DATA_SEARCH_vS1() As Boolean
        DATA_SEARCH_vS1 = False

        DS1 = PrcDS("USP_ISUD2351C_SEARCH_VS1", cn, L2351.MaterialInBoundNo)


        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_ISUD2351C_SEARCH_VS1_INSERT", cn, L2351.FactOrderNo, L2351.FactOrderSeq)

            SPR_SET(Vs1, , , , OperationMode.Normal)
            SPR_PRO(Vs1, DS2, "USP_ISUD2351C_SEARCH_VS1", "Vs1")
            SPR_INSERT(Vs1)

            If READ_PFK7171(ListCode("Department"), getData(Vs1, getColumIndex(Vs1, "cdDepartment"), 0)) Then
                txt_cdDepartment.Data = D7171.BasicName
                txt_cdDepartment.Code = D7171.BasicCode
            End If

            Vs1.Enabled = True
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO(Vs1, DS1, "USP_ISUD2351C_SEARCH_VS1", "Vs1")

        Dim i As Integer
        For i = 0 To Vs1.ActiveSheet.RowCount - 1
            If CDblp(getData(Vs1, getColumIndex(Vs1, "QtyOutBound"), i)) > 0 Then
                Call SPR_LOCK(Vs1, i)
                Call SPR_BACKCOLOR(Vs1, Color.Pink, i)
            End If
        Next

        DATA_SEARCH_vS1 = True

    End Function

    Private Function DATA_SEARCH_vS1_Semi() As Boolean
        DATA_SEARCH_vS1_Semi = False

        DS1 = PrcDS("USP_ISUD2351C_SEARCH_VS1", cn, L2351.MaterialInBoundNo)


        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_ISUD2351C_SEARCH_VS1_INSERT_SEMI", cn, L2351.FactOrderNo, cdSemiGroupMaterial)

            SPR_SET(Vs1, , , , OperationMode.Normal)
            SPR_PRO(Vs1, DS2, "USP_ISUD2351C_SEARCH_VS1", "Vs1")
            SPR_INSERT(Vs1)

            If READ_PFK7171(ListCode("Department"), getData(Vs1, getColumIndex(Vs1, "cdDepartment"), 0)) Then
                txt_cdDepartment.Data = D7171.BasicName
                txt_cdDepartment.Code = D7171.BasicCode
            End If

            Vs1.Enabled = True
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO(Vs1, DS1, "USP_ISUD2351C_SEARCH_VS1", "Vs1")

        Dim i As Integer
        For i = 0 To Vs1.ActiveSheet.RowCount - 1
            If CDblp(getData(Vs1, getColumIndex(Vs1, "QtyOutBound"), i)) > 0 Then
                Call SPR_LOCK(Vs1, i)
                Call SPR_BACKCOLOR(Vs1, Color.Pink, i)
            End If
        Next

        DATA_SEARCH_vS1_Semi = True

    End Function

    Private Function DATA_SEARCH_vS2() As Boolean
        DATA_SEARCH_vS2 = False
        Dim MaterialInBoundNo As String
        Dim MaterialInBoundSeq As String
        Dim PackInBound As String
        Dim QtyBasic As String

        MaterialInBoundNo = getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundNo"), Vs1.ActiveSheet.ActiveRowIndex)
        MaterialInBoundSeq = getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundSeq"), Vs1.ActiveSheet.ActiveRowIndex)
        PackInBound = getData(Vs1, getColumIndex(Vs1, "PackInBound"), Vs1.ActiveSheet.ActiveRowIndex)
        QtyBasic = CDecp(getData(Vs1, getColumIndex(Vs1, "QtyBasic"), Vs1.ActiveSheet.ActiveRowIndex))

        If READ_PFK2351(MaterialInBoundNo, MaterialInBoundSeq) = False Then Exit Function

        DS1 = PrcDS("USP_ISUD2351C_SEARCH_VS2", cn, MaterialInBoundNo, _
                                                        MaterialInBoundSeq)

        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_ISUD2351C_SEARCH_VS2_INSERT", cn, MaterialInBoundNo, _
                                                       MaterialInBoundSeq,
                                                       PackInBound, QtyBasic)

            SPR_SET(vS2, , , , OperationMode.Normal)
            SPR_PRO(vS2, DS2, "USP_ISUD2351C_SEARCH_vS2", "vS2")
            SPR_INSERT(vS2)
            vS2.Enabled = True
            Exit Function
        End If

        SPR_SET(vS2, , , , OperationMode.Normal)
        SPR_PRO(vS2, DS1, "USP_ISUD2351C_SEARCH_vS2", "vS2")

        Dim i As Integer

        For i = 0 To vS2.ActiveSheet.RowCount - 1
            If getData(vS2, getColumIndex(vS2, "PackOutBound"), i) > 0 Or getDataM(vS2, getColumIndex(vS2, "CheckPrint"), i) = "1" Then
                SPR_BACKCOLORCELL(vS2, Color.Red, getColumIndex(vS2, "MaterialInBoundSno"), i)
                'SPR_LOCK(vS2, i)
            End If
        Next

        DATA_SEARCH_vS2 = True


    End Function


    Private Function DATA_SEARCH_vS3() As Boolean
        DATA_SEARCH_vS3 = False
        Dim MaterialInBoundNo As String
        Dim MaterialInBoundSeq As String
        Dim PackInBound As String
        Dim QtyBasic As String

        MaterialInBoundNo = getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundNo"), Vs1.ActiveSheet.ActiveRowIndex)
        MaterialInBoundSeq = getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        If READ_PFK2351(MaterialInBoundNo, MaterialInBoundSeq) = False Then Exit Function

        DS1 = PrcDS("USP_ISUD2351C_SEARCH_vS3", cn, MaterialInBoundNo, _
                                                        MaterialInBoundSeq)

        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_ISUD2351C_SEARCH_vS3_INSERT", cn, MaterialInBoundNo, _
                                                       MaterialInBoundSeq)

            SPR_SET(vS3, , , , OperationMode.Normal)
            SPR_PRO(vS3, DS2, "USP_ISUD2351C_SEARCH_vS3", "vS3")
            SPR_INSERT(vS3)
            vS3.Enabled = True
            Exit Function
        End If

        SPR_SET(vS3, , , , OperationMode.Normal)
        SPR_PRO(vS3, DS1, "USP_ISUD2351C_SEARCH_vS3", "vS3")

        DATA_SEARCH_vS3 = True

    End Function
#End Region

#Region "Function"
    Private Sub CheckInBoundMaterial(Process As String)
        Select Case Process
            Case "1" : rad_CheckInBoundMaterial1.Checked = True
            Case "2" : rad_CheckInBoundMaterial2.Checked = True
            Case Else : rad_CheckInBoundMaterial1.Checked = True
        End Select
    End Sub
    Private Sub CheckInBoundMaterial()

    End Sub
    Private Sub CheckMarketType(Market As String)
        Select Case Market
            Case "1" : rad_CheckMarketType1.Checked = True
            Case "2" : rad_CheckMarketType2.Checked = True
            Case Else : rad_CheckMarketType1.Checked = True
        End Select
    End Sub

    Private Sub CheckMarketType()
        If rad_CheckMarketType1.Checked = True Then W2351.CheckMarketType = "1"
        If rad_CheckMarketType2.Checked = True Then W2351.CheckMarketType = "2"
    End Sub

    Private Sub CheckMaterialType(Market As String)
        Select Case Market
            Case "1" : rad_CheckMaterialType1.Checked = True
            Case "2" : rad_CheckMaterialType2.Checked = True
            Case Else : rad_CheckMaterialType1.Checked = True
        End Select
    End Sub

    Private Sub CheckMaterialType()
        If rad_CheckMaterialType1.Checked = True Then W2351.CheckMaterialType = "1"
        If rad_CheckMaterialType2.Checked = True Then W2351.CheckMaterialType = "2"
    End Sub
    Private Sub DATA_MOVE()

    End Sub

    Private Sub DATA_MOVE_DEFAULT()
        W2351.seDepartment = ListCode("Department")
        W2351.seSite = ListCode("Site")
        W2351.seTax1 = ListCode("Tax")
        W2351.seTax2 = ListCode("Tax")
        W2351.seTax3 = ListCode("Tax")
        W2351.seUnitMaterial = ListCode("UnitMaterial")
        W2351.seUnitPacking = ListCode("UnitPacking")
        W2351.seUnitPrice = ListCode("UnitPrice")
    End Sub

    Private Function DATA_MOVE_WRITE01() As Boolean
        DATA_MOVE_WRITE01 = False
        Try
            Dim i As Integer
            Dim j As Integer

            Dim PackInBound As String
            j = 0
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getDataM(Vs1, getColumIndex(Vs1, "DCHK"), i) <> "1" Then GoTo skip

                j = j + 1

                If K2351_MOVE(Vs1, i, W2351, txt_MaterialInBoundNo.Data, getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundSeq"), i)) = True Then
                    W2351.PriceExchange = txt_PriceExchange.Data
                    W2351.DateExchange = txt_DateExchange.Data

                    W2351.DateInBoundMaterial = FormatCut(txt_DateInBoundMaterial.Data)
                    W2351.DateAccept = FormatCut(txt_DateInBoundMaterial.Data)
                    W2351.DatePosted = FormatCut(txt_DatePosted.Data)

                    W2351.cdDepartment = txt_cdDepartment.Code

                    Call CheckMarketType()
                    Call CheckInBoundMaterial()
                    Call CheckMaterialType()
                    Call DATA_MOVE_DEFAULT()
                    W2351.SupplierCode = txt_SupplierCode.Code
                    W2351.InchargeInBound = txt_InchargeInBound.Code

                    W2351.InvoiceNo = txt_InvoiceNo.Data

                    W2351.cdUnitMaterialOld = W2351.cdUnitMaterial

                    W2351.CheckInBoundMaterial = CIntp(cmb_CheckInBoundMaterial.InSelected) + 1


                    W2351.ColorCode = getData(Vs1, getColumIndex(Vs1, "ColorCode"), i)
                    W2351.ColorName = getData(Vs1, getColumIndex(Vs1, "ColorName"), i)
                    W2351.SizeName = getData(Vs1, getColumIndex(Vs1, "SizeName"), i)
                    W2351.Width = getData(Vs1, getColumIndex(Vs1, "Width"), i)
                    Call REWRITE_PFK2351(W2351) : isudCHK = True

                Else
                    W2351.MaterialInBoundNo = L2351.MaterialInBoundNo
                    W2351.cdDepartment = txt_cdDepartment.Code

                    Call KEY_COUNT_2351()

                    W2351.DateInBoundMaterial = FormatCut(txt_DateInBoundMaterial.Data)
                    W2351.DateAccept = FormatCut(txt_DateInBoundMaterial.Data)
                    W2351.DatePosted = FormatCut(txt_DatePosted.Data)

                    W2351.PriceExchange = txt_PriceExchange.Data
                    W2351.DateExchange = txt_DateExchange.Data

                    Call CheckMarketType()
                    Call CheckInBoundMaterial()
                    Call CheckMaterialType()
                    Call DATA_MOVE_DEFAULT()

                    W2351.SupplierCode = txt_SupplierCode.Code
                    W2351.InchargeInBound = txt_InchargeInBound.Code

                    PackInBound = W2351.PackInBound
                    W2351.QtyInBound = 0

                    W2351.CheckComplete = "1"
                    W2351.InvoiceNo = txt_InvoiceNo.Data

                    W2351.CheckInBoundMaterial = CIntp(cmb_CheckInBoundMaterial.InSelected) + 1

                    W2351.cdWareHouseGroup = getData(Vs1, getColumIndex(Vs1, "cdWareHouseGroup"), i)
                    W2351.cdWareHousePosition = getData(Vs1, getColumIndex(Vs1, "cdWareHousePosition"), i)

                    W2351.seWareHouseGroup = ListCode("WareHouseGroup")
                    W2351.seWareHousePosition = ListCode("WareHousePosition")

                    W2351.cdUnitMaterialOld = W2351.cdUnitMaterial


                    W2351.QtyInBound_Or = W2351.QtyBasic


                    W2351.ColorCode = getData(Vs1, getColumIndex(Vs1, "ColorCode"), i)
                    W2351.ColorName = getData(Vs1, getColumIndex(Vs1, "ColorName"), i)
                    W2351.SizeName = getData(Vs1, getColumIndex(Vs1, "SizeName"), i)
                    W2351.Width = getData(Vs1, getColumIndex(Vs1, "Width"), i)
                    If WRITE_PFK2351(W2351) Then
                        Call PrcExeNoError("USP_PFK2351C_INSERT", cn, W2351.MaterialInBoundNo, W2351.MaterialInBoundSeq, PackInBound, 0)

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

    Private Function DATA_MOVE_WRITE02() As Boolean
        DATA_MOVE_WRITE02 = False
        Try
            Dim i As Integer
            Dim j As Integer
            j = 0
            For i = 0 To vS2.ActiveSheet.RowCount - 1
                j = j + 1

                If K2352_MOVE(vS2, i, W2352, getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundNo"), i),
                               getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundSeq"), i),
                               getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundSno"), i)) = True Then


                    W2352.QtyInBound = getData(vS2, getColumIndex(vS2, "QtyInBound"), i)
                    W2352.QtyInBoundQC = getData(vS2, getColumIndex(vS2, "QtyInBoundQC"), i)

                    W2352.CheckComplete = "1"
                    Call REWRITE_PFK2352(W2352)
                    isudCHK = True
                Else
                    W2352.MaterialInBoundNo = getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundNo"), 0)
                    W2352.MaterialInBoundSeq = getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundSeq"), 0)

                    L2352.MaterialInBoundNo = W2352.MaterialInBoundNo
                    L2352.MaterialInBoundSeq = W2352.MaterialInBoundSeq

                    Call KEY_COUNT_2352()
                    W2352.CheckComplete = "1"
                    Call WRITE_PFK2352(W2352)
                    isudCHK = True
                End If
skip:

            Next
            DATA_MOVE_WRITE02 = True
        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE01")
        End Try
    End Function
    Private Sub DATA_INSERT()

        Try
            Call DATA_MOVE()
            Call KEY_COUNT()
            If DATA_MOVE_WRITE01() = True Then
                MsgBoxP("Insert Inbound Sucessfully!", vbInformation)
                Call DATA_SEARCH_vS1()
                wJOB = 3
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub DATA_UPDATE()
        Try
            Dim i As Integer
            Dim j As Integer

            Dim PackInBound As String
            j = 0
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getDataM(Vs1, getColumIndex(Vs1, "DCHK"), i) <> "1" Then GoTo skip

                j = j + 1

                If READ_PFK2351(txt_MaterialInBoundNo.Data, getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundSeq"), i)) = True Then
                    W2351 = D2351
                    W2351.cdWareHouseGroup = getData(Vs1, getColumIndex(Vs1, "cdWareHouseGroup"), i)
                    W2351.cdWareHousePosition = getData(Vs1, getColumIndex(Vs1, "cdWareHousePosition"), i)

                    W2351.seWareHouseGroup = ListCode("WareHouseGroup")
                    W2351.seWareHousePosition = ListCode("WareHousePosition")


                    W2351.ColorCode = getData(Vs1, getColumIndex(Vs1, "ColorCode"), i)
                    W2351.ColorName = getData(Vs1, getColumIndex(Vs1, "ColorName"), i)
                    W2351.SizeName = getData(Vs1, getColumIndex(Vs1, "SizeName"), i)
                    W2351.Width = getData(Vs1, getColumIndex(Vs1, "Width"), i)
                    Call REWRITE_PFK2351(W2351)
                    isudCHK = True

                Else
                    If READ_PFK2351(txt_MaterialInBoundNo.Data, "001") Then
                        W2351 = D2351

                        W2351.QtyInBound = 0
                        W2351.QtyOutBound = 0

                        Call KEY_COUNT_2351()

                        W2351.MaterialCode = getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i)

                        W2351.ColorCode = getData(Vs1, getColumIndex(Vs1, "ColorCode"), i)
                        W2351.ColorName = getData(Vs1, getColumIndex(Vs1, "ColorName"), i)
                        W2351.SizeName = getData(Vs1, getColumIndex(Vs1, "SizeName"), i)
                        W2351.Width = getData(Vs1, getColumIndex(Vs1, "Width"), i)
                        If WRITE_PFK2351(W2351) Then
                            Call PrcExeNoError("USP_PFK2351C_INSERT", cn, W2351.MaterialInBoundNo, W2351.MaterialInBoundSeq, W2351.PackInBound, 0)
                        End If

                        isudCHK = True



                    End If
                    


                End If
skip:
            Next

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Try
            Dim i As Integer

            For i = 0 To Vs1.ActiveSheet.RowCount - 1

                If Trim(getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundNo"), i)) = "" Then GoTo skip
                If Trim(getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundSeq"), i)) = "" Then GoTo skip

                W2351.MaterialInBoundNo = getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundNo"), i)
                W2351.MaterialInBoundSeq = getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundSeq"), i)

                If READ_PFK2351(W2351.MaterialInBoundNo, W2351.MaterialInBoundSeq) = True Then
                    W2351 = D2351
                    If W2351.QtyOutBound > 0 Then MsgBoxP("Outbound Data Already") : Exit Sub

                    If PrcExeNoError("USP_ISUD2352A_ROWNUMBER_DELETE", cn, W2351.MaterialInBoundNo, W2351.MaterialInBoundSeq) Then
                        Call DELETE_PFK2351(W2351)

                        Call Delete_History("PFK2351", W2351.MaterialInBoundNo)

                        isudCHK = True

                        Call PrcExeNoError("USP_ISUD2352A_ROWNUMBER_DELETE_FACTORDERNO", cn, W2351.FactOrderNo, W2351.FactOrderNo)

                    End If
                End If
skip:

            Next
        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try
    End Sub
    Private Sub KEY_COUNT_2351()
        Try
            SQL = "SELECT MAX(CAST(K2351_MaterialInBoundSeq AS DECIMAL)) AS MAX_MCODE FROM PFK2351 "
            SQL = SQL & " WHERE K2351_MaterialInBoundNo = '" & txt_MaterialInBoundNo.Data & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W2351.MaterialInBoundSeq = "001"
            Else
                W2351.MaterialInBoundSeq = CIntp(rd!MAX_MCODE + 1).ToString("000")
            End If

            rd.Close()

            W2351.MaterialInBoundSeq = W2351.MaterialInBoundSeq

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub KEY_COUNT_2352()
        Try
            SQL = "SELECT MAX(K2352_MaterialInBoundSno) AS MAX_MCODE FROM PFK2352 "
            SQL = SQL & " WHERE K2352_MaterialInBoundNo = '" & L2352.MaterialInBoundNo & "' "
            SQL = SQL & " AND K2352_MaterialInBoundSeq = '" & L2352.MaterialInBoundSeq & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W2352.MaterialInBoundSno = 1
            Else
                W2352.MaterialInBoundSno = CIntp(rd!MAX_MCODE + 1)
            End If

            rd.Close()

            L2352.MaterialInBoundSno = W2352.MaterialInBoundSno

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub KEY_COUNT()

        Dim YRNO_oRI As Integer
        Dim YRNO As Integer


        YRNO = Mid(System_Date_8(), 3, 2)


        Try

            'SQL = "SELECT MAX(CAST(SUBSTRING(K2351_MaterialInBoundNo,5,5) AS DECIMAL)) AS MAX_MCODE FROM PFK2351 "
            'SQL = SQL & " WHERE SUBSTRING(K2351_MaterialInBoundNo,3,2) = '" & YRNO.ToString & "' "
            'SQL = SQL & " AND LEFT(K2351_MaterialInBoundNo,2) = 'WS' "

            'cmd = New SqlClient.SqlCommand(SQL, cn)
            'rd = cmd.ExecuteReader
            'rd.Read()

            'If IsDBNull(rd!MAX_MCODE) Then
            '    W2351.MaterialInBoundNo = "WP" & YRNO & "00001"
            'Else
            '    W2351.MaterialInBoundNo = "WP" & YRNO & Format(CInt(rd!MAX_MCODE + 1), "00000")

            'End If

            'rd.Close()

            SQL = "SELECT MAX(CAST(SUBSTRING(K2351_MaterialInBoundNo,5,5) AS DECIMAL)) AS MAX_MCODE FROM PFK2351 "
            SQL = SQL & " WHERE SUBSTRING(K2351_MaterialInBoundNo,3,2) = '" & YRNO.ToString & "' "

            If cmb_CheckInBoundMaterial.PeaceCombobox1.SelectedIndex = 0 Then
                SQL = SQL & " AND LEFT(K2351_MaterialInBoundNo,2) = 'WO' "
            ElseIf cmb_CheckInBoundMaterial.PeaceCombobox1.SelectedIndex = 1 Then
                SQL = SQL & " AND LEFT(K2351_MaterialInBoundNo,2) = 'WB' "
            ElseIf cmb_CheckInBoundMaterial.PeaceCombobox1.SelectedIndex = 2 Then
                SQL = SQL & " AND LEFT(K2351_MaterialInBoundNo,2) = 'WP' "
            ElseIf cmb_CheckInBoundMaterial.PeaceCombobox1.SelectedIndex = 3 Then
                SQL = SQL & " AND LEFT(K2351_MaterialInBoundNo,2) = 'WI' "
            ElseIf cmb_CheckInBoundMaterial.PeaceCombobox1.SelectedIndex = 4 Then
                SQL = SQL & " AND LEFT(K2351_MaterialInBoundNo,2) = 'WT' "
            ElseIf cmb_CheckInBoundMaterial.PeaceCombobox1.SelectedIndex = 5 Then
                SQL = SQL & " AND LEFT(K2351_MaterialInBoundNo,2) = 'WL' "
            ElseIf cmb_CheckInBoundMaterial.PeaceCombobox1.SelectedIndex = 6 Then
                SQL = SQL & " AND LEFT(K2351_MaterialInBoundNo,2) = 'WH' "
            ElseIf cmb_CheckInBoundMaterial.PeaceCombobox1.SelectedIndex = 7 Then
                SQL = SQL & " AND LEFT(K2351_MaterialInBoundNo,2) = 'WR' "
            End If



            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If cmb_CheckInBoundMaterial.PeaceCombobox1.SelectedIndex = 0 Then
                If IsDBNull(rd!MAX_MCODE) Then
                    W2351.MaterialInBoundNo = "WO" & YRNO & "00001"
                Else
                    W2351.MaterialInBoundNo = "WO" & YRNO & Format(CInt(rd!MAX_MCODE + 1), "00000")

                End If

            ElseIf cmb_CheckInBoundMaterial.PeaceCombobox1.SelectedIndex = 1 Then

                If IsDBNull(rd!MAX_MCODE) Then
                    W2351.MaterialInBoundNo = "WB" & YRNO & "00001"
                Else
                    W2351.MaterialInBoundNo = "WB" & YRNO & Format(CInt(rd!MAX_MCODE + 1), "00000")

                End If

            ElseIf cmb_CheckInBoundMaterial.PeaceCombobox1.SelectedIndex = 2 Then

                If IsDBNull(rd!MAX_MCODE) Then
                    W2351.MaterialInBoundNo = "WP" & YRNO & "00001"
                Else
                    W2351.MaterialInBoundNo = "WP" & YRNO & Format(CInt(rd!MAX_MCODE + 1), "00000")

                End If

            ElseIf cmb_CheckInBoundMaterial.PeaceCombobox1.SelectedIndex = 3 Then

                If IsDBNull(rd!MAX_MCODE) Then
                    W2351.MaterialInBoundNo = "WI" & YRNO & "00001"
                Else
                    W2351.MaterialInBoundNo = "WI" & YRNO & Format(CInt(rd!MAX_MCODE + 1), "00000")

                End If

            ElseIf cmb_CheckInBoundMaterial.PeaceCombobox1.SelectedIndex = 4 Then

                If IsDBNull(rd!MAX_MCODE) Then
                    W2351.MaterialInBoundNo = "WT" & YRNO & "00001"
                Else
                    W2351.MaterialInBoundNo = "WT" & YRNO & Format(CInt(rd!MAX_MCODE + 1), "00000")

                End If

            ElseIf cmb_CheckInBoundMaterial.PeaceCombobox1.SelectedIndex = 5 Then

                If IsDBNull(rd!MAX_MCODE) Then
                    W2351.MaterialInBoundNo = "WL" & YRNO & "00001"
                Else
                    W2351.MaterialInBoundNo = "WL" & YRNO & Format(CInt(rd!MAX_MCODE + 1), "00000")

                End If

            ElseIf cmb_CheckInBoundMaterial.PeaceCombobox1.SelectedIndex = 6 Then

                If IsDBNull(rd!MAX_MCODE) Then
                    W2351.MaterialInBoundNo = "WH" & YRNO & "00001"
                Else
                    W2351.MaterialInBoundNo = "WH" & YRNO & Format(CInt(rd!MAX_MCODE + 1), "00000")

                End If
            ElseIf cmb_CheckInBoundMaterial.PeaceCombobox1.SelectedIndex = 7 Then

                If IsDBNull(rd!MAX_MCODE) Then
                    W2351.MaterialInBoundNo = "WR" & YRNO & "00001"
                Else
                    W2351.MaterialInBoundNo = "WR" & YRNO & Format(CInt(rd!MAX_MCODE + 1), "00000")

                End If

            End If


            txt_MaterialInBoundNo.Data = W2351.MaterialInBoundNo
            L2351.MaterialInBoundNo = W2351.MaterialInBoundNo

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub


    Private Sub DATA_INIT()
        Try
            txt_MaterialInBoundNo.Enabled = False
            Call D2351_CLEAR()

            txt_DateInBoundMaterial.Data = System_Date_8()
            txt_DateExchange.Data = System_Date_8()

            If READ_PFK7411(Pub.SAW) Then
                txt_InchargeInBound.Data = D7411.Name
                txt_InchargeInBound.Code = D7411.IDNO
            End If

            txt_DatePosted.Data = Pub.DAT
            W2351 = D2351

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()
        chk_Size.Checked = False
        chk_Size.Visible = False

        Vs1.InsChk = False
        vS2.InsChk = False
        vS3.InsChk = False
    End Sub
    Private Sub vS2_DATA_INSERT(xrow As Integer)
        Try
            setData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundNo"), xrow, getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundNo"), 0))
            setData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundSeq"), xrow, getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundSeq"), 0))
            setData(vS2, getColumIndex(vS2, "PackInBound"), xrow, 1)
            setData(vS2, getColumIndex(vS2, "QtyInbound"), xrow, 0)

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "Event"
    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim i As Integer

        Try
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getDataM(Vs1, getColumIndex(Vs1, "DCHK"), i) <> "1" Then GoTo skip
                If getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i).ToString.Trim = "" Then MsgBoxP("MaterialCode at Row " & (i + 1)) : Exit Function
                'If getData(Vs1, getColumIndex(Vs1, "cdUnitPrice"), i).ToString.Trim = "" Then MsgBoxP("Unit Price at Row " & (i + 1)) : Exit Function
                If getData(Vs1, getColumIndex(Vs1, "cdUnitMaterial"), i).ToString.Trim = "" Then MsgBoxP("Unit Material at Row " & (i + 1)) : Exit Function
                If getData(Vs1, getColumIndex(Vs1, "cdUnitPacking"), i).ToString.Trim = "" Then MsgBoxP("Unit Packing at Row " & (i + 1)) : Exit Function

                'If getData(Vs1, getColumIndex(Vs1, "WareHousePosition"), i).ToString.Trim = "" Then MsgBoxP("Position at Row " & (i + 1)) : Exit Function

                If CIntp(getData(Vs1, getColumIndex(Vs1, "PackInBound"), i)) <= 0 Then MsgBoxP("Pack <=0 at Row " & (i + 1)) : Exit Function
skip:
            Next

            Data_Check = True
        Catch ex As Exception

        End Try
    End Function
    Private Sub DATA_CLOSE()
        Try
            Call PrcExeNoError(" EXP_CLOSSING_PFK2351C", cn, txt_MaterialInBoundNo.Data)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Sub
                If DataCheck(Me, "PFK2351") = False Then Exit Sub

                Call DATA_INSERT()
                Call DATA_CLOSE()

                Call DATA_SEARCH_vS2()
                Call DATA_SEARCH_vS3()
            Case 2
                Me.Dispose()

            Case 3
                If Data_Check() = False Then Exit Sub
                If DataCheck(Me, "PFK2351") = False Then Exit Sub

                If READ_PFK3429_MaterialInBoundNo(txt_MaterialInBoundNo.Data, "") = True Then
                    MsgBox("Already make Payable can't modify !")
                    Exit Sub
                End If

                Call DATA_UPDATE()
                Call DATA_CLOSE()

                Call DATA_SEARCH_vS1()
                Call DATA_SEARCH_vS2()
                Call DATA_SEARCH_vS3()

            Case 4

                If READ_PFK3429_MaterialInBoundNo(txt_MaterialInBoundNo.Data, "") = True Then
                    MsgBox("Already make Payable can't modify !")
                    Exit Sub
                End If

                Call DATA_DELETE()
                Call DATA_CLOSE()
                Me.Dispose()

            Case 11
                If Data_Check() = False Then Exit Sub
                If DataCheck(Me, "PFK2351") = False Then Exit Sub

                If READ_PFK3429_MaterialInBoundNo(txt_MaterialInBoundNo.Data, "") = True Then
                    MsgBox("Already make Payable can't modify !")
                    Exit Sub
                End If

                Call DATA_INSERT()
                Call DATA_CLOSE()

                Call DATA_SEARCH_vS2()
                Call DATA_SEARCH_vS3()
        End Select
    End Sub
    Private Sub cmd_UpdateRoll_Click(sender As Object, e As EventArgs) Handles cmd_UpdateRoll.Click
        Dim MaterialInBoundNo As String
        Dim MaterialInBoundSeq As String

        MaterialInBoundNo = getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundNo"), vS2.ActiveSheet.ActiveRowIndex)
        MaterialInBoundSeq = getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundSeq"), vS2.ActiveSheet.ActiveRowIndex)

        If READ_PFK2351(MaterialInBoundNo, MaterialInBoundSeq) = False Then Exit Sub

        If READ_PFK3429_MaterialInBoundNo(MaterialInBoundNo, MaterialInBoundSeq) = True Then
            MsgBox("Already make Payable can't modify !")
            Exit Sub
        End If

        If DATA_MOVE_WRITE02() = True Then
            MsgBoxP("Update Roll Sucessfully!", vbInformation)
            isudCHK = True
            Call DATA_SEARCH_vS2()
            Call DATA_SEARCH_vS1()
        End If
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

        If READ_PFK3429_MaterialInBoundNo(txt_MaterialInBoundNo.Data, "") = True Then
            MsgBox("Already make Payable can't modify !")
            Exit Sub
        End If

        Call DATA_DELETE()
        Call DATA_CLOSE()
        Me.Dispose()
    End Sub

    Private Sub Vs1_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles Vs1.ButtonClicked
        Dim xrow As Integer
        xrow = e.Row

        Select Case e.Column
            Case getColumIndex(Vs1, "MaterialCode")
                'Later    Dim f As New Form
                'f = New HLP3131A
                'f.ShowDialog()

                'If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub

                'setData(Vs1, getColumIndex(Vs1, "RequestPurchasingNo"), xrow, D3132.RequestPurchasingNo)
                'setData(Vs1, getColumIndex(Vs1, "RequestPurchasingSeq"), xrow, D3132.RequestPurchasingSeq)

                'If READ_PFK3132(D3132.RequestPurchasingNo, D3132.RequestPurchasingSeq) = True Then
                '    setData(Vs1, getColumIndex(Vs1, "MaterialCode"), xrow, D3132.MaterialCode)
                'End If

                'setData(Vs1, getColumIndex(Vs1, "cdUnitPriceMaterial"), xrow, "001")
                'setData(Vs1, getColumIndex(Vs1, "cdUnitPriceMaterialName"), xrow, "USD")

            Case getColumIndex(Vs1, "cdUnitPriceMaterial")
                Call HLPCHECK("Const_UnitPrice")

                If hlp0000SeVa = "" Or hlp0000SeVaTt = "" Then Exit Sub
                setData(Vs1, getColumIndex(Vs1, "cdUnitPriceMaterial"), xrow, hlp0000SeVaTt)
                setData(Vs1, getColumIndex(Vs1, "cdUnitPriceMaterialName"), xrow, hlp0000SeVa)

                setData(Vs1, getColumIndex(Vs1, "TaxImport"), xrow, ImportTax)
                setData(Vs1, getColumIndex(Vs1, "TaxVat"), xrow, VatTax)

        End Select

        vSChange(e.Row)

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

    Private Sub Vs2_Change(sender As Object, e As ChangeEventArgs) Handles vS2.Change
        Dim xCOL As Long
        Dim xROW As Long

        Try

            xROW = e.Row
            xCOL = e.Column

            'vS2Change(xROW)

        Catch ex As Exception

        End Try

    End Sub
    Private Sub vSChange(xROW As Integer)

    End Sub
    Private Sub vS2Change(xROW As Integer)
        Try
            Dim MaterialInBoundNo As String
            Dim MaterialInBoundSeq As String
            Dim MaterialInBoundSno As String

            MaterialInBoundNo = getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundNo"), xROW)
            MaterialInBoundSeq = getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundSeq"), xROW)
            MaterialInBoundSno = getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundSno"), xROW)

            If READ_PFK2352(MaterialInBoundNo, MaterialInBoundSeq, MaterialInBoundSno) Then
                If W2352.CheckPrint <> "1" Then
                    W2352 = D2352
                    W2352.QtyInBound = getData(vS2, getColumIndex(vS2, "QtyInBound"), xROW)
                    W2352.QtyInBoundQC = getData(vS2, getColumIndex(vS2, "QtyInBoundQC"), xROW)

                    If REWRITE_PFK2352(W2352) Then
                        If READ_PFK2351(MaterialInBoundNo, MaterialInBoundSeq) Then
                            setData(Vs1, getColumIndex(Vs1, "QtyInbound"), Vs1.ActiveSheet.ActiveRowIndex, D2351.QtyInBound)
                        End If
                    End If

                End If

            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column

        If e.Column = getColumIndex(Vs1, "DChk") Or e.Column = getColumIndex(Vs1, "CLcdWareHousePosition") Or e.Column = getColumIndex(Vs1, "CLcdWareHouseGroup") Then
            Vs1.ActiveSheet.OperationMode = OperationMode.Normal

        ElseIf (e.Column = getColumIndex(Vs1, "QtyBasic") Or e.Column = getColumIndex(Vs1, "PackInBound")) And (wJOB = 1 Or wJOB = 11) Then
            Vs1.ActiveSheet.OperationMode = OperationMode.Normal
        Else
            Vs1.ActiveSheet.OperationMode = OperationMode.SingleSelect
            Call DATA_SEARCH_vS2()
        End If
    End Sub

    Private Sub Vs1_CelldoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column

        If e.Column = getColumIndex(Vs1, "MaterialName") Then
            If ISUD7231SP.Link_ISUD7231SP(3, getData(Vs1, getColumIndex(Vs1, "MaterialCode"), e.Row), "PFP72310") Then

            End If
        Else
            Call DATA_SEARCH_vS2()
        End If

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


                Call K2351_MOVE(Vs1, xROW, W2351, txt_MaterialInBoundNo.Data, getData(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundSeq"), xROW))

                If W2351.MaterialInBoundSeq <> "0" Then

                    W2351.MaterialInBoundNo = txt_MaterialInBoundNo.Data
                    W2351.MaterialInBoundSeq = getDataM(Vs1, getColumIndex(Vs1, "KEY_MaterialInBoundSeq"), xROW)

                    If W2351.QtyInBound > 0 Then
                        MsgBoxP("Inbound Data Already") : Exit Sub
                    End If

                    If READ_PFK3429_MaterialInBoundNo(W2351.MaterialInBoundNo, W2351.MaterialInBoundSeq) = True Then
                        MsgBox("Already make Payable can't modify !")
                        Exit Sub
                    End If
                    If PrcExeNoError("USP_ISUD2352A_ROWNUMBER_DELETE", cn, W2351.MaterialInBoundNo, W2351.MaterialInBoundSeq) Then
                        Call DELETE_PFK2351(W2351)
                        Call Delete_History("PFK2351", W2351.MaterialInBoundNo)

                    End If

                End If

                SPR_DEL(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
                Vs1.Focus()

            Case Keys.Enter
                vSChange(xROW)
        End Select
    End Sub
    Private Sub txt_DateExchange_Load(sender As Object, e As EventArgs) Handles txt_DateExchange.m_Textchange
        Try

        Catch ex As Exception

        End Try

    End Sub


    Private Sub cmd_BARCODE_Click(sender As Object, e As EventArgs) Handles cmd_BARCODE.Click
        Dim Msg_Result As String
        Dim i As Integer
        Try
            Msg_Result = MsgBoxP("TAG PRINT?", vbYesNo)
            If Msg_Result = vbYes Then
                For i = 0 To vS2.ActiveSheet.RowCount - 1
                    If getDataM(vS2, getColumIndex(vS2, "DCHK"), i) = "1" Then

                        Call DATA_MOVE_BARCODE(getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundNo"), i),
                                               getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundSeq"), i),
                                               getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundSno"), i))


                        If READ_PFK2352(getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundNo"), i),
                                               getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundSeq"), i),
                                               getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundSno"), i)) Then
                            W2352 = D2352
                            W2352.CheckPrint = "1"
                            W2352.TimePrint = System_Date_time()

                            Call REWRITE_PFK2352(W2352)
                        End If
                    End If
                Next i
            End If
        Catch ex As Exception
            MsgBoxP("DATA_MOVE_BARCODE")
        End Try

    End Sub

    Public Sub DATA_MOVE_BARCODE(MaterialInBoundNo As String, MaterialInBoundSeq As String, MaterialInBoundSno As String)
        DS1 = PrcDS("USP_ISUD2352A_SEARCH_PRINT", cn, MaterialInBoundNo, MaterialInBoundSeq, MaterialInBoundSno)
        If GetDsRc(DS1) = 0 Then MsgBoxP("No data!") : Exit Sub

        MATERIAL.PRNo = GetDsData(DS1, 0, "PRNo")
        MATERIAL.MaterialInBoundSno = MaterialInBoundSno

        MATERIAL.MaterialCode = GetDsData(DS1, 0, "MaterialCode")
        MATERIAL.MaterialName = GetDsData(DS1, 0, "MaterialName")
        MATERIAL.cdUnitMaterialName = GetDsData(DS1, 0, "cdUnitMaterialName")
        MATERIAL.cdUnitPackingName = GetDsData(DS1, 0, "cdUnitPackingName")

        MATERIAL.DateInBoundMaterial = GetDsData(DS1, 0, "DateInBoundMaterial")

        MATERIAL.PackInBound = GetDsData(DS1, 0, "PackInBound")
        MATERIAL.QtyInBound = GetDsData(DS1, 0, "QtyInBound")
        MATERIAL.InvoiceNo = GetDsData(DS1, 0, "InvoiceNo")

        MATERIAL.InchargeInBoundName = GetDsData(DS1, 0, "InchargeInBoundName")
        MATERIAL.SupplierName = GetDsData(DS1, 0, "SupplierCodeName")

        MATERIAL.CheckInBoundMaterial = GetDsData(DS1, 0, "CheckInBoundMaterial")
        MATERIAL.CheckMaterialType = GetDsData(DS1, 0, "CheckMaterialType")
        MATERIAL.CheckMarketType = GetDsData(DS1, 0, "CheckMarketType")

        MATERIAL.Barcode = GetDsData(DS1, 0, "Barcode")
        MATERIAL.ColorName = GetDsData(DS1, 0, "ColorName")

        Try
            If chk_Preview = False And chk_PreviewBox.Checked = False Then
                PrintDocument1 = New Printing.PrintDocument
                PrintDocument1.Print()

            Else
                Call frm_PrintPreview.LINKDATA(MATERIAL.MaterialCode)

                PrintPreviewDialog1 = New PrintPreviewDialog
                PrintPreviewDialog1.Document = PrintDocument1

                PrintPreviewDialog1.ShowDialog()
            End If
        Catch ex As Exception
            MsgBoxP("DATA_MOVE_BARCODE")
        End Try

    End Sub

    Public Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        gpp = e.Graphics
        Call TAG_PRINT_MATERIAL_NEW_F2()
    End Sub

    Private Sub txt_PriceExchange_txtTextChanged(sender As Object, e As EventArgs) Handles txt_PriceExchange.txtTextChanged, txt_cdUnitPrice.txtTextChange
        If formA = False Then Exit Sub
        Dim i As Integer
        Try

            If READ_PFK7199(txt_DateExchange.Data, ListCode("UnitPrice"), txt_cdUnitPrice.Code) Then
                txt_PriceExchange.Data = D7199.Value

            End If

        Catch ex As Exception

        End Try


    End Sub


    Private Sub vS2_CellClick(sender As Object, e As CellClickEventArgs) Handles vS2.CellClick
        If e.ColumnHeader = True And e.Column = getColumIndex(vS2, "dchk") Then
            SPR_HEADCHK(vS2, e, e.Column)
        End If
    End Sub

    Private Sub vS2_KeyDown(sender As Object, e As KeyEventArgs) Handles vS2.KeyDown
        Dim xCOL As Long
        Dim xROW As Long

        xCOL = vS2.ActiveSheet.ActiveColumnIndex
        xROW = vS2.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Enter

                'If READ_PFK2352(getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundNo"), xROW),
                '                  getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundSeq"), xROW),
                '                  getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundSno"), xROW)) = True Then
                '    W2352 = D2352
                '    W2352.QtyInBoundQC = getData(vS2, getColumIndex(vS2, "QtyInBoundQC"), xROW)
                '    W2352.QtyInBound = getData(vS2, getColumIndex(vS2, "QtyInBound"), xROW)

                '    If READ_PFK3429_MaterialInBoundNo(W2352.MaterialInBoundNo, W2352.MaterialInBoundSeq) = True Then
                '        MsgBox("Already make Payable can't modify !")
                '        Exit Sub
                '    End If

                '    Call REWRITE_PFK2352(W2352)
                'End If


            Case Keys.Delete
                Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)
                If Msg_Result <> vbYes Then Exit Sub

                If READ_PFK2352(getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundNo"), xROW),
                                getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundSeq"), xROW),
                                getData(vS2, getColumIndex(vS2, "KEY_MaterialInBoundSno"), xROW)) = True Then

                    W2352 = D2352

                    If READ_PFK3429_MaterialInBoundNo(W2352.MaterialInBoundNo, W2352.MaterialInBoundSeq) = True Then
                        MsgBox("Already make Payable can't modify !")
                        Exit Sub
                    End If

                    If W2352.QtyOutBound > 0 Then MsgBoxP("Already Outbound!") : Exit Sub
                    If DELETE_PFK2352(W2352) Then
                        SPR_DEL(vS2, 0, vS2.ActiveSheet.ActiveRowIndex)
                        If READ_PFK2351(W2352.MaterialInBoundNo, W2352.MaterialInBoundSeq) Then
                            setData(Vs1, getColumIndex(Vs1, "PackInBound"), Vs1.ActiveSheet.ActiveRowIndex, D2351.PackInBound)
                            setData(Vs1, getColumIndex(Vs1, "QtyInbound"), Vs1.ActiveSheet.ActiveRowIndex, D2351.QtyInBound)
                        End If

                        Call Delete_History("PFK2352", W2352.MaterialInBoundNo & "-" & W2352.MaterialInBoundSeq)

                    End If
                End If



        End Select

    End Sub

    Private Sub PeaceCheckbox1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_PreviewBox.CheckedChanged
        If chk_PreviewBox.Checked = True Then
            chk_Preview = True
        Else
            chk_Preview = False
        End If
    End Sub

    Private Sub chk_Size_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Size.CheckedChanged
        If chk_Size.Checked = False Then
            SplitContainer1.Panel2Collapsed = True
        ElseIf chk_Size.Checked = True Then
            SplitContainer1.Panel2Collapsed = False
        End If
    End Sub

#End Region
End Class