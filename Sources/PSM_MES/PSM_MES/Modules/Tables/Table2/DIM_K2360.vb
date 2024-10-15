'=========================================================================================================================================================
'   TABLE : (PFK2360)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K2360

Structure T2360_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	Autokey	 AS Double	'			decimal		*
Public 	OrderNo	 AS String	'			char(9)
Public 	OrderNoSeq	 AS String	'			char(3)
Public 	MaterialInBoundNo	 AS String	'			char(9)
Public 	MaterialInBoundSeq	 AS String	'			char(3)
Public 	MaterialInBoundSno	 AS Double	'			decimal
Public 	QtyInBound	 AS Double	'			decimal
Public 	seSite	 AS String	'			char(3)
Public 	cdSite	 AS String	'			char(3)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D2360 As T2360_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK2360(AUTOKEY AS Double) As Boolean
    READ_PFK2360 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK2360 "
    SQL = SQL & " WHERE K2360_Autokey		 =  " & Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D2360_CLEAR: GoTo SKIP_READ_PFK2360
                
    Call K2360_MOVE(rd)
    READ_PFK2360 = True

SKIP_READ_PFK2360:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK2360",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK2360(AUTOKEY AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK2360 "
    SQL = SQL & " WHERE K2360_Autokey		 =  " & Autokey & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK2360",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK2360(z2360 As T2360_AREA) As Boolean
    WRITE_PFK2360 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z2360)
 
    SQL = " INSERT INTO PFK2360 "
    SQL = SQL & " ( "
    SQL = SQL & " K2360_OrderNo," 
    SQL = SQL & " K2360_OrderNoSeq," 
    SQL = SQL & " K2360_MaterialInBoundNo," 
    SQL = SQL & " K2360_MaterialInBoundSeq," 
    SQL = SQL & " K2360_MaterialInBoundSno," 
    SQL = SQL & " K2360_QtyInBound," 
    SQL = SQL & " K2360_seSite," 
    SQL = SQL & " K2360_cdSite," 
    SQL = SQL & " K2360_DateInsert," 
    SQL = SQL & " K2360_DateUpdate," 
    SQL = SQL & " K2360_InchargeInsert," 
    SQL = SQL & " K2360_InchargeUpdate," 
    SQL = SQL & " K2360_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z2360.OrderNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2360.OrderNoSeq) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2360.MaterialInBoundNo) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2360.MaterialInBoundSeq) & "', "  
    SQL = SQL & "   " & FormatSQL(z2360.MaterialInBoundSno) & ", "  
    SQL = SQL & "   " & FormatSQL(z2360.QtyInBound) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z2360.seSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2360.cdSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2360.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2360.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2360.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2360.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z2360.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK2360 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK2360",vbCritical)
Finally
        Call GetFullInformation("PFK2360", "I", SQL)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK2360(z2360 As T2360_AREA) As Boolean
    REWRITE_PFK2360 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z2360)
   
    SQL = " UPDATE PFK2360 SET "
    SQL = SQL & "    K2360_OrderNo      = N'" & FormatSQL(z2360.OrderNo) & "', " 
    SQL = SQL & "    K2360_OrderNoSeq      = N'" & FormatSQL(z2360.OrderNoSeq) & "', " 
    SQL = SQL & "    K2360_MaterialInBoundNo      = N'" & FormatSQL(z2360.MaterialInBoundNo) & "', " 
    SQL = SQL & "    K2360_MaterialInBoundSeq      = N'" & FormatSQL(z2360.MaterialInBoundSeq) & "', " 
    SQL = SQL & "    K2360_MaterialInBoundSno      =  " & FormatSQL(z2360.MaterialInBoundSno) & ", " 
    SQL = SQL & "    K2360_QtyInBound      =  " & FormatSQL(z2360.QtyInBound) & ", " 
    SQL = SQL & "    K2360_seSite      = N'" & FormatSQL(z2360.seSite) & "', " 
    SQL = SQL & "    K2360_cdSite      = N'" & FormatSQL(z2360.cdSite) & "', " 
    SQL = SQL & "    K2360_DateInsert      = N'" & FormatSQL(z2360.DateInsert) & "', " 
    SQL = SQL & "    K2360_DateUpdate      = N'" & FormatSQL(z2360.DateUpdate) & "', " 
    SQL = SQL & "    K2360_InchargeInsert      = N'" & FormatSQL(z2360.InchargeInsert) & "', " 
    SQL = SQL & "    K2360_InchargeUpdate      = N'" & FormatSQL(z2360.InchargeUpdate) & "', " 
    SQL = SQL & "    K2360_Remark      = N'" & FormatSQL(z2360.Remark) & "'  " 
    SQL = SQL & " WHERE K2360_Autokey		 =  " & z2360.Autokey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
	REWRITE_PFK2360 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK2360",vbCritical)
