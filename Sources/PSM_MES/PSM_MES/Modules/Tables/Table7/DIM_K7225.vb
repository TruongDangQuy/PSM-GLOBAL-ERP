'=========================================================================================================================================================
'   TABLE : (PFK7225)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7225

Structure T7225_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	YarnYY	 AS String	'			char(4)		*
Public 	YarnMM	 AS String	'			char(2)		*
Public 	ItemCode	 AS String	'			char(5)		*
Public 	PriceGreyGross	 AS Double	'			decimal
Public 	PriceGreyNet	 AS Double	'			decimal
Public 	PriceWeavingWarp	 AS Double	'			decimal
Public 	PriceWeavingWeft	 AS Double	'			decimal
Public 	PriceWeavingSizing	 AS Double	'			decimal
Public 	PriceWeavingProduct	 AS Double	'			decimal
Public 	QtyYarnOptimum	 AS Double	'			decimal
Public 	Remark	 AS String	'			nvarchar(200)
'=========================================================================================================================================================
End structure

Public D7225 As T7225_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK7225(YARNYY AS String, YARNMM AS String, ITEMCODE AS String) As Boolean
    READ_PFK7225 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7225 "
    SQL = SQL & " WHERE K7225_YarnYY		 = '" & YarnYY & "' " 
    SQL = SQL & "   AND K7225_YarnMM		 = '" & YarnMM & "' " 
    SQL = SQL & "   AND K7225_ItemCode		 = '" & ItemCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D7225_CLEAR: GoTo SKIP_READ_PFK7225
                
    Call K7225_MOVE(rd)
    READ_PFK7225 = True

SKIP_READ_PFK7225:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK7225",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK7225(YARNYY AS String, YARNMM AS String, ITEMCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK7225 "
    SQL = SQL & " WHERE K7225_YarnYY		 = '" & YarnYY & "' " 
    SQL = SQL & "   AND K7225_YarnMM		 = '" & YarnMM & "' " 
    SQL = SQL & "   AND K7225_ItemCode		 = '" & ItemCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK7225",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK7225(z7225 As T7225_AREA) As Boolean
    WRITE_PFK7225 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z7225)
 
    SQL = " INSERT INTO PFK7225 "
    SQL = SQL & " ( "
    SQL = SQL & " K7225_YarnYY," 
    SQL = SQL & " K7225_YarnMM," 
    SQL = SQL & " K7225_ItemCode," 
    SQL = SQL & " K7225_PriceGreyGross," 
    SQL = SQL & " K7225_PriceGreyNet," 
    SQL = SQL & " K7225_PriceWeavingWarp," 
    SQL = SQL & " K7225_PriceWeavingWeft," 
    SQL = SQL & " K7225_PriceWeavingSizing," 
    SQL = SQL & " K7225_PriceWeavingProduct," 
    SQL = SQL & " K7225_QtyYarnOptimum," 
    SQL = SQL & " K7225_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  '" & z7225.YarnYY & "', "  
    SQL = SQL & "  '" & z7225.YarnMM & "', "  
    SQL = SQL & "  '" & z7225.ItemCode & "', "  
    SQL = SQL & "   " & z7225.PriceGreyGross & " , "  
    SQL = SQL & "   " & z7225.PriceGreyNet & " , "  
    SQL = SQL & "   " & z7225.PriceWeavingWarp & " , "  
    SQL = SQL & "   " & z7225.PriceWeavingWeft & " , "  
    SQL = SQL & "   " & z7225.PriceWeavingSizing & " , "  
    SQL = SQL & "   " & z7225.PriceWeavingProduct & " , "  
    SQL = SQL & "   " & z7225.QtyYarnOptimum & " , "  
    SQL = SQL & "  '" & z7225.Remark & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK7225 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK7225",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK7225(z7225 As T7225_AREA) As Boolean
    REWRITE_PFK7225 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z7225)
   
    SQL = " UPDATE PFK7225 SET "
    SQL = SQL & "    K7225_PriceGreyGross      =  " & z7225.PriceGreyGross & " , " 
    SQL = SQL & "    K7225_PriceGreyNet      =  " & z7225.PriceGreyNet & " , " 
    SQL = SQL & "    K7225_PriceWeavingWarp      =  " & z7225.PriceWeavingWarp & " , " 
    SQL = SQL & "    K7225_PriceWeavingWeft      =  " & z7225.PriceWeavingWeft & " , " 
    SQL = SQL & "    K7225_PriceWeavingSizing      =  " & z7225.PriceWeavingSizing & " , " 
    SQL = SQL & "    K7225_PriceWeavingProduct      =  " & z7225.PriceWeavingProduct & " , " 
    SQL = SQL & "    K7225_QtyYarnOptimum      =  " & z7225.QtyYarnOptimum & " , " 
    SQL = SQL & "    K7225_Remark      = '" & z7225.Remark & "'  " 
    SQL = SQL & " WHERE K7225_YarnYY		 = '" & z7225.YarnYY & "' " 
    SQL = SQL & "   AND K7225_YarnMM		 = '" & z7225.YarnMM & "' " 
    SQL = SQL & "   AND K7225_ItemCode		 = '" & z7225.ItemCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK7225 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK7225",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK7225(z7225 As T7225_AREA) As Boolean
    DELETE_PFK7225 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK7225 "
    SQL = SQL & " WHERE K7225_YarnYY		 = '" & z7225.YarnYY & "' " 
    SQL = SQL & "   AND K7225_YarnMM		 = '" & z7225.YarnMM & "' " 
    SQL = SQL & "   AND K7225_ItemCode		 = '" & z7225.ItemCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK7225 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK7225",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D7225_CLEAR()
