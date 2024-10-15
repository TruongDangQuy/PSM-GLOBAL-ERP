Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.ComponentModel
Public Class SelectMulti


#Region "Standard"

    Friend Data() As DATASPACE

    Public SQL As String = ""

    Public SelectedCount As Integer = 0

    Public SqlPreName As String = ""
    Public SqlCodeName As String = ""

#End Region

#Region "Property Extra"

    Private m_CellBorderStyle As TableLayoutPanelCellBorderStyle = TableLayoutPanelCellBorderStyle.Single

    Private m_SendTab As Boolean = True

    Private m_ButtonTitle As String
    Private m_ButtonEnabled As Boolean = False
    Private m_percent As String = "40,10,30,20"

    Private m_CheckTitle As String
    Private m_CheckEnabled As Boolean = True
    Private m_Checked As Boolean = True

    Private m_SelectTitle As String
    Private m_SelectEnabled As Boolean = True

    Private m_ComboBoxEnabled As Boolean = True
    Private m_ComboBoxDropDownStyle As ComboBoxStyle = 1

    Private m_ComboBoxfont As Font = New Font("Tahoma", 9)

#End Region

#Region "Event"

    Public Event btnTitleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event btnTitleKeyDown As KeyEventHandler
    Public Event btnSelectClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event btnSelectKeyDown As KeyEventHandler
    Public Event cboTextSelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event cboTextKeyDown As KeyEventHandler

#End Region

#Region "New"

    Public Sub New()

        InitializeComponent()
        ttpMain.SetToolTip(chkAll, "Uncheck để search. Check để clear!")
        ttpMain.SetToolTip(btnSelect, "Bấm vào đây để lựa chọn !.")

    End Sub

#End Region

#Region "Property"

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
            '   tlpMain.CellBorderStyle = Value
        End Set
    End Property

    <DefaultValue("Title"), Description("제목버튼의 [문자열]을 지정합니다.")> _
    Public Property ButtonTitle() As String
        Get
            Return m_ButtonTitle
        End Get
        Set(ByVal Value As String)
            m_ButtonTitle = Value
            btnTitle.Text = Value
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
            TableLayoutPanel1.ColumnStyles(3).Width = CDbl(a(3))
        End Set
    End Property

    <DefaultValue(False), Description("제목버튼의 [사용여부]를 지정합니다.")> _
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

    <DefaultValue("Title"), Description("검색버튼의 [문자열]을 지정합니다.")> _
    Public Property SelectTitle() As String
        Get
            Return m_SelectTitle
        End Get
        Set(ByVal Value As String)
            m_SelectTitle = Value
            btnSelect.Text = Value
        End Set
    End Property

    <DefaultValue(True), Description("검색버튼의 [사용여부]를 지정합니다.")> _
    Public Property SelectEnabled() As Boolean
        Get
            Return m_SelectEnabled
        End Get
        Set(ByVal Value As Boolean)

            m_SelectEnabled = Value
            btnSelect.Enabled = Value

            If Value = False Then
                btnSelect.ForeColor = cForeColor
            End If

        End Set
    End Property

    <DefaultValue("Title"), Description("체크버튼의 [문자열]을 지정합니다.")> _
    Public Property CheckBoxTitle() As String
        Get
            Return m_CheckTitle
        End Get
        Set(ByVal Value As String)
            m_CheckTitle = Value
            chkAll.Text = Value
        End Set
    End Property

    <DefaultValue(False), Description("체크버튼의 [사용여부]를 지정합니다.")> _
    Public Property CheckBoxEnabled() As Boolean
        Get
            Return m_CheckEnabled
        End Get
        Set(ByVal Value As Boolean)

            m_CheckEnabled = Value
            chkAll.Enabled = Value

        End Set
    End Property

    <DefaultValue(True), Description("체크박스 [체크여부]를 지정합니다.")> _
    Public Property Checked() As Boolean
        Get
            Return m_Checked
        End Get
        Set(ByVal Value As Boolean)
            m_Checked = Value
            chkAll.Checked = Value
        End Set
    End Property

    <DefaultValue(True), Description("콤보박스의 [사용여부]를 지정합니다.")> _
    Public Property TextEnabled() As Boolean
        Get
            Return m_ComboBoxEnabled
        End Get
        Set(ByVal Value As Boolean)

            m_ComboBoxEnabled = Value
            cboText.Enabled = Value

            If Value = False Then
                cboText.BackColor = cDisabledColor
            Else
                cboText.BackColor = cEnabledColor
            End If

        End Set
    End Property

    <DefaultValue(1), Description("콤보박스의 [스타일]을 지정합니다.")> _
    Public Property DropDownStyle() As ComboBoxStyle
        Get
            Return m_ComboBoxDropDownStyle
        End Get
        Set(ByVal Value As ComboBoxStyle)
            m_ComboBoxDropDownStyle = Value
            cboText.DropDownStyle = Value
        End Set
    End Property

    Public Property ComboBoxFont() As Font
        Get
            Return m_ComboBoxfont
        End Get
        Set(ByVal Value As Font)

            m_ComboBoxfont = Value
            cboText.Font = Value

        End Set
    End Property
