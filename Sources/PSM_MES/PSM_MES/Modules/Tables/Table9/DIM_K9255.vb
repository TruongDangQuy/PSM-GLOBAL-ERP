'=========================================================================================================================================================
'   TABLE : (PFK9255)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9255

Structure T9255_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	DateIVTMaterial	 AS String	'			char(6)		*
Public 	cdFactoryMaterial	 AS String	'			char(3)		*
Public 	CheckIVTProcessMaterial	 AS String	'			char(1)		*
Public 	MaterialCode	 AS String	'			char(6)		*
Public 	PriceIVTMaterialUSD	 AS Double	'			decimal
Public 	PriceIVTMaterialVND	 AS Double	'			decimal
Public 	LTBoxTotalIVTMaterial	 AS Double	'			decimal
Public 	LTQtyTotalIVTMaterial	 AS Double	'			decimal
Public 	LTBoxTotalIVTMaterial_Normal	 AS Double	'			decimal
Public 	LTQtyTotalIVTMaterial_Normal	 AS Double	'			decimal
Public 	LTBoxTotalIVTMaterial_Sample	 AS Double	'			decimal
Public 	LTQtyTotalIVTMaterial_Sample	 AS Double	'			decimal
Public 	LTBoxTotalIVTMaterial_Return	 AS Double	'			decimal
Public 	LTQtyTotalIVTMaterial_Return	 AS Double	'			decimal
Public 	LTBoxTotalIVTMaterial_Again	 AS Double	'			decimal
Public 	LTQtyTotalIVTMaterial_Again	 AS Double	'			decimal
Public 	BLBoxTotalIVTMaterial	 AS Double	'			decimal
Public 	BLQtyTotalIVTMaterial	 AS Double	'			decimal
Public 	BLBoxTotalIVTMaterial_Normal	 AS Double	'			decimal
Public 	BLQtyTotalIVTMaterial_Normal	 AS Double	'			decimal
Public 	BLBoxTotalIVTMaterial_Sample	 AS Double	'			decimal
Public 	BLQtyTotalIVTMaterial_Sample	 AS Double	'			decimal
Public 	BLBoxTotalIVTMaterial_Return	 AS Double	'			decimal
Public 	BLQtyTotalIVTMaterial_Return	 AS Double	'			decimal
Public 	BLBoxTotalIVTMaterial_Again	 AS Double	'			decimal
Public 	BLQtyTotalIVTMaterial_Again	 AS Double	'			decimal
Public 	AmountIVTMaterialUSD	 AS Double	'			decimal
Public 	AmountIVTMaterialVND	 AS Double	'			decimal
'=========================================================================================================================================================
End structure

Public D9255 As T9255_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK9255(DATEIVTMATERIAL AS String, CDFACTORYMATERIAL AS String, CHECKIVTPROCESSMATERIAL AS String, MATERIALCODE AS String) As Boolean
    READ_PFK9255 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9255 "
    SQL = SQL & " WHERE K9255_DateIVTMaterial		 = '" & DateIVTMaterial & "' " 
    SQL = SQL & "   AND K9255_cdFactoryMaterial		 = '" & cdFactoryMaterial & "' " 
    SQL = SQL & "   AND K9255_CheckIVTProcessMaterial		 = '" & CheckIVTProcessMaterial & "' " 
    SQL = SQL & "   AND K9255_MaterialCode		 = '" & MaterialCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D9255_CLEAR: GoTo SKIP_READ_PFK9255
                
    Call K9255_MOVE(rd)
    READ_PFK9255 = True

