'=========================================================================================================================================================
'   TABLE : (PFK9706)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9706

    Structure T9706_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public LayoutNoRef As Long    '			int		*
        Public FormName As String  '			varchar(50)		*
        Public GroupUser As String  '			char(3)		*
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

    Public D9706 As T9706_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK9706(LAYOUTNOREF As Long, FormName As String, GROUPUSER As String) As Boolean
        READ_PFK9706 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9706 "
            SQL = SQL & " WHERE K9706_LayoutNoRef		 =  " & LayoutNoRef & "  "
            SQL = SQL & "   AND K9706_FormName		 = '" & FormName & "' "
            SQL = SQL & "   AND K9706_GroupUser		 = '" & GroupUser & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9706_CLEAR() : GoTo SKIP_READ_PFK9706

            Call K9706_MOVE(rd)
            READ_PFK9706 = True

SKIP_READ_PFK9706:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9706", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK9706(LAYOUTNOREF As Long, FormName As String, GROUPUSER As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9706 "
            SQL = SQL & " WHERE K9706_LayoutNoRef		 =  " & LayoutNoRef & "  "
            SQL = SQL & "   AND K9706_FormName		 = '" & FormName & "' "
            SQL = SQL & "   AND K9706_GroupUser		 = '" & GroupUser & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK9706", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK9706(z9706 As T9706_AREA) As Boolean
        WRITE_PFK9706 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9706)

            SQL = " INSERT INTO PFK9706 "
            SQL = SQL & " ( "
            SQL = SQL & " K9706_LayoutNoRef,"
            SQL = SQL & " K9706_FormName,"
            SQL = SQL & " K9706_GroupUser,"
            SQL = SQL & " K9706_ItemName,"
            SQL = SQL & " K9706_ControlName,"
            SQL = SQL & " K9706_ControlData1,"
            SQL = SQL & " K9706_ControlData2,"
            SQL = SQL & " K9706_ControlData3,"
            SQL = SQL & " K9706_ControlData4,"
            SQL = SQL & " K9706_Type,"
            SQL = SQL & " K9706_DefaultValue1,"
            SQL = SQL & " K9706_DefaultValue2,"
            SQL = SQL & " K9706_DefaultValue3,"
            SQL = SQL & " K9706_CreateDate,"
            SQL = SQL & " K9706_Active "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "   " & FormatSQL(z9706.LayoutNoRef) & ", "
            SQL = SQL & "  N'" & FormatSQL(z9706.FormName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9706.GroupUser) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9706.ItemName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9706.ControlName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9706.ControlData1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9706.ControlData2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9706.ControlData3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9706.ControlData4) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9706.Type) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9706.DefaultValue1) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9706.DefaultValue2) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9706.DefaultValue3) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9706.CreateDate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z9706.Active) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK9706 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK9706", vbCritical)
        Finally
            Call GetFullInformation("PFK9706", "I", SQL)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK9706(z9706 As T9706_AREA) As Boolean
        REWRITE_PFK9706 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9706)

            SQL = " UPDATE PFK9706 SET "
            SQL = SQL & "    K9706_ItemName      = N'" & FormatSQL(z9706.ItemName) & "', "
            SQL = SQL & "    K9706_ControlName      = N'" & FormatSQL(z9706.ControlName) & "', "
            SQL = SQL & "    K9706_ControlData1      = N'" & FormatSQL(z9706.ControlData1) & "', "
            SQL = SQL & "    K9706_ControlData2      = N'" & FormatSQL(z9706.ControlData2) & "', "
            SQL = SQL & "    K9706_ControlData3      = N'" & FormatSQL(z9706.ControlData3) & "', "
            SQL = SQL & "    K9706_ControlData4      = N'" & FormatSQL(z9706.ControlData4) & "', "
            SQL = SQL & "    K9706_Type      = N'" & FormatSQL(z9706.Type) & "', "
            SQL = SQL & "    K9706_DefaultValue1      = N'" & FormatSQL(z9706.DefaultValue1) & "', "
            SQL = SQL & "    K9706_DefaultValue2      = N'" & FormatSQL(z9706.DefaultValue2) & "', "
            SQL = SQL & "    K9706_DefaultValue3      = N'" & FormatSQL(z9706.DefaultValue3) & "', "
            SQL = SQL & "    K9706_CreateDate      = N'" & FormatSQL(z9706.CreateDate) & "', "
            SQL = SQL & "    K9706_Active      = N'" & FormatSQL(z9706.Active) & "'  "
            SQL = SQL & " WHERE K9706_LayoutNoRef		 =  " & z9706.LayoutNoRef & "  "
            SQL = SQL & "   AND K9706_FormName		 = '" & z9706.FormName & "' "
            SQL = SQL & "   AND K9706_GroupUser		 = '" & z9706.GroupUser & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK9706 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK9706", vbCritical)
        Finally
            Call GetFullInformation("PFK9706", "U", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK9706(z9706 As T9706_AREA) As Boolean
        DELETE_PFK9706 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK9706 "
            SQL = SQL & " WHERE K9706_LayoutNoRef		 =  " & z9706.LayoutNoRef & "  "
            SQL = SQL & "   AND K9706_FormName		 = '" & z9706.FormName & "' "
            SQL = SQL & "   AND K9706_GroupUser		 = '" & z9706.GroupUser & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK9706 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK9706", vbCritical)
        Finally
            Call GetFullInformation("PFK9706", "D", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D9706_CLEAR()
        Try

            D9706.LayoutNoRef = 0
            D9706.FormName = ""
            D9706.GroupUser = ""
            D9706.ItemName = ""
            D9706.ControlName = ""
            D9706.ControlData1 = ""
            D9706.ControlData2 = ""
            D9706.ControlData3 = ""
            D9706.ControlData4 = ""
            D9706.Type = ""
            D9706.DefaultValue1 = ""
            D9706.DefaultValue2 = ""
            D9706.DefaultValue3 = ""
            D9706.CreateDate = ""
            D9706.Active = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D9706_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x9706 As T9706_AREA)
        Try

            x9706.LayoutNoRef = trim$(x9706.LayoutNoRef)
            x9706.FormName = trim$(x9706.FormName)
            x9706.GroupUser = trim$(x9706.GroupUser)
            x9706.ItemName = trim$(x9706.ItemName)
            x9706.ControlName = trim$(x9706.ControlName)
            x9706.ControlData1 = trim$(x9706.ControlData1)
            x9706.ControlData2 = trim$(x9706.ControlData2)
            x9706.ControlData3 = trim$(x9706.ControlData3)
            x9706.ControlData4 = trim$(x9706.ControlData4)
            x9706.Type = trim$(x9706.Type)
            x9706.DefaultValue1 = trim$(x9706.DefaultValue1)
            x9706.DefaultValue2 = trim$(x9706.DefaultValue2)
            x9706.DefaultValue3 = trim$(x9706.DefaultValue3)
            x9706.CreateDate = trim$(x9706.CreateDate)
            x9706.Active = trim$(x9706.Active)

            If trim$(x9706.LayoutNoRef) = "" Then x9706.LayoutNoRef = 0
            If trim$(x9706.FormName) = "" Then x9706.FormName = Space(1)
            If trim$(x9706.GroupUser) = "" Then x9706.GroupUser = Space(1)
            If trim$(x9706.ItemName) = "" Then x9706.ItemName = Space(1)
            If trim$(x9706.ControlName) = "" Then x9706.ControlName = Space(1)
            If trim$(x9706.ControlData1) = "" Then x9706.ControlData1 = Space(1)
            If trim$(x9706.ControlData2) = "" Then x9706.ControlData2 = Space(1)
            If trim$(x9706.ControlData3) = "" Then x9706.ControlData3 = Space(1)
            If trim$(x9706.ControlData4) = "" Then x9706.ControlData4 = Space(1)
            If trim$(x9706.Type) = "" Then x9706.Type = Space(1)
            If trim$(x9706.DefaultValue1) = "" Then x9706.DefaultValue1 = Space(1)
            If trim$(x9706.DefaultValue2) = "" Then x9706.DefaultValue2 = Space(1)
            If trim$(x9706.DefaultValue3) = "" Then x9706.DefaultValue3 = Space(1)
            If trim$(x9706.CreateDate) = "" Then x9706.CreateDate = Space(1)
            If trim$(x9706.Active) = "" Then x9706.Active = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K9706_MOVE(rs9706 As SqlClient.SqlDataReader)
        Try

            Call D9706_CLEAR()

            If IsdbNull(rs9706!K9706_LayoutNoRef) = False Then D9706.LayoutNoRef = Trim$(rs9706!K9706_LayoutNoRef)
            If IsdbNull(rs9706!K9706_FormName) = False Then D9706.FormName = Trim$(rs9706!K9706_FormName)
            If IsdbNull(rs9706!K9706_GroupUser) = False Then D9706.GroupUser = Trim$(rs9706!K9706_GroupUser)
            If IsdbNull(rs9706!K9706_ItemName) = False Then D9706.ItemName = Trim$(rs9706!K9706_ItemName)
            If IsdbNull(rs9706!K9706_ControlName) = False Then D9706.ControlName = Trim$(rs9706!K9706_ControlName)
            If IsdbNull(rs9706!K9706_ControlData1) = False Then D9706.ControlData1 = Trim$(rs9706!K9706_ControlData1)
            If IsdbNull(rs9706!K9706_ControlData2) = False Then D9706.ControlData2 = Trim$(rs9706!K9706_ControlData2)
            If IsdbNull(rs9706!K9706_ControlData3) = False Then D9706.ControlData3 = Trim$(rs9706!K9706_ControlData3)
            If IsdbNull(rs9706!K9706_ControlData4) = False Then D9706.ControlData4 = Trim$(rs9706!K9706_ControlData4)
            If IsdbNull(rs9706!K9706_Type) = False Then D9706.Type = Trim$(rs9706!K9706_Type)
            If IsdbNull(rs9706!K9706_DefaultValue1) = False Then D9706.DefaultValue1 = Trim$(rs9706!K9706_DefaultValue1)
            If IsdbNull(rs9706!K9706_DefaultValue2) = False Then D9706.DefaultValue2 = Trim$(rs9706!K9706_DefaultValue2)
            If IsdbNull(rs9706!K9706_DefaultValue3) = False Then D9706.DefaultValue3 = Trim$(rs9706!K9706_DefaultValue3)
            If IsdbNull(rs9706!K9706_CreateDate) = False Then D9706.CreateDate = Trim$(rs9706!K9706_CreateDate)
            If IsdbNull(rs9706!K9706_Active) = False Then D9706.Active = Trim$(rs9706!K9706_Active)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9706_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K9706_MOVE(rs9706 As DataRow)
        Try

            Call D9706_CLEAR()

            If IsdbNull(rs9706!K9706_LayoutNoRef) = False Then D9706.LayoutNoRef = Trim$(rs9706!K9706_LayoutNoRef)
            If IsdbNull(rs9706!K9706_FormName) = False Then D9706.FormName = Trim$(rs9706!K9706_FormName)
            If IsdbNull(rs9706!K9706_GroupUser) = False Then D9706.GroupUser = Trim$(rs9706!K9706_GroupUser)
            If IsdbNull(rs9706!K9706_ItemName) = False Then D9706.ItemName = Trim$(rs9706!K9706_ItemName)
            If IsdbNull(rs9706!K9706_ControlName) = False Then D9706.ControlName = Trim$(rs9706!K9706_ControlName)
            If IsdbNull(rs9706!K9706_ControlData1) = False Then D9706.ControlData1 = Trim$(rs9706!K9706_ControlData1)
            If IsdbNull(rs9706!K9706_ControlData2) = False Then D9706.ControlData2 = Trim$(rs9706!K9706_ControlData2)
            If IsdbNull(rs9706!K9706_ControlData3) = False Then D9706.ControlData3 = Trim$(rs9706!K9706_ControlData3)
            If IsdbNull(rs9706!K9706_ControlData4) = False Then D9706.ControlData4 = Trim$(rs9706!K9706_ControlData4)
            If IsdbNull(rs9706!K9706_Type) = False Then D9706.Type = Trim$(rs9706!K9706_Type)
            If IsdbNull(rs9706!K9706_DefaultValue1) = False Then D9706.DefaultValue1 = Trim$(rs9706!K9706_DefaultValue1)
            If IsdbNull(rs9706!K9706_DefaultValue2) = False Then D9706.DefaultValue2 = Trim$(rs9706!K9706_DefaultValue2)
            If IsdbNull(rs9706!K9706_DefaultValue3) = False Then D9706.DefaultValue3 = Trim$(rs9706!K9706_DefaultValue3)
            If IsdbNull(rs9706!K9706_CreateDate) = False Then D9706.CreateDate = Trim$(rs9706!K9706_CreateDate)
            If IsdbNull(rs9706!K9706_Active) = False Then D9706.Active = Trim$(rs9706!K9706_Active)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9706_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K9706_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9706 As T9706_AREA, LAYOUTNOREF As Long, FormName As String, GROUPUSER As String) As Boolean

        K9706_MOVE = False

        Try
            If READ_PFK9706(LAYOUTNOREF, FormName, GROUPUSER) = True Then
                z9706 = D9706
                K9706_MOVE = True
            Else
                z9706 = Nothing
            End If

            If getColumnIndex(spr, "LayoutNoRef") > -1 Then z9706.LayoutNoRef = getDataM(spr, getColumnIndex(spr, "LayoutNoRef"), xRow)
            If getColumnIndex(spr, "FormName") > -1 Then z9706.FormName = getDataM(spr, getColumnIndex(spr, "FormName"), xRow)
            If getColumnIndex(spr, "GroupUser") > -1 Then z9706.GroupUser = getDataM(spr, getColumnIndex(spr, "GroupUser"), xRow)
            If getColumnIndex(spr, "ItemName") > -1 Then z9706.ItemName = getDataM(spr, getColumnIndex(spr, "ItemName"), xRow)
            If getColumnIndex(spr, "ControlName") > -1 Then z9706.ControlName = getDataM(spr, getColumnIndex(spr, "ControlName"), xRow)
            If getColumnIndex(spr, "ControlData1") > -1 Then z9706.ControlData1 = getDataM(spr, getColumnIndex(spr, "ControlData1"), xRow)
            If getColumnIndex(spr, "ControlData2") > -1 Then z9706.ControlData2 = getDataM(spr, getColumnIndex(spr, "ControlData2"), xRow)
            If getColumnIndex(spr, "ControlData3") > -1 Then z9706.ControlData3 = getDataM(spr, getColumnIndex(spr, "ControlData3"), xRow)
            If getColumnIndex(spr, "ControlData4") > -1 Then z9706.ControlData4 = getDataM(spr, getColumnIndex(spr, "ControlData4"), xRow)
            If getColumnIndex(spr, "Type") > -1 Then z9706.Type = getDataM(spr, getColumnIndex(spr, "Type"), xRow)
            If getColumnIndex(spr, "DefaultValue1") > -1 Then z9706.DefaultValue1 = getDataM(spr, getColumnIndex(spr, "DefaultValue1"), xRow)
            If getColumnIndex(spr, "DefaultValue2") > -1 Then z9706.DefaultValue2 = getDataM(spr, getColumnIndex(spr, "DefaultValue2"), xRow)
            If getColumnIndex(spr, "DefaultValue3") > -1 Then z9706.DefaultValue3 = getDataM(spr, getColumnIndex(spr, "DefaultValue3"), xRow)
            If getColumnIndex(spr, "CreateDate") > -1 Then z9706.CreateDate = getDataM(spr, getColumnIndex(spr, "CreateDate"), xRow)
            If getColumnIndex(spr, "Active") > -1 Then z9706.Active = getDataM(spr, getColumnIndex(spr, "Active"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9706_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K9706_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9706 As T9706_AREA, CheckClear As Boolean, LAYOUTNOREF As Long, FormName As String, GROUPUSER As String) As Boolean

        K9706_MOVE = False

        Try
            If READ_PFK9706(LAYOUTNOREF, FormName, GROUPUSER) = True Then
                z9706 = D9706
                K9706_MOVE = True
            Else
                If CheckClear = True Then z9706 = Nothing
            End If

            If getColumnIndex(spr, "LayoutNoRef") > -1 Then z9706.LayoutNoRef = getDataM(spr, getColumnIndex(spr, "LayoutNoRef"), xRow)
            If getColumnIndex(spr, "FormName") > -1 Then z9706.FormName = getDataM(spr, getColumnIndex(spr, "FormName"), xRow)
            If getColumnIndex(spr, "GroupUser") > -1 Then z9706.GroupUser = getDataM(spr, getColumnIndex(spr, "GroupUser"), xRow)
            If getColumnIndex(spr, "ItemName") > -1 Then z9706.ItemName = getDataM(spr, getColumnIndex(spr, "ItemName"), xRow)
            If getColumnIndex(spr, "ControlName") > -1 Then z9706.ControlName = getDataM(spr, getColumnIndex(spr, "ControlName"), xRow)
            If getColumnIndex(spr, "ControlData1") > -1 Then z9706.ControlData1 = getDataM(spr, getColumnIndex(spr, "ControlData1"), xRow)
            If getColumnIndex(spr, "ControlData2") > -1 Then z9706.ControlData2 = getDataM(spr, getColumnIndex(spr, "ControlData2"), xRow)
            If getColumnIndex(spr, "ControlData3") > -1 Then z9706.ControlData3 = getDataM(spr, getColumnIndex(spr, "ControlData3"), xRow)
            If getColumnIndex(spr, "ControlData4") > -1 Then z9706.ControlData4 = getDataM(spr, getColumnIndex(spr, "ControlData4"), xRow)
            If getColumnIndex(spr, "Type") > -1 Then z9706.Type = getDataM(spr, getColumnIndex(spr, "Type"), xRow)
            If getColumnIndex(spr, "DefaultValue1") > -1 Then z9706.DefaultValue1 = getDataM(spr, getColumnIndex(spr, "DefaultValue1"), xRow)
            If getColumnIndex(spr, "DefaultValue2") > -1 Then z9706.DefaultValue2 = getDataM(spr, getColumnIndex(spr, "DefaultValue2"), xRow)
            If getColumnIndex(spr, "DefaultValue3") > -1 Then z9706.DefaultValue3 = getDataM(spr, getColumnIndex(spr, "DefaultValue3"), xRow)
            If getColumnIndex(spr, "CreateDate") > -1 Then z9706.CreateDate = getDataM(spr, getColumnIndex(spr, "CreateDate"), xRow)
            If getColumnIndex(spr, "Active") > -1 Then z9706.Active = getDataM(spr, getColumnIndex(spr, "Active"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9706_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K9706_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9706 As T9706_AREA, Job As String, LAYOUTNOREF As Long, FormName As String, GROUPUSER As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9706_MOVE = False

        Try
            If READ_PFK9706(LAYOUTNOREF, FormName, GROUPUSER) = True Then
                z9706 = D9706
                K9706_MOVE = True
            Else
                z9706 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9706")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "LAYOUTNOREF" : z9706.LayoutNoRef = Children(i).Code
                                Case "FormName" : z9706.FormName = Children(i).Code
                                Case "GROUPUSER" : z9706.GroupUser = Children(i).Code
                                Case "ITEMNAME" : z9706.ItemName = Children(i).Code
                                Case "CONTROLNAME" : z9706.ControlName = Children(i).Code
                                Case "CONTROLDATA1" : z9706.ControlData1 = Children(i).Code
                                Case "CONTROLDATA2" : z9706.ControlData2 = Children(i).Code
                                Case "CONTROLDATA3" : z9706.ControlData3 = Children(i).Code
                                Case "CONTROLDATA4" : z9706.ControlData4 = Children(i).Code
                                Case "TYPE" : z9706.Type = Children(i).Code
                                Case "DEFAULTVALUE1" : z9706.DefaultValue1 = Children(i).Code
                                Case "DEFAULTVALUE2" : z9706.DefaultValue2 = Children(i).Code
                                Case "DEFAULTVALUE3" : z9706.DefaultValue3 = Children(i).Code
                                Case "CREATEDATE" : z9706.CreateDate = Children(i).Code
                                Case "ACTIVE" : z9706.Active = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "LAYOUTNOREF" : z9706.LayoutNoRef = Children(i).Data
                                Case "FormName" : z9706.FormName = Children(i).Data
                                Case "GROUPUSER" : z9706.GroupUser = Children(i).Data
                                Case "ITEMNAME" : z9706.ItemName = Children(i).Data
                                Case "CONTROLNAME" : z9706.ControlName = Children(i).Data
                                Case "CONTROLDATA1" : z9706.ControlData1 = Children(i).Data
                                Case "CONTROLDATA2" : z9706.ControlData2 = Children(i).Data
                                Case "CONTROLDATA3" : z9706.ControlData3 = Children(i).Data
                                Case "CONTROLDATA4" : z9706.ControlData4 = Children(i).Data
                                Case "TYPE" : z9706.Type = Children(i).Data
                                Case "DEFAULTVALUE1" : z9706.DefaultValue1 = Children(i).Data
                                Case "DEFAULTVALUE2" : z9706.DefaultValue2 = Children(i).Data
                                Case "DEFAULTVALUE3" : z9706.DefaultValue3 = Children(i).Data
                                Case "CREATEDATE" : z9706.CreateDate = Children(i).Data
                                Case "ACTIVE" : z9706.Active = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9706_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K9706_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9706 As T9706_AREA, Job As String, CheckClear As Boolean, LAYOUTNOREF As Long, FormName As String, GROUPUSER As String) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9706_MOVE = False

        Try
            If READ_PFK9706(LAYOUTNOREF, FormName, GROUPUSER) = True Then
                z9706 = D9706
                K9706_MOVE = True
            Else
                If CheckClear = True Then z9706 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9706")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "LAYOUTNOREF" : z9706.LayoutNoRef = Children(i).Code
                                Case "FormName" : z9706.FormName = Children(i).Code
                                Case "GROUPUSER" : z9706.GroupUser = Children(i).Code
                                Case "ITEMNAME" : z9706.ItemName = Children(i).Code
                                Case "CONTROLNAME" : z9706.ControlName = Children(i).Code
                                Case "CONTROLDATA1" : z9706.ControlData1 = Children(i).Code
                                Case "CONTROLDATA2" : z9706.ControlData2 = Children(i).Code
                                Case "CONTROLDATA3" : z9706.ControlData3 = Children(i).Code
                                Case "CONTROLDATA4" : z9706.ControlData4 = Children(i).Code
                                Case "TYPE" : z9706.Type = Children(i).Code
                                Case "DEFAULTVALUE1" : z9706.DefaultValue1 = Children(i).Code
                                Case "DEFAULTVALUE2" : z9706.DefaultValue2 = Children(i).Code
                                Case "DEFAULTVALUE3" : z9706.DefaultValue3 = Children(i).Code
                                Case "CREATEDATE" : z9706.CreateDate = Children(i).Code
                                Case "ACTIVE" : z9706.Active = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "LAYOUTNOREF" : z9706.LayoutNoRef = Children(i).Data
                                Case "FormName" : z9706.FormName = Children(i).Data
                                Case "GROUPUSER" : z9706.GroupUser = Children(i).Data
                                Case "ITEMNAME" : z9706.ItemName = Children(i).Data
                                Case "CONTROLNAME" : z9706.ControlName = Children(i).Data
                                Case "CONTROLDATA1" : z9706.ControlData1 = Children(i).Data
                                Case "CONTROLDATA2" : z9706.ControlData2 = Children(i).Data
                                Case "CONTROLDATA3" : z9706.ControlData3 = Children(i).Data
                                Case "CONTROLDATA4" : z9706.ControlData4 = Children(i).Data
                                Case "TYPE" : z9706.Type = Children(i).Data
                                Case "DEFAULTVALUE1" : z9706.DefaultValue1 = Children(i).Data
                                Case "DEFAULTVALUE2" : z9706.DefaultValue2 = Children(i).Data
                                Case "DEFAULTVALUE3" : z9706.DefaultValue3 = Children(i).Data
                                Case "CREATEDATE" : z9706.CreateDate = Children(i).Data
                                Case "ACTIVE" : z9706.Active = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9706_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW AREA
    '=========================================================================================================================================================
    Public Sub K9706_MOVE(ByRef a9706 As T9706_AREA, ByRef b9706 As T9706_AREA)
        Try
            If trim$(a9706.LayoutNoRef) = "" Then b9706.LayoutNoRef = "" Else b9706.LayoutNoRef = a9706.LayoutNoRef
            If trim$(a9706.FormName) = "" Then b9706.FormName = "" Else b9706.FormName = a9706.FormName
            If trim$(a9706.GroupUser) = "" Then b9706.GroupUser = "" Else b9706.GroupUser = a9706.GroupUser
            If trim$(a9706.ItemName) = "" Then b9706.ItemName = "" Else b9706.ItemName = a9706.ItemName
            If trim$(a9706.ControlName) = "" Then b9706.ControlName = "" Else b9706.ControlName = a9706.ControlName
            If trim$(a9706.ControlData1) = "" Then b9706.ControlData1 = "" Else b9706.ControlData1 = a9706.ControlData1
            If trim$(a9706.ControlData2) = "" Then b9706.ControlData2 = "" Else b9706.ControlData2 = a9706.ControlData2
            If trim$(a9706.ControlData3) = "" Then b9706.ControlData3 = "" Else b9706.ControlData3 = a9706.ControlData3
            If trim$(a9706.ControlData4) = "" Then b9706.ControlData4 = "" Else b9706.ControlData4 = a9706.ControlData4
            If trim$(a9706.Type) = "" Then b9706.Type = "" Else b9706.Type = a9706.Type
            If trim$(a9706.DefaultValue1) = "" Then b9706.DefaultValue1 = "" Else b9706.DefaultValue1 = a9706.DefaultValue1
            If trim$(a9706.DefaultValue2) = "" Then b9706.DefaultValue2 = "" Else b9706.DefaultValue2 = a9706.DefaultValue2
            If trim$(a9706.DefaultValue3) = "" Then b9706.DefaultValue3 = "" Else b9706.DefaultValue3 = a9706.DefaultValue3
            If trim$(a9706.CreateDate) = "" Then b9706.CreateDate = "" Else b9706.CreateDate = a9706.CreateDate
            If trim$(a9706.Active) = "" Then b9706.Active = "" Else b9706.Active = a9706.Active
        Catch ex As Exception
            Call MsgBoxP("K9706_MOVE", vbCritical)
        End Try
    End Sub


End Module
