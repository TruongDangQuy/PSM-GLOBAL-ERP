<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HLP7106G
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HLP7106G))
        Me.cmd_SEARCH = New PSMGlobal.PeaceButton(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_ShoesCode = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_MoldCode = New PSMGlobal.SelectPeaceHLPButton()
        Me.PeacePanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Vs1 = New PSMGlobal.PeaceFarpoint()
        Me.Vs1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.Frame4 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_Update = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_OutsoleColor = New PSMGlobal.SelectLabelText()
        Me.txt_LogoColorCode = New PSMGlobal.SelectLabelText()
        Me.txt_LogoColor = New PSMGlobal.SelectLabelText()
        Me.txt_MidsoleColor = New PSMGlobal.SelectLabelText()
        Me.txt_InsoleColor = New PSMGlobal.SelectLabelText()
        Me.txt_OutsoleColorCode = New PSMGlobal.SelectLabelText()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.cmd_SEARCH.Location = New System.Drawing.Point(1071, 3)
        Me.cmd_SEARCH.Name = "cmd_SEARCH"
        Me.cmd_SEARCH.Size = New System.Drawing.Size(132, 27)
        Me.cmd_SEARCH.TabIndex = 7
        Me.cmd_SEARCH.Text = "   Search(&S)"
        Me.cmd_SEARCH.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.cmd_SEARCH, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_ShoesCode, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_MoldCode, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1206, 31)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'txt_ShoesCode
        '
        Me.txt_ShoesCode.BackYesno = False
        Me.txt_ShoesCode.ButtonBackColor = System.Drawing.SystemColors.Control
        Me.txt_ShoesCode.ButtonEnabled = True
        Me.txt_ShoesCode.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ShoesCode.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_ShoesCode.ButtonName = ""
        Me.txt_ShoesCode.ButtonTitle = "ITEM CODE"
        Me.txt_ShoesCode.Code = ""
        Me.txt_ShoesCode.Data = ""
        Me.txt_ShoesCode.DataDecimal = 0
        Me.txt_ShoesCode.DataLen = 0
        Me.txt_ShoesCode.DataValue = 0
        Me.txt_ShoesCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ShoesCode.Enabled = False
        Me.txt_ShoesCode.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_ShoesCode.Location = New System.Drawing.Point(0, 0)
        Me.txt_ShoesCode.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_ShoesCode.Name = "txt_ShoesCode"
        Me.txt_ShoesCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ShoesCode.Size = New System.Drawing.Size(250, 33)
        Me.txt_ShoesCode.TabIndex = 107
        Me.txt_ShoesCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ShoesCode.TextBoxAutoComplete = True
        Me.txt_ShoesCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ShoesCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ShoesCode.TextEnabled = True
        Me.txt_ShoesCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ShoesCode.TextMaxLength = 32767
        Me.txt_ShoesCode.TextMultiLine = False
        Me.txt_ShoesCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ShoesCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ShoesCode.UseSendTab = True
        '
        'txt_MoldCode
        '
        Me.txt_MoldCode.BackYesno = False
        Me.txt_MoldCode.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_MoldCode.ButtonEnabled = True
        Me.txt_MoldCode.ButtonFont = Nothing
        Me.txt_MoldCode.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_MoldCode.ButtonName = ""
        Me.txt_MoldCode.ButtonTitle = "Molde Code"
        Me.txt_MoldCode.Code = ""
        Me.txt_MoldCode.Data = ""
        Me.txt_MoldCode.DataDecimal = 0
        Me.txt_MoldCode.DataLen = 0
        Me.txt_MoldCode.DataValue = 0
        Me.txt_MoldCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_MoldCode.Location = New System.Drawing.Point(251, 1)
        Me.txt_MoldCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MoldCode.Name = "txt_MoldCode"
        Me.txt_MoldCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MoldCode.Size = New System.Drawing.Size(357, 27)
        Me.txt_MoldCode.TabIndex = 28
        Me.txt_MoldCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MoldCode.TextBoxAutoComplete = False
        Me.txt_MoldCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MoldCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_MoldCode.TextEnabled = True
        Me.txt_MoldCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MoldCode.TextMaxLength = 32767
        Me.txt_MoldCode.TextMultiLine = False
        Me.txt_MoldCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MoldCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MoldCode.UseSendTab = True
        '
        'PeacePanel1
        '
        Me.PeacePanel1.Code = ""
        Me.PeacePanel1.Controls.Add(Me.TableLayoutPanel2)
        Me.PeacePanel1.Data = ""
        Me.PeacePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeacePanel1.Location = New System.Drawing.Point(4, 4)
        Me.PeacePanel1.Name = "PeacePanel1"
        Me.PeacePanel1.Size = New System.Drawing.Size(1210, 35)
        Me.PeacePanel1.TabIndex = 6
        Me.PeacePanel1.Tag = ""
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Vs1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Frame4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PeacePanel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1218, 366)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'Vs1
        '
        Me.Vs1.AccessibleDescription = "Vs1, Sheet1, Row 0, Column 0, "
        Me.Vs1.AllowEditorReservedLocations = False
        Me.Vs1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Vs1.CopyPasteChk = True
        Me.Vs1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Vs1.FocusRenderer = EnhancedFocusIndicatorRenderer1
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
        Me.Vs1.InsChk = False
        Me.Vs1.Location = New System.Drawing.Point(1, 111)
        Me.Vs1.Margin = New System.Windows.Forms.Padding(0)
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
        Me.Vs1.ReportName = Nothing
        Me.Vs1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.Vs1_Sheet1})
        Me.Vs1.Size = New System.Drawing.Size(1216, 207)
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
        Me.Vs1.SpreadWjob = 0
        Me.Vs1.TabIndex = 11
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
        '
        'Vs1_Sheet1
        '
        Me.Vs1_Sheet1.Reset()
        Me.Vs1_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.Vs1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.Vs1_Sheet1.ColumnCount = 100
        Me.Vs1_Sheet1.RowCount = 100
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
        Me.Vs1_Sheet1.ColumnHeader.AutoText = FarPoint.Win.Spread.HeaderAutoText.Numbers
        Me.Vs1_Sheet1.ColumnHeader.Cells.Get(0, 0).Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Vs1_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnHeader.Rows.Get(0).Height = 25.0!
        Me.Vs1_Sheet1.Columns.Get(0).Width = 158.0!
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
        Me.Vs1_Sheet1.NullFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vs1_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.SingleSelect
        Me.Vs1_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.Vs1_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.RowHeader.Columns.Get(0).Width = 1.0!
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.Rows.Default.Height = 22.0!
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
        'Frame4
        '
        Me.Frame4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Frame4.Code = ""
        Me.Frame4.Controls.Add(Me.cmd_Update)
        Me.Frame4.Controls.Add(Me.cmd_Cancel)
        Me.Frame4.Controls.Add(Me.cmd_OK)
        Me.Frame4.Data = ""
        Me.Frame4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame4.Location = New System.Drawing.Point(4, 322)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Size = New System.Drawing.Size(1210, 40)
        Me.Frame4.TabIndex = 9
        Me.Frame4.Tag = ""
        '
        'cmd_Update
        '
        Me.cmd_Update.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Update.Appearance.Options.UseFont = True
        Me.cmd_Update.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Update.ButtonTitle = Nothing
        Me.cmd_Update.Code = Nothing
        Me.cmd_Update.Data = Nothing
        Me.cmd_Update.Image = Global.PSMGlobal.My.Resources.Resources.edit
        Me.cmd_Update.ImageAlign = 16
        Me.cmd_Update.Location = New System.Drawing.Point(6, 4)
        Me.cmd_Update.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_Update.Name = "cmd_Update"
        Me.cmd_Update.Size = New System.Drawing.Size(140, 32)
        Me.cmd_Update.TabIndex = 47
        Me.cmd_Update.Text = "Update (&U)"
        Me.cmd_Update.UseVisualStyleBackColor = False
        Me.cmd_Update.Visible = False
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
        Me.cmd_Cancel.ImageAlign = 0
        Me.cmd_Cancel.Location = New System.Drawing.Point(1065, 3)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(141, 35)
        Me.cmd_Cancel.TabIndex = 1
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
        Me.cmd_OK.ImageAlign = 0
        Me.cmd_OK.Location = New System.Drawing.Point(924, 3)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(141, 35)
        Me.cmd_OK.TabIndex = 0
        Me.cmd_OK.Text = "OK(&K)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_OutsoleColor)
        Me.Panel1.Controls.Add(Me.txt_LogoColorCode)
        Me.Panel1.Controls.Add(Me.txt_LogoColor)
        Me.Panel1.Controls.Add(Me.txt_MidsoleColor)
        Me.Panel1.Controls.Add(Me.txt_InsoleColor)
        Me.Panel1.Controls.Add(Me.txt_OutsoleColorCode)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1210, 61)
        Me.Panel1.TabIndex = 12
        '
        'txt_OutsoleColor
        '
        Me.txt_OutsoleColor.BackYesno = False
        Me.txt_OutsoleColor.ButtonTitle = Nothing
        Me.txt_OutsoleColor.Code = Nothing
        Me.txt_OutsoleColor.Data = ""
        Me.txt_OutsoleColor.DataDecimal = 0
        Me.txt_OutsoleColor.DataLen = 0
        Me.txt_OutsoleColor.DataValue = 0
        Me.txt_OutsoleColor.FormatDecimal = 0
        Me.txt_OutsoleColor.FormatValue = False
        Me.txt_OutsoleColor.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_OutsoleColor.LableEnabled = True
        Me.txt_OutsoleColor.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_OutsoleColor.LableForeColor = System.Drawing.Color.Empty
        Me.txt_OutsoleColor.LableTitle = "Outsole Color"
        Me.txt_OutsoleColor.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_OutsoleColor.Location = New System.Drawing.Point(3, 1)
        Me.txt_OutsoleColor.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_OutsoleColor.Name = "txt_OutsoleColor"
        Me.txt_OutsoleColor.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_OutsoleColor.Size = New System.Drawing.Size(357, 27)
        Me.txt_OutsoleColor.TabIndex = 34
        Me.txt_OutsoleColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_OutsoleColor.TextBoxAutoComplete = False
        Me.txt_OutsoleColor.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_OutsoleColor.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_OutsoleColor.TextEnabled = True
        Me.txt_OutsoleColor.TextForeColor = System.Drawing.Color.Empty
        Me.txt_OutsoleColor.TextMaxLength = 32767
        Me.txt_OutsoleColor.TextMultiLine = False
        Me.txt_OutsoleColor.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_OutsoleColor.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_OutsoleColor.UseSendTab = True
        '
        'txt_LogoColorCode
        '
        Me.txt_LogoColorCode.BackYesno = False
        Me.txt_LogoColorCode.ButtonTitle = Nothing
        Me.txt_LogoColorCode.Code = Nothing
        Me.txt_LogoColorCode.Data = ""
        Me.txt_LogoColorCode.DataDecimal = 0
        Me.txt_LogoColorCode.DataLen = 0
        Me.txt_LogoColorCode.DataValue = 0
        Me.txt_LogoColorCode.FormatDecimal = 0
        Me.txt_LogoColorCode.FormatValue = False
        Me.txt_LogoColorCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_LogoColorCode.LableEnabled = True
        Me.txt_LogoColorCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_LogoColorCode.LableForeColor = System.Drawing.Color.Empty
        Me.txt_LogoColorCode.LableTitle = "Logo Color"
        Me.txt_LogoColorCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_LogoColorCode.Location = New System.Drawing.Point(774, 0)
        Me.txt_LogoColorCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_LogoColorCode.Name = "txt_LogoColorCode"
        Me.txt_LogoColorCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_LogoColorCode.Size = New System.Drawing.Size(410, 27)
        Me.txt_LogoColorCode.TabIndex = 33
        Me.txt_LogoColorCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_LogoColorCode.TextBoxAutoComplete = False
        Me.txt_LogoColorCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_LogoColorCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_LogoColorCode.TextEnabled = True
        Me.txt_LogoColorCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_LogoColorCode.TextMaxLength = 32767
        Me.txt_LogoColorCode.TextMultiLine = False
        Me.txt_LogoColorCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_LogoColorCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_LogoColorCode.UseSendTab = True
        '
        'txt_LogoColor
        '
        Me.txt_LogoColor.BackYesno = False
        Me.txt_LogoColor.ButtonTitle = Nothing
        Me.txt_LogoColor.Code = Nothing
        Me.txt_LogoColor.Data = ""
        Me.txt_LogoColor.DataDecimal = 0
        Me.txt_LogoColor.DataLen = 0
        Me.txt_LogoColor.DataValue = 0
        Me.txt_LogoColor.FormatDecimal = 0
        Me.txt_LogoColor.FormatValue = False
        Me.txt_LogoColor.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_LogoColor.LableEnabled = True
        Me.txt_LogoColor.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_LogoColor.LableForeColor = System.Drawing.Color.Empty
        Me.txt_LogoColor.LableTitle = "Logo Color"
        Me.txt_LogoColor.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_LogoColor.Location = New System.Drawing.Point(774, 29)
        Me.txt_LogoColor.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_LogoColor.Name = "txt_LogoColor"
        Me.txt_LogoColor.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_LogoColor.Size = New System.Drawing.Size(410, 27)
        Me.txt_LogoColor.TabIndex = 32
        Me.txt_LogoColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_LogoColor.TextBoxAutoComplete = False
        Me.txt_LogoColor.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_LogoColor.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_LogoColor.TextEnabled = True
        Me.txt_LogoColor.TextForeColor = System.Drawing.Color.Empty
        Me.txt_LogoColor.TextMaxLength = 32767
        Me.txt_LogoColor.TextMultiLine = False
        Me.txt_LogoColor.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_LogoColor.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_LogoColor.UseSendTab = True
        '
        'txt_MidsoleColor
        '
        Me.txt_MidsoleColor.BackYesno = False
        Me.txt_MidsoleColor.ButtonTitle = Nothing
        Me.txt_MidsoleColor.Code = Nothing
        Me.txt_MidsoleColor.Data = ""
        Me.txt_MidsoleColor.DataDecimal = 0
        Me.txt_MidsoleColor.DataLen = 0
        Me.txt_MidsoleColor.DataValue = 0
        Me.txt_MidsoleColor.FormatDecimal = 0
        Me.txt_MidsoleColor.FormatValue = False
        Me.txt_MidsoleColor.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_MidsoleColor.LableEnabled = True
        Me.txt_MidsoleColor.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MidsoleColor.LableForeColor = System.Drawing.Color.Empty
        Me.txt_MidsoleColor.LableTitle = "MidSole Color"
        Me.txt_MidsoleColor.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_MidsoleColor.Location = New System.Drawing.Point(362, 30)
        Me.txt_MidsoleColor.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MidsoleColor.Name = "txt_MidsoleColor"
        Me.txt_MidsoleColor.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MidsoleColor.Size = New System.Drawing.Size(410, 27)
        Me.txt_MidsoleColor.TabIndex = 31
        Me.txt_MidsoleColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MidsoleColor.TextBoxAutoComplete = False
        Me.txt_MidsoleColor.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MidsoleColor.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MidsoleColor.TextEnabled = True
        Me.txt_MidsoleColor.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MidsoleColor.TextMaxLength = 32767
        Me.txt_MidsoleColor.TextMultiLine = False
        Me.txt_MidsoleColor.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MidsoleColor.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MidsoleColor.UseSendTab = True
        '
        'txt_InsoleColor
        '
        Me.txt_InsoleColor.BackYesno = False
        Me.txt_InsoleColor.ButtonTitle = Nothing
        Me.txt_InsoleColor.Code = Nothing
        Me.txt_InsoleColor.Data = ""
        Me.txt_InsoleColor.DataDecimal = 0
        Me.txt_InsoleColor.DataLen = 0
        Me.txt_InsoleColor.DataValue = 0
        Me.txt_InsoleColor.FormatDecimal = 0
        Me.txt_InsoleColor.FormatValue = False
        Me.txt_InsoleColor.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_InsoleColor.LableEnabled = True
        Me.txt_InsoleColor.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_InsoleColor.LableForeColor = System.Drawing.Color.Empty
        Me.txt_InsoleColor.LableTitle = "Insole Color"
        Me.txt_InsoleColor.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_InsoleColor.Location = New System.Drawing.Point(362, 1)
        Me.txt_InsoleColor.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_InsoleColor.Name = "txt_InsoleColor"
        Me.txt_InsoleColor.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_InsoleColor.Size = New System.Drawing.Size(410, 27)
        Me.txt_InsoleColor.TabIndex = 30
        Me.txt_InsoleColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_InsoleColor.TextBoxAutoComplete = False
        Me.txt_InsoleColor.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_InsoleColor.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_InsoleColor.TextEnabled = True
        Me.txt_InsoleColor.TextForeColor = System.Drawing.Color.Empty
        Me.txt_InsoleColor.TextMaxLength = 32767
        Me.txt_InsoleColor.TextMultiLine = False
        Me.txt_InsoleColor.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_InsoleColor.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_InsoleColor.UseSendTab = True
        '
        'txt_OutsoleColorCode
        '
        Me.txt_OutsoleColorCode.BackYesno = False
        Me.txt_OutsoleColorCode.ButtonTitle = Nothing
        Me.txt_OutsoleColorCode.Code = Nothing
        Me.txt_OutsoleColorCode.Data = ""
        Me.txt_OutsoleColorCode.DataDecimal = 0
        Me.txt_OutsoleColorCode.DataLen = 0
        Me.txt_OutsoleColorCode.DataValue = 0
        Me.txt_OutsoleColorCode.FormatDecimal = 0
        Me.txt_OutsoleColorCode.FormatValue = False
        Me.txt_OutsoleColorCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_OutsoleColorCode.LableEnabled = True
        Me.txt_OutsoleColorCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_OutsoleColorCode.LableForeColor = System.Drawing.Color.Empty
        Me.txt_OutsoleColorCode.LableTitle = "Outsole Color Code"
        Me.txt_OutsoleColorCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_OutsoleColorCode.Location = New System.Drawing.Point(3, 30)
        Me.txt_OutsoleColorCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_OutsoleColorCode.Name = "txt_OutsoleColorCode"
        Me.txt_OutsoleColorCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_OutsoleColorCode.Size = New System.Drawing.Size(357, 27)
        Me.txt_OutsoleColorCode.TabIndex = 29
        Me.txt_OutsoleColorCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_OutsoleColorCode.TextBoxAutoComplete = False
        Me.txt_OutsoleColorCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_OutsoleColorCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_OutsoleColorCode.TextEnabled = True
        Me.txt_OutsoleColorCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_OutsoleColorCode.TextMaxLength = 32767
        Me.txt_OutsoleColorCode.TextMultiLine = False
        Me.txt_OutsoleColorCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_OutsoleColorCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_OutsoleColorCode.UseSendTab = True
        '
        'HLP7106G
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1218, 366)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HLP7106G"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ITEM CODE HELP (HLP7106G)"
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_SEARCH As PSMGlobal.PeaceButton
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PeacePanel1 As PSMGlobal.PeacePanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txt_ShoesCode As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents Frame4 As PSMGlobal.PeacePanel
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Public WithEvents Vs1 As PSMGlobal.PeaceFarpoint
    Friend WithEvents Vs1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents cmd_Update As PSMGlobal.PeaceButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_OutsoleColorCode As PSMGlobal.SelectLabelText
    Friend WithEvents txt_MoldCode As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_MidsoleColor As PSMGlobal.SelectLabelText
    Friend WithEvents txt_InsoleColor As PSMGlobal.SelectLabelText
    Friend WithEvents txt_LogoColorCode As PSMGlobal.SelectLabelText
    Friend WithEvents txt_LogoColor As PSMGlobal.SelectLabelText
    Friend WithEvents txt_OutsoleColor As PSMGlobal.SelectLabelText
End Class
