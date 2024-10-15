Public Class SelectPeaceCalLR
    Private m_ButtonName As String
    Private m_ButtonTitle As String = "DATE"
    Private m_percent As String = "40,40,10,10"
    Private m_data As New DATASPACE

    Private m_TextBoxEnabled As Boolean = True
    Private m_TextBoxMultiline As Boolean = True
    Private m_TextBoxScrollBars As ScrollBars = ScrollBars.None
    Private m_TextBoxMaxLength As Integer = 32767
    Private m_TextBoxForeColor As Color
    Private m_TextBoxAlign As HorizontalAlignment = HorizontalAlignment.Center
    Private m_TextBoxBorderStyle As DevExpress.XtraEditors.Controls.BorderStyles = DevExpress.XtraEditors.Controls.BorderStyles.Simple
    Private m_TextBoxfont As Font

    Public Event m_buttonclick As EventHandler
#Region "Event"
    Public Event btnTitleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event btnTitleKeyDown As KeyEventHandler
    Public Event txtTextKeyDown As KeyEventHandler
    Public Event txtTextChanged As EventHandler
    Public Event txtTextKeyPress As KeyPressEventHandler
    Public Event txtTextLostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)

#End Region
    Private Sub PeaceButton1_Click(sender As Object, e As EventArgs) Handles PeaceButton1.Click
        CALENDAR_SINGLE.ShowDialog()
        Me.Data = syearn & smonth.ToString("00") & sday.ToString("00")
        Me.Code = syearn & smonth.ToString("00") & sday.ToString("00")
    End Sub
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
            TableLayoutPanel1.ColumnStyles(3).SizeType = SizeType.Percent
            TableLayoutPanel1.ColumnStyles(0).Width = CDbl(a(0))
            TableLayoutPanel1.ColumnStyles(1).Width = CDbl(a(1))
            TableLayoutPanel1.ColumnStyles(2).Width = CDbl(a(2))
            TableLayoutPanel1.ColumnStyles(3).Width = CDbl(a(2))
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
            Return m_Data.CODE
        End Get
        Set(ByVal Value As String)
            m_data.CODE = Value
            Me.PeaceMaskedtextbox1.Tag = Value
        End Set
    End Property
    Public Property Data() As String
        Get
            Return m_Data.NAME
        End Get
        Set(ByVal Value As String)
            m_data.NAME = Value
            Me.PeaceMaskedtextbox1.Text = Value
        End Set
    End Property
    Private Sub txtText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeaceMaskedtextbox1.TextChanged
        RaiseEvent txtTextChanged(sender, e)
        Data = PeaceMaskedtextbox1.Text
        Code = ""

    End Sub
    Private Sub txtText_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeaceMaskedtextbox1.LostFocus

        PeaceMaskedtextbox1.BackColor = cLostFocusColor

        RaiseEvent txtTextLostFocus(sender, e)

    End Sub

    Private Sub PeaceButton2_Click(sender As Object, e As EventArgs) Handles PeaceButton2.Click, PeaceButton3.Click
        If sender.Equals(PeaceButton2) Then
            Dim a As DateTime = New Date(Strings.Left(Me.Data.Replace("-", ""), 4), Strings.Mid(Me.Data.Replace("-", ""), 5, 2), Strings.Right(Me.Data.Replace("-", ""), 2))
            a = a.AddDays(-1)
            Me.Data = a.Year & a.Month.ToString("00") & a.Day.ToString("00")
            RaiseEvent m_buttonclick(sender, e)
        End If
        If sender.Equals(PeaceButton3) Then
            Dim a As DateTime = New Date(Strings.Left(Me.Data.Replace("-", ""), 4), Strings.Mid(Me.Data.Replace("-", ""), 5, 2), Strings.Right(Me.Data.Replace("-", ""), 2))
            a = a.AddDays(1)
            Me.Data = a.Year & a.Month.ToString("00") & a.Day.ToString("00")
            RaiseEvent m_buttonclick(sender, e)
        End If

    End Sub
End Class
