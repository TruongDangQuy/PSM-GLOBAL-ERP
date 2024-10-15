'=========================================================================================================================================================
'   TABLE : (PFK7180)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7180

Structure T7180_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ProcessDyeingSel	 AS String	'			char(3)		*
Public 	ProcessDyeingBOM	 AS String	'			char(6)		*
Public 	ProcessDyeingName	 AS String	'			nvarchar(100)
Public 	ProcessDyeingNameSimply	 AS String	'			nvarchar(50)
Public 	cdFinishProcessDyeing	 AS String	'			char(3)
Public 	DyeingPrice	 AS Double	'			decimal
Public 	SpecialPrice	 AS Double	'			decimal
Public 	CheckProcess1	 AS String	'			char(1)
Public 	CheckProcess2	 AS String	'			char(1)
Public 	CheckProcess3	 AS String	'			char(1)
Public 	CheckUse	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(200)
'=========================================================================================================================================================
End structure

Public D7180 As T7180_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7180(PROCESSDYEINGSEL AS String, PROCESSDYEINGBOM AS String) As Boolean
    READ_PFK7180 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7180 "
    SQL = SQL & " WHERE K7180_ProcessDyeingSel		 = '" & ProcessDyeingSel & "' " 
    SQL = SQL & "   AND K7180_ProcessDyeingBOM		 = '" & ProcessDyeingBOM & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7180_CLEAR: GoTo SKIP_READ_PFK7180
                
    Call K7180_MOVE(rd)
    READ_PFK7180 = True

SKIP_READ_PFK7180:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7180",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7180(PROCESSDYEINGSEL AS String, PROCESSDYEINGBOM AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7180 "
    SQL = SQL & " WHERE K7180_ProcessDyeingSel		 = '" & ProcessDyeingSel & "' " 
    SQL = SQL & "   AND K7180_ProcessDyeingBOM		 = '" & ProcessDyeingBOM & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7180",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7180(z7180 As T7180_AREA) As Boolean
    WRITE_PFK7180 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7180)
 
    SQL = " INSERT INTO PFK7180 "
    SQL = SQL & " ( "
    SQL = SQL & " K7180_ProcessDyeingSel," 
    SQL = SQL & " K7180_ProcessDyeingBOM," 
    SQL = SQL & " K7180_ProcessDyeingName," 
    SQL = SQL & " K7180_ProcessDyeingNameSimply," 
    SQL = SQL & " K7180_cdFinishProcessDyeing," 
    SQL = SQL & " K7180_DyeingPrice," 
    SQL = SQL & " K7180_SpecialPrice," 
    SQL = SQL & " K7180_CheckProcess1," 
    SQL = SQL & " K7180_CheckProcess2," 
    SQL = SQL & " K7180_CheckProcess3," 
    SQL = SQL & " K7180_CheckUse," 
    SQL = SQL & " K7180_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  '" & z7180.ProcessDyeingSel & "', "  
    SQL = SQL & "  '" & z7180.ProcessDyeingBOM & "', "  
    SQL = SQL & "  '" & z7180.ProcessDyeingName & "', "  
    SQL = SQL & "  '" & z7180.ProcessDyeingNameSimply & "', "  
    SQL = SQL & "  '" & z7180.cdFinishProcessDyeing & "', "  
    SQL = SQL & "   " & z7180.DyeingPrice & " , "  
    SQL = SQL & "   " & z7180.SpecialPrice & " , "  
    SQL = SQL & "  '" & z7180.CheckProcess1 & "', "  
    SQL = SQL & "  '" & z7180.CheckProcess2 & "', "  
    SQL = SQL & "  '" & z7180.CheckProcess3 & "', "  
    SQL = SQL & "  '" & z7180.CheckUse & "', "  
    SQL = SQL & "  '" & z7180.Remark & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7180 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7180",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7180(z7180 As T7180_AREA) As Boolean
    REWRITE_PFK7180 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7180)
   
    SQL = " UPDATE PFK7180 SET "
    SQL = SQL & "    K7180_ProcessDyeingName      = '" & z7180.ProcessDyeingName & "', " 
    SQL = SQL & "    K7180_ProcessDyeingNameSimply      = '" & z7180.ProcessDyeingNameSimply & "', " 
    SQL = SQL & "    K7180_cdFinishProcessDyeing      = '" & z7180.cdFinishProcessDyeing & "', " 
    SQL = SQL & "    K7180_DyeingPrice      =  " & z7180.DyeingPrice & " , " 
    SQL = SQL & "    K7180_SpecialPrice      =  " & z7180.SpecialPrice & " , " 
    SQL = SQL & "    K7180_CheckProcess1      = '" & z7180.CheckProcess1 & "', " 
    SQL = SQL & "    K7180_CheckProcess2      = '" & z7180.CheckProcess2 & "', " 
    SQL = SQL & "    K7180_CheckProcess3      = '" & z7180.CheckProcess3 & "', " 
    SQL = SQL & "    K7180_CheckUse      = '" & z7180.CheckUse & "', " 
    SQL = SQL & "    K7180_Remark      = '" & z7180.Remark & "'  " 
    SQL = SQL & " WHERE K7180_ProcessDyeingSel		 = '" & z7180.ProcessDyeingSel & "' " 
    SQL = SQL & "   AND K7180_ProcessDyeingBOM		 = '" & z7180.ProcessDyeingBOM & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7180 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7180",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7180(z7180 As T7180_AREA) As Boolean
    DELETE_PFK7180 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7180 "
    SQL = SQL & " WHERE K7180_ProcessDyeingSel		 = '" & z7180.ProcessDyeingSel & "' " 
    SQL = SQL & "   AND K7180_ProcessDyeingBOM		 = '" & z7180.ProcessDyeingBOM & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7180 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7180",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7180_CLEAR()
