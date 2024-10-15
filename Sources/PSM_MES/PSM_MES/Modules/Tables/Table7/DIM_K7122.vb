'=========================================================================================================================================================
'   TABLE : (PFK7122)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7122

Structure T7122_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	SpecCode	 AS String	'			char(6)		*
Public 	seLargeGroupMaterial	 AS String	'			char(3)
Public 	cdLargeGroupMaterial	 AS String	'			char(3)
Public 	seSemiGroupMaterial	 AS String	'			char(3)
Public 	cdSemiGroupMaterial	 AS String	'			char(3)
Public 	seDetailGroupMaterial	 AS String	'			char(3)
Public 	cdDetailGroupMaterial	 AS String	'			char(3)
        Public CheckUse As String  '			char(1)
        Public DateInsert As String  '			char(8)
        Public DateUpdate As String  '			char(8)
        Public InchargeInsert As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        Public Remark As String  '			nvarchar(100)
        '=========================================================================================================================================================
    End Structure

    Public D7122 As T7122_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK7122(SPECCODE As String) As Boolean
        READ_PFK7122 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7122 "
            SQL = SQL & " WHERE K7122_SpecCode		 = '" & SpecCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7122_CLEAR() : GoTo SKIP_READ_PFK7122

            Call K7122_MOVE(rd)
            READ_PFK7122 = True

