'=========================================================================================================================================================
'   TABLE : (PFK7411)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7411

Structure T7411_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	IDNO	 AS String	'			char(8)		*
Public 	DevelopmenetCode	 AS String	'			nvarchar(20)
Public 	IDCard	 AS String	'			nvarchar(100)
Public 	IDHRCode	 AS String	'			nvarchar(100)
Public 	UserID	 AS String	'			nvarchar(100)
Public 	PassWord	 AS String	'			nvarchar(100)
Public 	Name	 AS String	'			nvarchar(100)
Public 	ForeignName	 AS String	'			nvarchar(30)
Public 	seSite	 AS String	'			char(3)
Public 	cdSite	 AS String	'			char(3)
Public 	seMainProcess	 AS String	'			char(3)
Public 	cdMainProcess	 AS String	'			char(3)
Public 	seSubProcess	 AS String	'			char(3)
Public 	cdSubProcess	 AS String	'			char(3)
Public 	seNationality	 AS String	'			char(3)
Public 	cdNationality	 AS String	'			char(3)
Public 	seDepartment	 AS String	'			char(3)
Public 	cdDepartment	 AS String	'			char(3)
Public 	seOnePosition	 AS String	'			char(3)
Public 	cdOnePosition	 AS String	'			char(3)
Public 	sePosition	 AS String	'			char(3)
Public 	cdPosition	 AS String	'			char(3)
Public 	seInCharge	 AS String	'			char(3)
Public 	cdInCharge	 AS String	'			char(3)
Public 	seFactory	 AS String	'			char(3)
Public 	cdFactory	 AS String	'			char(3)
Public 	seLineProd	 AS String	'			char(3)
Public 	cdLineProd	 AS String	'			char(3)
Public 	Email	 AS String	'			nvarchar(100)
Public 	Mobile	 AS String	'			nvarchar(30)
Public 	Gender	 AS String	'			char(1)
Public 	SendEmail	 AS String	'			char(1)
Public 	SendSMS	 AS String	'			char(1)
Public 	SendFax	 AS String	'			char(1)
Public 	Locked	 AS String	'			char(1)
Public 	OpenCdt	 AS String	'			char(1)
Public 	OpenPrvDays	 AS String	'			char(1)
Public 	OpenRate	 AS String	'			char(1)
Public 	OpenSchedule	 AS String	'			char(1)
Public 	OpenAlert	 AS String	'			char(1)
Public 	OpenMessage	 AS String	'			char(1)
Public 	ScreenLock	 AS Double	'			decimal
Public 	IDCD	 AS String	'			nvarchar(30)
Public 	DGCD	 AS String	'			nvarchar(30)
Public 	GNID	 AS String	'			nvarchar(30)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	DateActive	 AS String	'			char(8)
Public 	DateDeactive	 AS String	'			char(8)
Public 	CheckActive	 AS String	'			char(1)
Public 	FirstChangePass	 AS String	'			char(1)
Public 	LastPass	 AS String	'			nvarchar(100)
Public 	LastPass1	 AS String	'			nvarchar(100)
Public 	LastPass2	 AS String	'			nvarchar(100)
Public 	FailLoginCnt	 AS Double	'			decimal
Public 	CheckNever	 AS String	'			char(1)
Public 	LastLogin	 AS String	'			char(8)
Public 	LastTime	 AS String	'			char(14)
Public 	CheckOption1	 AS String	'			char(1)
Public 	CheckOption2	 AS String	'			char(1)
Public 	CheckOption3	 AS String	'			char(1)
Public 	CheckOption4	 AS String	'			char(1)
Public 	CheckOption5	 AS String	'			char(1)
Public 	CheckUse	 AS String	'			char(1)
'=========================================================================================================================================================
End structure

Public D7411 As T7411_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7411(IDNO AS String) As Boolean
    READ_PFK7411 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7411 "
    SQL = SQL & " WHERE K7411_IDNO		 = '" & IDNO & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7411_CLEAR: GoTo SKIP_READ_PFK7411
                
    Call K7411_MOVE(rd)
    READ_PFK7411 = True

SKIP_READ_PFK7411:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7411",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7411(IDNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7411 "
    SQL = SQL & " WHERE K7411_IDNO		 = '" & IDNO & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7411",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7411(z7411 As T7411_AREA) As Boolean
    WRITE_PFK7411 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7411)
 
    SQL = " INSERT INTO PFK7411 "
    SQL = SQL & " ( "
    SQL = SQL & " K7411_IDNO," 
    SQL = SQL & " K7411_DevelopmenetCode," 
    SQL = SQL & " K7411_IDCard," 
    SQL = SQL & " K7411_IDHRCode," 
    SQL = SQL & " K7411_UserID," 
    SQL = SQL & " K7411_PassWord," 
    SQL = SQL & " K7411_Name," 
    SQL = SQL & " K7411_ForeignName," 
    SQL = SQL & " K7411_seSite," 
    SQL = SQL & " K7411_cdSite," 
    SQL = SQL & " K7411_seMainProcess," 
    SQL = SQL & " K7411_cdMainProcess," 
    SQL = SQL & " K7411_seSubProcess," 
    SQL = SQL & " K7411_cdSubProcess," 
    SQL = SQL & " K7411_seNationality," 
    SQL = SQL & " K7411_cdNationality," 
    SQL = SQL & " K7411_seDepartment," 
    SQL = SQL & " K7411_cdDepartment," 
    SQL = SQL & " K7411_seOnePosition," 
    SQL = SQL & " K7411_cdOnePosition," 
    SQL = SQL & " K7411_sePosition," 
    SQL = SQL & " K7411_cdPosition," 
    SQL = SQL & " K7411_seInCharge," 
    SQL = SQL & " K7411_cdInCharge," 
    SQL = SQL & " K7411_seFactory," 
    SQL = SQL & " K7411_cdFactory," 
    SQL = SQL & " K7411_seLineProd," 
    SQL = SQL & " K7411_cdLineProd," 
    SQL = SQL & " K7411_Email," 
    SQL = SQL & " K7411_Mobile," 
    SQL = SQL & " K7411_Gender," 
    SQL = SQL & " K7411_SendEmail," 
    SQL = SQL & " K7411_SendSMS," 
    SQL = SQL & " K7411_SendFax," 
    SQL = SQL & " K7411_Locked," 
    SQL = SQL & " K7411_OpenCdt," 
    SQL = SQL & " K7411_OpenPrvDays," 
    SQL = SQL & " K7411_OpenRate," 
    SQL = SQL & " K7411_OpenSchedule," 
    SQL = SQL & " K7411_OpenAlert," 
    SQL = SQL & " K7411_OpenMessage," 
    SQL = SQL & " K7411_ScreenLock," 
    SQL = SQL & " K7411_IDCD," 
    SQL = SQL & " K7411_DGCD," 
    SQL = SQL & " K7411_GNID," 
    SQL = SQL & " K7411_DateInsert," 
    SQL = SQL & " K7411_DateUpdate," 
    SQL = SQL & " K7411_InchargeInsert," 
    SQL = SQL & " K7411_InchargeUpdate," 
    SQL = SQL & " K7411_DateActive," 
    SQL = SQL & " K7411_DateDeactive," 
    SQL = SQL & " K7411_CheckActive," 
    SQL = SQL & " K7411_FirstChangePass," 
    SQL = SQL & " K7411_LastPass," 
    SQL = SQL & " K7411_LastPass1," 
    SQL = SQL & " K7411_LastPass2," 
    SQL = SQL & " K7411_FailLoginCnt," 
    SQL = SQL & " K7411_CheckNever," 
    SQL = SQL & " K7411_LastLogin," 
    SQL = SQL & " K7411_LastTime," 
    SQL = SQL & " K7411_CheckOption1," 
    SQL = SQL & " K7411_CheckOption2," 
    SQL = SQL & " K7411_CheckOption3," 
    SQL = SQL & " K7411_CheckOption4," 
    SQL = SQL & " K7411_CheckOption5," 
    SQL = SQL & " K7411_CheckUse " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7411.IDNO) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.DevelopmenetCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.IDCard) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.IDHRCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.UserID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.PassWord) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.Name) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.ForeignName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.seSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.cdSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.seMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.cdMainProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.cdSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.seNationality) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.cdNationality) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.seDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.cdDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.seOnePosition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.cdOnePosition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.sePosition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.cdPosition) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.seInCharge) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.cdInCharge) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.seLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.cdLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.Email) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.Mobile) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.Gender) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.SendEmail) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.SendSMS) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.SendFax) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.Locked) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.OpenCdt) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.OpenPrvDays) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.OpenRate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.OpenSchedule) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.OpenAlert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.OpenMessage) & "', "  
    SQL = SQL & "   " & FormatSQL(z7411.ScreenLock) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7411.IDCD) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.DGCD) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.GNID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.DateActive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.DateDeactive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.CheckActive) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.FirstChangePass) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.LastPass) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.LastPass1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.LastPass2) & "', "  
    SQL = SQL & "   " & FormatSQL(z7411.FailLoginCnt) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7411.CheckNever) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.LastLogin) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.LastTime) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.CheckOption1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.CheckOption2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.CheckOption3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.CheckOption4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.CheckOption5) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7411.CheckUse) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7411 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7411",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7411(z7411 As T7411_AREA) As Boolean
    REWRITE_PFK7411 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7411)
   
    SQL = " UPDATE PFK7411 SET "
    SQL = SQL & "    K7411_DevelopmenetCode      = N'" & FormatSQL(z7411.DevelopmenetCode) & "', " 
    SQL = SQL & "    K7411_IDCard      = N'" & FormatSQL(z7411.IDCard) & "', " 
    SQL = SQL & "    K7411_IDHRCode      = N'" & FormatSQL(z7411.IDHRCode) & "', " 
    SQL = SQL & "    K7411_UserID      = N'" & FormatSQL(z7411.UserID) & "', " 
    SQL = SQL & "    K7411_PassWord      = N'" & FormatSQL(z7411.PassWord) & "', " 
    SQL = SQL & "    K7411_Name      = N'" & FormatSQL(z7411.Name) & "', " 
    SQL = SQL & "    K7411_ForeignName      = N'" & FormatSQL(z7411.ForeignName) & "', " 
    SQL = SQL & "    K7411_seSite      = N'" & FormatSQL(z7411.seSite) & "', " 
    SQL = SQL & "    K7411_cdSite      = N'" & FormatSQL(z7411.cdSite) & "', " 
    SQL = SQL & "    K7411_seMainProcess      = N'" & FormatSQL(z7411.seMainProcess) & "', " 
    SQL = SQL & "    K7411_cdMainProcess      = N'" & FormatSQL(z7411.cdMainProcess) & "', " 
    SQL = SQL & "    K7411_seSubProcess      = N'" & FormatSQL(z7411.seSubProcess) & "', " 
    SQL = SQL & "    K7411_cdSubProcess      = N'" & FormatSQL(z7411.cdSubProcess) & "', " 
    SQL = SQL & "    K7411_seNationality      = N'" & FormatSQL(z7411.seNationality) & "', " 
    SQL = SQL & "    K7411_cdNationality      = N'" & FormatSQL(z7411.cdNationality) & "', " 
    SQL = SQL & "    K7411_seDepartment      = N'" & FormatSQL(z7411.seDepartment) & "', " 
    SQL = SQL & "    K7411_cdDepartment      = N'" & FormatSQL(z7411.cdDepartment) & "', " 
    SQL = SQL & "    K7411_seOnePosition      = N'" & FormatSQL(z7411.seOnePosition) & "', " 
    SQL = SQL & "    K7411_cdOnePosition      = N'" & FormatSQL(z7411.cdOnePosition) & "', " 
    SQL = SQL & "    K7411_sePosition      = N'" & FormatSQL(z7411.sePosition) & "', " 
    SQL = SQL & "    K7411_cdPosition      = N'" & FormatSQL(z7411.cdPosition) & "', " 
    SQL = SQL & "    K7411_seInCharge      = N'" & FormatSQL(z7411.seInCharge) & "', " 
    SQL = SQL & "    K7411_cdInCharge      = N'" & FormatSQL(z7411.cdInCharge) & "', " 
    SQL = SQL & "    K7411_seFactory      = N'" & FormatSQL(z7411.seFactory) & "', " 
    SQL = SQL & "    K7411_cdFactory      = N'" & FormatSQL(z7411.cdFactory) & "', " 
    SQL = SQL & "    K7411_seLineProd      = N'" & FormatSQL(z7411.seLineProd) & "', " 
    SQL = SQL & "    K7411_cdLineProd      = N'" & FormatSQL(z7411.cdLineProd) & "', " 
    SQL = SQL & "    K7411_Email      = N'" & FormatSQL(z7411.Email) & "', " 
    SQL = SQL & "    K7411_Mobile      = N'" & FormatSQL(z7411.Mobile) & "', " 
    SQL = SQL & "    K7411_Gender      = N'" & FormatSQL(z7411.Gender) & "', " 
    SQL = SQL & "    K7411_SendEmail      = N'" & FormatSQL(z7411.SendEmail) & "', " 
    SQL = SQL & "    K7411_SendSMS      = N'" & FormatSQL(z7411.SendSMS) & "', " 
    SQL = SQL & "    K7411_SendFax      = N'" & FormatSQL(z7411.SendFax) & "', " 
    SQL = SQL & "    K7411_Locked      = N'" & FormatSQL(z7411.Locked) & "', " 
    SQL = SQL & "    K7411_OpenCdt      = N'" & FormatSQL(z7411.OpenCdt) & "', " 
    SQL = SQL & "    K7411_OpenPrvDays      = N'" & FormatSQL(z7411.OpenPrvDays) & "', " 
    SQL = SQL & "    K7411_OpenRate      = N'" & FormatSQL(z7411.OpenRate) & "', " 
    SQL = SQL & "    K7411_OpenSchedule      = N'" & FormatSQL(z7411.OpenSchedule) & "', " 
    SQL = SQL & "    K7411_OpenAlert      = N'" & FormatSQL(z7411.OpenAlert) & "', " 
    SQL = SQL & "    K7411_OpenMessage      = N'" & FormatSQL(z7411.OpenMessage) & "', " 
    SQL = SQL & "    K7411_ScreenLock      =  " & FormatSQL(z7411.ScreenLock) & ", " 
    SQL = SQL & "    K7411_IDCD      = N'" & FormatSQL(z7411.IDCD) & "', " 
    SQL = SQL & "    K7411_DGCD      = N'" & FormatSQL(z7411.DGCD) & "', " 
    SQL = SQL & "    K7411_GNID      = N'" & FormatSQL(z7411.GNID) & "', " 
    SQL = SQL & "    K7411_DateInsert      = N'" & FormatSQL(z7411.DateInsert) & "', " 
    SQL = SQL & "    K7411_DateUpdate      = N'" & FormatSQL(z7411.DateUpdate) & "', " 
    SQL = SQL & "    K7411_InchargeInsert      = N'" & FormatSQL(z7411.InchargeInsert) & "', " 
    SQL = SQL & "    K7411_InchargeUpdate      = N'" & FormatSQL(z7411.InchargeUpdate) & "', " 
    SQL = SQL & "    K7411_DateActive      = N'" & FormatSQL(z7411.DateActive) & "', " 
    SQL = SQL & "    K7411_DateDeactive      = N'" & FormatSQL(z7411.DateDeactive) & "', " 
    SQL = SQL & "    K7411_CheckActive      = N'" & FormatSQL(z7411.CheckActive) & "', " 
    SQL = SQL & "    K7411_FirstChangePass      = N'" & FormatSQL(z7411.FirstChangePass) & "', " 
    SQL = SQL & "    K7411_LastPass      = N'" & FormatSQL(z7411.LastPass) & "', " 
    SQL = SQL & "    K7411_LastPass1      = N'" & FormatSQL(z7411.LastPass1) & "', " 
    SQL = SQL & "    K7411_LastPass2      = N'" & FormatSQL(z7411.LastPass2) & "', " 
    SQL = SQL & "    K7411_FailLoginCnt      =  " & FormatSQL(z7411.FailLoginCnt) & ", " 
    SQL = SQL & "    K7411_CheckNever      = N'" & FormatSQL(z7411.CheckNever) & "', " 
    SQL = SQL & "    K7411_LastLogin      = N'" & FormatSQL(z7411.LastLogin) & "', " 
    SQL = SQL & "    K7411_LastTime      = N'" & FormatSQL(z7411.LastTime) & "', " 
    SQL = SQL & "    K7411_CheckOption1      = N'" & FormatSQL(z7411.CheckOption1) & "', " 
    SQL = SQL & "    K7411_CheckOption2      = N'" & FormatSQL(z7411.CheckOption2) & "', " 
    SQL = SQL & "    K7411_CheckOption3      = N'" & FormatSQL(z7411.CheckOption3) & "', " 
    SQL = SQL & "    K7411_CheckOption4      = N'" & FormatSQL(z7411.CheckOption4) & "', " 
    SQL = SQL & "    K7411_CheckOption5      = N'" & FormatSQL(z7411.CheckOption5) & "', " 
    SQL = SQL & "    K7411_CheckUse      = N'" & FormatSQL(z7411.CheckUse) & "'  " 
    SQL = SQL & " WHERE K7411_IDNO		 = '" & z7411.IDNO & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7411 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7411",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7411(z7411 As T7411_AREA) As Boolean
    DELETE_PFK7411 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7411 "
    SQL = SQL & " WHERE K7411_IDNO		 = '" & z7411.IDNO & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7411 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7411",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7411_CLEAR()
