<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD7550A
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
        Dim EnhancedScrollBarRenderer4 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim NamedStyle7 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("DataAreaDefault")
        Dim GeneralCellType3 As FarPoint.Win.Spread.CellType.GeneralCellType = New FarPoint.Win.Spread.CellType.GeneralCellType()
        Dim NamedStyle8 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style2")
        Dim BevelBorder5 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType6 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle9 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style3")
        Dim BevelBorder6 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType7 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle10 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style1")
        Dim BevelBorder7 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType8 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle11 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style4")
        Dim BevelBorder8 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType9 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle12 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style5")
        Dim GeneralCellType4 As FarPoint.Win.Spread.CellType.GeneralCellType = New FarPoint.Win.Spread.CellType.GeneralCellType()
        Dim SpreadSkin2 As FarPoint.Win.Spread.SpreadSkin = New FarPoint.Win.Spread.SpreadSkin()
        Dim EnhancedFocusIndicatorRenderer2 As FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer = New FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer()
        Dim EnhancedInterfaceRenderer2 As FarPoint.Win.Spread.EnhancedInterfaceRenderer = New FarPoint.Win.Spread.EnhancedInterfaceRenderer()
        Dim EnhancedScrollBarRenderer5 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim EnhancedScrollBarRenderer6 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim Vs1_InputMapWhenFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim Vs1_InputMapWhenFocusedSingleSelect As FarPoint.Win.Spread.InputMap
        Dim Vs1_InputMapWhenAncestorOfFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim Vs1_InputMapWhenAncestorOfFocusedSingleSelect As FarPoint.Win.Spread.InputMap
        Dim TextCellType10 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD7550A))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_ShoesCode = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_OrderNo = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdQAResult = New PSMGlobal.SelectPeaceHLPButton()
        Me.Vs1 = New PSMGlobal.PeaceFarpoint()
        Me.Vs1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.txt_FileName = New PSMGlobal.SelectLabelText()
        Me.txt_QAKey = New PSMGlobal.SelectLabelText()
        Me.txt_DateQA = New PSMGlobal.SelectPeaceCalSin()
        Me.txtFileToUpload = New PSMGlobal.SelectLabelText()
        Me.cmdUpload = New PSMGlobal.PeaceButton(Me.components)
        Me.cmdBrowse = New PSMGlobal.PeaceButton(Me.components)
        Me.txt_QAComment = New PSMGlobal.PeaceMemo(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_DateLable = New PSMGlobal.SelectLabelText()
        Me.txt_CustPONO = New PSMGlobal.SelectLabelText()
        Me.txt_ProductCode = New PSMGlobal.SelectLabelText()
        Me.txt_cdProductSize = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_CustomerCode = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdProductType = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdGender = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_Article = New PSMGlobal.SelectLabelText()
        Me.txt_cdSpecState = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_Style = New PSMGlobal.SelectLabelText()
        Me.txt_CustSpecNo = New PSMGlobal.SelectLabelText()
        Me.lblUploadStatus = New PSMGlobal.PeaceLabel(Me.components)
        Me.txt_FormName = New PSMGlobal.SelectLabelText()
        Me.cmb_State = New PSMGlobal.PeaceCombobox(Me.components)
        Me.chk_MultiView = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Vs1_InputMapWhenFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenFocusedSingleSelect = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenFocusedSingleSelect.Parent = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedSingleSelect = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedSingleSelect.Parent = New FarPoint.Win.Spread.InputMap()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_QAComment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.8883!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.1117!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Vs1, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 41)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 169.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(752, 470)
        Me.TableLayoutPanel1.TabIndex = 213
        '
        'Panel1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel1, 2)
        Me.Panel1.Controls.Add(Me.txt_ShoesCode)
        Me.Panel1.Controls.Add(Me.txt_QAComment)
        Me.Panel1.Controls.Add(Me.txt_OrderNo)
        Me.Panel1.Controls.Add(Me.txt_cdQAResult)
        Me.Panel1.Controls.Add(Me.txt_FileName)
        Me.Panel1.Controls.Add(Me.txt_QAKey)
        Me.Panel1.Controls.Add(Me.txt_DateQA)
        Me.Panel1.Controls.Add(Me.txtFileToUpload)
        Me.Panel1.Controls.Add(Me.cmdUpload)
        Me.Panel1.Controls.Add(Me.cmdBrowse)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(746, 163)
        Me.Panel1.TabIndex = 0
        '
        'txt_ShoesCode
        '
        Me.txt_ShoesCode.BackYesno = False
        Me.txt_ShoesCode.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_ShoesCode.ButtonEnabled = True
        Me.txt_ShoesCode.ButtonFont = Nothing
        Me.txt_ShoesCode.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_ShoesCode.ButtonName = "Const_LargeGroupMaterial"
        Me.txt_ShoesCode.ButtonTitle = "Item Code"
        Me.txt_ShoesCode.Code = ""
        Me.txt_ShoesCode.Data = ""
        Me.txt_ShoesCode.DataDecimal = 0
        Me.txt_ShoesCode.DataLen = 0
        Me.txt_ShoesCode.DataValue = 1
        Me.txt_ShoesCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ShoesCode.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_ShoesCode.Location = New System.Drawing.Point(7, 111)
        Me.txt_ShoesCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ShoesCode.Name = "txt_ShoesCode"
        Me.txt_ShoesCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ShoesCode.Size = New System.Drawing.Size(213, 23)
        Me.txt_ShoesCode.TabIndex = 5
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
        'txt_OrderNo
        '
        Me.txt_OrderNo.BackYesno = False
        Me.txt_OrderNo.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_OrderNo.ButtonEnabled = True
        Me.txt_OrderNo.ButtonFont = Nothing
        Me.txt_OrderNo.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_OrderNo.ButtonName = "Const_LargeGroupMaterial"
        Me.txt_OrderNo.ButtonTitle = "OrderNo"
        Me.txt_OrderNo.Code = ""
        Me.txt_OrderNo.Data = ""
        Me.txt_OrderNo.DataDecimal = 0
        Me.txt_OrderNo.DataLen = 0
        Me.txt_OrderNo.DataValue = 1
        Me.txt_OrderNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_OrderNo.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_OrderNo.Location = New System.Drawing.Point(7, 86)
        Me.txt_OrderNo.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_OrderNo.Name = "txt_OrderNo"
        Me.txt_OrderNo.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_OrderNo.Size = New System.Drawing.Size(213, 23)
        Me.txt_OrderNo.TabIndex = 3
        Me.txt_OrderNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_OrderNo.TextBoxAutoComplete = True
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
        'txt_cdQAResult
        '
        Me.txt_cdQAResult.BackYesno = False
        Me.txt_cdQAResult.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdQAResult.ButtonEnabled = True
        Me.txt_cdQAResult.ButtonFont = Nothing
        Me.txt_cdQAResult.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdQAResult.ButtonName = "Const_LargeGroupMaterial"
        Me.txt_cdQAResult.ButtonTitle = "QA Result"
        Me.txt_cdQAResult.Code = ""
        Me.txt_cdQAResult.Data = ""
        Me.txt_cdQAResult.DataDecimal = 0
        Me.txt_cdQAResult.DataLen = 0
        Me.txt_cdQAResult.DataValue = 1
        Me.txt_cdQAResult.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdQAResult.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_cdQAResult.Location = New System.Drawing.Point(7, 61)
        Me.txt_cdQAResult.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdQAResult.Name = "txt_cdQAResult"
        Me.txt_cdQAResult.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdQAResult.Size = New System.Drawing.Size(213, 23)
        Me.txt_cdQAResult.TabIndex = 2
        Me.txt_cdQAResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdQAResult.TextBoxAutoComplete = True
        Me.txt_cdQAResult.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdQAResult.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_cdQAResult.TextEnabled = True
        Me.txt_cdQAResult.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdQAResult.TextMaxLength = 32767
        Me.txt_cdQAResult.TextMultiLine = False
        Me.txt_cdQAResult.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdQAResult.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdQAResult.UseSendTab = True
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
        Me.Vs1.FocusRenderer = New FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer(1)
        Me.Vs1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs1.HorizontalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.Vs1.HorizontalScrollBar.Name = ""
        EnhancedScrollBarRenderer4.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer4.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer4.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer4.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer4.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer4.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer4.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer4.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.Vs1.HorizontalScrollBar.Renderer = EnhancedScrollBarRenderer4
        Me.Vs1.HorizontalScrollBar.TabIndex = 0
        Me.Vs1.InsChk = True
        Me.Vs1.Location = New System.Drawing.Point(315, 169)
        Me.Vs1.Margin = New System.Windows.Forms.Padding(0)
        Me.Vs1.Name = "Vs1"
        NamedStyle7.BackColor = System.Drawing.SystemColors.Window
        NamedStyle7.CellType = GeneralCellType3
        NamedStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        NamedStyle7.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle7.Renderer = GeneralCellType3
        NamedStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle8.Border = BevelBorder5
        NamedStyle8.CanFocus = False
        NamedStyle8.CellType = TextCellType6
        NamedStyle8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        NamedStyle8.ForeColor = System.Drawing.Color.White
        NamedStyle8.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle8.Locked = False
        NamedStyle8.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle8.Renderer = TextCellType6
        NamedStyle8.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle8.VisualStyles = FarPoint.Win.VisualStyles.Off
        NamedStyle9.Border = BevelBorder6
        NamedStyle9.CellType = TextCellType7
        NamedStyle9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamedStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle9.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle9.Locked = False
        NamedStyle9.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle9.Renderer = TextCellType7
        NamedStyle9.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle10.Border = BevelBorder7
        NamedStyle10.CanFocus = False
        NamedStyle10.CellType = TextCellType8
        NamedStyle10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamedStyle10.ForeColor = System.Drawing.Color.White
        NamedStyle10.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle10.Locked = False
        NamedStyle10.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle10.Renderer = TextCellType8
        NamedStyle10.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle10.VisualStyles = FarPoint.Win.VisualStyles.Off
        NamedStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle11.Border = BevelBorder8
        NamedStyle11.CellType = TextCellType9
        NamedStyle11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        NamedStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle11.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle11.Locked = False
        NamedStyle11.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle11.Renderer = TextCellType9
        NamedStyle11.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle12.BackColor = System.Drawing.SystemColors.Window
        NamedStyle12.CellType = GeneralCellType4
        NamedStyle12.Font = New System.Drawing.Font("Tahoma", 9.0!)
        NamedStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        NamedStyle12.Locked = False
        NamedStyle12.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle12.Renderer = GeneralCellType4
        Me.Vs1.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle7, NamedStyle8, NamedStyle9, NamedStyle10, NamedStyle11, NamedStyle12})
        Me.Vs1.ReportName = Nothing
        Me.Vs1.SheetDSName = Nothing
        Me.Vs1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.Vs1_Sheet1})
        Me.Vs1.Size = New System.Drawing.Size(434, 298)
        SpreadSkin2.ColumnFooterDefaultStyle = NamedStyle9
        SpreadSkin2.ColumnHeaderDefaultStyle = NamedStyle8
        SpreadSkin2.CornerDefaultStyle = NamedStyle11
        SpreadSkin2.DefaultStyle = NamedStyle12
        SpreadSkin2.FocusRenderer = EnhancedFocusIndicatorRenderer2
        EnhancedInterfaceRenderer2.ScrollBoxBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(221, Byte), Integer))
        EnhancedInterfaceRenderer2.SheetTabLowerActiveColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(244, Byte), Integer))
        EnhancedInterfaceRenderer2.SheetTabLowerNormalColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(249, Byte), Integer))
        EnhancedInterfaceRenderer2.SheetTabUpperActiveColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(244, Byte), Integer))
        EnhancedInterfaceRenderer2.SheetTabUpperNormalColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(249, Byte), Integer))
        EnhancedInterfaceRenderer2.TabStripBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(221, Byte), Integer))
        SpreadSkin2.InterfaceRenderer = EnhancedInterfaceRenderer2
        SpreadSkin2.Name = "Hung123"
        SpreadSkin2.RowHeaderDefaultStyle = NamedStyle10
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
        Me.Vs1.Skin = SpreadSkin2
        Me.Vs1.SpreadWjob = 0
        Me.Vs1.TabIndex = 201
        Me.Vs1.TabStop = False
        Me.Vs1.TabStrip.DefaultSheetTab.BackColor = System.Drawing.Color.White
        Me.Vs1.TabStrip.DefaultSheetTab.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vs1.VerticalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.Vs1.VerticalScrollBar.Name = ""
        EnhancedScrollBarRenderer6.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer6.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer6.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer6.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer6.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer6.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer6.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer6.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.Vs1.VerticalScrollBar.Renderer = EnhancedScrollBarRenderer6
        Me.Vs1.VerticalScrollBar.TabIndex = 1
        Vs1_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Vs1_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnWrap)
        Vs1_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
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
        TextCellType10.WordWrap = True
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.CellType = TextCellType10
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.Renderer = TextCellType10
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
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.CellType = TextCellType10
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.Renderer = TextCellType10
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
        'txt_FileName
        '
        Me.txt_FileName.BackYesno = False
        Me.txt_FileName.ButtonTitle = Nothing
        Me.txt_FileName.Code = Nothing
        Me.txt_FileName.Data = ""
        Me.txt_FileName.DataDecimal = 0
        Me.txt_FileName.DataLen = 50
        Me.txt_FileName.DataValue = 1
        Me.txt_FileName.Enabled = False
        Me.txt_FileName.FormatDecimal = 0
        Me.txt_FileName.FormatValue = False
        Me.txt_FileName.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_FileName.LableEnabled = True
        Me.txt_FileName.LableFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_FileName.LableForeColor = System.Drawing.Color.Empty
        Me.txt_FileName.LableTitle = "Content"
        Me.txt_FileName.Layoutpercent = New Decimal(New Integer() {12, 0, 0, 131072})
        Me.txt_FileName.Location = New System.Drawing.Point(2, 138)
        Me.txt_FileName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_FileName.Name = "txt_FileName"
        Me.txt_FileName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_FileName.Size = New System.Drawing.Size(743, 24)
        Me.txt_FileName.TabIndex = 6
        Me.txt_FileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_FileName.TextBoxAutoComplete = False
        Me.txt_FileName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_FileName.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FileName.TextEnabled = True
        Me.txt_FileName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_FileName.TextMaxLength = 32767
        Me.txt_FileName.TextMultiLine = False
        Me.txt_FileName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_FileName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_FileName.UseSendTab = True
        '
        'txt_QAKey
        '
        Me.txt_QAKey.BackYesno = False
        Me.txt_QAKey.ButtonTitle = Nothing
        Me.txt_QAKey.Code = Nothing
        Me.txt_QAKey.Data = ""
        Me.txt_QAKey.DataDecimal = 0
        Me.txt_QAKey.DataLen = 50
        Me.txt_QAKey.DataValue = 1
        Me.txt_QAKey.Enabled = False
        Me.txt_QAKey.FormatDecimal = 0
        Me.txt_QAKey.FormatValue = False
        Me.txt_QAKey.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_QAKey.LableEnabled = True
        Me.txt_QAKey.LableFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_QAKey.LableForeColor = System.Drawing.Color.Empty
        Me.txt_QAKey.LableTitle = "QA Key"
        Me.txt_QAKey.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_QAKey.Location = New System.Drawing.Point(7, 7)
        Me.txt_QAKey.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_QAKey.Name = "txt_QAKey"
        Me.txt_QAKey.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_QAKey.Size = New System.Drawing.Size(213, 24)
        Me.txt_QAKey.TabIndex = 0
        Me.txt_QAKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_QAKey.TextBoxAutoComplete = False
        Me.txt_QAKey.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_QAKey.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_QAKey.TextEnabled = True
        Me.txt_QAKey.TextForeColor = System.Drawing.Color.Empty
        Me.txt_QAKey.TextMaxLength = 32767
        Me.txt_QAKey.TextMultiLine = False
        Me.txt_QAKey.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_QAKey.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_QAKey.UseSendTab = True
        '
        'txt_DateQA
        '
        Me.txt_DateQA.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_DateQA.ButtonEnabled = True
        Me.txt_DateQA.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_DateQA.ButtonName = Nothing
        Me.txt_DateQA.ButtonTitle = "Date QA"
        Me.txt_DateQA.Code = ""
        Me.txt_DateQA.Data = "20150101"
        Me.txt_DateQA.DataDecimal = 0
        Me.txt_DateQA.DataLen = 0
        Me.txt_DateQA.DataValue = 0
        Me.txt_DateQA.FormatDecimal = 0
        Me.txt_DateQA.FormatValue = False
        Me.txt_DateQA.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_DateQA.Location = New System.Drawing.Point(7, 33)
        Me.txt_DateQA.Margin = New System.Windows.Forms.Padding(1, 1, 138, 1)
        Me.txt_DateQA.Name = "txt_DateQA"
        Me.txt_DateQA.Size = New System.Drawing.Size(213, 24)
        Me.txt_DateQA.TabIndex = 1
        Me.txt_DateQA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_DateQA.TextBoxAutoComplete = False
        Me.txt_DateQA.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DateQA.TextEnabled = True
        Me.txt_DateQA.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DateQA.TextMaxLength = 32767
        Me.txt_DateQA.TextMultiLine = True
        Me.txt_DateQA.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        '
        'txtFileToUpload
        '
        Me.txtFileToUpload.BackYesno = False
        Me.txtFileToUpload.ButtonTitle = Nothing
        Me.txtFileToUpload.Code = ""
        Me.txtFileToUpload.Data = ""
        Me.txtFileToUpload.DataDecimal = 0
        Me.txtFileToUpload.DataLen = 0
        Me.txtFileToUpload.DataValue = 0
        Me.txtFileToUpload.FormatDecimal = 0
        Me.txtFileToUpload.FormatValue = False
        Me.txtFileToUpload.LableBackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtFileToUpload.LableEnabled = True
        Me.txtFileToUpload.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileToUpload.LableForeColor = System.Drawing.Color.Black
        Me.txtFileToUpload.LableTitle = "Path File"
        Me.txtFileToUpload.Layoutpercent = New Decimal(New Integer() {2, 0, 0, 65536})
        Me.txtFileToUpload.Location = New System.Drawing.Point(800, 5)
        Me.txtFileToUpload.Margin = New System.Windows.Forms.Padding(1)
        Me.txtFileToUpload.Name = "txtFileToUpload"
        Me.txtFileToUpload.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txtFileToUpload.Size = New System.Drawing.Size(454, 24)
        Me.txtFileToUpload.TabIndex = 204
        Me.txtFileToUpload.TabStop = False
        Me.txtFileToUpload.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtFileToUpload.TextBoxAutoComplete = False
        Me.txtFileToUpload.TextboxBackColor = System.Drawing.Color.Empty
        Me.txtFileToUpload.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txtFileToUpload.TextEnabled = False
        Me.txtFileToUpload.TextForeColor = System.Drawing.Color.Blue
        Me.txtFileToUpload.TextMaxLength = 32767
        Me.txtFileToUpload.TextMultiLine = False
        Me.txtFileToUpload.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFileToUpload.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtFileToUpload.UseSendTab = True
        '
        'cmdUpload
        '
        Me.cmdUpload.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdUpload.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdUpload.Appearance.Options.UseFont = True
        Me.cmdUpload.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdUpload.ButtonTitle = Nothing
        Me.cmdUpload.Code = ""
        Me.cmdUpload.Data = ""
        Me.cmdUpload.Image = CType(resources.GetObject("cmdUpload.Image"), System.Drawing.Image)
        Me.cmdUpload.ImageAlign = 16
        Me.cmdUpload.Location = New System.Drawing.Point(722, 67)
        Me.cmdUpload.Name = "cmdUpload"
        Me.cmdUpload.Size = New System.Drawing.Size(149, 24)
        Me.cmdUpload.TabIndex = 0
        Me.cmdUpload.TabStop = False
        Me.cmdUpload.Tag = ""
        Me.cmdUpload.Text = "UPLOAD (&U)"
        Me.cmdUpload.UseVisualStyleBackColor = False
        Me.cmdUpload.Visible = False
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmdBrowse.Appearance.Options.UseFont = True
        Me.cmdBrowse.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdBrowse.ButtonTitle = Nothing
        Me.cmdBrowse.Code = ""
        Me.cmdBrowse.Data = ""
        Me.cmdBrowse.Image = Global.PSMGlobal.My.Resources.Resources.find_f
        Me.cmdBrowse.ImageAlign = 16
        Me.cmdBrowse.Location = New System.Drawing.Point(723, 5)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(131, 24)
        Me.cmdBrowse.TabIndex = 4
        Me.cmdBrowse.TabStop = False
        Me.cmdBrowse.Tag = ""
        Me.cmdBrowse.Text = "Browse (&B)"
        Me.cmdBrowse.UseVisualStyleBackColor = False
        Me.cmdBrowse.Visible = False
        '
        'txt_QAComment
        '
        Me.txt_QAComment.Code = Nothing
        Me.txt_QAComment.Data = Nothing
        Me.txt_QAComment.Location = New System.Drawing.Point(224, 8)
        Me.txt_QAComment.Name = "txt_QAComment"
        Me.txt_QAComment.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_QAComment.Properties.Appearance.Options.UseFont = True
        Me.txt_QAComment.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_QAComment.Size = New System.Drawing.Size(519, 126)
        Me.txt_QAComment.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txt_DateLable)
        Me.Panel2.Controls.Add(Me.txt_CustPONO)
        Me.Panel2.Controls.Add(Me.txt_ProductCode)
        Me.Panel2.Controls.Add(Me.txt_cdProductSize)
        Me.Panel2.Controls.Add(Me.txt_CustomerCode)
        Me.Panel2.Controls.Add(Me.txt_cdProductType)
        Me.Panel2.Controls.Add(Me.txt_cdGender)
        Me.Panel2.Controls.Add(Me.txt_Article)
        Me.Panel2.Controls.Add(Me.txt_cdSpecState)
        Me.Panel2.Controls.Add(Me.txt_Style)
        Me.Panel2.Controls.Add(Me.txt_CustSpecNo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(3, 172)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(309, 295)
        Me.Panel2.TabIndex = 1
        '
        'txt_DateLable
        '
        Me.txt_DateLable.BackYesno = False
        Me.txt_DateLable.ButtonTitle = Nothing
        Me.txt_DateLable.Code = Nothing
        Me.txt_DateLable.Data = "test"
        Me.txt_DateLable.DataDecimal = 0
        Me.txt_DateLable.DataLen = 0
        Me.txt_DateLable.DataValue = 0
        Me.txt_DateLable.FormatDecimal = 0
        Me.txt_DateLable.FormatValue = False
        Me.txt_DateLable.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_DateLable.LableEnabled = True
        Me.txt_DateLable.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DateLable.LableForeColor = System.Drawing.Color.Empty
        Me.txt_DateLable.LableTitle = "DTSP/Date Code"
        Me.txt_DateLable.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_DateLable.Location = New System.Drawing.Point(1, 29)
        Me.txt_DateLable.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_DateLable.Name = "txt_DateLable"
        Me.txt_DateLable.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_DateLable.Size = New System.Drawing.Size(300, 22)
        Me.txt_DateLable.TabIndex = 1
        Me.txt_DateLable.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_DateLable.TextBoxAutoComplete = False
        Me.txt_DateLable.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_DateLable.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DateLable.TextEnabled = True
        Me.txt_DateLable.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DateLable.TextMaxLength = 32767
        Me.txt_DateLable.TextMultiLine = False
        Me.txt_DateLable.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_DateLable.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_DateLable.UseSendTab = True
        '
        'txt_CustPONO
        '
        Me.txt_CustPONO.BackYesno = False
        Me.txt_CustPONO.ButtonTitle = Nothing
        Me.txt_CustPONO.Code = Nothing
        Me.txt_CustPONO.Data = "So/WI#"
        Me.txt_CustPONO.DataDecimal = 0
        Me.txt_CustPONO.DataLen = 0
        Me.txt_CustPONO.DataValue = 0
        Me.txt_CustPONO.FormatDecimal = 0
        Me.txt_CustPONO.FormatValue = False
        Me.txt_CustPONO.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_CustPONO.LableEnabled = True
        Me.txt_CustPONO.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_CustPONO.LableForeColor = System.Drawing.Color.Empty
        Me.txt_CustPONO.LableTitle = "So/WI#"
        Me.txt_CustPONO.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_CustPONO.Location = New System.Drawing.Point(2, 3)
        Me.txt_CustPONO.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_CustPONO.Name = "txt_CustPONO"
        Me.txt_CustPONO.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CustPONO.Size = New System.Drawing.Size(300, 22)
        Me.txt_CustPONO.TabIndex = 0
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
        'txt_ProductCode
        '
        Me.txt_ProductCode.BackYesno = False
        Me.txt_ProductCode.ButtonTitle = Nothing
        Me.txt_ProductCode.Code = Nothing
        Me.txt_ProductCode.Data = "test"
        Me.txt_ProductCode.DataDecimal = 0
        Me.txt_ProductCode.DataLen = 0
        Me.txt_ProductCode.DataValue = 0
        Me.txt_ProductCode.FormatDecimal = 0
        Me.txt_ProductCode.FormatValue = False
        Me.txt_ProductCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ProductCode.LableEnabled = True
        Me.txt_ProductCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ProductCode.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ProductCode.LableTitle = "Product Code"
        Me.txt_ProductCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_ProductCode.Location = New System.Drawing.Point(2, 54)
        Me.txt_ProductCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ProductCode.Name = "txt_ProductCode"
        Me.txt_ProductCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ProductCode.Size = New System.Drawing.Size(300, 22)
        Me.txt_ProductCode.TabIndex = 2
        Me.txt_ProductCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ProductCode.TextBoxAutoComplete = False
        Me.txt_ProductCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ProductCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ProductCode.TextEnabled = True
        Me.txt_ProductCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ProductCode.TextMaxLength = 32767
        Me.txt_ProductCode.TextMultiLine = False
        Me.txt_ProductCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ProductCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ProductCode.UseSendTab = True
        '
        'txt_cdProductSize
        '
        Me.txt_cdProductSize.BackYesno = False
        Me.txt_cdProductSize.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdProductSize.ButtonEnabled = True
        Me.txt_cdProductSize.ButtonFont = Nothing
        Me.txt_cdProductSize.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdProductSize.ButtonName = ""
        Me.txt_cdProductSize.ButtonTitle = "Prod Size"
        Me.txt_cdProductSize.Code = ""
        Me.txt_cdProductSize.Data = "test"
        Me.txt_cdProductSize.DataDecimal = 0
        Me.txt_cdProductSize.DataLen = 0
        Me.txt_cdProductSize.DataValue = 1
        Me.txt_cdProductSize.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdProductSize.Location = New System.Drawing.Point(1, 168)
        Me.txt_cdProductSize.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdProductSize.Name = "txt_cdProductSize"
        Me.txt_cdProductSize.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdProductSize.Size = New System.Drawing.Size(300, 22)
        Me.txt_cdProductSize.TabIndex = 6
        Me.txt_cdProductSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdProductSize.TextBoxAutoComplete = False
        Me.txt_cdProductSize.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdProductSize.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdProductSize.TextEnabled = True
        Me.txt_cdProductSize.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdProductSize.TextMaxLength = 32767
        Me.txt_cdProductSize.TextMultiLine = False
        Me.txt_cdProductSize.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdProductSize.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdProductSize.UseSendTab = True
        '
        'txt_CustomerCode
        '
        Me.txt_CustomerCode.BackYesno = False
        Me.txt_CustomerCode.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_CustomerCode.ButtonEnabled = True
        Me.txt_CustomerCode.ButtonFont = Nothing
        Me.txt_CustomerCode.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_CustomerCode.ButtonName = ""
        Me.txt_CustomerCode.ButtonTitle = "Buyer"
        Me.txt_CustomerCode.Code = ""
        Me.txt_CustomerCode.Data = "test"
        Me.txt_CustomerCode.DataDecimal = 0
        Me.txt_CustomerCode.DataLen = 0
        Me.txt_CustomerCode.DataValue = 0
        Me.txt_CustomerCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_CustomerCode.Location = New System.Drawing.Point(1, 81)
        Me.txt_CustomerCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_CustomerCode.Name = "txt_CustomerCode"
        Me.txt_CustomerCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CustomerCode.Size = New System.Drawing.Size(300, 22)
        Me.txt_CustomerCode.TabIndex = 3
        Me.txt_CustomerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_CustomerCode.TextBoxAutoComplete = False
        Me.txt_CustomerCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_CustomerCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_CustomerCode.TextEnabled = True
        Me.txt_CustomerCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_CustomerCode.TextMaxLength = 32767
        Me.txt_CustomerCode.TextMultiLine = False
        Me.txt_CustomerCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CustomerCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_CustomerCode.UseSendTab = True
        '
        'txt_cdProductType
        '
        Me.txt_cdProductType.BackYesno = False
        Me.txt_cdProductType.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdProductType.ButtonEnabled = True
        Me.txt_cdProductType.ButtonFont = Nothing
        Me.txt_cdProductType.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdProductType.ButtonName = ""
        Me.txt_cdProductType.ButtonTitle = "Prod Type"
        Me.txt_cdProductType.Code = ""
        Me.txt_cdProductType.Data = "test"
        Me.txt_cdProductType.DataDecimal = 0
        Me.txt_cdProductType.DataLen = 0
        Me.txt_cdProductType.DataValue = 1
        Me.txt_cdProductType.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdProductType.Location = New System.Drawing.Point(2, 139)
        Me.txt_cdProductType.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdProductType.Name = "txt_cdProductType"
        Me.txt_cdProductType.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdProductType.Size = New System.Drawing.Size(300, 22)
        Me.txt_cdProductType.TabIndex = 5
        Me.txt_cdProductType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdProductType.TextBoxAutoComplete = False
        Me.txt_cdProductType.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdProductType.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdProductType.TextEnabled = True
        Me.txt_cdProductType.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdProductType.TextMaxLength = 32767
        Me.txt_cdProductType.TextMultiLine = False
        Me.txt_cdProductType.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdProductType.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdProductType.UseSendTab = True
        '
        'txt_cdGender
        '
        Me.txt_cdGender.BackYesno = False
        Me.txt_cdGender.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdGender.ButtonEnabled = True
        Me.txt_cdGender.ButtonFont = Nothing
        Me.txt_cdGender.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdGender.ButtonName = "Const_CustomerDivision"
        Me.txt_cdGender.ButtonTitle = "Gender"
        Me.txt_cdGender.Code = ""
        Me.txt_cdGender.Data = "test"
        Me.txt_cdGender.DataDecimal = 0
        Me.txt_cdGender.DataLen = 0
        Me.txt_cdGender.DataValue = 0
        Me.txt_cdGender.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdGender.Location = New System.Drawing.Point(2, 197)
        Me.txt_cdGender.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdGender.Name = "txt_cdGender"
        Me.txt_cdGender.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdGender.Size = New System.Drawing.Size(300, 22)
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
        'txt_Article
        '
        Me.txt_Article.BackYesno = False
        Me.txt_Article.ButtonTitle = Nothing
        Me.txt_Article.Code = Nothing
        Me.txt_Article.Data = "test"
        Me.txt_Article.DataDecimal = 0
        Me.txt_Article.DataLen = 0
        Me.txt_Article.DataValue = 1
        Me.txt_Article.FormatDecimal = 0
        Me.txt_Article.FormatValue = False
        Me.txt_Article.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Article.LableEnabled = True
        Me.txt_Article.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Article.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Article.LableTitle = "Spec#/Article"
        Me.txt_Article.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Article.Location = New System.Drawing.Point(2, 226)
        Me.txt_Article.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Article.Name = "txt_Article"
        Me.txt_Article.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Article.Size = New System.Drawing.Size(300, 22)
        Me.txt_Article.TabIndex = 8
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
        'txt_cdSpecState
        '
        Me.txt_cdSpecState.BackYesno = False
        Me.txt_cdSpecState.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSpecState.ButtonEnabled = True
        Me.txt_cdSpecState.ButtonFont = Nothing
        Me.txt_cdSpecState.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSpecState.ButtonName = ""
        Me.txt_cdSpecState.ButtonTitle = "Dev Stage"
        Me.txt_cdSpecState.Code = ""
        Me.txt_cdSpecState.Data = "test"
        Me.txt_cdSpecState.DataDecimal = 0
        Me.txt_cdSpecState.DataLen = 0
        Me.txt_cdSpecState.DataValue = 1
        Me.txt_cdSpecState.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdSpecState.Location = New System.Drawing.Point(1, 110)
        Me.txt_cdSpecState.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSpecState.Name = "txt_cdSpecState"
        Me.txt_cdSpecState.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSpecState.Size = New System.Drawing.Size(300, 22)
        Me.txt_cdSpecState.TabIndex = 4
        Me.txt_cdSpecState.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSpecState.TextBoxAutoComplete = False
        Me.txt_cdSpecState.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdSpecState.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdSpecState.TextEnabled = True
        Me.txt_cdSpecState.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdSpecState.TextMaxLength = 32767
        Me.txt_cdSpecState.TextMultiLine = False
        Me.txt_cdSpecState.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdSpecState.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdSpecState.UseSendTab = True
        '
        'txt_Style
        '
        Me.txt_Style.BackYesno = False
        Me.txt_Style.ButtonTitle = Nothing
        Me.txt_Style.Code = Nothing
        Me.txt_Style.Data = "test"
        Me.txt_Style.DataDecimal = 0
        Me.txt_Style.DataLen = 0
        Me.txt_Style.DataValue = 0
        Me.txt_Style.FormatDecimal = 0
        Me.txt_Style.FormatValue = False
        Me.txt_Style.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Style.LableEnabled = True
        Me.txt_Style.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Style.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Style.LableTitle = "Style/SKU#"
        Me.txt_Style.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Style.Location = New System.Drawing.Point(2, 299)
        Me.txt_Style.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Style.Name = "txt_Style"
        Me.txt_Style.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Style.Size = New System.Drawing.Size(300, 22)
        Me.txt_Style.TabIndex = 10
        Me.txt_Style.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Style.TextBoxAutoComplete = False
        Me.txt_Style.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Style.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Style.TextEnabled = True
        Me.txt_Style.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Style.TextMaxLength = 32767
        Me.txt_Style.TextMultiLine = False
        Me.txt_Style.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Style.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Style.UseSendTab = True
        '
        'txt_CustSpecNo
        '
        Me.txt_CustSpecNo.BackYesno = False
        Me.txt_CustSpecNo.ButtonTitle = Nothing
        Me.txt_CustSpecNo.Code = Nothing
        Me.txt_CustSpecNo.Data = "test"
        Me.txt_CustSpecNo.DataDecimal = 0
        Me.txt_CustSpecNo.DataLen = 0
        Me.txt_CustSpecNo.DataValue = 0
        Me.txt_CustSpecNo.FormatDecimal = 0
        Me.txt_CustSpecNo.FormatValue = False
        Me.txt_CustSpecNo.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_CustSpecNo.LableEnabled = True
        Me.txt_CustSpecNo.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_CustSpecNo.LableForeColor = System.Drawing.Color.Empty
        Me.txt_CustSpecNo.LableTitle = "Cust SpecNo"
        Me.txt_CustSpecNo.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_CustSpecNo.Location = New System.Drawing.Point(2, 255)
        Me.txt_CustSpecNo.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_CustSpecNo.Name = "txt_CustSpecNo"
        Me.txt_CustSpecNo.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CustSpecNo.Size = New System.Drawing.Size(300, 22)
        Me.txt_CustSpecNo.TabIndex = 9
        Me.txt_CustSpecNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_CustSpecNo.TextBoxAutoComplete = False
        Me.txt_CustSpecNo.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_CustSpecNo.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_CustSpecNo.TextEnabled = True
        Me.txt_CustSpecNo.TextForeColor = System.Drawing.Color.Empty
        Me.txt_CustSpecNo.TextMaxLength = 32767
        Me.txt_CustSpecNo.TextMultiLine = False
        Me.txt_CustSpecNo.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CustSpecNo.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_CustSpecNo.UseSendTab = True
        '
        'lblUploadStatus
        '
        Me.lblUploadStatus.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblUploadStatus.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lblUploadStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblUploadStatus.ButtonTitle = Nothing
        Me.lblUploadStatus.Code = ""
        Me.lblUploadStatus.Data = ""
        Me.lblUploadStatus.DTDec = 0
        Me.lblUploadStatus.DTLen = 0
        Me.lblUploadStatus.DTValue = 0
        Me.lblUploadStatus.Location = New System.Drawing.Point(650, 132)
        Me.lblUploadStatus.Name = "lblUploadStatus"
        Me.lblUploadStatus.NoClear = False
        Me.lblUploadStatus.Size = New System.Drawing.Size(102, 15)
        Me.lblUploadStatus.TabIndex = 3
        Me.lblUploadStatus.Tag = ""
        Me.lblUploadStatus.Text = "Status Loading ..."
        Me.lblUploadStatus.TextAlign = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblUploadStatus.Visible = False
        '
        'txt_FormName
        '
        Me.txt_FormName.BackYesno = False
        Me.txt_FormName.ButtonTitle = Nothing
        Me.txt_FormName.Code = ""
        Me.txt_FormName.Data = ""
        Me.txt_FormName.DataDecimal = 0
        Me.txt_FormName.DataLen = 0
        Me.txt_FormName.DataValue = 0
        Me.txt_FormName.FormatDecimal = 0
        Me.txt_FormName.FormatValue = False
        Me.txt_FormName.LableBackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_FormName.LableEnabled = True
        Me.txt_FormName.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FormName.LableForeColor = System.Drawing.Color.Black
        Me.txt_FormName.LableTitle = "Code"
        Me.txt_FormName.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_FormName.Location = New System.Drawing.Point(698, 104)
        Me.txt_FormName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_FormName.Name = "txt_FormName"
        Me.txt_FormName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_FormName.Size = New System.Drawing.Size(101, 24)
        Me.txt_FormName.TabIndex = 144
        Me.txt_FormName.TabStop = False
        Me.txt_FormName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_FormName.TextBoxAutoComplete = False
        Me.txt_FormName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_FormName.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_FormName.TextEnabled = False
        Me.txt_FormName.TextForeColor = System.Drawing.Color.Blue
        Me.txt_FormName.TextMaxLength = 32767
        Me.txt_FormName.TextMultiLine = False
        Me.txt_FormName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_FormName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_FormName.UseSendTab = True
        Me.txt_FormName.Visible = False
        '
        'cmb_State
        '
        Me.cmb_State.DTDec = 0
        Me.cmb_State.DTLen = 0
        Me.cmb_State.DTValue = 0
        Me.cmb_State.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_State.FormattingEnabled = True
        Me.cmb_State.InSelected = 0
        Me.cmb_State.Items.AddRange(New Object() {"Normal", "Stretch", "Autosize", "Center"})
        Me.cmb_State.ListIndex = 0
        Me.cmb_State.Location = New System.Drawing.Point(861, 129)
        Me.cmb_State.Name = "cmb_State"
        Me.cmb_State.NoClear = False
        Me.cmb_State.Size = New System.Drawing.Size(149, 22)
        Me.cmb_State.TabIndex = 209
        Me.cmb_State.Visible = False
        '
        'chk_MultiView
        '
        Me.chk_MultiView.AutoSize = True
        Me.chk_MultiView.ButtonTitle = Nothing
        Me.chk_MultiView.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_MultiView.Location = New System.Drawing.Point(767, 132)
        Me.chk_MultiView.Name = "chk_MultiView"
        Me.chk_MultiView.Size = New System.Drawing.Size(94, 18)
        Me.chk_MultiView.TabIndex = 207
        Me.chk_MultiView.Text = "Muilti-View"
        Me.chk_MultiView.UseVisualStyleBackColor = True
        Me.chk_MultiView.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ISUD7550A
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 511)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.txt_FormName)
        Me.Controls.Add(Me.lblUploadStatus)
        Me.Controls.Add(Me.chk_MultiView)
        Me.Controls.Add(Me.cmb_State)
        Me.Name = "ISUD7550A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QA PROCESSING (ISUD7550A)"
        Me.Controls.SetChildIndex(Me.cmb_State, 0)
        Me.Controls.SetChildIndex(Me.chk_MultiView, 0)
        Me.Controls.SetChildIndex(Me.lblUploadStatus, 0)
        Me.Controls.SetChildIndex(Me.txt_FormName, 0)
        Me.Controls.SetChildIndex(Me.TableLayoutPanel1, 0)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_QAComment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Public WithEvents Vs1 As PSMGlobal.PeaceFarpoint
    Friend WithEvents Vs1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents lblUploadStatus As PSMGlobal.PeaceLabel
    Friend WithEvents txt_FormName As PSMGlobal.SelectLabelText
    Friend WithEvents txtFileToUpload As PSMGlobal.SelectLabelText
    Friend WithEvents cmb_State As PSMGlobal.PeaceCombobox
    Friend WithEvents cmdUpload As PSMGlobal.PeaceButton
    Friend WithEvents cmdBrowse As PSMGlobal.PeaceButton
    Friend WithEvents chk_MultiView As PSMGlobal.PeaceCheckbox
    Friend WithEvents txt_DateQA As PSMGlobal.SelectPeaceCalSin
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_QAKey As PSMGlobal.SelectLabelText
    Friend WithEvents txt_FileName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_QAComment As PSMGlobal.PeaceMemo
    Friend WithEvents txt_ShoesCode As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_OrderNo As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdQAResult As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_cdProductSize As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdProductType As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_ProductCode As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdSpecState As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_CustomerCode As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_CustSpecNo As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Style As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Article As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdGender As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_DateLable As PSMGlobal.SelectLabelText
    Friend WithEvents txt_CustPONO As PSMGlobal.SelectLabelText
End Class
