Public Class Gadget002

#Region "Field"

    Private m_vSSdateEdate As Boolean = True
    Private m_vSGCODE As Boolean = True
    Private m_vSSpecStatus As Boolean = True
    Private m_vSArticle As Boolean = True
    Private m_vSLine As Boolean = True
    Private m_vSMaterialName As Boolean = True
    Private m_vSColorName As Boolean = True
    Private m_vSMoldName As Boolean = True
    Private m_vSLastName As Boolean = True
    Private m_vSSizeRange As Boolean = True
    Private m_vSSpeciticSize As Boolean = True
    Private m_vSSpecNo As Boolean = True

    Private m_vSUnitMaterial As Boolean = True
    Private m_vSUnitPacking As Boolean = True
    Private m_vSIncharge As Boolean = True

    Private m_vSpCheckRequest As Boolean = True




    Private m_sDate As String
    Private m_eDate As String

    Private m_SpecStatus As String
    Private m_Article As String
    Private m_Line As String

    Private m_MaterialName As String
    Private m_ColorName As String
    Private m_MoldName As String
    Private m_LastName As String

    Private m_SizeRange As String
    Private m_SpeciticSize As String
    Private m_SpecNo As String

    Private m_UnitMaterial As String
    Private m_UnitPacking As String
    Private m_Incharge As String
    Private m_pCheckRequest As String



#End Region

    Public Sub New()

        ' 이 호출은 Windows Form 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

    End Sub

