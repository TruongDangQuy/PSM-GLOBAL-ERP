'=========================================================================================================================================================
'   TABLE : (PFK4272)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4272

Structure T4272_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	AutoKey	 AS Double	'			decimal		*
Public 	ProdDate	 AS String	'			char(8)
Public 	seFactory	 AS String	'			char(3)
Public 	cdFactory	 AS String	'			char(3)
Public 	seLineProd	 AS String	'			char(3)
Public 	cdLineProd	 AS String	'			char(3)
Public 	InchargeProduction	 AS String	'			char(8)
Public 	QtyProduction	 AS Double	'			decimal
Public 	Option1	 AS String	'			nvarchar(20)
Public 	Option2	 AS String	'			nvarchar(20)
Public 	Option3	 AS String	'			nvarchar(20)
Public 	Option4	 AS String	'			nvarchar(20)
Public 	Option5	 AS String	'			nvarchar(20)
Public 	AutoKey_K7120	 AS Double	'			decimal
Public 	ShoesCode	 AS String	'			char(6)
Public 	seGroupJobProcess	 AS String	'			char(3)
Public 	cdGroupJobProcess	 AS String	'			char(3)
Public 	MAMaID	 AS String	'			nvarchar(50)
Public 	MAMahang	 AS String	'			nvarchar(50)
Public 	MATenhang	 AS String	'			nvarchar(200)
Public 	MAGhichu	 AS String	'			nvarchar(2000)
Public 	MBSTT	 AS Double	'			decimal
Public 	MBMathangID	 AS String	'			nvarchar(50)
Public 	MBNgayapdung	 AS String	'			nvarchar(200)
Public 	MBDongia_Giay	 AS Double	'			decimal
Public 	MBDongia_Mau	 AS Double	'			decimal
Public 	MBTongthoigian	 AS Double	'			decimal
Public 	MBSonguoi_Gio	 AS Double	'			decimal
Public 	MCMaID	 AS String	'			nvarchar(50)
Public 	MCMathangID	 AS String	'			nvarchar(50)
Public 	MCMacongdoan	 AS String	'			nvarchar(50)
Public 	MCTencongdoan	 AS String	'			nvarchar(50)
Public 	MCThoigiankiemtra	 AS Double	'			decimal
Public 	MCThoigian_datra	 AS Double	'			decimal
Public 	MCThoigian_chophep	 AS Double	'			decimal
Public 	MCDongia	 AS Double	'			decimal
Public 	MCGhichu	 AS String	'			nvarchar(200)
Public 	DateInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	TimeUpdate	 AS String	'			char(14)
Public 	TimeInsert	 AS String	'			char(14)
'=========================================================================================================================================================
End structure

Public D4272 As T4272_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4272(AUTOKEY AS Double) As Boolean
    READ_PFK4272 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4272 "
    SQL = SQL & " WHERE K4272_AutoKey		 =  " & AutoKey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4272_CLEAR: GoTo SKIP_READ_PFK4272
                
    Call K4272_MOVE(rd)
    READ_PFK4272 = True

SKIP_READ_PFK4272:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4272",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4272(AUTOKEY AS Double, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4272 "
    SQL = SQL & " WHERE K4272_AutoKey		 =  " & AutoKey & "  " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4272",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4272(z4272 As T4272_AREA) As Boolean
    WRITE_PFK4272 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4272)
 
    SQL = " INSERT INTO PFK4272 "
    SQL = SQL & " ( "
    SQL = SQL & " K4272_AutoKey," 
    SQL = SQL & " K4272_ProdDate," 
    SQL = SQL & " K4272_seFactory," 
    SQL = SQL & " K4272_cdFactory," 
    SQL = SQL & " K4272_seLineProd," 
    SQL = SQL & " K4272_cdLineProd," 
    SQL = SQL & " K4272_InchargeProduction," 
    SQL = SQL & " K4272_QtyProduction," 
    SQL = SQL & " K4272_Option1," 
    SQL = SQL & " K4272_Option2," 
    SQL = SQL & " K4272_Option3," 
    SQL = SQL & " K4272_Option4," 
    SQL = SQL & " K4272_Option5," 
    SQL = SQL & " K4272_AutoKey_K7120," 
    SQL = SQL & " K4272_ShoesCode," 
    SQL = SQL & " K4272_seGroupJobProcess," 
    SQL = SQL & " K4272_cdGroupJobProcess," 
    SQL = SQL & " K4272_MAMaID," 
    SQL = SQL & " K4272_MAMahang," 
    SQL = SQL & " K4272_MATenhang," 
    SQL = SQL & " K4272_MAGhichu," 
    SQL = SQL & " K4272_MBSTT," 
    SQL = SQL & " K4272_MBMathangID," 
    SQL = SQL & " K4272_MBNgayapdung," 
    SQL = SQL & " K4272_MBDongia_Giay," 
    SQL = SQL & " K4272_MBDongia_Mau," 
    SQL = SQL & " K4272_MBTongthoigian," 
    SQL = SQL & " K4272_MBSonguoi_Gio," 
    SQL = SQL & " K4272_MCMaID," 
    SQL = SQL & " K4272_MCMathangID," 
    SQL = SQL & " K4272_MCMacongdoan," 
    SQL = SQL & " K4272_MCTencongdoan," 
    SQL = SQL & " K4272_MCThoigiankiemtra," 
    SQL = SQL & " K4272_MCThoigian_datra," 
    SQL = SQL & " K4272_MCThoigian_chophep," 
    SQL = SQL & " K4272_MCDongia," 
    SQL = SQL & " K4272_MCGhichu," 
    SQL = SQL & " K4272_DateInsert," 
    SQL = SQL & " K4272_DateUpdate," 
    SQL = SQL & " K4272_InchargeInsert," 
    SQL = SQL & " K4272_InchargeUpdate," 
    SQL = SQL & " K4272_TimeUpdate," 
    SQL = SQL & " K4272_TimeInsert " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "   " & FormatSQL(z4272.AutoKey) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4272.ProdDate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4272.seFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4272.cdFactory) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4272.seLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4272.cdLineProd) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4272.InchargeProduction) & "', "  
    SQL = SQL & "   " & FormatSQL(z4272.QtyProduction) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4272.Option1) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4272.Option2) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4272.Option3) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4272.Option4) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4272.Option5) & "', "  
    SQL = SQL & "   " & FormatSQL(z4272.AutoKey_K7120) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4272.ShoesCode) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4272.seGroupJobProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4272.cdGroupJobProcess) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4272.MAMaID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4272.MAMahang) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4272.MATenhang) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4272.MAGhichu) & "', "  
    SQL = SQL & "   " & FormatSQL(z4272.MBSTT) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4272.MBMathangID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4272.MBNgayapdung) & "', "  
    SQL = SQL & "   " & FormatSQL(z4272.MBDongia_Giay) & ", "  
    SQL = SQL & "   " & FormatSQL(z4272.MBDongia_Mau) & ", "  
    SQL = SQL & "   " & FormatSQL(z4272.MBTongthoigian) & ", "  
    SQL = SQL & "   " & FormatSQL(z4272.MBSonguoi_Gio) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4272.MCMaID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4272.MCMathangID) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4272.MCMacongdoan) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4272.MCTencongdoan) & "', "  
    SQL = SQL & "   " & FormatSQL(z4272.MCThoigiankiemtra) & ", "  
    SQL = SQL & "   " & FormatSQL(z4272.MCThoigian_datra) & ", "  
    SQL = SQL & "   " & FormatSQL(z4272.MCThoigian_chophep) & ", "  
    SQL = SQL & "   " & FormatSQL(z4272.MCDongia) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4272.MCGhichu) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4272.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4272.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4272.TimeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(PUB.TIME) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4272 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4272",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4272(z4272 As T4272_AREA) As Boolean
    REWRITE_PFK4272 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4272)
   
    SQL = " UPDATE PFK4272 SET "
    SQL = SQL & "    K4272_ProdDate      = N'" & FormatSQL(z4272.ProdDate) & "', " 
    SQL = SQL & "    K4272_seFactory      = N'" & FormatSQL(z4272.seFactory) & "', " 
    SQL = SQL & "    K4272_cdFactory      = N'" & FormatSQL(z4272.cdFactory) & "', " 
    SQL = SQL & "    K4272_seLineProd      = N'" & FormatSQL(z4272.seLineProd) & "', " 
    SQL = SQL & "    K4272_cdLineProd      = N'" & FormatSQL(z4272.cdLineProd) & "', " 
    SQL = SQL & "    K4272_InchargeProduction      = N'" & FormatSQL(z4272.InchargeProduction) & "', " 
    SQL = SQL & "    K4272_QtyProduction      =  " & FormatSQL(z4272.QtyProduction) & ", " 
    SQL = SQL & "    K4272_Option1      = N'" & FormatSQL(z4272.Option1) & "', " 
    SQL = SQL & "    K4272_Option2      = N'" & FormatSQL(z4272.Option2) & "', " 
    SQL = SQL & "    K4272_Option3      = N'" & FormatSQL(z4272.Option3) & "', " 
    SQL = SQL & "    K4272_Option4      = N'" & FormatSQL(z4272.Option4) & "', " 
    SQL = SQL & "    K4272_Option5      = N'" & FormatSQL(z4272.Option5) & "', " 
    SQL = SQL & "    K4272_AutoKey_K7120      =  " & FormatSQL(z4272.AutoKey_K7120) & ", " 
    SQL = SQL & "    K4272_ShoesCode      = N'" & FormatSQL(z4272.ShoesCode) & "', " 
    SQL = SQL & "    K4272_seGroupJobProcess      = N'" & FormatSQL(z4272.seGroupJobProcess) & "', " 
    SQL = SQL & "    K4272_cdGroupJobProcess      = N'" & FormatSQL(z4272.cdGroupJobProcess) & "', " 
    SQL = SQL & "    K4272_MAMaID      = N'" & FormatSQL(z4272.MAMaID) & "', " 
    SQL = SQL & "    K4272_MAMahang      = N'" & FormatSQL(z4272.MAMahang) & "', " 
    SQL = SQL & "    K4272_MATenhang      = N'" & FormatSQL(z4272.MATenhang) & "', " 
    SQL = SQL & "    K4272_MAGhichu      = N'" & FormatSQL(z4272.MAGhichu) & "', " 
    SQL = SQL & "    K4272_MBSTT      =  " & FormatSQL(z4272.MBSTT) & ", " 
    SQL = SQL & "    K4272_MBMathangID      = N'" & FormatSQL(z4272.MBMathangID) & "', " 
    SQL = SQL & "    K4272_MBNgayapdung      = N'" & FormatSQL(z4272.MBNgayapdung) & "', " 
    SQL = SQL & "    K4272_MBDongia_Giay      =  " & FormatSQL(z4272.MBDongia_Giay) & ", " 
    SQL = SQL & "    K4272_MBDongia_Mau      =  " & FormatSQL(z4272.MBDongia_Mau) & ", " 
    SQL = SQL & "    K4272_MBTongthoigian      =  " & FormatSQL(z4272.MBTongthoigian) & ", " 
    SQL = SQL & "    K4272_MBSonguoi_Gio      =  " & FormatSQL(z4272.MBSonguoi_Gio) & ", " 
    SQL = SQL & "    K4272_MCMaID      = N'" & FormatSQL(z4272.MCMaID) & "', " 
    SQL = SQL & "    K4272_MCMathangID      = N'" & FormatSQL(z4272.MCMathangID) & "', " 
    SQL = SQL & "    K4272_MCMacongdoan      = N'" & FormatSQL(z4272.MCMacongdoan) & "', " 
    SQL = SQL & "    K4272_MCTencongdoan      = N'" & FormatSQL(z4272.MCTencongdoan) & "', " 
    SQL = SQL & "    K4272_MCThoigiankiemtra      =  " & FormatSQL(z4272.MCThoigiankiemtra) & ", " 
    SQL = SQL & "    K4272_MCThoigian_datra      =  " & FormatSQL(z4272.MCThoigian_datra) & ", " 
    SQL = SQL & "    K4272_MCThoigian_chophep      =  " & FormatSQL(z4272.MCThoigian_chophep) & ", " 
    SQL = SQL & "    K4272_MCDongia      =  " & FormatSQL(z4272.MCDongia) & ", " 
    SQL = SQL & "    K4272_MCGhichu      = N'" & FormatSQL(z4272.MCGhichu) & "', " 
    SQL = SQL & "    K4272_DateInsert      = N'" & FormatSQL(z4272.DateInsert) & "', " 
    SQL = SQL & "    K4272_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', " 
    SQL = SQL & "    K4272_InchargeInsert      = N'" & FormatSQL(z4272.InchargeInsert) & "', " 
    SQL = SQL & "    K4272_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "', " 
    SQL = SQL & "    K4272_TimeUpdate      = N'" & FormatSQL(PUB.TIME) & "', " 
    SQL = SQL & "    K4272_TimeInsert      = N'" & FormatSQL(z4272.TimeInsert) & "'  " 
    SQL = SQL & " WHERE K4272_AutoKey		 =  " & z4272.AutoKey & "  " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  

    REWRITE_PFK4272 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4272",vbCritical)

  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4272(z4272 As T4272_AREA) As Boolean
    DELETE_PFK4272 = False

   Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4272)
      
        SQL = " DELETE FROM PFK4272  "
    SQL = SQL & " WHERE K4272_AutoKey		 =  " & z4272.AutoKey & "  " 

    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4272 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4272",vbCritical)
