Imports System.Drawing
Imports System.Windows.Forms
Public Class SelectPeaceMaskText
#Region "Field"
    Private m_Data As New DATASPACE
    Private m_SendTab As Boolean = True
    Private m_SetFocus As Boolean = True

    Private m_Clicked As Boolean = False

    Private m_CellBorderStyle As TableLayoutPanelCellBorderStyle = TableLayoutPanelCellBorderStyle.Single

    Private m_ButtonBorderStyle As FlatStyle
    Private m_ButtonTitle As String
    Private m_ButtonEnabled As Boolean = True
    Private m_ButtonFont As Font
    Private m_ButtonColor As Color

    Private m_TextBoxMask As String
    Private m_percent As Decimal = 0.3366
    Private m_TextBoxEnabled As Boolean = True
    Private m_TextBoxMultiline As Boolean = True
    Private m_TextBoxScrollBars As ScrollBars = ScrollBars.None
    Private m_TextBoxMaxLength As Integer = 32767
    Private m_TextBoxForeColor As Color
    Private m_TextBoxAlign As HorizontalAlignment = HorizontalAlignment.Left
    Private m_TextBoxBorderStyle As DevExpress.XtraEditors.Controls.BorderStyles = DevExpress.XtraEditors.Controls.BorderStyles.Simple
    Private m_TextBoxfont As Font = New Font("Tahoma", 9)

    Private m_TextBoxAutoComplete As Boolean = False
#End Region
#Region "Event"
    Public Event btnTitleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event btnTitleKeyDown As KeyEventHandler
    Public Event txtTextKeyDown As KeyEventHandler
    Public Event txtTextChanged As EventHandler
    Public Event txtTextKeyPress As KeyPressEventHandler
    Public Event txtTextLostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)

#End Region
    Public Sub New()

        ' 이 호출은 Windows Form 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

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

    Public Property SetTextFocus() As Boolean
        Get
            Return m_SetFocus
        End Get
        Set(ByVal Value As Boolean)
            m_SetFocus = Value
            If Value = True Then
                PeaceMaskedtextbox1.Focus()
            End If
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
            PeaceMaskedtextbox1.Enabled = Value

            If Value = False Then
                PeaceMaskedtextbox1.BackColor = cDisabledColor
            Else
                PeaceMaskedtextbox1.BackColor = cEnabledColor
            End If

        End Set
    End Property

    Public Property TextMultiLine() As Boolean
        Get
            Return m_TextBoxMultiline
        End Get
        Set(ByVal Value As Boolean)

            m_TextBoxMultiline = Value
            PeaceMaskedtextbox1.Multiline = Value

        End Set
    End Property

    Public Property TextScrollBars() As ScrollBars
        Get
            Return m_TextBoxScrollBars
        End Get
        Set(ByVal Value As ScrollBars)
            '  PeaceMaskedtextbox1.ScrollBars = Value
            m_TextBoxScrollBars = Value
        End Set
    End Property

    Public Property TextMaxLength() As Integer
        Get
            Return m_TextBoxMaxLength
        End Get
        Set(ByVal Value As Integer)
            PeaceMaskedtextbox1.MaxLength = Value
            m_TextBoxMaxLength = Value
        End Set
    End Property

    Public Property TextStyle() As DevExpress.XtraEditors.Controls.BorderStyles
        Get
            Return m_TextBoxBorderStyle
        End Get
        Set(ByVal Value As DevExpress.XtraEditors.Controls.BorderStyles)

            m_TextBoxBorderStyle = Value
            PeaceMaskedtextbox1.BorderStyle = Value

        End Set
    End Property

    Public Property TextAlign() As HorizontalAlignment
        Get
            Return m_TextBoxAlign
        End Get
        Set(ByVal Value As HorizontalAlignment)

            m_TextBoxAlign = Value
            PeaceMaskedtextbox1.TextAlign = Value

        End Set
    End Property

    Public Property TextForeColor() As Color
        Get
            Return m_TextBoxForeColor
        End Get
        Set(ByVal Value As Color)

            m_TextBoxForeColor = Value
            PeaceMaskedtextbox1.ForeColor = Value

        End Set
    End Property

    Public Property TextBoxFont() As Font
        Get
            Return m_TextBoxfont
        End Get
        Set(ByVal Value As Font)

            m_TextBoxfont = Value
            PeaceMaskedtextbox1.Font = Value

        End Set
    End Property

    Public Property TextMask() As String
        Get
            Return m_TextBoxMask
        End Get
        Set(value As String)
            m_TextBoxMask = value
            PeaceMaskedtextbox1.AllowPromptAsInput = True
            PeaceMaskedtextbox1.PromptChar = "_"
            PeaceMaskedtextbox1.ValidatingType = GetType(System.ICustomFormatter)
            PeaceMaskedtextbox1.Mask = value

        End Set
    End Property

    Public Property Code() As String
        Get
            Return m_Data.CODE
        End Get
        Set(ByVal Value As String)

            m_Data.CODE = Value
            PeaceMaskedtextbox1.Tag = Value

        End Set
    End Property
    Public Property Data() As String
        Get
            Return m_Data.NAME
        End Get
        Set(ByVal Value As String)

            m_Data.NAME = Value
            PeaceMaskedtextbox1.Text = Value

        End Set
    End Property

#End Region
#Region "Event Method Click - Focus ..."

    Private Sub btnTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeaceButton1.Click

        RaiseEvent btnTitleClick(sender, e)

        PeaceMaskedtextbox1.Focus()

    End Sub

    Private Sub PeaceTextbox1_KeyDown(sender As Object, e As KeyPressEventArgs) Handles PeaceMaskedtextbox1.KeyPress
        RaiseEvent txtTextKeyPress(sender, e)
    End Sub

    Private Sub txtText_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PeaceMaskedtextbox1.MouseDown

        m_Clicked = True

    End Sub

    Private Sub txtText_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PeaceMaskedtextbox1.MouseUp

        m_Clicked = False

    End Sub



    Private Sub btnTitle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PeaceButton1.KeyDown

        RaiseEvent btnTitleKeyDown(sender, e)

    End Sub

    Private Sub txtText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeaceMaskedtextbox1.TextChanged
        RaiseEvent txtTextChanged(sender, e)
        Data = PeaceMaskedtextbox1.Text
        Code = ""

    End Sub

    Private Sub txtText_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeaceMaskedtextbox1.GotFocus

        PeaceMaskedtextbox1.BackColor = cGotFocusColor

        If m_Clicked = False Then

            PeaceMaskedtextbox1.SelectAll()

        Else

            m_Clicked = False

        End If

    End Sub

    Private Sub txtText_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeaceMaskedtextbox1.LostFocus

        PeaceMaskedtextbox1.BackColor = cLostFocusColor

        RaiseEvent txtTextLostFocus(sender, e)

    End Sub


#End Region
End Class