Try
    
   D7411.IDNO = ""
   D7411.DevelopmenetCode = ""
   D7411.IDCard = ""
   D7411.IDHRCode = ""
   D7411.UserID = ""
   D7411.PassWord = ""
   D7411.Name = ""
   D7411.ForeignName = ""
   D7411.seSite = ""
   D7411.cdSite = ""
   D7411.seMainProcess = ""
   D7411.cdMainProcess = ""
   D7411.seSubProcess = ""
   D7411.cdSubProcess = ""
   D7411.seNationality = ""
   D7411.cdNationality = ""
   D7411.seDepartment = ""
   D7411.cdDepartment = ""
   D7411.seOnePosition = ""
   D7411.cdOnePosition = ""
   D7411.sePosition = ""
   D7411.cdPosition = ""
   D7411.seInCharge = ""
   D7411.cdInCharge = ""
   D7411.seFactory = ""
   D7411.cdFactory = ""
   D7411.seLineProd = ""
   D7411.cdLineProd = ""
   D7411.Email = ""
   D7411.Mobile = ""
   D7411.Gender = ""
   D7411.SendEmail = ""
   D7411.SendSMS = ""
   D7411.SendFax = ""
   D7411.Locked = ""
   D7411.OpenCdt = ""
   D7411.OpenPrvDays = ""
   D7411.OpenRate = ""
   D7411.OpenSchedule = ""
   D7411.OpenAlert = ""
   D7411.OpenMessage = ""
    D7411.ScreenLock = 0 
   D7411.IDCD = ""
   D7411.DGCD = ""
   D7411.GNID = ""
   D7411.DateInsert = ""
   D7411.DateUpdate = ""
   D7411.InchargeInsert = ""
   D7411.InchargeUpdate = ""
   D7411.DateActive = ""
   D7411.DateDeactive = ""
   D7411.CheckActive = ""
   D7411.FirstChangePass = ""
   D7411.LastPass = ""
   D7411.LastPass1 = ""
   D7411.LastPass2 = ""
    D7411.FailLoginCnt = 0 
   D7411.CheckNever = ""
   D7411.LastLogin = ""
   D7411.LastTime = ""
   D7411.CheckOption1 = ""
   D7411.CheckOption2 = ""
   D7411.CheckOption3 = ""
   D7411.CheckOption4 = ""
   D7411.CheckOption5 = ""
   D7411.CheckUse = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7411_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7411 As T7411_AREA)
