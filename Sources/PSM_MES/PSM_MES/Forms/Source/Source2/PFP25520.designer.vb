<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PFP25520
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
        Dim vS1_InputMapWhenFocusedSingleSelect As FarPoint.Win.Spread.InputMap
        Dim vS1_InputMapWhenAncestorOfFocusedSingleSelect As FarPoint.Win.Spread.InputMap
        Dim TextCellType5 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.vS1 = New PSMGlobal.PeaceFarpoint()
        Me.vS1_Sheet1 = New FarPoint.Win.Spread.SheetView()
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
        Me.PeacePanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.Panel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmd_SEARCH = New System.Windows.Forms.Button()
        Me.chk_FSEL = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.SdateEdate = New PSMGlobal.SelectPeaceCalDou()
        Me.txt_MaterialName = New PSMGlobal.SelectLabelText()
        Me.txt_cdDepartment = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_InvoiceNo = New PSMGlobal.SelectLabelText()
        Me.Cms_1 = New PSMGlobal.PeaceContextMenuStrip(Me.components)
        Me.Cms_2 = New PSMGlobal.PeaceContextMenuStrip(Me.components)
        Me.ssp_WHERE = New PSMGlobal.PeacePanel(Me.components)
        Me.PeaceLabel4 = New PSMGlobal.PeaceLabel(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PeaceCheckbox7 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.PeaceCheckbox8 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.PeaceCheckbox6 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.PeaceCheckbox2 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.PeaceCheckbox3 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.PeaceCheckbox4 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.PeaceCheckbox5 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.PeaceCheckbox1 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.txt_CustomerInBoundMaterialName = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdSemiGroupMaterialName = New PSMGlobal.SelectPeaceHLPButton()
        Me.ptsb_Manual = New PSMGlobal.PeaceToolStripButton(Me.components)
        Me.ptsb_Help = New PSMGlobal.PeaceToolStripButton(Me.components)
        Me.ptsb_Excel = New PSMGlobal.PeaceToolStripButton(Me.components)
        vS1_InputMapWhenFocusedSingleSelect = New FarPoint.Win.Spread.InputMap()
        vS1_InputMapWhenFocusedSingleSelect.Parent = New FarPoint.Win.Spread.InputMap()
        vS1_InputMapWhenAncestorOfFocusedSingleSelect = New FarPoint.Win.Spread.InputMap()
        vS1_InputMapWhenAncestorOfFocusedSingleSelect.Parent = New FarPoint.Win.Spread.InputMap()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.vS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vS1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ssp_WHERE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ssp_WHERE.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.vS1, 0, 2)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1444, 762)
        Me.TableLayoutPanel1.TabIndex = 13
        '
        'vS1
        '
        Me.vS1.AccessibleDescription = "Vs2, Sheet1, Row 0, Column 0, "
        Me.vS1.AllowDragFill = True
        Me.vS1.AllowEditorReservedLocations = False
        Me.vS1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.vS1.ClipboardOptions = FarPoint.Win.Spread.ClipboardOptions.NoHeaders
        Me.vS1.CopyPasteChk = True
        Me.vS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vS1.FocusRenderer = New FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer(1)
        Me.vS1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vS1.HorizontalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.vS1.HorizontalScrollBar.Name = ""
        EnhancedScrollBarRenderer1.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer1.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.vS1.HorizontalScrollBar.Renderer = EnhancedScrollBarRenderer1
        Me.vS1.HorizontalScrollBar.TabIndex = 0
        Me.vS1.InsChk = False
        Me.vS1.Location = New System.Drawing.Point(1, 68)
        Me.vS1.Margin = New System.Windows.Forms.Padding(0)
        Me.vS1.Name = "vS1"
        NamedStyle1.BackColor = System.Drawing.SystemColors.Window
        NamedStyle1.CellType = GeneralCellType1
        NamedStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        NamedStyle1.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle1.Renderer = GeneralCellType1
        NamedStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle2.Border = BevelBorder1
        NamedStyle2.CanFocus = False
        NamedStyle2.CellType = TextCellType1
        NamedStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        NamedStyle2.ForeColor = System.Drawing.Color.White
        NamedStyle2.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle2.Locked = False
        NamedStyle2.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle2.Renderer = TextCellType1
        NamedStyle2.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle2.VisualStyles = FarPoint.Win.VisualStyles.Off
        NamedStyle3.Border = BevelBorder2
        NamedStyle3.CellType = TextCellType2
        NamedStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        NamedStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        NamedStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        NamedStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle5.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle5.Locked = False
        NamedStyle5.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle5.Renderer = TextCellType4
        NamedStyle5.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle6.BackColor = System.Drawing.SystemColors.Window
        NamedStyle6.CellType = GeneralCellType2
        NamedStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        NamedStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        NamedStyle6.Locked = False
        NamedStyle6.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle6.Renderer = GeneralCellType2
        Me.vS1.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle1, NamedStyle2, NamedStyle3, NamedStyle4, NamedStyle5, NamedStyle6})
        Me.vS1.ReportName = Nothing
        Me.vS1.SheetDSName = Nothing
        Me.vS1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.vS1_Sheet1})
        Me.vS1.Size = New System.Drawing.Size(1442, 693)
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
        Me.vS1.Skin = SpreadSkin1
        Me.vS1.SpreadWjob = 0
        Me.vS1.TabIndex = 16
        Me.vS1.TabStop = False
        Me.vS1.TabStrip.DefaultSheetTab.BackColor = System.Drawing.Color.White
        Me.vS1.TabStrip.DefaultSheetTab.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vS1.VerticalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.vS1.VerticalScrollBar.Name = ""
        EnhancedScrollBarRenderer3.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer3.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.vS1.VerticalScrollBar.Renderer = EnhancedScrollBarRenderer3
        Me.vS1.VerticalScrollBar.TabIndex = 27
        vS1_InputMapWhenFocusedSingleSelect.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        vS1_InputMapWhenFocusedSingleSelect.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        vS1_InputMapWhenFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.C, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCopy)
        vS1_InputMapWhenFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Insert, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCopy)
        vS1_InputMapWhenFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Z, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Undo)
        vS1_InputMapWhenFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Y, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Redo)
        Me.vS1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.SingleSelect, vS1_InputMapWhenFocusedSingleSelect)
        vS1_InputMapWhenAncestorOfFocusedSingleSelect.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        vS1_InputMapWhenAncestorOfFocusedSingleSelect.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        vS1_InputMapWhenAncestorOfFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.SelectPreviousItem)
        vS1_InputMapWhenAncestorOfFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.SelectNextItem)
        vS1_InputMapWhenAncestorOfFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ScrollToPreviousColumnVisual)
        vS1_InputMapWhenAncestorOfFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ScrollToNextColumnVisual)
        vS1_InputMapWhenAncestorOfFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.SelectPreviousPageOfItems)
        vS1_InputMapWhenAncestorOfFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.SelectNextPageOfItems)
        vS1_InputMapWhenAncestorOfFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.SelectFirstItem)
        vS1_InputMapWhenAncestorOfFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.SelectLastItem)
        Me.vS1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused, FarPoint.Win.Spread.OperationMode.SingleSelect, vS1_InputMapWhenAncestorOfFocusedSingleSelect)
        '
        'vS1_Sheet1
        '
        Me.vS1_Sheet1.Reset()
        Me.vS1_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.vS1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.vS1_Sheet1.ColumnCount = 29
        Me.vS1_Sheet1.RowCount = 10
        Me.vS1_Sheet1.ActiveSkin = New FarPoint.Win.Spread.SheetSkin("SheetSkin1", System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer)), FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer)), System.Drawing.Color.White, System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.White, System.Drawing.SystemColors.ButtonFace, False, False, False, True, True, True, False, True, "RowHeaderDefault", "RowHeaderDefault", "RowHeaderDefault", "DataAreaDefault", "RowHeaderDefault")
        Me.vS1_Sheet1.ColumnFooter.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vS1_Sheet1.ColumnFooter.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.vS1_Sheet1.ColumnFooter.DefaultStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.vS1_Sheet1.ColumnFooter.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.vS1_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.ColumnFooter.DefaultStyle.Parent = "RowHeaderDefault"
        Me.vS1_Sheet1.ColumnFooter.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vS1_Sheet1.ColumnFooter.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vS1_Sheet1.ColumnFooterSheetCornerStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.vS1_Sheet1.ColumnFooterSheetCornerStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.vS1_Sheet1.ColumnFooterSheetCornerStyle.ForeColor = System.Drawing.Color.White
        Me.vS1_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.ColumnFooterSheetCornerStyle.Parent = "RowHeaderDefault"
        Me.vS1_Sheet1.ColumnFooterSheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vS1_Sheet1.ColumnHeader.Cells.Get(0, 0).Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.vS1_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        TextCellType5.WordWrap = True
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.CellType = TextCellType5
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.Renderer = TextCellType5
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vS1_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vS1_Sheet1.ColumnHeader.Rows.Get(0).Height = 25.0!
        Me.vS1_Sheet1.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vS1_Sheet1.DefaultStyle.ForeColor = System.Drawing.Color.Black
        Me.vS1_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.DefaultStyle.Parent = "DataAreaDefault"
        Me.vS1_Sheet1.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.vS1_Sheet1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.FilterBar.DefaultStyle.Parent = "FilterBarDefaultEnhanced"
        Me.vS1_Sheet1.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.vS1_Sheet1.GroupBarInfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vS1_Sheet1.NullFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.vS1_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.SingleSelect
        Me.vS1_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.vS1_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vS1_Sheet1.RowHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.vS1_Sheet1.RowHeader.DefaultStyle.CellType = TextCellType5
        Me.vS1_Sheet1.RowHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vS1_Sheet1.RowHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.vS1_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.vS1_Sheet1.RowHeader.DefaultStyle.Renderer = TextCellType5
        Me.vS1_Sheet1.RowHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vS1_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vS1_Sheet1.Rows.Default.Height = 22.0!
        Me.vS1_Sheet1.SelectionBackColor = System.Drawing.Color.Aquamarine
        Me.vS1_Sheet1.SelectionPolicy = FarPoint.Win.Spread.Model.SelectionPolicy.[Single]
        Me.vS1_Sheet1.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.SelectionColors
        Me.vS1_Sheet1.SelectionUnit = FarPoint.Win.Spread.Model.SelectionUnit.Row
        Me.vS1_Sheet1.SheetCornerStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.vS1_Sheet1.SheetCornerStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.vS1_Sheet1.SheetCornerStyle.ForeColor = System.Drawing.Color.White
        Me.vS1_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.SheetCornerStyle.Parent = "RowHeaderDefault"
        Me.vS1_Sheet1.SheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vS1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_1, Me.ToolStripSeparator2, Me.tst_2, Me.ToolStripSeparator4, Me.tst_3, Me.ToolStripSeparator3, Me.tst_4, Me.ToolStripSeparator5, Me.tst_5, Me.ToolStripSeparator6, Me.tst_6, Me.ToolStripSeparator1, Me.ptsb_Manual, Me.ptsb_Help, Me.ptsb_Excel})
        Me.ToolStrip1.Location = New System.Drawing.Point(1, 1)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1442, 30)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tst_1
        '
        Me.tst_1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tst_1.Image = Global.PSMGlobal.My.Resources.Resources.insert
        Me.tst_1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_1.Name = "tst_1"
        Me.tst_1.Size = New System.Drawing.Size(86, 27)
        Me.tst_1.Text = "INSERT (F5)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 30)
        '
        'tst_2
        '
        Me.tst_2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tst_2.Image = Global.PSMGlobal.My.Resources.Resources.find
        Me.tst_2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_2.Name = "tst_2"
        Me.tst_2.Size = New System.Drawing.Size(94, 27)
        Me.tst_2.Text = "SEARCH (F6)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 30)
        '
        'tst_3
        '
        Me.tst_3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tst_3.Image = Global.PSMGlobal.My.Resources.Resources.edit
        Me.tst_3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_3.Name = "tst_3"
        Me.tst_3.Size = New System.Drawing.Size(94, 27)
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
        Me.tst_4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tst_4.Image = Global.PSMGlobal.My.Resources.Resources.delete
        Me.tst_4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_4.Name = "tst_4"
        Me.tst_4.Size = New System.Drawing.Size(88, 27)
        Me.tst_4.Text = "DELETE (F8)"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 30)
        '
        'tst_5
        '
        Me.tst_5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tst_5.Image = Global.PSMGlobal.My.Resources.Resources.printer
        Me.tst_5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_5.Name = "tst_5"
        Me.tst_5.Size = New System.Drawing.Size(82, 27)
        Me.tst_5.Text = "PRINT (F9)"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 30)
        '
        'tst_6
        '
        Me.tst_6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tst_6.Image = Global.PSMGlobal.My.Resources.Resources.progress
        Me.tst_6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_6.Name = "tst_6"
        Me.tst_6.Size = New System.Drawing.Size(125, 27)
        Me.tst_6.Text = "PROCESSING (F10)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'PeacePanel1
        '
        Me.PeacePanel1.Code = ""
        Me.PeacePanel1.Controls.Add(Me.Panel2)
        Me.PeacePanel1.Data = ""
        Me.PeacePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeacePanel1.Location = New System.Drawing.Point(4, 35)
        Me.PeacePanel1.Name = "PeacePanel1"
        Me.PeacePanel1.Size = New System.Drawing.Size(1436, 29)
        Me.PeacePanel1.TabIndex = 15
        Me.PeacePanel1.Tag = ""
        '
        'Panel2
        '
        Me.Panel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Panel2.ColumnCount = 6
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 257.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 257.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.Panel2.Controls.Add(Me.cmd_SEARCH, 5, 0)
        Me.Panel2.Controls.Add(Me.chk_FSEL, 0, 0)
        Me.Panel2.Controls.Add(Me.SdateEdate, 1, 0)
        Me.Panel2.Controls.Add(Me.txt_MaterialName, 2, 0)
        Me.Panel2.Controls.Add(Me.txt_cdDepartment, 3, 0)
        Me.Panel2.Controls.Add(Me.txt_InvoiceNo, 4, 0)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RowCount = 1
        Me.Panel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel2.Size = New System.Drawing.Size(1432, 25)
        Me.Panel2.TabIndex = 17
        '
        'cmd_SEARCH
        '
        Me.cmd_SEARCH.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmd_SEARCH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd_SEARCH.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmd_SEARCH.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_SEARCH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.cmd_SEARCH.Image = Global.PSMGlobal.My.Resources.Resources.find_f
        Me.cmd_SEARCH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_SEARCH.Location = New System.Drawing.Point(1292, 2)
        Me.cmd_SEARCH.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_SEARCH.Name = "cmd_SEARCH"
        Me.cmd_SEARCH.Size = New System.Drawing.Size(138, 21)
        Me.cmd_SEARCH.TabIndex = 7
        Me.cmd_SEARCH.Text = "   Search(&S)"
        Me.cmd_SEARCH.UseVisualStyleBackColor = False
        '
        'chk_FSEL
        '
        Me.chk_FSEL.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.chk_FSEL.ButtonTitle = Nothing
        Me.chk_FSEL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chk_FSEL.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
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
        'SdateEdate
        '
        Me.SdateEdate.ButtonTitle = "Period"
        Me.SdateEdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SdateEdate.Location = New System.Drawing.Point(127, 1)
        Me.SdateEdate.Margin = New System.Windows.Forms.Padding(0)
        Me.SdateEdate.Name = "SdateEdate"
        Me.SdateEdate.Size = New System.Drawing.Size(260, 23)
        Me.SdateEdate.TabIndex = 114
        Me.SdateEdate.text1 = ""
        Me.SdateEdate.text2 = ""
        Me.SdateEdate.TextBoxFont = New System.Drawing.Font("Segoe UI", 10.0!)
        '
        'txt_MaterialName
        '
        Me.txt_MaterialName.BackYesno = False
        Me.txt_MaterialName.ButtonTitle = Nothing
        Me.txt_MaterialName.Code = ""
        Me.txt_MaterialName.Data = ""
        Me.txt_MaterialName.DataDecimal = 0
        Me.txt_MaterialName.DataLen = 0
        Me.txt_MaterialName.DataValue = 0
        Me.txt_MaterialName.FormatDecimal = 0
        Me.txt_MaterialName.FormatValue = False
        Me.txt_MaterialName.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_MaterialName.LableEnabled = True
        Me.txt_MaterialName.LableFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_MaterialName.LableForeColor = System.Drawing.Color.Empty
        Me.txt_MaterialName.LableTitle = "Material Name"
        Me.txt_MaterialName.Layoutpercent = New Decimal(New Integer() {46, 0, 0, 131072})
        Me.txt_MaterialName.Location = New System.Drawing.Point(389, 2)
        Me.txt_MaterialName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MaterialName.Name = "txt_MaterialName"
        Me.txt_MaterialName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MaterialName.Size = New System.Drawing.Size(255, 21)
        Me.txt_MaterialName.TabIndex = 115
        Me.txt_MaterialName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MaterialName.TextBoxAutoComplete = False
        Me.txt_MaterialName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MaterialName.TextBoxFont = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_MaterialName.TextEnabled = True
        Me.txt_MaterialName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MaterialName.TextMaxLength = 32767
        Me.txt_MaterialName.TextMultiLine = False
        Me.txt_MaterialName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MaterialName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MaterialName.UseSendTab = True
        '
        'txt_cdDepartment
        '
        Me.txt_cdDepartment.BackYesno = False
        Me.txt_cdDepartment.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdDepartment.ButtonEnabled = True
        Me.txt_cdDepartment.ButtonFont = Nothing
        Me.txt_cdDepartment.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdDepartment.ButtonName = ""
        Me.txt_cdDepartment.ButtonTitle = "Department"
        Me.txt_cdDepartment.Code = ""
        Me.txt_cdDepartment.Data = ""
        Me.txt_cdDepartment.DataDecimal = 0
        Me.txt_cdDepartment.DataLen = 0
        Me.txt_cdDepartment.DataValue = 1
        Me.txt_cdDepartment.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdDepartment.Location = New System.Drawing.Point(647, 2)
        Me.txt_cdDepartment.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdDepartment.Name = "txt_cdDepartment"
        Me.txt_cdDepartment.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdDepartment.Size = New System.Drawing.Size(255, 21)
        Me.txt_cdDepartment.TabIndex = 274
        Me.txt_cdDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdDepartment.TextBoxAutoComplete = False
        Me.txt_cdDepartment.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdDepartment.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_cdDepartment.TextEnabled = True
        Me.txt_cdDepartment.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdDepartment.TextMaxLength = 32767
        Me.txt_cdDepartment.TextMultiLine = False
        Me.txt_cdDepartment.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdDepartment.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdDepartment.UseSendTab = True
        '
        'txt_InvoiceNo
        '
        Me.txt_InvoiceNo.BackYesno = False
        Me.txt_InvoiceNo.ButtonTitle = Nothing
        Me.txt_InvoiceNo.Code = ""
        Me.txt_InvoiceNo.Data = ""
        Me.txt_InvoiceNo.DataDecimal = 0
        Me.txt_InvoiceNo.DataLen = 0
        Me.txt_InvoiceNo.DataValue = 0
        Me.txt_InvoiceNo.FormatDecimal = 0
        Me.txt_InvoiceNo.FormatValue = False
        Me.txt_InvoiceNo.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_InvoiceNo.LableEnabled = True
        Me.txt_InvoiceNo.LableFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_InvoiceNo.LableForeColor = System.Drawing.Color.Empty
        Me.txt_InvoiceNo.LableTitle = "Invoice No"
        Me.txt_InvoiceNo.Layoutpercent = New Decimal(New Integer() {46, 0, 0, 131072})
        Me.txt_InvoiceNo.Location = New System.Drawing.Point(905, 2)
        Me.txt_InvoiceNo.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_InvoiceNo.Name = "txt_InvoiceNo"
        Me.txt_InvoiceNo.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_InvoiceNo.Size = New System.Drawing.Size(255, 21)
        Me.txt_InvoiceNo.TabIndex = 116
        Me.txt_InvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_InvoiceNo.TextBoxAutoComplete = False
        Me.txt_InvoiceNo.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_InvoiceNo.TextBoxFont = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_InvoiceNo.TextEnabled = True
        Me.txt_InvoiceNo.TextForeColor = System.Drawing.Color.Empty
        Me.txt_InvoiceNo.TextMaxLength = 32767
        Me.txt_InvoiceNo.TextMultiLine = False
        Me.txt_InvoiceNo.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_InvoiceNo.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_InvoiceNo.UseSendTab = True
        '
        'Cms_1
        '
        Me.Cms_1.Name = "Cms_1"
        Me.Cms_1.Size = New System.Drawing.Size(61, 4)
        '
        'Cms_2
        '
        Me.Cms_2.Name = "Cms_1"
        Me.Cms_2.Size = New System.Drawing.Size(61, 4)
        '
        'ssp_WHERE
        '
        Me.ssp_WHERE.Code = ""
        Me.ssp_WHERE.Controls.Add(Me.PeaceLabel4)
        Me.ssp_WHERE.Controls.Add(Me.TableLayoutPanel2)
        Me.ssp_WHERE.Controls.Add(Me.txt_CustomerInBoundMaterialName)
        Me.ssp_WHERE.Controls.Add(Me.txt_cdSemiGroupMaterialName)
        Me.ssp_WHERE.Data = ""
        Me.ssp_WHERE.Location = New System.Drawing.Point(48, 124)
        Me.ssp_WHERE.Name = "ssp_WHERE"
        Me.ssp_WHERE.Size = New System.Drawing.Size(442, 221)
        Me.ssp_WHERE.TabIndex = 16
        Me.ssp_WHERE.Tag = ""
        Me.ssp_WHERE.Visible = False
        '
        'PeaceLabel4
        '
        Me.PeaceLabel4.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.PeaceLabel4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PeaceLabel4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PeaceLabel4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PeaceLabel4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeaceLabel4.ButtonTitle = Nothing
        Me.PeaceLabel4.Code = ""
        Me.PeaceLabel4.Data = ""
        Me.PeaceLabel4.DTDec = 0
        Me.PeaceLabel4.DTLen = 0
        Me.PeaceLabel4.DTValue = 0
        Me.PeaceLabel4.Location = New System.Drawing.Point(17, 13)
        Me.PeaceLabel4.Margin = New System.Windows.Forms.Padding(1)
        Me.PeaceLabel4.Name = "PeaceLabel4"
        Me.PeaceLabel4.NoClear = False
        Me.PeaceLabel4.Size = New System.Drawing.Size(134, 101)
        Me.PeaceLabel4.TabIndex = 173
        Me.PeaceLabel4.Tag = ""
        Me.PeaceLabel4.Text = "Request Status"
        Me.PeaceLabel4.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 393.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PeaceCheckbox7, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.PeaceCheckbox8, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.PeaceCheckbox6, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.PeaceCheckbox2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PeaceCheckbox3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.PeaceCheckbox4, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.PeaceCheckbox5, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.PeaceCheckbox1, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(153, 12)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(273, 102)
        Me.TableLayoutPanel2.TabIndex = 172
        '
        'PeaceCheckbox7
        '
        Me.PeaceCheckbox7.AutoSize = True
        Me.PeaceCheckbox7.ButtonTitle = Nothing
        Me.PeaceCheckbox7.Checked = True
        Me.PeaceCheckbox7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PeaceCheckbox7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceCheckbox7.ForeColor = System.Drawing.Color.Black
        Me.PeaceCheckbox7.Location = New System.Drawing.Point(4, 76)
        Me.PeaceCheckbox7.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.PeaceCheckbox7.Name = "PeaceCheckbox7"
        Me.PeaceCheckbox7.Size = New System.Drawing.Size(93, 19)
        Me.PeaceCheckbox7.TabIndex = 4
        Me.PeaceCheckbox7.Text = "ReturnSales"
        Me.PeaceCheckbox7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PeaceCheckbox7.UseVisualStyleBackColor = True
        '
        'PeaceCheckbox8
        '
        Me.PeaceCheckbox8.AutoSize = True
        Me.PeaceCheckbox8.ButtonTitle = Nothing
        Me.PeaceCheckbox8.Checked = True
        Me.PeaceCheckbox8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PeaceCheckbox8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceCheckbox8.ForeColor = System.Drawing.Color.Black
        Me.PeaceCheckbox8.Location = New System.Drawing.Point(125, 76)
        Me.PeaceCheckbox8.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.PeaceCheckbox8.Name = "PeaceCheckbox8"
        Me.PeaceCheckbox8.Size = New System.Drawing.Size(125, 19)
        Me.PeaceCheckbox8.TabIndex = 3
        Me.PeaceCheckbox8.Text = "ReturnPurchasing"
        Me.PeaceCheckbox8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PeaceCheckbox8.UseVisualStyleBackColor = True
        '
        'PeaceCheckbox6
        '
        Me.PeaceCheckbox6.AutoSize = True
        Me.PeaceCheckbox6.ButtonTitle = Nothing
        Me.PeaceCheckbox6.Checked = True
        Me.PeaceCheckbox6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PeaceCheckbox6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceCheckbox6.ForeColor = System.Drawing.Color.Black
        Me.PeaceCheckbox6.Location = New System.Drawing.Point(125, 49)
        Me.PeaceCheckbox6.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.PeaceCheckbox6.Name = "PeaceCheckbox6"
        Me.PeaceCheckbox6.Size = New System.Drawing.Size(100, 19)
        Me.PeaceCheckbox6.TabIndex = 2
        Me.PeaceCheckbox6.Text = "ReturnInSide"
        Me.PeaceCheckbox6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PeaceCheckbox6.UseVisualStyleBackColor = True
        '
        'PeaceCheckbox2
        '
        Me.PeaceCheckbox2.AutoSize = True
        Me.PeaceCheckbox2.ButtonTitle = Nothing
        Me.PeaceCheckbox2.Checked = True
        Me.PeaceCheckbox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PeaceCheckbox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PeaceCheckbox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceCheckbox2.ForeColor = System.Drawing.Color.Black
        Me.PeaceCheckbox2.Location = New System.Drawing.Point(125, 4)
        Me.PeaceCheckbox2.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.PeaceCheckbox2.Name = "PeaceCheckbox2"
        Me.PeaceCheckbox2.Size = New System.Drawing.Size(54, 19)
        Me.PeaceCheckbox2.TabIndex = 0
        Me.PeaceCheckbox2.Text = "Semi"
        Me.PeaceCheckbox2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PeaceCheckbox2.UseVisualStyleBackColor = True
        '
        'PeaceCheckbox3
        '
        Me.PeaceCheckbox3.AutoSize = True
        Me.PeaceCheckbox3.ButtonTitle = Nothing
        Me.PeaceCheckbox3.Checked = True
        Me.PeaceCheckbox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PeaceCheckbox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceCheckbox3.ForeColor = System.Drawing.Color.Black
        Me.PeaceCheckbox3.Location = New System.Drawing.Point(4, 27)
        Me.PeaceCheckbox3.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.PeaceCheckbox3.Name = "PeaceCheckbox3"
        Me.PeaceCheckbox3.Size = New System.Drawing.Size(51, 18)
        Me.PeaceCheckbox3.TabIndex = 0
        Me.PeaceCheckbox3.Text = "Final"
        Me.PeaceCheckbox3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PeaceCheckbox3.UseVisualStyleBackColor = True
        '
        'PeaceCheckbox4
        '
        Me.PeaceCheckbox4.AutoSize = True
        Me.PeaceCheckbox4.ButtonTitle = Nothing
        Me.PeaceCheckbox4.Checked = True
        Me.PeaceCheckbox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PeaceCheckbox4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceCheckbox4.ForeColor = System.Drawing.Color.Black
        Me.PeaceCheckbox4.Location = New System.Drawing.Point(125, 27)
        Me.PeaceCheckbox4.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.PeaceCheckbox4.Name = "PeaceCheckbox4"
        Me.PeaceCheckbox4.Size = New System.Drawing.Size(69, 18)
        Me.PeaceCheckbox4.TabIndex = 0
        Me.PeaceCheckbox4.Text = "Balance"
        Me.PeaceCheckbox4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PeaceCheckbox4.UseVisualStyleBackColor = True
        '
        'PeaceCheckbox5
        '
        Me.PeaceCheckbox5.AutoSize = True
        Me.PeaceCheckbox5.ButtonTitle = Nothing
        Me.PeaceCheckbox5.Checked = True
        Me.PeaceCheckbox5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PeaceCheckbox5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceCheckbox5.ForeColor = System.Drawing.Color.Black
        Me.PeaceCheckbox5.Location = New System.Drawing.Point(4, 49)
        Me.PeaceCheckbox5.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.PeaceCheckbox5.Name = "PeaceCheckbox5"
        Me.PeaceCheckbox5.Size = New System.Drawing.Size(110, 19)
        Me.PeaceCheckbox5.TabIndex = 0
        Me.PeaceCheckbox5.Text = "ReturnOutSide"
        Me.PeaceCheckbox5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PeaceCheckbox5.UseVisualStyleBackColor = True
        '
        'PeaceCheckbox1
        '
        Me.PeaceCheckbox1.AutoSize = True
        Me.PeaceCheckbox1.ButtonTitle = Nothing
        Me.PeaceCheckbox1.Checked = True
        Me.PeaceCheckbox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PeaceCheckbox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceCheckbox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceCheckbox1.ForeColor = System.Drawing.Color.Black
        Me.PeaceCheckbox1.Location = New System.Drawing.Point(4, 4)
        Me.PeaceCheckbox1.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.PeaceCheckbox1.Name = "PeaceCheckbox1"
        Me.PeaceCheckbox1.Size = New System.Drawing.Size(117, 19)
        Me.PeaceCheckbox1.TabIndex = 1
        Me.PeaceCheckbox1.Text = "Purchasing"
        Me.PeaceCheckbox1.UseVisualStyleBackColor = True
        '
        'txt_CustomerInBoundMaterialName
        '
        Me.txt_CustomerInBoundMaterialName.BackYesno = False
        Me.txt_CustomerInBoundMaterialName.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_CustomerInBoundMaterialName.ButtonEnabled = True
        Me.txt_CustomerInBoundMaterialName.ButtonFont = Nothing
        Me.txt_CustomerInBoundMaterialName.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_CustomerInBoundMaterialName.ButtonName = "btn_Customer"
        Me.txt_CustomerInBoundMaterialName.ButtonTitle = "Supplier"
        Me.txt_CustomerInBoundMaterialName.Code = ""
        Me.txt_CustomerInBoundMaterialName.Data = ""
        Me.txt_CustomerInBoundMaterialName.DataDecimal = 0
        Me.txt_CustomerInBoundMaterialName.DataLen = 0
        Me.txt_CustomerInBoundMaterialName.DataValue = 1
        Me.txt_CustomerInBoundMaterialName.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_CustomerInBoundMaterialName.Location = New System.Drawing.Point(17, 147)
        Me.txt_CustomerInBoundMaterialName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_CustomerInBoundMaterialName.Name = "txt_CustomerInBoundMaterialName"
        Me.txt_CustomerInBoundMaterialName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CustomerInBoundMaterialName.Size = New System.Drawing.Size(410, 29)
        Me.txt_CustomerInBoundMaterialName.TabIndex = 70
        Me.txt_CustomerInBoundMaterialName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_CustomerInBoundMaterialName.TextBoxAutoComplete = False
        Me.txt_CustomerInBoundMaterialName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_CustomerInBoundMaterialName.TextBoxFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_CustomerInBoundMaterialName.TextEnabled = True
        Me.txt_CustomerInBoundMaterialName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_CustomerInBoundMaterialName.TextMaxLength = 32767
        Me.txt_CustomerInBoundMaterialName.TextMultiLine = False
        Me.txt_CustomerInBoundMaterialName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CustomerInBoundMaterialName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_CustomerInBoundMaterialName.UseSendTab = True
        '
        'txt_cdSemiGroupMaterialName
        '
        Me.txt_cdSemiGroupMaterialName.BackYesno = False
        Me.txt_cdSemiGroupMaterialName.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSemiGroupMaterialName.ButtonEnabled = True
        Me.txt_cdSemiGroupMaterialName.ButtonFont = Nothing
        Me.txt_cdSemiGroupMaterialName.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSemiGroupMaterialName.ButtonName = "Const_SemiGroupMaterial"
        Me.txt_cdSemiGroupMaterialName.ButtonTitle = "Semi Group"
        Me.txt_cdSemiGroupMaterialName.Code = ""
        Me.txt_cdSemiGroupMaterialName.Data = ""
        Me.txt_cdSemiGroupMaterialName.DataDecimal = 0
        Me.txt_cdSemiGroupMaterialName.DataLen = 0
        Me.txt_cdSemiGroupMaterialName.DataValue = 1
        Me.txt_cdSemiGroupMaterialName.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdSemiGroupMaterialName.Location = New System.Drawing.Point(17, 116)
        Me.txt_cdSemiGroupMaterialName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSemiGroupMaterialName.Name = "txt_cdSemiGroupMaterialName"
        Me.txt_cdSemiGroupMaterialName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSemiGroupMaterialName.Size = New System.Drawing.Size(410, 29)
        Me.txt_cdSemiGroupMaterialName.TabIndex = 68
        Me.txt_cdSemiGroupMaterialName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSemiGroupMaterialName.TextBoxAutoComplete = False
        Me.txt_cdSemiGroupMaterialName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdSemiGroupMaterialName.TextBoxFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdSemiGroupMaterialName.TextEnabled = True
        Me.txt_cdSemiGroupMaterialName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdSemiGroupMaterialName.TextMaxLength = 32767
        Me.txt_cdSemiGroupMaterialName.TextMultiLine = False
        Me.txt_cdSemiGroupMaterialName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdSemiGroupMaterialName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdSemiGroupMaterialName.UseSendTab = True
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
        'PFP25520
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1444, 762)
        Me.Controls.Add(Me.ssp_WHERE)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "PFP25520"
        Me.Text = "MATERIAL WAREHOUSE AUDIT CONTROL (PFP25520A)"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.vS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vS1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.ssp_WHERE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ssp_WHERE.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
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
    Friend WithEvents PeacePanel1 As PSMGlobal.PeacePanel
    Public WithEvents chk_FSEL As PSMGlobal.PeaceCheckbox
    Public WithEvents cmd_SEARCH As System.Windows.Forms.Button
    Friend WithEvents SdateEdate As PSMGlobal.SelectPeaceCalDou
    Friend WithEvents Cms_1 As PSMGlobal.PeaceContextMenuStrip
    Public WithEvents txt_MaterialName As PSMGlobal.SelectLabelText
    Public WithEvents Panel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Cms_2 As PSMGlobal.PeaceContextMenuStrip
    Public WithEvents txt_InvoiceNo As PSMGlobal.SelectLabelText
    Public WithEvents ssp_WHERE As PSMGlobal.PeacePanel
    Friend WithEvents txt_CustomerInBoundMaterialName As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdSemiGroupMaterialName As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents PeaceLabel4 As PSMGlobal.PeaceLabel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PeaceCheckbox7 As PSMGlobal.PeaceCheckbox
    Friend WithEvents PeaceCheckbox8 As PSMGlobal.PeaceCheckbox
    Friend WithEvents PeaceCheckbox6 As PSMGlobal.PeaceCheckbox
    Friend WithEvents PeaceCheckbox2 As PSMGlobal.PeaceCheckbox
    Friend WithEvents PeaceCheckbox3 As PSMGlobal.PeaceCheckbox
    Friend WithEvents PeaceCheckbox4 As PSMGlobal.PeaceCheckbox
    Friend WithEvents PeaceCheckbox5 As PSMGlobal.PeaceCheckbox
    Friend WithEvents PeaceCheckbox1 As PSMGlobal.PeaceCheckbox
    Public WithEvents vS1 As PSMGlobal.PeaceFarpoint
    Public WithEvents vS1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents txt_cdDepartment As PSMGlobal.SelectPeaceHLPButton
    Public WithEvents ptsb_Manual As PSMGlobal.PeaceToolStripButton
    Public WithEvents ptsb_Help As PSMGlobal.PeaceToolStripButton
    Public WithEvents ptsb_Excel As PSMGlobal.PeaceToolStripButton
End Class