Finally
        Call GetFullInformation("PFK2360", "U", SQL)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK2360(z2360 As T2360_AREA) As Boolean
    DELETE_PFK2360 = False

   Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z2360)
      
        SQL = " DELETE FROM PFK2360  "
    SQL = SQL & " WHERE K2360_Autokey		 =  " & z2360.Autokey & "  " 

    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK2360 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK2360",vbCritical)
Finally
        Call GetFullInformation("PFK2360", "U", SQL)
  End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D2360_CLEAR()
Try
    
    D2360.Autokey = 0 
   D2360.OrderNo = ""
   D2360.OrderNoSeq = ""
   D2360.MaterialInBoundNo = ""
   D2360.MaterialInBoundSeq = ""
    D2360.MaterialInBoundSno = 0 
    D2360.QtyInBound = 0 
   D2360.seSite = ""
   D2360.cdSite = ""
   D2360.DateInsert = ""
   D2360.DateUpdate = ""
   D2360.InchargeInsert = ""
   D2360.InchargeUpdate = ""
   D2360.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D2360_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x2360 As T2360_AREA)
Try
    
    x2360.Autokey = trim$(  x2360.Autokey)
    x2360.OrderNo = trim$(  x2360.OrderNo)
    x2360.OrderNoSeq = trim$(  x2360.OrderNoSeq)
    x2360.MaterialInBoundNo = trim$(  x2360.MaterialInBoundNo)
    x2360.MaterialInBoundSeq = trim$(  x2360.MaterialInBoundSeq)
    x2360.MaterialInBoundSno = trim$(  x2360.MaterialInBoundSno)
    x2360.QtyInBound = trim$(  x2360.QtyInBound)
    x2360.seSite = trim$(  x2360.seSite)
    x2360.cdSite = trim$(  x2360.cdSite)
    x2360.DateInsert = trim$(  x2360.DateInsert)
    x2360.DateUpdate = trim$(  x2360.DateUpdate)
    x2360.InchargeInsert = trim$(  x2360.InchargeInsert)
    x2360.InchargeUpdate = trim$(  x2360.InchargeUpdate)
    x2360.Remark = trim$(  x2360.Remark)
     
    If trim$( x2360.Autokey ) = "" Then x2360.Autokey = 0 
    If trim$( x2360.OrderNo ) = "" Then x2360.OrderNo = Space(1) 
    If trim$( x2360.OrderNoSeq ) = "" Then x2360.OrderNoSeq = Space(1) 
    If trim$( x2360.MaterialInBoundNo ) = "" Then x2360.MaterialInBoundNo = Space(1) 
    If trim$( x2360.MaterialInBoundSeq ) = "" Then x2360.MaterialInBoundSeq = Space(1) 
    If trim$( x2360.MaterialInBoundSno ) = "" Then x2360.MaterialInBoundSno = 0 
    If trim$( x2360.QtyInBound ) = "" Then x2360.QtyInBound = 0 
    If trim$( x2360.seSite ) = "" Then x2360.seSite = Space(1) 
    If trim$( x2360.cdSite ) = "" Then x2360.cdSite = Space(1) 
    If trim$( x2360.DateInsert ) = "" Then x2360.DateInsert = Space(1) 
    If trim$( x2360.DateUpdate ) = "" Then x2360.DateUpdate = Space(1) 
    If trim$( x2360.InchargeInsert ) = "" Then x2360.InchargeInsert = Space(1) 
    If trim$( x2360.InchargeUpdate ) = "" Then x2360.InchargeUpdate = Space(1) 
    If trim$( x2360.Remark ) = "" Then x2360.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K2360_MOVE(rs2360 As SqlClient.SqlDataReader)
