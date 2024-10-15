Public Class ISUD7106Q
#Region "Variable"
    Private wJOB As Integer

    Private W7111 As T7111_AREA
    Private L7111 As T7111_AREA

    Private W7231 As T7231_AREA

    Private W7110 As T7110_AREA
    Private L7110 As T7110_AREA

    Private W7113 As T7113_AREA
    Private L7113 As T7113_AREA

    Private W7114 As T7114_AREA
    Private L7114 As T7114_AREA

    Private W0111 As T0111_AREA
    Private L0111 As T0111_AREA

    Private W7112 As T7112_AREA
    Private L7112 As T7112_AREA

    Private WRITE_CHK As String
    Private ChkUpload As Boolean = False
    Private cdGroupComponent As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7106Q(job As Integer, BaseComponentBOM As String, ShoesCode As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D7110.BaseComponentBOM = BaseComponentBOM
        D7110.ShoesCode = ShoesCode

        wJOB = job : L7111 = D7111

        Link_ISUD7106Q = False

        Try
            Select Case job
                Case 1
                Case Else
                    If READ_PFK7110(L7111.ShoesCode, L7111.ShoesCode) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7106Q = isudCHK


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

                Call KEY_COUNT()
                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

            Case 2
                Me.Text = "COLOR GROUP ISUD7106Q" & " - SEARCH"
                cmd_OK.Visible = False

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
                Me.Text = "COLOR GROUP ISUD7106Q" & " - UPDATE"
                txt_BaseComponentBOM.Enabled = False

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
                Me.Text = "COLOR GROUP ISUD7106Q" & " - DELETE"

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
            txt_BaseComponentBOM.Enabled = False
            Call D7111_CLEAR()
            W7111 = D7111

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()
        Call Cms_additem(Cms_1, _
                      "GROUP COLOR ADD PROCESSING - " & WordConv("INPUT") & "(F5)")

        Me.ContextMenuStrip = Cms_1
        Me.WindowState = FormWindowState.Maximized

    End Sub
    Private Sub PFP17811_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

        DS1 = READ_PFK7110(L7111.ShoesCode, L7111.ShoesCode, cn)

        If GetDsRc(DS1) = 0 Then Exit Function

        Call READER_MOVE(Me, DS1)

        DS1 = Nothing


        DATA_SEARCH01 = True

    End Function

    Private Function DATA_SEARCH_VS0() As Boolean
        DATA_SEARCH_VS0 = False

        DS1 = PrcDS("USP_ISUD7106Q_SEARCH_VS0", cn, L7111.ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS0, DS1, "USP_ISUD7106Q_SEARCH_VS0", "VS0")

            vS0.Enabled = True
            Exit Function
        End If
        SPR_PRO_NEW(vS0, DS1, "USP_ISUD7106Q_SEARCH_VS0", "VS0")

        vS0.ActiveSheet.ColumnHeader.Rows(0).Height = 30
        vS0.ActiveSheet.RowCount = 2
        SPR_CHECKBOXROW(vS0, 1)

        DATA_SEARCH_VS0 = True
    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        If READ_PFK7110(L7110.BaseComponentBOM, L7110.ShoesCode) Then
            DS1 = PrcDS("USP_ISUD7106Q_SEARCH_VS1", cn, D7110.BaseComponentBOM)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS1, DS1, "USP_ISUD7106Q_SEARCH_VS1", "VS1")

                vS1.Enabled = True
                Exit Function
            End If
            SPR_PRO_NEW(vS1, DS1, "USP_ISUD7106Q_SEARCH_VS1", "VS1")

            DATA_SEARCH_VS1 = True

        End If
    End Function

    Private Function DATA_SEARCH_VS7() As Boolean
        DATA_SEARCH_VS7 = False
        If READ_PFK7110(L7110.BaseComponentBOM, L7110.ShoesCode) Then
            DS1 = PrcDS("USP_ISUD7106Q_SEARCH_VS7", cn, D7110.BaseComponentBOM)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vs7, DS1, "USP_ISUD7106Q_SEARCH_VS7", "VS7")

                vs7.Enabled = True
                Exit Function
            End If
            SPR_PRO_NEW(vs7, DS1, "USP_ISUD7106Q_SEARCH_VS7", "VS7")

            DATA_SEARCH_VS7 = True
        End If

    End Function

    Private Function DATA_SEARCH_VS8() As Boolean
        DATA_SEARCH_VS8 = False
        Dim UploadNo As String

        UploadNo = getData(vs7, getColumIndex(vs7, "KEY_UploadNo"), vs7.ActiveSheet.ActiveRowIndex)

        DS1 = PrcDS("USP_ISUD7106Q_SEARCH_VS8", cn, UploadNo)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS8, DS1, "USP_ISUD7106Q_SEARCH_VS8", "VS8")

            vS8.Enabled = True
            Exit Function
        End If
        SPR_PRO_NEW(vS8, DS1, "USP_ISUD7106Q_SEARCH_VS8", "VS8")

        DATA_SEARCH_VS8 = True

    End Function

    Private Function BaseComponentBOMList() As String
        BaseComponentBOMList = ""

        Dim i As Integer

        For i = 0 To vS1.ActiveSheet.RowCount - 1
            If getDataM(vS1, getColumIndex(vS1, "CheckUse"), i) <> "1" Then GoTo next1
            BaseComponentBOMList = BaseComponentBOMList & "''" & getData(vS1, getColumIndex(vS1, "KEY_BaseComponentBOM"), i)
            BaseComponentBOMList = BaseComponentBOMList & "!" & getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), i) & "''"
            BaseComponentBOMList = BaseComponentBOMList & ","
