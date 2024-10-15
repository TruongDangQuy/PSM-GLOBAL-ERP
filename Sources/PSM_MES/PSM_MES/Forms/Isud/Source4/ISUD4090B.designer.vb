<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD4090B
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD4090B))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Bk_1 = New System.ComponentModel.BackgroundWorker()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_Mess = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.vS1 = New PSMGlobal.PeaceFarpoint()
        Me.vS1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.Frame4 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_DEL = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Pan_Process = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_T30 = New PSMGlobal.PeaceLabel(Me.components)
        Me.txt_Line = New PSMGlobal.PeaceLabel(Me.components)
        Me.txt_ProdSeq = New PSMGlobal.SelectLabelText()
        Me.txt_ProdDate = New PSMGlobal.SelectLabelText()
        Me.FlowLayoutPanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_Mess2 = New System.Windows.Forms.TextBox()
        Me.txt_cdSubProcess = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_TimeMaterialOutBound = New PSMGlobal.SelectLabelText()
        Me.txt_cdMainProcess = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_InchargeProdution = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdFactory = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdLineProd = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_Barcode = New PSMGlobal.SelectLabelText()
        Me.PeaceButton2 = New PSMGlobal.PeaceButton(Me.components)
        Me.PeaceMaskedtextbox1 = New PSMGlobal.PeaceMaskedtextbox(Me.components)
        Me.tim_30 = New System.Windows.Forms.Timer(Me.components)
        vS1_InputMapWhenFocusedNormal = New FarPoint.Win.Spread.InputMap()
        vS1_InputMapWhenFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        vS1_InputMapWhenAncestorOfFocusedNormal = New FarPoint.Win.Spread.InputMap()
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.vS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vS1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Pan_Process, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pan_Process.SuspendLayout()
        CType(Me.FlowLayoutPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bk_1
        '
        Me.Bk_1.WorkerReportsProgress = True
        Me.Bk_1.WorkerSupportsCancellation = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Frame4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1509, 707)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.ItemSize = New System.Drawing.Size(250, 24)
        Me.TabControl1.Location = New System.Drawing.Point(3, 221)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1503, 438)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 202
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_Mess)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1495, 406)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CONTROL"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_Mess
        '
        Me.txt_Mess.BackColor = System.Drawing.SystemColors.Control
        Me.txt_Mess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Mess.Enabled = False
        Me.txt_Mess.Font = New System.Drawing.Font("Tahoma", 80.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Mess.ForeColor = System.Drawing.Color.Green
        Me.txt_Mess.Location = New System.Drawing.Point(3, 3)
        Me.txt_Mess.Multiline = True
        Me.txt_Mess.Name = "txt_Mess"
        Me.txt_Mess.Size = New System.Drawing.Size(1489, 400)
        Me.txt_Mess.TabIndex = 202
        Me.txt_Mess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.vS1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1495, 406)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "STATE"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'vS1
        '
        Me.vS1.AccessibleDescription = ""
        Me.vS1.AllowDragFill = True
        Me.vS1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.vS1.HorizontalScrollBar.TabIndex = 0
        Me.vS1.InsChk = True
        Me.vS1.Location = New System.Drawing.Point(3, 3)
        Me.vS1.Name = "vS1"
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
        Me.vS1.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle1, NamedStyle2, NamedStyle3, NamedStyle4, NamedStyle5})
        Me.vS1.ReportName = Nothing
        Me.vS1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.vS1_Sheet1})
        Me.vS1.Size = New System.Drawing.Size(1489, 400)
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
        Me.vS1.Skin = SpreadSkin1
        Me.vS1.SpreadWjob = 0
        Me.vS1.TabIndex = 0
        Me.vS1.TabStop = False
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
        Me.vS1.VerticalScrollBar.TabIndex = 9
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
        'Frame4
        '
        Me.Frame4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Frame4.Code = ""
        Me.Frame4.Controls.Add(Me.cmd_DEL)
        Me.Frame4.Controls.Add(Me.cmd_Cancel)
        Me.Frame4.Controls.Add(Me.cmd_OK)
        Me.Frame4.Data = ""
        Me.Frame4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame4.Location = New System.Drawing.Point(3, 665)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Size = New System.Drawing.Size(1503, 39)
        Me.Frame4.TabIndex = 1
        Me.Frame4.Tag = ""
        '
        'cmd_DEL
        '
        Me.cmd_DEL.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_DEL.Appearance.Options.UseFont = True
        Me.cmd_DEL.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_DEL.ButtonTitle = Nothing
        Me.cmd_DEL.Code = Nothing
        Me.cmd_DEL.Data = Nothing
        Me.cmd_DEL.Image = CType(resources.GetObject("cmd_DEL.Image"), System.Drawing.Image)
        Me.cmd_DEL.ImageAlign = 16
        Me.cmd_DEL.Location = New System.Drawing.Point(2, 1)
        Me.cmd_DEL.Margin = New System.Windows.Forms.Padding(0)
        Me.cmd_DEL.Name = "cmd_DEL"
        Me.cmd_DEL.Size = New System.Drawing.Size(141, 35)
        Me.cmd_DEL.TabIndex = 2
        Me.cmd_DEL.TabStop = False
        Me.cmd_DEL.Text = "DELETE(&D)"
        Me.cmd_DEL.UseVisualStyleBackColor = False
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.ButtonTitle = Nothing
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.Image = CType(resources.GetObject("cmd_Cancel.Image"), System.Drawing.Image)
        Me.cmd_Cancel.ImageAlign = 16
        Me.cmd_Cancel.Location = New System.Drawing.Point(1360, 1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(141, 35)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.TabStop = False
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
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Image = CType(resources.GetObject("cmd_OK.Image"), System.Drawing.Image)
        Me.cmd_OK.ImageAlign = 16
        Me.cmd_OK.Location = New System.Drawing.Point(1219, 1)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(141, 35)
        Me.cmd_OK.TabIndex = 0
        Me.cmd_OK.TabStop = False
        Me.cmd_OK.Text = "SAVE(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Pan_Process)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.txt_Barcode)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1503, 212)
        Me.Panel1.TabIndex = 3
        '
        'Pan_Process
        '
        Me.Pan_Process.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Pan_Process.Code = ""
        Me.Pan_Process.Controls.Add(Me.txt_T30)
        Me.Pan_Process.Controls.Add(Me.txt_Line)
        Me.Pan_Process.Controls.Add(Me.txt_ProdSeq)
        Me.Pan_Process.Controls.Add(Me.txt_ProdDate)
        Me.Pan_Process.Data = ""
        Me.Pan_Process.Location = New System.Drawing.Point(2, 4)
        Me.Pan_Process.Margin = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.Pan_Process.Name = "Pan_Process"
        Me.Pan_Process.Size = New System.Drawing.Size(484, 97)
        Me.Pan_Process.TabIndex = 0
        Me.Pan_Process.Tag = ""
        '
        'txt_T30
        '
        Me.txt_T30.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.txt_T30.Appearance.Font = New System.Drawing.Font("Tahoma", 30.0!, System.Drawing.FontStyle.Bold)
        Me.txt_T30.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_T30.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_T30.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_T30.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_T30.ButtonTitle = Nothing
        Me.txt_T30.Code = ""
        Me.txt_T30.Data = ""
        Me.txt_T30.DTDec = 0
        Me.txt_T30.DTLen = 0
        Me.txt_T30.DTValue = 0
        Me.txt_T30.Location = New System.Drawing.Point(250, 3)
        Me.txt_T30.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_T30.Name = "txt_T30"
        Me.txt_T30.NoClear = False
        Me.txt_T30.Size = New System.Drawing.Size(231, 91)
        Me.txt_T30.TabIndex = 203
        Me.txt_T30.Tag = ""
        Me.txt_T30.Text = "5"
        Me.txt_T30.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'txt_Line
        '
        Me.txt_Line.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.txt_Line.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Line.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_Line.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_Line.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Line.ButtonTitle = Nothing
        Me.txt_Line.Code = ""
        Me.txt_Line.Data = ""
        Me.txt_Line.DTDec = 0
        Me.txt_Line.DTLen = 0
        Me.txt_Line.DTValue = 0
        Me.txt_Line.Location = New System.Drawing.Point(2, 28)
        Me.txt_Line.Margin = New System.Windows.Forms.Padding(20, 1, 1, 1)
        Me.txt_Line.Name = "txt_Line"
        Me.txt_Line.NoClear = False
        Me.txt_Line.Size = New System.Drawing.Size(246, 64)
        Me.txt_Line.TabIndex = 190
        Me.txt_Line.Tag = ""
        Me.txt_Line.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'txt_ProdSeq
        '
        Me.txt_ProdSeq.BackYesno = False
        Me.txt_ProdSeq.ButtonTitle = Nothing
        Me.txt_ProdSeq.Code = Nothing
        Me.txt_ProdSeq.Data = ""
        Me.txt_ProdSeq.DataDecimal = 0
        Me.txt_ProdSeq.DataLen = 0
        Me.txt_ProdSeq.DataValue = 0
        Me.txt_ProdSeq.FormatDecimal = 0
        Me.txt_ProdSeq.FormatValue = False
        Me.txt_ProdSeq.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ProdSeq.LableEnabled = True
        Me.txt_ProdSeq.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ProdSeq.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ProdSeq.LableTitle = "Date"
        Me.txt_ProdSeq.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_ProdSeq.Location = New System.Drawing.Point(189, 3)
        Me.txt_ProdSeq.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ProdSeq.Name = "txt_ProdSeq"
        Me.txt_ProdSeq.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ProdSeq.Size = New System.Drawing.Size(59, 23)
        Me.txt_ProdSeq.TabIndex = 187
        Me.txt_ProdSeq.TabStop = False
        Me.txt_ProdSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ProdSeq.TextBoxAutoComplete = False
        Me.txt_ProdSeq.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ProdSeq.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ProdSeq.TextEnabled = False
        Me.txt_ProdSeq.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ProdSeq.TextMaxLength = 32767
        Me.txt_ProdSeq.TextMultiLine = False
        Me.txt_ProdSeq.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ProdSeq.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ProdSeq.UseSendTab = True
        '
        'txt_ProdDate
        '
        Me.txt_ProdDate.BackYesno = False
        Me.txt_ProdDate.ButtonTitle = Nothing
        Me.txt_ProdDate.Code = Nothing
        Me.txt_ProdDate.Data = ""
        Me.txt_ProdDate.DataDecimal = 0
        Me.txt_ProdDate.DataLen = 0
        Me.txt_ProdDate.DataValue = 0
        Me.txt_ProdDate.FormatDecimal = 0
        Me.txt_ProdDate.FormatValue = False
        Me.txt_ProdDate.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ProdDate.LableEnabled = True
        Me.txt_ProdDate.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ProdDate.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ProdDate.LableTitle = "Date"
        Me.txt_ProdDate.Layoutpercent = New Decimal(New Integer() {35, 0, 0, 131072})
        Me.txt_ProdDate.Location = New System.Drawing.Point(2, 3)
        Me.txt_ProdDate.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ProdDate.Name = "txt_ProdDate"
        Me.txt_ProdDate.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ProdDate.Size = New System.Drawing.Size(185, 23)
        Me.txt_ProdDate.TabIndex = 186
        Me.txt_ProdDate.TabStop = False
        Me.txt_ProdDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ProdDate.TextBoxAutoComplete = False
        Me.txt_ProdDate.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ProdDate.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ProdDate.TextEnabled = False
        Me.txt_ProdDate.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ProdDate.TextMaxLength = 32767
        Me.txt_ProdDate.TextMultiLine = False
        Me.txt_ProdDate.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ProdDate.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ProdDate.UseSendTab = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Code = ""
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Mess2)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdSubProcess)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_TimeMaterialOutBound)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdMainProcess)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_InchargeProdution)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdFactory)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdLineProd)
        Me.FlowLayoutPanel1.Data = ""
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(491, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1104, 206)
        Me.FlowLayoutPanel1.TabIndex = 1
        Me.FlowLayoutPanel1.Tag = ""
        '
        'txt_Mess2
        '
        Me.txt_Mess2.BackColor = System.Drawing.SystemColors.Control
        Me.txt_Mess2.Font = New System.Drawing.Font("Tahoma", 30.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Mess2.ForeColor = System.Drawing.Color.Blue
        Me.txt_Mess2.Location = New System.Drawing.Point(4, 99)
        Me.txt_Mess2.Multiline = True
        Me.txt_Mess2.Name = "txt_Mess2"
        Me.txt_Mess2.Size = New System.Drawing.Size(1004, 106)
        Me.txt_Mess2.TabIndex = 203
        '
        'txt_cdSubProcess
        '
        Me.txt_cdSubProcess.BackYesno = False
        Me.txt_cdSubProcess.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSubProcess.ButtonEnabled = True
        Me.txt_cdSubProcess.ButtonFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdSubProcess.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSubProcess.ButtonName = ""
        Me.txt_cdSubProcess.ButtonTitle = "Sub Process"
        Me.txt_cdSubProcess.Code = ""
        Me.txt_cdSubProcess.Data = ""
        Me.txt_cdSubProcess.DataDecimal = 1
        Me.txt_cdSubProcess.DataLen = 1
        Me.txt_cdSubProcess.DataValue = 1
        Me.txt_cdSubProcess.Enabled = False
        Me.txt_cdSubProcess.Layoutpercent = New Decimal(New Integer() {35, 0, 0, 131072})
        Me.txt_cdSubProcess.Location = New System.Drawing.Point(653, 51)
        Me.txt_cdSubProcess.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSubProcess.Name = "txt_cdSubProcess"
        Me.txt_cdSubProcess.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSubProcess.Size = New System.Drawing.Size(355, 46)
        Me.txt_cdSubProcess.TabIndex = 201
        Me.txt_cdSubProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSubProcess.TextBoxAutoComplete = False
        Me.txt_cdSubProcess.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdSubProcess.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdSubProcess.TextEnabled = True
        Me.txt_cdSubProcess.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdSubProcess.TextMaxLength = 32767
        Me.txt_cdSubProcess.TextMultiLine = False
        Me.txt_cdSubProcess.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdSubProcess.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdSubProcess.UseSendTab = True
        '
        'txt_TimeMaterialOutBound
        '
        Me.txt_TimeMaterialOutBound.BackYesno = False
        Me.txt_TimeMaterialOutBound.ButtonTitle = Nothing
        Me.txt_TimeMaterialOutBound.Code = Nothing
        Me.txt_TimeMaterialOutBound.Data = ""
        Me.txt_TimeMaterialOutBound.DataDecimal = 0
        Me.txt_TimeMaterialOutBound.DataLen = 0
        Me.txt_TimeMaterialOutBound.DataValue = 0
        Me.txt_TimeMaterialOutBound.FormatDecimal = 0
        Me.txt_TimeMaterialOutBound.FormatValue = False
        Me.txt_TimeMaterialOutBound.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_TimeMaterialOutBound.LableEnabled = True
        Me.txt_TimeMaterialOutBound.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_TimeMaterialOutBound.LableForeColor = System.Drawing.Color.Empty
        Me.txt_TimeMaterialOutBound.LableTitle = "Time Outbound"
        Me.txt_TimeMaterialOutBound.Layoutpercent = New Decimal(New Integer() {35, 0, 0, 131072})
        Me.txt_TimeMaterialOutBound.Location = New System.Drawing.Point(4, 51)
        Me.txt_TimeMaterialOutBound.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_TimeMaterialOutBound.Name = "txt_TimeMaterialOutBound"
        Me.txt_TimeMaterialOutBound.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_TimeMaterialOutBound.Size = New System.Drawing.Size(302, 40)
        Me.txt_TimeMaterialOutBound.TabIndex = 190
        Me.txt_TimeMaterialOutBound.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_TimeMaterialOutBound.TextBoxAutoComplete = False
        Me.txt_TimeMaterialOutBound.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_TimeMaterialOutBound.TextBoxFont = New System.Drawing.Font("Tahoma", 14.0!)
        Me.txt_TimeMaterialOutBound.TextEnabled = True
        Me.txt_TimeMaterialOutBound.TextForeColor = System.Drawing.Color.Empty
        Me.txt_TimeMaterialOutBound.TextMaxLength = 32767
        Me.txt_TimeMaterialOutBound.TextMultiLine = False
        Me.txt_TimeMaterialOutBound.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_TimeMaterialOutBound.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_TimeMaterialOutBound.UseSendTab = True
        '
        'txt_cdMainProcess
        '
        Me.txt_cdMainProcess.BackYesno = False
        Me.txt_cdMainProcess.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdMainProcess.ButtonEnabled = True
        Me.txt_cdMainProcess.ButtonFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdMainProcess.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdMainProcess.ButtonName = ""
        Me.txt_cdMainProcess.ButtonTitle = "Main Process"
        Me.txt_cdMainProcess.Code = ""
        Me.txt_cdMainProcess.Data = ""
        Me.txt_cdMainProcess.DataDecimal = 1
        Me.txt_cdMainProcess.DataLen = 1
        Me.txt_cdMainProcess.DataValue = 1
        Me.txt_cdMainProcess.Enabled = False
        Me.txt_cdMainProcess.Layoutpercent = New Decimal(New Integer() {35, 0, 0, 131072})
        Me.txt_cdMainProcess.Location = New System.Drawing.Point(311, 51)
        Me.txt_cdMainProcess.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdMainProcess.Name = "txt_cdMainProcess"
        Me.txt_cdMainProcess.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdMainProcess.Size = New System.Drawing.Size(340, 46)
        Me.txt_cdMainProcess.TabIndex = 2
        Me.txt_cdMainProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdMainProcess.TextBoxAutoComplete = False
        Me.txt_cdMainProcess.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdMainProcess.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txt_InchargeProdution.ButtonFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_InchargeProdution.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeProdution.ButtonName = "Const_Emp005"
        Me.txt_InchargeProdution.ButtonTitle = "Incharge"
        Me.txt_InchargeProdution.Code = ""
        Me.txt_InchargeProdution.Data = ""
        Me.txt_InchargeProdution.DataDecimal = 1
        Me.txt_InchargeProdution.DataLen = 0
        Me.txt_InchargeProdution.DataValue = 1
        Me.txt_InchargeProdution.Layoutpercent = New Decimal(New Integer() {35, 0, 0, 131072})
        Me.txt_InchargeProdution.Location = New System.Drawing.Point(652, 0)
        Me.txt_InchargeProdution.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_InchargeProdution.Name = "txt_InchargeProdution"
        Me.txt_InchargeProdution.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_InchargeProdution.Size = New System.Drawing.Size(356, 49)
        Me.txt_InchargeProdution.TabIndex = 3
        Me.txt_InchargeProdution.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_InchargeProdution.TextBoxAutoComplete = False
        Me.txt_InchargeProdution.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_InchargeProdution.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_InchargeProdution.TextEnabled = True
        Me.txt_InchargeProdution.TextForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeProdution.TextMaxLength = 32767
        Me.txt_InchargeProdution.TextMultiLine = False
        Me.txt_InchargeProdution.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_InchargeProdution.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_InchargeProdution.UseSendTab = True
        '
        'txt_cdFactory
        '
        Me.txt_cdFactory.BackYesno = False
        Me.txt_cdFactory.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdFactory.ButtonEnabled = True
        Me.txt_cdFactory.ButtonFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdFactory.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.ButtonName = ""
        Me.txt_cdFactory.ButtonTitle = "Factory"
        Me.txt_cdFactory.Code = ""
        Me.txt_cdFactory.Data = ""
        Me.txt_cdFactory.DataDecimal = 1
        Me.txt_cdFactory.DataLen = 1
        Me.txt_cdFactory.DataValue = 1
        Me.txt_cdFactory.Layoutpercent = New Decimal(New Integer() {35, 0, 0, 131072})
        Me.txt_cdFactory.Location = New System.Drawing.Point(3, 1)
        Me.txt_cdFactory.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdFactory.Name = "txt_cdFactory"
        Me.txt_cdFactory.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdFactory.Size = New System.Drawing.Size(303, 49)
        Me.txt_cdFactory.TabIndex = 0
        Me.txt_cdFactory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdFactory.TextBoxAutoComplete = False
        Me.txt_cdFactory.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdFactory.TextEnabled = True
        Me.txt_cdFactory.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.TextMaxLength = 32767
        Me.txt_cdFactory.TextMultiLine = False
        Me.txt_cdFactory.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdFactory.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdFactory.UseSendTab = True
        '
        'txt_cdLineProd
        '
        Me.txt_cdLineProd.BackYesno = False
        Me.txt_cdLineProd.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdLineProd.ButtonEnabled = True
        Me.txt_cdLineProd.ButtonFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdLineProd.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd.ButtonName = ""
        Me.txt_cdLineProd.ButtonTitle = "Line Prod"
        Me.txt_cdLineProd.Code = ""
        Me.txt_cdLineProd.Data = ""
        Me.txt_cdLineProd.DataDecimal = 1
        Me.txt_cdLineProd.DataLen = 1
        Me.txt_cdLineProd.DataValue = 1
        Me.txt_cdLineProd.Layoutpercent = New Decimal(New Integer() {35, 0, 0, 131072})
        Me.txt_cdLineProd.Location = New System.Drawing.Point(313, 0)
        Me.txt_cdLineProd.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdLineProd.Name = "txt_cdLineProd"
        Me.txt_cdLineProd.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdLineProd.Size = New System.Drawing.Size(337, 49)
        Me.txt_cdLineProd.TabIndex = 1
        Me.txt_cdLineProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdLineProd.TextBoxAutoComplete = False
        Me.txt_cdLineProd.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdLineProd.TextEnabled = True
        Me.txt_cdLineProd.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd.TextMaxLength = 32767
        Me.txt_cdLineProd.TextMultiLine = False
        Me.txt_cdLineProd.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdLineProd.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdLineProd.UseSendTab = True
        '
        'txt_Barcode
        '
        Me.txt_Barcode.BackYesno = False
        Me.txt_Barcode.ButtonTitle = Nothing
        Me.txt_Barcode.Code = Nothing
        Me.txt_Barcode.Data = ""
        Me.txt_Barcode.DataDecimal = 0
        Me.txt_Barcode.DataLen = 0
        Me.txt_Barcode.DataValue = 0
        Me.txt_Barcode.FormatDecimal = 0
        Me.txt_Barcode.FormatValue = False
        Me.txt_Barcode.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_Barcode.LableEnabled = True
        Me.txt_Barcode.LableFont = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Barcode.LableForeColor = System.Drawing.Color.Black
        Me.txt_Barcode.LableTitle = "B#"
        Me.txt_Barcode.Layoutpercent = New Decimal(New Integer() {2, 0, 0, 65536})
        Me.txt_Barcode.Location = New System.Drawing.Point(2, 103)
        Me.txt_Barcode.Margin = New System.Windows.Forms.Padding(1, 1, 100, 1)
        Me.txt_Barcode.Name = "txt_Barcode"
        Me.txt_Barcode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Barcode.Size = New System.Drawing.Size(482, 105)
        Me.txt_Barcode.TabIndex = 4
        Me.txt_Barcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Barcode.TextBoxAutoComplete = True
        Me.txt_Barcode.TextboxBackColor = System.Drawing.Color.White
        Me.txt_Barcode.TextBoxFont = New System.Drawing.Font("Tahoma", 34.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Barcode.TextEnabled = True
        Me.txt_Barcode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Barcode.TextMaxLength = 1000
        Me.txt_Barcode.TextMultiLine = False
        Me.txt_Barcode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Barcode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Barcode.UseSendTab = True
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
        'tim_30
        '
        Me.tim_30.Interval = 1000
        '
        'ISUD4090B
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1509, 707)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.KeyPreview = True
        Me.Name = "ISUD4090B"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ASSEMBLY PRODUCTION PROCESSING (ISUD4090B)"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.vS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vS1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.Pan_Process, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pan_Process.ResumeLayout(False)
        CType(Me.FlowLayoutPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents cmd_DEL As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents Frame4 As PSMGlobal.PeacePanel
    Friend WithEvents PeaceButton2 As PSMGlobal.PeaceButton
    Friend WithEvents PeaceMaskedtextbox1 As PSMGlobal.PeaceMaskedtextbox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Bk_1 As System.ComponentModel.BackgroundWorker
    Public WithEvents vS1 As PSMGlobal.PeaceFarpoint
    Friend WithEvents vS1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents txt_Barcode As PSMGlobal.SelectLabelText
    Public WithEvents Pan_Process As PSMGlobal.PeacePanel
    Friend WithEvents txt_InchargeProdution As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_ProdDate As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdMainProcess As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As PSMGlobal.PeacePanel
    Friend WithEvents txt_cdFactory As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdLineProd As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_TimeMaterialOutBound As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ProdSeq As PSMGlobal.SelectLabelText
    Public WithEvents txt_Line As PSMGlobal.PeaceLabel
    Friend WithEvents txt_cdSubProcess As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_Mess As System.Windows.Forms.TextBox
    Friend WithEvents tim_30 As System.Windows.Forms.Timer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txt_T30 As PSMGlobal.PeaceLabel
    Friend WithEvents txt_Mess2 As System.Windows.Forms.TextBox
End Class