Try

    call D2360_CLEAR()   

    If IsdbNull(rs2360!K2360_Autokey) = False Then D2360.Autokey = Trim$(rs2360!K2360_Autokey)
    If IsdbNull(rs2360!K2360_OrderNo) = False Then D2360.OrderNo = Trim$(rs2360!K2360_OrderNo)
    If IsdbNull(rs2360!K2360_OrderNoSeq) = False Then D2360.OrderNoSeq = Trim$(rs2360!K2360_OrderNoSeq)
    If IsdbNull(rs2360!K2360_MaterialInBoundNo) = False Then D2360.MaterialInBoundNo = Trim$(rs2360!K2360_MaterialInBoundNo)
    If IsdbNull(rs2360!K2360_MaterialInBoundSeq) = False Then D2360.MaterialInBoundSeq = Trim$(rs2360!K2360_MaterialInBoundSeq)
    If IsdbNull(rs2360!K2360_MaterialInBoundSno) = False Then D2360.MaterialInBoundSno = Trim$(rs2360!K2360_MaterialInBoundSno)
    If IsdbNull(rs2360!K2360_QtyInBound) = False Then D2360.QtyInBound = Trim$(rs2360!K2360_QtyInBound)
    If IsdbNull(rs2360!K2360_seSite) = False Then D2360.seSite = Trim$(rs2360!K2360_seSite)
    If IsdbNull(rs2360!K2360_cdSite) = False Then D2360.cdSite = Trim$(rs2360!K2360_cdSite)
    If IsdbNull(rs2360!K2360_DateInsert) = False Then D2360.DateInsert = Trim$(rs2360!K2360_DateInsert)
    If IsdbNull(rs2360!K2360_DateUpdate) = False Then D2360.DateUpdate = Trim$(rs2360!K2360_DateUpdate)
    If IsdbNull(rs2360!K2360_InchargeInsert) = False Then D2360.InchargeInsert = Trim$(rs2360!K2360_InchargeInsert)
    If IsdbNull(rs2360!K2360_InchargeUpdate) = False Then D2360.InchargeUpdate = Trim$(rs2360!K2360_InchargeUpdate)
    If IsdbNull(rs2360!K2360_Remark) = False Then D2360.Remark = Trim$(rs2360!K2360_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K2360_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K2360_MOVE(rs2360 As DataRow)
Try

    call D2360_CLEAR()   

    If IsdbNull(rs2360!K2360_Autokey) = False Then D2360.Autokey = Trim$(rs2360!K2360_Autokey)
    If IsdbNull(rs2360!K2360_OrderNo) = False Then D2360.OrderNo = Trim$(rs2360!K2360_OrderNo)
    If IsdbNull(rs2360!K2360_OrderNoSeq) = False Then D2360.OrderNoSeq = Trim$(rs2360!K2360_OrderNoSeq)
    If IsdbNull(rs2360!K2360_MaterialInBoundNo) = False Then D2360.MaterialInBoundNo = Trim$(rs2360!K2360_MaterialInBoundNo)
    If IsdbNull(rs2360!K2360_MaterialInBoundSeq) = False Then D2360.MaterialInBoundSeq = Trim$(rs2360!K2360_MaterialInBoundSeq)
    If IsdbNull(rs2360!K2360_MaterialInBoundSno) = False Then D2360.MaterialInBoundSno = Trim$(rs2360!K2360_MaterialInBoundSno)
    If IsdbNull(rs2360!K2360_QtyInBound) = False Then D2360.QtyInBound = Trim$(rs2360!K2360_QtyInBound)
    If IsdbNull(rs2360!K2360_seSite) = False Then D2360.seSite = Trim$(rs2360!K2360_seSite)
    If IsdbNull(rs2360!K2360_cdSite) = False Then D2360.cdSite = Trim$(rs2360!K2360_cdSite)
    If IsdbNull(rs2360!K2360_DateInsert) = False Then D2360.DateInsert = Trim$(rs2360!K2360_DateInsert)
    If IsdbNull(rs2360!K2360_DateUpdate) = False Then D2360.DateUpdate = Trim$(rs2360!K2360_DateUpdate)
    If IsdbNull(rs2360!K2360_InchargeInsert) = False Then D2360.InchargeInsert = Trim$(rs2360!K2360_InchargeInsert)
    If IsdbNull(rs2360!K2360_InchargeUpdate) = False Then D2360.InchargeUpdate = Trim$(rs2360!K2360_InchargeUpdate)
    If IsdbNull(rs2360!K2360_Remark) = False Then D2360.Remark = Trim$(rs2360!K2360_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K2360_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K2360_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z2360 As T2360_AREA, AUTOKEY AS Double) as Boolean

K2360_MOVE = False

Try
    If READ_PFK2360(AUTOKEY) = True Then
                z2360 = D2360
		K2360_MOVE = True
		else
	z2360 = nothing
     End If

     If  getColumnIndex(spr,"Autokey") > -1 then z2360.Autokey = getDataM(spr, getColumnIndex(spr,"Autokey"), xRow)
     If  getColumnIndex(spr,"OrderNo") > -1 then z2360.OrderNo = getDataM(spr, getColumnIndex(spr,"OrderNo"), xRow)
     If  getColumnIndex(spr,"OrderNoSeq") > -1 then z2360.OrderNoSeq = getDataM(spr, getColumnIndex(spr,"OrderNoSeq"), xRow)
     If  getColumnIndex(spr,"MaterialInBoundNo") > -1 then z2360.MaterialInBoundNo = getDataM(spr, getColumnIndex(spr,"MaterialInBoundNo"), xRow)
     If  getColumnIndex(spr,"MaterialInBoundSeq") > -1 then z2360.MaterialInBoundSeq = getDataM(spr, getColumnIndex(spr,"MaterialInBoundSeq"), xRow)
     If  getColumnIndex(spr,"MaterialInBoundSno") > -1 then z2360.MaterialInBoundSno = getDataM(spr, getColumnIndex(spr,"MaterialInBoundSno"), xRow)
     If  getColumnIndex(spr,"QtyInBound") > -1 then z2360.QtyInBound = getDataM(spr, getColumnIndex(spr,"QtyInBound"), xRow)
     If  getColumnIndex(spr,"seSite") > -1 then z2360.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z2360.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z2360.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z2360.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z2360.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z2360.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z2360.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K2360_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K2360_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z2360 As T2360_AREA,CheckClear as Boolean,AUTOKEY AS Double) as Boolean

