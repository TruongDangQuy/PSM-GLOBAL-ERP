Public Class PFW99998
#Region "Variable"
    Private t_SPACE, SANO As String
    Private Job_Start As Boolean

    Private W7411 As T7411_AREA
    Private W9982 As T9982_AREA
    Private W9981 As T9981_AREA
    Private W9985 As T9985_AREA

    Private W9992 As T9992_AREA
    Private W9996 As T9996_AREA

    Private Dsu01 As Long
    Private a7411() As T7411_AREA
    Private a9982() As T9982_AREA
    Private L9996 As T9996_AREA

    Private W7171 As T7171_AREA

    Dim tabcheck As Boolean = False

    Private Structure PFW9999
        Public W9999_IDNO As String
        Public W9999_Seq As String
        Public W9999_IDCard As String
        Public W9999_seMainProcess As String
        Public W9999_cdMainProcess As String
        Public W9999_seSubProcess As String
        Public W9999_cdSubProcess As String
        Public W9999_seFactory As String
        Public W9999_cdFactory As String
        Public W9999_seLineProd As String
        Public W9999_cdLineProd As String
        Public W9999_CheckUse As String
    End Structure

    Private a9999s As List(Of PFW9999)

#End Region

#Region "Form_Load"
    Private Sub PFW99998_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            W9982 = D9982
            W9981 = D9981
            W9985 = D9985
            W7411 = D7411

            lab_SITE.Data = "CHANG SHUEN"
            lab_SITE.Code = "001"
            lab_SITE.Tag = "001"

            DataInti()

        Catch ex As Exception

        End Try
        
    End Sub

    Private Function DataInti() As Boolean
        DataInti = False
        Try
            CreateTable()
            CreateSP()
            DataInti = True
        Catch ex As Exception

        End Try
    End Function

    Private Function CreateTable() As Boolean
        CreateTable = False
        Try
            rd = SqlDR("SELECT COUNT(1) AS CheckCount FROM sys.tables mt WITH (NOLOCK) WHERE mt.name = 'PFW9999'", cn)
            If rd.Read() Then
                If rd("CheckCount").ToString = "0" Then
                    Dim sql As String = ""
                    sql = sql & "SET ANSI_NULLS ON " & vbCrLf
                    sql = sql & "GO " & vbCrLf
                    sql = sql & "SET QUOTED_IDENTIFIER ON " & vbCrLf
                    sql = sql & "GO " & vbCrLf
                    sql = sql & "SET ANSI_PADDING ON " & vbCrLf
                    sql = sql & "GO " & vbCrLf
                    sql = sql & "CREATE TABLE [dbo].[PFW9999]( " & vbCrLf
                    sql = sql & "	[W9999_IDNO] [CHAR](8) NOT NULL, " & vbCrLf
                    sql = sql & "	[W9999_Seq] [CHAR](5) NOT NULL, " & vbCrLf
                    sql = sql & "	[W9999_IDCard] [NVARCHAR](100) NULL, " & vbCrLf
                    sql = sql & "	[W9999_seFactory] [CHAR](3) NULL, " & vbCrLf
                    sql = sql & "	[W9999_cdFactory] [CHAR](3) NULL, " & vbCrLf
                    sql = sql & "	[W9999_seMainProcess] [CHAR](3) NULL, " & vbCrLf
                    sql = sql & "	[W9999_cdMainProcess] [CHAR](3) NULL, " & vbCrLf
                    sql = sql & "	[W9999_seSubProcess] [CHAR](3) NULL, " & vbCrLf
                    sql = sql & "	[W9999_cdSubProcess] [CHAR](3) NULL, " & vbCrLf
                    sql = sql & "	[W9999_seLineProd] [CHAR](3) NULL, " & vbCrLf
                    sql = sql & "	[W9999_cdLineProd] [CHAR](3) NULL, " & vbCrLf
                    sql = sql & "	[W9999_CheckUse] [CHAR](1) NOT NULL, " & vbCrLf
                    sql = sql & " CONSTRAINT [PK_PFW9999] PRIMARY KEY CLUSTERED  " & vbCrLf
                    sql = sql & "( " & vbCrLf
                    sql = sql & "	[W9999_IDNO] ASC, " & vbCrLf
                    sql = sql & "	[W9999_Seq] ASC " & vbCrLf
                    sql = sql & ")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] " & vbCrLf
                    sql = sql & ") ON [PRIMARY] " & vbCrLf
                    sql = sql & "GO " & vbCrLf
                    sql = sql & "SET ANSI_PADDING OFF " & vbCrLf
                    sql = sql & "GO " & vbCrLf

                    cmd = New SqlClient.SqlCommand
                    cmd.CommandText = sql
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = cn
                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                    End Try
                End If
            End If

            rd.Close()

            CreateTable = True
        Catch ex As Exception

        End Try
    End Function
    Private Function CreateSP() As Boolean
        Try
            Dim DS As New DataSet
            Dim sqlcheck As String = ""
            Dim SQL As String = ""

            sqlcheck = sqlcheck & "SELECT mt.name, CASE WHEN ISNULL(K1.name,'') = '' THEN '1' ELSE '0' END AS checkinsert " & vbCrLf
            sqlcheck = sqlcheck & "	FROM (	SELECT 'PSM_USP_PFW99998_SEARCH_VS1' AS name  " & vbCrLf
            sqlcheck = sqlcheck & "			UNION ALL SELECT 'PSM_USP_PFW99998_SEARCH_VS1_LINE' AS name  " & vbCrLf
            sqlcheck = sqlcheck & "			UNION ALL SELECT 'PSM_USP_PFW99998_SEARCH_VS1_LINE_DISPLAY' AS name  " & vbCrLf
            sqlcheck = sqlcheck & "			UNION ALL SELECT 'PSM_USP_PFW99998_SEARCH_VS22_K7171' AS name  " & vbCrLf
            sqlcheck = sqlcheck & "			UNION ALL SELECT 'PSM_USP_PFW99998_SEARCH_VS23_K7171' AS name  " & vbCrLf
            sqlcheck = sqlcheck & "			UNION ALL SELECT 'PSM_USP_PFW99998_SEARCH_VS21_K7171' AS name  " & vbCrLf
            sqlcheck = sqlcheck & "		) AS MT " & vbCrLf
            sqlcheck = sqlcheck & "LEFT JOIN sys.objects K1 ON K1.name = MT.name AND K1.type = 'P' " & vbCrLf

            cmd = New SqlClient.SqlCommand
            cmd.CommandText = sqlcheck
            cmd.CommandType = CommandType.Text
            cmd.Connection = cn
            DS = New DataSet
            DS = PrcDS(cmd, cn)
            Dim i As Integer = 0
            For i = 0 To DS.Tables(0).Rows.Count - 1 Step 1
                If DS.Tables(0).Rows(i)("checkinsert").ToString = "1" Then
                    Select Case DS.Tables(0).Rows(i)("name").ToString
                        Case "PSM_USP_PFW99998_SEARCH_VS1"

                            SQL = "/* " & vbCrLf
                            SQL = SQL & "-- ============================================= " & vbCrLf
                            SQL = SQL & "-- Author:		Minh Duy " & vbCrLf
                            SQL = SQL & "-- Create date: 2019/05/08 " & vbCrLf
                            SQL = SQL & "-- Description:	Sheet Vs1 Display  " & vbCrLf
                            SQL = SQL & "-- ============================================= " & vbCrLf
                            SQL = SQL & " " & vbCrLf
                            SQL = SQL & "	[PSM_USP_PFW99998_SEARCH_VS1] '','','471','472','473','474','475','476','1','1' " & vbCrLf
                            SQL = SQL & "*/ " & vbCrLf
                            SQL = SQL & " " & vbCrLf
                            SQL = SQL & "CREATE PROC [dbo].[PSM_USP_PFW99998_SEARCH_VS1] " & vbCrLf
                            SQL = SQL & "	@NAME					NVARCHAR(50)," & vbCrLf
                            SQL = SQL & "	@SITE					NVARCHAR(50)," & vbCrLf
                            SQL = SQL & "	@Const_Site				NVARCHAR(3)," & vbCrLf
                            SQL = SQL & "	@Const_Nationality		NVARCHAR(3)," & vbCrLf
                            SQL = SQL & "	@Const_Department		NVARCHAR(3)," & vbCrLf
                            SQL = SQL & "	@Const_OnePosition		NVARCHAR(3)," & vbCrLf
                            SQL = SQL & "	@Const_Position			NVARCHAR(3)," & vbCrLf
                            SQL = SQL & "	@Const_InCharge			NVARCHAR(3)," & vbCrLf
                            SQL = SQL & "	@UseCheck1				NVARCHAR(1)," & vbCrLf
                            SQL = SQL & "	@UseCheck2				NVARCHAR(1)" & vbCrLf
                            SQL = SQL & "AS" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "SET	@Const_Site			=	'471'" & vbCrLf
                            SQL = SQL & "SET	@Const_Nationality	=	'472'" & vbCrLf
                            SQL = SQL & "SET	@Const_Department	=	'474'" & vbCrLf
                            SQL = SQL & "SET	@Const_OnePosition	=	'473'" & vbCrLf
                            SQL = SQL & "SET	@Const_Position		=	'475'" & vbCrLf
                            SQL = SQL & "SET	@Const_InCharge		=	'476'" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "DECLARE 	@SQL0   NVARCHAR(4000)" & vbCrLf
                            SQL = SQL & "DECLARE 	@SQL1   NVARCHAR(4000)" & vbCrLf
                            SQL = SQL & "DECLARE 	@SQL2   NVARCHAR(4000)" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "SET @SQL0 = ''" & vbCrLf
                            SQL = SQL & "SET @SQL1 = ''" & vbCrLf
                            SQL = SQL & "SET @SQL2 = ''" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "SET @SQL0 = @SQL0 + '" & vbCrLf
                            SQL = SQL & "	SELECT	ISNULL(K7411_IDNO, '' '')				AS	Key_IDNO " & vbCrLf
                            SQL = SQL & "	" & vbCrLf
                            SQL = SQL & "		,	'' ''									AS	SCHK" & vbCrLf
                            SQL = SQL & "		,	ISNULL(K7411_IDNO, '' '')				AS	IDNO " & vbCrLf
                            SQL = SQL & "		,	ISNULL(K7411_Name, '' '')				AS	Name" & vbCrLf
                            SQL = SQL & "		,	ISNULL(K9992_ID, '' '')					AS	ID  " & vbCrLf
                            SQL = SQL & "		,	ISNULL(K9992_PW, '' '')					AS	PW " & vbCrLf
                            SQL = SQL & "		,	ISNULL(Z2.K7171_BasicName, '' '')		AS	NameNationality" & vbCrLf
                            SQL = SQL & "		,	ISNULL(Z3.K7171_BasicName, '' '')		AS	NamtDepartment " & vbCrLf
                            SQL = SQL & "		,	ISNULL(Z4.K7171_BasicName, '' '')		AS	NamtOnePosition" & vbCrLf
                            SQL = SQL & "		,	ISNULL(Z5.K7171_BasicName, '' '')		AS	NamtPosition" & vbCrLf
                            SQL = SQL & "		,	ISNULL(Z6.K7171_BasicName, '' '')		AS	NamtInCharge" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "		,	ISNULL(K9992_CUSTOMER_CHK, '' '')		AS	CUSTOMER_CHK " & vbCrLf
                            SQL = SQL & "		,	ISNULL(K9992_GROUP_BASIC, '' '')		AS	GROUP_BASIC " & vbCrLf
                            SQL = SQL & "'" & vbCrLf
                            SQL = SQL & "SET @SQL1 = @SQL1 + '" & vbCrLf
                            SQL = SQL & "	FROM			PFK7411							WITH(NOLOCK)" & vbCrLf
                            SQL = SQL & "	" & vbCrLf
                            SQL = SQL & "	LEFT	JOIN	PFK9992							WITH(NOLOCK)					" & vbCrLf
                            SQL = SQL & "			ON		K9992_SITE						=	K7411_cdSite" & vbCrLf
                            SQL = SQL & "			AND		K9992_SANO						=	K7411_IDNO" & vbCrLf
                            SQL = SQL & "			" & vbCrLf
                            SQL = SQL & "	LEFT	JOIN	PFK7171							AS	Z1 WITH(NOLOCK)" & vbCrLf
                            SQL = SQL & "			ON		K7411_cdSite					=	Z1.K7171_BasicCode " & vbCrLf
                            SQL = SQL & "			AND		Z1.K7171_BasicSel				=	''' + @Const_Site + ''' " & vbCrLf
                            SQL = SQL & "			" & vbCrLf
                            SQL = SQL & "	LEFT	JOIN	PFK7171							AS	Z2 WITH(NOLOCK)" & vbCrLf
                            SQL = SQL & "			ON		K7411_cdNationality				=	Z2.K7171_BasicCode " & vbCrLf
                            SQL = SQL & "			AND		Z2.K7171_BasicSel				=	''' + @Const_Nationality + ''' " & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "	LEFT	JOIN	PFK7171							AS	Z3 WITH(NOLOCK)" & vbCrLf
                            SQL = SQL & "			ON		K7411_cdDepartment				=	Z3.K7171_BasicCode " & vbCrLf
                            SQL = SQL & "			AND		Z3.K7171_BasicSel				=	''' + @Const_Department + ''' " & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "	LEFT	JOIN	PFK7171							AS	Z4 WITH(NOLOCK)" & vbCrLf
                            SQL = SQL & "			ON		K7411_cdOnePosition				=	Z4.K7171_BasicCode " & vbCrLf
                            SQL = SQL & "			AND		Z4.K7171_BasicSel				=	''' + @Const_OnePosition + ''' " & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "	LEFT	JOIN	PFK7171							AS	Z5 WITH(NOLOCK)" & vbCrLf
                            SQL = SQL & "			ON		K7411_cdPosition				=	Z5.K7171_BasicCode " & vbCrLf
                            SQL = SQL & "			AND		Z5.K7171_BasicSel				=	''' + @Const_Position + ''' " & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "	LEFT	JOIN	PFK7171							AS	Z6 WITH(NOLOCK)" & vbCrLf
                            SQL = SQL & "			ON		K7411_cdInCharge				=	Z6.K7171_BasicCode " & vbCrLf
                            SQL = SQL & "			AND		Z6.K7171_BasicSel				=	''' + @Const_InCharge + ''' " & vbCrLf
                            SQL = SQL & "			" & vbCrLf
                            SQL = SQL & " '" & vbCrLf
                            SQL = SQL & "SET @SQL2 =  @SQL2 + '" & vbCrLf
                            SQL = SQL & "	WHERE			K7411_IDNO						<>	'' '' '" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "IF LTRIM(@NAME)		<> ''	BEGIN SET  @SQL2 = @SQL2 + '	" & vbCrLf
                            SQL = SQL & "			AND		K7411_Name						LIKE	''%'+ @NAME +'%'' '		END" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "IF LTRIM(@SITE)		<> ''	BEGIN SET  @SQL2 = @SQL2 + '	" & vbCrLf
                            SQL = SQL & "			AND		Z1.k7171_BasicName				LIKE	''%'+ @SITE +'%'' '		END" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "SET @SQL2 = @SQL2 + ' AND ( K7411_CheckUse   = '' '' '" & vbCrLf
                            SQL = SQL & "	IF LTRIM(@UseCheck1) = '1'  BEGIN SET @SQL2 = @SQL2 + ' OR K7411_CheckUse =  ''1''  ' END" & vbCrLf
                            SQL = SQL & "	IF LTRIM(@UseCheck2) = '1'  BEGIN SET @SQL2 = @SQL2 + ' OR K7411_CheckUse =  ''2''  ' END" & vbCrLf
                            SQL = SQL & "SET @SQL2 = @SQL2 + ' ) '" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "SET @SQL2 =  @SQL2 + '" & vbCrLf
                            SQL = SQL & "	ORDER	BY		K7411_IDNO '" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "EXEC (@SQL0 + @SQL1 + @SQL2)" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "PRINT @SQL0 " & vbCrLf
                            SQL = SQL & "PRINT @SQL1" & vbCrLf
                            SQL = SQL & "PRINT @SQL2" & vbCrLf
                            SQL = SQL & "" & vbCrLf

                            cmd = New SqlClient.SqlCommand
                            cmd.CommandText = SQL
                            cmd.CommandType = CommandType.Text
                            cmd.Connection = cn
                            Try
                                cmd.ExecuteNonQuery()
                            Catch ex As Exception
                            End Try

                        Case "PSM_USP_PFW99998_SEARCH_VS1_LINE"

                            SQL = "/* " & vbCrLf
                            SQL = SQL & "-- ============================================= " & vbCrLf
                            SQL = SQL & "-- Author:		Minh Duy " & vbCrLf
                            SQL = SQL & "-- Create date: 2019/05/08 " & vbCrLf
                            SQL = SQL & "-- Description:	Sheet Vs1 Display  " & vbCrLf
                            SQL = SQL & "-- ============================================= " & vbCrLf
                            SQL = SQL & " " & vbCrLf
                            SQL = SQL & "	[PSM_USP_PFW99998_SEARCH_VS1_LINE] '00000001','471','472','473','474','475','476'" & vbCrLf
                            SQL = SQL & "*/ " & vbCrLf
                            SQL = SQL & " " & vbCrLf
                            SQL = SQL & "CREATE    PROC [dbo].[PSM_USP_PFW99998_SEARCH_VS1_LINE]" & vbCrLf
                            SQL = SQL & "	@IDNO					CHAR(8)," & vbCrLf
                            SQL = SQL & "	@Const_Site				NVARCHAR(3)," & vbCrLf
                            SQL = SQL & "	@Const_Nationality		NVARCHAR(3)," & vbCrLf
                            SQL = SQL & "	@Const_Department		NVARCHAR(3)," & vbCrLf
                            SQL = SQL & "	@Const_OnePosition		NVARCHAR(3)," & vbCrLf
                            SQL = SQL & "	@Const_Position			NVARCHAR(3)," & vbCrLf
                            SQL = SQL & "	@Const_InCharge			NVARCHAR(3)" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "AS" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "SET	@Const_Site			=	'471'" & vbCrLf
                            SQL = SQL & "SET	@Const_Nationality	=	'472'" & vbCrLf
                            SQL = SQL & "SET	@Const_Department	=	'474'" & vbCrLf
                            SQL = SQL & "SET	@Const_OnePosition	=	'473'" & vbCrLf
                            SQL = SQL & "SET	@Const_Position		=	'475'" & vbCrLf
                            SQL = SQL & "SET	@Const_InCharge		=	'476'" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "DECLARE 	@SQL0   NvarChar(4000)" & vbCrLf
                            SQL = SQL & "DECLARE 	@SQL1   NvarChar(4000)" & vbCrLf
                            SQL = SQL & "DECLARE 	@SQL2   NvarChar(4000)" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "SET @SQL0 = ''" & vbCrLf
                            SQL = SQL & "SET @SQL1 = ''" & vbCrLf
                            SQL = SQL & "SET @SQL2 = ''" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "SET @SQL0 = @SQL0 + '" & vbCrLf
                            SQL = SQL & "	SELECT	ISNULL(K7411_IDNO, '' '')				AS	Key_IDNO " & vbCrLf
                            SQL = SQL & "	" & vbCrLf
                            SQL = SQL & "		,	ISNULL(K7411_IDNO, '' '')				AS	IDNO " & vbCrLf
                            SQL = SQL & "		,	ISNULL(K9992_ID, '' '')					AS	IDNAME " & vbCrLf
                            SQL = SQL & "		,	ISNULL(K9992_PW, '' '')					AS	PW " & vbCrLf
                            SQL = SQL & "		,	ISNULL(K9992_GROUPPW, '' '')			AS	GROUPPW " & vbCrLf
                            SQL = SQL & "		,	ISNULL(K9992_GROUP, '' '')				AS	[GROUP]" & vbCrLf
                            SQL = SQL & "		,	ISNULL(Z7.K7171_BasicName, '' '')		AS	GROUPNAME" & vbCrLf
                            SQL = SQL & "		,	ISNULL(K7411_Name, '' '')				AS	Name " & vbCrLf
                            SQL = SQL & "		,	ISNULL(K9992_GROUP_ERO, '' '')			AS	GROUP_ERO " & vbCrLf
                            SQL = SQL & "		,	ISNULL(K9992_GROUP_BASIC, ''2'')		AS	GROUP_BASIC " & vbCrLf
                            SQL = SQL & "						" & vbCrLf
                            SQL = SQL & "		,	ISNULL(Z1.K7171_BasicName, '' '')		AS	NameSite" & vbCrLf
                            SQL = SQL & "		,	ISNULL(Z1.K7171_BasicCode, '' '')		AS	NameCode " & vbCrLf
                            SQL = SQL & "		,	ISNULL(Z2.K7171_BasicName, '' '')		AS	NameNationality" & vbCrLf
                            SQL = SQL & "		,	ISNULL(Z3.K7171_BasicName, '' '')		AS	NameDepartment " & vbCrLf
                            SQL = SQL & "		,	ISNULL(Z4.K7171_BasicName, '' '')		AS	NameOnePosition" & vbCrLf
                            SQL = SQL & "		,	ISNULL(Z5.K7171_BasicName, '' '')		AS	NamePosition" & vbCrLf
                            SQL = SQL & "		,	ISNULL(Z6.K7171_BasicName, '' '')		AS	NameInCharge" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "		,	ISNULL(K9992_CUSTOMER_CHK, '' '')		AS	CUSTOMER_CHK " & vbCrLf
                            SQL = SQL & "		,	ISNULL(K9992_GROUP_BASIC, '' '')		AS	GROUP_BASIC " & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "		,	ISNULL(K7411_IDCard, '''')				AS	IDCard" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "'" & vbCrLf
                            SQL = SQL & "SET @SQL1 = @SQL1 + '" & vbCrLf
                            SQL = SQL & "	FROM			PFK7411 " & vbCrLf
                            SQL = SQL & "	" & vbCrLf
                            SQL = SQL & "	LEFT	JOIN	PFK9992							" & vbCrLf
                            SQL = SQL & "			ON		K9992_SITE						=	K7411_cdSite" & vbCrLf
                            SQL = SQL & "			AND		K9992_SANO						=	K7411_IDNO" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "	LEFT	JOIN	PFK7171							AS	Z1" & vbCrLf
                            SQL = SQL & "			ON		K7411_cdSite						=	Z1.k7171_BasicCode " & vbCrLf
                            SQL = SQL & "			AND		Z1.k7171_BasicSel				=	''' + @Const_Site + ''' " & vbCrLf
                            SQL = SQL & "			" & vbCrLf
                            SQL = SQL & "	LEFT	JOIN	PFK7171							AS	Z2" & vbCrLf
                            SQL = SQL & "			ON		K7411_cdNationality				=	Z2.k7171_BasicCode " & vbCrLf
                            SQL = SQL & "			AND		Z2.k7171_BasicSel				=	''' + @Const_Nationality + ''' " & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "	LEFT	JOIN	PFK7171							AS	Z3" & vbCrLf
                            SQL = SQL & "			ON		K7411_cdDepartment				=	Z3.k7171_BasicCode " & vbCrLf
                            SQL = SQL & "			AND		Z3.k7171_BasicSel				=	''' + @Const_Department + ''' " & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "	LEFT	JOIN	PFK7171							AS	Z4" & vbCrLf
                            SQL = SQL & "			ON		K7411_cdOnePosition				=	Z4.k7171_BasicCode " & vbCrLf
                            SQL = SQL & "			AND		Z4.k7171_BasicSel				=	''' + @Const_OnePosition + ''' " & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "	LEFT	JOIN	PFK7171							AS	Z5" & vbCrLf
                            SQL = SQL & "			ON		K7411_cdPosition					=	Z5.k7171_BasicCode " & vbCrLf
                            SQL = SQL & "			AND		Z5.k7171_BasicSel				=	''' + @Const_Position + ''' " & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "	LEFT	JOIN	PFK7171							AS	Z6" & vbCrLf
                            SQL = SQL & "			ON		K7411_cdInCharge					=	Z6.k7171_BasicCode " & vbCrLf
                            SQL = SQL & "			AND		Z6.k7171_BasicSel				=	''' + @Const_InCharge + ''' " & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "	LEFT	JOIN	PFK7171							AS	Z7" & vbCrLf
                            SQL = SQL & "			ON		Z7.k7171_BasicSel				=	''905''" & vbCrLf
                            SQL = SQL & "			AND		K9992_GROUP						=	Z7.k7171_BasicCode " & vbCrLf
                            SQL = SQL & "	" & vbCrLf
                            SQL = SQL & "					" & vbCrLf
                            SQL = SQL & " '" & vbCrLf
                            SQL = SQL & "SET @SQL2 =  @SQL2 + '" & vbCrLf
                            SQL = SQL & "	WHERE			K7411_IDNO					=	''' + @IDNO + ''' '" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "EXEC (@SQL0 + @SQL1 + @SQL2)" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "PRINT @SQL0 " & vbCrLf
                            SQL = SQL & "PRINT @SQL1" & vbCrLf
                            SQL = SQL & "PRINT @SQL2" & vbCrLf

                            cmd = New SqlClient.SqlCommand
                            cmd.CommandText = SQL
                            cmd.CommandType = CommandType.Text
                            cmd.Connection = cn
                            Try
                                cmd.ExecuteNonQuery()
                            Catch ex As Exception
                            End Try

                        Case "PSM_USP_PFW99998_SEARCH_VS1_LINE_DISPLAY"

                            SQL = "/* " & vbCrLf
                            SQL = SQL & "-- ============================================= " & vbCrLf
                            SQL = SQL & "-- Author:		Minh Duy " & vbCrLf
                            SQL = SQL & "-- Create date: 2019/05/08 " & vbCrLf
                            SQL = SQL & "-- Description:	Sheet Vs1 Display  " & vbCrLf
                            SQL = SQL & "-- ============================================= " & vbCrLf
                            SQL = SQL & "SELECT  * FROM PFK9992" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "	PSM_USP_PFW99998_SEARCH_VS1_LINE_DISPLAY '','471','472','473','474','475','476','1','1'" & vbCrLf
                            SQL = SQL & "	EXEC PSM_USP_PFW99998_SEARCH_VS1_LINE_DISPLAY '00000103',  '012',  '013',  '014',  '015',  '016',  '017',  '1',  '1' " & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "*/" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "CREATE    PROC [dbo].[PSM_USP_PFW99998_SEARCH_VS1_LINE_DISPLAY]" & vbCrLf
                            SQL = SQL & "	@SANO					CHAR(8)," & vbCrLf
                            SQL = SQL & "	@Const_Site				NVARCHAR(3)," & vbCrLf
                            SQL = SQL & "	@Const_Nationality		NVARCHAR(3)," & vbCrLf
                            SQL = SQL & "	@Const_Department		NVARCHAR(3)," & vbCrLf
                            SQL = SQL & "	@Const_OnePosition		NVARCHAR(3)," & vbCrLf
                            SQL = SQL & "	@Const_Position			NVARCHAR(3)," & vbCrLf
                            SQL = SQL & "	@Const_InCharge			NVARCHAR(3)," & vbCrLf
                            SQL = SQL & "	@UseCheck1				NVARCHAR(1)," & vbCrLf
                            SQL = SQL & "	@UseCheck2				NVARCHAR(1)" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "AS" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "SET	@Const_Site			=	'471'" & vbCrLf
                            SQL = SQL & "SET	@Const_Nationality	=	'472'" & vbCrLf
                            SQL = SQL & "SET	@Const_Department	=	'474'" & vbCrLf
                            SQL = SQL & "SET	@Const_OnePosition	=	'473'" & vbCrLf
                            SQL = SQL & "SET	@Const_Position		=	'475'" & vbCrLf
                            SQL = SQL & "SET	@Const_InCharge		=	'476'" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "DECLARE 	@SQL0   NVARCHAR(4000)" & vbCrLf
                            SQL = SQL & "DECLARE 	@SQL1   NVARCHAR(4000)" & vbCrLf
                            SQL = SQL & "DECLARE 	@SQL2   NVARCHAR(4000)" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "SET @SQL0 = ''" & vbCrLf
                            SQL = SQL & "SET @SQL1 = ''" & vbCrLf
                            SQL = SQL & "SET @SQL2 = ''" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "SET @SQL0 = @SQL0 + '" & vbCrLf
                            SQL = SQL & "	SELECT	ISNULL(K7411_IDNO, '' '')				AS	Key_IDNO " & vbCrLf
                            SQL = SQL & "	" & vbCrLf
                            SQL = SQL & "		,	'' ''									AS	SCHK" & vbCrLf
                            SQL = SQL & "		,	ISNULL(K7411_IDNO, '' '')				AS	IDNO " & vbCrLf
                            SQL = SQL & "		,	ISNULL(K7411_Name, '' '')				AS	Name" & vbCrLf
                            SQL = SQL & "		,	ISNULL(K9992_ID, '' '')					AS	ID  " & vbCrLf
                            SQL = SQL & "		,	ISNULL(K9992_PW, '' '')					AS	PW " & vbCrLf
                            SQL = SQL & "		,	ISNULL(Z2.K7171_BasicName, '' '')		AS	NameNationality" & vbCrLf
                            SQL = SQL & "		,	ISNULL(Z3.K7171_BasicName, '' '')		AS	NamtDepartment " & vbCrLf
                            SQL = SQL & "		,	ISNULL(Z4.K7171_BasicName, '' '')		AS	NamtOnePosition" & vbCrLf
                            SQL = SQL & "		,	ISNULL(Z5.K7171_BasicName, '' '')		AS	NamtPosition" & vbCrLf
                            SQL = SQL & "		,	ISNULL(Z6.K7171_BasicName, '' '')		AS	NamtInCharge" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "		,	ISNULL(K9992_CUSTOMER_CHK, '' '')		AS	CUSTOMER_CHK " & vbCrLf
                            SQL = SQL & "		,	ISNULL(K9992_GROUP_BASIC, '' '')		AS	GROUP_BASIC " & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "'" & vbCrLf
                            SQL = SQL & "SET @SQL1 = @SQL1 + '" & vbCrLf
                            SQL = SQL & "	FROM			PFK7411 " & vbCrLf
                            SQL = SQL & "	" & vbCrLf
                            SQL = SQL & "	INNER	JOIN	PFK9992							" & vbCrLf
                            SQL = SQL & "			ON		K9992_SITE						=	K7411_cdSite" & vbCrLf
                            SQL = SQL & "			AND		K9992_SANO						=	K7411_IDNO" & vbCrLf
                            SQL = SQL & "			" & vbCrLf
                            SQL = SQL & "	LEFT	JOIN	PFK7171							AS	Z1" & vbCrLf
                            SQL = SQL & "			ON		K7411_cdSite					=	Z1.K7171_BasicCode " & vbCrLf
                            SQL = SQL & "			AND		Z1.K7171_BasicSel				=	''' + @Const_Site + ''' " & vbCrLf
                            SQL = SQL & "			" & vbCrLf
                            SQL = SQL & "	LEFT	JOIN	PFK7171							AS	Z2" & vbCrLf
                            SQL = SQL & "			ON		K7411_cdNationality				=	Z2.K7171_BasicCode " & vbCrLf
                            SQL = SQL & "			AND		Z2.K7171_BasicSel				=	''' + @Const_Nationality + ''' " & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "	LEFT	JOIN	PFK7171							AS	Z3" & vbCrLf
                            SQL = SQL & "			ON		K7411_cdDepartment				=	Z3.K7171_BasicCode " & vbCrLf
                            SQL = SQL & "			AND		Z3.K7171_BasicSel				=	''' + @Const_Department + ''' " & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "	LEFT	JOIN	PFK7171							AS	Z4" & vbCrLf
                            SQL = SQL & "			ON		K7411_cdOnePosition				=	Z4.K7171_BasicCode " & vbCrLf
                            SQL = SQL & "			AND		Z4.K7171_BasicSel				=	''' + @Const_OnePosition + ''' " & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "	LEFT	JOIN	PFK7171							AS	Z5" & vbCrLf
                            SQL = SQL & "			ON		K7411_cdPosition				=	Z5.K7171_BasicCode " & vbCrLf
                            SQL = SQL & "			AND		Z5.K7171_BasicSel				=	''' + @Const_Position + ''' " & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "	LEFT	JOIN	PFK7171							AS	Z6" & vbCrLf
                            SQL = SQL & "			ON		K7411_cdInCharge				=	Z6.K7171_BasicCode " & vbCrLf
                            SQL = SQL & "			AND		Z6.K7171_BasicSel				=	''' + @Const_InCharge + ''' " & vbCrLf
                            SQL = SQL & "			" & vbCrLf
                            SQL = SQL & " '" & vbCrLf
                            SQL = SQL & "SET @SQL2 =  @SQL2 + '" & vbCrLf
                            SQL = SQL & "	WHERE			K7411_IDNO						=	''' + @SANO + ''' '" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "SET @SQL2 =  @SQL2 + '" & vbCrLf
                            SQL = SQL & "	ORDER	BY		K7411_IDNO '" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "EXEC (@SQL0 + @SQL1 + @SQL2)" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "PRINT @SQL0 " & vbCrLf
                            SQL = SQL & "PRINT @SQL1" & vbCrLf
                            SQL = SQL & "PRINT @SQL2" & vbCrLf

                            cmd = New SqlClient.SqlCommand
                            cmd.CommandText = SQL
                            cmd.CommandType = CommandType.Text
                            cmd.Connection = cn
                            Try
                                cmd.ExecuteNonQuery()
                            Catch ex As Exception
                            End Try

                        Case "PSM_USP_PFW99998_SEARCH_VS21_K7171"

                            SQL = "/* " & vbCrLf
                            SQL = SQL & "-- ============================================= " & vbCrLf
                            SQL = SQL & "-- Author:		Minh Duy " & vbCrLf
                            SQL = SQL & "-- Create date: 2019/05/08 " & vbCrLf
                            SQL = SQL & "-- Description:	Sheet Vs1 Display  " & vbCrLf
                            SQL = SQL & "-- ============================================= " & vbCrLf
                            SQL = SQL & "	PSM_USP_PFW99998_SEARCH_VS21_K7171 '00005827'" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "*/" & vbCrLf
                            SQL = SQL & "CREATE    PROC [dbo].[PSM_USP_PFW99998_SEARCH_VS21_K7171]" & vbCrLf
                            SQL = SQL & "	@IDNO CHAR(8)" & vbCrLf
                            SQL = SQL & "AS" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "DECLARE 	@SQL0   NVARCHAR(4000)" & vbCrLf
                            SQL = SQL & "DECLARE 	@SQL1   NVARCHAR(4000)" & vbCrLf
                            SQL = SQL & "DECLARE 	@SQL2   NVARCHAR(4000)" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "SET @SQL0 = ''" & vbCrLf
                            SQL = SQL & "SET @SQL1 = ''" & vbCrLf
                            SQL = SQL & "SET @SQL2 = ''" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "SET @SQL0 = @SQL0 + '" & vbCrLf
                            SQL = SQL & "BEGIN" & vbCrLf
                            SQL = SQL & "	SELECT		CASE WHEN ISNULL(K1.W9999_IDNO, '''') = '''' THEN ''0'' ELSE ''1'' END					AS	PCHK_PFK99998_VS22" & vbCrLf
                            SQL = SQL & "		  ,		MT.K7171_BasicSel																		AS	Key_BasicSel_PFK99998_VS22" & vbCrLf
                            SQL = SQL & "		  ,		MT.K7171_BasicCode																		AS	Key_BasicCode_PFK99998_VS22" & vbCrLf
                            SQL = SQL & "		  ,		MT.K7171_BasicName																		AS	BasicName_PFK99998_VS22" & vbCrLf
                            SQL = SQL & "		  ,		MT.K7171_NameSimply																		AS	NameSimply_PFK99998_VS22" & vbCrLf
                            SQL = SQL & "'" & vbCrLf
                            SQL = SQL & "SET @SQL1 = @SQL1 + '" & vbCrLf
                            SQL = SQL & "	FROM		PFK7171						MT WITH (NOLOCK)" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "	LEFT	JOIN	PFW9999				K1 WITH(NOLOCK)" & vbCrLf
                            SQL = SQL & "			ON		K1.W9999_IDNO		= ''' + @IDNO + ''' " & vbCrLf
                            SQL = SQL & "			AND		K1.W9999_seFactory	= MT.K7171_BasicSel" & vbCrLf
                            SQL = SQL & "			AND		K1.W9999_cdFactory	= MT.K7171_BasicCode " & vbCrLf
                            SQL = SQL & "'" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "SET @SQL2 =  @SQL2 + '" & vbCrLf
                            SQL = SQL & "	WHERE			MT.K7171_BasicSel		=	''300''" & vbCrLf
                            SQL = SQL & "			AND		MT.K7171_CheckUse		=	''1''" & vbCrLf
                            SQL = SQL & "			AND		MT.K7171_Check2			=	''1''" & vbCrLf
                            SQL = SQL & "'" & vbCrLf
                            SQL = SQL & "SET @SQL2 =  @SQL2 + '" & vbCrLf
                            SQL = SQL & "	GROUP BY		MT.K7171_BasicSel	" & vbCrLf
                            SQL = SQL & "		,			MT.K7171_BasicCode	" & vbCrLf
                            SQL = SQL & "		,			MT.K7171_BasicName	" & vbCrLf
                            SQL = SQL & "		,			MT.K7171_NameSimply	" & vbCrLf
                            SQL = SQL & "		,			K1.W9999_IDNO" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "	ORDER BY		MT.K7171_BasicName " & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "END " & vbCrLf
                            SQL = SQL & "'" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "EXEC (@SQL0 + @SQL1 + @SQL2)" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "PRINT @SQL0 " & vbCrLf
                            SQL = SQL & "PRINT @SQL1" & vbCrLf
                            SQL = SQL & "PRINT @SQL2" & vbCrLf

                            cmd = New SqlClient.SqlCommand
                            cmd.CommandText = SQL
                            cmd.CommandType = CommandType.Text
                            cmd.Connection = cn
                            Try
                                cmd.ExecuteNonQuery()
                            Catch ex As Exception
                            End Try

                        Case "PSM_USP_PFW99998_SEARCH_VS22_K7171"

                            SQL = "/* " & vbCrLf
                            SQL = SQL & "-- ============================================= " & vbCrLf
                            SQL = SQL & "-- Author:		Minh Duy " & vbCrLf
                            SQL = SQL & "-- Create date: 2019/05/08 " & vbCrLf
                            SQL = SQL & "-- Description:	Sheet Vs1 Display  " & vbCrLf
                            SQL = SQL & "-- ============================================= " & vbCrLf
                            SQL = SQL & "	PSM_USP_PFW99998_SEARCH_VS22_K7171 '00005827'" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "*/" & vbCrLf
                            SQL = SQL & "CREATE    PROC [dbo].[PSM_USP_PFW99998_SEARCH_VS22_K7171]" & vbCrLf
                            SQL = SQL & "	@IDNO CHAR(8)" & vbCrLf
                            SQL = SQL & "AS" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "DECLARE 	@SQL0   NVARCHAR(4000)" & vbCrLf
                            SQL = SQL & "DECLARE 	@SQL1   NVARCHAR(4000)" & vbCrLf
                            SQL = SQL & "DECLARE 	@SQL2   NVARCHAR(4000)" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "SET @SQL0 = ''" & vbCrLf
                            SQL = SQL & "SET @SQL1 = ''" & vbCrLf
                            SQL = SQL & "SET @SQL2 = ''" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "SET @SQL0 = @SQL0 + '" & vbCrLf
                            SQL = SQL & "BEGIN" & vbCrLf
                            SQL = SQL & "	SELECT		CASE WHEN ISNULL(K2.W9999_IDNO, '''') = '''' THEN ''0'' ELSE ''1'' END			AS	PCHK_PFK99998_VS24" & vbCrLf
                            SQL = SQL & "		  ,		MT.K7171_BasicSel																AS	Key_BasicSel_PFK99998_VS24" & vbCrLf
                            SQL = SQL & "		  ,		MT.K7171_BasicCode																AS	Key_BasicCode_PFK99998_VS24" & vbCrLf
                            SQL = SQL & "		  ,		MT.K7171_seBasicMaster															AS	Key_seBasicMaster_PFK99998_VS24" & vbCrLf
                            SQL = SQL & "		  ,		MT.K7171_cdBasicMaster															AS	Key_cdBasicMaster_PFK99998_VS24" & vbCrLf
                            SQL = SQL & "		  " & vbCrLf
                            SQL = SQL & "		  ,		K1.K7171_BasicName																AS	BasicMasterName_PFK99998_VS24" & vbCrLf
                            SQL = SQL & "		  ,		K1.K7171_NameSimply																AS	BasicMasterNameSimply_PFK99998_VS24" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "		  ,		MT.K7171_BasicName																AS	BasicName_PFK99998_VS24" & vbCrLf
                            SQL = SQL & "		  ,		MT.K7171_NameSimply																AS	NameSimply_PFK99998_VS24" & vbCrLf
                            SQL = SQL & "		  " & vbCrLf
                            SQL = SQL & "'" & vbCrLf
                            SQL = SQL & "SET @SQL1 = @SQL1 + '" & vbCrLf
                            SQL = SQL & "	FROM		PFK7171						MT WITH (NOLOCK)" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "	INNER	JOIN	PFK7171					K1 WITH (NOLOCK) " & vbCrLf
                            SQL = SQL & "			ON		K1.K7171_BasicSel		= MT.K7171_seBasicMaster" & vbCrLf
                            SQL = SQL & "			AND		K1.K7171_BasicCode		= MT.K7171_cdBasicMaster" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "	LEFT	JOIN	PFW9999					K2 WITH(NOLOCK)" & vbCrLf
                            SQL = SQL & "			ON		K2.W9999_IDNO			= ''' + @IDNO + ''' " & vbCrLf
                            SQL = SQL & "			AND		K2.W9999_seMainProcess	= MT.K7171_seBasicMaster" & vbCrLf
                            SQL = SQL & "			AND		K2.W9999_cdMainProcess	= MT.K7171_cdBasicMaster " & vbCrLf
                            SQL = SQL & "			AND		K2.W9999_seSubProcess	= MT.K7171_BasicSel" & vbCrLf
                            SQL = SQL & "			AND		K2.W9999_cdSubProcess	= MT.K7171_BasicCode" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "'" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "SET @SQL2 =  @SQL2 + '" & vbCrLf
                            SQL = SQL & "	WHERE			MT.K7171_BasicSel		=	''002''" & vbCrLf
                            SQL = SQL & "			AND		MT.K7171_CheckUse		=	''1''" & vbCrLf
                            SQL = SQL & "			AND		MT.K7171_Check2			=	''1''" & vbCrLf
                            SQL = SQL & "'" & vbCrLf
                            SQL = SQL & "SET @SQL2 =  @SQL2 + '" & vbCrLf
                            SQL = SQL & "	GROUP BY		MT.K7171_BasicSel												" & vbCrLf
                            SQL = SQL & "		,			MT.K7171_BasicCode												" & vbCrLf
                            SQL = SQL & "		,			MT.K7171_seBasicMaster											" & vbCrLf
                            SQL = SQL & "		,			MT.K7171_cdBasicMaster											" & vbCrLf
                            SQL = SQL & "		" & vbCrLf
                            SQL = SQL & "		,			K1.K7171_BasicName												" & vbCrLf
                            SQL = SQL & "		,			K1.K7171_NameSimply												" & vbCrLf
                            SQL = SQL & "		" & vbCrLf
                            SQL = SQL & "		,			MT.K7171_BasicName												" & vbCrLf
                            SQL = SQL & "		,			MT.K7171_NameSimply												" & vbCrLf
                            SQL = SQL & "		,			K2.W9999_IDNO" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "	ORDER BY		K1.K7171_BasicName										" & vbCrLf
                            SQL = SQL & "		  ,			MT.K7171_BasicName			" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "END " & vbCrLf
                            SQL = SQL & "'" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "EXEC (@SQL0 + @SQL1 + @SQL2)" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "PRINT @SQL0 " & vbCrLf
                            SQL = SQL & "PRINT @SQL1" & vbCrLf
                            SQL = SQL & "PRINT @SQL2" & vbCrLf

                            cmd = New SqlClient.SqlCommand
                            cmd.CommandText = SQL
                            cmd.CommandType = CommandType.Text
                            cmd.Connection = cn
                            Try
                                cmd.ExecuteNonQuery()
                            Catch ex As Exception
                            End Try

                        Case "PSM_USP_PFW99998_SEARCH_VS23_K7171"

                            SQL = "/* " & vbCrLf
                            SQL = SQL & "-- ============================================= " & vbCrLf
                            SQL = SQL & "-- Author:		Minh Duy " & vbCrLf
                            SQL = SQL & "-- Create date: 2019/05/08 " & vbCrLf
                            SQL = SQL & "-- Description:	Sheet Vs1 Display  " & vbCrLf
                            SQL = SQL & "-- ============================================= " & vbCrLf
                            SQL = SQL & "	USP_PFP99998_SEARCH_VS25_K7171 '00005827'" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "*/" & vbCrLf
                            SQL = SQL & "CREATE    PROC [dbo].[PSM_USP_PFW99998_SEARCH_VS23_K7171]" & vbCrLf
                            SQL = SQL & "	@IDNO CHAR(8)" & vbCrLf
                            SQL = SQL & "AS" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "DECLARE 	@SQL0   NVARCHAR(4000)" & vbCrLf
                            SQL = SQL & "DECLARE 	@SQL1   NVARCHAR(4000)" & vbCrLf
                            SQL = SQL & "DECLARE 	@SQL2   NVARCHAR(4000)" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "SET @SQL0 = ''" & vbCrLf
                            SQL = SQL & "SET @SQL1 = ''" & vbCrLf
                            SQL = SQL & "SET @SQL2 = ''" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "SET @SQL0 = @SQL0 + '" & vbCrLf
                            SQL = SQL & "BEGIN" & vbCrLf
                            SQL = SQL & "	SELECT		CASE WHEN ISNULL(K1.W9999_IDNO, '''') = '''' THEN ''0'' ELSE ''1'' END			AS	PCHK_PFK99998_VS25" & vbCrLf
                            SQL = SQL & "		  ,		MT.K7171_BasicSel																AS	Key_BasicSel_PFK99998_VS25" & vbCrLf
                            SQL = SQL & "		  ,		MT.K7171_BasicCode																AS	Key_BasicCode_PFK99998_VS25" & vbCrLf
                            SQL = SQL & "		  ,		MT.K7171_BasicName																AS	BasicName_PFK99998_VS25" & vbCrLf
                            SQL = SQL & "		  ,		MT.K7171_NameSimply																AS	NameSimply_PFK99998_VS25" & vbCrLf
                            SQL = SQL & "'" & vbCrLf
                            SQL = SQL & "SET @SQL1 = @SQL1 + '" & vbCrLf
                            SQL = SQL & "	FROM		PFK7171						MT WITH (NOLOCK)" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "	LEFT	JOIN	PFW9999				K1 WITH(NOLOCK)" & vbCrLf
                            SQL = SQL & "			ON		K1.W9999_IDNO		= ''' + @IDNO + ''' " & vbCrLf
                            SQL = SQL & "			AND		K1.W9999_seLineProd	= MT.K7171_BasicSel" & vbCrLf
                            SQL = SQL & "			AND		K1.W9999_cdLineProd	= MT.K7171_BasicCode " & vbCrLf
                            SQL = SQL & "'" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "SET @SQL2 =  @SQL2 + '" & vbCrLf
                            SQL = SQL & "	WHERE			MT.K7171_BasicSel		=	''301''" & vbCrLf
                            SQL = SQL & "			AND		MT.K7171_CheckUse		=	''1''" & vbCrLf
                            SQL = SQL & "			AND		MT.K7171_Check2			=	''1''" & vbCrLf
                            SQL = SQL & "'" & vbCrLf
                            SQL = SQL & "SET @SQL2 =  @SQL2 + '" & vbCrLf
                            SQL = SQL & "	GROUP BY		MT.K7171_BasicSel	" & vbCrLf
                            SQL = SQL & "		,			MT.K7171_BasicCode	" & vbCrLf
                            SQL = SQL & "		,			MT.K7171_BasicName	" & vbCrLf
                            SQL = SQL & "		,			MT.K7171_NameSimply	" & vbCrLf
                            SQL = SQL & "		,			K1.W9999_IDNO" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "	ORDER BY		MT.K7171_BasicName " & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "END " & vbCrLf
                            SQL = SQL & "'" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "EXEC (@SQL0 + @SQL1 + @SQL2)" & vbCrLf
                            SQL = SQL & "" & vbCrLf
                            SQL = SQL & "PRINT @SQL0 " & vbCrLf
                            SQL = SQL & "PRINT @SQL1" & vbCrLf
                            SQL = SQL & "PRINT @SQL2" & vbCrLf

                            cmd = New SqlClient.SqlCommand
                            cmd.CommandText = SQL
                            cmd.CommandType = CommandType.Text
                            cmd.Connection = cn
                            Try
                                cmd.ExecuteNonQuery()
                            Catch ex As Exception
                            End Try


                    End Select


                End If

            Next



        Catch ex As Exception

        End Try
    End Function

