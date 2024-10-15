Module M_Spread

#Region "Variables"
    '================================== '==================================
    Private PRG As E_PRG
    Private M9911 As T9911_AREA
    Private M9912 As T9912_AREA
    Private CheckTick As Boolean = False
    Public CheckPFPAll As Boolean = False
    '================================== '==================================

    Public tf As Boolean

    Public vS_Array() As String

    Public vS_col As Integer
    Public vS_row As Integer
    Public vS_txt As String

    Public vS_col0 As Integer
    Public vS_row0 As Integer

    Public vS_row1 As Integer
    Public vS_row2 As Integer
    Public vS_row3 As Integer
    Public vS_sort As Boolean
    Public vS_Mrow As Integer
    Public vS_Mcol As Integer

    Public SheetHeader As String
    Public Sheetfooter As String

    Public cButtomHelpColor As Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
    Public cSprSealNo As Color = Color.GreenYellow
    Public cSprBalance As Color = Color.Khaki
    Public cSprProduction As Color = Color.SkyBlue

    Public cSprSetBalance As Color = Color.PaleGreen

    '================================== '==================================

#End Region

#Region "SPR_PRO"
    Public Enum SearchType
        Material = 1
        BasicCode = 2
        Customer = 3
        Supplier = 4
        ColorName = 5

        Component = 6

    End Enum

    Public Sub SPR_SearchType(sender As Object, str_SearchType As Integer, Optional str_SearchName As String = "", Optional str_SearchValue As String = "")
        Try
            Select Case str_SearchType
                Case SearchType.Material
                    Call SPR_SearchName(sender, "USP_HLP7231C_SEARCH_VS1_COMBOBOX", "MaterialName")

                Case SearchType.BasicCode
                    Call SPR_SearchName(sender, "USP_HLP7171A_SEARCH_vS1_COMBOBOX", str_SearchName, str_SearchValue)

                Case SearchType.ColorName
                    Call SPR_SearchName(sender, "USP_HLP7121C_SEARCH_VS1_COMBOBOX", "ColorName")

                Case SearchType.Component
                    Call SPR_SearchName(sender, "USP_HLP7171A_SEARCH_vS1_COMBOBOX", str_SearchName, str_SearchValue)

            End Select

        Catch ex As Exception

        End Try
    End Sub

    Public Sub SPR_SearchName(sender As Object, str_ProgramName As String, str_ColumnName As String, ByVal ParamArray _ArrList() As String)
        Try
            Dim dtPosts1 As New DataSet
            Dim i As Integer

            If _ArrList.Length = 0 Then dtPosts1 = PrcDS(str_ProgramName, cn) Else dtPosts1 = PrcDS(str_ProgramName, cn, _ArrList)

            Dim inputcell1 As New GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType
            Dim acsc As New AutoCompleteStringCollection

            For i = 0 To GetDsRc(dtPosts1) - 1
                acsc.Add(GetDsData(dtPosts1, i, 0).ToString)
            Next

            inputcell1.AutoCompleteCustomSource = acsc
            inputcell1.AutoCompleteMode = AutoCompleteMode.Suggest
            inputcell1.Ellipsis = GrapeCity.Win.Spread.InputMan.CellType.EllipsisMode.EllipsisPath
            inputcell1.EllipsisString = ".."

            inputcell1.MaxLineCount = 50
            inputcell1.LineSpace = 2

            inputcell1.AutoCompleteSource = AutoCompleteSource.CustomSource

            inputcell1.AutoComplete.MatchingMode = GrapeCity.Win.Spread.InputMan.CellType.AutoCompleteMatchingMode.AmbiguousMatchAll
            inputcell1.AutoComplete.HighlightStyle.BackColor = Color.Yellow
            inputcell1.AutoComplete.HighlightMatchedText = True

            inputcell1.AcceptsArrowKeys = FarPoint.Win.SuperEdit.AcceptsArrowKeys.AllArrowsIgnoringMultiline
            inputcell1.AcceptsCrLf = GrapeCity.Win.Spread.InputMan.CellType.CrLfMode.Cut
            inputcell1.AcceptsTabChar = GrapeCity.Win.Spread.InputMan.CellType.TabCharMode.NoControl
            inputcell1.AllowSpace = GrapeCity.Win.Spread.InputMan.CellType.AllowSpace.Both

            inputcell1.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.EditorBaseFocusCursorPosition.Inherit

            sender.ActiveSheet.Columns(getColumIndex(sender, str_ColumnName)).CellType = inputcell1

        Catch ex As Exception

        End Try
    End Sub

    Public Sub VsSizeRangeNew_one(sender As PeaceFarpoint, ProgramName As String, FixColstr As String, ParamArray Para() As String)
        Dim FixCol As Integer
        Dim i, j As Integer

        DS2 = PrcDS(ProgramName, cn, Para)

        'sender.ActiveSheet.ColumnHeader.Rows.Add(0, GetDsRc(DS2))
        FixCol = FixColstr

        'sender.ActiveSheet.ColumnHeader.Rows(0, GetDsRc(DS2)).Height = cSprRowHeaderHeight_25
        'sender.ActiveSheet.ColumnHeader.Cells(0, 0, sender.ActiveSheet.ColumnHeader.RowCount - 2, FixCol - 1).BackColor = Color.White

        'sender.ActiveSheet.ColumnHeader.Cells(0, 0).RowSpan = GetDsRc(DS2)
        'sender.ActiveSheet.ColumnHeader.Cells(0, 0).ColumnSpan = FixCol

        For i = 0 To GetDsRc(DS2) - 1
            If i = 0 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = cHeadColor
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.White

            ElseIf i = 1 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.LawnGreen
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 2 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Gold
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 3 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.LightPink
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 4 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Orange
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 5 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Yellow
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 6 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.DarkTurquoise
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            End If

            For j = 0 To 30
                setDataCH(sender, FixCol + j, i, GetDsData(DS2, i, j))
            Next
        Next
    End Sub


    Public Sub VsSizeRangeNew_Many(sender As PeaceFarpoint, ProgramName As String, FixColstr As String, ParamArray Para() As String)
        Dim FixCol As Integer
        Dim i, j As Integer

        DS2 = PrcDS(ProgramName, cn, Para)

        sender.ActiveSheet.ColumnHeader.Rows.Add(0, GetDsRc(DS2))
        FixCol = FixColstr

        sender.ActiveSheet.ColumnHeader.Rows(0, GetDsRc(DS2)).Height = cSprRowHeaderHeight_25
        sender.ActiveSheet.ColumnHeader.Cells(0, 0, sender.ActiveSheet.ColumnHeader.RowCount - 2, FixCol - 1).BackColor = Color.White

        sender.ActiveSheet.ColumnHeader.Cells(0, 0).RowSpan = GetDsRc(DS2)
        sender.ActiveSheet.ColumnHeader.Cells(0, 0).ColumnSpan = FixCol

        For i = 0 To GetDsRc(DS2) - 1
            If i = 0 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = cHeadColor
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.White

            ElseIf i = 1 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.LawnGreen
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 2 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Gold
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 3 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.LightPink
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 4 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Orange
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 5 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Yellow
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 6 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.DarkTurquoise
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            End If

            For j = 0 To 30
                setDataCH(sender, FixCol + j, i, GetDsData(DS2, i, j))
            Next
        Next
    End Sub

    Public Sub SPR_PRO_NEW_NO_PFK9911(ByRef spr As PeaceFarpoint, datatr As DataSet, program As String, sheetname As String, Optional ByVal Chk As Boolean = False)

        If datatr Is Nothing Then Exit Sub

        Dim header As Boolean = False

        Dim DATAreader As SqlClient.SqlDataReader
        Dim ColumnName As String
        Dim DataConvert() As String
        Dim i, j As Integer
        Dim str(), str1() As String

        spr.SuspendLayout()
        DATAreader = Nothing
        spr.Tag = program & ";" & sheetname

        MdiMenu.Cursor = Cursors.WaitCursor

        Try
            If READ_PFK9914("DMS", program, sheetname) = True Then
                SPR_SET(spr, D9914.ColsFrozen,
                            D9914.RowsFrozen,
                            D9914.MaxRows,
                            D9914.OperationMode,
                            CboolP(D9914.Lock),
                            CboolP(D9914.DefaultRowHeight),
                            CboolP(D9914.HeaderTextMode),
                            CboolP(D9914.RetainSelectionBlock),
                            D9914.Fontsize,
                            D9914.Rowheight,
                            D9914.AutoClip,
                            False)
                header = CboolP(D9914.Header)
            End If

            spr.ActiveSheet.RowCount = 0
            spr.ActiveSheet.ColumnCount = 0
            spr.ActiveSheet.ColumnHeader.RowCount = 1
            spr.ActiveSheet.ColumnHeader.Rows(0).Height = cSprRowHeaderHeight
            spr.ActiveSheet.ColumnCount = GetDsCc(datatr)

            Dim RowCount As Integer
            Dim ColumnCount As Integer

            RowCount = GetDsRc(datatr)
            ColumnCount = GetDsCc(datatr)

            If RowCount > 1000 Then
                PRG_SET(ProgressBar1, RowCount)
                spr.ActiveSheet.RowCount = RowCount

                For i = 0 To RowCount - 1
                    PRG_VALUE(ProgressBar1, i + 1)

                    For j = 0 To ColumnCount - 1
                        'spr.ActiveSheet.Cells(i, j).Value = datatr.Tables(0).Rows(i).Item(j)
                        setData(spr, j, i, datatr.Tables(0).Rows(i).Item(j))
                    Next
                Next

            Else
                spr.ActiveSheet.RowCount = RowCount
                spr.ActiveSheet.DataSource = datatr.Tables(0)
            End If

            spr.ActiveSheet.ZoomFactor = ZoomSize

            If D9914.Footer = "1" Then
                spr.ActiveSheet.ColumnFooter.Visible = True
                spr.ActiveSheet.ColumnFooter.RowCount = 1
                spr.ActiveSheet.ColumnFooter.Rows(0).BackColor = SystemColors.Info
                spr.ActiveSheet.ColumnFooter.Rows(0).ForeColor = Color.Black
            ElseIf header = True Then
                spr.ActiveSheet.ColumnFooter.Visible = False
                spr.ActiveSheet.ColumnFooter.RowCount = 1
                spr.ActiveSheet.ColumnFooter.Rows(0).BackColor = SystemColors.Info
                spr.ActiveSheet.ColumnFooter.Rows(0).ForeColor = Color.Black

                spr.ActiveSheet.Rows.Add(0, 1)
                SPR_BACKCOLORROWTOTAL(spr, cRelation3HeaderColor, 0)
                spr.ActiveSheet.FrozenRowCount = 1
                RowCount += 1
            End If

            Dim CheckMas As Boolean = False

            For i = 0 To ColumnCount - 1
BEGIN:
                ColumnName = getColumName(datatr, i)

                Call D9912_CLEAR()

                If READ_PFK9912_2("DMS", program, sheetname, ColumnName) Then
                    If D9912.CheckDev = "1" Then
                        spr.ActiveSheet.ColumnHeader.Columns(i).Label = D9912.ItemNameSimply : CheckMas = True
                    Else
                        CheckMas = False

                    End If
                End If

                DATAreader = PrcDRSheet("USP_SPREAD_PROGRAM_SEARCH_ITEMNAME_SANO", cn, Pub.SAW, program, sheetname, ColumnName)
                If DATAreader.HasRows = False Then DATAreader.Close() : DATAreader = PrcDRSheet("USP_SPREAD_PROGRAM_SEARCH_ITEMNAME", cn, program, sheetname, ColumnName)

                If DATAreader.HasRows Then
                    DATAreader.Read()

                    If CheckMas = False Then
                        If MdiMenu.M20001.Checked = True Then spr.ActiveSheet.ColumnHeader.Columns(i).Label = DATAreader("K9911_ItemNameSimply")
                        If MdiMenu.M20002.Checked = True Then spr.ActiveSheet.ColumnHeader.Columns(i).Label = DATAreader("K9911_ItemNameForeign1")
                    Else
                        If MdiMenu.M20001.Checked = True Then spr.ActiveSheet.ColumnHeader.Columns(i).Label = D9912.ItemNameSimply
                        If MdiMenu.M20002.Checked = True Then spr.ActiveSheet.ColumnHeader.Columns(i).Label = D9912.ItemNameForeign1
                    End If

                    spr.ActiveSheet.ColumnHeader.Columns(i).Tag = DATAreader("K9911_ItemName").ToString.ToUpper
                    'spr.Range(i) = DATAreader("K9911_CheckDevValue").ToString.ToUpper

                    If DATAreader("K9911_Hidden") = "1" Then spr.ActiveSheet.Columns(i).Visible = True Else spr.ActiveSheet.Columns(i).Visible = False

                    Select Case DATAreader("K9911_DataType")

                        Case 0, 6
                            Call SPR_TEXTBOX(spr, i, DATAreader("K9911_DataSize"))

                            If header = False Then Exit Select

                            If DATAreader("K9911_CheckHead") <> "1" Then
                                Exit Select
                            Else
                                If D9914.Footer = "1" Then
                                    Dim Formula1 As String
                                    Formula1 = "SUBTOTAL(103," & spr.ActiveSheet.GetColumnAutoText(i) & "1:" & spr.ActiveSheet.GetColumnAutoText(i) & spr.ActiveSheet.RowCount & ")"
                                    SPR_NUMBERCELLFOOTER(spr, DATAreader("K9911_DataDecimal"), CIntp(DATAreader("K9911_DataSize")), i)
                                    spr.ActiveSheet.ColumnFooter.SetAggregationType(0, i, Model.AggregationType.CountAIgnoreHidden)
                                End If
                                Exit Select
                            End If

                            spr.ActiveSheet.Cells(0, i).Formula = "SUBTOTAL(103," & spr.ActiveSheet.GetColumnAutoText(i) & "2:" & spr.ActiveSheet.GetColumnAutoText(i) & spr.ActiveSheet.RowCount & ")"

                            SPR_NUMBERCELLFOOTER(spr, DATAreader("K9911_DataDecimal"), CIntp(DATAreader("K9911_DataSize")), i)
                            spr.ActiveSheet.ColumnFooter.SetAggregationType(0, i, Model.AggregationType.CountAIgnoreHidden)
                        Case 1
                            Call SPR_NUMBERCELL(spr, DATAreader("K9911_DataDecimal"), CIntp(DATAreader("K9911_DataSize")), i)

                            If D9914.Footer = "1" Then
                                Dim Formula1 As String
                                Formula1 = "SUBTOTAL(109," & spr.ActiveSheet.GetColumnAutoText(i) & "1:" & spr.ActiveSheet.GetColumnAutoText(i) & spr.ActiveSheet.RowCount & ")"
                                SPR_NUMBERCELLFOOTER(spr, DATAreader("K9911_DataDecimal"), CIntp(DATAreader("K9911_DataSize")), i)
                                spr.ActiveSheet.ColumnFooter.SetAggregationType(0, i, Model.AggregationType.SumIgnoreHidden)
                                Exit Select
                            End If

                            If header = False Then
                                Exit Select
                            End If


                            Dim FixAmount As Decimal = 0
                            Dim ConAmount As Decimal = 0
                            Dim HeadAmount As Decimal = 0
                            Dim HeadCount As Integer = 0

                            'If DATAreader("K9911_CheckHead") <> "1" Then Exit Select

                            If DATAreader("K9911_CheckHead") <> "1" Then
                                Exit Select

                            End If

                            If DATAreader("K9911_CheckHeadType") = "0" Then
                                For j = 1 To RowCount - 1
                                    ConAmount = CDecp(getData(spr, i, j))
                                    HeadAmount += ConAmount
                                Next
                                setData(spr, i, 0, HeadAmount)

                                If D9914.Footer = "1" Then
                                    Dim Formula As String
                                    Formula = "SUBTOTAL(109," & spr.ActiveSheet.GetColumnAutoText(i) & "2:" & spr.ActiveSheet.GetColumnAutoText(i) & spr.ActiveSheet.RowCount & ")"
                                    spr.ActiveSheet.Cells(0, i).Formula = Formula

                                    SPR_NUMBERCELLFOOTER(spr, DATAreader("K9911_DataDecimal"), CIntp(DATAreader("K9911_DataSize")), i)
                                    spr.ActiveSheet.ColumnFooter.SetAggregationType(0, i, Model.AggregationType.SumIgnoreHidden)
                                    spr.ActiveSheet.ColumnFooter.Cells(0, i).Formula = Formula
                                End If

                            ElseIf DATAreader("K9911_CheckHeadType") = "1" And DATAreader("K9911_REMK").ToString.Trim <> "" Then
                                DataConvert = Split(DATAreader("K9911_REMK").ToString.Trim, ";")

                                For j = 1 To RowCount - 1
                                    ConAmount += CDecp(getData(spr, DataConvert(0), j))
                                    HeadCount += CDecp(getData(spr, DataConvert(1), j))
                                Next
                                If HeadCount > 0 Then setData(spr, i, 0, ConAmount / HeadCount * 100)

                            ElseIf DATAreader("K9911_CheckHeadType") = "1" Then
                                Dim Formula As String
                                Formula = "SUBTOTAL(101," & spr.ActiveSheet.GetColumnAutoText(i) & "2:" & spr.ActiveSheet.GetColumnAutoText(i) & spr.ActiveSheet.RowCount & ")"
                                spr.ActiveSheet.Cells(0, i).Formula = Formula

                                SPR_NUMBERCELLFOOTER(spr, DATAreader("K9911_DataDecimal"), CIntp(DATAreader("K9911_DataSize")), i)
                                spr.ActiveSheet.ColumnFooter.SetAggregationType(0, i, Model.AggregationType.AvgIgnoreHidden)

                            Else
                                Dim Formula As String
                                Formula = "SUBTOTAL(103," & spr.ActiveSheet.GetColumnAutoText(i) & "2:" & spr.ActiveSheet.GetColumnAutoText(i) & spr.ActiveSheet.RowCount & ")"
                                spr.ActiveSheet.Cells(0, i).Formula = Formula

                                SPR_NUMBERCELLFOOTER(spr, DATAreader("K9911_DataDecimal"), CIntp(DATAreader("K9911_DataSize")), i)
                                spr.ActiveSheet.ColumnFooter.SetAggregationType(0, i, Model.AggregationType.CountAIgnoreHidden)
                            End If

                        Case 2
                            If ColumnName = "PrescriptionWeavingCheck" Or ColumnName = "PrescriptionProductionCheck" Then
                                For j = 0 To RowCount - 1
                                    If GetDsData(datatr, j, "CheckPrescription") = True Then
                                        SPR_BUTTON_S(spr, i, j, getData(spr, i, j))
                                    End If
                                Next
                            Else
                                SPR_BUTTON(spr, i)
                            End If

                        Case 3
                            Call SPR_COMBOBOX(spr, i, Split(DATAreader("K9911_REMK").ToString.Trim, ";"))

                            For j = 0 To RowCount - 1
                                setDataCB(spr, i, j, getData(spr, i, j))
                            Next

                        Case 4
                            Call SPR_CHECKBOX(spr, i)

                            Dim ValueChk As String
                            For j = 0 To RowCount - 1
                                ValueChk = CIntp(getData(spr, i, j))
                                setDataChk(spr, i, j, ValueChk)
                            Next

                        Case 5
                            Call SPR_DATEVALUE(spr, i)

                        Case 8
                            Call SPR_IMAGE(spr, i)
                    End Select

                    If CheckMas = False Then
                        spr.ActiveSheet.ColumnHeader.Columns(i).Width = DATAreader("K9911_SizeWidth")
                    Else
                        spr.ActiveSheet.ColumnHeader.Columns(i).Width = D9912.SizeWidth
                    End If


                    If CDbl(DATAreader("K9911_SizeWidth")) = 111 Then
                        spr.ActiveSheet.ColumnHeader.Columns(i).Width = spr.ActiveSheet.ColumnHeader.Columns(i).GetPreferredWidth
                    End If
                    str1 = Split(DATAreader("K9911_ForeColor"), "-")
                    spr.ActiveSheet.Columns(i).ForeColor = System.Drawing.Color.FromArgb(CInt(str1(0)), CInt(str1(1)), CInt(str1(2)))

                    spr.ActiveSheet.Columns(i).VerticalAlignment = DATAreader("K9911_VerticalAlignment")
                    spr.ActiveSheet.Columns(i).HorizontalAlignment = DATAreader("K9911_HorizontalAlignment")

                    If DATAreader("K9911_Lock") = "1" Then
                        spr.ActiveSheet.Columns(i).Locked = True
                    Else
                        spr.ActiveSheet.Columns(i).Locked = False

                    End If

                    If D9914.AreaColorCheck = "1" Then
                        str = Split(D9914.AreaColor, "-")
                        SPR_BackColumn(spr, System.Drawing.Color.FromArgb(CInt(str(0)), CInt(str(1)), CInt(str(2))), i)
                    Else
                        SPR_BackColumn(spr, Color.White, i)
                    End If

                    If DATAreader("K9911_BackColot") <> "255-255-255" Then
                        str = Split(DATAreader("K9911_BackColot"), "-")
                        spr.ActiveSheet.Columns(i).BackColor = System.Drawing.Color.FromArgb(CInt(str(0)), CInt(str(1)), CInt(str(2)))
                    End If
                    DATAreader.Close()

                Else

END1:
                End If
            Next

            Dim ArrInteger(0) As Integer
            Dim ArrIntegerR(0) As Integer

            Dim ArrList() As String
            Dim ArrListR() As String

            Dim ListChk As Boolean = False
            Dim ListChkR As Boolean = False

            If D9914.MergeColumn <> "" Then
                ArrList = Split(D9914.MergeColumn, ",")
                If ArrList.Length > 0 Then
                    ReDim ArrInteger(ArrList.Length - 1)

                    For i = 0 To UBound(ArrList)
                        ArrInteger(i) = CIntp(ArrList(i))
                    Next

                    ListChk = True
                End If
            End If

            If D9914.MergeRetrict <> "" Then
                ArrListR = Split(D9914.MergeRetrict, ",")
                If ArrListR.Length > 0 Then
                    ReDim ArrIntegerR(ArrListR.Length - 1)

                    For i = 0 To UBound(ArrListR)
                        ArrIntegerR(i) = CIntp(ArrListR(i))
                    Next

                    ListChkR = True
                End If
            End If

            If CboolP(D9914.Separate) = True And CboolP(D9914.TotalSeparate) = False Then
                Call SPR_SEPARATE(spr, D9914.ColumnBase, D9914.ColumnCal)

            ElseIf CboolP(D9914.Separate) = False And CboolP(D9914.TotalSeparate) = True Then
                Call SPR_TOTAL(spr, D9914.ColumnBase, D9914.ColumnCal)

            End If
            If CboolP(D9914.Merge) = True Then
                If ListChk = True Then Call SPR_MERGEALWAYS(spr, ArrInteger)
                If ListChkR = True Then Call SPR_MERGERESTRICT(spr, ArrIntegerR)
            End If

            If D9914.HeaderColumn = "2" Then
                spr.ActiveSheet.ColumnHeaderVisible = False
            Else
                spr.ActiveSheet.ColumnHeaderVisible = True
            End If

            If D9914.HeaderRow = "2" Then
                spr.ActiveSheet.RowHeaderVisible = False
            Else
                spr.ActiveSheet.RowHeaderVisible = True
            End If

            'ADD

            If D9914.ColumnSpanID = 0 Then GoTo next1

            DS2 = PrcDS("USP_SPREAD_PROGRAM_SEARCH_PFK9915", cn, "DMS", program, sheetname, D9914.ColumnSpanID)

            If GetDsRc(DS2) = 0 Then GoTo next1

            spr.ActiveSheet.ColumnHeader.RowCount = 2

            For i = 0 To GetDsRc(DS2) - 1
                For j = CIntp(GetDsData(DS2, i, "BeginColumn")) To CIntp(GetDsData(DS2, i, "EndColumn"))
                    spr.ActiveSheet.ColumnHeader.Cells(1, j).Value = spr.ActiveSheet.ColumnHeader.Cells(0, j).Value
                Next
                spr.ActiveSheet.AddColumnHeaderSpanCell(0, CIntp(GetDsData(DS2, i, "BeginColumn")), 1, CIntp(GetDsData(DS2, i, "EndColumn")) - CIntp(GetDsData(DS2, i, "BeginColumn")) + 1)
                spr.ActiveSheet.ColumnHeader.Cells(0, CIntp(GetDsData(DS2, i, "BeginColumn"))).Value = GetDsData(DS2, i, "Title")
            Next

            For i = 0 To spr.ActiveSheet.ColumnCount - 1
                If spr.ActiveSheet.ColumnHeader.Cells(0, i).ColumnSpan = 1 Then
                    spr.ActiveSheet.ColumnHeader.Cells(0, i).RowSpan = 2
                End If

            Next

            If READ_PFK9914("DMS", program, sheetname) Then
                If D9914.ColHeader1 < 10 Then
                    spr.ActiveSheet.ColumnHeader.Rows(0).Height = cSprRowHeight
                Else
                    spr.ActiveSheet.ColumnHeader.Rows(0).Height = D9914.ColHeader1
                End If
                If D9914.ColHeader2 < 10 Then
                    spr.ActiveSheet.ColumnHeader.Rows(1).Height = cSprRowHeight
                Else
                    spr.ActiveSheet.ColumnHeader.Rows(1).Height = D9914.ColHeader2
                End If

            End If

