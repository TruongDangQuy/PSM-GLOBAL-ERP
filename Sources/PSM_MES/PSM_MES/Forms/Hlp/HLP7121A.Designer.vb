<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HLP7121A
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
        Dim NamedStyle6 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style2")
        Dim BevelBorder5 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType5 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle7 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style3")
        Dim BevelBorder6 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType6 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle8 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style1")
        Dim BevelBorder7 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType7 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle9 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style4")
        Dim BevelBorder8 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType8 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle10 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style5")
        Dim GeneralCellType2 As FarPoint.Win.Spread.CellType.GeneralCellType = New FarPoint.Win.Spread.CellType.GeneralCellType()
        Dim SpreadSkin2 As FarPoint.Win.Spread.SpreadSkin = New FarPoint.Win.Spread.SpreadSkin()
        Dim EnhancedInterfaceRenderer2 As FarPoint.Win.Spread.EnhancedInterfaceRenderer = New FarPoint.Win.Spread.EnhancedInterfaceRenderer()
        Dim EnhancedScrollBarRenderer5 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim EnhancedScrollBarRenderer6 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.VS1 = New PSMGlobal.PeaceFarpoint()
        Me.VS1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.PeacePanel2 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_Add = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.PeacePanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_cdColorBase = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_Name = New PSMGlobal.SelectLabelText()
        Me.cmd_SEARCH = New PSMGlobal.PeaceButton(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.VS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VS1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeacePanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel2.SuspendLayout()
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.VS1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PeacePanel2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PeacePanel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(592, 677)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'VS1
        '
        Me.VS1.AccessibleDescription = "VS1, Sheet1, Row 0, Column 0, "
        Me.VS1.AllowEditorReservedLocations = False
        Me.VS1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.VS1, 4)
        Me.VS1.CopyPasteChk = True
        Me.VS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VS1.FocusRenderer = EnhancedFocusIndicatorRenderer2
        Me.VS1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.VS1.HorizontalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.VS1.HorizontalScrollBar.Name = ""
        EnhancedScrollBarRenderer4.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer4.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer4.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer4.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer4.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer4.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer4.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer4.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.VS1.HorizontalScrollBar.Renderer = EnhancedScrollBarRenderer4
        Me.VS1.HorizontalScrollBar.TabIndex = 0
        Me.VS1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never
        Me.VS1.InsChk = False
        Me.VS1.Location = New System.Drawing.Point(0, 70)
        Me.VS1.Margin = New System.Windows.Forms.Padding(0)
        Me.VS1.MoveActiveOnFocus = False
        Me.VS1.Name = "VS1"
        NamedStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle6.Border = BevelBorder5
        NamedStyle6.CellType = TextCellType5
        NamedStyle6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        NamedStyle6.ForeColor = System.Drawing.Color.White
        NamedStyle6.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle6.Locked = False
        NamedStyle6.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle6.Renderer = TextCellType5
        NamedStyle6.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle6.VisualStyles = FarPoint.Win.VisualStyles.Off
        NamedStyle7.Border = BevelBorder6
        NamedStyle7.CellType = TextCellType6
        NamedStyle7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamedStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle7.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle7.Locked = False
        NamedStyle7.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle7.Renderer = TextCellType6
        NamedStyle7.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle8.Border = BevelBorder7
        NamedStyle8.CellType = TextCellType7
        NamedStyle8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamedStyle8.ForeColor = System.Drawing.Color.White
        NamedStyle8.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle8.Locked = False
        NamedStyle8.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle8.Renderer = TextCellType7
        NamedStyle8.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle8.VisualStyles = FarPoint.Win.VisualStyles.Off
        NamedStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle9.Border = BevelBorder8
        NamedStyle9.CellType = TextCellType8
        NamedStyle9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        NamedStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle9.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle9.Locked = False
        NamedStyle9.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle9.Renderer = TextCellType8
        NamedStyle9.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle10.BackColor = System.Drawing.SystemColors.Window
        NamedStyle10.CellType = GeneralCellType2
        NamedStyle10.Font = New System.Drawing.Font("Tahoma", 9.0!)
        NamedStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        NamedStyle10.Locked = False
        NamedStyle10.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle10.Renderer = GeneralCellType2
        Me.VS1.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle6, NamedStyle7, NamedStyle8, NamedStyle9, NamedStyle10})
        Me.VS1.ReportName = Nothing
        Me.VS1.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.Cells
        Me.VS1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.VS1_Sheet1})
        Me.VS1.Size = New System.Drawing.Size(592, 565)
        SpreadSkin2.ColumnFooterDefaultStyle = NamedStyle7
        SpreadSkin2.ColumnHeaderDefaultStyle = NamedStyle6
        SpreadSkin2.CornerDefaultStyle = NamedStyle9
        SpreadSkin2.DefaultStyle = NamedStyle10
        SpreadSkin2.FocusRenderer = EnhancedFocusIndicatorRenderer2
        EnhancedInterfaceRenderer2.ScrollBoxBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(221, Byte), Integer))
        EnhancedInterfaceRenderer2.SheetTabLowerActiveColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(244, Byte), Integer))
        EnhancedInterfaceRenderer2.SheetTabLowerNormalColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(249, Byte), Integer))
        EnhancedInterfaceRenderer2.SheetTabUpperActiveColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(244, Byte), Integer))
        EnhancedInterfaceRenderer2.SheetTabUpperNormalColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(249, Byte), Integer))
        EnhancedInterfaceRenderer2.TabStripBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(221, Byte), Integer))
        SpreadSkin2.InterfaceRenderer = EnhancedInterfaceRenderer2
        SpreadSkin2.Name = "Hung123"
        SpreadSkin2.RowHeaderDefaultStyle = NamedStyle8
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
        Me.VS1.Skin = SpreadSkin2
        Me.VS1.SpreadWjob = 0
        Me.VS1.TabIndex = 47
        Me.VS1.TabStrip.DefaultSheetTab.BackColor = System.Drawing.Color.White
        Me.VS1.TabStrip.DefaultSheetTab.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VS1.VerticalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.VS1.VerticalScrollBar.Name = ""
        EnhancedScrollBarRenderer6.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer6.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer6.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer6.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer6.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer6.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer6.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer6.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.VS1.VerticalScrollBar.Renderer = EnhancedScrollBarRenderer6
        Me.VS1.VerticalScrollBar.TabIndex = 5
        '
        'VS1_Sheet1
        '
        Me.VS1_Sheet1.Reset()
        Me.VS1_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.VS1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.VS1_Sheet1.ColumnCount = 3
        Me.VS1_Sheet1.RowCount = 49
        Me.VS1_Sheet1.ActiveSkin = New FarPoint.Win.Spread.SheetSkin("SheetSkin1", System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer)), FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer)), System.Drawing.Color.White, System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.White, System.Drawing.SystemColors.ButtonFace, False, False, False, True, True, True, False, True, "RowHeaderDefault", "RowHeaderDefault", "RowHeaderDefault", "DataAreaDefault", "RowHeaderDefault")
        Me.VS1_Sheet1.ColumnFooter.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.VS1_Sheet1.ColumnFooter.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.VS1_Sheet1.ColumnFooter.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VS1_Sheet1.ColumnFooter.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.VS1_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.VS1_Sheet1.ColumnFooter.DefaultStyle.Parent = "RowHeaderDefault"
        Me.VS1_Sheet1.ColumnFooter.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.VS1_Sheet1.ColumnFooter.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.VS1_Sheet1.ColumnFooterSheetCornerStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.VS1_Sheet1.ColumnFooterSheetCornerStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.VS1_Sheet1.ColumnFooterSheetCornerStyle.ForeColor = System.Drawing.Color.White
        Me.VS1_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.VS1_Sheet1.ColumnFooterSheetCornerStyle.Parent = "RowHeaderDefault"
        Me.VS1_Sheet1.ColumnFooterSheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.VS1_Sheet1.ColumnHeader.Cells.Get(0, 1).Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VS1_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "CODE"
        Me.VS1_Sheet1.ColumnHeader.Cells.Get(0, 2).Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VS1_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "NAME"
        Me.VS1_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.VS1_Sheet1.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.VS1_Sheet1.ColumnHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VS1_Sheet1.ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.VS1_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.VS1_Sheet1.ColumnHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.VS1_Sheet1.ColumnHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.VS1_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.VS1_Sheet1.ColumnHeader.Rows.Get(0).Height = 24.0!
        Me.VS1_Sheet1.Columns.Get(0).Visible = False
        Me.VS1_Sheet1.Columns.Get(1).Label = "CODE"
        Me.VS1_Sheet1.Columns.Get(1).Width = 86.0!
        Me.VS1_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.VS1_Sheet1.Columns.Get(2).Label = "NAME"
        Me.VS1_Sheet1.Columns.Get(2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.VS1_Sheet1.Columns.Get(2).Width = 378.0!
        Me.VS1_Sheet1.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.VS1_Sheet1.DefaultStyle.ForeColor = System.Drawing.Color.Black
        Me.VS1_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.VS1_Sheet1.DefaultStyle.Parent = "DataAreaDefault"
        Me.VS1_Sheet1.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.VS1_Sheet1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.VS1_Sheet1.FilterBar.DefaultStyle.Parent = "FilterBarDefaultEnhanced"
        Me.VS1_Sheet1.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.VS1_Sheet1.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.VS1_Sheet1.GroupBarInfo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VS1_Sheet1.NullFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VS1_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.[ReadOnly]
        Me.VS1_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.VS1_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.VS1_Sheet1.RowHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.VS1_Sheet1.RowHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VS1_Sheet1.RowHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.VS1_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.VS1_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.VS1_Sheet1.RowHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.VS1_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.VS1_Sheet1.Rows.Default.Height = 22.0!
        Me.VS1_Sheet1.Rows.Get(0).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(1).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(2).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(3).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(4).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(5).Height = 28.0!
        Me.VS1_Sheet1.Rows.Get(6).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(7).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(8).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(9).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(10).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(11).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(12).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(13).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(14).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(15).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(16).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(17).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(18).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(19).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(20).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(21).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(22).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(23).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(24).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(25).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(26).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(27).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(28).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(29).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(30).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(31).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(32).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(33).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(34).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(35).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(36).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(37).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(38).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(39).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(40).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(41).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(42).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(43).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(44).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(45).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(46).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(47).Height = 30.0!
        Me.VS1_Sheet1.Rows.Get(48).Height = 30.0!
        Me.VS1_Sheet1.SelectionPolicy = FarPoint.Win.Spread.Model.SelectionPolicy.[Single]
        Me.VS1_Sheet1.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.SelectionColors
        Me.VS1_Sheet1.SelectionUnit = FarPoint.Win.Spread.Model.SelectionUnit.Row
        Me.VS1_Sheet1.SheetCornerStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.VS1_Sheet1.SheetCornerStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VS1_Sheet1.SheetCornerStyle.ForeColor = System.Drawing.Color.White
        Me.VS1_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.VS1_Sheet1.SheetCornerStyle.Parent = "RowHeaderDefault"
        Me.VS1_Sheet1.SheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.VS1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'PeacePanel2
        '
        Me.PeacePanel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel2.Code = ""
        Me.TableLayoutPanel1.SetColumnSpan(Me.PeacePanel2, 4)
        Me.PeacePanel2.Controls.Add(Me.txt_Add)
        Me.PeacePanel2.Controls.Add(Me.cmd_OK)
        Me.PeacePanel2.Controls.Add(Me.cmd_Cancel)
        Me.PeacePanel2.Data = ""
        Me.PeacePanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeacePanel2.Location = New System.Drawing.Point(4, 638)
        Me.PeacePanel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PeacePanel2.Name = "PeacePanel2"
        Me.PeacePanel2.Size = New System.Drawing.Size(584, 36)
        Me.PeacePanel2.TabIndex = 48
        Me.PeacePanel2.Tag = ""
        '
        'txt_Add
        '
        Me.txt_Add.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Add.Appearance.Options.UseFont = True
        Me.txt_Add.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txt_Add.ButtonTitle = Nothing
        Me.txt_Add.Code = Nothing
        Me.txt_Add.Data = Nothing
        Me.txt_Add.Image = Global.PSMGlobal.My.Resources.Resources.edit
        Me.txt_Add.ImageAlign = 16
        Me.txt_Add.Location = New System.Drawing.Point(2, 1)
        Me.txt_Add.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Add.Name = "txt_Add"
        Me.txt_Add.Size = New System.Drawing.Size(165, 32)
        Me.txt_Add.TabIndex = 45
        Me.txt_Add.Text = "Add(&A)"
        Me.txt_Add.UseVisualStyleBackColor = False
        '
        'cmd_OK
        '
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_OK.ButtonTitle = Nothing
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Image = Global.PSMGlobal.My.Resources.Resources.save
        Me.cmd_OK.ImageAlign = 0
        Me.cmd_OK.Location = New System.Drawing.Point(254, 1)
        Me.cmd_OK.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(165, 32)
        Me.cmd_OK.TabIndex = 44
        Me.cmd_OK.Text = "Save(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.ButtonTitle = Nothing
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.Image = Global.PSMGlobal.My.Resources.Resources.delete
        Me.cmd_Cancel.ImageAlign = 16
        Me.cmd_Cancel.Location = New System.Drawing.Point(419, 1)
        Me.cmd_Cancel.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(165, 32)
        Me.cmd_Cancel.TabIndex = 43
        Me.cmd_Cancel.Text = "Close(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'PeacePanel1
        '
        Me.PeacePanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel1.Code = ""
        Me.TableLayoutPanel1.SetColumnSpan(Me.PeacePanel1, 4)
        Me.PeacePanel1.Controls.Add(Me.txt_cdColorBase)
        Me.PeacePanel1.Controls.Add(Me.txt_Name)
        Me.PeacePanel1.Controls.Add(Me.cmd_SEARCH)
        Me.PeacePanel1.Data = ""
        Me.PeacePanel1.Location = New System.Drawing.Point(4, 3)
        Me.PeacePanel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PeacePanel1.Name = "PeacePanel1"
        Me.TableLayoutPanel1.SetRowSpan(Me.PeacePanel1, 2)
        Me.PeacePanel1.Size = New System.Drawing.Size(584, 64)
        Me.PeacePanel1.TabIndex = 46
        Me.PeacePanel1.Tag = ""
        '
        'txt_cdColorBase
        '
        Me.txt_cdColorBase.BackYesno = False
        Me.txt_cdColorBase.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdColorBase.ButtonEnabled = True
        Me.txt_cdColorBase.ButtonFont = Nothing
        Me.txt_cdColorBase.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdColorBase.ButtonName = ""
        Me.txt_cdColorBase.ButtonTitle = "Color Base"
        Me.txt_cdColorBase.Code = ""
        Me.txt_cdColorBase.Data = ""
        Me.txt_cdColorBase.DataDecimal = 0
        Me.txt_cdColorBase.DataLen = 0
        Me.txt_cdColorBase.DataValue = 1
        Me.txt_cdColorBase.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdColorBase.Location = New System.Drawing.Point(3, 5)
        Me.txt_cdColorBase.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdColorBase.Name = "txt_cdColorBase"
        Me.txt_cdColorBase.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdColorBase.Size = New System.Drawing.Size(396, 26)
        Me.txt_cdColorBase.TabIndex = 119
        Me.txt_cdColorBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdColorBase.TextBoxAutoComplete = True
        Me.txt_cdColorBase.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdColorBase.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdColorBase.TextEnabled = True
        Me.txt_cdColorBase.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdColorBase.TextMaxLength = 32767
        Me.txt_cdColorBase.TextMultiLine = False
        Me.txt_cdColorBase.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdColorBase.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdColorBase.UseSendTab = True
        '
        'txt_Name
        '
        Me.txt_Name.BackYesno = False
        Me.txt_Name.ButtonTitle = Nothing
        Me.txt_Name.Code = Nothing
        Me.txt_Name.Data = ""
        Me.txt_Name.DataDecimal = 0
        Me.txt_Name.DataLen = 0
        Me.txt_Name.DataValue = 0
        Me.txt_Name.FormatDecimal = 0
        Me.txt_Name.FormatValue = False
        Me.txt_Name.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Name.LableEnabled = True
        Me.txt_Name.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Name.LableForeColor = System.Drawing.Color.Black
        Me.txt_Name.LableTitle = "Type Name"
        Me.txt_Name.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Name.Location = New System.Drawing.Point(2, 34)
        Me.txt_Name.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Name.Size = New System.Drawing.Size(397, 25)
        Me.txt_Name.TabIndex = 45
        Me.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Name.TextBoxAutoComplete = False
        Me.txt_Name.TextboxBackColor = System.Drawing.SystemColors.Control
        Me.txt_Name.TextBoxFont = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_Name.TextEnabled = True
        Me.txt_Name.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Name.TextMaxLength = 32767
        Me.txt_Name.TextMultiLine = False
        Me.txt_Name.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Name.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Name.UseSendTab = True
        '
        'cmd_SEARCH
        '
        Me.cmd_SEARCH.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_SEARCH.Appearance.Options.UseFont = True
        Me.cmd_SEARCH.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_SEARCH.ButtonTitle = Nothing
        Me.cmd_SEARCH.Code = Nothing
        Me.cmd_SEARCH.Data = Nothing
        Me.cmd_SEARCH.Image = Global.PSMGlobal.My.Resources.Resources.find_f
        Me.cmd_SEARCH.ImageAlign = 16
        Me.cmd_SEARCH.Location = New System.Drawing.Point(401, 5)
        Me.cmd_SEARCH.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_SEARCH.Name = "cmd_SEARCH"
        Me.cmd_SEARCH.Size = New System.Drawing.Size(178, 54)
        Me.cmd_SEARCH.TabIndex = 1
        Me.cmd_SEARCH.Text = "Search(&S)"
        Me.cmd_SEARCH.UseVisualStyleBackColor = False
        '
        'HLP7121A
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(592, 677)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "HLP7121A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COLOR CODE HELP (HLP7121A)"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.VS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VS1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeacePanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel2.ResumeLayout(False)
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents VS1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents PeacePanel2 As PSMGlobal.PeacePanel
    Public WithEvents VS1 As PSMGlobal.PeaceFarpoint
    Friend WithEvents txt_Add As PSMGlobal.PeaceButton
    Friend WithEvents PeacePanel1 As PSMGlobal.PeacePanel
    Friend WithEvents txt_Name As PSMGlobal.SelectLabelText
    Friend WithEvents cmd_SEARCH As PSMGlobal.PeaceButton
    Friend WithEvents txt_cdColorBase As PSMGlobal.SelectPeaceHLPButton
End Class
