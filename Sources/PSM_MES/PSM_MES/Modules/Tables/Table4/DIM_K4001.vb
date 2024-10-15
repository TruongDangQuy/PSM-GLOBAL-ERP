'=========================================================================================================================================================
'   TABLE : (PFK4001)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K4001

Structure T4001_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	WorkOrder	 AS String	'			char(9)		*
Public 	WorkOrderName	 AS String	'			nvarchar(100)
Public 	seSite	 AS String	'			char(3)
Public 	cdSite	 AS String	'			char(3)
Public 	seDepartment	 AS String	'			char(3)
Public 	cdDepartment	 AS String	'			char(3)
Public 	WorkOrderStatus	 AS String	'			char(1)
Public 	DateApproval	 AS String	'			char(8)
Public 	DateCancel	 AS String	'			char(8)
Public 	DateComplete	 AS String	'			char(8)
Public 	DatePending	 AS String	'			char(8)
Public 	DateWorkOrder	 AS String	'			char(8)
Public 	DateTransfer	 AS String	'			char(8)
Public 	QtyOrder	 AS Double	'			decimal
Public 	DateInsert	 AS String	'			char(8)
Public 	InchargeInsert	 AS String	'			char(8)
Public 	DateUpdate	 AS String	'			char(8)
Public 	InchargeUpdate	 AS String	'			char(8)
Public 	InchargeSales	 AS String	'			char(8)
Public 	InchargePPC	 AS String	'			char(8)
Public 	RemarkOrder	 AS String	'			nvarchar(500)
Public 	RemarkCustomer	 AS String	'			nvarchar(500)
Public 	RemarkOther	 AS String	'			nvarchar(500)
'=========================================================================================================================================================
End structure

Public D4001 As T4001_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK4001(WORKORDER AS String) As Boolean
    READ_PFK4001 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4001 "
    SQL = SQL & " WHERE K4001_WorkOrder		 = '" & WorkOrder & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D4001_CLEAR: GoTo SKIP_READ_PFK4001
                
    Call K4001_MOVE(rd)
    READ_PFK4001 = True

SKIP_READ_PFK4001:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK4001",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK4001(WORKORDER AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK4001 "
    SQL = SQL & " WHERE K4001_WorkOrder		 = '" & WorkOrder & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK4001",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK4001(z4001 As T4001_AREA) As Boolean
    WRITE_PFK4001 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z4001)
 
    SQL = " INSERT INTO PFK4001 "
    SQL = SQL & " ( "
    SQL = SQL & " K4001_WorkOrder," 
    SQL = SQL & " K4001_WorkOrderName," 
    SQL = SQL & " K4001_seSite," 
    SQL = SQL & " K4001_cdSite," 
    SQL = SQL & " K4001_seDepartment," 
    SQL = SQL & " K4001_cdDepartment," 
    SQL = SQL & " K4001_WorkOrderStatus," 
    SQL = SQL & " K4001_DateApproval," 
    SQL = SQL & " K4001_DateCancel," 
    SQL = SQL & " K4001_DateComplete," 
    SQL = SQL & " K4001_DatePending," 
    SQL = SQL & " K4001_DateWorkOrder," 
    SQL = SQL & " K4001_DateTransfer," 
    SQL = SQL & " K4001_QtyOrder," 
    SQL = SQL & " K4001_DateInsert," 
    SQL = SQL & " K4001_InchargeInsert," 
    SQL = SQL & " K4001_DateUpdate," 
    SQL = SQL & " K4001_InchargeUpdate," 
    SQL = SQL & " K4001_InchargeSales," 
    SQL = SQL & " K4001_InchargePPC," 
    SQL = SQL & " K4001_RemarkOrder," 
    SQL = SQL & " K4001_RemarkCustomer," 
    SQL = SQL & " K4001_RemarkOther " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & FormatSQL(z4001.WorkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4001.WorkOrderName) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4001.seSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4001.cdSite) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4001.seDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4001.cdDepartment) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4001.WorkOrderStatus) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4001.DateApproval) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4001.DateCancel) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4001.DateComplete) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4001.DatePending) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4001.DateWorkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4001.DateTransfer) & "', "  
    SQL = SQL & "   " & FormatSQL(z4001.QtyOrder) & ", "  
    SQL = SQL & "  N'" & FormatSQL(z4001.DateInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4001.InchargeInsert) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4001.DateUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4001.InchargeUpdate) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4001.InchargeSales) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4001.InchargePPC) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4001.RemarkOrder) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4001.RemarkCustomer) & "', "  
    SQL = SQL & "  N'" & FormatSQL(z4001.RemarkOther) & "'  "  
    SQL = SQL & " ) "    
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()

    WRITE_PFK4001 = True
    Exit Function
