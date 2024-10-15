'=========================================================================================================================================================
'   TABLE : (PFK3440)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3440

    Structure T3440_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public InvoiceNo As String  '			nvarchar(20)		*
        Public TransferType As String  '			char(1)
        Public DateInvoice As String  '			char(8)
        Public InvoiceNoMaster As String  '			nvarchar(20)
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
        Public InchargeInvoice As String  '			char(8)
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

    Public D3440 As T3440_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK3440(INVOICENO As String) As Boolean
        READ_PFK3440 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3440 "
            SQL = SQL & " WHERE K3440_InvoiceNo		 = '" & InvoiceNo & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3440_CLEAR() : GoTo SKIP_READ_PFK3440

            Call K3440_MOVE(rd)
            READ_PFK3440 = True

SKIP_READ_PFK3440:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3440", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK3440(INVOICENO As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3440 "
            SQL = SQL & " WHERE K3440_InvoiceNo		 = '" & InvoiceNo & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK3440", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK3440(z3440 As T3440_AREA) As Boolean
        WRITE_PFK3440 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3440)

            SQL = " INSERT INTO PFK3440 "
            SQL = SQL & " ( "
            SQL = SQL & " K3440_InvoiceNo,"
            SQL = SQL & " K3440_TransferType,"
            SQL = SQL & " K3440_DateInvoice,"
            SQL = SQL & " K3440_InvoiceNoMaster,"
            SQL = SQL & " K3440_ContainerNo,"
            SQL = SQL & " K3440_CustomerCode,"
            SQL = SQL & " K3440_DateETA,"
            SQL = SQL & " K3440_DateETD,"
            SQL = SQL & " K3440_DateFlight,"
            SQL = SQL & " K3440_DateBooking,"
            SQL = SQL & " K3440_BookingNo,"
            SQL = SQL & " K3440_CheckMarketType,"
            SQL = SQL & " K3440_seDepartment,"
            SQL = SQL & " K3440_cdDepartment,"
            SQL = SQL & " K3440_InchargeInvoice,"
            SQL = SQL & " K3440_seUnitPrice,"
            SQL = SQL & " K3440_cdUnitPrice,"
            SQL = SQL & " K3440_CustomerName,"
            SQL = SQL & " K3440_DestinationID,"
            SQL = SQL & " K3440_Remarks,"
            SQL = SQL & " K3440_seSite,"
            SQL = SQL & " K3440_cdSite,"
            SQL = SQL & " K3440_ShipFrom,"
            SQL = SQL & " K3440_ShipTo,"
            SQL = SQL & " K3440_ShipMark,"
            SQL = SQL & " K3440_Shipper,"
            SQL = SQL & " K3440_sePaymentDay,"
            SQL = SQL & " K3440_cdPaymentDay,"
            SQL = SQL & " K3440_VisAllName,"
            SQL = SQL & " K3440_VisAllNo,"
            SQL = SQL & " K3440_Buyer,"
            SQL = SQL & " K3440_FlightNo,"
            SQL = SQL & " K3440_HAWB,"
            SQL = SQL & " K3440_Status,"
            SQL = SQL & " K3440_DateInsert,"
            SQL = SQL & " K3440_DateUpdate,"
            SQL = SQL & " K3440_InchargeInsert,"
            SQL = SQL & " K3440_InchargeUpdate,"
            SQL = SQL & " K3440_TimeInsert,"
            SQL = SQL & " K3440_TimeUpdate "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z3440.InvoiceNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.TransferType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.DateInvoice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.InvoiceNoMaster) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.ContainerNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.CustomerCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.DateETA) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.DateETD) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.DateFlight) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.DateBooking) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.BookingNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.CheckMarketType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.seDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.cdDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.InchargeInvoice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.seUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.cdUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.CustomerName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.DestinationID) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.Remarks) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.seSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.cdSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.ShipFrom) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.ShipTo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.ShipMark) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.Shipper) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.sePaymentDay) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.cdPaymentDay) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.VisAllName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.VisAllNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.Buyer) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.FlightNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.HAWB) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.Status) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.DateInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.InchargeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.TimeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3440.TimeUpdate) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK3440 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK3440", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK3440(z3440 As T3440_AREA) As Boolean
        REWRITE_PFK3440 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3440)

            SQL = " UPDATE PFK3440 SET "
            SQL = SQL & "    K3440_TransferType      = N'" & FormatSQL(z3440.TransferType) & "', "
            SQL = SQL & "    K3440_DateInvoice      = N'" & FormatSQL(z3440.DateInvoice) & "', "
            SQL = SQL & "    K3440_InvoiceNoMaster      = N'" & FormatSQL(z3440.InvoiceNoMaster) & "', "
            SQL = SQL & "    K3440_ContainerNo      = N'" & FormatSQL(z3440.ContainerNo) & "', "
            SQL = SQL & "    K3440_CustomerCode      = N'" & FormatSQL(z3440.CustomerCode) & "', "
            SQL = SQL & "    K3440_DateETA      = N'" & FormatSQL(z3440.DateETA) & "', "
            SQL = SQL & "    K3440_DateETD      = N'" & FormatSQL(z3440.DateETD) & "', "
            SQL = SQL & "    K3440_DateFlight      = N'" & FormatSQL(z3440.DateFlight) & "', "
            SQL = SQL & "    K3440_DateBooking      = N'" & FormatSQL(z3440.DateBooking) & "', "
            SQL = SQL & "    K3440_BookingNo      = N'" & FormatSQL(z3440.BookingNo) & "', "
            SQL = SQL & "    K3440_CheckMarketType      = N'" & FormatSQL(z3440.CheckMarketType) & "', "
            SQL = SQL & "    K3440_seDepartment      = N'" & FormatSQL(z3440.seDepartment) & "', "
            SQL = SQL & "    K3440_cdDepartment      = N'" & FormatSQL(z3440.cdDepartment) & "', "
            SQL = SQL & "    K3440_InchargeInvoice      = N'" & FormatSQL(z3440.InchargeInvoice) & "', "
            SQL = SQL & "    K3440_seUnitPrice      = N'" & FormatSQL(z3440.seUnitPrice) & "', "
            SQL = SQL & "    K3440_cdUnitPrice      = N'" & FormatSQL(z3440.cdUnitPrice) & "', "
            SQL = SQL & "    K3440_CustomerName      = N'" & FormatSQL(z3440.CustomerName) & "', "
            SQL = SQL & "    K3440_DestinationID      = N'" & FormatSQL(z3440.DestinationID) & "', "
            SQL = SQL & "    K3440_Remarks      = N'" & FormatSQL(z3440.Remarks) & "', "
            SQL = SQL & "    K3440_seSite      = N'" & FormatSQL(z3440.seSite) & "', "
            SQL = SQL & "    K3440_cdSite      = N'" & FormatSQL(z3440.cdSite) & "', "
            SQL = SQL & "    K3440_ShipFrom      = N'" & FormatSQL(z3440.ShipFrom) & "', "
            SQL = SQL & "    K3440_ShipTo      = N'" & FormatSQL(z3440.ShipTo) & "', "
            SQL = SQL & "    K3440_ShipMark      = N'" & FormatSQL(z3440.ShipMark) & "', "
            SQL = SQL & "    K3440_Shipper      = N'" & FormatSQL(z3440.Shipper) & "', "
            SQL = SQL & "    K3440_sePaymentDay      = N'" & FormatSQL(z3440.sePaymentDay) & "', "
            SQL = SQL & "    K3440_cdPaymentDay      = N'" & FormatSQL(z3440.cdPaymentDay) & "', "
            SQL = SQL & "    K3440_VisAllName      = N'" & FormatSQL(z3440.VisAllName) & "', "
            SQL = SQL & "    K3440_VisAllNo      = N'" & FormatSQL(z3440.VisAllNo) & "', "
            SQL = SQL & "    K3440_Buyer      = N'" & FormatSQL(z3440.Buyer) & "', "
            SQL = SQL & "    K3440_FlightNo      = N'" & FormatSQL(z3440.FlightNo) & "', "
            SQL = SQL & "    K3440_HAWB      = N'" & FormatSQL(z3440.HAWB) & "', "
            SQL = SQL & "    K3440_Status      = N'" & FormatSQL(z3440.Status) & "', "
            SQL = SQL & "    K3440_DateInsert      = N'" & FormatSQL(z3440.DateInsert) & "', "
            SQL = SQL & "    K3440_DateUpdate      = N'" & FormatSQL(z3440.DateUpdate) & "', "
            SQL = SQL & "    K3440_InchargeInsert      = N'" & FormatSQL(z3440.InchargeInsert) & "', "
            SQL = SQL & "    K3440_InchargeUpdate      = N'" & FormatSQL(z3440.InchargeUpdate) & "', "
            SQL = SQL & "    K3440_TimeInsert      = N'" & FormatSQL(z3440.TimeInsert) & "', "
            SQL = SQL & "    K3440_TimeUpdate      = N'" & FormatSQL(z3440.TimeUpdate) & "'  "
            SQL = SQL & " WHERE K3440_InvoiceNo		 = '" & z3440.InvoiceNo & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK3440 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK3440", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK3440(z3440 As T3440_AREA) As Boolean
        DELETE_PFK3440 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK3440 "
            SQL = SQL & " WHERE K3440_InvoiceNo		 = '" & z3440.InvoiceNo & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK3440 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK3440", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D3440_CLEAR()
        Try

            D3440.InvoiceNo = ""
            D3440.TransferType = ""
            D3440.DateInvoice = ""
            D3440.InvoiceNoMaster = ""
            D3440.ContainerNo = ""
            D3440.CustomerCode = ""
            D3440.DateETA = ""
            D3440.DateETD = ""
            D3440.DateFlight = ""
            D3440.DateBooking = ""
            D3440.BookingNo = ""
            D3440.CheckMarketType = ""
            D3440.seDepartment = ""
            D3440.cdDepartment = ""
            D3440.InchargeInvoice = ""
            D3440.seUnitPrice = ""
            D3440.cdUnitPrice = ""
            D3440.CustomerName = ""
            D3440.DestinationID = ""
            D3440.Remarks = ""
            D3440.seSite = ""
            D3440.cdSite = ""
            D3440.ShipFrom = ""
            D3440.ShipTo = ""
            D3440.ShipMark = ""
            D3440.Shipper = ""
            D3440.sePaymentDay = ""
            D3440.cdPaymentDay = ""
            D3440.VisAllName = ""
            D3440.VisAllNo = ""
            D3440.Buyer = ""
            D3440.FlightNo = ""
            D3440.HAWB = ""
            D3440.Status = ""
            D3440.DateInsert = ""
            D3440.DateUpdate = ""
            D3440.InchargeInsert = ""
            D3440.InchargeUpdate = ""
            D3440.TimeInsert = ""
            D3440.TimeUpdate = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D3440_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x3440 As T3440_AREA)
        Try

            x3440.InvoiceNo = trim$(x3440.InvoiceNo)
            x3440.TransferType = trim$(x3440.TransferType)
            x3440.DateInvoice = trim$(x3440.DateInvoice)
            x3440.InvoiceNoMaster = trim$(x3440.InvoiceNoMaster)
            x3440.ContainerNo = trim$(x3440.ContainerNo)
            x3440.CustomerCode = trim$(x3440.CustomerCode)
            x3440.DateETA = trim$(x3440.DateETA)
            x3440.DateETD = trim$(x3440.DateETD)
            x3440.DateFlight = trim$(x3440.DateFlight)
            x3440.DateBooking = trim$(x3440.DateBooking)
            x3440.BookingNo = trim$(x3440.BookingNo)
            x3440.CheckMarketType = trim$(x3440.CheckMarketType)
            x3440.seDepartment = trim$(x3440.seDepartment)
            x3440.cdDepartment = trim$(x3440.cdDepartment)
            x3440.InchargeInvoice = trim$(x3440.InchargeInvoice)
            x3440.seUnitPrice = trim$(x3440.seUnitPrice)
            x3440.cdUnitPrice = trim$(x3440.cdUnitPrice)
            x3440.CustomerName = trim$(x3440.CustomerName)
            x3440.DestinationID = trim$(x3440.DestinationID)
            x3440.Remarks = trim$(x3440.Remarks)
            x3440.seSite = trim$(x3440.seSite)
            x3440.cdSite = Trim$(x3440.cdSite)
            x3440.ShipFrom = trim$(x3440.ShipFrom)
            x3440.ShipTo = trim$(x3440.ShipTo)
            x3440.ShipMark = trim$(x3440.ShipMark)
            x3440.Shipper = trim$(x3440.Shipper)
            x3440.sePaymentDay = trim$(x3440.sePaymentDay)
            x3440.cdPaymentDay = trim$(x3440.cdPaymentDay)
            x3440.VisAllName = trim$(x3440.VisAllName)
            x3440.VisAllNo = trim$(x3440.VisAllNo)
            x3440.Buyer = trim$(x3440.Buyer)
            x3440.FlightNo = trim$(x3440.FlightNo)
            x3440.HAWB = trim$(x3440.HAWB)
            x3440.Status = trim$(x3440.Status)
            x3440.DateInsert = trim$(x3440.DateInsert)
            x3440.DateUpdate = trim$(x3440.DateUpdate)
            x3440.InchargeInsert = trim$(x3440.InchargeInsert)
            x3440.InchargeUpdate = trim$(x3440.InchargeUpdate)
            x3440.TimeInsert = trim$(x3440.TimeInsert)
            x3440.TimeUpdate = trim$(x3440.TimeUpdate)

            If trim$(x3440.InvoiceNo) = "" Then x3440.InvoiceNo = Space(1)
            If trim$(x3440.TransferType) = "" Then x3440.TransferType = Space(1)
            If trim$(x3440.DateInvoice) = "" Then x3440.DateInvoice = Space(1)
            If trim$(x3440.InvoiceNoMaster) = "" Then x3440.InvoiceNoMaster = Space(1)
            If trim$(x3440.ContainerNo) = "" Then x3440.ContainerNo = Space(1)
            If trim$(x3440.CustomerCode) = "" Then x3440.CustomerCode = Space(1)
            If trim$(x3440.DateETA) = "" Then x3440.DateETA = Space(1)
            If trim$(x3440.DateETD) = "" Then x3440.DateETD = Space(1)
            If trim$(x3440.DateFlight) = "" Then x3440.DateFlight = Space(1)
            If trim$(x3440.DateBooking) = "" Then x3440.DateBooking = Space(1)
            If trim$(x3440.BookingNo) = "" Then x3440.BookingNo = Space(1)
            If trim$(x3440.CheckMarketType) = "" Then x3440.CheckMarketType = Space(1)
            If trim$(x3440.seDepartment) = "" Then x3440.seDepartment = Space(1)
            If trim$(x3440.cdDepartment) = "" Then x3440.cdDepartment = Space(1)
            If trim$(x3440.InchargeInvoice) = "" Then x3440.InchargeInvoice = Space(1)
            If trim$(x3440.seUnitPrice) = "" Then x3440.seUnitPrice = Space(1)
            If trim$(x3440.cdUnitPrice) = "" Then x3440.cdUnitPrice = Space(1)
            If trim$(x3440.CustomerName) = "" Then x3440.CustomerName = Space(1)
            If trim$(x3440.DestinationID) = "" Then x3440.DestinationID = Space(1)
            If trim$(x3440.Remarks) = "" Then x3440.Remarks = Space(1)
            If Trim$(x3440.seSite) = "" Then x3440.seSite = Space(1)
            If Trim$(x3440.cdSite) = "" Then x3440.cdSite = Space(1)
            If trim$(x3440.ShipFrom) = "" Then x3440.ShipFrom = Space(1)
            If trim$(x3440.ShipTo) = "" Then x3440.ShipTo = Space(1)
            If trim$(x3440.ShipMark) = "" Then x3440.ShipMark = Space(1)
            If trim$(x3440.Shipper) = "" Then x3440.Shipper = Space(1)
            If trim$(x3440.sePaymentDay) = "" Then x3440.sePaymentDay = Space(1)
            If trim$(x3440.cdPaymentDay) = "" Then x3440.cdPaymentDay = Space(1)
            If trim$(x3440.VisAllName) = "" Then x3440.VisAllName = Space(1)
            If trim$(x3440.VisAllNo) = "" Then x3440.VisAllNo = Space(1)
            If trim$(x3440.Buyer) = "" Then x3440.Buyer = Space(1)
            If trim$(x3440.FlightNo) = "" Then x3440.FlightNo = Space(1)
            If trim$(x3440.HAWB) = "" Then x3440.HAWB = Space(1)
            If trim$(x3440.Status) = "" Then x3440.Status = Space(1)
            If trim$(x3440.DateInsert) = "" Then x3440.DateInsert = Space(1)
            If trim$(x3440.DateUpdate) = "" Then x3440.DateUpdate = Space(1)
            If trim$(x3440.InchargeInsert) = "" Then x3440.InchargeInsert = Space(1)
            If trim$(x3440.InchargeUpdate) = "" Then x3440.InchargeUpdate = Space(1)
            If trim$(x3440.TimeInsert) = "" Then x3440.TimeInsert = Space(1)
            If trim$(x3440.TimeUpdate) = "" Then x3440.TimeUpdate = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K3440_MOVE(rs3440 As SqlClient.SqlDataReader)
        Try

            Call D3440_CLEAR()

            If IsdbNull(rs3440!K3440_InvoiceNo) = False Then D3440.InvoiceNo = Trim$(rs3440!K3440_InvoiceNo)
            If IsdbNull(rs3440!K3440_TransferType) = False Then D3440.TransferType = Trim$(rs3440!K3440_TransferType)
            If IsdbNull(rs3440!K3440_DateInvoice) = False Then D3440.DateInvoice = Trim$(rs3440!K3440_DateInvoice)
            If IsdbNull(rs3440!K3440_InvoiceNoMaster) = False Then D3440.InvoiceNoMaster = Trim$(rs3440!K3440_InvoiceNoMaster)
            If IsdbNull(rs3440!K3440_ContainerNo) = False Then D3440.ContainerNo = Trim$(rs3440!K3440_ContainerNo)
            If IsdbNull(rs3440!K3440_CustomerCode) = False Then D3440.CustomerCode = Trim$(rs3440!K3440_CustomerCode)
            If IsdbNull(rs3440!K3440_DateETA) = False Then D3440.DateETA = Trim$(rs3440!K3440_DateETA)
            If IsdbNull(rs3440!K3440_DateETD) = False Then D3440.DateETD = Trim$(rs3440!K3440_DateETD)
            If IsdbNull(rs3440!K3440_DateFlight) = False Then D3440.DateFlight = Trim$(rs3440!K3440_DateFlight)
            If IsdbNull(rs3440!K3440_DateBooking) = False Then D3440.DateBooking = Trim$(rs3440!K3440_DateBooking)
            If IsdbNull(rs3440!K3440_BookingNo) = False Then D3440.BookingNo = Trim$(rs3440!K3440_BookingNo)
            If IsdbNull(rs3440!K3440_CheckMarketType) = False Then D3440.CheckMarketType = Trim$(rs3440!K3440_CheckMarketType)
            If IsdbNull(rs3440!K3440_seDepartment) = False Then D3440.seDepartment = Trim$(rs3440!K3440_seDepartment)
            If IsdbNull(rs3440!K3440_cdDepartment) = False Then D3440.cdDepartment = Trim$(rs3440!K3440_cdDepartment)
            If IsdbNull(rs3440!K3440_InchargeInvoice) = False Then D3440.InchargeInvoice = Trim$(rs3440!K3440_InchargeInvoice)
            If IsdbNull(rs3440!K3440_seUnitPrice) = False Then D3440.seUnitPrice = Trim$(rs3440!K3440_seUnitPrice)
            If IsdbNull(rs3440!K3440_cdUnitPrice) = False Then D3440.cdUnitPrice = Trim$(rs3440!K3440_cdUnitPrice)
            If IsdbNull(rs3440!K3440_CustomerName) = False Then D3440.CustomerName = Trim$(rs3440!K3440_CustomerName)
            If IsdbNull(rs3440!K3440_DestinationID) = False Then D3440.DestinationID = Trim$(rs3440!K3440_DestinationID)
            If IsdbNull(rs3440!K3440_Remarks) = False Then D3440.Remarks = Trim$(rs3440!K3440_Remarks)
            If IsDBNull(rs3440!K3440_seSite) = False Then D3440.seSite = Trim$(rs3440!K3440_seSite)
            If IsDBNull(rs3440!K3440_cdSite) = False Then D3440.cdSite = Trim$(rs3440!K3440_cdSite)
            If IsdbNull(rs3440!K3440_ShipFrom) = False Then D3440.ShipFrom = Trim$(rs3440!K3440_ShipFrom)
            If IsdbNull(rs3440!K3440_ShipTo) = False Then D3440.ShipTo = Trim$(rs3440!K3440_ShipTo)
            If IsdbNull(rs3440!K3440_ShipMark) = False Then D3440.ShipMark = Trim$(rs3440!K3440_ShipMark)
            If IsdbNull(rs3440!K3440_Shipper) = False Then D3440.Shipper = Trim$(rs3440!K3440_Shipper)
            If IsdbNull(rs3440!K3440_sePaymentDay) = False Then D3440.sePaymentDay = Trim$(rs3440!K3440_sePaymentDay)
            If IsdbNull(rs3440!K3440_cdPaymentDay) = False Then D3440.cdPaymentDay = Trim$(rs3440!K3440_cdPaymentDay)
            If IsdbNull(rs3440!K3440_VisAllName) = False Then D3440.VisAllName = Trim$(rs3440!K3440_VisAllName)
            If IsdbNull(rs3440!K3440_VisAllNo) = False Then D3440.VisAllNo = Trim$(rs3440!K3440_VisAllNo)
            If IsdbNull(rs3440!K3440_Buyer) = False Then D3440.Buyer = Trim$(rs3440!K3440_Buyer)
            If IsdbNull(rs3440!K3440_FlightNo) = False Then D3440.FlightNo = Trim$(rs3440!K3440_FlightNo)
            If IsdbNull(rs3440!K3440_HAWB) = False Then D3440.HAWB = Trim$(rs3440!K3440_HAWB)
            If IsdbNull(rs3440!K3440_Status) = False Then D3440.Status = Trim$(rs3440!K3440_Status)
            If IsdbNull(rs3440!K3440_DateInsert) = False Then D3440.DateInsert = Trim$(rs3440!K3440_DateInsert)
            If IsdbNull(rs3440!K3440_DateUpdate) = False Then D3440.DateUpdate = Trim$(rs3440!K3440_DateUpdate)
            If IsdbNull(rs3440!K3440_InchargeInsert) = False Then D3440.InchargeInsert = Trim$(rs3440!K3440_InchargeInsert)
            If IsdbNull(rs3440!K3440_InchargeUpdate) = False Then D3440.InchargeUpdate = Trim$(rs3440!K3440_InchargeUpdate)
            If IsdbNull(rs3440!K3440_TimeInsert) = False Then D3440.TimeInsert = Trim$(rs3440!K3440_TimeInsert)
            If IsdbNull(rs3440!K3440_TimeUpdate) = False Then D3440.TimeUpdate = Trim$(rs3440!K3440_TimeUpdate)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3440_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K3440_MOVE(rs3440 As DataRow)
        Try

            Call D3440_CLEAR()

            If IsdbNull(rs3440!K3440_InvoiceNo) = False Then D3440.InvoiceNo = Trim$(rs3440!K3440_InvoiceNo)
            If IsdbNull(rs3440!K3440_TransferType) = False Then D3440.TransferType = Trim$(rs3440!K3440_TransferType)
            If IsdbNull(rs3440!K3440_DateInvoice) = False Then D3440.DateInvoice = Trim$(rs3440!K3440_DateInvoice)
            If IsdbNull(rs3440!K3440_InvoiceNoMaster) = False Then D3440.InvoiceNoMaster = Trim$(rs3440!K3440_InvoiceNoMaster)
            If IsdbNull(rs3440!K3440_ContainerNo) = False Then D3440.ContainerNo = Trim$(rs3440!K3440_ContainerNo)
            If IsdbNull(rs3440!K3440_CustomerCode) = False Then D3440.CustomerCode = Trim$(rs3440!K3440_CustomerCode)
            If IsdbNull(rs3440!K3440_DateETA) = False Then D3440.DateETA = Trim$(rs3440!K3440_DateETA)
            If IsdbNull(rs3440!K3440_DateETD) = False Then D3440.DateETD = Trim$(rs3440!K3440_DateETD)
            If IsdbNull(rs3440!K3440_DateFlight) = False Then D3440.DateFlight = Trim$(rs3440!K3440_DateFlight)
            If IsdbNull(rs3440!K3440_DateBooking) = False Then D3440.DateBooking = Trim$(rs3440!K3440_DateBooking)
            If IsdbNull(rs3440!K3440_BookingNo) = False Then D3440.BookingNo = Trim$(rs3440!K3440_BookingNo)
            If IsdbNull(rs3440!K3440_CheckMarketType) = False Then D3440.CheckMarketType = Trim$(rs3440!K3440_CheckMarketType)
            If IsdbNull(rs3440!K3440_seDepartment) = False Then D3440.seDepartment = Trim$(rs3440!K3440_seDepartment)
            If IsdbNull(rs3440!K3440_cdDepartment) = False Then D3440.cdDepartment = Trim$(rs3440!K3440_cdDepartment)
            If IsdbNull(rs3440!K3440_InchargeInvoice) = False Then D3440.InchargeInvoice = Trim$(rs3440!K3440_InchargeInvoice)
            If IsdbNull(rs3440!K3440_seUnitPrice) = False Then D3440.seUnitPrice = Trim$(rs3440!K3440_seUnitPrice)
            If IsdbNull(rs3440!K3440_cdUnitPrice) = False Then D3440.cdUnitPrice = Trim$(rs3440!K3440_cdUnitPrice)
            If IsdbNull(rs3440!K3440_CustomerName) = False Then D3440.CustomerName = Trim$(rs3440!K3440_CustomerName)
            If IsdbNull(rs3440!K3440_DestinationID) = False Then D3440.DestinationID = Trim$(rs3440!K3440_DestinationID)
            If IsdbNull(rs3440!K3440_Remarks) = False Then D3440.Remarks = Trim$(rs3440!K3440_Remarks)
            If IsDBNull(rs3440!K3440_seSite) = False Then D3440.seSite = Trim$(rs3440!K3440_seSite)
            If IsDBNull(rs3440!K3440_cdSite) = False Then D3440.cdSite = Trim$(rs3440!K3440_cdSite)
            If IsdbNull(rs3440!K3440_ShipFrom) = False Then D3440.ShipFrom = Trim$(rs3440!K3440_ShipFrom)
            If IsdbNull(rs3440!K3440_ShipTo) = False Then D3440.ShipTo = Trim$(rs3440!K3440_ShipTo)
            If IsdbNull(rs3440!K3440_ShipMark) = False Then D3440.ShipMark = Trim$(rs3440!K3440_ShipMark)
            If IsdbNull(rs3440!K3440_Shipper) = False Then D3440.Shipper = Trim$(rs3440!K3440_Shipper)
            If IsdbNull(rs3440!K3440_sePaymentDay) = False Then D3440.sePaymentDay = Trim$(rs3440!K3440_sePaymentDay)
            If IsdbNull(rs3440!K3440_cdPaymentDay) = False Then D3440.cdPaymentDay = Trim$(rs3440!K3440_cdPaymentDay)
            If IsdbNull(rs3440!K3440_VisAllName) = False Then D3440.VisAllName = Trim$(rs3440!K3440_VisAllName)
            If IsdbNull(rs3440!K3440_VisAllNo) = False Then D3440.VisAllNo = Trim$(rs3440!K3440_VisAllNo)
            If IsdbNull(rs3440!K3440_Buyer) = False Then D3440.Buyer = Trim$(rs3440!K3440_Buyer)
            If IsdbNull(rs3440!K3440_FlightNo) = False Then D3440.FlightNo = Trim$(rs3440!K3440_FlightNo)
            If IsdbNull(rs3440!K3440_HAWB) = False Then D3440.HAWB = Trim$(rs3440!K3440_HAWB)
            If IsdbNull(rs3440!K3440_Status) = False Then D3440.Status = Trim$(rs3440!K3440_Status)
            If IsdbNull(rs3440!K3440_DateInsert) = False Then D3440.DateInsert = Trim$(rs3440!K3440_DateInsert)
            If IsdbNull(rs3440!K3440_DateUpdate) = False Then D3440.DateUpdate = Trim$(rs3440!K3440_DateUpdate)
            If IsdbNull(rs3440!K3440_InchargeInsert) = False Then D3440.InchargeInsert = Trim$(rs3440!K3440_InchargeInsert)
            If IsdbNull(rs3440!K3440_InchargeUpdate) = False Then D3440.InchargeUpdate = Trim$(rs3440!K3440_InchargeUpdate)
            If IsdbNull(rs3440!K3440_TimeInsert) = False Then D3440.TimeInsert = Trim$(rs3440!K3440_TimeInsert)
            If IsdbNull(rs3440!K3440_TimeUpdate) = False Then D3440.TimeUpdate = Trim$(rs3440!K3440_TimeUpdate)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3440_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K3440_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3440 As T3440_AREA, INVOICENO As String) As Boolean

        K3440_MOVE = False

        Try
            If READ_PFK3440(INVOICENO) = True Then
                z3440 = D3440
                K3440_MOVE = True
            Else
                z3440 = Nothing
            End If

            If getColumIndex(spr, "InvoiceNo") > -1 Then z3440.InvoiceNo = getDataM(spr, getColumIndex(spr, "InvoiceNo"), xRow)
            If getColumIndex(spr, "TransferType") > -1 Then z3440.TransferType = getDataM(spr, getColumIndex(spr, "TransferType"), xRow)
            If getColumIndex(spr, "DateInvoice") > -1 Then z3440.DateInvoice = getDataM(spr, getColumIndex(spr, "DateInvoice"), xRow)
            If getColumIndex(spr, "InvoiceNoMaster") > -1 Then z3440.InvoiceNoMaster = getDataM(spr, getColumIndex(spr, "InvoiceNoMaster"), xRow)
            If getColumIndex(spr, "ContainerNo") > -1 Then z3440.ContainerNo = getDataM(spr, getColumIndex(spr, "ContainerNo"), xRow)
            If getColumIndex(spr, "CustomerCode") > -1 Then z3440.CustomerCode = getDataM(spr, getColumIndex(spr, "CustomerCode"), xRow)
            If getColumIndex(spr, "DateETA") > -1 Then z3440.DateETA = getDataM(spr, getColumIndex(spr, "DateETA"), xRow)
            If getColumIndex(spr, "DateETD") > -1 Then z3440.DateETD = getDataM(spr, getColumIndex(spr, "DateETD"), xRow)
            If getColumIndex(spr, "DateFlight") > -1 Then z3440.DateFlight = getDataM(spr, getColumIndex(spr, "DateFlight"), xRow)
            If getColumIndex(spr, "DateBooking") > -1 Then z3440.DateBooking = getDataM(spr, getColumIndex(spr, "DateBooking"), xRow)
            If getColumIndex(spr, "BookingNo") > -1 Then z3440.BookingNo = getDataM(spr, getColumIndex(spr, "BookingNo"), xRow)
            If getColumIndex(spr, "CheckMarketType") > -1 Then z3440.CheckMarketType = getDataM(spr, getColumIndex(spr, "CheckMarketType"), xRow)
            If getColumIndex(spr, "seDepartment") > -1 Then z3440.seDepartment = getDataM(spr, getColumIndex(spr, "seDepartment"), xRow)
            If getColumIndex(spr, "cdDepartment") > -1 Then z3440.cdDepartment = getDataM(spr, getColumIndex(spr, "cdDepartment"), xRow)
            If getColumIndex(spr, "InchargeInvoice") > -1 Then z3440.InchargeInvoice = getDataM(spr, getColumIndex(spr, "InchargeInvoice"), xRow)
            If getColumIndex(spr, "seUnitPrice") > -1 Then z3440.seUnitPrice = getDataM(spr, getColumIndex(spr, "seUnitPrice"), xRow)
            If getColumIndex(spr, "cdUnitPrice") > -1 Then z3440.cdUnitPrice = getDataM(spr, getColumIndex(spr, "cdUnitPrice"), xRow)
            If getColumIndex(spr, "CustomerName") > -1 Then z3440.CustomerName = getDataM(spr, getColumIndex(spr, "CustomerName"), xRow)
            If getColumIndex(spr, "DestinationID") > -1 Then z3440.DestinationID = getDataM(spr, getColumIndex(spr, "DestinationID"), xRow)
            If getColumIndex(spr, "Remarks") > -1 Then z3440.Remarks = getDataM(spr, getColumIndex(spr, "Remarks"), xRow)
            If getColumIndex(spr, "seSite") > -1 Then z3440.seSite = getDataM(spr, getColumIndex(spr, "seSite"), xRow)
            If getColumIndex(spr, "cdSite") > -1 Then z3440.cdSite = getDataM(spr, getColumIndex(spr, "cdSite"), xRow)
            If getColumIndex(spr, "ShipFrom") > -1 Then z3440.ShipFrom = getDataM(spr, getColumIndex(spr, "ShipFrom"), xRow)
            If getColumIndex(spr, "ShipTo") > -1 Then z3440.ShipTo = getDataM(spr, getColumIndex(spr, "ShipTo"), xRow)
            If getColumIndex(spr, "ShipMark") > -1 Then z3440.ShipMark = getDataM(spr, getColumIndex(spr, "ShipMark"), xRow)
            If getColumIndex(spr, "Shipper") > -1 Then z3440.Shipper = getDataM(spr, getColumIndex(spr, "Shipper"), xRow)
            If getColumIndex(spr, "sePaymentDay") > -1 Then z3440.sePaymentDay = getDataM(spr, getColumIndex(spr, "sePaymentDay"), xRow)
            If getColumIndex(spr, "cdPaymentDay") > -1 Then z3440.cdPaymentDay = getDataM(spr, getColumIndex(spr, "cdPaymentDay"), xRow)
            If getColumIndex(spr, "VisAllName") > -1 Then z3440.VisAllName = getDataM(spr, getColumIndex(spr, "VisAllName"), xRow)
            If getColumIndex(spr, "VisAllNo") > -1 Then z3440.VisAllNo = getDataM(spr, getColumIndex(spr, "VisAllNo"), xRow)
            If getColumIndex(spr, "Buyer") > -1 Then z3440.Buyer = getDataM(spr, getColumIndex(spr, "Buyer"), xRow)
            If getColumIndex(spr, "FlightNo") > -1 Then z3440.FlightNo = getDataM(spr, getColumIndex(spr, "FlightNo"), xRow)
            If getColumIndex(spr, "HAWB") > -1 Then z3440.HAWB = getDataM(spr, getColumIndex(spr, "HAWB"), xRow)
            If getColumIndex(spr, "Status") > -1 Then z3440.Status = getDataM(spr, getColumIndex(spr, "Status"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z3440.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z3440.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z3440.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z3440.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "TimeInsert") > -1 Then z3440.TimeInsert = getDataM(spr, getColumIndex(spr, "TimeInsert"), xRow)
            If getColumIndex(spr, "TimeUpdate") > -1 Then z3440.TimeUpdate = getDataM(spr, getColumIndex(spr, "TimeUpdate"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3440_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K3440_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3440 As T3440_AREA, CheckClear As Boolean, INVOICENO As String) As Boolean

        K3440_MOVE = False

        Try
            If READ_PFK3440(INVOICENO) = True Then
                z3440 = D3440
                K3440_MOVE = True
            Else
                If CheckClear = True Then z3440 = Nothing
            End If

            If getColumIndex(spr, "InvoiceNo") > -1 Then z3440.InvoiceNo = getDataM(spr, getColumIndex(spr, "InvoiceNo"), xRow)
            If getColumIndex(spr, "TransferType") > -1 Then z3440.TransferType = getDataM(spr, getColumIndex(spr, "TransferType"), xRow)
            If getColumIndex(spr, "DateInvoice") > -1 Then z3440.DateInvoice = getDataM(spr, getColumIndex(spr, "DateInvoice"), xRow)
            If getColumIndex(spr, "InvoiceNoMaster") > -1 Then z3440.InvoiceNoMaster = getDataM(spr, getColumIndex(spr, "InvoiceNoMaster"), xRow)
            If getColumIndex(spr, "ContainerNo") > -1 Then z3440.ContainerNo = getDataM(spr, getColumIndex(spr, "ContainerNo"), xRow)
            If getColumIndex(spr, "CustomerCode") > -1 Then z3440.CustomerCode = getDataM(spr, getColumIndex(spr, "CustomerCode"), xRow)
            If getColumIndex(spr, "DateETA") > -1 Then z3440.DateETA = getDataM(spr, getColumIndex(spr, "DateETA"), xRow)
            If getColumIndex(spr, "DateETD") > -1 Then z3440.DateETD = getDataM(spr, getColumIndex(spr, "DateETD"), xRow)
            If getColumIndex(spr, "DateFlight") > -1 Then z3440.DateFlight = getDataM(spr, getColumIndex(spr, "DateFlight"), xRow)
            If getColumIndex(spr, "DateBooking") > -1 Then z3440.DateBooking = getDataM(spr, getColumIndex(spr, "DateBooking"), xRow)
            If getColumIndex(spr, "BookingNo") > -1 Then z3440.BookingNo = getDataM(spr, getColumIndex(spr, "BookingNo"), xRow)
            If getColumIndex(spr, "CheckMarketType") > -1 Then z3440.CheckMarketType = getDataM(spr, getColumIndex(spr, "CheckMarketType"), xRow)
            If getColumIndex(spr, "seDepartment") > -1 Then z3440.seDepartment = getDataM(spr, getColumIndex(spr, "seDepartment"), xRow)
            If getColumIndex(spr, "cdDepartment") > -1 Then z3440.cdDepartment = getDataM(spr, getColumIndex(spr, "cdDepartment"), xRow)
            If getColumIndex(spr, "InchargeInvoice") > -1 Then z3440.InchargeInvoice = getDataM(spr, getColumIndex(spr, "InchargeInvoice"), xRow)
            If getColumIndex(spr, "seUnitPrice") > -1 Then z3440.seUnitPrice = getDataM(spr, getColumIndex(spr, "seUnitPrice"), xRow)
            If getColumIndex(spr, "cdUnitPrice") > -1 Then z3440.cdUnitPrice = getDataM(spr, getColumIndex(spr, "cdUnitPrice"), xRow)
            If getColumIndex(spr, "CustomerName") > -1 Then z3440.CustomerName = getDataM(spr, getColumIndex(spr, "CustomerName"), xRow)
            If getColumIndex(spr, "DestinationID") > -1 Then z3440.DestinationID = getDataM(spr, getColumIndex(spr, "DestinationID"), xRow)
            If getColumIndex(spr, "Remarks") > -1 Then z3440.Remarks = getDataM(spr, getColumIndex(spr, "Remarks"), xRow)
            If getColumIndex(spr, "seSite") > -1 Then z3440.seSite = getDataM(spr, getColumIndex(spr, "seSite"), xRow)
            If getColumIndex(spr, "cdSite") > -1 Then z3440.cdSite = getDataM(spr, getColumIndex(spr, "cdSite"), xRow)
            If getColumIndex(spr, "ShipFrom") > -1 Then z3440.ShipFrom = getDataM(spr, getColumIndex(spr, "ShipFrom"), xRow)
            If getColumIndex(spr, "ShipTo") > -1 Then z3440.ShipTo = getDataM(spr, getColumIndex(spr, "ShipTo"), xRow)
            If getColumIndex(spr, "ShipMark") > -1 Then z3440.ShipMark = getDataM(spr, getColumIndex(spr, "ShipMark"), xRow)
            If getColumIndex(spr, "Shipper") > -1 Then z3440.Shipper = getDataM(spr, getColumIndex(spr, "Shipper"), xRow)
            If getColumIndex(spr, "sePaymentDay") > -1 Then z3440.sePaymentDay = getDataM(spr, getColumIndex(spr, "sePaymentDay"), xRow)
            If getColumIndex(spr, "cdPaymentDay") > -1 Then z3440.cdPaymentDay = getDataM(spr, getColumIndex(spr, "cdPaymentDay"), xRow)
            If getColumIndex(spr, "VisAllName") > -1 Then z3440.VisAllName = getDataM(spr, getColumIndex(spr, "VisAllName"), xRow)
            If getColumIndex(spr, "VisAllNo") > -1 Then z3440.VisAllNo = getDataM(spr, getColumIndex(spr, "VisAllNo"), xRow)
            If getColumIndex(spr, "Buyer") > -1 Then z3440.Buyer = getDataM(spr, getColumIndex(spr, "Buyer"), xRow)
            If getColumIndex(spr, "FlightNo") > -1 Then z3440.FlightNo = getDataM(spr, getColumIndex(spr, "FlightNo"), xRow)
            If getColumIndex(spr, "HAWB") > -1 Then z3440.HAWB = getDataM(spr, getColumIndex(spr, "HAWB"), xRow)
            If getColumIndex(spr, "Status") > -1 Then z3440.Status = getDataM(spr, getColumIndex(spr, "Status"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z3440.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z3440.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z3440.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z3440.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "TimeInsert") > -1 Then z3440.TimeInsert = getDataM(spr, getColumIndex(spr, "TimeInsert"), xRow)
            If getColumIndex(spr, "TimeUpdate") > -1 Then z3440.TimeUpdate = getDataM(spr, getColumIndex(spr, "TimeUpdate"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3440_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K3440_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3440 As T3440_AREA, Job As String, INVOICENO As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3440_MOVE = False

        Try
            If READ_PFK3440(INVOICENO) = True Then
                z3440 = D3440
                K3440_MOVE = True
            Else
                z3440 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3440")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "INVOICENO" : z3440.InvoiceNo = Children(i).Code
                                Case "TRANSFERTYPE" : z3440.TransferType = Children(i).Code
                                Case "DATEINVOICE" : z3440.DateInvoice = Children(i).Code
                                Case "INVOICENOMASTER" : z3440.InvoiceNoMaster = Children(i).Code
                                Case "CONTAINERNO" : z3440.ContainerNo = Children(i).Code
                                Case "CUSTOMERCODE" : z3440.CustomerCode = Children(i).Code
                                Case "DATEETA" : z3440.DateETA = Children(i).Code
                                Case "DATEETD" : z3440.DateETD = Children(i).Code
                                Case "DATEFLIGHT" : z3440.DateFlight = Children(i).Code
                                Case "DATEBOOKING" : z3440.DateBooking = Children(i).Code
                                Case "BOOKINGNO" : z3440.BookingNo = Children(i).Code
                                Case "CHECKMARKETTYPE" : z3440.CheckMarketType = Children(i).Code
                                Case "SEDEPARTMENT" : z3440.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z3440.cdDepartment = Children(i).Code
                                Case "INCHARGEINVOICE" : z3440.InchargeInvoice = Children(i).Code
                                Case "SEUNITPRICE" : z3440.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z3440.cdUnitPrice = Children(i).Code
                                Case "CUSTOMERNAME" : z3440.CustomerName = Children(i).Code
                                Case "DESTINATIONID" : z3440.DestinationID = Children(i).Code
                                Case "REMARKS" : z3440.Remarks = Children(i).Code
                                Case "SESITE" : z3440.seSite = Children(i).Code
                                Case "CDSITE" : z3440.cdSite = Children(i).Code
                                Case "SHIPFROM" : z3440.ShipFrom = Children(i).Code
                                Case "SHIPTO" : z3440.ShipTo = Children(i).Code
                                Case "SHIPMARK" : z3440.ShipMark = Children(i).Code
                                Case "SHIPPER" : z3440.Shipper = Children(i).Code
                                Case "SEPAYMENTDAY" : z3440.sePaymentDay = Children(i).Code
                                Case "CDPAYMENTDAY" : z3440.cdPaymentDay = Children(i).Code
                                Case "VISALLNAME" : z3440.VisAllName = Children(i).Code
                                Case "VISALLNO" : z3440.VisAllNo = Children(i).Code
                                Case "BUYER" : z3440.Buyer = Children(i).Code
                                Case "FLIGHTNO" : z3440.FlightNo = Children(i).Code
                                Case "HAWB" : z3440.HAWB = Children(i).Code
                                Case "STATUS" : z3440.Status = Children(i).Code
                                Case "DATEINSERT" : z3440.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z3440.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z3440.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z3440.InchargeUpdate = Children(i).Code
                                Case "TIMEINSERT" : z3440.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z3440.TimeUpdate = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "INVOICENO" : z3440.InvoiceNo = Children(i).Data
                                Case "TRANSFERTYPE" : z3440.TransferType = Children(i).Data
                                Case "DATEINVOICE" : z3440.DateInvoice = Children(i).Data
                                Case "INVOICENOMASTER" : z3440.InvoiceNoMaster = Children(i).Data
                                Case "CONTAINERNO" : z3440.ContainerNo = Children(i).Data
                                Case "CUSTOMERCODE" : z3440.CustomerCode = Children(i).Data
                                Case "DATEETA" : z3440.DateETA = Children(i).Data
                                Case "DATEETD" : z3440.DateETD = Children(i).Data
                                Case "DATEFLIGHT" : z3440.DateFlight = Children(i).Data
                                Case "DATEBOOKING" : z3440.DateBooking = Children(i).Data
                                Case "BOOKINGNO" : z3440.BookingNo = Children(i).Data
                                Case "CHECKMARKETTYPE" : z3440.CheckMarketType = Children(i).Data
                                Case "SEDEPARTMENT" : z3440.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z3440.cdDepartment = Children(i).Data
                                Case "INCHARGEINVOICE" : z3440.InchargeInvoice = Children(i).Data
                                Case "SEUNITPRICE" : z3440.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z3440.cdUnitPrice = Children(i).Data
                                Case "CUSTOMERNAME" : z3440.CustomerName = Children(i).Data
                                Case "DESTINATIONID" : z3440.DestinationID = Children(i).Data
                                Case "REMARKS" : z3440.Remarks = Children(i).Data
                                Case "SESITE" : z3440.seSite = Children(i).Data
                                Case "CDSITE" : z3440.cdSite = Children(i).Data
                                Case "SHIPFROM" : z3440.ShipFrom = Children(i).Data
                                Case "SHIPTO" : z3440.ShipTo = Children(i).Data
                                Case "SHIPMARK" : z3440.ShipMark = Children(i).Data
                                Case "SHIPPER" : z3440.Shipper = Children(i).Data
                                Case "SEPAYMENTDAY" : z3440.sePaymentDay = Children(i).Data
                                Case "CDPAYMENTDAY" : z3440.cdPaymentDay = Children(i).Data
                                Case "VISALLNAME" : z3440.VisAllName = Children(i).Data
                                Case "VISALLNO" : z3440.VisAllNo = Children(i).Data
                                Case "BUYER" : z3440.Buyer = Children(i).Data
                                Case "FLIGHTNO" : z3440.FlightNo = Children(i).Data
                                Case "HAWB" : z3440.HAWB = Children(i).Data
                                Case "STATUS" : z3440.Status = Children(i).Data
                                Case "DATEINSERT" : z3440.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z3440.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z3440.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z3440.InchargeUpdate = Children(i).Data
                                Case "TIMEINSERT" : z3440.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z3440.TimeUpdate = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3440_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K3440_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3440 As T3440_AREA, Job As String, CheckClear As Boolean, INVOICENO As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3440_MOVE = False

        Try
            If READ_PFK3440(INVOICENO) = True Then
                z3440 = D3440
                K3440_MOVE = True
            Else
                If CheckClear = True Then z3440 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3440")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "INVOICENO" : z3440.InvoiceNo = Children(i).Code
                                Case "TRANSFERTYPE" : z3440.TransferType = Children(i).Code
                                Case "DATEINVOICE" : z3440.DateInvoice = Children(i).Code
                                Case "INVOICENOMASTER" : z3440.InvoiceNoMaster = Children(i).Code
                                Case "CONTAINERNO" : z3440.ContainerNo = Children(i).Code
                                Case "CUSTOMERCODE" : z3440.CustomerCode = Children(i).Code
                                Case "DATEETA" : z3440.DateETA = Children(i).Code
                                Case "DATEETD" : z3440.DateETD = Children(i).Code
                                Case "DATEFLIGHT" : z3440.DateFlight = Children(i).Code
                                Case "DATEBOOKING" : z3440.DateBooking = Children(i).Code
                                Case "BOOKINGNO" : z3440.BookingNo = Children(i).Code
                                Case "CHECKMARKETTYPE" : z3440.CheckMarketType = Children(i).Code
                                Case "SEDEPARTMENT" : z3440.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z3440.cdDepartment = Children(i).Code
                                Case "INCHARGEINVOICE" : z3440.InchargeInvoice = Children(i).Code
                                Case "SEUNITPRICE" : z3440.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z3440.cdUnitPrice = Children(i).Code
                                Case "CUSTOMERNAME" : z3440.CustomerName = Children(i).Code
                                Case "DESTINATIONID" : z3440.DestinationID = Children(i).Code
                                Case "REMARKS" : z3440.Remarks = Children(i).Code
                                Case "SESITE" : z3440.seSite = Children(i).Code
                                Case "CDSITE" : z3440.cdSite = Children(i).Code
                                Case "SHIPFROM" : z3440.ShipFrom = Children(i).Code
                                Case "SHIPTO" : z3440.ShipTo = Children(i).Code
                                Case "SHIPMARK" : z3440.ShipMark = Children(i).Code
                                Case "SHIPPER" : z3440.Shipper = Children(i).Code
                                Case "SEPAYMENTDAY" : z3440.sePaymentDay = Children(i).Code
                                Case "CDPAYMENTDAY" : z3440.cdPaymentDay = Children(i).Code
                                Case "VISALLNAME" : z3440.VisAllName = Children(i).Code
                                Case "VISALLNO" : z3440.VisAllNo = Children(i).Code
                                Case "BUYER" : z3440.Buyer = Children(i).Code
                                Case "FLIGHTNO" : z3440.FlightNo = Children(i).Code
                                Case "HAWB" : z3440.HAWB = Children(i).Code
                                Case "STATUS" : z3440.Status = Children(i).Code
                                Case "DATEINSERT" : z3440.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z3440.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z3440.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z3440.InchargeUpdate = Children(i).Code
                                Case "TIMEINSERT" : z3440.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z3440.TimeUpdate = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "INVOICENO" : z3440.InvoiceNo = Children(i).Data
                                Case "TRANSFERTYPE" : z3440.TransferType = Children(i).Data
                                Case "DATEINVOICE" : z3440.DateInvoice = Children(i).Data
                                Case "INVOICENOMASTER" : z3440.InvoiceNoMaster = Children(i).Data
                                Case "CONTAINERNO" : z3440.ContainerNo = Children(i).Data
                                Case "CUSTOMERCODE" : z3440.CustomerCode = Children(i).Data
                                Case "DATEETA" : z3440.DateETA = Children(i).Data
                                Case "DATEETD" : z3440.DateETD = Children(i).Data
                                Case "DATEFLIGHT" : z3440.DateFlight = Children(i).Data
                                Case "DATEBOOKING" : z3440.DateBooking = Children(i).Data
                                Case "BOOKINGNO" : z3440.BookingNo = Children(i).Data
                                Case "CHECKMARKETTYPE" : z3440.CheckMarketType = Children(i).Data
                                Case "SEDEPARTMENT" : z3440.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z3440.cdDepartment = Children(i).Data
                                Case "INCHARGEINVOICE" : z3440.InchargeInvoice = Children(i).Data
                                Case "SEUNITPRICE" : z3440.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z3440.cdUnitPrice = Children(i).Data
                                Case "CUSTOMERNAME" : z3440.CustomerName = Children(i).Data
                                Case "DESTINATIONID" : z3440.DestinationID = Children(i).Data
                                Case "REMARKS" : z3440.Remarks = Children(i).Data
                                Case "SESITE" : z3440.seSite = Children(i).Data
                                Case "CDSITE" : z3440.cdSite = Children(i).Data
                                Case "SHIPFROM" : z3440.ShipFrom = Children(i).Data
                                Case "SHIPTO" : z3440.ShipTo = Children(i).Data
                                Case "SHIPMARK" : z3440.ShipMark = Children(i).Data
                                Case "SHIPPER" : z3440.Shipper = Children(i).Data
                                Case "SEPAYMENTDAY" : z3440.sePaymentDay = Children(i).Data
                                Case "CDPAYMENTDAY" : z3440.cdPaymentDay = Children(i).Data
                                Case "VISALLNAME" : z3440.VisAllName = Children(i).Data
                                Case "VISALLNO" : z3440.VisAllNo = Children(i).Data
                                Case "BUYER" : z3440.Buyer = Children(i).Data
                                Case "FLIGHTNO" : z3440.FlightNo = Children(i).Data
                                Case "HAWB" : z3440.HAWB = Children(i).Data
                                Case "STATUS" : z3440.Status = Children(i).Data
                                Case "DATEINSERT" : z3440.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z3440.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z3440.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z3440.InchargeUpdate = Children(i).Data
                                Case "TIMEINSERT" : z3440.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z3440.TimeUpdate = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3440_MOVE", vbCritical)
        End Try
    End Function

End Module