next1:
            '-----------------------------------------CHART----------------------------------------'
            '2016/11/01
            'If D9914.Footer = "1" Then
            '    spr.ActiveSheet.ColumnHeader.RowCount += 1
            '    spr.ActiveSheet.ColumnHeader.Rows(spr.ActiveSheet.ColumnHeader.RowCount - 1).Height = cSprRowHeight
            '    spr.ActiveSheet.ColumnHeader.Rows(spr.ActiveSheet.ColumnHeader.RowCount - 1).BackColor = cRelation3HeaderColor
            '    spr.ActiveSheet.ColumnHeader.Cells(spr.ActiveSheet.ColumnHeader.RowCount - 1, 0, spr.ActiveSheet.ColumnHeader.RowCount - 1, spr.ActiveSheet.ColumnCount - 1).Value = ""
            'End If

            If D9914.Chart = "1" Then
                spr.ActiveSheet.Charts.Clear()

                Dim LineplotArea As New FarPoint.Win.Chart.YPlotArea()
                LineplotArea.Location = New PointF(0.2F, 0.2F)
                LineplotArea.Size = New SizeF(0.6F, 0.6F)

                Dim BarplotArea As New FarPoint.Win.Chart.YPlotArea()
                BarplotArea.Location = New PointF(0.2F, 0.2F)
                BarplotArea.Size = New SizeF(0.6F, 0.6F)

                Dim PieplotArea As New FarPoint.Win.Chart.PiePlotArea()
                PieplotArea.Location = New PointF(0.2F, 0.2F)
                PieplotArea.Size = New SizeF(0.6F, 0.6F)

                If D9914.LineBase <> "" Then
                    Dim Line() As FarPoint.Win.Chart.LineSeries
                    Dim LineRc As Integer
                    LineRc = Split(D9914.LineBase, ",").Length - 1
                    ReDim Line(LineRc)
                    For i = 0 To LineRc
                        Line(i) = New FarPoint.Win.Chart.LineSeries
                        Line(i).SmoothedLine = True
                        Line(i).PointMarker = New FarPoint.Win.Chart.NoMarker

                        ' Line(i).SeriesName = spr.ActiveSheet.Columns(Split(D9914.LineBase, ",")(i)).Tag
                        Line(i).SeriesName = spr.ActiveSheet.ColumnHeader.Columns(CIntp(Split(D9914.LineBase, ",")(i))).Label
                        LineplotArea.Series.Add(Line(i))

                    Next

                    If D9914.Header = "1" Then
                        For j = 1 To spr.ActiveSheet.RowCount - 1
                            For i = 0 To LineRc
                                Line(i).Values.Add(getData(spr, CIntp(Split(D9914.LineBase, ",")(i)), j))
                            Next
                        Next
                    Else
                        For j = 0 To spr.ActiveSheet.RowCount - 1
                            For i = 0 To LineRc
                                Line(i).Values.Add(getData(spr, CIntp(Split(D9914.LineBase, ",")(i)), j))
                            Next
                        Next
                    End If

                    'Dim Chuoi() As String
                    'ReDim Chuoi(spr.ActiveSheet.RowCount - 1)
                    'If D9914.Line <> "" Then


                    '    For j = 0 To spr.ActiveSheet.RowCount - 1
                    '        Chuoi(j) = getData(spr, CIntp(D9914.Line), j)

                    '        LineplotArea.XAxis.AxisType = FarPoint.Win.Chart.IndexAxisType.Text
                    '    Next

                    'End If


                    Dim Label As New FarPoint.Win.Chart.LabelArea()
                    Label.Text = D9914.NameChart
                    Label.Border = New FarPoint.Win.Chart.SolidLine(System.Drawing.Color.Blue)
                    Label.Fill = New FarPoint.Win.Chart.SolidFill(System.Drawing.Color.Yellow)
                    Label.Location = New PointF(0.5F, 0.02F)
                    Label.TextFont = New System.Drawing.Font("Tahoma", 10)
                    Label.TextFill = New FarPoint.Win.Chart.SolidFill(System.Drawing.Color.Black)

                    Dim model As New FarPoint.Win.Chart.ChartModel()
                    model.PlotAreas.Add(LineplotArea)
                    model.LabelAreas.Add(Label)

                    Dim chart As New FarPoint.Win.Spread.Chart.SpreadChart()
                    chart.Model = model
                    'chart.Size = New Size(spr.Size.Width, spr.Size.Height)
                    'chart.Location = New Point(0, 0)
                    spr.ActiveSheet.Charts.Add(chart)
                    '  If D9914.ChartVisible = "1" Then spr.ActiveSheet.Charts(0).Visible = True Else spr.ActiveSheet.Charts(0).Visible = False
                End If

                If D9914.BarBase <> "" Then
                    Dim Line() As FarPoint.Win.Chart.BarSeries
                    Dim Lineseries As New FarPoint.Win.Chart.ClusteredBarSeries()

                    Dim LineRc As Integer
                    LineRc = Split(D9914.BarBase, ",").Length - 1
                    ReDim Line(LineRc)

                    For i = 0 To LineRc
                        Line(i) = New FarPoint.Win.Chart.BarSeries
                        ' Line(i).SeriesName = spr.ActiveSheet.Columns(Split(D9914.BarBase, ",")(i)).Tag
                        Line(i).SeriesName = spr.ActiveSheet.ColumnHeader.Columns(CIntp(Split(D9914.BarBase, ",")(i))).Label
                        Lineseries.Series.Add(Line(i))
                    Next

                    BarplotArea.Series.Add(Lineseries)

                    If D9914.Header = "1" Then
                        For j = 1 To spr.ActiveSheet.RowCount - 1
                            For i = 0 To LineRc
                                Line(i).Values.Add(getData(spr, CIntp(Split(D9914.BarBase, ",")(i)), j))
                            Next
                        Next
                    Else
                        For j = 0 To spr.ActiveSheet.RowCount - 1
                            For i = 0 To LineRc
                                Line(i).Values.Add(getData(spr, CIntp(Split(D9914.BarBase, ",")(i)), j))
                            Next
                        Next
                    End If

                    Dim Label As New FarPoint.Win.Chart.LabelArea()
                    Label.Text = D9914.NameChart
                    Label.Border = New FarPoint.Win.Chart.SolidLine(System.Drawing.Color.Blue)
                    Label.Fill = New FarPoint.Win.Chart.SolidFill(System.Drawing.Color.Yellow)
                    Label.Location = New PointF(0.5F, 0.02F)
                    Label.TextFont = New System.Drawing.Font("Tahoma", 10)
                    Label.TextFill = New FarPoint.Win.Chart.SolidFill(System.Drawing.Color.Black)

                    Dim model As New FarPoint.Win.Chart.ChartModel()
                    model.PlotAreas.Add(BarplotArea)
                    model.LabelAreas.Add(Label)

                    Dim chart As New FarPoint.Win.Spread.Chart.SpreadChart()
                    chart.Model = model
                    spr.ActiveSheet.Charts.Add(chart)
                End If


                If D9914.PieBase <> "" Then
                    Dim Line() As FarPoint.Win.Chart.PieSeries
                    Dim LineRc As Integer
                    LineRc = Split(D9914.PieBase, ",").Length - 1

                    ReDim Line(LineRc)
                    For i = 0 To 0
                        Line(i) = New FarPoint.Win.Chart.PieSeries
                        Line(i).SeriesName = spr.ActiveSheet.ColumnHeader.Columns(CIntp(Split(D9914.PieBase, ",")(i))).Label
                        PieplotArea.Series.Add(Line(i))
                    Next

                    If D9914.Header = "1" Then
                        For i = 0 To LineRc
                            Line(0).Values.Add(CDecp(getData(spr, CIntp(Split(D9914.PieBase, ",")(i)), 0)))
                        Next

                        Dim Label As New FarPoint.Win.Chart.LabelArea()
                        Label.Text = D9914.NameChart
                        Label.Border = New FarPoint.Win.Chart.SolidLine(System.Drawing.Color.Blue)
                        Label.Fill = New FarPoint.Win.Chart.SolidFill(System.Drawing.Color.Yellow)
                        Label.Location = New PointF(0.5F, 0.02F)
                        Label.TextFont = New System.Drawing.Font("Tahoma", 10)
                        Label.TextFill = New FarPoint.Win.Chart.SolidFill(System.Drawing.Color.Black)

                        Dim legend As New FarPoint.Win.Chart.LegendArea()
                        legend.Location = New PointF(0.98F, 0.5F)
                        legend.AlignmentX = 1.0F
                        legend.AlignmentY = 0.5F


                        Dim model As New FarPoint.Win.Chart.ChartModel()
                        model.PlotAreas.Add(PieplotArea)
                        model.LegendAreas.Add(legend)
                        model.LabelAreas.Add(Label)

                        Dim chart As New FarPoint.Win.Spread.Chart.SpreadChart()
                        chart.Model = model
                        chart.ViewType = FarPoint.Win.Chart.ChartViewType.View2D

                        spr.ActiveSheet.Charts.Add(chart)
                        'If D9914.ChartVisible = "1" Then spr.ActiveSheet.Charts(2).Visible = True Else spr.ActiveSheet.Charts(1).Visible = False
                    End If

                End If

                For i = 0 To spr.ActiveSheet.Charts.Count - 1
                    spr.ActiveSheet.Charts(i).Size = New Size(spr.Size.Width / spr.ActiveSheet.Charts.Count, spr.Size.Height)
                    spr.ActiveSheet.Charts(i).Location = New Point(0 + i * spr.Size.Width / spr.ActiveSheet.Charts.Count, 0)
                Next

            End If

            spr.ResumeLayout(True)
            spr.SearchChk = True

            If D9914.Header = "1" Then
                spr.ActiveSheet.ActiveRowIndex = 1
                spr.Select()
            Else
                spr.ActiveSheet.ActiveRowIndex = 0
                spr.Select()
            End If

            MdiMenu.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBoxP(program & sheetname, vbCritical)
            If spr IsNot Nothing Then spr.ResumeLayout(True)
            If D9914.Header = "1" Then
                spr.ActiveSheet.ActiveRowIndex = 1
                spr.Select()
            Else
                spr.ActiveSheet.ActiveRowIndex = 0
                spr.Select()
            End If
            If DATAreader IsNot Nothing Then
                If DATAreader.IsClosed = False Then
                    DATAreader.Close()
                End If
            End If
        Finally
            MdiMenu.Cursor = Cursors.Default
            'apiBlockInput(0)
        End Try
    End Sub

    Public Sub Sheet_Print(sender As PeaceFarpoint, ReportName As String, VbResult As String)
        Try
            'DataValue = sender.Tag.ToString.Split(";")

            'If UBound(DataValue) = 1 Then

            '    If READ_PFK9912_1(DataValue(0), DataValue(1)) Then
            '        ReportName = D9912.ReportName
            '    End If
            'End If

            Dim pi As New FarPoint.Win.Spread.PrintInfo()
            Dim rules As New FarPoint.Win.Spread.SmartPrintRulesCollection

            rules.Add(New FarPoint.Win.Spread.ScaleRule(FarPoint.Win.Spread.ResetOption.None, 1, 0.1, 0.01))

            rules.Add(New FarPoint.Win.Spread.BestFitColumnRule(FarPoint.Win.Spread.ResetOption.None))

            rules.Add(New FarPoint.Win.Spread.LandscapeRule(FarPoint.Win.Spread.ResetOption.None))

            pi.SmartPrintRules = rules

            If VbResult = vbYes Then pi.Orientation = PrintOrientation.Portrait
            If VbResult = vbNo Then pi.Orientation = PrintOrientation.Landscape

            With pi

                .ZoomFactor = 1
                .FirstPageNumber = 1

                .PrintType = FarPoint.Win.Spread.PrintType.CellRange
                .PageOrder = FarPoint.Win.Spread.PrintPageOrder.OverThenDown
                .BestFitCols = False
                .BestFitRows = False
                .PageStart = -1
                .PageEnd = -1

                .Header = "/fn" & Chr(34) & "굴림" & Chr(34) & "/fz" & Chr(34) & "14.25" & Chr(34) & "/fb1/fi0/fu0/fk0/c" & ReportName & Chr(10) & "Print Date: " & FSDate(Pub.DAT) & "/n"
                .Centering = FarPoint.Win.Spread.Centering.Horizontal

                .Preview = True
                .ShowBorder = False
                .ShowGrid = True
                .ShowColor = True
                .ShowShadows = True
                .ShowColumnHeader = FarPoint.Win.Spread.PrintHeader.Show
                .ShowRowHeader = FarPoint.Win.Spread.PrintHeader.Show
                .ShowColumnFooter = FarPoint.Win.Spread.PrintHeader.Inherit
                .ShowColumnFooterEachPage = True
                .ShowTitle = FarPoint.Win.Spread.PrintTitle.Inherit
                .ShowSubtitle = FarPoint.Win.Spread.PrintTitle.Inherit
                .ShowPrintDialog = False
                .UseMax = True
                .UseSmartPrint = True


                .Opacity = 255
                .PrintNotes = FarPoint.Win.Spread.PrintNotes.None
                .PrintShapes = True


                .RepeatColStart = -1
                .RepeatColEnd = -1
                .RepeatRowStart = 1
                .SmartPrintPagesTall = 100
                .SmartPrintPagesWide = 1
                .HeaderHeight = -1
                .FooterHeight = -1

                .PrintToPdf = False
                .PdfWriteMode = 0
                .PdfWriteTo = 0

                .Margin.Top = 20




                .ShowPrintDialog = True
            End With


            sender.Sheets(0).PrintInfo = pi

            sender.PrintSheet(0)

            Exit Sub

        Catch ex As Exception
            MsgBoxP(ex.Message)
        End Try
    End Sub

    Public Sub Sheet_Print_NotFix(sender As PeaceFarpoint, ReportName As String, VbResult As String)
        Try
            'DataValue = sender.Tag.ToString.Split(";")

            'If UBound(DataValue) = 1 Then

            '    If READ_PFK9912_1(DataValue(0), DataValue(1)) Then
            '        ReportName = D9912.ReportName
            '    End If
            'End If

            Dim pi As New FarPoint.Win.Spread.PrintInfo()
            'Dim rules As New FarPoint.Win.Spread.SmartPrintRulesCollection

            ''rules.Add(New FarPoint.Win.Spread.ScaleRule(FarPoint.Win.Spread.ResetOption.None, 1, 0.1, 0.01))

            'rules.Add(New FarPoint.Win.Spread.BestFitColumnRule(FarPoint.Win.Spread.ResetOption.None))

            'rules.Add(New FarPoint.Win.Spread.LandscapeRule(FarPoint.Win.Spread.ResetOption.None))

            'pi.SmartPrintRules = rules

            If VbResult = vbYes Then pi.Orientation = PrintOrientation.Portrait
            If VbResult = vbNo Then pi.Orientation = PrintOrientation.Landscape

            With pi

                .ZoomFactor = 1
                .FirstPageNumber = 1

                .PrintType = FarPoint.Win.Spread.PrintType.CellRange
                .PageOrder = FarPoint.Win.Spread.PrintPageOrder.OverThenDown
                .BestFitCols = False
                .BestFitRows = False
                .PageStart = -1
                .PageEnd = -1

                .Header = "/fn" & Chr(34) & "굴림" & Chr(34) & "/fz" & Chr(34) & "14.25" & Chr(34) & "/fb1/fi0/fu0/fk0/c" & ReportName & Chr(10) & "Print Date: " & FSDate(Pub.DAT) & "/n"
                .Centering = FarPoint.Win.Spread.Centering.Horizontal

                .Preview = True
                .ShowBorder = False
                .ShowGrid = True
                .ShowColor = True
                .ShowShadows = True

                .ShowColumnHeader = FarPoint.Win.Spread.PrintHeader.Show
                .ShowRowHeader = FarPoint.Win.Spread.PrintHeader.Show
                .ShowColumnFooter = FarPoint.Win.Spread.PrintHeader.Inherit

                .ShowColumnFooterEachPage = True
                .ShowTitle = FarPoint.Win.Spread.PrintTitle.Inherit
                .ShowSubtitle = FarPoint.Win.Spread.PrintTitle.Inherit
                .ShowPrintDialog = False
                .UseMax = True
                .UseSmartPrint = True


                .Opacity = 255
                .PrintNotes = FarPoint.Win.Spread.PrintNotes.None
                .PrintShapes = True


                .RepeatColStart = -1
                .RepeatColEnd = -1
                .RepeatRowStart = 1

                .SmartPrintPagesTall = 100
                .SmartPrintPagesWide = 1

                .HeaderHeight = -1
                .FooterHeight = -1

                .PrintToPdf = False
                .PdfWriteMode = 0
                .PdfWriteTo = 0

                .Margin.Top = 20




                .ShowPrintDialog = True
            End With


            sender.Sheets(0).PrintInfo = pi

            sender.PrintSheet(0)

            Exit Sub

        Catch ex As Exception
            MsgBoxP(ex.Message)
        End Try
    End Sub

    Public Sub Sheet_Print_New(sender As PeaceFarpoint, ReportName As String, VbResult As String)
        Try
            Dim pi As New FarPoint.Win.Spread.PrintInfo()
            Dim rules As New FarPoint.Win.Spread.SmartPrintRulesCollection

            rules.Add(New FarPoint.Win.Spread.ScaleRule(FarPoint.Win.Spread.ResetOption.None, 1, 0.1, 0.01))

            rules.Add(New FarPoint.Win.Spread.BestFitColumnRule(FarPoint.Win.Spread.ResetOption.None))

            rules.Add(New FarPoint.Win.Spread.LandscapeRule(FarPoint.Win.Spread.ResetOption.None))

            pi.SmartPrintRules = rules

            If VbResult = vbYes Then pi.Orientation = PrintOrientation.Portrait
            If VbResult = vbNo Then pi.Orientation = PrintOrientation.Landscape

            With pi

                .ZoomFactor = 1
                .FirstPageNumber = 1

                .PrintType = FarPoint.Win.Spread.PrintType.CellRange
                .PageOrder = FarPoint.Win.Spread.PrintPageOrder.OverThenDown
                .BestFitCols = False
                .BestFitRows = False
                .PageStart = -1
                .PageEnd = -1

                .Centering = FarPoint.Win.Spread.Centering.Horizontal

                If pi.Orientation = PrintOrientation.Portrait = 0 Then
                    pi.PaperSize = New Printing.PaperSize("A4", 827, 1169)
                Else
                    pi.PaperSize = New Printing.PaperSize("A4", 1169, 827)
                End If

                .Preview = True
                .ShowBorder = False
                .ShowGrid = False
                .ShowColor = True
                .ShowShadows = True
                .ShowColumnHeader = False
                .ShowRowHeader = False
                .ShowColumnFooter = FarPoint.Win.Spread.PrintHeader.Inherit
                .ShowColumnFooterEachPage = True
                .ShowTitle = FarPoint.Win.Spread.PrintTitle.Inherit
                .ShowSubtitle = FarPoint.Win.Spread.PrintTitle.Inherit
                .ShowPrintDialog = False
                .UseMax = True

                .Opacity = 255
                .PrintNotes = FarPoint.Win.Spread.PrintNotes.None
                .PrintShapes = True


                .RepeatColStart = -1
                .RepeatColEnd = -1
                .RepeatRowStart = 1
                .SmartPrintPagesTall = 100
                .SmartPrintPagesWide = 1
                .HeaderHeight = -1
                .FooterHeight = -1

                .PrintToPdf = False
                .PdfWriteMode = 0
                .PdfWriteTo = 0

                .Margin.Top = 20
                .ShowPrintDialog = True


            End With

            sender.Sheets(0).ColumnHeader.Visible = False
            sender.Sheets(0).RowHeader.Visible = False

            sender.Sheets(0).PrintInfo = pi

            sender.PrintSheet(0)

            Exit Sub

        Catch ex As Exception
            MsgBoxP(ex.Message)
        End Try
    End Sub

    Public Sub VsSizeRange(sender As PeaceFarpoint, ProgramName As String, ParamArray Para() As String)
        Dim FixCol As Integer
        Dim i, j As Integer

        DS2 = PrcDS(ProgramName, cn, Para)

        sender.ActiveSheet.ColumnHeader.Rows.Add(0, GetDsRc(DS2))
        FixCol = getColumIndex(sender, "SizeRangeName")

        If FixCol = -1 Then FixCol = getColumIndex(sender, "cdSizeRangeName")

        sender.ActiveSheet.ColumnHeader.Rows(0, GetDsRc(DS2)).Height = cSprRowHeaderHeight_25
        sender.ActiveSheet.ColumnHeader.Cells(0, 0, sender.ActiveSheet.ColumnHeader.RowCount - 2, FixCol - 1).BackColor = Color.White

        sender.ActiveSheet.ColumnHeader.Cells(0, 0).RowSpan = GetDsRc(DS2)
        sender.ActiveSheet.ColumnHeader.Cells(0, 0).ColumnSpan = FixCol

        For i = 0 To GetDsRc(DS2) - 1
            If i = 0 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Aquamarine
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 1 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.LawnGreen
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 2 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Gold
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 3 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.LightPink
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 4 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Orange
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 5 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Yellow
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 6 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.DarkTurquoise
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            End If

            For j = 0 To 30
                setDataCH(sender, FixCol + j, i, GetDsData(DS2, i, j))
            Next
        Next
    End Sub
    Public Sub VsSizeRangeTitle_FixColumn(sender As PeaceFarpoint, ProgramName As String, ColumneName As String, ParamArray Para() As String)
        Dim FixCol As Integer
        Dim i, j As Integer

        DS2 = PrcDS(ProgramName, cn, Para)

        sender.ActiveSheet.ColumnHeader.Rows.Add(0, GetDsRc(DS2))
        FixCol = getColumIndex(sender, ColumneName)

        If FixCol = -1 Then FixCol = getColumIndex(sender, ColumneName)

        sender.ActiveSheet.ColumnHeader.Rows(0, GetDsRc(DS2)).Height = cSprRowHeaderHeight_25
        sender.ActiveSheet.ColumnHeader.Cells(0, 0, sender.ActiveSheet.ColumnHeader.RowCount - 2, FixCol - 1).BackColor = Color.White

        sender.ActiveSheet.ColumnHeader.Cells(0, 0).RowSpan = GetDsRc(DS2)
        sender.ActiveSheet.ColumnHeader.Cells(0, 0).ColumnSpan = FixCol

        FixCol = FixCol
        For i = 0 To GetDsRc(DS2) - 1
            If i = 0 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Aquamarine
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 1 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.LawnGreen
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 2 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Gold
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 3 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.LightPink
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 4 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Orange
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 5 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Yellow
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 6 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.DarkTurquoise
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            End If

            FixCol = FixCol
            setDataCH(sender, FixCol, i, GetDsData(DS2, i, j))


            For j = 0 To 30
                setDataCH(sender, FixCol + j, i, GetDsData(DS2, i, j))
            Next
        Next
    End Sub
    Public Sub VsSizeRangeTitle(sender As PeaceFarpoint, ProgramName As String, ParamArray Para() As String)
        Dim FixCol As Integer
        Dim i, j As Integer

        DS2 = PrcDS(ProgramName, cn, Para)

        sender.ActiveSheet.ColumnHeader.Rows.Add(0, GetDsRc(DS2))
        FixCol = getColumIndex(sender, "SlNo")

        If FixCol = -1 Then FixCol = getColumIndex(sender, "SlNo")

        sender.ActiveSheet.ColumnHeader.Rows(0, GetDsRc(DS2)).Height = cSprRowHeaderHeight_25
        sender.ActiveSheet.ColumnHeader.Cells(0, 0, sender.ActiveSheet.ColumnHeader.RowCount - 2, FixCol - 1).BackColor = Color.White

        sender.ActiveSheet.ColumnHeader.Cells(0, 0).RowSpan = GetDsRc(DS2)
        sender.ActiveSheet.ColumnHeader.Cells(0, 0).ColumnSpan = FixCol

        FixCol = FixCol + 1
        For i = 0 To GetDsRc(DS2) - 1
            If i = 0 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Aquamarine
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 1 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.LawnGreen
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 2 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Gold
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 3 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.LightPink
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 4 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Orange
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 5 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Yellow
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 6 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.DarkTurquoise
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            End If

            FixCol = FixCol - 1
            setDataCH(sender, FixCol, i, GetDsData(DS2, i, j))


            For j = 0 To 30
                setDataCH(sender, FixCol + j, i, GetDsData(DS2, i, j))
            Next
        Next
    End Sub
    Public Sub VsSizeRangeNew(sender As PeaceFarpoint, ProgramName As String, FixColstr As String, ParamArray Para() As String)
        Dim FixCol As Integer
        Dim i, j As Integer

        DS2 = PrcDS(ProgramName, cn, Para)

        FixCol = getColumIndex(sender, FixColstr)

        If FixCol < 1 Then Exit Sub

        'FixCol -= 1

        For i = 0 To GetDsRc(DS2) - 1
            If i = 0 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.White

            ElseIf i = 1 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.LawnGreen
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 2 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Gold
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 3 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.LightPink
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 4 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Orange
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 5 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Yellow
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 6 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.DarkTurquoise
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            End If

            For j = 0 To 30
                setDataCH(sender, FixCol + j, i, GetDsData(DS2, i, j))
            Next
        Next
    End Sub
    Public Sub VsSizeRangeTool(sender As PeaceFarpoint, ProgramName As String, ParamArray Para() As String)
        Dim FixCol As Integer
        Dim i, j As Integer

        DS2 = PrcDS(ProgramName, cn, Para)

        sender.ActiveSheet.ColumnHeader.Rows.Add(0, GetDsRc(DS2))
        FixCol = getColumIndex(sender, "SizeRangeToolName")

        sender.ActiveSheet.ColumnHeader.Rows(0, GetDsRc(DS2)).Height = cSprRowHeaderHeight_25
        sender.ActiveSheet.ColumnHeader.Cells(0, 0, sender.ActiveSheet.ColumnHeader.RowCount - 2, FixCol - 1).BackColor = Color.White

        sender.ActiveSheet.ColumnHeader.Cells(0, 0).RowSpan = GetDsRc(DS2)
        sender.ActiveSheet.ColumnHeader.Cells(0, 0).ColumnSpan = FixCol

        For i = 0 To GetDsRc(DS2) - 1
            If i = 0 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Aquamarine
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 1 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.LawnGreen
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 2 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Gold
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 3 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.LightPink
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 4 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Orange
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 5 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.Yellow
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            ElseIf i = 6 Then
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).BackColor = Color.DarkTurquoise
                sender.ActiveSheet.ColumnHeader.Cells(i, FixCol, i, sender.ActiveSheet.ColumnCount - 1).ForeColor = Color.Black

            End If

            For j = 0 To 30
                setDataCH(sender, FixCol + j, i, GetDsData(DS2, i, j))
            Next
        Next
    End Sub
    Public Sub SPR_HIDE_Start_End(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal check As Boolean, ByVal scolumn As Integer, ByVal ecolumn As Integer)
        Dim i As Integer
        Try
            For i = scolumn To ecolumn
                spr.ActiveSheet.Columns(i).Visible = check
            Next
        Catch ex As Exception

        End Try
    End Sub
    Public Sub SPR_PRO_NEW(ByRef spr As PeaceFarpoint, datatr As DataSet, program As String, sheetname As String, Optional ByVal Chk As Boolean = False, Optional ByVal ChkLoop As Boolean = False)
        If CheckPFPAll = True Then
            If program.Contains("PFP") Then
                Call SPR_PRO_NEW_PFP(spr, datatr, program, sheetname, Chk)
                Exit Sub
            End If
        End If

        If datatr Is Nothing Then Exit Sub

        Dim header As Boolean = False

        Dim DATAreader As SqlClient.SqlDataReader
        Dim ColumnName As String
        Dim DataConvert() As String
        Dim i, j As Integer
        Dim str(), str1() As String

        Dim ChkUser As Boolean = False

        spr.SuspendLayout()
        DATAreader = Nothing
        spr.Tag = program & ";" & sheetname

        MdiMenu.Cursor = Cursors.WaitCursor

        Try
            If READ_PFK9914("DMS", program, sheetname) = True Then
                SPR_SET(spr, D9914.ColsFrozen,
                            D9914.RowsFrozen,
                            D9914.MaxRows,
                            D9914.OperationMode,
                            CboolP(D9914.Lock),
                            CboolP(D9914.DefaultRowHeight),
                            CboolP(D9914.HeaderTextMode),
                            CboolP(D9914.RetainSelectionBlock),
                            D9914.Fontsize,
                            D9914.Rowheight,
                            D9914.AutoClip,
                            False)
                header = CboolP(D9914.Header)
            End If

            spr.ActiveSheet.RowCount = 0
            spr.ActiveSheet.ColumnCount = 0
            spr.ActiveSheet.ColumnHeader.RowCount = 1
            spr.ActiveSheet.ColumnHeader.Rows(0).Height = cSprRowHeaderHeight
            spr.ActiveSheet.ColumnCount = GetDsCc(datatr)

            Dim RowCount As Integer
            Dim ColumnCount As Integer

            RowCount = GetDsRc(datatr)
            ColumnCount = GetDsCc(datatr)

            If RowCount > 1000000 And ChkLoop = False Then
                PRG_SET(ProgressBar1, RowCount)
                spr.ActiveSheet.RowCount = RowCount

                For i = 0 To RowCount - 1
                    PRG_VALUE(ProgressBar1, i + 1)

                    For j = 0 To ColumnCount - 1
                        'spr.ActiveSheet.Cells(i, j).Value = datatr.Tables(0).Rows(i).Item(j)
                        setData(spr, j, i, datatr.Tables(0).Rows(i).Item(j))
                    Next
                Next

            Else
                spr.ActiveSheet.RowCount = RowCount
                spr.ActiveSheet.DataSource = datatr.Tables(0)
            End If

            If CDecp(D9914.ZoomSize) < 1 Or CDecp(D9914.ZoomSize) > 5 Then spr.ActiveSheet.ZoomFactor = 1 Else spr.ActiveSheet.ZoomFactor = CDecp(D9914.ZoomSize)

            If D9914.Footer = "1" Then
                spr.ActiveSheet.ColumnFooter.Visible = True
                spr.ActiveSheet.ColumnFooter.RowCount = 1
                spr.ActiveSheet.ColumnFooter.Rows(0).BackColor = SystemColors.Info
                spr.ActiveSheet.ColumnFooter.Rows(0).ForeColor = Color.Black
            ElseIf header = True Then
                spr.ActiveSheet.ColumnFooter.Visible = False
                spr.ActiveSheet.ColumnFooter.RowCount = 1
                spr.ActiveSheet.ColumnFooter.Rows(0).BackColor = SystemColors.Info
                spr.ActiveSheet.ColumnFooter.Rows(0).ForeColor = Color.Black

                spr.ActiveSheet.Rows.Add(0, 1)
                SPR_BACKCOLORROWTOTAL(spr, cRelation3HeaderColor, 0)
                spr.ActiveSheet.FrozenRowCount = 1
                RowCount += 1
            End If

            Dim CheckMas As Boolean = False

            For i = 0 To ColumnCount - 1
