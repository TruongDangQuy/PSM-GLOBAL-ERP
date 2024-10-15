Public Class E_MSG

#Region "열거형 원형 선언 구역"

	Public Enum _MSG_STYLE
		OKOnly = 0
		OKCancel = 1
		AbortRetryIgnore = 2
		YesNoCancel = 3
		YesNo = 4
		RetryCancel = 5
		CustomButton = 6
	End Enum

	Public Enum _MSG_RESULT
		OK = 1
		Cancel = 2
		Abort = 3
		Retry = 4
		Ignore = 5
		Yes = 6
		No = 7
		Button1 = 8
		Button2 = 9
		Button3 = 10
	End Enum

#End Region

#Region "지역 변수 구역"

	Private m_Buttons As _MSG_STYLE
	Private m_Ctr As Control
	Private m_Err As ErrorProvider

	Private m_Button1Text As String
	Private m_Button2Text As String
	Private m_Button3Text As String

	Private Pipe As New C_PIPE

#End Region

#Region "클래스 메소드 구역"

    Public Sub New(ByRef Value As C_Pipe, _
    ByVal Text As String, _
    Optional ByVal Buttons As _MSG_STYLE = _MSG_STYLE.OKOnly, _
    Optional ByVal Title As Object = Nothing, _
    Optional ByRef ctr As Control = Nothing, _
    Optional ByRef err As ErrorProvider = Nothing, _
    Optional ByVal Button1Text As String = "", _
    Optional ByVal Button2Text As String = "", _
    Optional ByVal Button3Text As String = "")
        MyBase.New()

        '이 호출은 Windows Form 디자이너에 필요합니다.
        InitializeComponent()

        'InitializeComponent()를 호출한 다음에 초기화 작업을 추가하십시오.

        Me.lblText.Text = Text

        If IsNothing(Title) = False Then

            Me.lblTitle.Text = Title

        End If

        Call kndl()

        m_Buttons = Buttons

        If Buttons = 292 Then
            m_Buttons = _MSG_STYLE.YesNo
        End If

        m_Ctr = ctr
        m_Err = err

        m_Button1Text = Button1Text
        m_Button2Text = Button2Text
        m_Button3Text = Button3Text

        Pipe = Value
        Pipe.Response = Me

    End Sub

#End Region

#Region "이벤트 핸들러 구역"

	Private Sub E_MSG_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

		Select Case m_Buttons

			Case _MSG_STYLE.OKOnly

				btnBR1.Visible = False
				btnBR2.Visible = False
				btnBR3.Visible = True

                btnBR3.Text = "OK"

				Me.AcceptButton = btnBR3
				Me.CancelButton = btnBR3

			Case _MSG_STYLE.OKCancel

				btnBR1.Visible = False
				btnBR2.Visible = True
				btnBR3.Visible = True

                btnBR2.Text = "OK"
                btnBR3.Text = "CANCEL"

				Me.AcceptButton = btnBR2
				Me.CancelButton = btnBR3

			Case _MSG_STYLE.AbortRetryIgnore

				btnBR1.Visible = True
				btnBR2.Visible = True
				btnBR3.Visible = True

				btnBR1.Text = "실행"
                btnBR2.Text = "RETRY"
                btnBR3.Text = "무시"

                Me.AcceptButton = btnBR1
                Me.CancelButton = btnBR3

            Case _MSG_STYLE.YesNoCancel

                btnBR1.Visible = True
                btnBR2.Visible = True
                btnBR3.Visible = True

                btnBR1.Text = "OK"
                btnBR2.Text = "NO"
                btnBR3.Text = "CANCEL"

                Me.AcceptButton = btnBR1
                Me.CancelButton = btnBR3

            Case _MSG_STYLE.YesNo

                btnBR1.Visible = False
                btnBR2.Visible = True
                btnBR3.Visible = True

                btnBR2.Text = "OK"
                btnBR3.Text = "NO"

                Me.AcceptButton = btnBR2
                Me.CancelButton = btnBR3

            Case _MSG_STYLE.RetryCancel

                btnBR1.Visible = False
                btnBR2.Visible = True
                btnBR3.Visible = True

                btnBR2.Text = "RETRY"
                btnBR3.Text = "CANCEL"

                Me.AcceptButton = btnBR2
                Me.CancelButton = btnBR3

			Case _MSG_STYLE.CustomButton


				If m_Button1Text = "" Then
					btnBR1.Visible = False
				Else
					btnBR1.Visible = True
					btnBR1.Text = m_Button1Text
				End If

				If m_Button2Text = "" Then
					btnBR2.Visible = False
				Else
					btnBR2.Visible = True
					btnBR2.Text = m_Button2Text
				End If

				If m_Button3Text = "" Then
					btnBR3.Visible = False
				Else
					btnBR3.Visible = True
					btnBR3.Text = m_Button3Text
				End If

		End Select

	End Sub

	Private Sub btnBR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBR1.Click, btnBR2.Click, btnBR3.Click

		If sender.Equals(btnBR1) = True Then

			Select Case m_Buttons

				Case _MSG_STYLE.AbortRetryIgnore

					Pipe.RetValue = _MSG_RESULT.Abort

				Case _MSG_STYLE.YesNoCancel

					Pipe.RetValue = _MSG_RESULT.Yes

				Case _MSG_STYLE.CustomButton

					Pipe.RetValue = _MSG_RESULT.Button1

			End Select

		End If

		If sender.Equals(btnBR2) = True Then

			Select Case m_Buttons

				Case _MSG_STYLE.OKCancel

					Pipe.RetValue = _MSG_RESULT.OK

				Case _MSG_STYLE.AbortRetryIgnore

					Pipe.RetValue = _MSG_RESULT.Retry

				Case _MSG_STYLE.YesNoCancel

					Pipe.RetValue = _MSG_RESULT.No

				Case _MSG_STYLE.YesNo

					Pipe.RetValue = _MSG_RESULT.Yes

				Case _MSG_STYLE.RetryCancel

					Pipe.RetValue = _MSG_RESULT.Retry

				Case _MSG_STYLE.CustomButton

					Pipe.RetValue = _MSG_RESULT.Button2

			End Select

		End If

		If sender.Equals(btnBR3) = True Then

			Select Case m_Buttons

				Case _MSG_STYLE.OKOnly

					Pipe.RetValue = _MSG_RESULT.OK

				Case _MSG_STYLE.OKCancel

					Pipe.RetValue = _MSG_RESULT.Cancel

				Case _MSG_STYLE.AbortRetryIgnore

					Pipe.RetValue = _MSG_RESULT.Ignore

				Case _MSG_STYLE.YesNoCancel

					Pipe.RetValue = _MSG_RESULT.Cancel

				Case _MSG_STYLE.YesNo

					Pipe.RetValue = _MSG_RESULT.No

				Case _MSG_STYLE.RetryCancel

					Pipe.RetValue = _MSG_RESULT.Cancel

				Case _MSG_STYLE.CustomButton

					Pipe.RetValue = _MSG_RESULT.Button3

			End Select

		End If

		Me.Close()

	End Sub

#End Region

End Class