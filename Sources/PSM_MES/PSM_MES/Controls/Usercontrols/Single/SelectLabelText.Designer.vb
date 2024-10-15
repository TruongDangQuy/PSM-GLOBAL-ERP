<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectLabelText
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
        Me.PeaceTextbox1 = New PSMGlobal.PeaceTextbox(Me.components)
        Me.lbl_name = New PSMGlobal.PeaceLabel(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PeaceTextbox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.66!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.34!))
        Me.TableLayoutPanel1.Controls.Add(Me.PeaceTextbox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_name, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(410, 29)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'PeaceTextbox1
        '
        Me.PeaceTextbox1.Code = Nothing
        Me.PeaceTextbox1.Data = ""
        Me.PeaceTextbox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceTextbox1.DTDec = 0
        Me.PeaceTextbox1.DTLen = 0
        Me.PeaceTextbox1.DTValue = 0
        Me.PeaceTextbox1.EditValue = ""
        Me.PeaceTextbox1.Location = New System.Drawing.Point(138, 0)
        Me.PeaceTextbox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PeaceTextbox1.MaxLength = 22
        Me.PeaceTextbox1.MultiLine = True
        Me.PeaceTextbox1.Name = "PeaceTextbox1"
        Me.PeaceTextbox1.NoClear = False
        Me.PeaceTextbox1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceTextbox1.Properties.Appearance.Options.UseFont = True
        Me.PeaceTextbox1.Properties.AutoHeight = False
        Me.PeaceTextbox1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeaceTextbox1.Properties.ValidateOnEnterKey = True
        Me.PeaceTextbox1.ScrollBars = False
        Me.PeaceTextbox1.Size = New System.Drawing.Size(272, 29)
        Me.PeaceTextbox1.TabIndex = 1
        Me.PeaceTextbox1.TextAlign = 0
        '
        'lbl_name
        '
        Me.lbl_name.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_name.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_name.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
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
        Me.lbl_name.Size = New System.Drawing.Size(137, 29)
        Me.lbl_name.TabIndex = 2
        Me.lbl_name.Tag = ""
        Me.lbl_name.Text = "LABLE NAME"
        Me.lbl_name.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'SelectLabelText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.Name = "SelectLabelText"
        Me.Size = New System.Drawing.Size(410, 29)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PeaceTextbox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents PeaceTextbox1 As PSMGlobal.PeaceTextbox
    Public WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents lbl_name As PSMGlobal.PeaceLabel

End Class
