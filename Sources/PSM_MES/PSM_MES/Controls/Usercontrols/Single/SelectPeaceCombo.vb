Public Class SelectPeaceCombo

#Region "Field"
    Private m_Data As New DATASPACE
    Private m_SendTab As Boolean = True

    Private m_Clicked As Boolean = False

    Private m_CellBorderStyle As TableLayoutPanelCellBorderStyle = TableLayoutPanelCellBorderStyle.Single

    Private m_ButtonBorderStyle As FlatStyle
    Private m_ButtonTitle As String
    Private m_ButtonEnabled As Boolean = True
    Private m_ButtonBackColor As Color
    Private m_ButtonFont As Font
    Private m_ButtonColor As Color

    Private m_InSelected As Integer = -1

    Private m_DataValue As Integer = 0
    Private m_DataLen As Integer = 0
    Private m_DataDecimal As Integer = 0

    Private m_percent As Decimal = 0.3366

    Private m_TextBoxBackColorYN As Boolean = False
    Private m_TextBoxEnabled As Boolean = True
    Private m_TextBoxMultiline As Boolean = True
    Private m_TextBoxScrollBars As ScrollBars = ScrollBars.None
    Private m_TextBoxMaxLength As Integer = 32767
    Private m_TextBoxForeColor As Color
    Private m_TextBoxAlign As HorizontalAlignment = HorizontalAlignment.Left
    Private m_TextBoxBorderStyle As DevExpress.XtraEditors.Controls.BorderStyles = DevExpress.XtraEditors.Controls.BorderStyles.Simple
    Private m_TextBoxfont As Font = New Font("Tahoma", 9)
    Private m_TextBoxBackColor As Color
    Private m_CValue As String
    Private m_TextBoxAutoComplete As Boolean = False
#End Region
#Region "Event"
    Public Event btnTitleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event cmbIndexChange(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event btnTitleKeyDown As KeyEventHandler
    Public Event txt_ChangeIndex(ByVal sender As Object, ByVal e As System.EventArgs)
#End Region
    Public Sub New()

        ' 이 호출은 Windows Form 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        PeaceCombobox1.DropDownStyle = ComboBoxStyle.DropDownList

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

    Public Property ButtonTitle() As String
        Get
            Return m_ButtonTitle
        End Get
        Set(ByVal Value As String)
            m_ButtonTitle = Value
            lbl_name.Text = Value
        End Set
    End Property
    Public Property ButtonEnabled() As Boolean
        Get
            Return m_ButtonEnabled
        End Get
        Set(ByVal Value As Boolean)

            m_ButtonEnabled = Value
            lbl_name.Enabled = Value

            If Value = False Then
                lbl_name.ForeColor = cForeColor
            End If

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
    Public Property ButtonBackColor As Color
        Get
            Return m_ButtonBackColor
        End Get
        Set(value As Color)
            m_ButtonBackColor = value
            lbl_name.BackColor = value
        End Set
    End Property
    Public Property ButtonFont() As Font
        Get
            Return m_ButtonFont
        End Get
        Set(value As Font)
            m_ButtonFont = value
            lbl_name.Font = value
        End Set
    End Property

    Public Property ButtonForeColor() As Color
        Get
            Return m_ButtonColor
        End Get
        Set(value As Color)
            m_ButtonColor = value
            lbl_name.ForeColor = value
        End Set
    End Property




    Public Property Layoutpercent() As Decimal
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
                Me.lbl_name.Dispose()
                TableLayoutPanel1.ColumnCount = 1
                PeaceCombobox1.Margin = New Padding(0)
                lbl_name.Margin = New Padding(0)
            End If
        End Set
    End Property

   

    Public Property DataValue() As Integer
        Get
            Return m_DataValue
        End Get
        Set(value As Integer)
            m_DataValue = value
            PeaceCombobox1.DTValue = value
        End Set
    End Property

    Public Property DataLen() As Integer
        Get
            Return m_DataLen
        End Get
        Set(value As Integer)
            m_DataLen = value
            PeaceCombobox1.DTLen = value
        End Set
    End Property

    Public Property DataDecimal() As Integer
        Get
            Return m_DataDecimal
        End Get
        Set(value As Integer)
            m_DataDecimal = value
            PeaceCombobox1.DTDec = value
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
            PeaceCombobox1.Enabled = Value
            If m_TextBoxBackColorYN = True Then Exit Property
            If Value = False Then
                PeaceCombobox1.BackColor = cDisabledColor
            Else
                PeaceCombobox1.BackColor = cEnabledColor
            End If

        End Set
    End Property


    Public Property TextMaxLength() As Integer
        Get
            Return m_TextBoxMaxLength
        End Get
        Set(ByVal Value As Integer)
            PeaceCombobox1.MaxLength = Value
            m_TextBoxMaxLength = Value
        End Set
    End Property


    Public Property TextForeColor() As Color
        Get
            Return m_TextBoxForeColor
        End Get
        Set(ByVal Value As Color)

            m_TextBoxForeColor = Value
            PeaceCombobox1.ForeColor = Value

        End Set
    End Property

    Public Property TextBoxFont() As Font
        Get
            Return m_TextBoxfont
        End Get
        Set(ByVal Value As Font)

            m_TextBoxfont = Value
            PeaceCombobox1.Font = Value

        End Set
    End Property

    Public Property TextboxBackColor() As Color
        Get
            Return m_TextBoxBackColor
        End Get
        Set(ByVal value As Color)
            m_TextBoxBackColor = value
            PeaceCombobox1.BackColor = value
        End Set
    End Property
    Public Property CValue() As String
        Get
            Return m_CValue
        End Get
        Set(ByVal Value As String)
            m_CValue = Value
            PeaceCombobox1.Items.AddRange(Split(m_CValue, ";"))

        End Set
    End Property
    Public Property Code() As String
        Get
            Return m_Data.CODE
        End Get
        Set(ByVal Value As String)

            m_Data.CODE = Value
           
        End Set
    End Property
    Public Property Data() As String
        Get
            Return m_Data.NAME
        End Get
        Set(ByVal Value As String)

            m_Data.NAME = Value

        End Set
    End Property

    Public Property InSelected() As Integer
        Get
            Return m_InSelected
        End Get
        Set(value As Integer)
            m_InSelected = value
            PeaceCombobox1.InSelected = value
        End Set
    End Property

#End Region
#Region "Event Method Click - Focus ..."
    Private Sub PeaceCombobox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PeaceCombobox1.SelectedIndexChanged
        If PeaceCombobox1.SelectedIndex < 0 Then Exit Sub
        m_InSelected = PeaceCombobox1.SelectedIndex

        Me.Data = PeaceCombobox1.SelectedIndex + 1
        Me.Code = PeaceCombobox1.SelectedIndex + 1

        RaiseEvent cmbIndexChange(sender, e)

    End Sub
    Private Sub btnTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        RaiseEvent btnTitleClick(sender, e)

    End Sub



    Private Sub btnTitle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        RaiseEvent btnTitleKeyDown(sender, e)

    End Sub

  


#End Region

 
End Class