Try
    
    x7411.IDNO = trim$(  x7411.IDNO)
    x7411.DevelopmenetCode = trim$(  x7411.DevelopmenetCode)
    x7411.IDCard = trim$(  x7411.IDCard)
    x7411.IDHRCode = trim$(  x7411.IDHRCode)
    x7411.UserID = trim$(  x7411.UserID)
    x7411.PassWord = trim$(  x7411.PassWord)
    x7411.Name = trim$(  x7411.Name)
    x7411.ForeignName = trim$(  x7411.ForeignName)
    x7411.seSite = trim$(  x7411.seSite)
    x7411.cdSite = trim$(  x7411.cdSite)
    x7411.seMainProcess = trim$(  x7411.seMainProcess)
    x7411.cdMainProcess = trim$(  x7411.cdMainProcess)
    x7411.seSubProcess = trim$(  x7411.seSubProcess)
    x7411.cdSubProcess = trim$(  x7411.cdSubProcess)
    x7411.seNationality = trim$(  x7411.seNationality)
    x7411.cdNationality = trim$(  x7411.cdNationality)
    x7411.seDepartment = trim$(  x7411.seDepartment)
    x7411.cdDepartment = trim$(  x7411.cdDepartment)
    x7411.seOnePosition = trim$(  x7411.seOnePosition)
    x7411.cdOnePosition = trim$(  x7411.cdOnePosition)
    x7411.sePosition = trim$(  x7411.sePosition)
    x7411.cdPosition = trim$(  x7411.cdPosition)
    x7411.seInCharge = trim$(  x7411.seInCharge)
    x7411.cdInCharge = trim$(  x7411.cdInCharge)
    x7411.seFactory = trim$(  x7411.seFactory)
    x7411.cdFactory = trim$(  x7411.cdFactory)
    x7411.seLineProd = trim$(  x7411.seLineProd)
    x7411.cdLineProd = trim$(  x7411.cdLineProd)
    x7411.Email = trim$(  x7411.Email)
    x7411.Mobile = trim$(  x7411.Mobile)
    x7411.Gender = trim$(  x7411.Gender)
    x7411.SendEmail = trim$(  x7411.SendEmail)
    x7411.SendSMS = trim$(  x7411.SendSMS)
    x7411.SendFax = trim$(  x7411.SendFax)
    x7411.Locked = trim$(  x7411.Locked)
    x7411.OpenCdt = trim$(  x7411.OpenCdt)
    x7411.OpenPrvDays = trim$(  x7411.OpenPrvDays)
    x7411.OpenRate = trim$(  x7411.OpenRate)
    x7411.OpenSchedule = trim$(  x7411.OpenSchedule)
    x7411.OpenAlert = trim$(  x7411.OpenAlert)
    x7411.OpenMessage = trim$(  x7411.OpenMessage)
    x7411.ScreenLock = trim$(  x7411.ScreenLock)
    x7411.IDCD = trim$(  x7411.IDCD)
    x7411.DGCD = trim$(  x7411.DGCD)
    x7411.GNID = trim$(  x7411.GNID)
    x7411.DateInsert = trim$(  x7411.DateInsert)
    x7411.DateUpdate = trim$(  x7411.DateUpdate)
    x7411.InchargeInsert = trim$(  x7411.InchargeInsert)
    x7411.InchargeUpdate = trim$(  x7411.InchargeUpdate)
    x7411.DateActive = trim$(  x7411.DateActive)
    x7411.DateDeactive = trim$(  x7411.DateDeactive)
    x7411.CheckActive = trim$(  x7411.CheckActive)
    x7411.FirstChangePass = trim$(  x7411.FirstChangePass)
    x7411.LastPass = trim$(  x7411.LastPass)
    x7411.LastPass1 = trim$(  x7411.LastPass1)
    x7411.LastPass2 = trim$(  x7411.LastPass2)
    x7411.FailLoginCnt = trim$(  x7411.FailLoginCnt)
    x7411.CheckNever = trim$(  x7411.CheckNever)
    x7411.LastLogin = trim$(  x7411.LastLogin)
    x7411.LastTime = trim$(  x7411.LastTime)
    x7411.CheckOption1 = trim$(  x7411.CheckOption1)
    x7411.CheckOption2 = trim$(  x7411.CheckOption2)
    x7411.CheckOption3 = trim$(  x7411.CheckOption3)
    x7411.CheckOption4 = trim$(  x7411.CheckOption4)
    x7411.CheckOption5 = trim$(  x7411.CheckOption5)
    x7411.CheckUse = trim$(  x7411.CheckUse)
     
    If trim$( x7411.IDNO ) = "" Then x7411.IDNO = Space(1) 
    If trim$( x7411.DevelopmenetCode ) = "" Then x7411.DevelopmenetCode = Space(1) 
    If trim$( x7411.IDCard ) = "" Then x7411.IDCard = Space(1) 
    If trim$( x7411.IDHRCode ) = "" Then x7411.IDHRCode = Space(1) 
    If trim$( x7411.UserID ) = "" Then x7411.UserID = Space(1) 
    If trim$( x7411.PassWord ) = "" Then x7411.PassWord = Space(1) 
    If trim$( x7411.Name ) = "" Then x7411.Name = Space(1) 
    If trim$( x7411.ForeignName ) = "" Then x7411.ForeignName = Space(1) 
    If trim$( x7411.seSite ) = "" Then x7411.seSite = Space(1) 
    If trim$( x7411.cdSite ) = "" Then x7411.cdSite = Space(1) 
    If trim$( x7411.seMainProcess ) = "" Then x7411.seMainProcess = Space(1) 
    If trim$( x7411.cdMainProcess ) = "" Then x7411.cdMainProcess = Space(1) 
    If trim$( x7411.seSubProcess ) = "" Then x7411.seSubProcess = Space(1) 
    If trim$( x7411.cdSubProcess ) = "" Then x7411.cdSubProcess = Space(1) 
    If trim$( x7411.seNationality ) = "" Then x7411.seNationality = Space(1) 
    If trim$( x7411.cdNationality ) = "" Then x7411.cdNationality = Space(1) 
    If trim$( x7411.seDepartment ) = "" Then x7411.seDepartment = Space(1) 
    If trim$( x7411.cdDepartment ) = "" Then x7411.cdDepartment = Space(1) 
    If trim$( x7411.seOnePosition ) = "" Then x7411.seOnePosition = Space(1) 
    If trim$( x7411.cdOnePosition ) = "" Then x7411.cdOnePosition = Space(1) 
    If trim$( x7411.sePosition ) = "" Then x7411.sePosition = Space(1) 
    If trim$( x7411.cdPosition ) = "" Then x7411.cdPosition = Space(1) 
    If trim$( x7411.seInCharge ) = "" Then x7411.seInCharge = Space(1) 
    If trim$( x7411.cdInCharge ) = "" Then x7411.cdInCharge = Space(1) 
    If trim$( x7411.seFactory ) = "" Then x7411.seFactory = Space(1) 
    If trim$( x7411.cdFactory ) = "" Then x7411.cdFactory = Space(1) 
    If trim$( x7411.seLineProd ) = "" Then x7411.seLineProd = Space(1) 
    If trim$( x7411.cdLineProd ) = "" Then x7411.cdLineProd = Space(1) 
    If trim$( x7411.Email ) = "" Then x7411.Email = Space(1) 
    If trim$( x7411.Mobile ) = "" Then x7411.Mobile = Space(1) 
    If trim$( x7411.Gender ) = "" Then x7411.Gender = Space(1) 
    If trim$( x7411.SendEmail ) = "" Then x7411.SendEmail = Space(1) 
    If trim$( x7411.SendSMS ) = "" Then x7411.SendSMS = Space(1) 
    If trim$( x7411.SendFax ) = "" Then x7411.SendFax = Space(1) 
    If trim$( x7411.Locked ) = "" Then x7411.Locked = Space(1) 
    If trim$( x7411.OpenCdt ) = "" Then x7411.OpenCdt = Space(1) 
    If trim$( x7411.OpenPrvDays ) = "" Then x7411.OpenPrvDays = Space(1) 
    If trim$( x7411.OpenRate ) = "" Then x7411.OpenRate = Space(1) 
    If trim$( x7411.OpenSchedule ) = "" Then x7411.OpenSchedule = Space(1) 
    If trim$( x7411.OpenAlert ) = "" Then x7411.OpenAlert = Space(1) 
    If trim$( x7411.OpenMessage ) = "" Then x7411.OpenMessage = Space(1) 
    If trim$( x7411.ScreenLock ) = "" Then x7411.ScreenLock = 0 
    If trim$( x7411.IDCD ) = "" Then x7411.IDCD = Space(1) 
    If trim$( x7411.DGCD ) = "" Then x7411.DGCD = Space(1) 
    If trim$( x7411.GNID ) = "" Then x7411.GNID = Space(1) 
    If trim$( x7411.DateInsert ) = "" Then x7411.DateInsert = Space(1) 
    If trim$( x7411.DateUpdate ) = "" Then x7411.DateUpdate = Space(1) 
    If trim$( x7411.InchargeInsert ) = "" Then x7411.InchargeInsert = Space(1) 
    If trim$( x7411.InchargeUpdate ) = "" Then x7411.InchargeUpdate = Space(1) 
    If trim$( x7411.DateActive ) = "" Then x7411.DateActive = Space(1) 
    If trim$( x7411.DateDeactive ) = "" Then x7411.DateDeactive = Space(1) 
    If trim$( x7411.CheckActive ) = "" Then x7411.CheckActive = Space(1) 
    If trim$( x7411.FirstChangePass ) = "" Then x7411.FirstChangePass = Space(1) 
    If trim$( x7411.LastPass ) = "" Then x7411.LastPass = Space(1) 
    If trim$( x7411.LastPass1 ) = "" Then x7411.LastPass1 = Space(1) 
    If trim$( x7411.LastPass2 ) = "" Then x7411.LastPass2 = Space(1) 
    If trim$( x7411.FailLoginCnt ) = "" Then x7411.FailLoginCnt = 0 
    If trim$( x7411.CheckNever ) = "" Then x7411.CheckNever = Space(1) 
    If trim$( x7411.LastLogin ) = "" Then x7411.LastLogin = Space(1) 
    If trim$( x7411.LastTime ) = "" Then x7411.LastTime = Space(1) 
    If trim$( x7411.CheckOption1 ) = "" Then x7411.CheckOption1 = Space(1) 
    If trim$( x7411.CheckOption2 ) = "" Then x7411.CheckOption2 = Space(1) 
    If trim$( x7411.CheckOption3 ) = "" Then x7411.CheckOption3 = Space(1) 
    If trim$( x7411.CheckOption4 ) = "" Then x7411.CheckOption4 = Space(1) 
    If trim$( x7411.CheckOption5 ) = "" Then x7411.CheckOption5 = Space(1) 
    If trim$( x7411.CheckUse ) = "" Then x7411.CheckUse = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7411_MOVE(rs7411 As SqlClient.SqlDataReader)
