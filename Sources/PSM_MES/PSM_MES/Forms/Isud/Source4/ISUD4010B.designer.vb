<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD4010B
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Vs1 = New PSMGlobal.PeaceFarpoint()
        Me.Vs1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.FlowLayoutPanel2 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_Refresh = New PSMGlobal.PeaceButton(Me.components)
        Me.txt_QtyAverage = New PSMGlobal.SelectLabelText()
        Me.txt_QtyOrder = New PSMGlobal.SelectLabelText()
        Me.txt_cdSubProcess = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_ProdDate = New PSMGlobal.SelectPeaceCalSin()
        Me.txt_JobCard = New PSMGlobal.SelectLabelText()
        Me.tit_Use = New PSMGlobal.PeaceLabel(Me.components)
        Me.Panel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_CheckPlan4 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckPlan3 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckPlan5 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckPlan1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckPlan2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.txt_DateDeliveryD = New PSMGlobal.SelectLabelText()
        Me.txt_CustPONO = New PSMGlobal.SelectLabelText()
        Me.txt_OrderNoSeq = New PSMGlobal.SelectLabelText()
        Me.txt_OrderNo = New PSMGlobal.SelectLabelText()
        Me.txt_Article = New PSMGlobal.SelectLabelText()
        Vs1_InputMapWhenFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenFocusedSingleSelect = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedSingleSelect = New FarPoint.Win.Spread.InputMap()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlowLayoutPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Vs1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 38)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 151.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1106, 567)
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
        Me.Vs1.Location = New System.Drawing.Point(3, 154)
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
        Me.Vs1.Size = New System.Drawing.Size(1100, 410)
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
        Me.Vs1.VerticalScrollBar.TabIndex = 1
        Vs1_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Vs1_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnWrap)
        Vs1_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Me.Vs1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.Normal, Vs1_InputMapWhenFocusedNormal)
        Vs1_InputMapWhenFocusedSingleSelect.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Vs1_InputMapWhenFocusedSingleSelect.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        Me.Vs1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.SingleSelect, Vs1_InputMapWhenFocusedSingleSelect)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnWrap)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Me.Vs1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused, FarPoint.Win.Spread.OperationMode.Normal, Vs1_InputMapWhenAncestorOfFocusedNormal)
        Vs1_InputMapWhenAncestorOfFocusedSingleSelect.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Vs1_InputMapWhenAncestorOfFocusedSingleSelect.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
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
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_DateDeliveryD)
        Me.FlowLayoutPanel2.Controls.Add(Me.cmd_Refresh)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_CustPONO)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_QtyAverage)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_OrderNoSeq)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_QtyOrder)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_OrderNo)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_Article)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_cdSubProcess)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_ProdDate)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_JobCard)
        Me.FlowLayoutPanel2.Controls.Add(Me.tit_Use)
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel5)
        Me.FlowLayoutPanel2.Data = ""
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1100, 145)
        Me.FlowLayoutPanel2.TabIndex = 102
        Me.FlowLayoutPanel2.Tag = ""
        '
        'cmd_Refresh
        '
        Me.cmd_Refresh.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_Refresh.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Refresh.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.cmd_Refresh.Appearance.Options.UseBackColor = True
        Me.cmd_Refresh.Appearance.Options.UseFont = True
        Me.cmd_Refresh.Appearance.Options.UseForeColor = True
        Me.cmd_Refresh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Refresh.ButtonTitle = Nothing
        Me.cmd_Refresh.Code = Nothing
        Me.cmd_Refresh.Data = Nothing
        Me.cmd_Refresh.ImageAlign = 16
        Me.cmd_Refresh.Location = New System.Drawing.Point(239, 32)
        Me.cmd_Refresh.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_Refresh.Name = "cmd_Refresh"
        Me.cmd_Refresh.Size = New System.Drawing.Size(260, 53)
        Me.cmd_Refresh.TabIndex = 162
        Me.cmd_Refresh.Text = "Refresh Data !"
        Me.cmd_Refresh.UseVisualStyleBackColor = False
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
        Me.txt_QtyAverage.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_QtyAverage.Location = New System.Drawing.Point(501, 32)
        Me.txt_QtyAverage.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_QtyAverage.Name = "txt_QtyAverage"
        Me.txt_QtyAverage.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_QtyAverage.Size = New System.Drawing.Size(278, 26)
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
        Me.txt_QtyOrder.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_QtyOrder.Location = New System.Drawing.Point(501, 60)
        Me.txt_QtyOrder.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_QtyOrder.Name = "txt_QtyOrder"
        Me.txt_QtyOrder.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_QtyOrder.Size = New System.Drawing.Size(278, 26)
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
        'txt_cdSubProcess
        '
        Me.txt_cdSubProcess.BackYesno = False
        Me.txt_cdSubProcess.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSubProcess.ButtonEnabled = True
        Me.txt_cdSubProcess.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdSubProcess.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSubProcess.ButtonName = ""
        Me.txt_cdSubProcess.ButtonTitle = "Sub Process"
        Me.txt_cdSubProcess.Code = ""
        Me.txt_cdSubProcess.Data = ""
        Me.txt_cdSubProcess.DataDecimal = 1
        Me.txt_cdSubProcess.DataLen = 0
        Me.txt_cdSubProcess.DataValue = 1
        Me.txt_cdSubProcess.Layoutpercent = New Decimal(New Integer() {508, 0, 0, 196608})
        Me.txt_cdSubProcess.Location = New System.Drawing.Point(3, 32)
        Me.txt_cdSubProcess.Margin = New System.Windows.Forms.Padding(1, 1, 171, 1)
        Me.txt_cdSubProcess.Name = "txt_cdSubProcess"
        Me.txt_cdSubProcess.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSubProcess.Size = New System.Drawing.Size(234, 24)
        Me.txt_cdSubProcess.TabIndex = 159
        Me.txt_cdSubProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSubProcess.TextBoxAutoComplete = True
        Me.txt_cdSubProcess.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdSubProcess.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_cdSubProcess.TextEnabled = False
        Me.txt_cdSubProcess.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdSubProcess.TextMaxLength = 32767
        Me.txt_cdSubProcess.TextMultiLine = False
        Me.txt_cdSubProcess.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdSubProcess.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdSubProcess.UseSendTab = True
        '
        'txt_ProdDate
        '
        Me.txt_ProdDate.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_ProdDate.ButtonEnabled = True
        Me.txt_ProdDate.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_ProdDate.ButtonName = Nothing
        Me.txt_ProdDate.ButtonTitle = "Date Prod"
        Me.txt_ProdDate.Code = ""
        Me.txt_ProdDate.Data = "20150101"
        Me.txt_ProdDate.DataDecimal = 1
        Me.txt_ProdDate.DataLen = 0
        Me.txt_ProdDate.DataValue = 0
        Me.txt_ProdDate.FormatDecimal = 0
        Me.txt_ProdDate.FormatValue = False
        Me.txt_ProdDate.Layoutpercent = New Decimal(New Integer() {508, 0, 0, 196608})
        Me.txt_ProdDate.Location = New System.Drawing.Point(3, 59)
        Me.txt_ProdDate.Margin = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.txt_ProdDate.Name = "txt_ProdDate"
        Me.txt_ProdDate.Size = New System.Drawing.Size(234, 24)
        Me.txt_ProdDate.TabIndex = 158
        Me.txt_ProdDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_ProdDate.TextBoxAutoComplete = False
        Me.txt_ProdDate.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ProdDate.TextEnabled = True
        Me.txt_ProdDate.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ProdDate.TextMaxLength = 32767
        Me.txt_ProdDate.TextMultiLine = True
        Me.txt_ProdDate.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
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
        'txt_DateDeliveryD
        '
        Me.txt_DateDeliveryD.BackYesno = False
        Me.txt_DateDeliveryD.ButtonTitle = Nothing
        Me.txt_DateDeliveryD.Code = Nothing
        Me.txt_DateDeliveryD.Data = ""
        Me.txt_DateDeliveryD.DataDecimal = 0
        Me.txt_DateDeliveryD.DataLen = 0
        Me.txt_DateDeliveryD.DataValue = 0
        Me.txt_DateDeliveryD.Enabled = False
        Me.txt_DateDeliveryD.FormatDecimal = 0
        Me.txt_DateDeliveryD.FormatValue = False
        Me.txt_DateDeliveryD.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_DateDeliveryD.LableEnabled = True
        Me.txt_DateDeliveryD.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_DateDeliveryD.LableForeColor = System.Drawing.Color.Black
        Me.txt_DateDeliveryD.LableTitle = "PONO#/DTSP"
        Me.txt_DateDeliveryD.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_DateDeliveryD.Location = New System.Drawing.Point(501, 116)
        Me.txt_DateDeliveryD.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_DateDeliveryD.Name = "txt_DateDeliveryD"
        Me.txt_DateDeliveryD.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_DateDeliveryD.Size = New System.Drawing.Size(279, 26)
        Me.txt_DateDeliveryD.TabIndex = 142
        Me.txt_DateDeliveryD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_DateDeliveryD.TextBoxAutoComplete = False
        Me.txt_DateDeliveryD.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_DateDeliveryD.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DateDeliveryD.TextEnabled = True
        Me.txt_DateDeliveryD.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DateDeliveryD.TextMaxLength = 32767
        Me.txt_DateDeliveryD.TextMultiLine = False
        Me.txt_DateDeliveryD.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_DateDeliveryD.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_DateDeliveryD.UseSendTab = True
        '
        'txt_CustPONO
        '
        Me.txt_CustPONO.BackYesno = False
        Me.txt_CustPONO.ButtonTitle = Nothing
        Me.txt_CustPONO.Code = Nothing
        Me.txt_CustPONO.Data = ""
        Me.txt_CustPONO.DataDecimal = 0
        Me.txt_CustPONO.DataLen = 0
        Me.txt_CustPONO.DataValue = 0
        Me.txt_CustPONO.Enabled = False
        Me.txt_CustPONO.FormatDecimal = 0
        Me.txt_CustPONO.FormatValue = False
        Me.txt_CustPONO.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_CustPONO.LableEnabled = True
        Me.txt_CustPONO.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_CustPONO.LableForeColor = System.Drawing.Color.Black
        Me.txt_CustPONO.LableTitle = "SO/WI#"
        Me.txt_CustPONO.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_CustPONO.Location = New System.Drawing.Point(501, 88)
        Me.txt_CustPONO.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_CustPONO.Name = "txt_CustPONO"
        Me.txt_CustPONO.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CustPONO.Size = New System.Drawing.Size(278, 26)
        Me.txt_CustPONO.TabIndex = 141
        Me.txt_CustPONO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_CustPONO.TextBoxAutoComplete = False
        Me.txt_CustPONO.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_CustPONO.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_CustPONO.TextEnabled = True
        Me.txt_CustPONO.TextForeColor = System.Drawing.Color.Empty
        Me.txt_CustPONO.TextMaxLength = 32767
        Me.txt_CustPONO.TextMultiLine = False
        Me.txt_CustPONO.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CustPONO.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_CustPONO.UseSendTab = True
        '
        'txt_OrderNoSeq
        '
        Me.txt_OrderNoSeq.BackYesno = False
        Me.txt_OrderNoSeq.ButtonTitle = Nothing
        Me.txt_OrderNoSeq.Code = Nothing
        Me.txt_OrderNoSeq.Data = ""
        Me.txt_OrderNoSeq.DataDecimal = 0
        Me.txt_OrderNoSeq.DataLen = 0
        Me.txt_OrderNoSeq.DataValue = 0
        Me.txt_OrderNoSeq.Enabled = False
        Me.txt_OrderNoSeq.FormatDecimal = 0
        Me.txt_OrderNoSeq.FormatValue = False
        Me.txt_OrderNoSeq.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_OrderNoSeq.LableEnabled = True
        Me.txt_OrderNoSeq.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_OrderNoSeq.LableForeColor = System.Drawing.Color.Black
        Me.txt_OrderNoSeq.LableTitle = "Seq"
        Me.txt_OrderNoSeq.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_OrderNoSeq.Location = New System.Drawing.Point(781, 60)
        Me.txt_OrderNoSeq.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_OrderNoSeq.Name = "txt_OrderNoSeq"
        Me.txt_OrderNoSeq.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_OrderNoSeq.Size = New System.Drawing.Size(278, 25)
        Me.txt_OrderNoSeq.TabIndex = 140
        Me.txt_OrderNoSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_OrderNoSeq.TextBoxAutoComplete = False
        Me.txt_OrderNoSeq.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_OrderNoSeq.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_OrderNoSeq.TextEnabled = True
        Me.txt_OrderNoSeq.TextForeColor = System.Drawing.Color.Empty
        Me.txt_OrderNoSeq.TextMaxLength = 32767
        Me.txt_OrderNoSeq.TextMultiLine = False
        Me.txt_OrderNoSeq.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_OrderNoSeq.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_OrderNoSeq.UseSendTab = True
        '
        'txt_OrderNo
        '
        Me.txt_OrderNo.BackYesno = False
        Me.txt_OrderNo.ButtonTitle = Nothing
        Me.txt_OrderNo.Code = Nothing
        Me.txt_OrderNo.Data = ""
        Me.txt_OrderNo.DataDecimal = 0
        Me.txt_OrderNo.DataLen = 0
        Me.txt_OrderNo.DataValue = 0
        Me.txt_OrderNo.Enabled = False
        Me.txt_OrderNo.FormatDecimal = 0
        Me.txt_OrderNo.FormatValue = False
        Me.txt_OrderNo.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_OrderNo.LableEnabled = True
        Me.txt_OrderNo.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_OrderNo.LableForeColor = System.Drawing.Color.Black
        Me.txt_OrderNo.LableTitle = "Order No #"
        Me.txt_OrderNo.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_OrderNo.Location = New System.Drawing.Point(781, 32)
        Me.txt_OrderNo.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_OrderNo.Name = "txt_OrderNo"
        Me.txt_OrderNo.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_OrderNo.Size = New System.Drawing.Size(278, 26)
        Me.txt_OrderNo.TabIndex = 139
        Me.txt_OrderNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_OrderNo.TextBoxAutoComplete = False
        Me.txt_OrderNo.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_OrderNo.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_OrderNo.TextEnabled = True
        Me.txt_OrderNo.TextForeColor = System.Drawing.Color.Empty
        Me.txt_OrderNo.TextMaxLength = 32767
        Me.txt_OrderNo.TextMultiLine = False
        Me.txt_OrderNo.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_OrderNo.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_OrderNo.UseSendTab = True
        '
        'txt_Article
        '
        Me.txt_Article.BackYesno = False
        Me.txt_Article.ButtonTitle = "Article"
        Me.txt_Article.Code = Nothing
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
        Me.txt_Article.Location = New System.Drawing.Point(781, 88)
        Me.txt_Article.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Article.Name = "txt_Article"
        Me.txt_Article.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Article.Size = New System.Drawing.Size(278, 25)
        Me.txt_Article.TabIndex = 138
        Me.txt_Article.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Article.TextBoxAutoComplete = False
        Me.txt_Article.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Article.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Article.TextEnabled = True
        Me.txt_Article.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Article.TextMaxLength = 32767
        Me.txt_Article.TextMultiLine = False
        Me.txt_Article.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Article.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Article.UseSendTab = True
        '
        'ISUD4010B
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1106, 605)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.Name = "ISUD4010B"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JOBCARD PRODUCTION PROCESSING (ISUD4010B)"
        Me.Controls.SetChildIndex(Me.TableLayoutPanel1, 0)
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
    Public WithEvents Vs1 As PSMGlobal.PeaceFarpoint
    Friend WithEvents Vs1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents txt_cdSubProcess As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_QtyAverage As PSMGlobal.SelectLabelText
    Friend WithEvents txt_QtyOrder As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ProdDate As PSMGlobal.SelectPeaceCalSin
    Friend WithEvents cmd_Refresh As PSMGlobal.PeaceButton
    Friend WithEvents txt_DateDeliveryD As PSMGlobal.SelectLabelText
    Friend WithEvents txt_CustPONO As PSMGlobal.SelectLabelText
    Friend WithEvents txt_OrderNoSeq As PSMGlobal.SelectLabelText
    Friend WithEvents txt_OrderNo As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Article As PSMGlobal.SelectLabelText
End Class
