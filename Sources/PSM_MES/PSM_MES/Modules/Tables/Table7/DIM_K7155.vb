'=========================================================================================================================================================
'   TABLE : (PFK7155)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7155

Structure T7155_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	MachineCode	 AS String	'			char(6)		*
Public 	DevelopmentCode	 AS String	'			char(6)
Public 	AccCode	 AS String	'			nvarchar(50)
Public 	TagNo	 AS String	'			nvarchar(50)
Public 	Model	 AS String	'			nvarchar(50)
Public 	seMachineType	 AS String	'			char(3)
Public 	cdMachineType	 AS String	'			char(3)
Public 	MachineName	 AS String	'			nvarchar(100)
Public 	MachineNameSimply	 AS String	'			nvarchar(50)
Public 	seFactory	 AS String	'			char(3)
Public 	cdFactory	 AS String	'			char(3)
Public 	seSubProcess	 AS String	'			char(3)
Public 	cdSubProcess	 AS String	'			char(3)
Public 	MachineRPM	 AS Double	'			decimal
Public 	MachineCapacity	 AS Double	'			decimal
Public 	RotationDayProduction	 AS Double	'			decimal
Public 	RotationOnceProduction	 AS Double	'			decimal
Public 	RotationOnceTimeProduction	 AS Double	'			decimal
Public 	CheckApplyLiquid	 AS String	'			char(1)
Public 	RateLiquid	 AS Double	'			decimal
Public 	WDCPMDTC	 AS String	'			varchar(100)
Public 	RateSoda1	 AS Double	'			decimal
Public 	RateSoda2	 AS Double	'			decimal
Public 	RateSoda3	 AS Double	'			decimal
Public 	RateGlauberSalt1	 AS Double	'			decimal
Public 	RateGlauberSalt2	 AS Double	'			decimal
Public 	RateGlauberSalt3	 AS Double	'			decimal
Public 	GroupMachine	 AS Double	'			decimal
Public 	HorizontalPosition	 AS Double	'			decimal
Public 	VerticalPosition	 AS Double	'			decimal
Public 	ChecK1	 AS String	'			char(1)
Public 	Check2	 AS String	'			char(1)
Public 	CheckFinalProcess	 AS String	'			char(1)
Public 	CheckProcess	 AS String	'			char(1)
Public 	checkUse	 AS String	'			char(1)
Public 	DisplaySeq	 AS Double	'			decimal
Public 	Remark	 AS String	'			nvarchar(200)
'=========================================================================================================================================================
End structure

Public D7155 As T7155_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7155(MACHINECODE AS String) As Boolean
    READ_PFK7155 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7155 "
    SQL = SQL & " WHERE K7155_MachineCode		 = '" & MachineCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7155_CLEAR: GoTo SKIP_READ_PFK7155
                
    Call K7155_MOVE(rd)
    READ_PFK7155 = True