Try

    call D7411_CLEAR()   

    If IsdbNull(rs7411!K7411_IDNO) = False Then D7411.IDNO = Trim$(rs7411!K7411_IDNO)
    If IsdbNull(rs7411!K7411_DevelopmenetCode) = False Then D7411.DevelopmenetCode = Trim$(rs7411!K7411_DevelopmenetCode)
    If IsdbNull(rs7411!K7411_IDCard) = False Then D7411.IDCard = Trim$(rs7411!K7411_IDCard)
    If IsdbNull(rs7411!K7411_IDHRCode) = False Then D7411.IDHRCode = Trim$(rs7411!K7411_IDHRCode)
    If IsdbNull(rs7411!K7411_UserID) = False Then D7411.UserID = Trim$(rs7411!K7411_UserID)
    If IsdbNull(rs7411!K7411_PassWord) = False Then D7411.PassWord = Trim$(rs7411!K7411_PassWord)
    If IsdbNull(rs7411!K7411_Name) = False Then D7411.Name = Trim$(rs7411!K7411_Name)
    If IsdbNull(rs7411!K7411_ForeignName) = False Then D7411.ForeignName = Trim$(rs7411!K7411_ForeignName)
    If IsdbNull(rs7411!K7411_seSite) = False Then D7411.seSite = Trim$(rs7411!K7411_seSite)
    If IsdbNull(rs7411!K7411_cdSite) = False Then D7411.cdSite = Trim$(rs7411!K7411_cdSite)
    If IsdbNull(rs7411!K7411_seMainProcess) = False Then D7411.seMainProcess = Trim$(rs7411!K7411_seMainProcess)
    If IsdbNull(rs7411!K7411_cdMainProcess) = False Then D7411.cdMainProcess = Trim$(rs7411!K7411_cdMainProcess)
    If IsdbNull(rs7411!K7411_seSubProcess) = False Then D7411.seSubProcess = Trim$(rs7411!K7411_seSubProcess)
    If IsdbNull(rs7411!K7411_cdSubProcess) = False Then D7411.cdSubProcess = Trim$(rs7411!K7411_cdSubProcess)
    If IsdbNull(rs7411!K7411_seNationality) = False Then D7411.seNationality = Trim$(rs7411!K7411_seNationality)
    If IsdbNull(rs7411!K7411_cdNationality) = False Then D7411.cdNationality = Trim$(rs7411!K7411_cdNationality)
    If IsdbNull(rs7411!K7411_seDepartment) = False Then D7411.seDepartment = Trim$(rs7411!K7411_seDepartment)
    If IsdbNull(rs7411!K7411_cdDepartment) = False Then D7411.cdDepartment = Trim$(rs7411!K7411_cdDepartment)
    If IsdbNull(rs7411!K7411_seOnePosition) = False Then D7411.seOnePosition = Trim$(rs7411!K7411_seOnePosition)
    If IsdbNull(rs7411!K7411_cdOnePosition) = False Then D7411.cdOnePosition = Trim$(rs7411!K7411_cdOnePosition)
    If IsdbNull(rs7411!K7411_sePosition) = False Then D7411.sePosition = Trim$(rs7411!K7411_sePosition)
    If IsdbNull(rs7411!K7411_cdPosition) = False Then D7411.cdPosition = Trim$(rs7411!K7411_cdPosition)
    If IsdbNull(rs7411!K7411_seInCharge) = False Then D7411.seInCharge = Trim$(rs7411!K7411_seInCharge)
    If IsdbNull(rs7411!K7411_cdInCharge) = False Then D7411.cdInCharge = Trim$(rs7411!K7411_cdInCharge)
    If IsdbNull(rs7411!K7411_seFactory) = False Then D7411.seFactory = Trim$(rs7411!K7411_seFactory)
    If IsdbNull(rs7411!K7411_cdFactory) = False Then D7411.cdFactory = Trim$(rs7411!K7411_cdFactory)
    If IsdbNull(rs7411!K7411_seLineProd) = False Then D7411.seLineProd = Trim$(rs7411!K7411_seLineProd)
    If IsdbNull(rs7411!K7411_cdLineProd) = False Then D7411.cdLineProd = Trim$(rs7411!K7411_cdLineProd)
    If IsdbNull(rs7411!K7411_Email) = False Then D7411.Email = Trim$(rs7411!K7411_Email)
    If IsdbNull(rs7411!K7411_Mobile) = False Then D7411.Mobile = Trim$(rs7411!K7411_Mobile)
    If IsdbNull(rs7411!K7411_Gender) = False Then D7411.Gender = Trim$(rs7411!K7411_Gender)
    If IsdbNull(rs7411!K7411_SendEmail) = False Then D7411.SendEmail = Trim$(rs7411!K7411_SendEmail)
    If IsdbNull(rs7411!K7411_SendSMS) = False Then D7411.SendSMS = Trim$(rs7411!K7411_SendSMS)
    If IsdbNull(rs7411!K7411_SendFax) = False Then D7411.SendFax = Trim$(rs7411!K7411_SendFax)
    If IsdbNull(rs7411!K7411_Locked) = False Then D7411.Locked = Trim$(rs7411!K7411_Locked)
    If IsdbNull(rs7411!K7411_OpenCdt) = False Then D7411.OpenCdt = Trim$(rs7411!K7411_OpenCdt)
    If IsdbNull(rs7411!K7411_OpenPrvDays) = False Then D7411.OpenPrvDays = Trim$(rs7411!K7411_OpenPrvDays)
    If IsdbNull(rs7411!K7411_OpenRate) = False Then D7411.OpenRate = Trim$(rs7411!K7411_OpenRate)
    If IsdbNull(rs7411!K7411_OpenSchedule) = False Then D7411.OpenSchedule = Trim$(rs7411!K7411_OpenSchedule)
    If IsdbNull(rs7411!K7411_OpenAlert) = False Then D7411.OpenAlert = Trim$(rs7411!K7411_OpenAlert)
    If IsdbNull(rs7411!K7411_OpenMessage) = False Then D7411.OpenMessage = Trim$(rs7411!K7411_OpenMessage)
    If IsdbNull(rs7411!K7411_ScreenLock) = False Then D7411.ScreenLock = Trim$(rs7411!K7411_ScreenLock)
    If IsdbNull(rs7411!K7411_IDCD) = False Then D7411.IDCD = Trim$(rs7411!K7411_IDCD)
    If IsdbNull(rs7411!K7411_DGCD) = False Then D7411.DGCD = Trim$(rs7411!K7411_DGCD)
    If IsdbNull(rs7411!K7411_GNID) = False Then D7411.GNID = Trim$(rs7411!K7411_GNID)
    If IsdbNull(rs7411!K7411_DateInsert) = False Then D7411.DateInsert = Trim$(rs7411!K7411_DateInsert)
    If IsdbNull(rs7411!K7411_DateUpdate) = False Then D7411.DateUpdate = Trim$(rs7411!K7411_DateUpdate)
    If IsdbNull(rs7411!K7411_InchargeInsert) = False Then D7411.InchargeInsert = Trim$(rs7411!K7411_InchargeInsert)
    If IsdbNull(rs7411!K7411_InchargeUpdate) = False Then D7411.InchargeUpdate = Trim$(rs7411!K7411_InchargeUpdate)
    If IsdbNull(rs7411!K7411_DateActive) = False Then D7411.DateActive = Trim$(rs7411!K7411_DateActive)
    If IsdbNull(rs7411!K7411_DateDeactive) = False Then D7411.DateDeactive = Trim$(rs7411!K7411_DateDeactive)
    If IsdbNull(rs7411!K7411_CheckActive) = False Then D7411.CheckActive = Trim$(rs7411!K7411_CheckActive)
    If IsdbNull(rs7411!K7411_FirstChangePass) = False Then D7411.FirstChangePass = Trim$(rs7411!K7411_FirstChangePass)
    If IsdbNull(rs7411!K7411_LastPass) = False Then D7411.LastPass = Trim$(rs7411!K7411_LastPass)
    If IsdbNull(rs7411!K7411_LastPass1) = False Then D7411.LastPass1 = Trim$(rs7411!K7411_LastPass1)
    If IsdbNull(rs7411!K7411_LastPass2) = False Then D7411.LastPass2 = Trim$(rs7411!K7411_LastPass2)
    If IsdbNull(rs7411!K7411_FailLoginCnt) = False Then D7411.FailLoginCnt = Trim$(rs7411!K7411_FailLoginCnt)
    If IsdbNull(rs7411!K7411_CheckNever) = False Then D7411.CheckNever = Trim$(rs7411!K7411_CheckNever)
    If IsdbNull(rs7411!K7411_LastLogin) = False Then D7411.LastLogin = Trim$(rs7411!K7411_LastLogin)
    If IsdbNull(rs7411!K7411_LastTime) = False Then D7411.LastTime = Trim$(rs7411!K7411_LastTime)
    If IsdbNull(rs7411!K7411_CheckOption1) = False Then D7411.CheckOption1 = Trim$(rs7411!K7411_CheckOption1)
    If IsdbNull(rs7411!K7411_CheckOption2) = False Then D7411.CheckOption2 = Trim$(rs7411!K7411_CheckOption2)
    If IsdbNull(rs7411!K7411_CheckOption3) = False Then D7411.CheckOption3 = Trim$(rs7411!K7411_CheckOption3)
    If IsdbNull(rs7411!K7411_CheckOption4) = False Then D7411.CheckOption4 = Trim$(rs7411!K7411_CheckOption4)
    If IsdbNull(rs7411!K7411_CheckOption5) = False Then D7411.CheckOption5 = Trim$(rs7411!K7411_CheckOption5)
    If IsdbNull(rs7411!K7411_CheckUse) = False Then D7411.CheckUse = Trim$(rs7411!K7411_CheckUse)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7411_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7411_MOVE(rs7411 As DataRow)
