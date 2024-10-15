<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD4010A
    Inherits PeaceForm_ISUD

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim EnhancedScrollBarRenderer1 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim NamedStyle1 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("DataAreaDefault")
        Dim GeneralCellType1 As FarPoint.Win.Spread.CellType.GeneralCellType = New FarPoint.Win.Spread.CellType.GeneralCellType()
        Dim NamedStyle2 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style2")
        Dim BevelBorder1 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType1 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle3 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style3")
        Dim BevelBorder2 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType2 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle4 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style1")
        Dim BevelBorder3 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType3 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle5 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style4")
        Dim BevelBorder4 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType4 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle6 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style5")
        Dim GeneralCellType2 As FarPoint.Win.Spread.CellType.GeneralCellType = New FarPoint.Win.Spread.CellType.GeneralCellType()
        Dim SpreadSkin1 As FarPoint.Win.Spread.SpreadSkin = New FarPoint.Win.Spread.SpreadSkin()
        Dim EnhancedFocusIndicatorRenderer1 As FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer = New FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer()
        Dim EnhancedInterfaceRenderer1 As FarPoint.Win.Spread.EnhancedInterfaceRenderer = New FarPoint.Win.Spread.EnhancedInterfaceRenderer()
        Dim EnhancedScrollBarRenderer2 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim EnhancedScrollBarRenderer3 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim Vs1_InputMapWhenFocusedSingleSelect As FarPoint.Win.Spread.InputMap
        Dim Vs1_InputMapWhenAncestorOfFocusedSingleSelect As FarPoint.Win.Spread.InputMap
        Dim TextCellType5 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Me.Frame1 = New PSMGlobal.PeacePanel(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Vs1 = New PSMGlobal.PeaceFarpoint()
        Me.Vs1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.FlowLayoutPanel2 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_QtyAverage = New PSMGlobal.SelectLabelText()
        Me.txt_QtyOrder = New PSMGlobal.SelectLabelText()
        Me.txt_cdJobState = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_DatePlanFinish = New PSMGlobal.SelectPeaceCalSin()
        Me.txt_DatePlanStart = New PSMGlobal.SelectPeaceCalSin()
        Me.txt_cdFactory = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_JobCard = New PSMGlobal.SelectLabelText()
        Me.tit_Use = New PSMGlobal.PeaceLabel(Me.components)
        Me.Panel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_CheckPlan4 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckPlan3 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckPlan5 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckPlan1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckPlan2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.txt_JobCardBefore = New PSMGlobal.SelectLabelText()
        Me.txt_JobCardAfter = New PSMGlobal.SelectLabelText()
        Vs1_InputMapWhenFocusedSingleSelect = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenFocusedSingleSelect.Parent = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedSingleSelect = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedSingleSelect.Parent = New FarPoint.Win.Spread.InputMap()
        CType(Me.Frame1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlowLayoutPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Code = ""
        Me.Frame1.Controls.Add(Me.TableLayoutPanel1)
        Me.Frame1.Data = ""
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame1.Location = New System.Drawing.Point(0, 38)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(1074, 413)
        Me.Frame1.TabIndex = 4
        Me.Frame1.Tag = ""
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Vs1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 41)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1069, 368)
        Me.TableLayoutPanel1.TabIndex = 103
        '
        'Vs1
        '
        Me.Vs1.AccessibleDescription = "Vs1, Sheet1, Row 0, Column 0, "
        Me.Vs1.AllowDragFill = True
        Me.Vs1.AllowEditorReservedLocations = False
        Me.Vs1.AutoClipboard = False
        Me.Vs1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Vs1.ClipboardOptions = FarPoint.Win.Spread.ClipboardOptions.NoHeaders
        Me.Vs1.CopyPasteChk = False
        Me.Vs1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Vs1.FocusRenderer = New FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer(1)
        Me.Vs1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs1.HorizontalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.Vs1.HorizontalScrollBar.Name = ""
        EnhancedScrollBarRenderer1.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer1.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.Vs1.HorizontalScrollBar.Renderer = EnhancedScrollBarRenderer1
        Me.Vs1.HorizontalScrollBar.TabIndex = 0
        Me.Vs1.InsChk = True
        Me.Vs1.Location = New System.Drawing.Point(3, 119)
        Me.Vs1.Name = "Vs1"
        NamedStyle1.BackColor = System.Drawing.SystemColors.Window
        NamedStyle1.CellType = GeneralCellType1
        NamedStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        NamedStyle1.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle1.Renderer = GeneralCellType1
        NamedStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle2.Border = BevelBorder1
        NamedStyle2.CanFocus = False
        NamedStyle2.CellType = TextCellType1
        NamedStyle2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        NamedStyle2.ForeColor = System.Drawing.Color.White
        NamedStyle2.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle2.Locked = False
        NamedStyle2.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle2.Renderer = TextCellType1
        NamedStyle2.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle2.VisualStyles = FarPoint.Win.VisualStyles.Off
        NamedStyle3.Border = BevelBorder2
        NamedStyle3.CellType = TextCellType2
        NamedStyle3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamedStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle3.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle3.Locked = False
        NamedStyle3.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle3.Renderer = TextCellType2
        NamedStyle3.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle4.Border = BevelBorder3
        NamedStyle4.CanFocus = False
        NamedStyle4.CellType = TextCellType3
        NamedStyle4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamedStyle4.ForeColor = System.Drawing.Color.White
        NamedStyle4.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle4.Locked = False
        NamedStyle4.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle4.Renderer = TextCellType3
        NamedStyle4.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle4.VisualStyles = FarPoint.Win.VisualStyles.Off
        NamedStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle5.Border = BevelBorder4
        NamedStyle5.CellType = TextCellType4
        NamedStyle5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        NamedStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle5.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle5.Locked = False
        NamedStyle5.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle5.Renderer = TextCellType4
        NamedStyle5.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle6.BackColor = System.Drawing.SystemColors.Window
        NamedStyle6.CellType = GeneralCellType2
        NamedStyle6.Font = New System.Drawing.Font("Tahoma", 9.0!)
        NamedStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        NamedStyle6.Locked = False
        NamedStyle6.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle6.Renderer = GeneralCellType2
        Me.Vs1.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle1, NamedStyle2, NamedStyle3, NamedStyle4, NamedStyle5, NamedStyle6})
        Me.Vs1.ReportName = Nothing
        Me.Vs1.SheetDSName = Nothing
        Me.Vs1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.Vs1_Sheet1})
        Me.Vs1.Size = New System.Drawing.Size(1063, 246)
        SpreadSkin1.ColumnFooterDefaultStyle = NamedStyle3
        SpreadSkin1.ColumnHeaderDefaultStyle = NamedStyle2
        SpreadSkin1.CornerDefaultStyle = NamedStyle5
        SpreadSkin1.DefaultStyle = NamedStyle6
        SpreadSkin1.FocusRenderer = EnhancedFocusIndicatorRenderer1
        EnhancedInterfaceRenderer1.ScrollBoxBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(221, Byte), Integer))
        EnhancedInterfaceRenderer1.SheetTabLowerActiveColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(244, Byte), Integer))
        EnhancedInterfaceRenderer1.SheetTabLowerNormalColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(249, Byte), Integer))
        EnhancedInterfaceRenderer1.SheetTabUpperActiveColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(244, Byte), Integer))
        EnhancedInterfaceRenderer1.SheetTabUpperNormalColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(249, Byte), Integer))
        EnhancedInterfaceRenderer1.TabStripBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(221, Byte), Integer))
        SpreadSkin1.InterfaceRenderer = EnhancedInterfaceRenderer1
        SpreadSkin1.Name = "Hung123"
        SpreadSkin1.RowHeaderDefaultStyle = NamedStyle4
        EnhancedScrollBarRenderer2.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer2.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer2.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer2.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer2.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer2.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer2.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer2.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        SpreadSkin1.ScrollBarRenderer = EnhancedScrollBarRenderer2
        SpreadSkin1.SelectionRenderer = New FarPoint.Win.Spread.DefaultSelectionRenderer()
        Me.Vs1.Skin = SpreadSkin1
        Me.Vs1.SpreadWjob = 0
        Me.Vs1.TabIndex = 0
        Me.Vs1.TabStrip.DefaultSheetTab.BackColor = System.Drawing.Color.White
        Me.Vs1.TabStrip.DefaultSheetTab.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vs1.VerticalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.Vs1.VerticalScrollBar.Name = ""
        EnhancedScrollBarRenderer3.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer3.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.Vs1.VerticalScrollBar.Renderer = EnhancedScrollBarRenderer3
        Me.Vs1.VerticalScrollBar.TabIndex = 3
        Vs1_InputMapWhenFocusedSingleSelect.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Vs1_InputMapWhenFocusedSingleSelect.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        Vs1_InputMapWhenFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.C, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCopy)
        Vs1_InputMapWhenFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Insert, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCopy)
        Vs1_InputMapWhenFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Z, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Undo)
        Vs1_InputMapWhenFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Y, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Redo)
        Me.Vs1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.SingleSelect, Vs1_InputMapWhenFocusedSingleSelect)
        Vs1_InputMapWhenAncestorOfFocusedSingleSelect.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Vs1_InputMapWhenAncestorOfFocusedSingleSelect.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        Vs1_InputMapWhenAncestorOfFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.SelectPreviousItem)
        Vs1_InputMapWhenAncestorOfFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.SelectNextItem)
        Vs1_InputMapWhenAncestorOfFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ScrollToPreviousColumnVisual)
        Vs1_InputMapWhenAncestorOfFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ScrollToNextColumnVisual)
        Vs1_InputMapWhenAncestorOfFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.SelectPreviousPageOfItems)
        Vs1_InputMapWhenAncestorOfFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.SelectNextPageOfItems)
        Vs1_InputMapWhenAncestorOfFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.SelectFirstItem)
        Vs1_InputMapWhenAncestorOfFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.SelectLastItem)
        Me.Vs1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused, FarPoint.Win.Spread.OperationMode.SingleSelect, Vs1_InputMapWhenAncestorOfFocusedSingleSelect)
        '
        'Vs1_Sheet1
        '
        Me.Vs1_Sheet1.Reset()
        Me.Vs1_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.Vs1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.Vs1_Sheet1.ColumnCount = 29
        Me.Vs1_Sheet1.RowCount = 10
        Me.Vs1_Sheet1.ActiveSkin = New FarPoint.Win.Spread.SheetSkin("SheetSkin1", System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer)), FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer)), System.Drawing.Color.White, System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.White, System.Drawing.SystemColors.ButtonFace, False, False, False, True, True, True, False, True, "RowHeaderDefault", "RowHeaderDefault", "RowHeaderDefault", "DataAreaDefault", "RowHeaderDefault")
        Me.Vs1_Sheet1.ColumnFooter.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnFooter.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Vs1_Sheet1.ColumnFooter.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Vs1_Sheet1.ColumnFooter.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.ColumnFooter.DefaultStyle.Parent = "RowHeaderDefault"
        Me.Vs1_Sheet1.ColumnFooter.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnFooter.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.ForeColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.Parent = "RowHeaderDefault"
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnHeader.Cells.Get(0, 0).Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Vs1_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        TextCellType5.WordWrap = True
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.CellType = TextCellType5
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.Renderer = TextCellType5
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnHeader.Rows.Get(0).Height = 25.0!
        Me.Vs1_Sheet1.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs1_Sheet1.DefaultStyle.ForeColor = System.Drawing.Color.Black
        Me.Vs1_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.DefaultStyle.Parent = "DataAreaDefault"
        Me.Vs1_Sheet1.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.Vs1_Sheet1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.FilterBar.DefaultStyle.Parent = "FilterBarDefaultEnhanced"
        Me.Vs1_Sheet1.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.Vs1_Sheet1.GroupBarInfo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vs1_Sheet1.NullFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs1_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.SingleSelect
        Me.Vs1_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.Vs1_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.CellType = TextCellType5
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.Renderer = TextCellType5
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.Rows.Default.Height = 22.0!
        Me.Vs1_Sheet1.SelectionBackColor = System.Drawing.Color.Aquamarine
        Me.Vs1_Sheet1.SelectionPolicy = FarPoint.Win.Spread.Model.SelectionPolicy.[Single]
        Me.Vs1_Sheet1.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.SelectionColors
        Me.Vs1_Sheet1.SelectionUnit = FarPoint.Win.Spread.Model.SelectionUnit.Row
        Me.Vs1_Sheet1.SheetCornerStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Vs1_Sheet1.SheetCornerStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Vs1_Sheet1.SheetCornerStyle.ForeColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.SheetCornerStyle.Parent = "RowHeaderDefault"
        Me.Vs1_Sheet1.SheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.FlowLayoutPanel2.Code = ""
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_JobCardAfter)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_JobCardBefore)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_QtyAverage)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_QtyOrder)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_cdJobState)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_DatePlanFinish)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_DatePlanStart)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_cdFactory)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_JobCard)
        Me.FlowLayoutPanel2.Controls.Add(Me.tit_Use)
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel5)
        Me.FlowLayoutPanel2.Data = ""
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1059, 110)
        Me.FlowLayoutPanel2.TabIndex = 102
        Me.FlowLayoutPanel2.Tag = ""
        '
        'txt_QtyAverage
        '
        Me.txt_QtyAverage.BackYesno = False
        Me.txt_QtyAverage.ButtonTitle = Nothing
        Me.txt_QtyAverage.Code = Nothing
        Me.txt_QtyAverage.Data = ""
        Me.txt_QtyAverage.DataDecimal = 0
        Me.txt_QtyAverage.DataLen = 0
        Me.txt_QtyAverage.DataValue = 0
        Me.txt_QtyAverage.FormatDecimal = 0
        Me.txt_QtyAverage.FormatValue = False
        Me.txt_QtyAverage.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_QtyAverage.LableEnabled = True
        Me.txt_QtyAverage.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_QtyAverage.LableForeColor = System.Drawing.Color.Black
        Me.txt_QtyAverage.LableTitle = "Qty AVG"
        Me.txt_QtyAverage.Layoutpercent = New Decimal(New Integer() {42, 0, 0, 131072})
        Me.txt_QtyAverage.Location = New System.Drawing.Point(503, 58)
        Me.txt_QtyAverage.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_QtyAverage.Name = "txt_QtyAverage"
        Me.txt_QtyAverage.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_QtyAverage.Size = New System.Drawing.Size(252, 26)
        Me.txt_QtyAverage.TabIndex = 161
        Me.txt_QtyAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_QtyAverage.TextBoxAutoComplete = False
        Me.txt_QtyAverage.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_QtyAverage.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_QtyAverage.TextEnabled = True
        Me.txt_QtyAverage.TextForeColor = System.Drawing.Color.Empty
        Me.txt_QtyAverage.TextMaxLength = 32767
        Me.txt_QtyAverage.TextMultiLine = False
        Me.txt_QtyAverage.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_QtyAverage.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_QtyAverage.UseSendTab = True
        '
        'txt_QtyOrder
        '
        Me.txt_QtyOrder.BackYesno = False
        Me.txt_QtyOrder.ButtonTitle = Nothing
        Me.txt_QtyOrder.Code = Nothing
        Me.txt_QtyOrder.Data = ""
        Me.txt_QtyOrder.DataDecimal = 0
        Me.txt_QtyOrder.DataLen = 0
        Me.txt_QtyOrder.DataValue = 0
        Me.txt_QtyOrder.FormatDecimal = 0
        Me.txt_QtyOrder.FormatValue = False
        Me.txt_QtyOrder.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_QtyOrder.LableEnabled = True
        Me.txt_QtyOrder.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_QtyOrder.LableForeColor = System.Drawing.Color.Black
        Me.txt_QtyOrder.LableTitle = "Qty Order"
        Me.txt_QtyOrder.Layoutpercent = New Decimal(New Integer() {42, 0, 0, 131072})
        Me.txt_QtyOrder.Location = New System.Drawing.Point(239, 57)
        Me.txt_QtyOrder.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_QtyOrder.Name = "txt_QtyOrder"
        Me.txt_QtyOrder.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_QtyOrder.Size = New System.Drawing.Size(262, 26)
        Me.txt_QtyOrder.TabIndex = 160
        Me.txt_QtyOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_QtyOrder.TextBoxAutoComplete = False
        Me.txt_QtyOrder.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_QtyOrder.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_QtyOrder.TextEnabled = True
        Me.txt_QtyOrder.TextForeColor = System.Drawing.Color.Empty
        Me.txt_QtyOrder.TextMaxLength = 32767
        Me.txt_QtyOrder.TextMultiLine = False
        Me.txt_QtyOrder.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_QtyOrder.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_QtyOrder.UseSendTab = True
        '
        'txt_cdJobState
        '
        Me.txt_cdJobState.BackYesno = False
        Me.txt_cdJobState.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdJobState.ButtonEnabled = True
        Me.txt_cdJobState.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdJobState.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdJobState.ButtonName = ""
        Me.txt_cdJobState.ButtonTitle = "Job State"
        Me.txt_cdJobState.Code = ""
        Me.txt_cdJobState.Data = ""
        Me.txt_cdJobState.DataDecimal = 1
        Me.txt_cdJobState.DataLen = 0
        Me.txt_cdJobState.DataValue = 1
        Me.txt_cdJobState.Layoutpercent = New Decimal(New Integer() {42, 0, 0, 131072})
        Me.txt_cdJobState.Location = New System.Drawing.Point(239, 85)
        Me.txt_cdJobState.Margin = New System.Windows.Forms.Padding(1, 1, 171, 1)
        Me.txt_cdJobState.Name = "txt_cdJobState"
        Me.txt_cdJobState.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdJobState.Size = New System.Drawing.Size(262, 24)
        Me.txt_cdJobState.TabIndex = 159
        Me.txt_cdJobState.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdJobState.TextBoxAutoComplete = True
        Me.txt_cdJobState.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdJobState.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_cdJobState.TextEnabled = False
        Me.txt_cdJobState.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdJobState.TextMaxLength = 32767
        Me.txt_cdJobState.TextMultiLine = False
        Me.txt_cdJobState.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdJobState.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdJobState.UseSendTab = True
        '
        'txt_DatePlanFinish
        '
        Me.txt_DatePlanFinish.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_DatePlanFinish.ButtonEnabled = True
        Me.txt_DatePlanFinish.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_DatePlanFinish.ButtonName = Nothing
        Me.txt_DatePlanFinish.ButtonTitle = "Finish Date"
        Me.txt_DatePlanFinish.Code = ""
        Me.txt_DatePlanFinish.Data = "20150101"
        Me.txt_DatePlanFinish.DataDecimal = 1
        Me.txt_DatePlanFinish.DataLen = 0
        Me.txt_DatePlanFinish.DataValue = 0
        Me.txt_DatePlanFinish.FormatDecimal = 0
        Me.txt_DatePlanFinish.FormatValue = False
        Me.txt_DatePlanFinish.Layoutpercent = New Decimal(New Integer() {42, 0, 0, 131072})
        Me.txt_DatePlanFinish.Location = New System.Drawing.Point(502, 32)
        Me.txt_DatePlanFinish.Margin = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.txt_DatePlanFinish.Name = "txt_DatePlanFinish"
        Me.txt_DatePlanFinish.Size = New System.Drawing.Size(253, 24)
        Me.txt_DatePlanFinish.TabIndex = 158
        Me.txt_DatePlanFinish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_DatePlanFinish.TextBoxAutoComplete = False
        Me.txt_DatePlanFinish.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DatePlanFinish.TextEnabled = True
        Me.txt_DatePlanFinish.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DatePlanFinish.TextMaxLength = 32767
        Me.txt_DatePlanFinish.TextMultiLine = True
        Me.txt_DatePlanFinish.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        '
        'txt_DatePlanStart
        '
        Me.txt_DatePlanStart.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_DatePlanStart.ButtonEnabled = True
        Me.txt_DatePlanStart.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_DatePlanStart.ButtonName = Nothing
        Me.txt_DatePlanStart.ButtonTitle = "Start Date"
        Me.txt_DatePlanStart.Code = ""
        Me.txt_DatePlanStart.Data = "20150101"
        Me.txt_DatePlanStart.DataDecimal = 1
        Me.txt_DatePlanStart.DataLen = 0
        Me.txt_DatePlanStart.DataValue = 0
        Me.txt_DatePlanStart.FormatDecimal = 0
        Me.txt_DatePlanStart.FormatValue = False
        Me.txt_DatePlanStart.Layoutpercent = New Decimal(New Integer() {42, 0, 0, 131072})
        Me.txt_DatePlanStart.Location = New System.Drawing.Point(239, 32)
        Me.txt_DatePlanStart.Margin = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.txt_DatePlanStart.Name = "txt_DatePlanStart"
        Me.txt_DatePlanStart.Size = New System.Drawing.Size(262, 24)
        Me.txt_DatePlanStart.TabIndex = 157
        Me.txt_DatePlanStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_DatePlanStart.TextBoxAutoComplete = False
        Me.txt_DatePlanStart.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DatePlanStart.TextEnabled = True
        Me.txt_DatePlanStart.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DatePlanStart.TextMaxLength = 32767
        Me.txt_DatePlanStart.TextMultiLine = True
        Me.txt_DatePlanStart.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        '
        'txt_cdFactory
        '
        Me.txt_cdFactory.BackYesno = False
        Me.txt_cdFactory.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdFactory.ButtonEnabled = True
        Me.txt_cdFactory.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdFactory.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.ButtonName = ""
        Me.txt_cdFactory.ButtonTitle = "Factory"
        Me.txt_cdFactory.Code = ""
        Me.txt_cdFactory.Data = ""
        Me.txt_cdFactory.DataDecimal = 1
        Me.txt_cdFactory.DataLen = 0
        Me.txt_cdFactory.DataValue = 1
        Me.txt_cdFactory.Layoutpercent = New Decimal(New Integer() {49, 0, 0, 131072})
        Me.txt_cdFactory.Location = New System.Drawing.Point(5, 31)
        Me.txt_cdFactory.Margin = New System.Windows.Forms.Padding(1, 1, 171, 1)
        Me.txt_cdFactory.Name = "txt_cdFactory"
        Me.txt_cdFactory.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdFactory.Size = New System.Drawing.Size(232, 24)
        Me.txt_cdFactory.TabIndex = 12
        Me.txt_cdFactory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdFactory.TextBoxAutoComplete = True
        Me.txt_cdFactory.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_cdFactory.TextEnabled = False
        Me.txt_cdFactory.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.TextMaxLength = 32767
        Me.txt_cdFactory.TextMultiLine = False
        Me.txt_cdFactory.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdFactory.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdFactory.UseSendTab = True
        '
        'txt_JobCard
        '
        Me.txt_JobCard.BackYesno = False
        Me.txt_JobCard.ButtonTitle = Nothing
        Me.txt_JobCard.Code = Nothing
        Me.txt_JobCard.Data = ""
        Me.txt_JobCard.DataDecimal = 0
        Me.txt_JobCard.DataLen = 0
        Me.txt_JobCard.DataValue = 0
        Me.txt_JobCard.FormatDecimal = 0
        Me.txt_JobCard.FormatValue = False
        Me.txt_JobCard.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_JobCard.LableEnabled = True
        Me.txt_JobCard.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_JobCard.LableForeColor = System.Drawing.Color.Black
        Me.txt_JobCard.LableTitle = "JobCard"
        Me.txt_JobCard.Layoutpercent = New Decimal(New Integer() {508, 0, 0, 196608})
        Me.txt_JobCard.Location = New System.Drawing.Point(3, 3)
        Me.txt_JobCard.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_JobCard.Name = "txt_JobCard"
        Me.txt_JobCard.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_JobCard.Size = New System.Drawing.Size(234, 26)
        Me.txt_JobCard.TabIndex = 1
        Me.txt_JobCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_JobCard.TextBoxAutoComplete = False
        Me.txt_JobCard.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_JobCard.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_JobCard.TextEnabled = True
        Me.txt_JobCard.TextForeColor = System.Drawing.Color.Empty
        Me.txt_JobCard.TextMaxLength = 32767
        Me.txt_JobCard.TextMultiLine = False
        Me.txt_JobCard.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_JobCard.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_JobCard.UseSendTab = True
        '
        'tit_Use
        '
        Me.tit_Use.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.tit_Use.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tit_Use.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tit_Use.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tit_Use.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.tit_Use.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tit_Use.ButtonTitle = Nothing
        Me.tit_Use.Code = ""
        Me.tit_Use.Data = ""
        Me.tit_Use.DTDec = 0
        Me.tit_Use.DTLen = 0
        Me.tit_Use.DTValue = 0
        Me.tit_Use.Location = New System.Drawing.Point(239, 3)
        Me.tit_Use.Margin = New System.Windows.Forms.Padding(1)
        Me.tit_Use.Name = "tit_Use"
        Me.tit_Use.NoClear = False
        Me.tit_Use.Size = New System.Drawing.Size(116, 27)
        Me.tit_Use.TabIndex = 9
        Me.tit_Use.Tag = ""
        Me.tit_Use.Text = "Use"
        Me.tit_Use.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Panel5.ColumnCount = 5
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Panel5.Controls.Add(Me.rad_CheckPlan4, 0, 0)
        Me.Panel5.Controls.Add(Me.rad_CheckPlan3, 0, 0)
        Me.Panel5.Controls.Add(Me.rad_CheckPlan5, 1, 0)
        Me.Panel5.Controls.Add(Me.rad_CheckPlan1, 1, 0)
        Me.Panel5.Controls.Add(Me.rad_CheckPlan2, 0, 0)
        Me.Panel5.Location = New System.Drawing.Point(357, 3)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(1, 1, 200, 1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.RowCount = 1
        Me.Panel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel5.Size = New System.Drawing.Size(702, 27)
        Me.Panel5.TabIndex = 10
        '
        'rad_CheckPlan4
        '
        Me.rad_CheckPlan4.AutoSize = True
        Me.rad_CheckPlan4.BackColor = System.Drawing.Color.Red
        Me.rad_CheckPlan4.ButtonTitle = Nothing
        Me.rad_CheckPlan4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckPlan4.ForeColor = System.Drawing.Color.Black
        Me.rad_CheckPlan4.Location = New System.Drawing.Point(284, 4)
        Me.rad_CheckPlan4.Name = "rad_CheckPlan4"
        Me.rad_CheckPlan4.Size = New System.Drawing.Size(67, 18)
        Me.rad_CheckPlan4.TabIndex = 4
        Me.rad_CheckPlan4.TabStop = True
        Me.rad_CheckPlan4.Text = "Urgent"
        Me.rad_CheckPlan4.UseVisualStyleBackColor = False
        '
        'rad_CheckPlan3
        '
        Me.rad_CheckPlan3.AutoSize = True
        Me.rad_CheckPlan3.BackColor = System.Drawing.Color.Lime
        Me.rad_CheckPlan3.ButtonTitle = Nothing
        Me.rad_CheckPlan3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckPlan3.Location = New System.Drawing.Point(144, 4)
        Me.rad_CheckPlan3.Name = "rad_CheckPlan3"
        Me.rad_CheckPlan3.Size = New System.Drawing.Size(90, 18)
        Me.rad_CheckPlan3.TabIndex = 3
        Me.rad_CheckPlan3.TabStop = True
        Me.rad_CheckPlan3.Text = "Processing"
        Me.rad_CheckPlan3.UseVisualStyleBackColor = False
        '
        'rad_CheckPlan5
        '
        Me.rad_CheckPlan5.AutoSize = True
        Me.rad_CheckPlan5.BackColor = System.Drawing.Color.Orange
        Me.rad_CheckPlan5.ButtonTitle = Nothing
        Me.rad_CheckPlan5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckPlan5.Location = New System.Drawing.Point(424, 4)
        Me.rad_CheckPlan5.Name = "rad_CheckPlan5"
        Me.rad_CheckPlan5.Size = New System.Drawing.Size(64, 18)
        Me.rad_CheckPlan5.TabIndex = 1
        Me.rad_CheckPlan5.TabStop = True
        Me.rad_CheckPlan5.Text = "Cancel"
        Me.rad_CheckPlan5.UseVisualStyleBackColor = False
        '
        'rad_CheckPlan1
        '
        Me.rad_CheckPlan1.AutoSize = True
        Me.rad_CheckPlan1.BackColor = System.Drawing.Color.Yellow
        Me.rad_CheckPlan1.ButtonTitle = Nothing
        Me.rad_CheckPlan1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckPlan1.Location = New System.Drawing.Point(564, 4)
        Me.rad_CheckPlan1.Name = "rad_CheckPlan1"
        Me.rad_CheckPlan1.Size = New System.Drawing.Size(83, 18)
        Me.rad_CheckPlan1.TabIndex = 2
        Me.rad_CheckPlan1.TabStop = True
        Me.rad_CheckPlan1.Text = "Complete"
        Me.rad_CheckPlan1.UseVisualStyleBackColor = False
        '
        'rad_CheckPlan2
        '
        Me.rad_CheckPlan2.AutoSize = True
        Me.rad_CheckPlan2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.rad_CheckPlan2.ButtonTitle = Nothing
        Me.rad_CheckPlan2.Checked = True
        Me.rad_CheckPlan2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckPlan2.Location = New System.Drawing.Point(4, 4)
        Me.rad_CheckPlan2.Name = "rad_CheckPlan2"
        Me.rad_CheckPlan2.Size = New System.Drawing.Size(51, 18)
        Me.rad_CheckPlan2.TabIndex = 0
        Me.rad_CheckPlan2.TabStop = True
        Me.rad_CheckPlan2.Text = "Plan"
        Me.rad_CheckPlan2.UseVisualStyleBackColor = False
        '
        'txt_JobCardBefore
        '
        Me.txt_JobCardBefore.BackYesno = False
        Me.txt_JobCardBefore.ButtonTitle = Nothing
        Me.txt_JobCardBefore.Code = Nothing
        Me.txt_JobCardBefore.Data = ""
        Me.txt_JobCardBefore.DataDecimal = 0
        Me.txt_JobCardBefore.DataLen = 0
        Me.txt_JobCardBefore.DataValue = 0
        Me.txt_JobCardBefore.FormatDecimal = 0
        Me.txt_JobCardBefore.FormatValue = False
        Me.txt_JobCardBefore.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_JobCardBefore.LableEnabled = True
        Me.txt_JobCardBefore.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_JobCardBefore.LableForeColor = System.Drawing.Color.Black
        Me.txt_JobCardBefore.LableTitle = "JobCard Before"
        Me.txt_JobCardBefore.Layoutpercent = New Decimal(New Integer() {508, 0, 0, 196608})
        Me.txt_JobCardBefore.Location = New System.Drawing.Point(757, 32)
        Me.txt_JobCardBefore.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_JobCardBefore.Name = "txt_JobCardBefore"
        Me.txt_JobCardBefore.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_JobCardBefore.Size = New System.Drawing.Size(299, 24)
        Me.txt_JobCardBefore.TabIndex = 162
        Me.txt_JobCardBefore.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_JobCardBefore.TextBoxAutoComplete = False
        Me.txt_JobCardBefore.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_JobCardBefore.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_JobCardBefore.TextEnabled = True
        Me.txt_JobCardBefore.TextForeColor = System.Drawing.Color.Empty
        Me.txt_JobCardBefore.TextMaxLength = 32767
        Me.txt_JobCardBefore.TextMultiLine = False
        Me.txt_JobCardBefore.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_JobCardBefore.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_JobCardBefore.UseSendTab = True
        '
        'txt_JobCardAfter
        '
        Me.txt_JobCardAfter.BackYesno = False
        Me.txt_JobCardAfter.ButtonTitle = Nothing
        Me.txt_JobCardAfter.Code = Nothing
        Me.txt_JobCardAfter.Data = ""
        Me.txt_JobCardAfter.DataDecimal = 0
        Me.txt_JobCardAfter.DataLen = 0
        Me.txt_JobCardAfter.DataValue = 0
        Me.txt_JobCardAfter.FormatDecimal = 0
        Me.txt_JobCardAfter.FormatValue = False
        Me.txt_JobCardAfter.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_JobCardAfter.LableEnabled = True
        Me.txt_JobCardAfter.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_JobCardAfter.LableForeColor = System.Drawing.Color.Black
        Me.txt_JobCardAfter.LableTitle = "JobCard After"
        Me.txt_JobCardAfter.Layoutpercent = New Decimal(New Integer() {508, 0, 0, 196608})
        Me.txt_JobCardAfter.Location = New System.Drawing.Point(757, 58)
        Me.txt_JobCardAfter.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_JobCardAfter.Name = "txt_JobCardAfter"
        Me.txt_JobCardAfter.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_JobCardAfter.Size = New System.Drawing.Size(299, 24)
        Me.txt_JobCardAfter.TabIndex = 163
        Me.txt_JobCardAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_JobCardAfter.TextBoxAutoComplete = False
        Me.txt_JobCardAfter.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_JobCardAfter.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_JobCardAfter.TextEnabled = True
        Me.txt_JobCardAfter.TextForeColor = System.Drawing.Color.Empty
        Me.txt_JobCardAfter.TextMaxLength = 32767
        Me.txt_JobCardAfter.TextMultiLine = False
        Me.txt_JobCardAfter.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_JobCardAfter.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_JobCardAfter.UseSendTab = True
        '
        'ISUD4010A
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1074, 451)
        Me.Controls.Add(Me.Frame1)
        Me.DoubleBuffered = True
        Me.Name = "ISUD4010A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JOBCARD PROCESSING (ISUD4010A)"
        Me.Controls.SetChildIndex(Me.Frame1, 0)
        CType(Me.Frame1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlowLayoutPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Frame1 As PSMGlobal.PeacePanel
    Friend WithEvents FlowLayoutPanel2 As PSMGlobal.PeacePanel
    Friend WithEvents txt_JobCard As PSMGlobal.SelectLabelText
    Friend WithEvents tit_Use As PSMGlobal.PeaceLabel
    Friend WithEvents Panel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_CheckPlan5 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckPlan2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_CheckPlan4 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckPlan3 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckPlan1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_cdFactory As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_DatePlanFinish As PSMGlobal.SelectPeaceCalSin
    Friend WithEvents txt_DatePlanStart As PSMGlobal.SelectPeaceCalSin
    Public WithEvents Vs1 As PSMGlobal.PeaceFarpoint
    Friend WithEvents Vs1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents txt_cdJobState As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_QtyOrder As PSMGlobal.SelectLabelText
    Friend WithEvents txt_QtyAverage As PSMGlobal.SelectLabelText
    Friend WithEvents txt_JobCardAfter As PSMGlobal.SelectLabelText
    Friend WithEvents txt_JobCardBefore As PSMGlobal.SelectLabelText
End Class