Finally
        Call GetFullInformation("PFK4272", "D", SQL)
  End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4272_CLEAR()
Try
    
    D4272.AutoKey = 0 
   D4272.ProdDate = ""
   D4272.seFactory = ""
   D4272.cdFactory = ""
   D4272.seLineProd = ""
   D4272.cdLineProd = ""
   D4272.InchargeProduction = ""
    D4272.QtyProduction = 0 
   D4272.Option1 = ""
   D4272.Option2 = ""
   D4272.Option3 = ""
   D4272.Option4 = ""
   D4272.Option5 = ""
    D4272.AutoKey_K7120 = 0 
   D4272.ShoesCode = ""
   D4272.seGroupJobProcess = ""
   D4272.cdGroupJobProcess = ""
   D4272.MAMaID = ""
   D4272.MAMahang = ""
   D4272.MATenhang = ""
   D4272.MAGhichu = ""
    D4272.MBSTT = 0 
   D4272.MBMathangID = ""
   D4272.MBNgayapdung = ""
    D4272.MBDongia_Giay = 0 
    D4272.MBDongia_Mau = 0 
    D4272.MBTongthoigian = 0 
    D4272.MBSonguoi_Gio = 0 
   D4272.MCMaID = ""
   D4272.MCMathangID = ""
   D4272.MCMacongdoan = ""
   D4272.MCTencongdoan = ""
    D4272.MCThoigiankiemtra = 0 
    D4272.MCThoigian_datra = 0 
    D4272.MCThoigian_chophep = 0 
    D4272.MCDongia = 0 
   D4272.MCGhichu = ""
   D4272.DateInsert = ""
   D4272.DateUpdate = ""
   D4272.InchargeInsert = ""
   D4272.InchargeUpdate = ""
   D4272.TimeUpdate = ""
   D4272.TimeInsert = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4272_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4272 As T4272_AREA)
