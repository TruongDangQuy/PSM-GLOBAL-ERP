<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class SelectPeaceCalSinUP
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
        Me.PeaceButton1 = New PSMGlobal.PeaceButton(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PeaceMaskedtextbox1 = New PSMGlobal.PeaceMaskedtextbox(Me.components)
        Me.cmd_Back = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Next = New PSMGlobal.PeaceButton(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PeaceButton1
        '
        Me.PeaceButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PeaceButton1.Code = Nothing
        Me.PeaceButton1.Data = Nothing
        Me.PeaceButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceButton1.Location = New System.Drawing.Point(0, 0)
        Me.PeaceButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.PeaceButton1.Name = "PeaceButton1"
        Me.PeaceButton1.Size = New System.Drawing.Size(112, 30)
        Me.PeaceButton1.TabIndex = 2
        Me.PeaceButton1.TabStop = False
        Me.PeaceButton1.Text = "DATE"
        Me.PeaceButton1.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.66!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.34!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmd_Next, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PeaceButton1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PeaceMaskedtextbox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmd_Back, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(410, 30)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'PeaceMaskedtextbox1
        '
        Me.PeaceMaskedtextbox1.BackColor = System.Drawing.SystemColors.Control
        Me.PeaceMaskedtextbox1.Code = Nothing
        Me.PeaceMaskedtextbox1.Data = "    /  /"
        Me.PeaceMaskedtextbox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceMaskedtextbox1.DTDec = 0
        Me.PeaceMaskedtextbox1.DTLen = 0
        Me.PeaceMaskedtextbox1.DTValue = 0
        Me.PeaceMaskedtextbox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceMaskedtextbox1.Location = New System.Drawing.Point(112, 0)
        Me.PeaceMaskedtextbox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PeaceMaskedtextbox1.Mask = "0000/00/00"
        Me.PeaceMaskedtextbox1.Name = "PeaceMaskedtextbox1"
        Me.PeaceMaskedtextbox1.NoClear = False
        Me.PeaceMaskedtextbox1.PromptChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.PeaceMaskedtextbox1.Size = New System.Drawing.Size(221, 29)
        Me.PeaceMaskedtextbox1.TabIndex = 3
        '
        'cmd_Back
        '
        Me.cmd_Back.Code = Nothing
        Me.cmd_Back.Data = Nothing
        Me.cmd_Back.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd_Back.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Back.Location = New System.Drawing.Point(333, 0)
        Me.cmd_Back.Margin = New System.Windows.Forms.Padding(0)
        Me.cmd_Back.Name = "cmd_Back"
        Me.cmd_Back.Size = New System.Drawing.Size(37, 30)
        Me.cmd_Back.TabIndex = 4
        Me.cmd_Back.TabStop = False
        Me.cmd_Back.Text = "<<"
        Me.cmd_Back.UseVisualStyleBackColor = True
        '
        'cmd_Next
        '
        Me.cmd_Next.Code = Nothing
        Me.cmd_Next.Data = Nothing
        Me.cmd_Next.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmd_Next.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Next.Location = New System.Drawing.Point(370, 0)
        Me.cmd_Next.Margin = New System.Windows.Forms.Padding(0)
        Me.cmd_Next.Name = "cmd_Next"
        Me.cmd_Next.Size = New System.Drawing.Size(40, 30)
        Me.cmd_Next.TabIndex = 5
        Me.cmd_Next.TabStop = False
        Me.cmd_Next.Text = ">>"
        Me.cmd_Next.UseVisualStyleBackColor = True
        '
        'SelectPeaceCalSinUP
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "SelectPeaceCalSinUP"
        Me.Size = New System.Drawing.Size(410, 30)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Public WithEvents PeaceMaskedtextbox1 As PSMGlobal.PeaceMaskedtextbox
    Friend WithEvents PeaceButton1 As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Next As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Back As PSMGlobal.PeaceButton

End Class
