Public Class ISUD7106K
#Region "Variable"
    Private wJOB As Integer

    Private W7106 As T7106_AREA
    Private L7106 As T7106_AREA

    Private W7231 As T7231_AREA

    Private W7109 As T7109_AREA
    Private L7109 As T7109_AREA

    Private WRITE_CHK As String
    Private ChkUpload As Boolean = False
    Private cdGroupComponent As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7106K(job As Integer, ShoesCode As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D7106.ShoesCode = ShoesCode
        wJOB = job : L7106 = D7106

        Link_ISUD7106K = False

        Try
            Select Case job
                Case 1
                Case Else
                    If READ_PFK7106(ShoesCode) Then
                        L7106 = D7106
                    End If

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7106K = isudCHK


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
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

            Case 2
                Me.Text = "COLOR GROUP ISUD7106K" & " - SEARCH"
                tst_iSave.Visible = False

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
                Call DATA_SEARCH_VS2()

            Case 3
                Me.Text = "COLOR GROUP ISUD7106K" & " - UPDATE"
                txt_Article.Enabled = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

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
                Me.Text = "COLOR GROUP ISUD7106K" & " - DELETE"

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Try
            txt_Article.Enabled = False
            Call D7109_CLEAR()
            W7109 = D7109

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()
        Call Cms_additem(Cms_1, _
                      "GROUP COLOR ADD PROCESSING - " & WordConv("INPUT") & "(F5)")

        Me.ContextMenuStrip = Cms_1

        tst_iRefresh.Visible = True
    End Sub
    Private Sub ISUD7106K_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub

    Overrides Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey
                Case Keys.F5 : Call MAIN_JOB01()
                    'Case Keys.F6 : Call MAIN_JOB02()
                    'Case Keys.F7 : Call MAIN_JOB03()
                    'Case Keys.F8 : Call MAIN_JOB04()
                    'Case Keys.F9 : Call MAIN_JOB05()
            End Select
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Data_Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        DATA_SEARCH01 = True

    End Function

    Private Function DATA_SEARCH_VS0() As Boolean
        DATA_SEARCH_VS0 = False

        DS1 = PrcDS("USP_ISUD7106K_SEARCH_VS0", cn, L7106.ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS0, DS1, "USP_ISUD7106K_SEARCH_VS0", "VS0")

            vS0.Enabled = True
            Exit Function
        End If
        SPR_PRO_NEW(vS0, DS1, "USP_ISUD7106K_SEARCH_VS0", "VS0")

        vS0.ActiveSheet.ColumnHeader.Rows(0).Height = 30
        vS0.ActiveSheet.RowCount = 2
        SPR_CHECKBOXROW(vS0, 1)

        DATA_SEARCH_VS0 = True
    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        DS1 = PrcDS("USP_ISUD7106K_SEARCH_VS1", cn, L7106.Article)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS1, DS1, "USP_ISUD7106K_SEARCH_VS1", "VS1")

            vS1.Enabled = True
            Exit Function
        End If
        SPR_PRO_NEW(vS1, DS1, "USP_ISUD7106K_SEARCH_VS1", "VS1")

        DATA_SEARCH_VS1 = True
    End Function
    Private Function DATA_SEARCH_VS2() As Boolean
        DATA_SEARCH_VS2 = False
        Dim xr As Integer
        Dim ArrayShoesCode As String

        For xr = 0 To vS1.ActiveSheet.RowCount - 1
            If getDataM(vS1, getColumIndex(vS1, "CheckUse"), xr) = "1" Then
                ArrayShoesCode = ArrayShoesCode & "''" & getData(vS1, getColumIndex(vS1, "ShoesCode"), xr) & "''" & ","
            End If
        Next

        If ArrayShoesCode = "" Then Exit Function

        ArrayShoesCode = Strings.Left(ArrayShoesCode, Len(ArrayShoesCode) - 1)

        If chk_FullBase.Checked = False Then

            Dim Starting As Object

            Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

            Try
                DS1 = PrcDS("USP_ISUD7106K_SEARCH_VS2", cn, ArrayShoesCode _
           , chk_cdGroupComponentName.CheckState _
           , chk_ComponentName.CheckState _
           , chk_MaterialName.CheckState _
           , chk_Specification.CheckState _
           , chk_ColorName.CheckState _
           , chk_Width.CheckState _
           , chk_Height.CheckState _
           , chk_SizeName.CheckState _
           , chk_cdUnitmaterialName.CheckState _
           , chk_Consumption.CheckState _
           , chk_GrossUsage.CheckState _
           , chk_cdSubProcessName.CheckState)


                If GetDsRc(DS1) = 0 Then
                    SPR_PRO_NEW(vS2, DS1, "USP_ISUD7106K_SEARCH_VS2", "VS2")
                    vS2.Enabled = True
                    Exit Function
                End If

                SPR_PRO_NEW(vS2, DS1, "USP_ISUD7106K_SEARCH_VS2", "VS2")

                Dim i As Integer
                Dim j As Integer
                Dim k As Integer
                Dim l As Integer

                vS2.ActiveSheet.ColumnHeader.RowCount = 2

                For i = 0 To vS1.ActiveSheet.RowCount - 1
                    If getDataM(vS1, getColumIndex(vS1, "CheckUse"), i) = "1" Then
                        DS2 = PrcDS("USP_ISUD7106K_SEARCH_VS2_INSERT", cn,
                                 getData(vS1, getColumIndex(vS1, "ShoesCode"), i) _
                               , chk_cdGroupComponentName.CheckState _
                               , chk_ComponentName.CheckState _
                               , chk_MaterialName.CheckState _
                               , chk_Specification.CheckState _
                               , chk_ColorName.CheckState _
                               , chk_Width.CheckState _
                               , chk_Height.CheckState _
                               , chk_SizeName.CheckState _
                               , chk_cdUnitmaterialName.CheckState _
                               , chk_Consumption.CheckState _
                               , chk_GrossUsage.CheckState _
                               , chk_cdSubProcessName.CheckState)

                        vS2.ActiveSheet.ColumnCount += CntProcess - 1
                        vS2.ActiveSheet.FrozenColumnCount = 2

                        For j = 0 To GetDsRc(DS2) - 1
                            For k = vS2.ActiveSheet.ColumnCount - (CntProcess - 1) To vS2.ActiveSheet.ColumnCount - 1

                                For l = 0 To vS2.ActiveSheet.RowCount - 1
                                    If getData(vS2, getColumIndex(vS2, "GroupComponentSeq"), l) & getData(vS2, getColumIndex(vS2, "ComponentName"), l) =
                                        GetDsData(DS2, j, "GroupComponentSeq") & GetDsData(DS2, j, "ComponentName") Then
                                        setData(vS2, k, l, GetDsData(DS2, j, CntProcess - (vS2.ActiveSheet.ColumnCount - k - 2)))
                                        Exit For
                                    End If
                                Next

                                setCellCH(vS2, k, 0, getData(vS1, getColumIndex(vS1, "ShoesCode"), i))

                                setDataCH(vS2, k, 0, GetDsData(DS2, 0, "ShoesCode_ColorName"))
                                vS2.ActiveSheet.ColumnHeader.Cells(0, k).ColumnSpan = CntProcess - 1

                                setDataCH(vS2, k, 1, getColumName(DS2, CntProcess - (vS2.ActiveSheet.ColumnCount - k - 2)))

                                vS2.ActiveSheet.Columns(k).Width = 120
                            Next
                        Next

                    End If
                Next



                DATA_SEARCH_VS2 = True
            Catch ex As Exception

            Finally
                Starting.close()
            End Try

        Else

            Dim Starting As Object

            Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

            Try
                DS1 = PrcDS("USP_ISUD7106K_SEARCH_VS2_FULL", cn _
           , txt_GroupComponentBOM.Data _
           , txt_GroupComponentSeq.Data _
           , "1" _
           , "1" _
           , "1" _
           , "1" _
           , "1" _
           , "1" _
           , "1" _
           , "1" _
           , "1" _
           , "1" _
           , "1" _
           , "1")

                If GetDsRc(DS1) = 0 Then
                    SPR_PRO_NEW(vS2, DS1, "USP_ISUD7106K_SEARCH_VS2_FULL", "VS2")
                    vS2.Enabled = True
                    Exit Function
                End If

                SPR_PRO_NEW(vS2, DS1, "USP_ISUD7106K_SEARCH_VS2_FULL", "VS2")
                DATA_SEARCH_VS2 = True

            Catch ex As Exception

            Finally
                Starting.close()
            End Try

        End If
    End Function

    Private Function DATA_SEARCH_VS3() As Boolean
        DATA_SEARCH_VS3 = False

        DS1 = PrcDS("USP_ISUD7106K_SEARCH_VS3", cn, txt_GroupComponentBOM.Data, txt_GroupComponentSeq.Data)

        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_ISUD7106K_SEARCH_VS3_INSERT", cn, txt_GroupComponentBOM.Data, txt_GroupComponentSeq.Data)

            SPR_PRO_NEW(vS3, DS2, "USP_ISUD7106K_SEARCH_VS3", "VS3")

            vS3.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS3, DS1, "USP_ISUD7106K_SEARCH_VS3", "VS3")

        DATA_SEARCH_VS3 = True
    End Function

    Private Function DATA_SEARCH_VS4() As Boolean
        DATA_SEARCH_VS4 = False

        DS1 = PrcDS("USP_ISUD7106K_SEARCH_VS4", cn, txt_GroupComponentBOM.Data, txt_GroupComponentSeq.Data)

        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_ISUD7106K_SEARCH_VS4_INSERT", cn, txt_GroupComponentBOM.Data, txt_GroupComponentSeq.Data)
            SPR_PRO_NEW(vS4, DS2, "USP_ISUD7106K_SEARCH_VS4", "VS4")
            vS4.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS4, DS1, "USP_ISUD7106K_SEARCH_VS4", "VS4")

        DATA_SEARCH_VS4 = True
    End Function

    Private Function DATA_SEARCH_VS5_HEAD() As Boolean
        DATA_SEARCH_VS5_HEAD = False

        DS1 = PrcDS("USP_ISUD7106K_SEARCH_VS5_HEAD", cn, txt_GroupComponentBOM.Data, txt_GroupComponentSeq.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS5_Head, DS1, "USP_ISUD7106K_SEARCH_VS5_HEAD", "VS5_HEAD")
            vS5_Head.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS5_Head, DS1, "USP_ISUD7106K_SEARCH_VS5_HEAD", "VS5_HEAD")

        DATA_SEARCH_VS5_HEAD = True
    End Function
    Private Function DATA_SEARCH_VS5() As Boolean
        DATA_SEARCH_VS5 = False

        DS1 = PrcDS("USP_ISUD7106K_SEARCH_VS5", cn, txt_GroupComponentBOM.Data, txt_GroupComponentSeq.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS5, DS1, "USP_ISUD7106K_SEARCH_VS5", "VS5")
            vS5.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS5, DS1, "USP_ISUD7106K_SEARCH_VS5", "VS5")

        DATA_SEARCH_VS5 = True
    End Function

    Private Function DATA_SEARCH_VS6_HEAD() As Boolean
        DATA_SEARCH_VS6_HEAD = False

        DS1 = PrcDS("USP_ISUD7106K_SEARCH_VS6_HEAD", cn, txt_GroupComponentBOM.Data, txt_GroupComponentSeq.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS6_Head, DS1, "USP_ISUD7106K_SEARCH_VS6_HEAD", "VS6_HEAD")
            vS6_Head.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS6_Head, DS1, "USP_ISUD7106K_SEARCH_VS6_HEAD", "VS6_HEAD")

        DATA_SEARCH_VS6_HEAD = True
    End Function
    Private Function DATA_SEARCH_VS6() As Boolean
        DATA_SEARCH_VS6 = False
        Dim i As Integer
        Dim Value As String = ""

        For i = 0 To vS0.ActiveSheet.ColumnCount - 1
            If getDataM(vS0, i, 1) = "1" And getData(vS0, i, 0) <> "" Then
                Value &= "''" & i.ToString("00") & "'',"
            End If
        Next

        If Value.Length > 1 Then Value = Strings.Left(Value, Len(Value) - 1)

        DS1 = PrcDS("USP_ISUD7106K_SEARCH_VS6", cn, txt_GroupComponentBOM.Data, txt_GroupComponentSeq.Data, Value)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS6, DS1, "USP_ISUD7106K_SEARCH_VS6", "VS6")
            vS6.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS6, DS1, "USP_ISUD7106K_SEARCH_VS6", "VS6")

        DATA_SEARCH_VS6 = True
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
    Private Sub DATA_INSERT()
        Try
            Call DATA_MOVE()
            Call DATA_MOVE_WRITE01()
            Call DATA_MOVE_WRITE_NO_UPLOAD()
            isudCHK = True : WRITE_CHK = "*"
            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INSERT")
        End Try

    End Sub

    Private Sub DATA_UPDATE()
        Dim Starting As Object
        Starting = New DevExpress.Utils.WaitDialogForm("Saving data...", "PSM")

        Try


            Dim i As Integer

            For i = 0 To vS1.ActiveSheet.RowCount - 1


            Next

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")

        Finally

            Starting.close()

        End Try
    End Sub

    Private Function KEY_COUNT_NO_2(SpecNo As String) As String


    End Function

    Private Sub DATA_DELETE()


    End Sub

    Private Function CheckExist(SpecNo As String, SpecNoSeq As String) As Boolean
        CheckExist = False

        Dim RC As Integer
        Try
            rd = PrcDR("USP_ISUD0101A_SEARCH_VS00_CHECKEXIST", cn, SpecNo, SpecNoSeq)

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


    Private Function DATA_MOVE_K7109() As Boolean
        Dim j As Integer
        Dim i As Integer

        DATA_MOVE_K7109 = False

        Try
            For i = 0 To vS2.ActiveSheet.RowCount - 1
                If getData(vS2, getColumIndex(vS2, "MaterialName"), i) = "" Then GoTo next1

                If READ_PFK7231_NAME(getData(vS2, getColumIndex(vS2, "MaterialName"), i)) = False Then
                    Call KEY_COUNT_MATERIAL()
                    W7231.MaterialName = getData(vS2, getColumIndex(vS2, "MaterialName"), i)
                    W7231.CheckUse = "1"
                    W7231.CheckActive = "2"
                    W7231.DateInsert = Pub.DAT
                    W7231.InchargeInsert = Pub.SAW

                    W7231.DevelopmentCode = W7231.MaterialCode
                    W7231.cdUnitMaterial = getData(vS2, getColumIndex(vS2, "cdUnitMaterial"), i)
                    W7231.seUnitMaterial = ListCode("UnitMaterial")

                    If WRITE_PFK7231(W7231) Then
                        setData(vS2, getColumIndex(vS2, "MaterialCode"), i, W7231.MaterialCode)
                    End If

                Else
                    setData(vS2, getColumIndex(vS2, "MaterialCode"), i, D7231.MaterialCode)
                End If

                j += 1

                If K7109_MOVE(vS2, i, W7109, txt_GroupComponentBOM.Data, getData(vS2, getColumIndex(vS2, "KEY_GroupComponentSeq"), i)) = True Then
                    W7109.GroupComponentBOM = txt_GroupComponentBOM.Data
                    W7109.GroupComponentSeq = getData(vS2, getColumIndex(vS2, "KEY_GroupComponentSeq"), i)
                    W7109.Dseq = j

                    W7109.GrossUsage = W7109.Consumption * (1 + W7109.Loss)
                    W7109.MaterialAMT = W7109.GrossUsage * W7109.Price

                    Call DATA_MOVE_DEFAULT()
                    Call REWRITE_PFK7109(W7109)
                Else
                    Call KEY_COUNT_7109()
                    W7109.Dseq = j

                    W7109.GroupComponentBOM = txt_GroupComponentBOM.Data
                    W7109.GroupComponentSeq = txt_GroupComponentSeq.Data

                    W7109.GrossUsage = W7109.Consumption * (1 + W7109.Loss)
                    W7109.MaterialAMT = W7109.GrossUsage * W7109.Price

                    Call DATA_MOVE_DEFAULT()
                    Call WRITE_PFK7109(W7109)
                End If