Try
    
    x4272.AutoKey = trim$(  x4272.AutoKey)
    x4272.ProdDate = trim$(  x4272.ProdDate)
    x4272.seFactory = trim$(  x4272.seFactory)
    x4272.cdFactory = trim$(  x4272.cdFactory)
    x4272.seLineProd = trim$(  x4272.seLineProd)
    x4272.cdLineProd = trim$(  x4272.cdLineProd)
    x4272.InchargeProduction = trim$(  x4272.InchargeProduction)
    x4272.QtyProduction = trim$(  x4272.QtyProduction)
    x4272.Option1 = trim$(  x4272.Option1)
    x4272.Option2 = trim$(  x4272.Option2)
    x4272.Option3 = trim$(  x4272.Option3)
    x4272.Option4 = trim$(  x4272.Option4)
    x4272.Option5 = trim$(  x4272.Option5)
    x4272.AutoKey_K7120 = trim$(  x4272.AutoKey_K7120)
    x4272.ShoesCode = trim$(  x4272.ShoesCode)
    x4272.seGroupJobProcess = trim$(  x4272.seGroupJobProcess)
    x4272.cdGroupJobProcess = trim$(  x4272.cdGroupJobProcess)
    x4272.MAMaID = trim$(  x4272.MAMaID)
    x4272.MAMahang = trim$(  x4272.MAMahang)
    x4272.MATenhang = trim$(  x4272.MATenhang)
    x4272.MAGhichu = trim$(  x4272.MAGhichu)
    x4272.MBSTT = trim$(  x4272.MBSTT)
    x4272.MBMathangID = trim$(  x4272.MBMathangID)
    x4272.MBNgayapdung = trim$(  x4272.MBNgayapdung)
    x4272.MBDongia_Giay = trim$(  x4272.MBDongia_Giay)
    x4272.MBDongia_Mau = trim$(  x4272.MBDongia_Mau)
    x4272.MBTongthoigian = trim$(  x4272.MBTongthoigian)
    x4272.MBSonguoi_Gio = trim$(  x4272.MBSonguoi_Gio)
    x4272.MCMaID = trim$(  x4272.MCMaID)
    x4272.MCMathangID = trim$(  x4272.MCMathangID)
    x4272.MCMacongdoan = trim$(  x4272.MCMacongdoan)
    x4272.MCTencongdoan = trim$(  x4272.MCTencongdoan)
    x4272.MCThoigiankiemtra = trim$(  x4272.MCThoigiankiemtra)
    x4272.MCThoigian_datra = trim$(  x4272.MCThoigian_datra)
    x4272.MCThoigian_chophep = trim$(  x4272.MCThoigian_chophep)
    x4272.MCDongia = trim$(  x4272.MCDongia)
    x4272.MCGhichu = trim$(  x4272.MCGhichu)
    x4272.DateInsert = trim$(  x4272.DateInsert)
    x4272.DateUpdate = trim$(  x4272.DateUpdate)
    x4272.InchargeInsert = trim$(  x4272.InchargeInsert)
    x4272.InchargeUpdate = trim$(  x4272.InchargeUpdate)
    x4272.TimeUpdate = trim$(  x4272.TimeUpdate)
    x4272.TimeInsert = trim$(  x4272.TimeInsert)
     
    If trim$( x4272.AutoKey ) = "" Then x4272.AutoKey = 0 
    If trim$( x4272.ProdDate ) = "" Then x4272.ProdDate = Space(1) 
    If trim$( x4272.seFactory ) = "" Then x4272.seFactory = Space(1) 
    If trim$( x4272.cdFactory ) = "" Then x4272.cdFactory = Space(1) 
    If trim$( x4272.seLineProd ) = "" Then x4272.seLineProd = Space(1) 
    If trim$( x4272.cdLineProd ) = "" Then x4272.cdLineProd = Space(1) 
    If trim$( x4272.InchargeProduction ) = "" Then x4272.InchargeProduction = Space(1) 
    If trim$( x4272.QtyProduction ) = "" Then x4272.QtyProduction = 0 
    If trim$( x4272.Option1 ) = "" Then x4272.Option1 = Space(1) 
    If trim$( x4272.Option2 ) = "" Then x4272.Option2 = Space(1) 
    If trim$( x4272.Option3 ) = "" Then x4272.Option3 = Space(1) 
    If trim$( x4272.Option4 ) = "" Then x4272.Option4 = Space(1) 
    If trim$( x4272.Option5 ) = "" Then x4272.Option5 = Space(1) 
    If trim$( x4272.AutoKey_K7120 ) = "" Then x4272.AutoKey_K7120 = 0 
    If trim$( x4272.ShoesCode ) = "" Then x4272.ShoesCode = Space(1) 
    If trim$( x4272.seGroupJobProcess ) = "" Then x4272.seGroupJobProcess = Space(1) 
    If trim$( x4272.cdGroupJobProcess ) = "" Then x4272.cdGroupJobProcess = Space(1) 
    If trim$( x4272.MAMaID ) = "" Then x4272.MAMaID = Space(1) 
    If trim$( x4272.MAMahang ) = "" Then x4272.MAMahang = Space(1) 
    If trim$( x4272.MATenhang ) = "" Then x4272.MATenhang = Space(1) 
    If trim$( x4272.MAGhichu ) = "" Then x4272.MAGhichu = Space(1) 
    If trim$( x4272.MBSTT ) = "" Then x4272.MBSTT = 0 
    If trim$( x4272.MBMathangID ) = "" Then x4272.MBMathangID = Space(1) 
    If trim$( x4272.MBNgayapdung ) = "" Then x4272.MBNgayapdung = Space(1) 
    If trim$( x4272.MBDongia_Giay ) = "" Then x4272.MBDongia_Giay = 0 
    If trim$( x4272.MBDongia_Mau ) = "" Then x4272.MBDongia_Mau = 0 
    If trim$( x4272.MBTongthoigian ) = "" Then x4272.MBTongthoigian = 0 
    If trim$( x4272.MBSonguoi_Gio ) = "" Then x4272.MBSonguoi_Gio = 0 
    If trim$( x4272.MCMaID ) = "" Then x4272.MCMaID = Space(1) 
    If trim$( x4272.MCMathangID ) = "" Then x4272.MCMathangID = Space(1) 
    If trim$( x4272.MCMacongdoan ) = "" Then x4272.MCMacongdoan = Space(1) 
    If trim$( x4272.MCTencongdoan ) = "" Then x4272.MCTencongdoan = Space(1) 
    If trim$( x4272.MCThoigiankiemtra ) = "" Then x4272.MCThoigiankiemtra = 0 
    If trim$( x4272.MCThoigian_datra ) = "" Then x4272.MCThoigian_datra = 0 
    If trim$( x4272.MCThoigian_chophep ) = "" Then x4272.MCThoigian_chophep = 0 
    If trim$( x4272.MCDongia ) = "" Then x4272.MCDongia = 0 
    If trim$( x4272.MCGhichu ) = "" Then x4272.MCGhichu = Space(1) 
    If trim$( x4272.DateInsert ) = "" Then x4272.DateInsert = Space(1) 
    If trim$( x4272.DateUpdate ) = "" Then x4272.DateUpdate = Space(1) 
    If trim$( x4272.InchargeInsert ) = "" Then x4272.InchargeInsert = Space(1) 
    If trim$( x4272.InchargeUpdate ) = "" Then x4272.InchargeUpdate = Space(1) 
    If trim$( x4272.TimeUpdate ) = "" Then x4272.TimeUpdate = Space(1) 
    If trim$( x4272.TimeInsert ) = "" Then x4272.TimeInsert = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4272_MOVE(rs4272 As SqlClient.SqlDataReader)
Try

    call D4272_CLEAR()   

    If IsdbNull(rs4272!K4272_AutoKey) = False Then D4272.AutoKey = Trim$(rs4272!K4272_AutoKey)
    If IsdbNull(rs4272!K4272_ProdDate) = False Then D4272.ProdDate = Trim$(rs4272!K4272_ProdDate)
    If IsdbNull(rs4272!K4272_seFactory) = False Then D4272.seFactory = Trim$(rs4272!K4272_seFactory)
    If IsdbNull(rs4272!K4272_cdFactory) = False Then D4272.cdFactory = Trim$(rs4272!K4272_cdFactory)
    If IsdbNull(rs4272!K4272_seLineProd) = False Then D4272.seLineProd = Trim$(rs4272!K4272_seLineProd)
    If IsdbNull(rs4272!K4272_cdLineProd) = False Then D4272.cdLineProd = Trim$(rs4272!K4272_cdLineProd)
    If IsdbNull(rs4272!K4272_InchargeProduction) = False Then D4272.InchargeProduction = Trim$(rs4272!K4272_InchargeProduction)
    If IsdbNull(rs4272!K4272_QtyProduction) = False Then D4272.QtyProduction = Trim$(rs4272!K4272_QtyProduction)
    If IsdbNull(rs4272!K4272_Option1) = False Then D4272.Option1 = Trim$(rs4272!K4272_Option1)
    If IsdbNull(rs4272!K4272_Option2) = False Then D4272.Option2 = Trim$(rs4272!K4272_Option2)
    If IsdbNull(rs4272!K4272_Option3) = False Then D4272.Option3 = Trim$(rs4272!K4272_Option3)
    If IsdbNull(rs4272!K4272_Option4) = False Then D4272.Option4 = Trim$(rs4272!K4272_Option4)
    If IsdbNull(rs4272!K4272_Option5) = False Then D4272.Option5 = Trim$(rs4272!K4272_Option5)
    If IsdbNull(rs4272!K4272_AutoKey_K7120) = False Then D4272.AutoKey_K7120 = Trim$(rs4272!K4272_AutoKey_K7120)
    If IsdbNull(rs4272!K4272_ShoesCode) = False Then D4272.ShoesCode = Trim$(rs4272!K4272_ShoesCode)
    If IsdbNull(rs4272!K4272_seGroupJobProcess) = False Then D4272.seGroupJobProcess = Trim$(rs4272!K4272_seGroupJobProcess)
    If IsdbNull(rs4272!K4272_cdGroupJobProcess) = False Then D4272.cdGroupJobProcess = Trim$(rs4272!K4272_cdGroupJobProcess)
    If IsdbNull(rs4272!K4272_MAMaID) = False Then D4272.MAMaID = Trim$(rs4272!K4272_MAMaID)
    If IsdbNull(rs4272!K4272_MAMahang) = False Then D4272.MAMahang = Trim$(rs4272!K4272_MAMahang)
    If IsdbNull(rs4272!K4272_MATenhang) = False Then D4272.MATenhang = Trim$(rs4272!K4272_MATenhang)
    If IsdbNull(rs4272!K4272_MAGhichu) = False Then D4272.MAGhichu = Trim$(rs4272!K4272_MAGhichu)
    If IsdbNull(rs4272!K4272_MBSTT) = False Then D4272.MBSTT = Trim$(rs4272!K4272_MBSTT)
    If IsdbNull(rs4272!K4272_MBMathangID) = False Then D4272.MBMathangID = Trim$(rs4272!K4272_MBMathangID)
    If IsdbNull(rs4272!K4272_MBNgayapdung) = False Then D4272.MBNgayapdung = Trim$(rs4272!K4272_MBNgayapdung)
    If IsdbNull(rs4272!K4272_MBDongia_Giay) = False Then D4272.MBDongia_Giay = Trim$(rs4272!K4272_MBDongia_Giay)
    If IsdbNull(rs4272!K4272_MBDongia_Mau) = False Then D4272.MBDongia_Mau = Trim$(rs4272!K4272_MBDongia_Mau)
    If IsdbNull(rs4272!K4272_MBTongthoigian) = False Then D4272.MBTongthoigian = Trim$(rs4272!K4272_MBTongthoigian)
    If IsdbNull(rs4272!K4272_MBSonguoi_Gio) = False Then D4272.MBSonguoi_Gio = Trim$(rs4272!K4272_MBSonguoi_Gio)
    If IsdbNull(rs4272!K4272_MCMaID) = False Then D4272.MCMaID = Trim$(rs4272!K4272_MCMaID)
    If IsdbNull(rs4272!K4272_MCMathangID) = False Then D4272.MCMathangID = Trim$(rs4272!K4272_MCMathangID)
    If IsdbNull(rs4272!K4272_MCMacongdoan) = False Then D4272.MCMacongdoan = Trim$(rs4272!K4272_MCMacongdoan)
    If IsdbNull(rs4272!K4272_MCTencongdoan) = False Then D4272.MCTencongdoan = Trim$(rs4272!K4272_MCTencongdoan)
    If IsdbNull(rs4272!K4272_MCThoigiankiemtra) = False Then D4272.MCThoigiankiemtra = Trim$(rs4272!K4272_MCThoigiankiemtra)
    If IsdbNull(rs4272!K4272_MCThoigian_datra) = False Then D4272.MCThoigian_datra = Trim$(rs4272!K4272_MCThoigian_datra)
    If IsdbNull(rs4272!K4272_MCThoigian_chophep) = False Then D4272.MCThoigian_chophep = Trim$(rs4272!K4272_MCThoigian_chophep)
    If IsdbNull(rs4272!K4272_MCDongia) = False Then D4272.MCDongia = Trim$(rs4272!K4272_MCDongia)
    If IsdbNull(rs4272!K4272_MCGhichu) = False Then D4272.MCGhichu = Trim$(rs4272!K4272_MCGhichu)
    If IsdbNull(rs4272!K4272_DateInsert) = False Then D4272.DateInsert = Trim$(rs4272!K4272_DateInsert)
    If IsdbNull(rs4272!K4272_DateUpdate) = False Then D4272.DateUpdate = Trim$(rs4272!K4272_DateUpdate)
    If IsdbNull(rs4272!K4272_InchargeInsert) = False Then D4272.InchargeInsert = Trim$(rs4272!K4272_InchargeInsert)
    If IsdbNull(rs4272!K4272_InchargeUpdate) = False Then D4272.InchargeUpdate = Trim$(rs4272!K4272_InchargeUpdate)
    If IsdbNull(rs4272!K4272_TimeUpdate) = False Then D4272.TimeUpdate = Trim$(rs4272!K4272_TimeUpdate)
    If IsdbNull(rs4272!K4272_TimeInsert) = False Then D4272.TimeInsert = Trim$(rs4272!K4272_TimeInsert)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4272_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4272_MOVE(rs4272 As DataRow)
