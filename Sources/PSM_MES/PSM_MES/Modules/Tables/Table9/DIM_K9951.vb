'=========================================================================================================================================================
'   TABLE : (PFK9951)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9951

Structure T9951_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	Autokey	 AS Double	'			decimal		*
Public 	IDNO	 AS String	'			char(8)		*
Public 	seSite	 AS String	'			char(3)
Public 	cdSite	 AS String	'			char(3)
Public 	TimeInsert	 AS String	'			char(14)
Public 	TimeUpdate	 AS String	'			char(14)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
'=========================================================================================================================================================
End structure

Public D9951 As T9951_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK9951(AUTOKEY AS Double, IDNO AS String) As Boolean
    READ_PFK9951 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9951 "
    SQL = SQL & " WHERE K9951_Autokey		 =  " & Autokey & "  " 
    SQL = SQL & "   AND K9951_IDNO		 = '" & IDNO & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D9951_CLEAR: GoTo SKIP_READ_PFK9951
                
    Call K9951_MOVE(rd)
    READ_PFK9951 = True

SKIP_READ_PFK9951:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK9951",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK9951(AUTOKEY AS Double, IDNO AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9951 "
    SQL = SQL & " WHERE K9951_Autokey		 =  " & Autokey & "  " 
    SQL = SQL & "   AND K9951_IDNO		 = '" & IDNO & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK9951",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK9951(z9951 As T9951_AREA) As Boolean
    WRITE_PFK9951 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z9951)
 
    SQL = " INSERT INTO PFK9951 "
    SQL = SQL & " ( "
    SQL = SQL & " K9951_Autokey," 
    SQL = SQL & " K9951_IDNO," 
    SQL = SQL & " K9951_seSite," 
    SQL = SQL & " K9951_cdSite," 
    SQL = SQL & " K9951_TimeInsert," 
    SQL = SQL & " K9951_TimeUpdate," 
    SQL = SQL & " K9951_DateInsert," 
    SQL = SQL & " K9951_DateUpdate," 
    SQL = SQL & " K9951_InchargeInsert," 
    SQL = SQL & " K9951_InchargeUpdate " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "   " & FormatSQL(z9951.Autokey) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z9951.IDNO) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9951.seSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9951.cdSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.TIME) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9951.TimeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9951.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9951.InchargeUpdate) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK9951 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK9951",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK9951(z9951 As T9951_AREA) As Boolean
    REWRITE_PFK9951 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z9951)
   
    SQL = " UPDATE PFK9951 SET "
    SQL = SQL & "    K9951_seSite      = N'" & FormatSQL(z9951.seSite) & "', " 
    SQL = SQL & "    K9951_cdSite      = N'" & FormatSQL(z9951.cdSite) & "', " 
    SQL = SQL & "    K9951_TimeInsert      = N'" & FormatSQL(z9951.TimeInsert) & "', " 
    SQL = SQL & "    K9951_TimeUpdate      = N'" & FormatSQL(PUB.TIME) & "', " 
    SQL = SQL & "    K9951_DateInsert      = N'" & FormatSQL(z9951.DateInsert) & "', " 
    SQL = SQL & "    K9951_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', " 
    SQL = SQL & "    K9951_InchargeInsert      = N'" & FormatSQL(z9951.InchargeInsert) & "', " 
    SQL = SQL & "    K9951_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "'  " 
    SQL = SQL & " WHERE K9951_Autokey		 =  " & z9951.Autokey & "  " 
    SQL = SQL & "   AND K9951_IDNO		 = '" & z9951.IDNO & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  

    REWRITE_PFK9951 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK9951",vbCritical)

  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK9951(z9951 As T9951_AREA) As Boolean
    DELETE_PFK9951 = False

   Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z9951)
      
        SQL = " DELETE FROM PFK9951  "
    SQL = SQL & " WHERE K9951_Autokey		 =  " & z9951.Autokey & "  " 
    SQL = SQL & "   AND K9951_IDNO		 = '" & z9951.IDNO & "' " 

    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK9951 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK9951",vbCritical)
Finally
        Call GetFullInformation("PFK9951", "D", SQL)
  End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D9951_CLEAR()
