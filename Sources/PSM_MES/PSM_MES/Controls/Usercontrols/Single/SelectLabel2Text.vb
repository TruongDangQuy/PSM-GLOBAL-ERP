Public Class SelectLabel2Text
#Region "Field"
    Private m_Data1 As New DATASPACE

    Private m_Data2 As New DATASPACE

    Private m_SendTab As Boolean = True

    Private m_Clicked1 As Boolean = False
    Private m_Clicked2 As Boolean = False

    Private m_CellBorderStyle As TableLayoutPanelCellBorderStyle = TableLayoutPanelCellBorderStyle.Single

    Private m_ButtonTitle As String
    Private m_LableBorderStyle As FlatStyle
    Private m_LableTitle As String
    Private m_LableEnabled As Boolean = True
    Private m_LableBackColor As Color
    Private m_LableFont As Font = New Font("Tahoma", 9, FontStyle.Bold)
    Private m_LableColor As Color

    Private m_DataValue As Integer = 0
    Private m_DataLen As Integer = 0
    Private m_DataDecimal As Integer = 0

    Private m_DataValue1 As Integer = 0
    Private m_DataLen1 As Integer = 0
    Private m_DataDecimal1 As Integer = 0


    Private m_percent As Decimal = 0.3366
    Private m_Text1BoxBackColorYN As Boolean = False
    Private m_Text1BoxEnabled As Boolean = True
    Private m_Text1BoxMultiline As Boolean = True
    Private m_Text1BoxScrollBars As ScrollBars = ScrollBars.None
    Private m_Text1BoxMaxLength As Integer = 32767
    Private m_Text1BoxForeColor As Color
    Private m_Text1BoxAlign As HorizontalAlignment = HorizontalAlignment.Left
    Private m_Text1BoxBorderStyle As BorderStyle = Windows.Forms.BorderStyle.Fixed3D
    Private m_Text1Boxfont As Font = New Font("Tahoma", 9)
    Private m_Text1BoxBackColor As Color

    Private m_Text2BoxBackColorYN As Boolean = False
    Private m_Text2BoxEnabled As Boolean = True
    Private m_Text2BoxMultiline As Boolean = True
    Private m_Text2BoxScrollBars As ScrollBars = ScrollBars.None
    Private m_Text2BoxMaxLength As Integer = 32767
    Private m_Text2BoxForeColor As Color
    Private m_Text2BoxAlign As HorizontalAlignment = HorizontalAlignment.Left
    Private m_Text2BoxBorderStyle As BorderStyle = Windows.Forms.BorderStyle.Fixed3D
    Private m_Text2Boxfont As Font = New Font("Tahoma", 9)
    Private m_Text2BoxBackColor As Color


    Private m_TextBoxAutoComplete As Boolean = False
    Private m_TextBoxAutoComplete1 As Boolean = False

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
    Public Property ButtonTitle() As String
        Get
            Return m_ButtonTitle
        End Get
        Set(ByVal Value As String)
            m_ButtonTitle = Value
            lbl_name.Text = Value
        End Set
    End Property
    Public Property TextBoxAutoComplete() As Boolean
        Get
            Return m_TextBoxAutoComplete
        End Get
        Set(ByVal Value As Boolean)
            m_TextBoxAutoComplete = Value
            text1.NoClear = Value
        End Set
    End Property

    Public Property TextBoxAutoComplete1() As Boolean
        Get
            Return m_TextBoxAutoComplete1
        End Get
        Set(ByVal Value As Boolean)
            m_TextBoxAutoComplete1 = Value
            text2.NoClear = Value
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

