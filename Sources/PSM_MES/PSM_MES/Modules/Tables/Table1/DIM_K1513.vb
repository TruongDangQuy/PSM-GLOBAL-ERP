'=========================================================================================================================================================
'   TABLE : (PFK1513)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1513

    Structure T1513_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public OrderNo As String  '			char(9)		*
        Public OrderSeq As Double  '			decimal		*
        Public DateOrder As String  '			char(8)
        Public AmountForecastTaxExportVND As Double  '			decimal
        Public AmountForecastTaxEnvironmentVND As Double  '			decimal
        Public AmountForecastTaxVATVND As Double  '			decimal
        Public AmountActualTaxExportVND As Double  '			decimal
        Public AmountActualTaxEnvironmentVND As Double  '			decimal
        Public AmountActualTaxVATVND As Double  '			decimal
        Public AmountReceivedTaxExportVND As Double  '			decimal
        Public AmountReceivedTaxEnvironmentVND As Double  '			decimal
        Public AmountReceivedTaxVATVND As Double  '			decimal
        Public CheckComplete As String  '			char(1)
        Public Remark As String  '			nvarchar(150)
        '=========================================================================================================================================================
    End Structure

    Public D1513 As T1513_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK1513(ORDERNO As String, ORDERSEQ As Double) As Boolean
        READ_PFK1513 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1513 "
            SQL = SQL & " WHERE K1513_OrderNo		 = '" & OrderNo & "' "
            SQL = SQL & "   AND K1513_OrderSeq		 =  " & OrderSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D1513_CLEAR() : GoTo SKIP_READ_PFK1513

            Call K1513_MOVE(rd)
            READ_PFK1513 = True

