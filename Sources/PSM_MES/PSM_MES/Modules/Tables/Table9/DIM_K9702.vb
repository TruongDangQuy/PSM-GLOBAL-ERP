'=========================================================================================================================================================
'   TABLE : (PFK9702)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9702

    Structure T9702_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public LayoutNo As Long    '			int		*
        Public FormName As String  '			varchar(50)
        Public User As String  '			char(6)
        Public ItemName As String  '			varchar(200)
        Public ControlName As String  '			varchar(200)
        Public ControlData1 As String  '			varchar(200)
        Public ControlData2 As String  '			varchar(200)
        Public ControlData3 As String  '			varchar(200)
        Public ControlData4 As String  '			varchar(200)
        Public Type As String  '			char(1)
        Public DefaultValue1 As String  '			nvarchar(500)
        Public DefaultValue2 As String  '			nvarchar(500)
        Public DefaultValue3 As String  '			nvarchar(500)
        Public CreateDate As String  '			char(8)
        Public Active As String  '			char(1)
        '=========================================================================================================================================================
    End Structure

    Public D9702 As T9702_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK9702(LAYOUTNO As Long) As Boolean
        READ_PFK9702 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9702 "
            SQL = SQL & " WHERE K9702_LayoutNo		 =  " & LayoutNo & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9702_CLEAR() : GoTo SKIP_READ_PFK9702

            Call K9702_MOVE(rd)
            READ_PFK9702 = True

