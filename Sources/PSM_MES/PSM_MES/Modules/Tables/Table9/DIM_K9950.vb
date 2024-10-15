'=========================================================================================================================================================
'   TABLE : (PFK9950)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9950

Structure T9950_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	Autokey	 AS Double	'			decimal		*
Public 	ProgramNo	 AS String	'			nvarchar(100)
Public 	Content	 AS String	'			nvarchar(-1)
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

Public D9950 As T9950_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK9950(AUTOKEY AS Double) As Boolean
    READ_PFK9950 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9950 "
    SQL = SQL & " WHERE K9950_Autokey		 =  " & Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D9950_CLEAR: GoTo SKIP_READ_PFK9950
                
    Call K9950_MOVE(rd)
    READ_PFK9950 = True

SKIP_READ_PFK9950:
    rd.Close()
    Exit Function
 Catch ex As Exception
            'Call MsgBoxP("READ_PFK9950",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK9950(AUTOKEY AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9950 "
    SQL = SQL & " WHERE K9950_Autokey		 =  " & Autokey & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
            'Call MsgBoxP"READ_PFK9950",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK9950(z9950 As T9950_AREA) As Boolean
    WRITE_PFK9950 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z9950)
 
    SQL = " INSERT INTO PFK9950 "
    SQL = SQL & " ( "

    SQL = SQL & " K9950_ProgramNo," 
    SQL = SQL & " K9950_Content," 
    SQL = SQL & " K9950_seSite," 
    SQL = SQL & " K9950_cdSite," 
    SQL = SQL & " K9950_TimeInsert," 
    SQL = SQL & " K9950_TimeUpdate," 
    SQL = SQL & " K9950_DateInsert," 
    SQL = SQL & " K9950_DateUpdate," 
    SQL = SQL & " K9950_InchargeInsert," 
    SQL = SQL & " K9950_InchargeUpdate " 
    SQL = SQL & " ) VALUES ( "

    SQL = SQL & "  N'" & FormatSQL(z9950.ProgramNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9950.Content) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9950.seSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9950.cdSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.TIME) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9950.TimeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9950.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z9950.InchargeUpdate) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK9950 = True
    Exit Function
Catch ex As Exception
            'Call MsgBoxP"WRITE_PFK9950",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK9950(z9950 As T9950_AREA) As Boolean
    REWRITE_PFK9950 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z9950)
   
    SQL = " UPDATE PFK9950 SET "
    SQL = SQL & "    K9950_ProgramNo      = N'" & FormatSQL(z9950.ProgramNo) & "', " 
    SQL = SQL & "    K9950_Content      = N'" & FormatSQL(z9950.Content) & "', " 
    SQL = SQL & "    K9950_seSite      = N'" & FormatSQL(z9950.seSite) & "', " 
    SQL = SQL & "    K9950_cdSite      = N'" & FormatSQL(z9950.cdSite) & "', " 
    SQL = SQL & "    K9950_TimeInsert      = N'" & FormatSQL(z9950.TimeInsert) & "', " 
    SQL = SQL & "    K9950_TimeUpdate      = N'" & FormatSQL(PUB.TIME) & "', " 
    SQL = SQL & "    K9950_DateInsert      = N'" & FormatSQL(z9950.DateInsert) & "', " 
    SQL = SQL & "    K9950_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', " 
    SQL = SQL & "    K9950_InchargeInsert      = N'" & FormatSQL(z9950.InchargeInsert) & "', " 
    SQL = SQL & "    K9950_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "'  " 
    SQL = SQL & " WHERE K9950_Autokey		 =  " & z9950.Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  

    REWRITE_PFK9950 = True

    Exit Function
Catch ex As Exception
            'Call MsgBoxP"REWRITE_PFK9950",vbCritical)

  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK9950(z9950 As T9950_AREA) As Boolean
    DELETE_PFK9950 = False

   Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z9950)
      
        SQL = " DELETE FROM PFK9950  "
    SQL = SQL & " WHERE K9950_Autokey		 =  " & z9950.Autokey & "  " 

    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK9950 = True

    Exit Function
Catch ex As Exception
            'Call MsgBoxP"DELETE_PFK9950",vbCritical)
Finally
        Call GetFullInformation("PFK9950", "D", SQL)
  End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D9950_CLEAR()
Try
    
    D9950.Autokey = 0 
   D9950.ProgramNo = ""
   D9950.Content = ""
   D9950.seSite = ""
   D9950.cdSite = ""
   D9950.TimeInsert = ""
   D9950.TimeUpdate = ""
   D9950.DateInsert = ""
   D9950.DateUpdate = ""
   D9950.InchargeInsert = ""
   D9950.InchargeUpdate = ""

    
    Exit Sub
