'=========================================================================================================================================================
'   TABLE : (PFK2554)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K2554

    Structure T2554_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public Autokey As Double  '			decimal		*
        Public DateAudit As String  '			char(8)
        Public MaterialInBoundNo As String  '			char(9)
        Public MaterialInBoundSeq As String  '			char(3)
        Public MaterialInBoundSno As Double  '			decimal
        Public MaterialInBoundDseq As Double  '			decimal
        Public PackAudit As Double  '			decimal
        Public QtyAudit As Double  '			decimal
        Public QtyAdjust As Double  '			decimal
        Public seWareHousePosition As String  '			char(3)
        Public cdWareHousePosition As String  '			char(3)
        Public CheckComplete As String  '			char(1)
        Public InchargeAudit As String  '			char(8)
        Public Remark As String  '			nvarchar(100)
        '=========================================================================================================================================================
    End Structure

    Public D2554 As T2554_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK2554(AUTOKEY As Double) As Boolean
        READ_PFK2554 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2554 "
            SQL = SQL & " WHERE K2554_Autokey		 =  " & Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D2554_CLEAR() : GoTo SKIP_READ_PFK2554

            Call K2554_MOVE(rd)
            READ_PFK2554 = True

SKIP_READ_PFK2554:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK2554", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK2554(AUTOKEY As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2554 "
            SQL = SQL & " WHERE K2554_Autokey		 =  " & Autokey & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK2554", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK2554(z2554 As T2554_AREA) As Boolean
        WRITE_PFK2554 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z2554)

            SQL = " INSERT INTO PFK2554 "
            SQL = SQL & " ( "
            SQL = SQL & " K2554_Autokey,"
            SQL = SQL & " K2554_DateAudit,"
            SQL = SQL & " K2554_MaterialInBoundNo,"
            SQL = SQL & " K2554_MaterialInBoundSeq,"
            SQL = SQL & " K2554_MaterialInBoundSno,"
            SQL = SQL & " K2554_MaterialInBoundDseq,"
            SQL = SQL & " K2554_PackAudit,"
            SQL = SQL & " K2554_QtyAudit,"
            SQL = SQL & " K2554_QtyAdjust,"
            SQL = SQL & " K2554_seWareHousePosition,"
            SQL = SQL & " K2554_cdWareHousePosition,"
            SQL = SQL & " K2554_CheckComplete,"
            SQL = SQL & " K2554_InchargeAudit,"
            SQL = SQL & " K2554_TimeAudit,"
            SQL = SQL & " K2554_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "   " & FormatSQL(z2554.Autokey) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2554.DateAudit) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2554.MaterialInBoundNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2554.MaterialInBoundSeq) & "', "
            SQL = SQL & "   " & FormatSQL(z2554.MaterialInBoundSno) & ", "
            SQL = SQL & "   " & FormatSQL(z2554.MaterialInBoundDseq) & ", "
            SQL = SQL & "   " & FormatSQL(z2554.PackAudit) & ", "
            SQL = SQL & "   " & FormatSQL(z2554.QtyAudit) & ", "
            SQL = SQL & "   " & FormatSQL(z2554.QtyAdjust) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2554.seWareHousePosition) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2554.cdWareHousePosition) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2554.CheckComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2554.InchargeAudit) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2554.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK2554 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK2554", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK2554(z2554 As T2554_AREA) As Boolean
        REWRITE_PFK2554 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z2554)

            SQL = " UPDATE PFK2554 SET "
            SQL = SQL & "    K2554_DateAudit      = N'" & FormatSQL(z2554.DateAudit) & "', "
            SQL = SQL & "    K2554_MaterialInBoundNo      = N'" & FormatSQL(z2554.MaterialInBoundNo) & "', "
            SQL = SQL & "    K2554_MaterialInBoundSeq      = N'" & FormatSQL(z2554.MaterialInBoundSeq) & "', "
            SQL = SQL & "    K2554_MaterialInBoundSno      =  " & FormatSQL(z2554.MaterialInBoundSno) & ", "
            SQL = SQL & "    K2554_MaterialInBoundDseq      =  " & FormatSQL(z2554.MaterialInBoundDseq) & ", "
            SQL = SQL & "    K2554_PackAudit      =  " & FormatSQL(z2554.PackAudit) & ", "
            SQL = SQL & "    K2554_QtyAudit      =  " & FormatSQL(z2554.QtyAudit) & ", "
            SQL = SQL & "    K2554_QtyAdjust      =  " & FormatSQL(z2554.QtyAdjust) & ", "
            SQL = SQL & "    K2554_seWareHousePosition      = N'" & FormatSQL(z2554.seWareHousePosition) & "', "
            SQL = SQL & "    K2554_cdWareHousePosition      = N'" & FormatSQL(z2554.cdWareHousePosition) & "', "
            SQL = SQL & "    K2554_CheckComplete      = N'" & FormatSQL(z2554.CheckComplete) & "', "
            SQL = SQL & "    K2554_InchargeAudit      = N'" & FormatSQL(z2554.InchargeAudit) & "', "
            SQL = SQL & "    K2554_Remark      = N'" & FormatSQL(z2554.Remark) & "'  "
            SQL = SQL & " WHERE K2554_Autokey		 =  " & z2554.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK2554 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK2554", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK2554(z2554 As T2554_AREA) As Boolean
        DELETE_PFK2554 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK2554 "
            SQL = SQL & " WHERE K2554_Autokey		 =  " & z2554.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK2554 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK2554", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D2554_CLEAR()
        Try

            D2554.Autokey = 0
            D2554.DateAudit = ""
            D2554.MaterialInBoundNo = ""
            D2554.MaterialInBoundSeq = ""
            D2554.MaterialInBoundSno = 0
            D2554.MaterialInBoundDseq = 0
            D2554.PackAudit = 0
            D2554.QtyAudit = 0
            D2554.QtyAdjust = 0
            D2554.seWareHousePosition = ""
            D2554.cdWareHousePosition = ""
            D2554.CheckComplete = ""
            D2554.InchargeAudit = ""
            D2554.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D2554_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x2554 As T2554_AREA)
        Try

            x2554.Autokey = trim$(x2554.Autokey)
            x2554.DateAudit = trim$(x2554.DateAudit)
            x2554.MaterialInBoundNo = trim$(x2554.MaterialInBoundNo)
            x2554.MaterialInBoundSeq = trim$(x2554.MaterialInBoundSeq)
            x2554.MaterialInBoundSno = trim$(x2554.MaterialInBoundSno)
            x2554.MaterialInBoundDseq = trim$(x2554.MaterialInBoundDseq)
            x2554.PackAudit = trim$(x2554.PackAudit)
            x2554.QtyAudit = trim$(x2554.QtyAudit)
            x2554.QtyAdjust = trim$(x2554.QtyAdjust)
            x2554.seWareHousePosition = trim$(x2554.seWareHousePosition)
            x2554.cdWareHousePosition = trim$(x2554.cdWareHousePosition)
            x2554.CheckComplete = trim$(x2554.CheckComplete)
            x2554.InchargeAudit = trim$(x2554.InchargeAudit)
            x2554.Remark = Trim$(x2554.Remark)

            If trim$(x2554.Autokey) = "" Then x2554.Autokey = 0
            If trim$(x2554.DateAudit) = "" Then x2554.DateAudit = Space(1)
            If trim$(x2554.MaterialInBoundNo) = "" Then x2554.MaterialInBoundNo = Space(1)
            If trim$(x2554.MaterialInBoundSeq) = "" Then x2554.MaterialInBoundSeq = Space(1)
            If trim$(x2554.MaterialInBoundSno) = "" Then x2554.MaterialInBoundSno = 0
            If trim$(x2554.MaterialInBoundDseq) = "" Then x2554.MaterialInBoundDseq = 0
            If trim$(x2554.PackAudit) = "" Then x2554.PackAudit = 0
            If trim$(x2554.QtyAudit) = "" Then x2554.QtyAudit = 0
            If trim$(x2554.QtyAdjust) = "" Then x2554.QtyAdjust = 0
            If trim$(x2554.seWareHousePosition) = "" Then x2554.seWareHousePosition = Space(1)
            If trim$(x2554.cdWareHousePosition) = "" Then x2554.cdWareHousePosition = Space(1)
            If trim$(x2554.CheckComplete) = "" Then x2554.CheckComplete = Space(1)
            If trim$(x2554.InchargeAudit) = "" Then x2554.InchargeAudit = Space(1)
            If Trim$(x2554.Remark) = "" Then x2554.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K2554_MOVE(rs2554 As SqlClient.SqlDataReader)
        Try

            Call D2554_CLEAR()

            If IsdbNull(rs2554!K2554_Autokey) = False Then D2554.Autokey = Trim$(rs2554!K2554_Autokey)
            If IsdbNull(rs2554!K2554_DateAudit) = False Then D2554.DateAudit = Trim$(rs2554!K2554_DateAudit)
            If IsdbNull(rs2554!K2554_MaterialInBoundNo) = False Then D2554.MaterialInBoundNo = Trim$(rs2554!K2554_MaterialInBoundNo)
            If IsdbNull(rs2554!K2554_MaterialInBoundSeq) = False Then D2554.MaterialInBoundSeq = Trim$(rs2554!K2554_MaterialInBoundSeq)
            If IsdbNull(rs2554!K2554_MaterialInBoundSno) = False Then D2554.MaterialInBoundSno = Trim$(rs2554!K2554_MaterialInBoundSno)
            If IsdbNull(rs2554!K2554_MaterialInBoundDseq) = False Then D2554.MaterialInBoundDseq = Trim$(rs2554!K2554_MaterialInBoundDseq)
            If IsdbNull(rs2554!K2554_PackAudit) = False Then D2554.PackAudit = Trim$(rs2554!K2554_PackAudit)
            If IsdbNull(rs2554!K2554_QtyAudit) = False Then D2554.QtyAudit = Trim$(rs2554!K2554_QtyAudit)
            If IsdbNull(rs2554!K2554_QtyAdjust) = False Then D2554.QtyAdjust = Trim$(rs2554!K2554_QtyAdjust)
            If IsdbNull(rs2554!K2554_seWareHousePosition) = False Then D2554.seWareHousePosition = Trim$(rs2554!K2554_seWareHousePosition)
            If IsdbNull(rs2554!K2554_cdWareHousePosition) = False Then D2554.cdWareHousePosition = Trim$(rs2554!K2554_cdWareHousePosition)
            If IsdbNull(rs2554!K2554_CheckComplete) = False Then D2554.CheckComplete = Trim$(rs2554!K2554_CheckComplete)
            If IsdbNull(rs2554!K2554_InchargeAudit) = False Then D2554.InchargeAudit = Trim$(rs2554!K2554_InchargeAudit)
            If IsDBNull(rs2554!K2554_Remark) = False Then D2554.Remark = Trim$(rs2554!K2554_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K2554_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K2554_MOVE(rs2554 As DataRow)
        Try

            Call D2554_CLEAR()

            If IsdbNull(rs2554!K2554_Autokey) = False Then D2554.Autokey = Trim$(rs2554!K2554_Autokey)
            If IsdbNull(rs2554!K2554_DateAudit) = False Then D2554.DateAudit = Trim$(rs2554!K2554_DateAudit)
            If IsdbNull(rs2554!K2554_MaterialInBoundNo) = False Then D2554.MaterialInBoundNo = Trim$(rs2554!K2554_MaterialInBoundNo)
            If IsdbNull(rs2554!K2554_MaterialInBoundSeq) = False Then D2554.MaterialInBoundSeq = Trim$(rs2554!K2554_MaterialInBoundSeq)
            If IsdbNull(rs2554!K2554_MaterialInBoundSno) = False Then D2554.MaterialInBoundSno = Trim$(rs2554!K2554_MaterialInBoundSno)
            If IsdbNull(rs2554!K2554_MaterialInBoundDseq) = False Then D2554.MaterialInBoundDseq = Trim$(rs2554!K2554_MaterialInBoundDseq)
            If IsdbNull(rs2554!K2554_PackAudit) = False Then D2554.PackAudit = Trim$(rs2554!K2554_PackAudit)
            If IsdbNull(rs2554!K2554_QtyAudit) = False Then D2554.QtyAudit = Trim$(rs2554!K2554_QtyAudit)
            If IsdbNull(rs2554!K2554_QtyAdjust) = False Then D2554.QtyAdjust = Trim$(rs2554!K2554_QtyAdjust)
            If IsdbNull(rs2554!K2554_seWareHousePosition) = False Then D2554.seWareHousePosition = Trim$(rs2554!K2554_seWareHousePosition)
            If IsdbNull(rs2554!K2554_cdWareHousePosition) = False Then D2554.cdWareHousePosition = Trim$(rs2554!K2554_cdWareHousePosition)
            If IsdbNull(rs2554!K2554_CheckComplete) = False Then D2554.CheckComplete = Trim$(rs2554!K2554_CheckComplete)
            If IsdbNull(rs2554!K2554_InchargeAudit) = False Then D2554.InchargeAudit = Trim$(rs2554!K2554_InchargeAudit)
            If IsDBNull(rs2554!K2554_Remark) = False Then D2554.Remark = Trim$(rs2554!K2554_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K2554_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K2554_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z2554 As T2554_AREA, AUTOKEY As Double) As Boolean

        K2554_MOVE = False

        Try
            If READ_PFK2554(AUTOKEY) = True Then
                z2554 = D2554
                K2554_MOVE = True
            Else
                z2554 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z2554.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "DateAudit") > -1 Then z2554.DateAudit = getDataM(spr, getColumIndex(spr, "DateAudit"), xRow)
            If getColumIndex(spr, "MaterialInBoundNo") > -1 Then z2554.MaterialInBoundNo = getDataM(spr, getColumIndex(spr, "MaterialInBoundNo"), xRow)
            If getColumIndex(spr, "MaterialInBoundSeq") > -1 Then z2554.MaterialInBoundSeq = getDataM(spr, getColumIndex(spr, "MaterialInBoundSeq"), xRow)
            If getColumIndex(spr, "MaterialInBoundSno") > -1 Then z2554.MaterialInBoundSno = getDataM(spr, getColumIndex(spr, "MaterialInBoundSno"), xRow)
            If getColumIndex(spr, "MaterialInBoundDseq") > -1 Then z2554.MaterialInBoundDseq = getDataM(spr, getColumIndex(spr, "MaterialInBoundDseq"), xRow)
            If getColumIndex(spr, "PackAudit") > -1 Then z2554.PackAudit = getDataM(spr, getColumIndex(spr, "PackAudit"), xRow)
            If getColumIndex(spr, "QtyAudit") > -1 Then z2554.QtyAudit = getDataM(spr, getColumIndex(spr, "QtyAudit"), xRow)
            If getColumIndex(spr, "QtyAdjust") > -1 Then z2554.QtyAdjust = getDataM(spr, getColumIndex(spr, "QtyAdjust"), xRow)
            If getColumIndex(spr, "seWareHousePosition") > -1 Then z2554.seWareHousePosition = getDataM(spr, getColumIndex(spr, "seWareHousePosition"), xRow)
            If getColumIndex(spr, "cdWareHousePosition") > -1 Then z2554.cdWareHousePosition = getDataM(spr, getColumIndex(spr, "cdWareHousePosition"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z2554.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "InchargeAudit") > -1 Then z2554.InchargeAudit = getDataM(spr, getColumIndex(spr, "InchargeAudit"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z2554.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2554_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K2554_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z2554 As T2554_AREA, CheckClear As Boolean, AUTOKEY As Double) As Boolean

        K2554_MOVE = False

        Try
            If READ_PFK2554(AUTOKEY) = True Then
                z2554 = D2554
                K2554_MOVE = True
            Else
                If CheckClear = True Then z2554 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z2554.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "DateAudit") > -1 Then z2554.DateAudit = getDataM(spr, getColumIndex(spr, "DateAudit"), xRow)
            If getColumIndex(spr, "MaterialInBoundNo") > -1 Then z2554.MaterialInBoundNo = getDataM(spr, getColumIndex(spr, "MaterialInBoundNo"), xRow)
            If getColumIndex(spr, "MaterialInBoundSeq") > -1 Then z2554.MaterialInBoundSeq = getDataM(spr, getColumIndex(spr, "MaterialInBoundSeq"), xRow)
            If getColumIndex(spr, "MaterialInBoundSno") > -1 Then z2554.MaterialInBoundSno = getDataM(spr, getColumIndex(spr, "MaterialInBoundSno"), xRow)
            If getColumIndex(spr, "MaterialInBoundDseq") > -1 Then z2554.MaterialInBoundDseq = getDataM(spr, getColumIndex(spr, "MaterialInBoundDseq"), xRow)
            If getColumIndex(spr, "PackAudit") > -1 Then z2554.PackAudit = getDataM(spr, getColumIndex(spr, "PackAudit"), xRow)
            If getColumIndex(spr, "QtyAudit") > -1 Then z2554.QtyAudit = getDataM(spr, getColumIndex(spr, "QtyAudit"), xRow)
            If getColumIndex(spr, "QtyAdjust") > -1 Then z2554.QtyAdjust = getDataM(spr, getColumIndex(spr, "QtyAdjust"), xRow)
            If getColumIndex(spr, "seWareHousePosition") > -1 Then z2554.seWareHousePosition = getDataM(spr, getColumIndex(spr, "seWareHousePosition"), xRow)
            If getColumIndex(spr, "cdWareHousePosition") > -1 Then z2554.cdWareHousePosition = getDataM(spr, getColumIndex(spr, "cdWareHousePosition"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z2554.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "InchargeAudit") > -1 Then z2554.InchargeAudit = getDataM(spr, getColumIndex(spr, "InchargeAudit"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z2554.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2554_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K2554_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z2554 As T2554_AREA, Job As String, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K2554_MOVE = False

        Try
            If READ_PFK2554(AUTOKEY) = True Then
                z2554 = D2554
                K2554_MOVE = True
            Else
                z2554 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2554")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z2554.Autokey = Children(i).Code
                                Case "DATEAUDIT" : z2554.DateAudit = Children(i).Code
                                Case "MATERIALINBOUNDNO" : z2554.MaterialInBoundNo = Children(i).Code
                                Case "MATERIALINBOUNDSEQ" : z2554.MaterialInBoundSeq = Children(i).Code
                                Case "MATERIALINBOUNDSNO" : z2554.MaterialInBoundSno = Children(i).Code
                                Case "MATERIALINBOUNDDSEQ" : z2554.MaterialInBoundDseq = Children(i).Code
                                Case "PACKAUDIT" : z2554.PackAudit = Children(i).Code
                                Case "QTYAUDIT" : z2554.QtyAudit = Children(i).Code
                                Case "QTYADJUST" : z2554.QtyAdjust = Children(i).Code
                                Case "SEWAREHOUSEPOSITION" : z2554.seWareHousePosition = Children(i).Code
                                Case "CDWAREHOUSEPOSITION" : z2554.cdWareHousePosition = Children(i).Code
                                Case "CHECKCOMPLETE" : z2554.CheckComplete = Children(i).Code
                                Case "INCHARGEAUDIT" : z2554.InchargeAudit = Children(i).Code
                                Case "REMARK" : z2554.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z2554.Autokey = Children(i).Data
                                Case "DATEAUDIT" : z2554.DateAudit = Children(i).Data
                                Case "MATERIALINBOUNDNO" : z2554.MaterialInBoundNo = Children(i).Data
                                Case "MATERIALINBOUNDSEQ" : z2554.MaterialInBoundSeq = Children(i).Data
                                Case "MATERIALINBOUNDSNO" : z2554.MaterialInBoundSno = Children(i).Data
                                Case "MATERIALINBOUNDDSEQ" : z2554.MaterialInBoundDseq = Children(i).Data
                                Case "PACKAUDIT" : z2554.PackAudit = Children(i).Data
                                Case "QTYAUDIT" : z2554.QtyAudit = Children(i).Data
                                Case "QTYADJUST" : z2554.QtyAdjust = Children(i).Data
                                Case "SEWAREHOUSEPOSITION" : z2554.seWareHousePosition = Children(i).Data
                                Case "CDWAREHOUSEPOSITION" : z2554.cdWareHousePosition = Children(i).Data
                                Case "CHECKCOMPLETE" : z2554.CheckComplete = Children(i).Data
                                Case "INCHARGEAUDIT" : z2554.InchargeAudit = Children(i).Data
                                Case "REMARK" : z2554.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2554_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K2554_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z2554 As T2554_AREA, Job As String, CheckClear As Boolean, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K2554_MOVE = False

        Try
            If READ_PFK2554(AUTOKEY) = True Then
                z2554 = D2554
                K2554_MOVE = True
            Else
                If CheckClear = True Then z2554 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2554")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z2554.Autokey = Children(i).Code
                                Case "DATEAUDIT" : z2554.DateAudit = Children(i).Code
                                Case "MATERIALINBOUNDNO" : z2554.MaterialInBoundNo = Children(i).Code
                                Case "MATERIALINBOUNDSEQ" : z2554.MaterialInBoundSeq = Children(i).Code
                                Case "MATERIALINBOUNDSNO" : z2554.MaterialInBoundSno = Children(i).Code
                                Case "MATERIALINBOUNDDSEQ" : z2554.MaterialInBoundDseq = Children(i).Code
                                Case "PACKAUDIT" : z2554.PackAudit = Children(i).Code
                                Case "QTYAUDIT" : z2554.QtyAudit = Children(i).Code
                                Case "QTYADJUST" : z2554.QtyAdjust = Children(i).Code
                                Case "SEWAREHOUSEPOSITION" : z2554.seWareHousePosition = Children(i).Code
                                Case "CDWAREHOUSEPOSITION" : z2554.cdWareHousePosition = Children(i).Code
                                Case "CHECKCOMPLETE" : z2554.CheckComplete = Children(i).Code
                                Case "INCHARGEAUDIT" : z2554.InchargeAudit = Children(i).Code
                                Case "REMARK" : z2554.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z2554.Autokey = Children(i).Data
                                Case "DATEAUDIT" : z2554.DateAudit = Children(i).Data
                                Case "MATERIALINBOUNDNO" : z2554.MaterialInBoundNo = Children(i).Data
                                Case "MATERIALINBOUNDSEQ" : z2554.MaterialInBoundSeq = Children(i).Data
                                Case "MATERIALINBOUNDSNO" : z2554.MaterialInBoundSno = Children(i).Data
                                Case "MATERIALINBOUNDDSEQ" : z2554.MaterialInBoundDseq = Children(i).Data
                                Case "PACKAUDIT" : z2554.PackAudit = Children(i).Data
                                Case "QTYAUDIT" : z2554.QtyAudit = Children(i).Data
                                Case "QTYADJUST" : z2554.QtyAdjust = Children(i).Data
                                Case "SEWAREHOUSEPOSITION" : z2554.seWareHousePosition = Children(i).Data
                                Case "CDWAREHOUSEPOSITION" : z2554.cdWareHousePosition = Children(i).Data
                                Case "CHECKCOMPLETE" : z2554.CheckComplete = Children(i).Data
                                Case "INCHARGEAUDIT" : z2554.InchargeAudit = Children(i).Data
                                Case "REMARK" : z2554.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2554_MOVE", vbCritical)
        End Try
    End Function

End Module