Catch ex As Exception
	Call MsgBoxP("WRITE_PFK4001",vbCritical)
End Try

End Function

'=========================================================================================================================================================
' DATA REWRITE 
'=========================================================================================================================================================
Public Function REWRITE_PFK4001(z4001 As T4001_AREA) As Boolean
    REWRITE_PFK4001 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try     
    Call NULL_ZERO(z4001)
   
    SQL = " UPDATE PFK4001 SET "
    SQL = SQL & "    K4001_WorkOrderName      = N'" & FormatSQL(z4001.WorkOrderName) & "', " 
    SQL = SQL & "    K4001_seSite      = N'" & FormatSQL(z4001.seSite) & "', " 
    SQL = SQL & "    K4001_cdSite      = N'" & FormatSQL(z4001.cdSite) & "', " 
    SQL = SQL & "    K4001_seDepartment      = N'" & FormatSQL(z4001.seDepartment) & "', " 
    SQL = SQL & "    K4001_cdDepartment      = N'" & FormatSQL(z4001.cdDepartment) & "', " 
    SQL = SQL & "    K4001_WorkOrderStatus      = N'" & FormatSQL(z4001.WorkOrderStatus) & "', " 
    SQL = SQL & "    K4001_DateApproval      = N'" & FormatSQL(z4001.DateApproval) & "', " 
    SQL = SQL & "    K4001_DateCancel      = N'" & FormatSQL(z4001.DateCancel) & "', " 
    SQL = SQL & "    K4001_DateComplete      = N'" & FormatSQL(z4001.DateComplete) & "', " 
    SQL = SQL & "    K4001_DatePending      = N'" & FormatSQL(z4001.DatePending) & "', " 
    SQL = SQL & "    K4001_DateWorkOrder      = N'" & FormatSQL(z4001.DateWorkOrder) & "', " 
    SQL = SQL & "    K4001_DateTransfer      = N'" & FormatSQL(z4001.DateTransfer) & "', " 
    SQL = SQL & "    K4001_QtyOrder      =  " & FormatSQL(z4001.QtyOrder) & ", " 
    SQL = SQL & "    K4001_DateInsert      = N'" & FormatSQL(z4001.DateInsert) & "', " 
    SQL = SQL & "    K4001_InchargeInsert      = N'" & FormatSQL(z4001.InchargeInsert) & "', " 
    SQL = SQL & "    K4001_DateUpdate      = N'" & FormatSQL(z4001.DateUpdate) & "', " 
    SQL = SQL & "    K4001_InchargeUpdate      = N'" & FormatSQL(z4001.InchargeUpdate) & "', " 
    SQL = SQL & "    K4001_InchargeSales      = N'" & FormatSQL(z4001.InchargeSales) & "', " 
    SQL = SQL & "    K4001_InchargePPC      = N'" & FormatSQL(z4001.InchargePPC) & "', " 
    SQL = SQL & "    K4001_RemarkOrder      = N'" & FormatSQL(z4001.RemarkOrder) & "', " 
    SQL = SQL & "    K4001_RemarkCustomer      = N'" & FormatSQL(z4001.RemarkCustomer) & "', " 
    SQL = SQL & "    K4001_RemarkOther      = N'" & FormatSQL(z4001.RemarkOther) & "'  " 
    SQL = SQL & " WHERE K4001_WorkOrder		 = '" & z4001.WorkOrder & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    REWRITE_PFK4001 = True

    Exit Function
Catch ex As Exception
 	Call MsgBoxP("REWRITE_PFK4001",vbCritical)
  End Try
End Function

'=========================================================================================================================================================
' DATA DELETE 
'=========================================================================================================================================================
Public Function DELETE_PFK4001(z4001 As T4001_AREA) As Boolean
    DELETE_PFK4001 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try      
    SQL = " DELETE FROM PFK4001 "
    SQL = SQL & " WHERE K4001_WorkOrder		 = '" & z4001.WorkOrder & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    cmd.ExecuteNonQuery()  
  
    DELETE_PFK4001 = True
    Exit Function
Catch ex As Exception
 	Call MsgBoxP("DELETE_PFK4001",vbCritical)
End Try
End Function

'=========================================================================================================================================================
' CLEAR 
'=========================================================================================================================================================
Public Sub D4001_CLEAR()
Try
    
   D4001.WorkOrder = ""
   D4001.WorkOrderName = ""
   D4001.seSite = ""
   D4001.cdSite = ""
   D4001.seDepartment = ""
   D4001.cdDepartment = ""
   D4001.WorkOrderStatus = ""
   D4001.DateApproval = ""
   D4001.DateCancel = ""
   D4001.DateComplete = ""
   D4001.DatePending = ""
   D4001.DateWorkOrder = ""
   D4001.DateTransfer = ""
    D4001.QtyOrder = 0 
   D4001.DateInsert = ""
   D4001.InchargeInsert = ""
   D4001.DateUpdate = ""
   D4001.InchargeUpdate = ""
   D4001.InchargeSales = ""
   D4001.InchargePPC = ""
   D4001.RemarkOrder = ""
   D4001.RemarkCustomer = ""
   D4001.RemarkOther = ""

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("D4001_CLEAR",vbCritical)
End Try
End Sub

