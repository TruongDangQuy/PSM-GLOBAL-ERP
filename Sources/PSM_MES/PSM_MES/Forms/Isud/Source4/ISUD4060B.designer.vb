<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD4060B
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD4060B))
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
        Me.Frame4 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_cdLineProd1 = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_QtyOrder = New PSMGlobal.SelectLabelText()
        Me.txt_cdFactory = New PSMGlobal.SelectPeaceHLPButton()
        Me.cmd_Search = New PSMGlobal.PeaceButton(Me.components)
        Me.txt_cdMainProcess = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_SealNo = New PSMGlobal.SelectPeaceHLPButton()
        Me.vS1 = New PSMGlobal.PeaceFarpoint()
        Me.vS1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.txt_SdateEdate = New PSMGlobal.SelectPeaceCalDou()
        Me.txt_QtyDate = New PSMGlobal.SelectLabelText()
        Me.Cms_2 = New PSMGlobal.PeaceContextMenuStrip(Me.components)
        Me.Cms_1 = New PSMGlobal.PeaceContextMenuStrip(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.txt_Article = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdLineProd2 = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdLineProd3 = New PSMGlobal.SelectPeaceHLPButton()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.vS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vS1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Frame4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1168, 372)
        Me.TableLayoutPanel1.TabIndex = 44
        '
        'Frame4
        '
        Me.Frame4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Frame4.Code = ""
        Me.Frame4.Controls.Add(Me.cmd_Cancel)
        Me.Frame4.Controls.Add(Me.cmd_OK)
        Me.Frame4.Data = ""
        Me.Frame4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame4.Location = New System.Drawing.Point(3, 332)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Size = New System.Drawing.Size(1162, 37)
        Me.Frame4.TabIndex = 1
        Me.Frame4.Tag = ""
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.ButtonTitle = Nothing
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.Image = CType(resources.GetObject("cmd_Cancel.Image"), System.Drawing.Image)
        Me.cmd_Cancel.ImageAlign = 16
        Me.cmd_Cancel.Location = New System.Drawing.Point(1017, 0)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(141, 35)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.TabStop = False
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'cmd_OK
        '
        Me.cmd_OK.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_OK.ButtonTitle = Nothing
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Image = CType(resources.GetObject("cmd_OK.Image"), System.Drawing.Image)
        Me.cmd_OK.ImageAlign = 16
        Me.cmd_OK.Location = New System.Drawing.Point(872, 0)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(141, 35)
        Me.cmd_OK.TabIndex = 0
        Me.cmd_OK.TabStop = False
        Me.cmd_OK.Text = "SAVE(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_cdLineProd3)
        Me.Panel1.Controls.Add(Me.txt_cdLineProd2)
        Me.Panel1.Controls.Add(Me.txt_cdLineProd1)
        Me.Panel1.Controls.Add(Me.txt_QtyOrder)
        Me.Panel1.Controls.Add(Me.txt_cdFactory)
        Me.Panel1.Controls.Add(Me.cmd_Search)
        Me.Panel1.Controls.Add(Me.txt_cdMainProcess)
        Me.Panel1.Controls.Add(Me.txt_Article)
        Me.Panel1.Controls.Add(Me.txt_SealNo)
        Me.Panel1.Controls.Add(Me.vS1)
        Me.Panel1.Controls.Add(Me.txt_SdateEdate)
        Me.Panel1.Controls.Add(Me.txt_QtyDate)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1162, 323)
        Me.Panel1.TabIndex = 2
        '
        'txt_cdLineProd1
        '
        Me.txt_cdLineProd1.BackYesno = False
        Me.txt_cdLineProd1.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdLineProd1.ButtonEnabled = True
        Me.txt_cdLineProd1.ButtonFont = Nothing
        Me.txt_cdLineProd1.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd1.ButtonName = ""
        Me.txt_cdLineProd1.ButtonTitle = "Line 1"
        Me.txt_cdLineProd1.Code = ""
        Me.txt_cdLineProd1.Data = ""
        Me.txt_cdLineProd1.DataDecimal = 0
        Me.txt_cdLineProd1.DataLen = 0
        Me.txt_cdLineProd1.DataValue = 0
        Me.txt_cdLineProd1.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdLineProd1.Location = New System.Drawing.Point(712, 4)
        Me.txt_cdLineProd1.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdLineProd1.Name = "txt_cdLineProd1"
        Me.txt_cdLineProd1.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdLineProd1.Size = New System.Drawing.Size(259, 24)
        Me.txt_cdLineProd1.TabIndex = 55
        Me.txt_cdLineProd1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdLineProd1.TextBoxAutoComplete = False
        Me.txt_cdLineProd1.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd1.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdLineProd1.TextEnabled = True
        Me.txt_cdLineProd1.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd1.TextMaxLength = 32767
        Me.txt_cdLineProd1.TextMultiLine = False
        Me.txt_cdLineProd1.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdLineProd1.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdLineProd1.UseSendTab = True
        '
        'txt_QtyOrder
        '
        Me.txt_QtyOrder.BackYesno = True
        Me.txt_QtyOrder.ButtonTitle = Nothing
        Me.txt_QtyOrder.Code = Nothing
        Me.txt_QtyOrder.Data = "1"
        Me.txt_QtyOrder.DataDecimal = 0
        Me.txt_QtyOrder.DataLen = 1
        Me.txt_QtyOrder.DataValue = 1
        Me.txt_QtyOrder.FormatDecimal = 0
        Me.txt_QtyOrder.FormatValue = False
        Me.txt_QtyOrder.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_QtyOrder.LableEnabled = True
        Me.txt_QtyOrder.LableFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_QtyOrder.LableForeColor = System.Drawing.Color.Empty
        Me.txt_QtyOrder.LableTitle = "Qty Order"
        Me.txt_QtyOrder.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_QtyOrder.Location = New System.Drawing.Point(268, 32)
        Me.txt_QtyOrder.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_QtyOrder.Name = "txt_QtyOrder"
        Me.txt_QtyOrder.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_QtyOrder.Size = New System.Drawing.Size(220, 24)
        Me.txt_QtyOrder.TabIndex = 51
        Me.txt_QtyOrder.TabStop = False
        Me.txt_QtyOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_QtyOrder.TextBoxAutoComplete = True
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
        'txt_cdFactory
        '
        Me.txt_cdFactory.BackYesno = False
        Me.txt_cdFactory.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdFactory.ButtonEnabled = True
        Me.txt_cdFactory.ButtonFont = Nothing
        Me.txt_cdFactory.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.ButtonName = ""
        Me.txt_cdFactory.ButtonTitle = "Factory"
        Me.txt_cdFactory.Code = ""
        Me.txt_cdFactory.Data = ""
        Me.txt_cdFactory.DataDecimal = 0
        Me.txt_cdFactory.DataLen = 0
        Me.txt_cdFactory.DataValue = 0
        Me.txt_cdFactory.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdFactory.Location = New System.Drawing.Point(490, 4)
        Me.txt_cdFactory.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdFactory.Name = "txt_cdFactory"
        Me.txt_cdFactory.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdFactory.Size = New System.Drawing.Size(220, 24)
        Me.txt_cdFactory.TabIndex = 54
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
        'cmd_Search
        '
        Me.cmd_Search.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_Search.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Search.Appearance.Options.UseBackColor = True
        Me.cmd_Search.Appearance.Options.UseFont = True
        Me.cmd_Search.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Search.ButtonTitle = Nothing
        Me.cmd_Search.Code = Nothing
        Me.cmd_Search.Data = Nothing
        Me.cmd_Search.Image = Global.PSMGlobal.My.Resources.Resources.Find_16x16
        Me.cmd_Search.ImageAlign = 16
        Me.cmd_Search.Location = New System.Drawing.Point(975, 4)
        Me.cmd_Search.Name = "cmd_Search"
        Me.cmd_Search.Size = New System.Drawing.Size(183, 76)
        Me.cmd_Search.TabIndex = 50
        Me.cmd_Search.TabStop = False
        Me.cmd_Search.Text = "Search(&S)"
        Me.cmd_Search.UseVisualStyleBackColor = False
        '
        'txt_cdMainProcess
        '
        Me.txt_cdMainProcess.BackYesno = False
        Me.txt_cdMainProcess.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdMainProcess.ButtonEnabled = True
        Me.txt_cdMainProcess.ButtonFont = Nothing
        Me.txt_cdMainProcess.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdMainProcess.ButtonName = "btn_Tool"
        Me.txt_cdMainProcess.ButtonTitle = "Main Proess"
        Me.txt_cdMainProcess.Code = ""
        Me.txt_cdMainProcess.Data = ""
        Me.txt_cdMainProcess.DataDecimal = 0
        Me.txt_cdMainProcess.DataLen = 0
        Me.txt_cdMainProcess.DataValue = 0
        Me.txt_cdMainProcess.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdMainProcess.Location = New System.Drawing.Point(7, 32)
        Me.txt_cdMainProcess.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdMainProcess.Name = "txt_cdMainProcess"
        Me.txt_cdMainProcess.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdMainProcess.Size = New System.Drawing.Size(259, 24)
        Me.txt_cdMainProcess.TabIndex = 49
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
        'txt_SealNo
        '
        Me.txt_SealNo.BackYesno = False
        Me.txt_SealNo.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_SealNo.ButtonEnabled = True
        Me.txt_SealNo.ButtonFont = Nothing
        Me.txt_SealNo.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_SealNo.ButtonName = "btn_Tool"
        Me.txt_SealNo.ButtonTitle = "Seal No"
        Me.txt_SealNo.Code = ""
        Me.txt_SealNo.Data = ""
        Me.txt_SealNo.DataDecimal = 0
        Me.txt_SealNo.DataLen = 0
        Me.txt_SealNo.DataValue = 0
        Me.txt_SealNo.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_SealNo.Location = New System.Drawing.Point(7, 58)
        Me.txt_SealNo.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_SealNo.Name = "txt_SealNo"
        Me.txt_SealNo.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_SealNo.Size = New System.Drawing.Size(259, 24)
        Me.txt_SealNo.TabIndex = 47
        Me.txt_SealNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_SealNo.TextBoxAutoComplete = False
        Me.txt_SealNo.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_SealNo.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SealNo.TextEnabled = True
        Me.txt_SealNo.TextForeColor = System.Drawing.Color.Empty
        Me.txt_SealNo.TextMaxLength = 32767
        Me.txt_SealNo.TextMultiLine = False
        Me.txt_SealNo.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_SealNo.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_SealNo.UseSendTab = True
        '
        'vS1
        '
        Me.vS1.AccessibleDescription = "vS1, Sheet1, Row 0, Column 0, "
        Me.vS1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.vS1.CopyPasteChk = True
        Me.vS1.FocusRenderer = EnhancedFocusIndicatorRenderer2
        Me.vS1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vS1.HorizontalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.vS1.HorizontalScrollBar.Name = ""
        EnhancedScrollBarRenderer4.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer4.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer4.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer4.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer4.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer4.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer4.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer4.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.vS1.HorizontalScrollBar.Renderer = EnhancedScrollBarRenderer4
        Me.vS1.HorizontalScrollBar.TabIndex = 0
        Me.vS1.InsChk = True
        Me.vS1.Location = New System.Drawing.Point(7, 86)
        Me.vS1.Name = "vS1"
        NamedStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle6.Border = BevelBorder5
        NamedStyle6.CanFocus = False
        TextCellType5.WordWrap = True
        NamedStyle6.CellType = TextCellType5
        NamedStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        NamedStyle6.ForeColor = System.Drawing.Color.White
        NamedStyle6.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle6.Locked = False
        NamedStyle6.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle6.Renderer = TextCellType5
        NamedStyle6.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle6.VisualStyles = FarPoint.Win.VisualStyles.Off
        NamedStyle7.Border = BevelBorder6
        NamedStyle7.CellType = TextCellType6
        NamedStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamedStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle7.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle7.Locked = False
        NamedStyle7.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle7.Renderer = TextCellType6
        NamedStyle7.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle8.Border = BevelBorder7
        NamedStyle8.CanFocus = False
        NamedStyle8.CellType = TextCellType7
        NamedStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        NamedStyle9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        NamedStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle9.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle9.Locked = False
        NamedStyle9.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle9.Renderer = TextCellType8
        NamedStyle9.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle10.BackColor = System.Drawing.SystemColors.Window
        NamedStyle10.CellType = GeneralCellType2
        NamedStyle10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        NamedStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        NamedStyle10.Locked = False
        NamedStyle10.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle10.Renderer = GeneralCellType2
        Me.vS1.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle6, NamedStyle7, NamedStyle8, NamedStyle9, NamedStyle10})
        Me.vS1.ReportName = Nothing
        Me.vS1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.vS1_Sheet1})
        Me.vS1.Size = New System.Drawing.Size(1152, 234)
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
        SpreadSkin2.Name = "KhanhHung1"
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
        Me.vS1.Skin = SpreadSkin2
        Me.vS1.SpreadWjob = 0
        Me.vS1.TabIndex = 0
        Me.vS1.VerticalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.vS1.VerticalScrollBar.Name = ""
        EnhancedScrollBarRenderer6.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer6.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer6.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer6.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer6.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer6.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer6.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer6.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.vS1.VerticalScrollBar.Renderer = EnhancedScrollBarRenderer6
        Me.vS1.VerticalScrollBar.TabIndex = 1
        '
        'vS1_Sheet1
        '
        Me.vS1_Sheet1.Reset()
        Me.vS1_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.vS1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.vS1_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.ColumnFooter.DefaultStyle.Parent = "Style3"
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.Parent = "Style2"
        Me.vS1_Sheet1.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vS1_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.DefaultStyle.Parent = "Style5"
        Me.vS1_Sheet1.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.vS1_Sheet1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.RowHeader.DefaultStyle.Parent = "Style1"
        Me.vS1_Sheet1.Rows.Default.Height = 22.0!
        Me.vS1_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.SheetCornerStyle.Parent = "Style4"
        Me.vS1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'txt_SdateEdate
        '
        Me.txt_SdateEdate.ButtonTitle = "Period"
        Me.txt_SdateEdate.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_SdateEdate.Location = New System.Drawing.Point(7, 7)
        Me.txt_SdateEdate.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.txt_SdateEdate.Name = "txt_SdateEdate"
        Me.txt_SdateEdate.Size = New System.Drawing.Size(259, 21)
        Me.txt_SdateEdate.TabIndex = 46
        Me.txt_SdateEdate.text1 = ""
        Me.txt_SdateEdate.text2 = ""
        Me.txt_SdateEdate.TextBoxFont = New System.Drawing.Font("Tahoma", 8.0!)
        '
        'txt_QtyDate
        '
        Me.txt_QtyDate.BackYesno = True
        Me.txt_QtyDate.ButtonTitle = Nothing
        Me.txt_QtyDate.Code = Nothing
        Me.txt_QtyDate.Data = "1"
        Me.txt_QtyDate.DataDecimal = 0
        Me.txt_QtyDate.DataLen = 1
        Me.txt_QtyDate.DataValue = 1
        Me.txt_QtyDate.FormatDecimal = 0
        Me.txt_QtyDate.FormatValue = False
        Me.txt_QtyDate.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_QtyDate.LableEnabled = True
        Me.txt_QtyDate.LableFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_QtyDate.LableForeColor = System.Drawing.Color.Empty
        Me.txt_QtyDate.LableTitle = "Qty Date"
        Me.txt_QtyDate.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_QtyDate.Location = New System.Drawing.Point(268, 4)
        Me.txt_QtyDate.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_QtyDate.Name = "txt_QtyDate"
        Me.txt_QtyDate.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_QtyDate.Size = New System.Drawing.Size(220, 24)
        Me.txt_QtyDate.TabIndex = 2
        Me.txt_QtyDate.TabStop = False
        Me.txt_QtyDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_QtyDate.TextBoxAutoComplete = True
        Me.txt_QtyDate.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_QtyDate.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_QtyDate.TextEnabled = True
        Me.txt_QtyDate.TextForeColor = System.Drawing.Color.Empty
        Me.txt_QtyDate.TextMaxLength = 32767
        Me.txt_QtyDate.TextMultiLine = False
        Me.txt_QtyDate.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_QtyDate.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_QtyDate.UseSendTab = True
        '
        'Cms_2
        '
        Me.Cms_2.Name = "Cms_1"
        Me.Cms_2.Size = New System.Drawing.Size(61, 4)
        '
        'Cms_1
        '
        Me.Cms_1.Name = "Cms_1"
        Me.Cms_1.Size = New System.Drawing.Size(61, 4)
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'txt_Article
        '
        Me.txt_Article.BackYesno = False
        Me.txt_Article.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_Article.ButtonEnabled = True
        Me.txt_Article.ButtonFont = Nothing
        Me.txt_Article.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_Article.ButtonName = "btn_Tool"
        Me.txt_Article.ButtonTitle = "Article"
        Me.txt_Article.Code = ""
        Me.txt_Article.Data = ""
        Me.txt_Article.DataDecimal = 0
        Me.txt_Article.DataLen = 0
        Me.txt_Article.DataValue = 0
        Me.txt_Article.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_Article.Location = New System.Drawing.Point(268, 58)
        Me.txt_Article.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Article.Name = "txt_Article"
        Me.txt_Article.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Article.Size = New System.Drawing.Size(220, 24)
        Me.txt_Article.TabIndex = 48
        Me.txt_Article.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Article.TextBoxAutoComplete = False
        Me.txt_Article.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Article.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Article.TextEnabled = True
        Me.txt_Article.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Article.TextMaxLength = 32767
        Me.txt_Article.TextMultiLine = False
        Me.txt_Article.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Article.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Article.UseSendTab = True
        '
        'txt_cdLineProd2
        '
        Me.txt_cdLineProd2.BackYesno = False
        Me.txt_cdLineProd2.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdLineProd2.ButtonEnabled = True
        Me.txt_cdLineProd2.ButtonFont = Nothing
        Me.txt_cdLineProd2.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd2.ButtonName = ""
        Me.txt_cdLineProd2.ButtonTitle = "Line 2"
        Me.txt_cdLineProd2.Code = ""
        Me.txt_cdLineProd2.Data = ""
        Me.txt_cdLineProd2.DataDecimal = 0
        Me.txt_cdLineProd2.DataLen = 0
        Me.txt_cdLineProd2.DataValue = 0
        Me.txt_cdLineProd2.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdLineProd2.Location = New System.Drawing.Point(712, 30)
        Me.txt_cdLineProd2.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdLineProd2.Name = "txt_cdLineProd2"
        Me.txt_cdLineProd2.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdLineProd2.Size = New System.Drawing.Size(259, 24)
        Me.txt_cdLineProd2.TabIndex = 56
        Me.txt_cdLineProd2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdLineProd2.TextBoxAutoComplete = False
        Me.txt_cdLineProd2.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd2.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdLineProd2.TextEnabled = True
        Me.txt_cdLineProd2.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd2.TextMaxLength = 32767
        Me.txt_cdLineProd2.TextMultiLine = False
        Me.txt_cdLineProd2.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdLineProd2.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdLineProd2.UseSendTab = True
        '
        'txt_cdLineProd3
        '
        Me.txt_cdLineProd3.BackYesno = False
        Me.txt_cdLineProd3.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdLineProd3.ButtonEnabled = True
        Me.txt_cdLineProd3.ButtonFont = Nothing
        Me.txt_cdLineProd3.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd3.ButtonName = ""
        Me.txt_cdLineProd3.ButtonTitle = "Line 3"
        Me.txt_cdLineProd3.Code = ""
        Me.txt_cdLineProd3.Data = ""
        Me.txt_cdLineProd3.DataDecimal = 0
        Me.txt_cdLineProd3.DataLen = 0
        Me.txt_cdLineProd3.DataValue = 0
        Me.txt_cdLineProd3.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdLineProd3.Location = New System.Drawing.Point(712, 56)
        Me.txt_cdLineProd3.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdLineProd3.Name = "txt_cdLineProd3"
        Me.txt_cdLineProd3.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdLineProd3.Size = New System.Drawing.Size(259, 24)
        Me.txt_cdLineProd3.TabIndex = 57
        Me.txt_cdLineProd3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdLineProd3.TextBoxAutoComplete = False
        Me.txt_cdLineProd3.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd3.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdLineProd3.TextEnabled = True
        Me.txt_cdLineProd3.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd3.TextMaxLength = 32767
        Me.txt_cdLineProd3.TextMultiLine = False
        Me.txt_cdLineProd3.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdLineProd3.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdLineProd3.UseSendTab = True
        '
        'ISUD4060B
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1168, 372)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "ISUD4060B"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PLANNING WORKING CONTROL (ISUD4060B)"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.vS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vS1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Frame4 As PSMGlobal.PeacePanel
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents Cms_2 As PSMGlobal.PeaceContextMenuStrip
    Friend WithEvents Cms_1 As PSMGlobal.PeaceContextMenuStrip
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_QtyDate As PSMGlobal.SelectLabelText
    Public WithEvents vS1 As PSMGlobal.PeaceFarpoint
    Friend WithEvents vS1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents txt_SdateEdate As PSMGlobal.SelectPeaceCalDou
    Friend WithEvents txt_SealNo As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdMainProcess As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents cmd_Search As PSMGlobal.PeaceButton
    Friend WithEvents txt_QtyOrder As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdLineProd1 As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdFactory As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdLineProd3 As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdLineProd2 As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_Article As PSMGlobal.SelectPeaceHLPButton
End Class
