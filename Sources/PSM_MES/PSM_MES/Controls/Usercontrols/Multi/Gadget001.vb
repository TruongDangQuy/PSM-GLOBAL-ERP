Public Class Gadget001

#Region "Field"

    Private m_vSSdateEdate As Boolean = True
    Private m_vSGCODE As Boolean = True
    Private m_vSSeason As Boolean = True
    Private m_vSSpecStatus As Boolean = True
    Private m_vSSpecNoRef As Boolean = True
    Private m_vSSpecState As Boolean = True
    Private m_vSSpecKind As Boolean = True
    Private m_vSSizeRange As Boolean = True
    Private m_vSArticle As Boolean = True
    Private m_vSLine As Boolean = True
    Private m_vSMaterialName As Boolean = True
    Private m_vSColorName As Boolean = True
    Private m_vSCustomerName As Boolean = True
    Private m_vSMoldName As Boolean = True
    Private m_vSLastName As Boolean = True
    Private m_vSIncharge As Boolean = True
    Private m_vSpCheckRequest As Boolean = True
    Private m_vSpCheckUse As Boolean = False



    Private m_sDate As String
    Private m_eDate As String
    Private m_Season As String
    Private m_SeasonCode As String
    Private m_SpecStatus As String
    Private m_SpecNoRef As String
    Private m_SpecState As String
    Private m_SpecKind As String
    Private m_SizeRange As String
    Private m_Article As String
    Private m_Line As String
    Private m_MaterialName As String
    Private m_ColorName As String
    Private m_CustomerName As String
    Private m_CustomerCode As String
    Private m_MoldName As String
    Private m_LastName As String
    Private m_Incharge As String
    Private m_pCheckRequest As String
    Private m_pCheckUse0 As String
    Private m_pCheckUse1 As String

    Private m_chkGcodeCheck As CheckState
    Private m_chkGcodeSQL As String
    Private m_chkGcodeData As String

#End Region

    Public Sub New()

        ' 이 호출은 Windows Form 디자이너에 필요합니다.
        InitializeComponent()

        Try

            If cn Is Nothing Then

                If READ_PFK7171(ListCode("Site"), Pub.SITE) Then
                    txt_cdSite.Code = D7171.BasicCode
                    txt_cdSite.Code = D7171.BasicName

                    gData_Season = D7171.BasicName
                    gData_SeasonCode = D7171.BasicCode
                End If


            End If
        Catch ex As Exception

        End Try
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
    End Sub