Try
    
    D9951.Autokey = 0 
   D9951.IDNO = ""
   D9951.seSite = ""
   D9951.cdSite = ""
   D9951.TimeInsert = ""
   D9951.TimeUpdate = ""
   D9951.DateInsert = ""
   D9951.DateUpdate = ""
   D9951.InchargeInsert = ""
   D9951.InchargeUpdate = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D9951_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x9951 As T9951_AREA)
Try
    
    x9951.Autokey = trim$(  x9951.Autokey)
    x9951.IDNO = trim$(  x9951.IDNO)
    x9951.seSite = trim$(  x9951.seSite)
    x9951.cdSite = trim$(  x9951.cdSite)
    x9951.TimeInsert = trim$(  x9951.TimeInsert)
    x9951.TimeUpdate = trim$(  x9951.TimeUpdate)
    x9951.DateInsert = trim$(  x9951.DateInsert)
    x9951.DateUpdate = trim$(  x9951.DateUpdate)
    x9951.InchargeInsert = trim$(  x9951.InchargeInsert)
    x9951.InchargeUpdate = trim$(  x9951.InchargeUpdate)
     
    If trim$( x9951.Autokey ) = "" Then x9951.Autokey = 0 
    If trim$( x9951.IDNO ) = "" Then x9951.IDNO = Space(1) 
    If trim$( x9951.seSite ) = "" Then x9951.seSite = Space(1) 
    If trim$( x9951.cdSite ) = "" Then x9951.cdSite = Space(1) 
    If trim$( x9951.TimeInsert ) = "" Then x9951.TimeInsert = Space(1) 
    If trim$( x9951.TimeUpdate ) = "" Then x9951.TimeUpdate = Space(1) 
    If trim$( x9951.DateInsert ) = "" Then x9951.DateInsert = Space(1) 
    If trim$( x9951.DateUpdate ) = "" Then x9951.DateUpdate = Space(1) 
    If trim$( x9951.InchargeInsert ) = "" Then x9951.InchargeInsert = Space(1) 
    If trim$( x9951.InchargeUpdate ) = "" Then x9951.InchargeUpdate = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K9951_MOVE(rs9951 As SqlClient.SqlDataReader)
Try

    call D9951_CLEAR()   

    If IsdbNull(rs9951!K9951_Autokey) = False Then D9951.Autokey = Trim$(rs9951!K9951_Autokey)
    If IsdbNull(rs9951!K9951_IDNO) = False Then D9951.IDNO = Trim$(rs9951!K9951_IDNO)
    If IsdbNull(rs9951!K9951_seSite) = False Then D9951.seSite = Trim$(rs9951!K9951_seSite)
    If IsdbNull(rs9951!K9951_cdSite) = False Then D9951.cdSite = Trim$(rs9951!K9951_cdSite)
    If IsdbNull(rs9951!K9951_TimeInsert) = False Then D9951.TimeInsert = Trim$(rs9951!K9951_TimeInsert)
    If IsdbNull(rs9951!K9951_TimeUpdate) = False Then D9951.TimeUpdate = Trim$(rs9951!K9951_TimeUpdate)
    If IsdbNull(rs9951!K9951_DateInsert) = False Then D9951.DateInsert = Trim$(rs9951!K9951_DateInsert)
    If IsdbNull(rs9951!K9951_DateUpdate) = False Then D9951.DateUpdate = Trim$(rs9951!K9951_DateUpdate)
    If IsdbNull(rs9951!K9951_InchargeInsert) = False Then D9951.InchargeInsert = Trim$(rs9951!K9951_InchargeInsert)
    If IsdbNull(rs9951!K9951_InchargeUpdate) = False Then D9951.InchargeUpdate = Trim$(rs9951!K9951_InchargeUpdate)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9951_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K9951_MOVE(rs9951 As DataRow)
