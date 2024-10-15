Public Class ISUD7110E
#Region "Variable"
    Private wJOB As Integer
    Private W7231 As T7231_AREA

    Private W7109 As T7109_AREA
    Private L7109 As T7109_AREA

    Private W7108 As T7108_AREA
    Private L7108 As T7108_AREA

    Private W7106 As T7106_AREA
    Private L7106 As T7106_AREA

    Private W7115 As T7115_AREA
    Private L7115 As T7115_AREA

    Private W7116 As T7116_AREA
    Private L7116 As T7116_AREA

    Private WRITE_CHK As String
    Private ChkUpload As Boolean = False
    Private cdGroupComponent As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7110E(job As Integer, ShoesCode As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D7106.ShoesCode = ShoesCode
        D7110.ShoesCode = ShoesCode

        txt_ShoesCode.Data = ShoesCode
        txt_ShoesCode.Code = ShoesCode

        wJOB = job : L7106 = D7106

        If READ_PFK7106(ShoesCode) = False Then Link_ISUD7110E = False : Exit Function
        If D7106.CheckComplete = "1" Then MsgBoxP("Already complete! Đã hoàn thành !", vbInformation)


        Link_ISUD7110E = False

        Try
            Select Case job
                Case 1
                Case Else

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7110E = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("BaseComponentBOM"))
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

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
                Call Default_Search_Combobox()

                vS1.Select()
            Case 2
                Me.Text = Me.Text & " - SEARCH"
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
                Call Default_Search_Combobox()


                cmd_DEL.Visible = False
                tst_All.Visible = False

                vS1.Select()
            Case 3
                Me.Text = Me.Text & " - UPDATE"

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

                Call Default_Search_Combobox()

                vS1.Select()
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
                        Call MsgBoxP("16", "Form_Activate")
                    End If
                End If

            Case 4                                                      '»èÁ¦
                Me.Text = Me.Text & " - DELETE"

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

                Call Default_Search_Combobox()
                vS1.Select()
        End Select

        formA = True
    End Sub

    Private Sub Default_Search_Combobox()


    End Sub


    Private Sub DATA_INIT()
        Try

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()
        Me.WindowState = FormWindowState.Maximized

    End Sub
    Private Sub PFP17811_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub

    Overrides Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey
                Case Keys.F5 : Call tst_1.PerformClick()
                Case Keys.F6 : Call tst_2.PerformClick()
                Case Keys.F7 : Call tst_3.PerformClick()
                Case Keys.F8 : Call tst_4.PerformClick()
            End Select
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Data_Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        If READ_PFK7115_SHOESCODE(L7106.ShoesCode) Then
            txt_cdUnitPrice.Code = D7115.cdUnitPrice
            txt_cdUnitPriceLocal.Code = D7115.cdUnitPriceLocal

            Call READ_PFK7171(ListCode("UnitPrice"), D7115.cdUnitPrice)
            txt_cdUnitPrice.Data = D7171.BasicName
            Call READ_PFK7171(ListCode("UnitPriceLocal"), D7115.cdUnitPriceLocal)
            txt_cdUnitPriceLocal.Data = D7171.BasicName


            txt_PriceExchange.Data = CDecp(D7115.PriceExchange)
            txt_ProfitRate.Value = CDecp(D7115.ProfitRate)

            chk_CheckProfitAmt.Checked = CboolP(D7115.CheckProfitAmt)
            txt_ProfitAmt.Data = CDecp(D7115.ProfitAmt)

        End If

        DATA_SEARCH01 = True

    End Function


    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        DS1 = PrcDS("USP_ISUD7110D_SEARCH_VS1", cn, L7106.ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS1, DS1, "USP_ISUD7110D_SEARCH_VS1", "VS1")


            vS1.ActiveSheet.RowCount = 1
            vS1.Enabled = True
            Exit Function
        End If
        SPR_PRO_NEW(vS1, DS1, "USP_ISUD7110D_SEARCH_VS1", "VS1")
        vS1.ActiveSheet.AddSelection(0, 0, 1, 1)

        DATA_SEARCH_VS1 = True

    End Function



    Private Function BaseComponentBOMList() As String
        BaseComponentBOMList = ""

        Dim i As Integer

        For i = 0 To vS1.ActiveSheet.RowCount - 1
            BaseComponentBOMList = BaseComponentBOMList & "''" & getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), i) & "''"
            BaseComponentBOMList = BaseComponentBOMList & ","
next1:
        Next

        If BaseComponentBOMList = "" Then Exit Function
        BaseComponentBOMList = Strings.Left(BaseComponentBOMList, Len(BaseComponentBOMList) - 1)

    End Function
    Private Function DATA_SEARCH_VS2() As Boolean
        DATA_SEARCH_VS2 = False
        Dim ShoesCode As String

        ShoesCode = getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), vS1.ActiveSheet.ActiveRowIndex)

        DS1 = PrcDS("USP_ISUD7110E_SEARCH_VS2", cn, ShoesCode)


        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS2, DS1, "USP_ISUD7110E_SEARCH_VS2", "VS2")
            Call SPR_SearchType(vS2, SearchType.Material)
            vS2.ActiveSheet.RowCount = 1
            vS2.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS2, DS1, "USP_ISUD7110E_SEARCH_VS2", "VS2")
        Call SPR_SearchType(vS2, SearchType.Material)

    End Function

    Private Function DATA_SEARCH_VS2_NO() As Boolean
        DATA_SEARCH_VS2_NO = False
        Dim i As Integer
        If BaseComponentBOMList() = "" Then Exit Function

        If chk_FullBase.Checked = False Then

            Dim Starting As Object

            Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

            Try
                DS1 = PrcDS("USP_ISUD7110D_SEARCH_VS2_NO", cn, BaseComponentBOMList)

                If GetDsRc(DS1) = 0 Then
                    SPR_PRO_NEW(vS2, DS1, "USP_ISUD7110D_SEARCH_VS2_NO", "VS2")
                    vS2.Enabled = True
                    Exit Function
                End If

                SPR_PRO_NEW(vS2, DS1, "USP_ISUD7110D_SEARCH_VS2_NO", "VS2")

                DATA_SEARCH_VS2_NO = True

            Catch ex As Exception

            Finally
                Starting.close()
            End Try

        End If

    End Function

    Private Function DATA_SEARCH_VS31() As Boolean
        DATA_SEARCH_VS31 = False

        DS1 = PrcDS("USP_ISUD7110D_SEARCH_VS31", cn, W7108.ShoesCode, "1")

        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_ISUD7110D_SEARCH_VS31_INSERT", cn, ListCode("CBDCost"), "1")
            SPR_PRO_NEW(vS31, DS2, "USP_ISUD7110D_SEARCH_VS31", "vS31")
            SPR_INSERT(vS31)
            Exit Function
        End If

        SPR_PRO_NEW(vS31, DS1, "USP_ISUD7110D_SEARCH_VS31", "VS31")

        DATA_SEARCH_VS31 = True
    End Function

    Private Function DATA_SEARCH_VS32() As Boolean
        DATA_SEARCH_VS32 = False

        DS1 = PrcDS("USP_ISUD7110D_SEARCH_VS32", cn, W7108.ShoesCode, "2")

        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_ISUD7110D_SEARCH_VS32_INSERT", cn, ListCode("CBDCost"), "2")
            SPR_PRO_NEW(vS32, DS2, "USP_ISUD7110D_SEARCH_VS32", "VS32")
            SPR_INSERT(vS32)
            Exit Function
        End If
        SPR_PRO_NEW(vS32, DS1, "USP_ISUD7110D_SEARCH_VS32", "VS32")

        DATA_SEARCH_VS32 = True
    End Function

    Private Function DATA_SEARCH_VS33() As Boolean
        DATA_SEARCH_VS33 = False

        DS1 = PrcDS("USP_ISUD7110D_SEARCH_VS33", cn, W7108.ShoesCode, "3")

        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_ISUD7110D_SEARCH_VS33_INSERT", cn, ListCode("CBDCost"), "3")
            SPR_PRO_NEW(vS33, DS2, "USP_ISUD7110D_SEARCH_VS33", "VS33")
            SPR_INSERT(vS33)
            Exit Function
        End If
        SPR_PRO_NEW(vS33, DS1, "USP_ISUD7110D_SEARCH_VS33", "VS33")

        DATA_SEARCH_VS33 = True
    End Function
    Private Function DATA_SEARCH_VS4() As Boolean
        DATA_SEARCH_VS4 = False

        DS1 = PrcDS("USP_ISUD7110D_SEARCH_VS4", cn, W7108.ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS4, DS1, "USP_ISUD7110D_SEARCH_VS4", "VS4")
            vS4.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS4, DS1, "USP_ISUD7110D_SEARCH_VS4", "VS4")
        DATA_SEARCH_VS4 = True
    End Function

    Private Function DATA_SEARCH_VS5() As Boolean
        DATA_SEARCH_VS5 = False

        DS1 = PrcDS("USP_ISUD7110D_SEARCH_VS5", cn, L7106.ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS5, DS1, "USP_ISUD7110D_SEARCH_VS5", "VS5")
            vS5.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS5, DS1, "USP_ISUD7110D_SEARCH_VS5", "VS5")
        DATA_SEARCH_VS5 = True
    End Function

