<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CALENDAR_SINGLE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CALENDAR_SINGLE))
        Me.lbl_yy = New PSMGlobal.PeaceLabel(Me.components)
        Me.cmb_year = New PSMGlobal.PeaceCombobox(Me.components)
        Me.PeaceLabel2 = New PSMGlobal.PeaceLabel(Me.components)
        Me.cmb_month = New PSMGlobal.PeaceCombobox(Me.components)
        Me.btn_back = New PSMGlobal.PeaceButton(Me.components)
        Me.btn_next = New PSMGlobal.PeaceButton(Me.components)
        Me.PeacePanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.PeacePanel2 = New PSMGlobal.PeacePanel(Me.components)
        Me.btn_close = New PSMGlobal.PeaceButton(Me.components)
        Me.btn_ok = New PSMGlobal.PeaceButton(Me.components)
        Me.btn_del = New PSMGlobal.PeaceButton(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FpSpread1 = New PeaceFarpoint
        Me.FpSpread1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.PeacePanel1.SuspendLayout()
        Me.PeacePanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.FpSpread1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FpSpread1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_yy
        '
        Me.lbl_yy.AutoSize = True
        Me.lbl_yy.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_yy.Location = New System.Drawing.Point(7, 25)
        Me.lbl_yy.Name = "lbl_yy"
        Me.lbl_yy.Size = New System.Drawing.Size(58, 20)
        Me.lbl_yy.TabIndex = 0
        Me.lbl_yy.Text = "YEAR"
        '
        'cmb_year
        '
        Me.cmb_year.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmb_year.FormattingEnabled = True
        Me.cmb_year.Location = New System.Drawing.Point(70, 22)
        Me.cmb_year.Name = "cmb_year"
        Me.cmb_year.Size = New System.Drawing.Size(92, 28)
        Me.cmb_year.TabIndex = 1
        '
        'PeaceLabel2
        '
        Me.PeaceLabel2.AutoSize = True
        Me.PeaceLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceLabel2.Location = New System.Drawing.Point(168, 25)
        Me.PeaceLabel2.Name = "PeaceLabel2"
        Me.PeaceLabel2.Size = New System.Drawing.Size(71, 20)
        Me.PeaceLabel2.TabIndex = 2
        Me.PeaceLabel2.Text = "MONTH"
        '
        'cmb_month
        '
        Me.cmb_month.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmb_month.FormattingEnabled = True
        Me.cmb_month.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cmb_month.Location = New System.Drawing.Point(245, 22)
        Me.cmb_month.Name = "cmb_month"
        Me.cmb_month.Size = New System.Drawing.Size(94, 28)
        Me.cmb_month.TabIndex = 3
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.White
        Me.btn_back.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_back.Image = Global.PSMGlobal.My.Resources.Resources.Previous1
        Me.btn_back.Location = New System.Drawing.Point(351, 11)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(64, 48)
        Me.btn_back.TabIndex = 4
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_next
        '
        Me.btn_next.BackColor = System.Drawing.Color.White
        Me.btn_next.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_next.Image = Global.PSMGlobal.My.Resources.Resources.next1
        Me.btn_next.Location = New System.Drawing.Point(421, 11)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(64, 48)
        Me.btn_next.TabIndex = 5
        Me.btn_next.UseVisualStyleBackColor = False
        '
        'PeacePanel1
        '
        Me.PeacePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PeacePanel1.Controls.Add(Me.cmb_year)
        Me.PeacePanel1.Controls.Add(Me.btn_next)
        Me.PeacePanel1.Controls.Add(Me.lbl_yy)
        Me.PeacePanel1.Controls.Add(Me.btn_back)
        Me.PeacePanel1.Controls.Add(Me.PeaceLabel2)
        Me.PeacePanel1.Controls.Add(Me.cmb_month)
        Me.PeacePanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PeacePanel1.Location = New System.Drawing.Point(0, 0)
        Me.PeacePanel1.Name = "PeacePanel1"
        Me.PeacePanel1.Size = New System.Drawing.Size(495, 72)
        Me.PeacePanel1.TabIndex = 6
        '
        'PeacePanel2
        '
        Me.PeacePanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PeacePanel2.Controls.Add(Me.btn_close)
        Me.PeacePanel2.Controls.Add(Me.btn_ok)
        Me.PeacePanel2.Controls.Add(Me.btn_del)
        Me.PeacePanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PeacePanel2.Location = New System.Drawing.Point(0, 421)
        Me.PeacePanel2.Name = "PeacePanel2"
        Me.PeacePanel2.Size = New System.Drawing.Size(495, 61)
        Me.PeacePanel2.TabIndex = 7
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_close.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_close.Location = New System.Drawing.Point(377, 5)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(113, 52)
        Me.btn_close.TabIndex = 4
        Me.btn_close.Text = "CLOSE(&X)"
        Me.btn_close.UseVisualStyleBackColor = False
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
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_del.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_del.Location = New System.Drawing.Point(4, 4)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(121, 52)
        Me.btn_del.TabIndex = 4
        Me.btn_del.Text = "DELETE(&D)"
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FpSpread1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(495, 349)
        Me.Panel1.TabIndex = 8
        '
        'FpSpread1
        '
        Me.FpSpread1.AccessibleDescription = "FpSpread1, Sheet1, Row 0, Column 0, "
        Me.FpSpread1.AllowUserZoom = False
        Me.FpSpread1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FpSpread1.FocusRenderer = New FarPoint.Win.Spread.CustomFocusIndicatorRenderer(CType(resources.GetObject("FpSpread1.FocusRenderer"), System.Drawing.Bitmap), 1)
        Me.FpSpread1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never
        Me.FpSpread1.Location = New System.Drawing.Point(0, 0)
        Me.FpSpread1.Name = "FpSpread1"
        Me.FpSpread1.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.Cells
        Me.FpSpread1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.FpSpread1_Sheet1})
        Me.FpSpread1.Size = New System.Drawing.Size(495, 349)
        Me.FpSpread1.TabIndex = 0
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
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "SUN"
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "MON"
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "TUE"
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "WED"
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "THU"
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "FRI"
        Me.FpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "SAT"
        Me.FpSpread1_Sheet1.ColumnHeader.Rows.Get(0).Height = 38.0!
        Me.FpSpread1_Sheet1.Columns.Get(0).Label = "SUN"
        Me.FpSpread1_Sheet1.Columns.Get(0).Width = 70.0!
        Me.FpSpread1_Sheet1.Columns.Get(1).Label = "MON"
        Me.FpSpread1_Sheet1.Columns.Get(1).Width = 70.0!
        Me.FpSpread1_Sheet1.Columns.Get(2).Label = "TUE"
        Me.FpSpread1_Sheet1.Columns.Get(2).Width = 70.0!
        Me.FpSpread1_Sheet1.Columns.Get(3).Label = "WED"
        Me.FpSpread1_Sheet1.Columns.Get(3).Width = 70.0!
        Me.FpSpread1_Sheet1.Columns.Get(4).Label = "THU"
        Me.FpSpread1_Sheet1.Columns.Get(4).Width = 70.0!
        Me.FpSpread1_Sheet1.Columns.Get(5).Label = "FRI"
        Me.FpSpread1_Sheet1.Columns.Get(5).Width = 70.0!
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
        'CALENDAR_SINGLE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(495, 482)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PeacePanel2)
        Me.Controls.Add(Me.PeacePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.KeyPreview = True
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "CALENDAR_SINGLE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CALENDAR"
        Me.PeacePanel1.ResumeLayout(False)
        Me.PeacePanel1.PerformLayout()
        Me.PeacePanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.FpSpread1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FpSpread1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_yy As PSMGlobal.PeaceLabel
    Friend WithEvents cmb_year As PSMGlobal.PeaceCombobox
    Friend WithEvents PeaceLabel2 As PSMGlobal.PeaceLabel
    Friend WithEvents cmb_month As PSMGlobal.PeaceCombobox
    Friend WithEvents btn_back As PSMGlobal.PeaceButton
    Friend WithEvents btn_next As PSMGlobal.PeaceButton
    Friend WithEvents PeacePanel1 As PSMGlobal.PeacePanel
    Friend WithEvents PeacePanel2 As PSMGlobal.PeacePanel
    Friend WithEvents btn_close As PSMGlobal.PeaceButton
    Friend WithEvents btn_ok As PSMGlobal.PeaceButton
    Friend WithEvents btn_del As PSMGlobal.PeaceButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FpSpread1 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents FpSpread1_Sheet1 As FarPoint.Win.Spread.SheetView
End Class