Try

    call D9951_CLEAR()   

    If IsdbNull(rs9951!K9951_Autokey) = False Then D9951.Autokey = Trim$(rs9951!K9951_Autokey)
    If IsdbNull(rs9951!K9951_IDNO) = False Then D9951.IDNO = Trim$(rs9951!K9951_IDNO)
    If IsdbNull(rs9951!K9951_seSite) = False Then D9951.seSite = Trim$(rs9951!K9951_seSite)
    If IsdbNull(rs9951!K9951_cdSite) = False Then D9951.cdSite = Trim$(rs9951!K9951_cdSite)
    If IsdbNull(rs9951!K9951_TimeInsert) = False Then D9951.TimeInsert = Trim$(rs9951!K9951_TimeInsert)
    If IsdbNull(rs9951!K9951_TimeUpdate) = False Then D9951.TimeUpdate = Trim$(rs9951!K9951_TimeUpdate)
    If IsdbNull(rs9951!K9951_DateInsert) = False Then D9951.DateInsert = Trim$(rs9951!K9951_DateInsert)
    If IsdbNull(rs9951!K9951_DateUpdate) = False Then D9951.DateUpdate = Trim$(rs9951!K9951_DateUpdate)
    If IsdbNull(rs9951!K9951_InchargeInsert) = False Then D9951.InchargeInsert = Trim$(rs9951!K9951_InchargeInsert)
    If IsdbNull(rs9951!K9951_InchargeUpdate) = False Then D9951.InchargeUpdate = Trim$(rs9951!K9951_InchargeUpdate)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9951_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K9951_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9951 As T9951_AREA, AUTOKEY AS Double, IDNO AS String) as Boolean

K9951_MOVE = False

