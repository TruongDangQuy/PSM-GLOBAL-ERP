'=========================================================================================================================================================
'   TABLE : (PFK7115)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7115

    Structure T7115_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public CostBOM As String  '			char(6)		*
        Public seUnitPrice As String  '			char(3)
        Public cdUnitPrice As String  '			char(3)
        Public seUnitPriceLocal As String  '			char(3)
        Public cdUnitPriceLocal As String  '			char(3)
        Public DateExchange As String  '			char(8)
        Public PriceExchange As Double  '			decimal
        Public ShoesCode As String  '			char(6)
        Public ProfitRate As Double  '			decimal
        Public ProfitAmt As Double  '			decimal
        Public CheckProfitAmt As String  '			char(1)
        Public CostBOMName As String  '			nvarchar(200)
        Public CheckUse As String  '			char(1)
        Public Remark As String  '			nvarchar(50)
        '=========================================================================================================================================================
    End Structure

    Public D7115 As T7115_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK7115(COSTBOM As String) As Boolean
        READ_PFK7115 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7115 "
            SQL = SQL & " WHERE K7115_CostBOM		 = '" & CostBOM & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7115_CLEAR() : GoTo SKIP_READ_PFK7115

            Call K7115_MOVE(rd)
            READ_PFK7115 = True

