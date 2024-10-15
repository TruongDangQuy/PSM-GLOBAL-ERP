<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectPeace2Label
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
        Me.PeaceLabel1 = New PSMGlobal.PeaceLabel(Me.components)
        Me.PeaceLabel2 = New PSMGlobal.PeaceLabel(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.65993!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.69989!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.64018!))
        Me.TableLayoutPanel1.Controls.Add(Me.PeaceButton1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PeaceLabel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PeaceLabel2, 2, 0)
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
        Me.PeaceButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceButton1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceButton1.Location = New System.Drawing.Point(0, 0)
        Me.PeaceButton1.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.PeaceButton1.Name = "PeaceButton1"
        Me.PeaceButton1.Size = New System.Drawing.Size(136, 30)
        Me.PeaceButton1.TabIndex = 0
        Me.PeaceButton1.Text = "PeaceButton"
        '
        'PeaceLabel1
        '
        Me.PeaceLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PeaceLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeaceLabel1.Location = New System.Drawing.Point(139, 1)
        Me.PeaceLabel1.Margin = New System.Windows.Forms.Padding(1)
        Me.PeaceLabel1.Name = "PeaceLabel1"
        Me.PeaceLabel1.Size = New System.Drawing.Size(214, 28)
        Me.PeaceLabel1.TabIndex = 1
        Me.PeaceLabel1.Text = "PeaceLabel1"
        Me.PeaceLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PeaceLabel2
        '
        Me.PeaceLabel2.AutoSize = True
        Me.PeaceLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PeaceLabel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceLabel2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceLabel2.Location = New System.Drawing.Point(355, 1)
        Me.PeaceLabel2.Margin = New System.Windows.Forms.Padding(1)
        Me.PeaceLabel2.Name = "PeaceLabel2"
        Me.PeaceLabel2.Size = New System.Drawing.Size(54, 28)
        Me.PeaceLabel2.TabIndex = 2
        Me.PeaceLabel2.Text = "PeaceLabel2"
        Me.PeaceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SelectPeace2Label
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "SelectPeace2Label"
        Me.Size = New System.Drawing.Size(410, 30)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PeaceButton1 As PSMGlobal.PeaceButton
    Friend WithEvents PeaceLabel1 As PSMGlobal.PeaceLabel
    Friend WithEvents PeaceLabel2 As PSMGlobal.PeaceLabel

End Class
