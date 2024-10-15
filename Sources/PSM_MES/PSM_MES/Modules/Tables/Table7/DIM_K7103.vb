'=========================================================================================================================================================
'   TABLE : (PFK7103)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7103

Structure T7103_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	Autokey	 AS Double	'			decimal		*
Public 	PreFix	 AS String	'			nvarchar(5)
Public 	TypeCode	 AS String	'			char(6)
Public 	seTypeCode	 AS String	'			char(3)
Public 	cdTypeCode	 AS String	'			char(3)
Public 	seComponentType	 AS String	'			char(3)
Public 	cdComponentType	 AS String	'			char(3)
Public 	TypeName	 AS String	'			nvarchar(50)
Public 	TypeNameRelation	 AS String	'			nvarchar(50)
Public 	TypeSimpleName	 AS String	'			nvarchar(20)
Public 	CustomerCode	 AS String	'			char(6)
Public 	ValueType1	 AS String	'			char(1)
Public 	QtyBatchS	 AS Double	'			decimal
Public 	QtyDay	 AS Double	'			decimal
Public 	QtyDayS	 AS Double	'			decimal
Public 	QtyMan	 AS Double	'			decimal
Public 	AmtAllowance	 AS Double	'			decimal
Public 	Standard	 AS String	'			nvarchar(20)
Public 	Standard1	 AS String	'			nvarchar(20)
Public 	Standard2	 AS String	'			nvarchar(20)
Public 	Standard3	 AS String	'			nvarchar(20)
Public 	Standard4	 AS String	'			nvarchar(20)
Public 	Standard5	 AS String	'			nvarchar(20)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(6)
Public 	InchargeUpdate	 AS String	'			char(6)
Public 	CheckUse	 AS String	'			char(1)
Public 	CheckComplete	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D7103 As T7103_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7103(AUTOKEY AS Double) As Boolean
    READ_PFK7103 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7103 "
    SQL = SQL & " WHERE K7103_Autokey		 =  " & Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7103_CLEAR: GoTo SKIP_READ_PFK7103
                
    Call K7103_MOVE(rd)
    READ_PFK7103 = True

SKIP_READ_PFK7103:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7103",vbCritical)
 End Try
    End Function

    Public Function READ_PFK7103_CdTypeCode(TypeCode As String, TypeCode_name As String) As Boolean
        READ_PFK7103_CdTypeCode = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7103 "
            SQL = SQL & " WHERE K7103_TypeCode		 =  " & TypeCode & "  "
            SQL = SQL & " AND K7103_cdTypeCode		 =  " & TypeCode_name & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7103_CLEAR() : GoTo SKIP_READ_PFK7103

            Call K7103_MOVE(rd)
            READ_PFK7103_CdTypeCode = True

