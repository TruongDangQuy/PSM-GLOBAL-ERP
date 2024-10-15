'=========================================================================================================================================================
'   TABLE : (PFK2552)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K2552

    Structure T2552_AREA
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

    Public D2552 As T2552_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK2552(AUTOKEY As Double) As Boolean
        READ_PFK2552 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2552 "
            SQL = SQL & " WHERE K2552_Autokey		 =  " & Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D2552_CLEAR() : GoTo SKIP_READ_PFK2552

            Call K2552_MOVE(rd)
            READ_PFK2552 = True

SKIP_READ_PFK2552:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK2552", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK2552(AUTOKEY As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK2552 "
            SQL = SQL & " WHERE K2552_Autokey		 =  " & Autokey & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK2552", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK2552(z2552 As T2552_AREA) As Boolean
        WRITE_PFK2552 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z2552)

            SQL = " INSERT INTO PFK2552 "
            SQL = SQL & " ( "
            SQL = SQL & " K2552_Autokey,"
            SQL = SQL & " K2552_DateAudit,"
            SQL = SQL & " K2552_MaterialInBoundNo,"
            SQL = SQL & " K2552_MaterialInBoundSeq,"
            SQL = SQL & " K2552_MaterialInBoundSno,"
            SQL = SQL & " K2552_MaterialInBoundDseq,"
            SQL = SQL & " K2552_PackAudit,"
            SQL = SQL & " K2552_QtyAudit,"
            SQL = SQL & " K2552_QtyAdjust,"
            SQL = SQL & " K2552_seWareHousePosition,"
            SQL = SQL & " K2552_cdWareHousePosition,"
            SQL = SQL & " K2552_CheckComplete,"
            SQL = SQL & " K2552_InchargeAudit,"
            SQL = SQL & " K2552_TimeAudit,"
            SQL = SQL & " K2552_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "   " & FormatSQL(z2552.Autokey) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2552.DateAudit) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2552.MaterialInBoundNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2552.MaterialInBoundSeq) & "', "
            SQL = SQL & "   " & FormatSQL(z2552.MaterialInBoundSno) & ", "
            SQL = SQL & "   " & FormatSQL(z2552.MaterialInBoundDseq) & ", "
            SQL = SQL & "   " & FormatSQL(z2552.PackAudit) & ", "
            SQL = SQL & "   " & FormatSQL(z2552.QtyAudit) & ", "
            SQL = SQL & "   " & FormatSQL(z2552.QtyAdjust) & ", "
            SQL = SQL & "  N'" & FormatSQL(z2552.seWareHousePosition) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2552.cdWareHousePosition) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2552.CheckComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2552.InchargeAudit) & "', "
            SQL = SQL & "  N'" & FormatSQL(z2552.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK2552 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK2552", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK2552(z2552 As T2552_AREA) As Boolean
        REWRITE_PFK2552 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z2552)

            SQL = " UPDATE PFK2552 SET "
            SQL = SQL & "    K2552_DateAudit      = N'" & FormatSQL(z2552.DateAudit) & "', "
            SQL = SQL & "    K2552_MaterialInBoundNo      = N'" & FormatSQL(z2552.MaterialInBoundNo) & "', "
            SQL = SQL & "    K2552_MaterialInBoundSeq      = N'" & FormatSQL(z2552.MaterialInBoundSeq) & "', "
            SQL = SQL & "    K2552_MaterialInBoundSno      =  " & FormatSQL(z2552.MaterialInBoundSno) & ", "
            SQL = SQL & "    K2552_MaterialInBoundDseq      =  " & FormatSQL(z2552.MaterialInBoundDseq) & ", "
            SQL = SQL & "    K2552_PackAudit      =  " & FormatSQL(z2552.PackAudit) & ", "
            SQL = SQL & "    K2552_QtyAudit      =  " & FormatSQL(z2552.QtyAudit) & ", "
            SQL = SQL & "    K2552_QtyAdjust      =  " & FormatSQL(z2552.QtyAdjust) & ", "
            SQL = SQL & "    K2552_seWareHousePosition      = N'" & FormatSQL(z2552.seWareHousePosition) & "', "
            SQL = SQL & "    K2552_cdWareHousePosition      = N'" & FormatSQL(z2552.cdWareHousePosition) & "', "
            SQL = SQL & "    K2552_CheckComplete      = N'" & FormatSQL(z2552.CheckComplete) & "', "
            SQL = SQL & "    K2552_InchargeAudit      = N'" & FormatSQL(z2552.InchargeAudit) & "', "
            SQL = SQL & "    K2552_Remark      = N'" & FormatSQL(z2552.Remark) & "'  "
            SQL = SQL & " WHERE K2552_Autokey		 =  " & z2552.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK2552 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK2552", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK2552(z2552 As T2552_AREA) As Boolean
        DELETE_PFK2552 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK2552 "
            SQL = SQL & " WHERE K2552_Autokey		 =  " & z2552.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK2552 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK2552", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D2552_CLEAR()
        Try

            D2552.Autokey = 0
            D2552.DateAudit = ""
            D2552.MaterialInBoundNo = ""
            D2552.MaterialInBoundSeq = ""
            D2552.MaterialInBoundSno = 0
            D2552.MaterialInBoundDseq = 0
            D2552.PackAudit = 0
            D2552.QtyAudit = 0
            D2552.QtyAdjust = 0
            D2552.seWareHousePosition = ""
            D2552.cdWareHousePosition = ""
            D2552.CheckComplete = ""
            D2552.InchargeAudit = ""
            D2552.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D2552_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x2552 As T2552_AREA)
        Try

            x2552.Autokey = trim$(x2552.Autokey)
            x2552.DateAudit = trim$(x2552.DateAudit)
            x2552.MaterialInBoundNo = trim$(x2552.MaterialInBoundNo)
            x2552.MaterialInBoundSeq = trim$(x2552.MaterialInBoundSeq)
            x2552.MaterialInBoundSno = trim$(x2552.MaterialInBoundSno)
            x2552.MaterialInBoundDseq = trim$(x2552.MaterialInBoundDseq)
            x2552.PackAudit = trim$(x2552.PackAudit)
            x2552.QtyAudit = trim$(x2552.QtyAudit)
            x2552.QtyAdjust = trim$(x2552.QtyAdjust)
            x2552.seWareHousePosition = trim$(x2552.seWareHousePosition)
            x2552.cdWareHousePosition = trim$(x2552.cdWareHousePosition)
            x2552.CheckComplete = trim$(x2552.CheckComplete)
            x2552.InchargeAudit = trim$(x2552.InchargeAudit)
            x2552.Remark = Trim$(x2552.Remark)

            If trim$(x2552.Autokey) = "" Then x2552.Autokey = 0
            If trim$(x2552.DateAudit) = "" Then x2552.DateAudit = Space(1)
            If trim$(x2552.MaterialInBoundNo) = "" Then x2552.MaterialInBoundNo = Space(1)
            If trim$(x2552.MaterialInBoundSeq) = "" Then x2552.MaterialInBoundSeq = Space(1)
            If trim$(x2552.MaterialInBoundSno) = "" Then x2552.MaterialInBoundSno = 0
            If trim$(x2552.MaterialInBoundDseq) = "" Then x2552.MaterialInBoundDseq = 0
            If trim$(x2552.PackAudit) = "" Then x2552.PackAudit = 0
            If trim$(x2552.QtyAudit) = "" Then x2552.QtyAudit = 0
            If trim$(x2552.QtyAdjust) = "" Then x2552.QtyAdjust = 0
            If trim$(x2552.seWareHousePosition) = "" Then x2552.seWareHousePosition = Space(1)
            If trim$(x2552.cdWareHousePosition) = "" Then x2552.cdWareHousePosition = Space(1)
            If trim$(x2552.CheckComplete) = "" Then x2552.CheckComplete = Space(1)
            If trim$(x2552.InchargeAudit) = "" Then x2552.InchargeAudit = Space(1)
            If Trim$(x2552.Remark) = "" Then x2552.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K2552_MOVE(rs2552 As SqlClient.SqlDataReader)
        Try

            Call D2552_CLEAR()

            If IsdbNull(rs2552!K2552_Autokey) = False Then D2552.Autokey = Trim$(rs2552!K2552_Autokey)
            If IsdbNull(rs2552!K2552_DateAudit) = False Then D2552.DateAudit = Trim$(rs2552!K2552_DateAudit)
            If IsdbNull(rs2552!K2552_MaterialInBoundNo) = False Then D2552.MaterialInBoundNo = Trim$(rs2552!K2552_MaterialInBoundNo)
            If IsdbNull(rs2552!K2552_MaterialInBoundSeq) = False Then D2552.MaterialInBoundSeq = Trim$(rs2552!K2552_MaterialInBoundSeq)
            If IsdbNull(rs2552!K2552_MaterialInBoundSno) = False Then D2552.MaterialInBoundSno = Trim$(rs2552!K2552_MaterialInBoundSno)
            If IsdbNull(rs2552!K2552_MaterialInBoundDseq) = False Then D2552.MaterialInBoundDseq = Trim$(rs2552!K2552_MaterialInBoundDseq)
            If IsdbNull(rs2552!K2552_PackAudit) = False Then D2552.PackAudit = Trim$(rs2552!K2552_PackAudit)
            If IsdbNull(rs2552!K2552_QtyAudit) = False Then D2552.QtyAudit = Trim$(rs2552!K2552_QtyAudit)
            If IsdbNull(rs2552!K2552_QtyAdjust) = False Then D2552.QtyAdjust = Trim$(rs2552!K2552_QtyAdjust)
            If IsdbNull(rs2552!K2552_seWareHousePosition) = False Then D2552.seWareHousePosition = Trim$(rs2552!K2552_seWareHousePosition)
            If IsdbNull(rs2552!K2552_cdWareHousePosition) = False Then D2552.cdWareHousePosition = Trim$(rs2552!K2552_cdWareHousePosition)
            If IsdbNull(rs2552!K2552_CheckComplete) = False Then D2552.CheckComplete = Trim$(rs2552!K2552_CheckComplete)
            If IsdbNull(rs2552!K2552_InchargeAudit) = False Then D2552.InchargeAudit = Trim$(rs2552!K2552_InchargeAudit)
            If IsDBNull(rs2552!K2552_Remark) = False Then D2552.Remark = Trim$(rs2552!K2552_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K2552_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K2552_MOVE(rs2552 As DataRow)
        Try

            Call D2552_CLEAR()

            If IsdbNull(rs2552!K2552_Autokey) = False Then D2552.Autokey = Trim$(rs2552!K2552_Autokey)
            If IsdbNull(rs2552!K2552_DateAudit) = False Then D2552.DateAudit = Trim$(rs2552!K2552_DateAudit)
            If IsdbNull(rs2552!K2552_MaterialInBoundNo) = False Then D2552.MaterialInBoundNo = Trim$(rs2552!K2552_MaterialInBoundNo)
            If IsdbNull(rs2552!K2552_MaterialInBoundSeq) = False Then D2552.MaterialInBoundSeq = Trim$(rs2552!K2552_MaterialInBoundSeq)
            If IsdbNull(rs2552!K2552_MaterialInBoundSno) = False Then D2552.MaterialInBoundSno = Trim$(rs2552!K2552_MaterialInBoundSno)
            If IsdbNull(rs2552!K2552_MaterialInBoundDseq) = False Then D2552.MaterialInBoundDseq = Trim$(rs2552!K2552_MaterialInBoundDseq)
            If IsdbNull(rs2552!K2552_PackAudit) = False Then D2552.PackAudit = Trim$(rs2552!K2552_PackAudit)
            If IsdbNull(rs2552!K2552_QtyAudit) = False Then D2552.QtyAudit = Trim$(rs2552!K2552_QtyAudit)
            If IsdbNull(rs2552!K2552_QtyAdjust) = False Then D2552.QtyAdjust = Trim$(rs2552!K2552_QtyAdjust)
            If IsdbNull(rs2552!K2552_seWareHousePosition) = False Then D2552.seWareHousePosition = Trim$(rs2552!K2552_seWareHousePosition)
            If IsdbNull(rs2552!K2552_cdWareHousePosition) = False Then D2552.cdWareHousePosition = Trim$(rs2552!K2552_cdWareHousePosition)
            If IsdbNull(rs2552!K2552_CheckComplete) = False Then D2552.CheckComplete = Trim$(rs2552!K2552_CheckComplete)
            If IsdbNull(rs2552!K2552_InchargeAudit) = False Then D2552.InchargeAudit = Trim$(rs2552!K2552_InchargeAudit)
            If IsDBNull(rs2552!K2552_Remark) = False Then D2552.Remark = Trim$(rs2552!K2552_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K2552_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K2552_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z2552 As T2552_AREA, AUTOKEY As Double) As Boolean

        K2552_MOVE = False

        Try
            If READ_PFK2552(AUTOKEY) = True Then
                z2552 = D2552
                K2552_MOVE = True
            Else
                z2552 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z2552.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "DateAudit") > -1 Then z2552.DateAudit = getDataM(spr, getColumIndex(spr, "DateAudit"), xRow)
            If getColumIndex(spr, "MaterialInBoundNo") > -1 Then z2552.MaterialInBoundNo = getDataM(spr, getColumIndex(spr, "MaterialInBoundNo"), xRow)
            If getColumIndex(spr, "MaterialInBoundSeq") > -1 Then z2552.MaterialInBoundSeq = getDataM(spr, getColumIndex(spr, "MaterialInBoundSeq"), xRow)
            If getColumIndex(spr, "MaterialInBoundSno") > -1 Then z2552.MaterialInBoundSno = getDataM(spr, getColumIndex(spr, "MaterialInBoundSno"), xRow)
            If getColumIndex(spr, "MaterialInBoundDseq") > -1 Then z2552.MaterialInBoundDseq = getDataM(spr, getColumIndex(spr, "MaterialInBoundDseq"), xRow)
            If getColumIndex(spr, "PackAudit") > -1 Then z2552.PackAudit = getDataM(spr, getColumIndex(spr, "PackAudit"), xRow)
            If getColumIndex(spr, "QtyAudit") > -1 Then z2552.QtyAudit = getDataM(spr, getColumIndex(spr, "QtyAudit"), xRow)
            If getColumIndex(spr, "QtyAdjust") > -1 Then z2552.QtyAdjust = getDataM(spr, getColumIndex(spr, "QtyAdjust"), xRow)
            If getColumIndex(spr, "seWareHousePosition") > -1 Then z2552.seWareHousePosition = getDataM(spr, getColumIndex(spr, "seWareHousePosition"), xRow)
            If getColumIndex(spr, "cdWareHousePosition") > -1 Then z2552.cdWareHousePosition = getDataM(spr, getColumIndex(spr, "cdWareHousePosition"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z2552.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "InchargeAudit") > -1 Then z2552.InchargeAudit = getDataM(spr, getColumIndex(spr, "InchargeAudit"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z2552.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2552_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K2552_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z2552 As T2552_AREA, CheckClear As Boolean, AUTOKEY As Double) As Boolean

        K2552_MOVE = False

        Try
            If READ_PFK2552(AUTOKEY) = True Then
                z2552 = D2552
                K2552_MOVE = True
            Else
                If CheckClear = True Then z2552 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z2552.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "DateAudit") > -1 Then z2552.DateAudit = getDataM(spr, getColumIndex(spr, "DateAudit"), xRow)
            If getColumIndex(spr, "MaterialInBoundNo") > -1 Then z2552.MaterialInBoundNo = getDataM(spr, getColumIndex(spr, "MaterialInBoundNo"), xRow)
            If getColumIndex(spr, "MaterialInBoundSeq") > -1 Then z2552.MaterialInBoundSeq = getDataM(spr, getColumIndex(spr, "MaterialInBoundSeq"), xRow)
            If getColumIndex(spr, "MaterialInBoundSno") > -1 Then z2552.MaterialInBoundSno = getDataM(spr, getColumIndex(spr, "MaterialInBoundSno"), xRow)
            If getColumIndex(spr, "MaterialInBoundDseq") > -1 Then z2552.MaterialInBoundDseq = getDataM(spr, getColumIndex(spr, "MaterialInBoundDseq"), xRow)
            If getColumIndex(spr, "PackAudit") > -1 Then z2552.PackAudit = getDataM(spr, getColumIndex(spr, "PackAudit"), xRow)
            If getColumIndex(spr, "QtyAudit") > -1 Then z2552.QtyAudit = getDataM(spr, getColumIndex(spr, "QtyAudit"), xRow)
            If getColumIndex(spr, "QtyAdjust") > -1 Then z2552.QtyAdjust = getDataM(spr, getColumIndex(spr, "QtyAdjust"), xRow)
            If getColumIndex(spr, "seWareHousePosition") > -1 Then z2552.seWareHousePosition = getDataM(spr, getColumIndex(spr, "seWareHousePosition"), xRow)
            If getColumIndex(spr, "cdWareHousePosition") > -1 Then z2552.cdWareHousePosition = getDataM(spr, getColumIndex(spr, "cdWareHousePosition"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z2552.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "InchargeAudit") > -1 Then z2552.InchargeAudit = getDataM(spr, getColumIndex(spr, "InchargeAudit"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z2552.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2552_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K2552_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z2552 As T2552_AREA, Job As String, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K2552_MOVE = False

        Try
            If READ_PFK2552(AUTOKEY) = True Then
                z2552 = D2552
                K2552_MOVE = True
            Else
                z2552 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2552")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z2552.Autokey = Children(i).Code
                                Case "DATEAUDIT" : z2552.DateAudit = Children(i).Code
                                Case "MATERIALINBOUNDNO" : z2552.MaterialInBoundNo = Children(i).Code
                                Case "MATERIALINBOUNDSEQ" : z2552.MaterialInBoundSeq = Children(i).Code
                                Case "MATERIALINBOUNDSNO" : z2552.MaterialInBoundSno = Children(i).Code
                                Case "MATERIALINBOUNDDSEQ" : z2552.MaterialInBoundDseq = Children(i).Code
                                Case "PACKAUDIT" : z2552.PackAudit = Children(i).Code
                                Case "QTYAUDIT" : z2552.QtyAudit = Children(i).Code
                                Case "QTYADJUST" : z2552.QtyAdjust = Children(i).Code
                                Case "SEWAREHOUSEPOSITION" : z2552.seWareHousePosition = Children(i).Code
                                Case "CDWAREHOUSEPOSITION" : z2552.cdWareHousePosition = Children(i).Code
                                Case "CHECKCOMPLETE" : z2552.CheckComplete = Children(i).Code
                                Case "INCHARGEAUDIT" : z2552.InchargeAudit = Children(i).Code
                                Case "REMARK" : z2552.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z2552.Autokey = Children(i).Data
                                Case "DATEAUDIT" : z2552.DateAudit = Children(i).Data
                                Case "MATERIALINBOUNDNO" : z2552.MaterialInBoundNo = Children(i).Data
                                Case "MATERIALINBOUNDSEQ" : z2552.MaterialInBoundSeq = Children(i).Data
                                Case "MATERIALINBOUNDSNO" : z2552.MaterialInBoundSno = Children(i).Data
                                Case "MATERIALINBOUNDDSEQ" : z2552.MaterialInBoundDseq = Children(i).Data
                                Case "PACKAUDIT" : z2552.PackAudit = Children(i).Data
                                Case "QTYAUDIT" : z2552.QtyAudit = Children(i).Data
                                Case "QTYADJUST" : z2552.QtyAdjust = Children(i).Data
                                Case "SEWAREHOUSEPOSITION" : z2552.seWareHousePosition = Children(i).Data
                                Case "CDWAREHOUSEPOSITION" : z2552.cdWareHousePosition = Children(i).Data
                                Case "CHECKCOMPLETE" : z2552.CheckComplete = Children(i).Data
                                Case "INCHARGEAUDIT" : z2552.InchargeAudit = Children(i).Data
                                Case "REMARK" : z2552.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2552_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K2552_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z2552 As T2552_AREA, Job As String, CheckClear As Boolean, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K2552_MOVE = False

        Try
            If READ_PFK2552(AUTOKEY) = True Then
                z2552 = D2552
                K2552_MOVE = True
            Else
                If CheckClear = True Then z2552 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK2552")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z2552.Autokey = Children(i).Code
                                Case "DATEAUDIT" : z2552.DateAudit = Children(i).Code
                                Case "MATERIALINBOUNDNO" : z2552.MaterialInBoundNo = Children(i).Code
                                Case "MATERIALINBOUNDSEQ" : z2552.MaterialInBoundSeq = Children(i).Code
                                Case "MATERIALINBOUNDSNO" : z2552.MaterialInBoundSno = Children(i).Code
                                Case "MATERIALINBOUNDDSEQ" : z2552.MaterialInBoundDseq = Children(i).Code
                                Case "PACKAUDIT" : z2552.PackAudit = Children(i).Code
                                Case "QTYAUDIT" : z2552.QtyAudit = Children(i).Code
                                Case "QTYADJUST" : z2552.QtyAdjust = Children(i).Code
                                Case "SEWAREHOUSEPOSITION" : z2552.seWareHousePosition = Children(i).Code
                                Case "CDWAREHOUSEPOSITION" : z2552.cdWareHousePosition = Children(i).Code
                                Case "CHECKCOMPLETE" : z2552.CheckComplete = Children(i).Code
                                Case "INCHARGEAUDIT" : z2552.InchargeAudit = Children(i).Code
                                Case "REMARK" : z2552.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z2552.Autokey = Children(i).Data
                                Case "DATEAUDIT" : z2552.DateAudit = Children(i).Data
                                Case "MATERIALINBOUNDNO" : z2552.MaterialInBoundNo = Children(i).Data
                                Case "MATERIALINBOUNDSEQ" : z2552.MaterialInBoundSeq = Children(i).Data
                                Case "MATERIALINBOUNDSNO" : z2552.MaterialInBoundSno = Children(i).Data
                                Case "MATERIALINBOUNDDSEQ" : z2552.MaterialInBoundDseq = Children(i).Data
                                Case "PACKAUDIT" : z2552.PackAudit = Children(i).Data
                                Case "QTYAUDIT" : z2552.QtyAudit = Children(i).Data
                                Case "QTYADJUST" : z2552.QtyAdjust = Children(i).Data
                                Case "SEWAREHOUSEPOSITION" : z2552.seWareHousePosition = Children(i).Data
                                Case "CDWAREHOUSEPOSITION" : z2552.cdWareHousePosition = Children(i).Data
                                Case "CHECKCOMPLETE" : z2552.CheckComplete = Children(i).Data
                                Case "INCHARGEAUDIT" : z2552.InchargeAudit = Children(i).Data
                                Case "REMARK" : z2552.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K2552_MOVE", vbCritical)
        End Try
    End Function

End Module
