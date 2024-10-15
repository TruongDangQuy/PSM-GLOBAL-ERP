Imports System.Data.SqlClient
Module M_Variable

#Region "Enums"
    Public Enum ISUD
        Insert = 1
        Search = 2
        Update = 3
        Delete = 4
        Approval = 5
    End Enum
#End Region

#Region "ServerUse"
    Public Structure T01
        Dim SSER As String
        Dim SER As String
        Dim CLI As String
        Dim DBS As String
        Dim IDS As String
        Dim PWS As String
        Dim pos As String

        Dim SAJ As String
        Dim SAN As String
        Dim DAT As String
        Dim TIM As String
        Dim TIME As String
        Dim SAW As String
        Dim NAM As String
        Dim PWD As String
        Dim IPS As String
        Dim abc As String
        Dim VER As String
        Dim VERNEW As String

        Dim SETCS As String
        Dim GRA As String
        Dim GRP As String
        Dim SITE As String
        Dim SITENAME As String

        Dim PCK As String

        Dim NAT As String
        Dim BNAT As String

        Dim DYE As String

        Dim CPW As String

        Dim JUY As String
        Dim PId As String
        Dim PDT As String
        Dim Year As String
        Dim Month As String

        Dim ERO As String

        Dim DEPARTMENT As String

        Dim DEPARTMENTCHK As String
        Dim CUSCHK As String
        Dim SITECHK As String
        Dim ADMCHK As String
        Dim DEVCHK As String

    End Structure

    Public bolCheckRNDPrice As Boolean = False
    Public bolCheckSalesPrice As Boolean = False

    Public bolCheckBOM As Boolean = False
    Public bolCheckCBD As Boolean = False

    Public Pub As T01
    Public R9700 As T9700_AREA

#End Region

#Region "DataBaseUse"
    Public DSxxx As DataRow
    Public bLoadingForm As Boolean = False
    Public DBCONNECT_TYPE As String
    Public DbConnectCheck As Boolean
    Public pubDATE_FULL As String
    Public pubDATE As String

    Public SQL As String
    Public SQL0 As String
    Public SQL1 As String
    'Public cn As SqlConnection
    Public cntest As SqlConnection
    Friend rd As SqlDataReader
    Public rd1 As SqlDataReader
    Public rd2 As SqlDataReader
    Public cmd As New SqlCommand
    Public cmd1 As New SqlCommand
    Public cmd2 As New SqlCommand
    Public da As New SqlDataAdapter
    Public da1 As New SqlDataAdapter
    Public ds As New DataSet
    Public DS1 As New DataSet
    Public DS2 As New DataSet
    Public DS3 As New DataSet
    Public PASSWORDCHECK As String = ""
    Public str As String
    Public charac As String = ""
    Public SQLcon As String = "data Source=127.0.0.1;Initial Catalog=THANHCONG_MES;User ID=sa;Password=123"
    Public KindDB As String

#End Region

#Region "PrintUse"
    Public barBUYER As String
    Public barSTNO As String
    Public barGNAME As String

    Public barODNO As String
    Public barPONO As String

    Public barTCFNO As String
    Public barFNAME As String
    Public barCNAME As String
    Public barGRADE As String
    Public barRLNO As String
    Public barLTNO As String

    Public barGWGT As String
    Public barGWGT_NET As String

    Public barGYD As String
    Public barGYD_GROSS As String

    Public barSIZE As String
    Public barGPCS As String
    Public barGPCS_GROSS As String
    Public barCOLOR_GROUP As String

    Public barxFNAME As String

    Public barPOLYESTER As String
    Public barCOTTON As String

    Public xSIZE As String
    Public xWDGU_N As String
    Public barPOG As String
    Public barSGM2 As String
    Public barGRMT As String
    Public barGDATE As String

    Public barSANO As String
    Public barJAKJI As String
    Public xWDCD As String
    Public xKDNO As String
    Public barYD01 As String
    Public xSUMA As String

    Public xYARN01 As String
    Public xYARN02 As String

    Public xKEY1338 As String
#End Region

#Region "PrintUse"
    Public hlp0000SeVa As String = ""
    Public hlp0000SeVaTt As String = ""
    Public hlp0000SeVaTt1 As String = ""

    Public Array_hlp0000SeVaTt As New List(Of String)
    Public Array_hlp0000SeVaTt1 As New List(Of String)

    Public diembatdau As Integer
    Public syearn As Integer
    Public smonth As Integer
    Public eyearn As Integer
    Public emonth As Integer
    Public sday As Integer
    Public eday As Integer
    Public Structure DATASPACE

        Public CODE As String
        Public NAME As String
    End Structure
#End Region

