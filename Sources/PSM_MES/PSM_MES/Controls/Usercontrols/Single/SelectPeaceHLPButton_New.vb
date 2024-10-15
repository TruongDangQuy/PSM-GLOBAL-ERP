Public Class SelectPeaceHLPButton_New

#Region "Field"
    Private m_Data As New DATASPACE With {.NAME = "", .CODE = ""}
    Private m_SendTab As Boolean = True

    Private m_Clicked As Boolean = False

    Private m_CellBorderStyle As TableLayoutPanelCellBorderStyle = TableLayoutPanelCellBorderStyle.Single
    Private m_ButtonName As String
    Private m_ButtonTitle As String
    Private m_ButtonEnabled As Boolean = True
    Private m_ButtonBackColor As Color = Color.FromArgb(255, 255, 128)
    Private m_ButtonFont As Font = New Font("Tahoma", 9)
    Private m_ButtonColor As Color

    Private m_DataValue As Integer = 0
    Private m_DataLen As Integer = 0
    Private m_DataDecimal As Integer = 0

    Private m_percent As Decimal = 0.3366

    Private m_TextBoxEnabled As Boolean = True
    Private m_TextBoxMultiline As Boolean = True
    Private m_TextBoxScrollBars As ScrollBars = ScrollBars.None
    Private m_TextBoxMaxLength As Integer = 32767
    Private m_TextBoxForeColor As Color
    Private m_TextBoxAlign As HorizontalAlignment = HorizontalAlignment.Left
    Private m_TextBoxBorderStyle As DevExpress.XtraEditors.Controls.BorderStyles = DevExpress.XtraEditors.Controls.BorderStyles.Simple
    Private m_TextBoxfont As Font = New Font("Tahoma", 9)

    Private m_TextBoxBackColorYN As Boolean = False
    Private m_TextBoxBackColor As Color
    Private m_TextBoxAutoComplete As Boolean = False

    Private m_CheckValue As Boolean = False
    Private m_Value1 As String
    Private m_Value2 As String
    Private m_Value3 As String
#End Region
#Region "Event"
    Public Event btnTitleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event btnTitleKeyDown As KeyEventHandler
    Public Event txtTextChange As EventHandler
    Public Event txtTextKeyDown As KeyEventHandler
    Public Event txtTextKeyPress As KeyPressEventHandler
    Public Event txtTextLostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Public Event DelegateKeydown As MethodInvoker


