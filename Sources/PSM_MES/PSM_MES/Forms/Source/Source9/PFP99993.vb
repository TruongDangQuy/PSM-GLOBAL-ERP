Public Class PFP99993
#Region "Variable"
    Private t_SPACE, SANO As String
    Private Job_Start As Boolean
    Private W7411 As T7411_AREA
    Private W9992 As T9992_AREA
    Private W9993 As T9993_AREA
    Private W9994 As T9994_AREA
    Private W9995 As New T9995_AREA
    Private Dsu01 As Long
    Private a7411() As T7411_AREA
    Private a9992() As T9992_AREA
    Dim tabcheck As Boolean = False
#End Region

#Region "Form_Load"
    Private Sub PFP99992_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Pub.SAW = "ERPTEAM" Then Me.Dispose()
        W9992 = D9992
        W9993 = D9993
        W9994 = D9994
        W7411 = D7411
        lab_SITE01.Text = "CHANG SHUEN"
        lab_SITE01.Tag = "001"
        SPR_CHECKBOX(Vs2, 0, 3, 4, 5, 6, 7)
        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_SET(Vs2, , , , OperationMode.Normal)
    End Sub

#End Region

#Region "HEAD_SEARCH"
    Public Function HEAD_DISPLAY01(USER As String) As Boolean
        HEAD_DISPLAY01 = False
        txt_IDNO.Text = ""
        txt_Name.Text = ""
        txt_NameDepartment.Text = ""
        txt_NamePosition.Text = ""
        txt_NamePosition.Text = ""
        txt_NameOnePosition.Text = ""
        txt_ID01.Text = ""
        txt_PW01.Text = ""
        LAB_GROUP01.Text = ""
        txt_PW02.Text = ""
        lab_SITE01.Text = "SY Vina"
        READ_PFK7411(USER)
        txt_IDNO.Text = D7411.IDNO
        txt_Name.Text = D7411.Name

        Call READ_PFK7171(Const_BUSEO, D7411.cdDepartment)
        txt_NameDepartment.Text = D7171.BasicName

        Call READ_PFK7171(Const_JIKUI, D7411.cdPosition)
        txt_NamePosition.Text = D7171.BasicName

        Call READ_PFK7171(Const_Site, D7411.cdSite)
        lab_SITE01.Text = D7171.BasicName
        txt_NameInCharge.Text = D7171.BasicName

        Call READ_PFK7171(Const_SOSOK, D7411.cdNationality)
        txt_NameOnePosition.Text = D7171.BasicName

        If READ_PFK9992(Pub.SITE, D7411.IDNO) = True Then
            READ_PFK7171(Const_GROUP_DMS, D9992.GROUP)
            txt_ID01.Text = D9992.ID
            txt_PW01.Text = D9992.PW
            LAB_GROUP01.Text = D7171.BasicName
            txt_PW02.Text = D9992.GROUPPW
        End If
        HEAD_DISPLAY01 = True
    End Function
#End Region

