<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HLP0001_M
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
        Dim VS1_InputMapWhenFocusedReadOnly As FarPoint.Win.Spread.InputMap
        Dim VS1_InputMapWhenAncestorOfFocusedReadOnly As FarPoint.Win.Spread.InputMap
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_SEARCH = New PSMGlobal.PeaceButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.PeacePanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pck6 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.Pck5 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.Pck4 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.Pck3 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.Pck2 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.PCK1 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.PeaceTextbox1 = New PSMGlobal.PeaceTextbox(Me.components)
        Me.PeaceButton1 = New PSMGlobal.PeaceButton(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SelectLabelSearch1 = New PSMGlobal.SelectLabelSearch()
        Me.VS1 = New PSMGlobal.PeaceFarpoint()
        Me.VS1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.ttpMain = New PSMGlobal.PeaceTooltip(Me.components)
        VS1_InputMapWhenFocusedReadOnly = New FarPoint.Win.Spread.InputMap()
        VS1_InputMapWhenFocusedReadOnly.Parent = New FarPoint.Win.Spread.InputMap()
        VS1_InputMapWhenAncestorOfFocusedReadOnly = New FarPoint.Win.Spread.InputMap()
        VS1_InputMapWhenAncestorOfFocusedReadOnly.Parent = New FarPoint.Win.Spread.InputMap()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.PeacePanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SelectLabelSearch1.SuspendLayout()
        CType(Me.VS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VS1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_OK
        '
        Me.cmd_OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd_OK.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Image = Global.PSMGlobal.My.Resources.Resources.save
        Me.cmd_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_OK.Location = New System.Drawing.Point(3, 3)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(130, 35)
        Me.cmd_OK.TabIndex = 44
        Me.cmd_OK.Text = "Save(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'cmd_SEARCH
        '
        Me.cmd_SEARCH.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmd_SEARCH, 2)
        Me.cmd_SEARCH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd_SEARCH.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_SEARCH.Image = Global.PSMGlobal.My.Resources.Resources.find_f
        Me.cmd_SEARCH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_SEARCH.Location = New System.Drawing.Point(368, 2)
        Me.cmd_SEARCH.Margin = New System.Windows.Forms.Padding(2)
        Me.cmd_SEARCH.Name = "cmd_SEARCH"
        Me.cmd_SEARCH.Size = New System.Drawing.Size(130, 27)
        Me.cmd_SEARCH.TabIndex = 1
        Me.cmd_SEARCH.Text = "Search(&S)"
        Me.cmd_SEARCH.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 3)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.cmd_Cancel, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmd_OK, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(225, 635)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(272, 41)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd_Cancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Image = Global.PSMGlobal.My.Resources.Resources.delete
        Me.cmd_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Cancel.Location = New System.Drawing.Point(139, 3)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(130, 35)
        Me.cmd_Cancel.TabIndex = 43
        Me.cmd_Cancel.Text = "Close(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'PeacePanel1
        '
        Me.PeacePanel1.BackColor = System.Drawing.SystemColors.Control
        Me.PeacePanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel1.Code = ""
        Me.TableLayoutPanel1.SetColumnSpan(Me.PeacePanel1, 4)
        Me.PeacePanel1.Controls.Add(Me.Label1)
        Me.PeacePanel1.Controls.Add(Me.Pck6)
        Me.PeacePanel1.Controls.Add(Me.Pck5)
        Me.PeacePanel1.Controls.Add(Me.Pck4)
        Me.PeacePanel1.Controls.Add(Me.Pck3)
        Me.PeacePanel1.Controls.Add(Me.Pck2)
        Me.PeacePanel1.Controls.Add(Me.PCK1)
        Me.PeacePanel1.Data = ""
        Me.PeacePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeacePanel1.Location = New System.Drawing.Point(3, 34)
        Me.PeacePanel1.Name = "PeacePanel1"
        Me.PeacePanel1.Size = New System.Drawing.Size(494, 89)
        Me.PeacePanel1.TabIndex = 5
        Me.PeacePanel1.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Please check the conditions below to search"
        '
        'Pck6
        '
        Me.Pck6.AutoSize = True
        Me.Pck6.Checked = True
        Me.Pck6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Pck6.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Pck6.Location = New System.Drawing.Point(346, 55)
        Me.Pck6.Name = "Pck6"
        Me.Pck6.Size = New System.Drawing.Size(78, 19)
        Me.Pck6.TabIndex = 5
        Me.Pck6.Text = "OTHER 3"
        Me.Pck6.UseVisualStyleBackColor = True
        '
        'Pck5
        '
        Me.Pck5.AutoSize = True
        Me.Pck5.Checked = True
        Me.Pck5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Pck5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Pck5.Location = New System.Drawing.Point(347, 27)
        Me.Pck5.Name = "Pck5"
        Me.Pck5.Size = New System.Drawing.Size(90, 19)
        Me.Pck5.TabIndex = 4
        Me.Pck5.Text = "EMPLOYEE"
        Me.Pck5.UseVisualStyleBackColor = True
        '
        'Pck4
        '
        Me.Pck4.AutoSize = True
        Me.Pck4.Checked = True
        Me.Pck4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Pck4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Pck4.Location = New System.Drawing.Point(191, 55)
        Me.Pck4.Name = "Pck4"
        Me.Pck4.Size = New System.Drawing.Size(78, 19)
        Me.Pck4.TabIndex = 3
        Me.Pck4.Text = "OTHER 2"
        Me.Pck4.UseVisualStyleBackColor = True
        '
        'Pck3
        '
        Me.Pck3.AutoSize = True
        Me.Pck3.Checked = True
        Me.Pck3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Pck3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Pck3.Location = New System.Drawing.Point(192, 27)
        Me.Pck3.Name = "Pck3"
        Me.Pck3.Size = New System.Drawing.Size(86, 19)
        Me.Pck3.TabIndex = 2
        Me.Pck3.Text = "SUPPLIER"
        Me.Pck3.UseVisualStyleBackColor = True
        '
        'Pck2
        '
        Me.Pck2.AutoSize = True
        Me.Pck2.Checked = True
        Me.Pck2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Pck2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Pck2.Location = New System.Drawing.Point(37, 55)
        Me.Pck2.Name = "Pck2"
        Me.Pck2.Size = New System.Drawing.Size(78, 19)
        Me.Pck2.TabIndex = 1
        Me.Pck2.Text = "OTHER 1"
        Me.Pck2.UseVisualStyleBackColor = True
        '
        'PCK1
        '
        Me.PCK1.AutoSize = True
        Me.PCK1.Checked = True
        Me.PCK1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PCK1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PCK1.Location = New System.Drawing.Point(38, 27)
        Me.PCK1.Name = "PCK1"
        Me.PCK1.Size = New System.Drawing.Size(102, 19)
        Me.PCK1.TabIndex = 0
        Me.PCK1.Text = "CUSTOMERS"
        Me.PCK1.UseVisualStyleBackColor = True
        '
        'PeaceTextbox1
        '
        Me.PeaceTextbox1.BackColor = System.Drawing.Color.White
        Me.PeaceTextbox1.Code = Nothing
        Me.PeaceTextbox1.Data = Nothing
        Me.PeaceTextbox1.DTDec = 0
        Me.PeaceTextbox1.DTLen = 0
        Me.PeaceTextbox1.DTValue = 0
        Me.PeaceTextbox1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceTextbox1.Location = New System.Drawing.Point(136, 0)
        Me.PeaceTextbox1.MaxLength = 25
        Me.PeaceTextbox1.Multiline = True
        Me.PeaceTextbox1.Name = "PeaceTextbox1"
        Me.PeaceTextbox1.NoClear = False
        Me.PeaceTextbox1.Size = New System.Drawing.Size(271, 37)
        Me.PeaceTextbox1.TabIndex = 1
        Me.PeaceTextbox1.Tag = ""
        '
        'PeaceButton1
        '
        Me.PeaceButton1.Code = Nothing
        Me.PeaceButton1.Data = Nothing
        Me.PeaceButton1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceButton1.Location = New System.Drawing.Point(0, 0)
        Me.PeaceButton1.Name = "PeaceButton1"
        Me.PeaceButton1.Size = New System.Drawing.Size(130, 37)
        Me.PeaceButton1.TabIndex = 0
        Me.PeaceButton1.Text = "Name"
        Me.PeaceButton1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.72727!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.344538!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.4!))
        Me.TableLayoutPanel1.Controls.Add(Me.SelectLabelSearch1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PeacePanel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmd_SEARCH, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.VS1, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.942339!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.99176!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.93311!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(500, 679)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'SelectLabelSearch1
        '
        Me.SelectLabelSearch1.BackYesno = False
        Me.SelectLabelSearch1.ButtonBackColor = System.Drawing.SystemColors.Control
        Me.SelectLabelSearch1.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Standard
        Me.SelectLabelSearch1.ButtonEnabled = True
        Me.SelectLabelSearch1.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectLabelSearch1.ButtonForeColor = System.Drawing.Color.Empty
        Me.SelectLabelSearch1.ButtonTitle = "Name"
        Me.SelectLabelSearch1.Code = ""
        Me.TableLayoutPanel1.SetColumnSpan(Me.SelectLabelSearch1, 2)
        Me.SelectLabelSearch1.Controls.Add(Me.PeaceTextbox1)
        Me.SelectLabelSearch1.Controls.Add(Me.PeaceButton1)
        Me.SelectLabelSearch1.Data = ""
        Me.SelectLabelSearch1.DataDecimal = 0
        Me.SelectLabelSearch1.DataLen = 0
        Me.SelectLabelSearch1.DataValue = 0
        Me.SelectLabelSearch1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SelectLabelSearch1.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.SelectLabelSearch1.Location = New System.Drawing.Point(0, 0)
        Me.SelectLabelSearch1.Margin = New System.Windows.Forms.Padding(0)
        Me.SelectLabelSearch1.Name = "SelectLabelSearch1"
        Me.SelectLabelSearch1.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.SelectLabelSearch1.Size = New System.Drawing.Size(366, 31)
        Me.SelectLabelSearch1.TabIndex = 0
        Me.SelectLabelSearch1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SelectLabelSearch1.TextBoxAutoComplete = False
        Me.SelectLabelSearch1.TextboxBackColor = System.Drawing.Color.Empty
        Me.SelectLabelSearch1.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SelectLabelSearch1.TextEnabled = True
        Me.SelectLabelSearch1.TextForeColor = System.Drawing.Color.Empty
        Me.SelectLabelSearch1.TextMaxLength = 25
        Me.SelectLabelSearch1.TextMultiLine = False
        Me.SelectLabelSearch1.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SelectLabelSearch1.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SelectLabelSearch1.UseSendTab = True
        '
        'VS1
        '
        Me.VS1.AccessibleDescription = "VS1, Sheet1, Row 0, Column 0, "
        Me.VS1.AllowEditorReservedLocations = False
        Me.Vs1.BorderStyle = BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.VS1, 4)
        Me.VS1.CopyPasteChk = True
        Me.VS1.FocusRenderer = New FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer(1)
        Me.VS1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.VS1.HorizontalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.VS1.HorizontalScrollBar.Name = ""
        EnhancedScrollBarRenderer1.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer1.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.VS1.HorizontalScrollBar.Renderer = EnhancedScrollBarRenderer1
        Me.VS1.HorizontalScrollBar.TabIndex = 0
        Me.VS1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never
        Me.VS1.InsChk = False
        Me.VS1.Location = New System.Drawing.Point(0, 126)
        Me.VS1.Margin = New System.Windows.Forms.Padding(0)
        Me.VS1.Name = "VS1"
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
        Me.VS1.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle1, NamedStyle2, NamedStyle3, NamedStyle4, NamedStyle5})
        Me.VS1.RetainSelectionBlock = False
        Me.VS1.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.Cells
        Me.VS1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.VS1_Sheet1})
        Me.VS1.Size = New System.Drawing.Size(500, 506)
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
        Me.VS1.Skin = SpreadSkin1
        Me.VS1.SpreadWjob = 0
        Me.VS1.TabIndex = 48
        Me.VS1.TabStrip.DefaultSheetTab.BackColor = System.Drawing.Color.White
        Me.VS1.TabStrip.DefaultSheetTab.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VS1.VerticalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.VS1.VerticalScrollBar.Name = ""
        EnhancedScrollBarRenderer3.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer3.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.VS1.VerticalScrollBar.Renderer = EnhancedScrollBarRenderer3
        Me.VS1.VerticalScrollBar.TabIndex = 1
        VS1_InputMapWhenFocusedReadOnly.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        VS1_InputMapWhenFocusedReadOnly.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.C, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCopy)
        VS1_InputMapWhenFocusedReadOnly.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Insert, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCopy)
        VS1_InputMapWhenFocusedReadOnly.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Z, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Undo)
        VS1_InputMapWhenFocusedReadOnly.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Y, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Redo)
        Me.VS1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.[ReadOnly], VS1_InputMapWhenFocusedReadOnly)
        VS1_InputMapWhenAncestorOfFocusedReadOnly.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        VS1_InputMapWhenAncestorOfFocusedReadOnly.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ScrollToPreviousRow)
        VS1_InputMapWhenAncestorOfFocusedReadOnly.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ScrollToNextRow)
        VS1_InputMapWhenAncestorOfFocusedReadOnly.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ScrollToPreviousColumnVisual)
        VS1_InputMapWhenAncestorOfFocusedReadOnly.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ScrollToNextColumnVisual)
        VS1_InputMapWhenAncestorOfFocusedReadOnly.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ScrollToPreviousPageOfRows)
        VS1_InputMapWhenAncestorOfFocusedReadOnly.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ScrollToNextPageOfRows)
        VS1_InputMapWhenAncestorOfFocusedReadOnly.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ScrollToPreviousPageOfColumns)
        VS1_InputMapWhenAncestorOfFocusedReadOnly.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ScrollToNextPageOfColumns)
        VS1_InputMapWhenAncestorOfFocusedReadOnly.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ScrollToFirstColumn)
        VS1_InputMapWhenAncestorOfFocusedReadOnly.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ScrollToLastColumn)
        VS1_InputMapWhenAncestorOfFocusedReadOnly.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ScrollToFirstCell)
        VS1_InputMapWhenAncestorOfFocusedReadOnly.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ScrollToLastCell)
        Me.VS1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused, FarPoint.Win.Spread.OperationMode.[ReadOnly], VS1_InputMapWhenAncestorOfFocusedReadOnly)
        '
        'VS1_Sheet1
        '
        Me.VS1_Sheet1.Reset()
        Me.VS1_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.VS1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.VS1_Sheet1.ColumnCount = 2
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
        Me.VS1_Sheet1.ColumnHeader.Cells.Get(0, 0).Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VS1_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "CODE"
        Me.VS1_Sheet1.ColumnHeader.Cells.Get(0, 1).Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VS1_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "NAME"
        Me.VS1_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.VS1_Sheet1.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.VS1_Sheet1.ColumnHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VS1_Sheet1.ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.VS1_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.VS1_Sheet1.ColumnHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.VS1_Sheet1.ColumnHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.VS1_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.VS1_Sheet1.ColumnHeader.Rows.Get(0).Height = 24.0!
        Me.VS1_Sheet1.Columns.Get(0).Label = "CODE"
        Me.VS1_Sheet1.Columns.Get(0).Width = 86.0!
        Me.VS1_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        Me.VS1_Sheet1.Columns.Get(1).Label = "NAME"
        Me.VS1_Sheet1.Columns.Get(1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.VS1_Sheet1.Columns.Get(1).Width = 378.0!
        Me.VS1_Sheet1.DefaultStyle.ForeColor = System.Drawing.Color.Black
        Me.VS1_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.VS1_Sheet1.DefaultStyle.Parent = "DataAreaDefault"
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
        Me.VS1_Sheet1.SelectionBackColor = System.Drawing.Color.Aquamarine
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
        'ttpMain
        '
        Me.ttpMain.AutoPopDelay = 5000
        Me.ttpMain.InitialDelay = 500
        Me.ttpMain.IsBalloon = True
        Me.ttpMain.ReshowDelay = 100
        Me.ttpMain.ShowAlways = True
        Me.ttpMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttpMain.ToolTipTitle = "Information"
        '
        'HLP0001_M
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(500, 679)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "HLP0001_M"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HLP0001_M"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.PeacePanel1.ResumeLayout(False)
        Me.PeacePanel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.SelectLabelSearch1.ResumeLayout(False)
        Me.SelectLabelSearch1.PerformLayout()
        CType(Me.VS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VS1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents cmd_SEARCH As PSMGlobal.PeaceButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SelectLabelSearch1 As PSMGlobal.SelectLabelSearch
    Friend WithEvents PeaceTextbox1 As PSMGlobal.PeaceTextbox
    Friend WithEvents PeaceButton1 As PSMGlobal.PeaceButton
    Friend WithEvents PeacePanel1 As PSMGlobal.PeacePanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Pck6 As PSMGlobal.PeaceCheckbox
    Friend WithEvents Pck5 As PSMGlobal.PeaceCheckbox
    Friend WithEvents Pck4 As PSMGlobal.PeaceCheckbox
    Friend WithEvents Pck3 As PSMGlobal.PeaceCheckbox
    Friend WithEvents Pck2 As PSMGlobal.PeaceCheckbox
    Friend WithEvents PCK1 As PSMGlobal.PeaceCheckbox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents ttpMain As PSMGlobal.PeaceTooltip
    Friend WithEvents VS1_Sheet1 As FarPoint.Win.Spread.SheetView
    Public WithEvents VS1 As PSMGlobal.PeaceFarpoint
End Class
