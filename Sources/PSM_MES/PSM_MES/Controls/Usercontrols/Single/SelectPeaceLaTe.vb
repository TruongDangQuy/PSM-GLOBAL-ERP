Public Class SelectPeaceLaTe


#Region "Field"
    Private m_Data As New DATASPACE
    Private m_SendTab As Boolean = True

    Private m_Clicked As Boolean = False

    Private m_CellBorderStyle As TableLayoutPanelCellBorderStyle = TableLayoutPanelCellBorderStyle.Single

    Private m_ButtonBorderStyle As FlatStyle
    Private m_ButtonTitle As String
    Private m_ButtonEnabled As Boolean = True
    Private m_ButtonVisibled As Boolean = True
    Private m_ButtonBackColor As Color
    Private m_ButtonFont As Font
    Private m_ButtonColor As Color

    Private m_percent As String = "40,30,30"
    Private m_LabelForeColor As Color
    Private m_LabelBackColor As Color
    Private m_labelAlign As ContentAlignment = ContentAlignment.MiddleLeft
    Private m_LabelFont As Font = New Font("Tahoma", 9, FontStyle.Bold)
    Private m_Label2ForeColor As Color
    Private m_Label2Text As String
    Private m_Label2Font As Font = New Font("Tahoma", 9, FontStyle.Bold)


    Private m_TextBoxEnabled As Boolean = True
    Private m_TextBoxMultiline As Boolean = True
    Private m_TextBoxBackColorYN As Boolean = False
    Private m_TextBoxScrollBars As ScrollBars = ScrollBars.None
    Private m_TextBoxMaxLength As Integer = 32767
    Private m_TextBoxForeColor As Color
    Private m_TextBoxAlign As HorizontalAlignment = HorizontalAlignment.Left
    Private m_TextBoxBorderStyle As DevExpress.XtraEditors.Controls.BorderStyles = DevExpress.XtraEditors.Controls.BorderStyles.Simple
    Private m_TextBoxfont As Font = New Font("Tahoma", 9)
    Private m_TextBoxBackColor As Color
    Public Event txtTextLostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Event txtTextKeyDown As KeyEventHandler
    Public Event txtTextChanged As EventHandler
    Public Event txtTextKeyPress As KeyPressEventHandler
    Public Property BackYesno() As Boolean
        Get
            Return m_TextBoxBackColorYN
        End Get
        Set(ByVal Value As Boolean)
            m_TextBoxBackColorYN = Value
        End Set
    End Property

    Private Sub btnTitle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pbt.KeyDown

        RaiseEvent btnTitleKeyDown(sender, e)

    End Sub
    Private Sub PeaceTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ptb.KeyPress

        RaiseEvent txtTextKeyPress(sender, e)
    End Sub
    Private Sub txtText_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptb.LostFocus
        If m_TextBoxBackColorYN = True Then Exit Sub
        If Trim(ptb.Text) = "" Then
            ptb.BackColor = cLostFocusColor
        Else
            ptb.BackColor = cGotFocusColorText
        End If

        RaiseEvent txtTextLostFocus(sender, e)

    End Sub

#End Region
#Region "Event"
    Public Event btnTitleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event btnTitleKeyDown As KeyEventHandler
#End Region
    Public Sub New()

        ' 이 호출은 Windows Form 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

    End Sub
