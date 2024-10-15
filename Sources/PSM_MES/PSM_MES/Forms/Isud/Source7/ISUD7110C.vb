Public Class ISUD7110C
#Region "Variable"
    Private wJOB As Integer

    Private W7110 As T7110_AREA
    Private L7110 As T7110_AREA

    Private W7231 As T7231_AREA

    Private W0101 As T0101_AREA
    Private L0101 As T0101_AREA

    Private W7113 As T7113_AREA
    Private L7113 As T7113_AREA

    Private W7114 As T7114_AREA
    Private L7114 As T7114_AREA

    Private W7109 As T7109_AREA
    Private L7109 As T7109_AREA

    Private W7108 As T7108_AREA
    Private L7108 As T7108_AREA

    Private W7112 As T7112_AREA
    Private L7112 As T7112_AREA

    Private W7111 As T7111_AREA
    Private L7111 As T7111_AREA

    Private WRITE_CHK As String
    Private ChkUpload As Boolean = False
    Private cdGroupComponent As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7110K(job As Integer, ShoesCode As String, Optional ByVal TAG As String = "") As Boolean
        Link_ISUD7110K = False

        Me.Tag = TAG
        D7108.ShoesCode = ShoesCode
        D7110.ShoesCode = ShoesCode

        txt_ShoesCode.Data = ShoesCode
        txt_ShoesCode.Code = ShoesCode

        wJOB = job : L7110 = D7110 : L7108 = D7108

        If READ_PFK7106(ShoesCode) = False Then Exit Function

        If D7106.CheckComplete = "1" Then MsgBoxP("Already complete! Đã hoàn thành !", vbInformation)

        Try
            Select Case job
                Case 1
                Case Else

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7110K = isudCHK


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
                Call KEY_COUNT()
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
                Me.Text = "COLOR GROUP ISUD7110K" & " - SEARCH"
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

                cmd_Demand.Visible = False
                txt_Link0112.Visible = False
                cmd_DEL.Visible = False
                tst_All.Visible = False

                vS1.Select()
            Case 3
                Me.Text = "COLOR GROUP ISUD7110K" & " - UPDATE"

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
                Me.Text = "COLOR GROUP ISUD7110K" & " - DELETE"

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
        'Call SPR_SearchType(vS2, SearchType.Material)
        'Call SPR_SearchType(vS2, SearchType.ColorName)

        'Call SPR_SearchType(vS2, SearchType.Component)
        'Call SPR_SearchType(vS2, SearchType.BasicCode, ListCode("GroupComponent"), "cdGroupComponentName")

    End Sub


    Private Sub DATA_INIT()
        Try
            Call D7110_CLEAR()
            W7110 = D7110

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()
        'Call Cms_additem(Cms_1, _
        '              "GROUP COLOR ADD PROCESSING - " & WordConv("INPUT") & "(F5)")

        'vS5.ContextMenuStrip = Cms_1
        'vS5_Head.ContextMenuStrip = Cms_1
        Me.WindowState = FormWindowState.Maximized

        'If REWRITE_PFK9916(D9916) Then
        '    Call SPR_PRO_LOAD(vS2, "DMS", "USP_ISUD7110K_SEARCH_VS2", "vs2")
        'End If

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
                Case Keys.F9 : Call tst_5.PerformClick()
                Case Keys.F10 : Call tst_6.PerformClick()
                Case Keys.F11 : Call tst_7.PerformClick()
            End Select
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Data_Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        DS1 = READ_PFK7110(L7110.BaseComponentBOM, L7110.ShoesCode, cn)

        If GetDsRc(DS1) = 0 Then Exit Function

        Call READER_MOVE(Me, DS1)

        DS1 = Nothing

        DS1 = READ_PFK0101(L7110.BaseComponentBOM, cn)

        If GetDsRc(DS1) = 0 Then Exit Function

        Call READER_MOVE(Me, DS1)

        DS1 = Nothing

        DATA_SEARCH01 = True

    End Function


    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        DS1 = PrcDS("USP_ISUD7110K_SEARCH_VS1", cn, L7110.ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS1, DS1, "USP_ISUD7110K_SEARCH_VS1", "VS1")


            vS1.ActiveSheet.RowCount = 1
            vS1.Enabled = True
            Exit Function
        End If
        SPR_PRO_NEW(vS1, DS1, "USP_ISUD7110K_SEARCH_VS1", "VS1")
        vS1.ActiveSheet.AddSelection(0, 0, 1, 1)

        DATA_SEARCH_VS1 = True

    End Function

    Private Function DATA_SEARCH_VS7() As Boolean
        DATA_SEARCH_VS7 = False

        DS1 = PrcDS("USP_ISUD7110K_SEARCH_VS7", cn, L7110.ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vs7, DS1, "USP_ISUD7110K_SEARCH_VS7", "VS7")

            vs7.Enabled = True
            Exit Function
        End If
        SPR_PRO_NEW(vs7, DS1, "USP_ISUD7110K_SEARCH_VS7", "VS7")

        DATA_SEARCH_VS7 = True

    End Function

    Private Function DATA_SEARCH_VS8() As Boolean
        DATA_SEARCH_VS8 = False
        Dim UploadNo As String

        UploadNo = getData(vs7, getColumIndex(vs7, "KEY_UploadNo"), vs7.ActiveSheet.ActiveRowIndex)

        DS1 = PrcDS("USP_ISUD7110K_SEARCH_VS8", cn, UploadNo)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS8, DS1, "USP_ISUD7110K_SEARCH_VS8", "VS8")

            vS8.Enabled = True
            Exit Function
        End If
        SPR_PRO_NEW(vS8, DS1, "USP_ISUD7110K_SEARCH_VS8", "VS8")
        Call VsSizeRangeNew(vS8, "USP_VS_SIZERANGE_SHOESCODEBASE", "CSizeQty01", L7108.ShoesCode)

        DATA_SEARCH_VS8 = True

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

        DS1 = PrcDS("USP_ISUD7110K_SEARCH_VS2", cn, ShoesCode)


        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS2, DS1, "USP_ISUD7110K_SEARCH_VS2", "VS2")
            Call SPR_SearchType(vS2, SearchType.Material)
            vS2.ActiveSheet.RowCount = 1
            vS2.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS2, DS1, "USP_ISUD7110K_SEARCH_VS2", "VS2")
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
                DS1 = PrcDS("USP_ISUD7110K_SEARCH_VS2_NO", cn, BaseComponentBOMList)

                If GetDsRc(DS1) = 0 Then
                    SPR_PRO_NEW(vS2, DS1, "USP_ISUD7110K_SEARCH_VS2_NO", "VS2")
                    vS2.Enabled = True
                    Exit Function
                End If

                SPR_PRO_NEW(vS2, DS1, "USP_ISUD7110K_SEARCH_VS2_NO", "VS2")

                DATA_SEARCH_VS2_NO = True

            Catch ex As Exception

            Finally
                Starting.close()
            End Try

        End If

    End Function
    Private Function DATA_SEARCH_VS3() As Boolean
        DATA_SEARCH_VS3 = False

        DS1 = PrcDS("USP_ISUD7110K_SEARCH_VS3", cn, L7108.ShoesCode)

        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_ISUD7110K_SEARCH_VS3_INSERT", cn, L7108.ShoesCode)

            SPR_PRO_NEW(vS3, DS2, "USP_ISUD7110K_SEARCH_VS3", "VS3")
            Call VsSizeRangeNew(vS3, "USP_VS_SIZERANGE_SHOESCODEBASE", "CSizeQty01", L7108.ShoesCode)
            vS3.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS3, DS1, "USP_ISUD7110K_SEARCH_VS3", "VS3")
        Call VsSizeRangeNew(vS3, "USP_VS_SIZERANGE_SHOESCODEBASE", "CSizeQty01", L7108.ShoesCode)
        DATA_SEARCH_VS3 = True
    End Function

    Private Function DATA_SEARCH_VS4() As Boolean
        DATA_SEARCH_VS4 = False

        DS1 = PrcDS("USP_ISUD7110K_SEARCH_VS4", cn, L7108.ShoesCode)

        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_ISUD7110K_SEARCH_VS4_INSERT", cn, L7108.ShoesCode)
            SPR_PRO_NEW(vS4, DS2, "USP_ISUD7110K_SEARCH_VS4", "VS4")
            Call VsSizeRangeNew(vS4, "USP_VS_SIZERANGE_SHOESCODEBASE", "CSizeQty01", L7108.ShoesCode)
            vS4.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS4, DS1, "USP_ISUD7110K_SEARCH_VS4", "VS4")
        Call VsSizeRangeNew(vS4, "USP_VS_SIZERANGE_SHOESCODEBASE", "CSizeQty01", L7108.ShoesCode)

        DATA_SEARCH_VS4 = True
    End Function

    Private Function DATA_SEARCH_VS5_HEAD() As Boolean
        DATA_SEARCH_VS5_HEAD = False

        If BaseComponentBOMList() = "" Then Exit Function

        DS1 = PrcDS("USP_ISUD7110K_SEARCH_VS5_HEAD", cn, L7108.ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS5_Head, DS1, "USP_ISUD7110K_SEARCH_VS5_HEAD", "VS5_HEAD")
            vS5_Head.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS5_Head, DS1, "USP_ISUD7110K_SEARCH_VS5_HEAD", "VS5_HEAD")

        DATA_SEARCH_VS5_HEAD = True
    End Function
    Private Function DATA_SEARCH_VS5() As Boolean
        DATA_SEARCH_VS5 = False

        If BaseComponentBOMList() = "" Then Exit Function

        DS1 = PrcDS("USP_ISUD7110K_SEARCH_VS5", cn, L7108.ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS5, DS1, "USP_ISUD7110K_SEARCH_VS5", "VS5")
            Call SPR_SearchType(vS5, SearchType.Material)
            vS5.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS5, DS1, "USP_ISUD7110K_SEARCH_VS5", "VS5")
        Call SPR_SearchType(vS5, SearchType.Material)

        DATA_SEARCH_VS5 = True
    End Function

    Private Function DATA_SEARCH_VS6_HEAD() As Boolean
        DATA_SEARCH_VS6_HEAD = False

        DS1 = PrcDS("USP_ISUD7110K_SEARCH_VS6_HEAD", cn, L7108.ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS6_Head, DS1, "USP_ISUD7110K_SEARCH_VS6_HEAD", "VS6_HEAD")
            vS6_Head.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS6_Head, DS1, "USP_ISUD7110K_SEARCH_VS6_HEAD", "VS6_HEAD")

        DATA_SEARCH_VS6_HEAD = True
    End Function
    Private Function DATA_SEARCH_VS6() As Boolean
        DATA_SEARCH_VS6 = False
        Dim i As Integer
        Dim Value As String = ""

        If Value.Length > 1 Then Value = Strings.Left(Value, Len(Value) - 1)

        DS1 = PrcDS("USP_ISUD7110K_SEARCH_VS6", cn, L7108.ShoesCode, Value)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS6, DS1, "USP_ISUD7110K_SEARCH_VS6", "VS6")
            vS6.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS6, DS1, "USP_ISUD7110K_SEARCH_VS6", "VS6")

        DATA_SEARCH_VS6 = True
    End Function

    Private Function DATA_SEARCH_VS9() As Boolean
        DATA_SEARCH_VS9 = False
        Dim ShoesCode As String

        ShoesCode = getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), vS1.ActiveSheet.ActiveRowIndex)

        DS1 = PrcDS("USP_ISUD7110K_SEARCH_VS9", cn, ShoesCode)


        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS9, DS1, "USP_ISUD7110K_SEARCH_VS9", "VS9")
            vS9.ActiveSheet.RowCount = 1
            vS9.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS9, DS1, "USP_ISUD7110K_SEARCH_VS9", "VS9")


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

                Call PrcExeNoError("USP_PFK7110K_UPLOAD_CLOSSING", cn, UploadNo)
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

            Call READ_PFK7106(L7110.ShoesCode)

            For i = sRow To eRow
                If getData(vS8, pCol, i) = "" Then GoTo skip

                j = j + 1

                Call D7112_CLEAR() : W7112 = D7112

                W7112.NameUpload = D7106.Article
                W7112.DateUpload = Pub.DAT
                W7112.InchargeUpload = Pub.SAW

                W7112.UploadNo = L7112.UploadNo
                W7112.UploadSeq = j

                W7112.BaseComponentBOM = L7110.BaseComponentBOM
                W7112.ShoesCode = L7110.ShoesCode

                Call READ_PFK7108_SHOESCODE(L7110.ShoesCode)
                W7112.BaseComponentBOM = D7108.GroupComponentBOM


                W7112.Dseq = j

                W7112.Spec2 = getData(vS8, WCol, i) ' material
                W7112.Spec3 = getData(vS8, LCol, i) ' allowance
                W7112.Spec4 = getData(vS8, SpCol, i) ' width x height
                W7112.Spec1 = getData(vS8, pCol, i) ' piêc

                If W7112.Spec3.Contains("%") Then
                    Dim Loss As String

                    Loss = W7112.Spec3.IndexOf("%")
                    Loss = Strings.Left(Loss, W7112.Spec3.IndexOf("%"))

                    Loss = StrReverse(Loss)
                    Loss = Trim(Loss)

                    Loss = Strings.Left(Loss, Loss.IndexOf(" "))

                    Loss = Replace(Loss, "%", "")
                    Loss = CIntp(Loss)

                Else
                    W7112.Loss = 0
                End If


                W7112.Specification = getData(vS8, LCol, i) ' piêc
                W7112.Width = getData(vS8, WCol, i) ' piêc

                W7112.ComponentName = getData(vS8, pCol, i) ' piêc

                W7112.QtyComponent = CDecp(getData(vS8, QCol, i))

                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 1, sRow - 1))), CDecp(getData(vS8, Scol + 1, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 2, sRow - 1))), CDecp(getData(vS8, Scol + 2, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 3, sRow - 1))), CDecp(getData(vS8, Scol + 3, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 4, sRow - 1))), CDecp(getData(vS8, Scol + 4, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 5, sRow - 1))), CDecp(getData(vS8, Scol + 5, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 6, sRow - 1))), CDecp(getData(vS8, Scol + 6, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 7, sRow - 1))), CDecp(getData(vS8, Scol + 7, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 8, sRow - 1))), CDecp(getData(vS8, Scol + 8, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 9, sRow - 1))), CDecp(getData(vS8, Scol + 9, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 10, sRow - 1))), CDecp(getData(vS8, Scol + 10, i)))

                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 11, sRow - 1))), CDecp(getData(vS8, Scol + 11, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 12, sRow - 1))), CDecp(getData(vS8, Scol + 12, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 13, sRow - 1))), CDecp(getData(vS8, Scol + 13, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 14, sRow - 1))), CDecp(getData(vS8, Scol + 14, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 15, sRow - 1))), CDecp(getData(vS8, Scol + 15, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 16, sRow - 1))), CDecp(getData(vS8, Scol + 16, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 17, sRow - 1))), CDecp(getData(vS8, Scol + 17, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 18, sRow - 1))), CDecp(getData(vS8, Scol + 18, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 19, sRow - 1))), CDecp(getData(vS8, Scol + 19, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 20, sRow - 1))), CDecp(getData(vS8, Scol + 20, i)))

                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 21, sRow - 1))), CDecp(getData(vS8, Scol + 21, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 22, sRow - 1))), CDecp(getData(vS8, Scol + 22, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 23, sRow - 1))), CDecp(getData(vS8, Scol + 23, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 24, sRow - 1))), CDecp(getData(vS8, Scol + 24, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 25, sRow - 1))), CDecp(getData(vS8, Scol + 25, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 26, sRow - 1))), CDecp(getData(vS8, Scol + 26, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 27, sRow - 1))), CDecp(getData(vS8, Scol + 27, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 28, sRow - 1))), CDecp(getData(vS8, Scol + 28, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 29, sRow - 1))), CDecp(getData(vS8, Scol + 29, i)))
                Call DATA_MATCHING(READ_PFK7104_SZNO(D7106.SizeRange, FormatCutAllSize(getData(vS8, Scol + 30, sRow - 1))), CDecp(getData(vS8, Scol + 30, i)))

                'W7112.CSizeQty11 = CDecp(getData(vS8, Scol + 11, i))
                'W7112.CSizeQty12 = CDecp(getData(vS8, Scol + 12, i))
                'W7112.CSizeQty13 = CDecp(getData(vS8, Scol + 13, i))
                'W7112.CSizeQty14 = CDecp(getData(vS8, Scol + 14, i))
                'W7112.CSizeQty15 = CDecp(getData(vS8, Scol + 15, i))
                'W7112.CSizeQty16 = CDecp(getData(vS8, Scol + 16, i))
                'W7112.CSizeQty17 = CDecp(getData(vS8, Scol + 17, i))
                'W7112.CSizeQty18 = CDecp(getData(vS8, Scol + 18, i))
                'W7112.CSizeQty19 = CDecp(getData(vS8, Scol + 19, i))
                'W7112.CSizeQty20 = CDecp(getData(vS8, Scol + 20, i))

                'W7112.CSizeQty21 = CDecp(getData(vS8, Scol + 21, i))
                'W7112.CSizeQty22 = CDecp(getData(vS8, Scol + 22, i))
                'W7112.CSizeQty23 = CDecp(getData(vS8, Scol + 23, i))
                'W7112.CSizeQty24 = CDecp(getData(vS8, Scol + 24, i))
                'W7112.CSizeQty25 = CDecp(getData(vS8, Scol + 25, i))
                'W7112.CSizeQty26 = CDecp(getData(vS8, Scol + 26, i))
                'W7112.CSizeQty27 = CDecp(getData(vS8, Scol + 27, i))
                'W7112.CSizeQty28 = CDecp(getData(vS8, Scol + 28, i))
                'W7112.CSizeQty29 = CDecp(getData(vS8, Scol + 29, i))
                'W7112.CSizeQty30 = CDecp(getData(vS8, Scol + 30, i))

                W7112.Remark = Pub.SAW & Pub.TIM
                If chk_Yield.Checked Then W7112.CheckType = "1" Else W7112.CheckType = "2"

                Call WRITE_PFK7112(W7112)
