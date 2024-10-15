<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSnipMain
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSnipMain))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tstNew = New System.Windows.Forms.ToolStripButton()
        Me.tstDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.mniRect = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniFull = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tstOption = New System.Windows.Forms.ToolStripButton()
        Me.tstDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.mniChageDefaultLocation = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtDefaultLocation = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDefaultLocation, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(401, 108)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Window
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstNew, Me.tstDropDownButton1, Me.ToolStripSeparator1, Me.tstOption, Me.tstDropDownButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(401, 30)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Tag = ""
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tstNew
        '
        Me.tstNew.AutoToolTip = False
        Me.tstNew.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        'Me.tstNew.Image = Global.PSMGlobal.My.Resources.Resources.snipSisscor
        Me.tstNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstNew.Margin = New System.Windows.Forms.Padding(1, 1, 0, 2)
        Me.tstNew.Name = "tstNew"
        Me.tstNew.Size = New System.Drawing.Size(56, 27)
        Me.tstNew.Text = "New"
        '
        'tstDropDownButton1
        '
        Me.tstDropDownButton1.AutoToolTip = False
        Me.tstDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.tstDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniRect, Me.mniFull})
        Me.tstDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstDropDownButton1.Name = "tstDropDownButton1"
        Me.tstDropDownButton1.Size = New System.Drawing.Size(13, 27)
        '
        'mniRect
        '
        Me.mniRect.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.mniRect.Name = "mniRect"
        Me.mniRect.Size = New System.Drawing.Size(178, 24)
        Me.mniRect.Text = "Rectangular Snip"
        '
        'mniFull
        '
        Me.mniFull.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.mniFull.Name = "mniFull"
        Me.mniFull.Size = New System.Drawing.Size(178, 24)
        Me.mniFull.Text = "Full-screen Snip"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'tstOption
        '
        Me.tstOption.AutoToolTip = False
        Me.tstOption.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        'Me.tstOption.Image = Global.PSMGlobal.My.Resources.Resources.snipoption
        Me.tstOption.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstOption.Margin = New System.Windows.Forms.Padding(1, 1, 0, 2)
        Me.tstOption.Name = "tstOption"
        Me.tstOption.Size = New System.Drawing.Size(72, 27)
        Me.tstOption.Text = "Option"
        '
        'tstDropDownButton2
        '
        Me.tstDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.tstDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniChageDefaultLocation})
        Me.tstDropDownButton2.Image = CType(resources.GetObject("tstDropDownButton2.Image"), System.Drawing.Image)
        Me.tstDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstDropDownButton2.Name = "tstDropDownButton2"
        Me.tstDropDownButton2.Size = New System.Drawing.Size(13, 27)
        '
        'mniChageDefaultLocation
        '
        Me.mniChageDefaultLocation.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.mniChageDefaultLocation.Name = "mniChageDefaultLocation"
        Me.mniChageDefaultLocation.Size = New System.Drawing.Size(244, 24)
        Me.mniChageDefaultLocation.Text = "Chage default save location"
        '
        'txtDefaultLocation
        '
        Me.txtDefaultLocation.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtDefaultLocation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDefaultLocation.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtDefaultLocation.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtDefaultLocation.Location = New System.Drawing.Point(3, 59)
        Me.txtDefaultLocation.Name = "txtDefaultLocation"
        Me.txtDefaultLocation.ReadOnly = True
        Me.txtDefaultLocation.Size = New System.Drawing.Size(395, 25)
        Me.txtDefaultLocation.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Default save loacation:"
        '
        'frmSnipMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(401, 108)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(273, 110)
        Me.Name = "frmSnipMain"
        Me.ShowInTaskbar = False
        Me.Text = "SnipMe"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tstNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents mniRect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniFull As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tstOption As System.Windows.Forms.ToolStripButton
    Friend WithEvents tstDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents mniChageDefaultLocation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtDefaultLocation As System.Windows.Forms.TextBox

End Class
