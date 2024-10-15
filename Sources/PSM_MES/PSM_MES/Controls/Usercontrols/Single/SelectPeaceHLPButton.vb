Public Class SelectPeaceHLPButton

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

        Try
            If Me.Name = "txt_cdseason" Then
                Me.Data = "000"
                Me.Code = "000"
                Me.Visible = False
                Me.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub
#Region "Property"

    Public Property TextBoxAutoComplete() As Boolean
        Get
            Return m_TextBoxAutoComplete
        End Get
        Set(ByVal Value As Boolean)
            m_TextBoxAutoComplete = Value
            PeaceTextbox1.NoClear = Value
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
            PeaceButton1.Appearance.BackColor = value
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
            PeaceTextbox1.DTValue = value
        End Set
    End Property

    Public Property DataLen() As Integer
        Get
            Return m_DataLen
        End Get
        Set(value As Integer)
            m_DataLen = value
            PeaceTextbox1.DTLen = value
        End Set
    End Property

    Public Property DataDecimal() As Integer
        Get
            Return m_DataDecimal
        End Get
        Set(value As Integer)
            m_DataDecimal = value
            PeaceTextbox1.DTDec = value
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
            PeaceTextbox1.Multiline = Value

        End Set
    End Property

    Public Property TextScrollBars() As ScrollBars
        Get
            Return m_TextBoxScrollBars
        End Get
        Set(ByVal Value As ScrollBars)
            PeaceTextbox1.ScrollBars = Value
            m_TextBoxScrollBars = Value
        End Set
    End Property

    Public Property TextMaxLength() As Integer
        Get
            Return m_TextBoxMaxLength
        End Get
        Set(ByVal Value As Integer)
            PeaceTextbox1.MaxLength = Value
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
            PeaceTextbox1.TextAlign = Value

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
        Dim FormName As String
        If Me.ParentForm.Name.Contains("PFP") Then FormName = Strings.Left(Me.ParentForm.Name, 8) Else FormName = Me.ParentForm.Name

        hlp0000SeVa = ""
        hlp0000SeVaTt = ""

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

                        Exit Sub
                    End If
                End If

                If READ_PFK9916_1(FormName, Strings.Mid(Me.Name, 5)) Then
                    If D9916.CheckDev = "1" Then
                        Dim Value() As String
                        Value = D9916.REMK.Split(";")

                        Select Case Value(0)
                            Case "1" ' Customer
                                If HLP7101A.Link_HLP7101A(Me.Data) = False Then Exit Sub

                                If READ_PFK7101(hlp0000SeVaTt) Then
                                    PeaceTextbox1.Tag = D7101.CustomerCode
                                    PeaceTextbox1.Text = D7101.CustomerName
                                End If

                            Case "1A" ' Customer user	
                                If HLP7101A_Customer.Link_HLP7101A_Customer(Me.Data) = False Then Exit Sub

                                If READ_PFK7101(hlp0000SeVaTt) Then
                                    PeaceTextbox1.Tag = D7101.CustomerCode
                                    PeaceTextbox1.Text = D7101.CustomerName
                                End If

                            Case "1B" ' Customer
                                Dim xSel As String
                                xSel = Value(1)

                                If Value(1) <> "" Then
                                    If HLP7101A.Link_HLP7101B(xSel) = False Then Exit Sub

                                    If READ_PFK7101(hlp0000SeVaTt) Then
                                        PeaceTextbox1.Tag = D7101.CustomerCode
                                        PeaceTextbox1.Text = D7101.CustomerName
                                    End If
                                Else
                                    If HLP7101A.Link_HLP7101A(Me.Data) = False Then Exit Sub

                                    If READ_PFK7101(hlp0000SeVaTt) Then
                                        PeaceTextbox1.Tag = D7101.CustomerCode
                                        PeaceTextbox1.Text = D7101.CustomerName
                                    End If
                                End If

                            Case "1M" ' Customer
                                Dim xSel1 As String = "1"
                                Dim xSel2 As String = "1"
                                Dim xSel3 As String = "1"
                                Dim xSel4 As String = "1"
                                Dim xSel5 As String = "1"
                                Dim xSel6 As String = "1"

                                If Value(1) <> "" Then xSel1 = Value(1)
                                If Value(2) <> "" Then xSel2 = Value(2)
                                If Value(3) <> "" Then xSel3 = Value(3)
                                If Value(4) <> "" Then xSel4 = Value(4)
                                If Value(5) <> "" Then xSel5 = Value(5)
                                If Value(6) <> "" Then xSel6 = Value(6)

                                If HLP7101A.Link_HLP7101M(xSel1, xSel2, xSel3, xSel4, xSel5, xSel6) = False Then Exit Sub

                                If READ_PFK7101(hlp0000SeVaTt) Then
                                    PeaceTextbox1.Tag = D7101.CustomerCode
                                    PeaceTextbox1.Text = D7101.CustomerName
                                End If

                            Case "2"
                                Call HLP7104C.Link_HLP7104C(Me.FindForm.FindCode("CustomerCode").Code)

                                If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub

                                If READ_PFK7104(hlp0000SeVaTt) Then
                                    PeaceTextbox1.Tag = D7104.SizeRange
                                    PeaceTextbox1.Text = D7104.SizeRangeName
                                End If

                            Case "3" ' Type Code
                                If Value.Length > 1 Then HLPNA = Value(1)
                                If HLP7103A.Link_HLP7103A(HLPNA, "") = False Then Exit Sub

                                If READ_PFK7103_TYPECODE(D7103.cdTypeCode, D7103.TypeCode) Then
                                    PeaceTextbox1.Tag = D7103.TypeCode
                                    PeaceTextbox1.Text = D7103.TypeName
                                End If

                            Case "4" ' Tool Code
                                If Value.Length > 1 Then HLPNA = Value(1)
                                If HLP7156A.Link_HLP7156A(HLPNA, "") = False Then Exit Sub

                                If READ_PFK7156(D7156.ToolCode) Then
                                    PeaceTextbox1.Tag = D7156.ToolCode
                                    PeaceTextbox1.Text = D7156.ToolName
                                End If

                            Case "5" ' Outsource
                                If HLP7101A.Link_HLP7101B(4) = False Then Exit Sub

                                If READ_PFK7101(hlp0000SeVaTt) Then
                                    PeaceTextbox1.Tag = D7101.CustomerCode
                                    PeaceTextbox1.Text = D7101.CustomerName
                                End If

                            Case "6" 'HR CODE
                                If Value.Length > 1 Then HLPNA = Value(1) Else HLPNA = ""

                                If HLP7411A.Link_HLP7411A(HLPNA) = False Then Exit Sub

                                If READ_PFK7101(hlp0000SeVaTt) Then
                                    PeaceTextbox1.Tag = D7101.CustomerCode
                                    PeaceTextbox1.Text = D7101.CustomerName
                                End If


                            Case "7" ' Material code Code
                                If Me.Name.ToUpper.Contains("LASTCODE") Then chkLast = True
                                If Me.Name.ToUpper.Contains("MOLDCODE") Then chkMold = True
                                If Me.Name.ToUpper.Contains("CUTTINGDIE") Then chkCut = True

                                HLP7231C.ShowDialog()

                                If READ_PFK7231(hlp0000SeVaTt) Then
                                    PeaceTextbox1.Tag = D7231.MaterialCode
                                    PeaceTextbox1.Text = D7231.MaterialName & " " & D7231.MaterialPName
                                End If

                                chkLast = False
                                chkMold = False
                                chkCut = False
                                Exit Sub

                            Case "8" 'Basic Code
                                HLPNA = ListCode(Strings.Mid(Me.Name, 7)) ' Value(1)
                                Chk717_CheckProd = False
                                Chk717_CheckAcc = False

                                If Me.ParentForm.Name.Contains("0511") Or Me.ParentForm.Name.Contains("7741") Or Me.ParentForm.Name.Contains("0170") Then Chk717_CheckProd = True
                                If Me.ParentForm.Name.Contains("PFP85") Then Chk717_CheckAcc = True

                                If HLP7171ALL.Link_HLP7171A(HLPNA, "") = False Then Exit Sub

                                If READ_PFK7171(HLPNA, hlp0000SeVaTt) Then
                                    PeaceTextbox1.Tag = D7171.BasicCode
                                    PeaceTextbox1.Text = D7171.BasicName
                                End If

                                Exit Sub

                            Case "9" 'Machine Code
                                If Value.Length > 1 Then
                                    If HLP7155A.Link_HLP7155A(Value(1)) = False Then Exit Sub
                                Else
                                    If HLP7155A.Link_HLP7155A(Me.FindForm.FindCode("cdMachineType").Code) = False Then Exit Sub
                                End If

                                If READ_PFK7155(hlp0000SeVaTt) Then
                                    PeaceTextbox1.Tag = D7155.MachineCode
                                    PeaceTextbox1.Text = D7155.MachineName
                                End If

                                Exit Sub

                            Case "C" ' size range toool
                                Call HLP7105C.Link_HLP7105C("")

                                If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub

                                If READ_PFK7105(hlp0000SeVaTt) Then
                                    PeaceTextbox1.Tag = D7105.SizeRangeTool
                                    PeaceTextbox1.Text = D7105.SizeRangeToolName
                                End If


                            Case "x" 'Basic Code
                                DSxxx = Nothing
                                If HLPxxxxA.Link_HLPxxxxA(FormName, Value(1)) = False Then Exit Sub
                                If Value(2) = 0 Then
                                    Me.Enabled = False
                                    DATAROW_MOVE(Me.ParentForm, DSxxx)
                                End If

                            Case "ACC" ' Accounting
                                Dim xSel As String
                                Dim StoreName As String

                                xSel = Value(1)
                                StoreName = " USP_GET_ACC_HLPSLK_KEY "

                                If Value(1) <> "" Then

                                    Dim cmd As New SqlClient.SqlCommand

                                    SQL = "EXEC" + StoreName + "'" + xSel + "'" + ", N'" + Me.Data + "'"
                                    cmd = New SqlClient.SqlCommand(SQL, cn)

                                    DS1 = PrcDS(cmd, cn)

                                    If DS1.Tables(0).Rows.Count = 1 And Me.Data <> "" Then
                                        PeaceTextbox1.Tag = GetDsData(DS1, 0, "Code")
                                        PeaceTextbox1.Text = GetDsData(DS1, 0, "Name")
                                    Else
                                        Dim Sort As String = ""
                                        If Value.Count > 2 Then
                                            Sort = Value(2).Replace("'", "''")
                                        Else
                                            Sort = ""
                                        End If
                                        If HLPACC_DM.Link_HLPACC_DM(xSel, Me.Data, Sort) = False Then Exit Sub

                                        PeaceTextbox1.Tag = hlp0000SeVaTt
                                        PeaceTextbox1.Text = hlp0000SeVa
                                    End If
                                End If
                        End Select
                        PeaceTextbox1.Focus()

                        If hlp0000SeVaTt = "" Then Exit Sub
                        PeaceTextbox1.Text = hlp0000SeVa
                        PeaceTextbox1.Tag = hlp0000SeVaTt
                        Data = PeaceTextbox1.Text
                        Code = PeaceTextbox1.Tag

                        Exit Sub
                    End If
                End If
            End If


            RaiseEvent btnTitleClick(sender, e)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub HLPOpen()
        Dim FormName As String
        If Me.ParentForm.Name.Contains("PFP") Then FormName = Strings.Left(Me.ParentForm.Name, 8) Else FormName = Me.ParentForm.Name

        Try

            If Me.Name.Length > 5 Then
                If READ_PFK9916_1(FormName, Strings.Mid(Me.Name, 5)) Then
                    If D9916.CheckDev = "1" Then

                        Dim Value() As String
                        Value = D9916.REMK.Split(";")
                        Select Case Value(0)
                            Case "1" ' Customer
                                TranValue = PeaceTextbox1.Data

                                If IsNumeric(TranValue) Then
                                    If READ_PFK7101_CODE(TranValue) = True Then
                                        PeaceTextbox1.Tag = D7101.CustomerCode
                                        PeaceTextbox1.Text = D7101.CustomerName
                                        Data = PeaceTextbox1.Text
                                        Code = PeaceTextbox1.Tag

                                        GoTo KeyTab
                                    End If
                                Else
                                    If READ_PFK7101_NAME(TranValue) = True Then
                                        PeaceTextbox1.Tag = D7101.CustomerCode
                                        PeaceTextbox1.Text = D7101.CustomerName
                                        Data = PeaceTextbox1.Text
                                        Code = PeaceTextbox1.Tag

                                        GoTo KeyTab
                                    End If
                                End If

                                If HLP7101A.Link_HLP7101A(TranValue) = False Then Exit Sub

                                If READ_PFK7101(hlp0000SeVaTt) Then
                                    PeaceTextbox1.Tag = D7101.CustomerCode
                                    PeaceTextbox1.Text = D7101.CustomerName
                                    Data = PeaceTextbox1.Text
                                    Code = PeaceTextbox1.Tag

                                    GoTo KeyTab
                                End If
                            Case "1A" ' Customer		
                                TranValue = PeaceTextbox1.Data

                                If IsNumeric(TranValue) Then
                                    If READ_PFK7101_CODE_CUSTOMER(TranValue) = True Then
                                        PeaceTextbox1.Tag = D7101.CustomerCode
                                        PeaceTextbox1.Text = D7101.CustomerName
                                        Data = PeaceTextbox1.Text
                                        Code = PeaceTextbox1.Tag

                                        GoTo KeyTab
                                    End If
                                Else
                                    If READ_PFK7101_NAME_CUSTOMER(TranValue) = True Then
                                        PeaceTextbox1.Tag = D7101.CustomerCode
                                        PeaceTextbox1.Text = D7101.CustomerName
                                        Data = PeaceTextbox1.Text
                                        Code = PeaceTextbox1.Tag

                                        GoTo KeyTab
                                    End If
                                End If

                                If HLP7101A_Customer.Link_HLP7101A_Customer(TranValue) = False Then Exit Sub

                                If READ_PFK7101_CODE_CUSTOMER(hlp0000SeVaTt) Then
                                    PeaceTextbox1.Tag = D7101.CustomerCode
                                    PeaceTextbox1.Text = D7101.CustomerName
                                    Data = PeaceTextbox1.Text
                                    Code = PeaceTextbox1.Tag

                                    GoTo KeyTab
                                End If
                            Case "1B" ' Customer
                                TranValue = PeaceTextbox1.Data

                                If IsNumeric(TranValue) Then
                                    If READ_PFK7101_CODE(TranValue) = True Then
                                        PeaceTextbox1.Tag = D7101.CustomerCode
                                        PeaceTextbox1.Text = D7101.CustomerName
                                        Data = PeaceTextbox1.Text
                                        Code = PeaceTextbox1.Tag

                                        GoTo KeyTab
                                    End If
                                Else
                                    If READ_PFK7101_NAME(TranValue) = True Then
                                        PeaceTextbox1.Tag = D7101.CustomerCode
                                        PeaceTextbox1.Text = D7101.CustomerName
                                        Data = PeaceTextbox1.Text
                                        Code = PeaceTextbox1.Tag

                                        GoTo KeyTab
                                    End If
                                End If

                                If HLP7101A.Link_HLP7101A(TranValue) = False Then Exit Sub

                                If READ_PFK7101(hlp0000SeVaTt) Then
                                    PeaceTextbox1.Tag = D7101.CustomerCode
                                    PeaceTextbox1.Text = D7101.CustomerName
                                    Data = PeaceTextbox1.Text
                                    Code = PeaceTextbox1.Tag

                                    GoTo KeyTab
                                End If

                            Case "2" ' Buyer
                                Call HLP7104C.Link_HLP7104C(Me.FindForm.FindCode("CustomerCode").Code)

                                If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub

                                If READ_PFK7104(hlp0000SeVaTt) Then
                                    PeaceTextbox1.Tag = D7104.SizeRange
                                    PeaceTextbox1.Text = D7104.SizeRangeName
                                End If

                                GoTo KeyTab

                            Case "3" ' Type Code
                                If Value.Length > 1 Then HLPNA = Value(1)
                                'If HLP7103A.Link_HLP7103A(HLPNA, "") = False Then Exit Sub

                                'If READ_PFK7103_TYPECODE(D7103.cdTypeCode, D7103.TypeCode) Then
                                '    PeaceTextbox1.Tag = D7103.TypeCode
                                '    PeaceTextbox1.Text = D7103.TypeName
                                '    GoTo KeyTab
                                'End If

                                TranValue = PeaceTextbox1.Data

                                If IsNumeric(TranValue) Then
                                    If READ_PFK7103_TYPECODE(HLPNA, TranValue) = True Then

                                        PeaceTextbox1.Tag = D7103.TypeCode
                                        PeaceTextbox1.Text = D7103.TypeName
                                        Data = PeaceTextbox1.Text
                                        Code = PeaceTextbox1.Tag

                                        GoTo KeyTab

                                    End If
                                Else
                                    If READ_PFK7103_TYPENAME(HLPNA, TranValue) = True Then
                                        PeaceTextbox1.Tag = D7103.TypeCode
                                        PeaceTextbox1.Text = D7103.TypeName
                                        Data = PeaceTextbox1.Text
                                        Code = PeaceTextbox1.Tag

                                        GoTo KeyTab

                                    End If
                                End If

                                If HLP7103A.Link_HLP7103A(HLPNA, TranValue) = False Then
                                    PeaceTextbox1.Tag = D7103.TypeCode
                                    PeaceTextbox1.Text = D7103.TypeName

                                    Data = PeaceTextbox1.Text
                                    Code = PeaceTextbox1.Tag
                                    Exit Sub
                                End If

                                If READ_PFK7103_TYPECODE(HLPNA, hlp0000SeVaTt) Then
                                    PeaceTextbox1.Tag = D7103.TypeCode
                                    PeaceTextbox1.Text = D7103.TypeName

                                    Data = PeaceTextbox1.Text
                                    Code = PeaceTextbox1.Tag

                                    GoTo KeyTab

                                End If

                            Case "4" ' Tool Code
                                'If Value.Length > 1 Then HLPNA = Value(1)
                                'If HLP7156A.Link_HLP7156A(HLPNA, "") = False Then Exit Sub

                                'If READ_PFK7156(D7156.ToolCode) Then
                                '    PeaceTextbox1.Tag = D7156.ToolCode
                                '    PeaceTextbox1.Text = D7156.ToolName
                                '    GoTo KeyTab
                                'End If

                                If Value.Length > 1 Then HLPNA = Value(1)
                                TranValue = PeaceTextbox1.Data

                                If IsNumeric(TranValue) Then
                                    If READ_PFK7156_CODE(HLPNA, TranValue) = True Then

                                        PeaceTextbox1.Tag = D7156.ToolCode
                                        PeaceTextbox1.Text = D7156.ToolName
                                        Data = PeaceTextbox1.Text
                                        Code = PeaceTextbox1.Tag

                                        GoTo KeyTab

                                    End If
                                Else
                                    If READ_PFK7156_NAME(HLPNA, TranValue) = True Then
                                        PeaceTextbox1.Tag = D7156.ToolCode
                                        PeaceTextbox1.Text = D7156.ToolName
                                        Data = PeaceTextbox1.Text
                                        Code = PeaceTextbox1.Tag

                                        GoTo KeyTab

                                    End If
                                End If

                                If HLP7156A.Link_HLP7156A(HLPNA, TranValue) = False Then
                                    PeaceTextbox1.Tag = D7156.ToolCode
                                    PeaceTextbox1.Text = D7156.ToolName

                                    Data = PeaceTextbox1.Text
                                    Code = PeaceTextbox1.Tag
                                    Exit Sub
                                End If

                                If READ_PFK7156_CODE(HLPNA, hlp0000SeVaTt) Then
                                    PeaceTextbox1.Tag = D7156.ToolCode
                                    PeaceTextbox1.Text = D7156.ToolName

                                    Data = PeaceTextbox1.Text
                                    Code = PeaceTextbox1.Tag

                                    GoTo KeyTab

                                End If

                            Case "3" ' Style
                                'If HLP7106A.Link_HLP7106A("", "") = False Then Exit Function

                            Case "4" ' Pono
                                If HLP7102A.Link_HLP7102A("3") = False Then Exit Sub

                            Case "5" ' Odno
                                If HLP7102A.Link_HLP7102A("2") = False Then Exit Sub

                            Case "6" 'HR CODE
                                If Value.Length > 1 Then HLPNA = Value(1)

                                TranValue = PeaceTextbox1.Data


                                If READ_PFK7411_HRNO(TranValue) Then
                                    PeaceTextbox1.Tag = D7411.IDNO
                                    PeaceTextbox1.Text = D7411.Name
                                    Data = PeaceTextbox1.Text
                                    Code = PeaceTextbox1.Tag

                                    GoTo KeyTab
                                End If


                                If READ_PFK7411_IDNO(TranValue) Then
                                    PeaceTextbox1.Tag = D7411.IDNO
                                    PeaceTextbox1.Text = D7411.Name
                                    Data = PeaceTextbox1.Text
                                    Code = PeaceTextbox1.Tag

                                    GoTo KeyTab
                                End If

                                HLP0002.ShowDialog()

                                If READ_PFK7411(hlp0000SeVaTt) Then
                                    PeaceTextbox1.Tag = D7411.IDNO
                                    PeaceTextbox1.Text = D7411.Name
                                    Data = PeaceTextbox1.Text
                                    Code = PeaceTextbox1.Tag

                                    GoTo KeyTab
                                End If

                            Case "7" ' Material Code
                                TranValue = PeaceTextbox1.Data
                                If Me.Name.ToUpper.Contains("LASTCODE") Then chkLast = True
                                If Me.Name.ToUpper.Contains("MOLDCODE") Then chkMold = True
                                If Me.Name.ToUpper.Contains("CUTTINGDIE") Then chkCut = True

                                If IsNumeric(TranValue) Then
                                    If READ_PFK7231_CODE(TranValue) = True Then

                                        PeaceTextbox1.Tag = D7231.MaterialCode
                                        PeaceTextbox1.Text = D7231.MaterialName
                                        Data = PeaceTextbox1.Text
                                        Code = PeaceTextbox1.Tag

                                        GoTo KeyTab

                                    End If
                                Else
                                    If READ_PFK7231_NAME(TranValue) = True Then
                                        PeaceTextbox1.Tag = D7231.MaterialCode
                                        PeaceTextbox1.Text = D7231.MaterialName
                                        Data = PeaceTextbox1.Text
                                        Code = PeaceTextbox1.Tag

                                        GoTo KeyTab

                                    End If
                                End If

                                If HLP7231C.Link_HLP7231C(TranValue) = False Then
                                    PeaceTextbox1.Tag = D7231.MaterialCode
                                    PeaceTextbox1.Text = D7231.MaterialName & " " & D7231.MaterialPName
                                    Data = PeaceTextbox1.Text
                                    Code = PeaceTextbox1.Tag

                                    Exit Sub
                                End If

                                If READ_PFK7231(hlp0000SeVaTt) Then
                                    PeaceTextbox1.Tag = D7231.MaterialCode
                                    PeaceTextbox1.Text = D7231.MaterialName
                                    Data = PeaceTextbox1.Text
                                    Code = PeaceTextbox1.Tag

                                    GoTo KeyTab

                                End If

                            Case "8" 'Basic Code
                                Chk717_CheckProd = False
                                If Me.ParentForm.Name.Contains("0511") Or Me.ParentForm.Name.Contains("7741") Or Me.ParentForm.Name.Contains("0170") Then Chk717_CheckProd = True

                                HLPNA = ListCode(Strings.Mid(Me.Name, 7))
                                TranValue = PeaceTextbox1.Data

                                If IsNumeric(TranValue) Then
                                    If READ_PFK7171_CODE(HLPNA, TranValue) = True Then
                                        PeaceTextbox1.Tag = D7171.BasicCode
                                        PeaceTextbox1.Text = D7171.BasicName
                                        Data = PeaceTextbox1.Text
                                        Code = PeaceTextbox1.Tag

                                        GoTo KeyTab
                                    End If
                                Else
                                    If READ_PFK7171_NAME(HLPNA, TranValue) = True Then
                                        PeaceTextbox1.Tag = D7171.BasicCode
                                        PeaceTextbox1.Text = D7171.BasicName
                                        Data = PeaceTextbox1.Text
                                        Code = PeaceTextbox1.Tag

                                        GoTo KeyTab
                                    End If
                                End If

                                If HLP7171ALL.Link_HLP7171A(HLPNA, TranValue) = False Then Exit Sub

                                If READ_PFK7171(HLPNA, hlp0000SeVaTt) Then
                                    PeaceTextbox1.Tag = D7171.BasicCode
                                    PeaceTextbox1.Text = D7171.BasicName
                                    Data = PeaceTextbox1.Text
                                    Code = PeaceTextbox1.Tag
                                    GoTo KeyTab
                                End If

                            Case "9" 'Machine Code

                                If Value.Length > 1 Then
                                    If HLP7155A.Link_HLP7155A(Value(1)) = False Then Exit Sub
                                Else
                                    If HLP7155A.Link_HLP7155A(Me.FindForm.FindCode("cdMachineType").Code) = False Then Exit Sub
                                End If

                                If READ_PFK7155(hlp0000SeVaTt) Then
                                    PeaceTextbox1.Tag = D7155.MachineCode
                                    PeaceTextbox1.Text = D7155.MachineName
                                    Data = PeaceTextbox1.Text
                                    Code = PeaceTextbox1.Tag
                                    GoTo KeyTab
                                End If

                                Exit Sub

                            Case "ACC" ' Accounting
                                Dim xSel As String
                                Dim StoreName As String

                                xSel = Value(1)
                                StoreName = " USP_GET_ACC_HLPSLK_KEY "

                                If Value(1) <> "" Then

                                    Dim cmd As New SqlClient.SqlCommand

                                    SQL = "EXEC" + StoreName + "'" + xSel + "'" + ", N'" + Me.Data + "'"
                                    cmd = New SqlClient.SqlCommand(SQL, cn)

                                    DS1 = PrcDS(cmd, cn)

                                    If DS1.Tables(0).Rows.Count = 1 And Me.Data <> "" Then
                                        PeaceTextbox1.Tag = GetDsData(DS1, 0, "Code")
                                        PeaceTextbox1.Text = GetDsData(DS1, 0, "Name")
                                    Else
                                        Dim Sort As String = ""
                                        If Value.Count > 2 Then
                                            Sort = Value(2).Replace("'", "''")
                                        Else
                                            Sort = ""
                                        End If
                                        If HLPACC_DM.Link_HLPACC_DM(xSel, Me.Data, Sort) = False Then Exit Sub

                                        PeaceTextbox1.Tag = hlp0000SeVaTt
                                        PeaceTextbox1.Text = hlp0000SeVa
                                    End If
                                End If
                        End Select


                    End If
                End If
            End If

            Exit Sub