skip:
            Next

            Call PrcExeNoError("USP_PFK7110K_UPLOAD_CLOSSING", cn, W7112.UploadNo)
            ChkUpload = False
            Call DATA_SEARCH_VS7()

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub
    Private Function DATA_MATCHING(Value As String, ValueData As String) As Boolean
        DATA_MATCHING = False

        Select Case Value
            Case "01" : W7112.CSizeQty01 = ValueData
            Case "02" : W7112.CSizeQty02 = ValueData
            Case "03" : W7112.CSizeQty03 = ValueData
            Case "04" : W7112.CSizeQty04 = ValueData
            Case "05" : W7112.CSizeQty05 = ValueData
            Case "06" : W7112.CSizeQty06 = ValueData
            Case "07" : W7112.CSizeQty07 = ValueData
            Case "08" : W7112.CSizeQty08 = ValueData
            Case "09" : W7112.CSizeQty09 = ValueData
            Case "10" : W7112.CSizeQty10 = ValueData

            Case "11" : W7112.CSizeQty11 = ValueData
            Case "12" : W7112.CSizeQty12 = ValueData
            Case "13" : W7112.CSizeQty13 = ValueData
            Case "14" : W7112.CSizeQty14 = ValueData
            Case "15" : W7112.CSizeQty15 = ValueData
            Case "16" : W7112.CSizeQty16 = ValueData
            Case "17" : W7112.CSizeQty17 = ValueData
            Case "18" : W7112.CSizeQty18 = ValueData
            Case "19" : W7112.CSizeQty19 = ValueData
            Case "20" : W7112.CSizeQty20 = ValueData

            Case "21" : W7112.CSizeQty21 = ValueData
            Case "22" : W7112.CSizeQty22 = ValueData
            Case "23" : W7112.CSizeQty23 = ValueData
            Case "24" : W7112.CSizeQty24 = ValueData
            Case "25" : W7112.CSizeQty25 = ValueData
            Case "26" : W7112.CSizeQty26 = ValueData
            Case "27" : W7112.CSizeQty27 = ValueData
            Case "28" : W7112.CSizeQty28 = ValueData
            Case "29" : W7112.CSizeQty29 = ValueData
            Case "30" : W7112.CSizeQty30 = ValueData


        End Select



    End Function
    Private Function KEY_COUNT_NO_2(BaseComponentBOM As String) As String
        KEY_COUNT_NO_2 = ""

        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 2)


        SQL = "SELECT MAX(CAST(K7110_BaseComponentBOM AS DECIMAL)) AS MAX_MCODE FROM PFK7110 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_MCODE) Then
            KEY_COUNT_NO_2 = "000001"
        Else
            KEY_COUNT_NO_2 = FormatP(CIntp(rd!MAX_MCODE + 1), "000000")
        End If

        rd.Close()

    End Function

    Private Sub KEY_COUNT()
        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 2)


        SQL = "SELECT MAX(CAST(K7110_BaseComponentBOM AS DECIMAL)) AS MAX_MCODE FROM PFK7110 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_MCODE) Then
            L7110.BaseComponentBOM = "000001"
        Else
            L7110.BaseComponentBOM = FormatP(CIntp(rd!MAX_MCODE + 1), "000000")
        End If

        W7110.BaseComponentBOM = L7110.BaseComponentBOM

        txt_BaseComponentBOMFull.Data = L7110.BaseComponentBOM

        rd.Close()

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

    Private Function CheckExist(BaseComponentBOM As String, ShoesCode As String) As Boolean
        CheckExist = False

        Dim RC As Integer
        Try
            rd = PrcDR("USP_ISUD0101A_SEARCH_VS00_CHECKEXIST", cn, BaseComponentBOM, ShoesCode)

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

    Private Function DATA_MOVE_K7110() As Boolean
        Dim i As Integer

        DATA_MOVE_K7110 = False



        For i = 0 To vS1.ActiveSheet.RowCount - 1
            If READ_PFK7108_SHOESCODE(getData(vS1, getColumIndex(vS1, "ShoesCode"), i)) Then
                If READ_PFK7110(D7108.GroupComponentBOM, getData(vS1, getColumIndex(vS1, "ShoesCode"), i)) = False Then
                    W7110.BaseComponentBOM = D7108.GroupComponentBOM
                    W7110.ShoesCode = D7108.ShoesCode
                    W7110.InchargeInsert = Pub.SAW
                    W7110.DateInsert = Pub.DAT
                    W7110.BaseName = W7110.ShoesCode

                    Call WRITE_PFK7110(W7110)

                End If
            End If
        Next


    End Function

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

                        If READ_PFK7109(W7109.GroupComponentBOM, W7109.GroupComponentSeq) = False Then
                            W7109 = D7109

                            W7109.selGroupComponent = ListCode("GroupComponent")
                            W7109.seDepartment = ListCode("Department")
                            W7109.seShoesStatus = ListCode("ShoesStatus")
                            W7109.seUnitMaterial = ListCode("UnitMaterial")
                            W7109.seSubProcess = ListCode("SubProcess")
                            W7109.seSpecialProcess = ListCode("SpecialProcess")

                            W7109.cdSubProcess = getData(vS2, getColumIndex(vS2, "cdSubProcess"), i)

                            W7109.Loss = CIntp(getData(vS2, getColumIndex(vS2, "Loss"), i))

                            W7109.Dseq = j
                            W7109.GrossUsage = W7109.Consumption * (1 + W7109.Loss / 100)

                            Call REWRITE_PFK7109(W7109)
                        End If
                    Next
                End If

          
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
        Exit Sub

        Dim Starting As Object

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

            Dim ColB As String
            Dim ColE As String

            Dim SpanC As Integer
            Dim Value As Cell

            ColB = InputBox("Size Begin, Pls!")
            ColE = InputBox("Size End, Pls!")

            Call READ_PFK7106(txt_ShoesCode.Code)

            SizeBegin = READ_PFK7104_SZNO(D7106.SizeRange, ColB)
            SizeEnd = READ_PFK7104_SZNO(D7106.SizeRange, ColE)

            If CIntp(SizeBegin) = 0 Or CIntp(SizeEnd) = 0 Then MsgBoxP("Wrong size!") : GoTo next1
            If CIntp(SizeBegin) >= CIntp(SizeEnd) Then MsgBox("Wrong position!") : GoTo next1

            Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

            MaterialSeq = getData(vS5_Head, getColumIndex(vS5_Head, "Key_MaterialSeq"), vS5_Head.ActiveSheet.ActiveRowIndex)

            QtySize = getData(vS5_Head, getColumIndex(vS5_Head, "Consumption"), vS5_Head.ActiveSheet.ActiveRowIndex)
            LossSize = getData(vS5_Head, getColumIndex(vS5_Head, "Loss"), vS5_Head.ActiveSheet.ActiveRowIndex)
            QtyUsage = getData(vS5_Head, getColumIndex(vS5_Head, "GrossUsage"), vS5_Head.ActiveSheet.ActiveRowIndex)

            For i = 0 To vS1.ActiveSheet.RowCount - 1
                If getDataM(vS1, getColumIndex(vS1, "DCHK"), i) = "1" Then

                    BaseComponentBOM = getDataM(vS1, getColumIndex(vS1, "KEY_BaseComponentBOM"), i)
                    ShoesCode = getDataM(vS1, getColumIndex(vS1, "KEY_ShoesCode"), i)

                    For j = 0 To vS5_Head.ActiveSheet.RowCount - 1
                        If getDataM(vS5_Head, getColumIndex(vS5_Head, "CheckUse"), j) = "1" Then

                            W7113.ShoesCode = ShoesCode

                            If READ_PFK7108_SHOESCODE(ShoesCode) = False Then Exit Sub
                            BaseComponentBOM = D7108.GroupComponentBOM
                            MaterialSeq = getData(vS5_Head, getColumIndex(vS5_Head, "KEY_GroupComponentSeq"), j) 'MaterialSeq

                            W7113.BaseComponentBOM = BaseComponentBOM

                            W7113.MaterialSeq = getData(vS5_Head, getColumIndex(vS5_Head, "KEY_GroupComponentSeq"), j) 'MaterialSeq
                            W7113.QtySize = getData(vS5_Head, getColumIndex(vS5_Head, "Consumption"), j) ' QtySize
                            W7113.LossSize = getData(vS5_Head, getColumIndex(vS5_Head, "Loss"), j) ' QtySize
                            W7113.QtyUsage = getData(vS5_Head, getColumIndex(vS5_Head, "GrossUsage"), j) ' QtySize

                            W7113.SizeBegin = SizeBegin
                            W7113.SizeEnd = SizeEnd
                            W7113.SizeBeginName = ColB
                            W7113.SizeEndName = ColE

                            If READ_PFK7109(BaseComponentBOM, MaterialSeq) Then
                                W7113.ComponentName = D7109.ComponentName

                                W7113.MaterialCode = D7109.MaterialCode
                                W7113.Color = D7109.ColorName
                                W7113.ColorName = D7109.ColorName
                                W7113.Height = D7109.Height
                                W7113.Width = D7109.Width
                                W7113.SizeName = D7109.SizeName
                                W7113.Specification = D7109.Specification

                                W7113.QtySize = D7109.QtyComponent
                                W7113.QtyUsage = D7109.GrossUsage
                                W7113.LossSize = D7109.Loss

                                Call WRITE_PFK7113(W7113)

                                For k = ColB To ColE
                                    W7114.BaseComponentBOM = BaseComponentBOM
                                    W7114.ShoesCode = ShoesCode


                                    W7114.MaterialSeq = W7113.MaterialSeq
                                    W7114.QtySize = W7113.QtySize
                                    W7114.LossSize = W7113.LossSize
                                    W7114.QtyUsage = W7113.QtyUsage
                                    W7114.MaterialCode = D7109.MaterialCode

                                    W7114.Color = D7109.ColorName
                                    W7114.ColorName = D7109.ColorName
                                    W7114.Height = D7109.Height
                                    W7114.Width = D7109.Width

                                    W7114.seDepartment = D7109.seDepartment
                                    W7114.seShoesStatus = D7109.seShoesStatus
                                    W7114.seSubProcess = D7109.seSubProcess
                                    W7114.seUnitMaterial = D7109.seUnitMaterial
                                    W7114.seUnitPrice = D7109.seUnitPrice

                                    W7114.cdDepartment = D7109.cdDepartment
                                    W7114.cdShoesStatus = D7109.cdShoesStatus
                                    W7114.cdSubProcess = D7109.cdSubProcess
                                    W7114.cdUnitmaterial = D7109.cdUnitMaterial
                                    W7114.cdUnitPrice = D7109.cdUnitPrice

                                    W7114.Price = D7109.Price
                                    W7114.MaterialAMT = D7109.MaterialAMT

                                    W7114.QtySize = D7109.QtyComponent
                                    W7114.QtyUsage = D7109.GrossUsage
                                    W7114.LossSize = D7109.Loss

                                    W7114.SizeNo = k.ToString("00")

                                    Call WRITE_PFK7114(W7114)
                                Next

                            End If
                        End If
                    Next

                End If
            Next


            Call DATA_SEARCH_VS5()