Try
    
   D7225.YarnYY = ""
   D7225.YarnMM = ""
   D7225.ItemCode = ""
    D7225.PriceGreyGross = 0 
    D7225.PriceGreyNet = 0 
    D7225.PriceWeavingWarp = 0 
    D7225.PriceWeavingWeft = 0 
    D7225.PriceWeavingSizing = 0 
    D7225.PriceWeavingProduct = 0 
    D7225.QtyYarnOptimum = 0 
   D7225.Remark = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D7225_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x7225 As T7225_AREA)
Try
    
    x7225.YarnYY = trim$(  x7225.YarnYY)
    x7225.YarnMM = trim$(  x7225.YarnMM)
    x7225.ItemCode = trim$(  x7225.ItemCode)
    x7225.PriceGreyGross = trim$(  x7225.PriceGreyGross)
    x7225.PriceGreyNet = trim$(  x7225.PriceGreyNet)
    x7225.PriceWeavingWarp = trim$(  x7225.PriceWeavingWarp)
    x7225.PriceWeavingWeft = trim$(  x7225.PriceWeavingWeft)
    x7225.PriceWeavingSizing = trim$(  x7225.PriceWeavingSizing)
    x7225.PriceWeavingProduct = trim$(  x7225.PriceWeavingProduct)
    x7225.QtyYarnOptimum = trim$(  x7225.QtyYarnOptimum)
    x7225.Remark = trim$(  x7225.Remark)
     
    If trim$( x7225.YarnYY ) = "" Then x7225.YarnYY = Space(1) 
    If trim$( x7225.YarnMM ) = "" Then x7225.YarnMM = Space(1) 
    If trim$( x7225.ItemCode ) = "" Then x7225.ItemCode = Space(1) 
    If trim$( x7225.PriceGreyGross ) = "" Then x7225.PriceGreyGross = 0 
    If trim$( x7225.PriceGreyNet ) = "" Then x7225.PriceGreyNet = 0 
    If trim$( x7225.PriceWeavingWarp ) = "" Then x7225.PriceWeavingWarp = 0 
    If trim$( x7225.PriceWeavingWeft ) = "" Then x7225.PriceWeavingWeft = 0 
    If trim$( x7225.PriceWeavingSizing ) = "" Then x7225.PriceWeavingSizing = 0 
    If trim$( x7225.PriceWeavingProduct ) = "" Then x7225.PriceWeavingProduct = 0 
    If trim$( x7225.QtyYarnOptimum ) = "" Then x7225.QtyYarnOptimum = 0 
    If trim$( x7225.Remark ) = "" Then x7225.Remark = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K7225_MOVE(rs7225 As SqlClient.SqlDataReader)
