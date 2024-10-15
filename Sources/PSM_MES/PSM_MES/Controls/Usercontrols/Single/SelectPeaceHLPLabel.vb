Public Class SelectPeaceHLPLabel

#Region "Field"
    Private m_Data As New DATASPACE
    Private m_SendTab As Boolean = True

    Private m_Clicked As Boolean = False

    Private m_CellBorderStyle As TableLayoutPanelCellBorderStyle = TableLayoutPanelCellBorderStyle.Single
    Private m_ButtonName As String
    Private m_ButtonTitle As String
    Private m_ButtonEnabled As Boolean = True
    Private m_ButtonBackColor As Color = Color.FromArgb(255, 255, 128)
    Private m_ButtonFont As Font
    Private m_ButtonColor As Color

    Private m_percent As Decimal = 0.3366

    Private m_TextBoxEnabled As Boolean = True
    Private m_TextBoxMultiline As Boolean = True
    Private m_TextBoxScrollBars As ScrollBars = ScrollBars.None
    Private m_TextBoxMaxLength As Integer = 32767
    Private m_TextBoxForeColor As Color
    Private m_TextBoxAlign As ContentAlignment = ContentAlignment.MiddleLeft
    Private m_TextBoxBorderStyle As DevExpress.XtraEditors.Controls.BorderStyles = DevExpress.XtraEditors.Controls.BorderStyles.Simple
    Private m_TextBoxfont As Font = New Font("Tahoma", 9)


    Private m_TextBoxAutoComplete As Boolean = False
#End Region
#Region "Event"
    Public Event btnTitleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event btnTitleKeyDown As KeyEventHandler
    Public Event txtTextKeyDown As KeyEventHandler
    Public Event txtTextKeyPress As KeyPressEventHandler
    Public Event txtTextLostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
#End Region
    Public Sub New()
        ' 이 호출은 Windows Form 디자이너에 필요합니다.
        '        kndl()
        InitializeComponent()
    End Sub
#Region "Property"

    Public Property TextBoxAutoComplete() As Boolean
        Get
            Return m_TextBoxAutoComplete
        End Get
        Set(ByVal Value As Boolean)
            m_TextBoxAutoComplete = Value
        End Set
    End Property

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

    Public Property ButtonName() As String
        Get
            Return m_ButtonName
        End Get
        Set(ByVal Value As String)
            m_ButtonName = Value
        End Set
    End Property

    Public Property ButtonTitle() As String
        Get
            Return m_ButtonTitle
        End Get
        Set(ByVal Value As String)
            m_ButtonTitle = Value
            PeaceButton1.Text = Value
        End Set
    End Property
    Public Property ButtonEnabled() As Boolean
        Get
            Return m_ButtonEnabled
        End Get
        Set(ByVal Value As Boolean)

            m_ButtonEnabled = Value
            PeaceButton1.Enabled = Value

            If Value = False Then
                PeaceButton1.ForeColor = cForeColor
            End If

        End Set
    End Property

    Public Property ButtonBackColor As Color
        Get
            Return m_ButtonBackColor
        End Get
        Set(value As Color)
            m_ButtonBackColor = value
            PeaceButton1.BackColor = value
        End Set
    End Property
    Public Property ButtonFont() As Font
        Get
            Return m_ButtonFont
        End Get
        Set(value As Font)
            m_ButtonFont = value
            PeaceButton1.Font = value
        End Set
    End Property

    Public Property ButtonForeColor() As Color
        Get
            Return m_ButtonColor
        End Get
        Set(value As Color)
            m_ButtonColor = value
            PeaceButton1.ForeColor = value
        End Set
    End Property

    Public Property Layoutpercent As Decimal
        Get
            Return m_percent
        End Get
        Set(value As Decimal)
            m_percent = value
            TableLayoutPanel1.ColumnStyles(0).SizeType = SizeType.Percent
            TableLayoutPanel1.ColumnStyles(1).SizeType = SizeType.Percent
            TableLayoutPanel1.ColumnStyles(0).Width = value * TableLayoutPanel1.Width
            TableLayoutPanel1.ColumnStyles(1).Width = (1 - value) * TableLayoutPanel1.Width
        End Set
    End Property

    Public Property TextEnabled() As Boolean
        Get
            Return m_TextBoxEnabled
        End Get
        Set(ByVal Value As Boolean)

            m_TextBoxEnabled = Value
            PeaceLabel1.Enabled = Value

            If Value = False Then
                PeaceLabel1.BackColor = cDisabledColor
            Else
                PeaceLabel1.BackColor = cEnabledColor
            End If

        End Set
    End Property


    Public Property TextStyle() As DevExpress.XtraEditors.Controls.BorderStyles
        Get
            Return m_TextBoxBorderStyle
        End Get
        Set(ByVal Value As DevExpress.XtraEditors.Controls.BorderStyles)

            m_TextBoxBorderStyle = Value
            PeaceLabel1.BorderStyle = Value

        End Set
    End Property

    Public Property TextAlign() As ContentAlignment
        Get
            Return m_TextBoxAlign
        End Get
        Set(ByVal Value As ContentAlignment)

            m_TextBoxAlign = Value
            PeaceLabel1.TextAlign = Value

        End Set
    End Property

    Public Property TextForeColor() As Color
        Get
            Return m_TextBoxForeColor
        End Get
        Set(ByVal Value As Color)

            m_TextBoxForeColor = Value
            PeaceLabel1.ForeColor = Value

        End Set
    End Property
    Public Property TextBoxFont() As Font
        Get
            Return m_TextBoxfont
        End Get
        Set(ByVal Value As Font)

            m_TextBoxfont = Value
            PeaceLabel1.Font = Value

        End Set
    End Property
    Public Property Code() As String
        Get
            Return m_Data.CODE
        End Get
        Set(ByVal Value As String)

            m_Data.CODE = Value
            PeaceLabel1.Tag = Value

        End Set
    End Property
    Public Property Data() As String
        Get
            Return m_Data.NAME
        End Get
        Set(ByVal Value As String)

            m_Data.NAME = Value
            PeaceLabel1.Text = Value

        End Set
    End Property

#End Region
#Region "Event Method Click - Focus ..."

    Public Overridable Sub btnTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeaceButton1.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        HLPCHECK(m_ButtonName)
        PeaceLabel1.Text = hlp0000SeVa
        PeaceLabel1.Tag = hlp0000SeVaTt
        Data = PeaceLabel1.Text
        Code = PeaceLabel1.Tag
        txtText_LostFocus(sender, e)
        RaiseEvent btnTitleClick(sender, e)
    End Sub



    Private Sub txtText_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PeaceLabel1.MouseDown

        m_Clicked = True

    End Sub

    Private Sub txtText_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PeaceLabel1.MouseUp

        m_Clicked = False

    End Sub


    Private Sub btnTitle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PeaceButton1.KeyDown

        RaiseEvent btnTitleKeyDown(sender, e)

    End Sub

    Public Sub txtText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeaceLabel1.TextChanged
        Data = PeaceLabel1.Text
        Code = PeaceLabel1.Tag

    End Sub

    Public Sub txtText_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeaceLabel1.GotFocus

        PeaceLabel1.BackColor = cGotFocusColor


    End Sub

    Public Sub txtText_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeaceLabel1.LostFocus
        If Trim(PeaceLabel1.Text) = "" Then
            PeaceLabel1.BackColor = cLostFocusColor
        Else
            PeaceLabel1.BackColor = cGotFocusColorText
        End If
        RaiseEvent txtTextLostFocus(sender, e)
    End Sub


#End Region
End Class