#Region "Property"



    Public Property UseSendTab() As Boolean
        Get
            Return m_SendTab
        End Get
        Set(ByVal Value As Boolean)
            m_SendTab = Value
        End Set
    End Property

    Public Property PanelStyle() As TableLayoutPanelCellBorderStyle
        Get
            Return m_CellBorderStyle
        End Get
        Set(ByVal Value As TableLayoutPanelCellBorderStyle)
            m_CellBorderStyle = Value
        End Set
    End Property

    Public Property ButtonBorderStyle() As FlatStyle
        Get
            Return m_ButtonBorderStyle
        End Get
        Set(ByVal Value As FlatStyle)
            m_ButtonBorderStyle = Value
        End Set
    End Property

    Public Property ButtonTitle() As String
        Get
            Return m_ButtonTitle
        End Get
        Set(ByVal Value As String)
            m_ButtonTitle = Value
            pbt.Text = Value
        End Set
    End Property
    Public Property ButtonEnabled() As Boolean
        Get
            Return m_ButtonEnabled
        End Get
        Set(ByVal Value As Boolean)

            m_ButtonEnabled = Value
            pbt.Enabled = Value

            If Value = False Then
                pbt.ForeColor = cForeColor
            End If

        End Set
    End Property
    Public Property ButtonVisibled() As Boolean
        Get
            Return m_ButtonVisibled
        End Get
        Set(ByVal Value As Boolean)

            m_ButtonVisibled = Value
            pbt.Visible = Value
            If Value = False Then
                TableLayoutPanel1.ColumnCount = 2
            End If
        End Set
    End Property
    Public Property ButtonBackColor As Color
        Get
            Return m_ButtonBackColor
        End Get
        Set(value As Color)
            m_ButtonBackColor = value
            pbt.BackColor = value
        End Set
    End Property

    Public Property ButtonFont() As Font
        Get
            Return m_ButtonFont
        End Get
        Set(value As Font)
            m_ButtonFont = value
            pbt.Font = value
        End Set
    End Property

    Public Property ButtonForeColor() As Color
        Get
            Return m_ButtonColor
        End Get
        Set(value As Color)
            m_ButtonColor = value
            pbt.ForeColor = value
        End Set
    End Property

    Public Property Layoutpercent() As String
        Get
            Return m_percent
        End Get
        Set(value As String)
            m_percent = value
            Dim a() As String
            a = Split(m_percent, ",")
            TableLayoutPanel1.ColumnStyles(0).SizeType = SizeType.Percent
            TableLayoutPanel1.ColumnStyles(1).SizeType = SizeType.Percent
            TableLayoutPanel1.ColumnStyles(2).SizeType = SizeType.Percent
            TableLayoutPanel1.ColumnStyles(0).Width = CDbl(a(0))
            TableLayoutPanel1.ColumnStyles(1).Width = CDbl(a(1))
            TableLayoutPanel1.ColumnStyles(2).Width = CDbl(a(2))
        End Set
    End Property
    Public Property TextEnabled() As Boolean
        Get
            Return m_TextBoxEnabled
        End Get
        Set(ByVal Value As Boolean)

            m_TextBoxEnabled = Value
            ptb.Enabled = Value

            If Value = False Then
                ptb.BackColor = cDisabledColor
            Else
                ptb.BackColor = cEnabledColor
            End If

        End Set
    End Property

    Public Property TextMultiLine() As Boolean
        Get
            Return m_TextBoxMultiline
        End Get
        Set(ByVal Value As Boolean)

            m_TextBoxMultiline = Value
            ptb.Multiline = Value

        End Set
    End Property

    Public Property TextScrollBars() As ScrollBars
        Get
            Return m_TextBoxScrollBars
        End Get
        Set(ByVal Value As ScrollBars)
            ptb.ScrollBars = Value
            m_TextBoxScrollBars = Value
        End Set
    End Property

    Public Property TextMaxLength() As Integer
        Get
            Return m_TextBoxMaxLength
        End Get
        Set(ByVal Value As Integer)
            ptb.MaxLength = Value
            m_TextBoxMaxLength = Value
        End Set
    End Property

    Public Property TextStyle() As DevExpress.XtraEditors.Controls.BorderStyles
        Get
            Return m_TextBoxBorderStyle
        End Get
        Set(ByVal Value As DevExpress.XtraEditors.Controls.BorderStyles)

            m_TextBoxBorderStyle = Value
            ptb.BorderStyle = Value

        End Set
    End Property

    Public Property TextAlign() As HorizontalAlignment
        Get
            Return m_TextBoxAlign
        End Get
        Set(ByVal Value As HorizontalAlignment)

            m_TextBoxAlign = Value
            ptb.TextAlign = Value

        End Set
    End Property

    Public Property TextForeColor() As Color
        Get
            Return m_TextBoxForeColor
        End Get
        Set(ByVal Value As Color)

            m_TextBoxForeColor = Value
            ptb.ForeColor = Value

        End Set
    End Property

    Public Property TextBoxFont() As Font
        Get
            Return m_TextBoxfont
        End Get
        Set(ByVal Value As Font)

            m_TextBoxfont = Value
            ptb.Font = Value

        End Set
    End Property

    Public Property TextboxBackColor As Color
        Get
            Return m_TextBoxBackColor
        End Get
        Set(value As Color)
            m_TextBoxBackColor = value
            ptb.BackColor = value
        End Set
    End Property


    Public Property Code() As String
        Get
            Return m_Data.CODE
        End Get
        Set(ByVal Value As String)

            m_Data.CODE = Value
            ptb.Tag = Value

        End Set
    End Property
    Public Property Data() As String
        Get
            Return m_Data.NAME
        End Get
        Set(ByVal Value As String)

            m_Data.NAME = Value
            ptb.Text = Value

        End Set
    End Property


    Public Property Label2Text() As String
        Get
            Return m_Label2Text
        End Get
        Set(value As String)
            m_Label2Text = value
            pl2.Text = value
        End Set
    End Property
    Public Property Label2Font() As Font
        Get
            Return m_LabelFont
        End Get
        Set(value As Font)
            m_LabelFont = value
            pl2.Font = value
        End Set
    End Property
    Public Property Label2FontColor() As Color
        Get
            Return m_LabelForeColor
        End Get
        Set(value As Color)
            m_LabelForeColor = value
            pl2.ForeColor = value
        End Set
    End Property
    Public Property Label2BackColor() As Color
        Get
            Return m_LabelBackColor
        End Get
        Set(value As Color)
            m_LabelBackColor = value
            pl2.BackColor = value
        End Set
    End Property
    Public Property Label2Align() As ContentAlignment
        Get
            Return m_labelAlign
        End Get
        Set(value As ContentAlignment)
            m_labelAlign = value
            pl2.TextAlign = value
        End Set
    End Property
    
    Private Sub txtText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptb.TextChanged
        Data = ptb.Text
        Code = ptb.Tag
        RaiseEvent txtTextChanged(sender, e)

    End Sub


#End Region

  
   
End Class
