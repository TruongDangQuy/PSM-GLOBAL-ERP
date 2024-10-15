'=========================================================================================================================================================
'   TABLE : (PFK9913)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K9913

    Structure T9913_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public ProdjectName As String  '			nvarchar(10)		*
        Public Sano As String  '			char(7)		*
        Public ProgramNo As String  '			nvarchar(10)		*
        Public SheetName As String  '			nvarchar(10)		*
        Public ProgramSeq As Double  '			decimal		*
        Public DisplaySeq As Double  '			decimal
        Public ItemCode As String  '			char(6)

        Public SizeWidth As Double  '			decimal

        Public Lock As String  '			nvarchar(10)
        Public Hidden As String  '			nvarchar(10)
        Public REMK As String  '			nvarchar(100)
        '=========================================================================================================================================================
    End Structure

    Public D9913 As T9913_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK9913(PRODJECTNAME As String, SANO As String, PROGRAMNO As String, SHEETNAME As String, PROGRAMSEQ As Double) As Boolean
        READ_PFK9913 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9913 "
            SQL = SQL & " WHERE K9913_ProdjectName		 = '" & ProdjectName & "' "
            SQL = SQL & "   AND K9913_Sano		 = '" & Sano & "' "
            SQL = SQL & "   AND K9913_ProgramNo		 = '" & ProgramNo & "' "
            SQL = SQL & "   AND K9913_SheetName		 = '" & SheetName & "' "
            SQL = SQL & "   AND K9913_ProgramSeq		 =  " & ProgramSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9913_CLEAR() : GoTo SKIP_READ_PFK9913

            Call K9913_MOVE(rd)
            READ_PFK9913 = True

SKIP_READ_PFK9913:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK9913", vbCritical)
        End Try
    End Function
    Public Function READ_PFK9913(Sano As String, PRODJECTNAME As String, PROGRAMNO As String, SHEETNAME As String) As Boolean
        READ_PFK9913 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9913 "
            SQL = SQL & " WHERE K9913_ProdjectName		 = '" & PRODJECTNAME & "' "
            SQL = SQL & "   AND K9913_ProgramNo		 = '" & PROGRAMNO & "' "
            SQL = SQL & "   AND K9913_SheetName		 = '" & SHEETNAME & "' "
            SQL = SQL & "   AND K9913_Sano		 = '" & Sano & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)

            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D9913_CLEAR() : GoTo SKIP_READ_PFK9913

            Call K9913_MOVE(rd)
            READ_PFK9913 = True