SKIP_READ_PFK7122:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7122", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK7122(SPECCODE As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7122 "
            SQL = SQL & " WHERE K7122_SpecCode		 = '" & SpecCode & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK7122", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK7122(z7122 As T7122_AREA) As Boolean
        WRITE_PFK7122 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7122)

            SQL = " INSERT INTO PFK7122 "
            SQL = SQL & " ( "
            SQL = SQL & " K7122_SpecCode,"
            SQL = SQL & " K7122_seLargeGroupMaterial,"
            SQL = SQL & " K7122_cdLargeGroupMaterial,"
            SQL = SQL & " K7122_seSemiGroupMaterial,"
            SQL = SQL & " K7122_cdSemiGroupMaterial,"
            SQL = SQL & " K7122_seDetailGroupMaterial,"
            SQL = SQL & " K7122_cdDetailGroupMaterial,"
            SQL = SQL & " K7122_CheckUse,"
            SQL = SQL & " K7122_DateInsert,"
            SQL = SQL & " K7122_DateUpdate,"
            SQL = SQL & " K7122_InchargeInsert,"
            SQL = SQL & " K7122_InchargeUpdate,"
            SQL = SQL & " K7122_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z7122.SpecCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7122.seLargeGroupMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7122.cdLargeGroupMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7122.seSemiGroupMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7122.cdSemiGroupMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7122.seDetailGroupMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7122.cdDetailGroupMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7122.CheckUse) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7122.DateInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7122.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7122.InchargeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7122.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7122.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK7122 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK7122", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK7122(z7122 As T7122_AREA) As Boolean
        REWRITE_PFK7122 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7122)

            SQL = " UPDATE PFK7122 SET "
            SQL = SQL & "    K7122_seLargeGroupMaterial      = N'" & FormatSQL(z7122.seLargeGroupMaterial) & "', "
            SQL = SQL & "    K7122_cdLargeGroupMaterial      = N'" & FormatSQL(z7122.cdLargeGroupMaterial) & "', "
            SQL = SQL & "    K7122_seSemiGroupMaterial      = N'" & FormatSQL(z7122.seSemiGroupMaterial) & "', "
            SQL = SQL & "    K7122_cdSemiGroupMaterial      = N'" & FormatSQL(z7122.cdSemiGroupMaterial) & "', "
            SQL = SQL & "    K7122_seDetailGroupMaterial      = N'" & FormatSQL(z7122.seDetailGroupMaterial) & "', "
            SQL = SQL & "    K7122_cdDetailGroupMaterial      = N'" & FormatSQL(z7122.cdDetailGroupMaterial) & "', "
            SQL = SQL & "    K7122_CheckUse      = N'" & FormatSQL(z7122.CheckUse) & "', "
            SQL = SQL & "    K7122_DateInsert      = N'" & FormatSQL(z7122.DateInsert) & "', "
            SQL = SQL & "    K7122_DateUpdate      = N'" & FormatSQL(z7122.DateUpdate) & "', "
            SQL = SQL & "    K7122_InchargeInsert      = N'" & FormatSQL(z7122.InchargeInsert) & "', "
            SQL = SQL & "    K7122_InchargeUpdate      = N'" & FormatSQL(z7122.InchargeUpdate) & "', "
            SQL = SQL & "    K7122_Remark      = N'" & FormatSQL(z7122.Remark) & "'  "
            SQL = SQL & " WHERE K7122_SpecCode		 = '" & z7122.SpecCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK7122 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK7122", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK7122(z7122 As T7122_AREA) As Boolean
        DELETE_PFK7122 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK7122 "
            SQL = SQL & " WHERE K7122_SpecCode		 = '" & z7122.SpecCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7122 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7122", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D7122_CLEAR()
        Try

            D7122.SpecCode = ""
            D7122.seLargeGroupMaterial = ""
            D7122.cdLargeGroupMaterial = ""
            D7122.seSemiGroupMaterial = ""
            D7122.cdSemiGroupMaterial = ""
            D7122.seDetailGroupMaterial = ""
            D7122.cdDetailGroupMaterial = ""
            D7122.CheckUse = ""
            D7122.DateInsert = ""
            D7122.DateUpdate = ""
            D7122.InchargeInsert = ""
            D7122.InchargeUpdate = ""
            D7122.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D7122_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x7122 As T7122_AREA)
        Try

            x7122.SpecCode = trim$(x7122.SpecCode)
            x7122.seLargeGroupMaterial = trim$(x7122.seLargeGroupMaterial)
            x7122.cdLargeGroupMaterial = trim$(x7122.cdLargeGroupMaterial)
            x7122.seSemiGroupMaterial = trim$(x7122.seSemiGroupMaterial)
            x7122.cdSemiGroupMaterial = trim$(x7122.cdSemiGroupMaterial)
            x7122.seDetailGroupMaterial = trim$(x7122.seDetailGroupMaterial)
            x7122.cdDetailGroupMaterial = trim$(x7122.cdDetailGroupMaterial)
            x7122.CheckUse = trim$(x7122.CheckUse)
            x7122.DateInsert = trim$(x7122.DateInsert)
            x7122.DateUpdate = trim$(x7122.DateUpdate)
            x7122.InchargeInsert = trim$(x7122.InchargeInsert)
            x7122.InchargeUpdate = trim$(x7122.InchargeUpdate)
            x7122.Remark = trim$(x7122.Remark)

            If trim$(x7122.SpecCode) = "" Then x7122.SpecCode = Space(1)
            If trim$(x7122.seLargeGroupMaterial) = "" Then x7122.seLargeGroupMaterial = Space(1)
            If trim$(x7122.cdLargeGroupMaterial) = "" Then x7122.cdLargeGroupMaterial = Space(1)
            If trim$(x7122.seSemiGroupMaterial) = "" Then x7122.seSemiGroupMaterial = Space(1)
            If trim$(x7122.cdSemiGroupMaterial) = "" Then x7122.cdSemiGroupMaterial = Space(1)
            If trim$(x7122.seDetailGroupMaterial) = "" Then x7122.seDetailGroupMaterial = Space(1)
            If trim$(x7122.cdDetailGroupMaterial) = "" Then x7122.cdDetailGroupMaterial = Space(1)
            If trim$(x7122.CheckUse) = "" Then x7122.CheckUse = Space(1)
            If trim$(x7122.DateInsert) = "" Then x7122.DateInsert = Space(1)
            If trim$(x7122.DateUpdate) = "" Then x7122.DateUpdate = Space(1)
            If trim$(x7122.InchargeInsert) = "" Then x7122.InchargeInsert = Space(1)
            If trim$(x7122.InchargeUpdate) = "" Then x7122.InchargeUpdate = Space(1)
            If trim$(x7122.Remark) = "" Then x7122.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K7122_MOVE(rs7122 As SqlClient.SqlDataReader)
        Try

            Call D7122_CLEAR()

            If IsdbNull(rs7122!K7122_SpecCode) = False Then D7122.SpecCode = Trim$(rs7122!K7122_SpecCode)
            If IsdbNull(rs7122!K7122_seLargeGroupMaterial) = False Then D7122.seLargeGroupMaterial = Trim$(rs7122!K7122_seLargeGroupMaterial)
            If IsdbNull(rs7122!K7122_cdLargeGroupMaterial) = False Then D7122.cdLargeGroupMaterial = Trim$(rs7122!K7122_cdLargeGroupMaterial)
            If IsdbNull(rs7122!K7122_seSemiGroupMaterial) = False Then D7122.seSemiGroupMaterial = Trim$(rs7122!K7122_seSemiGroupMaterial)
            If IsdbNull(rs7122!K7122_cdSemiGroupMaterial) = False Then D7122.cdSemiGroupMaterial = Trim$(rs7122!K7122_cdSemiGroupMaterial)
            If IsdbNull(rs7122!K7122_seDetailGroupMaterial) = False Then D7122.seDetailGroupMaterial = Trim$(rs7122!K7122_seDetailGroupMaterial)
            If IsdbNull(rs7122!K7122_cdDetailGroupMaterial) = False Then D7122.cdDetailGroupMaterial = Trim$(rs7122!K7122_cdDetailGroupMaterial)
            If IsdbNull(rs7122!K7122_CheckUse) = False Then D7122.CheckUse = Trim$(rs7122!K7122_CheckUse)
            If IsdbNull(rs7122!K7122_DateInsert) = False Then D7122.DateInsert = Trim$(rs7122!K7122_DateInsert)
            If IsdbNull(rs7122!K7122_DateUpdate) = False Then D7122.DateUpdate = Trim$(rs7122!K7122_DateUpdate)
            If IsdbNull(rs7122!K7122_InchargeInsert) = False Then D7122.InchargeInsert = Trim$(rs7122!K7122_InchargeInsert)
            If IsdbNull(rs7122!K7122_InchargeUpdate) = False Then D7122.InchargeUpdate = Trim$(rs7122!K7122_InchargeUpdate)
            If IsdbNull(rs7122!K7122_Remark) = False Then D7122.Remark = Trim$(rs7122!K7122_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7122_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K7122_MOVE(rs7122 As DataRow)
        Try

            Call D7122_CLEAR()

            If IsdbNull(rs7122!K7122_SpecCode) = False Then D7122.SpecCode = Trim$(rs7122!K7122_SpecCode)
            If IsdbNull(rs7122!K7122_seLargeGroupMaterial) = False Then D7122.seLargeGroupMaterial = Trim$(rs7122!K7122_seLargeGroupMaterial)
            If IsdbNull(rs7122!K7122_cdLargeGroupMaterial) = False Then D7122.cdLargeGroupMaterial = Trim$(rs7122!K7122_cdLargeGroupMaterial)
            If IsdbNull(rs7122!K7122_seSemiGroupMaterial) = False Then D7122.seSemiGroupMaterial = Trim$(rs7122!K7122_seSemiGroupMaterial)
            If IsdbNull(rs7122!K7122_cdSemiGroupMaterial) = False Then D7122.cdSemiGroupMaterial = Trim$(rs7122!K7122_cdSemiGroupMaterial)
            If IsdbNull(rs7122!K7122_seDetailGroupMaterial) = False Then D7122.seDetailGroupMaterial = Trim$(rs7122!K7122_seDetailGroupMaterial)
            If IsdbNull(rs7122!K7122_cdDetailGroupMaterial) = False Then D7122.cdDetailGroupMaterial = Trim$(rs7122!K7122_cdDetailGroupMaterial)
            If IsdbNull(rs7122!K7122_CheckUse) = False Then D7122.CheckUse = Trim$(rs7122!K7122_CheckUse)
            If IsdbNull(rs7122!K7122_DateInsert) = False Then D7122.DateInsert = Trim$(rs7122!K7122_DateInsert)
            If IsdbNull(rs7122!K7122_DateUpdate) = False Then D7122.DateUpdate = Trim$(rs7122!K7122_DateUpdate)
            If IsdbNull(rs7122!K7122_InchargeInsert) = False Then D7122.InchargeInsert = Trim$(rs7122!K7122_InchargeInsert)
            If IsdbNull(rs7122!K7122_InchargeUpdate) = False Then D7122.InchargeUpdate = Trim$(rs7122!K7122_InchargeUpdate)
            If IsdbNull(rs7122!K7122_Remark) = False Then D7122.Remark = Trim$(rs7122!K7122_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7122_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K7122_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7122 As T7122_AREA, SPECCODE As String) As Boolean

        K7122_MOVE = False

        Try
            If READ_PFK7122(SPECCODE) = True Then
                z7122 = D7122
                K7122_MOVE = True
            Else
                z7122 = Nothing
            End If

            If getColumIndex(spr, "SpecCode") > -1 Then z7122.SpecCode = getDataM(spr, getColumIndex(spr, "SpecCode"), xRow)
            If getColumIndex(spr, "seLargeGroupMaterial") > -1 Then z7122.seLargeGroupMaterial = getDataM(spr, getColumIndex(spr, "seLargeGroupMaterial"), xRow)
            If getColumIndex(spr, "cdLargeGroupMaterial") > -1 Then z7122.cdLargeGroupMaterial = getDataM(spr, getColumIndex(spr, "cdLargeGroupMaterial"), xRow)
            If getColumIndex(spr, "seSemiGroupMaterial") > -1 Then z7122.seSemiGroupMaterial = getDataM(spr, getColumIndex(spr, "seSemiGroupMaterial"), xRow)
            If getColumIndex(spr, "cdSemiGroupMaterial") > -1 Then z7122.cdSemiGroupMaterial = getDataM(spr, getColumIndex(spr, "cdSemiGroupMaterial"), xRow)
            If getColumIndex(spr, "seDetailGroupMaterial") > -1 Then z7122.seDetailGroupMaterial = getDataM(spr, getColumIndex(spr, "seDetailGroupMaterial"), xRow)
            If getColumIndex(spr, "cdDetailGroupMaterial") > -1 Then z7122.cdDetailGroupMaterial = getDataM(spr, getColumIndex(spr, "cdDetailGroupMaterial"), xRow)
            If getColumIndex(spr, "CheckUse") > -1 Then z7122.CheckUse = getDataM(spr, getColumIndex(spr, "CheckUse"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z7122.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z7122.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z7122.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z7122.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z7122.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7122_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K7122_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7122 As T7122_AREA, CheckClear As Boolean, SPECCODE As String) As Boolean

        K7122_MOVE = False

        Try
            If READ_PFK7122(SPECCODE) = True Then
                z7122 = D7122
                K7122_MOVE = True
            Else
                If CheckClear = True Then z7122 = Nothing
            End If

            If getColumIndex(spr, "SpecCode") > -1 Then z7122.SpecCode = getDataM(spr, getColumIndex(spr, "SpecCode"), xRow)
            If getColumIndex(spr, "seLargeGroupMaterial") > -1 Then z7122.seLargeGroupMaterial = getDataM(spr, getColumIndex(spr, "seLargeGroupMaterial"), xRow)
            If getColumIndex(spr, "cdLargeGroupMaterial") > -1 Then z7122.cdLargeGroupMaterial = getDataM(spr, getColumIndex(spr, "cdLargeGroupMaterial"), xRow)
            If getColumIndex(spr, "seSemiGroupMaterial") > -1 Then z7122.seSemiGroupMaterial = getDataM(spr, getColumIndex(spr, "seSemiGroupMaterial"), xRow)
            If getColumIndex(spr, "cdSemiGroupMaterial") > -1 Then z7122.cdSemiGroupMaterial = getDataM(spr, getColumIndex(spr, "cdSemiGroupMaterial"), xRow)
            If getColumIndex(spr, "seDetailGroupMaterial") > -1 Then z7122.seDetailGroupMaterial = getDataM(spr, getColumIndex(spr, "seDetailGroupMaterial"), xRow)
            If getColumIndex(spr, "cdDetailGroupMaterial") > -1 Then z7122.cdDetailGroupMaterial = getDataM(spr, getColumIndex(spr, "cdDetailGroupMaterial"), xRow)
            If getColumIndex(spr, "CheckUse") > -1 Then z7122.CheckUse = getDataM(spr, getColumIndex(spr, "CheckUse"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z7122.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z7122.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z7122.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z7122.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z7122.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7122_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K7122_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7122 As T7122_AREA, Job As String, SPECCODE As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7122_MOVE = False

        Try
            If READ_PFK7122(SPECCODE) = True Then
                z7122 = D7122
                K7122_MOVE = True
            Else
                z7122 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7122")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "SPECCODE" : z7122.SpecCode = Children(i).Code
                                Case "SELARGEGROUPMATERIAL" : z7122.seLargeGroupMaterial = Children(i).Code
                                Case "CDLARGEGROUPMATERIAL" : z7122.cdLargeGroupMaterial = Children(i).Code
                                Case "SESEMIGROUPMATERIAL" : z7122.seSemiGroupMaterial = Children(i).Code
                                Case "CDSEMIGROUPMATERIAL" : z7122.cdSemiGroupMaterial = Children(i).Code
                                Case "SEDETAILGROUPMATERIAL" : z7122.seDetailGroupMaterial = Children(i).Code
                                Case "CDDETAILGROUPMATERIAL" : z7122.cdDetailGroupMaterial = Children(i).Code
                                Case "CHECKUSE" : z7122.CheckUse = Children(i).Code
                                Case "DATEINSERT" : z7122.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z7122.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z7122.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z7122.InchargeUpdate = Children(i).Code
                                Case "REMARK" : z7122.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "SPECCODE" : z7122.SpecCode = Children(i).Data
                                Case "SELARGEGROUPMATERIAL" : z7122.seLargeGroupMaterial = Children(i).Data
                                Case "CDLARGEGROUPMATERIAL" : z7122.cdLargeGroupMaterial = Children(i).Data
                                Case "SESEMIGROUPMATERIAL" : z7122.seSemiGroupMaterial = Children(i).Data
                                Case "CDSEMIGROUPMATERIAL" : z7122.cdSemiGroupMaterial = Children(i).Data
                                Case "SEDETAILGROUPMATERIAL" : z7122.seDetailGroupMaterial = Children(i).Data
                                Case "CDDETAILGROUPMATERIAL" : z7122.cdDetailGroupMaterial = Children(i).Data
                                Case "CHECKUSE" : z7122.CheckUse = Children(i).Data
                                Case "DATEINSERT" : z7122.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z7122.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z7122.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z7122.InchargeUpdate = Children(i).Data
                                Case "REMARK" : z7122.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7122_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K7122_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7122 As T7122_AREA, Job As String, CheckClear As Boolean, SPECCODE As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7122_MOVE = False

        Try
            If READ_PFK7122(SPECCODE) = True Then
                z7122 = D7122
                K7122_MOVE = True
            Else
                If CheckClear = True Then z7122 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7122")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "SPECCODE" : z7122.SpecCode = Children(i).Code
                                Case "SELARGEGROUPMATERIAL" : z7122.seLargeGroupMaterial = Children(i).Code
                                Case "CDLARGEGROUPMATERIAL" : z7122.cdLargeGroupMaterial = Children(i).Code
                                Case "SESEMIGROUPMATERIAL" : z7122.seSemiGroupMaterial = Children(i).Code
                                Case "CDSEMIGROUPMATERIAL" : z7122.cdSemiGroupMaterial = Children(i).Code
                                Case "SEDETAILGROUPMATERIAL" : z7122.seDetailGroupMaterial = Children(i).Code
                                Case "CDDETAILGROUPMATERIAL" : z7122.cdDetailGroupMaterial = Children(i).Code
                                Case "CHECKUSE" : z7122.CheckUse = Children(i).Code
                                Case "DATEINSERT" : z7122.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z7122.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z7122.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z7122.InchargeUpdate = Children(i).Code
                                Case "REMARK" : z7122.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "SPECCODE" : z7122.SpecCode = Children(i).Data
                                Case "SELARGEGROUPMATERIAL" : z7122.seLargeGroupMaterial = Children(i).Data
                                Case "CDLARGEGROUPMATERIAL" : z7122.cdLargeGroupMaterial = Children(i).Data
                                Case "SESEMIGROUPMATERIAL" : z7122.seSemiGroupMaterial = Children(i).Data
                                Case "CDSEMIGROUPMATERIAL" : z7122.cdSemiGroupMaterial = Children(i).Data
                                Case "SEDETAILGROUPMATERIAL" : z7122.seDetailGroupMaterial = Children(i).Data
                                Case "CDDETAILGROUPMATERIAL" : z7122.cdDetailGroupMaterial = Children(i).Data
                                Case "CHECKUSE" : z7122.CheckUse = Children(i).Data
   Case "DATEINSERT":z7122.DateInsert = Children(i).Data
   Case "DATEUPDATE":z7122.DateUpdate = Children(i).Data
   Case "INCHARGEINSERT":z7122.InchargeInsert = Children(i).Data
   Case "INCHARGEUPDATE":z7122.InchargeUpdate = Children(i).Data
   Case "REMARK":z7122.Remark = Children(i).Data
 		  End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7122_MOVE",vbCritical)
End Try
End Function 
    
End Module 
