'=========================================================================================================================================================
'   TABLE : (PFK0108)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K0108

    Structure T0108_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public Autokey As Double  '			decimal		*
        Public Dseq As Double  '			decimal
        Public SpecNo As String  '			char(9)
        Public SpecNoSeq As String  '			char(3)
        Public MaterialSeq As Double  '			decimal
        Public SizeBegin As String  '			char(2)
        Public SizeEnd As String  '			char(2)
        Public SizeBeginName As String  '			nvarchar(50)
        Public SizeEndName As String  '			nvarchar(50)
        Public MaterialCode As String  '			char(6)
        Public Color As String  '			nvarchar(200)
        Public Specification As String  '			nvarchar(20)
        Public Width As String  '			nvarchar(20)
        Public Height As String  '			nvarchar(20)
        Public SizeName As String  '			nvarchar(20)
        Public ColorName As String  '			nvarchar(100)
        Public QtySize As Double  '			decimal
        Public LossSize As Double  '			decimal
        Public QtyUsage As Double  '			decimal
        '=========================================================================================================================================================
    End Structure

    Public D0108 As T0108_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK0108(AUTOKEY As Double) As Boolean
        READ_PFK0108 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK0108 "
            SQL = SQL & " WHERE K0108_Autokey		 =  " & Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D0108_CLEAR() : GoTo SKIP_READ_PFK0108

            Call K0108_MOVE(rd)
            READ_PFK0108 = True