Catch ex As Exception
            'Call MsgBoxP"D9950_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x9950 As T9950_AREA)
Try
    
    x9950.Autokey = trim$(  x9950.Autokey)
    x9950.ProgramNo = trim$(  x9950.ProgramNo)
    x9950.Content = trim$(  x9950.Content)
    x9950.seSite = trim$(  x9950.seSite)
    x9950.cdSite = trim$(  x9950.cdSite)
    x9950.TimeInsert = trim$(  x9950.TimeInsert)
    x9950.TimeUpdate = trim$(  x9950.TimeUpdate)
    x9950.DateInsert = trim$(  x9950.DateInsert)
    x9950.DateUpdate = trim$(  x9950.DateUpdate)
    x9950.InchargeInsert = trim$(  x9950.InchargeInsert)
    x9950.InchargeUpdate = trim$(  x9950.InchargeUpdate)
     
    If trim$( x9950.Autokey ) = "" Then x9950.Autokey = 0 
    If trim$( x9950.ProgramNo ) = "" Then x9950.ProgramNo = Space(1) 
    If trim$( x9950.Content ) = "" Then x9950.Content = Space(1) 
    If trim$( x9950.seSite ) = "" Then x9950.seSite = Space(1) 
    If trim$( x9950.cdSite ) = "" Then x9950.cdSite = Space(1) 
    If trim$( x9950.TimeInsert ) = "" Then x9950.TimeInsert = Space(1) 
    If trim$( x9950.TimeUpdate ) = "" Then x9950.TimeUpdate = Space(1) 
    If trim$( x9950.DateInsert ) = "" Then x9950.DateInsert = Space(1) 
    If trim$( x9950.DateUpdate ) = "" Then x9950.DateUpdate = Space(1) 
    If trim$( x9950.InchargeInsert ) = "" Then x9950.InchargeInsert = Space(1) 
    If trim$( x9950.InchargeUpdate ) = "" Then x9950.InchargeUpdate = Space(1) 


    Exit Sub
Catch ex As Exception
            'Call MsgBoxP"NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K9950_MOVE(rs9950 As SqlClient.SqlDataReader)
Try

    call D9950_CLEAR()   

    If IsdbNull(rs9950!K9950_Autokey) = False Then D9950.Autokey = Trim$(rs9950!K9950_Autokey)
    If IsdbNull(rs9950!K9950_ProgramNo) = False Then D9950.ProgramNo = Trim$(rs9950!K9950_ProgramNo)
    If IsdbNull(rs9950!K9950_Content) = False Then D9950.Content = Trim$(rs9950!K9950_Content)
    If IsdbNull(rs9950!K9950_seSite) = False Then D9950.seSite = Trim$(rs9950!K9950_seSite)
    If IsdbNull(rs9950!K9950_cdSite) = False Then D9950.cdSite = Trim$(rs9950!K9950_cdSite)
    If IsdbNull(rs9950!K9950_TimeInsert) = False Then D9950.TimeInsert = Trim$(rs9950!K9950_TimeInsert)
    If IsdbNull(rs9950!K9950_TimeUpdate) = False Then D9950.TimeUpdate = Trim$(rs9950!K9950_TimeUpdate)
    If IsdbNull(rs9950!K9950_DateInsert) = False Then D9950.DateInsert = Trim$(rs9950!K9950_DateInsert)
    If IsdbNull(rs9950!K9950_DateUpdate) = False Then D9950.DateUpdate = Trim$(rs9950!K9950_DateUpdate)
    If IsdbNull(rs9950!K9950_InchargeInsert) = False Then D9950.InchargeInsert = Trim$(rs9950!K9950_InchargeInsert)
    If IsdbNull(rs9950!K9950_InchargeUpdate) = False Then D9950.InchargeUpdate = Trim$(rs9950!K9950_InchargeUpdate)

    
    Exit Sub
Catch ex As Exception
            'Call MsgBoxP"K9950_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K9950_MOVE(rs9950 As DataRow)
