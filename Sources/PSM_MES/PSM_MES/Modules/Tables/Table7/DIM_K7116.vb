'=========================================================================================================================================================
'   TABLE : (PFK7116)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7116

Structure T7116_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	CostBOM	 AS String	'			char(6)		*
Public 	CostSeq	 AS Double	'			decimal		*
        Public CostType As String  '			char(1)		*
        Public Dseq As Double  '			decimal
        Public seCBDCost As String  '			char(3)
        Public cdCBDCost As String  '			char(3)
        Public seCostingType As String  '			char(3)
        Public cdCostingType As String  '			char(3)
        Public Price As Double  '			decimal
        Public QtyCost As Double  '			decimal
        Public AMTCost As Double  '			decimal
        Public InsertDate As String  '			char(8)
        Public InchargeInsert As String  '			char(8)
        Public UpdateDate As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        Public AttachID As String  '			char(6)
        Public Remark As String  '			nvarchar(50)
        '=========================================================================================================================================================
    End Structure

    Public D7116 As T7116_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK7116(COSTBOM As String, COSTSEQ As Double, COSTTYPE As String) As Boolean
        READ_PFK7116 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7116 "
            SQL = SQL & " WHERE K7116_CostBOM		 = '" & CostBOM & "' "
            SQL = SQL & "   AND K7116_CostSeq		 =  " & CostSeq & "  "
            SQL = SQL & "   AND K7116_CostType		 = '" & CostType & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7116_CLEAR() : GoTo SKIP_READ_PFK7116

            Call K7116_MOVE(rd)
            READ_PFK7116 = True

