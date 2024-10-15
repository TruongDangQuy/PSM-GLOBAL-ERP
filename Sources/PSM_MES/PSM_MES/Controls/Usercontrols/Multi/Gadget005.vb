Public Class Gadget005

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
            Return txt_cdSeason.Data

        End Get
        Set(ByVal Value As String)
            If txt_cdSeason.Visible = True Then
                m_Season = Value
                txt_cdSeason.Data = Value
            Else
                m_Season = ""
                txt_cdSeason.Data = ""
            End If
        End Set
    End Property

    Public Property gVisible_Season() As Boolean
        Get
            Return m_vSSeason
        End Get
        Set(ByVal Value As Boolean)

            m_vSSeason = Value
            txt_cdSeason.Visible = Value

            If Value = False Then
                txt_cdSeason.Data = ""
                txt_cdSeason.Visible = False
            Else
                txt_cdSeason.Data = txt_cdSeason.PeaceTextbox1.Text
                txt_cdSeason.Visible = True
            End If

        End Set
    End Property

    Public Property gData_SpecStatus() As String
        Get
            Return m_SpecStatus
        End Get
        Set(ByVal Value As String)
            m_SpecStatus = Value
            txt_cdFactory.Data = Value
        End Set
    End Property

    Public Property gCode_SpecStatus() As String
        Get
            Return txt_cdFactory.Code
        End Get
        Set(ByVal Value As String)
            m_SpecStatus = Value
            txt_cdFactory.Code = Value
        End Set
    End Property

    Public Property gVisible_SpecStatus() As Boolean
        Get
            Return m_vSSpecStatus
        End Get
        Set(ByVal Value As Boolean)

            m_vSSpecStatus = Value
            txt_cdFactory.Visible = Value

            If Value = False Then
                txt_cdFactory.Data = ""
                txt_cdFactory.Visible = False
            Else
                txt_cdFactory.Data = txt_cdFactory.PeaceTextbox1.Text
                txt_cdFactory.Visible = True
            End If

        End Set
    End Property

    Public Property gData_SpecNoRef() As String
        Get
            Return m_SpecNoRef
        End Get
        Set(ByVal Value As String)
            m_SpecNoRef = Value

        End Set
    End Property

    Public Property gVisible_SpecNoRef() As Boolean
        Get
            Return m_vSSpecNoRef
        End Get
        Set(ByVal Value As Boolean)

            m_vSSpecNoRef = Value
        End Set
    End Property

    Public Property gData_SpecState() As String
        Get
            Return m_SpecState
        End Get
        Set(ByVal Value As String)
            m_SpecState = Value
            txt_cdLineGroup.Data = Value

        End Set
    End Property

    Public Property gVisible_SpecState() As Boolean
        Get
            Return m_vSSpecState
        End Get
        Set(ByVal Value As Boolean)

            m_vSSpecState = Value
            txt_cdLineGroup.Visible = Value

            If Value = False Then
                txt_cdLineGroup.Data = ""
                txt_cdLineGroup.Visible = False
            Else
                txt_cdLineGroup.Data = txt_cdLineGroup.PeaceTextbox1.Text
                txt_cdLineGroup.Visible = True
            End If

        End Set
    End Property

    Public Property gData_SpecKind() As String
        Get
            Return m_SpecKind
        End Get
        Set(ByVal Value As String)
            m_SpecKind = Value
            txt_cdLineProd.Data = Value

        End Set
    End Property

    Public Property gVisible_SpecKind() As Boolean
        Get
            Return m_vSSpecKind
        End Get
        Set(ByVal Value As Boolean)

            m_vSSpecKind = Value
            txt_cdLineProd.Visible = Value

            If Value = False Then
                txt_cdLineProd.Data = ""
                txt_cdLineProd.Visible = False
            Else
                txt_cdLineProd.Data = txt_cdLineProd.PeaceTextbox1.Text
                txt_cdLineProd.Visible = True
            End If

        End Set
    End Property

    Public Property gData_SizeRange() As String
        Get
            Return m_SizeRange
        End Get
        Set(ByVal Value As String)
            m_SizeRange = Value

        End Set
    End Property

    Public Property gVisible_SizeRange() As Boolean
        Get
            Return m_vSSizeRange
        End Get
        Set(ByVal Value As Boolean)

            m_vSSizeRange = Value

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
            txt_SealNo.Data = Value

        End Set
    End Property

    Public Property gVisible_MaterialName() As Boolean
        Get
            Return m_vSMaterialName
        End Get
        Set(ByVal Value As Boolean)

            m_vSMaterialName = Value
            txt_SealNo.Visible = Value

            If Value = False Then
                txt_SealNo.Data = ""
                txt_SealNo.Visible = False
            Else
                txt_SealNo.Data = txt_SealNo.PeaceTextbox1.Text
                txt_SealNo.Visible = True
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

        End Set
    End Property

    Public Property gVisible_CheckRequest() As Boolean
        Get
            Return m_vSpCheckRequest
        End Get
        Set(ByVal Value As Boolean)

            m_vSpCheckRequest = Value

        End Set
    End Property

    Public Property gData_CheckUse0() As String
        Get
            Return chk_CheckUse1.CheckState
        End Get
        Set(ByVal Value As String)
            m_pCheckUse0 = Value
            chk_CheckUse1.CheckState = Value

        End Set
    End Property

    Public Property gData_CheckUse1() As String
        Get
            Return chk_CheckUse2.CheckState
        End Get
        Set(ByVal Value As String)
            m_pCheckUse1 = Value
            chk_CheckUse2.CheckState = Value

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
                If chk_CheckUse2.Checked = True Then
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

    Private Sub txt_SdateEdate_txtTextChange(sender As Object, e As EventArgs) Handles txt_SdateEdate.txtTextChange
        gData_SDate = txt_SdateEdate.text1
        gData_EDate = txt_SdateEdate.text2
    End Sub



#End Region



End Class