Try

    call D4272_CLEAR()   

    If IsdbNull(rs4272!K4272_AutoKey) = False Then D4272.AutoKey = Trim$(rs4272!K4272_AutoKey)
    If IsdbNull(rs4272!K4272_ProdDate) = False Then D4272.ProdDate = Trim$(rs4272!K4272_ProdDate)
    If IsdbNull(rs4272!K4272_seFactory) = False Then D4272.seFactory = Trim$(rs4272!K4272_seFactory)
    If IsdbNull(rs4272!K4272_cdFactory) = False Then D4272.cdFactory = Trim$(rs4272!K4272_cdFactory)
    If IsdbNull(rs4272!K4272_seLineProd) = False Then D4272.seLineProd = Trim$(rs4272!K4272_seLineProd)
    If IsdbNull(rs4272!K4272_cdLineProd) = False Then D4272.cdLineProd = Trim$(rs4272!K4272_cdLineProd)
    If IsdbNull(rs4272!K4272_InchargeProduction) = False Then D4272.InchargeProduction = Trim$(rs4272!K4272_InchargeProduction)
    If IsdbNull(rs4272!K4272_QtyProduction) = False Then D4272.QtyProduction = Trim$(rs4272!K4272_QtyProduction)
    If IsdbNull(rs4272!K4272_Option1) = False Then D4272.Option1 = Trim$(rs4272!K4272_Option1)
    If IsdbNull(rs4272!K4272_Option2) = False Then D4272.Option2 = Trim$(rs4272!K4272_Option2)
    If IsdbNull(rs4272!K4272_Option3) = False Then D4272.Option3 = Trim$(rs4272!K4272_Option3)
    If IsdbNull(rs4272!K4272_Option4) = False Then D4272.Option4 = Trim$(rs4272!K4272_Option4)
    If IsdbNull(rs4272!K4272_Option5) = False Then D4272.Option5 = Trim$(rs4272!K4272_Option5)
    If IsdbNull(rs4272!K4272_AutoKey_K7120) = False Then D4272.AutoKey_K7120 = Trim$(rs4272!K4272_AutoKey_K7120)
    If IsdbNull(rs4272!K4272_ShoesCode) = False Then D4272.ShoesCode = Trim$(rs4272!K4272_ShoesCode)
    If IsdbNull(rs4272!K4272_seGroupJobProcess) = False Then D4272.seGroupJobProcess = Trim$(rs4272!K4272_seGroupJobProcess)
    If IsdbNull(rs4272!K4272_cdGroupJobProcess) = False Then D4272.cdGroupJobProcess = Trim$(rs4272!K4272_cdGroupJobProcess)
    If IsdbNull(rs4272!K4272_MAMaID) = False Then D4272.MAMaID = Trim$(rs4272!K4272_MAMaID)
    If IsdbNull(rs4272!K4272_MAMahang) = False Then D4272.MAMahang = Trim$(rs4272!K4272_MAMahang)
    If IsdbNull(rs4272!K4272_MATenhang) = False Then D4272.MATenhang = Trim$(rs4272!K4272_MATenhang)
    If IsdbNull(rs4272!K4272_MAGhichu) = False Then D4272.MAGhichu = Trim$(rs4272!K4272_MAGhichu)
    If IsdbNull(rs4272!K4272_MBSTT) = False Then D4272.MBSTT = Trim$(rs4272!K4272_MBSTT)
    If IsdbNull(rs4272!K4272_MBMathangID) = False Then D4272.MBMathangID = Trim$(rs4272!K4272_MBMathangID)
    If IsdbNull(rs4272!K4272_MBNgayapdung) = False Then D4272.MBNgayapdung = Trim$(rs4272!K4272_MBNgayapdung)
    If IsdbNull(rs4272!K4272_MBDongia_Giay) = False Then D4272.MBDongia_Giay = Trim$(rs4272!K4272_MBDongia_Giay)
    If IsdbNull(rs4272!K4272_MBDongia_Mau) = False Then D4272.MBDongia_Mau = Trim$(rs4272!K4272_MBDongia_Mau)
    If IsdbNull(rs4272!K4272_MBTongthoigian) = False Then D4272.MBTongthoigian = Trim$(rs4272!K4272_MBTongthoigian)
    If IsdbNull(rs4272!K4272_MBSonguoi_Gio) = False Then D4272.MBSonguoi_Gio = Trim$(rs4272!K4272_MBSonguoi_Gio)
    If IsdbNull(rs4272!K4272_MCMaID) = False Then D4272.MCMaID = Trim$(rs4272!K4272_MCMaID)
    If IsdbNull(rs4272!K4272_MCMathangID) = False Then D4272.MCMathangID = Trim$(rs4272!K4272_MCMathangID)
    If IsdbNull(rs4272!K4272_MCMacongdoan) = False Then D4272.MCMacongdoan = Trim$(rs4272!K4272_MCMacongdoan)
    If IsdbNull(rs4272!K4272_MCTencongdoan) = False Then D4272.MCTencongdoan = Trim$(rs4272!K4272_MCTencongdoan)
    If IsdbNull(rs4272!K4272_MCThoigiankiemtra) = False Then D4272.MCThoigiankiemtra = Trim$(rs4272!K4272_MCThoigiankiemtra)
    If IsdbNull(rs4272!K4272_MCThoigian_datra) = False Then D4272.MCThoigian_datra = Trim$(rs4272!K4272_MCThoigian_datra)
    If IsdbNull(rs4272!K4272_MCThoigian_chophep) = False Then D4272.MCThoigian_chophep = Trim$(rs4272!K4272_MCThoigian_chophep)
    If IsdbNull(rs4272!K4272_MCDongia) = False Then D4272.MCDongia = Trim$(rs4272!K4272_MCDongia)
    If IsdbNull(rs4272!K4272_MCGhichu) = False Then D4272.MCGhichu = Trim$(rs4272!K4272_MCGhichu)
    If IsdbNull(rs4272!K4272_DateInsert) = False Then D4272.DateInsert = Trim$(rs4272!K4272_DateInsert)
    If IsdbNull(rs4272!K4272_DateUpdate) = False Then D4272.DateUpdate = Trim$(rs4272!K4272_DateUpdate)
    If IsdbNull(rs4272!K4272_InchargeInsert) = False Then D4272.InchargeInsert = Trim$(rs4272!K4272_InchargeInsert)
    If IsdbNull(rs4272!K4272_InchargeUpdate) = False Then D4272.InchargeUpdate = Trim$(rs4272!K4272_InchargeUpdate)
    If IsdbNull(rs4272!K4272_TimeUpdate) = False Then D4272.TimeUpdate = Trim$(rs4272!K4272_TimeUpdate)
    If IsdbNull(rs4272!K4272_TimeInsert) = False Then D4272.TimeInsert = Trim$(rs4272!K4272_TimeInsert)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4272_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4272_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4272 As T4272_AREA, AUTOKEY AS Double) as Boolean

K4272_MOVE = False

