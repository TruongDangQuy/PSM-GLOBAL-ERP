'=========================================================================================================================================================
'   TABLE : (PFK3208)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3208

Structure T3208_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	GroupComponentBOM	 AS String	'			char(6)		*
Public 	ShoesCode	 AS String	'			char(6)
Public 	GroupComponentBOMName	 AS String	'			nvarchar(200)
Public 	CheckUse	 AS String	'			char(1)
Public 	ChecComplete	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(50)
Public 	QtyTTL	 AS Double	'			decimal
Public 	TimeInsert	 AS String	'			char(14)
Public 	TimeUpdate	 AS String	'			char(14)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	seSite	 AS String	'			char(3)
Public 	cdSite	 AS String	'			char(3)
'=========================================================================================================================================================
End structure

Public D3208 As T3208_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK3208(GROUPCOMPONENTBOM AS String) As Boolean
    READ_PFK3208 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3208 "
    SQL = SQL & " WHERE K3208_GroupComponentBOM		 = '" & GroupComponentBOM & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D3208_CLEAR: GoTo SKIP_READ_PFK3208
                
    Call K3208_MOVE(rd)
    READ_PFK3208 = True

SKIP_READ_PFK3208:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK3208",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK3208(GROUPCOMPONENTBOM AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK3208 "
    SQL = SQL & " WHERE K3208_GroupComponentBOM		 = '" & GroupComponentBOM & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK3208",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK3208(z3208 As T3208_AREA) As Boolean
    WRITE_PFK3208 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z3208)
 
    SQL = " INSERT INTO PFK3208 "
    SQL = SQL & " ( "
    SQL = SQL & " K3208_GroupComponentBOM," 
    SQL = SQL & " K3208_ShoesCode," 
    SQL = SQL & " K3208_GroupComponentBOMName," 
    SQL = SQL & " K3208_CheckUse," 
    SQL = SQL & " K3208_ChecComplete," 
    SQL = SQL & " K3208_Remark," 
    SQL = SQL & " K3208_QtyTTL," 
    SQL = SQL & " K3208_TimeInsert," 
    SQL = SQL & " K3208_TimeUpdate," 
    SQL = SQL & " K3208_InchargeInsert," 
    SQL = SQL & " K3208_InchargeUpdate," 
    SQL = SQL & " K3208_DateInsert," 
    SQL = SQL & " K3208_DateUpdate," 
    SQL = SQL & " K3208_seSite," 
    SQL = SQL & " K3208_cdSite " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z3208.GroupComponentBOM) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3208.ShoesCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3208.GroupComponentBOMName) & "', "  
        SQL = SQL & "  N'1', "  
    SQL = SQL & "  N'" & FormatSQL(z3208.ChecComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3208.Remark) & "', "  
    SQL = SQL & "   " & FormatSQL(z3208.QtyTTL) & ", "  
    SQL = SQL & "  N'" & FormatSQL(PUB.TIME) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3208.TimeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3208.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3208.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3208.seSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z3208.cdSite) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK3208 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK3208",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK3208(z3208 As T3208_AREA) As Boolean
    REWRITE_PFK3208 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3208)
   
    SQL = " UPDATE PFK3208 SET "
    SQL = SQL & "    K3208_ShoesCode      = N'" & FormatSQL(z3208.ShoesCode) & "', " 
    SQL = SQL & "    K3208_GroupComponentBOMName      = N'" & FormatSQL(z3208.GroupComponentBOMName) & "', " 
    SQL = SQL & "    K3208_CheckUse      = N'" & FormatSQL(z3208.CheckUse) & "', " 
    SQL = SQL & "    K3208_ChecComplete      = N'" & FormatSQL(z3208.ChecComplete) & "', " 
    SQL = SQL & "    K3208_Remark      = N'" & FormatSQL(z3208.Remark) & "', " 
    SQL = SQL & "    K3208_QtyTTL      =  " & FormatSQL(z3208.QtyTTL) & ", " 
    SQL = SQL & "    K3208_TimeInsert      = N'" & FormatSQL(z3208.TimeInsert) & "', " 
    SQL = SQL & "    K3208_TimeUpdate      = N'" & FormatSQL(PUB.TIME) & "', " 
    SQL = SQL & "    K3208_InchargeInsert      = N'" & FormatSQL(z3208.InchargeInsert) & "', " 
    SQL = SQL & "    K3208_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "', " 
    SQL = SQL & "    K3208_DateInsert      = N'" & FormatSQL(z3208.DateInsert) & "', " 
    SQL = SQL & "    K3208_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', " 
    SQL = SQL & "    K3208_seSite      = N'" & FormatSQL(z3208.seSite) & "', " 
    SQL = SQL & "    K3208_cdSite      = N'" & FormatSQL(z3208.cdSite) & "'  " 
    SQL = SQL & " WHERE K3208_GroupComponentBOM		 = '" & z3208.GroupComponentBOM & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  

    REWRITE_PFK3208 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK3208",vbCritical)

  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK3208(z3208 As T3208_AREA) As Boolean
    DELETE_PFK3208 = False

   Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z3208)
      
        SQL = " DELETE FROM PFK3208  "
    SQL = SQL & " WHERE K3208_GroupComponentBOM		 = '" & z3208.GroupComponentBOM & "' " 

    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK3208 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK3208",vbCritical)