BEGIN:
                ColumnName = getColumName(datatr, i)

                Call D9912_CLEAR()

                If READ_PFK9912_2("DMS", program, sheetname, ColumnName) Then
                    If D9912.CheckDev = "1" Then
                        spr.ActiveSheet.ColumnHeader.Columns(i).Label = D9912.ItemNameSimply : CheckMas = True
                    Else
                        CheckMas = False

                    End If
                End If

                ChkUser = False

                DATAreader = PrcDRSheet("USP_SPREAD_PROGRAM_SEARCH_ITEMNAME_SANO", cn, Pub.SAW, program, sheetname, ColumnName)
                If DATAreader.HasRows = False Then
                    DATAreader.Close()
                    DATAreader = PrcDRSheet("USP_SPREAD_PROGRAM_SEARCH_ITEMNAME", cn, program, sheetname, ColumnName)
                Else
                    ChkUser = True
                End If

                If DATAreader.HasRows Then
                    DATAreader.Read()

                    If CheckMas = False Then
                        If MdiMenu.M20001.Checked = True Then spr.ActiveSheet.ColumnHeader.Columns(i).Label = DATAreader("K9911_ItemNameSimply")
                        If MdiMenu.M20002.Checked = True Then spr.ActiveSheet.ColumnHeader.Columns(i).Label = DATAreader("K9911_ItemNameForeign1")
                    Else
                        If MdiMenu.M20001.Checked = True Then spr.ActiveSheet.ColumnHeader.Columns(i).Label = D9912.ItemNameSimply
                        If MdiMenu.M20002.Checked = True Then spr.ActiveSheet.ColumnHeader.Columns(i).Label = D9912.ItemNameForeign1
                    End If

                    spr.ActiveSheet.ColumnHeader.Columns(i).Tag = DATAreader("K9911_ItemName").ToString.ToUpper

                    If DATAreader("K9911_Hidden") = "1" Then spr.ActiveSheet.Columns(i).Visible = True Else spr.ActiveSheet.Columns(i).Visible = False

                    Dim str_Visible As String
                    str_Visible = DATAreader("K9911_DataType")

                    If spr.ActiveSheet.Columns(i).Visible = False Then str_Visible = 100

                    Select Case str_Visible

                        Case 0, 6
                            Call SPR_TEXTBOX(spr, i, DATAreader("K9911_DataSize"))

                            If header = False Then Exit Select

                            If DATAreader("K9911_CheckHead") <> "1" Then
                                Exit Select
                            Else
                                If D9914.Footer = "1" Then
                                    Dim Formula1 As String
                                    Formula1 = "SUBTOTAL(103," & spr.ActiveSheet.GetColumnAutoText(i) & "1:" & spr.ActiveSheet.GetColumnAutoText(i) & spr.ActiveSheet.RowCount & ")"
                                    SPR_NUMBERCELLFOOTER(spr, DATAreader("K9911_DataDecimal"), CIntp(DATAreader("K9911_DataSize")), i)
                                    spr.ActiveSheet.ColumnFooter.SetAggregationType(0, i, Model.AggregationType.CountAIgnoreHidden)
                                End If
                                Exit Select
                            End If

                            spr.ActiveSheet.Cells(0, i).Formula = "SUBTOTAL(103," & spr.ActiveSheet.GetColumnAutoText(i) & "2:" & spr.ActiveSheet.GetColumnAutoText(i) & spr.ActiveSheet.RowCount & ")"

                            SPR_NUMBERCELLFOOTER(spr, DATAreader("K9911_DataDecimal"), CIntp(DATAreader("K9911_DataSize")), i)
                            spr.ActiveSheet.ColumnFooter.SetAggregationType(0, i, Model.AggregationType.CountAIgnoreHidden)
                        Case 1
                            Call SPR_NUMBERCELL(spr, DATAreader("K9911_DataDecimal"), CIntp(DATAreader("K9911_DataSize")), i)

                            If D9914.Footer = "1" Then
                                Dim Formula1 As String
                                Formula1 = "SUBTOTAL(109," & spr.ActiveSheet.GetColumnAutoText(i) & "1:" & spr.ActiveSheet.GetColumnAutoText(i) & spr.ActiveSheet.RowCount & ")"
                                SPR_NUMBERCELLFOOTER(spr, DATAreader("K9911_DataDecimal"), CIntp(DATAreader("K9911_DataSize")), i)
                                spr.ActiveSheet.ColumnFooter.SetAggregationType(0, i, Model.AggregationType.SumIgnoreHidden)
                                Exit Select
                            End If

                            If header = False Then
                                Exit Select
                            End If


                            Dim FixAmount As Decimal = 0
                            Dim ConAmount As Decimal = 0
                            Dim HeadAmount As Decimal = 0
                            Dim HeadCount As Integer = 0

                            'If DATAreader("K9911_CheckHead") <> "1" Then Exit Select

                            If DATAreader("K9911_CheckHead") <> "1" Then
                                Exit Select

                            End If

                            If DATAreader("K9911_CheckHeadType") = "0" Then
                                For j = 1 To RowCount - 1
                                    ConAmount = CDecp(getData(spr, i, j))
                                    HeadAmount += ConAmount
                                Next
                                setData(spr, i, 0, HeadAmount)

                                If D9914.Footer = "1" Then
                                    Dim Formula As String
                                    Formula = "SUBTOTAL(109," & spr.ActiveSheet.GetColumnAutoText(i) & "2:" & spr.ActiveSheet.GetColumnAutoText(i) & spr.ActiveSheet.RowCount & ")"
                                    spr.ActiveSheet.Cells(0, i).Formula = Formula

                                    SPR_NUMBERCELLFOOTER(spr, DATAreader("K9911_DataDecimal"), CIntp(DATAreader("K9911_DataSize")), i)
                                    spr.ActiveSheet.ColumnFooter.SetAggregationType(0, i, Model.AggregationType.SumIgnoreHidden)
                                    spr.ActiveSheet.ColumnFooter.Cells(0, i).Formula = Formula
                                End If

                            ElseIf DATAreader("K9911_CheckHeadType") = "1" And DATAreader("K9911_REMK").ToString.Trim <> "" Then
                                DataConvert = Split(DATAreader("K9911_REMK").ToString.Trim, ";")

                                For j = 1 To RowCount - 1
                                    ConAmount += CDecp(getData(spr, DataConvert(0), j))
                                    HeadCount += CDecp(getData(spr, DataConvert(1), j))
                                Next
                                If HeadCount > 0 Then setData(spr, i, 0, ConAmount / HeadCount * 100)

                            ElseIf DATAreader("K9911_CheckHeadType") = "1" Then
                                Dim Formula As String
                                Formula = "SUBTOTAL(101," & spr.ActiveSheet.GetColumnAutoText(i) & "2:" & spr.ActiveSheet.GetColumnAutoText(i) & spr.ActiveSheet.RowCount & ")"
                                spr.ActiveSheet.Cells(0, i).Formula = Formula

                                SPR_NUMBERCELLFOOTER(spr, DATAreader("K9911_DataDecimal"), CIntp(DATAreader("K9911_DataSize")), i)
                                spr.ActiveSheet.ColumnFooter.SetAggregationType(0, i, Model.AggregationType.AvgIgnoreHidden)

                            Else
                                Dim Formula As String
                                Formula = "SUBTOTAL(103," & spr.ActiveSheet.GetColumnAutoText(i) & "2:" & spr.ActiveSheet.GetColumnAutoText(i) & spr.ActiveSheet.RowCount & ")"
                                spr.ActiveSheet.Cells(0, i).Formula = Formula

                                SPR_NUMBERCELLFOOTER(spr, DATAreader("K9911_DataDecimal"), CIntp(DATAreader("K9911_DataSize")), i)
                                spr.ActiveSheet.ColumnFooter.SetAggregationType(0, i, Model.AggregationType.CountAIgnoreHidden)
                            End If

                        Case 2
                            If ColumnName = "PrescriptionWeavingCheck" Or ColumnName = "PrescriptionProductionCheck" Then
                                For j = 0 To RowCount - 1
                                    If GetDsData(datatr, j, "CheckPrescription") = True Then
                                        SPR_BUTTON_S(spr, i, j, getData(spr, i, j))
                                    End If
                                Next
                            Else
                                SPR_BUTTON(spr, i)
                            End If

                        Case 3
                            Call SPR_COMBOBOX(spr, i, Split(DATAreader("K9911_REMK").ToString.Trim, ";"))

                            For j = 0 To RowCount - 1
                                setDataCB(spr, i, j, getData(spr, i, j))
                            Next

                        Case 4
                            Call SPR_CHECKBOX(spr, i)

                            Dim ValueChk As String
                            For j = 0 To RowCount - 1
                                ValueChk = CIntp(getData(spr, i, j))
                                setDataChk(spr, i, j, ValueChk)
                            Next

                        Case 5
                            Call SPR_DATEVALUE(spr, i)

                        Case 7
                            Call SPR_PERCENTCELL(spr, DATAreader("K9911_DataDecimal"), CIntp(DATAreader("K9911_DataSize")), i)

                            Dim FixAmount As Decimal = 0
                            Dim ConAmount As Decimal = 0
                            Dim HeadAmount As Decimal = 0
                            Dim HeadCount As Integer = 0

                            If DATAreader("K9911_CheckHead") <> "1" Then Exit Select

                            If DATAreader("K9911_CheckHeadType") = "0" Then
                                For j = 1 To RowCount - 1
                                    ConAmount = CDecp(getData(spr, i, j))
                                    HeadAmount += ConAmount
                                Next
                                setData(spr, i, 0, HeadAmount)
                            ElseIf DATAreader("K9911_CheckHeadType") = "1" Then
                                For j = 1 To RowCount - 1
                                    ConAmount = CDecp(getData(spr, i, j))
                                    HeadCount += 1
                                    HeadAmount += ConAmount
                                Next
                                setData(spr, i, 0, HeadAmount / HeadCount)
                            Else
                                For j = 1 To RowCount - 1
                                    HeadCount += 1
                                Next
                                setData(spr, i, 0, HeadCount)
                            End If

                        Case 8
                            Call SPR_IMAGE(spr, i)
                    End Select

                    spr.ActiveSheet.ColumnHeader.Columns(i).Width = DATAreader("K9911_SizeWidth")

                    If CDbl(DATAreader("K9911_SizeWidth")) = 111 Then
                        spr.ActiveSheet.ColumnHeader.Columns(i).Width = spr.ActiveSheet.ColumnHeader.Columns(i).GetPreferredWidth
                    End If
                    If CheckMas = True Then spr.ActiveSheet.ColumnHeader.Columns(i).Width = D9912.SizeWidth
                    If ChkUser = True Then spr.ActiveSheet.ColumnHeader.Columns(i).Width = DATAreader("K9911_SizeWidth")

                    str1 = Split(DATAreader("K9911_ForeColor"), "-")
                    spr.ActiveSheet.Columns(i).ForeColor = System.Drawing.Color.FromArgb(CInt(str1(0)), CInt(str1(1)), CInt(str1(2)))

                    spr.ActiveSheet.Columns(i).VerticalAlignment = DATAreader("K9911_VerticalAlignment")
                    spr.ActiveSheet.Columns(i).HorizontalAlignment = DATAreader("K9911_HorizontalAlignment")

                    If DATAreader("K9911_Lock") = "1" Then
                        spr.ActiveSheet.Columns(i).Locked = True
                    Else
                        spr.ActiveSheet.Columns(i).Locked = False

                    End If

                    If D9914.AreaColorCheck = "1" Then
                        str = Split(D9914.AreaColor, "-")
                        SPR_BackColumn(spr, System.Drawing.Color.FromArgb(CInt(str(0)), CInt(str(1)), CInt(str(2))), i)
                    Else
                        SPR_BackColumn(spr, Color.White, i)
                    End If

                    If DATAreader("K9911_BackColot") <> "255-255-255" Then
                        str = Split(DATAreader("K9911_BackColot"), "-")
                        spr.ActiveSheet.Columns(i).BackColor = System.Drawing.Color.FromArgb(CInt(str(0)), CInt(str(1)), CInt(str(2)))
                    End If
                    DATAreader.Close()

                Else
                    DATAreader.Close()

                    If READ_PFK9911(ColumnName) = True Then
                        M9911 = D9911
                        REWRITE_PFK9911(M9911)
                        M9912.ItemCode = M9911.ItemCode
                        M9912.Lock = "1"
                        M9912.Hidden = "1"
                        If Strings.Left(M9911.ItemName, 4).ToUpper = "KEY_" Then M9912.Hidden = "0"
                        M9912.ProdjectName = "DMS"
                        M9912.ProgramNo = program
                        M9912.SheetName = sheetname
                        M9912.ProgramSeq = key_count_k9912(M9912.ProdjectName, M9912.ProgramNo, M9912.SheetName)
                        WRITE_PFK9912(M9912)
                    Else

                        M9911 = D9911
                        M9911.ItemName = ColumnName
                        M9911.ItemCode = key_count()
                        M9911.ItemNameSimply = ColumnName
                        M9911.ItemNameForeign1 = ColumnName
                        M9911.ItemNameForeign2 = ColumnName
                        M9911.ProdjectName = "DMS"
                        M9911.DataType = 0
                        M9911.DataSize = 100
                        M9911.DataDecimal = 2
                        M9911.TextAlign = 2
                        M9911.HorizontalAlignment = 1
                        M9911.VerticalAlignment = 2
                        M9911.SizeWidth = 100
                        M9911.SizeHeight = 30
                        M9911.BackColot = "255-255-255"
                        M9911.ForeColor = "0-0-0"
                        M9911.FontName = "Tahoma"
                        M9911.FontSize = "9.00"
                        M9911.FontBold = "0"
                        M9911.Lock = "1"
                        M9911.Hidden = "1"
                        If Strings.Left(M9911.ItemName, 4).ToUpper = "KEY_" Then M9911.Hidden = "0"

                        If M9911.ItemName.Contains("Amount") Or M9911.ItemName.Contains("amount") _
                          Or M9911.ItemName.Contains("Price") _
                         Or M9911.ItemName.Contains("price") _
                          Or M9911.ItemName.Contains("quantity") _
                          Or M9911.ItemName.Contains("Balance") _
                          Or M9911.ItemName.Contains("balance") _
                          Or M9911.ItemName.Contains("Qty") _
                          Or M9911.ItemName.Contains("qty") _
                           Or M9911.ItemName.Contains("Quantity") Then
                            M9911.DataType = 1
                            M9911.HorizontalAlignment = 3
                        End If

                        M9911.REMK = ""
                        WRITE_PFK9911(M9911)
                        M9912.ItemCode = M9911.ItemCode
                        M9912.Lock = "1"
                        M9912.Hidden = "1"

                        If Strings.Left(M9911.ItemName, 4).ToUpper = "KEY_" Then M9912.Hidden = "0"
                        M9912.ProdjectName = "DMS"
                        M9912.ProgramNo = program
                        M9912.SheetName = sheetname
                        M9912.ProgramSeq = key_count_k9912(M9912.ProdjectName, M9912.ProgramNo, M9912.SheetName)

                        WRITE_PFK9912(M9912)
                    End If
                    GoTo BEGIN
                End If
            Next

            Dim ArrInteger(0) As Integer
            Dim ArrIntegerR(0) As Integer

            Dim ArrList() As String
            Dim ArrListR() As String

            Dim ListChk As Boolean = False
            Dim ListChkR As Boolean = False

            If D9914.MergeColumn <> "" Then
                ArrList = Split(D9914.MergeColumn, ",")
                If ArrList.Length > 0 Then
                    ReDim ArrInteger(ArrList.Length - 1)

                    For i = 0 To UBound(ArrList)
                        ArrInteger(i) = CIntp(ArrList(i))
                    Next

                    ListChk = True
                End If
            End If

            If D9914.MergeRetrict <> "" Then
                ArrListR = Split(D9914.MergeRetrict, ",")
                If ArrListR.Length > 0 Then
                    ReDim ArrIntegerR(ArrListR.Length - 1)

                    For i = 0 To UBound(ArrListR)
                        ArrIntegerR(i) = CIntp(ArrListR(i))
                    Next

                    ListChkR = True
                End If
            End If

            If CboolP(D9914.Separate) = True And CboolP(D9914.TotalSeparate) = False Then
                Call SPR_SEPARATE(spr, D9914.ColumnBase, D9914.ColumnCal)

            ElseIf CboolP(D9914.Separate) = False And CboolP(D9914.TotalSeparate) = True Then
                Call SPR_TOTAL(spr, D9914.ColumnBase, D9914.ColumnCal)

            End If
            If CboolP(D9914.Merge) = True Then
                If ListChk = True Then Call SPR_MERGEALWAYS(spr, ArrInteger)
                If ListChkR = True Then Call SPR_MERGERESTRICT(spr, ArrIntegerR)
            End If

            If D9914.HeaderColumn = "2" Then
                spr.ActiveSheet.ColumnHeaderVisible = False
            Else
                spr.ActiveSheet.ColumnHeaderVisible = True
            End If

            If D9914.HeaderRow = "2" Then
                spr.ActiveSheet.RowHeaderVisible = False
            Else
                spr.ActiveSheet.RowHeaderVisible = True
            End If

            'ADD

            If D9914.ColumnSpanID = 0 Then GoTo next1

            DS2 = PrcDSSheet("USP_SPREAD_PROGRAM_SEARCH_PFK9915", cn, "DMS", program, sheetname, D9914.ColumnSpanID)

            If GetDsRc(DS2) = 0 Then GoTo next1

            spr.ActiveSheet.ColumnHeader.RowCount = 2

            For i = 0 To GetDsRc(DS2) - 1

                If CIntp(GetDsData(DS2, i, "EndColumn")) > spr.ActiveSheet.ColumnCount - 1 Or CIntp(GetDsData(DS2, i, "BeginColumn")) > spr.ActiveSheet.ColumnCount - 1 Then
                    Continue For
                End If

                For j = CIntp(GetDsData(DS2, i, "BeginColumn")) To CIntp(GetDsData(DS2, i, "EndColumn"))
                    spr.ActiveSheet.ColumnHeader.Cells(1, j).Value = spr.ActiveSheet.ColumnHeader.Cells(0, j).Value
                Next
                spr.ActiveSheet.AddColumnHeaderSpanCell(0, CIntp(GetDsData(DS2, i, "BeginColumn")), 1, CIntp(GetDsData(DS2, i, "EndColumn")) - CIntp(GetDsData(DS2, i, "BeginColumn")) + 1)
                spr.ActiveSheet.ColumnHeader.Cells(0, CIntp(GetDsData(DS2, i, "BeginColumn"))).Value = GetDsData(DS2, i, "Title")

                If MdiMenu.M20001.Checked = True Then spr.ActiveSheet.ColumnHeader.Cells(0, CIntp(GetDsData(DS2, i, "BeginColumn"))).Value = GetDsData(DS2, i, "Title")
                If MdiMenu.M20002.Checked = True Then spr.ActiveSheet.ColumnHeader.Cells(0, CIntp(GetDsData(DS2, i, "BeginColumn"))).Value = GetDsData(DS2, i, "ForeignName1")

            Next

            For i = 0 To spr.ActiveSheet.ColumnCount - 1
                If spr.ActiveSheet.ColumnHeader.Cells(0, i).ColumnSpan = 1 Then
                    spr.ActiveSheet.ColumnHeader.Cells(0, i).RowSpan = 2
                End If

            Next

            If READ_PFK9914("DMS", program, sheetname) Then
                If D9914.ColHeader1 < 10 Then
                    spr.ActiveSheet.ColumnHeader.Rows(0).Height = cSprRowHeight
                Else
                    spr.ActiveSheet.ColumnHeader.Rows(0).Height = D9914.ColHeader1
                End If
                If D9914.ColHeader2 < 10 Then
                    spr.ActiveSheet.ColumnHeader.Rows(1).Height = cSprRowHeight
                Else
                    spr.ActiveSheet.ColumnHeader.Rows(1).Height = D9914.ColHeader2
                End If

            End If

next1:
            '-----------------------------------------CHART----------------------------------------'
            '2016/11/01
            'If D9914.Footer = "1" Then
            '    spr.ActiveSheet.ColumnHeader.RowCount += 1
            '    spr.ActiveSheet.ColumnHeader.Rows(spr.ActiveSheet.ColumnHeader.RowCount - 1).Height = cSprRowHeight
            '    spr.ActiveSheet.ColumnHeader.Rows(spr.ActiveSheet.ColumnHeader.RowCount - 1).BackColor = cRelation3HeaderColor
            '    spr.ActiveSheet.ColumnHeader.Cells(spr.ActiveSheet.ColumnHeader.RowCount - 1, 0, spr.ActiveSheet.ColumnHeader.RowCount - 1, spr.ActiveSheet.ColumnCount - 1).Value = ""
            'End If

            If D9914.Chart = "1" Then
                spr.ActiveSheet.Charts.Clear()

                Dim LineplotArea As New FarPoint.Win.Chart.YPlotArea()
                LineplotArea.Location = New PointF(0.2F, 0.2F)
                LineplotArea.Size = New SizeF(0.6F, 0.6F)

                Dim BarplotArea As New FarPoint.Win.Chart.YPlotArea()
                BarplotArea.Location = New PointF(0.2F, 0.2F)
                BarplotArea.Size = New SizeF(0.6F, 0.6F)

                Dim PieplotArea As New FarPoint.Win.Chart.PiePlotArea()
                PieplotArea.Location = New PointF(0.2F, 0.2F)
                PieplotArea.Size = New SizeF(0.6F, 0.6F)

                If D9914.LineBase <> "" Then
                    Dim Line() As FarPoint.Win.Chart.LineSeries
                    Dim LineRc As Integer
                    LineRc = Split(D9914.LineBase, ",").Length - 1
                    ReDim Line(LineRc)
                    For i = 0 To LineRc
                        Line(i) = New FarPoint.Win.Chart.LineSeries
                        Line(i).SmoothedLine = True
                        Line(i).PointMarker = New FarPoint.Win.Chart.NoMarker

                        ' Line(i).SeriesName = spr.ActiveSheet.Columns(Split(D9914.LineBase, ",")(i)).Tag
                        Line(i).SeriesName = spr.ActiveSheet.ColumnHeader.Columns(CIntp(Split(D9914.LineBase, ",")(i))).Label
                        LineplotArea.Series.Add(Line(i))

                    Next

                    If D9914.Header = "1" Then
                        For j = 1 To spr.ActiveSheet.RowCount - 1
                            For i = 0 To LineRc
                                Line(i).Values.Add(getData(spr, CIntp(Split(D9914.LineBase, ",")(i)), j))
                            Next
                        Next
                    Else
                        For j = 0 To spr.ActiveSheet.RowCount - 1
                            For i = 0 To LineRc
                                Line(i).Values.Add(getData(spr, CIntp(Split(D9914.LineBase, ",")(i)), j))
                            Next
                        Next
                    End If

                    'Dim Chuoi() As String
                    'ReDim Chuoi(spr.ActiveSheet.RowCount - 1)
                    'If D9914.Line <> "" Then


                    '    For j = 0 To spr.ActiveSheet.RowCount - 1
                    '        Chuoi(j) = getData(spr, CIntp(D9914.Line), j)

                    '        LineplotArea.XAxis.AxisType = FarPoint.Win.Chart.IndexAxisType.Text
                    '    Next

                    'End If


                    Dim Label As New FarPoint.Win.Chart.LabelArea()
                    Label.Text = D9914.NameChart
                    Label.Border = New FarPoint.Win.Chart.SolidLine(System.Drawing.Color.Blue)
                    Label.Fill = New FarPoint.Win.Chart.SolidFill(System.Drawing.Color.Yellow)
                    Label.Location = New PointF(0.5F, 0.02F)
                    Label.TextFont = New System.Drawing.Font("Tahoma", 10)
                    Label.TextFill = New FarPoint.Win.Chart.SolidFill(System.Drawing.Color.Black)

                    Dim model As New FarPoint.Win.Chart.ChartModel()
                    model.PlotAreas.Add(LineplotArea)
                    model.LabelAreas.Add(Label)

                    Dim chart As New FarPoint.Win.Spread.Chart.SpreadChart()
                    chart.Model = model
                    'chart.Size = New Size(spr.Size.Width, spr.Size.Height)
                    'chart.Location = New Point(0, 0)
                    spr.ActiveSheet.Charts.Add(chart)
                    '  If D9914.ChartVisible = "1" Then spr.ActiveSheet.Charts(0).Visible = True Else spr.ActiveSheet.Charts(0).Visible = False
                End If

                If D9914.BarBase <> "" Then
                    Dim Line() As FarPoint.Win.Chart.BarSeries
                    Dim Lineseries As New FarPoint.Win.Chart.ClusteredBarSeries()

                    Dim LineRc As Integer
                    LineRc = Split(D9914.BarBase, ",").Length - 1
                    ReDim Line(LineRc)

                    For i = 0 To LineRc
                        Line(i) = New FarPoint.Win.Chart.BarSeries
                        ' Line(i).SeriesName = spr.ActiveSheet.Columns(Split(D9914.BarBase, ",")(i)).Tag
                        Line(i).SeriesName = spr.ActiveSheet.ColumnHeader.Columns(CIntp(Split(D9914.BarBase, ",")(i))).Label
                        Lineseries.Series.Add(Line(i))
                    Next

                    BarplotArea.Series.Add(Lineseries)

                    If D9914.Header = "1" Then
                        For j = 1 To spr.ActiveSheet.RowCount - 1
                            For i = 0 To LineRc
                                Line(i).Values.Add(getData(spr, CIntp(Split(D9914.BarBase, ",")(i)), j))
                            Next
                        Next
                    Else
                        For j = 0 To spr.ActiveSheet.RowCount - 1
                            For i = 0 To LineRc
                                Line(i).Values.Add(getData(spr, CIntp(Split(D9914.BarBase, ",")(i)), j))
                            Next
                        Next
                    End If

                    Dim Label As New FarPoint.Win.Chart.LabelArea()
                    Label.Text = D9914.NameChart
                    Label.Border = New FarPoint.Win.Chart.SolidLine(System.Drawing.Color.Blue)
                    Label.Fill = New FarPoint.Win.Chart.SolidFill(System.Drawing.Color.Yellow)
                    Label.Location = New PointF(0.5F, 0.02F)
                    Label.TextFont = New System.Drawing.Font("Tahoma", 10)
                    Label.TextFill = New FarPoint.Win.Chart.SolidFill(System.Drawing.Color.Black)

                    Dim model As New FarPoint.Win.Chart.ChartModel()
                    model.PlotAreas.Add(BarplotArea)
                    model.LabelAreas.Add(Label)

                    Dim chart As New FarPoint.Win.Spread.Chart.SpreadChart()
                    chart.Model = model
                    spr.ActiveSheet.Charts.Add(chart)
                End If


                If D9914.PieBase <> "" Then
                    Dim Line() As FarPoint.Win.Chart.PieSeries
                    Dim LineRc As Integer
                    LineRc = Split(D9914.PieBase, ",").Length - 1

                    ReDim Line(LineRc)
                    For i = 0 To 0
                        Line(i) = New FarPoint.Win.Chart.PieSeries
                        Line(i).SeriesName = spr.ActiveSheet.ColumnHeader.Columns(CIntp(Split(D9914.PieBase, ",")(i))).Label
                        PieplotArea.Series.Add(Line(i))
                    Next

                    If D9914.Header = "1" Then
                        For i = 0 To LineRc
                            Line(0).Values.Add(CDecp(getData(spr, CIntp(Split(D9914.PieBase, ",")(i)), 0)))
                        Next

                        Dim Label As New FarPoint.Win.Chart.LabelArea()
                        Label.Text = D9914.NameChart
                        Label.Border = New FarPoint.Win.Chart.SolidLine(System.Drawing.Color.Blue)
                        Label.Fill = New FarPoint.Win.Chart.SolidFill(System.Drawing.Color.Yellow)
                        Label.Location = New PointF(0.5F, 0.02F)
                        Label.TextFont = New System.Drawing.Font("Tahoma", 10)
                        Label.TextFill = New FarPoint.Win.Chart.SolidFill(System.Drawing.Color.Black)

                        Dim legend As New FarPoint.Win.Chart.LegendArea()
                        legend.Location = New PointF(0.98F, 0.5F)
                        legend.AlignmentX = 1.0F
                        legend.AlignmentY = 0.5F


                        Dim model As New FarPoint.Win.Chart.ChartModel()
                        model.PlotAreas.Add(PieplotArea)
                        model.LegendAreas.Add(legend)
                        model.LabelAreas.Add(Label)

                        Dim chart As New FarPoint.Win.Spread.Chart.SpreadChart()
                        chart.Model = model
                        chart.ViewType = FarPoint.Win.Chart.ChartViewType.View2D

                        spr.ActiveSheet.Charts.Add(chart)
                        'If D9914.ChartVisible = "1" Then spr.ActiveSheet.Charts(2).Visible = True Else spr.ActiveSheet.Charts(1).Visible = False
                    End If

                End If

                For i = 0 To spr.ActiveSheet.Charts.Count - 1
                    spr.ActiveSheet.Charts(i).Size = New Size(spr.Size.Width / spr.ActiveSheet.Charts.Count, spr.Size.Height)
                    spr.ActiveSheet.Charts(i).Location = New Point(0 + i * spr.Size.Width / spr.ActiveSheet.Charts.Count, 0)
                Next

            End If

            If D9914.FixSize = "1" Then
                Dim intWith As Integer

                If D9914.HeaderRow = "2" Then
                    intWith = SPR_SHEETWIDHT(spr) + cSprWidthSize
                Else
                    intWith = SPR_SHEETWIDHT(spr) + cSprWidthSize
                End If

                Dim objParent As Object
                objParent = spr.Parent.Parent
                If TypeOf (objParent) Is SplitContainer Then
                    objParent.SplitterDistance = intWith
                End If
            End If

            'spr.ActiveSheet.RowHeader.Columns(0).Width = 50

            spr.ResumeLayout(True)
            spr.SearchChk = True

            If D9914.Header = "1" Then
                spr.ActiveSheet.ActiveRowIndex = 1
                spr.Select()
            Else
                spr.ActiveSheet.ActiveRowIndex = 0
                spr.Select()
            End If

            MdiMenu.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBoxP(program & sheetname, vbCritical)
            If spr IsNot Nothing Then spr.ResumeLayout(True)
            If D9914.Header = "1" Then
                spr.ActiveSheet.ActiveRowIndex = 1
                spr.Select()
            Else
                spr.ActiveSheet.ActiveRowIndex = 0
                spr.Select()
            End If
            If DATAreader IsNot Nothing Then
                If DATAreader.IsClosed = False Then
                    DATAreader.Close()
                End If
            End If
        Finally
            MdiMenu.Cursor = Cursors.Default



        End Try
    End Sub
    Public Sub SPR_PRO_NEW_BARCODE(ByRef spr As PeaceFarpoint, datatr As DataSet, program As String, sheetname As String, Optional ByVal Chk As Boolean = False, Optional ByVal ChkLoop As Boolean = False)

        If datatr Is Nothing Then Exit Sub

        Dim header As Boolean = False

        Dim DATAreader As SqlClient.SqlDataReader
        Dim ColumnName As String
        Dim DataConvert() As String
        Dim i, j As Integer
        Dim str(), str1() As String

        spr.SuspendLayout()
        DATAreader = Nothing
        spr.Tag = program & ";" & sheetname

        MdiMenu.Cursor = Cursors.WaitCursor

        Try
            If READ_PFK9914("DMS", program, sheetname) = True Then
                SPR_SET(spr, D9914.ColsFrozen,
                            D9914.RowsFrozen,
                            D9914.MaxRows,
                            D9914.OperationMode,
                            CboolP(D9914.Lock),
                            CboolP(D9914.DefaultRowHeight),
                            CboolP(D9914.HeaderTextMode),
                            CboolP(D9914.RetainSelectionBlock),
                            D9914.Fontsize,
                            D9914.Rowheight,
                            D9914.AutoClip,
                            False)
                header = CboolP(D9914.Header)
            End If

            spr.ActiveSheet.RowCount = 0
            spr.ActiveSheet.ColumnCount = 0
            spr.ActiveSheet.ColumnHeader.RowCount = 1
            spr.ActiveSheet.ColumnHeader.Rows(0).Height = cSprRowHeaderHeight
            spr.ActiveSheet.ColumnCount = GetDsCc(datatr)

            Dim RowCount As Integer
            Dim ColumnCount As Integer

            RowCount = GetDsRc(datatr)
            ColumnCount = GetDsCc(datatr)

            If RowCount > 1000 And ChkLoop = False Then
                PRG_SET(ProgressBar1, RowCount)
                spr.ActiveSheet.RowCount = RowCount

                For i = 0 To RowCount - 1
                    PRG_VALUE(ProgressBar1, i + 1)

                    For j = 0 To ColumnCount - 1
                        'spr.ActiveSheet.Cells(i, j).Value = datatr.Tables(0).Rows(i).Item(j)
                        setData(spr, j, i, datatr.Tables(0).Rows(i).Item(j))
                    Next
                Next

            Else
                spr.ActiveSheet.RowCount = RowCount
                spr.ActiveSheet.DataSource = datatr.Tables(0)
            End If

            If CDecp(D9914.ZoomSize) < 1 Or CDecp(D9914.ZoomSize) > 5 Then spr.ActiveSheet.ZoomFactor = 1 Else spr.ActiveSheet.ZoomFactor = CDecp(D9914.ZoomSize)

            If D9914.Footer = "1" Then
                spr.ActiveSheet.ColumnFooter.Visible = True
                spr.ActiveSheet.ColumnFooter.RowCount = 1
                spr.ActiveSheet.ColumnFooter.Rows(0).BackColor = SystemColors.Info
                spr.ActiveSheet.ColumnFooter.Rows(0).ForeColor = Color.Black
            ElseIf header = True Then
                spr.ActiveSheet.ColumnFooter.Visible = False
                spr.ActiveSheet.ColumnFooter.RowCount = 1
                spr.ActiveSheet.ColumnFooter.Rows(0).BackColor = SystemColors.Info
                spr.ActiveSheet.ColumnFooter.Rows(0).ForeColor = Color.Black

                spr.ActiveSheet.Rows.Add(0, 1)
                SPR_BACKCOLORROWTOTAL(spr, cRelation3HeaderColor, 0)
                spr.ActiveSheet.FrozenRowCount = 1
                RowCount += 1
            End If

            Dim CheckMas As Boolean = False

            For i = 0 To ColumnCount - 1