#Region "Data"
  
    Public Property gData_SDate() As String
        Get
            Return m_sDate
        End Get
        Set(ByVal Value As String)
            m_sDate = Value
            txt_SdateEdate.text1 = Value

        End Set
    End Property

    Public Property gData_EDate() As String
        Get
            Return m_eDate
        End Get
        Set(ByVal Value As String)
            m_eDate = Value
            txt_SdateEdate.text2 = Value

        End Set
    End Property

    Public Property gVisible_SDateEDate() As Boolean
        Get
            Return m_vSSdateEdate
        End Get
        Set(ByVal Value As Boolean)

            m_vSSdateEdate = Value
            txt_SdateEdate.Visible = Value

            If Value = False Then
                txt_SdateEdate.text1 = ""
                txt_SdateEdate.text2 = ""
                txt_SdateEdate.Visible = False
            Else
                txt_SdateEdate.text1 = txt_SdateEdate.sdate.Text
                txt_SdateEdate.text2 = txt_SdateEdate.edate.Text
                txt_SdateEdate.Visible = True
            End If

        End Set
    End Property

   

    Public Property gData_Season() As String
        Get
            Return txt_cdSite.Data

        End Get
        Set(ByVal Value As String)
            If txt_cdSite.Visible = True Then
                m_Season = Value
                txt_cdSite.Data = Value
            Else
                m_Season = ""
                txt_cdSite.Data = ""
            End If
        End Set
    End Property

    Public Property gData_SeasonCode() As String
        Get
            Return txt_cdSite.Code

        End Get
        Set(ByVal Value As String)
            m_SeasonCode = Value
            txt_cdSite.Code = Value

            'If txt_cdSeason.Visible = True Then
            '    m_SeasonCode = Value
            '    txt_cdSeason.Code = Value
            'Else
            '    m_SeasonCode = ""
            '    txt_cdSeason.Code = ""
            'End If
        End Set
    End Property
    Public Property gVisible_Season() As Boolean
        Get
            Return m_vSSeason
        End Get
        Set(ByVal Value As Boolean)

            m_vSSeason = Value
            txt_cdSite.Visible = Value

            If Value = False Then
                txt_cdSite.Data = ""
                txt_cdSite.Visible = False
            Else
                txt_cdSite.Data = txt_cdSite.PeaceTextbox1.Text
                txt_cdSite.Visible = True
            End If

        End Set
    End Property

    Public Property gData_SpecStatus() As String
        Get
            Return m_SpecStatus
        End Get
        Set(ByVal Value As String)
            m_SpecStatus = Value
            txt_cdSpecStatus.Data = Value

        End Set
    End Property

    Public Property gVisible_SpecStatus() As Boolean
        Get
            Return m_vSSpecStatus
        End Get
        Set(ByVal Value As Boolean)

            m_vSSpecStatus = Value
            txt_cdSpecStatus.Visible = Value

            If Value = False Then
                txt_cdSpecStatus.Data = ""
                txt_cdSpecStatus.Visible = False
            Else
                txt_cdSpecStatus.Data = txt_cdSpecStatus.PeaceTextbox1.Text
                txt_cdSpecStatus.Visible = True
            End If

        End Set
    End Property

    Public Property gData_SpecNoRef() As String
        Get
            Return m_SpecNoRef
        End Get
        Set(ByVal Value As String)
            m_SpecNoRef = Value
            txt_SpecNoRef.Data = Value

        End Set
    End Property

    Public Property gVisible_SpecNoRef() As Boolean
        Get
            Return m_vSSpecNoRef
        End Get
        Set(ByVal Value As Boolean)

            m_vSSpecNoRef = Value
            'txt_SpecNoRef.Visible = Value

            'If Value = False Then
            '    txt_SpecNoRef.Data = ""
            '    txt_SpecNoRef.Visible = False
            'Else
            '    txt_SpecNoRef.Data = txt_SpecNoRef.PeaceTextbox1.Text
            '    txt_SpecNoRef.Visible = True
            'End If

        End Set
    End Property

    Public Property gData_SpecState() As String
        Get
            Return m_SpecState
        End Get
        Set(ByVal Value As String)
            m_SpecState = Value
            txt_cdSpecState.Data = Value

        End Set
    End Property

    Public Property gVisible_SpecState() As Boolean
        Get
            Return m_vSSpecState
        End Get
        Set(ByVal Value As Boolean)

            m_vSSpecState = Value
            txt_cdSpecState.Visible = Value

            If Value = False Then
                txt_cdSpecState.Data = ""
                txt_cdSpecState.Visible = False
            Else
                txt_cdSpecState.Data = txt_cdSpecState.PeaceTextbox1.Text
                txt_cdSpecState.Visible = True
            End If

        End Set
    End Property

    Public Property gData_SpecKind() As String
        Get
            Return m_SpecKind
        End Get
        Set(ByVal Value As String)
            m_SpecKind = Value
            txt_cdSpecKind.Data = Value

        End Set
    End Property

    Public Property gVisible_SpecKind() As Boolean
        Get
            Return m_vSSpecKind
        End Get
        Set(ByVal Value As Boolean)

            m_vSSpecKind = Value
            'txt_cdSpecKind.Visible = Value

            'If Value = False Then
            '    txt_cdSpecKind.Data = ""
            '    txt_cdSpecKind.Visible = False
            'Else
            '    txt_cdSpecKind.Data = txt_cdSpecKind.PeaceTextbox1.Text
            '    txt_cdSpecKind.Visible = True
            'End If

        End Set
    End Property

    Public Property gData_SizeRange() As String
        Get
            Return m_SizeRange
        End Get
        Set(ByVal Value As String)
            m_SizeRange = Value
            txt_cdSizeRange.Data = Value

        End Set
    End Property

    Public Property gVisible_SizeRange() As Boolean
        Get
            Return m_vSSizeRange
        End Get
        Set(ByVal Value As Boolean)

            m_vSSizeRange = Value
            'txt_cdSizeRange.Visible = Value

            'If Value = False Then
            '    txt_cdSizeRange.Data = ""
            '    txt_cdSizeRange.Visible = False
            'Else
            '    txt_cdSizeRange.Data = txt_cdSizeRange.PeaceTextbox1.Text
            '    txt_cdSizeRange.Visible = True
            'End If

        End Set
    End Property

    Public Property gData_Article() As String
        Get
            Return m_Article
        End Get
        Set(ByVal Value As String)
            m_Article = Value
            txt_Article.Data = Value

        End Set
    End Property

    Public Property gVisible_Article() As Boolean
        Get
            Return m_vSArticle
        End Get
        Set(ByVal Value As Boolean)

            m_vSArticle = Value
            txt_Article.Visible = Value

            If Value = False Then
                txt_Article.Data = ""
                txt_Article.Visible = False
            Else
                txt_Article.Data = txt_Article.PeaceTextbox1.Text
                txt_Article.Visible = True
            End If

        End Set
    End Property

    Public Property gData_Line() As String
        Get
            Return m_Line
        End Get
        Set(ByVal Value As String)
            m_Line = Value
            txt_Line.Data = Value

        End Set
    End Property

    Public Property gVisible_Line() As Boolean
        Get
            Return m_vSLine
        End Get
        Set(ByVal Value As Boolean)

            m_vSLine = Value
            txt_Line.Visible = Value

            If Value = False Then
                txt_Line.Data = ""
                txt_Line.Visible = False
            Else
                txt_Line.Data = txt_Line.PeaceTextbox1.Text
                txt_Line.Visible = True
            End If

        End Set
    End Property

    Public Property gData_MaterialName() As String
        Get
            Return m_MaterialName
        End Get
        Set(ByVal Value As String)
            m_MaterialName = Value
            txt_MaterialName.Data = Value

        End Set
    End Property

    Public Property gVisible_MaterialName() As Boolean
        Get
            Return m_vSMaterialName
        End Get
        Set(ByVal Value As Boolean)

            m_vSMaterialName = Value
            txt_MaterialName.Visible = Value

            If Value = False Then
                txt_MaterialName.Data = ""
                txt_MaterialName.Visible = False
            Else
                txt_MaterialName.Data = txt_MaterialName.PeaceTextbox1.Text
                txt_MaterialName.Visible = True
            End If

        End Set
    End Property

    Public Property gData_ColorName() As String
        Get
            Return m_ColorName
        End Get
        Set(ByVal Value As String)
            m_ColorName = Value
            txt_ColorName.Data = Value

        End Set
    End Property

    Public Property gVisible_ColorName() As Boolean
        Get
            Return m_vSColorName
        End Get
        Set(ByVal Value As Boolean)

            m_vSColorName = Value
            txt_ColorName.Visible = Value

            If Value = False Then
                txt_ColorName.Data = ""
                txt_ColorName.Visible = False
            Else
                txt_ColorName.Data = txt_ColorName.PeaceTextbox1.Text
                txt_ColorName.Visible = True
            End If

        End Set
    End Property

    Public Property gData_CustomerCode() As String
        Get
            Return m_CustomerCode
        End Get
        Set(ByVal Value As String)
            m_CustomerCode = Value
            txt_CustomerName.Code = Value

        End Set
    End Property
    Public Property gData_CustomerName() As String
        Get
            Return m_CustomerName
        End Get
        Set(ByVal Value As String)
            m_CustomerName = Value
            txt_CustomerName.Data = Value

        End Set
    End Property
    Public Property gVisible_CustomerName() As Boolean
        Get
            Return m_vSCustomerName
        End Get
        Set(ByVal Value As Boolean)

            m_vSCustomerName = Value
            txt_CustomerName.Visible = Value

            If Value = False Then
                txt_CustomerName.Data = ""
                txt_CustomerName.Visible = False
            Else
                txt_CustomerName.Data = txt_CustomerName.PeaceTextbox1.Text
                txt_CustomerName.Visible = True
            End If

        End Set
    End Property

    Public Property gData_MoldName() As String
        Get
            Return m_MoldName
        End Get
        Set(ByVal Value As String)
            m_MoldName = Value
            txt_MoldName.Data = Value

        End Set
    End Property

    Public Property gVisible_MoldName() As Boolean
        Get
            Return m_vSMoldName
        End Get
        Set(ByVal Value As Boolean)

            m_vSMoldName = Value
            txt_MoldName.Visible = Value

            If Value = False Then
                txt_MoldName.Data = ""
                txt_MoldName.Visible = False
            Else
                txt_MoldName.Data = txt_MoldName.PeaceTextbox1.Text
                txt_MoldName.Visible = True
            End If

        End Set
    End Property

    Public Property gData_LastName() As String
        Get
            Return m_LastName
        End Get
        Set(ByVal Value As String)
            m_LastName = Value
            txt_LastName.Data = Value

        End Set
    End Property

    Public Property gVisible_LastName() As Boolean
        Get
            Return m_vSLastName
        End Get
        Set(ByVal Value As Boolean)

            m_vSLastName = Value
            txt_LastName.Visible = Value

            If Value = False Then
                txt_LastName.Data = ""
                txt_LastName.Visible = False
            Else
                txt_LastName.Data = txt_LastName.PeaceTextbox1.Text
                txt_LastName.Visible = True
            End If

        End Set
    End Property

    Public Property gData_Incharge() As String
        Get
            Return m_Incharge
        End Get
        Set(ByVal Value As String)
            m_Incharge = Value
            txt_Incharge.Data = Value

        End Set
    End Property

    Public Property gVisible_Incharge() As Boolean
        Get
            Return m_vSIncharge
        End Get
        Set(ByVal Value As Boolean)

            m_vSIncharge = Value
            txt_Incharge.Visible = Value

            If Value = False Then
                txt_Incharge.Data = ""
                txt_Incharge.Visible = False
            Else
                txt_Incharge.Data = txt_Incharge.PeaceTextbox1.Text
                txt_Incharge.Visible = True
            End If

        End Set
    End Property

    Public Property gData_CheckRequest() As String
        Get
            Return m_pCheckRequest
        End Get
        Set(ByVal Value As String)
            m_pCheckRequest = Value
            If opt_CheckRequest0.Checked = True Then m_pCheckRequest = "1"
            If opt_CheckRequest1.Checked = True Then m_pCheckRequest = "2"
            If opt_CheckRequest2.Checked = True Then m_pCheckRequest = "3"
            If opt_CheckRequest3.Checked = True Then m_pCheckRequest = "4"
            If opt_CheckRequest4.Checked = True Then m_pCheckRequest = "5"
            If opt_CheckRequest9.Checked = True Then m_pCheckRequest = "9"

        End Set
    End Property

    Public Property gVisible_CheckRequest() As Boolean
        Get
            Return m_vSpCheckRequest
        End Get
        Set(ByVal Value As Boolean)

            m_vSpCheckRequest = Value
            pCheckRequest.Visible = Value

            If Value = False Then
                opt_CheckRequest0.Checked = False
                opt_CheckRequest1.Checked = False
                opt_CheckRequest2.Checked = False
                opt_CheckRequest3.Checked = False
                opt_CheckRequest4.Checked = False
                opt_CheckRequest9.Checked = False
                pCheckRequest.Visible = False
            Else
                If opt_CheckRequest0.Checked = True Then m_pCheckRequest = "1"
                If opt_CheckRequest1.Checked = True Then m_pCheckRequest = "2"
                If opt_CheckRequest2.Checked = True Then m_pCheckRequest = "3"
                If opt_CheckRequest3.Checked = True Then m_pCheckRequest = "4"
                If opt_CheckRequest4.Checked = True Then m_pCheckRequest = "5"
                If opt_CheckRequest9.Checked = True Then m_pCheckRequest = "9"
                pCheckRequest.Visible = True
            End If

        End Set
    End Property

    Public Property gData_CheckUse0() As String
        Get
            Return chk_checkUse1.CheckState
        End Get
        Set(ByVal Value As String)
            m_pCheckUse0 = Value
            chk_checkUse1.CheckState = Value

        End Set
    End Property

    Public Property gData_CheckUse1() As String
        Get
            Return chk_checkUse2.CheckState
        End Get
        Set(ByVal Value As String)
            m_pCheckUse1 = Value
            chk_checkUse2.CheckState = Value

        End Set
    End Property

    Public Property gVisible_CheckUse() As Boolean
        Get
            Return m_vSpCheckUse
        End Get
        Set(ByVal Value As Boolean)

            m_vSpCheckUse = Value
            pCheckUse.Visible = Value

            If Value = False Then
                m_pCheckUse0 = "0"
                m_pCheckUse1 = "0"
                pCheckUse.Visible = False
            Else
                If chk_checkUse2.Checked = True Then
                    m_pCheckUse1 = "1"
                    m_pCheckUse0 = "0"
                Else
                    m_pCheckUse1 = "0"
                    m_pCheckUse0 = "1"
                End If
                pCheckUse.Visible = True
            End If

        End Set
    End Property


    Public Property gData_chkGCodeCheck() As CheckState
        Get
            Return txt_GCODE.chkAll.CheckState
        End Get
        Set(ByVal Value As CheckState)
            m_chkGcodeCheck = Value
            txt_GCODE.chkAll.CheckState = Value
        End Set
    End Property


    Public Property gData_chkGCodeSQL() As String
        Get
            Return txt_GCODE.SQL
        End Get
        Set(ByVal Value As String)
            m_chkGcodeSQL = Value
            txt_GCODE.SQL = Value

        End Set
    End Property

    Public Property gData_chkGCodeData() As String
        Get
            Return txt_GCODE.cboText.Text
        End Get
        Set(ByVal Value As String)
            m_chkGcodeData = Value
            txt_GCODE.cboText.Text = Value

        End Set
    End Property



