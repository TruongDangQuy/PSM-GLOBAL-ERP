Public Class SelectPeaceCalSin
    Private m_ButtonName As String
    Private m_ButtonTitle As String = "DATE"
    Private m_percent As Double = 0.3366
    Private m_data As New DATASPACE
    Private m_ButtonFont As Font
    Private m_ButtonEnabled As Boolean = True
    Private m_ButtonBackColor As Color = Color.FromArgb(255, 255, 128)

    Private m_DataValue As Integer = 0
    Private m_DataLen As Integer = 0
    Private m_DataDecimal As Integer = 0

    Private m_TextBoxEnabled As Boolean = True
    Private m_TextBoxMultiline As Boolean = True
    Private m_TextBoxScrollBars As ScrollBars = ScrollBars.None
    Private m_TextBoxMaxLength As Integer = 32767
    Private m_TextBoxForeColor As Color
    Private m_TextBoxAlign As HorizontalAlignment = HorizontalAlignment.Left
    Private m_TextBoxBorderStyle As DevExpress.XtraEditors.Controls.BorderStyles = DevExpress.XtraEditors.Controls.BorderStyles.Simple
    Private m_TextBoxfont As Font

    Private m_TextBoxAutoComplete As Boolean = False
    Public Event m_Textchange As EventHandler

    Public Event txtTextKeyDown As KeyEventHandler
    Public Event txtTextGotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Event txtTextLostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)

#Region "Format Decimal"
    Private m_FormatNumber As Boolean = False
    Private m_FormatDecimal As Integer = 0

    Public Property FormatValue() As Boolean
        Get
            Return m_FormatNumber
        End Get
        Set(ByVal Value As Boolean)
            m_FormatNumber = Value
        End Set
    End Property
    Public Property FormatDecimal() As Integer
        Get
            Return m_FormatDecimal
        End Get
        Set(value As Integer)
            m_FormatDecimal = value

        End Set
    End Property
#End Region
    Private Sub PeaceButton1_Click(sender As Object, e As EventArgs) Handles PeaceButton1.Click
        Dim Sdate As Date
        Try
            If cn.State = ConnectionState.Closed Then Exit Sub

            Sdate = New Date(Strings.Left(Me.Data, 4), Mid(Me.Data, 5, 2), Strings.Right(Me.Data, 2))
            sday = CIntp(Strings.Right(Data, 2))
            smonth = CIntp(Strings.Mid(Data, 5, 2))
            syearn = CIntp(Strings.Left(Data, 4))

            Call CALENDAR_SINGLE.CALENDAR_SINGLE_Link()

            If syearn > 0 And smonth > 0 And sday > 0 Then
                Me.Data = syearn & smonth.ToString("00") & sday.ToString("00")
            Else
                Me.Data = ""
            End If
            PeaceMaskedtextbox1.Focus()
        Catch ex As Exception
            Me.Data = System_Date_8()
        End Try
    End Sub
    Public Property TextBoxAutoComplete() As Boolean
        Get
            Return m_TextBoxAutoComplete
        End Get
        Set(ByVal Value As Boolean)
            m_TextBoxAutoComplete = Value
            PeaceMaskedtextbox1.NoClear = Value
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
        Set(ByVal Value As Font)
            m_ButtonFont = Value
            PeaceButton1.Font = Value
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

    Public Property ButtonTitle() As String
        Get
            Return m_ButtonTitle
        End Get
        Set(ByVal Value As String)
            m_ButtonTitle = Value
            PeaceButton1.Text = Value
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

    Public Property DataValue() As Integer
        Get
            Return m_DataValue
        End Get
        Set(value As Integer)
            m_DataValue = value
            PeaceMaskedtextbox1.DTValue = value
        End Set
    End Property

    Public Property DataLen() As Integer
        Get
            Return m_DataLen
        End Get
        Set(value As Integer)
            m_DataLen = value
            PeaceMaskedtextbox1.DTLen = value
        End Set
    End Property

    Public Property DataDecimal() As Integer
        Get
            Return m_DataDecimal
        End Get
        Set(value As Integer)
            m_DataDecimal = value
            PeaceMaskedtextbox1.DTDec = value
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
    Public Property Code() As String
        Get
            If m_data.CODE = "" Then Return "" Else Return FormatCut(m_data.CODE)
        End Get
        Set(ByVal Value As String)
            m_data.CODE = Value
            Me.PeaceMaskedtextbox1.Tag = Value
        End Set
    End Property
    Public Property Data() As String
        Get
            If m_data.NAME = "" Then Return "" Else Return FormatCut(m_data.NAME)
        End Get
        Set(ByVal Value As String)
            m_data.NAME = Value
            Me.PeaceMaskedtextbox1.Text = Value
        End Set
    End Property
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PeaceMaskedtextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PeaceMaskedtextbox1.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) And IsDate(PeaceMaskedtextbox1.Text) Then
                SendKeys.Send("{TAB}")
            ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) And Not IsDate(PeaceMaskedtextbox1.Text) Then
                Me.PeaceMaskedtextbox1.Text = System_Date_8()
                PeaceMaskedtextbox1.SelectAll()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PeaceMaskedtextbox1_TextChanged(sender As Object, e As EventArgs) Handles PeaceMaskedtextbox1.TextChanged
        Data = PeaceMaskedtextbox1.Text
        Code = PeaceMaskedtextbox1.Tag

        RaiseEvent m_Textchange(sender, e)
    End Sub

    Private Sub PeaceTextbox1_KeyDown(sender As Object, e As KeyEventArgs) Handles PeaceMaskedtextbox1.KeyDown
        RaiseEvent txtTextKeyDown(sender, e)
    End Sub


    Private Sub txtText_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeaceMaskedtextbox1.GotFocus

        PeaceMaskedtextbox1.SelectAll()

        RaiseEvent txtTextGotFocus(sender, e)
    End Sub
    Private Sub txtText_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeaceMaskedtextbox1.LostFocus


        RaiseEvent txtTextLostFocus(sender, e)
    End Sub

End Class
