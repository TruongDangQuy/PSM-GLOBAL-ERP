<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PFP71032
    Inherits PeaceForm

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
        Dim EnhancedFocusIndicatorRenderer2 As FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer = New FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer()
        Dim EnhancedScrollBarRenderer4 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim NamedStyle7 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("DataAreaDefault")
        Dim GeneralCellType3 As FarPoint.Win.Spread.CellType.GeneralCellType = New FarPoint.Win.Spread.CellType.GeneralCellType()
        Dim NamedStyle8 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style2")
        Dim BevelBorder5 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType5 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle9 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style3")
        Dim BevelBorder6 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType6 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle10 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style1")
        Dim BevelBorder7 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType7 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle11 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style4")
        Dim BevelBorder8 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType8 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle12 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style5")
        Dim GeneralCellType4 As FarPoint.Win.Spread.CellType.GeneralCellType = New FarPoint.Win.Spread.CellType.GeneralCellType()
        Dim SpreadSkin2 As FarPoint.Win.Spread.SpreadSkin = New FarPoint.Win.Spread.SpreadSkin()
        Dim EnhancedInterfaceRenderer2 As FarPoint.Win.Spread.EnhancedInterfaceRenderer = New FarPoint.Win.Spread.EnhancedInterfaceRenderer()
        Dim EnhancedScrollBarRenderer5 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim EnhancedScrollBarRenderer6 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim Vs1_InputMapWhenFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim Vs1_InputMapWhenAncestorOfFocusedNormal As FarPoint.Win.Spread.InputMap
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Vs1 = New PSMGlobal.PeaceFarpoint()
        Me.Vs1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.ToolStrip1 = New PSMGlobal.PeaceToolStrip(Me.components)
        Me.tst_1 = New PSMGlobal.PeaceToolStripButton(Me.components)
        Me.ToolStripSeparator2 = New PSMGlobal.PeaceToolStripSep(Me.components)
        Me.tst_2 = New PSMGlobal.PeaceToolStripButton(Me.components)
        Me.ToolStripSeparator4 = New PSMGlobal.PeaceToolStripSep(Me.components)
        Me.tst_3 = New PSMGlobal.PeaceToolStripButton(Me.components)
        Me.ToolStripSeparator3 = New PSMGlobal.PeaceToolStripSep(Me.components)
        Me.tst_4 = New PSMGlobal.PeaceToolStripButton(Me.components)
        Me.ToolStripSeparator5 = New PSMGlobal.PeaceToolStripSep(Me.components)
        Me.tst_5 = New PSMGlobal.PeaceToolStripButton(Me.components)
        Me.ToolStripSeparator6 = New PSMGlobal.PeaceToolStripSep(Me.components)
        Me.tst_6 = New PSMGlobal.PeaceToolStripButton(Me.components)
        Me.ToolStripSeparator1 = New PSMGlobal.PeaceToolStripSep(Me.components)
        Me.ptsb_Manual = New PSMGlobal.PeaceToolStripButton(Me.components)
        Me.ptsb_Help = New PSMGlobal.PeaceToolStripButton(Me.components)
        Me.ptsb_Excel = New PSMGlobal.PeaceToolStripButton(Me.components)
        Me.PeacePanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.Panel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_cdTypeCode = New PSMGlobal.SelectPeaceHLPButton()
        Me.cmd_SEARCH = New PSMGlobal.PeaceButton(Me.components)
        Me.btn_SAVE = New PSMGlobal.PeaceButton(Me.components)
        Me.chk_FSEL = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.txt_TypeName = New PSMGlobal.SelectLabelText()
        Me.ssp_WHERE = New PSMGlobal.PeacePanel(Me.components)
        Me.Cms_1 = New PSMGlobal.PeaceContextMenuStrip(Me.components)
        Vs1_InputMapWhenFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ssp_WHERE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Vs1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PeacePanel1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1264, 681)
        Me.TableLayoutPanel1.TabIndex = 13
        '
        'Vs1
        '
        Me.Vs1.AccessibleDescription = "Vs2, Sheet1, Row 0, Column 0, "
        Me.Vs1.AllowEditorReservedLocations = False
        Me.Vs1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Vs1.CopyPasteChk = True
        Me.Vs1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Vs1.FocusRenderer = EnhancedFocusIndicatorRenderer2
        Me.Vs1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs1.HorizontalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.Vs1.HorizontalScrollBar.Name = ""
        EnhancedScrollBarRenderer4.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer4.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer4.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer4.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer4.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer4.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer4.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer4.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.Vs1.HorizontalScrollBar.Renderer = EnhancedScrollBarRenderer4
        Me.Vs1.HorizontalScrollBar.TabIndex = 0
        Me.Vs1.InsChk = False
        Me.Vs1.Location = New System.Drawing.Point(1, 68)
        Me.Vs1.Margin = New System.Windows.Forms.Padding(0)
        Me.Vs1.Name = "Vs1"
        NamedStyle7.BackColor = System.Drawing.SystemColors.Window
        NamedStyle7.CellType = GeneralCellType3
        NamedStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        NamedStyle7.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle7.Renderer = GeneralCellType3
        NamedStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle8.Border = BevelBorder5
        NamedStyle8.CanFocus = False
        NamedStyle8.CellType = TextCellType5
        NamedStyle8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        NamedStyle8.ForeColor = System.Drawing.Color.White
        NamedStyle8.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle8.Locked = False
        NamedStyle8.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle8.Renderer = TextCellType5
        NamedStyle8.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle8.VisualStyles = FarPoint.Win.VisualStyles.Off
        NamedStyle9.Border = BevelBorder6
        NamedStyle9.CellType = TextCellType6
        NamedStyle9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamedStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle9.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle9.Locked = False
        NamedStyle9.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle9.Renderer = TextCellType6
        NamedStyle9.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle10.Border = BevelBorder7
        NamedStyle10.CanFocus = False
        NamedStyle10.CellType = TextCellType7
        NamedStyle10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamedStyle10.ForeColor = System.Drawing.Color.White
        NamedStyle10.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle10.Locked = False
        NamedStyle10.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle10.Renderer = TextCellType7
        NamedStyle10.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle10.VisualStyles = FarPoint.Win.VisualStyles.Off
        NamedStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle11.Border = BevelBorder8
        NamedStyle11.CellType = TextCellType8
        NamedStyle11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        NamedStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle11.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle11.Locked = False
        NamedStyle11.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle11.Renderer = TextCellType8
        NamedStyle11.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle12.BackColor = System.Drawing.SystemColors.Window
        NamedStyle12.CellType = GeneralCellType4
        NamedStyle12.Font = New System.Drawing.Font("Tahoma", 9.0!)
        NamedStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        NamedStyle12.Locked = False
        NamedStyle12.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle12.Renderer = GeneralCellType4
        Me.Vs1.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle7, NamedStyle8, NamedStyle9, NamedStyle10, NamedStyle11, NamedStyle12})
        Me.Vs1.ReportName = Nothing
        Me.Vs1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.Vs1_Sheet1})
        Me.Vs1.Size = New System.Drawing.Size(1262, 612)
        SpreadSkin2.ColumnFooterDefaultStyle = NamedStyle9
        SpreadSkin2.ColumnHeaderDefaultStyle = NamedStyle8
        SpreadSkin2.CornerDefaultStyle = NamedStyle11
        SpreadSkin2.DefaultStyle = NamedStyle12
        SpreadSkin2.FocusRenderer = EnhancedFocusIndicatorRenderer2
        EnhancedInterfaceRenderer2.ScrollBoxBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(221, Byte), Integer))
        EnhancedInterfaceRenderer2.SheetTabLowerActiveColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(244, Byte), Integer))
        EnhancedInterfaceRenderer2.SheetTabLowerNormalColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(249, Byte), Integer))
        EnhancedInterfaceRenderer2.SheetTabUpperActiveColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(244, Byte), Integer))
        EnhancedInterfaceRenderer2.SheetTabUpperNormalColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(249, Byte), Integer))
        EnhancedInterfaceRenderer2.TabStripBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(221, Byte), Integer))
        SpreadSkin2.InterfaceRenderer = EnhancedInterfaceRenderer2
        SpreadSkin2.Name = "Hung123"
        SpreadSkin2.RowHeaderDefaultStyle = NamedStyle10
        EnhancedScrollBarRenderer5.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer5.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer5.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer5.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer5.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer5.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer5.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer5.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        SpreadSkin2.ScrollBarRenderer = EnhancedScrollBarRenderer5
        SpreadSkin2.SelectionRenderer = New FarPoint.Win.Spread.DefaultSelectionRenderer()
        Me.Vs1.Skin = SpreadSkin2
        Me.Vs1.SpreadWjob = 0
        Me.Vs1.TabIndex = 14
        Me.Vs1.TabStrip.DefaultSheetTab.BackColor = System.Drawing.Color.White
        Me.Vs1.TabStrip.DefaultSheetTab.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vs1.VerticalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.Vs1.VerticalScrollBar.Name = ""
        EnhancedScrollBarRenderer6.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer6.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer6.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer6.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer6.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer6.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer6.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer6.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.Vs1.VerticalScrollBar.Renderer = EnhancedScrollBarRenderer6
        Me.Vs1.VerticalScrollBar.TabIndex = 25
        Vs1_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(Global.Microsoft.VisualBasic.ChrW(61)), FarPoint.Win.Spread.SpreadActions.StartEditingFormula)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.C, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCopy)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.V, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardPasteAll)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.X, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCut)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Insert, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCopy)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Delete, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCut)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Insert, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardPasteAll)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F4, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ShowSubEditor)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Space, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.SelectRow)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Z, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Undo)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Y, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Redo)
        Me.Vs1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.Normal, Vs1_InputMapWhenFocusedNormal)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnVisual)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnVisual)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousRow)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextRow)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousColumnVisual)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextColumnVisual)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnVisual)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnVisual)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousRow)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextRow)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousColumnVisual)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextColumnVisual)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfRows)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfRows)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfColumns)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfColumns)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousPageOfRows)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextPageOfRows)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousPageOfColumns)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextPageOfColumns)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToFirstColumn)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToLastColumn)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToFirstCell)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToLastCell)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToFirstColumn)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToLastColumn)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToFirstCell)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToLastCell)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Space, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.SelectColumn)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Space, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.SelectSheet)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Escape, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.CancelEditing)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Tab, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Tab, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnWrap)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ClearCell)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F3, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.DateTimeNow)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F4, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ShowSubEditor)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        Me.Vs1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused, FarPoint.Win.Spread.OperationMode.Normal, Vs1_InputMapWhenAncestorOfFocusedNormal)
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
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.Parent = "RowHeaderDefault"
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
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.Rows.Default.Height = 22.0!
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
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_1, Me.ToolStripSeparator2, Me.tst_2, Me.ToolStripSeparator4, Me.tst_3, Me.ToolStripSeparator3, Me.tst_4, Me.ToolStripSeparator5, Me.tst_5, Me.ToolStripSeparator6, Me.tst_6, Me.ToolStripSeparator1, Me.ptsb_Manual, Me.ptsb_Help, Me.ptsb_Excel})
        Me.ToolStrip1.Location = New System.Drawing.Point(1, 1)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1262, 30)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tst_1
        '
        Me.tst_1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tst_1.Image = Global.PSMGlobal.My.Resources.Resources.insert
        Me.tst_1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_1.Name = "tst_1"
        Me.tst_1.Size = New System.Drawing.Size(95, 27)
        Me.tst_1.Text = "INSERT (F5)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 30)
        '
        'tst_2
        '
        Me.tst_2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tst_2.Image = Global.PSMGlobal.My.Resources.Resources.find
        Me.tst_2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_2.Name = "tst_2"
        Me.tst_2.Size = New System.Drawing.Size(98, 27)
        Me.tst_2.Text = "SEARCH (F6)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 30)
        '
        'tst_3
        '
        Me.tst_3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tst_3.Image = Global.PSMGlobal.My.Resources.Resources.edit
        Me.tst_3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_3.Name = "tst_3"
        Me.tst_3.Size = New System.Drawing.Size(98, 27)
        Me.tst_3.Text = "MODIFY (F7)"
        Me.tst_3.ToolTipText = "MODIFY (F7)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 30)
        '
        'tst_4
        '
        Me.tst_4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tst_4.Image = Global.PSMGlobal.My.Resources.Resources.delete
        Me.tst_4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_4.Name = "tst_4"
        Me.tst_4.Size = New System.Drawing.Size(97, 27)
        Me.tst_4.Text = "DELETE (F8)"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 30)
        '
        'tst_5
        '
        Me.tst_5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tst_5.Image = Global.PSMGlobal.My.Resources.Resources.printer
        Me.tst_5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_5.Name = "tst_5"
        Me.tst_5.Size = New System.Drawing.Size(88, 27)
        Me.tst_5.Text = "PRINT (F9)"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 30)
        '
        'tst_6
        '
        Me.tst_6.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tst_6.Image = Global.PSMGlobal.My.Resources.Resources.progress
        Me.tst_6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_6.Name = "tst_6"
        Me.tst_6.Size = New System.Drawing.Size(132, 27)
        Me.tst_6.Text = "PROCESSING (F10)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'ptsb_Manual
        '
        Me.ptsb_Manual.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ptsb_Manual.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ptsb_Manual.Image = Global.PSMGlobal.My.Resources.Resources.GroupFooter_16x16
        Me.ptsb_Manual.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ptsb_Manual.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ptsb_Manual.Name = "ptsb_Manual"
        Me.ptsb_Manual.Size = New System.Drawing.Size(23, 27)
        Me.ptsb_Manual.Text = "HELP"
        '
        'ptsb_Help
        '
        Me.ptsb_Help.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ptsb_Help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ptsb_Help.Image = Global.PSMGlobal.My.Resources.Resources.Pivot_16x16
        Me.ptsb_Help.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ptsb_Help.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ptsb_Help.Name = "ptsb_Help"
        Me.ptsb_Help.Size = New System.Drawing.Size(23, 27)
        Me.ptsb_Help.Text = "HELP"
        '
        'ptsb_Excel
        '
        Me.ptsb_Excel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ptsb_Excel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ptsb_Excel.Image = Global.PSMGlobal.My.Resources.Resources.ExportToXLS_16x16
        Me.ptsb_Excel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ptsb_Excel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ptsb_Excel.Name = "ptsb_Excel"
        Me.ptsb_Excel.Size = New System.Drawing.Size(23, 27)
        Me.ptsb_Excel.Text = "EXCEL"
        '
        'PeacePanel1
        '
        Me.PeacePanel1.Code = ""
        Me.PeacePanel1.Controls.Add(Me.Panel2)
        Me.PeacePanel1.Data = ""
        Me.PeacePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeacePanel1.Location = New System.Drawing.Point(4, 35)
        Me.PeacePanel1.Name = "PeacePanel1"
        Me.PeacePanel1.Size = New System.Drawing.Size(1256, 29)
        Me.PeacePanel1.TabIndex = 15
        Me.PeacePanel1.Tag = ""
        '
        'Panel2
        '
        Me.Panel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Panel2.ColumnCount = 7
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 305.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Panel2.Controls.Add(Me.txt_cdTypeCode, 0, 0)
        Me.Panel2.Controls.Add(Me.cmd_SEARCH, 6, 0)
        Me.Panel2.Controls.Add(Me.btn_SAVE, 5, 0)
        Me.Panel2.Controls.Add(Me.chk_FSEL, 0, 0)
        Me.Panel2.Controls.Add(Me.txt_TypeName, 2, 0)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RowCount = 1
        Me.Panel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel2.Size = New System.Drawing.Size(1252, 25)
        Me.Panel2.TabIndex = 17
        '
        'txt_cdTypeCode
        '
        Me.txt_cdTypeCode.BackYesno = False
        Me.txt_cdTypeCode.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdTypeCode.ButtonEnabled = True
        Me.txt_cdTypeCode.ButtonFont = Nothing
        Me.txt_cdTypeCode.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdTypeCode.ButtonName = ""
        Me.txt_cdTypeCode.ButtonTitle = "Type Code"
        Me.txt_cdTypeCode.Code = ""
        Me.txt_cdTypeCode.Data = ""
        Me.txt_cdTypeCode.DataDecimal = 0
        Me.txt_cdTypeCode.DataLen = 0
        Me.txt_cdTypeCode.DataValue = 1
        Me.txt_cdTypeCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_cdTypeCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdTypeCode.Location = New System.Drawing.Point(128, 2)
        Me.txt_cdTypeCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdTypeCode.Name = "txt_cdTypeCode"
        Me.txt_cdTypeCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdTypeCode.Size = New System.Drawing.Size(298, 21)
        Me.txt_cdTypeCode.TabIndex = 113
        Me.txt_cdTypeCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdTypeCode.TextBoxAutoComplete = False
        Me.txt_cdTypeCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdTypeCode.TextBoxFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdTypeCode.TextEnabled = True
        Me.txt_cdTypeCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdTypeCode.TextMaxLength = 32767
        Me.txt_cdTypeCode.TextMultiLine = False
        Me.txt_cdTypeCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdTypeCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdTypeCode.UseSendTab = True
        '
        'cmd_SEARCH
        '
        Me.cmd_SEARCH.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_SEARCH.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.cmd_SEARCH.Appearance.Options.UseFont = True
        Me.cmd_SEARCH.Appearance.Options.UseForeColor = True
        Me.cmd_SEARCH.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_SEARCH.ButtonTitle = Nothing
        Me.cmd_SEARCH.Code = Nothing
        Me.cmd_SEARCH.Data = Nothing
        Me.cmd_SEARCH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd_SEARCH.Image = Global.PSMGlobal.My.Resources.Resources.find_f
        Me.cmd_SEARCH.ImageAlign = 16
        Me.cmd_SEARCH.Location = New System.Drawing.Point(1120, 2)
        Me.cmd_SEARCH.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_SEARCH.Name = "cmd_SEARCH"
        Me.cmd_SEARCH.Size = New System.Drawing.Size(130, 21)
        Me.cmd_SEARCH.TabIndex = 7
        Me.cmd_SEARCH.Text = "   Search(&S)"
        Me.cmd_SEARCH.UseVisualStyleBackColor = False
        '
        'btn_SAVE
        '
        Me.btn_SAVE.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_SAVE.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_SAVE.Appearance.Options.UseFont = True
        Me.btn_SAVE.Appearance.Options.UseForeColor = True
        Me.btn_SAVE.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btn_SAVE.ButtonTitle = Nothing
        Me.btn_SAVE.Code = Nothing
        Me.btn_SAVE.Data = Nothing
        Me.btn_SAVE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_SAVE.Image = Global.PSMGlobal.My.Resources.Resources.Save_16x16
        Me.btn_SAVE.ImageAlign = 16
        Me.btn_SAVE.Location = New System.Drawing.Point(987, 2)
        Me.btn_SAVE.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_SAVE.Name = "btn_SAVE"
        Me.btn_SAVE.Size = New System.Drawing.Size(130, 21)
        Me.btn_SAVE.TabIndex = 7
        Me.btn_SAVE.Text = "Save(&S)"
        Me.btn_SAVE.UseVisualStyleBackColor = False
        '
        'chk_FSEL
        '
        Me.chk_FSEL.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.chk_FSEL.ButtonTitle = Nothing
        Me.chk_FSEL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chk_FSEL.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chk_FSEL.ForeColor = System.Drawing.Color.Black
        Me.chk_FSEL.Location = New System.Drawing.Point(2, 2)
        Me.chk_FSEL.Margin = New System.Windows.Forms.Padding(1)
        Me.chk_FSEL.Name = "chk_FSEL"
        Me.chk_FSEL.Size = New System.Drawing.Size(123, 21)
        Me.chk_FSEL.TabIndex = 17
        Me.chk_FSEL.Text = "Open"
        Me.chk_FSEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk_FSEL.UseVisualStyleBackColor = False
        '
        'txt_TypeName
        '
        Me.txt_TypeName.BackYesno = False
        Me.txt_TypeName.ButtonTitle = Nothing
        Me.txt_TypeName.Code = Nothing
        Me.txt_TypeName.Data = ""
        Me.txt_TypeName.DataDecimal = 0
        Me.txt_TypeName.DataLen = 0
        Me.txt_TypeName.DataValue = 0
        Me.txt_TypeName.FormatDecimal = 0
        Me.txt_TypeName.FormatValue = False
        Me.txt_TypeName.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_TypeName.LableEnabled = True
        Me.txt_TypeName.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_TypeName.LableForeColor = System.Drawing.Color.Empty
        Me.txt_TypeName.LableTitle = "Name"
        Me.txt_TypeName.Layoutpercent = New Decimal(New Integer() {46, 0, 0, 131072})
        Me.txt_TypeName.Location = New System.Drawing.Point(429, 2)
        Me.txt_TypeName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_TypeName.Name = "txt_TypeName"
        Me.txt_TypeName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_TypeName.Size = New System.Drawing.Size(298, 21)
        Me.txt_TypeName.TabIndex = 112
        Me.txt_TypeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_TypeName.TextBoxAutoComplete = False
        Me.txt_TypeName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_TypeName.TextBoxFont = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_TypeName.TextEnabled = True
        Me.txt_TypeName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_TypeName.TextMaxLength = 32767
        Me.txt_TypeName.TextMultiLine = False
        Me.txt_TypeName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_TypeName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_TypeName.UseSendTab = True
        '
        'ssp_WHERE
        '
        Me.ssp_WHERE.Code = ""
        Me.ssp_WHERE.Data = ""
        Me.ssp_WHERE.Location = New System.Drawing.Point(50, 86)
        Me.ssp_WHERE.Name = "ssp_WHERE"
        Me.ssp_WHERE.Size = New System.Drawing.Size(542, 112)
        Me.ssp_WHERE.TabIndex = 15
        Me.ssp_WHERE.Tag = ""
        Me.ssp_WHERE.Visible = False
        '
        'Cms_1
        '
        Me.Cms_1.Name = "Cms_1"
        Me.Cms_1.Size = New System.Drawing.Size(61, 4)
        '
        'PFP71032
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.ssp_WHERE)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "PFP71032"
        Me.Text = "COMPONENT BATCH CONTROL (PFP71032)"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.ssp_WHERE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Public WithEvents ToolStrip1 As PSMGlobal.PeaceToolStrip
    Public WithEvents tst_1 As PSMGlobal.PeaceToolStripButton
    Public WithEvents ToolStripSeparator2 As PSMGlobal.PeaceToolStripSep
    Public WithEvents tst_2 As PSMGlobal.PeaceToolStripButton
    Public WithEvents ToolStripSeparator4 As PSMGlobal.PeaceToolStripSep
    Public WithEvents tst_3 As PSMGlobal.PeaceToolStripButton
    Public WithEvents ToolStripSeparator3 As PSMGlobal.PeaceToolStripSep
    Public WithEvents tst_4 As PSMGlobal.PeaceToolStripButton
    Public WithEvents ToolStripSeparator5 As PSMGlobal.PeaceToolStripSep
    Public WithEvents tst_5 As PSMGlobal.PeaceToolStripButton
    Public WithEvents ToolStripSeparator6 As PSMGlobal.PeaceToolStripSep
    Public WithEvents tst_6 As PSMGlobal.PeaceToolStripButton
    Public WithEvents ToolStripSeparator1 As PSMGlobal.PeaceToolStripSep
    Public WithEvents ptsb_Manual As PSMGlobal.PeaceToolStripButton
    Public WithEvents ptsb_Help As PSMGlobal.PeaceToolStripButton
    Public WithEvents ptsb_Excel As PSMGlobal.PeaceToolStripButton
    Public WithEvents ssp_WHERE As PSMGlobal.PeacePanel
    Public WithEvents Vs1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents PeacePanel1 As PSMGlobal.PeacePanel
    Public WithEvents Panel2 As System.Windows.Forms.TableLayoutPanel
    Public WithEvents chk_FSEL As PSMGlobal.PeaceCheckbox
    Public WithEvents txt_TypeName As PSMGlobal.SelectLabelText
    Public WithEvents cmd_SEARCH As PSMGlobal.PeaceButton
    Public WithEvents btn_SAVE As PSMGlobal.PeaceButton
    Public WithEvents Vs1 As PSMGlobal.PeaceFarpoint
    Friend WithEvents txt_cdTypeCode As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents Cms_1 As PSMGlobal.PeaceContextMenuStrip

End Class
