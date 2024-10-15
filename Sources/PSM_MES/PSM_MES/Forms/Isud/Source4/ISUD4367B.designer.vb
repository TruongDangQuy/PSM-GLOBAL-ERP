<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD4367B
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
        Dim EnhancedFocusIndicatorRenderer1 As FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer = New FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer()
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
        Dim EnhancedInterfaceRenderer1 As FarPoint.Win.Spread.EnhancedInterfaceRenderer = New FarPoint.Win.Spread.EnhancedInterfaceRenderer()
        Dim EnhancedScrollBarRenderer2 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim EnhancedScrollBarRenderer3 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim vS1_InputMapWhenFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim vS1_InputMapWhenAncestorOfFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim TextCellType5 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD4367B))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Bk_1 = New System.ComponentModel.BackgroundWorker()
        Me.PeaceButton2 = New PSMGlobal.PeaceButton(Me.components)
        Me.PeaceMaskedtextbox1 = New PSMGlobal.PeaceMaskedtextbox(Me.components)
        Me.PeaceSplitContainer1 = New PSMGlobal.PeaceSplitContainer(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.vS1 = New PSMGlobal.PeaceFarpoint()
        Me.vS1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.PeacePanel4 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_CANCEL = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_DEL = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.FlowLayoutPanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_MaterialName = New System.Windows.Forms.TextBox()
        Me.PeaceLabel1 = New PSMGlobal.PeaceLabel(Me.components)
        Me.lbt_MaterialName = New PSMGlobal.PeaceLabel(Me.components)
        Me.txt_Mess = New System.Windows.Forms.TextBox()
        Me.txt_Barcode_Box = New PSMGlobal.SelectLabelText()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Pan_Process = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_cdFactory = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdMainProcess = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_InchargeProdution = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdLineProd = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_DateProd = New PSMGlobal.SelectLabelText()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        vS1_InputMapWhenFocusedNormal = New FarPoint.Win.Spread.InputMap()
        vS1_InputMapWhenFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        vS1_InputMapWhenAncestorOfFocusedNormal = New FarPoint.Win.Spread.InputMap()
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        CType(Me.PeaceSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeaceSplitContainer1.Panel1.SuspendLayout()
        Me.PeaceSplitContainer1.Panel2.SuspendLayout()
        Me.PeaceSplitContainer1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.vS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vS1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeacePanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel4.SuspendLayout()
        CType(Me.FlowLayoutPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Pan_Process, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pan_Process.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bk_1
        '
        Me.Bk_1.WorkerReportsProgress = True
        Me.Bk_1.WorkerSupportsCancellation = True
        '
        'PeaceButton2
        '
        Me.PeaceButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceButton2.Appearance.Options.UseFont = True
        Me.PeaceButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PeaceButton2.ButtonTitle = Nothing
        Me.PeaceButton2.Code = Nothing
        Me.PeaceButton2.Data = Nothing
        Me.PeaceButton2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceButton2.ImageAlign = 0
        Me.PeaceButton2.Location = New System.Drawing.Point(0, 0)
        Me.PeaceButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.PeaceButton2.Name = "PeaceButton2"
        Me.PeaceButton2.Size = New System.Drawing.Size(137, 27)
        Me.PeaceButton2.TabIndex = 2
        Me.PeaceButton2.TabStop = False
        Me.PeaceButton2.Text = "Date Exchange"
        Me.PeaceButton2.UseVisualStyleBackColor = False
        '
        'PeaceMaskedtextbox1
        '
        Me.PeaceMaskedtextbox1.BackColor = System.Drawing.Color.White
        Me.PeaceMaskedtextbox1.Code = Nothing
        Me.PeaceMaskedtextbox1.Data = "2015/01/01"
        Me.PeaceMaskedtextbox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceMaskedtextbox1.DTDec = 0
        Me.PeaceMaskedtextbox1.DTLen = 0
        Me.PeaceMaskedtextbox1.DTValue = 0
        Me.PeaceMaskedtextbox1.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.PeaceMaskedtextbox1.Location = New System.Drawing.Point(137, 0)
        Me.PeaceMaskedtextbox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PeaceMaskedtextbox1.Mask = "0000/00/00"
        Me.PeaceMaskedtextbox1.Name = "PeaceMaskedtextbox1"
        Me.PeaceMaskedtextbox1.NoClear = False
        Me.PeaceMaskedtextbox1.PromptChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.PeaceMaskedtextbox1.Size = New System.Drawing.Size(208, 25)
        Me.PeaceMaskedtextbox1.TabIndex = 3
        Me.PeaceMaskedtextbox1.Text = "20150101"
        Me.PeaceMaskedtextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PeaceSplitContainer1
        '
        Me.PeaceSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceSplitContainer1.Location = New System.Drawing.Point(3, 115)
        Me.PeaceSplitContainer1.Name = "PeaceSplitContainer1"
        '
        'PeaceSplitContainer1.Panel1
        '
        Me.PeaceSplitContainer1.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'PeaceSplitContainer1.Panel2
        '
        Me.PeaceSplitContainer1.Panel2.Controls.Add(Me.PeacePanel4)
        Me.PeaceSplitContainer1.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.PeaceSplitContainer1.Size = New System.Drawing.Size(1216, 453)
        Me.PeaceSplitContainer1.SplitterDistance = 723
        Me.PeaceSplitContainer1.TabIndex = 4
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.vS1)
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Size = New System.Drawing.Size(723, 453)
        Me.SplitContainer1.SplitterDistance = 698
        Me.SplitContainer1.TabIndex = 2
        '
        'vS1
        '
        Me.vS1.AccessibleDescription = ""
        Me.vS1.AllowDragFill = True
        Me.vS1.ClipboardOptions = FarPoint.Win.Spread.ClipboardOptions.NoHeaders
        Me.vS1.CopyPasteChk = True
        Me.vS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vS1.FocusRenderer = EnhancedFocusIndicatorRenderer1
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
        Me.vS1.HorizontalScrollBar.TabIndex = 30
        Me.vS1.InsChk = True
        Me.vS1.Location = New System.Drawing.Point(0, 0)
        Me.vS1.Name = "vS1"
        NamedStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle1.Border = BevelBorder1
        NamedStyle1.CanFocus = False
        TextCellType1.WordWrap = True
        NamedStyle1.CellType = TextCellType1
        NamedStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        NamedStyle1.ForeColor = System.Drawing.Color.White
        NamedStyle1.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle1.Locked = False
        NamedStyle1.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle1.Renderer = TextCellType1
        NamedStyle1.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle1.VisualStyles = FarPoint.Win.VisualStyles.Off
        NamedStyle2.Border = BevelBorder2
        NamedStyle2.CellType = TextCellType2
        NamedStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        NamedStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        NamedStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        NamedStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle4.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle4.Locked = False
        NamedStyle4.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle4.Renderer = TextCellType4
        NamedStyle4.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle5.BackColor = System.Drawing.SystemColors.Window
        NamedStyle5.CellType = GeneralCellType1
        NamedStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        NamedStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        NamedStyle5.Locked = False
        NamedStyle5.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle5.Renderer = GeneralCellType1
        Me.vS1.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle1, NamedStyle2, NamedStyle3, NamedStyle4, NamedStyle5})
        Me.vS1.ReportName = Nothing
        Me.vS1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.vS1_Sheet1})
        Me.vS1.Size = New System.Drawing.Size(723, 453)
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
        SpreadSkin1.Name = "KhanhHung1"
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
        Me.vS1.Skin = SpreadSkin1
        Me.vS1.SpreadWjob = 0
        Me.vS1.TabIndex = 1
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
        Me.vS1.VerticalScrollBar.TabIndex = 31
        vS1_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        vS1_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(Global.Microsoft.VisualBasic.ChrW(61)), FarPoint.Win.Spread.SpreadActions.StartEditingFormula)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.C, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCopy)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.V, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardPasteAll)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.X, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCut)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Insert, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCopy)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Delete, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCut)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Insert, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardPasteAll)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F4, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ShowSubEditor)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Space, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.SelectRow)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Z, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Undo)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Y, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Redo)
        Me.vS1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.Normal, vS1_InputMapWhenFocusedNormal)
        vS1_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        vS1_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnVisual)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnVisual)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousRow)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextRow)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousColumnVisual)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextColumnVisual)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnVisual)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnVisual)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousRow)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextRow)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousColumnVisual)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextColumnVisual)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfRows)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfRows)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfColumns)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfColumns)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousPageOfRows)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextPageOfRows)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousPageOfColumns)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextPageOfColumns)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToFirstColumn)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToLastColumn)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToFirstCell)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToLastCell)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToFirstColumn)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToLastColumn)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToFirstCell)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToLastCell)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Space, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.SelectColumn)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Space, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.SelectSheet)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Escape, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.CancelEditing)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Tab, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Tab, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnWrap)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ClearCell)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F3, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.DateTimeNow)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F4, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ShowSubEditor)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        Me.vS1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused, FarPoint.Win.Spread.OperationMode.Normal, vS1_InputMapWhenAncestorOfFocusedNormal)
        '
        'vS1_Sheet1
        '
        Me.vS1_Sheet1.Reset()
        Me.vS1_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.vS1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.vS1_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.ColumnFooter.DefaultStyle.Parent = "Style3"
        TextCellType5.WordWrap = True
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.CellType = TextCellType5
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.Parent = "Style2"
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.Renderer = TextCellType5
        Me.vS1_Sheet1.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vS1_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.DefaultStyle.Parent = "Style5"
        Me.vS1_Sheet1.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.vS1_Sheet1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.GrayAreaBackColor = System.Drawing.Color.White
        Me.vS1_Sheet1.RowHeader.DefaultStyle.CellType = TextCellType5
        Me.vS1_Sheet1.RowHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vS1_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.RowHeader.DefaultStyle.Parent = "Style1"
        Me.vS1_Sheet1.RowHeader.DefaultStyle.Renderer = TextCellType5
        Me.vS1_Sheet1.Rows.Default.Height = 22.0!
        Me.vS1_Sheet1.SelectionBackColor = System.Drawing.Color.Aquamarine
        Me.vS1_Sheet1.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.SelectionColors
        Me.vS1_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.SheetCornerStyle.Parent = "Style4"
        Me.vS1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'PeacePanel4
        '
        Me.PeacePanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PeacePanel4.Code = ""
        Me.PeacePanel4.Controls.Add(Me.cmd_CANCEL)
        Me.PeacePanel4.Controls.Add(Me.cmd_DEL)
        Me.PeacePanel4.Controls.Add(Me.cmd_OK)
        Me.PeacePanel4.Data = ""
        Me.PeacePanel4.Location = New System.Drawing.Point(9, 374)
        Me.PeacePanel4.Name = "PeacePanel4"
        Me.PeacePanel4.Size = New System.Drawing.Size(473, 70)
        Me.PeacePanel4.TabIndex = 196
        Me.PeacePanel4.Tag = ""
        '
        'cmd_CANCEL
        '
        Me.cmd_CANCEL.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmd_CANCEL.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_CANCEL.Appearance.Options.UseFont = True
        Me.cmd_CANCEL.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmd_CANCEL.ButtonTitle = Nothing
        Me.cmd_CANCEL.Code = Nothing
        Me.cmd_CANCEL.Data = Nothing
        Me.cmd_CANCEL.Image = CType(resources.GetObject("cmd_CANCEL.Image"), System.Drawing.Image)
        Me.cmd_CANCEL.ImageAlign = 16
        Me.cmd_CANCEL.Location = New System.Drawing.Point(327, 2)
        Me.cmd_CANCEL.Margin = New System.Windows.Forms.Padding(0)
        Me.cmd_CANCEL.Name = "cmd_CANCEL"
        Me.cmd_CANCEL.Size = New System.Drawing.Size(135, 64)
        Me.cmd_CANCEL.TabIndex = 199
        Me.cmd_CANCEL.TabStop = False
        Me.cmd_CANCEL.Text = "CLOSE"
        Me.cmd_CANCEL.UseVisualStyleBackColor = False
        '
        'cmd_DEL
        '
        Me.cmd_DEL.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmd_DEL.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_DEL.Appearance.Options.UseFont = True
        Me.cmd_DEL.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmd_DEL.ButtonTitle = Nothing
        Me.cmd_DEL.Code = Nothing
        Me.cmd_DEL.Data = Nothing
        Me.cmd_DEL.Image = CType(resources.GetObject("cmd_DEL.Image"), System.Drawing.Image)
        Me.cmd_DEL.ImageAlign = 16
        Me.cmd_DEL.Location = New System.Drawing.Point(14, 3)
        Me.cmd_DEL.Margin = New System.Windows.Forms.Padding(0)
        Me.cmd_DEL.Name = "cmd_DEL"
        Me.cmd_DEL.Size = New System.Drawing.Size(135, 64)
        Me.cmd_DEL.TabIndex = 198
        Me.cmd_DEL.TabStop = False
        Me.cmd_DEL.Text = "DELETE"
        Me.cmd_DEL.UseVisualStyleBackColor = False
        '
        'cmd_OK
        '
        Me.cmd_OK.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmd_OK.ButtonTitle = Nothing
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Enabled = False
        Me.cmd_OK.Image = CType(resources.GetObject("cmd_OK.Image"), System.Drawing.Image)
        Me.cmd_OK.ImageAlign = 16
        Me.cmd_OK.Location = New System.Drawing.Point(171, 2)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(135, 64)
        Me.cmd_OK.TabIndex = 197
        Me.cmd_OK.TabStop = False
        Me.cmd_OK.Text = "SAVE"
        Me.cmd_OK.UseVisualStyleBackColor = False
        Me.cmd_OK.Visible = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Code = ""
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_MaterialName)
        Me.FlowLayoutPanel1.Controls.Add(Me.PeaceLabel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.lbt_MaterialName)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Mess)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Barcode_Box)
        Me.FlowLayoutPanel1.Data = ""
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(9, 2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(473, 366)
        Me.FlowLayoutPanel1.TabIndex = 1
        Me.FlowLayoutPanel1.Tag = ""
        '
        'txt_MaterialName
        '
        Me.txt_MaterialName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_MaterialName.BackColor = System.Drawing.SystemColors.Control
        Me.txt_MaterialName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_MaterialName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_MaterialName.Location = New System.Drawing.Point(14, 90)
        Me.txt_MaterialName.Multiline = True
        Me.txt_MaterialName.Name = "txt_MaterialName"
        Me.txt_MaterialName.ReadOnly = True
        Me.txt_MaterialName.Size = New System.Drawing.Size(448, 60)
        Me.txt_MaterialName.TabIndex = 202
        '
        'PeaceLabel1
        '
        Me.PeaceLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PeaceLabel1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeaceLabel1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PeaceLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeaceLabel1.ButtonTitle = Nothing
        Me.PeaceLabel1.Code = ""
        Me.PeaceLabel1.Data = ""
        Me.PeaceLabel1.DTDec = 0
        Me.PeaceLabel1.DTLen = 0
        Me.PeaceLabel1.DTValue = 0
        Me.PeaceLabel1.Location = New System.Drawing.Point(14, 156)
        Me.PeaceLabel1.Name = "PeaceLabel1"
        Me.PeaceLabel1.NoClear = False
        Me.PeaceLabel1.Size = New System.Drawing.Size(448, 25)
        Me.PeaceLabel1.TabIndex = 201
        Me.PeaceLabel1.Tag = ""
        Me.PeaceLabel1.Text = "System Message"
        Me.PeaceLabel1.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'lbt_MaterialName
        '
        Me.lbt_MaterialName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbt_MaterialName.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbt_MaterialName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbt_MaterialName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbt_MaterialName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lbt_MaterialName.ButtonTitle = Nothing
        Me.lbt_MaterialName.Code = ""
        Me.lbt_MaterialName.Data = ""
        Me.lbt_MaterialName.DTDec = 0
        Me.lbt_MaterialName.DTLen = 0
        Me.lbt_MaterialName.DTValue = 0
        Me.lbt_MaterialName.Location = New System.Drawing.Point(14, 65)
        Me.lbt_MaterialName.Name = "lbt_MaterialName"
        Me.lbt_MaterialName.NoClear = False
        Me.lbt_MaterialName.Size = New System.Drawing.Size(448, 25)
        Me.lbt_MaterialName.TabIndex = 200
        Me.lbt_MaterialName.Tag = ""
        Me.lbt_MaterialName.Text = "Material Name"
        Me.lbt_MaterialName.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'txt_Mess
        '
        Me.txt_Mess.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Mess.BackColor = System.Drawing.SystemColors.Control
        Me.txt_Mess.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txt_Mess.ForeColor = System.Drawing.Color.Black
        Me.txt_Mess.Location = New System.Drawing.Point(14, 181)
        Me.txt_Mess.Multiline = True
        Me.txt_Mess.Name = "txt_Mess"
        Me.txt_Mess.ReadOnly = True
        Me.txt_Mess.Size = New System.Drawing.Size(448, 180)
        Me.txt_Mess.TabIndex = 199
        '
        'txt_Barcode_Box
        '
        Me.txt_Barcode_Box.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Barcode_Box.BackYesno = False
        Me.txt_Barcode_Box.ButtonTitle = Nothing
        Me.txt_Barcode_Box.Code = Nothing
        Me.txt_Barcode_Box.Data = "CW19012019"
        Me.txt_Barcode_Box.DataDecimal = 0
        Me.txt_Barcode_Box.DataLen = 0
        Me.txt_Barcode_Box.DataValue = 0
        Me.txt_Barcode_Box.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Barcode_Box.FormatDecimal = 0
        Me.txt_Barcode_Box.FormatValue = False
        Me.txt_Barcode_Box.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_Barcode_Box.LableEnabled = True
        Me.txt_Barcode_Box.LableFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Barcode_Box.LableForeColor = System.Drawing.Color.Black
        Me.txt_Barcode_Box.LableTitle = "BOX #"
        Me.txt_Barcode_Box.Layoutpercent = New Decimal(New Integer() {35, 0, 0, 131072})
        Me.txt_Barcode_Box.Location = New System.Drawing.Point(14, 6)
        Me.txt_Barcode_Box.Margin = New System.Windows.Forms.Padding(1, 1, 100, 1)
        Me.txt_Barcode_Box.Name = "txt_Barcode_Box"
        Me.txt_Barcode_Box.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Barcode_Box.Size = New System.Drawing.Size(448, 55)
        Me.txt_Barcode_Box.TabIndex = 4
        Me.txt_Barcode_Box.Tag = ""
        Me.txt_Barcode_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Barcode_Box.TextBoxAutoComplete = True
        Me.txt_Barcode_Box.TextboxBackColor = System.Drawing.Color.White
        Me.txt_Barcode_Box.TextBoxFont = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Barcode_Box.TextEnabled = True
        Me.txt_Barcode_Box.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Barcode_Box.TextMaxLength = 1000
        Me.txt_Barcode_Box.TextMultiLine = False
        Me.txt_Barcode_Box.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Barcode_Box.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Barcode_Box.UseSendTab = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Pan_Process)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1216, 106)
        Me.Panel1.TabIndex = 3
        '
        'Pan_Process
        '
        Me.Pan_Process.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Pan_Process.Code = ""
        Me.Pan_Process.Controls.Add(Me.txt_cdFactory)
        Me.Pan_Process.Controls.Add(Me.txt_cdMainProcess)
        Me.Pan_Process.Controls.Add(Me.txt_InchargeProdution)
        Me.Pan_Process.Controls.Add(Me.txt_cdLineProd)
        Me.Pan_Process.Controls.Add(Me.txt_DateProd)
        Me.Pan_Process.Data = ""
        Me.Pan_Process.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pan_Process.Location = New System.Drawing.Point(0, 0)
        Me.Pan_Process.Margin = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.Pan_Process.Name = "Pan_Process"
        Me.Pan_Process.Size = New System.Drawing.Size(1216, 106)
        Me.Pan_Process.TabIndex = 0
        Me.Pan_Process.Tag = ""
        '
        'txt_cdFactory
        '
        Me.txt_cdFactory.BackYesno = False
        Me.txt_cdFactory.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdFactory.ButtonEnabled = True
        Me.txt_cdFactory.ButtonFont = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdFactory.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.ButtonName = ""
        Me.txt_cdFactory.ButtonTitle = "Factory"
        Me.txt_cdFactory.Code = ""
        Me.txt_cdFactory.Data = "FACTORY"
        Me.txt_cdFactory.DataDecimal = 1
        Me.txt_cdFactory.DataLen = 1
        Me.txt_cdFactory.DataValue = 1
        Me.txt_cdFactory.Enabled = False
        Me.txt_cdFactory.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdFactory.Layoutpercent = New Decimal(New Integer() {35, 0, 0, 131072})
        Me.txt_cdFactory.Location = New System.Drawing.Point(342, 3)
        Me.txt_cdFactory.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdFactory.Name = "txt_cdFactory"
        Me.txt_cdFactory.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdFactory.Size = New System.Drawing.Size(381, 49)
        Me.txt_cdFactory.TabIndex = 0
        Me.txt_cdFactory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdFactory.TextBoxAutoComplete = False
        Me.txt_cdFactory.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.TextBoxFont = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdFactory.TextEnabled = True
        Me.txt_cdFactory.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.TextMaxLength = 32767
        Me.txt_cdFactory.TextMultiLine = False
        Me.txt_cdFactory.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdFactory.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdFactory.UseSendTab = True
        '
        'txt_cdMainProcess
        '
        Me.txt_cdMainProcess.BackYesno = False
        Me.txt_cdMainProcess.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdMainProcess.ButtonEnabled = True
        Me.txt_cdMainProcess.ButtonFont = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdMainProcess.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdMainProcess.ButtonName = ""
        Me.txt_cdMainProcess.ButtonTitle = "Process"
        Me.txt_cdMainProcess.Code = ""
        Me.txt_cdMainProcess.Data = "Cutting"
        Me.txt_cdMainProcess.DataDecimal = 1
        Me.txt_cdMainProcess.DataLen = 1
        Me.txt_cdMainProcess.DataValue = 1
        Me.txt_cdMainProcess.Enabled = False
        Me.txt_cdMainProcess.Layoutpercent = New Decimal(New Integer() {35, 0, 0, 131072})
        Me.txt_cdMainProcess.Location = New System.Drawing.Point(342, 54)
        Me.txt_cdMainProcess.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdMainProcess.Name = "txt_cdMainProcess"
        Me.txt_cdMainProcess.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdMainProcess.Size = New System.Drawing.Size(381, 49)
        Me.txt_cdMainProcess.TabIndex = 2
        Me.txt_cdMainProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdMainProcess.TextBoxAutoComplete = False
        Me.txt_cdMainProcess.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdMainProcess.TextBoxFont = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdMainProcess.TextEnabled = True
        Me.txt_cdMainProcess.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdMainProcess.TextMaxLength = 32767
        Me.txt_cdMainProcess.TextMultiLine = False
        Me.txt_cdMainProcess.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdMainProcess.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdMainProcess.UseSendTab = True
        '
        'txt_InchargeProdution
        '
        Me.txt_InchargeProdution.BackYesno = False
        Me.txt_InchargeProdution.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_InchargeProdution.ButtonEnabled = True
        Me.txt_InchargeProdution.ButtonFont = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_InchargeProdution.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeProdution.ButtonName = ""
        Me.txt_InchargeProdution.ButtonTitle = "Incharge"
        Me.txt_InchargeProdution.Code = ""
        Me.txt_InchargeProdution.Data = ""
        Me.txt_InchargeProdution.DataDecimal = 1
        Me.txt_InchargeProdution.DataLen = 0
        Me.txt_InchargeProdution.DataValue = 1
        Me.txt_InchargeProdution.Enabled = False
        Me.txt_InchargeProdution.Layoutpercent = New Decimal(New Integer() {35, 0, 0, 131072})
        Me.txt_InchargeProdution.Location = New System.Drawing.Point(750, 54)
        Me.txt_InchargeProdution.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_InchargeProdution.Name = "txt_InchargeProdution"
        Me.txt_InchargeProdution.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_InchargeProdution.Size = New System.Drawing.Size(448, 50)
        Me.txt_InchargeProdution.TabIndex = 3
        Me.txt_InchargeProdution.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_InchargeProdution.TextBoxAutoComplete = False
        Me.txt_InchargeProdution.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_InchargeProdution.TextBoxFont = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_InchargeProdution.TextEnabled = True
        Me.txt_InchargeProdution.TextForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeProdution.TextMaxLength = 32767
        Me.txt_InchargeProdution.TextMultiLine = False
        Me.txt_InchargeProdution.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_InchargeProdution.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_InchargeProdution.UseSendTab = True
        '
        'txt_cdLineProd
        '
        Me.txt_cdLineProd.BackYesno = False
        Me.txt_cdLineProd.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdLineProd.ButtonEnabled = True
        Me.txt_cdLineProd.ButtonFont = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdLineProd.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd.ButtonName = ""
        Me.txt_cdLineProd.ButtonTitle = "Line"
        Me.txt_cdLineProd.Code = ""
        Me.txt_cdLineProd.Data = "LINE 1"
        Me.txt_cdLineProd.DataDecimal = 1
        Me.txt_cdLineProd.DataLen = 1
        Me.txt_cdLineProd.DataValue = 1
        Me.txt_cdLineProd.Enabled = False
        Me.txt_cdLineProd.Layoutpercent = New Decimal(New Integer() {35, 0, 0, 131072})
        Me.txt_cdLineProd.Location = New System.Drawing.Point(750, 0)
        Me.txt_cdLineProd.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdLineProd.Name = "txt_cdLineProd"
        Me.txt_cdLineProd.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdLineProd.Size = New System.Drawing.Size(448, 51)
        Me.txt_cdLineProd.TabIndex = 1
        Me.txt_cdLineProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdLineProd.TextBoxAutoComplete = False
        Me.txt_cdLineProd.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd.TextBoxFont = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdLineProd.TextEnabled = True
        Me.txt_cdLineProd.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd.TextMaxLength = 32767
        Me.txt_cdLineProd.TextMultiLine = False
        Me.txt_cdLineProd.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdLineProd.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdLineProd.UseSendTab = True
        '
        'txt_DateProd
        '
        Me.txt_DateProd.BackYesno = False
        Me.txt_DateProd.ButtonTitle = Nothing
        Me.txt_DateProd.Code = Nothing
        Me.txt_DateProd.Data = "2019/01/09"
        Me.txt_DateProd.DataDecimal = 0
        Me.txt_DateProd.DataLen = 0
        Me.txt_DateProd.DataValue = 0
        Me.txt_DateProd.FormatDecimal = 0
        Me.txt_DateProd.FormatValue = False
        Me.txt_DateProd.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_DateProd.LableEnabled = True
        Me.txt_DateProd.LableFont = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DateProd.LableForeColor = System.Drawing.Color.Empty
        Me.txt_DateProd.LableTitle = "Date"
        Me.txt_DateProd.Layoutpercent = New Decimal(New Integer() {43, 0, 0, 131072})
        Me.txt_DateProd.Location = New System.Drawing.Point(3, 3)
        Me.txt_DateProd.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_DateProd.Name = "txt_DateProd"
        Me.txt_DateProd.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_DateProd.Size = New System.Drawing.Size(337, 49)
        Me.txt_DateProd.TabIndex = 186
        Me.txt_DateProd.TabStop = False
        Me.txt_DateProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_DateProd.TextBoxAutoComplete = False
        Me.txt_DateProd.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_DateProd.TextBoxFont = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DateProd.TextEnabled = False
        Me.txt_DateProd.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DateProd.TextMaxLength = 32767
        Me.txt_DateProd.TextMultiLine = False
        Me.txt_DateProd.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_DateProd.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_DateProd.UseSendTab = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PeaceSplitContainer1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1222, 571)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'ISUD4367B
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1222, 571)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.KeyPreview = True
        Me.Name = "ISUD4367B"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CUTIING INPUT PROCESSING (ISUD4367A)"
        Me.PeaceSplitContainer1.Panel1.ResumeLayout(False)
        Me.PeaceSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.PeaceSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeaceSplitContainer1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.vS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vS1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeacePanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel4.ResumeLayout(False)
        CType(Me.FlowLayoutPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Pan_Process, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pan_Process.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PeaceButton2 As PSMGlobal.PeaceButton
    Friend WithEvents PeaceMaskedtextbox1 As PSMGlobal.PeaceMaskedtextbox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Bk_1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PeaceSplitContainer1 As PSMGlobal.PeaceSplitContainer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents FlowLayoutPanel1 As PSMGlobal.PeacePanel
    Friend WithEvents txt_Barcode_Box As PSMGlobal.SelectLabelText
    Public WithEvents Pan_Process As PSMGlobal.PeacePanel
    Friend WithEvents txt_cdFactory As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdMainProcess As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_InchargeProdution As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdLineProd As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_DateProd As PSMGlobal.SelectLabelText
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PeacePanel4 As PSMGlobal.PeacePanel
    Friend WithEvents cmd_DEL As PSMGlobal.PeaceButton
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents cmd_CANCEL As PSMGlobal.PeaceButton
    Friend WithEvents txt_Mess As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents vS1 As PSMGlobal.PeaceFarpoint
    Friend WithEvents vS1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents lbt_MaterialName As PSMGlobal.PeaceLabel
    Friend WithEvents txt_MaterialName As System.Windows.Forms.TextBox
    Friend WithEvents PeaceLabel1 As PSMGlobal.PeaceLabel


End Class
