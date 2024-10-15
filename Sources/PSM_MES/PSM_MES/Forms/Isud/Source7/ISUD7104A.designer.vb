<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD7104A
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
        Dim Vs1_InputMapWhenFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim Vs1_InputMapWhenFocusedSingleSelect As FarPoint.Win.Spread.InputMap
        Dim Vs1_InputMapWhenAncestorOfFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim Vs1_InputMapWhenAncestorOfFocusedSingleSelect As FarPoint.Win.Spread.InputMap
        Dim TextCellType5 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Me.Frame1 = New PSMGlobal.PeacePanel(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Vs1 = New PSMGlobal.PeaceFarpoint()
        Me.Vs1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.FlowLayoutPanel2 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_CustomerCode = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_SizeRange = New PSMGlobal.SelectLabelText()
        Me.tit_Use = New PSMGlobal.PeaceLabel(Me.components)
        Me.Panel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_CheckUse2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckUse1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.txt_SizeRangeName = New PSMGlobal.SelectLabelText()
        Me.txt_SizeRangeSimpleName = New PSMGlobal.SelectLabelText()
        Me.txt_SizeAverage01 = New PSMGlobal.SelectLabelText()
        Me.txt_SizeAverage02 = New PSMGlobal.SelectLabelText()
        Me.txt_SizeAverage03 = New PSMGlobal.SelectLabelText()
        Me.txt_cdSeason = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdGender = New PSMGlobal.SelectPeaceHLPButton()
        Vs1_InputMapWhenFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenFocusedSingleSelect = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenFocusedSingleSelect.Parent = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
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
        Me.Frame1.Size = New System.Drawing.Size(709, 382)
        Me.Frame1.TabIndex = 4
        Me.Frame1.Tag = ""
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Vs1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(705, 378)
        Me.TableLayoutPanel1.TabIndex = 103
        '
        'Vs1
        '
        Me.Vs1.AccessibleDescription = "Vs2, Sheet1, Row 0, Column 0, "
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
        Me.Vs1.InsChk = True
        Me.Vs1.Location = New System.Drawing.Point(3, 127)
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
        Me.Vs1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.Vs1_Sheet1})
        Me.Vs1.Size = New System.Drawing.Size(699, 248)
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
        Vs1_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Vs1_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnWrap)
        Vs1_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
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
        Vs1_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnWrap)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
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
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
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
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.FlowLayoutPanel2.Code = ""
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_CustomerCode)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_SizeRange)
        Me.FlowLayoutPanel2.Controls.Add(Me.tit_Use)
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel5)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_SizeRangeName)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_SizeRangeSimpleName)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_SizeAverage01)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_SizeAverage02)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_SizeAverage03)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_cdSeason)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_cdGender)
        Me.FlowLayoutPanel2.Data = ""
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(699, 118)
        Me.FlowLayoutPanel2.TabIndex = 102
        Me.FlowLayoutPanel2.Tag = ""
        '
        'txt_CustomerCode
        '
        Me.txt_CustomerCode.BackYesno = False
        Me.txt_CustomerCode.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_CustomerCode.ButtonEnabled = True
        Me.txt_CustomerCode.ButtonFont = Nothing
        Me.txt_CustomerCode.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_CustomerCode.ButtonName = "Gender"
        Me.txt_CustomerCode.ButtonTitle = "Customer"
        Me.txt_CustomerCode.Code = ""
        Me.txt_CustomerCode.Data = ""
        Me.txt_CustomerCode.DataDecimal = 0
        Me.txt_CustomerCode.DataLen = 0
        Me.txt_CustomerCode.DataValue = 1
        Me.txt_CustomerCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_CustomerCode.Location = New System.Drawing.Point(1, 1)
        Me.txt_CustomerCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_CustomerCode.Name = "txt_CustomerCode"
        Me.txt_CustomerCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CustomerCode.Size = New System.Drawing.Size(346, 27)
        Me.txt_CustomerCode.TabIndex = 0
        Me.txt_CustomerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_CustomerCode.TextBoxAutoComplete = False
        Me.txt_CustomerCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_CustomerCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_CustomerCode.TextEnabled = False
        Me.txt_CustomerCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_CustomerCode.TextMaxLength = 32767
        Me.txt_CustomerCode.TextMultiLine = False
        Me.txt_CustomerCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CustomerCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_CustomerCode.UseSendTab = True
        '
        'txt_SizeRange
        '
        Me.txt_SizeRange.BackYesno = False
        Me.txt_SizeRange.ButtonTitle = Nothing
        Me.txt_SizeRange.Code = Nothing
        Me.txt_SizeRange.Data = ""
        Me.txt_SizeRange.DataDecimal = 0
        Me.txt_SizeRange.DataLen = 0
        Me.txt_SizeRange.DataValue = 0
        Me.txt_SizeRange.FormatDecimal = 0
        Me.txt_SizeRange.FormatValue = False
        Me.txt_SizeRange.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_SizeRange.LableEnabled = True
        Me.txt_SizeRange.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_SizeRange.LableForeColor = System.Drawing.Color.Black
        Me.txt_SizeRange.LableTitle = "Size Range"
        Me.txt_SizeRange.Layoutpercent = New Decimal(New Integer() {508, 0, 0, 196608})
        Me.txt_SizeRange.Location = New System.Drawing.Point(349, 1)
        Me.txt_SizeRange.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_SizeRange.Name = "txt_SizeRange"
        Me.txt_SizeRange.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_SizeRange.Size = New System.Drawing.Size(234, 26)
        Me.txt_SizeRange.TabIndex = 1
        Me.txt_SizeRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_SizeRange.TextBoxAutoComplete = False
        Me.txt_SizeRange.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_SizeRange.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_SizeRange.TextEnabled = True
        Me.txt_SizeRange.TextForeColor = System.Drawing.Color.Empty
        Me.txt_SizeRange.TextMaxLength = 32767
        Me.txt_SizeRange.TextMultiLine = False
        Me.txt_SizeRange.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_SizeRange.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_SizeRange.UseSendTab = True
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
        Me.tit_Use.Location = New System.Drawing.Point(349, 87)
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
        Me.Panel5.ColumnCount = 2
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.Controls.Add(Me.rad_CheckUse2, 1, 0)
        Me.Panel5.Controls.Add(Me.rad_CheckUse1, 0, 0)
        Me.Panel5.Location = New System.Drawing.Point(467, 87)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(1, 1, 200, 1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.RowCount = 1
        Me.Panel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.Size = New System.Drawing.Size(228, 27)
        Me.Panel5.TabIndex = 10
        '
        'rad_CheckUse2
        '
        Me.rad_CheckUse2.AutoSize = True
        Me.rad_CheckUse2.ButtonTitle = Nothing
        Me.rad_CheckUse2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckUse2.Location = New System.Drawing.Point(117, 4)
        Me.rad_CheckUse2.Name = "rad_CheckUse2"
        Me.rad_CheckUse2.Size = New System.Drawing.Size(41, 18)
        Me.rad_CheckUse2.TabIndex = 1
        Me.rad_CheckUse2.TabStop = True
        Me.rad_CheckUse2.Text = "No"
        Me.rad_CheckUse2.UseVisualStyleBackColor = True
        '
        'rad_CheckUse1
        '
        Me.rad_CheckUse1.AutoSize = True
        Me.rad_CheckUse1.ButtonTitle = Nothing
        Me.rad_CheckUse1.Checked = True
        Me.rad_CheckUse1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckUse1.Location = New System.Drawing.Point(4, 4)
        Me.rad_CheckUse1.Name = "rad_CheckUse1"
        Me.rad_CheckUse1.Size = New System.Drawing.Size(45, 18)
        Me.rad_CheckUse1.TabIndex = 0
        Me.rad_CheckUse1.TabStop = True
        Me.rad_CheckUse1.Text = "Yes"
        Me.rad_CheckUse1.UseVisualStyleBackColor = True
        '
        'txt_SizeRangeName
        '
        Me.txt_SizeRangeName.BackYesno = False
        Me.txt_SizeRangeName.ButtonTitle = Nothing
        Me.txt_SizeRangeName.Code = Nothing
        Me.txt_SizeRangeName.Data = ""
        Me.txt_SizeRangeName.DataDecimal = 0
        Me.txt_SizeRangeName.DataLen = 0
        Me.txt_SizeRangeName.DataValue = 0
        Me.txt_SizeRangeName.FormatDecimal = 0
        Me.txt_SizeRangeName.FormatValue = False
        Me.txt_SizeRangeName.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_SizeRangeName.LableEnabled = True
        Me.txt_SizeRangeName.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_SizeRangeName.LableForeColor = System.Drawing.Color.Empty
        Me.txt_SizeRangeName.LableTitle = "Size Range Name"
        Me.txt_SizeRangeName.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_SizeRangeName.Location = New System.Drawing.Point(1, 30)
        Me.txt_SizeRangeName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_SizeRangeName.Name = "txt_SizeRangeName"
        Me.txt_SizeRangeName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_SizeRangeName.Size = New System.Drawing.Size(346, 26)
        Me.txt_SizeRangeName.TabIndex = 2
        Me.txt_SizeRangeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_SizeRangeName.TextBoxAutoComplete = False
        Me.txt_SizeRangeName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_SizeRangeName.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_SizeRangeName.TextEnabled = True
        Me.txt_SizeRangeName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_SizeRangeName.TextMaxLength = 32767
        Me.txt_SizeRangeName.TextMultiLine = False
        Me.txt_SizeRangeName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_SizeRangeName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_SizeRangeName.UseSendTab = True
        '
        'txt_SizeRangeSimpleName
        '
        Me.txt_SizeRangeSimpleName.BackYesno = False
        Me.txt_SizeRangeSimpleName.ButtonTitle = Nothing
        Me.txt_SizeRangeSimpleName.Code = Nothing
        Me.txt_SizeRangeSimpleName.Data = ""
        Me.txt_SizeRangeSimpleName.DataDecimal = 0
        Me.txt_SizeRangeSimpleName.DataLen = 0
        Me.txt_SizeRangeSimpleName.DataValue = 0
        Me.txt_SizeRangeSimpleName.FormatDecimal = 0
        Me.txt_SizeRangeSimpleName.FormatValue = False
        Me.txt_SizeRangeSimpleName.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_SizeRangeSimpleName.LableEnabled = True
        Me.txt_SizeRangeSimpleName.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_SizeRangeSimpleName.LableForeColor = System.Drawing.Color.Empty
        Me.txt_SizeRangeSimpleName.LableTitle = "Acronym"
        Me.txt_SizeRangeSimpleName.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_SizeRangeSimpleName.Location = New System.Drawing.Point(349, 30)
        Me.txt_SizeRangeSimpleName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_SizeRangeSimpleName.Name = "txt_SizeRangeSimpleName"
        Me.txt_SizeRangeSimpleName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_SizeRangeSimpleName.Size = New System.Drawing.Size(346, 27)
        Me.txt_SizeRangeSimpleName.TabIndex = 3
        Me.txt_SizeRangeSimpleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_SizeRangeSimpleName.TextBoxAutoComplete = False
        Me.txt_SizeRangeSimpleName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_SizeRangeSimpleName.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_SizeRangeSimpleName.TextEnabled = True
        Me.txt_SizeRangeSimpleName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_SizeRangeSimpleName.TextMaxLength = 32767
        Me.txt_SizeRangeSimpleName.TextMultiLine = False
        Me.txt_SizeRangeSimpleName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_SizeRangeSimpleName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_SizeRangeSimpleName.UseSendTab = True
        '
        'txt_SizeAverage01
        '
        Me.txt_SizeAverage01.BackYesno = False
        Me.txt_SizeAverage01.ButtonTitle = Nothing
        Me.txt_SizeAverage01.Code = Nothing
        Me.txt_SizeAverage01.Data = ""
        Me.txt_SizeAverage01.DataDecimal = 0
        Me.txt_SizeAverage01.DataLen = 0
        Me.txt_SizeAverage01.DataValue = 0
        Me.txt_SizeAverage01.FormatDecimal = 0
        Me.txt_SizeAverage01.FormatValue = False
        Me.txt_SizeAverage01.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_SizeAverage01.LableEnabled = True
        Me.txt_SizeAverage01.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_SizeAverage01.LableForeColor = System.Drawing.Color.Empty
        Me.txt_SizeAverage01.LableTitle = "AVG 1"
        Me.txt_SizeAverage01.Layoutpercent = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txt_SizeAverage01.Location = New System.Drawing.Point(1, 58)
        Me.txt_SizeAverage01.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_SizeAverage01.Name = "txt_SizeAverage01"
        Me.txt_SizeAverage01.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_SizeAverage01.Size = New System.Drawing.Size(116, 26)
        Me.txt_SizeAverage01.TabIndex = 4
        Me.txt_SizeAverage01.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_SizeAverage01.TextBoxAutoComplete = False
        Me.txt_SizeAverage01.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_SizeAverage01.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_SizeAverage01.TextEnabled = True
        Me.txt_SizeAverage01.TextForeColor = System.Drawing.Color.Empty
        Me.txt_SizeAverage01.TextMaxLength = 32767
        Me.txt_SizeAverage01.TextMultiLine = False
        Me.txt_SizeAverage01.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_SizeAverage01.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_SizeAverage01.UseSendTab = True
        '
        'txt_SizeAverage02
        '
        Me.txt_SizeAverage02.BackYesno = False
        Me.txt_SizeAverage02.ButtonTitle = Nothing
        Me.txt_SizeAverage02.Code = Nothing
        Me.txt_SizeAverage02.Data = ""
        Me.txt_SizeAverage02.DataDecimal = 0
        Me.txt_SizeAverage02.DataLen = 0
        Me.txt_SizeAverage02.DataValue = 0
        Me.txt_SizeAverage02.FormatDecimal = 0
        Me.txt_SizeAverage02.FormatValue = False
        Me.txt_SizeAverage02.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_SizeAverage02.LableEnabled = True
        Me.txt_SizeAverage02.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_SizeAverage02.LableForeColor = System.Drawing.Color.Empty
        Me.txt_SizeAverage02.LableTitle = "AVG 2"
        Me.txt_SizeAverage02.Layoutpercent = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txt_SizeAverage02.Location = New System.Drawing.Point(120, 58)
        Me.txt_SizeAverage02.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_SizeAverage02.Name = "txt_SizeAverage02"
        Me.txt_SizeAverage02.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_SizeAverage02.Size = New System.Drawing.Size(114, 26)
        Me.txt_SizeAverage02.TabIndex = 5
        Me.txt_SizeAverage02.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_SizeAverage02.TextBoxAutoComplete = False
        Me.txt_SizeAverage02.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_SizeAverage02.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_SizeAverage02.TextEnabled = True
        Me.txt_SizeAverage02.TextForeColor = System.Drawing.Color.Empty
        Me.txt_SizeAverage02.TextMaxLength = 32767
        Me.txt_SizeAverage02.TextMultiLine = False
        Me.txt_SizeAverage02.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_SizeAverage02.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_SizeAverage02.UseSendTab = True
        '
        'txt_SizeAverage03
        '
        Me.txt_SizeAverage03.BackYesno = False
        Me.txt_SizeAverage03.ButtonTitle = Nothing
        Me.txt_SizeAverage03.Code = Nothing
        Me.txt_SizeAverage03.Data = ""
        Me.txt_SizeAverage03.DataDecimal = 0
        Me.txt_SizeAverage03.DataLen = 0
        Me.txt_SizeAverage03.DataValue = 0
        Me.txt_SizeAverage03.FormatDecimal = 0
        Me.txt_SizeAverage03.FormatValue = False
        Me.txt_SizeAverage03.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_SizeAverage03.LableEnabled = True
        Me.txt_SizeAverage03.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_SizeAverage03.LableForeColor = System.Drawing.Color.Empty
        Me.txt_SizeAverage03.LableTitle = "AVG 3"
        Me.txt_SizeAverage03.Layoutpercent = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txt_SizeAverage03.Location = New System.Drawing.Point(236, 58)
        Me.txt_SizeAverage03.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_SizeAverage03.Name = "txt_SizeAverage03"
        Me.txt_SizeAverage03.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_SizeAverage03.Size = New System.Drawing.Size(111, 26)
        Me.txt_SizeAverage03.TabIndex = 6
        Me.txt_SizeAverage03.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_SizeAverage03.TextBoxAutoComplete = False
        Me.txt_SizeAverage03.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_SizeAverage03.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_SizeAverage03.TextEnabled = True
        Me.txt_SizeAverage03.TextForeColor = System.Drawing.Color.Empty
        Me.txt_SizeAverage03.TextMaxLength = 32767
        Me.txt_SizeAverage03.TextMultiLine = False
        Me.txt_SizeAverage03.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_SizeAverage03.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_SizeAverage03.UseSendTab = True
        '
        'txt_cdSeason
        '
        Me.txt_cdSeason.BackYesno = False
        Me.txt_cdSeason.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSeason.ButtonEnabled = True
        Me.txt_cdSeason.ButtonFont = Nothing
        Me.txt_cdSeason.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSeason.ButtonName = "Season"
        Me.txt_cdSeason.ButtonTitle = "Season"
        Me.txt_cdSeason.Code = ""
        Me.txt_cdSeason.Data = ""
        Me.txt_cdSeason.DataDecimal = 0
        Me.txt_cdSeason.DataLen = 0
        Me.txt_cdSeason.DataValue = 1
        Me.txt_cdSeason.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdSeason.Location = New System.Drawing.Point(3, 86)
        Me.txt_cdSeason.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSeason.Name = "txt_cdSeason"
        Me.txt_cdSeason.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSeason.Size = New System.Drawing.Size(344, 27)
        Me.txt_cdSeason.TabIndex = 8
        Me.txt_cdSeason.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSeason.TextBoxAutoComplete = False
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
        'txt_cdGender
        '
        Me.txt_cdGender.BackYesno = False
        Me.txt_cdGender.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdGender.ButtonEnabled = True
        Me.txt_cdGender.ButtonFont = Nothing
        Me.txt_cdGender.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdGender.ButtonName = "Gender"
        Me.txt_cdGender.ButtonTitle = "Gender"
        Me.txt_cdGender.Code = ""
        Me.txt_cdGender.Data = ""
        Me.txt_cdGender.DataDecimal = 0
        Me.txt_cdGender.DataLen = 0
        Me.txt_cdGender.DataValue = 1
        Me.txt_cdGender.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdGender.Location = New System.Drawing.Point(349, 58)
        Me.txt_cdGender.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdGender.Name = "txt_cdGender"
        Me.txt_cdGender.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdGender.Size = New System.Drawing.Size(346, 27)
        Me.txt_cdGender.TabIndex = 7
        Me.txt_cdGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdGender.TextBoxAutoComplete = False
        Me.txt_cdGender.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdGender.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdGender.TextEnabled = True
        Me.txt_cdGender.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdGender.TextMaxLength = 32767
        Me.txt_cdGender.TextMultiLine = False
        Me.txt_cdGender.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdGender.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdGender.UseSendTab = True
        '
        'ISUD7104A
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(709, 420)
        Me.Controls.Add(Me.Frame1)
        Me.DoubleBuffered = True
        Me.Name = "ISUD7104A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIZE RANGE CODE PROCESSING (ISUD7104A)"
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
    Friend WithEvents Vs1_Sheet1 As FarPoint.Win.Spread.SheetView
    Public WithEvents Vs1 As PSMGlobal.PeaceFarpoint
    Friend WithEvents FlowLayoutPanel2 As PSMGlobal.PeacePanel
    Friend WithEvents txt_SizeRange As PSMGlobal.SelectLabelText
    Friend WithEvents tit_Use As PSMGlobal.PeaceLabel
    Friend WithEvents Panel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_CheckUse2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckUse1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_SizeRangeName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_SizeRangeSimpleName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdGender As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdSeason As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_SizeAverage01 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_SizeAverage02 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_SizeAverage03 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_CustomerCode As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