#End Region

#Region "Property"
    Private Sub opt_SEL0_CheckedChanged(sender As Object, e As EventArgs) Handles opt_CheckRequest0.CheckedChanged, opt_CheckRequest1.CheckedChanged, opt_CheckRequest2.CheckedChanged, opt_CheckRequest3.CheckedChanged, opt_CheckRequest4.CheckedChanged, opt_CheckRequest9.CheckedChanged
        Try
            If opt_CheckRequest0.Checked = True Then m_pCheckRequest = "1"
            If opt_CheckRequest1.Checked = True Then m_pCheckRequest = "2"
            If opt_CheckRequest2.Checked = True Then m_pCheckRequest = "3"
            If opt_CheckRequest3.Checked = True Then m_pCheckRequest = "4"
            If opt_CheckRequest4.Checked = True Then m_pCheckRequest = "5"
            If opt_CheckRequest9.Checked = True Then m_pCheckRequest = "9"
            pCheckRequest.Visible = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_SdateEdate_txtTextChange(sender As Object, e As EventArgs) Handles txt_SdateEdate.txtTextChange
        gData_SDate = txt_SdateEdate.text1
        gData_EDate = txt_SdateEdate.text2
    End Sub
    Private Sub txt__txtTextChanged(sender As Object, e As EventArgs) Handles _
        txt_Article.txtTextChanged,
        txt_cdSite.txtTextChange,
        txt_SpecNoRef.txtTextChanged,
        txt_cdSizeRange.txtTextChange,
        txt_cdSpecState.txtTextChange,
        txt_cdSpecStatus.txtTextChange,
        txt_ColorName.txtTextChanged,
        txt_CustomerName.txtTextChange,
        txt_Incharge.txtTextChange,
        txt_LastName.txtTextChanged,
        txt_Line.txtTextChanged,
        txt_MaterialName.txtTextChanged,
        txt_MoldName.txtTextChanged

        Select Case True
            Case sender Is txt_Article.PeaceTextbox1
                gData_Article = txt_Article.Data

            Case sender Is txt_cdSite.PeaceTextbox1
                gData_Season = txt_cdSite.Data

            Case sender Is txt_SpecNoRef.PeaceTextbox1
                gData_SpecNoRef = txt_SpecNoRef.Data

            Case sender Is txt_cdSizeRange.PeaceTextbox1
                gData_SizeRange = txt_cdSizeRange.Data

            Case sender Is txt_cdSpecState.PeaceTextbox1
                gData_SpecState = txt_cdSpecState.Data

            Case sender Is txt_cdSpecStatus.PeaceTextbox1
                gData_SpecStatus = txt_cdSpecStatus.Data

            Case sender Is txt_ColorName.PeaceTextbox1
                gData_ColorName = txt_ColorName.Data

            Case sender Is txt_CustomerName.PeaceTextbox1
                gData_CustomerName = txt_CustomerName.Data

            Case sender Is txt_Incharge.PeaceTextbox1
                gData_Incharge = txt_Incharge.Data

            Case sender Is txt_LastName.PeaceTextbox1
                gData_LastName = txt_LastName.Data

            Case sender Is txt_Line.PeaceTextbox1
                gData_Line = txt_Line.Data

            Case sender Is txt_MaterialName.PeaceTextbox1
                gData_MaterialName = txt_MaterialName.Data

            Case sender Is txt_MoldName.PeaceTextbox1
                gData_MoldName = txt_MoldName.Data


        End Select


    End Sub


#End Region


  
End Class
