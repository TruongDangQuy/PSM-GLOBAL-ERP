<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PFW99981
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PFW99981))
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
        Dim Vs1_InputMapWhenAncestorOfFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim TextCellType5 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip1 = New PSMGlobal.PeaceToolStrip(Me.components)
        Me.tst_1 = New PSMGlobal.PeaceToolStripButton(Me.components)
        Me.ToolStripSeparator2 = New PSMGlobal.PeaceToolStripSep(Me.components)
        Me.tst_2 = New PSMGlobal.PeaceToolStripButton(Me.components)
        Me.ToolStripSeparator4 = New PSMGlobal.PeaceToolStripSep(Me.components)
        Me.tst_3 = New PSMGlobal.PeaceToolStripButton(Me.components)
        Me.ToolStripSeparator3 = New PSMGlobal.PeaceToolStripSep(Me.components)
        Me.tst_4 = New PSMGlobal.PeaceToolStripButton(Me.components)
        Me.ToolStripSeparator5 = New PSMGlobal.PeaceToolStripSep(Me.components)
        Me.tst_5 = New PSMGlobal.PeaceToolStripButton(Me.components)
        Me.ToolStripSeparator6 = New PSMGlobal.PeaceToolStripSep(Me.components)
        Me.tst_6 = New PSMGlobal.PeaceToolStripButton(Me.components)
        Me.ToolStripSeparator1 = New PSMGlobal.PeaceToolStripSep(Me.components)
        Me.ptsb_Manual = New PSMGlobal.PeaceToolStripButton(Me.components)
        Me.ptsb_Excel = New PSMGlobal.PeaceToolStripButton(Me.components)
        Me.PPanel = New PSMGlobal.PeacePanel(Me.components)
        Me.Panel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmd_SEARCH = New PSMGlobal.PeaceButton(Me.components)
        Me.Panel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.opt_SEL0 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.opt_SEL1 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.tit_Use = New PSMGlobal.PeaceLabel(Me.components)
        Me.tit_Sort = New PSMGlobal.PeaceLabel(Me.components)
        Me.Panel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.opt_Name = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.opt_Code = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Vs1 = New PSMGlobal.PeaceFarpoint()
        Me.Vs1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Vs1_InputMapWhenFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Panel1.ColumnCount = 1
        Me.Panel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel1.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.Panel1.Controls.Add(Me.PPanel, 0, 1)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1, 0, 2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RowCount = 3
        Me.Panel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.Panel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.Panel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel1.Size = New System.Drawing.Size(1341, 562)
        Me.Panel1.TabIndex = 13
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_1, Me.ToolStripSeparator2, Me.tst_2, Me.ToolStripSeparator4, Me.tst_3, Me.ToolStripSeparator3, Me.tst_4, Me.ToolStripSeparator5, Me.tst_5, Me.ToolStripSeparator6, Me.tst_6, Me.ToolStripSeparator1, Me.ptsb_Manual, Me.ptsb_Excel})
        Me.ToolStrip1.Location = New System.Drawing.Point(1, 1)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1339, 30)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tst_1
        '
        Me.tst_1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tst_1.Image = CType(resources.GetObject("tst_1.Image"), System.Drawing.Image)
        Me.tst_1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_1.Name = "tst_1"
        Me.tst_1.Size = New System.Drawing.Size(95, 27)
        Me.tst_1.Text = "INSERT (F5)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 30)
        '
        'tst_2
        '
        Me.tst_2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tst_2.Image = CType(resources.GetObject("tst_2.Image"), System.Drawing.Image)
        Me.tst_2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_2.Name = "tst_2"
        Me.tst_2.Size = New System.Drawing.Size(98, 27)
        Me.tst_2.Text = "SEARCH (F6)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 30)
        '
        'tst_3
        '
        Me.tst_3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tst_3.Image = CType(resources.GetObject("tst_3.Image"), System.Drawing.Image)
        Me.tst_3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_3.Name = "tst_3"
        Me.tst_3.Size = New System.Drawing.Size(98, 27)
        Me.tst_3.Text = "MODIFY (F7)"
        Me.tst_3.ToolTipText = "MODIFY (F7)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 30)
        '
        'tst_4
        '
        Me.tst_4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tst_4.Image = CType(resources.GetObject("tst_4.Image"), System.Drawing.Image)
        Me.tst_4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_4.Name = "tst_4"
        Me.tst_4.Size = New System.Drawing.Size(97, 27)
        Me.tst_4.Text = "DELETE (F8)"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 30)
        '
        'tst_5
        '
        Me.tst_5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tst_5.Image = CType(resources.GetObject("tst_5.Image"), System.Drawing.Image)
        Me.tst_5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_5.Name = "tst_5"
        Me.tst_5.Size = New System.Drawing.Size(88, 27)
        Me.tst_5.Text = "PRINT (F9)"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 30)
        '
        'tst_6
        '
        Me.tst_6.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tst_6.Image = CType(resources.GetObject("tst_6.Image"), System.Drawing.Image)
        Me.tst_6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_6.Name = "tst_6"
        Me.tst_6.Size = New System.Drawing.Size(132, 27)
        Me.tst_6.Text = "PROCESSING (F10)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'ptsb_Manual
        '
        Me.ptsb_Manual.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ptsb_Manual.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ptsb_Manual.Image = Global.PSMGlobal.My.Resources.Resources.GroupFooter_16x16
        Me.ptsb_Manual.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ptsb_Manual.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ptsb_Manual.Name = "ptsb_Manual"
        Me.ptsb_Manual.Size = New System.Drawing.Size(23, 27)
        Me.ptsb_Manual.Text = "HELP"
        '
        'ptsb_Excel
        '
        Me.ptsb_Excel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ptsb_Excel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ptsb_Excel.Image = Global.PSMGlobal.My.Resources.Resources.ExportToXLS_16x16
        Me.ptsb_Excel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ptsb_Excel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ptsb_Excel.Name = "ptsb_Excel"
        Me.ptsb_Excel.Size = New System.Drawing.Size(23, 27)
        Me.ptsb_Excel.Text = "EXCEL"
        '
        'PPanel
        '
        Me.PPanel.Code = ""
        Me.PPanel.Controls.Add(Me.Panel2)
        Me.PPanel.Data = ""
        Me.PPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PPanel.Location = New System.Drawing.Point(4, 35)
        Me.PPanel.Name = "PPanel"
        Me.PPanel.Size = New System.Drawing.Size(1333, 29)
        Me.PPanel.TabIndex = 6
        Me.PPanel.Tag = ""
        '
        'Panel2
        '
        Me.Panel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Panel2.ColumnCount = 8
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Panel2.Controls.Add(Me.cmd_SEARCH, 7, 0)
        Me.Panel2.Controls.Add(Me.Panel5, 3, 0)
        Me.Panel2.Controls.Add(Me.tit_Use, 2, 0)
        Me.Panel2.Controls.Add(Me.tit_Sort, 0, 0)
        Me.Panel2.Controls.Add(Me.Panel4, 1, 0)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RowCount = 1
        Me.Panel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel2.Size = New System.Drawing.Size(1329, 25)
        Me.Panel2.TabIndex = 7
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
        Me.cmd_SEARCH.Location = New System.Drawing.Point(1197, 2)
        Me.cmd_SEARCH.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_SEARCH.Name = "cmd_SEARCH"
        Me.cmd_SEARCH.Size = New System.Drawing.Size(130, 21)
        Me.cmd_SEARCH.TabIndex = 7
        Me.cmd_SEARCH.Text = "Search(&S)"
        Me.cmd_SEARCH.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Panel5.ColumnCount = 2
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.Controls.Add(Me.opt_SEL0, 0, 0)
        Me.Panel5.Controls.Add(Me.opt_SEL1, 1, 0)
        Me.Panel5.Location = New System.Drawing.Point(395, 2)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.RowCount = 1
        Me.Panel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.Size = New System.Drawing.Size(138, 21)
        Me.Panel5.TabIndex = 8
        '
        'opt_SEL0
        '
        Me.opt_SEL0.AutoSize = True
        Me.opt_SEL0.ButtonTitle = Nothing
        Me.opt_SEL0.Checked = True
        Me.opt_SEL0.CheckState = System.Windows.Forms.CheckState.Checked
        Me.opt_SEL0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.opt_SEL0.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.opt_SEL0.ForeColor = System.Drawing.Color.Black
        Me.opt_SEL0.Location = New System.Drawing.Point(4, 4)
        Me.opt_SEL0.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.opt_SEL0.Name = "opt_SEL0"
        Me.opt_SEL0.Size = New System.Drawing.Size(64, 16)
        Me.opt_SEL0.TabIndex = 0
        Me.opt_SEL0.Text = "Yes"
        Me.opt_SEL0.UseVisualStyleBackColor = True
        '
        'opt_SEL1
        '
        Me.opt_SEL1.AutoSize = True
        Me.opt_SEL1.ButtonTitle = Nothing
        Me.opt_SEL1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.opt_SEL1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.opt_SEL1.ForeColor = System.Drawing.Color.Black
        Me.opt_SEL1.Location = New System.Drawing.Point(72, 4)
        Me.opt_SEL1.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.opt_SEL1.Name = "opt_SEL1"
        Me.opt_SEL1.Size = New System.Drawing.Size(65, 16)
        Me.opt_SEL1.TabIndex = 1
        Me.opt_SEL1.Text = "No"
        Me.opt_SEL1.UseVisualStyleBackColor = True
        '
        'tit_Use
        '
        Me.tit_Use.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.tit_Use.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
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
        Me.tit_Use.Location = New System.Drawing.Point(269, 2)
        Me.tit_Use.Margin = New System.Windows.Forms.Padding(1)
        Me.tit_Use.Name = "tit_Use"
        Me.tit_Use.NoClear = False
        Me.tit_Use.Size = New System.Drawing.Size(123, 21)
        Me.tit_Use.TabIndex = 13
        Me.tit_Use.Tag = ""
        Me.tit_Use.Text = "Use"
        Me.tit_Use.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'tit_Sort
        '
        Me.tit_Sort.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.tit_Sort.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tit_Sort.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tit_Sort.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tit_Sort.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.tit_Sort.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tit_Sort.ButtonTitle = Nothing
        Me.tit_Sort.Code = ""
        Me.tit_Sort.Data = ""
        Me.tit_Sort.DTDec = 0
        Me.tit_Sort.DTLen = 0
        Me.tit_Sort.DTValue = 0
        Me.tit_Sort.Location = New System.Drawing.Point(2, 2)
        Me.tit_Sort.Margin = New System.Windows.Forms.Padding(1)
        Me.tit_Sort.Name = "tit_Sort"
        Me.tit_Sort.NoClear = False
        Me.tit_Sort.Size = New System.Drawing.Size(123, 21)
        Me.tit_Sort.TabIndex = 9
        Me.tit_Sort.Tag = ""
        Me.tit_Sort.Text = "Sort"
        Me.tit_Sort.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Panel4.ColumnCount = 2
        Me.Panel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.4359!))
        Me.Panel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.5641!))
        Me.Panel4.Controls.Add(Me.opt_Name, 0, 0)
        Me.Panel4.Controls.Add(Me.opt_Code, 1, 0)
        Me.Panel4.Location = New System.Drawing.Point(128, 2)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.RowCount = 1
        Me.Panel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel4.Size = New System.Drawing.Size(138, 21)
        Me.Panel4.TabIndex = 14
        '
        'opt_Name
        '
        Me.opt_Name.AutoSize = True
        Me.opt_Name.ButtonTitle = Nothing
        Me.opt_Name.Checked = True
        Me.opt_Name.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.opt_Name.ForeColor = System.Drawing.Color.Black
        Me.opt_Name.Location = New System.Drawing.Point(4, 4)
        Me.opt_Name.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.opt_Name.Name = "opt_Name"
        Me.opt_Name.Size = New System.Drawing.Size(58, 16)
        Me.opt_Name.TabIndex = 1
        Me.opt_Name.TabStop = True
        Me.opt_Name.Text = "Name"
        Me.opt_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.opt_Name.UseVisualStyleBackColor = True
        '
        'opt_Code
        '
        Me.opt_Code.AutoSize = True
        Me.opt_Code.ButtonTitle = Nothing
        Me.opt_Code.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.opt_Code.ForeColor = System.Drawing.Color.Black
        Me.opt_Code.Location = New System.Drawing.Point(69, 4)
        Me.opt_Code.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.opt_Code.Name = "opt_Code"
        Me.opt_Code.Size = New System.Drawing.Size(56, 16)
        Me.opt_Code.TabIndex = 0
        Me.opt_Code.Text = "Code"
        Me.opt_Code.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.opt_Code.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Vs1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 71)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1333, 487)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'Vs1
        '
        Me.Vs1.AccessibleDescription = ""
        Me.Vs1.AllowDragFill = True
        Me.Vs1.ClipboardOptions = FarPoint.Win.Spread.ClipboardOptions.NoHeaders
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
        Me.Vs1.Location = New System.Drawing.Point(3, 3)
        Me.Vs1.Name = "Vs1"
        NamedStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle1.Border = BevelBorder1
        NamedStyle1.CanFocus = False
        TextCellType1.WordWrap = True
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
        NamedStyle3.CanFocus = False
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
        Me.Vs1.SheetDSName = Nothing
        Me.Vs1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.Vs1_Sheet1})
        Me.Vs1.Size = New System.Drawing.Size(1327, 481)
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
        Me.Vs1.TabIndex = 12
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
        Vs1_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        Me.Vs1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.Normal, Vs1_InputMapWhenFocusedNormal)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        Me.Vs1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused, FarPoint.Win.Spread.OperationMode.Normal, Vs1_InputMapWhenAncestorOfFocusedNormal)
        '
        'Vs1_Sheet1
        '
        Me.Vs1_Sheet1.Reset()
        Me.Vs1_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.Vs1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.Vs1_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.ColumnFooter.DefaultStyle.Parent = "Style3"
        TextCellType5.WordWrap = True
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.CellType = TextCellType5
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.Parent = "Style2"
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.Renderer = TextCellType5
        Me.Vs1_Sheet1.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs1_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.DefaultStyle.Parent = "Style5"
        Me.Vs1_Sheet1.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.Vs1_Sheet1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.GrayAreaBackColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.CellType = TextCellType5
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.Parent = "Style1"
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.Renderer = TextCellType5
        Me.Vs1_Sheet1.Rows.Default.Height = 22.0!
        Me.Vs1_Sheet1.SelectionBackColor = System.Drawing.Color.Aquamarine
        Me.Vs1_Sheet1.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.SelectionColors
        Me.Vs1_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.SheetCornerStyle.Parent = "Style4"
        Me.Vs1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'PFW99981
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1341, 562)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "PFW99981"
        Me.Text = "Page Control (PFW99981)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tst_4 As PSMGlobal.PeaceToolStripButton
    Friend WithEvents ToolStripSeparator3 As PSMGlobal.PeaceToolStripSep
    Friend WithEvents tst_3 As PSMGlobal.PeaceToolStripButton
    Friend WithEvents ToolStripSeparator4 As PSMGlobal.PeaceToolStripSep
    Friend WithEvents tst_2 As PSMGlobal.PeaceToolStripButton
    Friend WithEvents ToolStripSeparator2 As PSMGlobal.PeaceToolStripSep
    Friend WithEvents tst_5 As PSMGlobal.PeaceToolStripButton
    Friend WithEvents tst_1 As PSMGlobal.PeaceToolStripButton
    Friend WithEvents ToolStripSeparator5 As PSMGlobal.PeaceToolStripSep
    Friend WithEvents ToolStrip1 As PSMGlobal.PeaceToolStrip
    Friend WithEvents ToolStripSeparator6 As PSMGlobal.PeaceToolStripSep
    Friend WithEvents tst_6 As PSMGlobal.PeaceToolStripButton
    Friend WithEvents ToolStripSeparator1 As PSMGlobal.PeaceToolStripSep
    Friend WithEvents ptsb_Manual As PSMGlobal.PeaceToolStripButton
    Friend WithEvents ptsb_Excel As PSMGlobal.PeaceToolStripButton
    Friend WithEvents PPanel As PSMGlobal.PeacePanel
    Friend WithEvents cmd_SEARCH As PSMGlobal.PeaceButton
    Friend WithEvents Panel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents opt_SEL0 As PSMGlobal.PeaceCheckbox
    Friend WithEvents opt_SEL1 As PSMGlobal.PeaceCheckbox
    Friend WithEvents tit_Use As PSMGlobal.PeaceLabel
    Friend WithEvents tit_Sort As PSMGlobal.PeaceLabel
    Friend WithEvents Panel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents opt_Name As PSMGlobal.PeaceRadioButton
    Friend WithEvents opt_Code As PSMGlobal.PeaceRadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Public WithEvents Vs1 As PSMGlobal.PeaceFarpoint
    Friend WithEvents Vs1_Sheet1 As FarPoint.Win.Spread.SheetView
End Class
