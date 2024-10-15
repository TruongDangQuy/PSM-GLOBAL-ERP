<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PFP71014
    Inherits PeaceForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Dim Vs1_InputMapWhenFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim Vs1_InputMapWhenFocusedSingleSelect As FarPoint.Win.Spread.InputMap
        Dim Vs1_InputMapWhenAncestorOfFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim Vs1_InputMapWhenAncestorOfFocusedSingleSelect As FarPoint.Win.Spread.InputMap
        Dim TextCellType5 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
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
        Me.cmd_SEARCH = New PSMGlobal.PeaceButton(Me.components)
        Me.btn_Print = New PSMGlobal.PeaceButton(Me.components)
        Me.Panel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.chk_CheckUse1 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_CheckUse2 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.tit_CheckUse = New PSMGlobal.PeaceLabel(Me.components)
        Me.Panel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.opt_SortName = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.opt_SortCode = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.tit_Sort = New PSMGlobal.PeaceLabel(Me.components)
        Me.chk_FSEL = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.txt_GNAME = New PSMGlobal.SelectLabelText()
        Me.ssp_WHERE = New PSMGlobal.PeacePanel(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_CheckCustomerStatus4 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.rad_CheckCustomerStatus1 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.rad_CheckCustomerStatus2 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.rad_CheckCustomerStatus3 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.rad_CheckCustomerStatus5 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.rad_CheckCustomerStatus6 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.Lab_CheckCustomerStatus = New PSMGlobal.PeaceLabel(Me.components)
        Me.Frame3 = New PSMGlobal.PeacePanel(Me.components)
        Me.chk_CheckOutside = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_CheckInside = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_CheckEmployee = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_CheckOther = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_CheckSupplier = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_CheckCustomer = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.lbt_Type = New PSMGlobal.PeaceLabel(Me.components)
        Me.Cms_1 = New PSMGlobal.PeaceContextMenuStrip(Me.components)
        Vs1_InputMapWhenFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenFocusedSingleSelect = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenFocusedSingleSelect.Parent = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedSingleSelect = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedSingleSelect.Parent = New FarPoint.Win.Spread.InputMap()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.ssp_WHERE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ssp_WHERE.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.Frame3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame3.SuspendLayout()
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
        Me.Vs1.AllowDragFill = True
        Me.Vs1.AllowEditorReservedLocations = False
        Me.Vs1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Vs1.ClipboardOptions = FarPoint.Win.Spread.ClipboardOptions.NoHeaders
        Me.Vs1.CopyPasteChk = True
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
        Me.Vs1.InsChk = False
        Me.Vs1.Location = New System.Drawing.Point(1, 68)
        Me.Vs1.Margin = New System.Windows.Forms.Padding(0)
        Me.Vs1.Name = "Vs1"
        NamedStyle1.BackColor = System.Drawing.SystemColors.Window
        NamedStyle1.CellType = GeneralCellType1
        NamedStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        NamedStyle1.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        NamedStyle1.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle1.Renderer = GeneralCellType1
        NamedStyle1.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
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
        NamedStyle6.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        NamedStyle6.Locked = False
        NamedStyle6.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle6.Renderer = GeneralCellType2
        NamedStyle6.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.Vs1.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle1, NamedStyle2, NamedStyle3, NamedStyle4, NamedStyle5, NamedStyle6})
        Me.Vs1.ReportName = Nothing
        Me.Vs1.SheetDSName = Nothing
        Me.Vs1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.Vs1_Sheet1})
        Me.Vs1.Size = New System.Drawing.Size(1262, 612)
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
        Me.Vs1.TabIndex = 14
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
        Vs1_InputMapWhenFocusedSingleSelect.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Vs1_InputMapWhenFocusedSingleSelect.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        Vs1_InputMapWhenFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.C, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCopy)
        Vs1_InputMapWhenFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Insert, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCopy)
        Vs1_InputMapWhenFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Z, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Undo)
        Vs1_InputMapWhenFocusedSingleSelect.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Y, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Redo)
        Me.Vs1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.SingleSelect, Vs1_InputMapWhenFocusedSingleSelect)
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
        Me.Vs1_Sheet1.ColumnFooter.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.Vs1_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.ColumnFooter.DefaultStyle.Parent = "RowHeaderDefault"
        Me.Vs1_Sheet1.ColumnFooter.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.Vs1_Sheet1.ColumnFooter.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnFooter.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.ForeColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.Parent = "RowHeaderDefault"
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnHeader.Cells.Get(0, 0).Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Vs1_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        TextCellType5.WordWrap = True
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.CellType = TextCellType5
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.Renderer = TextCellType5
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnHeader.Rows.Get(0).Height = 25.0!
        Me.Vs1_Sheet1.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs1_Sheet1.DefaultStyle.ForeColor = System.Drawing.Color.Black
        Me.Vs1_Sheet1.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.Vs1_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.DefaultStyle.Parent = "DataAreaDefault"
        Me.Vs1_Sheet1.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.Vs1_Sheet1.FilterBar.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.Vs1_Sheet1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.FilterBar.DefaultStyle.Parent = "FilterBarDefaultEnhanced"
        Me.Vs1_Sheet1.FilterBar.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.Vs1_Sheet1.FilterBar.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.Vs1_Sheet1.FilterBarHeaderStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.Vs1_Sheet1.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.Vs1_Sheet1.FilterBarHeaderStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.Vs1_Sheet1.FilterBarHeaderStyle.VisualStyles = FarPoint.Win.VisualStyles.[Auto]
        Me.Vs1_Sheet1.GroupBarInfo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vs1_Sheet1.NullFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs1_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.SingleSelect
        Me.Vs1_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.Vs1_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.CellType = TextCellType5
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.Renderer = TextCellType5
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
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
        Me.Vs1_Sheet1.SheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.Vs1_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.SheetCornerStyle.Parent = "RowHeaderDefault"
        Me.Vs1_Sheet1.SheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.Vs1_Sheet1.SheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
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
        Me.tst_1.Size = New System.Drawing.Size(116, 27)
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
        Me.tst_2.Size = New System.Drawing.Size(118, 27)
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
        Me.tst_3.Size = New System.Drawing.Size(122, 27)
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
        Me.tst_4.Size = New System.Drawing.Size(116, 27)
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
        Me.tst_5.Size = New System.Drawing.Size(108, 27)
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
        Me.tst_6.Size = New System.Drawing.Size(160, 27)
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
        Me.ptsb_Manual.Size = New System.Drawing.Size(29, 27)
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
        Me.ptsb_Help.Size = New System.Drawing.Size(29, 27)
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
        Me.ptsb_Excel.Size = New System.Drawing.Size(29, 27)
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
        Me.Panel2.ColumnCount = 9
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Panel2.Controls.Add(Me.cmd_SEARCH, 8, 0)
        Me.Panel2.Controls.Add(Me.btn_Print, 7, 0)
        Me.Panel2.Controls.Add(Me.Panel5, 5, 0)
        Me.Panel2.Controls.Add(Me.tit_CheckUse, 4, 0)
        Me.Panel2.Controls.Add(Me.Panel4, 3, 0)
        Me.Panel2.Controls.Add(Me.tit_Sort, 2, 0)
        Me.Panel2.Controls.Add(Me.chk_FSEL, 0, 0)
        Me.Panel2.Controls.Add(Me.txt_GNAME, 1, 0)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RowCount = 1
        Me.Panel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel2.Size = New System.Drawing.Size(1252, 25)
        Me.Panel2.TabIndex = 17
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
        'btn_Print
        '
        Me.btn_Print.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Print.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_Print.Appearance.Options.UseFont = True
        Me.btn_Print.Appearance.Options.UseForeColor = True
        Me.btn_Print.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btn_Print.ButtonTitle = Nothing
        Me.btn_Print.Code = Nothing
        Me.btn_Print.Data = Nothing
        Me.btn_Print.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Print.Image = Global.PSMGlobal.My.Resources.Resources.print_f
        Me.btn_Print.ImageAlign = 16
        Me.btn_Print.Location = New System.Drawing.Point(987, 2)
        Me.btn_Print.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_Print.Name = "btn_Print"
        Me.btn_Print.Size = New System.Drawing.Size(130, 21)
        Me.btn_Print.TabIndex = 7
        Me.btn_Print.Text = "Print(&P)"
        Me.btn_Print.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Panel5.ColumnCount = 2
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.Controls.Add(Me.chk_CheckUse1, 0, 0)
        Me.Panel5.Controls.Add(Me.chk_CheckUse2, 1, 0)
        Me.Panel5.Location = New System.Drawing.Point(822, 2)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.RowCount = 1
        Me.Panel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.Size = New System.Drawing.Size(138, 21)
        Me.Panel5.TabIndex = 16
        '
        'chk_CheckUse1
        '
        Me.chk_CheckUse1.AutoSize = True
        Me.chk_CheckUse1.ButtonTitle = Nothing
        Me.chk_CheckUse1.Checked = True
        Me.chk_CheckUse1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_CheckUse1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chk_CheckUse1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckUse1.ForeColor = System.Drawing.Color.Black
        Me.chk_CheckUse1.Location = New System.Drawing.Point(4, 4)
        Me.chk_CheckUse1.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.chk_CheckUse1.Name = "chk_CheckUse1"
        Me.chk_CheckUse1.Size = New System.Drawing.Size(64, 16)
        Me.chk_CheckUse1.TabIndex = 0
        Me.chk_CheckUse1.Text = "Yes"
        Me.chk_CheckUse1.UseVisualStyleBackColor = True
        '
        'chk_CheckUse2
        '
        Me.chk_CheckUse2.AutoSize = True
        Me.chk_CheckUse2.ButtonTitle = Nothing
        Me.chk_CheckUse2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chk_CheckUse2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckUse2.ForeColor = System.Drawing.Color.Black
        Me.chk_CheckUse2.Location = New System.Drawing.Point(72, 4)
        Me.chk_CheckUse2.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.chk_CheckUse2.Name = "chk_CheckUse2"
        Me.chk_CheckUse2.Size = New System.Drawing.Size(65, 16)
        Me.chk_CheckUse2.TabIndex = 1
        Me.chk_CheckUse2.Text = "No"
        Me.chk_CheckUse2.UseVisualStyleBackColor = True
        '
        'tit_CheckUse
        '
        Me.tit_CheckUse.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.tit_CheckUse.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tit_CheckUse.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tit_CheckUse.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tit_CheckUse.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.tit_CheckUse.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tit_CheckUse.ButtonTitle = Nothing
        Me.tit_CheckUse.Code = ""
        Me.tit_CheckUse.Data = ""
        Me.tit_CheckUse.DTDec = 0
        Me.tit_CheckUse.DTLen = 0
        Me.tit_CheckUse.DTValue = 0
        Me.tit_CheckUse.Location = New System.Drawing.Point(696, 2)
        Me.tit_CheckUse.Margin = New System.Windows.Forms.Padding(1)
        Me.tit_CheckUse.Name = "tit_CheckUse"
        Me.tit_CheckUse.NoClear = False
        Me.tit_CheckUse.Size = New System.Drawing.Size(123, 21)
        Me.tit_CheckUse.TabIndex = 18
        Me.tit_CheckUse.Tag = ""
        Me.tit_CheckUse.Text = "Use"
        Me.tit_CheckUse.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Panel4.ColumnCount = 2
        Me.Panel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.4359!))
        Me.Panel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.5641!))
        Me.Panel4.Controls.Add(Me.opt_SortName, 0, 0)
        Me.Panel4.Controls.Add(Me.opt_SortCode, 1, 0)
        Me.Panel4.Location = New System.Drawing.Point(555, 2)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.RowCount = 1
        Me.Panel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel4.Size = New System.Drawing.Size(138, 21)
        Me.Panel4.TabIndex = 19
        '
        'opt_SortName
        '
        Me.opt_SortName.AutoSize = True
        Me.opt_SortName.ButtonTitle = Nothing
        Me.opt_SortName.Checked = True
        Me.opt_SortName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.opt_SortName.ForeColor = System.Drawing.Color.Black
        Me.opt_SortName.Location = New System.Drawing.Point(2, 2)
        Me.opt_SortName.Margin = New System.Windows.Forms.Padding(1)
        Me.opt_SortName.Name = "opt_SortName"
        Me.opt_SortName.Size = New System.Drawing.Size(62, 17)
        Me.opt_SortName.TabIndex = 1
        Me.opt_SortName.TabStop = True
        Me.opt_SortName.Text = "Name"
        Me.opt_SortName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.opt_SortName.UseVisualStyleBackColor = True
        '
        'opt_SortCode
        '
        Me.opt_SortCode.AutoSize = True
        Me.opt_SortCode.ButtonTitle = Nothing
        Me.opt_SortCode.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.opt_SortCode.ForeColor = System.Drawing.Color.Black
        Me.opt_SortCode.Location = New System.Drawing.Point(67, 2)
        Me.opt_SortCode.Margin = New System.Windows.Forms.Padding(1)
        Me.opt_SortCode.Name = "opt_SortCode"
        Me.opt_SortCode.Size = New System.Drawing.Size(66, 17)
        Me.opt_SortCode.TabIndex = 0
        Me.opt_SortCode.Text = "Code"
        Me.opt_SortCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.opt_SortCode.UseVisualStyleBackColor = True
        '
        'tit_Sort
        '
        Me.tit_Sort.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.tit_Sort.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tit_Sort.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tit_Sort.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tit_Sort.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.tit_Sort.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tit_Sort.ButtonTitle = Nothing
        Me.tit_Sort.Code = ""
        Me.tit_Sort.Data = ""
        Me.tit_Sort.DTDec = 0
        Me.tit_Sort.DTLen = 0
        Me.tit_Sort.DTValue = 0
        Me.tit_Sort.Location = New System.Drawing.Point(429, 2)
        Me.tit_Sort.Margin = New System.Windows.Forms.Padding(1)
        Me.tit_Sort.Name = "tit_Sort"
        Me.tit_Sort.NoClear = False
        Me.tit_Sort.Size = New System.Drawing.Size(123, 21)
        Me.tit_Sort.TabIndex = 17
        Me.tit_Sort.Tag = ""
        Me.tit_Sort.Text = "Sort"
        Me.tit_Sort.TextAlign = DevExpress.Utils.HorzAlignment.Center
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
        'txt_GNAME
        '
        Me.txt_GNAME.BackYesno = False
        Me.txt_GNAME.ButtonTitle = Nothing
        Me.txt_GNAME.Code = Nothing
        Me.txt_GNAME.Data = ""
        Me.txt_GNAME.DataDecimal = 0
        Me.txt_GNAME.DataLen = 0
        Me.txt_GNAME.DataValue = 0
        Me.txt_GNAME.Dock = System.Windows.Forms.DockStyle.Left
        Me.txt_GNAME.FormatDecimal = 0
        Me.txt_GNAME.FormatValue = False
        Me.txt_GNAME.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_GNAME.LableEnabled = True
        Me.txt_GNAME.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_GNAME.LableForeColor = System.Drawing.Color.Empty
        Me.txt_GNAME.LableTitle = "Name"
        Me.txt_GNAME.Layoutpercent = New Decimal(New Integer() {46, 0, 0, 131072})
        Me.txt_GNAME.Location = New System.Drawing.Point(128, 2)
        Me.txt_GNAME.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_GNAME.Name = "txt_GNAME"
        Me.txt_GNAME.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_GNAME.Size = New System.Drawing.Size(298, 21)
        Me.txt_GNAME.TabIndex = 112
        Me.txt_GNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_GNAME.TextBoxAutoComplete = False
        Me.txt_GNAME.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_GNAME.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_GNAME.TextEnabled = True
        Me.txt_GNAME.TextForeColor = System.Drawing.Color.Empty
        Me.txt_GNAME.TextMaxLength = 32767
        Me.txt_GNAME.TextMultiLine = False
        Me.txt_GNAME.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_GNAME.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_GNAME.UseSendTab = True
        '
        'ssp_WHERE
        '
        Me.ssp_WHERE.Code = ""
        Me.ssp_WHERE.Controls.Add(Me.TableLayoutPanel2)
        Me.ssp_WHERE.Controls.Add(Me.Lab_CheckCustomerStatus)
        Me.ssp_WHERE.Controls.Add(Me.Frame3)
        Me.ssp_WHERE.Controls.Add(Me.lbt_Type)
        Me.ssp_WHERE.Data = ""
        Me.ssp_WHERE.Location = New System.Drawing.Point(50, 86)
        Me.ssp_WHERE.Name = "ssp_WHERE"
        Me.ssp_WHERE.Size = New System.Drawing.Size(517, 180)
        Me.ssp_WHERE.TabIndex = 15
        Me.ssp_WHERE.Tag = ""
        Me.ssp_WHERE.Visible = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.61905!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.38095!))
        Me.TableLayoutPanel2.Controls.Add(Me.rad_CheckCustomerStatus4, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.rad_CheckCustomerStatus1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.rad_CheckCustomerStatus2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.rad_CheckCustomerStatus3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.rad_CheckCustomerStatus5, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.rad_CheckCustomerStatus6, 1, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(165, 92)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(335, 75)
        Me.TableLayoutPanel2.TabIndex = 67
        Me.TableLayoutPanel2.Visible = False
        '
        'rad_CheckCustomerStatus4
        '
        Me.rad_CheckCustomerStatus4.AutoSize = True
        Me.rad_CheckCustomerStatus4.ButtonTitle = Nothing
        Me.rad_CheckCustomerStatus4.Checked = True
        Me.rad_CheckCustomerStatus4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rad_CheckCustomerStatus4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckCustomerStatus4.ForeColor = System.Drawing.Color.Black
        Me.rad_CheckCustomerStatus4.Location = New System.Drawing.Point(163, 4)
        Me.rad_CheckCustomerStatus4.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.rad_CheckCustomerStatus4.Name = "rad_CheckCustomerStatus4"
        Me.rad_CheckCustomerStatus4.Size = New System.Drawing.Size(80, 22)
        Me.rad_CheckCustomerStatus4.TabIndex = 3
        Me.rad_CheckCustomerStatus4.Text = "Cancel"
        Me.rad_CheckCustomerStatus4.UseVisualStyleBackColor = True
        '
        'rad_CheckCustomerStatus1
        '
        Me.rad_CheckCustomerStatus1.AutoSize = True
        Me.rad_CheckCustomerStatus1.ButtonTitle = Nothing
        Me.rad_CheckCustomerStatus1.Checked = True
        Me.rad_CheckCustomerStatus1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rad_CheckCustomerStatus1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckCustomerStatus1.ForeColor = System.Drawing.Color.Black
        Me.rad_CheckCustomerStatus1.Location = New System.Drawing.Point(4, 4)
        Me.rad_CheckCustomerStatus1.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.rad_CheckCustomerStatus1.Name = "rad_CheckCustomerStatus1"
        Me.rad_CheckCustomerStatus1.Size = New System.Drawing.Size(128, 22)
        Me.rad_CheckCustomerStatus1.TabIndex = 0
        Me.rad_CheckCustomerStatus1.Text = "NotApproved"
        Me.rad_CheckCustomerStatus1.UseVisualStyleBackColor = True
        '
        'rad_CheckCustomerStatus2
        '
        Me.rad_CheckCustomerStatus2.AutoSize = True
        Me.rad_CheckCustomerStatus2.ButtonTitle = Nothing
        Me.rad_CheckCustomerStatus2.Checked = True
        Me.rad_CheckCustomerStatus2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rad_CheckCustomerStatus2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckCustomerStatus2.ForeColor = System.Drawing.Color.Black
        Me.rad_CheckCustomerStatus2.Location = New System.Drawing.Point(4, 30)
        Me.rad_CheckCustomerStatus2.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.rad_CheckCustomerStatus2.Name = "rad_CheckCustomerStatus2"
        Me.rad_CheckCustomerStatus2.Size = New System.Drawing.Size(100, 22)
        Me.rad_CheckCustomerStatus2.TabIndex = 2
        Me.rad_CheckCustomerStatus2.Text = "Complete"
        Me.rad_CheckCustomerStatus2.UseVisualStyleBackColor = True
        '
        'rad_CheckCustomerStatus3
        '
        Me.rad_CheckCustomerStatus3.AutoSize = True
        Me.rad_CheckCustomerStatus3.ButtonTitle = Nothing
        Me.rad_CheckCustomerStatus3.Checked = True
        Me.rad_CheckCustomerStatus3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rad_CheckCustomerStatus3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckCustomerStatus3.ForeColor = System.Drawing.Color.Black
        Me.rad_CheckCustomerStatus3.Location = New System.Drawing.Point(4, 56)
        Me.rad_CheckCustomerStatus3.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.rad_CheckCustomerStatus3.Name = "rad_CheckCustomerStatus3"
        Me.rad_CheckCustomerStatus3.Size = New System.Drawing.Size(101, 22)
        Me.rad_CheckCustomerStatus3.TabIndex = 1
        Me.rad_CheckCustomerStatus3.Text = "Approved"
        Me.rad_CheckCustomerStatus3.UseVisualStyleBackColor = True
        '
        'rad_CheckCustomerStatus5
        '
        Me.rad_CheckCustomerStatus5.AutoSize = True
        Me.rad_CheckCustomerStatus5.ButtonTitle = Nothing
        Me.rad_CheckCustomerStatus5.Checked = True
        Me.rad_CheckCustomerStatus5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rad_CheckCustomerStatus5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckCustomerStatus5.ForeColor = System.Drawing.Color.Black
        Me.rad_CheckCustomerStatus5.Location = New System.Drawing.Point(163, 30)
        Me.rad_CheckCustomerStatus5.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.rad_CheckCustomerStatus5.Name = "rad_CheckCustomerStatus5"
        Me.rad_CheckCustomerStatus5.Size = New System.Drawing.Size(104, 22)
        Me.rad_CheckCustomerStatus5.TabIndex = 5
        Me.rad_CheckCustomerStatus5.Text = "Pending 1"
        Me.rad_CheckCustomerStatus5.UseVisualStyleBackColor = True
        '
        'rad_CheckCustomerStatus6
        '
        Me.rad_CheckCustomerStatus6.AutoSize = True
        Me.rad_CheckCustomerStatus6.ButtonTitle = Nothing
        Me.rad_CheckCustomerStatus6.Checked = True
        Me.rad_CheckCustomerStatus6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rad_CheckCustomerStatus6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckCustomerStatus6.ForeColor = System.Drawing.Color.Black
        Me.rad_CheckCustomerStatus6.Location = New System.Drawing.Point(163, 56)
        Me.rad_CheckCustomerStatus6.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.rad_CheckCustomerStatus6.Name = "rad_CheckCustomerStatus6"
        Me.rad_CheckCustomerStatus6.Size = New System.Drawing.Size(104, 22)
        Me.rad_CheckCustomerStatus6.TabIndex = 4
        Me.rad_CheckCustomerStatus6.Text = "Pending 2"
        Me.rad_CheckCustomerStatus6.UseVisualStyleBackColor = True
        '
        'Lab_CheckCustomerStatus
        '
        Me.Lab_CheckCustomerStatus.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Lab_CheckCustomerStatus.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Lab_CheckCustomerStatus.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Lab_CheckCustomerStatus.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Lab_CheckCustomerStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.Lab_CheckCustomerStatus.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Lab_CheckCustomerStatus.ButtonTitle = Nothing
        Me.Lab_CheckCustomerStatus.Code = ""
        Me.Lab_CheckCustomerStatus.Data = ""
        Me.Lab_CheckCustomerStatus.DTDec = 0
        Me.Lab_CheckCustomerStatus.DTLen = 0
        Me.Lab_CheckCustomerStatus.DTValue = 0
        Me.Lab_CheckCustomerStatus.Location = New System.Drawing.Point(18, 92)
        Me.Lab_CheckCustomerStatus.Margin = New System.Windows.Forms.Padding(1)
        Me.Lab_CheckCustomerStatus.Name = "Lab_CheckCustomerStatus"
        Me.Lab_CheckCustomerStatus.NoClear = False
        Me.Lab_CheckCustomerStatus.Size = New System.Drawing.Size(141, 80)
        Me.Lab_CheckCustomerStatus.TabIndex = 66
        Me.Lab_CheckCustomerStatus.Tag = ""
        Me.Lab_CheckCustomerStatus.Text = "Status"
        Me.Lab_CheckCustomerStatus.TextAlign = DevExpress.Utils.HorzAlignment.Center
        Me.Lab_CheckCustomerStatus.Visible = False
        '
        'Frame3
        '
        Me.Frame3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Frame3.Code = ""
        Me.Frame3.Controls.Add(Me.chk_CheckOutside)
        Me.Frame3.Controls.Add(Me.chk_CheckInside)
        Me.Frame3.Controls.Add(Me.chk_CheckEmployee)
        Me.Frame3.Controls.Add(Me.chk_CheckOther)
        Me.Frame3.Controls.Add(Me.chk_CheckSupplier)
        Me.Frame3.Controls.Add(Me.chk_CheckCustomer)
        Me.Frame3.Data = ""
        Me.Frame3.Location = New System.Drawing.Point(165, 18)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Size = New System.Drawing.Size(335, 70)
        Me.Frame3.TabIndex = 65
        Me.Frame3.Tag = ""
        '
        'chk_CheckOutside
        '
        Me.chk_CheckOutside.AutoSize = True
        Me.chk_CheckOutside.ButtonTitle = Nothing
        Me.chk_CheckOutside.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckOutside.ForeColor = System.Drawing.Color.Black
        Me.chk_CheckOutside.Location = New System.Drawing.Point(118, 41)
        Me.chk_CheckOutside.Name = "chk_CheckOutside"
        Me.chk_CheckOutside.Size = New System.Drawing.Size(88, 22)
        Me.chk_CheckOutside.TabIndex = 5
        Me.chk_CheckOutside.Text = "Outside"
        Me.chk_CheckOutside.UseVisualStyleBackColor = True
        '
        'chk_CheckInside
        '
        Me.chk_CheckInside.AutoSize = True
        Me.chk_CheckInside.ButtonTitle = Nothing
        Me.chk_CheckInside.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckInside.ForeColor = System.Drawing.Color.Black
        Me.chk_CheckInside.Location = New System.Drawing.Point(4, 41)
        Me.chk_CheckInside.Name = "chk_CheckInside"
        Me.chk_CheckInside.Size = New System.Drawing.Size(77, 22)
        Me.chk_CheckInside.TabIndex = 4
        Me.chk_CheckInside.Text = "Inside"
        Me.chk_CheckInside.UseVisualStyleBackColor = True
        '
        'chk_CheckEmployee
        '
        Me.chk_CheckEmployee.AutoSize = True
        Me.chk_CheckEmployee.ButtonTitle = Nothing
        Me.chk_CheckEmployee.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckEmployee.ForeColor = System.Drawing.Color.Black
        Me.chk_CheckEmployee.Location = New System.Drawing.Point(212, 13)
        Me.chk_CheckEmployee.Name = "chk_CheckEmployee"
        Me.chk_CheckEmployee.Size = New System.Drawing.Size(102, 22)
        Me.chk_CheckEmployee.TabIndex = 3
        Me.chk_CheckEmployee.Text = "Employee"
        Me.chk_CheckEmployee.UseVisualStyleBackColor = True
        '
        'chk_CheckOther
        '
        Me.chk_CheckOther.AutoSize = True
        Me.chk_CheckOther.ButtonTitle = Nothing
        Me.chk_CheckOther.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckOther.ForeColor = System.Drawing.Color.Black
        Me.chk_CheckOther.Location = New System.Drawing.Point(212, 41)
        Me.chk_CheckOther.Name = "chk_CheckOther"
        Me.chk_CheckOther.Size = New System.Drawing.Size(73, 22)
        Me.chk_CheckOther.TabIndex = 2
        Me.chk_CheckOther.Text = "Other"
        Me.chk_CheckOther.UseVisualStyleBackColor = True
        '
        'chk_CheckSupplier
        '
        Me.chk_CheckSupplier.AutoSize = True
        Me.chk_CheckSupplier.ButtonTitle = Nothing
        Me.chk_CheckSupplier.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckSupplier.ForeColor = System.Drawing.Color.Black
        Me.chk_CheckSupplier.Location = New System.Drawing.Point(120, 13)
        Me.chk_CheckSupplier.Name = "chk_CheckSupplier"
        Me.chk_CheckSupplier.Size = New System.Drawing.Size(93, 22)
        Me.chk_CheckSupplier.TabIndex = 1
        Me.chk_CheckSupplier.Text = "Supplier"
        Me.chk_CheckSupplier.UseVisualStyleBackColor = True
        '
        'chk_CheckCustomer
        '
        Me.chk_CheckCustomer.AutoSize = True
        Me.chk_CheckCustomer.ButtonTitle = Nothing
        Me.chk_CheckCustomer.Checked = True
        Me.chk_CheckCustomer.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_CheckCustomer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckCustomer.ForeColor = System.Drawing.Color.Black
        Me.chk_CheckCustomer.Location = New System.Drawing.Point(5, 13)
        Me.chk_CheckCustomer.Name = "chk_CheckCustomer"
        Me.chk_CheckCustomer.Size = New System.Drawing.Size(101, 22)
        Me.chk_CheckCustomer.TabIndex = 0
        Me.chk_CheckCustomer.Text = "Customer"
        Me.chk_CheckCustomer.UseVisualStyleBackColor = True
        '
        'lbt_Type
        '
        Me.lbt_Type.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.lbt_Type.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbt_Type.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbt_Type.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbt_Type.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lbt_Type.ButtonTitle = Nothing
        Me.lbt_Type.Code = ""
        Me.lbt_Type.Data = ""
        Me.lbt_Type.DTDec = 0
        Me.lbt_Type.DTLen = 0
        Me.lbt_Type.DTValue = 0
        Me.lbt_Type.Location = New System.Drawing.Point(18, 18)
        Me.lbt_Type.Name = "lbt_Type"
        Me.lbt_Type.NoClear = False
        Me.lbt_Type.Size = New System.Drawing.Size(141, 70)
        Me.lbt_Type.TabIndex = 64
        Me.lbt_Type.Tag = ""
        Me.lbt_Type.Text = "Type"
        Me.lbt_Type.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'Cms_1
        '
        Me.Cms_1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Cms_1.Name = "Cms_1"
        Me.Cms_1.Size = New System.Drawing.Size(61, 4)
        '
        'PFP71014
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.ssp_WHERE)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "PFP71014"
        Me.Text = "Danh mục khách hàng (PFP71014)"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.ssp_WHERE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ssp_WHERE.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.Frame3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
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
    Public WithEvents Frame3 As PSMGlobal.PeacePanel
    Public WithEvents chk_CheckOutside As PSMGlobal.PeaceCheckbox
    Public WithEvents chk_CheckInside As PSMGlobal.PeaceCheckbox
    Public WithEvents chk_CheckEmployee As PSMGlobal.PeaceCheckbox
    Public WithEvents chk_CheckOther As PSMGlobal.PeaceCheckbox
    Public WithEvents chk_CheckSupplier As PSMGlobal.PeaceCheckbox
    Public WithEvents chk_CheckCustomer As PSMGlobal.PeaceCheckbox
    Public WithEvents lbt_Type As PSMGlobal.PeaceLabel
    Public WithEvents Vs1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents PeacePanel1 As PSMGlobal.PeacePanel
    Public WithEvents Panel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chk_CheckUse1 As PSMGlobal.PeaceCheckbox
    Friend WithEvents chk_CheckUse2 As PSMGlobal.PeaceCheckbox
    Friend WithEvents tit_CheckUse As PSMGlobal.PeaceLabel
    Friend WithEvents Panel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents opt_SortName As PSMGlobal.PeaceRadioButton
    Friend WithEvents opt_SortCode As PSMGlobal.PeaceRadioButton
    Friend WithEvents tit_Sort As PSMGlobal.PeaceLabel
    Public WithEvents chk_FSEL As PSMGlobal.PeaceCheckbox
    Public WithEvents txt_GNAME As PSMGlobal.SelectLabelText
    Public WithEvents cmd_SEARCH As PSMGlobal.PeaceButton
    Public WithEvents btn_Print As PSMGlobal.PeaceButton
    Public WithEvents Vs1 As PSMGlobal.PeaceFarpoint
    Friend WithEvents Lab_CheckCustomerStatus As PSMGlobal.PeaceLabel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_CheckCustomerStatus4 As PSMGlobal.PeaceCheckbox
    Friend WithEvents rad_CheckCustomerStatus1 As PSMGlobal.PeaceCheckbox
    Friend WithEvents rad_CheckCustomerStatus2 As PSMGlobal.PeaceCheckbox
    Friend WithEvents rad_CheckCustomerStatus3 As PSMGlobal.PeaceCheckbox
    Friend WithEvents rad_CheckCustomerStatus5 As PSMGlobal.PeaceCheckbox
    Friend WithEvents rad_CheckCustomerStatus6 As PSMGlobal.PeaceCheckbox
    Friend WithEvents Cms_1 As PSMGlobal.PeaceContextMenuStrip

End Class