next1:
        Next

        If BaseComponentBOMList = "" Then Exit Function
        BaseComponentBOMList = Strings.Left(BaseComponentBOMList, Len(BaseComponentBOMList) - 1)

    End Function
    Private Function DATA_SEARCH_VS2() As Boolean
        DATA_SEARCH_VS2 = False
        Dim i As Integer
        If BaseComponentBOMList() = "" Then Exit Function

        If chk_FullBase.Checked = False Then

            Dim Starting As Object

            Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

            Try
                DS1 = PrcDS("USP_ISUD7106Q_SEARCH_VS2", cn, BaseComponentBOMList _
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
                    SPR_PRO_NEW(vS2, DS1, "USP_ISUD7106Q_SEARCH_VS2", "VS2")
                    vS2.Enabled = True
                    Exit Function
                End If

                SPR_PRO_NEW(vS2, DS1, "USP_ISUD7106Q_SEARCH_VS2", "VS2")

                Dim j As Integer
                Dim k As Integer
                Dim l As Integer

                vS2.ActiveSheet.ColumnHeader.RowCount = 2

                For i = 0 To vS1.ActiveSheet.RowCount - 1
                    If getDataM(vS1, getColumIndex(vS1, "CheckUse"), i) = "1" Then
                        DS2 = PrcDS("USP_ISUD7106Q_SEARCH_VS2_INSERT", cn,
                                 getData(vS1, getColumIndex(vS1, "BaseComponentBOM"), i),
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
                                    If getData(vS2, getColumIndex(vS2, "MaterialSeq"), l) & getData(vS2, getColumIndex(vS2, "ComponentName"), l) =
                                        GetDsData(DS2, j, "MaterialSeq") & GetDsData(DS2, j, "ComponentName") Then
                                        setData(vS2, k, l, GetDsData(DS2, j, CntProcess - (vS2.ActiveSheet.ColumnCount - k - 2)))
                                        Exit For
                                    End If
                                Next

                                setCellCH(vS2, k, 0, getData(vS1, getColumIndex(vS1, "BaseComponentBOM"), i) & "-" & getData(vS1, getColumIndex(vS1, "ShoesCode"), i))

                                setDataCH(vS2, k, 0, GetDsData(DS2, 0, "Color"))
                                vS2.ActiveSheet.ColumnHeader.Cells(0, k).ColumnSpan = CntProcess - 1

                                setDataCH(vS2, k, 1, GetColumname(DS2, CntProcess - (vS2.ActiveSheet.ColumnCount - k - 2)))

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
                DS1 = PrcDS("USP_ISUD7106Q_SEARCH_VS2_FULL", cn _
           , txt_BaseComponentBOMFull.Data _
           , txt_ShoesCodeFull.Data _
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
                    SPR_PRO_NEW(vS2, DS1, "USP_ISUD7106Q_SEARCH_VS2_FULL", "VS2")
                    vS2.Enabled = True
                    Exit Function
                End If

                SPR_PRO_NEW(vS2, DS1, "USP_ISUD7106Q_SEARCH_VS2_FULL", "VS2")
                DATA_SEARCH_VS2 = True

            Catch ex As Exception

            Finally
                Starting.close()
            End Try

        End If
    End Function
    Private Function DATA_SEARCH_VS2_NO() As Boolean
        DATA_SEARCH_VS2_NO = False
        Dim i As Integer
        If BaseComponentBOMList() = "" Then Exit Function

        If chk_FullBase.Checked = False Then

            Dim Starting As Object

            Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

            Try
                DS1 = PrcDS("USP_ISUD7106Q_SEARCH_VS2_NO", cn, BaseComponentBOMList _
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
                    SPR_PRO_NEW(vS2, DS1, "USP_ISUD7106Q_SEARCH_VS2_NO", "VS2")
                    vS2.Enabled = True
                    Exit Function
                End If

                SPR_PRO_NEW(vS2, DS1, "USP_ISUD7106Q_SEARCH_VS2_NO", "VS2")

                DATA_SEARCH_VS2_NO = True

            Catch ex As Exception

            Finally
                Starting.close()
            End Try

        End If

    End Function
    Private Function DATA_SEARCH_VS3() As Boolean
        DATA_SEARCH_VS3 = False

        DS1 = PrcDS("USP_ISUD7106Q_SEARCH_VS3", cn, txt_BaseComponentBOMFull.Data, txt_ShoesCodeFull.Data)

        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_ISUD7106Q_SEARCH_VS3_INSERT", cn, txt_BaseComponentBOMFull.Data, txt_ShoesCodeFull.Data)

            SPR_PRO_NEW(vS3, DS2, "USP_ISUD7106Q_SEARCH_VS3", "VS3")

            vS3.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS3, DS1, "USP_ISUD7106Q_SEARCH_VS3", "VS3")

        DATA_SEARCH_VS3 = True
    End Function

    Private Function DATA_SEARCH_VS4() As Boolean
        DATA_SEARCH_VS4 = False

        DS1 = PrcDS("USP_ISUD7106Q_SEARCH_VS4", cn, txt_BaseComponentBOMFull.Data, txt_ShoesCodeFull.Data)

        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_ISUD7106Q_SEARCH_VS4_INSERT", cn, txt_BaseComponentBOMFull.Data, txt_ShoesCodeFull.Data)
            SPR_PRO_NEW(vS4, DS2, "USP_ISUD7106Q_SEARCH_VS4", "VS4")
            vS4.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS4, DS1, "USP_ISUD7106Q_SEARCH_VS4", "VS4")

        DATA_SEARCH_VS4 = True
    End Function

    Private Function DATA_SEARCH_VS5_HEAD() As Boolean
        DATA_SEARCH_VS5_HEAD = False

        If BaseComponentBOMList() = "" Then Exit Function

        DS1 = PrcDS("USP_ISUD7106Q_SEARCH_VS5_HEAD", cn, BaseComponentBOMList)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS5_Head, DS1, "USP_ISUD7106Q_SEARCH_VS5_HEAD", "VS5_HEAD")
            vS5_Head.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS5_Head, DS1, "USP_ISUD7106Q_SEARCH_VS5_HEAD", "VS5_HEAD")

        DATA_SEARCH_VS5_HEAD = True
    End Function
    Private Function DATA_SEARCH_VS5() As Boolean
        DATA_SEARCH_VS5 = False

        If BaseComponentBOMList() = "" Then Exit Function

        DS1 = PrcDS("USP_ISUD7106Q_SEARCH_VS5", cn, BaseComponentBOMList)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS5, DS1, "USP_ISUD7106Q_SEARCH_VS5", "VS5")
            vS5.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS5, DS1, "USP_ISUD7106Q_SEARCH_VS5", "VS5")

        DATA_SEARCH_VS5 = True
    End Function

    Private Function DATA_SEARCH_VS6_HEAD() As Boolean
        DATA_SEARCH_VS6_HEAD = False

        DS1 = PrcDS("USP_ISUD7106Q_SEARCH_VS6_HEAD", cn, txt_BaseComponentBOMFull.Data, txt_ShoesCodeFull.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS6_Head, DS1, "USP_ISUD7106Q_SEARCH_VS6_HEAD", "VS6_HEAD")
            vS6_Head.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS6_Head, DS1, "USP_ISUD7106Q_SEARCH_VS6_HEAD", "VS6_HEAD")

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

        DS1 = PrcDS("USP_ISUD7106Q_SEARCH_VS6", cn, txt_BaseComponentBOMFull.Data, txt_ShoesCodeFull.Data, Value)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS6, DS1, "USP_ISUD7106Q_SEARCH_VS6", "VS6")
            vS6.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS6, DS1, "USP_ISUD7106Q_SEARCH_VS6", "VS6")

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

    End Sub

    Private Sub DATA_MOVE_K7112()
        Try
            If ChkUpload = False Then
                Dim UploadNo As String

                UploadNo = getData(vs7, getColumIndex(vs7, "KEY_UploadNo"), vs7.ActiveSheet.ActiveRowIndex)

                Call PrcExeNoError("USP_PFK7106Q_UPLOAD_CLOSSING", cn, UploadNo)
                Call DATA_SEARCH_VS8()
                Exit Sub

            End If

            Dim i As Integer
            Dim j As Integer
            Dim k As Integer
            Dim sRow As Integer
            Dim eRow As Integer
            Dim pCol As Integer
            Dim SpCol As Integer

            Dim QCol As Integer
            Dim WCol As Integer
            Dim LCol As Integer
            Dim Scol As Integer
            Dim ECol As Integer


            sRow = CIntp(lbl_RowStart.Text) - 1
            eRow = 200 - 1

            pCol = CIntp(lbl_Piece.Text) - 1
            QCol = CIntp(lbl_Qty.Text) - 1

            SpCol = CIntp(lbl_Spec.Text) - 1

            WCol = CIntp(lbl_Width.Text) - 1
            LCol = CIntp(lbl_Length.Text) - 1

            Scol = CIntp(lbl_Size.Text) - 1 - 1
            ECol = Scol + 30

            j = 0

            Call KEY_COUNT_7112()

            For i = sRow To eRow
                If getData(vS8, pCol, i) = "" Then GoTo skip

                j = j + 1

                Call D7112_CLEAR() : W7112 = D7112

                W7112.NameUpload = vS8.ActiveSheet.SheetName
                W7112.DateUpload = Pub.DAT
                W7112.InchargeUpload = Pub.SAW

                W7112.UploadNo = L7112.UploadNo
                W7112.UploadSeq = j

                W7112.BaseComponentBOM = L7111.ShoesCode
                W7112.ShoesCode = L7111.ShoesCode

                W7112.DSeq = j

                W7112.Spec2 = getData(vS8, WCol, i) ' material
                W7112.Spec3 = getData(vS8, LCol, i) ' allowance
                W7112.Spec4 = getData(vS8, SpCol, i) ' width x height
                W7112.Spec1 = getData(vS8, pCol, i) ' piêc

                W7112.ComponentName = getData(vS8, pCol, i) ' piêc

                W7112.QtyComponent = CDecp(getData(vS8, QCol, i))

                W7112.CSizeQty01 = CDecp(getData(vS8, Scol + 1, i))
                W7112.CSizeQty02 = CDecp(getData(vS8, Scol + 2, i))
                W7112.CSizeQty03 = CDecp(getData(vS8, Scol + 3, i))
                W7112.CSizeQty04 = CDecp(getData(vS8, Scol + 4, i))
                W7112.CSizeQty05 = CDecp(getData(vS8, Scol + 5, i))
                W7112.CSizeQty06 = CDecp(getData(vS8, Scol + 6, i))
                W7112.CSizeQty07 = CDecp(getData(vS8, Scol + 7, i))
                W7112.CSizeQty08 = CDecp(getData(vS8, Scol + 8, i))
                W7112.CSizeQty09 = CDecp(getData(vS8, Scol + 9, i))
                W7112.CSizeQty10 = CDecp(getData(vS8, Scol + 10, i))

                W7112.CSizeQty11 = CDecp(getData(vS8, Scol + 11, i))
                W7112.CSizeQty12 = CDecp(getData(vS8, Scol + 12, i))
                W7112.CSizeQty13 = CDecp(getData(vS8, Scol + 13, i))
                W7112.CSizeQty14 = CDecp(getData(vS8, Scol + 14, i))
                W7112.CSizeQty15 = CDecp(getData(vS8, Scol + 15, i))
                W7112.CSizeQty16 = CDecp(getData(vS8, Scol + 16, i))
                W7112.CSizeQty17 = CDecp(getData(vS8, Scol + 17, i))
                W7112.CSizeQty18 = CDecp(getData(vS8, Scol + 18, i))
                W7112.CSizeQty19 = CDecp(getData(vS8, Scol + 19, i))
                W7112.CSizeQty20 = CDecp(getData(vS8, Scol + 20, i))

                W7112.CSizeQty21 = CDecp(getData(vS8, Scol + 21, i))
                W7112.CSizeQty22 = CDecp(getData(vS8, Scol + 22, i))
                W7112.CSizeQty23 = CDecp(getData(vS8, Scol + 23, i))
                W7112.CSizeQty24 = CDecp(getData(vS8, Scol + 24, i))
                W7112.CSizeQty25 = CDecp(getData(vS8, Scol + 25, i))
                W7112.CSizeQty26 = CDecp(getData(vS8, Scol + 26, i))
                W7112.CSizeQty27 = CDecp(getData(vS8, Scol + 27, i))
                W7112.CSizeQty28 = CDecp(getData(vS8, Scol + 28, i))
                W7112.CSizeQty29 = CDecp(getData(vS8, Scol + 29, i))
                W7112.CSizeQty30 = CDecp(getData(vS8, Scol + 30, i))

                Call WRITE_PFK7112(W7112)