'=========================================================================================================================================================
' NULL ZERO
'=========================================================================================================================================================
Private Sub NULL_ZERO(Byref x4001 As T4001_AREA)
Try
    
    x4001.WorkOrder = trim$(  x4001.WorkOrder)
    x4001.WorkOrderName = trim$(  x4001.WorkOrderName)
    x4001.seSite = trim$(  x4001.seSite)
    x4001.cdSite = trim$(  x4001.cdSite)
    x4001.seDepartment = trim$(  x4001.seDepartment)
    x4001.cdDepartment = trim$(  x4001.cdDepartment)
    x4001.WorkOrderStatus = trim$(  x4001.WorkOrderStatus)
    x4001.DateApproval = trim$(  x4001.DateApproval)
    x4001.DateCancel = trim$(  x4001.DateCancel)
    x4001.DateComplete = trim$(  x4001.DateComplete)
    x4001.DatePending = trim$(  x4001.DatePending)
    x4001.DateWorkOrder = trim$(  x4001.DateWorkOrder)
    x4001.DateTransfer = trim$(  x4001.DateTransfer)
    x4001.QtyOrder = trim$(  x4001.QtyOrder)
    x4001.DateInsert = trim$(  x4001.DateInsert)
    x4001.InchargeInsert = trim$(  x4001.InchargeInsert)
    x4001.DateUpdate = trim$(  x4001.DateUpdate)
    x4001.InchargeUpdate = trim$(  x4001.InchargeUpdate)
    x4001.InchargeSales = trim$(  x4001.InchargeSales)
    x4001.InchargePPC = trim$(  x4001.InchargePPC)
    x4001.RemarkOrder = trim$(  x4001.RemarkOrder)
    x4001.RemarkCustomer = trim$(  x4001.RemarkCustomer)
    x4001.RemarkOther = trim$(  x4001.RemarkOther)
     
    If trim$( x4001.WorkOrder ) = "" Then x4001.WorkOrder = Space(1) 
    If trim$( x4001.WorkOrderName ) = "" Then x4001.WorkOrderName = Space(1) 
    If trim$( x4001.seSite ) = "" Then x4001.seSite = Space(1) 
    If trim$( x4001.cdSite ) = "" Then x4001.cdSite = Space(1) 
    If trim$( x4001.seDepartment ) = "" Then x4001.seDepartment = Space(1) 
    If trim$( x4001.cdDepartment ) = "" Then x4001.cdDepartment = Space(1) 
    If trim$( x4001.WorkOrderStatus ) = "" Then x4001.WorkOrderStatus = Space(1) 
    If trim$( x4001.DateApproval ) = "" Then x4001.DateApproval = Space(1) 
    If trim$( x4001.DateCancel ) = "" Then x4001.DateCancel = Space(1) 
    If trim$( x4001.DateComplete ) = "" Then x4001.DateComplete = Space(1) 
    If trim$( x4001.DatePending ) = "" Then x4001.DatePending = Space(1) 
    If trim$( x4001.DateWorkOrder ) = "" Then x4001.DateWorkOrder = Space(1) 
    If trim$( x4001.DateTransfer ) = "" Then x4001.DateTransfer = Space(1) 
    If trim$( x4001.QtyOrder ) = "" Then x4001.QtyOrder = 0 
    If trim$( x4001.DateInsert ) = "" Then x4001.DateInsert = Space(1) 
    If trim$( x4001.InchargeInsert ) = "" Then x4001.InchargeInsert = Space(1) 
    If trim$( x4001.DateUpdate ) = "" Then x4001.DateUpdate = Space(1) 
    If trim$( x4001.InchargeUpdate ) = "" Then x4001.InchargeUpdate = Space(1) 
    If trim$( x4001.InchargeSales ) = "" Then x4001.InchargeSales = Space(1) 
    If trim$( x4001.InchargePPC ) = "" Then x4001.InchargePPC = Space(1) 
    If trim$( x4001.RemarkOrder ) = "" Then x4001.RemarkOrder = Space(1) 
    If trim$( x4001.RemarkCustomer ) = "" Then x4001.RemarkCustomer = Space(1) 
    If trim$( x4001.RemarkOther ) = "" Then x4001.RemarkOther = Space(1) 


    Exit Sub
