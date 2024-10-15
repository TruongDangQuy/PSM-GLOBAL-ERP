<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD4958U
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD4958U))
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
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_DEL = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.Pal_2 = New PSMGlobal.PeacePanel(Me.components)
        Me.Pal_1 = New PSMGlobal.PeacePanel(Me.components)
        Me.chk_Error = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.cmd_Link7235 = New PSMGlobal.SelectPeaceHLPButton()
        Me.cmd_Rule = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_MappingNo = New System.Windows.Forms.ComboBox()
        Me.cmd_Upload = New DevExpress.XtraEditors.SimpleButton()
        Me.Vs1 = New PSMGlobal.PeaceFarpoint()
        Me.Vs1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.Tlp_1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ptc_Main = New PSMGlobal.PeaceTabControl(Me.components)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        CType(Me.Pal_2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pal_2.SuspendLayout()
        CType(Me.Pal_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pal_1.SuspendLayout()
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tlp_1.SuspendLayout()
        Me.ptc_Main.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_OK
        '
        Me.cmd_OK.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_OK.ButtonTitle = Nothing
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Image = CType(resources.GetObject("cmd_OK.Image"), System.Drawing.Image)
        Me.cmd_OK.ImageAlign = 16
        Me.cmd_OK.Location = New System.Drawing.Point(995, 1)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(141, 35)
        Me.cmd_OK.TabIndex = 0
        Me.cmd_OK.Text = "SAVE(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
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
        Me.cmd_DEL.Location = New System.Drawing.Point(1, 1)
        Me.cmd_DEL.Margin = New System.Windows.Forms.Padding(0)
        Me.cmd_DEL.Name = "cmd_DEL"
        Me.cmd_DEL.Size = New System.Drawing.Size(141, 35)
        Me.cmd_DEL.TabIndex = 2
        Me.cmd_DEL.Text = "DELETE(&D)"
        Me.cmd_DEL.UseVisualStyleBackColor = False
        Me.cmd_DEL.Visible = False
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.ButtonTitle = Nothing
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.Image = CType(resources.GetObject("cmd_Cancel.Image"), System.Drawing.Image)
        Me.cmd_Cancel.ImageAlign = 16
        Me.cmd_Cancel.Location = New System.Drawing.Point(1136, 1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(141, 35)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'Pal_2
        '
        Me.Pal_2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Pal_2.Code = ""
        Me.Pal_2.Controls.Add(Me.cmd_Cancel)
        Me.Pal_2.Controls.Add(Me.cmd_DEL)
        Me.Pal_2.Controls.Add(Me.cmd_OK)
        Me.Pal_2.Data = ""
        Me.Pal_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pal_2.Location = New System.Drawing.Point(3, 757)
        Me.Pal_2.Name = "Pal_2"
        Me.Pal_2.Size = New System.Drawing.Size(1281, 39)
        Me.Pal_2.TabIndex = 1
        Me.Pal_2.Tag = ""
        '
        'Pal_1
        '
        Me.Pal_1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Pal_1.Code = ""
        Me.Pal_1.Controls.Add(Me.chk_Error)
        Me.Pal_1.Controls.Add(Me.cmd_Link7235)
        Me.Pal_1.Controls.Add(Me.cmd_Rule)
        Me.Pal_1.Controls.Add(Me.txt_MappingNo)
        Me.Pal_1.Controls.Add(Me.cmd_Upload)
        Me.Pal_1.Data = ""
        Me.Pal_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pal_1.Location = New System.Drawing.Point(3, 3)
        Me.Pal_1.Name = "Pal_1"
        Me.Pal_1.Size = New System.Drawing.Size(1281, 84)
        Me.Pal_1.TabIndex = 0
        Me.Pal_1.Tag = ""
        '
        'chk_Error
        '
        Me.chk_Error.AutoSize = True
        Me.chk_Error.ButtonTitle = Nothing
        Me.chk_Error.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_Error.ForeColor = System.Drawing.Color.Red
        Me.chk_Error.Location = New System.Drawing.Point(1091, 63)
        Me.chk_Error.Name = "chk_Error"
        Me.chk_Error.Size = New System.Drawing.Size(86, 18)
        Me.chk_Error.TabIndex = 142
        Me.chk_Error.Text = "Error only"
        Me.chk_Error.UseVisualStyleBackColor = True
        Me.chk_Error.Visible = False
        '
        'cmd_Link7235
        '
        Me.cmd_Link7235.BackYesno = False
        Me.cmd_Link7235.ButtonBackColor = System.Drawing.Color.Lime
        Me.cmd_Link7235.ButtonEnabled = True
        Me.cmd_Link7235.ButtonFont = Nothing
        Me.cmd_Link7235.ButtonForeColor = System.Drawing.Color.Empty
        Me.cmd_Link7235.ButtonName = ""
        Me.cmd_Link7235.ButtonTitle = "UOM!"
        Me.cmd_Link7235.Code = ""
        Me.cmd_Link7235.Data = ""
        Me.cmd_Link7235.DataDecimal = 0
        Me.cmd_Link7235.DataLen = 0
        Me.cmd_Link7235.DataValue = 0
        Me.cmd_Link7235.Layoutpercent = New Decimal(New Integer() {1, 0, 0, 0})
        Me.cmd_Link7235.Location = New System.Drawing.Point(1088, 34)
        Me.cmd_Link7235.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_Link7235.Name = "cmd_Link7235"
        Me.cmd_Link7235.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.cmd_Link7235.Size = New System.Drawing.Size(59, 24)
        Me.cmd_Link7235.TabIndex = 141
        Me.cmd_Link7235.TabStop = False
        Me.cmd_Link7235.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.cmd_Link7235.TextBoxAutoComplete = False
        Me.cmd_Link7235.TextboxBackColor = System.Drawing.Color.Empty
        Me.cmd_Link7235.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Link7235.TextEnabled = True
        Me.cmd_Link7235.TextForeColor = System.Drawing.Color.Empty
        Me.cmd_Link7235.TextMaxLength = 32767
        Me.cmd_Link7235.TextMultiLine = False
        Me.cmd_Link7235.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.cmd_Link7235.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmd_Link7235.UseSendTab = True
        Me.cmd_Link7235.Visible = False
        '
        'cmd_Rule
        '
        Me.cmd_Rule.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmd_Rule.Appearance.Options.UseBackColor = True
        Me.cmd_Rule.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cmd_Rule.Location = New System.Drawing.Point(1089, 4)
        Me.cmd_Rule.Name = "cmd_Rule"
        Me.cmd_Rule.Size = New System.Drawing.Size(58, 25)
        Me.cmd_Rule.TabIndex = 140
        Me.cmd_Rule.Text = "Rule"
        Me.cmd_Rule.Visible = False
        '
        'txt_MappingNo
        '
        Me.txt_MappingNo.FormattingEnabled = True
        Me.txt_MappingNo.Location = New System.Drawing.Point(885, 6)
        Me.txt_MappingNo.Name = "txt_MappingNo"
        Me.txt_MappingNo.Size = New System.Drawing.Size(199, 21)
        Me.txt_MappingNo.TabIndex = 139
        Me.txt_MappingNo.Visible = False
        '
        'cmd_Upload
        '
        Me.cmd_Upload.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmd_Upload.Appearance.Options.UseBackColor = True
        Me.cmd_Upload.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.cmd_Upload.Location = New System.Drawing.Point(885, 33)
        Me.cmd_Upload.Name = "cmd_Upload"
        Me.cmd_Upload.Size = New System.Drawing.Size(199, 51)
        Me.cmd_Upload.TabIndex = 9
        Me.cmd_Upload.Text = "Upload Loading Plan"
        '
        'Vs1
        '
        Me.Vs1.AccessibleDescription = ""
        Me.Vs1.CopyPasteChk = False
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
        Me.Vs1.HorizontalScrollBar.TabIndex = 30
        Me.Vs1.InsChk = True
        Me.Vs1.Location = New System.Drawing.Point(3, 3)
        Me.Vs1.Name = "Vs1"
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
        Me.Vs1.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle1, NamedStyle2, NamedStyle3, NamedStyle4, NamedStyle5})
        Me.Vs1.ReportName = Nothing
        Me.Vs1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.Vs1_Sheet1})
        Me.Vs1.Size = New System.Drawing.Size(1267, 619)
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
        Me.Vs1.Skin = SpreadSkin1
        Me.Vs1.SpreadWjob = 0
        Me.Vs1.TabIndex = 0
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
        Me.Vs1.VerticalScrollBar.TabIndex = 31
        '
        'Vs1_Sheet1
        '
        Me.Vs1_Sheet1.Reset()
        Me.Vs1_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.Vs1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.Vs1_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.ColumnFooter.DefaultStyle.Parent = "Style3"
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.Parent = "Style2"
        Me.Vs1_Sheet1.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs1_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.DefaultStyle.Parent = "Style5"
        Me.Vs1_Sheet1.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.Vs1_Sheet1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.Parent = "Style1"
        Me.Vs1_Sheet1.Rows.Default.Height = 22.0!
        Me.Vs1_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.SheetCornerStyle.Parent = "Style4"
        Me.Vs1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'Tlp_1
        '
        Me.Tlp_1.ColumnCount = 1
        Me.Tlp_1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Tlp_1.Controls.Add(Me.Pal_2, 0, 2)
        Me.Tlp_1.Controls.Add(Me.Pal_1, 0, 0)
        Me.Tlp_1.Controls.Add(Me.ptc_Main, 0, 1)
        Me.Tlp_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tlp_1.Location = New System.Drawing.Point(0, 0)
        Me.Tlp_1.Name = "Tlp_1"
        Me.Tlp_1.RowCount = 3
        Me.Tlp_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.Tlp_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Tlp_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.Tlp_1.Size = New System.Drawing.Size(1287, 799)
        Me.Tlp_1.TabIndex = 103
        '
        'ptc_Main
        '
        Me.ptc_Main.Controls.Add(Me.TabPage1)
        Me.ptc_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ptc_Main.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ptc_Main.ItemSize = New System.Drawing.Size(1200, 25)
        Me.ptc_Main.Location = New System.Drawing.Point(3, 93)
        Me.ptc_Main.Name = "ptc_Main"
        Me.ptc_Main.SelectedIndex = 0
        Me.ptc_Main.Size = New System.Drawing.Size(1281, 658)
        Me.ptc_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.ptc_Main.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Vs1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1273, 625)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Loading Plan Excel"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ISUD4958U
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1287, 799)
        Me.Controls.Add(Me.Tlp_1)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "ISUD4958U"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOADING PLAN UPLOAD PROCESSING (ISUD4958U)"
        CType(Me.Pal_2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pal_2.ResumeLayout(False)
        CType(Me.Pal_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pal_1.ResumeLayout(False)
        Me.Pal_1.PerformLayout()
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tlp_1.ResumeLayout(False)
        Me.ptc_Main.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents cmd_DEL As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents Pal_2 As PSMGlobal.PeacePanel
    Friend WithEvents Vs1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents Pal_1 As PSMGlobal.PeacePanel
    Public WithEvents Vs1 As PSMGlobal.PeaceFarpoint
    Friend WithEvents Tlp_1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmd_Upload As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ptc_Main As PSMGlobal.PeaceTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cmd_Rule As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_MappingNo As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_Link7235 As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents chk_Error As PSMGlobal.PeaceCheckbox
End Class