#End Region
    'Private Sub [Select]()
    '    'MyBase.[Select](directed, forward)
    '    Setfocus(PeaceTextbox1)
    'End Sub

    Public Sub New()
        ' 이 호출은 Windows Form 디자이너에 필요합니다.
        '        kndl()
        InitializeComponent()
        m_Data.CODE = ""
        m_Data.NAME = ""
        PeaceTextbox1.Data = ""
        PeaceTextbox1.Code = ""
        Me.Data = ""
        Me.Code = ""
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
            TableLayoutPanel1.ColumnStyles(0).SizeType = SizeType.Percent
            TableLayoutPanel1.ColumnStyles(1).SizeType = SizeType.Percent
            TableLayoutPanel1.ColumnStyles(0).Width = value * TableLayoutPanel1.Width
            TableLayoutPanel1.ColumnStyles(1).Width = (1 - value) * TableLayoutPanel1.Width
        End Set
    End Property

    Public Property TextEnabled() As Boolean
        Get
            Return m_TextBoxEnabled
        End Get
        Set(ByVal Value As Boolean)

            m_TextBoxEnabled = Value
            PeaceTextbox1.Enabled = Value

            If Value = False Then
                PeaceTextbox1.BackColor = cDisabledColor
                PeaceTextbox1.TabStop = False
            Else
                PeaceTextbox1.BackColor = cEnabledColor
                PeaceTextbox1.TabStop = True
            End If

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

    Public Property TextScrollBars() As ScrollBars
        Get
            Return m_TextBoxScrollBars
        End Get
        Set(ByVal Value As ScrollBars)
            m_TextBoxScrollBars = Value
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

    Public Property TextStyle() As DevExpress.XtraEditors.Controls.BorderStyles
        Get
            Return m_TextBoxBorderStyle
        End Get
        Set(ByVal Value As DevExpress.XtraEditors.Controls.BorderStyles)

            m_TextBoxBorderStyle = Value
            PeaceTextbox1.BorderStyle = Value

        End Set
    End Property

    Public Property TextAlign() As HorizontalAlignment
        Get
            Return m_TextBoxAlign
        End Get
        Set(ByVal Value As HorizontalAlignment)

            m_TextBoxAlign = Value


        End Set
    End Property

    Public Property TextForeColor() As Color
        Get
            Return m_TextBoxForeColor
        End Get
        Set(ByVal Value As Color)

            m_TextBoxForeColor = Value
            PeaceTextbox1.ForeColor = Value

        End Set
    End Property
    Public Property TextBoxFont() As Font
        Get
            Return m_TextBoxfont
        End Get
        Set(ByVal Value As Font)

            m_TextBoxfont = Value
            PeaceTextbox1.Font = Value

        End Set
    End Property
    Public Property Code() As String
        Get
            If m_Data.CODE = "" Then Return "" Else Return m_Data.CODE
        End Get
        Set(ByVal Value As String)

            m_Data.CODE = Value
            PeaceTextbox1.Tag = Value

        End Set
    End Property
    Public Property Data() As String
        Get
            If m_Data.NAME = "" Then Return "" Else Return m_Data.NAME
        End Get
        Set(ByVal Value As String)

            m_Data.NAME = Value
            PeaceTextbox1.Text = Value

        End Set
    End Property

#End Region