KeyTab:
            SendKeys.Send("{TAB}")
            chkLast = False
            chkMold = False
            chkCut = False
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

    Private Sub PeaceTextbox1_KeyDown(sender As Object, e As KeyEventArgs) Handles PeaceTextbox1.KeyDown
        Dim FormName As String
        If Me.ParentForm.Name.Contains("PFP") Then FormName = Strings.Left(Me.ParentForm.Name, 8) Else FormName = Me.ParentForm.Name

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F1 Then
            Call HLPOpen()
        End If

        If e.KeyCode = Keys.Down Then
            Exit Sub

            If READ_PFK9916_1(FormName, Strings.Mid(Me.Name, 5)) Then
                If D9916.CheckDev = "1" Then
                    Dim Value() As String
                    Value = D9916.REMK.Split(";")

                    Select Case Value(0)
                        Case "1" ' Customer
                            Dim cmd As New SqlClient.SqlCommand
                            Dim GridC As New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit

                            SQL = "SELECT K7101_CustomerCode, K7101_CustomerName FROM PFK7101"
                            cmd = New SqlClient.SqlCommand(SQL, cn)

                            DS1 = PrcDS(cmd, cn)

                            GridC.View.Columns.AddVisible("K7101_CustomerCode").Caption = "Customer Code"
                            GridC.View.Columns.AddVisible("K7101_CustomerName").Caption = "Customer Name"

                            GridC.DataSource = DS1.Tables(0)
                            GridC.DisplayMember = "K7101_CustomerName"
                            GridC.ValueMember = "K7101_CustomerCode"

                        Case "1B" ' Customer
                            Dim cmd As New SqlClient.SqlCommand
                            Dim GridC As New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit

                            SQL = "SELECT K7101_CustomerCode, K7101_CustomerName FROM PFK7101"
                            cmd = New SqlClient.SqlCommand(SQL, cn)

                            DS1 = PrcDS(cmd, cn)

                            GridC.View.Columns.AddVisible("K7101_CustomerCode").Caption = "Customer Code"
                            GridC.View.Columns.AddVisible("K7101_CustomerName").Caption = "Customer Name"

                            GridC.DataSource = DS1.Tables(0)
                            GridC.DisplayMember = "K7101_CustomerName"
                            GridC.ValueMember = "K7101_CustomerCode"

                        Case "2" ' Buyer
                            If HLP7102A.Link_HLP7102A("1") = False Then Exit Sub

                        Case "3" ' Type Code
                            If Value.Length > 1 Then HLPNA = Value(1)
                            If HLP7103A.Link_HLP7103A(HLPNA, "") = False Then Exit Sub

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
                            HLPNA = ListCode(ListCode(Strings.Mid(Me.Name, 7))) ' Value(1)
                            HLP7171ALL.ShowDialog()

                        Case "9"
                            If HLP7155A.Link_HLP7155A(Value(1)) = False Then Exit Sub

                        Case "A" 'HR Basic Code
                            If HLP4471A.Link_HLP4471A(Value(1)) = False Then Exit Sub
                        Case "ACC" ' Accounting
                            Dim xSel As String
                            Dim StoreName As String

                            xSel = Value(1)
                            StoreName = " USP_GET_ACC_HLPSLK_KEY "

                            If Value(1) <> "" Then

                                Dim cmd As New SqlClient.SqlCommand

                                SQL = "EXEC" + StoreName + "'" + xSel + "'" + ", N'" + Me.Data + "'"
                                cmd = New SqlClient.SqlCommand(SQL, cn)

                                DS1 = PrcDS(cmd, cn)

                                If DS1.Tables(0).Rows.Count = 1 And Me.Data <> "" Then
                                    PeaceTextbox1.Tag = GetDsData(DS1, 0, "Code")
                                    PeaceTextbox1.Text = GetDsData(DS1, 0, "Name")
                                Else
                                    Dim Sort As String = ""
                                    If Value.Count > 2 Then
                                        Sort = Value(2).Replace("'", "''")
                                    Else
                                        Sort = ""
                                    End If
                                    If HLPACC_DM.Link_HLPACC_DM(xSel, Me.Data, Sort) = False Then Exit Sub

                                    PeaceTextbox1.Tag = hlp0000SeVaTt
                                    PeaceTextbox1.Text = hlp0000SeVa
                                End If
                            End If
                    End Select

                End If
            End If
        End If

        'RaiseEvent txtTextKeyDown(sender, e)
    End Sub


    Private Sub txtText_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PeaceTextbox1.MouseDown

        m_Clicked = True

    End Sub

    Private Sub txtText_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PeaceTextbox1.MouseUp

        m_Clicked = False

    End Sub


    Private Sub btnTitle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PeaceButton1.KeyDown

        RaiseEvent btnTitleKeyDown(sender, e)

    End Sub

    Public Sub txtText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeaceTextbox1.TextChanged
        Data = PeaceTextbox1.Text
        Code = PeaceTextbox1.Tag

        ttpMain.SetToolTip(PeaceButton1, "Sel = " & ListCode(Me.Name.Substring(7)) & " : Code = " & Code)

        If Data = "" Then
            Code = ""
        End If

       
        RaiseEvent txtTextChange(sender, e)

        'ATER ON 2018/07/12
        'If Pub.CUSCHK = "1" Then
        '    If Me.ParentForm IsNot Nothing Then
        '        If List_Customer.Contains(Code) = False And Me.Name.Contains("CustomerCode") And Me.ParentForm.Name.Contains("ISUD") Then

        '            PeaceTextbox1.Text = ""
        '            PeaceTextbox1.Tag = ""

        '        End If
        '    End If

        'End If


    End Sub

    Public Sub txtText_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeaceTextbox1.GotFocus

        'PeaceTextbox1.BackColor = cGotFocusColor

        'If m_Clicked = False Then

        '    PeaceTextbox1.SelectAll()

        'Else

        '    m_Clicked = False

        'End If

    End Sub

    Public Sub txtText_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeaceTextbox1.LostFocus
        'If Trim(PeaceTextbox1.Text) = "" Then
        '    PeaceTextbox1.BackColor = cLostFocusColor
        'Else
        '    PeaceTextbox1.BackColor = cGotFocusColorText
        'End If
        'RaiseEvent txtTextLostFocus(sender, e)
    End Sub
    Private sentab As Boolean = False

    Private Sub PeaceTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PeaceTextbox1.KeyPress
        RaiseEvent txtTextKeyPress(sender, e)
    End Sub

#End Region

    
   
End Class