SKIP_READ_PFK9913:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("37", "READ_PFK9912")
        End Try
    End Function
    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK9913(PRODJECTNAME As String, SANO As String, PROGRAMNO As String, SHEETNAME As String, PROGRAMSEQ As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK9913 "
            SQL = SQL & " WHERE K9913_ProdjectName		 = '" & ProdjectName & "' "
            SQL = SQL & "   AND K9913_Sano		 = '" & Sano & "' "
            SQL = SQL & "   AND K9913_ProgramNo		 = '" & ProgramNo & "' "
            SQL = SQL & "   AND K9913_SheetName		 = '" & SheetName & "' "
            SQL = SQL & "   AND K9913_ProgramSeq		 =  " & ProgramSeq & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK9913", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK9913(z9913 As T9913_AREA) As Boolean
        WRITE_PFK9913 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9913)

            SQL = " INSERT INTO PFK9913 "
            SQL = SQL & " ( "
            SQL = SQL & " K9913_ProdjectName,"
            SQL = SQL & " K9913_Sano,"
            SQL = SQL & " K9913_ProgramNo,"
            SQL = SQL & " K9913_SheetName,"
            SQL = SQL & " K9913_ProgramSeq,"
            SQL = SQL & " K9913_DisplaySeq,"
            SQL = SQL & " K9913_SizeWidth,"
            SQL = SQL & " K9913_ItemCode,"
            SQL = SQL & " K9913_Lock,"
            SQL = SQL & " K9913_Hidden,"
            SQL = SQL & " K9913_REMK "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  '" & z9913.ProdjectName & "', "
            SQL = SQL & "  '" & z9913.Sano & "', "
            SQL = SQL & "  '" & z9913.ProgramNo & "', "
            SQL = SQL & "  '" & z9913.SheetName & "', "
            SQL = SQL & "   " & z9913.ProgramSeq & " , "
            SQL = SQL & "   " & z9913.DisplaySeq & " , "
            SQL = SQL & "   " & z9913.SizeWidth & " , "
            SQL = SQL & "  '" & z9913.ItemCode & "', "
            SQL = SQL & "  '" & z9913.Lock & "', "
            SQL = SQL & "  '" & z9913.Hidden & "', "
            SQL = SQL & "  '" & z9913.REMK & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK9913 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK9913", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK9913(z9913 As T9913_AREA) As Boolean
        REWRITE_PFK9913 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z9913)

            SQL = " UPDATE PFK9913 SET "
            SQL = SQL & "    K9913_DisplaySeq      =  " & z9913.DisplaySeq & " , "
            SQL = SQL & "    K9913_SizeWidth      =  " & z9913.SizeWidth & " , "
            SQL = SQL & "    K9913_ItemCode      = '" & z9913.ItemCode & "', "
            SQL = SQL & "    K9913_Lock      = '" & z9913.Lock & "', "
            SQL = SQL & "    K9913_Hidden      = '" & z9913.Hidden & "', "
            SQL = SQL & "    K9913_REMK      = '" & z9913.REMK & "'  "
            SQL = SQL & " WHERE K9913_ProdjectName		 = '" & z9913.ProdjectName & "' "
            SQL = SQL & "   AND K9913_Sano		 = '" & z9913.Sano & "' "
            SQL = SQL & "   AND K9913_ProgramNo		 = '" & z9913.ProgramNo & "' "
            SQL = SQL & "   AND K9913_SheetName		 = '" & z9913.SheetName & "' "
            SQL = SQL & "   AND K9913_ProgramSeq		 =  " & z9913.ProgramSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK9913 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK9913", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK9913(z9913 As T9913_AREA) As Boolean
        DELETE_PFK9913 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK9913 "
            SQL = SQL & " WHERE K9913_ProdjectName		 = '" & z9913.ProdjectName & "' "
            SQL = SQL & "   AND K9913_Sano		 = '" & z9913.Sano & "' "
            SQL = SQL & "   AND K9913_ProgramNo		 = '" & z9913.ProgramNo & "' "
            SQL = SQL & "   AND K9913_SheetName		 = '" & z9913.SheetName & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK9913 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK9913", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D9913_CLEAR()
        Try

            D9913.ProdjectName = ""
            D9913.Sano = ""
            D9913.ProgramNo = ""
            D9913.SheetName = ""
            D9913.ProgramSeq = 0
            D9913.DisplaySeq = 0
            D9913.SizeWidth = 0
            D9913.ItemCode = ""
            D9913.Lock = ""
            D9913.Hidden = ""
            D9913.REMK = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D9913_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x9913 As T9913_AREA)
        Try

            x9913.ProdjectName = trim$(x9913.ProdjectName)
            x9913.Sano = trim$(x9913.Sano)
            x9913.ProgramNo = trim$(x9913.ProgramNo)
            x9913.SheetName = trim$(x9913.SheetName)
            x9913.ProgramSeq = trim$(x9913.ProgramSeq)
            x9913.DisplaySeq = Trim$(x9913.DisplaySeq)
            x9913.SizeWidth = Trim$(x9913.SizeWidth)
            x9913.ItemCode = trim$(x9913.ItemCode)
            x9913.Lock = trim$(x9913.Lock)
            x9913.Hidden = trim$(x9913.Hidden)
            x9913.REMK = trim$(x9913.REMK)

            If trim$(x9913.ProdjectName) = "" Then x9913.ProdjectName = Space(1)
            If trim$(x9913.Sano) = "" Then x9913.Sano = Space(1)
            If trim$(x9913.ProgramNo) = "" Then x9913.ProgramNo = Space(1)
            If trim$(x9913.SheetName) = "" Then x9913.SheetName = Space(1)
            If trim$(x9913.ProgramSeq) = "" Then x9913.ProgramSeq = 0
            If Trim$(x9913.DisplaySeq) = "" Then x9913.DisplaySeq = 0
            If Trim$(x9913.SizeWidth) = "" Then x9913.SizeWidth = 0
            If trim$(x9913.ItemCode) = "" Then x9913.ItemCode = Space(1)
            If trim$(x9913.Lock) = "" Then x9913.Lock = Space(1)
            If trim$(x9913.Hidden) = "" Then x9913.Hidden = Space(1)
            If trim$(x9913.REMK) = "" Then x9913.REMK = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K9913_MOVE(rs9913 As SqlClient.SqlDataReader)
        Try

            Call D9913_CLEAR()

            If IsdbNull(rs9913!K9913_ProdjectName) = False Then D9913.ProdjectName = Trim$(rs9913!K9913_ProdjectName)
            If IsdbNull(rs9913!K9913_Sano) = False Then D9913.Sano = Trim$(rs9913!K9913_Sano)
            If IsdbNull(rs9913!K9913_ProgramNo) = False Then D9913.ProgramNo = Trim$(rs9913!K9913_ProgramNo)
            If IsdbNull(rs9913!K9913_SheetName) = False Then D9913.SheetName = Trim$(rs9913!K9913_SheetName)
            If IsdbNull(rs9913!K9913_ProgramSeq) = False Then D9913.ProgramSeq = Trim$(rs9913!K9913_ProgramSeq)
            If IsDBNull(rs9913!K9913_DisplaySeq) = False Then D9913.DisplaySeq = Trim$(rs9913!K9913_DisplaySeq)
            If IsDBNull(rs9913!K9913_SizeWidth) = False Then D9913.SizeWidth = Trim$(rs9913!K9913_SizeWidth)
            If IsdbNull(rs9913!K9913_ItemCode) = False Then D9913.ItemCode = Trim$(rs9913!K9913_ItemCode)
            If IsdbNull(rs9913!K9913_Lock) = False Then D9913.Lock = Trim$(rs9913!K9913_Lock)
            If IsdbNull(rs9913!K9913_Hidden) = False Then D9913.Hidden = Trim$(rs9913!K9913_Hidden)
            If IsdbNull(rs9913!K9913_REMK) = False Then D9913.REMK = Trim$(rs9913!K9913_REMK)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9913_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K9913_MOVE(rs9913 As DataRow)
        Try

            Call D9913_CLEAR()

            If IsdbNull(rs9913!K9913_ProdjectName) = False Then D9913.ProdjectName = Trim$(rs9913!K9913_ProdjectName)
            If IsdbNull(rs9913!K9913_Sano) = False Then D9913.Sano = Trim$(rs9913!K9913_Sano)
            If IsdbNull(rs9913!K9913_ProgramNo) = False Then D9913.ProgramNo = Trim$(rs9913!K9913_ProgramNo)
            If IsdbNull(rs9913!K9913_SheetName) = False Then D9913.SheetName = Trim$(rs9913!K9913_SheetName)
            If IsdbNull(rs9913!K9913_ProgramSeq) = False Then D9913.ProgramSeq = Trim$(rs9913!K9913_ProgramSeq)
            If IsDBNull(rs9913!K9913_DisplaySeq) = False Then D9913.DisplaySeq = Trim$(rs9913!K9913_DisplaySeq)
            If IsDBNull(rs9913!K9913_SizeWidth) = False Then D9913.SizeWidth = Trim$(rs9913!K9913_SizeWidth)
            If IsdbNull(rs9913!K9913_ItemCode) = False Then D9913.ItemCode = Trim$(rs9913!K9913_ItemCode)
            If IsdbNull(rs9913!K9913_Lock) = False Then D9913.Lock = Trim$(rs9913!K9913_Lock)
            If IsdbNull(rs9913!K9913_Hidden) = False Then D9913.Hidden = Trim$(rs9913!K9913_Hidden)
            If IsdbNull(rs9913!K9913_REMK) = False Then D9913.REMK = Trim$(rs9913!K9913_REMK)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K9913_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K9913_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z9913 As T9913_AREA, PRODJECTNAME As String, SANO As String, PROGRAMNO As String, SHEETNAME As String, PROGRAMSEQ As Double) As Boolean

        K9913_MOVE = False

        Try
            If READ_PFK9913(PRODJECTNAME, SANO, PROGRAMNO, SHEETNAME, PROGRAMSEQ) = True Then
                z9913 = D9913
                K9913_MOVE = True
            End If

            z9913.ProdjectName = getDataM(spr, getColumIndex(spr, "ProdjectName"), xRow)
            z9913.Sano = getDataM(spr, getColumIndex(spr, "Sano"), xRow)
            z9913.ProgramNo = getDataM(spr, getColumIndex(spr, "ProgramNo"), xRow)
            z9913.SheetName = getDataM(spr, getColumIndex(spr, "SheetName"), xRow)
            z9913.ProgramSeq = getDataM(spr, getColumIndex(spr, "ProgramSeq"), xRow)
            z9913.DisplaySeq = getDataM(spr, getColumIndex(spr, "DisplaySeq"), xRow)
            z9913.SizeWidth = getDataM(spr, getColumIndex(spr, "SizeWidth"), xRow)
            z9913.ItemCode = getDataM(spr, getColumIndex(spr, "ItemCode"), xRow)
            z9913.Lock = getDataM(spr, getColumIndex(spr, "Lock"), xRow)
            z9913.Hidden = getDataM(spr, getColumIndex(spr, "Hidden"), xRow)
            z9913.REMK = getDataM(spr, getColumIndex(spr, "REMK"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9913_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K9913_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z9913 As T9913_AREA, Job As String, PRODJECTNAME As String, SANO As String, PROGRAMNO As String, SHEETNAME As String, PROGRAMSEQ As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K9913_MOVE = False

        Try
            If READ_PFK9913(PRODJECTNAME, SANO, PROGRAMNO, SHEETNAME, PROGRAMSEQ) = True Then
                z9913 = D9913
                K9913_MOVE = True

            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK9913")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "ProdjectName" : z9913.ProdjectName = Children(i).Code
                                Case "Sano" : z9913.Sano = Children(i).Code
                                Case "ProgramNo" : z9913.ProgramNo = Children(i).Code
                                Case "SheetName" : z9913.SheetName = Children(i).Code
                                Case "ProgramSeq" : z9913.ProgramSeq = Children(i).Code
                                Case "DisplaySeq" : z9913.DisplaySeq = Children(i).Code
                                Case "SizeWidth" : z9913.SizeWidth = Children(i).Code
                                Case "ItemCode" : z9913.ItemCode = Children(i).Code
                                Case "Lock" : z9913.Lock = Children(i).Code
                                Case "Hidden" : z9913.Hidden = Children(i).Code
                                Case "REMK" : z9913.REMK = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "ProdjectName" : z9913.ProdjectName = Children(i).Data
                                Case "Sano" : z9913.Sano = Children(i).Data
                                Case "ProgramNo" : z9913.ProgramNo = Children(i).Data
                                Case "SheetName" : z9913.SheetName = Children(i).Data
                                Case "ProgramSeq" : z9913.ProgramSeq = Children(i).Data
                                Case "DisplaySeq" : z9913.DisplaySeq = Children(i).Data
                                Case "SizeWidth" : z9913.SizeWidth = Children(i).Data
                                Case "ItemCode" : z9913.ItemCode = Children(i).Data
                                Case "Lock" : z9913.Lock = Children(i).Data
                                Case "Hidden" : z9913.Hidden = Children(i).Data
                                Case "REMK" : z9913.REMK = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K9913_MOVE", vbCritical)
        End Try
    End Function

End Module
