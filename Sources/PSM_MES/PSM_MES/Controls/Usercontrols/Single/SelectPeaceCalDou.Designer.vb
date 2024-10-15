<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectPeaceCalDou
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
        Me.PeaceButton1 = New PSMGlobal.PeaceButton(Me.components)
        Me.edate = New PSMGlobal.PeaceMaskedtextbox(Me.components)
        Me.sdate = New PSMGlobal.PeaceMaskedtextbox(Me.components)
        Me.PeaceLabel1 = New PSMGlobal.PeaceLabel(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.66!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.34!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.5!))
        Me.TableLayoutPanel1.Controls.Add(Me.PeaceButton1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.edate, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.sdate, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PeaceLabel1, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(410, 30)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'PeaceButton1
        '
        Me.PeaceButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PeaceButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceButton1.Appearance.Options.UseBackColor = True
        Me.PeaceButton1.Appearance.Options.UseFont = True
        Me.PeaceButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.PeaceButton1.Code = Nothing
        Me.PeaceButton1.Data = Nothing
        Me.PeaceButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceButton1.ImageAlign = 0
        Me.PeaceButton1.Location = New System.Drawing.Point(0, 0)
        Me.PeaceButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.PeaceButton1.Name = "PeaceButton1"
        Me.PeaceButton1.Size = New System.Drawing.Size(138, 30)
        Me.PeaceButton1.TabIndex = 0
        Me.PeaceButton1.Text = "PERIOD"
        Me.PeaceButton1.UseVisualStyleBackColor = False
        '
        'edate
        '
        Me.edate.BackColor = System.Drawing.Color.White
        Me.edate.Code = Nothing
        Me.edate.Data = "    -  -"
        Me.edate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.edate.DTDec = 0
        Me.edate.DTLen = 0
        Me.edate.DTValue = 0
        Me.edate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.edate.Location = New System.Drawing.Point(280, 0)
        Me.edate.Margin = New System.Windows.Forms.Padding(0)
        Me.edate.Mask = "9999-99-99"
        Me.edate.Name = "edate"
        Me.edate.NoClear = False
        Me.edate.PromptChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.edate.Size = New System.Drawing.Size(130, 26)
        Me.edate.TabIndex = 3
        Me.edate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'sdate
        '
        Me.sdate.BackColor = System.Drawing.Color.White
        Me.sdate.Code = Nothing
        Me.sdate.Data = "    -  -"
        Me.sdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sdate.DTDec = 0
        Me.sdate.DTLen = 0
        Me.sdate.DTValue = 0
        Me.sdate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sdate.Location = New System.Drawing.Point(138, 0)
        Me.sdate.Margin = New System.Windows.Forms.Padding(0)
        Me.sdate.Mask = "9999-99-99"
        Me.sdate.Name = "sdate"
        Me.sdate.NoClear = False
        Me.sdate.PromptChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.sdate.Size = New System.Drawing.Size(129, 26)
        Me.sdate.TabIndex = 1
        Me.sdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PeaceLabel1
        '
        Me.PeaceLabel1.Code = ""
        Me.PeaceLabel1.Data = ""
        Me.PeaceLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceLabel1.DTDec = 0
        Me.PeaceLabel1.DTLen = 0
        Me.PeaceLabel1.DTValue = 0
        Me.PeaceLabel1.Font = New System.Drawing.Font("Tahoma", 5.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceLabel1.Location = New System.Drawing.Point(270, 0)
        Me.PeaceLabel1.Name = "PeaceLabel1"
        Me.PeaceLabel1.NoClear = False
        Me.PeaceLabel1.Size = New System.Drawing.Size(7, 30)
        Me.PeaceLabel1.TabIndex = 2
        Me.PeaceLabel1.Text = "-"
        Me.PeaceLabel1.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'SelectPeaceCalDou
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "SelectPeaceCalDou"
        Me.Size = New System.Drawing.Size(410, 30)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PeaceButton1 As PSMGlobal.PeaceButton
    Friend WithEvents sdate As PSMGlobal.PeaceMaskedtextbox
    Friend WithEvents PeaceLabel1 As PSMGlobal.PeaceLabel
    Friend WithEvents edate As PSMGlobal.PeaceMaskedtextbox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

End Class
