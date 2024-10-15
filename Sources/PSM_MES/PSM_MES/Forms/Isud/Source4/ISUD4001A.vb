
Public Class ISUD4001A

#Region "Variable"
    Private wJOB As Integer

    Private KEY_CHK As String
    Private WRITE_CHK As String

    Private W4001 As T4001_AREA
    Private L4001 As T4001_AREA

    Private W4002 As T4002_AREA
    Private L4002 As T4002_AREA

    Private W4003 As T4003_AREA
    Private L4003 As T4003_AREA

    Private W4020 As T4020_AREA
    Private L4020 As T4020_AREA

    Private W4025 As T4025_AREA
    Private L4025 As T4025_AREA

    Private L4033 As T4033_AREA
    Private W4033 As T4033_AREA

    Private L4035 As T4035_AREA
    Private W4035 As T4035_AREA

    Private L4037 As T4037_AREA
    Private W4037 As T4037_AREA

    Private L4039 As T4039_AREA
    Private W4039 As T4039_AREA

    Private formA As Boolean

    Private checkisud As Boolean

    Private CHK(0 To 5) As String

    Private strFormName As String
    Private Value As String = ""

#End Region

#Region "Link_ISUD"
    Public Function Link_ISUD4001A(job As Integer, WorkOrder As String, WorkOrderSeq As String, Optional CheckName As String = "") As Boolean
        If strFormName = "" Then strFormName = Me.Text
        Me.Tag = CheckName

        D4001.WorkOrder = WorkOrder

        D4002.WorkOrder = WorkOrder
        D4002.WorkOrderSeq = WorkOrderSeq

        wJOB = job : L4001 = D4001 : L4002 = D4002

        Link_ISUD4001A = False

        Select Case job
            Case 1, 5, 6

            Case Else
                txt_WorkOrder.Data = L4002.WorkOrder
                txt_WorkOrderSeq.Data = L4002.WorkOrderSeq

                If READ_PFK4002(L4002.WorkOrder, L4002.WorkOrderSeq) = False Then
                    Call MsgBoxP("3", "LINK_ISUD")
                    Exit Function
                End If

                If D4002.WorkOrderStatus = "3" Or D4002.WorkOrderStatus = "2" Then wJOB = 2

        End Select

        formA = False
        Me.ShowDialog()

        Link_ISUD4001A = isudCHK
    End Function

    Public Function Link_ISUD4001A_AUTO(job As Integer, OrderNo As String, OrderNoSeq As String, _Value As String, Optional CheckName As String = "") As Boolean
        Me.Tag = CheckName

        D4002.OrderNo = OrderNo
        D4002.OrderNoSeq = OrderNoSeq
        Value = _Value

        wJOB = job : L4001 = D4001 : L4002 = D4002

        Link_ISUD4001A_AUTO = False

        Select Case job
            Case 1, 5, 6

            Case Else

        End Select

        formA = False
        Me.ShowDialog()

        Link_ISUD4001A_AUTO = isudCHK
    End Function
#End Region

#Region "Form_load"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Activated
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_KeyDown()
        Call DATA_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

begin:
        Select Case wJOB
            Case 1
                Me.Text = strFormName & " - INSERT"
                checkisud = False
                Call KEY_COUNT()
                Call KEY_COUNT_NO()
                cmd_DEL.Visible = False

                Call DATA_SEARCH_VS00()
                Call DATA_SEARCH_VS10()

                Setfocus(txt_cdDepartment)

                If CHK(1) <> "1" Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If
                wJOB = 3
                checkisud = True
            Case 2
                Me.Text = strFormName & " - SEARCH"
                checkisud = True
                cmd_DEL.Visible = False
                cmd_OK.Visible = False

                'Call DisableAllType()

                If CHK(2) <> "1" Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_DETAIL()
                Call DATA_SEARCH_VS00()
                Call DATA_SEARCH_VS10()

            Case 3
                Me.Text = strFormName & " - UPDATE"
                checkisud = True
                cmd_DEL.Visible = False

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_DETAIL()
                Call DATA_SEARCH_VS00()
                Call DATA_SEARCH_VS10()

                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        formA = True
                        Me.Dispose()
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else
                        Me.Text = strFormName & " - SEARCH"
                        isudCHK = False
                        wJOB = 2
                        cmd_DEL.Visible = False
                        GoTo Begin
                    End If
                End If

            Case 4
                Me.Text = strFormName & " - DELETE"
                cmd_DEL.Visible = True

                checkisud = True
                cmd_OK.Visible = False

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_DETAIL()
                Call DATA_SEARCH_VS00()
                Call DATA_SEARCH_VS10()

                If CHK(4) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        formA = True
                        Me.Dispose()
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else
                        Me.Text = strFormName & " - SEARCH"
                        isudCHK = False
                        wJOB = 2
                        cmd_DEL.Visible = False
                        GoTo Begin
                    End If
                End If

            Case 7

                Me.Text = strFormName & " - ADD-PR1"

                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        formA = True
                        Me.Dispose()
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else
                        Me.Text = strFormName & " - SEARCH"
                        isudCHK = False
                        wJOB = 2
                        cmd_DEL.Visible = False
                        GoTo Begin
                    End If
                End If

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_DETAIL()
                Call DATA_SEARCH_VS00()
                Call DATA_SEARCH_VS10()

                Call KEY_COUNT_NO()


            Case 8
                Me.Text = strFormName & " - ADD-PR2"

                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        formA = True
                        Me.Dispose()
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else
                        Me.Text = strFormName & " - SEARCH"
                        isudCHK = False
                        wJOB = 2
                        cmd_DEL.Visible = False
                        GoTo Begin
                    End If
                End If

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_DETAIL()
                Call DATA_SEARCH_VS00()
                Call DATA_SEARCH_VS10()

                Call KEY_COUNT_NO()

            Case 9
                Me.Text = strFormName & " - ADD-SM"

                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        formA = True
                        Me.Dispose()
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else
                        Me.Text = strFormName & " - SEARCH"
                        isudCHK = False
                        wJOB = 2
                        cmd_DEL.Visible = False
                        GoTo Begin
                    End If
                End If

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_DETAIL()
                Call DATA_SEARCH_VS00()
                Call DATA_SEARCH_VS10()


                Call KEY_COUNT_NO()
                vS00.InsChk = True


            Case 11
                Me.Text = strFormName & " - AUTO"
                checkisud = False

                Call KEY_COUNT()
                Call KEY_COUNT_NO()
                cmd_DEL.Visible = False
                cmd_OK.Visible = True
                Call DATA_SEARCH_VS00()
                Call DATA_SEARCH_VS10()

                Setfocus(txt_cdDepartment)

                If CHK(1) <> "1" Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If
                checkisud = True

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        KEY_CHK = ""

        txt_DateWorkOrder.Data = Pub.DAT

        ptc_Main.ItemSize = New Size((ptc_Main.Width - 15) / ptc_Main.TabCount, 25)
        Ptc_Sub.ItemSize = New Size((Ptc_Sub.Width - 15) / Ptc_Sub.TabCount, 25)

    End Sub

