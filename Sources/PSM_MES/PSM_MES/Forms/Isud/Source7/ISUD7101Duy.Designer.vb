<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD7101Duy
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
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.chk_Option1 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_Option2 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_Option3 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_Option4 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_Option5 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_Option6 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_Option7 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_Option8 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_Option9 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_Option10 = New PSMGlobal.PeaceCheckbox(Me.components)
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
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(728, 90)
        Me.Frame1.TabIndex = 5
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
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(724, 86)
        Me.FlowLayoutPanel1.TabIndex = 102
        '
        'Block
        '
        Me.Block.ColumnCount = 5
        Me.Block.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Block.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Block.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Block.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Block.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Block.Controls.Add(Me.chk_Option1, 0, 0)
        Me.Block.Controls.Add(Me.chk_Option2, 1, 0)
        Me.Block.Controls.Add(Me.chk_Option3, 2, 0)
        Me.Block.Controls.Add(Me.chk_Option4, 3, 0)
        Me.Block.Controls.Add(Me.chk_Option5, 4, 0)
        Me.Block.Controls.Add(Me.chk_Option6, 0, 1)
        Me.Block.Controls.Add(Me.chk_Option7, 1, 1)
        Me.Block.Controls.Add(Me.chk_Option8, 2, 1)
        Me.Block.Controls.Add(Me.chk_Option9, 3, 1)
        Me.Block.Controls.Add(Me.chk_Option10, 4, 1)
        Me.Block.Location = New System.Drawing.Point(1, 1)
        Me.Block.Margin = New System.Windows.Forms.Padding(1)
        Me.Block.Name = "Block"
        Me.Block.RowCount = 2
        Me.Block.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Block.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Block.Size = New System.Drawing.Size(719, 52)
        Me.Block.TabIndex = 109
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
        Me.cmd_OK.Location = New System.Drawing.Point(1, 55)
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
        Me.cmd_Cancel.Location = New System.Drawing.Point(362, 55)
        Me.cmd_Cancel.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(358, 27)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.TabStop = False
        Me.cmd_Cancel.Tag = ""
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'chk_Option1
        '
        Me.chk_Option1.AutoSize = True
        Me.chk_Option1.ButtonTitle = Nothing
        Me.chk_Option1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chk_Option1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_Option1.ForeColor = System.Drawing.Color.Black
        Me.chk_Option1.Location = New System.Drawing.Point(3, 3)
        Me.chk_Option1.Name = "chk_Option1"
        Me.chk_Option1.Size = New System.Drawing.Size(137, 20)
        Me.chk_Option1.TabIndex = 1
        Me.chk_Option1.Text = "Option 1"
        Me.chk_Option1.UseVisualStyleBackColor = True
        '
        'chk_Option2
        '
        Me.chk_Option2.AutoSize = True
        Me.chk_Option2.ButtonTitle = Nothing
        Me.chk_Option2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chk_Option2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_Option2.ForeColor = System.Drawing.Color.Black
        Me.chk_Option2.Location = New System.Drawing.Point(146, 3)
        Me.chk_Option2.Name = "chk_Option2"
        Me.chk_Option2.Size = New System.Drawing.Size(137, 20)
        Me.chk_Option2.TabIndex = 1
        Me.chk_Option2.Text = "Option 2"
        Me.chk_Option2.UseVisualStyleBackColor = True
        '
        'chk_Option3
        '
        Me.chk_Option3.AutoSize = True
        Me.chk_Option3.ButtonTitle = Nothing
        Me.chk_Option3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chk_Option3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_Option3.ForeColor = System.Drawing.Color.Black
        Me.chk_Option3.Location = New System.Drawing.Point(289, 3)
        Me.chk_Option3.Name = "chk_Option3"
        Me.chk_Option3.Size = New System.Drawing.Size(137, 20)
        Me.chk_Option3.TabIndex = 1
        Me.chk_Option3.Text = "Option 3"
        Me.chk_Option3.UseVisualStyleBackColor = True
        '
        'chk_Option4
        '
        Me.chk_Option4.AutoSize = True
        Me.chk_Option4.ButtonTitle = Nothing
        Me.chk_Option4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chk_Option4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_Option4.ForeColor = System.Drawing.Color.Black
        Me.chk_Option4.Location = New System.Drawing.Point(432, 3)
        Me.chk_Option4.Name = "chk_Option4"
        Me.chk_Option4.Size = New System.Drawing.Size(137, 20)
        Me.chk_Option4.TabIndex = 1
        Me.chk_Option4.Text = "Option 4"
        Me.chk_Option4.UseVisualStyleBackColor = True
        '
        'chk_Option5
        '
        Me.chk_Option5.AutoSize = True
        Me.chk_Option5.ButtonTitle = Nothing
        Me.chk_Option5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chk_Option5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_Option5.ForeColor = System.Drawing.Color.Black
        Me.chk_Option5.Location = New System.Drawing.Point(575, 3)
        Me.chk_Option5.Name = "chk_Option5"
        Me.chk_Option5.Size = New System.Drawing.Size(141, 20)
        Me.chk_Option5.TabIndex = 1
        Me.chk_Option5.Text = "Option 5"
        Me.chk_Option5.UseVisualStyleBackColor = True
        '
        'chk_Option6
        '
        Me.chk_Option6.AutoSize = True
        Me.chk_Option6.ButtonTitle = Nothing
        Me.chk_Option6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chk_Option6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_Option6.ForeColor = System.Drawing.Color.Black
        Me.chk_Option6.Location = New System.Drawing.Point(3, 29)
        Me.chk_Option6.Name = "chk_Option6"
        Me.chk_Option6.Size = New System.Drawing.Size(137, 20)
        Me.chk_Option6.TabIndex = 1
        Me.chk_Option6.Text = "Option 6"
        Me.chk_Option6.UseVisualStyleBackColor = True
        '
        'chk_Option7
        '
        Me.chk_Option7.AutoSize = True
        Me.chk_Option7.ButtonTitle = Nothing
        Me.chk_Option7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chk_Option7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_Option7.ForeColor = System.Drawing.Color.Black
        Me.chk_Option7.Location = New System.Drawing.Point(146, 29)
        Me.chk_Option7.Name = "chk_Option7"
        Me.chk_Option7.Size = New System.Drawing.Size(137, 20)
        Me.chk_Option7.TabIndex = 1
        Me.chk_Option7.Text = "Option 7"
        Me.chk_Option7.UseVisualStyleBackColor = True
        '
        'chk_Option8
        '
        Me.chk_Option8.AutoSize = True
        Me.chk_Option8.ButtonTitle = Nothing
        Me.chk_Option8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chk_Option8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_Option8.ForeColor = System.Drawing.Color.Black
        Me.chk_Option8.Location = New System.Drawing.Point(289, 29)
        Me.chk_Option8.Name = "chk_Option8"
        Me.chk_Option8.Size = New System.Drawing.Size(137, 20)
        Me.chk_Option8.TabIndex = 1
        Me.chk_Option8.Text = "Option 8"
        Me.chk_Option8.UseVisualStyleBackColor = True
        '
        'chk_Option9
        '
        Me.chk_Option9.AutoSize = True
        Me.chk_Option9.ButtonTitle = Nothing
        Me.chk_Option9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chk_Option9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_Option9.ForeColor = System.Drawing.Color.Black
        Me.chk_Option9.Location = New System.Drawing.Point(432, 29)
        Me.chk_Option9.Name = "chk_Option9"
        Me.chk_Option9.Size = New System.Drawing.Size(137, 20)
        Me.chk_Option9.TabIndex = 1
        Me.chk_Option9.Text = "Option 9"
        Me.chk_Option9.UseVisualStyleBackColor = True
        '
        'chk_Option10
        '
        Me.chk_Option10.AutoSize = True
        Me.chk_Option10.ButtonTitle = Nothing
        Me.chk_Option10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chk_Option10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_Option10.ForeColor = System.Drawing.Color.Black
        Me.chk_Option10.Location = New System.Drawing.Point(575, 29)
        Me.chk_Option10.Name = "chk_Option10"
        Me.chk_Option10.Size = New System.Drawing.Size(141, 20)
        Me.chk_Option10.TabIndex = 1
        Me.chk_Option10.Text = "Option 10"
        Me.chk_Option10.UseVisualStyleBackColor = True
        '
        'ISUD7101Duy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 90)
        Me.Controls.Add(Me.Frame1)
        Me.KeyPreview = True
        Me.Name = "ISUD7101Duy"
        Me.Text = "ISUD7101Duy"
        CType(Me.Frame1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Block.ResumeLayout(False)
        Me.Block.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Frame1 As PSMGlobal.PeacePanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Block As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents chk_Option1 As PSMGlobal.PeaceCheckbox
    Friend WithEvents chk_Option2 As PSMGlobal.PeaceCheckbox
    Friend WithEvents chk_Option3 As PSMGlobal.PeaceCheckbox
    Friend WithEvents chk_Option4 As PSMGlobal.PeaceCheckbox
    Friend WithEvents chk_Option5 As PSMGlobal.PeaceCheckbox
    Friend WithEvents chk_Option6 As PSMGlobal.PeaceCheckbox
    Friend WithEvents chk_Option7 As PSMGlobal.PeaceCheckbox
    Friend WithEvents chk_Option8 As PSMGlobal.PeaceCheckbox
    Friend WithEvents chk_Option9 As PSMGlobal.PeaceCheckbox
    Friend WithEvents chk_Option10 As PSMGlobal.PeaceCheckbox
End Class
