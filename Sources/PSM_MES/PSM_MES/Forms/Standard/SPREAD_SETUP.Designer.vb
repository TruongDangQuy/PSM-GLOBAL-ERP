<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_SPREAD_SETUP
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
        Dim Vs1_InputMapWhenFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim Vs1_InputMapWhenAncestorOfFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_SPREAD_SETUP))
        Me.Vs1 = New PSMGlobal.PeaceFarpoint()
        Me.Vs1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.Itemcode = New PSMGlobal.SelectLabelSearch()
        Me.Itemname = New PSMGlobal.SelectLabelSearch()
        Me.Itemnamesimple = New PSMGlobal.SelectLabelSearch()
        Me.Datadecimal = New PSMGlobal.SelectLabelSearch()
        Me.Fontstyle = New PSMGlobal.SelectLabelSearch()
        Me.Forecolor_ = New PSMGlobal.SelectLabelSearch()
        Me.Backcolor_ = New PSMGlobal.SelectLabelSearch()
        Me.Fontbold = New PSMGlobal.SelectLabelSearch()
        Me.Fontsize = New PSMGlobal.SelectLabelSearch()
        Me.Fontname = New PSMGlobal.SelectLabelSearch()
        Me.Sizeheight = New PSMGlobal.SelectLabelSearch()
        Me.Sizewidth = New PSMGlobal.SelectLabelSearch()
        Me.Datasize = New PSMGlobal.SelectLabelSearch()
        Me.Projectname = New PSMGlobal.SelectLabelSearch()
        Me.PeaceButton1 = New PSMGlobal.PeaceButton(Me.components)
        Me.txt_NAME = New PSMGlobal.SelectLabelSearch()
        Me.PeaceButton2 = New PSMGlobal.PeaceButton(Me.components)
        Me.PeaceButton3 = New PSMGlobal.PeaceButton(Me.components)
        Me.PeaceButton4 = New PSMGlobal.PeaceButton(Me.components)
        Me.PeaceButton5 = New PSMGlobal.PeaceButton(Me.components)
        Me.VerticalAlign = New PSMGlobal.PeaceCombobox(Me.components)
        Me.HorizonAlign = New PSMGlobal.PeaceCombobox(Me.components)
        Me.TextAlign = New PSMGlobal.PeaceCombobox(Me.components)
        Me.Datatype = New PSMGlobal.PeaceCombobox(Me.components)
        Me.Frame4 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_DEL = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.DataLock = New PSMGlobal.PeaceCombobox(Me.components)
        Me.DataLock1 = New PSMGlobal.PeaceButton(Me.components)
        Me.PeaceButton7 = New PSMGlobal.PeaceButton(Me.components)
        Me.DataHide = New PSMGlobal.PeaceCombobox(Me.components)
        Vs1_InputMapWhenFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Vs1
        '
        Me.Vs1.AccessibleDescription = ""
        Me.Vs1.BorderStyle = BorderStyle.FixedSingle
        Me.Vs1.FocusRenderer = EnhancedFocusIndicatorRenderer1
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
        Me.Vs1.InsChk = False
        Me.Vs1.Location = New System.Drawing.Point(3, 36)
        Me.Vs1.Name = "Vs1"
        NamedStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle1.Border = BevelBorder1
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
        Me.Vs1.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle1, NamedStyle2, NamedStyle3, NamedStyle4, NamedStyle5})
        Me.Vs1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.Vs1_Sheet1})
        Me.Vs1.Size = New System.Drawing.Size(969, 368)
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
        Me.Vs1.Skin = SpreadSkin1
        Me.Vs1.TabIndex = 3
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
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.ForeColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.Parent = "RowHeaderDefault"
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnHeader.AutoText = FarPoint.Win.Spread.HeaderAutoText.Blank
        Me.Vs1_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnHeader.Rows.Get(0).Height = 49.0!
        Me.Vs1_Sheet1.DefaultStyle.ForeColor = System.Drawing.Color.Black
        Me.Vs1_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.DefaultStyle.Parent = "DataAreaDefault"
        Me.Vs1_Sheet1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.FilterBar.DefaultStyle.Parent = "FilterBarDefaultEnhanced"
        Me.Vs1_Sheet1.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.Vs1_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.Vs1_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.SelectionBackColor = System.Drawing.Color.Aquamarine
        Me.Vs1_Sheet1.SheetCornerStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Vs1_Sheet1.SheetCornerStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Vs1_Sheet1.SheetCornerStyle.ForeColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.SheetCornerStyle.Parent = "RowHeaderDefault"
        Me.Vs1_Sheet1.SheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'Itemcode
        '
        Me.Itemcode.BackYesno = False
        Me.Itemcode.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Itemcode.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Standard
        Me.Itemcode.ButtonEnabled = True
        Me.Itemcode.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Itemcode.ButtonForeColor = System.Drawing.Color.Empty
        Me.Itemcode.ButtonTitle = "Itemcode"
        Me.Itemcode.Code = Nothing
        Me.Itemcode.Data = " "
        Me.Itemcode.DataDecimal = 0
        Me.Itemcode.DataLen = 0
        Me.Itemcode.DataValue = 0
        Me.Itemcode.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.Itemcode.Location = New System.Drawing.Point(3, 408)
        Me.Itemcode.Margin = New System.Windows.Forms.Padding(0)
        Me.Itemcode.Name = "Itemcode"
        Me.Itemcode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Itemcode.Size = New System.Drawing.Size(310, 22)
        Me.Itemcode.TabIndex = 4
        Me.Itemcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Itemcode.TextBoxAutoComplete = False
        Me.Itemcode.TextboxBackColor = System.Drawing.Color.Empty
        Me.Itemcode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Itemcode.TextEnabled = True
        Me.Itemcode.TextForeColor = System.Drawing.Color.Empty
        Me.Itemcode.TextMaxLength = 32767
        Me.Itemcode.TextMultiLine = False
        Me.Itemcode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Itemcode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Itemcode.UseSendTab = True
        '
        'Itemname
        '
        Me.Itemname.BackYesno = False
        Me.Itemname.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Itemname.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Standard
        Me.Itemname.ButtonEnabled = True
        Me.Itemname.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Itemname.ButtonForeColor = System.Drawing.Color.Empty
        Me.Itemname.ButtonTitle = "Itemname"
        Me.Itemname.Code = Nothing
        Me.Itemname.Data = " "
        Me.Itemname.DataDecimal = 0
        Me.Itemname.DataLen = 0
        Me.Itemname.DataValue = 0
        Me.Itemname.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.Itemname.Location = New System.Drawing.Point(3, 432)
        Me.Itemname.Margin = New System.Windows.Forms.Padding(0)
        Me.Itemname.Name = "Itemname"
        Me.Itemname.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Itemname.Size = New System.Drawing.Size(310, 22)
        Me.Itemname.TabIndex = 5
        Me.Itemname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Itemname.TextBoxAutoComplete = False
        Me.Itemname.TextboxBackColor = System.Drawing.Color.Empty
        Me.Itemname.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Itemname.TextEnabled = True
        Me.Itemname.TextForeColor = System.Drawing.Color.Empty
        Me.Itemname.TextMaxLength = 32767
        Me.Itemname.TextMultiLine = False
        Me.Itemname.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Itemname.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Itemname.UseSendTab = True
        '
        'Itemnamesimple
        '
        Me.Itemnamesimple.BackYesno = False
        Me.Itemnamesimple.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Itemnamesimple.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Standard
        Me.Itemnamesimple.ButtonEnabled = True
        Me.Itemnamesimple.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Itemnamesimple.ButtonForeColor = System.Drawing.Color.Empty
        Me.Itemnamesimple.ButtonTitle = "Itemnamesimple"
        Me.Itemnamesimple.Code = Nothing
        Me.Itemnamesimple.Data = " "
        Me.Itemnamesimple.DataDecimal = 0
        Me.Itemnamesimple.DataLen = 0
        Me.Itemnamesimple.DataValue = 0
        Me.Itemnamesimple.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.Itemnamesimple.Location = New System.Drawing.Point(3, 456)
        Me.Itemnamesimple.Margin = New System.Windows.Forms.Padding(0)
        Me.Itemnamesimple.Name = "Itemnamesimple"
        Me.Itemnamesimple.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Itemnamesimple.Size = New System.Drawing.Size(310, 22)
        Me.Itemnamesimple.TabIndex = 6
        Me.Itemnamesimple.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Itemnamesimple.TextBoxAutoComplete = False
        Me.Itemnamesimple.TextboxBackColor = System.Drawing.Color.Empty
        Me.Itemnamesimple.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Itemnamesimple.TextEnabled = True
        Me.Itemnamesimple.TextForeColor = System.Drawing.Color.Empty
        Me.Itemnamesimple.TextMaxLength = 32767
        Me.Itemnamesimple.TextMultiLine = False
        Me.Itemnamesimple.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Itemnamesimple.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Itemnamesimple.UseSendTab = True
        '
        'Datadecimal
        '
        Me.Datadecimal.BackYesno = False
        Me.Datadecimal.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Datadecimal.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Standard
        Me.Datadecimal.ButtonEnabled = True
        Me.Datadecimal.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datadecimal.ButtonForeColor = System.Drawing.Color.Empty
        Me.Datadecimal.ButtonTitle = "Datadecimal"
        Me.Datadecimal.Code = Nothing
        Me.Datadecimal.Data = Nothing
        Me.Datadecimal.DataDecimal = 0
        Me.Datadecimal.DataLen = 0
        Me.Datadecimal.DataValue = 0
        Me.Datadecimal.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.Datadecimal.Location = New System.Drawing.Point(325, 408)
        Me.Datadecimal.Margin = New System.Windows.Forms.Padding(0)
        Me.Datadecimal.Name = "Datadecimal"
        Me.Datadecimal.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Datadecimal.Size = New System.Drawing.Size(310, 22)
        Me.Datadecimal.TabIndex = 7
        Me.Datadecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Datadecimal.TextBoxAutoComplete = False
        Me.Datadecimal.TextboxBackColor = System.Drawing.Color.Empty
        Me.Datadecimal.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Datadecimal.TextEnabled = True
        Me.Datadecimal.TextForeColor = System.Drawing.Color.Empty
        Me.Datadecimal.TextMaxLength = 32767
        Me.Datadecimal.TextMultiLine = False
        Me.Datadecimal.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Datadecimal.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Datadecimal.UseSendTab = True
        '
        'Fontstyle
        '
        Me.Fontstyle.BackYesno = False
        Me.Fontstyle.ButtonBackColor = System.Drawing.Color.Yellow
        Me.Fontstyle.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Standard
        Me.Fontstyle.ButtonEnabled = True
        Me.Fontstyle.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fontstyle.ButtonForeColor = System.Drawing.Color.Empty
        Me.Fontstyle.ButtonTitle = "Fontstyle"
        Me.Fontstyle.Code = Nothing
        Me.Fontstyle.Data = Nothing
        Me.Fontstyle.DataDecimal = 0
        Me.Fontstyle.DataLen = 0
        Me.Fontstyle.DataValue = 0
        Me.Fontstyle.Layoutpercent = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Fontstyle.Location = New System.Drawing.Point(663, 457)
        Me.Fontstyle.Margin = New System.Windows.Forms.Padding(0)
        Me.Fontstyle.Name = "Fontstyle"
        Me.Fontstyle.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Fontstyle.Size = New System.Drawing.Size(310, 22)
        Me.Fontstyle.TabIndex = 12
        Me.Fontstyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Fontstyle.TextBoxAutoComplete = False
        Me.Fontstyle.TextboxBackColor = System.Drawing.Color.Empty
        Me.Fontstyle.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Fontstyle.TextEnabled = False
        Me.Fontstyle.TextForeColor = System.Drawing.Color.Empty
        Me.Fontstyle.TextMaxLength = 32767
        Me.Fontstyle.TextMultiLine = False
        Me.Fontstyle.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Fontstyle.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Fontstyle.UseSendTab = True
        '
        'Forecolor_
        '
        Me.Forecolor_.BackYesno = False
        Me.Forecolor_.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Forecolor_.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Standard
        Me.Forecolor_.ButtonEnabled = True
        Me.Forecolor_.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Forecolor_.ButtonForeColor = System.Drawing.Color.Empty
        Me.Forecolor_.ButtonTitle = "Forecolor"
        Me.Forecolor_.Code = Nothing
        Me.Forecolor_.Data = " "
        Me.Forecolor_.DataDecimal = 0
        Me.Forecolor_.DataLen = 0
        Me.Forecolor_.DataValue = 0
        Me.Forecolor_.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.Forecolor_.Location = New System.Drawing.Point(663, 433)
        Me.Forecolor_.Margin = New System.Windows.Forms.Padding(0)
        Me.Forecolor_.Name = "Forecolor_"
        Me.Forecolor_.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Forecolor_.Size = New System.Drawing.Size(310, 22)
        Me.Forecolor_.TabIndex = 11
        Me.Forecolor_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Forecolor_.TextBoxAutoComplete = False
        Me.Forecolor_.TextboxBackColor = System.Drawing.Color.Empty
        Me.Forecolor_.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Forecolor_.TextEnabled = False
        Me.Forecolor_.TextForeColor = System.Drawing.Color.Empty
        Me.Forecolor_.TextMaxLength = 32767
        Me.Forecolor_.TextMultiLine = False
        Me.Forecolor_.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Forecolor_.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Forecolor_.UseSendTab = True
        '
        'Backcolor_
        '
        Me.Backcolor_.BackYesno = False
        Me.Backcolor_.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Backcolor_.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Standard
        Me.Backcolor_.ButtonEnabled = True
        Me.Backcolor_.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Backcolor_.ButtonForeColor = System.Drawing.Color.Empty
        Me.Backcolor_.ButtonTitle = "Backcolor"
        Me.Backcolor_.Code = Nothing
        Me.Backcolor_.Data = " "
        Me.Backcolor_.DataDecimal = 0
        Me.Backcolor_.DataLen = 0
        Me.Backcolor_.DataValue = 0
        Me.Backcolor_.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.Backcolor_.Location = New System.Drawing.Point(663, 409)
        Me.Backcolor_.Margin = New System.Windows.Forms.Padding(0)
        Me.Backcolor_.Name = "Backcolor_"
        Me.Backcolor_.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Backcolor_.Size = New System.Drawing.Size(310, 22)
        Me.Backcolor_.TabIndex = 10
        Me.Backcolor_.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Backcolor_.TextBoxAutoComplete = False
        Me.Backcolor_.TextboxBackColor = System.Drawing.Color.Empty
        Me.Backcolor_.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Backcolor_.TextEnabled = False
        Me.Backcolor_.TextForeColor = System.Drawing.Color.Empty
        Me.Backcolor_.TextMaxLength = 32767
        Me.Backcolor_.TextMultiLine = False
        Me.Backcolor_.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Backcolor_.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Backcolor_.UseSendTab = True
        '
        'Fontbold
        '
        Me.Fontbold.BackYesno = False
        Me.Fontbold.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Fontbold.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Standard
        Me.Fontbold.ButtonEnabled = True
        Me.Fontbold.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fontbold.ButtonForeColor = System.Drawing.Color.Empty
        Me.Fontbold.ButtonTitle = "Font bold"
        Me.Fontbold.Code = Nothing
        Me.Fontbold.Data = "0"
        Me.Fontbold.DataDecimal = 0
        Me.Fontbold.DataLen = 0
        Me.Fontbold.DataValue = 0
        Me.Fontbold.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.Fontbold.Location = New System.Drawing.Point(663, 532)
        Me.Fontbold.Margin = New System.Windows.Forms.Padding(0)
        Me.Fontbold.Name = "Fontbold"
        Me.Fontbold.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Fontbold.Size = New System.Drawing.Size(310, 22)
        Me.Fontbold.TabIndex = 21
        Me.Fontbold.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Fontbold.TextBoxAutoComplete = False
        Me.Fontbold.TextboxBackColor = System.Drawing.Color.Empty
        Me.Fontbold.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Fontbold.TextEnabled = False
        Me.Fontbold.TextForeColor = System.Drawing.Color.Empty
        Me.Fontbold.TextMaxLength = 32767
        Me.Fontbold.TextMultiLine = False
        Me.Fontbold.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Fontbold.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Fontbold.UseSendTab = True
        '
        'Fontsize
        '
        Me.Fontsize.BackYesno = False
        Me.Fontsize.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Fontsize.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Standard
        Me.Fontsize.ButtonEnabled = True
        Me.Fontsize.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fontsize.ButtonForeColor = System.Drawing.Color.Empty
        Me.Fontsize.ButtonTitle = "Font size"
        Me.Fontsize.Code = Nothing
        Me.Fontsize.Data = "9"
        Me.Fontsize.DataDecimal = 0
        Me.Fontsize.DataLen = 0
        Me.Fontsize.DataValue = 0
        Me.Fontsize.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.Fontsize.Location = New System.Drawing.Point(663, 508)
        Me.Fontsize.Margin = New System.Windows.Forms.Padding(0)
        Me.Fontsize.Name = "Fontsize"
        Me.Fontsize.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Fontsize.Size = New System.Drawing.Size(310, 22)
        Me.Fontsize.TabIndex = 20
        Me.Fontsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Fontsize.TextBoxAutoComplete = False
        Me.Fontsize.TextboxBackColor = System.Drawing.Color.Empty
        Me.Fontsize.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Fontsize.TextEnabled = False
        Me.Fontsize.TextForeColor = System.Drawing.Color.Empty
        Me.Fontsize.TextMaxLength = 32767
        Me.Fontsize.TextMultiLine = False
        Me.Fontsize.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Fontsize.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Fontsize.UseSendTab = True
        '
        'Fontname
        '
        Me.Fontname.BackYesno = False
        Me.Fontname.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Fontname.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Standard
        Me.Fontname.ButtonEnabled = True
        Me.Fontname.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fontname.ButtonForeColor = System.Drawing.Color.Empty
        Me.Fontname.ButtonTitle = "Font name"
        Me.Fontname.Code = Nothing
        Me.Fontname.Data = "Tahoma"
        Me.Fontname.DataDecimal = 0
        Me.Fontname.DataLen = 0
        Me.Fontname.DataValue = 0
        Me.Fontname.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.Fontname.Location = New System.Drawing.Point(663, 484)
        Me.Fontname.Margin = New System.Windows.Forms.Padding(0)
        Me.Fontname.Name = "Fontname"
        Me.Fontname.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Fontname.Size = New System.Drawing.Size(310, 22)
        Me.Fontname.TabIndex = 19
        Me.Fontname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Fontname.TextBoxAutoComplete = False
        Me.Fontname.TextboxBackColor = System.Drawing.Color.Empty
        Me.Fontname.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Fontname.TextEnabled = False
        Me.Fontname.TextForeColor = System.Drawing.Color.Empty
        Me.Fontname.TextMaxLength = 32767
        Me.Fontname.TextMultiLine = False
        Me.Fontname.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Fontname.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Fontname.UseSendTab = True
        '
        'Sizeheight
        '
        Me.Sizeheight.BackYesno = False
        Me.Sizeheight.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Sizeheight.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Standard
        Me.Sizeheight.ButtonEnabled = True
        Me.Sizeheight.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sizeheight.ButtonForeColor = System.Drawing.Color.Empty
        Me.Sizeheight.ButtonTitle = "Sizeheight"
        Me.Sizeheight.Code = Nothing
        Me.Sizeheight.Data = " "
        Me.Sizeheight.DataDecimal = 0
        Me.Sizeheight.DataLen = 0
        Me.Sizeheight.DataValue = 0
        Me.Sizeheight.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.Sizeheight.Location = New System.Drawing.Point(325, 531)
        Me.Sizeheight.Margin = New System.Windows.Forms.Padding(0)
        Me.Sizeheight.Name = "Sizeheight"
        Me.Sizeheight.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Sizeheight.Size = New System.Drawing.Size(310, 22)
        Me.Sizeheight.TabIndex = 18
        Me.Sizeheight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Sizeheight.TextBoxAutoComplete = False
        Me.Sizeheight.TextboxBackColor = System.Drawing.Color.Empty
        Me.Sizeheight.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Sizeheight.TextEnabled = True
        Me.Sizeheight.TextForeColor = System.Drawing.Color.Empty
        Me.Sizeheight.TextMaxLength = 32767
        Me.Sizeheight.TextMultiLine = False
        Me.Sizeheight.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Sizeheight.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Sizeheight.UseSendTab = True
        '
        'Sizewidth
        '
        Me.Sizewidth.BackYesno = False
        Me.Sizewidth.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Sizewidth.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Standard
        Me.Sizewidth.ButtonEnabled = True
        Me.Sizewidth.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sizewidth.ButtonForeColor = System.Drawing.Color.Empty
        Me.Sizewidth.ButtonTitle = "Sizewidth"
        Me.Sizewidth.Code = Nothing
        Me.Sizewidth.Data = " "
        Me.Sizewidth.DataDecimal = 0
        Me.Sizewidth.DataLen = 0
        Me.Sizewidth.DataValue = 0
        Me.Sizewidth.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.Sizewidth.Location = New System.Drawing.Point(325, 507)
        Me.Sizewidth.Margin = New System.Windows.Forms.Padding(0)
        Me.Sizewidth.Name = "Sizewidth"
        Me.Sizewidth.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Sizewidth.Size = New System.Drawing.Size(310, 22)
        Me.Sizewidth.TabIndex = 17
        Me.Sizewidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Sizewidth.TextBoxAutoComplete = False
        Me.Sizewidth.TextboxBackColor = System.Drawing.Color.Empty
        Me.Sizewidth.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Sizewidth.TextEnabled = True
        Me.Sizewidth.TextForeColor = System.Drawing.Color.Empty
        Me.Sizewidth.TextMaxLength = 32767
        Me.Sizewidth.TextMultiLine = False
        Me.Sizewidth.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Sizewidth.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Sizewidth.UseSendTab = True
        '
        'Datasize
        '
        Me.Datasize.BackYesno = False
        Me.Datasize.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Datasize.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Standard
        Me.Datasize.ButtonEnabled = True
        Me.Datasize.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datasize.ButtonForeColor = System.Drawing.Color.Empty
        Me.Datasize.ButtonTitle = "Datasize"
        Me.Datasize.Code = Nothing
        Me.Datasize.Data = Nothing
        Me.Datasize.DataDecimal = 0
        Me.Datasize.DataLen = 0
        Me.Datasize.DataValue = 0
        Me.Datasize.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.Datasize.Location = New System.Drawing.Point(3, 531)
        Me.Datasize.Margin = New System.Windows.Forms.Padding(0)
        Me.Datasize.Name = "Datasize"
        Me.Datasize.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Datasize.Size = New System.Drawing.Size(310, 22)
        Me.Datasize.TabIndex = 15
        Me.Datasize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Datasize.TextBoxAutoComplete = False
        Me.Datasize.TextboxBackColor = System.Drawing.Color.Empty
        Me.Datasize.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Datasize.TextEnabled = True
        Me.Datasize.TextForeColor = System.Drawing.Color.Empty
        Me.Datasize.TextMaxLength = 32767
        Me.Datasize.TextMultiLine = False
        Me.Datasize.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Datasize.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Datasize.UseSendTab = True
        '
        'Projectname
        '
        Me.Projectname.BackYesno = False
        Me.Projectname.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Projectname.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Standard
        Me.Projectname.ButtonEnabled = True
        Me.Projectname.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Projectname.ButtonForeColor = System.Drawing.Color.Empty
        Me.Projectname.ButtonTitle = "Projectname"
        Me.Projectname.Code = Nothing
        Me.Projectname.Data = " "
        Me.Projectname.DataDecimal = 0
        Me.Projectname.DataLen = 0
        Me.Projectname.DataValue = 0
        Me.Projectname.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.Projectname.Location = New System.Drawing.Point(3, 483)
        Me.Projectname.Margin = New System.Windows.Forms.Padding(0)
        Me.Projectname.Name = "Projectname"
        Me.Projectname.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Projectname.Size = New System.Drawing.Size(310, 22)
        Me.Projectname.TabIndex = 13
        Me.Projectname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Projectname.TextBoxAutoComplete = False
        Me.Projectname.TextboxBackColor = System.Drawing.Color.Empty
        Me.Projectname.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Projectname.TextEnabled = True
        Me.Projectname.TextForeColor = System.Drawing.Color.Empty
        Me.Projectname.TextMaxLength = 32767
        Me.Projectname.TextMultiLine = False
        Me.Projectname.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Projectname.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Projectname.UseSendTab = True
        '
        'PeaceButton1
        '
        Me.PeaceButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PeaceButton1.Code = Nothing
        Me.PeaceButton1.Data = Nothing
        Me.PeaceButton1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceButton1.Location = New System.Drawing.Point(3, 508)
        Me.PeaceButton1.Name = "PeaceButton1"
        Me.PeaceButton1.Size = New System.Drawing.Size(121, 20)
        Me.PeaceButton1.TabIndex = 23
        Me.PeaceButton1.Text = "Datatype"
        Me.PeaceButton1.UseVisualStyleBackColor = False
        '
        'txt_NAME
        '
        Me.txt_NAME.BackYesno = False
        Me.txt_NAME.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_NAME.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Standard
        Me.txt_NAME.ButtonEnabled = True
        Me.txt_NAME.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NAME.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_NAME.ButtonTitle = "Name"
        Me.txt_NAME.Code = Nothing
        Me.txt_NAME.Data = " "
        Me.txt_NAME.DataDecimal = 0
        Me.txt_NAME.DataLen = 0
        Me.txt_NAME.DataValue = 0
        Me.txt_NAME.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_NAME.Location = New System.Drawing.Point(8, 8)
        Me.txt_NAME.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_NAME.Name = "txt_NAME"
        Me.txt_NAME.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_NAME.Size = New System.Drawing.Size(310, 22)
        Me.txt_NAME.TabIndex = 25
        Me.txt_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_NAME.TextBoxAutoComplete = False
        Me.txt_NAME.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_NAME.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_NAME.TextEnabled = True
        Me.txt_NAME.TextForeColor = System.Drawing.Color.Empty
        Me.txt_NAME.TextMaxLength = 32767
        Me.txt_NAME.TextMultiLine = False
        Me.txt_NAME.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_NAME.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_NAME.UseSendTab = True
        '
        'PeaceButton2
        '
        Me.PeaceButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PeaceButton2.Code = Nothing
        Me.PeaceButton2.Data = Nothing
        Me.PeaceButton2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PeaceButton2.Location = New System.Drawing.Point(328, 5)
        Me.PeaceButton2.Name = "PeaceButton2"
        Me.PeaceButton2.Size = New System.Drawing.Size(640, 28)
        Me.PeaceButton2.TabIndex = 45
        Me.PeaceButton2.Text = "SREACH(&S)"
        Me.PeaceButton2.UseVisualStyleBackColor = False
        '
        'PeaceButton3
        '
        Me.PeaceButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PeaceButton3.Code = Nothing
        Me.PeaceButton3.Data = Nothing
        Me.PeaceButton3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceButton3.Location = New System.Drawing.Point(328, 432)
        Me.PeaceButton3.Name = "PeaceButton3"
        Me.PeaceButton3.Size = New System.Drawing.Size(121, 20)
        Me.PeaceButton3.TabIndex = 46
        Me.PeaceButton3.Text = "TextAlign"
        Me.PeaceButton3.UseVisualStyleBackColor = False
        '
        'PeaceButton4
        '
        Me.PeaceButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PeaceButton4.Code = Nothing
        Me.PeaceButton4.Data = Nothing
        Me.PeaceButton4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceButton4.Location = New System.Drawing.Point(328, 456)
        Me.PeaceButton4.Name = "PeaceButton4"
        Me.PeaceButton4.Size = New System.Drawing.Size(121, 20)
        Me.PeaceButton4.TabIndex = 48
        Me.PeaceButton4.Text = "HorizonAlign"
        Me.PeaceButton4.UseVisualStyleBackColor = False
        '
        'PeaceButton5
        '
        Me.PeaceButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PeaceButton5.Code = Nothing
        Me.PeaceButton5.Data = Nothing
        Me.PeaceButton5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceButton5.Location = New System.Drawing.Point(328, 481)
        Me.PeaceButton5.Name = "PeaceButton5"
        Me.PeaceButton5.Size = New System.Drawing.Size(121, 20)
        Me.PeaceButton5.TabIndex = 50
        Me.PeaceButton5.Text = "VericalAlign"
        Me.PeaceButton5.UseVisualStyleBackColor = False
        '
        'VerticalAlign
        '
        Me.VerticalAlign.DTDec = 0
        Me.VerticalAlign.DTLen = 0
        Me.VerticalAlign.DTValue = 0
        Me.VerticalAlign.FormattingEnabled = True
        Me.VerticalAlign.InSelected = -1
        Me.VerticalAlign.Items.AddRange(New Object() {"General", "Top", "Center", "Bottom", "Justify", "Distribute"})
        Me.VerticalAlign.Location = New System.Drawing.Point(451, 481)
        Me.VerticalAlign.Name = "VerticalAlign"
        Me.VerticalAlign.NoClear = False
        Me.VerticalAlign.Size = New System.Drawing.Size(184, 20)
        Me.VerticalAlign.TabIndex = 51
        '
        'HorizonAlign
        '
        Me.HorizonAlign.DTDec = 0
        Me.HorizonAlign.DTLen = 0
        Me.HorizonAlign.DTValue = 0
        Me.HorizonAlign.FormattingEnabled = True
        Me.HorizonAlign.InSelected = -1
        Me.HorizonAlign.Items.AddRange(New Object() {"General", "Left", "Center", "Right", "Justify", "Distribute"})
        Me.HorizonAlign.Location = New System.Drawing.Point(451, 456)
        Me.HorizonAlign.Name = "HorizonAlign"
        Me.HorizonAlign.NoClear = False
        Me.HorizonAlign.Size = New System.Drawing.Size(184, 20)
        Me.HorizonAlign.TabIndex = 49
        '
        'TextAlign
        '
        Me.TextAlign.DTDec = 0
        Me.TextAlign.DTLen = 0
        Me.TextAlign.DTValue = 0
        Me.TextAlign.FormattingEnabled = True
        Me.TextAlign.InSelected = -1
        Me.TextAlign.Items.AddRange(New Object() {"Left", "Right", "Center"})
        Me.TextAlign.Location = New System.Drawing.Point(451, 432)
        Me.TextAlign.Name = "TextAlign"
        Me.TextAlign.NoClear = False
        Me.TextAlign.Size = New System.Drawing.Size(184, 20)
        Me.TextAlign.TabIndex = 47
        '
        'Datatype
        '
        Me.Datatype.DTDec = 0
        Me.Datatype.DTLen = 0
        Me.Datatype.DTValue = 0
        Me.Datatype.FormattingEnabled = True
        Me.Datatype.InSelected = -1
        Me.Datatype.Items.AddRange(New Object() {"Text", "Number", "Button", "Combo", "Checkbox", "Date", "TextConvert"})
        Me.Datatype.Location = New System.Drawing.Point(127, 508)
        Me.Datatype.Name = "Datatype"
        Me.Datatype.NoClear = False
        Me.Datatype.Size = New System.Drawing.Size(184, 20)
        Me.Datatype.TabIndex = 24
        '
        'Frame4
        '
        Me.Frame4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Frame4.Controls.Add(Me.cmd_DEL)
        Me.Frame4.Controls.Add(Me.cmd_Cancel)
        Me.Frame4.Controls.Add(Me.cmd_OK)
        Me.Frame4.Location = New System.Drawing.Point(3, 582)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Size = New System.Drawing.Size(969, 37)
        Me.Frame4.TabIndex = 22
        '
        'cmd_DEL
        '
        Me.cmd_DEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_DEL.Code = Nothing
        Me.cmd_DEL.Data = Nothing
        Me.cmd_DEL.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_DEL.Image = CType(resources.GetObject("cmd_DEL.Image"), System.Drawing.Image)
        Me.cmd_DEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_DEL.Location = New System.Drawing.Point(6, 1)
        Me.cmd_DEL.Margin = New System.Windows.Forms.Padding(0)
        Me.cmd_DEL.Name = "cmd_DEL"
        Me.cmd_DEL.Size = New System.Drawing.Size(164, 32)
        Me.cmd_DEL.TabIndex = 44
        Me.cmd_DEL.Text = "DELETE(&X)"
        Me.cmd_DEL.UseVisualStyleBackColor = False
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmd_Cancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Image = CType(resources.GetObject("cmd_Cancel.Image"), System.Drawing.Image)
        Me.cmd_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Cancel.Location = New System.Drawing.Point(798, 1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(161, 33)
        Me.cmd_Cancel.TabIndex = 42
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'cmd_OK
        '
        Me.cmd_OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Image = CType(resources.GetObject("cmd_OK.Image"), System.Drawing.Image)
        Me.cmd_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_OK.Location = New System.Drawing.Point(630, 3)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(161, 29)
        Me.cmd_OK.TabIndex = 43
        Me.cmd_OK.Text = "SAVE(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'DataLock
        '
        Me.DataLock.DTDec = 0
        Me.DataLock.DTLen = 0
        Me.DataLock.DTValue = 0
        Me.DataLock.FormattingEnabled = True
        Me.DataLock.InSelected = -1
        Me.DataLock.Items.AddRange(New Object() {"False", "True"})
        Me.DataLock.Location = New System.Drawing.Point(129, 556)
        Me.DataLock.Name = "DataLock"
        Me.DataLock.NoClear = False
        Me.DataLock.Size = New System.Drawing.Size(184, 20)
        Me.DataLock.TabIndex = 53
        '
        'DataLock1
        '
        Me.DataLock1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataLock1.Code = Nothing
        Me.DataLock1.Data = Nothing
        Me.DataLock1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.DataLock1.Location = New System.Drawing.Point(6, 556)
        Me.DataLock1.Name = "DataLock1"
        Me.DataLock1.Size = New System.Drawing.Size(121, 20)
        Me.DataLock1.TabIndex = 52
        Me.DataLock1.Text = "Datalock"
        Me.DataLock1.UseVisualStyleBackColor = False
        '
        'PeaceButton7
        '
        Me.PeaceButton7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PeaceButton7.Code = Nothing
        Me.PeaceButton7.Data = Nothing
        Me.PeaceButton7.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceButton7.Location = New System.Drawing.Point(328, 556)
        Me.PeaceButton7.Name = "PeaceButton7"
        Me.PeaceButton7.Size = New System.Drawing.Size(121, 20)
        Me.PeaceButton7.TabIndex = 54
        Me.PeaceButton7.Text = "DataHide"
        Me.PeaceButton7.UseVisualStyleBackColor = False
        '
        'DataHide
        '
        Me.DataHide.DTDec = 0
        Me.DataHide.DTLen = 0
        Me.DataHide.DTValue = 0
        Me.DataHide.FormattingEnabled = True
        Me.DataHide.InSelected = -1
        Me.DataHide.Items.AddRange(New Object() {"False", "True"})
        Me.DataHide.Location = New System.Drawing.Point(451, 557)
        Me.DataHide.Name = "DataHide"
        Me.DataHide.NoClear = False
        Me.DataHide.Size = New System.Drawing.Size(184, 20)
        Me.DataHide.TabIndex = 55
        '
        'P_SPREAD_SETUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(982, 623)
        Me.Controls.Add(Me.DataHide)
        Me.Controls.Add(Me.PeaceButton7)
        Me.Controls.Add(Me.DataLock)
        Me.Controls.Add(Me.DataLock1)
        Me.Controls.Add(Me.VerticalAlign)
        Me.Controls.Add(Me.PeaceButton5)
        Me.Controls.Add(Me.HorizonAlign)
        Me.Controls.Add(Me.PeaceButton4)
        Me.Controls.Add(Me.TextAlign)
        Me.Controls.Add(Me.PeaceButton3)
        Me.Controls.Add(Me.PeaceButton2)
        Me.Controls.Add(Me.txt_NAME)
        Me.Controls.Add(Me.Datatype)
        Me.Controls.Add(Me.PeaceButton1)
        Me.Controls.Add(Me.Frame4)
        Me.Controls.Add(Me.Fontbold)
        Me.Controls.Add(Me.Fontsize)
        Me.Controls.Add(Me.Fontname)
        Me.Controls.Add(Me.Sizeheight)
        Me.Controls.Add(Me.Sizewidth)
        Me.Controls.Add(Me.Datasize)
        Me.Controls.Add(Me.Projectname)
        Me.Controls.Add(Me.Fontstyle)
        Me.Controls.Add(Me.Forecolor_)
        Me.Controls.Add(Me.Backcolor_)
        Me.Controls.Add(Me.Datadecimal)
        Me.Controls.Add(Me.Itemnamesimple)
        Me.Controls.Add(Me.Itemname)
        Me.Controls.Add(Me.Itemcode)
        Me.Controls.Add(Me.Vs1)
        Me.Name = "P_SPREAD_SETUP"
        Me.Text = "SPREAD_SETUP"
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Vs1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents Itemcode As PSMGlobal.SelectLabelSearch
    Friend WithEvents Itemname As PSMGlobal.SelectLabelSearch
    Friend WithEvents Itemnamesimple As PSMGlobal.SelectLabelSearch
    Friend WithEvents Datadecimal As PSMGlobal.SelectLabelSearch
    Friend WithEvents Fontstyle As PSMGlobal.SelectLabelSearch
    Friend WithEvents Forecolor_ As PSMGlobal.SelectLabelSearch
    Friend WithEvents Backcolor_ As PSMGlobal.SelectLabelSearch
    Friend WithEvents Fontbold As PSMGlobal.SelectLabelSearch
    Friend WithEvents Fontsize As PSMGlobal.SelectLabelSearch
    Friend WithEvents Fontname As PSMGlobal.SelectLabelSearch
    Friend WithEvents Sizeheight As PSMGlobal.SelectLabelSearch
    Friend WithEvents Sizewidth As PSMGlobal.SelectLabelSearch
    Friend WithEvents Datasize As PSMGlobal.SelectLabelSearch
    Friend WithEvents Projectname As PSMGlobal.SelectLabelSearch
    Friend WithEvents Frame4 As PSMGlobal.PeacePanel
    Friend WithEvents cmd_DEL As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents PeaceButton1 As PSMGlobal.PeaceButton
    Friend WithEvents Datatype As PSMGlobal.PeaceCombobox
    Friend WithEvents txt_NAME As PSMGlobal.SelectLabelSearch
    Friend WithEvents PeaceButton2 As PSMGlobal.PeaceButton
    Friend WithEvents TextAlign As PSMGlobal.PeaceCombobox
    Friend WithEvents PeaceButton3 As PSMGlobal.PeaceButton
    Friend WithEvents HorizonAlign As PSMGlobal.PeaceCombobox
    Friend WithEvents PeaceButton4 As PSMGlobal.PeaceButton
    Friend WithEvents VerticalAlign As PSMGlobal.PeaceCombobox
    Friend WithEvents PeaceButton5 As PSMGlobal.PeaceButton
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents DataLock As PSMGlobal.PeaceCombobox
    Friend WithEvents DataLock1 As PSMGlobal.PeaceButton
    Friend WithEvents PeaceButton7 As PSMGlobal.PeaceButton
    Friend WithEvents DataHide As PSMGlobal.PeaceCombobox
    Public WithEvents Vs1 As PSMGlobal.PeaceFarpoint
End Class
