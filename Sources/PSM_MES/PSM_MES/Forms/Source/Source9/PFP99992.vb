Public Class PFP99992
#Region "Variable"
    Private t_SPACE, SANO As String
    Private Job_Start As Boolean
    Private W7411 As T7411_AREA
    Private W9992 As T9992_AREA
    Private W9993 As T9993_AREA
    Private W9994 As T9994_AREA
    Private W9996 As T9996_AREA
    Private W9995 As New T9995_AREA

    Private Dsu01 As Long
    Private a7411() As T7411_AREA
    Private a9992() As T9992_AREA
    Private L9996 As T9996_AREA

    Dim tabcheck As Boolean = False
#End Region

#Region "Form_Load"
    Private strSite As String = "001"
    Private Sub PFP99992_Load(sender As Object, e As EventArgs) Handles Me.Load


        W9992 = D9992
        W9993 = D9993
        W9994 = D9994
        W7411 = D7411

        lab_SITE.Data = "CHANG SHUEN"
        lab_SITE.Code = "001"
        lab_SITE.Tag = "001"
    End Sub

#End Region

#Region "DATA_SEARCH"
    Private Function GROUP_DISPLAY() As Boolean
        GROUP_DISPLAY = False

        Dim SQL As String
        Dim i As Integer
        Try

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
        Catch ex As Exception
            MsgBoxP("ERROR IN DATA_SEARCH_01")
        End Try
    End Function
    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        Try
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
                Call SPR_PRO_NEW(Vs1, DS1, "USP_PFP99992_SEARCH_VS1", "Vs1")

                Vs1.Enabled = True
                Vs1.ActiveSheet.RowCount = 0
                Exit Function
            End If

            Call SPR_PRO_NEW(Vs1, DS1, "USP_PFP99992_SEARCH_VS1", "Vs1")

            Vs1.Enabled = True

            DATA_SEARCH_VS1 = True
        Catch ex As Exception
            MsgBoxP("ERROR IN DATA_SEARCH_01")
        End Try
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

            'Call STORE_MOVE(Me, DS1)

            lab_SITE.Data = GetDsData(DS1, 0, "NameSite")
            lab_SITE.Code = GetDsData(DS1, 0, "NameCode")
            lab_SITE.Tag = GetDsData(DS1, 0, "NameCode")

            txt_IDNO.Data = GetDsData(DS1, 0, "IDNO")
            txt_IDNO.Code = GetDsData(DS1, 0, "IDNO")
            txt_IDNO.Tag = GetDsData(DS1, 0, "IDNO")

            txt_Name.Data = GetDsData(DS1, 0, "Name")
            txt_NameDepartment.Data = GetDsData(DS1, 0, "NameDepartment")

            txt_ID01.Data = GetDsData(DS1, 0, "IDNAME")
            txt_PW01.Data = GetDsData(DS1, 0, "PW")

            If GetDsData(DS1, 0, "GROUP") <> "" Then
                LAB_GROUP01.Data = GetDsData(DS1, 0, "GROUP") & "    " & GetDsData(DS1, 0, "GROUPNAME")
                LAB_GROUP01.Code = GetDsData(DS1, 0, "GROUP")

                cmb_GROUP.Text = GetDsData(DS1, 0, "GROUP") & "    " & GetDsData(DS1, 0, "GROUPNAME")
            Else
                LAB_GROUP01.Data = ""
                LAB_GROUP01.Code = ""
            End If

            chk_Customer.Checked = False
            If GetDsData(DS1, 0, "CUSTOMER_CHK") = "1" Then chk_Customer.Checked = True
            If GetDsData(DS1, 0, "CheckSite") = "1" Then chk_CheckSite.Checked = True

            txt_PW02.Data = GetDsData(DS1, 0, "GROUPPW")

            If GetDsData(DS1, 0, "GROUP_ERO") = "001" Then chk_GROUP_ERO.Checked = True Else chk_GROUP_ERO.Checked = False

            DATA_SEARCH_01 = True
        Catch ex As Exception
            MsgBoxP("ERROR IN DATA_SEARCH_01")
        End Try

    End Function
    Private Function DATA_SEARCH_VS2(valSITE As String, valGROUP As String) As Boolean
        DATA_SEARCH_VS2 = False

        Try
            Me.Cursor = Cursors.WaitCursor
            TableLayoutPanel1.Enabled = False

            Vs2.Enabled = False

            DS1 = PrcDS("USP_ISUD9993_SEARCH_VS1_NEW", cn, valSITE, valGROUP)

            If GetDsRc(DS1) = 0 Then

                DS1 = PrcDS("USP_ISUD9993_SEARCH_VS1_NEW", cn, valSITE, "000")
                If GetDsRc(DS1) = 0 Then
                    Call SPR_PRO_NEW(Vs2, DS1, "USP_ISUD9993_SEARCH_VS1_NEW", "vS3")
                    Vs2.ActiveSheet.RowCount = 1
                    Vs2.Enabled = True
                    Exit Function
                End If
            End If

            Call SPR_PRO_NEW(Vs2, DS1, "USP_ISUD9993_SEARCH_VS1_NEW", "Vs2")

            Dim i As Integer

            For i = 0 To Vs2.ActiveSheet.RowCount - 1
                If Trim$(getData(Vs2, getColumIndex(Vs2, "ProgramName"), i)) <> "" Then
                    If Mid(Trim$(getData(Vs2, getColumIndex(Vs2, "PROG"), i)), 1, 1) = "M" Then Call SPR_BACKCOLOR_SE(Vs2, cSprSealNo, getColumIndex(Vs2, "PCHK"), Vs2.ActiveSheet.ColumnCount - 1, i)
                    If Mid(Trim$(getData(Vs2, getColumIndex(Vs2, "PROG"), i)), 1, 1) = "N" Then Call SPR_BACKCOLOR_SE(Vs2, cSprProduction, getColumIndex(Vs2, "PCHK"), Vs2.ActiveSheet.ColumnCount - 1, i)
                End If
            Next

            Vs2.Enabled = True
            Me.Cursor = Cursors.Default
            TableLayoutPanel1.Enabled = True

            DATA_SEARCH_VS2 = True

        Catch ex As Exception
            MsgBoxP("ERROR IN DATA_SEARCH_VS2")
        Finally
            Vs2.Enabled = True
            Me.Cursor = Cursors.Default
            TableLayoutPanel1.Enabled = True
        End Try

    End Function
    Private Function DATA_SEARCH_VS3() As Boolean
        DATA_SEARCH_VS3 = False
        Try

            vS3.Enabled = False
            Me.Cursor = Cursors.WaitCursor

            DS1 = PrcDS("USP_PFP99992_SEARCH_VS3", cn, lab_SITE.Code, txt_IDNO.Code)

            If GetDsRc(DS1) = 0 Then
                Call SPR_PRO_NEW(vS3, DS1, "USP_PFP99992_SEARCH_VS3", "vS3")
                vS3.ActiveSheet.RowCount = 1
                vS3.Enabled = True
                Exit Function
            End If

            Call SPR_PRO_NEW(vS3, DS1, "USP_PFP99992_SEARCH_VS3", "vS3")

            vS3.Enabled = True
            Me.Cursor = Cursors.Default

            DATA_SEARCH_VS3 = True
            vS3.InsChk = True
        Catch ex As Exception
            MsgBoxP("ERROR IN DATA_SEARCH_VS3")
        Finally
            vS3.Enabled = True
            Me.Cursor = Cursors.Default
        End Try

    End Function



    Public Function ListPW_Get(Value As String) As Integer
        ListPW_Get = 0

        Value = Value.ToUpper
        Try
            Return ListPW.FindAll(Function(p) p.Name = Value)(0).RowID
        Catch ex As Exception
            MsgBoxP("ERROR IN ListPW_Get")
        End Try
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
            SQL = SQL & " WHERE K9992_SITE = '" & strSite & "' "
            SQL = SQL & "   AND K9992_SANO = '" & txt_IDNO.Text.Trim & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            txt_ID01.Data = ""
            txt_PW01.Data = ""

            LAB_GROUP01.Text = ""
            LAB_GROUP01.Code = ""

            txt_PW02.Text = ""

            MsgBoxP("Delete Successfully!", vbInformation)

        Catch ex As Exception
            MsgBoxP("ERROR IN cmdDEL0_Click")
        End Try

    End Sub
    Private Sub cmd_Save_Click(sender As Object, e As EventArgs) Handles cmd_Save.Click
        Try
            If txt_IDNO.Text.Trim = "" Then Exit Sub

            If READ_PFK9992(strSite, txt_IDNO.Data) = True Then
                W9992 = D9992

                W9992.ID = Trim$(txt_ID01.Data)
                W9992.PW = Trim$(txt_PW01.Data)
                W9992.GROUP = Trim$(LAB_GROUP01.Code)
                W9992.GROUPPW = Trim$(txt_PW02.Data)

                If LAB_GROUP01.Code = "" Then
                    W9992.GROUP = Mid(cmb_GROUP.Text, 1, 3)
                Else
                    If LAB_GROUP01.Code <> Mid(cmb_GROUP.Text, 1, 3) Then
                        Dim str As String = MsgBoxP("Do you want to Update ?", vbYesNo)
                        If str = vbYes Then
                            W9992.GROUP = Mid(cmb_GROUP.Text, 1, 3)
                        Else
                            W9992.GROUP = LAB_GROUP01.Code
                        End If

                    End If
                End If

                If chk_GROUP_ERO.Checked = True Then
                    W9992.GROUP_ERO = "001"
                Else
                    W9992.GROUP_ERO = ""
                End If

                If chk_Customer.Checked = True Then
                    W9992.CUSTOMER_CHK = "1"
                Else
                    W9992.CUSTOMER_CHK = "2"
                End If

                If chk_CheckSite.Checked = True Then
                    W9992.CHECKSITE = "1"
                Else
                    W9992.CHECKSITE = "2"
                End If

                Call REWRITE_PFK9992(W9992)
            Else

                W9992.SITE = Trim$(strSite)
                W9992.SANO = Trim$(txt_IDNO.Data)
                W9992.ID = Trim$(txt_ID01.Data)
                W9992.PW = Trim$(txt_PW01.Data)
                W9992.GROUP = Trim$(LAB_GROUP01.Code)
                W9992.GROUPPW = Trim$(txt_PW02.Data)
                W9992.GROUP = Mid(cmb_GROUP.Text, 1, 3)

                If chk_GROUP_ERO.Checked = True Then
                    W9992.GROUP_ERO = "001"
                Else
                    W9992.GROUP_ERO = ""
                End If

                If chk_Customer.Checked = True Then
                    W9992.CUSTOMER_CHK = "1"
                Else
                    W9992.CUSTOMER_CHK = "2"
                End If

                If chk_CheckSite.Checked = True Then
                    W9992.CHECKSITE = "1"
                Else
                    W9992.CHECKSITE = "2"
                End If

                WRITE_PFK9992(W9992)
            End If

            Dim i As Integer
            For i = 0 To vS3.ActiveSheet.RowCount - 1
                If Trim(getData(vS3, getColumIndex(vS3, "CustomerCode"), i)) = "" Then GoTo skip1

                If K9996_MOVE(vS3, i, W9996, lab_SITE.Code, txt_IDNO.Code, getData(vS3, getColumIndex(vS3, "KEY_SEQ"), i)) = True Then
                    W9996.SEQ = getData(vS3, getColumIndex(vS3, "KEY_SEQ"), i)

                    Call REWRITE_PFK9996(W9996)
                Else
                    Call KEY_COUNT_K9996()
                    W9996.SITE = lab_SITE.Code
                    W9996.SANO = txt_IDNO.Code
                    W9996.SEQ = L9996.SEQ
                    Call WRITE_PFK9996(W9996)
                End If