next1:
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB01!", vbCritical)

        Finally
            Starting.close()
        End Try
    End Sub


    Private Sub MAIN_JOB02()
        If wJOB = 2 Then Exit Sub

        Dim Starting As Object

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

            Dim ColB As String
            Dim ColE As String

            Dim SpanC As Integer
            Dim Value As Cell


            Call READ_PFK7106(txt_ShoesCode.Code)

            SizeBegin = READ_PFK7104_SIZENAMEMIN(D7106.SizeRange)
            SizeEnd = READ_PFK7104_SIZENAMEMAX(D7106.SizeRange)

            ColB = READ_PFK7104_SIZENAME(D7106.SizeRange, SizeBegin)
            ColE = READ_PFK7104_SIZENAME(D7106.SizeRange, SizeEnd)

            Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

            MaterialSeq = getData(vS2, getColumIndex(vS2, "Key_MaterialSeq"), vS2.ActiveSheet.ActiveRowIndex)

            QtySize = getData(vS2, getColumIndex(vS2, "Consumption"), vS2.ActiveSheet.ActiveRowIndex)
            LossSize = getData(vS2, getColumIndex(vS2, "Loss"), vS2.ActiveSheet.ActiveRowIndex)
            QtyUsage = getData(vS2, getColumIndex(vS2, "GrossUsage"), vS2.ActiveSheet.ActiveRowIndex)

            For i = 0 To vS1.ActiveSheet.RowCount - 1
                If getDataM(vS1, getColumIndex(vS1, "CheckParent"), i) = "1" Then

                    BaseComponentBOM = getDataM(vS1, getColumIndex(vS1, "KEY_BaseComponentBOM"), i)
                    ShoesCode = getDataM(vS1, getColumIndex(vS1, "KEY_ShoesCode"), i)

                    For j = 0 To vS2.ActiveSheet.RowCount - 1
                        If vS2.ActiveSheet.ActiveRowIndex = j Then

                            W7113.ShoesCode = ShoesCode

                            If READ_PFK7108_SHOESCODE(ShoesCode) = False Then Exit Sub
                            BaseComponentBOM = D7108.GroupComponentBOM
                            MaterialSeq = getData(vS2, getColumIndex(vS2, "KEY_GroupComponentSeq"), j) 'MaterialSeq

                            W7113.BaseComponentBOM = BaseComponentBOM

                            W7113.MaterialSeq = getData(vS2, getColumIndex(vS2, "KEY_GroupComponentSeq"), j) 'MaterialSeq
                            W7113.QtySize = getData(vS2, getColumIndex(vS2, "Consumption"), j) ' QtySize
                            W7113.LossSize = getData(vS2, getColumIndex(vS2, "Loss"), j) ' QtySize
                            W7113.QtyUsage = getData(vS2, getColumIndex(vS2, "GrossUsage"), j) ' QtySize

                            W7113.SizeBegin = SizeBegin
                            W7113.SizeEnd = SizeEnd
                            W7113.SizeBeginName = ColB
                            W7113.SizeEndName = ColE

                            If READ_PFK7109(BaseComponentBOM, MaterialSeq) Then
                                W7113.ComponentName = D7109.ComponentName

                                W7113.MaterialCode = D7109.MaterialCode
                                W7113.Color = D7109.ColorName
                                W7113.ColorName = D7109.ColorName
                                W7113.Height = D7109.Height
                                W7113.Width = D7109.Width
                                W7113.SizeName = D7109.SizeName
                                W7113.Specification = D7109.Specification

                                W7113.Specification = "1"

                                Call WRITE_PFK7113(W7113)

                                'For k = ColB To ColE
                                '    W7114.BaseComponentBOM = BaseComponentBOM
                                '    W7114.ShoesCode = ShoesCode


                                '    W7114.MaterialSeq = W7113.MaterialSeq
                                '    W7114.QtySize = W7113.QtySize
                                '    W7114.LossSize = W7113.LossSize
                                '    W7114.QtyUsage = W7113.QtyUsage
                                '    W7114.MaterialCode = D7109.MaterialCode

                                '    W7114.Color = D7109.ColorName
                                '    W7114.ColorName = D7109.ColorName
                                '    W7114.Height = D7109.Height
                                '    W7114.Width = D7109.Width

                                '    W7114.seDepartment = D7109.seDepartment
                                '    W7114.seShoesStatus = D7109.seShoesStatus
                                '    W7114.seSubProcess = D7109.seSubProcess
                                '    W7114.seUnitMaterial = D7109.seUnitMaterial
                                '    W7114.seUnitPrice = D7109.seUnitPrice

                                '    W7114.cdDepartment = D7109.cdDepartment
                                '    W7114.cdShoesStatus = D7109.cdShoesStatus
                                '    W7114.cdSubProcess = D7109.cdSubProcess
                                '    W7114.cdUnitmaterial = D7109.cdUnitMaterial
                                '    W7114.cdUnitPrice = D7109.cdUnitPrice

                                '    W7114.Price = D7109.Price
                                '    W7114.MaterialAMT = D7109.MaterialAMT

                                '    W7114.SizeNo = k.ToString("00")

                                '    Call WRITE_PFK7114(W7114)
                                'Next

                            End If
                        End If
                    Next

                End If
            Next