skip:
            Next

            Call PrcExeNoError("USP_PFK7106Q_UPLOAD_CLOSSING", cn, W7112.UploadNo)
            ChkUpload = False
            Call DATA_SEARCH_VS7()

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub
    Private Function KEY_COUNT_NO_2(BaseComponentBOM As String) As String
        KEY_COUNT_NO_2 = ""

        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 2)


        SQL = "SELECT MAX(CAST(K7110_ShoesCode AS DECIMAL)) AS MAX_MCODE FROM PFK7110 "
        SQL = SQL & " WHERE K7110_BaseComponentBOM = '" & BaseComponentBOM & "' "
        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_MCODE) Then
            KEY_COUNT_NO_2 = "001"
        Else
            KEY_COUNT_NO_2 = FormatP(CIntp(rd!MAX_MCODE + 1), "000")
        End If

        rd.Close()

    End Function

    Private Sub DATA_DELETE()
        Try
            If chk_FullBase.Checked = True Then
                PrcExe("USP_PFK7110_DATA_DELETE_MATERIAL", cn, txt_BaseComponentBOMFull.Data, txt_ShoesCodeFull.Data)
                Call DATA_SEARCH_VS2()
            End If
        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

    Private Function CheckExist(BaseComponentBOM As String, ShoesCode As String) As Boolean
        CheckExist = False

        Dim RC As Integer
        Try
            rd = PrcDR("USP_ISUD7110A_SEARCH_VS00_CHECKEXIST", cn, BaseComponentBOM, ShoesCode)

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


    Private Function DATA_MOVE_K0111() As Boolean
        DATA_MOVE_K0111 = True
    End Function

    '    Private Function DATA_MOVE_K0111() As Boolean
    '        Dim j As Integer
    '        Dim i As Integer

    '        DATA_MOVE_K0111 = False

    '        Try
    '            For i = 0 To vS2.ActiveSheet.RowCount - 1
    '                If getData(vS2, getColumIndex(vS2, "MaterialName"), i) = "" Then GoTo next1

    '                j += 1

    '                If K0111_MOVE(vS2, i, W0111, txt_BaseComponentBOMFull.Data, txt_ShoesCodeFull.Data, getData(vS2, getColumIndex(vS2, "KEY_MaterialSeq"), i)) = True Then
    '                    W0111.BaseComponentBOM = txt_BaseComponentBOMFull.Data
    '                    W0111.ShoesCode = txt_ShoesCodeFull.Data
    '                    W0111.DSeq = j

    '                    W0111.GrossUsage = W0111.Consumption * (1 + W0111.Loss)
    '                    W0111.MaterialAMT = W0111.GrossUsage * W0111.Price

    '                    Call DATA_MOVE_DEFAULT()
    '                    Call REWRITE_PFK0111(W0111)
    '                Else
    '                    Call KEY_COUNT_0111()
    '                    W0111.DSeq = j

    '                    W0111.BaseComponentBOM = txt_BaseComponentBOMFull.Data
    '                    W0111.ShoesCode = txt_ShoesCodeFull.Data

    '                    W0111.GrossUsage = W0111.Consumption * (1 + W0111.Loss)
    '                    W0111.MaterialAMT = W0111.GrossUsage * W0111.Price

    '                    Call DATA_MOVE_DEFAULT()
    '                    Call WRITE_PFK0111(W0111)
    '                End If
    'next1:
    '            Next

    '            DATA_MOVE_K0111 = True

    '        Catch ex As Exception
    '            MsgBoxP("DATA_MOVE_K7820!", vbCritical)
    '        End Try

    '    End Function

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
        W0111.seDepartment = ListCode("Department")
        W0111.seGroupComponent = ListCode("GroupComponent")
        W0111.seShoesStatus = ListCode("ShoesStatus")
        W0111.seUnitMaterial = ListCode("UnitMaterial")
        W0111.seUnitPrice = ListCode("UnitPrice")
        W0111.seSubProcess = ListCode("SubProcess")
    End Sub

    Private Sub KEY_COUNT_0111()
        SQL = "SELECT MAX(CAST(K0111_MaterialSeq AS DECIMAL)) AS MAX_MCODE FROM PFK0111 "
        SQL = SQL & " WHERE K0111_BaseComponentBOM = '" & txt_BaseComponentBOM.Data & "' "
        SQL = SQL & " AND K0111_ShoesCode = '" & txt_ShoesCode.Data & "' "
        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_MCODE) Then
            L0111.MaterialSeq = "1"
        Else
            L0111.MaterialSeq = Format(CInt(rd!MAX_MCODE + 1), "0")
        End If

        W0111.MaterialSeq = L0111.MaterialSeq

        rd.Close()
    End Sub

    Private Sub KEY_COUNT_7112()
        SQL = "SELECT MAX(CAST(K7112_UploadNo AS DECIMAL)) AS MAX_MCODE FROM PFK7112 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_MCODE) Then
            L7112.UploadNo = "000000001"
        Else
            L7112.UploadNo = Format(CInt(rd!MAX_MCODE + 1), "000000000")
        End If

        W7112.UploadNo = L7112.UploadNo

        rd.Close()
    End Sub

    Private Sub MAIN_JOB01()

        Dim Starting As Object
        Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

        Try
            Dim BaseComponentBOM As String
            Dim ShoesCode As String

            Dim SizeBegin As String
            Dim SizeEnd As String
            Dim SizeBeginName As String
            Dim SizeEndName As String
            Dim QtySize As String
            Dim MaterialSeq As String
            Dim LossSize As String
            Dim QtyUsage As String

            Dim i As Integer
            Dim j As Integer
            Dim k As Integer

            Dim ColB As Integer
            Dim ColE As Integer
            Dim SpanC As Integer
            Dim Value As Cell

            Value = vS0.ActiveSheet.ActiveCell
            Dim cr() As FarPoint.Win.Spread.Model.CellRange
            cr = vS0.ActiveSheet.GetSelections

            If cr.Length = 0 Then MsgBoxP("No size choose") : Exit Sub

            ColB = cr(0).Column
            ColE = ColB + cr(0).ColumnCount - 1
            SpanC = cr(0).ColumnCount
            If ColE < ColB Then Exit Sub

            SizeBegin = ColB.ToString("00")
            SizeEnd = ColE.ToString("00")

            SizeBeginName = getData(vS0, ColB, 0)
            SizeEndName = getData(vS0, ColE, 0)

            MaterialSeq = getData(vS5_Head, getColumIndex(vS5_Head, "Key_MaterialSeq"), vS5_Head.ActiveSheet.ActiveRowIndex)

            QtySize = getData(vS5_Head, getColumIndex(vS5_Head, "Consumption"), vS5_Head.ActiveSheet.ActiveRowIndex)
            LossSize = getData(vS5_Head, getColumIndex(vS5_Head, "Loss"), vS5_Head.ActiveSheet.ActiveRowIndex)
            QtyUsage = getData(vS5_Head, getColumIndex(vS5_Head, "GrossUsage"), vS5_Head.ActiveSheet.ActiveRowIndex)

            'Dim StrMsg As String = InputBox("Size consumption ?", "Input consumtion!", QtySize)
            'If IsNumeric(StrMsg) = False Then MsgBoxP("Numeric only!") : Exit Sub

            'QtySize = CDecp(StrMsg)

            For i = 0 To vS1.ActiveSheet.RowCount - 1
                If getDataM(vS1, getColumIndex(vS1, "CheckUse"), i) = "1" Then
                    BaseComponentBOM = getDataM(vS1, getColumIndex(vS1, "KEY_BaseComponentBOM"), i)
                    ShoesCode = getDataM(vS1, getColumIndex(vS1, "KEY_ShoesCode"), i)

                    For j = 0 To vS5_Head.ActiveSheet.RowCount - 1
                        If getDataM(vS5_Head, getColumIndex(vS5_Head, "CheckUse"), j) = "1" Then
                            W7113.BaseComponentBOM = BaseComponentBOM
                            W7113.ShoesCode = ShoesCode

                            W7113.MaterialSeq = getData(vS5_Head, getColumIndex(vS5_Head, "Key_MaterialSeq"), j) 'MaterialSeq
                            W7113.QtySize = getData(vS5_Head, getColumIndex(vS5_Head, "Consumption"), j) ' QtySize
                            W7113.LossSize = getData(vS5_Head, getColumIndex(vS5_Head, "Loss"), j) ' QtySize
                            W7113.QtyUsage = getData(vS5_Head, getColumIndex(vS5_Head, "GrossUsage"), j) ' QtySize

                            W7113.SizeBegin = SizeBegin
                            W7113.SizeEnd = SizeEnd
                            W7113.SizeBeginName = SizeBeginName
                            W7113.SizeEndName = SizeEndName

                            If READ_PFK0111(BaseComponentBOM, ShoesCode, MaterialSeq) Then

                                W7113.MaterialCode = D0111.MaterialCode
                                W7113.Color = D0111.Color
                                W7113.ColorName = D0111.ColorName
                                W7113.Height = D0111.Height
                                W7113.Width = D0111.Width
                                W7113.SizeName = D0111.SizeName
                                W7113.Specification = D0111.Specification

                                Call WRITE_PFK7113(W7113)

                                For k = ColB To ColE
                                    W7114.BaseComponentBOM = BaseComponentBOM
                                    W7114.ShoesCode = ShoesCode

                                    W7114.MaterialSeq = W7113.MaterialSeq
                                    W7114.QtySize = W7113.QtySize
                                    W7114.LossSize = W7113.LossSize
                                    W7114.QtyUsage = W7113.QtyUsage
                                    W7114.MaterialCode = D0111.MaterialCode

                                    W7114.Color = D0111.Color
                                    W7114.ColorName = D0111.ColorName
                                    W7114.Height = D0111.Height
                                    W7114.Width = D0111.Width

                                    W7114.seDepartment = D0111.seDepartment
                                    W7114.seShoesStatus = D0111.seShoesStatus
                                    W7114.seSubProcess = D0111.seSubProcess
                                    W7114.seUnitMaterial = D0111.seUnitMaterial
                                    W7114.seUnitPrice = D0111.seUnitPrice

                                    W7114.cdDepartment = D0111.cdDepartment
                                    W7114.cdShoesStatus = D0111.cdShoesStatus
                                    W7114.cdSubProcess = D0111.cdSubProcess
                                    W7114.cdUnitmaterial = D0111.cdUnitmaterial
                                    W7114.cdUnitPrice = D0111.cdUnitPrice

                                    W7114.Price = D0111.Price
                                    W7114.MaterialAMT = D0111.MaterialAMT

                                    W7114.SizeNo = k.ToString("00")
                                    W7114.SizeNoName = getData(vS0, k, 0)

                                    Call WRITE_PFK7114(W7114)
                                Next

                            End If
                        End If
                    Next

                End If
            Next


            Call DATA_SEARCH_VS5()

        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB01!", vbCritical)

        Finally
            Starting.close()
        End Try
    End Sub