#End Region

#Region "Function"

    Private Function Data_Check() As Boolean
        Data_Check = False

        Data_Check = True
    End Function


    Private Sub DATA_MOVE()
        Try
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE"))
        End Try
    End Sub

    Private Sub DATA_MOVE_WRITE01()
        Try


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub

    Private Sub DATA_MOVE_WRITE_NO_UPLOAD()
        Try


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub

    Private Sub DATA_DELETE()
        Try
            Dim j As Integer
            Dim i As Integer

            For i = 0 To vS2.ActiveSheet.RowCount - 1
                j = j + 1

                Call D7109_CLEAR() : W7109 = D7109

                W7109.GroupComponentBOM = W7108.GroupComponentBOM
                W7109.GroupComponentSeq = CIntp(getData(vS2, getColumIndex(vS2, "KEY_GroupComponentSeq"), i))

                If READ_PFK7109(W7109.GroupComponentBOM, W7109.GroupComponentSeq) = False Then

                    W7109 = D7109
                    Call DELETE_PFK7109(W7109)
                End If
            Next
        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub
    Private Sub KEY_COUNT_K7109_SEQ()
        Try

            SQL = " SELECT MAX(K7109_GroupComponentSeq) as MAX_CODE FROM PFK7109 "
            SQL = SQL & " WHERE K7109_GroupComponentBOM  = '" & W7108.GroupComponentBOM & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W7109.GroupComponentSeq = 1
            Else
                W7109.GroupComponentSeq = CIntp(rd!MAX_CODE + 1)
            End If

            rd.Close()

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub KEY_COUNT_K7108()
        Try

            SQL = " SELECT MAX(CAST(K7108_GroupComponentBOM AS DECIMAL)) as MAX_CODE FROM PFK7108 "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W7108.GroupComponentBOM = "000001"
            Else
                W7108.GroupComponentBOM = Format(CIntp(rd!MAX_CODE + 1), "000000")
            End If

            rd.Close()

            L7108.GroupComponentBOM = W7108.GroupComponentBOM

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub
    Private Function CheckData() As Boolean
        CheckData = False
        Try
            Dim i As Integer

            For i = 0 To vS2.ActiveSheet.RowCount - 1
                If READ_PFK7103_TYPENAME("003", getData(vS2, getColumIndex(vS2, "ComponentName"), i)) And getData(vS2, getColumIndex(vS2, "ComponentName"), i) <> "" Then

                End If
            Next

            CheckData = True
        Catch ex As Exception

        End Try
    End Function

    Private Function DATA_MOVE_K7109() As Boolean
        Dim j As Integer
        Dim i As Integer
        Dim tmpSTR1 As String = ""
        Dim tmpSTR2 As String = ""
        Dim k As Integer
        Dim l As Integer

        DATA_MOVE_K7109 = False
        'later

        Try
            W7108.ShoesCode = getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), vS1.ActiveSheet.ActiveRowIndex)

            If READ_PFK7108_SHOESCODE(W7108.ShoesCode) = False Then
                Call KEY_COUNT_K7108()
                W7108.InchargeInsert = Pub.SAW

                If WRITE_PFK7108(W7108) = True Then
                    If READ_PFK7106(W7108.ShoesCode) Then
                        D7106.InchargeCBD_I = Pub.SAW
                        Call REWRITE_PFK7106(D7106)
                    End If

                    For i = 0 To vS2.ActiveSheet.RowCount - 1
                        j = j + 1

                        Call D7109_CLEAR() : W7109 = D7109

                        W7109.GroupComponentBOM = W7108.GroupComponentBOM
                        W7109.GroupComponentSeq = CIntp(getData(vS2, getColumIndex(vS2, "KEY_GroupComponentSeq"), i))
                        W7109.PriceMaterial = CIntp(getData(vS2, getColumIndex(vS2, "PriceMaterial"), i))

                        If K7109_MOVE(vS2, i, W7109, W7109.GroupComponentBOM, W7109.GroupComponentSeq) = False Then
                            W7109.GroupComponentBOM = W7108.GroupComponentBOM

                            Call KEY_COUNT_K7109_SEQ()

                            W7109.Dseq = j

                            W7109.selGroupComponent = ListCode("GroupComponent")
                            W7109.seDepartment = ListCode("Department")
                            W7109.seShoesStatus = ListCode("ShoesStatus")
                            W7109.seUnitMaterial = ListCode("UnitMaterial")
                            W7109.seSubProcess = ListCode("SubProcess")
                            W7109.seSpecialProcess = ListCode("SpecialProcess")

                            W7109.GrossUsage = W7109.Consumption * (1 + W7109.Loss / 100)

                            If getData(vS2, getColumIndex(vS2, "KEY_ProcessSeq"), i) = " " Then
                                W7109.ProcessSeq = j
                            Else
                                W7109.ProcessSeq = getData(vS2, getColumIndex(vS2, "KEY_ProcessSeq"), i)
                            End If

                            tmpSTR1 = W7109.ProcessSeq

                            If i <> 0 And tmpSTR1 <> tmpSTR2 And tmpSTR1 <> "" And tmpSTR2 <> "" Then
                                l = l - 1
                                W7109.ProcessSeq = l
                            End If

                            W7109.MaterialAMTSales = CDblp(getData(vS2, getColumIndex(vS2, "MaterialAMTSales"), i))

                            W7109.PriceRnD = W7109.PriceMaterial * (1 + W7109.ShippingRate / 100)
                            W7109.PriceRnD += W7109.ExchangeCost
                            W7109.PriceRnD += W7109.AddedCost
                            W7109.PriceRnD += W7109.ComplicationCost
                            W7109.PriceRnD += W7109.ShippingCost

                            W7109.MaterialAMT = W7109.GrossUsage * W7109.PriceRnD

                            If W7109.GrossUsage = "0" Then
                                W7109.Price = 0
                            Else
                                W7109.Price = W7109.MaterialAMTSales / W7109.GrossUsage
                            End If

                            Call WRITE_PFK7109(W7109)

                            tmpSTR2 = W7109.ProcessSeq

                        Else
                            W7109.selGroupComponent = ListCode("GroupComponent")
                            W7109.seDepartment = ListCode("Department")
                            W7109.seShoesStatus = ListCode("ShoesStatus")
                            W7109.seUnitMaterial = ListCode("UnitMaterial")
                            W7109.seSubProcess = ListCode("SubProcess")
                            W7109.seSpecialProcess = ListCode("SpecialProcess")

                            W7109.Dseq = j
                            W7109.GrossUsage = W7109.Consumption * (1 + W7109.Loss / 100)

                            If getData(vS2, getColumIndex(vS2, "KEY_ProcessSeq"), i) = " " Then
                                W7109.ProcessSeq = j
                            Else
                                W7109.ProcessSeq = getData(vS2, getColumIndex(vS2, "KEY_ProcessSeq"), i)
                            End If

                            tmpSTR1 = W7109.ProcessSeq

                            If i <> 0 And tmpSTR1 = tmpSTR2 Then
                                l = l - 1
                            End If

                            W7109.MaterialAMTSales = CDblp(getData(vS2, getColumIndex(vS2, "MaterialAMTSales"), i))

                            W7109.PriceRnD = W7109.PriceMaterial * (1 + W7109.ShippingRate / 100)
                            W7109.PriceRnD += W7109.ExchangeCost
                            W7109.PriceRnD += W7109.AddedCost
                            W7109.PriceRnD += W7109.ComplicationCost
                            W7109.PriceRnD += W7109.ShippingCost

                            W7109.MaterialAMT = W7109.GrossUsage * W7109.PriceRnD

                            If W7109.GrossUsage = "0" Then
                                W7109.Price = 0
                            Else
                                W7109.Price = W7109.MaterialAMTSales / W7109.GrossUsage
                            End If

                            Call REWRITE_PFK7109(W7109)

                            tmpSTR2 = W7109.ProcessSeq

                        End If
                    Next
                End If

            Else
                W7108 = D7108
                W7108.InchargeUpdate = Pub.SAW

                If REWRITE_PFK7108(W7108) Then
                    If READ_PFK7106(W7108.ShoesCode) Then
                        D7106.InchargeCBD_U = Pub.SAW
                        Call REWRITE_PFK7106(D7106)
                    End If
                End If

                For i = 0 To vS2.ActiveSheet.RowCount - 1
                    j = j + 1

                    Call D7109_CLEAR() : W7109 = D7109

                    W7109.GroupComponentBOM = W7108.GroupComponentBOM
                    W7109.GroupComponentSeq = CIntp(getData(vS2, getColumIndex(vS2, "KEY_GroupComponentSeq"), i))
                    W7109.PriceMaterial = CIntp(getData(vS2, getColumIndex(vS2, "PriceMaterial"), i))

                    If K7109_MOVE(vS2, i, W7109, W7109.GroupComponentBOM, W7109.GroupComponentSeq) = False Then
                        W7109.GroupComponentBOM = W7108.GroupComponentBOM

                        Call KEY_COUNT_K7109_SEQ()

                        W7109.Dseq = j

                        W7109.selGroupComponent = ListCode("GroupComponent")
                        W7109.seDepartment = ListCode("Department")
                        W7109.seShoesStatus = ListCode("ShoesStatus")
                        W7109.seUnitMaterial = ListCode("UnitMaterial")
                        W7109.seSubProcess = ListCode("SubProcess")
                        W7109.seSpecialProcess = ListCode("SpecialProcess")

                        W7109.GrossUsage = W7109.Consumption * (1 + W7109.Loss / 100)

                        W7109.MaterialAMTSales = CDblp(getData(vS2, getColumIndex(vS2, "MaterialAMTSales"), i))

                        W7109.PriceRnD = W7109.PriceMaterial * (1 + W7109.ShippingRate / 100)
                        W7109.PriceRnD += W7109.ExchangeCost
                        W7109.PriceRnD += W7109.AddedCost
                        W7109.PriceRnD += W7109.ComplicationCost
                        W7109.PriceRnD += W7109.ShippingCost

                        W7109.MaterialAMT = W7109.GrossUsage * W7109.PriceRnD

                        If W7109.GrossUsage = "0" Then
                            W7109.Price = 0
                        Else
                            W7109.Price = W7109.MaterialAMTSales / W7109.GrossUsage

                        End If

                        Call WRITE_PFK7109(W7109)
                    Else
                        W7109.selGroupComponent = ListCode("GroupComponent")
                        W7109.seDepartment = ListCode("Department")
                        W7109.seShoesStatus = ListCode("ShoesStatus")
                        W7109.seUnitMaterial = ListCode("UnitMaterial")
                        W7109.seSubProcess = ListCode("SubProcess")
                        W7109.seSpecialProcess = ListCode("SpecialProcess")

                        W7109.Dseq = j
                        W7109.GrossUsage = W7109.Consumption * (1 + W7109.Loss / 100)

                        If getData(vS2, getColumIndex(vS2, "KEY_ProcessSeq"), i) = " " Then
                            W7109.ProcessSeq = j
                        Else
                            W7109.ProcessSeq = getData(vS2, getColumIndex(vS2, "KEY_ProcessSeq"), i)
                        End If

                        tmpSTR1 = W7109.ProcessSeq

                        If i <> 0 And tmpSTR1 = tmpSTR2 Then
                            l = l - 1
                        End If

                        W7109.MaterialAMTSales = CDblp(getData(vS2, getColumIndex(vS2, "MaterialAMTSales"), i))

                        W7109.PriceRnD = W7109.PriceMaterial * (1 + W7109.ShippingRate / 100)
                        W7109.PriceRnD += W7109.ExchangeCost
                        W7109.PriceRnD += W7109.AddedCost
                        W7109.PriceRnD += W7109.ComplicationCost
                        W7109.PriceRnD += W7109.ShippingCost

                        W7109.MaterialAMT = W7109.GrossUsage * W7109.PriceRnD

                        If W7109.GrossUsage = "0" Then
                            W7109.Price = 0
                        Else
                            W7109.Price = W7109.MaterialAMTSales / W7109.GrossUsage

                        End If

                        Call REWRITE_PFK7109(W7109)

                        tmpSTR2 = W7109.ProcessSeq

                    End If
                Next

            End If



            DATA_MOVE_K7109 = True

        Catch ex As Exception
            MsgBoxP("DATA_MOVE_K7820!", vbCritical)
        End Try

    End Function

    Private Sub KEY_COUNT_MATERIAL()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader


        SQL = "SELECT MAX(CAST(K7231_MaterialCode AS DECIMAL)) AS MAX_CODE FROM PFK7231 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            W7231.MaterialCode = "000001"
        Else
            W7231.MaterialCode = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If


    End Sub

    Private Sub DATA_MOVE_DEFAULT()
        W7109.seDepartment = ListCode("Department")
        W7109.selGroupComponent = ListCode("GroupComponent")
        W7109.seShoesStatus = ListCode("ShoesStatus")
        W7109.seUnitMaterial = ListCode("UnitMaterial")
        W7109.seUnitPrice = ListCode("UnitPrice")
        W7109.seSubProcess = ListCode("SubProcess")
    End Sub

    Private Sub KEY_COUNT_7109()
        SQL = "SELECT MAX(CAST(K7109_MaterialSeq AS DECIMAL)) AS MAX_MCODE FROM PFK7109 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_MCODE) Then
            L7109.GroupComponentSeq = "1"
        Else
            L7109.GroupComponentSeq = Format(CInt(rd!MAX_MCODE + 1), "0")
        End If

        W7109.GroupComponentSeq = L7109.GroupComponentSeq

        rd.Close()
    End Sub