Try
    If READ_PFK9951(AUTOKEY, IDNO) = True Then
                z9951 = D9951
		K9951_MOVE = True
		else
	z9951 = nothing
     End If

     If  getColumnIndex(spr,"Autokey") > -1 then z9951.Autokey = Cdecp(getDataM(spr, getColumnIndex(spr,"Autokey"), xRow))
     If  getColumnIndex(spr,"IDNO") > -1 then z9951.IDNO = getDataM(spr, getColumnIndex(spr,"IDNO"), xRow)
     If  getColumnIndex(spr,"seSite") > -1 then z9951.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z9951.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)
     If  getColumnIndex(spr,"TimeInsert") > -1 then z9951.TimeInsert = getDataM(spr, getColumnIndex(spr,"TimeInsert"), xRow)
     If  getColumnIndex(spr,"TimeUpdate") > -1 then z9951.TimeUpdate = getDataM(spr, getColumnIndex(spr,"TimeUpdate"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z9951.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z9951.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z9951.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z9951.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9951_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K9951_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9951 As T9951_AREA,CheckClear as Boolean,AUTOKEY AS Double, IDNO AS String) as Boolean

K9951_MOVE = False

Try
    If READ_PFK9951(AUTOKEY, IDNO) = True Then
                z9951 = D9951
		K9951_MOVE = True
		else
	If CheckClear  = True then z9951 = nothing
     End If

     If  getColumnIndex(spr,"Autokey") > -1 then z9951.Autokey = Cdecp(getDataM(spr, getColumnIndex(spr,"Autokey"), xRow))
     If  getColumnIndex(spr,"IDNO") > -1 then z9951.IDNO = getDataM(spr, getColumnIndex(spr,"IDNO"), xRow)
     If  getColumnIndex(spr,"seSite") > -1 then z9951.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z9951.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)
     If  getColumnIndex(spr,"TimeInsert") > -1 then z9951.TimeInsert = getDataM(spr, getColumnIndex(spr,"TimeInsert"), xRow)
     If  getColumnIndex(spr,"TimeUpdate") > -1 then z9951.TimeUpdate = getDataM(spr, getColumnIndex(spr,"TimeUpdate"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z9951.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z9951.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z9951.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z9951.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9951_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K9951_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9951 As T9951_AREA, Job as String, AUTOKEY AS Double, IDNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9951_MOVE = False

Try
    If READ_PFK9951(AUTOKEY, IDNO) = True Then
                z9951 = D9951
		K9951_MOVE = True
		else
	z9951 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9951")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z9951.Autokey = Children(i).Code
   Case "IDNO":z9951.IDNO = Children(i).Code
   Case "SESITE":z9951.seSite = Children(i).Code
   Case "CDSITE":z9951.cdSite = Children(i).Code
   Case "TIMEINSERT":z9951.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z9951.TimeUpdate = Children(i).Code
   Case "DATEINSERT":z9951.DateInsert = Children(i).Code
   Case "DATEUPDATE":z9951.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z9951.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z9951.InchargeUpdate = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z9951.Autokey = Cdecp(Children(i).Data)
   Case "IDNO":z9951.IDNO = Children(i).Data
   Case "SESITE":z9951.seSite = Children(i).Data
   Case "CDSITE":z9951.cdSite = Children(i).Data
   Case "TIMEINSERT":z9951.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z9951.TimeUpdate = Children(i).Data
   Case "DATEINSERT":z9951.DateInsert = Children(i).Data
   Case "DATEUPDATE":z9951.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z9951.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z9951.InchargeUpdate = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9951_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K9951_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9951 As T9951_AREA, Job as String, CheckClear as Boolean, AUTOKEY AS Double, IDNO AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9951_MOVE = False

Try
    If READ_PFK9951(AUTOKEY, IDNO) = True Then
                z9951 = D9951
		K9951_MOVE = True
		else
	If CheckClear  = True then z9951 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9951")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z9951.Autokey = Children(i).Code
   Case "IDNO":z9951.IDNO = Children(i).Code
   Case "SESITE":z9951.seSite = Children(i).Code
   Case "CDSITE":z9951.cdSite = Children(i).Code
   Case "TIMEINSERT":z9951.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z9951.TimeUpdate = Children(i).Code
   Case "DATEINSERT":z9951.DateInsert = Children(i).Code
   Case "DATEUPDATE":z9951.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z9951.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z9951.InchargeUpdate = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z9951.Autokey = Cdecp(Children(i).Data)
   Case "IDNO":z9951.IDNO = Children(i).Data
   Case "SESITE":z9951.seSite = Children(i).Data
   Case "CDSITE":z9951.cdSite = Children(i).Data
   Case "TIMEINSERT":z9951.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z9951.TimeUpdate = Children(i).Data
   Case "DATEINSERT":z9951.DateInsert = Children(i).Data
   Case "DATEUPDATE":z9951.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z9951.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z9951.InchargeUpdate = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9951_MOVE",vbCritical)
End Try
End Function 
    

'=========================================================================================================================================================
' DATA MOVE FORM NEW AREA
'=========================================================================================================================================================
Public Sub K9951_MOVE(ByRef a9951 As T9951_AREA, ByRef b9951 As T9951_AREA) 
Try
If trim$( a9951.Autokey ) = "" Then b9951.Autokey = ""  Else b9951.Autokey=a9951.Autokey
If trim$( a9951.IDNO ) = "" Then b9951.IDNO = ""  Else b9951.IDNO=a9951.IDNO
If trim$( a9951.seSite ) = "" Then b9951.seSite = ""  Else b9951.seSite=a9951.seSite
If trim$( a9951.cdSite ) = "" Then b9951.cdSite = ""  Else b9951.cdSite=a9951.cdSite
If trim$( a9951.TimeInsert ) = "" Then b9951.TimeInsert = ""  Else b9951.TimeInsert=a9951.TimeInsert
If trim$( a9951.TimeUpdate ) = "" Then b9951.TimeUpdate = ""  Else b9951.TimeUpdate=a9951.TimeUpdate
If trim$( a9951.DateInsert ) = "" Then b9951.DateInsert = ""  Else b9951.DateInsert=a9951.DateInsert
If trim$( a9951.DateUpdate ) = "" Then b9951.DateUpdate = ""  Else b9951.DateUpdate=a9951.DateUpdate
If trim$( a9951.InchargeInsert ) = "" Then b9951.InchargeInsert = ""  Else b9951.InchargeInsert=a9951.InchargeInsert
If trim$( a9951.InchargeUpdate ) = "" Then b9951.InchargeUpdate = ""  Else b9951.InchargeUpdate=a9951.InchargeUpdate
Catch ex As Exception
      Call MsgBoxP("K9951_MOVE",vbCritical)
End Try
End Sub 


End Module 