Finally
        Call GetFullInformation("PFK3208", "D", SQL)
  End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D3208_CLEAR()
Try
    
   D3208.GroupComponentBOM = ""
   D3208.ShoesCode = ""
   D3208.GroupComponentBOMName = ""
   D3208.CheckUse = ""
   D3208.ChecComplete = ""
   D3208.Remark = ""
    D3208.QtyTTL = 0 
   D3208.TimeInsert = ""
   D3208.TimeUpdate = ""
   D3208.InchargeInsert = ""
   D3208.InchargeUpdate = ""
   D3208.DateInsert = ""
   D3208.DateUpdate = ""
   D3208.seSite = ""
   D3208.cdSite = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D3208_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x3208 As T3208_AREA)
Try
    
    x3208.GroupComponentBOM = trim$(  x3208.GroupComponentBOM)
    x3208.ShoesCode = trim$(  x3208.ShoesCode)
    x3208.GroupComponentBOMName = trim$(  x3208.GroupComponentBOMName)
    x3208.CheckUse = trim$(  x3208.CheckUse)
    x3208.ChecComplete = trim$(  x3208.ChecComplete)
    x3208.Remark = trim$(  x3208.Remark)
    x3208.QtyTTL = trim$(  x3208.QtyTTL)
    x3208.TimeInsert = trim$(  x3208.TimeInsert)
    x3208.TimeUpdate = trim$(  x3208.TimeUpdate)
    x3208.InchargeInsert = trim$(  x3208.InchargeInsert)
    x3208.InchargeUpdate = trim$(  x3208.InchargeUpdate)
    x3208.DateInsert = trim$(  x3208.DateInsert)
    x3208.DateUpdate = trim$(  x3208.DateUpdate)
    x3208.seSite = trim$(  x3208.seSite)
    x3208.cdSite = trim$(  x3208.cdSite)
     
    If trim$( x3208.GroupComponentBOM ) = "" Then x3208.GroupComponentBOM = Space(1) 
    If trim$( x3208.ShoesCode ) = "" Then x3208.ShoesCode = Space(1) 
    If trim$( x3208.GroupComponentBOMName ) = "" Then x3208.GroupComponentBOMName = Space(1) 
    If trim$( x3208.CheckUse ) = "" Then x3208.CheckUse = Space(1) 
    If trim$( x3208.ChecComplete ) = "" Then x3208.ChecComplete = Space(1) 
    If trim$( x3208.Remark ) = "" Then x3208.Remark = Space(1) 
    If trim$( x3208.QtyTTL ) = "" Then x3208.QtyTTL = 0 
    If trim$( x3208.TimeInsert ) = "" Then x3208.TimeInsert = Space(1) 
    If trim$( x3208.TimeUpdate ) = "" Then x3208.TimeUpdate = Space(1) 
    If trim$( x3208.InchargeInsert ) = "" Then x3208.InchargeInsert = Space(1) 
    If trim$( x3208.InchargeUpdate ) = "" Then x3208.InchargeUpdate = Space(1) 
    If trim$( x3208.DateInsert ) = "" Then x3208.DateInsert = Space(1) 
    If trim$( x3208.DateUpdate ) = "" Then x3208.DateUpdate = Space(1) 
    If trim$( x3208.seSite ) = "" Then x3208.seSite = Space(1) 
    If trim$( x3208.cdSite ) = "" Then x3208.cdSite = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K3208_MOVE(rs3208 As SqlClient.SqlDataReader)