next1:
            Next

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
        SQL = "SELECT MAX(CAST(K7109_GroupComponentSeq AS DECIMAL)) AS MAX_MCODE FROM PFK7109 "
        SQL = SQL & " AND K7109_GroupComponentSeq = '" & txt_GroupComponentSeq.Data & "' "
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

    Private Sub MAIN_JOB01()

    End Sub
#End Region

#Region "Event"

    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 1

            Case 2
                Me.Dispose()
            Case 3
                If Data_Check() = False Then Exit Sub

                If DataCheck(Me, "PFK0112") = False Then Exit Sub
                Call DATA_UPDATE()

                If chk_FullBase.Checked = True Then Call DATA_MOVE_K7109()

                Call DATA_SEARCH_VS1()

            Case 4
                Call DATA_DELETE()

        End Select
    End Sub

    Private Sub tst_iClose_Click(sender As Object, e As EventArgs) Handles tst_iClose.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub

    Private Sub tst_iDelete_Click(sender As Object, e As EventArgs)
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "tst_iDelete_Click")
            Exit Sub
        End If

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

        Call DATA_DELETE()


    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles vS1.CellClick
        Dim xCOL As Integer
        Dim xROW As Integer
        Dim Value As String

        xROW = sender.ActiveSheet.ActiveRowIndex
        xCOL = sender.ActiveSheet.ActiveColumnIndex

        If chk_FullBase.Checked = False And (ptc_Main.SelectedIndex = 0 Or (ptc_Main.SelectedIndex = 3 And xCOL <> getColumIndex(sender, "SpecNoSeq"))) Then
            vS1.ActiveSheet.Columns(getColumIndex(vS1, "CheckUse")).Locked = False
            Exit Sub
        ElseIf chk_FullBase.Checked = False And (ptc_Main.SelectedIndex = 3) And xCOL = getColumIndex(sender, "SpecNoSeq") Then
            vS1.ActiveSheet.Columns(getColumIndex(vS1, "CheckUse")).Locked = True
        Else
            vS1.ActiveSheet.Columns(getColumIndex(vS1, "CheckUse")).Locked = True

        End If

        Value = getData(sender, getColumIndex(sender, "CheckUse"), xROW)

        setDataChkCol(sender, getColumIndex(sender, "CheckUse"), "2")

        If Value <> "1" Then
            setData(sender, getColumIndex(sender, "CheckUse"), xROW, "1", , True)
            txt_GroupComponentBOM.Data = getData(vS1, getColumIndex(vS1, "Key_GroupComponentBOM"), e.Row)
            txt_GroupComponentSeq.Data = getData(vS1, getColumIndex(vS1, "Key_GroupComponentSeq"), e.Row)
        Else
            setData(sender, getColumIndex(sender, "CheckUse"), xROW, "0", , True)
            txt_GroupComponentBOM.Data = ""
            txt_GroupComponentSeq.Data = ""
        End If

        Call ptc_Main_SelectedIndexChanged(sender, e)
    End Sub


    Private Sub cmd_Upload_Click(sender As Object, e As EventArgs)
        Try

            Using OpenFileDialog As OpenFileDialog = Me.GetOpenFileDialog()

                If (OpenFileDialog.ShowDialog(Me) = DialogResult.OK) Then
                    vS1.OpenExcel(OpenFileDialog.FileName)
                    ChkUpload = True
                Else 'Cancel

                    Exit Sub

                End If

            End Using

        Catch ex As Exception

        End Try
    End Sub

    Friend Shared Function GetExcelFile(ByVal strFileName As String, ByVal strPath As String) As DataTable

        Try

            Dim dt As New DataTable

            Dim ConStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strPath & ";Extended Properties=""Text;HDR=Yes;FMT=Delimited\"""
            Dim conn As New OleDb.OleDbConnection(ConStr)
            Dim da As New OleDb.OleDbDataAdapter("Select * from " & strFileName, conn)
            da.Fill(dt)

            Return dt

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Private Function GetOpenFileDialog() As OpenFileDialog

        Dim openFileDialog As New OpenFileDialog

        openFileDialog.CheckFileExists = True
        openFileDialog.Multiselect = False
        openFileDialog.AddExtension = True
        openFileDialog.ValidateNames = True
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        Return openFileDialog


    End Function

    Private Sub ptc_Main_DoubleClick(sender As Object, e As EventArgs) Handles ptc_Main.DoubleClick
        If formA = False Then ptc_Main.SelectedIndex = 0

        Select Case ptc_Main.SelectedIndex
            Case 0
                Call DATA_SEARCH_VS2()

            Case 1
                Call DATA_SEARCH_VS3()

            Case 2
                Call DATA_SEARCH_VS4()

            Case 3
                Call DATA_SEARCH_VS5_HEAD()
                Call DATA_SEARCH_VS5()

            Case 4
                Call DATA_SEARCH_VS6_HEAD()
                Call DATA_SEARCH_VS6()

        End Select
    End Sub
    Private Sub ptc_Main_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ptc_Main.SelectedIndexChanged
        If formA = False Then Exit Sub
        If ptc_Main.SelectedIndex = -1 Then Exit Sub

        If formA = False Then ptc_Main.SelectedIndex = 0

        Select Case ptc_Main.SelectedIndex
            Case 0
                Call DATA_SEARCH_VS2()

            Case 1
                Call DATA_SEARCH_VS3()

            Case 2
                Call DATA_SEARCH_VS4()

            Case 3
                Call DATA_SEARCH_VS5_HEAD()
                Call DATA_SEARCH_VS5()

            Case 4
                Call DATA_SEARCH_VS6_HEAD()
                Call DATA_SEARCH_VS6()
        End Select

    End Sub
    Private flagP As Boolean = False
    Private flagQ As Boolean = False
    Private flagW As Boolean = False
    Private flagL As Boolean = False
    Private flagS As Boolean = False


    Private Sub tst_iRefresh_Click(sender As Object, e As EventArgs) Handles tst_iRefresh.Click
        Call DATA_SEARCH_VS2()
    End Sub

    Private CntProcess As Integer

    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked
        If Cms_1.Items(0).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB01()

        End If
    End Sub

    Private Sub chk_cdGroupComponentName_CheckedChanged(sender As Object, e As EventArgs) Handles chk_cdGroupComponentName.CheckedChanged _
        , chk_ComponentName.CheckedChanged _
        , chk_MaterialName.CheckedChanged _
        , chk_Specification.CheckedChanged _
        , chk_ColorName.CheckedChanged _
        , chk_Width.CheckedChanged _
        , chk_Height.CheckedChanged _
        , chk_SizeName.CheckedChanged _
        , chk_cdUnitmaterialName.CheckedChanged _
        , chk_Consumption.CheckedChanged _
        , chk_GrossUsage.CheckedChanged _
        , chk_cdSubProcessName.CheckedChanged _
        , chk_FullBase.CheckedChanged

        CntProcess = 0

        If chk_FullBase.Checked = False Then
            If chk_cdGroupComponentName.Checked = True Then CntProcess += 1
            If chk_ComponentName.Checked = True Then CntProcess += 1
            If chk_MaterialName.Checked = True Then CntProcess += 1
            If chk_Specification.Checked = True Then CntProcess += 1
            If chk_ColorName.Checked = True Then CntProcess += 1
            If chk_Width.Checked = True Then CntProcess += 1
            If chk_Height.Checked = True Then CntProcess += 1
            If chk_SizeName.Checked = True Then CntProcess += 1
            If chk_cdUnitmaterialName.Checked = True Then CntProcess += 1
            If chk_Consumption.Checked = True Then CntProcess += 1
            If chk_GrossUsage.Checked = True Then CntProcess += 1
            If chk_cdSubProcessName.Checked = True Then CntProcess += 1
        Else
            If chk_cdGroupComponentName.Checked = True Then CntProcess += 3
            If chk_ComponentName.Checked = True Then CntProcess += 4
            If chk_MaterialName.Checked = True Then CntProcess += 5
            If chk_Specification.Checked = True Then CntProcess += 1
            If chk_ColorName.Checked = True Then CntProcess += 1
            If chk_Width.Checked = True Then CntProcess += 1
            If chk_Height.Checked = True Then CntProcess += 1
            If chk_SizeName.Checked = True Then CntProcess += 1
            If chk_cdUnitmaterialName.Checked = True Then CntProcess += 3
            If chk_Consumption.Checked = True Then CntProcess += 2
            If chk_GrossUsage.Checked = True Then CntProcess += 3
            If chk_cdSubProcessName.Checked = True Then CntProcess += 4
        End If

        If chk_FullBase.Checked = True Then
            Call DATA_SEARCH_VS1()
            txt_GroupComponentBOM.Data = ""
            txt_GroupComponentSeq.Data = ""
        End If

    End Sub


    Private Sub vS2_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS2.CellDoubleClick
        If e.ColumnHeader Then
            Dim ShoesCode As String

            If getCellCH(vS2, e.Column, 0) = "" Then Exit Sub

            ShoesCode = getCellCH(vS2, e.Column, 0)

            If READ_PFK7108_SHOESCODE(ShoesCode) = False Then
                If ISUD7108A.Link_ISUD7108A(1, ShoesCode, Me.Tag) Then
                    Call DATA_SEARCH_VS2()
                End If
            Else
                If ISUD7108A.Link_ISUD7108A(3, D7108.GroupComponentBOM, Me.Tag) Then
                    Call DATA_SEARCH_VS2()
                End If
            End If
        End If
    End Sub

#End Region

End Class