#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH_IMAGE() As Boolean
        Dim ds As New DataSet
        DATA_SEARCH_IMAGE = False

        DATA_SEARCH_IMAGE = True

    End Function
    Private Function DATA_SEARCH_HEAD() As Boolean
        DATA_SEARCH_HEAD = False
        DS1 = READ_PFK4001(L4001.WorkOrder, cn)

        If GetDsRc(DS1) = 0 Then Exit Function

        Call READER_MOVE(Me, DS1)

        DS1 = Nothing

        DATA_SEARCH_HEAD = True

    End Function
    Private Function DATA_SEARCH_DETAIL() As Boolean
        DATA_SEARCH_DETAIL = False
        DS2 = READ_PFK4002(txt_WorkOrder.Data, txt_WorkOrderSeq.Data, cn)

        If GetDsRc(DS2) = 0 Then
            Exit Function
        End If

        Call READER_MOVE(Me, DS2)

        DS2 = Nothing

        DATA_SEARCH_DETAIL = True
    End Function

    Private Function DATA_SEARCH_VS00() As Boolean
        DATA_SEARCH_VS00 = False

        DS1 = PrcDS("USP_ISUD4001A_SEARCH_VS00", cn, txt_WorkOrder.Data)
        vS00.Enabled = True

        If GetDsRc(DS1) = 0 Then
            If wJOB = 11 Then
                DS2 = PrcDS("USP_ISUD4001A_SEARCH_VS00_INSERT", cn, Value)
                SPR_PRO_NEW(vS00, DS2, "USP_ISUD4001A_SEARCH_VS00", "VS00")
                vS00.Enabled = False
                Exit Function
            End If

            SPR_PRO_NEW(vS00, DS1, "USP_ISUD4001A_SEARCH_VS00", "VS00")
            vS00.ActiveSheet.RowCount = 1
            vS00.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS00, DS1, "USP_ISUD4001A_SEARCH_VS00", "VS00")

        DATA_SEARCH_VS00 = True
    End Function

    Private Function DATA_SEARCH_VS10() As Boolean
        DATA_SEARCH_VS10 = False

        DS1 = PrcDS("USP_ISUD4001A_SEARCH_VS10", cn, txt_WorkOrder.Data)

        If GetDsRc(DS1) = 0 Then
            If wJOB = 11 Then
                DS2 = PrcDS("USP_ISUD4001A_SEARCH_VS10_INSERT", cn, Value)
                SPR_PRO_NEW(Vs10, DS2, "USP_ISUD4001A_SEARCH_Vs10", "Vs10")
                Vs10.Enabled = False
                Exit Function
            End If

            SPR_PRO_NEW(Vs10, DS1, "USP_ISUD4001A_SEARCH_VS10", "VS10")
            Vs10.ActiveSheet.RowCount = 1
            Vs10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs10, DS1, "USP_ISUD4001A_SEARCH_VS10", "VS10")


        DATA_SEARCH_VS10 = True
    End Function

    Private Function DATA_SEARCH_VS2x() As Boolean
        DATA_SEARCH_VS2x = False

        DS1 = PrcDS("USP_ISUD4001A_SEARCH_VS2x", cn, txt_WorkOrder.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS2x, DS1, "USP_ISUD4001A_SEARCH_VS2x", "VS2x")
            vS2x.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS2x, DS1, "USP_ISUD4001A_SEARCH_VS2x", "VS2x")

        DATA_SEARCH_VS2x = True
    End Function


