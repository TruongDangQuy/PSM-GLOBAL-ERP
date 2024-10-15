Public Class ISUD1310B
#Region "Variable"
    Private wJOB As Integer

    Private W7231 As T7231_AREA

    Private L7106 As T7106_AREA

    Private W7108 As T7108_AREA
    Private L7108 As T7108_AREA

    Private W1310 As T1310_AREA
    Private L1310 As T1310_AREA

    Private W7103 As T7103_AREA

    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD1310B(job As Integer, GroupComponentBOM As String, OrderNo As String, OrderNoSeq As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D7108.GroupComponentBOM = GroupComponentBOM

        txt_OrderNo.Data = OrderNo
        txt_OrderNoSeq.Data = OrderNoSeq

        D1310.OrderNo = OrderNo
        D1310.OrderNoSeq = OrderNoSeq
        D1310.GroupComponentBOM = GroupComponentBOM

        If job = "1" Then
            D7108.GroupComponentBOM = ""
            D7108.ShoesCode = GroupComponentBOM
            L7108.ShoesCode = GroupComponentBOM
            txt_ShoesCode.Data = GroupComponentBOM
        End If


        wJOB = job : L7108 = D7108 : L7106 = D7106 : L1310 = D1310

        Link_ISUD1310B = False
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

            Link_ISUD1310B = isudCHK


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

                Call DATA_SEARCH_VS1()

                Frame1.Enabled = True
                tst_iDelete.Visible = False

                Setfocus(txt_GWeight)

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
                Call DATA_SEARCH_VS1()

                tst_iDelete.Visible = False
                tst_iSave.Visible = False
                Setfocus(txt_GWeight)

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
                Call DATA_SEARCH_VS1()

                txt_GroupComponentBOM.Enabled = False

                tst_iDelete.Visible = False
                tst_iSave.Visible = True
                Setfocus(txt_GWeight)

            Case 4
                Me.Text = Me.Text & " - DELETE"
                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                tst_iDelete.Visible = True
                tst_iSave.Visible = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

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
        Vs1.AllowRowMove = True
        PeaceSplitContainer1.Panel1Collapsed = True
        Call Cms_additem(Cms_1,
                     WordConv("CHECK DEFAULT VERSION"),
                     WordConv("UPDATE INFORMATION"),
                     WordConv("MAKE NEW VERSION"),
                     WordConv("CHECK DATA VERSION"))

        vS0.ContextMenuStrip = Cms_1
        Frame1.Enabled = True
        Pal_1.Enabled = True

        txt_GWeight.Enabled = True
        txt_NWeight.Enabled = True
    End Sub
#End Region

#Region "Data_Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Try

            txt_OrderNo.Data = L1310.OrderNo
            txt_OrderNoSeq.Data = L1310.OrderNoSeq
            txt_GroupComponentBOM.Data = L1310.GroupComponentBOM

            If READ_PFK7108(L7108.GroupComponentBOM) Then
                L7108.ShoesCode = D7108.ShoesCode
            End If

            DS1 = READ_PFK7106(L7108.ShoesCode, cn)

            If GetDsRc(DS1) > 0 Then
                READER_MOVE(Me, DS1)
                Call READ_PFK7106(L7108.ShoesCode)
            End If


            If READ_PFK1312(txt_OrderNo.Data, txt_OrderNoSeq.Data) Then
                txt_DateDeliveryD.Data = D1312.PONO & "/" & D1312.DateLable
                txt_GWeight.Data = Format3(CDecp(D1312.QtyGW))
                txt_NWeight.Data = Format3(CDecp(D1312.QtyNW))

            End If

            If READ_PFK1311(txt_OrderNo.Data) Then
                txt_CustPONO.Data = D1311.CustPoNo
            End If

            DS1 = Nothing


            DATA_SEARCH01 = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH01")
        End Try

    End Function

    Private Function DATA_SEARCH_VS0() As Boolean
        DATA_SEARCH_VS0 = False

        DS1 = PrcDS("USP_ISUD1310B_SEARCH_VS0", cn, L7108.ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(VS0, , , , OperationMode.Normal)
            SPR_PRO_NEW(VS0, DS1, "USP_ISUD1310B_SEARCH_VS0", "VS0")

            VS0.Enabled = True
            Exit Function
        End If
        SPR_SET(VS0, , , , OperationMode.Normal)
        SPR_PRO_NEW(VS0, DS1, "USP_ISUD1310B_SEARCH_VS0", "VS0")

        DATA_SEARCH_VS0 = True


    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        DS1 = PrcDS("USP_ISUD1310B_SEARCH_VS1_F1", cn, txt_OrderNo.Data, txt_OrderNoSeq.Data)

        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_ISUD1310B_SEARCH_VS1_F1_INSERT", cn, txt_OrderNo.Data, txt_OrderNoSeq.Data)

            SPR_SET(Vs1, , , , OperationMode.Normal)
            SPR_PRO_NEW(Vs1, DS2, "USP_ISUD1310B_SEARCH_VS1_F1", "Vs1")

            SPR_INSERT(Vs1)

            Call SPR_SearchType(Vs1, SearchType.Material)
            Call SPR_SearchType(Vs1, SearchType.BasicCode, "cdGroupComponentName", ListCode("GroupComponent"))

            Vs1.Enabled = True
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO_NEW(Vs1, DS1, "USP_ISUD1310B_SEARCH_VS1_F1", "Vs1")

        Call SPR_SearchType(Vs1, SearchType.Material)
        Call SPR_SearchType(Vs1, SearchType.BasicCode, "cdGroupComponentName", ListCode("GroupComponent"))

        Dim intCol1 As Integer = getColumIndex(Vs1, "MaterialName")
        Dim intCol2 As Integer = getColumIndex(Vs1, "ContractID")


        For i As Integer = 0 To Vs1.ActiveSheet.RowCount - 1
            If FormatCut(getData(Vs1, intCol2, i)) = "" Then Call SPR_BACKCOLORCELL(Vs1, Color.Coral, intCol1, i)

        Next


        DATA_SEARCH_VS1 = True


    End Function

    Private Function DATA_SEARCH_VS1_HistoryCode(HistoryCode) As Boolean
        DATA_SEARCH_VS1_HistoryCode = False

        DS1 = PrcDS("USP_ISUD1310B_SEARCH_VS1_HISTORY", cn, HistoryCode)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(Vs1, , , , OperationMode.Normal)
            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD1310B_SEARCH_VS1", "Vs1")

            Vs1.Enabled = True
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO_NEW(Vs1, DS1, "USP_ISUD1310B_SEARCH_VS1", "Vs1")

        DATA_SEARCH_VS1_HistoryCode = True
    End Function

#End Region

#Region "Function"

    Private Function Data_Check() As Boolean
        Dim i As Integer

        Data_Check = False

        Try
            If wJOB = "1" Then
                If READ_PFK7108(L7108.GroupComponentBOM) = True Then
                    Call MsgBoxP("5", "DATA_INSERT")
                    txt_GroupComponentBOM.Focus()
                    KEY_COUNT()
                    Exit Function
                End If
            End If

            W7108.CheckUse = "1"

            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getDataM(Vs1, getColumIndex(Vs1, "CheckUse"), i) = "1" Then

                    If CDecp(getData(Vs1, getColumIndex(Vs1, "Price"), i)) = 0 And getDataM(Vs1, getColumIndex(Vs1, "CheckUse1"), i) <> "1" Then MsgBoxP("No Price at row " & (i + 1).ToString) : Exit Function
                    If FormatCut(getData(Vs1, getColumIndex(Vs1, "Specification"), i)) = "" And getDataM(Vs1, getColumIndex(Vs1, "CheckUse1"), i) <> "1" Then MsgBoxP("No size spec at row " & (i + 1).ToString) : Exit Function

                    If FormatCut(getData(Vs1, getColumIndex(Vs1, "SupplierCode"), i)) = "" Then MsgBoxP("No supplier at row " & (i + 1).ToString) : Exit Function
                    If CDecp(getData(Vs1, getColumIndex(Vs1, "Consumption"), i)) = 0 Then MsgBoxP("No consumption at row " & (i + 1).ToString) : Exit Function

                End If

            Next

            Data_Check = True
skip_1:
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))

        End Try
    End Function


    Private Sub DATA_MOVE()
        Try
            'W7108.GroupComponentBOM = txt_GroupComponentBOM.Data
            'W7108.GroupComponentBOMName = txt_GroupComponentBOMName.Data

            'W7108.Remark = txt_Remark.Data
            'W7108.ShoesCode = txt_ShoesCode.Data

            'If rad_CheckUse1.Checked = True Then W7108.CheckUse = "1"
            'If rad_CheckUse2.Checked = True Then W7108.CheckUse = "2"


            'If READ_PFK7106(W7108.ShoesCode) Then
            '    If chk_CheckBOM1.Checked = True Then D7106.CheckBOM = "1"
            '    If chk_CheckBOM2.Checked = True Then D7106.CheckBOM = "2"

            '    D7106.DateBOMCom = Pub.DAT
            '    D7106.InchargeBOMCom = Pub.SAW

            '    Call REWRITE_PFK7106(D7106)
            'End If

            'W7108.CheckUse = "1"

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

                Call D1310_CLEAR() : W1310 = D1310

                W1310.OrderNo = txt_OrderNo.Data
                W1310.OrderNoSeq = txt_OrderNoSeq.Data

                W1310.AutoKey = CIntp(getData(Vs1, getColumIndex(Vs1, "KEY_AutoKey"), i))

                If READ_PFK1310(W1310.AutoKey) = True Then
                    L1310 = D1310
                    W1310 = D1310
                    W1310.CheckUse = getDataM(Vs1, getColumIndex(Vs1, "CheckUse"), i)
                    W1310.CheckUse1 = getDataM(Vs1, getColumIndex(Vs1, "CheckUse1"), i)

                    W1310.Specification = getData(Vs1, getColumIndex(Vs1, "Specification"), i)

                    If L1310.CheckUse + L1310.CheckUse1 + L1310.Specification <> W1310.CheckUse + W1310.CheckUse1 + W1310.Specification Then
                        If REWRITE_PFK1310(W1310) Then

                        End If
                    End If
                  



                End If