SKIP_READ_PFK0108:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK0108", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK0108(AUTOKEY As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK0108 "
            SQL = SQL & " WHERE K0108_Autokey		 =  " & Autokey & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK0108", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK0108(z0108 As T0108_AREA) As Boolean
        WRITE_PFK0108 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z0108)

            SQL = " INSERT INTO PFK0108 "
            SQL = SQL & " ( "
            SQL = SQL & " K0108_Dseq,"
            SQL = SQL & " K0108_SpecNo,"
            SQL = SQL & " K0108_SpecNoSeq,"
            SQL = SQL & " K0108_MaterialSeq,"
            SQL = SQL & " K0108_SizeBegin,"
            SQL = SQL & " K0108_SizeEnd,"
            SQL = SQL & " K0108_SizeBeginName,"
            SQL = SQL & " K0108_SizeEndName,"
            SQL = SQL & " K0108_MaterialCode,"
            SQL = SQL & " K0108_Color,"
            SQL = SQL & " K0108_Specification,"
            SQL = SQL & " K0108_Width,"
            SQL = SQL & " K0108_Height,"
            SQL = SQL & " K0108_SizeName,"
            SQL = SQL & " K0108_ColorName,"
            SQL = SQL & " K0108_QtySize,"
            SQL = SQL & " K0108_LossSize,"
            SQL = SQL & " K0108_QtyUsage "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "   " & FormatSQL(z0108.Dseq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0108.SpecNo) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0108.SpecNoSeq) & "', "
            SQL = SQL & "   " & FormatSQL(z0108.MaterialSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z0108.SizeBegin) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0108.SizeEnd) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0108.SizeBeginName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0108.SizeEndName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0108.MaterialCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0108.Color) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0108.Specification) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0108.Width) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0108.Height) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0108.SizeName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z0108.ColorName) & "', "
            SQL = SQL & "   " & FormatSQL(z0108.QtySize) & ", "
            SQL = SQL & "   " & FormatSQL(z0108.LossSize) & ", "
            SQL = SQL & "   " & FormatSQL(z0108.QtyUsage) & "  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK0108 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK0108", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK0108(z0108 As T0108_AREA) As Boolean
        REWRITE_PFK0108 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z0108)

            SQL = " UPDATE PFK0108 SET "
            SQL = SQL & "    K0108_Dseq      =  " & FormatSQL(z0108.Dseq) & ", "
            SQL = SQL & "    K0108_SpecNo      = N'" & FormatSQL(z0108.SpecNo) & "', "
            SQL = SQL & "    K0108_SpecNoSeq      = N'" & FormatSQL(z0108.SpecNoSeq) & "', "
            SQL = SQL & "    K0108_MaterialSeq      =  " & FormatSQL(z0108.MaterialSeq) & ", "
            SQL = SQL & "    K0108_SizeBegin      = N'" & FormatSQL(z0108.SizeBegin) & "', "
            SQL = SQL & "    K0108_SizeEnd      = N'" & FormatSQL(z0108.SizeEnd) & "', "
            SQL = SQL & "    K0108_SizeBeginName      = N'" & FormatSQL(z0108.SizeBeginName) & "', "
            SQL = SQL & "    K0108_SizeEndName      = N'" & FormatSQL(z0108.SizeEndName) & "', "
            SQL = SQL & "    K0108_MaterialCode      = N'" & FormatSQL(z0108.MaterialCode) & "', "
            SQL = SQL & "    K0108_Color      = N'" & FormatSQL(z0108.Color) & "', "
            SQL = SQL & "    K0108_Specification      = N'" & FormatSQL(z0108.Specification) & "', "
            SQL = SQL & "    K0108_Width      = N'" & FormatSQL(z0108.Width) & "', "
            SQL = SQL & "    K0108_Height      = N'" & FormatSQL(z0108.Height) & "', "
            SQL = SQL & "    K0108_SizeName      = N'" & FormatSQL(z0108.SizeName) & "', "
            SQL = SQL & "    K0108_ColorName      = N'" & FormatSQL(z0108.ColorName) & "', "
            SQL = SQL & "    K0108_QtySize      =  " & FormatSQL(z0108.QtySize) & ", "
            SQL = SQL & "    K0108_LossSize      =  " & FormatSQL(z0108.LossSize) & ", "
            SQL = SQL & "    K0108_QtyUsage      =  " & FormatSQL(z0108.QtyUsage) & "  "
            SQL = SQL & " WHERE K0108_Autokey		 =  " & z0108.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK0108 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK0108", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK0108(z0108 As T0108_AREA) As Boolean
        DELETE_PFK0108 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK0108 "
            SQL = SQL & " WHERE K0108_Autokey		 =  " & z0108.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK0108 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK0108", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D0108_CLEAR()
        Try

            D0108.Autokey = 0
            D0108.Dseq = 0
            D0108.SpecNo = ""
            D0108.SpecNoSeq = ""
            D0108.MaterialSeq = 0
            D0108.SizeBegin = ""
            D0108.SizeEnd = ""
            D0108.SizeBeginName = ""
            D0108.SizeEndName = ""
            D0108.MaterialCode = ""
            D0108.Color = ""
            D0108.Specification = ""
            D0108.Width = ""
            D0108.Height = ""
            D0108.SizeName = ""
            D0108.ColorName = ""
            D0108.QtySize = 0
            D0108.LossSize = 0
            D0108.QtyUsage = 0


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D0108_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x0108 As T0108_AREA)
        Try

            x0108.Autokey = trim$(x0108.Autokey)
            x0108.Dseq = trim$(x0108.Dseq)
            x0108.SpecNo = trim$(x0108.SpecNo)
            x0108.SpecNoSeq = trim$(x0108.SpecNoSeq)
            x0108.MaterialSeq = trim$(x0108.MaterialSeq)
            x0108.SizeBegin = trim$(x0108.SizeBegin)
            x0108.SizeEnd = trim$(x0108.SizeEnd)
            x0108.SizeBeginName = trim$(x0108.SizeBeginName)
            x0108.SizeEndName = trim$(x0108.SizeEndName)
            x0108.MaterialCode = trim$(x0108.MaterialCode)
            x0108.Color = trim$(x0108.Color)
            x0108.Specification = trim$(x0108.Specification)
            x0108.Width = trim$(x0108.Width)
            x0108.Height = trim$(x0108.Height)
            x0108.SizeName = trim$(x0108.SizeName)
            x0108.ColorName = trim$(x0108.ColorName)
            x0108.QtySize = trim$(x0108.QtySize)
            x0108.LossSize = trim$(x0108.LossSize)
            x0108.QtyUsage = trim$(x0108.QtyUsage)

            If trim$(x0108.Autokey) = "" Then x0108.Autokey = 0
            If trim$(x0108.Dseq) = "" Then x0108.Dseq = 0
            If trim$(x0108.SpecNo) = "" Then x0108.SpecNo = Space(1)
            If trim$(x0108.SpecNoSeq) = "" Then x0108.SpecNoSeq = Space(1)
            If trim$(x0108.MaterialSeq) = "" Then x0108.MaterialSeq = 0
            If trim$(x0108.SizeBegin) = "" Then x0108.SizeBegin = Space(1)
            If trim$(x0108.SizeEnd) = "" Then x0108.SizeEnd = Space(1)
            If trim$(x0108.SizeBeginName) = "" Then x0108.SizeBeginName = Space(1)
            If trim$(x0108.SizeEndName) = "" Then x0108.SizeEndName = Space(1)
            If trim$(x0108.MaterialCode) = "" Then x0108.MaterialCode = Space(1)
            If trim$(x0108.Color) = "" Then x0108.Color = Space(1)
            If trim$(x0108.Specification) = "" Then x0108.Specification = Space(1)
            If trim$(x0108.Width) = "" Then x0108.Width = Space(1)
            If trim$(x0108.Height) = "" Then x0108.Height = Space(1)
            If trim$(x0108.SizeName) = "" Then x0108.SizeName = Space(1)
            If trim$(x0108.ColorName) = "" Then x0108.ColorName = Space(1)
            If trim$(x0108.QtySize) = "" Then x0108.QtySize = 0
            If trim$(x0108.LossSize) = "" Then x0108.LossSize = 0
            If trim$(x0108.QtyUsage) = "" Then x0108.QtyUsage = 0


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K0108_MOVE(rs0108 As SqlClient.SqlDataReader)
        Try

            Call D0108_CLEAR()

            If IsdbNull(rs0108!K0108_Autokey) = False Then D0108.Autokey = Trim$(rs0108!K0108_Autokey)
            If IsdbNull(rs0108!K0108_Dseq) = False Then D0108.Dseq = Trim$(rs0108!K0108_Dseq)
            If IsdbNull(rs0108!K0108_SpecNo) = False Then D0108.SpecNo = Trim$(rs0108!K0108_SpecNo)
            If IsdbNull(rs0108!K0108_SpecNoSeq) = False Then D0108.SpecNoSeq = Trim$(rs0108!K0108_SpecNoSeq)
            If IsdbNull(rs0108!K0108_MaterialSeq) = False Then D0108.MaterialSeq = Trim$(rs0108!K0108_MaterialSeq)
            If IsdbNull(rs0108!K0108_SizeBegin) = False Then D0108.SizeBegin = Trim$(rs0108!K0108_SizeBegin)
            If IsdbNull(rs0108!K0108_SizeEnd) = False Then D0108.SizeEnd = Trim$(rs0108!K0108_SizeEnd)
            If IsdbNull(rs0108!K0108_SizeBeginName) = False Then D0108.SizeBeginName = Trim$(rs0108!K0108_SizeBeginName)
            If IsdbNull(rs0108!K0108_SizeEndName) = False Then D0108.SizeEndName = Trim$(rs0108!K0108_SizeEndName)
            If IsdbNull(rs0108!K0108_MaterialCode) = False Then D0108.MaterialCode = Trim$(rs0108!K0108_MaterialCode)
            If IsdbNull(rs0108!K0108_Color) = False Then D0108.Color = Trim$(rs0108!K0108_Color)
            If IsdbNull(rs0108!K0108_Specification) = False Then D0108.Specification = Trim$(rs0108!K0108_Specification)
            If IsdbNull(rs0108!K0108_Width) = False Then D0108.Width = Trim$(rs0108!K0108_Width)
            If IsdbNull(rs0108!K0108_Height) = False Then D0108.Height = Trim$(rs0108!K0108_Height)
            If IsdbNull(rs0108!K0108_SizeName) = False Then D0108.SizeName = Trim$(rs0108!K0108_SizeName)
            If IsdbNull(rs0108!K0108_ColorName) = False Then D0108.ColorName = Trim$(rs0108!K0108_ColorName)
            If IsdbNull(rs0108!K0108_QtySize) = False Then D0108.QtySize = Trim$(rs0108!K0108_QtySize)
            If IsdbNull(rs0108!K0108_LossSize) = False Then D0108.LossSize = Trim$(rs0108!K0108_LossSize)
            If IsdbNull(rs0108!K0108_QtyUsage) = False Then D0108.QtyUsage = Trim$(rs0108!K0108_QtyUsage)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K0108_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K0108_MOVE(rs0108 As DataRow)
        Try

            Call D0108_CLEAR()

            If IsdbNull(rs0108!K0108_Autokey) = False Then D0108.Autokey = Trim$(rs0108!K0108_Autokey)
            If IsdbNull(rs0108!K0108_Dseq) = False Then D0108.Dseq = Trim$(rs0108!K0108_Dseq)
            If IsdbNull(rs0108!K0108_SpecNo) = False Then D0108.SpecNo = Trim$(rs0108!K0108_SpecNo)
            If IsdbNull(rs0108!K0108_SpecNoSeq) = False Then D0108.SpecNoSeq = Trim$(rs0108!K0108_SpecNoSeq)
            If IsdbNull(rs0108!K0108_MaterialSeq) = False Then D0108.MaterialSeq = Trim$(rs0108!K0108_MaterialSeq)
            If IsdbNull(rs0108!K0108_SizeBegin) = False Then D0108.SizeBegin = Trim$(rs0108!K0108_SizeBegin)
            If IsdbNull(rs0108!K0108_SizeEnd) = False Then D0108.SizeEnd = Trim$(rs0108!K0108_SizeEnd)
            If IsdbNull(rs0108!K0108_SizeBeginName) = False Then D0108.SizeBeginName = Trim$(rs0108!K0108_SizeBeginName)
            If IsdbNull(rs0108!K0108_SizeEndName) = False Then D0108.SizeEndName = Trim$(rs0108!K0108_SizeEndName)
            If IsdbNull(rs0108!K0108_MaterialCode) = False Then D0108.MaterialCode = Trim$(rs0108!K0108_MaterialCode)
            If IsdbNull(rs0108!K0108_Color) = False Then D0108.Color = Trim$(rs0108!K0108_Color)
            If IsdbNull(rs0108!K0108_Specification) = False Then D0108.Specification = Trim$(rs0108!K0108_Specification)
            If IsdbNull(rs0108!K0108_Width) = False Then D0108.Width = Trim$(rs0108!K0108_Width)
            If IsdbNull(rs0108!K0108_Height) = False Then D0108.Height = Trim$(rs0108!K0108_Height)
            If IsdbNull(rs0108!K0108_SizeName) = False Then D0108.SizeName = Trim$(rs0108!K0108_SizeName)
            If IsdbNull(rs0108!K0108_ColorName) = False Then D0108.ColorName = Trim$(rs0108!K0108_ColorName)
            If IsdbNull(rs0108!K0108_QtySize) = False Then D0108.QtySize = Trim$(rs0108!K0108_QtySize)
            If IsdbNull(rs0108!K0108_LossSize) = False Then D0108.LossSize = Trim$(rs0108!K0108_LossSize)
            If IsdbNull(rs0108!K0108_QtyUsage) = False Then D0108.QtyUsage = Trim$(rs0108!K0108_QtyUsage)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K0108_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K0108_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z0108 As T0108_AREA, AUTOKEY As Double) As Boolean

        K0108_MOVE = False

        Try
            If READ_PFK0108(AUTOKEY) = True Then
                z0108 = D0108
                K0108_MOVE = True
            Else
                z0108 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z0108.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z0108.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "SpecNo") > -1 Then z0108.SpecNo = getDataM(spr, getColumIndex(spr, "SpecNo"), xRow)
            If getColumIndex(spr, "SpecNoSeq") > -1 Then z0108.SpecNoSeq = getDataM(spr, getColumIndex(spr, "SpecNoSeq"), xRow)
            If getColumIndex(spr, "MaterialSeq") > -1 Then z0108.MaterialSeq = getDataM(spr, getColumIndex(spr, "MaterialSeq"), xRow)
            If getColumIndex(spr, "SizeBegin") > -1 Then z0108.SizeBegin = getDataM(spr, getColumIndex(spr, "SizeBegin"), xRow)
            If getColumIndex(spr, "SizeEnd") > -1 Then z0108.SizeEnd = getDataM(spr, getColumIndex(spr, "SizeEnd"), xRow)
            If getColumIndex(spr, "SizeBeginName") > -1 Then z0108.SizeBeginName = getDataM(spr, getColumIndex(spr, "SizeBeginName"), xRow)
            If getColumIndex(spr, "SizeEndName") > -1 Then z0108.SizeEndName = getDataM(spr, getColumIndex(spr, "SizeEndName"), xRow)
            If getColumIndex(spr, "MaterialCode") > -1 Then z0108.MaterialCode = getDataM(spr, getColumIndex(spr, "MaterialCode"), xRow)
            If getColumIndex(spr, "Color") > -1 Then z0108.Color = getDataM(spr, getColumIndex(spr, "Color"), xRow)
            If getColumIndex(spr, "Specification") > -1 Then z0108.Specification = getDataM(spr, getColumIndex(spr, "Specification"), xRow)
            If getColumIndex(spr, "Width") > -1 Then z0108.Width = getDataM(spr, getColumIndex(spr, "Width"), xRow)
            If getColumIndex(spr, "Height") > -1 Then z0108.Height = getDataM(spr, getColumIndex(spr, "Height"), xRow)
            If getColumIndex(spr, "SizeName") > -1 Then z0108.SizeName = getDataM(spr, getColumIndex(spr, "SizeName"), xRow)
            If getColumIndex(spr, "ColorName") > -1 Then z0108.ColorName = getDataM(spr, getColumIndex(spr, "ColorName"), xRow)
            If getColumIndex(spr, "QtySize") > -1 Then z0108.QtySize = getDataM(spr, getColumIndex(spr, "QtySize"), xRow)
            If getColumIndex(spr, "LossSize") > -1 Then z0108.LossSize = getDataM(spr, getColumIndex(spr, "LossSize"), xRow)
            If getColumIndex(spr, "QtyUsage") > -1 Then z0108.QtyUsage = getDataM(spr, getColumIndex(spr, "QtyUsage"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K0108_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K0108_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z0108 As T0108_AREA, CheckClear As Boolean, AUTOKEY As Double) As Boolean

        K0108_MOVE = False

        Try
            If READ_PFK0108(AUTOKEY) = True Then
                z0108 = D0108
                K0108_MOVE = True
            Else
                If CheckClear = True Then z0108 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z0108.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z0108.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "SpecNo") > -1 Then z0108.SpecNo = getDataM(spr, getColumIndex(spr, "SpecNo"), xRow)
            If getColumIndex(spr, "SpecNoSeq") > -1 Then z0108.SpecNoSeq = getDataM(spr, getColumIndex(spr, "SpecNoSeq"), xRow)
            If getColumIndex(spr, "MaterialSeq") > -1 Then z0108.MaterialSeq = getDataM(spr, getColumIndex(spr, "MaterialSeq"), xRow)
            If getColumIndex(spr, "SizeBegin") > -1 Then z0108.SizeBegin = getDataM(spr, getColumIndex(spr, "SizeBegin"), xRow)
            If getColumIndex(spr, "SizeEnd") > -1 Then z0108.SizeEnd = getDataM(spr, getColumIndex(spr, "SizeEnd"), xRow)
            If getColumIndex(spr, "SizeBeginName") > -1 Then z0108.SizeBeginName = getDataM(spr, getColumIndex(spr, "SizeBeginName"), xRow)
            If getColumIndex(spr, "SizeEndName") > -1 Then z0108.SizeEndName = getDataM(spr, getColumIndex(spr, "SizeEndName"), xRow)
            If getColumIndex(spr, "MaterialCode") > -1 Then z0108.MaterialCode = getDataM(spr, getColumIndex(spr, "MaterialCode"), xRow)
            If getColumIndex(spr, "Color") > -1 Then z0108.Color = getDataM(spr, getColumIndex(spr, "Color"), xRow)
            If getColumIndex(spr, "Specification") > -1 Then z0108.Specification = getDataM(spr, getColumIndex(spr, "Specification"), xRow)
            If getColumIndex(spr, "Width") > -1 Then z0108.Width = getDataM(spr, getColumIndex(spr, "Width"), xRow)
            If getColumIndex(spr, "Height") > -1 Then z0108.Height = getDataM(spr, getColumIndex(spr, "Height"), xRow)
            If getColumIndex(spr, "SizeName") > -1 Then z0108.SizeName = getDataM(spr, getColumIndex(spr, "SizeName"), xRow)
            If getColumIndex(spr, "ColorName") > -1 Then z0108.ColorName = getDataM(spr, getColumIndex(spr, "ColorName"), xRow)
            If getColumIndex(spr, "QtySize") > -1 Then z0108.QtySize = getDataM(spr, getColumIndex(spr, "QtySize"), xRow)
            If getColumIndex(spr, "LossSize") > -1 Then z0108.LossSize = getDataM(spr, getColumIndex(spr, "LossSize"), xRow)
            If getColumIndex(spr, "QtyUsage") > -1 Then z0108.QtyUsage = getDataM(spr, getColumIndex(spr, "QtyUsage"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K0108_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K0108_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z0108 As T0108_AREA, Job As String, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K0108_MOVE = False

        Try
            If READ_PFK0108(AUTOKEY) = True Then
                z0108 = D0108
                K0108_MOVE = True
            Else
                z0108 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0108")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z0108.Autokey = Children(i).Code
                                Case "DSEQ" : z0108.Dseq = Children(i).Code
                                Case "SPECNO" : z0108.SpecNo = Children(i).Code
                                Case "SPECNOSEQ" : z0108.SpecNoSeq = Children(i).Code
                                Case "MATERIALSEQ" : z0108.MaterialSeq = Children(i).Code
                                Case "SIZEBEGIN" : z0108.SizeBegin = Children(i).Code
                                Case "SIZEEND" : z0108.SizeEnd = Children(i).Code
                                Case "SIZEBEGINNAME" : z0108.SizeBeginName = Children(i).Code
                                Case "SIZEENDNAME" : z0108.SizeEndName = Children(i).Code
                                Case "MATERIALCODE" : z0108.MaterialCode = Children(i).Code
                                Case "COLOR" : z0108.Color = Children(i).Code
                                Case "SPECIFICATION" : z0108.Specification = Children(i).Code
                                Case "WIDTH" : z0108.Width = Children(i).Code
                                Case "HEIGHT" : z0108.Height = Children(i).Code
                                Case "SIZENAME" : z0108.SizeName = Children(i).Code
                                Case "COLORNAME" : z0108.ColorName = Children(i).Code
                                Case "QTYSIZE" : z0108.QtySize = Children(i).Code
                                Case "LOSSSIZE" : z0108.LossSize = Children(i).Code
                                Case "QTYUSAGE" : z0108.QtyUsage = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z0108.Autokey = Children(i).Data
                                Case "DSEQ" : z0108.Dseq = Children(i).Data
                                Case "SPECNO" : z0108.SpecNo = Children(i).Data
                                Case "SPECNOSEQ" : z0108.SpecNoSeq = Children(i).Data
                                Case "MATERIALSEQ" : z0108.MaterialSeq = Children(i).Data
                                Case "SIZEBEGIN" : z0108.SizeBegin = Children(i).Data
                                Case "SIZEEND" : z0108.SizeEnd = Children(i).Data
                                Case "SIZEBEGINNAME" : z0108.SizeBeginName = Children(i).Data
                                Case "SIZEENDNAME" : z0108.SizeEndName = Children(i).Data
                                Case "MATERIALCODE" : z0108.MaterialCode = Children(i).Data
                                Case "COLOR" : z0108.Color = Children(i).Data
                                Case "SPECIFICATION" : z0108.Specification = Children(i).Data
                                Case "WIDTH" : z0108.Width = Children(i).Data
                                Case "HEIGHT" : z0108.Height = Children(i).Data
                                Case "SIZENAME" : z0108.SizeName = Children(i).Data
                                Case "COLORNAME" : z0108.ColorName = Children(i).Data
                                Case "QTYSIZE" : z0108.QtySize = Children(i).Data
                                Case "LOSSSIZE" : z0108.LossSize = Children(i).Data
                                Case "QTYUSAGE" : z0108.QtyUsage = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K0108_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K0108_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z0108 As T0108_AREA, Job As String, CheckClear As Boolean, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K0108_MOVE = False

        Try
            If READ_PFK0108(AUTOKEY) = True Then
                z0108 = D0108
                K0108_MOVE = True
            Else
                If CheckClear = True Then z0108 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK0108")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z0108.Autokey = Children(i).Code
                                Case "DSEQ" : z0108.Dseq = Children(i).Code
                                Case "SPECNO" : z0108.SpecNo = Children(i).Code
                                Case "SPECNOSEQ" : z0108.SpecNoSeq = Children(i).Code
                                Case "MATERIALSEQ" : z0108.MaterialSeq = Children(i).Code
                                Case "SIZEBEGIN" : z0108.SizeBegin = Children(i).Code
                                Case "SIZEEND" : z0108.SizeEnd = Children(i).Code
                                Case "SIZEBEGINNAME" : z0108.SizeBeginName = Children(i).Code
                                Case "SIZEENDNAME" : z0108.SizeEndName = Children(i).Code
                                Case "MATERIALCODE" : z0108.MaterialCode = Children(i).Code
                                Case "COLOR" : z0108.Color = Children(i).Code
                                Case "SPECIFICATION" : z0108.Specification = Children(i).Code
                                Case "WIDTH" : z0108.Width = Children(i).Code
                                Case "HEIGHT" : z0108.Height = Children(i).Code
                                Case "SIZENAME" : z0108.SizeName = Children(i).Code
                                Case "COLORNAME" : z0108.ColorName = Children(i).Code
                                Case "QTYSIZE" : z0108.QtySize = Children(i).Code
                                Case "LOSSSIZE" : z0108.LossSize = Children(i).Code
                                Case "QTYUSAGE" : z0108.QtyUsage = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z0108.Autokey = Children(i).Data
                                Case "DSEQ" : z0108.Dseq = Children(i).Data
                                Case "SPECNO" : z0108.SpecNo = Children(i).Data
                                Case "SPECNOSEQ" : z0108.SpecNoSeq = Children(i).Data
                                Case "MATERIALSEQ" : z0108.MaterialSeq = Children(i).Data
                                Case "SIZEBEGIN" : z0108.SizeBegin = Children(i).Data
                                Case "SIZEEND" : z0108.SizeEnd = Children(i).Data
                                Case "SIZEBEGINNAME" : z0108.SizeBeginName = Children(i).Data
                                Case "SIZEENDNAME" : z0108.SizeEndName = Children(i).Data
                                Case "MATERIALCODE" : z0108.MaterialCode = Children(i).Data
                                Case "COLOR" : z0108.Color = Children(i).Data
                                Case "SPECIFICATION" : z0108.Specification = Children(i).Data
                                Case "WIDTH" : z0108.Width = Children(i).Data
                                Case "HEIGHT" : z0108.Height = Children(i).Data
                                Case "SIZENAME" : z0108.SizeName = Children(i).Data
                                Case "COLORNAME" : z0108.ColorName = Children(i).Data
                                Case "QTYSIZE" : z0108.QtySize = Children(i).Data
                                Case "LOSSSIZE" : z0108.LossSize = Children(i).Data
                                Case "QTYUSAGE" : z0108.QtyUsage = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K0108_MOVE", vbCritical)
        End Try
    End Function

End Module