#End Region

#Region "DATA_SEARCH"

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        Try
            Dim RS01 As DataRow = Nothing

            Vs1.Enabled = False

            DATA_SEARCH_VS1 = False
            DS1 = PrcDS("PSM_USP_PFW99998_SEARCH_VS1", cn, txt_SANO.Data, _
                                                         "",
                                                        Const_Site, _
                                                        Const_Nationality, _
                                                        Const_Department, _
                                                        Const_OnePosition, _
                                                        Const_Position, _
                                                        Const_Incharge, _
                                                        "1", _
                                                        "1")
            If GetDsRc(DS1) = 0 Then
                Call SPR_PRO_NEW(Vs1, DS1, "PSM_USP_PFW99998_SEARCH_VS1", "Vs1")

                Vs1.Enabled = True
                Vs1.ActiveSheet.RowCount = 0
                Exit Function
            End If

            Call SPR_PRO_NEW(Vs1, DS1, "PSM_USP_PFW99998_SEARCH_VS1", "Vs1")

            Vs1.Enabled = True

            DATA_SEARCH_VS1 = True
        Catch ex As Exception
            MsgBoxP("ERROR IN DATA_SEARCH_01")
        End Try
    End Function
    Private Function DATA_SEARCH_VS1_LINE_DISP() As Boolean
        DATA_SEARCH_VS1_LINE_DISP = False

        Try
            Dim RS01 As DataRow = Nothing

            DATA_SEARCH_VS1_LINE_DISP = False

            DS1 = PrcDS("PSM_USP_PFW99998_SEARCH_VS1_LINE_DISPLAY", cn, getData(Vs1, getColumIndex(Vs1, "IDNO"), Vs1.ActiveSheet.ActiveRowIndex), _
                                                        Const_Site, _
                                                        Const_Nationality, _
                                                        Const_Department, _
                                                        Const_OnePosition, _
                                                        Const_Position, _
                                                        Const_Incharge, _
                                                        "1", _
                                                        "1")
            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If

            Call setData(Vs1, getColumIndex(Vs1, "ID"), Vs1.ActiveSheet.ActiveRowIndex, GetDsData(DS1, 0, "ID"))

            DATA_SEARCH_VS1_LINE_DISP = True
        Catch ex As Exception
            MsgBoxP("ERROR IN DATA_SEARCH_01")
        End Try
    End Function

    Private Function DATA_SEARCH_01() As Boolean
        DATA_SEARCH_01 = False

        Try
            DS1 = PrcDS("PSM_USP_PFW99998_SEARCH_VS1_LINE", cn, getData(Vs1, getColumIndex(Vs1, "IDNO"), Vs1.ActiveSheet.ActiveRowIndex), _
                                                            Const_Site, _
                                                            Const_Nationality, _
                                                            Const_Department, _
                                                            Const_OnePosition, _
                                                            Const_Position, _
                                                            Const_Incharge)
            If GetDsRc(DS1) = 0 Then
                Me.Dispose()
                isudCHK = False

                Exit Function
            End If


            lab_SITE.Data = GetDsData(DS1, 0, "NameSite")
            lab_SITE.Code = GetDsData(DS1, 0, "NameCode")
            lab_SITE.Tag = GetDsData(DS1, 0, "NameCode")

            txt_IDNO.Data = GetDsData(DS1, 0, "IDNO")
            txt_IDNO.Code = GetDsData(DS1, 0, "IDNO")
            txt_IDNO.Tag = GetDsData(DS1, 0, "IDNO")

            txt_Name.Data = GetDsData(DS1, 0, "Name")
            txt_NameDepartment.Data = GetDsData(DS1, 0, "NameDepartment")
           
            txt_ID01.Data = GetDsData(DS1, 0, "IDNAME")
            txt_PW01.Data = GetDsData(DS1, 0, "PW")

            txt_IDCard.Data = GetDsData(DS1, 0, "IDCard")

            DATA_SEARCH_01 = True
        Catch ex As Exception
            MsgBoxP("ERROR IN DATA_SEARCH_01")
        End Try

    End Function

    Private Function DATA_SEARCH_VS21_K7171(ByVal IDNO As String) As Boolean
        DATA_SEARCH_VS21_K7171 = False

        Try
            Me.Cursor = Cursors.WaitCursor
            TableLayoutPanel1.Enabled = False

            Vs21.Enabled = False
            Dim DS22 As New DataSet
            DS22 = PrcDS("PSM_USP_PFW99998_SEARCH_VS21_K7171", cn, IDNO)

            If GetDsRc(DS22) = 0 Then
                Vs21.ActiveSheet.RowCount = 0

                Vs21.Enabled = True
                Me.Cursor = Cursors.Default
                TableLayoutPanel1.Enabled = True

                Exit Function
            End If

            Call SPR_PRO_NEW(Vs21, DS22, "PSM_USP_PFW99998_SEARCH_VS21_K7171", "VS21")

            Vs21.Enabled = True

            Me.Cursor = Cursors.Default
            TableLayoutPanel1.Enabled = True

            DATA_SEARCH_VS21_K7171 = True
        Catch ex As Exception
            MsgBoxP("ERROR IN PSM_USP_PFW99998_SEARCH_VS21_K7171")
        Finally
            Vs21.Enabled = True
            Me.Cursor = Cursors.Default
            TableLayoutPanel1.Enabled = True
        End Try
    End Function

    Private Function DATA_SEARCH_VS22_K7171(ByVal IDNO As String) As Boolean
        DATA_SEARCH_VS22_K7171 = False

        Try
            Me.Cursor = Cursors.WaitCursor
            TableLayoutPanel1.Enabled = False

            Vs22.Enabled = False
            Dim DS24 As New DataSet
            DS24 = PrcDS("PSM_USP_PFW99998_SEARCH_VS22_K7171", cn, IDNO)

            If GetDsRc(DS24) = 0 Then
                Vs22.ActiveSheet.RowCount = 0

                Vs22.Enabled = True
                Me.Cursor = Cursors.Default
                TableLayoutPanel1.Enabled = True

                Exit Function
            End If

            Call SPR_PRO_NEW(Vs22, DS24, "PSM_USP_PFW99998_SEARCH_VS22_K7171", "VS22")

            Vs22.Enabled = True

            Me.Cursor = Cursors.Default
            TableLayoutPanel1.Enabled = True

            DATA_SEARCH_VS22_K7171 = True
        Catch ex As Exception
            MsgBoxP("ERROR IN PSM_USP_PFW99998_SEARCH_VS22_K7171")
        Finally
            Vs22.Enabled = True
            Me.Cursor = Cursors.Default
            TableLayoutPanel1.Enabled = True
        End Try
    End Function

    Private Function DATA_SEARCH_VS23_K7171(ByVal IDNO As String) As Boolean
        DATA_SEARCH_VS23_K7171 = False

        Try
            Me.Cursor = Cursors.WaitCursor
            TableLayoutPanel1.Enabled = False

            Vs23.Enabled = False
            Dim DS25 As New DataSet
            DS25 = PrcDS("PSM_USP_PFW99998_SEARCH_VS23_K7171", cn, IDNO)

            If GetDsRc(DS25) = 0 Then
                Vs23.ActiveSheet.RowCount = 0

                Vs23.Enabled = True
                Me.Cursor = Cursors.Default
                TableLayoutPanel1.Enabled = True

                Exit Function
            End If

            Call SPR_PRO_NEW(Vs23, DS25, "PSM_USP_PFW99998_SEARCH_VS23_K7171", "VS23")

            Vs23.Enabled = True

            Me.Cursor = Cursors.Default
            TableLayoutPanel1.Enabled = True

            DATA_SEARCH_VS23_K7171 = True
        Catch ex As Exception
            MsgBoxP("ERROR IN PSM_USP_PFW99998_SEARCH_VS23_K7171")
        Finally
            Vs23.Enabled = True
            Me.Cursor = Cursors.Default
            TableLayoutPanel1.Enabled = True
        End Try
    End Function


