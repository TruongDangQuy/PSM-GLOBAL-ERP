<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PFP80004
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PFP80004))
        Dim vSPrint_InputMapWhenFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim vSPrint_InputMapWhenAncestorOfFocusedNormal As FarPoint.Win.Spread.InputMap
        Me.PeaceButton1 = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Prt = New PSMGlobal.PeaceButton(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.chk_FSEL = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.cmd_SEARCH = New PSMGlobal.PeaceButton(Me.components)
        Me.txt_SDATE = New PSMGlobal.SelectPeaceCalSinUP()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.chk_Sp = New System.Windows.Forms.CheckBox()
        Me.PeaceLabel13 = New PSMGlobal.PeaceLabel(Me.components)
        Me.chk_Size = New System.Windows.Forms.NumericUpDown()
        Me.cmd_Back = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Next = New PSMGlobal.PeaceButton(Me.components)
        Me.PeaceLabel1 = New PSMGlobal.PeaceLabel(Me.components)
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.PeaceLabel2 = New PSMGlobal.PeaceLabel(Me.components)
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.PeaceLabel3 = New PSMGlobal.PeaceLabel(Me.components)
        Me.cmb_Kind = New PSMGlobal.PeaceCombobox(Me.components)
        Me.PeaceLabel4 = New PSMGlobal.PeaceLabel(Me.components)
        Me.cmb_Layout = New PSMGlobal.PeaceCombobox(Me.components)
        Me.PeaceLabel5 = New PSMGlobal.PeaceLabel(Me.components)
        Me.cmb_Margin = New PSMGlobal.PeaceCombobox(Me.components)
        Me.PeaceLabel6 = New PSMGlobal.PeaceLabel(Me.components)
        Me.txt_Left = New System.Windows.Forms.NumericUpDown()
        Me.PeaceLabel7 = New PSMGlobal.PeaceLabel(Me.components)
        Me.txt_Right = New System.Windows.Forms.NumericUpDown()
        Me.PeaceLabel8 = New PSMGlobal.PeaceLabel(Me.components)
        Me.txt_Top = New System.Windows.Forms.NumericUpDown()
        Me.PeaceLabel9 = New PSMGlobal.PeaceLabel(Me.components)
        Me.txt_Buttom = New System.Windows.Forms.NumericUpDown()
        Me.PeaceLabel10 = New PSMGlobal.PeaceLabel(Me.components)
        Me.txt_Header = New System.Windows.Forms.NumericUpDown()
        Me.PeaceLabel11 = New PSMGlobal.PeaceLabel(Me.components)
        Me.txt_Footer = New System.Windows.Forms.NumericUpDown()
        Me.cmd_Enable = New PSMGlobal.PeaceButton(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.vSPrint = New PSMGlobal.PeaceFarpoint()
        Me.vSPrint_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.PageSetup = New System.Windows.Forms.PageSetupDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        vSPrint_InputMapWhenFocusedNormal = New FarPoint.Win.Spread.InputMap()
        vSPrint_InputMapWhenAncestorOfFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.chk_Size, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Right, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Top, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Buttom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Header, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Footer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        CType(Me.vSPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vSPrint_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PeaceButton1
        '
        Me.PeaceButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PeaceButton1.Appearance.Options.UseFont = True
        Me.PeaceButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PeaceButton1.ButtonTitle = Nothing
        Me.PeaceButton1.Code = Nothing
        Me.PeaceButton1.Data = Nothing
        Me.PeaceButton1.Image = Global.PSMGlobal.My.Resources.Resources.printer
        Me.PeaceButton1.ImageAlign = 0
        Me.PeaceButton1.Location = New System.Drawing.Point(1, 210)
        Me.PeaceButton1.Margin = New System.Windows.Forms.Padding(1)
        Me.PeaceButton1.Name = "PeaceButton1"
        Me.PeaceButton1.Size = New System.Drawing.Size(95, 65)
        Me.PeaceButton1.TabIndex = 44
        Me.PeaceButton1.TabStop = False
        Me.PeaceButton1.Text = "Save Excel(&F)"
        Me.PeaceButton1.UseVisualStyleBackColor = False
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.ButtonTitle = Nothing
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.Image = CType(resources.GetObject("cmd_Cancel.Image"), System.Drawing.Image)
        Me.cmd_Cancel.ImageAlign = 0
        Me.cmd_Cancel.Location = New System.Drawing.Point(1, 344)
        Me.cmd_Cancel.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(95, 65)
        Me.cmd_Cancel.TabIndex = 39
        Me.cmd_Cancel.TabStop = False
        Me.cmd_Cancel.Text = "Close(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'cmd_Prt
        '
        Me.cmd_Prt.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmd_Prt.Appearance.Options.UseFont = True
        Me.cmd_Prt.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Prt.ButtonTitle = Nothing
        Me.cmd_Prt.Code = Nothing
        Me.cmd_Prt.Data = Nothing
        Me.cmd_Prt.Image = Global.PSMGlobal.My.Resources.Resources.printer
        Me.cmd_Prt.ImageAlign = 0
        Me.cmd_Prt.Location = New System.Drawing.Point(1, 277)
        Me.cmd_Prt.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_Prt.Name = "cmd_Prt"
        Me.cmd_Prt.Size = New System.Drawing.Size(95, 65)
        Me.cmd_Prt.TabIndex = 43
        Me.cmd_Prt.TabStop = False
        Me.cmd_Prt.Text = "Print Excel(&P)"
        Me.cmd_Prt.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.StatusStrip1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.StatusStrip2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.vSPrint, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1133, 996)
        Me.TableLayoutPanel1.TabIndex = 44
        '
        'Panel2
        '
        Me.Panel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Panel2.ColumnCount = 4
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 329.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Panel2.Controls.Add(Me.chk_FSEL, 0, 0)
        Me.Panel2.Controls.Add(Me.cmd_SEARCH, 3, 0)
        Me.Panel2.Controls.Add(Me.txt_SDATE, 1, 0)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(105, 24)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RowCount = 1
        Me.Panel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel2.Size = New System.Drawing.Size(1026, 30)
        Me.Panel2.TabIndex = 49
        '
        'chk_FSEL
        '
        Me.chk_FSEL.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.chk_FSEL.ButtonTitle = Nothing
        Me.chk_FSEL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chk_FSEL.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chk_FSEL.ForeColor = System.Drawing.Color.Black
        Me.chk_FSEL.Location = New System.Drawing.Point(2, 2)
        Me.chk_FSEL.Margin = New System.Windows.Forms.Padding(1)
        Me.chk_FSEL.Name = "chk_FSEL"
        Me.chk_FSEL.Size = New System.Drawing.Size(123, 26)
        Me.chk_FSEL.TabIndex = 17
        Me.chk_FSEL.Text = "Open"
        Me.chk_FSEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk_FSEL.UseVisualStyleBackColor = False
        '
        'cmd_SEARCH
        '
        Me.cmd_SEARCH.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
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
        Me.cmd_SEARCH.Location = New System.Drawing.Point(882, 2)
        Me.cmd_SEARCH.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_SEARCH.Name = "cmd_SEARCH"
        Me.cmd_SEARCH.Size = New System.Drawing.Size(142, 26)
        Me.cmd_SEARCH.TabIndex = 115
        Me.cmd_SEARCH.Text = "   Search(&S)"
        Me.cmd_SEARCH.UseVisualStyleBackColor = False
        '
        'txt_SDATE
        '
        Me.txt_SDATE.ButtonEnabled = True
        Me.txt_SDATE.ButtonFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_SDATE.ButtonName = Nothing
        Me.txt_SDATE.ButtonTitle = "Report Date"
        Me.txt_SDATE.Code = Nothing
        Me.txt_SDATE.Data = ""
        Me.txt_SDATE.DataDecimal = 0
        Me.txt_SDATE.DataLen = 0
        Me.txt_SDATE.DataValue = 0
        Me.txt_SDATE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_SDATE.Layoutpercent = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txt_SDATE.Location = New System.Drawing.Point(127, 1)
        Me.txt_SDATE.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_SDATE.Name = "txt_SDATE"
        Me.txt_SDATE.Size = New System.Drawing.Size(329, 28)
        Me.txt_SDATE.TabIndex = 116
        Me.txt_SDATE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_SDATE.TextBoxFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_SDATE.TextEnabled = True
        Me.txt_SDATE.TextForeColor = System.Drawing.Color.Empty
        Me.txt_SDATE.TextMaxLength = 32767
        Me.txt_SDATE.TextMultiLine = True
        Me.txt_SDATE.TextStyle = System.Windows.Forms.BorderStyle.Fixed3D
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.FlowLayoutPanel1.Controls.Add(Me.chk_Sp)
        Me.FlowLayoutPanel1.Controls.Add(Me.PeaceLabel13)
        Me.FlowLayoutPanel1.Controls.Add(Me.chk_Size)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmd_Back)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmd_Next)
        Me.FlowLayoutPanel1.Controls.Add(Me.PeaceButton1)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmd_Prt)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmd_Cancel)
        Me.FlowLayoutPanel1.Controls.Add(Me.PeaceLabel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.NumericUpDown1)
        Me.FlowLayoutPanel1.Controls.Add(Me.PeaceLabel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.NumericUpDown2)
        Me.FlowLayoutPanel1.Controls.Add(Me.PeaceLabel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmb_Kind)
        Me.FlowLayoutPanel1.Controls.Add(Me.PeaceLabel4)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmb_Layout)
        Me.FlowLayoutPanel1.Controls.Add(Me.PeaceLabel5)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmb_Margin)
        Me.FlowLayoutPanel1.Controls.Add(Me.PeaceLabel6)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Left)
        Me.FlowLayoutPanel1.Controls.Add(Me.PeaceLabel7)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Right)
        Me.FlowLayoutPanel1.Controls.Add(Me.PeaceLabel8)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Top)
        Me.FlowLayoutPanel1.Controls.Add(Me.PeaceLabel9)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Buttom)
        Me.FlowLayoutPanel1.Controls.Add(Me.PeaceLabel10)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Header)
        Me.FlowLayoutPanel1.Controls.Add(Me.PeaceLabel11)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Footer)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmd_Enable)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 59)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(97, 912)
        Me.FlowLayoutPanel1.TabIndex = 44
        '
        'chk_Sp
        '
        Me.chk_Sp.AutoSize = True
        Me.chk_Sp.Checked = True
        Me.chk_Sp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Sp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chk_Sp.Location = New System.Drawing.Point(3, 3)
        Me.chk_Sp.Name = "chk_Sp"
        Me.chk_Sp.Size = New System.Drawing.Size(82, 19)
        Me.chk_Sp.TabIndex = 71
        Me.chk_Sp.Text = "SmartPrint"
        Me.chk_Sp.UseVisualStyleBackColor = True
        '
        'PeaceLabel13
        '
        Me.PeaceLabel13.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PeaceLabel13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel13.ButtonTitle = Nothing
        Me.PeaceLabel13.Code = ""
        Me.PeaceLabel13.Data = ""
        Me.PeaceLabel13.DTDec = 0
        Me.PeaceLabel13.DTLen = 0
        Me.PeaceLabel13.DTValue = 0
        Me.PeaceLabel13.Location = New System.Drawing.Point(3, 28)
        Me.PeaceLabel13.Name = "PeaceLabel13"
        Me.PeaceLabel13.NoClear = False
        Me.PeaceLabel13.Size = New System.Drawing.Size(65535, 15)
        Me.PeaceLabel13.TabIndex = 69
        Me.PeaceLabel13.Tag = ""
        Me.PeaceLabel13.Text = "Zoom Factor"
        Me.PeaceLabel13.TextAlign = DevExpress.Utils.HorzAlignment.[Default]
        '
        'chk_Size
        '
        Me.chk_Size.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Size.Location = New System.Drawing.Point(3, 49)
        Me.chk_Size.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.chk_Size.Name = "chk_Size"
        Me.chk_Size.Size = New System.Drawing.Size(92, 23)
        Me.chk_Size.TabIndex = 67
        Me.chk_Size.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'cmd_Back
        '
        Me.cmd_Back.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmd_Back.Appearance.Options.UseFont = True
        Me.cmd_Back.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Back.ButtonTitle = Nothing
        Me.cmd_Back.Code = Nothing
        Me.cmd_Back.Data = Nothing
        Me.cmd_Back.ImageAlign = 0
        Me.cmd_Back.Location = New System.Drawing.Point(1, 76)
        Me.cmd_Back.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_Back.Name = "cmd_Back"
        Me.cmd_Back.Size = New System.Drawing.Size(95, 65)
        Me.cmd_Back.TabIndex = 0
        Me.cmd_Back.TabStop = False
        Me.cmd_Back.Text = "Previous  <<"
        Me.cmd_Back.UseVisualStyleBackColor = False
        '
        'cmd_Next
        '
        Me.cmd_Next.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmd_Next.Appearance.Options.UseFont = True
        Me.cmd_Next.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Next.ButtonTitle = Nothing
        Me.cmd_Next.Code = Nothing
        Me.cmd_Next.Data = Nothing
        Me.cmd_Next.ImageAlign = 0
        Me.cmd_Next.Location = New System.Drawing.Point(1, 143)
        Me.cmd_Next.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_Next.Name = "cmd_Next"
        Me.cmd_Next.Size = New System.Drawing.Size(95, 65)
        Me.cmd_Next.TabIndex = 1
        Me.cmd_Next.TabStop = False
        Me.cmd_Next.Text = "Next >>"
        Me.cmd_Next.UseVisualStyleBackColor = False
        '
        'PeaceLabel1
        '
        Me.PeaceLabel1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PeaceLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel1.ButtonTitle = Nothing
        Me.PeaceLabel1.Code = ""
        Me.PeaceLabel1.Data = ""
        Me.PeaceLabel1.DTDec = 0
        Me.PeaceLabel1.DTLen = 0
        Me.PeaceLabel1.DTValue = 0
        Me.PeaceLabel1.Location = New System.Drawing.Point(3, 413)
        Me.PeaceLabel1.Name = "PeaceLabel1"
        Me.PeaceLabel1.NoClear = False
        Me.PeaceLabel1.Size = New System.Drawing.Size(91, 15)
        Me.PeaceLabel1.TabIndex = 45
        Me.PeaceLabel1.Tag = ""
        Me.PeaceLabel1.Text = "Pages"
        Me.PeaceLabel1.TextAlign = DevExpress.Utils.HorzAlignment.[Default]
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(3, 434)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(92, 23)
        Me.NumericUpDown1.TabIndex = 46
        '
        'PeaceLabel2
        '
        Me.PeaceLabel2.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PeaceLabel2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel2.ButtonTitle = Nothing
        Me.PeaceLabel2.Code = ""
        Me.PeaceLabel2.Data = ""
        Me.PeaceLabel2.DTDec = 0
        Me.PeaceLabel2.DTLen = 0
        Me.PeaceLabel2.DTValue = 0
        Me.PeaceLabel2.Location = New System.Drawing.Point(3, 463)
        Me.PeaceLabel2.Name = "PeaceLabel2"
        Me.PeaceLabel2.NoClear = False
        Me.PeaceLabel2.Size = New System.Drawing.Size(65535, 15)
        Me.PeaceLabel2.TabIndex = 47
        Me.PeaceLabel2.Tag = ""
        Me.PeaceLabel2.Text = "To"
        Me.PeaceLabel2.TextAlign = DevExpress.Utils.HorzAlignment.[Default]
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown2.Location = New System.Drawing.Point(3, 484)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(92, 23)
        Me.NumericUpDown2.TabIndex = 48
        '
        'PeaceLabel3
        '
        Me.PeaceLabel3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PeaceLabel3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel3.ButtonTitle = Nothing
        Me.PeaceLabel3.Code = ""
        Me.PeaceLabel3.Data = ""
        Me.PeaceLabel3.DTDec = 0
        Me.PeaceLabel3.DTLen = 0
        Me.PeaceLabel3.DTValue = 0
        Me.PeaceLabel3.Location = New System.Drawing.Point(3, 513)
        Me.PeaceLabel3.Name = "PeaceLabel3"
        Me.PeaceLabel3.NoClear = False
        Me.PeaceLabel3.Size = New System.Drawing.Size(91, 15)
        Me.PeaceLabel3.TabIndex = 49
        Me.PeaceLabel3.Tag = ""
        Me.PeaceLabel3.Text = "Paperkind"
        Me.PeaceLabel3.TextAlign = DevExpress.Utils.HorzAlignment.[Default]
        '
        'cmb_Kind
        '
        Me.cmb_Kind.DTDec = 0
        Me.cmb_Kind.DTLen = 0
        Me.cmb_Kind.DTValue = 0
        Me.cmb_Kind.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Kind.FormattingEnabled = True
        Me.cmb_Kind.InSelected = -1
        Me.cmb_Kind.Items.AddRange(New Object() {"A4(5.83''*8.27'')", "A4(8.27''*11.69'')"})
        Me.cmb_Kind.ListIndex = 0
        Me.cmb_Kind.Location = New System.Drawing.Point(3, 534)
        Me.cmb_Kind.Name = "cmb_Kind"
        Me.cmb_Kind.NoClear = False
        Me.cmb_Kind.Size = New System.Drawing.Size(92, 23)
        Me.cmb_Kind.TabIndex = 50
        '
        'PeaceLabel4
        '
        Me.PeaceLabel4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PeaceLabel4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel4.ButtonTitle = Nothing
        Me.PeaceLabel4.Code = ""
        Me.PeaceLabel4.Data = ""
        Me.PeaceLabel4.DTDec = 0
        Me.PeaceLabel4.DTLen = 0
        Me.PeaceLabel4.DTValue = 0
        Me.PeaceLabel4.Location = New System.Drawing.Point(3, 563)
        Me.PeaceLabel4.Name = "PeaceLabel4"
        Me.PeaceLabel4.NoClear = False
        Me.PeaceLabel4.Size = New System.Drawing.Size(65535, 15)
        Me.PeaceLabel4.TabIndex = 52
        Me.PeaceLabel4.Tag = ""
        Me.PeaceLabel4.Text = "PaperLayout"
        Me.PeaceLabel4.TextAlign = DevExpress.Utils.HorzAlignment.[Default]
        '
        'cmb_Layout
        '
        Me.cmb_Layout.DTDec = 0
        Me.cmb_Layout.DTLen = 0
        Me.cmb_Layout.DTValue = 0
        Me.cmb_Layout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Layout.FormattingEnabled = True
        Me.cmb_Layout.InSelected = -1
        Me.cmb_Layout.Items.AddRange(New Object() {"Portrait", "Landscape"})
        Me.cmb_Layout.ListIndex = 0
        Me.cmb_Layout.Location = New System.Drawing.Point(3, 584)
        Me.cmb_Layout.Name = "cmb_Layout"
        Me.cmb_Layout.NoClear = False
        Me.cmb_Layout.Size = New System.Drawing.Size(92, 23)
        Me.cmb_Layout.TabIndex = 51
        '
        'PeaceLabel5
        '
        Me.PeaceLabel5.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PeaceLabel5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel5.ButtonTitle = Nothing
        Me.PeaceLabel5.Code = ""
        Me.PeaceLabel5.Data = ""
        Me.PeaceLabel5.DTDec = 0
        Me.PeaceLabel5.DTLen = 0
        Me.PeaceLabel5.DTValue = 0
        Me.PeaceLabel5.Location = New System.Drawing.Point(3, 613)
        Me.PeaceLabel5.Name = "PeaceLabel5"
        Me.PeaceLabel5.NoClear = False
        Me.PeaceLabel5.Size = New System.Drawing.Size(91, 15)
        Me.PeaceLabel5.TabIndex = 54
        Me.PeaceLabel5.Tag = ""
        Me.PeaceLabel5.Text = "Margin"
        Me.PeaceLabel5.TextAlign = DevExpress.Utils.HorzAlignment.[Default]
        '
        'cmb_Margin
        '
        Me.cmb_Margin.DTDec = 0
        Me.cmb_Margin.DTLen = 0
        Me.cmb_Margin.DTValue = 0
        Me.cmb_Margin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Margin.FormattingEnabled = True
        Me.cmb_Margin.InSelected = -1
        Me.cmb_Margin.Items.AddRange(New Object() {"Normal Margin", "Wide Margin", "Narrow Margin", "Customer Margin"})
        Me.cmb_Margin.ListIndex = 0
        Me.cmb_Margin.Location = New System.Drawing.Point(3, 634)
        Me.cmb_Margin.Name = "cmb_Margin"
        Me.cmb_Margin.NoClear = False
        Me.cmb_Margin.Size = New System.Drawing.Size(92, 23)
        Me.cmb_Margin.TabIndex = 53
        '
        'PeaceLabel6
        '
        Me.PeaceLabel6.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PeaceLabel6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel6.ButtonTitle = Nothing
        Me.PeaceLabel6.Code = ""
        Me.PeaceLabel6.Data = ""
        Me.PeaceLabel6.DTDec = 0
        Me.PeaceLabel6.DTLen = 0
        Me.PeaceLabel6.DTValue = 0
        Me.PeaceLabel6.Location = New System.Drawing.Point(3, 663)
        Me.PeaceLabel6.Name = "PeaceLabel6"
        Me.PeaceLabel6.NoClear = False
        Me.PeaceLabel6.Size = New System.Drawing.Size(65535, 15)
        Me.PeaceLabel6.TabIndex = 55
        Me.PeaceLabel6.Tag = ""
        Me.PeaceLabel6.Text = "Left"
        Me.PeaceLabel6.TextAlign = DevExpress.Utils.HorzAlignment.[Default]
        '
        'txt_Left
        '
        Me.txt_Left.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_Left.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Left.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txt_Left.Location = New System.Drawing.Point(3, 684)
        Me.txt_Left.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txt_Left.Name = "txt_Left"
        Me.txt_Left.Size = New System.Drawing.Size(92, 23)
        Me.txt_Left.TabIndex = 56
        Me.txt_Left.ThousandsSeparator = True
        Me.txt_Left.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'PeaceLabel7
        '
        Me.PeaceLabel7.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PeaceLabel7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel7.ButtonTitle = Nothing
        Me.PeaceLabel7.Code = ""
        Me.PeaceLabel7.Data = ""
        Me.PeaceLabel7.DTDec = 0
        Me.PeaceLabel7.DTLen = 0
        Me.PeaceLabel7.DTValue = 0
        Me.PeaceLabel7.Location = New System.Drawing.Point(3, 713)
        Me.PeaceLabel7.Name = "PeaceLabel7"
        Me.PeaceLabel7.NoClear = False
        Me.PeaceLabel7.Size = New System.Drawing.Size(91, 15)
        Me.PeaceLabel7.TabIndex = 57
        Me.PeaceLabel7.Tag = ""
        Me.PeaceLabel7.Text = "Right"
        Me.PeaceLabel7.TextAlign = DevExpress.Utils.HorzAlignment.[Default]
        '
        'txt_Right
        '
        Me.txt_Right.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_Right.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Right.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txt_Right.Location = New System.Drawing.Point(3, 734)
        Me.txt_Right.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txt_Right.Name = "txt_Right"
        Me.txt_Right.Size = New System.Drawing.Size(92, 23)
        Me.txt_Right.TabIndex = 58
        Me.txt_Right.ThousandsSeparator = True
        Me.txt_Right.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'PeaceLabel8
        '
        Me.PeaceLabel8.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PeaceLabel8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel8.ButtonTitle = Nothing
        Me.PeaceLabel8.Code = ""
        Me.PeaceLabel8.Data = ""
        Me.PeaceLabel8.DTDec = 0
        Me.PeaceLabel8.DTLen = 0
        Me.PeaceLabel8.DTValue = 0
        Me.PeaceLabel8.Location = New System.Drawing.Point(3, 763)
        Me.PeaceLabel8.Name = "PeaceLabel8"
        Me.PeaceLabel8.NoClear = False
        Me.PeaceLabel8.Size = New System.Drawing.Size(65535, 15)
        Me.PeaceLabel8.TabIndex = 59
        Me.PeaceLabel8.Tag = ""
        Me.PeaceLabel8.Text = "Top"
        Me.PeaceLabel8.TextAlign = DevExpress.Utils.HorzAlignment.[Default]
        '
        'txt_Top
        '
        Me.txt_Top.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_Top.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Top.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txt_Top.Location = New System.Drawing.Point(3, 784)
        Me.txt_Top.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txt_Top.Name = "txt_Top"
        Me.txt_Top.Size = New System.Drawing.Size(92, 23)
        Me.txt_Top.TabIndex = 60
        Me.txt_Top.ThousandsSeparator = True
        Me.txt_Top.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'PeaceLabel9
        '
        Me.PeaceLabel9.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PeaceLabel9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel9.ButtonTitle = Nothing
        Me.PeaceLabel9.Code = ""
        Me.PeaceLabel9.Data = ""
        Me.PeaceLabel9.DTDec = 0
        Me.PeaceLabel9.DTLen = 0
        Me.PeaceLabel9.DTValue = 0
        Me.PeaceLabel9.Location = New System.Drawing.Point(3, 813)
        Me.PeaceLabel9.Name = "PeaceLabel9"
        Me.PeaceLabel9.NoClear = False
        Me.PeaceLabel9.Size = New System.Drawing.Size(91, 15)
        Me.PeaceLabel9.TabIndex = 61
        Me.PeaceLabel9.Tag = ""
        Me.PeaceLabel9.Text = "Bottom"
        Me.PeaceLabel9.TextAlign = DevExpress.Utils.HorzAlignment.[Default]
        '
        'txt_Buttom
        '
        Me.txt_Buttom.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_Buttom.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Buttom.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txt_Buttom.Location = New System.Drawing.Point(3, 834)
        Me.txt_Buttom.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txt_Buttom.Name = "txt_Buttom"
        Me.txt_Buttom.Size = New System.Drawing.Size(92, 23)
        Me.txt_Buttom.TabIndex = 62
        Me.txt_Buttom.ThousandsSeparator = True
        Me.txt_Buttom.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'PeaceLabel10
        '
        Me.PeaceLabel10.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PeaceLabel10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel10.ButtonTitle = Nothing
        Me.PeaceLabel10.Code = ""
        Me.PeaceLabel10.Data = ""
        Me.PeaceLabel10.DTDec = 0
        Me.PeaceLabel10.DTLen = 0
        Me.PeaceLabel10.DTValue = 0
        Me.PeaceLabel10.Location = New System.Drawing.Point(3, 863)
        Me.PeaceLabel10.Name = "PeaceLabel10"
        Me.PeaceLabel10.NoClear = False
        Me.PeaceLabel10.Size = New System.Drawing.Size(65535, 15)
        Me.PeaceLabel10.TabIndex = 63
        Me.PeaceLabel10.Tag = ""
        Me.PeaceLabel10.Text = "Hearder"
        Me.PeaceLabel10.TextAlign = DevExpress.Utils.HorzAlignment.[Default]
        '
        'txt_Header
        '
        Me.txt_Header.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_Header.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Header.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txt_Header.Location = New System.Drawing.Point(3, 884)
        Me.txt_Header.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txt_Header.Name = "txt_Header"
        Me.txt_Header.Size = New System.Drawing.Size(92, 23)
        Me.txt_Header.TabIndex = 64
        Me.txt_Header.ThousandsSeparator = True
        Me.txt_Header.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'PeaceLabel11
        '
        Me.PeaceLabel11.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PeaceLabel11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel11.ButtonTitle = Nothing
        Me.PeaceLabel11.Code = ""
        Me.PeaceLabel11.Data = ""
        Me.PeaceLabel11.DTDec = 0
        Me.PeaceLabel11.DTLen = 0
        Me.PeaceLabel11.DTValue = 0
        Me.PeaceLabel11.Location = New System.Drawing.Point(3, 913)
        Me.PeaceLabel11.Name = "PeaceLabel11"
        Me.PeaceLabel11.NoClear = False
        Me.PeaceLabel11.Size = New System.Drawing.Size(91, 15)
        Me.PeaceLabel11.TabIndex = 65
        Me.PeaceLabel11.Tag = ""
        Me.PeaceLabel11.Text = "Footer"
        Me.PeaceLabel11.TextAlign = DevExpress.Utils.HorzAlignment.[Default]
        '
        'txt_Footer
        '
        Me.txt_Footer.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_Footer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Footer.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txt_Footer.Location = New System.Drawing.Point(3, 934)
        Me.txt_Footer.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txt_Footer.Name = "txt_Footer"
        Me.txt_Footer.Size = New System.Drawing.Size(92, 23)
        Me.txt_Footer.TabIndex = 66
        Me.txt_Footer.ThousandsSeparator = True
        Me.txt_Footer.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'cmd_Enable
        '
        Me.cmd_Enable.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmd_Enable.Appearance.Options.UseFont = True
        Me.cmd_Enable.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Enable.ButtonTitle = Nothing
        Me.cmd_Enable.Code = Nothing
        Me.cmd_Enable.Data = Nothing
        Me.cmd_Enable.ImageAlign = 0
        Me.cmd_Enable.Location = New System.Drawing.Point(1, 961)
        Me.cmd_Enable.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_Enable.Name = "cmd_Enable"
        Me.cmd_Enable.Size = New System.Drawing.Size(95, 32)
        Me.cmd_Enable.TabIndex = 72
        Me.cmd_Enable.TabStop = False
        Me.cmd_Enable.Text = "Sheet Enable"
        Me.cmd_Enable.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.StatusStrip1, 2)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 974)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 12, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1133, 22)
        Me.StatusStrip1.TabIndex = 46
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(705, 17)
        Me.ToolStripStatusLabel1.Text = "Here is the Peace Print Form.  Please adjust some conditions to make your print r" & _
    "eport clearly and properly. Thank for your attention!"
        '
        'StatusStrip2
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.StatusStrip2, 2)
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Padding = New System.Windows.Forms.Padding(1, 0, 12, 0)
        Me.StatusStrip2.Size = New System.Drawing.Size(1133, 22)
        Me.StatusStrip2.TabIndex = 47
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(73, 17)
        Me.ToolStripStatusLabel2.Text = "Report Print "
        Me.ToolStripStatusLabel2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'vSPrint
        '
        Me.vSPrint.AccessibleDescription = ""
        Me.vSPrint.AutoClipboard = False
        Me.vSPrint.CopyPasteChk = False
        Me.vSPrint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vSPrint.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vSPrint.InsChk = False
        Me.vSPrint.Location = New System.Drawing.Point(106, 59)
        Me.vSPrint.Name = "vSPrint"
        Me.vSPrint.ReportName = Nothing
        Me.vSPrint.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.vSPrint_Sheet1})
        Me.vSPrint.Size = New System.Drawing.Size(1024, 912)
        Me.vSPrint.SpreadWjob = 0
        Me.vSPrint.TabIndex = 45
        Me.vSPrint.TabStop = False
        vSPrint_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Me.vSPrint.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.Normal, vSPrint_InputMapWhenFocusedNormal)
        vSPrint_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Me.vSPrint.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused, FarPoint.Win.Spread.OperationMode.Normal, vSPrint_InputMapWhenAncestorOfFocusedNormal)
        '
        'vSPrint_Sheet1
        '
        Me.vSPrint_Sheet1.Reset()
        Me.vSPrint_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.vSPrint_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.vSPrint_Sheet1.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vSPrint_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vSPrint_Sheet1.DefaultStyle.Parent = "DataAreaDefault"
        Me.vSPrint_Sheet1.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.vSPrint_Sheet1.Rows.Default.Height = 22.0!
        Me.vSPrint_Sheet1.SelectionBackColor = System.Drawing.Color.Aquamarine
        Me.vSPrint_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'PFP80004
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1133, 996)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.KeyPreview = True
        Me.Name = "PFP80004"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peace Print Preview (ISUD PRINT PFP80004)"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.chk_Size, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Right, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Top, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Buttom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Header, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Footer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        CType(Me.vSPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vSPrint_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_Prt As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PeaceButton1 As PSMGlobal.PeaceButton
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cmd_Back As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Next As PSMGlobal.PeaceButton
    Friend WithEvents PeaceLabel1 As PSMGlobal.PeaceLabel
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents PeaceLabel2 As PSMGlobal.PeaceLabel
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents PeaceLabel3 As PSMGlobal.PeaceLabel
    Friend WithEvents cmb_Kind As PSMGlobal.PeaceCombobox
    Friend WithEvents PeaceLabel4 As PSMGlobal.PeaceLabel
    Friend WithEvents cmb_Layout As PSMGlobal.PeaceCombobox
    Friend WithEvents PeaceLabel5 As PSMGlobal.PeaceLabel
    Friend WithEvents cmb_Margin As PSMGlobal.PeaceCombobox
    Friend WithEvents PageSetup As System.Windows.Forms.PageSetupDialog
    Friend WithEvents PeaceLabel6 As PSMGlobal.PeaceLabel
    Friend WithEvents txt_Left As System.Windows.Forms.NumericUpDown
    Friend WithEvents PeaceLabel7 As PSMGlobal.PeaceLabel
    Friend WithEvents txt_Right As System.Windows.Forms.NumericUpDown
    Friend WithEvents PeaceLabel8 As PSMGlobal.PeaceLabel
    Friend WithEvents txt_Top As System.Windows.Forms.NumericUpDown
    Friend WithEvents PeaceLabel9 As PSMGlobal.PeaceLabel
    Friend WithEvents txt_Buttom As System.Windows.Forms.NumericUpDown
    Friend WithEvents PeaceLabel10 As PSMGlobal.PeaceLabel
    Friend WithEvents txt_Header As System.Windows.Forms.NumericUpDown
    Friend WithEvents PeaceLabel11 As PSMGlobal.PeaceLabel
    Friend WithEvents txt_Footer As System.Windows.Forms.NumericUpDown
    Friend WithEvents PeaceLabel13 As PSMGlobal.PeaceLabel
    Friend WithEvents chk_Size As System.Windows.Forms.NumericUpDown
    Friend WithEvents vSPrint As PSMGlobal.PeaceFarpoint
    Friend WithEvents vSPrint_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents chk_Sp As System.Windows.Forms.CheckBox
    Friend WithEvents cmd_Enable As PSMGlobal.PeaceButton
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Public WithEvents Panel2 As System.Windows.Forms.TableLayoutPanel
    Public WithEvents chk_FSEL As PSMGlobal.PeaceCheckbox
    Public WithEvents cmd_SEARCH As PSMGlobal.PeaceButton
    Friend WithEvents txt_SDATE As PSMGlobal.SelectPeaceCalSinUP
End Class
