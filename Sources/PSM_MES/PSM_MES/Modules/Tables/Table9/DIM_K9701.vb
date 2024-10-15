'=========================================================================================================================================================
'   TABLE : (PFK9701)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9701

    Structure T9701_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public FormName As String  '			varchar(50)		*
        Public User As String  '			char(6)		*
        Public GroupUser As String  '			char(3)		*
        Public Version As String  '			varchar(20)		*
        Public Data As String  '			varchar(-1)
        Public Remark As String  '			nvarchar(500)
        Public DateCreate As String  '			char(8)
        '=========================================================================================================================================================
    End Structure

    Public D9701 As T9701_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK9701(FORMNAME As String, USER As String, GROUPUSER As String, VERSION As String) As Boolean
        READ_PFK9701 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9701 "
            SQL = SQL & " WHERE K9701_FormName		 = '" & FormName & "' "
            SQL = SQL & "   AND K9701_User		 = '" & User & "' "
            SQL = SQL & "   AND K9701_GroupUser		 = '" & GroupUser & "' "
            SQL = SQL & "   AND K9701_Version		 = '" & Version & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9701_CLEAR() : GoTo SKIP_READ_PFK9701

            Call K9701_MOVE(rd)
            READ_PFK9701 = True

SKIP_READ_PFK9701:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9701", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK9701(FORMNAME As String, USER As String, GROUPUSER As String, VERSION As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9701 "
            SQL = SQL & " WHERE K9701_FormName		 = '" & FormName & "' "
            SQL = SQL & "   AND K9701_User		 = '" & User & "' "
            SQL = SQL & "   AND K9701_GroupUser		 = '" & GroupUser & "' "
            SQL = SQL & "   AND K9701_Version		 = '" & Version & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK9701", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK9701(z9701 As T9701_AREA) As Boolean
        WRITE_PFK9701 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9701)

            SQL = " INSERT INTO PFK9701 "
            SQL = SQL & " ( "
            SQL = SQL & " K9701_FormName,"
            SQL = SQL & " K9701_User,"
            SQL = SQL & " K9701_GroupUser,"
            SQL = SQL & " K9701_Version,"
            SQL = SQL & " K9701_Data,"
            SQL = SQL & " K9701_Remark,"
            SQL = SQL & " K9701_DateCreate "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z9701.FormName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9701.User) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9701.GroupUser) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9701.Version) & "', "
            SQL = SQL & "  N'" & z9701.Data & "', "
            SQL = SQL & "  N'" & FormatSQL(z9701.Remark) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9701.DateCreate) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK9701 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK9701", vbCritical)
        Finally
            Call GetFullInformation("PFK9701", "I", SQL)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK9701(z9701 As T9701_AREA) As Boolean
        REWRITE_PFK9701 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9701)

            SQL = " UPDATE PFK9701 SET "
            SQL = SQL & "    K9701_Data      = N'" & z9701.Data & "', "
            SQL = SQL & "    K9701_Remark      = N'" & FormatSQL(z9701.Remark) & "', "
            SQL = SQL & "    K9701_DateCreate      = N'" & FormatSQL(z9701.DateCreate) & "'  "
            SQL = SQL & " WHERE K9701_FormName		 = '" & z9701.FormName & "' "
            SQL = SQL & "   AND K9701_User		 = '" & z9701.User & "' "
            SQL = SQL & "   AND K9701_GroupUser		 = '" & z9701.GroupUser & "' "
            SQL = SQL & "   AND K9701_Version		 = '" & z9701.Version & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK9701 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK9701", vbCritical)
        Finally
            Call GetFullInformation("PFK9701", "U", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK9701(z9701 As T9701_AREA) As Boolean
        DELETE_PFK9701 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK9701 "
            SQL = SQL & " WHERE K9701_FormName		 = '" & z9701.FormName & "' "
            SQL = SQL & "   AND K9701_User		 = '" & z9701.User & "' "
            SQL = SQL & "   AND K9701_GroupUser		 = '" & z9701.GroupUser & "' "
            SQL = SQL & "   AND K9701_Version		 = '" & z9701.Version & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK9701 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK9701", vbCritical)
        Finally
            Call GetFullInformation("PFK9701", "D", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D9701_CLEAR()
        Try

            D9701.FormName = ""
            D9701.User = ""
            D9701.GroupUser = ""
            D9701.Version = ""
            D9701.Data = ""
            D9701.Remark = ""
            D9701.DateCreate = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D9701_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x9701 As T9701_AREA)
        Try

            x9701.FormName = trim$(x9701.FormName)
            x9701.User = trim$(x9701.User)
            x9701.GroupUser = trim$(x9701.GroupUser)
            x9701.Version = trim$(x9701.Version)
            x9701.Data = trim$(x9701.Data)
            x9701.Remark = trim$(x9701.Remark)
            x9701.DateCreate = trim$(x9701.DateCreate)

            If trim$(x9701.FormName) = "" Then x9701.FormName = Space(1)
            If trim$(x9701.User) = "" Then x9701.User = Space(1)
            If trim$(x9701.GroupUser) = "" Then x9701.GroupUser = Space(1)
            If trim$(x9701.Version) = "" Then x9701.Version = Space(1)
            If trim$(x9701.Data) = "" Then x9701.Data = Space(1)
            If trim$(x9701.Remark) = "" Then x9701.Remark = Space(1)
            If trim$(x9701.DateCreate) = "" Then x9701.DateCreate = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K9701_MOVE(rs9701 As SqlClient.SqlDataReader)
        Try

            Call D9701_CLEAR()

            If IsdbNull(rs9701!K9701_FormName) = False Then D9701.FormName = Trim$(rs9701!K9701_FormName)
            If IsdbNull(rs9701!K9701_User) = False Then D9701.User = Trim$(rs9701!K9701_User)
            If IsdbNull(rs9701!K9701_GroupUser) = False Then D9701.GroupUser = Trim$(rs9701!K9701_GroupUser)
            If IsdbNull(rs9701!K9701_Version) = False Then D9701.Version = Trim$(rs9701!K9701_Version)
            If IsdbNull(rs9701!K9701_Data) = False Then D9701.Data = Trim$(rs9701!K9701_Data)
            If IsdbNull(rs9701!K9701_Remark) = False Then D9701.Remark = Trim$(rs9701!K9701_Remark)
            If IsdbNull(rs9701!K9701_DateCreate) = False Then D9701.DateCreate = Trim$(rs9701!K9701_DateCreate)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9701_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K9701_MOVE(rs9701 As DataRow)
        Try

            Call D9701_CLEAR()

            If IsdbNull(rs9701!K9701_FormName) = False Then D9701.FormName = Trim$(rs9701!K9701_FormName)
            If IsdbNull(rs9701!K9701_User) = False Then D9701.User = Trim$(rs9701!K9701_User)
            If IsdbNull(rs9701!K9701_GroupUser) = False Then D9701.GroupUser = Trim$(rs9701!K9701_GroupUser)
            If IsdbNull(rs9701!K9701_Version) = False Then D9701.Version = Trim$(rs9701!K9701_Version)
            If IsdbNull(rs9701!K9701_Data) = False Then D9701.Data = Trim$(rs9701!K9701_Data)
            If IsdbNull(rs9701!K9701_Remark) = False Then D9701.Remark = Trim$(rs9701!K9701_Remark)
            If IsdbNull(rs9701!K9701_DateCreate) = False Then D9701.DateCreate = Trim$(rs9701!K9701_DateCreate)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9701_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K9701_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9701 As T9701_AREA, FORMNAME As String, USER As String, GROUPUSER As String, VERSION As String) As Boolean

        K9701_MOVE = False

        Try
            If READ_PFK9701(FORMNAME, USER, GROUPUSER, VERSION) = True Then
                z9701 = D9701
                K9701_MOVE = True
            Else
                z9701 = Nothing
            End If

            If getColumnIndex(spr, "FormName") > -1 Then z9701.FormName = getDataM(spr, getColumnIndex(spr, "FormName"), xRow)
            If getColumnIndex(spr, "User") > -1 Then z9701.User = getDataM(spr, getColumnIndex(spr, "User"), xRow)
            If getColumnIndex(spr, "GroupUser") > -1 Then z9701.GroupUser = getDataM(spr, getColumnIndex(spr, "GroupUser"), xRow)
            If getColumnIndex(spr, "Version") > -1 Then z9701.Version = getDataM(spr, getColumnIndex(spr, "Version"), xRow)
            If getColumnIndex(spr, "Data") > -1 Then z9701.Data = getDataM(spr, getColumnIndex(spr, "Data"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z9701.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "DateCreate") > -1 Then z9701.DateCreate = getDataM(spr, getColumnIndex(spr, "DateCreate"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9701_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K9701_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9701 As T9701_AREA, CheckClear As Boolean, FORMNAME As String, USER As String, GROUPUSER As String, VERSION As String) As Boolean

        K9701_MOVE = False

        Try
            If READ_PFK9701(FORMNAME, USER, GROUPUSER, VERSION) = True Then
                z9701 = D9701
                K9701_MOVE = True
            Else
                If CheckClear = True Then z9701 = Nothing
            End If

            If getColumnIndex(spr, "FormName") > -1 Then z9701.FormName = getDataM(spr, getColumnIndex(spr, "FormName"), xRow)
            If getColumnIndex(spr, "User") > -1 Then z9701.User = getDataM(spr, getColumnIndex(spr, "User"), xRow)
            If getColumnIndex(spr, "GroupUser") > -1 Then z9701.GroupUser = getDataM(spr, getColumnIndex(spr, "GroupUser"), xRow)
            If getColumnIndex(spr, "Version") > -1 Then z9701.Version = getDataM(spr, getColumnIndex(spr, "Version"), xRow)
            If getColumnIndex(spr, "Data") > -1 Then z9701.Data = getDataM(spr, getColumnIndex(spr, "Data"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z9701.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "DateCreate") > -1 Then z9701.DateCreate = getDataM(spr, getColumnIndex(spr, "DateCreate"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9701_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K9701_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9701 As T9701_AREA, Job As String, FORMNAME As String, USER As String, GROUPUSER As String, VERSION As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9701_MOVE = False

        Try
            If READ_PFK9701(FORMNAME, USER, GROUPUSER, VERSION) = True Then
                z9701 = D9701
                K9701_MOVE = True
            Else
                z9701 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9701")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "FORMNAME" : z9701.FormName = Children(i).Code
                                Case "USER" : z9701.User = Children(i).Code
                                Case "GROUPUSER" : z9701.GroupUser = Children(i).Code
                                Case "VERSION" : z9701.Version = Children(i).Code
                                Case "DATA" : z9701.Data = Children(i).Code
                                Case "REMARK" : z9701.Remark = Children(i).Code
                                Case "DATECREATE" : z9701.DateCreate = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "FORMNAME" : z9701.FormName = Children(i).Data
                                Case "USER" : z9701.User = Children(i).Data
                                Case "GROUPUSER" : z9701.GroupUser = Children(i).Data
                                Case "VERSION" : z9701.Version = Children(i).Data
                                Case "DATA" : z9701.Data = Children(i).Data
                                Case "REMARK" : z9701.Remark = Children(i).Data
                                Case "DATECREATE" : z9701.DateCreate = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9701_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K9701_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9701 As T9701_AREA, Job As String, CheckClear As Boolean, FORMNAME As String, USER As String, GROUPUSER As String, VERSION As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9701_MOVE = False

        Try
            If READ_PFK9701(FORMNAME, USER, GROUPUSER, VERSION) = True Then
                z9701 = D9701
                K9701_MOVE = True
            Else
                If CheckClear = True Then z9701 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9701")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "FORMNAME" : z9701.FormName = Children(i).Code
                                Case "USER" : z9701.User = Children(i).Code
                                Case "GROUPUSER" : z9701.GroupUser = Children(i).Code
                                Case "VERSION" : z9701.Version = Children(i).Code
                                Case "DATA" : z9701.Data = Children(i).Code
                                Case "REMARK" : z9701.Remark = Children(i).Code
                                Case "DATECREATE" : z9701.DateCreate = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "FORMNAME" : z9701.FormName = Children(i).Data
                                Case "USER" : z9701.User = Children(i).Data
                                Case "GROUPUSER" : z9701.GroupUser = Children(i).Data
                                Case "VERSION" : z9701.Version = Children(i).Data
                                Case "DATA" : z9701.Data = Children(i).Data
                                Case "REMARK" : z9701.Remark = Children(i).Data
                                Case "DATECREATE" : z9701.DateCreate = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9701_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW AREA
    '=========================================================================================================================================================
    Public Sub K9701_MOVE(ByRef a9701 As T9701_AREA, ByRef b9701 As T9701_AREA)
        Try
            If trim$(a9701.FormName) = "" Then b9701.FormName = "" Else b9701.FormName = a9701.FormName
            If trim$(a9701.User) = "" Then b9701.User = "" Else b9701.User = a9701.User
            If trim$(a9701.GroupUser) = "" Then b9701.GroupUser = "" Else b9701.GroupUser = a9701.GroupUser
            If trim$(a9701.Version) = "" Then b9701.Version = "" Else b9701.Version = a9701.Version
            If trim$(a9701.Data) = "" Then b9701.Data = "" Else b9701.Data = a9701.Data
            If trim$(a9701.Remark) = "" Then b9701.Remark = "" Else b9701.Remark = a9701.Remark
            If trim$(a9701.DateCreate) = "" Then b9701.DateCreate = "" Else b9701.DateCreate = a9701.DateCreate
        Catch ex As Exception
            Call MsgBoxP("K9701_MOVE", vbCritical)
        End Try
    End Sub


End Module