#Region "DATA_SEARCH"

    'Private Function DATA_INSERT01() As Boolean Handles cmd_Save.Click
    '    DATA_INSERT01 = False
    '    Try
    '        If cmb_GROUP.Items.Count = 0 Then
    '            Call MsgBoxP("428", "DATA_INSERT01")
    '            Exit Function
    '        End If

    '        If Trim(txt_PW02.Text) = "" Then
    '            Call MsgBoxP("429", "DATA_INSERT01")
    '            Exit Function
    '        End If

    '        W9992.SITE = Pub.SITE
    '        W9992.SANO = txt_IDNO.Data
    '        W9992.ID = Trim(txt_ID01.Data)
    '        W9992.PW = Trim(txt_PW01.Text)
    '        W9992.GRANT = "1"
    '        W9992.GROUP = Mid(cmb_GROUP.Text, 1, 3)
    '        W9992.GROUPPW = UCase(Trim(txt_PW02.Text))

    '        If READ_PFK9992(Pub.SITE, W9992.SANO) = False Then
    '            If WRITE_PFK9992(W9992) = False Then
    '                Call MsgBoxP("35", "DATA_INSERT")
    '            End If
    '        Else
    '            If REWRITE_PFK9992(W9992) = False Then
    '                Call MsgBoxP("35", "DATA_INSERT")
    '                Exit Function
    '            End If
    '        End If

    '        Call MsgBoxP("430", "DATA_INSERT01")

    '        DATA_INSERT01 = True
    '        Call HEAD_DISPLAY01(SANO)

    '    Catch ex As Exception
    '        DATA_INSERT01 = False
    '        Call MsgBoxP("35", "DATA_INSERT")
    '    End Try
    'End Function
    Private Function GROUP_DISPLAY() As Boolean

        GROUP_DISPLAY = False

        Dim SQL As String
        Dim i As Integer

        For i = 0 To Vs2.ActiveSheet.RowCount - 1
            setData(Vs2, 0, i, 0, , True)
            setData(Vs2, 3, i, 0, , True)
            setData(Vs2, 4, i, 0, , True)
            setData(Vs2, 5, i, 0, , True)
            setData(Vs2, 6, i, 0, , True)
        Next

        SQL = " SELECT K7171_BasicCode, K7171_BasicName FROM PFK7171 "
        SQL = SQL & " WHERE K7171_BasicSel = '" + Const_GROUP_DMS + "' "
        SQL = SQL & " ORDER BY K7171_BasicSel "
        SQL = Replace(SQL, "SUBSTR(", "SUBSTRING(")
        SQL = Replace(SQL, "NVL(", "IsDBNull(")

        cmd = New SqlClient.SqlCommand(SQL, cn)
        da.SelectCommand = cmd
        ds.Reset()
        da.Fill(ds)

        If GetDsRc(ds) = 0 Then
            MsgBoxP("SQL DATABASE CONNECTION ERROR!", vbRetryCancel)
            Exit Function
        Else
            cmb_GROUP.Text = ""
            cmb_GROUP.Items.Clear()
            cmb_GROUP.Items.Add("SELECT")
            For i = 0 To GetDsRc(ds) - 1
                cmb_GROUP.Items.Add(GetDsData(ds, i, "K7171_BasicCode") & Space(4) & GetDsData(ds, i, "K7171_BasicName"))
            Next
        End If
        GROUP_DISPLAY = True
    End Function

#End Region