#End Region

#Region "DATA_FUNCTION"
    Private Function CHECK_USERID(ByVal IDNO As String, ByVal USERID As String) As Boolean
        CHECK_USERID = False
        Try
            Dim query As String = "SELECT COUNT(1) FROM PFK9992 MT WITH (NOLOCK) WHERE MT.K9992_ID = '" & USERID & "' AND MT.K9992_SANO <> '" & IDNO & "'"
            cmd = New SqlClient.SqlCommand
            cmd.CommandText = query
            cmd.CommandType = CommandType.Text
            cmd.Connection = cn

            Dim ds00 As New DataSet

            ds00 = PrcDS(cmd, cn)

            If ds00.Tables(0).Rows(0)(0).ToString = "0" Then
                CHECK_USERID = True
            End If

        Catch ex As Exception

        End Try
    End Function

    Private Function CHECK_IDCard(ByVal IDNO As String, ByVal IDCard As String) As Boolean
        CHECK_IDCard = False
        Try
            Dim query As String = "SELECT COUNT(1) FROM PFK7411 MT WITH (NOLOCK) WHERE MT.K7411_IDCard = '" & IDCard & "' AND  MT.K7411_IDNO <> '" & IDNO & "'"
            cmd = New SqlClient.SqlCommand
            cmd.CommandText = query
            cmd.CommandType = CommandType.Text
            cmd.Connection = cn

            Dim ds00 As New DataSet

            ds00 = PrcDS(cmd, cn)

            If ds00.Tables(0).Rows(0)(0).ToString = "0" Then
                CHECK_IDCard = True
            End If

        Catch ex As Exception

        End Try
    End Function

