<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMessageBox
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
        Me.FlowLayoutPanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txt_Message = New System.Windows.Forms.TextBox()
        Me.cmd_CLOSE = New PSMGlobal.PeaceButton(Me.components)
        CType(Me.FlowLayoutPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.FlowLayoutPanel1.Code = ""
        Me.FlowLayoutPanel1.Controls.Add(Me.SplitContainer1)
        Me.FlowLayoutPanel1.Data = ""
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(7, 4)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(981, 403)
        Me.FlowLayoutPanel1.TabIndex = 2
        Me.FlowLayoutPanel1.Tag = ""
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(5, 5)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Red
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_Message)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmd_CLOSE)
        Me.SplitContainer1.Size = New System.Drawing.Size(971, 393)
        Me.SplitContainer1.SplitterDistance = 287
        Me.SplitContainer1.TabIndex = 3
        '
        'txt_Message
        '
        Me.txt_Message.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Message.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Message.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Message.Enabled = False
        Me.txt_Message.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Message.Location = New System.Drawing.Point(19, 100)
        Me.txt_Message.Name = "txt_Message"
        Me.txt_Message.Size = New System.Drawing.Size(936, 65)
        Me.txt_Message.TabIndex = 0
        Me.txt_Message.Text = "Message 1"
        Me.txt_Message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmd_CLOSE
        '
        Me.cmd_CLOSE.Appearance.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_CLOSE.Appearance.Options.UseFont = True
        Me.cmd_CLOSE.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.cmd_CLOSE.ButtonTitle = Nothing
        Me.cmd_CLOSE.Code = Nothing
        Me.cmd_CLOSE.Data = Nothing
        Me.cmd_CLOSE.Image = Global.PSMGlobal.My.Resources.Resources.Close
        Me.cmd_CLOSE.ImageAlign = 16
        Me.cmd_CLOSE.Location = New System.Drawing.Point(2, 1)
        Me.cmd_CLOSE.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cmd_CLOSE.Name = "cmd_CLOSE"
        Me.cmd_CLOSE.Size = New System.Drawing.Size(967, 100)
        Me.cmd_CLOSE.TabIndex = 2
        Me.cmd_CLOSE.Text = "OK"
        Me.cmd_CLOSE.UseVisualStyleBackColor = False
        '
        'FMessageBox
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1002, 420)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "FMessageBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PASSWORDFORM"
        CType(Me.FlowLayoutPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As PSMGlobal.PeacePanel
    Friend WithEvents cmd_CLOSE As PSMGlobal.PeaceButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txt_Message As System.Windows.Forms.TextBox
End Class