next1:
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB01!", vbCritical)

        Finally
            Starting.close()
        End Try
    End Sub


    Private Sub MAIN_JOB03()
        If wJOB = 2 Then Exit Sub

        Dim Starting As Object

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

            Dim ColB As String
            Dim ColE As String

            Dim SpanC As Integer
            Dim Value As Cell


            Call READ_PFK7106(txt_ShoesCode.Code)

            SizeBegin = READ_PFK7104_SIZENAMEMIN(D7106.SizeRange)
            SizeEnd = READ_PFK7104_SIZENAMEMAX(D7106.SizeRange)

            ColB = READ_PFK7104_SIZENAME(D7106.SizeRange, SizeBegin)
            ColE = READ_PFK7104_SIZENAME(D7106.SizeRange, SizeEnd)

            Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

            MaterialSeq = getData(vS2, getColumIndex(vS2, "Key_MaterialSeq"), vS2.ActiveSheet.ActiveRowIndex)

            QtySize = getData(vS2, getColumIndex(vS2, "Consumption"), vS2.ActiveSheet.ActiveRowIndex)
            LossSize = getData(vS2, getColumIndex(vS2, "Loss"), vS2.ActiveSheet.ActiveRowIndex)
            QtyUsage = getData(vS2, getColumIndex(vS2, "GrossUsage"), vS2.ActiveSheet.ActiveRowIndex)

            For i = 0 To vS1.ActiveSheet.RowCount - 1
                BaseComponentBOM = getDataM(vS1, getColumIndex(vS1, "KEY_BaseComponentBOM"), i)
                ShoesCode = getDataM(vS1, getColumIndex(vS1, "KEY_ShoesCode"), i)

                For j = 0 To vS2.ActiveSheet.RowCount - 1
                    If vS2.ActiveSheet.ActiveRowIndex = j Then
                        W7113.ShoesCode = ShoesCode

                        If READ_PFK7108_SHOESCODE(ShoesCode) = False Then Exit Sub
                        BaseComponentBOM = D7108.GroupComponentBOM
                        MaterialSeq = getData(vS2, getColumIndex(vS2, "KEY_GroupComponentSeq"), j) 'MaterialSeq

                        W7113.BaseComponentBOM = BaseComponentBOM

                        W7113.MaterialSeq = getData(vS2, getColumIndex(vS2, "KEY_GroupComponentSeq"), j) 'MaterialSeq
                        W7113.QtySize = getData(vS2, getColumIndex(vS2, "Consumption"), j) ' QtySize
                        W7113.LossSize = getData(vS2, getColumIndex(vS2, "Loss"), j) ' QtySize
                        W7113.QtyUsage = getData(vS2, getColumIndex(vS2, "GrossUsage"), j) ' QtySize

                        W7113.SizeBegin = SizeBegin
                        W7113.SizeEnd = SizeEnd
                        W7113.SizeBeginName = ColB
                        W7113.SizeEndName = ColE

                        If READ_PFK7109(BaseComponentBOM, MaterialSeq) Then
                            W7113.ComponentName = D7109.ComponentName

                            W7113.MaterialCode = D7109.MaterialCode
                            W7113.Color = D7109.ColorName
                            W7113.ColorName = D7109.ColorName
                            W7113.Height = D7109.Height
                            W7113.Width = D7109.Width
                            W7113.SizeName = D7109.SizeName
                            W7113.Specification = "2"

                            Call WRITE_PFK7113(W7113)

                        End If
                    End If
                Next

            Next