#End Region

#Region "Event"
    Private Sub KEY_COUNT()

        Try
            SQL = " SELECT MAX(CAST(K7115_CostBOM AS DECIMAL)) as MAX_CODE FROM PFK7115 "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W7115.CostBOM = "000001"
            Else
                W7115.CostBOM = Format(CIntp(rd!MAX_CODE + 1), "000000")
            End If

            rd.Close()

            L7115.CostBOM = W7115.CostBOM

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub DATA_INSERT()
        If READ_PFK7115_SHOESCODE(L7108.ShoesCode) = True Then
            W7115 = D7115
            W7115.ProfitRate = txt_ProfitRate.Value
            W7115.cdUnitPrice = txt_cdUnitPrice.Code
            W7115.cdUnitPriceLocal = txt_cdUnitPriceLocal.Code
            W7115.PriceExchange = CDecp(txt_PriceExchange.Data)

            W7115.ProfitAmt = CDecp(txt_ProfitAmt.Data)
            If (chk_CheckProfitAmt.Checked) Then
                W7115.CheckProfitAmt = "1"
            Else
                W7115.CheckProfitAmt = "2"
            End If

            W7115.seUnitPrice = ListCode("UnitPrice")
            W7115.seUnitPriceLocal = ListCode("UnitPriceLocal")

            If REWRITE_PFK7115(W7115) Then

            End If

        Else
            Call KEY_COUNT()
            Call DATA_MOVE()

            W7115.ProfitRate = txt_ProfitRate.Value
            W7115.cdUnitPrice = txt_cdUnitPrice.Code
            W7115.cdUnitPriceLocal = txt_cdUnitPriceLocal.Code
            W7115.PriceExchange = CDecp(txt_PriceExchange.Data)

            W7115.ProfitAmt = CDecp(txt_ProfitAmt.Data)
            If (chk_CheckProfitAmt.Checked) Then
                W7115.CheckProfitAmt = "1"
            Else
                W7115.CheckProfitAmt = "2"
            End If

            W7115.ShoesCode = L7106.ShoesCode
            W7115.seUnitPrice = ListCode("UnitPrice")
            W7115.seUnitPriceLocal = ListCode("UnitPriceLocal")

            If WRITE_PFK7115(W7115) = True Then


            End If
        End If
    End Sub
    Private Sub DATA_UPDATE()
        Try
            W7108.ShoesCode = getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), vS1.ActiveSheet.ActiveRowIndex)

            If READ_PFK7115_SHOESCODE(W7108.ShoesCode) = True Then
                W7115 = D7115
                W7115.ProfitRate = txt_ProfitRate.Value
                W7115.cdUnitPrice = txt_cdUnitPrice.Code
                W7115.cdUnitPriceLocal = txt_cdUnitPriceLocal.Code
                W7115.PriceExchange = CDecp(txt_PriceExchange.Data)

                W7115.ProfitAmt = CDecp(txt_ProfitAmt.Data)
                If (chk_CheckProfitAmt.Checked) Then
                    W7115.CheckProfitAmt = "1"
                Else
                    W7115.CheckProfitAmt = "2"
                End If

                W7115.seUnitPrice = ListCode("UnitPrice")
                W7115.seUnitPriceLocal = ListCode("UnitPriceLocal")

                If REWRITE_PFK7115(W7115) Then

                End If

            Else
                Call KEY_COUNT()
                Call DATA_MOVE()
                W7115.ProfitRate = txt_ProfitRate.Value
                W7115.cdUnitPrice = txt_cdUnitPrice.Code
                W7115.cdUnitPriceLocal = txt_cdUnitPriceLocal.Code
                W7115.PriceExchange = CDecp(txt_PriceExchange.Data)

                W7115.ProfitAmt = CDecp(txt_ProfitAmt.Data)
                If (chk_CheckProfitAmt.Checked) Then
                    W7115.CheckProfitAmt = "1"
                Else
                    W7115.CheckProfitAmt = "2"
                End If

                W7115.ShoesCode = W7108.ShoesCode
                W7115.seUnitPrice = ListCode("UnitPrice")
                W7115.seUnitPriceLocal = ListCode("UnitPriceLocal")

                If WRITE_PFK7115(W7115) = True Then


                End If
            End If

            If ptc_Main.SelectedIndex = 0 Then Call DATA_MOVE_K7109() : Call DATA_SEARCH_VS2()
            If ptc_Main.SelectedIndex = 1 Then
                If READ_PFK7115_SHOESCODE(L7106.ShoesCode) = True Then
                    W7115 = D7115
                    W7115.ProfitRate = txt_ProfitRate.Value
                    W7115.cdUnitPrice = txt_cdUnitPrice.Code
                    W7115.cdUnitPriceLocal = txt_cdUnitPriceLocal.Code
                    W7115.PriceExchange = CDecp(txt_PriceExchange.Data)


                    W7115.ProfitAmt = CDecp(txt_ProfitAmt.Data)
                    If (chk_CheckProfitAmt.Checked) Then
                        W7115.CheckProfitAmt = "1"
                    Else
                        W7115.CheckProfitAmt = "2"
                    End If

                    W7115.seUnitPrice = ListCode("UnitPrice")
                    W7115.seUnitPriceLocal = ListCode("UnitPriceLocal")

                    If REWRITE_PFK7115(W7115) Then
                        Call DATA_MOVE_WRITE031()
                        Call DATA_MOVE_WRITE032()
                        Call DATA_MOVE_WRITE033()

                        Call DATA_SEARCH_VS31()
                        Call DATA_SEARCH_VS32()
                        Call DATA_SEARCH_VS33()

                        isudCHK = True : WRITE_CHK = "*"
                    End If

                Else
                    Call KEY_COUNT()
                    Call DATA_MOVE()

                    W7115.ProfitRate = txt_ProfitRate.Value
                    W7115.cdUnitPrice = txt_cdUnitPrice.Code
                    W7115.cdUnitPriceLocal = txt_cdUnitPriceLocal.Code
                    W7115.PriceExchange = CDecp(txt_PriceExchange.Data)

                    W7115.ProfitAmt = CDecp(txt_ProfitAmt.Data)
                    If (chk_CheckProfitAmt.Checked) Then
                        W7115.CheckProfitAmt = "1"
                    Else
                        W7115.CheckProfitAmt = "2"
                    End If

                    W7115.ShoesCode = W7108.ShoesCode
                    W7115.seUnitPrice = ListCode("UnitPrice")
                    W7115.seUnitPriceLocal = ListCode("UnitPriceLocal")


                    If WRITE_PFK7115(W7115) = True Then
                        Call DATA_MOVE_WRITE031()
                        Call DATA_MOVE_WRITE032()
                        Call DATA_MOVE_WRITE033()

                        Call DATA_SEARCH_VS31()
                        Call DATA_SEARCH_VS32()
                        Call DATA_SEARCH_VS33()
                    End If
                End If

                Call DATA_UPDATE_USER(W7108.ShoesCode)

            End If

            If ptc_Main.SelectedIndex = 2 Then
                If READ_PFK7115_SHOESCODE(W7108.ShoesCode) = True Then
                    W7115 = D7115
                    W7115.ProfitRate = txt_ProfitRate.Value

                    If REWRITE_PFK7115(W7115) Then
                        isudCHK = True : WRITE_CHK = "*"
                    End If

                Else
                    Call KEY_COUNT()
                    Call DATA_MOVE()

                    W7115.ProfitRate = txt_ProfitRate.Value
                    W7115.cdUnitPrice = txt_cdUnitPrice.Code
                    W7115.cdUnitPriceLocal = txt_cdUnitPriceLocal.Code
                    W7115.PriceExchange = CDecp(txt_PriceExchange.Data)

                    W7115.ProfitAmt = CDecp(txt_ProfitAmt.Data)
                    If (chk_CheckProfitAmt.Checked) Then
                        W7115.CheckProfitAmt = "1"
                    Else
                        W7115.CheckProfitAmt = "2"
                    End If

                    W7115.ShoesCode = W7108.ShoesCode
                    W7115.seUnitPrice = ListCode("UnitPrice")
                    W7115.seUnitPriceLocal = ListCode("UnitPriceLocal")

                    If WRITE_PFK7115(W7115) = True Then

                    End If
                End If
                Call DATA_UPDATE_USER(W7108.ShoesCode)
                Call DATA_SEARCH_VS4()
            End If


        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_UPDATE_USER(ShoesCode As String)
        If READ_PFK7106(ShoesCode) = True Then

            W7106 = D7106

            W7106.InchargeCBD_U = Pub.SAW

            Call REWRITE_PFK7106(W7106)
        End If
    End Sub
    Private Sub DATA_MOVE_WRITE031()
        Try
            SQL = "DELETE FROM PFK7116 "
            SQL = SQL & " WHERE K7116_CostBOM  = '" & W7115.CostBOM & "' "
            SQL = SQL & " AND K7116_CostType  = '1' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            Dim i As Integer
            Dim j As Integer
            j = 0
            For i = 0 To vS31.ActiveSheet.RowCount - 1
                If getData(vS31, getColumIndex(vS31, "cdCBDCost"), i) = "" Then GoTo skip

                j = j + 1

                Call D7116_CLEAR() : W7116 = D7116
                Call K7116_MOVE(vS31, i, W7116, W7116.CostBOM, W7116.CostSeq, "1")

                W7116.CostBOM = W7115.CostBOM
                W7116.CostSeq = j
                W7116.Dseq = j
                W7116.CostType = "1"

                W7116.seCBDCost = ListCode("CBDCost")
                W7116.seCostingType = ListCode("CostingType")

                W7116.Price = CDecp(getData(vS31, getColumIndex(vS31, "Price"), i))
                W7116.QtyCost = CDecp(getData(vS31, getColumIndex(vS31, "QtyCost"), i))
                W7116.AMTCost = CDecp(W7116.Price * W7116.QtyCost)

                Call WRITE_PFK7116(W7116)
