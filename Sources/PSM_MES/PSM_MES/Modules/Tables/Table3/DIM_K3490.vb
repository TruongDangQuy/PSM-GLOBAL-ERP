'=========================================================================================================================================================
'   TABLE : (PFK3490)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3490

    Structure T3490_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public WIPNo As String  '			nvarchar(20)		*
        Public TransferType As String  '			char(1)
        Public DateWIP As String  '			char(8)
        Public WIPNoMaster As String  '			nvarchar(20)
        Public ContainerNo As String  '			nvarchar(50)
        Public CustomerCode As String  '			char(6)
        Public DateETA As String  '			char(8)
        Public DateETD As String  '			char(8)
        Public DateFlight As String  '			char(8)
        Public DateBooking As String  '			char(8)
        Public BookingNo As String  '			nvarchar(50)
        Public CheckMarketType As String  '			char(1)
        Public seDepartment As String  '			char(3)
        Public cdDepartment As String  '			char(3)
        Public InchargeWIP As String  '			char(8)
        Public seUnitPrice As String  '			char(3)
        Public cdUnitPrice As String  '			char(3)
        Public CustomerName As String  '			nvarchar(100)
        Public DestinationID As String  '			nvarchar(20)
        Public Remarks As String  '			nvarchar(100)
        Public seSite As String  '			char(3)
        Public cdSite As String  '			char(3)
        Public ShipFrom As String  '			nvarchar(100)
        Public ShipTo As String  '			nvarchar(100)
        Public ShipMark As String  '			nvarchar(100)
        Public Shipper As String  '			nvarchar(100)
        Public sePaymentDay As String  '			char(3)
        Public cdPaymentDay As String  '			char(3)
        Public VisAllName As String  '			nvarchar(100)
        Public VisAllNo As String  '			nvarchar(100)
        Public Buyer As String  '			nvarchar(100)
        Public FlightNo As String  '			nvarchar(100)
        Public HAWB As String  '			nvarchar(100)
        Public Status As String  '			char(1)
        Public DateInsert As String  '			char(8)
        Public DateUpdate As String  '			char(8)
        Public InchargeInsert As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        Public TimeInsert As String  '			char(14)
        Public TimeUpdate As String  '			char(14)
        '=========================================================================================================================================================
    End Structure

    Public D3490 As T3490_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK3490(WIPNO As String) As Boolean
        READ_PFK3490 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3490 "
            SQL = SQL & " WHERE K3490_WIPNo		 = '" & WIPNo & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3490_CLEAR() : GoTo SKIP_READ_PFK3490

            Call K3490_MOVE(rd)
            READ_PFK3490 = True