SKIP_READ_PFK9255:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK9255",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK9255(DATEIVTMATERIAL AS String, CDFACTORYMATERIAL AS String, CHECKIVTPROCESSMATERIAL AS String, MATERIALCODE AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK9255 "
    SQL = SQL & " WHERE K9255_DateIVTMaterial		 = '" & DateIVTMaterial & "' " 
    SQL = SQL & "   AND K9255_cdFactoryMaterial		 = '" & cdFactoryMaterial & "' " 
    SQL = SQL & "   AND K9255_CheckIVTProcessMaterial		 = '" & CheckIVTProcessMaterial & "' " 
    SQL = SQL & "   AND K9255_MaterialCode		 = '" & MaterialCode & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK9255",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK9255(z9255 As T9255_AREA) As Boolean
    WRITE_PFK9255 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z9255)
 
    SQL = " INSERT INTO PFK9255 "
    SQL = SQL & " ( "
    SQL = SQL & " K9255_DateIVTMaterial," 
    SQL = SQL & " K9255_cdFactoryMaterial," 
    SQL = SQL & " K9255_CheckIVTProcessMaterial," 
    SQL = SQL & " K9255_MaterialCode," 
    SQL = SQL & " K9255_PriceIVTMaterialUSD," 
    SQL = SQL & " K9255_PriceIVTMaterialVND," 
    SQL = SQL & " K9255_LTBoxTotalIVTMaterial," 
    SQL = SQL & " K9255_LTQtyTotalIVTMaterial," 
    SQL = SQL & " K9255_LTBoxTotalIVTMaterial_Normal," 
    SQL = SQL & " K9255_LTQtyTotalIVTMaterial_Normal," 
    SQL = SQL & " K9255_LTBoxTotalIVTMaterial_Sample," 
    SQL = SQL & " K9255_LTQtyTotalIVTMaterial_Sample," 
    SQL = SQL & " K9255_LTBoxTotalIVTMaterial_Return," 
    SQL = SQL & " K9255_LTQtyTotalIVTMaterial_Return," 
    SQL = SQL & " K9255_LTBoxTotalIVTMaterial_Again," 
    SQL = SQL & " K9255_LTQtyTotalIVTMaterial_Again," 
    SQL = SQL & " K9255_BLBoxTotalIVTMaterial," 
    SQL = SQL & " K9255_BLQtyTotalIVTMaterial," 
    SQL = SQL & " K9255_BLBoxTotalIVTMaterial_Normal," 
    SQL = SQL & " K9255_BLQtyTotalIVTMaterial_Normal," 
    SQL = SQL & " K9255_BLBoxTotalIVTMaterial_Sample," 
    SQL = SQL & " K9255_BLQtyTotalIVTMaterial_Sample," 
    SQL = SQL & " K9255_BLBoxTotalIVTMaterial_Return," 
    SQL = SQL & " K9255_BLQtyTotalIVTMaterial_Return," 
    SQL = SQL & " K9255_BLBoxTotalIVTMaterial_Again," 
    SQL = SQL & " K9255_BLQtyTotalIVTMaterial_Again," 
    SQL = SQL & " K9255_AmountIVTMaterialUSD," 
    SQL = SQL & " K9255_AmountIVTMaterialVND " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  '" & z9255.DateIVTMaterial & "', "  
    SQL = SQL & "  '" & z9255.cdFactoryMaterial & "', "  
    SQL = SQL & "  '" & z9255.CheckIVTProcessMaterial & "', "  
    SQL = SQL & "  '" & z9255.MaterialCode & "', "  
    SQL = SQL & "   " & z9255.PriceIVTMaterialUSD & " , "  
    SQL = SQL & "   " & z9255.PriceIVTMaterialVND & " , "  
    SQL = SQL & "   " & z9255.LTBoxTotalIVTMaterial & " , "  
    SQL = SQL & "   " & z9255.LTQtyTotalIVTMaterial & " , "  
    SQL = SQL & "   " & z9255.LTBoxTotalIVTMaterial_Normal & " , "  
    SQL = SQL & "   " & z9255.LTQtyTotalIVTMaterial_Normal & " , "  
    SQL = SQL & "   " & z9255.LTBoxTotalIVTMaterial_Sample & " , "  
    SQL = SQL & "   " & z9255.LTQtyTotalIVTMaterial_Sample & " , "  
    SQL = SQL & "   " & z9255.LTBoxTotalIVTMaterial_Return & " , "  
    SQL = SQL & "   " & z9255.LTQtyTotalIVTMaterial_Return & " , "  
    SQL = SQL & "   " & z9255.LTBoxTotalIVTMaterial_Again & " , "  
    SQL = SQL & "   " & z9255.LTQtyTotalIVTMaterial_Again & " , "  
    SQL = SQL & "   " & z9255.BLBoxTotalIVTMaterial & " , "  
    SQL = SQL & "   " & z9255.BLQtyTotalIVTMaterial & " , "  
    SQL = SQL & "   " & z9255.BLBoxTotalIVTMaterial_Normal & " , "  
    SQL = SQL & "   " & z9255.BLQtyTotalIVTMaterial_Normal & " , "  
    SQL = SQL & "   " & z9255.BLBoxTotalIVTMaterial_Sample & " , "  
    SQL = SQL & "   " & z9255.BLQtyTotalIVTMaterial_Sample & " , "  
    SQL = SQL & "   " & z9255.BLBoxTotalIVTMaterial_Return & " , "  
    SQL = SQL & "   " & z9255.BLQtyTotalIVTMaterial_Return & " , "  
    SQL = SQL & "   " & z9255.BLBoxTotalIVTMaterial_Again & " , "  
    SQL = SQL & "   " & z9255.BLQtyTotalIVTMaterial_Again & " , "  
    SQL = SQL & "   " & z9255.AmountIVTMaterialUSD & " , "  
    SQL = SQL & "   " & z9255.AmountIVTMaterialVND & "   "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK9255 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK9255",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK9255(z9255 As T9255_AREA) As Boolean
    REWRITE_PFK9255 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z9255)
   
    SQL = " UPDATE PFK9255 SET "
    SQL = SQL & "    K9255_PriceIVTMaterialUSD      =  " & z9255.PriceIVTMaterialUSD & " , " 
    SQL = SQL & "    K9255_PriceIVTMaterialVND      =  " & z9255.PriceIVTMaterialVND & " , " 
    SQL = SQL & "    K9255_LTBoxTotalIVTMaterial      =  " & z9255.LTBoxTotalIVTMaterial & " , " 
    SQL = SQL & "    K9255_LTQtyTotalIVTMaterial      =  " & z9255.LTQtyTotalIVTMaterial & " , " 
    SQL = SQL & "    K9255_LTBoxTotalIVTMaterial_Normal      =  " & z9255.LTBoxTotalIVTMaterial_Normal & " , " 
    SQL = SQL & "    K9255_LTQtyTotalIVTMaterial_Normal      =  " & z9255.LTQtyTotalIVTMaterial_Normal & " , " 
    SQL = SQL & "    K9255_LTBoxTotalIVTMaterial_Sample      =  " & z9255.LTBoxTotalIVTMaterial_Sample & " , " 
    SQL = SQL & "    K9255_LTQtyTotalIVTMaterial_Sample      =  " & z9255.LTQtyTotalIVTMaterial_Sample & " , " 
    SQL = SQL & "    K9255_LTBoxTotalIVTMaterial_Return      =  " & z9255.LTBoxTotalIVTMaterial_Return & " , " 
    SQL = SQL & "    K9255_LTQtyTotalIVTMaterial_Return      =  " & z9255.LTQtyTotalIVTMaterial_Return & " , " 
    SQL = SQL & "    K9255_LTBoxTotalIVTMaterial_Again      =  " & z9255.LTBoxTotalIVTMaterial_Again & " , " 
    SQL = SQL & "    K9255_LTQtyTotalIVTMaterial_Again      =  " & z9255.LTQtyTotalIVTMaterial_Again & " , " 
    SQL = SQL & "    K9255_BLBoxTotalIVTMaterial      =  " & z9255.BLBoxTotalIVTMaterial & " , " 
    SQL = SQL & "    K9255_BLQtyTotalIVTMaterial      =  " & z9255.BLQtyTotalIVTMaterial & " , " 
    SQL = SQL & "    K9255_BLBoxTotalIVTMaterial_Normal      =  " & z9255.BLBoxTotalIVTMaterial_Normal & " , " 
    SQL = SQL & "    K9255_BLQtyTotalIVTMaterial_Normal      =  " & z9255.BLQtyTotalIVTMaterial_Normal & " , " 
    SQL = SQL & "    K9255_BLBoxTotalIVTMaterial_Sample      =  " & z9255.BLBoxTotalIVTMaterial_Sample & " , " 
    SQL = SQL & "    K9255_BLQtyTotalIVTMaterial_Sample      =  " & z9255.BLQtyTotalIVTMaterial_Sample & " , " 
    SQL = SQL & "    K9255_BLBoxTotalIVTMaterial_Return      =  " & z9255.BLBoxTotalIVTMaterial_Return & " , " 
    SQL = SQL & "    K9255_BLQtyTotalIVTMaterial_Return      =  " & z9255.BLQtyTotalIVTMaterial_Return & " , " 
    SQL = SQL & "    K9255_BLBoxTotalIVTMaterial_Again      =  " & z9255.BLBoxTotalIVTMaterial_Again & " , " 
    SQL = SQL & "    K9255_BLQtyTotalIVTMaterial_Again      =  " & z9255.BLQtyTotalIVTMaterial_Again & " , " 
    SQL = SQL & "    K9255_AmountIVTMaterialUSD      =  " & z9255.AmountIVTMaterialUSD & " , " 
    SQL = SQL & "    K9255_AmountIVTMaterialVND      =  " & z9255.AmountIVTMaterialVND & "   " 
    SQL = SQL & " WHERE K9255_DateIVTMaterial		 = '" & z9255.DateIVTMaterial & "' " 
    SQL = SQL & "   AND K9255_cdFactoryMaterial		 = '" & z9255.cdFactoryMaterial & "' " 
    SQL = SQL & "   AND K9255_CheckIVTProcessMaterial		 = '" & z9255.CheckIVTProcessMaterial & "' " 
    SQL = SQL & "   AND K9255_MaterialCode		 = '" & z9255.MaterialCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK9255 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK9255",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK9255(z9255 As T9255_AREA) As Boolean
    DELETE_PFK9255 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK9255 "
    SQL = SQL & " WHERE K9255_DateIVTMaterial		 = '" & z9255.DateIVTMaterial & "' " 
    SQL = SQL & "   AND K9255_cdFactoryMaterial		 = '" & z9255.cdFactoryMaterial & "' " 
    SQL = SQL & "   AND K9255_CheckIVTProcessMaterial		 = '" & z9255.CheckIVTProcessMaterial & "' " 
    SQL = SQL & "   AND K9255_MaterialCode		 = '" & z9255.MaterialCode & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK9255 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK9255",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D9255_CLEAR()
