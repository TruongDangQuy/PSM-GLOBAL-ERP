'=========================================================================================================================================================
'   TABLE : (PFK7255)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7255

Structure T7255_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	YearMaterial	 AS String	'			char(4)		*
Public 	MonthMaterial	 AS String	'			char(2)		*
Public 	CustomerCode	 AS String	'			char(6)		*
Public 	MaterialCode	 AS String	'			char(6)		*
Public 	MaterialSeq	 AS Double	'			decimal		*
Public 	MaterialCodeBom	 AS String	'			char(6)
Public 	PriceMaterial	 AS Double	'			decimal
Public 	QtyPrescription	 AS Double	'			decimal
Public 	CostMaterial	 AS Double	'			decimal
Public 	Remark	 AS String	'			nvarchar(50)
'=========================================================================================================================================================
End structure

Public D7255 As T7255_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7255(YEARMATERIAL AS String, MONTHMATERIAL AS String, CUSTOMERCODE AS String, MATERIALCODE AS String, MATERIALSEQ AS Double) As Boolean
    READ_PFK7255 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7255 "
    SQL = SQL & " WHERE K7255_YearMaterial		 = '" & YearMaterial & "' " 
    SQL = SQL & "   AND K7255_MonthMaterial		 = '" & MonthMaterial & "' " 
    SQL = SQL & "   AND K7255_CustomerCode		 = '" & CustomerCode & "' " 
    SQL = SQL & "   AND K7255_MaterialCode		 = '" & MaterialCode & "' " 
    SQL = SQL & "   AND K7255_MaterialSeq		 =  " & MaterialSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7255_CLEAR: GoTo SKIP_READ_PFK7255
                
    Call K7255_MOVE(rd)
    READ_PFK7255 = True

SKIP_READ_PFK7255:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7255",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7255(YEARMATERIAL AS String, MONTHMATERIAL AS String, CUSTOMERCODE AS String, MATERIALCODE AS String, MATERIALSEQ AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7255 "
    SQL = SQL & " WHERE K7255_YearMaterial		 = '" & YearMaterial & "' " 
    SQL = SQL & "   AND K7255_MonthMaterial		 = '" & MonthMaterial & "' " 
    SQL = SQL & "   AND K7255_CustomerCode		 = '" & CustomerCode & "' " 
    SQL = SQL & "   AND K7255_MaterialCode		 = '" & MaterialCode & "' " 
    SQL = SQL & "   AND K7255_MaterialSeq		 =  " & MaterialSeq & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7255",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7255(z7255 As T7255_AREA) As Boolean
    WRITE_PFK7255 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7255)
 
    SQL = " INSERT INTO PFK7255 "
    SQL = SQL & " ( "
    SQL = SQL & " K7255_YearMaterial," 
    SQL = SQL & " K7255_MonthMaterial," 
    SQL = SQL & " K7255_CustomerCode," 
    SQL = SQL & " K7255_MaterialCode," 
    SQL = SQL & " K7255_MaterialSeq," 
    SQL = SQL & " K7255_MaterialCodeBom," 
    SQL = SQL & " K7255_PriceMaterial," 
    SQL = SQL & " K7255_QtyPrescription," 
    SQL = SQL & " K7255_CostMaterial," 
    SQL = SQL & " K7255_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z7255.YearMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7255.MonthMaterial) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7255.CustomerCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z7255.MaterialCode) & "', "  
    SQL = SQL & "   " & FormatSQL(z7255.MaterialSeq) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7255.MaterialCodeBom) & "', "  
    SQL = SQL & "   " & FormatSQL(z7255.PriceMaterial) & ", "  
    SQL = SQL & "   " & FormatSQL(z7255.QtyPrescription) & ", "  
    SQL = SQL & "   " & FormatSQL(z7255.CostMaterial) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z7255.Remark) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7255 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7255",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7255(z7255 As T7255_AREA) As Boolean
    REWRITE_PFK7255 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7255)
   
    SQL = " UPDATE PFK7255 SET "
    SQL = SQL & "    K7255_MaterialCodeBom      = N'" & FormatSQL(z7255.MaterialCodeBom) & "', " 
    SQL = SQL & "    K7255_PriceMaterial      =  " & FormatSQL(z7255.PriceMaterial) & ", " 
    SQL = SQL & "    K7255_QtyPrescription      =  " & FormatSQL(z7255.QtyPrescription) & ", " 
    SQL = SQL & "    K7255_CostMaterial      =  " & FormatSQL(z7255.CostMaterial) & ", " 
    SQL = SQL & "    K7255_Remark      = N'" & FormatSQL(z7255.Remark) & "'  " 
    SQL = SQL & " WHERE K7255_YearMaterial		 = '" & z7255.YearMaterial & "' " 
    SQL = SQL & "   AND K7255_MonthMaterial		 = '" & z7255.MonthMaterial & "' " 
    SQL = SQL & "   AND K7255_CustomerCode		 = '" & z7255.CustomerCode & "' " 
    SQL = SQL & "   AND K7255_MaterialCode		 = '" & z7255.MaterialCode & "' " 
    SQL = SQL & "   AND K7255_MaterialSeq		 =  " & z7255.MaterialSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7255 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7255",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7255(z7255 As T7255_AREA) As Boolean
    DELETE_PFK7255 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7255 "
    SQL = SQL & " WHERE K7255_YearMaterial		 = '" & z7255.YearMaterial & "' " 
    SQL = SQL & "   AND K7255_MonthMaterial		 = '" & z7255.MonthMaterial & "' " 
    SQL = SQL & "   AND K7255_CustomerCode		 = '" & z7255.CustomerCode & "' " 
    SQL = SQL & "   AND K7255_MaterialCode		 = '" & z7255.MaterialCode & "' " 
    SQL = SQL & "   AND K7255_MaterialSeq		 =  " & z7255.MaterialSeq & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7255 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7255",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7255_CLEAR()