SKIP_READ_PFK3490:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3490", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK3490(WIPNO As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3490 "
            SQL = SQL & " WHERE K3490_WIPNo		 = '" & WIPNo & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK3490", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK3490(z3490 As T3490_AREA) As Boolean
        WRITE_PFK3490 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3490)

            SQL = " INSERT INTO PFK3490 "
            SQL = SQL & " ( "
            SQL = SQL & " K3490_WIPNo,"
            SQL = SQL & " K3490_TransferType,"
            SQL = SQL & " K3490_DateWIP,"
            SQL = SQL & " K3490_WIPNoMaster,"
            SQL = SQL & " K3490_ContainerNo,"
            SQL = SQL & " K3490_CustomerCode,"
            SQL = SQL & " K3490_DateETA,"
            SQL = SQL & " K3490_DateETD,"
            SQL = SQL & " K3490_DateFlight,"
            SQL = SQL & " K3490_DateBooking,"
            SQL = SQL & " K3490_BookingNo,"
            SQL = SQL & " K3490_CheckMarketType,"
            SQL = SQL & " K3490_seDepartment,"
            SQL = SQL & " K3490_cdDepartment,"
            SQL = SQL & " K3490_InchargeWIP,"
            SQL = SQL & " K3490_seUnitPrice,"
            SQL = SQL & " K3490_cdUnitPrice,"
            SQL = SQL & " K3490_CustomerName,"
            SQL = SQL & " K3490_DestinationID,"
            SQL = SQL & " K3490_Remarks,"
            SQL = SQL & " K3490_seSite,"
            SQL = SQL & " K3490_cdSite,"
            SQL = SQL & " K3490_ShipFrom,"
            SQL = SQL & " K3490_ShipTo,"
            SQL = SQL & " K3490_ShipMark,"
            SQL = SQL & " K3490_Shipper,"
            SQL = SQL & " K3490_sePaymentDay,"
            SQL = SQL & " K3490_cdPaymentDay,"
            SQL = SQL & " K3490_VisAllName,"
            SQL = SQL & " K3490_VisAllNo,"
            SQL = SQL & " K3490_Buyer,"
            SQL = SQL & " K3490_FlightNo,"
            SQL = SQL & " K3490_HAWB,"
            SQL = SQL & " K3490_Status,"
            SQL = SQL & " K3490_DateInsert,"
            SQL = SQL & " K3490_DateUpdate,"
            SQL = SQL & " K3490_InchargeInsert,"
            SQL = SQL & " K3490_InchargeUpdate,"
            SQL = SQL & " K3490_TimeInsert,"
            SQL = SQL & " K3490_TimeUpdate "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z3490.WIPNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.TransferType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.DateWIP) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.WIPNoMaster) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.ContainerNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.CustomerCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.DateETA) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.DateETD) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.DateFlight) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.DateBooking) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.BookingNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.CheckMarketType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.seDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.cdDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.InchargeWIP) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.seUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.cdUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.CustomerName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.DestinationID) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.Remarks) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.seSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.cdSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.ShipFrom) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.ShipTo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.ShipMark) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.Shipper) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.sePaymentDay) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.cdPaymentDay) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.VisAllName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.VisAllNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.Buyer) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.FlightNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.HAWB) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.Status) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.DateInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.InchargeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.TimeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3490.TimeUpdate) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK3490 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK3490", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK3490(z3490 As T3490_AREA) As Boolean
        REWRITE_PFK3490 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3490)

            SQL = " UPDATE PFK3490 SET "
            SQL = SQL & "    K3490_TransferType      = N'" & FormatSQL(z3490.TransferType) & "', "
            SQL = SQL & "    K3490_DateWIP      = N'" & FormatSQL(z3490.DateWIP) & "', "
            SQL = SQL & "    K3490_WIPNoMaster      = N'" & FormatSQL(z3490.WIPNoMaster) & "', "
            SQL = SQL & "    K3490_ContainerNo      = N'" & FormatSQL(z3490.ContainerNo) & "', "
            SQL = SQL & "    K3490_CustomerCode      = N'" & FormatSQL(z3490.CustomerCode) & "', "
            SQL = SQL & "    K3490_DateETA      = N'" & FormatSQL(z3490.DateETA) & "', "
            SQL = SQL & "    K3490_DateETD      = N'" & FormatSQL(z3490.DateETD) & "', "
            SQL = SQL & "    K3490_DateFlight      = N'" & FormatSQL(z3490.DateFlight) & "', "
            SQL = SQL & "    K3490_DateBooking      = N'" & FormatSQL(z3490.DateBooking) & "', "
            SQL = SQL & "    K3490_BookingNo      = N'" & FormatSQL(z3490.BookingNo) & "', "
            SQL = SQL & "    K3490_CheckMarketType      = N'" & FormatSQL(z3490.CheckMarketType) & "', "
            SQL = SQL & "    K3490_seDepartment      = N'" & FormatSQL(z3490.seDepartment) & "', "
            SQL = SQL & "    K3490_cdDepartment      = N'" & FormatSQL(z3490.cdDepartment) & "', "
            SQL = SQL & "    K3490_InchargeWIP      = N'" & FormatSQL(z3490.InchargeWIP) & "', "
            SQL = SQL & "    K3490_seUnitPrice      = N'" & FormatSQL(z3490.seUnitPrice) & "', "
            SQL = SQL & "    K3490_cdUnitPrice      = N'" & FormatSQL(z3490.cdUnitPrice) & "', "
            SQL = SQL & "    K3490_CustomerName      = N'" & FormatSQL(z3490.CustomerName) & "', "
            SQL = SQL & "    K3490_DestinationID      = N'" & FormatSQL(z3490.DestinationID) & "', "
            SQL = SQL & "    K3490_Remarks      = N'" & FormatSQL(z3490.Remarks) & "', "
            SQL = SQL & "    K3490_seSite      = N'" & FormatSQL(z3490.seSite) & "', "
            SQL = SQL & "    K3490_cdSite      = N'" & FormatSQL(z3490.cdSite) & "', "
            SQL = SQL & "    K3490_ShipFrom      = N'" & FormatSQL(z3490.ShipFrom) & "', "
            SQL = SQL & "    K3490_ShipTo      = N'" & FormatSQL(z3490.ShipTo) & "', "
            SQL = SQL & "    K3490_ShipMark      = N'" & FormatSQL(z3490.ShipMark) & "', "
            SQL = SQL & "    K3490_Shipper      = N'" & FormatSQL(z3490.Shipper) & "', "
            SQL = SQL & "    K3490_sePaymentDay      = N'" & FormatSQL(z3490.sePaymentDay) & "', "
            SQL = SQL & "    K3490_cdPaymentDay      = N'" & FormatSQL(z3490.cdPaymentDay) & "', "
            SQL = SQL & "    K3490_VisAllName      = N'" & FormatSQL(z3490.VisAllName) & "', "
            SQL = SQL & "    K3490_VisAllNo      = N'" & FormatSQL(z3490.VisAllNo) & "', "
            SQL = SQL & "    K3490_Buyer      = N'" & FormatSQL(z3490.Buyer) & "', "
            SQL = SQL & "    K3490_FlightNo      = N'" & FormatSQL(z3490.FlightNo) & "', "
            SQL = SQL & "    K3490_HAWB      = N'" & FormatSQL(z3490.HAWB) & "', "
            SQL = SQL & "    K3490_Status      = N'" & FormatSQL(z3490.Status) & "', "
            SQL = SQL & "    K3490_DateInsert      = N'" & FormatSQL(z3490.DateInsert) & "', "
            SQL = SQL & "    K3490_DateUpdate      = N'" & FormatSQL(z3490.DateUpdate) & "', "
            SQL = SQL & "    K3490_InchargeInsert      = N'" & FormatSQL(z3490.InchargeInsert) & "', "
            SQL = SQL & "    K3490_InchargeUpdate      = N'" & FormatSQL(z3490.InchargeUpdate) & "', "
            SQL = SQL & "    K3490_TimeInsert      = N'" & FormatSQL(z3490.TimeInsert) & "', "
            SQL = SQL & "    K3490_TimeUpdate      = N'" & FormatSQL(z3490.TimeUpdate) & "'  "
            SQL = SQL & " WHERE K3490_WIPNo		 = '" & z3490.WIPNo & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK3490 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK3490", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK3490(z3490 As T3490_AREA) As Boolean
        DELETE_PFK3490 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK3490 "
            SQL = SQL & " WHERE K3490_WIPNo		 = '" & z3490.WIPNo & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK3490 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK3490", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D3490_CLEAR()
        Try

            D3490.WIPNo = ""
            D3490.TransferType = ""
            D3490.DateWIP = ""
            D3490.WIPNoMaster = ""
            D3490.ContainerNo = ""
            D3490.CustomerCode = ""
            D3490.DateETA = ""
            D3490.DateETD = ""
            D3490.DateFlight = ""
            D3490.DateBooking = ""
            D3490.BookingNo = ""
            D3490.CheckMarketType = ""
            D3490.seDepartment = ""
            D3490.cdDepartment = ""
            D3490.InchargeWIP = ""
            D3490.seUnitPrice = ""
            D3490.cdUnitPrice = ""
            D3490.CustomerName = ""
            D3490.DestinationID = ""
            D3490.Remarks = ""
            D3490.seSite = ""
            D3490.cdSite = ""
            D3490.ShipFrom = ""
            D3490.ShipTo = ""
            D3490.ShipMark = ""
            D3490.Shipper = ""
            D3490.sePaymentDay = ""
            D3490.cdPaymentDay = ""
            D3490.VisAllName = ""
            D3490.VisAllNo = ""
            D3490.Buyer = ""
            D3490.FlightNo = ""
            D3490.HAWB = ""
            D3490.Status = ""
            D3490.DateInsert = ""
            D3490.DateUpdate = ""
            D3490.InchargeInsert = ""
            D3490.InchargeUpdate = ""
            D3490.TimeInsert = ""
            D3490.TimeUpdate = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D3490_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x3490 As T3490_AREA)
        Try

            x3490.WIPNo = trim$(x3490.WIPNo)
            x3490.TransferType = trim$(x3490.TransferType)
            x3490.DateWIP = trim$(x3490.DateWIP)
            x3490.WIPNoMaster = trim$(x3490.WIPNoMaster)
            x3490.ContainerNo = trim$(x3490.ContainerNo)
            x3490.CustomerCode = trim$(x3490.CustomerCode)
            x3490.DateETA = trim$(x3490.DateETA)
            x3490.DateETD = trim$(x3490.DateETD)
            x3490.DateFlight = trim$(x3490.DateFlight)
            x3490.DateBooking = trim$(x3490.DateBooking)
            x3490.BookingNo = trim$(x3490.BookingNo)
            x3490.CheckMarketType = trim$(x3490.CheckMarketType)
            x3490.seDepartment = trim$(x3490.seDepartment)
            x3490.cdDepartment = trim$(x3490.cdDepartment)
            x3490.InchargeWIP = trim$(x3490.InchargeWIP)
            x3490.seUnitPrice = trim$(x3490.seUnitPrice)
            x3490.cdUnitPrice = trim$(x3490.cdUnitPrice)
            x3490.CustomerName = trim$(x3490.CustomerName)
            x3490.DestinationID = trim$(x3490.DestinationID)
            x3490.Remarks = trim$(x3490.Remarks)
            x3490.seSite = trim$(x3490.seSite)
            x3490.cdSite = Trim$(x3490.cdSite)
            x3490.ShipFrom = trim$(x3490.ShipFrom)
            x3490.ShipTo = trim$(x3490.ShipTo)
            x3490.ShipMark = trim$(x3490.ShipMark)
            x3490.Shipper = trim$(x3490.Shipper)
            x3490.sePaymentDay = trim$(x3490.sePaymentDay)
            x3490.cdPaymentDay = trim$(x3490.cdPaymentDay)
            x3490.VisAllName = trim$(x3490.VisAllName)
            x3490.VisAllNo = trim$(x3490.VisAllNo)
            x3490.Buyer = trim$(x3490.Buyer)
            x3490.FlightNo = trim$(x3490.FlightNo)
            x3490.HAWB = trim$(x3490.HAWB)
            x3490.Status = trim$(x3490.Status)
            x3490.DateInsert = trim$(x3490.DateInsert)
            x3490.DateUpdate = trim$(x3490.DateUpdate)
            x3490.InchargeInsert = trim$(x3490.InchargeInsert)
            x3490.InchargeUpdate = trim$(x3490.InchargeUpdate)
            x3490.TimeInsert = trim$(x3490.TimeInsert)
            x3490.TimeUpdate = trim$(x3490.TimeUpdate)

            If trim$(x3490.WIPNo) = "" Then x3490.WIPNo = Space(1)
            If trim$(x3490.TransferType) = "" Then x3490.TransferType = Space(1)
            If trim$(x3490.DateWIP) = "" Then x3490.DateWIP = Space(1)
            If trim$(x3490.WIPNoMaster) = "" Then x3490.WIPNoMaster = Space(1)
            If trim$(x3490.ContainerNo) = "" Then x3490.ContainerNo = Space(1)
            If trim$(x3490.CustomerCode) = "" Then x3490.CustomerCode = Space(1)
            If trim$(x3490.DateETA) = "" Then x3490.DateETA = Space(1)
            If trim$(x3490.DateETD) = "" Then x3490.DateETD = Space(1)
            If trim$(x3490.DateFlight) = "" Then x3490.DateFlight = Space(1)
            If trim$(x3490.DateBooking) = "" Then x3490.DateBooking = Space(1)
            If trim$(x3490.BookingNo) = "" Then x3490.BookingNo = Space(1)
            If trim$(x3490.CheckMarketType) = "" Then x3490.CheckMarketType = Space(1)
            If trim$(x3490.seDepartment) = "" Then x3490.seDepartment = Space(1)
            If trim$(x3490.cdDepartment) = "" Then x3490.cdDepartment = Space(1)
            If trim$(x3490.InchargeWIP) = "" Then x3490.InchargeWIP = Space(1)
            If trim$(x3490.seUnitPrice) = "" Then x3490.seUnitPrice = Space(1)
            If trim$(x3490.cdUnitPrice) = "" Then x3490.cdUnitPrice = Space(1)
            If trim$(x3490.CustomerName) = "" Then x3490.CustomerName = Space(1)
            If trim$(x3490.DestinationID) = "" Then x3490.DestinationID = Space(1)
            If trim$(x3490.Remarks) = "" Then x3490.Remarks = Space(1)
            If Trim$(x3490.seSite) = "" Then x3490.seSite = Space(1)
            If Trim$(x3490.cdSite) = "" Then x3490.cdSite = Space(1)
            If trim$(x3490.ShipFrom) = "" Then x3490.ShipFrom = Space(1)
            If trim$(x3490.ShipTo) = "" Then x3490.ShipTo = Space(1)
            If trim$(x3490.ShipMark) = "" Then x3490.ShipMark = Space(1)
            If trim$(x3490.Shipper) = "" Then x3490.Shipper = Space(1)
            If trim$(x3490.sePaymentDay) = "" Then x3490.sePaymentDay = Space(1)
            If trim$(x3490.cdPaymentDay) = "" Then x3490.cdPaymentDay = Space(1)
            If trim$(x3490.VisAllName) = "" Then x3490.VisAllName = Space(1)
            If trim$(x3490.VisAllNo) = "" Then x3490.VisAllNo = Space(1)
            If trim$(x3490.Buyer) = "" Then x3490.Buyer = Space(1)
            If trim$(x3490.FlightNo) = "" Then x3490.FlightNo = Space(1)
            If trim$(x3490.HAWB) = "" Then x3490.HAWB = Space(1)
            If trim$(x3490.Status) = "" Then x3490.Status = Space(1)
            If trim$(x3490.DateInsert) = "" Then x3490.DateInsert = Space(1)
            If trim$(x3490.DateUpdate) = "" Then x3490.DateUpdate = Space(1)
            If trim$(x3490.InchargeInsert) = "" Then x3490.InchargeInsert = Space(1)
            If trim$(x3490.InchargeUpdate) = "" Then x3490.InchargeUpdate = Space(1)
            If trim$(x3490.TimeInsert) = "" Then x3490.TimeInsert = Space(1)
            If trim$(x3490.TimeUpdate) = "" Then x3490.TimeUpdate = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K3490_MOVE(rs3490 As SqlClient.SqlDataReader)
        Try

            Call D3490_CLEAR()

            If IsdbNull(rs3490!K3490_WIPNo) = False Then D3490.WIPNo = Trim$(rs3490!K3490_WIPNo)
            If IsdbNull(rs3490!K3490_TransferType) = False Then D3490.TransferType = Trim$(rs3490!K3490_TransferType)
            If IsdbNull(rs3490!K3490_DateWIP) = False Then D3490.DateWIP = Trim$(rs3490!K3490_DateWIP)
            If IsdbNull(rs3490!K3490_WIPNoMaster) = False Then D3490.WIPNoMaster = Trim$(rs3490!K3490_WIPNoMaster)
            If IsdbNull(rs3490!K3490_ContainerNo) = False Then D3490.ContainerNo = Trim$(rs3490!K3490_ContainerNo)
            If IsdbNull(rs3490!K3490_CustomerCode) = False Then D3490.CustomerCode = Trim$(rs3490!K3490_CustomerCode)
            If IsdbNull(rs3490!K3490_DateETA) = False Then D3490.DateETA = Trim$(rs3490!K3490_DateETA)
            If IsdbNull(rs3490!K3490_DateETD) = False Then D3490.DateETD = Trim$(rs3490!K3490_DateETD)
            If IsdbNull(rs3490!K3490_DateFlight) = False Then D3490.DateFlight = Trim$(rs3490!K3490_DateFlight)
            If IsdbNull(rs3490!K3490_DateBooking) = False Then D3490.DateBooking = Trim$(rs3490!K3490_DateBooking)
            If IsdbNull(rs3490!K3490_BookingNo) = False Then D3490.BookingNo = Trim$(rs3490!K3490_BookingNo)
            If IsdbNull(rs3490!K3490_CheckMarketType) = False Then D3490.CheckMarketType = Trim$(rs3490!K3490_CheckMarketType)
            If IsdbNull(rs3490!K3490_seDepartment) = False Then D3490.seDepartment = Trim$(rs3490!K3490_seDepartment)
            If IsdbNull(rs3490!K3490_cdDepartment) = False Then D3490.cdDepartment = Trim$(rs3490!K3490_cdDepartment)
            If IsdbNull(rs3490!K3490_InchargeWIP) = False Then D3490.InchargeWIP = Trim$(rs3490!K3490_InchargeWIP)
            If IsdbNull(rs3490!K3490_seUnitPrice) = False Then D3490.seUnitPrice = Trim$(rs3490!K3490_seUnitPrice)
            If IsdbNull(rs3490!K3490_cdUnitPrice) = False Then D3490.cdUnitPrice = Trim$(rs3490!K3490_cdUnitPrice)
            If IsdbNull(rs3490!K3490_CustomerName) = False Then D3490.CustomerName = Trim$(rs3490!K3490_CustomerName)
            If IsdbNull(rs3490!K3490_DestinationID) = False Then D3490.DestinationID = Trim$(rs3490!K3490_DestinationID)
            If IsdbNull(rs3490!K3490_Remarks) = False Then D3490.Remarks = Trim$(rs3490!K3490_Remarks)
            If IsDBNull(rs3490!K3490_seSite) = False Then D3490.seSite = Trim$(rs3490!K3490_seSite)
            If IsDBNull(rs3490!K3490_cdSite) = False Then D3490.cdSite = Trim$(rs3490!K3490_cdSite)
            If IsdbNull(rs3490!K3490_ShipFrom) = False Then D3490.ShipFrom = Trim$(rs3490!K3490_ShipFrom)
            If IsdbNull(rs3490!K3490_ShipTo) = False Then D3490.ShipTo = Trim$(rs3490!K3490_ShipTo)
            If IsdbNull(rs3490!K3490_ShipMark) = False Then D3490.ShipMark = Trim$(rs3490!K3490_ShipMark)
            If IsdbNull(rs3490!K3490_Shipper) = False Then D3490.Shipper = Trim$(rs3490!K3490_Shipper)
            If IsdbNull(rs3490!K3490_sePaymentDay) = False Then D3490.sePaymentDay = Trim$(rs3490!K3490_sePaymentDay)
            If IsdbNull(rs3490!K3490_cdPaymentDay) = False Then D3490.cdPaymentDay = Trim$(rs3490!K3490_cdPaymentDay)
            If IsdbNull(rs3490!K3490_VisAllName) = False Then D3490.VisAllName = Trim$(rs3490!K3490_VisAllName)
            If IsdbNull(rs3490!K3490_VisAllNo) = False Then D3490.VisAllNo = Trim$(rs3490!K3490_VisAllNo)
            If IsdbNull(rs3490!K3490_Buyer) = False Then D3490.Buyer = Trim$(rs3490!K3490_Buyer)
            If IsdbNull(rs3490!K3490_FlightNo) = False Then D3490.FlightNo = Trim$(rs3490!K3490_FlightNo)
            If IsdbNull(rs3490!K3490_HAWB) = False Then D3490.HAWB = Trim$(rs3490!K3490_HAWB)
            If IsdbNull(rs3490!K3490_Status) = False Then D3490.Status = Trim$(rs3490!K3490_Status)
            If IsdbNull(rs3490!K3490_DateInsert) = False Then D3490.DateInsert = Trim$(rs3490!K3490_DateInsert)
            If IsdbNull(rs3490!K3490_DateUpdate) = False Then D3490.DateUpdate = Trim$(rs3490!K3490_DateUpdate)
            If IsdbNull(rs3490!K3490_InchargeInsert) = False Then D3490.InchargeInsert = Trim$(rs3490!K3490_InchargeInsert)
            If IsdbNull(rs3490!K3490_InchargeUpdate) = False Then D3490.InchargeUpdate = Trim$(rs3490!K3490_InchargeUpdate)
            If IsdbNull(rs3490!K3490_TimeInsert) = False Then D3490.TimeInsert = Trim$(rs3490!K3490_TimeInsert)
            If IsdbNull(rs3490!K3490_TimeUpdate) = False Then D3490.TimeUpdate = Trim$(rs3490!K3490_TimeUpdate)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3490_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K3490_MOVE(rs3490 As DataRow)
        Try

            Call D3490_CLEAR()

            If IsdbNull(rs3490!K3490_WIPNo) = False Then D3490.WIPNo = Trim$(rs3490!K3490_WIPNo)
            If IsdbNull(rs3490!K3490_TransferType) = False Then D3490.TransferType = Trim$(rs3490!K3490_TransferType)
            If IsdbNull(rs3490!K3490_DateWIP) = False Then D3490.DateWIP = Trim$(rs3490!K3490_DateWIP)
            If IsdbNull(rs3490!K3490_WIPNoMaster) = False Then D3490.WIPNoMaster = Trim$(rs3490!K3490_WIPNoMaster)
            If IsdbNull(rs3490!K3490_ContainerNo) = False Then D3490.ContainerNo = Trim$(rs3490!K3490_ContainerNo)
            If IsdbNull(rs3490!K3490_CustomerCode) = False Then D3490.CustomerCode = Trim$(rs3490!K3490_CustomerCode)
            If IsdbNull(rs3490!K3490_DateETA) = False Then D3490.DateETA = Trim$(rs3490!K3490_DateETA)
            If IsdbNull(rs3490!K3490_DateETD) = False Then D3490.DateETD = Trim$(rs3490!K3490_DateETD)
            If IsdbNull(rs3490!K3490_DateFlight) = False Then D3490.DateFlight = Trim$(rs3490!K3490_DateFlight)
            If IsdbNull(rs3490!K3490_DateBooking) = False Then D3490.DateBooking = Trim$(rs3490!K3490_DateBooking)
            If IsdbNull(rs3490!K3490_BookingNo) = False Then D3490.BookingNo = Trim$(rs3490!K3490_BookingNo)
            If IsdbNull(rs3490!K3490_CheckMarketType) = False Then D3490.CheckMarketType = Trim$(rs3490!K3490_CheckMarketType)
            If IsdbNull(rs3490!K3490_seDepartment) = False Then D3490.seDepartment = Trim$(rs3490!K3490_seDepartment)
            If IsdbNull(rs3490!K3490_cdDepartment) = False Then D3490.cdDepartment = Trim$(rs3490!K3490_cdDepartment)
            If IsdbNull(rs3490!K3490_InchargeWIP) = False Then D3490.InchargeWIP = Trim$(rs3490!K3490_InchargeWIP)
            If IsdbNull(rs3490!K3490_seUnitPrice) = False Then D3490.seUnitPrice = Trim$(rs3490!K3490_seUnitPrice)
            If IsdbNull(rs3490!K3490_cdUnitPrice) = False Then D3490.cdUnitPrice = Trim$(rs3490!K3490_cdUnitPrice)
            If IsdbNull(rs3490!K3490_CustomerName) = False Then D3490.CustomerName = Trim$(rs3490!K3490_CustomerName)
            If IsdbNull(rs3490!K3490_DestinationID) = False Then D3490.DestinationID = Trim$(rs3490!K3490_DestinationID)
            If IsdbNull(rs3490!K3490_Remarks) = False Then D3490.Remarks = Trim$(rs3490!K3490_Remarks)
            If IsDBNull(rs3490!K3490_seSite) = False Then D3490.seSite = Trim$(rs3490!K3490_seSite)
            If IsDBNull(rs3490!K3490_cdSite) = False Then D3490.cdSite = Trim$(rs3490!K3490_cdSite)
            If IsdbNull(rs3490!K3490_ShipFrom) = False Then D3490.ShipFrom = Trim$(rs3490!K3490_ShipFrom)
            If IsdbNull(rs3490!K3490_ShipTo) = False Then D3490.ShipTo = Trim$(rs3490!K3490_ShipTo)
            If IsdbNull(rs3490!K3490_ShipMark) = False Then D3490.ShipMark = Trim$(rs3490!K3490_ShipMark)
            If IsdbNull(rs3490!K3490_Shipper) = False Then D3490.Shipper = Trim$(rs3490!K3490_Shipper)
            If IsdbNull(rs3490!K3490_sePaymentDay) = False Then D3490.sePaymentDay = Trim$(rs3490!K3490_sePaymentDay)
            If IsdbNull(rs3490!K3490_cdPaymentDay) = False Then D3490.cdPaymentDay = Trim$(rs3490!K3490_cdPaymentDay)
            If IsdbNull(rs3490!K3490_VisAllName) = False Then D3490.VisAllName = Trim$(rs3490!K3490_VisAllName)
            If IsdbNull(rs3490!K3490_VisAllNo) = False Then D3490.VisAllNo = Trim$(rs3490!K3490_VisAllNo)
            If IsdbNull(rs3490!K3490_Buyer) = False Then D3490.Buyer = Trim$(rs3490!K3490_Buyer)
            If IsdbNull(rs3490!K3490_FlightNo) = False Then D3490.FlightNo = Trim$(rs3490!K3490_FlightNo)
            If IsdbNull(rs3490!K3490_HAWB) = False Then D3490.HAWB = Trim$(rs3490!K3490_HAWB)
            If IsdbNull(rs3490!K3490_Status) = False Then D3490.Status = Trim$(rs3490!K3490_Status)
            If IsdbNull(rs3490!K3490_DateInsert) = False Then D3490.DateInsert = Trim$(rs3490!K3490_DateInsert)
            If IsdbNull(rs3490!K3490_DateUpdate) = False Then D3490.DateUpdate = Trim$(rs3490!K3490_DateUpdate)
            If IsdbNull(rs3490!K3490_InchargeInsert) = False Then D3490.InchargeInsert = Trim$(rs3490!K3490_InchargeInsert)
            If IsdbNull(rs3490!K3490_InchargeUpdate) = False Then D3490.InchargeUpdate = Trim$(rs3490!K3490_InchargeUpdate)
            If IsdbNull(rs3490!K3490_TimeInsert) = False Then D3490.TimeInsert = Trim$(rs3490!K3490_TimeInsert)
            If IsdbNull(rs3490!K3490_TimeUpdate) = False Then D3490.TimeUpdate = Trim$(rs3490!K3490_TimeUpdate)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3490_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K3490_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3490 As T3490_AREA, WIPNO As String) As Boolean

        K3490_MOVE = False

        Try
            If READ_PFK3490(WIPNO) = True Then
                z3490 = D3490
                K3490_MOVE = True
            Else
                z3490 = Nothing
            End If

            If getColumIndex(spr, "WIPNo") > -1 Then z3490.WIPNo = getDataM(spr, getColumIndex(spr, "WIPNo"), xRow)
            If getColumIndex(spr, "TransferType") > -1 Then z3490.TransferType = getDataM(spr, getColumIndex(spr, "TransferType"), xRow)
            If getColumIndex(spr, "DateWIP") > -1 Then z3490.DateWIP = getDataM(spr, getColumIndex(spr, "DateWIP"), xRow)
            If getColumIndex(spr, "WIPNoMaster") > -1 Then z3490.WIPNoMaster = getDataM(spr, getColumIndex(spr, "WIPNoMaster"), xRow)
            If getColumIndex(spr, "ContainerNo") > -1 Then z3490.ContainerNo = getDataM(spr, getColumIndex(spr, "ContainerNo"), xRow)
            If getColumIndex(spr, "CustomerCode") > -1 Then z3490.CustomerCode = getDataM(spr, getColumIndex(spr, "CustomerCode"), xRow)
            If getColumIndex(spr, "DateETA") > -1 Then z3490.DateETA = getDataM(spr, getColumIndex(spr, "DateETA"), xRow)
            If getColumIndex(spr, "DateETD") > -1 Then z3490.DateETD = getDataM(spr, getColumIndex(spr, "DateETD"), xRow)
            If getColumIndex(spr, "DateFlight") > -1 Then z3490.DateFlight = getDataM(spr, getColumIndex(spr, "DateFlight"), xRow)
            If getColumIndex(spr, "DateBooking") > -1 Then z3490.DateBooking = getDataM(spr, getColumIndex(spr, "DateBooking"), xRow)
            If getColumIndex(spr, "BookingNo") > -1 Then z3490.BookingNo = getDataM(spr, getColumIndex(spr, "BookingNo"), xRow)
            If getColumIndex(spr, "CheckMarketType") > -1 Then z3490.CheckMarketType = getDataM(spr, getColumIndex(spr, "CheckMarketType"), xRow)
            If getColumIndex(spr, "seDepartment") > -1 Then z3490.seDepartment = getDataM(spr, getColumIndex(spr, "seDepartment"), xRow)
            If getColumIndex(spr, "cdDepartment") > -1 Then z3490.cdDepartment = getDataM(spr, getColumIndex(spr, "cdDepartment"), xRow)
            If getColumIndex(spr, "InchargeWIP") > -1 Then z3490.InchargeWIP = getDataM(spr, getColumIndex(spr, "InchargeWIP"), xRow)
            If getColumIndex(spr, "seUnitPrice") > -1 Then z3490.seUnitPrice = getDataM(spr, getColumIndex(spr, "seUnitPrice"), xRow)
            If getColumIndex(spr, "cdUnitPrice") > -1 Then z3490.cdUnitPrice = getDataM(spr, getColumIndex(spr, "cdUnitPrice"), xRow)
            If getColumIndex(spr, "CustomerName") > -1 Then z3490.CustomerName = getDataM(spr, getColumIndex(spr, "CustomerName"), xRow)
            If getColumIndex(spr, "DestinationID") > -1 Then z3490.DestinationID = getDataM(spr, getColumIndex(spr, "DestinationID"), xRow)
            If getColumIndex(spr, "Remarks") > -1 Then z3490.Remarks = getDataM(spr, getColumIndex(spr, "Remarks"), xRow)
            If getColumIndex(spr, "seSite") > -1 Then z3490.seSite = getDataM(spr, getColumIndex(spr, "seSite"), xRow)
            If getColumIndex(spr, "cdSite") > -1 Then z3490.cdSite = getDataM(spr, getColumIndex(spr, "cdSite"), xRow)
            If getColumIndex(spr, "ShipFrom") > -1 Then z3490.ShipFrom = getDataM(spr, getColumIndex(spr, "ShipFrom"), xRow)
            If getColumIndex(spr, "ShipTo") > -1 Then z3490.ShipTo = getDataM(spr, getColumIndex(spr, "ShipTo"), xRow)
            If getColumIndex(spr, "ShipMark") > -1 Then z3490.ShipMark = getDataM(spr, getColumIndex(spr, "ShipMark"), xRow)
            If getColumIndex(spr, "Shipper") > -1 Then z3490.Shipper = getDataM(spr, getColumIndex(spr, "Shipper"), xRow)
            If getColumIndex(spr, "sePaymentDay") > -1 Then z3490.sePaymentDay = getDataM(spr, getColumIndex(spr, "sePaymentDay"), xRow)
            If getColumIndex(spr, "cdPaymentDay") > -1 Then z3490.cdPaymentDay = getDataM(spr, getColumIndex(spr, "cdPaymentDay"), xRow)
            If getColumIndex(spr, "VisAllName") > -1 Then z3490.VisAllName = getDataM(spr, getColumIndex(spr, "VisAllName"), xRow)
            If getColumIndex(spr, "VisAllNo") > -1 Then z3490.VisAllNo = getDataM(spr, getColumIndex(spr, "VisAllNo"), xRow)
            If getColumIndex(spr, "Buyer") > -1 Then z3490.Buyer = getDataM(spr, getColumIndex(spr, "Buyer"), xRow)
            If getColumIndex(spr, "FlightNo") > -1 Then z3490.FlightNo = getDataM(spr, getColumIndex(spr, "FlightNo"), xRow)
            If getColumIndex(spr, "HAWB") > -1 Then z3490.HAWB = getDataM(spr, getColumIndex(spr, "HAWB"), xRow)
            If getColumIndex(spr, "Status") > -1 Then z3490.Status = getDataM(spr, getColumIndex(spr, "Status"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z3490.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z3490.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z3490.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z3490.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "TimeInsert") > -1 Then z3490.TimeInsert = getDataM(spr, getColumIndex(spr, "TimeInsert"), xRow)
            If getColumIndex(spr, "TimeUpdate") > -1 Then z3490.TimeUpdate = getDataM(spr, getColumIndex(spr, "TimeUpdate"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3490_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K3490_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3490 As T3490_AREA, CheckClear As Boolean, WIPNO As String) As Boolean

        K3490_MOVE = False

        Try
            If READ_PFK3490(WIPNO) = True Then
                z3490 = D3490
                K3490_MOVE = True
            Else
                If CheckClear = True Then z3490 = Nothing
            End If

            If getColumIndex(spr, "WIPNo") > -1 Then z3490.WIPNo = getDataM(spr, getColumIndex(spr, "WIPNo"), xRow)
            If getColumIndex(spr, "TransferType") > -1 Then z3490.TransferType = getDataM(spr, getColumIndex(spr, "TransferType"), xRow)
            If getColumIndex(spr, "DateWIP") > -1 Then z3490.DateWIP = getDataM(spr, getColumIndex(spr, "DateWIP"), xRow)
            If getColumIndex(spr, "WIPNoMaster") > -1 Then z3490.WIPNoMaster = getDataM(spr, getColumIndex(spr, "WIPNoMaster"), xRow)
            If getColumIndex(spr, "ContainerNo") > -1 Then z3490.ContainerNo = getDataM(spr, getColumIndex(spr, "ContainerNo"), xRow)
            If getColumIndex(spr, "CustomerCode") > -1 Then z3490.CustomerCode = getDataM(spr, getColumIndex(spr, "CustomerCode"), xRow)
            If getColumIndex(spr, "DateETA") > -1 Then z3490.DateETA = getDataM(spr, getColumIndex(spr, "DateETA"), xRow)
            If getColumIndex(spr, "DateETD") > -1 Then z3490.DateETD = getDataM(spr, getColumIndex(spr, "DateETD"), xRow)
            If getColumIndex(spr, "DateFlight") > -1 Then z3490.DateFlight = getDataM(spr, getColumIndex(spr, "DateFlight"), xRow)
            If getColumIndex(spr, "DateBooking") > -1 Then z3490.DateBooking = getDataM(spr, getColumIndex(spr, "DateBooking"), xRow)
            If getColumIndex(spr, "BookingNo") > -1 Then z3490.BookingNo = getDataM(spr, getColumIndex(spr, "BookingNo"), xRow)
            If getColumIndex(spr, "CheckMarketType") > -1 Then z3490.CheckMarketType = getDataM(spr, getColumIndex(spr, "CheckMarketType"), xRow)
            If getColumIndex(spr, "seDepartment") > -1 Then z3490.seDepartment = getDataM(spr, getColumIndex(spr, "seDepartment"), xRow)
            If getColumIndex(spr, "cdDepartment") > -1 Then z3490.cdDepartment = getDataM(spr, getColumIndex(spr, "cdDepartment"), xRow)
            If getColumIndex(spr, "InchargeWIP") > -1 Then z3490.InchargeWIP = getDataM(spr, getColumIndex(spr, "InchargeWIP"), xRow)
            If getColumIndex(spr, "seUnitPrice") > -1 Then z3490.seUnitPrice = getDataM(spr, getColumIndex(spr, "seUnitPrice"), xRow)
            If getColumIndex(spr, "cdUnitPrice") > -1 Then z3490.cdUnitPrice = getDataM(spr, getColumIndex(spr, "cdUnitPrice"), xRow)
            If getColumIndex(spr, "CustomerName") > -1 Then z3490.CustomerName = getDataM(spr, getColumIndex(spr, "CustomerName"), xRow)
            If getColumIndex(spr, "DestinationID") > -1 Then z3490.DestinationID = getDataM(spr, getColumIndex(spr, "DestinationID"), xRow)
            If getColumIndex(spr, "Remarks") > -1 Then z3490.Remarks = getDataM(spr, getColumIndex(spr, "Remarks"), xRow)
            If getColumIndex(spr, "seSite") > -1 Then z3490.seSite = getDataM(spr, getColumIndex(spr, "seSite"), xRow)
            If getColumIndex(spr, "cdSite") > -1 Then z3490.cdSite = getDataM(spr, getColumIndex(spr, "cdSite"), xRow)
            If getColumIndex(spr, "ShipFrom") > -1 Then z3490.ShipFrom = getDataM(spr, getColumIndex(spr, "ShipFrom"), xRow)
            If getColumIndex(spr, "ShipTo") > -1 Then z3490.ShipTo = getDataM(spr, getColumIndex(spr, "ShipTo"), xRow)
            If getColumIndex(spr, "ShipMark") > -1 Then z3490.ShipMark = getDataM(spr, getColumIndex(spr, "ShipMark"), xRow)
            If getColumIndex(spr, "Shipper") > -1 Then z3490.Shipper = getDataM(spr, getColumIndex(spr, "Shipper"), xRow)
            If getColumIndex(spr, "sePaymentDay") > -1 Then z3490.sePaymentDay = getDataM(spr, getColumIndex(spr, "sePaymentDay"), xRow)
            If getColumIndex(spr, "cdPaymentDay") > -1 Then z3490.cdPaymentDay = getDataM(spr, getColumIndex(spr, "cdPaymentDay"), xRow)
            If getColumIndex(spr, "VisAllName") > -1 Then z3490.VisAllName = getDataM(spr, getColumIndex(spr, "VisAllName"), xRow)
            If getColumIndex(spr, "VisAllNo") > -1 Then z3490.VisAllNo = getDataM(spr, getColumIndex(spr, "VisAllNo"), xRow)
            If getColumIndex(spr, "Buyer") > -1 Then z3490.Buyer = getDataM(spr, getColumIndex(spr, "Buyer"), xRow)
            If getColumIndex(spr, "FlightNo") > -1 Then z3490.FlightNo = getDataM(spr, getColumIndex(spr, "FlightNo"), xRow)
            If getColumIndex(spr, "HAWB") > -1 Then z3490.HAWB = getDataM(spr, getColumIndex(spr, "HAWB"), xRow)
            If getColumIndex(spr, "Status") > -1 Then z3490.Status = getDataM(spr, getColumIndex(spr, "Status"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z3490.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z3490.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z3490.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z3490.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "TimeInsert") > -1 Then z3490.TimeInsert = getDataM(spr, getColumIndex(spr, "TimeInsert"), xRow)
            If getColumIndex(spr, "TimeUpdate") > -1 Then z3490.TimeUpdate = getDataM(spr, getColumIndex(spr, "TimeUpdate"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3490_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K3490_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3490 As T3490_AREA, Job As String, WIPNO As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3490_MOVE = False

        Try
            If READ_PFK3490(WIPNO) = True Then
                z3490 = D3490
                K3490_MOVE = True
            Else
                z3490 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3490")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "WIPNO" : z3490.WIPNo = Children(i).Code
                                Case "TRANSFERTYPE" : z3490.TransferType = Children(i).Code
                                Case "DATEWIP" : z3490.DateWIP = Children(i).Code
                                Case "WIPNOMASTER" : z3490.WIPNoMaster = Children(i).Code
                                Case "CONTAINERNO" : z3490.ContainerNo = Children(i).Code
                                Case "CUSTOMERCODE" : z3490.CustomerCode = Children(i).Code
                                Case "DATEETA" : z3490.DateETA = Children(i).Code
                                Case "DATEETD" : z3490.DateETD = Children(i).Code
                                Case "DATEFLIGHT" : z3490.DateFlight = Children(i).Code
                                Case "DATEBOOKING" : z3490.DateBooking = Children(i).Code
                                Case "BOOKINGNO" : z3490.BookingNo = Children(i).Code
                                Case "CHECKMARKETTYPE" : z3490.CheckMarketType = Children(i).Code
                                Case "SEDEPARTMENT" : z3490.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z3490.cdDepartment = Children(i).Code
                                Case "INCHARGEWIP" : z3490.InchargeWIP = Children(i).Code
                                Case "SEUNITPRICE" : z3490.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z3490.cdUnitPrice = Children(i).Code
                                Case "CUSTOMERNAME" : z3490.CustomerName = Children(i).Code
                                Case "DESTINATIONID" : z3490.DestinationID = Children(i).Code
                                Case "REMARKS" : z3490.Remarks = Children(i).Code
                                Case "SESITE" : z3490.seSite = Children(i).Code
                                Case "CDSITE" : z3490.cdSite = Children(i).Code
                                Case "SHIPFROM" : z3490.ShipFrom = Children(i).Code
                                Case "SHIPTO" : z3490.ShipTo = Children(i).Code
                                Case "SHIPMARK" : z3490.ShipMark = Children(i).Code
                                Case "SHIPPER" : z3490.Shipper = Children(i).Code
                                Case "SEPAYMENTDAY" : z3490.sePaymentDay = Children(i).Code
                                Case "CDPAYMENTDAY" : z3490.cdPaymentDay = Children(i).Code
                                Case "VISALLNAME" : z3490.VisAllName = Children(i).Code
                                Case "VISALLNO" : z3490.VisAllNo = Children(i).Code
                                Case "BUYER" : z3490.Buyer = Children(i).Code
                                Case "FLIGHTNO" : z3490.FlightNo = Children(i).Code
                                Case "HAWB" : z3490.HAWB = Children(i).Code
                                Case "STATUS" : z3490.Status = Children(i).Code
                                Case "DATEINSERT" : z3490.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z3490.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z3490.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z3490.InchargeUpdate = Children(i).Code
                                Case "TIMEINSERT" : z3490.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z3490.TimeUpdate = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "WIPNO" : z3490.WIPNo = Children(i).Data
                                Case "TRANSFERTYPE" : z3490.TransferType = Children(i).Data
                                Case "DATEWIP" : z3490.DateWIP = Children(i).Data
                                Case "WIPNOMASTER" : z3490.WIPNoMaster = Children(i).Data
                                Case "CONTAINERNO" : z3490.ContainerNo = Children(i).Data
                                Case "CUSTOMERCODE" : z3490.CustomerCode = Children(i).Data
                                Case "DATEETA" : z3490.DateETA = Children(i).Data
                                Case "DATEETD" : z3490.DateETD = Children(i).Data
                                Case "DATEFLIGHT" : z3490.DateFlight = Children(i).Data
                                Case "DATEBOOKING" : z3490.DateBooking = Children(i).Data
                                Case "BOOKINGNO" : z3490.BookingNo = Children(i).Data
                                Case "CHECKMARKETTYPE" : z3490.CheckMarketType = Children(i).Data
                                Case "SEDEPARTMENT" : z3490.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z3490.cdDepartment = Children(i).Data
                                Case "INCHARGEWIP" : z3490.InchargeWIP = Children(i).Data
                                Case "SEUNITPRICE" : z3490.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z3490.cdUnitPrice = Children(i).Data
                                Case "CUSTOMERNAME" : z3490.CustomerName = Children(i).Data
                                Case "DESTINATIONID" : z3490.DestinationID = Children(i).Data
                                Case "REMARKS" : z3490.Remarks = Children(i).Data
                                Case "SESITE" : z3490.seSite = Children(i).Data
                                Case "CDSITE" : z3490.cdSite = Children(i).Data
                                Case "SHIPFROM" : z3490.ShipFrom = Children(i).Data
                                Case "SHIPTO" : z3490.ShipTo = Children(i).Data
                                Case "SHIPMARK" : z3490.ShipMark = Children(i).Data
                                Case "SHIPPER" : z3490.Shipper = Children(i).Data
                                Case "SEPAYMENTDAY" : z3490.sePaymentDay = Children(i).Data
                                Case "CDPAYMENTDAY" : z3490.cdPaymentDay = Children(i).Data
                                Case "VISALLNAME" : z3490.VisAllName = Children(i).Data
                                Case "VISALLNO" : z3490.VisAllNo = Children(i).Data
                                Case "BUYER" : z3490.Buyer = Children(i).Data
                                Case "FLIGHTNO" : z3490.FlightNo = Children(i).Data
                                Case "HAWB" : z3490.HAWB = Children(i).Data
                                Case "STATUS" : z3490.Status = Children(i).Data
                                Case "DATEINSERT" : z3490.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z3490.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z3490.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z3490.InchargeUpdate = Children(i).Data
                                Case "TIMEINSERT" : z3490.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z3490.TimeUpdate = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3490_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K3490_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3490 As T3490_AREA, Job As String, CheckClear As Boolean, WIPNO As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3490_MOVE = False

        Try
            If READ_PFK3490(WIPNO) = True Then
                z3490 = D3490
                K3490_MOVE = True
            Else
                If CheckClear = True Then z3490 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3490")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "WIPNO" : z3490.WIPNo = Children(i).Code
                                Case "TRANSFERTYPE" : z3490.TransferType = Children(i).Code
                                Case "DATEWIP" : z3490.DateWIP = Children(i).Code
                                Case "WIPNOMASTER" : z3490.WIPNoMaster = Children(i).Code
                                Case "CONTAINERNO" : z3490.ContainerNo = Children(i).Code
                                Case "CUSTOMERCODE" : z3490.CustomerCode = Children(i).Code
                                Case "DATEETA" : z3490.DateETA = Children(i).Code
                                Case "DATEETD" : z3490.DateETD = Children(i).Code
                                Case "DATEFLIGHT" : z3490.DateFlight = Children(i).Code
                                Case "DATEBOOKING" : z3490.DateBooking = Children(i).Code
                                Case "BOOKINGNO" : z3490.BookingNo = Children(i).Code
                                Case "CHECKMARKETTYPE" : z3490.CheckMarketType = Children(i).Code
                                Case "SEDEPARTMENT" : z3490.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z3490.cdDepartment = Children(i).Code
                                Case "INCHARGEWIP" : z3490.InchargeWIP = Children(i).Code
                                Case "SEUNITPRICE" : z3490.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z3490.cdUnitPrice = Children(i).Code
                                Case "CUSTOMERNAME" : z3490.CustomerName = Children(i).Code
                                Case "DESTINATIONID" : z3490.DestinationID = Children(i).Code
                                Case "REMARKS" : z3490.Remarks = Children(i).Code
                                Case "SESITE" : z3490.seSite = Children(i).Code
                                Case "CDSITE" : z3490.cdSite = Children(i).Code
                                Case "SHIPFROM" : z3490.ShipFrom = Children(i).Code
                                Case "SHIPTO" : z3490.ShipTo = Children(i).Code
                                Case "SHIPMARK" : z3490.ShipMark = Children(i).Code
                                Case "SHIPPER" : z3490.Shipper = Children(i).Code
                                Case "SEPAYMENTDAY" : z3490.sePaymentDay = Children(i).Code
                                Case "CDPAYMENTDAY" : z3490.cdPaymentDay = Children(i).Code
                                Case "VISALLNAME" : z3490.VisAllName = Children(i).Code
                                Case "VISALLNO" : z3490.VisAllNo = Children(i).Code
                                Case "BUYER" : z3490.Buyer = Children(i).Code
                                Case "FLIGHTNO" : z3490.FlightNo = Children(i).Code
                                Case "HAWB" : z3490.HAWB = Children(i).Code
                                Case "STATUS" : z3490.Status = Children(i).Code
                                Case "DATEINSERT" : z3490.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z3490.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z3490.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z3490.InchargeUpdate = Children(i).Code
                                Case "TIMEINSERT" : z3490.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z3490.TimeUpdate = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "WIPNO" : z3490.WIPNo = Children(i).Data
                                Case "TRANSFERTYPE" : z3490.TransferType = Children(i).Data
                                Case "DATEWIP" : z3490.DateWIP = Children(i).Data
                                Case "WIPNOMASTER" : z3490.WIPNoMaster = Children(i).Data
                                Case "CONTAINERNO" : z3490.ContainerNo = Children(i).Data
                                Case "CUSTOMERCODE" : z3490.CustomerCode = Children(i).Data
                                Case "DATEETA" : z3490.DateETA = Children(i).Data
                                Case "DATEETD" : z3490.DateETD = Children(i).Data
                                Case "DATEFLIGHT" : z3490.DateFlight = Children(i).Data
                                Case "DATEBOOKING" : z3490.DateBooking = Children(i).Data
                                Case "BOOKINGNO" : z3490.BookingNo = Children(i).Data
                                Case "CHECKMARKETTYPE" : z3490.CheckMarketType = Children(i).Data
                                Case "SEDEPARTMENT" : z3490.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z3490.cdDepartment = Children(i).Data
                                Case "INCHARGEWIP" : z3490.InchargeWIP = Children(i).Data
                                Case "SEUNITPRICE" : z3490.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z3490.cdUnitPrice = Children(i).Data
                                Case "CUSTOMERNAME" : z3490.CustomerName = Children(i).Data
                                Case "DESTINATIONID" : z3490.DestinationID = Children(i).Data
                                Case "REMARKS" : z3490.Remarks = Children(i).Data
                                Case "SESITE" : z3490.seSite = Children(i).Data
                                Case "CDSITE" : z3490.cdSite = Children(i).Data
                                Case "SHIPFROM" : z3490.ShipFrom = Children(i).Data
                                Case "SHIPTO" : z3490.ShipTo = Children(i).Data
                                Case "SHIPMARK" : z3490.ShipMark = Children(i).Data
                                Case "SHIPPER" : z3490.Shipper = Children(i).Data
                                Case "SEPAYMENTDAY" : z3490.sePaymentDay = Children(i).Data
                                Case "CDPAYMENTDAY" : z3490.cdPaymentDay = Children(i).Data
                                Case "VISALLNAME" : z3490.VisAllName = Children(i).Data
                                Case "VISALLNO" : z3490.VisAllNo = Children(i).Data
                                Case "BUYER" : z3490.Buyer = Children(i).Data
                                Case "FLIGHTNO" : z3490.FlightNo = Children(i).Data
                                Case "HAWB" : z3490.HAWB = Children(i).Data
                                Case "STATUS" : z3490.Status = Children(i).Data
                                Case "DATEINSERT" : z3490.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z3490.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z3490.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z3490.InchargeUpdate = Children(i).Data
                                Case "TIMEINSERT" : z3490.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z3490.TimeUpdate = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3490_MOVE", vbCritical)
        End Try
    End Function

End Module
