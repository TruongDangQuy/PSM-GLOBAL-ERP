'=========================================================================================================================================================
'   TABLE : (PFK7611)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7611

    Structure T7611_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public AutoKey As Double  '			decimal		*
        Public AutoKey_K7103 As Double  '			decimal
        Public Dseq As Double  '			decimal
        Public ComponentName As String  '			nvarchar(50)
        Public MaterialCode As String  '			char(6)
        Public Specification As String  '			nvarchar(20)
        Public Width As String  '			nvarchar(20)
        Public Height As String  '			nvarchar(20)
        Public SizeName As String  '			nvarchar(20)
        Public ColorName As String  '			nvarchar(30)
        Public seUnitMaterial As String  '			char(3)
        Public cdUnitMaterial As String  '			char(3)
        Public QtyBatch As Double  '			decimal
        Public seSubProcess As String  '			char(3)
        Public cdSubProcess As String  '			char(3)
        Public Remark As String  '			nvarchar(200)
        '=========================================================================================================================================================
    End Structure

    Public D7611 As T7611_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK7611(AUTOKEY As Double) As Boolean
        READ_PFK7611 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7611 "
            SQL = SQL & " WHERE K7611_AutoKey		 =  " & AutoKey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7611_CLEAR() : GoTo SKIP_READ_PFK7611

            Call K7611_MOVE(rd)
            READ_PFK7611 = True

