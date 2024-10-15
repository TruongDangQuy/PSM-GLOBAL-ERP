Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports FarPoint.Win
Public Class PeaceFarpoint
    Inherits FarPoint.Win.Spread.FpSpread

#Region "Check"
    Public SearchChk As Boolean = False
    Private InsertChk As Boolean = False
    Private CheckIni As Boolean = False
    Private CopyChk As Boolean = True
    Private m_UseGradient As Boolean = False
    Private i_SpreadWJOB As Integer
    'Public Range(200) As String
    Public CheckHLPChange As Boolean = True
    Public CheckHLPClick As Boolean = True
    Public CheckInputMap As Boolean = False

#End Region

#Region "New"
    Private m_Tag1 As String

    Public Sub New()

        InitializeComponent()

        Me.AutoClipboard = CopyPasteChk


    End Sub

#End Region

#Region "Handle"
    Private _ReportName As String
    Public Property ReportName() As String
        Get
            Return _ReportName
        End Get
        Set(ByVal value As String)
            _ReportName = value
        End Set
    End Property


    Private _SheetDSName As String
    Public Property SheetDSName() As String
        Get
            Return _SheetDSName
        End Get
        Set(ByVal value As String)
            _SheetDSName = value
        End Set
    End Property
    Private Sub PeaceFarpoint_ClipboardPasted(sender As Object, e As ClipboardPastedEventArgs) Handles Me.ClipboardPasted
        Try
            Dim i As Integer

            For i = e.CellRange.Row To e.CellRange.Row + e.CellRange.RowCount - 1
                PeaceFarpoint_vSChange(e.CellRange.Column, i)
            Next

        Catch ex As Exception
        End Try
    End Sub

    Private Sub PeaceFarpoint_vSChange(XCol As Integer, xRow As Integer)
        If CheckHLPChange = False Then Exit Sub

        Try
            Dim ColumnName As String

            ColumnName = Me.ActiveSheet.Columns(XCol - 2).Tag

            If ColumnName = "" Then Exit Sub

            If ColumnName.Length > 2 Then
                If TypeOf (Me.ActiveSheet.Columns(XCol - 2).CellType) Is CellType.ButtonCellType Then
                    Call HLPOpenVsChange(XCol, xRow, ColumnName)
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PeaceFarpoint_Change(XCol As Integer, xRow As Integer)
        If CheckHLPChange = False Then Exit Sub

        Try
            Dim ColumnName As String

            ColumnName = Me.ActiveSheet.Columns(XCol - 2).Tag

            If ColumnName = "" Then Exit Sub

            If ColumnName.Length > 2 Then
                If TypeOf (Me.ActiveSheet.Columns(XCol - 2).CellType) Is CellType.ButtonCellType Then
                    Call HLPOpen(XCol, xRow, ColumnName)
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub PeaceFarpoint_Change(sender As Object, e As ChangeEventArgs) Handles Me.Change
        Call PeaceFarpoint_Change(e.Column, e.Row)
    End Sub
    Private Sub PeaceFarpoint_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles Me.ButtonClicked
        If CheckHLPClick = False Then Exit Sub

        Try
            Dim ColumnName As String
            Dim Value() As String

            ColumnName = Me.ActiveSheet.ActiveColumn.Tag

            ColumnName = Strings.Mid(ColumnName, 5)

            chkLast = False : chkMold = False
            If Me.ActiveSheet.ActiveColumn.Tag.ToUpper.Contains("LASTCODE") Then chkLast = True
            If Me.ActiveSheet.ActiveColumn.Tag.ToUpper.Contains("MOLDCODE") Then chkMold = True

            If READ_PFK9911(Me.ActiveSheet.ActiveColumn.Tag) Then
                If D9911.CheckDev = "1" Then

                    Value = D9911.CheckDevValue.Split(";")

                    Select Case Value(0)
                        Case "1" ' Customer
                            If Value.Length > 1 Then
                                HLPNA = Value(1)
                                HLP7101A.Link_HLP7101B(HLPNA)
                            Else
                                HLP7101A.ShowDialog()
                            End If

                        Case "1M" ' Customer
                            '-------------------------------
                            Dim Type1 As String = "0"
                            Dim Type2 As String = "0"
                            Dim Type3 As String = "0"
                            Dim Type4 As String = "0"
                            Dim Type5 As String = "0"
                            Dim Type6 As String = "0"

                            If Value(1) = "1" Then Type1 = "1"
                            If Value(2) = "1" Then Type2 = "1"
                            If Value(3) = "1" Then Type3 = "1"
                            If Value(4) = "1" Then Type4 = "1"
                            If Value(5) = "1" Then Type5 = "1"
                            If Value(6) = "1" Then Type6 = "1"

                            If HLP7101A.Link_HLP7101M(Type1, Type2, Type3, Type4, Type5, Type6) = False Then
                                setData(sender, getColumIndex(Me, "CustomerCode"), e.Row, D7101.CustomerCode)
                                setData(sender, getColumIndex(Me, "CustomerName"), e.Row, D7101.CustomerName)

                                Exit Sub
                            End If

                            If READ_PFK7101(hlp0000SeVaTt) Then
                                setData(sender, getColumIndex(Me, "CustomerCode"), e.Row, D7101.CustomerCode)
                                setData(sender, getColumIndex(Me, "CustomerName"), e.Row, D7101.CustomerName)
                            End If

                        Case "2" ' ColorCode
                            If HLP7121A.Link_HLP7121A("1") = False Then Exit Sub

                        Case "3" ' Type Code
                            If Value.Length > 1 Then HLPNA = Value(1)
                            If HLP7103A.Link_HLP7103A(HLPNA, "") = False Then Exit Sub

                        Case "4" ' Tool Code
                            If Value.Length > 1 Then HLPNA = Value(1)
                            If HLP7156A.Link_HLP7156A(HLPNA, "3") = False Then Exit Sub

                        Case "5" ' Odno
                            'If HLP7102A.Link_HLP7102A("2") = False Then Exit Sub
                            HLP7231F.ShowDialog()

                            If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub

                            Call READ_PFK7231(hlp0000SeVaTt)

                            setData(sender, getColumIndex(Me, "MaterialCode"), e.Row, D7231.MaterialCode)
                            setData(sender, getColumIndex(Me, "MaterialName"), e.Row, D7231.MaterialName)

                            setData(sender, getColumIndex(Me, "MaterialSimple"), e.Row, D7231.MaterialSimple)

                            setData(sender, getColumIndex(sender, "seUnitMaterial"), e.Row, D7231.seUnitMaterial)
                            setData(sender, getColumIndex(sender, "cdUnitMaterial"), e.Row, D7231.cdUnitMaterial)

                            Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                            setData(sender, getColumIndex(sender, "cdUnitMaterialName"), e.Row, D7171.BasicName)

                            setData(sender, getColumIndex(sender, "seUnitPacking"), e.Row, D7231.seUnitPacking)
                            setData(sender, getColumIndex(sender, "cdUnitPacking"), e.Row, D7231.cdUnitPacking)

                            Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                            setData(sender, getColumIndex(sender, "cdUnitPackingName"), e.Row, D7171.BasicName)

                            setData(sender, getColumIndex(sender, "Width"), e.Row, D7231.Width)
                            setData(sender, getColumIndex(sender, "Height"), e.Row, D7231.Height)
                            setData(sender, getColumIndex(sender, "SizeName"), e.Row, D7231.SizeName)

                            If D9911.CheckMerge = "1" Then
                                For i As Integer = 0 To e.Row
                                    If FormatCut(getData(sender, e.Column + 1, i)) = "" Then
                                        setData(sender, getColumIndex(Me, "MaterialCode"), e.Row, D7231.MaterialCode)
                                        setData(sender, getColumIndex(Me, "MaterialName"), e.Row, D7231.MaterialName)

                                        setData(sender, getColumIndex(Me, "MaterialSimple"), e.Row, D7231.MaterialSimple)

                                        setData(sender, getColumIndex(sender, "seUnitMaterial"), e.Row, D7231.seUnitMaterial)
                                        setData(sender, getColumIndex(sender, "cdUnitMaterial"), e.Row, D7231.cdUnitMaterial)

                                        Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                        setData(sender, getColumIndex(sender, "cdUnitMaterialName"), e.Row, D7171.BasicName)

                                        setData(sender, getColumIndex(sender, "seUnitPacking"), e.Row, D7231.seUnitPacking)
                                        setData(sender, getColumIndex(sender, "cdUnitPacking"), e.Row, D7231.cdUnitPacking)

                                        Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                        setData(sender, getColumIndex(sender, "cdUnitPackingName"), e.Row, D7171.BasicName)

                                        setData(sender, getColumIndex(sender, "Width"), e.Row, D7231.Width)
                                        setData(sender, getColumIndex(sender, "Height"), e.Row, D7231.Height)
                                        setData(sender, getColumIndex(sender, "SizeName"), e.Row, D7231.SizeName)

                                    End If

                                Next

                            End If

                        Case "6" 'HR CODE
                            If Value.Length > 1 Then HLPNA = Value(1)
                            HLP0002.ShowDialog()

                        Case "7" ' Material code Code
                            HLP7231C.ShowDialog()

                            If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub

                            Call READ_PFK7231(hlp0000SeVaTt)

                            If D9911.CheckMerge = "1" Then
                                For i As Integer = 0 To e.Row
                                    If FormatCut(getData(sender, e.Column + 1, i)) = "" Then
                                        setData(sender, getColumIndex(Me, "MaterialCode"), e.Row, D7231.MaterialCode)
                                        setData(sender, getColumIndex(Me, "MaterialName"), e.Row, D7231.MaterialName)

                                        setData(sender, getColumIndex(Me, "MaterialSimple"), e.Row, D7231.MaterialSimple)

                                        setData(sender, getColumIndex(sender, "QtyBasic"), e.Row, D7231.QtyBasic)

                                        setData(sender, getColumIndex(sender, "seUnitMaterial"), e.Row, D7231.seUnitMaterial)
                                        setData(sender, getColumIndex(sender, "cdUnitMaterial"), e.Row, D7231.cdUnitMaterial)

                                        Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                        setData(sender, getColumIndex(sender, "cdUnitMaterialName"), e.Row, D7171.BasicName)

                                        setData(sender, getColumIndex(sender, "seUnitPacking"), e.Row, D7231.seUnitPacking)
                                        setData(sender, getColumIndex(sender, "cdUnitPacking"), e.Row, D7231.cdUnitPacking)

                                        Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                        setData(sender, getColumIndex(sender, "cdUnitPackingName"), e.Row, D7171.BasicName)

                                        setData(sender, getColumIndex(sender, "seUnitPrice"), e.Row, D7231.seUnitPrice)
                                        setData(sender, getColumIndex(sender, "cdUnitPrice"), e.Row, D7231.cdUnitPrice)
                                        Call READ_PFK7171(D7231.seUnitPrice, D7231.cdUnitPrice)
                                        setData(sender, getColumIndex(sender, "cdUnitPriceName"), e.Row, D7171.BasicName)

                                        Call READ_PFK7171(D7231.seLargeGroupMaterial, D7231.cdLargeGroupMaterial)
                                        setData(sender, getColumIndex(sender, "cdLargeGroupMaterialName"), e.Row, D7171.BasicName)

                                        Call READ_PFK7171(D7231.seSemiGroupMaterial, D7231.cdSemiGroupMaterial)
                                        setData(sender, getColumIndex(sender, "cdSemiGroupMaterialName"), e.Row, D7171.BasicName)

                                        Call READ_PFK7171(D7231.seDetailGroupMaterial, D7231.cdDetailGroupMaterial)
                                        setData(sender, getColumIndex(sender, "cdDetailGroupMaterialName"), e.Row, D7171.BasicName)

                                        setData(sender, getColumIndex(sender, "Width"), e.Row, D7231.Width)
                                        setData(sender, getColumIndex(sender, "Height"), e.Row, D7231.Height)
                                        setData(sender, getColumIndex(sender, "SizeName"), e.Row, D7231.SizeName)

                                    End If

                                Next

                            End If

                        Case "M" ' Material code Code
                            Dim xSel1 As String = ""
                            Dim xSel2 As String = ""

                            If Value(1) <> "" Then xSel1 = Value(1)
                            If Value(2) <> "" Then xSel2 = Value(2)


                            If HLP7231C.Link_HLP7231C(xSel1, xSel2, "") Then
                                If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub

                                If D9911.CheckMerge = "1" Then
                                    For i As Integer = 0 To e.Row
                                        If FormatCut(getData(sender, e.Column + 1, i)) = "" Then
                                            setData(sender, getColumIndex(Me, "MaterialCode"), e.Row, D7231.MaterialCode)
                                            setData(sender, getColumIndex(Me, "MaterialName"), e.Row, D7231.MaterialName)

                                            setData(sender, getColumIndex(Me, "MaterialSimple"), e.Row, D7231.MaterialSimple)

                                            setData(sender, getColumIndex(sender, "QtyBasic"), e.Row, D7231.QtyBasic)

                                            setData(sender, getColumIndex(sender, "seUnitMaterial"), e.Row, D7231.seUnitMaterial)
                                            setData(sender, getColumIndex(sender, "cdUnitMaterial"), e.Row, D7231.cdUnitMaterial)

                                            Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                            setData(sender, getColumIndex(sender, "cdUnitMaterialName"), e.Row, D7171.BasicName)

                                            setData(sender, getColumIndex(sender, "seUnitPacking"), e.Row, D7231.seUnitPacking)
                                            setData(sender, getColumIndex(sender, "cdUnitPacking"), e.Row, D7231.cdUnitPacking)

                                            Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                            setData(sender, getColumIndex(sender, "cdUnitPackingName"), e.Row, D7171.BasicName)

                                            setData(sender, getColumIndex(sender, "seUnitPrice"), e.Row, D7231.seUnitPrice)
                                            setData(sender, getColumIndex(sender, "cdUnitPrice"), e.Row, D7231.cdUnitPrice)
                                            Call READ_PFK7171(D7231.seUnitPrice, D7231.cdUnitPrice)
                                            setData(sender, getColumIndex(sender, "cdUnitPriceName"), e.Row, D7171.BasicName)

                                            Call READ_PFK7171(D7231.seLargeGroupMaterial, D7231.cdLargeGroupMaterial)
                                            setData(sender, getColumIndex(sender, "cdLargeGroupMaterialName"), e.Row, D7171.BasicName)

                                            Call READ_PFK7171(D7231.seSemiGroupMaterial, D7231.cdSemiGroupMaterial)
                                            setData(sender, getColumIndex(sender, "cdSemiGroupMaterialName"), e.Row, D7171.BasicName)

                                            Call READ_PFK7171(D7231.seDetailGroupMaterial, D7231.cdDetailGroupMaterial)
                                            setData(sender, getColumIndex(sender, "cdDetailGroupMaterialName"), e.Row, D7171.BasicName)

                                            setData(sender, getColumIndex(sender, "Width"), e.Row, D7231.Width)
                                            setData(sender, getColumIndex(sender, "Height"), e.Row, D7231.Height)
                                            setData(sender, getColumIndex(sender, "SizeName"), e.Row, D7231.SizeName)

                                        End If

                                    Next

                                End If

                            End If

                            Exit Sub

                        Case "8" 'Basic Code
                            HLPNA = ListCode(ColumnName) ' Value(1)
                            HLP7171ALL.ShowDialog()


                        Case "9"
                            If HLP7155A.Link_HLP7155A(Value(1)) = False Then Exit Sub

                        Case "A" 'HR Basic Code
                            If HLP4471A.Link_HLP4471A(Value(1)) = False Then Exit Sub

                        Case "B" ' Material Code
                            HLP7231MM.ShowDialog()
                            'If HLP7231T.Link_HLP7231T(Me) = False Then Exit Sub

                            If Array_hlp0000SeVaTt.Count = 0 Then Exit Sub

                            Dim j As Integer = -1

                            For i As Integer = 0 To Array_hlp0000SeVaTt.Count - 1
                                If READ_PFK7231(Array_hlp0000SeVaTt(i)) Then
                                    j += 1

                                    If e.Row + j = Me.ActiveSheet.RowCount - 1 Then
                                        Me.ActiveSheet.RowCount += 1
                                    End If

                                    setData(sender, getColumIndex(Me, "MaterialCode"), e.Row + j, D7231.MaterialCode)

                                    setData(sender, getColumIndex(Me, "MaterialName"), e.Row + j, D7231.MaterialName)
                                    setData(sender, getColumIndex(Me, "MaterialSimple"), e.Row + j, D7231.MaterialSimple)

                                    setData(sender, getColumIndex(sender, "QtyBasic"), e.Row + j, D7231.QtyBasic)

                                    setData(sender, getColumIndex(sender, "seUnitMaterial"), e.Row + j, D7231.seUnitMaterial)
                                    setData(sender, getColumIndex(sender, "cdUnitMaterial"), e.Row + j, D7231.cdUnitMaterial)
                                    Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                    setData(sender, getColumIndex(sender, "cdUnitMaterialName"), e.Row + j, D7171.BasicName)

                                    setData(sender, getColumIndex(sender, "seUnitPacking"), e.Row + j, D7231.seUnitPacking)
                                    setData(sender, getColumIndex(sender, "cdUnitPacking"), e.Row + j, D7231.cdUnitPacking)
                                    Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                    setData(sender, getColumIndex(sender, "cdUnitPackingName"), e.Row + j, D7171.BasicName)

                                    setData(sender, getColumIndex(sender, "seUnitPrice"), e.Row + j, D7231.seUnitPrice)
                                    setData(sender, getColumIndex(sender, "cdUnitPrice"), e.Row + j, D7231.cdUnitPrice)
                                    Call READ_PFK7171(D7231.seUnitPrice, D7231.cdUnitPrice)
                                    setData(sender, getColumIndex(sender, "cdUnitPriceName"), e.Row + j, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seLargeGroupMaterial, D7231.cdLargeGroupMaterial)
                                    setData(sender, getColumIndex(sender, "cdLargeGroupMaterialName"), e.Row + j, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seSemiGroupMaterial, D7231.cdSemiGroupMaterial)
                                    setData(sender, getColumIndex(sender, "cdSemiGroupMaterialName"), e.Row + j, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seDetailGroupMaterial, D7231.cdDetailGroupMaterial)
                                    setData(sender, getColumIndex(sender, "cdDetailGroupMaterialName"), e.Row + j, D7171.BasicName)

                                    setData(sender, getColumIndex(sender, "Width"), e.Row + j, D7231.Width)
                                    setData(sender, getColumIndex(sender, "Height"), e.Row + j, D7231.Height)
                                    setData(sender, getColumIndex(sender, "SizeName"), e.Row + j, D7231.SizeName)
                                End If

                            Next

                            Exit Sub

                        Case "C"
                            Dim MaterialCode As String

                            MaterialCode = getData(sender, getColumIndex(sender, "MaterialCode"), e.Row)

                            If sender.ActiveSheet.ActiveRowIndex < 0 Then Exit Sub

                            If HLP7260A.Link_HLP7260A(MaterialCode, "2") = False Then Exit Sub
                            If READ_PFK7260(D7261.ContractID) Then
                                setData(sender, getColumIndex(sender, "SupplierCode"), e.Row, D7260.CustomerCode)
                                setData(sender, getColumIndex(sender, "PriceMaterial"), e.Row, D7261.PriceMaterialVND)

                                If READ_PFK7101(D7260.CustomerCode) Then
                                    setData(sender, getColumIndex(sender, "SupplierName"), e.Row, D7101.CustomerName)
                                End If

                            End If

                        Case "D" '
                            If HLP7103B.Link_HLP7103B("003", "") = False Then Exit Sub

                            If Array_hlp0000SeVaTt.Count = 0 Then Exit Sub

                            Dim j As Integer = -1

                            For i As Integer = 0 To Array_hlp0000SeVaTt.Count - 1
                                If READ_PFK7103_TYPECODE("003", Array_hlp0000SeVaTt(i)) Then
                                    j += 1

                                    If e.Row + j = Me.ActiveSheet.RowCount - 1 Then
                                        Me.ActiveSheet.RowCount += 1
                                    End If

                                    setData(sender, getColumIndex(Me, "cdTypeCode"), e.Row + j, D7103.cdTypeCode)
                                    setData(sender, getColumIndex(Me, "TypeCode"), e.Row + j, D7103.TypeCode)
                                    setData(sender, getColumIndex(Me, "ComponentName"), e.Row + j, D7103.TypeName)
                                End If

                            Next

                            Exit Sub

                        Case "x" 'Basic Code
                            'DSxxx = Nothing
                            'If HLPxxxxA.Link_HLPxxxxA(Me.FindForm.Name, Value(1)) = False Then Exit Sub
                            'If Value(2) = 0 Then
                            '    Me.Enabled = False
                            '    DATAROW_MOVE(Me.FindForm, DSxxx)
                            'End If
                    End Select

                    If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub

                    If Value(0) = "3" Then
                        setData(sender, e.Column + 1, e.Row, hlp0000SeVaTt)
                        setData(sender, e.Column + 2, e.Row, hlp0000SeVaTt1)
                        setData(sender, e.Column + 3, e.Row, hlp0000SeVa)
                    Else
                        setData(sender, e.Column + 1, e.Row, hlp0000SeVaTt)
                        setData(sender, e.Column + 2, e.Row, hlp0000SeVa)
                    End If

                    'setData(Me, e.Column + 1, e.Row, hlp0000SeVaTt)
                    'setData(Me, e.Column + 2, e.Row, hlp0000SeVa)

                    If D9911.CheckMerge = "1" Then
                        For i As Integer = 0 To e.Row - 1
                            If FormatCut(getData(sender, e.Column + 1, i)) = "" Then
                                If Value(0) = "3" Then
                                    setData(sender, e.Column + 1, i, hlp0000SeVaTt)
                                    setData(sender, e.Column + 2, i, hlp0000SeVaTt1)
                                    setData(sender, e.Column + 3, i, hlp0000SeVa)
                                Else
                                    setData(sender, e.Column + 1, i, hlp0000SeVaTt)
                                    setData(sender, e.Column + 2, i, hlp0000SeVa)
                                End If

                            End If

                        Next

                    End If

                End If
            End If


        Catch ex As Exception

        End Try
    End Sub

    Public chk_CC As Boolean = True

    Overridable Sub PeaceFarpoint_CellClick(sender As Object, e As CellClickEventArgs) Handles Me.CellClick
        If chk_CC = False Then Exit Sub

        'If e.ColumnHeader Or e.RowHeader Then Exit Sub
        Me.ActiveSheet.ActiveRowIndex = e.Row
        Me.ActiveSheet.ActiveColumnIndex = e.Column
        Me.ActiveSheet.AddSelection(e.Row, e.Column, 1, 1)


    End Sub

    Private Sub PeaceFarpoint_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Me.CellDoubleClick
        Try
            If chk_KeyControl = True Then
                Call SpreadP1_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.Q))
                chk_KeyControl = False
            End If

            If e.ColumnHeader = True And e.Column = getColumIndex(sender, "CheckUse") Then
                SPR_HEADCHK(sender, e, e.Column)

            ElseIf e.ColumnHeader = True And e.Column = getColumIndex(sender, "Dchk") Then
                SPR_HEADCHK(sender, e, e.Column)

            ElseIf e.ColumnHeader = True And e.Column = getColumIndex(sender, "CheckComplete") Then
                SPR_HEADCHK(sender, e, e.Column)

            ElseIf e.Column = getColumIndex(sender, "SpecNoSeqCF") Then


            End If

            If Me.ActiveSheet.Columns(e.Column).Tag.ToString.ToUpper.Contains("DATE") Then
                If Me.ActiveSheet.Columns(e.Column).Locked = False Then
                    Dim xCOL, xRow As Integer

                    xCOL = e.Column
                    xRow = e.Row
                    If Me.ActiveSheet.Columns(e.Row).Locked = False Then
                        If CALENDAR_SINGLE.CALENDAR_SINGLE_Link(getData(Me, xCOL, xRow)) = False Then Exit Sub
                        If CIntp(syearn) = 0 Or CIntp(smonth) = 0 Or CIntp(sday) = 0 Then Exit Sub

                        Dim CalDate As String
                        CalDate = syearn.ToString & smonth.ToString("00") & sday.ToString("00")
                        setData(Me, xCOL, xRow, FSDate(CalDate))
                        setCell(Me, xCOL, xRow, CalDate)
                        Me.ActiveSheet.ActiveRowIndex = xRow
                        Me.Focus()
                    End If

                End If
            End If

        Catch ex As Exception

        End Try

    End Sub




    Private Sub SpreadP1_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleCreated

        SetDefault()

        'SPR_KEY(Me, Keys.Enter, FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        'SPR_KEY(Me, Keys.Left, FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumn)
        'SPR_KEY(Me, Keys.Right, FarPoint.Win.Spread.SpreadActions.MoveToNextColumn)

    End Sub

