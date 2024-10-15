Public Class SelectPeaceCalDou
    Private m_TextBoxfont As Font
    Private m_text1 As String
    Private m_text2 As String
    Private m_ButtonTitle As String
    Private Event m_textchanged As EventHandler

    Public Event txtTextKeyDown As KeyEventHandler
    Public Event txtTextChange As EventHandler

    Public Event btnTitleClick As EventHandler
    Public Property ButtonTitle() As String
        Get
            Return m_ButtonTitle
        End Get
        Set(ByVal Value As String)
            m_ButtonTitle = Value
            PeaceButton1.Text = Value
        End Set
    End Property
    Public Property text1() As String
        Get
            Return FormatCut(m_text1)
        End Get
        Set(ByVal Value As String)
            m_text1 = Value
            sdate.Text = Value
        End Set
    End Property
    Public Property text2() As String
        Get
            Return FormatCut(m_text2)
        End Get
        Set(ByVal Value As String)
            m_text2 = Value
            edate.Text = Value
        End Set
    End Property
    Public Property TextBoxFont() As Font
        Get
            Return m_TextBoxfont
        End Get
        Set(ByVal Value As Font)
            m_TextBoxfont = Value
            sdate.Font = Value
            edate.Font = Value
        End Set
    End Property

    Public Sub btnTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeaceButton1.Click
        Try
            If IsNumeric(text1) = False Then text1 = System_Date_8()
            If IsNumeric(text2) = False Then text2 = System_Date_8()
            sday = CInt(Strings.Right(text1, 2))
            eday = CInt(Strings.Right(text2, 2))
            smonth = CInt(Strings.Mid(text1, 5, 2))
            emonth = CInt(Strings.Mid(text2, 5, 2))
            syearn = CInt(Strings.Left(text1, 4))
            eyearn = CInt(Strings.Left(text2, 4))
            CALENDAR_DOUBLE.ShowDialog()
            Me.text1 = syearn & smonth.ToString("00") & sday.ToString("00")
            Me.text2 = eyearn & emonth.ToString("00") & eday.ToString("00")

            RaiseEvent btnTitleClick(sender, e)

        Catch ex As Exception
            text1 = System_Date_8()
            text2 = System_Date_8()
        End Try


    End Sub

    Public Sub New()
        InitializeComponent()
        Me.text1 = System_Date_8()
        Me.text2 = System_Date_8()
    End Sub

    Private Sub PeaceMaskedtextbox1_TextChanged(sender As Object, e As EventArgs) Handles sdate.TextChanged, edate.TextChanged
        If sender.Equals(sdate) Then
            text1 = sdate.Text
        End If
        If sender.Equals(edate) Then
            text2 = edate.Text
        End If

        RaiseEvent txtTextChange(sender, e)
    End Sub


    Private Sub sdate_KeyDown(sender As Object, e As KeyEventArgs) Handles sdate.KeyDown
        RaiseEvent txtTextKeyDown(sender, e)
    End Sub

    Private Sub edate_KeyDown(sender As Object, e As KeyEventArgs) Handles edate.KeyDown
        RaiseEvent txtTextKeyDown(sender, e)
    End Sub
End Class