Try
    
   D9255.DateIVTMaterial = ""
   D9255.cdFactoryMaterial = ""
   D9255.CheckIVTProcessMaterial = ""
   D9255.MaterialCode = ""
    D9255.PriceIVTMaterialUSD = 0 
    D9255.PriceIVTMaterialVND = 0 
    D9255.LTBoxTotalIVTMaterial = 0 
    D9255.LTQtyTotalIVTMaterial = 0 
    D9255.LTBoxTotalIVTMaterial_Normal = 0 
    D9255.LTQtyTotalIVTMaterial_Normal = 0 
    D9255.LTBoxTotalIVTMaterial_Sample = 0 
    D9255.LTQtyTotalIVTMaterial_Sample = 0 
    D9255.LTBoxTotalIVTMaterial_Return = 0 
    D9255.LTQtyTotalIVTMaterial_Return = 0 
    D9255.LTBoxTotalIVTMaterial_Again = 0 
    D9255.LTQtyTotalIVTMaterial_Again = 0 
    D9255.BLBoxTotalIVTMaterial = 0 
    D9255.BLQtyTotalIVTMaterial = 0 
    D9255.BLBoxTotalIVTMaterial_Normal = 0 
    D9255.BLQtyTotalIVTMaterial_Normal = 0 
    D9255.BLBoxTotalIVTMaterial_Sample = 0 
    D9255.BLQtyTotalIVTMaterial_Sample = 0 
    D9255.BLBoxTotalIVTMaterial_Return = 0 
    D9255.BLQtyTotalIVTMaterial_Return = 0 
    D9255.BLBoxTotalIVTMaterial_Again = 0 
    D9255.BLQtyTotalIVTMaterial_Again = 0 
    D9255.AmountIVTMaterialUSD = 0 
    D9255.AmountIVTMaterialVND = 0 

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D9255_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x9255 As T9255_AREA)
Try
    
    x9255.DateIVTMaterial = trim$(  x9255.DateIVTMaterial)
    x9255.cdFactoryMaterial = trim$(  x9255.cdFactoryMaterial)
    x9255.CheckIVTProcessMaterial = trim$(  x9255.CheckIVTProcessMaterial)
    x9255.MaterialCode = trim$(  x9255.MaterialCode)
    x9255.PriceIVTMaterialUSD = trim$(  x9255.PriceIVTMaterialUSD)
    x9255.PriceIVTMaterialVND = trim$(  x9255.PriceIVTMaterialVND)
    x9255.LTBoxTotalIVTMaterial = trim$(  x9255.LTBoxTotalIVTMaterial)
    x9255.LTQtyTotalIVTMaterial = trim$(  x9255.LTQtyTotalIVTMaterial)
    x9255.LTBoxTotalIVTMaterial_Normal = trim$(  x9255.LTBoxTotalIVTMaterial_Normal)
    x9255.LTQtyTotalIVTMaterial_Normal = trim$(  x9255.LTQtyTotalIVTMaterial_Normal)
    x9255.LTBoxTotalIVTMaterial_Sample = trim$(  x9255.LTBoxTotalIVTMaterial_Sample)
    x9255.LTQtyTotalIVTMaterial_Sample = trim$(  x9255.LTQtyTotalIVTMaterial_Sample)
    x9255.LTBoxTotalIVTMaterial_Return = trim$(  x9255.LTBoxTotalIVTMaterial_Return)
    x9255.LTQtyTotalIVTMaterial_Return = trim$(  x9255.LTQtyTotalIVTMaterial_Return)
    x9255.LTBoxTotalIVTMaterial_Again = trim$(  x9255.LTBoxTotalIVTMaterial_Again)
    x9255.LTQtyTotalIVTMaterial_Again = trim$(  x9255.LTQtyTotalIVTMaterial_Again)
    x9255.BLBoxTotalIVTMaterial = trim$(  x9255.BLBoxTotalIVTMaterial)
    x9255.BLQtyTotalIVTMaterial = trim$(  x9255.BLQtyTotalIVTMaterial)
    x9255.BLBoxTotalIVTMaterial_Normal = trim$(  x9255.BLBoxTotalIVTMaterial_Normal)
    x9255.BLQtyTotalIVTMaterial_Normal = trim$(  x9255.BLQtyTotalIVTMaterial_Normal)
    x9255.BLBoxTotalIVTMaterial_Sample = trim$(  x9255.BLBoxTotalIVTMaterial_Sample)
    x9255.BLQtyTotalIVTMaterial_Sample = trim$(  x9255.BLQtyTotalIVTMaterial_Sample)
    x9255.BLBoxTotalIVTMaterial_Return = trim$(  x9255.BLBoxTotalIVTMaterial_Return)
    x9255.BLQtyTotalIVTMaterial_Return = trim$(  x9255.BLQtyTotalIVTMaterial_Return)
    x9255.BLBoxTotalIVTMaterial_Again = trim$(  x9255.BLBoxTotalIVTMaterial_Again)
    x9255.BLQtyTotalIVTMaterial_Again = trim$(  x9255.BLQtyTotalIVTMaterial_Again)
    x9255.AmountIVTMaterialUSD = trim$(  x9255.AmountIVTMaterialUSD)
    x9255.AmountIVTMaterialVND = trim$(  x9255.AmountIVTMaterialVND)
     
    If trim$( x9255.DateIVTMaterial ) = "" Then x9255.DateIVTMaterial = Space(1) 
    If trim$( x9255.cdFactoryMaterial ) = "" Then x9255.cdFactoryMaterial = Space(1) 
    If trim$( x9255.CheckIVTProcessMaterial ) = "" Then x9255.CheckIVTProcessMaterial = Space(1) 
    If trim$( x9255.MaterialCode ) = "" Then x9255.MaterialCode = Space(1) 
    If trim$( x9255.PriceIVTMaterialUSD ) = "" Then x9255.PriceIVTMaterialUSD = 0 
    If trim$( x9255.PriceIVTMaterialVND ) = "" Then x9255.PriceIVTMaterialVND = 0 
    If trim$( x9255.LTBoxTotalIVTMaterial ) = "" Then x9255.LTBoxTotalIVTMaterial = 0 
    If trim$( x9255.LTQtyTotalIVTMaterial ) = "" Then x9255.LTQtyTotalIVTMaterial = 0 
    If trim$( x9255.LTBoxTotalIVTMaterial_Normal ) = "" Then x9255.LTBoxTotalIVTMaterial_Normal = 0 
    If trim$( x9255.LTQtyTotalIVTMaterial_Normal ) = "" Then x9255.LTQtyTotalIVTMaterial_Normal = 0 
    If trim$( x9255.LTBoxTotalIVTMaterial_Sample ) = "" Then x9255.LTBoxTotalIVTMaterial_Sample = 0 
    If trim$( x9255.LTQtyTotalIVTMaterial_Sample ) = "" Then x9255.LTQtyTotalIVTMaterial_Sample = 0 
    If trim$( x9255.LTBoxTotalIVTMaterial_Return ) = "" Then x9255.LTBoxTotalIVTMaterial_Return = 0 
    If trim$( x9255.LTQtyTotalIVTMaterial_Return ) = "" Then x9255.LTQtyTotalIVTMaterial_Return = 0 
    If trim$( x9255.LTBoxTotalIVTMaterial_Again ) = "" Then x9255.LTBoxTotalIVTMaterial_Again = 0 
    If trim$( x9255.LTQtyTotalIVTMaterial_Again ) = "" Then x9255.LTQtyTotalIVTMaterial_Again = 0 
    If trim$( x9255.BLBoxTotalIVTMaterial ) = "" Then x9255.BLBoxTotalIVTMaterial = 0 
    If trim$( x9255.BLQtyTotalIVTMaterial ) = "" Then x9255.BLQtyTotalIVTMaterial = 0 
    If trim$( x9255.BLBoxTotalIVTMaterial_Normal ) = "" Then x9255.BLBoxTotalIVTMaterial_Normal = 0 
    If trim$( x9255.BLQtyTotalIVTMaterial_Normal ) = "" Then x9255.BLQtyTotalIVTMaterial_Normal = 0 
    If trim$( x9255.BLBoxTotalIVTMaterial_Sample ) = "" Then x9255.BLBoxTotalIVTMaterial_Sample = 0 
    If trim$( x9255.BLQtyTotalIVTMaterial_Sample ) = "" Then x9255.BLQtyTotalIVTMaterial_Sample = 0 
    If trim$( x9255.BLBoxTotalIVTMaterial_Return ) = "" Then x9255.BLBoxTotalIVTMaterial_Return = 0 
    If trim$( x9255.BLQtyTotalIVTMaterial_Return ) = "" Then x9255.BLQtyTotalIVTMaterial_Return = 0 
    If trim$( x9255.BLBoxTotalIVTMaterial_Again ) = "" Then x9255.BLBoxTotalIVTMaterial_Again = 0 
    If trim$( x9255.BLQtyTotalIVTMaterial_Again ) = "" Then x9255.BLQtyTotalIVTMaterial_Again = 0 
    If trim$( x9255.AmountIVTMaterialUSD ) = "" Then x9255.AmountIVTMaterialUSD = 0 
    If trim$( x9255.AmountIVTMaterialVND ) = "" Then x9255.AmountIVTMaterialVND = 0 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K9255_MOVE(rs9255 As SqlClient.SqlDataReader)