#Region "Orrder"
    Private Function DATA_SEARCH_VS21() As Boolean
        DATA_SEARCH_VS21 = False

        DS1 = PrcDS("USP_ISUD0101K1_SEARCH_VS21", cn, txt_SpecNo.Data, txt_SpecNoSeq.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS21, DS1, "USP_ISUD0101K1_SEARCH_VS21", "VS21")
            vS21.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(VS21, DS1, "USP_ISUD0101K1_SEARCH_VS21", "VS21")

        DATA_SEARCH_VS21 = True
    End Function

    Private Function DATA_SEARCH_VS22() As Boolean
        DATA_SEARCH_VS22 = False

        DS1 = PrcDS("USP_ISUD0101K1_SEARCH_VS22", cn, txt_SpecNo.Data, txt_SpecNoSeq.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(VS22, DS1, "USP_ISUD0101K1_SEARCH_VS22", "VS22")
            vS22.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(VS22, DS1, "USP_ISUD0101K1_SEARCH_VS22", "VS22")

        DATA_SEARCH_VS22 = True
    End Function

    Private Function DATA_SEARCH_VS23_Child(ProcessSeq As String) As Boolean
        DATA_SEARCH_VS23_Child = False

        DS1 = PrcDS("USP_ISUD0101K1_SEARCH_VS23_Child", cn, txt_SpecNo.Data, txt_SpecNoSeq.Data, ProcessSeq)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS23_Child, DS1, "USP_ISUD0101K1_SEARCH_VS23_Child", "VS23_Child")
            vS23_Child.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS23_Child, DS1, "USP_ISUD0101K1_SEARCH_VS23_Child", "VS23_Child")

        DATA_SEARCH_VS23_Child = True
    End Function

    Private Function DATA_SEARCH_VS23() As Boolean
        DATA_SEARCH_VS23 = False

        DS1 = PrcDS("USP_ISUD0101K1_SEARCH_VS23", cn, txt_SpecNo.Data, txt_SpecNoSeq.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS23, DS1, "USP_ISUD0101K1_SEARCH_VS23", "VS23")
            vS23.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(VS23, DS1, "USP_ISUD0101K1_SEARCH_VS23", "VS23")

        DATA_SEARCH_VS23 = True
    End Function

    Private Function DATA_SEARCH_VS24() As Boolean
        DATA_SEARCH_VS24 = False

        DS1 = PrcDS("USP_ISUD0101K1_SEARCH_VS24", cn, txt_SpecNo.Data, txt_SpecNoSeq.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(VS24, DS1, "USP_ISUD0101K1_SEARCH_VS24", "VS24")
            vS24.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(VS24, DS1, "USP_ISUD0101K1_SEARCH_VS24", "VS24")

        DATA_SEARCH_VS24 = True
    End Function

    Private Function DATA_SEARCH_VS25() As Boolean
        DATA_SEARCH_VS25 = False

        DS1 = PrcDS("USP_ISUD0101K1_SEARCH_VS25", cn, txt_SpecNo.Data, txt_SpecNoSeq.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(VS25, DS1, "USP_ISUD0101K1_SEARCH_VS25", "VS25")
            vS25.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(VS25, DS1, "USP_ISUD0101K1_SEARCH_VS25", "VS25")
        DATA_SEARCH_VS25 = True
    End Function


    Private Function DATA_SEARCH_VS26() As Boolean
        DATA_SEARCH_VS26 = False

        DS1 = PrcDS("USP_ISUD0101K1_SEARCH_VS26", cn, txt_SpecNo.Data, txt_SpecNoSeq.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(VS26, DS1, "USP_ISUD0101K1_SEARCH_VS26", "VS26")
            vS26.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS26, DS1, "USP_ISUD0101K1_SEARCH_VS26", "VS26")
        DATA_SEARCH_VS26 = True
    End Function


    Private Function DATA_SEARCH_VS27() As Boolean
        DATA_SEARCH_VS27 = False

        DS1 = PrcDS("USP_ISUD0101K1_SEARCH_VS27", cn, txt_SpecNo.Data, txt_SpecNoSeq.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS27, DS1, "USP_ISUD0101K1_SEARCH_VS27", "VS27")
            vS27.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS27, DS1, "USP_ISUD0101K1_SEARCH_VS27", "VS27")
        DATA_SEARCH_VS27 = True
    End Function

    Private Function DATA_SEARCH_VS28() As Boolean
        DATA_SEARCH_VS28 = False

        DS1 = PrcDS("USP_ISUD0101K1_SEARCH_VS28", cn, txt_SpecNo.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS28, DS1, "USP_ISUD0101K1_SEARCH_VS28", "VS28")
            vS28.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS28, DS1, "USP_ISUD0101K1_SEARCH_VS28", "VS28")
        DATA_SEARCH_VS28 = True
    End Function
    Private Sub vS2x_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS2x.CellClick
        txt_SpecNo.Data = getData(sender, getColumIndex(sender, "KEY_SpecNo"), e.Row)
        txt_SpecNoSeq.Data = getData(sender, getColumIndex(sender, "KEY_SpecNoSeq"), e.Row)

        Select Case Ptc_Sub.SelectedIndex
            Case 0
                Call DATA_SEARCH_VS21()
            Case 1
                Call DATA_SEARCH_VS22()
            Case 2
                Call DATA_SEARCH_VS23()
            Case 3
                Call DATA_SEARCH_VS24()

            Case 4
                Call DATA_SEARCH_VS25()
                Call DATA_SEARCH_VS26()
                Call DATA_SEARCH_VS27()
            Case 5
                Call DATA_SEARCH_VS28()
        End Select
    End Sub


    Private Sub vS23_CellClick(sender As Object, e As CellClickEventArgs) Handles vS23.CellClick
        Dim ProcessSeq As String

        ProcessSeq = getData(vS23, getColumIndex(vS23, "KEY_ProcessSeq"), vS23.ActiveSheet.ActiveRowIndex)

        Call DATA_SEARCH_VS23_Child(ProcessSeq)
    End Sub

    Private Sub ptc_Sub_DoubleClick(sender As Object, e As EventArgs) Handles Ptc_Sub.DoubleClick

        Select Case ptc_Sub.SelectedIndex
            Case 0
                Call DATA_SEARCH_VS21()
            Case 1
                Call DATA_SEARCH_VS22()
            Case 2
                Call DATA_SEARCH_VS23()
            Case 3
                Call DATA_SEARCH_VS24()

            Case 4
                Call DATA_SEARCH_VS25()
                Call DATA_SEARCH_VS26()
                Call DATA_SEARCH_VS27()
            Case 5
                Call DATA_SEARCH_VS28()

        End Select
    End Sub
    Private Sub ptc_Sub_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Ptc_Sub.SelectedIndexChanged
        If formA = False Then Exit Sub
        If ptc_Sub.SelectedIndex = -1 Then Exit Sub

        Select Case Ptc_Sub.SelectedIndex
            Case 0
                Call DATA_SEARCH_VS21()
            Case 1
                Call DATA_SEARCH_VS22()
            Case 2
                Call DATA_SEARCH_VS23()
                Dim ProcessSeq As String

                ProcessSeq = getData(vS23, getColumIndex(vS23, "KEY_ProcessSeq"), vS23.ActiveSheet.ActiveRowIndex)

                Call DATA_SEARCH_VS23_Child(ProcessSeq)

            Case 3
                Call DATA_SEARCH_VS24()

            Case 4
                Call DATA_SEARCH_VS25()
                Call DATA_SEARCH_VS26()
                Call DATA_SEARCH_VS27()

            Case 5
                Call DATA_SEARCH_VS28()

        End Select

    End Sub

#End Region

#End Region

