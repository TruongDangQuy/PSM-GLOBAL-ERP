<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HLP1312L
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HLP1312L))
        Dim EnhancedScrollBarRenderer1 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim NamedStyle1 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style2")
        Dim BevelBorder1 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType1 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle2 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style3")
        Dim BevelBorder2 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType2 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle3 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style1")
        Dim BevelBorder3 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType3 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle4 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style4")
        Dim BevelBorder4 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType4 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle5 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style5")
        Dim GeneralCellType1 As FarPoint.Win.Spread.CellType.GeneralCellType = New FarPoint.Win.Spread.CellType.GeneralCellType()
        Dim SpreadSkin1 As FarPoint.Win.Spread.SpreadSkin = New FarPoint.Win.Spread.SpreadSkin()
        Dim EnhancedFocusIndicatorRenderer1 As FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer = New FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer()
        Dim EnhancedInterfaceRenderer1 As FarPoint.Win.Spread.EnhancedInterfaceRenderer = New FarPoint.Win.Spread.EnhancedInterfaceRenderer()
        Dim EnhancedScrollBarRenderer2 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim EnhancedScrollBarRenderer3 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim PeacePanalSeach_InputMapWhenFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim TextCellType5 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Cms_1 = New PSMGlobal.PeaceContextMenuStrip(Me.components)
        Me.Cms_2 = New PSMGlobal.PeaceContextMenuStrip(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Frame4 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.PeacePanalSeach = New PSMGlobal.PeaceFarpoint()
        Me.PeacePanalSeach_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.PeacePanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.Panel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_ColorCode = New PSMGlobal.SelectLabelText()
        Me.txt_SizeSpecifize = New PSMGlobal.SelectLabelText()
        Me.chk_FSEL = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.cmd_SEARCH = New PSMGlobal.PeaceButton(Me.components)
        Me.PeacePanel6 = New PSMGlobal.PeacePanel(Me.components)
        Me.opt_CheckRelationType1 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.opt_CheckRelationType0 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.lbla_use = New PSMGlobal.PeaceLabel(Me.components)
        Me.PeaceRadioButton5 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.chk_CheckDate = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.ssp_WHERE = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_ShoesCode = New PSMGlobal.SelectLabelText()
        Me.SdateEdate = New PSMGlobal.SelectPeaceCalDou()
        Me.txt_CustomerCode = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdSeason = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_Line = New PSMGlobal.SelectLabelText()
        Me.txt_Article = New PSMGlobal.SelectLabelText()
        Me.txt_Customer = New PSMGlobal.SelectLabelText()
        PeacePanalSeach_InputMapWhenFocusedNormal = New FarPoint.Win.Spread.InputMap()
        PeacePanalSeach_InputMapWhenFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal = New FarPoint.Win.Spread.InputMap()
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame4.SuspendLayout()
        CType(Me.PeacePanalSeach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeacePanalSeach_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PeacePanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel6.SuspendLayout()
        CType(Me.ssp_WHERE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ssp_WHERE.SuspendLayout()
        Me.SuspendLayout()
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Frame4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PeacePanalSeach, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PeacePanel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1287, 751)
        Me.TableLayoutPanel1.TabIndex = 18
        '
        'Frame4
        '
        Me.Frame4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Frame4.Code = ""
        Me.Frame4.Controls.Add(Me.cmd_Cancel)
        Me.Frame4.Controls.Add(Me.cmd_OK)
        Me.Frame4.Data = ""
        Me.Frame4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame4.Location = New System.Drawing.Point(4, 713)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Size = New System.Drawing.Size(1279, 34)
        Me.Frame4.TabIndex = 18
        Me.Frame4.Tag = ""
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.ButtonTitle = Nothing
        Me.cmd_Cancel.Code = ""
        Me.cmd_Cancel.Data = ""
        Me.cmd_Cancel.Image = CType(resources.GetObject("cmd_Cancel.Image"), System.Drawing.Image)
        Me.cmd_Cancel.ImageAlign = 16
        Me.cmd_Cancel.Location = New System.Drawing.Point(1133, 3)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(141, 27)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.TabStop = False
        Me.cmd_Cancel.Tag = ""
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'cmd_OK
        '
        Me.cmd_OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_OK.ButtonTitle = Nothing
        Me.cmd_OK.Code = ""
        Me.cmd_OK.Data = ""
        Me.cmd_OK.Image = CType(resources.GetObject("cmd_OK.Image"), System.Drawing.Image)
        Me.cmd_OK.ImageAlign = 16
        Me.cmd_OK.Location = New System.Drawing.Point(986, 3)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(141, 27)
        Me.cmd_OK.TabIndex = 0
        Me.cmd_OK.TabStop = False
        Me.cmd_OK.Tag = ""
        Me.cmd_OK.Text = "OK(&K)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'PeacePanalSeach
        '
        Me.PeacePanalSeach.AccessibleDescription = ""
        Me.PeacePanalSeach.AllowDragFill = True
        Me.PeacePanalSeach.ClipboardOptions = FarPoint.Win.Spread.ClipboardOptions.NoHeaders
        Me.PeacePanalSeach.CopyPasteChk = False
        Me.PeacePanalSeach.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeacePanalSeach.FocusRenderer = New FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer(1)
        Me.PeacePanalSeach.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeacePanalSeach.HorizontalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.PeacePanalSeach.HorizontalScrollBar.Name = ""
        EnhancedScrollBarRenderer1.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer1.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.PeacePanalSeach.HorizontalScrollBar.Renderer = EnhancedScrollBarRenderer1
        Me.PeacePanalSeach.HorizontalScrollBar.TabIndex = 0
        Me.PeacePanalSeach.InsChk = False
        Me.PeacePanalSeach.Location = New System.Drawing.Point(4, 40)
        Me.PeacePanalSeach.Name = "PeacePanalSeach"
        NamedStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle1.Border = BevelBorder1
        NamedStyle1.CanFocus = False
        TextCellType1.WordWrap = True
        NamedStyle1.CellType = TextCellType1
        NamedStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        NamedStyle1.ForeColor = System.Drawing.Color.White
        NamedStyle1.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle1.Locked = False
        NamedStyle1.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle1.Renderer = TextCellType1
        NamedStyle1.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle1.VisualStyles = FarPoint.Win.VisualStyles.Off
        NamedStyle2.Border = BevelBorder2
        NamedStyle2.CellType = TextCellType2
        NamedStyle2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamedStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle2.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle2.Locked = False
        NamedStyle2.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle2.Renderer = TextCellType2
        NamedStyle2.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle3.Border = BevelBorder3
        NamedStyle3.CanFocus = False
        NamedStyle3.CellType = TextCellType3
        NamedStyle3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamedStyle3.ForeColor = System.Drawing.Color.White
        NamedStyle3.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle3.Locked = False
        NamedStyle3.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle3.Renderer = TextCellType3
        NamedStyle3.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle3.VisualStyles = FarPoint.Win.VisualStyles.Off
        NamedStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle4.Border = BevelBorder4
        NamedStyle4.CellType = TextCellType4
        NamedStyle4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        NamedStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle4.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle4.Locked = False
        NamedStyle4.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle4.Renderer = TextCellType4
        NamedStyle4.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle5.BackColor = System.Drawing.SystemColors.Window
        NamedStyle5.CellType = GeneralCellType1
        NamedStyle5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        NamedStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        NamedStyle5.Locked = False
        NamedStyle5.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle5.Renderer = GeneralCellType1
        Me.PeacePanalSeach.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle1, NamedStyle2, NamedStyle3, NamedStyle4, NamedStyle5})
        Me.PeacePanalSeach.ReportName = Nothing
        Me.PeacePanalSeach.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.PeacePanalSeach_Sheet1})
        Me.PeacePanalSeach.Size = New System.Drawing.Size(1279, 666)
        SpreadSkin1.ColumnFooterDefaultStyle = NamedStyle2
        SpreadSkin1.ColumnHeaderDefaultStyle = NamedStyle1
        SpreadSkin1.CornerDefaultStyle = NamedStyle4
        SpreadSkin1.DefaultStyle = NamedStyle5
        SpreadSkin1.FocusRenderer = EnhancedFocusIndicatorRenderer1
        EnhancedInterfaceRenderer1.ScrollBoxBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(221, Byte), Integer))
        EnhancedInterfaceRenderer1.SheetTabLowerActiveColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(244, Byte), Integer))
        EnhancedInterfaceRenderer1.SheetTabLowerNormalColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(249, Byte), Integer))
        EnhancedInterfaceRenderer1.SheetTabUpperActiveColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(244, Byte), Integer))
        EnhancedInterfaceRenderer1.SheetTabUpperNormalColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(249, Byte), Integer))
        EnhancedInterfaceRenderer1.TabStripBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(221, Byte), Integer))
        SpreadSkin1.InterfaceRenderer = EnhancedInterfaceRenderer1
        SpreadSkin1.Name = "Hung123"
        SpreadSkin1.RowHeaderDefaultStyle = NamedStyle3
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
        Me.PeacePanalSeach.Skin = SpreadSkin1
        Me.PeacePanalSeach.SpreadWjob = 0
        Me.PeacePanalSeach.TabIndex = 17
        Me.PeacePanalSeach.TabStop = False
        Me.PeacePanalSeach.VerticalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.PeacePanalSeach.VerticalScrollBar.Name = ""
        EnhancedScrollBarRenderer3.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer3.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.PeacePanalSeach.VerticalScrollBar.Renderer = EnhancedScrollBarRenderer3
        Me.PeacePanalSeach.VerticalScrollBar.TabIndex = 1
        PeacePanalSeach_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        PeacePanalSeach_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        PeacePanalSeach_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        PeacePanalSeach_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        PeacePanalSeach_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(Global.Microsoft.VisualBasic.ChrW(61)), FarPoint.Win.Spread.SpreadActions.StartEditingFormula)
        PeacePanalSeach_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.C, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCopy)
        PeacePanalSeach_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.V, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardPasteAll)
        PeacePanalSeach_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.X, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCut)
        PeacePanalSeach_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Insert, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCopy)
        PeacePanalSeach_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Delete, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCut)
        PeacePanalSeach_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Insert, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardPasteAll)
        PeacePanalSeach_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F4, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ShowSubEditor)
        PeacePanalSeach_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Space, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.SelectRow)
        PeacePanalSeach_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Z, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Undo)
        PeacePanalSeach_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Y, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Redo)
        Me.PeacePanalSeach.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.Normal, PeacePanalSeach_InputMapWhenFocusedNormal)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnVisual)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnVisual)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousRow)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextRow)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousColumnVisual)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextColumnVisual)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnVisual)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnVisual)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousRow)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextRow)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousColumnVisual)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextColumnVisual)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfRows)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfRows)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfColumns)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfColumns)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousPageOfRows)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextPageOfRows)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousPageOfColumns)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextPageOfColumns)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToFirstColumn)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToLastColumn)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToFirstCell)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToLastCell)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToFirstColumn)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToLastColumn)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToFirstCell)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToLastCell)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Space, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.SelectColumn)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Space, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.SelectSheet)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Escape, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.CancelEditing)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Tab, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Tab, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnWrap)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ClearCell)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F3, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.DateTimeNow)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F4, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ShowSubEditor)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        Me.PeacePanalSeach.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused, FarPoint.Win.Spread.OperationMode.Normal, PeacePanalSeach_InputMapWhenAncestorOfFocusedNormal)
        '
        'PeacePanalSeach_Sheet1
        '
        Me.PeacePanalSeach_Sheet1.Reset()
        Me.PeacePanalSeach_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.PeacePanalSeach_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.PeacePanalSeach_Sheet1.ActiveSkin = New FarPoint.Win.Spread.SheetSkin("KhanhHung1", System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer)), FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer)), System.Drawing.Color.White, System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.White, System.Drawing.SystemColors.ButtonFace, False, False, False, True, True, True, False, True, "RowHeaderDefault", "RowHeaderDefault", "RowHeaderDefault", "DataAreaDefault", "RowHeaderDefault")
        Me.PeacePanalSeach_Sheet1.ColumnFooter.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.PeacePanalSeach_Sheet1.ColumnFooter.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.PeacePanalSeach_Sheet1.ColumnFooter.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeacePanalSeach_Sheet1.ColumnFooter.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.PeacePanalSeach_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.PeacePanalSeach_Sheet1.ColumnFooter.DefaultStyle.Parent = "RowHeaderDefault"
        Me.PeacePanalSeach_Sheet1.ColumnFooter.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.PeacePanalSeach_Sheet1.ColumnFooter.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.PeacePanalSeach_Sheet1.ColumnFooterSheetCornerStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.PeacePanalSeach_Sheet1.ColumnFooterSheetCornerStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PeacePanalSeach_Sheet1.ColumnFooterSheetCornerStyle.ForeColor = System.Drawing.Color.White
        Me.PeacePanalSeach_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.PeacePanalSeach_Sheet1.ColumnFooterSheetCornerStyle.Parent = "RowHeaderDefault"
        Me.PeacePanalSeach_Sheet1.ColumnFooterSheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.PeacePanalSeach_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.PeacePanalSeach_Sheet1.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        TextCellType5.WordWrap = True
        Me.PeacePanalSeach_Sheet1.ColumnHeader.DefaultStyle.CellType = TextCellType5
        Me.PeacePanalSeach_Sheet1.ColumnHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeacePanalSeach_Sheet1.ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.PeacePanalSeach_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.PeacePanalSeach_Sheet1.ColumnHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.PeacePanalSeach_Sheet1.ColumnHeader.DefaultStyle.Renderer = TextCellType5
        Me.PeacePanalSeach_Sheet1.ColumnHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.PeacePanalSeach_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.PeacePanalSeach_Sheet1.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeacePanalSeach_Sheet1.DefaultStyle.ForeColor = System.Drawing.Color.Black
        Me.PeacePanalSeach_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.PeacePanalSeach_Sheet1.DefaultStyle.Parent = "DataAreaDefault"
        Me.PeacePanalSeach_Sheet1.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.PeacePanalSeach_Sheet1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.PeacePanalSeach_Sheet1.FilterBar.DefaultStyle.Parent = "FilterBarDefaultEnhanced"
        Me.PeacePanalSeach_Sheet1.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.PeacePanalSeach_Sheet1.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.PeacePanalSeach_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.PeacePanalSeach_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.PeacePanalSeach_Sheet1.RowHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.PeacePanalSeach_Sheet1.RowHeader.DefaultStyle.CellType = TextCellType5
        Me.PeacePanalSeach_Sheet1.RowHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeacePanalSeach_Sheet1.RowHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.PeacePanalSeach_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.PeacePanalSeach_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.PeacePanalSeach_Sheet1.RowHeader.DefaultStyle.Renderer = TextCellType5
        Me.PeacePanalSeach_Sheet1.RowHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.PeacePanalSeach_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.PeacePanalSeach_Sheet1.Rows.Default.Height = 22.0!
        Me.PeacePanalSeach_Sheet1.SelectionBackColor = System.Drawing.Color.Aquamarine
        Me.PeacePanalSeach_Sheet1.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.SelectionColors
        Me.PeacePanalSeach_Sheet1.SheetCornerStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.PeacePanalSeach_Sheet1.SheetCornerStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeacePanalSeach_Sheet1.SheetCornerStyle.ForeColor = System.Drawing.Color.White
        Me.PeacePanalSeach_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.PeacePanalSeach_Sheet1.SheetCornerStyle.Parent = "RowHeaderDefault"
        Me.PeacePanalSeach_Sheet1.SheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.PeacePanalSeach_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'PeacePanel1
        '
        Me.PeacePanel1.Code = ""
        Me.PeacePanel1.Controls.Add(Me.Panel2)
        Me.PeacePanel1.Data = ""
        Me.PeacePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeacePanel1.Location = New System.Drawing.Point(4, 4)
        Me.PeacePanel1.Name = "PeacePanel1"
        Me.PeacePanel1.Size = New System.Drawing.Size(1279, 29)
        Me.PeacePanel1.TabIndex = 15
        Me.PeacePanel1.Tag = ""
        '
        'Panel2
        '
        Me.Panel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Panel2.ColumnCount = 5
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.Panel2.Controls.Add(Me.txt_ColorCode, 0, 0)
        Me.Panel2.Controls.Add(Me.txt_SizeSpecifize, 0, 0)
        Me.Panel2.Controls.Add(Me.chk_FSEL, 0, 0)
        Me.Panel2.Controls.Add(Me.cmd_SEARCH, 4, 0)
        Me.Panel2.Controls.Add(Me.PeacePanel6, 2, 0)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RowCount = 1
        Me.Panel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel2.Size = New System.Drawing.Size(1275, 25)
        Me.Panel2.TabIndex = 17
        '
        'txt_ColorCode
        '
        Me.txt_ColorCode.BackYesno = False
        Me.txt_ColorCode.ButtonTitle = Nothing
        Me.txt_ColorCode.Code = ""
        Me.txt_ColorCode.Data = ""
        Me.txt_ColorCode.DataDecimal = 0
        Me.txt_ColorCode.DataLen = 0
        Me.txt_ColorCode.DataValue = 0
        Me.txt_ColorCode.Enabled = False
        Me.txt_ColorCode.FormatDecimal = 0
        Me.txt_ColorCode.FormatValue = False
        Me.txt_ColorCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ColorCode.LableEnabled = True
        Me.txt_ColorCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ColorCode.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ColorCode.LableTitle = "Color Code"
        Me.txt_ColorCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_ColorCode.Location = New System.Drawing.Point(327, 2)
        Me.txt_ColorCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ColorCode.Name = "txt_ColorCode"
        Me.txt_ColorCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ColorCode.Size = New System.Drawing.Size(238, 21)
        Me.txt_ColorCode.TabIndex = 267
        Me.txt_ColorCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ColorCode.TextBoxAutoComplete = False
        Me.txt_ColorCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ColorCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_ColorCode.TextEnabled = True
        Me.txt_ColorCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ColorCode.TextMaxLength = 32767
        Me.txt_ColorCode.TextMultiLine = False
        Me.txt_ColorCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ColorCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ColorCode.UseSendTab = True
        '
        'txt_SizeSpecifize
        '
        Me.txt_SizeSpecifize.BackYesno = False
        Me.txt_SizeSpecifize.ButtonTitle = Nothing
        Me.txt_SizeSpecifize.Code = ""
        Me.txt_SizeSpecifize.Data = ""
        Me.txt_SizeSpecifize.DataDecimal = 0
        Me.txt_SizeSpecifize.DataLen = 0
        Me.txt_SizeSpecifize.DataValue = 0
        Me.txt_SizeSpecifize.FormatDecimal = 0
        Me.txt_SizeSpecifize.FormatValue = False
        Me.txt_SizeSpecifize.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_SizeSpecifize.LableEnabled = True
        Me.txt_SizeSpecifize.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_SizeSpecifize.LableForeColor = System.Drawing.Color.Empty
        Me.txt_SizeSpecifize.LableTitle = "Size "
        Me.txt_SizeSpecifize.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_SizeSpecifize.Location = New System.Drawing.Point(126, 2)
        Me.txt_SizeSpecifize.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_SizeSpecifize.Name = "txt_SizeSpecifize"
        Me.txt_SizeSpecifize.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_SizeSpecifize.Size = New System.Drawing.Size(198, 21)
        Me.txt_SizeSpecifize.TabIndex = 266
        Me.txt_SizeSpecifize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_SizeSpecifize.TextBoxAutoComplete = False
        Me.txt_SizeSpecifize.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_SizeSpecifize.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_SizeSpecifize.TextEnabled = True
        Me.txt_SizeSpecifize.TextForeColor = System.Drawing.Color.Empty
        Me.txt_SizeSpecifize.TextMaxLength = 32767
        Me.txt_SizeSpecifize.TextMultiLine = False
        Me.txt_SizeSpecifize.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_SizeSpecifize.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_SizeSpecifize.UseSendTab = True
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
        Me.chk_FSEL.Size = New System.Drawing.Size(121, 21)
        Me.chk_FSEL.TabIndex = 265
        Me.chk_FSEL.Text = "Open"
        Me.chk_FSEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk_FSEL.UseVisualStyleBackColor = False
        '
        'cmd_SEARCH
        '
        Me.cmd_SEARCH.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_SEARCH.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.cmd_SEARCH.Appearance.Options.UseFont = True
        Me.cmd_SEARCH.Appearance.Options.UseForeColor = True
        Me.cmd_SEARCH.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_SEARCH.ButtonTitle = Nothing
        Me.cmd_SEARCH.Code = ""
        Me.cmd_SEARCH.Data = ""
        Me.cmd_SEARCH.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmd_SEARCH.Image = Global.PSMGlobal.My.Resources.Resources.find_f
        Me.cmd_SEARCH.ImageAlign = 16
        Me.cmd_SEARCH.Location = New System.Drawing.Point(1125, 2)
        Me.cmd_SEARCH.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_SEARCH.Name = "cmd_SEARCH"
        Me.cmd_SEARCH.Size = New System.Drawing.Size(148, 21)
        Me.cmd_SEARCH.TabIndex = 7
        Me.cmd_SEARCH.TabStop = False
        Me.cmd_SEARCH.Tag = ""
        Me.cmd_SEARCH.Text = "   Search(&S)"
        Me.cmd_SEARCH.UseVisualStyleBackColor = False
        '
        'PeacePanel6
        '
        Me.PeacePanel6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel6.Code = ""
        Me.PeacePanel6.Controls.Add(Me.opt_CheckRelationType1)
        Me.PeacePanel6.Controls.Add(Me.opt_CheckRelationType0)
        Me.PeacePanel6.Controls.Add(Me.lbla_use)
        Me.PeacePanel6.Data = ""
        Me.PeacePanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeacePanel6.Location = New System.Drawing.Point(571, 2)
        Me.PeacePanel6.Margin = New System.Windows.Forms.Padding(1)
        Me.PeacePanel6.Name = "PeacePanel6"
        Me.PeacePanel6.Size = New System.Drawing.Size(551, 21)
        Me.PeacePanel6.TabIndex = 264
        Me.PeacePanel6.Tag = ""
        '
        'opt_CheckRelationType1
        '
        Me.opt_CheckRelationType1.AutoSize = True
        Me.opt_CheckRelationType1.ButtonTitle = Nothing
        Me.opt_CheckRelationType1.Checked = True
        Me.opt_CheckRelationType1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.opt_CheckRelationType1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.opt_CheckRelationType1.ForeColor = System.Drawing.Color.Black
        Me.opt_CheckRelationType1.Location = New System.Drawing.Point(159, 2)
        Me.opt_CheckRelationType1.Name = "opt_CheckRelationType1"
        Me.opt_CheckRelationType1.Size = New System.Drawing.Size(43, 18)
        Me.opt_CheckRelationType1.TabIndex = 3
        Me.opt_CheckRelationType1.Text = "NO"
        Me.opt_CheckRelationType1.UseVisualStyleBackColor = True
        '
        'opt_CheckRelationType0
        '
        Me.opt_CheckRelationType0.AutoSize = True
        Me.opt_CheckRelationType0.ButtonTitle = Nothing
        Me.opt_CheckRelationType0.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.opt_CheckRelationType0.ForeColor = System.Drawing.Color.Black
        Me.opt_CheckRelationType0.Location = New System.Drawing.Point(103, 2)
        Me.opt_CheckRelationType0.Name = "opt_CheckRelationType0"
        Me.opt_CheckRelationType0.Size = New System.Drawing.Size(48, 18)
        Me.opt_CheckRelationType0.TabIndex = 2
        Me.opt_CheckRelationType0.Text = "YES"
        Me.opt_CheckRelationType0.UseVisualStyleBackColor = True
        '
        'lbla_use
        '
        Me.lbla_use.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lbla_use.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbla_use.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbla_use.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lbla_use.ButtonTitle = Nothing
        Me.lbla_use.Code = ""
        Me.lbla_use.Data = ""
        Me.lbla_use.DTDec = 0
        Me.lbla_use.DTLen = 0
        Me.lbla_use.DTValue = 0
        Me.lbla_use.Location = New System.Drawing.Point(20, 1)
        Me.lbla_use.Margin = New System.Windows.Forms.Padding(1)
        Me.lbla_use.Name = "lbla_use"
        Me.lbla_use.NoClear = False
        Me.lbla_use.Size = New System.Drawing.Size(72, 20)
        Me.lbla_use.TabIndex = 265
        Me.lbla_use.Tag = ""
        Me.lbla_use.Text = "Use"
        Me.lbla_use.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'PeaceRadioButton5
        '
        Me.PeaceRadioButton5.AutoSize = True
        Me.PeaceRadioButton5.ButtonTitle = Nothing
        Me.PeaceRadioButton5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceRadioButton5.Location = New System.Drawing.Point(387, 4)
        Me.PeaceRadioButton5.Name = "PeaceRadioButton5"
        Me.PeaceRadioButton5.Size = New System.Drawing.Size(64, 17)
        Me.PeaceRadioButton5.TabIndex = 7
        Me.PeaceRadioButton5.Text = "Return"
        Me.PeaceRadioButton5.UseVisualStyleBackColor = True
        '
        'chk_CheckDate
        '
        Me.chk_CheckDate.AutoSize = True
        Me.chk_CheckDate.ButtonTitle = Nothing
        Me.chk_CheckDate.Checked = True
        Me.chk_CheckDate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_CheckDate.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_CheckDate.Location = New System.Drawing.Point(22, 38)
        Me.chk_CheckDate.Name = "chk_CheckDate"
        Me.chk_CheckDate.Size = New System.Drawing.Size(140, 18)
        Me.chk_CheckDate.TabIndex = 261
        Me.chk_CheckDate.Text = "Check Date Approval"
        Me.chk_CheckDate.UseVisualStyleBackColor = True
        '
        'ssp_WHERE
        '
        Me.ssp_WHERE.Code = ""
        Me.ssp_WHERE.Controls.Add(Me.txt_ShoesCode)
        Me.ssp_WHERE.Controls.Add(Me.chk_CheckDate)
        Me.ssp_WHERE.Controls.Add(Me.SdateEdate)
        Me.ssp_WHERE.Controls.Add(Me.txt_CustomerCode)
        Me.ssp_WHERE.Controls.Add(Me.txt_cdSeason)
        Me.ssp_WHERE.Controls.Add(Me.txt_Line)
        Me.ssp_WHERE.Controls.Add(Me.txt_Article)
        Me.ssp_WHERE.Controls.Add(Me.txt_Customer)
        Me.ssp_WHERE.Data = ""
        Me.ssp_WHERE.Location = New System.Drawing.Point(41, 64)
        Me.ssp_WHERE.Name = "ssp_WHERE"
        Me.ssp_WHERE.Size = New System.Drawing.Size(300, 222)
        Me.ssp_WHERE.TabIndex = 262
        Me.ssp_WHERE.Tag = ""
        Me.ssp_WHERE.Visible = False
        '
        'txt_ShoesCode
        '
        Me.txt_ShoesCode.BackYesno = False
        Me.txt_ShoesCode.ButtonTitle = Nothing
        Me.txt_ShoesCode.Code = ""
        Me.txt_ShoesCode.Data = ""
        Me.txt_ShoesCode.DataDecimal = 0
        Me.txt_ShoesCode.DataLen = 0
        Me.txt_ShoesCode.DataValue = 0
        Me.txt_ShoesCode.Enabled = False
        Me.txt_ShoesCode.FormatDecimal = 0
        Me.txt_ShoesCode.FormatValue = False
        Me.txt_ShoesCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ShoesCode.LableEnabled = True
        Me.txt_ShoesCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ShoesCode.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ShoesCode.LableTitle = "ITEM CODE"
        Me.txt_ShoesCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_ShoesCode.Location = New System.Drawing.Point(22, 184)
        Me.txt_ShoesCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ShoesCode.Name = "txt_ShoesCode"
        Me.txt_ShoesCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ShoesCode.Size = New System.Drawing.Size(238, 24)
        Me.txt_ShoesCode.TabIndex = 273
        Me.txt_ShoesCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ShoesCode.TextBoxAutoComplete = False
        Me.txt_ShoesCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ShoesCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_ShoesCode.TextEnabled = True
        Me.txt_ShoesCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ShoesCode.TextMaxLength = 32767
        Me.txt_ShoesCode.TextMultiLine = False
        Me.txt_ShoesCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ShoesCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ShoesCode.UseSendTab = True
        '
        'SdateEdate
        '
        Me.SdateEdate.ButtonTitle = "Period"
        Me.SdateEdate.Location = New System.Drawing.Point(22, 13)
        Me.SdateEdate.Margin = New System.Windows.Forms.Padding(1)
        Me.SdateEdate.Name = "SdateEdate"
        Me.SdateEdate.Size = New System.Drawing.Size(238, 21)
        Me.SdateEdate.TabIndex = 114
        Me.SdateEdate.text1 = ""
        Me.SdateEdate.text2 = ""
        Me.SdateEdate.TextBoxFont = New System.Drawing.Font("Tahoma", 7.0!)
        '
        'txt_CustomerCode
        '
        Me.txt_CustomerCode.BackYesno = False
        Me.txt_CustomerCode.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_CustomerCode.ButtonEnabled = True
        Me.txt_CustomerCode.ButtonFont = Nothing
        Me.txt_CustomerCode.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_CustomerCode.ButtonName = "Const_cdCustomer"
        Me.txt_CustomerCode.ButtonTitle = "Customer"
        Me.txt_CustomerCode.Code = ""
        Me.txt_CustomerCode.Data = ""
        Me.txt_CustomerCode.DataDecimal = 0
        Me.txt_CustomerCode.DataLen = 0
        Me.txt_CustomerCode.DataValue = 1
        Me.txt_CustomerCode.Enabled = False
        Me.txt_CustomerCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_CustomerCode.Location = New System.Drawing.Point(22, 83)
        Me.txt_CustomerCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_CustomerCode.Name = "txt_CustomerCode"
        Me.txt_CustomerCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CustomerCode.Size = New System.Drawing.Size(238, 21)
        Me.txt_CustomerCode.TabIndex = 272
        Me.txt_CustomerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_CustomerCode.TextBoxAutoComplete = True
        Me.txt_CustomerCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_CustomerCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_CustomerCode.TextEnabled = True
        Me.txt_CustomerCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_CustomerCode.TextMaxLength = 32767
        Me.txt_CustomerCode.TextMultiLine = False
        Me.txt_CustomerCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CustomerCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_CustomerCode.UseSendTab = True
        '
        'txt_cdSeason
        '
        Me.txt_cdSeason.BackYesno = False
        Me.txt_cdSeason.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSeason.ButtonEnabled = True
        Me.txt_cdSeason.ButtonFont = Nothing
        Me.txt_cdSeason.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSeason.ButtonName = "Const_cdSeason"
        Me.txt_cdSeason.ButtonTitle = "Season"
        Me.txt_cdSeason.Code = ""
        Me.txt_cdSeason.Data = ""
        Me.txt_cdSeason.DataDecimal = 0
        Me.txt_cdSeason.DataLen = 0
        Me.txt_cdSeason.DataValue = 1
        Me.txt_cdSeason.Enabled = False
        Me.txt_cdSeason.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdSeason.Location = New System.Drawing.Point(22, 60)
        Me.txt_cdSeason.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSeason.Name = "txt_cdSeason"
        Me.txt_cdSeason.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSeason.Size = New System.Drawing.Size(238, 21)
        Me.txt_cdSeason.TabIndex = 271
        Me.txt_cdSeason.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSeason.TextBoxAutoComplete = True
        Me.txt_cdSeason.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdSeason.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdSeason.TextEnabled = True
        Me.txt_cdSeason.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdSeason.TextMaxLength = 32767
        Me.txt_cdSeason.TextMultiLine = False
        Me.txt_cdSeason.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdSeason.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdSeason.UseSendTab = True
        '
        'txt_Line
        '
        Me.txt_Line.BackYesno = False
        Me.txt_Line.ButtonTitle = Nothing
        Me.txt_Line.Code = ""
        Me.txt_Line.Data = ""
        Me.txt_Line.DataDecimal = 0
        Me.txt_Line.DataLen = 0
        Me.txt_Line.DataValue = 0
        Me.txt_Line.Enabled = False
        Me.txt_Line.FormatDecimal = 0
        Me.txt_Line.FormatValue = False
        Me.txt_Line.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Line.LableEnabled = True
        Me.txt_Line.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Line.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Line.LableTitle = "Line"
        Me.txt_Line.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Line.Location = New System.Drawing.Point(22, 132)
        Me.txt_Line.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Line.Name = "txt_Line"
        Me.txt_Line.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Line.Size = New System.Drawing.Size(238, 24)
        Me.txt_Line.TabIndex = 164
        Me.txt_Line.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Line.TextBoxAutoComplete = False
        Me.txt_Line.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Line.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Line.TextEnabled = True
        Me.txt_Line.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Line.TextMaxLength = 32767
        Me.txt_Line.TextMultiLine = False
        Me.txt_Line.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Line.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Line.UseSendTab = True
        '
        'txt_Article
        '
        Me.txt_Article.BackYesno = False
        Me.txt_Article.ButtonTitle = Nothing
        Me.txt_Article.Code = ""
        Me.txt_Article.Data = ""
        Me.txt_Article.DataDecimal = 0
        Me.txt_Article.DataLen = 0
        Me.txt_Article.DataValue = 0
        Me.txt_Article.Enabled = False
        Me.txt_Article.FormatDecimal = 0
        Me.txt_Article.FormatValue = False
        Me.txt_Article.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Article.LableEnabled = True
        Me.txt_Article.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Article.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Article.LableTitle = "Article"
        Me.txt_Article.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Article.Location = New System.Drawing.Point(22, 158)
        Me.txt_Article.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Article.Name = "txt_Article"
        Me.txt_Article.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Article.Size = New System.Drawing.Size(238, 24)
        Me.txt_Article.TabIndex = 163
        Me.txt_Article.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Article.TextBoxAutoComplete = False
        Me.txt_Article.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Article.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Article.TextEnabled = True
        Me.txt_Article.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Article.TextMaxLength = 32767
        Me.txt_Article.TextMultiLine = False
        Me.txt_Article.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Article.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Article.UseSendTab = True
        '
        'txt_Customer
        '
        Me.txt_Customer.BackYesno = False
        Me.txt_Customer.ButtonTitle = Nothing
        Me.txt_Customer.Code = ""
        Me.txt_Customer.Data = ""
        Me.txt_Customer.DataDecimal = 0
        Me.txt_Customer.DataLen = 0
        Me.txt_Customer.DataValue = 0
        Me.txt_Customer.Enabled = False
        Me.txt_Customer.FormatDecimal = 0
        Me.txt_Customer.FormatValue = False
        Me.txt_Customer.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Customer.LableEnabled = True
        Me.txt_Customer.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Customer.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Customer.LableTitle = "Customer"
        Me.txt_Customer.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Customer.Location = New System.Drawing.Point(22, 106)
        Me.txt_Customer.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Customer.Name = "txt_Customer"
        Me.txt_Customer.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Customer.Size = New System.Drawing.Size(238, 24)
        Me.txt_Customer.TabIndex = 162
        Me.txt_Customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Customer.TextBoxAutoComplete = False
        Me.txt_Customer.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Customer.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Customer.TextEnabled = True
        Me.txt_Customer.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Customer.TextMaxLength = 32767
        Me.txt_Customer.TextMultiLine = False
        Me.txt_Customer.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Customer.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Customer.UseSendTab = True
        '
        'HLP1312L
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1287, 751)
        Me.Controls.Add(Me.ssp_WHERE)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "HLP1312L"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ORDER REQUEST HELP (HLP1312L)"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame4.ResumeLayout(False)
        CType(Me.PeacePanalSeach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeacePanalSeach_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PeacePanel6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel6.ResumeLayout(False)
        Me.PeacePanel6.PerformLayout()
        CType(Me.ssp_WHERE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ssp_WHERE.ResumeLayout(False)
        Me.ssp_WHERE.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Cms_1 As PSMGlobal.PeaceContextMenuStrip
    Friend WithEvents Cms_2 As PSMGlobal.PeaceContextMenuStrip
    Public WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Frame4 As PSMGlobal.PeacePanel
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Public WithEvents PeacePanalSeach As PSMGlobal.PeaceFarpoint
    Friend WithEvents PeacePanalSeach_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents PeacePanel1 As PSMGlobal.PeacePanel
    Public WithEvents Panel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PeaceRadioButton5 As PSMGlobal.PeaceRadioButton
    Public WithEvents cmd_SEARCH As PeaceButton
    Friend WithEvents chk_CheckDate As PSMGlobal.PeaceCheckbox
    Public WithEvents chk_FSEL As PSMGlobal.PeaceCheckbox
    Public WithEvents ssp_WHERE As PSMGlobal.PeacePanel
    Friend WithEvents SdateEdate As PSMGlobal.SelectPeaceCalDou
    Friend WithEvents txt_CustomerCode As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdSeason As PSMGlobal.SelectPeaceHLPButton
    Public WithEvents txt_Line As PSMGlobal.SelectLabelText
    Public WithEvents txt_Article As PSMGlobal.SelectLabelText
    Public WithEvents txt_Customer As PSMGlobal.SelectLabelText
    Public WithEvents txt_ShoesCode As PSMGlobal.SelectLabelText
    Public WithEvents txt_SizeSpecifize As PSMGlobal.SelectLabelText
    Friend WithEvents PeacePanel6 As PSMGlobal.PeacePanel
    Public WithEvents opt_CheckRelationType1 As PSMGlobal.PeaceCheckbox
    Public WithEvents opt_CheckRelationType0 As PSMGlobal.PeaceCheckbox
    Friend WithEvents lbla_use As PSMGlobal.PeaceLabel
    Public WithEvents txt_ColorCode As PSMGlobal.SelectLabelText



End Class