#Region "Label"
    Public Property LableTitle() As String
        Get
            Return m_LableTitle
        End Get
        Set(ByVal Value As String)
            m_LableTitle = Value
            lbl_name.Text = Value
        End Set
    End Property
    Public Property LableEnabled() As Boolean
        Get
            Return m_LableEnabled
        End Get
        Set(ByVal Value As Boolean)

            m_LableEnabled = Value
            lbl_name.Enabled = Value

            If Value = False Then
                lbl_name.ForeColor = cForeColor
            End If

        End Set
    End Property


    Public Property LableBackColor As Color
        Get
            Return m_LableBackColor
        End Get
        Set(value As Color)
            m_LableBackColor = value
            lbl_name.BackColor = value
        End Set
    End Property
    Public Property LableFont() As Font
        Get
            Return m_LableFont
        End Get
        Set(value As Font)
            m_LableFont = value
            lbl_name.Font = value
        End Set
    End Property

    Public Property LableForeColor() As Color
        Get
            Return m_LableColor
        End Get
        Set(value As Color)
            m_LableColor = value
            lbl_name.ForeColor = value
        End Set
    End Property
    Public Property DataValue() As Integer
        Get
            Return m_DataValue
        End Get
        Set(value As Integer)
            m_DataValue = value
            text1.DTValue = value
        End Set
    End Property

    Public Property DataLen() As Integer
        Get
            Return m_DataLen
        End Get
        Set(value As Integer)
            m_DataLen = value
            text1.DTLen = value
        End Set
    End Property

    Public Property DataDecimal() As Integer
        Get
            Return m_DataDecimal
        End Get
        Set(value As Integer)
            m_DataDecimal = value
            text1.DTDec = value
        End Set
    End Property

    Public Property DataValue1() As Integer
        Get
            Return m_DataValue1
        End Get
        Set(value As Integer)
            m_DataValue1 = value
            text2.DTValue = value
        End Set
    End Property

    Public Property DataLen1() As Integer
        Get
            Return m_DataLen1
        End Get
        Set(value As Integer)
            m_DataLen1 = value
            text2.DTLen = value
        End Set
    End Property

    Public Property DataDecimal1() As Integer
        Get
            Return m_DataDecimal1
        End Get
        Set(value As Integer)
            m_DataDecimal1 = value
            text2.DTDec = value
        End Set
    End Property
    Public Property Layoutpercent() As Decimal
        Get
            Return m_percent
        End Get
        Set(value As Decimal)
            m_percent = value
            TableLayoutPanel1.ColumnStyles(0).SizeType = SizeType.Percent
            TableLayoutPanel1.ColumnStyles(1).SizeType = SizeType.Percent
            TableLayoutPanel1.ColumnStyles(2).SizeType = SizeType.Percent
            'TableLayoutPanel1.ColumnStyles(0).Width = value * TableLayoutPanel1.Width
            'TableLayoutPanel1.ColumnStyles(1).Width = value * TableLayoutPanel1.Width
            'TableLayoutPanel1.ColumnStyles(2).Width = (1 - value) * TableLayoutPanel1.Width
        End Set
    End Property
#End Region

