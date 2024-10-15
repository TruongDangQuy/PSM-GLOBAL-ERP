<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectPeaceCalLR
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
        Me.PeaceMaskedtextbox1 = New PSMGlobal.PeaceMaskedtextbox(Me.components)
        Me.PeaceLabel1 = New PSMGlobal.PeaceLabel(Me.components)
        Me.PeaceButton2 = New PSMGlobal.PeaceButton(Me.components)
        Me.PeaceButton3 = New PSMGlobal.PeaceButton(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.25!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.25!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PeaceButton1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PeaceMaskedtextbox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PeaceLabel1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PeaceButton2, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PeaceButton3, 4, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(410, 30)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'PeaceButton1
        '
        Me.PeaceButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceButton1.Appearance.Options.UseFont = True
        Me.PeaceButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.PeaceButton1.ButtonTitle = Nothing
        Me.PeaceButton1.Code = Nothing
        Me.PeaceButton1.Data = Nothing
        Me.PeaceButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceButton1.ImageAlign = 0
        Me.PeaceButton1.Location = New System.Drawing.Point(0, 0)
        Me.PeaceButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.PeaceButton1.Name = "PeaceButton1"
        Me.PeaceButton1.Size = New System.Drawing.Size(136, 30)
        Me.PeaceButton1.TabIndex = 0
        Me.PeaceButton1.Text = "PERIOD"
        Me.PeaceButton1.UseVisualStyleBackColor = False
        '
        'PeaceMaskedtextbox1
        '
        Me.PeaceMaskedtextbox1.BackColor = System.Drawing.SystemColors.Control
        Me.PeaceMaskedtextbox1.Code = Nothing
        Me.PeaceMaskedtextbox1.Data = "    -  -"
        Me.PeaceMaskedtextbox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceMaskedtextbox1.DTDec = 0
        Me.PeaceMaskedtextbox1.DTLen = 0
        Me.PeaceMaskedtextbox1.DTValue = 0
        Me.PeaceMaskedtextbox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceMaskedtextbox1.Location = New System.Drawing.Point(136, 0)
        Me.PeaceMaskedtextbox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PeaceMaskedtextbox1.Mask = "9999-99-99"
        Me.PeaceMaskedtextbox1.Name = "PeaceMaskedtextbox1"
        Me.PeaceMaskedtextbox1.NoClear = False
        Me.PeaceMaskedtextbox1.PromptChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.PeaceMaskedtextbox1.Size = New System.Drawing.Size(136, 22)
        Me.PeaceMaskedtextbox1.TabIndex = 1
        Me.PeaceMaskedtextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PeaceLabel1
        '
        Me.PeaceLabel1.Appearance.Font = New System.Drawing.Font("Tahoma", 5.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceLabel1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PeaceLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel1.ButtonTitle = Nothing
        Me.PeaceLabel1.Code = ""
        Me.PeaceLabel1.Data = ""
        Me.PeaceLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceLabel1.DTDec = 0
        Me.PeaceLabel1.DTLen = 0
        Me.PeaceLabel1.DTValue = 0
        Me.PeaceLabel1.Location = New System.Drawing.Point(275, 3)
        Me.PeaceLabel1.Name = "PeaceLabel1"
        Me.PeaceLabel1.NoClear = False
        Me.PeaceLabel1.Size = New System.Drawing.Size(8, 24)
        Me.PeaceLabel1.TabIndex = 2
        Me.PeaceLabel1.Tag = ""
        Me.PeaceLabel1.Text = "-"
        Me.PeaceLabel1.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'PeaceButton2
        '
        Me.PeaceButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceButton2.Appearance.Options.UseFont = True
        Me.PeaceButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.PeaceButton2.ButtonTitle = Nothing
        Me.PeaceButton2.Code = Nothing
        Me.PeaceButton2.Data = Nothing
        Me.PeaceButton2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceButton2.Image = Global.PSMGlobal.My.Resources.Resources.Previous1
        Me.PeaceButton2.ImageAlign = 0
        Me.PeaceButton2.Location = New System.Drawing.Point(286, 0)
        Me.PeaceButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.PeaceButton2.Name = "PeaceButton2"
        Me.PeaceButton2.Size = New System.Drawing.Size(61, 30)
        Me.PeaceButton2.TabIndex = 3
        Me.PeaceButton2.UseVisualStyleBackColor = True
        '
        'PeaceButton3
        '
        Me.PeaceButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceButton3.Appearance.Options.UseFont = True
        Me.PeaceButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.PeaceButton3.ButtonTitle = Nothing
        Me.PeaceButton3.Code = Nothing
        Me.PeaceButton3.Data = Nothing
        Me.PeaceButton3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceButton3.Image = Global.PSMGlobal.My.Resources.Resources.next1
        Me.PeaceButton3.ImageAlign = 0
        Me.PeaceButton3.Location = New System.Drawing.Point(347, 0)
        Me.PeaceButton3.Margin = New System.Windows.Forms.Padding(0)
        Me.PeaceButton3.Name = "PeaceButton3"
        Me.PeaceButton3.Size = New System.Drawing.Size(63, 30)
        Me.PeaceButton3.TabIndex = 3
        Me.PeaceButton3.UseVisualStyleBackColor = True
        '
        'SelectPeaceCalLR
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "SelectPeaceCalLR"
        Me.Size = New System.Drawing.Size(410, 30)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PeaceButton1 As PSMGlobal.PeaceButton
    Friend WithEvents PeaceMaskedtextbox1 As PSMGlobal.PeaceMaskedtextbox
    Friend WithEvents PeaceLabel1 As PSMGlobal.PeaceLabel
    Friend WithEvents PeaceButton2 As PSMGlobal.PeaceButton
    Friend WithEvents PeaceButton3 As PSMGlobal.PeaceButton

End Class
