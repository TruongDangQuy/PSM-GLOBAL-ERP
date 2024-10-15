<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HLP7102A
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
        Dim NamedStyle1 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("BorderEx444636226620155068432", "DataAreaDefault")
        Dim ComplexBorder1 As FarPoint.Win.ComplexBorder = New FarPoint.Win.ComplexBorder(New FarPoint.Win.ComplexBorderSide(System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))))
        Dim NamedStyle2 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Text594636226620155224432", "DataAreaDefault")
        Dim TextCellType1 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle3 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Text718636226620155224432")
        Dim TextCellType2 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TipAppearance1 As FarPoint.Win.Spread.TipAppearance = New FarPoint.Win.Spread.TipAppearance()
        Dim TextCellType3 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType4 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.VS1 = New PSMGlobal.PeaceFarpoint()
        Me.VS1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.PeacePanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Name = New PSMGlobal.SelectLabelText()
        Me.cmd_SEARCH = New PSMGlobal.PeaceButton(Me.components)
        Me.PeacePanel2 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.VS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VS1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PeacePanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.9402!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.0598!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.VS1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PeacePanel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PeacePanel2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(592, 616)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'VS1
        '
        Me.VS1.AccessibleDescription = "VS1, Sheet1, Row 0, Column 0, "
        Me.TableLayoutPanel1.SetColumnSpan(Me.VS1, 4)
        Me.VS1.CopyPasteChk = True
        Me.VS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VS1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.VS1.InsChk = False
        Me.VS1.Location = New System.Drawing.Point(0, 34)
        Me.VS1.Margin = New System.Windows.Forms.Padding(0)
        Me.VS1.Name = "VS1"
        NamedStyle1.Border = ComplexBorder1
        NamedStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        NamedStyle1.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle1.Parent = "DataAreaDefault"
        TextCellType1.MaxLength = 60
        NamedStyle2.CellType = TextCellType1
        NamedStyle2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        NamedStyle2.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle2.Parent = "DataAreaDefault"
        NamedStyle2.Renderer = TextCellType1
        TextCellType2.MaxLength = 60
        NamedStyle3.CellType = TextCellType2
        NamedStyle3.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        NamedStyle3.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle3.Renderer = TextCellType2
        NamedStyle3.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.VS1.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle1, NamedStyle2, NamedStyle3})
        Me.VS1.ReportName = Nothing
        Me.VS1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.VS1_Sheet1})
        Me.VS1.Size = New System.Drawing.Size(592, 544)
        Me.VS1.SpreadWjob = 0
        Me.VS1.TabIndex = 47
        Me.VS1.TabStop = False
        Me.VS1.TabStripRatio = 0.6R
        TipAppearance1.BackColor = System.Drawing.SystemColors.Info
        TipAppearance1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        TipAppearance1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.VS1.TextTipAppearance = TipAppearance1
        '
        'VS1_Sheet1
        '
        Me.VS1_Sheet1.Reset()
        Me.VS1_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.VS1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.VS1_Sheet1.ColumnCount = 1
        Me.VS1_Sheet1.RowCount = 20
        Me.VS1_Sheet1.ColumnFooter.Columns.Default.SortIndicator = FarPoint.Win.Spread.Model.SortIndicator.None
        Me.VS1_Sheet1.ColumnFooter.Columns.Default.Width = 64.0!
        Me.VS1_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "NAME"
        Me.VS1_Sheet1.ColumnHeader.Columns.Default.SortIndicator = FarPoint.Win.Spread.Model.SortIndicator.None
        Me.VS1_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.VS1_Sheet1.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        TextCellType3.WordWrap = True
        Me.VS1_Sheet1.ColumnHeader.DefaultStyle.CellType = TextCellType3
        Me.VS1_Sheet1.ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VS1_Sheet1.ColumnHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.VS1_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.VS1_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderDefaultEnhanced"
        Me.VS1_Sheet1.ColumnHeader.DefaultStyle.Renderer = TextCellType3
        Me.VS1_Sheet1.ColumnHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.VS1_Sheet1.ColumnHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.VS1_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.VS1_Sheet1.ColumnHeader.Rows.Get(0).Height = 30.0!
        Me.VS1_Sheet1.Columns.Default.SortIndicator = FarPoint.Win.Spread.Model.SortIndicator.None
        Me.VS1_Sheet1.Columns.Default.Width = 64.0!
        Me.VS1_Sheet1.Columns.Get(0).Label = "NAME"
        Me.VS1_Sheet1.Columns.Get(0).StyleName = "Text718636226620155224432"
        Me.VS1_Sheet1.Columns.Get(0).Width = 492.0!
        Me.VS1_Sheet1.DefaultStyle.CellType = TextCellType1
        Me.VS1_Sheet1.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.VS1_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.VS1_Sheet1.DefaultStyle.Parent = "DataAreaDefault"
        Me.VS1_Sheet1.DefaultStyle.Renderer = TextCellType1
        Me.VS1_Sheet1.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.VS1_Sheet1.GrayAreaBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VS1_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.[ReadOnly]
        Me.VS1_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.VS1_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.VS1_Sheet1.RowHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        TextCellType4.WordWrap = True
        Me.VS1_Sheet1.RowHeader.DefaultStyle.CellType = TextCellType4
        Me.VS1_Sheet1.RowHeader.DefaultStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VS1_Sheet1.RowHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.VS1_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.VS1_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.VS1_Sheet1.RowHeader.DefaultStyle.Renderer = TextCellType4
        Me.VS1_Sheet1.RowHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.VS1_Sheet1.RowHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.VS1_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.VS1_Sheet1.Rows.Default.Height = 22.0!
        Me.VS1_Sheet1.Rows.Get(0).Height = 29.0!
        Me.VS1_Sheet1.Rows.Get(1).Height = 29.0!
        Me.VS1_Sheet1.Rows.Get(2).Height = 29.0!
        Me.VS1_Sheet1.Rows.Get(3).Height = 29.0!
        Me.VS1_Sheet1.Rows.Get(4).Height = 29.0!
        Me.VS1_Sheet1.Rows.Get(5).Height = 29.0!
        Me.VS1_Sheet1.Rows.Get(6).Height = 29.0!
        Me.VS1_Sheet1.Rows.Get(7).Height = 29.0!
        Me.VS1_Sheet1.Rows.Get(8).Height = 29.0!
        Me.VS1_Sheet1.Rows.Get(9).Height = 29.0!
        Me.VS1_Sheet1.Rows.Get(10).Height = 29.0!
        Me.VS1_Sheet1.Rows.Get(11).Height = 29.0!
        Me.VS1_Sheet1.Rows.Get(12).Height = 29.0!
        Me.VS1_Sheet1.Rows.Get(13).Height = 29.0!
        Me.VS1_Sheet1.Rows.Get(14).Height = 29.0!
        Me.VS1_Sheet1.Rows.Get(15).Height = 29.0!
        Me.VS1_Sheet1.Rows.Get(16).Height = 29.0!
        Me.VS1_Sheet1.Rows.Get(17).Height = 29.0!
        Me.VS1_Sheet1.Rows.Get(18).Height = 29.0!
        Me.VS1_Sheet1.Rows.Get(19).Height = 29.0!
        Me.VS1_Sheet1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.VS1_Sheet1.SelectionPolicy = FarPoint.Win.Spread.Model.SelectionPolicy.[Single]
        Me.VS1_Sheet1.SelectionUnit = FarPoint.Win.Spread.Model.SelectionUnit.Row
        Me.VS1_Sheet1.SheetCornerStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.VS1_Sheet1.SheetCornerStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VS1_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.VS1_Sheet1.SheetCornerStyle.Parent = "CornerDefaultEnhanced"
        Me.VS1_Sheet1.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.VS1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'PeacePanel1
        '
        Me.PeacePanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel1.Code = ""
        Me.TableLayoutPanel1.SetColumnSpan(Me.PeacePanel1, 4)
        Me.PeacePanel1.Controls.Add(Me.TableLayoutPanel2)
        Me.PeacePanel1.Data = ""
        Me.PeacePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeacePanel1.Location = New System.Drawing.Point(4, 3)
        Me.PeacePanel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PeacePanel1.Name = "PeacePanel1"
        Me.PeacePanel1.Size = New System.Drawing.Size(584, 28)
        Me.PeacePanel1.TabIndex = 46
        Me.PeacePanel1.Tag = ""
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txt_Name, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmd_SEARCH, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(580, 24)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'txt_Name
        '
        Me.txt_Name.BackYesno = False
        Me.txt_Name.ButtonTitle = Nothing
        Me.txt_Name.Code = ""
        Me.txt_Name.Data = ""
        Me.txt_Name.DataDecimal = 0
        Me.txt_Name.DataLen = 0
        Me.txt_Name.DataValue = 0
        Me.txt_Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Name.FormatDecimal = 0
        Me.txt_Name.FormatValue = False
        Me.txt_Name.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Name.LableEnabled = True
        Me.txt_Name.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Name.LableForeColor = System.Drawing.Color.Black
        Me.txt_Name.LableTitle = "NAME"
        Me.txt_Name.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Name.Location = New System.Drawing.Point(2, 2)
        Me.txt_Name.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Name.Size = New System.Drawing.Size(397, 20)
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
        Me.cmd_SEARCH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd_SEARCH.Image = Global.PSMGlobal.My.Resources.Resources.find_f
        Me.cmd_SEARCH.ImageAlign = 16
        Me.cmd_SEARCH.Location = New System.Drawing.Point(402, 2)
        Me.cmd_SEARCH.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_SEARCH.Name = "cmd_SEARCH"
        Me.cmd_SEARCH.Size = New System.Drawing.Size(176, 20)
        Me.cmd_SEARCH.TabIndex = 1
        Me.cmd_SEARCH.Text = "Search(&S)"
        Me.cmd_SEARCH.UseVisualStyleBackColor = False
        '
        'PeacePanel2
        '
        Me.PeacePanel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel2.Code = ""
        Me.TableLayoutPanel1.SetColumnSpan(Me.PeacePanel2, 4)
        Me.PeacePanel2.Controls.Add(Me.cmd_OK)
        Me.PeacePanel2.Controls.Add(Me.cmd_Cancel)
        Me.PeacePanel2.Data = ""
        Me.PeacePanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeacePanel2.Location = New System.Drawing.Point(4, 581)
        Me.PeacePanel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PeacePanel2.Name = "PeacePanel2"
        Me.PeacePanel2.Size = New System.Drawing.Size(584, 32)
        Me.PeacePanel2.TabIndex = 48
        Me.PeacePanel2.Tag = ""
        '
        'cmd_OK
        '
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_OK.ButtonTitle = Nothing
        Me.cmd_OK.Code = ""
        Me.cmd_OK.Data = ""
        Me.cmd_OK.Image = Global.PSMGlobal.My.Resources.Resources.save
        Me.cmd_OK.ImageAlign = 16
        Me.cmd_OK.Location = New System.Drawing.Point(280, 1)
        Me.cmd_OK.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(148, 28)
        Me.cmd_OK.TabIndex = 44
        Me.cmd_OK.TabStop = False
        Me.cmd_OK.Tag = ""
        Me.cmd_OK.Text = "Save(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.ButtonTitle = Nothing
        Me.cmd_Cancel.Code = ""
        Me.cmd_Cancel.Data = ""
        Me.cmd_Cancel.Image = Global.PSMGlobal.My.Resources.Resources.delete
        Me.cmd_Cancel.ImageAlign = 16
        Me.cmd_Cancel.Location = New System.Drawing.Point(431, 1)
        Me.cmd_Cancel.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(148, 28)
        Me.cmd_Cancel.TabIndex = 43
        Me.cmd_Cancel.TabStop = False
        Me.cmd_Cancel.Tag = ""
        Me.cmd_Cancel.Text = "Close(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'HLP7102A
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(592, 616)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "HLP7102A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OBJECT CODE HELP (HLP7102A)"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.VS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VS1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PeacePanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmd_SEARCH As PSMGlobal.PeaceButton
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents txt_Name As PSMGlobal.SelectLabelText
    Friend WithEvents VS1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents PeacePanel1 As PSMGlobal.PeacePanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PeacePanel2 As PSMGlobal.PeacePanel
    Public WithEvents VS1 As PSMGlobal.PeaceFarpoint
End Class