#Region "Data"

    Public Property sDate() As String
        Get
            Return m_sDate
        End Get
        Set(ByVal Value As String)
            m_sDate = Value
            txt_Period.text1 = Value

        End Set
    End Property

    Public Property VisibledSDateEDate() As Boolean
        Get
            Return m_vSSdateEdate
        End Get
        Set(ByVal Value As Boolean)

            m_vSSdateEdate = Value
            txt_Period.Visible = Value

            If Value = False Then
                txt_Period.text1 = ""
                txt_Period.text2 = ""
                txt_Period.Visible = False
            Else
                txt_Period.text1 = txt_Period.sdate.Text
                txt_Period.text2 = txt_Period.edate.Text
                txt_Period.Visible = True
            End If

        End Set
    End Property

    Public Property eDate() As String
        Get
            Return m_eDate
        End Get
        Set(ByVal Value As String)
            m_eDate = Value
            txt_Period.text2 = Value

        End Set
    End Property

    Public Property gSpecStatus() As String
        Get
            Return m_SpecStatus
        End Get
        Set(ByVal Value As String)
            m_SpecStatus = Value
            txt_SpecStatus.Data = Value

        End Set
    End Property

    Public Property VisibledSpecStatus() As Boolean
        Get
            Return m_vSSpecStatus
        End Get
        Set(ByVal Value As Boolean)

            m_vSSpecStatus = Value
            txt_SpecStatus.Visible = Value

            If Value = False Then
                txt_SpecStatus.Data = ""
                txt_SpecStatus.Visible = False
            Else
                txt_SpecStatus.Data = txt_SpecStatus.PeaceTextbox1.Text
                txt_SpecStatus.Visible = True
            End If

        End Set
    End Property

    Public Property gArticle() As String
        Get
            Return m_Article
        End Get
        Set(ByVal Value As String)
            m_Article = Value
            txt_Article.Data = Value

        End Set
    End Property

    Public Property VisibledArticle() As Boolean
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

    Public Property gLine() As String
        Get
            Return m_Line
        End Get
        Set(ByVal Value As String)
            m_Line = Value
            txt_Line.Data = Value

        End Set
    End Property

    Public Property VisibledLine() As Boolean
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


    Public Property gMaterialName() As String
        Get
            Return m_MaterialName
        End Get
        Set(ByVal Value As String)
            m_MaterialName = Value
            txt_MaterialName.Data = Value

        End Set
    End Property

    Public Property VisibledMaterialName() As Boolean
        Get
            Return m_vSMaterialName
        End Get
        Set(ByVal Value As Boolean)

            m_vSLine = Value
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

    Public Property gColorName() As String
        Get
            Return m_ColorName
        End Get
        Set(ByVal Value As String)
            m_ColorName = Value
            txt_ColorName.Data = Value

        End Set
    End Property

    Public Property VisibledColorName() As Boolean
        Get
            Return m_vSColorName
        End Get
        Set(ByVal Value As Boolean)

            m_vSLine = Value
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

    Public Property gMoldName() As String
        Get
            Return m_MoldName
        End Get
        Set(ByVal Value As String)
            m_MoldName = Value
            txt_MoldName.Data = Value

        End Set
    End Property

    Public Property VisibledMoldName() As Boolean
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

    Public Property gLastName() As String
        Get
            Return m_LastName
        End Get
        Set(ByVal Value As String)
            m_LastName = Value
            txt_LastName.Data = Value

        End Set
    End Property

    Public Property VisibledLastName() As Boolean
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

    Public Property gSizeRange() As String
        Get
            Return m_SizeRange
        End Get
        Set(ByVal Value As String)
            m_SizeRange = Value
            txt_SizeRange.Data = Value

        End Set
    End Property

    Public Property VisibledSizeRange() As Boolean
        Get
            Return m_vSSizeRange
        End Get
        Set(ByVal Value As Boolean)

            m_vSSizeRange = Value
            txt_SizeRange.Visible = Value

            If Value = False Then
                txt_SizeRange.Data = ""
                txt_SizeRange.Visible = False
            Else
                txt_SizeRange.Data = txt_SizeRange.PeaceTextbox1.Text
                txt_SizeRange.Visible = True
            End If

        End Set
    End Property


    Public Property gSpecNo() As String
        Get
            Return m_SpecNo
        End Get
        Set(ByVal Value As String)
            m_SpecNo = Value
            txt_SpecNo.Data = Value

        End Set
    End Property

    Public Property VisibledSpecNo() As Boolean
        Get
            Return m_vSSpecNo
        End Get
        Set(ByVal Value As Boolean)

            m_vSSpecNo = Value
            txt_SpecNo.Visible = Value

            If Value = False Then
                txt_SpecNo.Data = ""
                txt_SpecNo.Visible = False
            Else
                txt_SpecNo.Data = txt_SpecNo.PeaceTextbox1.Text
                txt_SpecStatus.Visible = True
            End If

        End Set
    End Property

    Public Property gUnitMaterial() As String
        Get
            Return m_UnitMaterial
        End Get
        Set(ByVal Value As String)
            m_UnitMaterial = Value
            txt_UnitMaterial.Data = Value

        End Set
    End Property

    Public Property VisibledUnitMaterial() As Boolean
        Get
            Return m_vSUnitMaterial
        End Get
        Set(ByVal Value As Boolean)

            m_vSUnitMaterial = Value
            txt_UnitMaterial.Visible = Value

            If Value = False Then
                txt_UnitMaterial.Data = ""
                txt_UnitMaterial.Visible = False
            Else
                txt_UnitMaterial.Data = txt_UnitMaterial.PeaceTextbox1.Text
                txt_UnitMaterial.Visible = True
            End If

        End Set
    End Property


    Public Property gUnitPacking() As String
        Get
            Return m_UnitPacking
        End Get
        Set(ByVal Value As String)
            m_UnitPacking = Value
            txt_UnitPacking.Data = Value

        End Set
    End Property

    Public Property VisibledUnitPacking() As Boolean
        Get
            Return m_vSUnitPacking
        End Get
        Set(ByVal Value As Boolean)

            m_vSUnitPacking = Value
            txt_UnitPacking.Visible = Value

            If Value = False Then
                txt_UnitPacking.Data = ""
                txt_UnitPacking.Visible = False
            Else
                txt_UnitPacking.Data = txt_UnitPacking.PeaceTextbox1.Text
                txt_UnitPacking.Visible = True
            End If

        End Set
    End Property




    Public Property gIncharge() As String
        Get
            Return m_Incharge
        End Get
        Set(ByVal Value As String)
            m_Incharge = Value
            txt_Incharge.Data = Value

        End Set
    End Property

    Public Property VisibledIncharge() As Boolean
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

    Public Property gCheckRequest() As String
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

    Public Property VisibledCheckRequest() As Boolean
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






#End Region
#Region "Property"

#End Region


End Class
