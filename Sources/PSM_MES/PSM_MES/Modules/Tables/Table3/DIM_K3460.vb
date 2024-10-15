'=========================================================================================================================================================
'   TABLE : (PFK3460)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3460

    Structure T3460_AREA
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

    Public D3460 As T3460_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK3460(INVOICENO As String) As Boolean
        READ_PFK3460 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3460 "
            SQL = SQL & " WHERE K3460_InvoiceNo		 = '" & InvoiceNo & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3460_CLEAR() : GoTo SKIP_READ_PFK3460

            Call K3460_MOVE(rd)
            READ_PFK3460 = True

SKIP_READ_PFK3460:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3460", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK3460(INVOICENO As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3460 "
            SQL = SQL & " WHERE K3460_InvoiceNo		 = '" & InvoiceNo & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK3460", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK3460(z3460 As T3460_AREA) As Boolean
        WRITE_PFK3460 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3460)

            SQL = " INSERT INTO PFK3460 "
            SQL = SQL & " ( "
            SQL = SQL & " K3460_InvoiceNo,"
            SQL = SQL & " K3460_TransferType,"
            SQL = SQL & " K3460_DateInvoice,"
            SQL = SQL & " K3460_InvoiceNoMaster,"
            SQL = SQL & " K3460_ContainerNo,"
            SQL = SQL & " K3460_CustomerCode,"
            SQL = SQL & " K3460_DateETA,"
            SQL = SQL & " K3460_DateETD,"
            SQL = SQL & " K3460_DateFlight,"
            SQL = SQL & " K3460_DateBooking,"
            SQL = SQL & " K3460_BookingNo,"
            SQL = SQL & " K3460_CheckMarketType,"
            SQL = SQL & " K3460_seDepartment,"
            SQL = SQL & " K3460_cdDepartment,"
            SQL = SQL & " K3460_InchargeInvoice,"
            SQL = SQL & " K3460_seUnitPrice,"
            SQL = SQL & " K3460_cdUnitPrice,"
            SQL = SQL & " K3460_CustomerName,"
            SQL = SQL & " K3460_DestinationID,"
            SQL = SQL & " K3460_Remarks,"
            SQL = SQL & " K3460_seSite,"
            SQL = SQL & " K3460_cdSite,"
            SQL = SQL & " K3460_ShipFrom,"
            SQL = SQL & " K3460_ShipTo,"
            SQL = SQL & " K3460_ShipMark,"
            SQL = SQL & " K3460_Shipper,"
            SQL = SQL & " K3460_sePaymentDay,"
            SQL = SQL & " K3460_cdPaymentDay,"
            SQL = SQL & " K3460_VisAllName,"
            SQL = SQL & " K3460_VisAllNo,"
            SQL = SQL & " K3460_Buyer,"
            SQL = SQL & " K3460_FlightNo,"
            SQL = SQL & " K3460_HAWB,"
            SQL = SQL & " K3460_Status,"
            SQL = SQL & " K3460_DateInsert,"
            SQL = SQL & " K3460_DateUpdate,"
            SQL = SQL & " K3460_InchargeInsert,"
            SQL = SQL & " K3460_InchargeUpdate,"
            SQL = SQL & " K3460_TimeInsert,"
            SQL = SQL & " K3460_TimeUpdate "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z3460.InvoiceNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.TransferType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.DateInvoice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.InvoiceNoMaster) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.ContainerNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.CustomerCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.DateETA) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.DateETD) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.DateFlight) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.DateBooking) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.BookingNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.CheckMarketType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.seDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.cdDepartment) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.InchargeInvoice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.seUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.cdUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.CustomerName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.DestinationID) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.Remarks) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.seSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.cdSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.ShipFrom) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.ShipTo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.ShipMark) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.Shipper) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.sePaymentDay) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.cdPaymentDay) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.VisAllName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.VisAllNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.Buyer) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.FlightNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.HAWB) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.Status) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.DateInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.InchargeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.TimeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3460.TimeUpdate) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK3460 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK3460", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK3460(z3460 As T3460_AREA) As Boolean
        REWRITE_PFK3460 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3460)

            SQL = " UPDATE PFK3460 SET "
            SQL = SQL & "    K3460_TransferType      = N'" & FormatSQL(z3460.TransferType) & "', "
            SQL = SQL & "    K3460_DateInvoice      = N'" & FormatSQL(z3460.DateInvoice) & "', "
            SQL = SQL & "    K3460_InvoiceNoMaster      = N'" & FormatSQL(z3460.InvoiceNoMaster) & "', "
            SQL = SQL & "    K3460_ContainerNo      = N'" & FormatSQL(z3460.ContainerNo) & "', "
            SQL = SQL & "    K3460_CustomerCode      = N'" & FormatSQL(z3460.CustomerCode) & "', "
            SQL = SQL & "    K3460_DateETA      = N'" & FormatSQL(z3460.DateETA) & "', "
            SQL = SQL & "    K3460_DateETD      = N'" & FormatSQL(z3460.DateETD) & "', "
            SQL = SQL & "    K3460_DateFlight      = N'" & FormatSQL(z3460.DateFlight) & "', "
            SQL = SQL & "    K3460_DateBooking      = N'" & FormatSQL(z3460.DateBooking) & "', "
            SQL = SQL & "    K3460_BookingNo      = N'" & FormatSQL(z3460.BookingNo) & "', "
            SQL = SQL & "    K3460_CheckMarketType      = N'" & FormatSQL(z3460.CheckMarketType) & "', "
            SQL = SQL & "    K3460_seDepartment      = N'" & FormatSQL(z3460.seDepartment) & "', "
            SQL = SQL & "    K3460_cdDepartment      = N'" & FormatSQL(z3460.cdDepartment) & "', "
            SQL = SQL & "    K3460_InchargeInvoice      = N'" & FormatSQL(z3460.InchargeInvoice) & "', "
            SQL = SQL & "    K3460_seUnitPrice      = N'" & FormatSQL(z3460.seUnitPrice) & "', "
            SQL = SQL & "    K3460_cdUnitPrice      = N'" & FormatSQL(z3460.cdUnitPrice) & "', "
            SQL = SQL & "    K3460_CustomerName      = N'" & FormatSQL(z3460.CustomerName) & "', "
            SQL = SQL & "    K3460_DestinationID      = N'" & FormatSQL(z3460.DestinationID) & "', "
            SQL = SQL & "    K3460_Remarks      = N'" & FormatSQL(z3460.Remarks) & "', "
            SQL = SQL & "    K3460_seSite      = N'" & FormatSQL(z3460.seSite) & "', "
            SQL = SQL & "    K3460_cdSite      = N'" & FormatSQL(z3460.cdSite) & "', "
            SQL = SQL & "    K3460_ShipFrom      = N'" & FormatSQL(z3460.ShipFrom) & "', "
            SQL = SQL & "    K3460_ShipTo      = N'" & FormatSQL(z3460.ShipTo) & "', "
            SQL = SQL & "    K3460_ShipMark      = N'" & FormatSQL(z3460.ShipMark) & "', "
            SQL = SQL & "    K3460_Shipper      = N'" & FormatSQL(z3460.Shipper) & "', "
            SQL = SQL & "    K3460_sePaymentDay      = N'" & FormatSQL(z3460.sePaymentDay) & "', "
            SQL = SQL & "    K3460_cdPaymentDay      = N'" & FormatSQL(z3460.cdPaymentDay) & "', "
            SQL = SQL & "    K3460_VisAllName      = N'" & FormatSQL(z3460.VisAllName) & "', "
            SQL = SQL & "    K3460_VisAllNo      = N'" & FormatSQL(z3460.VisAllNo) & "', "
            SQL = SQL & "    K3460_Buyer      = N'" & FormatSQL(z3460.Buyer) & "', "
            SQL = SQL & "    K3460_FlightNo      = N'" & FormatSQL(z3460.FlightNo) & "', "
            SQL = SQL & "    K3460_HAWB      = N'" & FormatSQL(z3460.HAWB) & "', "
            SQL = SQL & "    K3460_Status      = N'" & FormatSQL(z3460.Status) & "', "
            SQL = SQL & "    K3460_DateInsert      = N'" & FormatSQL(z3460.DateInsert) & "', "
            SQL = SQL & "    K3460_DateUpdate      = N'" & FormatSQL(z3460.DateUpdate) & "', "
            SQL = SQL & "    K3460_InchargeInsert      = N'" & FormatSQL(z3460.InchargeInsert) & "', "
            SQL = SQL & "    K3460_InchargeUpdate      = N'" & FormatSQL(z3460.InchargeUpdate) & "', "
            SQL = SQL & "    K3460_TimeInsert      = N'" & FormatSQL(z3460.TimeInsert) & "', "
            SQL = SQL & "    K3460_TimeUpdate      = N'" & FormatSQL(z3460.TimeUpdate) & "'  "
            SQL = SQL & " WHERE K3460_InvoiceNo		 = '" & z3460.InvoiceNo & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK3460 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK3460", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK3460(z3460 As T3460_AREA) As Boolean
        DELETE_PFK3460 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK3460 "
            SQL = SQL & " WHERE K3460_InvoiceNo		 = '" & z3460.InvoiceNo & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK3460 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK3460", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D3460_CLEAR()
        Try

            D3460.InvoiceNo = ""
            D3460.TransferType = ""
            D3460.DateInvoice = ""
            D3460.InvoiceNoMaster = ""
            D3460.ContainerNo = ""
            D3460.CustomerCode = ""
            D3460.DateETA = ""
            D3460.DateETD = ""
            D3460.DateFlight = ""
            D3460.DateBooking = ""
            D3460.BookingNo = ""
            D3460.CheckMarketType = ""
            D3460.seDepartment = ""
            D3460.cdDepartment = ""
            D3460.InchargeInvoice = ""
            D3460.seUnitPrice = ""
            D3460.cdUnitPrice = ""
            D3460.CustomerName = ""
            D3460.DestinationID = ""
            D3460.Remarks = ""
            D3460.seSite = ""
            D3460.cdSite = ""
            D3460.ShipFrom = ""
            D3460.ShipTo = ""
            D3460.ShipMark = ""
            D3460.Shipper = ""
            D3460.sePaymentDay = ""
            D3460.cdPaymentDay = ""
            D3460.VisAllName = ""
            D3460.VisAllNo = ""
            D3460.Buyer = ""
            D3460.FlightNo = ""
            D3460.HAWB = ""
            D3460.Status = ""
            D3460.DateInsert = ""
            D3460.DateUpdate = ""
            D3460.InchargeInsert = ""
            D3460.InchargeUpdate = ""
            D3460.TimeInsert = ""
            D3460.TimeUpdate = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D3460_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x3460 As T3460_AREA)
        Try

            x3460.InvoiceNo = trim$(x3460.InvoiceNo)
            x3460.TransferType = trim$(x3460.TransferType)
            x3460.DateInvoice = trim$(x3460.DateInvoice)
            x3460.InvoiceNoMaster = trim$(x3460.InvoiceNoMaster)
            x3460.ContainerNo = trim$(x3460.ContainerNo)
            x3460.CustomerCode = trim$(x3460.CustomerCode)
            x3460.DateETA = trim$(x3460.DateETA)
            x3460.DateETD = trim$(x3460.DateETD)
            x3460.DateFlight = trim$(x3460.DateFlight)
            x3460.DateBooking = trim$(x3460.DateBooking)
            x3460.BookingNo = trim$(x3460.BookingNo)
            x3460.CheckMarketType = trim$(x3460.CheckMarketType)
            x3460.seDepartment = trim$(x3460.seDepartment)
            x3460.cdDepartment = trim$(x3460.cdDepartment)
            x3460.InchargeInvoice = trim$(x3460.InchargeInvoice)
            x3460.seUnitPrice = trim$(x3460.seUnitPrice)
            x3460.cdUnitPrice = trim$(x3460.cdUnitPrice)
            x3460.CustomerName = trim$(x3460.CustomerName)
            x3460.DestinationID = trim$(x3460.DestinationID)
            x3460.Remarks = trim$(x3460.Remarks)
            x3460.seSite = trim$(x3460.seSite)
            x3460.cdSite = Trim$(x3460.cdSite)
            x3460.ShipFrom = trim$(x3460.ShipFrom)
            x3460.ShipTo = trim$(x3460.ShipTo)
            x3460.ShipMark = trim$(x3460.ShipMark)
            x3460.Shipper = trim$(x3460.Shipper)
            x3460.sePaymentDay = trim$(x3460.sePaymentDay)
            x3460.cdPaymentDay = trim$(x3460.cdPaymentDay)
            x3460.VisAllName = trim$(x3460.VisAllName)
            x3460.VisAllNo = trim$(x3460.VisAllNo)
            x3460.Buyer = trim$(x3460.Buyer)
            x3460.FlightNo = trim$(x3460.FlightNo)
            x3460.HAWB = trim$(x3460.HAWB)
            x3460.Status = trim$(x3460.Status)
            x3460.DateInsert = trim$(x3460.DateInsert)
            x3460.DateUpdate = trim$(x3460.DateUpdate)
            x3460.InchargeInsert = trim$(x3460.InchargeInsert)
            x3460.InchargeUpdate = trim$(x3460.InchargeUpdate)
            x3460.TimeInsert = trim$(x3460.TimeInsert)
            x3460.TimeUpdate = trim$(x3460.TimeUpdate)

            If trim$(x3460.InvoiceNo) = "" Then x3460.InvoiceNo = Space(1)
            If trim$(x3460.TransferType) = "" Then x3460.TransferType = Space(1)
            If trim$(x3460.DateInvoice) = "" Then x3460.DateInvoice = Space(1)
            If trim$(x3460.InvoiceNoMaster) = "" Then x3460.InvoiceNoMaster = Space(1)
            If trim$(x3460.ContainerNo) = "" Then x3460.ContainerNo = Space(1)
            If trim$(x3460.CustomerCode) = "" Then x3460.CustomerCode = Space(1)
            If trim$(x3460.DateETA) = "" Then x3460.DateETA = Space(1)
            If trim$(x3460.DateETD) = "" Then x3460.DateETD = Space(1)
            If trim$(x3460.DateFlight) = "" Then x3460.DateFlight = Space(1)
            If trim$(x3460.DateBooking) = "" Then x3460.DateBooking = Space(1)
            If trim$(x3460.BookingNo) = "" Then x3460.BookingNo = Space(1)
            If trim$(x3460.CheckMarketType) = "" Then x3460.CheckMarketType = Space(1)
            If trim$(x3460.seDepartment) = "" Then x3460.seDepartment = Space(1)
            If trim$(x3460.cdDepartment) = "" Then x3460.cdDepartment = Space(1)
            If trim$(x3460.InchargeInvoice) = "" Then x3460.InchargeInvoice = Space(1)
            If trim$(x3460.seUnitPrice) = "" Then x3460.seUnitPrice = Space(1)
            If trim$(x3460.cdUnitPrice) = "" Then x3460.cdUnitPrice = Space(1)
            If trim$(x3460.CustomerName) = "" Then x3460.CustomerName = Space(1)
            If trim$(x3460.DestinationID) = "" Then x3460.DestinationID = Space(1)
            If trim$(x3460.Remarks) = "" Then x3460.Remarks = Space(1)
            If Trim$(x3460.seSite) = "" Then x3460.seSite = Space(1)
            If Trim$(x3460.cdSite) = "" Then x3460.cdSite = Space(1)
            If trim$(x3460.ShipFrom) = "" Then x3460.ShipFrom = Space(1)
            If trim$(x3460.ShipTo) = "" Then x3460.ShipTo = Space(1)
            If trim$(x3460.ShipMark) = "" Then x3460.ShipMark = Space(1)
            If trim$(x3460.Shipper) = "" Then x3460.Shipper = Space(1)
            If trim$(x3460.sePaymentDay) = "" Then x3460.sePaymentDay = Space(1)
            If trim$(x3460.cdPaymentDay) = "" Then x3460.cdPaymentDay = Space(1)
            If trim$(x3460.VisAllName) = "" Then x3460.VisAllName = Space(1)
            If trim$(x3460.VisAllNo) = "" Then x3460.VisAllNo = Space(1)
            If trim$(x3460.Buyer) = "" Then x3460.Buyer = Space(1)
            If trim$(x3460.FlightNo) = "" Then x3460.FlightNo = Space(1)
            If trim$(x3460.HAWB) = "" Then x3460.HAWB = Space(1)
            If trim$(x3460.Status) = "" Then x3460.Status = Space(1)
            If trim$(x3460.DateInsert) = "" Then x3460.DateInsert = Space(1)
            If trim$(x3460.DateUpdate) = "" Then x3460.DateUpdate = Space(1)
            If trim$(x3460.InchargeInsert) = "" Then x3460.InchargeInsert = Space(1)
            If trim$(x3460.InchargeUpdate) = "" Then x3460.InchargeUpdate = Space(1)
            If trim$(x3460.TimeInsert) = "" Then x3460.TimeInsert = Space(1)
            If trim$(x3460.TimeUpdate) = "" Then x3460.TimeUpdate = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K3460_MOVE(rs3460 As SqlClient.SqlDataReader)
        Try

            Call D3460_CLEAR()

            If IsdbNull(rs3460!K3460_InvoiceNo) = False Then D3460.InvoiceNo = Trim$(rs3460!K3460_InvoiceNo)
            If IsdbNull(rs3460!K3460_TransferType) = False Then D3460.TransferType = Trim$(rs3460!K3460_TransferType)
            If IsdbNull(rs3460!K3460_DateInvoice) = False Then D3460.DateInvoice = Trim$(rs3460!K3460_DateInvoice)
            If IsdbNull(rs3460!K3460_InvoiceNoMaster) = False Then D3460.InvoiceNoMaster = Trim$(rs3460!K3460_InvoiceNoMaster)
            If IsdbNull(rs3460!K3460_ContainerNo) = False Then D3460.ContainerNo = Trim$(rs3460!K3460_ContainerNo)
            If IsdbNull(rs3460!K3460_CustomerCode) = False Then D3460.CustomerCode = Trim$(rs3460!K3460_CustomerCode)
            If IsdbNull(rs3460!K3460_DateETA) = False Then D3460.DateETA = Trim$(rs3460!K3460_DateETA)
            If IsdbNull(rs3460!K3460_DateETD) = False Then D3460.DateETD = Trim$(rs3460!K3460_DateETD)
            If IsdbNull(rs3460!K3460_DateFlight) = False Then D3460.DateFlight = Trim$(rs3460!K3460_DateFlight)
            If IsdbNull(rs3460!K3460_DateBooking) = False Then D3460.DateBooking = Trim$(rs3460!K3460_DateBooking)
            If IsdbNull(rs3460!K3460_BookingNo) = False Then D3460.BookingNo = Trim$(rs3460!K3460_BookingNo)
            If IsdbNull(rs3460!K3460_CheckMarketType) = False Then D3460.CheckMarketType = Trim$(rs3460!K3460_CheckMarketType)
            If IsdbNull(rs3460!K3460_seDepartment) = False Then D3460.seDepartment = Trim$(rs3460!K3460_seDepartment)
            If IsdbNull(rs3460!K3460_cdDepartment) = False Then D3460.cdDepartment = Trim$(rs3460!K3460_cdDepartment)
            If IsdbNull(rs3460!K3460_InchargeInvoice) = False Then D3460.InchargeInvoice = Trim$(rs3460!K3460_InchargeInvoice)
            If IsdbNull(rs3460!K3460_seUnitPrice) = False Then D3460.seUnitPrice = Trim$(rs3460!K3460_seUnitPrice)
            If IsdbNull(rs3460!K3460_cdUnitPrice) = False Then D3460.cdUnitPrice = Trim$(rs3460!K3460_cdUnitPrice)
            If IsdbNull(rs3460!K3460_CustomerName) = False Then D3460.CustomerName = Trim$(rs3460!K3460_CustomerName)
            If IsdbNull(rs3460!K3460_DestinationID) = False Then D3460.DestinationID = Trim$(rs3460!K3460_DestinationID)
            If IsdbNull(rs3460!K3460_Remarks) = False Then D3460.Remarks = Trim$(rs3460!K3460_Remarks)
            If IsDBNull(rs3460!K3460_seSite) = False Then D3460.seSite = Trim$(rs3460!K3460_seSite)
            If IsDBNull(rs3460!K3460_cdSite) = False Then D3460.cdSite = Trim$(rs3460!K3460_cdSite)
            If IsdbNull(rs3460!K3460_ShipFrom) = False Then D3460.ShipFrom = Trim$(rs3460!K3460_ShipFrom)
            If IsdbNull(rs3460!K3460_ShipTo) = False Then D3460.ShipTo = Trim$(rs3460!K3460_ShipTo)
            If IsdbNull(rs3460!K3460_ShipMark) = False Then D3460.ShipMark = Trim$(rs3460!K3460_ShipMark)
            If IsdbNull(rs3460!K3460_Shipper) = False Then D3460.Shipper = Trim$(rs3460!K3460_Shipper)
            If IsdbNull(rs3460!K3460_sePaymentDay) = False Then D3460.sePaymentDay = Trim$(rs3460!K3460_sePaymentDay)
            If IsdbNull(rs3460!K3460_cdPaymentDay) = False Then D3460.cdPaymentDay = Trim$(rs3460!K3460_cdPaymentDay)
            If IsdbNull(rs3460!K3460_VisAllName) = False Then D3460.VisAllName = Trim$(rs3460!K3460_VisAllName)
            If IsdbNull(rs3460!K3460_VisAllNo) = False Then D3460.VisAllNo = Trim$(rs3460!K3460_VisAllNo)
            If IsdbNull(rs3460!K3460_Buyer) = False Then D3460.Buyer = Trim$(rs3460!K3460_Buyer)
            If IsdbNull(rs3460!K3460_FlightNo) = False Then D3460.FlightNo = Trim$(rs3460!K3460_FlightNo)
            If IsdbNull(rs3460!K3460_HAWB) = False Then D3460.HAWB = Trim$(rs3460!K3460_HAWB)
            If IsdbNull(rs3460!K3460_Status) = False Then D3460.Status = Trim$(rs3460!K3460_Status)
            If IsdbNull(rs3460!K3460_DateInsert) = False Then D3460.DateInsert = Trim$(rs3460!K3460_DateInsert)
            If IsdbNull(rs3460!K3460_DateUpdate) = False Then D3460.DateUpdate = Trim$(rs3460!K3460_DateUpdate)
            If IsdbNull(rs3460!K3460_InchargeInsert) = False Then D3460.InchargeInsert = Trim$(rs3460!K3460_InchargeInsert)
            If IsdbNull(rs3460!K3460_InchargeUpdate) = False Then D3460.InchargeUpdate = Trim$(rs3460!K3460_InchargeUpdate)
            If IsdbNull(rs3460!K3460_TimeInsert) = False Then D3460.TimeInsert = Trim$(rs3460!K3460_TimeInsert)
            If IsdbNull(rs3460!K3460_TimeUpdate) = False Then D3460.TimeUpdate = Trim$(rs3460!K3460_TimeUpdate)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3460_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K3460_MOVE(rs3460 As DataRow)
        Try

            Call D3460_CLEAR()

            If IsdbNull(rs3460!K3460_InvoiceNo) = False Then D3460.InvoiceNo = Trim$(rs3460!K3460_InvoiceNo)
            If IsdbNull(rs3460!K3460_TransferType) = False Then D3460.TransferType = Trim$(rs3460!K3460_TransferType)
            If IsdbNull(rs3460!K3460_DateInvoice) = False Then D3460.DateInvoice = Trim$(rs3460!K3460_DateInvoice)
            If IsdbNull(rs3460!K3460_InvoiceNoMaster) = False Then D3460.InvoiceNoMaster = Trim$(rs3460!K3460_InvoiceNoMaster)
            If IsdbNull(rs3460!K3460_ContainerNo) = False Then D3460.ContainerNo = Trim$(rs3460!K3460_ContainerNo)
            If IsdbNull(rs3460!K3460_CustomerCode) = False Then D3460.CustomerCode = Trim$(rs3460!K3460_CustomerCode)
            If IsdbNull(rs3460!K3460_DateETA) = False Then D3460.DateETA = Trim$(rs3460!K3460_DateETA)
            If IsdbNull(rs3460!K3460_DateETD) = False Then D3460.DateETD = Trim$(rs3460!K3460_DateETD)
            If IsdbNull(rs3460!K3460_DateFlight) = False Then D3460.DateFlight = Trim$(rs3460!K3460_DateFlight)
            If IsdbNull(rs3460!K3460_DateBooking) = False Then D3460.DateBooking = Trim$(rs3460!K3460_DateBooking)
            If IsdbNull(rs3460!K3460_BookingNo) = False Then D3460.BookingNo = Trim$(rs3460!K3460_BookingNo)
            If IsdbNull(rs3460!K3460_CheckMarketType) = False Then D3460.CheckMarketType = Trim$(rs3460!K3460_CheckMarketType)
            If IsdbNull(rs3460!K3460_seDepartment) = False Then D3460.seDepartment = Trim$(rs3460!K3460_seDepartment)
            If IsdbNull(rs3460!K3460_cdDepartment) = False Then D3460.cdDepartment = Trim$(rs3460!K3460_cdDepartment)
            If IsdbNull(rs3460!K3460_InchargeInvoice) = False Then D3460.InchargeInvoice = Trim$(rs3460!K3460_InchargeInvoice)
            If IsdbNull(rs3460!K3460_seUnitPrice) = False Then D3460.seUnitPrice = Trim$(rs3460!K3460_seUnitPrice)
            If IsdbNull(rs3460!K3460_cdUnitPrice) = False Then D3460.cdUnitPrice = Trim$(rs3460!K3460_cdUnitPrice)
            If IsdbNull(rs3460!K3460_CustomerName) = False Then D3460.CustomerName = Trim$(rs3460!K3460_CustomerName)
            If IsdbNull(rs3460!K3460_DestinationID) = False Then D3460.DestinationID = Trim$(rs3460!K3460_DestinationID)
            If IsdbNull(rs3460!K3460_Remarks) = False Then D3460.Remarks = Trim$(rs3460!K3460_Remarks)
            If IsDBNull(rs3460!K3460_seSite) = False Then D3460.seSite = Trim$(rs3460!K3460_seSite)
            If IsDBNull(rs3460!K3460_cdSite) = False Then D3460.cdSite = Trim$(rs3460!K3460_cdSite)
            If IsdbNull(rs3460!K3460_ShipFrom) = False Then D3460.ShipFrom = Trim$(rs3460!K3460_ShipFrom)
            If IsdbNull(rs3460!K3460_ShipTo) = False Then D3460.ShipTo = Trim$(rs3460!K3460_ShipTo)
            If IsdbNull(rs3460!K3460_ShipMark) = False Then D3460.ShipMark = Trim$(rs3460!K3460_ShipMark)
            If IsdbNull(rs3460!K3460_Shipper) = False Then D3460.Shipper = Trim$(rs3460!K3460_Shipper)
            If IsdbNull(rs3460!K3460_sePaymentDay) = False Then D3460.sePaymentDay = Trim$(rs3460!K3460_sePaymentDay)
            If IsdbNull(rs3460!K3460_cdPaymentDay) = False Then D3460.cdPaymentDay = Trim$(rs3460!K3460_cdPaymentDay)
            If IsdbNull(rs3460!K3460_VisAllName) = False Then D3460.VisAllName = Trim$(rs3460!K3460_VisAllName)
            If IsdbNull(rs3460!K3460_VisAllNo) = False Then D3460.VisAllNo = Trim$(rs3460!K3460_VisAllNo)
            If IsdbNull(rs3460!K3460_Buyer) = False Then D3460.Buyer = Trim$(rs3460!K3460_Buyer)
            If IsdbNull(rs3460!K3460_FlightNo) = False Then D3460.FlightNo = Trim$(rs3460!K3460_FlightNo)
            If IsdbNull(rs3460!K3460_HAWB) = False Then D3460.HAWB = Trim$(rs3460!K3460_HAWB)
            If IsdbNull(rs3460!K3460_Status) = False Then D3460.Status = Trim$(rs3460!K3460_Status)
            If IsdbNull(rs3460!K3460_DateInsert) = False Then D3460.DateInsert = Trim$(rs3460!K3460_DateInsert)
            If IsdbNull(rs3460!K3460_DateUpdate) = False Then D3460.DateUpdate = Trim$(rs3460!K3460_DateUpdate)
            If IsdbNull(rs3460!K3460_InchargeInsert) = False Then D3460.InchargeInsert = Trim$(rs3460!K3460_InchargeInsert)
            If IsdbNull(rs3460!K3460_InchargeUpdate) = False Then D3460.InchargeUpdate = Trim$(rs3460!K3460_InchargeUpdate)
            If IsdbNull(rs3460!K3460_TimeInsert) = False Then D3460.TimeInsert = Trim$(rs3460!K3460_TimeInsert)
            If IsdbNull(rs3460!K3460_TimeUpdate) = False Then D3460.TimeUpdate = Trim$(rs3460!K3460_TimeUpdate)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3460_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K3460_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3460 As T3460_AREA, INVOICENO As String) As Boolean

        K3460_MOVE = False

        Try
            If READ_PFK3460(INVOICENO) = True Then
                z3460 = D3460
                K3460_MOVE = True
            Else
                z3460 = Nothing
            End If

            If getColumIndex(spr, "InvoiceNo") > -1 Then z3460.InvoiceNo = getDataM(spr, getColumIndex(spr, "InvoiceNo"), xRow)
            If getColumIndex(spr, "TransferType") > -1 Then z3460.TransferType = getDataM(spr, getColumIndex(spr, "TransferType"), xRow)
            If getColumIndex(spr, "DateInvoice") > -1 Then z3460.DateInvoice = getDataM(spr, getColumIndex(spr, "DateInvoice"), xRow)
            If getColumIndex(spr, "InvoiceNoMaster") > -1 Then z3460.InvoiceNoMaster = getDataM(spr, getColumIndex(spr, "InvoiceNoMaster"), xRow)
            If getColumIndex(spr, "ContainerNo") > -1 Then z3460.ContainerNo = getDataM(spr, getColumIndex(spr, "ContainerNo"), xRow)
            If getColumIndex(spr, "CustomerCode") > -1 Then z3460.CustomerCode = getDataM(spr, getColumIndex(spr, "CustomerCode"), xRow)
            If getColumIndex(spr, "DateETA") > -1 Then z3460.DateETA = getDataM(spr, getColumIndex(spr, "DateETA"), xRow)
            If getColumIndex(spr, "DateETD") > -1 Then z3460.DateETD = getDataM(spr, getColumIndex(spr, "DateETD"), xRow)
            If getColumIndex(spr, "DateFlight") > -1 Then z3460.DateFlight = getDataM(spr, getColumIndex(spr, "DateFlight"), xRow)
            If getColumIndex(spr, "DateBooking") > -1 Then z3460.DateBooking = getDataM(spr, getColumIndex(spr, "DateBooking"), xRow)
            If getColumIndex(spr, "BookingNo") > -1 Then z3460.BookingNo = getDataM(spr, getColumIndex(spr, "BookingNo"), xRow)
            If getColumIndex(spr, "CheckMarketType") > -1 Then z3460.CheckMarketType = getDataM(spr, getColumIndex(spr, "CheckMarketType"), xRow)
            If getColumIndex(spr, "seDepartment") > -1 Then z3460.seDepartment = getDataM(spr, getColumIndex(spr, "seDepartment"), xRow)
            If getColumIndex(spr, "cdDepartment") > -1 Then z3460.cdDepartment = getDataM(spr, getColumIndex(spr, "cdDepartment"), xRow)
            If getColumIndex(spr, "InchargeInvoice") > -1 Then z3460.InchargeInvoice = getDataM(spr, getColumIndex(spr, "InchargeInvoice"), xRow)
            If getColumIndex(spr, "seUnitPrice") > -1 Then z3460.seUnitPrice = getDataM(spr, getColumIndex(spr, "seUnitPrice"), xRow)
            If getColumIndex(spr, "cdUnitPrice") > -1 Then z3460.cdUnitPrice = getDataM(spr, getColumIndex(spr, "cdUnitPrice"), xRow)
            If getColumIndex(spr, "CustomerName") > -1 Then z3460.CustomerName = getDataM(spr, getColumIndex(spr, "CustomerName"), xRow)
            If getColumIndex(spr, "DestinationID") > -1 Then z3460.DestinationID = getDataM(spr, getColumIndex(spr, "DestinationID"), xRow)
            If getColumIndex(spr, "Remarks") > -1 Then z3460.Remarks = getDataM(spr, getColumIndex(spr, "Remarks"), xRow)
            If getColumIndex(spr, "seSite") > -1 Then z3460.seSite = getDataM(spr, getColumIndex(spr, "seSite"), xRow)
            If getColumIndex(spr, "cdSite") > -1 Then z3460.cdSite = getDataM(spr, getColumIndex(spr, "cdSite"), xRow)
            If getColumIndex(spr, "ShipFrom") > -1 Then z3460.ShipFrom = getDataM(spr, getColumIndex(spr, "ShipFrom"), xRow)
            If getColumIndex(spr, "ShipTo") > -1 Then z3460.ShipTo = getDataM(spr, getColumIndex(spr, "ShipTo"), xRow)
            If getColumIndex(spr, "ShipMark") > -1 Then z3460.ShipMark = getDataM(spr, getColumIndex(spr, "ShipMark"), xRow)
            If getColumIndex(spr, "Shipper") > -1 Then z3460.Shipper = getDataM(spr, getColumIndex(spr, "Shipper"), xRow)
            If getColumIndex(spr, "sePaymentDay") > -1 Then z3460.sePaymentDay = getDataM(spr, getColumIndex(spr, "sePaymentDay"), xRow)
            If getColumIndex(spr, "cdPaymentDay") > -1 Then z3460.cdPaymentDay = getDataM(spr, getColumIndex(spr, "cdPaymentDay"), xRow)
            If getColumIndex(spr, "VisAllName") > -1 Then z3460.VisAllName = getDataM(spr, getColumIndex(spr, "VisAllName"), xRow)
            If getColumIndex(spr, "VisAllNo") > -1 Then z3460.VisAllNo = getDataM(spr, getColumIndex(spr, "VisAllNo"), xRow)
            If getColumIndex(spr, "Buyer") > -1 Then z3460.Buyer = getDataM(spr, getColumIndex(spr, "Buyer"), xRow)
            If getColumIndex(spr, "FlightNo") > -1 Then z3460.FlightNo = getDataM(spr, getColumIndex(spr, "FlightNo"), xRow)
            If getColumIndex(spr, "HAWB") > -1 Then z3460.HAWB = getDataM(spr, getColumIndex(spr, "HAWB"), xRow)
            If getColumIndex(spr, "Status") > -1 Then z3460.Status = getDataM(spr, getColumIndex(spr, "Status"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z3460.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z3460.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z3460.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z3460.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "TimeInsert") > -1 Then z3460.TimeInsert = getDataM(spr, getColumIndex(spr, "TimeInsert"), xRow)
            If getColumIndex(spr, "TimeUpdate") > -1 Then z3460.TimeUpdate = getDataM(spr, getColumIndex(spr, "TimeUpdate"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3460_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K3460_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3460 As T3460_AREA, CheckClear As Boolean, INVOICENO As String) As Boolean

        K3460_MOVE = False

        Try
            If READ_PFK3460(INVOICENO) = True Then
                z3460 = D3460
                K3460_MOVE = True
            Else
                If CheckClear = True Then z3460 = Nothing
            End If

            If getColumIndex(spr, "InvoiceNo") > -1 Then z3460.InvoiceNo = getDataM(spr, getColumIndex(spr, "InvoiceNo"), xRow)
            If getColumIndex(spr, "TransferType") > -1 Then z3460.TransferType = getDataM(spr, getColumIndex(spr, "TransferType"), xRow)
            If getColumIndex(spr, "DateInvoice") > -1 Then z3460.DateInvoice = getDataM(spr, getColumIndex(spr, "DateInvoice"), xRow)
            If getColumIndex(spr, "InvoiceNoMaster") > -1 Then z3460.InvoiceNoMaster = getDataM(spr, getColumIndex(spr, "InvoiceNoMaster"), xRow)
            If getColumIndex(spr, "ContainerNo") > -1 Then z3460.ContainerNo = getDataM(spr, getColumIndex(spr, "ContainerNo"), xRow)
            If getColumIndex(spr, "CustomerCode") > -1 Then z3460.CustomerCode = getDataM(spr, getColumIndex(spr, "CustomerCode"), xRow)
            If getColumIndex(spr, "DateETA") > -1 Then z3460.DateETA = getDataM(spr, getColumIndex(spr, "DateETA"), xRow)
            If getColumIndex(spr, "DateETD") > -1 Then z3460.DateETD = getDataM(spr, getColumIndex(spr, "DateETD"), xRow)
            If getColumIndex(spr, "DateFlight") > -1 Then z3460.DateFlight = getDataM(spr, getColumIndex(spr, "DateFlight"), xRow)
            If getColumIndex(spr, "DateBooking") > -1 Then z3460.DateBooking = getDataM(spr, getColumIndex(spr, "DateBooking"), xRow)
            If getColumIndex(spr, "BookingNo") > -1 Then z3460.BookingNo = getDataM(spr, getColumIndex(spr, "BookingNo"), xRow)
            If getColumIndex(spr, "CheckMarketType") > -1 Then z3460.CheckMarketType = getDataM(spr, getColumIndex(spr, "CheckMarketType"), xRow)
            If getColumIndex(spr, "seDepartment") > -1 Then z3460.seDepartment = getDataM(spr, getColumIndex(spr, "seDepartment"), xRow)
            If getColumIndex(spr, "cdDepartment") > -1 Then z3460.cdDepartment = getDataM(spr, getColumIndex(spr, "cdDepartment"), xRow)
            If getColumIndex(spr, "InchargeInvoice") > -1 Then z3460.InchargeInvoice = getDataM(spr, getColumIndex(spr, "InchargeInvoice"), xRow)
            If getColumIndex(spr, "seUnitPrice") > -1 Then z3460.seUnitPrice = getDataM(spr, getColumIndex(spr, "seUnitPrice"), xRow)
            If getColumIndex(spr, "cdUnitPrice") > -1 Then z3460.cdUnitPrice = getDataM(spr, getColumIndex(spr, "cdUnitPrice"), xRow)
            If getColumIndex(spr, "CustomerName") > -1 Then z3460.CustomerName = getDataM(spr, getColumIndex(spr, "CustomerName"), xRow)
            If getColumIndex(spr, "DestinationID") > -1 Then z3460.DestinationID = getDataM(spr, getColumIndex(spr, "DestinationID"), xRow)
            If getColumIndex(spr, "Remarks") > -1 Then z3460.Remarks = getDataM(spr, getColumIndex(spr, "Remarks"), xRow)
            If getColumIndex(spr, "seSite") > -1 Then z3460.seSite = getDataM(spr, getColumIndex(spr, "seSite"), xRow)
            If getColumIndex(spr, "cdSite") > -1 Then z3460.cdSite = getDataM(spr, getColumIndex(spr, "cdSite"), xRow)
            If getColumIndex(spr, "ShipFrom") > -1 Then z3460.ShipFrom = getDataM(spr, getColumIndex(spr, "ShipFrom"), xRow)
            If getColumIndex(spr, "ShipTo") > -1 Then z3460.ShipTo = getDataM(spr, getColumIndex(spr, "ShipTo"), xRow)
            If getColumIndex(spr, "ShipMark") > -1 Then z3460.ShipMark = getDataM(spr, getColumIndex(spr, "ShipMark"), xRow)
            If getColumIndex(spr, "Shipper") > -1 Then z3460.Shipper = getDataM(spr, getColumIndex(spr, "Shipper"), xRow)
            If getColumIndex(spr, "sePaymentDay") > -1 Then z3460.sePaymentDay = getDataM(spr, getColumIndex(spr, "sePaymentDay"), xRow)
            If getColumIndex(spr, "cdPaymentDay") > -1 Then z3460.cdPaymentDay = getDataM(spr, getColumIndex(spr, "cdPaymentDay"), xRow)
            If getColumIndex(spr, "VisAllName") > -1 Then z3460.VisAllName = getDataM(spr, getColumIndex(spr, "VisAllName"), xRow)
            If getColumIndex(spr, "VisAllNo") > -1 Then z3460.VisAllNo = getDataM(spr, getColumIndex(spr, "VisAllNo"), xRow)
            If getColumIndex(spr, "Buyer") > -1 Then z3460.Buyer = getDataM(spr, getColumIndex(spr, "Buyer"), xRow)
            If getColumIndex(spr, "FlightNo") > -1 Then z3460.FlightNo = getDataM(spr, getColumIndex(spr, "FlightNo"), xRow)
            If getColumIndex(spr, "HAWB") > -1 Then z3460.HAWB = getDataM(spr, getColumIndex(spr, "HAWB"), xRow)
            If getColumIndex(spr, "Status") > -1 Then z3460.Status = getDataM(spr, getColumIndex(spr, "Status"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z3460.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z3460.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z3460.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z3460.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "TimeInsert") > -1 Then z3460.TimeInsert = getDataM(spr, getColumIndex(spr, "TimeInsert"), xRow)
            If getColumIndex(spr, "TimeUpdate") > -1 Then z3460.TimeUpdate = getDataM(spr, getColumIndex(spr, "TimeUpdate"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3460_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K3460_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3460 As T3460_AREA, Job As String, INVOICENO As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3460_MOVE = False

        Try
            If READ_PFK3460(INVOICENO) = True Then
                z3460 = D3460
                K3460_MOVE = True
            Else
                z3460 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3460")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "INVOICENO" : z3460.InvoiceNo = Children(i).Code
                                Case "TRANSFERTYPE" : z3460.TransferType = Children(i).Code
                                Case "DATEINVOICE" : z3460.DateInvoice = Children(i).Code
                                Case "INVOICENOMASTER" : z3460.InvoiceNoMaster = Children(i).Code
                                Case "CONTAINERNO" : z3460.ContainerNo = Children(i).Code
                                Case "CUSTOMERCODE" : z3460.CustomerCode = Children(i).Code
                                Case "DATEETA" : z3460.DateETA = Children(i).Code
                                Case "DATEETD" : z3460.DateETD = Children(i).Code
                                Case "DATEFLIGHT" : z3460.DateFlight = Children(i).Code
                                Case "DATEBOOKING" : z3460.DateBooking = Children(i).Code
                                Case "BOOKINGNO" : z3460.BookingNo = Children(i).Code
                                Case "CHECKMARKETTYPE" : z3460.CheckMarketType = Children(i).Code
                                Case "SEDEPARTMENT" : z3460.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z3460.cdDepartment = Children(i).Code
                                Case "INCHARGEINVOICE" : z3460.InchargeInvoice = Children(i).Code
                                Case "SEUNITPRICE" : z3460.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z3460.cdUnitPrice = Children(i).Code
                                Case "CUSTOMERNAME" : z3460.CustomerName = Children(i).Code
                                Case "DESTINATIONID" : z3460.DestinationID = Children(i).Code
                                Case "REMARKS" : z3460.Remarks = Children(i).Code
                                Case "SESITE" : z3460.seSite = Children(i).Code
                                Case "CDSITE" : z3460.cdSite = Children(i).Code
                                Case "SHIPFROM" : z3460.ShipFrom = Children(i).Code
                                Case "SHIPTO" : z3460.ShipTo = Children(i).Code
                                Case "SHIPMARK" : z3460.ShipMark = Children(i).Code
                                Case "SHIPPER" : z3460.Shipper = Children(i).Code
                                Case "SEPAYMENTDAY" : z3460.sePaymentDay = Children(i).Code
                                Case "CDPAYMENTDAY" : z3460.cdPaymentDay = Children(i).Code
                                Case "VISALLNAME" : z3460.VisAllName = Children(i).Code
                                Case "VISALLNO" : z3460.VisAllNo = Children(i).Code
                                Case "BUYER" : z3460.Buyer = Children(i).Code
                                Case "FLIGHTNO" : z3460.FlightNo = Children(i).Code
                                Case "HAWB" : z3460.HAWB = Children(i).Code
                                Case "STATUS" : z3460.Status = Children(i).Code
                                Case "DATEINSERT" : z3460.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z3460.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z3460.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z3460.InchargeUpdate = Children(i).Code
                                Case "TIMEINSERT" : z3460.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z3460.TimeUpdate = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "INVOICENO" : z3460.InvoiceNo = Children(i).Data
                                Case "TRANSFERTYPE" : z3460.TransferType = Children(i).Data
                                Case "DATEINVOICE" : z3460.DateInvoice = Children(i).Data
                                Case "INVOICENOMASTER" : z3460.InvoiceNoMaster = Children(i).Data
                                Case "CONTAINERNO" : z3460.ContainerNo = Children(i).Data
                                Case "CUSTOMERCODE" : z3460.CustomerCode = Children(i).Data
                                Case "DATEETA" : z3460.DateETA = Children(i).Data
                                Case "DATEETD" : z3460.DateETD = Children(i).Data
                                Case "DATEFLIGHT" : z3460.DateFlight = Children(i).Data
                                Case "DATEBOOKING" : z3460.DateBooking = Children(i).Data
                                Case "BOOKINGNO" : z3460.BookingNo = Children(i).Data
                                Case "CHECKMARKETTYPE" : z3460.CheckMarketType = Children(i).Data
                                Case "SEDEPARTMENT" : z3460.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z3460.cdDepartment = Children(i).Data
                                Case "INCHARGEINVOICE" : z3460.InchargeInvoice = Children(i).Data
                                Case "SEUNITPRICE" : z3460.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z3460.cdUnitPrice = Children(i).Data
                                Case "CUSTOMERNAME" : z3460.CustomerName = Children(i).Data
                                Case "DESTINATIONID" : z3460.DestinationID = Children(i).Data
                                Case "REMARKS" : z3460.Remarks = Children(i).Data
                                Case "SESITE" : z3460.seSite = Children(i).Data
                                Case "CDSITE" : z3460.cdSite = Children(i).Data
                                Case "SHIPFROM" : z3460.ShipFrom = Children(i).Data
                                Case "SHIPTO" : z3460.ShipTo = Children(i).Data
                                Case "SHIPMARK" : z3460.ShipMark = Children(i).Data
                                Case "SHIPPER" : z3460.Shipper = Children(i).Data
                                Case "SEPAYMENTDAY" : z3460.sePaymentDay = Children(i).Data
                                Case "CDPAYMENTDAY" : z3460.cdPaymentDay = Children(i).Data
                                Case "VISALLNAME" : z3460.VisAllName = Children(i).Data
                                Case "VISALLNO" : z3460.VisAllNo = Children(i).Data
                                Case "BUYER" : z3460.Buyer = Children(i).Data
                                Case "FLIGHTNO" : z3460.FlightNo = Children(i).Data
                                Case "HAWB" : z3460.HAWB = Children(i).Data
                                Case "STATUS" : z3460.Status = Children(i).Data
                                Case "DATEINSERT" : z3460.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z3460.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z3460.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z3460.InchargeUpdate = Children(i).Data
                                Case "TIMEINSERT" : z3460.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z3460.TimeUpdate = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3460_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K3460_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3460 As T3460_AREA, Job As String, CheckClear As Boolean, INVOICENO As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3460_MOVE = False

        Try
            If READ_PFK3460(INVOICENO) = True Then
                z3460 = D3460
                K3460_MOVE = True
            Else
                If CheckClear = True Then z3460 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3460")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "INVOICENO" : z3460.InvoiceNo = Children(i).Code
                                Case "TRANSFERTYPE" : z3460.TransferType = Children(i).Code
                                Case "DATEINVOICE" : z3460.DateInvoice = Children(i).Code
                                Case "INVOICENOMASTER" : z3460.InvoiceNoMaster = Children(i).Code
                                Case "CONTAINERNO" : z3460.ContainerNo = Children(i).Code
                                Case "CUSTOMERCODE" : z3460.CustomerCode = Children(i).Code
                                Case "DATEETA" : z3460.DateETA = Children(i).Code
                                Case "DATEETD" : z3460.DateETD = Children(i).Code
                                Case "DATEFLIGHT" : z3460.DateFlight = Children(i).Code
                                Case "DATEBOOKING" : z3460.DateBooking = Children(i).Code
                                Case "BOOKINGNO" : z3460.BookingNo = Children(i).Code
                                Case "CHECKMARKETTYPE" : z3460.CheckMarketType = Children(i).Code
                                Case "SEDEPARTMENT" : z3460.seDepartment = Children(i).Code
                                Case "CDDEPARTMENT" : z3460.cdDepartment = Children(i).Code
                                Case "INCHARGEINVOICE" : z3460.InchargeInvoice = Children(i).Code
                                Case "SEUNITPRICE" : z3460.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z3460.cdUnitPrice = Children(i).Code
                                Case "CUSTOMERNAME" : z3460.CustomerName = Children(i).Code
                                Case "DESTINATIONID" : z3460.DestinationID = Children(i).Code
                                Case "REMARKS" : z3460.Remarks = Children(i).Code
                                Case "SESITE" : z3460.seSite = Children(i).Code
                                Case "CDSITE" : z3460.cdSite = Children(i).Code
                                Case "SHIPFROM" : z3460.ShipFrom = Children(i).Code
                                Case "SHIPTO" : z3460.ShipTo = Children(i).Code
                                Case "SHIPMARK" : z3460.ShipMark = Children(i).Code
                                Case "SHIPPER" : z3460.Shipper = Children(i).Code
                                Case "SEPAYMENTDAY" : z3460.sePaymentDay = Children(i).Code
                                Case "CDPAYMENTDAY" : z3460.cdPaymentDay = Children(i).Code
                                Case "VISALLNAME" : z3460.VisAllName = Children(i).Code
                                Case "VISALLNO" : z3460.VisAllNo = Children(i).Code
                                Case "BUYER" : z3460.Buyer = Children(i).Code
                                Case "FLIGHTNO" : z3460.FlightNo = Children(i).Code
                                Case "HAWB" : z3460.HAWB = Children(i).Code
                                Case "STATUS" : z3460.Status = Children(i).Code
                                Case "DATEINSERT" : z3460.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z3460.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z3460.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z3460.InchargeUpdate = Children(i).Code
                                Case "TIMEINSERT" : z3460.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z3460.TimeUpdate = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "INVOICENO" : z3460.InvoiceNo = Children(i).Data
                                Case "TRANSFERTYPE" : z3460.TransferType = Children(i).Data
                                Case "DATEINVOICE" : z3460.DateInvoice = Children(i).Data
                                Case "INVOICENOMASTER" : z3460.InvoiceNoMaster = Children(i).Data
                                Case "CONTAINERNO" : z3460.ContainerNo = Children(i).Data
                                Case "CUSTOMERCODE" : z3460.CustomerCode = Children(i).Data
                                Case "DATEETA" : z3460.DateETA = Children(i).Data
                                Case "DATEETD" : z3460.DateETD = Children(i).Data
                                Case "DATEFLIGHT" : z3460.DateFlight = Children(i).Data
                                Case "DATEBOOKING" : z3460.DateBooking = Children(i).Data
                                Case "BOOKINGNO" : z3460.BookingNo = Children(i).Data
                                Case "CHECKMARKETTYPE" : z3460.CheckMarketType = Children(i).Data
                                Case "SEDEPARTMENT" : z3460.seDepartment = Children(i).Data
                                Case "CDDEPARTMENT" : z3460.cdDepartment = Children(i).Data
                                Case "INCHARGEINVOICE" : z3460.InchargeInvoice = Children(i).Data
                                Case "SEUNITPRICE" : z3460.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z3460.cdUnitPrice = Children(i).Data
                                Case "CUSTOMERNAME" : z3460.CustomerName = Children(i).Data
                                Case "DESTINATIONID" : z3460.DestinationID = Children(i).Data
                                Case "REMARKS" : z3460.Remarks = Children(i).Data
                                Case "SESITE" : z3460.seSite = Children(i).Data
                                Case "CDSITE" : z3460.cdSite = Children(i).Data
                                Case "SHIPFROM" : z3460.ShipFrom = Children(i).Data
                                Case "SHIPTO" : z3460.ShipTo = Children(i).Data
                                Case "SHIPMARK" : z3460.ShipMark = Children(i).Data
                                Case "SHIPPER" : z3460.Shipper = Children(i).Data
                                Case "SEPAYMENTDAY" : z3460.sePaymentDay = Children(i).Data
                                Case "CDPAYMENTDAY" : z3460.cdPaymentDay = Children(i).Data
                                Case "VISALLNAME" : z3460.VisAllName = Children(i).Data
                                Case "VISALLNO" : z3460.VisAllNo = Children(i).Data
                                Case "BUYER" : z3460.Buyer = Children(i).Data
                                Case "FLIGHTNO" : z3460.FlightNo = Children(i).Data
                                Case "HAWB" : z3460.HAWB = Children(i).Data
                                Case "STATUS" : z3460.Status = Children(i).Data
                                Case "DATEINSERT" : z3460.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z3460.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z3460.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z3460.InchargeUpdate = Children(i).Data
                                Case "TIMEINSERT" : z3460.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z3460.TimeUpdate = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3460_MOVE", vbCritical)
        End Try
    End Function

End Module
