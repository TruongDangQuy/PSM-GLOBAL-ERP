<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HLP7271A
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_Name = New PSMGlobal.SelectLabelSearch()
        Me.PeaceTextbox1 = New PSMGlobal.PeaceTextbox(Me.components)
        Me.PeaceButton1 = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_SEARCH = New PSMGlobal.PeaceButton(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.Vs1 = New PeaceFarpoint
        Me.Vs1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.txt_Name.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = SystemColors.Control
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.18459!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.837729!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.349784!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.49911!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Name, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmd_SEARCH, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Vs1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(789, 766)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'txt_Name
        '
        Me.txt_Name.BackYesno = False
        Me.txt_Name.ButtonBackColor = System.Drawing.SystemColors.Control
        Me.txt_Name.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Standard
        Me.txt_Name.ButtonEnabled = True
        Me.txt_Name.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Name.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_Name.ButtonTitle = "Name"
        Me.txt_Name.Code = ""
        Me.TableLayoutPanel1.SetColumnSpan(Me.txt_Name, 2)
        Me.txt_Name.Controls.Add(Me.PeaceTextbox1)
        Me.txt_Name.Controls.Add(Me.PeaceButton1)
        Me.txt_Name.Data = ""
        Me.txt_Name.DataDecimal = 0
        Me.txt_Name.DataLen = 0
        Me.txt_Name.DataValue = 0
        Me.txt_Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Name.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Name.Location = New System.Drawing.Point(0, 0)
        Me.txt_Name.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Name.Size = New System.Drawing.Size(576, 30)
        Me.txt_Name.TabIndex = 0
        Me.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Name.TextBoxAutoComplete = False
        Me.txt_Name.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Name.TextBoxFont = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_Name.TextEnabled = True
        Me.txt_Name.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Name.TextMaxLength = 25
        Me.txt_Name.TextMultiLine = False
        Me.txt_Name.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Name.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Name.UseSendTab = True
        '
        'PeaceTextbox1
        '
        Me.PeaceTextbox1.BackColor = System.Drawing.Color.White
        Me.PeaceTextbox1.Code = Nothing
        Me.PeaceTextbox1.Data = Nothing
        Me.PeaceTextbox1.DTDec = 0
        Me.PeaceTextbox1.DTLen = 0
        Me.PeaceTextbox1.DTValue = 0
        Me.PeaceTextbox1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceTextbox1.Location = New System.Drawing.Point(136, 0)
        Me.PeaceTextbox1.MaxLength = 25
        Me.PeaceTextbox1.Multiline = True
        Me.PeaceTextbox1.Name = "PeaceTextbox1"
        Me.PeaceTextbox1.NoClear = False
        Me.PeaceTextbox1.Size = New System.Drawing.Size(271, 37)
        Me.PeaceTextbox1.TabIndex = 1
        Me.PeaceTextbox1.Tag = ""
        '
        'PeaceButton1
        '
        Me.PeaceButton1.Code = Nothing
        Me.PeaceButton1.Data = Nothing
        Me.PeaceButton1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceButton1.Location = New System.Drawing.Point(0, 0)
        Me.PeaceButton1.Name = "PeaceButton1"
        Me.PeaceButton1.Size = New System.Drawing.Size(130, 37)
        Me.PeaceButton1.TabIndex = 0
        Me.PeaceButton1.Text = "Name"
        '
        'cmd_SEARCH
        '
        Me.cmd_SEARCH.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TableLayoutPanel1.SetColumnSpan(Me.cmd_SEARCH, 2)
        Me.cmd_SEARCH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd_SEARCH.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_SEARCH.Image = Global.PSMGlobal.My.Resources.Resources.find_f
        Me.cmd_SEARCH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_SEARCH.Location = New System.Drawing.Point(579, 3)
        Me.cmd_SEARCH.Name = "cmd_SEARCH"
        Me.cmd_SEARCH.Size = New System.Drawing.Size(207, 24)
        Me.cmd_SEARCH.TabIndex = 1
        Me.cmd_SEARCH.Text = "Search(&S)"
        Me.cmd_SEARCH.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 3)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.cmd_Cancel, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmd_OK, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(502, 733)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(284, 30)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmd_Cancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd_Cancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Image = Global.PSMGlobal.My.Resources.Resources.delete
        Me.cmd_Cancel.Location = New System.Drawing.Point(143, 1)
        Me.cmd_Cancel.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(140, 28)
        Me.cmd_Cancel.TabIndex = 43
        Me.cmd_Cancel.Text = "Close(&X)"
        '
        'cmd_OK
        '
        Me.cmd_OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd_OK.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Image = Global.PSMGlobal.My.Resources.Resources.save
        Me.cmd_OK.Location = New System.Drawing.Point(1, 1)
        Me.cmd_OK.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(140, 28)
        Me.cmd_OK.TabIndex = 44
        Me.cmd_OK.Text = "Save(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'Vs1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Vs1, 4)
        Me.Vs1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Vs1.Location = New System.Drawing.Point(3, 33)
        Me.Vs1.Name = "Vs1"
        Me.Vs1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.Vs1_Sheet1})
        Me.Vs1.Size = New System.Drawing.Size(783, 694)
        Me.Vs1.TabIndex = 16
        '
        'Vs1_Sheet1
        '
        Me.Vs1_Sheet1.Reset()
        Me.Vs1_Sheet1.SheetName = "Sheet1"
        '
        'HLP7271A
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(789, 766)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "HLP7271A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WAREHOUSE POSITION HELP (HLP7271B)"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.txt_Name.ResumeLayout(False)
        Me.txt_Name.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmd_SEARCH As PSMGlobal.PeaceButton
    Friend WithEvents txt_Name As PSMGlobal.SelectLabelSearch
    Friend WithEvents PeaceTextbox1 As PSMGlobal.PeaceTextbox
    Friend WithEvents PeaceButton1 As PSMGlobal.PeaceButton
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Public WithEvents Vs1 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents Vs1_Sheet1 As FarPoint.Win.Spread.SheetView
End Class
