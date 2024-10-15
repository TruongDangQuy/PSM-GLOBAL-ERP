Public Class SelectPeace2Label

#Region "Field"
    Private m_Data As New DATASPACE
    Private m_Data1 As New DATASPACE
    Private m_SendTab As Boolean = True

    Private m_Clicked As Boolean = False

    Private m_CellBorderStyle As TableLayoutPanelCellBorderStyle = TableLayoutPanelCellBorderStyle.Single

    Private m_ButtonBorderStyle As FlatStyle
    Private m_ButtonTitle As String
    Private m_ButtonEnabled As Boolean = True
    Private m_ButtonBackColor As Color
    Private m_ButtonFont As Font
    Private m_ButtonColor As Color

    Private m_percent As String = "40,30,30"
    Private m_LabelForeColor As Color
    Private m_LabelFont As Font
    Private m_Label2ForeColor As Color
    Private m_Label2Text As String
    Private m_Label2Font As Font
    Private m_Label1Layout As ContentAlignment = ContentAlignment.MiddleCenter
    Private m_Label2Layout As ContentAlignment = ContentAlignment.MiddleCenter
    Private m_Label1BackColor As Color
    Private m_Label2BackColor As Color
    '  Private m_Data1 As New DATASPACE
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

    'Public Property Layoutpercent As Decimal
    '    Get
    '        Return m_percent
    '    End Get
    '    Set(value As Decimal)
    '        m_percent = value
    '        TableLayoutPanel1.ColumnStyles(0).SizeType = SizeType.Percent
    '        TableLayoutPanel1.ColumnStyles(1).SizeType = SizeType.Percent
    '        TableLayoutPanel1.ColumnStyles(2).SizeType = SizeType.Percent
    '        TableLayoutPanel1.ColumnStyles(0).Width = value * TableLayoutPanel1.Width
    '        ' TableLayoutPanel1.ColumnStyles(1).Width = (1 - value) * TableLayoutPanel1.Width
    '    End Set
    'End Property
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
    Public Property Code1() As String
        Get
            Return m_Data1.CODE
        End Get
        Set(ByVal Value As String)

            m_Data1.CODE = Value
            PeaceLabel2.Tag = Value

        End Set
    End Property
    Public Property Data1() As String
        Get
            Return m_Data1.NAME
        End Get
        Set(ByVal Value As String)

            m_Data1.NAME = Value
            PeaceLabel2.Text = Value

        End Set
    End Property

    Public Property LabelFont() As Font
        Get
            Return m_LabelFont
        End Get
        Set(value As Font)
            m_LabelFont = value
            PeaceLabel1.Font = value
            PeaceLabel2.Font = value
        End Set
    End Property

    Public Property LabelForeColor() As Color
        Get
            Return m_LabelForeColor
        End Get
        Set(value As Color)
            m_LabelForeColor = value
            PeaceLabel1.ForeColor = value
        End Set
    End Property

    Public Property Label2ForeColor() As Color
        Get
            Return m_Label2ForeColor
        End Get
        Set(value As Color)
            m_Label2ForeColor = value
            PeaceLabel2.ForeColor = value
        End Set
    End Property

    Public Property Label2Text() As String
        Get
            Return m_Label2Text
        End Get
        Set(value As String)
            m_Label2Text = value
            PeaceLabel2.Text = value
        End Set
    End Property
    Public Property Label1Layout() As ContentAlignment
        Get
            Return m_Label1Layout
        End Get
        Set(value As ContentAlignment)
            m_Label1Layout = value
            PeaceLabel1.TextAlign = value
        End Set
    End Property

    Public Property Label2Layout() As ContentAlignment
        Get
            Return m_Label2Layout
        End Get
        Set(value As ContentAlignment)
            m_Label2Layout = value
            PeaceLabel2.TextAlign = value
        End Set
    End Property

    Public Property Label1BackColor As Color
        Get
            Return m_Label1BackColor
        End Get
        Set(value As Color)
            m_Label1BackColor = value
            PeaceLabel1.BackColor = value
        End Set
    End Property
    Public Property Label2BackColor As Color
        Get
            Return m_Label2BackColor
        End Get
        Set(value As Color)
            m_Label2BackColor = value
            PeaceLabel2.BackColor = value
        End Set
    End Property

#End Region








    
End Class