#End Region

#Region "Event"

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1

            Case 2
                Me.Dispose()
            Case 3
                If Data_Check() = False Then Exit Sub

                If DataCheck(Me, "PFK7111") = False Then Exit Sub
                Call DATA_UPDATE()
                Call DATA_SEARCH_VS1()

                If ptc_Main.SelectedIndex = 0 Then If chk_FullBase.Checked = True Then Call DATA_MOVE_K0111()
                If ptc_Main.SelectedIndex = 1 Then Call DATA_MOVE_K0111()
                If ptc_Main.SelectedIndex = 5 Then Call DATA_MOVE_K7112()

                Call DATA_SEARCH_VS1()

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

    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs)
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
        Dim xCOL As Integer
        Dim xROW As Integer
        Dim Value As String

        xROW = sender.ActiveSheet.ActiveRowIndex
        xCOL = sender.ActiveSheet.ActiveColumnIndex

        If chk_FullBase.Checked = False And (ptc_Main.SelectedIndex = 0 Or ptc_Main.SelectedIndex = 5 Or (ptc_Main.SelectedIndex = 3 And xCOL <> getColumIndex(sender, "ShoesCode"))) Then
            vS1.ActiveSheet.Columns(getColumIndex(vS1, "CheckUse")).Locked = False
            Exit Sub
        ElseIf chk_FullBase.Checked = False And (ptc_Main.SelectedIndex = 3) And xCOL = getColumIndex(sender, "ShoesCode") Then
            vS1.ActiveSheet.Columns(getColumIndex(vS1, "CheckUse")).Locked = True
        Else
            vS1.ActiveSheet.Columns(getColumIndex(vS1, "CheckUse")).Locked = True

        End If

        'If xCOL <> getColumIndex(sender, "CheckUse") Then Exit Sub

        Value = getData(sender, getColumIndex(sender, "CheckUse"), xROW)

        setDataChkCol(sender, getColumIndex(sender, "CheckUse"), "2")

        If Value <> "1" Then
            setData(sender, getColumIndex(sender, "CheckUse"), xROW, "1", , True)
            txt_BaseComponentBOM.Data = getData(vS1, getColumIndex(vS1, "Key_BaseComponentBOM"), e.Row)
            txt_ShoesCodeFull.Data = getData(vS1, getColumIndex(vS1, "Key_ShoesCode"), e.Row)
        Else
            setData(sender, getColumIndex(sender, "CheckUse"), xROW, "0", , True)
            txt_BaseComponentBOM.Data = ""
            txt_ShoesCodeFull.Data = ""
        End If

        Call ptc_Main_SelectedIndexChanged(sender, e)
    End Sub


    Private Sub cmd_Upload_Click(sender As Object, e As EventArgs)
        Try

            Using OpenFileDialog As OpenFileDialog = Me.GetOpenFileDialog()

                'Open the File Dialog to select the file
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


    Private Sub vS_KeyDown(sender As Object, e As KeyEventArgs) Handles vS5.KeyDown, vS6.KeyDown, vs7.KeyDown
        Dim xCOL As Integer
        Dim xROW As Integer

        xCOL = sender.ActiveSheet.ActiveColumnIndex
        xROW = sender.ActiveSheet.ActiveRowIndex


        Select Case e.KeyCode
            Case Keys.Delete

                Call Select_Message("3", WordConv("PROCESSING"), 2)

                If Msg_Result <> vbYes Then Exit Sub

                Select Case True
                    Case sender Is vS5
                        If READ_PFK7113(getData(sender, getColumIndex(sender, "KEY_Autokey"), xROW)) = True Then
                            W7113 = D7113

                            Call DELETE_PFK7113(W7113)
                            Call DELETE_PFK7114_SIZE_TO_SIZE(W7113)
                        End If

                    Case sender Is vs7
                        SQL = "DELETE FROM PFK7112 "
                        SQL = SQL & " WHERE K7112_UpLoadNo  = '" & getData(sender, getColumIndex(sender, "KEY_UpLoadNo"), xROW) & "' "

                        cmd = New SqlClient.SqlCommand(SQL, cn)
                        cmd.ExecuteNonQuery()

                        Call DATA_SEARCH_VS7()
                        Call DATA_SEARCH_VS8()

                        Exit Sub

                    Case Else


                End Select

                SPR_DEL(sender, xCOL, xROW)

                sender.ActiveSheet.ActiveColumnIndex = xCOL
                sender.ActiveSheet.ActiveRowIndex = xROW
                sender.Focus()

            Case Keys.Enter
                If wJOB = 2 Then Exit Sub
                Exit Select



        End Select
    End Sub

    Private Sub KEY_COUNT()
        Try

            SQL = " SELECT MAX(CAST(K7110_BaseComponentBOM AS DECIMAL)) as MAX_CODE FROM PFK7110 "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W7110.BaseComponentBOM = "000001"
            Else
                W7110.BaseComponentBOM = Format(CIntp(rd!MAX_CODE + 1), "000000")
            End If

            rd.Close()

            txt_BaseComponentBOM.Data = W7110.BaseComponentBOM
            L7110.BaseComponentBOM = W7110.BaseComponentBOM

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub


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

            Case 5
                Call DATA_SEARCH_VS7()
                Call DATA_SEARCH_VS8()

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

            Case 5

                Call DATA_SEARCH_VS7()
                Call DATA_SEARCH_VS8()

        End Select

    End Sub
    Private flagP As Boolean = False
    Private flagQ As Boolean = False
    Private flagW As Boolean = False
    Private flagL As Boolean = False
    Private flagS As Boolean = False

    Private Sub txt_Link7111_btnTitleClick(sender As Object, e As EventArgs) Handles txt_Link0112.btnTitleClick
     
        If ptc_Main.SelectedIndex = 5 Then
            Try

                Using OpenFileDialog As OpenFileDialog = Me.GetOpenFileDialog()

                    'Open the File Dialog to select the file
                    If (OpenFileDialog.ShowDialog(Me) = DialogResult.OK) Then
                        If IO.Path.GetExtension(OpenFileDialog.FileName).ToUpper = ".CSV" Then
                            Dim strEx As String
                            strEx = IO.Path.GetExtension(OpenFileDialog.FileName).ToUpper

                            vS8.Reset()
                            vS8.DataSource = ReadCSV(OpenFileDialog.FileName)
                            ChkUpload = True

                        Else
                            vS8.OpenExcel(OpenFileDialog.FileName)
                            ChkUpload = True
                        End If

                    Else 'Cancel

                        Exit Sub

                    End If

                End Using

            Catch ex As Exception

            End Try
        End If

    End Sub

    Function ReadCSV(ByVal path As String) As System.Data.DataTable

        Try

            Dim sr As New System.IO.StreamReader(path)

            Dim fullFileStr As String = sr.ReadToEnd()

            fullFileStr = fullFileStr.Replace("""""", "''")
            fullFileStr = fullFileStr.Replace("""", "")

            sr.Close()

            sr.Dispose()

            Dim lines As String() = fullFileStr.Split(ControlChars.Lf)

            Dim recs As New System.Data.DataTable()

            Dim sArr As String() = lines(0).Split(","c)

            For Each s As String In sArr

                recs.Columns.Add(New DataColumn())

            Next

            Dim row As DataRow

            Dim finalLine As String = ""

            For Each line As String In lines

                row = recs.NewRow()

                finalLine = line.Replace(Convert.ToString(ControlChars.Cr), "")

                row.ItemArray = finalLine.Split(","c)

                recs.Rows.Add(row)

            Next

            Return recs

        Catch ex As Exception

            Throw ex

        End Try

    End Function
    Private Sub cmd_Link7235_Load(sender As Object, e As EventArgs) Handles cmd_Link7235.btnTitleClick
        If ISUD7235A.Link_ISUD7235A("3", "PFP71080") = False Then Exit Sub
    End Sub
    Private Sub cmd_Refresh_Click(sender As Object, e As EventArgs) Handles cmd_Refresh.Click
        If chk_Compare.Checked Then Call DATA_SEARCH_VS2() Else DATA_SEARCH_VS2_NO()
    End Sub
    Private Sub cmd_Demand_Load(sender As Object, e As EventArgs) Handles cmd_Demand.btnTitleClick
        Try
            Dim UploadNo As String

            UploadNo = getData(vs7, getColumIndex(vs7, "KEY_UploadNo"), vs7.ActiveSheet.ActiveRowIndex)

            Dim strMsg As String

            strMsg = MsgBox("Do you want to matching this" + UploadNo + " with Spec No !")

            If StrMsg <> vbYes Then Exit Sub

            DS1 = PrcDS("USP_PFK7106Q_UPLOAD_CHECK", cn, UploadNo, BaseComponentBOMList)

            If GetDsRc(DS1) > 0 Then
                MsgBoxP("Error in upload!")
                SPR_PRO_NEW(vS8, DS1, "USP_PFK7106Q_UPLOAD_CHECK", "vs8")
                Exit Sub
            End If

            Call PrcExeNoError("USP_PFK7106Q_UPLOAD_MATCHING", cn, UploadNo, BaseComponentBOMList)

            Call DATA_SEARCH_VS1()


        Catch ex As Exception

        End Try

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
            txt_BaseComponentBOM.Data = ""
            txt_ShoesCodeFull.Data = ""
        End If

    End Sub


    Private Sub vS2_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS2.CellDoubleClick
        If e.ColumnHeader Then
            Dim BaseComponentBOM As String
            Dim ShoesCode As String

            If getCellCH(vS2, e.Column, 0) = "" Then Exit Sub

            BaseComponentBOM = Strings.Left(getCellCH(vS2, e.Column, 0), 9)
            ShoesCode = Strings.Right(getCellCH(vS2, e.Column, 0), 3)

       
        End If
    End Sub

    Private Sub vS7_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vs7.CellClick
        If e.ColumnHeader = False Then

            Call DATA_SEARCH_VS8()
        End If
    End Sub
#End Region




End Class