Catch ex As Exception
   Call MsgBoxP("NULL_ZERO",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE DATAREADER
'=========================================================================================================================================================
Public Sub K4001_MOVE(rs4001 As SqlClient.SqlDataReader)
Try

    call D4001_CLEAR()   

    If IsdbNull(rs4001!K4001_WorkOrder) = False Then D4001.WorkOrder = Trim$(rs4001!K4001_WorkOrder)
    If IsdbNull(rs4001!K4001_WorkOrderName) = False Then D4001.WorkOrderName = Trim$(rs4001!K4001_WorkOrderName)
    If IsdbNull(rs4001!K4001_seSite) = False Then D4001.seSite = Trim$(rs4001!K4001_seSite)
    If IsdbNull(rs4001!K4001_cdSite) = False Then D4001.cdSite = Trim$(rs4001!K4001_cdSite)
    If IsdbNull(rs4001!K4001_seDepartment) = False Then D4001.seDepartment = Trim$(rs4001!K4001_seDepartment)
    If IsdbNull(rs4001!K4001_cdDepartment) = False Then D4001.cdDepartment = Trim$(rs4001!K4001_cdDepartment)
    If IsdbNull(rs4001!K4001_WorkOrderStatus) = False Then D4001.WorkOrderStatus = Trim$(rs4001!K4001_WorkOrderStatus)
    If IsdbNull(rs4001!K4001_DateApproval) = False Then D4001.DateApproval = Trim$(rs4001!K4001_DateApproval)
    If IsdbNull(rs4001!K4001_DateCancel) = False Then D4001.DateCancel = Trim$(rs4001!K4001_DateCancel)
    If IsdbNull(rs4001!K4001_DateComplete) = False Then D4001.DateComplete = Trim$(rs4001!K4001_DateComplete)
    If IsdbNull(rs4001!K4001_DatePending) = False Then D4001.DatePending = Trim$(rs4001!K4001_DatePending)
    If IsdbNull(rs4001!K4001_DateWorkOrder) = False Then D4001.DateWorkOrder = Trim$(rs4001!K4001_DateWorkOrder)
    If IsdbNull(rs4001!K4001_DateTransfer) = False Then D4001.DateTransfer = Trim$(rs4001!K4001_DateTransfer)
    If IsdbNull(rs4001!K4001_QtyOrder) = False Then D4001.QtyOrder = Trim$(rs4001!K4001_QtyOrder)
    If IsdbNull(rs4001!K4001_DateInsert) = False Then D4001.DateInsert = Trim$(rs4001!K4001_DateInsert)
    If IsdbNull(rs4001!K4001_InchargeInsert) = False Then D4001.InchargeInsert = Trim$(rs4001!K4001_InchargeInsert)
    If IsdbNull(rs4001!K4001_DateUpdate) = False Then D4001.DateUpdate = Trim$(rs4001!K4001_DateUpdate)
    If IsdbNull(rs4001!K4001_InchargeUpdate) = False Then D4001.InchargeUpdate = Trim$(rs4001!K4001_InchargeUpdate)
    If IsdbNull(rs4001!K4001_InchargeSales) = False Then D4001.InchargeSales = Trim$(rs4001!K4001_InchargeSales)
    If IsdbNull(rs4001!K4001_InchargePPC) = False Then D4001.InchargePPC = Trim$(rs4001!K4001_InchargePPC)
    If IsdbNull(rs4001!K4001_RemarkOrder) = False Then D4001.RemarkOrder = Trim$(rs4001!K4001_RemarkOrder)
    If IsdbNull(rs4001!K4001_RemarkCustomer) = False Then D4001.RemarkCustomer = Trim$(rs4001!K4001_RemarkCustomer)
    If IsdbNull(rs4001!K4001_RemarkOther) = False Then D4001.RemarkOther = Trim$(rs4001!K4001_RemarkOther)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4001_MOVE",vbCritical)
End try
End Sub
'=========================================================================================================================================================
' DATA MOVE DATAROW
'=========================================================================================================================================================
Public Sub K4001_MOVE(rs4001 As DataRow)
Try

    call D4001_CLEAR()   

    If IsdbNull(rs4001!K4001_WorkOrder) = False Then D4001.WorkOrder = Trim$(rs4001!K4001_WorkOrder)
    If IsdbNull(rs4001!K4001_WorkOrderName) = False Then D4001.WorkOrderName = Trim$(rs4001!K4001_WorkOrderName)
    If IsdbNull(rs4001!K4001_seSite) = False Then D4001.seSite = Trim$(rs4001!K4001_seSite)
    If IsdbNull(rs4001!K4001_cdSite) = False Then D4001.cdSite = Trim$(rs4001!K4001_cdSite)
    If IsdbNull(rs4001!K4001_seDepartment) = False Then D4001.seDepartment = Trim$(rs4001!K4001_seDepartment)
    If IsdbNull(rs4001!K4001_cdDepartment) = False Then D4001.cdDepartment = Trim$(rs4001!K4001_cdDepartment)
    If IsdbNull(rs4001!K4001_WorkOrderStatus) = False Then D4001.WorkOrderStatus = Trim$(rs4001!K4001_WorkOrderStatus)
    If IsdbNull(rs4001!K4001_DateApproval) = False Then D4001.DateApproval = Trim$(rs4001!K4001_DateApproval)
    If IsdbNull(rs4001!K4001_DateCancel) = False Then D4001.DateCancel = Trim$(rs4001!K4001_DateCancel)
    If IsdbNull(rs4001!K4001_DateComplete) = False Then D4001.DateComplete = Trim$(rs4001!K4001_DateComplete)
    If IsdbNull(rs4001!K4001_DatePending) = False Then D4001.DatePending = Trim$(rs4001!K4001_DatePending)
    If IsdbNull(rs4001!K4001_DateWorkOrder) = False Then D4001.DateWorkOrder = Trim$(rs4001!K4001_DateWorkOrder)
    If IsdbNull(rs4001!K4001_DateTransfer) = False Then D4001.DateTransfer = Trim$(rs4001!K4001_DateTransfer)
    If IsdbNull(rs4001!K4001_QtyOrder) = False Then D4001.QtyOrder = Trim$(rs4001!K4001_QtyOrder)
    If IsdbNull(rs4001!K4001_DateInsert) = False Then D4001.DateInsert = Trim$(rs4001!K4001_DateInsert)
    If IsdbNull(rs4001!K4001_InchargeInsert) = False Then D4001.InchargeInsert = Trim$(rs4001!K4001_InchargeInsert)
    If IsdbNull(rs4001!K4001_DateUpdate) = False Then D4001.DateUpdate = Trim$(rs4001!K4001_DateUpdate)
    If IsdbNull(rs4001!K4001_InchargeUpdate) = False Then D4001.InchargeUpdate = Trim$(rs4001!K4001_InchargeUpdate)
    If IsdbNull(rs4001!K4001_InchargeSales) = False Then D4001.InchargeSales = Trim$(rs4001!K4001_InchargeSales)
    If IsdbNull(rs4001!K4001_InchargePPC) = False Then D4001.InchargePPC = Trim$(rs4001!K4001_InchargePPC)
    If IsdbNull(rs4001!K4001_RemarkOrder) = False Then D4001.RemarkOrder = Trim$(rs4001!K4001_RemarkOrder)
    If IsdbNull(rs4001!K4001_RemarkCustomer) = False Then D4001.RemarkCustomer = Trim$(rs4001!K4001_RemarkCustomer)
    If IsdbNull(rs4001!K4001_RemarkOther) = False Then D4001.RemarkOther = Trim$(rs4001!K4001_RemarkOther)

    
    Exit Sub
Catch ex As Exception
    Call MsgBoxP("K4001_MOVE",vbCritical)
End try
End Sub

'=========================================================================================================================================================
' DATA MOVE SPREAD
'=========================================================================================================================================================
Public Function K4001_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4001 As T4001_AREA, WORKORDER AS String) as Boolean

