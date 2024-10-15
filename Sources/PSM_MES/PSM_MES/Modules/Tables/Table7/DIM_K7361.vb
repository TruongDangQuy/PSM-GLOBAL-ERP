'=========================================================================================================================================================
'   TABLE : (PFK7361)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7361

    Structure T7361_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public ContractID As String  '			char(6)		*
        Public ContractSeq As Double  '			decimal		*
        Public CheckType As String  '			char(1)
        Public MaterialCode As String  '			char(6)
        Public ColorName As String  '			nvarchar(100)
        Public Line As String  '			nvarchar(50)
        Public Article As String  '			nvarchar(50)
        Public CheckSize As String  '			char(1)
        Public FromSize As Double  '			decimal
        Public ToSize As Double  '			decimal
        Public PriceMaterialEX As Double  '			decimal
        Public PriceExchange As Double  '			decimal
        Public seUnitPrice As String  '			char(3)
        Public cdUnitPrice As String  '			char(3)
        Public PriceMaterialVND As Double  '			decimal
        Public PerTax3 As Double  '			decimal
        Public DateInsert As String  '			char(8)
        Public DateUpdate As String  '			char(8)
        Public InchargeInsert As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        Public Remark As String  '			nvarchar(1000)
        '=========================================================================================================================================================
    End Structure

    Public D7361 As T7361_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK7361(CONTRACTID As String, CONTRACTSEQ As Double, COLOR As String) As Boolean
        READ_PFK7361 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7361 "
            SQL = SQL & " WHERE K7361_ContractID		 = '" & CONTRACTID & "' "
            SQL = SQL & "   AND K7361_ContractSeq		 =  " & CONTRACTSEQ & "  "
            SQL = SQL & "   AND K7361_ColorName		 =  " & COLOR & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7361_CLEAR() : GoTo SKIP_READ_PFK7361

            Call K7361_MOVE(rd)
            READ_PFK7361 = True

SKIP_READ_PFK7361:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7361", vbCritical)
        End Try
    End Function

    Public Function READ_PFK7361(CONTRACTID As String, CONTRACTSEQ As Double) As Boolean
        READ_PFK7361 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7361 "
            SQL = SQL & " WHERE K7361_ContractID		 = '" & CONTRACTID & "' "
            SQL = SQL & "   AND K7361_ContractSeq		 =  " & CONTRACTSEQ & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7361_CLEAR() : GoTo SKIP_READ_PFK7361

            Call K7361_MOVE(rd)
            READ_PFK7361 = True