Try

    call D9950_CLEAR()   

    If IsdbNull(rs9950!K9950_Autokey) = False Then D9950.Autokey = Trim$(rs9950!K9950_Autokey)
    If IsdbNull(rs9950!K9950_ProgramNo) = False Then D9950.ProgramNo = Trim$(rs9950!K9950_ProgramNo)
    If IsdbNull(rs9950!K9950_Content) = False Then D9950.Content = Trim$(rs9950!K9950_Content)
    If IsdbNull(rs9950!K9950_seSite) = False Then D9950.seSite = Trim$(rs9950!K9950_seSite)
    If IsdbNull(rs9950!K9950_cdSite) = False Then D9950.cdSite = Trim$(rs9950!K9950_cdSite)
    If IsdbNull(rs9950!K9950_TimeInsert) = False Then D9950.TimeInsert = Trim$(rs9950!K9950_TimeInsert)
    If IsdbNull(rs9950!K9950_TimeUpdate) = False Then D9950.TimeUpdate = Trim$(rs9950!K9950_TimeUpdate)
    If IsdbNull(rs9950!K9950_DateInsert) = False Then D9950.DateInsert = Trim$(rs9950!K9950_DateInsert)
    If IsdbNull(rs9950!K9950_DateUpdate) = False Then D9950.DateUpdate = Trim$(rs9950!K9950_DateUpdate)
    If IsdbNull(rs9950!K9950_InchargeInsert) = False Then D9950.InchargeInsert = Trim$(rs9950!K9950_InchargeInsert)
    If IsdbNull(rs9950!K9950_InchargeUpdate) = False Then D9950.InchargeUpdate = Trim$(rs9950!K9950_InchargeUpdate)

    
    Exit Sub
Catch ex As Exception
            'Call MsgBoxP"K9950_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K9950_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9950 As T9950_AREA, AUTOKEY AS Double) as Boolean

K9950_MOVE = False