K4001_MOVE = False

Try
    If READ_PFK4001(WORKORDER) = True Then
                z4001 = D4001
		K4001_MOVE = True
		else
	z4001 = nothing
     End If

     If  getColumIndex(spr,"WorkOrder") > -1 then z4001.WorkOrder = getDataM(spr, getColumIndex(spr,"WorkOrder"), xRow)
     If  getColumIndex(spr,"WorkOrderName") > -1 then z4001.WorkOrderName = getDataM(spr, getColumIndex(spr,"WorkOrderName"), xRow)
     If  getColumIndex(spr,"seSite") > -1 then z4001.seSite = getDataM(spr, getColumIndex(spr,"seSite"), xRow)
     If  getColumIndex(spr,"cdSite") > -1 then z4001.cdSite = getDataM(spr, getColumIndex(spr,"cdSite"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z4001.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z4001.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"WorkOrderStatus") > -1 then z4001.WorkOrderStatus = getDataM(spr, getColumIndex(spr,"WorkOrderStatus"), xRow)
     If  getColumIndex(spr,"DateApproval") > -1 then z4001.DateApproval = getDataM(spr, getColumIndex(spr,"DateApproval"), xRow)
     If  getColumIndex(spr,"DateCancel") > -1 then z4001.DateCancel = getDataM(spr, getColumIndex(spr,"DateCancel"), xRow)
     If  getColumIndex(spr,"DateComplete") > -1 then z4001.DateComplete = getDataM(spr, getColumIndex(spr,"DateComplete"), xRow)
     If  getColumIndex(spr,"DatePending") > -1 then z4001.DatePending = getDataM(spr, getColumIndex(spr,"DatePending"), xRow)
     If  getColumIndex(spr,"DateWorkOrder") > -1 then z4001.DateWorkOrder = getDataM(spr, getColumIndex(spr,"DateWorkOrder"), xRow)
     If  getColumIndex(spr,"DateTransfer") > -1 then z4001.DateTransfer = getDataM(spr, getColumIndex(spr,"DateTransfer"), xRow)
     If  getColumIndex(spr,"QtyOrder") > -1 then z4001.QtyOrder = getDataM(spr, getColumIndex(spr,"QtyOrder"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z4001.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z4001.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z4001.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z4001.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"InchargeSales") > -1 then z4001.InchargeSales = getDataM(spr, getColumIndex(spr,"InchargeSales"), xRow)
     If  getColumIndex(spr,"InchargePPC") > -1 then z4001.InchargePPC = getDataM(spr, getColumIndex(spr,"InchargePPC"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z4001.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)
     If  getColumIndex(spr,"RemarkCustomer") > -1 then z4001.RemarkCustomer = getDataM(spr, getColumIndex(spr,"RemarkCustomer"), xRow)
     If  getColumIndex(spr,"RemarkOther") > -1 then z4001.RemarkOther = getDataM(spr, getColumIndex(spr,"RemarkOther"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4001_MOVE",vbCritical)
End try
End Function 


'=========================================================================================================================================================
' DATA MOVE SPREAD NEW
'=========================================================================================================================================================
Public Function K4001_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer,ByRef z4001 As T4001_AREA,CheckClear as Boolean,WORKORDER AS String) as Boolean

K4001_MOVE = False

Try
    If READ_PFK4001(WORKORDER) = True Then
                z4001 = D4001
		K4001_MOVE = True
		else
	If CheckClear  = True then z4001 = nothing
     End If

     If  getColumIndex(spr,"WorkOrder") > -1 then z4001.WorkOrder = getDataM(spr, getColumIndex(spr,"WorkOrder"), xRow)
     If  getColumIndex(spr,"WorkOrderName") > -1 then z4001.WorkOrderName = getDataM(spr, getColumIndex(spr,"WorkOrderName"), xRow)
     If  getColumIndex(spr,"seSite") > -1 then z4001.seSite = getDataM(spr, getColumIndex(spr,"seSite"), xRow)
     If  getColumIndex(spr,"cdSite") > -1 then z4001.cdSite = getDataM(spr, getColumIndex(spr,"cdSite"), xRow)
     If  getColumIndex(spr,"seDepartment") > -1 then z4001.seDepartment = getDataM(spr, getColumIndex(spr,"seDepartment"), xRow)
     If  getColumIndex(spr,"cdDepartment") > -1 then z4001.cdDepartment = getDataM(spr, getColumIndex(spr,"cdDepartment"), xRow)
     If  getColumIndex(spr,"WorkOrderStatus") > -1 then z4001.WorkOrderStatus = getDataM(spr, getColumIndex(spr,"WorkOrderStatus"), xRow)
     If  getColumIndex(spr,"DateApproval") > -1 then z4001.DateApproval = getDataM(spr, getColumIndex(spr,"DateApproval"), xRow)
     If  getColumIndex(spr,"DateCancel") > -1 then z4001.DateCancel = getDataM(spr, getColumIndex(spr,"DateCancel"), xRow)
     If  getColumIndex(spr,"DateComplete") > -1 then z4001.DateComplete = getDataM(spr, getColumIndex(spr,"DateComplete"), xRow)
     If  getColumIndex(spr,"DatePending") > -1 then z4001.DatePending = getDataM(spr, getColumIndex(spr,"DatePending"), xRow)
     If  getColumIndex(spr,"DateWorkOrder") > -1 then z4001.DateWorkOrder = getDataM(spr, getColumIndex(spr,"DateWorkOrder"), xRow)
     If  getColumIndex(spr,"DateTransfer") > -1 then z4001.DateTransfer = getDataM(spr, getColumIndex(spr,"DateTransfer"), xRow)
     If  getColumIndex(spr,"QtyOrder") > -1 then z4001.QtyOrder = getDataM(spr, getColumIndex(spr,"QtyOrder"), xRow)
     If  getColumIndex(spr,"DateInsert") > -1 then z4001.DateInsert = getDataM(spr, getColumIndex(spr,"DateInsert"), xRow)
     If  getColumIndex(spr,"InchargeInsert") > -1 then z4001.InchargeInsert = getDataM(spr, getColumIndex(spr,"InchargeInsert"), xRow)
     If  getColumIndex(spr,"DateUpdate") > -1 then z4001.DateUpdate = getDataM(spr, getColumIndex(spr,"DateUpdate"), xRow)
     If  getColumIndex(spr,"InchargeUpdate") > -1 then z4001.InchargeUpdate = getDataM(spr, getColumIndex(spr,"InchargeUpdate"), xRow)
     If  getColumIndex(spr,"InchargeSales") > -1 then z4001.InchargeSales = getDataM(spr, getColumIndex(spr,"InchargeSales"), xRow)
     If  getColumIndex(spr,"InchargePPC") > -1 then z4001.InchargePPC = getDataM(spr, getColumIndex(spr,"InchargePPC"), xRow)
     If  getColumIndex(spr,"RemarkOrder") > -1 then z4001.RemarkOrder = getDataM(spr, getColumIndex(spr,"RemarkOrder"), xRow)
     If  getColumIndex(spr,"RemarkCustomer") > -1 then z4001.RemarkCustomer = getDataM(spr, getColumIndex(spr,"RemarkCustomer"), xRow)
     If  getColumIndex(spr,"RemarkOther") > -1 then z4001.RemarkOther = getDataM(spr, getColumIndex(spr,"RemarkOther"), xRow)

    
    Exit Function 
Catch ex As Exception
     Call MsgBoxP("K4001_MOVE",vbCritical)
End try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM
'=========================================================================================================================================================
Public Function K4001_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4001 As T4001_AREA, Job as String, WORKORDER AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4001_MOVE = False

Try
    If READ_PFK4001(WORKORDER) = True Then
                z4001 = D4001
		K4001_MOVE = True
		else
	z4001 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4001")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
		temp1 = temp1.ToUpper
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "WORKORDER":z4001.WorkOrder = Children(i).Code
   Case "WORKORDERNAME":z4001.WorkOrderName = Children(i).Code
   Case "SESITE":z4001.seSite = Children(i).Code
   Case "CDSITE":z4001.cdSite = Children(i).Code
   Case "SEDEPARTMENT":z4001.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z4001.cdDepartment = Children(i).Code
   Case "WORKORDERSTATUS":z4001.WorkOrderStatus = Children(i).Code
   Case "DATEAPPROVAL":z4001.DateApproval = Children(i).Code
   Case "DATECANCEL":z4001.DateCancel = Children(i).Code
   Case "DATECOMPLETE":z4001.DateComplete = Children(i).Code
   Case "DATEPENDING":z4001.DatePending = Children(i).Code
   Case "DATEWORKORDER":z4001.DateWorkOrder = Children(i).Code
   Case "DATETRANSFER":z4001.DateTransfer = Children(i).Code
   Case "QTYORDER":z4001.QtyOrder = Children(i).Code
   Case "DATEINSERT":z4001.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z4001.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z4001.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z4001.InchargeUpdate = Children(i).Code
   Case "INCHARGESALES":z4001.InchargeSales = Children(i).Code
   Case "INCHARGEPPC":z4001.InchargePPC = Children(i).Code
   Case "REMARKORDER":z4001.RemarkOrder = Children(i).Code
   Case "REMARKCUSTOMER":z4001.RemarkCustomer = Children(i).Code
   Case "REMARKOTHER":z4001.RemarkOther = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "WORKORDER":z4001.WorkOrder = Children(i).Data
   Case "WORKORDERNAME":z4001.WorkOrderName = Children(i).Data
   Case "SESITE":z4001.seSite = Children(i).Data
   Case "CDSITE":z4001.cdSite = Children(i).Data
   Case "SEDEPARTMENT":z4001.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z4001.cdDepartment = Children(i).Data
   Case "WORKORDERSTATUS":z4001.WorkOrderStatus = Children(i).Data
   Case "DATEAPPROVAL":z4001.DateApproval = Children(i).Data
   Case "DATECANCEL":z4001.DateCancel = Children(i).Data
   Case "DATECOMPLETE":z4001.DateComplete = Children(i).Data
   Case "DATEPENDING":z4001.DatePending = Children(i).Data
   Case "DATEWORKORDER":z4001.DateWorkOrder = Children(i).Data
   Case "DATETRANSFER":z4001.DateTransfer = Children(i).Data
   Case "QTYORDER":z4001.QtyOrder = Children(i).Data
   Case "DATEINSERT":z4001.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z4001.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z4001.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z4001.InchargeUpdate = Children(i).Data
   Case "INCHARGESALES":z4001.InchargeSales = Children(i).Data
   Case "INCHARGEPPC":z4001.InchargePPC = Children(i).Data
   Case "REMARKORDER":z4001.RemarkOrder = Children(i).Data
   Case "REMARKCUSTOMER":z4001.RemarkCustomer = Children(i).Data
   Case "REMARKOTHER":z4001.RemarkOther = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4001_MOVE",vbCritical)
End Try
End Function 

'=========================================================================================================================================================
' DATA MOVE FORM NEW
'=========================================================================================================================================================
Public Function K4001_MOVE(ByRef StartingContainer As System.Windows.Forms.Control,ByRef z4001 As T4001_AREA, Job as String, CheckClear as Boolean, WORKORDER AS String) as Boolean
Dim temp1 As String
Dim i As Integer
Dim Children As New List(Of Object)
Dim newds As New DataSet

K4001_MOVE = False

Try
    If READ_PFK4001(WORKORDER) = True Then
                z4001 = D4001
		K4001_MOVE = True
		else
	If CheckClear  = True then z4001 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK4001")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "WORKORDER":z4001.WorkOrder = Children(i).Code
   Case "WORKORDERNAME":z4001.WorkOrderName = Children(i).Code
   Case "SESITE":z4001.seSite = Children(i).Code
   Case "CDSITE":z4001.cdSite = Children(i).Code
   Case "SEDEPARTMENT":z4001.seDepartment = Children(i).Code
   Case "CDDEPARTMENT":z4001.cdDepartment = Children(i).Code
   Case "WORKORDERSTATUS":z4001.WorkOrderStatus = Children(i).Code
   Case "DATEAPPROVAL":z4001.DateApproval = Children(i).Code
   Case "DATECANCEL":z4001.DateCancel = Children(i).Code
   Case "DATECOMPLETE":z4001.DateComplete = Children(i).Code
   Case "DATEPENDING":z4001.DatePending = Children(i).Code
   Case "DATEWORKORDER":z4001.DateWorkOrder = Children(i).Code
   Case "DATETRANSFER":z4001.DateTransfer = Children(i).Code
   Case "QTYORDER":z4001.QtyOrder = Children(i).Code
   Case "DATEINSERT":z4001.DateInsert = Children(i).Code
   Case "INCHARGEINSERT":z4001.InchargeInsert = Children(i).Code
   Case "DATEUPDATE":z4001.DateUpdate = Children(i).Code
   Case "INCHARGEUPDATE":z4001.InchargeUpdate = Children(i).Code
   Case "INCHARGESALES":z4001.InchargeSales = Children(i).Code
   Case "INCHARGEPPC":z4001.InchargePPC = Children(i).Code
   Case "REMARKORDER":z4001.RemarkOrder = Children(i).Code
   Case "REMARKCUSTOMER":z4001.RemarkCustomer = Children(i).Code
   Case "REMARKOTHER":z4001.RemarkOther = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "WORKORDER":z4001.WorkOrder = Children(i).Data
   Case "WORKORDERNAME":z4001.WorkOrderName = Children(i).Data
   Case "SESITE":z4001.seSite = Children(i).Data
   Case "CDSITE":z4001.cdSite = Children(i).Data
   Case "SEDEPARTMENT":z4001.seDepartment = Children(i).Data
   Case "CDDEPARTMENT":z4001.cdDepartment = Children(i).Data
   Case "WORKORDERSTATUS":z4001.WorkOrderStatus = Children(i).Data
   Case "DATEAPPROVAL":z4001.DateApproval = Children(i).Data
   Case "DATECANCEL":z4001.DateCancel = Children(i).Data
   Case "DATECOMPLETE":z4001.DateComplete = Children(i).Data
   Case "DATEPENDING":z4001.DatePending = Children(i).Data
   Case "DATEWORKORDER":z4001.DateWorkOrder = Children(i).Data
   Case "DATETRANSFER":z4001.DateTransfer = Children(i).Data
   Case "QTYORDER":z4001.QtyOrder = Children(i).Data
   Case "DATEINSERT":z4001.DateInsert = Children(i).Data
   Case "INCHARGEINSERT":z4001.InchargeInsert = Children(i).Data
   Case "DATEUPDATE":z4001.DateUpdate = Children(i).Data
   Case "INCHARGEUPDATE":z4001.InchargeUpdate = Children(i).Data
   Case "INCHARGESALES":z4001.InchargeSales = Children(i).Data
   Case "INCHARGEPPC":z4001.InchargePPC = Children(i).Data
   Case "REMARKORDER":z4001.RemarkOrder = Children(i).Data
   Case "REMARKCUSTOMER":z4001.RemarkCustomer = Children(i).Data
   Case "REMARKOTHER":z4001.RemarkOther = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K4001_MOVE",vbCritical)
End Try
End Function 
    
End Module 
