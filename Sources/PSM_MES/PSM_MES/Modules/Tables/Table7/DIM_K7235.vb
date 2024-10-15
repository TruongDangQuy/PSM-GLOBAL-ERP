'=========================================================================================================================================================
'   TABLE : (PFK7235)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7235

    Structure T7235_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public Autokey As Double  '			decimal		*
        Public ExchangeName As String  '			nvarchar(50)
        Public QtyBasicExchange As Double  '			decimal
        Public Width As String  '			nvarchar(50)
        Public Height As String  '			nvarchar(50)
        Public SizeName As String  '			nvarchar(50)
        Public seUnitMaterial As String  '			char(3)
        Public cdUnitMaterial As String  '			char(3)
        Public Remark As String  '			nvarchar(100)
        '=========================================================================================================================================================
    End Structure

    Public D7235 As T7235_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK7235(AUTOKEY As Double) As Boolean
        READ_PFK7235 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7235 "
            SQL = SQL & " WHERE K7235_Autokey		 =  " & Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7235_CLEAR() : GoTo SKIP_READ_PFK7235

            Call K7235_MOVE(rd)
            READ_PFK7235 = True

SKIP_READ_PFK7235:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7235", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK7235(AUTOKEY As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7235 "
            SQL = SQL & " WHERE K7235_Autokey		 =  " & Autokey & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK7235", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK7235(z7235 As T7235_AREA) As Boolean
        WRITE_PFK7235 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7235)

            SQL = " INSERT INTO PFK7235 "
            SQL = SQL & " ( "
            SQL = SQL & " K7235_ExchangeName,"
            SQL = SQL & " K7235_QtyBasicExchange,"
            SQL = SQL & " K7235_Width,"
            SQL = SQL & " K7235_Height,"
            SQL = SQL & " K7235_SizeName,"
            SQL = SQL & " K7235_seUnitMaterial,"
            SQL = SQL & " K7235_cdUnitMaterial,"
            SQL = SQL & " K7235_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z7235.ExchangeName) & "', "
            SQL = SQL & "   " & FormatSQL(z7235.QtyBasicExchange) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7235.Width) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7235.Height) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7235.SizeName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7235.seUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7235.cdUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7235.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK7235 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK7235", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK7235(z7235 As T7235_AREA) As Boolean
        REWRITE_PFK7235 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7235)

            SQL = " UPDATE PFK7235 SET "
            SQL = SQL & "    K7235_ExchangeName      = N'" & FormatSQL(z7235.ExchangeName) & "', "
            SQL = SQL & "    K7235_QtyBasicExchange      =  " & FormatSQL(z7235.QtyBasicExchange) & ", "
            SQL = SQL & "    K7235_Width      = N'" & FormatSQL(z7235.Width) & "', "
            SQL = SQL & "    K7235_Height      = N'" & FormatSQL(z7235.Height) & "', "
            SQL = SQL & "    K7235_SizeName      = N'" & FormatSQL(z7235.SizeName) & "', "
            SQL = SQL & "    K7235_seUnitMaterial      = N'" & FormatSQL(z7235.seUnitMaterial) & "', "
            SQL = SQL & "    K7235_cdUnitMaterial      = N'" & FormatSQL(z7235.cdUnitMaterial) & "', "
            SQL = SQL & "    K7235_Remark      = N'" & FormatSQL(z7235.Remark) & "'  "
            SQL = SQL & " WHERE K7235_Autokey		 =  " & z7235.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK7235 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK7235", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK7235(z7235 As T7235_AREA) As Boolean
        DELETE_PFK7235 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK7235 "
            SQL = SQL & " WHERE K7235_Autokey		 =  " & z7235.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7235 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7235", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D7235_CLEAR()
        Try

            D7235.Autokey = 0
            D7235.ExchangeName = ""
            D7235.QtyBasicExchange = 0
            D7235.Width = ""
            D7235.Height = ""
            D7235.SizeName = ""
            D7235.seUnitMaterial = ""
            D7235.cdUnitMaterial = ""
            D7235.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D7235_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x7235 As T7235_AREA)
        Try

            x7235.Autokey = trim$(x7235.Autokey)
            x7235.ExchangeName = trim$(x7235.ExchangeName)
            x7235.QtyBasicExchange = trim$(x7235.QtyBasicExchange)
            x7235.Width = trim$(x7235.Width)
            x7235.Height = trim$(x7235.Height)
            x7235.SizeName = trim$(x7235.SizeName)
            x7235.seUnitMaterial = trim$(x7235.seUnitMaterial)
            x7235.cdUnitMaterial = trim$(x7235.cdUnitMaterial)
            x7235.Remark = trim$(x7235.Remark)

            If trim$(x7235.Autokey) = "" Then x7235.Autokey = 0
            If trim$(x7235.ExchangeName) = "" Then x7235.ExchangeName = Space(1)
            If trim$(x7235.QtyBasicExchange) = "" Then x7235.QtyBasicExchange = 0
            If trim$(x7235.Width) = "" Then x7235.Width = Space(1)
            If trim$(x7235.Height) = "" Then x7235.Height = Space(1)
            If trim$(x7235.SizeName) = "" Then x7235.SizeName = Space(1)
            If trim$(x7235.seUnitMaterial) = "" Then x7235.seUnitMaterial = Space(1)
            If trim$(x7235.cdUnitMaterial) = "" Then x7235.cdUnitMaterial = Space(1)
            If trim$(x7235.Remark) = "" Then x7235.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K7235_MOVE(rs7235 As SqlClient.SqlDataReader)
        Try

            Call D7235_CLEAR()

            If IsdbNull(rs7235!K7235_Autokey) = False Then D7235.Autokey = Trim$(rs7235!K7235_Autokey)
            If IsdbNull(rs7235!K7235_ExchangeName) = False Then D7235.ExchangeName = Trim$(rs7235!K7235_ExchangeName)
            If IsdbNull(rs7235!K7235_QtyBasicExchange) = False Then D7235.QtyBasicExchange = Trim$(rs7235!K7235_QtyBasicExchange)
            If IsdbNull(rs7235!K7235_Width) = False Then D7235.Width = Trim$(rs7235!K7235_Width)
            If IsdbNull(rs7235!K7235_Height) = False Then D7235.Height = Trim$(rs7235!K7235_Height)
            If IsdbNull(rs7235!K7235_SizeName) = False Then D7235.SizeName = Trim$(rs7235!K7235_SizeName)
            If IsdbNull(rs7235!K7235_seUnitMaterial) = False Then D7235.seUnitMaterial = Trim$(rs7235!K7235_seUnitMaterial)
            If IsdbNull(rs7235!K7235_cdUnitMaterial) = False Then D7235.cdUnitMaterial = Trim$(rs7235!K7235_cdUnitMaterial)
            If IsdbNull(rs7235!K7235_Remark) = False Then D7235.Remark = Trim$(rs7235!K7235_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7235_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K7235_MOVE(rs7235 As DataRow)
        Try

            Call D7235_CLEAR()

            If IsdbNull(rs7235!K7235_Autokey) = False Then D7235.Autokey = Trim$(rs7235!K7235_Autokey)
            If IsdbNull(rs7235!K7235_ExchangeName) = False Then D7235.ExchangeName = Trim$(rs7235!K7235_ExchangeName)
            If IsdbNull(rs7235!K7235_QtyBasicExchange) = False Then D7235.QtyBasicExchange = Trim$(rs7235!K7235_QtyBasicExchange)
            If IsdbNull(rs7235!K7235_Width) = False Then D7235.Width = Trim$(rs7235!K7235_Width)
            If IsdbNull(rs7235!K7235_Height) = False Then D7235.Height = Trim$(rs7235!K7235_Height)
            If IsdbNull(rs7235!K7235_SizeName) = False Then D7235.SizeName = Trim$(rs7235!K7235_SizeName)
            If IsdbNull(rs7235!K7235_seUnitMaterial) = False Then D7235.seUnitMaterial = Trim$(rs7235!K7235_seUnitMaterial)
            If IsdbNull(rs7235!K7235_cdUnitMaterial) = False Then D7235.cdUnitMaterial = Trim$(rs7235!K7235_cdUnitMaterial)
            If IsdbNull(rs7235!K7235_Remark) = False Then D7235.Remark = Trim$(rs7235!K7235_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7235_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K7235_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7235 As T7235_AREA, AUTOKEY As Double) As Boolean

        K7235_MOVE = False

        Try
            If READ_PFK7235(AUTOKEY) = True Then
                z7235 = D7235
                K7235_MOVE = True
            Else
                z7235 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z7235.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "ExchangeName") > -1 Then z7235.ExchangeName = getDataM(spr, getColumIndex(spr, "ExchangeName"), xRow)
            If getColumIndex(spr, "QtyBasicExchange") > -1 Then z7235.QtyBasicExchange = getDataM(spr, getColumIndex(spr, "QtyBasicExchange"), xRow)
            If getColumIndex(spr, "Width") > -1 Then z7235.Width = getDataM(spr, getColumIndex(spr, "Width"), xRow)
            If getColumIndex(spr, "Height") > -1 Then z7235.Height = getDataM(spr, getColumIndex(spr, "Height"), xRow)
            If getColumIndex(spr, "SizeName") > -1 Then z7235.SizeName = getDataM(spr, getColumIndex(spr, "SizeName"), xRow)
            If getColumIndex(spr, "seUnitMaterial") > -1 Then z7235.seUnitMaterial = getDataM(spr, getColumIndex(spr, "seUnitMaterial"), xRow)
            If getColumIndex(spr, "cdUnitMaterial") > -1 Then z7235.cdUnitMaterial = getDataM(spr, getColumIndex(spr, "cdUnitMaterial"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z7235.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7235_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K7235_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7235 As T7235_AREA, CheckClear As Boolean, AUTOKEY As Double) As Boolean

        K7235_MOVE = False

        Try
            If READ_PFK7235(AUTOKEY) = True Then
                z7235 = D7235
                K7235_MOVE = True
            Else
                If CheckClear = True Then z7235 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z7235.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "ExchangeName") > -1 Then z7235.ExchangeName = getDataM(spr, getColumIndex(spr, "ExchangeName"), xRow)
            If getColumIndex(spr, "QtyBasicExchange") > -1 Then z7235.QtyBasicExchange = getDataM(spr, getColumIndex(spr, "QtyBasicExchange"), xRow)
            If getColumIndex(spr, "Width") > -1 Then z7235.Width = getDataM(spr, getColumIndex(spr, "Width"), xRow)
            If getColumIndex(spr, "Height") > -1 Then z7235.Height = getDataM(spr, getColumIndex(spr, "Height"), xRow)
            If getColumIndex(spr, "SizeName") > -1 Then z7235.SizeName = getDataM(spr, getColumIndex(spr, "SizeName"), xRow)
            If getColumIndex(spr, "seUnitMaterial") > -1 Then z7235.seUnitMaterial = getDataM(spr, getColumIndex(spr, "seUnitMaterial"), xRow)
            If getColumIndex(spr, "cdUnitMaterial") > -1 Then z7235.cdUnitMaterial = getDataM(spr, getColumIndex(spr, "cdUnitMaterial"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z7235.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7235_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K7235_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7235 As T7235_AREA, Job As String, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7235_MOVE = False

        Try
            If READ_PFK7235(AUTOKEY) = True Then
                z7235 = D7235
                K7235_MOVE = True
            Else
                z7235 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7235")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z7235.Autokey = Children(i).Code
                                Case "EXCHANGENAME" : z7235.ExchangeName = Children(i).Code
                                Case "QTYBASICEXCHANGE" : z7235.QtyBasicExchange = Children(i).Code
                                Case "WIDTH" : z7235.Width = Children(i).Code
                                Case "HEIGHT" : z7235.Height = Children(i).Code
                                Case "SIZENAME" : z7235.SizeName = Children(i).Code
                                Case "SEUNITMATERIAL" : z7235.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z7235.cdUnitMaterial = Children(i).Code
                                Case "REMARK" : z7235.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z7235.Autokey = Children(i).Data
                                Case "EXCHANGENAME" : z7235.ExchangeName = Children(i).Data
                                Case "QTYBASICEXCHANGE" : z7235.QtyBasicExchange = Children(i).Data
                                Case "WIDTH" : z7235.Width = Children(i).Data
                                Case "HEIGHT" : z7235.Height = Children(i).Data
                                Case "SIZENAME" : z7235.SizeName = Children(i).Data
                                Case "SEUNITMATERIAL" : z7235.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z7235.cdUnitMaterial = Children(i).Data
                                Case "REMARK" : z7235.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7235_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K7235_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7235 As T7235_AREA, Job As String, CheckClear As Boolean, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7235_MOVE = False

        Try
            If READ_PFK7235(AUTOKEY) = True Then
                z7235 = D7235
                K7235_MOVE = True
            Else
                If CheckClear = True Then z7235 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7235")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z7235.Autokey = Children(i).Code
                                Case "EXCHANGENAME" : z7235.ExchangeName = Children(i).Code
                                Case "QTYBASICEXCHANGE" : z7235.QtyBasicExchange = Children(i).Code
                                Case "WIDTH" : z7235.Width = Children(i).Code
                                Case "HEIGHT" : z7235.Height = Children(i).Code
                                Case "SIZENAME" : z7235.SizeName = Children(i).Code
                                Case "SEUNITMATERIAL" : z7235.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z7235.cdUnitMaterial = Children(i).Code
                                Case "REMARK" : z7235.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z7235.Autokey = Children(i).Data
                                Case "EXCHANGENAME" : z7235.ExchangeName = Children(i).Data
                                Case "QTYBASICEXCHANGE" : z7235.QtyBasicExchange = Children(i).Data
                                Case "WIDTH" : z7235.Width = Children(i).Data
                                Case "HEIGHT" : z7235.Height = Children(i).Data
                                Case "SIZENAME" : z7235.SizeName = Children(i).Data
                                Case "SEUNITMATERIAL" : z7235.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z7235.cdUnitMaterial = Children(i).Data
                                Case "REMARK" : z7235.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7235_MOVE", vbCritical)
        End Try
    End Function

End Module
