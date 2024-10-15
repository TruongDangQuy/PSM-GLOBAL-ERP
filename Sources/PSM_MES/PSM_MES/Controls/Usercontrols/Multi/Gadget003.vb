Public Class Gadget003

#Region "Field"
    ''
    ''Visible
    Private m_vSSdateEdate As Boolean = True
    Private m_vSGCODE As Boolean = True
    Private m_vSCustomer As Boolean = True
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
    Private m_vSMoldName As Boolean = True
    Private m_vSLastName As Boolean = True
    Private m_vSIncharge As Boolean = True
    Private m_vSpCheckRequest As Boolean = True
    Private m_vSpCheckUse As Boolean = True
    ''
    ''Data
    Private m_sDate As String
    Private m_eDate As String

    Private m_chkGcodeCheck As String
    Private m_chkGcodeSQL As String
    Private m_chkGcodeData As String

    Private m_Season As String
    Private m_Customer As String
    Private m_SpecStatus As String
    Private m_SpecNoRef As String
    Private m_SpecState As String
    Private m_SpecKind As String
    Private m_SizeRange As String
    Private m_Article As String
    Private m_Line As String
    Private m_MaterialName As String
    Private m_ColorName As String
    Private m_MoldName As String
    Private m_LastName As String
    Private m_Incharge As String
    Private m_pCheckRequest As String
    Private m_pCheckUse0 As String
    Private m_pCheckUse1 As String


#End Region

    Public Sub New()

        InitializeComponent()

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

    Public Property gData_Customer() As String
        Get
            Return m_Customer

        End Get
        Set(ByVal Value As String)
            If txt_Customer.Visible = True Then
                m_Customer = Value
                txt_Customer.Data = Value
            Else
                m_Customer = ""
                txt_Customer.Data = ""
            End If
        End Set
    End Property

    Public Property gVisible_Customer() As Boolean
        Get
            Return m_vSCustomer
        End Get
        Set(ByVal Value As Boolean)

            m_vSCustomer = Value
            txt_Customer.Visible = Value

            If Value = False Then
                txt_Customer.Data = ""
                txt_Customer.Visible = False
            Else
                txt_Customer.Data = txt_Customer.PeaceTextbox1.Text
                txt_Customer.Visible = True
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
            txt_SpecNo.Data = Value

        End Set
    End Property

    Public Property gVisible_SpecNoRef() As Boolean
        Get
            Return m_vSSpecNoRef
        End Get
        Set(ByVal Value As Boolean)

            m_vSSpecNoRef = Value
            txt_SpecNo.Visible = Value

            If Value = False Then
                txt_SpecNo.Data = ""
                txt_SpecNo.Visible = False
            Else
                txt_SpecNo.Data = txt_SpecNo.PeaceTextbox1.Text
                txt_SpecNo.Visible = True
            End If

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
            txt_cdSizeRange.Visible = Value

            If Value = False Then
                txt_cdSizeRange.Data = ""
                txt_cdSizeRange.Visible = False
            Else
                txt_cdSizeRange.Data = txt_cdSizeRange.PeaceTextbox1.Text
                txt_cdSizeRange.Visible = True
            End If

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
            txt_cdIncharge.Data = Value

        End Set
    End Property

    Public Property gVisible_Incharge() As Boolean
        Get
            Return m_vSIncharge
        End Get
        Set(ByVal Value As Boolean)

            m_vSIncharge = Value
            txt_cdIncharge.Visible = Value

            If Value = False Then
                txt_cdIncharge.Data = ""
                txt_cdIncharge.Visible = False
            Else
                txt_cdIncharge.Data = txt_cdIncharge.PeaceTextbox1.Text
                txt_cdIncharge.Visible = True
            End If

        End Set
    End Property

    Public Property gData_CheckRequest() As String
        Get
            Return m_pCheckRequest
        End Get
        Set(ByVal Value As String)
            m_pCheckRequest = Value
            If opt_SEL0.Checked = True Then m_pCheckRequest = "1"
            If opt_SEL1.Checked = True Then m_pCheckRequest = "2"
            If opt_SEL2.Checked = True Then m_pCheckRequest = "3"
            If opt_SEL3.Checked = True Then m_pCheckRequest = "4"
            If opt_SEL4.Checked = True Then m_pCheckRequest = "5"
            If opt_SEL5.Checked = True Then m_pCheckRequest = "9"

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
                opt_SEL0.Checked = False
                opt_SEL1.Checked = False
                opt_SEL2.Checked = False
                opt_SEL3.Checked = False
                opt_SEL4.Checked = False
                opt_SEL5.Checked = False
                pCheckRequest.Visible = False
            Else
                If opt_SEL0.Checked = True Then m_pCheckRequest = "1"
                If opt_SEL1.Checked = True Then m_pCheckRequest = "2"
                If opt_SEL2.Checked = True Then m_pCheckRequest = "3"
                If opt_SEL3.Checked = True Then m_pCheckRequest = "4"
                If opt_SEL4.Checked = True Then m_pCheckRequest = "5"
                If opt_SEL5.Checked = True Then m_pCheckRequest = "9"
                pCheckRequest.Visible = True
            End If

        End Set
    End Property


    Public Property gData_chkGCodeCheck() As String
        Get
            Return txt_GCODE.chkAll.CheckState
        End Get
        Set(ByVal Value As String)

            m_chkGcodeCheck = Value
            If txt_GCODE.chkAll.Checked = True Then
                txt_GCODE.chkAll.CheckState = "1"
            Else
                txt_GCODE.chkAll.CheckState = "0"
            End If

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

#Region "Events"
    Private Sub opt_SEL0_CheckedChanged(sender As Object, e As EventArgs)
        Try
            If opt_SEL0.Checked = True Then m_pCheckRequest = "1"
            If opt_SEL1.Checked = True Then m_pCheckRequest = "2"
            If opt_SEL2.Checked = True Then m_pCheckRequest = "3"
            If opt_SEL3.Checked = True Then m_pCheckRequest = "4"
            If opt_SEL4.Checked = True Then m_pCheckRequest = "5"
            If opt_SEL5.Checked = True Then m_pCheckRequest = "9"
            pCheckRequest.Visible = True

        Catch ex As Exception

        End Try
    End Sub


#End Region



End Class