SKIP_READ_PFK7103:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7103", vbCritical)
        End Try
    End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7103(AUTOKEY AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7103 "
    SQL = SQL & " WHERE K7103_Autokey		 =  " & Autokey & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7103",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7103(z7103 As T7103_AREA) As Boolean
    WRITE_PFK7103 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7103)
 
    SQL = " INSERT INTO PFK7103 "
    SQL = SQL & " ( "
            SQL = SQL & " K7103_PreFix,"
    SQL = SQL & " K7103_TypeCode," 
    SQL = SQL & " K7103_seTypeCode," 
    SQL = SQL & " K7103_cdTypeCode," 
    SQL = SQL & " K7103_seComponentType," 
    SQL = SQL & " K7103_cdComponentType," 
    SQL = SQL & " K7103_TypeName," 
    SQL = SQL & " K7103_TypeNameRelation," 
    SQL = SQL & " K7103_TypeSimpleName," 
    SQL = SQL & " K7103_CustomerCode," 
    SQL = SQL & " K7103_ValueType1," 
    SQL = SQL & " K7103_QtyBatchS," 
    SQL = SQL & " K7103_QtyDay," 
    SQL = SQL & " K7103_QtyDayS," 
    SQL = SQL & " K7103_QtyMan," 
    SQL = SQL & " K7103_AmtAllowance," 
    SQL = SQL & " K7103_Standard," 
    SQL = SQL & " K7103_Standard1," 
    SQL = SQL & " K7103_Standard2," 
    SQL = SQL & " K7103_Standard3," 
    SQL = SQL & " K7103_Standard4," 
    SQL = SQL & " K7103_Standard5," 
    SQL = SQL & " K7103_DateInsert," 
    SQL = SQL & " K7103_DateUpdate," 
    SQL = SQL & " K7103_InchargeInsert," 
    SQL = SQL & " K7103_InchargeUpdate," 
    SQL = SQL & " K7103_CheckUse," 
    SQL = SQL & " K7103_CheckComplete," 
    SQL = SQL & " K7103_Remark " 
    SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z7103.PreFix) & "', "
    SQL = SQL & "  N'" & FormatSQL(z7103.TypeCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7103.seTypeCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7103.cdTypeCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7103.seComponentType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7103.cdComponentType) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7103.TypeName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7103.TypeNameRelation) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7103.TypeSimpleName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7103.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7103.ValueType1) & "', "  
    SQL = SQL & "   " & FormatSQL(z7103.QtyBatchS) & ", "  
    SQL = SQL & "   " & FormatSQL(z7103.QtyDay) & ", "  
    SQL = SQL & "   " & FormatSQL(z7103.QtyDayS) & ", "  
    SQL = SQL & "   " & FormatSQL(z7103.QtyMan) & ", "  
    SQL = SQL & "   " & FormatSQL(z7103.AmtAllowance) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7103.Standard) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7103.Standard1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7103.Standard2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7103.Standard3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7103.Standard4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7103.Standard5) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7103.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7103.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7103.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7103.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7103.CheckUse) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7103.CheckComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7103.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7103 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7103",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7103(z7103 As T7103_AREA) As Boolean
    REWRITE_PFK7103 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7103)
   
    SQL = " UPDATE PFK7103 SET "
    SQL = SQL & "    K7103_PreFix      = N'" & FormatSQL(z7103.PreFix) & "', " 
    SQL = SQL & "    K7103_TypeCode      = N'" & FormatSQL(z7103.TypeCode) & "', " 
    SQL = SQL & "    K7103_seTypeCode      = N'" & FormatSQL(z7103.seTypeCode) & "', " 
    SQL = SQL & "    K7103_cdTypeCode      = N'" & FormatSQL(z7103.cdTypeCode) & "', " 
    SQL = SQL & "    K7103_seComponentType      = N'" & FormatSQL(z7103.seComponentType) & "', " 
    SQL = SQL & "    K7103_cdComponentType      = N'" & FormatSQL(z7103.cdComponentType) & "', " 
    SQL = SQL & "    K7103_TypeName      = N'" & FormatSQL(z7103.TypeName) & "', " 
    SQL = SQL & "    K7103_TypeNameRelation      = N'" & FormatSQL(z7103.TypeNameRelation) & "', " 
    SQL = SQL & "    K7103_TypeSimpleName      = N'" & FormatSQL(z7103.TypeSimpleName) & "', " 
    SQL = SQL & "    K7103_CustomerCode      = N'" & FormatSQL(z7103.CustomerCode) & "', " 
    SQL = SQL & "    K7103_ValueType1      = N'" & FormatSQL(z7103.ValueType1) & "', " 
    SQL = SQL & "    K7103_QtyBatchS      =  " & FormatSQL(z7103.QtyBatchS) & ", " 
    SQL = SQL & "    K7103_QtyDay      =  " & FormatSQL(z7103.QtyDay) & ", " 
    SQL = SQL & "    K7103_QtyDayS      =  " & FormatSQL(z7103.QtyDayS) & ", " 
    SQL = SQL & "    K7103_QtyMan      =  " & FormatSQL(z7103.QtyMan) & ", " 
    SQL = SQL & "    K7103_AmtAllowance      =  " & FormatSQL(z7103.AmtAllowance) & ", " 
    SQL = SQL & "    K7103_Standard      = N'" & FormatSQL(z7103.Standard) & "', " 
    SQL = SQL & "    K7103_Standard1      = N'" & FormatSQL(z7103.Standard1) & "', " 
    SQL = SQL & "    K7103_Standard2      = N'" & FormatSQL(z7103.Standard2) & "', " 
    SQL = SQL & "    K7103_Standard3      = N'" & FormatSQL(z7103.Standard3) & "', " 
    SQL = SQL & "    K7103_Standard4      = N'" & FormatSQL(z7103.Standard4) & "', " 
    SQL = SQL & "    K7103_Standard5      = N'" & FormatSQL(z7103.Standard5) & "', " 
    SQL = SQL & "    K7103_DateInsert      = N'" & FormatSQL(z7103.DateInsert) & "', " 
    SQL = SQL & "    K7103_DateUpdate      = N'" & FormatSQL(z7103.DateUpdate) & "', " 
    SQL = SQL & "    K7103_InchargeInsert      = N'" & FormatSQL(z7103.InchargeInsert) & "', " 
    SQL = SQL & "    K7103_InchargeUpdate      = N'" & FormatSQL(z7103.InchargeUpdate) & "', " 
    SQL = SQL & "    K7103_CheckUse      = N'" & FormatSQL(z7103.CheckUse) & "', " 
    SQL = SQL & "    K7103_CheckComplete      = N'" & FormatSQL(z7103.CheckComplete) & "', " 
    SQL = SQL & "    K7103_Remark      = N'" & FormatSQL(z7103.Remark) & "'  " 
    SQL = SQL & " WHERE K7103_Autokey		 =  " & z7103.Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7103 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7103",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7103(z7103 As T7103_AREA) As Boolean
    DELETE_PFK7103 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7103 "
    SQL = SQL & " WHERE K7103_Autokey		 =  " & z7103.Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7103 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7103",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7103_CLEAR()
Try
    
    D7103.Autokey = 0 
   D7103.PreFix = ""
   D7103.TypeCode = ""
   D7103.seTypeCode = ""
   D7103.cdTypeCode = ""
   D7103.seComponentType = ""
   D7103.cdComponentType = ""
   D7103.TypeName = ""
   D7103.TypeNameRelation = ""
   D7103.TypeSimpleName = ""
   D7103.CustomerCode = ""
   D7103.ValueType1 = ""
    D7103.QtyBatchS = 0 
    D7103.QtyDay = 0 
    D7103.QtyDayS = 0 
    D7103.QtyMan = 0 
    D7103.AmtAllowance = 0 
   D7103.Standard = ""
   D7103.Standard1 = ""
   D7103.Standard2 = ""
   D7103.Standard3 = ""
   D7103.Standard4 = ""
   D7103.Standard5 = ""
   D7103.DateInsert = ""
   D7103.DateUpdate = ""
   D7103.InchargeInsert = ""
   D7103.InchargeUpdate = ""
   D7103.CheckUse = ""
   D7103.CheckComplete = ""
   D7103.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7103_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7103 As T7103_AREA)