SKIP_READ_PFK7611:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7611", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK7611(AUTOKEY As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7611 "
            SQL = SQL & " WHERE K7611_AutoKey		 =  " & AutoKey & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK7611", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK7611(z7611 As T7611_AREA) As Boolean
        WRITE_PFK7611 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7611)

            SQL = " INSERT INTO PFK7611 "
            SQL = SQL & " ( "
            SQL = SQL & " K7611_AutoKey_K7103,"
            SQL = SQL & " K7611_Dseq,"
            SQL = SQL & " K7611_ComponentName,"
            SQL = SQL & " K7611_MaterialCode,"
            SQL = SQL & " K7611_Specification,"
            SQL = SQL & " K7611_Width,"
            SQL = SQL & " K7611_Height,"
            SQL = SQL & " K7611_SizeName,"
            SQL = SQL & " K7611_ColorName,"
            SQL = SQL & " K7611_seUnitMaterial,"
            SQL = SQL & " K7611_cdUnitMaterial,"
            SQL = SQL & " K7611_QtyBatch,"
            SQL = SQL & " K7611_seSubProcess,"
            SQL = SQL & " K7611_cdSubProcess,"
            SQL = SQL & " K7611_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "   " & FormatSQL(z7611.AutoKey_K7103) & ", "
            SQL = SQL & "   " & FormatSQL(z7611.Dseq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7611.ComponentName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7611.MaterialCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7611.Specification) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7611.Width) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7611.Height) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7611.SizeName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7611.ColorName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7611.seUnitMaterial) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7611.cdUnitMaterial) & "', "
            SQL = SQL & "   " & FormatSQL(z7611.QtyBatch) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7611.seSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7611.cdSubProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7611.Remark) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK7611 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK7611", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK7611(z7611 As T7611_AREA) As Boolean
        REWRITE_PFK7611 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7611)

            SQL = " UPDATE PFK7611 SET "
            SQL = SQL & "    K7611_AutoKey_K7103      =  " & FormatSQL(z7611.AutoKey_K7103) & ", "
            SQL = SQL & "    K7611_Dseq      =  " & FormatSQL(z7611.Dseq) & ", "
            SQL = SQL & "    K7611_ComponentName      = N'" & FormatSQL(z7611.ComponentName) & "', "
            SQL = SQL & "    K7611_MaterialCode      = N'" & FormatSQL(z7611.MaterialCode) & "', "
            SQL = SQL & "    K7611_Specification      = N'" & FormatSQL(z7611.Specification) & "', "
            SQL = SQL & "    K7611_Width      = N'" & FormatSQL(z7611.Width) & "', "
            SQL = SQL & "    K7611_Height      = N'" & FormatSQL(z7611.Height) & "', "
            SQL = SQL & "    K7611_SizeName      = N'" & FormatSQL(z7611.SizeName) & "', "
            SQL = SQL & "    K7611_ColorName      = N'" & FormatSQL(z7611.ColorName) & "', "
            SQL = SQL & "    K7611_seUnitMaterial      = N'" & FormatSQL(z7611.seUnitMaterial) & "', "
            SQL = SQL & "    K7611_cdUnitMaterial      = N'" & FormatSQL(z7611.cdUnitMaterial) & "', "
            SQL = SQL & "    K7611_QtyBatch      =  " & FormatSQL(z7611.QtyBatch) & ", "
            SQL = SQL & "    K7611_seSubProcess      = N'" & FormatSQL(z7611.seSubProcess) & "', "
            SQL = SQL & "    K7611_cdSubProcess      = N'" & FormatSQL(z7611.cdSubProcess) & "', "
            SQL = SQL & "    K7611_Remark      = N'" & FormatSQL(z7611.Remark) & "'  "
            SQL = SQL & " WHERE K7611_AutoKey		 =  " & z7611.AutoKey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK7611 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK7611", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK7611(z7611 As T7611_AREA) As Boolean
        DELETE_PFK7611 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK7611 "
            SQL = SQL & " WHERE K7611_AutoKey		 =  " & z7611.AutoKey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7611 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7611", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D7611_CLEAR()
        Try

            D7611.AutoKey = 0
            D7611.AutoKey_K7103 = 0
            D7611.Dseq = 0
            D7611.ComponentName = ""
            D7611.MaterialCode = ""
            D7611.Specification = ""
            D7611.Width = ""
            D7611.Height = ""
            D7611.SizeName = ""
            D7611.ColorName = ""
            D7611.seUnitMaterial = ""
            D7611.cdUnitMaterial = ""
            D7611.QtyBatch = 0
            D7611.seSubProcess = ""
            D7611.cdSubProcess = ""
            D7611.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D7611_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x7611 As T7611_AREA)
        Try

            x7611.AutoKey = trim$(x7611.AutoKey)
            x7611.AutoKey_K7103 = trim$(x7611.AutoKey_K7103)
            x7611.Dseq = trim$(x7611.Dseq)
            x7611.ComponentName = trim$(x7611.ComponentName)
            x7611.MaterialCode = trim$(x7611.MaterialCode)
            x7611.Specification = trim$(x7611.Specification)
            x7611.Width = trim$(x7611.Width)
            x7611.Height = trim$(x7611.Height)
            x7611.SizeName = trim$(x7611.SizeName)
            x7611.ColorName = trim$(x7611.ColorName)
            x7611.seUnitMaterial = trim$(x7611.seUnitMaterial)
            x7611.cdUnitMaterial = trim$(x7611.cdUnitMaterial)
            x7611.QtyBatch = trim$(x7611.QtyBatch)
            x7611.seSubProcess = trim$(x7611.seSubProcess)
            x7611.cdSubProcess = trim$(x7611.cdSubProcess)
            x7611.Remark = trim$(x7611.Remark)

            If trim$(x7611.AutoKey) = "" Then x7611.AutoKey = 0
            If trim$(x7611.AutoKey_K7103) = "" Then x7611.AutoKey_K7103 = 0
            If trim$(x7611.Dseq) = "" Then x7611.Dseq = 0
            If trim$(x7611.ComponentName) = "" Then x7611.ComponentName = Space(1)
            If trim$(x7611.MaterialCode) = "" Then x7611.MaterialCode = Space(1)
            If trim$(x7611.Specification) = "" Then x7611.Specification = Space(1)
            If trim$(x7611.Width) = "" Then x7611.Width = Space(1)
            If trim$(x7611.Height) = "" Then x7611.Height = Space(1)
            If trim$(x7611.SizeName) = "" Then x7611.SizeName = Space(1)
            If trim$(x7611.ColorName) = "" Then x7611.ColorName = Space(1)
            If trim$(x7611.seUnitMaterial) = "" Then x7611.seUnitMaterial = Space(1)
            If trim$(x7611.cdUnitMaterial) = "" Then x7611.cdUnitMaterial = Space(1)
            If trim$(x7611.QtyBatch) = "" Then x7611.QtyBatch = 0
            If trim$(x7611.seSubProcess) = "" Then x7611.seSubProcess = Space(1)
            If trim$(x7611.cdSubProcess) = "" Then x7611.cdSubProcess = Space(1)
            If trim$(x7611.Remark) = "" Then x7611.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K7611_MOVE(rs7611 As SqlClient.SqlDataReader)
        Try

            Call D7611_CLEAR()

            If IsdbNull(rs7611!K7611_AutoKey) = False Then D7611.AutoKey = Trim$(rs7611!K7611_AutoKey)
            If IsdbNull(rs7611!K7611_AutoKey_K7103) = False Then D7611.AutoKey_K7103 = Trim$(rs7611!K7611_AutoKey_K7103)
            If IsdbNull(rs7611!K7611_Dseq) = False Then D7611.Dseq = Trim$(rs7611!K7611_Dseq)
            If IsdbNull(rs7611!K7611_ComponentName) = False Then D7611.ComponentName = Trim$(rs7611!K7611_ComponentName)
            If IsdbNull(rs7611!K7611_MaterialCode) = False Then D7611.MaterialCode = Trim$(rs7611!K7611_MaterialCode)
            If IsdbNull(rs7611!K7611_Specification) = False Then D7611.Specification = Trim$(rs7611!K7611_Specification)
            If IsdbNull(rs7611!K7611_Width) = False Then D7611.Width = Trim$(rs7611!K7611_Width)
            If IsdbNull(rs7611!K7611_Height) = False Then D7611.Height = Trim$(rs7611!K7611_Height)
            If IsdbNull(rs7611!K7611_SizeName) = False Then D7611.SizeName = Trim$(rs7611!K7611_SizeName)
            If IsdbNull(rs7611!K7611_ColorName) = False Then D7611.ColorName = Trim$(rs7611!K7611_ColorName)
            If IsdbNull(rs7611!K7611_seUnitMaterial) = False Then D7611.seUnitMaterial = Trim$(rs7611!K7611_seUnitMaterial)
            If IsdbNull(rs7611!K7611_cdUnitMaterial) = False Then D7611.cdUnitMaterial = Trim$(rs7611!K7611_cdUnitMaterial)
            If IsdbNull(rs7611!K7611_QtyBatch) = False Then D7611.QtyBatch = Trim$(rs7611!K7611_QtyBatch)
            If IsdbNull(rs7611!K7611_seSubProcess) = False Then D7611.seSubProcess = Trim$(rs7611!K7611_seSubProcess)
            If IsdbNull(rs7611!K7611_cdSubProcess) = False Then D7611.cdSubProcess = Trim$(rs7611!K7611_cdSubProcess)
            If IsdbNull(rs7611!K7611_Remark) = False Then D7611.Remark = Trim$(rs7611!K7611_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7611_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K7611_MOVE(rs7611 As DataRow)
        Try

            Call D7611_CLEAR()

            If IsdbNull(rs7611!K7611_AutoKey) = False Then D7611.AutoKey = Trim$(rs7611!K7611_AutoKey)
            If IsdbNull(rs7611!K7611_AutoKey_K7103) = False Then D7611.AutoKey_K7103 = Trim$(rs7611!K7611_AutoKey_K7103)
            If IsdbNull(rs7611!K7611_Dseq) = False Then D7611.Dseq = Trim$(rs7611!K7611_Dseq)
            If IsdbNull(rs7611!K7611_ComponentName) = False Then D7611.ComponentName = Trim$(rs7611!K7611_ComponentName)
            If IsdbNull(rs7611!K7611_MaterialCode) = False Then D7611.MaterialCode = Trim$(rs7611!K7611_MaterialCode)
            If IsdbNull(rs7611!K7611_Specification) = False Then D7611.Specification = Trim$(rs7611!K7611_Specification)
            If IsdbNull(rs7611!K7611_Width) = False Then D7611.Width = Trim$(rs7611!K7611_Width)
            If IsdbNull(rs7611!K7611_Height) = False Then D7611.Height = Trim$(rs7611!K7611_Height)
            If IsdbNull(rs7611!K7611_SizeName) = False Then D7611.SizeName = Trim$(rs7611!K7611_SizeName)
            If IsdbNull(rs7611!K7611_ColorName) = False Then D7611.ColorName = Trim$(rs7611!K7611_ColorName)
            If IsdbNull(rs7611!K7611_seUnitMaterial) = False Then D7611.seUnitMaterial = Trim$(rs7611!K7611_seUnitMaterial)
            If IsdbNull(rs7611!K7611_cdUnitMaterial) = False Then D7611.cdUnitMaterial = Trim$(rs7611!K7611_cdUnitMaterial)
            If IsdbNull(rs7611!K7611_QtyBatch) = False Then D7611.QtyBatch = Trim$(rs7611!K7611_QtyBatch)
            If IsdbNull(rs7611!K7611_seSubProcess) = False Then D7611.seSubProcess = Trim$(rs7611!K7611_seSubProcess)
            If IsdbNull(rs7611!K7611_cdSubProcess) = False Then D7611.cdSubProcess = Trim$(rs7611!K7611_cdSubProcess)
            If IsdbNull(rs7611!K7611_Remark) = False Then D7611.Remark = Trim$(rs7611!K7611_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7611_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K7611_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7611 As T7611_AREA, AUTOKEY As Double) As Boolean

        K7611_MOVE = False

        Try
            If READ_PFK7611(AUTOKEY) = True Then
                z7611 = D7611
                K7611_MOVE = True
            Else
                z7611 = Nothing
            End If

            If getColumIndex(spr, "AutoKey") > -1 Then z7611.AutoKey = getDataM(spr, getColumIndex(spr, "AutoKey"), xRow)
            If getColumIndex(spr, "AutoKey_K7103") > -1 Then z7611.AutoKey_K7103 = getDataM(spr, getColumIndex(spr, "AutoKey_K7103"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z7611.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "ComponentName") > -1 Then z7611.ComponentName = getDataM(spr, getColumIndex(spr, "ComponentName"), xRow)
            If getColumIndex(spr, "MaterialCode") > -1 Then z7611.MaterialCode = getDataM(spr, getColumIndex(spr, "MaterialCode"), xRow)
            If getColumIndex(spr, "Specification") > -1 Then z7611.Specification = getDataM(spr, getColumIndex(spr, "Specification"), xRow)
            If getColumIndex(spr, "Width") > -1 Then z7611.Width = getDataM(spr, getColumIndex(spr, "Width"), xRow)
            If getColumIndex(spr, "Height") > -1 Then z7611.Height = getDataM(spr, getColumIndex(spr, "Height"), xRow)
            If getColumIndex(spr, "SizeName") > -1 Then z7611.SizeName = getDataM(spr, getColumIndex(spr, "SizeName"), xRow)
            If getColumIndex(spr, "ColorName") > -1 Then z7611.ColorName = getDataM(spr, getColumIndex(spr, "ColorName"), xRow)
            If getColumIndex(spr, "seUnitMaterial") > -1 Then z7611.seUnitMaterial = getDataM(spr, getColumIndex(spr, "seUnitMaterial"), xRow)
            If getColumIndex(spr, "cdUnitMaterial") > -1 Then z7611.cdUnitMaterial = getDataM(spr, getColumIndex(spr, "cdUnitMaterial"), xRow)
            If getColumIndex(spr, "QtyBatch") > -1 Then z7611.QtyBatch = getDataM(spr, getColumIndex(spr, "QtyBatch"), xRow)
            If getColumIndex(spr, "seSubProcess") > -1 Then z7611.seSubProcess = getDataM(spr, getColumIndex(spr, "seSubProcess"), xRow)
            If getColumIndex(spr, "cdSubProcess") > -1 Then z7611.cdSubProcess = getDataM(spr, getColumIndex(spr, "cdSubProcess"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z7611.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7611_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K7611_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7611 As T7611_AREA, CheckClear As Boolean, AUTOKEY As Double) As Boolean

        K7611_MOVE = False

        Try
            If READ_PFK7611(AUTOKEY) = True Then
                z7611 = D7611
                K7611_MOVE = True
            Else
                If CheckClear = True Then z7611 = Nothing
            End If

            If getColumIndex(spr, "AutoKey") > -1 Then z7611.AutoKey = getDataM(spr, getColumIndex(spr, "AutoKey"), xRow)
            If getColumIndex(spr, "AutoKey_K7103") > -1 Then z7611.AutoKey_K7103 = getDataM(spr, getColumIndex(spr, "AutoKey_K7103"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z7611.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "ComponentName") > -1 Then z7611.ComponentName = getDataM(spr, getColumIndex(spr, "ComponentName"), xRow)
            If getColumIndex(spr, "MaterialCode") > -1 Then z7611.MaterialCode = getDataM(spr, getColumIndex(spr, "MaterialCode"), xRow)
            If getColumIndex(spr, "Specification") > -1 Then z7611.Specification = getDataM(spr, getColumIndex(spr, "Specification"), xRow)
            If getColumIndex(spr, "Width") > -1 Then z7611.Width = getDataM(spr, getColumIndex(spr, "Width"), xRow)
            If getColumIndex(spr, "Height") > -1 Then z7611.Height = getDataM(spr, getColumIndex(spr, "Height"), xRow)
            If getColumIndex(spr, "SizeName") > -1 Then z7611.SizeName = getDataM(spr, getColumIndex(spr, "SizeName"), xRow)
            If getColumIndex(spr, "ColorName") > -1 Then z7611.ColorName = getDataM(spr, getColumIndex(spr, "ColorName"), xRow)
            If getColumIndex(spr, "seUnitMaterial") > -1 Then z7611.seUnitMaterial = getDataM(spr, getColumIndex(spr, "seUnitMaterial"), xRow)
            If getColumIndex(spr, "cdUnitMaterial") > -1 Then z7611.cdUnitMaterial = getDataM(spr, getColumIndex(spr, "cdUnitMaterial"), xRow)
            If getColumIndex(spr, "QtyBatch") > -1 Then z7611.QtyBatch = getDataM(spr, getColumIndex(spr, "QtyBatch"), xRow)
            If getColumIndex(spr, "seSubProcess") > -1 Then z7611.seSubProcess = getDataM(spr, getColumIndex(spr, "seSubProcess"), xRow)
            If getColumIndex(spr, "cdSubProcess") > -1 Then z7611.cdSubProcess = getDataM(spr, getColumIndex(spr, "cdSubProcess"), xRow)
            If getColumIndex(spr, "Remark") > -1 Then z7611.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7611_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K7611_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7611 As T7611_AREA, Job As String, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7611_MOVE = False

        Try
            If READ_PFK7611(AUTOKEY) = True Then
                z7611 = D7611
                K7611_MOVE = True
            Else
                z7611 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7611")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z7611.AutoKey = Children(i).Code
                                Case "AUTOKEY_K7103" : z7611.AutoKey_K7103 = Children(i).Code
                                Case "DSEQ" : z7611.Dseq = Children(i).Code
                                Case "COMPONENTNAME" : z7611.ComponentName = Children(i).Code
                                Case "MATERIALCODE" : z7611.MaterialCode = Children(i).Code
                                Case "SPECIFICATION" : z7611.Specification = Children(i).Code
                                Case "WIDTH" : z7611.Width = Children(i).Code
                                Case "HEIGHT" : z7611.Height = Children(i).Code
                                Case "SIZENAME" : z7611.SizeName = Children(i).Code
                                Case "COLORNAME" : z7611.ColorName = Children(i).Code
                                Case "SEUNITMATERIAL" : z7611.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z7611.cdUnitMaterial = Children(i).Code
                                Case "QTYBATCH" : z7611.QtyBatch = Children(i).Code
                                Case "SESUBPROCESS" : z7611.seSubProcess = Children(i).Code
                                Case "CDSUBPROCESS" : z7611.cdSubProcess = Children(i).Code
                                Case "REMARK" : z7611.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z7611.AutoKey = Children(i).Data
                                Case "AUTOKEY_K7103" : z7611.AutoKey_K7103 = Children(i).Data
                                Case "DSEQ" : z7611.Dseq = Children(i).Data
                                Case "COMPONENTNAME" : z7611.ComponentName = Children(i).Data
                                Case "MATERIALCODE" : z7611.MaterialCode = Children(i).Data
                                Case "SPECIFICATION" : z7611.Specification = Children(i).Data
                                Case "WIDTH" : z7611.Width = Children(i).Data
                                Case "HEIGHT" : z7611.Height = Children(i).Data
                                Case "SIZENAME" : z7611.SizeName = Children(i).Data
                                Case "COLORNAME" : z7611.ColorName = Children(i).Data
                                Case "SEUNITMATERIAL" : z7611.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z7611.cdUnitMaterial = Children(i).Data
                                Case "QTYBATCH" : z7611.QtyBatch = Children(i).Data
                                Case "SESUBPROCESS" : z7611.seSubProcess = Children(i).Data
                                Case "CDSUBPROCESS" : z7611.cdSubProcess = Children(i).Data
                                Case "REMARK" : z7611.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7611_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K7611_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7611 As T7611_AREA, Job As String, CheckClear As Boolean, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7611_MOVE = False

        Try
            If READ_PFK7611(AUTOKEY) = True Then
                z7611 = D7611
                K7611_MOVE = True
            Else
                If CheckClear = True Then z7611 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7611")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z7611.AutoKey = Children(i).Code
                                Case "AUTOKEY_K7103" : z7611.AutoKey_K7103 = Children(i).Code
                                Case "DSEQ" : z7611.Dseq = Children(i).Code
                                Case "COMPONENTNAME" : z7611.ComponentName = Children(i).Code
                                Case "MATERIALCODE" : z7611.MaterialCode = Children(i).Code
                                Case "SPECIFICATION" : z7611.Specification = Children(i).Code
                                Case "WIDTH" : z7611.Width = Children(i).Code
                                Case "HEIGHT" : z7611.Height = Children(i).Code
                                Case "SIZENAME" : z7611.SizeName = Children(i).Code
                                Case "COLORNAME" : z7611.ColorName = Children(i).Code
                                Case "SEUNITMATERIAL" : z7611.seUnitMaterial = Children(i).Code
                                Case "CDUNITMATERIAL" : z7611.cdUnitMaterial = Children(i).Code
                                Case "QTYBATCH" : z7611.QtyBatch = Children(i).Code
                                Case "SESUBPROCESS" : z7611.seSubProcess = Children(i).Code
                                Case "CDSUBPROCESS" : z7611.cdSubProcess = Children(i).Code
                                Case "REMARK" : z7611.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z7611.AutoKey = Children(i).Data
                                Case "AUTOKEY_K7103" : z7611.AutoKey_K7103 = Children(i).Data
                                Case "DSEQ" : z7611.Dseq = Children(i).Data
                                Case "COMPONENTNAME" : z7611.ComponentName = Children(i).Data
                                Case "MATERIALCODE" : z7611.MaterialCode = Children(i).Data
                                Case "SPECIFICATION" : z7611.Specification = Children(i).Data
                                Case "WIDTH" : z7611.Width = Children(i).Data
                                Case "HEIGHT" : z7611.Height = Children(i).Data
                                Case "SIZENAME" : z7611.SizeName = Children(i).Data
                                Case "COLORNAME" : z7611.ColorName = Children(i).Data
                                Case "SEUNITMATERIAL" : z7611.seUnitMaterial = Children(i).Data
                                Case "CDUNITMATERIAL" : z7611.cdUnitMaterial = Children(i).Data
                                Case "QTYBATCH" : z7611.QtyBatch = Children(i).Data
                                Case "SESUBPROCESS" : z7611.seSubProcess = Children(i).Data
                                Case "CDSUBPROCESS" : z7611.cdSubProcess = Children(i).Data
                                Case "REMARK" : z7611.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7611_MOVE", vbCritical)
        End Try
    End Function

End Module