#End Region

#Region "Default"
    Private Sub HeaderDefault()
        Me.ActiveSheet.ColumnHeader.DefaultStyle = Nothing
        Me.ActiveSheet.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.ActiveSheet.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ActiveSheet.ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.ActiveSheet.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.ActiveSheet.ColumnHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.ActiveSheet.ColumnHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.ActiveSheet.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
    End Sub
    Private Sub SetDefault()
        Dim StrFormName As String

        Try
            If CheckIni = False Then
                Me.Font = New Font("Tahoma", 9, FontStyle.Regular)
                Me.ActiveSheet.DefaultStyle.Font = New Font("Tahoma", 9, FontStyle.Regular)
                Me.ActiveSheet.Rows(-1).Height = cSprRowHeight
                Me.ActiveSheet.Rows(-1).VerticalAlignment = CellVerticalAlignment.Center

                StrFormName = Me.FindForm.Name

                If StrFormName.Contains("PFP") Then
                    If StrFormName.Length > 8 Then
                        StrFormName = Strings.Left(StrFormName, 8)
                    End If
                End If

                If READ_PFK9916_1(StrFormName, Me.Name) Then
                    If D9916.CheckDev = "1" Then Call SPR_PRO_LOAD(Me, "DMS", D9916.REMK, Me.Name)
                End If

                Dim ct As New CellType.TextCellType
                ct.WordWrap = True

                Me.ActiveSheet.RowHeader.Columns(-1).CellType = ct
                Me.ActiveSheet.RowHeader.Columns(-1).Font = New Font("Tahoma", 9, FontStyle.Regular)

                Me.ActiveSheet.ColumnHeader.Rows(-1).CellType = ct
                Me.ActiveSheet.ColumnHeader.Rows(-1).Font = New Font("Tahoma", 9, FontStyle.Regular)

                Me.ActiveSheet.LockBackColor = Color.Empty
                Me.ActiveSheet.GrayAreaBackColor = Color.White
                CheckIni = True

                Me.ClipboardOptions = Spread.ClipboardOptions.NoHeaders
                Me.AllowDragFill = True

                If CheckInputMap = False Then
                    Call SPR_KEY_ANCESTOR(Me, Keys.Enter, FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
                    Call SPR_KEY_ANCESTOR(Me, Keys.F2, FarPoint.Win.Spread.SpreadActions.StartEditing)
                End If

            End If

            Me.ActiveSheet.SelectionStyle = SelectionStyles.SelectionColors
            Me.ActiveSheet.SelectionBackColor = cSprSelectionBackColor
            Me.FocusRenderer = New FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer(1)
        Catch ex As Exception

        End Try

    End Sub

#End Region

    Public Property SpreadWjob() As Integer
        Get
            Return i_SpreadWJOB
        End Get
        Set(ByVal value As Integer)
            i_SpreadWJOB = value
            i_SpreadWJOB = wJOB
        End Set
    End Property
    Public Property InsChk() As Boolean
        Get
            Return InsertChk
        End Get
        Set(ByVal value As Boolean)
            InsertChk = value
        End Set
    End Property
    Public Property CopyPasteChk() As Boolean
        Get
            Return CopyChk
        End Get
        Set(ByVal value As Boolean)
            CopyChk = value
        End Set
    End Property

    Private Sub fpSpread1_Grouped(sender As Object, e As EventArgs)
        Dim gdm As FarPoint.Win.Spread.Model.GroupDataModel
        gdm = DirectCast(Me.ActiveSheet.Models.Data, FarPoint.Win.Spread.Model.GroupDataModel)
        gdm.GroupFooterVisible = True

        Dim i, j As Integer

        For i = 0 To gdm.Groups.Count - 1
            For j = 0 To Me.ActiveSheet.ColumnCount - 1
                If TypeOf Me.ActiveSheet.Columns(j).CellType Is FarPoint.Win.Spread.CellType.NumberCellType Then
                    Dim g1 As FarPoint.Win.Spread.Model.Group = DirectCast(gdm.Groups(i), FarPoint.Win.Spread.Model.Group)

                    DirectCast(g1.GroupFooter.DataModel, FarPoint.Win.Spread.Model.IAggregationSupport).SetCellAggregationType(0, j, FarPoint.Win.Spread.Model.AggregationType.Sum)
                    DirectCast(g1.GroupFooter.DataModel, FarPoint.Win.Spread.Model.IAggregationSupport).SetCellAggregationFormat(0, j, "{0:#,###}")

                    Me.ActiveSheet.Models.Data = gdm


                End If
            Next
        Next

    End Sub
    Private Sub HLPOpen(xCol As Integer, xRow As Integer, ControlName As String)
        Dim FormName As String

        FormName = Me.FindForm.Name

        Try

            TranValue = getData(Me, xCol, xRow)

            If TranValue = "" Then
                setData(Me, xCol - 1, xRow, "")
                setData(Me, xCol, xRow, "")
                Exit Sub
            End If

            If ControlName.Length > 5 Then
                If READ_PFK9911(ControlName) Then
                    If D9911.CheckDev = "1" Then
                        Dim Value() As String
                        Value = D9911.CheckDevValue.Split(";")

                        Select Case Value(0)
                            Case "1" ' Customer
                                TranValue = getData(Me, xCol, xRow)

                                If IsNumeric(TranValue) Then
                                    If READ_PFK7101_CODE(TranValue) = True Then

                                        setData(Me, xCol - 1, xRow, D7101.CustomerCode)
                                        setData(Me, xCol, xRow, D7101.CustomerName)

                                        GoTo KeyTab1
                                    End If
                                Else
                                    If READ_PFK7101_NAME(TranValue) = True Then
                                        setData(Me, xCol - 1, xRow, D7101.CustomerCode)
                                        setData(Me, xCol, xRow, D7101.CustomerName)

                                        GoTo KeyTab1
                                    End If
                                End If

                                If HLP7101A.Link_HLP7101A(TranValue) = False Then
                                    setData(Me, xCol - 1, xRow, "")
                                    setData(Me, xCol, xRow, "")
                                    Exit Sub
                                End If

                                If READ_PFK7101(hlp0000SeVaTt) Then
                                    setData(Me, xCol - 1, xRow, D7101.CustomerCode)
                                    setData(Me, xCol, xRow, D7101.CustomerName)

                                    GoTo KeyTab1
                                End If

KeyTab1:


                            Case "2" ' ColorCode
                                TranValue = getData(Me, xCol, xRow)

                                If IsNumeric(TranValue) Then
                                    If READ_PFK7121(CIntp(TranValue).ToString("000000")) = True Then

                                        setData(Me, xCol - 1, xRow, D7121.ColorCode)
                                        setData(Me, xCol, xRow, D7121.ColorName)

                                        Exit Sub

                                    End If
                                Else
                                    If READ_PFK7121_NAME(TranValue) = True Then
                                        setData(Me, xCol - 1, xRow, D7121.ColorCode)
                                        setData(Me, xCol, xRow, D7121.ColorName)

                                        Exit Sub

                                    End If
                                End If

                                If HLP7121A.Link_HLP7121A(TranValue) = False Then
                                    setData(Me, xCol - 1, xRow, "")
                                    setData(Me, xCol, xRow, "")
                                    Exit Sub
                                End If

                                If READ_PFK7121(hlp0000SeVaTt) Then
                                    setData(Me, xCol - 1, xRow, D7121.ColorCode)
                                    setData(Me, xCol, xRow, D7121.ColorName)

                                    Exit Sub
                                End If

                            Case "3" ' Type Code
                                If Value.Length > 1 Then HLPNA = Value(1)

                                TranValue = getData(Me, xCol, xRow)

                                If IsNumeric(TranValue) Then
                                    If READ_PFK7103_TYPECODE(HLPNA, TranValue) = True Then

                                        setData(Me, xCol - 1, xRow, D7103.TypeCode)
                                        setData(Me, xCol, xRow, D7103.TypeName)

                                        GoTo KeyTab3

                                    End If
                                Else
                                    If READ_PFK7103_TYPENAME(HLPNA, TranValue) = True Then
                                        setData(Me, xCol - 1, xRow, D7103.TypeCode)
                                        setData(Me, xCol, xRow, D7103.TypeName)

                                        GoTo KeyTab3

                                    End If
                                End If

                                If HLP7103A.Link_HLP7103A(HLPNA, TranValue) = False Then
                                    setData(Me, xCol - 1, xRow, D7103.TypeCode)
                                    setData(Me, xCol, xRow, D7103.TypeName)

                                    Exit Sub
                                End If

                                If READ_PFK7103_TYPECODE(HLPNA, hlp0000SeVaTt) Then
                                    setData(Me, xCol - 1, xRow, D7103.TypeCode)
                                    setData(Me, xCol, xRow, D7103.TypeName)

                                    GoTo KeyTab3

                                End If
KeyTab3:
                                If D9911.CheckMerge = "1" Then
                                    For i As Integer = 0 To xRow - 1
                                        If FormatCut(getData(Me, xCol, i)) = "" Then
                                            setData(Me, xCol - 1, i, D7103.TypeCode)
                                            setData(Me, xCol, i, D7103.TypeName)
                                        End If
                                    Next

                                End If


                            Case "4" ' Tool Code
                                If Value.Length > 1 Then HLPNA = Value(1)

                                TranValue = getData(Me, xCol, xRow)

                                If IsNumeric(TranValue) Then
                                    If READ_PFK7156_CODE(HLPNA, TranValue) = True Then

                                        setData(Me, xCol - 1, xRow, D7156.ToolCode)
                                        setData(Me, xCol, xRow, D7156.ToolName)

                                        GoTo KeyTab4

                                    End If
                                Else
                                    If READ_PFK7156_NAME(HLPNA, TranValue) = True Then
                                        setData(Me, xCol - 1, xRow, D7156.ToolCode)
                                        setData(Me, xCol, xRow, D7156.ToolName)

                                        GoTo KeyTab4

                                    End If
                                End If

                                If HLP7156A.Link_HLP7156A(HLPNA, TranValue) = False Then
                                    setData(Me, xCol - 1, xRow, D7156.ToolCode)
                                    setData(Me, xCol, xRow, D7156.ToolName)

                                    Exit Sub
                                End If

                                If READ_PFK7156_CODE(HLPNA, hlp0000SeVaTt) Then
                                    setData(Me, xCol - 1, xRow, D7156.ToolCode)
                                    setData(Me, xCol, xRow, D7156.ToolName)

                                    GoTo KeyTab4

                                End If
KeyTab4:
                                If D9911.CheckMerge = "1" Then
                                    For i As Integer = 0 To xRow - 1
                                        If FormatCut(getData(Me, xCol, i)) = "" Then
                                            setData(Me, xCol - 1, i, D7156.ToolCode)
                                            setData(Me, xCol, i, D7156.ToolName)
                                        End If
                                    Next

                                End If

                            Case "5" ' RNDcODE
                                Exit Sub
                                'If HLP7102A.Link_HLP7102A("2") = False Then Exit Sub
                                TranValue = getData(Me, xCol, xRow)

                                If IsNumeric(TranValue) Then
                                    If READ_PFK7231_CODE(TranValue) = True Then

                                        If CheckMaterialAll() = False Then setData(Me, getColumIndex(Me, "MaterialCode"), xRow, "") : setData(Me, getColumIndex(Me, "MaterialName"), xRow, "") : Exit Sub

                                        setData(Me, xCol - 1, xRow, D7231.MaterialCode)
                                        setData(Me, xCol, xRow, D7231.MaterialName)

                                        setData(Me, getColumIndex(Me, "MaterialCode"), xRow, D7231.MaterialCode)
                                        setData(Me, getColumIndex(Me, "MaterialName"), xRow, D7231.MaterialName)

                                        setData(Me, getColumIndex(Me, "MaterialSimple"), xRow, D7231.MaterialSimple)

                                        setData(Me, getColumIndex(Me, "QtyBasic"), xRow, D7231.QtyBasic)

                                        setData(Me, getColumIndex(Me, "seUnitMaterial"), xRow, D7231.seUnitMaterial)
                                        setData(Me, getColumIndex(Me, "cdUnitMaterial"), xRow, D7231.cdUnitMaterial)
                                        Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                        setData(Me, getColumIndex(Me, "cdUnitMaterialName"), xRow, D7171.BasicName)

                                        setData(Me, getColumIndex(Me, "seUnitPacking"), xRow, D7231.seUnitPacking)
                                        setData(Me, getColumIndex(Me, "cdUnitPacking"), xRow, D7231.cdUnitPacking)
                                        Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                        setData(Me, getColumIndex(Me, "cdUnitPackingName"), xRow, D7171.BasicName)

                                        setData(Me, getColumIndex(Me, "Width"), xRow, D7231.Width)
                                        setData(Me, getColumIndex(Me, "Height"), xRow, D7231.Height)
                                        setData(Me, getColumIndex(Me, "SizeName"), xRow, D7231.SizeName)

                                        GoTo KeyTab5

                                    End If
                                Else
                                    If READ_PFK7231_NAME(TranValue) = True Then
                                        setData(Me, xCol - 1, xRow, D7231.MaterialCode)

                                        If CheckMaterialAll() = False Then setData(Me, getColumIndex(Me, "MaterialCode"), xRow, "") : setData(Me, getColumIndex(Me, "MaterialName"), xRow, "") : Exit Sub

                                        setData(Me, xCol, xRow, D7231.MaterialName)

                                        setData(Me, getColumIndex(Me, "MaterialCode"), xRow, D7231.MaterialCode)
                                        setData(Me, getColumIndex(Me, "MaterialName"), xRow, D7231.MaterialName)

                                        setData(Me, getColumIndex(Me, "MaterialSimple"), xRow, D7231.MaterialSimple)

                                        setData(Me, getColumIndex(Me, "seUnitMaterial"), xRow, D7231.seUnitMaterial)
                                        setData(Me, getColumIndex(Me, "cdUnitMaterial"), xRow, D7231.cdUnitMaterial)
                                        Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                        setData(Me, getColumIndex(Me, "cdUnitMaterialName"), xRow, D7171.BasicName)

                                        setData(Me, getColumIndex(Me, "seUnitPacking"), xRow, D7231.seUnitPacking)
                                        setData(Me, getColumIndex(Me, "cdUnitPacking"), xRow, D7231.cdUnitPacking)
                                        Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                        setData(Me, getColumIndex(Me, "cdUnitPackingName"), xRow, D7171.BasicName)


                                        setData(Me, getColumIndex(Me, "Width"), xRow, D7231.Width)
                                        setData(Me, getColumIndex(Me, "Height"), xRow, D7231.Height)
                                        setData(Me, getColumIndex(Me, "SizeName"), xRow, D7231.SizeName)

                                        GoTo KeyTab5

                                    End If
                                End If

                                If HLP7231F.Link_HLP7231F(TranValue) = False Then
                                    setData(Me, xCol - 1, xRow, "")
                                    setData(Me, xCol, xRow, "")
                                    Exit Sub
                                End If

                                If READ_PFK7231(hlp0000SeVaTt) Then
                                    setData(Me, xCol - 1, xRow, D7231.MaterialCode)

                                    If CheckMaterialAll() = False Then setData(Me, getColumIndex(Me, "MaterialCode"), xRow, "") : setData(Me, getColumIndex(Me, "MaterialName"), xRow, "") : Exit Sub

                                    setData(Me, xCol, xRow, D7231.MaterialName)
                                    setData(Me, getColumIndex(Me, "MaterialCode"), xRow, D7231.MaterialCode)
                                    setData(Me, getColumIndex(Me, "MaterialName"), xRow, D7231.MaterialName)
                                    setData(Me, getColumIndex(Me, "MaterialSimple"), xRow, D7231.MaterialSimple)

                                    setData(Me, getColumIndex(Me, "QtyBasic"), xRow, D7231.QtyBasic)

                                    setData(Me, getColumIndex(Me, "seUnitMaterial"), xRow, D7231.seUnitMaterial)
                                    setData(Me, getColumIndex(Me, "cdUnitMaterial"), xRow, D7231.cdUnitMaterial)
                                    Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                    setData(Me, getColumIndex(Me, "cdUnitMaterialName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "seUnitPacking"), xRow, D7231.seUnitPacking)
                                    setData(Me, getColumIndex(Me, "cdUnitPacking"), xRow, D7231.cdUnitPacking)
                                    Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                    setData(Me, getColumIndex(Me, "cdUnitPackingName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "Width"), xRow, D7231.Width)
                                    setData(Me, getColumIndex(Me, "Height"), xRow, D7231.Height)
                                    setData(Me, getColumIndex(Me, "SizeName"), xRow, D7231.SizeName)

                                    GoTo KeyTab5
                                End If

KeyTab5:
                                If D9911.CheckMerge = "1" Then
                                    For i As Integer = 0 To xRow - 1
                                        If FormatCut(getData(Me, xCol, i)) = "" Then
                                            setData(Me, xCol - 1, i, D7231.MaterialCode)
                                            setData(Me, xCol, i, D7231.MaterialName)

                                            setData(Me, getColumIndex(Me, "MaterialCode"), xRow, D7231.MaterialCode)
                                            setData(Me, getColumIndex(Me, "MaterialName"), xRow, D7231.MaterialName)
                                            setData(Me, getColumIndex(Me, "MaterialSimple"), xRow, D7231.MaterialSimple)

                                            setData(Me, getColumIndex(Me, "QtyBasic"), xRow, D7231.QtyBasic)

                                            setData(Me, getColumIndex(Me, "seUnitMaterial"), xRow, D7231.seUnitMaterial)
                                            setData(Me, getColumIndex(Me, "cdUnitMaterial"), xRow, D7231.cdUnitMaterial)
                                            Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                            setData(Me, getColumIndex(Me, "cdUnitMaterialName"), xRow, D7171.BasicName)

                                            setData(Me, getColumIndex(Me, "seUnitPacking"), xRow, D7231.seUnitPacking)
                                            setData(Me, getColumIndex(Me, "cdUnitPacking"), xRow, D7231.cdUnitPacking)
                                            Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                            setData(Me, getColumIndex(Me, "cdUnitPackingName"), xRow, D7171.BasicName)

                                            setData(Me, getColumIndex(Me, "Width"), xRow, D7231.Width)
                                            setData(Me, getColumIndex(Me, "Height"), xRow, D7231.Height)
                                            setData(Me, getColumIndex(Me, "SizeName"), xRow, D7231.SizeName)
                                        End If
                                    Next

                                End If

                            Case "6" 'HR CODE
                                HLPNA = Value(1)
                                HLP0002.ShowDialog()

                            Case "7", "B" ' 
                                TranValue = getData(Me, xCol, xRow)

                                If IsNumeric(TranValue) Then
                                    If READ_PFK7231_CODE(TranValue) = True Then

                                        If CheckMaterialAll() = False Then setData(Me, getColumIndex(Me, "MaterialCode"), xRow, "") : setData(Me, getColumIndex(Me, "MaterialName"), xRow, "") : Exit Sub

                                        setData(Me, xCol - 1, xRow, D7231.MaterialCode)
                                        setData(Me, xCol, xRow, D7231.MaterialName)

                                        setData(Me, getColumIndex(Me, "MaterialCode"), xRow, D7231.MaterialCode)
                                        setData(Me, getColumIndex(Me, "MaterialName"), xRow, D7231.MaterialName)

                                        setData(Me, getColumIndex(Me, "MaterialSimple"), xRow, D7231.MaterialSimple)

                                        setData(Me, getColumIndex(Me, "QtyBasic"), xRow, D7231.QtyBasic)

                                        setData(Me, getColumIndex(Me, "seUnitMaterial"), xRow, D7231.seUnitMaterial)
                                        setData(Me, getColumIndex(Me, "cdUnitMaterial"), xRow, D7231.cdUnitMaterial)
                                        Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                        setData(Me, getColumIndex(Me, "cdUnitMaterialName"), xRow, D7171.BasicName)

                                        setData(Me, getColumIndex(Me, "seUnitPacking"), xRow, D7231.seUnitPacking)
                                        setData(Me, getColumIndex(Me, "cdUnitPacking"), xRow, D7231.cdUnitPacking)
                                        Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                        setData(Me, getColumIndex(Me, "cdUnitPackingName"), xRow, D7171.BasicName)

                                        setData(Me, getColumIndex(Me, "seUnitPrice"), xRow, D7231.seUnitPrice)
                                        setData(Me, getColumIndex(Me, "cdUnitPrice"), xRow, D7231.cdUnitPrice)
                                        Call READ_PFK7171(D7231.seUnitPrice, D7231.cdUnitPrice)
                                        setData(Me, getColumIndex(Me, "cdUnitPriceName"), xRow, D7171.BasicName)

                                        Call READ_PFK7171(D7231.seLargeGroupMaterial, D7231.cdLargeGroupMaterial)
                                        setData(Me, getColumIndex(Me, "cdLargeGroupMaterialName"), xRow, D7171.BasicName)

                                        Call READ_PFK7171(D7231.seSemiGroupMaterial, D7231.cdSemiGroupMaterial)
                                        setData(Me, getColumIndex(Me, "cdSemiGroupMaterialName"), xRow, D7171.BasicName)

                                        Call READ_PFK7171(D7231.seDetailGroupMaterial, D7231.cdDetailGroupMaterial)
                                        setData(Me, getColumIndex(Me, "cdDetailGroupMaterialName"), xRow, D7171.BasicName)

                                        setData(Me, getColumIndex(Me, "Width"), xRow, D7231.Width)
                                        setData(Me, getColumIndex(Me, "Height"), xRow, D7231.Height)
                                        setData(Me, getColumIndex(Me, "SizeName"), xRow, D7231.SizeName)

                                        GoTo KeyTab7

                                    End If
                                ElseIf READ_PFK7231_NAME(TranValue) = True Then
                                    If CheckMaterialAll() = False Then setData(Me, getColumIndex(Me, "MaterialCode"), xRow, "") : setData(Me, getColumIndex(Me, "MaterialName"), xRow, "") : Exit Sub

                                    setData(Me, xCol - 1, xRow, D7231.MaterialCode)
                                    setData(Me, xCol, xRow, D7231.MaterialName)

                                    setData(Me, getColumIndex(Me, "MaterialCode"), xRow, D7231.MaterialCode)
                                    setData(Me, getColumIndex(Me, "MaterialName"), xRow, D7231.MaterialName)
                                    setData(Me, getColumIndex(Me, "MaterialSimple"), xRow, D7231.MaterialSimple)

                                    setData(Me, getColumIndex(Me, "QtyBasic"), xRow, D7231.QtyBasic)

                                    setData(Me, getColumIndex(Me, "seUnitMaterial"), xRow, D7231.seUnitMaterial)
                                    setData(Me, getColumIndex(Me, "cdUnitMaterial"), xRow, D7231.cdUnitMaterial)
                                    Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                    setData(Me, getColumIndex(Me, "cdUnitMaterialName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "seUnitPacking"), xRow, D7231.seUnitPacking)
                                    setData(Me, getColumIndex(Me, "cdUnitPacking"), xRow, D7231.cdUnitPacking)
                                    Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                    setData(Me, getColumIndex(Me, "cdUnitPackingName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "seUnitPrice"), xRow, D7231.seUnitPrice)
                                    setData(Me, getColumIndex(Me, "cdUnitPrice"), xRow, D7231.cdUnitPrice)
                                    Call READ_PFK7171(D7231.seUnitPrice, D7231.cdUnitPrice)
                                    setData(Me, getColumIndex(Me, "cdUnitPriceName"), xRow, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seLargeGroupMaterial, D7231.cdLargeGroupMaterial)
                                    setData(Me, getColumIndex(Me, "cdLargeGroupMaterialName"), xRow, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seSemiGroupMaterial, D7231.cdSemiGroupMaterial)
                                    setData(Me, getColumIndex(Me, "cdSemiGroupMaterialName"), xRow, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seDetailGroupMaterial, D7231.cdDetailGroupMaterial)
                                    setData(Me, getColumIndex(Me, "cdDetailGroupMaterialName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "Width"), xRow, D7231.Width)
                                    setData(Me, getColumIndex(Me, "Height"), xRow, D7231.Height)
                                    setData(Me, getColumIndex(Me, "SizeName"), xRow, D7231.SizeName)

                                    GoTo KeyTab7

                                ElseIf READ_PFK7231_NAME_FULLNAME(TranValue) = True Then
                                    If CheckMaterialAll() = False Then setData(Me, getColumIndex(Me, "MaterialCode"), xRow, "") : setData(Me, getColumIndex(Me, "MaterialName"), xRow, "") : Exit Sub

                                    setData(Me, xCol - 1, xRow, D7231.MaterialCode)
                                    setData(Me, xCol, xRow, D7231.MaterialName)

                                    setData(Me, getColumIndex(Me, "MaterialCode"), xRow, D7231.MaterialCode)
                                    setData(Me, getColumIndex(Me, "MaterialName"), xRow, D7231.MaterialName)
                                    setData(Me, getColumIndex(Me, "MaterialSimple"), xRow, D7231.MaterialSimple)

                                    setData(Me, getColumIndex(Me, "QtyBasic"), xRow, D7231.QtyBasic)

                                    setData(Me, getColumIndex(Me, "seUnitMaterial"), xRow, D7231.seUnitMaterial)
                                    setData(Me, getColumIndex(Me, "cdUnitMaterial"), xRow, D7231.cdUnitMaterial)
                                    Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                    setData(Me, getColumIndex(Me, "cdUnitMaterialName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "seUnitPacking"), xRow, D7231.seUnitPacking)
                                    setData(Me, getColumIndex(Me, "cdUnitPacking"), xRow, D7231.cdUnitPacking)
                                    Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                    setData(Me, getColumIndex(Me, "cdUnitPackingName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "seUnitPrice"), xRow, D7231.seUnitPrice)
                                    setData(Me, getColumIndex(Me, "cdUnitPrice"), xRow, D7231.cdUnitPrice)
                                    Call READ_PFK7171(D7231.seUnitPrice, D7231.cdUnitPrice)
                                    setData(Me, getColumIndex(Me, "cdUnitPriceName"), xRow, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seLargeGroupMaterial, D7231.cdLargeGroupMaterial)
                                    setData(Me, getColumIndex(Me, "cdLargeGroupMaterialName"), xRow, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seSemiGroupMaterial, D7231.cdSemiGroupMaterial)
                                    setData(Me, getColumIndex(Me, "cdSemiGroupMaterialName"), xRow, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seDetailGroupMaterial, D7231.cdDetailGroupMaterial)
                                    setData(Me, getColumIndex(Me, "cdDetailGroupMaterialName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "Width"), xRow, D7231.Width)
                                    setData(Me, getColumIndex(Me, "Height"), xRow, D7231.Height)
                                    setData(Me, getColumIndex(Me, "SizeName"), xRow, D7231.SizeName)

                                    GoTo KeyTab7

                                ElseIf READ_PFK7231_CHECKNAME_FULL(TranValue) = True Then
                                    If CheckMaterialAll() = False Then setData(Me, getColumIndex(Me, "MaterialCode"), xRow, "") : setData(Me, getColumIndex(Me, "MaterialName"), xRow, "") : Exit Sub

                                    setData(Me, xCol - 1, xRow, D7231.MaterialCode)
                                    setData(Me, xCol, xRow, D7231.MaterialName)

                                    setData(Me, getColumIndex(Me, "MaterialCode"), xRow, D7231.MaterialCode)
                                    setData(Me, getColumIndex(Me, "MaterialName"), xRow, D7231.MaterialName)
                                    setData(Me, getColumIndex(Me, "MaterialSimple"), xRow, D7231.MaterialSimple)

                                    setData(Me, getColumIndex(Me, "QtyBasic"), xRow, D7231.QtyBasic)

                                    setData(Me, getColumIndex(Me, "seUnitMaterial"), xRow, D7231.seUnitMaterial)
                                    setData(Me, getColumIndex(Me, "cdUnitMaterial"), xRow, D7231.cdUnitMaterial)
                                    Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                    setData(Me, getColumIndex(Me, "cdUnitMaterialName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "seUnitPacking"), xRow, D7231.seUnitPacking)
                                    setData(Me, getColumIndex(Me, "cdUnitPacking"), xRow, D7231.cdUnitPacking)
                                    Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                    setData(Me, getColumIndex(Me, "cdUnitPackingName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "seUnitPrice"), xRow, D7231.seUnitPrice)
                                    setData(Me, getColumIndex(Me, "cdUnitPrice"), xRow, D7231.cdUnitPrice)
                                    Call READ_PFK7171(D7231.seUnitPrice, D7231.cdUnitPrice)
                                    setData(Me, getColumIndex(Me, "cdUnitPriceName"), xRow, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seLargeGroupMaterial, D7231.cdLargeGroupMaterial)
                                    setData(Me, getColumIndex(Me, "cdLargeGroupMaterialName"), xRow, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seSemiGroupMaterial, D7231.cdSemiGroupMaterial)
                                    setData(Me, getColumIndex(Me, "cdSemiGroupMaterialName"), xRow, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seDetailGroupMaterial, D7231.cdDetailGroupMaterial)
                                    setData(Me, getColumIndex(Me, "cdDetailGroupMaterialName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "Width"), xRow, D7231.Width)
                                    setData(Me, getColumIndex(Me, "Height"), xRow, D7231.Height)
                                    setData(Me, getColumIndex(Me, "SizeName"), xRow, D7231.SizeName)

                                    GoTo KeyTab7
                                End If

                                If HLP7231C.Link_HLP7231C(TranValue) = False Then
                                    setData(Me, xCol - 1, xRow, "")
                                    setData(Me, xCol, xRow, "")
                                    Exit Sub
                                End If

                                If READ_PFK7231(hlp0000SeVaTt) Then
                                    setData(Me, xCol - 1, xRow, D7231.MaterialCode)

                                    If CheckMaterialAll() = False Then setData(Me, getColumIndex(Me, "MaterialCode"), xRow, "") : setData(Me, getColumIndex(Me, "MaterialName"), xRow, "") : Exit Sub

                                    setData(Me, xCol, xRow, D7231.MaterialName)
                                    setData(Me, getColumIndex(Me, "MaterialCode"), xRow, D7231.MaterialCode)
                                    setData(Me, getColumIndex(Me, "MaterialName"), xRow, D7231.MaterialName)
                                    setData(Me, getColumIndex(Me, "MaterialSimple"), xRow, D7231.MaterialSimple)

                                    setData(Me, getColumIndex(Me, "QtyBasic"), xRow, D7231.QtyBasic)

                                    setData(Me, getColumIndex(Me, "seUnitMaterial"), xRow, D7231.seUnitMaterial)
                                    setData(Me, getColumIndex(Me, "cdUnitMaterial"), xRow, D7231.cdUnitMaterial)
                                    Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                    setData(Me, getColumIndex(Me, "cdUnitMaterialName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "seUnitPacking"), xRow, D7231.seUnitPacking)
                                    setData(Me, getColumIndex(Me, "cdUnitPacking"), xRow, D7231.cdUnitPacking)
                                    Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                    setData(Me, getColumIndex(Me, "cdUnitPackingName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "seUnitPrice"), xRow, D7231.seUnitPrice)
                                    setData(Me, getColumIndex(Me, "cdUnitPrice"), xRow, D7231.cdUnitPrice)
                                    Call READ_PFK7171(D7231.seUnitPrice, D7231.cdUnitPrice)
                                    setData(Me, getColumIndex(Me, "cdUnitPriceName"), xRow, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seLargeGroupMaterial, D7231.cdLargeGroupMaterial)
                                    setData(Me, getColumIndex(Me, "cdLargeGroupMaterialName"), xRow, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seSemiGroupMaterial, D7231.cdSemiGroupMaterial)
                                    setData(Me, getColumIndex(Me, "cdSemiGroupMaterialName"), xRow, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seDetailGroupMaterial, D7231.cdDetailGroupMaterial)
                                    setData(Me, getColumIndex(Me, "cdDetailGroupMaterialName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "Width"), xRow, D7231.Width)
                                    setData(Me, getColumIndex(Me, "Height"), xRow, D7231.Height)
                                    setData(Me, getColumIndex(Me, "SizeName"), xRow, D7231.SizeName)

                                    GoTo KeyTab7
                                End If

KeyTab7:
                                If D9911.CheckMerge = "1" Then
                                    For i As Integer = 0 To xRow - 1
                                        If FormatCut(getData(Me, xCol, i)) = "" Then
                                            setData(Me, xCol - 1, i, D7231.MaterialCode)
                                            setData(Me, xCol, i, D7231.MaterialName)
                                            setData(Me, getColumIndex(Me, "MaterialCode"), xRow, D7231.MaterialCode)
                                            setData(Me, getColumIndex(Me, "MaterialName"), xRow, D7231.MaterialName)
                                            setData(Me, getColumIndex(Me, "MaterialSimple"), xRow, D7231.MaterialSimple)

                                            setData(Me, getColumIndex(Me, "QtyBasic"), xRow, D7231.QtyBasic)

                                            setData(Me, getColumIndex(Me, "seUnitMaterial"), xRow, D7231.seUnitMaterial)
                                            setData(Me, getColumIndex(Me, "cdUnitMaterial"), xRow, D7231.cdUnitMaterial)
                                            Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                            setData(Me, getColumIndex(Me, "cdUnitMaterialName"), xRow, D7171.BasicName)

                                            setData(Me, getColumIndex(Me, "seUnitPacking"), xRow, D7231.seUnitPacking)
                                            setData(Me, getColumIndex(Me, "cdUnitPacking"), xRow, D7231.cdUnitPacking)
                                            Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                            setData(Me, getColumIndex(Me, "cdUnitPackingName"), xRow, D7171.BasicName)

                                            setData(Me, getColumIndex(Me, "seUnitPrice"), xRow, D7231.seUnitPrice)
                                            setData(Me, getColumIndex(Me, "cdUnitPrice"), xRow, D7231.cdUnitPrice)
                                            Call READ_PFK7171(D7231.seUnitPrice, D7231.cdUnitPrice)
                                            setData(Me, getColumIndex(Me, "cdUnitPriceName"), xRow, D7171.BasicName)

                                            Call READ_PFK7171(D7231.seLargeGroupMaterial, D7231.cdLargeGroupMaterial)
                                            setData(Me, getColumIndex(Me, "cdLargeGroupMaterialName"), xRow, D7171.BasicName)

                                            Call READ_PFK7171(D7231.seSemiGroupMaterial, D7231.cdSemiGroupMaterial)
                                            setData(Me, getColumIndex(Me, "cdSemiGroupMaterialName"), xRow, D7171.BasicName)

                                            Call READ_PFK7171(D7231.seDetailGroupMaterial, D7231.cdDetailGroupMaterial)
                                            setData(Me, getColumIndex(Me, "cdDetailGroupMaterialName"), xRow, D7171.BasicName)

                                            setData(Me, getColumIndex(Me, "Width"), xRow, D7231.Width)
                                            setData(Me, getColumIndex(Me, "Height"), xRow, D7231.Height)
                                            setData(Me, getColumIndex(Me, "SizeName"), xRow, D7231.SizeName)
                                        End If
                                    Next

                                End If

                            Case "8" 'Basic Code
                                HLPNA = ListCode(Strings.Mid(ControlName, 5))
                                TranValue = getData(Me, xCol, xRow)

                                If IsNumeric(TranValue) Then
                                    If READ_PFK7171_CODE(HLPNA, TranValue) = True Then
                                        setData(Me, xCol - 1, xRow, D7171.BasicCode)
                                        setData(Me, xCol, xRow, D7171.BasicName)

                                        GoTo KeyTab8
                                    End If
                                Else
                                    If READ_PFK7171_NAME(HLPNA, TranValue) = True Then
                                        setData(Me, xCol - 1, xRow, D7171.BasicCode)
                                        setData(Me, xCol, xRow, D7171.BasicName)

                                        GoTo KeyTab8
                                    End If
                                End If

                                If HLP7171ALL.Link_HLP7171A(HLPNA, TranValue) = False Then
                                    setData(Me, xCol - 1, xRow, "")
                                    setData(Me, xCol, xRow, "")
                                    Exit Sub
                                End If


                                If READ_PFK7171(HLPNA, hlp0000SeVaTt) Then
                                    setData(Me, xCol - 1, xRow, D7171.BasicCode)
                                    setData(Me, xCol, xRow, D7171.BasicName)

                                    GoTo KeyTab8
                                End If
KeyTab8:

                                If D9911.CheckMerge = "1" Then
                                    For i As Integer = 0 To xRow - 1
                                        If FormatCut(getData(Me, xCol, i)) = "" Then
                                            setData(Me, xCol - 1, i, D7171.BasicCode)
                                            setData(Me, xCol, i, D7171.BasicName)
                                        End If
                                    Next

                                End If

                            Case "9" 'Machine Code
                                If HLP7155A.Link_HLP7155A(Value(1)) = False Then Exit Sub


                            Case "B"
                                HLP7231MM.ShowDialog()
                                'If HLP7231T.Link_HLP7231T(Me) = False Then Exit Sub

                                If Array_hlp0000SeVaTt.Count = 0 Then Exit Sub

                                For i As Integer = 0 To Array_hlp0000SeVaTt.Count - 1
                                    If READ_PFK7231(Array_hlp0000SeVaTt(i)) Then

                                        If xRow = Me.ActiveSheet.RowCount - 1 Then
                                            Me.ActiveSheet.RowCount += 1
                                        End If

                                        setData(Me, getColumIndex(Me, "MaterialCode"), xRow + i, D7231.MaterialCode)
                                        setData(Me, getColumIndex(Me, "MaterialName"), xRow, D7231.MaterialName)
                                        setData(Me, getColumIndex(Me, "MaterialSimple"), xRow, D7231.MaterialSimple)

                                        setData(Me, getColumIndex(Me, "QtyBasic"), xRow + i, D7231.QtyBasic)

                                        setData(Me, getColumIndex(Me, "seUnitMaterial"), xRow + i, D7231.seUnitMaterial)
                                        setData(Me, getColumIndex(Me, "cdUnitMaterial"), xRow + i, D7231.cdUnitMaterial)
                                        Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                        setData(Me, getColumIndex(Me, "cdUnitMaterialName"), xRow + i, D7171.BasicName)

                                        setData(Me, getColumIndex(Me, "seUnitPacking"), xRow + i, D7231.seUnitPacking)
                                        setData(Me, getColumIndex(Me, "cdUnitPacking"), xRow + i, D7231.cdUnitPacking)
                                        Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                        setData(Me, getColumIndex(Me, "cdUnitPackingName"), xRow + i, D7171.BasicName)

                                        setData(Me, getColumIndex(Me, "seUnitPrice"), xRow + i, D7231.seUnitPrice)
                                        setData(Me, getColumIndex(Me, "cdUnitPrice"), xRow + i, D7231.cdUnitPrice)
                                        Call READ_PFK7171(D7231.seUnitPrice, D7231.cdUnitPrice)
                                        setData(Me, getColumIndex(Me, "cdUnitPriceName"), xRow + i, D7171.BasicName)

                                        Call READ_PFK7171(D7231.seLargeGroupMaterial, D7231.cdLargeGroupMaterial)
                                        setData(Me, getColumIndex(Me, "cdLargeGroupMaterialName"), xRow + i, D7171.BasicName)

                                        Call READ_PFK7171(D7231.seSemiGroupMaterial, D7231.cdSemiGroupMaterial)
                                        setData(Me, getColumIndex(Me, "cdSemiGroupMaterialName"), xRow + i, D7171.BasicName)

                                        Call READ_PFK7171(D7231.seDetailGroupMaterial, D7231.cdDetailGroupMaterial)
                                        setData(Me, getColumIndex(Me, "cdDetailGroupMaterialName"), xRow + i, D7171.BasicName)

                                        setData(Me, getColumIndex(Me, "Width"), xRow + i, D7231.Width)
                                        setData(Me, getColumIndex(Me, "Height"), xRow + i, D7231.Height)
                                        setData(Me, getColumIndex(Me, "SizeName"), xRow + i, D7231.SizeName)

                                    End If

                                Next

                                Exit Sub

                        End Select


                    End If
                End If
            End If

            Exit Sub

        Catch ex As Exception

        End Try
    End Sub
    Private Sub HLPOpenvSchange(xCol As Integer, xRow As Integer, ControlName As String)
        Dim FormName As String

        FormName = Me.FindForm.Name

        Try

            If ControlName.Length > 5 Then
                If READ_PFK9911(ControlName) Then
                    If D9911.CheckDev = "1" Then
                        Dim Value() As String
                        Value = D9911.CheckDevValue.Split(";")

                        Select Case Value(0)
                            Case "1" ' Customer
                                TranValue = getData(Me, xCol, xRow)

                                If IsNumeric(TranValue) Then
                                    If READ_PFK7101_CODE(TranValue) = True Then

                                        setData(Me, xCol - 1, xRow, D7101.CustomerCode)
                                        setData(Me, xCol, xRow, D7101.CustomerName)

                                        GoTo KeyTab1
                                    End If
                                Else
                                    If READ_PFK7101_NAME(TranValue) = True Then
                                        setData(Me, xCol - 1, xRow, D7101.CustomerCode)
                                        setData(Me, xCol, xRow, D7101.CustomerName)

                                        GoTo KeyTab1
                                    End If
                                End If

                                If HLP7101A.Link_HLP7101A(TranValue) = False Then
                                    setData(Me, xCol - 1, xRow, "")
                                    setData(Me, xCol, xRow, "")
                                    Exit Sub
                                End If

                                If READ_PFK7101(hlp0000SeVaTt) Then
                                    setData(Me, xCol - 1, xRow, D7101.CustomerCode)
                                    setData(Me, xCol, xRow, D7101.CustomerName)

                                    GoTo KeyTab1
                                End If

KeyTab1:


                            Case "2" ' ColorCode
                                TranValue = getData(Me, xCol, xRow)

                                If IsNumeric(TranValue) Then
                                    If READ_PFK7121(CIntp(TranValue).ToString("000000")) = True Then

                                        setData(Me, xCol - 1, xRow, D7121.ColorCode)
                                        setData(Me, xCol, xRow, D7121.ColorName)

                                        Exit Sub

                                    End If
                                Else
                                    If READ_PFK7121_NAME(TranValue) = True Then
                                        setData(Me, xCol - 1, xRow, D7121.ColorCode)
                                        setData(Me, xCol, xRow, D7121.ColorName)

                                        Exit Sub

                                    End If
                                End If

                                If HLP7121A.Link_HLP7121A(TranValue) = False Then
                                    setData(Me, xCol - 1, xRow, "")
                                    setData(Me, xCol, xRow, "")
                                    Exit Sub
                                End If

                                If READ_PFK7121(hlp0000SeVaTt) Then
                                    setData(Me, xCol - 1, xRow, D7121.ColorCode)
                                    setData(Me, xCol, xRow, D7121.ColorName)

                                    Exit Sub
                                End If

                            Case "3" ' Type Code
                                If Value.Length > 1 Then HLPNA = Value(1)

                                TranValue = getData(Me, xCol, xRow)

                                If IsNumeric(TranValue) Then
                                    If READ_PFK7103_TYPECODE(HLPNA, TranValue) = True Then

                                        setData(Me, xCol - 1, xRow, D7103.TypeCode)
                                        setData(Me, xCol, xRow, D7103.TypeName)

                                        GoTo KeyTab3

                                    End If
                                Else
                                    If READ_PFK7103_TYPENAME(HLPNA, TranValue) = True Then
                                        setData(Me, xCol - 1, xRow, D7103.TypeCode)
                                        setData(Me, xCol, xRow, D7103.TypeName)

                                        GoTo KeyTab3

                                    End If
                                End If

                                If HLP7103A.Link_HLP7103A(HLPNA, TranValue) = False Then
                                    setData(Me, xCol - 1, xRow, D7103.TypeCode)
                                    setData(Me, xCol, xRow, D7103.TypeName)

                                    Exit Sub
                                End If

                                If READ_PFK7103_TYPECODE(HLPNA, hlp0000SeVaTt) Then
                                    setData(Me, xCol - 1, xRow, D7103.TypeCode)
                                    setData(Me, xCol, xRow, D7103.TypeName)

                                    GoTo KeyTab3

                                End If
KeyTab3:


                            Case "4" ' Tool Code

                                If Value.Length > 1 Then HLPNA = Value(1)

                                TranValue = getData(Me, xCol, xRow)

                                If IsNumeric(TranValue) Then
                                    If READ_PFK7156_CODE(HLPNA, TranValue) = True Then

                                        setData(Me, xCol - 1, xRow, D7156.ToolCode)
                                        setData(Me, xCol, xRow, D7156.ToolName)

                                        GoTo KeyTab4

                                    End If
                                Else
                                    If READ_PFK7156_NAME(HLPNA, TranValue) = True Then
                                        setData(Me, xCol - 1, xRow, D7156.ToolCode)
                                        setData(Me, xCol, xRow, D7156.ToolName)

                                        GoTo KeyTab4

                                    End If
                                End If

                                If HLP7156A.Link_HLP7156A(HLPNA, TranValue) = False Then
                                    setData(Me, xCol - 1, xRow, D7156.ToolCode)
                                    setData(Me, xCol, xRow, D7156.ToolName)

                                    Exit Sub
                                End If

                                If READ_PFK7156_CODE(HLPNA, hlp0000SeVaTt) Then
                                    setData(Me, xCol - 1, xRow, D7156.ToolCode)
                                    setData(Me, xCol, xRow, D7156.ToolName)

                                    GoTo KeyTab4

                                End If
KeyTab4:

                            Case "5" ' Odno
                                Exit Sub
                                If HLP7102A.Link_HLP7102A("2") = False Then Exit Sub

                            Case "6" 'HR CODE
                                HLPNA = Value(1)
                                HLP0002.ShowDialog()

                            Case "7", "B" ' 
                                TranValue = getData(Me, xCol, xRow)

                                If IsNumeric(TranValue) Then
                                    If READ_PFK7231_CODE(TranValue) = True Then

                                        If CheckMaterialAll() = False Then setData(Me, getColumIndex(Me, "MaterialCode"), xRow, "") : setData(Me, getColumIndex(Me, "MaterialName"), xRow, "") : Exit Sub

                                        setData(Me, xCol - 1, xRow, D7231.MaterialCode)
                                        setData(Me, xCol, xRow, D7231.MaterialName)

                                        setData(Me, getColumIndex(Me, "MaterialCode"), xRow, D7231.MaterialCode)
                                        setData(Me, getColumIndex(Me, "MaterialName"), xRow, D7231.MaterialName)
                                        setData(Me, getColumIndex(Me, "MaterialSimple"), xRow, D7231.MaterialSimple)

                                        setData(Me, getColumIndex(Me, "QtyBasic"), xRow, D7231.QtyBasic)

                                        setData(Me, getColumIndex(Me, "seUnitMaterial"), xRow, D7231.seUnitMaterial)
                                        setData(Me, getColumIndex(Me, "cdUnitMaterial"), xRow, D7231.cdUnitMaterial)
                                        Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                        setData(Me, getColumIndex(Me, "cdUnitMaterialName"), xRow, D7171.BasicName)

                                        setData(Me, getColumIndex(Me, "seUnitPacking"), xRow, D7231.seUnitPacking)
                                        setData(Me, getColumIndex(Me, "cdUnitPacking"), xRow, D7231.cdUnitPacking)
                                        Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                        setData(Me, getColumIndex(Me, "cdUnitPackingName"), xRow, D7171.BasicName)

                                        setData(Me, getColumIndex(Me, "seUnitPrice"), xRow, D7231.seUnitPrice)
                                        setData(Me, getColumIndex(Me, "cdUnitPrice"), xRow, D7231.cdUnitPrice)
                                        Call READ_PFK7171(D7231.seUnitPrice, D7231.cdUnitPrice)
                                        setData(Me, getColumIndex(Me, "cdUnitPriceName"), xRow, D7171.BasicName)

                                        Call READ_PFK7171(D7231.seLargeGroupMaterial, D7231.cdLargeGroupMaterial)
                                        setData(Me, getColumIndex(Me, "cdLargeGroupMaterialName"), xRow, D7171.BasicName)

                                        Call READ_PFK7171(D7231.seSemiGroupMaterial, D7231.cdSemiGroupMaterial)
                                        setData(Me, getColumIndex(Me, "cdSemiGroupMaterialName"), xRow, D7171.BasicName)

                                        Call READ_PFK7171(D7231.seDetailGroupMaterial, D7231.cdDetailGroupMaterial)
                                        setData(Me, getColumIndex(Me, "cdDetailGroupMaterialName"), xRow, D7171.BasicName)

                                        setData(Me, getColumIndex(Me, "Width"), xRow, D7231.Width)
                                        setData(Me, getColumIndex(Me, "Height"), xRow, D7231.Height)
                                        setData(Me, getColumIndex(Me, "SizeName"), xRow, D7231.SizeName)

                                        GoTo KeyTab7

                                    End If

                                ElseIf READ_PFK7231_NAME(TranValue) = True Then
                                    If CheckMaterialAll() = False Then setData(Me, getColumIndex(Me, "MaterialCode"), xRow, "") : setData(Me, getColumIndex(Me, "MaterialName"), xRow, "") : Exit Sub

                                    setData(Me, xCol - 1, xRow, D7231.MaterialCode)
                                    setData(Me, xCol, xRow, D7231.MaterialName)

                                    setData(Me, getColumIndex(Me, "MaterialCode"), xRow, D7231.MaterialCode)
                                    setData(Me, getColumIndex(Me, "MaterialName"), xRow, D7231.MaterialName)

                                    setData(Me, getColumIndex(Me, "MaterialSimple"), xRow, D7231.MaterialSimple)

                                    setData(Me, getColumIndex(Me, "QtyBasic"), xRow, D7231.QtyBasic)

                                    setData(Me, getColumIndex(Me, "seUnitMaterial"), xRow, D7231.seUnitMaterial)
                                    setData(Me, getColumIndex(Me, "cdUnitMaterial"), xRow, D7231.cdUnitMaterial)
                                    Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                    setData(Me, getColumIndex(Me, "cdUnitMaterialName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "seUnitPacking"), xRow, D7231.seUnitPacking)
                                    setData(Me, getColumIndex(Me, "cdUnitPacking"), xRow, D7231.cdUnitPacking)
                                    Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                    setData(Me, getColumIndex(Me, "cdUnitPackingName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "seUnitPrice"), xRow, D7231.seUnitPrice)
                                    setData(Me, getColumIndex(Me, "cdUnitPrice"), xRow, D7231.cdUnitPrice)
                                    Call READ_PFK7171(D7231.seUnitPrice, D7231.cdUnitPrice)
                                    setData(Me, getColumIndex(Me, "cdUnitPriceName"), xRow, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seLargeGroupMaterial, D7231.cdLargeGroupMaterial)
                                    setData(Me, getColumIndex(Me, "cdLargeGroupMaterialName"), xRow, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seSemiGroupMaterial, D7231.cdSemiGroupMaterial)
                                    setData(Me, getColumIndex(Me, "cdSemiGroupMaterialName"), xRow, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seDetailGroupMaterial, D7231.cdDetailGroupMaterial)
                                    setData(Me, getColumIndex(Me, "cdDetailGroupMaterialName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "Width"), xRow, D7231.Width)
                                    setData(Me, getColumIndex(Me, "Height"), xRow, D7231.Height)
                                    setData(Me, getColumIndex(Me, "SizeName"), xRow, D7231.SizeName)

                                    GoTo KeyTab7


                                ElseIf READ_PFK7231_NAME_FULLNAME(TranValue) = True Then
                                    If CheckMaterialAll() = False Then setData(Me, getColumIndex(Me, "MaterialCode"), xRow, "") : setData(Me, getColumIndex(Me, "MaterialName"), xRow, "") : Exit Sub

                                    setData(Me, xCol - 1, xRow, D7231.MaterialCode)
                                    setData(Me, xCol, xRow, D7231.MaterialName)

                                    setData(Me, getColumIndex(Me, "MaterialCode"), xRow, D7231.MaterialCode)
                                    setData(Me, getColumIndex(Me, "MaterialName"), xRow, D7231.MaterialName)

                                    setData(Me, getColumIndex(Me, "MaterialSimple"), xRow, D7231.MaterialSimple)

                                    setData(Me, getColumIndex(Me, "QtyBasic"), xRow, D7231.QtyBasic)

                                    setData(Me, getColumIndex(Me, "seUnitMaterial"), xRow, D7231.seUnitMaterial)
                                    setData(Me, getColumIndex(Me, "cdUnitMaterial"), xRow, D7231.cdUnitMaterial)
                                    Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                    setData(Me, getColumIndex(Me, "cdUnitMaterialName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "seUnitPacking"), xRow, D7231.seUnitPacking)
                                    setData(Me, getColumIndex(Me, "cdUnitPacking"), xRow, D7231.cdUnitPacking)
                                    Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                    setData(Me, getColumIndex(Me, "cdUnitPackingName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "seUnitPrice"), xRow, D7231.seUnitPrice)
                                    setData(Me, getColumIndex(Me, "cdUnitPrice"), xRow, D7231.cdUnitPrice)
                                    Call READ_PFK7171(D7231.seUnitPrice, D7231.cdUnitPrice)
                                    setData(Me, getColumIndex(Me, "cdUnitPriceName"), xRow, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seLargeGroupMaterial, D7231.cdLargeGroupMaterial)
                                    setData(Me, getColumIndex(Me, "cdLargeGroupMaterialName"), xRow, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seSemiGroupMaterial, D7231.cdSemiGroupMaterial)
                                    setData(Me, getColumIndex(Me, "cdSemiGroupMaterialName"), xRow, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seDetailGroupMaterial, D7231.cdDetailGroupMaterial)
                                    setData(Me, getColumIndex(Me, "cdDetailGroupMaterialName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "Width"), xRow, D7231.Width)
                                    setData(Me, getColumIndex(Me, "Height"), xRow, D7231.Height)
                                    setData(Me, getColumIndex(Me, "SizeName"), xRow, D7231.SizeName)

                                    GoTo KeyTab7

                                ElseIf READ_PFK7231_CHECKNAME_FULL(TranValue) = True Then
                                    If CheckMaterialAll() = False Then setData(Me, getColumIndex(Me, "MaterialCode"), xRow, "") : setData(Me, getColumIndex(Me, "MaterialName"), xRow, "") : Exit Sub

                                    setData(Me, xCol - 1, xRow, D7231.MaterialCode)
                                    setData(Me, xCol, xRow, D7231.MaterialName)

                                    setData(Me, getColumIndex(Me, "MaterialCode"), xRow, D7231.MaterialCode)
                                    setData(Me, getColumIndex(Me, "MaterialName"), xRow, D7231.MaterialName)
                                    setData(Me, getColumIndex(Me, "MaterialSimple"), xRow, D7231.MaterialSimple)

                                    setData(Me, getColumIndex(Me, "QtyBasic"), xRow, D7231.QtyBasic)

                                    setData(Me, getColumIndex(Me, "seUnitMaterial"), xRow, D7231.seUnitMaterial)
                                    setData(Me, getColumIndex(Me, "cdUnitMaterial"), xRow, D7231.cdUnitMaterial)
                                    Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                    setData(Me, getColumIndex(Me, "cdUnitMaterialName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "seUnitPacking"), xRow, D7231.seUnitPacking)
                                    setData(Me, getColumIndex(Me, "cdUnitPacking"), xRow, D7231.cdUnitPacking)
                                    Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                    setData(Me, getColumIndex(Me, "cdUnitPackingName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "seUnitPrice"), xRow, D7231.seUnitPrice)
                                    setData(Me, getColumIndex(Me, "cdUnitPrice"), xRow, D7231.cdUnitPrice)
                                    Call READ_PFK7171(D7231.seUnitPrice, D7231.cdUnitPrice)
                                    setData(Me, getColumIndex(Me, "cdUnitPriceName"), xRow, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seLargeGroupMaterial, D7231.cdLargeGroupMaterial)
                                    setData(Me, getColumIndex(Me, "cdLargeGroupMaterialName"), xRow, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seSemiGroupMaterial, D7231.cdSemiGroupMaterial)
                                    setData(Me, getColumIndex(Me, "cdSemiGroupMaterialName"), xRow, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seDetailGroupMaterial, D7231.cdDetailGroupMaterial)
                                    setData(Me, getColumIndex(Me, "cdDetailGroupMaterialName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "Width"), xRow, D7231.Width)
                                    setData(Me, getColumIndex(Me, "Height"), xRow, D7231.Height)
                                    setData(Me, getColumIndex(Me, "SizeName"), xRow, D7231.SizeName)

                                    GoTo KeyTab7

                                End If

                                If HLP7231C.Link_HLP7231C(TranValue) = False Then
                                    setData(Me, xCol - 1, xRow, "")
                                    setData(Me, xCol, xRow, "")
                                    Exit Sub
                                End If

                                If READ_PFK7231(hlp0000SeVaTt) Then
                                    If CheckMaterialAll() = False Then setData(Me, getColumIndex(Me, "MaterialCode"), xRow, "") : setData(Me, getColumIndex(Me, "MaterialName"), xRow, "") : Exit Sub

                                    setData(Me, xCol - 1, xRow, D7231.MaterialCode)
                                    setData(Me, xCol, xRow, D7231.MaterialName)
                                    setData(Me, getColumIndex(Me, "MaterialCode"), xRow, D7231.MaterialCode)
                                    setData(Me, getColumIndex(Me, "MaterialName"), xRow, D7231.MaterialName)
                                    setData(Me, getColumIndex(Me, "MaterialSimple"), xRow, D7231.MaterialSimple)


                                    setData(Me, getColumIndex(Me, "QtyBasic"), xRow, D7231.QtyBasic)

                                    setData(Me, getColumIndex(Me, "seUnitMaterial"), xRow, D7231.seUnitMaterial)
                                    setData(Me, getColumIndex(Me, "cdUnitMaterial"), xRow, D7231.cdUnitMaterial)
                                    Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                    setData(Me, getColumIndex(Me, "cdUnitMaterialName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "seUnitPacking"), xRow, D7231.seUnitPacking)
                                    setData(Me, getColumIndex(Me, "cdUnitPacking"), xRow, D7231.cdUnitPacking)
                                    Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                    setData(Me, getColumIndex(Me, "cdUnitPackingName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "seUnitPrice"), xRow, D7231.seUnitPrice)
                                    setData(Me, getColumIndex(Me, "cdUnitPrice"), xRow, D7231.cdUnitPrice)
                                    Call READ_PFK7171(D7231.seUnitPrice, D7231.cdUnitPrice)
                                    setData(Me, getColumIndex(Me, "cdUnitPriceName"), xRow, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seLargeGroupMaterial, D7231.cdLargeGroupMaterial)
                                    setData(Me, getColumIndex(Me, "cdLargeGroupMaterialName"), xRow, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seSemiGroupMaterial, D7231.cdSemiGroupMaterial)
                                    setData(Me, getColumIndex(Me, "cdSemiGroupMaterialName"), xRow, D7171.BasicName)

                                    Call READ_PFK7171(D7231.seDetailGroupMaterial, D7231.cdDetailGroupMaterial)
                                    setData(Me, getColumIndex(Me, "cdDetailGroupMaterialName"), xRow, D7171.BasicName)

                                    setData(Me, getColumIndex(Me, "Width"), xRow, D7231.Width)
                                    setData(Me, getColumIndex(Me, "Height"), xRow, D7231.Height)
                                    setData(Me, getColumIndex(Me, "SizeName"), xRow, D7231.SizeName)

                                    GoTo KeyTab7
                                End If

KeyTab7:
                            Case "8" 'Basic Code
                                HLPNA = ListCode(Strings.Mid(ControlName, 5))
                                TranValue = getData(Me, xCol, xRow)

                                If IsNumeric(TranValue) Then
                                    If READ_PFK7171_CODE(HLPNA, TranValue) = True Then
                                        setData(Me, xCol - 1, xRow, D7171.BasicCode)
                                        setData(Me, xCol, xRow, D7171.BasicName)

                                        GoTo KeyTab8
                                    End If
                                Else
                                    If READ_PFK7171_NAME(HLPNA, TranValue) = True Then
                                        setData(Me, xCol - 1, xRow, D7171.BasicCode)
                                        setData(Me, xCol, xRow, D7171.BasicName)

                                        GoTo KeyTab8
                                    End If
                                End If

                                If HLP7171ALL.Link_HLP7171A(HLPNA, TranValue) = False Then
                                    setData(Me, xCol - 1, xRow, "")
                                    setData(Me, xCol, xRow, "")
                                    Exit Sub
                                End If


                                If READ_PFK7171(HLPNA, hlp0000SeVaTt) Then
                                    setData(Me, xCol - 1, xRow, D7171.BasicCode)
                                    setData(Me, xCol, xRow, D7171.BasicName)

                                    GoTo KeyTab8
                                End If
KeyTab8:


                            Case "9" 'Machine Code
                                If HLP7155A.Link_HLP7155A(Value(1)) = False Then Exit Sub


                            Case "B"
                                HLP7231MM.ShowDialog()
                                'If HLP7231T.Link_HLP7231T(Me) = False Then Exit Sub

                                If Array_hlp0000SeVaTt.Count = 0 Then Exit Sub

                                For i As Integer = 0 To Array_hlp0000SeVaTt.Count - 1
                                    If READ_PFK7231(Array_hlp0000SeVaTt(i)) Then

                                        If xRow = Me.ActiveSheet.RowCount - 1 Then
                                            Me.ActiveSheet.RowCount += 1
                                        End If

                                        setData(Me, getColumIndex(Me, "MaterialCode"), xRow + i, D7231.MaterialCode)
                                        setData(Me, getColumIndex(Me, "MaterialName"), xRow + i, D7231.MaterialName)
                                        setData(Me, getColumIndex(Me, "MaterialSimple"), xRow, D7231.MaterialSimple)

                                        setData(Me, getColumIndex(Me, "QtyBasic"), xRow + i, D7231.QtyBasic)

                                        setData(Me, getColumIndex(Me, "seUnitMaterial"), xRow + i, D7231.seUnitMaterial)
                                        setData(Me, getColumIndex(Me, "cdUnitMaterial"), xRow + i, D7231.cdUnitMaterial)
                                        Call READ_PFK7171(D7231.seUnitMaterial, D7231.cdUnitMaterial)
                                        setData(Me, getColumIndex(Me, "cdUnitMaterialName"), xRow + i, D7171.BasicName)

                                        setData(Me, getColumIndex(Me, "seUnitPacking"), xRow + i, D7231.seUnitPacking)
                                        setData(Me, getColumIndex(Me, "cdUnitPacking"), xRow + i, D7231.cdUnitPacking)
                                        Call READ_PFK7171(D7231.seUnitPacking, D7231.cdUnitPacking)
                                        setData(Me, getColumIndex(Me, "cdUnitPackingName"), xRow + i, D7171.BasicName)

                                        setData(Me, getColumIndex(Me, "seUnitPrice"), xRow + i, D7231.seUnitPrice)
                                        setData(Me, getColumIndex(Me, "cdUnitPrice"), xRow + i, D7231.cdUnitPrice)
                                        Call READ_PFK7171(D7231.seUnitPrice, D7231.cdUnitPrice)
                                        setData(Me, getColumIndex(Me, "cdUnitPriceName"), xRow + i, D7171.BasicName)

                                        Call READ_PFK7171(D7231.seLargeGroupMaterial, D7231.cdLargeGroupMaterial)
                                        setData(Me, getColumIndex(Me, "cdLargeGroupMaterialName"), xRow + i, D7171.BasicName)

                                        Call READ_PFK7171(D7231.seSemiGroupMaterial, D7231.cdSemiGroupMaterial)
                                        setData(Me, getColumIndex(Me, "cdSemiGroupMaterialName"), xRow + i, D7171.BasicName)

                                        Call READ_PFK7171(D7231.seDetailGroupMaterial, D7231.cdDetailGroupMaterial)
                                        setData(Me, getColumIndex(Me, "cdDetailGroupMaterialName"), xRow + i, D7171.BasicName)


                                        setData(Me, getColumIndex(Me, "Width"), xRow + i, D7231.Width)
                                        setData(Me, getColumIndex(Me, "Height"), xRow + i, D7231.Height)
                                        setData(Me, getColumIndex(Me, "SizeName"), xRow + i, D7231.SizeName)
                                    End If

                                Next

                                Exit Sub

                        End Select


                    End If
                End If
            End If

            Exit Sub

        Catch ex As Exception

        End Try
    End Sub


    Private Sub MenuClick(sender As Object, e As EventArgs)
        Dim MenuAt As MenuItem
        MenuAt = CType(sender, MenuItem)
        If MenuAt.Text = "Item Code - Information" Then
            Dim f As New ISUD7106A
            Call f.Link_ISUD7106A("2", MenuAt.Tag, "PFP71060")

        ElseIf MenuAt.Text = "Spec Information - Information" Then
            Dim f As New ISUD7108A
            If READ_PFK7106(MenuAt.Tag) Then
                If READ_PFK7108_SHOESCODE(D7106.ShoesCode) Then
                    If f.Link_ISUD7108A(2, D7108.GroupComponentBOM, "PFP71085") = False Then Exit Sub
                End If
            End If


        ElseIf MenuAt.Text = "CBD Information - Information" Then
            Dim f As New ISUD7110D
            If READ_PFK7106(MenuAt.Tag) Then
                If f.Link_ISUD7110D(2, D7106.ShoesCode, "PFP71086") = False Then Exit Sub
            End If

        ElseIf MenuAt.Text = "Image" Then
            Call downLoadFile(MenuAt.Tag, "1")

        ElseIf MenuAt.Text = "Doc" Then
            Call downLoadFile(MenuAt.Tag, "2")

        ElseIf MenuAt.Text = "Exit" Then

        End If
    End Sub

    Private Sub downLoadFile(strShoeSode As String, checkType As String)
        Dim sFileName As String
        Dim strSql As String

        'For Document
        Try
            'Get image data from gridview column. 
            strSql = "Select TOP 1 * from [PFK7107] "
            strSql = strSql & " WHERE [K7107_ShoesCode]= '" & strShoeSode & "' AND [K7107_CheckType] = '" & checkType & "' "

            Dim sqlCmd As New SqlClient.SqlCommand(strSql, cn)
            DS1 = PrcDS(sqlCmd, cn)

            If GetDsRc(DS1) > 0 Then
                sFileName = GetDsData(DS1, 0, "K7107_FileName")
                sFileName &= "." & GetDsData(DS1, 0, "K7107_FileType")

                'Get image data from DB
                Dim fileData As Object = GetDsData(DS1, 0, "K7107_ImageData")

                Dim sTempFileName As String = System.IO.Path.GetTempPath & sFileName

                If Not fileData Is Nothing Then

                    'Read image data into a file stream 
                    Using fs As New IO.FileStream(sTempFileName, IO.FileMode.OpenOrCreate, IO.FileAccess.Write)
                        fs.Write(fileData, 0, fileData.Length)
                        'Set image variable value using memory stream. 
                        fs.Flush()
                        fs.Close()
                    End Using

                    'Open File

                    Process.Start(sTempFileName)

                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private chk_KeyControl As Boolean = False
    Public chk_NoUseKey As Boolean = False

    Overridable Sub SpreadP1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try
            If chk_NoUseKey = True Then Exit Sub

            Dim col As Integer = CType(sender, PeaceFarpoint).Sheets(0).ActiveColumnIndex
            Dim row As Integer = CType(sender, PeaceFarpoint).Sheets(0).ActiveRowIndex

            If e.Control = True Then
                chk_KeyControl = True

                Select Case e.KeyCode
                    Case Keys.Insert And e.Shift = True
                        If InsChk = False Then Exit Sub


                        For i As Integer = row To sender.ActiveSheet.RowCount - 1
                            sender.ActiveSheet.RowCount += 1
                            Call SPR_COPY(Me, i, sender.ActiveSheet.RowCount - 1)
                        Next




                        e.Handled = True

                    Case Keys.Insert
                        If InsChk = False Then Exit Sub

                        If row = sender.ActiveSheet.RowCount - 1 Then
                            Me.ActiveSheet.RowCount += 1
                            Me.ActiveSheet.ActiveRowIndex = row + 1
                            Call SPR_COPY(Me, row, row + 1)
                        Else
                            Me.ActiveSheet.AddRows(row, 1)
                            Call SPR_COPY(Me, row + 1, row)

                        End If
                        e.Handled = True

                    Case Keys.W
                        If Pub.DEVCHK <> "1" Then Exit Sub
                        Dim i As Integer
                        Dim ProgramName As String
                        Dim SheetName As String
                        Dim Value() As String

                        Value = Me.Tag.ToString.Split(";")
                        If Value.Length < 2 Then Exit Sub
                        ProgramName = Value(0)
                        SheetName = Value(1)

                        For i = 0 To Me.ActiveSheet.ColumnCount - 1
                            If READ_PFK9912_2("DMS", ProgramName, SheetName, Me.ActiveSheet.Columns(i).Tag) Then
                                D9912.SizeWidth = Me.ActiveSheet.Columns(i).Width
                                Call REWRITE_PFK9912(D9912)
                                Call D9912_CLEAR()
                            End If
                        Next
                        MsgBoxP("Update Successfully!", vbInformation)

                    Case Keys.B
                        Dim f As New ISUBBIG
                        f.BringToFront()
                        Call f.Link_ISUBBIG(Me)

                    Case Keys.Q
                        Select Case col
                            Case getColumIndex(sender, "TransferVoucher"), getColumIndex(sender, "TransferOrder")
                                If READ_PFK2356_TRANSFERVOUCHER(getData(Me, getColumIndex(sender, "TransferVoucher"), row)) Then
                                    Call ISUD2356B.Link_ISUD2356B(2, "1", D2356.DateOutBoundMaterial, D2356.SeqOutBoundMaterial, D2356.SnoOutBoundMaterial, "", 0, "PFP23567")
                                End If



                            Case getColumIndex(sender, "OrderNo"), getColumIndex(sender, "OrderNoSeq")
                                Call ISUD1311A_F1.Link_ISUD1311A_F1(2, getData(Me, getColumIndex(sender, "OrderNo"), row), "PFP13123")

                            Case getColumIndex(sender, "CustomerCode")
                                Call ISUD7101B.Link_ISUD7101A(2, getData(Me, getColumIndex(sender, "CustomerCode"), row), "PFP71010")

                            Case getColumIndex(sender, "SupplierCode")
                                Call ISUD7101B.Link_ISUD7101A(2, getData(Me, getColumIndex(sender, "SupplierCode"), row), "PFP71010")

                            Case getColumIndex(sender, "CustomerName"), getColumIndex(sender, "SupplierName"), getColumIndex(sender, "CustomerSimplyName")
                                If READ_PFK7101_NAME(getData(Me, col, row)) Then
                                    Call ISUD7101B.Link_ISUD7101A(2, D7101.CustomerCode, "PFP71010")

                                ElseIf READ_PFK7101_SIMPLENAME(getData(Me, col, row)) Then
                                    Call ISUD7101B.Link_ISUD7101A(2, D7101.CustomerCode, "PFP71010")
                                End If

                            Case getColumIndex(sender, "ShoesCode")

                                Dim menuItems() As MenuItem = New MenuItem() _
                            {New MenuItem("Item Code - Information"), _
                            New MenuItem("Spec Information - Information"), _
                             New MenuItem("CBD Information - Information"), _
                             New MenuItem("Image"), _
                              New MenuItem("Doc"), _
                            New MenuItem("Exit")}

                                Dim buttonMenu As New ContextMenu(menuItems)
                                buttonMenu.Show(sender, New System.Drawing.Point(Me.Location.X / 2, Me.Location.Y / 2))

                                For Each Objecta As MenuItem In menuItems
                                    Objecta.Tag = getData(Me, col, row)
                                    AddHandler Objecta.Click, AddressOf MenuClick
                                Next

                            Case getColumIndex(sender, "PurchasingOrderNo")
                                Call ISUD3411A.Link_ISUD3411A(2, getData(Me, getColumIndex(sender, "PurchasingOrderNo"), row), "PFP30112")

                            Case getColumIndex(sender, "PRName")
                                If READ_PFK1312(getData(Me, getColumIndex(sender, "KEY_OrderNo"), row), getData(Me, getColumIndex(sender, "KEY_OrderNoSeq"), row)) Then
                                    Call ISUD3011B.Link_ISUD3011B(2, D1312.OrderNo, D1312.OrderNoSeq, "PFP30111")
                                End If


                            Case getColumIndex(sender, "FactOrderNo")

                                If READ_PFK3421(getData(Me, col, row)) Then
                                    If D3421.CheckInPurchasingOrder = "1" Then
                                        Call ISUD3411A.Link_ISUD3411A(2, D3421.PurchasingOrderNo, "PFP30112")
                                    Else
                                        Call ISUD3421A.Link_ISUD3421A(2, D3421.FactOrderNo, D3421.CheckIOType, IIf(D3421.CheckIOType = "1", D3421.CheckInPurchasingOrder, D3421.CheckOutPurchasingOrder), "PFP34210")

                                    End If
                                End If

                            Case getColumIndex(sender, "PRName")
                                Call ISUD3011B.Link_ISUD3011B(2, getData(Me, getColumIndex(sender, "OrderNo"), row), getData(Me, getColumIndex(sender, "OrderNoSeq"), row))

                            Case getColumIndex(sender, "SlnoD"), getColumIndex(sender, "Slno"), getColumIndex(sender, "Sealno")
                                If READ_PFK7171_NAME(ListCode("Season"), getData(Me, getColumIndex(sender, "cdSeasonName"), row)) Then
                                    If READ_PFK4010_SLNO_SEASON(D7171.BasicCode, getData(Me, col, row)) Then
                                        Call PFP40751.Link_ISUD40751A(D4010.JobCard)
                                    End If
                                End If

                            Case getColumIndex(sender, "JobCard")
                                If READ_PFK4010(getData(Me, col, row)) Then
                                    Call ISUD4010B.Link_ISUD4010B(3, D4010.JobCard, "PFP40010")
                                End If

                            Case getColumIndex(sender, "MaterialInboundNo")
                                Call ISUD2351A.Link_ISUD2351A(2, "1", getData(Me, getColumIndex(sender, "MaterialInboundNo"), row), "PFP23510")

                            Case getColumIndex(sender, "MaterialCode")
                                Call ISUD7231A.Link_ISUD7231A(2, getData(Me, getColumIndex(sender, "MaterialCode"), row), "PFP72310")

                            Case getColumIndex(sender, "MaterialName")
                                If READ_PFK7231_NAME(getData(Me, getColumIndex(sender, "MaterialCode"), row)) Then
                                    Call ISUD7231A.Link_ISUD7231A(2, D7231.MaterialCode, "PFP72310")
                                End If

                            Case getColumIndex(sender, "IDNO")
                                Call ISUD7411A.Link_ISUD7411A(2, getData(Me, getColumIndex(sender, "IDNO"), row), "PFP74110")



                        End Select

                        If getColumName(sender, col).ToString.ToUpper.Contains("INCHARGE") Then

                            If READ_PFK7411_NAME(getData(Me, getColumIndex(sender, col), row)) Then
                                Call ISUD7411A.Link_ISUD7411A(2, getData(Me, getColumIndex(sender, "IDNO"), row), "PFP74110")
                            End If


                        End If


                    Case Keys.U
                        Select Case col
                            Case getColumIndex(sender, "OrderNo"), getColumIndex(sender, "OrderNoSeq")
                                Call ISUD1311A_F1.Link_ISUD1311A_F1(3, getData(Me, getColumIndex(sender, "OrderNo"), row), "PFP13123")

                            Case getColumIndex(sender, "CustomerCode")
                                Call ISUD7101B.Link_ISUD7101A(3, getData(Me, getColumIndex(sender, "CustomerCode"), row), "PFP71010")

                            Case getColumIndex(sender, "SupplierCode")
                                Call ISUD7101B.Link_ISUD7101A(3, getData(Me, getColumIndex(sender, "SupplierCode"), row), "PFP71010")

                            Case getColumIndex(sender, "CustomerName"), getColumIndex(sender, "SupplierName"), getColumIndex(sender, "CustomerSimplyName")
                                If READ_PFK7101_NAME(getData(Me, col, row)) Then
                                    Call ISUD7101B.Link_ISUD7101A(3, D7101.CustomerCode, "PFP71010")

                                ElseIf READ_PFK7101_SIMPLENAME(getData(Me, col, row)) Then
                                    Call ISUD7101B.Link_ISUD7101A(3, D7101.CustomerCode, "PFP71010")
                                End If

                            Case getColumIndex(sender, "ShoesCode")

                                Dim menuItems() As MenuItem = New MenuItem() _
                            {New MenuItem("Item Code - Information"), _
                            New MenuItem("Spec Information - Information"), _
                             New MenuItem("CBD Information - Information"), _
                             New MenuItem("Image"), _
                              New MenuItem("Doc"), _
                            New MenuItem("Exit")}

                                Dim buttonMenu As New ContextMenu(menuItems)
                                buttonMenu.Show(sender, New System.Drawing.Point(Me.Location.X / 2, Me.Location.Y / 2))

                                For Each Objecta As MenuItem In menuItems
                                    Objecta.Tag = getData(Me, col, row)
                                    AddHandler Objecta.Click, AddressOf MenuClick
                                Next

                            Case getColumIndex(sender, "PurchasingOrderNo")
                                Call ISUD3411A.Link_ISUD3411A(3, getData(Me, getColumIndex(sender, "PurchasingOrderNo"), row), "PFP30112")

                            Case getColumIndex(sender, "FactOrderNo")

                                If READ_PFK3421(getData(Me, col, row)) Then
                                    If D3421.CheckInPurchasingOrder = "1" Then
                                        Call ISUD3411A.Link_ISUD3411A(3, D3421.PurchasingOrderNo, "PFP30112")
                                    Else
                                        Call ISUD3421A.Link_ISUD3421A(3, D3421.FactOrderNo, D3421.CheckIOType, IIf(D3421.CheckIOType = "1", D3421.CheckInPurchasingOrder, D3421.CheckOutPurchasingOrder), "PFP34210")

                                    End If
                                End If

                            Case getColumIndex(sender, "PRNo")
                                Call ISUD3011A.Link_ISUD3011A(3, getData(Me, getColumIndex(sender, "PRNo"), row))

                            Case getColumIndex(sender, "SlnoD"), getColumIndex(sender, "Slno"), getColumIndex(sender, "Sealno")
                                If READ_PFK7171_NAME(ListCode("Season"), getData(Me, getColumIndex(sender, "cdSeasonName"), row)) Then
                                    If READ_PFK4010_SLNO_SEASON(D7171.BasicCode, getData(Me, col, row)) Then
                                        Call PFP40751.Link_ISUD40751A(D4010.JobCard)
                                    End If
                                End If

                            Case getColumIndex(sender, "MaterialInboundNo")
                                Call ISUD2351A.Link_ISUD2351A(3, "1", getData(Me, getColumIndex(sender, "MaterialInboundNo"), row), "PFP23510")

                            Case getColumIndex(sender, "MaterialCode")
                                Call ISUD7231A.Link_ISUD7231A(3, getData(Me, getColumIndex(sender, "MaterialCode"), row), "PFP72310")

                            Case getColumIndex(sender, "MaterialName")
                                If READ_PFK7231_NAME(getData(Me, getColumIndex(sender, "MaterialCode"), row)) Then
                                    Call ISUD7231A.Link_ISUD7231A(3, D7231.MaterialCode, "PFP72310")
                                End If

                            Case getColumIndex(sender, "IDNO")
                                Call ISUD7411A.Link_ISUD7411A(3, getData(Me, getColumIndex(sender, "IDNO"), row), "PFP74110")



                        End Select

                        If getColumName(sender, col).ToString.ToUpper.Contains("INCHARGE") Then

                            If READ_PFK7411_NAME(getData(Me, getColumIndex(sender, col), row)) Then
                                Call ISUD7411A.Link_ISUD7411A(2, getData(Me, getColumIndex(sender, "IDNO"), row), "PFP74110")
                            End If


                        End If

                    Case Keys.D

                        If col + 1 < Me.ActiveSheet.ColumnCount Then SPR_SET(Me, col + 1, , Me.ActiveSheet.RowCount, Me.ActiveSheet.OperationMode)
                    Case Keys.R

                        If row + 1 < Me.ActiveSheet.RowCount Then SPR_SET(Me, , row + 1, Me.ActiveSheet.RowCount, Me.ActiveSheet.OperationMode)
                    Case Keys.F

                        If Me.ActiveSheet.ActiveColumn.AllowAutoFilter = True Then
                            Me.ActiveSheet.Columns(0, Me.ActiveSheet.ColumnCount - 1).AllowAutoFilter = False
                            Me.ActiveSheet.Columns(0, Me.ActiveSheet.ColumnCount - 1).AllowAutoSort = False
                            Me.ActiveSheet.AutoFilterMode = Nothing

                        Else
                            Call HeaderDefault()
                            Me.ActiveSheet.AutoFilterMode = AutoFilterMode.EnhancedContextMenu
                            Me.ActiveSheet.Columns(0, Me.ActiveSheet.ColumnCount - 1).AllowAutoFilter = True
                            Me.ActiveSheet.Columns(0, Me.ActiveSheet.ColumnCount - 1).AllowAutoSort = True
                            Me.ActiveSheet.Columns(0, Me.ActiveSheet.ColumnCount - 1).ShowSortIndicator = True
                        End If

                    Case Keys.I
                        Dim program As String
                        Dim Sheetname As String
                        Dim Chuoi() As String

                        Chuoi = Split(Me.Tag, ";")
                        If UBound(Chuoi) < 1 Then Exit Sub
                        program = Chuoi(0)
                        Sheetname = Chuoi(1)

                        Call P_SPREAD_PROGRAM_USER.Link_ISUD_P_SPREAD_PROGRAM_USER(3, program, Sheetname)

                    Case Keys.T

                        Me.ActiveSheet.OperationMode = OperationMode.Normal
                        Me.FocusRenderer = New FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer(3)

                        Dim sd As FarPoint.Win.Spread.AdvancedSearchDialog
                        Me.SearchWithDialogAdvanced("")
                        sd = Me.SearchDialog
                        sd.SetCustomTextToDefaults()
                        sd.StartSheetIndex = 0
                        sd.EndSheetIndex = 0
                        sd.SearchCellText = True
                        sd.SearchNotes = False
                        sd.SearchTags = False
                        sd.AlternateSearch = False
                        sd.UseWildcards = False
                        sd.CaseSensitive = False
                        sd.ExactMatch = False
                        sd.StartColumnIndex = 0
                        sd.StartRowIndex = 0

                    Case Keys.P

                        Dim tmpPW_CHK As String = ""
                        tmpPW_CHK = "PSM@."

                        If Pub.DEVCHK <> "1" Then
                            Dim f As Form
                            f = New FPassWord
                            f.ShowDialog()
                            If PASSWORDCHECK.Trim = "" Then Exit Sub
                            If PASSWORDCHECK <> tmpPW_CHK Then MsgBoxP("WRONG PASS!") : Exit Sub
                        End If

                        Dim program As String
                        Dim Sheetname As String
                        Dim Chuoi() As String

                        Chuoi = Split(Me.Tag, ";")
                        If UBound(Chuoi) < 1 Then Exit Sub
                        program = Chuoi(0)
                        Sheetname = Chuoi(1)

                        Call P_SPREAD_PROGRAM_V2.Link_ISUD_P_SPREAD_PROGRAM(3, program, Sheetname)
                    Case Keys.S
                        Dim a As New SaveFileDialog
                        Dim filelocation As String
                        a.Filter = "Excel Files|*.xls"
                        a.DefaultExt = "xls"
                        If a.ShowDialog = DialogResult.OK Then
                            filelocation = a.FileName

                            Me.ActiveSheet.Protect = False

                            If Me.FindForm.Name.Contains("13129") Then
                                Me.SaveExcel(filelocation, FarPoint.Excel.ExcelSaveFlags.SaveBothCustomRowAndColumnHeaders Or FarPoint.Excel.ExcelSaveFlags.SaveAsFiltered)
                            ElseIf Me.FindForm.Name.Contains("1311") Or Me.FindForm.Name.Contains("1312") Then
                                Me.SaveExcel(filelocation, FarPoint.Excel.ExcelSaveFlags.UseOOXMLFormat Or FarPoint.Excel.ExcelSaveFlags.SaveBothCustomRowAndColumnHeaders Or FarPoint.Excel.ExcelSaveFlags.SaveAsFiltered)
                            Else
                                Me.SaveExcel(filelocation, FarPoint.Excel.ExcelSaveFlags.SaveBothCustomRowAndColumnHeaders Or FarPoint.Excel.ExcelSaveFlags.UseOOXMLFormat Or FarPoint.Excel.ExcelSaveFlags.SaveAsFiltered)
                            End If

                            Dim str = MsgBoxP("Finish. Would you like to open it?", vbYesNo)
                            If str = MsgBoxResult.Yes Then
                                Process.Start(filelocation)
                            End If
                            Exit Sub
                        End If

                    Case Keys.E

                        If My.Computer.FileSystem.DirectoryExists(App_Path & "\Temp") = False Then
                            System.IO.Directory.CreateDirectory(App_Path & "\Temp")
                        End If

                        Dim filelocation As String
                        Dim sv_1 As New SheetView
                        Dim int_CH As Integer
                        Dim Int_Col As Integer

                        filelocation = App_Path & "\Temp\" & Me.Name & System_Date_time() & ".xls"
                        int_CH = Me.ActiveSheet.ColumnHeader.RowCount


                        sv_1 = Clone_SV(Me.ActiveSheet)
                        sv_1.Rows.Add(0, 4 + int_CH)
                        sv_1.Protect = False

                        Int_Col = sv_1.ColumnCount - 1
                        While Int_Col >= 0
                            If sv_1.Columns(Int_Col).Visible = False Or sv_1.Columns(Int_Col).Width < 10 Then
                                sv_1.Columns(Int_Col).Remove()
                                Int_Col = Int_Col - 1
                            Else
                                Int_Col = Int_Col - 1
                            End If
                        End While


                        sv_1.Cells(4, 0, 4 + int_CH - 1, sv_1.ColumnCount - 1).BackColor = Color.Gray
                        sv_1.Cells(4, 0, 4 + int_CH - 1, sv_1.ColumnCount - 1).VerticalAlignment = CellVerticalAlignment.Center
                        sv_1.Cells(4, 0, 4 + int_CH - 1, sv_1.ColumnCount - 1).HorizontalAlignment = CellHorizontalAlignment.Center


                        For Int_Col = 4 To 4 + int_CH
                            sv_1.Rows(Int_Col).BackColor = Color.Empty
                        Next

                        If Split(Me.Tag.ToString, ";").Length = 2 Then
                            If READ_PFK9914("dms", Split(Me.Tag.ToString, ";")(0), Split(Me.Tag.ToString, ";")(1)) Then
                                If D9914.Header = "1" Then sv_1.Cells(4 + int_CH, 0, 4 + int_CH, sv_1.ColumnCount - 1).BackColor = Color.Yellow
                            End If
                        End If

                        Dim Int_Col2 As Integer
                        Dim Int_List As New List(Of Integer)
                        Dim str_List(sv_1.ColumnHeader.RowCount - 1) As List(Of String)

                        For Int_Col2 = 0 To int_CH - 1
                            str_List(Int_Col2) = New List(Of String)
                            str_List(Int_Col2).Clear()
                        Next

                        For Int_Col = 0 To sv_1.ColumnCount - 1
                            Int_List.Add(Int_Col)

                            For Int_Col2 = 0 To int_CH - 1
                                str_List(Int_Col2).Add(sv_1.ColumnHeader.Cells(0 + Int_Col2, Int_Col).Value)

                                sv_1.Cells(4 + Int_Col2, Int_Col).ColumnSpan = sv_1.ColumnHeader.Cells(0 + Int_Col2, Int_Col).ColumnSpan
                                sv_1.Cells(4 + Int_Col2, Int_Col).RowSpan = sv_1.ColumnHeader.Cells(0 + Int_Col2, Int_Col).RowSpan

                                sv_1.Cells(4 + Int_Col2, Int_Col).VerticalAlignment = CellVerticalAlignment.Center
                                sv_1.Cells(4 + Int_Col2, Int_Col).HorizontalAlignment = CellHorizontalAlignment.Center
                                sv_1.Cells(4 + Int_Col2, Int_Col).Font = New Font("Tahoma", 8, FontStyle.Bold)
                            Next

                        Next

                        Dim bottomborder As New FarPoint.Win.ComplexBorderSide(True, Color.Gray, 1, System.Drawing.Drawing2D.DashStyle.Solid, Nothing, Nothing) ' New Single() {0.1, 0.1, 0.1, 0.1, 0.1, 0.1})
                        sv_1.Cells(4, 0, sv_1.RowCount - 1, sv_1.ColumnCount - 1).Border = New FarPoint.Win.ComplexBorder(bottomborder, bottomborder, bottomborder, bottomborder)

                        Dim bottomborder2 As New FarPoint.Win.ComplexBorderSide(True, Color.Black, 1, System.Drawing.Drawing2D.DashStyle.Solid, Nothing, Nothing) ' New Single() {0.1, 0.1, 0.1, 0.1, 0.1, 0.1})
                        sv_1.Cells(4, 0, 4 + int_CH, sv_1.ColumnCount - 1).Border = New FarPoint.Win.ComplexBorder(bottomborder2, bottomborder2, bottomborder2, bottomborder2)

                        sv_1.Cells(3, 0).Value = Me.FindForm.Text
                        sv_1.Cells(3, 0).ColumnSpan = sv_1.ColumnCount

                        sv_1.Cells(0, 0).VerticalAlignment = CellVerticalAlignment.Center
                        sv_1.Cells(0, 0).HorizontalAlignment = CellHorizontalAlignment.Left
                        sv_1.Cells(1, 0).VerticalAlignment = CellVerticalAlignment.Center
                        sv_1.Cells(1, 0).HorizontalAlignment = CellHorizontalAlignment.Left
                        sv_1.Cells(2, 0).VerticalAlignment = CellVerticalAlignment.Center
                        sv_1.Cells(2, 0).HorizontalAlignment = CellHorizontalAlignment.Left
                        sv_1.Cells(3, 0).VerticalAlignment = CellVerticalAlignment.Center
                        sv_1.Cells(3, 0).HorizontalAlignment = CellHorizontalAlignment.Left

                        sv_1.Cells(3, 0).Font = New Font("Tahoma", 16, FontStyle.Bold)

                        Dim fpSpread1 As New FarPoint.Win.Spread.FpSpread()
                        fpSpread1.Sheets.Add(sv_1)
                        fpSpread1.Font = New Font("Tahoma", 8)

                        fpSpread1.ActiveSheet.FrozenColumnCount = 0
                        fpSpread1.ActiveSheet.FrozenRowCount = 0

                        fpSpread1.SaveExcel(filelocation, FarPoint.Excel.ExcelSaveFlags.NoFlagsSet Or FarPoint.Excel.ExcelSaveFlags.NoFormulas Or FarPoint.Excel.ExcelSaveFlags.NoNotes)
                        Call ChangeTitle(Me, filelocation, Int_List, str_List)


                End Select
            ElseIf e.KeyCode = Keys.Insert Then
                If InsChk = False Then Exit Sub
                If row = sender.ActiveSheet.RowCount - 1 Then
                    Me.ActiveSheet.RowCount += 1
                    Me.ActiveSheet.ActiveRowIndex = row + 1
                Else
                    Me.ActiveSheet.AddRows(row, 1)
                End If


            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub PeaceFarpoint_ColumnWidthChanged(sender As Object, e As Spread.ColumnWidthChangedEventArgs) Handles Me.ColumnWidthChanged
        Dim StrTag As String
        StrTag = Me.Tag
        Try
            If StrTag.Split(";").Length <> 2 Then Exit Sub

            If READ_PFK9912_2("DMS", StrTag.Split(";")(0), StrTag.Split(";")(1), Me.ActiveSheet.Columns(e.ColumnList.Item(0).firstcolumn).Tag) Then

                If READ_PFK9913_ITEMNAME(Pub.SAW, "DMS", StrTag.Split(";")(0), StrTag.Split(";")(1), D9912.ItemCode) = True Then
                    D9913.SizeWidth = Me.ActiveSheet.Columns(e.ColumnList.Item(0).firstcolumn).Width

                    Call REWRITE_PFK9913(D9913)

                End If

            End If

        Catch ex As Exception

        End Try


    End Sub
End Class