Try
    
   D7180.ProcessDyeingSel = ""
   D7180.ProcessDyeingBOM = ""
   D7180.ProcessDyeingName = ""
   D7180.ProcessDyeingNameSimply = ""
   D7180.cdFinishProcessDyeing = ""
    D7180.DyeingPrice = 0 
    D7180.SpecialPrice = 0 
   D7180.CheckProcess1 = ""
   D7180.CheckProcess2 = ""
   D7180.CheckProcess3 = ""
   D7180.CheckUse = ""
   D7180.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7180_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7180 As T7180_AREA)
Try
    
    x7180.ProcessDyeingSel = trim$(  x7180.ProcessDyeingSel)
    x7180.ProcessDyeingBOM = trim$(  x7180.ProcessDyeingBOM)
    x7180.ProcessDyeingName = trim$(  x7180.ProcessDyeingName)
    x7180.ProcessDyeingNameSimply = trim$(  x7180.ProcessDyeingNameSimply)
    x7180.cdFinishProcessDyeing = trim$(  x7180.cdFinishProcessDyeing)
    x7180.DyeingPrice = trim$(  x7180.DyeingPrice)
    x7180.SpecialPrice = trim$(  x7180.SpecialPrice)
    x7180.CheckProcess1 = trim$(  x7180.CheckProcess1)
    x7180.CheckProcess2 = trim$(  x7180.CheckProcess2)
    x7180.CheckProcess3 = trim$(  x7180.CheckProcess3)
    x7180.CheckUse = trim$(  x7180.CheckUse)
    x7180.Remark = trim$(  x7180.Remark)
     
    If trim$( x7180.ProcessDyeingSel ) = "" Then x7180.ProcessDyeingSel = Space(1) 
    If trim$( x7180.ProcessDyeingBOM ) = "" Then x7180.ProcessDyeingBOM = Space(1) 
    If trim$( x7180.ProcessDyeingName ) = "" Then x7180.ProcessDyeingName = Space(1) 
    If trim$( x7180.ProcessDyeingNameSimply ) = "" Then x7180.ProcessDyeingNameSimply = Space(1) 
    If trim$( x7180.cdFinishProcessDyeing ) = "" Then x7180.cdFinishProcessDyeing = Space(1) 
    If trim$( x7180.DyeingPrice ) = "" Then x7180.DyeingPrice = 0 
    If trim$( x7180.SpecialPrice ) = "" Then x7180.SpecialPrice = 0 
    If trim$( x7180.CheckProcess1 ) = "" Then x7180.CheckProcess1 = Space(1) 
    If trim$( x7180.CheckProcess2 ) = "" Then x7180.CheckProcess2 = Space(1) 
    If trim$( x7180.CheckProcess3 ) = "" Then x7180.CheckProcess3 = Space(1) 
    If trim$( x7180.CheckUse ) = "" Then x7180.CheckUse = Space(1) 
    If trim$( x7180.Remark ) = "" Then x7180.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7180_MOVE(rs7180 As SqlClient.SqlDataReader)