#Region "Function"

    Private Sub KEY_COUNT()
        If KEY_CHK = "*" Then Exit Sub
        Dim YRNO As Integer
        YRNO = CIntp(Mid(System_Date_8(), 3, 4))


        SQL = "SELECT MAX(CAST(right(K4001_WorkOrder,3) AS DECIMAL)) AS MAX_MCODE FROM PFK4001 "
        SQL = SQL & " WHERE SUBSTRING(K4001_WorkOrder,3,4) = '" & YRNO.ToString & "' "
        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_MCODE) Then
            L4001.WorkOrder = "WS" & YRNO & "001"
        Else
            L4001.WorkOrder = "WS" & YRNO & Format(CInt(rd!MAX_MCODE + 1), "000")
        End If

        W4001.WorkOrder = L4001.WorkOrder

        rd.Close()
        txt_WorkOrder.Data = W4001.WorkOrder

    End Sub

    Private Sub KEY_COUNT_NO()
        If KEY_CHK = "*" Then Exit Sub
        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 2)


        SQL = "SELECT MAX(CAST(K4002_WorkOrderSeq AS DECIMAL)) AS MAX_MCODE FROM PFK4002 "
        SQL = SQL & " WHERE K4002_WorkOrder = '" & txt_WorkOrder.Data & "' "
        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_MCODE) Then
            L4002.WorkOrderSeq = "001"
        Else
            L4002.WorkOrderSeq = FormatP(CIntp(rd!MAX_MCODE + 1), "000")
        End If

        W4002.WorkOrder = txt_WorkOrder.Data
        W4002.WorkOrderSeq = L4002.WorkOrderSeq
        txt_WorkOrderSeq.Data = L4002.WorkOrderSeq
        rd.Close()

    End Sub

    Private Sub KEY_COUNT_4020()
        SQL = "SELECT MAX(CAST(K4020_MaterialSeq AS DECIMAL)) AS MAX_MCODE FROM PFK4020 "
        SQL = SQL & " WHERE K4020_WorkOrder = '" & txt_WorkOrder.Data & "' "
        SQL = SQL & " AND K4020_WorkOrderSeq = '" & txt_WorkOrderSeq.Data & "' "
        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_MCODE) Then
            L4020.MaterialSeq = "1"
        Else
            L4020.MaterialSeq = Format(CInt(rd!MAX_MCODE + 1), "0")
        End If

        W4020.MaterialSeq = L4020.MaterialSeq

        rd.Close()
    End Sub


    Private Sub KEY_COUNT_4025()
        SQL = "SELECT MAX(CAST(K4025_ProcessSeq AS DECIMAL)) AS MAX_MCODE FROM PFK4025 "
        SQL = SQL & " WHERE K4025_WorkOrder = '" & txt_WorkOrder.Data & "' "
        SQL = SQL & " AND K4025_WorkOrderSeq = '" & txt_WorkOrderSeq.Data & "' "
        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_MCODE) Then
            L4025.ProcessSeq = "1"
        Else
            L4025.ProcessSeq = Format(CInt(rd!MAX_MCODE + 1), "0")
        End If

        W4025.ProcessSeq = L4025.ProcessSeq

        rd.Close()
    End Sub

    Private Sub KEY_COUNT_4033()
        SQL = "SELECT MAX(CAST(K4033_AddCostSeq AS DECIMAL)) AS MAX_MCODE FROM PFK4033 "
        SQL = SQL & " WHERE K4033_WorkOrder = '" & txt_WorkOrder.Data & "' "
        SQL = SQL & " AND K4033_WorkOrderSeq = '" & txt_WorkOrderSeq.Data & "' "
        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_MCODE) Then
            L4033.AddCostSeq = "1"
        Else
            L4033.AddCostSeq = Format(CInt(rd!MAX_MCODE + 1), "0")
        End If

        W4033.AddCostSeq = L4033.AddCostSeq

        rd.Close()
    End Sub

    Private Sub KEY_COUNT_4035()
        SQL = "SELECT MAX(CAST(K4035_OverCostSeq AS DECIMAL)) AS MAX_MCODE FROM PFK4035 "
        SQL = SQL & " WHERE K4035_WorkOrder = '" & txt_WorkOrder.Data & "' "
        SQL = SQL & " AND K4035_WorkOrderSeq = '" & txt_WorkOrderSeq.Data & "' "
        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_MCODE) Then
            L4035.OverCostSeq = "1"
        Else
            L4035.OverCostSeq = Format(CInt(rd!MAX_MCODE + 1), "0")
        End If

        W4035.OverCostSeq = L4035.OverCostSeq

        rd.Close()
    End Sub

    Private Sub KEY_COUNT_4037()
        SQL = "SELECT MAX(CAST(K4037_SalesCostSeq AS DECIMAL)) AS MAX_MCODE FROM PFK4037 "
        SQL = SQL & " WHERE K4037_WorkOrder = '" & txt_WorkOrder.Data & "' "
        SQL = SQL & " AND K4037_WorkOrderSeq = '" & txt_WorkOrderSeq.Data & "' "
        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_MCODE) Then
            L4037.SalesCostSeq = "1"
        Else
            L4037.SalesCostSeq = Format(CInt(rd!MAX_MCODE + 1), "0")
        End If

        W4037.SalesCostSeq = L4037.SalesCostSeq

        rd.Close()
    End Sub

    Private Sub KEY_COUNT_4039()
        SQL = "SELECT MAX(CAST(K4039_CommentSeq AS DECIMAL)) AS MAX_MCODE FROM PFK4039 "
        SQL = SQL & " WHERE K4039_WorkOrder = '" & txt_WorkOrder.Data & "' "
        SQL = SQL & " AND K4039_WorkOrderSeq = '" & txt_WorkOrderSeq.Data & "' "
        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_MCODE) Then
            L4039.CommentSeq = "1"
        Else
            L4039.CommentSeq = Format(CInt(rd!MAX_MCODE + 1), "0")
        End If

        W4039.CommentSeq = L4039.CommentSeq

        rd.Close()
    End Sub
    Private Function DATA_DELETE_MATERIAL() As Boolean
        DATA_DELETE_MATERIAL = False
        Try
            Dim StrMsg As String

            StrMsg = MsgBox("Would you like to delete this material?", vbYesNo)

            If StrMsg <> vbYes Then Exit Function

            PrcExe("USP_PFK4001_DATA_DELETE_MATERIAL", cn, txt_WorkOrder.Data, txt_WorkOrderSeq.Data)
            DATA_DELETE_MATERIAL = True
        Catch ex As Exception
            MsgBoxP("DATA_DELETE_MATERIAL!", vbCritical)
        End Try
    End Function

    Private Function DATA_DELETE_PROCESS() As Boolean
        DATA_DELETE_PROCESS = False
        Try
            Dim StrMsg As String

            StrMsg = MsgBox("Would you like to delete this ?", vbYesNo)

            If StrMsg <> vbYes Then Exit Function

            PrcExe("USP_PFK4001_DATA_DELETE_PROCESS", cn, txt_WorkOrder.Data, txt_WorkOrderSeq.Data)
            DATA_DELETE_PROCESS = True
        Catch ex As Exception
            MsgBoxP("DATA_DELETE_PROCESS!", vbCritical)
        End Try
    End Function

    Private Function DATA_DELETE_COST() As Boolean
        DATA_DELETE_COST = False
        Try
            Dim StrMsg As String

            StrMsg = MsgBox("Would you like to delete this ?", vbYesNo)

            If StrMsg <> vbYes Then Exit Function

            PrcExe("USP_PFK4001_DATA_DELETE_COST", cn, txt_WorkOrder.Data, txt_WorkOrderSeq.Data)
            DATA_DELETE_COST = True
        Catch ex As Exception
            MsgBoxP("DATA_DELETE_COST!", vbCritical)
        End Try
    End Function

    Private Function DATA_DELETE_REMARK() As Boolean
        DATA_DELETE_REMARK = False
        Try
            Dim StrMsg As String

            StrMsg = MsgBox("Would you like to delete this ?", vbYesNo)

            If StrMsg <> vbYes Then Exit Function

            PrcExe("USP_PFK4001_DATA_DELETE_REMARK", cn, txt_WorkOrder.Data, txt_WorkOrderSeq.Data)
            DATA_DELETE_REMARK = True
        Catch ex As Exception
            MsgBoxP("DATA_DELETE_REMARK!", vbCritical)
        End Try
    End Function



    Private Function DATA_MOVE_K4001() As Boolean
        DATA_MOVE_K4001 = False
        Try
            Call K4001_MOVE(Me, W4001, 1, txt_WorkOrder.Data)

            If READ_PFK4001(W4001.WorkOrder) Then
                Call DATA_MOVE_DEFAULT()
                W4001.DateUpdate = Pub.DAT
                W4001.InchargeUpdate = Pub.SAW

                If REWRITE_PFK4001(W4001) = True Then

                End If

            Else
                Call KEY_COUNT()
                Call DATA_MOVE_DEFAULT()

                W4001.DateInsert = Pub.DAT
                W4001.InchargeUpdate = Pub.SAW

                'W4002.OrderNo = L4002.OrderNo
                'W4002.OrderNoSeq = L4002.OrderNoSeq

                'If READ_PFK4002(L4002.OrderNo, L4002.OrderNoSeq) Then
                '    D4002.DateRnD = Pub.DAT

                '    Call REWRITE_PFK4002(D4002)
                'End If

                If WRITE_PFK4001(W4001) = True Then
                    isudCHK = True
                    DATA_MOVE_K4001 = True
                End If

            End If

            DATA_MOVE_K4001 = True
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INSERT")
        End Try

    End Function
    Private Function CheckExist(WorkOrder As String, WorkOrderSeq As String) As Boolean
        CheckExist = False

        Dim RC As Integer
        Try
            rd = PrcDR("USP_ISUD4001A_SEARCH_VS00_CHECKEXIST", cn, WorkOrder, WorkOrderSeq)

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

    Private Function DATA_MOVE_K4002() As Boolean
        DATA_MOVE_K4002 = False
        Dim i As Integer
        Dim WorkOrder As String
        Dim WorkOrderSeq As String

        Try
            For i = 0 To vS00.ActiveSheet.RowCount - 1
                WorkOrder = getData(vS00, getColumIndex(vS00, "KEY_WorkOrder"), i)
                WorkOrderSeq = getData(vS00, getColumIndex(vS00, "KEY_WorkOrderSeq"), i)

                If READ_PFK4002(WorkOrder, WorkOrderSeq) = False Then
                    Call K4002_MOVE(vS00, i, W4002, WorkOrder, WorkOrderSeq)

                    Call KEY_COUNT_NO()
                    W4002.WorkOrderStatus = "1"
                    W4002.DateAccept = Pub.DAT
                    W4002.InchargePPC = Pub.DAT

                    Call DATA_MOVE_DEFAULT()
                    Call WRITE_PFK4002(W4002)

                    isudCHK = True : WRITE_CHK = "*"
                    DATA_MOVE_K4002 = True
                Else
                    Call DATA_MOVE_DEFAULT()

                    Call REWRITE_PFK4002(W4002)

                    isudCHK = True

                    DATA_MOVE_K4002 = True
                End If

            Next
        Catch ex As Exception

        End Try


    End Function


    Private Function DATA_MOVE_K4003() As Boolean
        DATA_MOVE_K4003 = False
        Dim TotalQty As Double
        Dim i As Integer
        Dim WorkOrder As String
        Dim WorkOrderSeq As String


        Try
            For i = 0 To Vs10.ActiveSheet.RowCount - 1
                WorkOrder = getData(Vs10, getColumIndex(Vs10, "KEY_WorkOrder"), i)
                WorkOrderSeq = getData(Vs10, getColumIndex(Vs10, "KEY_WorkOrderSeq"), i)
                TotalQty = 0

                If READ_PFK4002(WorkOrder, WorkOrderSeq) = True Then

                    W4003.WorkOrder = WorkOrder
                    W4003.WorkOrderSeq = WorkOrderSeq

                    W4003.SizeQty01 = getData(Vs10, getColumIndex(Vs10, "SizeQty01"), i)
                    W4003.SizeQty02 = getData(Vs10, getColumIndex(Vs10, "SizeQty02"), i)
                    W4003.SizeQty03 = getData(Vs10, getColumIndex(Vs10, "SizeQty03"), i)
                    W4003.SizeQty04 = getData(Vs10, getColumIndex(Vs10, "SizeQty04"), i)
                    W4003.SizeQty05 = getData(Vs10, getColumIndex(Vs10, "SizeQty05"), i)
                    W4003.SizeQty06 = getData(Vs10, getColumIndex(Vs10, "SizeQty06"), i)
                    W4003.SizeQty07 = getData(Vs10, getColumIndex(Vs10, "SizeQty07"), i)
                    W4003.SizeQty08 = getData(Vs10, getColumIndex(Vs10, "SizeQty08"), i)
                    W4003.SizeQty09 = getData(Vs10, getColumIndex(Vs10, "SizeQty09"), i)
                    W4003.SizeQty10 = getData(Vs10, getColumIndex(Vs10, "SizeQty10"), i)

                    W4003.SizeQty11 = getData(Vs10, getColumIndex(Vs10, "SizeQty11"), i)
                    W4003.SizeQty12 = getData(Vs10, getColumIndex(Vs10, "SizeQty12"), i)
                    W4003.SizeQty13 = getData(Vs10, getColumIndex(Vs10, "SizeQty13"), i)
                    W4003.SizeQty14 = getData(Vs10, getColumIndex(Vs10, "SizeQty14"), i)
                    W4003.SizeQty15 = getData(Vs10, getColumIndex(Vs10, "SizeQty15"), i)
                    W4003.SizeQty16 = getData(Vs10, getColumIndex(Vs10, "SizeQty16"), i)
                    W4003.SizeQty17 = getData(Vs10, getColumIndex(Vs10, "SizeQty17"), i)
                    W4003.SizeQty18 = getData(Vs10, getColumIndex(Vs10, "SizeQty18"), i)
                    W4003.SizeQty19 = getData(Vs10, getColumIndex(Vs10, "SizeQty19"), i)
                    W4003.SizeQty20 = getData(Vs10, getColumIndex(Vs10, "SizeQty20"), i)

                    W4003.SizeQty21 = getData(Vs10, getColumIndex(Vs10, "SizeQty21"), i)
                    W4003.SizeQty22 = getData(Vs10, getColumIndex(Vs10, "SizeQty22"), i)
                    W4003.SizeQty23 = getData(Vs10, getColumIndex(Vs10, "SizeQty23"), i)
                    W4003.SizeQty24 = getData(Vs10, getColumIndex(Vs10, "SizeQty24"), i)
                    W4003.SizeQty25 = getData(Vs10, getColumIndex(Vs10, "SizeQty25"), i)
                    W4003.SizeQty26 = getData(Vs10, getColumIndex(Vs10, "SizeQty26"), i)
                    W4003.SizeQty27 = getData(Vs10, getColumIndex(Vs10, "SizeQty27"), i)
                    W4003.SizeQty28 = getData(Vs10, getColumIndex(Vs10, "SizeQty28"), i)
                    W4003.SizeQty29 = getData(Vs10, getColumIndex(Vs10, "SizeQty29"), i)
                    W4003.SizeQty30 = getData(Vs10, getColumIndex(Vs10, "SizeQty30"), i)

                    TotalQty = TotalQty + W4003.SizeQty01
                    TotalQty = TotalQty + W4003.SizeQty02
                    TotalQty = TotalQty + W4003.SizeQty03
                    TotalQty = TotalQty + W4003.SizeQty04
                    TotalQty = TotalQty + W4003.SizeQty05
                    TotalQty = TotalQty + W4003.SizeQty06
                    TotalQty = TotalQty + W4003.SizeQty07
                    TotalQty = TotalQty + W4003.SizeQty08
                    TotalQty = TotalQty + W4003.SizeQty09
                    TotalQty = TotalQty + W4003.SizeQty10

                    TotalQty = TotalQty + W4003.SizeQty11
                    TotalQty = TotalQty + W4003.SizeQty12
                    TotalQty = TotalQty + W4003.SizeQty13
                    TotalQty = TotalQty + W4003.SizeQty14
                    TotalQty = TotalQty + W4003.SizeQty15
                    TotalQty = TotalQty + W4003.SizeQty16
                    TotalQty = TotalQty + W4003.SizeQty17
                    TotalQty = TotalQty + W4003.SizeQty18
                    TotalQty = TotalQty + W4003.SizeQty19
                    TotalQty = TotalQty + W4003.SizeQty20

                    TotalQty = TotalQty + W4003.SizeQty21
                    TotalQty = TotalQty + W4003.SizeQty22
                    TotalQty = TotalQty + W4003.SizeQty23
                    TotalQty = TotalQty + W4003.SizeQty24
                    TotalQty = TotalQty + W4003.SizeQty25
                    TotalQty = TotalQty + W4003.SizeQty26
                    TotalQty = TotalQty + W4003.SizeQty27
                    TotalQty = TotalQty + W4003.SizeQty28
                    TotalQty = TotalQty + W4003.SizeQty29
                    TotalQty = TotalQty + W4003.SizeQty30

                    If READ_PFK4003(WorkOrder, WorkOrderSeq) = True Then
                        If REWRITE_PFK4003(W4003) Then
                            If READ_PFK4002(WorkOrder, WorkOrderSeq) Then
                                W4002 = D4002
                                W4002.QtyOrder = TotalQty
                                Call REWRITE_PFK4002(W4002)
                            End If
                        End If
                    Else
                        If WRITE_PFK4003(W4003) Then
                            If READ_PFK4002(WorkOrder, WorkOrderSeq) Then
                                W4002 = D4002
                                W4002.QtyOrder = TotalQty
                                Call REWRITE_PFK4002(W4002)
                            End If
                        End If
                    End If
                    isudCHK = True : WRITE_CHK = "*"
                    DATA_MOVE_K4003 = True

                End If

            Next
        Catch ex As Exception

        End Try


    End Function


    Private Function DATA_MOVE_K4003(xrow As Integer) As Boolean
        DATA_MOVE_K4003 = False
        Dim TotalQty As Double
        Dim WorkOrder As String
        Dim WorkOrderSeq As String


        Try
            WorkOrder = getData(Vs10, getColumIndex(Vs10, "KEY_WorkOrder"), xrow)
            WorkOrderSeq = getData(Vs10, getColumIndex(Vs10, "KEY_WorkOrderSeq"), xrow)
            TotalQty = 0

            If READ_PFK4002(WorkOrder, WorkOrderSeq) = True Then

                W4003.WorkOrder = WorkOrder
                W4003.WorkOrderSeq = WorkOrderSeq

                W4003.SizeQty01 = getData(Vs10, getColumIndex(Vs10, "SizeQty01"), xrow)
                W4003.SizeQty02 = getData(Vs10, getColumIndex(Vs10, "SizeQty02"), xrow)
                W4003.SizeQty03 = getData(Vs10, getColumIndex(Vs10, "SizeQty03"), xrow)
                W4003.SizeQty04 = getData(Vs10, getColumIndex(Vs10, "SizeQty04"), xrow)
                W4003.SizeQty05 = getData(Vs10, getColumIndex(Vs10, "SizeQty05"), xrow)
                W4003.SizeQty06 = getData(Vs10, getColumIndex(Vs10, "SizeQty06"), xrow)
                W4003.SizeQty07 = getData(Vs10, getColumIndex(Vs10, "SizeQty07"), xrow)
                W4003.SizeQty08 = getData(Vs10, getColumIndex(Vs10, "SizeQty08"), xrow)
                W4003.SizeQty09 = getData(Vs10, getColumIndex(Vs10, "SizeQty09"), xrow)
                W4003.SizeQty10 = getData(Vs10, getColumIndex(Vs10, "SizeQty10"), xrow)

                W4003.SizeQty11 = getData(Vs10, getColumIndex(Vs10, "SizeQty11"), xrow)
                W4003.SizeQty12 = getData(Vs10, getColumIndex(Vs10, "SizeQty12"), xrow)
                W4003.SizeQty13 = getData(Vs10, getColumIndex(Vs10, "SizeQty13"), xrow)
                W4003.SizeQty14 = getData(Vs10, getColumIndex(Vs10, "SizeQty14"), xrow)
                W4003.SizeQty15 = getData(Vs10, getColumIndex(Vs10, "SizeQty15"), xrow)
                W4003.SizeQty16 = getData(Vs10, getColumIndex(Vs10, "SizeQty16"), xrow)
                W4003.SizeQty17 = getData(Vs10, getColumIndex(Vs10, "SizeQty17"), xrow)
                W4003.SizeQty18 = getData(Vs10, getColumIndex(Vs10, "SizeQty18"), xrow)
                W4003.SizeQty19 = getData(Vs10, getColumIndex(Vs10, "SizeQty19"), xrow)
                W4003.SizeQty20 = getData(Vs10, getColumIndex(Vs10, "SizeQty20"), xrow)

                W4003.SizeQty21 = getData(Vs10, getColumIndex(Vs10, "SizeQty21"), xrow)
                W4003.SizeQty22 = getData(Vs10, getColumIndex(Vs10, "SizeQty22"), xrow)
                W4003.SizeQty23 = getData(Vs10, getColumIndex(Vs10, "SizeQty23"), xrow)
                W4003.SizeQty24 = getData(Vs10, getColumIndex(Vs10, "SizeQty24"), xrow)
                W4003.SizeQty25 = getData(Vs10, getColumIndex(Vs10, "SizeQty25"), xrow)
                W4003.SizeQty26 = getData(Vs10, getColumIndex(Vs10, "SizeQty26"), xrow)
                W4003.SizeQty27 = getData(Vs10, getColumIndex(Vs10, "SizeQty27"), xrow)
                W4003.SizeQty28 = getData(Vs10, getColumIndex(Vs10, "SizeQty28"), xrow)
                W4003.SizeQty29 = getData(Vs10, getColumIndex(Vs10, "SizeQty29"), xrow)
                W4003.SizeQty30 = getData(Vs10, getColumIndex(Vs10, "SizeQty30"), xrow)

                TotalQty = TotalQty + W4003.SizeQty01
                TotalQty = TotalQty + W4003.SizeQty02
                TotalQty = TotalQty + W4003.SizeQty03
                TotalQty = TotalQty + W4003.SizeQty04
                TotalQty = TotalQty + W4003.SizeQty05
                TotalQty = TotalQty + W4003.SizeQty06
                TotalQty = TotalQty + W4003.SizeQty07
                TotalQty = TotalQty + W4003.SizeQty08
                TotalQty = TotalQty + W4003.SizeQty09
                TotalQty = TotalQty + W4003.SizeQty10

                TotalQty = TotalQty + W4003.SizeQty11
                TotalQty = TotalQty + W4003.SizeQty12
                TotalQty = TotalQty + W4003.SizeQty13
                TotalQty = TotalQty + W4003.SizeQty14
                TotalQty = TotalQty + W4003.SizeQty15
                TotalQty = TotalQty + W4003.SizeQty16
                TotalQty = TotalQty + W4003.SizeQty17
                TotalQty = TotalQty + W4003.SizeQty18
                TotalQty = TotalQty + W4003.SizeQty19
                TotalQty = TotalQty + W4003.SizeQty20

                TotalQty = TotalQty + W4003.SizeQty21
                TotalQty = TotalQty + W4003.SizeQty22
                TotalQty = TotalQty + W4003.SizeQty23
                TotalQty = TotalQty + W4003.SizeQty24
                TotalQty = TotalQty + W4003.SizeQty25
                TotalQty = TotalQty + W4003.SizeQty26
                TotalQty = TotalQty + W4003.SizeQty27
                TotalQty = TotalQty + W4003.SizeQty28
                TotalQty = TotalQty + W4003.SizeQty29
                TotalQty = TotalQty + W4003.SizeQty30

                If READ_PFK4003(WorkOrder, WorkOrderSeq) = True Then
                    If REWRITE_PFK4003(W4003) Then
                        If READ_PFK4002(WorkOrder, WorkOrderSeq) Then
                            W4002 = D4002
                            W4002.QtyOrder = TotalQty
                            Call REWRITE_PFK4002(W4002)
                        End If
                    End If
                Else
                    If WRITE_PFK4003(W4003) Then
                        If READ_PFK4002(WorkOrder, WorkOrderSeq) Then
                            W4002 = D4002
                            W4002.QtyOrder = TotalQty
                            Call REWRITE_PFK4002(W4002)
                        End If
                    End If
                End If

                isudCHK = True : WRITE_CHK = "*"
                DATA_MOVE_K4003 = True

            End If

        Catch ex As Exception

        End Try


    End Function
    Private Sub DATA_MOVE_DEFAULT()
        W4001.seDepartment = ListCode("Department")
        W4001.seSite = ListCode("Site")

        W4020.seDepartment = ListCode("Department")
        W4020.seGroupComponent = ListCode("GroupComponent")
        W4020.seShoesStatus = ListCode("ShoesStatus")
        W4020.seUnitMaterial = ListCode("UnitMaterial")
        W4020.seUnitPrice = ListCode("UnitPrice")
        W4020.seSubProcess = ListCode("SubProcess")

        W4025.seMainProcess = ListCode("MainProcess")
        W4025.seSubProcess = ListCode("SubProcess")
        W4025.seShoesStatus = ListCode("ShoesStatus")
        W4025.seMachineType = ListCode("MachineType")

        W4033.seAdditionalCost = ListCode("AdditionalCost")
        W4033.seCostingType = ListCode("CostingType")
        W4035.seOverheadCost = ListCode("OverheadCost")

        W4037.seSalesCost = ListCode("SalesCost")
        W4037.seCostingType = ListCode("CostingType")

        W4039.seFieldRemark = ListCode("FieldRemark")
    End Sub


