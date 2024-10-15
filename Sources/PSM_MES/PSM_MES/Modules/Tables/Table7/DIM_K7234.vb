'=========================================================================================================================================================
'   TABLE : (PFK7234)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7234

Structure T7234_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	MaterialCode	 AS String	'			char(6)		*
Public 	PackingSeq	 AS Double	'			decimal		*
Public 	seUnitPacking	 AS String	'			char(3)
Public 	cdUnitPacking	 AS String	'			char(3)
Public 	QtyBasic	 AS Double	'			decimal
Public 	seUnitMaterial	 AS String	'			char(3)
Public 	cdUnitMaterial	 AS String	'			char(3)
Public 	PackingName	 AS String	'			nvarchar(100)
Public 	Remark	 AS String	'			nvarchar(100)
'=========================================================================================================================================================
End structure

Public D7234 As T7234_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7234(MATERIALCODE AS String, PACKINGSEQ AS Double) As Boolean
    READ_PFK7234 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7234 "
    SQL = SQL & " WHERE K7234_MaterialCode		 = '" & MaterialCode & "' " 
    SQL = SQL & "   AND K7234_PackingSeq		 =  " & PackingSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7234_CLEAR: GoTo SKIP_READ_PFK7234
                
    Call K7234_MOVE(rd)
    READ_PFK7234 = True

SKIP_READ_PFK7234:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7234",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7234(MATERIALCODE AS String, PACKINGSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7234 "
    SQL = SQL & " WHERE K7234_MaterialCode		 = '" & MaterialCode & "' " 
    SQL = SQL & "   AND K7234_PackingSeq		 =  " & PackingSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7234",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7234(z7234 As T7234_AREA) As Boolean
    WRITE_PFK7234 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7234)
 
    SQL = " INSERT INTO PFK7234 "
    SQL = SQL & " ( "
    SQL = SQL & " K7234_MaterialCode," 
    SQL = SQL & " K7234_PackingSeq," 
    SQL = SQL & " K7234_seUnitPacking," 
    SQL = SQL & " K7234_cdUnitPacking," 
    SQL = SQL & " K7234_QtyBasic," 
    SQL = SQL & " K7234_seUnitMaterial," 
    SQL = SQL & " K7234_cdUnitMaterial," 
    SQL = SQL & " K7234_PackingName," 
    SQL = SQL & " K7234_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7234.MaterialCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7234.PackingSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7234.seUnitPacking) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7234.cdUnitPacking) & "', "  
    SQL = SQL & "   " & FormatSQL(z7234.QtyBasic) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7234.seUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7234.cdUnitMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7234.PackingName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7234.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7234 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7234",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7234(z7234 As T7234_AREA) As Boolean
    REWRITE_PFK7234 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7234)
   
    SQL = " UPDATE PFK7234 SET "
    SQL = SQL & "    K7234_seUnitPacking      = N'" & FormatSQL(z7234.seUnitPacking) & "', " 
    SQL = SQL & "    K7234_cdUnitPacking      = N'" & FormatSQL(z7234.cdUnitPacking) & "', " 
    SQL = SQL & "    K7234_QtyBasic      =  " & FormatSQL(z7234.QtyBasic) & ", " 
    SQL = SQL & "    K7234_seUnitMaterial      = N'" & FormatSQL(z7234.seUnitMaterial) & "', " 
    SQL = SQL & "    K7234_cdUnitMaterial      = N'" & FormatSQL(z7234.cdUnitMaterial) & "', " 
    SQL = SQL & "    K7234_PackingName      = N'" & FormatSQL(z7234.PackingName) & "', " 
    SQL = SQL & "    K7234_Remark      = N'" & FormatSQL(z7234.Remark) & "'  " 
    SQL = SQL & " WHERE K7234_MaterialCode		 = '" & z7234.MaterialCode & "' " 
    SQL = SQL & "   AND K7234_PackingSeq		 =  " & z7234.PackingSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7234 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7234",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7234(z7234 As T7234_AREA) As Boolean
    DELETE_PFK7234 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7234 "
    SQL = SQL & " WHERE K7234_MaterialCode		 = '" & z7234.MaterialCode & "' " 
    SQL = SQL & "   AND K7234_PackingSeq		 =  " & z7234.PackingSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7234 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7234",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7234_CLEAR()