Try

    call D7180_CLEAR()   

    If IsdbNull(rs7180!K7180_ProcessDyeingSel) = False Then D7180.ProcessDyeingSel = Trim$(rs7180!K7180_ProcessDyeingSel)
    If IsdbNull(rs7180!K7180_ProcessDyeingBOM) = False Then D7180.ProcessDyeingBOM = Trim$(rs7180!K7180_ProcessDyeingBOM)
    If IsdbNull(rs7180!K7180_ProcessDyeingName) = False Then D7180.ProcessDyeingName = Trim$(rs7180!K7180_ProcessDyeingName)
    If IsdbNull(rs7180!K7180_ProcessDyeingNameSimply) = False Then D7180.ProcessDyeingNameSimply = Trim$(rs7180!K7180_ProcessDyeingNameSimply)
    If IsdbNull(rs7180!K7180_cdFinishProcessDyeing) = False Then D7180.cdFinishProcessDyeing = Trim$(rs7180!K7180_cdFinishProcessDyeing)
    If IsdbNull(rs7180!K7180_DyeingPrice) = False Then D7180.DyeingPrice = Trim$(rs7180!K7180_DyeingPrice)
    If IsdbNull(rs7180!K7180_SpecialPrice) = False Then D7180.SpecialPrice = Trim$(rs7180!K7180_SpecialPrice)
    If IsdbNull(rs7180!K7180_CheckProcess1) = False Then D7180.CheckProcess1 = Trim$(rs7180!K7180_CheckProcess1)
    If IsdbNull(rs7180!K7180_CheckProcess2) = False Then D7180.CheckProcess2 = Trim$(rs7180!K7180_CheckProcess2)
    If IsdbNull(rs7180!K7180_CheckProcess3) = False Then D7180.CheckProcess3 = Trim$(rs7180!K7180_CheckProcess3)
    If IsdbNull(rs7180!K7180_CheckUse) = False Then D7180.CheckUse = Trim$(rs7180!K7180_CheckUse)
    If IsdbNull(rs7180!K7180_Remark) = False Then D7180.Remark = Trim$(rs7180!K7180_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7180_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7180_MOVE(rs7180 As DataRow)
Try

    call D7180_CLEAR()   

    If IsdbNull(rs7180!K7180_ProcessDyeingSel) = False Then D7180.ProcessDyeingSel = Trim$(rs7180!K7180_ProcessDyeingSel)
    If IsdbNull(rs7180!K7180_ProcessDyeingBOM) = False Then D7180.ProcessDyeingBOM = Trim$(rs7180!K7180_ProcessDyeingBOM)
    If IsdbNull(rs7180!K7180_ProcessDyeingName) = False Then D7180.ProcessDyeingName = Trim$(rs7180!K7180_ProcessDyeingName)
    If IsdbNull(rs7180!K7180_ProcessDyeingNameSimply) = False Then D7180.ProcessDyeingNameSimply = Trim$(rs7180!K7180_ProcessDyeingNameSimply)
    If IsdbNull(rs7180!K7180_cdFinishProcessDyeing) = False Then D7180.cdFinishProcessDyeing = Trim$(rs7180!K7180_cdFinishProcessDyeing)
    If IsdbNull(rs7180!K7180_DyeingPrice) = False Then D7180.DyeingPrice = Trim$(rs7180!K7180_DyeingPrice)
    If IsdbNull(rs7180!K7180_SpecialPrice) = False Then D7180.SpecialPrice = Trim$(rs7180!K7180_SpecialPrice)
    If IsdbNull(rs7180!K7180_CheckProcess1) = False Then D7180.CheckProcess1 = Trim$(rs7180!K7180_CheckProcess1)
    If IsdbNull(rs7180!K7180_CheckProcess2) = False Then D7180.CheckProcess2 = Trim$(rs7180!K7180_CheckProcess2)
    If IsdbNull(rs7180!K7180_CheckProcess3) = False Then D7180.CheckProcess3 = Trim$(rs7180!K7180_CheckProcess3)
    If IsdbNull(rs7180!K7180_CheckUse) = False Then D7180.CheckUse = Trim$(rs7180!K7180_CheckUse)
    If IsdbNull(rs7180!K7180_Remark) = False Then D7180.Remark = Trim$(rs7180!K7180_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7180_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7180_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7180 As T7180_AREA,PROCESSDYEINGSEL AS String, PROCESSDYEINGBOM AS String) as Boolean

K7180_MOVE = False

Try
    If READ_PFK7180(PROCESSDYEINGSEL, PROCESSDYEINGBOM) = True Then
                z7180 = D7180
		K7180_MOVE = True
            End If

   z7180.ProcessDyeingSel = getDataM(spr, getColumIndex(spr,"ProcessDyeingSel"), xRow)
   z7180.ProcessDyeingBOM = getDataM(spr, getColumIndex(spr,"ProcessDyeingBOM"), xRow)
   z7180.ProcessDyeingName = getDataM(spr, getColumIndex(spr,"ProcessDyeingName"), xRow)
   z7180.ProcessDyeingNameSimply = getDataM(spr, getColumIndex(spr,"ProcessDyeingNameSimply"), xRow)
   z7180.cdFinishProcessDyeing = getDataM(spr, getColumIndex(spr,"cdFinishProcessDyeing"), xRow)
   z7180.DyeingPrice = getDataM(spr, getColumIndex(spr,"DyeingPrice"), xRow)
   z7180.SpecialPrice = getDataM(spr, getColumIndex(spr,"SpecialPrice"), xRow)
   z7180.CheckProcess1 = getDataM(spr, getColumIndex(spr,"CheckProcess1"), xRow)
   z7180.CheckProcess2 = getDataM(spr, getColumIndex(spr,"CheckProcess2"), xRow)
   z7180.CheckProcess3 = getDataM(spr, getColumIndex(spr,"CheckProcess3"), xRow)
   z7180.CheckUse = getDataM(spr, getColumIndex(spr,"CheckUse"), xRow)
   z7180.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7180_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7180_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7180 As T7180_AREA, Job as String,PROCESSDYEINGSEL AS String, PROCESSDYEINGBOM AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7180_MOVE = False

Try
    If READ_PFK7180(PROCESSDYEINGSEL, PROCESSDYEINGBOM) = True Then
                z7180 = D7180
		K7180_MOVE = True

    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7180")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "ProcessDyeingSel":z7180.ProcessDyeingSel = Children(i).Code
   Case "ProcessDyeingBOM":z7180.ProcessDyeingBOM = Children(i).Code
   Case "ProcessDyeingName":z7180.ProcessDyeingName = Children(i).Code
   Case "ProcessDyeingNameSimply":z7180.ProcessDyeingNameSimply = Children(i).Code
   Case "cdFinishProcessDyeing":z7180.cdFinishProcessDyeing = Children(i).Code
   Case "DyeingPrice":z7180.DyeingPrice = Children(i).Code
   Case "SpecialPrice":z7180.SpecialPrice = Children(i).Code
   Case "CheckProcess1":z7180.CheckProcess1 = Children(i).Code
   Case "CheckProcess2":z7180.CheckProcess2 = Children(i).Code
   Case "CheckProcess3":z7180.CheckProcess3 = Children(i).Code
   Case "CheckUse":z7180.CheckUse = Children(i).Code
   Case "Remark":z7180.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "ProcessDyeingSel":z7180.ProcessDyeingSel = Children(i).Data
   Case "ProcessDyeingBOM":z7180.ProcessDyeingBOM = Children(i).Data
   Case "ProcessDyeingName":z7180.ProcessDyeingName = Children(i).Data
   Case "ProcessDyeingNameSimply":z7180.ProcessDyeingNameSimply = Children(i).Data
   Case "cdFinishProcessDyeing":z7180.cdFinishProcessDyeing = Children(i).Data
   Case "DyeingPrice":z7180.DyeingPrice = Children(i).Data
   Case "SpecialPrice":z7180.SpecialPrice = Children(i).Data
   Case "CheckProcess1":z7180.CheckProcess1 = Children(i).Data
   Case "CheckProcess2":z7180.CheckProcess2 = Children(i).Data
   Case "CheckProcess3":z7180.CheckProcess3 = Children(i).Data
   Case "CheckUse":z7180.CheckUse = Children(i).Data
   Case "Remark":z7180.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7180_MOVE",vbCritical)
End Try
End Function 
    
End Module 
