<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD4073H
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD4073H))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.frm_Condition = New PSMGlobal.PeacePanel(Me.components)
        Me.Block1 = New PSMGlobal.PeacePanel(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PeacePanel2 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_MachineName = New PSMGlobal.SelectLabelText()
        Me.txt_DatePlan = New PSMGlobal.SelectPeaceCalSin()
        Me.txt_ProcessSeq = New PSMGlobal.SelectLabelText()
        Me.txt_LineTno = New PSMGlobal.SelectLabelText()
        Me.txt_cdLineProd = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_InchargePlan = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdMainProcess = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdFactory = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_Barcode = New PSMGlobal.SelectLabelText()
        Me.Frame4 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_DEL = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.PeacePanel3 = New PSMGlobal.PeacePanel(Me.components)
        Me.chk_CheckComplete3 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.chk_CheckComplete4 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.chk_CheckComplete5 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.chk_CheckComplete6 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.chk_CheckComplete1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.chk_CheckComplete2 = New PSMGlobal.PeaceRadioButton(Me.components)
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frm_Condition.SuspendLayout()
        CType(Me.Block1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Block1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PeacePanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel2.SuspendLayout()
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame4.SuspendLayout()
        CType(Me.PeacePanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'frm_Condition
        '
        Me.frm_Condition.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.frm_Condition.Code = ""
        Me.frm_Condition.Controls.Add(Me.Block1)
        Me.frm_Condition.Data = ""
        Me.frm_Condition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frm_Condition.Location = New System.Drawing.Point(0, 0)
        Me.frm_Condition.Name = "frm_Condition"
        Me.frm_Condition.Size = New System.Drawing.Size(789, 257)
        Me.frm_Condition.TabIndex = 3
        Me.frm_Condition.Tag = ""
        '
        'Block1
        '
        Me.Block1.Code = ""
        Me.Block1.Controls.Add(Me.TableLayoutPanel1)
        Me.Block1.Data = ""
        Me.Block1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Block1.Location = New System.Drawing.Point(2, 2)
        Me.Block1.Margin = New System.Windows.Forms.Padding(0)
        Me.Block1.Name = "Block1"
        Me.Block1.Size = New System.Drawing.Size(785, 253)
        Me.Block1.TabIndex = 2
        Me.Block1.Tag = ""
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PeacePanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Frame4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PeacePanel3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(781, 249)
        Me.TableLayoutPanel1.TabIndex = 159
        '
        'PeacePanel2
        '
        Me.PeacePanel2.Code = ""
        Me.PeacePanel2.Controls.Add(Me.txt_MachineName)
        Me.PeacePanel2.Controls.Add(Me.txt_DatePlan)
        Me.PeacePanel2.Controls.Add(Me.txt_ProcessSeq)
        Me.PeacePanel2.Controls.Add(Me.txt_LineTno)
        Me.PeacePanel2.Controls.Add(Me.txt_cdLineProd)
        Me.PeacePanel2.Controls.Add(Me.txt_InchargePlan)
        Me.PeacePanel2.Controls.Add(Me.txt_cdMainProcess)
        Me.PeacePanel2.Controls.Add(Me.txt_cdFactory)
        Me.PeacePanel2.Controls.Add(Me.txt_Barcode)
        Me.PeacePanel2.Data = ""
        Me.PeacePanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeacePanel2.Enabled = False
        Me.PeacePanel2.Location = New System.Drawing.Point(3, 3)
        Me.PeacePanel2.Name = "PeacePanel2"
        Me.PeacePanel2.Size = New System.Drawing.Size(775, 144)
        Me.PeacePanel2.TabIndex = 141
        Me.PeacePanel2.Tag = ""
        '
        'txt_MachineName
        '
        Me.txt_MachineName.BackYesno = False
        Me.txt_MachineName.ButtonTitle = Nothing
        Me.txt_MachineName.Code = Nothing
        Me.txt_MachineName.Data = ""
        Me.txt_MachineName.DataDecimal = 1
        Me.txt_MachineName.DataLen = 0
        Me.txt_MachineName.DataValue = 0
        Me.txt_MachineName.FormatDecimal = 0
        Me.txt_MachineName.FormatValue = False
        Me.txt_MachineName.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_MachineName.LableEnabled = True
        Me.txt_MachineName.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MachineName.LableForeColor = System.Drawing.Color.Empty
        Me.txt_MachineName.LableTitle = "Date Prepared"
        Me.txt_MachineName.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_MachineName.Location = New System.Drawing.Point(289, 57)
        Me.txt_MachineName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MachineName.Name = "txt_MachineName"
        Me.txt_MachineName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MachineName.Size = New System.Drawing.Size(196, 24)
        Me.txt_MachineName.TabIndex = 155
        Me.txt_MachineName.TabStop = False
        Me.txt_MachineName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_MachineName.TextBoxAutoComplete = True
        Me.txt_MachineName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MachineName.TextBoxFont = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txt_MachineName.TextEnabled = False
        Me.txt_MachineName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MachineName.TextMaxLength = 32767
        Me.txt_MachineName.TextMultiLine = False
        Me.txt_MachineName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MachineName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MachineName.UseSendTab = True
        '
        'txt_DatePlan
        '
        Me.txt_DatePlan.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_DatePlan.ButtonEnabled = True
        Me.txt_DatePlan.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_DatePlan.ButtonName = Nothing
        Me.txt_DatePlan.ButtonTitle = "Plan Date"
        Me.txt_DatePlan.Code = ""
        Me.txt_DatePlan.Data = "20150101"
        Me.txt_DatePlan.DataDecimal = 1
        Me.txt_DatePlan.DataLen = 0
        Me.txt_DatePlan.DataValue = 0
        Me.txt_DatePlan.FormatDecimal = 0
        Me.txt_DatePlan.FormatValue = False
        Me.txt_DatePlan.Layoutpercent = New Decimal(New Integer() {42, 0, 0, 131072})
        Me.txt_DatePlan.Location = New System.Drawing.Point(289, 5)
        Me.txt_DatePlan.Margin = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.txt_DatePlan.Name = "txt_DatePlan"
        Me.txt_DatePlan.Size = New System.Drawing.Size(280, 24)
        Me.txt_DatePlan.TabIndex = 156
        Me.txt_DatePlan.TabStop = False
        Me.txt_DatePlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_DatePlan.TextBoxAutoComplete = False
        Me.txt_DatePlan.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DatePlan.TextEnabled = True
        Me.txt_DatePlan.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DatePlan.TextMaxLength = 32767
        Me.txt_DatePlan.TextMultiLine = True
        Me.txt_DatePlan.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        '
        'txt_ProcessSeq
        '
        Me.txt_ProcessSeq.BackYesno = True
        Me.txt_ProcessSeq.ButtonTitle = Nothing
        Me.txt_ProcessSeq.Code = Nothing
        Me.txt_ProcessSeq.Data = ""
        Me.txt_ProcessSeq.DataDecimal = 0
        Me.txt_ProcessSeq.DataLen = 0
        Me.txt_ProcessSeq.DataValue = 0
        Me.txt_ProcessSeq.Enabled = False
        Me.txt_ProcessSeq.FormatDecimal = 0
        Me.txt_ProcessSeq.FormatValue = False
        Me.txt_ProcessSeq.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ProcessSeq.LableEnabled = True
        Me.txt_ProcessSeq.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ProcessSeq.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ProcessSeq.LableTitle = "B/T NO"
        Me.txt_ProcessSeq.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_ProcessSeq.Location = New System.Drawing.Point(423, 87)
        Me.txt_ProcessSeq.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ProcessSeq.Name = "txt_ProcessSeq"
        Me.txt_ProcessSeq.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ProcessSeq.Size = New System.Drawing.Size(145, 51)
        Me.txt_ProcessSeq.TabIndex = 131
        Me.txt_ProcessSeq.TabStop = False
        Me.txt_ProcessSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_ProcessSeq.TextBoxAutoComplete = False
        Me.txt_ProcessSeq.TextboxBackColor = System.Drawing.SystemColors.Control
        Me.txt_ProcessSeq.TextBoxFont = New System.Drawing.Font("Tahoma", 24.0!)
        Me.txt_ProcessSeq.TextEnabled = True
        Me.txt_ProcessSeq.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ProcessSeq.TextMaxLength = 32767
        Me.txt_ProcessSeq.TextMultiLine = False
        Me.txt_ProcessSeq.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ProcessSeq.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ProcessSeq.UseSendTab = True
        '
        'txt_LineTno
        '
        Me.txt_LineTno.BackYesno = False
        Me.txt_LineTno.ButtonTitle = Nothing
        Me.txt_LineTno.Code = Nothing
        Me.txt_LineTno.Data = ""
        Me.txt_LineTno.DataDecimal = 1
        Me.txt_LineTno.DataLen = 0
        Me.txt_LineTno.DataValue = 0
        Me.txt_LineTno.FormatDecimal = 0
        Me.txt_LineTno.FormatValue = False
        Me.txt_LineTno.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_LineTno.LableEnabled = True
        Me.txt_LineTno.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_LineTno.LableForeColor = System.Drawing.Color.Empty
        Me.txt_LineTno.LableTitle = "Date Prepared"
        Me.txt_LineTno.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_LineTno.Location = New System.Drawing.Point(487, 56)
        Me.txt_LineTno.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_LineTno.Name = "txt_LineTno"
        Me.txt_LineTno.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_LineTno.Size = New System.Drawing.Size(81, 26)
        Me.txt_LineTno.TabIndex = 155
        Me.txt_LineTno.TabStop = False
        Me.txt_LineTno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_LineTno.TextBoxAutoComplete = True
        Me.txt_LineTno.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_LineTno.TextBoxFont = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txt_LineTno.TextEnabled = False
        Me.txt_LineTno.TextForeColor = System.Drawing.Color.Empty
        Me.txt_LineTno.TextMaxLength = 32767
        Me.txt_LineTno.TextMultiLine = False
        Me.txt_LineTno.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_LineTno.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_LineTno.UseSendTab = True
        '
        'txt_cdLineProd
        '
        Me.txt_cdLineProd.BackYesno = False
        Me.txt_cdLineProd.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdLineProd.ButtonEnabled = True
        Me.txt_cdLineProd.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdLineProd.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd.ButtonName = ""
        Me.txt_cdLineProd.ButtonTitle = "Line Prod"
        Me.txt_cdLineProd.Code = ""
        Me.txt_cdLineProd.Data = ""
        Me.txt_cdLineProd.DataDecimal = 1
        Me.txt_cdLineProd.DataLen = 0
        Me.txt_cdLineProd.DataValue = 1
        Me.txt_cdLineProd.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_cdLineProd.Location = New System.Drawing.Point(5, 58)
        Me.txt_cdLineProd.Margin = New System.Windows.Forms.Padding(1, 1, 171, 1)
        Me.txt_cdLineProd.Name = "txt_cdLineProd"
        Me.txt_cdLineProd.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdLineProd.Size = New System.Drawing.Size(280, 24)
        Me.txt_cdLineProd.TabIndex = 153
        Me.txt_cdLineProd.TabStop = False
        Me.txt_cdLineProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdLineProd.TextBoxAutoComplete = True
        Me.txt_cdLineProd.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_cdLineProd.TextEnabled = False
        Me.txt_cdLineProd.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd.TextMaxLength = 32767
        Me.txt_cdLineProd.TextMultiLine = False
        Me.txt_cdLineProd.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdLineProd.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdLineProd.UseSendTab = True
        '
        'txt_InchargePlan
        '
        Me.txt_InchargePlan.BackYesno = False
        Me.txt_InchargePlan.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_InchargePlan.ButtonEnabled = True
        Me.txt_InchargePlan.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_InchargePlan.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_InchargePlan.ButtonName = "Const_Emp117"
        Me.txt_InchargePlan.ButtonTitle = "Incharge"
        Me.txt_InchargePlan.Code = ""
        Me.txt_InchargePlan.Data = ""
        Me.txt_InchargePlan.DataDecimal = 1
        Me.txt_InchargePlan.DataLen = 0
        Me.txt_InchargePlan.DataValue = 1
        Me.txt_InchargePlan.Layoutpercent = New Decimal(New Integer() {42, 0, 0, 131072})
        Me.txt_InchargePlan.Location = New System.Drawing.Point(289, 31)
        Me.txt_InchargePlan.Margin = New System.Windows.Forms.Padding(1, 1, 171, 1)
        Me.txt_InchargePlan.Name = "txt_InchargePlan"
        Me.txt_InchargePlan.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_InchargePlan.Size = New System.Drawing.Size(280, 24)
        Me.txt_InchargePlan.TabIndex = 152
        Me.txt_InchargePlan.TabStop = False
        Me.txt_InchargePlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_InchargePlan.TextBoxAutoComplete = True
        Me.txt_InchargePlan.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_InchargePlan.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_InchargePlan.TextEnabled = True
        Me.txt_InchargePlan.TextForeColor = System.Drawing.Color.Empty
        Me.txt_InchargePlan.TextMaxLength = 32767
        Me.txt_InchargePlan.TextMultiLine = False
        Me.txt_InchargePlan.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_InchargePlan.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_InchargePlan.UseSendTab = True
        '
        'txt_cdMainProcess
        '
        Me.txt_cdMainProcess.BackYesno = False
        Me.txt_cdMainProcess.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdMainProcess.ButtonEnabled = True
        Me.txt_cdMainProcess.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdMainProcess.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdMainProcess.ButtonName = ""
        Me.txt_cdMainProcess.ButtonTitle = "Process"
        Me.txt_cdMainProcess.Code = ""
        Me.txt_cdMainProcess.Data = ""
        Me.txt_cdMainProcess.DataDecimal = 1
        Me.txt_cdMainProcess.DataLen = 0
        Me.txt_cdMainProcess.DataValue = 1
        Me.txt_cdMainProcess.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_cdMainProcess.Location = New System.Drawing.Point(5, 31)
        Me.txt_cdMainProcess.Margin = New System.Windows.Forms.Padding(1, 1, 171, 1)
        Me.txt_cdMainProcess.Name = "txt_cdMainProcess"
        Me.txt_cdMainProcess.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdMainProcess.Size = New System.Drawing.Size(280, 24)
        Me.txt_cdMainProcess.TabIndex = 151
        Me.txt_cdMainProcess.TabStop = False
        Me.txt_cdMainProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdMainProcess.TextBoxAutoComplete = True
        Me.txt_cdMainProcess.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdMainProcess.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_cdMainProcess.TextEnabled = False
        Me.txt_cdMainProcess.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdMainProcess.TextMaxLength = 32767
        Me.txt_cdMainProcess.TextMultiLine = False
        Me.txt_cdMainProcess.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdMainProcess.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdMainProcess.UseSendTab = True
        '
        'txt_cdFactory
        '
        Me.txt_cdFactory.BackYesno = False
        Me.txt_cdFactory.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdFactory.ButtonEnabled = True
        Me.txt_cdFactory.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdFactory.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.ButtonName = ""
        Me.txt_cdFactory.ButtonTitle = "Factory"
        Me.txt_cdFactory.Code = ""
        Me.txt_cdFactory.Data = ""
        Me.txt_cdFactory.DataDecimal = 1
        Me.txt_cdFactory.DataLen = 0
        Me.txt_cdFactory.DataValue = 1
        Me.txt_cdFactory.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_cdFactory.Location = New System.Drawing.Point(5, 5)
        Me.txt_cdFactory.Margin = New System.Windows.Forms.Padding(1, 1, 171, 1)
        Me.txt_cdFactory.Name = "txt_cdFactory"
        Me.txt_cdFactory.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdFactory.Size = New System.Drawing.Size(280, 24)
        Me.txt_cdFactory.TabIndex = 11
        Me.txt_cdFactory.TabStop = False
        Me.txt_cdFactory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdFactory.TextBoxAutoComplete = True
        Me.txt_cdFactory.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_cdFactory.TextEnabled = False
        Me.txt_cdFactory.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.TextMaxLength = 32767
        Me.txt_cdFactory.TextMultiLine = False
        Me.txt_cdFactory.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdFactory.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdFactory.UseSendTab = True
        '
        'txt_Barcode
        '
        Me.txt_Barcode.BackYesno = False
        Me.txt_Barcode.ButtonTitle = Nothing
        Me.txt_Barcode.Code = Nothing
        Me.txt_Barcode.Data = ""
        Me.txt_Barcode.DataDecimal = 0
        Me.txt_Barcode.DataLen = 0
        Me.txt_Barcode.DataValue = 0
        Me.txt_Barcode.FormatDecimal = 0
        Me.txt_Barcode.FormatValue = False
        Me.txt_Barcode.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Barcode.LableEnabled = True
        Me.txt_Barcode.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Barcode.LableForeColor = System.Drawing.Color.Black
        Me.txt_Barcode.LableTitle = "Barcode #"
        Me.txt_Barcode.Layoutpercent = New Decimal(New Integer() {26, 0, 0, 131072})
        Me.txt_Barcode.Location = New System.Drawing.Point(5, 88)
        Me.txt_Barcode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Barcode.Name = "txt_Barcode"
        Me.txt_Barcode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Barcode.Size = New System.Drawing.Size(416, 50)
        Me.txt_Barcode.TabIndex = 10
        Me.txt_Barcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Barcode.TextBoxAutoComplete = False
        Me.txt_Barcode.TextboxBackColor = System.Drawing.Color.White
        Me.txt_Barcode.TextBoxFont = New System.Drawing.Font("Tahoma", 24.0!)
        Me.txt_Barcode.TextEnabled = True
        Me.txt_Barcode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Barcode.TextMaxLength = 32767
        Me.txt_Barcode.TextMultiLine = False
        Me.txt_Barcode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Barcode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Barcode.UseSendTab = True
        '
        'Frame4
        '
        Me.Frame4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Frame4.Code = ""
        Me.Frame4.Controls.Add(Me.cmd_DEL)
        Me.Frame4.Controls.Add(Me.cmd_Cancel)
        Me.Frame4.Controls.Add(Me.cmd_OK)
        Me.Frame4.Data = ""
        Me.Frame4.Location = New System.Drawing.Point(3, 208)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Size = New System.Drawing.Size(775, 39)
        Me.Frame4.TabIndex = 1
        Me.Frame4.Tag = ""
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
        Me.cmd_DEL.Location = New System.Drawing.Point(5, 2)
        Me.cmd_DEL.Margin = New System.Windows.Forms.Padding(0)
        Me.cmd_DEL.Name = "cmd_DEL"
        Me.cmd_DEL.Size = New System.Drawing.Size(141, 35)
        Me.cmd_DEL.TabIndex = 2
        Me.cmd_DEL.TabStop = False
        Me.cmd_DEL.Text = "DELETE(&D)"
        Me.cmd_DEL.UseVisualStyleBackColor = False
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.ButtonTitle = Nothing
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.Image = CType(resources.GetObject("cmd_Cancel.Image"), System.Drawing.Image)
        Me.cmd_Cancel.ImageAlign = 16
        Me.cmd_Cancel.Location = New System.Drawing.Point(633, 2)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(138, 35)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.TabStop = False
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'cmd_OK
        '
        Me.cmd_OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_OK.ButtonTitle = Nothing
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Image = CType(resources.GetObject("cmd_OK.Image"), System.Drawing.Image)
        Me.cmd_OK.ImageAlign = 16
        Me.cmd_OK.Location = New System.Drawing.Point(492, 2)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(138, 35)
        Me.cmd_OK.TabIndex = 0
        Me.cmd_OK.TabStop = False
        Me.cmd_OK.Text = "SAVE(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'PeacePanel3
        '
        Me.PeacePanel3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel3.Code = ""
        Me.PeacePanel3.Controls.Add(Me.chk_CheckComplete3)
        Me.PeacePanel3.Controls.Add(Me.chk_CheckComplete4)
        Me.PeacePanel3.Controls.Add(Me.chk_CheckComplete5)
        Me.PeacePanel3.Controls.Add(Me.chk_CheckComplete6)
        Me.PeacePanel3.Controls.Add(Me.chk_CheckComplete1)
        Me.PeacePanel3.Controls.Add(Me.chk_CheckComplete2)
        Me.PeacePanel3.Data = ""
        Me.PeacePanel3.Location = New System.Drawing.Point(3, 153)
        Me.PeacePanel3.Name = "PeacePanel3"
        Me.PeacePanel3.Size = New System.Drawing.Size(771, 49)
        Me.PeacePanel3.TabIndex = 0
        Me.PeacePanel3.Tag = ""
        '
        'chk_CheckComplete3
        '
        Me.chk_CheckComplete3.AutoSize = True
        Me.chk_CheckComplete3.ButtonTitle = Nothing
        Me.chk_CheckComplete3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_CheckComplete3.Location = New System.Drawing.Point(18, 60)
        Me.chk_CheckComplete3.Name = "chk_CheckComplete3"
        Me.chk_CheckComplete3.Size = New System.Drawing.Size(56, 18)
        Me.chk_CheckComplete3.TabIndex = 6
        Me.chk_CheckComplete3.Text = "STOP"
        Me.chk_CheckComplete3.UseVisualStyleBackColor = True
        Me.chk_CheckComplete3.Visible = False
        '
        'chk_CheckComplete4
        '
        Me.chk_CheckComplete4.AutoSize = True
        Me.chk_CheckComplete4.ButtonTitle = Nothing
        Me.chk_CheckComplete4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_CheckComplete4.Location = New System.Drawing.Point(111, 59)
        Me.chk_CheckComplete4.Name = "chk_CheckComplete4"
        Me.chk_CheckComplete4.Size = New System.Drawing.Size(82, 18)
        Me.chk_CheckComplete4.TabIndex = 7
        Me.chk_CheckComplete4.Text = "ACCIDENT"
        Me.chk_CheckComplete4.UseVisualStyleBackColor = True
        Me.chk_CheckComplete4.Visible = False
        '
        'chk_CheckComplete5
        '
        Me.chk_CheckComplete5.AutoSize = True
        Me.chk_CheckComplete5.ButtonTitle = Nothing
        Me.chk_CheckComplete5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_CheckComplete5.Location = New System.Drawing.Point(18, 89)
        Me.chk_CheckComplete5.Name = "chk_CheckComplete5"
        Me.chk_CheckComplete5.Size = New System.Drawing.Size(72, 18)
        Me.chk_CheckComplete5.TabIndex = 4
        Me.chk_CheckComplete5.Text = "RECEIPT"
        Me.chk_CheckComplete5.UseVisualStyleBackColor = True
        Me.chk_CheckComplete5.Visible = False
        '
        'chk_CheckComplete6
        '
        Me.chk_CheckComplete6.AutoSize = True
        Me.chk_CheckComplete6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chk_CheckComplete6.ButtonTitle = Nothing
        Me.chk_CheckComplete6.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.chk_CheckComplete6.Location = New System.Drawing.Point(270, 7)
        Me.chk_CheckComplete6.Name = "chk_CheckComplete6"
        Me.chk_CheckComplete6.Size = New System.Drawing.Size(164, 37)
        Me.chk_CheckComplete6.TabIndex = 1
        Me.chk_CheckComplete6.Text = "PROGRESS"
        Me.chk_CheckComplete6.UseVisualStyleBackColor = False
        '
        'chk_CheckComplete1
        '
        Me.chk_CheckComplete1.AutoSize = True
        Me.chk_CheckComplete1.ButtonTitle = Nothing
        Me.chk_CheckComplete1.Checked = True
        Me.chk_CheckComplete1.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.chk_CheckComplete1.Location = New System.Drawing.Point(28, 7)
        Me.chk_CheckComplete1.Name = "chk_CheckComplete1"
        Me.chk_CheckComplete1.Size = New System.Drawing.Size(95, 37)
        Me.chk_CheckComplete1.TabIndex = 0
        Me.chk_CheckComplete1.TabStop = True
        Me.chk_CheckComplete1.Text = "PLAN"
        Me.chk_CheckComplete1.UseVisualStyleBackColor = True
        '
        'chk_CheckComplete2
        '
        Me.chk_CheckComplete2.AutoSize = True
        Me.chk_CheckComplete2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chk_CheckComplete2.ButtonTitle = Nothing
        Me.chk_CheckComplete2.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.chk_CheckComplete2.Location = New System.Drawing.Point(563, 7)
        Me.chk_CheckComplete2.Name = "chk_CheckComplete2"
        Me.chk_CheckComplete2.Size = New System.Drawing.Size(163, 37)
        Me.chk_CheckComplete2.TabIndex = 2
        Me.chk_CheckComplete2.Text = "COMPLETE"
        Me.chk_CheckComplete2.UseVisualStyleBackColor = False
        '
        'ISUD4073H
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(789, 257)
        Me.Controls.Add(Me.frm_Condition)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "ISUD4073H"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PLANNING PROGRESS PROCESSING (ISUD4073H)"
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frm_Condition.ResumeLayout(False)
        CType(Me.Block1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Block1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PeacePanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel2.ResumeLayout(False)
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame4.ResumeLayout(False)
        CType(Me.PeacePanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel3.ResumeLayout(False)
        Me.PeacePanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frm_Condition As PSMGlobal.PeacePanel
    Friend WithEvents Block1 As PSMGlobal.PeacePanel
    Friend WithEvents PeacePanel2 As PSMGlobal.PeacePanel
    Friend WithEvents chk_CheckComplete2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents chk_CheckComplete1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_cdFactory As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_Barcode As PSMGlobal.SelectLabelText
    Friend WithEvents txt_InchargePlan As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdMainProcess As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents PeacePanel3 As PSMGlobal.PeacePanel
    Friend WithEvents txt_LineTno As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ProcessSeq As PSMGlobal.SelectLabelText
    Friend WithEvents txt_DatePlan As PSMGlobal.SelectPeaceCalSin
    Friend WithEvents txt_MachineName As PSMGlobal.SelectLabelText
    Friend WithEvents chk_CheckComplete3 As PSMGlobal.PeaceRadioButton
    Friend WithEvents chk_CheckComplete4 As PSMGlobal.PeaceRadioButton
    Friend WithEvents chk_CheckComplete5 As PSMGlobal.PeaceRadioButton
    Friend WithEvents chk_CheckComplete6 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_cdLineProd As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Frame4 As PSMGlobal.PeacePanel
    Friend WithEvents cmd_DEL As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
End Class
