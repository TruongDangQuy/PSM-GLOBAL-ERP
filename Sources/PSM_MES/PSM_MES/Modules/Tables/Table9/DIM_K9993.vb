'=========================================================================================================================================================
'   TABLE : (PFK9993)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9993

Structure T9993_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	SITE	 AS String	'			char(3)		*
Public 	GROUP	 AS String	'			char(3)		*
Public 	PROG	 AS String	'			varchar(50)		*
Public 	CHK01	 AS String	'			char(1)
Public 	CHK02	 AS String	'			char(1)
Public 	CHK03	 AS String	'			char(1)
Public 	CHK04	 AS String	'			char(1)
Public 	CHK05	 AS String	'			char(1)
'=========================================================================================================================================================
End structure

Public D9993 As T9993_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK9993(SITE AS String, GROUP AS String, PROG AS String) As Boolean
    READ_PFK9993 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9993 "
    SQL = SQL & " WHERE K9993_SITE		 = '" & SITE & "' " 
    SQL = SQL & "   AND K9993_GROUP		 = '" & GROUP & "' " 
            SQL = SQL & "   AND K9993_PROG		 = N'" & FormatSQL(PROG) & "' "
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D9993_CLEAR: GoTo SKIP_READ_PFK9993
                
    Call K9993_MOVE(rd)
    READ_PFK9993 = True

SKIP_READ_PFK9993:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK9993",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK9993(SITE AS String, GROUP AS String, PROG AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9993 "
    SQL = SQL & " WHERE K9993_SITE		 = '" & SITE & "' " 
    SQL = SQL & "   AND K9993_GROUP		 = '" & GROUP & "' " 
    SQL = SQL & "   AND K9993_PROG		 = '" & PROG & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK9993",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK9993(z9993 As T9993_AREA) As Boolean
    WRITE_PFK9993 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z9993)
 
    SQL = " INSERT INTO PFK9993 "
    SQL = SQL & " ( "
    SQL = SQL & " K9993_SITE," 
    SQL = SQL & " K9993_GROUP," 
    SQL = SQL & " K9993_PROG," 
    SQL = SQL & " K9993_CHK01," 
    SQL = SQL & " K9993_CHK02," 
    SQL = SQL & " K9993_CHK03," 
    SQL = SQL & " K9993_CHK04," 
    SQL = SQL & " K9993_CHK05 " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  '" & z9993.SITE & "', "  
    SQL = SQL & "  '" & z9993.GROUP & "', "  
    SQL = SQL & "  '" & z9993.PROG & "', "  
    SQL = SQL & "  '" & z9993.CHK01 & "', "  
    SQL = SQL & "  '" & z9993.CHK02 & "', "  
    SQL = SQL & "  '" & z9993.CHK03 & "', "  
    SQL = SQL & "  '" & z9993.CHK04 & "', "  
    SQL = SQL & "  '" & z9993.CHK05 & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK9993 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK9993",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK9993(z9993 As T9993_AREA) As Boolean
    REWRITE_PFK9993 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z9993)
   
    SQL = " UPDATE PFK9993 SET "
    SQL = SQL & "    K9993_CHK01      = '" & z9993.CHK01 & "', " 
    SQL = SQL & "    K9993_CHK02      = '" & z9993.CHK02 & "', " 
    SQL = SQL & "    K9993_CHK03      = '" & z9993.CHK03 & "', " 
    SQL = SQL & "    K9993_CHK04      = '" & z9993.CHK04 & "', " 
    SQL = SQL & "    K9993_CHK05      = '" & z9993.CHK05 & "'  " 
    SQL = SQL & " WHERE K9993_SITE		 = '" & z9993.SITE & "' " 
    SQL = SQL & "   AND K9993_GROUP		 = '" & z9993.GROUP & "' " 
    SQL = SQL & "   AND K9993_PROG		 = '" & z9993.PROG & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK9993 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK9993",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK9993(z9993 As T9993_AREA) As Boolean
    DELETE_PFK9993 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK9993 "
    SQL = SQL & " WHERE K9993_SITE		 = '" & z9993.SITE & "' " 
    SQL = SQL & "   AND K9993_GROUP		 = '" & z9993.GROUP & "' " 
    SQL = SQL & "   AND K9993_PROG		 = '" & z9993.PROG & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK9993 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK9993",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D9993_CLEAR()
Try
    
   D9993.SITE = ""
   D9993.GROUP = ""
   D9993.PROG = ""
   D9993.CHK01 = ""
   D9993.CHK02 = ""
   D9993.CHK03 = ""
   D9993.CHK04 = ""
   D9993.CHK05 = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D9993_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x9993 As T9993_AREA)
Try
    
    x9993.SITE = trim$(  x9993.SITE)
    x9993.GROUP = trim$(  x9993.GROUP)
    x9993.PROG = trim$(  x9993.PROG)
    x9993.CHK01 = trim$(  x9993.CHK01)
    x9993.CHK02 = trim$(  x9993.CHK02)
    x9993.CHK03 = trim$(  x9993.CHK03)
    x9993.CHK04 = trim$(  x9993.CHK04)
    x9993.CHK05 = trim$(  x9993.CHK05)
     
    If trim$( x9993.SITE ) = "" Then x9993.SITE = Space(1) 
    If trim$( x9993.GROUP ) = "" Then x9993.GROUP = Space(1) 
    If trim$( x9993.PROG ) = "" Then x9993.PROG = Space(1) 
    If trim$( x9993.CHK01 ) = "" Then x9993.CHK01 = Space(1) 
    If trim$( x9993.CHK02 ) = "" Then x9993.CHK02 = Space(1) 
    If trim$( x9993.CHK03 ) = "" Then x9993.CHK03 = Space(1) 
    If trim$( x9993.CHK04 ) = "" Then x9993.CHK04 = Space(1) 
    If trim$( x9993.CHK05 ) = "" Then x9993.CHK05 = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K9993_MOVE(rs9993 As SqlClient.SqlDataReader)