Try
    
   D7234.MaterialCode = ""
    D7234.PackingSeq = 0 
   D7234.seUnitPacking = ""
   D7234.cdUnitPacking = ""
    D7234.QtyBasic = 0 
   D7234.seUnitMaterial = ""
   D7234.cdUnitMaterial = ""
   D7234.PackingName = ""
   D7234.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7234_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7234 As T7234_AREA)
Try
    
    x7234.MaterialCode = trim$(  x7234.MaterialCode)
    x7234.PackingSeq = trim$(  x7234.PackingSeq)
    x7234.seUnitPacking = trim$(  x7234.seUnitPacking)
    x7234.cdUnitPacking = trim$(  x7234.cdUnitPacking)
    x7234.QtyBasic = trim$(  x7234.QtyBasic)
    x7234.seUnitMaterial = trim$(  x7234.seUnitMaterial)
    x7234.cdUnitMaterial = trim$(  x7234.cdUnitMaterial)
    x7234.PackingName = trim$(  x7234.PackingName)
    x7234.Remark = trim$(  x7234.Remark)
     
    If trim$( x7234.MaterialCode ) = "" Then x7234.MaterialCode = Space(1) 
    If trim$( x7234.PackingSeq ) = "" Then x7234.PackingSeq = 0 
    If trim$( x7234.seUnitPacking ) = "" Then x7234.seUnitPacking = Space(1) 
    If trim$( x7234.cdUnitPacking ) = "" Then x7234.cdUnitPacking = Space(1) 
    If trim$( x7234.QtyBasic ) = "" Then x7234.QtyBasic = 0 
    If trim$( x7234.seUnitMaterial ) = "" Then x7234.seUnitMaterial = Space(1) 
    If trim$( x7234.cdUnitMaterial ) = "" Then x7234.cdUnitMaterial = Space(1) 
    If trim$( x7234.PackingName ) = "" Then x7234.PackingName = Space(1) 
    If trim$( x7234.Remark ) = "" Then x7234.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7234_MOVE(rs7234 As SqlClient.SqlDataReader)
