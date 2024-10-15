Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.ComponentModel
Public Class SelectPeaceSelect
#Region "Field"
#Region "전역 변수 선언 구역"

    Public CheckedCount As Integer = 0

#End Region
    Private m_Data As String = ""
    Private m_SendTab As Boolean = True

    Private m_Clicked As Boolean = False

    Private m_CellBorderStyle As TableLayoutPanelCellBorderStyle = TableLayoutPanelCellBorderStyle.Single

    Private m_LableBorderStyle As FlatStyle
    Private m_LableTitle As String
    Private m_LableEnabled As Boolean = True
    Private m_LableBackColor As Color
    Private m_LableFont As Font = New Font("Tahoma", 9, FontStyle.Bold)
    Private m_LableColor As Color = Color.White

    Private m_DataValue As Integer = 0
    Private m_DataLen As Integer = 0
    Private m_DataDecimal As Integer = 0

    Private m_percent As Decimal = 0.3366

    Private m_ButtonTitle As String
    Private m_ButtonEnabled As Boolean = True
    Private m_CheckBoxEnabled As Boolean = True
    Private m_CheckBoxMultiColumn As Boolean = True
    Private m_CheckBoxAllChecked As Boolean = True
    Private m_CheckBoxColumnWidth As Integer = 60

    Private m_TextBoxAutoComplete As Boolean = False
    Public Event clbTextKeyDown As KeyEventHandler
#End Region

#Region "Event"
    Public Event btnTitleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event btnTitleKeyDown As KeyEventHandler
    Public Event txtTextKeyDown As KeyEventHandler
    Public Event txtTextChanged As EventHandler
    Public Event txtTextKeyPress As KeyPressEventHandler
    Public Event txtTextLostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
#End Region

#Region "Tao mới"

    Public Sub New()

        ' 이 호출은 Windows Form 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        ttpMain.SetToolTip(btnTitle, "검색창을 표시합니다.")
        ttpMain.SetToolTip(clbText, "항목을 선택합니다.")

    End Sub

#End Region

#Region "Tab "

    <DefaultValue(True), Description("[Enter] 시 다음 컨트롤로 이동 여부를 선택합니다.")> _
    Public Property UseSendTab() As Boolean
        Get
            Return m_SendTab
        End Get
        Set(ByVal Value As Boolean)
            m_SendTab = Value
        End Set
    End Property

    <DefaultValue(1), Description("컨트롤의 [내부스타일]을 지정합니다.")> _
    Public Property PanelStyle() As TableLayoutPanelCellBorderStyle
        Get
            Return m_CellBorderStyle
        End Get
        Set(ByVal Value As TableLayoutPanelCellBorderStyle)
            m_CellBorderStyle = Value
            TableLayoutPanel1.CellBorderStyle = Value
        End Set
    End Property

    <DefaultValue("Title"), Description("검색버튼의 [문자열]을 지정합니다.")> _
    Public Property ButtonTitle() As String
        Get
            Return m_ButtonTitle
        End Get
        Set(ByVal Value As String)
            m_ButtonTitle = Value
            btnTitle.Text = Value
        End Set
    End Property

    <DefaultValue(True), Description("검색버튼의 [사용여부]를 지정합니다.")> _
    Public Property ButtonEnabled() As Boolean
        Get
            Return m_ButtonEnabled
        End Get
        Set(ByVal Value As Boolean)

            m_ButtonEnabled = Value
            btnTitle.Enabled = Value

            If Value = False Then
                btnTitle.ForeColor = cForeColor
            End If

        End Set
    End Property

    <DefaultValue(True), Description("체크박스의[사용여부]를 지정합니다.")> _
    Public Property TextEnabled() As Boolean
        Get
            Return m_CheckBoxEnabled
        End Get
        Set(ByVal Value As Boolean)

            m_CheckBoxEnabled = Value
            clbText.Enabled = Value

            If Value = False Then
                clbText.BackColor = cDisabledColor
            Else
                clbText.BackColor = cEnabledColor
            End If

        End Set
    End Property

    <DefaultValue(True), Description("체크박스의[다중컬럼]을 설정합니다.")> _
    Public Property MultiColumn() As Boolean
        Get
            Return m_CheckBoxMultiColumn
        End Get
        Set(ByVal Value As Boolean)

            m_CheckBoxMultiColumn = Value
            clbText.MultiColumn = Value

        End Set
    End Property

    <DefaultValue("Data"), Description("[리스트열]을 지정합니다.")> _
    Public Property Data() As String
        Get
            Return m_Data
        End Get
        Set(ByVal Value As String)

            Dim AA() As String

            AA = Split(Value, ";")

            m_Data = Value
            clbText.Items.Clear()
            clbText.Items.AddRange(AA)

            AllChecked = m_CheckBoxAllChecked
        End Set
    End Property

    <DefaultValue(60), Description("각 열의 [너비]를 지정합니다.")> _
    Public Property ColumnWidth() As Integer
        Get
            Return m_CheckBoxColumnWidth
        End Get
        Set(ByVal Value As Integer)
            m_CheckBoxColumnWidth = Value
            clbText.ColumnWidth = Value
        End Set
    End Property

    <DefaultValue(True), Description("체크박스 [체크여부]를 지정합니다.")> _
    Public Property AllChecked() As Boolean
        Get
            Return m_CheckBoxAllChecked
        End Get
        Set(ByVal Value As Boolean)

            Dim i As Integer

            m_CheckBoxAllChecked = Value

            For i = 0 To clbText.Items.Count - 1

                clbText.SetItemChecked(i, Value)

            Next

            CheckedCount = clbText.CheckedItems.Count

        End Set
    End Property

    Public Property Checked(ByVal index As Integer) As Object
        Get

            If clbText.GetItemChecked(index) = True Then
                Return "1"
            Else
                Return "0"
            End If

        End Get
        Set(ByVal Value As Object)

            If IsNothing(Value) = True Then

                clbText.SetItemCheckState(index, CheckState.Checked)

            Else

                If CInt(Value) = "0" Or CBool(Value) = False Then
                    clbText.SetItemCheckState(index, CheckState.Unchecked)
                Else
                    clbText.SetItemCheckState(index, CheckState.Checked)
                End If

            End If

        End Set
    End Property

#End Region

#Region "이벤트 핸들러 구역"

    Private Sub btnTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTitle.Click

        RaiseEvent btnTitleClick(sender, e)

    End Sub

    Private Sub btnTitle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnTitle.KeyDown

        RaiseEvent btnTitleKeyDown(sender, e)

    End Sub

    Private Sub clbText_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles clbText.KeyDown

        RaiseEvent clbTextKeyDown(sender, e)

        If m_SendTab = True Then

            SendTab(e.KeyCode)

        End If

    End Sub

    Private Sub clbSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbText.SelectedIndexChanged

        CheckedCount = clbText.CheckedItems.Count

    End Sub

    Private Sub CheckSelect_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize

        TableLayoutPanel1.Top = 0
        TableLayoutPanel1.Left = 0
        TableLayoutPanel1.Width = Me.Width
        TableLayoutPanel1.Height = Me.Height

    End Sub

#End Region

End Class