skip1:
            Next

            MsgBoxP("Update Successfully!", vbInformation)

        Catch ex As Exception
            MsgBoxP("ERROR IN cmd_Save_Click")
        End Try
    End Sub

    Private Sub KEY_COUNT_K9996()
        Try

            SQL = "SELECT MAX(K9996_SEQ) AS MAX_MCODE FROM PFK9996 "
            SQL = SQL & " WHERE K9996_SITE = '" & lab_SITE.Code & "' "
            SQL = SQL & "   AND K9996_SANO = '" & txt_IDNO.Code & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W9996.SEQ = 1
            Else
                W9996.SEQ = CIntp(rd!MAX_MCODE + 1)
            End If

            rd.Close()

            L9996.SEQ = W9996.SEQ

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT_K9996")
        End Try
    End Sub

    Private Sub cmb_GROUP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_GROUP.SelectedIndexChanged
        If cmb_GROUP.Items.Count = 0 Then Exit Sub

        Dim GROUPNAME As String

        Try
            Me.Enabled = False
            GROUPNAME = Mid(cmb_GROUP.Text, 1, 3)

            Call DATA_SEARCH_VS2(strSite, GROUPNAME)

        Catch ex As Exception
            MsgBoxP("ERROR IN cmb_GROUP")
        Finally
            Me.Enabled = True
        End Try
    End Sub

    Private Sub txt_SANO_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_SANO.KeyDown
        If e.KeyValue = Keys.Enter Then
        End If
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        If DATA_SEARCH_VS1() = True Then Exit Sub
    End Sub

    Private Sub ptc_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ptc_1.SelectedIndexChanged
        If tabcheck = True Then ptc_1.SelectedIndex = 1 Else ptc_1.SelectedIndex = 0
    End Sub

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

        Try
            ptc_1.SelectedIndex = 1

            Me.Enabled = False
            Me.Cursor = Cursors.WaitCursor


            If GROUP_DISPLAY() = True Then
                tabcheck = True

                Dim str As String
                Dim j As Integer
                Dim i As Integer
                Dim m As Integer

                Vs1.ActiveSheet.RowCount = 0
                Vs2.ActiveSheet.RowCount = 0

                Dim bb As New ToolStripMenuItem

                Dim Children As New List(Of ToolStripMenuItem)
                Children = MdiMenu.MenuStrip1.FindAllToolStripMenuItem()

                str = "000"

                SQL = "DELETE  FROM PFK9993"
                SQL = SQL + " WHERE K9993_SITE = '" + strSite + "'"
                SQL = SQL + " AND K9993_GROUP= '" + str + "'"
                cmd = New SqlClient.SqlCommand(SQL, cn)
                cmd.ExecuteNonQuery()

                SQL = "DELETE  FROM PFK9994"
                SQL = SQL + " WHERE K9994_SITE = '" + strSite + "'"
                SQL = SQL + " AND K9994_GROUP= '" + str + "'"
                cmd = New SqlClient.SqlCommand(SQL, cn)
                cmd.ExecuteNonQuery()


                For i = 0 To Children.Count - 1
                    If Children(i).Name <> "" Then
                        Vs2.ActiveSheet.RowCount += 1
                        Vs2.Sheets(0).Cells(m, 1).Value = Children(i).Text
                        Vs2.Sheets(0).Cells(m, 2).Value = Children(i).Name
                        Vs2.Sheets(0).Cells(m, 1).ForeColor = Color.Red
                        Vs2.Sheets(0).Cells(m, 1).Font = New Font("Tahoma", 9, FontStyle.Bold)
                        bb = Children(i)

                        m = m + 1

                        If READ_PFK9993(strSite, "000", Children(i).Text) = False Then
                            W9993.SITE = strSite
                            W9993.GROUP = str
                            W9993.PROG = Children(i).Name

                            W9993.CHK01 = "2"
                            W9993.CHK02 = "2"
                            W9993.CHK03 = "2"
                            W9993.CHK04 = "2"
                            W9993.CHK05 = "2"

                            WRITE_PFK9993(W9993)

                            W9994.SITE = strSite
                            W9994.GROUP = str
                            W9994.PROG = Children(i).Name

                            W9994.PROGRAMNAME = Children(i).Text
                            W9994.PROGRAMNAME1 = Children(i).Text
                            W9994.PROGRAMNAME2 = Children(i).Text

                            W9994.PCHK = "2"
                            W9994.AFTERPROG = m

                            WRITE_PFK9994(W9994)
                        Else
                            W9993.SITE = strSite
                            W9993.GROUP = str
                            W9993.PROG = Children(i).Name

                            W9993.CHK01 = "2"
                            W9993.CHK02 = "2"
                            W9993.CHK03 = "2"
                            W9993.CHK04 = "2"
                            W9993.CHK05 = "2"

                            REWRITE_PFK9993(W9993)

                            W9994.SITE = strSite
                            W9994.GROUP = str
                            W9994.PROG = Children(i).Name

                            W9994.PROGRAMNAME = Children(i).Text
                            W9994.PROGRAMNAME1 = Children(i).Text
                            W9994.PROGRAMNAME2 = Children(i).Text

                            W9994.PCHK = "2"
                            W9994.AFTERPROG = m

                            REWRITE_PFK9994(W9994)

                        End If
                    End If
                Next

                Children.Clear()

                Call DATA_SEARCH_VS2(strSite, "000")
            Else
                Exit Sub
            End If



        Catch ex As Exception
            MsgBoxP("ERROR IN cmdJOB_dyw")

        Finally
            Me.Enabled = True
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub FpSpread1_CellClick(sender As Object, e As FarPoint.Win.Spread.CellClickEventArgs)
        If e.Row < 0 Then Exit Sub
        SANO = Vs1.Sheets(0).Cells(e.Row, 0).Value
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If e.ColumnHeader = True Then Exit Sub
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If DATA_SEARCH_01() = True Then
            Call DATA_SEARCH_VS3()
        Else
            Me.Form_ClearData()
        End If
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
            SQL = SQL + " WHERE K9993_SITE = '" + strSite + "'"
            SQL = SQL + " AND K9993_GROUP= '" + str + "'"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            SQL = "DELETE  FROM PFK9994"
            SQL = SQL + " WHERE K9994_SITE = '" + strSite + "'"
            SQL = SQL + " AND K9994_GROUP= '" + str + "'"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            For i = 0 To Vs2.ActiveSheet.RowCount - 1
                If getDataM(Vs2, getColumIndex(Vs2, "PCHK"), i) = "1" Then

                    W9993.GROUP = str
                    W9993.SITE = strSite
                    W9993.PROG = getData(Vs2, getColumIndex(Vs2, "PROG"), i)

                    W9993.CHK01 = getDataM(Vs2, getColumIndex(Vs2, "PwdCHK01"), i)
                    W9993.CHK02 = getDataM(Vs2, getColumIndex(Vs2, "PwdCHK02"), i)
                    W9993.CHK03 = getDataM(Vs2, getColumIndex(Vs2, "PwdCHK03"), i)
                    W9993.CHK04 = getDataM(Vs2, getColumIndex(Vs2, "PwdCHK04"), i)
                    W9993.CHK05 = getDataM(Vs2, getColumIndex(Vs2, "PwdCHK05"), i)

                    WRITE_PFK9993(W9993)

                    W9994.GROUP = str
                    W9994.AFTERPROG = str
                    W9994.SITE = strSite
                    W9994.PROG = getData(Vs2, getColumIndex(Vs2, "PROG"), i)
                    W9994.PROGRAMNAME = getData(Vs2, getColumIndex(Vs2, "PROGRAMNAME"), i)
                    W9994.PROGRAMNAME1 = getData(Vs2, getColumIndex(Vs2, "PROGRAMNAME1"), i)
                    W9994.PROGRAMNAME2 = getData(Vs2, getColumIndex(Vs2, "PROGRAMNAME2"), i)

                    W9994.PCHK = getDataM(Vs2, getColumIndex(Vs2, "PCHK"), i)

                    WRITE_PFK9994(W9994)

                End If
            Next

            SQL = "DELETE  FROM PFK9995"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            For i = 0 To Vs2.ActiveSheet.RowCount - 1
                If getData(Vs2, getColumIndex(Vs2, "PROG"), i) <> "" Then
                    W9995.PROG = getData(Vs2, getColumIndex(Vs2, "PROG"), i)
                    W9995.NAME = getData(Vs2, getColumIndex(Vs2, "PROGRAMNAME"), i)
                    W9995.NAME1 = getData(Vs2, getColumIndex(Vs2, "PROGRAMNAME1"), i)
                    W9995.NAME2 = getData(Vs2, getColumIndex(Vs2, "PROGRAMNAME2"), i)

                    W9995.SEQ = (i + 1).ToString("0000")
                    W9995.REMARK = ""

                    WRITE_PFK9995(W9995)
                End If
            Next

            MsgBoxP("Update Group Successfully!", vbInformation)

        Catch ex As Exception
            MsgBoxP("Error! Please Contact ERP Team")
        End Try
    End Sub

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
#End Region


End Class