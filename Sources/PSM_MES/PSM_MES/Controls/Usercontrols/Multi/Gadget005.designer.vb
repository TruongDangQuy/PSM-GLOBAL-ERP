<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gadget005
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txt_SdateEdate = New PSMGlobal.SelectPeaceCalDou()
        Me.txt_GCODE = New PSMGlobal.SelectMulti()
        Me.txt_CustomerName = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdSeason = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdFactory = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdLineGroup = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdLineProd = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_SealNo = New PSMGlobal.SelectLabelText()
        Me.txt_Article = New PSMGlobal.SelectLabelText()
        Me.txt_Line = New PSMGlobal.SelectLabelText()
        Me.txt_ColorName = New PSMGlobal.SelectLabelText()
        Me.txt_MoldName = New PSMGlobal.SelectLabelText()
        Me.txt_LastName = New PSMGlobal.SelectLabelText()
        Me.txt_Incharge = New PSMGlobal.SelectPeaceHLPButton()
        Me.pCheckUse = New System.Windows.Forms.Panel()
        Me.chk_CheckUse2 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_CheckUse1 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.txt_CheckUse = New PSMGlobal.SelectLabelText()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.pCheckUse.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(18, 18)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 511.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(367, 400)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_SdateEdate)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_GCODE)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_CustomerName)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdSeason)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdFactory)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdLineGroup)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdLineProd)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_SealNo)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Article)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Line)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_ColorName)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_MoldName)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_LastName)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Incharge)
        Me.FlowLayoutPanel1.Controls.Add(Me.pCheckUse)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(1, 1)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(1)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(365, 398)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'txt_SdateEdate
        '
        Me.txt_SdateEdate.ButtonTitle = "Period"
        Me.txt_SdateEdate.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_SdateEdate.Location = New System.Drawing.Point(1, 1)
        Me.txt_SdateEdate.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.txt_SdateEdate.Name = "txt_SdateEdate"
        Me.txt_SdateEdate.Size = New System.Drawing.Size(361, 21)
        Me.txt_SdateEdate.TabIndex = 0
        Me.txt_SdateEdate.text1 = ""
        Me.txt_SdateEdate.text2 = ""
        Me.txt_SdateEdate.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        '
        'txt_GCODE
        '
        Me.txt_GCODE.BackColor = System.Drawing.SystemColors.Control
        Me.txt_GCODE.ButtonTitle = "Customer Multi"
        Me.txt_GCODE.CheckBoxEnabled = True
        Me.txt_GCODE.CheckBoxTitle = Nothing
        Me.txt_GCODE.ComboBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_GCODE.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_GCODE.Layoutpercent = "34,10,33,23"
        Me.txt_GCODE.Location = New System.Drawing.Point(1, 25)
        Me.txt_GCODE.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_GCODE.Name = "txt_GCODE"
        Me.txt_GCODE.SelectTitle = "Multiple"
        Me.txt_GCODE.Size = New System.Drawing.Size(361, 24)
        Me.txt_GCODE.TabIndex = 1
        Me.txt_GCODE.Visible = False
        '
        'txt_CustomerName
        '
        Me.txt_CustomerName.BackYesno = False
        Me.txt_CustomerName.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_CustomerName.ButtonEnabled = True
        Me.txt_CustomerName.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_CustomerName.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_CustomerName.ButtonName = Nothing
        Me.txt_CustomerName.ButtonTitle = "Customer"
        Me.txt_CustomerName.Code = ""
        Me.txt_CustomerName.Data = ""
        Me.txt_CustomerName.DataDecimal = 0
        Me.txt_CustomerName.DataLen = 0
        Me.txt_CustomerName.DataValue = 0
        Me.txt_CustomerName.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_CustomerName.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_CustomerName.Location = New System.Drawing.Point(1, 51)
        Me.txt_CustomerName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_CustomerName.Name = "txt_CustomerName"
        Me.txt_CustomerName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CustomerName.Size = New System.Drawing.Size(361, 24)
        Me.txt_CustomerName.TabIndex = 2
        Me.txt_CustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_CustomerName.TextBoxAutoComplete = False
        Me.txt_CustomerName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_CustomerName.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_CustomerName.TextEnabled = True
        Me.txt_CustomerName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_CustomerName.TextMaxLength = 32767
        Me.txt_CustomerName.TextMultiLine = False
        Me.txt_CustomerName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CustomerName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_CustomerName.UseSendTab = True
        '
        'txt_cdSeason
        '
        Me.txt_cdSeason.BackYesno = False
        Me.txt_cdSeason.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSeason.ButtonEnabled = True
        Me.txt_cdSeason.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_cdSeason.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSeason.ButtonName = Nothing
        Me.txt_cdSeason.ButtonTitle = "Season"
        Me.txt_cdSeason.Code = ""
        Me.txt_cdSeason.Data = ""
        Me.txt_cdSeason.DataDecimal = 0
        Me.txt_cdSeason.DataLen = 0
        Me.txt_cdSeason.DataValue = 0
        Me.txt_cdSeason.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdSeason.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdSeason.Location = New System.Drawing.Point(1, 77)
        Me.txt_cdSeason.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSeason.Name = "txt_cdSeason"
        Me.txt_cdSeason.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSeason.Size = New System.Drawing.Size(361, 24)
        Me.txt_cdSeason.TabIndex = 3
        Me.txt_cdSeason.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSeason.TextBoxAutoComplete = False
        Me.txt_cdSeason.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdSeason.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdSeason.TextEnabled = True
        Me.txt_cdSeason.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdSeason.TextMaxLength = 32767
        Me.txt_cdSeason.TextMultiLine = False
        Me.txt_cdSeason.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdSeason.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdSeason.UseSendTab = True
        '
        'txt_cdFactory
        '
        Me.txt_cdFactory.BackYesno = False
        Me.txt_cdFactory.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdFactory.ButtonEnabled = True
        Me.txt_cdFactory.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_cdFactory.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.ButtonName = Nothing
        Me.txt_cdFactory.ButtonTitle = "Factory"
        Me.txt_cdFactory.Code = ""
        Me.txt_cdFactory.Data = ""
        Me.txt_cdFactory.DataDecimal = 0
        Me.txt_cdFactory.DataLen = 0
        Me.txt_cdFactory.DataValue = 0
        Me.txt_cdFactory.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdFactory.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdFactory.Location = New System.Drawing.Point(1, 103)
        Me.txt_cdFactory.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdFactory.Name = "txt_cdFactory"
        Me.txt_cdFactory.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdFactory.Size = New System.Drawing.Size(361, 24)
        Me.txt_cdFactory.TabIndex = 4
        Me.txt_cdFactory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdFactory.TextBoxAutoComplete = False
        Me.txt_cdFactory.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdFactory.TextEnabled = True
        Me.txt_cdFactory.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.TextMaxLength = 32767
        Me.txt_cdFactory.TextMultiLine = False
        Me.txt_cdFactory.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdFactory.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdFactory.UseSendTab = True
        '
        'txt_cdLineGroup
        '
        Me.txt_cdLineGroup.BackYesno = False
        Me.txt_cdLineGroup.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdLineGroup.ButtonEnabled = True
        Me.txt_cdLineGroup.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_cdLineGroup.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdLineGroup.ButtonName = Nothing
        Me.txt_cdLineGroup.ButtonTitle = "Line Group"
        Me.txt_cdLineGroup.Code = ""
        Me.txt_cdLineGroup.Data = ""
        Me.txt_cdLineGroup.DataDecimal = 0
        Me.txt_cdLineGroup.DataLen = 0
        Me.txt_cdLineGroup.DataValue = 0
        Me.txt_cdLineGroup.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdLineGroup.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdLineGroup.Location = New System.Drawing.Point(1, 129)
        Me.txt_cdLineGroup.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdLineGroup.Name = "txt_cdLineGroup"
        Me.txt_cdLineGroup.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdLineGroup.Size = New System.Drawing.Size(361, 24)
        Me.txt_cdLineGroup.TabIndex = 6
        Me.txt_cdLineGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdLineGroup.TextBoxAutoComplete = False
        Me.txt_cdLineGroup.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdLineGroup.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdLineGroup.TextEnabled = True
        Me.txt_cdLineGroup.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdLineGroup.TextMaxLength = 32767
        Me.txt_cdLineGroup.TextMultiLine = False
        Me.txt_cdLineGroup.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdLineGroup.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdLineGroup.UseSendTab = True
        '
        'txt_cdLineProd
        '
        Me.txt_cdLineProd.BackYesno = False
        Me.txt_cdLineProd.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdLineProd.ButtonEnabled = True
        Me.txt_cdLineProd.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_cdLineProd.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd.ButtonName = Nothing
        Me.txt_cdLineProd.ButtonTitle = "Line Prod"
        Me.txt_cdLineProd.Code = ""
        Me.txt_cdLineProd.Data = ""
        Me.txt_cdLineProd.DataDecimal = 0
        Me.txt_cdLineProd.DataLen = 0
        Me.txt_cdLineProd.DataValue = 0
        Me.txt_cdLineProd.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdLineProd.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdLineProd.Location = New System.Drawing.Point(1, 155)
        Me.txt_cdLineProd.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdLineProd.Name = "txt_cdLineProd"
        Me.txt_cdLineProd.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdLineProd.Size = New System.Drawing.Size(361, 24)
        Me.txt_cdLineProd.TabIndex = 7
        Me.txt_cdLineProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdLineProd.TextBoxAutoComplete = False
        Me.txt_cdLineProd.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdLineProd.TextEnabled = True
        Me.txt_cdLineProd.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd.TextMaxLength = 32767
        Me.txt_cdLineProd.TextMultiLine = False
        Me.txt_cdLineProd.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdLineProd.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdLineProd.UseSendTab = True
        '
        'txt_SealNo
        '
        Me.txt_SealNo.BackYesno = False
        Me.txt_SealNo.ButtonTitle = Nothing
        Me.txt_SealNo.Code = Nothing
        Me.txt_SealNo.Data = ""
        Me.txt_SealNo.DataDecimal = 0
        Me.txt_SealNo.DataLen = 0
        Me.txt_SealNo.DataValue = 0
        Me.txt_SealNo.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_SealNo.FormatDecimal = 0
        Me.txt_SealNo.FormatValue = False
        Me.txt_SealNo.LableBackColor = System.Drawing.Color.Empty
        Me.txt_SealNo.LableEnabled = True
        Me.txt_SealNo.LableFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_SealNo.LableForeColor = System.Drawing.Color.Black
        Me.txt_SealNo.LableTitle = "Seal No #"
        Me.txt_SealNo.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_SealNo.Location = New System.Drawing.Point(1, 181)
        Me.txt_SealNo.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_SealNo.Name = "txt_SealNo"
        Me.txt_SealNo.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_SealNo.Size = New System.Drawing.Size(361, 24)
        Me.txt_SealNo.TabIndex = 11
        Me.txt_SealNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_SealNo.TextBoxAutoComplete = False
        Me.txt_SealNo.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_SealNo.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_SealNo.TextEnabled = True
        Me.txt_SealNo.TextForeColor = System.Drawing.Color.Empty
        Me.txt_SealNo.TextMaxLength = 32767
        Me.txt_SealNo.TextMultiLine = False
        Me.txt_SealNo.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_SealNo.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_SealNo.UseSendTab = True
        '
        'txt_Article
        '
        Me.txt_Article.BackYesno = False
        Me.txt_Article.ButtonTitle = Nothing
        Me.txt_Article.Code = Nothing
        Me.txt_Article.Data = ""
        Me.txt_Article.DataDecimal = 0
        Me.txt_Article.DataLen = 0
        Me.txt_Article.DataValue = 0
        Me.txt_Article.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_Article.FormatDecimal = 0
        Me.txt_Article.FormatValue = False
        Me.txt_Article.LableBackColor = System.Drawing.Color.Empty
        Me.txt_Article.LableEnabled = True
        Me.txt_Article.LableFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_Article.LableForeColor = System.Drawing.Color.Black
        Me.txt_Article.LableTitle = "Article"
        Me.txt_Article.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Article.Location = New System.Drawing.Point(1, 207)
        Me.txt_Article.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Article.Name = "txt_Article"
        Me.txt_Article.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Article.Size = New System.Drawing.Size(361, 24)
        Me.txt_Article.TabIndex = 9
        Me.txt_Article.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Article.TextBoxAutoComplete = False
        Me.txt_Article.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Article.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_Article.TextEnabled = True
        Me.txt_Article.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Article.TextMaxLength = 32767
        Me.txt_Article.TextMultiLine = False
        Me.txt_Article.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Article.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Article.UseSendTab = True
        '
        'txt_Line
        '
        Me.txt_Line.BackYesno = False
        Me.txt_Line.ButtonTitle = Nothing
        Me.txt_Line.Code = Nothing
        Me.txt_Line.Data = ""
        Me.txt_Line.DataDecimal = 0
        Me.txt_Line.DataLen = 0
        Me.txt_Line.DataValue = 0
        Me.txt_Line.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_Line.FormatDecimal = 0
        Me.txt_Line.FormatValue = False
        Me.txt_Line.LableBackColor = System.Drawing.Color.Empty
        Me.txt_Line.LableEnabled = True
        Me.txt_Line.LableFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_Line.LableForeColor = System.Drawing.Color.Black
        Me.txt_Line.LableTitle = "Line"
        Me.txt_Line.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Line.Location = New System.Drawing.Point(1, 233)
        Me.txt_Line.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Line.Name = "txt_Line"
        Me.txt_Line.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Line.Size = New System.Drawing.Size(361, 24)
        Me.txt_Line.TabIndex = 10
        Me.txt_Line.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Line.TextBoxAutoComplete = False
        Me.txt_Line.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Line.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_Line.TextEnabled = True
        Me.txt_Line.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Line.TextMaxLength = 32767
        Me.txt_Line.TextMultiLine = False
        Me.txt_Line.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Line.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Line.UseSendTab = True
        '
        'txt_ColorName
        '
        Me.txt_ColorName.BackYesno = False
        Me.txt_ColorName.ButtonTitle = Nothing
        Me.txt_ColorName.Code = Nothing
        Me.txt_ColorName.Data = ""
        Me.txt_ColorName.DataDecimal = 0
        Me.txt_ColorName.DataLen = 0
        Me.txt_ColorName.DataValue = 0
        Me.txt_ColorName.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_ColorName.FormatDecimal = 0
        Me.txt_ColorName.FormatValue = False
        Me.txt_ColorName.LableBackColor = System.Drawing.Color.Empty
        Me.txt_ColorName.LableEnabled = True
        Me.txt_ColorName.LableFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_ColorName.LableForeColor = System.Drawing.Color.Black
        Me.txt_ColorName.LableTitle = "Color Name"
        Me.txt_ColorName.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_ColorName.Location = New System.Drawing.Point(1, 259)
        Me.txt_ColorName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ColorName.Name = "txt_ColorName"
        Me.txt_ColorName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ColorName.Size = New System.Drawing.Size(361, 24)
        Me.txt_ColorName.TabIndex = 12
        Me.txt_ColorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ColorName.TextBoxAutoComplete = False
        Me.txt_ColorName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ColorName.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_ColorName.TextEnabled = True
        Me.txt_ColorName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ColorName.TextMaxLength = 32767
        Me.txt_ColorName.TextMultiLine = False
        Me.txt_ColorName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ColorName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ColorName.UseSendTab = True
        '
        'txt_MoldName
        '
        Me.txt_MoldName.BackYesno = False
        Me.txt_MoldName.ButtonTitle = Nothing
        Me.txt_MoldName.Code = Nothing
        Me.txt_MoldName.Data = ""
        Me.txt_MoldName.DataDecimal = 0
        Me.txt_MoldName.DataLen = 0
        Me.txt_MoldName.DataValue = 0
        Me.txt_MoldName.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_MoldName.FormatDecimal = 0
        Me.txt_MoldName.FormatValue = False
        Me.txt_MoldName.LableBackColor = System.Drawing.Color.Empty
        Me.txt_MoldName.LableEnabled = True
        Me.txt_MoldName.LableFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_MoldName.LableForeColor = System.Drawing.Color.Black
        Me.txt_MoldName.LableTitle = "Mold Name"
        Me.txt_MoldName.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_MoldName.Location = New System.Drawing.Point(1, 285)
        Me.txt_MoldName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MoldName.Name = "txt_MoldName"
        Me.txt_MoldName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MoldName.Size = New System.Drawing.Size(361, 24)
        Me.txt_MoldName.TabIndex = 13
        Me.txt_MoldName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MoldName.TextBoxAutoComplete = False
        Me.txt_MoldName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MoldName.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_MoldName.TextEnabled = True
        Me.txt_MoldName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MoldName.TextMaxLength = 32767
        Me.txt_MoldName.TextMultiLine = False
        Me.txt_MoldName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MoldName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MoldName.UseSendTab = True
        '
        'txt_LastName
        '
        Me.txt_LastName.BackYesno = False
        Me.txt_LastName.ButtonTitle = Nothing
        Me.txt_LastName.Code = Nothing
        Me.txt_LastName.Data = ""
        Me.txt_LastName.DataDecimal = 0
        Me.txt_LastName.DataLen = 0
        Me.txt_LastName.DataValue = 0
        Me.txt_LastName.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_LastName.FormatDecimal = 0
        Me.txt_LastName.FormatValue = False
        Me.txt_LastName.LableBackColor = System.Drawing.Color.Empty
        Me.txt_LastName.LableEnabled = True
        Me.txt_LastName.LableFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_LastName.LableForeColor = System.Drawing.Color.Black
        Me.txt_LastName.LableTitle = "Last Name"
        Me.txt_LastName.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_LastName.Location = New System.Drawing.Point(1, 311)
        Me.txt_LastName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_LastName.Name = "txt_LastName"
        Me.txt_LastName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_LastName.Size = New System.Drawing.Size(361, 24)
        Me.txt_LastName.TabIndex = 14
        Me.txt_LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_LastName.TextBoxAutoComplete = False
        Me.txt_LastName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_LastName.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_LastName.TextEnabled = True
        Me.txt_LastName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_LastName.TextMaxLength = 32767
        Me.txt_LastName.TextMultiLine = False
        Me.txt_LastName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_LastName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_LastName.UseSendTab = True
        '
        'txt_Incharge
        '
        Me.txt_Incharge.BackYesno = False
        Me.txt_Incharge.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_Incharge.ButtonEnabled = True
        Me.txt_Incharge.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_Incharge.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_Incharge.ButtonName = Nothing
        Me.txt_Incharge.ButtonTitle = "Incharge"
        Me.txt_Incharge.Code = ""
        Me.txt_Incharge.Data = ""
        Me.txt_Incharge.DataDecimal = 0
        Me.txt_Incharge.DataLen = 0
        Me.txt_Incharge.DataValue = 0
        Me.txt_Incharge.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_Incharge.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Incharge.Location = New System.Drawing.Point(1, 337)
        Me.txt_Incharge.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Incharge.Name = "txt_Incharge"
        Me.txt_Incharge.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Incharge.Size = New System.Drawing.Size(361, 24)
        Me.txt_Incharge.TabIndex = 15
        Me.txt_Incharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Incharge.TextBoxAutoComplete = False
        Me.txt_Incharge.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Incharge.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_Incharge.TextEnabled = True
        Me.txt_Incharge.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Incharge.TextMaxLength = 32767
        Me.txt_Incharge.TextMultiLine = False
        Me.txt_Incharge.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Incharge.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Incharge.UseSendTab = True
        '
        'pCheckUse
        '
        Me.pCheckUse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pCheckUse.Controls.Add(Me.chk_CheckUse2)
        Me.pCheckUse.Controls.Add(Me.chk_CheckUse1)
        Me.pCheckUse.Controls.Add(Me.txt_CheckUse)
        Me.pCheckUse.Location = New System.Drawing.Point(1, 363)
        Me.pCheckUse.Margin = New System.Windows.Forms.Padding(1)
        Me.pCheckUse.Name = "pCheckUse"
        Me.pCheckUse.Size = New System.Drawing.Size(361, 28)
        Me.pCheckUse.TabIndex = 17
        Me.pCheckUse.Visible = False
        '
        'chk_CheckUse2
        '
        Me.chk_CheckUse2.ButtonTitle = Nothing
        Me.chk_CheckUse2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckUse2.Location = New System.Drawing.Point(260, 1)
        Me.chk_CheckUse2.Name = "chk_CheckUse2"
        Me.chk_CheckUse2.Size = New System.Drawing.Size(96, 24)
        Me.chk_CheckUse2.TabIndex = 3
        Me.chk_CheckUse2.Text = "No"
        Me.chk_CheckUse2.UseVisualStyleBackColor = True
        '
        'chk_CheckUse1
        '
        Me.chk_CheckUse1.ButtonTitle = Nothing
        Me.chk_CheckUse1.Checked = True
        Me.chk_CheckUse1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_CheckUse1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckUse1.Location = New System.Drawing.Point(130, 1)
        Me.chk_CheckUse1.Name = "chk_CheckUse1"
        Me.chk_CheckUse1.Size = New System.Drawing.Size(100, 24)
        Me.chk_CheckUse1.TabIndex = 2
        Me.chk_CheckUse1.Text = "Yes"
        Me.chk_CheckUse1.UseVisualStyleBackColor = True
        '
        'txt_CheckUse
        '
        Me.txt_CheckUse.BackYesno = False
        Me.txt_CheckUse.ButtonTitle = Nothing
        Me.txt_CheckUse.Code = Nothing
        Me.txt_CheckUse.Data = ""
        Me.txt_CheckUse.DataDecimal = 0
        Me.txt_CheckUse.DataLen = 0
        Me.txt_CheckUse.DataValue = 0
        Me.txt_CheckUse.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_CheckUse.FormatDecimal = 0
        Me.txt_CheckUse.FormatValue = False
        Me.txt_CheckUse.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_CheckUse.LableEnabled = True
        Me.txt_CheckUse.LableFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_CheckUse.LableForeColor = System.Drawing.Color.Black
        Me.txt_CheckUse.LableTitle = "Use"
        Me.txt_CheckUse.Layoutpercent = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_CheckUse.Location = New System.Drawing.Point(1, 1)
        Me.txt_CheckUse.Name = "txt_CheckUse"
        Me.txt_CheckUse.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CheckUse.Size = New System.Drawing.Size(120, 24)
        Me.txt_CheckUse.TabIndex = 1
        Me.txt_CheckUse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_CheckUse.TextBoxAutoComplete = False
        Me.txt_CheckUse.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_CheckUse.TextBoxFont = Nothing
        Me.txt_CheckUse.TextEnabled = True
        Me.txt_CheckUse.TextForeColor = System.Drawing.Color.Empty
        Me.txt_CheckUse.TextMaxLength = 32767
        Me.txt_CheckUse.TextMultiLine = False
        Me.txt_CheckUse.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CheckUse.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_CheckUse.UseSendTab = True
        '
        'Gadget005
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Gadget005"
        Me.Size = New System.Drawing.Size(404, 444)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.pCheckUse.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txt_SdateEdate As PSMGlobal.SelectPeaceCalDou
    Friend WithEvents txt_GCODE As PSMGlobal.SelectMulti
    Friend WithEvents txt_cdSeason As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdFactory As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdLineGroup As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdLineProd As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_Article As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Line As PSMGlobal.SelectLabelText
    Friend WithEvents txt_SealNo As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ColorName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_MoldName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_LastName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Incharge As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents pCheckUse As System.Windows.Forms.Panel
    Friend WithEvents chk_CheckUse2 As PSMGlobal.PeaceCheckbox
    Friend WithEvents chk_CheckUse1 As PSMGlobal.PeaceCheckbox
    Friend WithEvents txt_CheckUse As PSMGlobal.SelectLabelText
    Friend WithEvents txt_CustomerName As PSMGlobal.SelectPeaceHLPButton

End Class