SKIP_READ_PFK7361:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7361", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK7361(CONTRACTID As String, CONTRACTSEQ As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7361 "
            SQL = SQL & " WHERE K7361_ContractID		 = '" & CONTRACTID & "' "
            SQL = SQL & "   AND K7361_ContractSeq		 =  " & CONTRACTSEQ & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK7361", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK7361(z7361 As T7361_AREA) As Boolean
        WRITE_PFK7361 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7361)

            SQL = " INSERT INTO PFK7361 "
            SQL = SQL & " ( "
            SQL = SQL & " K7361_ContractID,"
            SQL = SQL & " K7361_ContractSeq,"
            SQL = SQL & " K7361_CheckType,"
            SQL = SQL & " K7361_MaterialCode,"
            SQL = SQL & " K7361_ColorName,"
            SQL = SQL & " K7361_Line,"
            SQL = SQL & " K7361_Article,"
            SQL = SQL & " K7361_CheckSize,"
            SQL = SQL & " K7361_FromSize,"
            SQL = SQL & " K7361_ToSize,"
            SQL = SQL & " K7361_PriceMaterialEX,"
            SQL = SQL & " K7361_PriceExchange,"
            SQL = SQL & " K7361_seUnitPrice,"
            SQL = SQL & " K7361_cdUnitPrice,"
            SQL = SQL & " K7361_PriceMaterialVND,"
            SQL = SQL & " K7361_PerTax3,"
            SQL = SQL & " K7361_DateInsert,"
            SQL = SQL & " K7361_DateUpdate,"
            SQL = SQL & " K7361_InchargeInsert,"
            SQL = SQL & " K7361_InchargeUpdate,"
            SQL = SQL & " K7361_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z7361.ContractID) & "', "
            SQL = SQL & "   " & FormatSQL(z7361.ContractSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7361.CheckType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7361.MaterialCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7361.ColorName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7361.Line) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7361.Article) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7361.CheckSize) & "', "
            SQL = SQL & "   " & FormatSQL(z7361.FromSize) & ", "
            SQL = SQL & "   " & FormatSQL(z7361.ToSize) & ", "
            SQL = SQL & "   " & FormatSQL(z7361.PriceMaterialEX) & ", "
            SQL = SQL & "   " & FormatSQL(z7361.PriceExchange) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7361.seUnitPrice) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7361.cdUnitPrice) & "', "
            SQL = SQL & "   " & FormatSQL(z7361.PriceMaterialVND) & ", "
            SQL = SQL & "   " & FormatSQL(z7361.PerTax3) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7361.DateInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7361.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7361.InchargeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7361.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7361.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK7361 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK7361", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK7361(z7361 As T7361_AREA) As Boolean
        REWRITE_PFK7361 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7361)

            SQL = " UPDATE PFK7361 SET "
            SQL = SQL & "    K7361_CheckType      = N'" & FormatSQL(z7361.CheckType) & "', "
            SQL = SQL & "    K7361_MaterialCode      = N'" & FormatSQL(z7361.MaterialCode) & "', "
            SQL = SQL & "    K7361_ColorName      = N'" & FormatSQL(z7361.ColorName) & "', "
            SQL = SQL & "    K7361_Line      = N'" & FormatSQL(z7361.Line) & "', "
            SQL = SQL & "    K7361_Article      = N'" & FormatSQL(z7361.Article) & "', "
            SQL = SQL & "    K7361_CheckSize      = N'" & FormatSQL(z7361.CheckSize) & "', "
            SQL = SQL & "    K7361_FromSize      =  " & FormatSQL(z7361.FromSize) & ", "
            SQL = SQL & "    K7361_ToSize      =  " & FormatSQL(z7361.ToSize) & ", "
            SQL = SQL & "    K7361_PriceMaterialEX      =  " & FormatSQL(z7361.PriceMaterialEX) & ", "
            SQL = SQL & "    K7361_PriceExchange      =  " & FormatSQL(z7361.PriceExchange) & ", "
            SQL = SQL & "    K7361_seUnitPrice      = N'" & FormatSQL(z7361.seUnitPrice) & "', "
            SQL = SQL & "    K7361_cdUnitPrice      = N'" & FormatSQL(z7361.cdUnitPrice) & "', "
            SQL = SQL & "    K7361_PriceMaterialVND      =  " & FormatSQL(z7361.PriceMaterialVND) & ", "
            SQL = SQL & "    K7361_PerTax3      =  " & FormatSQL(z7361.PerTax3) & ", "
            SQL = SQL & "    K7361_DateInsert      = N'" & FormatSQL(z7361.DateInsert) & "', "
            SQL = SQL & "    K7361_DateUpdate      = N'" & FormatSQL(z7361.DateUpdate) & "', "
            SQL = SQL & "    K7361_InchargeInsert      = N'" & FormatSQL(z7361.InchargeInsert) & "', "
            SQL = SQL & "    K7361_InchargeUpdate      = N'" & FormatSQL(z7361.InchargeUpdate) & "', "
            SQL = SQL & "    K7361_Remark      = N'" & FormatSQL(z7361.Remark) & "'  "
            SQL = SQL & "   WHERE K7361_ContractID		 = '" & z7361.ContractID & "' "
            SQL = SQL & "   AND K7361_ContractSeq		 =  " & z7361.ContractSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK7361 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK7361", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK7361(z7361 As T7361_AREA) As Boolean
        DELETE_PFK7361 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK7361 "
            SQL = SQL & " WHERE K7361_ContractID		 = '" & z7361.ContractID & "' "
            SQL = SQL & "   AND K7361_ContractSeq		 =  " & z7361.ContractSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7361 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7361", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D7361_CLEAR()
        Try

            D7361.ContractID = ""
            D7361.ContractSeq = 0
            D7361.CheckType = ""
            D7361.MaterialCode = ""
            D7361.ColorName = ""
            D7361.Line = ""
            D7361.Article = ""
            D7361.CheckSize = ""
            D7361.FromSize = 0
            D7361.ToSize = 0
            D7361.PriceMaterialEX = 0
            D7361.PriceExchange = 0
            D7361.seUnitPrice = ""
            D7361.cdUnitPrice = ""
            D7361.PriceMaterialVND = 0
            D7361.PerTax3 = 0
            D7361.DateInsert = ""
            D7361.DateUpdate = ""
            D7361.InchargeInsert = ""
            D7361.InchargeUpdate = ""
            D7361.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D7361_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x7361 As T7361_AREA)
        Try

            x7361.ContractID = Trim$(x7361.ContractID)
            x7361.ContractSeq = Trim$(x7361.ContractSeq)
            x7361.CheckType = Trim$(x7361.CheckType)
            x7361.MaterialCode = Trim$(x7361.MaterialCode)
            x7361.ColorName = Trim$(x7361.ColorName)
            x7361.Line = Trim$(x7361.Line)
            x7361.Article = Trim$(x7361.Article)
            x7361.CheckSize = Trim$(x7361.CheckSize)
            x7361.FromSize = Trim$(x7361.FromSize)
            x7361.ToSize = Trim$(x7361.ToSize)
            x7361.PriceMaterialEX = Trim$(x7361.PriceMaterialEX)
            x7361.PriceExchange = Trim$(x7361.PriceExchange)
            x7361.seUnitPrice = Trim$(x7361.seUnitPrice)
            x7361.cdUnitPrice = Trim$(x7361.cdUnitPrice)
            x7361.PriceMaterialVND = Trim$(x7361.PriceMaterialVND)
            x7361.PerTax3 = Trim$(x7361.PerTax3)
            x7361.DateInsert = Trim$(x7361.DateInsert)
            x7361.DateUpdate = Trim$(x7361.DateUpdate)
            x7361.InchargeInsert = Trim$(x7361.InchargeInsert)
            x7361.InchargeUpdate = Trim$(x7361.InchargeUpdate)
            x7361.Remark = Trim$(x7361.Remark)

            If Trim$(x7361.ContractID) = "" Then x7361.ContractID = Space(1)
            If Trim$(x7361.ContractSeq) = "" Then x7361.ContractSeq = 0
            If Trim$(x7361.CheckType) = "" Then x7361.CheckType = Space(1)
            If Trim$(x7361.MaterialCode) = "" Then x7361.MaterialCode = Space(1)
            If Trim$(x7361.ColorName) = "" Then x7361.ColorName = Space(1)
            If Trim$(x7361.Line) = "" Then x7361.Line = Space(1)
            If Trim$(x7361.Article) = "" Then x7361.Article = Space(1)
            If Trim$(x7361.CheckSize) = "" Then x7361.CheckSize = Space(1)
            If Trim$(x7361.FromSize) = "" Then x7361.FromSize = 0
            If Trim$(x7361.ToSize) = "" Then x7361.ToSize = 0
            If Trim$(x7361.PriceMaterialEX) = "" Then x7361.PriceMaterialEX = 0
            If Trim$(x7361.PriceExchange) = "" Then x7361.PriceExchange = 0
            If Trim$(x7361.seUnitPrice) = "" Then x7361.seUnitPrice = Space(1)
            If Trim$(x7361.cdUnitPrice) = "" Then x7361.cdUnitPrice = Space(1)
            If Trim$(x7361.PriceMaterialVND) = "" Then x7361.PriceMaterialVND = 0
            If Trim$(x7361.PerTax3) = "" Then x7361.PerTax3 = 0
            If Trim$(x7361.DateInsert) = "" Then x7361.DateInsert = Space(1)
            If Trim$(x7361.DateUpdate) = "" Then x7361.DateUpdate = Space(1)
            If Trim$(x7361.InchargeInsert) = "" Then x7361.InchargeInsert = Space(1)
            If Trim$(x7361.InchargeUpdate) = "" Then x7361.InchargeUpdate = Space(1)
            If Trim$(x7361.Remark) = "" Then x7361.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K7361_MOVE(rs7361 As SqlClient.SqlDataReader)
        Try

            Call D7361_CLEAR()

            If IsDBNull(rs7361!K7361_ContractID) = False Then D7361.ContractID = Trim$(rs7361!K7361_ContractID)
            If IsDBNull(rs7361!K7361_ContractSeq) = False Then D7361.ContractSeq = Trim$(rs7361!K7361_ContractSeq)
            If IsDBNull(rs7361!K7361_CheckType) = False Then D7361.CheckType = Trim$(rs7361!K7361_CheckType)
            If IsDBNull(rs7361!K7361_MaterialCode) = False Then D7361.MaterialCode = Trim$(rs7361!K7361_MaterialCode)
            If IsDBNull(rs7361!K7361_ColorName) = False Then D7361.ColorName = Trim$(rs7361!K7361_ColorName)
            If IsDBNull(rs7361!K7361_Line) = False Then D7361.Line = Trim$(rs7361!K7361_Line)
            If IsDBNull(rs7361!K7361_Article) = False Then D7361.Article = Trim$(rs7361!K7361_Article)
            If IsDBNull(rs7361!K7361_CheckSize) = False Then D7361.CheckSize = Trim$(rs7361!K7361_CheckSize)
            If IsDBNull(rs7361!K7361_FromSize) = False Then D7361.FromSize = Trim$(rs7361!K7361_FromSize)
            If IsDBNull(rs7361!K7361_ToSize) = False Then D7361.ToSize = Trim$(rs7361!K7361_ToSize)
            If IsDBNull(rs7361!K7361_PriceMaterialEX) = False Then D7361.PriceMaterialEX = Trim$(rs7361!K7361_PriceMaterialEX)
            If IsDBNull(rs7361!K7361_PriceExchange) = False Then D7361.PriceExchange = Trim$(rs7361!K7361_PriceExchange)
            If IsDBNull(rs7361!K7361_seUnitPrice) = False Then D7361.seUnitPrice = Trim$(rs7361!K7361_seUnitPrice)
            If IsDBNull(rs7361!K7361_cdUnitPrice) = False Then D7361.cdUnitPrice = Trim$(rs7361!K7361_cdUnitPrice)
            If IsDBNull(rs7361!K7361_PriceMaterialVND) = False Then D7361.PriceMaterialVND = Trim$(rs7361!K7361_PriceMaterialVND)
            If IsDBNull(rs7361!K7361_PerTax3) = False Then D7361.PerTax3 = Trim$(rs7361!K7361_PerTax3)
            If IsDBNull(rs7361!K7361_DateInsert) = False Then D7361.DateInsert = Trim$(rs7361!K7361_DateInsert)
            If IsDBNull(rs7361!K7361_DateUpdate) = False Then D7361.DateUpdate = Trim$(rs7361!K7361_DateUpdate)
            If IsDBNull(rs7361!K7361_InchargeInsert) = False Then D7361.InchargeInsert = Trim$(rs7361!K7361_InchargeInsert)
            If IsDBNull(rs7361!K7361_InchargeUpdate) = False Then D7361.InchargeUpdate = Trim$(rs7361!K7361_InchargeUpdate)
            If IsDBNull(rs7361!K7361_Remark) = False Then D7361.Remark = Trim$(rs7361!K7361_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7361_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K7361_MOVE(rs7361 As DataRow)
        Try

            Call D7361_CLEAR()

            If IsDBNull(rs7361!K7361_ContractID) = False Then D7361.ContractID = Trim$(rs7361!K7361_ContractID)
            If IsDBNull(rs7361!K7361_ContractSeq) = False Then D7361.ContractSeq = Trim$(rs7361!K7361_ContractSeq)
            If IsDBNull(rs7361!K7361_CheckType) = False Then D7361.CheckType = Trim$(rs7361!K7361_CheckType)
            If IsDBNull(rs7361!K7361_MaterialCode) = False Then D7361.MaterialCode = Trim$(rs7361!K7361_MaterialCode)
            If IsDBNull(rs7361!K7361_ColorName) = False Then D7361.ColorName = Trim$(rs7361!K7361_ColorName)
            If IsDBNull(rs7361!K7361_Line) = False Then D7361.Line = Trim$(rs7361!K7361_Line)
            If IsDBNull(rs7361!K7361_Article) = False Then D7361.Article = Trim$(rs7361!K7361_Article)
            If IsDBNull(rs7361!K7361_CheckSize) = False Then D7361.CheckSize = Trim$(rs7361!K7361_CheckSize)
            If IsDBNull(rs7361!K7361_FromSize) = False Then D7361.FromSize = Trim$(rs7361!K7361_FromSize)
            If IsDBNull(rs7361!K7361_ToSize) = False Then D7361.ToSize = Trim$(rs7361!K7361_ToSize)
            If IsDBNull(rs7361!K7361_PriceMaterialEX) = False Then D7361.PriceMaterialEX = Trim$(rs7361!K7361_PriceMaterialEX)
            If IsDBNull(rs7361!K7361_PriceExchange) = False Then D7361.PriceExchange = Trim$(rs7361!K7361_PriceExchange)
            If IsDBNull(rs7361!K7361_seUnitPrice) = False Then D7361.seUnitPrice = Trim$(rs7361!K7361_seUnitPrice)
            If IsDBNull(rs7361!K7361_cdUnitPrice) = False Then D7361.cdUnitPrice = Trim$(rs7361!K7361_cdUnitPrice)
            If IsDBNull(rs7361!K7361_PriceMaterialVND) = False Then D7361.PriceMaterialVND = Trim$(rs7361!K7361_PriceMaterialVND)
            If IsDBNull(rs7361!K7361_PerTax3) = False Then D7361.PerTax3 = Trim$(rs7361!K7361_PerTax3)
            If IsDBNull(rs7361!K7361_DateInsert) = False Then D7361.DateInsert = Trim$(rs7361!K7361_DateInsert)
            If IsDBNull(rs7361!K7361_DateUpdate) = False Then D7361.DateUpdate = Trim$(rs7361!K7361_DateUpdate)
            If IsDBNull(rs7361!K7361_InchargeInsert) = False Then D7361.InchargeInsert = Trim$(rs7361!K7361_InchargeInsert)
            If IsDBNull(rs7361!K7361_InchargeUpdate) = False Then D7361.InchargeUpdate = Trim$(rs7361!K7361_InchargeUpdate)
            If IsDBNull(rs7361!K7361_Remark) = False Then D7361.Remark = Trim$(rs7361!K7361_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7361_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K7361_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7361 As T7361_AREA, CONTRACTID As String, CONTRACTSEQ As Double) As Boolean

        K7361_MOVE = False

        Try
            If READ_PFK7361(CONTRACTID, CONTRACTSEQ) = True Then
                z7361 = D7361
                K7361_MOVE = True
            Else
                z7361 = Nothing
            End If

            If getColumIndex(spr, "ContractID") > -1 Then z7361.ContractID = getDataM(spr, getColumIndex(spr, "ContractID"), xRow)
            If getColumIndex(spr, "ContractSeq") > -1 Then z7361.ContractSeq = getDataM(spr, getColumIndex(spr, "ContractSeq"), xRow)
            If getColumIndex(spr, "CheckType") > -1 Then z7361.CheckType = getDataM(spr, getColumIndex(spr, "CheckType"), xRow)
            If getColumIndex(spr, "MaterialCode") > -1 Then z7361.MaterialCode = getDataM(spr, getColumIndex(spr, "MaterialCode"), xRow)
            If getColumIndex(spr, "ColorName") > -1 Then z7361.ColorName = getDataM(spr, getColumIndex(spr, "ColorName"), xRow)
            If getColumIndex(spr, "Line") > -1 Then z7361.Line = getDataM(spr, getColumIndex(spr, "Line"), xRow)
            If getColumIndex(spr, "Article") > -1 Then z7361.Article = getDataM(spr, getColumIndex(spr, "Article"), xRow)
            If getColumIndex(spr, "CheckSize") > -1 Then z7361.CheckSize = getDataM(spr, getColumIndex(spr, "CheckSize"), xRow)
            If getColumIndex(spr, "FromSize") > -1 Then z7361.FromSize = getDataM(spr, getColumIndex(spr, "FromSize"), xRow)
            If getColumIndex(spr, "ToSize") > -1 Then z7361.ToSize = getDataM(spr, getColumIndex(spr, "ToSize"), xRow)
            If getColumIndex(spr, "PriceMaterialEX") > -1 Then z7361.PriceMaterialEX = getDataM(spr, getColumIndex(spr, "PriceMaterialEX"), xRow)
            If getColumIndex(spr, "PriceExchange") > -1 Then z7361.PriceExchange = getDataM(spr, getColumIndex(spr, "PriceExchange"), xRow)
            If getColumIndex(spr, "seUnitPrice") > -1 Then z7361.seUnitPrice = getDataM(spr, getColumIndex(spr, "seUnitPrice"), xRow)
            If getColumIndex(spr, "cdUnitPrice") > -1 Then z7361.cdUnitPrice = getDataM(spr, getColumIndex(spr, "cdUnitPrice"), xRow)
            If getColumIndex(spr, "PriceMaterialVND") > -1 Then z7361.PriceMaterialVND = getDataM(spr, getColumIndex(spr, "PriceMaterialVND"), xRow)
            If getColumIndex(spr, "PerTax3") > -1 Then z7361.PerTax3 = getDataM(spr, getColumIndex(spr, "PerTax3"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z7361.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z7361.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z7361.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z7361.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z7361.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7361_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K7361_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7361 As T7361_AREA, CheckClear As Boolean, CONTRACTID As String, CONTRACTSEQ As Double) As Boolean

        K7361_MOVE = False

        Try
            If READ_PFK7361(CONTRACTID, CONTRACTSEQ) = True Then
                z7361 = D7361
                K7361_MOVE = True
            Else
                If CheckClear = True Then z7361 = Nothing
            End If

            If getColumIndex(spr, "ContractID") > -1 Then z7361.ContractID = getDataM(spr, getColumIndex(spr, "ContractID"), xRow)
            If getColumIndex(spr, "ContractSeq") > -1 Then z7361.ContractSeq = getDataM(spr, getColumIndex(spr, "ContractSeq"), xRow)
            If getColumIndex(spr, "CheckType") > -1 Then z7361.CheckType = getDataM(spr, getColumIndex(spr, "CheckType"), xRow)
            If getColumIndex(spr, "MaterialCode") > -1 Then z7361.MaterialCode = getDataM(spr, getColumIndex(spr, "MaterialCode"), xRow)
            If getColumIndex(spr, "ColorName") > -1 Then z7361.ColorName = getDataM(spr, getColumIndex(spr, "ColorName"), xRow)
            If getColumIndex(spr, "Line") > -1 Then z7361.Line = getDataM(spr, getColumIndex(spr, "Line"), xRow)
            If getColumIndex(spr, "Article") > -1 Then z7361.Article = getDataM(spr, getColumIndex(spr, "Article"), xRow)
            If getColumIndex(spr, "CheckSize") > -1 Then z7361.CheckSize = getDataM(spr, getColumIndex(spr, "CheckSize"), xRow)
            If getColumIndex(spr, "FromSize") > -1 Then z7361.FromSize = getDataM(spr, getColumIndex(spr, "FromSize"), xRow)
            If getColumIndex(spr, "ToSize") > -1 Then z7361.ToSize = getDataM(spr, getColumIndex(spr, "ToSize"), xRow)
            If getColumIndex(spr, "PriceMaterialEX") > -1 Then z7361.PriceMaterialEX = getDataM(spr, getColumIndex(spr, "PriceMaterialEX"), xRow)
            If getColumIndex(spr, "PriceExchange") > -1 Then z7361.PriceExchange = getDataM(spr, getColumIndex(spr, "PriceExchange"), xRow)
            If getColumIndex(spr, "seUnitPrice") > -1 Then z7361.seUnitPrice = getDataM(spr, getColumIndex(spr, "seUnitPrice"), xRow)
            If getColumIndex(spr, "cdUnitPrice") > -1 Then z7361.cdUnitPrice = getDataM(spr, getColumIndex(spr, "cdUnitPrice"), xRow)
            If getColumIndex(spr, "PriceMaterialVND_7361") > -1 Then z7361.PriceMaterialVND = getDataM(spr, getColumIndex(spr, "PriceMaterialVND_7361"), xRow)
            If getColumIndex(spr, "PerTax3") > -1 Then z7361.PerTax3 = getDataM(spr, getColumIndex(spr, "PerTax3"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z7361.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z7361.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z7361.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z7361.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z7361.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7361_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K7361_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7361 As T7361_AREA, Job As String, CONTRACTID As String, CONTRACTSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7361_MOVE = False

        Try
            If READ_PFK7361(CONTRACTID, CONTRACTSEQ) = True Then
                z7361 = D7361
                K7361_MOVE = True
            Else
                z7361 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7361")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "CONTRACTID" : z7361.ContractID = Children(i).Code
                                Case "CONTRACTSEQ" : z7361.ContractSeq = Children(i).Code
                                Case "CHECKTYPE" : z7361.CheckType = Children(i).Code
                                Case "MATERIALCODE" : z7361.MaterialCode = Children(i).Code
                                Case "COLORNAME" : z7361.ColorName = Children(i).Code
                                Case "LINE" : z7361.Line = Children(i).Code
                                Case "ARTICLE" : z7361.Article = Children(i).Code
                                Case "CHECKSIZE" : z7361.CheckSize = Children(i).Code
                                Case "FROMSIZE" : z7361.FromSize = Children(i).Code
                                Case "TOSIZE" : z7361.ToSize = Children(i).Code
                                Case "PRICEMATERIALEX" : z7361.PriceMaterialEX = Children(i).Code
                                Case "PRICEEXCHANGE" : z7361.PriceExchange = Children(i).Code
                                Case "SEUNITPRICE" : z7361.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z7361.cdUnitPrice = Children(i).Code
                                Case "PRICEMATERIALVND" : z7361.PriceMaterialVND = Children(i).Code
                                Case "PERTAX3" : z7361.PerTax3 = Children(i).Code
                                Case "DATEINSERT" : z7361.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z7361.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z7361.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z7361.InchargeUpdate = Children(i).Code
                                Case "REMARK" : z7361.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "CONTRACTID" : z7361.ContractID = Children(i).Data
                                Case "CONTRACTSEQ" : z7361.ContractSeq = Children(i).Data
                                Case "CHECKTYPE" : z7361.CheckType = Children(i).Data
                                Case "MATERIALCODE" : z7361.MaterialCode = Children(i).Data
                                Case "COLORNAME" : z7361.ColorName = Children(i).Data
                                Case "LINE" : z7361.Line = Children(i).Data
                                Case "ARTICLE" : z7361.Article = Children(i).Data
                                Case "CHECKSIZE" : z7361.CheckSize = Children(i).Data
                                Case "FROMSIZE" : z7361.FromSize = Children(i).Data
                                Case "TOSIZE" : z7361.ToSize = Children(i).Data
                                Case "PRICEMATERIALEX" : z7361.PriceMaterialEX = Children(i).Data
                                Case "PRICEEXCHANGE" : z7361.PriceExchange = Children(i).Data
                                Case "SEUNITPRICE" : z7361.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z7361.cdUnitPrice = Children(i).Data
                                Case "PRICEMATERIALVND" : z7361.PriceMaterialVND = Children(i).Data
                                Case "PERTAX3" : z7361.PerTax3 = Children(i).Data
                                Case "DATEINSERT" : z7361.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z7361.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z7361.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z7361.InchargeUpdate = Children(i).Data
                                Case "REMARK" : z7361.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7361_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K7361_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7361 As T7361_AREA, Job As String, CheckClear As Boolean, CONTRACTID As String, CONTRACTSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7361_MOVE = False

        Try
            If READ_PFK7361(CONTRACTID, CONTRACTSEQ) = True Then
                z7361 = D7361
                K7361_MOVE = True
            Else
                If CheckClear = True Then z7361 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7361")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "CONTRACTID" : z7361.ContractID = Children(i).Code
                                Case "CONTRACTSEQ" : z7361.ContractSeq = Children(i).Code
                                Case "CHECKTYPE" : z7361.CheckType = Children(i).Code
                                Case "MATERIALCODE" : z7361.MaterialCode = Children(i).Code
                                Case "COLORNAME" : z7361.ColorName = Children(i).Code
                                Case "LINE" : z7361.Line = Children(i).Code
                                Case "ARTICLE" : z7361.Article = Children(i).Code
                                Case "CHECKSIZE" : z7361.CheckSize = Children(i).Code
                                Case "FROMSIZE" : z7361.FromSize = Children(i).Code
                                Case "TOSIZE" : z7361.ToSize = Children(i).Code
                                Case "PRICEMATERIALEX" : z7361.PriceMaterialEX = Children(i).Code
                                Case "PRICEEXCHANGE" : z7361.PriceExchange = Children(i).Code
                                Case "SEUNITPRICE" : z7361.seUnitPrice = Children(i).Code
                                Case "CDUNITPRICE" : z7361.cdUnitPrice = Children(i).Code
                                Case "PRICEMATERIALVND" : z7361.PriceMaterialVND = Children(i).Code
                                Case "PERTAX3" : z7361.PerTax3 = Children(i).Code
                                Case "DATEINSERT" : z7361.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z7361.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z7361.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z7361.InchargeUpdate = Children(i).Code
                                Case "REMARK" : z7361.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "CONTRACTID" : z7361.ContractID = Children(i).Data
                                Case "CONTRACTSEQ" : z7361.ContractSeq = Children(i).Data
                                Case "CHECKTYPE" : z7361.CheckType = Children(i).Data
                                Case "MATERIALCODE" : z7361.MaterialCode = Children(i).Data
                                Case "COLORNAME" : z7361.ColorName = Children(i).Data
                                Case "LINE" : z7361.Line = Children(i).Data
                                Case "ARTICLE" : z7361.Article = Children(i).Data
                                Case "CHECKSIZE" : z7361.CheckSize = Children(i).Data
                                Case "FROMSIZE" : z7361.FromSize = Children(i).Data
                                Case "TOSIZE" : z7361.ToSize = Children(i).Data
                                Case "PRICEMATERIALEX" : z7361.PriceMaterialEX = Children(i).Data
                                Case "PRICEEXCHANGE" : z7361.PriceExchange = Children(i).Data
                                Case "SEUNITPRICE" : z7361.seUnitPrice = Children(i).Data
                                Case "CDUNITPRICE" : z7361.cdUnitPrice = Children(i).Data
                                Case "PRICEMATERIALVND" : z7361.PriceMaterialVND = Children(i).Data
                                Case "PERTAX3" : z7361.PerTax3 = Children(i).Data
                                Case "DATEINSERT" : z7361.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z7361.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z7361.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z7361.InchargeUpdate = Children(i).Data
                                Case "REMARK" : z7361.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7361_MOVE", vbCritical)
        End Try
    End Function

End Module