#End Region

#Region "EVent"

    Private Sub btnTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTitle.Click

        RaiseEvent btnTitleClick(sender, e)

    End Sub

    Private Sub btnTitle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnTitle.KeyDown

        RaiseEvent btnTitleKeyDown(sender, e)

    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click

        If Me.Name.Contains("GCODE") Then
            OBJ_GCODE(Me, "K7101_CustomerCode", "G1.", "0")

        ElseIf Me.Name.Contains("IGCODE") Then
            OBJ_GCODE(Me, "K7101_CustomerCode", "G2.", "0")

        ElseIf Me.Name.Contains("MCCODE") Then
            OBJ_GCODE(Me, "K7155_MachineCode", "Y1.", "3")

        ElseIf Me.Name.Contains("FCODE") Then
            OBJ_GCODE(Me, "K7111_FCODE", "F1.", "1")

        ElseIf Me.Name.Contains("MCODE") Then
            OBJ_GCODE(Me, "K7231_MaterialCode", "Y1.", "2")
        End If

        RaiseEvent btnSelectClick(sender, e)

    End Sub

    Private Sub btnselect_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnSelect.KeyDown

        RaiseEvent btnSelectKeyDown(sender, e)

    End Sub
    Private Sub cboText_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboText.KeyDown

        RaiseEvent cboTextKeyDown(sender, e)

        If m_SendTab = True Then

            SendTab(e.KeyCode)

        End If

    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged

        Checked = chkAll.Checked

        If Checked = True Then

            cboText.Text = ""
            cboText.Items.Clear()

            ReDim Data(0)

            SQL = ""
            SelectedCount = 0

            SqlCodeName = ""
            SqlPreName = ""

        End If

    End Sub

    Private Sub cboText_ValueMemberChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboText.ValueMemberChanged

        If cboText.Items.Count > 0 Then

            Checked = False

        End If

    End Sub

    Private Sub cboText_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboText.GotFocus

        cboText.BackColor = cGotFocusColor

    End Sub

    Private Sub cboText_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboText.LostFocus

        cboText.BackColor = cLostFocusColor

    End Sub

    Private Sub cboText_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboText.SelectedIndexChanged

        RaiseEvent cboTextSelectedIndexChanged(sender, e)

        If cboText.Items.Count > 0 Then

            Checked = False

        End If

        CallSQLMake()

    End Sub

    Private Sub MultiSelect_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize

        'tlpMain.Top = 0
        'tlpMain.Left = 0
        'tlpMain.Width = Me.Width
        'tlpMain.Height = Me.Height

    End Sub

#End Region

#Region "SQL hay chuỗi"

    Private Sub CallSQLMake()

        If SqlCodeName <> "" Then

            SQL_MAKE(Me, SqlCodeName, SqlPreName)

        End If

    End Sub

#End Region

  
End Class
