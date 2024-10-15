<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD4000C
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
        Dim vS1_InputMapWhenFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim vS1_InputMapWhenAncestorOfFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim TextCellType5 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Bk_1 = New System.ComponentModel.BackgroundWorker()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_cdMainProcess_ScanOffline = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_Barcode = New System.Windows.Forms.TextBox()
        Me.txt_InchargeProdution = New PSMGlobal.SelectPeaceHLPButton()
        Me.vS1 = New PSMGlobal.PeaceFarpoint()
        Me.vS1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.txt_DateProd = New PSMGlobal.SelectPeaceCalSin()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        vS1_InputMapWhenFocusedNormal = New FarPoint.Win.Spread.InputMap()
        vS1_InputMapWhenAncestorOfFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.vS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vS1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bk_1
        '
        Me.Bk_1.WorkerReportsProgress = True
        Me.Bk_1.WorkerSupportsCancellation = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.vS1, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 41)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(992, 465)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'txt_cdMainProcess_ScanOffline
        '
        Me.txt_cdMainProcess_ScanOffline.BackYesno = False
        Me.txt_cdMainProcess_ScanOffline.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdMainProcess_ScanOffline.ButtonEnabled = True
        Me.txt_cdMainProcess_ScanOffline.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdMainProcess_ScanOffline.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdMainProcess_ScanOffline.ButtonName = ""
        Me.txt_cdMainProcess_ScanOffline.ButtonTitle = "Process"
        Me.txt_cdMainProcess_ScanOffline.Code = ""
        Me.txt_cdMainProcess_ScanOffline.Data = "Cutting"
        Me.txt_cdMainProcess_ScanOffline.DataDecimal = 1
        Me.txt_cdMainProcess_ScanOffline.DataLen = 1
        Me.txt_cdMainProcess_ScanOffline.DataValue = 1
        Me.txt_cdMainProcess_ScanOffline.Enabled = False
        Me.txt_cdMainProcess_ScanOffline.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdMainProcess_ScanOffline.Layoutpercent = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txt_cdMainProcess_ScanOffline.Location = New System.Drawing.Point(8, 57)
        Me.txt_cdMainProcess_ScanOffline.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_cdMainProcess_ScanOffline.Name = "txt_cdMainProcess_ScanOffline"
        Me.txt_cdMainProcess_ScanOffline.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdMainProcess_ScanOffline.Size = New System.Drawing.Size(223, 25)
        Me.txt_cdMainProcess_ScanOffline.TabIndex = 200
        Me.txt_cdMainProcess_ScanOffline.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdMainProcess_ScanOffline.TextBoxAutoComplete = False
        Me.txt_cdMainProcess_ScanOffline.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdMainProcess_ScanOffline.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdMainProcess_ScanOffline.TextEnabled = False
        Me.txt_cdMainProcess_ScanOffline.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdMainProcess_ScanOffline.TextMaxLength = 32767
        Me.txt_cdMainProcess_ScanOffline.TextMultiLine = False
        Me.txt_cdMainProcess_ScanOffline.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdMainProcess_ScanOffline.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdMainProcess_ScanOffline.UseSendTab = True
        '
        'txt_Barcode
        '
        Me.txt_Barcode.BackColor = System.Drawing.Color.White
        Me.txt_Barcode.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Barcode.Location = New System.Drawing.Point(8, 110)
        Me.txt_Barcode.Multiline = True
        Me.txt_Barcode.Name = "txt_Barcode"
        Me.txt_Barcode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Barcode.Size = New System.Drawing.Size(223, 341)
        Me.txt_Barcode.TabIndex = 2
        '
        'txt_InchargeProdution
        '
        Me.txt_InchargeProdution.BackYesno = False
        Me.txt_InchargeProdution.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_InchargeProdution.ButtonEnabled = True
        Me.txt_InchargeProdution.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_InchargeProdution.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeProdution.ButtonName = ""
        Me.txt_InchargeProdution.ButtonTitle = "Incharge"
        Me.txt_InchargeProdution.Code = ""
        Me.txt_InchargeProdution.Data = ""
        Me.txt_InchargeProdution.DataDecimal = 1
        Me.txt_InchargeProdution.DataLen = 0
        Me.txt_InchargeProdution.DataValue = 1
        Me.txt_InchargeProdution.Enabled = False
        Me.txt_InchargeProdution.Layoutpercent = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txt_InchargeProdution.Location = New System.Drawing.Point(8, 28)
        Me.txt_InchargeProdution.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_InchargeProdution.Name = "txt_InchargeProdution"
        Me.txt_InchargeProdution.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_InchargeProdution.Size = New System.Drawing.Size(223, 25)
        Me.txt_InchargeProdution.TabIndex = 192
        Me.txt_InchargeProdution.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_InchargeProdution.TextBoxAutoComplete = False
        Me.txt_InchargeProdution.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_InchargeProdution.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_InchargeProdution.TextEnabled = True
        Me.txt_InchargeProdution.TextForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeProdution.TextMaxLength = 32767
        Me.txt_InchargeProdution.TextMultiLine = False
        Me.txt_InchargeProdution.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_InchargeProdution.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_InchargeProdution.UseSendTab = True
        '
        'vS1
        '
        Me.vS1.AccessibleDescription = ""
        Me.vS1.AllowDragFill = True
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
        Me.vS1.InsChk = True
        Me.vS1.Location = New System.Drawing.Point(245, 5)
        Me.vS1.Margin = New System.Windows.Forms.Padding(5)
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
        Me.vS1.SheetDSName = Nothing
        Me.vS1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.vS1_Sheet1})
        Me.vS1.Size = New System.Drawing.Size(742, 455)
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
        Me.vS1.TabIndex = 2
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
        Me.vS1.VerticalScrollBar.TabIndex = 1
        vS1_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        vS1_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        Me.vS1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.Normal, vS1_InputMapWhenFocusedNormal)
        vS1_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        vS1_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
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
        'txt_DateProd
        '
        Me.txt_DateProd.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_DateProd.ButtonEnabled = True
        Me.txt_DateProd.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_DateProd.ButtonName = Nothing
        Me.txt_DateProd.ButtonTitle = "Outbound Date"
        Me.txt_DateProd.Code = ""
        Me.txt_DateProd.Data = "20190219"
        Me.txt_DateProd.DataDecimal = 0
        Me.txt_DateProd.DataLen = 0
        Me.txt_DateProd.DataValue = 0
        Me.txt_DateProd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_DateProd.FormatDecimal = 0
        Me.txt_DateProd.FormatValue = False
        Me.txt_DateProd.Layoutpercent = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txt_DateProd.Location = New System.Drawing.Point(8, 2)
        Me.txt_DateProd.Margin = New System.Windows.Forms.Padding(5)
        Me.txt_DateProd.Name = "txt_DateProd"
        Me.txt_DateProd.Size = New System.Drawing.Size(223, 25)
        Me.txt_DateProd.TabIndex = 201
        Me.txt_DateProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_DateProd.TextBoxAutoComplete = False
        Me.txt_DateProd.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_DateProd.TextEnabled = True
        Me.txt_DateProd.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DateProd.TextMaxLength = 32767
        Me.txt_DateProd.TextMultiLine = True
        Me.txt_DateProd.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_Barcode)
        Me.Panel1.Controls.Add(Me.txt_cdMainProcess_ScanOffline)
        Me.Panel1.Controls.Add(Me.txt_InchargeProdution)
        Me.Panel1.Controls.Add(Me.txt_DateProd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(234, 459)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(8, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 14)
        Me.Label1.TabIndex = 202
        Me.Label1.Text = "Barcode List - Please input here !"
        '
        'ISUD4000C
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 509)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Name = "ISUD4000C"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scan Outbound Jobworking Offline Processing (ISUD4000C)"
        Me.Controls.SetChildIndex(Me.TableLayoutPanel3, 0)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.vS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vS1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Bk_1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txt_cdMainProcess_ScanOffline As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_Barcode As System.Windows.Forms.TextBox
    Friend WithEvents txt_InchargeProdution As PSMGlobal.SelectPeaceHLPButton
    Public WithEvents vS1 As PSMGlobal.PeaceFarpoint
    Friend WithEvents vS1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_DateProd As PSMGlobal.SelectPeaceCalSin
End Class
