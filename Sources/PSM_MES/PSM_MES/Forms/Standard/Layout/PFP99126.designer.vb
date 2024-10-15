<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PFP99126
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_FormName = New PSMGlobal.SelectLabelText()
        Me.txt_Remark = New PSMGlobal.SelectLabelText()
        Me.txt_Version = New PSMGlobal.SelectLabelText()
        Me.txt_Date = New PSMGlobal.SelectPeaceCalSin()
        Me.PeacePanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PeacePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_FormName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Remark, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Version, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Date, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PeacePanel1, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(608, 88)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txt_FormName
        '
        Me.txt_FormName.BackYesno = False
        Me.txt_FormName.ButtonTitle = Nothing
        Me.txt_FormName.Code = Nothing
        Me.txt_FormName.Data = Nothing
        Me.txt_FormName.DataDecimal = 0
        Me.txt_FormName.DataLen = 0
        Me.txt_FormName.DataValue = 0
        Me.txt_FormName.FormatDecimal = 0
        Me.txt_FormName.FormatValue = False
        Me.txt_FormName.LableBackColor = System.Drawing.Color.Empty
        Me.txt_FormName.LableEnabled = True
        Me.txt_FormName.LableFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_FormName.LableForeColor = System.Drawing.Color.Black
        Me.txt_FormName.LableTitle = "Form Name"
        Me.txt_FormName.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_FormName.Location = New System.Drawing.Point(3, 3)
        Me.txt_FormName.Name = "txt_FormName"
        Me.txt_FormName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_FormName.Size = New System.Drawing.Size(298, 23)
        Me.txt_FormName.TabIndex = 0
        Me.txt_FormName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_FormName.TextBoxAutoComplete = False
        Me.txt_FormName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_FormName.TextBoxFont = New System.Drawing.Font("Arial", 9.0!)
        Me.txt_FormName.TextEnabled = False
        Me.txt_FormName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_FormName.TextMaxLength = 32767
        Me.txt_FormName.TextMultiLine = True
        Me.txt_FormName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_FormName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_FormName.UseSendTab = True
        '
        'txt_Remark
        '
        Me.txt_Remark.BackYesno = False
        Me.txt_Remark.ButtonTitle = Nothing
        Me.txt_Remark.Code = Nothing
        Me.txt_Remark.Data = Nothing
        Me.txt_Remark.DataDecimal = 0
        Me.txt_Remark.DataLen = 0
        Me.txt_Remark.DataValue = 0
        Me.txt_Remark.FormatDecimal = 0
        Me.txt_Remark.FormatValue = False
        Me.txt_Remark.LableBackColor = System.Drawing.Color.Empty
        Me.txt_Remark.LableEnabled = True
        Me.txt_Remark.LableFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Remark.LableForeColor = System.Drawing.Color.Black
        Me.txt_Remark.LableTitle = "Remark"
        Me.txt_Remark.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Remark.Location = New System.Drawing.Point(3, 32)
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Remark.Size = New System.Drawing.Size(298, 23)
        Me.txt_Remark.TabIndex = 1
        Me.txt_Remark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Remark.TextBoxAutoComplete = False
        Me.txt_Remark.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Remark.TextBoxFont = New System.Drawing.Font("Arial", 9.0!)
        Me.txt_Remark.TextEnabled = True
        Me.txt_Remark.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Remark.TextMaxLength = 32767
        Me.txt_Remark.TextMultiLine = True
        Me.txt_Remark.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Remark.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Remark.UseSendTab = True
        '
        'txt_Version
        '
        Me.txt_Version.BackYesno = False
        Me.txt_Version.ButtonTitle = Nothing
        Me.txt_Version.Code = Nothing
        Me.txt_Version.Data = Nothing
        Me.txt_Version.DataDecimal = 0
        Me.txt_Version.DataLen = 0
        Me.txt_Version.DataValue = 0
        Me.txt_Version.FormatDecimal = 0
        Me.txt_Version.FormatValue = False
        Me.txt_Version.LableBackColor = System.Drawing.Color.Empty
        Me.txt_Version.LableEnabled = True
        Me.txt_Version.LableFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Version.LableForeColor = System.Drawing.Color.Black
        Me.txt_Version.LableTitle = "Version"
        Me.txt_Version.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Version.Location = New System.Drawing.Point(307, 3)
        Me.txt_Version.Name = "txt_Version"
        Me.txt_Version.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Version.Size = New System.Drawing.Size(298, 23)
        Me.txt_Version.TabIndex = 2
        Me.txt_Version.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Version.TextBoxAutoComplete = False
        Me.txt_Version.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Version.TextBoxFont = New System.Drawing.Font("Arial", 9.0!)
        Me.txt_Version.TextEnabled = True
        Me.txt_Version.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Version.TextMaxLength = 32767
        Me.txt_Version.TextMultiLine = True
        Me.txt_Version.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Version.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Version.UseSendTab = True
        '
        'txt_Date
        '
        Me.txt_Date.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_Date.ButtonEnabled = False
        Me.txt_Date.ButtonFont = New System.Drawing.Font("Arial", 9.0!)
        Me.txt_Date.ButtonName = Nothing
        Me.txt_Date.ButtonTitle = "DATE"
        Me.txt_Date.Code = ""
        Me.txt_Date.Data = ""
        Me.txt_Date.DataDecimal = 0
        Me.txt_Date.DataLen = 0
        Me.txt_Date.DataValue = 0
        Me.txt_Date.FormatDecimal = 0
        Me.txt_Date.FormatValue = False
        Me.txt_Date.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Date.Location = New System.Drawing.Point(304, 29)
        Me.txt_Date.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_Date.Name = "txt_Date"
        Me.txt_Date.Size = New System.Drawing.Size(304, 28)
        Me.txt_Date.TabIndex = 3
        Me.txt_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Date.TextBoxAutoComplete = False
        Me.txt_Date.TextBoxFont = New System.Drawing.Font("Arial", 9.0!)
        Me.txt_Date.TextEnabled = False
        Me.txt_Date.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Date.TextMaxLength = 32767
        Me.txt_Date.TextMultiLine = True
        Me.txt_Date.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple

        'PeacePanel1
        '
        Me.PeacePanel1.Code = ""
        Me.PeacePanel1.Controls.Add(Me.cmd_OK)
        Me.PeacePanel1.Data = ""
        Me.PeacePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeacePanel1.Location = New System.Drawing.Point(307, 61)
        Me.PeacePanel1.Name = "PeacePanel1"
        Me.PeacePanel1.Size = New System.Drawing.Size(298, 24)
        Me.PeacePanel1.TabIndex = 5
        Me.PeacePanel1.Tag = ""
        '
        'cmd_OK
        '
        Me.cmd_OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_OK.Code = ""
        Me.cmd_OK.Data = ""
        Me.cmd_OK.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmd_OK.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_OK.Location = New System.Drawing.Point(99, 0)
        Me.cmd_OK.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(199, 24)
        Me.cmd_OK.TabIndex = 4
        Me.cmd_OK.TabStop = False
        Me.cmd_OK.Tag = ""
        Me.cmd_OK.Text = "SAVE(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'SAVELAYOUT_FORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 88)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.KeyPreview = True
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "SAVELAYOUT_FORM"
        Me.Text = "SAVELAYOUT"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PeacePanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txt_FormName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Remark As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Version As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Date As PSMGlobal.SelectPeaceCalSin
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents PeacePanel1 As PSMGlobal.PeacePanel
End Class
