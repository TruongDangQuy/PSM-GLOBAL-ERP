<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectPeaceOpen
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
        Me.Ppn_1 = New PSMGlobal.PeacePanel(Me.components)
        Me.SelectPeaceMaskText1 = New PSMGlobal.SelectPeaceMaskText()
        Me.psl_PONO = New PSMGlobal.SelectLabelSearch()
        Me.PeacePanel3 = New PSMGlobal.PeacePanel(Me.components)
        Me.PeaceRadioButton1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.PeaceRadioButton4 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.PeaceRadioButton3 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.PeaceRadioButton2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.SelectPeaceLable1 = New PSMGlobal.SelectPeaceLable()
        Me.pcm_YCHK = New PSMGlobal.SelectPeaceCombo()
        Me.pbt_IGCODE = New PSMGlobal.SelectPeaceHLPButton()
        Me.psl_ONAT = New PSMGlobal.SelectLabelSearch()
        Me.psl_STNO = New PSMGlobal.SelectLabelSearch()
        Me.SelectLabelSearch2 = New PSMGlobal.SelectLabelSearch()
        Me.Ppn_1.SuspendLayout()
        Me.PeacePanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ppn_1
        '
        Me.Ppn_1.Controls.Add(Me.SelectPeaceMaskText1)
        Me.Ppn_1.Controls.Add(Me.psl_PONO)
        Me.Ppn_1.Controls.Add(Me.PeacePanel3)
        Me.Ppn_1.Controls.Add(Me.SelectPeaceLable1)
        Me.Ppn_1.Controls.Add(Me.pcm_YCHK)
        Me.Ppn_1.Controls.Add(Me.pbt_IGCODE)
        Me.Ppn_1.Controls.Add(Me.psl_ONAT)
        Me.Ppn_1.Controls.Add(Me.psl_STNO)
        Me.Ppn_1.Controls.Add(Me.SelectLabelSearch2)
        Me.Ppn_1.Location = New System.Drawing.Point(3, 0)
        Me.Ppn_1.Margin = New System.Windows.Forms.Padding(0)
        Me.Ppn_1.Name = "Ppn_1"
        Me.Ppn_1.Size = New System.Drawing.Size(770, 200)
        Me.Ppn_1.TabIndex = 10
        '
        'SelectPeaceMaskText1
        '
        Me.SelectPeaceMaskText1.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectPeaceMaskText1.ButtonEnabled = True
        Me.SelectPeaceMaskText1.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectPeaceMaskText1.ButtonForeColor = System.Drawing.Color.Empty
        Me.SelectPeaceMaskText1.ButtonTitle = "FILENO"
        Me.SelectPeaceMaskText1.Code = ""
        Me.SelectPeaceMaskText1.Data = "        -   -"
        Me.SelectPeaceMaskText1.Location = New System.Drawing.Point(388, 160)
        Me.SelectPeaceMaskText1.Name = "SelectPeaceMaskText1"
        Me.SelectPeaceMaskText1.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.SelectPeaceMaskText1.SetTextFocus = True
        Me.SelectPeaceMaskText1.Size = New System.Drawing.Size(374, 30)
        Me.SelectPeaceMaskText1.TabIndex = 11
        Me.SelectPeaceMaskText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SelectPeaceMaskText1.TextBoxAutoComplete = False
        Me.SelectPeaceMaskText1.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SelectPeaceMaskText1.TextEnabled = True
        Me.SelectPeaceMaskText1.TextForeColor = System.Drawing.Color.Empty
        Me.SelectPeaceMaskText1.TextMask = "99999999-999-99"
        Me.SelectPeaceMaskText1.TextMaxLength = 32767
        Me.SelectPeaceMaskText1.TextMultiLine = False
        Me.SelectPeaceMaskText1.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SelectPeaceMaskText1.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SelectPeaceMaskText1.UseSendTab = True
        '
        'psl_PONO
        '
        Me.psl_PONO.ButtonBackColor = System.Drawing.Color.Empty
        Me.psl_PONO.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Flat
        Me.psl_PONO.ButtonEnabled = True
        Me.psl_PONO.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.psl_PONO.ButtonForeColor = System.Drawing.Color.Empty
        Me.psl_PONO.ButtonTitle = "PO #"
        Me.psl_PONO.Code = Nothing
        Me.psl_PONO.Data = Nothing
        Me.psl_PONO.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.psl_PONO.Location = New System.Drawing.Point(6, 96)
        Me.psl_PONO.Margin = New System.Windows.Forms.Padding(0)
        Me.psl_PONO.Name = "psl_PONO"
        Me.psl_PONO.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.psl_PONO.Size = New System.Drawing.Size(377, 30)
        Me.psl_PONO.TabIndex = 10
        Me.psl_PONO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.psl_PONO.TextBoxAutoComplete = False
        Me.psl_PONO.TextboxBackColor = System.Drawing.Color.Empty
        Me.psl_PONO.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.psl_PONO.TextEnabled = True
        Me.psl_PONO.TextForeColor = System.Drawing.Color.Empty
        Me.psl_PONO.TextMaxLength = 32767
        Me.psl_PONO.TextMultiLine = False
        Me.psl_PONO.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.psl_PONO.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.psl_PONO.UseSendTab = True
        '
        'PeacePanel3
        '
        Me.PeacePanel3.Controls.Add(Me.PeaceRadioButton1)
        Me.PeacePanel3.Controls.Add(Me.PeaceRadioButton4)
        Me.PeacePanel3.Controls.Add(Me.PeaceRadioButton3)
        Me.PeacePanel3.Controls.Add(Me.PeaceRadioButton2)
        Me.PeacePanel3.Location = New System.Drawing.Point(388, 39)
        Me.PeacePanel3.Name = "PeacePanel3"
        Me.PeacePanel3.Size = New System.Drawing.Size(374, 115)
        Me.PeacePanel3.TabIndex = 9
        '
        'PeaceRadioButton1
        '
        Me.PeaceRadioButton1.AutoSize = True
        Me.PeaceRadioButton1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceRadioButton1.Location = New System.Drawing.Point(28, 26)
        Me.PeaceRadioButton1.Name = "PeaceRadioButton1"
        Me.PeaceRadioButton1.Size = New System.Drawing.Size(71, 18)
        Me.PeaceRadioButton1.TabIndex = 8
        Me.PeaceRadioButton1.TabStop = True
        Me.PeaceRadioButton1.Text = "PAID BY"
        Me.PeaceRadioButton1.UseVisualStyleBackColor = True
        '
        'PeaceRadioButton4
        '
        Me.PeaceRadioButton4.AutoSize = True
        Me.PeaceRadioButton4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceRadioButton4.Location = New System.Drawing.Point(214, 69)
        Me.PeaceRadioButton4.Name = "PeaceRadioButton4"
        Me.PeaceRadioButton4.Size = New System.Drawing.Size(113, 18)
        Me.PeaceRadioButton4.TabIndex = 8
        Me.PeaceRadioButton4.TabStop = True
        Me.PeaceRadioButton4.Text = "SUPPLIER DATE"
        Me.PeaceRadioButton4.UseVisualStyleBackColor = True
        '
        'PeaceRadioButton3
        '
        Me.PeaceRadioButton3.AutoSize = True
        Me.PeaceRadioButton3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceRadioButton3.Location = New System.Drawing.Point(28, 69)
        Me.PeaceRadioButton3.Name = "PeaceRadioButton3"
        Me.PeaceRadioButton3.Size = New System.Drawing.Size(65, 18)
        Me.PeaceRadioButton3.TabIndex = 8
        Me.PeaceRadioButton3.TabStop = True
        Me.PeaceRadioButton3.Text = "ORIGIN"
        Me.PeaceRadioButton3.UseVisualStyleBackColor = True
        '
        'PeaceRadioButton2
        '
        Me.PeaceRadioButton2.AutoSize = True
        Me.PeaceRadioButton2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceRadioButton2.Location = New System.Drawing.Point(214, 26)
        Me.PeaceRadioButton2.Name = "PeaceRadioButton2"
        Me.PeaceRadioButton2.Size = New System.Drawing.Size(92, 18)
        Me.PeaceRadioButton2.TabIndex = 8
        Me.PeaceRadioButton2.TabStop = True
        Me.PeaceRadioButton2.Text = "YARN NAME"
        Me.PeaceRadioButton2.UseVisualStyleBackColor = True
        '
        'SelectPeaceLable1
        '
        Me.SelectPeaceLable1.ButtonBackColor = System.Drawing.Color.Empty
        Me.SelectPeaceLable1.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectPeaceLable1.ButtonEnabled = True
        Me.SelectPeaceLable1.ButtonFont = Nothing
        Me.SelectPeaceLable1.ButtonForeColor = System.Drawing.Color.Empty
        Me.SelectPeaceLable1.ButtonTitle = Nothing
        Me.SelectPeaceLable1.Code = Nothing
        Me.SelectPeaceLable1.Data = "SORT"
        Me.SelectPeaceLable1.LabelFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SelectPeaceLable1.LabelForeColor = System.Drawing.Color.Empty
        Me.SelectPeaceLable1.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SelectPeaceLable1.Location = New System.Drawing.Point(388, 3)
        Me.SelectPeaceLable1.Name = "SelectPeaceLable1"
        Me.SelectPeaceLable1.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.SelectPeaceLable1.Size = New System.Drawing.Size(374, 30)
        Me.SelectPeaceLable1.TabIndex = 7
        Me.SelectPeaceLable1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SelectPeaceLable1.UseSendTab = True
        '
        'pcm_YCHK
        '
        Me.pcm_YCHK.ButtonBackColor = System.Drawing.Color.Empty
        Me.pcm_YCHK.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pcm_YCHK.ButtonEnabled = True
        Me.pcm_YCHK.ButtonFont = Nothing
        Me.pcm_YCHK.ButtonForeColor = System.Drawing.Color.Empty
        Me.pcm_YCHK.ButtonTitle = "YARN TYPE"
        Me.pcm_YCHK.Location = New System.Drawing.Point(6, 128)
        Me.pcm_YCHK.Margin = New System.Windows.Forms.Padding(0)
        Me.pcm_YCHK.Name = "pcm_YCHK"
        Me.pcm_YCHK.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.pcm_YCHK.Size = New System.Drawing.Size(377, 29)
        Me.pcm_YCHK.TabIndex = 6
        Me.pcm_YCHK.TextBoxAutoComplete = False
        Me.pcm_YCHK.UseSendTab = True
        '
        'pbt_IGCODE
        '
        Me.pbt_IGCODE.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pbt_IGCODE.ButtonEnabled = True
        Me.pbt_IGCODE.ButtonFont = Nothing
        Me.pbt_IGCODE.ButtonForeColor = System.Drawing.Color.Empty
        Me.pbt_IGCODE.ButtonName = Nothing
        Me.pbt_IGCODE.ButtonTitle = "SUPPLIER"
        Me.pbt_IGCODE.Code = Nothing
        Me.pbt_IGCODE.Data = Nothing
        Me.pbt_IGCODE.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.pbt_IGCODE.Location = New System.Drawing.Point(6, 160)
        Me.pbt_IGCODE.Margin = New System.Windows.Forms.Padding(0)
        Me.pbt_IGCODE.Name = "pbt_IGCODE"
        Me.pbt_IGCODE.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.pbt_IGCODE.Size = New System.Drawing.Size(377, 30)
        Me.pbt_IGCODE.TabIndex = 5
        Me.pbt_IGCODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.pbt_IGCODE.TextBoxAutoComplete = False
        Me.pbt_IGCODE.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.pbt_IGCODE.TextEnabled = True
        Me.pbt_IGCODE.TextForeColor = System.Drawing.Color.Empty
        Me.pbt_IGCODE.TextMaxLength = 32767
        Me.pbt_IGCODE.TextMultiLine = True
        Me.pbt_IGCODE.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.pbt_IGCODE.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.pbt_IGCODE.UseSendTab = True
        '
        'psl_ONAT
        '
        Me.psl_ONAT.ButtonBackColor = System.Drawing.Color.Empty
        Me.psl_ONAT.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Flat
        Me.psl_ONAT.ButtonEnabled = True
        Me.psl_ONAT.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.psl_ONAT.ButtonForeColor = System.Drawing.Color.Empty
        Me.psl_ONAT.ButtonTitle = "ORIGIN"
        Me.psl_ONAT.Code = Nothing
        Me.psl_ONAT.Data = Nothing
        Me.psl_ONAT.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.psl_ONAT.Location = New System.Drawing.Point(6, 65)
        Me.psl_ONAT.Margin = New System.Windows.Forms.Padding(0)
        Me.psl_ONAT.Name = "psl_ONAT"
        Me.psl_ONAT.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.psl_ONAT.Size = New System.Drawing.Size(377, 30)
        Me.psl_ONAT.TabIndex = 3
        Me.psl_ONAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.psl_ONAT.TextBoxAutoComplete = False
        Me.psl_ONAT.TextboxBackColor = System.Drawing.Color.Empty
        Me.psl_ONAT.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.psl_ONAT.TextEnabled = True
        Me.psl_ONAT.TextForeColor = System.Drawing.Color.Empty
        Me.psl_ONAT.TextMaxLength = 32767
        Me.psl_ONAT.TextMultiLine = False
        Me.psl_ONAT.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.psl_ONAT.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.psl_ONAT.UseSendTab = True
        '
        'psl_STNO
        '
        Me.psl_STNO.ButtonBackColor = System.Drawing.Color.Empty
        Me.psl_STNO.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Flat
        Me.psl_STNO.ButtonEnabled = True
        Me.psl_STNO.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.psl_STNO.ButtonForeColor = System.Drawing.Color.Empty
        Me.psl_STNO.ButtonTitle = "STYLE"
        Me.psl_STNO.Code = Nothing
        Me.psl_STNO.Data = Nothing
        Me.psl_STNO.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.psl_STNO.Location = New System.Drawing.Point(6, 34)
        Me.psl_STNO.Margin = New System.Windows.Forms.Padding(0)
        Me.psl_STNO.Name = "psl_STNO"
        Me.psl_STNO.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.psl_STNO.Size = New System.Drawing.Size(377, 30)
        Me.psl_STNO.TabIndex = 2
        Me.psl_STNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.psl_STNO.TextBoxAutoComplete = False
        Me.psl_STNO.TextboxBackColor = System.Drawing.Color.Empty
        Me.psl_STNO.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.psl_STNO.TextEnabled = True
        Me.psl_STNO.TextForeColor = System.Drawing.Color.Empty
        Me.psl_STNO.TextMaxLength = 32767
        Me.psl_STNO.TextMultiLine = False
        Me.psl_STNO.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.psl_STNO.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.psl_STNO.UseSendTab = True
        '
        'SelectLabelSearch2
        '
        Me.SelectLabelSearch2.ButtonBackColor = System.Drawing.Color.Empty
        Me.SelectLabelSearch2.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectLabelSearch2.ButtonEnabled = True
        Me.SelectLabelSearch2.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SelectLabelSearch2.ButtonForeColor = System.Drawing.Color.Empty
        Me.SelectLabelSearch2.ButtonTitle = "BUYER"
        Me.SelectLabelSearch2.Code = ""
        Me.SelectLabelSearch2.Data = ""
        Me.SelectLabelSearch2.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.SelectLabelSearch2.Location = New System.Drawing.Point(6, 3)
        Me.SelectLabelSearch2.Margin = New System.Windows.Forms.Padding(0)
        Me.SelectLabelSearch2.Name = "SelectLabelSearch2"
        Me.SelectLabelSearch2.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.SelectLabelSearch2.Size = New System.Drawing.Size(377, 30)
        Me.SelectLabelSearch2.TabIndex = 1
        Me.SelectLabelSearch2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SelectLabelSearch2.TextBoxAutoComplete = False
        Me.SelectLabelSearch2.TextboxBackColor = System.Drawing.Color.Empty
        Me.SelectLabelSearch2.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.SelectLabelSearch2.TextEnabled = True
        Me.SelectLabelSearch2.TextForeColor = System.Drawing.Color.Empty
        Me.SelectLabelSearch2.TextMaxLength = 32767
        Me.SelectLabelSearch2.TextMultiLine = False
        Me.SelectLabelSearch2.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SelectLabelSearch2.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SelectLabelSearch2.UseSendTab = True
        '
        'SelectPeaceOpen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.Ppn_1)
        Me.Name = "SelectPeaceOpen"
        Me.Size = New System.Drawing.Size(770, 200)
        Me.Ppn_1.ResumeLayout(False)
        Me.PeacePanel3.ResumeLayout(False)
        Me.PeacePanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ppn_1 As PSMGlobal.PeacePanel
    Friend WithEvents SelectPeaceMaskText1 As PSMGlobal.SelectPeaceMaskText
    Friend WithEvents psl_PONO As PSMGlobal.SelectLabelSearch
    Friend WithEvents PeacePanel3 As PSMGlobal.PeacePanel
    Friend WithEvents PeaceRadioButton1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents PeaceRadioButton4 As PSMGlobal.PeaceRadioButton
    Friend WithEvents PeaceRadioButton3 As PSMGlobal.PeaceRadioButton
    Friend WithEvents PeaceRadioButton2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents SelectPeaceLable1 As PSMGlobal.SelectPeaceLable
    Friend WithEvents pcm_YCHK As PSMGlobal.SelectPeaceCombo
    Friend WithEvents pbt_IGCODE As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents psl_ONAT As PSMGlobal.SelectLabelSearch
    Friend WithEvents psl_STNO As PSMGlobal.SelectLabelSearch
    Friend WithEvents SelectLabelSearch2 As PSMGlobal.SelectLabelSearch

End Class