Try

    call D3208_CLEAR()   

    If IsdbNull(rs3208!K3208_GroupComponentBOM) = False Then D3208.GroupComponentBOM = Trim$(rs3208!K3208_GroupComponentBOM)
    If IsdbNull(rs3208!K3208_ShoesCode) = False Then D3208.ShoesCode = Trim$(rs3208!K3208_ShoesCode)
    If IsdbNull(rs3208!K3208_GroupComponentBOMName) = False Then D3208.GroupComponentBOMName = Trim$(rs3208!K3208_GroupComponentBOMName)
    If IsdbNull(rs3208!K3208_CheckUse) = False Then D3208.CheckUse = Trim$(rs3208!K3208_CheckUse)
    If IsdbNull(rs3208!K3208_ChecComplete) = False Then D3208.ChecComplete = Trim$(rs3208!K3208_ChecComplete)
    If IsdbNull(rs3208!K3208_Remark) = False Then D3208.Remark = Trim$(rs3208!K3208_Remark)
    If IsdbNull(rs3208!K3208_QtyTTL) = False Then D3208.QtyTTL = Trim$(rs3208!K3208_QtyTTL)
    If IsdbNull(rs3208!K3208_TimeInsert) = False Then D3208.TimeInsert = Trim$(rs3208!K3208_TimeInsert)
    If IsdbNull(rs3208!K3208_TimeUpdate) = False Then D3208.TimeUpdate = Trim$(rs3208!K3208_TimeUpdate)
    If IsdbNull(rs3208!K3208_InchargeInsert) = False Then D3208.InchargeInsert = Trim$(rs3208!K3208_InchargeInsert)
    If IsdbNull(rs3208!K3208_InchargeUpdate) = False Then D3208.InchargeUpdate = Trim$(rs3208!K3208_InchargeUpdate)
    If IsdbNull(rs3208!K3208_DateInsert) = False Then D3208.DateInsert = Trim$(rs3208!K3208_DateInsert)
    If IsdbNull(rs3208!K3208_DateUpdate) = False Then D3208.DateUpdate = Trim$(rs3208!K3208_DateUpdate)
    If IsdbNull(rs3208!K3208_seSite) = False Then D3208.seSite = Trim$(rs3208!K3208_seSite)
    If IsdbNull(rs3208!K3208_cdSite) = False Then D3208.cdSite = Trim$(rs3208!K3208_cdSite)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3208_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K3208_MOVE(rs3208 As DataRow)
Try

    call D3208_CLEAR()   

    If IsdbNull(rs3208!K3208_GroupComponentBOM) = False Then D3208.GroupComponentBOM = Trim$(rs3208!K3208_GroupComponentBOM)
    If IsdbNull(rs3208!K3208_ShoesCode) = False Then D3208.ShoesCode = Trim$(rs3208!K3208_ShoesCode)
    If IsdbNull(rs3208!K3208_GroupComponentBOMName) = False Then D3208.GroupComponentBOMName = Trim$(rs3208!K3208_GroupComponentBOMName)
    If IsdbNull(rs3208!K3208_CheckUse) = False Then D3208.CheckUse = Trim$(rs3208!K3208_CheckUse)
    If IsdbNull(rs3208!K3208_ChecComplete) = False Then D3208.ChecComplete = Trim$(rs3208!K3208_ChecComplete)
    If IsdbNull(rs3208!K3208_Remark) = False Then D3208.Remark = Trim$(rs3208!K3208_Remark)
    If IsdbNull(rs3208!K3208_QtyTTL) = False Then D3208.QtyTTL = Trim$(rs3208!K3208_QtyTTL)
    If IsdbNull(rs3208!K3208_TimeInsert) = False Then D3208.TimeInsert = Trim$(rs3208!K3208_TimeInsert)
    If IsdbNull(rs3208!K3208_TimeUpdate) = False Then D3208.TimeUpdate = Trim$(rs3208!K3208_TimeUpdate)
    If IsdbNull(rs3208!K3208_InchargeInsert) = False Then D3208.InchargeInsert = Trim$(rs3208!K3208_InchargeInsert)
    If IsdbNull(rs3208!K3208_InchargeUpdate) = False Then D3208.InchargeUpdate = Trim$(rs3208!K3208_InchargeUpdate)
    If IsdbNull(rs3208!K3208_DateInsert) = False Then D3208.DateInsert = Trim$(rs3208!K3208_DateInsert)
    If IsdbNull(rs3208!K3208_DateUpdate) = False Then D3208.DateUpdate = Trim$(rs3208!K3208_DateUpdate)
    If IsdbNull(rs3208!K3208_seSite) = False Then D3208.seSite = Trim$(rs3208!K3208_seSite)
    If IsdbNull(rs3208!K3208_cdSite) = False Then D3208.cdSite = Trim$(rs3208!K3208_cdSite)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K3208_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K3208_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3208 As T3208_AREA, GROUPCOMPONENTBOM AS String) as Boolean

