Public Class ISUD3208O
#Region "Variable"
    Private wJOB As Integer

    Private W7231 As T7231_AREA

    Private L7106 As T7106_AREA

    Private W3208 As T3208_AREA
    Private L3208 As T3208_AREA

    Private W3209 As T3209_AREA
    Private L3209 As T3209_AREA

    Private W7103 As T7103_AREA

    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD3208O(job As Integer, GroupComponentBOM As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D3208.GroupComponentBOM = GroupComponentBOM

        If job = "1" Then
            D3208.GroupComponentBOM = ""
            D3208.ShoesCode = GroupComponentBOM
            L3208.ShoesCode = GroupComponentBOM
            txt_ShoesCode.Data = GroupComponentBOM
        End If


        wJOB = job : L3208 = D3208 : L7106 = D7106

        Link_ISUD3208O = False
        Try
            Select Case job
                Case 1
                Case Else
                    If READ_PFK3208(GroupComponentBOM) = False Then
                        Call MsgBoxP("You have no right is this ShoesCode !")
                        Me.Dispose()

                        Exit Function
                    End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD3208O = isudCHK


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

                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()

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
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()

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
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()

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
              
                tst_iDelete.Visible = True
                tst_iSave.Visible = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Try
            txt_GroupComponentBOM.Enabled = False
            Call D3208_CLEAR()
            W3208 = D3208

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()
        Vs1.AllowRowMove = True
        PeaceSplitContainer1.Panel1Collapsed = True
        Call Cms_additem(Cms_1,
                     WordConv("CHECK DEFAULT VERSION"),
                     WordConv("UPDATE INFORMATION"),
                     WordConv("MAKE NEW VERSION"),
                     WordConv("CHECK DATA VERSION"))

        vS0.ContextMenuStrip = Cms_1

    End Sub
#End Region

#Region "Data_Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Try

            If READ_PFK3208(L3208.GroupComponentBOM) Then
                L3208.ShoesCode = D3208.ShoesCode
            End If

            DS1 = READ_PFK7106(L3208.ShoesCode, cn)

            If GetDsRc(DS1) > 0 Then
                READER_MOVE(Me, DS1)

            End If


            DS1 = Nothing

            DS1 = READ_PFK3208(L3208.GroupComponentBOM, cn)

            If GetDsRc(DS1) = 0 Then
                Exit Function
                isudCHK = False
            End If

            READER_MOVE(Me, DS1)

            If GetDsData(DS1, 0, "K3208_CheckUse") = "1" Then
                rad_CheckUse1.Checked = True
                rad_CheckUse2.Checked = False
            Else
                rad_CheckUse1.Checked = False
                rad_CheckUse2.Checked = True
            End If




            DATA_SEARCH01 = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH01")
        End Try

    End Function

    Private Function DATA_SEARCH_VS0() As Boolean
        DATA_SEARCH_VS0 = False

        DS1 = PrcDS("USP_ISUD3208O_SEARCH_VS0", cn, L3208.ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(VS0, , , , OperationMode.Normal)
            SPR_PRO_NEW(VS0, DS1, "USP_ISUD3208O_SEARCH_VS0", "VS0")

            VS0.Enabled = True
            Exit Function
        End If
        SPR_SET(VS0, , , , OperationMode.Normal)
        SPR_PRO_NEW(VS0, DS1, "USP_ISUD3208O_SEARCH_VS0", "VS0")

        DATA_SEARCH_VS0 = True


    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        DS1 = PrcDS("USP_ISUD3208O_SEARCH_VS1", cn, L3208.GroupComponentBOM)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(Vs1, , , , OperationMode.Normal)
            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3208O_SEARCH_VS1", "Vs1")

            Vs1.ActiveSheet.RowCount = 1
            Vs1.Enabled = True
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3208O_SEARCH_VS1", "Vs1")


        DATA_SEARCH_VS1 = True


    End Function

    Private Function DATA_SEARCH_VS1_HistoryCode(HistoryCode) As Boolean
        DATA_SEARCH_VS1_HistoryCode = False

        DS1 = PrcDS("USP_ISUD3208O_SEARCH_VS1_HISTORY", cn, HistoryCode)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(Vs1, , , , OperationMode.Normal)
            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3208O_SEARCH_VS1", "Vs1")

            Vs1.Enabled = True
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3208O_SEARCH_VS1", "Vs1")

        DATA_SEARCH_VS1_HistoryCode = True
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
                If READ_PFK3208(L3208.GroupComponentBOM) = True Then
                    Call MsgBoxP("5", "DATA_INSERT")
                    txt_GroupComponentBOM.Focus()
                    KEY_COUNT()
                    Exit Function
                End If
            End If

            W3208.CheckUse = "1"

            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If FormatCut(getData(Vs1, getColumIndex(Vs1, "MaterialName"), i)) = "" Then rad_CheckUse2.Checked = True : W3208.CheckUse = "2"
                If FormatCut(getData(Vs1, getColumIndex(Vs1, "ComponentName"), i)) = "" Then rad_CheckUse2.Checked = True : W3208.CheckUse = "2"
                If FormatCut(getData(Vs1, getColumIndex(Vs1, "cdGroupComponent"), i)) = "" Then rad_CheckUse2.Checked = True : W3208.CheckUse = "2"
            Next

            Data_Check = True
skip_1:
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))

        End Try
    End Function


    Private Sub DATA_MOVE()
        Try
            W3208.GroupComponentBOM = txt_GroupComponentBOM.Data
            W3208.GroupComponentBOMName = txt_GroupComponentBOMName.Data

            W3208.Remark = txt_Remark.Data
            W3208.ShoesCode = txt_ShoesCode.Data

            If rad_CheckUse1.Checked = True Then W3208.CheckUse = "1"
            If rad_CheckUse2.Checked = True Then W3208.CheckUse = "2"

            W3208.CheckUse = "1"

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

    Private Sub DATA_MOVE_WRITE01()
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

            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                j = j + 1
                l = l + 1

                Call D3209_CLEAR() : W3209 = D3209

                W3209.GroupComponentBOM = txt_GroupComponentBOM.Data
                W3209.GroupComponentSeq = CIntp(getData(Vs1, getColumIndex(Vs1, "KEY_GroupComponentSeq"), i))

                If wJOB = 1 Then W3209.GroupComponentSeq = 0

                If K3209_MOVE(Vs1, i, W3209, W3209.GroupComponentBOM, W3209.GroupComponentSeq) = False Then
                    W3209.GroupComponentBOM = L3208.GroupComponentBOM

                    Call KEY_COUNT_SEQ()

                    W3209.Dseq = j

                    If getData(Vs1, getColumIndex(Vs1, "KEY_ProcessSeq"), i) = " " Then
                        W3209.ProcessSeq = j
                    Else
                        W3209.ProcessSeq = getData(Vs1, getColumIndex(Vs1, "KEY_ProcessSeq"), i)
                    End If

                    tmpSTR1 = W3209.ProcessSeq

                    If i <> 0 And tmpSTR1 <> tmpSTR2 And tmpSTR1 <> "" And tmpSTR2 <> "" Then
                        l = l - 1
                        W3209.ProcessSeq = l
                    End If

                    W3209.selGroupComponent = ListCode("GroupComponent")
                    W3209.seDepartment = ListCode("Department")
                    W3209.seShoesStatus = ListCode("ShoesStatus")
                    W3209.seUnitMaterial = ListCode("UnitMaterial")
                    W3209.seSubProcess = ListCode("SubProcess")
                    W3209.seSpecialProcess = ListCode("SpecialProcess")

                    W3209.GrossUsage = W3209.Consumption * (1 + W3209.Loss / 100)

                    W3209.PriceMaterial = W3209.Price
                    W3209.PriceRnD = W3209.PriceRnD

                    W3209.MaterialAMT = W3209.Price * W3209.Consumption * (1 + W3209.Loss / 100)

                    W3209.MaterialAMT = W3209.MaterialAMT * (1 + W3209.AddedCost / 100)

                    W3209.MaterialAMTPurchasing = W3209.MaterialAMT
                    W3209.MaterialAMTSales = W3209.MaterialAMT

                    Call WRITE_PFK3209(W3209)

                    tmpSTR2 = W3209.ProcessSeq

                Else
                    W3209.Dseq = j

                    If String.Compare(getData(Vs1, getColumIndex(Vs1, "KEY_ProcessSeq"), i), getData(Vs1, getColumIndex(Vs1, "Dseq"), i)) = "0" Then
                        W3209.ProcessSeq = W3209.Dseq
                    Else
                        If getData(Vs1, getColumIndex(Vs1, "KEY_ProcessSeq"), i) = " " Then
                            W3209.ProcessSeq = l
                        Else
                            W3209.ProcessSeq = getData(Vs1, getColumIndex(Vs1, "KEY_ProcessSeq"), i)
                        End If
                    End If

                    W3209.GrossUsage = W3209.Consumption * (1 + W3209.Loss / 100)

                    tmpSTR1 = W3209.ProcessSeq

                    If i <> 0 And tmpSTR1 = tmpSTR2 Then
                        l = l - 1
                    End If





                    W3209.PriceMaterial = W3209.Price
                    W3209.PriceRnD = W3209.PriceRnD

                    W3209.MaterialAMT = W3209.Price * W3209.Consumption * (1 + W3209.Loss / 100)
                    W3209.MaterialAMT = W3209.MaterialAMT * (1 + W3209.AddedCost / 100)

                    W3209.MaterialAMTPurchasing = W3209.MaterialAMT
                    W3209.MaterialAMTSales = W3209.MaterialAMT

                    Call REWRITE_PFK3209(W3209)

                    tmpSTR2 = W3209.ProcessSeq

                End If