#Region "Text2"
    Public Property BackYesno2() As Boolean
        Get
            Return m_Text2BoxBackColorYN
        End Get
        Set(ByVal Value As Boolean)
            m_Text2BoxBackColorYN = Value
        End Set
    End Property

    Public Property TextEnabled2() As Boolean
        Get
            Return m_Text2BoxEnabled
        End Get
        Set(ByVal Value As Boolean)

            m_Text2BoxEnabled = Value
            text2.Enabled = Value
            If m_Text2BoxBackColorYN = True Then Exit Property
            If Value = False Then
                text2.BackColor = cDisabledColor
            Else
                text2.BackColor = cEnabledColor
            End If

        End Set
    End Property

    Public Property TextMultiLine2() As Boolean
        Get
            Return m_Text2BoxMultiline
        End Get
        Set(ByVal Value As Boolean)

            m_Text2BoxMultiline = Value
            text2.Multiline = Value

        End Set
    End Property

    Public Property TextScrollBars2() As ScrollBars
        Get
            Return m_Text2BoxScrollBars
        End Get
        Set(ByVal Value As ScrollBars)
            text2.ScrollBars = Value
            m_Text2BoxScrollBars = Value
        End Set
    End Property

    Public Property TextMaxLength2() As Integer
        Get
            Return m_Text2BoxMaxLength
        End Get
        Set(ByVal Value As Integer)
            text2.MaxLength = Value
            m_Text2BoxMaxLength = Value
        End Set
    End Property

    Public Property TextStyle2() As BorderStyle
        Get
            Return m_Text2BoxBorderStyle
        End Get
        Set(ByVal Value As BorderStyle)

            m_Text2BoxBorderStyle = Value
            text2.BorderStyle = Value

        End Set
    End Property

    Public Property TextAlign2() As HorizontalAlignment
        Get
            Return m_Text2BoxAlign
        End Get
        Set(ByVal Value As HorizontalAlignment)

            m_Text2BoxAlign = Value
            text2.TextAlign = Value

        End Set
    End Property

    Public Property TextForeColor2() As Color
        Get
            Return m_Text2BoxForeColor
        End Get
        Set(ByVal Value As Color)

            m_Text2BoxForeColor = Value
            text2.ForeColor = Value

        End Set
    End Property

    Public Property TextBoxFont2() As Font
        Get
            Return m_Text2Boxfont
        End Get
        Set(ByVal Value As Font)

            m_Text2Boxfont = Value
            text2.Font = Value

        End Set
    End Property

    Public Property TextboxBackColor2() As Color
        Get
            Return m_Text2BoxBackColor
        End Get
        Set(ByVal value As Color)
            m_Text2BoxBackColor = value
            text2.BackColor = value
        End Set
    End Property

    Public Property Code2() As String
        Get
            Return m_Data2.CODE
        End Get
        Set(ByVal Value As String)

            m_Data2.CODE = Value
            text2.Tag = Value

        End Set
    End Property
    Public Property Data2() As String
        Get
            Return m_Data2.NAME
        End Get
        Set(ByVal Value As String)

            m_Data2.NAME = Value
            text2.Text = Value

        End Set
    End Property

#End Region

#Region "Text1"
    Public Property BackYesno1() As Boolean
        Get
            Return m_Text1BoxBackColorYN
        End Get
        Set(ByVal Value As Boolean)
            m_Text1BoxBackColorYN = Value
        End Set
    End Property

    Public Property TextEnabled1() As Boolean
        Get
            Return m_Text1BoxEnabled
        End Get
        Set(ByVal Value As Boolean)

            m_Text1BoxEnabled = Value
            text1.Enabled = Value
            If m_Text1BoxBackColorYN = True Then Exit Property
            If Value = False Then
                text1.BackColor = cDisabledColor
            Else
                text1.BackColor = cEnabledColor
            End If

        End Set
    End Property

    Public Property TextMultiLine1() As Boolean
        Get
            Return m_Text1BoxMultiline
        End Get
        Set(ByVal Value As Boolean)

            m_Text1BoxMultiline = Value
            text1.Multiline = Value

        End Set
    End Property

    Public Property TextScrollBars1() As ScrollBars
        Get
            Return m_Text1BoxScrollBars
        End Get
        Set(ByVal Value As ScrollBars)
            text1.ScrollBars = Value
            m_Text1BoxScrollBars = Value
        End Set
    End Property

    Public Property TextMaxLength1() As Integer
        Get
            Return m_Text1BoxMaxLength
        End Get
        Set(ByVal Value As Integer)
            text1.MaxLength = Value
            m_Text1BoxMaxLength = Value
        End Set
    End Property

    Public Property TextStyle1() As BorderStyle
        Get
            Return m_Text1BoxBorderStyle
        End Get
        Set(ByVal Value As BorderStyle)

            m_Text1BoxBorderStyle = Value
            text1.BorderStyle = Value

        End Set
    End Property

    Public Property TextAlign1() As HorizontalAlignment
        Get
            Return m_Text1BoxAlign
        End Get
        Set(ByVal Value As HorizontalAlignment)

            m_Text1BoxAlign = Value
            text1.TextAlign = Value

        End Set
    End Property

    Public Property TextForeColor1() As Color
        Get
            Return m_Text1BoxForeColor
        End Get
        Set(ByVal Value As Color)

            m_Text1BoxForeColor = Value
            text1.ForeColor = Value

        End Set
    End Property

    Public Property TextBoxFont1() As Font
        Get
            Return m_Text1Boxfont
        End Get
        Set(ByVal Value As Font)

            m_Text1Boxfont = Value
            text1.Font = Value

        End Set
    End Property

    Public Property TextboxBackColor1() As Color
        Get
            Return m_Text1BoxBackColor
        End Get
        Set(ByVal value As Color)
            m_Text1BoxBackColor = value
            text1.BackColor = value
        End Set
    End Property

    Public Property Code1() As String
        Get
            Return m_Data1.CODE
        End Get
        Set(ByVal Value As String)

            m_Data1.CODE = Value
            text1.Tag = Value

        End Set
    End Property
    Public Property Data1() As String
        Get
            Return m_Data1.NAME
        End Get
        Set(ByVal Value As String)

            m_Data1.NAME = Value
            text1.Text = Value

        End Set
    End Property