next1:
        Catch ex As Exception
            MsgBoxP("Error in MAIN_JOB01!", vbCritical)

        Finally
            Starting.close()
        End Try
    End Sub

#End Region

#Region "Event"
    Private Function DATA_MOVE_K7111(sender As Object) As Boolean
        DATA_MOVE_K7111 = False
        Try
            Dim i As Integer
            Dim j As Integer

            Dim colstart As Integer

            j = 0

            colstart = getColumIndex(sender, "CSizeQty01")

            For i = 0 To sender.ActiveSheet.RowCount - 1
                j = j + 1

                If READ_PFK7111(getData(sender, getColumIndex(sender, "Key_ShoesCode"), i), getData(sender, getColumIndex(sender, "Key_MaterialSeq"), i)) = True Then
                    W7111 = D7111
                    W7111.QtyComponent = CDblp(getData(sender, getColumIndex(sender, "QtyComponent"), i))

                    W7111.CSizeQty01 = CDblp(getData(sender, colstart, i))
                    W7111.CSizeQty02 = CDblp(getData(sender, colstart + 1, i))
                    W7111.CSizeQty03 = CDblp(getData(sender, colstart + 2, i))
                    W7111.CSizeQty04 = CDblp(getData(sender, colstart + 3, i))
                    W7111.CSizeQty05 = CDblp(getData(sender, colstart + 4, i))
                    W7111.CSizeQty06 = CDblp(getData(sender, colstart + 5, i))
                    W7111.CSizeQty07 = CDblp(getData(sender, colstart + 6, i))
                    W7111.CSizeQty08 = CDblp(getData(sender, colstart + 7, i))
                    W7111.CSizeQty09 = CDblp(getData(sender, colstart + 8, i))
                    W7111.CSizeQty10 = CDblp(getData(sender, colstart + 9, i))
                    W7111.CSizeQty11 = CDblp(getData(sender, colstart + 10, i))
                    W7111.CSizeQty12 = CDblp(getData(sender, colstart + 11, i))
                    W7111.CSizeQty13 = CDblp(getData(sender, colstart + 12, i))
                    W7111.CSizeQty14 = CDblp(getData(sender, colstart + 13, i))
                    W7111.CSizeQty15 = CDblp(getData(sender, colstart + 14, i))
                    W7111.CSizeQty16 = CDblp(getData(sender, colstart + 15, i))
                    W7111.CSizeQty17 = CDblp(getData(sender, colstart + 16, i))
                    W7111.CSizeQty18 = CDblp(getData(sender, colstart + 17, i))
                    W7111.CSizeQty19 = CDblp(getData(sender, colstart + 18, i))
                    W7111.CSizeQty20 = CDblp(getData(sender, colstart + 19, i))
                    W7111.CSizeQty21 = CDblp(getData(sender, colstart + 20, i))
                    W7111.CSizeQty22 = CDblp(getData(sender, colstart + 21, i))
                    W7111.CSizeQty23 = CDblp(getData(sender, colstart + 22, i))
                    W7111.CSizeQty24 = CDblp(getData(sender, colstart + 23, i))
                    W7111.CSizeQty25 = CDblp(getData(sender, colstart + 24, i))
                    W7111.CSizeQty26 = CDblp(getData(sender, colstart + 25, i))
                    W7111.CSizeQty27 = CDblp(getData(sender, colstart + 26, i))
                    W7111.CSizeQty28 = CDblp(getData(sender, colstart + 27, i))
                    W7111.CSizeQty29 = CDblp(getData(sender, colstart + 28, i))
                    W7111.CSizeQty30 = CDblp(getData(sender, colstart + 29, i))

                    If REWRITE_PFK7111(W7111) Then

                    End If
                    isudCHK = True

                Else

                    W7111.ShoesCode = getData(sender, getColumIndex(sender, "Key_ShoesCode"), i)
                    W7111.MaterialSeq = getData(sender, getColumIndex(sender, "Key_MaterialSeq"), i)

                    W7111.QtyComponent = CDblp(getData(sender, getColumIndex(sender, "QtyComponent"), i))

                    W7111.CSizeQty01 = CDblp(getData(sender, colstart, i))
                    W7111.CSizeQty02 = CDblp(getData(sender, colstart + 1, i))
                    W7111.CSizeQty03 = CDblp(getData(sender, colstart + 2, i))
                    W7111.CSizeQty04 = CDblp(getData(sender, colstart + 3, i))
                    W7111.CSizeQty05 = CDblp(getData(sender, colstart + 4, i))
                    W7111.CSizeQty06 = CDblp(getData(sender, colstart + 5, i))
                    W7111.CSizeQty07 = CDblp(getData(sender, colstart + 6, i))
                    W7111.CSizeQty08 = CDblp(getData(sender, colstart + 7, i))
                    W7111.CSizeQty09 = CDblp(getData(sender, colstart + 8, i))
                    W7111.CSizeQty10 = CDblp(getData(sender, colstart + 9, i))
                    W7111.CSizeQty11 = CDblp(getData(sender, colstart + 10, i))
                    W7111.CSizeQty12 = CDblp(getData(sender, colstart + 11, i))
                    W7111.CSizeQty13 = CDblp(getData(sender, colstart + 12, i))
                    W7111.CSizeQty14 = CDblp(getData(sender, colstart + 13, i))
                    W7111.CSizeQty15 = CDblp(getData(sender, colstart + 14, i))
                    W7111.CSizeQty16 = CDblp(getData(sender, colstart + 15, i))
                    W7111.CSizeQty17 = CDblp(getData(sender, colstart + 16, i))
                    W7111.CSizeQty18 = CDblp(getData(sender, colstart + 17, i))
                    W7111.CSizeQty19 = CDblp(getData(sender, colstart + 18, i))
                    W7111.CSizeQty20 = CDblp(getData(sender, colstart + 19, i))
                    W7111.CSizeQty21 = CDblp(getData(sender, colstart + 20, i))
                    W7111.CSizeQty22 = CDblp(getData(sender, colstart + 21, i))
                    W7111.CSizeQty23 = CDblp(getData(sender, colstart + 22, i))
                    W7111.CSizeQty24 = CDblp(getData(sender, colstart + 23, i))
                    W7111.CSizeQty25 = CDblp(getData(sender, colstart + 24, i))
                    W7111.CSizeQty26 = CDblp(getData(sender, colstart + 25, i))
                    W7111.CSizeQty27 = CDblp(getData(sender, colstart + 26, i))
                    W7111.CSizeQty28 = CDblp(getData(sender, colstart + 27, i))
                    W7111.CSizeQty29 = CDblp(getData(sender, colstart + 28, i))
                    W7111.CSizeQty30 = CDblp(getData(sender, colstart + 29, i))

                    If WRITE_PFK7111(W7111) Then

                    End If

                    isudCHK = True

                End If
