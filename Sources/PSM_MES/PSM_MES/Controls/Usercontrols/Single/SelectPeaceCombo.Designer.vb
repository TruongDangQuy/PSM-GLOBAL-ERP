<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectPeaceCombo
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
        Me.lbl_name = New PSMGlobal.PeaceLabel(Me.components)
        Me.PeaceCombobox1 = New PSMGlobal.PeaceCombobox(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.66!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.34!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_name, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PeaceCombobox1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(478, 28)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'lbl_name
        '
        Me.lbl_name.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_name.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_name.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_name.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lbl_name.ButtonTitle = Nothing
        Me.lbl_name.Code = ""
        Me.lbl_name.Data = ""
        Me.lbl_name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_name.DTDec = 0
        Me.lbl_name.DTLen = 0
        Me.lbl_name.DTValue = 0
        Me.lbl_name.Location = New System.Drawing.Point(0, 0)
        Me.lbl_name.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.NoClear = False
        Me.lbl_name.Size = New System.Drawing.Size(159, 28)
        Me.lbl_name.TabIndex = 3
        Me.lbl_name.Tag = ""
        Me.lbl_name.Text = "LABLE NAME"
        Me.lbl_name.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'PeaceCombobox1
        '
        Me.PeaceCombobox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceCombobox1.DTDec = 0
        Me.PeaceCombobox1.DTLen = 0
        Me.PeaceCombobox1.DTValue = 0
        Me.PeaceCombobox1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.PeaceCombobox1.FormattingEnabled = True
        Me.PeaceCombobox1.InSelected = -1
        Me.PeaceCombobox1.ListIndex = 0
        Me.PeaceCombobox1.Location = New System.Drawing.Point(160, 0)
        Me.PeaceCombobox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PeaceCombobox1.Name = "PeaceCombobox1"
        Me.PeaceCombobox1.NoClear = False
        Me.PeaceCombobox1.Size = New System.Drawing.Size(318, 27)
        Me.PeaceCombobox1.TabIndex = 1
        '
        'SelectPeaceCombo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "SelectPeaceCombo"
        Me.Size = New System.Drawing.Size(478, 28)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PeaceCombobox1 As PSMGlobal.PeaceCombobox
    Public WithEvents lbl_name As PSMGlobal.PeaceLabel

End Class
