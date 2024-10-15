'=========================================================================================================================================================
'   TABLE : (PFK2555)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K2555

    Structure T2555_AREA
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

    Public D2555 As T2555_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK2555(AUTOKEY As Double) As Boolean
        READ_PFK2555 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2555 "
            SQL = SQL & " WHERE K2555_Autokey		 =  " & Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D2555_CLEAR() : GoTo SKIP_READ_PFK2555

            Call K2555_MOVE(rd)
            READ_PFK2555 = True

SKIP_READ_PFK2555:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK2555", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK2555(AUTOKEY As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2555 "
            SQL = SQL & " WHERE K2555_Autokey		 =  " & Autokey & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK2555", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK2555(z2555 As T2555_AREA) As Boolean
        WRITE_PFK2555 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z2555)

            SQL = " INSERT INTO PFK2555 "
            SQL = SQL & " ( "
            SQL = SQL & " K2555_Autokey,"
            SQL = SQL & " K2555_DateAudit,"
            SQL = SQL & " K2555_MaterialInBoundNo,"
            SQL = SQL & " K2555_MaterialInBoundSeq,"
            SQL = SQL & " K2555_MaterialInBoundSno,"
            SQL = SQL & " K2555_MaterialInBoundDseq,"
            SQL = SQL & " K2555_PackAudit,"
            SQL = SQL & " K2555_QtyAudit,"
            SQL = SQL & " K2555_QtyAdjust,"
            SQL = SQL & " K2555_seWareHousePosition,"
            SQL = SQL & " K2555_cdWareHousePosition,"
            SQL = SQL & " K2555_CheckComplete,"
            SQL = SQL & " K2555_InchargeAudit,"
            SQL = SQL & " K2555_TimeAudit,"
            SQL = SQL & " K2555_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "   " & FormatSQL(z2555.Autokey) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2555.DateAudit) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2555.MaterialInBoundNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2555.MaterialInBoundSeq) & "', "
            SQL = SQL & "   " & FormatSQL(z2555.MaterialInBoundSno) & ", "
            SQL = SQL & "   " & FormatSQL(z2555.MaterialInBoundDseq) & ", "
            SQL = SQL & "   " & FormatSQL(z2555.PackAudit) & ", "
            SQL = SQL & "   " & FormatSQL(z2555.QtyAudit) & ", "
            SQL = SQL & "   " & FormatSQL(z2555.QtyAdjust) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2555.seWareHousePosition) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2555.cdWareHousePosition) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2555.CheckComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2555.InchargeAudit) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2555.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK2555 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK2555", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK2555(z2555 As T2555_AREA) As Boolean
        REWRITE_PFK2555 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z2555)

            SQL = " UPDATE PFK2555 SET "
            SQL = SQL & "    K2555_DateAudit      = N'" & FormatSQL(z2555.DateAudit) & "', "
            SQL = SQL & "    K2555_MaterialInBoundNo      = N'" & FormatSQL(z2555.MaterialInBoundNo) & "', "
            SQL = SQL & "    K2555_MaterialInBoundSeq      = N'" & FormatSQL(z2555.MaterialInBoundSeq) & "', "
            SQL = SQL & "    K2555_MaterialInBoundSno      =  " & FormatSQL(z2555.MaterialInBoundSno) & ", "
            SQL = SQL & "    K2555_MaterialInBoundDseq      =  " & FormatSQL(z2555.MaterialInBoundDseq) & ", "
            SQL = SQL & "    K2555_PackAudit      =  " & FormatSQL(z2555.PackAudit) & ", "
            SQL = SQL & "    K2555_QtyAudit      =  " & FormatSQL(z2555.QtyAudit) & ", "
            SQL = SQL & "    K2555_QtyAdjust      =  " & FormatSQL(z2555.QtyAdjust) & ", "
            SQL = SQL & "    K2555_seWareHousePosition      = N'" & FormatSQL(z2555.seWareHousePosition) & "', "
            SQL = SQL & "    K2555_cdWareHousePosition      = N'" & FormatSQL(z2555.cdWareHousePosition) & "', "
            SQL = SQL & "    K2555_CheckComplete      = N'" & FormatSQL(z2555.CheckComplete) & "', "
            SQL = SQL & "    K2555_InchargeAudit      = N'" & FormatSQL(z2555.InchargeAudit) & "', "
            SQL = SQL & "    K2555_Remark      = N'" & FormatSQL(z2555.Remark) & "'  "
            SQL = SQL & " WHERE K2555_Autokey		 =  " & z2555.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK2555 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK2555", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK2555(z2555 As T2555_AREA) As Boolean
        DELETE_PFK2555 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK2555 "
            SQL = SQL & " WHERE K2555_Autokey		 =  " & z2555.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK2555 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK2555", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D2555_CLEAR()
        Try

            D2555.Autokey = 0
            D2555.DateAudit = ""
            D2555.MaterialInBoundNo = ""
            D2555.MaterialInBoundSeq = ""
            D2555.MaterialInBoundSno = 0
            D2555.MaterialInBoundDseq = 0
            D2555.PackAudit = 0
            D2555.QtyAudit = 0
            D2555.QtyAdjust = 0
            D2555.seWareHousePosition = ""
            D2555.cdWareHousePosition = ""
            D2555.CheckComplete = ""
            D2555.InchargeAudit = ""
            D2555.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D2555_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x2555 As T2555_AREA)
        Try

            x2555.Autokey = trim$(x2555.Autokey)
            x2555.DateAudit = trim$(x2555.DateAudit)
            x2555.MaterialInBoundNo = trim$(x2555.MaterialInBoundNo)
            x2555.MaterialInBoundSeq = trim$(x2555.MaterialInBoundSeq)
            x2555.MaterialInBoundSno = trim$(x2555.MaterialInBoundSno)
            x2555.MaterialInBoundDseq = trim$(x2555.MaterialInBoundDseq)
            x2555.PackAudit = trim$(x2555.PackAudit)
            x2555.QtyAudit = trim$(x2555.QtyAudit)
            x2555.QtyAdjust = trim$(x2555.QtyAdjust)
            x2555.seWareHousePosition = trim$(x2555.seWareHousePosition)
            x2555.cdWareHousePosition = trim$(x2555.cdWareHousePosition)
            x2555.CheckComplete = trim$(x2555.CheckComplete)
            x2555.InchargeAudit = trim$(x2555.InchargeAudit)
            x2555.Remark = Trim$(x2555.Remark)

            If trim$(x2555.Autokey) = "" Then x2555.Autokey = 0
            If trim$(x2555.DateAudit) = "" Then x2555.DateAudit = Space(1)
            If trim$(x2555.MaterialInBoundNo) = "" Then x2555.MaterialInBoundNo = Space(1)
            If trim$(x2555.MaterialInBoundSeq) = "" Then x2555.MaterialInBoundSeq = Space(1)
            If trim$(x2555.MaterialInBoundSno) = "" Then x2555.MaterialInBoundSno = 0
            If trim$(x2555.MaterialInBoundDseq) = "" Then x2555.MaterialInBoundDseq = 0
            If trim$(x2555.PackAudit) = "" Then x2555.PackAudit = 0
            If trim$(x2555.QtyAudit) = "" Then x2555.QtyAudit = 0
            If trim$(x2555.QtyAdjust) = "" Then x2555.QtyAdjust = 0
            If trim$(x2555.seWareHousePosition) = "" Then x2555.seWareHousePosition = Space(1)
            If trim$(x2555.cdWareHousePosition) = "" Then x2555.cdWareHousePosition = Space(1)
            If trim$(x2555.CheckComplete) = "" Then x2555.CheckComplete = Space(1)
            If trim$(x2555.InchargeAudit) = "" Then x2555.InchargeAudit = Space(1)
            If Trim$(x2555.Remark) = "" Then x2555.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K2555_MOVE(rs2555 As SqlClient.SqlDataReader)
        Try

            Call D2555_CLEAR()

            If IsdbNull(rs2555!K2555_Autokey) = False Then D2555.Autokey = Trim$(rs2555!K2555_Autokey)
            If IsdbNull(rs2555!K2555_DateAudit) = False Then D2555.DateAudit = Trim$(rs2555!K2555_DateAudit)
            If IsdbNull(rs2555!K2555_MaterialInBoundNo) = False Then D2555.MaterialInBoundNo = Trim$(rs2555!K2555_MaterialInBoundNo)
            If IsdbNull(rs2555!K2555_MaterialInBoundSeq) = False Then D2555.MaterialInBoundSeq = Trim$(rs2555!K2555_MaterialInBoundSeq)
            If IsdbNull(rs2555!K2555_MaterialInBoundSno) = False Then D2555.MaterialInBoundSno = Trim$(rs2555!K2555_MaterialInBoundSno)
            If IsdbNull(rs2555!K2555_MaterialInBoundDseq) = False Then D2555.MaterialInBoundDseq = Trim$(rs2555!K2555_MaterialInBoundDseq)
            If IsdbNull(rs2555!K2555_PackAudit) = False Then D2555.PackAudit = Trim$(rs2555!K2555_PackAudit)
            If IsdbNull(rs2555!K2555_QtyAudit) = False Then D2555.QtyAudit = Trim$(rs2555!K2555_QtyAudit)
            If IsdbNull(rs2555!K2555_QtyAdjust) = False Then D2555.QtyAdjust = Trim$(rs2555!K2555_QtyAdjust)
            If IsdbNull(rs2555!K2555_seWareHousePosition) = False Then D2555.seWareHousePosition = Trim$(rs2555!K2555_seWareHousePosition)
            If IsdbNull(rs2555!K2555_cdWareHousePosition) = False Then D2555.cdWareHousePosition = Trim$(rs2555!K2555_cdWareHousePosition)
            If IsdbNull(rs2555!K2555_CheckComplete) = False Then D2555.CheckComplete = Trim$(rs2555!K2555_CheckComplete)
            If IsdbNull(rs2555!K2555_InchargeAudit) = False Then D2555.InchargeAudit = Trim$(rs2555!K2555_InchargeAudit)
            If IsDBNull(rs2555!K2555_Remark) = False Then D2555.Remark = Trim$(rs2555!K2555_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K2555_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K2555_MOVE(rs2555 As DataRow)
        Try

            Call D2555_CLEAR()

            If IsdbNull(rs2555!K2555_Autokey) = False Then D2555.Autokey = Trim$(rs2555!K2555_Autokey)
            If IsdbNull(rs2555!K2555_DateAudit) = False Then D2555.DateAudit = Trim$(rs2555!K2555_DateAudit)
            If IsdbNull(rs2555!K2555_MaterialInBoundNo) = False Then D2555.MaterialInBoundNo = Trim$(rs2555!K2555_MaterialInBoundNo)
            If IsdbNull(rs2555!K2555_MaterialInBoundSeq) = False Then D2555.MaterialInBoundSeq = Trim$(rs2555!K2555_MaterialInBoundSeq)
            If IsdbNull(rs2555!K2555_MaterialInBoundSno) = False Then D2555.MaterialInBoundSno = Trim$(rs2555!K2555_MaterialInBoundSno)
            If IsdbNull(rs2555!K2555_MaterialInBoundDseq) = False Then D2555.MaterialInBoundDseq = Trim$(rs2555!K2555_MaterialInBoundDseq)
            If IsdbNull(rs2555!K2555_PackAudit) = False Then D2555.PackAudit = Trim$(rs2555!K2555_PackAudit)
            If IsdbNull(rs2555!K2555_QtyAudit) = False Then D2555.QtyAudit = Trim$(rs2555!K2555_QtyAudit)
            If IsdbNull(rs2555!K2555_QtyAdjust) = False Then D2555.QtyAdjust = Trim$(rs2555!K2555_QtyAdjust)
            If IsdbNull(rs2555!K2555_seWareHousePosition) = False Then D2555.seWareHousePosition = Trim$(rs2555!K2555_seWareHousePosition)
            If IsdbNull(rs2555!K2555_cdWareHousePosition) = False Then D2555.cdWareHousePosition = Trim$(rs2555!K2555_cdWareHousePosition)
            If IsdbNull(rs2555!K2555_CheckComplete) = False Then D2555.CheckComplete = Trim$(rs2555!K2555_CheckComplete)
            If IsdbNull(rs2555!K2555_InchargeAudit) = False Then D2555.InchargeAudit = Trim$(rs2555!K2555_InchargeAudit)
            If IsDBNull(rs2555!K2555_Remark) = False Then D2555.Remark = Trim$(rs2555!K2555_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K2555_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K2555_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z2555 As T2555_AREA, AUTOKEY As Double) As Boolean

        K2555_MOVE = False

        Try
            If READ_PFK2555(AUTOKEY) = True Then
                z2555 = D2555
                K2555_MOVE = True
            Else
                z2555 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z2555.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "DateAudit") > -1 Then z2555.DateAudit = getDataM(spr, getColumIndex(spr, "DateAudit"), xRow)
            If getColumIndex(spr, "MaterialInBoundNo") > -1 Then z2555.MaterialInBoundNo = getDataM(spr, getColumIndex(spr, "MaterialInBoundNo"), xRow)
            If getColumIndex(spr, "MaterialInBoundSeq") > -1 Then z2555.MaterialInBoundSeq = getDataM(spr, getColumIndex(spr, "MaterialInBoundSeq"), xRow)
            If getColumIndex(spr, "MaterialInBoundSno") > -1 Then z2555.MaterialInBoundSno = getDataM(spr, getColumIndex(spr, "MaterialInBoundSno"), xRow)
            If getColumIndex(spr, "MaterialInBoundDseq") > -1 Then z2555.MaterialInBoundDseq = getDataM(spr, getColumIndex(spr, "MaterialInBoundDseq"), xRow)
            If getColumIndex(spr, "PackAudit") > -1 Then z2555.PackAudit = getDataM(spr, getColumIndex(spr, "PackAudit"), xRow)
            If getColumIndex(spr, "QtyAudit") > -1 Then z2555.QtyAudit = getDataM(spr, getColumIndex(spr, "QtyAudit"), xRow)
            If getColumIndex(spr, "QtyAdjust") > -1 Then z2555.QtyAdjust = getDataM(spr, getColumIndex(spr, "QtyAdjust"), xRow)
            If getColumIndex(spr, "seWareHousePosition") > -1 Then z2555.seWareHousePosition = getDataM(spr, getColumIndex(spr, "seWareHousePosition"), xRow)
            If getColumIndex(spr, "cdWareHousePosition") > -1 Then z2555.cdWareHousePosition = getDataM(spr, getColumIndex(spr, "cdWareHousePosition"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z2555.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "InchargeAudit") > -1 Then z2555.InchargeAudit = getDataM(spr, getColumIndex(spr, "InchargeAudit"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z2555.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2555_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K2555_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z2555 As T2555_AREA, CheckClear As Boolean, AUTOKEY As Double) As Boolean

        K2555_MOVE = False

        Try
            If READ_PFK2555(AUTOKEY) = True Then
                z2555 = D2555
                K2555_MOVE = True
            Else
                If CheckClear = True Then z2555 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z2555.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "DateAudit") > -1 Then z2555.DateAudit = getDataM(spr, getColumIndex(spr, "DateAudit"), xRow)
            If getColumIndex(spr, "MaterialInBoundNo") > -1 Then z2555.MaterialInBoundNo = getDataM(spr, getColumIndex(spr, "MaterialInBoundNo"), xRow)
            If getColumIndex(spr, "MaterialInBoundSeq") > -1 Then z2555.MaterialInBoundSeq = getDataM(spr, getColumIndex(spr, "MaterialInBoundSeq"), xRow)
            If getColumIndex(spr, "MaterialInBoundSno") > -1 Then z2555.MaterialInBoundSno = getDataM(spr, getColumIndex(spr, "MaterialInBoundSno"), xRow)
            If getColumIndex(spr, "MaterialInBoundDseq") > -1 Then z2555.MaterialInBoundDseq = getDataM(spr, getColumIndex(spr, "MaterialInBoundDseq"), xRow)
            If getColumIndex(spr, "PackAudit") > -1 Then z2555.PackAudit = getDataM(spr, getColumIndex(spr, "PackAudit"), xRow)
            If getColumIndex(spr, "QtyAudit") > -1 Then z2555.QtyAudit = getDataM(spr, getColumIndex(spr, "QtyAudit"), xRow)
            If getColumIndex(spr, "QtyAdjust") > -1 Then z2555.QtyAdjust = getDataM(spr, getColumIndex(spr, "QtyAdjust"), xRow)
            If getColumIndex(spr, "seWareHousePosition") > -1 Then z2555.seWareHousePosition = getDataM(spr, getColumIndex(spr, "seWareHousePosition"), xRow)
            If getColumIndex(spr, "cdWareHousePosition") > -1 Then z2555.cdWareHousePosition = getDataM(spr, getColumIndex(spr, "cdWareHousePosition"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z2555.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "InchargeAudit") > -1 Then z2555.InchargeAudit = getDataM(spr, getColumIndex(spr, "InchargeAudit"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z2555.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2555_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K2555_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z2555 As T2555_AREA, Job As String, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K2555_MOVE = False

        Try
            If READ_PFK2555(AUTOKEY) = True Then
                z2555 = D2555
                K2555_MOVE = True
            Else
                z2555 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2555")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z2555.Autokey = Children(i).Code
                                Case "DATEAUDIT" : z2555.DateAudit = Children(i).Code
                                Case "MATERIALINBOUNDNO" : z2555.MaterialInBoundNo = Children(i).Code
                                Case "MATERIALINBOUNDSEQ" : z2555.MaterialInBoundSeq = Children(i).Code
                                Case "MATERIALINBOUNDSNO" : z2555.MaterialInBoundSno = Children(i).Code
                                Case "MATERIALINBOUNDDSEQ" : z2555.MaterialInBoundDseq = Children(i).Code
                                Case "PACKAUDIT" : z2555.PackAudit = Children(i).Code
                                Case "QTYAUDIT" : z2555.QtyAudit = Children(i).Code
                                Case "QTYADJUST" : z2555.QtyAdjust = Children(i).Code
                                Case "SEWAREHOUSEPOSITION" : z2555.seWareHousePosition = Children(i).Code
                                Case "CDWAREHOUSEPOSITION" : z2555.cdWareHousePosition = Children(i).Code
                                Case "CHECKCOMPLETE" : z2555.CheckComplete = Children(i).Code
                                Case "INCHARGEAUDIT" : z2555.InchargeAudit = Children(i).Code
                                Case "REMARK" : z2555.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z2555.Autokey = Children(i).Data
                                Case "DATEAUDIT" : z2555.DateAudit = Children(i).Data
                                Case "MATERIALINBOUNDNO" : z2555.MaterialInBoundNo = Children(i).Data
                                Case "MATERIALINBOUNDSEQ" : z2555.MaterialInBoundSeq = Children(i).Data
                                Case "MATERIALINBOUNDSNO" : z2555.MaterialInBoundSno = Children(i).Data
                                Case "MATERIALINBOUNDDSEQ" : z2555.MaterialInBoundDseq = Children(i).Data
                                Case "PACKAUDIT" : z2555.PackAudit = Children(i).Data
                                Case "QTYAUDIT" : z2555.QtyAudit = Children(i).Data
                                Case "QTYADJUST" : z2555.QtyAdjust = Children(i).Data
                                Case "SEWAREHOUSEPOSITION" : z2555.seWareHousePosition = Children(i).Data
                                Case "CDWAREHOUSEPOSITION" : z2555.cdWareHousePosition = Children(i).Data
                                Case "CHECKCOMPLETE" : z2555.CheckComplete = Children(i).Data
                                Case "INCHARGEAUDIT" : z2555.InchargeAudit = Children(i).Data
                                Case "REMARK" : z2555.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2555_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K2555_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z2555 As T2555_AREA, Job As String, CheckClear As Boolean, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K2555_MOVE = False

        Try
            If READ_PFK2555(AUTOKEY) = True Then
                z2555 = D2555
                K2555_MOVE = True
            Else
                If CheckClear = True Then z2555 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2555")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z2555.Autokey = Children(i).Code
                                Case "DATEAUDIT" : z2555.DateAudit = Children(i).Code
                                Case "MATERIALINBOUNDNO" : z2555.MaterialInBoundNo = Children(i).Code
                                Case "MATERIALINBOUNDSEQ" : z2555.MaterialInBoundSeq = Children(i).Code
                                Case "MATERIALINBOUNDSNO" : z2555.MaterialInBoundSno = Children(i).Code
                                Case "MATERIALINBOUNDDSEQ" : z2555.MaterialInBoundDseq = Children(i).Code
                                Case "PACKAUDIT" : z2555.PackAudit = Children(i).Code
                                Case "QTYAUDIT" : z2555.QtyAudit = Children(i).Code
                                Case "QTYADJUST" : z2555.QtyAdjust = Children(i).Code
                                Case "SEWAREHOUSEPOSITION" : z2555.seWareHousePosition = Children(i).Code
                                Case "CDWAREHOUSEPOSITION" : z2555.cdWareHousePosition = Children(i).Code
                                Case "CHECKCOMPLETE" : z2555.CheckComplete = Children(i).Code
                                Case "INCHARGEAUDIT" : z2555.InchargeAudit = Children(i).Code
                                Case "REMARK" : z2555.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z2555.Autokey = Children(i).Data
                                Case "DATEAUDIT" : z2555.DateAudit = Children(i).Data
                                Case "MATERIALINBOUNDNO" : z2555.MaterialInBoundNo = Children(i).Data
                                Case "MATERIALINBOUNDSEQ" : z2555.MaterialInBoundSeq = Children(i).Data
                                Case "MATERIALINBOUNDSNO" : z2555.MaterialInBoundSno = Children(i).Data
                                Case "MATERIALINBOUNDDSEQ" : z2555.MaterialInBoundDseq = Children(i).Data
                                Case "PACKAUDIT" : z2555.PackAudit = Children(i).Data
                                Case "QTYAUDIT" : z2555.QtyAudit = Children(i).Data
                                Case "QTYADJUST" : z2555.QtyAdjust = Children(i).Data
                                Case "SEWAREHOUSEPOSITION" : z2555.seWareHousePosition = Children(i).Data
                                Case "CDWAREHOUSEPOSITION" : z2555.cdWareHousePosition = Children(i).Data
                                Case "CHECKCOMPLETE" : z2555.CheckComplete = Children(i).Data
                                Case "INCHARGEAUDIT" : z2555.InchargeAudit = Children(i).Data
                                Case "REMARK" : z2555.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2555_MOVE", vbCritical)
        End Try
    End Function

End Module
