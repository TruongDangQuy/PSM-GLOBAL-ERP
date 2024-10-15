<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUBBIG
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
        Me.vSPlan = New PSMGlobal.PeaceFarpoint()
        Me.vSPlan_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip1 = New PSMGlobal.PeaceToolStrip(Me.components)
        Me.ptsb_Manual = New PSMGlobal.PeaceToolStripButton(Me.components)
        Me.ptsb_Help = New PSMGlobal.PeaceToolStripButton(Me.components)
        Me.ptsb_Excel = New PSMGlobal.PeaceToolStripButton(Me.components)
        CType(Me.vSPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vSPlan_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'vSPlan
        '
        Me.vSPlan.AccessibleDescription = ""
        Me.vSPlan.BorderStyle = BorderStyle.FixedSingle
        Me.vSPlan.CopyPasteChk = True
        Me.vSPlan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vSPlan.FocusRenderer = EnhancedFocusIndicatorRenderer1
        Me.vSPlan.HorizontalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.vSPlan.HorizontalScrollBar.Name = ""
        EnhancedScrollBarRenderer1.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer1.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.vSPlan.HorizontalScrollBar.Renderer = EnhancedScrollBarRenderer1
        Me.vSPlan.HorizontalScrollBar.TabIndex = 0
        Me.vSPlan.InsChk = False
        Me.vSPlan.Location = New System.Drawing.Point(4, 35)
        Me.vSPlan.Name = "vSPlan"
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
        Me.vSPlan.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle1, NamedStyle2, NamedStyle3, NamedStyle4, NamedStyle5})
        Me.vSPlan.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.vSPlan_Sheet1})
        Me.vSPlan.Size = New System.Drawing.Size(574, 572)
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
        Me.vSPlan.Skin = SpreadSkin1
        Me.vSPlan.SpreadWjob = 0
        Me.vSPlan.TabIndex = 104
        Me.vSPlan.VerticalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.vSPlan.VerticalScrollBar.Name = ""
        EnhancedScrollBarRenderer3.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer3.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.vSPlan.VerticalScrollBar.Renderer = EnhancedScrollBarRenderer3
        Me.vSPlan.VerticalScrollBar.TabIndex = 1
        '
        'vSPlan_Sheet1
        '
        Me.vSPlan_Sheet1.Reset()
        Me.vSPlan_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.vSPlan_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.vSPlan_Sheet1.ActiveSkin = New FarPoint.Win.Spread.SheetSkin("KhanhHung1", System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer)), FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer)), System.Drawing.Color.White, System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.White, System.Drawing.SystemColors.ButtonFace, False, False, False, True, True, True, False, True, "RowHeaderDefault", "RowHeaderDefault", "RowHeaderDefault", "DataAreaDefault", "RowHeaderDefault")
        Me.vSPlan_Sheet1.ColumnFooter.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vSPlan_Sheet1.ColumnFooter.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.vSPlan_Sheet1.ColumnFooter.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.vSPlan_Sheet1.ColumnFooter.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.vSPlan_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vSPlan_Sheet1.ColumnFooter.DefaultStyle.Parent = "RowHeaderDefault"
        Me.vSPlan_Sheet1.ColumnFooter.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vSPlan_Sheet1.ColumnFooter.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vSPlan_Sheet1.ColumnFooterSheetCornerStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.vSPlan_Sheet1.ColumnFooterSheetCornerStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.vSPlan_Sheet1.ColumnFooterSheetCornerStyle.ForeColor = System.Drawing.Color.White
        Me.vSPlan_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vSPlan_Sheet1.ColumnFooterSheetCornerStyle.Parent = "RowHeaderDefault"
        Me.vSPlan_Sheet1.ColumnFooterSheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vSPlan_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vSPlan_Sheet1.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.vSPlan_Sheet1.ColumnHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.vSPlan_Sheet1.ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.vSPlan_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vSPlan_Sheet1.ColumnHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.vSPlan_Sheet1.ColumnHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vSPlan_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vSPlan_Sheet1.DefaultStyle.ForeColor = System.Drawing.Color.Black
        Me.vSPlan_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vSPlan_Sheet1.DefaultStyle.Parent = "DataAreaDefault"
        Me.vSPlan_Sheet1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vSPlan_Sheet1.FilterBar.DefaultStyle.Parent = "FilterBarDefaultEnhanced"
        Me.vSPlan_Sheet1.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vSPlan_Sheet1.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.vSPlan_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.vSPlan_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vSPlan_Sheet1.RowHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.vSPlan_Sheet1.RowHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.vSPlan_Sheet1.RowHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.vSPlan_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vSPlan_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.vSPlan_Sheet1.RowHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vSPlan_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vSPlan_Sheet1.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.SelectionColors
        Me.vSPlan_Sheet1.SheetCornerStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.vSPlan_Sheet1.SheetCornerStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.vSPlan_Sheet1.SheetCornerStyle.ForeColor = System.Drawing.Color.White
        Me.vSPlan_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vSPlan_Sheet1.SheetCornerStyle.Parent = "RowHeaderDefault"
        Me.vSPlan_Sheet1.SheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vSPlan_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.vSPlan, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(582, 611)
        Me.TableLayoutPanel1.TabIndex = 105
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ptsb_Manual, Me.ptsb_Help, Me.ptsb_Excel})
        Me.ToolStrip1.Location = New System.Drawing.Point(1, 1)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(580, 30)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ptsb_Manual
        '
        Me.ptsb_Manual.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ptsb_Manual.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ptsb_Manual.Image = Global.PSMGlobal.My.Resources.Resources.GroupFooter_16x16
        Me.ptsb_Manual.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ptsb_Manual.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ptsb_Manual.Name = "ptsb_Manual"
        Me.ptsb_Manual.Size = New System.Drawing.Size(28, 27)
        Me.ptsb_Manual.Text = "HELP"
        '
        'ptsb_Help
        '
        Me.ptsb_Help.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ptsb_Help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ptsb_Help.Image = Global.PSMGlobal.My.Resources.Resources.Pivot_16x16
        Me.ptsb_Help.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ptsb_Help.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ptsb_Help.Name = "ptsb_Help"
        Me.ptsb_Help.Size = New System.Drawing.Size(28, 27)
        Me.ptsb_Help.Text = "HELP"
        '
        'ptsb_Excel
        '
        Me.ptsb_Excel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ptsb_Excel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ptsb_Excel.Image = Global.PSMGlobal.My.Resources.Resources.ExportToXLS_16x16
        Me.ptsb_Excel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ptsb_Excel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ptsb_Excel.Name = "ptsb_Excel"
        Me.ptsb_Excel.Size = New System.Drawing.Size(28, 27)
        Me.ptsb_Excel.Text = "EXCEL"
        '
        'ISUBBIG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(582, 611)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ISUBBIG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORM_VIEW"
        CType(Me.vSPlan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vSPlan_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents vSPlan As PSMGlobal.PeaceFarpoint
    Friend WithEvents vSPlan_Sheet1 As FarPoint.Win.Spread.SheetView
    Public WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Public WithEvents ToolStrip1 As PSMGlobal.PeaceToolStrip
    Public WithEvents ptsb_Manual As PSMGlobal.PeaceToolStripButton
    Public WithEvents ptsb_Help As PSMGlobal.PeaceToolStripButton
    Public WithEvents ptsb_Excel As PSMGlobal.PeaceToolStripButton
End Class