BEGIN:
                ColumnName = getColumName(datatr, i)

                Call D9912_CLEAR()

                If READ_PFK9912_2("DMS", program, sheetname, ColumnName) Then
                    If D9912.CheckDev = "1" Then
                        spr.ActiveSheet.ColumnHeader.Columns(i).Label = D9912.ItemNameSimply : CheckMas = True
                    Else
                        CheckMas = False

                    End If
                End If

                DATAreader = PrcDRSheet("USP_SPREAD_PROGRAM_SEARCH_ITEMNAME_SANO", cn, Pub.SAW, program, sheetname, ColumnName)
                If DATAreader.HasRows = False Then DATAreader.Close() : DATAreader = PrcDRSheet("USP_SPREAD_PROGRAM_SEARCH_ITEMNAME", cn, program, sheetname, ColumnName)

                If DATAreader.HasRows Then
                    DATAreader.Read()

                    If CheckMas = False Then
                        If MdiMenu.M20001.Checked = True Then spr.ActiveSheet.ColumnHeader.Columns(i).Label = DATAreader("K9911_ItemNameSimply")
                        If MdiMenu.M20002.Checked = True Then spr.ActiveSheet.ColumnHeader.Columns(i).Label = DATAreader("K9911_ItemNameForeign1")
                    Else
                        If MdiMenu.M20001.Checked = True Then spr.ActiveSheet.ColumnHeader.Columns(i).Label = D9912.ItemNameSimply
                        If MdiMenu.M20002.Checked = True Then spr.ActiveSheet.ColumnHeader.Columns(i).Label = D9912.ItemNameForeign1
                    End If

                    spr.ActiveSheet.ColumnHeader.Columns(i).Tag = DATAreader("K9911_ItemName").ToString.ToUpper
                    'spr.Range(i) = DATAreader("K9911_CheckDevValue").ToString.ToUpper

                    If DATAreader("K9911_Hidden") = "1" Then spr.ActiveSheet.Columns(i).Visible = True Else spr.ActiveSheet.Columns(i).Visible = False

                    Select Case DATAreader("K9911_DataType")

                        Case 0, 6
                            Call SPR_TEXTBOX(spr, i, DATAreader("K9911_DataSize"))

                            If header = False Then Exit Select

                            If DATAreader("K9911_CheckHead") <> "1" Then
                                Exit Select
                            Else
                                If D9914.Footer = "1" Then
                                    Dim Formula1 As String
                                    Formula1 = "SUBTOTAL(103," & spr.ActiveSheet.GetColumnAutoText(i) & "1:" & spr.ActiveSheet.GetColumnAutoText(i) & spr.ActiveSheet.RowCount & ")"
                                    SPR_NUMBERCELLFOOTER(spr, DATAreader("K9911_DataDecimal"), CIntp(DATAreader("K9911_DataSize")), i)
                                    spr.ActiveSheet.ColumnFooter.SetAggregationType(0, i, Model.AggregationType.CountAIgnoreHidden)
                                End If
                                Exit Select
                            End If

                            spr.ActiveSheet.Cells(0, i).Formula = "SUBTOTAL(103," & spr.ActiveSheet.GetColumnAutoText(i) & "2:" & spr.ActiveSheet.GetColumnAutoText(i) & spr.ActiveSheet.RowCount & ")"

                            SPR_NUMBERCELLFOOTER(spr, DATAreader("K9911_DataDecimal"), CIntp(DATAreader("K9911_DataSize")), i)
                            spr.ActiveSheet.ColumnFooter.SetAggregationType(0, i, Model.AggregationType.CountAIgnoreHidden)
                        Case 1
                            Call SPR_NUMBERCELL(spr, DATAreader("K9911_DataDecimal"), CIntp(DATAreader("K9911_DataSize")), i)

                            If D9914.Footer = "1" Then
                                Dim Formula1 As String
                                Formula1 = "SUBTOTAL(109," & spr.ActiveSheet.GetColumnAutoText(i) & "1:" & spr.ActiveSheet.GetColumnAutoText(i) & spr.ActiveSheet.RowCount & ")"
                                SPR_NUMBERCELLFOOTER(spr, DATAreader("K9911_DataDecimal"), CIntp(DATAreader("K9911_DataSize")), i)
                                spr.ActiveSheet.ColumnFooter.SetAggregationType(0, i, Model.AggregationType.SumIgnoreHidden)
                                Exit Select
                            End If

                            If header = False Then
                                Exit Select
                            End If


                            Dim FixAmount As Decimal = 0
                            Dim ConAmount As Decimal = 0
                            Dim HeadAmount As Decimal = 0
                            Dim HeadCount As Integer = 0

                            'If DATAreader("K9911_CheckHead") <> "1" Then Exit Select

                            If DATAreader("K9911_CheckHead") <> "1" Then
                                Exit Select

                            End If

                            If DATAreader("K9911_CheckHeadType") = "0" Then
                                For j = 1 To RowCount - 1
                                    ConAmount = CDecp(getData(spr, i, j))
                                    HeadAmount += ConAmount
                                Next
                                setData(spr, i, 0, HeadAmount)

                                If D9914.Footer = "1" Then
                                    Dim Formula As String
                                    Formula = "SUBTOTAL(109," & spr.ActiveSheet.GetColumnAutoText(i) & "2:" & spr.ActiveSheet.GetColumnAutoText(i) & spr.ActiveSheet.RowCount & ")"
                                    spr.ActiveSheet.Cells(0, i).Formula = Formula

                                    SPR_NUMBERCELLFOOTER(spr, DATAreader("K9911_DataDecimal"), CIntp(DATAreader("K9911_DataSize")), i)
                                    spr.ActiveSheet.ColumnFooter.SetAggregationType(0, i, Model.AggregationType.SumIgnoreHidden)
                                    spr.ActiveSheet.ColumnFooter.Cells(0, i).Formula = Formula
                                End If

                            ElseIf DATAreader("K9911_CheckHeadType") = "1" And DATAreader("K9911_REMK").ToString.Trim <> "" Then
                                DataConvert = Split(DATAreader("K9911_REMK").ToString.Trim, ";")

                                For j = 1 To RowCount - 1
                                    ConAmount += CDecp(getData(spr, DataConvert(0), j))
                                    HeadCount += CDecp(getData(spr, DataConvert(1), j))
                                Next
                                If HeadCount > 0 Then setData(spr, i, 0, ConAmount / HeadCount * 100)

                            ElseIf DATAreader("K9911_CheckHeadType") = "1" Then
                                Dim Formula As String
                                Formula = "SUBTOTAL(101," & spr.ActiveSheet.GetColumnAutoText(i) & "2:" & spr.ActiveSheet.GetColumnAutoText(i) & spr.ActiveSheet.RowCount & ")"
                                spr.ActiveSheet.Cells(0, i).Formula = Formula

                                SPR_NUMBERCELLFOOTER(spr, DATAreader("K9911_DataDecimal"), CIntp(DATAreader("K9911_DataSize")), i)
                                spr.ActiveSheet.ColumnFooter.SetAggregationType(0, i, Model.AggregationType.AvgIgnoreHidden)

                            Else
                                Dim Formula As String
                                Formula = "SUBTOTAL(103," & spr.ActiveSheet.GetColumnAutoText(i) & "2:" & spr.ActiveSheet.GetColumnAutoText(i) & spr.ActiveSheet.RowCount & ")"
                                spr.ActiveSheet.Cells(0, i).Formula = Formula

                                SPR_NUMBERCELLFOOTER(spr, DATAreader("K9911_DataDecimal"), CIntp(DATAreader("K9911_DataSize")), i)
                                spr.ActiveSheet.ColumnFooter.SetAggregationType(0, i, Model.AggregationType.CountAIgnoreHidden)
                            End If

                        Case 2
                            If ColumnName = "PrescriptionWeavingCheck" Or ColumnName = "PrescriptionProductionCheck" Then
                                For j = 0 To RowCount - 1
                                    If GetDsData(datatr, j, "CheckPrescription") = True Then
                                        SPR_BUTTON_S(spr, i, j, getData(spr, i, j))
                                    End If
                                Next
                            Else
                                SPR_BUTTON(spr, i)
                            End If

                        Case 3
                            Call SPR_COMBOBOX(spr, i, Split(DATAreader("K9911_REMK").ToString.Trim, ";"))

                            For j = 0 To RowCount - 1
                                setDataCB(spr, i, j, getData(spr, i, j))
                            Next

                        Case 4
                            Call SPR_CHECKBOX(spr, i)

                            Dim ValueChk As String
                            For j = 0 To RowCount - 1
                                ValueChk = CIntp(getData(spr, i, j))
                                setDataChk(spr, i, j, ValueChk)
                            Next

                        Case 5
                            Call SPR_DATEVALUE(spr, i)

                        Case 8
                            Call SPR_IMAGE(spr, i)
                    End Select

                    spr.ActiveSheet.ColumnHeader.Columns(i).Width = DATAreader("K9911_SizeWidth")

                    If CDbl(DATAreader("K9911_SizeWidth")) = 111 Then
                        spr.ActiveSheet.ColumnHeader.Columns(i).Width = spr.ActiveSheet.ColumnHeader.Columns(i).GetPreferredWidth
                    End If
                    If CheckMas = True Then spr.ActiveSheet.ColumnHeader.Columns(i).Width = D9912.SizeWidth

                    str1 = Split(DATAreader("K9911_ForeColor"), "-")
                    spr.ActiveSheet.Columns(i).ForeColor = System.Drawing.Color.FromArgb(CInt(str1(0)), CInt(str1(1)), CInt(str1(2)))

                    If DATAreader("K9911_FontBold") = 0 Then
                        spr.ActiveSheet.Columns(i).Font = New Font(DATAreader("K9911_FontName").ToString, CSng(DATAreader("K9911_FontSize")), Drawing.FontStyle.Regular)
                    Else
                        spr.ActiveSheet.Columns(i).Font = New Font(DATAreader("K9911_FontName").ToString, CSng(DATAreader("K9911_FontSize")), Drawing.FontStyle.Bold)

                    End If
                    spr.ActiveSheet.Columns(i).VerticalAlignment = DATAreader("K9911_VerticalAlignment")
                    spr.ActiveSheet.Columns(i).HorizontalAlignment = DATAreader("K9911_HorizontalAlignment")

                    If DATAreader("K9911_Lock") = "1" Then
                        spr.ActiveSheet.Columns(i).Locked = True
                    Else
                        spr.ActiveSheet.Columns(i).Locked = False

                    End If

                    If D9914.AreaColorCheck = "1" Then
                        str = Split(D9914.AreaColor, "-")
                        SPR_BackColumn(spr, System.Drawing.Color.FromArgb(CInt(str(0)), CInt(str(1)), CInt(str(2))), i)
                    Else
                        SPR_BackColumn(spr, Color.White, i)
                    End If

                    If DATAreader("K9911_BackColot") <> "255-255-255" Then
                        str = Split(DATAreader("K9911_BackColot"), "-")
                        spr.ActiveSheet.Columns(i).BackColor = System.Drawing.Color.FromArgb(CInt(str(0)), CInt(str(1)), CInt(str(2)))
                    End If
                    DATAreader.Close()

                Else
                    DATAreader.Close()

                    If READ_PFK9911(ColumnName) = True Then
                        M9911 = D9911
                        REWRITE_PFK9911(M9911)
                        M9912.ItemCode = M9911.ItemCode
                        M9912.Lock = "1"
                        M9912.Hidden = "1"
                        If Strings.Left(M9911.ItemName, 4).ToUpper = "KEY_" Then M9912.Hidden = "0"
                        M9912.ProdjectName = "DMS"
                        M9912.ProgramNo = program
                        M9912.SheetName = sheetname
                        M9912.ProgramSeq = key_count_k9912(M9912.ProdjectName, M9912.ProgramNo, M9912.SheetName)
                        WRITE_PFK9912(M9912)
                    Else

                        M9911 = D9911
                        M9911.ItemName = ColumnName
                        M9911.ItemCode = key_count()
                        M9911.ItemNameSimply = ColumnName
                        M9911.ItemNameForeign1 = ColumnName
                        M9911.ItemNameForeign2 = ColumnName
                        M9911.ProdjectName = "DMS"
                        M9911.DataType = 0
                        M9911.DataSize = 100
                        M9911.DataDecimal = 2
                        M9911.TextAlign = 2
                        M9911.HorizontalAlignment = 2
                        M9911.VerticalAlignment = 2
                        M9911.SizeWidth = 100
                        M9911.SizeHeight = 30
                        M9911.BackColot = "255-255-255"
                        M9911.ForeColor = "0-0-0"
                        M9911.FontName = "Tahoma"
                        M9911.FontSize = "9.00"
                        M9911.FontBold = "0"
                        M9911.Lock = "1"
                        M9911.Hidden = "1"
                        If Strings.Left(M9911.ItemName, 4).ToUpper = "KEY_" Then M9911.Hidden = "0"

                        If M9911.ItemName.Contains("Amount") Or M9911.ItemName.Contains("amount") _
                          Or M9911.ItemName.Contains("Price") _
                         Or M9911.ItemName.Contains("price") _
                          Or M9911.ItemName.Contains("quantity") _
                          Or M9911.ItemName.Contains("Balance") _
                          Or M9911.ItemName.Contains("balance") _
                          Or M9911.ItemName.Contains("Qty") _
                          Or M9911.ItemName.Contains("qty") _
                           Or M9911.ItemName.Contains("Quantity") Then
                            M9911.DataType = 1
                            M9911.HorizontalAlignment = 3
                        End If

                        M9911.REMK = ""
                        WRITE_PFK9911(M9911)
                        M9912.ItemCode = M9911.ItemCode
                        M9912.Lock = "1"
                        M9912.Hidden = "1"

                        If Strings.Left(M9911.ItemName, 4).ToUpper = "KEY_" Then M9912.Hidden = "0"
                        M9912.ProdjectName = "DMS"
                        M9912.ProgramNo = program
                        M9912.SheetName = sheetname
                        M9912.ProgramSeq = key_count_k9912(M9912.ProdjectName, M9912.ProgramNo, M9912.SheetName)

                        WRITE_PFK9912(M9912)
                    End If
                    GoTo BEGIN
                End If
            Next

            Dim ArrInteger(0) As Integer
            Dim ArrIntegerR(0) As Integer

            Dim ArrList() As String
            Dim ArrListR() As String

            Dim ListChk As Boolean = False
            Dim ListChkR As Boolean = False

            If D9914.MergeColumn <> "" Then
                ArrList = Split(D9914.MergeColumn, ",")
                If ArrList.Length > 0 Then
                    ReDim ArrInteger(ArrList.Length - 1)

                    For i = 0 To UBound(ArrList)
                        ArrInteger(i) = CIntp(ArrList(i))
                    Next

                    ListChk = True
                End If
            End If

            If D9914.MergeRetrict <> "" Then
                ArrListR = Split(D9914.MergeRetrict, ",")
                If ArrListR.Length > 0 Then
                    ReDim ArrIntegerR(ArrListR.Length - 1)

                    For i = 0 To UBound(ArrListR)
                        ArrIntegerR(i) = CIntp(ArrListR(i))
                    Next

                    ListChkR = True
                End If
            End If

            If CboolP(D9914.Separate) = True And CboolP(D9914.TotalSeparate) = False Then
                Call SPR_SEPARATE(spr, D9914.ColumnBase, D9914.ColumnCal)

            ElseIf CboolP(D9914.Separate) = False And CboolP(D9914.TotalSeparate) = True Then
                Call SPR_TOTAL(spr, D9914.ColumnBase, D9914.ColumnCal)

            End If
            If CboolP(D9914.Merge) = True Then
                If ListChk = True Then Call SPR_MERGEALWAYS(spr, ArrInteger)
                If ListChkR = True Then Call SPR_MERGERESTRICT(spr, ArrIntegerR)
            End If

            If D9914.HeaderColumn = "2" Then
                spr.ActiveSheet.ColumnHeaderVisible = False
            Else
                spr.ActiveSheet.ColumnHeaderVisible = True
            End If

            If D9914.HeaderRow = "2" Then
                spr.ActiveSheet.RowHeaderVisible = False
            Else
                spr.ActiveSheet.RowHeaderVisible = True
            End If

            'ADD

            If D9914.ColumnSpanID = 0 Then GoTo next1

            DS2 = PrcDS("USP_SPREAD_PROGRAM_SEARCH_PFK9915", cn, "DMS", program, sheetname, D9914.ColumnSpanID)

            If GetDsRc(DS2) = 0 Then GoTo next1

            spr.ActiveSheet.ColumnHeader.RowCount = 2

            For i = 0 To GetDsRc(DS2) - 1
                For j = CIntp(GetDsData(DS2, i, "BeginColumn")) To CIntp(GetDsData(DS2, i, "EndColumn"))
                    spr.ActiveSheet.ColumnHeader.Cells(1, j).Value = spr.ActiveSheet.ColumnHeader.Cells(0, j).Value
                Next
                spr.ActiveSheet.AddColumnHeaderSpanCell(0, CIntp(GetDsData(DS2, i, "BeginColumn")), 1, CIntp(GetDsData(DS2, i, "EndColumn")) - CIntp(GetDsData(DS2, i, "BeginColumn")) + 1)
                spr.ActiveSheet.ColumnHeader.Cells(0, CIntp(GetDsData(DS2, i, "BeginColumn"))).Value = GetDsData(DS2, i, "Title")

                If MdiMenu.M20001.Checked = True Then spr.ActiveSheet.ColumnHeader.Cells(0, CIntp(GetDsData(DS2, i, "BeginColumn"))).Value = GetDsData(DS2, i, "Title")
                If MdiMenu.M20002.Checked = True Then spr.ActiveSheet.ColumnHeader.Cells(0, CIntp(GetDsData(DS2, i, "BeginColumn"))).Value = GetDsData(DS2, i, "ForeignName1")

            Next

            For i = 0 To spr.ActiveSheet.ColumnCount - 1
                If spr.ActiveSheet.ColumnHeader.Cells(0, i).ColumnSpan = 1 Then
                    spr.ActiveSheet.ColumnHeader.Cells(0, i).RowSpan = 2
                End If

            Next

            If READ_PFK9914("DMS", program, sheetname) Then
                If D9914.ColHeader1 < 10 Then
                    spr.ActiveSheet.ColumnHeader.Rows(0).Height = cSprRowHeight
                Else
                    spr.ActiveSheet.ColumnHeader.Rows(0).Height = D9914.ColHeader1
                End If
                If D9914.ColHeader2 < 10 Then
                    spr.ActiveSheet.ColumnHeader.Rows(1).Height = cSprRowHeight
                Else
                    spr.ActiveSheet.ColumnHeader.Rows(1).Height = D9914.ColHeader2
                End If

            End If

next1:

            If D9914.FixSize = "1" Then
                Dim intWith As Integer

                If D9914.HeaderRow = "2" Then
                    intWith = SPR_SHEETWIDHT(spr) + cSprWidthSize
                Else
                    intWith = SPR_SHEETWIDHT(spr) + cSprWidthSize
                End If

                Dim objParent As Object
                objParent = spr.Parent.Parent
                If TypeOf (objParent) Is SplitContainer Then
                    objParent.SplitterDistance = intWith
                End If
            End If

            spr.ResumeLayout(True)
            spr.SearchChk = True

            If D9914.Header = "1" Then
                spr.ActiveSheet.ActiveRowIndex = 1
                spr.Select()
            Else
                spr.ActiveSheet.ActiveRowIndex = 0
                spr.Select()
            End If

            MdiMenu.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBoxP(program & sheetname, vbCritical)
            If spr IsNot Nothing Then spr.ResumeLayout(True)
            If D9914.Header = "1" Then
                spr.ActiveSheet.ActiveRowIndex = 1
                spr.Select()
            Else
                spr.ActiveSheet.ActiveRowIndex = 0
                spr.Select()
            End If
            If DATAreader IsNot Nothing Then
                If DATAreader.IsClosed = False Then
                    DATAreader.Close()
                End If
            End If
        Finally
            MdiMenu.Cursor = Cursors.Default



        End Try
    End Sub


    Public Function DATA_SEARCH_IMAGE_TOTAL(ByRef Ptc As PictureBox, Table As String, Parameter As String) As Boolean
        Dim ds As New DataSet
        DATA_SEARCH_IMAGE_TOTAL = False
        Try
            SQL = "SELECT TOP 1	K7555_ImageData FROM PFK7555 WHERE K7555_TABLE   = 'PFK1312' "
            SQL = SQL & " AND		K7555_PAREMETER   = '" + Parameter + "'"
            SQL = SQL & " AND K7555_FileType in ('bmp', 'jpg', 'jpeg', 'gif', 'png') "
            SQL = SQL & " ORDER	BY		K7555_SEQ DESC	"

            Dim sqlCmd As New SqlClient.SqlCommand(SQL, cn)

            'Get image data from DB
            Dim imageData As Byte() = DirectCast(sqlCmd.ExecuteScalar(), Byte())

            'Initialize image variable 
            Dim newImage As Image = Nothing

            If Not imageData Is Nothing Then
                'Read image data into a memory stream 
                Using ms As New System.IO.MemoryStream(imageData, 0, imageData.Length)
                    ms.Write(imageData, 0, imageData.Length)
                    'Set image variable value using memory stream. 
                    newImage = Image.FromStream(ms, True)
                End Using

                'Display the picture  in Picture Box

                Ptc.Image = newImage
                Ptc.SizeMode = PictureBoxSizeMode.StretchImage

                DATA_SEARCH_IMAGE_TOTAL = True
            End If

        Catch ex As Exception

        End Try


    End Function

    Public Sub SPR_PRO_NEW_PFP(ByRef spr As FarPoint.Win.Spread.FpSpread, datatr As DataSet, program As String, sheetname As String, Optional ByVal Chk As Boolean = False)

        ' apiBlockInput(1)       
        ' Dim DataConvert() As String
        'Dim str(), str1() As String
        ' Dim newfont As Font

        If datatr Is Nothing Then Exit Sub
        Dim header As Boolean = False
        Dim i, j As Integer
        Dim DATAreader As SqlClient.SqlDataReader
        Dim ColumnName As String = ""
        spr.SuspendLayout()
        DATAreader = Nothing
        spr.Tag = program & ";" & sheetname

        MdiMenu.Cursor = Cursors.WaitCursor

        'If READ_PFK9916_1(spr.FindForm.Name, spr.Name) = False Then
        '    Call SPR_PRO_LOAD(spr, "DMS", D9916.REMK, spr.Name)
        'End If

        If READ_PFK9916_1(spr.FindForm.Name, sheetname) = True Then
            If D9916.CheckDev <> "1" Then
                D9916.CheckDev = "1"
                D9916.REMK = program
                If REWRITE_PFK9916(D9916) Then
                    Call SPR_PRO_LOAD(spr, "DMS", program, sheetname)
                End If
            End If
        End If

        Try
            If READ_PFK9914("DMS", program, sheetname) = True Then
                SPR_SET(spr, D9914.ColsFrozen,
                            D9914.RowsFrozen,
                            D9914.MaxRows,
                            D9914.OperationMode,
                            CboolP(D9914.Lock),
                            CboolP(D9914.DefaultRowHeight),
                            CboolP(D9914.HeaderTextMode),
                            CboolP(D9914.RetainSelectionBlock),
                            D9914.Fontsize,
                            D9914.Rowheight,
                            D9914.AutoClip,
                            False)
                header = CboolP(D9914.Header)
            End If

            Dim RowCount As Integer
            Dim ColumnCount As Integer
            Dim xColumnName As String
            Dim xColumnIndex As Integer

            RowCount = GetDsRc(datatr)
            ColumnCount = GetDsCc(datatr)


            DATAreader = PrcDRSheet("USP_SPREAD_PROGRAM_SEARCH_ITEMNAME_SANO", cn, Pub.SAW, program, sheetname, ColumnName)

            If DATAreader.HasRows = False Then DATAreader.Close() : DATAreader = PrcDRSheet("USP_SPREAD_PROGRAM_SEARCH_ITEMNAME", cn, program, sheetname, ColumnName)

            If DATAreader.HasRows Then
                DATAreader.Read()
                Select Case DATAreader("K9911_DataType")
                    Case 4
                        Call SPR_CHECKBOX(spr, i)
                        Dim ValueChk As String
                        For j = 0 To RowCount - 1
                            ValueChk = CIntp(getData(spr, i, j))
                            setDataChk(spr, i, j, ValueChk)
                        Next
                    Case 5
                        Call SPR_DATEVALUE(spr, i)
                    Case 8
                        Call SPR_IMAGE(spr, i)
                End Select
            End If

            If getColumIndex(spr, "ImageData") > 0 Then SPR_IMAGE(spr, getColumIndex(spr, "ImageData"))

            If RowCount > 1000 Then
                PRG_SET(ProgressBar1, RowCount)
                spr.ActiveSheet.RowCount = RowCount

                For i = 0 To RowCount - 1
                    PRG_VALUE(ProgressBar1, i + 1)
                    For j = 0 To ColumnCount - 1
                        If j <> getColumIndex(spr, "ImageData") Then

                            xColumnName = getColumName(datatr, j)
                            xColumnIndex = getColumIndex(spr, xColumnName)
                            Call SPR_TEXTBOX(spr, xColumnIndex, 500)
                            If xColumnIndex >= 0 Then
                                If (TypeOf spr.ActiveSheet.Columns(xColumnIndex).CellType Is CellType.CheckBoxCellType) Then
                                    setDataPFP(spr, xColumnIndex, i, datatr.Tables(0).Rows(i).Item(j), , True)

                                    'NAM 20170424
                                ElseIf spr.ActiveSheet.Columns(xColumnIndex).Tag.ToString.ToUpper = "DCHK" Then
                                    SPR_CHECKBOX(spr, xColumnIndex)
                                    Dim xxx = spr.ActiveSheet.Columns(xColumnIndex).Tag.ToString.ToUpper
                                    Dim ValueChk As String
                                    ValueChk = CIntp(datatr.Tables(0).Rows(i).Item(j))
                                    setDataCk(spr, xColumnIndex, i, ValueChk)

                                Else
                                    setDataPFP(spr, xColumnIndex, i, datatr.Tables(0).Rows(i).Item(j))
                                End If

                            End If

                        ElseIf j = getColumIndex(spr, "ImageData") Then
                            'setDataPFP(spr, j, i, datatr.Tables(0).Rows(i).Item(j))
                            spr.ActiveSheet.Cells(i, j).Value = datatr.Tables(0).Rows(i).Item(j)
                        End If

                    Next
                Next

            Else
                spr.ActiveSheet.RowCount = RowCount

                For i = 0 To RowCount - 1
                    For j = 0 To ColumnCount - 1

                        If j <> getColumIndex(spr, "ImageData") Then

                            xColumnName = getColumName(datatr, j)

                            'xColumnIndex = getColumIndex(datatr, xColumnName)

                            xColumnIndex = j 'getColumIndex(spr, xColumnName)

                            If xColumnIndex >= 0 Then
                                If (TypeOf spr.ActiveSheet.Columns(xColumnIndex).CellType Is CellType.CheckBoxCellType) Then
                                    setDataPFP(spr, xColumnIndex, i, datatr.Tables(0).Rows(i).Item(j), , True)
                                    'NAM 20170424
                                ElseIf spr.ActiveSheet.Columns(xColumnIndex).Tag.ToString.ToUpper = "DCHK" Then
                                    SPR_CHECKBOX(spr, xColumnIndex)
                                    Dim xxx = spr.ActiveSheet.Columns(xColumnIndex).Tag.ToString.ToUpper
                                    Dim ValueChk As String
                                    ValueChk = CIntp(datatr.Tables(0).Rows(i).Item(j))
                                    setDataCk(spr, xColumnIndex, i, ValueChk)
                                Else
                                    setDataPFP(spr, xColumnIndex, i, datatr.Tables(0).Rows(i).Item(j))
                                End If

                            End If

                        ElseIf j = getColumIndex(spr, "ImageData") Then
                            'setData(spr, j, i, datatr.Tables(0).Rows(i).Item(j))
                            spr.ActiveSheet.Cells(i, j).Value = datatr.Tables(0).Rows(i).Item(j)
                        End If

                    Next j
                Next i

            End If

            If CDecp(D9914.ZoomSize) < 1 Or CDecp(D9914.ZoomSize) > 5 Then spr.ActiveSheet.ZoomFactor = 1 Else spr.ActiveSheet.ZoomFactor = CDecp(D9914.ZoomSize)

            If D9914.Footer = "1" Then
                spr.ActiveSheet.ColumnFooter.Visible = True
                spr.ActiveSheet.ColumnFooter.RowCount = 1
                spr.ActiveSheet.ColumnFooter.Rows(0).BackColor = SystemColors.Info
                spr.ActiveSheet.ColumnFooter.Rows(0).ForeColor = Color.Black
            ElseIf header = True Then
                spr.ActiveSheet.ColumnFooter.Visible = False
                spr.ActiveSheet.ColumnFooter.RowCount = 1
                spr.ActiveSheet.ColumnFooter.Rows(0).BackColor = SystemColors.Info
                spr.ActiveSheet.ColumnFooter.Rows(0).ForeColor = Color.Black

                spr.ActiveSheet.Rows.Add(0, 1)
                SPR_BACKCOLORROWTOTAL(spr, cRelation3HeaderColor, 0)
                spr.ActiveSheet.FrozenRowCount = 1
                RowCount += 1
            End If

            DS1 = PrcDS("USP_SPREAD_PROGRAM_SEARCH_ITEMNAME_NUMBER", cn, program, sheetname)

            If GetDsRc(DS1) > 0 Then

                For i = 0 To GetDsRc(DS1) - 1
                    Dim FixAmount As Decimal = 0
                    Dim ConAmount As Decimal = 0
                    Dim HeadAmount As Decimal = 0
                    Dim HeadCount As Integer = 0
                    Dim ColumnIndex As Integer

                    ColumnIndex = getColumIndex(spr, GetDsData(DS1, i, 1))

                    For j = 1 To RowCount - 1
                        ConAmount = CDecp(getData(spr, ColumnIndex, j))
                        HeadAmount += ConAmount
                    Next
                    If ColumnIndex >= 0 Then
                        setData(spr, ColumnIndex, 0, HeadAmount)
                    End If
                Next

            End If

            Dim ArrInteger(0) As Integer
            Dim ArrIntegerR(0) As Integer

            Dim ArrList() As String
            Dim ArrListR() As String

            Dim ListChk As Boolean = False
            Dim ListChkR As Boolean = False

            If D9914.MergeColumn <> "" Then
                ArrList = Split(D9914.MergeColumn, ",")
                If ArrList.Length > 0 Then
                    ReDim ArrInteger(ArrList.Length - 1)

                    For i = 0 To UBound(ArrList)
                        ArrInteger(i) = CIntp(ArrList(i))
                    Next

                    ListChk = True
                End If
            End If

            If D9914.MergeRetrict <> "" Then
                ArrListR = Split(D9914.MergeRetrict, ",")
                If ArrListR.Length > 0 Then
                    ReDim ArrIntegerR(ArrListR.Length - 1)

                    For i = 0 To UBound(ArrListR)
                        ArrIntegerR(i) = CIntp(ArrListR(i))
                    Next

                    ListChkR = True
                End If
            End If

            If CboolP(D9914.Separate) = True And CboolP(D9914.TotalSeparate) = False Then
                Call SPR_SEPARATE(spr, D9914.ColumnBase, D9914.ColumnCal)

            ElseIf CboolP(D9914.Separate) = False And CboolP(D9914.TotalSeparate) = True Then
                Call SPR_TOTAL(spr, D9914.ColumnBase, D9914.ColumnCal)

            End If

            If CboolP(D9914.Merge) = True Then
                If ListChk = True Then Call SPR_MERGEALWAYS(spr, ArrInteger)
                If ListChkR = True Then Call SPR_MERGERESTRICT(spr, ArrIntegerR)
            End If

            If D9914.HeaderColumn = "2" Then
                spr.ActiveSheet.ColumnHeaderVisible = False
            Else
                spr.ActiveSheet.ColumnHeaderVisible = True
            End If

            If D9914.HeaderRow = "2" Then
                spr.ActiveSheet.RowHeaderVisible = False
            Else
                spr.ActiveSheet.RowHeaderVisible = True
            End If

            If D9914.ColumnSpanID = 0 Then GoTo next1

            If READ_PFK9914("DMS", program, sheetname) Then
                If D9914.ColHeader1 < 10 Then
                    spr.ActiveSheet.ColumnHeader.Rows(0).Height = cSprRowHeight
                Else
                    spr.ActiveSheet.ColumnHeader.Rows(0).Height = D9914.ColHeader1
                End If
                If D9914.ColHeader2 < 10 Then
                    spr.ActiveSheet.ColumnHeader.Rows(1).Height = cSprRowHeight
                Else
                    spr.ActiveSheet.ColumnHeader.Rows(1).Height = D9914.ColHeader2
                End If

            End If