#Region "Event Method Click - Focus ..."

    Public Overridable Sub btnTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeaceButton1.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""

        PeaceTextbox1.Properties.DataSource = Nothing
        PeaceTextbox1.BackColor = Color.Empty
        m_CheckValue = False

        Try
            If Me.Name.Length > 5 Then
                If Me.Name = "proname1" Then
                    If Me.m_ButtonName = "btn_programname" Or Me.m_ButtonName = "btn_sheetprint" Then
                        HLPCHECKBUTTON(m_ButtonName)
                        RaiseEvent btnTitleClick(sender, e)
                        If hlp0000SeVaTt = "" Or hlp0000SeVaTt = "" Then Exit Sub
                        PeaceTextbox1.Text = hlp0000SeVa
                        PeaceTextbox1.Tag = hlp0000SeVaTt
                        Data = PeaceTextbox1.Text
                        Code = PeaceTextbox1.Tag
                        txtText_LostFocus(sender, e)
                        RaiseEvent txtTextChange(sender, e)
                        Exit Sub
                    End If
                End If

                If READ_PFK9916_1(Me.ParentForm.Name, Strings.Mid(Me.Name, 5)) Then
                    If D9916.CheckDev = "1" Then
                        Dim Value() As String
                        Value = D9916.REMK.Split(";")

                        If Value.Length > 2 Then
                            m_Value1 = Value(0)
                            m_Value2 = Value(1)
                            m_Value3 = Value(2)
                        ElseIf Value.Length > 1 Then
                            m_Value1 = Value(0)
                            m_Value2 = Value(1)

                        ElseIf Value.Length = 1 Then
                            m_Value1 = Value(0)
                        End If

                        Select Case Value(0)
                            Case "1" ' Customer
                                HLP7101A.ShowDialog()

                            Case "2" ' Buyer
                                If HLP7102A.Link_HLP7102A("1") = False Then Exit Sub

                            Case "3" ' Style
                                If HLP7110A.Link_HLP7110A("", "") = False Then Exit Sub

                            Case "4" ' Pono
                                If HLP7102A.Link_HLP7102A("3") = False Then Exit Sub

                            Case "5" ' Odno
                                If HLP7102A.Link_HLP7102A("2") = False Then Exit Sub

                            Case "6" 'HR CODE
                                If Value.Length > 1 Then HLPNA = Value(1)
                                HLP0002.ShowDialog()

                            Case "7" ' Material code Code
                                HLP7231C.ShowDialog()

                            Case "8" 'Basic Code
                                HLPNA = ListCode(Strings.Mid(Me.Name, 7)) ' Value(1)
                                HLP7171ALL.ShowDialog()

                            Case "9" 'Machine Code
                                If HLP7155A.Link_HLP7155A(Value(1)) = False Then Exit Sub

                            Case "A" 'HR Basic Code
                                If HLP4471A.Link_HLP4471A(Value(1)) = False Then Exit Sub

                            Case "x" 'Basic Code
                                DSxxx = Nothing
                                If HLPxxxxA.Link_HLPxxxxA(Me.ParentForm.Name, Value(1)) = False Then Exit Sub
                                If Value(2) = 0 Then
                                    Me.Enabled = False
                                    DATAROW_MOVE(Me.ParentForm, DSxxx)
                                End If

                            Case "k"
                                RaiseEvent btnTitleClick(sender, e)
                                RaiseEvent txtTextKeyDown(sender, New KeyEventArgs(Keys.F1))

                                Exit Sub

                            Case Else
                                RaiseEvent btnTitleClick(sender, e)
                                RaiseEvent txtTextKeyDown(sender, New KeyEventArgs(Keys.F1))

                                Exit Sub
                        End Select
                        PeaceTextbox1.Focus()

                        If hlp0000SeVaTt = "" Then Exit Sub
                        PeaceTextbox1.Text = hlp0000SeVa
                        PeaceTextbox1.Tag = hlp0000SeVaTt
                        Data = PeaceTextbox1.Text
                        Code = PeaceTextbox1.Tag
                        txtText_LostFocus(sender, e)
                        RaiseEvent txtTextChange(sender, e)
                        PeaceTextbox1.Focus()
                        Exit Sub
                    End If

                    'ElseIf ListCode(Strings.Mid(Me.Name, 5)) Then
                    '    HLPNA = ListCode(Strings.Mid(Me.Name, 5))
                    '    Dim f As Form = New HLP7171ALL
                    '    f.ShowDialog()

                Else
                    m_ButtonName = ""
                    RaiseEvent btnTitleClick(sender, e)
                    RaiseEvent txtTextKeyDown(sender, New KeyEventArgs(Keys.F1))
                    Exit Sub
                End If
            End If
            If m_ButtonName = "" Then
                RaiseEvent btnTitleClick(sender, e)
                RaiseEvent txtTextKeyDown(sender, New KeyEventArgs(Keys.F1))
                Exit Sub
            End If


            HLPCHECKBUTTON(m_ButtonName)
            RaiseEvent btnTitleClick(sender, e)
            If hlp0000SeVaTt = "" Or hlp0000SeVaTt = "" Then Exit Sub
            PeaceTextbox1.Text = hlp0000SeVa
            PeaceTextbox1.Tag = hlp0000SeVaTt
            Data = PeaceTextbox1.Text
            Code = PeaceTextbox1.Tag
            txtText_LostFocus(sender, e)
            RaiseEvent txtTextChange(sender, e)

        Catch ex As Exception

        End Try

    End Sub
    Private Sub HLPOpen()
        Try
            If Me.Name.Length > 5 Then
                If READ_PFK9916_1(Me.ParentForm.Name, Strings.Mid(Me.Name, 5)) Then
                    If D9916.CheckDev = "1" Then

                        Dim Value() As String
                        Value = D9916.REMK.Split(";")

                        If Value.Length > 2 Then
                            m_Value1 = Value(0)
                            m_Value2 = Value(1)
                            m_Value3 = Value(2)
                        ElseIf Value.Length > 1 Then
                            m_Value1 = Value(0)
                            m_Value2 = Value(1)

                        ElseIf Value.Length = 1 Then
                            m_Value1 = Value(0)
                        End If

                        Select Case Value(0)
                            Case "1" ' Customer
                                TranValue = PeaceTextbox1.Data.Trim
                                If TranValue <> "" Then
                                    If READ_PFK7101_CODE(TranValue) = True Then
                                        PeaceTextbox1.Tag = D7101.CustomerCode
                                        PeaceTextbox1.Text = D7101.CustomerName
                                        Data = PeaceTextbox1.Text
                                        Code = PeaceTextbox1.Tag
                                        TranValue = ""
                                        sentab = True
                                        Exit Sub
                                    End If
                                End If

                                HLP7101A.ShowDialog()

                            Case "2" ' Buyer
                                If HLP7102A.Link_HLP7102A("1") = False Then Exit Sub

                            Case "3" ' Style
                                'If HLP7106A.Link_HLP7106A("", "") = False Then Exit Function

                            Case "4" ' Pono
                                If HLP7102A.Link_HLP7102A("3") = False Then Exit Sub

                            Case "5" ' Odno
                                If HLP7102A.Link_HLP7102A("2") = False Then Exit Sub

                            Case "6" 'HR CODE
                                HLPNA = Value(1)
                                HLP0002.ShowDialog()

                            Case "7" ' Yarn Code
                                HLP7231C.ShowDialog()

                            Case "8" 'Basic Code
                                'HLPNA = Value(1)
                                HLPNA = ListCode(Strings.Mid(Me.Name, 7))
                                TranValue = PeaceTextbox1.Data.Trim

                                If READ_PFK7171_HELPBUTTON(HLPNA, TranValue) = True Then
                                    PeaceTextbox1.Tag = D7171.BasicCode
                                    PeaceTextbox1.Text = D7171.BasicName
                                    Data = PeaceTextbox1.Text
                                    Code = PeaceTextbox1.Tag
                                    TranValue = ""
                                    sentab = True
                                    Exit Sub
                                End If
                                Dim f As Form = New HLP7171ALL
                                f.ShowDialog()

                            Case "9" 'Machine Code
                                If HLP7155A.Link_HLP7155A(Value(1)) = False Then Exit Sub

                            Case "A" 'HR Basic Code
                                If HLP4471A.Link_HLP4471A(Value(1)) = False Then Exit Sub

                            Case "x" 'Basic Code
                                DSxxx = Nothing
                                If HLPxxxxA.Link_HLPxxxxA(Me.ParentForm.Name, Value(1)) = False Then Exit Sub
                                If Value(2) = 0 Then
                                    DATAROW_MOVE(Me.ParentForm, DSxxx)
                                End If
                        End Select

                        If hlp0000SeVaTt = "" Then Exit Sub
                        PeaceTextbox1.Text = hlp0000SeVa
                        PeaceTextbox1.Tag = hlp0000SeVaTt
                        Data = PeaceTextbox1.Text
                        Code = PeaceTextbox1.Tag
                        Exit Sub
                    End If
                End If
            End If

            HLPCHECKBUTTON(m_ButtonName)
            If hlp0000SeVaTt = "" Or hlp0000SeVaTt = "" Then Exit Sub
            PeaceTextbox1.Text = hlp0000SeVa
            PeaceTextbox1.Tag = hlp0000SeVaTt
            Data = PeaceTextbox1.Text
            Code = PeaceTextbox1.Tag

        Catch ex As Exception

        End Try
    End Sub

    Public Property BackYesno() As Boolean
        Get
            Return m_TextBoxBackColorYN
        End Get
        Set(ByVal Value As Boolean)
            m_TextBoxBackColorYN = Value
        End Set
    End Property
    Public Property TextboxBackColor() As Color
        Get
            Return m_TextBoxBackColor
        End Get
        Set(ByVal value As Color)
            m_TextBoxBackColor = value
            PeaceTextbox1.BackColor = value
        End Set
    End Property

    Private Sub PeaceTextbox1_EditValueChanged(sender As Object, e As EventArgs) Handles PeaceTextbox1.EditValueChanged
        Data = PeaceTextbox1.Text
        Code = PeaceTextbox1.EditValue

        Try
            If m_Value1 <> "" Then
                Select Case m_Value1
                    Case "1"
                        If READ_PFK7101(Code) Then
                            Me.Code = D7101.CustomerCode
                            Me.Data = D7101.CustomerName
                        End If

                    Case "7" ' Material code Code
                        If READ_PFK7231(Code) Then
                            Me.Code = D7231.MaterialCode
                            Me.Data = D7231.MaterialName
                        End If

                    Case "8" 'Basic Code
                        If READ_PFK7171(ListCode(ListCode(Strings.Mid(Me.Name, 7))), Code) Then
                            Me.Code = D7171.BasicCode
                            Me.Data = D7171.BasicName
                        End If

                End Select

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PeaceTextbox1_KeyDown(sender As Object, e As KeyEventArgs) Handles PeaceTextbox1.KeyDown

        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F1) Then
            If m_CheckValue = True Then Exit Sub

            If m_ButtonName = "btn_Pono" Or m_ButtonName = "btn_Odno" Or m_ButtonName = "btn_Style" Or m_ButtonName = "btn_Buyer" Then
                TranValue = ""
                hlp0000SeVa = ""
                hlp0000SeVaTt = ""
                Call HLPOpen()
            End If
            If PeaceTextbox1.Text = "" And PeaceTextbox1.Tag = "" Then
                TranValue = ""
                hlp0000SeVa = ""
                hlp0000SeVaTt = ""
                Call HLPOpen()

            ElseIf IsNumeric(PeaceTextbox1.Tag) And PeaceTextbox1.Text.Trim <> "" Then

            ElseIf IsNumeric(PeaceTextbox1.Text) Then
                hlp0000SeVa = ""
                TranValue = ""
                hlp0000SeVa = ""
                hlp0000SeVaTt = ""
                Call HLPOpen()
            ElseIf IsNumeric(PeaceTextbox1.Text) = False Then
                TranValue = ""
                hlp0000SeVa = ""
                hlp0000SeVaTt = ""
                Call HLPOpen()
            End If

        ElseIf e.KeyCode = Keys.Down Then
            If m_CheckValue = True Then Exit Sub

            If READ_PFK9916_1(Me.ParentForm.Name, Strings.Mid(Me.Name, 5)) Then
                If D9916.CheckDev = "1" Then
                    Dim Value() As String
                    Value = D9916.REMK.Split(";")

                    If Value.Length > 2 Then
                        m_Value1 = Value(0)
                        m_Value2 = Value(1)
                        m_Value3 = Value(2)
                    ElseIf Value.Length > 1 Then
                        m_Value1 = Value(0)
                        m_Value2 = Value(1)

                    ElseIf Value.Length = 1 Then
                        m_Value1 = Value(0)
                    End If

                    PeaceTextbox1.BackColor = Color.LightGreen

                    Select Case Value(0)
                        Case "1" ' Customer
                            Dim cmd As New SqlClient.SqlCommand

                            SQL = "SELECT K7101_CustomerCode as Code, K7101_CustomerName  as Name FROM PFK7101"
                            cmd = New SqlClient.SqlCommand(SQL, cn)

                            DS1 = PrcDS(cmd, cn)

                            PeaceTextbox1.Properties.DataSource = DS1.Tables(0)
                            PeaceTextbox1.Properties.DisplayMember = "Name"
                            PeaceTextbox1.Properties.ValueMember = "Code"

                            m_CheckValue = True


                        Case "2" ' Buyer
                            If HLP7102A.Link_HLP7102A("1") = False Then Exit Sub

                        Case "3" ' Type Code
                            If Value.Length > 1 Then HLPNA = Value(1)

                            Dim cmd As New SqlClient.SqlCommand

                            SQL = "SELECT K7103_TypeCode as Code, K7103_TypeName as Name FROM PFK7103"
                            SQL = SQL & "WHERE K7103_cdTypeCode = '" + Value(1) + "'"

                            cmd = New SqlClient.SqlCommand(SQL, cn)

                            DS1 = PrcDS(cmd, cn)

                            PeaceTextbox1.Properties.DataSource = DS1.Tables(0)
                            PeaceTextbox1.Properties.DisplayMember = "Name"
                            PeaceTextbox1.Properties.ValueMember = "Code"


                            m_CheckValue = True


                        Case "4" ' Pono
                            If HLP7102A.Link_HLP7102A("3") = False Then Exit Sub

                        Case "5" ' Odno
                            If HLP7102A.Link_HLP7102A("2") = False Then Exit Sub

                        Case "6" 'HR CODE
                            If Value.Length > 1 Then HLPNA = Value(1)

                            Dim cmd As New SqlClient.SqlCommand

                            SQL = "SELECT K7411_IDNO as Code, K7411_Name  as Name FROM PFK7411"
                            SQL = SQL & "WHERE K7411_cdInCharge = '" + Value(1) + "'"

                            cmd = New SqlClient.SqlCommand(SQL, cn)

                            DS1 = PrcDS(cmd, cn)

                            PeaceTextbox1.Properties.DataSource = DS1.Tables(0)
                            PeaceTextbox1.Properties.DisplayMember = "Name"
                            PeaceTextbox1.Properties.ValueMember = "Code"


                            m_CheckValue = True


                        Case "7" ' Material code Code
                            Dim cmd As New SqlClient.SqlCommand

                            SQL = "SELECT K7231_MaterialCode as Code, K7231_MaterialName as Name FROM PFK7231"

                            cmd = New SqlClient.SqlCommand(SQL, cn)

                            DS1 = PrcDS(cmd, cn)

                            PeaceTextbox1.Properties.DataSource = DS1.Tables(0)
                            PeaceTextbox1.Properties.DisplayMember = "Name"
                            PeaceTextbox1.Properties.ValueMember = "Code"



                            m_CheckValue = True

                        Case "8" 'Basic Code
                            HLPNA = ListCode(ListCode(Strings.Mid(Me.Name, 7))) ' Value(1)
                            SQL = "SELECT K7171_BasicCode as Code, K7171_BasicName as Name FROM PFK7171"
                            SQL = SQL & "WHERE K7171_BasicSel = '" + Value(1) + "'"

                            cmd = New SqlClient.SqlCommand(SQL, cn)

                            DS1 = PrcDS(cmd, cn)

                            PeaceTextbox1.Properties.DataSource = DS1.Tables(0)
                            PeaceTextbox1.Properties.DisplayMember = "Name"
                            PeaceTextbox1.Properties.ValueMember = "Code"
                            m_CheckValue = True

                        Case "9"
                            If HLP7155A.Link_HLP7155A(Value(1)) = False Then Exit Sub

                        Case "A" 'HR Basic Code
                            If HLP4471A.Link_HLP4471A(Value(1)) = False Then Exit Sub

                    End Select

                End If
            End If
        End If

        RaiseEvent txtTextKeyDown(sender, e)
    End Sub


    Private Sub txtText_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        m_Clicked = True

    End Sub

    Private Sub txtText_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

        m_Clicked = False

    End Sub


    Private Sub btnTitle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PeaceButton1.KeyDown

        RaiseEvent btnTitleKeyDown(sender, e)

    End Sub

    Private Sub PeaceTextbox1_LostFocus(sender As Object, e As EventArgs) Handles PeaceTextbox1.LostFocus
        Call txtText_LostFocus(sender, e)
      
    End Sub


    Public Sub txtText_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)

        PeaceTextbox1.BackColor = cGotFocusColor

        If m_Clicked = False Then

            PeaceTextbox1.SelectAll()

        Else

            m_Clicked = False

        End If

    End Sub

    Public Sub txtText_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Trim(PeaceTextbox1.Text) = "" Then
            PeaceTextbox1.BackColor = cLostFocusColor
        Else
            PeaceTextbox1.BackColor = cGotFocusColorText
        End If
        RaiseEvent txtTextLostFocus(sender, e)
    End Sub
    Private sentab As Boolean = False

    Private Sub PeaceTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        RaiseEvent txtTextKeyPress(sender, e)
    End Sub

#End Region

   
  
End Class
