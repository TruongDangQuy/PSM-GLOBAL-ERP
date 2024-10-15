<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HLP7155A
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
        Dim Vs1_InputMapWhenFocusedSingleSelect As FarPoint.Win.Spread.InputMap
        Dim Vs1_InputMapWhenAncestorOfFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim Vs1_InputMapWhenAncestorOfFocusedSingleSelect As FarPoint.Win.Spread.InputMap
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HLP7155A))
        Me.cmd_SEARCH = New PSMGlobal.PeaceButton(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_MachineType = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_MachineName = New PSMGlobal.SelectPeaceHLPButton()
        Me.PeacePanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.Tlp_1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Vs1 = New PSMGlobal.PeaceFarpoint()
        Me.Vs1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.Frame4 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_New = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Vs1_InputMapWhenFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenFocusedSingleSelect = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenFocusedSingleSelect.Parent = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedSingleSelect = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedSingleSelect.Parent = New FarPoint.Win.Spread.InputMap()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel1.SuspendLayout()
        Me.Tlp_1.SuspendLayout()
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame4.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_SEARCH
        '
        Me.cmd_SEARCH.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmd_SEARCH.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_SEARCH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd_SEARCH.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_SEARCH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.cmd_SEARCH.Image = Global.PSMGlobal.My.Resources.Resources.find_f
        Me.cmd_SEARCH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_SEARCH.Location = New System.Drawing.Point(899, 1)
        Me.cmd_SEARCH.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_SEARCH.Name = "cmd_SEARCH"
        Me.cmd_SEARCH.Size = New System.Drawing.Size(135, 28)
        Me.cmd_SEARCH.TabIndex = 7
        Me.cmd_SEARCH.Text = "   Search(&S)"
        Me.cmd_SEARCH.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 237.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 265.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txt_MachineType, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_MachineName, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmd_SEARCH, 3, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1035, 30)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'txt_MachineType
        '
        Me.txt_MachineType.BackYesno = False
        Me.txt_MachineType.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_MachineType.ButtonEnabled = True
        Me.txt_MachineType.ButtonFont = Nothing
        Me.txt_MachineType.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_MachineType.ButtonName = "Const_MachineType"
        Me.txt_MachineType.ButtonTitle = "Machine Type"
        Me.txt_MachineType.Code = ""
        Me.txt_MachineType.Data = ""
        Me.txt_MachineType.DataDecimal = 0
        Me.txt_MachineType.DataLen = 0
        Me.txt_MachineType.DataValue = 1
        Me.txt_MachineType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_MachineType.Layoutpercent = New Decimal(New Integer() {46, 0, 0, 131072})
        Me.txt_MachineType.Location = New System.Drawing.Point(3, 3)
        Me.txt_MachineType.Name = "txt_MachineType"
        Me.txt_MachineType.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MachineType.Size = New System.Drawing.Size(231, 24)
        Me.txt_MachineType.TabIndex = 116
        Me.txt_MachineType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MachineType.TextBoxAutoComplete = False
        Me.txt_MachineType.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MachineType.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_MachineType.TextEnabled = True
        Me.txt_MachineType.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MachineType.TextMaxLength = 32767
        Me.txt_MachineType.TextMultiLine = False
        Me.txt_MachineType.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MachineType.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MachineType.UseSendTab = True
        '
        'txt_MachineName
        '
        Me.txt_MachineName.BackYesno = False
        Me.txt_MachineName.ButtonBackColor = System.Drawing.SystemColors.Control
        Me.txt_MachineName.ButtonEnabled = True
        Me.txt_MachineName.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MachineName.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_MachineName.ButtonName = ""
        Me.txt_MachineName.ButtonTitle = "Machine Name"
        Me.txt_MachineName.Code = ""
        Me.txt_MachineName.Data = " "
        Me.txt_MachineName.DataDecimal = 0
        Me.txt_MachineName.DataLen = 0
        Me.txt_MachineName.DataValue = 0
        Me.txt_MachineName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_MachineName.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_MachineName.Location = New System.Drawing.Point(240, 3)
        Me.txt_MachineName.Name = "txt_MachineName"
        Me.txt_MachineName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MachineName.Size = New System.Drawing.Size(259, 24)
        Me.txt_MachineName.TabIndex = 107
        Me.txt_MachineName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MachineName.TextBoxAutoComplete = True
        Me.txt_MachineName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MachineName.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MachineName.TextEnabled = True
        Me.txt_MachineName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MachineName.TextMaxLength = 32767
        Me.txt_MachineName.TextMultiLine = False
        Me.txt_MachineName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MachineName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MachineName.UseSendTab = True
        '
        'PeacePanel1
        '
        Me.PeacePanel1.Code = ""
        Me.PeacePanel1.Controls.Add(Me.TableLayoutPanel2)
        Me.PeacePanel1.Data = ""
        Me.PeacePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeacePanel1.Location = New System.Drawing.Point(4, 4)
        Me.PeacePanel1.Name = "PeacePanel1"
        Me.PeacePanel1.Size = New System.Drawing.Size(1039, 34)
        Me.PeacePanel1.TabIndex = 6
        Me.PeacePanel1.Tag = ""
        '
        'Tlp_1
        '
        Me.Tlp_1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Tlp_1.ColumnCount = 1
        Me.Tlp_1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Tlp_1.Controls.Add(Me.Vs1, 0, 1)
        Me.Tlp_1.Controls.Add(Me.Frame4, 0, 2)
        Me.Tlp_1.Controls.Add(Me.PeacePanel1, 0, 0)
        Me.Tlp_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tlp_1.Location = New System.Drawing.Point(0, 0)
        Me.Tlp_1.Margin = New System.Windows.Forms.Padding(0)
        Me.Tlp_1.Name = "Tlp_1"
        Me.Tlp_1.RowCount = 3
        Me.Tlp_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.Tlp_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Tlp_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.Tlp_1.Size = New System.Drawing.Size(1047, 603)
        Me.Tlp_1.TabIndex = 12
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
        Me.Vs1.Location = New System.Drawing.Point(1, 42)
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
        Me.Vs1.Size = New System.Drawing.Size(1045, 514)
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
        Me.Vs1.VerticalScrollBar.TabIndex = 5
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
        Me.Vs1_Sheet1.ColumnCount = 100
        Me.Vs1_Sheet1.RowCount = 100
        Me.Vs1_Sheet1.ActiveSkin = New FarPoint.Win.Spread.SheetSkin("SheetSkin1", System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer)), System.Drawing.Color.White, System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.White, System.Drawing.SystemColors.ButtonFace, False, False, False, True, True, True, False, True, "RowHeaderDefault", "RowHeaderDefault", "RowHeaderDefault", "DataAreaDefault", "RowHeaderDefault")
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
        Me.Frame4.Controls.Add(Me.cmd_New)
        Me.Frame4.Controls.Add(Me.cmd_Cancel)
        Me.Frame4.Controls.Add(Me.cmd_OK)
        Me.Frame4.Data = ""
        Me.Frame4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame4.Location = New System.Drawing.Point(4, 560)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Size = New System.Drawing.Size(1039, 39)
        Me.Frame4.TabIndex = 8
        Me.Frame4.Tag = ""
        '
        'cmd_New
        '
        Me.cmd_New.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmd_New.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_New.Appearance.Options.UseFont = True
        Me.cmd_New.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_New.Code = Nothing
        Me.cmd_New.Data = Nothing
        Me.cmd_New.Image = Global.PSMGlobal.My.Resources.Resources.edit
        Me.cmd_New.ImageAlign = 0
        Me.cmd_New.Location = New System.Drawing.Point(2, 0)
        Me.cmd_New.Name = "cmd_New"
        Me.cmd_New.Size = New System.Drawing.Size(141, 35)
        Me.cmd_New.TabIndex = 2
        Me.cmd_New.Text = "INPUT(&I)"
        Me.cmd_New.UseVisualStyleBackColor = False
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.Image = CType(resources.GetObject("cmd_Cancel.Image"), System.Drawing.Image)
        Me.cmd_Cancel.ImageAlign = 0
        Me.cmd_Cancel.Location = New System.Drawing.Point(893, 0)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(141, 35)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'cmd_OK
        '
        Me.cmd_OK.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Image = CType(resources.GetObject("cmd_OK.Image"), System.Drawing.Image)
        Me.cmd_OK.ImageAlign = 0
        Me.cmd_OK.Location = New System.Drawing.Point(750, 0)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(141, 35)
        Me.cmd_OK.TabIndex = 0
        Me.cmd_OK.Text = "OK(&K)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'HLP7155A
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1047, 603)
        Me.Controls.Add(Me.Tlp_1)
        Me.KeyPreview = True
        Me.Name = "HLP7155A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MACHINE CODE (HLP7155A)"
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel1.ResumeLayout(False)
        Me.Tlp_1.ResumeLayout(False)
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_SEARCH As PSMGlobal.PeaceButton
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PeacePanel1 As PSMGlobal.PeacePanel
    Friend WithEvents Tlp_1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Vs1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents txt_MachineName As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents Frame4 As PSMGlobal.PeacePanel
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Public WithEvents Vs1 As PSMGlobal.PeaceFarpoint
    Friend WithEvents cmd_New As PSMGlobal.PeaceButton
    Friend WithEvents txt_MachineType As PSMGlobal.SelectPeaceHLPButton
End Class