next1:
            If D9914.FixSize = "1" Then
                Dim intWith As Integer

                If D9914.HeaderRow = "2" Then
                    intWith = SPR_SHEETWIDHT(spr) + cSprWidthSize
                Else
                    intWith = SPR_SHEETWIDHT(spr) + cSprWidthSize
                End If

                Dim objParent As Object
                objParent = spr.Parent.Parent
                If TypeOf (objParent) Is SplitContainer Then
                    objParent.SplitterDistance = intWith
                End If
            End If

            spr.ResumeLayout(True)

            If D9914.Header = "1" Then
                spr.ActiveSheet.ActiveRowIndex = 1
                spr.Select()
            Else
                spr.ActiveSheet.ActiveRowIndex = 0
                spr.Select()
            End If

            MdiMenu.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBoxP(program & sheetname, vbCritical)
            spr.ResumeLayout(True)
            If D9914.Header = "1" Then
                spr.ActiveSheet.ActiveRowIndex = 1
                spr.Select()
            Else
                spr.ActiveSheet.ActiveRowIndex = 0
                spr.Select()
            End If
            If DATAreader IsNot Nothing Then
                If DATAreader.IsClosed = False Then
                    DATAreader.Close()
                End If
            End If
        Finally
            MdiMenu.Cursor = Cursors.Default
            ' apiBlockInput(0)
            Call GetFullInformation(program & sheetname, "SPR_PRO_NEW_PFP")

        End Try
    End Sub


    Public Sub SPR_PRO_NEW_PFP_MULTICOLHEADER(ByRef spr As FarPoint.Win.Spread.FpSpread, datatr As DataSet, colheadercount As Integer, program As String, sheetname As String, Optional ByVal Chk As Boolean = False)

        If datatr Is Nothing Then Exit Sub
        Dim header As Boolean = False
        Dim i, j As Integer
        Dim DATAreader As SqlClient.SqlDataReader
        Dim ColumnName As String = ""
        spr.SuspendLayout()
        DATAreader = Nothing
        spr.Tag = program & ";" & sheetname

        MdiMenu.Cursor = Cursors.WaitCursor

        'If READ_PFK9916_1(spr.FindForm.Name, spr.Name) = False Then
        '    Call SPR_PRO_LOAD(spr, "DMS", D9916.REMK, spr.Name)
        'End If

        If READ_PFK9916_1(spr.FindForm.Name, sheetname) = True Then
            If D9916.CheckDev <> "1" Then
                D9916.CheckDev = "1"
                D9916.REMK = program
                If REWRITE_PFK9916(D9916) Then
                    Call SPR_PRO_LOAD(spr, "DMS", program, sheetname)
                End If
            End If
        End If

        Try
            If READ_PFK9914("DMS", program, sheetname) = True Then
                SPR_SET(spr, D9914.ColsFrozen,
                            D9914.RowsFrozen,
                            D9914.MaxRows,
                            D9914.OperationMode,
                            CboolP(D9914.Lock),
                            CboolP(D9914.DefaultRowHeight),
                            CboolP(D9914.HeaderTextMode),
                            CboolP(D9914.RetainSelectionBlock),
                            D9914.Fontsize,
                            D9914.Rowheight,
                            D9914.AutoClip,
                            False)
                header = CboolP(D9914.Header)
            End If

            Dim RowCount As Integer
            Dim ColumnCount As Integer
            Dim xColumnName As String
            Dim xColumnIndex As Integer

            RowCount = GetDsRc(datatr)
            ColumnCount = GetDsCc(datatr)

            DATAreader = PrcDRSheet("USP_SPREAD_PROGRAM_SEARCH_ITEMNAME_SANO", cn, Pub.SAW, program, sheetname, ColumnName)

            If DATAreader.HasRows = False Then DATAreader.Close() : DATAreader = PrcDRSheet("USP_SPREAD_PROGRAM_SEARCH_ITEMNAME", cn, program, sheetname, ColumnName)

            If DATAreader.HasRows Then
                DATAreader.Read()
                Select Case DATAreader("K9911_DataType")
                    Case 4
                        Call SPR_CHECKBOX(spr, i)
                        Dim ValueChk As String
                        For j = 0 To RowCount - 1
                            ValueChk = CIntp(getData(spr, i, j))
                            setDataChk(spr, i, j, ValueChk)
                        Next
                    Case 5
                        Call SPR_DATEVALUE(spr, i)
                End Select
            End If

            If RowCount > 1000 Then
                PRG_SET(ProgressBar1, RowCount)
                spr.ActiveSheet.RowCount = RowCount

                For i = 0 To RowCount - 1
                    PRG_VALUE(ProgressBar1, i + 1)
                    For j = 0 To ColumnCount - 1

                        xColumnName = getColumName(datatr, j)
                        xColumnIndex = getColumIndex(spr, xColumnName)
                        Call SPR_TEXTBOX(spr, xColumnIndex, 500)
                        If xColumnIndex >= 0 Then
                            If (TypeOf spr.ActiveSheet.Columns(xColumnIndex).CellType Is CellType.CheckBoxCellType) Then
                                setDataPFP(spr, xColumnIndex, i, datatr.Tables(0).Rows(i).Item(j), , True)

                            ElseIf spr.ActiveSheet.Columns(xColumnIndex).Tag.ToString.ToUpper = "DCHK" Then
                                SPR_CHECKBOX(spr, xColumnIndex)
                                setDataCk(spr, xColumnIndex, i, CIntp(datatr.Tables(0).Rows(i).Item(j)))

                            Else
                                setDataPFP(spr, xColumnIndex, i, datatr.Tables(0).Rows(i).Item(j))

                            End If

                        End If

                    Next
                Next

            Else
                spr.ActiveSheet.RowCount = RowCount

                For i = 0 To RowCount - 1
                    For j = 0 To ColumnCount - 1

                        xColumnName = getColumName(datatr, j)

                        xColumnIndex = j

                        If xColumnIndex >= 0 Then
                            If (TypeOf spr.ActiveSheet.Columns(xColumnIndex).CellType Is CellType.CheckBoxCellType) Then
                                setDataCk(spr, xColumnIndex, i, datatr.Tables(0).Rows(i).Item(j))

                            ElseIf spr.ActiveSheet.Columns(xColumnIndex).Tag.ToString.ToUpper = "DCHK" Then
                                SPR_CHECKBOX(spr, xColumnIndex)
                                setDataCk(spr, xColumnIndex, i, CIntp(datatr.Tables(0).Rows(i).Item(j)))

                            Else
                                setDataPFP(spr, xColumnIndex, i, datatr.Tables(0).Rows(i).Item(j))

                            End If

                        End If

                    Next j
                Next i

            End If

            spr.ActiveSheet.ZoomFactor = ZoomSize
            spr.ActiveSheet.ColumnHeaderRowCount = colheadercount
            For chc As Integer = 0 To GetDsRc(datatr) - 1
                spr.ActiveSheet.ColumnHeader.Rows(chc).Height = cSprRowHeaderHeight_25
            Next

            If D9914.Footer = "1" Then
                spr.ActiveSheet.ColumnFooter.Visible = True
                spr.ActiveSheet.ColumnFooter.RowCount = 1
                spr.ActiveSheet.ColumnFooter.Rows(0).BackColor = SystemColors.Info
                spr.ActiveSheet.ColumnFooter.Rows(0).ForeColor = Color.Black
            ElseIf header = True Then
                spr.ActiveSheet.ColumnFooter.Visible = False
                spr.ActiveSheet.ColumnFooter.RowCount = 1
                spr.ActiveSheet.ColumnFooter.Rows(0).BackColor = SystemColors.Info
                spr.ActiveSheet.ColumnFooter.Rows(0).ForeColor = Color.Black

                spr.ActiveSheet.Rows.Add(0, 1)
                SPR_BACKCOLORROWTOTAL(spr, cRelation3HeaderColor, 0)
                spr.ActiveSheet.FrozenRowCount = 1
                RowCount += 1
            End If

            DS1 = PrcDS("USP_SPREAD_PROGRAM_SEARCH_ITEMNAME_NUMBER", cn, program, sheetname)

            If GetDsRc(DS1) > 0 Then

                For i = 0 To GetDsRc(DS1) - 1
                    Dim FixAmount As Decimal = 0
                    Dim ConAmount As Decimal = 0
                    Dim HeadAmount As Decimal = 0
                    Dim HeadCount As Integer = 0
                    Dim ColumnIndex As Integer

                    ColumnIndex = getColumIndex(spr, GetDsData(DS1, i, 1))

                    For j = 1 To RowCount - 1
                        ConAmount = CDecp(getData(spr, ColumnIndex, j))
                        HeadAmount += ConAmount
                    Next
                    If ColumnIndex >= 0 Then
                        setData(spr, ColumnIndex, 0, HeadAmount)
                    End If
                Next

            End If

            Dim ArrInteger(0) As Integer
            Dim ArrIntegerR(0) As Integer

            Dim ArrList() As String
            Dim ArrListR() As String

            Dim ListChk As Boolean = False
            Dim ListChkR As Boolean = False

            If D9914.MergeColumn <> "" Then
                ArrList = Split(D9914.MergeColumn, ",")
                If ArrList.Length > 0 Then
                    ReDim ArrInteger(ArrList.Length - 1)

                    For i = 0 To UBound(ArrList)
                        ArrInteger(i) = CIntp(ArrList(i))
                    Next

                    ListChk = True
                End If
            End If

            If D9914.MergeRetrict <> "" Then
                ArrListR = Split(D9914.MergeRetrict, ",")
                If ArrListR.Length > 0 Then
                    ReDim ArrIntegerR(ArrListR.Length - 1)

                    For i = 0 To UBound(ArrListR)
                        ArrIntegerR(i) = CIntp(ArrListR(i))
                    Next

                    ListChkR = True
                End If
            End If

            If CboolP(D9914.Separate) = True And CboolP(D9914.TotalSeparate) = False Then
                Call SPR_SEPARATE(spr, D9914.ColumnBase, D9914.ColumnCal)

            ElseIf CboolP(D9914.Separate) = False And CboolP(D9914.TotalSeparate) = True Then
                Call SPR_TOTAL(spr, D9914.ColumnBase, D9914.ColumnCal)

            End If

            If CboolP(D9914.Merge) = True Then
                If ListChk = True Then Call SPR_MERGEALWAYS(spr, ArrInteger)
                If ListChkR = True Then Call SPR_MERGERESTRICT(spr, ArrIntegerR)
            End If

            If D9914.HeaderColumn = "2" Then
                spr.ActiveSheet.ColumnHeaderVisible = False
            Else
                spr.ActiveSheet.ColumnHeaderVisible = True
            End If

            If D9914.HeaderRow = "2" Then
                spr.ActiveSheet.RowHeaderVisible = False
            Else
                spr.ActiveSheet.RowHeaderVisible = True
            End If

            If D9914.ColumnSpanID = 0 Then GoTo next1

            If READ_PFK9914("DMS", program, sheetname) Then
                If D9914.ColHeader1 < 10 Then
                    spr.ActiveSheet.ColumnHeader.Rows(0).Height = cSprRowHeight
                Else
                    spr.ActiveSheet.ColumnHeader.Rows(0).Height = D9914.ColHeader1
                End If
                If D9914.ColHeader2 < 10 Then
                    spr.ActiveSheet.ColumnHeader.Rows(1).Height = cSprRowHeight
                Else
                    spr.ActiveSheet.ColumnHeader.Rows(1).Height = D9914.ColHeader2
                End If

            End If