SKIP_READ_PFK7155:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7155",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7155(MACHINECODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7155 "
    SQL = SQL & " WHERE K7155_MachineCode		 = '" & MachineCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7155",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7155(z7155 As T7155_AREA) As Boolean
    WRITE_PFK7155 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7155)
 
    SQL = " INSERT INTO PFK7155 "
    SQL = SQL & " ( "
    SQL = SQL & " K7155_MachineCode," 
    SQL = SQL & " K7155_DevelopmentCode," 
    SQL = SQL & " K7155_AccCode," 
    SQL = SQL & " K7155_TagNo," 
    SQL = SQL & " K7155_Model," 
    SQL = SQL & " K7155_seMachineType," 
    SQL = SQL & " K7155_cdMachineType," 
    SQL = SQL & " K7155_MachineName," 
    SQL = SQL & " K7155_MachineNameSimply," 
    SQL = SQL & " K7155_seFactory," 
    SQL = SQL & " K7155_cdFactory," 
    SQL = SQL & " K7155_seSubProcess," 
    SQL = SQL & " K7155_cdSubProcess," 
    SQL = SQL & " K7155_MachineRPM," 
    SQL = SQL & " K7155_MachineCapacity," 
    SQL = SQL & " K7155_RotationDayProduction," 
    SQL = SQL & " K7155_RotationOnceProduction," 
    SQL = SQL & " K7155_RotationOnceTimeProduction," 
    SQL = SQL & " K7155_CheckApplyLiquid," 
    SQL = SQL & " K7155_RateLiquid," 
    SQL = SQL & " K7155_WDCPMDTC," 
    SQL = SQL & " K7155_RateSoda1," 
    SQL = SQL & " K7155_RateSoda2," 
    SQL = SQL & " K7155_RateSoda3," 
    SQL = SQL & " K7155_RateGlauberSalt1," 
    SQL = SQL & " K7155_RateGlauberSalt2," 
    SQL = SQL & " K7155_RateGlauberSalt3," 
    SQL = SQL & " K7155_GroupMachine," 
    SQL = SQL & " K7155_HorizontalPosition," 
    SQL = SQL & " K7155_VerticalPosition," 
    SQL = SQL & " K7155_ChecK1," 
    SQL = SQL & " K7155_Check2," 
    SQL = SQL & " K7155_CheckFinalProcess," 
    SQL = SQL & " K7155_CheckProcess," 
    SQL = SQL & " K7155_checkUse," 
    SQL = SQL & " K7155_DisplaySeq," 
    SQL = SQL & " K7155_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7155.MachineCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7155.DevelopmentCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7155.AccCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7155.TagNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7155.Model) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7155.seMachineType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7155.cdMachineType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7155.MachineName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7155.MachineNameSimply) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7155.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7155.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7155.seSubProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7155.cdSubProcess) & "', "  
    SQL = SQL & "   " & FormatSQL(z7155.MachineRPM) & ", "  
    SQL = SQL & "   " & FormatSQL(z7155.MachineCapacity) & ", "  
    SQL = SQL & "   " & FormatSQL(z7155.RotationDayProduction) & ", "  
    SQL = SQL & "   " & FormatSQL(z7155.RotationOnceProduction) & ", "  
    SQL = SQL & "   " & FormatSQL(z7155.RotationOnceTimeProduction) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7155.CheckApplyLiquid) & "', "  
    SQL = SQL & "   " & FormatSQL(z7155.RateLiquid) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7155.WDCPMDTC) & "', "  
    SQL = SQL & "   " & FormatSQL(z7155.RateSoda1) & ", "  
    SQL = SQL & "   " & FormatSQL(z7155.RateSoda2) & ", "  
    SQL = SQL & "   " & FormatSQL(z7155.RateSoda3) & ", "  
    SQL = SQL & "   " & FormatSQL(z7155.RateGlauberSalt1) & ", "  
    SQL = SQL & "   " & FormatSQL(z7155.RateGlauberSalt2) & ", "  
    SQL = SQL & "   " & FormatSQL(z7155.RateGlauberSalt3) & ", "  
    SQL = SQL & "   " & FormatSQL(z7155.GroupMachine) & ", "  
    SQL = SQL & "   " & FormatSQL(z7155.HorizontalPosition) & ", "  
    SQL = SQL & "   " & FormatSQL(z7155.VerticalPosition) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7155.ChecK1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7155.Check2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7155.CheckFinalProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7155.CheckProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7155.checkUse) & "', "  
    SQL = SQL & "   " & FormatSQL(z7155.DisplaySeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7155.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7155 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7155",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7155(z7155 As T7155_AREA) As Boolean
    REWRITE_PFK7155 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7155)
   
    SQL = " UPDATE PFK7155 SET "
    SQL = SQL & "    K7155_DevelopmentCode      = N'" & FormatSQL(z7155.DevelopmentCode) & "', " 
    SQL = SQL & "    K7155_AccCode      = N'" & FormatSQL(z7155.AccCode) & "', " 
    SQL = SQL & "    K7155_TagNo      = N'" & FormatSQL(z7155.TagNo) & "', " 
    SQL = SQL & "    K7155_Model      = N'" & FormatSQL(z7155.Model) & "', " 
    SQL = SQL & "    K7155_seMachineType      = N'" & FormatSQL(z7155.seMachineType) & "', " 
    SQL = SQL & "    K7155_cdMachineType      = N'" & FormatSQL(z7155.cdMachineType) & "', " 
    SQL = SQL & "    K7155_MachineName      = N'" & FormatSQL(z7155.MachineName) & "', " 
    SQL = SQL & "    K7155_MachineNameSimply      = N'" & FormatSQL(z7155.MachineNameSimply) & "', " 
    SQL = SQL & "    K7155_seFactory      = N'" & FormatSQL(z7155.seFactory) & "', " 
    SQL = SQL & "    K7155_cdFactory      = N'" & FormatSQL(z7155.cdFactory) & "', " 
    SQL = SQL & "    K7155_seSubProcess      = N'" & FormatSQL(z7155.seSubProcess) & "', " 
    SQL = SQL & "    K7155_cdSubProcess      = N'" & FormatSQL(z7155.cdSubProcess) & "', " 
    SQL = SQL & "    K7155_MachineRPM      =  " & FormatSQL(z7155.MachineRPM) & ", " 
    SQL = SQL & "    K7155_MachineCapacity      =  " & FormatSQL(z7155.MachineCapacity) & ", " 
    SQL = SQL & "    K7155_RotationDayProduction      =  " & FormatSQL(z7155.RotationDayProduction) & ", " 
    SQL = SQL & "    K7155_RotationOnceProduction      =  " & FormatSQL(z7155.RotationOnceProduction) & ", " 
    SQL = SQL & "    K7155_RotationOnceTimeProduction      =  " & FormatSQL(z7155.RotationOnceTimeProduction) & ", " 
    SQL = SQL & "    K7155_CheckApplyLiquid      = N'" & FormatSQL(z7155.CheckApplyLiquid) & "', " 
    SQL = SQL & "    K7155_RateLiquid      =  " & FormatSQL(z7155.RateLiquid) & ", " 
    SQL = SQL & "    K7155_WDCPMDTC      = N'" & FormatSQL(z7155.WDCPMDTC) & "', " 
    SQL = SQL & "    K7155_RateSoda1      =  " & FormatSQL(z7155.RateSoda1) & ", " 
    SQL = SQL & "    K7155_RateSoda2      =  " & FormatSQL(z7155.RateSoda2) & ", " 
    SQL = SQL & "    K7155_RateSoda3      =  " & FormatSQL(z7155.RateSoda3) & ", " 
    SQL = SQL & "    K7155_RateGlauberSalt1      =  " & FormatSQL(z7155.RateGlauberSalt1) & ", " 
    SQL = SQL & "    K7155_RateGlauberSalt2      =  " & FormatSQL(z7155.RateGlauberSalt2) & ", " 
    SQL = SQL & "    K7155_RateGlauberSalt3      =  " & FormatSQL(z7155.RateGlauberSalt3) & ", " 
    SQL = SQL & "    K7155_GroupMachine      =  " & FormatSQL(z7155.GroupMachine) & ", " 
    SQL = SQL & "    K7155_HorizontalPosition      =  " & FormatSQL(z7155.HorizontalPosition) & ", " 
    SQL = SQL & "    K7155_VerticalPosition      =  " & FormatSQL(z7155.VerticalPosition) & ", " 
    SQL = SQL & "    K7155_ChecK1      = N'" & FormatSQL(z7155.ChecK1) & "', " 
    SQL = SQL & "    K7155_Check2      = N'" & FormatSQL(z7155.Check2) & "', " 
    SQL = SQL & "    K7155_CheckFinalProcess      = N'" & FormatSQL(z7155.CheckFinalProcess) & "', " 
    SQL = SQL & "    K7155_CheckProcess      = N'" & FormatSQL(z7155.CheckProcess) & "', " 
    SQL = SQL & "    K7155_checkUse      = N'" & FormatSQL(z7155.checkUse) & "', " 
    SQL = SQL & "    K7155_DisplaySeq      =  " & FormatSQL(z7155.DisplaySeq) & ", " 
    SQL = SQL & "    K7155_Remark      = N'" & FormatSQL(z7155.Remark) & "'  " 
    SQL = SQL & " WHERE K7155_MachineCode		 = '" & z7155.MachineCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7155 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7155",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7155(z7155 As T7155_AREA) As Boolean
    DELETE_PFK7155 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7155 "
    SQL = SQL & " WHERE K7155_MachineCode		 = '" & z7155.MachineCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7155 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7155",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7155_CLEAR()
Try
    
   D7155.MachineCode = ""
   D7155.DevelopmentCode = ""
   D7155.AccCode = ""
   D7155.TagNo = ""
   D7155.Model = ""
   D7155.seMachineType = ""
   D7155.cdMachineType = ""
   D7155.MachineName = ""
   D7155.MachineNameSimply = ""
   D7155.seFactory = ""
   D7155.cdFactory = ""
   D7155.seSubProcess = ""
   D7155.cdSubProcess = ""
    D7155.MachineRPM = 0 
    D7155.MachineCapacity = 0 
    D7155.RotationDayProduction = 0 
    D7155.RotationOnceProduction = 0 
    D7155.RotationOnceTimeProduction = 0 
   D7155.CheckApplyLiquid = ""
    D7155.RateLiquid = 0 
   D7155.WDCPMDTC = ""
    D7155.RateSoda1 = 0 
    D7155.RateSoda2 = 0 
    D7155.RateSoda3 = 0 
    D7155.RateGlauberSalt1 = 0 
    D7155.RateGlauberSalt2 = 0 
    D7155.RateGlauberSalt3 = 0 
    D7155.GroupMachine = 0 
    D7155.HorizontalPosition = 0 
    D7155.VerticalPosition = 0 
   D7155.ChecK1 = ""
   D7155.Check2 = ""
   D7155.CheckFinalProcess = ""
   D7155.CheckProcess = ""
   D7155.checkUse = ""
    D7155.DisplaySeq = 0 
   D7155.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7155_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7155 As T7155_AREA)