Try

    call D7411_CLEAR()   

    If IsdbNull(rs7411!K7411_IDNO) = False Then D7411.IDNO = Trim$(rs7411!K7411_IDNO)
    If IsdbNull(rs7411!K7411_DevelopmenetCode) = False Then D7411.DevelopmenetCode = Trim$(rs7411!K7411_DevelopmenetCode)
    If IsdbNull(rs7411!K7411_IDCard) = False Then D7411.IDCard = Trim$(rs7411!K7411_IDCard)
    If IsdbNull(rs7411!K7411_IDHRCode) = False Then D7411.IDHRCode = Trim$(rs7411!K7411_IDHRCode)
    If IsdbNull(rs7411!K7411_UserID) = False Then D7411.UserID = Trim$(rs7411!K7411_UserID)
    If IsdbNull(rs7411!K7411_PassWord) = False Then D7411.PassWord = Trim$(rs7411!K7411_PassWord)
    If IsdbNull(rs7411!K7411_Name) = False Then D7411.Name = Trim$(rs7411!K7411_Name)
    If IsdbNull(rs7411!K7411_ForeignName) = False Then D7411.ForeignName = Trim$(rs7411!K7411_ForeignName)
    If IsdbNull(rs7411!K7411_seSite) = False Then D7411.seSite = Trim$(rs7411!K7411_seSite)
    If IsdbNull(rs7411!K7411_cdSite) = False Then D7411.cdSite = Trim$(rs7411!K7411_cdSite)
    If IsdbNull(rs7411!K7411_seMainProcess) = False Then D7411.seMainProcess = Trim$(rs7411!K7411_seMainProcess)
    If IsdbNull(rs7411!K7411_cdMainProcess) = False Then D7411.cdMainProcess = Trim$(rs7411!K7411_cdMainProcess)
    If IsdbNull(rs7411!K7411_seSubProcess) = False Then D7411.seSubProcess = Trim$(rs7411!K7411_seSubProcess)
    If IsdbNull(rs7411!K7411_cdSubProcess) = False Then D7411.cdSubProcess = Trim$(rs7411!K7411_cdSubProcess)
    If IsdbNull(rs7411!K7411_seNationality) = False Then D7411.seNationality = Trim$(rs7411!K7411_seNationality)
    If IsdbNull(rs7411!K7411_cdNationality) = False Then D7411.cdNationality = Trim$(rs7411!K7411_cdNationality)
    If IsdbNull(rs7411!K7411_seDepartment) = False Then D7411.seDepartment = Trim$(rs7411!K7411_seDepartment)
    If IsdbNull(rs7411!K7411_cdDepartment) = False Then D7411.cdDepartment = Trim$(rs7411!K7411_cdDepartment)
    If IsdbNull(rs7411!K7411_seOnePosition) = False Then D7411.seOnePosition = Trim$(rs7411!K7411_seOnePosition)
    If IsdbNull(rs7411!K7411_cdOnePosition) = False Then D7411.cdOnePosition = Trim$(rs7411!K7411_cdOnePosition)
    If IsdbNull(rs7411!K7411_sePosition) = False Then D7411.sePosition = Trim$(rs7411!K7411_sePosition)
    If IsdbNull(rs7411!K7411_cdPosition) = False Then D7411.cdPosition = Trim$(rs7411!K7411_cdPosition)
    If IsdbNull(rs7411!K7411_seInCharge) = False Then D7411.seInCharge = Trim$(rs7411!K7411_seInCharge)
    If IsdbNull(rs7411!K7411_cdInCharge) = False Then D7411.cdInCharge = Trim$(rs7411!K7411_cdInCharge)
    If IsdbNull(rs7411!K7411_seFactory) = False Then D7411.seFactory = Trim$(rs7411!K7411_seFactory)
    If IsdbNull(rs7411!K7411_cdFactory) = False Then D7411.cdFactory = Trim$(rs7411!K7411_cdFactory)
    If IsdbNull(rs7411!K7411_seLineProd) = False Then D7411.seLineProd = Trim$(rs7411!K7411_seLineProd)
    If IsdbNull(rs7411!K7411_cdLineProd) = False Then D7411.cdLineProd = Trim$(rs7411!K7411_cdLineProd)
    If IsdbNull(rs7411!K7411_Email) = False Then D7411.Email = Trim$(rs7411!K7411_Email)
    If IsdbNull(rs7411!K7411_Mobile) = False Then D7411.Mobile = Trim$(rs7411!K7411_Mobile)
    If IsdbNull(rs7411!K7411_Gender) = False Then D7411.Gender = Trim$(rs7411!K7411_Gender)
    If IsdbNull(rs7411!K7411_SendEmail) = False Then D7411.SendEmail = Trim$(rs7411!K7411_SendEmail)
    If IsdbNull(rs7411!K7411_SendSMS) = False Then D7411.SendSMS = Trim$(rs7411!K7411_SendSMS)
    If IsdbNull(rs7411!K7411_SendFax) = False Then D7411.SendFax = Trim$(rs7411!K7411_SendFax)
    If IsdbNull(rs7411!K7411_Locked) = False Then D7411.Locked = Trim$(rs7411!K7411_Locked)
    If IsdbNull(rs7411!K7411_OpenCdt) = False Then D7411.OpenCdt = Trim$(rs7411!K7411_OpenCdt)
    If IsdbNull(rs7411!K7411_OpenPrvDays) = False Then D7411.OpenPrvDays = Trim$(rs7411!K7411_OpenPrvDays)
    If IsdbNull(rs7411!K7411_OpenRate) = False Then D7411.OpenRate = Trim$(rs7411!K7411_OpenRate)
    If IsdbNull(rs7411!K7411_OpenSchedule) = False Then D7411.OpenSchedule = Trim$(rs7411!K7411_OpenSchedule)
    If IsdbNull(rs7411!K7411_OpenAlert) = False Then D7411.OpenAlert = Trim$(rs7411!K7411_OpenAlert)
    If IsdbNull(rs7411!K7411_OpenMessage) = False Then D7411.OpenMessage = Trim$(rs7411!K7411_OpenMessage)
    If IsdbNull(rs7411!K7411_ScreenLock) = False Then D7411.ScreenLock = Trim$(rs7411!K7411_ScreenLock)
    If IsdbNull(rs7411!K7411_IDCD) = False Then D7411.IDCD = Trim$(rs7411!K7411_IDCD)
    If IsdbNull(rs7411!K7411_DGCD) = False Then D7411.DGCD = Trim$(rs7411!K7411_DGCD)
    If IsdbNull(rs7411!K7411_GNID) = False Then D7411.GNID = Trim$(rs7411!K7411_GNID)
    If IsdbNull(rs7411!K7411_DateInsert) = False Then D7411.DateInsert = Trim$(rs7411!K7411_DateInsert)
    If IsdbNull(rs7411!K7411_DateUpdate) = False Then D7411.DateUpdate = Trim$(rs7411!K7411_DateUpdate)
    If IsdbNull(rs7411!K7411_InchargeInsert) = False Then D7411.InchargeInsert = Trim$(rs7411!K7411_InchargeInsert)
    If IsdbNull(rs7411!K7411_InchargeUpdate) = False Then D7411.InchargeUpdate = Trim$(rs7411!K7411_InchargeUpdate)
    If IsdbNull(rs7411!K7411_DateActive) = False Then D7411.DateActive = Trim$(rs7411!K7411_DateActive)
    If IsdbNull(rs7411!K7411_DateDeactive) = False Then D7411.DateDeactive = Trim$(rs7411!K7411_DateDeactive)
    If IsdbNull(rs7411!K7411_CheckActive) = False Then D7411.CheckActive = Trim$(rs7411!K7411_CheckActive)
    If IsdbNull(rs7411!K7411_FirstChangePass) = False Then D7411.FirstChangePass = Trim$(rs7411!K7411_FirstChangePass)
    If IsdbNull(rs7411!K7411_LastPass) = False Then D7411.LastPass = Trim$(rs7411!K7411_LastPass)
    If IsdbNull(rs7411!K7411_LastPass1) = False Then D7411.LastPass1 = Trim$(rs7411!K7411_LastPass1)
    If IsdbNull(rs7411!K7411_LastPass2) = False Then D7411.LastPass2 = Trim$(rs7411!K7411_LastPass2)
    If IsdbNull(rs7411!K7411_FailLoginCnt) = False Then D7411.FailLoginCnt = Trim$(rs7411!K7411_FailLoginCnt)
    If IsdbNull(rs7411!K7411_CheckNever) = False Then D7411.CheckNever = Trim$(rs7411!K7411_CheckNever)
    If IsdbNull(rs7411!K7411_LastLogin) = False Then D7411.LastLogin = Trim$(rs7411!K7411_LastLogin)
    If IsdbNull(rs7411!K7411_LastTime) = False Then D7411.LastTime = Trim$(rs7411!K7411_LastTime)
    If IsdbNull(rs7411!K7411_CheckOption1) = False Then D7411.CheckOption1 = Trim$(rs7411!K7411_CheckOption1)
    If IsdbNull(rs7411!K7411_CheckOption2) = False Then D7411.CheckOption2 = Trim$(rs7411!K7411_CheckOption2)
    If IsdbNull(rs7411!K7411_CheckOption3) = False Then D7411.CheckOption3 = Trim$(rs7411!K7411_CheckOption3)
    If IsdbNull(rs7411!K7411_CheckOption4) = False Then D7411.CheckOption4 = Trim$(rs7411!K7411_CheckOption4)
    If IsdbNull(rs7411!K7411_CheckOption5) = False Then D7411.CheckOption5 = Trim$(rs7411!K7411_CheckOption5)
    If IsdbNull(rs7411!K7411_CheckUse) = False Then D7411.CheckUse = Trim$(rs7411!K7411_CheckUse)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7411_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7411_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7411 As T7411_AREA, IDNO AS String) as Boolean

K7411_MOVE = False

