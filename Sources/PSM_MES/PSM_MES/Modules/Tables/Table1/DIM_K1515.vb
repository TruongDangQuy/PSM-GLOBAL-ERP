'=========================================================================================================================================================
'   TABLE : (PFK1515)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1515

Structure T1515_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	PaidCode	 AS String	'			char(6)		*
Public 	PaidSeq	 AS String	'			char(3)		*
Public 	OrderNo	 AS String	'			char(9)
Public 	OrderSeq	 AS Double	'			decimal
Public 	AmountReceivedOrderUSD	 AS Double	'			decimal
Public 	AmountReceivedOrderVND	 AS Double	'			decimal
Public 	AmountReceivedTaxExportVND	 AS Double	'			decimal
Public 	AmountReceivedTaxEnvironmentVND	 AS Double	'			decimal
Public 	AmountReceivedTaxVATVND	 AS Double	'			decimal
Public 	CheckDC	 AS String	'			char(1)
Public 	CheckComplete	 AS String	'			char(1)
Public 	Remark	 AS String	'			nvarchar(150)
'=========================================================================================================================================================
End structure

Public D1515 As T1515_AREA  

'=========================================================================================================================================================
' DIRECT READ 
'=========================================================================================================================================================
Public Function READ_PFK1515(PAIDCODE AS String, PAIDSEQ AS String) As Boolean
    READ_PFK1515 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1515 "
    SQL = SQL & " WHERE K1515_PaidCode		 = '" & PaidCode & "' " 
    SQL = SQL & "   AND K1515_PaidSeq		 = '" & PaidSeq & "' " 
    cmd = New SqlClient.SqlCommand(SQL, cn)
    rd = cmd.ExecuteReader
    rd.Read()

    If rd.HasRows = False Then Call D1515_CLEAR: GoTo SKIP_READ_PFK1515
                
    Call K1515_MOVE(rd)
    READ_PFK1515 = True

SKIP_READ_PFK1515:
    rd.Close()
    Exit Function
 Catch ex As Exception
	Call MsgBoxP("READ_PFK1515",vbCritical)
 End Try
End Function

'=========================================================================================================================================================
' DIRECT READ DATASET
'=========================================================================================================================================================
Public Function READ_PFK1515(PAIDCODE AS String, PAIDSEQ AS String, ByRef Con As SqlClient.SqlConnection) As DataSet
    Dim da As New SqlClient.SqlDataAdapter
    Dim dsnew As New DataSet
    Dim SQL As String
Try 
    SQL = " SELECT * FROM PFK1515 "
    SQL = SQL & " WHERE K1515_PaidCode		 = '" & PaidCode & "' " 
    SQL = SQL & "   AND K1515_PaidSeq		 = '" & PaidSeq & "' " 
    da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
    da.Fill(dsnew, "SP")
    Return dsnew

Catch ex As Exception
	Call MsgBoxP("READ_PFK1515",vbCritical)
    Return Nothing
Finally
    da = Nothing
    dsnew = Nothing
End Try
End Function

'=========================================================================================================================================================
' DATA WRITE 
'=========================================================================================================================================================
Public Function WRITE_PFK1515(z1515 As T1515_AREA) As Boolean
    WRITE_PFK1515 = False

    Dim cmd As SqlClient.SqlCommand
    Dim SQL As String
