Public Class ISUD7108C
#Region "Variable"
    Private wJOB As Integer

    Private W7231 As T7231_AREA

    Private L7106 As T7106_AREA

    Private W7108 As T7108_AREA
    Private L7108 As T7108_AREA

    Private W7209 As T7209_AREA
    Private L7209 As T7209_AREA

    Private W7208 As T7208_AREA
    Private L7208 As T7208_AREA

    Private W7103 As T7103_AREA

    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7108C(job As Integer, GroupComponentBOM As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D7108.GroupComponentBOM = GroupComponentBOM

        If job = "1" Then
            D7108.GroupComponentBOM = ""
            D7108.ShoesCode = GroupComponentBOM
            L7108.ShoesCode = GroupComponentBOM
            txt_ShoesCode.Data = GroupComponentBOM
        End If


        wJOB = job : L7108 = D7108 : L7106 = D7106

        Link_ISUD7108C = False
        Try
            Select Case job
                Case 1
                Case Else
                    If READ_PFK7108(GroupComponentBOM) = False Then
                        Call MsgBoxP("You have no right is this ShoesCode !")
                        Me.Dispose()

                        Exit Function
                    End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7108C = isudCHK


        Catch ex As Exception
            '       Call MsgBoxP("61", WordConv("GroupComponentBOM"))
        End Try


    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_Initial()
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

                Call KEY_COUNT()
                Call DATA_SEARCH01()

                Call DATA_SEARCH_VS10()
                Call DATA_SEARCH_VS11()

                Frame1.Enabled = True
                tst_iDelete.Visible = False

                Setfocus(txt_GroupComponentBOMName)

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
                Call DATA_SEARCH_VS10()
                Call DATA_SEARCH_VS11()

                Pal_1.Enabled = False
                tst_iDelete.Visible = False
                tst_iSave.Visible = False

            Case 3
                Me.Text = Me.Text & " - UPDATE"
                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS10()
                Call DATA_SEARCH_VS11()

                Frame1.Enabled = True
                txt_GroupComponentBOM.Enabled = False

                tst_iDelete.Visible = False
                tst_iSave.Visible = True

            Case 4
                Me.Text = Me.Text & " - DELETE"
                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If
                Frame1.Enabled = True
                cmd_AttachMaterialToSupplier.Visible = False

                tst_iDelete.Visible = True
                tst_iSave.Visible = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS10()
                Call DATA_SEARCH_VS11()

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Try
            txt_GroupComponentBOM.Enabled = False
            Call D7108_CLEAR()
            W7108 = D7108

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()
        vS11.AllowRowMove = True
        PeaceSplitContainer1.Panel1Collapsed = True
        PeaceSplitContainer2.Panel1Collapsed = True
        PeaceSplitContainer3.Panel1Collapsed = True
        'PeaceSplitContainer4.Panel1Collapsed = True

        Call Cms_additem(Cms_1,
                     WordConv("CHECK DEFAULT VERSION"),
                     WordConv("UPDATE INFORMATION"),
                     WordConv("MAKE NEW VERSION"),
                     WordConv("CHECK DATA VERSION"))

        vS10.ContextMenuStrip = Cms_1

        vS00.ContextMenuStrip = Cms_1
        vS20.ContextMenuStrip = Cms_1
        vS30.ContextMenuStrip = Cms_1

        ptc_Main.SelectedIndex = 1

    End Sub
#End Region

#Region "Data_Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Try


            If READ_PFK7108(L7108.GroupComponentBOM) Then
                L7108.ShoesCode = D7108.ShoesCode
                txt_QtyTTL.Data = D7108.QtyTTL
            End If

            DS1 = READ_PFK7106(L7108.ShoesCode, cn)

            If GetDsRc(DS1) > 0 Then
                READER_MOVE(Me, DS1)
                txt_GroupComponentBOMName.Data = D7106.ProductCode & "/" & D7106.Article
            End If

            If GetDsData(DS1, 0, "K7106_CheckCBD") = "1" Then
                MsgBoxP("Complete Already ! Only view !")
                wJOB = "2"
                tst_iSave.Visible = False
                tst_iDelete.Visible = False

                tst_iSave.Enabled = False
                tst_iDelete.Enabled = False

                chk_CheckCBD1.Checked = True
                chk_CheckCBD2.Checked = False

                txt_MasterBom.Visible = False
                txt_CBDProcess.Visible = False
                cmd_AttachMaterialToSupplier.Visible = False
                cmd_BuyerRule.Visible = False
                cmd_FileUpload.Visible = False
                cmd_GC.Visible = False
                cmd_UpdatePrice.Visible = False
                cmd_ItemCode.Visible = False

                cmd_SupplierCost.Visible = False
                txt_cdMasterBOM.Visible = False
                cmd_AttachMaterialToSupplier.Visible = False

            Else
                chk_CheckCBD1.Checked = False
                chk_CheckCBD2.Checked = True

            End If


            DS1 = Nothing

            DS1 = READ_PFK7108(L7108.GroupComponentBOM, cn)

            If GetDsRc(DS1) = 0 Then
                Exit Function
                isudCHK = False
            End If

            READER_MOVE(Me, DS1)


            If GetDsData(DS1, 0, "K7108_CheckUse") = "1" Then
                rad_CheckUse1.Checked = True
                rad_CheckUse2.Checked = False
            Else
                rad_CheckUse1.Checked = False
                rad_CheckUse2.Checked = True
            End If

            If READ_PFK7108(L7108.GroupComponentBOM) Then
                L7108.ShoesCode = D7108.ShoesCode
                txt_QtyTTL.Data = D7108.QtyTTL
            End If
            DATA_SEARCH01 = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH01")
        End Try

    End Function

    Private Function DATA_SEARCH_VS10() As Boolean
        DATA_SEARCH_VS10 = False

        If chk_Group.Checked = False Then Exit Function

        DS1 = PrcDS("USP_ISUD7108C_SEARCH_vs10", cn, L7108.ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(vS10, , , , OperationMode.Normal)
            SPR_PRO_NEW(vS10, DS1, "USP_ISUD7108C_SEARCH_vs10", "vs10")

            vS10.Enabled = True
            Exit Function
        End If
        SPR_SET(vS10, , , , OperationMode.Normal)
        SPR_PRO_NEW(vS10, DS1, "USP_ISUD7108C_SEARCH_vs10", "vs10")

        DATA_SEARCH_VS10 = True


    End Function

    Private Function DATA_SEARCH_VS11() As Boolean
        DATA_SEARCH_VS11 = False

        DS1 = PrcDS("USP_ISUD7108C_SEARCH_vS11", cn, L7108.GroupComponentBOM)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(vS11, , , , OperationMode.Normal)
            SPR_PRO_NEW(vS11, DS1, "USP_ISUD7108C_SEARCH_VS11", "vS11")

            Call SPR_SearchType(vS11, SearchType.Material)
            Call SPR_SearchType(vS11, SearchType.BasicCode, "cdGroupComponentName", ListCode("GroupComponent"))

            vS11.ActiveSheet.RowCount = 1
            vS11.Enabled = True
            Exit Function
        End If
        SPR_SET(vS11, , , , OperationMode.Normal)
        SPR_PRO_NEW(vS11, DS1, "USP_ISUD7108C_SEARCH_VS11", "vS11")

        Call SPR_SearchType(vS11, SearchType.Material)
        Call SPR_SearchType(vS11, SearchType.BasicCode, "cdGroupComponentName", ListCode("GroupComponent"))

        Dim i As Integer
        Dim CColor As Color
        Dim intCol1 As Integer = getColumIndex(vS11, "MaterialName")
        Dim intCol2 As Integer = getColumIndex(vS11, "MaterialCode")


        For i = 0 To vS11.ActiveSheet.RowCount - 1
            CColor = Color.Empty
            CColor = FUNCTION_MATERIAL_CBD(getData(vS11, getColumIndex(vS11, "KEY_CheckCBDType"), i))

            Call SPR_BACKCOLORCELL(vS11, CColor, intCol1, i)
            Call SPR_BACKCOLORCELL(vS11, CColor, intCol2, i)
        Next

        DATA_SEARCH_VS11 = True


    End Function

    Private Function DATA_SEARCH_VS11_HistoryCode(HistoryCode) As Boolean
        DATA_SEARCH_VS11_HistoryCode = False

        DS1 = PrcDS("USP_ISUD7108C_SEARCH_VS11_HISTORY", cn, HistoryCode)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(vS11, , , , OperationMode.Normal)
            SPR_PRO_NEW(vS11, DS1, "USP_ISUD7108C_SEARCH_VS11", "vS11")

            vS11.Enabled = True
            Exit Function
        End If
        SPR_SET(vS11, , , , OperationMode.Normal)
        SPR_PRO_NEW(vS11, DS1, "USP_ISUD7108C_SEARCH_VS11", "vS11")

        DATA_SEARCH_VS11_HistoryCode = True
    End Function


    Private Function DATA_SEARCH_vS00() As Boolean
        DATA_SEARCH_vS00 = False
        If chk_Group.Checked = False Then Exit Function
        DS1 = PrcDS("USP_ISUD7108C_SEARCH_vS00", cn, L7108.ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(vS00, , , , OperationMode.Normal)
            SPR_PRO_NEW(vS00, DS1, "USP_ISUD7108C_SEARCH_vS00", "vS00")

            vS00.Enabled = True
            Exit Function
        End If
        SPR_SET(vS00, , , , OperationMode.Normal)
        SPR_PRO_NEW(vS00, DS1, "USP_ISUD7108C_SEARCH_vS00", "vS00")

        DATA_SEARCH_vS00 = True


    End Function

    Private Function DATA_SEARCH_vS01() As Boolean
        DATA_SEARCH_vS01 = False

        DS1 = PrcDS("USP_ISUD7108C_SEARCH_vS01", cn, L7108.GroupComponentBOM)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(vS01, , , , OperationMode.Normal)
            SPR_PRO_NEW(vS01, DS1, "USP_ISUD7108C_SEARCH_vS01", "vS01")
            vS01.ActiveSheet.RowCount = 1
            vS01.Enabled = True
            Exit Function
        End If
        SPR_SET(vS01, , , , OperationMode.Normal)
        SPR_PRO_NEW(vS01, DS1, "USP_ISUD7108C_SEARCH_vS01", "vS01")

        DATA_SEARCH_vS01 = True


    End Function

    Private Function DATA_SEARCH_vS01_HistoryCode(HistoryCode) As Boolean
        DATA_SEARCH_vS01_HistoryCode = False

        DS1 = PrcDS("USP_ISUD7108C_SEARCH_vS01_HISTORY", cn, HistoryCode)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(vS01, , , , OperationMode.Normal)
            SPR_PRO_NEW(vS01, DS1, "USP_ISUD7108C_SEARCH_vS01", "vS01")

            vS01.Enabled = True
            Exit Function
        End If
        SPR_SET(vS01, , , , OperationMode.Normal)
        SPR_PRO_NEW(vS01, DS1, "USP_ISUD7108C_SEARCH_vS01", "vS01")

        DATA_SEARCH_vS01_HistoryCode = True
    End Function






    Private Function DATA_SEARCH_vS20() As Boolean
        DATA_SEARCH_vS20 = False
        If chk_Group.Checked = False Then Exit Function

        DS1 = PrcDS("USP_ISUD7108C_SEARCH_vS20", cn, L7108.ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(vS20, , , , OperationMode.Normal)
            SPR_PRO_NEW(vS20, DS1, "USP_ISUD7108C_SEARCH_vS20", "vS20")

            vS20.Enabled = True
            Exit Function
        End If
        SPR_SET(vS20, , , , OperationMode.Normal)
        SPR_PRO_NEW(vS20, DS1, "USP_ISUD7108C_SEARCH_vS20", "vS20")

        DATA_SEARCH_vS20 = True


    End Function

    Private Function DATA_SEARCH_vS21() As Boolean
        DATA_SEARCH_vS21 = False

        DS1 = PrcDS("USP_ISUD7108C_SEARCH_vS21", cn, L7108.GroupComponentBOM)

        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_ISUD7108C_SEARCH_VS21_INSERT", cn, L7108.GroupComponentBOM)

            SPR_PRO_NEW(vS21, DS2, "USP_ISUD7108C_SEARCH_vS21", "vS21")
            vS21.Enabled = True
            Exit Function
        End If
        SPR_SET(vS21, , , , OperationMode.Normal)
        SPR_PRO_NEW(vS21, DS1, "USP_ISUD7108C_SEARCH_vS21", "vS21")

        DATA_SEARCH_vS21 = True


    End Function

    Private Function DATA_SEARCH_vS21_HistoryCode(HistoryCode) As Boolean
        DATA_SEARCH_vS21_HistoryCode = False

        DS1 = PrcDS("USP_ISUD7108C_SEARCH_vS21_HISTORY", cn, HistoryCode)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(vS21, , , , OperationMode.Normal)
            SPR_PRO_NEW(vS21, DS1, "USP_ISUD7108C_SEARCH_vS21", "vS21")

            vS21.Enabled = True
            Exit Function
        End If
        SPR_SET(vS21, , , , OperationMode.Normal)
        SPR_PRO_NEW(vS21, DS1, "USP_ISUD7108C_SEARCH_vS21", "vS21")

        DATA_SEARCH_vS21_HistoryCode = True
    End Function





    Private Function DATA_SEARCH_vS30() As Boolean
        DATA_SEARCH_vS30 = False

        DS1 = PrcDS("USP_ISUD7108C_SEARCH_vS30", cn, L7108.ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(vS30, , , , OperationMode.Normal)
            SPR_PRO_NEW(vS30, DS1, "USP_ISUD7108C_SEARCH_vS30", "vS30")

            vS30.Enabled = True
            Exit Function
        End If
        SPR_SET(vS30, , , , OperationMode.Normal)
        SPR_PRO_NEW(vS30, DS1, "USP_ISUD7108C_SEARCH_vS30", "vS30")

        DATA_SEARCH_vS30 = True


    End Function

    Private Function DATA_SEARCH_vS31() As Boolean
        DATA_SEARCH_vS31 = False

        DS1 = PrcDS("USP_ISUD7108C_SEARCH_vS31", cn, txt_VerALL.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(vS31, , , , OperationMode.Normal)
            SPR_PRO_NEW(vS31, DS1, "USP_ISUD7108C_SEARCH_vS31", "vS31")

            vS31.ActiveSheet.RowCount = 1
            vS31.Enabled = True
            Exit Function
        End If
        SPR_SET(vS31, , , , OperationMode.Normal)
        SPR_PRO_NEW(vS31, DS1, "USP_ISUD7108C_SEARCH_vS31", "vS31")

        DATA_SEARCH_vS31 = True


    End Function

    Private Function DATA_SEARCH_vS31_HistoryCode(HistoryCode) As Boolean
        DATA_SEARCH_vS31_HistoryCode = False

        DS1 = PrcDS("USP_ISUD7108C_SEARCH_vS31_HISTORY", cn, HistoryCode)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(vS31, , , , OperationMode.Normal)
            SPR_PRO_NEW(vS31, DS1, "USP_ISUD7108C_SEARCH_vS31", "vS31")

            vS31.Enabled = True
            Exit Function
        End If
        SPR_SET(vS31, , , , OperationMode.Normal)
        SPR_PRO_NEW(vS31, DS1, "USP_ISUD7108C_SEARCH_vS31", "vS31")

        DATA_SEARCH_vS31_HistoryCode = True
    End Function


#End Region

#Region "Function"

    Private Function Data_Check() As Boolean
        Dim i As Integer

        Data_Check = False

        Try
            If txt_GroupComponentBOMName.Data.Trim = "" Then Setfocus(txt_GroupComponentBOMName) : Exit Function
            txt_GroupComponentBOMName.Data = Replace(txt_GroupComponentBOMName.Data, "'", "`")

            If wJOB = "1" Then
                If READ_PFK7108(L7108.GroupComponentBOM) = True Then
                    Call MsgBoxP("5", "DATA_INSERT_TAB1")
                    txt_GroupComponentBOM.Focus()
                    KEY_COUNT()
                    Exit Function
                End If
            End If

            W7108.CheckUse = "1"

            For i = 0 To vS11.ActiveSheet.RowCount - 1
                If FormatCut(getData(vS11, getColumIndex(vS11, "MaterialName"), i)) = "" Then rad_CheckUse2.Checked = True : W7108.CheckUse = "2"
                If FormatCut(getData(vS11, getColumIndex(vS11, "ComponentName"), i)) = "" Then rad_CheckUse2.Checked = True : W7108.CheckUse = "2"
                If FormatCut(getData(vS11, getColumIndex(vS11, "cdGroupComponent"), i)) = "" Then rad_CheckUse2.Checked = True : W7108.CheckUse = "2"
            Next

            Data_Check = True
skip_1:
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))

        End Try
    End Function

    Private Sub DATA_MOVE()
        Try
            W7108.GroupComponentBOM = txt_GroupComponentBOM.Data
            W7108.GroupComponentBOMName = txt_GroupComponentBOMName.Data

            W7108.Remark = txt_Remark.Data
            W7108.ShoesCode = txt_ShoesCode.Data
            W7108.QtyTTL = CDecp(txt_QtyTTL.Data)

            W7108.GroupComponentBOM = txt_GroupComponentBOM.Data

            If rad_CheckUse1.Checked = True Then W7108.CheckUse = "1"
            If rad_CheckUse2.Checked = True Then W7108.CheckUse = "2"

            If READ_PFK7106(W7108.ShoesCode) Then
                If D7106.CheckCBD = "2" And chk_CheckCBD1.Checked = True Then

                    If bolCheckCBD = False Then
                        If MsgBoxPPW("Please type the password to modify!", const_pwMCBD) = False Then Exit Sub
                        bolCheckCBD = True
                    End If

                End If

                If chk_CheckCBD1.Checked = True Then D7106.CheckCBD = "1" : D7106.TimeCBDCom = System_Date_time()
                If chk_CheckCBD2.Checked = True Then D7106.CheckCBD = "2"

                D7106.DateCBDCom = Pub.DAT
                D7106.InchargeCBDCom = Pub.SAW

                Call REWRITE_PFK7106(D7106)
            End If
       

            W7108.CheckUse = "1"

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE"))
        End Try
    End Sub

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

    Private Sub KEY_COUNT_7103()

        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        SQL = "SELECT MAX(CAST(K7103_TypeCode AS DECIMAL)) AS MAX_CODE FROM PFK7103 "
        SQL = SQL + " WHERE K7103_cdTypeCode = '003' "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            W7103.TypeCode = "000001"
        Else
            W7103.TypeCode = Format(CIntp(rd!MAX_CODE + 1), "000000")
        End If

        rd.Close()

    End Sub
#Region "TAB1"
    Private Sub KEY_COUNT_SEQ_TAB1()
        Try

            SQL = " SELECT MAX(K7209_GroupComponentSeq) as MAX_CODE FROM PFK7209 "
            SQL = SQL & " WHERE K7209_GroupComponentBOM  = '" & W7108.GroupComponentBOM & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)

            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W7209.GroupComponentSeq = 1
            Else
                W7209.GroupComponentSeq = CIntp(rd!MAX_CODE + 1)
            End If

            rd.Close()

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub DATA_MOVE_WRITE01_TAB1()
        Try

            Dim i As Integer
            Dim j As Integer
            Dim k As Integer
            Dim l As Integer
            Dim tmpSTR1 As String = ""
            Dim tmpSTR2 As String = ""

            j = 0
            l = 0
            k = 1
            i = 0

            For i = 0 To vS11.ActiveSheet.RowCount - 1
                j = j + 1
                l = l + 1

                Call D7209_CLEAR() : W7209 = D7209

                W7209.GroupComponentBOM = txt_GroupComponentBOM.Data
                W7209.GroupComponentSeq = CIntp(getData(vS11, getColumIndex(vS11, "KEY_GroupComponentSeq"), i))

                If wJOB = 1 Then W7209.GroupComponentSeq = 0

                If K7209_MOVE(vS11, i, W7209, W7209.GroupComponentBOM, W7209.GroupComponentSeq) = False Then
                    W7209.GroupComponentBOM = L7108.GroupComponentBOM

                    Call KEY_COUNT_SEQ_TAB1()

                    W7209.Dseq = j

                    If getData(vS11, getColumIndex(vS11, "KEY_ProcessSeq"), i) = " " Then
                        W7209.ProcessSeq = j
                    Else
                        W7209.ProcessSeq = getData(vS11, getColumIndex(vS11, "KEY_ProcessSeq"), i)
                    End If

                    tmpSTR1 = W7209.ProcessSeq

                    If i <> 0 And tmpSTR1 <> tmpSTR2 And tmpSTR1 <> "" And tmpSTR2 <> "" Then
                        l = l - 1
                        W7209.ProcessSeq = l
                    End If

                    W7209.selGroupComponent = ListCode("GroupComponent")
                    W7209.seDepartment = ListCode("Department")
                    W7209.seShoesStatus = ListCode("ShoesStatus")
                    W7209.seUnitMaterial = ListCode("UnitMaterial")
                    W7209.seSubProcess = ListCode("SubProcess")
                    W7209.seSpecialProcess = ListCode("SpecialProcess")

                    W7209.GrossUsage = W7209.Consumption * (1 + W7209.Loss / 100)

                    If READ_PFK7261(W7209.ContractID, W7209.ContracSeq) Then
                        W7209.Price = D7261.PriceMaterialVND
                    End If

                    If READ_PFK7231(W7209.MaterialCode) Then
                        If D7231.Check1 = "2" Then
                            If READ_PFK7261_GETEXACTLY_NO(W7209.ContractID, W7209.MaterialCode, W7209.ColorCode, CDecp(W7209.Width) + CDecp(W7209.Height)) Then
                                If D7261.PriceCharge > 0 Then
                                    W7209.Price = D7261.PriceMaterialVND + (CDecp(W7209.Width) + CDecp(W7209.Height) - D7261.QtyBasic) * D7261.PriceCharge
                                Else
                                    W7209.Price = D7261.PriceMaterialVND
                                End If
                            End If
                        End If
                    End If

                    If READ_PFK7231(W7209.MaterialCode) Then
                        If D7231.Check1 = "3" Then
                            W7209.Width = CDecp(W7209.Price)
                            If CDecp(txt_QtyTTL.Data) > 0 Then
                                W7209.Price = CDecp(W7209.Price) / CDecp(txt_QtyTTL.Data)
                            Else
                                W7209.Price = 0
                            End If
                        End If

                    End If

                    W7209.PriceMaterial = W7209.Price
                    W7209.PriceRnD = W7209.PriceRnD

                    W7209.MaterialAMT = W7209.Price * W7209.Consumption * (1 + W7209.Loss / 100)
                    W7209.MaterialAMT = W7209.MaterialAMT * (1 + W7209.AddedCost / 100)

                    If READ_PFK7231(W7209.MaterialCode) Then
                        If D7231.Check1 = "5" Then
                            If CDecp(W7209.Width) > 0 Then W7209.MaterialAMT = W7209.MaterialAMT * CDecp(W7209.Height) / CDecp(W7209.Width)
                        End If

                    End If


                    W7209.MaterialAMTPurchasing = W7209.MaterialAMT
                    W7209.MaterialAMTSales = W7209.MaterialAMT

                    Call WRITE_PFK7209(W7209)

                    tmpSTR2 = W7209.ProcessSeq

                Else
                    W7209.Dseq = j

                    If String.Compare(getData(vS11, getColumIndex(vS11, "KEY_ProcessSeq"), i), getData(vS11, getColumIndex(vS11, "Dseq"), i)) = "0" Then
                        W7209.ProcessSeq = W7209.Dseq
                    Else
                        If getData(vS11, getColumIndex(vS11, "KEY_ProcessSeq"), i) = " " Then
                            W7209.ProcessSeq = l
                        Else
                            W7209.ProcessSeq = getData(vS11, getColumIndex(vS11, "KEY_ProcessSeq"), i)
                        End If
                    End If

                    W7209.GrossUsage = W7209.Consumption * (1 + W7209.Loss / 100)

                    tmpSTR1 = W7209.ProcessSeq

                    If i <> 0 And tmpSTR1 = tmpSTR2 Then
                        l = l - 1
                    End If

                    If READ_PFK7261(W7209.ContractID, W7209.ContracSeq) Then
                        W7209.Price = D7261.PriceMaterialVND
                    End If

                    If READ_PFK7231(W7209.MaterialCode) Then
                        If D7231.Check1 = "2" Then


                            If READ_PFK7261_GETEXACTLY_NO(W7209.ContractID, W7209.MaterialCode, W7209.ColorCode, CDecp(W7209.Width) + CDecp(W7209.Height)) Then
                                If D7261.PriceCharge > 0 Then
                                    W7209.Price = D7261.PriceMaterialVND + (CDecp(W7209.Width) + CDecp(W7209.Height) - D7261.QtyBasic) * D7261.PriceCharge
                                Else
                                    W7209.Price = D7261.PriceMaterialVND
                                End If

                            End If
                        End If
                    End If


                    If READ_PFK7231(W7209.MaterialCode) Then
                        If D7231.Check1 = "3" Then
                            W7209.Width = CDecp(txt_QtyTTL.Data)
                            If CDecp(txt_QtyTTL.Data) > 0 Then
                                W7209.Price = CDecp(W7209.Height) / CDecp(txt_QtyTTL.Data)
                            Else
                                W7209.Price = 0
                            End If
                        End If
                    End If

                    W7209.PriceMaterial = W7209.Price
                    W7209.PriceRnD = W7209.PriceRnD


                    W7209.MaterialAMT = W7209.Price * W7209.Consumption * (1 + W7209.Loss / 100)
                    W7209.MaterialAMT = W7209.MaterialAMT * (1 + W7209.AddedCost / 100)

                    If READ_PFK7231(W7209.MaterialCode) Then
                        If D7231.Check1 = "5" Then
                            If CDecp(W7209.Width) > 0 Then W7209.MaterialAMT = W7209.MaterialAMT * CDecp(W7209.Height) / CDecp(W7209.Width)
                        End If

                    End If

                    W7209.MaterialAMTPurchasing = W7209.MaterialAMT
                    W7209.MaterialAMTSales = W7209.MaterialAMT

                    Call REWRITE_PFK7209(W7209)

                    tmpSTR2 = W7209.ProcessSeq

                End If
skip:
            Next

            Call PrcExeNoError("USP_PFK7108C_SHOESCODE_MAKE_NEW_FIRSTVER_TAB1", cn, L7108.ShoesCode, Pub.SAW)

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01_TAB1"))
        End Try

    End Sub

    Private Sub DATA_INSERT_TAB1()
        Try
            Call DATA_MOVE()
            Call KEY_COUNT()

            If WRITE_PFK7108(W7108) = True Then
                Call PrcExe("USP_ISUD7108C_CALCULATION_MOQ_PSC", cn, L7108.GroupComponentBOM)
                Call DATA_MOVE_WRITE01_TAB1()

                isudCHK = True : WRITE_CHK = "*"
                Exit Sub
            End If
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INSERT_TAB1")
        End Try

    End Sub

    Private Sub DATA_UPDATE_TAB1()
        Try
            Call DATA_MOVE()
            If REWRITE_PFK7108(W7108) = True Then
                Call PrcExe("USP_ISUD7108C_CALCULATION_MOQ_PSC", cn, L7108.GroupComponentBOM)
                Call DATA_MOVE_WRITE01_TAB1()

                isudCHK = True
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE_TAB1")
        End Try
    End Sub

    Private Sub DATA_DELETE_TAB1()
        Try

            If READ_PFK7108(L7108.GroupComponentBOM) = True Then
                W7108 = D7108

                SQL = "DELETE FROM PFK7209 "
                SQL = SQL & " WHERE K7209_GroupComponentBOM  = '" & W7108.GroupComponentBOM & "' "
                cmd = New SqlClient.SqlCommand(SQL, cn)
                cmd.ExecuteNonQuery()

                'Call DELETE_PFK7108(W7108)
            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE_TAB1")
        End Try

    End Sub


    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles vS11.CellClick
        vS11.ActiveSheet.ActiveRowIndex = e.Row
        vS11.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub


    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles vS11.KeyDown
        If wJOB = 2 Then Exit Sub

        Dim xCOL As Long
        Dim xROW As Long
        xCOL = vS11.ActiveSheet.ActiveColumnIndex
        xROW = vS11.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Delete

                Call Select_Message("3", WordConv("PROCESSING"), 2)

                If Msg_Result <> vbYes Then Exit Sub

                W7209.GroupComponentBOM = getData(vS11, getColumIndex(vS11, "KEY_GroupComponentBOM"), xROW)
                W7209.GroupComponentSeq = getData(vS11, getColumIndex(vS11, "KEY_GroupComponentSeq"), xROW)

                If READ_PFK7209(W7209.GroupComponentBOM, W7209.GroupComponentSeq) Then
                    W7209 = D7209
                    Call DELETE_PFK7209(W7209)
                End If

                SPR_DEL(vS11, xCOL, xROW)
                vS11.ActiveSheet.ActiveColumnIndex = xCOL
                vS11.ActiveSheet.ActiveRowIndex = xROW
                vS11.Focus()

            Case Keys.Enter
                Select Case xCOL

                End Select
        End Select
    End Sub
    Private Sub vS2_KeyDown(sender As Object, e As KeyEventArgs) Handles vS21.KeyDown
        If wJOB = 2 Then Exit Sub

        Dim xCOL As Long
        Dim xROW As Long
        xCOL = vS21.ActiveSheet.ActiveColumnIndex
        xROW = vS21.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Delete

                Call Select_Message("3", WordConv("PROCESSING"), 2)

                If Msg_Result <> vbYes Then Exit Sub

                SPR_DEL(vS21, xCOL, xROW)
                vS21.ActiveSheet.ActiveColumnIndex = xCOL
                vS21.ActiveSheet.ActiveRowIndex = xROW
                vS21.Focus()

            Case Keys.Enter
                Select Case xCOL

                End Select
        End Select
    End Sub


    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles vS11.Change

        Dim i As Integer
        Dim j As String

        Select Case e.Column

            Case getColumnIndex(vS11, "KEY_ProcessSeq")

                For i = vS11.ActiveSheet.ActiveRowIndex To vS11.ActiveSheet.RowCount

                    j = getData(vS11, getColumnIndex(vS11, "KEY_ProcessSeq"), i)

                    If IsNumeric(j) = True Then
                        setData(vS11, getColumnIndex(vS11, "KEY_ProcessSeq"), i + 1, j + 1)
                    Else
                        setData(vS11, getColumnIndex(vS11, "KEY_ProcessSeq"), i + 1, i + 1)
                    End If

                Next

        End Select


    End Sub
#End Region

#Region "TAB2"
    Private Sub KEY_COUNT_SEQ_TAB2()
        Try

            SQL = " SELECT MAX(K7208_GroupComponentSeq) as MAX_CODE FROM PFK7208 "
            SQL = SQL & " WHERE K7208_GroupComponentBOM  = '" & W7108.GroupComponentBOM & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)

            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W7208.GroupComponentSeq = 1
            Else
                W7208.GroupComponentSeq = CIntp(rd!MAX_CODE + 1)
            End If

            rd.Close()

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub DATA_MOVE_WRITE01_TAB2()
        Try

            Dim i As Integer
            Dim j As Integer
            Dim k As Integer
            Dim l As Integer
            Dim tmpSTR1 As String = ""
            Dim tmpSTR2 As String = ""

            j = 0
            l = 0
            k = 1
            i = 0

            For i = 0 To vS21.ActiveSheet.RowCount - 1
                j = j + 1
                l = l + 1

                Call D7208_CLEAR() : W7208 = D7208

                W7208.GroupComponentBOM = txt_GroupComponentBOM.Data
                W7208.GroupComponentSeq = CIntp(getData(vS21, getColumIndex(vS21, "KEY_GroupComponentSeq"), i))

                If wJOB = 1 Then W7208.GroupComponentSeq = 0

                If K7208_MOVE(vS21, i, W7208, W7208.GroupComponentBOM, W7208.GroupComponentSeq) = False Then
                    W7208.GroupComponentBOM = L7108.GroupComponentBOM

                    Call KEY_COUNT_SEQ_TAB2()

                    W7208.Dseq = j

                    If getData(vS21, getColumIndex(vS21, "KEY_ProcessSeq"), i) = " " Then
                        W7208.ProcessSeq = j
                    Else
                        W7208.ProcessSeq = getData(vS21, getColumIndex(vS21, "KEY_ProcessSeq"), i)
                    End If

                    tmpSTR1 = W7208.ProcessSeq

                    If i <> 0 And tmpSTR1 <> tmpSTR2 And tmpSTR1 <> "" And tmpSTR2 <> "" Then
                        l = l - 1
                        W7208.ProcessSeq = l
                    End If

                    W7208.selGroupComponent = ListCode("GroupComponent")
                    W7208.seDepartment = ListCode("Department")
                    W7208.seShoesStatus = ListCode("ShoesStatus")
                    W7208.seUnitMaterial = ListCode("UnitMaterial")
                    W7208.seSubProcess = ListCode("SubProcess")
                    W7208.seSpecialProcess = ListCode("SpecialProcess")

                    W7208.GrossUsage = W7208.Consumption * (1 + W7208.Loss / 100)
                    W7208.Consumption = 1

                    W7208.PriceMaterial = W7208.Price
                    W7208.PriceRnD = W7208.PriceRnD

                    W7208.MaterialAMT = W7208.Price * W7208.Consumption * (1 + W7208.Loss / 100)
                    W7208.MaterialAMTPurchasing = W7208.MaterialAMT
                    W7208.MaterialAMTSales = W7208.MaterialAMT

                    Call WRITE_PFK7208(W7208)

                    tmpSTR2 = W7208.ProcessSeq

                Else
                    W7208.Dseq = j

                    If String.Compare(getData(vS21, getColumIndex(vS21, "KEY_ProcessSeq"), i), getData(vS21, getColumIndex(vS21, "Dseq"), i)) = "0" Then
                        W7208.ProcessSeq = W7208.Dseq
                    Else
                        If getData(vS21, getColumIndex(vS21, "KEY_ProcessSeq"), i) = " " Then
                            W7208.ProcessSeq = l
                        Else
                            W7208.ProcessSeq = getData(vS21, getColumIndex(vS21, "KEY_ProcessSeq"), i)
                        End If
                    End If

                    W7208.GrossUsage = W7208.Consumption * (1 + W7208.Loss / 100)

                    tmpSTR1 = W7208.ProcessSeq

                    If i <> 0 And tmpSTR1 = tmpSTR2 Then
                        l = l - 1
                    End If


                    W7208.Consumption = 1
                    W7208.PriceMaterial = W7208.Price
                    W7208.PriceRnD = W7208.PriceRnD


                    W7208.MaterialAMT = W7208.Price * W7208.Consumption * (1 + W7208.Loss / 100)
                    W7208.MaterialAMTPurchasing = W7208.MaterialAMT
                    W7208.MaterialAMTSales = W7208.MaterialAMT

                    Call REWRITE_PFK7208(W7208)

                    tmpSTR2 = W7208.ProcessSeq

                End If
skip:
            Next

            Call PrcExeNoError("USP_PFK7108C_SHOESCODE_MAKE_NEW_FIRSTVER_TAB2", cn, L7108.ShoesCode, Pub.SAW)

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01_TAB2"))
        End Try

    End Sub

    Private Sub DATA_INSERT_TAB2()
        Try
            Call DATA_MOVE()
            Call KEY_COUNT()

            If WRITE_PFK7108(W7108) = True Then
                Call PrcExe("USP_ISUD7108C_CALCULATION_MOQ_PSC", cn, L7108.GroupComponentBOM)

                Call DATA_MOVE_WRITE01_TAB2()

                isudCHK = True : WRITE_CHK = "*"
                Exit Sub
            End If
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INSERT_TAB2")
        End Try

    End Sub

    Private Sub DATA_UPDATE_TAB2()
        Try
            Call DATA_MOVE()
            If REWRITE_PFK7108(W7108) = True Then
                Call PrcExe("USP_ISUD7108C_CALCULATION_MOQ_PSC", cn, L7108.GroupComponentBOM)

                Call DATA_MOVE_WRITE01_TAB2()

                isudCHK = True
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE_TAB2")
        End Try
    End Sub

    Private Sub DATA_DELETE_TAB2()
        Try

            If READ_PFK7108(L7108.GroupComponentBOM) = True Then
                W7108 = D7108

                SQL = "DELETE FROM PFK7208 "
                SQL = SQL & " WHERE K7208_GroupComponentBOM  = '" & W7108.GroupComponentBOM & "' "
                cmd = New SqlClient.SqlCommand(SQL, cn)
                cmd.ExecuteNonQuery()

                'Call DELETE_PFK7108(W7108)
            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE_TAB2")
        End Try

    End Sub

#End Region
#Region "TAB2"
    Private Sub KEY_COUNT_SEQ_TAB3()
        Try

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub DATA_MOVE_WRITE01_TAB3()

        Call PrcExeNoError("USP_PFK7108C_SHOESCODE_MAKE_NEW_FIRSTVER_TAB3", cn, L7108.ShoesCode, txt_ColorCode.Data, txt_VerBOM.Data, txt_VerCBD.Data, txt_VerJob.Data, Pub.SAW)


    End Sub

    Private Sub DATA_INSERT_TAB3()
        Try
            Call DATA_MOVE()
            Call KEY_COUNT()

            If WRITE_PFK7108(W7108) = True Then
                Call PrcExe("USP_ISUD7108C_CALCULATION_MOQ_PSC", cn, L7108.GroupComponentBOM)
                Call DATA_MOVE_WRITE01_TAB3()

                isudCHK = True : WRITE_CHK = "*"
                Exit Sub
            End If
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INSERT_TAB3")
        End Try

    End Sub

    Private Sub DATA_UPDATE_TAB3()
        Try
            Call DATA_MOVE()
            If REWRITE_PFK7108(W7108) = True Then
                Call PrcExe("USP_ISUD7108C_CALCULATION_MOQ_PSC", cn, L7108.GroupComponentBOM)

                Call DATA_MOVE_WRITE01_TAB3()

                isudCHK = True
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE_TAB3")
        End Try
    End Sub

    Private Sub DATA_DELETE_TAB3()
        Try

            If READ_PFK7108(L7108.GroupComponentBOM) = True Then
                W7108 = D7108

                SQL = "DELETE FROM PFK7204 "
                SQL = SQL & " WHERE K7204_GroupComponentBOM  = '" & W7108.GroupComponentBOM & "' "
                cmd = New SqlClient.SqlCommand(SQL, cn)
                cmd.ExecuteNonQuery()

                'Call DELETE_PFK7108(W7108)
            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE_TAB3")
        End Try

    End Sub

#End Region
    Private Sub KEY_COUNT()
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

            txt_GroupComponentBOM.Data = W7108.GroupComponentBOM
            L7108.GroupComponentBOM = W7108.GroupComponentBOM

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub



#End Region

#Region "Event"

    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Dim Starting As Object
        Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")


        Try
            If ptc_Main.SelectedIndex = 1 Then
                Select Case wJOB
                    Case 1
                        If Data_Check() = False Then Exit Sub

                        Call KEY_COUNT()
                        Call DATA_INSERT_TAB1()
                        Call PrcExe("USP_ISUD7108C_CALCULATION_MOQ_PSC", cn, L7108.GroupComponentBOM)

                        MsgBoxP("Save Successfully!", vbInformation)
                        wJOB = 3
                        Call DATA_SEARCH01()
                        Call DATA_SEARCH_VS11()

                    Case 2
                        Me.Dispose()
                    Case 3
                        If Data_Check() = False Then Exit Sub

                        Call DATA_UPDATE_TAB1()
                        Call PrcExe("USP_ISUD7108C_CALCULATION_MOQ_PSC", cn, L7108.GroupComponentBOM)

                        MsgBoxP("Save Successfully!", vbInformation)
                        Call DATA_SEARCH01()
                        Call DATA_SEARCH_VS11()
                    Case 4
                        Call DATA_DELETE_TAB1()
                End Select
            End If

            If ptc_Main.SelectedIndex = 2 Then
                Select Case wJOB
                    Case 1
                        If Data_Check() = False Then Exit Sub

                        Call KEY_COUNT()
                        Call DATA_INSERT_TAB2()
                        Call PrcExe("USP_ISUD7108C_CALCULATION_MOQ_PSC", cn, L7108.GroupComponentBOM)
                        MsgBoxP("Save Successfully!", vbInformation)
                        wJOB = 3
                        Call DATA_SEARCH01()
                        Call DATA_SEARCH_vS21()

                    Case 2
                        Me.Dispose()
                    Case 3
                        If Data_Check() = False Then Exit Sub

                        Call DATA_UPDATE_TAB2()
                        Call PrcExe("USP_ISUD7108C_CALCULATION_MOQ_PSC", cn, L7108.GroupComponentBOM)
                        MsgBoxP("Save Successfully!", vbInformation)
                        Call DATA_SEARCH01()
                        Call DATA_SEARCH_vS21()
                    Case 4
                        Call DATA_DELETE_TAB2()
                End Select
            End If

            If ptc_Main.SelectedIndex = 3 Then
                Select Case wJOB
                    Case 1
                        If Data_Check() = False Then Exit Sub

                        Call KEY_COUNT()
                        Call DATA_INSERT_TAB3()
                        Call PrcExe("USP_ISUD7108C_CALCULATION_MOQ_PSC", cn, L7108.GroupComponentBOM)
                        MsgBoxP("Save Successfully!", vbInformation)
                        wJOB = 3
                        Call DATA_SEARCH_vS31()

                    Case 2
                        Me.Dispose()
                    Case 3
                        If Data_Check() = False Then Exit Sub

                        Call DATA_UPDATE_TAB3()
                        Call PrcExe("USP_ISUD7108C_CALCULATION_MOQ_PSC", cn, L7108.GroupComponentBOM)
                        MsgBoxP("Save Successfully!", vbInformation)

                        Call DATA_SEARCH_vS31()
                    Case 4
                        Call DATA_DELETE_TAB3()
                End Select
            End If

        Catch ex As Exception

        Finally
            Starting.close()
        End Try
    End Sub

    Private Sub tst_iClose_Click(sender As Object, e As EventArgs) Handles tst_iClose.Click
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

        If ptc_Main.SelectedIndex = 1 Then Call DATA_DELETE_TAB1() : Call DATA_SEARCH_VS11()
        If ptc_Main.SelectedIndex = 2 Then Call DATA_DELETE_TAB2() : Call DATA_SEARCH_vS21()
        If ptc_Main.SelectedIndex = 3 Then Call DATA_DELETE_TAB3() : Call DATA_SEARCH_vS31()

        Me.Dispose()
    End Sub


    Private Sub txt_cdMasterBOM_Load(sender As Object, e As EventArgs) Handles txt_cdMasterBOM.btnTitleClick
        Dim xROW As Integer

        xROW = vS11.ActiveSheet.ActiveRowIndex
        If vS11.ActiveSheet.ActiveRowIndex < 0 Then Exit Sub

        If HLP7301A.Link_HLP7301A("") = False Then Exit Sub

        If hlp0000SeVa = "" Then Exit Sub
        DS1 = PrcDS("USP_ISUD7301A_SEARCH_VS1", cn, hlp0000SeVaTt)

        Call READ_SPREAD_N(vS11, DS1, xROW, GetDsRc(DS1), "USP_ISUD7108C_SEARCH_VS11", "vS11")

    End Sub


    Private Sub txt_BaseBom_Load(sender As Object, e As EventArgs) Handles txt_MasterBom.btnTitleClick
        Dim xROW As Integer

        xROW = vS11.ActiveSheet.ActiveRowIndex
        If vS11.ActiveSheet.ActiveRowIndex < 0 Then Exit Sub

        If HLP7108F.Link_HLP7108F = False Then Exit Sub

        If hlp0000SeVa = "" Then Exit Sub
        DS1 = PrcDS("USP_ISUD7108C_SEARCH_VS11_COPY_BOM", cn, hlp0000SeVaTt)

        Call READ_SPREAD_N(vS11, DS1, xROW, GetDsRc(DS1), "USP_ISUD7108C_SEARCH_vS11", "vS11")

    End Sub

    Private Sub cmd_SupplierCost_Load(sender As Object, e As EventArgs) Handles cmd_SupplierCost.btnTitleClick
        Dim xROW As Integer
        Dim MaterialCode As String

        xROW = vS11.ActiveSheet.ActiveRowIndex

        MaterialCode = getData(vS11, getColumIndex(vS11, "MaterialCode"), xROW)

        If vS11.ActiveSheet.ActiveRowIndex < 0 Then Exit Sub

        If HLP7260A.Link_HLP7260A(MaterialCode, "2") = False Then Exit Sub
        If READ_PFK7260(D7261.ContractID) Then
            setData(vS11, getColumIndex(vS11, "SupplierCode"), xROW, D7260.CustomerCode)
            setData(vS11, getColumIndex(vS11, "PriceMaterial"), xROW, D7261.PriceMaterialVND)
            setData(vS11, getColumIndex(vS11, "Price"), xROW, D7261.PriceMaterialVND)

            If READ_PFK7101(D7260.CustomerCode) Then
                setData(vS11, getColumIndex(vS11, "SupplierName"), xROW, D7101.CustomerName)
            End If

            setData(vS11, getColumIndex(vS11, "ContractID"), xROW, D7261.ContractID)
            setData(vS11, getColumIndex(vS11, "ContracSeq"), xROW, D7261.ContracSeq)

            setData(vS11, getColumIndex(vS11, "ColorCode"), xROW, D7261.ColorCode)
            setData(vS11, getColumIndex(vS11, "ColorName"), xROW, D7261.ColorName)

        End If
    End Sub

    Private Sub cmd_AttachMaterialToSupplier_Click(sender As Object, e As EventArgs) Handles cmd_AttachMaterialToSupplier.Click
        'If vS11.Focused = False Then Exit Sub

        MessSer = MsgBox("Do you want to update the price of CBD", vbYesNo)
        If MessSer <> vbYes Then Exit Sub


        Try
           
            If PrcExe("USP_ISUD7108C_CALCULATION_MOQ_PSC", cn, L7108.GroupComponentBOM) Then
                MsgBox("Successfully Update CBD !", vbInformation)
                Call DATA_SEARCH_VS11()
            End If

        Catch ex As Exception

        End Try
     
    End Sub

    Private Sub chk_Group_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Group.CheckedChanged
        PeaceSplitContainer1.Panel1Collapsed = Not chk_Group.Checked
        PeaceSplitContainer2.Panel1Collapsed = Not chk_Group.Checked
        PeaceSplitContainer3.Panel1Collapsed = Not chk_Group.Checked
        'PeaceSplitContainer4.Panel1Collapsed = Not chk_Group.Checked

        If ptc_Main.SelectedIndex = 0 And chk_Group.Checked Then DATA_SEARCH_vS00()
        If ptc_Main.SelectedIndex = 1 And chk_Group.Checked Then DATA_SEARCH_VS10()
        If ptc_Main.SelectedIndex = 2 And chk_Group.Checked Then DATA_SEARCH_vS20()
        If ptc_Main.SelectedIndex = 3 And chk_Group.Checked Then DATA_SEARCH_vS30()

    End Sub

    Private Sub Cms_1_Click(sender As Object, e As EventArgs) Handles Cms_1.ItemClicked
        Dim HistoryCode As String
        Dim CheckDefault As String


        If ptc_Main.SelectedIndex = 0 Then
            HistoryCode = getData(vS00, getColumIndex(vS00, "KEY_HistoryCode"), vS00.ActiveSheet.ActiveRowIndex)
            CheckDefault = getDataM(vS00, getColumIndex(vS00, "CheckDefault"), vS00.ActiveSheet.ActiveRowIndex)


            Select Case True
                Case Cms_1.Items(3).Selected
                    Cms_1.Hide()
                    Try

                        If CheckDefault = "2" Then Me.Tst_Main.Enabled = False : Call DATA_SEARCH_VS11_HistoryCode(HistoryCode)
                        If CheckDefault = "1" Then Me.Tst_Main.Enabled = True : Call DATA_SEARCH_VS11()
                    Catch ex As Exception

                    End Try

            End Select

        End If


        If ptc_Main.SelectedIndex = 1 Then
            HistoryCode = getData(vS10, getColumIndex(vS10, "KEY_HistoryCode"), vS10.ActiveSheet.ActiveRowIndex)
            CheckDefault = getDataM(vS10, getColumIndex(vS10, "CheckDefault"), vS10.ActiveSheet.ActiveRowIndex)

            Select Case True
                Case Cms_1.Items(0).Selected
                    Cms_1.Hide()
                    Try
                        Call PrcExeNoError("USP_PFK7108C_SHOESCODE_MAKE_DEFAULT", cn, L7108.ShoesCode, HistoryCode, Pub.SAW)

                    Catch ex As Exception

                    End Try

                Case Cms_1.Items(1).Selected
                    Cms_1.Hide()
                    Try
                        Dim HistoryName As String
                        Dim Remark As String
                        Dim HistoryNo As String
                        HistoryCode = getData(vS10, getColumIndex(vS10, "KEY_HistoryCode"), vS10.ActiveSheet.ActiveRowIndex)

                        HistoryName = getData(vS10, getColumIndex(vS10, "HistoryName"), vS10.ActiveSheet.ActiveRowIndex)
                        HistoryNo = getData(vS10, getColumIndex(vS10, "HistoryNo"), vS10.ActiveSheet.ActiveRowIndex)
                        Remark = getData(vS10, getColumIndex(vS10, "Remark"), vS10.ActiveSheet.ActiveRowIndex)

                        If CheckDefault = "1" Then
                            txt_VerCBD.Data = HistoryNo
                            Call PrcExeNoError("USP_PFK7108C_SHOESCODE_UPDATE_HISTORY_TAB1", cn, HistoryCode, HistoryName, HistoryNo, Remark, Pub.DAT, Pub.SAW)
                        Else
                            MsgBoxP("It's not current verion !") : Exit Select

                        End If

                    Catch ex As Exception

                    End Try

                Case Cms_1.Items(2).Selected
                    Cms_1.Hide()
                    Try
                        Call PrcExeNoError("USP_PFK7108C_SHOESCODE_MAKE_NEW_TAB1", cn, L7108.ShoesCode, Pub.SAW)
                        Call DATA_SEARCH_VS10()
                        Call DATA_SEARCH_VS11()

                    Catch ex As Exception

                    End Try

                Case Cms_1.Items(3).Selected
                    Cms_1.Hide()
                    Try

                        If CheckDefault = "2" Then Me.Tst_Main.Enabled = False : Call DATA_SEARCH_VS11_HistoryCode(HistoryCode)
                        If CheckDefault = "1" Then Me.Tst_Main.Enabled = True : Call DATA_SEARCH_VS11()
                    Catch ex As Exception

                    End Try

            End Select

        End If

        If ptc_Main.SelectedIndex = 2 Then
            HistoryCode = getData(vS20, getColumIndex(vS20, "KEY_HistoryCode"), vS20.ActiveSheet.ActiveRowIndex)
            CheckDefault = getDataM(vS20, getColumIndex(vS20, "CheckDefault"), vS20.ActiveSheet.ActiveRowIndex)


            Select Case True
                Case Cms_1.Items(0).Selected
                    Cms_1.Hide()
                    Try
                        Call PrcExeNoError("USP_PFK7108C_SHOESCODE_MAKE_DEFAULT", cn, L7108.ShoesCode, HistoryCode, Pub.SAW)

                    Catch ex As Exception

                    End Try

                Case Cms_1.Items(1).Selected
                    Cms_1.Hide()
                    Try
                        Dim HistoryName As String
                        Dim Remark As String
                        Dim HistoryNo As String
                        HistoryCode = getData(vS20, getColumIndex(vS20, "KEY_HistoryCode"), vS20.ActiveSheet.ActiveRowIndex)

                        HistoryName = getData(vS20, getColumIndex(vS20, "HistoryName"), vS20.ActiveSheet.ActiveRowIndex)
                        HistoryNo = getData(vS20, getColumIndex(vS20, "HistoryNo"), vS20.ActiveSheet.ActiveRowIndex)
                        Remark = getData(vS20, getColumIndex(vS20, "Remark"), vS20.ActiveSheet.ActiveRowIndex)

                        If CheckDefault = "1" Then
                            txt_VerJob.Data = HistoryNo
                            Call PrcExeNoError("USP_PFK7108C_SHOESCODE_UPDATE_HISTORY_TAB2", cn, HistoryCode, HistoryName, HistoryNo, Remark, Pub.DAT, Pub.SAW)
                        Else
                            MsgBoxP("It's not current verion !") : Exit Select

                        End If

                    Catch ex As Exception

                    End Try

                Case Cms_1.Items(2).Selected
                    Cms_1.Hide()
                    Try
                        Call PrcExeNoError("USP_PFK7108C_SHOESCODE_MAKE_NEW_TAB2", cn, L7108.ShoesCode, Pub.SAW)
                        Call DATA_SEARCH_vS20()
                        Call DATA_SEARCH_vS21()

                    Catch ex As Exception

                    End Try

                Case Cms_1.Items(3).Selected
                    Cms_1.Hide()
                    Try

                        If CheckDefault = "2" Then Me.Tst_Main.Enabled = False : Call DATA_SEARCH_vS21_HistoryCode(HistoryCode)
                        If CheckDefault = "1" Then Me.Tst_Main.Enabled = True : Call DATA_SEARCH_vS21()
                    Catch ex As Exception

                    End Try

            End Select

        End If

    End Sub
    Private Sub ptc_Main_DoubleClick(sender As Object, e As EventArgs) Handles ptc_Main.DoubleClick
        If formA = False Then ptc_Main.SelectedIndex = 0
        If Me.form_Close = True Then Exit Sub

        Select Case ptc_Main.SelectedIndex
            Case 0
                Call DATA_SEARCH_vS00()
                Call DATA_SEARCH_vS01()

            Case 1
                Call DATA_SEARCH_VS10()
                Call DATA_SEARCH_VS11()

            Case 2
                Call DATA_SEARCH_vS20()
                Call DATA_SEARCH_vS21()

            Case 3
                PeaceSplitContainer4.Panel1Collapsed = False
                Call DATA_SEARCH_vS30()
                Call DATA_SEARCH_vS31()
        End Select
    End Sub
    Private Sub ptc_Main_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ptc_Main.SelectedIndexChanged
        Exit Sub
        If formA = False Then Exit Sub
        If ptc_Main.SelectedIndex = -1 Then Exit Sub
        If Me.form_Close = True Then Exit Sub


        If formA = False Then ptc_Main.SelectedIndex = 0

        Select Case ptc_Main.SelectedIndex
            Case 0
                Call DATA_SEARCH_vS00()
                Call DATA_SEARCH_vS01()

            Case 1
                Call DATA_SEARCH_VS10()
                Call DATA_SEARCH_VS11()

            Case 2
                Call DATA_SEARCH_vS20()
                Call DATA_SEARCH_vS21()

            Case 3
                Call DATA_SEARCH_vS30()
                Call DATA_SEARCH_vS31()

        End Select

    End Sub

    Private Sub cmd_GC_btnTitleClick(sender As Object, e As EventArgs) Handles cmd_GC.btnTitleClick
        If READ_PFK7108_SHOESCODE(txt_ShoesCode.Code) Then
            If ISUD7108A.Link_ISUD7108A(wJOB, D7108.GroupComponentBOM, "PFP71060") = False Then Exit Sub
            Call DATA_SEARCH01()
        End If
    End Sub

    Private Sub txt_CBDProcess_btnTitleClick(sender As Object, e As EventArgs) Handles txt_CBDProcess.btnTitleClick

    End Sub

    Private Sub cmd_Process_btnTitleClick(sender As Object, e As EventArgs) Handles cmd_Process.btnTitleClick
        If READ_PFK7305_SHOESCODE(txt_ShoesCode.Code) Then
            If ISUD7305A.Link_ISUD7305A(wJOB, D7305.ProcessBOMCode, "PFP73050") = False Then Exit Sub
            Call DATA_SEARCH01()
        End If
    End Sub

    Private Sub cmd_Job_btnTitleClick(sender As Object, e As EventArgs) Handles cmd_JOB.btnTitleClick
        If READ_PFK7311_SHOESCODE(txt_ShoesCode.Code) Then
            If ISUD7311A.Link_ISUD7311A(wJOB, D7311.JobBOMCode, "PFP73110") = False Then Exit Sub
            Call DATA_SEARCH01()
        End If
    End Sub
#End Region

    Private Sub cmd_ItemCode_Load(sender As Object, e As EventArgs) Handles cmd_ItemCode.btnTitleClick
        If READ_PFK7106(txt_ShoesCode.Code) Then
            If ISUD7106A.Link_ISUD7106A(wJOB, D7106.ShoesCode, "PFP71060") = False Then Exit Sub
            Call DATA_SEARCH01()
        End If
    End Sub

    Private Sub cmd_FileUpload_Click(sender As Object, e As EventArgs) Handles cmd_FileUpload.Click
        Try
            If ISUD7555A.Link_ISUD7555A(3, "ISUD7171A", "001;950") = False Then Exit Sub
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_BuyerRule_Click(sender As Object, e As EventArgs) Handles cmd_BuyerRule.Click
        Try
            If READ_PFK7171_SIMPLENAME(ListCode("CBD"), txt_Customercode.Code) Then
                Call ISUD7171A.Link_ISUD7171A("3", D7171.BasicSel, D7171.BasicCode, "PFP71710")

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_UpdatePrice_Click(sender As Object, e As EventArgs) Handles cmd_UpdatePrice.Click
        Try
            If vS11.Focused = False Then Exit Sub

            MessSer = MsgBox("Do you want to update the price of CBD", vbYesNo)
            If MessSer <> vbYes Then Exit Sub

            Dim i As Integer
            Dim MaterialCode As String
            Dim ColorCode As String
            Dim SupplierCode As String

            For i = 0 To vS11.ActiveSheet.RowCount - 1
                MaterialCode = getData(vS11, getColumIndex(vS11, "MaterialCode"), i)
                ColorCode = getData(vS11, getColumIndex(vS11, "ColorCode"), i)
                SupplierCode = getData(vS11, getColumIndex(vS11, "SupplierCode"), i)

                If MaterialCode = "" Then GoTo next1
                If READ_PFK7231(MaterialCode) = False Then GoTo next1
                If D7231.Check1 <> "1" Then GoTo next1

                If SupplierCode = "" Then
                    Msg_Result = MsgBox("Do you want to matching without supplier !", vbYesNo)
                    If Msg_Result = vbNo Then GoTo next1
                    If READ_PFK7261_MATERIALCODE_COLORCODE_NOSUPPLIERCODE(MaterialCode, ColorCode) Then

                        Call READ_PFK7260(D7261.ContractID)

                        setData(vS11, getColumIndex(vS11, "SupplierCode"), i, D7260.CustomerCode)
                        setData(vS11, getColumIndex(vS11, "PriceMaterial"), i, D7261.PriceMaterialVND)
                        setData(vS11, getColumIndex(vS11, "Price"), i, D7261.PriceMaterialVND)

                        If READ_PFK7101(D7260.CustomerCode) Then
                            setData(vS11, getColumIndex(vS11, "SupplierName"), i, D7101.CustomerName)
                        End If

                        setData(vS11, getColumIndex(vS11, "ColorCode"), i, D7261.ColorCode)
                        setData(vS11, getColumIndex(vS11, "ColorName"), i, D7261.ColorName)

                        setData(vS11, getColumIndex(vS11, "ContractID"), i, D7261.ContractID)
                        setData(vS11, getColumIndex(vS11, "ContracSeq"), i, D7261.ContracSeq)
                        GoTo next1
                    End If

                    GoTo next1
                End If

                If READ_PFK7261_MATERIALCODE_COLORCODE_SUPPLIERCODE(MaterialCode, ColorCode, SupplierCode) Then
                    Call READ_PFK7260(D7261.ContractID)

                    setData(vS11, getColumIndex(vS11, "SupplierCode"), i, D7260.CustomerCode)
                    setData(vS11, getColumIndex(vS11, "PriceMaterial"), i, D7261.PriceMaterialVND)
                    setData(vS11, getColumIndex(vS11, "Price"), i, D7261.PriceMaterialVND)

                    If READ_PFK7101(D7260.CustomerCode) Then
                        setData(vS11, getColumIndex(vS11, "SupplierName"), i, D7101.CustomerName)
                    End If

                    setData(vS11, getColumIndex(vS11, "ColorCode"), i, D7261.ColorCode)
                    setData(vS11, getColumIndex(vS11, "ColorName"), i, D7261.ColorName)

                    setData(vS11, getColumIndex(vS11, "ContractID"), i, D7261.ContractID)
                    setData(vS11, getColumIndex(vS11, "ContracSeq"), i, D7261.ContracSeq)
                    GoTo next1
                End If

                If READ_PFK7261_MATERIALCODE_SUPPLIERCODE(MaterialCode, SupplierCode) Then
                    Call READ_PFK7260(D7261.ContractID)

                    setData(vS11, getColumIndex(vS11, "SupplierCode"), i, D7260.CustomerCode)
                    setData(vS11, getColumIndex(vS11, "PriceMaterial"), i, D7261.PriceMaterialVND)
                    setData(vS11, getColumIndex(vS11, "Price"), i, D7261.PriceMaterialVND)

                    If READ_PFK7101(D7260.CustomerCode) Then
                        setData(vS11, getColumIndex(vS11, "SupplierName"), i, D7101.CustomerName)
                    End If

                    setData(vS11, getColumIndex(vS11, "ContractID"), i, D7261.ContractID)
                    setData(vS11, getColumIndex(vS11, "ContracSeq"), i, D7261.ContracSeq)
                End If


next1:
            Next


        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_cdMasterBOM_Load_1(sender As Object, e As EventArgs) Handles txt_cdMasterBOM.Load

    End Sub

    Private Sub vS30_CellClick(sender As Object, e As CellClickEventArgs) Handles vS30.CellClick
        txt_VerALL.Data = getData(vS30, getColumIndex(vS30, "KEY_HistoryCode"), e.Row)

        Call DATA_SEARCH_vS31()
    End Sub

    Private Sub cmd_UnComplete_Click(sender As Object, e As EventArgs) Handles cmd_UnComplete.Click
        Try
            If bolCheckCBD = False Then
                If MsgBoxPPW("Please type the password to modify!", const_pwMCBD) = False Then Exit Sub
                bolCheckCBD = True
            End If

            If READ_PFK7106(L7108.ShoesCode) Then
                D7106.CheckCBD = "2"
                D7106.DateCBDUn = Pub.DAT
                D7106.InchargeCBDUn = Pub.SAW

                Call REWRITE_PFK7106(D7106)
                isudCHK = True
                Me.Dispose()

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class