skip:
            Next

            'Call PrcExeNoError("USP_PFK3208A_SHOESCODE_MAKE_NEW_FIRSTVER", cn, L3208.ShoesCode, Pub.SAW)

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub


    Private Sub DATA_INSERT()
        Try
            Call DATA_MOVE()
            Call KEY_COUNT()

            If WRITE_PFK3208(W3208) = True Then
                Call DATA_MOVE_WRITE01()

                isudCHK = True : WRITE_CHK = "*"
                Exit Sub
            End If
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INSERT")
        End Try

    End Sub

    Private Sub DATA_UPDATE()
        Try
            Call DATA_MOVE()
            If REWRITE_PFK3208(W3208) = True Then
                Call DATA_MOVE_WRITE01()

                isudCHK = True
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Try

            If READ_PFK3208(L3208.GroupComponentBOM) = True Then
                W3208 = D3208

                SQL = "DELETE FROM PFK3209 "
                SQL = SQL & " WHERE K3209_GroupComponentBOM  = '" & W3208.GroupComponentBOM & "' "
                cmd = New SqlClient.SqlCommand(SQL, cn)
                cmd.ExecuteNonQuery()

                'Call DELETE_PFK3208(W3208)
            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

    Private Sub KEY_COUNT()
        Try
            SQL = " SELECT MAX(CAST(K3208_GroupComponentBOM AS DECIMAL)) as MAX_CODE FROM PFK3208 "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W3208.GroupComponentBOM = "000001"
            Else
                W3208.GroupComponentBOM = Format(CIntp(rd!MAX_CODE + 1), "000000")
            End If

            rd.Close()

            txt_GroupComponentBOM.Data = W3208.GroupComponentBOM
            L3208.GroupComponentBOM = W3208.GroupComponentBOM

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub


    Private Sub KEY_COUNT_SEQ()
        Try

            SQL = " SELECT MAX(K3209_GroupComponentSeq) as MAX_CODE FROM PFK3209 "
            SQL = SQL & " WHERE K3209_GroupComponentBOM  = '" & W3208.GroupComponentBOM & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)

            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W3209.GroupComponentSeq = 1
            Else
                W3209.GroupComponentSeq = CIntp(rd!MAX_CODE + 1)
            End If

            rd.Close()

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
            Select Case wJOB
                Case 1
                    If Data_Check() = False Then Exit Sub
                    If DataCheck(Me, "PFK7018") = False Then Exit Sub
                    Call KEY_COUNT()
                    Call DATA_INSERT()
                    MsgBoxP("Save Successfully!", vbInformation)
                    wJOB = 3
                    Call DATA_SEARCH01()
                    Call DATA_SEARCH_VS1()

                Case 2
                    Me.Dispose()
                Case 3
                    If Data_Check() = False Then Exit Sub
                    If DataCheck(Me, "PFK7018") = False Then Exit Sub
                    Call DATA_UPDATE()
                    MsgBoxP("Save Successfully!", vbInformation)
                    Call DATA_SEARCH01()
                    Call DATA_SEARCH_VS1()
                Case 4
                    Call DATA_DELETE()
            End Select
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

        Call DATA_DELETE()

        Me.Dispose()
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub


    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        Dim xCOL As Integer
        Dim xROW As Integer
        Dim Autokey As String

        xCOL = Vs1.ActiveSheet.ActiveColumnIndex
        xROW = Vs1.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Delete

                Call Select_Message("3", WordConv("PROCESSING"), 2)

                If Msg_Result <> vbYes Then Exit Sub

                W3209.GroupComponentBOM = getData(Vs1, getColumIndex(Vs1, "KEY_GroupComponentBOM"), xROW)
                W3209.GroupComponentSeq = getData(Vs1, getColumIndex(Vs1, "KEY_GroupComponentSeq"), xROW)

                If READ_PFK3209(W3209.GroupComponentBOM, W3209.GroupComponentSeq) Then
                    W3209 = D3209
                    Call DELETE_PFK3209(W3209)
                End If

                SPR_DEL(Vs1, xCOL, xROW)
                Vs1.ActiveSheet.ActiveColumnIndex = xCOL
                Vs1.ActiveSheet.ActiveRowIndex = xROW
                Vs1.Focus()

            Case Keys.Enter
                Select Case xCOL
                    Case getColumnIndex(Vs1, "MaterialCode")
                        Autokey = getData(Vs1, getColumnIndex(Vs1, "MaterialCode"), xROW)

                        If READ_PFK7261_AUTOKEY(Autokey) Then

                            Call READ_PFK7260(D7261.ContractID)
                            setData(Vs1, getColumIndex(Vs1, "SupplierCode"), xROW, D7260.CustomerCode)
                            setData(Vs1, getColumIndex(Vs1, "PriceMaterial"), xROW, D7261.PriceMaterialVND)
                            setData(Vs1, getColumIndex(Vs1, "Price"), xROW, D7261.PriceMaterialVND)

                            If READ_PFK7101(D7260.CustomerCode) Then
                                setData(Vs1, getColumIndex(Vs1, "SupplierName"), xROW, D7101.CustomerName)
                            End If

                            setData(Vs1, getColumIndex(Vs1, "ColorCode"), xROW, D7261.ColorCode)
                            setData(Vs1, getColumIndex(Vs1, "ColorName"), xROW, D7261.ColorName)

                            setData(Vs1, getColumIndex(Vs1, "ContractID"), xROW, D7261.ContractID)
                            setData(Vs1, getColumIndex(Vs1, "ContracSeq"), xROW, D7261.ContracSeq)

                            Call READ_PFK7231(D7261.MaterialCode)

                            setData(Vs1, getColumIndex(Vs1, "MaterialCode"), xROW, D7231.MaterialCode)
                            setData(Vs1, getColumIndex(Vs1, "MaterialName"), xROW, D7231.MaterialName)

                            setData(Vs1, getColumIndex(Vs1, "MaterialSimple"), xROW, D7231.MaterialSimple)

                            setData(Vs1, getColumIndex(Vs1, "seUnitMaterial"), xROW, D7231.seUnitMaterial)
                            setData(Vs1, getColumIndex(Vs1, "cdUnitMaterial"), xROW, D7231.cdUnitMaterial)

                            Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                            setData(Vs1, getColumIndex(Vs1, "cdUnitMaterialName"), xROW, D7171.BasicName)

                            setData(Vs1, getColumIndex(Vs1, "seUnitPacking"), xROW, D7231.seUnitPacking)
                            setData(Vs1, getColumIndex(Vs1, "cdUnitPacking"), xROW, D7231.cdUnitPacking)

                            Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                            setData(Vs1, getColumIndex(Vs1, "cdUnitPackingName"), xROW, D7171.BasicName)

                            setData(Vs1, getColumIndex(Vs1, "Width"), xROW, D7231.Width)
                            setData(Vs1, getColumIndex(Vs1, "Height"), xROW, D7231.Height)
                            setData(Vs1, getColumIndex(Vs1, "SizeName"), xROW, D7231.SizeName)

                        End If

                End Select
        End Select
    End Sub

    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change

        Dim i As Integer
        Dim j As String
        Dim Autokey As String

        i = e.Row

        Select Case e.Column
            Case getColumnIndex(Vs1, "MaterialCode")
                Autokey = getData(Vs1, getColumnIndex(Vs1, "MaterialCode"), i)

                If READ_PFK7261_AUTOKEY(Autokey) Then
                    Call READ_PFK7260(D7261.ContractID)
                    setData(Vs1, getColumIndex(Vs1, "SupplierCode"), i, D7260.CustomerCode)
                    setData(Vs1, getColumIndex(Vs1, "PriceMaterial"), i, D7261.PriceMaterialVND)
                    setData(Vs1, getColumIndex(Vs1, "Price"), i, D7261.PriceMaterialVND)

                    If READ_PFK7101(D7260.CustomerCode) Then
                        setData(Vs1, getColumIndex(Vs1, "SupplierName"), i, D7101.CustomerName)
                    End If

                    setData(Vs1, getColumIndex(Vs1, "ColorCode"), i, D7261.ColorCode)
                    setData(Vs1, getColumIndex(Vs1, "ColorName"), i, D7261.ColorName)

                    setData(Vs1, getColumIndex(Vs1, "ContractID"), i, D7261.ContractID)
                    setData(Vs1, getColumIndex(Vs1, "ContracSeq"), i, D7261.ContracSeq)

                    Call READ_PFK7231(D7261.MaterialCode)

                    setData(Vs1, getColumIndex(Vs1, "MaterialCode"), e.Row, D7231.MaterialCode)
                    setData(Vs1, getColumIndex(Vs1, "MaterialName"), e.Row, D7231.MaterialName)

                    setData(Vs1, getColumIndex(Vs1, "MaterialSimple"), e.Row, D7231.MaterialSimple)

                    setData(Vs1, getColumIndex(Vs1, "seUnitMaterial"), e.Row, D7231.seUnitMaterial)
                    setData(Vs1, getColumIndex(Vs1, "cdUnitMaterial"), e.Row, D7231.cdUnitMaterial)

                    Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                    setData(Vs1, getColumIndex(Vs1, "cdUnitMaterialName"), e.Row, D7171.BasicName)

                    setData(Vs1, getColumIndex(Vs1, "seUnitPacking"), e.Row, D7231.seUnitPacking)
                    setData(Vs1, getColumIndex(Vs1, "cdUnitPacking"), e.Row, D7231.cdUnitPacking)

                    Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                    setData(Vs1, getColumIndex(Vs1, "cdUnitPackingName"), e.Row, D7171.BasicName)

                    setData(Vs1, getColumIndex(Vs1, "Width"), e.Row, D7231.Width)
                    setData(Vs1, getColumIndex(Vs1, "Height"), e.Row, D7231.Height)
                    setData(Vs1, getColumIndex(Vs1, "SizeName"), e.Row, D7231.SizeName)

                End If


            Case getColumnIndex(Vs1, "KEY_ProcessSeq")

                For i = Vs1.ActiveSheet.ActiveRowIndex To Vs1.ActiveSheet.RowCount - 1

                    j = getData(Vs1, getColumnIndex(Vs1, "KEY_ProcessSeq"), i)

                    If IsNumeric(j) = True Then
                        setData(Vs1, getColumnIndex(Vs1, "KEY_ProcessSeq"), i + 1, j + 1)
                    Else
                        setData(Vs1, getColumnIndex(Vs1, "KEY_ProcessSeq"), i + 1, i + 1)
                    End If

                Next

        End Select


    End Sub

    Private Sub txt_cdMasterBOM_Load(sender As Object, e As EventArgs) Handles txt_cdMasterBOM.btnTitleClick
        Dim xROW As Integer

        xROW = Vs1.ActiveSheet.ActiveRowIndex
        If Vs1.ActiveSheet.ActiveRowIndex < 0 Then Exit Sub

        If HLP7301A.Link_HLP7301A("") = False Then Exit Sub

        If hlp0000SeVa = "" Then Exit Sub
        DS1 = PrcDS("USP_ISUD7301A_SEARCH_VS1", cn, hlp0000SeVaTt)

        Call READ_SPREAD_N(Vs1, DS1, xROW, GetDsRc(DS1), "USP_ISUD7301A_SEARCH_VS1", "VS1")

    End Sub

    'Private Sub txt_BaseBom_Load(sender As Object, e As EventArgs) Handles txt_MasterBom.btnTitleClick
    '    Dim xROW As Integer

    '    xROW = Vs1.ActiveSheet.ActiveRowIndex
    '    If Vs1.ActiveSheet.ActiveRowIndex < 0 Then Exit Sub

    '    If HLP3208F.Link_HLP3208F = False Then Exit Sub

    '    If hlp0000SeVa = "" Then Exit Sub
    '    DS1 = PrcDS("USP_ISUD3208O_SEARCH_VS1", cn, hlp0000SeVaTt)

    '    Call READ_SPREAD_N(Vs1, DS1, xROW, GetDsRc(DS1), "USP_ISUD3208O_SEARCH_VS1", "VS1")

    'End Sub


    

