Public Class SelectLabelLable
#Region "Field"
    Private m_Data As New DATASPACE
    Private m_SendTab As Boolean = True

    Private m_Clicked As Boolean = False

    Private m_CellBorderStyle As TableLayoutPanelCellBorderStyle = TableLayoutPanelCellBorderStyle.Single

    Private m_LableBorderStyle As FlatStyle
    Private m_LableEnabled As Boolean = True
    Private m_LableBackColor As Color
    Private m_LableFont As Font = New Font("Tahoma", 9, FontStyle.Bold)
    Private m_LableColor As Color = Color.White
    Private m_ButtonAlign As ContentAlignment = ContentAlignment.MiddleLeft
    Private m_ButtonStyle As BorderStyle = Windows.Forms.BorderStyle.FixedSingle


    Private m_DataValue As Integer = 0
    Private m_DataLen As Integer = 0
    Private m_DataDecimal As Integer = 0

    Private m_percent As Decimal = 0.3366
    Private m_ButtonTitle As String
    Private m_TextBoxBackColorYN As Boolean = False
    Private m_TextBoxEnabled As Boolean = True
    Private m_TextBoxMultiline As Boolean = True
    Private m_TextBoxScrollBars As ScrollBars = ScrollBars.None
    Private m_TextBoxMaxLength As Integer = 32767
    Private m_TextBoxForeColor As Color
    Private m_TextBoxAlign As ContentAlignment = ContentAlignment.MiddleLeft
    Private m_TextBoxBorderStyle As DevExpress.XtraEditors.Controls.BorderStyles = DevExpress.XtraEditors.Controls.BorderStyles.Simple
    Private m_TextBoxfont As Font = New Font("Tahoma", 9)
    Private m_TextBoxBackColor As Color


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
    Public Property TextScrollBars() As ScrollBars
        Get
            Return m_TextBoxScrollBars
        End Get
        Set(ByVal Value As ScrollBars)
            m_TextBoxScrollBars = Value
        End Set
    End Property
    Public Property TextMultiLine() As Boolean
        Get
            Return m_TextBoxMultiline
        End Get
        Set(ByVal Value As Boolean)

            m_TextBoxMultiline = Value
        End Set
    End Property
    Public Property TextMaxLength() As Integer
        Get
            Return m_TextBoxMaxLength
        End Get
        Set(ByVal Value As Integer)
            m_TextBoxMaxLength = Value
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
    Public Property TextBoxAutoComplete() As Boolean
        Get
            Return m_TextBoxAutoComplete
        End Get
        Set(ByVal Value As Boolean)
            m_TextBoxAutoComplete = Value
        End Set
    End Property
    Public Property ButtonTitle() As String
        Get
            Return m_ButtonTitle
        End Get
        Set(ByVal Value As String)
            m_ButtonTitle = Value
            lbl_name1.Text = Value
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


    Public Property LableEnabled() As Boolean
        Get
            Return m_LableEnabled
        End Get
        Set(ByVal Value As Boolean)

            m_LableEnabled = Value
            lbl_name1.Enabled = Value

        End Set
    End Property


    Public Property LableBackColor() As Color
        Get
            Return m_LableBackColor
        End Get
        Set(value As Color)
            m_LableBackColor = value
            lbl_name1.BackColor = value
        End Set
    End Property
    Public Property LableFont() As Font
        Get
            Return m_LableFont
        End Get
        Set(value As Font)
            m_LableFont = value
            lbl_name1.Font = value
        End Set
    End Property

    Public Property LableForeColor() As Color
        Get
            Return m_LableColor
        End Get
        Set(value As Color)
            m_LableColor = value
            lbl_name1.ForeColor = value
        End Set
    End Property

    Public Property DataValue() As Integer
        Get
            Return m_DataValue
        End Get
        Set(value As Integer)
            m_DataValue = value
        End Set
    End Property

    Public Property DataLen() As Integer
        Get
            Return m_DataLen
        End Get
        Set(value As Integer)
            m_DataLen = value
        End Set
    End Property

    Public Property DataDecimal() As Integer
        Get
            Return m_DataDecimal
        End Get
        Set(value As Integer)
            m_DataDecimal = value
        End Set
    End Property


    Public Property Layoutpercent As Decimal
        Get
            Return m_percent
        End Get
        Set(value As Decimal)
            m_percent = value
            If value > 0 Then
                TableLayoutPanel1.ColumnStyles(0).SizeType = SizeType.Percent
                TableLayoutPanel1.ColumnStyles(1).SizeType = SizeType.Percent
                TableLayoutPanel1.ColumnStyles(0).Width = value * TableLayoutPanel1.Width
                TableLayoutPanel1.ColumnStyles(1).Width = (1 - value) * TableLayoutPanel1.Width
            Else
                Me.lbl_name1.Dispose()
                TableLayoutPanel1.ColumnCount = 1
                lbl_name2.Margin = New Padding(0)
                lbl_name1.Margin = New Padding(0)
            End If
        End Set
    End Property

    Public Property BackYesno() As Boolean
        Get
            Return m_TextBoxBackColorYN
        End Get
        Set(ByVal Value As Boolean)
            m_TextBoxBackColorYN = Value
        End Set
    End Property

    Public Property TextEnabled() As Boolean
        Get
            Return m_TextBoxEnabled
        End Get
        Set(ByVal Value As Boolean)

            m_TextBoxEnabled = Value
            lbl_name2.Enabled = Value

        End Set
    End Property


    Public Property TextStyle() As DevExpress.XtraEditors.Controls.BorderStyles
        Get
            Return m_TextBoxBorderStyle
        End Get
        Set(ByVal Value As DevExpress.XtraEditors.Controls.BorderStyles)

            m_TextBoxBorderStyle = Value
            lbl_name2.BorderStyle = Value

        End Set
    End Property

    Public Property ButtonStyle() As BorderStyle
        Get
            Return m_ButtonStyle
        End Get
        Set(ByVal Value As BorderStyle)

            m_ButtonStyle = Value
            lbl_name1.BorderStyle = Value

        End Set
    End Property
    Public Property TextAlign() As ContentAlignment
        Get
            Return m_TextBoxAlign
        End Get
        Set(ByVal Value As ContentAlignment)

            m_TextBoxAlign = Value
            lbl_name2.TextAlign = Value

        End Set
    End Property

    Public Property ButtonAlign() As ContentAlignment
        Get
            Return m_ButtonAlign
        End Get
        Set(ByVal Value As ContentAlignment)

            m_ButtonAlign = Value
            lbl_name1.TextAlign = Value

        End Set
    End Property
    Public Property TextForeColor() As Color
        Get
            Return m_TextBoxForeColor
        End Get
        Set(ByVal Value As Color)

            m_TextBoxForeColor = Value
            lbl_name2.ForeColor = Value

        End Set
    End Property

    Public Property TextBoxFont() As Font
        Get
            Return m_TextBoxfont
        End Get
        Set(ByVal Value As Font)

            m_TextBoxfont = Value
            lbl_name2.Font = Value

        End Set
    End Property

    Public Property TextboxBackColor() As Color
        Get
            Return m_TextBoxBackColor
        End Get
        Set(ByVal value As Color)
            m_TextBoxBackColor = value
            lbl_name2.BackColor = value
        End Set
    End Property

    Public Property Code() As String
        Get
            Return m_Data.CODE
        End Get
        Set(ByVal Value As String)

            m_Data.CODE = Value
            lbl_name2.Tag = Value

        End Set
    End Property
    Public Property Data() As String
        Get
            Return m_Data.NAME
        End Get
        Set(ByVal Value As String)

            m_Data.NAME = Value
            lbl_name2.Text = Value

        End Set
    End Property

#End Region
#Region "Event Method Click - Focus ..."

    Private Sub btnTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_name1.Click

        RaiseEvent btnTitleClick(sender, e)

    End Sub


    Private Sub lbl_name2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_name2.TextChanged
        Data = lbl_name2.Text
        Code = lbl_name2.Tag
        RaiseEvent txtTextChanged(sender, e)

    End Sub


#End Region

End Class