next1:

            spr.ResumeLayout(True)

            If D9914.Header = "1" Then
                spr.ActiveSheet.ActiveRowIndex = 1
                spr.Select()
            Else
                spr.ActiveSheet.ActiveRowIndex = 0
                spr.Select()
            End If

            MdiMenu.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBoxP(program & sheetname, vbCritical)
            spr.ResumeLayout(True)
            If D9914.Header = "1" Then
                spr.ActiveSheet.ActiveRowIndex = 1
                spr.Select()
            Else
                spr.ActiveSheet.ActiveRowIndex = 0
                spr.Select()
            End If
            If DATAreader IsNot Nothing Then
                If DATAreader.IsClosed = False Then
                    DATAreader.Close()
                End If
            End If
        Finally
            MdiMenu.Cursor = Cursors.Default
            ' apiBlockInput(0)
            Call GetFullInformation(program & sheetname, "SPR_PRO_NEW_PFP")

        End Try
    End Sub

    Public Sub SPR_PRO_LOAD(ByRef spr As FarPoint.Win.Spread.FpSpread, Project As String, program As String, sheetname As String, Optional ByVal Chk As Boolean = False)
        Dim DSN As New DataSet
        Dim i As Integer
        Dim j As Integer

        spr.About = "xxx"
        spr.Tag = program & ";" & sheetname

        Try

            If READ_PFK9912_CHECKDSEQ(Project, program, sheetname) Then
                SQL = ""
                SQL = SQL + "SELECT K9911_ItemCode,[K9911_ItemName]"
                SQL = SQL + "      ,[K9911_ItemNameSimply],[K9911_ItemNameForeign1],[K9911_ItemNameForeign2],[K9911_ProdjectName]"
                SQL = SQL + "      ,[K9911_FormType],[K9911_DataType],[K9911_DataSize]"
                SQL = SQL + "      ,[K9911_DataDecimal],[K9911_TextAlign]"
                SQL = SQL + "      ,[K9911_HorizontalAlignment] ,[K9911_VerticalAlignment]"
                SQL = SQL + "      ,[K9911_SizeWidth] ,[K9911_SizeHeight]"
                SQL = SQL + "      ,[K9911_BackColot] ,[K9911_ForeColor]"
                SQL = SQL + "      ,[K9911_FontName] ,[K9911_FontSize]"
                SQL = SQL + "      ,[K9911_FontBold],[K9911_REMK]"
                SQL = SQL + "      ,[K9911_CheckMerge] ,[K9911_CheckMergePolicy] ,[K9911_CheckHead] ,[K9911_CheckHeadType],[K9911_CheckDev],[K9911_CheckDevValue] "
                SQL = SQL + "       ,[K9912_Lock] AS [K9911_Lock] ,[K9912_Hidden] AS [K9911_Hidden]"
                SQL = SQL + "  FROM PFK9912 A"
                SQL = SQL + " INNER JOIN PFK9911 B "
                SQL = SQL + " ON A.K9912_ItemCode = B.K9911_ItemCode"
                SQL = SQL + " WHERE [K9912_ProgramNo] = '" + program + "'"
                SQL = SQL + " AND [K9912_SheetName]  = '" + sheetname + "'"
                SQL = SQL + " ORDER BY K9912_ProgramDSeq"
            Else
                SQL = ""
                SQL = SQL + "SELECT K9911_ItemCode,[K9911_ItemName]"
                SQL = SQL + "      ,[K9911_ItemNameSimply],[K9911_ItemNameForeign1],[K9911_ItemNameForeign2],[K9911_ProdjectName]"
                SQL = SQL + "      ,[K9911_FormType],[K9911_DataType],[K9911_DataSize]"
                SQL = SQL + "      ,[K9911_DataDecimal],[K9911_TextAlign]"
                SQL = SQL + "      ,[K9911_HorizontalAlignment] ,[K9911_VerticalAlignment]"
                SQL = SQL + "      ,[K9911_SizeWidth] ,[K9911_SizeHeight]"
                SQL = SQL + "      ,[K9911_BackColot] ,[K9911_ForeColor]"
                SQL = SQL + "      ,[K9911_FontName] ,[K9911_FontSize]"
                SQL = SQL + "      ,[K9911_FontBold],[K9911_REMK]"
                SQL = SQL + "      ,[K9911_CheckMerge] ,[K9911_CheckMergePolicy] ,[K9911_CheckHead] ,[K9911_CheckHeadType],[K9911_CheckDev],[K9911_CheckDevValue] "
                SQL = SQL + "       ,[K9912_Lock] AS [K9911_Lock] ,[K9912_Hidden] AS [K9911_Hidden]"
                SQL = SQL + "  FROM PFK9912 A"
                SQL = SQL + " INNER JOIN PFK9911 B "
                SQL = SQL + " ON A.K9912_ItemCode = B.K9911_ItemCode"
                SQL = SQL + " WHERE [K9912_ProgramNo] = '" + program + "'"
                SQL = SQL + " AND [K9912_SheetName]  = '" + sheetname + "'"
                SQL = SQL + " ORDER BY K9912_ProgramSeq"
            End If

            cmd = New SqlClient.SqlCommand(SQL, cn)
            da.SelectCommand = cmd
            da.Fill(DSN)

            spr.ActiveSheet.ColumnCount = 0
            spr.ActiveSheet.ColumnHeader.RowCount = 1

            spr.ActiveSheet.RowCount = 2
            SPR_BACKCOLORROWTOTAL(spr, cRelation3HeaderColor, 0)

            If GetDsRc(DSN) = 0 Then Exit Sub

            For Each RS01 As DataRow In DSN.Tables(0).Rows
                spr.ActiveSheet.ColumnCount = i + 1
                'spr.ActiveSheet.Cells(0, i).Value = "99999999"
                K9911_MOVE(RS01)

                SPR_PRO_PFP(spr, i, D9911)
                spr.ActiveSheet.Columns(i).Visible = True

                If D9911.Hidden = "1" Then
                    spr.ActiveSheet.Columns(i).Visible = True
                ElseIf D9911.Hidden = "0" Then
                    spr.ActiveSheet.Columns(i).Visible = False
                End If

                spr.ActiveSheet.Columns(i).Locked = D9911.Lock
                i += 1
            Next


            If READ_PFK9914(Project, program, sheetname) Then
                DS1 = PrcDS("USP_SPREAD_PROGRAM_SEARCH_PFK9915", cn, Project, program, sheetname, D9914.ColumnSpanID)
                spr.ActiveSheet.ColumnHeader.RowCount = 2

                For i = 0 To GetDsRc(DS1) - 1
                    For j = CIntp(GetDsData(DS1, i, "BeginColumn")) To CIntp(GetDsData(DS1, i, "EndColumn"))
                        spr.ActiveSheet.ColumnHeader.Cells(1, j).Value = spr.ActiveSheet.ColumnHeader.Cells(0, j).Value
                    Next
                    spr.ActiveSheet.AddColumnHeaderSpanCell(0, CIntp(GetDsData(DS1, i, "BeginColumn")), 1, CIntp(GetDsData(DS1, i, "EndColumn")) - CIntp(GetDsData(DS1, i, "BeginColumn")) + 1)
                    'spr.ActiveSheet.ColumnHeader.Cells(0, CIntp(GetDsData(DS1, i, "BeginColumn"))).Value = GetDsData(DS1, i, "Title")

                    If MdiMenu.M20001.Checked = True Then spr.ActiveSheet.ColumnHeader.Cells(0, CIntp(GetDsData(DS1, i, "BeginColumn"))).Value = GetDsData(DS1, i, "Title")
                    If MdiMenu.M20002.Checked = True Then spr.ActiveSheet.ColumnHeader.Cells(0, CIntp(GetDsData(DS2, i, "BeginColumn"))).Value = GetDsData(DS2, i, "ForeignName1")


                Next

                For i = 0 To spr.ActiveSheet.ColumnCount - 1
                    If spr.ActiveSheet.ColumnHeader.Cells(0, i).ColumnSpan = 1 Then
                        spr.ActiveSheet.ColumnHeader.Cells(0, i).RowSpan = 2
                    End If
                Next

                If D9914.ColHeader1 < 10 Then
                    spr.ActiveSheet.ColumnHeader.Rows(0).Height = cSprRowHeight
                Else
                    spr.ActiveSheet.ColumnHeader.Rows(0).Height = D9914.ColHeader1
                End If
                If D9914.ColHeader2 < 10 Then
                    spr.ActiveSheet.ColumnHeader.Rows(1).Height = cSprRowHeight
                Else
                    spr.ActiveSheet.ColumnHeader.Rows(1).Height = D9914.ColHeader2
                End If

            End If

            Dim ArrInteger(0) As Integer
            Dim ArrIntegerR(0) As Integer

            Dim ArrList() As String
            Dim ArrListR() As String

            Dim ListChk As Boolean = False
            Dim ListChkR As Boolean = False

            If D9914.MergeColumn <> "" Then
                ArrList = Split(D9914.MergeColumn, ",")
                If ArrList.Length > 0 Then
                    ReDim ArrInteger(ArrList.Length - 1)

                    For i = 0 To UBound(ArrList)
                        ArrInteger(i) = CIntp(ArrList(i))
                    Next

                    ListChk = True
                End If
            End If

            If D9914.MergeRetrict <> "" Then
                ArrListR = Split(D9914.MergeRetrict, ",")
                If ArrListR.Length > 0 Then
                    ReDim ArrIntegerR(ArrListR.Length - 1)

                    For i = 0 To UBound(ArrListR)
                        ArrIntegerR(i) = CIntp(ArrListR(i))
                    Next

                    ListChkR = True
                End If
            End If

            If CboolP(D9914.Merge) = True Then
                If ListChk = True Then Call SPR_MERGEALWAYS(spr, ArrInteger)
                If ListChkR = True Then Call SPR_MERGERESTRICT(spr, ArrIntegerR)
            End If

            spr.Font = New Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point)
            spr.ActiveSheet.DefaultStyle.Font = New Font("Tahoma", 9, GraphicsUnit.Point)
            spr.ActiveSheet.Columns(-1).Font = New Font("Tahoma", 9, FontStyle.Regular)
            spr.ActiveSheet.Columns(-1).BackColor = Color.White

        Catch ex As Exception

        End Try
    End Sub

    Public Sub SPR_PRO_PFP(ByRef spr As FarPoint.Win.Spread.FpSpread, _
   ByVal Xcol As Integer, _
   ByVal Value As T9911_AREA)
        Try
            Dim str(), str1() As String

            spr.ActiveSheet.ColumnHeader.Columns(Xcol).Label = Value.ItemNameSimply
            spr.ActiveSheet.ColumnHeader.Columns(Xcol).Tag = Value.ItemName.ToUpper

            If MdiMenu.M20001.Checked = True Then spr.ActiveSheet.ColumnHeader.Columns(Xcol).Label = Value.ItemNameSimply
            If MdiMenu.M20002.Checked = True Then spr.ActiveSheet.ColumnHeader.Columns(Xcol).Label = Value.ItemNameForeign1

            Select Case Value.DataType
                Case 0
                    SPR_TEXTBOX(spr, Xcol, Value.DataSize)
                Case 1
                    SPR_NUMBERCELL(spr, Value.DataDecimal, CInt(Value.DataSize), Xcol)
                Case 2
                    SPR_BUTTON(spr, Xcol)
                Case 3
                    SPR_COMBOBOX(spr, Xcol)
                Case 4
                    SPR_CHECKBOX(spr, Xcol)
                Case 5
                    'SPR_DATEFORMAT(spr, Xcol)
                Case 6
                    SPR_TEXTBOX(spr, Xcol, Value.DataSize)
                Case 7
                    SPR_PROGRESS(spr, Xcol)
            End Select
            spr.ActiveSheet.ColumnHeader.Columns(Xcol).Width = Value.SizeWidth

            str = Split(Value.BackColot, "-")
            spr.ActiveSheet.Columns(Xcol).BackColor = System.Drawing.Color.FromArgb(CInt(str(0)), CInt(str(1)), CInt(str(2)))

            str1 = Split(Value.ForeColor, "-")
            spr.ActiveSheet.Columns(Xcol).ForeColor = System.Drawing.Color.FromArgb(CInt(str1(0)), CInt(str1(1)), CInt(str1(2)))

            spr.ActiveSheet.Columns(Xcol).VerticalAlignment = Value.VerticalAlignment
            spr.ActiveSheet.Columns(Xcol).HorizontalAlignment = Value.HorizontalAlignment

        Catch ex As Exception
            MsgBoxP("Can not load the Sprfead")
        End Try
    End Sub

    Public Sub SPR_KEY(ByRef spr As FarPoint.Win.Spread.FpSpread, ByRef KeyCode As Keys, ByVal Action As Object)

        Dim ancestorOfFocusedMap As FarPoint.Win.Spread.InputMap
        Try

            ancestorOfFocusedMap = spr.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused)

            ancestorOfFocusedMap.Put(New FarPoint.Win.Spread.Keystroke(KeyCode, Keys.None), Action)

            Dim focusedMap As FarPoint.Win.Spread.InputMap

            focusedMap = spr.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused)

            focusedMap.Put(New FarPoint.Win.Spread.Keystroke(KeyCode, Keys.None), Action)

        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_KEY_ANCESTOR(ByVal spr As FarPoint.Win.Spread.FpSpread, ByVal KeyCode As Keys, ByVal Action As Object)

        Try

            Dim ancestorOfFocusedMap As FarPoint.Win.Spread.InputMap

            ancestorOfFocusedMap = spr.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused)

            ancestorOfFocusedMap.Put(New FarPoint.Win.Spread.Keystroke(KeyCode, Keys.None), Action)

            Dim focusedMap As FarPoint.Win.Spread.InputMap

            focusedMap = spr.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused)

            focusedMap.Put(New FarPoint.Win.Spread.Keystroke(KeyCode, Keys.None), Action)

        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_SET(ByRef spr As FarPoint.Win.Spread.FpSpread, _
       Optional ByVal ColsFrozen As Integer = 0, _
       Optional ByVal RowsFrozen As Integer = 0, _
       Optional ByVal MaxRows As Integer = 1, _
       Optional ByVal OperationMode As OperationMode = FarPoint.Win.Spread.OperationMode.Normal, _
       Optional ByVal Lock As Boolean = False, _
       Optional ByVal DefaultRowHeight As Boolean = True, _
       Optional ByVal HeaderTextMode As Boolean = False, _
       Optional ByVal RetainSelectionBlock As Boolean = True, _
       Optional ByVal Fontsize As Integer = 9, _
       Optional ByVal Rowheight As Integer = 20, _
       Optional ByVal AutoClip As Boolean = True, _
       Optional ByVal Sort As Boolean = False)

        Try

            If MaxRows = 0 Then
                spr.ActiveSheet.Rows.Count = 1
            End If

            spr.Font = New Font("Tahoma", Fontsize, FontStyle.Regular, GraphicsUnit.Point)

            spr.ActiveSheet.DefaultStyle.Font = New Font("Tahoma", Fontsize, GraphicsUnit.Point)

            If DefaultRowHeight = True Then
                spr.ActiveSheet.SetRowHeight(-1, cSprRowHeight)
            Else
                spr.ActiveSheet.SetRowHeight(-1, Rowheight)
            End If

            spr.ActiveSheet.GrayAreaBackColor = cSprGreyAreaBackColor
            spr.ActiveSheet.SelectionBackColor = cSprSelectionBackColor
            spr.ActiveSheet.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.SelectionColors

            spr.ActiveSheet.Columns(-1).BackColor = Color.White
            spr.ActiveSheet.Columns(-1).Font = New Font("Tahoma", Fontsize, FontStyle.Regular)

            spr.ActiveSheet.OperationMode = OperationMode

            spr.ActiveSheet.FrozenColumnCount = ColsFrozen
            spr.ActiveSheet.FrozenRowCount = RowsFrozen

            spr.ActiveSheet.DefaultStyle.VerticalAlignment = CellVerticalAlignment.Center

            spr.ActiveSheet.DefaultStyle.Locked = Lock
            spr.FocusRenderer = New FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer(2)

            spr.RetainSelectionBlock = RetainSelectionBlock
            spr.EditModeReplace = True

            spr.ActiveSheet.Rows.Count = MaxRows
            ' Thêm ko cho copy
            spr.AutoClipboard = AutoClip

            'spr.VisualStyles = FarPoint.Win.VisualStyles.Off
            spr.EditModeReplace = True

        Catch ex As Exception
            MsgBoxP("Can not load the Spread")
        End Try
    End Sub

    Public Sub SPR_SETDEFAULT(ByRef spr As FarPoint.Win.Spread.FpSpread, _
    Optional ByVal ColsFrozen As Integer = 0, _
    Optional ByVal RowsFrozen As Integer = 0, _
    Optional ByVal OperationMode As OperationMode = FarPoint.Win.Spread.OperationMode.RowMode, _
    Optional ByVal Lock As Boolean = False, _
    Optional ByVal DefaultRowHeight As Boolean = True, _
    Optional ByVal HeaderTextMode As Boolean = False, _
    Optional ByVal RetainSelectionBlock As Boolean = False, _
    Optional ByVal Fontsize As Integer = 9, _
    Optional ByVal Rowheight As Integer = 20, _
    Optional ByVal Sort As Boolean = False)
        Try

            spr.Font = New Font("Tahoma", Fontsize, FontStyle.Regular, GraphicsUnit.Point)

            spr.ActiveSheet.DefaultStyle.Font = New Font("Tahoma", Fontsize, GraphicsUnit.Point)

            If DefaultRowHeight = True Then
                spr.ActiveSheet.SetRowHeight(-1, cSprRowHeight)
            Else
                spr.ActiveSheet.SetRowHeight(-1, Rowheight)
            End If

            If HeaderTextMode = True Then

                Dim ct As New CellType.TextCellType

                spr.ActiveSheet.ColumnHeader.DefaultStyle.CellType = ct

            End If


            spr.ActiveSheet.GrayAreaBackColor = cSprGreyAreaBackColor
            spr.ActiveSheet.SelectionBackColor = cSprSelectionBackColor

            spr.ActiveSheet.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.SelectionColors

            spr.ActiveSheet.OperationMode = OperationMode

            spr.ActiveSheet.FrozenColumnCount = ColsFrozen

            spr.ActiveSheet.DefaultStyle.VerticalAlignment = CellVerticalAlignment.Center

            spr.ActiveSheet.DefaultStyle.Locked = Lock
            spr.FocusRenderer = New FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer(1)

            spr.RetainSelectionBlock = RetainSelectionBlock

            'spr.EditModeReplace = True
        Catch ex As Exception
            MsgBoxP("Can not load the Spread")
        End Try
    End Sub

    Public Sub SPR_PRO(ByRef spr As FarPoint.Win.Spread.FpSpread, _
    ByVal Xcol As Integer, _
    ByVal Lable As String, _
    ByVal CodeName As String, _
    ByVal Datatype As Integer, _
    ByVal Datasize As Integer, _
    ByVal Decimal_ As Integer, _
    ByVal Sizewidth As Integer, _
    ByVal Backcolor As String, _
    ByVal Forecolor As String, _
    ByVal Fontname As String, _
    ByVal Fontsize As String, _
    ByVal Fontbold As Integer, _
    ByVal VerticalAlignment As Integer, _
    ByVal HorizontalAlignment As Integer)
        Try
            Dim str(), str1() As String

            spr.ActiveSheet.ColumnHeader.Columns(Xcol).Label = Lable
            spr.ActiveSheet.ColumnHeader.Columns(Xcol).Tag = CodeName

            Select Case Datatype
                Case 0
                    SPR_TEXTBOX(spr, Xcol, Datasize)
                Case 1
                    SPR_NUMBERCELL(spr, Decimal_, Datasize, Xcol)
                Case 2
                    SPR_BUTTON(spr, Xcol)
                Case 3
                    SPR_COMBOBOX(spr, Xcol)
                Case 4
                    SPR_CHECKBOX(spr, Xcol)
                Case 7
                    SPR_PERCENTCELL(spr, Decimal_, Datasize, Xcol)

            End Select

            spr.ActiveSheet.ColumnHeader.Columns(Xcol).Width = Sizewidth
            If Sizewidth = 111 Then
                spr.ActiveSheet.ColumnHeader.Columns(Xcol).Width = spr.ActiveSheet.ColumnHeader.Columns(Xcol).GetPreferredWidth
            End If
            str = Split(Backcolor, "-")
            spr.ActiveSheet.Columns(Xcol).BackColor = System.Drawing.Color.FromArgb(CInt(str(0)), CInt(str(1)), CInt(str(2)))

            str1 = Split(Forecolor, "-")
            spr.ActiveSheet.Columns(Xcol).ForeColor = System.Drawing.Color.FromArgb(CInt(str1(0)), CInt(str1(1)), CInt(str1(2)))

            Dim newfont As Font
            If Fontbold = 0 Then
                newfont = New Font(Fontname, CSng(Fontsize), Drawing.FontStyle.Regular)
            Else
                newfont = New Font(Fontname, CSng(Fontsize), Drawing.FontStyle.Bold)
            End If
            spr.ActiveSheet.ColumnHeader.Columns(Xcol).Font = newfont
            spr.ActiveSheet.Columns(Xcol).VerticalAlignment = VerticalAlignment
            spr.ActiveSheet.Columns(Xcol).HorizontalAlignment = HorizontalAlignment
            spr.ActiveSheet.ActiveSkin = New FarPoint.Win.Spread.SheetSkin("SheetSkin1", System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer)), FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer)), System.Drawing.Color.White, System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.White, System.Drawing.SystemColors.ButtonFace, False, False, False, True, True, True, False, True, "RowHeaderDefault", "RowHeaderDefault", "RowHeaderDefault", "DataAreaDefault", "RowHeaderDefault")
            spr.ActiveSheet.ColumnFooter.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Catch ex As Exception
            MsgBoxP("Can not load the Spread")
        End Try
    End Sub

    Public Sub SPR_PRO(ByRef spr As FarPoint.Win.Spread.FpSpread, _
    ByVal Xcol As Integer, _
    ByVal Value As T9911_AREA)
        Try
            Dim str(), str1() As String

            spr.ActiveSheet.ColumnHeader.Columns(Xcol).Label = Value.ItemNameSimply
            spr.ActiveSheet.ColumnHeader.Columns(Xcol).Tag = Value.ItemCode & Value.ItemName

            Select Case Value.DataType
                Case 0
                    SPR_TEXTBOX(spr, Xcol, Value.DataSize)
                Case 1
                    SPR_NUMBERCELL(spr, Value.DataDecimal, CInt(Value.DataSize), Xcol)
                Case 2
                    SPR_BUTTON(spr, Xcol)
                Case 3
                    SPR_COMBOBOX(spr, Xcol)
                Case 4
                    SPR_CHECKBOX(spr, Xcol)
                Case 5
                    SPR_DATEVALUE(spr, Xcol)
                Case 6
                    SPR_TEXTBOX(spr, Xcol, Value.DataSize)
                Case 7
                    SPR_PERCENTCELL(spr, Value.DataDecimal, CInt(Value.DataSize), Xcol)
            End Select
            spr.ActiveSheet.ColumnHeader.Columns(Xcol).Width = Value.SizeWidth

            str = Split(Value.BackColot, "-")
            spr.ActiveSheet.Columns(Xcol).BackColor = System.Drawing.Color.FromArgb(CInt(str(0)), CInt(str(1)), CInt(str(2)))

            str1 = Split(Value.ForeColor, "-")
            spr.ActiveSheet.Columns(Xcol).ForeColor = System.Drawing.Color.FromArgb(CInt(str1(0)), CInt(str1(1)), CInt(str1(2)))

            spr.ActiveSheet.Columns(Xcol).VerticalAlignment = Value.VerticalAlignment
            spr.ActiveSheet.Columns(Xcol).HorizontalAlignment = Value.HorizontalAlignment

        Catch ex As Exception
            MsgBoxP("Can not load the Spread")
        End Try

    End Sub

    Public Sub SPR_TOTALHEAD(ByRef spr As FarPoint.Win.Spread.FpSpread, SCol As Integer, Ecol As Integer)
        Dim i, j As Integer
        Try
            spr.ActiveSheet.Rows.Add(0, 1)
            SPR_BACKCOLORROWTOTAL(spr, cRelation3HeaderColor, 0)
            Dim ConAmount As Decimal
            Dim HeadAmount As Decimal

            For i = SCol To Ecol
                HeadAmount = 0
                For j = 1 To spr.ActiveSheet.RowCount - 1
                    ConAmount = CDecp(getData(spr, i, j))
                    HeadAmount += ConAmount
                Next
                setData(spr, i, 0, HeadAmount)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub SPR_TOTALHEAD_nochange(ByRef spr As FarPoint.Win.Spread.FpSpread, SCol As Integer, Ecol As Integer)
        Dim i, j As Integer
        Try
            SPR_BACKCOLORROWTOTAL(spr, cRelation3HeaderColor, 0)
            Dim ConAmount As Decimal
            Dim HeadAmount As Decimal

            For i = SCol To Ecol
                HeadAmount = 0
                For j = 1 To spr.ActiveSheet.RowCount - 1
                    ConAmount = CDecp(getData(spr, i, j))
                    HeadAmount += ConAmount
                Next
                setData(spr, i, 0, HeadAmount)
            Next
        Catch ex As Exception

        End Try
    End Sub
    Public Sub SPR_TOTALHEAD(ByRef spr As FarPoint.Win.Spread.FpSpread, BaseColumn As String, SCol As Integer, Ecol As Integer)
        Dim i, j As Integer
        Try
            Dim ConAmount As Decimal
            Dim HeadAmount As Decimal

            For j = 0 To spr.ActiveSheet.RowCount - 1
                HeadAmount = 0
                For i = SCol To Ecol
                    ConAmount = CDecp(getData(spr, i, j))
                    HeadAmount += ConAmount
                Next
                setData(spr, getColumIndex(spr, BaseColumn), j, HeadAmount)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub SPR_TOTAL(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal ColumnBase As String, ByVal ColumnCal As String)
        Dim ValueS As String = ""
        Dim ValueE As String = ""
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer

        Dim ColumnTitle As Integer

        Dim ColumnBaseCnt As Integer
        Dim ColumnCalCnt As Integer
        Dim Rowcnt As Integer

        Dim SubAmount() As Double

        Try
            ColumnTitle = CIntp(Split(ColumnBase, ",")(0))
            ColumnBaseCnt = Split(ColumnBase, ",").Count
            ColumnCalCnt = Split(ColumnCal, ",").Count
            Rowcnt = spr.ActiveSheet.RowCount
            ReDim SubAmount(ColumnCalCnt)

            Do While i < Rowcnt
                ValueS = ""
                For j = 0 To ColumnBaseCnt - 1
                    ValueS = ValueS & getData(spr, CIntp(Split(ColumnBase, ",")(j)), i)
                Next

                If i > 0 And ValueS <> ValueE And ValueS <> "" And ValueE <> "" Then
                    spr.ActiveSheet.Rows.Add(i, 1)
                    For k = 0 To ColumnCalCnt - 1
                        setData(spr, CIntp(Split(ColumnCal, ",")(k)), i, IIf(SubAmount(k) > 0, SubAmount(k), Nothing))
                        SubAmount(k) = 0
                    Next
                    SPR_BACKCOLORROWTOTAL(spr, cRelation1HeaderColor, i)
                    'setData(spr, ColumnTitle, i, ValueE)

                    setData(spr, ColumnTitle, i, "")

                    Dim bottomborder As New FarPoint.Win.ComplexBorderSide(True, Color.Red, 1, System.Drawing.Drawing2D.DashStyle.Solid, Nothing, New Single() {0.1, 0.2, 0.3, 0.6, 0.7, 0.9})
                    spr.Sheets(0).Cells(i, 0, i, spr.ActiveSheet.ColumnCount - 1).Border = New FarPoint.Win.ComplexBorder(Nothing, Nothing, Nothing, bottomborder)

                    i += 1
                    Rowcnt += 1
                End If

                If ValueS <> "" Then
                    For k = 0 To ColumnCalCnt - 1
                        SubAmount(k) = SubAmount(k) + CDblp(getData(spr, CIntp(Split(ColumnCal, ",")(k)), i))
                    Next
                End If
                ValueE = ""
                For j = 0 To ColumnBaseCnt - 1
                    ValueE = ValueE & getData(spr, CIntp(Split(ColumnBase, ",")(j)), i)
                Next
                i += 1
            Loop

            spr.ActiveSheet.Rows.Add(i, 1)
            Rowcnt += 1
            SPR_BACKCOLORROWTOTAL(spr, cRelation1HeaderColor, i)
            'setData(spr, ColumnTitle, i, ValueE)
            setData(spr, ColumnTitle, i, "")

            Dim bottomborder1 As New FarPoint.Win.ComplexBorderSide(True, Color.Red, 1, System.Drawing.Drawing2D.DashStyle.Solid, Nothing, New Single() {0.1, 0.2, 0.3, 0.6, 0.7, 0.9})
            spr.Sheets(0).Cells(i, 0, i, spr.ActiveSheet.ColumnCount - 1).Border = New FarPoint.Win.ComplexBorder(Nothing, Nothing, Nothing, bottomborder1)

            For k = 0 To ColumnCalCnt - 1
                setData(spr, CIntp(Split(ColumnCal, ",")(k)), i, IIf(SubAmount(k) > 0, SubAmount(k), Nothing))
                SubAmount(k) = 0
            Next

            'spr.ActiveSheet.Columns(ColumnTitle).Width = spr.ActiveSheet.Columns(ColumnTitle).GetPreferredWidth
        Catch ex As Exception

        End Try


    End Sub


    Public Sub SPR_SEPARATE(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal ColumnBase As String, ByVal ColumnCal As String)
        Dim ValueS As String = ""
        Dim ValueE As String = ""
        Dim i As Integer
        Dim j As Integer

        Dim ColumnTitle As Integer

        Dim ColumnBaseCnt As Integer
        Dim ColumnCalCnt As Integer
        Dim Rowcnt As Integer

        Try

            ColumnTitle = CIntp(Split(ColumnBase, ",")(0))
            ColumnBaseCnt = Split(ColumnBase, ",").Count
            ColumnCalCnt = Split(ColumnCal, ",").Count
            Rowcnt = spr.ActiveSheet.RowCount

            Do While i < Rowcnt
                ValueS = ""
                For j = 0 To ColumnBaseCnt - 1
                    ValueS = ValueS & getData(spr, CIntp(Split(ColumnBase, ",")(j)), i)
                Next

                If i > 0 And ValueS <> ValueE And ValueS <> "" And ValueE <> "" Then
                    spr.ActiveSheet.Rows.Add(i, 1)

                    SPR_BACKCOLORROWTOTAL(spr, cRelation1HeaderColor, i)
                    'setData(spr, ColumnTitle, i, ValueE)

                    Dim bottomborder As New FarPoint.Win.ComplexBorderSide(True, Color.Red, 1, System.Drawing.Drawing2D.DashStyle.Solid, Nothing, New Single() {0.1, 0.2, 0.3, 0.6, 0.7, 0.9})
                    spr.Sheets(0).Cells(i, 0, i, spr.ActiveSheet.ColumnCount - 1).Border = New FarPoint.Win.ComplexBorder(Nothing, Nothing, Nothing, bottomborder)

                    i += 1
                    Rowcnt += 1
                End If

                If ValueS <> "" Then

                End If
                ValueE = ""
                For j = 0 To ColumnBaseCnt - 1
                    ValueE = ValueE & getData(spr, CIntp(Split(ColumnBase, ",")(j)), i)
                Next
                i += 1
            Loop

            spr.ActiveSheet.Rows.Add(i, 1)
            Rowcnt += 1
            SPR_BACKCOLORROWTOTAL(spr, cRelation1HeaderColor, i)
            'setData(spr, ColumnTitle, i, ValueE)

            Dim bottomborder1 As New FarPoint.Win.ComplexBorderSide(True, Color.Red, 1, System.Drawing.Drawing2D.DashStyle.Solid, Nothing, New Single() {0.1, 0.2, 0.3, 0.6, 0.7, 0.9})
            spr.Sheets(0).Cells(i, 0, i, spr.ActiveSheet.ColumnCount - 1).Border = New FarPoint.Win.ComplexBorder(Nothing, Nothing, Nothing, bottomborder1)

            'spr.ActiveSheet.Columns(ColumnTitle).Width = spr.ActiveSheet.Columns(ColumnTitle).GetPreferredWidth
        Catch ex As Exception

        End Try


    End Sub

    Public Sub SPR_SEPARATE_LINE(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal ColumnBase As String, ByVal ColumnCal As String)
        Dim ValueS As String = ""
        Dim ValueE As String = ""
        Dim i As Integer
        Dim j As Integer

        Dim ColumnTitle As Integer

        Dim ColumnBaseCnt As Integer
        Dim ColumnCalCnt As Integer
        Dim Rowcnt As Integer

        Try
            ColumnTitle = CIntp(Split(ColumnBase, ",")(0))
            ColumnBaseCnt = Split(ColumnBase, ",").Count
            ColumnCalCnt = Split(ColumnCal, ",").Count
            Rowcnt = spr.ActiveSheet.RowCount

            Do While i < Rowcnt
                ValueS = ""
                For j = 0 To ColumnBaseCnt - 1
                    ValueS = ValueS & getData(spr, CIntp(Split(ColumnBase, ",")(j)), i)
                Next

                If i > 0 And ValueS <> ValueE And ValueS <> "" And ValueE <> "" Then
                    'SPR_BACKCOLORROWTOTAL(spr, cRelation1HeaderColor, i)
                    'setData(spr, ColumnTitle, i, ValueE)

                    Dim bottomborder As New FarPoint.Win.ComplexBorderSide(True, Color.Red, 1, System.Drawing.Drawing2D.DashStyle.Solid, Nothing, New Single() {0.1, 0.2, 0.3, 0.6, 0.7, 0.9})
                    spr.Sheets(0).Cells(i, 0, i, spr.ActiveSheet.ColumnCount - 1).Border = New FarPoint.Win.ComplexBorder(Nothing, Nothing, Nothing, bottomborder)

                    'i += 1
                    'Rowcnt += 1
                End If

                If ValueS <> "" Then

                End If
                ValueE = ""
                For j = 0 To ColumnBaseCnt - 1
                    ValueE = ValueE & getData(spr, CIntp(Split(ColumnBase, ",")(j)), i)
                Next
                i += 1
            Loop
            i -= 1
            'Rowcnt += 1
            'SPR_BACKCOLORROWTOTAL(spr, cRelation1HeaderColor, i)
            'setData(spr, ColumnTitle, i, ValueE)

            Dim bottomborder1 As New FarPoint.Win.ComplexBorderSide(True, Color.Red, 1, System.Drawing.Drawing2D.DashStyle.Solid, Nothing, New Single() {0.1, 0.2, 0.3, 0.6, 0.7, 0.9})
            spr.Sheets(0).Cells(i, 0, i, spr.ActiveSheet.ColumnCount - 1).Border = New FarPoint.Win.ComplexBorder(Nothing, Nothing, Nothing, bottomborder1)

            spr.ActiveSheet.Columns(ColumnTitle).Width = spr.ActiveSheet.Columns(ColumnTitle).GetPreferredWidth
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_NUMBERCELLFOOTER(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal DecCol As Integer, ByVal DataSize As Integer, _
         ByVal ParamArray ColumnNo() As Integer)
        Dim i As Integer
        Dim nc As New FarPoint.Win.Spread.CellType.NumberCellType
        Try
            nc.ShowSeparator = True
            nc.DecimalPlaces = DecCol
            nc.MaximumValue = 999999999999
            nc.MinimumValue = -999999999999
            nc.NegativeRed = True

            For i = 0 To UBound(ColumnNo)
                spr.ActiveSheet.ColumnFooter.Columns(ColumnNo(i)).CellType = nc
                spr.ActiveSheet.ColumnFooter.Columns(ColumnNo(i)).HorizontalAlignment = CellHorizontalAlignment.Right
            Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Spr_AddHandleCheck(sender As Object, e As CellClickEventArgs)
        Try

            If e.ColumnHeader = True And e.Column = getColumIndex(sender, "CheckUse") Then
                SPR_HEADCHK(sender, e, e.Column)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_PRO(ByRef spr As FarPoint.Win.Spread.FpSpread, datatr As DataSet, program As String, sheetname As String, Optional Header As Boolean = False)
        Call SPR_PRO_NEW(spr, datatr, program, sheetname, Header)
    End Sub


    Public Sub READ_SPREAD(ByRef spr As FarPoint.Win.Spread.FpSpread, datatr As DataSet, program As String, sheetname As String, Row As Integer)
        If GetDsRc(datatr) = 0 Then Exit Sub
        Try
            Dim DATAreader As SqlClient.SqlDataReader
            Dim ColumnName As String
            Dim i As Integer

            For i = 0 To GetDsCc(datatr) - 1
                ColumnName = getColumName(datatr, i)
                Try
                    DATAreader = PrcDRSheet("USP_SPREAD_PROGRAM_SEARCH_ITEMNAME", cn, program, sheetname, ColumnName)

                    If DATAreader.HasRows Then
                        DATAreader.Read()

                        If ColumnName.ToUpper = DATAreader("K9911_ItemName").ToString.ToUpper Then
                            If TypeOf (spr.ActiveSheet.Columns(getColumIndex(spr, ColumnName)).CellType) Is FarPoint.Win.Spread.CellType.CheckBoxCellType Then
                                setData(spr, getColumIndex(spr, ColumnName), Row, GetDsDataToCk(datatr, 0, ColumnName), , True)

                            ElseIf TypeOf (spr.ActiveSheet.Columns(getColumIndex(spr, ColumnName)).CellType) Is FarPoint.Win.Spread.CellType.ComboBoxCellType Then
                                setDataCB(spr, getColumIndex(spr, ColumnName), Row, GetDsData(datatr, 0, ColumnName))

                            ElseIf TypeOf (spr.ActiveSheet.Columns(getColumIndex(spr, ColumnName)).CellType) Is FarPoint.Win.Spread.CellType.ButtonCellType Then
                                If ColumnName = "CheckPrescription" Then
                                    If getData(spr, getColumIndex(spr, ColumnName), Row) = True Then
                                        SPR_BUTTON_S(spr, getColumIndex(spr, "PrescriptionWeavingCheck"), Row)
                                    End If
                                Else
                                    setData(spr, getColumIndex(spr, ColumnName), Row, GetDsData(datatr, 0, ColumnName))
                                End If

                            ElseIf spr.ActiveSheet.Columns(getColumIndex(spr, ColumnName)).Label.Contains("Date") = True Then
                                setData(spr, getColumIndex(spr, ColumnName), Row, FSDate(GetDsData(datatr, 0, ColumnName)))

                            ElseIf spr.ActiveSheet.Columns(getColumIndex(spr, ColumnName)).Label.Contains("Time") = True Then
                                setData(spr, getColumIndex(spr, ColumnName), Row, FSDate(GetDsData(datatr, 0, ColumnName)))

                            ElseIf DATAreader("K9911_REMK").ToString.Trim <> "" And DATAreader("K9911_CheckDev").ToString.Trim = "0" Then
                                Dim DataConvert() As String
                                DataConvert = Split(DATAreader("K9911_REMK").ToString.Trim, ";")
                                If CIntp(GetDsData(datatr, Row, ColumnName)) > 0 Then
                                    'setData(spr, getColumIndex(spr, ColumnName), Row, DataConvert(CIntp(GetDsData(datatr, 0, ColumnName)) - 1))

                                    setTextConvert(spr, DataConvert, i, 1, spr.ActiveSheet.RowCount)
                                End If
                            Else
                                setData(spr, getColumIndex(spr, ColumnName), Row, GetDsData(datatr, 0, ColumnName))
                            End If

                        End If
                        DATAreader.Close()
                    Else
                        DATAreader.Close()
                    End If
                Catch ex As Exception

                End Try

            Next

        Catch ex As Exception
            MsgBoxP(program & sheetname, vbCritical)

        End Try
    End Sub

    Public Sub READ_SPREAD_N(ByRef spr As FarPoint.Win.Spread.FpSpread, datatr As DataSet, RowCount As Integer, program As String, sheetname As String)
        Try

            Dim DATAreader As SqlClient.SqlDataReader
            Dim ColumnName As String
            Dim i, j As Integer
            spr.ActiveSheet.RowCount = 0
            spr.ActiveSheet.RowCount = RowCount

            For i = 0 To GetDsCc(datatr) - 1
                ColumnName = getColumName(datatr, i)
                DATAreader = PrcDRSheet("USP_SPREAD_PROGRAM_SEARCH_ITEMNAME", cn, program, sheetname, ColumnName)
                If DATAreader.HasRows Then
                    DATAreader.Read()
                    If ColumnName.ToUpper = DATAreader("K9911_ItemName").ToString.ToUpper Then
                        If TypeOf (spr.ActiveSheet.Columns(getColumIndex(spr, ColumnName)).CellType) Is FarPoint.Win.Spread.CellType.CheckBoxCellType Then
                            For j = 0 To RowCount - 1
                                setDataChk(spr, getColumIndex(spr, ColumnName), j, GetDsData(datatr, j, ColumnName))
                            Next
                        ElseIf TypeOf (spr.ActiveSheet.Columns(getColumIndex(spr, ColumnName)).CellType) Is FarPoint.Win.Spread.CellType.ButtonCellType Then
                            If ColumnName = "CheckPrescription" Then
                                For j = 0 To RowCount - 1
                                    If getData(spr, getColumIndex(spr, ColumnName), j) = True Then
                                        If CDblp(getColumIndex(spr, "PrescriptionWeavingCheck")) > 0 Then
                                            SPR_BUTTON_S(spr, getColumIndex(spr, "PrescriptionWeavingCheck"), j)
                                        ElseIf CDblp(getColumIndex(spr, "PrescriptionProductionCheck")) > 0 Then
                                            SPR_BUTTON_S(spr, getColumIndex(spr, "PrescriptionWeavingCheck"), j)
                                        End If
                                    End If
                                Next
                            Else
                                For j = 0 To RowCount - 1
                                    setData(spr, getColumIndex(spr, ColumnName), j, GetDsData(datatr, j, ColumnName))
                                Next
                            End If
                        ElseIf ColumnName = "CheckPrescription" Then
                            For j = 0 To RowCount - 1
                                If getData(spr, getColumIndex(spr, ColumnName), j) = True Then
                                    If CDblp(getColumIndex(spr, "PrescriptionWeavingCheck")) > 0 Then
                                        SPR_BUTTON_S(spr, getColumIndex(spr, "PrescriptionWeavingCheck"), j)
                                    ElseIf CDblp(getColumIndex(spr, "PrescriptionProductionCheck")) > 0 Then
                                        SPR_BUTTON_S(spr, getColumIndex(spr, "PrescriptionWeavingCheck"), j)
                                    End If
                                End If
                            Next
                        Else
                            For j = 0 To RowCount - 1
                                setData(spr, getColumIndex(spr, ColumnName), j, GetDsData(datatr, j, ColumnName))
                            Next
                        End If

                    End If
                    DATAreader.Close()
                Else
                    DATAreader.Close()
                End If
            Next


        Catch ex As Exception
            MsgBoxP(program & sheetname, vbCritical)
            '  Application.Exit()
        End Try
    End Sub

    Public Sub READ_SPREAD_N(ByRef spr As FarPoint.Win.Spread.FpSpread, datatr As DataSet, RowBegin As Integer, RowCount As Integer, program As String, sheetname As String)

        If RowBegin + RowCount >= spr.ActiveSheet.RowCount Then
            spr.ActiveSheet.RowCount += RowBegin + RowCount - spr.ActiveSheet.RowCount '+ 1
        End If


        Dim DATAreader As SqlClient.SqlDataReader
        Dim ColumnName As String
        Dim i, j As Integer
        Try
            For i = 0 To GetDsCc(datatr) - 1
                ColumnName = getColumName(datatr, i)
                DATAreader = PrcDRSheet("USP_SPREAD_PROGRAM_SEARCH_ITEMNAME", cn, program, sheetname, ColumnName)
                If DATAreader.HasRows Then
                    DATAreader.Read()
                    If ColumnName.ToUpper = DATAreader("K9911_ItemName").ToString.ToUpper Then
                        If TypeOf (spr.ActiveSheet.Columns(getColumIndex(spr, ColumnName)).CellType) Is FarPoint.Win.Spread.CellType.CheckBoxCellType Then
                            For j = 0 To RowCount - 1
                                setData(spr, getColumIndex(spr, ColumnName), RowBegin + j, GetDsData(datatr, j, ColumnName), , True)
                            Next
                        Else
                            For j = 0 To RowCount - 1
                                setData(spr, getColumIndex(spr, ColumnName), RowBegin + j, GetDsData(datatr, j, ColumnName))
                            Next
                        End If

                    End If
                    DATAreader.Close()
                Else
                    DATAreader.Close()
                End If
            Next

            'FarPoint.Win.Spread.SheetSkin.Load(App_Path & "\Skin.skn").Apply(spr.ActiveSheet)
        Catch ex As Exception
            MsgBoxP(program & sheetname, vbCritical)
            ' Application.Exit()
        End Try
    End Sub

    Public Sub SPR_HeadClick(spr As FarPoint.Win.Spread.FpSpread, e As CellClickEventArgs)
        Dim i As Integer
        If e.ColumnHeader = True And e.Column = 0 Then
            For i = 0 To spr.ActiveSheet.RowCount - 1
                If getData(spr, 0, i) = "1" Then
                    setData(spr, 0, i, "0", , True)
                ElseIf getData(spr, 0, i) = "0" Then
                    setData(spr, 0, i, "1", , True)
                End If
            Next
        End If
    End Sub

    Public Sub SPR_HEADCHK(spr As FarPoint.Win.Spread.FpSpread, e As CellClickEventArgs, ColumnIndex As Integer)
        Dim i As Integer
        Try
            If spr.ActiveSheet.RowFilter IsNot Nothing Then
                For i = 0 To spr.ActiveSheet.RowCount - 1
                    If spr.ActiveSheet.RowFilter.IsRowFilteredOut(i) = False Then
                        If getDataM(spr, ColumnIndex, i) = "1" Then
                            setDataChk(spr, ColumnIndex, i, "2")
                        ElseIf getDataM(spr, ColumnIndex, i) = "2" Then
                            setDataChk(spr, ColumnIndex, i, "1")
                        End If
                    End If
                Next

            Else
                For i = 0 To spr.ActiveSheet.RowCount - 1
                    If getDataM(spr, ColumnIndex, i) = "1" Then
                        setDataChk(spr, ColumnIndex, i, "2")
                    ElseIf getDataM(spr, ColumnIndex, i) = "2" Then
                        setDataChk(spr, ColumnIndex, i, "1")
                    End If
                Next

            End If

        Catch ex As Exception

        End Try
    End Sub

    Public Sub SPR_MERGEPOLICY(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal Alwaycol As Integer, ByVal StartCol As Integer, ByVal EndCol As Integer)
        Dim i As Integer
        spr.ActiveSheet.Columns(Alwaycol).MergePolicy = Model.MergePolicy.Always
        For i = StartCol To EndCol
            spr.ActiveSheet.Columns(i).MergePolicy = Model.MergePolicy.Restricted
        Next
    End Sub

    Public Sub SPR_INSERT(ByRef spr As FarPoint.Win.Spread.FpSpread)
        Dim i As Integer
        Try
            For i = 0 To spr.ActiveSheet.RowCount - 1
                spr.ActiveSheet.Rows(i).Font = New Font("Tahoma", 9, (FontStyle.Italic Or FontStyle.Bold), GraphicsUnit.Point)
            Next

            'spr.ActiveSheet.Rows(-1).Font = New Font("Tahoma", 9, FontStyle.Italic, GraphicsUnit.Point)
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_MERGEALWAYS(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal ParamArray ColumnNo() As Integer)
        Dim i As Integer
        Try
            For i = 0 To UBound(ColumnNo)
                spr.ActiveSheet.Columns(ColumnNo(i)).MergePolicy = Model.MergePolicy.Always
                spr.ActiveSheet.Columns(ColumnNo(i)).VerticalAlignment = CellVerticalAlignment.Top
            Next
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_MERGEALWAYS(ByVal ColumnNo As Integer, ByRef spr As FarPoint.Win.Spread.FpSpread)
        Dim i As Integer
        Try
            For i = 0 To ColumnNo
                spr.ActiveSheet.Columns(i).VerticalAlignment = CellVerticalAlignment.Top
                spr.ActiveSheet.Columns(i).MergePolicy = Model.MergePolicy.Always
            Next
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_MERGERESTRICT(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal ParamArray ColumnNo() As Integer)
        Dim i As Integer
        Try
            For i = 0 To UBound(ColumnNo)
                spr.ActiveSheet.Columns(ColumnNo(i)).VerticalAlignment = CellVerticalAlignment.Top
                spr.ActiveSheet.Columns(ColumnNo(i)).MergePolicy = Model.MergePolicy.Restricted
            Next
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_HEIWID(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal height As Integer, ByVal width As Integer)
        Try
            spr.ActiveSheet.SetMultipleRowHeights(0, spr.ActiveSheet.RowCount, height)
            spr.ActiveSheet.SetMultipleColumnWidths(0, spr.ActiveSheet.ColumnCount, width)
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_BUTTON(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, _
                 Optional ByVal Colname As String = "")
        Dim nc As New FarPoint.Win.Spread.CellType.ButtonCellType
        Try
            nc.UseVisualStyleBackColor = False
            nc.ButtonColor = Color.Yellow
            nc.Text = Colname
            If Colname = "" Then nc.Text = Space(1)
            spr.ActiveSheet.Columns(Col).CellType = nc
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_PROGRESS(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, _
                Optional ByVal Colname As String = "")
        Dim nc As New FarPoint.Win.Spread.CellType.ProgressCellType
        Try
            nc.FillColor = System.Drawing.Color.Blue
            nc.FillColor2 = System.Drawing.Color.Cyan
            nc.FillTextColor = System.Drawing.Color.Black
            nc.Orientation = FarPoint.Win.ProgressOrientation.LeftToRight
            nc.TextStyle = FarPoint.Win.ProgressTextStyle.Value
            nc.GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal

            spr.ActiveSheet.Columns(Col).CellType = nc

        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_PROGRESS_S(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer)
        Dim nc As New FarPoint.Win.Spread.CellType.ProgressCellType
        Try


            nc.FillColor = System.Drawing.Color.Blue
            nc.FillColor2 = System.Drawing.Color.Cyan
            nc.FillTextColor = System.Drawing.Color.Black
            nc.Orientation = FarPoint.Win.ProgressOrientation.LeftToRight
            nc.TextStyle = FarPoint.Win.ProgressTextStyle.Value
            nc.GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal

            spr.ActiveSheet.Cells(Row, Col).CellType = nc
        Catch ex As Exception

        End Try
    End Sub

    Public Sub SPR_BUTTON_S(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer, _
                Optional ByVal Colname As String = "")
        Try
            Dim nc As New FarPoint.Win.Spread.CellType.ButtonCellType
            nc.UseVisualStyleBackColor = False
            nc.ButtonColor = Color.Yellow
            'If Colname <> "" Then nc.Text = Colname
            nc.Text = Colname
            If Colname = "" Then nc.Text = Space(1)
            spr.ActiveSheet.Cells(Row, Col).CellType = nc
        Catch ex As Exception
            MsgBoxP("SPR_BUTTON_S")
        End Try
    End Sub

    Public Sub SPR_TEXTBOXM(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, _
                 Optional ByVal maxlen As Integer = 1000)
        Try
            Dim nc As New FarPoint.Win.Spread.CellType.TextCellType
            nc.MaxLength = maxlen
            nc.Multiline = True
            spr.ActiveSheet.Columns(Col).CellType = nc
        Catch ex As Exception
            MsgBoxP("SPR_TEXTBOX")
        End Try

    End Sub

    Public Sub SPR_TEXTBOX(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, _
                Optional ByVal maxlen As Integer = 100)
        Try
            Dim nc As New FarPoint.Win.Spread.CellType.TextCellType
            nc.MaxLength = maxlen
            spr.ActiveSheet.Columns(Col).CellType = nc
        Catch ex As Exception
            MsgBoxP("SPR_TEXTBOX")
        End Try

    End Sub

    Public Sub SPR_TEXTBOXWARP(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, _
            Optional ByVal maxlen As Integer = 100)
        Try
            Dim nc As New FarPoint.Win.Spread.CellType.TextCellType
            nc.MaxLength = maxlen
            nc.WordWrap = True
            spr.ActiveSheet.Columns(Col).CellType = nc
        Catch ex As Exception
            MsgBoxP("SPR_TEXTBOX")
        End Try

    End Sub

    Public Sub SPR_TEXTBOXROW(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, _
               Optional ByVal maxlen As Integer = 100)
        Try
            Dim nc As New FarPoint.Win.Spread.CellType.TextCellType
            nc.MaxLength = maxlen
            spr.ActiveSheet.Rows(Col).CellType = nc
            spr.ActiveSheet.Rows(Col).HorizontalAlignment = CellHorizontalAlignment.Center
            spr.ActiveSheet.Rows(Col).VerticalAlignment = CellVerticalAlignment.Center
        Catch ex As Exception
            MsgBoxP("SPR_TEXTBOX")
        End Try

    End Sub

    Public Sub SPR_NUMBERROW(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal DeC As Integer, ByVal Row As Integer)
        Try
            Dim nc As New FarPoint.Win.Spread.CellType.NumberCellType
            nc.ShowSeparator = True
            nc.DecimalPlaces = DeC
            nc.MaximumValue = 999999999999
            nc.MinimumValue = -999999999999
            spr.ActiveSheet.Rows(Row).CellType = nc

        Catch ex As Exception
            MsgBoxP("SPR_TEXTBOX_S")
        End Try
    End Sub

    Public Sub SPR_GCTEXTBOX(ByRef spr As FarPoint.Win.Spread.FpSpread, ds As DataSet, Col As Integer, _
              Optional ByVal maxlen As Integer = 100)
        Try
            'Dim inputcell1 As New GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType
            Dim inputcell1 As New FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType

            inputcell1.AcceptsArrowKeys = FarPoint.Win.SuperEdit.AcceptsArrowKeys.AllArrows
            inputcell1.ButtonAlign = FarPoint.Win.ButtonAlign.Right
            Dim acsc As New AutoCompleteStringCollection

            SPR_AddRange(acsc, ds)

            inputcell1.AutoSearch = FarPoint.Win.AutoSearch.MultipleCharacter
            inputcell1.Editable = True
            inputcell1.ColumnEdit = 1
            inputcell1.DataColumn = 2

            inputcell1.ShowGridLines = True
            inputcell1.MaxDrop = 10
            inputcell1.ListWidth = 500
            inputcell1.DataSourceList = ds
            spr.ActiveSheet.Columns(Col).CellType = inputcell1


            SPR_KEY(spr, Keys.Down, FarPoint.Win.Spread.SpreadActions.ComboShowList)
            SPR_KEY(spr, Keys.Up, FarPoint.Win.Spread.SpreadActions.ComboShowList)
            SPR_KEY(spr, Keys.Enter, FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Catch ex As Exception
            MsgBoxP("SPR_TEXTBOX")
        End Try

    End Sub

    Public Sub SPR_MULTICOMBO(ByRef spr As FarPoint.Win.Spread.FpSpread, ds As DataSet, Col As Integer, _
             Optional ByVal maxlen As Integer = 100)
        Try
            Dim inputcell1 As New FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType

            inputcell1.AcceptsArrowKeys = FarPoint.Win.SuperEdit.AcceptsArrowKeys.AllArrows
            inputcell1.ButtonAlign = FarPoint.Win.ButtonAlign.Right

            inputcell1.AutoSearch = FarPoint.Win.AutoSearch.MultipleCharacter
            inputcell1.Editable = True
            inputcell1.ColumnEdit = 1
            inputcell1.DataColumn = 2

            inputcell1.ShowGridLines = True
            inputcell1.MaxDrop = 10
            inputcell1.ListWidth = 500
            inputcell1.DataSourceList = ds
            spr.ActiveSheet.Columns(Col).CellType = inputcell1


            SPR_KEY(spr, Keys.Down, FarPoint.Win.Spread.SpreadActions.ComboShowList)
            SPR_KEY(spr, Keys.Up, FarPoint.Win.Spread.SpreadActions.ComboShowList)
            SPR_KEY(spr, Keys.Enter, FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Catch ex As Exception
            MsgBoxP("SPR_TEXTBOX")
        End Try

    End Sub

    Private Sub SPR_AddRange(ByRef acsc As AutoCompleteStringCollection, ByVal DS As DataSet, ByVal Dscol As Integer)
        Dim i As Integer
        Try
            For i = 0 To GetDsRc(DS) - 1
                acsc.Add(GetDsData(DS, i, Dscol))
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SPR_AddRange(ByRef acsc As AutoCompleteStringCollection, ByVal DS As DataSet)
        Dim i As Integer
        Try
            If GetDsCc(DS) < 2 Then Exit Sub

            For i = 0 To GetDsRc(DS) - 1
                acsc.Add(GetDsData(DS, i, 0) & "-" & GetDsData(DS, i, 1))
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SPR_AddRange(ByRef inputcell As CellType.ComboBoxCellType, ByVal DS As DataSet)
        Try
            If GetDsCc(DS) < 2 Then Exit Sub

        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_TEXTBOX_S(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer)
        Try
            Dim nc As New FarPoint.Win.Spread.CellType.TextCellType
            spr.ActiveSheet.Cells(Row, Col).CellType = nc
        Catch ex As Exception
            MsgBoxP("SPR_TEXTBOX_S")
        End Try
    End Sub

    Public Sub SPR_NUMBER_S(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal DeC As Integer, ByVal Col As Integer, ByVal Row As Integer)
        Try
            Dim nc As New FarPoint.Win.Spread.CellType.NumberCellType
            nc.ShowSeparator = True
            nc.DecimalPlaces = DeC
            nc.MaximumValue = 999999999999
            nc.MinimumValue = -999999999999
            spr.ActiveSheet.Cells(Row, Col).CellType = nc

        Catch ex As Exception
            MsgBoxP("SPR_TEXTBOX_S")
        End Try
    End Sub

    Public Sub SPR_BUTTON_DATA(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer, ByVal Value As Object, Optional ByVal Bold As Boolean = False)
        Dim nc As New FarPoint.Win.Spread.CellType.ButtonCellType
        Try
            nc.UseVisualStyleBackColor = False
            nc.ButtonColor = Color.Yellow
            nc.Text = Value
            fpsA.ActiveSheet.Cells(Row, Col).CellType = nc
            If Bold = True Then fpsA.ActiveSheet.Cells(Row, Col).Font = New Font("Tahoma", 9, FontStyle.Bold)
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_COMBOBOX(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, _
                ByVal ParamArray Colname() As String)
        Dim nc As New FarPoint.Win.Spread.CellType.ComboBoxCellType
        Try
            nc.AutoSearch = FarPoint.Win.AutoSearch.SingleCharacter
            nc.Items = Colname
            spr.ActiveSheet.Columns(Col).CellType = nc
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_COPY(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal Srow As Integer, ByVal Erow As Integer)
        Dim nc As New FarPoint.Win.Spread.CellType.ComboBoxCellType
        Try
            Dim i As Integer

            For i = 0 To spr.ActiveSheet.ColumnCount - 1
                If spr.ActiveSheet.Columns(i).Label.ToUpper.Contains("KEY_") = False Then setData(spr, i, Erow, getData(spr, i, Srow))
            Next

        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_CHECKBOX(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal ParamArray ColumnNo() As Integer)
        Dim i As Integer
        Dim cel As New FarPoint.Win.Spread.CellType.CheckBoxCellType
        Try
            cel.Picture.False = My.Resources.riB_NO
            cel.Picture.FalseDisabled = My.Resources.riB_NO
            cel.Picture.FalsePressed = My.Resources.riB_NO
            cel.Picture.True = My.Resources.riB_YES

            cel.Picture.TrueDisabled = My.Resources.riB_YES
            cel.Picture.TruePressed = My.Resources.riB_YES

            For i = 0 To UBound(ColumnNo)
                spr.ActiveSheet.Columns(ColumnNo(i)).CellType = cel
            Next

        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_CHECKBOXROW(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal ParamArray Rows() As Integer)
        Dim i As Integer
        Dim cel As New FarPoint.Win.Spread.CellType.CheckBoxCellType
        Try
            cel.Picture.False = My.Resources.riB_NO
            cel.Picture.FalseDisabled = My.Resources.riB_NO
            cel.Picture.FalsePressed = My.Resources.riB_NO
            cel.Picture.True = My.Resources.riB_YES

            cel.Picture.TrueDisabled = My.Resources.riB_YES
            cel.Picture.TruePressed = My.Resources.riB_YES

            For i = 0 To UBound(Rows)
                spr.ActiveSheet.Rows(Rows(i)).CellType = cel
            Next

        Catch ex As Exception

        End Try

    End Sub
    Public Sub SPR_IMAGE(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal ParamArray ColumnNo() As Integer)
        Dim i As Integer
        Dim cel As New FarPoint.Win.Spread.CellType.ImageCellType
        cel.Style = FarPoint.Win.RenderStyle.StretchAndScale

        Try
            For i = 0 To UBound(ColumnNo)
                spr.ActiveSheet.Columns(ColumnNo(i)).CellType = cel
            Next

        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_CHECKBOX(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal ColumnNo As Integer, ByVal RowNo As Integer)

        Dim cel As New FarPoint.Win.Spread.CellType.CheckBoxCellType
        Try
            cel.Picture.False = My.Resources.riB_NO
            cel.Picture.FalseDisabled = My.Resources.riB_NO
            cel.Picture.FalsePressed = My.Resources.riB_NO
            cel.Picture.True = My.Resources.riB_YES

            cel.Picture.TrueDisabled = My.Resources.riB_YES
            cel.Picture.TruePressed = My.Resources.riB_YES

            spr.ActiveSheet.Cells(RowNo, ColumnNo).CellType = cel

        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_CHECKBOXALL(ByRef spr As FarPoint.Win.Spread.FpSpread)
        Dim i As Integer
        Dim cel As New FarPoint.Win.Spread.CellType.CheckBoxCellType
        Try
            cel.Picture.False = My.Resources.riB_NO1
            cel.Picture.FalseDisabled = My.Resources.riB_NO1
            cel.Picture.FalsePressed = My.Resources.riB_NO1
            cel.Picture.True = My.Resources.riB_YES1

            cel.Picture.TrueDisabled = My.Resources.riB_YES1
            cel.Picture.TruePressed = My.Resources.riB_YES1

            For i = 0 To spr.ActiveSheet.ColumnCount - 1
                spr.ActiveSheet.Columns(i).CellType = cel
            Next

        Catch ex As Exception

        End Try

    End Sub
    Public Sub SPR_PERCENTCELL(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal DecCol As Integer, ByVal DataSize As Integer, _
           ByVal ParamArray ColumnNo() As Integer)
        Dim i As Integer
        Dim nc As New FarPoint.Win.Spread.CellType.PercentCellType
        nc.ShowSeparator = True
        nc.DecimalPlaces = DecCol
        nc.MaximumValue = 999999999999
        nc.MinimumValue = -999999999999

        For i = 0 To UBound(ColumnNo)
            spr.ActiveSheet.Columns(ColumnNo(i)).CellType = nc
            spr.ActiveSheet.Columns(ColumnNo(i)).HorizontalAlignment = CellHorizontalAlignment.Right
        Next
    End Sub
    Public Sub SPR_DATEVALUE(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal ParamArray ColumnNo() As Integer)
        Dim i, j As Integer
        Try
            For i = 0 To UBound(ColumnNo)
                For j = 0 To spr.ActiveSheet.RowCount - 1
                    setData(spr, ColumnNo(i), j, FSDate(getData(spr, ColumnNo(i), j)))
                Next
            Next

        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_DATIME(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, _
               Optional ByVal maxlen As Integer = 100)
        Try
            Dim nc As New FarPoint.Win.Spread.CellType.DateTimeCellType

            spr.ActiveSheet.Columns(Col).CellType = nc
        Catch ex As Exception
            MsgBoxP("SPR_DATIME")
        End Try

    End Sub

    Public Sub SPR_NUMBERCELL(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal DecCol As Integer, ByVal DataSize As Integer, _
              ByVal ParamArray ColumnNo() As Integer)
        Dim i As Integer
        Dim nc As New FarPoint.Win.Spread.CellType.NumberCellType
        Try
            nc.ShowSeparator = True
            nc.DecimalPlaces = DecCol
            nc.MaximumValue = 999999999999
            nc.MinimumValue = -999999999999
            nc.NegativeRed = True

            For i = 0 To UBound(ColumnNo)
                spr.ActiveSheet.Columns(ColumnNo(i)).CellType = nc
                spr.ActiveSheet.Columns(ColumnNo(i)).HorizontalAlignment = CellHorizontalAlignment.Right
            Next

        Catch ex As Exception

        End Try

    End Sub
    Public Sub SPR_NUMBERCELL_SHEETVIEW(ByRef spr As SheetView, ByVal DecCol As Integer, ByVal DataSize As Integer, _
             ByVal ParamArray ColumnNo() As Integer)
        Dim i As Integer
        Dim nc As New FarPoint.Win.Spread.CellType.NumberCellType
        Try
            nc.ShowSeparator = True
            nc.DecimalPlaces = DecCol
            nc.MaximumValue = 999999999999
            nc.MinimumValue = -999999999999
            nc.NegativeRed = True

            For i = 0 To UBound(ColumnNo)
                spr.Columns(ColumnNo(i)).CellType = nc
                spr.Columns(ColumnNo(i)).HorizontalAlignment = CellHorizontalAlignment.Right
            Next

        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_NUMBERCELL(ByVal SCol As Integer, ByVal Ecol As Integer, ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal DecCol As Integer)
        Dim i As Integer
        Dim nc As New FarPoint.Win.Spread.CellType.NumberCellType
        Try
            nc.ShowSeparator = True
            nc.DecimalPlaces = DecCol
            nc.MaximumValue = 999999999999
            nc.MinimumValue = -999999999999
            nc.NegativeRed = True

            For i = SCol To Ecol
                spr.ActiveSheet.Columns(i).CellType = nc
                spr.ActiveSheet.Columns(i).HorizontalAlignment = CellHorizontalAlignment.Right
            Next
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_NUMBERCELL_SHEETVIEW(ByVal SCol As Integer, ByVal Ecol As Integer, ByRef spr As SheetView, ByVal DecCol As Integer)
        Dim i As Integer
        Dim nc As New FarPoint.Win.Spread.CellType.NumberCellType
        Try
            nc.ShowSeparator = True
            nc.DecimalPlaces = DecCol
            nc.MaximumValue = 999999999999
            nc.MinimumValue = -999999999999
            nc.NegativeRed = True

            For i = SCol To Ecol
                spr.Columns(i).CellType = nc
                spr.Columns(i).HorizontalAlignment = CellHorizontalAlignment.Right
            Next
        Catch ex As Exception

        End Try

    End Sub
    Public Sub SPR_WIDTHCOL(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal DecCol As Integer, _
              ByVal WidCol As Integer)
        Try
            spr.ActiveSheet.Columns(DecCol).Width = WidCol
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_WIDTHCOLPRE(ByRef spr As FarPoint.Win.Spread.FpSpread)
        Try
            For i As Integer = 0 To spr.ActiveSheet.ColumnCount - 1
                spr.ActiveSheet.Columns(i).Width = spr.ActiveSheet.Columns(i).GetPreferredWidth
            Next
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_WIDTHCOLRANGE(ByRef spr As FarPoint.Win.Spread.FpSpread,
             ByVal WidCol As Integer, ByVal Scol As Integer,
            ByVal Ecol As Integer)
        Try
            spr.ActiveSheet.Columns(Scol, Ecol).Width = WidCol
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_DEL(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal col As Integer, ByVal row As Integer)
        Try
            If spr.ActiveSheet.RowCount = 1 Then
                Call SPR_CLEAR(spr) : Exit Sub
            End If

            If spr.ActiveSheet.ActiveRowIndex = spr.ActiveSheet.RowCount - 1 Then
                spr.ActiveSheet.RowCount = spr.ActiveSheet.RowCount - 1
            Else
                spr.ActiveSheet.RemoveRows(row, 1)
                '    spr.ActiveSheet.RowCount = spr.ActiveSheet.RowCount - 1
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_RemoveRow(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal row As Integer, ByVal Cnt As Integer)
        Try
            spr.ActiveSheet.RemoveRows(row, Cnt)
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_END(ByRef spr As FarPoint.Win.Spread.FpSpread)
        Try
            With spr
                .Visible = True
                .Enabled = True
                .Refresh()
                .Focus()
            End With
        Catch ex As Exception

        End Try

    End Sub
    Public Sub SPR_TOPROW(ByRef spr As FarPoint.Win.Spread.FpSpread)
        spr.SetViewportTopRow(0, spr.ActiveSheet.RowCount - 1)
        spr.ActiveSheet.ActiveRowIndex = spr.ActiveSheet.RowCount - 1
    End Sub
    Public Sub SPR_END1(ByRef spr As FarPoint.Win.Spread.FpSpread)
        Try
            spr.ActiveSheet.SetActiveCell(0, 0)
        Catch ex As Exception

        End Try

    End Sub
#End Region


#Region "Spread_Hidden"

    Public Sub SPR_HIDE(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal check As Boolean, ByVal ParamArray column() As Integer)
        Dim i As Integer
        Try
            For i = 0 To UBound(column)
                spr.ActiveSheet.Columns(column(i)).Visible = check
            Next
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_HIDE_AMOUNT(ByRef spr As FarPoint.Win.Spread.FpSpread)
        Dim i As Integer
        Try
            For i = 0 To spr.ActiveSheet.ColumnCount - 1
                If spr.ActiveSheet.Columns(i).Label.ToUpper.Contains("AMOUNT") = True Then spr.ActiveSheet.Columns(i).Visible = False
                If spr.ActiveSheet.Columns(i).Label.ToUpper.Contains("AMT") = True Then spr.ActiveSheet.Columns(i).Visible = False
                If spr.ActiveSheet.Columns(i).Label.ToUpper.Contains("PRICE") = True Then spr.ActiveSheet.Columns(i).Visible = False
                If spr.ActiveSheet.Columns(i).Label.ToUpper.Contains("COST") = True Then spr.ActiveSheet.Columns(i).Visible = False
            Next
        Catch ex As Exception

        End Try

    End Sub



#End Region

#Region "SPR_Col_Row_Count"

    Public Sub SPR_NUMBERCOLUMN(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal DecCol As Integer, ByVal Scol As Integer,
            ByVal Ecol As Integer)

        Dim nc As New FarPoint.Win.Spread.CellType.NumberCellType
        Try
            nc.ShowSeparator = True
            nc.DecimalPlaces = DecCol
            nc.MaximumValue = 999999999999
            nc.MinimumValue = -999999999999
            nc.NegativeRed = True

            spr.ActiveSheet.Columns(Scol, Ecol).CellType = nc
            spr.ActiveSheet.Columns(Scol, Ecol).HorizontalAlignment = CellHorizontalAlignment.Right

        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_NUMBERCOL(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal DecCol As Integer, ByVal Scol As Integer)


        Dim nc As New FarPoint.Win.Spread.CellType.NumberCellType
        Try
            nc.ShowSeparator = True
            nc.DecimalPlaces = DecCol
            nc.MaximumValue = 999999999999
            nc.MinimumValue = -999999999999
            nc.NegativeRed = True

            spr.ActiveSheet.Columns(Scol).CellType = nc
            spr.ActiveSheet.Columns(Scol).HorizontalAlignment = CellHorizontalAlignment.Right

        Catch ex As Exception

        End Try

    End Sub
#End Region

#Region "SPR_CLEAR"

    Public Sub SPR_CLEAR(ByRef spr As FarPoint.Win.Spread.FpSpread, Optional CHK As Boolean = False)
        Try
            If CHK = False Then spr.ActiveSheet.RowCount = 1
            spr.ActiveSheet.ClearRange(0, 0, spr.ActiveSheet.RowCount, spr.ActiveSheet.ColumnCount, True)
            spr.ActiveSheet.Cells(0, 0, spr.ActiveSheet.RowCount - 1, spr.ActiveSheet.ColumnCount - 1).BackColor = Color.Empty
        Catch ex As Exception

        End Try
    End Sub

    Public Sub SPR_CLEAR(ByRef spr As FarPoint.Win.Spread.FpSpread, Row1 As Integer, Col1 As Integer, Row2 As Integer, Col2 As Integer)
        Try
            spr.ActiveSheet.ClearRange(Row1, Col1, 1, Col2, True)
            spr.ActiveSheet.Cells(0, 0, spr.ActiveSheet.RowCount - 1, spr.ActiveSheet.ColumnCount - 1).BackColor = Color.Empty

        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_ROWCLEAR(ByRef spr As FarPoint.Win.Spread.FpSpread, Row1 As Integer)

        Try
            spr.ActiveSheet.ClearRange(Row1, 0, 1, spr.ActiveSheet.ColumnCount, True)
            spr.ActiveSheet.Cells(Row1, 0, Row1, spr.ActiveSheet.ColumnCount - 1).BackColor = Color.Empty
        Catch ex As Exception

        End Try

    End Sub


#End Region


#Region "Spread_BackColor"
    Public Function SPR_SHEETWIDHT(ByRef spr As FarPoint.Win.Spread.FpSpread) As Integer
        Dim i As Integer
        Dim Value As Decimal

        For i = 0 To spr.ActiveSheet.ColumnCount - 1
            If spr.ActiveSheet.Columns(i).Visible = True Then Value += spr.ActiveSheet.Columns(i).Width
        Next

        If spr.ActiveSheet.RowHeaderVisible = True Then
            For i = 0 To spr.ActiveSheet.RowHeader.ColumnCount - 1
                If spr.ActiveSheet.RowHeader.Columns(i).Visible = True Then Value += spr.ActiveSheet.RowHeader.Columns(i).Width
            Next
        End If

        Return Value
    End Function
    Public Sub SPR_BACKCOLORCELL(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal co As Color, ByVal col As Integer, ByVal row As Integer)
        Try
            spr.ActiveSheet.Cells(row, col).BackColor = co
        Catch ex As Exception

        End Try

    End Sub
    Public Sub SPR_BACKCOLOR(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal co As Color, ByVal ParamArray RowNo() As Integer)
        Dim i As Integer
        Try
            For i = 0 To UBound(RowNo)
                spr.ActiveSheet.Rows(RowNo(i)).BackColor = co
                '  spr.ActiveSheet.Rows(RowNo(i)).Font = New Font("Tahoma", 9, FontStyle.Regular, GraphicsUnit.Point)
            Next
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_BackColumn(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal co As Color, ByVal ColumnNo As Integer)
        Try
            spr.ActiveSheet.Columns(ColumnNo).BackColor = co
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_BACKCOLORROWTOTAL(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal co As Color, ByVal RowNo As Integer)
        Try
            spr.ActiveSheet.Rows(RowNo).Font = New Font("Tahoma", 9, (FontStyle.Italic Or FontStyle.Bold), GraphicsUnit.Point)
            spr.ActiveSheet.Rows(RowNo).BackColor = co
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_BACKCOLORRE(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal co As Color, ByVal ParamArray RowNo() As Integer)
        Dim i As Integer
        Try
            For i = 0 To UBound(RowNo)
                spr.ActiveSheet.Rows(RowNo(i)).BackColor = co
            Next
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_BACKCOLOR_SE(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal co As Color, ByVal SCol As Integer, ByVal Ecol As Integer, ByVal Row As Integer)
        Dim i As Integer
        Try
            For i = SCol To Ecol
                spr.ActiveSheet.Cells(Row, i).BackColor = co
            Next
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_LOCK(ByRef spr As FarPoint.Win.Spread.FpSpread)
        Try
            spr.ActiveSheet.Cells(0, 0, spr.ActiveSheet.RowCount - 1, spr.ActiveSheet.ColumnCount - 1).Locked = True
        Catch ex As Exception
        End Try
    End Sub

    Public Sub SPR_UNLOCK(ByRef spr As FarPoint.Win.Spread.FpSpread)
        Try
            spr.ActiveSheet.Cells(0, 0, spr.ActiveSheet.RowCount - 1, spr.ActiveSheet.ColumnCount - 1).Locked = False
        Catch ex As Exception

        End Try

    End Sub


#End Region

#Region "Spread_ForeColor"
    Public Sub SPR_FORECOLORCELL(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal co As Color, ByVal col As Integer, ByVal row As Integer)
        Try
            spr.ActiveSheet.Cells(row, col).ForeColor = co
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_FORECOLORROW(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal co As Color, ByVal row As Integer)
        Try
            spr.ActiveSheet.Rows(row).ForeColor = co
        Catch ex As Exception

        End Try

    End Sub


#End Region

#Region "Spread_Width_High"

    Public Sub vaSpread_HIGH(vS As FpSpread, Row As Integer, HIGH As Decimal)
        Try
            vS.ActiveSheet.Rows(Row).Height = HIGH
        Catch ex As Exception
            Call Error_Message("62", "vaSpread_HIGH")
        End Try
    End Sub

#End Region

#Region "Spread_Lock_Check"
    Public Sub SPR_LOCK(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal ParamArray RowNo() As Integer)
        Dim i As Integer
        Try
            For i = 0 To UBound(RowNo)
                spr.ActiveSheet.Rows(RowNo(i)).Locked = True
            Next
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_ChkLock(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal CheckLock As Boolean, ByVal ParamArray ColumnNo() As Integer)
        Dim i As Integer
        Try
            For i = 0 To UBound(ColumnNo)
                spr.ActiveSheet.Columns(ColumnNo(i)).Locked = CheckLock
            Next
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_CheckAll(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal ColumnNo As Integer)
        Dim i As Integer
        Try
            If getDataM(spr, ColumnNo, 0) = "1" Then
                For i = 0 To spr.ActiveSheet.RowCount - 1
                    setData(spr, ColumnNo, i, "0", , True)
                Next
            Else
                For i = 0 To spr.ActiveSheet.RowCount - 1
                    setData(spr, ColumnNo, i, "1", , True)
                Next
            End If

        Catch ex As Exception

        End Try

    End Sub

    Public Sub SPR_LOCK(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal Col1 As Integer, ByVal Col2 As Integer, ByVal row1 As Integer, ByVal row2 As Integer)
        Try
            spr.ActiveSheet.Cells(row1, Col1, row2, Col2).Locked = True
        Catch ex As Exception

        End Try
    End Sub

    Public Sub SPR_LOCK(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal Col1 As Integer, ByVal Row1 As Integer)
        Try
            spr.ActiveSheet.Cells(Row1, Col1).Locked = True
        Catch ex As Exception

        End Try
    End Sub

    Public Sub SPR_LOCK_FALSE(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal Col1 As Integer, ByVal Row1 As Integer)
        Try
            spr.ActiveSheet.Cells(Row1, Col1).Locked = False
        Catch ex As Exception

        End Try
    End Sub

    Public Sub SPR_LOCK_COL(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal Col1 As Integer)
        Try
            spr.ActiveSheet.Columns(Col1).Locked = False
        Catch ex As Exception

        End Try
    End Sub


#End Region

#Region "Spread_SetText"

    Public Sub setTextConvert_Recursive(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Value() As String, ByVal Col As Integer, ByVal RowS As Integer, ByVal RowN As Integer)
        Try
            setData(fpsA, Col, RowS, Value(getData(fpsA, Col, RowS) - 1))
            If RowS = RowN Then Exit Sub
            setTextConvert(fpsA, Value, Col, RowS + 1, RowN)

        Catch ex As Exception
            ' setTextConvert(fpsA, Value, Col, RowS + 1, RowN)
        End Try
    End Sub

    Public Sub setTextConvert(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Value() As String, ByVal Col As Integer, ByVal RowS As Integer, ByVal RowN As Integer)
        Try
            Dim i As Integer

            For i = RowS To RowN
                If IsNumeric(getData(fpsA, Col, i)) = True Then
                    setData(fpsA, Col, i, Value(getData(fpsA, Col, i) - 1))
                End If
            Next

        Catch ex As Exception
            ' setTextConvert(fpsA, Value, Col, RowS + 1, RowN)
        End Try
    End Sub

    Public Sub setTextConvert(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Result As String, ByVal Value() As String, ByVal Col As Integer, ByVal RowS As Integer)
        Try
            If IsNumeric(Result) = True Then
                setData(fpsA, Col, RowS, Value(CInt(Result) - 1))
            End If
        Catch ex As Exception
            ' setTextConvert(fpsA, Value, Col, RowS + 1, RowN)
        End Try
    End Sub
    Public Function TextConvert(ByVal ConvertString() As String, ByVal Position As Integer) As String
        Try
            Return ConvertString(Position)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


#End Region


    Public Declare Function apiBlockInput Lib "user32" Alias "BlockInput" (ByVal fBlock As Integer) As Integer

#Region "Keycount"

    Private Function key_count_k9912(a As String, b As String, c As String) As String
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        SQL = "SELECT MAX(CAST(K9912_ProgramSeq AS DECIMAL)) AS MAX_CODE FROM PFK9912 "
        SQL = SQL + " WHERE [K9912_ProdjectName] = '" + a + "' "
        SQL = SQL + " AND [K9912_ProgramNo] = '" + b + "' "
        SQL = SQL + " AND [K9912_SheetName] = '" + c + "' "
        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            key_count_k9912 = "000001"
        Else
            key_count_k9912 = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If
        rd.Close()
    End Function

    Private Function key_count() As String
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        SQL = "SELECT MAX(CAST(K9911_ItemCode AS DECIMAL)) AS MAX_CODE FROM PFK9911 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            key_count = "000001"
        Else
            key_count = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If
        rd.Close()
    End Function

#End Region

#Region "GetData"

    Public Function getDataSheetView(ByVal fpsA As SheetView, ByVal Col As Integer, ByVal Row As Integer) As Object
        Try

            Return fpsA.GetValue(Row, Col)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function getData(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer) As Object
        Try

            Return fpsA.ActiveSheet.GetValue(Row, Col)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function getDataActiveSheet(ByVal fpsA As FarPoint.Win.Spread.FpSpread) As Object
        Try

            Return fpsA.ActiveSheet.GetValue(fpsA.ActiveSheet.ActiveRowIndex, fpsA.ActiveSheet.ActiveColumnIndex)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function getDatasheet(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal sheetno As Integer, ByVal Col As Integer, ByVal Row As Integer) As Object
        Try

            Return fpsA.Sheets(sheetno).GetValue(Row, Col)

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function getDataCSV(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer) As Object
        Try

            Return fpsA.ActiveSheet.GetValue(Row, Col).ToString.Replace("'", "")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function getDataBefore(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer) As Object
        Try
            If Col <= 0 Then Return Nothing
            Dim i As Integer
            Dim value As String = ""
            For i = 0 To Col - 1
                value = value + fpsA.ActiveSheet.GetValue(Row, i)
            Next
            Return value
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function getDataCH(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer) As Object
        Try
            Return fpsA.ActiveSheet.ColumnHeader.Cells(Row, Col).Value
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function getDataRH(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer) As Object
        Try
            Return fpsA.ActiveSheet.RowHeader.Cells(Row, Col).Value
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function getDataCHSheetView(ByVal fpsA As SheetView, ByVal Col As Integer, ByVal Row As Integer) As Object
        Try
            Return fpsA.ColumnHeader.Cells(Row, Col).Value
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function getCellCHSheetView(ByVal fpsA As SheetView, ByVal Col As Integer, ByVal Row As Integer) As Object
        Try
            Return fpsA.ColumnHeader.Cells(Row, Col).Tag
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function getDataM(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer) As Object
        Try
            If TypeOf (fpsA.ActiveSheet.Cells(Row, Col).CellType) Is FarPoint.Win.Spread.CellType.CheckBoxCellType Then
                If fpsA.ActiveSheet.GetValue(Row, Col) = True Or fpsA.ActiveSheet.GetValue(Row, Col) = "1" Then
                    Return "1"
                Else
                    Return "2"
                End If
            ElseIf TypeOf (fpsA.ActiveSheet.Columns(Col).CellType) Is FarPoint.Win.Spread.CellType.CheckBoxCellType Then
                If fpsA.ActiveSheet.GetValue(Row, Col) = "1" Or fpsA.ActiveSheet.GetValue(Row, Col) = True Then
                    Return "1"
                Else
                    Return "2"
                End If

            ElseIf TypeOf (fpsA.ActiveSheet.Rows(Row).CellType) Is FarPoint.Win.Spread.CellType.CheckBoxCellType Then
                If fpsA.ActiveSheet.GetValue(Row, Col) = "1" Or fpsA.ActiveSheet.GetValue(Row, Col) = True Then
                    Return "1"
                Else
                    Return "2"
                End If

            Else
                If fpsA.ActiveSheet.Columns(Col).Tag.Contains("DATELABLE") Then
                    Return fpsA.ActiveSheet.GetValue(Row, Col)
                End If

                If fpsA.ActiveSheet.Columns(Col).Tag.Contains("DATE") Or fpsA.ActiveSheet.Columns(Col).Tag.Contains("TIME") Then
                    Return fpsA.ActiveSheet.GetValue(Row, Col).ToString.ToString.Replace(":", "").Replace("/", "").Replace("-", "")
                Else
                    Return fpsA.ActiveSheet.GetValue(Row, Col)
                End If

            End If

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function getColumIndexSheetView(ByVal fpsA As SheetView, ByVal ColName As String) As Integer
        Try
            Return fpsA.Columns(ColName.ToUpper).Index
        Catch ex As Exception
            Return -1
        End Try
    End Function
    Public Function getColumIndex(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal ColName As String) As Integer
        Try
            Return fpsA.ActiveSheet.Columns(ColName.ToUpper).Index
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function getColumName(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal xCol As Integer) As String
        Try
            Return fpsA.ActiveSheet.Columns(xCol).Label
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function getColumnIndex(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal ColName As String) As Integer
        Try
            Return fpsA.ActiveSheet.Columns(ColName.ToUpper).Index
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function getColumnSheetFirstView(ByVal fpsA As FarPoint.Win.Spread.FpSpread) As Integer
        Try
            Dim i As Integer

            For i = 0 To fpsA.ActiveSheet.ColumnCount - 1
                If fpsA.ActiveSheet.Columns(i).Visible = True Then
                    Return i
                End If
            Next

            Return 0
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function getColumLastView(ByVal fpsA As FarPoint.Win.Spread.FpSpread) As Integer
        Try
            Dim i As Integer

            For i = 0 To fpsA.ActiveSheet.ColumnCount - 1
                If fpsA.ActiveSheet.Columns(fpsA.ActiveSheet.ColumnCount - i).Visible = True Then
                    Return fpsA.ActiveSheet.ColumnCount - i
                End If
            Next

            Return 0
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function getRowIndex(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal RowName As String) As Integer
        Try
            Return fpsA.ActiveSheet.Rows(RowName.ToUpper).Index
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function getCell(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer) As Object

        Return fpsA.ActiveSheet.Cells(Row, Col).Tag

    End Function

    Public Function getCellCH(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer) As Object

        Return fpsA.ActiveSheet.ColumnHeader.Cells(Row, Col).Tag

    End Function

    Public Function getCellRH(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer) As Object

        Return fpsA.ActiveSheet.RowHeader.Cells(Row, Col).Tag

    End Function

    Public Sub setDataSheet(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Index As Integer, ByVal Col As Integer, ByVal Row As Integer, ByVal Value As Object, Optional ByVal Style As String = "", Optional ByVal UseCheck As Boolean = False)
        Try

            If UseCheck = False Then

                If IsDBNull(Value) = True Then

                    Value = ""

                End If

                If IsNumeric(Value) And Style <> "" Then

                    Value = Format(CDbl(Value), Style)

                ElseIf CStr(Value) <> "" And Style <> "" Then

                    Value = Format(CStr(Value), Style)

                End If

            Else

                Dim cel As New FarPoint.Win.Spread.CellType.CheckBoxCellType

                cel.Picture.False = My.Resources.riB_NO
                cel.Picture.FalseDisabled = My.Resources.riB_NO
                cel.Picture.FalsePressed = My.Resources.riB_NO
                cel.Picture.True = My.Resources.riB_YES
                cel.Picture.TrueDisabled = My.Resources.riB_YES
                cel.Picture.TruePressed = My.Resources.riB_YES

                fpsA.Sheets(Index).Cells(Row, Col).CellType = cel

                If CDblp(Value) = 0 Or CDblp(Value) = 2 Then Value = False
                If CDblp(Value) = 1 Then Value = True

            End If

            fpsA.Sheets(Index).SetValue(Row, Col, Value)

        Catch ex As Exception

        End Try
    End Sub

    Public Sub setData(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer, ByVal Value As Object, Optional ByVal Style As String = "", Optional ByVal UseCheck As Boolean = False)
        Try

            If UseCheck = False Then

                If IsDBNull(Value) = True Then

                    Value = ""

                End If

                If IsNumeric(Value) And Style <> "" Then

                    Value = Format(CDbl(Value), Style)

                ElseIf CStr(Value) <> "" And Style <> "" Then

                    Value = Format(CStr(Value), Style)

                End If

            Else

                Dim cel As New FarPoint.Win.Spread.CellType.CheckBoxCellType

                cel.Picture.False = My.Resources.riB_NO
                cel.Picture.FalseDisabled = My.Resources.riB_NO
                cel.Picture.FalsePressed = My.Resources.riB_NO
                cel.Picture.True = My.Resources.riB_YES
                cel.Picture.TrueDisabled = My.Resources.riB_YES
                cel.Picture.TruePressed = My.Resources.riB_YES

                fpsA.ActiveSheet.Cells(Row, Col).CellType = cel

                If CDblp(Value) = 0 Or CDblp(Value) = 2 Then Value = False
                If CDblp(Value) = 1 Then Value = True

            End If

            fpsA.ActiveSheet.SetValue(Row, Col, Value)

        Catch ex As Exception

        End Try
    End Sub

    Public Sub setDataSheetView(ByVal fpsA As SheetView, ByVal Col As Integer, ByVal Row As Integer, ByVal Value As Object)
        Try

            fpsA.SetValue(Row, Col, Value)

        Catch ex As Exception

        End Try
    End Sub
    Public Sub setDataPFP(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer, ByVal Value As Object, Optional ByVal Style As String = "", Optional ByVal UseCheck As Boolean = False)
        Try

            If UseCheck = False Then

                If IsDBNull(Value) = True Then

                    Value = ""

                End If

                If IsNumeric(Value) And Style <> "" Then

                    Value = Format(CDbl(Value), Style)

                ElseIf CStr(Value) <> "" And Style <> "" Then

                    Value = Format(CStr(Value), Style)

                End If

            Else

                If CDblp(Value) = 1 Then Value = True Else Value = False

            End If

            fpsA.ActiveSheet.SetValue(Row, Col, Value)

        Catch ex As Exception

        End Try
    End Sub

    Public Sub SetDataBT(ByRef spr As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer, _
               ByVal Colname As String)
        Try
            Dim nc As New FarPoint.Win.Spread.CellType.ButtonCellType
            nc.UseVisualStyleBackColor = False
            nc.ButtonColor = Color.Yellow
            nc.Text = Colname
            spr.ActiveSheet.Cells(Row, Col).CellType = nc
            spr.ActiveSheet.Cells(Row, Col).Value = Colname

        Catch ex As Exception
            MsgBoxP("SetDataBT")
        End Try
    End Sub

    Public Sub setDataProgress(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer, ByVal Value As Object, Optional ByVal Style As String = "", Optional ByVal UseCheck As Boolean = False)
        Try

            If IsDBNull(Value) = True Then

                Value = ""

            End If

            If IsNumeric(Value) And Style <> "" Then

                Value = Format(CDbl(Value), Style)

            ElseIf CStr(Value) <> "" And Style <> "" Then

                Value = Format(CStr(Value), Style)

            End If

            fpsA.ActiveSheet.SetValue(Row, Col, Value)


        Catch ex As Exception
            'truoc mat da
            ' MsgBoxP("setData at " & Col & "-" & Row, vbCritical)
        End Try
    End Sub

    Public Sub setData(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer, ByVal Value As Object, ByVal MauSac As Color, Optional ByVal Style As String = "", Optional ByVal UseCheck As Boolean = False)
        Try

            If UseCheck = False Then

                If IsDBNull(Value) = True Then

                    Value = ""

                End If

                If IsNumeric(Value) And Style <> "" Then

                    Value = Format(CDbl(Value), Style)

                ElseIf CStr(Value) <> "" And Style <> "" Then

                    Value = Format(CStr(Value), Style)

                End If

            Else

                Dim cel As New FarPoint.Win.Spread.CellType.CheckBoxCellType

                cel.Picture.False = My.Resources.riB_NO
                cel.Picture.FalseDisabled = My.Resources.riB_NO
                cel.Picture.FalsePressed = My.Resources.riB_NO
                cel.Picture.True = My.Resources.riB_YES
                cel.Picture.TrueDisabled = My.Resources.riB_YES
                cel.Picture.TruePressed = My.Resources.riB_YES

                fpsA.ActiveSheet.Cells(Row, Col).CellType = cel

                If CDblp(Value) = 0 Or CDblp(Value) = 2 Then Value = False
                If CDblp(Value) = 1 Then Value = True

            End If

            fpsA.ActiveSheet.SetValue(Row, Col, Value)
            fpsA.ActiveSheet.Cells(Row, Col).ForeColor = MauSac
        Catch ex As Exception
            MsgBoxP("setData at " & Col & "-" & Row, vbCritical)
        End Try
    End Sub

    Public Sub setDataCk(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer, ByVal Value As Object, Optional ByVal Style As String = "", Optional ByVal UseCheck As Boolean = False)
        Try

            If UseCheck = False Then

                If IsDBNull(Value) = True Then

                    Value = ""

                End If

                If IsNumeric(Value) And Style <> "" Then

                    Value = Format(CDbl(Value), Style)

                ElseIf CStr(Value) <> "" And Style <> "" Then

                    Value = Format(CStr(Value), Style)

                End If

            Else

                Dim cel As New FarPoint.Win.Spread.CellType.CheckBoxCellType

                cel.Picture.False = My.Resources.riB_NO1
                cel.Picture.FalseDisabled = My.Resources.riB_NO1
                cel.Picture.FalsePressed = My.Resources.riB_NO1
                cel.Picture.True = My.Resources.riB_YES1
                cel.Picture.TrueDisabled = My.Resources.riB_YES1
                cel.Picture.TruePressed = My.Resources.riB_YES1

                fpsA.ActiveSheet.Cells(Row, Col).CellType = cel

                If CDblp(Value) = 0 Or CDblp(Value) = 2 Then Value = False
                If CDblp(Value) = 1 Then Value = True

            End If

            fpsA.ActiveSheet.SetValue(Row, Col, Value)
        Catch ex As Exception
            MsgBoxP("setData at " & Col & "-" & Row, vbCritical)
        End Try
    End Sub

    Public Sub setCell(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer, ByVal Value As Object, Optional ByVal Style As String = "")
        Try

            If IsDBNull(Value) = True Then

                Value = ""

            End If

            If IsNumeric(Value) And Style <> "" Then

                Value = Format(CDbl(Value), Style)

            ElseIf CStr(Value) <> "" And Style <> "" Then

                Value = Format(CStr(Value), Style)

            End If

            fpsA.ActiveSheet.Cells(Row, Col).Tag = Value
        Catch ex As Exception
            MsgBoxP("setData at " & Col & "-" & Row, vbCritical)
        End Try
    End Sub

    Public Sub setCell(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer, ByVal Value As Object)
        Try
            fpsA.ActiveSheet.Cells(Row, Col).Tag = Value
        Catch ex As Exception

        End Try
    End Sub

    ' Minh Duy 2019 01 25
    Public Sub setFocusCell(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal ColName As String, ByVal Value As Object)
        Try
            fpsA.ActiveSheet.ActiveColumnIndex = getColumIndex(fpsA, ColName)
            fpsA.ActiveSheet.ActiveRowIndex = fpsA.DataSource.Rows.IndexOf(fpsA.DataSource.Select(ColName & "='" & Value & "'")(0))
        Catch ex As Exception

        End Try
    End Sub

#End Region


#Region "DataSet"

    Public Function GetDsRc(ByRef dsd As DataSet) As Integer
        Try
            Return dsd.Tables(0).Rows.Count
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function GetDsCc(ByRef dsd As DataSet) As Integer
        Try
            Return dsd.Tables(0).Columns.Count
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function GetDsRow(ByRef dsd As DataSet, row As Integer) As DataRow
        If dsd Is Nothing Then Return Nothing : Exit Function
        Return dsd.Tables(0).Rows(row)

    End Function

    'Public Function GetDsData(ByRef dsd As DataSet, ByVal row As Integer, ByVal name As Object) As String
    '    Try
    '        Dim STR As String = ""
    '        STR = dsd.Tables(0).Rows(row).Item(name)
    '        If STR.Trim = "" Then
    '            STR = Space(1)
    '        End If
    '        Return STR

    '    Catch ex As Exception
    '        Return Nothing
    '    End Try
    'End Function

    Public Function GetDsData(ByRef dsd As DataSet, ByVal row As Integer, ByVal name As String) As Object
        Try
            Dim STR As Object
            STR = dsd.Tables(0).Rows(row).Item(name)
          
            Return STR

        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function GetDsData(ByRef dsd As DataSet, ByVal row As Integer, ByVal col As Integer) As String
        Try
            Dim STR As String = ""
            STR = dsd.Tables(0).Rows(row).Item(col)
            If STR.Trim = "" Then
                STR = Space(1)
            End If
            Return STR

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetDsDataToCk(ByRef dsd As DataSet, ByVal row As Integer, ByVal name As Object) As String
        Try
            Dim STR As String = ""
            STR = dsd.Tables(0).Rows(row).Item(name)
            If STR.Trim = "" Then
                STR = 0
            End If
            Return STR

        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function GetColumname(ByRef dsd As DataSet, ByVal column As Integer) As String

        Dim STR As String = ""

        Try
            STR = dsd.Tables(0).Columns(column).ColumnName
            If STR.Trim = "" Then
                STR = Space(1)
            End If

        Catch ex As Exception
            STR = ""
        End Try

        Return STR

    End Function

    

    Public Sub setDataCH(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer, ByVal Value1 As Object)
        Try
            If IsDBNull(Value1) = True Then
                Value1 = ""
            End If
            fpsA.ActiveSheet.ColumnHeader.Cells(Row, Col).Value = Value1
        Catch ex As Exception

        End Try

    End Sub

    Public Sub setCellCH(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer, ByVal Value1 As Object)

        Try
            If IsDBNull(Value1) = True Then
                Value1 = ""
            End If
            fpsA.ActiveSheet.ColumnHeader.Cells(Row, Col).Tag = Value1

        Catch ex As Exception

        End Try

    End Sub

    Public Sub setDataRH(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer, ByVal Value1 As Object)
        Try
            If IsDBNull(Value1) = True Then

                Value1 = ""

            End If

            fpsA.ActiveSheet.RowHeader.Cells(Row, Col).Value = Value1
        Catch ex As Exception
            Error_Message("62", "setDataRH")
        End Try

    End Sub

    Public Sub setCellRH(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer, ByVal Value1 As Object)
        Try
            If IsDBNull(Value1) = True Then

                Value1 = ""

            End If

            fpsA.ActiveSheet.RowHeader.Cells(Row, Col).Tag = Value1
        Catch ex As Exception
            Error_Message("62", "setCellRH")
        End Try

    End Sub

    Public Sub setDataChk(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer, ByVal Value As Object)
        Try
            If CIntp(Value) = 1 Then
                Value = True
            Else
                Value = False
            End If
            fpsA.ActiveSheet.SetValue(Row, Col, Value)
        Catch ex As Exception
            fpsA.ActiveSheet.SetValue(Row, Col, Nothing)
        End Try
    End Sub

    Public Sub setDataChkCol(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Value As Object)
        Dim i As Integer
        Try
            If CIntp(Value) = 1 Then
                Value = True
            Else
                Value = False
            End If
            For i = 0 To fpsA.ActiveSheet.RowCount - 1
                fpsA.ActiveSheet.SetValue(i, Col, Value)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Public Sub setDataCB(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Col As Integer, ByVal Row As Integer, ByVal Value As Object)
        Try
            If fpsA.ActiveSheet.Columns(Col).Tag = "DIRECTIONYARN" Then
                If CInt(Value) = 1 Then
                    Value = "WARP YARN"
                ElseIf CInt(Value) = 2 Then
                    Value = "WEFT YARN"
                End If
            ElseIf fpsA.ActiveSheet.Columns(Col).Tag.ToString.Contains("PART") = True Then
                If CInt(Value) = 1 Then
                    Value = "A"
                ElseIf CInt(Value) = 2 Then
                    Value = "B"
                ElseIf CInt(Value) = 3 Then
                    Value = "C"
                End If
            ElseIf fpsA.ActiveSheet.Columns(Col).Tag = "CHECKSIDETYPE" Then
                If CInt(Value) = 1 Then
                    Value = "INSIDE"
                Else
                    Value = "OUTSIDE"
                End If
            ElseIf fpsA.ActiveSheet.Columns(Col).Tag.ToString.Contains("BCHK") = True Then
                If CInt(Value) = 1 Then
                    Value = "X"
                ElseIf CInt(Value) = 2 Or CInt(Value) = 3 Then
                    Value = "O"

                End If
            End If

            fpsA.ActiveSheet.SetValue(Row, Col, Value)
        Catch ex As Exception
            fpsA.ActiveSheet.SetValue(Row, Col, Nothing)
        End Try

    End Sub

    Public Sub setTotalData(ByVal fpsA As FarPoint.Win.Spread.FpSpread, ByVal Row As Integer, ByVal Col As Integer, ByVal RowS As Integer, ByVal RowN As Integer)

        Try
            fpsA.ActiveSheet.Cells(Row, Col).Value += getData(fpsA, Col, RowS)
            If RowS = RowN Then Exit Sub
            setTotalData(fpsA, Row, Col, RowS + 1, RowN)
        Catch ex As Exception
            MsgBoxP("setTotalData!")
        End Try

    End Sub


#End Region

    'Nam 20180628
    Public Sub SPR_MERGEALWAYS_COLUMN(ByVal ColumnNo As Integer, ByRef spr As FarPoint.Win.Spread.FpSpread)
        Dim i As Integer
        Try
            spr.ActiveSheet.Columns(ColumnNo).VerticalAlignment = CellVerticalAlignment.Top
            spr.ActiveSheet.Columns(ColumnNo).MergePolicy = Model.MergePolicy.Always
        Catch ex As Exception

        End Try

    End Sub

End Module

