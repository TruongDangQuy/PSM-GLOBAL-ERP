'=========================================================================================================================================================
'   TABLE : (PFK3427)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3427

    Structure T3427_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public FactOrderNo As String  '			char(9)		*
        Public ExpenseSeq As Double  '			decimal		*
        Public seExpense As String  '			char(3)
        Public cdExpense As String  '			char(3)
        Public RateExpense As Double  '			decimal
        Public PackExpense As Double  '			decimal
        Public QtyExpense As Double  '			decimal
        Public AmountExpense As Double  '			decimal
        Public AmountExpenseVND As Double  '			decimal
        Public AmountExpenseUSD As Double  '			decimal
        Public Remark As String  '			nchar(200)
        '=========================================================================================================================================================
    End Structure

    Public D3427 As T3427_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK3427(FactOrderNo As String, EXPENSESEQ As Double) As Boolean
        READ_PFK3427 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3427 "
            SQL = SQL & " WHERE K3427_FactOrderNo		 = '" & FactOrderNo & "' "
            SQL = SQL & "   AND K3427_ExpenseSeq		 =  " & ExpenseSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3427_CLEAR() : GoTo SKIP_READ_PFK3427

            Call K3427_MOVE(rd)
            READ_PFK3427 = True

SKIP_READ_PFK3427:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3427", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK3427(FactOrderNo As String, EXPENSESEQ As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3427 "
            SQL = SQL & " WHERE K3427_FactOrderNo		 = '" & FactOrderNo & "' "
            SQL = SQL & "   AND K3427_ExpenseSeq		 =  " & ExpenseSeq & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK3427", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK3427(z3427 As T3427_AREA) As Boolean
        WRITE_PFK3427 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3427)

            SQL = " INSERT INTO PFK3427 "
            SQL = SQL & " ( "
            SQL = SQL & " K3427_FactOrderNo,"
            SQL = SQL & " K3427_ExpenseSeq,"
            SQL = SQL & " K3427_seExpense,"
            SQL = SQL & " K3427_cdExpense,"
            SQL = SQL & " K3427_RateExpense,"
            SQL = SQL & " K3427_PackExpense,"
            SQL = SQL & " K3427_QtyExpense,"
            SQL = SQL & " K3427_AmountExpense,"
            SQL = SQL & " K3427_AmountExpenseVND,"
            SQL = SQL & " K3427_AmountExpenseUSD,"
            SQL = SQL & " K3427_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z3427.FactOrderNo) & "', "
            SQL = SQL & "   " & FormatSQL(z3427.ExpenseSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3427.seExpense) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3427.cdExpense) & "', "
            SQL = SQL & "   " & FormatSQL(z3427.RateExpense) & ", "
            SQL = SQL & "   " & FormatSQL(z3427.PackExpense) & ", "
            SQL = SQL & "   " & FormatSQL(z3427.QtyExpense) & ", "
            SQL = SQL & "   " & FormatSQL(z3427.AmountExpense) & ", "
            SQL = SQL & "   " & FormatSQL(z3427.AmountExpenseVND) & ", "
            SQL = SQL & "   " & FormatSQL(z3427.AmountExpenseUSD) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3427.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK3427 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK3427", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK3427(z3427 As T3427_AREA) As Boolean
        REWRITE_PFK3427 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3427)

            SQL = " UPDATE PFK3427 SET "
            SQL = SQL & "    K3427_seExpense      = N'" & FormatSQL(z3427.seExpense) & "', "
            SQL = SQL & "    K3427_cdExpense      = N'" & FormatSQL(z3427.cdExpense) & "', "
            SQL = SQL & "    K3427_RateExpense      =  " & FormatSQL(z3427.RateExpense) & ", "
            SQL = SQL & "    K3427_PackExpense      =  " & FormatSQL(z3427.PackExpense) & ", "
            SQL = SQL & "    K3427_QtyExpense      =  " & FormatSQL(z3427.QtyExpense) & ", "
            SQL = SQL & "    K3427_AmountExpense      =  " & FormatSQL(z3427.AmountExpense) & ", "
            SQL = SQL & "    K3427_AmountExpenseVND      =  " & FormatSQL(z3427.AmountExpenseVND) & ", "
            SQL = SQL & "    K3427_AmountExpenseUSD      =  " & FormatSQL(z3427.AmountExpenseUSD) & ", "
            SQL = SQL & "    K3427_Remark      = N'" & FormatSQL(z3427.Remark) & "'  "
            SQL = SQL & " WHERE K3427_FactOrderNo		 = '" & z3427.FactOrderNo & "' "
            SQL = SQL & "   AND K3427_ExpenseSeq		 =  " & z3427.ExpenseSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK3427 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK3427", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK3427(z3427 As T3427_AREA) As Boolean
        DELETE_PFK3427 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK3427 "
            SQL = SQL & " WHERE K3427_FactOrderNo		 = '" & z3427.FactOrderNo & "' "
            SQL = SQL & "   AND K3427_ExpenseSeq		 =  " & z3427.ExpenseSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK3427 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK3427", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D3427_CLEAR()
        Try

            D3427.FactOrderNo = ""
            D3427.ExpenseSeq = 0
            D3427.seExpense = ""
            D3427.cdExpense = ""
            D3427.RateExpense = 0
            D3427.PackExpense = 0
            D3427.QtyExpense = 0
            D3427.AmountExpense = 0
            D3427.AmountExpenseVND = 0
            D3427.AmountExpenseUSD = 0
            D3427.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D3427_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x3427 As T3427_AREA)
        Try

            x3427.FactOrderNo = trim$(x3427.FactOrderNo)
            x3427.ExpenseSeq = trim$(x3427.ExpenseSeq)
            x3427.seExpense = trim$(x3427.seExpense)
            x3427.cdExpense = trim$(x3427.cdExpense)
            x3427.RateExpense = trim$(x3427.RateExpense)
            x3427.PackExpense = trim$(x3427.PackExpense)
            x3427.QtyExpense = trim$(x3427.QtyExpense)
            x3427.AmountExpense = trim$(x3427.AmountExpense)
            x3427.AmountExpenseVND = trim$(x3427.AmountExpenseVND)
            x3427.AmountExpenseUSD = trim$(x3427.AmountExpenseUSD)
            x3427.Remark = trim$(x3427.Remark)

            If trim$(x3427.FactOrderNo) = "" Then x3427.FactOrderNo = Space(1)
            If trim$(x3427.ExpenseSeq) = "" Then x3427.ExpenseSeq = 0
            If trim$(x3427.seExpense) = "" Then x3427.seExpense = Space(1)
            If trim$(x3427.cdExpense) = "" Then x3427.cdExpense = Space(1)
            If trim$(x3427.RateExpense) = "" Then x3427.RateExpense = 0
            If trim$(x3427.PackExpense) = "" Then x3427.PackExpense = 0
            If trim$(x3427.QtyExpense) = "" Then x3427.QtyExpense = 0
            If trim$(x3427.AmountExpense) = "" Then x3427.AmountExpense = 0
            If trim$(x3427.AmountExpenseVND) = "" Then x3427.AmountExpenseVND = 0
            If trim$(x3427.AmountExpenseUSD) = "" Then x3427.AmountExpenseUSD = 0
            If trim$(x3427.Remark) = "" Then x3427.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K3427_MOVE(rs3427 As SqlClient.SqlDataReader)
        Try

            Call D3427_CLEAR()

            If IsdbNull(rs3427!K3427_FactOrderNo) = False Then D3427.FactOrderNo = Trim$(rs3427!K3427_FactOrderNo)
            If IsdbNull(rs3427!K3427_ExpenseSeq) = False Then D3427.ExpenseSeq = Trim$(rs3427!K3427_ExpenseSeq)
            If IsdbNull(rs3427!K3427_seExpense) = False Then D3427.seExpense = Trim$(rs3427!K3427_seExpense)
            If IsdbNull(rs3427!K3427_cdExpense) = False Then D3427.cdExpense = Trim$(rs3427!K3427_cdExpense)
            If IsdbNull(rs3427!K3427_RateExpense) = False Then D3427.RateExpense = Trim$(rs3427!K3427_RateExpense)
            If IsdbNull(rs3427!K3427_PackExpense) = False Then D3427.PackExpense = Trim$(rs3427!K3427_PackExpense)
            If IsdbNull(rs3427!K3427_QtyExpense) = False Then D3427.QtyExpense = Trim$(rs3427!K3427_QtyExpense)
            If IsdbNull(rs3427!K3427_AmountExpense) = False Then D3427.AmountExpense = Trim$(rs3427!K3427_AmountExpense)
            If IsdbNull(rs3427!K3427_AmountExpenseVND) = False Then D3427.AmountExpenseVND = Trim$(rs3427!K3427_AmountExpenseVND)
            If IsdbNull(rs3427!K3427_AmountExpenseUSD) = False Then D3427.AmountExpenseUSD = Trim$(rs3427!K3427_AmountExpenseUSD)
            If IsdbNull(rs3427!K3427_Remark) = False Then D3427.Remark = Trim$(rs3427!K3427_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3427_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K3427_MOVE(rs3427 As DataRow)
        Try

            Call D3427_CLEAR()

            If IsdbNull(rs3427!K3427_FactOrderNo) = False Then D3427.FactOrderNo = Trim$(rs3427!K3427_FactOrderNo)
            If IsdbNull(rs3427!K3427_ExpenseSeq) = False Then D3427.ExpenseSeq = Trim$(rs3427!K3427_ExpenseSeq)
            If IsdbNull(rs3427!K3427_seExpense) = False Then D3427.seExpense = Trim$(rs3427!K3427_seExpense)
            If IsdbNull(rs3427!K3427_cdExpense) = False Then D3427.cdExpense = Trim$(rs3427!K3427_cdExpense)
            If IsdbNull(rs3427!K3427_RateExpense) = False Then D3427.RateExpense = Trim$(rs3427!K3427_RateExpense)
            If IsdbNull(rs3427!K3427_PackExpense) = False Then D3427.PackExpense = Trim$(rs3427!K3427_PackExpense)
            If IsdbNull(rs3427!K3427_QtyExpense) = False Then D3427.QtyExpense = Trim$(rs3427!K3427_QtyExpense)
            If IsdbNull(rs3427!K3427_AmountExpense) = False Then D3427.AmountExpense = Trim$(rs3427!K3427_AmountExpense)
            If IsdbNull(rs3427!K3427_AmountExpenseVND) = False Then D3427.AmountExpenseVND = Trim$(rs3427!K3427_AmountExpenseVND)
            If IsdbNull(rs3427!K3427_AmountExpenseUSD) = False Then D3427.AmountExpenseUSD = Trim$(rs3427!K3427_AmountExpenseUSD)
            If IsdbNull(rs3427!K3427_Remark) = False Then D3427.Remark = Trim$(rs3427!K3427_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3427_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K3427_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3427 As T3427_AREA, FactOrderNo As String, EXPENSESEQ As Double) As Boolean

        K3427_MOVE = False

        Try
            If READ_PFK3427(FactOrderNo, EXPENSESEQ) = True Then
                z3427 = D3427
                K3427_MOVE = True
            Else
                z3427 = Nothing
            End If

            If getColumIndex(spr, "FactOrderNo") > -1 Then z3427.FactOrderNo = getDataM(spr, getColumIndex(spr, "FactOrderNo"), xRow)
            If getColumIndex(spr, "ExpenseSeq") > -1 Then z3427.ExpenseSeq = getDataM(spr, getColumIndex(spr, "ExpenseSeq"), xRow)
            If getColumIndex(spr, "seExpense") > -1 Then z3427.seExpense = getDataM(spr, getColumIndex(spr, "seExpense"), xRow)
            If getColumIndex(spr, "cdExpense") > -1 Then z3427.cdExpense = getDataM(spr, getColumIndex(spr, "cdExpense"), xRow)
            If getColumIndex(spr, "RateExpense") > -1 Then z3427.RateExpense = getDataM(spr, getColumIndex(spr, "RateExpense"), xRow)
            If getColumIndex(spr, "PackExpense") > -1 Then z3427.PackExpense = getDataM(spr, getColumIndex(spr, "PackExpense"), xRow)
            If getColumIndex(spr, "QtyExpense") > -1 Then z3427.QtyExpense = getDataM(spr, getColumIndex(spr, "QtyExpense"), xRow)
            If getColumIndex(spr, "AmountExpense") > -1 Then z3427.AmountExpense = getDataM(spr, getColumIndex(spr, "AmountExpense"), xRow)
            If getColumIndex(spr, "AmountExpenseVND") > -1 Then z3427.AmountExpenseVND = getDataM(spr, getColumIndex(spr, "AmountExpenseVND"), xRow)
            If getColumIndex(spr, "AmountExpenseUSD") > -1 Then z3427.AmountExpenseUSD = getDataM(spr, getColumIndex(spr, "AmountExpenseUSD"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z3427.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3427_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K3427_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3427 As T3427_AREA, CheckClear As Boolean, FactOrderNo As String, EXPENSESEQ As Double) As Boolean

        K3427_MOVE = False

        Try
            If READ_PFK3427(FactOrderNo, EXPENSESEQ) = True Then
                z3427 = D3427
                K3427_MOVE = True
            Else
                If CheckClear = True Then z3427 = Nothing
            End If

            If getColumIndex(spr, "FactOrderNo") > -1 Then z3427.FactOrderNo = getDataM(spr, getColumIndex(spr, "FactOrderNo"), xRow)
            If getColumIndex(spr, "ExpenseSeq") > -1 Then z3427.ExpenseSeq = getDataM(spr, getColumIndex(spr, "ExpenseSeq"), xRow)
            If getColumIndex(spr, "seExpense") > -1 Then z3427.seExpense = getDataM(spr, getColumIndex(spr, "seExpense"), xRow)
            If getColumIndex(spr, "cdExpense") > -1 Then z3427.cdExpense = getDataM(spr, getColumIndex(spr, "cdExpense"), xRow)
            If getColumIndex(spr, "RateExpense") > -1 Then z3427.RateExpense = getDataM(spr, getColumIndex(spr, "RateExpense"), xRow)
            If getColumIndex(spr, "PackExpense") > -1 Then z3427.PackExpense = getDataM(spr, getColumIndex(spr, "PackExpense"), xRow)
            If getColumIndex(spr, "QtyExpense") > -1 Then z3427.QtyExpense = getDataM(spr, getColumIndex(spr, "QtyExpense"), xRow)
            If getColumIndex(spr, "AmountExpense") > -1 Then z3427.AmountExpense = getDataM(spr, getColumIndex(spr, "AmountExpense"), xRow)
            If getColumIndex(spr, "AmountExpenseVND") > -1 Then z3427.AmountExpenseVND = getDataM(spr, getColumIndex(spr, "AmountExpenseVND"), xRow)
            If getColumIndex(spr, "AmountExpenseUSD") > -1 Then z3427.AmountExpenseUSD = getDataM(spr, getColumIndex(spr, "AmountExpenseUSD"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z3427.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3427_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K3427_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3427 As T3427_AREA, Job As String, FactOrderNo As String, EXPENSESEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3427_MOVE = False

        Try
            If READ_PFK3427(FactOrderNo, EXPENSESEQ) = True Then
                z3427 = D3427
                K3427_MOVE = True
            Else
                z3427 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3427")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "FactOrderNo" : z3427.FactOrderNo = Children(i).Code
                                Case "EXPENSESEQ" : z3427.ExpenseSeq = Children(i).Code
                                Case "SEEXPENSE" : z3427.seExpense = Children(i).Code
                                Case "CDEXPENSE" : z3427.cdExpense = Children(i).Code
                                Case "RATEEXPENSE" : z3427.RateExpense = Children(i).Code
                                Case "PACKEXPENSE" : z3427.PackExpense = Children(i).Code
                                Case "QTYEXPENSE" : z3427.QtyExpense = Children(i).Code
                                Case "AMOUNTEXPENSE" : z3427.AmountExpense = Children(i).Code
                                Case "AMOUNTEXPENSEVND" : z3427.AmountExpenseVND = Children(i).Code
                                Case "AMOUNTEXPENSEUSD" : z3427.AmountExpenseUSD = Children(i).Code
                                Case "REMARK" : z3427.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "FactOrderNo" : z3427.FactOrderNo = Children(i).Data
                                Case "EXPENSESEQ" : z3427.ExpenseSeq = Children(i).Data
                                Case "SEEXPENSE" : z3427.seExpense = Children(i).Data
                                Case "CDEXPENSE" : z3427.cdExpense = Children(i).Data
                                Case "RATEEXPENSE" : z3427.RateExpense = Children(i).Data
                                Case "PACKEXPENSE" : z3427.PackExpense = Children(i).Data
                                Case "QTYEXPENSE" : z3427.QtyExpense = Children(i).Data
                                Case "AMOUNTEXPENSE" : z3427.AmountExpense = Children(i).Data
                                Case "AMOUNTEXPENSEVND" : z3427.AmountExpenseVND = Children(i).Data
                                Case "AMOUNTEXPENSEUSD" : z3427.AmountExpenseUSD = Children(i).Data
                                Case "REMARK" : z3427.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3427_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K3427_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3427 As T3427_AREA, Job As String, CheckClear As Boolean, FactOrderNo As String, EXPENSESEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3427_MOVE = False

        Try
            If READ_PFK3427(FactOrderNo, EXPENSESEQ) = True Then
                z3427 = D3427
                K3427_MOVE = True
            Else
                If CheckClear = True Then z3427 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3427")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "FactOrderNo" : z3427.FactOrderNo = Children(i).Code
                                Case "EXPENSESEQ" : z3427.ExpenseSeq = Children(i).Code
                                Case "SEEXPENSE" : z3427.seExpense = Children(i).Code
                                Case "CDEXPENSE" : z3427.cdExpense = Children(i).Code
                                Case "RATEEXPENSE" : z3427.RateExpense = Children(i).Code
                                Case "PACKEXPENSE" : z3427.PackExpense = Children(i).Code
                                Case "QTYEXPENSE" : z3427.QtyExpense = Children(i).Code
                                Case "AMOUNTEXPENSE" : z3427.AmountExpense = Children(i).Code
                                Case "AMOUNTEXPENSEVND" : z3427.AmountExpenseVND = Children(i).Code
                                Case "AMOUNTEXPENSEUSD" : z3427.AmountExpenseUSD = Children(i).Code
                                Case "REMARK" : z3427.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "FactOrderNo" : z3427.FactOrderNo = Children(i).Data
                                Case "EXPENSESEQ" : z3427.ExpenseSeq = Children(i).Data
                                Case "SEEXPENSE" : z3427.seExpense = Children(i).Data
                                Case "CDEXPENSE" : z3427.cdExpense = Children(i).Data
                                Case "RATEEXPENSE" : z3427.RateExpense = Children(i).Data
                                Case "PACKEXPENSE" : z3427.PackExpense = Children(i).Data
                                Case "QTYEXPENSE" : z3427.QtyExpense = Children(i).Data
                                Case "AMOUNTEXPENSE" : z3427.AmountExpense = Children(i).Data
                                Case "AMOUNTEXPENSEVND" : z3427.AmountExpenseVND = Children(i).Data
                                Case "AMOUNTEXPENSEUSD" : z3427.AmountExpenseUSD = Children(i).Data
                                Case "REMARK" : z3427.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3427_MOVE", vbCritical)
        End Try
    End Function

End Module