K3208_MOVE = False

Try
    If READ_PFK3208(GROUPCOMPONENTBOM) = True Then
                z3208 = D3208
		K3208_MOVE = True
		else
	z3208 = nothing
     End If

     If  getColumnIndex(spr,"GroupComponentBOM") > -1 then z3208.GroupComponentBOM = getDataM(spr, getColumnIndex(spr,"GroupComponentBOM"), xRow)
     If  getColumnIndex(spr,"ShoesCode") > -1 then z3208.ShoesCode = getDataM(spr, getColumnIndex(spr,"ShoesCode"), xRow)
     If  getColumnIndex(spr,"GroupComponentBOMName") > -1 then z3208.GroupComponentBOMName = getDataM(spr, getColumnIndex(spr,"GroupComponentBOMName"), xRow)
     If  getColumnIndex(spr,"CheckUse") > -1 then z3208.CheckUse = getDataM(spr, getColumnIndex(spr,"CheckUse"), xRow)
     If  getColumnIndex(spr,"ChecComplete") > -1 then z3208.ChecComplete = getDataM(spr, getColumnIndex(spr,"ChecComplete"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z3208.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)
     If  getColumnIndex(spr,"QtyTTL") > -1 then z3208.QtyTTL = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyTTL"), xRow))
     If  getColumnIndex(spr,"TimeInsert") > -1 then z3208.TimeInsert = getDataM(spr, getColumnIndex(spr,"TimeInsert"), xRow)
     If  getColumnIndex(spr,"TimeUpdate") > -1 then z3208.TimeUpdate = getDataM(spr, getColumnIndex(spr,"TimeUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z3208.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z3208.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z3208.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z3208.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"seSite") > -1 then z3208.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z3208.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3208_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K3208_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z3208 As T3208_AREA,CheckClear as Boolean,GROUPCOMPONENTBOM AS String) as Boolean

K3208_MOVE = False

Try
    If READ_PFK3208(GROUPCOMPONENTBOM) = True Then
                z3208 = D3208
		K3208_MOVE = True
		else
	If CheckClear  = True then z3208 = nothing
     End If

     If  getColumnIndex(spr,"GroupComponentBOM") > -1 then z3208.GroupComponentBOM = getDataM(spr, getColumnIndex(spr,"GroupComponentBOM"), xRow)
     If  getColumnIndex(spr,"ShoesCode") > -1 then z3208.ShoesCode = getDataM(spr, getColumnIndex(spr,"ShoesCode"), xRow)
     If  getColumnIndex(spr,"GroupComponentBOMName") > -1 then z3208.GroupComponentBOMName = getDataM(spr, getColumnIndex(spr,"GroupComponentBOMName"), xRow)
     If  getColumnIndex(spr,"CheckUse") > -1 then z3208.CheckUse = getDataM(spr, getColumnIndex(spr,"CheckUse"), xRow)
     If  getColumnIndex(spr,"ChecComplete") > -1 then z3208.ChecComplete = getDataM(spr, getColumnIndex(spr,"ChecComplete"), xRow)
     If  getColumnIndex(spr,"Remark") > -1 then z3208.Remark = getDataM(spr, getColumnIndex(spr,"Remark"), xRow)
     If  getColumnIndex(spr,"QtyTTL") > -1 then z3208.QtyTTL = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyTTL"), xRow))
     If  getColumnIndex(spr,"TimeInsert") > -1 then z3208.TimeInsert = getDataM(spr, getColumnIndex(spr,"TimeInsert"), xRow)
     If  getColumnIndex(spr,"TimeUpdate") > -1 then z3208.TimeUpdate = getDataM(spr, getColumnIndex(spr,"TimeUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z3208.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z3208.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z3208.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z3208.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"seSite") > -1 then z3208.seSite = getDataM(spr, getColumnIndex(spr,"seSite"), xRow)
     If  getColumnIndex(spr,"cdSite") > -1 then z3208.cdSite = getDataM(spr, getColumnIndex(spr,"cdSite"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K3208_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K3208_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3208 As T3208_AREA, Job as String, GROUPCOMPONENTBOM AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3208_MOVE = False

Try
    If READ_PFK3208(GROUPCOMPONENTBOM) = True Then
                z3208 = D3208
		K3208_MOVE = True
		else
	z3208 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3208")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "GROUPCOMPONENTBOM":z3208.GroupComponentBOM = Children(i).Code
   Case "SHOESCODE":z3208.ShoesCode = Children(i).Code
   Case "GROUPCOMPONENTBOMNAME":z3208.GroupComponentBOMName = Children(i).Code
   Case "CHECKUSE":z3208.CheckUse = Children(i).Code
   Case "CHECCOMPLETE":z3208.ChecComplete = Children(i).Code
   Case "REMARK":z3208.Remark = Children(i).Code
   Case "QTYTTL":z3208.QtyTTL = Children(i).Code
   Case "TIMEINSERT":z3208.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z3208.TimeUpdate = Children(i).Code
   Case "INCHARGEINSERT":z3208.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z3208.InchargeUpdate = Children(i).Code
   Case "DATEINSERT":z3208.DateInsert = Children(i).Code
   Case "DATEUPDATE":z3208.DateUpdate = Children(i).Code
   Case "SESITE":z3208.seSite = Children(i).Code
   Case "CDSITE":z3208.cdSite = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "GROUPCOMPONENTBOM":z3208.GroupComponentBOM = Children(i).Data
   Case "SHOESCODE":z3208.ShoesCode = Children(i).Data
   Case "GROUPCOMPONENTBOMNAME":z3208.GroupComponentBOMName = Children(i).Data
   Case "CHECKUSE":z3208.CheckUse = Children(i).Data
   Case "CHECCOMPLETE":z3208.ChecComplete = Children(i).Data
   Case "REMARK":z3208.Remark = Children(i).Data
   Case "QTYTTL":z3208.QtyTTL = Cdecp(Children(i).Data)
   Case "TIMEINSERT":z3208.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z3208.TimeUpdate = Children(i).Data
   Case "INCHARGEINSERT":z3208.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z3208.InchargeUpdate = Children(i).Data
   Case "DATEINSERT":z3208.DateInsert = Children(i).Data
   Case "DATEUPDATE":z3208.DateUpdate = Children(i).Data
   Case "SESITE":z3208.seSite = Children(i).Data
   Case "CDSITE":z3208.cdSite = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3208_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K3208_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z3208 As T3208_AREA, Job as String, CheckClear as Boolean, GROUPCOMPONENTBOM AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K3208_MOVE = False

Try
    If READ_PFK3208(GROUPCOMPONENTBOM) = True Then
                z3208 = D3208
		K3208_MOVE = True
		else
	If CheckClear  = True then z3208 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3208")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "GROUPCOMPONENTBOM":z3208.GroupComponentBOM = Children(i).Code
   Case "SHOESCODE":z3208.ShoesCode = Children(i).Code
   Case "GROUPCOMPONENTBOMNAME":z3208.GroupComponentBOMName = Children(i).Code
   Case "CHECKUSE":z3208.CheckUse = Children(i).Code
   Case "CHECCOMPLETE":z3208.ChecComplete = Children(i).Code
   Case "REMARK":z3208.Remark = Children(i).Code
   Case "QTYTTL":z3208.QtyTTL = Children(i).Code
   Case "TIMEINSERT":z3208.TimeInsert = Children(i).Code
   Case "TIMEUPDATE":z3208.TimeUpdate = Children(i).Code
   Case "INCHARGEINSERT":z3208.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z3208.InchargeUpdate = Children(i).Code
   Case "DATEINSERT":z3208.DateInsert = Children(i).Code
   Case "DATEUPDATE":z3208.DateUpdate = Children(i).Code
   Case "SESITE":z3208.seSite = Children(i).Code
   Case "CDSITE":z3208.cdSite = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "GROUPCOMPONENTBOM":z3208.GroupComponentBOM = Children(i).Data
   Case "SHOESCODE":z3208.ShoesCode = Children(i).Data
   Case "GROUPCOMPONENTBOMNAME":z3208.GroupComponentBOMName = Children(i).Data
   Case "CHECKUSE":z3208.CheckUse = Children(i).Data
   Case "CHECCOMPLETE":z3208.ChecComplete = Children(i).Data
   Case "REMARK":z3208.Remark = Children(i).Data
   Case "QTYTTL":z3208.QtyTTL = Cdecp(Children(i).Data)
   Case "TIMEINSERT":z3208.TimeInsert = Children(i).Data
   Case "TIMEUPDATE":z3208.TimeUpdate = Children(i).Data
   Case "INCHARGEINSERT":z3208.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z3208.InchargeUpdate = Children(i).Data
   Case "DATEINSERT":z3208.DateInsert = Children(i).Data
   Case "DATEUPDATE":z3208.DateUpdate = Children(i).Data
   Case "SESITE":z3208.seSite = Children(i).Data
   Case "CDSITE":z3208.cdSite = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3208_MOVE",vbCritical)
End Try
End Function 
    

'=========================================================================================================================================================
' DATA MOVE FORM NEW AREA
'=========================================================================================================================================================
Public Sub K3208_MOVE(ByRef a3208 As T3208_AREA, ByRef b3208 As T3208_AREA) 
Try
If trim$( a3208.GroupComponentBOM ) = "" Then b3208.GroupComponentBOM = ""  Else b3208.GroupComponentBOM=a3208.GroupComponentBOM
If trim$( a3208.ShoesCode ) = "" Then b3208.ShoesCode = ""  Else b3208.ShoesCode=a3208.ShoesCode
If trim$( a3208.GroupComponentBOMName ) = "" Then b3208.GroupComponentBOMName = ""  Else b3208.GroupComponentBOMName=a3208.GroupComponentBOMName
If trim$( a3208.CheckUse ) = "" Then b3208.CheckUse = ""  Else b3208.CheckUse=a3208.CheckUse
If trim$( a3208.ChecComplete ) = "" Then b3208.ChecComplete = ""  Else b3208.ChecComplete=a3208.ChecComplete
If trim$( a3208.Remark ) = "" Then b3208.Remark = ""  Else b3208.Remark=a3208.Remark
If trim$( a3208.QtyTTL ) = "" Then b3208.QtyTTL = ""  Else b3208.QtyTTL=a3208.QtyTTL
If trim$( a3208.TimeInsert ) = "" Then b3208.TimeInsert = ""  Else b3208.TimeInsert=a3208.TimeInsert
If trim$( a3208.TimeUpdate ) = "" Then b3208.TimeUpdate = ""  Else b3208.TimeUpdate=a3208.TimeUpdate
If trim$( a3208.InchargeInsert ) = "" Then b3208.InchargeInsert = ""  Else b3208.InchargeInsert=a3208.InchargeInsert
If trim$( a3208.InchargeUpdate ) = "" Then b3208.InchargeUpdate = ""  Else b3208.InchargeUpdate=a3208.InchargeUpdate
If trim$( a3208.DateInsert ) = "" Then b3208.DateInsert = ""  Else b3208.DateInsert=a3208.DateInsert
If trim$( a3208.DateUpdate ) = "" Then b3208.DateUpdate = ""  Else b3208.DateUpdate=a3208.DateUpdate
If trim$( a3208.seSite ) = "" Then b3208.seSite = ""  Else b3208.seSite=a3208.seSite
If trim$( a3208.cdSite ) = "" Then b3208.cdSite = ""  Else b3208.cdSite=a3208.cdSite
Catch ex As Exception
      Call MsgBoxP("K3208_MOVE",vbCritical)
End Try
End Sub 


End Module 
