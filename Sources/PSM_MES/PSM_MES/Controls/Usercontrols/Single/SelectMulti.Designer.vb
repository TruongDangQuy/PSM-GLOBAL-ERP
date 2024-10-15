<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectMulti
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
        Me.btnTitle = New PSMGlobal.PeaceButton(Me.components)
        Me.chkAll = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.cboText = New PSMGlobal.PeaceCombobox(Me.components)
        Me.btnSelect = New PSMGlobal.PeaceButton(Me.components)
        Me.ttpMain = New PSMGlobal.PeaceTooltip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.36585!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.536586!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.7561!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.82927!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnTitle, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.chkAll, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cboText, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSelect, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(410, 30)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'btnTitle
        '
        Me.btnTitle.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnTitle.Appearance.Options.UseFont = True
        Me.btnTitle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnTitle.ButtonTitle = Nothing
        Me.btnTitle.Code = Nothing
        Me.btnTitle.Data = Nothing
        Me.btnTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTitle.ImageAlign = 0
        Me.btnTitle.Location = New System.Drawing.Point(0, 0)
        Me.btnTitle.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.btnTitle.Name = "btnTitle"
        Me.btnTitle.Size = New System.Drawing.Size(101, 30)
        Me.btnTitle.TabIndex = 0
        Me.btnTitle.Text = "PeaceButton"
        Me.btnTitle.UseVisualStyleBackColor = True
        '
        'chkAll
        '
        Me.chkAll.ButtonTitle = Nothing
        Me.chkAll.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkAll.Location = New System.Drawing.Point(106, 3)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(28, 24)
        Me.chkAll.TabIndex = 1
        Me.chkAll.UseVisualStyleBackColor = True
        '
        'cboText
        '
        Me.cboText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboText.DTDec = 0
        Me.cboText.DTLen = 0
        Me.cboText.DTValue = 0
        Me.cboText.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboText.FormattingEnabled = True
        Me.cboText.InSelected = 0
        Me.cboText.ListIndex = 0
        Me.cboText.Location = New System.Drawing.Point(137, 3)
        Me.cboText.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.cboText.Name = "cboText"
        Me.cboText.NoClear = False
        Me.cboText.Size = New System.Drawing.Size(162, 22)
        Me.cboText.TabIndex = 2
        '
        'btnSelect
        '
        Me.btnSelect.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSelect.Appearance.Options.UseFont = True
        Me.btnSelect.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnSelect.ButtonTitle = Nothing
        Me.btnSelect.Code = Nothing
        Me.btnSelect.Data = Nothing
        Me.btnSelect.ImageAlign = 0
        Me.btnSelect.Location = New System.Drawing.Point(302, 0)
        Me.btnSelect.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(108, 30)
        Me.btnSelect.TabIndex = 3
        Me.btnSelect.Text = "Multiple"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'ttpMain
        '
        Me.ttpMain.AutoPopDelay = 5000
        Me.ttpMain.InitialDelay = 500
        Me.ttpMain.IsBalloon = True
        Me.ttpMain.ReshowDelay = 100
        Me.ttpMain.ShowAlways = True
        Me.ttpMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttpMain.ToolTipTitle = "Information"
        '
        'SelectMulti
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "SelectMulti"
        Me.Size = New System.Drawing.Size(410, 30)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnTitle As PSMGlobal.PeaceButton
    Friend WithEvents chkAll As PSMGlobal.PeaceCheckbox
    Friend WithEvents cboText As PSMGlobal.PeaceCombobox
    Friend WithEvents btnSelect As PSMGlobal.PeaceButton
    Friend WithEvents ttpMain As PSMGlobal.PeaceTooltip

End Class