SKIP_READ_PFK7115:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7115", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK7115(COSTBOM As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7115 "
            SQL = SQL & " WHERE K7115_CostBOM		 = '" & CostBOM & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK7115", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK7115(z7115 As T7115_AREA) As Boolean
        WRITE_PFK7115 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7115)

            SQL = " INSERT INTO PFK7115 "
            SQL = SQL & " ( "
            SQL = SQL & " K7115_CostBOM,"
            SQL = SQL & " K7115_seUnitPrice,"
            SQL = SQL & " K7115_cdUnitPrice,"
            SQL = SQL & " K7115_seUnitPriceLocal,"
            SQL = SQL & " K7115_cdUnitPriceLocal,"
            SQL = SQL & " K7115_DateExchange,"
            SQL = SQL & " K7115_PriceExchange,"
            SQL = SQL & " K7115_ShoesCode,"
            SQL = SQL & " K7115_ProfitRate,"
            SQL = SQL & " K7115_ProfitAmt,"
            SQL = SQL & " K7115_CheckProfitAmt,"
            SQL = SQL & " K7115_CostBOMName,"
            SQL = SQL & " K7115_CheckUse,"
            SQL = SQL & " K7115_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z7115.CostBOM) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7115.seUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7115.cdUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7115.seUnitPriceLocal) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7115.cdUnitPriceLocal) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7115.DateExchange) & "', "
            SQL = SQL & "   " & FormatSQL(z7115.PriceExchange) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7115.ShoesCode) & "', "
            SQL = SQL & "   " & FormatSQL(z7115.ProfitRate) & ", "
            SQL = SQL & "   " & FormatSQL(z7115.ProfitAmt) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7115.CheckProfitAmt) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7115.CostBOMName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7115.CheckUse) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7115.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK7115 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK7115", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK7115(z7115 As T7115_AREA) As Boolean
        REWRITE_PFK7115 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7115)

            SQL = " UPDATE PFK7115 SET "
            SQL = SQL & "    K7115_seUnitPrice      = N'" & FormatSQL(z7115.seUnitPrice) & "', "
            SQL = SQL & "    K7115_cdUnitPrice      = N'" & FormatSQL(z7115.cdUnitPrice) & "', "
            SQL = SQL & "    K7115_seUnitPriceLocal      = N'" & FormatSQL(z7115.seUnitPriceLocal) & "', "
            SQL = SQL & "    K7115_cdUnitPriceLocal      = N'" & FormatSQL(z7115.cdUnitPriceLocal) & "', "
            SQL = SQL & "    K7115_DateExchange      = N'" & FormatSQL(z7115.DateExchange) & "', "
            SQL = SQL & "    K7115_PriceExchange      =  " & FormatSQL(z7115.PriceExchange) & ", "
            SQL = SQL & "    K7115_ShoesCode      = N'" & FormatSQL(z7115.ShoesCode) & "', "
            SQL = SQL & "    K7115_ProfitRate      =  " & FormatSQL(z7115.ProfitRate) & ", "
            SQL = SQL & "    K7115_ProfitAmt      =  " & FormatSQL(z7115.ProfitAmt) & ", "
            SQL = SQL & "    K7115_CheckProfitAmt      = N'" & FormatSQL(z7115.CheckProfitAmt) & "', "
            SQL = SQL & "    K7115_CostBOMName      = N'" & FormatSQL(z7115.CostBOMName) & "', "
            SQL = SQL & "    K7115_CheckUse      = N'" & FormatSQL(z7115.CheckUse) & "', "
            SQL = SQL & "    K7115_Remark      = N'" & FormatSQL(z7115.Remark) & "'  "
            SQL = SQL & " WHERE K7115_CostBOM		 = '" & z7115.CostBOM & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK7115 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK7115", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK7115(z7115 As T7115_AREA) As Boolean
        DELETE_PFK7115 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK7115 "
            SQL = SQL & " WHERE K7115_CostBOM		 = '" & z7115.CostBOM & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7115 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7115", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D7115_CLEAR()
        Try

            D7115.CostBOM = ""
            D7115.seUnitPrice = ""
            D7115.cdUnitPrice = ""
            D7115.seUnitPriceLocal = ""
            D7115.cdUnitPriceLocal = ""
            D7115.DateExchange = ""
            D7115.PriceExchange = 0
            D7115.ShoesCode = ""
            D7115.ProfitRate = 0
            D7115.ProfitAmt = 0
            D7115.CheckProfitAmt = ""
            D7115.CostBOMName = ""
            D7115.CheckUse = ""
            D7115.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D7115_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x7115 As T7115_AREA)
        Try

            x7115.CostBOM = trim$(x7115.CostBOM)
            x7115.seUnitPrice = trim$(x7115.seUnitPrice)
            x7115.cdUnitPrice = trim$(x7115.cdUnitPrice)
            x7115.seUnitPriceLocal = trim$(x7115.seUnitPriceLocal)
            x7115.cdUnitPriceLocal = trim$(x7115.cdUnitPriceLocal)
            x7115.DateExchange = trim$(x7115.DateExchange)
            x7115.PriceExchange = trim$(x7115.PriceExchange)
            x7115.ShoesCode = trim$(x7115.ShoesCode)
            x7115.ProfitRate = trim$(x7115.ProfitRate)
            x7115.ProfitAmt = trim$(x7115.ProfitAmt)
            x7115.CheckProfitAmt = trim$(x7115.CheckProfitAmt)
            x7115.CostBOMName = trim$(x7115.CostBOMName)
            x7115.CheckUse = trim$(x7115.CheckUse)
            x7115.Remark = trim$(x7115.Remark)

            If trim$(x7115.CostBOM) = "" Then x7115.CostBOM = Space(1)
            If trim$(x7115.seUnitPrice) = "" Then x7115.seUnitPrice = Space(1)
            If trim$(x7115.cdUnitPrice) = "" Then x7115.cdUnitPrice = Space(1)
            If trim$(x7115.seUnitPriceLocal) = "" Then x7115.seUnitPriceLocal = Space(1)
            If trim$(x7115.cdUnitPriceLocal) = "" Then x7115.cdUnitPriceLocal = Space(1)
            If trim$(x7115.DateExchange) = "" Then x7115.DateExchange = Space(1)
            If trim$(x7115.PriceExchange) = "" Then x7115.PriceExchange = 0
            If trim$(x7115.ShoesCode) = "" Then x7115.ShoesCode = Space(1)
            If trim$(x7115.ProfitRate) = "" Then x7115.ProfitRate = 0
            If trim$(x7115.ProfitAmt) = "" Then x7115.ProfitAmt = 0
            If trim$(x7115.CheckProfitAmt) = "" Then x7115.CheckProfitAmt = Space(1)
            If trim$(x7115.CostBOMName) = "" Then x7115.CostBOMName = Space(1)
            If trim$(x7115.CheckUse) = "" Then x7115.CheckUse = Space(1)
            If trim$(x7115.Remark) = "" Then x7115.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K7115_MOVE(rs7115 As SqlClient.SqlDataReader)
        Try

            Call D7115_CLEAR()

            If IsdbNull(rs7115!K7115_CostBOM) = False Then D7115.CostBOM = Trim$(rs7115!K7115_CostBOM)
            If IsdbNull(rs7115!K7115_seUnitPrice) = False Then D7115.seUnitPrice = Trim$(rs7115!K7115_seUnitPrice)
            If IsdbNull(rs7115!K7115_cdUnitPrice) = False Then D7115.cdUnitPrice = Trim$(rs7115!K7115_cdUnitPrice)
            If IsdbNull(rs7115!K7115_seUnitPriceLocal) = False Then D7115.seUnitPriceLocal = Trim$(rs7115!K7115_seUnitPriceLocal)
            If IsdbNull(rs7115!K7115_cdUnitPriceLocal) = False Then D7115.cdUnitPriceLocal = Trim$(rs7115!K7115_cdUnitPriceLocal)
            If IsdbNull(rs7115!K7115_DateExchange) = False Then D7115.DateExchange = Trim$(rs7115!K7115_DateExchange)
            If IsdbNull(rs7115!K7115_PriceExchange) = False Then D7115.PriceExchange = Trim$(rs7115!K7115_PriceExchange)
            If IsdbNull(rs7115!K7115_ShoesCode) = False Then D7115.ShoesCode = Trim$(rs7115!K7115_ShoesCode)
            If IsdbNull(rs7115!K7115_ProfitRate) = False Then D7115.ProfitRate = Trim$(rs7115!K7115_ProfitRate)
            If IsdbNull(rs7115!K7115_ProfitAmt) = False Then D7115.ProfitAmt = Trim$(rs7115!K7115_ProfitAmt)
            If IsdbNull(rs7115!K7115_CheckProfitAmt) = False Then D7115.CheckProfitAmt = Trim$(rs7115!K7115_CheckProfitAmt)
            If IsdbNull(rs7115!K7115_CostBOMName) = False Then D7115.CostBOMName = Trim$(rs7115!K7115_CostBOMName)
            If IsdbNull(rs7115!K7115_CheckUse) = False Then D7115.CheckUse = Trim$(rs7115!K7115_CheckUse)
            If IsdbNull(rs7115!K7115_Remark) = False Then D7115.Remark = Trim$(rs7115!K7115_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7115_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K7115_MOVE(rs7115 As DataRow)
        Try

            Call D7115_CLEAR()

            If IsdbNull(rs7115!K7115_CostBOM) = False Then D7115.CostBOM = Trim$(rs7115!K7115_CostBOM)
            If IsdbNull(rs7115!K7115_seUnitPrice) = False Then D7115.seUnitPrice = Trim$(rs7115!K7115_seUnitPrice)
            If IsdbNull(rs7115!K7115_cdUnitPrice) = False Then D7115.cdUnitPrice = Trim$(rs7115!K7115_cdUnitPrice)
            If IsdbNull(rs7115!K7115_seUnitPriceLocal) = False Then D7115.seUnitPriceLocal = Trim$(rs7115!K7115_seUnitPriceLocal)
            If IsdbNull(rs7115!K7115_cdUnitPriceLocal) = False Then D7115.cdUnitPriceLocal = Trim$(rs7115!K7115_cdUnitPriceLocal)
            If IsdbNull(rs7115!K7115_DateExchange) = False Then D7115.DateExchange = Trim$(rs7115!K7115_DateExchange)
            If IsdbNull(rs7115!K7115_PriceExchange) = False Then D7115.PriceExchange = Trim$(rs7115!K7115_PriceExchange)
            If IsdbNull(rs7115!K7115_ShoesCode) = False Then D7115.ShoesCode = Trim$(rs7115!K7115_ShoesCode)
            If IsdbNull(rs7115!K7115_ProfitRate) = False Then D7115.ProfitRate = Trim$(rs7115!K7115_ProfitRate)
            If IsdbNull(rs7115!K7115_ProfitAmt) = False Then D7115.ProfitAmt = Trim$(rs7115!K7115_ProfitAmt)
            If IsdbNull(rs7115!K7115_CheckProfitAmt) = False Then D7115.CheckProfitAmt = Trim$(rs7115!K7115_CheckProfitAmt)
            If IsdbNull(rs7115!K7115_CostBOMName) = False Then D7115.CostBOMName = Trim$(rs7115!K7115_CostBOMName)
            If IsdbNull(rs7115!K7115_CheckUse) = False Then D7115.CheckUse = Trim$(rs7115!K7115_CheckUse)
            If IsdbNull(rs7115!K7115_Remark) = False Then D7115.Remark = Trim$(rs7115!K7115_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7115_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K7115_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7115 As T7115_AREA, COSTBOM As String) As Boolean

        K7115_MOVE = False

        Try
            If READ_PFK7115(COSTBOM) = True Then
                z7115 = D7115
                K7115_MOVE = True
            Else
                z7115 = Nothing
            End If

            If getColumnIndex(spr, "CostBOM") > -1 Then z7115.CostBOM = getDataM(spr, getColumnIndex(spr, "CostBOM"), xRow)
            If getColumnIndex(spr, "seUnitPrice") > -1 Then z7115.seUnitPrice = getDataM(spr, getColumnIndex(spr, "seUnitPrice"), xRow)
            If getColumnIndex(spr, "cdUnitPrice") > -1 Then z7115.cdUnitPrice = getDataM(spr, getColumnIndex(spr, "cdUnitPrice"), xRow)
            If getColumnIndex(spr, "seUnitPriceLocal") > -1 Then z7115.seUnitPriceLocal = getDataM(spr, getColumnIndex(spr, "seUnitPriceLocal"), xRow)
            If getColumnIndex(spr, "cdUnitPriceLocal") > -1 Then z7115.cdUnitPriceLocal = getDataM(spr, getColumnIndex(spr, "cdUnitPriceLocal"), xRow)
            If getColumnIndex(spr, "DateExchange") > -1 Then z7115.DateExchange = getDataM(spr, getColumnIndex(spr, "DateExchange"), xRow)
            If getColumnIndex(spr, "PriceExchange") > -1 Then z7115.PriceExchange = getDataM(spr, getColumnIndex(spr, "PriceExchange"), xRow)
            If getColumnIndex(spr, "ShoesCode") > -1 Then z7115.ShoesCode = getDataM(spr, getColumnIndex(spr, "ShoesCode"), xRow)
            If getColumnIndex(spr, "ProfitRate") > -1 Then z7115.ProfitRate = getDataM(spr, getColumnIndex(spr, "ProfitRate"), xRow)
            If getColumnIndex(spr, "ProfitAmt") > -1 Then z7115.ProfitAmt = getDataM(spr, getColumnIndex(spr, "ProfitAmt"), xRow)
            If getColumnIndex(spr, "CheckProfitAmt") > -1 Then z7115.CheckProfitAmt = getDataM(spr, getColumnIndex(spr, "CheckProfitAmt"), xRow)
            If getColumnIndex(spr, "CostBOMName") > -1 Then z7115.CostBOMName = getDataM(spr, getColumnIndex(spr, "CostBOMName"), xRow)
            If getColumnIndex(spr, "CheckUse") > -1 Then z7115.CheckUse = getDataM(spr, getColumnIndex(spr, "CheckUse"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z7115.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7115_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K7115_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7115 As T7115_AREA, CheckClear As Boolean, COSTBOM As String) As Boolean

        K7115_MOVE = False

        Try
            If READ_PFK7115(COSTBOM) = True Then
                z7115 = D7115
                K7115_MOVE = True
            Else
                If CheckClear = True Then z7115 = Nothing
            End If

            If getColumnIndex(spr, "CostBOM") > -1 Then z7115.CostBOM = getDataM(spr, getColumnIndex(spr, "CostBOM"), xRow)
            If getColumnIndex(spr, "seUnitPrice") > -1 Then z7115.seUnitPrice = getDataM(spr, getColumnIndex(spr, "seUnitPrice"), xRow)
            If getColumnIndex(spr, "cdUnitPrice") > -1 Then z7115.cdUnitPrice = getDataM(spr, getColumnIndex(spr, "cdUnitPrice"), xRow)
            If getColumnIndex(spr, "seUnitPriceLocal") > -1 Then z7115.seUnitPriceLocal = getDataM(spr, getColumnIndex(spr, "seUnitPriceLocal"), xRow)
            If getColumnIndex(spr, "cdUnitPriceLocal") > -1 Then z7115.cdUnitPriceLocal = getDataM(spr, getColumnIndex(spr, "cdUnitPriceLocal"), xRow)
            If getColumnIndex(spr, "DateExchange") > -1 Then z7115.DateExchange = getDataM(spr, getColumnIndex(spr, "DateExchange"), xRow)
            If getColumnIndex(spr, "PriceExchange") > -1 Then z7115.PriceExchange = getDataM(spr, getColumnIndex(spr, "PriceExchange"), xRow)
            If getColumnIndex(spr, "ShoesCode") > -1 Then z7115.ShoesCode = getDataM(spr, getColumnIndex(spr, "ShoesCode"), xRow)
            If getColumnIndex(spr, "ProfitRate") > -1 Then z7115.ProfitRate = getDataM(spr, getColumnIndex(spr, "ProfitRate"), xRow)
            If getColumnIndex(spr, "ProfitAmt") > -1 Then z7115.ProfitAmt = getDataM(spr, getColumnIndex(spr, "ProfitAmt"), xRow)
            If getColumnIndex(spr, "CheckProfitAmt") > -1 Then z7115.CheckProfitAmt = getDataM(spr, getColumnIndex(spr, "CheckProfitAmt"), xRow)
            If getColumnIndex(spr, "CostBOMName") > -1 Then z7115.CostBOMName = getDataM(spr, getColumnIndex(spr, "CostBOMName"), xRow)
            If getColumnIndex(spr, "CheckUse") > -1 Then z7115.CheckUse = getDataM(spr, getColumnIndex(spr, "CheckUse"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z7115.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7115_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K7115_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7115 As T7115_AREA, Job As String, COSTBOM As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7115_MOVE = False

        Try
            If READ_PFK7115(COSTBOM) = True Then
                z7115 = D7115
                K7115_MOVE = True
            Else
                z7115 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7115")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "COSTBOM" : z7115.CostBOM = Children(i).Code
                                Case "SEUNITPRICE" : z7115.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z7115.cdUnitPrice = Children(i).Code
                                Case "SEUNITPRICELOCAL" : z7115.seUnitPriceLocal = Children(i).Code
                                Case "CDUNITPRICELOCAL" : z7115.cdUnitPriceLocal = Children(i).Code
                                Case "DATEEXCHANGE" : z7115.DateExchange = Children(i).Code
                                Case "PRICEEXCHANGE" : z7115.PriceExchange = Children(i).Code
                                Case "SHOESCODE" : z7115.ShoesCode = Children(i).Code
                                Case "PROFITRATE" : z7115.ProfitRate = Children(i).Code
                                Case "PROFITAMT" : z7115.ProfitAmt = Children(i).Code
                                Case "CHECKPROFITAMT" : z7115.CheckProfitAmt = Children(i).Code
                                Case "COSTBOMNAME" : z7115.CostBOMName = Children(i).Code
                                Case "CHECKUSE" : z7115.CheckUse = Children(i).Code
                                Case "REMARK" : z7115.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "COSTBOM" : z7115.CostBOM = Children(i).Data
                                Case "SEUNITPRICE" : z7115.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z7115.cdUnitPrice = Children(i).Data
                                Case "SEUNITPRICELOCAL" : z7115.seUnitPriceLocal = Children(i).Data
                                Case "CDUNITPRICELOCAL" : z7115.cdUnitPriceLocal = Children(i).Data
                                Case "DATEEXCHANGE" : z7115.DateExchange = Children(i).Data
                                Case "PRICEEXCHANGE" : z7115.PriceExchange = Children(i).Data
                                Case "SHOESCODE" : z7115.ShoesCode = Children(i).Data
                                Case "PROFITRATE" : z7115.ProfitRate = Children(i).Data
                                Case "PROFITAMT" : z7115.ProfitAmt = Children(i).Data
                                Case "CHECKPROFITAMT" : z7115.CheckProfitAmt = Children(i).Data
                                Case "COSTBOMNAME" : z7115.CostBOMName = Children(i).Data
                                Case "CHECKUSE" : z7115.CheckUse = Children(i).Data
                                Case "REMARK" : z7115.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7115_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K7115_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7115 As T7115_AREA, Job As String, CheckClear As Boolean, COSTBOM As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7115_MOVE = False

        Try
            If READ_PFK7115(COSTBOM) = True Then
                z7115 = D7115
                K7115_MOVE = True
            Else
                If CheckClear = True Then z7115 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7115")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "COSTBOM" : z7115.CostBOM = Children(i).Code
                                Case "SEUNITPRICE" : z7115.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z7115.cdUnitPrice = Children(i).Code
                                Case "SEUNITPRICELOCAL" : z7115.seUnitPriceLocal = Children(i).Code
                                Case "CDUNITPRICELOCAL" : z7115.cdUnitPriceLocal = Children(i).Code
                                Case "DATEEXCHANGE" : z7115.DateExchange = Children(i).Code
                                Case "PRICEEXCHANGE" : z7115.PriceExchange = Children(i).Code
                                Case "SHOESCODE" : z7115.ShoesCode = Children(i).Code
                                Case "PROFITRATE" : z7115.ProfitRate = Children(i).Code
                                Case "PROFITAMT" : z7115.ProfitAmt = Children(i).Code
                                Case "CHECKPROFITAMT" : z7115.CheckProfitAmt = Children(i).Code
                                Case "COSTBOMNAME" : z7115.CostBOMName = Children(i).Code
                                Case "CHECKUSE" : z7115.CheckUse = Children(i).Code
                                Case "REMARK" : z7115.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "COSTBOM" : z7115.CostBOM = Children(i).Data
                                Case "SEUNITPRICE" : z7115.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z7115.cdUnitPrice = Children(i).Data
                                Case "SEUNITPRICELOCAL" : z7115.seUnitPriceLocal = Children(i).Data
                                Case "CDUNITPRICELOCAL" : z7115.cdUnitPriceLocal = Children(i).Data
                                Case "DATEEXCHANGE" : z7115.DateExchange = Children(i).Data
                                Case "PRICEEXCHANGE" : z7115.PriceExchange = Children(i).Data
                                Case "SHOESCODE" : z7115.ShoesCode = Children(i).Data
                                Case "PROFITRATE" : z7115.ProfitRate = Children(i).Data
                                Case "PROFITAMT" : z7115.ProfitAmt = Children(i).Data
                                Case "CHECKPROFITAMT" : z7115.CheckProfitAmt = Children(i).Data
                                Case "COSTBOMNAME" : z7115.CostBOMName = Children(i).Data
                                Case "CHECKUSE" : z7115.CheckUse = Children(i).Data
                                Case "REMARK" : z7115.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7115_MOVE", vbCritical)
        End Try
    End Function

End Module