Try
    
    x7155.MachineCode = trim$(  x7155.MachineCode)
    x7155.DevelopmentCode = trim$(  x7155.DevelopmentCode)
    x7155.AccCode = trim$(  x7155.AccCode)
    x7155.TagNo = trim$(  x7155.TagNo)
    x7155.Model = trim$(  x7155.Model)
    x7155.seMachineType = trim$(  x7155.seMachineType)
    x7155.cdMachineType = trim$(  x7155.cdMachineType)
    x7155.MachineName = trim$(  x7155.MachineName)
    x7155.MachineNameSimply = trim$(  x7155.MachineNameSimply)
    x7155.seFactory = trim$(  x7155.seFactory)
    x7155.cdFactory = trim$(  x7155.cdFactory)
    x7155.seSubProcess = trim$(  x7155.seSubProcess)
    x7155.cdSubProcess = trim$(  x7155.cdSubProcess)
    x7155.MachineRPM = trim$(  x7155.MachineRPM)
    x7155.MachineCapacity = trim$(  x7155.MachineCapacity)
    x7155.RotationDayProduction = trim$(  x7155.RotationDayProduction)
    x7155.RotationOnceProduction = trim$(  x7155.RotationOnceProduction)
    x7155.RotationOnceTimeProduction = trim$(  x7155.RotationOnceTimeProduction)
    x7155.CheckApplyLiquid = trim$(  x7155.CheckApplyLiquid)
    x7155.RateLiquid = trim$(  x7155.RateLiquid)
    x7155.WDCPMDTC = trim$(  x7155.WDCPMDTC)
    x7155.RateSoda1 = trim$(  x7155.RateSoda1)
    x7155.RateSoda2 = trim$(  x7155.RateSoda2)
    x7155.RateSoda3 = trim$(  x7155.RateSoda3)
    x7155.RateGlauberSalt1 = trim$(  x7155.RateGlauberSalt1)
    x7155.RateGlauberSalt2 = trim$(  x7155.RateGlauberSalt2)
    x7155.RateGlauberSalt3 = trim$(  x7155.RateGlauberSalt3)
    x7155.GroupMachine = trim$(  x7155.GroupMachine)
    x7155.HorizontalPosition = trim$(  x7155.HorizontalPosition)
    x7155.VerticalPosition = trim$(  x7155.VerticalPosition)
    x7155.ChecK1 = trim$(  x7155.ChecK1)
    x7155.Check2 = trim$(  x7155.Check2)
    x7155.CheckFinalProcess = trim$(  x7155.CheckFinalProcess)
    x7155.CheckProcess = trim$(  x7155.CheckProcess)
    x7155.checkUse = trim$(  x7155.checkUse)
    x7155.DisplaySeq = trim$(  x7155.DisplaySeq)
    x7155.Remark = trim$(  x7155.Remark)
     
    If trim$( x7155.MachineCode ) = "" Then x7155.MachineCode = Space(1) 
    If trim$( x7155.DevelopmentCode ) = "" Then x7155.DevelopmentCode = Space(1) 
    If trim$( x7155.AccCode ) = "" Then x7155.AccCode = Space(1) 
    If trim$( x7155.TagNo ) = "" Then x7155.TagNo = Space(1) 
    If trim$( x7155.Model ) = "" Then x7155.Model = Space(1) 
    If trim$( x7155.seMachineType ) = "" Then x7155.seMachineType = Space(1) 
    If trim$( x7155.cdMachineType ) = "" Then x7155.cdMachineType = Space(1) 
    If trim$( x7155.MachineName ) = "" Then x7155.MachineName = Space(1) 
    If trim$( x7155.MachineNameSimply ) = "" Then x7155.MachineNameSimply = Space(1) 
    If trim$( x7155.seFactory ) = "" Then x7155.seFactory = Space(1) 
    If trim$( x7155.cdFactory ) = "" Then x7155.cdFactory = Space(1) 
    If trim$( x7155.seSubProcess ) = "" Then x7155.seSubProcess = Space(1) 
    If trim$( x7155.cdSubProcess ) = "" Then x7155.cdSubProcess = Space(1) 
    If trim$( x7155.MachineRPM ) = "" Then x7155.MachineRPM = 0 
    If trim$( x7155.MachineCapacity ) = "" Then x7155.MachineCapacity = 0 
    If trim$( x7155.RotationDayProduction ) = "" Then x7155.RotationDayProduction = 0 
    If trim$( x7155.RotationOnceProduction ) = "" Then x7155.RotationOnceProduction = 0 
    If trim$( x7155.RotationOnceTimeProduction ) = "" Then x7155.RotationOnceTimeProduction = 0 
    If trim$( x7155.CheckApplyLiquid ) = "" Then x7155.CheckApplyLiquid = Space(1) 
    If trim$( x7155.RateLiquid ) = "" Then x7155.RateLiquid = 0 
    If trim$( x7155.WDCPMDTC ) = "" Then x7155.WDCPMDTC = Space(1) 
    If trim$( x7155.RateSoda1 ) = "" Then x7155.RateSoda1 = 0 
    If trim$( x7155.RateSoda2 ) = "" Then x7155.RateSoda2 = 0 
    If trim$( x7155.RateSoda3 ) = "" Then x7155.RateSoda3 = 0 
    If trim$( x7155.RateGlauberSalt1 ) = "" Then x7155.RateGlauberSalt1 = 0 
    If trim$( x7155.RateGlauberSalt2 ) = "" Then x7155.RateGlauberSalt2 = 0 
    If trim$( x7155.RateGlauberSalt3 ) = "" Then x7155.RateGlauberSalt3 = 0 
    If trim$( x7155.GroupMachine ) = "" Then x7155.GroupMachine = 0 
    If trim$( x7155.HorizontalPosition ) = "" Then x7155.HorizontalPosition = 0 
    If trim$( x7155.VerticalPosition ) = "" Then x7155.VerticalPosition = 0 
    If trim$( x7155.ChecK1 ) = "" Then x7155.ChecK1 = Space(1) 
    If trim$( x7155.Check2 ) = "" Then x7155.Check2 = Space(1) 
    If trim$( x7155.CheckFinalProcess ) = "" Then x7155.CheckFinalProcess = Space(1) 
    If trim$( x7155.CheckProcess ) = "" Then x7155.CheckProcess = Space(1) 
    If trim$( x7155.checkUse ) = "" Then x7155.checkUse = Space(1) 
    If trim$( x7155.DisplaySeq ) = "" Then x7155.DisplaySeq = 0 
    If trim$( x7155.Remark ) = "" Then x7155.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7155_MOVE(rs7155 As SqlClient.SqlDataReader)
