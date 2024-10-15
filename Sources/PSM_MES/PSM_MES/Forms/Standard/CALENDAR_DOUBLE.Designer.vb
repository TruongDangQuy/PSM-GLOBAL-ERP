<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CALENDAR_DOUBLE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CALENDAR_DOUBLE))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PeacePanel4 = New PSMGlobal.PeacePanel(Me.components)
        Me.FpSpread2 = New PeaceFarpoint
        Me.SheetView1 = New FarPoint.Win.Spread.SheetView()
        Me.PeacePanel5 = New PSMGlobal.PeacePanel(Me.components)
        Me.btn_Close = New PSMGlobal.PeaceButton(Me.components)
        Me.btn_ok = New PSMGlobal.PeaceButton(Me.components)
        Me.PeacePanel6 = New PSMGlobal.PeacePanel(Me.components)
        Me.cb_eyear = New PSMGlobal.PeaceCombobox(Me.components)
        Me.btn_next2 = New PSMGlobal.PeaceButton(Me.components)
        Me.PeaceLabel1 = New PSMGlobal.PeaceLabel(Me.components)
        Me.btn_back2 = New PSMGlobal.PeaceButton(Me.components)
        Me.PeaceLabel3 = New PSMGlobal.PeaceLabel(Me.components)
        Me.cb_emonth = New PSMGlobal.PeaceCombobox(Me.components)
        Me.PeacePanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.FpSpread1 = New PeaceFarpoint
        Me.FpSpread1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.PeacePanel3 = New PSMGlobal.PeacePanel(Me.components)
        Me.btn_del = New PSMGlobal.PeaceButton(Me.components)
        Me.PeacePanel2 = New PSMGlobal.PeacePanel(Me.components)
        Me.cb_syear = New PSMGlobal.PeaceCombobox(Me.components)
        Me.btn_next1 = New PSMGlobal.PeaceButton(Me.components)
        Me.lbl_yy = New PSMGlobal.PeaceLabel(Me.components)
        Me.btn_back1 = New PSMGlobal.PeaceButton(Me.components)
        Me.PeaceLabel2 = New PSMGlobal.PeaceLabel(Me.components)
        Me.cb_smonth = New PSMGlobal.PeaceCombobox(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PeacePanel4.SuspendLayout()
        CType(Me.FpSpread2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SheetView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel5.SuspendLayout()
        Me.PeacePanel6.SuspendLayout()
        Me.PeacePanel1.SuspendLayout()
        CType(Me.FpSpread1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FpSpread1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel3.SuspendLayout()
        Me.PeacePanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PeacePanel4, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PeacePanel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1000, 486)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PeacePanel4
        '
        Me.PeacePanel4.Controls.Add(Me.FpSpread2)
        Me.PeacePanel4.Controls.Add(Me.PeacePanel5)
        Me.PeacePanel4.Controls.Add(Me.PeacePanel6)
        Me.PeacePanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeacePanel4.Location = New System.Drawing.Point(503, 3)
        Me.PeacePanel4.Name = "PeacePanel4"
        Me.PeacePanel4.Size = New System.Drawing.Size(494, 480)
        Me.PeacePanel4.TabIndex = 1
        '
        'FpSpread2
        '
        Me.FpSpread2.AccessibleDescription = "FpSpread1, Sheet1, Row 0, Column 0, "
        Me.FpSpread2.AllowUserZoom = False
        Me.FpSpread2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FpSpread2.FocusRenderer = New FarPoint.Win.Spread.CustomFocusIndicatorRenderer(CType(resources.GetObject("FpSpread2.FocusRenderer"), System.Drawing.Bitmap), 1)
        Me.FpSpread2.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never
        Me.FpSpread2.Location = New System.Drawing.Point(0, 72)
        Me.FpSpread2.Name = "FpSpread2"
        Me.FpSpread2.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.Cells
        Me.FpSpread2.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.SheetView1})
        Me.FpSpread2.Size = New System.Drawing.Size(494, 347)
        Me.FpSpread2.TabIndex = 11
        Me.FpSpread2.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never
        '
        'SheetView1
        '
        Me.SheetView1.Reset()
        Me.SheetView1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.SheetView1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        SheetView1.ColumnCount = 7
        SheetView1.RowCount = 6
        Me.SheetView1.Cells.Get(0, 0).Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!)
        Me.SheetView1.Cells.Get(0, 0).Locked = True
        Me.SheetView1.Cells.Get(0, 1).Locked = True
        Me.SheetView1.Cells.Get(0, 2).Locked = True
        Me.SheetView1.Cells.Get(0, 3).Locked = True
        Me.SheetView1.Cells.Get(0, 4).Locked = True
        Me.SheetView1.Cells.Get(0, 5).Locked = True
        Me.SheetView1.Cells.Get(0, 6).Locked = True
        Me.SheetView1.Cells.Get(1, 0).Locked = True
        Me.SheetView1.Cells.Get(1, 1).Locked = True
        Me.SheetView1.Cells.Get(1, 2).Locked = True
        Me.SheetView1.Cells.Get(1, 3).Locked = True
        Me.SheetView1.Cells.Get(1, 4).Locked = True
        Me.SheetView1.Cells.Get(1, 5).Locked = True
        Me.SheetView1.Cells.Get(1, 6).Locked = True
        Me.SheetView1.Cells.Get(2, 0).Locked = True
        Me.SheetView1.Cells.Get(2, 1).Locked = True
        Me.SheetView1.Cells.Get(2, 2).Locked = True
        Me.SheetView1.Cells.Get(2, 3).Locked = True
        Me.SheetView1.Cells.Get(2, 4).Locked = True
        Me.SheetView1.Cells.Get(2, 5).Locked = True
        Me.SheetView1.Cells.Get(2, 6).Locked = True
        Me.SheetView1.Cells.Get(3, 0).Locked = True
        Me.SheetView1.Cells.Get(3, 1).Locked = True
        Me.SheetView1.Cells.Get(3, 2).Locked = True
        Me.SheetView1.Cells.Get(3, 3).Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!)
        Me.SheetView1.Cells.Get(3, 3).Locked = True
        Me.SheetView1.Cells.Get(3, 4).Locked = True
        Me.SheetView1.Cells.Get(3, 5).Locked = True
        Me.SheetView1.Cells.Get(3, 6).Locked = True
        Me.SheetView1.Cells.Get(4, 0).Locked = True
        Me.SheetView1.Cells.Get(4, 1).Locked = True
        Me.SheetView1.Cells.Get(4, 2).Locked = True
        Me.SheetView1.Cells.Get(4, 3).Locked = True
        Me.SheetView1.Cells.Get(4, 4).Locked = True
        Me.SheetView1.Cells.Get(4, 5).Locked = True
        Me.SheetView1.Cells.Get(4, 6).Locked = True
        Me.SheetView1.Cells.Get(5, 0).Locked = True
        Me.SheetView1.Cells.Get(5, 1).Locked = True
        Me.SheetView1.Cells.Get(5, 2).Locked = True
        Me.SheetView1.Cells.Get(5, 3).Locked = True
        Me.SheetView1.Cells.Get(5, 4).Locked = True
        Me.SheetView1.Cells.Get(5, 5).Locked = True
        Me.SheetView1.Cells.Get(5, 6).Locked = True
        Me.SheetView1.ColumnHeader.Cells.Get(0, 0).Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SheetView1.ColumnHeader.Cells.Get(0, 0).Value = "SUN"
        Me.SheetView1.ColumnHeader.Cells.Get(0, 1).Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SheetView1.ColumnHeader.Cells.Get(0, 1).Value = "MON"
        Me.SheetView1.ColumnHeader.Cells.Get(0, 2).Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SheetView1.ColumnHeader.Cells.Get(0, 2).Value = "TUE"
        Me.SheetView1.ColumnHeader.Cells.Get(0, 3).Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SheetView1.ColumnHeader.Cells.Get(0, 3).Value = "WED"
        Me.SheetView1.ColumnHeader.Cells.Get(0, 4).Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SheetView1.ColumnHeader.Cells.Get(0, 4).Value = "THU"
        Me.SheetView1.ColumnHeader.Cells.Get(0, 5).Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SheetView1.ColumnHeader.Cells.Get(0, 5).Value = "FRI"
        Me.SheetView1.ColumnHeader.Cells.Get(0, 6).Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SheetView1.ColumnHeader.Cells.Get(0, 6).Value = "SAT"
        Me.SheetView1.ColumnHeader.Rows.Get(0).Height = 38.0!
        Me.SheetView1.Columns.Get(0).Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SheetView1.Columns.Get(0).Label = "SUN"
        Me.SheetView1.Columns.Get(0).Width = 70.0!
        Me.SheetView1.Columns.Get(1).Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SheetView1.Columns.Get(1).Label = "MON"
        Me.SheetView1.Columns.Get(1).Width = 70.0!
        Me.SheetView1.Columns.Get(2).Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SheetView1.Columns.Get(2).Label = "TUE"
        Me.SheetView1.Columns.Get(2).Width = 70.0!
        Me.SheetView1.Columns.Get(3).Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SheetView1.Columns.Get(3).Label = "WED"
        Me.SheetView1.Columns.Get(3).Width = 70.0!
        Me.SheetView1.Columns.Get(4).Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SheetView1.Columns.Get(4).Label = "THU"
        Me.SheetView1.Columns.Get(4).Width = 70.0!
        Me.SheetView1.Columns.Get(5).Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SheetView1.Columns.Get(5).Label = "FRI"
        Me.SheetView1.Columns.Get(5).Width = 70.0!
        Me.SheetView1.Columns.Get(6).Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SheetView1.Columns.Get(6).Label = "SAT"
        Me.SheetView1.Columns.Get(6).Width = 70.0!
        Me.SheetView1.DefaultStyle.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!)
        Me.SheetView1.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.SheetView1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView1.DefaultStyle.Parent = "DataAreaDefault"
        Me.SheetView1.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.SheetView1.GrayAreaBackColor = System.Drawing.Color.White
        Me.SheetView1.RangeGroupBackgroundColor = System.Drawing.Color.Empty
        Me.SheetView1.RowHeader.Columns.Default.Resizable = False
        Me.SheetView1.RowHeader.Columns.Get(0).Width = 0.0!
        Me.SheetView1.Rows.Get(0).Height = 51.0!
        Me.SheetView1.Rows.Get(1).Height = 51.0!
        Me.SheetView1.Rows.Get(2).Height = 51.0!
        Me.SheetView1.Rows.Get(3).Height = 51.0!
        Me.SheetView1.Rows.Get(4).Height = 51.0!
        Me.SheetView1.Rows.Get(5).Height = 51.0!
        Me.SheetView1.SelectionBackColor = System.Drawing.Color.White
        Me.SheetView1.SelectionForeColor = System.Drawing.Color.White
        Me.SheetView1.SelectionPolicy = FarPoint.Win.Spread.Model.SelectionPolicy.[Single]
        Me.SheetView1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'PeacePanel5
        '
        Me.PeacePanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PeacePanel5.Controls.Add(Me.btn_Close)
        Me.PeacePanel5.Controls.Add(Me.btn_ok)
        Me.PeacePanel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PeacePanel5.Location = New System.Drawing.Point(0, 419)
        Me.PeacePanel5.Name = "PeacePanel5"
        Me.PeacePanel5.Size = New System.Drawing.Size(494, 61)
        Me.PeacePanel5.TabIndex = 9
        '
        'btn_Close
        '
        Me.btn_Close.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_Close.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Close.Location = New System.Drawing.Point(377, 5)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(113, 52)
        Me.btn_Close.TabIndex = 4
        Me.btn_Close.Text = "CLOSE(&X)"
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_ok.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_ok.Location = New System.Drawing.Point(260, 5)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(113, 52)
        Me.btn_ok.TabIndex = 4
        Me.btn_ok.Text = "OK(&K)"
        '
        'PeacePanel6
        '
        Me.PeacePanel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PeacePanel6.Controls.Add(Me.cb_eyear)
        Me.PeacePanel6.Controls.Add(Me.btn_next2)
        Me.PeacePanel6.Controls.Add(Me.PeaceLabel1)
        Me.PeacePanel6.Controls.Add(Me.btn_back2)
        Me.PeacePanel6.Controls.Add(Me.PeaceLabel3)
        Me.PeacePanel6.Controls.Add(Me.cb_emonth)
        Me.PeacePanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.PeacePanel6.Location = New System.Drawing.Point(0, 0)
        Me.PeacePanel6.Name = "PeacePanel6"
        Me.PeacePanel6.Size = New System.Drawing.Size(494, 72)
        Me.PeacePanel6.TabIndex = 7
        '
        'cb_eyear
        '
        Me.cb_eyear.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cb_eyear.FormattingEnabled = True
        Me.cb_eyear.Location = New System.Drawing.Point(70, 22)
        Me.cb_eyear.Name = "cb_eyear"
        Me.cb_eyear.Size = New System.Drawing.Size(92, 27)
        Me.cb_eyear.TabIndex = 1
        '
        'btn_next2
        '
        Me.btn_next2.BackColor = System.Drawing.Color.White
        Me.btn_next2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_next2.Image = Global.PSMGlobal.My.Resources.Resources.next1
        Me.btn_next2.Location = New System.Drawing.Point(421, 11)
        Me.btn_next2.Name = "btn_next2"
        Me.btn_next2.Size = New System.Drawing.Size(64, 48)
        Me.btn_next2.TabIndex = 5
        '
        'PeaceLabel1
        '
        Me.PeaceLabel1.AutoSize = True
        Me.PeaceLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceLabel1.Location = New System.Drawing.Point(7, 25)
        Me.PeaceLabel1.Name = "PeaceLabel1"
        Me.PeaceLabel1.Size = New System.Drawing.Size(49, 19)
        Me.PeaceLabel1.TabIndex = 0
        Me.PeaceLabel1.Text = "YEAR"
        '
        'btn_back2
        '
        Me.btn_back2.BackColor = System.Drawing.Color.White
        Me.btn_back2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_back2.Image = Global.PSMGlobal.My.Resources.Resources.Previous1
        Me.btn_back2.Location = New System.Drawing.Point(351, 11)
        Me.btn_back2.Name = "btn_back2"
        Me.btn_back2.Size = New System.Drawing.Size(64, 48)
        Me.btn_back2.TabIndex = 4
        '
        'PeaceLabel3
        '
        Me.PeaceLabel3.AutoSize = True
        Me.PeaceLabel3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceLabel3.Location = New System.Drawing.Point(168, 25)
        Me.PeaceLabel3.Name = "PeaceLabel3"
        Me.PeaceLabel3.Size = New System.Drawing.Size(65, 19)
        Me.PeaceLabel3.TabIndex = 2
        Me.PeaceLabel3.Text = "MONTH"
        '
        'cb_emonth
        '
        Me.cb_emonth.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cb_emonth.FormattingEnabled = True
        Me.cb_emonth.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cb_emonth.Location = New System.Drawing.Point(245, 22)
        Me.cb_emonth.Name = "cb_emonth"
        Me.cb_emonth.Size = New System.Drawing.Size(94, 27)
        Me.cb_emonth.TabIndex = 3
        '
        'PeacePanel1
        '
        Me.PeacePanel1.Controls.Add(Me.FpSpread1)
        Me.PeacePanel1.Controls.Add(Me.PeacePanel3)
        Me.PeacePanel1.Controls.Add(Me.PeacePanel2)
        Me.PeacePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeacePanel1.Location = New System.Drawing.Point(3, 3)
        Me.PeacePanel1.Name = "PeacePanel1"
        Me.PeacePanel1.Size = New System.Drawing.Size(494, 480)
        Me.PeacePanel1.TabIndex = 0
        '
        'FpSpread1
        '
        Me.FpSpread1.AccessibleDescription = "FpSpread1, Sheet1, Row 0, Column 0, "
        Me.FpSpread1.AllowUserZoom = False
        Me.FpSpread1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FpSpread1.FocusRenderer = New FarPoint.Win.Spread.CustomFocusIndicatorRenderer(CType(resources.GetObject("FpSpread1.FocusRenderer"), System.Drawing.Bitmap), 1)
        Me.FpSpread1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never
        Me.FpSpread1.Location = New System.Drawing.Point(0, 72)
        Me.FpSpread1.Name = "FpSpread1"
        Me.FpSpread1.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.Cells
        Me.FpSpread1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.FpSpread1_Sheet1})
        Me.FpSpread1.Size = New System.Drawing.Size(494, 347)
        Me.FpSpread1.TabIndex = 10
        Me.FpSpread1.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never
        '
        'FpSpread1_Sheet1
        '
        Me.FpSpread1_Sheet1.Reset()
        Me.FpSpread1_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.FpSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        FpSpread1_Sheet1.ColumnCount = 7
        FpSpread1_Sheet1.RowCount = 6
        Me.FpSpread1_Sheet1.Cells.Get(0, 0).Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!)
        Me.FpSpread1_Sheet1.Cells.Get(0, 0).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(0, 1).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(0, 2).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(0, 3).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(0, 4).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(0, 5).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(0, 6).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(1, 0).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(1, 1).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(1, 2).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(1, 3).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(1, 4).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(1, 5).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(1, 6).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(2, 0).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(2, 1).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(2, 2).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(2, 3).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(2, 4).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(2, 5).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(2, 6).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(3, 0).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(3, 1).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(3, 2).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(3, 3).Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!)
        Me.FpSpread1_Sheet1.Cells.Get(3, 3).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(3, 4).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(3, 5).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(3, 6).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(4, 0).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(4, 1).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(4, 2).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(4, 3).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(4, 4).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(4, 5).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(4, 6).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(5, 0).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(5, 1).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(5, 2).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(5, 3).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(5, 4).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(5, 5).Locked = True
        Me.FpSpread1_Sheet1.Cells.Get(5, 6).Locked = True
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 0).Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "SUN"
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 1).Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "MON"
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 2).Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "TUE"
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 3).Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "WED"
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 4).Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "THU"
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 5).Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "FRI"
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 6).Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "SAT"
        Me.FpSpread1_Sheet1.ColumnHeader.Rows.Get(0).Height = 38.0!
        Me.FpSpread1_Sheet1.Columns.Get(0).Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.FpSpread1_Sheet1.Columns.Get(0).Label = "SUN"
        Me.FpSpread1_Sheet1.Columns.Get(0).Width = 70.0!
        Me.FpSpread1_Sheet1.Columns.Get(1).Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.FpSpread1_Sheet1.Columns.Get(1).Label = "MON"
        Me.FpSpread1_Sheet1.Columns.Get(1).Width = 70.0!
        Me.FpSpread1_Sheet1.Columns.Get(2).Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.FpSpread1_Sheet1.Columns.Get(2).Label = "TUE"
        Me.FpSpread1_Sheet1.Columns.Get(2).Width = 70.0!
        Me.FpSpread1_Sheet1.Columns.Get(3).Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.FpSpread1_Sheet1.Columns.Get(3).Label = "WED"
        Me.FpSpread1_Sheet1.Columns.Get(3).Width = 70.0!
        Me.FpSpread1_Sheet1.Columns.Get(4).Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.FpSpread1_Sheet1.Columns.Get(4).Label = "THU"
        Me.FpSpread1_Sheet1.Columns.Get(4).Width = 70.0!
        Me.FpSpread1_Sheet1.Columns.Get(5).Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.FpSpread1_Sheet1.Columns.Get(5).Label = "FRI"
        Me.FpSpread1_Sheet1.Columns.Get(5).Width = 70.0!
        Me.FpSpread1_Sheet1.Columns.Get(6).Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.FpSpread1_Sheet1.Columns.Get(6).Label = "SAT"
        Me.FpSpread1_Sheet1.Columns.Get(6).Width = 70.0!
        Me.FpSpread1_Sheet1.DefaultStyle.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!)
        Me.FpSpread1_Sheet1.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        Me.FpSpread1_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.FpSpread1_Sheet1.DefaultStyle.Parent = "DataAreaDefault"
        Me.FpSpread1_Sheet1.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.FpSpread1_Sheet1.GrayAreaBackColor = System.Drawing.Color.White
        Me.FpSpread1_Sheet1.RangeGroupBackgroundColor = System.Drawing.Color.Empty
        Me.FpSpread1_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.FpSpread1_Sheet1.RowHeader.Columns.Get(0).Width = 0.0!
        Me.FpSpread1_Sheet1.Rows.Get(0).Height = 51.0!
        Me.FpSpread1_Sheet1.Rows.Get(1).Height = 51.0!
        Me.FpSpread1_Sheet1.Rows.Get(2).Height = 51.0!
        Me.FpSpread1_Sheet1.Rows.Get(3).Height = 51.0!
        Me.FpSpread1_Sheet1.Rows.Get(4).Height = 51.0!
        Me.FpSpread1_Sheet1.Rows.Get(5).Height = 51.0!
        Me.FpSpread1_Sheet1.SelectionBackColor = System.Drawing.Color.White
        Me.FpSpread1_Sheet1.SelectionForeColor = System.Drawing.Color.White
        Me.FpSpread1_Sheet1.SelectionPolicy = FarPoint.Win.Spread.Model.SelectionPolicy.[Single]
        Me.FpSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'PeacePanel3
        '
        Me.PeacePanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PeacePanel3.Controls.Add(Me.btn_del)
        Me.PeacePanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PeacePanel3.Location = New System.Drawing.Point(0, 419)
        Me.PeacePanel3.Name = "PeacePanel3"
        Me.PeacePanel3.Size = New System.Drawing.Size(494, 61)
        Me.PeacePanel3.TabIndex = 9
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_del.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_del.Location = New System.Drawing.Point(4, 4)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(120, 52)
        Me.btn_del.TabIndex = 4
        Me.btn_del.Text = "DELETE(&D)"
        '
        'PeacePanel2
        '
        Me.PeacePanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PeacePanel2.Controls.Add(Me.cb_syear)
        Me.PeacePanel2.Controls.Add(Me.btn_next1)
        Me.PeacePanel2.Controls.Add(Me.lbl_yy)
        Me.PeacePanel2.Controls.Add(Me.btn_back1)
        Me.PeacePanel2.Controls.Add(Me.PeaceLabel2)
        Me.PeacePanel2.Controls.Add(Me.cb_smonth)
        Me.PeacePanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PeacePanel2.Location = New System.Drawing.Point(0, 0)
        Me.PeacePanel2.Name = "PeacePanel2"
        Me.PeacePanel2.Size = New System.Drawing.Size(494, 72)
        Me.PeacePanel2.TabIndex = 7
        '
        'cb_syear
        '
        Me.cb_syear.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cb_syear.FormattingEnabled = True
        Me.cb_syear.Location = New System.Drawing.Point(70, 22)
        Me.cb_syear.Name = "cb_syear"
        Me.cb_syear.Size = New System.Drawing.Size(92, 27)
        Me.cb_syear.TabIndex = 1
        '
        'btn_next1
        '
        Me.btn_next1.BackColor = System.Drawing.Color.White
        Me.btn_next1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_next1.Image = Global.PSMGlobal.My.Resources.Resources.next1
        Me.btn_next1.Location = New System.Drawing.Point(421, 11)
        Me.btn_next1.Name = "btn_next1"
        Me.btn_next1.Size = New System.Drawing.Size(64, 48)
        Me.btn_next1.TabIndex = 5
        '
        'lbl_yy
        '
        Me.lbl_yy.AutoSize = True
        Me.lbl_yy.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lbl_yy.Location = New System.Drawing.Point(7, 25)
        Me.lbl_yy.Name = "lbl_yy"
        Me.lbl_yy.Size = New System.Drawing.Size(49, 19)
        Me.lbl_yy.TabIndex = 0
        Me.lbl_yy.Text = "YEAR"
        '
        'btn_back1
        '
        Me.btn_back1.BackColor = System.Drawing.Color.White
        Me.btn_back1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_back1.Image = Global.PSMGlobal.My.Resources.Resources.Previous1
        Me.btn_back1.Location = New System.Drawing.Point(351, 11)
        Me.btn_back1.Name = "btn_back1"
        Me.btn_back1.Size = New System.Drawing.Size(64, 48)
        Me.btn_back1.TabIndex = 4
        '
        'PeaceLabel2
        '
        Me.PeaceLabel2.AutoSize = True
        Me.PeaceLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceLabel2.Location = New System.Drawing.Point(168, 25)
        Me.PeaceLabel2.Name = "PeaceLabel2"
        Me.PeaceLabel2.Size = New System.Drawing.Size(65, 19)
        Me.PeaceLabel2.TabIndex = 2
        Me.PeaceLabel2.Text = "MONTH"
        '
        'cb_smonth
        '
        Me.cb_smonth.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cb_smonth.FormattingEnabled = True
        Me.cb_smonth.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cb_smonth.Location = New System.Drawing.Point(245, 22)
        Me.cb_smonth.Name = "cb_smonth"
        Me.cb_smonth.Size = New System.Drawing.Size(94, 27)
        Me.cb_smonth.TabIndex = 3
        '
        'CALENDAR_DOUBLE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1000, 486)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "CALENDAR_DOUBLE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CALENDAR_DOUBLE"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PeacePanel4.ResumeLayout(False)
        CType(Me.FpSpread2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SheetView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel5.ResumeLayout(False)
        Me.PeacePanel6.ResumeLayout(False)
        Me.PeacePanel6.PerformLayout()
        Me.PeacePanel1.ResumeLayout(False)
        CType(Me.FpSpread1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FpSpread1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel3.ResumeLayout(False)
        Me.PeacePanel2.ResumeLayout(False)
        Me.PeacePanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PeacePanel1 As PSMGlobal.PeacePanel
    Friend WithEvents PeacePanel2 As PSMGlobal.PeacePanel
    Friend WithEvents cb_syear As PSMGlobal.PeaceCombobox
    Friend WithEvents btn_next1 As PSMGlobal.PeaceButton
    Friend WithEvents lbl_yy As PSMGlobal.PeaceLabel
    Friend WithEvents btn_back1 As PSMGlobal.PeaceButton
    Friend WithEvents PeaceLabel2 As PSMGlobal.PeaceLabel
    Friend WithEvents cb_smonth As PSMGlobal.PeaceCombobox
    Friend WithEvents PeacePanel4 As PSMGlobal.PeacePanel
    Friend WithEvents PeacePanel5 As PSMGlobal.PeacePanel
    Friend WithEvents btn_Close As PSMGlobal.PeaceButton
    Friend WithEvents btn_ok As PSMGlobal.PeaceButton
    Friend WithEvents PeacePanel6 As PSMGlobal.PeacePanel
    Friend WithEvents cb_eyear As PSMGlobal.PeaceCombobox
    Friend WithEvents btn_next2 As PSMGlobal.PeaceButton
    Friend WithEvents PeaceLabel1 As PSMGlobal.PeaceLabel
    Friend WithEvents btn_back2 As PSMGlobal.PeaceButton
    Friend WithEvents PeaceLabel3 As PSMGlobal.PeaceLabel
    Friend WithEvents cb_emonth As PSMGlobal.PeaceCombobox
    Friend WithEvents PeacePanel3 As PSMGlobal.PeacePanel
    Friend WithEvents btn_del As PSMGlobal.PeaceButton
    Friend WithEvents FpSpread2 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents SheetView1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents FpSpread1 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents FpSpread1_Sheet1 As FarPoint.Win.Spread.SheetView
End Class