Try
    
   D7255.YearMaterial = ""
   D7255.MonthMaterial = ""
   D7255.CustomerCode = ""
   D7255.MaterialCode = ""
    D7255.MaterialSeq = 0 
   D7255.MaterialCodeBom = ""
    D7255.PriceMaterial = 0 
    D7255.QtyPrescription = 0 
    D7255.CostMaterial = 0 
   D7255.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7255_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7255 As T7255_AREA)
Try
    
    x7255.YearMaterial = trim$(  x7255.YearMaterial)
    x7255.MonthMaterial = trim$(  x7255.MonthMaterial)
    x7255.CustomerCode = trim$(  x7255.CustomerCode)
    x7255.MaterialCode = trim$(  x7255.MaterialCode)
    x7255.MaterialSeq = trim$(  x7255.MaterialSeq)
    x7255.MaterialCodeBom = trim$(  x7255.MaterialCodeBom)
    x7255.PriceMaterial = trim$(  x7255.PriceMaterial)
    x7255.QtyPrescription = trim$(  x7255.QtyPrescription)
    x7255.CostMaterial = trim$(  x7255.CostMaterial)
    x7255.Remark = trim$(  x7255.Remark)
     
    If trim$( x7255.YearMaterial ) = "" Then x7255.YearMaterial = Space(1) 
    If trim$( x7255.MonthMaterial ) = "" Then x7255.MonthMaterial = Space(1) 
    If trim$( x7255.CustomerCode ) = "" Then x7255.CustomerCode = Space(1) 
    If trim$( x7255.MaterialCode ) = "" Then x7255.MaterialCode = Space(1) 
    If trim$( x7255.MaterialSeq ) = "" Then x7255.MaterialSeq = 0 
    If trim$( x7255.MaterialCodeBom ) = "" Then x7255.MaterialCodeBom = Space(1) 
    If trim$( x7255.PriceMaterial ) = "" Then x7255.PriceMaterial = 0 
    If trim$( x7255.QtyPrescription ) = "" Then x7255.QtyPrescription = 0 
    If trim$( x7255.CostMaterial ) = "" Then x7255.CostMaterial = 0 
    If trim$( x7255.Remark ) = "" Then x7255.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7255_MOVE(rs7255 As SqlClient.SqlDataReader)