K2360_MOVE = False

Try
    If READ_PFK2360(AUTOKEY) = True Then
                z2360 = D2360
		K2360_MOVE = True
		else
	If CheckClear  = True then z2360 = nothing
     End If

     If  getColumnIndex(spr,"Autokey") > -1 then z2360.Autokey = getDataM(spr, getColumnIndex(spr,"Autokey"), xRow)
     If  getColumnIndex(spr,"OrderNo") > -1 then z2360.OrderNo = getDataM(spr, getColumnIndex(spr,"OrderNo"), xRow)
     If  getColumnIndex(spr,"OrderNoSeq") > -1 then z2360.OrderNoSeq = getDataM(spr, getColumnIndex(spr,"OrderNoSeq"), xRow)
     If  getColumnIndex(spr,"MaterialInBoundNo") > -1 then z2360.MaterialInBoundNo = getDataM(spr, getColumnIndex(spr,"MaterialInBoundNo"), xRow)
     If  getColumnIndex(spr,"MaterialInBoundSeq") > -1 then z2360.MaterialInBoundSeq = getDataM(spr, getColumnIndex(spr,"MaterialInBoundSeq"), xRow)
     If  getColumnIndex(spr,"MaterialInBoundSno") > -1 then z2360.MaterialInBoundSno = getDataM(spr, getColumnIndex(spr,"MaterialInBoundSno"), xRow)
     If  getColumnIndex(spr,"QtyInBound") > -1 then z2360.QtyInBound = getDataM(spr, getColumnIndex(spr,"QtyInBound"), xRow)
     If  getColumnIndex(spr,"seSite") > -1 then z2360.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z2360.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z2360.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z2360.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z2360.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z2360.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z2360.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K2360_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K2360_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z2360 As T2360_AREA, Job as String, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K2360_MOVE = False

