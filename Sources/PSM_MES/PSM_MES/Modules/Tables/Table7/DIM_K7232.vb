'=========================================================================================================================================================
'   TABLE : (PFK7232)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7232

    Structure T7232_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public MaterialCode As String  '			char(6)		*
        Public MaterialCodeSeq As Double  '			decimal		*
        Public Dseq As Double  '			decimal
        Public MaterialCodeBom As String  '			char(6)
        Public Temperature As Double  '			decimal
        Public TimeProduction As Double  '			decimal
        Public Rotations As Double  '			decimal
        Public QtyPrescription As Double  '			decimal
        Public ProductMethodName As String  '			nvarchar(200)
        Public checkUse As String  '			char(1)
        Public Remark As String  '			nvarchar(200)
        '=========================================================================================================================================================
    End Structure

    Public D7232 As T7232_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK7232(MATERIALCODE As String, MATERIALCODESEQ As Double) As Boolean
        READ_PFK7232 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7232 "
            SQL = SQL & " WHERE K7232_MaterialCode		 = '" & MaterialCode & "' "
            SQL = SQL & "   AND K7232_MaterialCodeSeq		 =  " & MaterialCodeSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7232_CLEAR() : GoTo SKIP_READ_PFK7232

            Call K7232_MOVE(rd)
            READ_PFK7232 = True