#Region "Event"
    Private Sub Button21_Click(sender As Object, e As EventArgs)
        FARPOINT_CHKBOXALL(Vs2.Sheets(0))
    End Sub
    Private Sub Button23_Click(sender As Object, e As EventArgs)
        FARPOINT_CHKBOXCAN(Vs2.Sheets(0))
    End Sub
    Private Sub cmdDEL_Click(sender As Object, e As EventArgs) Handles cmd_del.Click
        Try
            If txt_IDNO.Text.Trim = "" Then Exit Sub

            SQL = " DELETE FROM PFK9992 "
            SQL = SQL & " WHERE K9992_SITE = '" & Pub.SITE & "' "
            SQL = SQL & "   AND K9992_SANO = '" & txt_IDNO.Text.Trim & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()
            txt_ID01.Text = ""
            txt_PW01.Text = ""
            LAB_GROUP01.Text = ""
            txt_PW02.Text = ""
        Catch ex As Exception
            MsgBoxP("ERROR IN cmdDEL0_Click")
        End Try
    End Sub

    Private Sub cmb_GROUP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_GROUP.SelectedIndexChanged
        Dim i As Integer
        Dim j As Integer

        If cmb_GROUP.Items.Count = 0 Then Exit Sub
        Dim GROUPNAME As String
        GROUPNAME = Mid(cmb_GROUP.Text, 1, 3)

        trv_001.Nodes.Clear()

        strArr_Listof.Clear()



        tabcheck = True
        ptc_1.SelectedIndex = 1

        Dim m As Integer = 0
        Vs2.ActiveSheet.RowCount = 0

        Dim bb As New ToolStripMenuItem

        Dim Children As New List(Of ToolStripMenuItem)

        For i = 0 To MdiMenu.MenuStrip1.Items.Count - 1
            Children.Add(MdiMenu.MenuStrip1.Items(i))
        Next


        Dim int_MaXChildren As Integer
        int_MaXChildren = Children.Count
        i = 0

        For i = 0 To Children.Count - 1
            Dim Level As Integer
            Level = 0
            Dim xxx As New TreeNode
            xxx.Name = Children(i).Name
            xxx.Text = Children(i).Text
            xxx.Tag = Children(i).Name

            If strArr_Listof.Contains(xxx.Name) = False Then
                strArr_Listof.Add(xxx.Name) : trv_001.Nodes.Add(xxx)
                If trv_001.Nodes.Count < Children.Count Then Call DATA_SEARCH_RECURSIVE(Children(i), trv_001.Nodes(i))
            End If

        Next

        trv_001.ExpandAll()
        trv_001.Nodes(0).EnsureVisible()
        trv_001.Nodes(0).ExpandAll()
        'Call DATA_SEARCH02_NOTE()


        Dim ChildrenNode As New List(Of TreeNode)

        ChildrenNode = trv_001.FindAllNode

        For i = 0 To ChildrenNode.Count - 1
            If READ_PFK9994(lab_SITE01.Tag, cmb_GROUP.Text.Substring(0, 3), ChildrenNode(i).Name) Then
                ChildrenNode(i).Checked = True
            End If
        Next

    End Sub

    Private strArr_Listof As New List(Of String)
    Private Sub DATA_SEARCH_RECURSIVE(strToolStripMenuItemstr As ToolStripMenuItem, ByVal MainTreeNode As TreeNode)
        Try
            Dim i As Integer

            For i = 0 To strToolStripMenuItemstr.DropDownItems.Count - 1

                Dim xxxx As New TreeNode
                xxxx.Name = strToolStripMenuItemstr.DropDownItems(i).Name
                xxxx.Text = strToolStripMenuItemstr.DropDownItems(i).Text
                xxxx.Tag = strToolStripMenuItemstr.DropDownItems(i).Name


                If xxxx.Name.Contains("Separator") = False Then
                    If strArr_Listof.Contains(xxxx.Name) = False Then
                        strArr_Listof.Add(xxxx.Name) : MainTreeNode.Nodes.Add(xxxx)
                        Call DATA_SEARCH_RECURSIVE(strToolStripMenuItemstr.DropDownItems(i), MainTreeNode.Nodes(MainTreeNode.Nodes.Count - 1))
                    End If
                End If

            Next

            Return

        Catch ex As Exception

        End Try
    End Sub

    'Private Sub cmb_GROUP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_GROUP.SelectedIndexChanged
    '    Dim i As Integer
    '    Dim j As Integer
    '    For i = 0 To Vs2.ActiveSheet.RowCount - 1
    '        setData(Vs2, 0, i, 0, , True)
    '        setData(Vs2, 3, i, 0, , True)
    '        setData(Vs2, 4, i, 0, , True)
    '        setData(Vs2, 5, i, 0, , True)
    '        setData(Vs2, 6, i, 0, , True)
    '        setData(Vs2, 7, i, 0, , True)
    '    Next
    '    If cmb_GROUP.Items.Count = 0 Then Exit Sub
    '    Dim GROUPNAME As String
    '    GROUPNAME = Mid(cmb_GROUP.Text, 1, 3)
    '    For j = 0 To Vs2.ActiveSheet.RowCount - 1
    '        If READ_PFK9994(Pub.SITE, GROUPNAME, Vs2.Sheets(0).Cells(j, 2).Value) = True Then
    '            If D9994.PCHK = "1" Then setData(Vs2, 0, j, 1, , True)
    '            If D9994.PCHK = "2" Then setData(Vs2, 0, j, 0, , True)
    '        End If
    '        If READ_PFK9993(Pub.SITE, GROUPNAME, Vs2.Sheets(0).Cells(j, 2).Value) = True Then
    '            If D9993.CHK01 = "1" Then Vs2.Sheets(0).Cells(j, 3).Value = True Else Vs2.Sheets(0).Cells(j, 3).Value = False
    '            If D9993.CHK02 = "1" Then Vs2.Sheets(0).Cells(j, 4).Value = True Else Vs2.Sheets(0).Cells(j, 4).Value = False
    '            If D9993.CHK03 = "1" Then Vs2.Sheets(0).Cells(j, 5).Value = True Else Vs2.Sheets(0).Cells(j, 5).Value = False
    '            If D9993.CHK04 = "1" Then Vs2.Sheets(0).Cells(j, 6).Value = True Else Vs2.Sheets(0).Cells(j, 6).Value = False
    '            If D9993.CHK05 = "1" Then Vs2.Sheets(0).Cells(j, 7).Value = True Else Vs2.Sheets(0).Cells(j, 7).Value = False
    '        End If
    '    Next
    'End Sub
    Private LastNode As New TreeNode
    Private NowNode As New TreeNode

    Private Sub CheckAll(ByVal MyTreeNode As TreeNode, Optional ByVal CheckAll_YesNo As Boolean = True)
        Dim mTN As TreeNode
        For Each mTN In MyTreeNode.Nodes
            CheckAll(mTN, CheckAll_YesNo)
            mTN.Checked = CheckAll_YesNo
        Next
    End Sub
    Private Sub CheckAllTreeview(ByVal MyTreeNode As TreeView, Optional ByVal CheckAll_YesNo As Boolean = True)
        Dim mTN As TreeNode
        For Each mTN In MyTreeNode.Nodes
            CheckAll(mTN, CheckAll_YesNo)
            mTN.Checked = CheckAll_YesNo
        Next
    End Sub
    Private FormName As String
    Private Parameter As String
    Private Sub trv_001_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles trv_001.AfterCheck

        'Exit Sub

        Try
            If LastNode Is Nothing Then LastNode = e.Node
            'If LastNode.Name <> e.Node.Name Then LastNode.Checked = False : LastNode = e.Node

            Dim Sel As String
            Sel = e.Node.Tag

            FormName = Sel

            txt_NodeName.Data = e.Node.Text & "[" & e.Node.Tag & "]"
            txt_NodeName.Code = e.Node.Tag

            If e.Node.Checked = True Then
                Call DATA_SEARCH02_NOTE(e.Node, Sel)
            End If


            If chk_ISUD1.Checked Then txt_NodeName.Data = txt_NodeName.Data & " INSERT + "
            If chk_ISUD2.Checked Then txt_NodeName.Data = txt_NodeName.Data & " SEARCH + "
            If chk_ISUD3.Checked Then txt_NodeName.Data = txt_NodeName.Data & " UPDATE + "
            If chk_ISUD4.Checked Then txt_NodeName.Data = txt_NodeName.Data & " DELETE + "

            txt_NodeName.Data = Strings.Left(txt_NodeName.Data, Len(txt_NodeName.Data) - 2)

        Catch ex As Exception

        End Try
    End Sub

    Private Function DATA_SEARCH02_NOTE(Node As Object, KSEL As String) As Boolean
        Dim DSNEW As New DataSet

        DATA_SEARCH02_NOTE = False

        Try
            DSNEW = PrcDS("USP_ISUD9994_SEARCH_VS0_NODE", cn, KSEL)

            If GetDsRc(DSNEW) = 0 Then
                Exit Function
            End If

            DATA_SEARCH02_NOTE = True
        Catch ex As Exception

        End Try
    End Function


    'Private Sub cmdSET5_Click(sender As Object, e As EventArgs)
    '    Try
    '        Dim i As Integer
    '        SQL = ""
    '        SQL = " DELETE FROM PFK9994 "
    '        SQL = SQL & " WHERE K9994_SITE = '" & Pub.SITE & "' "
    '        SQL = SQL & "   AND K9994_GROUP = '" & Mid(cmb_GROUP.Text, 1, 3) & "' "
    '        cmd = New SqlClient.SqlCommand(SQL, cn)
    '        cmd.ExecuteNonQuery()
    '        SQL = ""
    '        SQL = " DELETE FROM PFK9993 "
    '        SQL = SQL & " WHERE K9993_SITE = '" & Pub.SITE & "' "
    '        SQL = SQL & "   AND K9993_GROUP = '" & Mid(cmb_GROUP.Text, 1, 3) & "' "
    '        cmd = New SqlClient.SqlCommand(SQL, cn)
    '        cmd.ExecuteNonQuery()
    '        For i = 0 To Vs2.ActiveSheet.RowCount - 1
    '            W9994.SITE = Pub.SITE
    '            W9994.GROUP = Mid(cmb_GROUP.Text, 1, 3)
    '            W9994.PROG = Trim(Vs2.Sheets(0).Cells(i, 2).Value)
    '            W9993.SITE = Pub.SITE
    '            W9993.GROUP = Mid(cmb_GROUP.Text, 1, 3)
    '            W9993.PROG = Trim(Vs2.Sheets(0).Cells(i, 2).Value)
    '            If W9994.PROG <> "" Then
    '                If Vs2.Sheets(0).Cells(i, 0).Value = True Then W9994.PCHK = "1" Else W9994.PCHK = "2"
    '                If Vs2.Sheets(0).Cells(i, 3).Value = True Then W9993.CHK01 = "1" Else W9993.CHK01 = "2"
    '                If Vs2.Sheets(0).Cells(i, 4).Value = True Then W9993.CHK02 = "1" Else W9993.CHK02 = "2"
    '                If Vs2.Sheets(0).Cells(i, 5).Value = True Then W9993.CHK03 = "1" Else W9993.CHK03 = "2"
    '                If Vs2.Sheets(0).Cells(i, 6).Value = True Then W9993.CHK04 = "1" Else W9993.CHK04 = "2"
    '                If Vs2.Sheets(0).Cells(i, 7).Value = True Then W9993.CHK05 = "1" Else W9993.CHK05 = "2"
    '                If W9994.PROG = "PFP71710" Then
    '                    W9994.PROG = "PFP71710"
    '                End If
    '                Call WRITE_PFK9994(W9994)
    '                Call WRITE_PFK9993(W9993)
    '            End If
    '        Next
    '        MsgBoxP("UPDATE GROUP SUCCESSFULLY !", vbInformation)
    '    Catch ex As Exception
    '        MsgBoxP("57", "ERROR IN UPDATE GROUP")
    '    End Try
    'End Sub

    Private Function DATA_SEARCH_VS1() As Boolean

        Dim RS01 As DataRow = Nothing

        Vs1.Enabled = False

        DATA_SEARCH_VS1 = False
        DS1 = PrcDS("USP_PFP99992_SEARCH_VS1", cn, txt_SANO.Data, _
                     "",
                    Const_Site, _
                    Const_Nationality, _
                    Const_Department, _
                    Const_OnePosition, _
                    Const_Position, _
                    Const_Incharge, _
                    "1", _
                    "1")
        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            Vs1.ActiveSheet.RowCount = 0
            Exit Function
        End If

        SPR_SET(Vs1, 1, , , OperationMode.Normal, True)
        SPR_PRO(Vs1, DS1, "USP_PFP77411_SEARCH_VS1", "Vs1")


        DATA_SEARCH_VS1 = True

        Vs1.Enabled = True
    End Function
    Private Function DATA_SEARCH_01() As Boolean
        DATA_SEARCH_01 = False
        Try

            DS1 = PrcDS("USP_PFP99992_SEARCH_VS1_LINE", cn, getData(Vs1, getColumIndex(Vs1, "IDNO"), Vs1.ActiveSheet.ActiveRowIndex), _
            Const_Site, _
            Const_Nationality, _
            Const_Department, _
            Const_OnePosition, _
            Const_Position, _
            Const_Incharge)
            If GetDsRc(DS1) = 0 Then
                Exit Function : Me.Dispose()
                isudCHK = False
            End If

            STORE_MOVE(Me, DS1)

            lab_SITE01.Text = GetDsData(DS1, 0, "NameSite")
            lab_SITE01.Tag = GetDsData(DS1, 0, "NameCode")
            txt_ID01.Data = GetDsData(DS1, 0, "IDNAME")
            txt_PW01.Data = GetDsData(DS1, 0, "PW")
            txt_PW02.Data = GetDsData(DS1, 0, "GROUPPW")
            LAB_GROUP01.Text = GetDsData(DS1, 0, "GROUPNAME")

            If GetDsData(DS1, 0, "GROUP_ERO") = "001" Then chk_GROUP_ERO.Checked = True Else chk_GROUP_ERO.Checked = False

            DATA_SEARCH_01 = True
        Catch ex As Exception

        End Try

    End Function
    Private Function HEAD_SEARCH_01(IDNO) As Boolean
        HEAD_SEARCH_01 = False
        Try


            DS1 = PrcDS("USP_PFP99992_SEARCH_VS1_LINE", cn, IDNO, _
            Const_Site, _
            Const_Nationality, _
            Const_Department, _
            Const_OnePosition, _
            Const_Position, _
            Const_Incharge)
            If GetDsRc(DS1) = 0 Then
                Exit Function : Me.Dispose()
                isudCHK = False
            End If

            STORE_MOVE(Me, DS1)
            lab_SITE01.Text = GetDsData(DS1, 0, "NameSite")
            lab_SITE01.Tag = GetDsData(DS1, 0, "NameCode")
            txt_ID01.Data = GetDsData(DS1, 0, "IDNAME")
            txt_PW01.Data = GetDsData(DS1, 0, "PW")
            txt_PW02.Data = GetDsData(DS1, 0, "GROUPPW")
            LAB_GROUP01.Text = GetDsData(DS1, 0, "GROUPNAME")
            HEAD_SEARCH_01 = True
        Catch ex As Exception

        End Try

    End Function
    Private Sub txt_SANO_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_SANO.KeyDown
        If e.KeyValue = Keys.Enter Then
            'REAK_K7411_K9992_SANO(Vs1.Sheets(0), Pub.SITE, Trim(txt_SANO.Text))
        End If
    End Sub
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        If DATA_SEARCH_VS1() = True Then Exit Sub
    End Sub
    Private Sub ptc_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ptc_1.SelectedIndexChanged
        If tabcheck = True Then ptc_1.SelectedIndex = 1 Else ptc_1.SelectedIndex = 0
    End Sub

    'Private Sub cmdDEL0_Click(sender As Object, e As EventArgs) Handles cmd_Save.Click
    '    Try
    '        Call DATA_INSERT01()
    '        txt_ID01.Focus()
    '    Catch ex As Exception
    '        MsgBoxP("ERROR IN cmdDEL0_Click")
    '    End Try
    'End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ID01.KeyPress, txt_PW01.KeyPress, txt_PW02.KeyPress
        keypresserp(sender, e)
    End Sub
    Private Sub cmdJOB_Click(sender As Object, e As EventArgs) Handles cmdJOB_dyw.Click
        cmb_GROUP.Items.Clear()
        Dim tmpPW_CHK As String
        Dim tmpPW_IN As String
        If READ_PFK7171(Const_PASSWORD, "009") = True Then
            If D7171.NameSimply = "" Then
                tmpPW_CHK = "PSM@."
            Else
                tmpPW_CHK = D7171.NameSimply
            End If
            Dim f As Form
            f = New FPassWord
            f.ShowDialog()
            tmpPW_IN = PASSWORDCHECK
            If tmpPW_IN <> tmpPW_CHK Then
                MsgBoxP("WRONG PASS!", vbInformation, "cmd_DEL_Click")
                Exit Sub
            End If
        End If

        If GROUP_DISPLAY() = True Then
            tabcheck = True
            ptc_1.SelectedIndex = 1
            Dim i As Integer = 0
            Dim j As Integer = 0
            Dim m As Integer = 0
            Vs2.ActiveSheet.RowCount = 0

            Dim bb As New ToolStripMenuItem

            Dim Children As New List(Of ToolStripMenuItem)
            Children = MdiMenu.MenuStrip1.FindAllToolStripMenuItem()


            For i = 0 To Children.Count - 1
                If Children(i).Name <> "" Then
                    Vs2.ActiveSheet.RowCount += 1
                    Vs2.Sheets(0).Cells(m, 1).Value = Children(i).Text
                    Vs2.Sheets(0).Cells(m, 2).Value = Children(i).Name
                    Vs2.Sheets(0).Cells(m, 1).ForeColor = Color.Red
                    Vs2.Sheets(0).Cells(m, 1).Font = New Font("Tahoma", 9, FontStyle.Bold)
                    bb = Children(i)
                    m = m + 1
                End If
            Next

        Else
            Exit Sub
        End If


    End Sub


    Private Function DATA_SEARCH02(KSEL As String, Optional KNAME As String = Nothing) As Boolean
        Dim DSNEW As New DataSet

        DATA_SEARCH02 = False

        Try
            DSNEW = PrcDS("USP_ISUD9994_SEARCH_VS0", cn, KSEL)

            If GetDsRc(DSNEW) = 0 Then

                Exit Function
            End If

            Dim i As Integer

            'trv_001.Nodes.Clear()

            'For i = 0 To GetDsRc(DSNEW) - 1
            '    Dim xxx As New TreeNode
            '    xxx.Name = GetDsData(DSNEW, i, "K9994_PROG")
            '    xxx.Text = GetDsData(DSNEW, i, "K9994_ProgramName")
            '    xxx.Tag = GetDsData(DSNEW, i, "K9994_PROG")

            '    trv_001.Nodes.Add(xxx)
            'Next

            DATA_SEARCH02 = True
        Catch ex As Exception

        End Try
    End Function