Try
    If READ_PFK2360(AUTOKEY) = True Then
                z2360 = D2360
		K2360_MOVE = True
		else
	z2360 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2360")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z2360.Autokey = Children(i).Code
   Case "ORDERNO":z2360.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z2360.OrderNoSeq = Children(i).Code
   Case "MATERIALINBOUNDNO":z2360.MaterialInBoundNo = Children(i).Code
   Case "MATERIALINBOUNDSEQ":z2360.MaterialInBoundSeq = Children(i).Code
   Case "MATERIALINBOUNDSNO":z2360.MaterialInBoundSno = Children(i).Code
   Case "QTYINBOUND":z2360.QtyInBound = Children(i).Code
   Case "SESITE":z2360.seSite = Children(i).Code
   Case "CDSITE":z2360.cdSite = Children(i).Code
   Case "DATEINSERT":z2360.DateInsert = Children(i).Code
   Case "DATEUPDATE":z2360.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z2360.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z2360.InchargeUpdate = Children(i).Code
   Case "REMARK":z2360.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z2360.Autokey = Children(i).Data
   Case "ORDERNO":z2360.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z2360.OrderNoSeq = Children(i).Data
   Case "MATERIALINBOUNDNO":z2360.MaterialInBoundNo = Children(i).Data
   Case "MATERIALINBOUNDSEQ":z2360.MaterialInBoundSeq = Children(i).Data
   Case "MATERIALINBOUNDSNO":z2360.MaterialInBoundSno = Children(i).Data
   Case "QTYINBOUND":z2360.QtyInBound = Children(i).Data
   Case "SESITE":z2360.seSite = Children(i).Data
   Case "CDSITE":z2360.cdSite = Children(i).Data
   Case "DATEINSERT":z2360.DateInsert = Children(i).Data
   Case "DATEUPDATE":z2360.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z2360.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z2360.InchargeUpdate = Children(i).Data
   Case "REMARK":z2360.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K2360_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K2360_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z2360 As T2360_AREA, Job as String, CheckClear as Boolean, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K2360_MOVE = False

