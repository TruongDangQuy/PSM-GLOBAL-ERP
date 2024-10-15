<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD7411D
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
        Me.Frame1 = New PSMGlobal.PeacePanel(Me.components)
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Block = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Password = New PSMGlobal.SelectLabelText()
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        CType(Me.Frame1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Block.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Code = ""
        Me.Frame1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Frame1.Data = ""
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame1.Location = New System.Drawing.Point(0, 38)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(733, 32)
        Me.Frame1.TabIndex = 6
        Me.Frame1.Tag = ""
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Controls.Add(Me.Block)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmd_OK)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmd_Cancel)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(729, 28)
        Me.FlowLayoutPanel1.TabIndex = 102
        '
        'Block
        '
        Me.Block.ColumnCount = 1
        Me.Block.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Block.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Block.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Block.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Block.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Block.Controls.Add(Me.txt_Password, 0, 0)
        Me.Block.Location = New System.Drawing.Point(1, 1)
        Me.Block.Margin = New System.Windows.Forms.Padding(1)
        Me.Block.Name = "Block"
        Me.Block.RowCount = 1
        Me.Block.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Block.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Block.Size = New System.Drawing.Size(719, 30)
        Me.Block.TabIndex = 109
        '
        'txt_Password
        '
        Me.txt_Password.BackYesno = False
        Me.txt_Password.ButtonTitle = Nothing
        Me.txt_Password.Code = Nothing
        Me.txt_Password.Data = ""
        Me.txt_Password.DataDecimal = 0
        Me.txt_Password.DataLen = 0
        Me.txt_Password.DataValue = 1
        Me.txt_Password.FormatDecimal = 0
        Me.txt_Password.FormatValue = False
        Me.txt_Password.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Password.LableEnabled = True
        Me.txt_Password.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Password.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Password.LableTitle = "Password"
        Me.txt_Password.Layoutpercent = New Decimal(New Integer() {168, 0, 0, 196608})
        Me.txt_Password.Location = New System.Drawing.Point(1, 1)
        Me.txt_Password.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Password.Size = New System.Drawing.Size(717, 27)
        Me.txt_Password.TabIndex = 1
        Me.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Password.TextBoxAutoComplete = False
        Me.txt_Password.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Password.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Password.TextEnabled = True
        Me.txt_Password.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Password.TextMaxLength = 32767
        Me.txt_Password.TextMultiLine = False
        Me.txt_Password.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Password.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Password.UseSendTab = True
        '
        'cmd_OK
        '
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_OK.ButtonTitle = Nothing
        Me.cmd_OK.Code = ""
        Me.cmd_OK.Data = ""
        Me.cmd_OK.Image = Global.PSMGlobal.My.Resources.Resources.Save_16x16
        Me.cmd_OK.ImageAlign = 16
        Me.cmd_OK.Location = New System.Drawing.Point(1, 33)
        Me.cmd_OK.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(359, 27)
        Me.cmd_OK.TabIndex = 0
        Me.cmd_OK.TabStop = False
        Me.cmd_OK.Tag = ""
        Me.cmd_OK.Text = "SAVE(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.ButtonTitle = Nothing
        Me.cmd_Cancel.Code = ""
        Me.cmd_Cancel.Data = ""
        Me.cmd_Cancel.Image = Global.PSMGlobal.My.Resources.Resources.Close_16x16
        Me.cmd_Cancel.ImageAlign = 16
        Me.cmd_Cancel.Location = New System.Drawing.Point(362, 33)
        Me.cmd_Cancel.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(358, 27)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.TabStop = False
        Me.cmd_Cancel.Tag = ""
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'ISUD7411D
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 70)
        Me.Controls.Add(Me.Frame1)
        Me.Name = "ISUD7411D"
        Me.Text = "ISUD7411D"
        Me.Controls.SetChildIndex(Me.Frame1, 0)
        CType(Me.Frame1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Block.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Frame1 As PSMGlobal.PeacePanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Block As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents txt_Password As PSMGlobal.SelectLabelText
End Class