#End Region

    Private Sub chk_Group_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Group.CheckedChanged
        PeaceSplitContainer1.Panel1Collapsed = Not chk_Group.Checked
    End Sub

    Private Sub Cms_1_Click(sender As Object, e As EventArgs) Handles Cms_1.ItemClicked
        Dim HistoryCode As String
        Dim CheckDefault As String

        HistoryCode = getData(vS0, getColumIndex(vS0, "KEY_HistoryCode"), vS0.ActiveSheet.ActiveRowIndex)
        CheckDefault = getDataM(vS0, getColumIndex(vS0, "CheckDefault"), vS0.ActiveSheet.ActiveRowIndex)


        Select Case True
            Case Cms_1.Items(0).Selected
                Cms_1.Hide()
                Try
                    'Call PrcExeNoError("USP_PFK3208A_SHOESCODE_MAKE_DEFAULT", cn, L3208.ShoesCode, HistoryCode, Pub.SAW)

                Catch ex As Exception

                End Try

            Case Cms_1.Items(1).Selected
                Cms_1.Hide()
                Try
                    Dim HistoryName As String
                    Dim Remark As String
                    Dim HistoryNo As String
                    HistoryCode = getData(vS0, getColumIndex(vS0, "KEY_HistoryCode"), vS0.ActiveSheet.ActiveRowIndex)

                    HistoryName = getData(vS0, getColumIndex(vS0, "HistoryName"), vS0.ActiveSheet.ActiveRowIndex)
                    HistoryNo = getData(vS0, getColumIndex(vS0, "HistoryNo"), vS0.ActiveSheet.ActiveRowIndex)
                    Remark = getData(vS0, getColumIndex(vS0, "Remark"), vS0.ActiveSheet.ActiveRowIndex)

                    If CheckDefault = "1" Then
                        'Call PrcExeNoError("USP_PFK3208A_SHOESCODE_UPDATE_HISTORY", cn, HistoryCode, HistoryName, HistoryNo, Remark, Pub.DAT, Pub.SAW)
                    Else
                        MsgBoxP("It's not current verion !") : Exit Select

                    End If



                Catch ex As Exception

                End Try

            Case Cms_1.Items(2).Selected
                Cms_1.Hide()
                Try
                    'Call PrcExeNoError("USP_PFK3208A_SHOESCODE_MAKE_NEW", cn, L3208.ShoesCode, Pub.SAW)
                    Call DATA_SEARCH_VS0()
                    Call DATA_SEARCH_VS1()

                Catch ex As Exception

                End Try

            Case Cms_1.Items(3).Selected
                Cms_1.Hide()
                Try

                    If CheckDefault = "2" Then Me.Tst_Main.Enabled = False : Call DATA_SEARCH_VS1_HistoryCode(HistoryCode)
                    If CheckDefault = "1" Then Me.Tst_Main.Enabled = True : Call DATA_SEARCH_VS1()



                Catch ex As Exception

                End Try

        End Select
    End Sub




End Class