'=========================================================================================================================================================
'   TABLE : (PFK2553)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K2553

    Structure T2553_AREA
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

    Public D2553 As T2553_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK2553(AUTOKEY As Double) As Boolean
        READ_PFK2553 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2553 "
            SQL = SQL & " WHERE K2553_Autokey		 =  " & AUTOKEY & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D2553_CLEAR() : GoTo SKIP_READ_PFK2553

            Call K2553_MOVE(rd)
            READ_PFK2553 = True

SKIP_READ_PFK2553:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK2553", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK2553(AUTOKEY As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2553 "
            SQL = SQL & " WHERE K2553_Autokey		 =  " & AUTOKEY & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK2553", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK2553(z2553 As T2553_AREA) As Boolean
        WRITE_PFK2553 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z2553)

            SQL = " INSERT INTO PFK2553 "
            SQL = SQL & " ( "
            SQL = SQL & " K2553_Autokey,"
            SQL = SQL & " K2553_DateAudit,"
            SQL = SQL & " K2553_MaterialInBoundNo,"
            SQL = SQL & " K2553_MaterialInBoundSeq,"
            SQL = SQL & " K2553_MaterialInBoundSno,"
            SQL = SQL & " K2553_MaterialInBoundDseq,"
            SQL = SQL & " K2553_PackAudit,"
            SQL = SQL & " K2553_QtyAudit,"
            SQL = SQL & " K2553_QtyAdjust,"
            SQL = SQL & " K2553_seWareHousePosition,"
            SQL = SQL & " K2553_cdWareHousePosition,"
            SQL = SQL & " K2553_CheckComplete,"
            SQL = SQL & " K2553_InchargeAudit,"
            SQL = SQL & " K2553_TimeAudit,"
            SQL = SQL & " K2553_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "   " & FormatSQL(z2553.Autokey) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2553.DateAudit) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2553.MaterialInBoundNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2553.MaterialInBoundSeq) & "', "
            SQL = SQL & "   " & FormatSQL(z2553.MaterialInBoundSno) & ", "
            SQL = SQL & "   " & FormatSQL(z2553.MaterialInBoundDseq) & ", "
            SQL = SQL & "   " & FormatSQL(z2553.PackAudit) & ", "
            SQL = SQL & "   " & FormatSQL(z2553.QtyAudit) & ", "
            SQL = SQL & "   " & FormatSQL(z2553.QtyAdjust) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2553.seWareHousePosition) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2553.cdWareHousePosition) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2553.CheckComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2553.InchargeAudit) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2553.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK2553 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK2553", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK2553(z2553 As T2553_AREA) As Boolean
        REWRITE_PFK2553 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z2553)

            SQL = " UPDATE PFK2553 SET "
            SQL = SQL & "    K2553_DateAudit      = N'" & FormatSQL(z2553.DateAudit) & "', "
            SQL = SQL & "    K2553_MaterialInBoundNo      = N'" & FormatSQL(z2553.MaterialInBoundNo) & "', "
            SQL = SQL & "    K2553_MaterialInBoundSeq      = N'" & FormatSQL(z2553.MaterialInBoundSeq) & "', "
            SQL = SQL & "    K2553_MaterialInBoundSno      =  " & FormatSQL(z2553.MaterialInBoundSno) & ", "
            SQL = SQL & "    K2553_MaterialInBoundDseq      =  " & FormatSQL(z2553.MaterialInBoundDseq) & ", "
            SQL = SQL & "    K2553_PackAudit      =  " & FormatSQL(z2553.PackAudit) & ", "
            SQL = SQL & "    K2553_QtyAudit      =  " & FormatSQL(z2553.QtyAudit) & ", "
            SQL = SQL & "    K2553_QtyAdjust      =  " & FormatSQL(z2553.QtyAdjust) & ", "
            SQL = SQL & "    K2553_seWareHousePosition      = N'" & FormatSQL(z2553.seWareHousePosition) & "', "
            SQL = SQL & "    K2553_cdWareHousePosition      = N'" & FormatSQL(z2553.cdWareHousePosition) & "', "
            SQL = SQL & "    K2553_CheckComplete      = N'" & FormatSQL(z2553.CheckComplete) & "', "
            SQL = SQL & "    K2553_InchargeAudit      = N'" & FormatSQL(z2553.InchargeAudit) & "', "
            SQL = SQL & "    K2553_Remark      = N'" & FormatSQL(z2553.Remark) & "'  "
            SQL = SQL & " WHERE K2553_Autokey		 =  " & z2553.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK2553 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK2553", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK2553(z2553 As T2553_AREA) As Boolean
        DELETE_PFK2553 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK2553 "
            SQL = SQL & " WHERE K2553_Autokey		 =  " & z2553.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK2553 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK2553", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D2553_CLEAR()
        Try

            D2553.Autokey = 0
            D2553.DateAudit = ""
            D2553.MaterialInBoundNo = ""
            D2553.MaterialInBoundSeq = ""
            D2553.MaterialInBoundSno = 0
            D2553.MaterialInBoundDseq = 0
            D2553.PackAudit = 0
            D2553.QtyAudit = 0
            D2553.QtyAdjust = 0
            D2553.seWareHousePosition = ""
            D2553.cdWareHousePosition = ""
            D2553.CheckComplete = ""
            D2553.InchargeAudit = ""
            D2553.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D2553_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x2553 As T2553_AREA)
        Try

            x2553.Autokey = trim$(x2553.Autokey)
            x2553.DateAudit = trim$(x2553.DateAudit)
            x2553.MaterialInBoundNo = trim$(x2553.MaterialInBoundNo)
            x2553.MaterialInBoundSeq = trim$(x2553.MaterialInBoundSeq)
            x2553.MaterialInBoundSno = trim$(x2553.MaterialInBoundSno)
            x2553.MaterialInBoundDseq = trim$(x2553.MaterialInBoundDseq)
            x2553.PackAudit = trim$(x2553.PackAudit)
            x2553.QtyAudit = trim$(x2553.QtyAudit)
            x2553.QtyAdjust = trim$(x2553.QtyAdjust)
            x2553.seWareHousePosition = trim$(x2553.seWareHousePosition)
            x2553.cdWareHousePosition = trim$(x2553.cdWareHousePosition)
            x2553.CheckComplete = trim$(x2553.CheckComplete)
            x2553.InchargeAudit = trim$(x2553.InchargeAudit)
            x2553.Remark = Trim$(x2553.Remark)

            If trim$(x2553.Autokey) = "" Then x2553.Autokey = 0
            If trim$(x2553.DateAudit) = "" Then x2553.DateAudit = Space(1)
            If trim$(x2553.MaterialInBoundNo) = "" Then x2553.MaterialInBoundNo = Space(1)
            If trim$(x2553.MaterialInBoundSeq) = "" Then x2553.MaterialInBoundSeq = Space(1)
            If trim$(x2553.MaterialInBoundSno) = "" Then x2553.MaterialInBoundSno = 0
            If trim$(x2553.MaterialInBoundDseq) = "" Then x2553.MaterialInBoundDseq = 0
            If trim$(x2553.PackAudit) = "" Then x2553.PackAudit = 0
            If trim$(x2553.QtyAudit) = "" Then x2553.QtyAudit = 0
            If trim$(x2553.QtyAdjust) = "" Then x2553.QtyAdjust = 0
            If trim$(x2553.seWareHousePosition) = "" Then x2553.seWareHousePosition = Space(1)
            If trim$(x2553.cdWareHousePosition) = "" Then x2553.cdWareHousePosition = Space(1)
            If trim$(x2553.CheckComplete) = "" Then x2553.CheckComplete = Space(1)
            If trim$(x2553.InchargeAudit) = "" Then x2553.InchargeAudit = Space(1)
            If Trim$(x2553.Remark) = "" Then x2553.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K2553_MOVE(rs2553 As SqlClient.SqlDataReader)
        Try

            Call D2553_CLEAR()

            If IsdbNull(rs2553!K2553_Autokey) = False Then D2553.Autokey = Trim$(rs2553!K2553_Autokey)
            If IsdbNull(rs2553!K2553_DateAudit) = False Then D2553.DateAudit = Trim$(rs2553!K2553_DateAudit)
            If IsdbNull(rs2553!K2553_MaterialInBoundNo) = False Then D2553.MaterialInBoundNo = Trim$(rs2553!K2553_MaterialInBoundNo)
            If IsdbNull(rs2553!K2553_MaterialInBoundSeq) = False Then D2553.MaterialInBoundSeq = Trim$(rs2553!K2553_MaterialInBoundSeq)
            If IsdbNull(rs2553!K2553_MaterialInBoundSno) = False Then D2553.MaterialInBoundSno = Trim$(rs2553!K2553_MaterialInBoundSno)
            If IsdbNull(rs2553!K2553_MaterialInBoundDseq) = False Then D2553.MaterialInBoundDseq = Trim$(rs2553!K2553_MaterialInBoundDseq)
            If IsdbNull(rs2553!K2553_PackAudit) = False Then D2553.PackAudit = Trim$(rs2553!K2553_PackAudit)
            If IsdbNull(rs2553!K2553_QtyAudit) = False Then D2553.QtyAudit = Trim$(rs2553!K2553_QtyAudit)
            If IsdbNull(rs2553!K2553_QtyAdjust) = False Then D2553.QtyAdjust = Trim$(rs2553!K2553_QtyAdjust)
            If IsdbNull(rs2553!K2553_seWareHousePosition) = False Then D2553.seWareHousePosition = Trim$(rs2553!K2553_seWareHousePosition)
            If IsdbNull(rs2553!K2553_cdWareHousePosition) = False Then D2553.cdWareHousePosition = Trim$(rs2553!K2553_cdWareHousePosition)
            If IsdbNull(rs2553!K2553_CheckComplete) = False Then D2553.CheckComplete = Trim$(rs2553!K2553_CheckComplete)
            If IsdbNull(rs2553!K2553_InchargeAudit) = False Then D2553.InchargeAudit = Trim$(rs2553!K2553_InchargeAudit)
            If IsDBNull(rs2553!K2553_Remark) = False Then D2553.Remark = Trim$(rs2553!K2553_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K2553_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K2553_MOVE(rs2553 As DataRow)
        Try

            Call D2553_CLEAR()

            If IsdbNull(rs2553!K2553_Autokey) = False Then D2553.Autokey = Trim$(rs2553!K2553_Autokey)
            If IsdbNull(rs2553!K2553_DateAudit) = False Then D2553.DateAudit = Trim$(rs2553!K2553_DateAudit)
            If IsdbNull(rs2553!K2553_MaterialInBoundNo) = False Then D2553.MaterialInBoundNo = Trim$(rs2553!K2553_MaterialInBoundNo)
            If IsdbNull(rs2553!K2553_MaterialInBoundSeq) = False Then D2553.MaterialInBoundSeq = Trim$(rs2553!K2553_MaterialInBoundSeq)
            If IsdbNull(rs2553!K2553_MaterialInBoundSno) = False Then D2553.MaterialInBoundSno = Trim$(rs2553!K2553_MaterialInBoundSno)
            If IsdbNull(rs2553!K2553_MaterialInBoundDseq) = False Then D2553.MaterialInBoundDseq = Trim$(rs2553!K2553_MaterialInBoundDseq)
            If IsdbNull(rs2553!K2553_PackAudit) = False Then D2553.PackAudit = Trim$(rs2553!K2553_PackAudit)
            If IsdbNull(rs2553!K2553_QtyAudit) = False Then D2553.QtyAudit = Trim$(rs2553!K2553_QtyAudit)
            If IsdbNull(rs2553!K2553_QtyAdjust) = False Then D2553.QtyAdjust = Trim$(rs2553!K2553_QtyAdjust)
            If IsdbNull(rs2553!K2553_seWareHousePosition) = False Then D2553.seWareHousePosition = Trim$(rs2553!K2553_seWareHousePosition)
            If IsdbNull(rs2553!K2553_cdWareHousePosition) = False Then D2553.cdWareHousePosition = Trim$(rs2553!K2553_cdWareHousePosition)
            If IsdbNull(rs2553!K2553_CheckComplete) = False Then D2553.CheckComplete = Trim$(rs2553!K2553_CheckComplete)
            If IsdbNull(rs2553!K2553_InchargeAudit) = False Then D2553.InchargeAudit = Trim$(rs2553!K2553_InchargeAudit)
            If IsDBNull(rs2553!K2553_Remark) = False Then D2553.Remark = Trim$(rs2553!K2553_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K2553_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K2553_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z2553 As T2553_AREA, AUTOKEY As Double) As Boolean

        K2553_MOVE = False

        Try
            If READ_PFK2553(AUTOKEY) = True Then
                z2553 = D2553
                K2553_MOVE = True
            Else
                z2553 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z2553.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "DateAudit") > -1 Then z2553.DateAudit = getDataM(spr, getColumIndex(spr, "DateAudit"), xRow)
            If getColumIndex(spr, "MaterialInBoundNo") > -1 Then z2553.MaterialInBoundNo = getDataM(spr, getColumIndex(spr, "MaterialInBoundNo"), xRow)
            If getColumIndex(spr, "MaterialInBoundSeq") > -1 Then z2553.MaterialInBoundSeq = getDataM(spr, getColumIndex(spr, "MaterialInBoundSeq"), xRow)
            If getColumIndex(spr, "MaterialInBoundSno") > -1 Then z2553.MaterialInBoundSno = getDataM(spr, getColumIndex(spr, "MaterialInBoundSno"), xRow)
            If getColumIndex(spr, "MaterialInBoundDseq") > -1 Then z2553.MaterialInBoundDseq = getDataM(spr, getColumIndex(spr, "MaterialInBoundDseq"), xRow)
            If getColumIndex(spr, "PackAudit") > -1 Then z2553.PackAudit = getDataM(spr, getColumIndex(spr, "PackAudit"), xRow)
            If getColumIndex(spr, "QtyAudit") > -1 Then z2553.QtyAudit = getDataM(spr, getColumIndex(spr, "QtyAudit"), xRow)
            If getColumIndex(spr, "QtyAdjust") > -1 Then z2553.QtyAdjust = getDataM(spr, getColumIndex(spr, "QtyAdjust"), xRow)
            If getColumIndex(spr, "seWareHousePosition") > -1 Then z2553.seWareHousePosition = getDataM(spr, getColumIndex(spr, "seWareHousePosition"), xRow)
            If getColumIndex(spr, "cdWareHousePosition") > -1 Then z2553.cdWareHousePosition = getDataM(spr, getColumIndex(spr, "cdWareHousePosition"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z2553.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "InchargeAudit") > -1 Then z2553.InchargeAudit = getDataM(spr, getColumIndex(spr, "InchargeAudit"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z2553.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2553_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K2553_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z2553 As T2553_AREA, CheckClear As Boolean, AUTOKEY As Double) As Boolean

        K2553_MOVE = False

        Try
            If READ_PFK2553(AUTOKEY) = True Then
                z2553 = D2553
                K2553_MOVE = True
            Else
                If CheckClear = True Then z2553 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z2553.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "DateAudit") > -1 Then z2553.DateAudit = getDataM(spr, getColumIndex(spr, "DateAudit"), xRow)
            If getColumIndex(spr, "MaterialInBoundNo") > -1 Then z2553.MaterialInBoundNo = getDataM(spr, getColumIndex(spr, "MaterialInBoundNo"), xRow)
            If getColumIndex(spr, "MaterialInBoundSeq") > -1 Then z2553.MaterialInBoundSeq = getDataM(spr, getColumIndex(spr, "MaterialInBoundSeq"), xRow)
            If getColumIndex(spr, "MaterialInBoundSno") > -1 Then z2553.MaterialInBoundSno = getDataM(spr, getColumIndex(spr, "MaterialInBoundSno"), xRow)
            If getColumIndex(spr, "MaterialInBoundDseq") > -1 Then z2553.MaterialInBoundDseq = getDataM(spr, getColumIndex(spr, "MaterialInBoundDseq"), xRow)
            If getColumIndex(spr, "PackAudit") > -1 Then z2553.PackAudit = getDataM(spr, getColumIndex(spr, "PackAudit"), xRow)
            If getColumIndex(spr, "QtyAudit") > -1 Then z2553.QtyAudit = getDataM(spr, getColumIndex(spr, "QtyAudit"), xRow)
            If getColumIndex(spr, "QtyAdjust") > -1 Then z2553.QtyAdjust = getDataM(spr, getColumIndex(spr, "QtyAdjust"), xRow)
            If getColumIndex(spr, "seWareHousePosition") > -1 Then z2553.seWareHousePosition = getDataM(spr, getColumIndex(spr, "seWareHousePosition"), xRow)
            If getColumIndex(spr, "cdWareHousePosition") > -1 Then z2553.cdWareHousePosition = getDataM(spr, getColumIndex(spr, "cdWareHousePosition"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z2553.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "InchargeAudit") > -1 Then z2553.InchargeAudit = getDataM(spr, getColumIndex(spr, "InchargeAudit"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z2553.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2553_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K2553_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z2553 As T2553_AREA, Job As String, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K2553_MOVE = False

        Try
            If READ_PFK2553(AUTOKEY) = True Then
                z2553 = D2553
                K2553_MOVE = True
            Else
                z2553 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2553")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z2553.Autokey = Children(i).Code
                                Case "DATEAUDIT" : z2553.DateAudit = Children(i).Code
                                Case "MATERIALINBOUNDNO" : z2553.MaterialInBoundNo = Children(i).Code
                                Case "MATERIALINBOUNDSEQ" : z2553.MaterialInBoundSeq = Children(i).Code
                                Case "MATERIALINBOUNDSNO" : z2553.MaterialInBoundSno = Children(i).Code
                                Case "MATERIALINBOUNDDSEQ" : z2553.MaterialInBoundDseq = Children(i).Code
                                Case "PACKAUDIT" : z2553.PackAudit = Children(i).Code
                                Case "QTYAUDIT" : z2553.QtyAudit = Children(i).Code
                                Case "QTYADJUST" : z2553.QtyAdjust = Children(i).Code
                                Case "SEWAREHOUSEPOSITION" : z2553.seWareHousePosition = Children(i).Code
                                Case "CDWAREHOUSEPOSITION" : z2553.cdWareHousePosition = Children(i).Code
                                Case "CHECKCOMPLETE" : z2553.CheckComplete = Children(i).Code
                                Case "INCHARGEAUDIT" : z2553.InchargeAudit = Children(i).Code
                                Case "REMARK" : z2553.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z2553.Autokey = Children(i).Data
                                Case "DATEAUDIT" : z2553.DateAudit = Children(i).Data
                                Case "MATERIALINBOUNDNO" : z2553.MaterialInBoundNo = Children(i).Data
                                Case "MATERIALINBOUNDSEQ" : z2553.MaterialInBoundSeq = Children(i).Data
                                Case "MATERIALINBOUNDSNO" : z2553.MaterialInBoundSno = Children(i).Data
                                Case "MATERIALINBOUNDDSEQ" : z2553.MaterialInBoundDseq = Children(i).Data
                                Case "PACKAUDIT" : z2553.PackAudit = Children(i).Data
                                Case "QTYAUDIT" : z2553.QtyAudit = Children(i).Data
                                Case "QTYADJUST" : z2553.QtyAdjust = Children(i).Data
                                Case "SEWAREHOUSEPOSITION" : z2553.seWareHousePosition = Children(i).Data
                                Case "CDWAREHOUSEPOSITION" : z2553.cdWareHousePosition = Children(i).Data
                                Case "CHECKCOMPLETE" : z2553.CheckComplete = Children(i).Data
                                Case "INCHARGEAUDIT" : z2553.InchargeAudit = Children(i).Data
                                Case "REMARK" : z2553.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2553_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K2553_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z2553 As T2553_AREA, Job As String, CheckClear As Boolean, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K2553_MOVE = False

        Try
            If READ_PFK2553(AUTOKEY) = True Then
                z2553 = D2553
                K2553_MOVE = True
            Else
                If CheckClear = True Then z2553 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2553")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z2553.Autokey = Children(i).Code
                                Case "DATEAUDIT" : z2553.DateAudit = Children(i).Code
                                Case "MATERIALINBOUNDNO" : z2553.MaterialInBoundNo = Children(i).Code
                                Case "MATERIALINBOUNDSEQ" : z2553.MaterialInBoundSeq = Children(i).Code
                                Case "MATERIALINBOUNDSNO" : z2553.MaterialInBoundSno = Children(i).Code
                                Case "MATERIALINBOUNDDSEQ" : z2553.MaterialInBoundDseq = Children(i).Code
                                Case "PACKAUDIT" : z2553.PackAudit = Children(i).Code
                                Case "QTYAUDIT" : z2553.QtyAudit = Children(i).Code
                                Case "QTYADJUST" : z2553.QtyAdjust = Children(i).Code
                                Case "SEWAREHOUSEPOSITION" : z2553.seWareHousePosition = Children(i).Code
                                Case "CDWAREHOUSEPOSITION" : z2553.cdWareHousePosition = Children(i).Code
                                Case "CHECKCOMPLETE" : z2553.CheckComplete = Children(i).Code
                                Case "INCHARGEAUDIT" : z2553.InchargeAudit = Children(i).Code
                                Case "REMARK" : z2553.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z2553.Autokey = Children(i).Data
                                Case "DATEAUDIT" : z2553.DateAudit = Children(i).Data
                                Case "MATERIALINBOUNDNO" : z2553.MaterialInBoundNo = Children(i).Data
                                Case "MATERIALINBOUNDSEQ" : z2553.MaterialInBoundSeq = Children(i).Data
                                Case "MATERIALINBOUNDSNO" : z2553.MaterialInBoundSno = Children(i).Data
                                Case "MATERIALINBOUNDDSEQ" : z2553.MaterialInBoundDseq = Children(i).Data
                                Case "PACKAUDIT" : z2553.PackAudit = Children(i).Data
                                Case "QTYAUDIT" : z2553.QtyAudit = Children(i).Data
                                Case "QTYADJUST" : z2553.QtyAdjust = Children(i).Data
                                Case "SEWAREHOUSEPOSITION" : z2553.seWareHousePosition = Children(i).Data
                                Case "CDWAREHOUSEPOSITION" : z2553.cdWareHousePosition = Children(i).Data
                                Case "CHECKCOMPLETE" : z2553.CheckComplete = Children(i).Data
                                Case "INCHARGEAUDIT" : z2553.InchargeAudit = Children(i).Data
                                Case "REMARK" : z2553.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2553_MOVE", vbCritical)
        End Try
    End Function

End Module