Try

    call D9255_CLEAR()   

    If IsdbNull(rs9255!K9255_DateIVTMaterial) = False Then D9255.DateIVTMaterial = Trim$(rs9255!K9255_DateIVTMaterial)
    If IsdbNull(rs9255!K9255_cdFactoryMaterial) = False Then D9255.cdFactoryMaterial = Trim$(rs9255!K9255_cdFactoryMaterial)
    If IsdbNull(rs9255!K9255_CheckIVTProcessMaterial) = False Then D9255.CheckIVTProcessMaterial = Trim$(rs9255!K9255_CheckIVTProcessMaterial)
    If IsdbNull(rs9255!K9255_MaterialCode) = False Then D9255.MaterialCode = Trim$(rs9255!K9255_MaterialCode)
    If IsdbNull(rs9255!K9255_PriceIVTMaterialUSD) = False Then D9255.PriceIVTMaterialUSD = Trim$(rs9255!K9255_PriceIVTMaterialUSD)
    If IsdbNull(rs9255!K9255_PriceIVTMaterialVND) = False Then D9255.PriceIVTMaterialVND = Trim$(rs9255!K9255_PriceIVTMaterialVND)
    If IsdbNull(rs9255!K9255_LTBoxTotalIVTMaterial) = False Then D9255.LTBoxTotalIVTMaterial = Trim$(rs9255!K9255_LTBoxTotalIVTMaterial)
    If IsdbNull(rs9255!K9255_LTQtyTotalIVTMaterial) = False Then D9255.LTQtyTotalIVTMaterial = Trim$(rs9255!K9255_LTQtyTotalIVTMaterial)
    If IsdbNull(rs9255!K9255_LTBoxTotalIVTMaterial_Normal) = False Then D9255.LTBoxTotalIVTMaterial_Normal = Trim$(rs9255!K9255_LTBoxTotalIVTMaterial_Normal)
    If IsdbNull(rs9255!K9255_LTQtyTotalIVTMaterial_Normal) = False Then D9255.LTQtyTotalIVTMaterial_Normal = Trim$(rs9255!K9255_LTQtyTotalIVTMaterial_Normal)
    If IsdbNull(rs9255!K9255_LTBoxTotalIVTMaterial_Sample) = False Then D9255.LTBoxTotalIVTMaterial_Sample = Trim$(rs9255!K9255_LTBoxTotalIVTMaterial_Sample)
    If IsdbNull(rs9255!K9255_LTQtyTotalIVTMaterial_Sample) = False Then D9255.LTQtyTotalIVTMaterial_Sample = Trim$(rs9255!K9255_LTQtyTotalIVTMaterial_Sample)
    If IsdbNull(rs9255!K9255_LTBoxTotalIVTMaterial_Return) = False Then D9255.LTBoxTotalIVTMaterial_Return = Trim$(rs9255!K9255_LTBoxTotalIVTMaterial_Return)
    If IsdbNull(rs9255!K9255_LTQtyTotalIVTMaterial_Return) = False Then D9255.LTQtyTotalIVTMaterial_Return = Trim$(rs9255!K9255_LTQtyTotalIVTMaterial_Return)
    If IsdbNull(rs9255!K9255_LTBoxTotalIVTMaterial_Again) = False Then D9255.LTBoxTotalIVTMaterial_Again = Trim$(rs9255!K9255_LTBoxTotalIVTMaterial_Again)
    If IsdbNull(rs9255!K9255_LTQtyTotalIVTMaterial_Again) = False Then D9255.LTQtyTotalIVTMaterial_Again = Trim$(rs9255!K9255_LTQtyTotalIVTMaterial_Again)
    If IsdbNull(rs9255!K9255_BLBoxTotalIVTMaterial) = False Then D9255.BLBoxTotalIVTMaterial = Trim$(rs9255!K9255_BLBoxTotalIVTMaterial)
    If IsdbNull(rs9255!K9255_BLQtyTotalIVTMaterial) = False Then D9255.BLQtyTotalIVTMaterial = Trim$(rs9255!K9255_BLQtyTotalIVTMaterial)
    If IsdbNull(rs9255!K9255_BLBoxTotalIVTMaterial_Normal) = False Then D9255.BLBoxTotalIVTMaterial_Normal = Trim$(rs9255!K9255_BLBoxTotalIVTMaterial_Normal)
    If IsdbNull(rs9255!K9255_BLQtyTotalIVTMaterial_Normal) = False Then D9255.BLQtyTotalIVTMaterial_Normal = Trim$(rs9255!K9255_BLQtyTotalIVTMaterial_Normal)
    If IsdbNull(rs9255!K9255_BLBoxTotalIVTMaterial_Sample) = False Then D9255.BLBoxTotalIVTMaterial_Sample = Trim$(rs9255!K9255_BLBoxTotalIVTMaterial_Sample)
    If IsdbNull(rs9255!K9255_BLQtyTotalIVTMaterial_Sample) = False Then D9255.BLQtyTotalIVTMaterial_Sample = Trim$(rs9255!K9255_BLQtyTotalIVTMaterial_Sample)
    If IsdbNull(rs9255!K9255_BLBoxTotalIVTMaterial_Return) = False Then D9255.BLBoxTotalIVTMaterial_Return = Trim$(rs9255!K9255_BLBoxTotalIVTMaterial_Return)
    If IsdbNull(rs9255!K9255_BLQtyTotalIVTMaterial_Return) = False Then D9255.BLQtyTotalIVTMaterial_Return = Trim$(rs9255!K9255_BLQtyTotalIVTMaterial_Return)
    If IsdbNull(rs9255!K9255_BLBoxTotalIVTMaterial_Again) = False Then D9255.BLBoxTotalIVTMaterial_Again = Trim$(rs9255!K9255_BLBoxTotalIVTMaterial_Again)
    If IsdbNull(rs9255!K9255_BLQtyTotalIVTMaterial_Again) = False Then D9255.BLQtyTotalIVTMaterial_Again = Trim$(rs9255!K9255_BLQtyTotalIVTMaterial_Again)
    If IsdbNull(rs9255!K9255_AmountIVTMaterialUSD) = False Then D9255.AmountIVTMaterialUSD = Trim$(rs9255!K9255_AmountIVTMaterialUSD)
    If IsdbNull(rs9255!K9255_AmountIVTMaterialVND) = False Then D9255.AmountIVTMaterialVND = Trim$(rs9255!K9255_AmountIVTMaterialVND)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9255_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K9255_MOVE(rs9255 As DataRow)
