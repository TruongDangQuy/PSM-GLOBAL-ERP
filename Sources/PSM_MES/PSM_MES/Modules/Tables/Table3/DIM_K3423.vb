'=========================================================================================================================================================
'   TABLE : (PFK3423)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K3423

Structure T3423_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	FactOrderNo	 AS String	'			char(9)		*
        Public OrderNo As String  '			char(9)		*
        Public OrderNoSeq As String  '			char(2)		*
        Public JobCard As String  '			char(9)		*
        Public QtyOrder As Double  '			decimal
        Public Remark As String  '			nvarchar(500)
        '=========================================================================================================================================================
    End Structure

    Public D3423 As T3423_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK3423(FACTORDERNO As String, ORDERNO As String, ORDERNOSEQ As String, JOBCARD As String) As Boolean
        READ_PFK3423 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3423 "
            SQL = SQL & " WHERE K3423_FactOrderNo		 = '" & FactOrderNo & "' "
            SQL = SQL & "   AND K3423_OrderNo		 = '" & OrderNo & "' "
            SQL = SQL & "   AND K3423_OrderNoSeq		 = '" & OrderNoSeq & "' "
            SQL = SQL & "   AND K3423_JobCard		 = '" & JobCard & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D3423_CLEAR() : GoTo SKIP_READ_PFK3423

            Call K3423_MOVE(rd)
            READ_PFK3423 = True