#End Region

#Region "Event"
    Private Sub cmdJOB_Click(sender As Object, e As EventArgs) Handles cmdJOB_dyw.Click
        Dim tmpPW_CHK As String
        Dim tmpPW_IN As String

        If READ_PFK7171(Const_PASSWORD, "009") = True Then
            If D7171.NameSimply = "" Then
                tmpPW_CHK = "PSM@."
            Else
                tmpPW_CHK = D7171.NameSimply
            End If

            Dim f As Form
            f = New FPassWord
            f.ShowDialog()
            tmpPW_IN = PASSWORDCHECK
            If tmpPW_IN <> tmpPW_CHK Then
                MsgBoxP("WRONG PASS!", vbInformation, "cmd_DEL_Click")
                Exit Sub
            End If
        End If

        Try
            ptc_1.SelectedIndex = 1

            Me.Enabled = False
            Me.Cursor = Cursors.WaitCursor

            Dim str As String = ""
            Dim j As Integer = "0"

            Vs1.ActiveSheet.RowCount = 0

            Vs21.ActiveSheet.RowCount = 0
            Vs22.ActiveSheet.RowCount = 0
            Vs23.ActiveSheet.RowCount = 0


        Catch ex As Exception
            MsgBoxP("ERROR IN cmdJOB_dyw")

        Finally
            Me.Enabled = True
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub cmd_Save_Click(sender As Object, e As EventArgs) Handles cmd_Save.Click
        Try
            Dim factoryi As Integer = 0
            Dim mainsubprocessi As Integer = 0
            Dim lineprodi As Integer = 0

            Dim DS As New DataSet

            If txt_IDNO.Text.Trim = "" Then Exit Sub

            If CHECK_IDCard(txt_IDNO.Data.Trim, txt_IDCard.Data.Trim) = False Then
                MsgBoxP("ID Card Duplicate!", vbInformation)
                txt_IDCard.Focus()
                Exit Sub
            End If

            cmd = New SqlClient.SqlCommand
            cmd.CommandText = "SELECT COUNT(1) FROM PFK7411 MT WITH (NOLOCK) WHERE MT.K7411_IDNO = '" & txt_IDNO.Data.Trim & "'"
            cmd.CommandType = CommandType.Text
            cmd.Connection = cn
            DS = New DataSet
            DS = PrcDS(cmd, cn)

            If DS.Tables(0).Rows(0)(0).ToString <> "0" Then
                cmd = New SqlClient.SqlCommand
                cmd.CommandText = "UPDATE PFK7411 SET K7411_IDCard = '" & txt_IDCard.Data.Trim & "' WHERE K7411_IDNO = '" & txt_IDNO.Data.Trim & "'"
                cmd.CommandType = CommandType.Text
                cmd.Connection = cn
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                End Try
            End If


            cmd = New SqlClient.SqlCommand
            cmd.CommandText = " SELECT COUNT(1) FROM PFW9999 MT WITH (NOLOCK) WHERE MT.W9999_IDNO = '" & txt_IDNO.Data & "'"
            cmd.CommandType = CommandType.Text
            cmd.Connection = cn

            DS = New DataSet
            DS = PrcDS(cmd, cn)

            If CInt(DS.Tables(0).Rows(0)(0).ToString) > 0 Then

                cmd = New SqlClient.SqlCommand
                cmd.CommandText = "DELETE FROM PFW9999 WHERE W9999_IDNO = '" & txt_IDNO.Data & "'"
                cmd.CommandType = CommandType.Text
                cmd.Connection = cn

                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                End Try
            End If

            Dim IDNO As String = txt_IDNO.Data
            Dim Seq As String
            Dim IDCard As String = txt_IDCard.Data
            Dim seFactory As String
            Dim cdFactory As String
            Dim seMainProcess As String
            Dim cdMainProcess As String
            Dim seSubProcess As String
            Dim cdSubProcess As String
            Dim seLineProd As String
            Dim cdLineProd As String
            Dim CheckUse As String = "1"

            Dim query_formal As String = "INSERT INTO PFW9999("
            query_formal = query_formal & " W9999_IDNO,"
            query_formal = query_formal & " W9999_Seq,"
            query_formal = query_formal & " W9999_IDCard,"
            query_formal = query_formal & " W9999_seFactory,"
            query_formal = query_formal & " W9999_cdFactory,"
            query_formal = query_formal & " W9999_seMainProcess,"
            query_formal = query_formal & " W9999_cdMainProcess,"
            query_formal = query_formal & " W9999_seSubProcess,"
            query_formal = query_formal & " W9999_cdSubProcess,"
            query_formal = query_formal & " W9999_seLineProd,"
            query_formal = query_formal & " W9999_cdLineProd,"
            query_formal = query_formal & " W9999_CheckUse)VALUES('{0}', '{1}', N'{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '1')"

            Dim test As String = getData(Vs21, getColumIndex(Vs21, "PCHK_PFK99998_VS22"), 0)

            For factoryi = 0 To Vs21.ActiveSheet.RowCount - 1 Step 1
                If CBool(getData(Vs21, getColumIndex(Vs21, "PCHK_PFK99998_VS22"), factoryi)) = True Then
                    seFactory = getData(Vs21, getColumIndex(Vs21, "Key_BasicSel_PFK99998_VS22"), factoryi)
                    cdFactory = getData(Vs21, getColumIndex(Vs21, "Key_BasicCode_PFK99998_VS22"), factoryi)

                    For mainsubprocessi = 0 To Vs22.ActiveSheet.RowCount - 1 Step 1
                        If CBool(getData(Vs22, getColumIndex(Vs22, "PCHK_PFK99998_VS24"), mainsubprocessi)) = True Then
                            seMainProcess = getData(Vs22, getColumIndex(Vs22, "Key_seBasicMaster_PFK99998_VS24"), mainsubprocessi)
                            cdMainProcess = getData(Vs22, getColumIndex(Vs22, "Key_cdBasicMaster_PFK99998_VS24"), mainsubprocessi)
                            seSubProcess = getData(Vs22, getColumIndex(Vs22, "Key_BasicSel_PFK99998_VS24"), mainsubprocessi)
                            cdSubProcess = getData(Vs22, getColumIndex(Vs22, "Key_BasicCode_PFK99998_VS24"), mainsubprocessi)

                            For lineprodi = 0 To Vs23.ActiveSheet.RowCount - 1 Step 1
                                If CBool(getData(Vs23, getColumIndex(Vs23, "PCHK_PFK99998_VS25"), lineprodi)) = True Then
                                    seLineProd = getData(Vs23, getColumIndex(Vs23, "Key_BasicSel_PFK99998_VS25"), lineprodi)
                                    cdLineProd = getData(Vs23, getColumIndex(Vs23, "Key_BasicCode_PFK99998_VS25"), lineprodi)

                                    If Seq Is Nothing Then
                                        Seq = "1"
                                    Else
                                        Seq = (CInt(Seq) + 1).ToString
                                    End If

                                    While Seq.Length < 5
                                        Seq = "0" & Seq
                                    End While

                                    Dim query As String = String.Format(query_formal, IDNO, Seq, IDCard, seFactory, cdFactory, seMainProcess, cdMainProcess, seSubProcess, cdSubProcess, seLineProd, cdLineProd)

                                    cmd = New SqlClient.SqlCommand
                                    cmd.CommandText = query
                                    cmd.CommandType = CommandType.Text
                                    cmd.Connection = cn

                                    Try
                                        cmd.ExecuteNonQuery()
                                    Catch ex As Exception
                                    End Try
                                End If

                            Next
                        End If

                    Next
                End If
            Next

            Call DATA_SEARCH_VS1_LINE_DISP()
            '============================================================================================

            MsgBoxP("Update Successfully!", vbInformation)

        Catch ex As Exception
            MsgBoxP("ERROR IN cmd_Save_Click")
        End Try
    End Sub

    Private Sub cmdDEL_Click(sender As Object, e As EventArgs) Handles cmd_del.Click
        Dim valSEL As String
        Dim str As String = MsgBoxP("Do you want to Delete?", vbYesNo)

        Try
            If txt_IDNO.Text.Trim = "" Then Exit Sub

            If str <> vbYes Then Exit Sub

            If TabControl1.SelectedIndex = 0 Then valSEL = "1"

            MsgBoxP("Delete Successfully!", vbInformation)

        Catch ex As Exception
            MsgBoxP("ERROR IN cmdDEL0_Click")
        End Try

    End Sub

    Private Sub txt_SANO_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_SANO.KeyDown
        If e.KeyValue = Keys.Enter Then
        End If
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        If DATA_SEARCH_VS1() = True Then Exit Sub
    End Sub

    Private Sub ptc_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ptc_1.SelectedIndexChanged
        If tabcheck = True Then ptc_1.SelectedIndex = 1 Else ptc_1.SelectedIndex = 0
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ID01.KeyPress, txt_PW01.KeyPress, txt_IDCard.KeyPress
        keypresserp(sender, e)
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If e.ColumnHeader = True Then
            setData(Vs1, getColumIndex(Vs1, "SCHK"), e.Row, "0", , True)
        End If
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If e.ColumnHeader = True Then
            If TypeOf (Vs1.ActiveSheet.Columns(e.Column).CellType) Is FarPoint.Win.Spread.CellType.CheckBoxCellType Then
                SPR_CheckAll(Vs1, e.Column)
            End If

            Exit Sub
        End If

        If getColumIndex(Vs1, "SCHK") <> Vs1.ActiveSheet.ActiveColumnIndex Then
            If DATA_SEARCH_01() = True Then

                Dim Key_IDNO As String = ""

                Key_IDNO = getData(Vs1, getColumIndex(Vs1, "Key_IDNO"), Vs1.ActiveSheet.ActiveRowIndex)

                Call DATA_SEARCH_VS21_K7171(Key_IDNO)
                Call DATA_SEARCH_VS22_K7171(Key_IDNO)
                Call DATA_SEARCH_VS23_K7171(Key_IDNO)

            Else
                Me.Form_ClearData()
            End If
        End If
    End Sub

    Private Sub Vs21_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs21.CellDoubleClick
        If e.ColumnHeader = True Then
            If TypeOf (Vs21.ActiveSheet.Columns(e.Column).CellType) Is FarPoint.Win.Spread.CellType.CheckBoxCellType Then
                SPR_CheckAll(Vs21, e.Column)
            End If
        End If
    End Sub
    Private Sub Vs22_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs22.CellDoubleClick
        If e.ColumnHeader = True Then
            If TypeOf (Vs22.ActiveSheet.Columns(e.Column).CellType) Is FarPoint.Win.Spread.CellType.CheckBoxCellType Then
                SPR_CheckAll(Vs22, e.Column)
            End If
        End If
    End Sub
    Private Sub Vs23_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs23.CellDoubleClick
        If e.ColumnHeader = True Then
            If TypeOf (Vs23.ActiveSheet.Columns(e.Column).CellType) Is FarPoint.Win.Spread.CellType.CheckBoxCellType Then
                SPR_CheckAll(Vs23, e.Column)
            End If
        End If
    End Sub

    Private Sub PFP85010_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width > 20 Then
            ptc_1.ItemSize = New Size((Me.Width - 20) / 2, 30)
        End If
    End Sub

#End Region
End Class