SKIP_READ_PFK7232:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7232", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK7232(MATERIALCODE As String, MATERIALCODESEQ As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7232 "
            SQL = SQL & " WHERE K7232_MaterialCode		 = '" & MaterialCode & "' "
            SQL = SQL & "   AND K7232_MaterialCodeSeq		 =  " & MaterialCodeSeq & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK7232", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK7232(z7232 As T7232_AREA) As Boolean
        WRITE_PFK7232 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7232)

            SQL = " INSERT INTO PFK7232 "
            SQL = SQL & " ( "
            SQL = SQL & " K7232_MaterialCode,"
            SQL = SQL & " K7232_MaterialCodeSeq,"
            SQL = SQL & " K7232_Dseq,"
            SQL = SQL & " K7232_MaterialCodeBom,"
            SQL = SQL & " K7232_Temperature,"
            SQL = SQL & " K7232_TimeProduction,"
            SQL = SQL & " K7232_Rotations,"
            SQL = SQL & " K7232_QtyPrescription,"
            SQL = SQL & " K7232_ProductMethodName,"
            SQL = SQL & " K7232_checkUse,"
            SQL = SQL & " K7232_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z7232.MaterialCode) & "', "
            SQL = SQL & "   " & FormatSQL(z7232.MaterialCodeSeq) & ", "
            SQL = SQL & "   " & FormatSQL(z7232.Dseq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7232.MaterialCodeBom) & "', "
            SQL = SQL & "   " & FormatSQL(z7232.Temperature) & ", "
            SQL = SQL & "   " & FormatSQL(z7232.TimeProduction) & ", "
            SQL = SQL & "   " & FormatSQL(z7232.Rotations) & ", "
            SQL = SQL & "   " & FormatSQL(z7232.QtyPrescription) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7232.ProductMethodName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7232.checkUse) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7232.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK7232 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK7232", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK7232(z7232 As T7232_AREA) As Boolean
        REWRITE_PFK7232 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7232)

            SQL = " UPDATE PFK7232 SET "
            SQL = SQL & "    K7232_Dseq      =  " & FormatSQL(z7232.Dseq) & ", "
            SQL = SQL & "    K7232_MaterialCodeBom      = N'" & FormatSQL(z7232.MaterialCodeBom) & "', "
            SQL = SQL & "    K7232_Temperature      =  " & FormatSQL(z7232.Temperature) & ", "
            SQL = SQL & "    K7232_TimeProduction      =  " & FormatSQL(z7232.TimeProduction) & ", "
            SQL = SQL & "    K7232_Rotations      =  " & FormatSQL(z7232.Rotations) & ", "
            SQL = SQL & "    K7232_QtyPrescription      =  " & FormatSQL(z7232.QtyPrescription) & ", "
            SQL = SQL & "    K7232_ProductMethodName      = N'" & FormatSQL(z7232.ProductMethodName) & "', "
            SQL = SQL & "    K7232_checkUse      = N'" & FormatSQL(z7232.checkUse) & "', "
            SQL = SQL & "    K7232_Remark      = N'" & FormatSQL(z7232.Remark) & "'  "
            SQL = SQL & " WHERE K7232_MaterialCode		 = '" & z7232.MaterialCode & "' "
            SQL = SQL & "   AND K7232_MaterialCodeSeq		 =  " & z7232.MaterialCodeSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK7232 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK7232", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK7232(z7232 As T7232_AREA) As Boolean
        DELETE_PFK7232 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK7232 "
            SQL = SQL & " WHERE K7232_MaterialCode		 = '" & z7232.MaterialCode & "' "
            SQL = SQL & "   AND K7232_MaterialCodeSeq		 =  " & z7232.MaterialCodeSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7232 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7232", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D7232_CLEAR()
        Try

            D7232.MaterialCode = ""
            D7232.MaterialCodeSeq = 0
            D7232.Dseq = 0
            D7232.MaterialCodeBom = ""
            D7232.Temperature = 0
            D7232.TimeProduction = 0
            D7232.Rotations = 0
            D7232.QtyPrescription = 0
            D7232.ProductMethodName = ""
            D7232.checkUse = ""
            D7232.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D7232_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x7232 As T7232_AREA)
        Try

            x7232.MaterialCode = trim$(x7232.MaterialCode)
            x7232.MaterialCodeSeq = trim$(x7232.MaterialCodeSeq)
            x7232.Dseq = trim$(x7232.Dseq)
            x7232.MaterialCodeBom = trim$(x7232.MaterialCodeBom)
            x7232.Temperature = trim$(x7232.Temperature)
            x7232.TimeProduction = trim$(x7232.TimeProduction)
            x7232.Rotations = trim$(x7232.Rotations)
            x7232.QtyPrescription = trim$(x7232.QtyPrescription)
            x7232.ProductMethodName = trim$(x7232.ProductMethodName)
            x7232.checkUse = trim$(x7232.checkUse)
            x7232.Remark = trim$(x7232.Remark)

            If trim$(x7232.MaterialCode) = "" Then x7232.MaterialCode = Space(1)
            If trim$(x7232.MaterialCodeSeq) = "" Then x7232.MaterialCodeSeq = 0
            If trim$(x7232.Dseq) = "" Then x7232.Dseq = 0
            If trim$(x7232.MaterialCodeBom) = "" Then x7232.MaterialCodeBom = Space(1)
            If trim$(x7232.Temperature) = "" Then x7232.Temperature = 0
            If trim$(x7232.TimeProduction) = "" Then x7232.TimeProduction = 0
            If trim$(x7232.Rotations) = "" Then x7232.Rotations = 0
            If trim$(x7232.QtyPrescription) = "" Then x7232.QtyPrescription = 0
            If trim$(x7232.ProductMethodName) = "" Then x7232.ProductMethodName = Space(1)
            If trim$(x7232.checkUse) = "" Then x7232.checkUse = Space(1)
            If trim$(x7232.Remark) = "" Then x7232.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K7232_MOVE(rs7232 As SqlClient.SqlDataReader)
        Try

            Call D7232_CLEAR()

            If IsdbNull(rs7232!K7232_MaterialCode) = False Then D7232.MaterialCode = Trim$(rs7232!K7232_MaterialCode)
            If IsdbNull(rs7232!K7232_MaterialCodeSeq) = False Then D7232.MaterialCodeSeq = Trim$(rs7232!K7232_MaterialCodeSeq)
            If IsdbNull(rs7232!K7232_Dseq) = False Then D7232.Dseq = Trim$(rs7232!K7232_Dseq)
            If IsdbNull(rs7232!K7232_MaterialCodeBom) = False Then D7232.MaterialCodeBom = Trim$(rs7232!K7232_MaterialCodeBom)
            If IsdbNull(rs7232!K7232_Temperature) = False Then D7232.Temperature = Trim$(rs7232!K7232_Temperature)
            If IsdbNull(rs7232!K7232_TimeProduction) = False Then D7232.TimeProduction = Trim$(rs7232!K7232_TimeProduction)
            If IsdbNull(rs7232!K7232_Rotations) = False Then D7232.Rotations = Trim$(rs7232!K7232_Rotations)
            If IsdbNull(rs7232!K7232_QtyPrescription) = False Then D7232.QtyPrescription = Trim$(rs7232!K7232_QtyPrescription)
            If IsdbNull(rs7232!K7232_ProductMethodName) = False Then D7232.ProductMethodName = Trim$(rs7232!K7232_ProductMethodName)
            If IsdbNull(rs7232!K7232_checkUse) = False Then D7232.checkUse = Trim$(rs7232!K7232_checkUse)
            If IsdbNull(rs7232!K7232_Remark) = False Then D7232.Remark = Trim$(rs7232!K7232_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7232_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K7232_MOVE(rs7232 As DataRow)
        Try

            Call D7232_CLEAR()

            If IsdbNull(rs7232!K7232_MaterialCode) = False Then D7232.MaterialCode = Trim$(rs7232!K7232_MaterialCode)
            If IsdbNull(rs7232!K7232_MaterialCodeSeq) = False Then D7232.MaterialCodeSeq = Trim$(rs7232!K7232_MaterialCodeSeq)
            If IsdbNull(rs7232!K7232_Dseq) = False Then D7232.Dseq = Trim$(rs7232!K7232_Dseq)
            If IsdbNull(rs7232!K7232_MaterialCodeBom) = False Then D7232.MaterialCodeBom = Trim$(rs7232!K7232_MaterialCodeBom)
            If IsdbNull(rs7232!K7232_Temperature) = False Then D7232.Temperature = Trim$(rs7232!K7232_Temperature)
            If IsdbNull(rs7232!K7232_TimeProduction) = False Then D7232.TimeProduction = Trim$(rs7232!K7232_TimeProduction)
            If IsdbNull(rs7232!K7232_Rotations) = False Then D7232.Rotations = Trim$(rs7232!K7232_Rotations)
            If IsdbNull(rs7232!K7232_QtyPrescription) = False Then D7232.QtyPrescription = Trim$(rs7232!K7232_QtyPrescription)
            If IsdbNull(rs7232!K7232_ProductMethodName) = False Then D7232.ProductMethodName = Trim$(rs7232!K7232_ProductMethodName)
            If IsdbNull(rs7232!K7232_checkUse) = False Then D7232.checkUse = Trim$(rs7232!K7232_checkUse)
            If IsdbNull(rs7232!K7232_Remark) = False Then D7232.Remark = Trim$(rs7232!K7232_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7232_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K7232_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7232 As T7232_AREA, MATERIALCODE As String, MATERIALCODESEQ As Double) As Boolean

        K7232_MOVE = False

        Try
            If READ_PFK7232(MATERIALCODE, MATERIALCODESEQ) = True Then
                z7232 = D7232
                K7232_MOVE = True
            Else
                z7232 = Nothing
            End If

            If getColumIndex(spr, "MaterialCode") > -1 Then z7232.MaterialCode = getDataM(spr, getColumIndex(spr, "MaterialCode"), xRow)
            If getColumIndex(spr, "MaterialCodeSeq") > -1 Then z7232.MaterialCodeSeq = getDataM(spr, getColumIndex(spr, "MaterialCodeSeq"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z7232.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "MaterialCodeBom") > -1 Then z7232.MaterialCodeBom = getDataM(spr, getColumIndex(spr, "MaterialCodeBom"), xRow)
            If getColumIndex(spr, "Temperature") > -1 Then z7232.Temperature = getDataM(spr, getColumIndex(spr, "Temperature"), xRow)
            If getColumIndex(spr, "TimeProduction") > -1 Then z7232.TimeProduction = getDataM(spr, getColumIndex(spr, "TimeProduction"), xRow)
            If getColumIndex(spr, "Rotations") > -1 Then z7232.Rotations = getDataM(spr, getColumIndex(spr, "Rotations"), xRow)
            If getColumIndex(spr, "QtyPrescription") > -1 Then z7232.QtyPrescription = getDataM(spr, getColumIndex(spr, "QtyPrescription"), xRow)
            If getColumIndex(spr, "ProductMethodName") > -1 Then z7232.ProductMethodName = getDataM(spr, getColumIndex(spr, "ProductMethodName"), xRow)
            If getColumIndex(spr, "checkUse") > -1 Then z7232.checkUse = getDataM(spr, getColumIndex(spr, "checkUse"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z7232.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7232_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K7232_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7232 As T7232_AREA, CheckClear As Boolean, MATERIALCODE As String, MATERIALCODESEQ As Double) As Boolean

        K7232_MOVE = False

        Try
            If READ_PFK7232(MATERIALCODE, MATERIALCODESEQ) = True Then
                z7232 = D7232
                K7232_MOVE = True
            Else
                If CheckClear = True Then z7232 = Nothing
            End If

            If getColumIndex(spr, "MaterialCode") > -1 Then z7232.MaterialCode = getDataM(spr, getColumIndex(spr, "MaterialCode"), xRow)
            If getColumIndex(spr, "MaterialCodeSeq") > -1 Then z7232.MaterialCodeSeq = getDataM(spr, getColumIndex(spr, "MaterialCodeSeq"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z7232.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "MaterialCodeBom") > -1 Then z7232.MaterialCodeBom = getDataM(spr, getColumIndex(spr, "MaterialCodeBom"), xRow)
            If getColumIndex(spr, "Temperature") > -1 Then z7232.Temperature = getDataM(spr, getColumIndex(spr, "Temperature"), xRow)
            If getColumIndex(spr, "TimeProduction") > -1 Then z7232.TimeProduction = getDataM(spr, getColumIndex(spr, "TimeProduction"), xRow)
            If getColumIndex(spr, "Rotations") > -1 Then z7232.Rotations = getDataM(spr, getColumIndex(spr, "Rotations"), xRow)
            If getColumIndex(spr, "QtyPrescription") > -1 Then z7232.QtyPrescription = getDataM(spr, getColumIndex(spr, "QtyPrescription"), xRow)
            If getColumIndex(spr, "ProductMethodName") > -1 Then z7232.ProductMethodName = getDataM(spr, getColumIndex(spr, "ProductMethodName"), xRow)
            If getColumIndex(spr, "checkUse") > -1 Then z7232.checkUse = getDataM(spr, getColumIndex(spr, "checkUse"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z7232.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7232_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K7232_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7232 As T7232_AREA, Job As String, MATERIALCODE As String, MATERIALCODESEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7232_MOVE = False

        Try
            If READ_PFK7232(MATERIALCODE, MATERIALCODESEQ) = True Then
                z7232 = D7232
                K7232_MOVE = True
            Else
                z7232 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7232")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "MATERIALCODE" : z7232.MaterialCode = Children(i).Code
                                Case "MATERIALCODESEQ" : z7232.MaterialCodeSeq = Children(i).Code
                                Case "DSEQ" : z7232.Dseq = Children(i).Code
                                Case "MATERIALCODEBOM" : z7232.MaterialCodeBom = Children(i).Code
                                Case "TEMPERATURE" : z7232.Temperature = Children(i).Code
                                Case "TIMEPRODUCTION" : z7232.TimeProduction = Children(i).Code
                                Case "ROTATIONS" : z7232.Rotations = Children(i).Code
                                Case "QTYPRESCRIPTION" : z7232.QtyPrescription = Children(i).Code
                                Case "PRODUCTMETHODNAME" : z7232.ProductMethodName = Children(i).Code
                                Case "CHECKUSE" : z7232.checkUse = Children(i).Code
                                Case "REMARK" : z7232.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "MATERIALCODE" : z7232.MaterialCode = Children(i).Data
                                Case "MATERIALCODESEQ" : z7232.MaterialCodeSeq = Children(i).Data
                                Case "DSEQ" : z7232.Dseq = Children(i).Data
                                Case "MATERIALCODEBOM" : z7232.MaterialCodeBom = Children(i).Data
                                Case "TEMPERATURE" : z7232.Temperature = Children(i).Data
                                Case "TIMEPRODUCTION" : z7232.TimeProduction = Children(i).Data
                                Case "ROTATIONS" : z7232.Rotations = Children(i).Data
                                Case "QTYPRESCRIPTION" : z7232.QtyPrescription = Children(i).Data
                                Case "PRODUCTMETHODNAME" : z7232.ProductMethodName = Children(i).Data
                                Case "CHECKUSE" : z7232.checkUse = Children(i).Data
                                Case "REMARK" : z7232.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7232_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K7232_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7232 As T7232_AREA, Job As String, CheckClear As Boolean, MATERIALCODE As String, MATERIALCODESEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7232_MOVE = False

        Try
            If READ_PFK7232(MATERIALCODE, MATERIALCODESEQ) = True Then
                z7232 = D7232
                K7232_MOVE = True
            Else
                If CheckClear = True Then z7232 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7232")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "MATERIALCODE" : z7232.MaterialCode = Children(i).Code
                                Case "MATERIALCODESEQ" : z7232.MaterialCodeSeq = Children(i).Code
                                Case "DSEQ" : z7232.Dseq = Children(i).Code
                                Case "MATERIALCODEBOM" : z7232.MaterialCodeBom = Children(i).Code
                                Case "TEMPERATURE" : z7232.Temperature = Children(i).Code
                                Case "TIMEPRODUCTION" : z7232.TimeProduction = Children(i).Code
                                Case "ROTATIONS" : z7232.Rotations = Children(i).Code
                                Case "QTYPRESCRIPTION" : z7232.QtyPrescription = Children(i).Code
                                Case "PRODUCTMETHODNAME" : z7232.ProductMethodName = Children(i).Code
                                Case "CHECKUSE" : z7232.checkUse = Children(i).Code
                                Case "REMARK" : z7232.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "MATERIALCODE" : z7232.MaterialCode = Children(i).Data
                                Case "MATERIALCODESEQ" : z7232.MaterialCodeSeq = Children(i).Data
                                Case "DSEQ" : z7232.Dseq = Children(i).Data
                                Case "MATERIALCODEBOM" : z7232.MaterialCodeBom = Children(i).Data
                                Case "TEMPERATURE" : z7232.Temperature = Children(i).Data
                                Case "TIMEPRODUCTION" : z7232.TimeProduction = Children(i).Data
                                Case "ROTATIONS" : z7232.Rotations = Children(i).Data
                                Case "QTYPRESCRIPTION" : z7232.QtyPrescription = Children(i).Data
                                Case "PRODUCTMETHODNAME" : z7232.ProductMethodName = Children(i).Data
                                Case "CHECKUSE" : z7232.checkUse = Children(i).Data
                                Case "REMARK" : z7232.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7232_MOVE", vbCritical)
        End Try
    End Function

End Module