#Region "Color"
    '---------- Area ----------
    Public Const cCtrVGap = 7
    Public Const cCtrHGap = 5
    Public Const cBtnTop = 5
    Public Const cBtnLeft = 5
    Public Const cBtnWidth = 75
    Public Const cBtnHeight = 21
    Public Const cChkTop = 5
    Public Const cCboTop = 7
    Public Const cTxtTop = 6
    Public Const cClbTop = 7
    Public Const cDtpTop = 6
    Public Const cRdoTop = 7
    Public Const cRdoLeft = 5
    Public Const cRdoHeight = 20

    '---------- Color  ----------
    ' Hưng đã thay đổi White Smoke
    Public cCheck As Color = Color.Aqua
    Public cUncheck As Color = Color.White


    Public cEnabledColor As Color = Color.White
    Public cDisabledColor As Color = Color.WhiteSmoke

    Public cGotFocusColor As Color = Color.LemonChiffon
    'Public cGotFocusColorText As Color = Color.WhiteSmoke
    'Public cLostFocusColor As Color = Color.WhiteSmoke

    Public cGotFocusColorText As Color = Color.White
    Public cLostFocusColor As Color = Color.White

    Public cForeColor As Color = Color.Black

    Public clrCheck As Color = Color.White
    Public clrUncheck As Color = SystemColors.ActiveCaption

    Public cBTOT As Color = Color.LightSkyBlue
    Public cSTOT As Color = Color.SkyBlue
    Public cTTOT As Color = Color.Pink
    Public cGTOT As Color = Color.LightGray

    Public cChangeForeColor As Color = Color.Red

    '--------- Control ---------
    Public cPnlBackColor = Color.WhiteSmoke

    '--------------------------

    '-------- sheet --------
    Public cSprGreyAreaBackColor As Color = Color.White

    Public cSprShadowColor As Color = Color.DarkBlue
    Public cSprShadowDark As Color = Color.Silver
    Public cSprShadowText As Color = Color.White

    Public cSprBackColor As Color = Color.LightGray

    Public cSprHeaderBackColor1 As Color = Color.RoyalBlue
    Public cSprHeaderBackColor2 As Color = Color.DarkBlue
    Public cSprHeaderForeColor As Color = Color.White

    Public cSprCellBackColor As Color = Color.DarkBlue
    Public cSprCellForeColor As Color = Color.Black
    Public cSprGridLineColor As Color = Color.LightGray

    'Public cSprSelectionBackColor As Color = Color.LemonChiffon
    Public cSprSelectionBackColor As Color = Color.Aquamarine 'Color.Aquamarine
    Public cSprSelectionForeColor As Color = Color.DimGray

    Public cSprEvenBackColor As Color = Color.White
    Public cSprOddRowBackColor As Color = Color.White

    Public cSprLockBackColor As Color = Color.Linen

    Public cRelation1HeaderColor As Color = Color.LightYellow

    Public cRelation3HeaderColor As Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
    Public cChat As Color = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(250, Byte), Integer))

    Public cRelation2HeaderColor As Color = Color.SteelBlue

    Public cSprRowHeight As Integer = 22
    Public cSprRowHeaderHeight As Integer = 40

    Public cSprWidthSize As Integer = 20

    Public cSprRowHeaderHeight_25 As Integer = 25

    Public cPInc As Color = Color.White
    Public cPCom As Color = Color.Violet
    Public cPHol As Color = Color.Orange
    Public cPCan As Color = Color.Yellow
    Public cPAcc As Color = Color.Red
    Public cPPro As Color = Color.Aqua

    Public cpOpen As Color = Color.GreenYellow
    Public cpClose As Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))

    Public MessSer As String

#End Region

#Region "Duy Add string Connect SQL"

    Public PasswordDuy As String = "NguyenKhanhHungVR"
    Public SaltDuy As String = "JunCo18CM"
    Public DefaultsValue As String = ""
    Public Class ConnectSQL
        Public Property Defaults As Integer
        Public Property ID As Integer
        Public Property Name As String
        Public Property SSER As String
        Public Property DBS As String
        Public Property IDS As String
        Public Property PWS As String
        Public Property SER As String
        Public Sub New()
        End Sub
        Public Sub New(iDefault As Integer, iD As Integer, name As String, sSER As String, dBS As String, iDS As String, pWS As String, sER As String)
            Me.Defaults = iDefault
            Me.ID = iD
            Me.Name = name
            Me.SSER = sSER
            Me.DBS = dBS
            Me.IDS = iDS
            Me.PWS = pWS
            Me.SER = sER
        End Sub
    End Class

    Public ListConnectSql As IEnumerable(Of ConnectSQL)
#End Region

End Module
