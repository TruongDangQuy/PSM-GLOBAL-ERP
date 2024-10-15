'=========================================================================================================================================================
'   TABLE : (PFK1360)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K1360

    Structure T1360_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public Autokey As Double  '			decimal		*
        Public OrderNo As String  '			char(9)
        Public OrderNoSeq As String  '			char(3)
        Public DateFitting As String  '			char(8)
        Public InchargeFitting As String  '			char(8)
        Public CheckFitting As String  '			char(1)
        Public DateTesting As String  '			char(8)
        Public InchargeTesting As String  '			char(8)
        Public CheckTesting As String  '			char(1)
        Public DateInsert As String  '			char(8)
        Public DateUpdate As String  '			char(8)
        Public InchargeInsert As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        Public Remark As String  '			nvarchar(100)
        '=========================================================================================================================================================
    End Structure

    Public D1360 As T1360_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK1360(AUTOKEY As Double) As Boolean
        READ_PFK1360 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1360 "
            SQL = SQL & " WHERE K1360_Autokey		 =  " & Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D1360_CLEAR() : GoTo SKIP_READ_PFK1360

            Call K1360_MOVE(rd)
            READ_PFK1360 = True

SKIP_READ_PFK1360:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK1360", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK1360(AUTOKEY As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK1360 "
            SQL = SQL & " WHERE K1360_Autokey		 =  " & Autokey & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK1360", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK1360(z1360 As T1360_AREA) As Boolean
        WRITE_PFK1360 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z1360)

            SQL = " INSERT INTO PFK1360 "
            SQL = SQL & " ( "
            SQL = SQL & " K1360_OrderNo,"
            SQL = SQL & " K1360_OrderNoSeq,"
            SQL = SQL & " K1360_DateFitting,"
            SQL = SQL & " K1360_InchargeFitting,"
            SQL = SQL & " K1360_CheckFitting,"
            SQL = SQL & " K1360_DateTesting,"
            SQL = SQL & " K1360_InchargeTesting,"
            SQL = SQL & " K1360_CheckTesting,"
            SQL = SQL & " K1360_DateInsert,"
            SQL = SQL & " K1360_DateUpdate,"
            SQL = SQL & " K1360_InchargeInsert,"
            SQL = SQL & " K1360_InchargeUpdate,"
            SQL = SQL & " K1360_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z1360.OrderNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1360.OrderNoSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1360.DateFitting) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1360.InchargeFitting) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1360.CheckFitting) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1360.DateTesting) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1360.InchargeTesting) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1360.CheckTesting) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1360.DateInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1360.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1360.InchargeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1360.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z1360.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK1360 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK1360", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK1360(z1360 As T1360_AREA) As Boolean
        REWRITE_PFK1360 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z1360)

            SQL = " UPDATE PFK1360 SET "
            SQL = SQL & "    K1360_OrderNo      = N'" & FormatSQL(z1360.OrderNo) & "', "
            SQL = SQL & "    K1360_OrderNoSeq      = N'" & FormatSQL(z1360.OrderNoSeq) & "', "
            SQL = SQL & "    K1360_DateFitting      = N'" & FormatSQL(z1360.DateFitting) & "', "
            SQL = SQL & "    K1360_InchargeFitting      = N'" & FormatSQL(z1360.InchargeFitting) & "', "
            SQL = SQL & "    K1360_CheckFitting      = N'" & FormatSQL(z1360.CheckFitting) & "', "
            SQL = SQL & "    K1360_DateTesting      = N'" & FormatSQL(z1360.DateTesting) & "', "
            SQL = SQL & "    K1360_InchargeTesting      = N'" & FormatSQL(z1360.InchargeTesting) & "', "
            SQL = SQL & "    K1360_CheckTesting      = N'" & FormatSQL(z1360.CheckTesting) & "', "
            SQL = SQL & "    K1360_DateInsert      = N'" & FormatSQL(z1360.DateInsert) & "', "
            SQL = SQL & "    K1360_DateUpdate      = N'" & FormatSQL(z1360.DateUpdate) & "', "
            SQL = SQL & "    K1360_InchargeInsert      = N'" & FormatSQL(z1360.InchargeInsert) & "', "
            SQL = SQL & "    K1360_InchargeUpdate      = N'" & FormatSQL(z1360.InchargeUpdate) & "', "
            SQL = SQL & "    K1360_Remark      = N'" & FormatSQL(z1360.Remark) & "'  "
            SQL = SQL & " WHERE K1360_Autokey		 =  " & z1360.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK1360 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK1360", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK1360(z1360 As T1360_AREA) As Boolean
        DELETE_PFK1360 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK1360 "
            SQL = SQL & " WHERE K1360_Autokey		 =  " & z1360.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK1360 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK1360", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D1360_CLEAR()
        Try

            D1360.Autokey = 0
            D1360.OrderNo = ""
            D1360.OrderNoSeq = ""
            D1360.DateFitting = ""
            D1360.InchargeFitting = ""
            D1360.CheckFitting = ""
            D1360.DateTesting = ""
            D1360.InchargeTesting = ""
            D1360.CheckTesting = ""
            D1360.DateInsert = ""
            D1360.DateUpdate = ""
            D1360.InchargeInsert = ""
            D1360.InchargeUpdate = ""
            D1360.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D1360_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x1360 As T1360_AREA)
        Try

            x1360.Autokey = trim$(x1360.Autokey)
            x1360.OrderNo = trim$(x1360.OrderNo)
            x1360.OrderNoSeq = trim$(x1360.OrderNoSeq)
            x1360.DateFitting = trim$(x1360.DateFitting)
            x1360.InchargeFitting = trim$(x1360.InchargeFitting)
            x1360.CheckFitting = trim$(x1360.CheckFitting)
            x1360.DateTesting = trim$(x1360.DateTesting)
            x1360.InchargeTesting = trim$(x1360.InchargeTesting)
            x1360.CheckTesting = trim$(x1360.CheckTesting)
            x1360.DateInsert = trim$(x1360.DateInsert)
            x1360.DateUpdate = trim$(x1360.DateUpdate)
            x1360.InchargeInsert = trim$(x1360.InchargeInsert)
            x1360.InchargeUpdate = trim$(x1360.InchargeUpdate)
            x1360.Remark = trim$(x1360.Remark)

            If trim$(x1360.Autokey) = "" Then x1360.Autokey = 0
            If trim$(x1360.OrderNo) = "" Then x1360.OrderNo = Space(1)
            If trim$(x1360.OrderNoSeq) = "" Then x1360.OrderNoSeq = Space(1)
            If trim$(x1360.DateFitting) = "" Then x1360.DateFitting = Space(1)
            If trim$(x1360.InchargeFitting) = "" Then x1360.InchargeFitting = Space(1)
            If trim$(x1360.CheckFitting) = "" Then x1360.CheckFitting = Space(1)
            If trim$(x1360.DateTesting) = "" Then x1360.DateTesting = Space(1)
            If trim$(x1360.InchargeTesting) = "" Then x1360.InchargeTesting = Space(1)
            If trim$(x1360.CheckTesting) = "" Then x1360.CheckTesting = Space(1)
            If trim$(x1360.DateInsert) = "" Then x1360.DateInsert = Space(1)
            If trim$(x1360.DateUpdate) = "" Then x1360.DateUpdate = Space(1)
            If trim$(x1360.InchargeInsert) = "" Then x1360.InchargeInsert = Space(1)
            If trim$(x1360.InchargeUpdate) = "" Then x1360.InchargeUpdate = Space(1)
            If trim$(x1360.Remark) = "" Then x1360.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K1360_MOVE(rs1360 As SqlClient.SqlDataReader)
        Try

            Call D1360_CLEAR()

            If IsdbNull(rs1360!K1360_Autokey) = False Then D1360.Autokey = Trim$(rs1360!K1360_Autokey)
            If IsdbNull(rs1360!K1360_OrderNo) = False Then D1360.OrderNo = Trim$(rs1360!K1360_OrderNo)
            If IsdbNull(rs1360!K1360_OrderNoSeq) = False Then D1360.OrderNoSeq = Trim$(rs1360!K1360_OrderNoSeq)
            If IsdbNull(rs1360!K1360_DateFitting) = False Then D1360.DateFitting = Trim$(rs1360!K1360_DateFitting)
            If IsdbNull(rs1360!K1360_InchargeFitting) = False Then D1360.InchargeFitting = Trim$(rs1360!K1360_InchargeFitting)
            If IsdbNull(rs1360!K1360_CheckFitting) = False Then D1360.CheckFitting = Trim$(rs1360!K1360_CheckFitting)
            If IsdbNull(rs1360!K1360_DateTesting) = False Then D1360.DateTesting = Trim$(rs1360!K1360_DateTesting)
            If IsdbNull(rs1360!K1360_InchargeTesting) = False Then D1360.InchargeTesting = Trim$(rs1360!K1360_InchargeTesting)
            If IsdbNull(rs1360!K1360_CheckTesting) = False Then D1360.CheckTesting = Trim$(rs1360!K1360_CheckTesting)
            If IsdbNull(rs1360!K1360_DateInsert) = False Then D1360.DateInsert = Trim$(rs1360!K1360_DateInsert)
            If IsdbNull(rs1360!K1360_DateUpdate) = False Then D1360.DateUpdate = Trim$(rs1360!K1360_DateUpdate)
            If IsdbNull(rs1360!K1360_InchargeInsert) = False Then D1360.InchargeInsert = Trim$(rs1360!K1360_InchargeInsert)
            If IsdbNull(rs1360!K1360_InchargeUpdate) = False Then D1360.InchargeUpdate = Trim$(rs1360!K1360_InchargeUpdate)
            If IsdbNull(rs1360!K1360_Remark) = False Then D1360.Remark = Trim$(rs1360!K1360_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K1360_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K1360_MOVE(rs1360 As DataRow)
        Try

            Call D1360_CLEAR()

            If IsdbNull(rs1360!K1360_Autokey) = False Then D1360.Autokey = Trim$(rs1360!K1360_Autokey)
            If IsdbNull(rs1360!K1360_OrderNo) = False Then D1360.OrderNo = Trim$(rs1360!K1360_OrderNo)
            If IsdbNull(rs1360!K1360_OrderNoSeq) = False Then D1360.OrderNoSeq = Trim$(rs1360!K1360_OrderNoSeq)
            If IsdbNull(rs1360!K1360_DateFitting) = False Then D1360.DateFitting = Trim$(rs1360!K1360_DateFitting)
            If IsdbNull(rs1360!K1360_InchargeFitting) = False Then D1360.InchargeFitting = Trim$(rs1360!K1360_InchargeFitting)
            If IsdbNull(rs1360!K1360_CheckFitting) = False Then D1360.CheckFitting = Trim$(rs1360!K1360_CheckFitting)
            If IsdbNull(rs1360!K1360_DateTesting) = False Then D1360.DateTesting = Trim$(rs1360!K1360_DateTesting)
            If IsdbNull(rs1360!K1360_InchargeTesting) = False Then D1360.InchargeTesting = Trim$(rs1360!K1360_InchargeTesting)
            If IsdbNull(rs1360!K1360_CheckTesting) = False Then D1360.CheckTesting = Trim$(rs1360!K1360_CheckTesting)
            If IsdbNull(rs1360!K1360_DateInsert) = False Then D1360.DateInsert = Trim$(rs1360!K1360_DateInsert)
            If IsdbNull(rs1360!K1360_DateUpdate) = False Then D1360.DateUpdate = Trim$(rs1360!K1360_DateUpdate)
            If IsdbNull(rs1360!K1360_InchargeInsert) = False Then D1360.InchargeInsert = Trim$(rs1360!K1360_InchargeInsert)
            If IsdbNull(rs1360!K1360_InchargeUpdate) = False Then D1360.InchargeUpdate = Trim$(rs1360!K1360_InchargeUpdate)
            If IsdbNull(rs1360!K1360_Remark) = False Then D1360.Remark = Trim$(rs1360!K1360_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K1360_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K1360_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z1360 As T1360_AREA, AUTOKEY As Double) As Boolean

        K1360_MOVE = False

        Try
            If READ_PFK1360(AUTOKEY) = True Then
                z1360 = D1360
                K1360_MOVE = True
            Else
                z1360 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z1360.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "OrderNo") > -1 Then z1360.OrderNo = getDataM(spr, getColumIndex(spr, "OrderNo"), xRow)
            If getColumIndex(spr, "OrderNoSeq") > -1 Then z1360.OrderNoSeq = getDataM(spr, getColumIndex(spr, "OrderNoSeq"), xRow)
            If getColumIndex(spr, "DateFitting") > -1 Then z1360.DateFitting = getDataM(spr, getColumIndex(spr, "DateFitting"), xRow)
            If getColumIndex(spr, "InchargeFitting") > -1 Then z1360.InchargeFitting = getDataM(spr, getColumIndex(spr, "InchargeFitting"), xRow)
            If getColumIndex(spr, "CheckFitting") > -1 Then z1360.CheckFitting = getDataM(spr, getColumIndex(spr, "CheckFitting"), xRow)
            If getColumIndex(spr, "DateTesting") > -1 Then z1360.DateTesting = getDataM(spr, getColumIndex(spr, "DateTesting"), xRow)
            If getColumIndex(spr, "InchargeTesting") > -1 Then z1360.InchargeTesting = getDataM(spr, getColumIndex(spr, "InchargeTesting"), xRow)
            If getColumIndex(spr, "CheckTesting") > -1 Then z1360.CheckTesting = getDataM(spr, getColumIndex(spr, "CheckTesting"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z1360.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z1360.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z1360.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z1360.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z1360.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1360_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K1360_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z1360 As T1360_AREA, CheckClear As Boolean, AUTOKEY As Double) As Boolean

        K1360_MOVE = False

        Try
            If READ_PFK1360(AUTOKEY) = True Then
                z1360 = D1360
                K1360_MOVE = True
            Else
                If CheckClear = True Then z1360 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z1360.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "OrderNo") > -1 Then z1360.OrderNo = getDataM(spr, getColumIndex(spr, "OrderNo"), xRow)
            If getColumIndex(spr, "OrderNoSeq") > -1 Then z1360.OrderNoSeq = getDataM(spr, getColumIndex(spr, "OrderNoSeq"), xRow)
            If getColumIndex(spr, "DateFitting") > -1 Then z1360.DateFitting = getDataM(spr, getColumIndex(spr, "DateFitting"), xRow)
            If getColumIndex(spr, "InchargeFitting") > -1 Then z1360.InchargeFitting = getDataM(spr, getColumIndex(spr, "InchargeFitting"), xRow)
            If getColumIndex(spr, "CheckFitting") > -1 Then z1360.CheckFitting = getDataM(spr, getColumIndex(spr, "CheckFitting"), xRow)
            If getColumIndex(spr, "DateTesting") > -1 Then z1360.DateTesting = getDataM(spr, getColumIndex(spr, "DateTesting"), xRow)
            If getColumIndex(spr, "InchargeTesting") > -1 Then z1360.InchargeTesting = getDataM(spr, getColumIndex(spr, "InchargeTesting"), xRow)
            If getColumIndex(spr, "CheckTesting") > -1 Then z1360.CheckTesting = getDataM(spr, getColumIndex(spr, "CheckTesting"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z1360.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z1360.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z1360.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z1360.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z1360.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1360_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K1360_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z1360 As T1360_AREA, Job As String, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K1360_MOVE = False

        Try
            If READ_PFK1360(AUTOKEY) = True Then
                z1360 = D1360
                K1360_MOVE = True
            Else
                z1360 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1360")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z1360.Autokey = Children(i).Code
                                Case "ORDERNO" : z1360.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z1360.OrderNoSeq = Children(i).Code
                                Case "DATEFITTING" : z1360.DateFitting = Children(i).Code
                                Case "INCHARGEFITTING" : z1360.InchargeFitting = Children(i).Code
                                Case "CHECKFITTING" : z1360.CheckFitting = Children(i).Code
                                Case "DATETESTING" : z1360.DateTesting = Children(i).Code
                                Case "INCHARGETESTING" : z1360.InchargeTesting = Children(i).Code
                                Case "CHECKTESTING" : z1360.CheckTesting = Children(i).Code
                                Case "DATEINSERT" : z1360.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z1360.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z1360.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z1360.InchargeUpdate = Children(i).Code
                                Case "REMARK" : z1360.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z1360.Autokey = Children(i).Data
                                Case "ORDERNO" : z1360.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z1360.OrderNoSeq = Children(i).Data
                                Case "DATEFITTING" : z1360.DateFitting = Children(i).Data
                                Case "INCHARGEFITTING" : z1360.InchargeFitting = Children(i).Data
                                Case "CHECKFITTING" : z1360.CheckFitting = Children(i).Data
                                Case "DATETESTING" : z1360.DateTesting = Children(i).Data
                                Case "INCHARGETESTING" : z1360.InchargeTesting = Children(i).Data
                                Case "CHECKTESTING" : z1360.CheckTesting = Children(i).Data
                                Case "DATEINSERT" : z1360.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z1360.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z1360.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z1360.InchargeUpdate = Children(i).Data
                                Case "REMARK" : z1360.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1360_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K1360_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z1360 As T1360_AREA, Job As String, CheckClear As Boolean, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K1360_MOVE = False

        Try
            If READ_PFK1360(AUTOKEY) = True Then
                z1360 = D1360
                K1360_MOVE = True
            Else
                If CheckClear = True Then z1360 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK1360")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z1360.Autokey = Children(i).Code
                                Case "ORDERNO" : z1360.OrderNo = Children(i).Code
                                Case "ORDERNOSEQ" : z1360.OrderNoSeq = Children(i).Code
                                Case "DATEFITTING" : z1360.DateFitting = Children(i).Code
                                Case "INCHARGEFITTING" : z1360.InchargeFitting = Children(i).Code
                                Case "CHECKFITTING" : z1360.CheckFitting = Children(i).Code
                                Case "DATETESTING" : z1360.DateTesting = Children(i).Code
                                Case "INCHARGETESTING" : z1360.InchargeTesting = Children(i).Code
                                Case "CHECKTESTING" : z1360.CheckTesting = Children(i).Code
                                Case "DATEINSERT" : z1360.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z1360.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z1360.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z1360.InchargeUpdate = Children(i).Code
                                Case "REMARK" : z1360.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z1360.Autokey = Children(i).Data
                                Case "ORDERNO" : z1360.OrderNo = Children(i).Data
                                Case "ORDERNOSEQ" : z1360.OrderNoSeq = Children(i).Data
                                Case "DATEFITTING" : z1360.DateFitting = Children(i).Data
                                Case "INCHARGEFITTING" : z1360.InchargeFitting = Children(i).Data
                                Case "CHECKFITTING" : z1360.CheckFitting = Children(i).Data
                                Case "DATETESTING" : z1360.DateTesting = Children(i).Data
                                Case "INCHARGETESTING" : z1360.InchargeTesting = Children(i).Data
                                Case "CHECKTESTING" : z1360.CheckTesting = Children(i).Data
                                Case "DATEINSERT" : z1360.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z1360.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z1360.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z1360.InchargeUpdate = Children(i).Data
                                Case "REMARK" : z1360.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K1360_MOVE", vbCritical)
        End Try
    End Function

End Module