Try
    If READ_PFK9950(AUTOKEY) = True Then
                z9950 = D9950
		K9950_MOVE = True
		else
	z9950 = nothing
     End If

     If  getColumnIndex(spr,"Autokey") > -1 then z9950.Autokey = Cdecp(getDataM(spr, getColumnIndex(spr,"Autokey"), xRow))
     If  getColumnIndex(spr,"ProgramNo") > -1 then z9950.ProgramNo = getDataM(spr, getColumnIndex(spr,"ProgramNo"), xRow)
     If  getColumnIndex(spr,"Content") > -1 then z9950.Content = getDataM(spr, getColumnIndex(spr,"Content"), xRow)
     If  getColumnIndex(spr,"seSite") > -1 then z9950.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z9950.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)
     If  getColumnIndex(spr,"TimeInsert") > -1 then z9950.TimeInsert = getDataM(spr, getColumnIndex(spr,"TimeInsert"), xRow)
     If  getColumnIndex(spr,"TimeUpdate") > -1 then z9950.TimeUpdate = getDataM(spr, getColumnIndex(spr,"TimeUpdate"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z9950.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z9950.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z9950.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z9950.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)

    
    Exit Function 
Catch ex As Exception
            'Call MsgBoxP"K9950_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K9950_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9950 As T9950_AREA,CheckClear as Boolean,AUTOKEY AS Double) as Boolean

K9950_MOVE = False

Try
    If READ_PFK9950(AUTOKEY) = True Then
                z9950 = D9950
		K9950_MOVE = True
		else
	If CheckClear  = True then z9950 = nothing
     End If

     If  getColumnIndex(spr,"Autokey") > -1 then z9950.Autokey = Cdecp(getDataM(spr, getColumnIndex(spr,"Autokey"), xRow))
     If  getColumnIndex(spr,"ProgramNo") > -1 then z9950.ProgramNo = getDataM(spr, getColumnIndex(spr,"ProgramNo"), xRow)
     If  getColumnIndex(spr,"Content") > -1 then z9950.Content = getDataM(spr, getColumnIndex(spr,"Content"), xRow)
     If  getColumnIndex(spr,"seSite") > -1 then z9950.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z9950.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)
     If  getColumnIndex(spr,"TimeInsert") > -1 then z9950.TimeInsert = getDataM(spr, getColumnIndex(spr,"TimeInsert"), xRow)
     If  getColumnIndex(spr,"TimeUpdate") > -1 then z9950.TimeUpdate = getDataM(spr, getColumnIndex(spr,"TimeUpdate"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z9950.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z9950.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z9950.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z9950.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)

    
    Exit Function 
Catch ex As Exception
            'Call MsgBoxP"K9950_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K9950_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9950 As T9950_AREA, Job as String, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9950_MOVE = False

Try
    If READ_PFK9950(AUTOKEY) = True Then
                z9950 = D9950
		K9950_MOVE = True
		else
	z9950 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9950")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z9950.Autokey = Children(i).Code
   Case "PROGRAMNO":z9950.ProgramNo = Children(i).Code
   Case "CONTENT":z9950.Content = Children(i).Code
   Case "SESITE":z9950.seSite = Children(i).Code
   Case "CDSITE":z9950.cdSite = Children(i).Code
   Case "TIMEINSERT":z9950.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z9950.TimeUpdate = Children(i).Code
   Case "DATEINSERT":z9950.DateInsert = Children(i).Code
   Case "DATEUPDATE":z9950.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z9950.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z9950.InchargeUpdate = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z9950.Autokey = Cdecp(Children(i).Data)
   Case "PROGRAMNO":z9950.ProgramNo = Children(i).Data
   Case "CONTENT":z9950.Content = Children(i).Data
   Case "SESITE":z9950.seSite = Children(i).Data
   Case "CDSITE":z9950.cdSite = Children(i).Data
   Case "TIMEINSERT":z9950.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z9950.TimeUpdate = Children(i).Data
   Case "DATEINSERT":z9950.DateInsert = Children(i).Data
   Case "DATEUPDATE":z9950.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z9950.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z9950.InchargeUpdate = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
            'Call MsgBoxP"K9950_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K9950_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9950 As T9950_AREA, Job as String, CheckClear as Boolean, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9950_MOVE = False

Try
    If READ_PFK9950(AUTOKEY) = True Then
                z9950 = D9950
		K9950_MOVE = True
		else
	If CheckClear  = True then z9950 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9950")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z9950.Autokey = Children(i).Code
   Case "PROGRAMNO":z9950.ProgramNo = Children(i).Code
   Case "CONTENT":z9950.Content = Children(i).Code
   Case "SESITE":z9950.seSite = Children(i).Code
   Case "CDSITE":z9950.cdSite = Children(i).Code
   Case "TIMEINSERT":z9950.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z9950.TimeUpdate = Children(i).Code
   Case "DATEINSERT":z9950.DateInsert = Children(i).Code
   Case "DATEUPDATE":z9950.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z9950.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z9950.InchargeUpdate = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z9950.Autokey = Cdecp(Children(i).Data)
   Case "PROGRAMNO":z9950.ProgramNo = Children(i).Data
   Case "CONTENT":z9950.Content = Children(i).Data
   Case "SESITE":z9950.seSite = Children(i).Data
   Case "CDSITE":z9950.cdSite = Children(i).Data
   Case "TIMEINSERT":z9950.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z9950.TimeUpdate = Children(i).Data
   Case "DATEINSERT":z9950.DateInsert = Children(i).Data
   Case "DATEUPDATE":z9950.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z9950.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z9950.InchargeUpdate = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
            'Call MsgBoxP"K9950_MOVE",vbCritical)
End Try
End Function 
    

'=========================================================================================================================================================
' DATA MOVE FORM NEW AREA
'=========================================================================================================================================================
Public Sub K9950_MOVE(ByRef a9950 As T9950_AREA, ByRef b9950 As T9950_AREA) 
Try
If trim$( a9950.Autokey ) = "" Then b9950.Autokey = ""  Else b9950.Autokey=a9950.Autokey
If trim$( a9950.ProgramNo ) = "" Then b9950.ProgramNo = ""  Else b9950.ProgramNo=a9950.ProgramNo
If trim$( a9950.Content ) = "" Then b9950.Content = ""  Else b9950.Content=a9950.Content
If trim$( a9950.seSite ) = "" Then b9950.seSite = ""  Else b9950.seSite=a9950.seSite
If trim$( a9950.cdSite ) = "" Then b9950.cdSite = ""  Else b9950.cdSite=a9950.cdSite
If trim$( a9950.TimeInsert ) = "" Then b9950.TimeInsert = ""  Else b9950.TimeInsert=a9950.TimeInsert
If trim$( a9950.TimeUpdate ) = "" Then b9950.TimeUpdate = ""  Else b9950.TimeUpdate=a9950.TimeUpdate
If trim$( a9950.DateInsert ) = "" Then b9950.DateInsert = ""  Else b9950.DateInsert=a9950.DateInsert
If trim$( a9950.DateUpdate ) = "" Then b9950.DateUpdate = ""  Else b9950.DateUpdate=a9950.DateUpdate
If trim$( a9950.InchargeInsert ) = "" Then b9950.InchargeInsert = ""  Else b9950.InchargeInsert=a9950.InchargeInsert
If trim$( a9950.InchargeUpdate ) = "" Then b9950.InchargeUpdate = ""  Else b9950.InchargeUpdate=a9950.InchargeUpdate
Catch ex As Exception
            'Call MsgBoxP"K9950_MOVE",vbCritical)
End Try
End Sub 


End Module 