Try

    call D7225_CLEAR()   

    If IsdbNull(rs7225!K7225_YarnYY) = False Then D7225.YarnYY = Trim$(rs7225!K7225_YarnYY)
    If IsdbNull(rs7225!K7225_YarnMM) = False Then D7225.YarnMM = Trim$(rs7225!K7225_YarnMM)
    If IsdbNull(rs7225!K7225_ItemCode) = False Then D7225.ItemCode = Trim$(rs7225!K7225_ItemCode)
    If IsdbNull(rs7225!K7225_PriceGreyGross) = False Then D7225.PriceGreyGross = Trim$(rs7225!K7225_PriceGreyGross)
    If IsdbNull(rs7225!K7225_PriceGreyNet) = False Then D7225.PriceGreyNet = Trim$(rs7225!K7225_PriceGreyNet)
    If IsdbNull(rs7225!K7225_PriceWeavingWarp) = False Then D7225.PriceWeavingWarp = Trim$(rs7225!K7225_PriceWeavingWarp)
    If IsdbNull(rs7225!K7225_PriceWeavingWeft) = False Then D7225.PriceWeavingWeft = Trim$(rs7225!K7225_PriceWeavingWeft)
    If IsdbNull(rs7225!K7225_PriceWeavingSizing) = False Then D7225.PriceWeavingSizing = Trim$(rs7225!K7225_PriceWeavingSizing)
    If IsdbNull(rs7225!K7225_PriceWeavingProduct) = False Then D7225.PriceWeavingProduct = Trim$(rs7225!K7225_PriceWeavingProduct)
    If IsdbNull(rs7225!K7225_QtyYarnOptimum) = False Then D7225.QtyYarnOptimum = Trim$(rs7225!K7225_QtyYarnOptimum)
    If IsdbNull(rs7225!K7225_Remark) = False Then D7225.Remark = Trim$(rs7225!K7225_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7225_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K7225_MOVE(rs7225 As DataRow)
Try

    call D7225_CLEAR()   

    If IsdbNull(rs7225!K7225_YarnYY) = False Then D7225.YarnYY = Trim$(rs7225!K7225_YarnYY)
    If IsdbNull(rs7225!K7225_YarnMM) = False Then D7225.YarnMM = Trim$(rs7225!K7225_YarnMM)
    If IsdbNull(rs7225!K7225_ItemCode) = False Then D7225.ItemCode = Trim$(rs7225!K7225_ItemCode)
    If IsdbNull(rs7225!K7225_PriceGreyGross) = False Then D7225.PriceGreyGross = Trim$(rs7225!K7225_PriceGreyGross)
    If IsdbNull(rs7225!K7225_PriceGreyNet) = False Then D7225.PriceGreyNet = Trim$(rs7225!K7225_PriceGreyNet)
    If IsdbNull(rs7225!K7225_PriceWeavingWarp) = False Then D7225.PriceWeavingWarp = Trim$(rs7225!K7225_PriceWeavingWarp)
    If IsdbNull(rs7225!K7225_PriceWeavingWeft) = False Then D7225.PriceWeavingWeft = Trim$(rs7225!K7225_PriceWeavingWeft)
    If IsdbNull(rs7225!K7225_PriceWeavingSizing) = False Then D7225.PriceWeavingSizing = Trim$(rs7225!K7225_PriceWeavingSizing)
    If IsdbNull(rs7225!K7225_PriceWeavingProduct) = False Then D7225.PriceWeavingProduct = Trim$(rs7225!K7225_PriceWeavingProduct)
    If IsdbNull(rs7225!K7225_QtyYarnOptimum) = False Then D7225.QtyYarnOptimum = Trim$(rs7225!K7225_QtyYarnOptimum)
    If IsdbNull(rs7225!K7225_Remark) = False Then D7225.Remark = Trim$(rs7225!K7225_Remark)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K7225_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K7225_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z7225 As T7225_AREA,YARNYY AS String, YARNMM AS String, ITEMCODE AS String) as Boolean

