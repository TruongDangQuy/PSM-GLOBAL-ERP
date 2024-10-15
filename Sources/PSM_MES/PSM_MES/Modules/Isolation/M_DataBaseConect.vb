Imports System.Data.SqlClient
Imports System.Resources

Module M_DataBaseConect

#Region "Variable"

#End Region

#Region "Methods"
    Public Function PrcDRSheet(ByVal ProcName As String, _
    ByRef Con As SqlConnection, ByVal ParamArray Param() As Object) As SqlDataReader

        Dim cmd As SqlCommand
        Dim SQL As String
        Dim i As Integer

        Try
            SQL = "EXEC " & ProcName
            If IsNothing(Param) = False Then
                For i = 0 To UBound(Param)
                    If i <> UBound(Param) Then
                        SQL = SQL & " '" & Param(i) & "', "
                    Else
                        SQL = SQL & " '" & Param(i) & "' "
                    End If
                Next
            End If

            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            cmd = New SqlCommand(SQL, Con)
            Return cmd.ExecuteReader()

        Catch ex As Exception
            MsgBoxP(ProcName & "-" & ex.Message, vbCritical)
            Return Nothing
        Finally

            cmd = Nothing
        End Try
    End Function
    Public Function PrcDR(ByVal ProcName As String, _
     ByRef Con As SqlConnection, ByVal ParamArray Param() As Object) As SqlDataReader

        Dim cmd As SqlCommand
        Dim SQL As String
        Dim i As Integer

        Try
            SQL = "EXEC " & ProcName
            If IsNothing(Param) = False Then
                For i = 0 To UBound(Param)
                    If i <> UBound(Param) Then
                        SQL = SQL & " '" & Param(i) & "', "
                    Else
                        SQL = SQL & " '" & Param(i) & "' "
                    End If
                Next
            End If

            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            cmd = New SqlCommand(SQL, Con)
            Return cmd.ExecuteReader()

        Catch ex As Exception
            MsgBoxP(ProcName & "-" & ex.Message, vbCritical)
            Return Nothing
        Finally
            Call Save_History_PFK9709("PrcDR", ProcName, SQL)

            cmd = Nothing
        End Try
    End Function
    Public Function PrcExe(ByVal ProcName As String, _
    ByRef Con As SqlConnection, ByVal ParamArray Param() As Object) As Boolean
        PrcExe = False

        Dim cmd As SqlCommand
        Dim SQL As String
        Dim i As Integer

        Try
            SQL = "EXEC " & ProcName
            If IsNothing(Param) = False Then
                For i = 0 To UBound(Param)
                    If i <> UBound(Param) Then
                        SQL = SQL & " '" & Param(i) & "', "
                    Else
                        SQL = SQL & " '" & Param(i) & "' "
                    End If
                Next
            End If

            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            cmd = New SqlCommand(SQL, Con)
            cmd.CommandTimeout = 0
            rd = cmd.ExecuteReader

            PrcExe = True
        Catch ex As Exception
            MsgBoxP(ProcName & "-" & ex.Message, vbCritical)

        Finally
            Call Save_History_PFK9709("PrcExe", ProcName, SQL)

            cmd = Nothing
            rd.Close()
        End Try
    End Function

    Public Function PrcDS(ByVal cmd As SqlCommand, _
ByRef Con As SqlConnection) As DataSet
        MdiMenu.Cursor = Cursors.WaitCursor
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        Try
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            da.SelectCommand = cmd
            da.Fill(ds, "SP")
            Return ds
        Catch ex As Exception
            Return Nothing
        Finally
            da = Nothing
            ds = Nothing
            MdiMenu.Cursor = Cursors.Default
        End Try
    End Function
    Public Function PrcDSSheet(ByVal ProcName As String, _
  ByRef Con As SqlConnection, ByVal ParamArray Param() As Object) As DataSet

        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim SQL As String = ""
        Dim i As Integer

        Try

            SQL = "EXEC " & ProcName
            If IsNothing(Param) = False Then
                For i = 0 To UBound(Param)
                    If i <> UBound(Param) Then
                        If Param(i) IsNot Nothing Then
                            If Param(i).ToString <> "" Then

                                If Param(i).ToString.Contains("''") = False Then Param(i) = FormatSQL(FormatSQL(Param(i)))

                                If Left(Param(i), 1) = "*" Then
                                    SQL = SQL & " N'" & Mid(Param(i), 2) & "', "
                                Else
                                    SQL = SQL & " '" & Param(i) & "', "
                                End If
                            Else
                                SQL = SQL & " '" & Param(i) & "', "
                            End If
                        Else
                            SQL = SQL & " '" & Param(i) & "', "
                        End If
                    Else
                        If Param(i) IsNot Nothing Then
                            If Param(i).ToString <> "" Then

                                If Param(i).ToString.Contains("''") = False Then Param(i) = FormatSQL(FormatSQL(Param(i)))

                                If Left(Param(i), 1) = "*" Then
                                    SQL = SQL & " N'" & Mid(Param(i), 2) & "' "
                                Else
                                    SQL = SQL & " '" & Param(i) & "' "
                                End If
                            Else
                                SQL = SQL & " '" & Param(i) & "' "
                            End If
                        Else
                            SQL = SQL & " '" & Param(i) & "' "
                        End If
                    End If
                Next
            End If

            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            da.SelectCommand = New SqlCommand(SQL, Con)
            da.Fill(ds, "SP")
            Return ds
        Catch ex As Exception
            MsgBoxP(ProcName & "-" & SQL & "-" & ex.Message, vbCritical)
            Return Nothing
        Finally
            Call Save_History_PFK9709("PrcDS", ProcName, SQL)

            da = Nothing
            ds = Nothing

        End Try
    End Function
    Public Function PrcDS(ByVal ProcName As String, _
   ByRef Con As SqlConnection, ByVal ParamArray Param() As Object) As DataSet

        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim SQL As String = ""
        Dim i As Integer

        Try

            SQL = "EXEC " & ProcName
            If IsNothing(Param) = False Then
                For i = 0 To UBound(Param)
                    If i <> UBound(Param) Then
                        If Param(i) IsNot Nothing Then
                            If Param(i).ToString <> "" Then

                                If Param(i).ToString.Contains("''") = False Then Param(i) = FormatSQL(FormatSQL(Param(i)))

                                If Left(Param(i), 1) = "*" Then
                                    SQL = SQL & " N'" & Mid(Param(i), 2) & "', "
                                Else
                                    SQL = SQL & " '" & Param(i) & "', "
                                End If
                            Else
                                SQL = SQL & " '" & Param(i) & "', "
                            End If
                        Else
                            SQL = SQL & " '" & Param(i) & "', "
                        End If
                    Else
                        If Param(i) IsNot Nothing Then
                            If Param(i).ToString <> "" Then

                                If Param(i).ToString.Contains("''") = False Then Param(i) = FormatSQL(FormatSQL(Param(i)))

                                If Left(Param(i), 1) = "*" Then
                                    SQL = SQL & " N'" & Mid(Param(i), 2) & "' "
                                Else
                                    SQL = SQL & " '" & Param(i) & "' "
                                End If
                            Else
                                SQL = SQL & " '" & Param(i) & "' "
                            End If
                        Else
                            SQL = SQL & " '" & Param(i) & "' "
                        End If
                    End If
                Next
            End If

            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            da.SelectCommand = New SqlCommand(SQL, Con)
            da.Fill(ds, "SP")
            Return ds
        Catch ex As Exception
            MsgBoxP(ProcName & "-" & SQL & "-" & ex.Message, vbCritical)
            Return Nothing
        Finally
            Call Save_History_PFK9709("PrcDS", ProcName, SQL)

            da = Nothing
            ds = Nothing

        End Try
    End Function

    Public Function PrcDS_NoError(ByVal ProcName As String, _
  ByRef Con As SqlConnection, ByVal ParamArray Param() As Object) As DataSet

        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim SQL As String = ""
        Dim i As Integer

        Try

            SQL = "EXEC " & ProcName
            If IsNothing(Param) = False Then
                For i = 0 To UBound(Param)
                    If i <> UBound(Param) Then
                        If Param(i) IsNot Nothing Then
                            If Param(i).ToString <> "" Then

                                If Param(i).ToString.Contains("''") = False Then Param(i) = FormatSQL(FormatSQL(Param(i)))

                                If Left(Param(i), 1) = "*" Then
                                    SQL = SQL & " N'" & Mid(Param(i), 2) & "', "
                                Else
                                    SQL = SQL & " '" & Param(i) & "', "
                                End If
                            Else
                                SQL = SQL & " '" & Param(i) & "', "
                            End If
                        Else
                            SQL = SQL & " '" & Param(i) & "', "
                        End If
                    Else
                        If Param(i) IsNot Nothing Then
                            If Param(i).ToString <> "" Then

                                If Param(i).ToString.Contains("''") = False Then Param(i) = FormatSQL(FormatSQL(Param(i)))

                                If Left(Param(i), 1) = "*" Then
                                    SQL = SQL & " N'" & Mid(Param(i), 2) & "' "
                                Else
                                    SQL = SQL & " '" & Param(i) & "' "
                                End If
                            Else
                                SQL = SQL & " '" & Param(i) & "' "
                            End If
                        Else
                            SQL = SQL & " '" & Param(i) & "' "
                        End If
                    End If
                Next
            End If

            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            da.SelectCommand = New SqlCommand(SQL, Con)
            da.Fill(ds, "SP")
            Return ds
        Catch ex As Exception
            'MsgBoxP(ProcName & "-" & SQL & "-" & ex.Message, vbCritical)
            Return Nothing
        Finally
            Call Save_History_PFK9709("PrcDS", ProcName, SQL)

            da = Nothing
            ds = Nothing

        End Try
    End Function
    Public Function PrcDS_Old(ByVal ProcName As String, _
  ByRef Con As SqlConnection, ByVal ParamArray Param() As Object) As DataSet

        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim SQL As String = ""
        Dim i As Integer

        Try

            SQL = "EXEC " & ProcName
            If IsNothing(Param) = False Then
                For i = 0 To UBound(Param)
                    If i <> UBound(Param) Then
                        If Param(i) IsNot Nothing Then
                            If Param(i).ToString <> "" Then
                                If Left(Param(i), 1) = "*" Then
                                    SQL = SQL & " N'" & Mid(Param(i), 2) & "', "
                                Else
                                    SQL = SQL & " '" & Param(i) & "', "
                                End If
                            Else
                                SQL = SQL & " '" & Param(i) & "', "
                            End If
                        Else
                            SQL = SQL & " '" & Param(i) & "', "
                        End If
                    Else
                        If Param(i) IsNot Nothing Then
                            If Param(i).ToString <> "" Then
                                If Left(Param(i), 1) = "*" Then
                                    SQL = SQL & " N'" & Mid(Param(i), 2) & "' "
                                Else
                                    SQL = SQL & " '" & Param(i) & "' "
                                End If
                            Else
                                SQL = SQL & " '" & Param(i) & "' "
                            End If
                        Else
                            SQL = SQL & " '" & Param(i) & "' "
                        End If
                    End If
                Next
            End If

            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            da.SelectCommand = New SqlCommand(SQL, Con)
            da.Fill(ds, "SP")
            Return ds
        Catch ex As Exception
            'MsgBoxP(ProcName & "-" & SQL & "-" & ex.Message, vbCritical)
            Return Nothing
        Finally
            da = Nothing
            ds = Nothing

        End Try
    End Function

    Public Function PrcDS_Name(ByVal ProcName As String, ByVal TableName As String, _
 ByRef Con As SqlConnection, ByVal ParamArray Param() As Object) As DataTable

        Dim da As New SqlDataAdapter
        Dim ds As New DataTable
        Dim SQL As String = ""
        Dim i As Integer

        Try

            SQL = "EXEC " & ProcName
            If IsNothing(Param) = False Then
                For i = 0 To UBound(Param)
                    If i <> UBound(Param) Then
                        If Param(i) IsNot Nothing Then
                            If Param(i).ToString <> "" Then
                                If Left(Param(i), 1) = "*" Then
                                    SQL = SQL & " N'" & Mid(Param(i), 2) & "', "
                                Else
                                    SQL = SQL & " '" & Param(i) & "', "
                                End If
                            Else
                                SQL = SQL & " '" & Param(i) & "', "
                            End If
                        Else
                            SQL = SQL & " '" & Param(i) & "', "
                        End If
                    Else
                        If Param(i) IsNot Nothing Then
                            If Param(i).ToString <> "" Then
                                If Left(Param(i), 1) = "*" Then
                                    SQL = SQL & " N'" & Mid(Param(i), 2) & "' "
                                Else
                                    SQL = SQL & " '" & Param(i) & "' "
                                End If
                            Else
                                SQL = SQL & " '" & Param(i) & "' "
                            End If
                        Else
                            SQL = SQL & " '" & Param(i) & "' "
                        End If
                    End If
                Next
            End If

            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            da.SelectCommand = New SqlCommand(SQL, Con)
            da.Fill(ds)
            ds.TableName = TableName
            Return ds
        Catch ex As Exception
            MsgBoxP(ProcName & "-" & SQL & "-" & ex.Message, vbCritical)
            Return Nothing
        Finally
            da = Nothing
            ds = Nothing

        End Try
    End Function
    Public Function PrcDSVN(ByVal ProcName As String, _
  ByRef Con As SqlConnection, ByVal ParamArray Param() As Object) As DataSet

        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim SQL As String = ""
        Dim i As Integer

        Try

            SQL = "EXEC " & ProcName
            If IsNothing(Param) = False Then
                For i = 0 To UBound(Param)
                    If i <> UBound(Param) Then
                        If Param(i) IsNot Nothing Then
                            If Param(i).ToString <> "" Then
                                If Left(Param(i), 1) = "*" Then
                                    SQL = SQL & " N'" & Mid(Param(i), 2) & "', "
                                Else
                                    SQL = SQL & " '" & Param(i) & "', "
                                End If
                            Else
                                SQL = SQL & " '" & Param(i) & "', "
                            End If
                        Else
                            SQL = SQL & " '" & Param(i) & "', "
                        End If
                    Else
                        If Param(i) IsNot Nothing Then
                            If Param(i).ToString <> "" Then
                                If Left(Param(i), 1) = "*" Then
                                    SQL = SQL & " N'" & Mid(Param(i), 2) & "' "
                                Else
                                    SQL = SQL & " '" & Param(i) & "' "
                                End If
                            Else
                                SQL = SQL & " '" & Param(i) & "' "
                            End If
                        Else
                            SQL = SQL & " '" & Param(i) & "' "
                        End If
                    End If
                Next
            End If

            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            da.SelectCommand = New SqlCommand(SQL, Con)
            da.Fill(ds, "SP")
            Return ds
        Catch ex As Exception
            MsgBoxP(ProcName & "-" & SQL & "-" & ex.Message, vbCritical)
            Return Nothing
        Finally
            Call Save_History_PFK9709("PrcDSVN", ProcName, SQL)

            da = Nothing
            ds = Nothing
        End Try
    End Function
    Public Function PrcExeNoError(ByVal ProcName As String, _
 ByRef Con As SqlConnection, ByVal ParamArray Param() As Object) As Boolean
        PrcExeNoError = False

        Dim cmd As SqlCommand
        Dim SQL As String
        Dim i As Integer

        Try
            SQL = "EXEC " & ProcName
            If IsNothing(Param) = False Then
                For i = 0 To UBound(Param)
                    If i <> UBound(Param) Then
                        If Left(Param(i), 1) = "*" Then
                            SQL = SQL & " N'" & Mid(Param(i), 2) & "', "
                        Else
                            SQL = SQL & " '" & Param(i) & "', "
                        End If

                    Else
                        If Left(Param(i), 1) = "*" Then
                            SQL = SQL & " N'" & Mid(Param(i), 2) & "' "
                        Else
                            SQL = SQL & " '" & Param(i) & "' "
                        End If

                    End If
                Next
            End If

            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            cmd = New SqlCommand(SQL, Con)
            cmd.CommandTimeout = 0
            rd = cmd.ExecuteReader

            PrcExeNoError = True
        Catch ex As Exception


        Finally
            Call Save_History_PFK9709("PrcExeNoError", ProcName, SQL)

            cmd = Nothing
            rd.Close()
        End Try
    End Function

    Public Function PrcExeNoError_Value(ByVal ProcName As String, _
ByRef Con As SqlConnection, ByVal ParamArray Param() As Object) As String
        PrcExeNoError_Value = ""

        Dim cmd As SqlCommand
        Dim SQL As String
        Dim i As Integer

        Try
            SQL = "EXEC " & ProcName
            If IsNothing(Param) = False Then
                For i = 0 To UBound(Param)
                    If i <> UBound(Param) Then
                        SQL = SQL & " '" & Param(i) & "', "
                    Else
                        SQL = SQL & " '" & Param(i) & "' "
                    End If
                Next
            End If

            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            cmd = New SqlCommand(SQL, Con)
            cmd.CommandTimeout = 0
            rd = cmd.ExecuteReader

            If rd.HasRows Then
                rd.Read()
                PrcExeNoError_Value = rd(0)
            End If

        Catch ex As Exception


        Finally
            Call Save_History_PFK9709("PrcExeNoError_Value", ProcName, SQL)

            cmd = Nothing
            rd.Close()
        End Try
    End Function

    Public Function PrcExeNoError_ValueVN(ByVal ProcName As String, _
ByRef Con As SqlConnection, ByVal ParamArray Param() As Object) As String
        PrcExeNoError_ValueVN = ""

        Dim cmd As SqlCommand
        Dim SQL As String
        Dim i As Integer

        Try
            SQL = "EXEC " & ProcName
            If IsNothing(Param) = False Then
                For i = 0 To UBound(Param)
                    If i <> UBound(Param) Then
                        If Left(Param(i), 1) = "*" Then
                            SQL = SQL & " N'" & Mid(Param(i), 2) & "', "
                        Else
                            SQL = SQL & " '" & Param(i) & "', "
                        End If
                    Else
                        If Left(Param(i), 1) = "*" Then
                            SQL = SQL & " N'" & Mid(Param(i), 2) & "' "
                        Else
                            SQL = SQL & " '" & Param(i) & "' "
                        End If
                    End If
                Next
            End If

            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            cmd = New SqlCommand(SQL, Con)
            cmd.CommandTimeout = 0
            rd = cmd.ExecuteReader

            If rd.HasRows Then
                rd.Read()
                PrcExeNoError_ValueVN = rd(0)
            End If

        Catch ex As Exception


        Finally
            Call Save_History_PFK9709("PrcExeNoError_ValueVN", ProcName, SQL)

            cmd = Nothing
            rd.Close()
        End Try
    End Function

    Public Function PrcExeNoError_Value1(ByVal ProcName As String, _
ByRef Con As SqlConnection, ByVal ParamArray Param() As Object) As String
        PrcExeNoError_Value1 = ""

        Dim cmd As SqlCommand
        Dim SQL As String
        Dim i As Integer

        Try
            SQL = "EXEC " & ProcName
            If IsNothing(Param) = False Then
                For i = 0 To UBound(Param)
                    If i <> UBound(Param) Then
                        SQL = SQL & " '" & Param(i) & "', "
                    Else
                        SQL = SQL & " '" & Param(i) & "' "
                    End If
                Next
            End If

            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            cmd = New SqlCommand(SQL, Con)
            cmd.CommandTimeout = 0
            rd = cmd.ExecuteReader

            If rd.HasRows Then
                rd.Read()
                PrcExeNoError_Value1 = rd(1)
            End If

        Catch ex As Exception


        Finally
            Call Save_History_PFK9709("PrcExeNoError_Value1", ProcName, SQL)

            cmd = Nothing
            rd.Close()
        End Try
    End Function

    Public Function PrcDSNotice(ByVal ProcName As String, _
    ByRef Con As SqlConnection, ByVal ParamArray Param() As Object) As DataSet

        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim SQL As String = ""
        Dim i As Integer

        Try

            SQL = "EXEC " & ProcName
            If IsNothing(Param) = False Then
                For i = 0 To UBound(Param)
                    If i <> UBound(Param) Then
                        If Param(i) IsNot Nothing Then
                            If Param(i).ToString <> "" Then
                                If Left(Param(i), 1) = "*" Then
                                    SQL = SQL & " N'" & Mid(Param(i), 2) & "', "
                                Else
                                    SQL = SQL & " '" & Param(i) & "', "
                                End If
                            Else
                                SQL = SQL & " '" & Param(i) & "', "
                            End If
                        Else
                            SQL = SQL & " '" & Param(i) & "', "
                        End If
                    Else
                        If Param(i) IsNot Nothing Then
                            If Param(i).ToString <> "" Then
                                If Left(Param(i), 1) = "*" Then
                                    SQL = SQL & " N'" & Mid(Param(i), 2) & "' "
                                Else
                                    SQL = SQL & " '" & Param(i) & "' "
                                End If
                            Else
                                SQL = SQL & " '" & Param(i) & "' "
                            End If
                        Else
                            SQL = SQL & " '" & Param(i) & "' "
                        End If
                    End If
                Next
            End If

            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            da.SelectCommand = New SqlCommand(SQL, Con)
            da.Fill(ds, "SP")
            Return ds
        Catch ex As Exception

            Return Nothing
        Finally
            da = Nothing
            ds = Nothing
        End Try
    End Function

    Public Function PrcDS_M(ByVal ProcName As String, _
        ByRef Con As SqlConnection, ByVal ParamArray Param() As Object) As DataSet

        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        Dim SQL As String
        Dim i As Integer

        Try

            SQL = "EXEC " & ProcName

            If IsNothing(Param) = False Then
                For i = 0 To UBound(Param)
                    If i <> UBound(Param) Then
                        SQL = SQL & " '" & Param(i) & "', "
                    Else
                        SQL = SQL & " " & Param(i) & " "
                    End If
                Next
            End If

            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            da.SelectCommand = New SqlCommand(SQL, Con)
            da.Fill(ds, "SP")
            Return ds
        Catch ex As Exception
            MsgBoxP(ProcName & "-" & ex.Message, vbCritical)
            Return Nothing

        Finally
            da = Nothing
            ds = Nothing

        End Try

    End Function

    Public Function SqlDR(ByVal SQL As String, ByRef Con As SqlConnection) As SqlDataReader
        Dim cmd As SqlCommand

        Try
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            cmd = New SqlCommand(SQL, Con)
            Return cmd.ExecuteReader
        Catch ex As Exception
            MsgBoxP("SqlDR" & "-" & ex.Message, vbCritical)
            Return Nothing
        Finally
            cmd = Nothing

        End Try
    End Function

    Public Function SqlDS(ByVal SQL As String, ByRef Con As SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet

        Try

            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(ds, "T1")

            Return ds
        Catch ex As Exception
            MsgBoxP("SqlDS" & "-" & ex.Message, vbCritical)
            Return Nothing
        Finally
            da = Nothing
            ds = Nothing

        End Try
    End Function
#End Region

    

End Module