SKIP_READ_PFK9702:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9702", vbCritical)
        End Try
    End Function

    

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK9702(LAYOUTNO As Long, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9702 "
            SQL = SQL & " WHERE K9702_LayoutNo		 =  " & LayoutNo & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK9702", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK9702(z9702 As T9702_AREA) As Boolean
        WRITE_PFK9702 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9702)

            SQL = " INSERT INTO PFK9702 "
            SQL = SQL & " ( "
            SQL = SQL & " K9702_FormName,"
            SQL = SQL & " K9702_User,"
            SQL = SQL & " K9702_ItemName,"
            SQL = SQL & " K9702_ControlName,"
            SQL = SQL & " K9702_ControlData1,"
            SQL = SQL & " K9702_ControlData2,"
            SQL = SQL & " K9702_ControlData3,"
            SQL = SQL & " K9702_ControlData4,"
            SQL = SQL & " K9702_Type,"
            SQL = SQL & " K9702_DefaultValue1,"
            SQL = SQL & " K9702_DefaultValue2,"
            SQL = SQL & " K9702_DefaultValue3,"
            SQL = SQL & " K9702_CreateDate,"
            SQL = SQL & " K9702_Active "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  N'" & FormatSQL(z9702.FormName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9702.User) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9702.ItemName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9702.ControlName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9702.ControlData1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9702.ControlData2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9702.ControlData3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9702.ControlData4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9702.Type) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9702.DefaultValue1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9702.DefaultValue2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9702.DefaultValue3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9702.CreateDate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9702.Active) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK9702 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK9702", vbCritical)
        Finally
            Call GetFullInformation("PFK9702", "I", SQL)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK9702(z9702 As T9702_AREA) As Boolean
        REWRITE_PFK9702 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9702)

            SQL = " UPDATE PFK9702 SET "
            SQL = SQL & "    K9702_FormName      = N'" & FormatSQL(z9702.FormName) & "', "
            SQL = SQL & "    K9702_User      = N'" & FormatSQL(z9702.User) & "', "
            SQL = SQL & "    K9702_ItemName      = N'" & FormatSQL(z9702.ItemName) & "', "
            SQL = SQL & "    K9702_ControlName      = N'" & FormatSQL(z9702.ControlName) & "', "
            SQL = SQL & "    K9702_ControlData1      = N'" & FormatSQL(z9702.ControlData1) & "', "
            SQL = SQL & "    K9702_ControlData2      = N'" & FormatSQL(z9702.ControlData2) & "', "
            SQL = SQL & "    K9702_ControlData3      = N'" & FormatSQL(z9702.ControlData3) & "', "
            SQL = SQL & "    K9702_ControlData4      = N'" & FormatSQL(z9702.ControlData4) & "', "
            SQL = SQL & "    K9702_Type      = N'" & FormatSQL(z9702.Type) & "', "
            SQL = SQL & "    K9702_DefaultValue1      = N'" & FormatSQL(z9702.DefaultValue1) & "', "
            SQL = SQL & "    K9702_DefaultValue2      = N'" & FormatSQL(z9702.DefaultValue2) & "', "
            SQL = SQL & "    K9702_DefaultValue3      = N'" & FormatSQL(z9702.DefaultValue3) & "', "
            SQL = SQL & "    K9702_CreateDate      = N'" & FormatSQL(z9702.CreateDate) & "', "
            SQL = SQL & "    K9702_Active      = N'" & FormatSQL(z9702.Active) & "'  "
            SQL = SQL & " WHERE K9702_LayoutNo		 =  " & z9702.LayoutNo & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK9702 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK9702", vbCritical)
        Finally
            Call GetFullInformation("PFK9702", "U", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK9702(z9702 As T9702_AREA) As Boolean
        DELETE_PFK9702 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK9702 "
            SQL = SQL & " WHERE K9702_LayoutNo		 =  " & z9702.LayoutNo & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK9702 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK9702", vbCritical)
        Finally
            Call GetFullInformation("PFK9702", "D", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D9702_CLEAR()
        Try

            D9702.LayoutNo = 0
            D9702.FormName = ""
            D9702.User = ""
            D9702.ItemName = ""
            D9702.ControlName = ""
            D9702.ControlData1 = ""
            D9702.ControlData2 = ""
            D9702.ControlData3 = ""
            D9702.ControlData4 = ""
            D9702.Type = ""
            D9702.DefaultValue1 = ""
            D9702.DefaultValue2 = ""
            D9702.DefaultValue3 = ""
            D9702.CreateDate = ""
            D9702.Active = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D9702_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x9702 As T9702_AREA)
        Try

            x9702.LayoutNo = trim$(x9702.LayoutNo)
            x9702.FormName = Trim$(x9702.FormName)
            x9702.User = trim$(x9702.User)
            x9702.ItemName = trim$(x9702.ItemName)
            x9702.ControlName = trim$(x9702.ControlName)
            x9702.ControlData1 = trim$(x9702.ControlData1)
            x9702.ControlData2 = trim$(x9702.ControlData2)
            x9702.ControlData3 = trim$(x9702.ControlData3)
            x9702.ControlData4 = trim$(x9702.ControlData4)
            x9702.Type = trim$(x9702.Type)
            x9702.DefaultValue1 = trim$(x9702.DefaultValue1)
            x9702.DefaultValue2 = trim$(x9702.DefaultValue2)
            x9702.DefaultValue3 = trim$(x9702.DefaultValue3)
            x9702.CreateDate = trim$(x9702.CreateDate)
            x9702.Active = trim$(x9702.Active)

            If trim$(x9702.LayoutNo) = "" Then x9702.LayoutNo = 0
            If Trim$(x9702.FormName) = "" Then x9702.FormName = Space(1)
            If trim$(x9702.User) = "" Then x9702.User = Space(1)
            If trim$(x9702.ItemName) = "" Then x9702.ItemName = Space(1)
            If trim$(x9702.ControlName) = "" Then x9702.ControlName = Space(1)
            If trim$(x9702.ControlData1) = "" Then x9702.ControlData1 = Space(1)
            If trim$(x9702.ControlData2) = "" Then x9702.ControlData2 = Space(1)
            If trim$(x9702.ControlData3) = "" Then x9702.ControlData3 = Space(1)
            If trim$(x9702.ControlData4) = "" Then x9702.ControlData4 = Space(1)
            If trim$(x9702.Type) = "" Then x9702.Type = Space(1)
            If trim$(x9702.DefaultValue1) = "" Then x9702.DefaultValue1 = Space(1)
            If trim$(x9702.DefaultValue2) = "" Then x9702.DefaultValue2 = Space(1)
            If trim$(x9702.DefaultValue3) = "" Then x9702.DefaultValue3 = Space(1)
            If trim$(x9702.CreateDate) = "" Then x9702.CreateDate = Space(1)
            If trim$(x9702.Active) = "" Then x9702.Active = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K9702_MOVE(rs9702 As SqlClient.SqlDataReader)
        Try

            Call D9702_CLEAR()

            If IsdbNull(rs9702!K9702_LayoutNo) = False Then D9702.LayoutNo = Trim$(rs9702!K9702_LayoutNo)
            If IsDBNull(rs9702!K9702_FormName) = False Then D9702.FormName = Trim$(rs9702!K9702_FormName)
            If IsdbNull(rs9702!K9702_User) = False Then D9702.User = Trim$(rs9702!K9702_User)
            If IsdbNull(rs9702!K9702_ItemName) = False Then D9702.ItemName = Trim$(rs9702!K9702_ItemName)
            If IsdbNull(rs9702!K9702_ControlName) = False Then D9702.ControlName = Trim$(rs9702!K9702_ControlName)
            If IsdbNull(rs9702!K9702_ControlData1) = False Then D9702.ControlData1 = Trim$(rs9702!K9702_ControlData1)
            If IsdbNull(rs9702!K9702_ControlData2) = False Then D9702.ControlData2 = Trim$(rs9702!K9702_ControlData2)
            If IsdbNull(rs9702!K9702_ControlData3) = False Then D9702.ControlData3 = Trim$(rs9702!K9702_ControlData3)
            If IsdbNull(rs9702!K9702_ControlData4) = False Then D9702.ControlData4 = Trim$(rs9702!K9702_ControlData4)
            If IsdbNull(rs9702!K9702_Type) = False Then D9702.Type = Trim$(rs9702!K9702_Type)
            If IsdbNull(rs9702!K9702_DefaultValue1) = False Then D9702.DefaultValue1 = Trim$(rs9702!K9702_DefaultValue1)
            If IsdbNull(rs9702!K9702_DefaultValue2) = False Then D9702.DefaultValue2 = Trim$(rs9702!K9702_DefaultValue2)
            If IsdbNull(rs9702!K9702_DefaultValue3) = False Then D9702.DefaultValue3 = Trim$(rs9702!K9702_DefaultValue3)
            If IsdbNull(rs9702!K9702_CreateDate) = False Then D9702.CreateDate = Trim$(rs9702!K9702_CreateDate)
            If IsdbNull(rs9702!K9702_Active) = False Then D9702.Active = Trim$(rs9702!K9702_Active)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9702_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K9702_MOVE(rs9702 As DataRow)
        Try

            Call D9702_CLEAR()

            If IsdbNull(rs9702!K9702_LayoutNo) = False Then D9702.LayoutNo = Trim$(rs9702!K9702_LayoutNo)
            If IsDBNull(rs9702!K9702_FormName) = False Then D9702.FormName = Trim$(rs9702!K9702_FormName)
            If IsdbNull(rs9702!K9702_User) = False Then D9702.User = Trim$(rs9702!K9702_User)
            If IsdbNull(rs9702!K9702_ItemName) = False Then D9702.ItemName = Trim$(rs9702!K9702_ItemName)
            If IsdbNull(rs9702!K9702_ControlName) = False Then D9702.ControlName = Trim$(rs9702!K9702_ControlName)
            If IsdbNull(rs9702!K9702_ControlData1) = False Then D9702.ControlData1 = Trim$(rs9702!K9702_ControlData1)
            If IsdbNull(rs9702!K9702_ControlData2) = False Then D9702.ControlData2 = Trim$(rs9702!K9702_ControlData2)
            If IsdbNull(rs9702!K9702_ControlData3) = False Then D9702.ControlData3 = Trim$(rs9702!K9702_ControlData3)
            If IsdbNull(rs9702!K9702_ControlData4) = False Then D9702.ControlData4 = Trim$(rs9702!K9702_ControlData4)
            If IsdbNull(rs9702!K9702_Type) = False Then D9702.Type = Trim$(rs9702!K9702_Type)
            If IsdbNull(rs9702!K9702_DefaultValue1) = False Then D9702.DefaultValue1 = Trim$(rs9702!K9702_DefaultValue1)
            If IsdbNull(rs9702!K9702_DefaultValue2) = False Then D9702.DefaultValue2 = Trim$(rs9702!K9702_DefaultValue2)
            If IsdbNull(rs9702!K9702_DefaultValue3) = False Then D9702.DefaultValue3 = Trim$(rs9702!K9702_DefaultValue3)
            If IsdbNull(rs9702!K9702_CreateDate) = False Then D9702.CreateDate = Trim$(rs9702!K9702_CreateDate)
            If IsdbNull(rs9702!K9702_Active) = False Then D9702.Active = Trim$(rs9702!K9702_Active)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9702_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K9702_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9702 As T9702_AREA, LAYOUTNO As Long) As Boolean

        K9702_MOVE = False

        Try
            If READ_PFK9702(LAYOUTNO) = True Then
                z9702 = D9702
                K9702_MOVE = True
            Else
                z9702 = Nothing
            End If

            If getColumnIndex(spr, "LayoutNo") > -1 Then z9702.LayoutNo = getDataM(spr, getColumnIndex(spr, "LayoutNo"), xRow)
            If getColumnIndex(spr, "FormName") > -1 Then z9702.FormName = getDataM(spr, getColumnIndex(spr, "FormName"), xRow)
            If getColumnIndex(spr, "User") > -1 Then z9702.User = getDataM(spr, getColumnIndex(spr, "User"), xRow)
            If getColumnIndex(spr, "ItemName") > -1 Then z9702.ItemName = getDataM(spr, getColumnIndex(spr, "ItemName"), xRow)
            If getColumnIndex(spr, "ControlName") > -1 Then z9702.ControlName = getDataM(spr, getColumnIndex(spr, "ControlName"), xRow)
            If getColumnIndex(spr, "ControlData1") > -1 Then z9702.ControlData1 = getDataM(spr, getColumnIndex(spr, "ControlData1"), xRow)
            If getColumnIndex(spr, "ControlData2") > -1 Then z9702.ControlData2 = getDataM(spr, getColumnIndex(spr, "ControlData2"), xRow)
            If getColumnIndex(spr, "ControlData3") > -1 Then z9702.ControlData3 = getDataM(spr, getColumnIndex(spr, "ControlData3"), xRow)
            If getColumnIndex(spr, "ControlData4") > -1 Then z9702.ControlData4 = getDataM(spr, getColumnIndex(spr, "ControlData4"), xRow)
            If getColumnIndex(spr, "Type") > -1 Then z9702.Type = getDataM(spr, getColumnIndex(spr, "Type"), xRow)
            If getColumnIndex(spr, "DefaultValue1") > -1 Then z9702.DefaultValue1 = getDataM(spr, getColumnIndex(spr, "DefaultValue1"), xRow)
            If getColumnIndex(spr, "DefaultValue2") > -1 Then z9702.DefaultValue2 = getDataM(spr, getColumnIndex(spr, "DefaultValue2"), xRow)
            If getColumnIndex(spr, "DefaultValue3") > -1 Then z9702.DefaultValue3 = getDataM(spr, getColumnIndex(spr, "DefaultValue3"), xRow)
            If getColumnIndex(spr, "CreateDate") > -1 Then z9702.CreateDate = getDataM(spr, getColumnIndex(spr, "CreateDate"), xRow)
            If getColumnIndex(spr, "Active") > -1 Then z9702.Active = getDataM(spr, getColumnIndex(spr, "Active"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9702_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K9702_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9702 As T9702_AREA, CheckClear As Boolean, LAYOUTNO As Long) As Boolean

        K9702_MOVE = False

        Try
            If READ_PFK9702(LAYOUTNO) = True Then
                z9702 = D9702
                K9702_MOVE = True
            Else
                If CheckClear = True Then z9702 = Nothing
            End If

            If getColumnIndex(spr, "LayoutNo") > -1 Then z9702.LayoutNo = getDataM(spr, getColumnIndex(spr, "LayoutNo"), xRow)
            If getColumnIndex(spr, "FormName") > -1 Then z9702.FormName = getDataM(spr, getColumnIndex(spr, "FormName"), xRow)
            If getColumnIndex(spr, "User") > -1 Then z9702.User = getDataM(spr, getColumnIndex(spr, "User"), xRow)
            If getColumnIndex(spr, "ItemName") > -1 Then z9702.ItemName = getDataM(spr, getColumnIndex(spr, "ItemName"), xRow)
            If getColumnIndex(spr, "ControlName") > -1 Then z9702.ControlName = getDataM(spr, getColumnIndex(spr, "ControlName"), xRow)
            If getColumnIndex(spr, "ControlData1") > -1 Then z9702.ControlData1 = getDataM(spr, getColumnIndex(spr, "ControlData1"), xRow)
            If getColumnIndex(spr, "ControlData2") > -1 Then z9702.ControlData2 = getDataM(spr, getColumnIndex(spr, "ControlData2"), xRow)
            If getColumnIndex(spr, "ControlData3") > -1 Then z9702.ControlData3 = getDataM(spr, getColumnIndex(spr, "ControlData3"), xRow)
            If getColumnIndex(spr, "ControlData4") > -1 Then z9702.ControlData4 = getDataM(spr, getColumnIndex(spr, "ControlData4"), xRow)
            If getColumnIndex(spr, "Type") > -1 Then z9702.Type = getDataM(spr, getColumnIndex(spr, "Type"), xRow)
            If getColumnIndex(spr, "DefaultValue1") > -1 Then z9702.DefaultValue1 = getDataM(spr, getColumnIndex(spr, "DefaultValue1"), xRow)
            If getColumnIndex(spr, "DefaultValue2") > -1 Then z9702.DefaultValue2 = getDataM(spr, getColumnIndex(spr, "DefaultValue2"), xRow)
            If getColumnIndex(spr, "DefaultValue3") > -1 Then z9702.DefaultValue3 = getDataM(spr, getColumnIndex(spr, "DefaultValue3"), xRow)
            If getColumnIndex(spr, "CreateDate") > -1 Then z9702.CreateDate = getDataM(spr, getColumnIndex(spr, "CreateDate"), xRow)
            If getColumnIndex(spr, "Active") > -1 Then z9702.Active = getDataM(spr, getColumnIndex(spr, "Active"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9702_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K9702_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9702 As T9702_AREA, Job As String, LAYOUTNO As Long) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9702_MOVE = False

        Try
            If READ_PFK9702(LAYOUTNO) = True Then
                z9702 = D9702
                K9702_MOVE = True
            Else
                z9702 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9702")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "LAYOUTNO" : z9702.LayoutNo = Children(i).Code
                                Case "FormName" : z9702.FormName = Children(i).Code
                                Case "USER" : z9702.User = Children(i).Code
                                Case "ITEMNAME" : z9702.ItemName = Children(i).Code
                                Case "CONTROLNAME" : z9702.ControlName = Children(i).Code
                                Case "CONTROLDATA1" : z9702.ControlData1 = Children(i).Code
                                Case "CONTROLDATA2" : z9702.ControlData2 = Children(i).Code
                                Case "CONTROLDATA3" : z9702.ControlData3 = Children(i).Code
                                Case "CONTROLDATA4" : z9702.ControlData4 = Children(i).Code
                                Case "TYPE" : z9702.Type = Children(i).Code
                                Case "DEFAULTVALUE1" : z9702.DefaultValue1 = Children(i).Code
                                Case "DEFAULTVALUE2" : z9702.DefaultValue2 = Children(i).Code
                                Case "DEFAULTVALUE3" : z9702.DefaultValue3 = Children(i).Code
                                Case "CREATEDATE" : z9702.CreateDate = Children(i).Code
                                Case "ACTIVE" : z9702.Active = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "LAYOUTNO" : z9702.LayoutNo = Children(i).Data
                                Case "FormName" : z9702.FormName = Children(i).Data
                                Case "USER" : z9702.User = Children(i).Data
                                Case "ITEMNAME" : z9702.ItemName = Children(i).Data
                                Case "CONTROLNAME" : z9702.ControlName = Children(i).Data
                                Case "CONTROLDATA1" : z9702.ControlData1 = Children(i).Data
                                Case "CONTROLDATA2" : z9702.ControlData2 = Children(i).Data
                                Case "CONTROLDATA3" : z9702.ControlData3 = Children(i).Data
                                Case "CONTROLDATA4" : z9702.ControlData4 = Children(i).Data
                                Case "TYPE" : z9702.Type = Children(i).Data
                                Case "DEFAULTVALUE1" : z9702.DefaultValue1 = Children(i).Data
                                Case "DEFAULTVALUE2" : z9702.DefaultValue2 = Children(i).Data
                                Case "DEFAULTVALUE3" : z9702.DefaultValue3 = Children(i).Data
                                Case "CREATEDATE" : z9702.CreateDate = Children(i).Data
                                Case "ACTIVE" : z9702.Active = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9702_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K9702_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9702 As T9702_AREA, Job As String, CheckClear As Boolean, LAYOUTNO As Long) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9702_MOVE = False

        Try
            If READ_PFK9702(LAYOUTNO) = True Then
                z9702 = D9702
                K9702_MOVE = True
            Else
                If CheckClear = True Then z9702 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9702")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "LAYOUTNO" : z9702.LayoutNo = Children(i).Code
                                Case "FormName" : z9702.FormName = Children(i).Code
                                Case "USER" : z9702.User = Children(i).Code
                                Case "ITEMNAME" : z9702.ItemName = Children(i).Code
                                Case "CONTROLNAME" : z9702.ControlName = Children(i).Code
                                Case "CONTROLDATA1" : z9702.ControlData1 = Children(i).Code
                                Case "CONTROLDATA2" : z9702.ControlData2 = Children(i).Code
                                Case "CONTROLDATA3" : z9702.ControlData3 = Children(i).Code
                                Case "CONTROLDATA4" : z9702.ControlData4 = Children(i).Code
                                Case "TYPE" : z9702.Type = Children(i).Code
                                Case "DEFAULTVALUE1" : z9702.DefaultValue1 = Children(i).Code
                                Case "DEFAULTVALUE2" : z9702.DefaultValue2 = Children(i).Code
                                Case "DEFAULTVALUE3" : z9702.DefaultValue3 = Children(i).Code
                                Case "CREATEDATE" : z9702.CreateDate = Children(i).Code
                                Case "ACTIVE" : z9702.Active = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "LAYOUTNO" : z9702.LayoutNo = Children(i).Data
                                Case "FormName" : z9702.FormName = Children(i).Data
                                Case "USER" : z9702.User = Children(i).Data
                                Case "ITEMNAME" : z9702.ItemName = Children(i).Data
                                Case "CONTROLNAME" : z9702.ControlName = Children(i).Data
                                Case "CONTROLDATA1" : z9702.ControlData1 = Children(i).Data
                                Case "CONTROLDATA2" : z9702.ControlData2 = Children(i).Data
                                Case "CONTROLDATA3" : z9702.ControlData3 = Children(i).Data
                                Case "CONTROLDATA4" : z9702.ControlData4 = Children(i).Data
                                Case "TYPE" : z9702.Type = Children(i).Data
                                Case "DEFAULTVALUE1" : z9702.DefaultValue1 = Children(i).Data
                                Case "DEFAULTVALUE2" : z9702.DefaultValue2 = Children(i).Data
                                Case "DEFAULTVALUE3" : z9702.DefaultValue3 = Children(i).Data
                                Case "CREATEDATE" : z9702.CreateDate = Children(i).Data
                                Case "ACTIVE" : z9702.Active = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9702_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW AREA
    '=========================================================================================================================================================
    Public Sub K9702_MOVE(ByRef a9702 As T9702_AREA, ByRef b9702 As T9702_AREA)
        Try
            If trim$(a9702.LayoutNo) = "" Then b9702.LayoutNo = "" Else b9702.LayoutNo = a9702.LayoutNo
            If Trim$(a9702.FormName) = "" Then b9702.FormName = "" Else b9702.FormName = a9702.FormName
            If trim$(a9702.User) = "" Then b9702.User = "" Else b9702.User = a9702.User
            If trim$(a9702.ItemName) = "" Then b9702.ItemName = "" Else b9702.ItemName = a9702.ItemName
            If trim$(a9702.ControlName) = "" Then b9702.ControlName = "" Else b9702.ControlName = a9702.ControlName
            If trim$(a9702.ControlData1) = "" Then b9702.ControlData1 = "" Else b9702.ControlData1 = a9702.ControlData1
            If trim$(a9702.ControlData2) = "" Then b9702.ControlData2 = "" Else b9702.ControlData2 = a9702.ControlData2
            If trim$(a9702.ControlData3) = "" Then b9702.ControlData3 = "" Else b9702.ControlData3 = a9702.ControlData3
            If trim$(a9702.ControlData4) = "" Then b9702.ControlData4 = "" Else b9702.ControlData4 = a9702.ControlData4
            If trim$(a9702.Type) = "" Then b9702.Type = "" Else b9702.Type = a9702.Type
            If trim$(a9702.DefaultValue1) = "" Then b9702.DefaultValue1 = "" Else b9702.DefaultValue1 = a9702.DefaultValue1
            If trim$(a9702.DefaultValue2) = "" Then b9702.DefaultValue2 = "" Else b9702.DefaultValue2 = a9702.DefaultValue2
            If trim$(a9702.DefaultValue3) = "" Then b9702.DefaultValue3 = "" Else b9702.DefaultValue3 = a9702.DefaultValue3
            If trim$(a9702.CreateDate) = "" Then b9702.CreateDate = "" Else b9702.CreateDate = a9702.CreateDate
            If trim$(a9702.Active) = "" Then b9702.Active = "" Else b9702.Active = a9702.Active
        Catch ex As Exception
            Call MsgBoxP("K9702_MOVE", vbCritical)
        End Try
    End Sub


End Module
