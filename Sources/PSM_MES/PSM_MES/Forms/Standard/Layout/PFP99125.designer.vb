<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PFP99125
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PFP99125))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_FormName = New PSMGlobal.SelectLabelText()
        Me.txt_GroupUser = New PSMGlobal.SelectPeaceHLPButton()
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_FormName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_GroupUser, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmd_OK, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(309, 88)
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
        Me.txt_FormName.TextEnabled = True
        Me.txt_FormName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_FormName.TextMaxLength = 32767
        Me.txt_FormName.TextMultiLine = True
        Me.txt_FormName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_FormName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_FormName.UseSendTab = True
        '
        'txt_GroupUser
        '
        Me.txt_GroupUser.BackYesno = False
        Me.txt_GroupUser.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_GroupUser.ButtonEnabled = True
        Me.txt_GroupUser.ButtonFont = Nothing
        Me.txt_GroupUser.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_GroupUser.ButtonName = ""
        Me.txt_GroupUser.ButtonTitle = "User Group"
        Me.txt_GroupUser.Code = ""
        Me.txt_GroupUser.Data = ""
        Me.txt_GroupUser.DataDecimal = 0
        Me.txt_GroupUser.DataLen = 0
        Me.txt_GroupUser.DataValue = 0
        Me.txt_GroupUser.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_GroupUser.Location = New System.Drawing.Point(0, 29)
        Me.txt_GroupUser.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_GroupUser.Name = "txt_GroupUser"
        Me.txt_GroupUser.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_GroupUser.Size = New System.Drawing.Size(309, 29)
        Me.txt_GroupUser.TabIndex = 7
        Me.txt_GroupUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_GroupUser.TextBoxAutoComplete = False
        Me.txt_GroupUser.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_GroupUser.TextBoxFont = New System.Drawing.Font("Arial", 9.0!)
        Me.txt_GroupUser.TextEnabled = True
        Me.txt_GroupUser.TextForeColor = System.Drawing.Color.Empty
        Me.txt_GroupUser.TextMaxLength = 32767
        Me.txt_GroupUser.TextMultiLine = True
        Me.txt_GroupUser.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_GroupUser.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_GroupUser.UseSendTab = True
        '
        'cmd_OK
        '
        Me.cmd_OK.BackColor = System.Drawing.Color.White
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmd_OK.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Image = CType(resources.GetObject("cmd_OK.Image"), System.Drawing.Image)
        Me.cmd_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_OK.Location = New System.Drawing.Point(103, 61)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(203, 24)
        Me.cmd_OK.TabIndex = 8
        Me.cmd_OK.Text = "OK(&K)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'OPENLAYOUT_FORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 88)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.KeyPreview = True
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "OPENLAYOUT_FORM"
        Me.Text = "OPEN LAYOUT"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txt_FormName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_GroupUser As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
End Class
