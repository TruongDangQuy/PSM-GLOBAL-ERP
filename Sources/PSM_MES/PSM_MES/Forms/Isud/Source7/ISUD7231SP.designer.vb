<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD7231SP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD7231SP))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.txt_MaterialSimple = New PSMGlobal.SelectLabelText()
        Me.txt_MaterialCode = New PSMGlobal.SelectLabelText()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_Check9 = New PSMGlobal.SelectLabelText()
        Me.txt_MaterialName = New PSMGlobal.SelectLabelText()
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
        'txt_MaterialSimple
        '
        Me.txt_MaterialSimple.BackYesno = False
        Me.txt_MaterialSimple.ButtonTitle = Nothing
        Me.txt_MaterialSimple.Code = ""
        Me.txt_MaterialSimple.Data = ""
        Me.txt_MaterialSimple.DataDecimal = 0
        Me.txt_MaterialSimple.DataLen = 0
        Me.txt_MaterialSimple.DataValue = 0
        Me.txt_MaterialSimple.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaterialSimple.FormatDecimal = 0
        Me.txt_MaterialSimple.FormatValue = False
        Me.txt_MaterialSimple.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_MaterialSimple.LableEnabled = True
        Me.txt_MaterialSimple.LableFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaterialSimple.LableForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_MaterialSimple.LableTitle = "Print Name"
        Me.txt_MaterialSimple.Layoutpercent = New Decimal(New Integer() {206, 0, 0, 196608})
        Me.txt_MaterialSimple.Location = New System.Drawing.Point(5, 96)
        Me.txt_MaterialSimple.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MaterialSimple.Name = "txt_MaterialSimple"
        Me.txt_MaterialSimple.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MaterialSimple.Size = New System.Drawing.Size(610, 24)
        Me.txt_MaterialSimple.TabIndex = 4
        Me.txt_MaterialSimple.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MaterialSimple.TextBoxAutoComplete = False
        Me.txt_MaterialSimple.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MaterialSimple.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MaterialSimple.TextEnabled = True
        Me.txt_MaterialSimple.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MaterialSimple.TextMaxLength = 32767
        Me.txt_MaterialSimple.TextMultiLine = False
        Me.txt_MaterialSimple.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MaterialSimple.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MaterialSimple.UseSendTab = True
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
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txt_Check9)
        Me.Panel2.Controls.Add(Me.txt_MaterialName)
        Me.Panel2.Controls.Add(Me.txt_MaterialSimple)
        Me.Panel2.Controls.Add(Me.txt_MaterialCode)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(625, 125)
        Me.Panel2.TabIndex = 0
        '
        'txt_Check9
        '
        Me.txt_Check9.BackYesno = False
        Me.txt_Check9.ButtonTitle = Nothing
        Me.txt_Check9.Code = ""
        Me.txt_Check9.Data = ""
        Me.txt_Check9.DataDecimal = 0
        Me.txt_Check9.DataLen = 0
        Me.txt_Check9.DataValue = 0
        Me.txt_Check9.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Check9.FormatDecimal = 0
        Me.txt_Check9.FormatValue = False
        Me.txt_Check9.LableBackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_Check9.LableEnabled = True
        Me.txt_Check9.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Check9.LableForeColor = System.Drawing.Color.Black
        Me.txt_Check9.LableTitle = "Check Print"
        Me.txt_Check9.Layoutpercent = New Decimal(New Integer() {715, 0, 0, 196608})
        Me.txt_Check9.Location = New System.Drawing.Point(5, 62)
        Me.txt_Check9.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Check9.Name = "txt_Check9"
        Me.txt_Check9.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Check9.Size = New System.Drawing.Size(175, 24)
        Me.txt_Check9.TabIndex = 41
        Me.txt_Check9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Check9.TextBoxAutoComplete = False
        Me.txt_Check9.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Check9.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_Check9.TextEnabled = True
        Me.txt_Check9.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Check9.TextMaxLength = 32767
        Me.txt_Check9.TextMultiLine = False
        Me.txt_Check9.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Check9.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Check9.UseSendTab = True
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
        Me.txt_MaterialName.LableBackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_MaterialName.LableEnabled = True
        Me.txt_MaterialName.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaterialName.LableForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_MaterialName.LableTitle = "Name"
        Me.txt_MaterialName.Layoutpercent = New Decimal(New Integer() {206, 0, 0, 196608})
        Me.txt_MaterialName.Location = New System.Drawing.Point(5, 34)
        Me.txt_MaterialName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MaterialName.Name = "txt_MaterialName"
        Me.txt_MaterialName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MaterialName.Size = New System.Drawing.Size(610, 24)
        Me.txt_MaterialName.TabIndex = 10
        Me.txt_MaterialName.TabStop = False
        Me.txt_MaterialName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MaterialName.TextBoxAutoComplete = False
        Me.txt_MaterialName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MaterialName.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_MaterialName.TextEnabled = False
        Me.txt_MaterialName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MaterialName.TextMaxLength = 32767
        Me.txt_MaterialName.TextMultiLine = False
        Me.txt_MaterialName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MaterialName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MaterialName.UseSendTab = True
        '
        'ISUD7231SP
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(625, 163)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ISUD7231SP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MATERIAL CODE PROCESSING (ISUD7231SP)"
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_MaterialSimple As PSMGlobal.SelectLabelText
    Friend WithEvents txt_MaterialCode As PSMGlobal.SelectLabelText
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_MaterialName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Check9 As PSMGlobal.SelectLabelText
End Class
