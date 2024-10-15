<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectPeaceMaskText
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
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.65854!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.34146!))
        Me.TableLayoutPanel1.Controls.Add(Me.PeaceButton1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PeaceMaskedtextbox1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(410, 30)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'PeaceButton1
        '
        Me.PeaceButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceButton1.Appearance.Options.UseFont = True
        Me.PeaceButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.PeaceButton1.Code = Nothing
        Me.PeaceButton1.Data = Nothing
        Me.PeaceButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceButton1.ImageAlign = 0
        Me.PeaceButton1.Location = New System.Drawing.Point(0, 0)
        Me.PeaceButton1.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.PeaceButton1.Name = "PeaceButton1"
        Me.PeaceButton1.Size = New System.Drawing.Size(136, 30)
        Me.PeaceButton1.TabIndex = 0
        Me.PeaceButton1.Text = "PeaceButton"
        Me.PeaceButton1.UseVisualStyleBackColor = True
        '
        'PeaceMaskedtextbox1
        '
        Me.PeaceMaskedtextbox1.Code = Nothing
        Me.PeaceMaskedtextbox1.Data = Nothing
        Me.PeaceMaskedtextbox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceMaskedtextbox1.DTDec = 0
        Me.PeaceMaskedtextbox1.DTLen = 0
        Me.PeaceMaskedtextbox1.DTValue = 0
        Me.PeaceMaskedtextbox1.Font = New System.Drawing.Font("Tahoma", 13.5!, System.Drawing.FontStyle.Bold)
        Me.PeaceMaskedtextbox1.Location = New System.Drawing.Point(138, 0)
        Me.PeaceMaskedtextbox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PeaceMaskedtextbox1.Name = "PeaceMaskedtextbox1"
        Me.PeaceMaskedtextbox1.NoClear = False
        Me.PeaceMaskedtextbox1.Size = New System.Drawing.Size(272, 28)
        Me.PeaceMaskedtextbox1.TabIndex = 1
        '
        'SelectPeaceMaskText
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "SelectPeaceMaskText"
        Me.Size = New System.Drawing.Size(410, 30)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PeaceButton1 As PSMGlobal.PeaceButton
    Friend WithEvents PeaceMaskedtextbox1 As PSMGlobal.PeaceMaskedtextbox

End Class