#Region "Sheet_Event"


    Private Sub FpSpread1_CellClick(sender As Object, e As FarPoint.Win.Spread.CellClickEventArgs)
        If e.Row < 0 Then Exit Sub
        SANO = Vs1.Sheets(0).Cells(e.Row, 0).Value
    End Sub

    Private Sub FpSpread1_CellDoubleClick(sender As Object, e As FarPoint.Win.Spread.CellClickEventArgs)
        If Trim(SANO) <> "" Then
            HEAD_DISPLAY01(SANO)
        End If
    End Sub
#End Region




    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If e.ColumnHeader = True Then Exit Sub
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If DATA_SEARCH_01() = False Then Me.Form_ClearData()
        cmb_GROUP.Text = ""
    End Sub



    Private Sub cmd_groupadd_Click(sender As Object, e As EventArgs) Handles cmd_groupadd.Click
        If ISUD7171A.Link_ISUD7171A(1, "905", "000") = False Then Exit Sub
        GROUP_DISPLAY()
    End Sub

    Private Sub cmd_groupupdate_Click(sender As Object, e As EventArgs) Handles cmd_groupupdate.Click
        If IsNumeric(cmb_GROUP.Text.Substring(1, 3)) = False Then Exit Sub
        Dim str As String
        str = cmb_GROUP.Text.Substring(0, 3)
        If ISUD7171A.Link_ISUD7171A(3, "905", str) = False Then Exit Sub
        GROUP_DISPLAY()
    End Sub

    Private Sub cmd_groupsave_Click(sender As Object, e As EventArgs) Handles cmd_groupsave.Click
        Dim i As Integer
        Dim str As String
        Dim SQL As String
        Dim cmd As New SqlClient.SqlCommand

        Try
            If cmb_GROUP.Text.Trim = "" Then Exit Sub
            If IsNumeric(cmb_GROUP.Text.Substring(1, 3)) = False Then Exit Sub
            str = cmb_GROUP.Text.Substring(0, 3)

            SQL = "DELETE  FROM PFK9993"
            SQL = SQL + " WHERE K9993_SITE = '" + lab_SITE01.Tag + "'"
            SQL = SQL + " AND K9993_GROUP= '" + str + "'"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            SQL = "DELETE  FROM PFK9994"
            SQL = SQL + " WHERE K9994_SITE = '" + lab_SITE01.Tag + "'"
            SQL = SQL + " AND K9994_GROUP= '" + str + "'"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            'For i = 0 To Vs2.ActiveSheet.RowCount - 1
            '    If getData(Vs2, 2, i) IsNot Nothing Then
            '        W9993.GROUP = str
            '        W9993.SITE = lab_SITE01.Tag
            '        W9993.PROG = getData(Vs2, 2, i)
            '        W9993.CHK01 = getDataM(Vs2, 3, i)
            '        W9993.CHK02 = getDataM(Vs2, 4, i)
            '        W9993.CHK03 = getDataM(Vs2, 5, i)
            '        W9993.CHK04 = getDataM(Vs2, 6, i)
            '        W9993.CHK05 = getDataM(Vs2, 7, i)
            '        WRITE_PFK9993(W9993)
            '        W9994.GROUP = str
            '        W9994.SITE = lab_SITE01.Tag
            '        W9994.PROG = getData(Vs2, 2, i)
            '        W9994.PCHK = getDataM(Vs2, 0, i)
            '        WRITE_PFK9994(W9994)
            '    End If
            'Next
            'If CIntp(cmb_GROUP.Text.Substring(1, 3)) = 1 Then
            '    SQL = "DELETE  FROM PFK9995"
            '    cmd = New SqlClient.SqlCommand(SQL, cn)
            '    cmd.ExecuteNonQuery()
            '    For i = 0 To Vs2.ActiveSheet.RowCount - 1
            '        If getData(Vs2, 2, i) IsNot Nothing Then
            '            If getData(Vs2, 2, i) <> "" Then
            '                W9995.PROG = getData(Vs2, 2, i)
            '                W9995.NAME = getData(Vs2, 1, i)
            '                W9995.SEQ = (i + 1).ToString("0000")
            '                W9995.REMARK = ""
            '                WRITE_PFK9995(W9995)
            '            End If
            '        End If
            '    Next

            'End If


            Dim Children As New List(Of TreeNode)

            Children = trv_001.FindAllNode


            For i = 0 To Children.Count - 1
                W9993.GROUP = str
                W9993.SITE = lab_SITE01.Tag
                W9993.PROG = Children(i).Tag
                W9993.CHK01 = chk_ISUD1.CheckState
                W9993.CHK02 = chk_ISUD2.CheckState
                W9993.CHK03 = chk_ISUD3.CheckState
                W9993.CHK04 = chk_ISUD4.CheckState
                W9993.CHK05 = chk_ISUD5.CheckState
                WRITE_PFK9993(W9993)
                W9994.GROUP = str
                W9994.SITE = lab_SITE01.Tag
                W9994.PROG = Children(i).Name
                If Children(i).PrevNode IsNot Nothing Then W9994.AFTERPROG = Children(i).PrevNode.Name
                If Children(i).Checked Then W9994.PCHK = "1" Else W9994.PCHK = "2"
                WRITE_PFK9994(W9994)

            Next
            MsgBoxP("Update Group Successfully!", vbInformation)

        Catch ex As Exception
            MsgBoxP("Error! Please Contact ERP Team")
        End Try
    End Sub

    Private Sub DATA_INSERT01(sender As Object, e As EventArgs) Handles cmd_Save.Click

        Try
            W9992.ID = txt_ID01.Data
            W9992.SITE = lab_SITE01.Tag
            W9992.SANO = txt_IDNO.Data
            W9992.PW = txt_PW01.Data
            W9992.GRANT = "1"

            If chk_GROUP_ERO.Checked = True Then
                W9992.GROUP_ERO = "001"
            End If

            If cmb_GROUP.Text <> "" Then
                If IsNumeric(cmb_GROUP.Text.Substring(1, 3)) = False Then Exit Sub
                str = cmb_GROUP.Text.Substring(0, 3)
                W9992.GROUP = str
            Else
                If LAB_GROUP01.Text.Trim = "" Then MsgBoxP("No Choose Group! Please Contact ERP Team") : Exit Sub
                W9992.GROUP = LAB_GROUP01.Text
            End If
            W9992.GROUPPW = txt_PW02.Data

            If READ_PFK9992(W9992.SITE, W9992.SANO) = True Then
                REWRITE_PFK9992(W9992)
            Else
                WRITE_PFK9992(W9992)
            End If
            MsgBoxP("Save ID Successfully!")
            If HEAD_SEARCH_01(W9992.SANO) = False Then Me.Form_ClearData()
        Catch ex As Exception
            MsgBoxP("No Choose Group! Please Contact ERP Team")
        End Try
    End Sub

#End Region

    Private Sub Vs2_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs2.CellClick
        If e.ColumnHeader = True Then
            If TypeOf (Vs2.ActiveSheet.Columns(e.Column).CellType) Is FarPoint.Win.Spread.CellType.CheckBoxCellType Then
                SPR_CheckAll(Vs2, e.Column)
            End If
        End If
    End Sub

    Private Sub PFP85010_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width > 20 Then
            ptc_1.ItemSize = New Size((Me.Width - 20) / 2, 30)
        End If
    End Sub

    Private Sub lbl_groupname_1_Click(sender As Object, e As EventArgs) Handles lbl_groupname_1.Click
        If cmb_GROUP.Text.Length < 3 Then Exit Sub
        If IsNumeric(cmb_GROUP.Text.Substring(1, 3)) = False Then Exit Sub

        Call ISUD7420A.Link_ISUD7420A(3, cmb_GROUP.Text.Substring(0, 3))
    End Sub

End Class