SKIP_READ_PFK1513:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK1513", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK1513(ORDERNO As String, ORDERSEQ As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1513 "
            SQL = SQL & " WHERE K1513_OrderNo		 = '" & OrderNo & "' "
            SQL = SQL & "   AND K1513_OrderSeq		 =  " & OrderSeq & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK1513", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK1513(z1513 As T1513_AREA) As Boolean
        WRITE_PFK1513 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z1513)

            SQL = " INSERT INTO PFK1513 "
            SQL = SQL & " ( "
            SQL = SQL & " K1513_OrderNo,"
            SQL = SQL & " K1513_OrderSeq,"
            SQL = SQL & " K1513_DateOrder,"
            SQL = SQL & " K1513_AmountForecastTaxExportVND,"
            SQL = SQL & " K1513_AmountForecastTaxEnvironmentVND,"
            SQL = SQL & " K1513_AmountForecastTaxVATVND,"
            SQL = SQL & " K1513_AmountActualTaxExportVND,"
            SQL = SQL & " K1513_AmountActualTaxEnvironmentVND,"
            SQL = SQL & " K1513_AmountActualTaxVATVND,"
            SQL = SQL & " K1513_AmountReceivedTaxExportVND,"
            SQL = SQL & " K1513_AmountReceivedTaxEnvironmentVND,"
            SQL = SQL & " K1513_AmountReceivedTaxVATVND,"
            SQL = SQL & " K1513_CheckComplete,"
            SQL = SQL & " K1513_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & z1513.OrderNo & "', "
            SQL = SQL & "   " & z1513.OrderSeq & ", "
            SQL = SQL & "  N'" & z1513.DateOrder & "', "
            SQL = SQL & "   " & z1513.AmountForecastTaxExportVND & ", "
            SQL = SQL & "   " & z1513.AmountForecastTaxEnvironmentVND & ", "
            SQL = SQL & "   " & z1513.AmountForecastTaxVATVND & ", "
            SQL = SQL & "   " & z1513.AmountActualTaxExportVND & ", "
            SQL = SQL & "   " & z1513.AmountActualTaxEnvironmentVND & ", "
            SQL = SQL & "   " & z1513.AmountActualTaxVATVND & ", "
            SQL = SQL & "   " & z1513.AmountReceivedTaxExportVND & ", "
            SQL = SQL & "   " & z1513.AmountReceivedTaxEnvironmentVND & ", "
            SQL = SQL & "   " & z1513.AmountReceivedTaxVATVND & ", "
            SQL = SQL & "  N'" & z1513.CheckComplete & "', "
            SQL = SQL & "  N'" & z1513.Remark & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK1513 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK1513", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK1513(z1513 As T1513_AREA) As Boolean
        REWRITE_PFK1513 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z1513)

            SQL = " UPDATE PFK1513 SET "
            SQL = SQL & "    K1513_DateOrder      = N'" & z1513.DateOrder & "', "
            SQL = SQL & "    K1513_AmountForecastTaxExportVND      =  " & z1513.AmountForecastTaxExportVND & ", "
            SQL = SQL & "    K1513_AmountForecastTaxEnvironmentVND      =  " & z1513.AmountForecastTaxEnvironmentVND & ", "
            SQL = SQL & "    K1513_AmountForecastTaxVATVND      =  " & z1513.AmountForecastTaxVATVND & ", "
            SQL = SQL & "    K1513_AmountActualTaxExportVND      =  " & z1513.AmountActualTaxExportVND & ", "
            SQL = SQL & "    K1513_AmountActualTaxEnvironmentVND      =  " & z1513.AmountActualTaxEnvironmentVND & ", "
            SQL = SQL & "    K1513_AmountActualTaxVATVND      =  " & z1513.AmountActualTaxVATVND & ", "
            SQL = SQL & "    K1513_AmountReceivedTaxExportVND      =  " & z1513.AmountReceivedTaxExportVND & ", "
            SQL = SQL & "    K1513_AmountReceivedTaxEnvironmentVND      =  " & z1513.AmountReceivedTaxEnvironmentVND & ", "
            SQL = SQL & "    K1513_AmountReceivedTaxVATVND      =  " & z1513.AmountReceivedTaxVATVND & ", "
            SQL = SQL & "    K1513_CheckComplete      = N'" & z1513.CheckComplete & "', "
            SQL = SQL & "    K1513_Remark      = N'" & z1513.Remark & "'  "
            SQL = SQL & " WHERE K1513_OrderNo		 = '" & z1513.OrderNo & "' "
            SQL = SQL & "   AND K1513_OrderSeq		 =  " & z1513.OrderSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK1513 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK1513", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK1513(z1513 As T1513_AREA) As Boolean
        DELETE_PFK1513 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK1513 "
            SQL = SQL & " WHERE K1513_OrderNo		 = '" & z1513.OrderNo & "' "
            SQL = SQL & "   AND K1513_OrderSeq		 =  " & z1513.OrderSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK1513 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK1513", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D1513_CLEAR()
        Try

            D1513.OrderNo = ""
            D1513.OrderSeq = 0
            D1513.DateOrder = ""
            D1513.AmountForecastTaxExportVND = 0
            D1513.AmountForecastTaxEnvironmentVND = 0
            D1513.AmountForecastTaxVATVND = 0
            D1513.AmountActualTaxExportVND = 0
            D1513.AmountActualTaxEnvironmentVND = 0
            D1513.AmountActualTaxVATVND = 0
            D1513.AmountReceivedTaxExportVND = 0
            D1513.AmountReceivedTaxEnvironmentVND = 0
            D1513.AmountReceivedTaxVATVND = 0
            D1513.CheckComplete = ""
            D1513.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D1513_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x1513 As T1513_AREA)
        Try

            x1513.OrderNo = trim$(x1513.OrderNo)
            x1513.OrderSeq = trim$(x1513.OrderSeq)
            x1513.DateOrder = trim$(x1513.DateOrder)
            x1513.AmountForecastTaxExportVND = trim$(x1513.AmountForecastTaxExportVND)
            x1513.AmountForecastTaxEnvironmentVND = trim$(x1513.AmountForecastTaxEnvironmentVND)
            x1513.AmountForecastTaxVATVND = trim$(x1513.AmountForecastTaxVATVND)
            x1513.AmountActualTaxExportVND = trim$(x1513.AmountActualTaxExportVND)
            x1513.AmountActualTaxEnvironmentVND = trim$(x1513.AmountActualTaxEnvironmentVND)
            x1513.AmountActualTaxVATVND = trim$(x1513.AmountActualTaxVATVND)
            x1513.AmountReceivedTaxExportVND = trim$(x1513.AmountReceivedTaxExportVND)
            x1513.AmountReceivedTaxEnvironmentVND = trim$(x1513.AmountReceivedTaxEnvironmentVND)
            x1513.AmountReceivedTaxVATVND = trim$(x1513.AmountReceivedTaxVATVND)
            x1513.CheckComplete = trim$(x1513.CheckComplete)
            x1513.Remark = trim$(x1513.Remark)

            If trim$(x1513.OrderNo) = "" Then x1513.OrderNo = Space(1)
            If trim$(x1513.OrderSeq) = "" Then x1513.OrderSeq = 0
            If trim$(x1513.DateOrder) = "" Then x1513.DateOrder = Space(1)
            If trim$(x1513.AmountForecastTaxExportVND) = "" Then x1513.AmountForecastTaxExportVND = 0
            If trim$(x1513.AmountForecastTaxEnvironmentVND) = "" Then x1513.AmountForecastTaxEnvironmentVND = 0
            If trim$(x1513.AmountForecastTaxVATVND) = "" Then x1513.AmountForecastTaxVATVND = 0
            If trim$(x1513.AmountActualTaxExportVND) = "" Then x1513.AmountActualTaxExportVND = 0
            If trim$(x1513.AmountActualTaxEnvironmentVND) = "" Then x1513.AmountActualTaxEnvironmentVND = 0
            If trim$(x1513.AmountActualTaxVATVND) = "" Then x1513.AmountActualTaxVATVND = 0
            If trim$(x1513.AmountReceivedTaxExportVND) = "" Then x1513.AmountReceivedTaxExportVND = 0
            If trim$(x1513.AmountReceivedTaxEnvironmentVND) = "" Then x1513.AmountReceivedTaxEnvironmentVND = 0
            If trim$(x1513.AmountReceivedTaxVATVND) = "" Then x1513.AmountReceivedTaxVATVND = 0
            If trim$(x1513.CheckComplete) = "" Then x1513.CheckComplete = Space(1)
            If trim$(x1513.Remark) = "" Then x1513.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K1513_MOVE(rs1513 As SqlClient.SqlDataReader)
        Try

            Call D1513_CLEAR()

            If IsdbNull(rs1513!K1513_OrderNo) = False Then D1513.OrderNo = Trim$(rs1513!K1513_OrderNo)
            If IsdbNull(rs1513!K1513_OrderSeq) = False Then D1513.OrderSeq = Trim$(rs1513!K1513_OrderSeq)
            If IsdbNull(rs1513!K1513_DateOrder) = False Then D1513.DateOrder = Trim$(rs1513!K1513_DateOrder)
            If IsdbNull(rs1513!K1513_AmountForecastTaxExportVND) = False Then D1513.AmountForecastTaxExportVND = Trim$(rs1513!K1513_AmountForecastTaxExportVND)
            If IsDBNull(rs1513!K1513_AmountForecastTaxEnvironmentVND) = False Then D1513.AmountForecastTaxEnvironmentVND = Trim$(rs1513!K1513_AmountForecastTaxEnvironmentVND)
            If IsdbNull(rs1513!K1513_AmountForecastTaxVATVND) = False Then D1513.AmountForecastTaxVATVND = Trim$(rs1513!K1513_AmountForecastTaxVATVND)
            If IsdbNull(rs1513!K1513_AmountActualTaxExportVND) = False Then D1513.AmountActualTaxExportVND = Trim$(rs1513!K1513_AmountActualTaxExportVND)
            If IsdbNull(rs1513!K1513_AmountActualTaxEnvironmentVND) = False Then D1513.AmountActualTaxEnvironmentVND = Trim$(rs1513!K1513_AmountActualTaxEnvironmentVND)
            If IsdbNull(rs1513!K1513_AmountActualTaxVATVND) = False Then D1513.AmountActualTaxVATVND = Trim$(rs1513!K1513_AmountActualTaxVATVND)
            If IsdbNull(rs1513!K1513_AmountReceivedTaxExportVND) = False Then D1513.AmountReceivedTaxExportVND = Trim$(rs1513!K1513_AmountReceivedTaxExportVND)
            If IsDBNull(rs1513!K1513_AmountReceivedTaxEnvironmentVND) = False Then D1513.AmountReceivedTaxEnvironmentVND = Trim$(rs1513!K1513_AmountReceivedTaxEnvironmentVND)
            If IsDBNull(rs1513!K1513_AmountReceivedTaxVATVND) = False Then D1513.AmountReceivedTaxVATVND = Trim$(rs1513!K1513_AmountReceivedTaxVATVND)
            If IsdbNull(rs1513!K1513_CheckComplete) = False Then D1513.CheckComplete = Trim$(rs1513!K1513_CheckComplete)
            If IsdbNull(rs1513!K1513_Remark) = False Then D1513.Remark = Trim$(rs1513!K1513_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K1513_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K1513_MOVE(rs1513 As DataRow)
        Try

            Call D1513_CLEAR()

            If IsdbNull(rs1513!K1513_OrderNo) = False Then D1513.OrderNo = Trim$(rs1513!K1513_OrderNo)
            If IsdbNull(rs1513!K1513_OrderSeq) = False Then D1513.OrderSeq = Trim$(rs1513!K1513_OrderSeq)
            If IsdbNull(rs1513!K1513_DateOrder) = False Then D1513.DateOrder = Trim$(rs1513!K1513_DateOrder)
            If IsdbNull(rs1513!K1513_AmountForecastTaxExportVND) = False Then D1513.AmountForecastTaxExportVND = Trim$(rs1513!K1513_AmountForecastTaxExportVND)
            If IsDBNull(rs1513!K1513_AmountForecastTaxEnvironmentVND) = False Then D1513.AmountForecastTaxEnvironmentVND = Trim$(rs1513!K1513_AmountForecastTaxEnvironmentVND)
            If IsdbNull(rs1513!K1513_AmountForecastTaxVATVND) = False Then D1513.AmountForecastTaxVATVND = Trim$(rs1513!K1513_AmountForecastTaxVATVND)
            If IsdbNull(rs1513!K1513_AmountActualTaxExportVND) = False Then D1513.AmountActualTaxExportVND = Trim$(rs1513!K1513_AmountActualTaxExportVND)
            If IsdbNull(rs1513!K1513_AmountActualTaxEnvironmentVND) = False Then D1513.AmountActualTaxEnvironmentVND = Trim$(rs1513!K1513_AmountActualTaxEnvironmentVND)
            If IsdbNull(rs1513!K1513_AmountActualTaxVATVND) = False Then D1513.AmountActualTaxVATVND = Trim$(rs1513!K1513_AmountActualTaxVATVND)
            If IsdbNull(rs1513!K1513_AmountReceivedTaxExportVND) = False Then D1513.AmountReceivedTaxExportVND = Trim$(rs1513!K1513_AmountReceivedTaxExportVND)
            If IsDBNull(rs1513!K1513_AmountReceivedTaxEnvironmentVND) = False Then D1513.AmountReceivedTaxEnvironmentVND = Trim$(rs1513!K1513_AmountReceivedTaxEnvironmentVND)
            If IsdbNull(rs1513!K1513_AmountReceivedTaxVATVND) = False Then D1513.AmountReceivedTaxVATVND = Trim$(rs1513!K1513_AmountReceivedTaxVATVND)
            If IsdbNull(rs1513!K1513_CheckComplete) = False Then D1513.CheckComplete = Trim$(rs1513!K1513_CheckComplete)
            If IsdbNull(rs1513!K1513_Remark) = False Then D1513.Remark = Trim$(rs1513!K1513_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K1513_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K1513_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z1513 As T1513_AREA, ORDERNO As String, ORDERSEQ As Double) As Boolean

        K1513_MOVE = False

        Try
            If READ_PFK1513(ORDERNO, ORDERSEQ) = True Then
                z1513 = D1513
                K1513_MOVE = True
            Else
                z1513 = Nothing
            End If

            If getColumIndex(spr, "OrderNo") > -1 Then z1513.OrderNo = getDataM(spr, getColumIndex(spr, "OrderNo"), xRow)
            If getColumIndex(spr, "OrderSeq") > -1 Then z1513.OrderSeq = getDataM(spr, getColumIndex(spr, "OrderSeq"), xRow)
            If getColumIndex(spr, "DateOrder") > -1 Then z1513.DateOrder = getDataM(spr, getColumIndex(spr, "DateOrder"), xRow)
            If getColumIndex(spr, "AmountForecastTaxExportVND") > -1 Then z1513.AmountForecastTaxExportVND = getDataM(spr, getColumIndex(spr, "AmountForecastTaxExportVND"), xRow)
            If getColumIndex(spr, "AmountForecastTaxEnvironmentVND") > -1 Then z1513.AmountForecastTaxEnvironmentVND = getDataM(spr, getColumIndex(spr, "AmountForecastTaxEnvironmentVND"), xRow)
            If getColumIndex(spr, "AmountForecastTaxVATVND") > -1 Then z1513.AmountForecastTaxVATVND = getDataM(spr, getColumIndex(spr, "AmountForecastTaxVATVND"), xRow)
            If getColumIndex(spr, "AmountActualTaxExportVND") > -1 Then z1513.AmountActualTaxExportVND = getDataM(spr, getColumIndex(spr, "AmountActualTaxExportVND"), xRow)
            If getColumIndex(spr, "AmountActualTaxEnvironmentVND") > -1 Then z1513.AmountActualTaxEnvironmentVND = getDataM(spr, getColumIndex(spr, "AmountActualTaxEnvironmentVND"), xRow)
            If getColumIndex(spr, "AmountActualTaxVATVND") > -1 Then z1513.AmountActualTaxVATVND = getDataM(spr, getColumIndex(spr, "AmountActualTaxVATVND"), xRow)
            If getColumIndex(spr, "AmountReceivedTaxExportVND") > -1 Then z1513.AmountReceivedTaxExportVND = getDataM(spr, getColumIndex(spr, "AmountReceivedTaxExportVND"), xRow)
            If getColumIndex(spr, "AmountReceivedTaxEnvironmentVND") > -1 Then z1513.AmountReceivedTaxEnvironmentVND = getDataM(spr, getColumIndex(spr, "AmountReceivedTaxEnvironmentVND"), xRow)
            If getColumIndex(spr, "AmountReceivedTaxVATVND") > -1 Then z1513.AmountReceivedTaxVATVND = getDataM(spr, getColumIndex(spr, "AmountReceivedTaxVATVND"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z1513.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z1513.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1513_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K1513_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z1513 As T1513_AREA, Job As String, ORDERNO As String, ORDERSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K1513_MOVE = False

        Try
            If READ_PFK1513(ORDERNO, ORDERSEQ) = True Then
                z1513 = D1513
                K1513_MOVE = True
            Else
                z1513 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1513")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "OrderNo" : z1513.OrderNo = Children(i).Code
                                Case "OrderSeq" : z1513.OrderSeq = Children(i).Code
                                Case "DateOrder" : z1513.DateOrder = Children(i).Code
                                Case "AmountForecastTaxExportVND" : z1513.AmountForecastTaxExportVND = Children(i).Code
                                Case "AmountForecastTaxEnvironmentVND" : z1513.AmountForecastTaxEnvironmentVND = Children(i).Code
                                Case "AmountForecastTaxVATVND" : z1513.AmountForecastTaxVATVND = Children(i).Code
                                Case "AmountActualTaxExportVND" : z1513.AmountActualTaxExportVND = Children(i).Code
                                Case "AmountActualTaxEnvironmentVND" : z1513.AmountActualTaxEnvironmentVND = Children(i).Code
                                Case "AmountActualTaxVATVND" : z1513.AmountActualTaxVATVND = Children(i).Code
                                Case "AmountReceivedTaxExportVND" : z1513.AmountReceivedTaxExportVND = Children(i).Code
                                Case "AmountReceivedTaxEnvironmentVND" : z1513.AmountReceivedTaxEnvironmentVND = Children(i).Code
                                Case "AmountReceivedTaxVATVND" : z1513.AmountReceivedTaxVATVND = Children(i).Code
                                Case "CheckComplete" : z1513.CheckComplete = Children(i).Code
                                Case "Remark" : z1513.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "OrderNo" : z1513.OrderNo = Children(i).Data
                                Case "OrderSeq" : z1513.OrderSeq = Children(i).Data
                                Case "DateOrder" : z1513.DateOrder = Children(i).Data
                                Case "AmountForecastTaxExportVND" : z1513.AmountForecastTaxExportVND = Children(i).Data
                                Case "AmountForecastTaxEnvironmentVND" : z1513.AmountForecastTaxEnvironmentVND = Children(i).Data
                                Case "AmountForecastTaxVATVND" : z1513.AmountForecastTaxVATVND = Children(i).Data
                                Case "AmountActualTaxExportVND" : z1513.AmountActualTaxExportVND = Children(i).Data
                                Case "AmountActualTaxEnvironmentVND" : z1513.AmountActualTaxEnvironmentVND = Children(i).Data
                                Case "AmountActualTaxVATVND" : z1513.AmountActualTaxVATVND = Children(i).Data
                                Case "AmountReceivedTaxExportVND" : z1513.AmountReceivedTaxExportVND = Children(i).Data
                                Case "AmountReceivedTaxEnvironmentVND" : z1513.AmountReceivedTaxEnvironmentVND = Children(i).Data
                                Case "AmountReceivedTaxVATVND" : z1513.AmountReceivedTaxVATVND = Children(i).Data
                                Case "CheckComplete" : z1513.CheckComplete = Children(i).Data
                                Case "Remark" : z1513.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1513_MOVE", vbCritical)
        End Try
    End Function

End Module
