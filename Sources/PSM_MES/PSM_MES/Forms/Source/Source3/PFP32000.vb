Public Class PFP32000

    '#Region "Variable"

    '    Private W3801 As T3801_AREA
    '    Private L3801 As T3801_AREA
    '    Private W3810 As T3810_AREA
    '    Private L3810 As T3810_AREA

    '    Private W3202 As T3202_AREA

    '    Private chk_Initial As Boolean = False
    '    Private Enum colVs1
    '        QtyPlan = 0
    '        QtyPlanBL = 1
    '    End Enum

    '    Private ColorUse As Color
    '    Private Color1 As Color
    '    Private Color2 As Color
    '    Private Color3 As Color
    '    Private Color4 As Color
    '    Private Color5 As Color

    '    Private cdDefaultProcess As String

    '#End Region

    '#Region "Form_load"
    '    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
    '        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)
    '        Try

    '            Call FORM_INIT()
    '            Call DATA_SEARCH_vS_Hidden()
    '            Call DATA_INIT()
    '        Catch ex As Exception
    '            Call MsgBoxP_Error("Form_load", ex.Message)
    '        End Try
    '    End Sub

    '    Public Sub FORM_INIT()
    '        Try
    '            Call DATA_SEARCH_vsProcess()
    '            Call DATA_SEARCH_vS_Order()

    '            chk_FSEL.Checked = True
    '            chk_Format.Checked = True

    '            chk_DetailPlan.Checked = True
    '            chk_Suggestion.Checked = False

    '        Catch ex As Exception
    '            Call MsgBoxP_Error("FORM_INIT", ex.Message)
    '        End Try
    '    End Sub

    '    Public Sub DATA_INIT()
    '        Try

    '            txt_DatePlan.Data = System_Date_8()
    '            txt_DateStart.Data = System_Date_8()
    '            txt_DateFinish.Data = System_Date_Add(0, 100)

    '            Color1 = cmd_color1.BackColor
    '            Color2 = cmd_color2.BackColor
    '            Color3 = cmd_color3.BackColor
    '            Color4 = cmd_color4.BackColor
    '            Color5 = cmd_color5.BackColor

    '        Catch ex As Exception
    '            Call MsgBoxP_Error("DATA_INIT", ex.Message)
    '        End Try
    '    End Sub

    '#End Region

    '#Region "Function"

    '    Public Sub MAIN_JOB01()


    '    End Sub

    '    Public Sub MAIN_JOB02()

    '    End Sub

    '    Public Sub MAIN_JOB03()

    '    End Sub

    '    Public Sub MAIN_JOB04()

    '    End Sub

    '    Public Sub MAIN_JOB06()


    '    End Sub

    '    Public Sub MAIN_JOB07()

    '    End Sub

    '    Public Sub MAIN_JOB08()

    '    End Sub
    '    Public Sub MAIN_JOB09()

    '    End Sub
    '    Public Sub MAIN_JOB010()

    '    End Sub
    '    Public Sub MAIN_JOB013()

    '    End Sub

    '    Public Sub MAIN_JOB011()

    '    End Sub
    '    Public Sub MAIN_JOB012()

    '    End Sub

    '#End Region

    '#Region "Data_search"
    '    Private Sub cmd_Loading_Click(sender As Object, e As EventArgs) Handles cmd_Loading.Click
    '        Try

    '            Call ChooseDateRange()
    '            Call ChooseProcessRange()

    '        Catch ex As Exception

    '        End Try
    '    End Sub

    '    Private int_ColumnMax As Integer

    '    Private int_FirstColumn As Integer
    '    Private int_LastColumn As Integer

    '    Private Function ChooseDateRange() As Boolean
    '        ChooseDateRange = False
    '        Try
    '            Dim i As Integer
    '            int_FirstColumn = -1
    '            int_LastColumn = -1

    '            For i = int_ColumnMax To int_ColumnMax + 99
    '                If CIntp(getCellCH(Vs10, i, 0)) >= CIntp(txt_DateStart.Data) And CIntp(getCellCH(Vs10, i, 0)) <= CIntp(txt_DateFinish.Data) Then
    '                    Vs10.ActiveSheet.Columns(i).Visible = True

    '                    If int_FirstColumn = -1 Then int_FirstColumn = i
    '                    If int_FirstColumn <> -1 Then int_LastColumn = i

    '                Else
    '                    Vs10.ActiveSheet.Columns(i).Visible = False
    '                End If
    '            Next
    '            ChooseDateRange = True
    '        Catch ex As Exception

    '        End Try
    '    End Function
    '    Private Function ChooseProcessRange() As Boolean
    '        ChooseProcessRange = False
    '        Dim Lis_SubProcess As New List(Of String)
    '        Dim int_fixCol As Integer
    '        Dim i, j As Integer

    '        Try

    '            For i = 0 To vS_Process.ActiveSheet.RowCount - 1
    '                If getDataM(vS_Process, getColumIndex(vS_Process, "DCHK"), i) = "1" Then
    '                    Lis_SubProcess.Add(getData(vS_Process, getColumIndex(vS_Process, "cdSubProcess"), i))
    '                End If

    '            Next

    '            int_fixCol = getColumIndex(Vs10, "cdSubProcess")
    '            Vs10.ActiveSheet.AutoCalculation = True

    '            For i = 0 To Vs10.ActiveSheet.RowCount - 1
    '                If Lis_SubProcess.Contains(getData(Vs10, int_fixCol, i)) Then
    '                    Vs10.ActiveSheet.Rows(i).Visible = True

    '                    If chk_Filer.Checked = True Then
    '                        For j = int_FirstColumn To int_LastColumn

    '                            If getData(Vs10, j, i) <> "" Then
    '                                GoTo next1
    '                            End If
    '                        Next

    '                        Vs10.ActiveSheet.Rows(i).Visible = False
    'next1:

    '                    End If

    '                Else
    '                    Vs10.ActiveSheet.Rows(i).Visible = False
    '                End If
    '            Next

    '            ChooseProcessRange = True
    '        Catch ex As Exception

    '        End Try
    '    End Function

    '    Private Function DATA_SEARCH_vsProcess() As Boolean
    '        DATA_SEARCH_vsProcess = False
    '        vS_Process.Enabled = False

    '        Try

    '            DS1 = PrcDS("USP_PFP32000_SEARCH_vS_Process", cn)

    '            Return SPR_PRO_NEW(vS_Process, DS1, "USP_PFP32000_SEARCH_vS_Process", "vS_Process")

    '        Catch ex As Exception
    '            Call MsgBoxP_Error("DATA_SEARCH_vs10", ex.Message)
    '        Finally
    '            vS_Process.Enabled = True
    '        End Try
    '    End Function

    '    Private Function DATA_SEARCH_vS_Order() As Boolean
    '        DATA_SEARCH_vS_Order = False
    '        vS_Order.Enabled = False

    '        Try

    '            DS1 = PrcDS("USP_PFP32000_SEARCH_vS_Order", cn, cdDefaultProcess)
    '            vS_Order.HorizontalScrollBarPolicy = ScrollBarPolicy.Never

    '            Return SPR_PRO_NEW(vS_Order, DS1, "USP_PFP32000_SEARCH_vS_Order", "vS_Order")

    '        Catch ex As Exception
    '            Call MsgBoxP_Error("DATA_SEARCH_vs10", ex.Message)
    '        Finally
    '            vS_Order.Enabled = True
    '        End Try
    '    End Function

    '    Private Function DATA_SEARCH_vS_Suggestion() As Boolean
    '        DATA_SEARCH_vS_Suggestion = False
    '        vS_Suggestion.Enabled = False

    '        Try

    '            DS1 = PrcDS("USP_PFP32000_SEARCH_vS_Suggestion", cn, cdDefaultProcess)

    '            Return SPR_PRO_NEW(vS_Suggestion, DS1, "USP_PFP32000_SEARCH_vS_Suggestion", "vS_Suggestion")

    '        Catch ex As Exception
    '            Call MsgBoxP_Error("DATA_SEARCH_vs10", ex.Message)
    '        Finally
    '            vS_Suggestion.Enabled = True
    '        End Try
    '    End Function


    '    Private Function DATA_SEARCH_vS_Suggestion_LINE() As Boolean
    '        DATA_SEARCH_vS_Suggestion_LINE = False
    '        vS_Suggestion.Enabled = False

    '        Dim MaterialCode As String
    '        MaterialCode = getData(vS_Suggestion, getColumIndex(vS_Suggestion, "KEY_MaterialCode"), vS_Suggestion.ActiveSheet.ActiveRowIndex)

    '        Try

    '            DS1 = PrcDS("USP_PFP32000_SEARCH_vS_Suggestion_LINE", cn, cdDefaultProcess, MaterialCode)

    '            READ_SPREAD(vS_Suggestion, DS1, "USP_PFP32000_SEARCH_vS_Suggestion", "vS_Suggestion", vS_Suggestion.ActiveSheet.ActiveRowIndex)

    '        Catch ex As Exception
    '            Call MsgBoxP_Error("DATA_SEARCH_vs10", ex.Message)
    '        Finally
    '            vS_Suggestion.Enabled = True
    '        End Try
    '    End Function

    '    Private Function DATA_SEARCH_vS_Suggestion_Order() As Boolean
    '        DATA_SEARCH_vS_Suggestion_Order = False
    '        vS_Suggestion.Enabled = False

    '        Try

    '            DS1 = PrcDS("USP_PFP32000_SEARCH_vS_Suggestion_Order", cn, cdDefaultProcess)

    '            Return SPR_PRO_NEW(vS_Suggestion, DS1, "USP_PFP32000_SEARCH_vS_Suggestion_Order", "vS_Suggestion_Order")

    '        Catch ex As Exception
    '            Call MsgBoxP_Error("DATA_SEARCH_vs10", ex.Message)
    '        Finally
    '            vS_Suggestion.Enabled = True
    '        End Try
    '    End Function


    '    Private Function DATA_SEARCH_vS_Suggestion_Order_LINE() As Boolean
    '        DATA_SEARCH_vS_Suggestion_Order_LINE = False
    '        vS_Suggestion.Enabled = False

    '        Dim KEY_AutoKey As String
    '        KEY_AutoKey = getData(vS_Suggestion, getColumIndex(vS_Suggestion, "KEY_AutoKey"), vS_Suggestion.ActiveSheet.ActiveRowIndex)

    '        Dim KEY_MaterialCode As String
    '        KEY_MaterialCode = getData(Vs10, getColumIndex(Vs10, "KEY_MaterialCode"), Vs10.ActiveSheet.ActiveRowIndex)

    '        Try

    '            DS1 = PrcDS("USP_PFP32000_SEARCH_vS_Suggestion_Order_LINE", cn, KEY_MaterialCode, KEY_AutoKey, cdDefaultProcess)

    '            READ_SPREAD(vS_Suggestion, DS1, "USP_PFP32000_SEARCH_vS_Suggestion_Order", "vS_Suggestion_Order", vS_Suggestion.ActiveSheet.ActiveRowIndex)

    '        Catch ex As Exception
    '            Call MsgBoxP_Error("DATA_SEARCH_vs10", ex.Message)
    '        Finally
    '            vS_Suggestion.Enabled = True
    '        End Try
    '    End Function


    '    Private Function DATA_SEARCH_vS_Hidden() As Boolean
    '        DATA_SEARCH_vS_Hidden = False
    '        vS_Hidden.Enabled = False

    '        Try
    '            DS1 = PrcDS("USP_PFP32000_SEARCH_vS_Hidden", cn)

    '            Call SPR_PRO_NEW(vS_Hidden, DS1, "USP_PFP32000_SEARCH_vS_Hidden", "vS_Hidden")
    '            vS_Hidden.ActiveSheet.RowCount = 0

    '        Catch ex As Exception
    '            Call MsgBoxP_Error("DATA_SEARCH_vs10", ex.Message)
    '        Finally
    '            vS_Hidden.Enabled = True
    '        End Try
    '    End Function

    '    Private Function DATA_SEARCH_vS_Hidden_Applied() As Boolean
    '        DATA_SEARCH_vS_Hidden_Applied = False
    '        Dim int_ToCol As Integer

    '        int_ToCol = getColumIndex(Vs10, "QtyPlanBL")

    '        Try


    '            For i As Integer = 0 To int_ToCol

    '                If Vs10.ActiveSheet.Columns(i).Visible = True Then
    '                    vS_Hidden.ActiveSheet.RowCount += 1

    '                    setData(vS_Hidden, 0, vS_Hidden.ActiveSheet.RowCount - 1, Vs10.ActiveSheet.Columns(i).Visible, , True)
    '                    setData(vS_Hidden, 1, vS_Hidden.ActiveSheet.RowCount - 1, Vs10.ActiveSheet.Columns(i).Tag)
    '                    setData(vS_Hidden, 2, vS_Hidden.ActiveSheet.RowCount - 1, Vs10.ActiveSheet.Columns(i).Label)
    '                End If

    '            Next


    '            DATA_SEARCH_vS_Hidden_Applied = True

    '        Catch ex As Exception
    '            Call MsgBoxP_Error("DATA_SEARCH_vS_Hidden_Applied", ex.Message)
    '        Finally
    '            vS_Hidden.Enabled = True
    '        End Try
    '    End Function

    '    Private Function DATA_SEARCH_vS11() As Boolean
    '        DATA_SEARCH_vS11 = False
    '        vS11.Enabled = False

    '        Dim str_Autokey As String
    '        Dim str_cdSubProcess As String

    '        str_Autokey = getData(Vs10, getColumIndex(Vs10, "Key_Autokey"), Vs10.ActiveSheet.ActiveRowIndex)
    '        str_cdSubProcess = getData(Vs10, getColumIndex(Vs10, "KEY_cdSubProcess"), Vs10.ActiveSheet.ActiveRowIndex)

    '        Try

    '            DS1 = PrcDS("USP_PFP32000_SEARCH_vS11", cn, str_Autokey, str_cdSubProcess)
    '            Return SPR_PRO_NEW(vS11, DS1, "USP_PFP32000_SEARCH_vS11", "vS11")

    '        Catch ex As Exception
    '            Call MsgBoxP_Error("DATA_SEARCH_vs10", ex.Message)
    '        Finally
    '            vS11.Enabled = True
    '        End Try
    '    End Function

    '    Private Function DATA_SEARCH_vS11_MACHINE() As Boolean
    '        DATA_SEARCH_vS11_MACHINE = False
    '        vS11.Enabled = False

    '        Dim str_MaterialCode As String
    '        Dim str_cdSubProcess As String

    '        str_MaterialCode = getData(Vs10, getColumIndex(Vs10, "Key_MaterialCode"), Vs10.ActiveSheet.ActiveRowIndex)
    '        str_cdSubProcess = getData(Vs10, getColumIndex(Vs10, "KEY_cdSubProcess"), Vs10.ActiveSheet.ActiveRowIndex)

    '        Try
    '            DS1 = PrcDS("USP_PFP32000_SEARCH_vS11_MACHINE", cn, str_MaterialCode, str_cdSubProcess)
    '            Return SPR_PRO_NEW(vS11, DS1, "USP_PFP32000_SEARCH_vS11_MACHINE", "vS11_Machine")

    '        Catch ex As Exception
    '            Call MsgBoxP_Error("DATA_SEARCH_vs10", ex.Message)
    '        Finally
    '            vS11.Enabled = True
    '        End Try

    '    End Function


    '    Private Function DATA_SEARCH_vS12() As Boolean
    '        DATA_SEARCH_vS12 = False
    '        vS12.Enabled = False

    '        Dim str_Autokey As String
    '        str_Autokey = getData(vS11, getColumIndex(vS11, "Key_Autokey"), vS11.ActiveSheet.ActiveRowIndex)

    '        Try

    '            DS1 = PrcDS("USP_PFP32500_SEARCH_vS12", cn, str_Autokey)

    '            Return SPR_PRO_NEW(vS12, DS1, "USP_PFP32500_SEARCH_vS12", "vS12")

    '        Catch ex As Exception
    '            Call MsgBoxP_Error("DATA_SEARCH_vs10", ex.Message)
    '        Finally
    '            vS12.Enabled = True
    '        End Try
    '    End Function

    '    Private Sub DemoData()
    '        Vs10.Enabled = False

    '        Try

    '            DS1 = PrcDS("USP_PFP32000_SEARCH_VS10", cn, txt_DatePlan.Data,
    '                                                        txt_DatePlan.Data,
    '                                                        txt_CustomerDyeingCode.Data,
    '                                                        "*" & txt_ProductName.Data,
    '                                                        "*" & txt_PONO.Data)

    '            Call SPR_PRO_NEW(Vs10, DS1, "USP_PFP32000_SEARCH_VS10", "vs10")

    '            Dim i As Integer

    '            Dim int_Random As Integer


    '            Dim int_ColFix As Integer
    '            Dim int_RandomRange As Integer
    '            int_ColumnMax = Vs10.ActiveSheet.ColumnCount
    '            Dim int_DateIncrement As Integer = -1
    '            Vs10.ActiveSheet.ColumnCount = Vs10.ActiveSheet.ColumnCount + 100



    '            For i = int_ColumnMax To int_ColumnMax + 99
    '                int_DateIncrement += 1
    '                setDataCH(Vs10, i, 0, Strings.Right(FSDate(System_Date_Add(0, int_DateIncrement)), 5))
    '                setCellCH(Vs10, i, 0, System_Date_Add(0, int_DateIncrement))

    '                setDataCH(Vs10, i, 1, Strings.Left(CDate(FSDate(System_Date_Add(0, int_DateIncrement))).DayOfWeek.ToString, 3).ToUpper)

    '                If CDate(FSDate(System_Date_Add(0, int_DateIncrement))).DayOfWeek = DayOfWeek.Sunday Then
    '                    Vs10.ActiveSheet.ColumnHeader.Cells(1, i).BackColor = Color.PaleVioletRed
    '                End If

    '                SPR_NUMBERCOL(Vs10, 0, i)
    '                Vs10.ActiveSheet.Columns(i).Width = 45
    '            Next

    '            int_ColFix = getColumIndex(Vs10, "cdSubProcess")

    '            Dim Ran1 As Integer
    '            Dim Ran2 As Integer
    '            Dim Ran3 As Integer
    '            Dim Ran4 As Integer
    '            Dim int_rowIn As Integer

    '            ColorUse = Color5

    '            For i = 0 To Vs10.ActiveSheet.RowCount - 1 Step 5

    '                If ColorUse = Color1 Then
    '                    ColorUse = Color2
    '                ElseIf ColorUse = Color2 Then
    '                    ColorUse = Color3
    '                ElseIf ColorUse = Color3 Then
    '                    ColorUse = Color4
    '                ElseIf ColorUse = Color4 Then
    '                    ColorUse = Color5
    '                ElseIf ColorUse = Color5 Then
    '                    ColorUse = Color1
    '                End If

    '                int_rowIn = i
    '                int_Random = GetRandom(int_ColumnMax, int_ColumnMax + 10)
    '                int_RandomRange = GetRandom(1, 10)
    '                Ran1 = int_Random + int_RandomRange

    '                SPR_TEXTBOX_S(Vs10, int_Random, int_rowIn)
    '                Vs10.ActiveSheet.Cells(int_rowIn, int_Random).HorizontalAlignment = CellHorizontalAlignment.Left
    '                SPR_BACKCOLORCELLRANGE(Vs10, ColorUse, int_Random, int_rowIn, int_Random + int_RandomRange, int_rowIn)

    '                Vs10.ActiveSheet.Cells(int_rowIn, int_Random).ColumnSpan = int_RandomRange + 1
    '                Vs10.ActiveSheet.Cells(int_rowIn, int_Random).Value = getData(Vs10, getColumIndex(Vs10, "ItemName"), int_rowIn) + "-" + "Plan []"


    '                int_Random = GetRandom(Ran1, Ran1 + 10)
    '                int_RandomRange = GetRandom(1, 10)
    '                Ran2 = int_Random + int_RandomRange
    '                int_rowIn += 1
    '                SPR_TEXTBOX_S(Vs10, int_Random, int_rowIn)
    '                Vs10.ActiveSheet.Cells(int_rowIn, int_Random).HorizontalAlignment = CellHorizontalAlignment.Left
    '                SPR_BACKCOLORCELLRANGE(Vs10, ColorUse, int_Random, int_rowIn, int_Random + int_RandomRange, int_rowIn)

    '                Vs10.ActiveSheet.Cells(int_rowIn, int_Random).ColumnSpan = int_RandomRange + 1
    '                Vs10.ActiveSheet.Cells(int_rowIn, int_Random).Value = getData(Vs10, getColumIndex(Vs10, "ItemName"), int_rowIn) + "-" + "Plan []"

    '                int_Random = GetRandom(Ran2, Ran2 + 10)
    '                int_RandomRange = GetRandom(1, 10)
    '                Ran3 = int_Random + int_RandomRange
    '                int_rowIn += 1
    '                SPR_TEXTBOX_S(Vs10, int_Random, int_rowIn)
    '                Vs10.ActiveSheet.Cells(int_rowIn, int_Random).HorizontalAlignment = CellHorizontalAlignment.Left
    '                SPR_BACKCOLORCELLRANGE(Vs10, ColorUse, int_Random, int_rowIn, int_Random + int_RandomRange, int_rowIn)

    '                Vs10.ActiveSheet.Cells(int_rowIn, int_Random).ColumnSpan = int_RandomRange + 1
    '                Vs10.ActiveSheet.Cells(int_rowIn, int_Random).Value = getData(Vs10, getColumIndex(Vs10, "ItemName"), int_rowIn) + "-" + "Plan []"

    '                int_Random = GetRandom(Ran3, Ran3 + 10)
    '                int_RandomRange = GetRandom(1, 10)
    '                Ran4 = int_Random + int_RandomRange
    '                int_rowIn += 1
    '                SPR_TEXTBOX_S(Vs10, int_Random, int_rowIn)
    '                Vs10.ActiveSheet.Cells(int_rowIn, int_Random).HorizontalAlignment = CellHorizontalAlignment.Left
    '                SPR_BACKCOLORCELLRANGE(Vs10, ColorUse, int_Random, int_rowIn, int_Random + int_RandomRange, int_rowIn)

    '                Vs10.ActiveSheet.Cells(int_rowIn, int_Random).ColumnSpan = int_RandomRange + 1
    '                Vs10.ActiveSheet.Cells(int_rowIn, int_Random).Value = getData(Vs10, getColumIndex(Vs10, "ItemName"), int_rowIn) + "-" + "Plan []"


    '                int_Random = GetRandom(Ran4, Ran4 + 10)
    '                int_RandomRange = GetRandom(1, 10)
    '                int_rowIn += 1
    '                SPR_TEXTBOX_S(Vs10, int_Random, int_rowIn)
    '                Vs10.ActiveSheet.Cells(int_rowIn, int_Random).HorizontalAlignment = CellHorizontalAlignment.Left
    '                SPR_BACKCOLORCELLRANGE(Vs10, ColorUse, int_Random, int_rowIn, int_Random + int_RandomRange, int_rowIn)

    '                Vs10.ActiveSheet.Cells(int_rowIn, int_Random).ColumnSpan = int_RandomRange + 1
    '                Vs10.ActiveSheet.Cells(int_rowIn, int_Random).Value = getData(Vs10, getColumIndex(Vs10, "ItemName"), int_rowIn) + "-" + "Plan []"

    '            Next

    '            Call ChooseDateRange()
    '            Call ChooseProcessRange()

    '        Catch ex As Exception
    '            Call MsgBoxP_Error("DATA_SEARCH_vs10", ex.Message)
    '        Finally
    '            Vs10.Enabled = True
    '        End Try
    '    End Sub
    '    Private Function DATA_SEARCH_vs10() As Boolean
    '        DATA_SEARCH_vs10 = False
    '        Vs10.Enabled = False
    '        Dim cdSubProcess As String
    '        Dim i As Integer

    '        Call DATA_SEARCH_vS_Order()

    '        Try

    '            If rad_MachineWorking.Checked = False Then

    '                For i = 0 To vS_Process.ActiveSheet.RowCount - 1
    '                    If getDataM(vS_Process, getColumIndex(vS_Process, "dchk"), i) = "1" Then
    '                        cdSubProcess = getData(vS_Process, getColumIndex(vS_Process, "cdSubProcess"), i)
    '                        cdDefaultProcess = cdSubProcess

    '                        Exit For
    '                    End If

    '                Next

    '                ' 2019/07/05 nêu sau này có ko tìm theo process thì chỉ cần bỏ điều kiện thôi, làm cho nhanh

    '                DS1 = PrcDS("USP_PFP32000_SEARCH_VS10", cn, txt_DatePlan.Data,
    '                                                            txt_DatePlan.Data,
    '                                                            txt_CustomerDyeingCode.Data,
    '                                                            "*" & txt_ProductName.Data,
    '                                                            "*" & txt_PONO.Data,
    '                                                            cdDefaultProcess)

    '                Call SPR_PRO_NEW(Vs10, DS1, "USP_PFP32000_SEARCH_VS10", "vs10")

    '                Vs10.AllowDragDrop = True
    '                Vs10.AllowDragFill = False



    '            Else

    '                For i = 0 To vS_Process.ActiveSheet.RowCount - 1
    '                    If getDataM(vS_Process, getColumIndex(vS_Process, "dchk"), i) = "1" Then
    '                        cdSubProcess = getData(vS_Process, getColumIndex(vS_Process, "cdSubProcess"), i)
    '                        cdDefaultProcess = cdSubProcess

    '                        Exit For
    '                    End If

    '                Next

    '                DS1 = PrcDS("USP_PFP32000_SEARCH_VS20", cn, txt_DatePlan.Data,
    '                                                           txt_DatePlan.Data,
    '                                                           txt_CustomerDyeingCode.Data,
    '                                                          cdSubProcess,
    '                                                           "*" & txt_PONO.Data)

    '                Call SPR_PRO_NEW(Vs10, DS1, "USP_PFP32000_SEARCH_VS20", "vs10")

    '            End If

    '            If chk_Initial = False Then
    '                Call DATA_SEARCH_vS_Hidden_Applied()
    '                chk_Initial = True
    '            End If

    '            If chk_Suggestion.Checked And rad_OrderWorking.Checked Then Call DATA_SEARCH_vS_Suggestion()
    '            If chk_Suggestion.Checked And rad_MachineWorking.Checked Then Call DATA_SEARCH_vS_Suggestion_Order()

    '            Dim int_Random As Integer

    '            Dim ColorUse As Color
    '            Dim Color1 As Color = cmd_color1.BackColor
    '            Dim Color2 As Color = cmd_color2.BackColor
    '            Dim Color3 As Color = cmd_color3.BackColor
    '            Dim Color4 As Color = cmd_color4.BackColor
    '            Dim Color5 As Color = cmd_color5.BackColor

    '            Dim int_ColFix As Integer
    '            Dim int_RandomRange As Integer
    '            int_ColumnMax = Vs10.ActiveSheet.ColumnCount
    '            Dim int_DateIncrement As Integer = -1
    '            Vs10.ActiveSheet.ColumnCount = Vs10.ActiveSheet.ColumnCount + 100

    '            Dim DateSystem As String = FSDate(txt_DatePlan.Data)



    '            For i = int_ColumnMax To int_ColumnMax + 99
    '                int_DateIncrement += 1
    '                setDataCH(Vs10, i, 0, Strings.Right(FSDate(Function_Date_Add(DateSystem, 0, int_DateIncrement)), 5))
    '                setCellCH(Vs10, i, 0, Function_Date_Add(DateSystem, 0, int_DateIncrement))

    '                Vs10.ActiveSheet.ColumnHeader.Columns(i).Tag = Function_Date_Add(DateSystem, 0, int_DateIncrement)

    '                setDataCH(Vs10, i, 1, Strings.Left(CDate(FSDate(Function_Date_Add(DateSystem, 0, int_DateIncrement))).DayOfWeek.ToString, 3).ToUpper)

    '                If CDate(FSDate(Function_Date_Add(DateSystem, 0, int_DateIncrement))).DayOfWeek = DayOfWeek.Sunday Then
    '                    Vs10.ActiveSheet.ColumnHeader.Cells(1, i).BackColor = Color.PaleVioletRed
    '                End If

    '                SPR_NUMBERCOL(Vs10, 0, i)
    '                Vs10.ActiveSheet.Columns(i).Width = 45

    '                'Vs10.ActiveSheet.Columns(i).Locked = False

    '            Next

    '            If rad_MachineWorking.Checked = False Then
    '                int_ColFix = getColumIndex(Vs10, "cdSubProcess")

    '                Dim Ran1 As Integer = 0
    '                Dim Ran2 As Integer = 0
    '                Dim Ran3 As Integer = 0
    '                Dim Ran4 As Integer = 0
    '                Dim int_rowIn As Integer

    '                ColorUse = Color5

    '                Dim str_Autokey As String

    '                Dim int_ColFix1 As Integer = getColumIndex(Vs10, "KEY_AUTOKEY")
    '                Dim int_ColFix2 As Integer = getColumIndex(Vs10, "key_cdSubProcess")
    '                Dim int_ProcessCnt As Integer = vS_Process.ActiveSheet.RowCount

    '                For i = 0 To Vs10.ActiveSheet.RowCount - 1 Step int_ProcessCnt
    '                    str_Autokey = getData(Vs10, int_ColFix1, i)


    '                    DS2 = PrcDS("USP_PFP32000_SEARCH_VS10_LINE", cn, str_Autokey)

    '                    For xrow As Integer = 0 To GetDsRc(DS2) - 1
    '                        int_rowIn = i + GetDsData(DS2, xrow, "DSeq") - 1

    '                        ' LẤY TỐI ĐA 5 QUY TRÌNH

    '                        If GetDsData(DS2, xrow, "DSeq") = "1" Then ColorUse = Color1
    '                        If GetDsData(DS2, xrow, "DSeq") = "2" Then ColorUse = Color2
    '                        If GetDsData(DS2, xrow, "DSeq") = "3" Then ColorUse = Color3
    '                        If GetDsData(DS2, xrow, "DSeq") = "4" Then ColorUse = Color4
    '                        If GetDsData(DS2, xrow, "DSeq") = "5" Then ColorUse = Color5


    '                        int_Random = getColumIndex(Vs10, GetDsData(DS2, xrow, "DateStart")) ' Lấy giá trị cột của DataStart

    '                        If int_Random < 0 Then int_Random = getColumIndex(Vs10, "QtyPlanBL") + 1 ' Nếu không có, cho mặc định cột 1

    '                        int_RandomRange = getColumIndex(Vs10, GetDsData(DS2, xrow, "DateFinish")) ' Lấy giá trị cột của Data Finsih

    '                        If int_RandomRange > 0 Then ' Nếu có giá trị, thực thi

    '                            int_RandomRange = int_RandomRange - int_Random

    '                            If int_Random < 0 Then int_Random = getColumIndex(Vs10, "QtyPlanBL") + 1

    '                            Ran1 = int_Random + int_RandomRange

    '                            SPR_TEXTBOX_S(Vs10, int_Random, int_rowIn)
    '                            Vs10.ActiveSheet.Cells(int_rowIn, int_Random).HorizontalAlignment = CellHorizontalAlignment.Left
    '                            SPR_BACKCOLORCELLRANGE(Vs10, ColorUse, int_Random, int_rowIn, int_Random + int_RandomRange, int_rowIn)

    '                            Vs10.ActiveSheet.Cells(int_rowIn, int_Random).ColumnSpan = int_RandomRange + 1
    '                            Vs10.ActiveSheet.Cells(int_rowIn, int_Random).Value = "[Plan: " & Format0(GetDsData(DS2, xrow, "QtyPlan")) & "-" & GetDsData(DS2, xrow, "MachineName") & "]"
    '                            setCell(Vs10, int_Random, int_rowIn, GetDsData(DS2, xrow, "KEY_AutoKey"))
    '                            Vs10.ActiveSheet.Cells(int_rowIn, int_Random, int_rowIn, int_Random + int_RandomRange).Tag = GetDsData(DS2, xrow, "KEY_AutoKey")

    '                        End If

    '                    Next

    '                Next


    '                Call ChooseDateRange()
    '                Call ChooseProcessRange()

    '            Else

    '                int_ColFix = getColumIndex(Vs10, "cdSubProcess")

    '                Dim Ran1 As Integer = 0
    '                Dim Ran2 As Integer = 0
    '                Dim Ran3 As Integer = 0
    '                Dim Ran4 As Integer = 0
    '                Dim int_rowIn As Integer

    '                ColorUse = Color5

    '                Dim str_Autokey As String

    '                Dim int_ColFix1 As Integer = getColumIndex(Vs10, "KEY_MaterialCode")
    '                Dim int_ProcessCnt As Integer = vS_Process.ActiveSheet.RowCount

    '                For i = 0 To Vs10.ActiveSheet.RowCount - 1
    '                    str_Autokey = getData(Vs10, int_ColFix1, i)
    '                    int_rowIn = i

    '                    DS2 = PrcDS("USP_PFP32000_SEARCH_VS20_LINE", cn, str_Autokey, getData(Vs10, getColumIndex(Vs10, "KEY_AutoKey"), int_rowIn))
    '                    If i Mod 5 = 0 Then ColorUse = Color1
    '                    If i Mod 5 = 1 Then ColorUse = Color2
    '                    If i Mod 5 = 2 Then ColorUse = Color3
    '                    If i Mod 5 = 3 Then ColorUse = Color4
    '                    If i Mod 5 = 4 Then ColorUse = Color5

    '                    For xrow As Integer = 0 To GetDsRc(DS2) - 1

    '                        int_Random = getColumIndex(Vs10, GetDsData(DS2, xrow, "DateStart"))
    '                        If int_Random < 0 Then int_Random = getColumIndex(Vs10, "QtyPlanBL") + 1

    '                        int_RandomRange = getColumIndex(Vs10, GetDsData(DS2, xrow, "DateFinish"))

    '                        If int_RandomRange > 0 Then
    '                            int_RandomRange = int_RandomRange - int_Random

    '                            If int_RandomRange < 0 Then int_RandomRange = getColumIndex(Vs10, "QtyPlanBL") + 1

    '                            Ran1 = int_Random + int_RandomRange

    '                            SPR_TEXTBOX_S(Vs10, int_Random, int_rowIn)
    '                            Vs10.ActiveSheet.Cells(int_rowIn, int_Random).HorizontalAlignment = CellHorizontalAlignment.Left
    '                            SPR_BACKCOLORCELLRANGE(Vs10, ColorUse, int_Random, int_rowIn, int_Random + int_RandomRange, int_rowIn)

    '                            Vs10.ActiveSheet.Cells(int_rowIn, int_Random).ColumnSpan = int_RandomRange + 1
    '                            Vs10.ActiveSheet.Cells(int_rowIn, int_Random).Value = "[Plan: " & Format0(GetDsData(DS2, xrow, "QtyPlan")) & "] -" & GetDsData(DS2, xrow, "POCode") & "-" & GetDsData(DS2, xrow, "ItemName")
    '                            Vs10.ActiveSheet.Cells(int_rowIn, int_Random, int_rowIn, int_Random + int_RandomRange).Tag = GetDsData(DS2, xrow, "KEY_AutoKey")

    '                        End If


    '                    Next

    '                Next

    '                Call ChooseDateRange()

    '            End If



    '        Catch ex As Exception
    '            Call MsgBoxP_Error("DATA_SEARCH_vs10", ex.Message)
    '        Finally
    '            Vs10.Enabled = True
    '        End Try
    '    End Function

    '    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
    '        Dim Generator As System.Random = New System.Random()
    '        Return Generator.Next(Min, Max)
    '    End Function


    '#End Region

    '#Region "Event"



    '    Private Sub btn_SEARCH_Click(sender As Object, e As EventArgs) Handles btn_SEARCH.Click
    '        Try
    '            chk_FSEL.CheckState = 0
    '            chk_FSEL.BackColor = clrUncheck
    '            chk_FSEL.ForeColor = Color.Black

    '            chk_FSEL.Text = WordConv("OPEN SEARCH")
    '            ssp_WHERE.Visible = False

    '            chk_Format.BackColor = clrUncheck
    '            chk_Format.ForeColor = Color.Black

    '            chk_Format.Text = WordConv("OPEN FORMAT")
    '            ssp_FORMAT.Visible = False


    '            If chk_DemoData.Checked = True Then Call DemoData() Else Call DATA_SEARCH_vs10()

    '        Catch ex As Exception
    '            MsgBoxP_Error("btn_SEARCH_Click", ex.Message)
    '        End Try

    '    End Sub

    '    Private Sub txt_SDateEDate_txtTextKeyDown(sender As Object, e As KeyEventArgs)
    '        Try
    '            Select Case e.KeyCode
    '                Case Keys.Enter
    '                    Setfocus(txt_CustomerDyeingCode)
    '            End Select
    '        Catch ex As Exception
    '        End Try
    '    End Sub
    '    Private Sub txt_InchardeSales_txtTextKeyDown(sender As Object, e As KeyEventArgs)
    '        Try
    '            Select Case e.KeyCode
    '                Case Keys.Enter
    '                    btn_SEARCH.Focus()
    '            End Select
    '        Catch ex As Exception
    '            Call MsgBoxP("txt_InchardeSales_txtTextKeyDown", ex.Message)
    '        End Try
    '    End Sub
    '    Private Sub chk_FSEL_Click(sender As Object, e As EventArgs) Handles chk_FSEL.CheckedChanged
    '        If chk_FSEL.CheckState = 0 Then                  '
    '            chk_FSEL.BackColor = clrUncheck
    '            chk_FSEL.ForeColor = Color.Black

    '            chk_FSEL.Text = WordConv("OPEN SEARCH")
    '            ssp_WHERE.Visible = False
    '        Else                                        '
    '            chk_FSEL.BackColor = clrCheck
    '            chk_FSEL.ForeColor = Color.Black

    '            chk_FSEL.Text = WordConv("CLOSE SEARCH")
    '            ssp_WHERE.Visible = True
    '        End If
    '    End Sub

    '    Private Sub chk_Format_Click(sender As Object, e As EventArgs) Handles chk_Format.CheckedChanged
    '        If chk_Format.CheckState = 0 Then                  '
    '            chk_Format.BackColor = clrUncheck
    '            chk_Format.ForeColor = Color.Black

    '            chk_Format.Text = WordConv("OPEN FORMAT")
    '            ssp_FORMAT.Visible = False
    '        Else                                        '
    '            chk_Format.BackColor = clrCheck
    '            chk_Format.ForeColor = Color.Black

    '            chk_Format.Text = WordConv("CLOSE FORMAT")
    '            ssp_FORMAT.Visible = True
    '        End If
    '    End Sub

    '    Private Sub Vs10_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellDoubleClick
    '        If chk_DetailPlan.Checked And rad_OrderWorking.Checked Then Call DATA_SEARCH_vS11()
    '        If chk_DetailPlan.Checked And rad_MachineWorking.Checked Then Call DATA_SEARCH_vS11_MACHINE()
    '    End Sub

    '    Private Sub Vs11_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS11.CellDoubleClick
    '        Exit Sub
    '        Call DATA_SEARCH_vS12()
    '    End Sub


    '    Overrides Sub Function_Event(PressKey As Integer)
    '        Try
    '            Select Case PressKey

    '            End Select

    '        Catch ex As Exception
    '        End Try
    '    End Sub
    '    Private Sub PFP21112_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
    '        Call Function_Event(e.KeyValue)
    '    End Sub
    '#End Region


    '    Private color_Dialog As Color
    '    Private int_RBG As Integer
    '    Private Sub cmd_color1_Click(sender As Object, e As EventArgs) Handles cmd_color1.Click, cmd_color2.Click, cmd_color3.Click, cmd_color4.Click, cmd_color5.Click, cmd_color6.Click
    '        Try
    '            Dim str_Vb As String
    '            str_Vb = ColorDialog1.ShowDialog()

    '            If str_Vb = "1" Then

    '                color_Dialog = ColorDialog1.Color
    '                int_RBG = color_Dialog.ToArgb()

    '                If sender Is cmd_color1 Then cmd_color1.BackColor = ColorDialog1.Color
    '                If sender Is cmd_color2 Then cmd_color2.BackColor = ColorDialog1.Color
    '                If sender Is cmd_color3 Then cmd_color3.BackColor = ColorDialog1.Color
    '                If sender Is cmd_color4 Then cmd_color4.BackColor = ColorDialog1.Color
    '                If sender Is cmd_color5 Then cmd_color5.BackColor = ColorDialog1.Color
    '                If sender Is cmd_color6 Then cmd_color6.BackColor = ColorDialog1.Color

    '            End If

    '        Catch ex As Exception
    '            Call MsgBoxP("txt_ColorHEX_btnTitleClick")
    '        End Try
    '    End Sub


    '    Private Sub Vs10_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellClick
    '        If rad_OrderWorking.Checked Then txt_QtyPlan.Data = Format0(CDecp(getData(Vs10, getColumIndex(Vs10, "QtyPlanBL"), Vs10.ActiveSheet.ActiveRowIndex)))

    '        If e.Column > getColumIndex(Vs10, "QtyPlanBL") Then ttpSheet.SetToolTip(Vs10, getData(Vs10, e.Column, e.Row))
    '    End Sub
    '    Private Sub Vs10_GotFocus(sender As Object, e As EventArgs) Handles Vs10.GotFocus, vS11.GotFocus
    '        chk_FSEL.BackColor = clrUncheck
    '        chk_FSEL.ForeColor = Color.Black

    '        chk_FSEL.Text = WordConv("OPEN")
    '        ssp_WHERE.Visible = False

    '        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

    '    End Sub
    '    Private Sub Vs10_LostFocus(sender As Object, e As EventArgs) Handles Vs10.LostFocus, vS11.LostFocus
    '        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)
    '    End Sub
    '    Private Sub Vs10_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs10.KeyDown
    '        Try

    '            Dim str_Autokey As String
    '            Dim int_xrow As Integer = Vs10.ActiveSheet.ActiveRowIndex
    '            Dim str_Autokey_3200 As String = getData(Vs10, getColumIndex(Vs10, "KEY_AUTOKEY"), int_xrow)

    '            Dim DateStart As String
    '            Dim DateEnd As String
    '            Dim _cdSubProcess As String = getData(Vs10, getColumIndex(Vs10, "KEY_cdSubProcess"), int_xrow)

    '            Dim int_ColumStart As Integer
    '            Dim int_ColumnEnd As Integer

    '            int_ColumStart = Vs10.ActiveSheet.ActiveCell.Column.Index
    '            int_ColumnEnd = Vs10.ActiveSheet.ActiveCell.Column.Index + Vs10.ActiveSheet.GetSelection(0).ColumnCount
    '            DateStart = Vs10.ActiveSheet.ColumnHeader.Columns(int_ColumStart).Tag
    '            DateEnd = Vs10.ActiveSheet.ColumnHeader.Columns(int_ColumnEnd).Tag

    '            If e.KeyCode = Keys.Enter Then
    '                str_Autokey = CIntp(getCell(Vs10, Vs10.ActiveSheet.ActiveColumnIndex, int_xrow))
    '                If READ_PFK3202(str_Autokey) Then
    '                    If ISUD3202A.Link_ISUD3202A(3, str_Autokey, Me.Name) = False Then GoTo next1

    '                Else
    '                    If ISUD3202A.Link_ISUD3202A(1, str_Autokey_3200, _cdSubProcess, DateStart, DateEnd, Pub.SAW, Me.Name) = False Then GoTo next1

    '                End If

    '                Dim int_Random As Integer
    '                Dim int_RandomRange As Integer
    '                int_ColumnMax = Vs10.ActiveSheet.ColumnCount

    '                Dim Ran1 As Integer
    '                Dim int_rowIn As Integer
    '                Dim ColorUse As Color

    '                ColorUse = Color.Gray

    '                Dim int_ColFix1 As Integer = getColumIndex(Vs10, "KEY_AUTOKEY")
    '                Dim int_ColFix2 As Integer = getColumIndex(Vs10, "key_cdSubProcess")

    '                DS2 = PrcDS("USP_PFP32000_SEARCH_VS10_LINE_PROCESS", cn, str_Autokey_3200, _cdSubProcess)

    '                setData(Vs10, getColumIndex(Vs10, "QtyPlan"), int_xrow, GetDsData(DS2, 0, "QtyPlanTotal"))
    '                setData(Vs10, getColumIndex(Vs10, "QtyPlanBL"), int_xrow, GetDsData(DS2, 0, "QtyPlanBL"))

    '                Vs10.ActiveSheet.ClearRange(int_xrow, getColumIndex(Vs10, "QtyPlanBL") + 1, 1, Vs10.ActiveSheet.ColumnCount - getColumIndex(Vs10, "QtyPlanBL") - 1, False)
    '                SPR_BACKCOLORCELLRANGE(Vs10, Color.Empty, getColumIndex(Vs10, "QtyPlanBL") + 1, int_rowIn, Vs10.ActiveSheet.ColumnCount - 1, int_rowIn)


    '                For xrow As Integer = 0 To GetDsRc(DS2) - 1
    '                    int_rowIn = int_xrow

    '                    int_Random = getColumIndex(Vs10, GetDsData(DS2, xrow, "DateStart"))

    '                    If int_Random < 0 Then int_Random = getColumIndex(Vs10, "QtyPlanBL") + 1

    '                    int_RandomRange = getColumIndex(Vs10, GetDsData(DS2, xrow, "DateFinish"))
    '                    int_RandomRange = int_RandomRange - int_Random

    '                    If int_Random < 0 Then int_Random = getColumIndex(Vs10, "QtyPlanBL") + 1

    '                    Ran1 = int_Random + int_RandomRange

    '                    SPR_TEXTBOX_S(Vs10, int_Random, int_rowIn)
    '                    Vs10.ActiveSheet.Cells(int_rowIn, int_Random).HorizontalAlignment = CellHorizontalAlignment.Left

    '                    SPR_BACKCOLORCELLRANGE(Vs10, ColorUse, int_Random, int_rowIn, int_Random + int_RandomRange, int_rowIn)

    '                    Vs10.ActiveSheet.Cells(int_rowIn, int_Random).ColumnSpan = int_RandomRange + 1
    '                    Vs10.ActiveSheet.Cells(int_rowIn, int_Random).Value = "[Plan: " & Format0(GetDsData(DS2, xrow, "QtyPlan")) & "-" & GetDsData(DS2, xrow, "MachineName") & "]"
    '                    setCell(Vs10, int_Random, int_rowIn, GetDsData(DS2, xrow, "KEY_AutoKey"))
    '                    Vs10.ActiveSheet.Cells(int_rowIn, int_Random, int_rowIn, int_Random + int_RandomRange).Tag = GetDsData(DS2, xrow, "KEY_AutoKey")

    '                Next



    'next1:
    '                e.Handled = True


    '            ElseIf e.KeyCode = Keys.Back Then

    '                str_Autokey = CIntp(getCell(Vs10, Vs10.ActiveSheet.ActiveCell.Column.Index2, int_xrow))

    '                If READ_PFK3202(str_Autokey) Then
    '                    D3202.DateFinish = Function_Date_Add(FSDate(D3202.DateFinish), 0, -1)

    '                    If D3202.DateFinish < D3202.DateStart Then MsgBoxP("Date Finish > Date Start") : Exit Sub

    '                    If REWRITE_PFK3202(D3202) Then
    '                        Vs10.ActiveSheet.ActiveCell.ColumnSpan = Vs10.ActiveSheet.ActiveCell.ColumnSpan - 1

    '                        Vs10.ActiveSheet.Cells(Vs10.ActiveSheet.ActiveRowIndex, Vs10.ActiveSheet.ActiveColumnIndex + Vs10.ActiveSheet.ActiveCell.ColumnSpan + 1).BackColor = Color.Empty
    '                        Vs10.ActiveSheet.Cells(Vs10.ActiveSheet.ActiveRowIndex, Vs10.ActiveSheet.ActiveColumnIndex + Vs10.ActiveSheet.ActiveCell.ColumnSpan + 1).ResetValue()
    '                        Vs10.ActiveSheet.Cells(Vs10.ActiveSheet.ActiveRowIndex, Vs10.ActiveSheet.ActiveColumnIndex + Vs10.ActiveSheet.ActiveCell.ColumnSpan + 1).ResetTag()


    '                    End If

    '                End If

    '                e.Handled = True

    '            ElseIf e.KeyCode = Keys.Oemplus Then

    '                str_Autokey = CIntp(getCell(Vs10, Vs10.ActiveSheet.ActiveColumnIndex, int_xrow))

    '                If READ_PFK3202(str_Autokey) Then
    '                    D3202.DateFinish = Function_Date_Add(FSDate(D3202.DateFinish), 0, 1)

    '                    If D3202.DateFinish > txt_DateFinish.Data Then MsgBoxP("Date Finish In Range") : Exit Sub

    '                    If REWRITE_PFK3202(D3202) Then
    '                        Vs10.ActiveSheet.ActiveCell.ColumnSpan = Vs10.ActiveSheet.ActiveCell.ColumnSpan + 1

    '                    End If

    '                End If

    '                e.Handled = True

    '            End If

    '        Catch ex As Exception

    '        End Try

    '    End Sub

    '    Private Function DATA_SEARCH_VS1_LINE()
    '        DATA_SEARCH_VS1_LINE = False
    '        Try
    '            DATA_SEARCH_VS1_LINE = True

    '            If rad_OrderWorking.Checked Then

    '                Dim int_xrow As Integer = Vs10.ActiveSheet.ActiveRowIndex
    '                Dim str_Autokey_3200 As String = getData(Vs10, getColumIndex(Vs10, "KEY_AUTOKEY"), int_xrow)
    '                Dim _cdSubProcess As String = getData(Vs10, getColumIndex(Vs10, "KEY_cdSubProcess"), int_xrow)

    '                Dim int_Random As Integer
    '                Dim int_RandomRange As Integer
    '                int_ColumnMax = Vs10.ActiveSheet.ColumnCount

    '                Dim Ran1 As Integer
    '                Dim int_rowIn As Integer
    '                Dim ColorUse As Color

    '                ColorUse = Color.Gray

    '                Dim int_ColFix1 As Integer = getColumIndex(Vs10, "KEY_AUTOKEY")
    '                Dim int_ColFix2 As Integer = getColumIndex(Vs10, "key_cdSubProcess")

    '                DS2 = PrcDS("USP_PFP32000_SEARCH_VS10_LINE_PROCESS", cn, str_Autokey_3200, _cdSubProcess)

    '                setData(Vs10, getColumIndex(Vs10, "QtyPlan"), int_xrow, GetDsData(DS2, 0, "QtyPlanTotal"))
    '                setData(Vs10, getColumIndex(Vs10, "QtyPlanBL"), int_xrow, GetDsData(DS2, 0, "QtyPlanBL"))

    '                Vs10.ActiveSheet.ClearRange(int_xrow, getColumIndex(Vs10, "QtyPlanBL") + 1, 1, Vs10.ActiveSheet.ColumnCount - getColumIndex(Vs10, "QtyPlanBL") - 1, False)

    '                SPR_BACKCOLORCELLRANGE(Vs10, Color.Empty, getColumIndex(Vs10, "QtyPlanBL") + 1, int_rowIn, Vs10.ActiveSheet.ColumnCount - 1, int_rowIn)

    '                Dim strDateStart As String

    '                Dim strDateStartOld As String
    '                Dim strDateFinish As String


    '                For xrow As Integer = 0 To GetDsRc(DS2) - 1
    '                    int_rowIn = int_xrow

    '                    strDateStart = GetDsData(DS2, xrow, "DateStart")

    '                    If CIntp(strDateStart) < CIntp(strDateFinish) Then
    '                        int_Random = getColumIndex(Vs10, strDateStartOld)

    '                        If int_Random < 0 Then int_Random = getColumIndex(Vs10, "QtyPlanBL") + 1

    '                        int_RandomRange = getColumIndex(Vs10, GetDsData(DS2, xrow, "DateFinish"))
    '                        int_RandomRange = int_RandomRange - int_Random

    '                        If int_Random < 0 Then int_Random = getColumIndex(Vs10, "QtyPlanBL") + 1

    '                        Ran1 = int_Random + int_RandomRange

    '                        SPR_TEXTBOX_S(Vs10, int_Random, int_rowIn)
    '                        Vs10.ActiveSheet.Cells(int_rowIn, int_Random).HorizontalAlignment = CellHorizontalAlignment.Left

    '                        SPR_BACKCOLORCELLRANGE(Vs10, ColorUse, int_Random, int_rowIn, int_Random + int_RandomRange, int_rowIn)

    '                        Vs10.ActiveSheet.Cells(int_rowIn, int_Random).ColumnSpan = int_RandomRange + 1
    '                        Vs10.ActiveSheet.Cells(int_rowIn, int_Random).Value &= "/ [Plan: " & Format0(GetDsData(DS2, xrow, "QtyPlan")) & "-" & GetDsData(DS2, xrow, "MachineName") & "]"
    '                        setCell(Vs10, int_Random, int_rowIn, GetDsData(DS2, xrow, "KEY_AutoKey"))
    '                        Vs10.ActiveSheet.Cells(int_rowIn, int_Random, int_rowIn, int_Random + int_RandomRange).Tag = GetDsData(DS2, xrow, "KEY_AutoKey")

    '                    Else

    '                        int_Random = getColumIndex(Vs10, GetDsData(DS2, xrow, "DateStart"))

    '                        If int_Random < 0 Then int_Random = getColumIndex(Vs10, "QtyPlanBL") + 1

    '                        int_RandomRange = getColumIndex(Vs10, GetDsData(DS2, xrow, "DateFinish"))
    '                        int_RandomRange = int_RandomRange - int_Random

    '                        If int_Random < 0 Then int_Random = getColumIndex(Vs10, "QtyPlanBL") + 1

    '                        Ran1 = int_Random + int_RandomRange

    '                        SPR_TEXTBOX_S(Vs10, int_Random, int_rowIn)
    '                        Vs10.ActiveSheet.Cells(int_rowIn, int_Random).HorizontalAlignment = CellHorizontalAlignment.Left

    '                        SPR_BACKCOLORCELLRANGE(Vs10, ColorUse, int_Random, int_rowIn, int_Random + int_RandomRange, int_rowIn)

    '                        Vs10.ActiveSheet.Cells(int_rowIn, int_Random).ColumnSpan = int_RandomRange + 1
    '                        Vs10.ActiveSheet.Cells(int_rowIn, int_Random).Value = "[Plan: " & Format0(GetDsData(DS2, xrow, "QtyPlan")) & "-" & GetDsData(DS2, xrow, "MachineName") & "]"
    '                        setCell(Vs10, int_Random, int_rowIn, GetDsData(DS2, xrow, "KEY_AutoKey"))
    '                        Vs10.ActiveSheet.Cells(int_rowIn, int_Random, int_rowIn, int_Random + int_RandomRange).Tag = GetDsData(DS2, xrow, "KEY_AutoKey")

    '                    End If


    '                    strDateStartOld = GetDsData(DS2, xrow, "DateStart")
    '                    strDateFinish = GetDsData(DS2, xrow, "DateFinish")

    '                Next

    '            ElseIf rad_MachineWorking.Checked Then

    '                Dim int_xrow As Integer = vS_Suggestion.ActiveSheet.ActiveRowIndex
    '                Dim KEY_MaterialCode As String = getData(Vs10, getColumIndex(Vs10, "KEY_MaterialCode"), Vs10.ActiveSheet.ActiveRowIndex)
    '                Dim _cdSubProcess As String = getData(Vs10, getColumIndex(Vs10, "KEY_cdSubProcess"), Vs10.ActiveSheet.ActiveRowIndex)


    '                Dim int_Random As Integer
    '                Dim int_RandomRange As Integer
    '                int_ColumnMax = Vs10.ActiveSheet.ColumnCount

    '                Dim Ran1 As Integer
    '                Dim int_rowIn As Integer
    '                Dim ColorUse As Color

    '                ColorUse = Color.Gray

    '                Dim int_ColFix1 As Integer = getColumIndex(Vs10, "KEY_MaterialCode")
    '                Dim int_ColFix2 As Integer = getColumIndex(Vs10, "key_cdSubProcess")

    '                Select Case wJOB
    '                    Case Enum_ISUDCHK.Insert
    '                        DS2 = PrcDS("USP_PFP32000_SEARCH_VS20_LINE_PROCESS", cn, KEY_MaterialCode, _cdSubProcess, getData(vS_Suggestion, getColumIndex(vS_Suggestion, "KEY_AutoKey"), int_xrow))

    '                        Vs10.ActiveSheet.Rows.Add(Vs10.ActiveSheet.ActiveRowIndex, 1)

    '                        For xCOL As Integer = 0 To getColumIndex(Vs10, "QtyPlanBL")
    '                            Vs10.ActiveSheet.Cells(Vs10.ActiveSheet.ActiveRowIndex, xCOL).Value = _
    '                                                    Vs10.ActiveSheet.Cells(Vs10.ActiveSheet.ActiveRowIndex + 1, xCOL).Value
    '                        Next


    '                        For xrow As Integer = 0 To GetDsRc(DS2) - 1
    '                            int_rowIn = Vs10.ActiveSheet.ActiveRowIndex

    '                            int_Random = getColumIndex(Vs10, GetDsData(DS2, xrow, "DateStart"))
    '                            If int_Random < 0 Then int_Random = getColumIndex(Vs10, "QtyPlanBL") + 1

    '                            int_RandomRange = getColumIndex(Vs10, GetDsData(DS2, xrow, "DateFinish"))

    '                            If int_RandomRange > 0 Then
    '                                int_RandomRange = int_RandomRange - int_Random

    '                                If int_RandomRange < 0 Then int_RandomRange = getColumIndex(Vs10, "QtyPlanBL") + 1

    '                                Ran1 = int_Random + int_RandomRange

    '                                SPR_TEXTBOX_S(Vs10, int_Random, int_rowIn)
    '                                Vs10.ActiveSheet.Cells(int_rowIn, int_Random).HorizontalAlignment = CellHorizontalAlignment.Left
    '                                SPR_BACKCOLORCELLRANGE(Vs10, ColorUse, int_Random, int_rowIn, int_Random + int_RandomRange, int_rowIn)

    '                                Vs10.ActiveSheet.Cells(int_rowIn, int_Random).ColumnSpan = int_RandomRange + 1
    '                                Vs10.ActiveSheet.Cells(int_rowIn, int_Random).Value = "[Plan: " & Format0(GetDsData(DS2, xrow, "QtyPlan")) & "] -" & GetDsData(DS2, xrow, "POCode") & "-" & GetDsData(DS2, xrow, "ItemName")
    '                                Vs10.ActiveSheet.Cells(int_rowIn, int_Random, int_rowIn, int_Random + int_RandomRange).Tag = GetDsData(DS2, xrow, "KEY_AutoKey")

    '                            End If
    '                        Next

    '                    Case Enum_ISUDCHK.Update

    '                        KEY_MaterialCode = CIntp(getCell(Vs10, Vs10.ActiveSheet.ActiveColumnIndex, Vs10.ActiveSheet.ActiveRowIndex))

    '                        DS2 = PrcDS("USP_PFP32000_SEARCH_VS20_LINE_AUTOKEY", cn, KEY_MaterialCode)

    '                        Dim xrow As Integer = Vs10.ActiveSheet.ActiveRowIndex
    '                        int_rowIn = Vs10.ActiveSheet.ActiveRowIndex

    '                        int_Random = getColumIndex(Vs10, GetDsData(DS2, 0, "DateStart"))
    '                        If int_Random < 0 Then int_Random = getColumIndex(Vs10, "QtyPlanBL") + 1

    '                        int_RandomRange = getColumIndex(Vs10, GetDsData(DS2, 0, "DateFinish"))

    '                        If int_RandomRange > 0 Then

    '                            SPR_BACKCOLORCELLRANGE(Vs10, Color.Empty, getColumIndex(Vs10, "QtyPlanBL") + 1, int_rowIn, Vs10.ActiveSheet.ColumnCount - 1, int_rowIn)

    '                            int_RandomRange = int_RandomRange - int_Random

    '                            If int_RandomRange < 0 Then int_RandomRange = getColumIndex(Vs10, "QtyPlanBL") + 1

    '                            Ran1 = int_Random + int_RandomRange

    '                            SPR_TEXTBOX_S(Vs10, int_Random, int_rowIn)
    '                            Vs10.ActiveSheet.Cells(int_rowIn, int_Random).HorizontalAlignment = CellHorizontalAlignment.Left
    '                            SPR_BACKCOLORCELLRANGE(Vs10, ColorUse, int_Random, int_rowIn, int_Random + int_RandomRange, int_rowIn)

    '                            Vs10.ActiveSheet.Cells(int_rowIn, int_Random).ColumnSpan = int_RandomRange + 1
    '                            Vs10.ActiveSheet.Cells(int_rowIn, int_Random).Value = "[Plan: " & Format0(GetDsData(DS2, 0, "QtyPlan")) & "] -" & GetDsData(DS2, 0, "POCode") & "-" & GetDsData(DS2, 0, "ItemName")
    '                            Vs10.ActiveSheet.Cells(int_rowIn, int_Random, int_rowIn, int_Random + int_RandomRange).Tag = GetDsData(DS2, 0, "KEY_AutoKey")

    '                        End If



    '                End Select


    '            End If
    '        Catch ex As Exception

    '        End Try
    '    End Function
    '    Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click
    '        Try
    '            Dim str_Autokey As String
    '            Dim int_xrow As Integer = Vs10.ActiveSheet.ActiveRowIndex

    '            Dim str_Autokey_3200 As String = getData(Vs10, getColumIndex(Vs10, "KEY_AUTOKEY"), int_xrow)


    '            Dim DateStart As String
    '            Dim DateEnd As String
    '            Dim _cdSubProcess As String = getData(Vs10, getColumIndex(Vs10, "KEY_cdSubProcess"), int_xrow)

    '            Dim int_ColumStart As Integer
    '            Dim int_ColumnEnd As Integer



    '            If Vs10.Focused Then
    '                int_ColumStart = Vs10.ActiveSheet.ActiveCell.Column.Index
    '                int_ColumnEnd = Vs10.ActiveSheet.ActiveCell.Column.Index + Vs10.ActiveSheet.GetSelection(0).ColumnCount
    '                DateStart = Vs10.ActiveSheet.ColumnHeader.Columns(int_ColumStart).Tag
    '                DateEnd = Vs10.ActiveSheet.ColumnHeader.Columns(int_ColumnEnd).Tag

    '                str_Autokey = CIntp(getCell(Vs10, Vs10.ActiveSheet.ActiveColumnIndex, int_xrow))

    '                If sender Is tst_2 And READ_PFK3202(str_Autokey) Then
    '                    wJOB = Enum_ISUDCHK.Search

    '                    If ISUD3202A.Link_ISUD3202A(2, str_Autokey, Me.Name) = False Then GoTo next1

    '                ElseIf sender Is tst_3 And READ_PFK3202(str_Autokey) Then
    '                    wJOB = Enum_ISUDCHK.Update

    '                    If ISUD3202A.Link_ISUD3202A(3, str_Autokey, Me.Name) = False Then GoTo next1

    '                ElseIf sender Is tst_4 And READ_PFK3202(str_Autokey) Then
    '                    wJOB = Enum_ISUDCHK.Delete
    '                    If ISUD3202A.Link_ISUD3202A(4, str_Autokey, Me.Name) = False Then GoTo next1

    '                    If rad_MachineWorking.Checked Then Call SPR_DEL(Vs10, 0, Vs10.ActiveSheet.ActiveRowIndex)


    '                ElseIf sender Is tst_1 Then
    '                    wJOB = Enum_ISUDCHK.Insert
    '                    If ISUD3202A.Link_ISUD3202A(1, str_Autokey_3200, _cdSubProcess, DateStart, DateEnd, Pub.SAW, Me.Name) = False Then GoTo next1

    '                End If

    '                Call DATA_SEARCH_VS1_LINE()

    '            ElseIf vS11.Focused Then

    '                str_Autokey = getData(vS11, getColumIndex(vS11, "KEY_AutoKey"), vS11.ActiveSheet.ActiveRowIndex)

    '                If sender Is tst_2 And READ_PFK3202(str_Autokey) Then
    '                    wJOB = Enum_ISUDCHK.Search
    '                    If ISUD3202A.Link_ISUD3202A(2, str_Autokey, Me.Name) = False Then GoTo next1

    '                ElseIf sender Is tst_3 And READ_PFK3202(str_Autokey) Then
    '                    wJOB = Enum_ISUDCHK.Update

    '                    If ISUD3202A.Link_ISUD3202A(3, str_Autokey, Me.Name) = False Then GoTo next1

    '                ElseIf sender Is tst_4 And READ_PFK3202(str_Autokey) Then
    '                    wJOB = Enum_ISUDCHK.Delete

    '                    If ISUD3202A.Link_ISUD3202A(4, str_Autokey, Me.Name) = False Then GoTo next1
    '                    If rad_MachineWorking.Checked Then
    '                        Call SPR_DEL(vS11, 0, vS11.ActiveSheet.ActiveRowIndex)

    '                    End If



    '                End If


    '                Call DATA_SEARCH_VS1_LINE()

    '            End If

    'next1:

    '        Catch ex As Exception

    '        End Try

    '    End Sub

    '    Private Sub Vs10_DragDropBlock(sender As Object, e As DragDropBlockEventArgs) Handles Vs10.DragDropBlock
    '        Try
    '            Dim str_Autokey As String
    '            Dim int_xrow As Integer = e.RowBegin
    '            Dim int_Gap As Long

    '            If e.RowBegin = e.RowEnd Then
    '                str_Autokey = CIntp(getCell(Vs10, e.ColumnBegin, e.RowBegin))

    '                If READ_PFK3202(str_Autokey) Then
    '                    int_Gap = DateDiff(DateInterval.Day, CDate(FSDate(D3202.DateStart)), CDate(FSDate(D3202.DateFinish)))

    '                    D3202.DateStart = Vs10.ActiveSheet.ColumnHeader.Columns(e.DestinationColumnEnd).Tag
    '                    D3202.DateFinish = Function_Date_Add(FSDate(D3202.DateStart), 0, int_Gap)

    '                    'Vs10.ActiveSheet.Cells(e.RowBegin, e.ColumnBegin, e.RowBegin, e.ColumnEnd + int_Gap).BackColor = Color.Empty
    '                    'Vs10.ActiveSheet.Cells(e.RowBegin, e.ColumnBegin, e.RowBegin, e.ColumnEnd + int_Gap).ResetValue()
    '                    'Vs10.ActiveSheet.Cells(e.RowBegin, e.ColumnBegin, e.RowBegin, e.ColumnEnd + int_Gap).ResetTag()

    '                    If REWRITE_PFK3202(D3202) Then
    '                        e.Cancel = False
    '                        Call DATA_SEARCH_VS1_LINE()
    '                    End If

    '                End If
    '            Else
    '                e.Cancel = True
    '            End If

    '        Catch ex As Exception

    '        End Try
    '    End Sub


    '    Private Sub chk_DetailPlan_CheckedChanged(sender As Object, e As EventArgs) Handles chk_DetailPlan.CheckedChanged
    '        Try
    '            SplitContainer1.Panel2Collapsed = Not chk_DetailPlan.Checked
    '        Catch ex As Exception

    '        End Try
    '    End Sub


    '    Private Sub chk_Suggestion_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Suggestion.CheckedChanged
    '        psc_Main.Panel2Collapsed = Not chk_Suggestion.Checked

    '        For i As Integer = 0 To vS_Process.ActiveSheet.RowCount - 1
    '            If getDataM(vS_Process, getColumIndex(vS_Process, "dchk"), i) = "1" Then
    '                cdDefaultProcess = getData(vS_Process, getColumIndex(vS_Process, "cdSubProcess"), i)
    '                Exit For
    '            End If

    '        Next

    '        If chk_Suggestion.Checked = True And rad_OrderWorking.Checked Then Call DATA_SEARCH_vS_Suggestion()
    '        If chk_Suggestion.Checked = True And rad_MachineWorking.Checked Then Call DATA_SEARCH_vS_Suggestion_Order()

    '    End Sub

    '    Private Sub vS_Suggestion_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Suggestion.CellClick
    '        If rad_MachineWorking.Checked And CDecp(txt_QtyPlan.Data) = 0 Then txt_QtyPlan.Data = Format0(CDecp(getData(vS_Suggestion, getColumIndex(Vs10, "QtyPlanBL"), Vs10.ActiveSheet.ActiveRowIndex)))

    '    End Sub

    '    Private Sub vS_Suggestion_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS_Suggestion.CellDoubleClick
    '        Try
    '            MessSer = MsgBox("Do you want to create new plan ?", vbYesNo)
    '            If MessSer <> vbYes Then Exit Sub
    '            wJOB = Enum_ISUDCHK.Insert

    '            If rad_OrderWorking.Checked Then
    '                If CDecp(txt_QtyPlan.Data) = 0 Then MsgBoxP("Qty must > 0 !") : Exit Sub

    '                Dim MachineCode As String
    '                Dim str_Autokey_3200 As String = getData(Vs10, getColumIndex(Vs10, "KEY_AUTOKEY"), Vs10.ActiveSheet.ActiveRowIndex)

    '                MachineCode = getData(vS_Suggestion, getColumIndex(vS_Suggestion, "KEY_MaterialCode"), e.Row)


    '                Dim DateStart As String
    '                Dim DateEnd As String

    '                Dim int_ColumStart As Integer
    '                Dim int_ColumnEnd As Integer

    '                int_ColumStart = Vs10.ActiveSheet.ActiveCell.Column.Index
    '                int_ColumnEnd = Vs10.ActiveSheet.ActiveCell.Column.Index + Vs10.ActiveSheet.GetSelection(0).ColumnCount
    '                DateStart = Vs10.ActiveSheet.ColumnHeader.Columns(int_ColumStart).Tag
    '                DateEnd = Vs10.ActiveSheet.ColumnHeader.Columns(int_ColumnEnd).Tag

    '                If READ_PFK7155_MATERIALCODE(MachineCode) Then
    '                    W3202.cdFactory = D7155.cdFactory
    '                    W3202.seFactory = ListCode("Factory")

    '                    W3202.cdSubProcess = D7155.cdSubProcess
    '                    W3202.seSubProcess = ListCode("SubProcess")

    '                    W3202.cdUnitMaterial = "001"
    '                    W3202.seUnitMaterial = ListCode("UnitMaterial")

    '                    W3202.QtyPlan = CDecp(txt_QtyPlan.Data)
    '                    W3202.MaterialCode = MachineCode

    '                    W3202.AutoKey_3200 = str_Autokey_3200
    '                    W3202.DateStart = DateStart
    '                    W3202.DateFinish = DateEnd
    '                    W3202.InchargeInsert = Pub.SAW
    '                    W3202.DateInsert = System_Date_time_11()

    '                    If WRITE_PFK3202(W3202) Then
    '                        Call DATA_SEARCH_VS1_LINE()
    '                        Call DATA_SEARCH_vS_Suggestion_LINE()
    '                    End If

    '                End If

    '            ElseIf rad_MachineWorking.Checked Then
    '                If CDecp(txt_QtyPlan.Data) = 0 Then MsgBoxP("Qty must > 0 !") : Exit Sub

    '                Dim MachineCode As String
    '                Dim str_Autokey_3200 As String

    '                MachineCode = getData(Vs10, getColumIndex(Vs10, "KEY_MaterialCode"), Vs10.ActiveSheet.ActiveRowIndex)
    '                str_Autokey_3200 = getData(vS_Suggestion, getColumIndex(vS_Suggestion, "KEY_AUTOKEY"), e.Row)

    '                Dim DateStart As String
    '                Dim DateEnd As String

    '                Dim int_ColumStart As Integer
    '                Dim int_ColumnEnd As Integer

    '                int_ColumStart = Vs10.ActiveSheet.ActiveCell.Column.Index
    '                int_ColumnEnd = Vs10.ActiveSheet.ActiveCell.Column.Index + Vs10.ActiveSheet.GetSelection(0).ColumnCount
    '                DateStart = Vs10.ActiveSheet.ColumnHeader.Columns(int_ColumStart).Tag
    '                DateEnd = Vs10.ActiveSheet.ColumnHeader.Columns(int_ColumnEnd).Tag

    '                If READ_PFK7155_MATERIALCODE(MachineCode) Then
    '                    W3202.cdFactory = D7155.cdFactory
    '                    W3202.seFactory = ListCode("Factory")

    '                    W3202.cdSubProcess = D7155.cdSubProcess
    '                    W3202.seSubProcess = ListCode("SubProcess")

    '                    W3202.cdUnitMaterial = "001"
    '                    W3202.seUnitMaterial = ListCode("UnitMaterial")

    '                    W3202.QtyPlan = CDecp(txt_QtyPlan.Data)
    '                    W3202.MaterialCode = MachineCode

    '                    W3202.AutoKey_3200 = str_Autokey_3200
    '                    W3202.DateStart = DateStart
    '                    W3202.DateFinish = DateEnd
    '                    W3202.InchargeInsert = Pub.SAW
    '                    W3202.DateInsert = System_Date_time_11()

    '                    If WRITE_PFK3202(W3202) Then
    '                        Call DATA_SEARCH_VS1_LINE()
    '                        Call DATA_SEARCH_vS_Suggestion_Order_LINE()
    '                    End If

    '                End If


    '            End If





    '        Catch ex As Exception

    '        End Try
    '    End Sub

    '    Private Sub cmd_AppliedHidden_Click(sender As Object, e As EventArgs) Handles cmd_AppliedHidden.Click
    '        Try
    '            Dim strColumnName As String

    '            For i As Integer = 0 To vS_Hidden.ActiveSheet.RowCount - 1
    '                strColumnName = getData(vS_Hidden, 1, i).ToString

    '                If getColumIndex(Vs10, strColumnName) > -1 Then
    '                    If getDataM(vS_Hidden, 0, i) = "1" Then
    '                        Vs10.ActiveSheet.Columns(strColumnName).Visible = True
    '                    Else
    '                        Vs10.ActiveSheet.Columns(strColumnName).Visible = False
    '                    End If
    '                End If

    '            Next
    '        Catch ex As Exception

    '        End Try
    '    End Sub



    '    Private Sub rad_OrderWorking_CheckedChanged(sender As Object, e As EventArgs) Handles rad_OrderWorking.CheckedChanged, rad_MachineWorking.CheckedChanged
    '        chk_Initial = False
    '    End Sub

End Class