Try

    call D7234_CLEAR()   

    If IsdbNull(rs7234!K7234_MaterialCode) = False Then D7234.MaterialCode = Trim$(rs7234!K7234_MaterialCode)
    If IsdbNull(rs7234!K7234_PackingSeq) = False Then D7234.PackingSeq = Trim$(rs7234!K7234_PackingSeq)
    If IsdbNull(rs7234!K7234_seUnitPacking) = False Then D7234.seUnitPacking = Trim$(rs7234!K7234_seUnitPacking)
    If IsdbNull(rs7234!K7234_cdUnitPacking) = False Then D7234.cdUnitPacking = Trim$(rs7234!K7234_cdUnitPacking)
    If IsdbNull(rs7234!K7234_QtyBasic) = False Then D7234.QtyBasic = Trim$(rs7234!K7234_QtyBasic)
    If IsdbNull(rs7234!K7234_seUnitMaterial) = False Then D7234.seUnitMaterial = Trim$(rs7234!K7234_seUnitMaterial)
    If IsdbNull(rs7234!K7234_cdUnitMaterial) = False Then D7234.cdUnitMaterial = Trim$(rs7234!K7234_cdUnitMaterial)
    If IsdbNull(rs7234!K7234_PackingName) = False Then D7234.PackingName = Trim$(rs7234!K7234_PackingName)
    If IsdbNull(rs7234!K7234_Remark) = False Then D7234.Remark = Trim$(rs7234!K7234_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7234_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7234_MOVE(rs7234 As DataRow)
Try

    call D7234_CLEAR()   

    If IsdbNull(rs7234!K7234_MaterialCode) = False Then D7234.MaterialCode = Trim$(rs7234!K7234_MaterialCode)
    If IsdbNull(rs7234!K7234_PackingSeq) = False Then D7234.PackingSeq = Trim$(rs7234!K7234_PackingSeq)
    If IsdbNull(rs7234!K7234_seUnitPacking) = False Then D7234.seUnitPacking = Trim$(rs7234!K7234_seUnitPacking)
    If IsdbNull(rs7234!K7234_cdUnitPacking) = False Then D7234.cdUnitPacking = Trim$(rs7234!K7234_cdUnitPacking)
    If IsdbNull(rs7234!K7234_QtyBasic) = False Then D7234.QtyBasic = Trim$(rs7234!K7234_QtyBasic)
    If IsdbNull(rs7234!K7234_seUnitMaterial) = False Then D7234.seUnitMaterial = Trim$(rs7234!K7234_seUnitMaterial)
    If IsdbNull(rs7234!K7234_cdUnitMaterial) = False Then D7234.cdUnitMaterial = Trim$(rs7234!K7234_cdUnitMaterial)
    If IsdbNull(rs7234!K7234_PackingName) = False Then D7234.PackingName = Trim$(rs7234!K7234_PackingName)
    If IsdbNull(rs7234!K7234_Remark) = False Then D7234.Remark = Trim$(rs7234!K7234_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7234_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7234_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7234 As T7234_AREA, MATERIALCODE AS String, PACKINGSEQ AS Double) as Boolean

K7234_MOVE = False

Try
    If READ_PFK7234(MATERIALCODE, PACKINGSEQ) = True Then
                z7234 = D7234
		K7234_MOVE = True
		else
	z7234 = nothing
     End If

     If  getColumIndex(spr,"MaterialCode") > -1 then z7234.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"PackingSeq") > -1 then z7234.PackingSeq = getDataM(spr, getColumIndex(spr,"PackingSeq"), xRow)
     If  getColumIndex(spr,"seUnitPacking") > -1 then z7234.seUnitPacking = getDataM(spr, getColumIndex(spr,"seUnitPacking"), xRow)
     If  getColumIndex(spr,"cdUnitPacking") > -1 then z7234.cdUnitPacking = getDataM(spr, getColumIndex(spr,"cdUnitPacking"), xRow)
     If  getColumIndex(spr,"QtyBasic") > -1 then z7234.QtyBasic = getDataM(spr, getColumIndex(spr,"QtyBasic"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z7234.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitMaterial") > -1 then z7234.cdUnitMaterial = getDataM(spr, getColumIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumIndex(spr,"PackingName") > -1 then z7234.PackingName = getDataM(spr, getColumIndex(spr,"PackingName"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7234.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7234_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7234_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7234 As T7234_AREA,CheckClear as Boolean,MATERIALCODE AS String, PACKINGSEQ AS Double) as Boolean

K7234_MOVE = False

Try
    If READ_PFK7234(MATERIALCODE, PACKINGSEQ) = True Then
                z7234 = D7234
		K7234_MOVE = True
		else
	If CheckClear  = True then z7234 = nothing
     End If

     If  getColumIndex(spr,"MaterialCode") > -1 then z7234.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"PackingSeq") > -1 then z7234.PackingSeq = getDataM(spr, getColumIndex(spr,"PackingSeq"), xRow)
     If  getColumIndex(spr,"seUnitPacking") > -1 then z7234.seUnitPacking = getDataM(spr, getColumIndex(spr,"seUnitPacking"), xRow)
     If  getColumIndex(spr,"cdUnitPacking") > -1 then z7234.cdUnitPacking = getDataM(spr, getColumIndex(spr,"cdUnitPacking"), xRow)
     If  getColumIndex(spr,"QtyBasic") > -1 then z7234.QtyBasic = getDataM(spr, getColumIndex(spr,"QtyBasic"), xRow)
     If  getColumIndex(spr,"seUnitMaterial") > -1 then z7234.seUnitMaterial = getDataM(spr, getColumIndex(spr,"seUnitMaterial"), xRow)
     If  getColumIndex(spr,"cdUnitMaterial") > -1 then z7234.cdUnitMaterial = getDataM(spr, getColumIndex(spr,"cdUnitMaterial"), xRow)
     If  getColumIndex(spr,"PackingName") > -1 then z7234.PackingName = getDataM(spr, getColumIndex(spr,"PackingName"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7234.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7234_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7234_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7234 As T7234_AREA, Job as String, MATERIALCODE AS String, PACKINGSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7234_MOVE = False

Try
    If READ_PFK7234(MATERIALCODE, PACKINGSEQ) = True Then
                z7234 = D7234
		K7234_MOVE = True
		else
	z7234 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7234")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MATERIALCODE":z7234.MaterialCode = Children(i).Code
   Case "PACKINGSEQ":z7234.PackingSeq = Children(i).Code
   Case "SEUNITPACKING":z7234.seUnitPacking = Children(i).Code
   Case "CDUNITPACKING":z7234.cdUnitPacking = Children(i).Code
   Case "QTYBASIC":z7234.QtyBasic = Children(i).Code
   Case "SEUNITMATERIAL":z7234.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z7234.cdUnitMaterial = Children(i).Code
   Case "PACKINGNAME":z7234.PackingName = Children(i).Code
   Case "REMARK":z7234.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MATERIALCODE":z7234.MaterialCode = Children(i).Data
   Case "PACKINGSEQ":z7234.PackingSeq = Children(i).Data
   Case "SEUNITPACKING":z7234.seUnitPacking = Children(i).Data
   Case "CDUNITPACKING":z7234.cdUnitPacking = Children(i).Data
   Case "QTYBASIC":z7234.QtyBasic = Children(i).Data
   Case "SEUNITMATERIAL":z7234.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z7234.cdUnitMaterial = Children(i).Data
   Case "PACKINGNAME":z7234.PackingName = Children(i).Data
   Case "REMARK":z7234.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7234_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7234_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7234 As T7234_AREA, Job as String, CheckClear as Boolean, MATERIALCODE AS String, PACKINGSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7234_MOVE = False

Try
    If READ_PFK7234(MATERIALCODE, PACKINGSEQ) = True Then
                z7234 = D7234
		K7234_MOVE = True
		else
	If CheckClear  = True then z7234 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7234")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "MATERIALCODE":z7234.MaterialCode = Children(i).Code
   Case "PACKINGSEQ":z7234.PackingSeq = Children(i).Code
   Case "SEUNITPACKING":z7234.seUnitPacking = Children(i).Code
   Case "CDUNITPACKING":z7234.cdUnitPacking = Children(i).Code
   Case "QTYBASIC":z7234.QtyBasic = Children(i).Code
   Case "SEUNITMATERIAL":z7234.seUnitMaterial = Children(i).Code
   Case "CDUNITMATERIAL":z7234.cdUnitMaterial = Children(i).Code
   Case "PACKINGNAME":z7234.PackingName = Children(i).Code
   Case "REMARK":z7234.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "MATERIALCODE":z7234.MaterialCode = Children(i).Data
   Case "PACKINGSEQ":z7234.PackingSeq = Children(i).Data
   Case "SEUNITPACKING":z7234.seUnitPacking = Children(i).Data
   Case "CDUNITPACKING":z7234.cdUnitPacking = Children(i).Data
   Case "QTYBASIC":z7234.QtyBasic = Children(i).Data
   Case "SEUNITMATERIAL":z7234.seUnitMaterial = Children(i).Data
   Case "CDUNITMATERIAL":z7234.cdUnitMaterial = Children(i).Data
   Case "PACKINGNAME":z7234.PackingName = Children(i).Data
   Case "REMARK":z7234.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7234_MOVE",vbCritical)
End Try
End Function 
    
End Module 