Try

    call D9255_CLEAR()   

    If IsdbNull(rs9255!K9255_DateIVTMaterial) = False Then D9255.DateIVTMaterial = Trim$(rs9255!K9255_DateIVTMaterial)
    If IsdbNull(rs9255!K9255_cdFactoryMaterial) = False Then D9255.cdFactoryMaterial = Trim$(rs9255!K9255_cdFactoryMaterial)
    If IsdbNull(rs9255!K9255_CheckIVTProcessMaterial) = False Then D9255.CheckIVTProcessMaterial = Trim$(rs9255!K9255_CheckIVTProcessMaterial)
    If IsdbNull(rs9255!K9255_MaterialCode) = False Then D9255.MaterialCode = Trim$(rs9255!K9255_MaterialCode)
    If IsdbNull(rs9255!K9255_PriceIVTMaterialUSD) = False Then D9255.PriceIVTMaterialUSD = Trim$(rs9255!K9255_PriceIVTMaterialUSD)
    If IsdbNull(rs9255!K9255_PriceIVTMaterialVND) = False Then D9255.PriceIVTMaterialVND = Trim$(rs9255!K9255_PriceIVTMaterialVND)
    If IsdbNull(rs9255!K9255_LTBoxTotalIVTMaterial) = False Then D9255.LTBoxTotalIVTMaterial = Trim$(rs9255!K9255_LTBoxTotalIVTMaterial)
    If IsdbNull(rs9255!K9255_LTQtyTotalIVTMaterial) = False Then D9255.LTQtyTotalIVTMaterial = Trim$(rs9255!K9255_LTQtyTotalIVTMaterial)
    If IsdbNull(rs9255!K9255_LTBoxTotalIVTMaterial_Normal) = False Then D9255.LTBoxTotalIVTMaterial_Normal = Trim$(rs9255!K9255_LTBoxTotalIVTMaterial_Normal)
    If IsdbNull(rs9255!K9255_LTQtyTotalIVTMaterial_Normal) = False Then D9255.LTQtyTotalIVTMaterial_Normal = Trim$(rs9255!K9255_LTQtyTotalIVTMaterial_Normal)
    If IsdbNull(rs9255!K9255_LTBoxTotalIVTMaterial_Sample) = False Then D9255.LTBoxTotalIVTMaterial_Sample = Trim$(rs9255!K9255_LTBoxTotalIVTMaterial_Sample)
    If IsdbNull(rs9255!K9255_LTQtyTotalIVTMaterial_Sample) = False Then D9255.LTQtyTotalIVTMaterial_Sample = Trim$(rs9255!K9255_LTQtyTotalIVTMaterial_Sample)
    If IsdbNull(rs9255!K9255_LTBoxTotalIVTMaterial_Return) = False Then D9255.LTBoxTotalIVTMaterial_Return = Trim$(rs9255!K9255_LTBoxTotalIVTMaterial_Return)
    If IsdbNull(rs9255!K9255_LTQtyTotalIVTMaterial_Return) = False Then D9255.LTQtyTotalIVTMaterial_Return = Trim$(rs9255!K9255_LTQtyTotalIVTMaterial_Return)
    If IsdbNull(rs9255!K9255_LTBoxTotalIVTMaterial_Again) = False Then D9255.LTBoxTotalIVTMaterial_Again = Trim$(rs9255!K9255_LTBoxTotalIVTMaterial_Again)
    If IsdbNull(rs9255!K9255_LTQtyTotalIVTMaterial_Again) = False Then D9255.LTQtyTotalIVTMaterial_Again = Trim$(rs9255!K9255_LTQtyTotalIVTMaterial_Again)
    If IsdbNull(rs9255!K9255_BLBoxTotalIVTMaterial) = False Then D9255.BLBoxTotalIVTMaterial = Trim$(rs9255!K9255_BLBoxTotalIVTMaterial)
    If IsdbNull(rs9255!K9255_BLQtyTotalIVTMaterial) = False Then D9255.BLQtyTotalIVTMaterial = Trim$(rs9255!K9255_BLQtyTotalIVTMaterial)
    If IsdbNull(rs9255!K9255_BLBoxTotalIVTMaterial_Normal) = False Then D9255.BLBoxTotalIVTMaterial_Normal = Trim$(rs9255!K9255_BLBoxTotalIVTMaterial_Normal)
    If IsdbNull(rs9255!K9255_BLQtyTotalIVTMaterial_Normal) = False Then D9255.BLQtyTotalIVTMaterial_Normal = Trim$(rs9255!K9255_BLQtyTotalIVTMaterial_Normal)
    If IsdbNull(rs9255!K9255_BLBoxTotalIVTMaterial_Sample) = False Then D9255.BLBoxTotalIVTMaterial_Sample = Trim$(rs9255!K9255_BLBoxTotalIVTMaterial_Sample)
    If IsdbNull(rs9255!K9255_BLQtyTotalIVTMaterial_Sample) = False Then D9255.BLQtyTotalIVTMaterial_Sample = Trim$(rs9255!K9255_BLQtyTotalIVTMaterial_Sample)
    If IsdbNull(rs9255!K9255_BLBoxTotalIVTMaterial_Return) = False Then D9255.BLBoxTotalIVTMaterial_Return = Trim$(rs9255!K9255_BLBoxTotalIVTMaterial_Return)
    If IsdbNull(rs9255!K9255_BLQtyTotalIVTMaterial_Return) = False Then D9255.BLQtyTotalIVTMaterial_Return = Trim$(rs9255!K9255_BLQtyTotalIVTMaterial_Return)
    If IsdbNull(rs9255!K9255_BLBoxTotalIVTMaterial_Again) = False Then D9255.BLBoxTotalIVTMaterial_Again = Trim$(rs9255!K9255_BLBoxTotalIVTMaterial_Again)
    If IsdbNull(rs9255!K9255_BLQtyTotalIVTMaterial_Again) = False Then D9255.BLQtyTotalIVTMaterial_Again = Trim$(rs9255!K9255_BLQtyTotalIVTMaterial_Again)
    If IsdbNull(rs9255!K9255_AmountIVTMaterialUSD) = False Then D9255.AmountIVTMaterialUSD = Trim$(rs9255!K9255_AmountIVTMaterialUSD)
    If IsdbNull(rs9255!K9255_AmountIVTMaterialVND) = False Then D9255.AmountIVTMaterialVND = Trim$(rs9255!K9255_AmountIVTMaterialVND)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K9255_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K9255_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z9255 As T9255_AREA,DATEIVTMATERIAL AS String, CDFACTORYMATERIAL AS String, CHECKIVTPROCESSMATERIAL AS String, MATERIALCODE AS String) as Boolean