skip:
            Next


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub

    Private Sub DATA_MOVE_WRITE032()
        Try


            SQL = "DELETE FROM PFK7116 "
            SQL = SQL & " WHERE K7116_CostBOM  = '" & W7115.CostBOM & "' "
            SQL = SQL & " AND K7116_CostType  = '2' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            Dim i As Integer
            Dim j As Integer
            j = 0
            For i = 0 To vS32.ActiveSheet.RowCount - 1
                If getData(vS32, getColumIndex(vS32, "cdCBDCost"), i) = "" Then GoTo skip

                j = j + 1

                Call D7116_CLEAR() : W7116 = D7116
                Call K7116_MOVE(vS32, i, W7116, W7116.CostBOM, W7116.CostSeq, "2")

                W7116.CostBOM = W7115.CostBOM
                W7116.CostSeq = j
                W7116.Dseq = j
                W7116.CostType = "2"

                W7116.seCBDCost = ListCode("CBDCost")
                W7116.seCostingType = ListCode("CostingType")

                W7116.Price = CDecp(getData(vS32, getColumIndex(vS32, "Price"), i))
                W7116.QtyCost = CDecp(getData(vS32, getColumIndex(vS32, "QtyCost"), i))
                W7116.AMTCost = CDecp(W7116.Price * W7116.QtyCost)

                Call WRITE_PFK7116(W7116)