skip:
            Next

            Call PrcExeNoError("USP_PFK1312_UPDATE_GW_NW", cn, txt_OrderNo.Data, txt_OrderNoSeq.Data, CDecp(txt_GWeight.Data), CDecp(txt_NWeight.Data), Pub.DAT, Pub.SAW)


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub


    Private Sub DATA_INSERT()
        Try
            Call DATA_MOVE()
            Call KEY_COUNT()

            Call DATA_MOVE_WRITE01()

            isudCHK = True : WRITE_CHK = "*"
            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INSERT")
        End Try

    End Sub

    Private Sub DATA_UPDATE()
        Try
            Call DATA_MOVE()
            Call DATA_MOVE_WRITE01()

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Try
            Dim xROW As Integer

            For xROW = 0 To Vs1.ActiveSheet.RowCount - 1
                W1310.AutoKey = getData(Vs1, getColumIndex(Vs1, "KEY_AutoKey"), xROW)
                'If PrcExeNoError("USP_PFK1310_ROW_NUMBER_PACKING_ROWBASE_DELETE", cn, W1310.AutoKey, Pub.SAW) Then
                Call DELETE_PFK1310(W1310)
                'End If

            Next

            'If READ_PFK7108(L7108.GroupComponentBOM) = True Then
            '    W7108 = D7108

            '    SQL = "DELETE FROM PFK1310 "
            '    SQL = SQL & " WHERE K1310_OrderNo  = '" & txt_OrderNo.Data & "' "
            '    SQL = SQL & " AND    K1310_OrderNoSeq  = '" & txt_OrderNoSeq.Data & "' "

            '    cmd = New SqlClient.SqlCommand(SQL, cn)
            '    cmd.ExecuteNonQuery()

            '    'Call DELETE_PFK7108(W7108)
            'End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

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


    Private Sub KEY_COUNT_SEQ()
        Try

            SQL = " SELECT MAX(K1310_GroupComponentSeq) as MAX_CODE FROM PFK1310 "
            SQL = SQL & " WHERE K1310_GroupComponentBOM  = '" & W7108.GroupComponentBOM & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)

            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W1310.GroupComponentSeq = 1
            Else
                W1310.GroupComponentSeq = CIntp(rd!MAX_CODE + 1)
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

        Msg_Result = MsgBox("This is important confirmation ! Please be careful to save ! Đây là thông tin cực kỳ quan trọng để mua hàng. Xin lưu ý ! Bấm Yes để tiếp tục !", vbYesNo)
        If Msg_Result <> vbYes Then Exit Sub

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
      
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub


#End Region



End Class