Try
    If READ_PFK7411(IDNO) = True Then
                z7411 = D7411
		K7411_MOVE = True
		else
	z7411 = nothing
     End If

     If  getColumIndex(spr,"IDNO") > -1 then z7411.IDNO = getDataM(spr, getColumIndex(spr,"IDNO"), xRow)
     If  getColumIndex(spr,"DevelopmenetCode") > -1 then z7411.DevelopmenetCode = getDataM(spr, getColumIndex(spr,"DevelopmenetCode"), xRow)
     If  getColumIndex(spr,"IDCard") > -1 then z7411.IDCard = getDataM(spr, getColumIndex(spr,"IDCard"), xRow)
     If  getColumIndex(spr,"IDHRCode") > -1 then z7411.IDHRCode = getDataM(spr, getColumIndex(spr,"IDHRCode"), xRow)
     If  getColumIndex(spr,"UserID") > -1 then z7411.UserID = getDataM(spr, getColumIndex(spr,"UserID"), xRow)
     If  getColumIndex(spr,"PassWord") > -1 then z7411.PassWord = getDataM(spr, getColumIndex(spr,"PassWord"), xRow)
     If  getColumIndex(spr,"Name") > -1 then z7411.Name = getDataM(spr, getColumIndex(spr,"Name"), xRow)
     If  getColumIndex(spr,"ForeignName") > -1 then z7411.ForeignName = getDataM(spr, getColumIndex(spr,"ForeignName"), xRow)
     If  getColumIndex(spr,"seSite") > -1 then z7411.seSite = getDataM(spr, getColumIndex(spr,"seSite"), xRow)
     If  getColumIndex(spr,"cdSite") > -1 then z7411.cdSite = getDataM(spr, getColumIndex(spr,"cdSite"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z7411.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z7411.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z7411.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z7411.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"seNationality") > -1 then z7411.seNationality = getDataM(spr, getColumIndex(spr,"seNationality"), xRow)
     If  getColumIndex(spr,"cdNationality") > -1 then z7411.cdNationality = getDataM(spr, getColumIndex(spr,"cdNationality"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z7411.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z7411.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"seOnePosition") > -1 then z7411.seOnePosition = getDataM(spr, getColumIndex(spr,"seOnePosition"), xRow)
     If  getColumIndex(spr,"cdOnePosition") > -1 then z7411.cdOnePosition = getDataM(spr, getColumIndex(spr,"cdOnePosition"), xRow)
     If  getColumIndex(spr,"sePosition") > -1 then z7411.sePosition = getDataM(spr, getColumIndex(spr,"sePosition"), xRow)
     If  getColumIndex(spr,"cdPosition") > -1 then z7411.cdPosition = getDataM(spr, getColumIndex(spr,"cdPosition"), xRow)
     If  getColumIndex(spr,"seInCharge") > -1 then z7411.seInCharge = getDataM(spr, getColumIndex(spr,"seInCharge"), xRow)
     If  getColumIndex(spr,"cdInCharge") > -1 then z7411.cdInCharge = getDataM(spr, getColumIndex(spr,"cdInCharge"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z7411.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z7411.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z7411.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z7411.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"Email") > -1 then z7411.Email = getDataM(spr, getColumIndex(spr,"Email"), xRow)
     If  getColumIndex(spr,"Mobile") > -1 then z7411.Mobile = getDataM(spr, getColumIndex(spr,"Mobile"), xRow)
     If  getColumIndex(spr,"Gender") > -1 then z7411.Gender = getDataM(spr, getColumIndex(spr,"Gender"), xRow)
     If  getColumIndex(spr,"SendEmail") > -1 then z7411.SendEmail = getDataM(spr, getColumIndex(spr,"SendEmail"), xRow)
     If  getColumIndex(spr,"SendSMS") > -1 then z7411.SendSMS = getDataM(spr, getColumIndex(spr,"SendSMS"), xRow)
     If  getColumIndex(spr,"SendFax") > -1 then z7411.SendFax = getDataM(spr, getColumIndex(spr,"SendFax"), xRow)
     If  getColumIndex(spr,"Locked") > -1 then z7411.Locked = getDataM(spr, getColumIndex(spr,"Locked"), xRow)
     If  getColumIndex(spr,"OpenCdt") > -1 then z7411.OpenCdt = getDataM(spr, getColumIndex(spr,"OpenCdt"), xRow)
     If  getColumIndex(spr,"OpenPrvDays") > -1 then z7411.OpenPrvDays = getDataM(spr, getColumIndex(spr,"OpenPrvDays"), xRow)
     If  getColumIndex(spr,"OpenRate") > -1 then z7411.OpenRate = getDataM(spr, getColumIndex(spr,"OpenRate"), xRow)
     If  getColumIndex(spr,"OpenSchedule") > -1 then z7411.OpenSchedule = getDataM(spr, getColumIndex(spr,"OpenSchedule"), xRow)
     If  getColumIndex(spr,"OpenAlert") > -1 then z7411.OpenAlert = getDataM(spr, getColumIndex(spr,"OpenAlert"), xRow)
     If  getColumIndex(spr,"OpenMessage") > -1 then z7411.OpenMessage = getDataM(spr, getColumIndex(spr,"OpenMessage"), xRow)
     If  getColumIndex(spr,"ScreenLock") > -1 then z7411.ScreenLock = getDataM(spr, getColumIndex(spr,"ScreenLock"), xRow)
     If  getColumIndex(spr,"IDCD") > -1 then z7411.IDCD = getDataM(spr, getColumIndex(spr,"IDCD"), xRow)
     If  getColumIndex(spr,"DGCD") > -1 then z7411.DGCD = getDataM(spr, getColumIndex(spr,"DGCD"), xRow)
     If  getColumIndex(spr,"GNID") > -1 then z7411.GNID = getDataM(spr, getColumIndex(spr,"GNID"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7411.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7411.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7411.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7411.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"DateActive") > -1 then z7411.DateActive = getDataM(spr, getColumIndex(spr,"DateActive"), xRow)
     If  getColumIndex(spr,"DateDeactive") > -1 then z7411.DateDeactive = getDataM(spr, getColumIndex(spr,"DateDeactive"), xRow)
     If  getColumIndex(spr,"CheckActive") > -1 then z7411.CheckActive = getDataM(spr, getColumIndex(spr,"CheckActive"), xRow)
     If  getColumIndex(spr,"FirstChangePass") > -1 then z7411.FirstChangePass = getDataM(spr, getColumIndex(spr,"FirstChangePass"), xRow)
     If  getColumIndex(spr,"LastPass") > -1 then z7411.LastPass = getDataM(spr, getColumIndex(spr,"LastPass"), xRow)
     If  getColumIndex(spr,"LastPass1") > -1 then z7411.LastPass1 = getDataM(spr, getColumIndex(spr,"LastPass1"), xRow)
     If  getColumIndex(spr,"LastPass2") > -1 then z7411.LastPass2 = getDataM(spr, getColumIndex(spr,"LastPass2"), xRow)
     If  getColumIndex(spr,"FailLoginCnt") > -1 then z7411.FailLoginCnt = getDataM(spr, getColumIndex(spr,"FailLoginCnt"), xRow)
     If  getColumIndex(spr,"CheckNever") > -1 then z7411.CheckNever = getDataM(spr, getColumIndex(spr,"CheckNever"), xRow)
     If  getColumIndex(spr,"LastLogin") > -1 then z7411.LastLogin = getDataM(spr, getColumIndex(spr,"LastLogin"), xRow)
     If  getColumIndex(spr,"LastTime") > -1 then z7411.LastTime = getDataM(spr, getColumIndex(spr,"LastTime"), xRow)
     If  getColumIndex(spr,"CheckOption1") > -1 then z7411.CheckOption1 = getDataM(spr, getColumIndex(spr,"CheckOption1"), xRow)
     If  getColumIndex(spr,"CheckOption2") > -1 then z7411.CheckOption2 = getDataM(spr, getColumIndex(spr,"CheckOption2"), xRow)
     If  getColumIndex(spr,"CheckOption3") > -1 then z7411.CheckOption3 = getDataM(spr, getColumIndex(spr,"CheckOption3"), xRow)
     If  getColumIndex(spr,"CheckOption4") > -1 then z7411.CheckOption4 = getDataM(spr, getColumIndex(spr,"CheckOption4"), xRow)
     If  getColumIndex(spr,"CheckOption5") > -1 then z7411.CheckOption5 = getDataM(spr, getColumIndex(spr,"CheckOption5"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7411.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7411_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7411_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7411 As T7411_AREA,CheckClear as Boolean,IDNO AS String) as Boolean

K7411_MOVE = False

Try
    If READ_PFK7411(IDNO) = True Then
                z7411 = D7411
		K7411_MOVE = True
		else
	If CheckClear  = True then z7411 = nothing
     End If

     If  getColumIndex(spr,"IDNO") > -1 then z7411.IDNO = getDataM(spr, getColumIndex(spr,"IDNO"), xRow)
     If  getColumIndex(spr,"DevelopmenetCode") > -1 then z7411.DevelopmenetCode = getDataM(spr, getColumIndex(spr,"DevelopmenetCode"), xRow)
     If  getColumIndex(spr,"IDCard") > -1 then z7411.IDCard = getDataM(spr, getColumIndex(spr,"IDCard"), xRow)
     If  getColumIndex(spr,"IDHRCode") > -1 then z7411.IDHRCode = getDataM(spr, getColumIndex(spr,"IDHRCode"), xRow)
     If  getColumIndex(spr,"UserID") > -1 then z7411.UserID = getDataM(spr, getColumIndex(spr,"UserID"), xRow)
     If  getColumIndex(spr,"PassWord") > -1 then z7411.PassWord = getDataM(spr, getColumIndex(spr,"PassWord"), xRow)
     If  getColumIndex(spr,"Name") > -1 then z7411.Name = getDataM(spr, getColumIndex(spr,"Name"), xRow)
     If  getColumIndex(spr,"ForeignName") > -1 then z7411.ForeignName = getDataM(spr, getColumIndex(spr,"ForeignName"), xRow)
     If  getColumIndex(spr,"seSite") > -1 then z7411.seSite = getDataM(spr, getColumIndex(spr,"seSite"), xRow)
     If  getColumIndex(spr,"cdSite") > -1 then z7411.cdSite = getDataM(spr, getColumIndex(spr,"cdSite"), xRow)
     If  getColumIndex(spr,"seMainProcess") > -1 then z7411.seMainProcess = getDataM(spr, getColumIndex(spr,"seMainProcess"), xRow)
     If  getColumIndex(spr,"cdMainProcess") > -1 then z7411.cdMainProcess = getDataM(spr, getColumIndex(spr,"cdMainProcess"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z7411.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z7411.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"seNationality") > -1 then z7411.seNationality = getDataM(spr, getColumIndex(spr,"seNationality"), xRow)
     If  getColumIndex(spr,"cdNationality") > -1 then z7411.cdNationality = getDataM(spr, getColumIndex(spr,"cdNationality"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z7411.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z7411.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"seOnePosition") > -1 then z7411.seOnePosition = getDataM(spr, getColumIndex(spr,"seOnePosition"), xRow)
     If  getColumIndex(spr,"cdOnePosition") > -1 then z7411.cdOnePosition = getDataM(spr, getColumIndex(spr,"cdOnePosition"), xRow)
     If  getColumIndex(spr,"sePosition") > -1 then z7411.sePosition = getDataM(spr, getColumIndex(spr,"sePosition"), xRow)
     If  getColumIndex(spr,"cdPosition") > -1 then z7411.cdPosition = getDataM(spr, getColumIndex(spr,"cdPosition"), xRow)
     If  getColumIndex(spr,"seInCharge") > -1 then z7411.seInCharge = getDataM(spr, getColumIndex(spr,"seInCharge"), xRow)
     If  getColumIndex(spr,"cdInCharge") > -1 then z7411.cdInCharge = getDataM(spr, getColumIndex(spr,"cdInCharge"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z7411.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z7411.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"seLineProd") > -1 then z7411.seLineProd = getDataM(spr, getColumIndex(spr,"seLineProd"), xRow)
     If  getColumIndex(spr,"cdLineProd") > -1 then z7411.cdLineProd = getDataM(spr, getColumIndex(spr,"cdLineProd"), xRow)
     If  getColumIndex(spr,"Email") > -1 then z7411.Email = getDataM(spr, getColumIndex(spr,"Email"), xRow)
     If  getColumIndex(spr,"Mobile") > -1 then z7411.Mobile = getDataM(spr, getColumIndex(spr,"Mobile"), xRow)
     If  getColumIndex(spr,"Gender") > -1 then z7411.Gender = getDataM(spr, getColumIndex(spr,"Gender"), xRow)
     If  getColumIndex(spr,"SendEmail") > -1 then z7411.SendEmail = getDataM(spr, getColumIndex(spr,"SendEmail"), xRow)
     If  getColumIndex(spr,"SendSMS") > -1 then z7411.SendSMS = getDataM(spr, getColumIndex(spr,"SendSMS"), xRow)
     If  getColumIndex(spr,"SendFax") > -1 then z7411.SendFax = getDataM(spr, getColumIndex(spr,"SendFax"), xRow)
     If  getColumIndex(spr,"Locked") > -1 then z7411.Locked = getDataM(spr, getColumIndex(spr,"Locked"), xRow)
     If  getColumIndex(spr,"OpenCdt") > -1 then z7411.OpenCdt = getDataM(spr, getColumIndex(spr,"OpenCdt"), xRow)
     If  getColumIndex(spr,"OpenPrvDays") > -1 then z7411.OpenPrvDays = getDataM(spr, getColumIndex(spr,"OpenPrvDays"), xRow)
     If  getColumIndex(spr,"OpenRate") > -1 then z7411.OpenRate = getDataM(spr, getColumIndex(spr,"OpenRate"), xRow)
     If  getColumIndex(spr,"OpenSchedule") > -1 then z7411.OpenSchedule = getDataM(spr, getColumIndex(spr,"OpenSchedule"), xRow)
     If  getColumIndex(spr,"OpenAlert") > -1 then z7411.OpenAlert = getDataM(spr, getColumIndex(spr,"OpenAlert"), xRow)
     If  getColumIndex(spr,"OpenMessage") > -1 then z7411.OpenMessage = getDataM(spr, getColumIndex(spr,"OpenMessage"), xRow)
     If  getColumIndex(spr,"ScreenLock") > -1 then z7411.ScreenLock = getDataM(spr, getColumIndex(spr,"ScreenLock"), xRow)
     If  getColumIndex(spr,"IDCD") > -1 then z7411.IDCD = getDataM(spr, getColumIndex(spr,"IDCD"), xRow)
     If  getColumIndex(spr,"DGCD") > -1 then z7411.DGCD = getDataM(spr, getColumIndex(spr,"DGCD"), xRow)
     If  getColumIndex(spr,"GNID") > -1 then z7411.GNID = getDataM(spr, getColumIndex(spr,"GNID"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7411.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7411.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7411.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7411.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"DateActive") > -1 then z7411.DateActive = getDataM(spr, getColumIndex(spr,"DateActive"), xRow)
     If  getColumIndex(spr,"DateDeactive") > -1 then z7411.DateDeactive = getDataM(spr, getColumIndex(spr,"DateDeactive"), xRow)
     If  getColumIndex(spr,"CheckActive") > -1 then z7411.CheckActive = getDataM(spr, getColumIndex(spr,"CheckActive"), xRow)
     If  getColumIndex(spr,"FirstChangePass") > -1 then z7411.FirstChangePass = getDataM(spr, getColumIndex(spr,"FirstChangePass"), xRow)
     If  getColumIndex(spr,"LastPass") > -1 then z7411.LastPass = getDataM(spr, getColumIndex(spr,"LastPass"), xRow)
     If  getColumIndex(spr,"LastPass1") > -1 then z7411.LastPass1 = getDataM(spr, getColumIndex(spr,"LastPass1"), xRow)
     If  getColumIndex(spr,"LastPass2") > -1 then z7411.LastPass2 = getDataM(spr, getColumIndex(spr,"LastPass2"), xRow)
     If  getColumIndex(spr,"FailLoginCnt") > -1 then z7411.FailLoginCnt = getDataM(spr, getColumIndex(spr,"FailLoginCnt"), xRow)
     If  getColumIndex(spr,"CheckNever") > -1 then z7411.CheckNever = getDataM(spr, getColumIndex(spr,"CheckNever"), xRow)
     If  getColumIndex(spr,"LastLogin") > -1 then z7411.LastLogin = getDataM(spr, getColumIndex(spr,"LastLogin"), xRow)
     If  getColumIndex(spr,"LastTime") > -1 then z7411.LastTime = getDataM(spr, getColumIndex(spr,"LastTime"), xRow)
     If  getColumIndex(spr,"CheckOption1") > -1 then z7411.CheckOption1 = getDataM(spr, getColumIndex(spr,"CheckOption1"), xRow)
     If  getColumIndex(spr,"CheckOption2") > -1 then z7411.CheckOption2 = getDataM(spr, getColumIndex(spr,"CheckOption2"), xRow)
     If  getColumIndex(spr,"CheckOption3") > -1 then z7411.CheckOption3 = getDataM(spr, getColumIndex(spr,"CheckOption3"), xRow)
     If  getColumIndex(spr,"CheckOption4") > -1 then z7411.CheckOption4 = getDataM(spr, getColumIndex(spr,"CheckOption4"), xRow)
     If  getColumIndex(spr,"CheckOption5") > -1 then z7411.CheckOption5 = getDataM(spr, getColumIndex(spr,"CheckOption5"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7411.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7411_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7411_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7411 As T7411_AREA, Job as String, IDNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7411_MOVE = False

Try
    If READ_PFK7411(IDNO) = True Then
                z7411 = D7411
		K7411_MOVE = True
		else
	z7411 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7411")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "IDNO":z7411.IDNO = Children(i).Code
   Case "DEVELOPMENETCODE":z7411.DevelopmenetCode = Children(i).Code
   Case "IDCARD":z7411.IDCard = Children(i).Code
   Case "IDHRCODE":z7411.IDHRCode = Children(i).Code
   Case "USERID":z7411.UserID = Children(i).Code
   Case "PASSWORD":z7411.PassWord = Children(i).Code
   Case "NAME":z7411.Name = Children(i).Code
   Case "FOREIGNNAME":z7411.ForeignName = Children(i).Code
   Case "SESITE":z7411.seSite = Children(i).Code
   Case "CDSITE":z7411.cdSite = Children(i).Code
   Case "SEMAINPROCESS":z7411.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z7411.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z7411.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z7411.cdSubProcess = Children(i).Code
   Case "SENATIONALITY":z7411.seNationality = Children(i).Code
   Case "CDNATIONALITY":z7411.cdNationality = Children(i).Code
   Case "SEDEPARTMENT":z7411.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z7411.cdDepartment = Children(i).Code
   Case "SEONEPOSITION":z7411.seOnePosition = Children(i).Code
   Case "CDONEPOSITION":z7411.cdOnePosition = Children(i).Code
   Case "SEPOSITION":z7411.sePosition = Children(i).Code
   Case "CDPOSITION":z7411.cdPosition = Children(i).Code
   Case "SEINCHARGE":z7411.seInCharge = Children(i).Code
   Case "CDINCHARGE":z7411.cdInCharge = Children(i).Code
   Case "SEFACTORY":z7411.seFactory = Children(i).Code
   Case "CDFACTORY":z7411.cdFactory = Children(i).Code
   Case "SELINEPROD":z7411.seLineProd = Children(i).Code
   Case "CDLINEPROD":z7411.cdLineProd = Children(i).Code
   Case "EMAIL":z7411.Email = Children(i).Code
   Case "MOBILE":z7411.Mobile = Children(i).Code
   Case "GENDER":z7411.Gender = Children(i).Code
   Case "SENDEMAIL":z7411.SendEmail = Children(i).Code
   Case "SENDSMS":z7411.SendSMS = Children(i).Code
   Case "SENDFAX":z7411.SendFax = Children(i).Code
   Case "LOCKED":z7411.Locked = Children(i).Code
   Case "OPENCDT":z7411.OpenCdt = Children(i).Code
   Case "OPENPRVDAYS":z7411.OpenPrvDays = Children(i).Code
   Case "OPENRATE":z7411.OpenRate = Children(i).Code
   Case "OPENSCHEDULE":z7411.OpenSchedule = Children(i).Code
   Case "OPENALERT":z7411.OpenAlert = Children(i).Code
   Case "OPENMESSAGE":z7411.OpenMessage = Children(i).Code
   Case "SCREENLOCK":z7411.ScreenLock = Children(i).Code
   Case "IDCD":z7411.IDCD = Children(i).Code
   Case "DGCD":z7411.DGCD = Children(i).Code
   Case "GNID":z7411.GNID = Children(i).Code
   Case "DATEINSERT":z7411.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7411.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7411.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7411.InchargeUpdate = Children(i).Code
   Case "DATEACTIVE":z7411.DateActive = Children(i).Code
   Case "DATEDEACTIVE":z7411.DateDeactive = Children(i).Code
   Case "CHECKACTIVE":z7411.CheckActive = Children(i).Code
   Case "FIRSTCHANGEPASS":z7411.FirstChangePass = Children(i).Code
   Case "LASTPASS":z7411.LastPass = Children(i).Code
   Case "LASTPASS1":z7411.LastPass1 = Children(i).Code
   Case "LASTPASS2":z7411.LastPass2 = Children(i).Code
   Case "FAILLOGINCNT":z7411.FailLoginCnt = Children(i).Code
   Case "CHECKNEVER":z7411.CheckNever = Children(i).Code
   Case "LASTLOGIN":z7411.LastLogin = Children(i).Code
   Case "LASTTIME":z7411.LastTime = Children(i).Code
   Case "CHECKOPTION1":z7411.CheckOption1 = Children(i).Code
   Case "CHECKOPTION2":z7411.CheckOption2 = Children(i).Code
   Case "CHECKOPTION3":z7411.CheckOption3 = Children(i).Code
   Case "CHECKOPTION4":z7411.CheckOption4 = Children(i).Code
   Case "CHECKOPTION5":z7411.CheckOption5 = Children(i).Code
   Case "CHECKUSE":z7411.CheckUse = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "IDNO":z7411.IDNO = Children(i).Data
   Case "DEVELOPMENETCODE":z7411.DevelopmenetCode = Children(i).Data
   Case "IDCARD":z7411.IDCard = Children(i).Data
   Case "IDHRCODE":z7411.IDHRCode = Children(i).Data
   Case "USERID":z7411.UserID = Children(i).Data
   Case "PASSWORD":z7411.PassWord = Children(i).Data
   Case "NAME":z7411.Name = Children(i).Data
   Case "FOREIGNNAME":z7411.ForeignName = Children(i).Data
   Case "SESITE":z7411.seSite = Children(i).Data
   Case "CDSITE":z7411.cdSite = Children(i).Data
   Case "SEMAINPROCESS":z7411.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z7411.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z7411.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z7411.cdSubProcess = Children(i).Data
   Case "SENATIONALITY":z7411.seNationality = Children(i).Data
   Case "CDNATIONALITY":z7411.cdNationality = Children(i).Data
   Case "SEDEPARTMENT":z7411.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z7411.cdDepartment = Children(i).Data
   Case "SEONEPOSITION":z7411.seOnePosition = Children(i).Data
   Case "CDONEPOSITION":z7411.cdOnePosition = Children(i).Data
   Case "SEPOSITION":z7411.sePosition = Children(i).Data
   Case "CDPOSITION":z7411.cdPosition = Children(i).Data
   Case "SEINCHARGE":z7411.seInCharge = Children(i).Data
   Case "CDINCHARGE":z7411.cdInCharge = Children(i).Data
   Case "SEFACTORY":z7411.seFactory = Children(i).Data
   Case "CDFACTORY":z7411.cdFactory = Children(i).Data
   Case "SELINEPROD":z7411.seLineProd = Children(i).Data
   Case "CDLINEPROD":z7411.cdLineProd = Children(i).Data
   Case "EMAIL":z7411.Email = Children(i).Data
   Case "MOBILE":z7411.Mobile = Children(i).Data
   Case "GENDER":z7411.Gender = Children(i).Data
   Case "SENDEMAIL":z7411.SendEmail = Children(i).Data
   Case "SENDSMS":z7411.SendSMS = Children(i).Data
   Case "SENDFAX":z7411.SendFax = Children(i).Data
   Case "LOCKED":z7411.Locked = Children(i).Data
   Case "OPENCDT":z7411.OpenCdt = Children(i).Data
   Case "OPENPRVDAYS":z7411.OpenPrvDays = Children(i).Data
   Case "OPENRATE":z7411.OpenRate = Children(i).Data
   Case "OPENSCHEDULE":z7411.OpenSchedule = Children(i).Data
   Case "OPENALERT":z7411.OpenAlert = Children(i).Data
   Case "OPENMESSAGE":z7411.OpenMessage = Children(i).Data
   Case "SCREENLOCK":z7411.ScreenLock = Children(i).Data
   Case "IDCD":z7411.IDCD = Children(i).Data
   Case "DGCD":z7411.DGCD = Children(i).Data
   Case "GNID":z7411.GNID = Children(i).Data
   Case "DATEINSERT":z7411.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7411.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7411.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7411.InchargeUpdate = Children(i).Data
   Case "DATEACTIVE":z7411.DateActive = Children(i).Data
   Case "DATEDEACTIVE":z7411.DateDeactive = Children(i).Data
   Case "CHECKACTIVE":z7411.CheckActive = Children(i).Data
   Case "FIRSTCHANGEPASS":z7411.FirstChangePass = Children(i).Data
   Case "LASTPASS":z7411.LastPass = Children(i).Data
   Case "LASTPASS1":z7411.LastPass1 = Children(i).Data
   Case "LASTPASS2":z7411.LastPass2 = Children(i).Data
   Case "FAILLOGINCNT":z7411.FailLoginCnt = Children(i).Data
   Case "CHECKNEVER":z7411.CheckNever = Children(i).Data
   Case "LASTLOGIN":z7411.LastLogin = Children(i).Data
   Case "LASTTIME":z7411.LastTime = Children(i).Data
   Case "CHECKOPTION1":z7411.CheckOption1 = Children(i).Data
   Case "CHECKOPTION2":z7411.CheckOption2 = Children(i).Data
   Case "CHECKOPTION3":z7411.CheckOption3 = Children(i).Data
   Case "CHECKOPTION4":z7411.CheckOption4 = Children(i).Data
   Case "CHECKOPTION5":z7411.CheckOption5 = Children(i).Data
   Case "CHECKUSE":z7411.CheckUse = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7411_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7411_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7411 As T7411_AREA, Job as String, CheckClear as Boolean, IDNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7411_MOVE = False

Try
    If READ_PFK7411(IDNO) = True Then
                z7411 = D7411
		K7411_MOVE = True
		else
	If CheckClear  = True then z7411 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7411")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "IDNO":z7411.IDNO = Children(i).Code
   Case "DEVELOPMENETCODE":z7411.DevelopmenetCode = Children(i).Code
   Case "IDCARD":z7411.IDCard = Children(i).Code
   Case "IDHRCODE":z7411.IDHRCode = Children(i).Code
   Case "USERID":z7411.UserID = Children(i).Code
   Case "PASSWORD":z7411.PassWord = Children(i).Code
   Case "NAME":z7411.Name = Children(i).Code
   Case "FOREIGNNAME":z7411.ForeignName = Children(i).Code
   Case "SESITE":z7411.seSite = Children(i).Code
   Case "CDSITE":z7411.cdSite = Children(i).Code
   Case "SEMAINPROCESS":z7411.seMainProcess = Children(i).Code
   Case "CDMAINPROCESS":z7411.cdMainProcess = Children(i).Code
   Case "SESUBPROCESS":z7411.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z7411.cdSubProcess = Children(i).Code
   Case "SENATIONALITY":z7411.seNationality = Children(i).Code
   Case "CDNATIONALITY":z7411.cdNationality = Children(i).Code
   Case "SEDEPARTMENT":z7411.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z7411.cdDepartment = Children(i).Code
   Case "SEONEPOSITION":z7411.seOnePosition = Children(i).Code
   Case "CDONEPOSITION":z7411.cdOnePosition = Children(i).Code
   Case "SEPOSITION":z7411.sePosition = Children(i).Code
   Case "CDPOSITION":z7411.cdPosition = Children(i).Code
   Case "SEINCHARGE":z7411.seInCharge = Children(i).Code
   Case "CDINCHARGE":z7411.cdInCharge = Children(i).Code
   Case "SEFACTORY":z7411.seFactory = Children(i).Code
   Case "CDFACTORY":z7411.cdFactory = Children(i).Code
   Case "SELINEPROD":z7411.seLineProd = Children(i).Code
   Case "CDLINEPROD":z7411.cdLineProd = Children(i).Code
   Case "EMAIL":z7411.Email = Children(i).Code
   Case "MOBILE":z7411.Mobile = Children(i).Code
   Case "GENDER":z7411.Gender = Children(i).Code
   Case "SENDEMAIL":z7411.SendEmail = Children(i).Code
   Case "SENDSMS":z7411.SendSMS = Children(i).Code
   Case "SENDFAX":z7411.SendFax = Children(i).Code
   Case "LOCKED":z7411.Locked = Children(i).Code
   Case "OPENCDT":z7411.OpenCdt = Children(i).Code
   Case "OPENPRVDAYS":z7411.OpenPrvDays = Children(i).Code
   Case "OPENRATE":z7411.OpenRate = Children(i).Code
   Case "OPENSCHEDULE":z7411.OpenSchedule = Children(i).Code
   Case "OPENALERT":z7411.OpenAlert = Children(i).Code
   Case "OPENMESSAGE":z7411.OpenMessage = Children(i).Code
   Case "SCREENLOCK":z7411.ScreenLock = Children(i).Code
   Case "IDCD":z7411.IDCD = Children(i).Code
   Case "DGCD":z7411.DGCD = Children(i).Code
   Case "GNID":z7411.GNID = Children(i).Code
   Case "DATEINSERT":z7411.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7411.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7411.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7411.InchargeUpdate = Children(i).Code
   Case "DATEACTIVE":z7411.DateActive = Children(i).Code
   Case "DATEDEACTIVE":z7411.DateDeactive = Children(i).Code
   Case "CHECKACTIVE":z7411.CheckActive = Children(i).Code
   Case "FIRSTCHANGEPASS":z7411.FirstChangePass = Children(i).Code
   Case "LASTPASS":z7411.LastPass = Children(i).Code
   Case "LASTPASS1":z7411.LastPass1 = Children(i).Code
   Case "LASTPASS2":z7411.LastPass2 = Children(i).Code
   Case "FAILLOGINCNT":z7411.FailLoginCnt = Children(i).Code
   Case "CHECKNEVER":z7411.CheckNever = Children(i).Code
   Case "LASTLOGIN":z7411.LastLogin = Children(i).Code
   Case "LASTTIME":z7411.LastTime = Children(i).Code
   Case "CHECKOPTION1":z7411.CheckOption1 = Children(i).Code
   Case "CHECKOPTION2":z7411.CheckOption2 = Children(i).Code
   Case "CHECKOPTION3":z7411.CheckOption3 = Children(i).Code
   Case "CHECKOPTION4":z7411.CheckOption4 = Children(i).Code
   Case "CHECKOPTION5":z7411.CheckOption5 = Children(i).Code
   Case "CHECKUSE":z7411.CheckUse = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "IDNO":z7411.IDNO = Children(i).Data
   Case "DEVELOPMENETCODE":z7411.DevelopmenetCode = Children(i).Data
   Case "IDCARD":z7411.IDCard = Children(i).Data
   Case "IDHRCODE":z7411.IDHRCode = Children(i).Data
   Case "USERID":z7411.UserID = Children(i).Data
   Case "PASSWORD":z7411.PassWord = Children(i).Data
   Case "NAME":z7411.Name = Children(i).Data
   Case "FOREIGNNAME":z7411.ForeignName = Children(i).Data
   Case "SESITE":z7411.seSite = Children(i).Data
   Case "CDSITE":z7411.cdSite = Children(i).Data
   Case "SEMAINPROCESS":z7411.seMainProcess = Children(i).Data
   Case "CDMAINPROCESS":z7411.cdMainProcess = Children(i).Data
   Case "SESUBPROCESS":z7411.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z7411.cdSubProcess = Children(i).Data
   Case "SENATIONALITY":z7411.seNationality = Children(i).Data
   Case "CDNATIONALITY":z7411.cdNationality = Children(i).Data
   Case "SEDEPARTMENT":z7411.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z7411.cdDepartment = Children(i).Data
   Case "SEONEPOSITION":z7411.seOnePosition = Children(i).Data
   Case "CDONEPOSITION":z7411.cdOnePosition = Children(i).Data
   Case "SEPOSITION":z7411.sePosition = Children(i).Data
   Case "CDPOSITION":z7411.cdPosition = Children(i).Data
   Case "SEINCHARGE":z7411.seInCharge = Children(i).Data
   Case "CDINCHARGE":z7411.cdInCharge = Children(i).Data
   Case "SEFACTORY":z7411.seFactory = Children(i).Data
   Case "CDFACTORY":z7411.cdFactory = Children(i).Data
   Case "SELINEPROD":z7411.seLineProd = Children(i).Data
   Case "CDLINEPROD":z7411.cdLineProd = Children(i).Data
   Case "EMAIL":z7411.Email = Children(i).Data
   Case "MOBILE":z7411.Mobile = Children(i).Data
   Case "GENDER":z7411.Gender = Children(i).Data
   Case "SENDEMAIL":z7411.SendEmail = Children(i).Data
   Case "SENDSMS":z7411.SendSMS = Children(i).Data
   Case "SENDFAX":z7411.SendFax = Children(i).Data
   Case "LOCKED":z7411.Locked = Children(i).Data
   Case "OPENCDT":z7411.OpenCdt = Children(i).Data
   Case "OPENPRVDAYS":z7411.OpenPrvDays = Children(i).Data
   Case "OPENRATE":z7411.OpenRate = Children(i).Data
   Case "OPENSCHEDULE":z7411.OpenSchedule = Children(i).Data
   Case "OPENALERT":z7411.OpenAlert = Children(i).Data
   Case "OPENMESSAGE":z7411.OpenMessage = Children(i).Data
   Case "SCREENLOCK":z7411.ScreenLock = Children(i).Data
   Case "IDCD":z7411.IDCD = Children(i).Data
   Case "DGCD":z7411.DGCD = Children(i).Data
   Case "GNID":z7411.GNID = Children(i).Data
   Case "DATEINSERT":z7411.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7411.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7411.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7411.InchargeUpdate = Children(i).Data
   Case "DATEACTIVE":z7411.DateActive = Children(i).Data
   Case "DATEDEACTIVE":z7411.DateDeactive = Children(i).Data
   Case "CHECKACTIVE":z7411.CheckActive = Children(i).Data
   Case "FIRSTCHANGEPASS":z7411.FirstChangePass = Children(i).Data
   Case "LASTPASS":z7411.LastPass = Children(i).Data
   Case "LASTPASS1":z7411.LastPass1 = Children(i).Data
   Case "LASTPASS2":z7411.LastPass2 = Children(i).Data
   Case "FAILLOGINCNT":z7411.FailLoginCnt = Children(i).Data
   Case "CHECKNEVER":z7411.CheckNever = Children(i).Data
   Case "LASTLOGIN":z7411.LastLogin = Children(i).Data
   Case "LASTTIME":z7411.LastTime = Children(i).Data
   Case "CHECKOPTION1":z7411.CheckOption1 = Children(i).Data
   Case "CHECKOPTION2":z7411.CheckOption2 = Children(i).Data
   Case "CHECKOPTION3":z7411.CheckOption3 = Children(i).Data
   Case "CHECKOPTION4":z7411.CheckOption4 = Children(i).Data
   Case "CHECKOPTION5":z7411.CheckOption5 = Children(i).Data
   Case "CHECKUSE":z7411.CheckUse = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7411_MOVE",vbCritical)
End Try
End Function 
    
End Module 