skip:
            Next


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub

    Private Sub DATA_MOVE_WRITE033()
        Try


            SQL = "DELETE FROM PFK7116 "
            SQL = SQL & " WHERE K7116_CostBOM  = '" & W7115.CostBOM & "' "
            SQL = SQL & " AND K7116_CostType  = '3' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            Dim i As Integer
            Dim j As Integer
            j = 0
            For i = 0 To vS33.ActiveSheet.RowCount - 1
                If getData(vS33, getColumIndex(vS33, "cdCBDCost"), i) = "" Then GoTo skip

                j = j + 1

                Call D7116_CLEAR() : W7116 = D7116
                Call K7116_MOVE(vS33, i, W7116, W7116.CostBOM, W7116.CostSeq, "3")

                W7116.CostBOM = W7115.CostBOM
                W7116.CostSeq = j
                W7116.Dseq = j
                W7116.CostType = "3"

                W7116.seCBDCost = ListCode("CBDCost")
                W7116.seCostingType = ListCode("CostingType")

                W7116.Price = CDecp(getData(vS33, getColumIndex(vS33, "Price"), i))
                W7116.QtyCost = CDecp(getData(vS33, getColumIndex(vS33, "QtyCost"), i))
                W7116.AMTCost = CDecp(W7116.Price * W7116.QtyCost)

                Call WRITE_PFK7116(W7116)
skip:
            Next


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If wJOB = 2 Then Exit Sub

        Select Case wJOB
            Case 1
                If ptc_Main.SelectedIndex = 0 Then
                    Call DATA_MOVE_K7109()
                    Call DATA_SEARCH_VS2()
                    vS1.Select()
                    MsgBoxP("Update Succesully!", vbInformation)
                End If
            Case 2
                Me.Dispose()
            Case 3
                If Data_Check() = False Then Exit Sub
                Call DATA_UPDATE()

                MsgBoxP("Update Succesully!", vbInformation)

            Case 4
                Call DATA_DELETE()

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
        If wJOB = 2 Then Exit Sub

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "cmd_DEL_Click")
            Exit Sub
        End If

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

        Call DATA_DELETE()


    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles vS1.CellClick
        If e.ColumnHeader Then Exit Sub

        L7106.ShoesCode = getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), vS1.ActiveSheet.ActiveRowIndex)
        L7108.ShoesCode = getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), vS1.ActiveSheet.ActiveRowIndex)
        W7108.ShoesCode = getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), vS1.ActiveSheet.ActiveRowIndex)
        txt_ShoesCode.Data = L7106.ShoesCode

        Dim xCOL As Integer
        Dim xROW As Integer
        Dim Value As String

        xROW = sender.ActiveSheet.ActiveRowIndex
        xCOL = sender.ActiveSheet.ActiveColumnIndex

        If ptc_Main.SelectedIndex = 3 Then
            vS1.ActiveSheet.OperationMode = OperationMode.Normal

        ElseIf ptc_Main.SelectedIndex = 0 And xCOL = getColumIndex(sender, "SpeciticSize") Then
            vS1.ActiveSheet.OperationMode = OperationMode.Normal
        ElseIf ptc_Main.SelectedIndex = 0 Then
            Call DATA_SEARCH_VS2()
            vS1.ActiveSheet.OperationMode = OperationMode.SingleSelect
            vS1.Select()
        ElseIf ptc_Main.SelectedIndex = 1 Then
            Call DATA_SEARCH_VS31()
            Call DATA_SEARCH_VS32()
            Call DATA_SEARCH_VS33()
        ElseIf ptc_Main.SelectedIndex = 2 Then
            Call DATA_SEARCH_VS4()
        ElseIf ptc_Main.SelectedIndex = 3 Then
            Call DATA_SEARCH_VS5()
        Else
            vS1.ActiveSheet.OperationMode = OperationMode.SingleSelect
        End If

    End Sub


    Private Sub ptc_Main_DoubleClick(sender As Object, e As EventArgs) Handles ptc_Main.DoubleClick
        If formA = False Then ptc_Main.SelectedIndex = 0

        W7108.ShoesCode = getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), vS1.ActiveSheet.ActiveRowIndex)

        Select Case ptc_Main.SelectedIndex
            Case 0
                Call DATA_SEARCH_VS2()

            Case 1
                Call DATA_SEARCH_VS31()
                Call DATA_SEARCH_VS32()
                Call DATA_SEARCH_VS33()

            Case 2
                Call DATA_SEARCH_VS4()

            Case 3
                Call DATA_SEARCH_VS5()

        End Select
    End Sub
    Private Sub ptc_Main_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ptc_Main.SelectedIndexChanged
        If formA = False Then Exit Sub
        If ptc_Main.SelectedIndex = -1 Then Exit Sub
        chk_Upload.Visible = False
        If formA = False Then ptc_Main.SelectedIndex = 0

        W7108.ShoesCode = getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), vS1.ActiveSheet.ActiveRowIndex)

        Select Case ptc_Main.SelectedIndex
            Case 0
                Call DATA_SEARCH_VS2()

            Case 1
                Call DATA_SEARCH_VS31()
                Call DATA_SEARCH_VS32()
                Call DATA_SEARCH_VS33()

            Case 2
                Call DATA_SEARCH_VS4()

            Case 3
                Call DATA_SEARCH_VS5()

        End Select

    End Sub
    Private flagP As Boolean = False
    Private flagQ As Boolean = False
    Private flagW As Boolean = False
    Private flagL As Boolean = False
    Private flagS As Boolean = False


    Private CntProcess As Integer

    Private Sub vS2_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles vS2.ButtonClicked
        Dim xCOL As Integer
        Dim xROW As Integer
        Dim i As Integer
        Dim Value1() As String
        Dim Value2(5) As String

        xROW = e.Row
        xCOL = e.Column

        Select Case xCOL
            Case getColumIndex(vS2, "CLcdMaterialCode_F1")
                If HLP7260C.Link_HLP7260C("", "2") = False Then Exit Sub

                If Array_hlp0000SeVaTt.Count = 0 Then Exit Sub

                Dim j As Integer = -1

                For i = 0 To Array_hlp0000SeVaTt.Count - 1
                    If READ_PFK7231(Array_hlp0000SeVaTt1(i)) Then
                        j += 1

                        If e.Row + j = vS2.ActiveSheet.RowCount - 1 Then
                            vS2.ActiveSheet.RowCount += 1
                        End If

                        xROW = e.Row + j

                        DS1 = PrcDS("USP_ISUD7110D_SEARCH_VS2_INSERT_SUPPLIER", cn, Array_hlp0000SeVaTt(i), Array_hlp0000SeVaTt1(i), "2")

                        Call READ_SPREAD_N(vS2, DS1, xROW, GetDsRc(DS1), "USP_ISUD7110D_SEARCH_VS2", "VS2")

                    End If

                Next

        End Select
    End Sub

    Private Sub vS2_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS2.CellDoubleClick
        If wJOB = 2 Then Exit Sub

        If e.ColumnHeader = True Then Exit Sub
        Dim MaterialCode As String

        If e.Column = getColumIndex(vS2, "width") Then
            Msg_Result = MsgBox("Do you want to adjust width base?", vbYesNo)
            If Msg_Result <> vbYes Then Exit Sub

            MaterialCode = getData(vS2, getColumIndex(vS2, "MaterialCode"), vS2.ActiveSheet.ActiveRowIndex)
            Dim Strmsg As String = InputBox("Please input Width!")

            Strmsg = Trim(Strmsg)
            If READ_PFK7231(MaterialCode) Then
                W7231 = D7231
                If W7231.Width = Strmsg Then MsgBoxP("Same width! No matching!") : Exit Sub

                W7231.MaterialName = W7231.MaterialName.Replace(W7231.Width, Strmsg)

                W7231.Width = Strmsg
                W7231.DateInsert = Pub.DAT
                W7231.InchargeInsert = Pub.SAW
                W7231.DateInBound = ""
                W7231.DateUpdate = ""
                W7231.DateComplete = ""
                W7231.DateOutBound = ""
                W7231.DatePending1 = ""
                W7231.DatePending2 = ""
                W7231.InchargeApproved = ""
                W7231.InchargeCancel = ""
                W7231.InchargeComplete = ""
                W7231.InchargePending1 = ""
                W7231.InchargePending2 = ""
                W7231.InchargeUpdate = ""

                Call KEY_COUNT_MATERIAL()

                If WRITE_PFK7231(W7231) Then
                    setData(vS2, getColumIndex(vS2, "MaterialCode"), vS2.ActiveSheet.ActiveRowIndex, W7231.MaterialCode)
                    setData(vS2, getColumIndex(vS2, "width"), vS2.ActiveSheet.ActiveRowIndex, W7231.Width)
                End If

            End If
        End If

        If e.Column = getColumIndex(vS2, "cdUnitMaterialName") Then
            Msg_Result = MsgBox("Do you want to unit material base?", vbYesNo)

            If Msg_Result <> vbYes Then Exit Sub


            MaterialCode = getData(vS2, getColumIndex(vS2, "MaterialCode"), vS2.ActiveSheet.ActiveRowIndex)

            Dim cdUnitMaterial As String
            cdUnitMaterial = ""

            If ISUD7231U.Link_HLP7231C("1", cdUnitMaterial) = True Then
                If READ_PFK7231(MaterialCode) Then
                    W7231 = D7231
                    If W7231.cdUnitMaterial = cdUnitMaterial Then MsgBoxP("Same unit! No matching!") : Exit Sub

                    W7231.cdUnitMaterial = cdUnitMaterial
                    W7231.seUnitMaterial = ListCode("UnitMaterial")
                    W7231.DateInsert = Pub.DAT
                    W7231.InchargeInsert = Pub.SAW
                    W7231.DateInBound = ""
                    W7231.DateUpdate = ""
                    W7231.DateComplete = ""
                    W7231.DateOutBound = ""
                    W7231.DatePending1 = ""
                    W7231.DatePending2 = ""
                    W7231.InchargeApproved = ""
                    W7231.InchargeCancel = ""
                    W7231.InchargeComplete = ""
                    W7231.InchargePending1 = ""
                    W7231.InchargePending2 = ""
                    W7231.InchargeUpdate = ""

                    Call KEY_COUNT_MATERIAL()

                    If WRITE_PFK7231(W7231) Then
                        Call READ_PFK7171(ListCode("UnitMaterial"), W7231.cdUnitMaterial)
                        setData(vS2, getColumIndex(vS2, "MaterialCode"), vS2.ActiveSheet.ActiveRowIndex, W7231.MaterialCode)
                        setData(vS2, getColumIndex(vS2, "cdUnitMaterial"), vS2.ActiveSheet.ActiveRowIndex, W7231.cdUnitMaterial)
                        setData(vS2, getColumIndex(vS2, "cdUnitMaterialName"), vS2.ActiveSheet.ActiveRowIndex, D7171.BasicName)

                    End If

                End If
            End If
        End If

    End Sub