#End Region
#Region "Event Method Click - Focus ..."

    Private Sub btnTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        RaiseEvent btnTitleClick(sender, e)

        text2.Focus()

    End Sub

    Private Sub txtText_MouseDown2(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles text2.MouseDown

        m_Clicked2 = True

    End Sub

    Private Sub txtText_MouseUp2(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles text2.MouseUp

        m_Clicked2 = False

    End Sub

    Private Sub txtText_MouseDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles text1.MouseDown

        m_Clicked1 = True

    End Sub

    Private Sub txtText_MouseUp1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles text1.MouseUp

        m_Clicked1 = False

    End Sub


    Private Sub btnTitle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        RaiseEvent btnTitleKeyDown(sender, e)

    End Sub

    Private Sub txtText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text2.TextChanged
        Data2 = text2.Text
        Code2 = text2.Tag
        RaiseEvent txtTextChanged(sender, e)

    End Sub
    Private Sub txtText1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text1.TextChanged
        Data1 = text1.Text
        Code1 = text1.Tag
        RaiseEvent txtTextChanged(sender, e)

    End Sub

    Private Sub txtText_GotFocus2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text2.GotFocus
        If m_Text2BoxBackColorYN = True Then Exit Sub
        text2.BackColor = cGotFocusColor

        If m_Clicked2 = False Then
            text2.SelectAll()
        Else
            m_Clicked2 = False

        End If

    End Sub

    Private Sub txtText_LostFocus2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text2.LostFocus
        If m_Text2BoxBackColorYN = True Then Exit Sub
        If Trim(text2.Text) = "" Then
            text2.BackColor = cLostFocusColor
        Else
            text2.BackColor = cGotFocusColorText
        End If
        RaiseEvent txtTextLostFocus(sender, e)

    End Sub


    Private Sub txtText_GotFocus1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text1.GotFocus
        If m_Text1BoxBackColorYN = True Then Exit Sub
        text1.BackColor = cGotFocusColor

        If m_Clicked1 = False Then
            text1.SelectAll()
        Else
            m_Clicked1 = False

        End If

    End Sub

    Private Sub txtText_LostFocus1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text1.LostFocus
        If m_Text2BoxBackColorYN = True Then Exit Sub
        If Trim(text1.Text) = "" Then
            text1.BackColor = cLostFocusColor
        Else
            text1.BackColor = cGotFocusColorText
        End If
        RaiseEvent txtTextLostFocus(sender, e)

    End Sub


#End Region


#End Region


End Class