#End Region

#Region "Event"

    Private Sub ptc_Main_DoubleClick(sender As Object, e As EventArgs) Handles ptc_Main.DoubleClick
        If checkisud = False Then ptc_Main.SelectedIndex = 0

        Select Case ptc_Main.SelectedIndex
            Case 0
                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_DETAIL()
                Call DATA_SEARCH_VS00()
                Call DATA_SEARCH_VS10()
            Case 1
                Call DATA_SEARCH_VS2x()

        End Select
    End Sub
    Private Sub ptc_Main_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ptc_Main.SelectedIndexChanged
        If formA = False Then Exit Sub
        If ptc_Main.SelectedIndex = -1 Then Exit Sub

        If checkisud = False Then ptc_Main.SelectedIndex = 0
        Select Case ptc_Main.SelectedIndex
            Case 0
                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_DETAIL()
                Call DATA_SEARCH_VS10()
            Case 1
                Call DATA_SEARCH_VS2x()
        End Select

    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Dim i As Integer
        Dim OrderNo As String
        Dim OrderNoSeq As String
        Dim ArrValue() As String
        Try

            Select Case wJOB
                Case 1 ' Insert

                    Select Case ptc_Main.SelectedIndex

                        Case 0
                            If checkisud = False Then
                                If DataCheck(Me, "PFK4001") = False Then MsgBoxP("Fill correct data !") : Exit Sub

                                Call KEY_COUNT()

                                If DATA_MOVE_K4001() = True Then
                                    Call DATA_MOVE_K4002()
                                    Call DATA_MOVE_K4003()
                                    checkisud = True
                                End If

                            Else
                                If DataCheck(Me, "PFK4001") = False Then Exit Sub

                                If DATA_MOVE_K4001() = True Then
                                    Call DATA_MOVE_K4002()
                                    Call DATA_MOVE_K4003()
                                    checkisud = True
                                End If
                            End If

                    End Select

                Case 2 ' Search
                    Me.Dispose()

                Case 3 ' Update
                    Select Case ptc_Main.SelectedIndex + 1

                        Case 1
                            If checkisud = False Then
                                If DataCheck(Me, "PFK4001") = False Then MsgBoxP("Fill correct data !") : Exit Sub

                                If DATA_MOVE_K4001() = True Then
                                    Call DATA_MOVE_K4002()
                                    Call DATA_MOVE_K4003()
                                    txt_WorkOrder.Code = txt_WorkOrder.Data
                                End If
                                checkisud = True
                            Else
                                If DataCheck(Me, "PFK4001") = False Then Exit Sub

                                If DATA_MOVE_K4001() = True Then
                                    Call DATA_MOVE_K4002()
                                    Call DATA_MOVE_K4003()
                                    txt_WorkOrder.Code = txt_WorkOrder.Data
                                End If

                                checkisud = True
                            End If
                        Case 2


                        Case 3

                        Case 4

                        Case 5

                    End Select

                Case 7
                    Select Case ptc_Main.SelectedIndex + 1
                        Case 1
                            If checkisud = False Then
                                If DataCheck(Me, "PFK4001") = False Then MsgBoxP("Fill correct data !") : Exit Sub

                                If DATA_MOVE_K4002() = True Then
                                    Call DATA_MOVE_K4003()
                                    checkisud = True
                                    wJOB = 3
                                End If

                            Else

                                If DataCheck(Me, "PFK4001") = False Then Exit Sub

                                If DATA_MOVE_K4002() Then
                                    Call DATA_MOVE_K4003()
                                    checkisud = True
                                    wJOB = 3
                                End If
                            End If


                    End Select

                Case 11 ' Auto

                    Select Case ptc_Main.SelectedIndex

                        Case 0
                            If checkisud = False Then
                                If DataCheck(Me, "PFK4001") = False Then MsgBoxP("Fill correct data !") : Exit Sub
                                ArrValue = Value.Replace("'", "").Split(",")
                                Call KEY_COUNT()

                                If DATA_MOVE_K4001() = True Then

                                    For i = 0 To ArrValue.Length - 1
                                        OrderNo = ""
                                        OrderNoSeq = ""

                                        OrderNo = Strings.Left(ArrValue(i), 9)
                                        OrderNoSeq = Strings.Right(ArrValue(i), 3)

                                        Call KEY_COUNT_NO()
                                        Call PrcExe("USP_PFK4001_TRANSFER_ACCEPT_F1", cn, L4001.WorkOrder, L4002.WorkOrderSeq, OrderNo, OrderNoSeq)
                                        Call PrcExe("USP_PFK4001_GENERATE_JOBCARD_F1", cn, L4001.WorkOrder, L4002.WorkOrderSeq)
                                        Call DATA_SEARCH_VS00()
                                        Call DATA_SEARCH_VS10()
                                        wJOB = 3
                                    Next

                                End If

                            Else
                                If DataCheck(Me, "PFK4001") = False Then Exit Sub
                                ArrValue = Value.Replace("'", "").Split(",")

                                If DATA_MOVE_K4001() = True Then
                                    For i = 0 To ArrValue.Length - 1
                                        OrderNo = ""
                                        OrderNoSeq = ""

                                        OrderNo = Strings.Left(ArrValue(i), 9)
                                        OrderNoSeq = Strings.Right(ArrValue(i), 3)

                                        Call KEY_COUNT_NO()
                                        If PrcExe("USP_PFK4001_TRANSFER_ACCEPT_F1", cn, L4001.WorkOrder, L4002.WorkOrderSeq, OrderNo, OrderNoSeq) Then
                                            Call PrcExe("USP_PFK4001_GENERATE_JOBCARD_F1", cn, L4001.WorkOrder, L4002.WorkOrderSeq)
                                            If READ_PFK1312(OrderNo, OrderNoSeq) Then
                                                D1312.DateTransfer = Pub.DAT
                                                Call REWRITE_PFK1312(D1312)
                                            End If
                                            Call DATA_SEARCH_VS00()
                                            Call DATA_SEARCH_VS10()
                                            wJOB = 3
                                        End If

                                    Next
                                    checkisud = True
                                End If
                            End If

                    End Select

            End Select
            If ptc_Main.SelectedIndex > -1 Then MsgBoxP("Save successful at " & ptc_Main.SelectedTab.Text & " !", vbInformation)
        Catch ex As Exception
            MsgBoxP("Has error in saving this item!")
        End Try

    End Sub

    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        If wJOB = 2 Then
            isudCHK = False
            Me.Dispose()
        Else
            isudCHK = True
            Me.Dispose()
        End If
    End Sub

    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs) Handles cmd_DEL.Click
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))
        Dim i As Integer

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "cmd_DEL_Click")
            Exit Sub
        End If
        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub
        Select Case ptc_Main.SelectedIndex + 1

            Case 1
                For i = 0 To vS00.ActiveSheet.RowCount - 1
                    If getDataM(vS00, getColumIndex(vS00, "CheckUse"), i) = "1" Then
                        If CheckExist(txt_WorkOrder.Data, getData(vS00, getColumIndex(vS00, "Key_WorkOrderSeq"), i)) = True Then Exit Sub
                        If PrcExe("USP_ISUD4001A_sTAB1_ITEM_DELETE", cn, txt_WorkOrder.Data, getData(vS00, getColumIndex(vS00, "Key_WorkOrderSeq"), i)) = True Then
                            isudCHK = True
                        End If
                    End If
                Next

                Me.Dispose()

        End Select
    End Sub

    Private Sub Me_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Me.SuspendLayout()
        If ptc_Main.TabCount > 1 Then
            If Me.Width > 30 Then
                ptc_Main.ItemSize = New Size((Me.Width - 50) / ptc_Main.TabCount, 25)
            End If
        End If

        If Ptc_Sub.TabCount > 1 Then
            If Me.Width > 30 Then
                Ptc_Sub.ItemSize = New Size((Me.Width - 50) / Ptc_Sub.TabCount, 25)
            End If
        End If
        Me.ResumeLayout(True)
    End Sub


    Private Sub vS00_CellClick(sender As Object, e As CellClickEventArgs) Handles vS00.CellClick
        Dim xCOL As Integer
        Dim xROW As Integer

        xROW = sender.ActiveSheet.ActiveRowIndex
        xCOL = sender.ActiveSheet.ActiveColumnIndex

        txt_WorkOrderSeq.Data = getData(vS00, getColumIndex(vS00, "KEY_WorkOrderSeq"), xROW)
    End Sub


    Private Sub vS_KeyDown(sender As Object, e As KeyEventArgs) Handles vS00.KeyDown, Vs10.KeyDown
        Dim xCOL As Integer
        Dim xROW As Integer

        xCOL = sender.ActiveSheet.ActiveColumnIndex
        xROW = sender.ActiveSheet.ActiveRowIndex

        If xCOL = getColumIndex(sender, "CheckUse") Then Exit Sub

        If e.Shift = True Then Exit Sub


        Select Case e.KeyCode
            Case Keys.Enter
                If wJOB = 2 Then Exit Sub

                Select Case True
                    Case sender Is vS00

                    Case sender Is Vs10
                        Call DATA_MOVE_K4003(xROW)


                End Select

        End Select
    End Sub


    Private Sub cmd_AttachID_Click(sender As Object, e As EventArgs) Handles cmd_AttachID.Click
        Call DATA_SEARCH_HEAD()
    End Sub


#End Region


End Class