Try

    call D7255_CLEAR()   

    If IsdbNull(rs7255!K7255_YearMaterial) = False Then D7255.YearMaterial = Trim$(rs7255!K7255_YearMaterial)
    If IsdbNull(rs7255!K7255_MonthMaterial) = False Then D7255.MonthMaterial = Trim$(rs7255!K7255_MonthMaterial)
    If IsdbNull(rs7255!K7255_CustomerCode) = False Then D7255.CustomerCode = Trim$(rs7255!K7255_CustomerCode)
    If IsdbNull(rs7255!K7255_MaterialCode) = False Then D7255.MaterialCode = Trim$(rs7255!K7255_MaterialCode)
    If IsdbNull(rs7255!K7255_MaterialSeq) = False Then D7255.MaterialSeq = Trim$(rs7255!K7255_MaterialSeq)
    If IsdbNull(rs7255!K7255_MaterialCodeBom) = False Then D7255.MaterialCodeBom = Trim$(rs7255!K7255_MaterialCodeBom)
    If IsdbNull(rs7255!K7255_PriceMaterial) = False Then D7255.PriceMaterial = Trim$(rs7255!K7255_PriceMaterial)
    If IsdbNull(rs7255!K7255_QtyPrescription) = False Then D7255.QtyPrescription = Trim$(rs7255!K7255_QtyPrescription)
    If IsdbNull(rs7255!K7255_CostMaterial) = False Then D7255.CostMaterial = Trim$(rs7255!K7255_CostMaterial)
    If IsdbNull(rs7255!K7255_Remark) = False Then D7255.Remark = Trim$(rs7255!K7255_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7255_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7255_MOVE(rs7255 As DataRow)
Try

    call D7255_CLEAR()   

    If IsdbNull(rs7255!K7255_YearMaterial) = False Then D7255.YearMaterial = Trim$(rs7255!K7255_YearMaterial)
    If IsdbNull(rs7255!K7255_MonthMaterial) = False Then D7255.MonthMaterial = Trim$(rs7255!K7255_MonthMaterial)
    If IsdbNull(rs7255!K7255_CustomerCode) = False Then D7255.CustomerCode = Trim$(rs7255!K7255_CustomerCode)
    If IsdbNull(rs7255!K7255_MaterialCode) = False Then D7255.MaterialCode = Trim$(rs7255!K7255_MaterialCode)
    If IsdbNull(rs7255!K7255_MaterialSeq) = False Then D7255.MaterialSeq = Trim$(rs7255!K7255_MaterialSeq)
    If IsdbNull(rs7255!K7255_MaterialCodeBom) = False Then D7255.MaterialCodeBom = Trim$(rs7255!K7255_MaterialCodeBom)
    If IsdbNull(rs7255!K7255_PriceMaterial) = False Then D7255.PriceMaterial = Trim$(rs7255!K7255_PriceMaterial)
    If IsdbNull(rs7255!K7255_QtyPrescription) = False Then D7255.QtyPrescription = Trim$(rs7255!K7255_QtyPrescription)
    If IsdbNull(rs7255!K7255_CostMaterial) = False Then D7255.CostMaterial = Trim$(rs7255!K7255_CostMaterial)
    If IsdbNull(rs7255!K7255_Remark) = False Then D7255.Remark = Trim$(rs7255!K7255_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7255_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7255_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7255 As T7255_AREA, YEARMATERIAL AS String, MONTHMATERIAL AS String, CUSTOMERCODE AS String, MATERIALCODE AS String, MATERIALSEQ AS Double) as Boolean

K7255_MOVE = False

Try
    If READ_PFK7255(YEARMATERIAL, MONTHMATERIAL, CUSTOMERCODE, MATERIALCODE, MATERIALSEQ) = True Then
                z7255 = D7255
		K7255_MOVE = True
		else
	z7255 = nothing
     End If

     If  getColumIndex(spr,"YearMaterial") > -1 then z7255.YearMaterial = getDataM(spr, getColumIndex(spr,"YearMaterial"), xRow)
     If  getColumIndex(spr,"MonthMaterial") > -1 then z7255.MonthMaterial = getDataM(spr, getColumIndex(spr,"MonthMaterial"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7255.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z7255.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"MaterialSeq") > -1 then z7255.MaterialSeq = getDataM(spr, getColumIndex(spr,"MaterialSeq"), xRow)
     If  getColumIndex(spr,"MaterialCodeBom") > -1 then z7255.MaterialCodeBom = getDataM(spr, getColumIndex(spr,"MaterialCodeBom"), xRow)
     If  getColumIndex(spr,"PriceMaterial") > -1 then z7255.PriceMaterial = getDataM(spr, getColumIndex(spr,"PriceMaterial"), xRow)
     If  getColumIndex(spr,"QtyPrescription") > -1 then z7255.QtyPrescription = getDataM(spr, getColumIndex(spr,"QtyPrescription"), xRow)
     If  getColumIndex(spr,"CostMaterial") > -1 then z7255.CostMaterial = getDataM(spr, getColumIndex(spr,"CostMaterial"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7255.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7255_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K7255_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7255 As T7255_AREA,CheckClear as Boolean,YEARMATERIAL AS String, MONTHMATERIAL AS String, CUSTOMERCODE AS String, MATERIALCODE AS String, MATERIALSEQ AS Double) as Boolean

K7255_MOVE = False

Try
    If READ_PFK7255(YEARMATERIAL, MONTHMATERIAL, CUSTOMERCODE, MATERIALCODE, MATERIALSEQ) = True Then
                z7255 = D7255
		K7255_MOVE = True
		else
	If CheckClear  = True then z7255 = nothing
     End If

     If  getColumIndex(spr,"YearMaterial") > -1 then z7255.YearMaterial = getDataM(spr, getColumIndex(spr,"YearMaterial"), xRow)
     If  getColumIndex(spr,"MonthMaterial") > -1 then z7255.MonthMaterial = getDataM(spr, getColumIndex(spr,"MonthMaterial"), xRow)
     If  getColumIndex(spr,"CustomerCode") > -1 then z7255.CustomerCode = getDataM(spr, getColumIndex(spr,"CustomerCode"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z7255.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"MaterialSeq") > -1 then z7255.MaterialSeq = getDataM(spr, getColumIndex(spr,"MaterialSeq"), xRow)
     If  getColumIndex(spr,"MaterialCodeBom") > -1 then z7255.MaterialCodeBom = getDataM(spr, getColumIndex(spr,"MaterialCodeBom"), xRow)
     If  getColumIndex(spr,"PriceMaterial") > -1 then z7255.PriceMaterial = getDataM(spr, getColumIndex(spr,"PriceMaterial"), xRow)
     If  getColumIndex(spr,"QtyPrescription") > -1 then z7255.QtyPrescription = getDataM(spr, getColumIndex(spr,"QtyPrescription"), xRow)
     If  getColumIndex(spr,"CostMaterial") > -1 then z7255.CostMaterial = getDataM(spr, getColumIndex(spr,"CostMaterial"), xRow)
     If  getColumIndex(spr,"Remark") > -1 then z7255.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7255_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7255_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7255 As T7255_AREA, Job as String, YEARMATERIAL AS String, MONTHMATERIAL AS String, CUSTOMERCODE AS String, MATERIALCODE AS String, MATERIALSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7255_MOVE = False

Try
    If READ_PFK7255(YEARMATERIAL, MONTHMATERIAL, CUSTOMERCODE, MATERIALCODE, MATERIALSEQ) = True Then
                z7255 = D7255
		K7255_MOVE = True
		else
	z7255 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7255")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "YEARMATERIAL":z7255.YearMaterial = Children(i).Code
   Case "MONTHMATERIAL":z7255.MonthMaterial = Children(i).Code
   Case "CUSTOMERCODE":z7255.CustomerCode = Children(i).Code
   Case "MATERIALCODE":z7255.MaterialCode = Children(i).Code
   Case "MATERIALSEQ":z7255.MaterialSeq = Children(i).Code
   Case "MATERIALCODEBOM":z7255.MaterialCodeBom = Children(i).Code
   Case "PRICEMATERIAL":z7255.PriceMaterial = Children(i).Code
   Case "QTYPRESCRIPTION":z7255.QtyPrescription = Children(i).Code
   Case "COSTMATERIAL":z7255.CostMaterial = Children(i).Code
   Case "REMARK":z7255.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "YEARMATERIAL":z7255.YearMaterial = Children(i).Data
   Case "MONTHMATERIAL":z7255.MonthMaterial = Children(i).Data
   Case "CUSTOMERCODE":z7255.CustomerCode = Children(i).Data
   Case "MATERIALCODE":z7255.MaterialCode = Children(i).Data
   Case "MATERIALSEQ":z7255.MaterialSeq = Children(i).Data
   Case "MATERIALCODEBOM":z7255.MaterialCodeBom = Children(i).Data
   Case "PRICEMATERIAL":z7255.PriceMaterial = Children(i).Data
   Case "QTYPRESCRIPTION":z7255.QtyPrescription = Children(i).Data
   Case "COSTMATERIAL":z7255.CostMaterial = Children(i).Data
   Case "REMARK":z7255.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7255_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K7255_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7255 As T7255_AREA, Job as String, CheckClear as Boolean, YEARMATERIAL AS String, MONTHMATERIAL AS String, CUSTOMERCODE AS String, MATERIALCODE AS String, MATERIALSEQ AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7255_MOVE = False

Try
    If READ_PFK7255(YEARMATERIAL, MONTHMATERIAL, CUSTOMERCODE, MATERIALCODE, MATERIALSEQ) = True Then
                z7255 = D7255
		K7255_MOVE = True
		else
	If CheckClear  = True then z7255 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7255")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "YEARMATERIAL":z7255.YearMaterial = Children(i).Code
   Case "MONTHMATERIAL":z7255.MonthMaterial = Children(i).Code
   Case "CUSTOMERCODE":z7255.CustomerCode = Children(i).Code
   Case "MATERIALCODE":z7255.MaterialCode = Children(i).Code
   Case "MATERIALSEQ":z7255.MaterialSeq = Children(i).Code
   Case "MATERIALCODEBOM":z7255.MaterialCodeBom = Children(i).Code
   Case "PRICEMATERIAL":z7255.PriceMaterial = Children(i).Code
   Case "QTYPRESCRIPTION":z7255.QtyPrescription = Children(i).Code
   Case "COSTMATERIAL":z7255.CostMaterial = Children(i).Code
   Case "REMARK":z7255.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "YEARMATERIAL":z7255.YearMaterial = Children(i).Data
   Case "MONTHMATERIAL":z7255.MonthMaterial = Children(i).Data
   Case "CUSTOMERCODE":z7255.CustomerCode = Children(i).Data
   Case "MATERIALCODE":z7255.MaterialCode = Children(i).Data
   Case "MATERIALSEQ":z7255.MaterialSeq = Children(i).Data
   Case "MATERIALCODEBOM":z7255.MaterialCodeBom = Children(i).Data
   Case "PRICEMATERIAL":z7255.PriceMaterial = Children(i).Data
   Case "QTYPRESCRIPTION":z7255.QtyPrescription = Children(i).Data
   Case "COSTMATERIAL":z7255.CostMaterial = Children(i).Data
   Case "REMARK":z7255.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7255_MOVE",vbCritical)
End Try
End Function 
    
End Module 
