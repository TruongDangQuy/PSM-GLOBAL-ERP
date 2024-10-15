<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD7231S
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD7231S))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.txt_cdLargeGroupMaterial = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_MaterialName = New PSMGlobal.SelectLabelText()
        Me.txt_cdSemiGroupMaterial = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdDetailGroupMaterial = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_MaterialCode = New PSMGlobal.SelectLabelText()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tlt_CheckUse = New PSMGlobal.PeaceLabel(Me.components)
        Me.PeacePanel4 = New PSMGlobal.PeacePanel(Me.components)
        Me.opt_XCHK1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.opt_XCHK0 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Check2 = New PSMGlobal.SelectLabelText()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Check1 = New PSMGlobal.SelectLabelText()
        Me.txt_OtherCode1 = New PSMGlobal.SelectLabelText()
        Me.txt_cdSpecGroup3 = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdSpecGroup2 = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdSpecGroup1 = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdUnitPacking = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_MaterialPName = New PSMGlobal.SelectLabelText()
        Me.txt_cdUnitMaterial = New PSMGlobal.SelectPeaceHLPButton()
        Me.Panel1.SuspendLayout()
        CType(Me.PeacePanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        'txt_cdLargeGroupMaterial
        '
        Me.txt_cdLargeGroupMaterial.BackYesno = False
        Me.txt_cdLargeGroupMaterial.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdLargeGroupMaterial.ButtonEnabled = True
        Me.txt_cdLargeGroupMaterial.ButtonFont = Nothing
        Me.txt_cdLargeGroupMaterial.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdLargeGroupMaterial.ButtonName = "Const_LargeGroupMaterial"
        Me.txt_cdLargeGroupMaterial.ButtonTitle = "Large Grouping"
        Me.txt_cdLargeGroupMaterial.Code = ""
        Me.txt_cdLargeGroupMaterial.Data = ""
        Me.txt_cdLargeGroupMaterial.DataDecimal = 0
        Me.txt_cdLargeGroupMaterial.DataLen = 0
        Me.txt_cdLargeGroupMaterial.DataValue = 1
        Me.txt_cdLargeGroupMaterial.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdLargeGroupMaterial.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_cdLargeGroupMaterial.Location = New System.Drawing.Point(5, 31)
        Me.txt_cdLargeGroupMaterial.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdLargeGroupMaterial.Name = "txt_cdLargeGroupMaterial"
        Me.txt_cdLargeGroupMaterial.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdLargeGroupMaterial.Size = New System.Drawing.Size(300, 24)
        Me.txt_cdLargeGroupMaterial.TabIndex = 2
        Me.txt_cdLargeGroupMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdLargeGroupMaterial.TextBoxAutoComplete = True
        Me.txt_cdLargeGroupMaterial.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdLargeGroupMaterial.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_cdLargeGroupMaterial.TextEnabled = True
        Me.txt_cdLargeGroupMaterial.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdLargeGroupMaterial.TextMaxLength = 32767
        Me.txt_cdLargeGroupMaterial.TextMultiLine = False
        Me.txt_cdLargeGroupMaterial.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdLargeGroupMaterial.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdLargeGroupMaterial.UseSendTab = True
        '
        'txt_MaterialName
        '
        Me.txt_MaterialName.BackYesno = False
        Me.txt_MaterialName.ButtonTitle = Nothing
        Me.txt_MaterialName.Code = ""
        Me.txt_MaterialName.Data = ""
        Me.txt_MaterialName.DataDecimal = 0
        Me.txt_MaterialName.DataLen = 0
        Me.txt_MaterialName.DataValue = 0
        Me.txt_MaterialName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaterialName.FormatDecimal = 0
        Me.txt_MaterialName.FormatValue = False
        Me.txt_MaterialName.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_MaterialName.LableEnabled = True
        Me.txt_MaterialName.LableFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaterialName.LableForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_MaterialName.LableTitle = "Material Name"
        Me.txt_MaterialName.Layoutpercent = New Decimal(New Integer() {206, 0, 0, 196608})
        Me.txt_MaterialName.Location = New System.Drawing.Point(5, 192)
        Me.txt_MaterialName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MaterialName.Name = "txt_MaterialName"
        Me.txt_MaterialName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MaterialName.Size = New System.Drawing.Size(605, 54)
        Me.txt_MaterialName.TabIndex = 9
        Me.txt_MaterialName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MaterialName.TextBoxAutoComplete = False
        Me.txt_MaterialName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MaterialName.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MaterialName.TextEnabled = True
        Me.txt_MaterialName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MaterialName.TextMaxLength = 32767
        Me.txt_MaterialName.TextMultiLine = True
        Me.txt_MaterialName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MaterialName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MaterialName.UseSendTab = True
        '
        'txt_cdSemiGroupMaterial
        '
        Me.txt_cdSemiGroupMaterial.BackYesno = False
        Me.txt_cdSemiGroupMaterial.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSemiGroupMaterial.ButtonEnabled = True
        Me.txt_cdSemiGroupMaterial.ButtonFont = Nothing
        Me.txt_cdSemiGroupMaterial.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSemiGroupMaterial.ButtonName = "Const_SemiGroupMaterial"
        Me.txt_cdSemiGroupMaterial.ButtonTitle = "Semi Grouping"
        Me.txt_cdSemiGroupMaterial.Code = ""
        Me.txt_cdSemiGroupMaterial.Data = ""
        Me.txt_cdSemiGroupMaterial.DataDecimal = 0
        Me.txt_cdSemiGroupMaterial.DataLen = 0
        Me.txt_cdSemiGroupMaterial.DataValue = 1
        Me.txt_cdSemiGroupMaterial.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdSemiGroupMaterial.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_cdSemiGroupMaterial.Location = New System.Drawing.Point(5, 58)
        Me.txt_cdSemiGroupMaterial.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSemiGroupMaterial.Name = "txt_cdSemiGroupMaterial"
        Me.txt_cdSemiGroupMaterial.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSemiGroupMaterial.Size = New System.Drawing.Size(300, 24)
        Me.txt_cdSemiGroupMaterial.TabIndex = 3
        Me.txt_cdSemiGroupMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSemiGroupMaterial.TextBoxAutoComplete = True
        Me.txt_cdSemiGroupMaterial.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdSemiGroupMaterial.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_cdSemiGroupMaterial.TextEnabled = True
        Me.txt_cdSemiGroupMaterial.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdSemiGroupMaterial.TextMaxLength = 32767
        Me.txt_cdSemiGroupMaterial.TextMultiLine = False
        Me.txt_cdSemiGroupMaterial.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdSemiGroupMaterial.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdSemiGroupMaterial.UseSendTab = True
        '
        'txt_cdDetailGroupMaterial
        '
        Me.txt_cdDetailGroupMaterial.BackYesno = False
        Me.txt_cdDetailGroupMaterial.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdDetailGroupMaterial.ButtonEnabled = True
        Me.txt_cdDetailGroupMaterial.ButtonFont = Nothing
        Me.txt_cdDetailGroupMaterial.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdDetailGroupMaterial.ButtonName = "Const_DetailGroupMaterial"
        Me.txt_cdDetailGroupMaterial.ButtonTitle = "Detailed Grouping"
        Me.txt_cdDetailGroupMaterial.Code = ""
        Me.txt_cdDetailGroupMaterial.Data = ""
        Me.txt_cdDetailGroupMaterial.DataDecimal = 0
        Me.txt_cdDetailGroupMaterial.DataLen = 0
        Me.txt_cdDetailGroupMaterial.DataValue = 0
        Me.txt_cdDetailGroupMaterial.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdDetailGroupMaterial.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_cdDetailGroupMaterial.Location = New System.Drawing.Point(310, 31)
        Me.txt_cdDetailGroupMaterial.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdDetailGroupMaterial.Name = "txt_cdDetailGroupMaterial"
        Me.txt_cdDetailGroupMaterial.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdDetailGroupMaterial.Size = New System.Drawing.Size(300, 24)
        Me.txt_cdDetailGroupMaterial.TabIndex = 4
        Me.txt_cdDetailGroupMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdDetailGroupMaterial.TextBoxAutoComplete = True
        Me.txt_cdDetailGroupMaterial.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdDetailGroupMaterial.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_cdDetailGroupMaterial.TextEnabled = True
        Me.txt_cdDetailGroupMaterial.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdDetailGroupMaterial.TextMaxLength = 32767
        Me.txt_cdDetailGroupMaterial.TextMultiLine = False
        Me.txt_cdDetailGroupMaterial.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdDetailGroupMaterial.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdDetailGroupMaterial.UseSendTab = True
        '
        'txt_MaterialCode
        '
        Me.txt_MaterialCode.BackYesno = False
        Me.txt_MaterialCode.ButtonTitle = Nothing
        Me.txt_MaterialCode.Code = ""
        Me.txt_MaterialCode.Data = ""
        Me.txt_MaterialCode.DataDecimal = 0
        Me.txt_MaterialCode.DataLen = 0
        Me.txt_MaterialCode.DataValue = 0
        Me.txt_MaterialCode.FormatDecimal = 0
        Me.txt_MaterialCode.FormatValue = False
        Me.txt_MaterialCode.LableBackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_MaterialCode.LableEnabled = True
        Me.txt_MaterialCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaterialCode.LableForeColor = System.Drawing.Color.Black
        Me.txt_MaterialCode.LableTitle = "Code"
        Me.txt_MaterialCode.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_MaterialCode.Location = New System.Drawing.Point(5, 5)
        Me.txt_MaterialCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MaterialCode.Name = "txt_MaterialCode"
        Me.txt_MaterialCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MaterialCode.Size = New System.Drawing.Size(300, 24)
        Me.txt_MaterialCode.TabIndex = 0
        Me.txt_MaterialCode.TabStop = False
        Me.txt_MaterialCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MaterialCode.TextBoxAutoComplete = False
        Me.txt_MaterialCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MaterialCode.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_MaterialCode.TextEnabled = False
        Me.txt_MaterialCode.TextForeColor = System.Drawing.Color.Blue
        Me.txt_MaterialCode.TextMaxLength = 32767
        Me.txt_MaterialCode.TextMultiLine = False
        Me.txt_MaterialCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MaterialCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MaterialCode.UseSendTab = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.tlt_CheckUse)
        Me.Panel1.Controls.Add(Me.PeacePanel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 317)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(615, 41)
        Me.Panel1.TabIndex = 0
        '
        'tlt_CheckUse
        '
        Me.tlt_CheckUse.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.tlt_CheckUse.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlt_CheckUse.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tlt_CheckUse.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tlt_CheckUse.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.tlt_CheckUse.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tlt_CheckUse.ButtonTitle = Nothing
        Me.tlt_CheckUse.Code = ""
        Me.tlt_CheckUse.Data = ""
        Me.tlt_CheckUse.DTDec = 0
        Me.tlt_CheckUse.DTLen = 0
        Me.tlt_CheckUse.DTValue = 0
        Me.tlt_CheckUse.Location = New System.Drawing.Point(5, 5)
        Me.tlt_CheckUse.Margin = New System.Windows.Forms.Padding(1)
        Me.tlt_CheckUse.Name = "tlt_CheckUse"
        Me.tlt_CheckUse.NoClear = False
        Me.tlt_CheckUse.Size = New System.Drawing.Size(123, 29)
        Me.tlt_CheckUse.TabIndex = 0
        Me.tlt_CheckUse.Tag = ""
        Me.tlt_CheckUse.Text = "Use"
        Me.tlt_CheckUse.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'PeacePanel4
        '
        Me.PeacePanel4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel4.Code = ""
        Me.PeacePanel4.Controls.Add(Me.opt_XCHK1)
        Me.PeacePanel4.Controls.Add(Me.opt_XCHK0)
        Me.PeacePanel4.Data = ""
        Me.PeacePanel4.Location = New System.Drawing.Point(130, 5)
        Me.PeacePanel4.Name = "PeacePanel4"
        Me.PeacePanel4.Size = New System.Drawing.Size(175, 30)
        Me.PeacePanel4.TabIndex = 1
        Me.PeacePanel4.Tag = ""
        '
        'opt_XCHK1
        '
        Me.opt_XCHK1.ButtonTitle = Nothing
        Me.opt_XCHK1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_XCHK1.Location = New System.Drawing.Point(93, 3)
        Me.opt_XCHK1.Name = "opt_XCHK1"
        Me.opt_XCHK1.Size = New System.Drawing.Size(40, 26)
        Me.opt_XCHK1.TabIndex = 1
        Me.opt_XCHK1.Text = "No"
        Me.opt_XCHK1.UseVisualStyleBackColor = True
        '
        'opt_XCHK0
        '
        Me.opt_XCHK0.ButtonTitle = Nothing
        Me.opt_XCHK0.Checked = True
        Me.opt_XCHK0.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_XCHK0.Location = New System.Drawing.Point(7, 3)
        Me.opt_XCHK0.Name = "opt_XCHK0"
        Me.opt_XCHK0.Size = New System.Drawing.Size(45, 26)
        Me.opt_XCHK0.TabIndex = 0
        Me.opt_XCHK0.TabStop = True
        Me.opt_XCHK0.Text = "Yes"
        Me.opt_XCHK0.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txt_Check2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txt_Check1)
        Me.Panel2.Controls.Add(Me.txt_OtherCode1)
        Me.Panel2.Controls.Add(Me.txt_cdSpecGroup3)
        Me.Panel2.Controls.Add(Me.txt_cdSpecGroup2)
        Me.Panel2.Controls.Add(Me.txt_cdSpecGroup1)
        Me.Panel2.Controls.Add(Me.txt_cdUnitPacking)
        Me.Panel2.Controls.Add(Me.txt_MaterialPName)
        Me.Panel2.Controls.Add(Me.txt_cdUnitMaterial)
        Me.Panel2.Controls.Add(Me.txt_MaterialName)
        Me.Panel2.Controls.Add(Me.txt_MaterialCode)
        Me.Panel2.Controls.Add(Me.txt_cdLargeGroupMaterial)
        Me.Panel2.Controls.Add(Me.txt_cdDetailGroupMaterial)
        Me.Panel2.Controls.Add(Me.txt_cdSemiGroupMaterial)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(615, 279)
        Me.Panel2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(479, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 48)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Case '1' : Material" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Case '2' : Process" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Case '3' : CMT"
        '
        'txt_Check2
        '
        Me.txt_Check2.BackYesno = False
        Me.txt_Check2.ButtonTitle = Nothing
        Me.txt_Check2.Code = ""
        Me.txt_Check2.Data = "1"
        Me.txt_Check2.DataDecimal = 0
        Me.txt_Check2.DataLen = 0
        Me.txt_Check2.DataValue = 0
        Me.txt_Check2.FormatDecimal = 0
        Me.txt_Check2.FormatValue = False
        Me.txt_Check2.LableBackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_Check2.LableEnabled = True
        Me.txt_Check2.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Check2.LableForeColor = System.Drawing.Color.Black
        Me.txt_Check2.LableTitle = "Type"
        Me.txt_Check2.Layoutpercent = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txt_Check2.Location = New System.Drawing.Point(479, 57)
        Me.txt_Check2.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Check2.Name = "txt_Check2"
        Me.txt_Check2.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Check2.Size = New System.Drawing.Size(125, 24)
        Me.txt_Check2.TabIndex = 14
        Me.txt_Check2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Check2.TextBoxAutoComplete = False
        Me.txt_Check2.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Check2.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_Check2.TextEnabled = True
        Me.txt_Check2.TextForeColor = System.Drawing.Color.Blue
        Me.txt_Check2.TextMaxLength = 32767
        Me.txt_Check2.TextMultiLine = False
        Me.txt_Check2.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Check2.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Check2.UseSendTab = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(310, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 75)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Case '1' : Normal  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Case '2' : Charge over " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Case '3' : Charge All" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Case '4' : S" & _
    "ystem" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Case '5' : Divide 2 figures"
        '
        'txt_Check1
        '
        Me.txt_Check1.BackYesno = False
        Me.txt_Check1.ButtonTitle = Nothing
        Me.txt_Check1.Code = ""
        Me.txt_Check1.Data = "1"
        Me.txt_Check1.DataDecimal = 0
        Me.txt_Check1.DataLen = 0
        Me.txt_Check1.DataValue = 0
        Me.txt_Check1.FormatDecimal = 0
        Me.txt_Check1.FormatValue = False
        Me.txt_Check1.LableBackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_Check1.LableEnabled = True
        Me.txt_Check1.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Check1.LableForeColor = System.Drawing.Color.Black
        Me.txt_Check1.LableTitle = "Price Case"
        Me.txt_Check1.Layoutpercent = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txt_Check1.Location = New System.Drawing.Point(310, 57)
        Me.txt_Check1.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Check1.Name = "txt_Check1"
        Me.txt_Check1.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Check1.Size = New System.Drawing.Size(125, 24)
        Me.txt_Check1.TabIndex = 12
        Me.txt_Check1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Check1.TextBoxAutoComplete = False
        Me.txt_Check1.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Check1.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_Check1.TextEnabled = True
        Me.txt_Check1.TextForeColor = System.Drawing.Color.Blue
        Me.txt_Check1.TextMaxLength = 32767
        Me.txt_Check1.TextMultiLine = False
        Me.txt_Check1.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Check1.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Check1.UseSendTab = True
        '
        'txt_OtherCode1
        '
        Me.txt_OtherCode1.BackYesno = False
        Me.txt_OtherCode1.ButtonTitle = Nothing
        Me.txt_OtherCode1.Code = ""
        Me.txt_OtherCode1.Data = ""
        Me.txt_OtherCode1.DataDecimal = 0
        Me.txt_OtherCode1.DataLen = 0
        Me.txt_OtherCode1.DataValue = 0
        Me.txt_OtherCode1.FormatDecimal = 0
        Me.txt_OtherCode1.FormatValue = False
        Me.txt_OtherCode1.LableBackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_OtherCode1.LableEnabled = True
        Me.txt_OtherCode1.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_OtherCode1.LableForeColor = System.Drawing.Color.Black
        Me.txt_OtherCode1.LableTitle = "CS Code"
        Me.txt_OtherCode1.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_OtherCode1.Location = New System.Drawing.Point(310, 5)
        Me.txt_OtherCode1.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_OtherCode1.Name = "txt_OtherCode1"
        Me.txt_OtherCode1.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_OtherCode1.Size = New System.Drawing.Size(300, 24)
        Me.txt_OtherCode1.TabIndex = 1
        Me.txt_OtherCode1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_OtherCode1.TextBoxAutoComplete = False
        Me.txt_OtherCode1.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_OtherCode1.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_OtherCode1.TextEnabled = True
        Me.txt_OtherCode1.TextForeColor = System.Drawing.Color.Blue
        Me.txt_OtherCode1.TextMaxLength = 32767
        Me.txt_OtherCode1.TextMultiLine = False
        Me.txt_OtherCode1.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_OtherCode1.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_OtherCode1.UseSendTab = True
        '
        'txt_cdSpecGroup3
        '
        Me.txt_cdSpecGroup3.BackYesno = False
        Me.txt_cdSpecGroup3.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSpecGroup3.ButtonEnabled = True
        Me.txt_cdSpecGroup3.ButtonFont = Nothing
        Me.txt_cdSpecGroup3.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSpecGroup3.ButtonName = "Const_SemiGroupMaterial"
        Me.txt_cdSpecGroup3.ButtonTitle = "Spec 3"
        Me.txt_cdSpecGroup3.Code = ""
        Me.txt_cdSpecGroup3.Data = ""
        Me.txt_cdSpecGroup3.DataDecimal = 0
        Me.txt_cdSpecGroup3.DataLen = 0
        Me.txt_cdSpecGroup3.DataValue = 1
        Me.txt_cdSpecGroup3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdSpecGroup3.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_cdSpecGroup3.Location = New System.Drawing.Point(5, 137)
        Me.txt_cdSpecGroup3.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSpecGroup3.Name = "txt_cdSpecGroup3"
        Me.txt_cdSpecGroup3.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSpecGroup3.Size = New System.Drawing.Size(300, 24)
        Me.txt_cdSpecGroup3.TabIndex = 7
        Me.txt_cdSpecGroup3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSpecGroup3.TextBoxAutoComplete = True
        Me.txt_cdSpecGroup3.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdSpecGroup3.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_cdSpecGroup3.TextEnabled = True
        Me.txt_cdSpecGroup3.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdSpecGroup3.TextMaxLength = 32767
        Me.txt_cdSpecGroup3.TextMultiLine = False
        Me.txt_cdSpecGroup3.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdSpecGroup3.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdSpecGroup3.UseSendTab = True
        '
        'txt_cdSpecGroup2
        '
        Me.txt_cdSpecGroup2.BackYesno = False
        Me.txt_cdSpecGroup2.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSpecGroup2.ButtonEnabled = True
        Me.txt_cdSpecGroup2.ButtonFont = Nothing
        Me.txt_cdSpecGroup2.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSpecGroup2.ButtonName = "Const_SemiGroupMaterial"
        Me.txt_cdSpecGroup2.ButtonTitle = "Spec 2"
        Me.txt_cdSpecGroup2.Code = ""
        Me.txt_cdSpecGroup2.Data = ""
        Me.txt_cdSpecGroup2.DataDecimal = 0
        Me.txt_cdSpecGroup2.DataLen = 0
        Me.txt_cdSpecGroup2.DataValue = 1
        Me.txt_cdSpecGroup2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdSpecGroup2.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_cdSpecGroup2.Location = New System.Drawing.Point(5, 111)
        Me.txt_cdSpecGroup2.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSpecGroup2.Name = "txt_cdSpecGroup2"
        Me.txt_cdSpecGroup2.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSpecGroup2.Size = New System.Drawing.Size(300, 24)
        Me.txt_cdSpecGroup2.TabIndex = 6
        Me.txt_cdSpecGroup2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSpecGroup2.TextBoxAutoComplete = True
        Me.txt_cdSpecGroup2.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdSpecGroup2.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_cdSpecGroup2.TextEnabled = True
        Me.txt_cdSpecGroup2.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdSpecGroup2.TextMaxLength = 32767
        Me.txt_cdSpecGroup2.TextMultiLine = False
        Me.txt_cdSpecGroup2.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdSpecGroup2.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdSpecGroup2.UseSendTab = True
        '
        'txt_cdSpecGroup1
        '
        Me.txt_cdSpecGroup1.BackYesno = False
        Me.txt_cdSpecGroup1.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSpecGroup1.ButtonEnabled = True
        Me.txt_cdSpecGroup1.ButtonFont = Nothing
        Me.txt_cdSpecGroup1.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSpecGroup1.ButtonName = "Const_SemiGroupMaterial"
        Me.txt_cdSpecGroup1.ButtonTitle = "Spec 1"
        Me.txt_cdSpecGroup1.Code = ""
        Me.txt_cdSpecGroup1.Data = ""
        Me.txt_cdSpecGroup1.DataDecimal = 0
        Me.txt_cdSpecGroup1.DataLen = 0
        Me.txt_cdSpecGroup1.DataValue = 1
        Me.txt_cdSpecGroup1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdSpecGroup1.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_cdSpecGroup1.Location = New System.Drawing.Point(5, 84)
        Me.txt_cdSpecGroup1.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSpecGroup1.Name = "txt_cdSpecGroup1"
        Me.txt_cdSpecGroup1.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSpecGroup1.Size = New System.Drawing.Size(300, 24)
        Me.txt_cdSpecGroup1.TabIndex = 5
        Me.txt_cdSpecGroup1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSpecGroup1.TextBoxAutoComplete = True
        Me.txt_cdSpecGroup1.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdSpecGroup1.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_cdSpecGroup1.TextEnabled = True
        Me.txt_cdSpecGroup1.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdSpecGroup1.TextMaxLength = 32767
        Me.txt_cdSpecGroup1.TextMultiLine = False
        Me.txt_cdSpecGroup1.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdSpecGroup1.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdSpecGroup1.UseSendTab = True
        '
        'txt_cdUnitPacking
        '
        Me.txt_cdUnitPacking.BackYesno = False
        Me.txt_cdUnitPacking.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdUnitPacking.ButtonEnabled = True
        Me.txt_cdUnitPacking.ButtonFont = Nothing
        Me.txt_cdUnitPacking.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdUnitPacking.ButtonName = "Const_UnitMaterial"
        Me.txt_cdUnitPacking.ButtonTitle = "Packingl Unit"
        Me.txt_cdUnitPacking.Code = ""
        Me.txt_cdUnitPacking.Data = ""
        Me.txt_cdUnitPacking.DataDecimal = 0
        Me.txt_cdUnitPacking.DataLen = 0
        Me.txt_cdUnitPacking.DataValue = 0
        Me.txt_cdUnitPacking.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdUnitPacking.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_cdUnitPacking.Location = New System.Drawing.Point(310, 250)
        Me.txt_cdUnitPacking.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdUnitPacking.Name = "txt_cdUnitPacking"
        Me.txt_cdUnitPacking.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdUnitPacking.Size = New System.Drawing.Size(300, 24)
        Me.txt_cdUnitPacking.TabIndex = 11
        Me.txt_cdUnitPacking.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdUnitPacking.TextBoxAutoComplete = False
        Me.txt_cdUnitPacking.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdUnitPacking.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_cdUnitPacking.TextEnabled = True
        Me.txt_cdUnitPacking.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdUnitPacking.TextMaxLength = 32767
        Me.txt_cdUnitPacking.TextMultiLine = False
        Me.txt_cdUnitPacking.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdUnitPacking.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdUnitPacking.UseSendTab = True
        '
        'txt_MaterialPName
        '
        Me.txt_MaterialPName.BackYesno = False
        Me.txt_MaterialPName.ButtonTitle = Nothing
        Me.txt_MaterialPName.Code = ""
        Me.txt_MaterialPName.Data = ""
        Me.txt_MaterialPName.DataDecimal = 0
        Me.txt_MaterialPName.DataLen = 0
        Me.txt_MaterialPName.DataValue = 0
        Me.txt_MaterialPName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaterialPName.FormatDecimal = 0
        Me.txt_MaterialPName.FormatValue = False
        Me.txt_MaterialPName.LableBackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_MaterialPName.LableEnabled = True
        Me.txt_MaterialPName.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaterialPName.LableForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_MaterialPName.LableTitle = "Name"
        Me.txt_MaterialPName.Layoutpercent = New Decimal(New Integer() {206, 0, 0, 196608})
        Me.txt_MaterialPName.Location = New System.Drawing.Point(5, 164)
        Me.txt_MaterialPName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MaterialPName.Name = "txt_MaterialPName"
        Me.txt_MaterialPName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MaterialPName.Size = New System.Drawing.Size(605, 24)
        Me.txt_MaterialPName.TabIndex = 8
        Me.txt_MaterialPName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MaterialPName.TextBoxAutoComplete = False
        Me.txt_MaterialPName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MaterialPName.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_MaterialPName.TextEnabled = True
        Me.txt_MaterialPName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MaterialPName.TextMaxLength = 32767
        Me.txt_MaterialPName.TextMultiLine = True
        Me.txt_MaterialPName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MaterialPName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MaterialPName.UseSendTab = True
        '
        'txt_cdUnitMaterial
        '
        Me.txt_cdUnitMaterial.BackYesno = False
        Me.txt_cdUnitMaterial.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdUnitMaterial.ButtonEnabled = True
        Me.txt_cdUnitMaterial.ButtonFont = Nothing
        Me.txt_cdUnitMaterial.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdUnitMaterial.ButtonName = "Const_UnitMaterial"
        Me.txt_cdUnitMaterial.ButtonTitle = "Material Unit"
        Me.txt_cdUnitMaterial.Code = ""
        Me.txt_cdUnitMaterial.Data = ""
        Me.txt_cdUnitMaterial.DataDecimal = 0
        Me.txt_cdUnitMaterial.DataLen = 0
        Me.txt_cdUnitMaterial.DataValue = 1
        Me.txt_cdUnitMaterial.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdUnitMaterial.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_cdUnitMaterial.Location = New System.Drawing.Point(5, 250)
        Me.txt_cdUnitMaterial.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdUnitMaterial.Name = "txt_cdUnitMaterial"
        Me.txt_cdUnitMaterial.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdUnitMaterial.Size = New System.Drawing.Size(300, 24)
        Me.txt_cdUnitMaterial.TabIndex = 10
        Me.txt_cdUnitMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdUnitMaterial.TextBoxAutoComplete = False
        Me.txt_cdUnitMaterial.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdUnitMaterial.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_cdUnitMaterial.TextEnabled = True
        Me.txt_cdUnitMaterial.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdUnitMaterial.TextMaxLength = 32767
        Me.txt_cdUnitMaterial.TextMultiLine = False
        Me.txt_cdUnitMaterial.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdUnitMaterial.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdUnitMaterial.UseSendTab = True
        '
        'ISUD7231S
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(615, 360)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(631, 399)
        Me.MinimumSize = New System.Drawing.Size(631, 399)
        Me.Name = "ISUD7231S"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MATERIAL CODE PROCESSING (ISUD7231S)"
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PeacePanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_MaterialName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdDetailGroupMaterial As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdSemiGroupMaterial As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_MaterialCode As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdLargeGroupMaterial As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_cdUnitMaterial As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_MaterialPName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdUnitPacking As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents tlt_CheckUse As PSMGlobal.PeaceLabel
    Friend WithEvents PeacePanel4 As PSMGlobal.PeacePanel
    Friend WithEvents opt_XCHK1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents opt_XCHK0 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_OtherCode1 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdSpecGroup3 As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdSpecGroup2 As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdSpecGroup1 As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Check1 As PSMGlobal.SelectLabelText
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Check2 As PSMGlobal.SelectLabelText
End Class
