'=========================================================================================================================================================
'   TABLE : (PFK9992)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9992

    Structure T9992_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public SITE As String  '			char(3)		*
        Public SANO As String  '			char(8)		*
        Public ID As String  '			varchar(30)
        Public PW As String  '			varchar(30)
        Public IP As String  '			varchar(30)
        Public GRANT As String  '			char(1)
        Public GROUP_ERO As String  '			char(3)
        Public GROUP_BASIC As String  '			char(3)
        Public GROUP As String  '			char(3)
        Public CUSTOMER_CHK As String  '			char(1)
        Public CHECKSITE As String  '			char(1)

        Public GROUPPW As String  '			varchar(30)
        '=========================================================================================================================================================
    End Structure

    Public D9992 As T9992_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK9992(SITE As String, SANO As String) As Boolean
        READ_PFK9992 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9992 "
            SQL = SQL & " WHERE K9992_SANO		 = '" & SANO & "' "
            'SQL = SQL & "   AND K9992_SANO		 = '" & SANO & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9992_CLEAR() : GoTo SKIP_READ_PFK9992

            Call K9992_MOVE(rd)
            READ_PFK9992 = True

SKIP_READ_PFK9992:
            rd.Close()
            Exit Function
        Catch ex As Exception
            '  Call MsgBoxP("READ_PFK9992", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK9992(SITE As String, SANO As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9992 "
            SQL = SQL & " WHERE K9992_SITE		 = '" & SITE & "' "
            SQL = SQL & "   AND K9992_SANO		 = '" & SANO & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK9992", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK9992(z9992 As T9992_AREA) As Boolean
        WRITE_PFK9992 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9992)

            SQL = " INSERT INTO PFK9992 "
            SQL = SQL & " ( "
            SQL = SQL & " K9992_SITE,"
            SQL = SQL & " K9992_SANO,"
            SQL = SQL & " K9992_ID,"
            SQL = SQL & " K9992_PW,"
            SQL = SQL & " K9992_IP,"
            SQL = SQL & " K9992_GRANT,"
            SQL = SQL & " K9992_GROUP_ERO,"
            SQL = SQL & " K9992_GROUP_BASIC,"
            SQL = SQL & " K9992_GROUP,"
            SQL = SQL & " K9992_CUSTOMER_CHK,"
            SQL = SQL & " K9992_CHECKSITE,"
            SQL = SQL & " K9992_GROUPPW "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z9992.SITE) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9992.SANO) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9992.ID) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9992.PW) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9992.IP) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9992.GRANT) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9992.GROUP_ERO) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9992.GROUP_BASIC) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9992.GROUP) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9992.CUSTOMER_CHK) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9992.CHECKSITE) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9992.GROUPPW) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK9992 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK9992", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK9992(z9992 As T9992_AREA) As Boolean
        REWRITE_PFK9992 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9992)

            SQL = " UPDATE PFK9992 SET "
            SQL = SQL & "    K9992_ID      = N'" & FormatSQL(z9992.ID) & "', "
            SQL = SQL & "    K9992_PW      = N'" & FormatSQL(z9992.PW) & "', "
            SQL = SQL & "    K9992_IP      = N'" & FormatSQL(z9992.IP) & "', "
            SQL = SQL & "    K9992_GRANT      = N'" & FormatSQL(z9992.GRANT) & "', "
            SQL = SQL & "    K9992_GROUP_ERO      = N'" & FormatSQL(z9992.GROUP_ERO) & "', "
            SQL = SQL & "    K9992_GROUP_BASIC      = N'" & FormatSQL(z9992.GROUP_BASIC) & "', "
            SQL = SQL & "    K9992_GROUP      = N'" & FormatSQL(z9992.GROUP) & "', "
            SQL = SQL & "    K9992_CUSTOMER_CHK      = N'" & FormatSQL(z9992.CUSTOMER_CHK) & "', "
            SQL = SQL & "    K9992_CHECKSITE      = N'" & FormatSQL(z9992.CHECKSITE) & "', "
            SQL = SQL & "    K9992_GROUPPW      = N'" & FormatSQL(z9992.GROUPPW) & "'  "
            SQL = SQL & " WHERE K9992_SITE		 = '" & z9992.SITE & "' "
            SQL = SQL & "   AND K9992_SANO		 = '" & z9992.SANO & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK9992 = True

            Exit Function
        Catch ex As Exception
            ' Call MsgBoxP("REWRITE_PFK9992", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK9992(z9992 As T9992_AREA) As Boolean
        DELETE_PFK9992 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK9992 "
            SQL = SQL & " WHERE K9992_SITE		 = '" & z9992.SITE & "' "
            SQL = SQL & "   AND K9992_SANO		 = '" & z9992.SANO & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK9992 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK9992", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D9992_CLEAR()
        Try
            D9992.SITE = ""
            D9992.SANO = ""
            D9992.ID = ""
            D9992.PW = ""
            D9992.IP = ""
            D9992.GRANT = ""
            D9992.GROUP_ERO = ""
            D9992.GROUP_BASIC = ""
            D9992.GROUP = ""
            D9992.CUSTOMER_CHK = ""
            D9992.CHECKSITE = ""
            D9992.GROUPPW = ""

            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D9992_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x9992 As T9992_AREA)
        Try

            x9992.SITE = Trim$(x9992.SITE)
            x9992.SANO = Trim$(x9992.SANO)
            x9992.ID = Trim$(x9992.ID)
            x9992.PW = Trim$(x9992.PW)
            x9992.IP = Trim$(x9992.IP)
            x9992.GRANT = Trim$(x9992.GRANT)
            x9992.GROUP_ERO = Trim$(x9992.GROUP_ERO)
            x9992.GROUP_BASIC = Trim$(x9992.GROUP_BASIC)
            x9992.GROUP = Trim$(x9992.GROUP)
            x9992.CUSTOMER_CHK = Trim$(x9992.CUSTOMER_CHK)
            x9992.CHECKSITE = Trim$(x9992.CHECKSITE)
            x9992.GROUPPW = Trim$(x9992.GROUPPW)

            If Trim$(x9992.SITE) = "" Then x9992.SITE = Space(1)
            If Trim$(x9992.SANO) = "" Then x9992.SANO = Space(1)
            If Trim$(x9992.ID) = "" Then x9992.ID = Space(1)
            If Trim$(x9992.PW) = "" Then x9992.PW = Space(1)
            If Trim$(x9992.IP) = "" Then x9992.IP = Space(1)
            If Trim$(x9992.GRANT) = "" Then x9992.GRANT = Space(1)
            If Trim$(x9992.GROUP_ERO) = "" Then x9992.GROUP_ERO = Space(1)
            If Trim$(x9992.GROUP_BASIC) = "" Then x9992.GROUP_BASIC = Space(1)
            If Trim$(x9992.GROUP) = "" Then x9992.GROUP = Space(1)
            If Trim$(x9992.CUSTOMER_CHK) = "" Then x9992.CUSTOMER_CHK = Space(1)
            If Trim$(x9992.CHECKSITE) = "" Then x9992.CHECKSITE = Space(1)
            If Trim$(x9992.GROUPPW) = "" Then x9992.GROUPPW = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K9992_MOVE(rs9992 As SqlClient.SqlDataReader)
        Try

            Call D9992_CLEAR()

            If IsDBNull(rs9992!K9992_SITE) = False Then D9992.SITE = Trim$(rs9992!K9992_SITE)
            If IsDBNull(rs9992!K9992_SANO) = False Then D9992.SANO = Trim$(rs9992!K9992_SANO)
            If IsDBNull(rs9992!K9992_ID) = False Then D9992.ID = Trim$(rs9992!K9992_ID)
            If IsDBNull(rs9992!K9992_PW) = False Then D9992.PW = Trim$(rs9992!K9992_PW)
            If IsDBNull(rs9992!K9992_IP) = False Then D9992.IP = Trim$(rs9992!K9992_IP)
            If IsDBNull(rs9992!K9992_GRANT) = False Then D9992.GRANT = Trim$(rs9992!K9992_GRANT)
            If IsDBNull(rs9992!K9992_GROUP_ERO) = False Then D9992.GROUP_ERO = Trim$(rs9992!K9992_GROUP_ERO)
            If IsDBNull(rs9992!K9992_GROUP_BASIC) = False Then D9992.GROUP_BASIC = Trim$(rs9992!K9992_GROUP_BASIC)
            If IsDBNull(rs9992!K9992_GROUP) = False Then D9992.GROUP = Trim$(rs9992!K9992_GROUP)
            If IsDBNull(rs9992!K9992_CUSTOMER_CHK) = False Then D9992.CUSTOMER_CHK = Trim$(rs9992!K9992_CUSTOMER_CHK)
            If IsDBNull(rs9992!K9992_CHECKSITE) = False Then D9992.CHECKSITE = Trim$(rs9992!K9992_CHECKSITE)
            If IsDBNull(rs9992!K9992_GROUPPW) = False Then D9992.GROUPPW = Trim$(rs9992!K9992_GROUPPW)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9992_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K9992_MOVE(rs9992 As DataRow)
        Try

            Call D9992_CLEAR()

            If IsDBNull(rs9992!K9992_SITE) = False Then D9992.SITE = Trim$(rs9992!K9992_SITE)
            If IsDBNull(rs9992!K9992_SANO) = False Then D9992.SANO = Trim$(rs9992!K9992_SANO)
            If IsDBNull(rs9992!K9992_ID) = False Then D9992.ID = Trim$(rs9992!K9992_ID)
            If IsDBNull(rs9992!K9992_PW) = False Then D9992.PW = Trim$(rs9992!K9992_PW)
            If IsDBNull(rs9992!K9992_IP) = False Then D9992.IP = Trim$(rs9992!K9992_IP)
            If IsDBNull(rs9992!K9992_GRANT) = False Then D9992.GRANT = Trim$(rs9992!K9992_GRANT)
            If IsDBNull(rs9992!K9992_GROUP_ERO) = False Then D9992.GROUP_ERO = Trim$(rs9992!K9992_GROUP_ERO)
            If IsDBNull(rs9992!K9992_GROUP_BASIC) = False Then D9992.GROUP_BASIC = Trim$(rs9992!K9992_GROUP_BASIC)
            If IsDBNull(rs9992!K9992_GROUP) = False Then D9992.GROUP = Trim$(rs9992!K9992_GROUP)
            If IsDBNull(rs9992!K9992_CUSTOMER_CHK) = False Then D9992.CUSTOMER_CHK = Trim$(rs9992!K9992_CUSTOMER_CHK)
            If IsDBNull(rs9992!K9992_CHECKSITE) = False Then D9992.CHECKSITE = Trim$(rs9992!K9992_CHECKSITE)
            If IsDBNull(rs9992!K9992_GROUPPW) = False Then D9992.GROUPPW = Trim$(rs9992!K9992_GROUPPW)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9992_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K9992_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9992 As T9992_AREA, SITE As String, SANO As String) As Boolean

        K9992_MOVE = False

        Try
            If READ_PFK9992(SITE, SANO) = True Then
                z9992 = D9992
                K9992_MOVE = True
            End If

            If getColumIndex(spr, "SITE") > -1 Then z9992.SITE = getDataM(spr, getColumIndex(spr, "SITE"), xRow)
            If getColumIndex(spr, "SANO") > -1 Then z9992.SANO = getDataM(spr, getColumIndex(spr, "SANO"), xRow)
            If getColumIndex(spr, "ID") > -1 Then z9992.ID = getDataM(spr, getColumIndex(spr, "ID"), xRow)
            If getColumIndex(spr, "PW") > -1 Then z9992.PW = getDataM(spr, getColumIndex(spr, "PW"), xRow)
            If getColumIndex(spr, "IP") > -1 Then z9992.IP = getDataM(spr, getColumIndex(spr, "IP"), xRow)
            If getColumIndex(spr, "GRANT") > -1 Then z9992.GRANT = getDataM(spr, getColumIndex(spr, "GRANT"), xRow)
            If getColumIndex(spr, "GROUP_ERO") > -1 Then z9992.GROUP_ERO = getDataM(spr, getColumIndex(spr, "GROUP_ERO"), xRow)
            If getColumIndex(spr, "GROUP_BASIC") > -1 Then z9992.GROUP_BASIC = getDataM(spr, getColumIndex(spr, "GROUP_BASIC"), xRow)
            If getColumIndex(spr, "GROUP") > -1 Then z9992.GROUP = getDataM(spr, getColumIndex(spr, "GROUP"), xRow)
            If getColumIndex(spr, "CUSTOMER_CHK") > -1 Then z9992.CUSTOMER_CHK = getDataM(spr, getColumIndex(spr, "CUSTOMER_CHK"), xRow)
            If getColumIndex(spr, "CHECKSITE") > -1 Then z9992.CHECKSITE = getDataM(spr, getColumIndex(spr, "CHECKSITE"), xRow)
            If getColumIndex(spr, "GROUPPW") > -1 Then z9992.GROUPPW = getDataM(spr, getColumIndex(spr, "GROUPPW"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9992_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K9992_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9992 As T9992_AREA, Job As String, SITE As String, SANO As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9992_MOVE = False

        Try
            If READ_PFK9992(SITE, SANO) = True Then
                z9992 = D9992
                K9992_MOVE = True

            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9992")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "SITE" : z9992.SITE = Children(i).Code
                                Case "SANO" : z9992.SANO = Children(i).Code
                                Case "ID" : z9992.ID = Children(i).Code
                                Case "PW" : z9992.PW = Children(i).Code
                                Case "IP" : z9992.IP = Children(i).Code
                                Case "GRANT" : z9992.GRANT = Children(i).Code
                                Case "GROUP_ERO" : z9992.GROUP_ERO = Children(i).Code
                                Case "GROUP_BASIC" : z9992.GROUP_BASIC = Children(i).Code
                                Case "GROUP" : z9992.GROUP = Children(i).Code
                                Case "CUSTOMER_CHK" : z9992.CUSTOMER_CHK = Children(i).Code
                                Case "CHECKSITE" : z9992.CHECKSITE = Children(i).Code
                                Case "GROUPPW" : z9992.GROUPPW = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "SITE" : z9992.SITE = Children(i).Data
                                Case "SANO" : z9992.SANO = Children(i).Data
                                Case "ID" : z9992.ID = Children(i).Data
                                Case "PW" : z9992.PW = Children(i).Data
                                Case "IP" : z9992.IP = Children(i).Data
                                Case "GRANT" : z9992.GRANT = Children(i).Data
                                Case "GROUP_ERO" : z9992.GROUP_ERO = Children(i).Data
                                Case "GROUP_BASIC" : z9992.GROUP_BASIC = Children(i).Data
                                Case "GROUP" : z9992.GROUP = Children(i).Data
                                Case "CUSTOMER_CHK" : z9992.CUSTOMER_CHK = Children(i).Data
                                Case "CHECKSITE" : z9992.CHECKSITE = Children(i).Data
                                Case "GROUPPW" : z9992.GROUPPW = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9992_MOVE", vbCritical)
        End Try
    End Function

End Module