SKIP_READ_PFK3423:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK3423", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK3423(FACTORDERNO As String, ORDERNO As String, ORDERNOSEQ As String, JOBCARD As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK3423 "
            SQL = SQL & " WHERE K3423_FactOrderNo		 = '" & FactOrderNo & "' "
            SQL = SQL & "   AND K3423_OrderNo		 = '" & OrderNo & "' "
            SQL = SQL & "   AND K3423_OrderNoSeq		 = '" & OrderNoSeq & "' "
            SQL = SQL & "   AND K3423_JobCard		 = '" & JobCard & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK3423", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK3423(z3423 As T3423_AREA) As Boolean
        WRITE_PFK3423 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3423)

            SQL = " INSERT INTO PFK3423 "
            SQL = SQL & " ( "
            SQL = SQL & " K3423_FactOrderNo,"
            SQL = SQL & " K3423_OrderNo,"
            SQL = SQL & " K3423_OrderNoSeq,"
            SQL = SQL & " K3423_JobCard,"
            SQL = SQL & " K3423_QtyOrder,"
            SQL = SQL & " K3423_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z3423.FactOrderNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3423.OrderNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3423.OrderNoSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z3423.JobCard) & "', "
            SQL = SQL & "   " & FormatSQL(z3423.QtyOrder) & ", "
            SQL = SQL & "  N'" & FormatSQL(z3423.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK3423 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK3423", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK3423(z3423 As T3423_AREA) As Boolean
        REWRITE_PFK3423 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z3423)

            SQL = " UPDATE PFK3423 SET "
            SQL = SQL & "    K3423_QtyOrder      =  " & FormatSQL(z3423.QtyOrder) & ", "
            SQL = SQL & "    K3423_Remark      = N'" & FormatSQL(z3423.Remark) & "'  "
            SQL = SQL & " WHERE K3423_FactOrderNo		 = '" & z3423.FactOrderNo & "' "
            SQL = SQL & "   AND K3423_OrderNo		 = '" & z3423.OrderNo & "' "
            SQL = SQL & "   AND K3423_OrderNoSeq		 = '" & z3423.OrderNoSeq & "' "
            SQL = SQL & "   AND K3423_JobCard		 = '" & z3423.JobCard & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK3423 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK3423", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK3423(z3423 As T3423_AREA) As Boolean
        DELETE_PFK3423 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK3423 "
            SQL = SQL & " WHERE K3423_FactOrderNo		 = '" & z3423.FactOrderNo & "' "
            SQL = SQL & "   AND K3423_OrderNo		 = '" & z3423.OrderNo & "' "
            SQL = SQL & "   AND K3423_OrderNoSeq		 = '" & z3423.OrderNoSeq & "' "
            SQL = SQL & "   AND K3423_JobCard		 = '" & z3423.JobCard & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK3423 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK3423", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D3423_CLEAR()
        Try

            D3423.FactOrderNo = ""
            D3423.OrderNo = ""
            D3423.OrderNoSeq = ""
            D3423.JobCard = ""
            D3423.QtyOrder = 0
            D3423.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D3423_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x3423 As T3423_AREA)
        Try

            x3423.FactOrderNo = trim$(x3423.FactOrderNo)
            x3423.OrderNo = trim$(x3423.OrderNo)
            x3423.OrderNoSeq = trim$(x3423.OrderNoSeq)
            x3423.JobCard = trim$(x3423.JobCard)
            x3423.QtyOrder = trim$(x3423.QtyOrder)
            x3423.Remark = trim$(x3423.Remark)

            If trim$(x3423.FactOrderNo) = "" Then x3423.FactOrderNo = Space(1)
            If trim$(x3423.OrderNo) = "" Then x3423.OrderNo = Space(1)
            If trim$(x3423.OrderNoSeq) = "" Then x3423.OrderNoSeq = Space(1)
            If trim$(x3423.JobCard) = "" Then x3423.JobCard = Space(1)
            If trim$(x3423.QtyOrder) = "" Then x3423.QtyOrder = 0
            If trim$(x3423.Remark) = "" Then x3423.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K3423_MOVE(rs3423 As SqlClient.SqlDataReader)
        Try

            Call D3423_CLEAR()

            If IsdbNull(rs3423!K3423_FactOrderNo) = False Then D3423.FactOrderNo = Trim$(rs3423!K3423_FactOrderNo)
            If IsdbNull(rs3423!K3423_OrderNo) = False Then D3423.OrderNo = Trim$(rs3423!K3423_OrderNo)
            If IsdbNull(rs3423!K3423_OrderNoSeq) = False Then D3423.OrderNoSeq = Trim$(rs3423!K3423_OrderNoSeq)
            If IsdbNull(rs3423!K3423_JobCard) = False Then D3423.JobCard = Trim$(rs3423!K3423_JobCard)
            If IsdbNull(rs3423!K3423_QtyOrder) = False Then D3423.QtyOrder = Trim$(rs3423!K3423_QtyOrder)
            If IsdbNull(rs3423!K3423_Remark) = False Then D3423.Remark = Trim$(rs3423!K3423_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3423_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K3423_MOVE(rs3423 As DataRow)
        Try

            Call D3423_CLEAR()

            If IsdbNull(rs3423!K3423_FactOrderNo) = False Then D3423.FactOrderNo = Trim$(rs3423!K3423_FactOrderNo)
            If IsdbNull(rs3423!K3423_OrderNo) = False Then D3423.OrderNo = Trim$(rs3423!K3423_OrderNo)
            If IsdbNull(rs3423!K3423_OrderNoSeq) = False Then D3423.OrderNoSeq = Trim$(rs3423!K3423_OrderNoSeq)
            If IsdbNull(rs3423!K3423_JobCard) = False Then D3423.JobCard = Trim$(rs3423!K3423_JobCard)
            If IsdbNull(rs3423!K3423_QtyOrder) = False Then D3423.QtyOrder = Trim$(rs3423!K3423_QtyOrder)
            If IsdbNull(rs3423!K3423_Remark) = False Then D3423.Remark = Trim$(rs3423!K3423_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K3423_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K3423_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3423 As T3423_AREA, FACTORDERNO As String, ORDERNO As String, ORDERNOSEQ As String, JOBCARD As String) As Boolean

        K3423_MOVE = False

        Try
            If READ_PFK3423(FACTORDERNO, ORDERNO, ORDERNOSEQ, JOBCARD) = True Then
                z3423 = D3423
                K3423_MOVE = True
            Else
                z3423 = Nothing
            End If

            If getColumIndex(spr, "FactOrderNo") > -1 Then z3423.FactOrderNo = getDataM(spr, getColumIndex(spr, "FactOrderNo"), xRow)
            If getColumIndex(spr, "OrderNo") > -1 Then z3423.OrderNo = getDataM(spr, getColumIndex(spr, "OrderNo"), xRow)
            If getColumIndex(spr, "OrderNoSeq") > -1 Then z3423.OrderNoSeq = getDataM(spr, getColumIndex(spr, "OrderNoSeq"), xRow)
            If getColumIndex(spr, "JobCard") > -1 Then z3423.JobCard = getDataM(spr, getColumIndex(spr, "JobCard"), xRow)
            If getColumIndex(spr, "QtyOrder") > -1 Then z3423.QtyOrder = getDataM(spr, getColumIndex(spr, "QtyOrder"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z3423.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3423_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K3423_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z3423 As T3423_AREA, CheckClear As Boolean, FACTORDERNO As String, ORDERNO As String, ORDERNOSEQ As String, JOBCARD As String) As Boolean

        K3423_MOVE = False

        Try
            If READ_PFK3423(FACTORDERNO, ORDERNO, ORDERNOSEQ, JOBCARD) = True Then
                z3423 = D3423
                K3423_MOVE = True
            Else
                If CheckClear = True Then z3423 = Nothing
            End If

            If getColumIndex(spr, "FactOrderNo") > -1 Then z3423.FactOrderNo = getDataM(spr, getColumIndex(spr, "FactOrderNo"), xRow)
            If getColumIndex(spr, "OrderNo") > -1 Then z3423.OrderNo = getDataM(spr, getColumIndex(spr, "OrderNo"), xRow)
            If getColumIndex(spr, "OrderNoSeq") > -1 Then z3423.OrderNoSeq = getDataM(spr, getColumIndex(spr, "OrderNoSeq"), xRow)
            If getColumIndex(spr, "JobCard") > -1 Then z3423.JobCard = getDataM(spr, getColumIndex(spr, "JobCard"), xRow)
            If getColumIndex(spr, "QtyOrder") > -1 Then z3423.QtyOrder = getDataM(spr, getColumIndex(spr, "QtyOrder"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z3423.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3423_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K3423_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3423 As T3423_AREA, Job As String, FACTORDERNO As String, ORDERNO As String, ORDERNOSEQ As String, JOBCARD As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3423_MOVE = False

        Try
            If READ_PFK3423(FACTORDERNO, ORDERNO, ORDERNOSEQ, JOBCARD) = True Then
                z3423 = D3423
                K3423_MOVE = True
            Else
                z3423 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3423")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "FACTORDERNO" : z3423.FactOrderNo = Children(i).Code
                                Case "ORDERNO" : z3423.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z3423.OrderNoSeq = Children(i).Code
                                Case "JOBCARD" : z3423.JobCard = Children(i).Code
                                Case "QTYORDER" : z3423.QtyOrder = Children(i).Code
                                Case "REMARK" : z3423.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "FACTORDERNO" : z3423.FactOrderNo = Children(i).Data
                                Case "ORDERNO" : z3423.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z3423.OrderNoSeq = Children(i).Data
                                Case "JOBCARD" : z3423.JobCard = Children(i).Data
                                Case "QTYORDER" : z3423.QtyOrder = Children(i).Data
                                Case "REMARK" : z3423.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K3423_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K3423_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z3423 As T3423_AREA, Job As String, CheckClear As Boolean, FACTORDERNO As String, ORDERNO As String, ORDERNOSEQ As String, JOBCARD As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K3423_MOVE = False

        Try
            If READ_PFK3423(FACTORDERNO, ORDERNO, ORDERNOSEQ, JOBCARD) = True Then
                z3423 = D3423
		K3423_MOVE = True
		else
	If CheckClear  = True then z3423 = nothing
    End If
   
    newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK3423")
            Children = StartingContainer.FindAllType
     For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
Try
	If Children(i).DataLen <> Job Then
                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                  Select Case temp1
   Case "FACTORDERNO":z3423.FactOrderNo = Children(i).Code
   Case "ORDERNO":z3423.OrderNo = Children(i).Code
   Case "ORDERNOSEQ":z3423.OrderNoSeq = Children(i).Code
   Case "JOBCARD":z3423.JobCard = Children(i).Code
   Case "QTYORDER":z3423.QtyOrder = Children(i).Code
   Case "REMARK":z3423.Remark = Children(i).Code
		  End Select
                Else
                  Select Case temp1
   Case "FACTORDERNO":z3423.FactOrderNo = Children(i).Data
   Case "ORDERNO":z3423.OrderNo = Children(i).Data
   Case "ORDERNOSEQ":z3423.OrderNoSeq = Children(i).Data
   Case "JOBCARD":z3423.JobCard = Children(i).Data
   Case "QTYORDER":z3423.QtyOrder = Children(i).Data
   Case "REMARK":z3423.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K3423_MOVE",vbCritical)
End Try
End Function 
    
End Module 