skip:
            Next

            DATA_MOVE_K7111 = True

        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE03")
        End Try

    End Function
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If wJOB = 2 Then Exit Sub

        Select Case wJOB
            Case 1
                If ptc_Main.SelectedIndex = 0 Then
                    Call KEY_COUNT()
                    Call DATA_MOVE_K7109()
                    Call DATA_MOVE_K7110()
                    Call DATA_SEARCH_VS2()
                    vS1.Select()

                End If
            Case 2
                Me.Dispose()
            Case 3
                If Data_Check() = False Then Exit Sub
                Call DATA_MOVE_K7110()
                If ptc_Main.SelectedIndex = 0 Then Call DATA_MOVE_K7109() : Call DemandCalculation()
                If ptc_Main.SelectedIndex = 1 Then Call DATA_MOVE_K7111(vS3)
                If ptc_Main.SelectedIndex = 2 Then Call DATA_MOVE_K7111(vS4)

                If ptc_Main.SelectedIndex = 3 Then Call DATA_MOVE_K7113()
                If ptc_Main.SelectedIndex = 5 Then Call DATA_MOVE_K7112() : Call cmd_Demand.PeaceButton1.PerformClick()

            Case 4
                Call DATA_DELETE()

        End Select
    End Sub

    Private Sub DATA_MOVE_K7113()
        Try
            Dim i As Integer

            For i = 0 To vS5.ActiveSheet.RowCount - 1

                W7109.GroupComponentSeq = CIntp(getData(vS5, getColumIndex(vS5, "KEY_Autokey"), i))

                If READ_PFK7113(getData(vS5, getColumIndex(vS5, "KEY_Autokey"), i)) = True Then
                    W7113 = D7113

                    W7113.MaterialCode = getData(vS5, getColumIndex(vS5, "MaterialCode"), i)

                    W7113.SizeBeginName = getData(vS5, getColumIndex(vS5, "SizeBeginName"), i)
                    W7113.SizeEndName = getData(vS5, getColumIndex(vS5, "SizeEndName"), i)

                    W7113.ColorName = getData(vS5, getColumIndex(vS5, "ColorName"), i)
                    W7113.Color = getData(vS5, getColumIndex(vS5, "Color"), i)

                    W7113.QtySize = getData(vS5, getColumIndex(vS5, "QtySize"), i)
                    W7113.LossSize = getData(vS5, getColumIndex(vS5, "LossSize"), i)
                    W7113.QtyUsage = getData(vS5, getColumIndex(vS5, "QtyUsage"), i)


                    Call REWRITE_PFK7113(W7113)

                End If
            Next

        Catch ex As Exception

        End Try
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
        Else
            vS1.ActiveSheet.OperationMode = OperationMode.SingleSelect
        End If

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

    Private Sub vS1_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles vS1.ButtonClicked
        Try
            vS1.ActiveSheet.ActiveRowIndex = e.Row
            vS1.ActiveSheet.ActiveColumnIndex = e.Column
            Select Case e.Column
                Case getColumIndex(vS1, "CLShoesCode")

                    HLP7106A.Link_HLP7106A("", "")
                    If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub
                    If READ_PFK7106(hlp0000SeVaTt) Then
                        setData(vS1, getColumIndex(vS1, "Style"), e.Row, D7106.Style)
                        setData(vS1, getColumIndex(vS1, "ShoesCode"), e.Row, D7106.ShoesCode)

                        setData(vS1, getColumIndex(vS1, "CustSpecNo"), e.Row, D7106.CustSpecNo)
                        setData(vS1, getColumIndex(vS1, "ProductCode"), e.Row, D7106.ProductCode)

                        'setData(vS1, getColumIndex(vS1, "SizeRange"), e.Row, D7106.SizeRange)

                        'If READ_PFK7104(D7106.SizeRange) Then
                        '    setData(vS1, getColumIndex(vS1, "SizeRangeName"), e.Row, D7104.SizeRangeName)
                        'End If

                        setData(vS1, getColumIndex(vS1, "Article"), e.Row, D7106.Article)
                        setData(vS1, getColumIndex(vS1, "Line"), e.Row, D7106.Line)
                        setData(vS1, getColumIndex(vS1, "ColorName"), e.Row, D7106.ColorName)
                        setData(vS1, getColumIndex(vS1, "ColorCode"), e.Row, D7106.ColorCode)

                        setData(vS1, getColumIndex(vS1, "MCODE"), e.Row, D7106.MCODE)
                        setData(vS1, getColumIndex(vS1, "MCODEName"), e.Row, D7106.MCODEName)

                        setData(vS1, getColumIndex(vS1, "MoldCode"), e.Row, D7106.MoldCode)

                        If READ_PFK7231(D7106.MoldCode) Then
                            setData(vS1, getColumIndex(vS1, "MoldName"), e.Row, D7231.MaterialName)
                        End If

                        setData(vS1, getColumIndex(vS1, "LastCode"), e.Row, D7106.LastCode)

                        If READ_PFK7231(D7106.LastCode) Then
                            setData(vS1, getColumIndex(vS1, "LastName"), e.Row, D7231.MaterialName)
                        End If

                        setData(vS1, getColumIndex(vS1, "cdSpecState"), e.Row, D7106.cdSpecState)

                        If READ_PFK7171(ListCode("SpecState"), D7106.cdSpecState) Then
                            setData(vS1, getColumIndex(vS1, "cdSpecStateName"), e.Row, D7171.BasicName)
                        End If

                    End If

            End Select
        Catch ex As Exception
            MsgBoxP("vS1_ButtonClicked")
        End Try
    End Sub

    Private Sub vS5_Change(sender As Object, e As ChangeEventArgs) Handles vS5.Change
        If wJOB = 2 Then Exit Sub

        Dim xROW As Integer

        xROW = e.Row

        Select Case True

            Case sender Is vS8
                If READ_PFK7112(getData(sender, getColumIndex(sender, "KEY_UploadNo"), xROW), getData(sender, getColumIndex(sender, "KEY_UploadSeq"), xROW)) = True Then
                    W7112 = D7112
                    Call REWRITE_PFK7112(W7112)

                End If

            Case Else


        End Select

    End Sub

    Private Sub vS_KeyDown(sender As Object, e As KeyEventArgs) Handles vS6.KeyDown, vs7.KeyDown, vS8.KeyDown
        If wJOB = 2 Then Exit Sub

        Dim xCOL As Integer
        Dim xROW As Integer

        xCOL = sender.ActiveSheet.ActiveColumnIndex
        xROW = sender.ActiveSheet.ActiveRowIndex


        Select Case e.KeyCode

            Case Keys.Delete

                Call Select_Message("3", WordConv("PROCESSING"), 2)

                If Msg_Result <> vbYes Then Exit Sub

                Select Case True
                    Case sender Is vS1

                    Case sender Is vS5
                        If READ_PFK7113(getData(sender, getColumIndex(sender, "KEY_Autokey"), xROW)) = True Then
                            W7113 = D7113

                            Call DELETE_PFK7113(W7113)
                            Call DELETE_PFK7114_SIZE_TO_SIZE(W7113)
                        End If

                    Case sender Is vs7

                        Call READ_PFK7112_TOP1(getData(sender, getColumIndex(sender, "KEY_UpLoadNo"), xROW))

                        SQL = "DELETE FROM PFK7112 "
                        SQL = SQL & " WHERE K7112_UpLoadNo  = '" & getData(sender, getColumIndex(sender, "KEY_UpLoadNo"), xROW) & "' "

                        cmd = New SqlClient.SqlCommand(SQL, cn)
                        cmd.ExecuteNonQuery()

                        Call READ_PFK7108_SHOESCODE(L7110.ShoesCode)

                        SQL = " DELETE FROM PFK7111 "
                        SQL = SQL & " WHERE K7111_GroupComponentBOM		 = '" & D7108.GroupComponentBOM & "' "
                        SQL = SQL & " AND    K7111_CheckType		     = '" & D7112.CheckType & "' "

                        cmd = New SqlClient.SqlCommand(SQL, cn)
                        cmd.ExecuteNonQuery()

                        Call PrcExeNoError("USP_PFK7110K_UPLOAD_MATCHING_DELETE", cn, D7112.CheckType, BaseComponentBOMList)


                        Call DATA_SEARCH_VS7()
                        Call DATA_SEARCH_VS8()

                        Exit Sub

                    Case sender Is vS8
                        If READ_PFK7112(getData(sender, getColumIndex(sender, "KEY_UploadNo"), xROW), getData(sender, getColumIndex(sender, "KEY_UploadSeq"), xROW)) = True Then
                            W7112 = D7112

                            Call DELETE_PFK7112(W7112)
                        End If

                    Case Else


                End Select

                SPR_DEL(sender, xCOL, xROW)

                sender.ActiveSheet.ActiveColumnIndex = xCOL
                sender.ActiveSheet.ActiveRowIndex = xROW
                sender.Focus()

            Case Keys.Enter
                If wJOB = 2 Then Exit Sub
                Select Case True

                    Case sender Is vS8
                        If READ_PFK7112(getData(sender, getColumIndex(sender, "KEY_UploadNo"), xROW), getData(sender, getColumIndex(sender, "KEY_UploadSeq"), xROW)) = True Then
                            W7112 = D7112

                            Call REWRITE_PFK7112(W7112)
                        End If

                    Case Else


                End Select



        End Select
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

            Case 6
                Call DATA_SEARCH_VS9()
        End Select
    End Sub
    Private Sub ptc_Main_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ptc_Main.SelectedIndexChanged
        If formA = False Then Exit Sub
        If ptc_Main.SelectedIndex = -1 Then Exit Sub
        chk_Upload.Visible = False

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
                chk_Upload.Visible = True
                Call DATA_SEARCH_VS7()
                Call DATA_SEARCH_VS8()

        End Select

    End Sub
    Private flagP As Boolean = False
    Private flagQ As Boolean = False
    Private flagW As Boolean = False
    Private flagL As Boolean = False
    Private flagS As Boolean = False


    Private Sub txt_Link7110_btnTitleClick(sender As Object, e As EventArgs) Handles txt_Link0112.btnTitleClick
        If ptc_Main.SelectedIndex = 5 Then
            Try

                Using OpenFileDialog As OpenFileDialog = Me.GetOpenFileDialog()
                    OpenFileDialog.ReadOnlyChecked = True
                    OpenFileDialog.RestoreDirectory = True

                    If _FileExt <> "" Then OpenFileDialog.InitialDirectory = _FileExt

                    If (OpenFileDialog.ShowDialog(Me) = DialogResult.OK) Then
                        If _FileExt = "" Then _FileExt = OpenFileDialog.FileName


                        If IO.Path.GetExtension(OpenFileDialog.FileName).ToUpper = ".CSV" Then
                            Dim strEx As String

                            Dim File As String
                            Dim DestTemp As String = OpenFileDialog.FileName + ".temp"

                            IO.File.Copy(OpenFileDialog.FileName, DestTemp)

                            strEx = IO.Path.GetExtension(OpenFileDialog.FileName).ToUpper

                            vS8.Reset()
                            vS8.DataSource = ReadCSV(DestTemp)
                            IO.File.Delete(DestTemp)
                            ChkUpload = True

                        Else
                            Dim strEx As String

                            Dim File As String
                            Dim DestTemp As String = OpenFileDialog.FileName + ".temp"

                            IO.File.Copy(OpenFileDialog.FileName, DestTemp)


                            vS8.OpenExcel(DestTemp)
                            IO.File.Delete(DestTemp)

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
        If PRINTSHEET_NEW.Link_SheetReport(3, "PFP71080", Me) = True Then

        End If
    End Sub
    Private Sub cmd_Demand_Load(sender As Object, e As EventArgs) Handles cmd_Demand.btnTitleClick
        Try
            Dim UploadNo As String

            UploadNo = getData(vs7, getColumIndex(vs7, "KEY_UploadNo"), vs7.ActiveSheet.ActiveRowIndex)
            If UploadNo = "" Then Exit Sub

            Dim strMsg As String

            strMsg = MsgBox("Do you want to matching this" + UploadNo + " with Spec No !", vbYesNo)

            If StrMsg <> vbYes Then Exit Sub

            DS1 = PrcDS("USP_PFK7110K_UPLOAD_CHECK", cn, UploadNo, BaseComponentBOMList)

            If GetDsRc(DS1) > 0 Then
                MsgBoxP("Error in upload!")
                SPR_PRO_NEW(vS8, DS1, "USP_PFK7110K_UPLOAD_CHECK", "vs8")
                Exit Sub
            End If

            Call PrcExeNoError("USP_PFK7110K_UPLOAD_MATCHING", cn, UploadNo, BaseComponentBOMList)

            If ptc_Main.SelectedIndex = 0 Then Call DATA_SEARCH_VS2()


        Catch ex As Exception

        End Try

    End Sub

    Private Sub DemandCalculation()
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim DS1x As New DataSet

            SQL = " SELECT K7112_UploadNo FROM PFK7112 WHERE K7112_ShoesCode = '" + getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), 0) + "' GROUP BY K7112_UploadNo "
            cmd = New SqlClient.SqlCommand(SQL, cn)

            DS1x = PrcDS(cmd, cn)

            Dim i As Integer

            For i = 0 To GetDsRc(DS1x) - 1
                Call PrcExeNoError("USP_PFK7110K_UPLOAD_MATCHING", cn, GetDsData(DS1x, i, 0), BaseComponentBOMList)
            Next

            If ptc_Main.SelectedIndex = 0 Then Call DATA_SEARCH_VS2()
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

    Private Sub chk_cdGroupComponentName_CheckedChanged(sender As Object, e As EventArgs) Handles chk_FullBase.CheckedChanged

        CntProcess = 0


        If chk_FullBase.Checked = True Then
            Call DATA_SEARCH_VS1()
            txt_BaseComponentBOMFull.Data = ""
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

            If ISUD7108A.Link_ISUD7108A(3, BaseComponentBOM, Me.Tag) Then
                Call DATA_SEARCH_VS2()
            End If
        End If
    End Sub

    Private Sub vS7_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vs7.CellClick
        If e.ColumnHeader = False Then

            Call DATA_SEARCH_VS8()
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

        Call READ_SPREAD_N(vS2, DS1, xROW, GetDsRc(DS1), "USP_ISUD7110K_SEARCH_VS2", "vS2")
    End Sub

    Private Sub tst_3_Click(sender As Object, e As EventArgs) Handles tst_3.Click
        Dim Starting As Object
        Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")


        Try
            Dim i As Integer

            For i = 0 To vS1.ActiveSheet.RowCount - 1
                If getData(vS1, getColumIndex(vS1, "ShoesParent"), i) <> getData(vS1, getColumIndex(vS1, "ShoesCode"), i) Then
                    Call PrcExeNoError("USP_ISUD7110K_SEARCH_SYNC_SHOESCODE", cn, getData(vS1, getColumIndex(vS1, "ShoesParent"), i), getData(vS1, getColumIndex(vS1, "ShoesCode"), i))
                End If
            Next
            MsgBoxP("Save Successfully!", vbInformation)

        Catch ex As Exception

        Finally
            Starting.close()
        End Try
    End Sub

    Private Sub tst_4_Click(sender As Object, e As EventArgs) Handles tst_4.Click
        If L7108.ShoesCode = getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), vS1.ActiveSheet.ActiveRowIndex) Then
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

    Private Sub tst_5_Click(sender As Object, e As EventArgs) Handles tst_5.Click

        Dim shoesCode As String

        shoesCode = getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), vS1.ActiveSheet.ActiveRowIndex)

        If HLP1312L.Link_HLP1312Material(shoesCode) = True Then

        End If


    End Sub
    Private Sub tst_6_Click(sender As Object, e As EventArgs) Handles tst_6.Click
        Call MAIN_JOB03()

        'If MsgBoxPPW("Please type the password to complete!", const_pwRnD) = False Then Exit Sub

        'Try
        '    Dim i As Integer

        '    For i = 0 To vS1.ActiveSheet.RowCount - 1
        '        If READ_PFK7106(getData(vS1, getColumIndex(vS1, "ShoesCode"), i)) Then
        '            D7106.CheckComplete = "1"
        '            D7106.InchargeComplete = Pub.SAW

        '            Call REWRITE_PFK7106(D7106)
        '        End If
        '    Next
        'Catch ex As Exception

        'End Try


    End Sub

    Private Sub vS5_KeyDown(sender As Object, e As KeyEventArgs) Handles vS5.KeyDown
        If wJOB = 2 Then Exit Sub

        Dim xCOL As Integer
        Dim xROW As Integer
        xCOL = vS5.ActiveSheet.ActiveColumnIndex
        xROW = vS5.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Delete

                Call Select_Message("3", WordConv("PROCESSING"), 2)

                If Msg_Result <> vbYes Then Exit Sub

                Dim K7113_Autokey As String = getData(vS5, getColumIndex(vS5, "Key_Autokey"), xROW)

                If READ_PFK7113(K7113_Autokey) Then
                    W7113 = D7113
                    Call DELETE_PFK7113(W7113)
                End If

                SPR_DEL(vS5, xCOL, xROW)
                vS5.ActiveSheet.ActiveColumnIndex = xCOL
                vS5.ActiveSheet.ActiveRowIndex = xROW
                vS5.Focus()

            Case Keys.Enter

                If READ_PFK7113(getData(vS5, getColumIndex(vS5, "KEY_Autokey"), xROW)) = True Then
                    W7113 = D7113

                    W7113.MaterialCode = getData(vS5, getColumIndex(vS5, "MaterialCode"), xROW)

                    W7113.SizeBeginName = getData(vS5, getColumIndex(vS5, "SizeBeginName"), xROW)
                    W7113.SizeEndName = getData(vS5, getColumIndex(vS5, "SizeEndName"), xROW)

                    W7113.ColorName = getData(vS5, getColumIndex(vS5, "ColorName"), xROW)
                    W7113.Color = getData(vS5, getColumIndex(vS5, "Color"), xROW)

                    W7113.QtySize = getData(vS5, getColumIndex(vS5, "QtySize"), xROW)
                    W7113.LossSize = getData(vS5, getColumIndex(vS5, "LossSize"), xROW)
                    W7113.QtyUsage = getData(vS5, getColumIndex(vS5, "QtyUsage"), xROW)


                    Call REWRITE_PFK7113(W7113)

                End If

        End Select

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

                        If WRITE_PFK7109(W7109) Then
                            setData(vS2, getColumIndex(vS2, "KEY_GroupComponentBOM"), xROW, W7109.GroupComponentBOM)
                            setData(vS2, getColumIndex(vS2, "KEY_GroupComponentSeq"), xROW, W7109.GroupComponentSeq)
                            setData(vS2, getColumIndex(vS2, "Dseq"), xROW, W7109.Dseq)
                        End If

                    Else
                        W7109.Dseq = xROW
                        W7109.GrossUsage = W7109.Consumption * (1 + W7109.Loss / 100)

                        Call REWRITE_PFK7109(W7109)
                    End If
                End If

        End Select
    End Sub

    Private Sub vS2_Change(sender As Object, e As ChangeEventArgs) Handles vS2.Change
        If wJOB = 2 Then Exit Sub

        Dim xCOL As Integer
        Dim xROW As Integer
        xCOL = vS2.ActiveSheet.ActiveColumnIndex
        xROW = vS2.ActiveSheet.ActiveRowIndex

        Try
            W7108.ShoesCode = getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), vS1.ActiveSheet.ActiveRowIndex)

            If READ_PFK7108_SHOESCODE(W7108.ShoesCode) = False Then
                Call KEY_COUNT_K7108()
                W7108.InchargeInsert = Pub.SAW

                If WRITE_PFK7108(W7108) = True Then

                End If
            Else
                W7108 = D7108

                W7109.GroupComponentBOM = W7108.GroupComponentBOM
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

                    If WRITE_PFK7109(W7109) Then
                        setData(vS2, getColumIndex(vS2, "KEY_GroupComponentBOM"), xROW, W7109.GroupComponentBOM)
                        setData(vS2, getColumIndex(vS2, "KEY_GroupComponentSeq"), xROW, W7109.GroupComponentSeq)
                        setData(vS2, getColumIndex(vS2, "Dseq"), xROW, W7109.Dseq)
                    End If

                Else
                    W7109.Dseq = xROW
                    W7109.GrossUsage = W7109.Consumption * (1 + W7109.Loss / 100)

                    Call REWRITE_PFK7109(W7109)
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
                If L7108.ShoesCode = getData(vS1, getColumIndex(vS1, "KEY_ShoesCode"), xROW) Then
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
                        Call cmd_Demand.PeaceButton1.PerformClick()
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
                Call DemandCalculation()
            End If
        End If
    End Sub




    Private Sub tst_7_Click(sender As Object, e As EventArgs) Handles tst_7.Click
        Call MAIN_JOB02()
    End Sub

    Private Sub tst_8_Click(sender As Object, e As EventArgs) Handles tst_8.Click
        If wJOB = 2 Then Exit Sub

        Call READ_PFK7108_SHOESCODE(L7110.ShoesCode)

        If MsgBoxPPW("Please type the password to DELETE consumption!", const_pwDeleteCS) = False Then Exit Sub

        'Call DELETE_PFK7109_ALL(W7108.GroupComponentBOM)
        Call DELETE_PFK7111_ALL(D7108.GroupComponentBOM)

    End Sub

    Private Sub chk_Upper_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Upper.CheckedChanged
        If chk_Upper.Checked = True Then
            chk_Yield.Checked = True
        Else
            chk_Yield.Checked = False
        End If
    End Sub



End Class