Try
    
    x7103.Autokey = trim$(  x7103.Autokey)
    x7103.PreFix = trim$(  x7103.PreFix)
    x7103.TypeCode = trim$(  x7103.TypeCode)
    x7103.seTypeCode = trim$(  x7103.seTypeCode)
    x7103.cdTypeCode = trim$(  x7103.cdTypeCode)
    x7103.seComponentType = trim$(  x7103.seComponentType)
    x7103.cdComponentType = trim$(  x7103.cdComponentType)
    x7103.TypeName = trim$(  x7103.TypeName)
    x7103.TypeNameRelation = trim$(  x7103.TypeNameRelation)
    x7103.TypeSimpleName = trim$(  x7103.TypeSimpleName)
    x7103.CustomerCode = trim$(  x7103.CustomerCode)
    x7103.ValueType1 = trim$(  x7103.ValueType1)
    x7103.QtyBatchS = trim$(  x7103.QtyBatchS)
    x7103.QtyDay = trim$(  x7103.QtyDay)
    x7103.QtyDayS = trim$(  x7103.QtyDayS)
    x7103.QtyMan = trim$(  x7103.QtyMan)
    x7103.AmtAllowance = trim$(  x7103.AmtAllowance)
    x7103.Standard = trim$(  x7103.Standard)
    x7103.Standard1 = trim$(  x7103.Standard1)
    x7103.Standard2 = trim$(  x7103.Standard2)
    x7103.Standard3 = trim$(  x7103.Standard3)
    x7103.Standard4 = trim$(  x7103.Standard4)
    x7103.Standard5 = trim$(  x7103.Standard5)
    x7103.DateInsert = trim$(  x7103.DateInsert)
    x7103.DateUpdate = trim$(  x7103.DateUpdate)
    x7103.InchargeInsert = trim$(  x7103.InchargeInsert)
    x7103.InchargeUpdate = trim$(  x7103.InchargeUpdate)
    x7103.CheckUse = trim$(  x7103.CheckUse)
    x7103.CheckComplete = trim$(  x7103.CheckComplete)
    x7103.Remark = trim$(  x7103.Remark)
     
    If trim$( x7103.Autokey ) = "" Then x7103.Autokey = 0 
    If trim$( x7103.PreFix ) = "" Then x7103.PreFix = Space(1) 
    If trim$( x7103.TypeCode ) = "" Then x7103.TypeCode = Space(1) 
    If trim$( x7103.seTypeCode ) = "" Then x7103.seTypeCode = Space(1) 
    If trim$( x7103.cdTypeCode ) = "" Then x7103.cdTypeCode = Space(1) 
    If trim$( x7103.seComponentType ) = "" Then x7103.seComponentType = Space(1) 
    If trim$( x7103.cdComponentType ) = "" Then x7103.cdComponentType = Space(1) 
    If trim$( x7103.TypeName ) = "" Then x7103.TypeName = Space(1) 
    If trim$( x7103.TypeNameRelation ) = "" Then x7103.TypeNameRelation = Space(1) 
    If trim$( x7103.TypeSimpleName ) = "" Then x7103.TypeSimpleName = Space(1) 
    If trim$( x7103.CustomerCode ) = "" Then x7103.CustomerCode = Space(1) 
    If trim$( x7103.ValueType1 ) = "" Then x7103.ValueType1 = Space(1) 
    If trim$( x7103.QtyBatchS ) = "" Then x7103.QtyBatchS = 0 
    If trim$( x7103.QtyDay ) = "" Then x7103.QtyDay = 0 
    If trim$( x7103.QtyDayS ) = "" Then x7103.QtyDayS = 0 
    If trim$( x7103.QtyMan ) = "" Then x7103.QtyMan = 0 
    If trim$( x7103.AmtAllowance ) = "" Then x7103.AmtAllowance = 0 
    If trim$( x7103.Standard ) = "" Then x7103.Standard = Space(1) 
    If trim$( x7103.Standard1 ) = "" Then x7103.Standard1 = Space(1) 
    If trim$( x7103.Standard2 ) = "" Then x7103.Standard2 = Space(1) 
    If trim$( x7103.Standard3 ) = "" Then x7103.Standard3 = Space(1) 
    If trim$( x7103.Standard4 ) = "" Then x7103.Standard4 = Space(1) 
    If trim$( x7103.Standard5 ) = "" Then x7103.Standard5 = Space(1) 
    If trim$( x7103.DateInsert ) = "" Then x7103.DateInsert = Space(1) 
    If trim$( x7103.DateUpdate ) = "" Then x7103.DateUpdate = Space(1) 
    If trim$( x7103.InchargeInsert ) = "" Then x7103.InchargeInsert = Space(1) 
    If trim$( x7103.InchargeUpdate ) = "" Then x7103.InchargeUpdate = Space(1) 
    If trim$( x7103.CheckUse ) = "" Then x7103.CheckUse = Space(1) 
    If trim$( x7103.CheckComplete ) = "" Then x7103.CheckComplete = Space(1) 
    If trim$( x7103.Remark ) = "" Then x7103.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7103_MOVE(rs7103 As SqlClient.SqlDataReader)
