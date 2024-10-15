'=========================================================================================================================================================
'   TABLE : (PFK7108)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7108

    Structure T7108_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public GroupComponentBOM As String  '			char(6)		*
        Public ShoesCode As String  '			char(6)
        Public GroupComponentBOMName As String  '			nvarchar(200)
        Public CheckUse As String  '			char(1)
        Public ChecComplete As String  '			char(1)
        Public Remark As String  '			nvarchar(50)
        Public QtyTTL As Double  '			decimal
        Public InchargeInsert As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        Public seSite As String  '			char(3)
        Public cdSite As String  '			char(3)
        '=========================================================================================================================================================
    End Structure

    Public D7108 As T7108_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK7108(GROUPCOMPONENTBOM As String) As Boolean
        READ_PFK7108 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7108 "
            SQL = SQL & " WHERE K7108_GroupComponentBOM		 = '" & GroupComponentBOM & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7108_CLEAR() : GoTo SKIP_READ_PFK7108

            Call K7108_MOVE(rd)
            READ_PFK7108 = True

SKIP_READ_PFK7108:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7108", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK7108(GROUPCOMPONENTBOM As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7108 "
            SQL = SQL & " WHERE K7108_GroupComponentBOM		 = '" & GroupComponentBOM & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK7108", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK7108(z7108 As T7108_AREA) As Boolean
        WRITE_PFK7108 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7108)

            SQL = " INSERT INTO PFK7108 "
            SQL = SQL & " ( "
            SQL = SQL & " K7108_GroupComponentBOM,"
            SQL = SQL & " K7108_ShoesCode,"
            SQL = SQL & " K7108_GroupComponentBOMName,"
            SQL = SQL & " K7108_CheckUse,"
            SQL = SQL & " K7108_ChecComplete,"
            SQL = SQL & " K7108_Remark,"
            SQL = SQL & " K7108_QtyTTL,"
            SQL = SQL & " K7108_InchargeInsert,"
            SQL = SQL & " K7108_InchargeUpdate,"
            SQL = SQL & " K7108_seSite,"
            SQL = SQL & " K7108_cdSite "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z7108.GroupComponentBOM) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7108.ShoesCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7108.GroupComponentBOMName) & "', "
            SQL = SQL & "  N'1', "
            SQL = SQL & "  N'" & FormatSQL(z7108.ChecComplete) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7108.Remark) & "', "
            SQL = SQL & "   " & FormatSQL(z7108.QtyTTL) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7108.InchargeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7108.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7108.seSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7108.cdSite) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK7108 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK7108", vbCritical)
        Finally
            Call GetFullInformation("PFK7108", "I", SQL)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK7108(z7108 As T7108_AREA) As Boolean
        REWRITE_PFK7108 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7108)

            SQL = " UPDATE PFK7108 SET "
            SQL = SQL & "    K7108_ShoesCode      = N'" & FormatSQL(z7108.ShoesCode) & "', "
            SQL = SQL & "    K7108_GroupComponentBOMName      = N'" & FormatSQL(z7108.GroupComponentBOMName) & "', "
            SQL = SQL & "    K7108_CheckUse      = N'" & FormatSQL(z7108.CheckUse) & "', "
            SQL = SQL & "    K7108_ChecComplete      = N'" & FormatSQL(z7108.ChecComplete) & "', "
            SQL = SQL & "    K7108_Remark      = N'" & FormatSQL(z7108.Remark) & "', "
            SQL = SQL & "    K7108_QtyTTL      =  " & FormatSQL(z7108.QtyTTL) & ", "
            SQL = SQL & "    K7108_InchargeInsert      = N'" & FormatSQL(z7108.InchargeInsert) & "', "
            SQL = SQL & "    K7108_InchargeUpdate      = N'" & FormatSQL(z7108.InchargeUpdate) & "', "
            SQL = SQL & "    K7108_seSite      = N'" & FormatSQL(z7108.seSite) & "', "
            SQL = SQL & "    K7108_cdSite      = N'" & FormatSQL(z7108.cdSite) & "'  "
            SQL = SQL & " WHERE K7108_GroupComponentBOM		 = '" & z7108.GroupComponentBOM & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK7108 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK7108", vbCritical)
        Finally
            Call GetFullInformation("PFK7108", "U", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK7108(z7108 As T7108_AREA) As Boolean
        DELETE_PFK7108 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7108)

            SQL = " DELETE FROM PFK7108  "
            SQL = SQL & " WHERE K7108_GroupComponentBOM		 = '" & z7108.GroupComponentBOM & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7108 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7108", vbCritical)
        Finally
            Call GetFullInformation("PFK7108", "U", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D7108_CLEAR()
        Try

            D7108.GroupComponentBOM = ""
            D7108.ShoesCode = ""
            D7108.GroupComponentBOMName = ""
            D7108.CheckUse = ""
            D7108.ChecComplete = ""
            D7108.Remark = ""
            D7108.QtyTTL = 0
            D7108.InchargeInsert = ""
            D7108.InchargeUpdate = ""
            D7108.seSite = ""
            D7108.cdSite = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D7108_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x7108 As T7108_AREA)
        Try

            x7108.GroupComponentBOM = trim$(x7108.GroupComponentBOM)
            x7108.ShoesCode = trim$(x7108.ShoesCode)
            x7108.GroupComponentBOMName = trim$(x7108.GroupComponentBOMName)
            x7108.CheckUse = trim$(x7108.CheckUse)
            x7108.ChecComplete = trim$(x7108.ChecComplete)
            x7108.Remark = trim$(x7108.Remark)
            x7108.QtyTTL = trim$(x7108.QtyTTL)
            x7108.InchargeInsert = Trim$(x7108.InchargeInsert)
            x7108.InchargeUpdate = trim$(x7108.InchargeUpdate)
            x7108.seSite = trim$(x7108.seSite)
            x7108.cdSite = trim$(x7108.cdSite)

            If trim$(x7108.GroupComponentBOM) = "" Then x7108.GroupComponentBOM = Space(1)
            If trim$(x7108.ShoesCode) = "" Then x7108.ShoesCode = Space(1)
            If trim$(x7108.GroupComponentBOMName) = "" Then x7108.GroupComponentBOMName = Space(1)
            If trim$(x7108.CheckUse) = "" Then x7108.CheckUse = Space(1)
            If trim$(x7108.ChecComplete) = "" Then x7108.ChecComplete = Space(1)
            If trim$(x7108.Remark) = "" Then x7108.Remark = Space(1)
            If trim$(x7108.QtyTTL) = "" Then x7108.QtyTTL = 0
            If Trim$(x7108.InchargeInsert) = "" Then x7108.InchargeInsert = Space(1)
            If trim$(x7108.InchargeUpdate) = "" Then x7108.InchargeUpdate = Space(1)
            If trim$(x7108.seSite) = "" Then x7108.seSite = Space(1)
            If trim$(x7108.cdSite) = "" Then x7108.cdSite = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K7108_MOVE(rs7108 As SqlClient.SqlDataReader)
        Try

            Call D7108_CLEAR()

            If IsdbNull(rs7108!K7108_GroupComponentBOM) = False Then D7108.GroupComponentBOM = Trim$(rs7108!K7108_GroupComponentBOM)
            If IsdbNull(rs7108!K7108_ShoesCode) = False Then D7108.ShoesCode = Trim$(rs7108!K7108_ShoesCode)
            If IsdbNull(rs7108!K7108_GroupComponentBOMName) = False Then D7108.GroupComponentBOMName = Trim$(rs7108!K7108_GroupComponentBOMName)
            If IsdbNull(rs7108!K7108_CheckUse) = False Then D7108.CheckUse = Trim$(rs7108!K7108_CheckUse)
            If IsdbNull(rs7108!K7108_ChecComplete) = False Then D7108.ChecComplete = Trim$(rs7108!K7108_ChecComplete)
            If IsdbNull(rs7108!K7108_Remark) = False Then D7108.Remark = Trim$(rs7108!K7108_Remark)
            If IsdbNull(rs7108!K7108_QtyTTL) = False Then D7108.QtyTTL = Trim$(rs7108!K7108_QtyTTL)
            If IsDBNull(rs7108!K7108_InchargeInsert) = False Then D7108.InchargeInsert = Trim$(rs7108!K7108_InchargeInsert)
            If IsdbNull(rs7108!K7108_InchargeUpdate) = False Then D7108.InchargeUpdate = Trim$(rs7108!K7108_InchargeUpdate)
            If IsdbNull(rs7108!K7108_seSite) = False Then D7108.seSite = Trim$(rs7108!K7108_seSite)
            If IsdbNull(rs7108!K7108_cdSite) = False Then D7108.cdSite = Trim$(rs7108!K7108_cdSite)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7108_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K7108_MOVE(rs7108 As DataRow)
        Try

            Call D7108_CLEAR()

            If IsdbNull(rs7108!K7108_GroupComponentBOM) = False Then D7108.GroupComponentBOM = Trim$(rs7108!K7108_GroupComponentBOM)
            If IsdbNull(rs7108!K7108_ShoesCode) = False Then D7108.ShoesCode = Trim$(rs7108!K7108_ShoesCode)
            If IsdbNull(rs7108!K7108_GroupComponentBOMName) = False Then D7108.GroupComponentBOMName = Trim$(rs7108!K7108_GroupComponentBOMName)
            If IsdbNull(rs7108!K7108_CheckUse) = False Then D7108.CheckUse = Trim$(rs7108!K7108_CheckUse)
            If IsdbNull(rs7108!K7108_ChecComplete) = False Then D7108.ChecComplete = Trim$(rs7108!K7108_ChecComplete)
            If IsdbNull(rs7108!K7108_Remark) = False Then D7108.Remark = Trim$(rs7108!K7108_Remark)
            If IsdbNull(rs7108!K7108_QtyTTL) = False Then D7108.QtyTTL = Trim$(rs7108!K7108_QtyTTL)
            If IsDBNull(rs7108!K7108_InchargeInsert) = False Then D7108.InchargeInsert = Trim$(rs7108!K7108_InchargeInsert)
            If IsdbNull(rs7108!K7108_InchargeUpdate) = False Then D7108.InchargeUpdate = Trim$(rs7108!K7108_InchargeUpdate)
            If IsdbNull(rs7108!K7108_seSite) = False Then D7108.seSite = Trim$(rs7108!K7108_seSite)
            If IsdbNull(rs7108!K7108_cdSite) = False Then D7108.cdSite = Trim$(rs7108!K7108_cdSite)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7108_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K7108_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7108 As T7108_AREA, GROUPCOMPONENTBOM As String) As Boolean

        K7108_MOVE = False

        Try
            If READ_PFK7108(GROUPCOMPONENTBOM) = True Then
                z7108 = D7108
                K7108_MOVE = True
            Else
                z7108 = Nothing
            End If

            If getColumnIndex(spr, "GroupComponentBOM") > -1 Then z7108.GroupComponentBOM = getDataM(spr, getColumnIndex(spr, "GroupComponentBOM"), xRow)
            If getColumnIndex(spr, "ShoesCode") > -1 Then z7108.ShoesCode = getDataM(spr, getColumnIndex(spr, "ShoesCode"), xRow)
            If getColumnIndex(spr, "GroupComponentBOMName") > -1 Then z7108.GroupComponentBOMName = getDataM(spr, getColumnIndex(spr, "GroupComponentBOMName"), xRow)
            If getColumnIndex(spr, "CheckUse") > -1 Then z7108.CheckUse = getDataM(spr, getColumnIndex(spr, "CheckUse"), xRow)
            If getColumnIndex(spr, "ChecComplete") > -1 Then z7108.ChecComplete = getDataM(spr, getColumnIndex(spr, "ChecComplete"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z7108.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "QtyTTL") > -1 Then z7108.QtyTTL = getDataM(spr, getColumnIndex(spr, "QtyTTL"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z7108.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z7108.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z7108.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z7108.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7108_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K7108_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7108 As T7108_AREA, CheckClear As Boolean, GROUPCOMPONENTBOM As String) As Boolean

        K7108_MOVE = False

        Try
            If READ_PFK7108(GROUPCOMPONENTBOM) = True Then
                z7108 = D7108
                K7108_MOVE = True
            Else
                If CheckClear = True Then z7108 = Nothing
            End If

            If getColumnIndex(spr, "GroupComponentBOM") > -1 Then z7108.GroupComponentBOM = getDataM(spr, getColumnIndex(spr, "GroupComponentBOM"), xRow)
            If getColumnIndex(spr, "ShoesCode") > -1 Then z7108.ShoesCode = getDataM(spr, getColumnIndex(spr, "ShoesCode"), xRow)
            If getColumnIndex(spr, "GroupComponentBOMName") > -1 Then z7108.GroupComponentBOMName = getDataM(spr, getColumnIndex(spr, "GroupComponentBOMName"), xRow)
            If getColumnIndex(spr, "CheckUse") > -1 Then z7108.CheckUse = getDataM(spr, getColumnIndex(spr, "CheckUse"), xRow)
            If getColumnIndex(spr, "ChecComplete") > -1 Then z7108.ChecComplete = getDataM(spr, getColumnIndex(spr, "ChecComplete"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z7108.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "QtyTTL") > -1 Then z7108.QtyTTL = getDataM(spr, getColumnIndex(spr, "QtyTTL"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z7108.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z7108.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z7108.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z7108.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7108_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K7108_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7108 As T7108_AREA, Job As String, GROUPCOMPONENTBOM As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7108_MOVE = False

        Try
            If READ_PFK7108(GROUPCOMPONENTBOM) = True Then
                z7108 = D7108
                K7108_MOVE = True
            Else
                z7108 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7108")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "GROUPCOMPONENTBOM" : z7108.GroupComponentBOM = Children(i).Code
                                Case "SHOESCODE" : z7108.ShoesCode = Children(i).Code
                                Case "GROUPCOMPONENTBOMNAME" : z7108.GroupComponentBOMName = Children(i).Code
                                Case "CHECKUSE" : z7108.CheckUse = Children(i).Code
                                Case "CHECCOMPLETE" : z7108.ChecComplete = Children(i).Code
                                Case "REMARK" : z7108.Remark = Children(i).Code
                                Case "QTYTTL" : z7108.QtyTTL = Children(i).Code
                                Case "INCHARGEINSERT" : z7108.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z7108.InchargeUpdate = Children(i).Code
                                Case "SESITE" : z7108.seSite = Children(i).Code
                                Case "CDSITE" : z7108.cdSite = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "GROUPCOMPONENTBOM" : z7108.GroupComponentBOM = Children(i).Data
                                Case "SHOESCODE" : z7108.ShoesCode = Children(i).Data
                                Case "GROUPCOMPONENTBOMNAME" : z7108.GroupComponentBOMName = Children(i).Data
                                Case "CHECKUSE" : z7108.CheckUse = Children(i).Data
                                Case "CHECCOMPLETE" : z7108.ChecComplete = Children(i).Data
                                Case "REMARK" : z7108.Remark = Children(i).Data
                                Case "QTYTTL" : z7108.QtyTTL = Children(i).Data
                                Case "INCHARGEINSERT" : z7108.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z7108.InchargeUpdate = Children(i).Data
                                Case "SESITE" : z7108.seSite = Children(i).Data
                                Case "CDSITE" : z7108.cdSite = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7108_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K7108_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7108 As T7108_AREA, Job As String, CheckClear As Boolean, GROUPCOMPONENTBOM As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7108_MOVE = False

        Try
            If READ_PFK7108(GROUPCOMPONENTBOM) = True Then
                z7108 = D7108
                K7108_MOVE = True
            Else
                If CheckClear = True Then z7108 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7108")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "GROUPCOMPONENTBOM" : z7108.GroupComponentBOM = Children(i).Code
                                Case "SHOESCODE" : z7108.ShoesCode = Children(i).Code
                                Case "GROUPCOMPONENTBOMNAME" : z7108.GroupComponentBOMName = Children(i).Code
                                Case "CHECKUSE" : z7108.CheckUse = Children(i).Code
                                Case "CHECCOMPLETE" : z7108.ChecComplete = Children(i).Code
                                Case "REMARK" : z7108.Remark = Children(i).Code
                                Case "QTYTTL" : z7108.QtyTTL = Children(i).Code
                                Case "INCHARGEINSERT" : z7108.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z7108.InchargeUpdate = Children(i).Code
                                Case "SESITE" : z7108.seSite = Children(i).Code
                                Case "CDSITE" : z7108.cdSite = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "GROUPCOMPONENTBOM" : z7108.GroupComponentBOM = Children(i).Data
                                Case "SHOESCODE" : z7108.ShoesCode = Children(i).Data
                                Case "GROUPCOMPONENTBOMNAME" : z7108.GroupComponentBOMName = Children(i).Data
                                Case "CHECKUSE" : z7108.CheckUse = Children(i).Data
                                Case "CHECCOMPLETE" : z7108.ChecComplete = Children(i).Data
                                Case "REMARK" : z7108.Remark = Children(i).Data
                                Case "QTYTTL" : z7108.QtyTTL = Children(i).Data
                                Case "INCHARGEINSERT" : z7108.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z7108.InchargeUpdate = Children(i).Data
                                Case "SESITE" : z7108.seSite = Children(i).Data
                                Case "CDSITE" : z7108.cdSite = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7108_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW AREA
    '=========================================================================================================================================================
    Public Sub K7108_MOVE(ByRef a7108 As T7108_AREA, ByRef b7108 As T7108_AREA)
        Try
            If trim$(a7108.GroupComponentBOM) = "" Then b7108.GroupComponentBOM = "" Else b7108.GroupComponentBOM = a7108.GroupComponentBOM
            If trim$(a7108.ShoesCode) = "" Then b7108.ShoesCode = "" Else b7108.ShoesCode = a7108.ShoesCode
            If trim$(a7108.GroupComponentBOMName) = "" Then b7108.GroupComponentBOMName = "" Else b7108.GroupComponentBOMName = a7108.GroupComponentBOMName
            If trim$(a7108.CheckUse) = "" Then b7108.CheckUse = "" Else b7108.CheckUse = a7108.CheckUse
            If trim$(a7108.ChecComplete) = "" Then b7108.ChecComplete = "" Else b7108.ChecComplete = a7108.ChecComplete
            If trim$(a7108.Remark) = "" Then b7108.Remark = "" Else b7108.Remark = a7108.Remark
            If trim$(a7108.QtyTTL) = "" Then b7108.QtyTTL = "" Else b7108.QtyTTL = a7108.QtyTTL
            If Trim$(a7108.InchargeInsert) = "" Then b7108.InchargeInsert = "" Else b7108.InchargeInsert = a7108.InchargeInsert
            If trim$(a7108.InchargeUpdate) = "" Then b7108.InchargeUpdate = "" Else b7108.InchargeUpdate = a7108.InchargeUpdate
            If trim$(a7108.seSite) = "" Then b7108.seSite = "" Else b7108.seSite = a7108.seSite
            If trim$(a7108.cdSite) = "" Then b7108.cdSite = "" Else b7108.cdSite = a7108.cdSite
        Catch ex As Exception
            Call MsgBoxP("K7108_MOVE", vbCritical)
        End Try
    End Sub


End Module