Try    
    Call NULL_ZERO(z1515)
 
    SQL = " INSERT INTO PFK1515 "
    SQL = SQL & " ( "
    SQL = SQL & " K1515_PaidCode," 
    SQL = SQL & " K1515_PaidSeq," 
    SQL = SQL & " K1515_OrderNo," 
    SQL = SQL & " K1515_OrderSeq," 
    SQL = SQL & " K1515_AmountReceivedOrderUSD," 
    SQL = SQL & " K1515_AmountReceivedOrderVND," 
    SQL = SQL & " K1515_AmountReceivedTaxExportVND," 
    SQL = SQL & " K1515_AmountReceivedTaxEnvironmentVND," 
    SQL = SQL & " K1515_AmountReceivedTaxVATVND," 
    SQL = SQL & " K1515_CheckDC," 
    SQL = SQL & " K1515_CheckComplete," 
    SQL = SQL & " K1515_Remark " 
    SQL = SQL & " ) VALUES ( "
    SQL = SQL & "  N'" & z1515.PaidCode & "', "  
    SQL = SQL & "  N'" & z1515.PaidSeq & "', "  
    SQL = SQL & "  N'" & z1515.OrderNo & "', "  
    SQL = SQL & "   " & z1515.OrderSeq & ", "  
    SQL = SQL & "   " & z1515.AmountReceivedOrderUSD & ", "  
    SQL = SQL & "   " & z1515.AmountReceivedOrderVND & ", "  
    SQL = SQL & "   " & z1515.AmountReceivedTaxExportVND & ", "  
            SQL = SQL & "   " & z1515.AmountReceivedTaxEnvironmentVND & ", "
            SQL = SQL & "   " & z1515.AmountReceivedTaxVATVND & ", "
            SQL = SQL & "  N'" & z1515.CheckDC & "', "
            SQL = SQL & "  N'" & z1515.CheckComplete & "', "
            SQL = SQL & "  N'" & z1515.Remark & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK1515 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK1515", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK1515(z1515 As T1515_AREA) As Boolean
        REWRITE_PFK1515 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z1515)

            SQL = " UPDATE PFK1515 SET "
            SQL = SQL & "    K1515_OrderNo      = N'" & z1515.OrderNo & "', "
            SQL = SQL & "    K1515_OrderSeq      =  " & z1515.OrderSeq & ", "
            SQL = SQL & "    K1515_AmountReceivedOrderUSD      =  " & z1515.AmountReceivedOrderUSD & ", "
            SQL = SQL & "    K1515_AmountReceivedOrderVND      =  " & z1515.AmountReceivedOrderVND & ", "
            SQL = SQL & "    K1515_AmountReceivedTaxExportVND      =  " & z1515.AmountReceivedTaxExportVND & ", "
            SQL = SQL & "    K1515_AmountReceivedTaxEnvironmentVND      =  " & z1515.AmountReceivedTaxEnvironmentVND & ", "
            SQL = SQL & "    K1515_AmountReceivedTaxVATVND      =  " & z1515.AmountReceivedTaxVATVND & ", "
            SQL = SQL & "    K1515_CheckDC      = N'" & z1515.CheckDC & "', "
            SQL = SQL & "    K1515_CheckComplete      = N'" & z1515.CheckComplete & "', "
            SQL = SQL & "    K1515_Remark      = N'" & z1515.Remark & "'  "
            SQL = SQL & " WHERE K1515_PaidCode		 = '" & z1515.PaidCode & "' "
            SQL = SQL & "   AND K1515_PaidSeq		 = '" & z1515.PaidSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK1515 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK1515", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK1515(z1515 As T1515_AREA) As Boolean
        DELETE_PFK1515 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK1515 "
            SQL = SQL & " WHERE K1515_PaidCode		 = '" & z1515.PaidCode & "' "
            SQL = SQL & "   AND K1515_PaidSeq		 = '" & z1515.PaidSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK1515 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK1515", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D1515_CLEAR()
        Try

            D1515.PaidCode = ""
            D1515.PaidSeq = ""
            D1515.OrderNo = ""
            D1515.OrderSeq = 0
            D1515.AmountReceivedOrderUSD = 0
            D1515.AmountReceivedOrderVND = 0
            D1515.AmountReceivedTaxExportVND = 0
            D1515.AmountReceivedTaxEnvironmentVND = 0
            D1515.AmountReceivedTaxVATVND = 0
            D1515.CheckDC = ""
            D1515.CheckComplete = ""
            D1515.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D1515_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x1515 As T1515_AREA)
        Try

            x1515.PaidCode = trim$(x1515.PaidCode)
            x1515.PaidSeq = trim$(x1515.PaidSeq)
            x1515.OrderNo = trim$(x1515.OrderNo)
            x1515.OrderSeq = trim$(x1515.OrderSeq)
            x1515.AmountReceivedOrderUSD = trim$(x1515.AmountReceivedOrderUSD)
            x1515.AmountReceivedOrderVND = trim$(x1515.AmountReceivedOrderVND)
            x1515.AmountReceivedTaxExportVND = trim$(x1515.AmountReceivedTaxExportVND)
            x1515.AmountReceivedTaxEnvironmentVND = trim$(x1515.AmountReceivedTaxEnvironmentVND)
            x1515.AmountReceivedTaxVATVND = trim$(x1515.AmountReceivedTaxVATVND)
            x1515.CheckDC = trim$(x1515.CheckDC)
            x1515.CheckComplete = trim$(x1515.CheckComplete)
            x1515.Remark = trim$(x1515.Remark)

            If trim$(x1515.PaidCode) = "" Then x1515.PaidCode = Space(1)
            If trim$(x1515.PaidSeq) = "" Then x1515.PaidSeq = Space(1)
            If trim$(x1515.OrderNo) = "" Then x1515.OrderNo = Space(1)
            If trim$(x1515.OrderSeq) = "" Then x1515.OrderSeq = 0
            If trim$(x1515.AmountReceivedOrderUSD) = "" Then x1515.AmountReceivedOrderUSD = 0
            If trim$(x1515.AmountReceivedOrderVND) = "" Then x1515.AmountReceivedOrderVND = 0
            If trim$(x1515.AmountReceivedTaxExportVND) = "" Then x1515.AmountReceivedTaxExportVND = 0
            If trim$(x1515.AmountReceivedTaxEnvironmentVND) = "" Then x1515.AmountReceivedTaxEnvironmentVND = 0
            If trim$(x1515.AmountReceivedTaxVATVND) = "" Then x1515.AmountReceivedTaxVATVND = 0
            If trim$(x1515.CheckDC) = "" Then x1515.CheckDC = Space(1)
            If trim$(x1515.CheckComplete) = "" Then x1515.CheckComplete = Space(1)
            If trim$(x1515.Remark) = "" Then x1515.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K1515_MOVE(rs1515 As SqlClient.SqlDataReader)
        Try

            Call D1515_CLEAR()

            If IsdbNull(rs1515!K1515_PaidCode) = False Then D1515.PaidCode = Trim$(rs1515!K1515_PaidCode)
            If IsdbNull(rs1515!K1515_PaidSeq) = False Then D1515.PaidSeq = Trim$(rs1515!K1515_PaidSeq)
            If IsdbNull(rs1515!K1515_OrderNo) = False Then D1515.OrderNo = Trim$(rs1515!K1515_OrderNo)
            If IsdbNull(rs1515!K1515_OrderSeq) = False Then D1515.OrderSeq = Trim$(rs1515!K1515_OrderSeq)
            If IsdbNull(rs1515!K1515_AmountReceivedOrderUSD) = False Then D1515.AmountReceivedOrderUSD = Trim$(rs1515!K1515_AmountReceivedOrderUSD)
            If IsdbNull(rs1515!K1515_AmountReceivedOrderVND) = False Then D1515.AmountReceivedOrderVND = Trim$(rs1515!K1515_AmountReceivedOrderVND)
            If IsdbNull(rs1515!K1515_AmountReceivedTaxExportVND) = False Then D1515.AmountReceivedTaxExportVND = Trim$(rs1515!K1515_AmountReceivedTaxExportVND)
            If IsdbNull(rs1515!K1515_AmountReceivedTaxEnvironmentVN) = False Then D1515.AmountReceivedTaxEnvironmentVND = Trim$(rs1515!K1515_AmountReceivedTaxEnvironmentVN)
            If IsdbNull(rs1515!K1515_AmountReceivedTaxVATVND) = False Then D1515.AmountReceivedTaxVATVND = Trim$(rs1515!K1515_AmountReceivedTaxVATVND)
            If IsdbNull(rs1515!K1515_CheckDC) = False Then D1515.CheckDC = Trim$(rs1515!K1515_CheckDC)
            If IsdbNull(rs1515!K1515_CheckComplete) = False Then D1515.CheckComplete = Trim$(rs1515!K1515_CheckComplete)
            If IsdbNull(rs1515!K1515_Remark) = False Then D1515.Remark = Trim$(rs1515!K1515_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K1515_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K1515_MOVE(rs1515 As DataRow)
        Try

            Call D1515_CLEAR()

            If IsdbNull(rs1515!K1515_PaidCode) = False Then D1515.PaidCode = Trim$(rs1515!K1515_PaidCode)
            If IsdbNull(rs1515!K1515_PaidSeq) = False Then D1515.PaidSeq = Trim$(rs1515!K1515_PaidSeq)
            If IsdbNull(rs1515!K1515_OrderNo) = False Then D1515.OrderNo = Trim$(rs1515!K1515_OrderNo)
            If IsdbNull(rs1515!K1515_OrderSeq) = False Then D1515.OrderSeq = Trim$(rs1515!K1515_OrderSeq)
            If IsdbNull(rs1515!K1515_AmountReceivedOrderUSD) = False Then D1515.AmountReceivedOrderUSD = Trim$(rs1515!K1515_AmountReceivedOrderUSD)
            If IsdbNull(rs1515!K1515_AmountReceivedOrderVND) = False Then D1515.AmountReceivedOrderVND = Trim$(rs1515!K1515_AmountReceivedOrderVND)
            If IsdbNull(rs1515!K1515_AmountReceivedTaxExportVND) = False Then D1515.AmountReceivedTaxExportVND = Trim$(rs1515!K1515_AmountReceivedTaxExportVND)
            If IsdbNull(rs1515!K1515_AmountReceivedTaxEnvironmentVN) = False Then D1515.AmountReceivedTaxEnvironmentVND = Trim$(rs1515!K1515_AmountReceivedTaxEnvironmentVN)
            If IsdbNull(rs1515!K1515_AmountReceivedTaxVATVND) = False Then D1515.AmountReceivedTaxVATVND = Trim$(rs1515!K1515_AmountReceivedTaxVATVND)
            If IsdbNull(rs1515!K1515_CheckDC) = False Then D1515.CheckDC = Trim$(rs1515!K1515_CheckDC)
            If IsdbNull(rs1515!K1515_CheckComplete) = False Then D1515.CheckComplete = Trim$(rs1515!K1515_CheckComplete)
            If IsdbNull(rs1515!K1515_Remark) = False Then D1515.Remark = Trim$(rs1515!K1515_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K1515_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K1515_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z1515 As T1515_AREA, PAIDCODE As String, PAIDSEQ As String) As Boolean

        K1515_MOVE = False

        Try
            If READ_PFK1515(PAIDCODE, PAIDSEQ) = True Then
                z1515 = D1515
                K1515_MOVE = True
            Else
                z1515 = Nothing
            End If

            If getColumIndex(spr, "PaidCode") > -1 Then z1515.PaidCode = getDataM(spr, getColumIndex(spr, "PaidCode"), xRow)
            If getColumIndex(spr, "PaidSeq") > -1 Then z1515.PaidSeq = getDataM(spr, getColumIndex(spr, "PaidSeq"), xRow)
            If getColumIndex(spr, "OrderNo") > -1 Then z1515.OrderNo = getDataM(spr, getColumIndex(spr, "OrderNo"), xRow)
            If getColumIndex(spr, "OrderSeq") > -1 Then z1515.OrderSeq = getDataM(spr, getColumIndex(spr, "OrderSeq"), xRow)
            If getColumIndex(spr, "AmountReceivedOrderUSD") > -1 Then z1515.AmountReceivedOrderUSD = getDataM(spr, getColumIndex(spr, "AmountReceivedOrderUSD"), xRow)
            If getColumIndex(spr, "AmountReceivedOrderVND") > -1 Then z1515.AmountReceivedOrderVND = getDataM(spr, getColumIndex(spr, "AmountReceivedOrderVND"), xRow)
            If getColumIndex(spr, "AmountReceivedTaxExportVND") > -1 Then z1515.AmountReceivedTaxExportVND = getDataM(spr, getColumIndex(spr, "AmountReceivedTaxExportVND"), xRow)
            If getColumIndex(spr, "AmountReceivedTaxEnvironmentVND") > -1 Then z1515.AmountReceivedTaxEnvironmentVND = getDataM(spr, getColumIndex(spr, "AmountReceivedTaxEnvironmentVND"), xRow)
            If getColumIndex(spr, "AmountReceivedTaxVATVND") > -1 Then z1515.AmountReceivedTaxVATVND = getDataM(spr, getColumIndex(spr, "AmountReceivedTaxVATVND"), xRow)
            If getColumIndex(spr, "CheckDC") > -1 Then z1515.CheckDC = getDataM(spr, getColumIndex(spr, "CheckDC"), xRow)
            If getColumIndex(spr, "CheckComplete") > -1 Then z1515.CheckComplete = getDataM(spr, getColumIndex(spr, "CheckComplete"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z1515.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1515_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K1515_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z1515 As T1515_AREA, Job As String, PAIDCODE As String, PAIDSEQ As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K1515_MOVE = False

        Try
            If READ_PFK1515(PAIDCODE, PAIDSEQ) = True Then
                z1515 = D1515
                K1515_MOVE = True
            Else
                z1515 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1515")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "PaidCode" : z1515.PaidCode = Children(i).Code
                                Case "PaidSeq" : z1515.PaidSeq = Children(i).Code
                                Case "OrderNo" : z1515.OrderNo = Children(i).Code
                                Case "OrderSeq" : z1515.OrderSeq = Children(i).Code
                                Case "AmountReceivedOrderUSD" : z1515.AmountReceivedOrderUSD = Children(i).Code
                                Case "AmountReceivedOrderVND" : z1515.AmountReceivedOrderVND = Children(i).Code
                                Case "AmountReceivedTaxExportVND" : z1515.AmountReceivedTaxExportVND = Children(i).Code
                                Case "AmountReceivedTaxEnvironmentVND" : z1515.AmountReceivedTaxEnvironmentVND = Children(i).Code
                                Case "AmountReceivedTaxVATVND" : z1515.AmountReceivedTaxVATVND = Children(i).Code
                                Case "CheckDC" : z1515.CheckDC = Children(i).Code
                                Case "CheckComplete" : z1515.CheckComplete = Children(i).Code
                                Case "Remark" : z1515.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "PaidCode" : z1515.PaidCode = Children(i).Data
                                Case "PaidSeq" : z1515.PaidSeq = Children(i).Data
                                Case "OrderNo" : z1515.OrderNo = Children(i).Data
                                Case "OrderSeq" : z1515.OrderSeq = Children(i).Data
                                Case "AmountReceivedOrderUSD" : z1515.AmountReceivedOrderUSD = Children(i).Data
                                Case "AmountReceivedOrderVND" : z1515.AmountReceivedOrderVND = Children(i).Data
                                Case "AmountReceivedTaxExportVND" : z1515.AmountReceivedTaxExportVND = Children(i).Data
                                Case "AmountReceivedTaxEnvironmentVND" : z1515.AmountReceivedTaxEnvironmentVND = Children(i).Data
                                Case "AmountReceivedTaxVATVND" : z1515.AmountReceivedTaxVATVND = Children(i).Data
                                Case "CheckDC" : z1515.CheckDC = Children(i).Data
                                Case "CheckComplete" : z1515.CheckComplete = Children(i).Data
                                Case "Remark" : z1515.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1515_MOVE", vbCritical)
        End Try
    End Function
    
End Module 