K7225_MOVE = False

Try
    If READ_PFK7225(YARNYY, YARNMM, ITEMCODE) = True Then
                z7225 = D7225
		K7225_MOVE = True
            End If

   z7225.YarnYY = getDataM(spr, getColumIndex(spr,"YarnYY"), xRow)
   z7225.YarnMM = getDataM(spr, getColumIndex(spr,"YarnMM"), xRow)
   z7225.ItemCode = getDataM(spr, getColumIndex(spr,"ItemCode"), xRow)
   z7225.PriceGreyGross = getDataM(spr, getColumIndex(spr,"PriceGreyGross"), xRow)
   z7225.PriceGreyNet = getDataM(spr, getColumIndex(spr,"PriceGreyNet"), xRow)
   z7225.PriceWeavingWarp = getDataM(spr, getColumIndex(spr,"PriceWeavingWarp"), xRow)
   z7225.PriceWeavingWeft = getDataM(spr, getColumIndex(spr,"PriceWeavingWeft"), xRow)
   z7225.PriceWeavingSizing = getDataM(spr, getColumIndex(spr,"PriceWeavingSizing"), xRow)
   z7225.PriceWeavingProduct = getDataM(spr, getColumIndex(spr,"PriceWeavingProduct"), xRow)
   z7225.QtyYarnOptimum = getDataM(spr, getColumIndex(spr,"QtyYarnOptimum"), xRow)
   z7225.Remark = getDataM(spr, getColumIndex(spr,"Remark"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K7225_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K7225_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z7225 As T7225_AREA, Job as String,YARNYY AS String, YARNMM AS String, ITEMCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K7225_MOVE = False

Try
    If READ_PFK7225(YARNYY, YARNMM, ITEMCODE) = True Then
                z7225 = D7225
		K7225_MOVE = True

    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7225")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "YarnYY":z7225.YarnYY = Children(i).Code
   Case "YarnMM":z7225.YarnMM = Children(i).Code
   Case "ItemCode":z7225.ItemCode = Children(i).Code
   Case "PriceGreyGross":z7225.PriceGreyGross = Children(i).Code
   Case "PriceGreyNet":z7225.PriceGreyNet = Children(i).Code
   Case "PriceWeavingWarp":z7225.PriceWeavingWarp = Children(i).Code
   Case "PriceWeavingWeft":z7225.PriceWeavingWeft = Children(i).Code
   Case "PriceWeavingSizing":z7225.PriceWeavingSizing = Children(i).Code
   Case "PriceWeavingProduct":z7225.PriceWeavingProduct = Children(i).Code
   Case "QtyYarnOptimum":z7225.QtyYarnOptimum = Children(i).Code
   Case "Remark":z7225.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "YarnYY":z7225.YarnYY = Children(i).Data
   Case "YarnMM":z7225.YarnMM = Children(i).Data
   Case "ItemCode":z7225.ItemCode = Children(i).Data
   Case "PriceGreyGross":z7225.PriceGreyGross = Children(i).Data
   Case "PriceGreyNet":z7225.PriceGreyNet = Children(i).Data
   Case "PriceWeavingWarp":z7225.PriceWeavingWarp = Children(i).Data
   Case "PriceWeavingWeft":z7225.PriceWeavingWeft = Children(i).Data
   Case "PriceWeavingSizing":z7225.PriceWeavingSizing = Children(i).Data
   Case "PriceWeavingProduct":z7225.PriceWeavingProduct = Children(i).Data
   Case "QtyYarnOptimum":z7225.QtyYarnOptimum = Children(i).Data
   Case "Remark":z7225.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7225_MOVE",vbCritical)
End Try
End Function 
    
End Module 