#End Region




    Private Sub tst_2_Click(sender As Object, e As EventArgs) Handles tst_2.Click
        Dim xROW As Integer

        xROW = vS2.ActiveSheet.ActiveRowIndex
        If vS2.ActiveSheet.ActiveRowIndex < 0 Then Exit Sub

        If HLP7108F.Link_HLP7108F = False Then Exit Sub

        If hlp0000SeVa = "" Then Exit Sub
        DS1 = PrcDS("USP_ISUD7108A_SEARCH_VS1", cn, hlp0000SeVaTt)

        Call READ_SPREAD_N(vS2, DS1, xROW, GetDsRc(DS1), "USP_ISUD7110D_SEARCH_VS2", "vS2")
    End Sub

    Private Sub tst_3_Click(sender As Object, e As EventArgs) Handles tst_3.Click
        Dim Starting As Object
        Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")


        Try
            Dim i As Integer

            For i = 0 To vS1.ActiveSheet.RowCount - 1
                If getData(vS1, getColumIndex(vS1, "ShoesParent"), i) <> getData(vS1, getColumIndex(vS1, "ShoesCode"), i) Then
                    Call PrcExeNoError("USP_ISUD7110D_SEARCH_SYNC_SHOESCODE", cn, getData(vS1, getColumIndex(vS1, "ShoesParent"), i), getData(vS1, getColumIndex(vS1, "ShoesCode"), i))
                End If
            Next
            MsgBoxP("Save Successfully!", vbInformation)

        Catch ex As Exception

        Finally
            Starting.close()
        End Try
    End Sub

    Private Sub tst_4_Click(sender As Object, e As EventArgs) Handles tst_4.Click
        If L7106.ShoesCode = getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), vS1.ActiveSheet.ActiveRowIndex) Then
            MsgBoxP("Shoes Parent Cannot Delete!")
            Exit Sub
        End If

        Msg_Result = MsgBox("Do you want to delete shoes parent?", vbYesNo)

        If Msg_Result <> vbYes Then Exit Sub

        If READ_PFK7106(getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), vS1.ActiveSheet.ActiveRowIndex)) Then

            If D7106.CheckParent = "1" Then Exit Sub

            D7106.CheckUse = "2"
            If REWRITE_PFK7106(D7106) Then

                setData(vS1, getColumIndex(vS1, "CheckUse"), vS1.ActiveSheet.ActiveRowIndex, "2", , False)

            End If


        End If

        Call DATA_SEARCH_VS1()

    End Sub



    Private Sub vS2_KeyDown(sender As Object, e As KeyEventArgs) Handles vS2.KeyDown
        If wJOB = 2 Then Exit Sub

        Dim xCOL As Integer
        Dim xROW As Integer
        xCOL = vS2.ActiveSheet.ActiveColumnIndex
        xROW = vS2.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Delete

                Call Select_Message("3", WordConv("PROCESSING"), 2)

                If Msg_Result <> vbYes Then Exit Sub

                W7109.GroupComponentBOM = getData(vS2, getColumIndex(vS2, "KEY_GroupComponentBOM"), xROW)
                W7109.GroupComponentSeq = CDecp(getData(vS2, getColumIndex(vS2, "KEY_GroupComponentSeq"), xROW))

                If READ_PFK7109(W7109.GroupComponentBOM, W7109.GroupComponentSeq) Then
                    W7109 = D7109
                    Call DELETE_PFK7109(W7109)
                End If

                SPR_DEL(vS2, xCOL, xROW)
                vS2.ActiveSheet.ActiveColumnIndex = xCOL
                vS2.ActiveSheet.ActiveRowIndex = xROW
                vS2.Focus()

            Case Keys.Enter


                W7108.ShoesCode = getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), vS1.ActiveSheet.ActiveRowIndex)

                If READ_PFK7108_SHOESCODE(W7108.ShoesCode) = False Then
                    Call KEY_COUNT_K7108()
                    W7108.InchargeInsert = Pub.SAW

                    If WRITE_PFK7108(W7108) = True Then

                    End If
                Else
                    W7108 = D7108

                    W7109.GroupComponentBOM = W7108.GroupComponentBOM
                    W7109.GroupComponentSeq = CDecp(getData(vS2, getColumIndex(vS2, "KEY_GroupComponentSeq"), xROW))

                    If FormatCut(W7109.GroupComponentBOM) = "" Then W7109.GroupComponentBOM = W7108.GroupComponentBOM

                    If K7109_MOVE(vS2, xROW, W7109, W7109.GroupComponentBOM, W7109.GroupComponentSeq) = False Then
                        W7109.GroupComponentBOM = W7108.GroupComponentBOM

                        Call KEY_COUNT_K7109_SEQ()

                        W7109.Dseq = xROW

                        W7109.selGroupComponent = ListCode("GroupComponent")
                        W7109.seDepartment = ListCode("Department")
                        W7109.seShoesStatus = ListCode("ShoesStatus")
                        W7109.seUnitMaterial = ListCode("UnitMaterial")
                        W7109.seSubProcess = ListCode("SubProcess")
                        W7109.seSpecialProcess = ListCode("SpecialProcess")

                        W7109.GrossUsage = W7109.Consumption * (1 + W7109.Loss / 100)

                        W7109.MaterialAMTSales = CDblp(getData(vS2, getColumIndex(vS2, "MaterialAMTSales"), xROW))

                        W7109.PriceRnD = W7109.PriceMaterial * (1 + W7109.ShippingRate / 100)
                        W7109.PriceRnD += W7109.ExchangeCost
                        W7109.PriceRnD += W7109.AddedCost
                        W7109.PriceRnD += W7109.ComplicationCost
                        W7109.PriceRnD += W7109.ShippingCost

                        W7109.MaterialAMT = W7109.GrossUsage * W7109.PriceRnD

                        If W7109.GrossUsage = "0" Then
                            W7109.Price = 0
                        Else
                            W7109.Price = W7109.MaterialAMTSales / W7109.GrossUsage
                        End If

                        If WRITE_PFK7109(W7109) Then
                            setData(vS2, getColumIndex(vS2, "KEY_GroupComponentBOM"), xROW, W7109.GroupComponentBOM)
                            setData(vS2, getColumIndex(vS2, "KEY_GroupComponentSeq"), xROW, W7109.GroupComponentSeq)
                            setData(vS2, getColumIndex(vS2, "Dseq"), xROW, W7109.Dseq)
                        End If

                    Else
                        W7109.Dseq = xROW
                        W7109.GrossUsage = W7109.Consumption * (1 + W7109.Loss / 100)

                        W7109.MaterialAMTSales = CDblp(getData(vS2, getColumIndex(vS2, "MaterialAMTSales"), xROW))

                        W7109.PriceRnD = W7109.PriceMaterial * (1 + W7109.ShippingRate / 100)
                        W7109.PriceRnD += W7109.ExchangeCost
                        W7109.PriceRnD += W7109.AddedCost
                        W7109.PriceRnD += W7109.ComplicationCost
                        W7109.PriceRnD += W7109.ShippingCost

                        W7109.MaterialAMT = W7109.GrossUsage * W7109.PriceRnD

                        If W7109.GrossUsage = "0" Then
                            W7109.Price = 0
                        Else
                            W7109.Price = W7109.MaterialAMTSales / W7109.GrossUsage
                        End If

                        Call REWRITE_PFK7109(W7109)
                    End If
                End If

        End Select
    End Sub

    Private Sub vS2_Change(sender As Object, e As ChangeEventArgs) Handles vS2.Change
        If wJOB = 2 Then Exit Sub

        Try

            If e.Column = getColumnIndex(vS2, "MaterialAMTSales") Then

                Dim i, j As Integer

                If e.Column = getColumnIndex(vS2, "KEY_ProcessSeq") Then

                    For i = vS2.ActiveSheet.ActiveRowIndex To vS2.ActiveSheet.RowCount

                        j = getData(vS2, getColumnIndex(vS2, "KEY_ProcessSeq"), i)

                        If IsNumeric(j) = True Then
                            setData(vS2, getColumnIndex(vS2, "KEY_ProcessSeq"), i + 1, j + 1)
                        Else
                            setData(vS2, getColumnIndex(vS2, "KEY_ProcessSeq"), i + 1, i + 1)
                        End If

                    Next

                    Exit Sub
                End If


                Dim xCOL As Integer
                Dim xROW As Integer
                xCOL = vS2.ActiveSheet.ActiveColumnIndex
                xROW = vS2.ActiveSheet.ActiveRowIndex

                W7108.ShoesCode = getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), vS1.ActiveSheet.ActiveRowIndex)

                If READ_PFK7108_SHOESCODE(L7106.ShoesCode) = False Then
                    Call KEY_COUNT_K7108()
                    L7108.InchargeInsert = Pub.SAW

                    If WRITE_PFK7108(L7108) = True Then

                    End If
                Else
                    L7108 = D7108

                    W7109.GroupComponentBOM = L7108.GroupComponentBOM
                    W7109.GroupComponentSeq = getData(vS2, getColumIndex(vS2, "KEY_GroupComponentSeq"), xROW)


                    If K7109_MOVE(vS2, xROW, W7109, W7109.GroupComponentBOM, W7109.GroupComponentSeq) = False Then
                        W7109.GroupComponentBOM = W7108.GroupComponentBOM

                        Call KEY_COUNT_K7109_SEQ()

                        W7109.Dseq = xROW

                        W7109.selGroupComponent = ListCode("GroupComponent")
                        W7109.seDepartment = ListCode("Department")
                        W7109.seShoesStatus = ListCode("ShoesStatus")
                        W7109.seUnitMaterial = ListCode("UnitMaterial")
                        W7109.seSubProcess = ListCode("SubProcess")
                        W7109.seSpecialProcess = ListCode("SpecialProcess")

                        W7109.GrossUsage = W7109.Consumption * (1 + W7109.Loss / 100)

                        W7109.MaterialAMTSales = getData(vS2, getColumnIndex(vS2, "MaterialAMTSales"), e.Row)

                        W7109.PriceRnD = W7109.PriceMaterial * (1 + W7109.ShippingRate / 100)
                        W7109.PriceRnD += W7109.ExchangeCost
                        W7109.PriceRnD += W7109.AddedCost
                        W7109.PriceRnD += W7109.ComplicationCost
                        W7109.PriceRnD += W7109.ShippingCost

                        W7109.MaterialAMT = W7109.GrossUsage * W7109.PriceRnD

                        If W7109.GrossUsage = "0" Then
                            W7109.Price = 0
                        Else
                            W7109.Price = W7109.MaterialAMTSales / W7109.GrossUsage
                        End If

                        setData(vS2, getColumnIndex(vS2, "Price"), e.Row, W7109.Price)

                        If WRITE_PFK7109(W7109) Then
                            setData(vS2, getColumIndex(vS2, "KEY_GroupComponentBOM"), xROW, W7109.GroupComponentBOM)
                            setData(vS2, getColumIndex(vS2, "KEY_GroupComponentSeq"), xROW, W7109.GroupComponentSeq)
                            setData(vS2, getColumIndex(vS2, "Dseq"), xROW, W7109.Dseq)
                        End If

                    Else
                        W7109.Dseq = xROW

                        W7109.GrossUsage = W7109.Consumption * (1 + W7109.Loss / 100)

                        W7109.MaterialAMTSales = getData(vS2, getColumnIndex(vS2, "MaterialAMTSales"), e.Row)

                        W7109.PriceRnD = W7109.PriceMaterial * (1 + W7109.ShippingRate / 100)
                        W7109.PriceRnD += W7109.ExchangeCost
                        W7109.PriceRnD += W7109.AddedCost
                        W7109.PriceRnD += W7109.ComplicationCost
                        W7109.PriceRnD += W7109.ShippingCost

                        W7109.MaterialAMT = W7109.GrossUsage * W7109.PriceRnD

                        If W7109.GrossUsage = "0" Then
                            W7109.Price = 0
                        Else
                            W7109.Price = W7109.MaterialAMTSales / W7109.GrossUsage
                        End If

                        setData(vS2, getColumnIndex(vS2, "Price"), e.Row, W7109.Price)

                        Call REWRITE_PFK7109(W7109)
                    End If
                End If

                ' =====================================================================huy 20180719 calculatepric

            Else

                Dim i, j As Integer

                If e.Column = getColumnIndex(vS2, "KEY_ProcessSeq") Then

                    For i = vS2.ActiveSheet.ActiveRowIndex To vS2.ActiveSheet.RowCount

                        j = getData(vS2, getColumnIndex(vS2, "KEY_ProcessSeq"), i)

                        If IsNumeric(j) = True Then
                            setData(vS2, getColumnIndex(vS2, "KEY_ProcessSeq"), i + 1, j + 1)
                        Else
                            setData(vS2, getColumnIndex(vS2, "KEY_ProcessSeq"), i + 1, i + 1)
                        End If

                    Next

                    Exit Sub
                End If


                Dim xCOL As Integer
                Dim xROW As Integer
                xCOL = vS2.ActiveSheet.ActiveColumnIndex
                xROW = vS2.ActiveSheet.ActiveRowIndex

                W7108.ShoesCode = getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), vS1.ActiveSheet.ActiveRowIndex)

                If READ_PFK7108_SHOESCODE(L7106.ShoesCode) = False Then
                    Call KEY_COUNT_K7108()
                    L7108.InchargeInsert = Pub.SAW

                    If WRITE_PFK7108(L7108) = True Then

                    End If
                Else
                    L7108 = D7108

                    W7109.GroupComponentBOM = L7108.GroupComponentBOM
                    W7109.GroupComponentSeq = getData(vS2, getColumIndex(vS2, "KEY_GroupComponentSeq"), xROW)


                    If K7109_MOVE(vS2, xROW, W7109, W7109.GroupComponentBOM, W7109.GroupComponentSeq) = False Then
                        W7109.GroupComponentBOM = W7108.GroupComponentBOM

                        Call KEY_COUNT_K7109_SEQ()

                        W7109.Dseq = xROW

                        W7109.selGroupComponent = ListCode("GroupComponent")
                        W7109.seDepartment = ListCode("Department")
                        W7109.seShoesStatus = ListCode("ShoesStatus")
                        W7109.seUnitMaterial = ListCode("UnitMaterial")
                        W7109.seSubProcess = ListCode("SubProcess")
                        W7109.seSpecialProcess = ListCode("SpecialProcess")

                        W7109.GrossUsage = W7109.Consumption * (1 + W7109.Loss / 100)

                        W7109.MaterialAMTSales = getData(vS2, getColumnIndex(vS2, "MaterialAMTSales"), e.Row)

                        W7109.PriceRnD = W7109.PriceMaterial * (1 + W7109.ShippingRate / 100)
                        W7109.PriceRnD += W7109.ExchangeCost
                        W7109.PriceRnD += W7109.AddedCost
                        W7109.PriceRnD += W7109.ComplicationCost
                        W7109.PriceRnD += W7109.ShippingCost

                        W7109.MaterialAMT = W7109.GrossUsage * W7109.PriceRnD
                        If W7109.GrossUsage = "0" Then
                            W7109.Price = 0
                        Else
                            W7109.Price = W7109.MaterialAMTSales / W7109.GrossUsage
                        End If

                        If WRITE_PFK7109(W7109) Then
                            setData(vS2, getColumIndex(vS2, "KEY_GroupComponentBOM"), xROW, W7109.GroupComponentBOM)
                            setData(vS2, getColumIndex(vS2, "KEY_GroupComponentSeq"), xROW, W7109.GroupComponentSeq)
                            setData(vS2, getColumIndex(vS2, "Dseq"), xROW, W7109.Dseq)
                        End If

                    Else
                        W7109.Dseq = xROW

                        W7109.GrossUsage = W7109.Consumption * (1 + W7109.Loss / 100)

                        W7109.MaterialAMTSales = getData(vS2, getColumnIndex(vS2, "MaterialAMTSales"), e.Row)

                        W7109.PriceRnD = W7109.PriceMaterial * (1 + W7109.ShippingRate / 100)
                        W7109.PriceRnD += W7109.ExchangeCost
                        W7109.PriceRnD += W7109.AddedCost
                        W7109.PriceRnD += W7109.ComplicationCost
                        W7109.PriceRnD += W7109.ShippingCost

                        W7109.MaterialAMT = W7109.GrossUsage * W7109.PriceRnD

                        If W7109.GrossUsage = "0" Then
                            W7109.Price = 0
                        Else
                            W7109.Price = W7109.MaterialAMTSales / W7109.GrossUsage
                        End If

                        Call REWRITE_PFK7109(W7109)
                    End If
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub vS1_DialogKey(sender As Object, e As DialogKeyEventArgs) Handles vS1.DialogKey
        Dim xCOL As Integer
        Dim xROW As Integer
        xCOL = vS1.ActiveSheet.ActiveColumnIndex
        xROW = vS1.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Up
                If vS1.ActiveSheet.ActiveRowIndex > 0 Then vS1.ActiveSheet.ActiveRowIndex = vS1.ActiveSheet.ActiveRowIndex - 1

                Dim Value As String
                If ptc_Main.SelectedIndex = 3 Then
                    vS1.ActiveSheet.OperationMode = OperationMode.Normal

                ElseIf ptc_Main.SelectedIndex = 0 And xCOL = getColumIndex(sender, "SpeciticSize") Then
                    vS1.ActiveSheet.OperationMode = OperationMode.Normal
                ElseIf ptc_Main.SelectedIndex = 0 Then
                    Call DATA_SEARCH_VS2()
                    vS1.ActiveSheet.OperationMode = OperationMode.SingleSelect
                    vS1.Select()
                Else
                    vS1.ActiveSheet.OperationMode = OperationMode.SingleSelect
                End If

            Case Keys.Down
                If vS1.ActiveSheet.ActiveRowIndex < vS1.ActiveSheet.RowCount - 1 Then vS1.ActiveSheet.ActiveRowIndex = vS1.ActiveSheet.ActiveRowIndex + 1

                Dim Value As String
                If ptc_Main.SelectedIndex = 3 Then
                    vS1.ActiveSheet.OperationMode = OperationMode.Normal

                ElseIf ptc_Main.SelectedIndex = 0 And xCOL = getColumIndex(sender, "SpeciticSize") Then
                    vS1.ActiveSheet.OperationMode = OperationMode.Normal
                ElseIf ptc_Main.SelectedIndex = 0 Then
                    Call DATA_SEARCH_VS2()
                    vS1.ActiveSheet.OperationMode = OperationMode.SingleSelect
                    vS1.Select()
                Else
                    vS1.ActiveSheet.OperationMode = OperationMode.SingleSelect
                End If

        End Select
    End Sub

    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles vS1.KeyDown
        If wJOB = 2 Then Exit Sub

        Dim xCOL As Integer
        Dim xROW As Integer
        xCOL = vS1.ActiveSheet.ActiveColumnIndex
        xROW = vS1.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode


            Case Keys.Delete
                If L7106.ShoesCode = getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), xROW) Then
                    MsgBoxP("Shoes Parent Cannot Delete!")
                    Exit Sub
                End If

                Msg_Result = MsgBox("Do you want to delete shoes parent?", vbYesNo)

                If Msg_Result <> vbYes Then Exit Sub

                If READ_PFK7106(getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), xROW)) Then
                    If D7106.CheckParent = "1" Then Exit Sub

                    D7106.CheckUse = "2"
                    If REWRITE_PFK7106(D7106) Then

                        setData(vS1, getColumIndex(vS1, "CheckUse"), xROW, "2", , False)

                    End If
                End If


            Case Keys.Enter
                If READ_PFK7106(getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), xROW)) Then
                    If READ_PFK7104_SZNO(D7106.SizeRange, getData(vS1, getColumIndex(vS1, "SpeciticSize"), xROW)) = "" Then
                        MsgBoxP("Wrong size!")
                        setData(vS1, getColumIndex(vS1, "SpeciticSize"), xROW, D7106.SpeciticSize)
                        Exit Sub
                    End If

                    D7106.SpeciticSize = getData(vS1, getColumIndex(vS1, "SpeciticSize"), xROW)
                    D7106.Szno = READ_PFK7104_SZNO(D7106.SizeRange, getData(vS1, getColumIndex(vS1, "SpeciticSize"), xROW))

                    If REWRITE_PFK7106(D7106) Then

                    End If
                End If

        End Select
    End Sub


    Private Sub vS1_Change(sender As Object, e As ChangeEventArgs) Handles vS1.Change
        If wJOB = 2 Then Exit Sub

        If READ_PFK7106(getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), e.Row)) Then
            If READ_PFK7104_SZNO(D7106.SizeRange, getData(vS1, getColumIndex(vS1, "SpeciticSize"), e.Row)) = "" Then
                setData(vS1, getColumIndex(vS1, "SpeciticSize"), e.Row, D7106.SpeciticSize)
                MsgBoxP("Wrong size!") : Exit Sub
            End If

            D7106.SpeciticSize = getData(vS1, getColumIndex(vS1, "SpeciticSize"), e.Row)
            D7106.Szno = READ_PFK7104_SZNO(D7106.SizeRange, getData(vS1, getColumIndex(vS1, "SpeciticSize"), e.Row))

            If REWRITE_PFK7106(D7106) Then

            End If
        End If
    End Sub

    Private Sub chk_CheckProfitAmt_CheckedChanged(sender As Object, e As EventArgs) Handles chk_CheckProfitAmt.CheckedChanged
        If chk_CheckProfitAmt.Checked = True Then
            txt_ProfitAmt.TextEnabled = True
            txt_ProfitRate.Value = 0
        Else
            txt_ProfitAmt.Data = 0
            txt_ProfitAmt.TextEnabled = False
        End If
    End Sub
End Class