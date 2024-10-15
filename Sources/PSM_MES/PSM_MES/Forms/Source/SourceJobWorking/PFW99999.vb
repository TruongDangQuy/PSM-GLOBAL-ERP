Public Class PFW99999

#Region "Variable"
    Private t_SPACE, SANO As String
    Private Job_Start As Boolean

    Private W7411 As T7411_AREA
    Private W9982 As T9982_AREA
    Private W9981 As T9981_AREA
    Private W9985 As T9985_AREA


    Private W9992 As T9992_AREA
    Private W9996 As T9996_AREA

    Private Dsu01 As Long
    Private a7411() As T7411_AREA
    Private a9982() As T9982_AREA
    Private L9996 As T9996_AREA

    Dim tabcheck As Boolean = False
#End Region

#Region "Form_Load"
    Private Sub PFW99999_Load(sender As Object, e As EventArgs) Handles Me.Load
        W9982 = D9982
        W9981 = D9981
        W9985 = D9985
        W7411 = D7411

        lab_SITE.Data = "Chang Shuen"
        lab_SITE.Code = "001"
        lab_SITE.Tag = "001"
    End Sub

#End Region

#Region "DATA_SEARCH"

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        Try
            Dim RS01 As DataRow = Nothing

            Vs1.Enabled = False

            DATA_SEARCH_VS1 = False
            DS1 = PrcDS("USP_PFW99999_SEARCH_VS1", cn, txt_SANO.Data, _
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
                Call SPR_PRO_NEW(Vs1, DS1, "USP_PFW99999_SEARCH_VS1", "Vs1")

                Vs1.Enabled = True
                Vs1.ActiveSheet.RowCount = 0
                Exit Function
            End If

            Call SPR_PRO_NEW(Vs1, DS1, "USP_PFW99999_SEARCH_VS1", "Vs1")

            Vs1.Enabled = True

            DATA_SEARCH_VS1 = True
        Catch ex As Exception
            MsgBoxP("ERROR IN DATA_SEARCH_01")
        End Try
    End Function
    Private Function DATA_SEARCH_VS1_LINE_DISP() As Boolean
        DATA_SEARCH_VS1_LINE_DISP = False

        Try
            Dim RS01 As DataRow = Nothing

            DATA_SEARCH_VS1_LINE_DISP = False

            DS1 = PrcDS("USP_PFW99999_SEARCH_VS1_LINE_DISPLAY", cn, getData(Vs1, getColumIndex(Vs1, "IDNO"), Vs1.ActiveSheet.ActiveRowIndex), _
                                                        Const_Site, _
                                                        Const_Nationality, _
                                                        Const_Department, _
                                                        Const_OnePosition, _
                                                        Const_Position, _
                                                        Const_Incharge, _
                                                        "1", _
                                                        "1")
            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If

            Call setData(Vs1, getColumIndex(Vs1, "ID"), Vs1.ActiveSheet.ActiveRowIndex, GetDsData(DS1, 0, "ID"))

            DATA_SEARCH_VS1_LINE_DISP = True
        Catch ex As Exception
            MsgBoxP("ERROR IN DATA_SEARCH_01")
        End Try
    End Function

    Private Function DATA_SEARCH_01() As Boolean
        DATA_SEARCH_01 = False

        Try
            DS1 = PrcDS("USP_PFW99999_SEARCH_VS1_LINE", cn, getData(Vs1, getColumIndex(Vs1, "IDNO"), Vs1.ActiveSheet.ActiveRowIndex), _
                                                            Const_Site, _
                                                            Const_Nationality, _
                                                            Const_Department, _
                                                            Const_OnePosition, _
                                                            Const_Position, _
                                                            Const_Incharge)
            If GetDsRc(DS1) = 0 Then
                Me.Dispose()
                isudCHK = False

                Exit Function
            End If


            lab_SITE.Data = GetDsData(DS1, 0, "NameSite")
            lab_SITE.Code = GetDsData(DS1, 0, "NameCode")
            lab_SITE.Tag = GetDsData(DS1, 0, "NameCode")

            txt_IDNO.Data = GetDsData(DS1, 0, "IDNO")
            txt_IDNO.Code = GetDsData(DS1, 0, "IDNO")
            txt_IDNO.Tag = GetDsData(DS1, 0, "IDNO")

            txt_Name.Data = GetDsData(DS1, 0, "Name")
            txt_NameDepartment.Data = GetDsData(DS1, 0, "NameDepartment")
            txt_NamePosition.Data = GetDsData(DS1, 0, "NamePosition")
            txt_NameOnePosition.Data = GetDsData(DS1, 0, "NameOnePosition")
            txt_NameInCharge.Data = GetDsData(DS1, 0, "NameInCharge")
            txt_ID01.Data = GetDsData(DS1, 0, "IDNAME")
            txt_PW01.Data = GetDsData(DS1, 0, "PW")


            chk_Customer.Checked = False
            chk_GROUP_BASIC.Checked = False

            If Trim$(GetDsData(DS1, 0, "GROUP_BASIC")) = "1" Then chk_GROUP_BASIC.Checked = True
            If Trim$(GetDsData(DS1, 0, "CUSTOMER_CHK")) = "1" Then chk_Customer.Checked = True

            If Trim$(GetDsData(DS1, 0, "GROUP_ERO")) = "001" Then chk_GROUP_ERO.Checked = True Else chk_GROUP_ERO.Checked = False

            DATA_SEARCH_01 = True
        Catch ex As Exception
            MsgBoxP("ERROR IN DATA_SEARCH_01")
        End Try

    End Function
    Private Function DATA_SEARCH_Vs20(valSITE As String, valSEL As String, valSANO As String, valCHK1 As String, valCHK2 As String) As Boolean
        DATA_SEARCH_Vs20 = False

        Try
            Me.Cursor = Cursors.WaitCursor
            TableLayoutPanel1.Enabled = False

            VS20.Enabled = False

            DS1 = PrcDS("USP_PFW99999_SEARCH_VS20", cn, valSITE, valSEL, valSANO, valCHK1, valCHK2)

            If GetDsRc(DS1) = 0 Then
                DS1 = PrcDS("USP_PFW99999_SEARCH_VS20", cn, valSITE, valSEL, "00000000", valCHK1, valCHK2)
            End If

            Call SPR_PRO_NEW(VS20, DS1, "USP_PFW99999_SEARCH_VS20", "Vs20")

            Dim i As Integer
            For i = 0 To VS20.ActiveSheet.RowCount - 1
                If Trim$(getData(VS20, getColumIndex(VS20, "ProgramName"), i)) <> "" Then
                    If Mid(Trim$(getData(VS20, getColumIndex(VS20, "PROG"), i)), 1, 1) = "M" Then Call SPR_BACKCOLOR_SE(VS20, cSprSealNo, getColumIndex(VS20, "PCHK"), VS20.ActiveSheet.ColumnCount - 1, i)
                    If Mid(Trim$(getData(VS20, getColumIndex(VS20, "PROG"), i)), 1, 1) = "N" Then Call SPR_BACKCOLOR_SE(VS20, cSprProduction, getColumIndex(VS20, "PCHK"), VS20.ActiveSheet.ColumnCount - 1, i)
                End If
            Next

            VS20.Enabled = True
            Me.Cursor = Cursors.Default
            TableLayoutPanel1.Enabled = True

            DATA_SEARCH_Vs20 = True

        Catch ex As Exception
            MsgBoxP("ERROR IN DATA_SEARCH_Vs20")
        Finally
            VS20.Enabled = True
            Me.Cursor = Cursors.Default
            TableLayoutPanel1.Enabled = True
        End Try

    End Function
    Private Function DATA_SEARCH_VS21(valSITE As String, valSEL As String, valSANO As String, valCHK1 As String, valCHK2 As String) As Boolean
        DATA_SEARCH_VS21 = False

        Try
            Me.Cursor = Cursors.WaitCursor
            TableLayoutPanel1.Enabled = False

            VS21.Enabled = False

            DS1 = PrcDS("USP_PFW99999_SEARCH_VS21", cn, valSITE, valSEL, valSANO, valCHK1, valCHK2)

            If GetDsRc(DS1) = 0 Then
                DS1 = PrcDS("USP_PFW99999_SEARCH_VS21", cn, valSITE, valSEL, "00000000", valCHK1, valCHK2)
            End If

            Call SPR_PRO_NEW(VS21, DS1, "USP_PFW99999_SEARCH_VS21", "VS21")

            Dim i As Integer
            For i = 0 To VS21.ActiveSheet.RowCount - 1
                If Trim$(getData(VS21, getColumIndex(VS21, "ProgramName"), i)) <> "" Then
                    If Mid(Trim$(getData(VS21, getColumIndex(VS21, "PROG"), i)), 1, 1) = "M" Then Call SPR_BACKCOLOR_SE(VS21, cSprSealNo, getColumIndex(VS21, "PCHK"), VS21.ActiveSheet.ColumnCount - 1, i)
                    If Mid(Trim$(getData(VS21, getColumIndex(VS21, "PROG"), i)), 1, 1) = "N" Then Call SPR_BACKCOLOR_SE(VS21, cSprProduction, getColumIndex(VS21, "PCHK"), VS21.ActiveSheet.ColumnCount - 1, i)
                End If
            Next

            VS21.Enabled = True
            Me.Cursor = Cursors.Default
            TableLayoutPanel1.Enabled = True

            DATA_SEARCH_VS21 = True

        Catch ex As Exception
            MsgBoxP("ERROR IN DATA_SEARCH_VS21")
        Finally
            VS21.Enabled = True
            Me.Cursor = Cursors.Default
            TableLayoutPanel1.Enabled = True
        End Try

    End Function

    Private Function DATA_SEARCH_VS21_K9981(valSITE As String, valSEL As String) As Boolean
        DATA_SEARCH_VS21_K9981 = False

        Try
            Me.Cursor = Cursors.WaitCursor
            TableLayoutPanel1.Enabled = False

            VS21.Enabled = False

            DS1 = PrcDS("USP_PFW99999_SEARCH_VS21_K9981", cn, valSITE, valSEL)

            If GetDsRc(DS1) = 0 Then
                VS21.ActiveSheet.RowCount = 0

                VS21.Enabled = True
                Me.Cursor = Cursors.Default
                TableLayoutPanel1.Enabled = True

                Exit Function
            End If

            Call SPR_PRO_NEW(VS21, DS1, "USP_PFW99999_SEARCH_VS21_K9981", "VS21")

            VS21.Enabled = True

            Me.Cursor = Cursors.Default
            TableLayoutPanel1.Enabled = True

            DATA_SEARCH_VS21_K9981 = True
        Catch ex As Exception
            MsgBoxP("ERROR IN DATA_SEARCH_VS21_K9981")
        Finally
            VS21.Enabled = True
            Me.Cursor = Cursors.Default
            TableLayoutPanel1.Enabled = True
        End Try

    End Function


    Private Function DATA_SEARCH_VS3() As Boolean
        DATA_SEARCH_VS3 = False
        Try

            vS3.Enabled = False
            Me.Cursor = Cursors.WaitCursor

            DS1 = PrcDS("USP_PFW99999_SEARCH_VS3", cn, lab_SITE.Code, txt_IDNO.Code)

            If GetDsRc(DS1) = 0 Then
                Call SPR_PRO_NEW(vS3, DS1, "USP_PFW99999_SEARCH_VS3", "vS3")
                vS3.ActiveSheet.RowCount = 1
                vS3.Enabled = True
                Exit Function
            End If

            Call SPR_PRO_NEW(vS3, DS1, "USP_PFW99999_SEARCH_VS3", "vS3")

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
#End Region

#Region "DATA_FUNCTION"
    Public Function ListPW_Get(Value As String) As Integer
        ListPW_Get = 0

        Value = Value.ToUpper
        Try
            Return ListPW.FindAll(Function(p) p.Name = Value)(0).RowID
        Catch ex As Exception
            MsgBoxP("ERROR IN ListPW_Get")
        End Try
    End Function
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

    Private Sub DATA_MOVE_PFK9985_VS20()
        Dim i As Integer
        Dim valSEL As String
        Dim valSANO As String

        Dim SQL As String
        Dim cmd As New SqlClient.SqlCommand

        Try
            If txt_IDNO.Code.Trim = "" Then Exit Sub

            valSEL = "1"
            valSANO = txt_IDNO.Code

            'SQL = "DELETE  FROM PFK9985"
            'SQL = SQL + " WHERE K9985_SITE = '" + Pub.SITE + "'"
            'SQL = SQL + " AND K9985_SEL= '" + valSEL + "'"
            'SQL = SQL + " AND K9985_SANO= '" + valSANO + "'"
            'cmd = New SqlClient.SqlCommand(SQL, cn)
            'cmd.ExecuteNonQuery()

            ' Not data delete

            For i = 0 To VS20.ActiveSheet.RowCount - 1
                If getDataM(VS20, getColumIndex(VS20, "PCHK"), i) = "1" Then
                    Call D9985_CLEAR()

                    W9985.SITE = Pub.SITE
                    W9985.SANO = txt_IDNO.Code
                    W9985.SEL = valSEL
                    W9985.PROG = getData(VS20, getColumIndex(VS20, "PROG"), i)

                    Call DELETE_PFK9985(W9985)

                    'W9985.SITE = Pub.SITE
                    'W9985.SANO = txt_IDNO.Code
                    'W9985.SEL = valSEL
                    'W9985.PROG = getData(VS20, getColumIndex(VS20, "PROG"), i)

                    W9985.CHK01 = getDataM(VS20, getColumIndex(VS20, "PwdCHK01"), i)
                    W9985.CHK02 = getDataM(VS20, getColumIndex(VS20, "PwdCHK02"), i)
                    W9985.CHK03 = getDataM(VS20, getColumIndex(VS20, "PwdCHK03"), i)
                    W9985.CHK04 = getDataM(VS20, getColumIndex(VS20, "PwdCHK04"), i)
                    W9985.CHK05 = getDataM(VS20, getColumIndex(VS20, "PwdCHK05"), i)

                    W9985.PCHK = getDataM(VS20, getColumIndex(VS20, "PCHK"), i)

                    WRITE_PFK9985(W9985)
                Else
                    W9985.SITE = Pub.SITE
                    W9985.SANO = txt_IDNO.Code
                    W9985.SEL = valSEL
                    W9985.PROG = getData(VS20, getColumIndex(VS20, "PROG"), i)

                    Call DELETE_PFK9985(W9985)
                End If

            Next

        Catch ex As Exception
            MsgBoxP("Error! DATA_MOVE_PFK9985_VS20")
        End Try
    End Sub

    Private Sub DATA_MOVE_PFK9985_VS21()
        Dim i As Integer
        Dim valSEL As String
        Dim valSANO As String

        Dim SQL As String
        Dim cmd As New SqlClient.SqlCommand

        Try
            If txt_IDNO.Code.Trim = "" Then Exit Sub

            valSEL = "2"
            valSANO = txt_IDNO.Code

            'SQL = "DELETE  FROM PFK9985"
            'SQL = SQL + " WHERE K9985_SITE = '" + Pub.SITE + "'"
            'SQL = SQL + " AND K9985_SEL= '" + valSEL + "'"
            'SQL = SQL + " AND K9985_SANO= '" + valSANO + "'"
            'cmd = New SqlClient.SqlCommand(SQL, cn)
            'cmd.ExecuteNonQuery()

            For i = 0 To VS21.ActiveSheet.RowCount - 1
                If getDataM(VS21, getColumIndex(VS21, "PwdCHK01"), i) = "1" Or
                    getDataM(VS21, getColumIndex(VS21, "PwdCHK02"), i) = "1" Or
                    getDataM(VS21, getColumIndex(VS21, "PwdCHK03"), i) = "1" Or
                    getDataM(VS21, getColumIndex(VS21, "PwdCHK04"), i) = "1" Or
                    getDataM(VS21, getColumIndex(VS21, "PwdCHK05"), i) = "1" Then

                    Call D9985_CLEAR()

                    W9985.SITE = Pub.SITE
                    W9985.SANO = txt_IDNO.Code
                    W9985.SEL = valSEL
                    W9985.PROG = getData(VS21, getColumIndex(VS21, "PROG"), i)

                    Call DELETE_PFK9985(W9985)

                    W9985.CHK01 = getDataM(VS21, getColumIndex(VS21, "PwdCHK01"), i)
                    W9985.CHK02 = getDataM(VS21, getColumIndex(VS21, "PwdCHK02"), i)
                    W9985.CHK03 = getDataM(VS21, getColumIndex(VS21, "PwdCHK03"), i)
                    W9985.CHK04 = getDataM(VS21, getColumIndex(VS21, "PwdCHK04"), i)
                    W9985.CHK05 = getDataM(VS21, getColumIndex(VS21, "PwdCHK05"), i)

                    W9985.PCHK = "2"
                    If W9985.CHK01 = "1" Or W9985.CHK02 = "1" Or W9985.CHK03 = "1" Or W9985.CHK04 = "1" Or W9985.CHK01 = "1" Then W9985.PCHK = "1"

                    WRITE_PFK9985(W9985)
                Else
                    W9985.SITE = Pub.SITE
                    W9985.SANO = txt_IDNO.Code
                    W9985.SEL = valSEL
                    W9985.PROG = getData(VS21, getColumIndex(VS21, "PROG"), i)

                    Call DELETE_PFK9985(W9985)
                End If
            Next

        Catch ex As Exception
            MsgBoxP("Error! DATA_MOVE_PFK9985_VS21")
        End Try
    End Sub

    Private Sub DATA_MOVE_PFK9985_ALL(valSITE As String, valSEL As String)
        Dim i As Integer

        Dim valSANO As String

        Try
            If txt_SANO_Before.Data = "" Then txt_SANO_Before.Code = ""
            If txt_SANO_Before.Data = "" Then Exit Sub
            If READ_PFK7411(txt_SANO_Before.Code) = False Then
                MsgBoxP("ERROR IN Check the Before IDNO")
                Exit Sub
            End If

            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getDataM(Vs1, getColumIndex(Vs1, "SCHK"), i) = "1" Then

                    valSANO = getData(Vs1, getColumIndex(Vs1, "Key_IDNO"), i)

                    Call PrcExeNoError("USP_PFW99999_INSERT_PFK9985_Copy", cn, valSITE, valSEL, txt_SANO_Before.Code, valSANO)

                End If
            Next

        Catch ex As Exception
            MsgBoxP("Error! DATA_MOVE_PFK9985_ALL")
        End Try
    End Sub
#End Region

#Region "Event"
    Private Sub cmdJOB_Click(sender As Object, e As EventArgs) Handles cmdJOB_dyw.Click
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

            Dim str As String = ""
            Dim j As Integer = "0"
            Dim i As Integer = "0"
            Dim m As Integer = "0"

            Vs1.ActiveSheet.RowCount = 0
            VS20.ActiveSheet.RowCount = 0
            VS21.ActiveSheet.RowCount = 0

            Dim bb As New ToolStripMenuItem

            Dim Children As New List(Of ToolStripMenuItem)
            Children = MdiMenu.MenuStrip1.FindAllToolStripMenuItem()

            str = "1"  '' '1', PFP  , '2',ISUD

            SQL = "DELETE  FROM PFK9982"
            SQL = SQL + " WHERE K9982_SITE = '" + Pub.SITE + "'"
            SQL = SQL + "   AND K9982_SEL  = '" + str + "'"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            SQL = "DELETE  FROM PFK9981"
            SQL = SQL + " WHERE K9981_SITE = '" + Pub.SITE + "'"
            SQL = SQL + "   AND K9981_SEL  = '" + str + "'"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()


            For i = 0 To Children.Count - 1
                If Children(i).Name <> "" Then
                    VS20.ActiveSheet.RowCount += 1
                    VS20.Sheets(0).Cells(m, 1).Value = Children(i).Text
                    VS20.Sheets(0).Cells(m, 2).Value = Children(i).Name
                    VS20.Sheets(0).Cells(m, 1).ForeColor = Color.Red
                    VS20.Sheets(0).Cells(m, 1).Font = New Font("Tahoma", 9, FontStyle.Bold)
                    bb = Children(i)

                    m = m + 1

                    Call D9982_CLEAR() : W9982 = D9982

                    W9982.SITE = Pub.SITE
                    W9982.SEL = str
                    W9982.SEQ = Format(m, "0000")
                    W9982.PROG = Children(i).Name

                    WRITE_PFK9982(W9982)
                    '=====================================================================================

                    If READ_PFK9981(Pub.SITE, str, W9982.PROG) = True Then
                        W9981 = D9981

                        REWRITE_PFK9981(W9981)
                    Else
                        W9981.SITE = W9982.SITE
                        W9981.SEL = W9982.SEL
                        W9981.PROG = W9982.PROG

                        W9981.NAME = Children(i).Text
                        W9981.NAME1 = Children(i).Text
                        W9981.NAME2 = Children(i).Text

                        WRITE_PFK9981(W9981)
                    End If

                End If
            Next

            Children.Clear()
            Call DATA_SEARCH_Vs20(Pub.SITE, str, "00000000", "1", "1")

            '' Call PrcExeNoError("USP_PFW99999_DELETE_PFK9985", cn, Pub.SITE, "1")
            ''==================================================================================================================
            ''------------------------------------------------------------------------------------------------------------------
            ''------------------------------------------------------------------------------------------------------------------
            str = "2"  '' '1', PFP  , '2',ISUD

            If DATA_SEARCH_VS21_K9981(Pub.SITE, str) = True Then
                m = 0

                SQL = "DELETE  FROM PFK9982"
                SQL = SQL + " WHERE K9982_SITE = '" + Pub.SITE + "'"
                SQL = SQL + "   AND K9982_SEL  = '" + str + "'"
                cmd = New SqlClient.SqlCommand(SQL, cn)
                cmd.ExecuteNonQuery()

                For i = 0 To VS21.ActiveSheet.RowCount - 1
                    If getData(VS21, getColumIndex(VS21, "PROG"), i) <> "" Then
                        m = m + 1
                        Call D9982_CLEAR() : W9982 = D9982

                        W9982.SITE = Pub.SITE
                        W9982.SEL = str
                        W9982.SEQ = Format(m, "0000")
                        W9982.PROG = getData(VS21, getColumIndex(VS21, "PROG"), i)

                        WRITE_PFK9982(W9982)
                    End If
                    '=====================================================================================
                Next

                Call DATA_SEARCH_VS21(Pub.SITE, str, "00000000", "1", "1")
            End If

        Catch ex As Exception
            MsgBoxP("ERROR IN cmdJOB_dyw")

        Finally
            Me.Enabled = True
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub cmd_Save_Click(sender As Object, e As EventArgs) Handles cmd_Save.Click
        Try
            If txt_IDNO.Text.Trim = "" Then Exit Sub

            If READ_PFK9992(Pub.SITE, txt_IDNO.Data) = True Then
                W9992 = D9992

                W9992.ID = Trim$(txt_ID01.Data)
                W9992.PW = Trim$(txt_PW01.Data)

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

                If chk_GROUP_BASIC.Checked = True Then
                    W9992.GROUP_BASIC = "1"
                Else
                    W9992.GROUP_BASIC = "2"
                End If

                If READ_PFK9992_IDNO_CHECK(Pub.SITE, txt_IDNO.Data, Trim$(W9992.ID)) = True Then
                    MsgBoxP("User ID Double Check Please!", vbInformation)
                    Setfocus(txt_ID01)
                    Exit Sub
                End If

                Call REWRITE_PFK9992(W9992)
            Else

                W9992.SITE = Trim$(Pub.SITE)
                W9992.SANO = Trim$(txt_IDNO.Data)
                W9992.ID = Trim$(txt_ID01.Data)
                W9992.PW = Trim$(txt_PW01.Data)
                W9992.GROUP = ""
                W9992.GROUPPW = ""
                W9992.GROUP = ""

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

                If chk_GROUP_BASIC.Checked = True Then
                    W9992.GROUP_BASIC = "1"
                Else
                    W9992.GROUP_BASIC = "2"
                End If

                If READ_PFK9992_IDNO_CHECK(Pub.SITE, txt_IDNO.Data, Trim$(W9992.ID)) = True Then
                    MsgBoxP("User ID Double Check Please!", vbInformation)
                    Setfocus(txt_ID01)
                    Exit Sub
                End If

                WRITE_PFK9992(W9992)
            End If
            '============================================================================================
            '   SANO PASSWORD WRITE
            If TabControl1.SelectedIndex = 0 Then Call DATA_MOVE_PFK9985_VS20()
            If TabControl1.SelectedIndex = 1 Then Call DATA_MOVE_PFK9985_VS21()
            '============================================================================================
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

                    W9996.CHK01 = "1"
                    W9996.CHK02 = "1"
                    W9996.CHK03 = "1"
                    W9996.CHK04 = "1"
                    W9996.CHK05 = "1"

                    Call WRITE_PFK9996(W9996)
                End If
skip1:
            Next

            Call DATA_SEARCH_VS1_LINE_DISP()
            '============================================================================================

            MsgBoxP("Update Successfully!", vbInformation)

        Catch ex As Exception
            MsgBoxP("ERROR IN cmd_Save_Click")
        End Try
    End Sub

    Private Sub cmd_Save_Copy_Click(sender As Object, e As EventArgs) Handles cmd_Save_Copy.Click
        Dim i As Integer
        Dim j As Integer
        Dim valSEL As String

        Try
            If txt_SANO_Before.Data = "" Then txt_SANO_Before.Code = ""
            If txt_SANO_After.Data = "" Then txt_SANO_After.Code = ""

            If txt_SANO_Before.Data = "" Then Exit Sub
            If Check_Copy.Checked = True And Check_All_Copy.Checked = True Then
                MsgBoxP("ERROR IN Check Copy")
                Exit Sub
            End If

            Me.Enabled = False
            Me.Cursor = Cursors.WaitCursor

            ''--- 1.IDNO
            If Check_Copy.Checked = True Then
                If txt_SANO_After.Data = "" Then Exit Sub

                If READ_PFK7411(txt_SANO_Before.Code) = True And READ_PFK7411(txt_SANO_After.Code) = True Then

                    If TabControl1.SelectedIndex = 0 Then valSEL = "1"
                    If TabControl1.SelectedIndex = 1 Then valSEL = "2"

                    Call PrcExeNoError("USP_PFW99999_INSERT_PFK9985_Copy", cn, Pub.SITE, valSEL, txt_SANO_Before.Code, txt_SANO_After.Code)
                Else
                    MsgBoxP("ERROR IN Before IDNO Data")
                End If
            End If

            ''--- Multi IDNO
            If Check_All_Copy.Checked = True Then
                If TabControl1.SelectedIndex = 0 Then valSEL = "1"
                If TabControl1.SelectedIndex = 1 Then valSEL = "2"

                Call DATA_MOVE_PFK9985_ALL(Pub.SITE, valSEL)
            End If

            MsgBoxP("Update Successfully!", vbInformation)

        Catch ex As Exception
            MsgBoxP("ERROR IN cmd_Save_Copy_Click")
        Finally
            Me.Enabled = True
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmdDEL_Click(sender As Object, e As EventArgs) Handles cmd_del.Click
        Dim valSEL As String
        Dim str As String = MsgBoxP("Do you want to Delete?", vbYesNo)

        Try
            If txt_IDNO.Text.Trim = "" Then Exit Sub

            If str <> vbYes Then Exit Sub

            If TabControl1.SelectedIndex = 0 Then valSEL = "1"
            If TabControl1.SelectedIndex = 1 Then valSEL = "2"

            SQL = " DELETE FROM PFK9992 "
            SQL = SQL & " WHERE K9992_SITE = '" & Pub.SITE & "' "
            SQL = SQL & "   AND K9992_SANO = '" & txt_IDNO.Text.Trim & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            SQL = " DELETE FROM PFK9985 "
            SQL = SQL & " WHERE K9985_SITE = '" & Pub.SITE & "' "
            SQL = SQL & "   AND K9985_SEL = '" & valSEL & "' "
            SQL = SQL & "   AND K9985_SANO = '" & txt_IDNO.Text.Trim & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            SQL = " DELETE FROM PFK9996 "
            SQL = SQL & " WHERE K9996_SITE = '" & Pub.SITE & "' "
            SQL = SQL & "   AND K9996_SANO = '" & txt_IDNO.Text.Trim & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            txt_ID01.Data = ""
            txt_PW01.Data = ""
            txt_SANO_Before.Data = ""
            txt_SANO_Before.Code = ""
            txt_SANO_After.Data = ""
            txt_SANO_After.Code = ""

            MsgBoxP("Delete Successfully!", vbInformation)

        Catch ex As Exception
            MsgBoxP("ERROR IN cmdDEL0_Click")
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

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ID01.KeyPress, txt_PW01.KeyPress
        keypresserp(sender, e)
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If e.ColumnHeader = False Then
            If getColumIndex(Vs1, "SCHK") = e.Column And Check_All_Copy.Checked = True Then
                If getDataM(Vs1, getColumIndex(Vs1, "SCHK"), e.Row) = "1" Then
                    setData(Vs1, getColumIndex(Vs1, "SCHK"), e.Row, "0", , True)
                Else
                    setData(Vs1, getColumIndex(Vs1, "SCHK"), e.Row, "1", , True)
                End If
            Else
                If Check_Copy.Checked = True Then
                    If READ_PFK7411(txt_SANO_Before.Code) = True Then
                        txt_SANO_After.Data = getData(Vs1, getColumIndex(Vs1, "Name"), e.Row)
                        txt_SANO_After.Code = getData(Vs1, getColumIndex(Vs1, "Key_IDNO"), e.Row)

                        If txt_SANO_Before.Data = txt_SANO_After.Data Then
                            txt_SANO_After.Data = ""
                            txt_SANO_After.Code = ""
                        End If
                    End If
                End If
            End If
        Else
            setData(Vs1, getColumIndex(Vs1, "SCHK"), e.Row, "0", , True)
        End If
    End Sub

    Private Sub Vs20_CellClick(sender As Object, e As CellClickEventArgs) Handles VS20.CellClick
        If e.ColumnHeader = False Then
            Select Case e.Column
                Case getColumIndex(VS20, "PCHK")
                    If getDataM(VS20, getColumIndex(VS20, "PCHK"), e.Row) = "1" Then
                        setData(VS20, getColumIndex(VS20, "PCHK"), e.Row, "0", , True)
                    Else
                        setData(VS20, getColumIndex(VS20, "PCHK"), e.Row, "1", , True)
                    End If
            End Select
        End If

    End Sub

    Private Sub Vs21_CellClick(sender As Object, e As CellClickEventArgs) Handles VS21.CellClick
        If e.ColumnHeader = False Then
            Select Case e.Column
                Case getColumIndex(VS21, "PwdCHK01")
                    If getDataM(VS21, getColumIndex(VS21, "PwdCHK01"), e.Row) = "1" Then
                        setData(VS21, getColumIndex(VS21, "PwdCHK01"), e.Row, "0", , True)
                    Else
                        setData(VS21, getColumIndex(VS21, "PwdCHK01"), e.Row, "1", , True)
                    End If
                Case getColumIndex(VS21, "PwdCHK02")
                    If getDataM(VS21, getColumIndex(VS21, "PwdCHK02"), e.Row) = "1" Then
                        setData(VS21, getColumIndex(VS21, "PwdCHK02"), e.Row, "0", , True)
                    Else
                        setData(VS21, getColumIndex(VS21, "PwdCHK02"), e.Row, "1", , True)
                    End If

                Case getColumIndex(VS21, "PwdCHK03")
                    If getDataM(VS21, getColumIndex(VS21, "PwdCHK03"), e.Row) = "1" Then
                        setData(VS21, getColumIndex(VS21, "PwdCHK03"), e.Row, "0", , True)
                    Else
                        setData(VS21, getColumIndex(VS21, "PwdCHK03"), e.Row, "1", , True)
                    End If

                Case getColumIndex(VS21, "PwdCHK04")
                    If getDataM(VS21, getColumIndex(VS21, "PwdCHK04"), e.Row) = "1" Then
                        setData(VS21, getColumIndex(VS21, "PwdCHK04"), e.Row, "0", , True)
                    Else
                        setData(VS21, getColumIndex(VS21, "PwdCHK04"), e.Row, "1", , True)
                    End If

                Case getColumIndex(VS21, "PwdCHK05")
                    If getDataM(VS21, getColumIndex(VS21, "PwdCHK05"), e.Row) = "1" Then
                        setData(VS21, getColumIndex(VS21, "PwdCHK05"), e.Row, "0", , True)
                    Else
                        setData(VS21, getColumIndex(VS21, "PwdCHK05"), e.Row, "1", , True)
                    End If
            End Select
        End If

    End Sub
    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If e.ColumnHeader = True And Check_All_Copy.Checked = True Then
            If TypeOf (Vs1.ActiveSheet.Columns(e.Column).CellType) Is FarPoint.Win.Spread.CellType.CheckBoxCellType Then
                SPR_CheckAll(Vs1, e.Column)
            End If

            Exit Sub
        End If

        If getColumIndex(Vs1, "SCHK") <> Vs1.ActiveSheet.ActiveColumnIndex Then
            If DATA_SEARCH_01() = True Then

                Dim ValCHECK1 As String = "2"
                Dim ValCHECK2 As String = "2"

                If Check01.Checked = True Then ValCHECK1 = "1"
                If Check02.Checked = True Then ValCHECK2 = "1"

                'If TabControl1.SelectedIndex = 0 Then Call DATA_SEARCH_Vs20(lab_SITE.Code, "1", txt_IDNO.Code, ValCHECK1, ValCHECK2)
                'If TabControl1.SelectedIndex = 1 Then Call DATA_SEARCH_VS21(lab_SITE.Code, "2", txt_IDNO.Code, ValCHECK1, ValCHECK2)

                Call DATA_SEARCH_Vs20(lab_SITE.Code, "1", txt_IDNO.Code, ValCHECK1, ValCHECK2)
                Call DATA_SEARCH_VS21(lab_SITE.Code, "2", txt_IDNO.Code, ValCHECK1, ValCHECK2)
                Call DATA_SEARCH_VS3()

                If Check_Copy.Checked = True Or Check_All_Copy.Checked = True Then

                    If txt_SANO_Before.Data = "" Then
                        txt_SANO_Before.Data = getData(Vs1, getColumIndex(Vs1, "Name"), Vs1.ActiveSheet.ActiveRowIndex)
                        txt_SANO_Before.Code = getData(Vs1, getColumIndex(Vs1, "Key_IDNO"), Vs1.ActiveSheet.ActiveRowIndex)
                    End If

                    If READ_PFK7411(txt_SANO_Before.Code) = True Then
                        txt_SANO_After.Data = getData(Vs1, getColumIndex(Vs1, "Name"), Vs1.ActiveSheet.ActiveRowIndex)
                        txt_SANO_After.Code = getData(Vs1, getColumIndex(Vs1, "Key_IDNO"), Vs1.ActiveSheet.ActiveRowIndex)

                        If txt_SANO_Before.Data = txt_SANO_After.Data Then
                            txt_SANO_After.Data = ""
                            txt_SANO_After.Code = ""
                        End If

                        If Check_All_Copy.Checked = True Then
                            txt_SANO_After.Data = ""
                            txt_SANO_After.Code = ""
                        End If

                        cmd_Save.Visible = False
                        cmd_del.Visible = False

                        cmd_Save_Copy.Visible = True
                    Else
                        txt_SANO_After.Data = ""
                        txt_SANO_After.Code = ""

                        cmd_Save.Visible = True
                        cmd_del.Visible = True

                        cmd_Save_Copy.Visible = False
                    End If
                Else
                    txt_SANO_After.Data = ""
                    txt_SANO_After.Code = ""

                    cmd_Save.Visible = True
                    cmd_del.Visible = True

                    cmd_Save_Copy.Visible = False
                End If

            Else
                Me.Form_ClearData()
            End If
        End If
    End Sub

    Private Sub Vs20_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles VS20.CellDoubleClick
        If e.ColumnHeader = True Then
            If TypeOf (VS20.ActiveSheet.Columns(e.Column).CellType) Is FarPoint.Win.Spread.CellType.CheckBoxCellType Then
                SPR_CheckAll(VS20, e.Column)
            End If
        End If
    End Sub

    Private Sub Vs21_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles VS21.CellDoubleClick
        If e.ColumnHeader = True Then
            If TypeOf (VS21.ActiveSheet.Columns(e.Column).CellType) Is FarPoint.Win.Spread.CellType.CheckBoxCellType Then
                SPR_CheckAll(VS21, e.Column)
            End If
        End If
    End Sub
    Private Sub vS3_KeyDown(sender As Object, e As KeyEventArgs) Handles vS3.KeyDown
        Dim xCOL As Long
        Dim xROW As Long
        Dim i As Integer

        xCOL = vS3.ActiveSheet.ActiveColumnIndex
        xROW = vS3.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode

            Case Keys.Delete
                Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)

                If Msg_Result <> vbYes Then Exit Sub

                W9996.SITE = Trim$(getData(vS3, getColumIndex(vS3, "KEY_SITE"), xROW))
                W9996.SANO = Trim$(getData(vS3, getColumIndex(vS3, "KEY_SANO"), xROW))
                W9996.SEQ = CDecp(getData(vS3, getColumIndex(vS3, "KEY_SEQ"), xROW))
                W9996.CustomerCode = Trim$(getData(vS3, getColumIndex(vS3, "CustomerCode"), xROW))

                If DELETE_PFK9996(W9996) = True Then
                    SPR_DEL(vS3, 0, vS3.ActiveSheet.ActiveRowIndex)
                    vS3.Focus()
                End If

        End Select

    End Sub


    Private Sub Check_Copy_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Copy.CheckedChanged

        If Check_Copy.Checked = False And Check_All_Copy.Checked = False Then
            txt_SANO_Before.Data = ""
            txt_SANO_Before.Code = ""

            txt_SANO_After.Data = ""
            txt_SANO_After.Code = ""
        End If

        If Check_All_Copy.Checked = False Then Call SPR_ChkLock(Vs1, True, getColumIndex(Vs1, "SCHK"))
        If Check_All_Copy.Checked = True Then Call SPR_ChkLock(Vs1, False, getColumIndex(Vs1, "SCHK"))

    End Sub
    Private Sub Check_Copy_ALL_CheckedChanged(sender As Object, e As EventArgs) Handles Check_All_Copy.CheckedChanged

        If Check_Copy.Checked = False And Check_All_Copy.Checked = False Then
            txt_SANO_Before.Data = ""
            txt_SANO_Before.Code = ""

            txt_SANO_After.Data = ""
            txt_SANO_After.Code = ""
        End If

        If Check_All_Copy.Checked = False Then Call SPR_ChkLock(Vs1, True, getColumIndex(Vs1, "SCHK"))
        If Check_All_Copy.Checked = True Then Call SPR_ChkLock(Vs1, False, getColumIndex(Vs1, "SCHK"))
    End Sub

    Private Sub PFP85010_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width > 20 Then
            ptc_1.ItemSize = New Size((Me.Width - 20) / 2, 30)
        End If
    End Sub

#End Region

End Class