SKIP_READ_PFK7116:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7116", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK7116(COSTBOM As String, COSTSEQ As Double, COSTTYPE As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7116 "
            SQL = SQL & " WHERE K7116_CostBOM		 = '" & CostBOM & "' "
            SQL = SQL & "   AND K7116_CostSeq		 =  " & CostSeq & "  "
            SQL = SQL & "   AND K7116_CostType		 = '" & CostType & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK7116", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK7116(z7116 As T7116_AREA) As Boolean
        WRITE_PFK7116 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7116)

            SQL = " INSERT INTO PFK7116 "
            SQL = SQL & " ( "
            SQL = SQL & " K7116_CostBOM,"
            SQL = SQL & " K7116_CostSeq,"
            SQL = SQL & " K7116_CostType,"
            SQL = SQL & " K7116_Dseq,"
            SQL = SQL & " K7116_seCBDCost,"
            SQL = SQL & " K7116_cdCBDCost,"
            SQL = SQL & " K7116_seCostingType,"
            SQL = SQL & " K7116_cdCostingType,"
            SQL = SQL & " K7116_Price,"
            SQL = SQL & " K7116_QtyCost,"
            SQL = SQL & " K7116_AMTCost,"
            SQL = SQL & " K7116_InsertDate,"
            SQL = SQL & " K7116_InchargeInsert,"
            SQL = SQL & " K7116_UpdateDate,"
            SQL = SQL & " K7116_InchargeUpdate,"
            SQL = SQL & " K7116_AttachID,"
            SQL = SQL & " K7116_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z7116.CostBOM) & "', "
            SQL = SQL & "   " & FormatSQL(z7116.CostSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7116.CostType) & "', "
            SQL = SQL & "   " & FormatSQL(z7116.Dseq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7116.seCBDCost) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7116.cdCBDCost) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7116.seCostingType) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7116.cdCostingType) & "', "
            SQL = SQL & "   " & FormatSQL(z7116.Price) & ", "
            SQL = SQL & "   " & FormatSQL(z7116.QtyCost) & ", "
            SQL = SQL & "   " & FormatSQL(z7116.AMTCost) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7116.InsertDate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7116.InchargeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7116.UpdateDate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7116.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7116.AttachID) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7116.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK7116 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK7116", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK7116(z7116 As T7116_AREA) As Boolean
        REWRITE_PFK7116 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7116)

            SQL = " UPDATE PFK7116 SET "
            SQL = SQL & "    K7116_Dseq      =  " & FormatSQL(z7116.Dseq) & ", "
            SQL = SQL & "    K7116_seCBDCost      = N'" & FormatSQL(z7116.seCBDCost) & "', "
            SQL = SQL & "    K7116_cdCBDCost      = N'" & FormatSQL(z7116.cdCBDCost) & "', "
            SQL = SQL & "    K7116_seCostingType      = N'" & FormatSQL(z7116.seCostingType) & "', "
            SQL = SQL & "    K7116_cdCostingType      = N'" & FormatSQL(z7116.cdCostingType) & "', "
            SQL = SQL & "    K7116_Price      =  " & FormatSQL(z7116.Price) & ", "
            SQL = SQL & "    K7116_QtyCost      =  " & FormatSQL(z7116.QtyCost) & ", "
            SQL = SQL & "    K7116_AMTCost      =  " & FormatSQL(z7116.AMTCost) & ", "
            SQL = SQL & "    K7116_InsertDate      = N'" & FormatSQL(z7116.InsertDate) & "', "
            SQL = SQL & "    K7116_InchargeInsert      = N'" & FormatSQL(z7116.InchargeInsert) & "', "
            SQL = SQL & "    K7116_UpdateDate      = N'" & FormatSQL(z7116.UpdateDate) & "', "
            SQL = SQL & "    K7116_InchargeUpdate      = N'" & FormatSQL(z7116.InchargeUpdate) & "', "
            SQL = SQL & "    K7116_AttachID      = N'" & FormatSQL(z7116.AttachID) & "', "
            SQL = SQL & "    K7116_Remark      = N'" & FormatSQL(z7116.Remark) & "'  "
            SQL = SQL & " WHERE K7116_CostBOM		 = '" & z7116.CostBOM & "' "
            SQL = SQL & "   AND K7116_CostSeq		 =  " & z7116.CostSeq & "  "
            SQL = SQL & "   AND K7116_CostType		 = '" & z7116.CostType & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK7116 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK7116", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK7116(z7116 As T7116_AREA) As Boolean
        DELETE_PFK7116 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK7116 "
            SQL = SQL & " WHERE K7116_CostBOM		 = '" & z7116.CostBOM & "' "
            SQL = SQL & "   AND K7116_CostSeq		 =  " & z7116.CostSeq & "  "
            SQL = SQL & "   AND K7116_CostType		 = '" & z7116.CostType & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7116 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7116", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D7116_CLEAR()
        Try

            D7116.CostBOM = ""
            D7116.CostSeq = 0
            D7116.CostType = ""
            D7116.Dseq = 0
            D7116.seCBDCost = ""
            D7116.cdCBDCost = ""
            D7116.seCostingType = ""
            D7116.cdCostingType = ""
            D7116.Price = 0
            D7116.QtyCost = 0
            D7116.AMTCost = 0
            D7116.InsertDate = ""
            D7116.InchargeInsert = ""
            D7116.UpdateDate = ""
            D7116.InchargeUpdate = ""
            D7116.AttachID = ""
            D7116.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D7116_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x7116 As T7116_AREA)
        Try

            x7116.CostBOM = trim$(x7116.CostBOM)
            x7116.CostSeq = trim$(x7116.CostSeq)
            x7116.CostType = trim$(x7116.CostType)
            x7116.Dseq = trim$(x7116.Dseq)
            x7116.seCBDCost = trim$(x7116.seCBDCost)
            x7116.cdCBDCost = trim$(x7116.cdCBDCost)
            x7116.seCostingType = trim$(x7116.seCostingType)
            x7116.cdCostingType = trim$(x7116.cdCostingType)
            x7116.Price = trim$(x7116.Price)
            x7116.QtyCost = trim$(x7116.QtyCost)
            x7116.AMTCost = trim$(x7116.AMTCost)
            x7116.InsertDate = trim$(x7116.InsertDate)
            x7116.InchargeInsert = trim$(x7116.InchargeInsert)
            x7116.UpdateDate = trim$(x7116.UpdateDate)
            x7116.InchargeUpdate = trim$(x7116.InchargeUpdate)
            x7116.AttachID = trim$(x7116.AttachID)
            x7116.Remark = trim$(x7116.Remark)

            If trim$(x7116.CostBOM) = "" Then x7116.CostBOM = Space(1)
            If trim$(x7116.CostSeq) = "" Then x7116.CostSeq = 0
            If trim$(x7116.CostType) = "" Then x7116.CostType = Space(1)
            If trim$(x7116.Dseq) = "" Then x7116.Dseq = 0
            If trim$(x7116.seCBDCost) = "" Then x7116.seCBDCost = Space(1)
            If trim$(x7116.cdCBDCost) = "" Then x7116.cdCBDCost = Space(1)
            If trim$(x7116.seCostingType) = "" Then x7116.seCostingType = Space(1)
            If trim$(x7116.cdCostingType) = "" Then x7116.cdCostingType = Space(1)
            If trim$(x7116.Price) = "" Then x7116.Price = 0
            If trim$(x7116.QtyCost) = "" Then x7116.QtyCost = 0
            If trim$(x7116.AMTCost) = "" Then x7116.AMTCost = 0
            If trim$(x7116.InsertDate) = "" Then x7116.InsertDate = Space(1)
            If trim$(x7116.InchargeInsert) = "" Then x7116.InchargeInsert = Space(1)
            If trim$(x7116.UpdateDate) = "" Then x7116.UpdateDate = Space(1)
            If trim$(x7116.InchargeUpdate) = "" Then x7116.InchargeUpdate = Space(1)
            If trim$(x7116.AttachID) = "" Then x7116.AttachID = Space(1)
            If trim$(x7116.Remark) = "" Then x7116.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K7116_MOVE(rs7116 As SqlClient.SqlDataReader)
        Try

            Call D7116_CLEAR()

            If IsdbNull(rs7116!K7116_CostBOM) = False Then D7116.CostBOM = Trim$(rs7116!K7116_CostBOM)
            If IsdbNull(rs7116!K7116_CostSeq) = False Then D7116.CostSeq = Trim$(rs7116!K7116_CostSeq)
            If IsdbNull(rs7116!K7116_CostType) = False Then D7116.CostType = Trim$(rs7116!K7116_CostType)
            If IsdbNull(rs7116!K7116_Dseq) = False Then D7116.Dseq = Trim$(rs7116!K7116_Dseq)
            If IsdbNull(rs7116!K7116_seCBDCost) = False Then D7116.seCBDCost = Trim$(rs7116!K7116_seCBDCost)
            If IsdbNull(rs7116!K7116_cdCBDCost) = False Then D7116.cdCBDCost = Trim$(rs7116!K7116_cdCBDCost)
            If IsdbNull(rs7116!K7116_seCostingType) = False Then D7116.seCostingType = Trim$(rs7116!K7116_seCostingType)
            If IsdbNull(rs7116!K7116_cdCostingType) = False Then D7116.cdCostingType = Trim$(rs7116!K7116_cdCostingType)
            If IsdbNull(rs7116!K7116_Price) = False Then D7116.Price = Trim$(rs7116!K7116_Price)
            If IsdbNull(rs7116!K7116_QtyCost) = False Then D7116.QtyCost = Trim$(rs7116!K7116_QtyCost)
            If IsdbNull(rs7116!K7116_AMTCost) = False Then D7116.AMTCost = Trim$(rs7116!K7116_AMTCost)
            If IsdbNull(rs7116!K7116_InsertDate) = False Then D7116.InsertDate = Trim$(rs7116!K7116_InsertDate)
            If IsdbNull(rs7116!K7116_InchargeInsert) = False Then D7116.InchargeInsert = Trim$(rs7116!K7116_InchargeInsert)
            If IsdbNull(rs7116!K7116_UpdateDate) = False Then D7116.UpdateDate = Trim$(rs7116!K7116_UpdateDate)
            If IsdbNull(rs7116!K7116_InchargeUpdate) = False Then D7116.InchargeUpdate = Trim$(rs7116!K7116_InchargeUpdate)
            If IsdbNull(rs7116!K7116_AttachID) = False Then D7116.AttachID = Trim$(rs7116!K7116_AttachID)
            If IsdbNull(rs7116!K7116_Remark) = False Then D7116.Remark = Trim$(rs7116!K7116_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7116_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K7116_MOVE(rs7116 As DataRow)
        Try

            Call D7116_CLEAR()

            If IsdbNull(rs7116!K7116_CostBOM) = False Then D7116.CostBOM = Trim$(rs7116!K7116_CostBOM)
            If IsdbNull(rs7116!K7116_CostSeq) = False Then D7116.CostSeq = Trim$(rs7116!K7116_CostSeq)
            If IsdbNull(rs7116!K7116_CostType) = False Then D7116.CostType = Trim$(rs7116!K7116_CostType)
            If IsdbNull(rs7116!K7116_Dseq) = False Then D7116.Dseq = Trim$(rs7116!K7116_Dseq)
            If IsdbNull(rs7116!K7116_seCBDCost) = False Then D7116.seCBDCost = Trim$(rs7116!K7116_seCBDCost)
            If IsdbNull(rs7116!K7116_cdCBDCost) = False Then D7116.cdCBDCost = Trim$(rs7116!K7116_cdCBDCost)
            If IsdbNull(rs7116!K7116_seCostingType) = False Then D7116.seCostingType = Trim$(rs7116!K7116_seCostingType)
            If IsdbNull(rs7116!K7116_cdCostingType) = False Then D7116.cdCostingType = Trim$(rs7116!K7116_cdCostingType)
            If IsdbNull(rs7116!K7116_Price) = False Then D7116.Price = Trim$(rs7116!K7116_Price)
            If IsdbNull(rs7116!K7116_QtyCost) = False Then D7116.QtyCost = Trim$(rs7116!K7116_QtyCost)
            If IsdbNull(rs7116!K7116_AMTCost) = False Then D7116.AMTCost = Trim$(rs7116!K7116_AMTCost)
            If IsdbNull(rs7116!K7116_InsertDate) = False Then D7116.InsertDate = Trim$(rs7116!K7116_InsertDate)
            If IsdbNull(rs7116!K7116_InchargeInsert) = False Then D7116.InchargeInsert = Trim$(rs7116!K7116_InchargeInsert)
            If IsdbNull(rs7116!K7116_UpdateDate) = False Then D7116.UpdateDate = Trim$(rs7116!K7116_UpdateDate)
            If IsdbNull(rs7116!K7116_InchargeUpdate) = False Then D7116.InchargeUpdate = Trim$(rs7116!K7116_InchargeUpdate)
            If IsdbNull(rs7116!K7116_AttachID) = False Then D7116.AttachID = Trim$(rs7116!K7116_AttachID)
            If IsdbNull(rs7116!K7116_Remark) = False Then D7116.Remark = Trim$(rs7116!K7116_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7116_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K7116_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7116 As T7116_AREA, COSTBOM As String, COSTSEQ As Double, COSTTYPE As String) As Boolean

        K7116_MOVE = False

        Try
            If READ_PFK7116(COSTBOM, COSTSEQ, COSTTYPE) = True Then
                z7116 = D7116
                K7116_MOVE = True
            Else
                z7116 = Nothing
            End If

            If getColumIndex(spr, "CostBOM") > -1 Then z7116.CostBOM = getDataM(spr, getColumIndex(spr, "CostBOM"), xRow)
            If getColumIndex(spr, "CostSeq") > -1 Then z7116.CostSeq = getDataM(spr, getColumIndex(spr, "CostSeq"), xRow)
            If getColumIndex(spr, "CostType") > -1 Then z7116.CostType = getDataM(spr, getColumIndex(spr, "CostType"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z7116.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "seCBDCost") > -1 Then z7116.seCBDCost = getDataM(spr, getColumIndex(spr, "seCBDCost"), xRow)
            If getColumIndex(spr, "cdCBDCost") > -1 Then z7116.cdCBDCost = getDataM(spr, getColumIndex(spr, "cdCBDCost"), xRow)
            If getColumIndex(spr, "seCostingType") > -1 Then z7116.seCostingType = getDataM(spr, getColumIndex(spr, "seCostingType"), xRow)
            If getColumIndex(spr, "cdCostingType") > -1 Then z7116.cdCostingType = getDataM(spr, getColumIndex(spr, "cdCostingType"), xRow)
            If getColumIndex(spr, "Price") > -1 Then z7116.Price = getDataM(spr, getColumIndex(spr, "Price"), xRow)
            If getColumIndex(spr, "QtyCost") > -1 Then z7116.QtyCost = getDataM(spr, getColumIndex(spr, "QtyCost"), xRow)
            If getColumIndex(spr, "AMTCost") > -1 Then z7116.AMTCost = getDataM(spr, getColumIndex(spr, "AMTCost"), xRow)
            If getColumIndex(spr, "InsertDate") > -1 Then z7116.InsertDate = getDataM(spr, getColumIndex(spr, "InsertDate"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z7116.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "UpdateDate") > -1 Then z7116.UpdateDate = getDataM(spr, getColumIndex(spr, "UpdateDate"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z7116.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "AttachID") > -1 Then z7116.AttachID = getDataM(spr, getColumIndex(spr, "AttachID"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z7116.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7116_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K7116_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7116 As T7116_AREA, CheckClear As Boolean, COSTBOM As String, COSTSEQ As Double, COSTTYPE As String) As Boolean

        K7116_MOVE = False

        Try
            If READ_PFK7116(COSTBOM, COSTSEQ, COSTTYPE) = True Then
                z7116 = D7116
                K7116_MOVE = True
            Else
                If CheckClear = True Then z7116 = Nothing
            End If

            If getColumIndex(spr, "CostBOM") > -1 Then z7116.CostBOM = getDataM(spr, getColumIndex(spr, "CostBOM"), xRow)
            If getColumIndex(spr, "CostSeq") > -1 Then z7116.CostSeq = getDataM(spr, getColumIndex(spr, "CostSeq"), xRow)
            If getColumIndex(spr, "CostType") > -1 Then z7116.CostType = getDataM(spr, getColumIndex(spr, "CostType"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z7116.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "seCBDCost") > -1 Then z7116.seCBDCost = getDataM(spr, getColumIndex(spr, "seCBDCost"), xRow)
            If getColumIndex(spr, "cdCBDCost") > -1 Then z7116.cdCBDCost = getDataM(spr, getColumIndex(spr, "cdCBDCost"), xRow)
            If getColumIndex(spr, "seCostingType") > -1 Then z7116.seCostingType = getDataM(spr, getColumIndex(spr, "seCostingType"), xRow)
            If getColumIndex(spr, "cdCostingType") > -1 Then z7116.cdCostingType = getDataM(spr, getColumIndex(spr, "cdCostingType"), xRow)
            If getColumIndex(spr, "Price") > -1 Then z7116.Price = getDataM(spr, getColumIndex(spr, "Price"), xRow)
            If getColumIndex(spr, "QtyCost") > -1 Then z7116.QtyCost = getDataM(spr, getColumIndex(spr, "QtyCost"), xRow)
            If getColumIndex(spr, "AMTCost") > -1 Then z7116.AMTCost = getDataM(spr, getColumIndex(spr, "AMTCost"), xRow)
            If getColumIndex(spr, "InsertDate") > -1 Then z7116.InsertDate = getDataM(spr, getColumIndex(spr, "InsertDate"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z7116.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "UpdateDate") > -1 Then z7116.UpdateDate = getDataM(spr, getColumIndex(spr, "UpdateDate"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z7116.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "AttachID") > -1 Then z7116.AttachID = getDataM(spr, getColumIndex(spr, "AttachID"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z7116.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7116_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K7116_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7116 As T7116_AREA, Job As String, COSTBOM As String, COSTSEQ As Double, COSTTYPE As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7116_MOVE = False

        Try
            If READ_PFK7116(COSTBOM, COSTSEQ, COSTTYPE) = True Then
                z7116 = D7116
                K7116_MOVE = True
            Else
                z7116 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7116")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "COSTBOM" : z7116.CostBOM = Children(i).Code
                                Case "COSTSEQ" : z7116.CostSeq = Children(i).Code
                                Case "COSTTYPE" : z7116.CostType = Children(i).Code
                                Case "DSEQ" : z7116.Dseq = Children(i).Code
                                Case "SECBDCOST" : z7116.seCBDCost = Children(i).Code
                                Case "CDCBDCOST" : z7116.cdCBDCost = Children(i).Code
                                Case "SECOSTINGTYPE" : z7116.seCostingType = Children(i).Code
                                Case "CDCOSTINGTYPE" : z7116.cdCostingType = Children(i).Code
                                Case "PRICE" : z7116.Price = Children(i).Code
                                Case "QTYCOST" : z7116.QtyCost = Children(i).Code
                                Case "AMTCOST" : z7116.AMTCost = Children(i).Code
                                Case "INSERTDATE" : z7116.InsertDate = Children(i).Code
                                Case "INCHARGEINSERT" : z7116.InchargeInsert = Children(i).Code
                                Case "UPDATEDATE" : z7116.UpdateDate = Children(i).Code
                                Case "INCHARGEUPDATE" : z7116.InchargeUpdate = Children(i).Code
                                Case "ATTACHID" : z7116.AttachID = Children(i).Code
                                Case "REMARK" : z7116.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "COSTBOM" : z7116.CostBOM = Children(i).Data
                                Case "COSTSEQ" : z7116.CostSeq = Children(i).Data
                                Case "COSTTYPE" : z7116.CostType = Children(i).Data
                                Case "DSEQ" : z7116.Dseq = Children(i).Data
                                Case "SECBDCOST" : z7116.seCBDCost = Children(i).Data
                                Case "CDCBDCOST" : z7116.cdCBDCost = Children(i).Data
                                Case "SECOSTINGTYPE" : z7116.seCostingType = Children(i).Data
                                Case "CDCOSTINGTYPE" : z7116.cdCostingType = Children(i).Data
                                Case "PRICE" : z7116.Price = Children(i).Data
                                Case "QTYCOST" : z7116.QtyCost = Children(i).Data
                                Case "AMTCOST" : z7116.AMTCost = Children(i).Data
                                Case "INSERTDATE" : z7116.InsertDate = Children(i).Data
                                Case "INCHARGEINSERT" : z7116.InchargeInsert = Children(i).Data
                                Case "UPDATEDATE" : z7116.UpdateDate = Children(i).Data
                                Case "INCHARGEUPDATE" : z7116.InchargeUpdate = Children(i).Data
                                Case "ATTACHID" : z7116.AttachID = Children(i).Data
                                Case "REMARK" : z7116.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7116_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K7116_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7116 As T7116_AREA, Job As String, CheckClear As Boolean, COSTBOM As String, COSTSEQ As Double, COSTTYPE As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7116_MOVE = False

        Try
            If READ_PFK7116(COSTBOM, COSTSEQ, COSTTYPE) = True Then
                z7116 = D7116
                K7116_MOVE = True
            Else
                If CheckClear = True Then z7116 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7116")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "COSTBOM" : z7116.CostBOM = Children(i).Code
                                Case "COSTSEQ" : z7116.CostSeq = Children(i).Code
                                Case "COSTTYPE" : z7116.CostType = Children(i).Code
                                Case "DSEQ" : z7116.Dseq = Children(i).Code
                                Case "SECBDCOST" : z7116.seCBDCost = Children(i).Code
                                Case "CDCBDCOST" : z7116.cdCBDCost = Children(i).Code
                                Case "SECOSTINGTYPE" : z7116.seCostingType = Children(i).Code
                                Case "CDCOSTINGTYPE" : z7116.cdCostingType = Children(i).Code
                                Case "PRICE" : z7116.Price = Children(i).Code
                                Case "QTYCOST" : z7116.QtyCost = Children(i).Code
                                Case "AMTCOST" : z7116.AMTCost = Children(i).Code
                                Case "INSERTDATE" : z7116.InsertDate = Children(i).Code
                                Case "INCHARGEINSERT" : z7116.InchargeInsert = Children(i).Code
                                Case "UPDATEDATE" : z7116.UpdateDate = Children(i).Code
                                Case "INCHARGEUPDATE" : z7116.InchargeUpdate = Children(i).Code
                                Case "ATTACHID" : z7116.AttachID = Children(i).Code
                                Case "REMARK" : z7116.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "COSTBOM" : z7116.CostBOM = Children(i).Data
                                Case "COSTSEQ" : z7116.CostSeq = Children(i).Data
                                Case "COSTTYPE" : z7116.CostType = Children(i).Data
                                Case "DSEQ" : z7116.Dseq = Children(i).Data
                                Case "SECBDCOST" : z7116.seCBDCost = Children(i).Data
   Case "CDCBDCOST":z7116.cdCBDCost = Children(i).Data
   Case "SECOSTINGTYPE":z7116.seCostingType = Children(i).Data
   Case "CDCOSTINGTYPE":z7116.cdCostingType = Children(i).Data
   Case "PRICE":z7116.Price = Children(i).Data
   Case "QTYCOST":z7116.QtyCost = Children(i).Data
   Case "AMTCOST":z7116.AMTCost = Children(i).Data
   Case "INSERTDATE":z7116.InsertDate = Children(i).Data
   Case "INCHARGEINSERT":z7116.InchargeInsert = Children(i).Data
   Case "UPDATEDATE":z7116.UpdateDate = Children(i).Data
   Case "INCHARGEUPDATE":z7116.InchargeUpdate = Children(i).Data
   Case "ATTACHID":z7116.AttachID = Children(i).Data
   Case "REMARK":z7116.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7116_MOVE",vbCritical)
End Try
End Function 
    
End Module 