K9255_MOVE = False

Try
    If READ_PFK9255(DATEIVTMATERIAL, CDFACTORYMATERIAL, CHECKIVTPROCESSMATERIAL, MATERIALCODE) = True Then
                z9255 = D9255
		K9255_MOVE = True
		else
		 z9255 = nothing
     End If

     If  getColumIndex(spr,"DateIVTMaterial") > -1 then z9255.DateIVTMaterial = getDataM(spr, getColumIndex(spr,"DateIVTMaterial"), xRow)
     If  getColumIndex(spr,"cdFactoryMaterial") > -1 then z9255.cdFactoryMaterial = getDataM(spr, getColumIndex(spr,"cdFactoryMaterial"), xRow)
     If  getColumIndex(spr,"CheckIVTProcessMaterial") > -1 then z9255.CheckIVTProcessMaterial = getDataM(spr, getColumIndex(spr,"CheckIVTProcessMaterial"), xRow)
     If  getColumIndex(spr,"MaterialCode") > -1 then z9255.MaterialCode = getDataM(spr, getColumIndex(spr,"MaterialCode"), xRow)
     If  getColumIndex(spr,"PriceIVTMaterialUSD") > -1 then z9255.PriceIVTMaterialUSD = getDataM(spr, getColumIndex(spr,"PriceIVTMaterialUSD"), xRow)
     If  getColumIndex(spr,"PriceIVTMaterialVND") > -1 then z9255.PriceIVTMaterialVND = getDataM(spr, getColumIndex(spr,"PriceIVTMaterialVND"), xRow)
     If  getColumIndex(spr,"LTBoxTotalIVTMaterial") > -1 then z9255.LTBoxTotalIVTMaterial = getDataM(spr, getColumIndex(spr,"LTBoxTotalIVTMaterial"), xRow)
     If  getColumIndex(spr,"LTQtyTotalIVTMaterial") > -1 then z9255.LTQtyTotalIVTMaterial = getDataM(spr, getColumIndex(spr,"LTQtyTotalIVTMaterial"), xRow)
     If  getColumIndex(spr,"LTBoxTotalIVTMaterial_Normal") > -1 then z9255.LTBoxTotalIVTMaterial_Normal = getDataM(spr, getColumIndex(spr,"LTBoxTotalIVTMaterial_Normal"), xRow)
     If  getColumIndex(spr,"LTQtyTotalIVTMaterial_Normal") > -1 then z9255.LTQtyTotalIVTMaterial_Normal = getDataM(spr, getColumIndex(spr,"LTQtyTotalIVTMaterial_Normal"), xRow)
     If  getColumIndex(spr,"LTBoxTotalIVTMaterial_Sample") > -1 then z9255.LTBoxTotalIVTMaterial_Sample = getDataM(spr, getColumIndex(spr,"LTBoxTotalIVTMaterial_Sample"), xRow)
     If  getColumIndex(spr,"LTQtyTotalIVTMaterial_Sample") > -1 then z9255.LTQtyTotalIVTMaterial_Sample = getDataM(spr, getColumIndex(spr,"LTQtyTotalIVTMaterial_Sample"), xRow)
     If  getColumIndex(spr,"LTBoxTotalIVTMaterial_Return") > -1 then z9255.LTBoxTotalIVTMaterial_Return = getDataM(spr, getColumIndex(spr,"LTBoxTotalIVTMaterial_Return"), xRow)
     If  getColumIndex(spr,"LTQtyTotalIVTMaterial_Return") > -1 then z9255.LTQtyTotalIVTMaterial_Return = getDataM(spr, getColumIndex(spr,"LTQtyTotalIVTMaterial_Return"), xRow)
     If  getColumIndex(spr,"LTBoxTotalIVTMaterial_Again") > -1 then z9255.LTBoxTotalIVTMaterial_Again = getDataM(spr, getColumIndex(spr,"LTBoxTotalIVTMaterial_Again"), xRow)
     If  getColumIndex(spr,"LTQtyTotalIVTMaterial_Again") > -1 then z9255.LTQtyTotalIVTMaterial_Again = getDataM(spr, getColumIndex(spr,"LTQtyTotalIVTMaterial_Again"), xRow)
     If  getColumIndex(spr,"BLBoxTotalIVTMaterial") > -1 then z9255.BLBoxTotalIVTMaterial = getDataM(spr, getColumIndex(spr,"BLBoxTotalIVTMaterial"), xRow)
     If  getColumIndex(spr,"BLQtyTotalIVTMaterial") > -1 then z9255.BLQtyTotalIVTMaterial = getDataM(spr, getColumIndex(spr,"BLQtyTotalIVTMaterial"), xRow)
     If  getColumIndex(spr,"BLBoxTotalIVTMaterial_Normal") > -1 then z9255.BLBoxTotalIVTMaterial_Normal = getDataM(spr, getColumIndex(spr,"BLBoxTotalIVTMaterial_Normal"), xRow)
     If  getColumIndex(spr,"BLQtyTotalIVTMaterial_Normal") > -1 then z9255.BLQtyTotalIVTMaterial_Normal = getDataM(spr, getColumIndex(spr,"BLQtyTotalIVTMaterial_Normal"), xRow)
     If  getColumIndex(spr,"BLBoxTotalIVTMaterial_Sample") > -1 then z9255.BLBoxTotalIVTMaterial_Sample = getDataM(spr, getColumIndex(spr,"BLBoxTotalIVTMaterial_Sample"), xRow)
     If  getColumIndex(spr,"BLQtyTotalIVTMaterial_Sample") > -1 then z9255.BLQtyTotalIVTMaterial_Sample = getDataM(spr, getColumIndex(spr,"BLQtyTotalIVTMaterial_Sample"), xRow)
     If  getColumIndex(spr,"BLBoxTotalIVTMaterial_Return") > -1 then z9255.BLBoxTotalIVTMaterial_Return = getDataM(spr, getColumIndex(spr,"BLBoxTotalIVTMaterial_Return"), xRow)
     If  getColumIndex(spr,"BLQtyTotalIVTMaterial_Return") > -1 then z9255.BLQtyTotalIVTMaterial_Return = getDataM(spr, getColumIndex(spr,"BLQtyTotalIVTMaterial_Return"), xRow)
     If  getColumIndex(spr,"BLBoxTotalIVTMaterial_Again") > -1 then z9255.BLBoxTotalIVTMaterial_Again = getDataM(spr, getColumIndex(spr,"BLBoxTotalIVTMaterial_Again"), xRow)
     If  getColumIndex(spr,"BLQtyTotalIVTMaterial_Again") > -1 then z9255.BLQtyTotalIVTMaterial_Again = getDataM(spr, getColumIndex(spr,"BLQtyTotalIVTMaterial_Again"), xRow)
     If  getColumIndex(spr,"AmountIVTMaterialUSD") > -1 then z9255.AmountIVTMaterialUSD = getDataM(spr, getColumIndex(spr,"AmountIVTMaterialUSD"), xRow)
     If  getColumIndex(spr,"AmountIVTMaterialVND") > -1 then z9255.AmountIVTMaterialVND = getDataM(spr, getColumIndex(spr,"AmountIVTMaterialVND"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K9255_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K9255_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z9255 As T9255_AREA, Job as String,DATEIVTMATERIAL AS String, CDFACTORYMATERIAL AS String, CHECKIVTPROCESSMATERIAL AS String, MATERIALCODE AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K9255_MOVE = False

Try
    If READ_PFK9255(DATEIVTMATERIAL, CDFACTORYMATERIAL, CHECKIVTPROCESSMATERIAL, MATERIALCODE) = True Then
                z9255 = D9255
		K9255_MOVE = True
		else
		 z9255 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9255")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "DateIVTMaterial":z9255.DateIVTMaterial = Children(i).Code
   Case "cdFactoryMaterial":z9255.cdFactoryMaterial = Children(i).Code
   Case "CheckIVTProcessMaterial":z9255.CheckIVTProcessMaterial = Children(i).Code
   Case "MaterialCode":z9255.MaterialCode = Children(i).Code
   Case "PriceIVTMaterialUSD":z9255.PriceIVTMaterialUSD = Children(i).Code
   Case "PriceIVTMaterialVND":z9255.PriceIVTMaterialVND = Children(i).Code
   Case "LTBoxTotalIVTMaterial":z9255.LTBoxTotalIVTMaterial = Children(i).Code
   Case "LTQtyTotalIVTMaterial":z9255.LTQtyTotalIVTMaterial = Children(i).Code
   Case "LTBoxTotalIVTMaterial_Normal":z9255.LTBoxTotalIVTMaterial_Normal = Children(i).Code
   Case "LTQtyTotalIVTMaterial_Normal":z9255.LTQtyTotalIVTMaterial_Normal = Children(i).Code
   Case "LTBoxTotalIVTMaterial_Sample":z9255.LTBoxTotalIVTMaterial_Sample = Children(i).Code
   Case "LTQtyTotalIVTMaterial_Sample":z9255.LTQtyTotalIVTMaterial_Sample = Children(i).Code
   Case "LTBoxTotalIVTMaterial_Return":z9255.LTBoxTotalIVTMaterial_Return = Children(i).Code
   Case "LTQtyTotalIVTMaterial_Return":z9255.LTQtyTotalIVTMaterial_Return = Children(i).Code
   Case "LTBoxTotalIVTMaterial_Again":z9255.LTBoxTotalIVTMaterial_Again = Children(i).Code
   Case "LTQtyTotalIVTMaterial_Again":z9255.LTQtyTotalIVTMaterial_Again = Children(i).Code
   Case "BLBoxTotalIVTMaterial":z9255.BLBoxTotalIVTMaterial = Children(i).Code
   Case "BLQtyTotalIVTMaterial":z9255.BLQtyTotalIVTMaterial = Children(i).Code
   Case "BLBoxTotalIVTMaterial_Normal":z9255.BLBoxTotalIVTMaterial_Normal = Children(i).Code
   Case "BLQtyTotalIVTMaterial_Normal":z9255.BLQtyTotalIVTMaterial_Normal = Children(i).Code
   Case "BLBoxTotalIVTMaterial_Sample":z9255.BLBoxTotalIVTMaterial_Sample = Children(i).Code
   Case "BLQtyTotalIVTMaterial_Sample":z9255.BLQtyTotalIVTMaterial_Sample = Children(i).Code
   Case "BLBoxTotalIVTMaterial_Return":z9255.BLBoxTotalIVTMaterial_Return = Children(i).Code
   Case "BLQtyTotalIVTMaterial_Return":z9255.BLQtyTotalIVTMaterial_Return = Children(i).Code
   Case "BLBoxTotalIVTMaterial_Again":z9255.BLBoxTotalIVTMaterial_Again = Children(i).Code
   Case "BLQtyTotalIVTMaterial_Again":z9255.BLQtyTotalIVTMaterial_Again = Children(i).Code
   Case "AmountIVTMaterialUSD":z9255.AmountIVTMaterialUSD = Children(i).Code
   Case "AmountIVTMaterialVND":z9255.AmountIVTMaterialVND = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "DateIVTMaterial":z9255.DateIVTMaterial = Children(i).Data
   Case "cdFactoryMaterial":z9255.cdFactoryMaterial = Children(i).Data
   Case "CheckIVTProcessMaterial":z9255.CheckIVTProcessMaterial = Children(i).Data
   Case "MaterialCode":z9255.MaterialCode = Children(i).Data
   Case "PriceIVTMaterialUSD":z9255.PriceIVTMaterialUSD = Children(i).Data
   Case "PriceIVTMaterialVND":z9255.PriceIVTMaterialVND = Children(i).Data
   Case "LTBoxTotalIVTMaterial":z9255.LTBoxTotalIVTMaterial = Children(i).Data
   Case "LTQtyTotalIVTMaterial":z9255.LTQtyTotalIVTMaterial = Children(i).Data
   Case "LTBoxTotalIVTMaterial_Normal":z9255.LTBoxTotalIVTMaterial_Normal = Children(i).Data
   Case "LTQtyTotalIVTMaterial_Normal":z9255.LTQtyTotalIVTMaterial_Normal = Children(i).Data
   Case "LTBoxTotalIVTMaterial_Sample":z9255.LTBoxTotalIVTMaterial_Sample = Children(i).Data
   Case "LTQtyTotalIVTMaterial_Sample":z9255.LTQtyTotalIVTMaterial_Sample = Children(i).Data
   Case "LTBoxTotalIVTMaterial_Return":z9255.LTBoxTotalIVTMaterial_Return = Children(i).Data
   Case "LTQtyTotalIVTMaterial_Return":z9255.LTQtyTotalIVTMaterial_Return = Children(i).Data
   Case "LTBoxTotalIVTMaterial_Again":z9255.LTBoxTotalIVTMaterial_Again = Children(i).Data
   Case "LTQtyTotalIVTMaterial_Again":z9255.LTQtyTotalIVTMaterial_Again = Children(i).Data
   Case "BLBoxTotalIVTMaterial":z9255.BLBoxTotalIVTMaterial = Children(i).Data
   Case "BLQtyTotalIVTMaterial":z9255.BLQtyTotalIVTMaterial = Children(i).Data
   Case "BLBoxTotalIVTMaterial_Normal":z9255.BLBoxTotalIVTMaterial_Normal = Children(i).Data
   Case "BLQtyTotalIVTMaterial_Normal":z9255.BLQtyTotalIVTMaterial_Normal = Children(i).Data
   Case "BLBoxTotalIVTMaterial_Sample":z9255.BLBoxTotalIVTMaterial_Sample = Children(i).Data
   Case "BLQtyTotalIVTMaterial_Sample":z9255.BLQtyTotalIVTMaterial_Sample = Children(i).Data
   Case "BLBoxTotalIVTMaterial_Return":z9255.BLBoxTotalIVTMaterial_Return = Children(i).Data
   Case "BLQtyTotalIVTMaterial_Return":z9255.BLQtyTotalIVTMaterial_Return = Children(i).Data
   Case "BLBoxTotalIVTMaterial_Again":z9255.BLBoxTotalIVTMaterial_Again = Children(i).Data
   Case "BLQtyTotalIVTMaterial_Again":z9255.BLQtyTotalIVTMaterial_Again = Children(i).Data
   Case "AmountIVTMaterialUSD":z9255.AmountIVTMaterialUSD = Children(i).Data
   Case "AmountIVTMaterialVND":z9255.AmountIVTMaterialVND = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K9255_MOVE",vbCritical)
End Try
End Function 
    
End Module 