Try

    call D9993_CLEAR()   

    If IsdbNull(rs9993!K9993_SITE) = False Then D9993.SITE = Trim$(rs9993!K9993_SITE)
    If IsdbNull(rs9993!K9993_GROUP) = False Then D9993.GROUP = Trim$(rs9993!K9993_GROUP)
    If IsdbNull(rs9993!K9993_PROG) = False Then D9993.PROG = Trim$(rs9993!K9993_PROG)
    If IsdbNull(rs9993!K9993_CHK01) = False Then D9993.CHK01 = Trim$(rs9993!K9993_CHK01)
    If IsdbNull(rs9993!K9993_CHK02) = False Then D9993.CHK02 = Trim$(rs9993!K9993_CHK02)
    If IsdbNull(rs9993!K9993_CHK03) = False Then D9993.CHK03 = Trim$(rs9993!K9993_CHK03)
    If IsdbNull(rs9993!K9993_CHK04) = False Then D9993.CHK04 = Trim$(rs9993!K9993_CHK04)
    If IsdbNull(rs9993!K9993_CHK05) = False Then D9993.CHK05 = Trim$(rs9993!K9993_CHK05)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9993_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K9993_MOVE(rs9993 As DataRow)
Try

    call D9993_CLEAR()   

    If IsdbNull(rs9993!K9993_SITE) = False Then D9993.SITE = Trim$(rs9993!K9993_SITE)
    If IsdbNull(rs9993!K9993_GROUP) = False Then D9993.GROUP = Trim$(rs9993!K9993_GROUP)
    If IsdbNull(rs9993!K9993_PROG) = False Then D9993.PROG = Trim$(rs9993!K9993_PROG)
    If IsdbNull(rs9993!K9993_CHK01) = False Then D9993.CHK01 = Trim$(rs9993!K9993_CHK01)
    If IsdbNull(rs9993!K9993_CHK02) = False Then D9993.CHK02 = Trim$(rs9993!K9993_CHK02)
    If IsdbNull(rs9993!K9993_CHK03) = False Then D9993.CHK03 = Trim$(rs9993!K9993_CHK03)
    If IsdbNull(rs9993!K9993_CHK04) = False Then D9993.CHK04 = Trim$(rs9993!K9993_CHK04)
    If IsdbNull(rs9993!K9993_CHK05) = False Then D9993.CHK05 = Trim$(rs9993!K9993_CHK05)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9993_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K9993_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9993 As T9993_AREA,SITE AS String, GROUP AS String, PROG AS String) as Boolean

K9993_MOVE = False

Try
    If READ_PFK9993(SITE, GROUP, PROG) = True Then
                z9993 = D9993
		K9993_MOVE = True
            End If

   z9993.SITE = getDataM(spr, getColumIndex(spr,"SITE"), xRow)
   z9993.GROUP = getDataM(spr, getColumIndex(spr,"GROUP"), xRow)
   z9993.PROG = getDataM(spr, getColumIndex(spr,"PROG"), xRow)
   z9993.CHK01 = getDataM(spr, getColumIndex(spr,"CHK01"), xRow)
   z9993.CHK02 = getDataM(spr, getColumIndex(spr,"CHK02"), xRow)
   z9993.CHK03 = getDataM(spr, getColumIndex(spr,"CHK03"), xRow)
   z9993.CHK04 = getDataM(spr, getColumIndex(spr,"CHK04"), xRow)
   z9993.CHK05 = getDataM(spr, getColumIndex(spr,"CHK05"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9993_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K9993_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9993 As T9993_AREA, Job as String,SITE AS String, GROUP AS String, PROG AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9993_MOVE = False

Try
    If READ_PFK9993(SITE, GROUP, PROG) = True Then
                z9993 = D9993
		K9993_MOVE = True

    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9993")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "SITE":z9993.SITE = Children(i).Code
   Case "GROUP":z9993.GROUP = Children(i).Code
   Case "PROG":z9993.PROG = Children(i).Code
   Case "CHK01":z9993.CHK01 = Children(i).Code
   Case "CHK02":z9993.CHK02 = Children(i).Code
   Case "CHK03":z9993.CHK03 = Children(i).Code
   Case "CHK04":z9993.CHK04 = Children(i).Code
   Case "CHK05":z9993.CHK05 = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "SITE":z9993.SITE = Children(i).Data
   Case "GROUP":z9993.GROUP = Children(i).Data
   Case "PROG":z9993.PROG = Children(i).Data
   Case "CHK01":z9993.CHK01 = Children(i).Data
   Case "CHK02":z9993.CHK02 = Children(i).Data
   Case "CHK03":z9993.CHK03 = Children(i).Data
   Case "CHK04":z9993.CHK04 = Children(i).Data
   Case "CHK05":z9993.CHK05 = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9993_MOVE",vbCritical)
End Try
End Function 
    
End Module 