Try
    If READ_PFK2360(AUTOKEY) = True Then
                z2360 = D2360
		K2360_MOVE = True
		else
	If CheckClear  = True then z2360 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2360")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z2360.Autokey = Children(i).Code
   Case "ORDERNO":z2360.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z2360.OrderNoSeq = Children(i).Code
   Case "MATERIALINBOUNDNO":z2360.MaterialInBoundNo = Children(i).Code
   Case "MATERIALINBOUNDSEQ":z2360.MaterialInBoundSeq = Children(i).Code
   Case "MATERIALINBOUNDSNO":z2360.MaterialInBoundSno = Children(i).Code
   Case "QTYINBOUND":z2360.QtyInBound = Children(i).Code
   Case "SESITE":z2360.seSite = Children(i).Code
   Case "CDSITE":z2360.cdSite = Children(i).Code
   Case "DATEINSERT":z2360.DateInsert = Children(i).Code
   Case "DATEUPDATE":z2360.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z2360.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z2360.InchargeUpdate = Children(i).Code
   Case "REMARK":z2360.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z2360.Autokey = Children(i).Data
   Case "ORDERNO":z2360.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z2360.OrderNoSeq = Children(i).Data
   Case "MATERIALINBOUNDNO":z2360.MaterialInBoundNo = Children(i).Data
   Case "MATERIALINBOUNDSEQ":z2360.MaterialInBoundSeq = Children(i).Data
   Case "MATERIALINBOUNDSNO":z2360.MaterialInBoundSno = Children(i).Data
   Case "QTYINBOUND":z2360.QtyInBound = Children(i).Data
   Case "SESITE":z2360.seSite = Children(i).Data
   Case "CDSITE":z2360.cdSite = Children(i).Data
   Case "DATEINSERT":z2360.DateInsert = Children(i).Data
   Case "DATEUPDATE":z2360.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z2360.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z2360.InchargeUpdate = Children(i).Data
   Case "REMARK":z2360.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K2360_MOVE",vbCritical)
End Try
End Function 
    

'=========================================================================================================================================================
' DATA MOVE FORM NEW AREA
'=========================================================================================================================================================
Public Sub K2360_MOVE(ByRef a2360 As T2360_AREA, ByRef b2360 As T2360_AREA) 
Try
If trim$( a2360.Autokey ) = "" Then b2360.Autokey = ""  Else b2360.Autokey=a2360.Autokey
If trim$( a2360.OrderNo ) = "" Then b2360.OrderNo = ""  Else b2360.OrderNo=a2360.OrderNo
If trim$( a2360.OrderNoSeq ) = "" Then b2360.OrderNoSeq = ""  Else b2360.OrderNoSeq=a2360.OrderNoSeq
If trim$( a2360.MaterialInBoundNo ) = "" Then b2360.MaterialInBoundNo = ""  Else b2360.MaterialInBoundNo=a2360.MaterialInBoundNo
If trim$( a2360.MaterialInBoundSeq ) = "" Then b2360.MaterialInBoundSeq = ""  Else b2360.MaterialInBoundSeq=a2360.MaterialInBoundSeq
If trim$( a2360.MaterialInBoundSno ) = "" Then b2360.MaterialInBoundSno = ""  Else b2360.MaterialInBoundSno=a2360.MaterialInBoundSno
If trim$( a2360.QtyInBound ) = "" Then b2360.QtyInBound = ""  Else b2360.QtyInBound=a2360.QtyInBound
If trim$( a2360.seSite ) = "" Then b2360.seSite = ""  Else b2360.seSite=a2360.seSite
If trim$( a2360.cdSite ) = "" Then b2360.cdSite = ""  Else b2360.cdSite=a2360.cdSite
If trim$( a2360.DateInsert ) = "" Then b2360.DateInsert = ""  Else b2360.DateInsert=a2360.DateInsert
If trim$( a2360.DateUpdate ) = "" Then b2360.DateUpdate = ""  Else b2360.DateUpdate=a2360.DateUpdate
If trim$( a2360.InchargeInsert ) = "" Then b2360.InchargeInsert = ""  Else b2360.InchargeInsert=a2360.InchargeInsert
If trim$( a2360.InchargeUpdate ) = "" Then b2360.InchargeUpdate = ""  Else b2360.InchargeUpdate=a2360.InchargeUpdate
If trim$( a2360.Remark ) = "" Then b2360.Remark = ""  Else b2360.Remark=a2360.Remark
Catch ex As Exception
      Call MsgBoxP("K2360_MOVE",vbCritical)
End Try
End Sub 


End Module 