Try
    If READ_PFK4272(AUTOKEY) = True Then
                z4272 = D4272
		K4272_MOVE = True
		else
	z4272 = nothing
     End If

     If  getColumnIndex(spr,"AutoKey") > -1 then z4272.AutoKey = Cdecp(getDataM(spr, getColumnIndex(spr,"AutoKey"), xRow))
     If  getColumnIndex(spr,"ProdDate") > -1 then z4272.ProdDate = getDataM(spr, getColumnIndex(spr,"ProdDate"), xRow)
     If  getColumnIndex(spr,"seFactory") > -1 then z4272.seFactory = getDataM(spr, getColumnIndex(spr,"seFactory"), xRow)
     If  getColumnIndex(spr,"cdFactory") > -1 then z4272.cdFactory = getDataM(spr, getColumnIndex(spr,"cdFactory"), xRow)
     If  getColumnIndex(spr,"seLineProd") > -1 then z4272.seLineProd = getDataM(spr, getColumnIndex(spr,"seLineProd"), xRow)
     If  getColumnIndex(spr,"cdLineProd") > -1 then z4272.cdLineProd = getDataM(spr, getColumnIndex(spr,"cdLineProd"), xRow)
     If  getColumnIndex(spr,"InchargeProduction") > -1 then z4272.InchargeProduction = getDataM(spr, getColumnIndex(spr,"InchargeProduction"), xRow)
     If  getColumnIndex(spr,"QtyProduction") > -1 then z4272.QtyProduction = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyProduction"), xRow))
     If  getColumnIndex(spr,"Option1") > -1 then z4272.Option1 = getDataM(spr, getColumnIndex(spr,"Option1"), xRow)
     If  getColumnIndex(spr,"Option2") > -1 then z4272.Option2 = getDataM(spr, getColumnIndex(spr,"Option2"), xRow)
     If  getColumnIndex(spr,"Option3") > -1 then z4272.Option3 = getDataM(spr, getColumnIndex(spr,"Option3"), xRow)
     If  getColumnIndex(spr,"Option4") > -1 then z4272.Option4 = getDataM(spr, getColumnIndex(spr,"Option4"), xRow)
     If  getColumnIndex(spr,"Option5") > -1 then z4272.Option5 = getDataM(spr, getColumnIndex(spr,"Option5"), xRow)
     If  getColumnIndex(spr,"AutoKey_K7120") > -1 then z4272.AutoKey_K7120 = Cdecp(getDataM(spr, getColumnIndex(spr,"AutoKey_K7120"), xRow))
     If  getColumnIndex(spr,"ShoesCode") > -1 then z4272.ShoesCode = getDataM(spr, getColumnIndex(spr,"ShoesCode"), xRow)
     If  getColumnIndex(spr,"seGroupJobProcess") > -1 then z4272.seGroupJobProcess = getDataM(spr, getColumnIndex(spr,"seGroupJobProcess"), xRow)
     If  getColumnIndex(spr,"cdGroupJobProcess") > -1 then z4272.cdGroupJobProcess = getDataM(spr, getColumnIndex(spr,"cdGroupJobProcess"), xRow)
     If  getColumnIndex(spr,"MAMaID") > -1 then z4272.MAMaID = getDataM(spr, getColumnIndex(spr,"MAMaID"), xRow)
     If  getColumnIndex(spr,"MAMahang") > -1 then z4272.MAMahang = getDataM(spr, getColumnIndex(spr,"MAMahang"), xRow)
     If  getColumnIndex(spr,"MATenhang") > -1 then z4272.MATenhang = getDataM(spr, getColumnIndex(spr,"MATenhang"), xRow)
     If  getColumnIndex(spr,"MAGhichu") > -1 then z4272.MAGhichu = getDataM(spr, getColumnIndex(spr,"MAGhichu"), xRow)
     If  getColumnIndex(spr,"MBSTT") > -1 then z4272.MBSTT = Cdecp(getDataM(spr, getColumnIndex(spr,"MBSTT"), xRow))
     If  getColumnIndex(spr,"MBMathangID") > -1 then z4272.MBMathangID = getDataM(spr, getColumnIndex(spr,"MBMathangID"), xRow)
     If  getColumnIndex(spr,"MBNgayapdung") > -1 then z4272.MBNgayapdung = getDataM(spr, getColumnIndex(spr,"MBNgayapdung"), xRow)
     If  getColumnIndex(spr,"MBDongia_Giay") > -1 then z4272.MBDongia_Giay = Cdecp(getDataM(spr, getColumnIndex(spr,"MBDongia_Giay"), xRow))
     If  getColumnIndex(spr,"MBDongia_Mau") > -1 then z4272.MBDongia_Mau = Cdecp(getDataM(spr, getColumnIndex(spr,"MBDongia_Mau"), xRow))
     If  getColumnIndex(spr,"MBTongthoigian") > -1 then z4272.MBTongthoigian = Cdecp(getDataM(spr, getColumnIndex(spr,"MBTongthoigian"), xRow))
     If  getColumnIndex(spr,"MBSonguoi_Gio") > -1 then z4272.MBSonguoi_Gio = Cdecp(getDataM(spr, getColumnIndex(spr,"MBSonguoi_Gio"), xRow))
     If  getColumnIndex(spr,"MCMaID") > -1 then z4272.MCMaID = getDataM(spr, getColumnIndex(spr,"MCMaID"), xRow)
     If  getColumnIndex(spr,"MCMathangID") > -1 then z4272.MCMathangID = getDataM(spr, getColumnIndex(spr,"MCMathangID"), xRow)
     If  getColumnIndex(spr,"MCMacongdoan") > -1 then z4272.MCMacongdoan = getDataM(spr, getColumnIndex(spr,"MCMacongdoan"), xRow)
     If  getColumnIndex(spr,"MCTencongdoan") > -1 then z4272.MCTencongdoan = getDataM(spr, getColumnIndex(spr,"MCTencongdoan"), xRow)
     If  getColumnIndex(spr,"MCThoigiankiemtra") > -1 then z4272.MCThoigiankiemtra = Cdecp(getDataM(spr, getColumnIndex(spr,"MCThoigiankiemtra"), xRow))
     If  getColumnIndex(spr,"MCThoigian_datra") > -1 then z4272.MCThoigian_datra = Cdecp(getDataM(spr, getColumnIndex(spr,"MCThoigian_datra"), xRow))
     If  getColumnIndex(spr,"MCThoigian_chophep") > -1 then z4272.MCThoigian_chophep = Cdecp(getDataM(spr, getColumnIndex(spr,"MCThoigian_chophep"), xRow))
     If  getColumnIndex(spr,"MCDongia") > -1 then z4272.MCDongia = Cdecp(getDataM(spr, getColumnIndex(spr,"MCDongia"), xRow))
     If  getColumnIndex(spr,"MCGhichu") > -1 then z4272.MCGhichu = getDataM(spr, getColumnIndex(spr,"MCGhichu"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z4272.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z4272.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z4272.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z4272.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)
     If  getColumnIndex(spr,"TimeUpdate") > -1 then z4272.TimeUpdate = getDataM(spr, getColumnIndex(spr,"TimeUpdate"), xRow)
     If  getColumnIndex(spr,"TimeInsert") > -1 then z4272.TimeInsert = getDataM(spr, getColumnIndex(spr,"TimeInsert"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4272_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4272_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4272 As T4272_AREA,CheckClear as Boolean,AUTOKEY AS Double) as Boolean

K4272_MOVE = False

Try
    If READ_PFK4272(AUTOKEY) = True Then
                z4272 = D4272
		K4272_MOVE = True
		else
	If CheckClear  = True then z4272 = nothing
     End If

     If  getColumnIndex(spr,"AutoKey") > -1 then z4272.AutoKey = Cdecp(getDataM(spr, getColumnIndex(spr,"AutoKey"), xRow))
     If  getColumnIndex(spr,"ProdDate") > -1 then z4272.ProdDate = getDataM(spr, getColumnIndex(spr,"ProdDate"), xRow)
     If  getColumnIndex(spr,"seFactory") > -1 then z4272.seFactory = getDataM(spr, getColumnIndex(spr,"seFactory"), xRow)
     If  getColumnIndex(spr,"cdFactory") > -1 then z4272.cdFactory = getDataM(spr, getColumnIndex(spr,"cdFactory"), xRow)
     If  getColumnIndex(spr,"seLineProd") > -1 then z4272.seLineProd = getDataM(spr, getColumnIndex(spr,"seLineProd"), xRow)
     If  getColumnIndex(spr,"cdLineProd") > -1 then z4272.cdLineProd = getDataM(spr, getColumnIndex(spr,"cdLineProd"), xRow)
     If  getColumnIndex(spr,"InchargeProduction") > -1 then z4272.InchargeProduction = getDataM(spr, getColumnIndex(spr,"InchargeProduction"), xRow)
     If  getColumnIndex(spr,"QtyProduction") > -1 then z4272.QtyProduction = Cdecp(getDataM(spr, getColumnIndex(spr,"QtyProduction"), xRow))
     If  getColumnIndex(spr,"Option1") > -1 then z4272.Option1 = getDataM(spr, getColumnIndex(spr,"Option1"), xRow)
     If  getColumnIndex(spr,"Option2") > -1 then z4272.Option2 = getDataM(spr, getColumnIndex(spr,"Option2"), xRow)
     If  getColumnIndex(spr,"Option3") > -1 then z4272.Option3 = getDataM(spr, getColumnIndex(spr,"Option3"), xRow)
     If  getColumnIndex(spr,"Option4") > -1 then z4272.Option4 = getDataM(spr, getColumnIndex(spr,"Option4"), xRow)
     If  getColumnIndex(spr,"Option5") > -1 then z4272.Option5 = getDataM(spr, getColumnIndex(spr,"Option5"), xRow)
     If  getColumnIndex(spr,"AutoKey_K7120") > -1 then z4272.AutoKey_K7120 = Cdecp(getDataM(spr, getColumnIndex(spr,"AutoKey_K7120"), xRow))
     If  getColumnIndex(spr,"ShoesCode") > -1 then z4272.ShoesCode = getDataM(spr, getColumnIndex(spr,"ShoesCode"), xRow)
     If  getColumnIndex(spr,"seGroupJobProcess") > -1 then z4272.seGroupJobProcess = getDataM(spr, getColumnIndex(spr,"seGroupJobProcess"), xRow)
     If  getColumnIndex(spr,"cdGroupJobProcess") > -1 then z4272.cdGroupJobProcess = getDataM(spr, getColumnIndex(spr,"cdGroupJobProcess"), xRow)
     If  getColumnIndex(spr,"MAMaID") > -1 then z4272.MAMaID = getDataM(spr, getColumnIndex(spr,"MAMaID"), xRow)
     If  getColumnIndex(spr,"MAMahang") > -1 then z4272.MAMahang = getDataM(spr, getColumnIndex(spr,"MAMahang"), xRow)
     If  getColumnIndex(spr,"MATenhang") > -1 then z4272.MATenhang = getDataM(spr, getColumnIndex(spr,"MATenhang"), xRow)
     If  getColumnIndex(spr,"MAGhichu") > -1 then z4272.MAGhichu = getDataM(spr, getColumnIndex(spr,"MAGhichu"), xRow)
     If  getColumnIndex(spr,"MBSTT") > -1 then z4272.MBSTT = Cdecp(getDataM(spr, getColumnIndex(spr,"MBSTT"), xRow))
     If  getColumnIndex(spr,"MBMathangID") > -1 then z4272.MBMathangID = getDataM(spr, getColumnIndex(spr,"MBMathangID"), xRow)
     If  getColumnIndex(spr,"MBNgayapdung") > -1 then z4272.MBNgayapdung = getDataM(spr, getColumnIndex(spr,"MBNgayapdung"), xRow)
     If  getColumnIndex(spr,"MBDongia_Giay") > -1 then z4272.MBDongia_Giay = Cdecp(getDataM(spr, getColumnIndex(spr,"MBDongia_Giay"), xRow))
     If  getColumnIndex(spr,"MBDongia_Mau") > -1 then z4272.MBDongia_Mau = Cdecp(getDataM(spr, getColumnIndex(spr,"MBDongia_Mau"), xRow))
     If  getColumnIndex(spr,"MBTongthoigian") > -1 then z4272.MBTongthoigian = Cdecp(getDataM(spr, getColumnIndex(spr,"MBTongthoigian"), xRow))
     If  getColumnIndex(spr,"MBSonguoi_Gio") > -1 then z4272.MBSonguoi_Gio = Cdecp(getDataM(spr, getColumnIndex(spr,"MBSonguoi_Gio"), xRow))
     If  getColumnIndex(spr,"MCMaID") > -1 then z4272.MCMaID = getDataM(spr, getColumnIndex(spr,"MCMaID"), xRow)
     If  getColumnIndex(spr,"MCMathangID") > -1 then z4272.MCMathangID = getDataM(spr, getColumnIndex(spr,"MCMathangID"), xRow)
     If  getColumnIndex(spr,"MCMacongdoan") > -1 then z4272.MCMacongdoan = getDataM(spr, getColumnIndex(spr,"MCMacongdoan"), xRow)
     If  getColumnIndex(spr,"MCTencongdoan") > -1 then z4272.MCTencongdoan = getDataM(spr, getColumnIndex(spr,"MCTencongdoan"), xRow)
     If  getColumnIndex(spr,"MCThoigiankiemtra") > -1 then z4272.MCThoigiankiemtra = Cdecp(getDataM(spr, getColumnIndex(spr,"MCThoigiankiemtra"), xRow))
     If  getColumnIndex(spr,"MCThoigian_datra") > -1 then z4272.MCThoigian_datra = Cdecp(getDataM(spr, getColumnIndex(spr,"MCThoigian_datra"), xRow))
     If  getColumnIndex(spr,"MCThoigian_chophep") > -1 then z4272.MCThoigian_chophep = Cdecp(getDataM(spr, getColumnIndex(spr,"MCThoigian_chophep"), xRow))
     If  getColumnIndex(spr,"MCDongia") > -1 then z4272.MCDongia = Cdecp(getDataM(spr, getColumnIndex(spr,"MCDongia"), xRow))
     If  getColumnIndex(spr,"MCGhichu") > -1 then z4272.MCGhichu = getDataM(spr, getColumnIndex(spr,"MCGhichu"), xRow)
     If  getColumnIndex(spr,"DateInsert") > -1 then z4272.DateInsert = getDataM(spr, getColumnIndex(spr,"DateInsert"), xRow)
     If  getColumnIndex(spr,"DateUpdate") > -1 then z4272.DateUpdate = getDataM(spr, getColumnIndex(spr,"DateUpdate"), xRow)
     If  getColumnIndex(spr,"InchargeInsert") > -1 then z4272.InchargeInsert = getDataM(spr, getColumnIndex(spr,"InchargeInsert"), xRow)
     If  getColumnIndex(spr,"InchargeUpdate") > -1 then z4272.InchargeUpdate = getDataM(spr, getColumnIndex(spr,"InchargeUpdate"), xRow)
     If  getColumnIndex(spr,"TimeUpdate") > -1 then z4272.TimeUpdate = getDataM(spr, getColumnIndex(spr,"TimeUpdate"), xRow)
     If  getColumnIndex(spr,"TimeInsert") > -1 then z4272.TimeInsert = getDataM(spr, getColumnIndex(spr,"TimeInsert"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4272_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4272_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4272 As T4272_AREA, Job as String, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4272_MOVE = False

Try
    If READ_PFK4272(AUTOKEY) = True Then
                z4272 = D4272
		K4272_MOVE = True
		else
	z4272 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4272")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z4272.AutoKey = Children(i).Code
   Case "PRODDATE":z4272.ProdDate = Children(i).Code
   Case "SEFACTORY":z4272.seFactory = Children(i).Code
   Case "CDFACTORY":z4272.cdFactory = Children(i).Code
   Case "SELINEPROD":z4272.seLineProd = Children(i).Code
   Case "CDLINEPROD":z4272.cdLineProd = Children(i).Code
   Case "INCHARGEPRODUCTION":z4272.InchargeProduction = Children(i).Code
   Case "QTYPRODUCTION":z4272.QtyProduction = Children(i).Code
   Case "OPTION1":z4272.Option1 = Children(i).Code
   Case "OPTION2":z4272.Option2 = Children(i).Code
   Case "OPTION3":z4272.Option3 = Children(i).Code
   Case "OPTION4":z4272.Option4 = Children(i).Code
   Case "OPTION5":z4272.Option5 = Children(i).Code
   Case "AUTOKEY_K7120":z4272.AutoKey_K7120 = Children(i).Code
   Case "SHOESCODE":z4272.ShoesCode = Children(i).Code
   Case "SEGROUPJOBPROCESS":z4272.seGroupJobProcess = Children(i).Code
   Case "CDGROUPJOBPROCESS":z4272.cdGroupJobProcess = Children(i).Code
   Case "MAMAID":z4272.MAMaID = Children(i).Code
   Case "MAMAHANG":z4272.MAMahang = Children(i).Code
   Case "MATENHANG":z4272.MATenhang = Children(i).Code
   Case "MAGHICHU":z4272.MAGhichu = Children(i).Code
   Case "MBSTT":z4272.MBSTT = Children(i).Code
   Case "MBMATHANGID":z4272.MBMathangID = Children(i).Code
   Case "MBNGAYAPDUNG":z4272.MBNgayapdung = Children(i).Code
   Case "MBDONGIA_GIAY":z4272.MBDongia_Giay = Children(i).Code
   Case "MBDONGIA_MAU":z4272.MBDongia_Mau = Children(i).Code
   Case "MBTONGTHOIGIAN":z4272.MBTongthoigian = Children(i).Code
   Case "MBSONGUOI_GIO":z4272.MBSonguoi_Gio = Children(i).Code
   Case "MCMAID":z4272.MCMaID = Children(i).Code
   Case "MCMATHANGID":z4272.MCMathangID = Children(i).Code
   Case "MCMACONGDOAN":z4272.MCMacongdoan = Children(i).Code
   Case "MCTENCONGDOAN":z4272.MCTencongdoan = Children(i).Code
   Case "MCTHOIGIANKIEMTRA":z4272.MCThoigiankiemtra = Children(i).Code
   Case "MCTHOIGIAN_DATRA":z4272.MCThoigian_datra = Children(i).Code
   Case "MCTHOIGIAN_CHOPHEP":z4272.MCThoigian_chophep = Children(i).Code
   Case "MCDONGIA":z4272.MCDongia = Children(i).Code
   Case "MCGHICHU":z4272.MCGhichu = Children(i).Code
   Case "DATEINSERT":z4272.DateInsert = Children(i).Code
   Case "DATEUPDATE":z4272.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z4272.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z4272.InchargeUpdate = Children(i).Code
   Case "TIMEUPDATE":z4272.TimeUpdate = Children(i).Code
   Case "TIMEINSERT":z4272.TimeInsert = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z4272.AutoKey = Cdecp(Children(i).Data)
   Case "PRODDATE":z4272.ProdDate = Children(i).Data
   Case "SEFACTORY":z4272.seFactory = Children(i).Data
   Case "CDFACTORY":z4272.cdFactory = Children(i).Data
   Case "SELINEPROD":z4272.seLineProd = Children(i).Data
   Case "CDLINEPROD":z4272.cdLineProd = Children(i).Data
   Case "INCHARGEPRODUCTION":z4272.InchargeProduction = Children(i).Data
   Case "QTYPRODUCTION":z4272.QtyProduction = Cdecp(Children(i).Data)
   Case "OPTION1":z4272.Option1 = Children(i).Data
   Case "OPTION2":z4272.Option2 = Children(i).Data
   Case "OPTION3":z4272.Option3 = Children(i).Data
   Case "OPTION4":z4272.Option4 = Children(i).Data
   Case "OPTION5":z4272.Option5 = Children(i).Data
   Case "AUTOKEY_K7120":z4272.AutoKey_K7120 = Cdecp(Children(i).Data)
   Case "SHOESCODE":z4272.ShoesCode = Children(i).Data
   Case "SEGROUPJOBPROCESS":z4272.seGroupJobProcess = Children(i).Data
   Case "CDGROUPJOBPROCESS":z4272.cdGroupJobProcess = Children(i).Data
   Case "MAMAID":z4272.MAMaID = Children(i).Data
   Case "MAMAHANG":z4272.MAMahang = Children(i).Data
   Case "MATENHANG":z4272.MATenhang = Children(i).Data
   Case "MAGHICHU":z4272.MAGhichu = Children(i).Data
   Case "MBSTT":z4272.MBSTT = Cdecp(Children(i).Data)
   Case "MBMATHANGID":z4272.MBMathangID = Children(i).Data
   Case "MBNGAYAPDUNG":z4272.MBNgayapdung = Children(i).Data
   Case "MBDONGIA_GIAY":z4272.MBDongia_Giay = Cdecp(Children(i).Data)
   Case "MBDONGIA_MAU":z4272.MBDongia_Mau = Cdecp(Children(i).Data)
   Case "MBTONGTHOIGIAN":z4272.MBTongthoigian = Cdecp(Children(i).Data)
   Case "MBSONGUOI_GIO":z4272.MBSonguoi_Gio = Cdecp(Children(i).Data)
   Case "MCMAID":z4272.MCMaID = Children(i).Data
   Case "MCMATHANGID":z4272.MCMathangID = Children(i).Data
   Case "MCMACONGDOAN":z4272.MCMacongdoan = Children(i).Data
   Case "MCTENCONGDOAN":z4272.MCTencongdoan = Children(i).Data
   Case "MCTHOIGIANKIEMTRA":z4272.MCThoigiankiemtra = Cdecp(Children(i).Data)
   Case "MCTHOIGIAN_DATRA":z4272.MCThoigian_datra = Cdecp(Children(i).Data)
   Case "MCTHOIGIAN_CHOPHEP":z4272.MCThoigian_chophep = Cdecp(Children(i).Data)
   Case "MCDONGIA":z4272.MCDongia = Cdecp(Children(i).Data)
   Case "MCGHICHU":z4272.MCGhichu = Children(i).Data
   Case "DATEINSERT":z4272.DateInsert = Children(i).Data
   Case "DATEUPDATE":z4272.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z4272.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z4272.InchargeUpdate = Children(i).Data
   Case "TIMEUPDATE":z4272.TimeUpdate = Children(i).Data
   Case "TIMEINSERT":z4272.TimeInsert = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4272_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4272_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4272 As T4272_AREA, Job as String, CheckClear as Boolean, AUTOKEY AS Double) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4272_MOVE = False

Try
    If READ_PFK4272(AUTOKEY) = True Then
                z4272 = D4272
		K4272_MOVE = True
		else
	If CheckClear  = True then z4272 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4272")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "AUTOKEY":z4272.AutoKey = Children(i).Code
   Case "PRODDATE":z4272.ProdDate = Children(i).Code
   Case "SEFACTORY":z4272.seFactory = Children(i).Code
   Case "CDFACTORY":z4272.cdFactory = Children(i).Code
   Case "SELINEPROD":z4272.seLineProd = Children(i).Code
   Case "CDLINEPROD":z4272.cdLineProd = Children(i).Code
   Case "INCHARGEPRODUCTION":z4272.InchargeProduction = Children(i).Code
   Case "QTYPRODUCTION":z4272.QtyProduction = Children(i).Code
   Case "OPTION1":z4272.Option1 = Children(i).Code
   Case "OPTION2":z4272.Option2 = Children(i).Code
   Case "OPTION3":z4272.Option3 = Children(i).Code
   Case "OPTION4":z4272.Option4 = Children(i).Code
   Case "OPTION5":z4272.Option5 = Children(i).Code
   Case "AUTOKEY_K7120":z4272.AutoKey_K7120 = Children(i).Code
   Case "SHOESCODE":z4272.ShoesCode = Children(i).Code
   Case "SEGROUPJOBPROCESS":z4272.seGroupJobProcess = Children(i).Code
   Case "CDGROUPJOBPROCESS":z4272.cdGroupJobProcess = Children(i).Code
   Case "MAMAID":z4272.MAMaID = Children(i).Code
   Case "MAMAHANG":z4272.MAMahang = Children(i).Code
   Case "MATENHANG":z4272.MATenhang = Children(i).Code
   Case "MAGHICHU":z4272.MAGhichu = Children(i).Code
   Case "MBSTT":z4272.MBSTT = Children(i).Code
   Case "MBMATHANGID":z4272.MBMathangID = Children(i).Code
   Case "MBNGAYAPDUNG":z4272.MBNgayapdung = Children(i).Code
   Case "MBDONGIA_GIAY":z4272.MBDongia_Giay = Children(i).Code
   Case "MBDONGIA_MAU":z4272.MBDongia_Mau = Children(i).Code
   Case "MBTONGTHOIGIAN":z4272.MBTongthoigian = Children(i).Code
   Case "MBSONGUOI_GIO":z4272.MBSonguoi_Gio = Children(i).Code
   Case "MCMAID":z4272.MCMaID = Children(i).Code
   Case "MCMATHANGID":z4272.MCMathangID = Children(i).Code
   Case "MCMACONGDOAN":z4272.MCMacongdoan = Children(i).Code
   Case "MCTENCONGDOAN":z4272.MCTencongdoan = Children(i).Code
   Case "MCTHOIGIANKIEMTRA":z4272.MCThoigiankiemtra = Children(i).Code
   Case "MCTHOIGIAN_DATRA":z4272.MCThoigian_datra = Children(i).Code
   Case "MCTHOIGIAN_CHOPHEP":z4272.MCThoigian_chophep = Children(i).Code
   Case "MCDONGIA":z4272.MCDongia = Children(i).Code
   Case "MCGHICHU":z4272.MCGhichu = Children(i).Code
   Case "DATEINSERT":z4272.DateInsert = Children(i).Code
   Case "DATEUPDATE":z4272.DateUpdate = Children(i).Code
   Case "INCHARGEINSERT":z4272.InchargeInsert = Children(i).Code
   Case "INCHARGEUPDATE":z4272.InchargeUpdate = Children(i).Code
   Case "TIMEUPDATE":z4272.TimeUpdate = Children(i).Code
   Case "TIMEINSERT":z4272.TimeInsert = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "AUTOKEY":z4272.AutoKey = Cdecp(Children(i).Data)
   Case "PRODDATE":z4272.ProdDate = Children(i).Data
   Case "SEFACTORY":z4272.seFactory = Children(i).Data
   Case "CDFACTORY":z4272.cdFactory = Children(i).Data
   Case "SELINEPROD":z4272.seLineProd = Children(i).Data
   Case "CDLINEPROD":z4272.cdLineProd = Children(i).Data
   Case "INCHARGEPRODUCTION":z4272.InchargeProduction = Children(i).Data
   Case "QTYPRODUCTION":z4272.QtyProduction = Cdecp(Children(i).Data)
   Case "OPTION1":z4272.Option1 = Children(i).Data
   Case "OPTION2":z4272.Option2 = Children(i).Data
   Case "OPTION3":z4272.Option3 = Children(i).Data
   Case "OPTION4":z4272.Option4 = Children(i).Data
   Case "OPTION5":z4272.Option5 = Children(i).Data
   Case "AUTOKEY_K7120":z4272.AutoKey_K7120 = Cdecp(Children(i).Data)
   Case "SHOESCODE":z4272.ShoesCode = Children(i).Data
   Case "SEGROUPJOBPROCESS":z4272.seGroupJobProcess = Children(i).Data
   Case "CDGROUPJOBPROCESS":z4272.cdGroupJobProcess = Children(i).Data
   Case "MAMAID":z4272.MAMaID = Children(i).Data
   Case "MAMAHANG":z4272.MAMahang = Children(i).Data
   Case "MATENHANG":z4272.MATenhang = Children(i).Data
   Case "MAGHICHU":z4272.MAGhichu = Children(i).Data
   Case "MBSTT":z4272.MBSTT = Cdecp(Children(i).Data)
   Case "MBMATHANGID":z4272.MBMathangID = Children(i).Data
   Case "MBNGAYAPDUNG":z4272.MBNgayapdung = Children(i).Data
   Case "MBDONGIA_GIAY":z4272.MBDongia_Giay = Cdecp(Children(i).Data)
   Case "MBDONGIA_MAU":z4272.MBDongia_Mau = Cdecp(Children(i).Data)
   Case "MBTONGTHOIGIAN":z4272.MBTongthoigian = Cdecp(Children(i).Data)
   Case "MBSONGUOI_GIO":z4272.MBSonguoi_Gio = Cdecp(Children(i).Data)
   Case "MCMAID":z4272.MCMaID = Children(i).Data
   Case "MCMATHANGID":z4272.MCMathangID = Children(i).Data
   Case "MCMACONGDOAN":z4272.MCMacongdoan = Children(i).Data
   Case "MCTENCONGDOAN":z4272.MCTencongdoan = Children(i).Data
   Case "MCTHOIGIANKIEMTRA":z4272.MCThoigiankiemtra = Cdecp(Children(i).Data)
   Case "MCTHOIGIAN_DATRA":z4272.MCThoigian_datra = Cdecp(Children(i).Data)
   Case "MCTHOIGIAN_CHOPHEP":z4272.MCThoigian_chophep = Cdecp(Children(i).Data)
   Case "MCDONGIA":z4272.MCDongia = Cdecp(Children(i).Data)
   Case "MCGHICHU":z4272.MCGhichu = Children(i).Data
   Case "DATEINSERT":z4272.DateInsert = Children(i).Data
   Case "DATEUPDATE":z4272.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z4272.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z4272.InchargeUpdate = Children(i).Data
   Case "TIMEUPDATE":z4272.TimeUpdate = Children(i).Data
   Case "TIMEINSERT":z4272.TimeInsert = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4272_MOVE",vbCritical)
End Try
End Function 
    

'=========================================================================================================================================================
' DATA MOVE FORM NEW AREA
'=========================================================================================================================================================
Public Sub K4272_MOVE(ByRef a4272 As T4272_AREA, ByRef b4272 As T4272_AREA) 
Try
If trim$( a4272.AutoKey ) = "" Then b4272.AutoKey = ""  Else b4272.AutoKey=a4272.AutoKey
If trim$( a4272.ProdDate ) = "" Then b4272.ProdDate = ""  Else b4272.ProdDate=a4272.ProdDate
If trim$( a4272.seFactory ) = "" Then b4272.seFactory = ""  Else b4272.seFactory=a4272.seFactory
If trim$( a4272.cdFactory ) = "" Then b4272.cdFactory = ""  Else b4272.cdFactory=a4272.cdFactory
If trim$( a4272.seLineProd ) = "" Then b4272.seLineProd = ""  Else b4272.seLineProd=a4272.seLineProd
If trim$( a4272.cdLineProd ) = "" Then b4272.cdLineProd = ""  Else b4272.cdLineProd=a4272.cdLineProd
If trim$( a4272.InchargeProduction ) = "" Then b4272.InchargeProduction = ""  Else b4272.InchargeProduction=a4272.InchargeProduction
If trim$( a4272.QtyProduction ) = "" Then b4272.QtyProduction = ""  Else b4272.QtyProduction=a4272.QtyProduction
If trim$( a4272.Option1 ) = "" Then b4272.Option1 = ""  Else b4272.Option1=a4272.Option1
If trim$( a4272.Option2 ) = "" Then b4272.Option2 = ""  Else b4272.Option2=a4272.Option2
If trim$( a4272.Option3 ) = "" Then b4272.Option3 = ""  Else b4272.Option3=a4272.Option3
If trim$( a4272.Option4 ) = "" Then b4272.Option4 = ""  Else b4272.Option4=a4272.Option4
If trim$( a4272.Option5 ) = "" Then b4272.Option5 = ""  Else b4272.Option5=a4272.Option5
If trim$( a4272.AutoKey_K7120 ) = "" Then b4272.AutoKey_K7120 = ""  Else b4272.AutoKey_K7120=a4272.AutoKey_K7120
If trim$( a4272.ShoesCode ) = "" Then b4272.ShoesCode = ""  Else b4272.ShoesCode=a4272.ShoesCode
If trim$( a4272.seGroupJobProcess ) = "" Then b4272.seGroupJobProcess = ""  Else b4272.seGroupJobProcess=a4272.seGroupJobProcess
If trim$( a4272.cdGroupJobProcess ) = "" Then b4272.cdGroupJobProcess = ""  Else b4272.cdGroupJobProcess=a4272.cdGroupJobProcess
If trim$( a4272.MAMaID ) = "" Then b4272.MAMaID = ""  Else b4272.MAMaID=a4272.MAMaID
If trim$( a4272.MAMahang ) = "" Then b4272.MAMahang = ""  Else b4272.MAMahang=a4272.MAMahang
If trim$( a4272.MATenhang ) = "" Then b4272.MATenhang = ""  Else b4272.MATenhang=a4272.MATenhang
If trim$( a4272.MAGhichu ) = "" Then b4272.MAGhichu = ""  Else b4272.MAGhichu=a4272.MAGhichu
If trim$( a4272.MBSTT ) = "" Then b4272.MBSTT = ""  Else b4272.MBSTT=a4272.MBSTT
If trim$( a4272.MBMathangID ) = "" Then b4272.MBMathangID = ""  Else b4272.MBMathangID=a4272.MBMathangID
If trim$( a4272.MBNgayapdung ) = "" Then b4272.MBNgayapdung = ""  Else b4272.MBNgayapdung=a4272.MBNgayapdung
If trim$( a4272.MBDongia_Giay ) = "" Then b4272.MBDongia_Giay = ""  Else b4272.MBDongia_Giay=a4272.MBDongia_Giay
If trim$( a4272.MBDongia_Mau ) = "" Then b4272.MBDongia_Mau = ""  Else b4272.MBDongia_Mau=a4272.MBDongia_Mau
If trim$( a4272.MBTongthoigian ) = "" Then b4272.MBTongthoigian = ""  Else b4272.MBTongthoigian=a4272.MBTongthoigian
If trim$( a4272.MBSonguoi_Gio ) = "" Then b4272.MBSonguoi_Gio = ""  Else b4272.MBSonguoi_Gio=a4272.MBSonguoi_Gio
If trim$( a4272.MCMaID ) = "" Then b4272.MCMaID = ""  Else b4272.MCMaID=a4272.MCMaID
If trim$( a4272.MCMathangID ) = "" Then b4272.MCMathangID = ""  Else b4272.MCMathangID=a4272.MCMathangID
If trim$( a4272.MCMacongdoan ) = "" Then b4272.MCMacongdoan = ""  Else b4272.MCMacongdoan=a4272.MCMacongdoan
If trim$( a4272.MCTencongdoan ) = "" Then b4272.MCTencongdoan = ""  Else b4272.MCTencongdoan=a4272.MCTencongdoan
If trim$( a4272.MCThoigiankiemtra ) = "" Then b4272.MCThoigiankiemtra = ""  Else b4272.MCThoigiankiemtra=a4272.MCThoigiankiemtra
If trim$( a4272.MCThoigian_datra ) = "" Then b4272.MCThoigian_datra = ""  Else b4272.MCThoigian_datra=a4272.MCThoigian_datra
If trim$( a4272.MCThoigian_chophep ) = "" Then b4272.MCThoigian_chophep = ""  Else b4272.MCThoigian_chophep=a4272.MCThoigian_chophep
If trim$( a4272.MCDongia ) = "" Then b4272.MCDongia = ""  Else b4272.MCDongia=a4272.MCDongia
If trim$( a4272.MCGhichu ) = "" Then b4272.MCGhichu = ""  Else b4272.MCGhichu=a4272.MCGhichu
If trim$( a4272.DateInsert ) = "" Then b4272.DateInsert = ""  Else b4272.DateInsert=a4272.DateInsert
If trim$( a4272.DateUpdate ) = "" Then b4272.DateUpdate = ""  Else b4272.DateUpdate=a4272.DateUpdate
If trim$( a4272.InchargeInsert ) = "" Then b4272.InchargeInsert = ""  Else b4272.InchargeInsert=a4272.InchargeInsert
If trim$( a4272.InchargeUpdate ) = "" Then b4272.InchargeUpdate = ""  Else b4272.InchargeUpdate=a4272.InchargeUpdate
If trim$( a4272.TimeUpdate ) = "" Then b4272.TimeUpdate = ""  Else b4272.TimeUpdate=a4272.TimeUpdate
If trim$( a4272.TimeInsert ) = "" Then b4272.TimeInsert = ""  Else b4272.TimeInsert=a4272.TimeInsert
Catch ex As Exception
      Call MsgBoxP("K4272_MOVE",vbCritical)
End Try
End Sub 


End Module 