Try

    call D7103_CLEAR()   

    If IsdbNull(rs7103!K7103_Autokey) = False Then D7103.Autokey = Trim$(rs7103!K7103_Autokey)
    If IsdbNull(rs7103!K7103_PreFix) = False Then D7103.PreFix = Trim$(rs7103!K7103_PreFix)
    If IsdbNull(rs7103!K7103_TypeCode) = False Then D7103.TypeCode = Trim$(rs7103!K7103_TypeCode)
    If IsdbNull(rs7103!K7103_seTypeCode) = False Then D7103.seTypeCode = Trim$(rs7103!K7103_seTypeCode)
    If IsdbNull(rs7103!K7103_cdTypeCode) = False Then D7103.cdTypeCode = Trim$(rs7103!K7103_cdTypeCode)
    If IsdbNull(rs7103!K7103_seComponentType) = False Then D7103.seComponentType = Trim$(rs7103!K7103_seComponentType)
    If IsdbNull(rs7103!K7103_cdComponentType) = False Then D7103.cdComponentType = Trim$(rs7103!K7103_cdComponentType)
    If IsdbNull(rs7103!K7103_TypeName) = False Then D7103.TypeName = Trim$(rs7103!K7103_TypeName)
    If IsdbNull(rs7103!K7103_TypeNameRelation) = False Then D7103.TypeNameRelation = Trim$(rs7103!K7103_TypeNameRelation)
    If IsdbNull(rs7103!K7103_TypeSimpleName) = False Then D7103.TypeSimpleName = Trim$(rs7103!K7103_TypeSimpleName)
    If IsdbNull(rs7103!K7103_CustomerCode) = False Then D7103.CustomerCode = Trim$(rs7103!K7103_CustomerCode)
    If IsdbNull(rs7103!K7103_ValueType1) = False Then D7103.ValueType1 = Trim$(rs7103!K7103_ValueType1)
    If IsdbNull(rs7103!K7103_QtyBatchS) = False Then D7103.QtyBatchS = Trim$(rs7103!K7103_QtyBatchS)
    If IsdbNull(rs7103!K7103_QtyDay) = False Then D7103.QtyDay = Trim$(rs7103!K7103_QtyDay)
    If IsdbNull(rs7103!K7103_QtyDayS) = False Then D7103.QtyDayS = Trim$(rs7103!K7103_QtyDayS)
    If IsdbNull(rs7103!K7103_QtyMan) = False Then D7103.QtyMan = Trim$(rs7103!K7103_QtyMan)
    If IsdbNull(rs7103!K7103_AmtAllowance) = False Then D7103.AmtAllowance = Trim$(rs7103!K7103_AmtAllowance)
    If IsdbNull(rs7103!K7103_Standard) = False Then D7103.Standard = Trim$(rs7103!K7103_Standard)
    If IsdbNull(rs7103!K7103_Standard1) = False Then D7103.Standard1 = Trim$(rs7103!K7103_Standard1)
    If IsdbNull(rs7103!K7103_Standard2) = False Then D7103.Standard2 = Trim$(rs7103!K7103_Standard2)
    If IsdbNull(rs7103!K7103_Standard3) = False Then D7103.Standard3 = Trim$(rs7103!K7103_Standard3)
    If IsdbNull(rs7103!K7103_Standard4) = False Then D7103.Standard4 = Trim$(rs7103!K7103_Standard4)
    If IsdbNull(rs7103!K7103_Standard5) = False Then D7103.Standard5 = Trim$(rs7103!K7103_Standard5)
    If IsdbNull(rs7103!K7103_DateInsert) = False Then D7103.DateInsert = Trim$(rs7103!K7103_DateInsert)
    If IsdbNull(rs7103!K7103_DateUpdate) = False Then D7103.DateUpdate = Trim$(rs7103!K7103_DateUpdate)
    If IsdbNull(rs7103!K7103_InchargeInsert) = False Then D7103.InchargeInsert = Trim$(rs7103!K7103_InchargeInsert)
    If IsdbNull(rs7103!K7103_InchargeUpdate) = False Then D7103.InchargeUpdate = Trim$(rs7103!K7103_InchargeUpdate)
    If IsdbNull(rs7103!K7103_CheckUse) = False Then D7103.CheckUse = Trim$(rs7103!K7103_CheckUse)
    If IsdbNull(rs7103!K7103_CheckComplete) = False Then D7103.CheckComplete = Trim$(rs7103!K7103_CheckComplete)
    If IsdbNull(rs7103!K7103_Remark) = False Then D7103.Remark = Trim$(rs7103!K7103_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7103_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7103_MOVE(rs7103 As DataRow)
Try

    call D7103_CLEAR()   

    If IsdbNull(rs7103!K7103_Autokey) = False Then D7103.Autokey = Trim$(rs7103!K7103_Autokey)
    If IsdbNull(rs7103!K7103_PreFix) = False Then D7103.PreFix = Trim$(rs7103!K7103_PreFix)
    If IsdbNull(rs7103!K7103_TypeCode) = False Then D7103.TypeCode = Trim$(rs7103!K7103_TypeCode)
    If IsdbNull(rs7103!K7103_seTypeCode) = False Then D7103.seTypeCode = Trim$(rs7103!K7103_seTypeCode)
    If IsdbNull(rs7103!K7103_cdTypeCode) = False Then D7103.cdTypeCode = Trim$(rs7103!K7103_cdTypeCode)
    If IsdbNull(rs7103!K7103_seComponentType) = False Then D7103.seComponentType = Trim$(rs7103!K7103_seComponentType)
    If IsdbNull(rs7103!K7103_cdComponentType) = False Then D7103.cdComponentType = Trim$(rs7103!K7103_cdComponentType)
    If IsdbNull(rs7103!K7103_TypeName) = False Then D7103.TypeName = Trim$(rs7103!K7103_TypeName)
    If IsdbNull(rs7103!K7103_TypeNameRelation) = False Then D7103.TypeNameRelation = Trim$(rs7103!K7103_TypeNameRelation)
    If IsdbNull(rs7103!K7103_TypeSimpleName) = False Then D7103.TypeSimpleName = Trim$(rs7103!K7103_TypeSimpleName)
    If IsdbNull(rs7103!K7103_CustomerCode) = False Then D7103.CustomerCode = Trim$(rs7103!K7103_CustomerCode)
    If IsdbNull(rs7103!K7103_ValueType1) = False Then D7103.ValueType1 = Trim$(rs7103!K7103_ValueType1)
    If IsdbNull(rs7103!K7103_QtyBatchS) = False Then D7103.QtyBatchS = Trim$(rs7103!K7103_QtyBatchS)
    If IsdbNull(rs7103!K7103_QtyDay) = False Then D7103.QtyDay = Trim$(rs7103!K7103_QtyDay)
    If IsdbNull(rs7103!K7103_QtyDayS) = False Then D7103.QtyDayS = Trim$(rs7103!K7103_QtyDayS)
    If IsdbNull(rs7103!K7103_QtyMan) = False Then D7103.QtyMan = Trim$(rs7103!K7103_QtyMan)
    If IsdbNull(rs7103!K7103_AmtAllowance) = False Then D7103.AmtAllowance = Trim$(rs7103!K7103_AmtAllowance)
    If IsdbNull(rs7103!K7103_Standard) = False Then D7103.Standard = Trim$(rs7103!K7103_Standard)
    If IsdbNull(rs7103!K7103_Standard1) = False Then D7103.Standard1 = Trim$(rs7103!K7103_Standard1)
    If IsdbNull(rs7103!K7103_Standard2) = False Then D7103.Standard2 = Trim$(rs7103!K7103_Standard2)
    If IsdbNull(rs7103!K7103_Standard3) = False Then D7103.Standard3 = Trim$(rs7103!K7103_Standard3)
    If IsdbNull(rs7103!K7103_Standard4) = False Then D7103.Standard4 = Trim$(rs7103!K7103_Standard4)
    If IsdbNull(rs7103!K7103_Standard5) = False Then D7103.Standard5 = Trim$(rs7103!K7103_Standard5)
    If IsdbNull(rs7103!K7103_DateInsert) = False Then D7103.DateInsert = Trim$(rs7103!K7103_DateInsert)
    If IsdbNull(rs7103!K7103_DateUpdate) = False Then D7103.DateUpdate = Trim$(rs7103!K7103_DateUpdate)
    If IsdbNull(rs7103!K7103_InchargeInsert) = False Then D7103.InchargeInsert = Trim$(rs7103!K7103_InchargeInsert)
    If IsdbNull(rs7103!K7103_InchargeUpdate) = False Then D7103.InchargeUpdate = Trim$(rs7103!K7103_InchargeUpdate)
    If IsdbNull(rs7103!K7103_CheckUse) = False Then D7103.CheckUse = Trim$(rs7103!K7103_CheckUse)
    If IsdbNull(rs7103!K7103_CheckComplete) = False Then D7103.CheckComplete = Trim$(rs7103!K7103_CheckComplete)
    If IsdbNull(rs7103!K7103_Remark) = False Then D7103.Remark = Trim$(rs7103!K7103_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7103_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7103_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7103 As T7103_AREA, AUTOKEY AS Double) as Boolean

K7103_MOVE = False

Try
    If READ_PFK7103(AUTOKEY) = True Then
                z7103 = D7103
		K7103_MOVE = True
		else
	z7103 = nothing
     End If

     If  getColumIndex(spr,"Autokey") > -1 then z7103.Autokey = getDataM(spr, getColumIndex(spr,"Autokey"), xRow)
     If  getColumIndex(spr,"PreFix") > -1 then z7103.PreFix = getDataM(spr, getColumIndex(spr,"PreFix"), xRow)
     If  getColumIndex(spr,"TypeCode") > -1 then z7103.TypeCode = getDataM(spr, getColumIndex(spr,"TypeCode"), xRow)
     If  getColumIndex(spr,"seTypeCode") > -1 then z7103.seTypeCode = getDataM(spr, getColumIndex(spr,"seTypeCode"), xRow)
     If  getColumIndex(spr,"cdTypeCode") > -1 then z7103.cdTypeCode = getDataM(spr, getColumIndex(spr,"cdTypeCode"), xRow)
     If  getColumIndex(spr,"seComponentType") > -1 then z7103.seComponentType = getDataM(spr, getColumIndex(spr,"seComponentType"), xRow)
     If  getColumIndex(spr,"cdComponentType") > -1 then z7103.cdComponentType = getDataM(spr, getColumIndex(spr,"cdComponentType"), xRow)
     If  getColumIndex(spr,"TypeName") > -1 then z7103.TypeName = getDataM(spr, getColumIndex(spr,"TypeName"), xRow)
     If  getColumIndex(spr,"TypeNameRelation") > -1 then z7103.TypeNameRelation = getDataM(spr, getColumIndex(spr,"TypeNameRelation"), xRow)
     If  getColumIndex(spr,"TypeSimpleName") > -1 then z7103.TypeSimpleName = getDataM(spr, getColumIndex(spr,"TypeSimpleName"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7103.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"ValueType1") > -1 then z7103.ValueType1 = getDataM(spr, getColumIndex(spr,"ValueType1"), xRow)
     If  getColumIndex(spr,"QtyBatchS") > -1 then z7103.QtyBatchS = getDataM(spr, getColumIndex(spr,"QtyBatchS"), xRow)
     If  getColumIndex(spr,"QtyDay") > -1 then z7103.QtyDay = getDataM(spr, getColumIndex(spr,"QtyDay"), xRow)
     If  getColumIndex(spr,"QtyDayS") > -1 then z7103.QtyDayS = getDataM(spr, getColumIndex(spr,"QtyDayS"), xRow)
     If  getColumIndex(spr,"QtyMan") > -1 then z7103.QtyMan = getDataM(spr, getColumIndex(spr,"QtyMan"), xRow)
     If  getColumIndex(spr,"AmtAllowance") > -1 then z7103.AmtAllowance = getDataM(spr, getColumIndex(spr,"AmtAllowance"), xRow)
     If  getColumIndex(spr,"Standard") > -1 then z7103.Standard = getDataM(spr, getColumIndex(spr,"Standard"), xRow)
     If  getColumIndex(spr,"Standard1") > -1 then z7103.Standard1 = getDataM(spr, getColumIndex(spr,"Standard1"), xRow)
     If  getColumIndex(spr,"Standard2") > -1 then z7103.Standard2 = getDataM(spr, getColumIndex(spr,"Standard2"), xRow)
     If  getColumIndex(spr,"Standard3") > -1 then z7103.Standard3 = getDataM(spr, getColumIndex(spr,"Standard3"), xRow)
     If  getColumIndex(spr,"Standard4") > -1 then z7103.Standard4 = getDataM(spr, getColumIndex(spr,"Standard4"), xRow)
     If  getColumIndex(spr,"Standard5") > -1 then z7103.Standard5 = getDataM(spr, getColumIndex(spr,"Standard5"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7103.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7103.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7103.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7103.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7103.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z7103.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7103.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7103_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7103_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7103 As T7103_AREA,CheckClear as Boolean,AUTOKEY AS Double) as Boolean

K7103_MOVE = False

Try
    If READ_PFK7103(AUTOKEY) = True Then
                z7103 = D7103
		K7103_MOVE = True
		else
	If CheckClear  = True then z7103 = nothing
     End If

     If  getColumIndex(spr,"Autokey") > -1 then z7103.Autokey = getDataM(spr, getColumIndex(spr,"Autokey"), xRow)
     If  getColumIndex(spr,"PreFix") > -1 then z7103.PreFix = getDataM(spr, getColumIndex(spr,"PreFix"), xRow)
     If  getColumIndex(spr,"TypeCode") > -1 then z7103.TypeCode = getDataM(spr, getColumIndex(spr,"TypeCode"), xRow)
     If  getColumIndex(spr,"seTypeCode") > -1 then z7103.seTypeCode = getDataM(spr, getColumIndex(spr,"seTypeCode"), xRow)
     If  getColumIndex(spr,"cdTypeCode") > -1 then z7103.cdTypeCode = getDataM(spr, getColumIndex(spr,"cdTypeCode"), xRow)
     If  getColumIndex(spr,"seComponentType") > -1 then z7103.seComponentType = getDataM(spr, getColumIndex(spr,"seComponentType"), xRow)
     If  getColumIndex(spr,"cdComponentType") > -1 then z7103.cdComponentType = getDataM(spr, getColumIndex(spr,"cdComponentType"), xRow)
     If  getColumIndex(spr,"TypeName") > -1 then z7103.TypeName = getDataM(spr, getColumIndex(spr,"TypeName"), xRow)
     If  getColumIndex(spr,"TypeNameRelation") > -1 then z7103.TypeNameRelation = getDataM(spr, getColumIndex(spr,"TypeNameRelation"), xRow)
     If  getColumIndex(spr,"TypeSimpleName") > -1 then z7103.TypeSimpleName = getDataM(spr, getColumIndex(spr,"TypeSimpleName"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7103.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"ValueType1") > -1 then z7103.ValueType1 = getDataM(spr, getColumIndex(spr,"ValueType1"), xRow)
     If  getColumIndex(spr,"QtyBatchS") > -1 then z7103.QtyBatchS = getDataM(spr, getColumIndex(spr,"QtyBatchS"), xRow)
     If  getColumIndex(spr,"QtyDay") > -1 then z7103.QtyDay = getDataM(spr, getColumIndex(spr,"QtyDay"), xRow)
     If  getColumIndex(spr,"QtyDayS") > -1 then z7103.QtyDayS = getDataM(spr, getColumIndex(spr,"QtyDayS"), xRow)
     If  getColumIndex(spr,"QtyMan") > -1 then z7103.QtyMan = getDataM(spr, getColumIndex(spr,"QtyMan"), xRow)
     If  getColumIndex(spr,"AmtAllowance") > -1 then z7103.AmtAllowance = getDataM(spr, getColumIndex(spr,"AmtAllowance"), xRow)
     If  getColumIndex(spr,"Standard") > -1 then z7103.Standard = getDataM(spr, getColumIndex(spr,"Standard"), xRow)
     If  getColumIndex(spr,"Standard1") > -1 then z7103.Standard1 = getDataM(spr, getColumIndex(spr,"Standard1"), xRow)
     If  getColumIndex(spr,"Standard2") > -1 then z7103.Standard2 = getDataM(spr, getColumIndex(spr,"Standard2"), xRow)
     If  getColumIndex(spr,"Standard3") > -1 then z7103.Standard3 = getDataM(spr, getColumIndex(spr,"Standard3"), xRow)
     If  getColumIndex(spr,"Standard4") > -1 then z7103.Standard4 = getDataM(spr, getColumIndex(spr,"Standard4"), xRow)
     If  getColumIndex(spr,"Standard5") > -1 then z7103.Standard5 = getDataM(spr, getColumIndex(spr,"Standard5"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z7103.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z7103.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z7103.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z7103.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"CheckUse") > -1 then z7103.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
     If  getColumIndex(spr,"CheckComplete") > -1 then z7103.CheckComplete = getDataM(spr, getColumIndex(spr,"CheckComplete"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7103.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7103_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7103_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7103 As T7103_AREA, Job as String, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7103_MOVE = False

Try
    If READ_PFK7103(AUTOKEY) = True Then
                z7103 = D7103
		K7103_MOVE = True
		else
	z7103 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7103")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z7103.Autokey = Children(i).Code
   Case "PREFIX":z7103.PreFix = Children(i).Code
   Case "TYPECODE":z7103.TypeCode = Children(i).Code
   Case "SETYPECODE":z7103.seTypeCode = Children(i).Code
   Case "CDTYPECODE":z7103.cdTypeCode = Children(i).Code
   Case "SECOMPONENTTYPE":z7103.seComponentType = Children(i).Code
   Case "CDCOMPONENTTYPE":z7103.cdComponentType = Children(i).Code
   Case "TYPENAME":z7103.TypeName = Children(i).Code
   Case "TYPENAMERELATION":z7103.TypeNameRelation = Children(i).Code
   Case "TYPESIMPLENAME":z7103.TypeSimpleName = Children(i).Code
   Case "CUSTOMERCODE":z7103.CustomerCode = Children(i).Code
   Case "VALUETYPE1":z7103.ValueType1 = Children(i).Code
   Case "QTYBATCHS":z7103.QtyBatchS = Children(i).Code
   Case "QTYDAY":z7103.QtyDay = Children(i).Code
   Case "QTYDAYS":z7103.QtyDayS = Children(i).Code
   Case "QTYMAN":z7103.QtyMan = Children(i).Code
   Case "AMTALLOWANCE":z7103.AmtAllowance = Children(i).Code
   Case "STANDARD":z7103.Standard = Children(i).Code
   Case "STANDARD1":z7103.Standard1 = Children(i).Code
   Case "STANDARD2":z7103.Standard2 = Children(i).Code
   Case "STANDARD3":z7103.Standard3 = Children(i).Code
   Case "STANDARD4":z7103.Standard4 = Children(i).Code
   Case "STANDARD5":z7103.Standard5 = Children(i).Code
   Case "DATEINSERT":z7103.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7103.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7103.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7103.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7103.CheckUse = Children(i).Code
   Case "CHECKCOMPLETE":z7103.CheckComplete = Children(i).Code
   Case "REMARK":z7103.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z7103.Autokey = Children(i).Data
   Case "PREFIX":z7103.PreFix = Children(i).Data
   Case "TYPECODE":z7103.TypeCode = Children(i).Data
   Case "SETYPECODE":z7103.seTypeCode = Children(i).Data
   Case "CDTYPECODE":z7103.cdTypeCode = Children(i).Data
   Case "SECOMPONENTTYPE":z7103.seComponentType = Children(i).Data
   Case "CDCOMPONENTTYPE":z7103.cdComponentType = Children(i).Data
   Case "TYPENAME":z7103.TypeName = Children(i).Data
   Case "TYPENAMERELATION":z7103.TypeNameRelation = Children(i).Data
   Case "TYPESIMPLENAME":z7103.TypeSimpleName = Children(i).Data
   Case "CUSTOMERCODE":z7103.CustomerCode = Children(i).Data
   Case "VALUETYPE1":z7103.ValueType1 = Children(i).Data
   Case "QTYBATCHS":z7103.QtyBatchS = Children(i).Data
   Case "QTYDAY":z7103.QtyDay = Children(i).Data
   Case "QTYDAYS":z7103.QtyDayS = Children(i).Data
   Case "QTYMAN":z7103.QtyMan = Children(i).Data
   Case "AMTALLOWANCE":z7103.AmtAllowance = Children(i).Data
   Case "STANDARD":z7103.Standard = Children(i).Data
   Case "STANDARD1":z7103.Standard1 = Children(i).Data
   Case "STANDARD2":z7103.Standard2 = Children(i).Data
   Case "STANDARD3":z7103.Standard3 = Children(i).Data
   Case "STANDARD4":z7103.Standard4 = Children(i).Data
   Case "STANDARD5":z7103.Standard5 = Children(i).Data
   Case "DATEINSERT":z7103.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7103.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7103.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7103.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7103.CheckUse = Children(i).Data
   Case "CHECKCOMPLETE":z7103.CheckComplete = Children(i).Data
   Case "REMARK":z7103.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7103_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7103_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7103 As T7103_AREA, Job as String, CheckClear as Boolean, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7103_MOVE = False

Try
    If READ_PFK7103(AUTOKEY) = True Then
                z7103 = D7103
		K7103_MOVE = True
		else
	If CheckClear  = True then z7103 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7103")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z7103.Autokey = Children(i).Code
   Case "PREFIX":z7103.PreFix = Children(i).Code
   Case "TYPECODE":z7103.TypeCode = Children(i).Code
   Case "SETYPECODE":z7103.seTypeCode = Children(i).Code
   Case "CDTYPECODE":z7103.cdTypeCode = Children(i).Code
   Case "SECOMPONENTTYPE":z7103.seComponentType = Children(i).Code
   Case "CDCOMPONENTTYPE":z7103.cdComponentType = Children(i).Code
   Case "TYPENAME":z7103.TypeName = Children(i).Code
   Case "TYPENAMERELATION":z7103.TypeNameRelation = Children(i).Code
   Case "TYPESIMPLENAME":z7103.TypeSimpleName = Children(i).Code
   Case "CUSTOMERCODE":z7103.CustomerCode = Children(i).Code
   Case "VALUETYPE1":z7103.ValueType1 = Children(i).Code
   Case "QTYBATCHS":z7103.QtyBatchS = Children(i).Code
   Case "QTYDAY":z7103.QtyDay = Children(i).Code
   Case "QTYDAYS":z7103.QtyDayS = Children(i).Code
   Case "QTYMAN":z7103.QtyMan = Children(i).Code
   Case "AMTALLOWANCE":z7103.AmtAllowance = Children(i).Code
   Case "STANDARD":z7103.Standard = Children(i).Code
   Case "STANDARD1":z7103.Standard1 = Children(i).Code
   Case "STANDARD2":z7103.Standard2 = Children(i).Code
   Case "STANDARD3":z7103.Standard3 = Children(i).Code
   Case "STANDARD4":z7103.Standard4 = Children(i).Code
   Case "STANDARD5":z7103.Standard5 = Children(i).Code
   Case "DATEINSERT":z7103.DateInsert = Children(i).Code
   Case "DATEUPDATE":z7103.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z7103.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z7103.InchargeUpdate = Children(i).Code
   Case "CHECKUSE":z7103.CheckUse = Children(i).Code
   Case "CHECKCOMPLETE":z7103.CheckComplete = Children(i).Code
   Case "REMARK":z7103.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z7103.Autokey = Children(i).Data
   Case "PREFIX":z7103.PreFix = Children(i).Data
   Case "TYPECODE":z7103.TypeCode = Children(i).Data
   Case "SETYPECODE":z7103.seTypeCode = Children(i).Data
   Case "CDTYPECODE":z7103.cdTypeCode = Children(i).Data
   Case "SECOMPONENTTYPE":z7103.seComponentType = Children(i).Data
   Case "CDCOMPONENTTYPE":z7103.cdComponentType = Children(i).Data
   Case "TYPENAME":z7103.TypeName = Children(i).Data
   Case "TYPENAMERELATION":z7103.TypeNameRelation = Children(i).Data
   Case "TYPESIMPLENAME":z7103.TypeSimpleName = Children(i).Data
   Case "CUSTOMERCODE":z7103.CustomerCode = Children(i).Data
   Case "VALUETYPE1":z7103.ValueType1 = Children(i).Data
   Case "QTYBATCHS":z7103.QtyBatchS = Children(i).Data
   Case "QTYDAY":z7103.QtyDay = Children(i).Data
   Case "QTYDAYS":z7103.QtyDayS = Children(i).Data
   Case "QTYMAN":z7103.QtyMan = Children(i).Data
   Case "AMTALLOWANCE":z7103.AmtAllowance = Children(i).Data
   Case "STANDARD":z7103.Standard = Children(i).Data
   Case "STANDARD1":z7103.Standard1 = Children(i).Data
   Case "STANDARD2":z7103.Standard2 = Children(i).Data
   Case "STANDARD3":z7103.Standard3 = Children(i).Data
   Case "STANDARD4":z7103.Standard4 = Children(i).Data
   Case "STANDARD5":z7103.Standard5 = Children(i).Data
   Case "DATEINSERT":z7103.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7103.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7103.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7103.InchargeUpdate = Children(i).Data
   Case "CHECKUSE":z7103.CheckUse = Children(i).Data
   Case "CHECKCOMPLETE":z7103.CheckComplete = Children(i).Data
   Case "REMARK":z7103.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7103_MOVE",vbCritical)
End Try
End Function 
    
End Module 