Try

    call D7155_CLEAR()   

    If IsdbNull(rs7155!K7155_MachineCode) = False Then D7155.MachineCode = Trim$(rs7155!K7155_MachineCode)
    If IsdbNull(rs7155!K7155_DevelopmentCode) = False Then D7155.DevelopmentCode = Trim$(rs7155!K7155_DevelopmentCode)
    If IsdbNull(rs7155!K7155_AccCode) = False Then D7155.AccCode = Trim$(rs7155!K7155_AccCode)
    If IsdbNull(rs7155!K7155_TagNo) = False Then D7155.TagNo = Trim$(rs7155!K7155_TagNo)
    If IsdbNull(rs7155!K7155_Model) = False Then D7155.Model = Trim$(rs7155!K7155_Model)
    If IsdbNull(rs7155!K7155_seMachineType) = False Then D7155.seMachineType = Trim$(rs7155!K7155_seMachineType)
    If IsdbNull(rs7155!K7155_cdMachineType) = False Then D7155.cdMachineType = Trim$(rs7155!K7155_cdMachineType)
    If IsdbNull(rs7155!K7155_MachineName) = False Then D7155.MachineName = Trim$(rs7155!K7155_MachineName)
    If IsdbNull(rs7155!K7155_MachineNameSimply) = False Then D7155.MachineNameSimply = Trim$(rs7155!K7155_MachineNameSimply)
    If IsdbNull(rs7155!K7155_seFactory) = False Then D7155.seFactory = Trim$(rs7155!K7155_seFactory)
    If IsdbNull(rs7155!K7155_cdFactory) = False Then D7155.cdFactory = Trim$(rs7155!K7155_cdFactory)
    If IsdbNull(rs7155!K7155_seSubProcess) = False Then D7155.seSubProcess = Trim$(rs7155!K7155_seSubProcess)
    If IsdbNull(rs7155!K7155_cdSubProcess) = False Then D7155.cdSubProcess = Trim$(rs7155!K7155_cdSubProcess)
    If IsdbNull(rs7155!K7155_MachineRPM) = False Then D7155.MachineRPM = Trim$(rs7155!K7155_MachineRPM)
    If IsdbNull(rs7155!K7155_MachineCapacity) = False Then D7155.MachineCapacity = Trim$(rs7155!K7155_MachineCapacity)
    If IsdbNull(rs7155!K7155_RotationDayProduction) = False Then D7155.RotationDayProduction = Trim$(rs7155!K7155_RotationDayProduction)
    If IsdbNull(rs7155!K7155_RotationOnceProduction) = False Then D7155.RotationOnceProduction = Trim$(rs7155!K7155_RotationOnceProduction)
    If IsdbNull(rs7155!K7155_RotationOnceTimeProduction) = False Then D7155.RotationOnceTimeProduction = Trim$(rs7155!K7155_RotationOnceTimeProduction)
    If IsdbNull(rs7155!K7155_CheckApplyLiquid) = False Then D7155.CheckApplyLiquid = Trim$(rs7155!K7155_CheckApplyLiquid)
    If IsdbNull(rs7155!K7155_RateLiquid) = False Then D7155.RateLiquid = Trim$(rs7155!K7155_RateLiquid)
    If IsdbNull(rs7155!K7155_WDCPMDTC) = False Then D7155.WDCPMDTC = Trim$(rs7155!K7155_WDCPMDTC)
    If IsdbNull(rs7155!K7155_RateSoda1) = False Then D7155.RateSoda1 = Trim$(rs7155!K7155_RateSoda1)
    If IsdbNull(rs7155!K7155_RateSoda2) = False Then D7155.RateSoda2 = Trim$(rs7155!K7155_RateSoda2)
    If IsdbNull(rs7155!K7155_RateSoda3) = False Then D7155.RateSoda3 = Trim$(rs7155!K7155_RateSoda3)
    If IsdbNull(rs7155!K7155_RateGlauberSalt1) = False Then D7155.RateGlauberSalt1 = Trim$(rs7155!K7155_RateGlauberSalt1)
    If IsdbNull(rs7155!K7155_RateGlauberSalt2) = False Then D7155.RateGlauberSalt2 = Trim$(rs7155!K7155_RateGlauberSalt2)
    If IsdbNull(rs7155!K7155_RateGlauberSalt3) = False Then D7155.RateGlauberSalt3 = Trim$(rs7155!K7155_RateGlauberSalt3)
    If IsdbNull(rs7155!K7155_GroupMachine) = False Then D7155.GroupMachine = Trim$(rs7155!K7155_GroupMachine)
    If IsdbNull(rs7155!K7155_HorizontalPosition) = False Then D7155.HorizontalPosition = Trim$(rs7155!K7155_HorizontalPosition)
    If IsdbNull(rs7155!K7155_VerticalPosition) = False Then D7155.VerticalPosition = Trim$(rs7155!K7155_VerticalPosition)
    If IsdbNull(rs7155!K7155_ChecK1) = False Then D7155.ChecK1 = Trim$(rs7155!K7155_ChecK1)
    If IsdbNull(rs7155!K7155_Check2) = False Then D7155.Check2 = Trim$(rs7155!K7155_Check2)
    If IsdbNull(rs7155!K7155_CheckFinalProcess) = False Then D7155.CheckFinalProcess = Trim$(rs7155!K7155_CheckFinalProcess)
    If IsdbNull(rs7155!K7155_CheckProcess) = False Then D7155.CheckProcess = Trim$(rs7155!K7155_CheckProcess)
    If IsdbNull(rs7155!K7155_checkUse) = False Then D7155.checkUse = Trim$(rs7155!K7155_checkUse)
    If IsdbNull(rs7155!K7155_DisplaySeq) = False Then D7155.DisplaySeq = Trim$(rs7155!K7155_DisplaySeq)
    If IsdbNull(rs7155!K7155_Remark) = False Then D7155.Remark = Trim$(rs7155!K7155_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7155_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7155_MOVE(rs7155 As DataRow)
Try

    call D7155_CLEAR()   

    If IsdbNull(rs7155!K7155_MachineCode) = False Then D7155.MachineCode = Trim$(rs7155!K7155_MachineCode)
    If IsdbNull(rs7155!K7155_DevelopmentCode) = False Then D7155.DevelopmentCode = Trim$(rs7155!K7155_DevelopmentCode)
    If IsdbNull(rs7155!K7155_AccCode) = False Then D7155.AccCode = Trim$(rs7155!K7155_AccCode)
    If IsdbNull(rs7155!K7155_TagNo) = False Then D7155.TagNo = Trim$(rs7155!K7155_TagNo)
    If IsdbNull(rs7155!K7155_Model) = False Then D7155.Model = Trim$(rs7155!K7155_Model)
    If IsdbNull(rs7155!K7155_seMachineType) = False Then D7155.seMachineType = Trim$(rs7155!K7155_seMachineType)
    If IsdbNull(rs7155!K7155_cdMachineType) = False Then D7155.cdMachineType = Trim$(rs7155!K7155_cdMachineType)
    If IsdbNull(rs7155!K7155_MachineName) = False Then D7155.MachineName = Trim$(rs7155!K7155_MachineName)
    If IsdbNull(rs7155!K7155_MachineNameSimply) = False Then D7155.MachineNameSimply = Trim$(rs7155!K7155_MachineNameSimply)
    If IsdbNull(rs7155!K7155_seFactory) = False Then D7155.seFactory = Trim$(rs7155!K7155_seFactory)
    If IsdbNull(rs7155!K7155_cdFactory) = False Then D7155.cdFactory = Trim$(rs7155!K7155_cdFactory)
    If IsdbNull(rs7155!K7155_seSubProcess) = False Then D7155.seSubProcess = Trim$(rs7155!K7155_seSubProcess)
    If IsdbNull(rs7155!K7155_cdSubProcess) = False Then D7155.cdSubProcess = Trim$(rs7155!K7155_cdSubProcess)
    If IsdbNull(rs7155!K7155_MachineRPM) = False Then D7155.MachineRPM = Trim$(rs7155!K7155_MachineRPM)
    If IsdbNull(rs7155!K7155_MachineCapacity) = False Then D7155.MachineCapacity = Trim$(rs7155!K7155_MachineCapacity)
    If IsdbNull(rs7155!K7155_RotationDayProduction) = False Then D7155.RotationDayProduction = Trim$(rs7155!K7155_RotationDayProduction)
    If IsdbNull(rs7155!K7155_RotationOnceProduction) = False Then D7155.RotationOnceProduction = Trim$(rs7155!K7155_RotationOnceProduction)
    If IsdbNull(rs7155!K7155_RotationOnceTimeProduction) = False Then D7155.RotationOnceTimeProduction = Trim$(rs7155!K7155_RotationOnceTimeProduction)
    If IsdbNull(rs7155!K7155_CheckApplyLiquid) = False Then D7155.CheckApplyLiquid = Trim$(rs7155!K7155_CheckApplyLiquid)
    If IsdbNull(rs7155!K7155_RateLiquid) = False Then D7155.RateLiquid = Trim$(rs7155!K7155_RateLiquid)
    If IsdbNull(rs7155!K7155_WDCPMDTC) = False Then D7155.WDCPMDTC = Trim$(rs7155!K7155_WDCPMDTC)
    If IsdbNull(rs7155!K7155_RateSoda1) = False Then D7155.RateSoda1 = Trim$(rs7155!K7155_RateSoda1)
    If IsdbNull(rs7155!K7155_RateSoda2) = False Then D7155.RateSoda2 = Trim$(rs7155!K7155_RateSoda2)
    If IsdbNull(rs7155!K7155_RateSoda3) = False Then D7155.RateSoda3 = Trim$(rs7155!K7155_RateSoda3)
    If IsdbNull(rs7155!K7155_RateGlauberSalt1) = False Then D7155.RateGlauberSalt1 = Trim$(rs7155!K7155_RateGlauberSalt1)
    If IsdbNull(rs7155!K7155_RateGlauberSalt2) = False Then D7155.RateGlauberSalt2 = Trim$(rs7155!K7155_RateGlauberSalt2)
    If IsdbNull(rs7155!K7155_RateGlauberSalt3) = False Then D7155.RateGlauberSalt3 = Trim$(rs7155!K7155_RateGlauberSalt3)
    If IsdbNull(rs7155!K7155_GroupMachine) = False Then D7155.GroupMachine = Trim$(rs7155!K7155_GroupMachine)
    If IsdbNull(rs7155!K7155_HorizontalPosition) = False Then D7155.HorizontalPosition = Trim$(rs7155!K7155_HorizontalPosition)
    If IsdbNull(rs7155!K7155_VerticalPosition) = False Then D7155.VerticalPosition = Trim$(rs7155!K7155_VerticalPosition)
    If IsdbNull(rs7155!K7155_ChecK1) = False Then D7155.ChecK1 = Trim$(rs7155!K7155_ChecK1)
    If IsdbNull(rs7155!K7155_Check2) = False Then D7155.Check2 = Trim$(rs7155!K7155_Check2)
    If IsdbNull(rs7155!K7155_CheckFinalProcess) = False Then D7155.CheckFinalProcess = Trim$(rs7155!K7155_CheckFinalProcess)
    If IsdbNull(rs7155!K7155_CheckProcess) = False Then D7155.CheckProcess = Trim$(rs7155!K7155_CheckProcess)
    If IsdbNull(rs7155!K7155_checkUse) = False Then D7155.checkUse = Trim$(rs7155!K7155_checkUse)
    If IsdbNull(rs7155!K7155_DisplaySeq) = False Then D7155.DisplaySeq = Trim$(rs7155!K7155_DisplaySeq)
    If IsdbNull(rs7155!K7155_Remark) = False Then D7155.Remark = Trim$(rs7155!K7155_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7155_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7155_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7155 As T7155_AREA, MACHINECODE AS String) as Boolean

K7155_MOVE = False

Try
    If READ_PFK7155(MACHINECODE) = True Then
                z7155 = D7155
		K7155_MOVE = True
		else
	z7155 = nothing
     End If

     If  getColumIndex(spr,"MachineCode") > -1 then z7155.MachineCode = getDataM(spr, getColumIndex(spr,"MachineCode"), xRow)
     If  getColumIndex(spr,"DevelopmentCode") > -1 then z7155.DevelopmentCode = getDataM(spr, getColumIndex(spr,"DevelopmentCode"), xRow)
     If  getColumIndex(spr,"AccCode") > -1 then z7155.AccCode = getDataM(spr, getColumIndex(spr,"AccCode"), xRow)
     If  getColumIndex(spr,"TagNo") > -1 then z7155.TagNo = getDataM(spr, getColumIndex(spr,"TagNo"), xRow)
     If  getColumIndex(spr,"Model") > -1 then z7155.Model = getDataM(spr, getColumIndex(spr,"Model"), xRow)
     If  getColumIndex(spr,"seMachineType") > -1 then z7155.seMachineType = getDataM(spr, getColumIndex(spr,"seMachineType"), xRow)
     If  getColumIndex(spr,"cdMachineType") > -1 then z7155.cdMachineType = getDataM(spr, getColumIndex(spr,"cdMachineType"), xRow)
     If  getColumIndex(spr,"MachineName") > -1 then z7155.MachineName = getDataM(spr, getColumIndex(spr,"MachineName"), xRow)
     If  getColumIndex(spr,"MachineNameSimply") > -1 then z7155.MachineNameSimply = getDataM(spr, getColumIndex(spr,"MachineNameSimply"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z7155.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z7155.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z7155.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z7155.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"MachineRPM") > -1 then z7155.MachineRPM = getDataM(spr, getColumIndex(spr,"MachineRPM"), xRow)
     If  getColumIndex(spr,"MachineCapacity") > -1 then z7155.MachineCapacity = getDataM(spr, getColumIndex(spr,"MachineCapacity"), xRow)
     If  getColumIndex(spr,"RotationDayProduction") > -1 then z7155.RotationDayProduction = getDataM(spr, getColumIndex(spr,"RotationDayProduction"), xRow)
     If  getColumIndex(spr,"RotationOnceProduction") > -1 then z7155.RotationOnceProduction = getDataM(spr, getColumIndex(spr,"RotationOnceProduction"), xRow)
     If  getColumIndex(spr,"RotationOnceTimeProduction") > -1 then z7155.RotationOnceTimeProduction = getDataM(spr, getColumIndex(spr,"RotationOnceTimeProduction"), xRow)
     If  getColumIndex(spr,"CheckApplyLiquid") > -1 then z7155.CheckApplyLiquid = getDataM(spr, getColumIndex(spr,"CheckApplyLiquid"), xRow)
     If  getColumIndex(spr,"RateLiquid") > -1 then z7155.RateLiquid = getDataM(spr, getColumIndex(spr,"RateLiquid"), xRow)
     If  getColumIndex(spr,"WDCPMDTC") > -1 then z7155.WDCPMDTC = getDataM(spr, getColumIndex(spr,"WDCPMDTC"), xRow)
     If  getColumIndex(spr,"RateSoda1") > -1 then z7155.RateSoda1 = getDataM(spr, getColumIndex(spr,"RateSoda1"), xRow)
     If  getColumIndex(spr,"RateSoda2") > -1 then z7155.RateSoda2 = getDataM(spr, getColumIndex(spr,"RateSoda2"), xRow)
     If  getColumIndex(spr,"RateSoda3") > -1 then z7155.RateSoda3 = getDataM(spr, getColumIndex(spr,"RateSoda3"), xRow)
     If  getColumIndex(spr,"RateGlauberSalt1") > -1 then z7155.RateGlauberSalt1 = getDataM(spr, getColumIndex(spr,"RateGlauberSalt1"), xRow)
     If  getColumIndex(spr,"RateGlauberSalt2") > -1 then z7155.RateGlauberSalt2 = getDataM(spr, getColumIndex(spr,"RateGlauberSalt2"), xRow)
     If  getColumIndex(spr,"RateGlauberSalt3") > -1 then z7155.RateGlauberSalt3 = getDataM(spr, getColumIndex(spr,"RateGlauberSalt3"), xRow)
     If  getColumIndex(spr,"GroupMachine") > -1 then z7155.GroupMachine = getDataM(spr, getColumIndex(spr,"GroupMachine"), xRow)
     If  getColumIndex(spr,"HorizontalPosition") > -1 then z7155.HorizontalPosition = getDataM(spr, getColumIndex(spr,"HorizontalPosition"), xRow)
     If  getColumIndex(spr,"VerticalPosition") > -1 then z7155.VerticalPosition = getDataM(spr, getColumIndex(spr,"VerticalPosition"), xRow)
     If  getColumIndex(spr,"ChecK1") > -1 then z7155.ChecK1 = getDataM(spr, getColumIndex(spr,"ChecK1"), xRow)
     If  getColumIndex(spr,"Check2") > -1 then z7155.Check2 = getDataM(spr, getColumIndex(spr,"Check2"), xRow)
     If  getColumIndex(spr,"CheckFinalProcess") > -1 then z7155.CheckFinalProcess = getDataM(spr, getColumIndex(spr,"CheckFinalProcess"), xRow)
     If  getColumIndex(spr,"CheckProcess") > -1 then z7155.CheckProcess = getDataM(spr, getColumIndex(spr,"CheckProcess"), xRow)
     If  getColumIndex(spr,"checkUse") > -1 then z7155.checkUse = getDataM(spr, getColumIndex(spr,"checkUse"), xRow)
     If  getColumIndex(spr,"DisplaySeq") > -1 then z7155.DisplaySeq = getDataM(spr, getColumIndex(spr,"DisplaySeq"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7155.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7155_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7155_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7155 As T7155_AREA,CheckClear as Boolean,MACHINECODE AS String) as Boolean

K7155_MOVE = False

Try
    If READ_PFK7155(MACHINECODE) = True Then
                z7155 = D7155
		K7155_MOVE = True
		else
	If CheckClear  = True then z7155 = nothing
     End If

     If  getColumIndex(spr,"MachineCode") > -1 then z7155.MachineCode = getDataM(spr, getColumIndex(spr,"MachineCode"), xRow)
     If  getColumIndex(spr,"DevelopmentCode") > -1 then z7155.DevelopmentCode = getDataM(spr, getColumIndex(spr,"DevelopmentCode"), xRow)
     If  getColumIndex(spr,"AccCode") > -1 then z7155.AccCode = getDataM(spr, getColumIndex(spr,"AccCode"), xRow)
     If  getColumIndex(spr,"TagNo") > -1 then z7155.TagNo = getDataM(spr, getColumIndex(spr,"TagNo"), xRow)
     If  getColumIndex(spr,"Model") > -1 then z7155.Model = getDataM(spr, getColumIndex(spr,"Model"), xRow)
     If  getColumIndex(spr,"seMachineType") > -1 then z7155.seMachineType = getDataM(spr, getColumIndex(spr,"seMachineType"), xRow)
     If  getColumIndex(spr,"cdMachineType") > -1 then z7155.cdMachineType = getDataM(spr, getColumIndex(spr,"cdMachineType"), xRow)
     If  getColumIndex(spr,"MachineName") > -1 then z7155.MachineName = getDataM(spr, getColumIndex(spr,"MachineName"), xRow)
     If  getColumIndex(spr,"MachineNameSimply") > -1 then z7155.MachineNameSimply = getDataM(spr, getColumIndex(spr,"MachineNameSimply"), xRow)
     If  getColumIndex(spr,"seFactory") > -1 then z7155.seFactory = getDataM(spr, getColumIndex(spr,"seFactory"), xRow)
     If  getColumIndex(spr,"cdFactory") > -1 then z7155.cdFactory = getDataM(spr, getColumIndex(spr,"cdFactory"), xRow)
     If  getColumIndex(spr,"seSubProcess") > -1 then z7155.seSubProcess = getDataM(spr, getColumIndex(spr,"seSubProcess"), xRow)
     If  getColumIndex(spr,"cdSubProcess") > -1 then z7155.cdSubProcess = getDataM(spr, getColumIndex(spr,"cdSubProcess"), xRow)
     If  getColumIndex(spr,"MachineRPM") > -1 then z7155.MachineRPM = getDataM(spr, getColumIndex(spr,"MachineRPM"), xRow)
     If  getColumIndex(spr,"MachineCapacity") > -1 then z7155.MachineCapacity = getDataM(spr, getColumIndex(spr,"MachineCapacity"), xRow)
     If  getColumIndex(spr,"RotationDayProduction") > -1 then z7155.RotationDayProduction = getDataM(spr, getColumIndex(spr,"RotationDayProduction"), xRow)
     If  getColumIndex(spr,"RotationOnceProduction") > -1 then z7155.RotationOnceProduction = getDataM(spr, getColumIndex(spr,"RotationOnceProduction"), xRow)
     If  getColumIndex(spr,"RotationOnceTimeProduction") > -1 then z7155.RotationOnceTimeProduction = getDataM(spr, getColumIndex(spr,"RotationOnceTimeProduction"), xRow)
     If  getColumIndex(spr,"CheckApplyLiquid") > -1 then z7155.CheckApplyLiquid = getDataM(spr, getColumIndex(spr,"CheckApplyLiquid"), xRow)
     If  getColumIndex(spr,"RateLiquid") > -1 then z7155.RateLiquid = getDataM(spr, getColumIndex(spr,"RateLiquid"), xRow)
     If  getColumIndex(spr,"WDCPMDTC") > -1 then z7155.WDCPMDTC = getDataM(spr, getColumIndex(spr,"WDCPMDTC"), xRow)
     If  getColumIndex(spr,"RateSoda1") > -1 then z7155.RateSoda1 = getDataM(spr, getColumIndex(spr,"RateSoda1"), xRow)
     If  getColumIndex(spr,"RateSoda2") > -1 then z7155.RateSoda2 = getDataM(spr, getColumIndex(spr,"RateSoda2"), xRow)
     If  getColumIndex(spr,"RateSoda3") > -1 then z7155.RateSoda3 = getDataM(spr, getColumIndex(spr,"RateSoda3"), xRow)
     If  getColumIndex(spr,"RateGlauberSalt1") > -1 then z7155.RateGlauberSalt1 = getDataM(spr, getColumIndex(spr,"RateGlauberSalt1"), xRow)
     If  getColumIndex(spr,"RateGlauberSalt2") > -1 then z7155.RateGlauberSalt2 = getDataM(spr, getColumIndex(spr,"RateGlauberSalt2"), xRow)
     If  getColumIndex(spr,"RateGlauberSalt3") > -1 then z7155.RateGlauberSalt3 = getDataM(spr, getColumIndex(spr,"RateGlauberSalt3"), xRow)
     If  getColumIndex(spr,"GroupMachine") > -1 then z7155.GroupMachine = getDataM(spr, getColumIndex(spr,"GroupMachine"), xRow)
     If  getColumIndex(spr,"HorizontalPosition") > -1 then z7155.HorizontalPosition = getDataM(spr, getColumIndex(spr,"HorizontalPosition"), xRow)
     If  getColumIndex(spr,"VerticalPosition") > -1 then z7155.VerticalPosition = getDataM(spr, getColumIndex(spr,"VerticalPosition"), xRow)
     If  getColumIndex(spr,"ChecK1") > -1 then z7155.ChecK1 = getDataM(spr, getColumIndex(spr,"ChecK1"), xRow)
     If  getColumIndex(spr,"Check2") > -1 then z7155.Check2 = getDataM(spr, getColumIndex(spr,"Check2"), xRow)
     If  getColumIndex(spr,"CheckFinalProcess") > -1 then z7155.CheckFinalProcess = getDataM(spr, getColumIndex(spr,"CheckFinalProcess"), xRow)
     If  getColumIndex(spr,"CheckProcess") > -1 then z7155.CheckProcess = getDataM(spr, getColumIndex(spr,"CheckProcess"), xRow)
     If  getColumIndex(spr,"checkUse") > -1 then z7155.checkUse = getDataM(spr, getColumIndex(spr,"checkUse"), xRow)
     If  getColumIndex(spr,"DisplaySeq") > -1 then z7155.DisplaySeq = getDataM(spr, getColumIndex(spr,"DisplaySeq"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7155.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7155_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7155_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7155 As T7155_AREA, Job as String, MACHINECODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7155_MOVE = False

Try
    If READ_PFK7155(MACHINECODE) = True Then
                z7155 = D7155
		K7155_MOVE = True
		else
	z7155 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7155")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MACHINECODE":z7155.MachineCode = Children(i).Code
   Case "DEVELOPMENTCODE":z7155.DevelopmentCode = Children(i).Code
   Case "ACCCODE":z7155.AccCode = Children(i).Code
   Case "TAGNO":z7155.TagNo = Children(i).Code
   Case "MODEL":z7155.Model = Children(i).Code
   Case "SEMACHINETYPE":z7155.seMachineType = Children(i).Code
   Case "CDMACHINETYPE":z7155.cdMachineType = Children(i).Code
   Case "MACHINENAME":z7155.MachineName = Children(i).Code
   Case "MACHINENAMESIMPLY":z7155.MachineNameSimply = Children(i).Code
   Case "SEFACTORY":z7155.seFactory = Children(i).Code
   Case "CDFACTORY":z7155.cdFactory = Children(i).Code
   Case "SESUBPROCESS":z7155.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z7155.cdSubProcess = Children(i).Code
   Case "MACHINERPM":z7155.MachineRPM = Children(i).Code
   Case "MACHINECAPACITY":z7155.MachineCapacity = Children(i).Code
   Case "ROTATIONDAYPRODUCTION":z7155.RotationDayProduction = Children(i).Code
   Case "ROTATIONONCEPRODUCTION":z7155.RotationOnceProduction = Children(i).Code
   Case "ROTATIONONCETIMEPRODUCTION":z7155.RotationOnceTimeProduction = Children(i).Code
   Case "CHECKAPPLYLIQUID":z7155.CheckApplyLiquid = Children(i).Code
   Case "RATELIQUID":z7155.RateLiquid = Children(i).Code
   Case "WDCPMDTC":z7155.WDCPMDTC = Children(i).Code
   Case "RATESODA1":z7155.RateSoda1 = Children(i).Code
   Case "RATESODA2":z7155.RateSoda2 = Children(i).Code
   Case "RATESODA3":z7155.RateSoda3 = Children(i).Code
   Case "RATEGLAUBERSALT1":z7155.RateGlauberSalt1 = Children(i).Code
   Case "RATEGLAUBERSALT2":z7155.RateGlauberSalt2 = Children(i).Code
   Case "RATEGLAUBERSALT3":z7155.RateGlauberSalt3 = Children(i).Code
   Case "GROUPMACHINE":z7155.GroupMachine = Children(i).Code
   Case "HORIZONTALPOSITION":z7155.HorizontalPosition = Children(i).Code
   Case "VERTICALPOSITION":z7155.VerticalPosition = Children(i).Code
   Case "CHECK1":z7155.ChecK1 = Children(i).Code
   Case "CHECK2":z7155.Check2 = Children(i).Code
   Case "CHECKFINALPROCESS":z7155.CheckFinalProcess = Children(i).Code
   Case "CHECKPROCESS":z7155.CheckProcess = Children(i).Code
   Case "CHECKUSE":z7155.checkUse = Children(i).Code
   Case "DISPLAYSEQ":z7155.DisplaySeq = Children(i).Code
   Case "REMARK":z7155.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MACHINECODE":z7155.MachineCode = Children(i).Data
   Case "DEVELOPMENTCODE":z7155.DevelopmentCode = Children(i).Data
   Case "ACCCODE":z7155.AccCode = Children(i).Data
   Case "TAGNO":z7155.TagNo = Children(i).Data
   Case "MODEL":z7155.Model = Children(i).Data
   Case "SEMACHINETYPE":z7155.seMachineType = Children(i).Data
   Case "CDMACHINETYPE":z7155.cdMachineType = Children(i).Data
   Case "MACHINENAME":z7155.MachineName = Children(i).Data
   Case "MACHINENAMESIMPLY":z7155.MachineNameSimply = Children(i).Data
   Case "SEFACTORY":z7155.seFactory = Children(i).Data
   Case "CDFACTORY":z7155.cdFactory = Children(i).Data
   Case "SESUBPROCESS":z7155.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z7155.cdSubProcess = Children(i).Data
   Case "MACHINERPM":z7155.MachineRPM = Children(i).Data
   Case "MACHINECAPACITY":z7155.MachineCapacity = Children(i).Data
   Case "ROTATIONDAYPRODUCTION":z7155.RotationDayProduction = Children(i).Data
   Case "ROTATIONONCEPRODUCTION":z7155.RotationOnceProduction = Children(i).Data
   Case "ROTATIONONCETIMEPRODUCTION":z7155.RotationOnceTimeProduction = Children(i).Data
   Case "CHECKAPPLYLIQUID":z7155.CheckApplyLiquid = Children(i).Data
   Case "RATELIQUID":z7155.RateLiquid = Children(i).Data
   Case "WDCPMDTC":z7155.WDCPMDTC = Children(i).Data
   Case "RATESODA1":z7155.RateSoda1 = Children(i).Data
   Case "RATESODA2":z7155.RateSoda2 = Children(i).Data
   Case "RATESODA3":z7155.RateSoda3 = Children(i).Data
   Case "RATEGLAUBERSALT1":z7155.RateGlauberSalt1 = Children(i).Data
   Case "RATEGLAUBERSALT2":z7155.RateGlauberSalt2 = Children(i).Data
   Case "RATEGLAUBERSALT3":z7155.RateGlauberSalt3 = Children(i).Data
   Case "GROUPMACHINE":z7155.GroupMachine = Children(i).Data
   Case "HORIZONTALPOSITION":z7155.HorizontalPosition = Children(i).Data
   Case "VERTICALPOSITION":z7155.VerticalPosition = Children(i).Data
   Case "CHECK1":z7155.ChecK1 = Children(i).Data
   Case "CHECK2":z7155.Check2 = Children(i).Data
   Case "CHECKFINALPROCESS":z7155.CheckFinalProcess = Children(i).Data
   Case "CHECKPROCESS":z7155.CheckProcess = Children(i).Data
   Case "CHECKUSE":z7155.checkUse = Children(i).Data
   Case "DISPLAYSEQ":z7155.DisplaySeq = Children(i).Data
   Case "REMARK":z7155.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7155_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7155_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7155 As T7155_AREA, Job as String, CheckClear as Boolean, MACHINECODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7155_MOVE = False

Try
    If READ_PFK7155(MACHINECODE) = True Then
                z7155 = D7155
		K7155_MOVE = True
		else
	If CheckClear  = True then z7155 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7155")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MACHINECODE":z7155.MachineCode = Children(i).Code
   Case "DEVELOPMENTCODE":z7155.DevelopmentCode = Children(i).Code
   Case "ACCCODE":z7155.AccCode = Children(i).Code
   Case "TAGNO":z7155.TagNo = Children(i).Code
   Case "MODEL":z7155.Model = Children(i).Code
   Case "SEMACHINETYPE":z7155.seMachineType = Children(i).Code
   Case "CDMACHINETYPE":z7155.cdMachineType = Children(i).Code
   Case "MACHINENAME":z7155.MachineName = Children(i).Code
   Case "MACHINENAMESIMPLY":z7155.MachineNameSimply = Children(i).Code
   Case "SEFACTORY":z7155.seFactory = Children(i).Code
   Case "CDFACTORY":z7155.cdFactory = Children(i).Code
   Case "SESUBPROCESS":z7155.seSubProcess = Children(i).Code
   Case "CDSUBPROCESS":z7155.cdSubProcess = Children(i).Code
   Case "MACHINERPM":z7155.MachineRPM = Children(i).Code
   Case "MACHINECAPACITY":z7155.MachineCapacity = Children(i).Code
   Case "ROTATIONDAYPRODUCTION":z7155.RotationDayProduction = Children(i).Code
   Case "ROTATIONONCEPRODUCTION":z7155.RotationOnceProduction = Children(i).Code
   Case "ROTATIONONCETIMEPRODUCTION":z7155.RotationOnceTimeProduction = Children(i).Code
   Case "CHECKAPPLYLIQUID":z7155.CheckApplyLiquid = Children(i).Code
   Case "RATELIQUID":z7155.RateLiquid = Children(i).Code
   Case "WDCPMDTC":z7155.WDCPMDTC = Children(i).Code
   Case "RATESODA1":z7155.RateSoda1 = Children(i).Code
   Case "RATESODA2":z7155.RateSoda2 = Children(i).Code
   Case "RATESODA3":z7155.RateSoda3 = Children(i).Code
   Case "RATEGLAUBERSALT1":z7155.RateGlauberSalt1 = Children(i).Code
   Case "RATEGLAUBERSALT2":z7155.RateGlauberSalt2 = Children(i).Code
   Case "RATEGLAUBERSALT3":z7155.RateGlauberSalt3 = Children(i).Code
   Case "GROUPMACHINE":z7155.GroupMachine = Children(i).Code
   Case "HORIZONTALPOSITION":z7155.HorizontalPosition = Children(i).Code
   Case "VERTICALPOSITION":z7155.VerticalPosition = Children(i).Code
   Case "CHECK1":z7155.ChecK1 = Children(i).Code
   Case "CHECK2":z7155.Check2 = Children(i).Code
   Case "CHECKFINALPROCESS":z7155.CheckFinalProcess = Children(i).Code
   Case "CHECKPROCESS":z7155.CheckProcess = Children(i).Code
   Case "CHECKUSE":z7155.checkUse = Children(i).Code
   Case "DISPLAYSEQ":z7155.DisplaySeq = Children(i).Code
   Case "REMARK":z7155.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MACHINECODE":z7155.MachineCode = Children(i).Data
   Case "DEVELOPMENTCODE":z7155.DevelopmentCode = Children(i).Data
   Case "ACCCODE":z7155.AccCode = Children(i).Data
   Case "TAGNO":z7155.TagNo = Children(i).Data
   Case "MODEL":z7155.Model = Children(i).Data
   Case "SEMACHINETYPE":z7155.seMachineType = Children(i).Data
   Case "CDMACHINETYPE":z7155.cdMachineType = Children(i).Data
   Case "MACHINENAME":z7155.MachineName = Children(i).Data
   Case "MACHINENAMESIMPLY":z7155.MachineNameSimply = Children(i).Data
   Case "SEFACTORY":z7155.seFactory = Children(i).Data
   Case "CDFACTORY":z7155.cdFactory = Children(i).Data
   Case "SESUBPROCESS":z7155.seSubProcess = Children(i).Data
   Case "CDSUBPROCESS":z7155.cdSubProcess = Children(i).Data
   Case "MACHINERPM":z7155.MachineRPM = Children(i).Data
   Case "MACHINECAPACITY":z7155.MachineCapacity = Children(i).Data
   Case "ROTATIONDAYPRODUCTION":z7155.RotationDayProduction = Children(i).Data
   Case "ROTATIONONCEPRODUCTION":z7155.RotationOnceProduction = Children(i).Data
   Case "ROTATIONONCETIMEPRODUCTION":z7155.RotationOnceTimeProduction = Children(i).Data
   Case "CHECKAPPLYLIQUID":z7155.CheckApplyLiquid = Children(i).Data
   Case "RATELIQUID":z7155.RateLiquid = Children(i).Data
   Case "WDCPMDTC":z7155.WDCPMDTC = Children(i).Data
   Case "RATESODA1":z7155.RateSoda1 = Children(i).Data
   Case "RATESODA2":z7155.RateSoda2 = Children(i).Data
   Case "RATESODA3":z7155.RateSoda3 = Children(i).Data
   Case "RATEGLAUBERSALT1":z7155.RateGlauberSalt1 = Children(i).Data
   Case "RATEGLAUBERSALT2":z7155.RateGlauberSalt2 = Children(i).Data
   Case "RATEGLAUBERSALT3":z7155.RateGlauberSalt3 = Children(i).Data
   Case "GROUPMACHINE":z7155.GroupMachine = Children(i).Data
   Case "HORIZONTALPOSITION":z7155.HorizontalPosition = Children(i).Data
   Case "VERTICALPOSITION":z7155.VerticalPosition = Children(i).Data
   Case "CHECK1":z7155.ChecK1 = Children(i).Data
   Case "CHECK2":z7155.Check2 = Children(i).Data
   Case "CHECKFINALPROCESS":z7155.CheckFinalProcess = Children(i).Data
   Case "CHECKPROCESS":z7155.CheckProcess = Children(i).Data
   Case "CHECKUSE":z7155.checkUse = Children(i).Data
   Case "DISPLAYSEQ":z7155.DisplaySeq = Children(i).Data
   Case "REMARK":z7155.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7155_MOVE",vbCritical)
End Try
End Function 
    
End Module 
