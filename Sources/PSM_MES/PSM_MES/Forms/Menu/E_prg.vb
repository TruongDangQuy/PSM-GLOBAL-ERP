Public Class E_PRG

#Region "Variable"

    Private m_Title As String
    'Delegate Sub ChangeTextDelegate(ByVal value As Integer)
    'Dim _Changetext As New ChangeTextDelegate(AddressOf ChangeText)
#End Region

#Region "Property"

    Public Property Value() As Integer
        Get
            Return prgPRG.Value
        End Get
        Set(ByVal Value As Integer)
            prgPRG.Value = Value
            lbl_Value.Text = prgPRG.Value
            lbl_Percent.Text = FormatPercent(CIntp(Me.lbl_Value.Text) / CInt(Me.lbl_Max.Text), 2)
        End Set
    End Property

#End Region

#Region "Function"

    Public Sub New(ByVal MaxValue As Integer, Optional ByVal MinValue As Integer = 0, Optional ByVal Title As String = "DATA LOADING...")

        '이 호출은 Windows Form 디자이너에 필요합니다.
        InitializeComponent()

        'InitializeComponent()를 호출한 다음에 초기화 작업을 추가하십시오.

        prgPRG.Minimum = MinValue
        prgPRG.Maximum = MaxValue

        lbl_Max.Text = MaxValue
        prgPRG.Value = 0

        m_Title = Title
        lblMsg.Text = Title

    End Sub

#End Region

#Region "Event"

    Private Sub E_PRG_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Me.KeyPreview = True
        Call INTERRUPT_TOGGLE(e.KeyCode)
    End Sub

    Private Sub E_PRG_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        timMain.Interval = 1000
        timMain.Enabled = True
        lbl_1.Parent = prgPRG
        lbl_2.Parent = prgPRG
        lbl_3.Parent = prgPRG
        lbl_Percent.Parent = prgPRG
        lbl_Max.Parent = prgPRG
        lbl_Value.Parent = prgPRG
        lbl_5.Parent = prgPRG
        lblMsg.Parent = prgPRG
        '  Me.Opacity = CDblp(prgPRG.Value / prgPRG.Maximum)

    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timMain.Tick

        If sender.Equals(timMain) = True Then

            If lblMsg.Text = "" Then

                lblMsg.Text = m_Title

            Else

                lblMsg.Text = ""

            End If
            If prgPRG.Maximum <= Value Then

                timMain = Nothing

                Me.Close()

            End If

        End If

    End Sub

#End Region

End Class