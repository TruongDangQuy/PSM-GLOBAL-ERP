'=========================================================================================================================================================
'   TABLE : (PFW9998)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_W9998

    Structure T9998_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public PageDate As String  '			char(8)		*
        Public PageSeq As String  '			char(5)		*
        Public Page As String  '			nvarchar(550)
        Public PageName As String  '			nvarchar(550)
        Public NameSimply As String  '			nvarchar(100)
        Public ForeignName1 As String  '			nvarchar(100)
        Public ForeignName2 As String  '			nvarchar(100)
        Public seSubProcess As String  '			char(3)
        Public cdSubProcess As String  '			char(3)
        Public CheckUse As String  '			char(1)
        Public Remark As String  '			nvarchar(4000)
        '=========================================================================================================================================================
    End Structure

    Public D9998 As T9998_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFW9998(PAGEDATE As String, PAGESEQ As String) As Boolean
        READ_PFW9998 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFW9998 "
            SQL = SQL & " WHERE W9998_PageDate		 = '" & PAGEDATE & "' "
            SQL = SQL & "   AND W9998_PageSeq		 = '" & PAGESEQ & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9998_CLEAR() : GoTo SKIP_READ_PFW9998

            Call W9998_MOVE(rd)
            READ_PFW9998 = True

SKIP_READ_PFW9998:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFW9998", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFW9998(PAGEDATE As String, PAGESEQ As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFW9998 "
            SQL = SQL & " WHERE W9998_PageDate		 = '" & PAGEDATE & "' "
            SQL = SQL & "   AND W9998_PageSeq		 = '" & PAGESEQ & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFW9998", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFW9998(z9998 As T9998_AREA) As Boolean
        WRITE_PFW9998 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9998)

            SQL = " INSERT INTO PFW9998 "
            SQL = SQL & " ( "
            SQL = SQL & " W9998_PageDate,"
            SQL = SQL & " W9998_PageSeq,"
            SQL = SQL & " W9998_Page,"
            SQL = SQL & " W9998_PageName,"
            SQL = SQL & " W9998_NameSimply,"
            SQL = SQL & " W9998_ForeignName1,"
            SQL = SQL & " W9998_ForeignName2,"
            SQL = SQL & " W9998_seSubProcess,"
            SQL = SQL & " W9998_cdSubProcess,"
            SQL = SQL & " W9998_CheckUse,"
            SQL = SQL & " W9998_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z9998.PageDate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9998.PageSeq) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9998.Page) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9998.PageName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9998.NameSimply) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9998.ForeignName1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9998.ForeignName2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9998.seSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9998.cdSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9998.CheckUse) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9998.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFW9998 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFW9998", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFW9998(z9998 As T9998_AREA) As Boolean
        REWRITE_PFW9998 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9998)

            SQL = " UPDATE PFW9998 SET "
            SQL = SQL & "    W9998_Page      = N'" & FormatSQL(z9998.Page) & "', "
            SQL = SQL & "    W9998_PageName      = N'" & FormatSQL(z9998.PageName) & "', "
            SQL = SQL & "    W9998_NameSimply      = N'" & FormatSQL(z9998.NameSimply) & "', "
            SQL = SQL & "    W9998_ForeignName1      = N'" & FormatSQL(z9998.ForeignName1) & "', "
            SQL = SQL & "    W9998_ForeignName2      = N'" & FormatSQL(z9998.ForeignName2) & "', "
            SQL = SQL & "    W9998_seSubProcess      = N'" & FormatSQL(z9998.seSubProcess) & "', "
            SQL = SQL & "    W9998_cdSubProcess      = N'" & FormatSQL(z9998.cdSubProcess) & "', "
            SQL = SQL & "    W9998_CheckUse      = N'" & FormatSQL(z9998.CheckUse) & "', "
            SQL = SQL & "    W9998_Remark      = N'" & FormatSQL(z9998.Remark) & "'  "
            SQL = SQL & " WHERE W9998_PageDate		 = '" & z9998.PageDate & "' "
            SQL = SQL & "   AND W9998_PageSeq		 = '" & z9998.PageSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFW9998 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFW9998", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFW9998(z9998 As T9998_AREA) As Boolean
        DELETE_PFW9998 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFW9998 "
            SQL = SQL & " WHERE W9998_PageDate		 = '" & z9998.PageDate & "' "
            SQL = SQL & "   AND W9998_PageSeq		 = '" & z9998.PageSeq & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFW9998 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFW9998", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D9998_CLEAR()
        Try

            D9998.PageDate = ""
            D9998.PageSeq = ""
            D9998.Page = ""
            D9998.PageName = ""
            D9998.NameSimply = ""
            D9998.ForeignName1 = ""
            D9998.ForeignName2 = ""
            D9998.seSubProcess = ""
            D9998.cdSubProcess = ""
            D9998.CheckUse = ""
            D9998.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D9998_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x9998 As T9998_AREA)
        Try

            x9998.PageDate = Trim$(x9998.PageDate)
            x9998.PageSeq = Trim$(x9998.PageSeq)
            x9998.Page = Trim$(x9998.Page)
            x9998.PageName = Trim$(x9998.PageName)
            x9998.NameSimply = Trim$(x9998.NameSimply)
            x9998.ForeignName1 = Trim$(x9998.ForeignName1)
            x9998.ForeignName2 = Trim$(x9998.ForeignName2)
            x9998.seSubProcess = Trim$(x9998.seSubProcess)
            x9998.cdSubProcess = Trim$(x9998.cdSubProcess)
            x9998.CheckUse = Trim$(x9998.CheckUse)
            x9998.Remark = Trim$(x9998.Remark)

            If Trim$(x9998.PageDate) = "" Then x9998.PageDate = Space(1)
            If Trim$(x9998.PageSeq) = "" Then x9998.PageSeq = Space(1)
            If Trim$(x9998.Page) = "" Then x9998.Page = Space(1)
            If Trim$(x9998.PageName) = "" Then x9998.PageName = Space(1)
            If Trim$(x9998.NameSimply) = "" Then x9998.NameSimply = Space(1)
            If Trim$(x9998.ForeignName1) = "" Then x9998.ForeignName1 = Space(1)
            If Trim$(x9998.ForeignName2) = "" Then x9998.ForeignName2 = Space(1)
            If Trim$(x9998.seSubProcess) = "" Then x9998.seSubProcess = Space(1)
            If Trim$(x9998.cdSubProcess) = "" Then x9998.cdSubProcess = Space(1)
            If Trim$(x9998.CheckUse) = "" Then x9998.CheckUse = Space(1)
            If Trim$(x9998.Remark) = "" Then x9998.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub W9998_MOVE(rs9998 As SqlClient.SqlDataReader)
        Try

            Call D9998_CLEAR()

            If IsDBNull(rs9998!W9998_PageDate) = False Then D9998.PageDate = Trim$(rs9998!W9998_PageDate)
            If IsDBNull(rs9998!W9998_PageSeq) = False Then D9998.PageSeq = Trim$(rs9998!W9998_PageSeq)
            If IsDBNull(rs9998!W9998_Page) = False Then D9998.Page = Trim$(rs9998!W9998_Page)
            If IsDBNull(rs9998!W9998_PageName) = False Then D9998.PageName = Trim$(rs9998!W9998_PageName)
            If IsDBNull(rs9998!W9998_NameSimply) = False Then D9998.NameSimply = Trim$(rs9998!W9998_NameSimply)
            If IsDBNull(rs9998!W9998_ForeignName1) = False Then D9998.ForeignName1 = Trim$(rs9998!W9998_ForeignName1)
            If IsDBNull(rs9998!W9998_ForeignName2) = False Then D9998.ForeignName2 = Trim$(rs9998!W9998_ForeignName2)
            If IsDBNull(rs9998!W9998_seSubProcess) = False Then D9998.seSubProcess = Trim$(rs9998!W9998_seSubProcess)
            If IsDBNull(rs9998!W9998_cdSubProcess) = False Then D9998.cdSubProcess = Trim$(rs9998!W9998_cdSubProcess)
            If IsDBNull(rs9998!W9998_CheckUse) = False Then D9998.CheckUse = Trim$(rs9998!W9998_CheckUse)
            If IsDBNull(rs9998!W9998_Remark) = False Then D9998.Remark = Trim$(rs9998!W9998_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("W9998_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub W9998_MOVE(rs9998 As DataRow)
        Try

            Call D9998_CLEAR()

            If IsDBNull(rs9998!W9998_PageDate) = False Then D9998.PageDate = Trim$(rs9998!W9998_PageDate)
            If IsDBNull(rs9998!W9998_PageSeq) = False Then D9998.PageSeq = Trim$(rs9998!W9998_PageSeq)
            If IsDBNull(rs9998!W9998_Page) = False Then D9998.Page = Trim$(rs9998!W9998_Page)
            If IsDBNull(rs9998!W9998_PageName) = False Then D9998.PageName = Trim$(rs9998!W9998_PageName)
            If IsDBNull(rs9998!W9998_NameSimply) = False Then D9998.NameSimply = Trim$(rs9998!W9998_NameSimply)
            If IsDBNull(rs9998!W9998_ForeignName1) = False Then D9998.ForeignName1 = Trim$(rs9998!W9998_ForeignName1)
            If IsDBNull(rs9998!W9998_ForeignName2) = False Then D9998.ForeignName2 = Trim$(rs9998!W9998_ForeignName2)
            If IsDBNull(rs9998!W9998_seSubProcess) = False Then D9998.seSubProcess = Trim$(rs9998!W9998_seSubProcess)
            If IsDBNull(rs9998!W9998_cdSubProcess) = False Then D9998.cdSubProcess = Trim$(rs9998!W9998_cdSubProcess)
            If IsDBNull(rs9998!W9998_CheckUse) = False Then D9998.CheckUse = Trim$(rs9998!W9998_CheckUse)
            If IsDBNull(rs9998!W9998_Remark) = False Then D9998.Remark = Trim$(rs9998!W9998_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("W9998_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function W9998_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9998 As T9998_AREA, PAGEDATE As String, PAGESEQ As String) As Boolean

        W9998_MOVE = False

        Try
            If READ_PFW9998(PAGEDATE, PAGESEQ) = True Then
                z9998 = D9998
                W9998_MOVE = True
            Else
                z9998 = Nothing
            End If

            If getColumnIndex(spr, "PageDate") > -1 Then z9998.PageDate = getDataM(spr, getColumnIndex(spr, "PageDate"), xRow)
            If getColumnIndex(spr, "PageSeq") > -1 Then z9998.PageSeq = getDataM(spr, getColumnIndex(spr, "PageSeq"), xRow)
            If getColumnIndex(spr, "Page") > -1 Then z9998.Page = getDataM(spr, getColumnIndex(spr, "Page"), xRow)
            If getColumnIndex(spr, "PageName") > -1 Then z9998.PageName = getDataM(spr, getColumnIndex(spr, "PageName"), xRow)
            If getColumnIndex(spr, "NameSimply") > -1 Then z9998.NameSimply = getDataM(spr, getColumnIndex(spr, "NameSimply"), xRow)
            If getColumnIndex(spr, "ForeignName1") > -1 Then z9998.ForeignName1 = getDataM(spr, getColumnIndex(spr, "ForeignName1"), xRow)
            If getColumnIndex(spr, "ForeignName2") > -1 Then z9998.ForeignName2 = getDataM(spr, getColumnIndex(spr, "ForeignName2"), xRow)
            If getColumnIndex(spr, "seSubProcess") > -1 Then z9998.seSubProcess = getDataM(spr, getColumnIndex(spr, "seSubProcess"), xRow)
            If getColumnIndex(spr, "cdSubProcess") > -1 Then z9998.cdSubProcess = getDataM(spr, getColumnIndex(spr, "cdSubProcess"), xRow)
            If getColumnIndex(spr, "CheckUse") > -1 Then z9998.CheckUse = getDataM(spr, getColumnIndex(spr, "CheckUse"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z9998.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("W9998_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function W9998_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9998 As T9998_AREA, CheckClear As Boolean, PAGEDATE As String, PAGESEQ As String) As Boolean

        W9998_MOVE = False

        Try
            If READ_PFW9998(PAGEDATE, PAGESEQ) = True Then
                z9998 = D9998
                W9998_MOVE = True
            Else
                If CheckClear = True Then z9998 = Nothing
            End If

            If getColumnIndex(spr, "PageDate") > -1 Then z9998.PageDate = getDataM(spr, getColumnIndex(spr, "PageDate"), xRow)
            If getColumnIndex(spr, "PageSeq") > -1 Then z9998.PageSeq = getDataM(spr, getColumnIndex(spr, "PageSeq"), xRow)
            If getColumnIndex(spr, "Page") > -1 Then z9998.Page = getDataM(spr, getColumnIndex(spr, "Page"), xRow)
            If getColumnIndex(spr, "PageName") > -1 Then z9998.PageName = getDataM(spr, getColumnIndex(spr, "PageName"), xRow)
            If getColumnIndex(spr, "NameSimply") > -1 Then z9998.NameSimply = getDataM(spr, getColumnIndex(spr, "NameSimply"), xRow)
            If getColumnIndex(spr, "ForeignName1") > -1 Then z9998.ForeignName1 = getDataM(spr, getColumnIndex(spr, "ForeignName1"), xRow)
            If getColumnIndex(spr, "ForeignName2") > -1 Then z9998.ForeignName2 = getDataM(spr, getColumnIndex(spr, "ForeignName2"), xRow)
            If getColumnIndex(spr, "seSubProcess") > -1 Then z9998.seSubProcess = getDataM(spr, getColumnIndex(spr, "seSubProcess"), xRow)
            If getColumnIndex(spr, "cdSubProcess") > -1 Then z9998.cdSubProcess = getDataM(spr, getColumnIndex(spr, "cdSubProcess"), xRow)
            If getColumnIndex(spr, "CheckUse") > -1 Then z9998.CheckUse = getDataM(spr, getColumnIndex(spr, "CheckUse"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z9998.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("W9998_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function W9998_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9998 As T9998_AREA, Job As String, PAGEDATE As String, PAGESEQ As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        W9998_MOVE = False

        Try
            If READ_PFW9998(PAGEDATE, PAGESEQ) = True Then
                z9998 = D9998
                W9998_MOVE = True
            Else
                z9998 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFW9998")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "PAGEDATE" : z9998.PageDate = Children(i).Code
                                Case "PAGESEQ" : z9998.PageSeq = Children(i).Code
                                Case "PAGE" : z9998.Page = Children(i).Code
                                Case "PAGENAME" : z9998.PageName = Children(i).Code
                                Case "NAMESIMPLY" : z9998.NameSimply = Children(i).Code
                                Case "FOREIGNNAME1" : z9998.ForeignName1 = Children(i).Code
                                Case "FOREIGNNAME2" : z9998.ForeignName2 = Children(i).Code
                                Case "SESUBPROCESS" : z9998.seSubProcess = Children(i).Code
                                Case "CDSUBPROCESS" : z9998.cdSubProcess = Children(i).Code
                                Case "CHECKUSE" : z9998.CheckUse = Children(i).Code
                                Case "REMARK" : z9998.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "PAGEDATE" : z9998.PageDate = Children(i).Data
                                Case "PAGESEQ" : z9998.PageSeq = Children(i).Data
                                Case "PAGE" : z9998.Page = Children(i).Data
                                Case "PAGENAME" : z9998.PageName = Children(i).Data
                                Case "NAMESIMPLY" : z9998.NameSimply = Children(i).Data
                                Case "FOREIGNNAME1" : z9998.ForeignName1 = Children(i).Data
                                Case "FOREIGNNAME2" : z9998.ForeignName2 = Children(i).Data
                                Case "SESUBPROCESS" : z9998.seSubProcess = Children(i).Data
                                Case "CDSUBPROCESS" : z9998.cdSubProcess = Children(i).Data
                                Case "CHECKUSE" : z9998.CheckUse = Children(i).Data
                                Case "REMARK" : z9998.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("W9998_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function W9998_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9998 As T9998_AREA, Job As String, CheckClear As Boolean, PAGEDATE As String, PAGESEQ As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        W9998_MOVE = False

        Try
            If READ_PFW9998(PAGEDATE, PAGESEQ) = True Then
                z9998 = D9998
                W9998_MOVE = True
            Else
                If CheckClear = True Then z9998 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFW9998")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "PAGEDATE" : z9998.PageDate = Children(i).Code
                                Case "PAGESEQ" : z9998.PageSeq = Children(i).Code
                                Case "PAGE" : z9998.Page = Children(i).Code
                                Case "PAGENAME" : z9998.PageName = Children(i).Code
                                Case "NAMESIMPLY" : z9998.NameSimply = Children(i).Code
                                Case "FOREIGNNAME1" : z9998.ForeignName1 = Children(i).Code
                                Case "FOREIGNNAME2" : z9998.ForeignName2 = Children(i).Code
                                Case "SESUBPROCESS" : z9998.seSubProcess = Children(i).Code
                                Case "CDSUBPROCESS" : z9998.cdSubProcess = Children(i).Code
                                Case "CHECKUSE" : z9998.CheckUse = Children(i).Code
                                Case "REMARK" : z9998.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "PAGEDATE" : z9998.PageDate = Children(i).Data
                                Case "PAGESEQ" : z9998.PageSeq = Children(i).Data
                                Case "PAGE" : z9998.Page = Children(i).Data
                                Case "PAGENAME" : z9998.PageName = Children(i).Data
                                Case "NAMESIMPLY" : z9998.NameSimply = Children(i).Data
                                Case "FOREIGNNAME1" : z9998.ForeignName1 = Children(i).Data
                                Case "FOREIGNNAME2" : z9998.ForeignName2 = Children(i).Data
                                Case "SESUBPROCESS" : z9998.seSubProcess = Children(i).Data
                                Case "CDSUBPROCESS" : z9998.cdSubProcess = Children(i).Data
                                Case "CHECKUSE" : z9998.CheckUse = Children(i).Data
                                Case "REMARK" : z9998.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("W9998_MOVE", vbCritical)
        End Try
    End Function

End Module
