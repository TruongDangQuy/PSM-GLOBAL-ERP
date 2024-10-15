'=========================================================================================================================================================
'   TABLE : (PFK7113)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7113

Structure T7113_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	Autokey	 AS Double	'			decimal		*
Public 	Dseq	 AS Double	'			decimal
Public 	BaseComponentBOM	 AS String	'			char(6)
Public 	ShoesCode	 AS String	'			char(6)
Public 	MaterialSeq	 AS Double	'			decimal
Public 	SizeBegin	 AS String	'			char(2)
Public 	SizeEnd	 AS String	'			char(2)
        Public ComponentName As String  '			nvarchar(50)
        Public SizeBeginName As String  '			nvarchar(4)
        Public SizeEndName As String  '			nvarchar(4)
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
        Public DateInsert As String  '			char(8)
        Public DateUpdate As String  '			char(8)
        Public InchargeInsert As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        '=========================================================================================================================================================
    End Structure

    Public D7113 As T7113_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK7113(AUTOKEY As Double) As Boolean
        READ_PFK7113 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7113 "
            SQL = SQL & " WHERE K7113_Autokey		 =  " & Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7113_CLEAR() : GoTo SKIP_READ_PFK7113

            Call K7113_MOVE(rd)
            READ_PFK7113 = True

SKIP_READ_PFK7113:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7113", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK7113(AUTOKEY As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7113 "
            SQL = SQL & " WHERE K7113_Autokey		 =  " & Autokey & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK7113", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK7113(z7113 As T7113_AREA) As Boolean
        WRITE_PFK7113 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7113)

            SQL = " INSERT INTO PFK7113 "
            SQL = SQL & " ( "
            SQL = SQL & " K7113_Dseq,"
            SQL = SQL & " K7113_BaseComponentBOM,"
            SQL = SQL & " K7113_ShoesCode,"
            SQL = SQL & " K7113_MaterialSeq,"
            SQL = SQL & " K7113_SizeBegin,"
            SQL = SQL & " K7113_SizeEnd,"
            SQL = SQL & " K7113_ComponentName,"
            SQL = SQL & " K7113_SizeBeginName,"
            SQL = SQL & " K7113_SizeEndName,"
            SQL = SQL & " K7113_MaterialCode,"
            SQL = SQL & " K7113_Color,"
            SQL = SQL & " K7113_Specification,"
            SQL = SQL & " K7113_Width,"
            SQL = SQL & " K7113_Height,"
            SQL = SQL & " K7113_SizeName,"
            SQL = SQL & " K7113_ColorName,"
            SQL = SQL & " K7113_QtySize,"
            SQL = SQL & " K7113_LossSize,"
            SQL = SQL & " K7113_QtyUsage,"
            SQL = SQL & " K7113_DateInsert,"
            SQL = SQL & " K7113_DateUpdate,"
            SQL = SQL & " K7113_InchargeInsert,"
            SQL = SQL & " K7113_InchargeUpdate "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "   " & FormatSQL(z7113.Dseq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7113.BaseComponentBOM) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7113.ShoesCode) & "', "
            SQL = SQL & "   " & FormatSQL(z7113.MaterialSeq) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7113.SizeBegin) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7113.SizeEnd) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7113.ComponentName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7113.SizeBeginName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7113.SizeEndName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7113.MaterialCode) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7113.Color) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7113.Specification) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7113.Width) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7113.Height) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7113.SizeName) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7113.ColorName) & "', "
            SQL = SQL & "   " & FormatSQL(z7113.QtySize) & ", "
            SQL = SQL & "   " & FormatSQL(z7113.LossSize) & ", "
            SQL = SQL & "   " & FormatSQL(z7113.QtyUsage) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7113.DateInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7113.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7113.InchargeInsert) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7113.InchargeUpdate) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK7113 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK7113", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK7113(z7113 As T7113_AREA) As Boolean
        REWRITE_PFK7113 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7113)

            SQL = " UPDATE PFK7113 SET "
            SQL = SQL & "    K7113_Dseq      =  " & FormatSQL(z7113.Dseq) & ", "
            SQL = SQL & "    K7113_BaseComponentBOM      = N'" & FormatSQL(z7113.BaseComponentBOM) & "', "
            SQL = SQL & "    K7113_ShoesCode      = N'" & FormatSQL(z7113.ShoesCode) & "', "
            SQL = SQL & "    K7113_MaterialSeq      =  " & FormatSQL(z7113.MaterialSeq) & ", "
            SQL = SQL & "    K7113_SizeBegin      = N'" & FormatSQL(z7113.SizeBegin) & "', "
            SQL = SQL & "    K7113_SizeEnd      = N'" & FormatSQL(z7113.SizeEnd) & "', "
            SQL = SQL & "    K7113_ComponentName      = N'" & FormatSQL(z7113.ComponentName) & "', "
            SQL = SQL & "    K7113_SizeBeginName      = N'" & FormatSQL(z7113.SizeBeginName) & "', "
            SQL = SQL & "    K7113_SizeEndName      = N'" & FormatSQL(z7113.SizeEndName) & "', "
            SQL = SQL & "    K7113_MaterialCode      = N'" & FormatSQL(z7113.MaterialCode) & "', "
            SQL = SQL & "    K7113_Color      = N'" & FormatSQL(z7113.Color) & "', "
            SQL = SQL & "    K7113_Specification      = N'" & FormatSQL(z7113.Specification) & "', "
            SQL = SQL & "    K7113_Width      = N'" & FormatSQL(z7113.Width) & "', "
            SQL = SQL & "    K7113_Height      = N'" & FormatSQL(z7113.Height) & "', "
            SQL = SQL & "    K7113_SizeName      = N'" & FormatSQL(z7113.SizeName) & "', "
            SQL = SQL & "    K7113_ColorName      = N'" & FormatSQL(z7113.ColorName) & "', "
            SQL = SQL & "    K7113_QtySize      =  " & FormatSQL(z7113.QtySize) & ", "
            SQL = SQL & "    K7113_LossSize      =  " & FormatSQL(z7113.LossSize) & ", "
            SQL = SQL & "    K7113_QtyUsage      =  " & FormatSQL(z7113.QtyUsage) & ", "
            SQL = SQL & "    K7113_DateInsert      = N'" & FormatSQL(z7113.DateInsert) & "', "
            SQL = SQL & "    K7113_DateUpdate      = N'" & FormatSQL(z7113.DateUpdate) & "', "
            SQL = SQL & "    K7113_InchargeInsert      = N'" & FormatSQL(z7113.InchargeInsert) & "', "
            SQL = SQL & "    K7113_InchargeUpdate      = N'" & FormatSQL(z7113.InchargeUpdate) & "'  "
            SQL = SQL & " WHERE K7113_Autokey		 =  " & z7113.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK7113 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK7113", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK7113(z7113 As T7113_AREA) As Boolean
        DELETE_PFK7113 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK7113 "
            SQL = SQL & " WHERE K7113_Autokey		 =  " & z7113.Autokey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7113 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7113", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D7113_CLEAR()
        Try

            D7113.Autokey = 0
            D7113.Dseq = 0
            D7113.BaseComponentBOM = ""
            D7113.ShoesCode = ""
            D7113.MaterialSeq = 0
            D7113.SizeBegin = ""
            D7113.SizeEnd = ""
            D7113.ComponentName = ""
            D7113.SizeBeginName = ""
            D7113.SizeEndName = ""
            D7113.MaterialCode = ""
            D7113.Color = ""
            D7113.Specification = ""
            D7113.Width = ""
            D7113.Height = ""
            D7113.SizeName = ""
            D7113.ColorName = ""
            D7113.QtySize = 0
            D7113.LossSize = 0
            D7113.QtyUsage = 0
            D7113.DateInsert = ""
            D7113.DateUpdate = ""
            D7113.InchargeInsert = ""
            D7113.InchargeUpdate = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D7113_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x7113 As T7113_AREA)
        Try

            x7113.Autokey = trim$(x7113.Autokey)
            x7113.Dseq = trim$(x7113.Dseq)
            x7113.BaseComponentBOM = trim$(x7113.BaseComponentBOM)
            x7113.ShoesCode = trim$(x7113.ShoesCode)
            x7113.MaterialSeq = trim$(x7113.MaterialSeq)
            x7113.SizeBegin = trim$(x7113.SizeBegin)
            x7113.SizeEnd = trim$(x7113.SizeEnd)
            x7113.ComponentName = trim$(x7113.ComponentName)
            x7113.SizeBeginName = trim$(x7113.SizeBeginName)
            x7113.SizeEndName = trim$(x7113.SizeEndName)
            x7113.MaterialCode = trim$(x7113.MaterialCode)
            x7113.Color = trim$(x7113.Color)
            x7113.Specification = trim$(x7113.Specification)
            x7113.Width = trim$(x7113.Width)
            x7113.Height = trim$(x7113.Height)
            x7113.SizeName = trim$(x7113.SizeName)
            x7113.ColorName = trim$(x7113.ColorName)
            x7113.QtySize = trim$(x7113.QtySize)
            x7113.LossSize = trim$(x7113.LossSize)
            x7113.QtyUsage = trim$(x7113.QtyUsage)
            x7113.DateInsert = trim$(x7113.DateInsert)
            x7113.DateUpdate = trim$(x7113.DateUpdate)
            x7113.InchargeInsert = trim$(x7113.InchargeInsert)
            x7113.InchargeUpdate = trim$(x7113.InchargeUpdate)

            If trim$(x7113.Autokey) = "" Then x7113.Autokey = 0
            If trim$(x7113.Dseq) = "" Then x7113.Dseq = 0
            If trim$(x7113.BaseComponentBOM) = "" Then x7113.BaseComponentBOM = Space(1)
            If trim$(x7113.ShoesCode) = "" Then x7113.ShoesCode = Space(1)
            If trim$(x7113.MaterialSeq) = "" Then x7113.MaterialSeq = 0
            If trim$(x7113.SizeBegin) = "" Then x7113.SizeBegin = Space(1)
            If trim$(x7113.SizeEnd) = "" Then x7113.SizeEnd = Space(1)
            If trim$(x7113.ComponentName) = "" Then x7113.ComponentName = Space(1)
            If trim$(x7113.SizeBeginName) = "" Then x7113.SizeBeginName = Space(1)
            If trim$(x7113.SizeEndName) = "" Then x7113.SizeEndName = Space(1)
            If trim$(x7113.MaterialCode) = "" Then x7113.MaterialCode = Space(1)
            If trim$(x7113.Color) = "" Then x7113.Color = Space(1)
            If trim$(x7113.Specification) = "" Then x7113.Specification = Space(1)
            If trim$(x7113.Width) = "" Then x7113.Width = Space(1)
            If trim$(x7113.Height) = "" Then x7113.Height = Space(1)
            If trim$(x7113.SizeName) = "" Then x7113.SizeName = Space(1)
            If trim$(x7113.ColorName) = "" Then x7113.ColorName = Space(1)
            If trim$(x7113.QtySize) = "" Then x7113.QtySize = 0
            If trim$(x7113.LossSize) = "" Then x7113.LossSize = 0
            If trim$(x7113.QtyUsage) = "" Then x7113.QtyUsage = 0
            If trim$(x7113.DateInsert) = "" Then x7113.DateInsert = Space(1)
            If trim$(x7113.DateUpdate) = "" Then x7113.DateUpdate = Space(1)
            If trim$(x7113.InchargeInsert) = "" Then x7113.InchargeInsert = Space(1)
            If trim$(x7113.InchargeUpdate) = "" Then x7113.InchargeUpdate = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K7113_MOVE(rs7113 As SqlClient.SqlDataReader)
        Try

            Call D7113_CLEAR()

            If IsdbNull(rs7113!K7113_Autokey) = False Then D7113.Autokey = Trim$(rs7113!K7113_Autokey)
            If IsdbNull(rs7113!K7113_Dseq) = False Then D7113.Dseq = Trim$(rs7113!K7113_Dseq)
            If IsdbNull(rs7113!K7113_BaseComponentBOM) = False Then D7113.BaseComponentBOM = Trim$(rs7113!K7113_BaseComponentBOM)
            If IsdbNull(rs7113!K7113_ShoesCode) = False Then D7113.ShoesCode = Trim$(rs7113!K7113_ShoesCode)
            If IsdbNull(rs7113!K7113_MaterialSeq) = False Then D7113.MaterialSeq = Trim$(rs7113!K7113_MaterialSeq)
            If IsdbNull(rs7113!K7113_SizeBegin) = False Then D7113.SizeBegin = Trim$(rs7113!K7113_SizeBegin)
            If IsdbNull(rs7113!K7113_SizeEnd) = False Then D7113.SizeEnd = Trim$(rs7113!K7113_SizeEnd)
            If IsdbNull(rs7113!K7113_ComponentName) = False Then D7113.ComponentName = Trim$(rs7113!K7113_ComponentName)
            If IsdbNull(rs7113!K7113_SizeBeginName) = False Then D7113.SizeBeginName = Trim$(rs7113!K7113_SizeBeginName)
            If IsdbNull(rs7113!K7113_SizeEndName) = False Then D7113.SizeEndName = Trim$(rs7113!K7113_SizeEndName)
            If IsdbNull(rs7113!K7113_MaterialCode) = False Then D7113.MaterialCode = Trim$(rs7113!K7113_MaterialCode)
            If IsdbNull(rs7113!K7113_Color) = False Then D7113.Color = Trim$(rs7113!K7113_Color)
            If IsdbNull(rs7113!K7113_Specification) = False Then D7113.Specification = Trim$(rs7113!K7113_Specification)
            If IsdbNull(rs7113!K7113_Width) = False Then D7113.Width = Trim$(rs7113!K7113_Width)
            If IsdbNull(rs7113!K7113_Height) = False Then D7113.Height = Trim$(rs7113!K7113_Height)
            If IsdbNull(rs7113!K7113_SizeName) = False Then D7113.SizeName = Trim$(rs7113!K7113_SizeName)
            If IsdbNull(rs7113!K7113_ColorName) = False Then D7113.ColorName = Trim$(rs7113!K7113_ColorName)
            If IsdbNull(rs7113!K7113_QtySize) = False Then D7113.QtySize = Trim$(rs7113!K7113_QtySize)
            If IsdbNull(rs7113!K7113_LossSize) = False Then D7113.LossSize = Trim$(rs7113!K7113_LossSize)
            If IsdbNull(rs7113!K7113_QtyUsage) = False Then D7113.QtyUsage = Trim$(rs7113!K7113_QtyUsage)
            If IsdbNull(rs7113!K7113_DateInsert) = False Then D7113.DateInsert = Trim$(rs7113!K7113_DateInsert)
            If IsdbNull(rs7113!K7113_DateUpdate) = False Then D7113.DateUpdate = Trim$(rs7113!K7113_DateUpdate)
            If IsdbNull(rs7113!K7113_InchargeInsert) = False Then D7113.InchargeInsert = Trim$(rs7113!K7113_InchargeInsert)
            If IsdbNull(rs7113!K7113_InchargeUpdate) = False Then D7113.InchargeUpdate = Trim$(rs7113!K7113_InchargeUpdate)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7113_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K7113_MOVE(rs7113 As DataRow)
        Try

            Call D7113_CLEAR()

            If IsdbNull(rs7113!K7113_Autokey) = False Then D7113.Autokey = Trim$(rs7113!K7113_Autokey)
            If IsdbNull(rs7113!K7113_Dseq) = False Then D7113.Dseq = Trim$(rs7113!K7113_Dseq)
            If IsdbNull(rs7113!K7113_BaseComponentBOM) = False Then D7113.BaseComponentBOM = Trim$(rs7113!K7113_BaseComponentBOM)
            If IsdbNull(rs7113!K7113_ShoesCode) = False Then D7113.ShoesCode = Trim$(rs7113!K7113_ShoesCode)
            If IsdbNull(rs7113!K7113_MaterialSeq) = False Then D7113.MaterialSeq = Trim$(rs7113!K7113_MaterialSeq)
            If IsdbNull(rs7113!K7113_SizeBegin) = False Then D7113.SizeBegin = Trim$(rs7113!K7113_SizeBegin)
            If IsdbNull(rs7113!K7113_SizeEnd) = False Then D7113.SizeEnd = Trim$(rs7113!K7113_SizeEnd)
            If IsdbNull(rs7113!K7113_ComponentName) = False Then D7113.ComponentName = Trim$(rs7113!K7113_ComponentName)
            If IsdbNull(rs7113!K7113_SizeBeginName) = False Then D7113.SizeBeginName = Trim$(rs7113!K7113_SizeBeginName)
            If IsdbNull(rs7113!K7113_SizeEndName) = False Then D7113.SizeEndName = Trim$(rs7113!K7113_SizeEndName)
            If IsdbNull(rs7113!K7113_MaterialCode) = False Then D7113.MaterialCode = Trim$(rs7113!K7113_MaterialCode)
            If IsdbNull(rs7113!K7113_Color) = False Then D7113.Color = Trim$(rs7113!K7113_Color)
            If IsdbNull(rs7113!K7113_Specification) = False Then D7113.Specification = Trim$(rs7113!K7113_Specification)
            If IsdbNull(rs7113!K7113_Width) = False Then D7113.Width = Trim$(rs7113!K7113_Width)
            If IsdbNull(rs7113!K7113_Height) = False Then D7113.Height = Trim$(rs7113!K7113_Height)
            If IsdbNull(rs7113!K7113_SizeName) = False Then D7113.SizeName = Trim$(rs7113!K7113_SizeName)
            If IsdbNull(rs7113!K7113_ColorName) = False Then D7113.ColorName = Trim$(rs7113!K7113_ColorName)
            If IsdbNull(rs7113!K7113_QtySize) = False Then D7113.QtySize = Trim$(rs7113!K7113_QtySize)
            If IsdbNull(rs7113!K7113_LossSize) = False Then D7113.LossSize = Trim$(rs7113!K7113_LossSize)
            If IsdbNull(rs7113!K7113_QtyUsage) = False Then D7113.QtyUsage = Trim$(rs7113!K7113_QtyUsage)
            If IsdbNull(rs7113!K7113_DateInsert) = False Then D7113.DateInsert = Trim$(rs7113!K7113_DateInsert)
            If IsdbNull(rs7113!K7113_DateUpdate) = False Then D7113.DateUpdate = Trim$(rs7113!K7113_DateUpdate)
            If IsdbNull(rs7113!K7113_InchargeInsert) = False Then D7113.InchargeInsert = Trim$(rs7113!K7113_InchargeInsert)
            If IsdbNull(rs7113!K7113_InchargeUpdate) = False Then D7113.InchargeUpdate = Trim$(rs7113!K7113_InchargeUpdate)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7113_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K7113_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7113 As T7113_AREA, AUTOKEY As Double) As Boolean

        K7113_MOVE = False

        Try
            If READ_PFK7113(AUTOKEY) = True Then
                z7113 = D7113
                K7113_MOVE = True
            Else
                z7113 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z7113.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z7113.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "BaseComponentBOM") > -1 Then z7113.BaseComponentBOM = getDataM(spr, getColumIndex(spr, "BaseComponentBOM"), xRow)
            If getColumIndex(spr, "ShoesCode") > -1 Then z7113.ShoesCode = getDataM(spr, getColumIndex(spr, "ShoesCode"), xRow)
            If getColumIndex(spr, "MaterialSeq") > -1 Then z7113.MaterialSeq = getDataM(spr, getColumIndex(spr, "MaterialSeq"), xRow)
            If getColumIndex(spr, "SizeBegin") > -1 Then z7113.SizeBegin = getDataM(spr, getColumIndex(spr, "SizeBegin"), xRow)
            If getColumIndex(spr, "SizeEnd") > -1 Then z7113.SizeEnd = getDataM(spr, getColumIndex(spr, "SizeEnd"), xRow)
            If getColumIndex(spr, "ComponentName") > -1 Then z7113.ComponentName = getDataM(spr, getColumIndex(spr, "ComponentName"), xRow)
            If getColumIndex(spr, "SizeBeginName") > -1 Then z7113.SizeBeginName = getDataM(spr, getColumIndex(spr, "SizeBeginName"), xRow)
            If getColumIndex(spr, "SizeEndName") > -1 Then z7113.SizeEndName = getDataM(spr, getColumIndex(spr, "SizeEndName"), xRow)
            If getColumIndex(spr, "MaterialCode") > -1 Then z7113.MaterialCode = getDataM(spr, getColumIndex(spr, "MaterialCode"), xRow)
            If getColumIndex(spr, "Color") > -1 Then z7113.Color = getDataM(spr, getColumIndex(spr, "Color"), xRow)
            If getColumIndex(spr, "Specification") > -1 Then z7113.Specification = getDataM(spr, getColumIndex(spr, "Specification"), xRow)
            If getColumIndex(spr, "Width") > -1 Then z7113.Width = getDataM(spr, getColumIndex(spr, "Width"), xRow)
            If getColumIndex(spr, "Height") > -1 Then z7113.Height = getDataM(spr, getColumIndex(spr, "Height"), xRow)
            If getColumIndex(spr, "SizeName") > -1 Then z7113.SizeName = getDataM(spr, getColumIndex(spr, "SizeName"), xRow)
            If getColumIndex(spr, "ColorName") > -1 Then z7113.ColorName = getDataM(spr, getColumIndex(spr, "ColorName"), xRow)
            If getColumIndex(spr, "QtySize") > -1 Then z7113.QtySize = getDataM(spr, getColumIndex(spr, "QtySize"), xRow)
            If getColumIndex(spr, "LossSize") > -1 Then z7113.LossSize = getDataM(spr, getColumIndex(spr, "LossSize"), xRow)
            If getColumIndex(spr, "QtyUsage") > -1 Then z7113.QtyUsage = getDataM(spr, getColumIndex(spr, "QtyUsage"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z7113.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z7113.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z7113.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z7113.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7113_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K7113_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7113 As T7113_AREA, CheckClear As Boolean, AUTOKEY As Double) As Boolean

        K7113_MOVE = False

        Try
            If READ_PFK7113(AUTOKEY) = True Then
                z7113 = D7113
                K7113_MOVE = True
            Else
                If CheckClear = True Then z7113 = Nothing
            End If

            If getColumIndex(spr, "Autokey") > -1 Then z7113.Autokey = getDataM(spr, getColumIndex(spr, "Autokey"), xRow)
            If getColumIndex(spr, "Dseq") > -1 Then z7113.Dseq = getDataM(spr, getColumIndex(spr, "Dseq"), xRow)
            If getColumIndex(spr, "BaseComponentBOM") > -1 Then z7113.BaseComponentBOM = getDataM(spr, getColumIndex(spr, "BaseComponentBOM"), xRow)
            If getColumIndex(spr, "ShoesCode") > -1 Then z7113.ShoesCode = getDataM(spr, getColumIndex(spr, "ShoesCode"), xRow)
            If getColumIndex(spr, "MaterialSeq") > -1 Then z7113.MaterialSeq = getDataM(spr, getColumIndex(spr, "MaterialSeq"), xRow)
            If getColumIndex(spr, "SizeBegin") > -1 Then z7113.SizeBegin = getDataM(spr, getColumIndex(spr, "SizeBegin"), xRow)
            If getColumIndex(spr, "SizeEnd") > -1 Then z7113.SizeEnd = getDataM(spr, getColumIndex(spr, "SizeEnd"), xRow)
            If getColumIndex(spr, "ComponentName") > -1 Then z7113.ComponentName = getDataM(spr, getColumIndex(spr, "ComponentName"), xRow)
            If getColumIndex(spr, "SizeBeginName") > -1 Then z7113.SizeBeginName = getDataM(spr, getColumIndex(spr, "SizeBeginName"), xRow)
            If getColumIndex(spr, "SizeEndName") > -1 Then z7113.SizeEndName = getDataM(spr, getColumIndex(spr, "SizeEndName"), xRow)
            If getColumIndex(spr, "MaterialCode") > -1 Then z7113.MaterialCode = getDataM(spr, getColumIndex(spr, "MaterialCode"), xRow)
            If getColumIndex(spr, "Color") > -1 Then z7113.Color = getDataM(spr, getColumIndex(spr, "Color"), xRow)
            If getColumIndex(spr, "Specification") > -1 Then z7113.Specification = getDataM(spr, getColumIndex(spr, "Specification"), xRow)
            If getColumIndex(spr, "Width") > -1 Then z7113.Width = getDataM(spr, getColumIndex(spr, "Width"), xRow)
            If getColumIndex(spr, "Height") > -1 Then z7113.Height = getDataM(spr, getColumIndex(spr, "Height"), xRow)
            If getColumIndex(spr, "SizeName") > -1 Then z7113.SizeName = getDataM(spr, getColumIndex(spr, "SizeName"), xRow)
            If getColumIndex(spr, "ColorName") > -1 Then z7113.ColorName = getDataM(spr, getColumIndex(spr, "ColorName"), xRow)
            If getColumIndex(spr, "QtySize") > -1 Then z7113.QtySize = getDataM(spr, getColumIndex(spr, "QtySize"), xRow)
            If getColumIndex(spr, "LossSize") > -1 Then z7113.LossSize = getDataM(spr, getColumIndex(spr, "LossSize"), xRow)
            If getColumIndex(spr, "QtyUsage") > -1 Then z7113.QtyUsage = getDataM(spr, getColumIndex(spr, "QtyUsage"), xRow)
            If getColumIndex(spr, "DateInsert") > -1 Then z7113.DateInsert = getDataM(spr, getColumIndex(spr, "DateInsert"), xRow)
            If getColumIndex(spr, "DateUpdate") > -1 Then z7113.DateUpdate = getDataM(spr, getColumIndex(spr, "DateUpdate"), xRow)
            If getColumIndex(spr, "InchargeInsert") > -1 Then z7113.InchargeInsert = getDataM(spr, getColumIndex(spr, "InchargeInsert"), xRow)
            If getColumIndex(spr, "InchargeUpdate") > -1 Then z7113.InchargeUpdate = getDataM(spr, getColumIndex(spr, "InchargeUpdate"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7113_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K7113_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7113 As T7113_AREA, Job As String, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7113_MOVE = False

        Try
            If READ_PFK7113(AUTOKEY) = True Then
                z7113 = D7113
                K7113_MOVE = True
            Else
                z7113 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7113")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z7113.Autokey = Children(i).Code
                                Case "DSEQ" : z7113.Dseq = Children(i).Code
                                Case "BASECOMPONENTBOM" : z7113.BaseComponentBOM = Children(i).Code
                                Case "SHOESCODE" : z7113.ShoesCode = Children(i).Code
                                Case "MATERIALSEQ" : z7113.MaterialSeq = Children(i).Code
                                Case "SIZEBEGIN" : z7113.SizeBegin = Children(i).Code
                                Case "SIZEEND" : z7113.SizeEnd = Children(i).Code
                                Case "COMPONENTNAME" : z7113.ComponentName = Children(i).Code
                                Case "SIZEBEGINNAME" : z7113.SizeBeginName = Children(i).Code
                                Case "SIZEENDNAME" : z7113.SizeEndName = Children(i).Code
                                Case "MATERIALCODE" : z7113.MaterialCode = Children(i).Code
                                Case "COLOR" : z7113.Color = Children(i).Code
                                Case "SPECIFICATION" : z7113.Specification = Children(i).Code
                                Case "WIDTH" : z7113.Width = Children(i).Code
                                Case "HEIGHT" : z7113.Height = Children(i).Code
                                Case "SIZENAME" : z7113.SizeName = Children(i).Code
                                Case "COLORNAME" : z7113.ColorName = Children(i).Code
                                Case "QTYSIZE" : z7113.QtySize = Children(i).Code
                                Case "LOSSSIZE" : z7113.LossSize = Children(i).Code
                                Case "QTYUSAGE" : z7113.QtyUsage = Children(i).Code
                                Case "DATEINSERT" : z7113.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z7113.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z7113.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z7113.InchargeUpdate = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z7113.Autokey = Children(i).Data
                                Case "DSEQ" : z7113.Dseq = Children(i).Data
                                Case "BASECOMPONENTBOM" : z7113.BaseComponentBOM = Children(i).Data
                                Case "SHOESCODE" : z7113.ShoesCode = Children(i).Data
                                Case "MATERIALSEQ" : z7113.MaterialSeq = Children(i).Data
                                Case "SIZEBEGIN" : z7113.SizeBegin = Children(i).Data
                                Case "SIZEEND" : z7113.SizeEnd = Children(i).Data
                                Case "COMPONENTNAME" : z7113.ComponentName = Children(i).Data
                                Case "SIZEBEGINNAME" : z7113.SizeBeginName = Children(i).Data
                                Case "SIZEENDNAME" : z7113.SizeEndName = Children(i).Data
                                Case "MATERIALCODE" : z7113.MaterialCode = Children(i).Data
                                Case "COLOR" : z7113.Color = Children(i).Data
                                Case "SPECIFICATION" : z7113.Specification = Children(i).Data
                                Case "WIDTH" : z7113.Width = Children(i).Data
                                Case "HEIGHT" : z7113.Height = Children(i).Data
                                Case "SIZENAME" : z7113.SizeName = Children(i).Data
                                Case "COLORNAME" : z7113.ColorName = Children(i).Data
                                Case "QTYSIZE" : z7113.QtySize = Children(i).Data
                                Case "LOSSSIZE" : z7113.LossSize = Children(i).Data
                                Case "QTYUSAGE" : z7113.QtyUsage = Children(i).Data
                                Case "DATEINSERT" : z7113.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z7113.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z7113.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z7113.InchargeUpdate = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7113_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K7113_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7113 As T7113_AREA, Job As String, CheckClear As Boolean, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7113_MOVE = False

        Try
            If READ_PFK7113(AUTOKEY) = True Then
                z7113 = D7113
                K7113_MOVE = True
            Else
                If CheckClear = True Then z7113 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7113")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z7113.Autokey = Children(i).Code
                                Case "DSEQ" : z7113.Dseq = Children(i).Code
                                Case "BASECOMPONENTBOM" : z7113.BaseComponentBOM = Children(i).Code
                                Case "SHOESCODE" : z7113.ShoesCode = Children(i).Code
                                Case "MATERIALSEQ" : z7113.MaterialSeq = Children(i).Code
                                Case "SIZEBEGIN" : z7113.SizeBegin = Children(i).Code
                                Case "SIZEEND" : z7113.SizeEnd = Children(i).Code
                                Case "COMPONENTNAME" : z7113.ComponentName = Children(i).Code
                                Case "SIZEBEGINNAME" : z7113.SizeBeginName = Children(i).Code
                                Case "SIZEENDNAME" : z7113.SizeEndName = Children(i).Code
                                Case "MATERIALCODE" : z7113.MaterialCode = Children(i).Code
                                Case "COLOR" : z7113.Color = Children(i).Code
                                Case "SPECIFICATION" : z7113.Specification = Children(i).Code
                                Case "WIDTH" : z7113.Width = Children(i).Code
                                Case "HEIGHT" : z7113.Height = Children(i).Code
                                Case "SIZENAME" : z7113.SizeName = Children(i).Code
                                Case "COLORNAME" : z7113.ColorName = Children(i).Code
                                Case "QTYSIZE" : z7113.QtySize = Children(i).Code
                                Case "LOSSSIZE" : z7113.LossSize = Children(i).Code
                                Case "QTYUSAGE" : z7113.QtyUsage = Children(i).Code
                                Case "DATEINSERT" : z7113.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z7113.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z7113.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z7113.InchargeUpdate = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z7113.Autokey = Children(i).Data
                                Case "DSEQ" : z7113.Dseq = Children(i).Data
                                Case "BASECOMPONENTBOM" : z7113.BaseComponentBOM = Children(i).Data
                                Case "SHOESCODE" : z7113.ShoesCode = Children(i).Data
                                Case "MATERIALSEQ" : z7113.MaterialSeq = Children(i).Data
                                Case "SIZEBEGIN" : z7113.SizeBegin = Children(i).Data
                                Case "SIZEEND" : z7113.SizeEnd = Children(i).Data
                                Case "COMPONENTNAME" : z7113.ComponentName = Children(i).Data
                                Case "SIZEBEGINNAME" : z7113.SizeBeginName = Children(i).Data
                                Case "SIZEENDNAME" : z7113.SizeEndName = Children(i).Data
                                Case "MATERIALCODE" : z7113.MaterialCode = Children(i).Data
                                Case "COLOR" : z7113.Color = Children(i).Data
                                Case "SPECIFICATION" : z7113.Specification = Children(i).Data
                                Case "WIDTH" : z7113.Width = Children(i).Data
                                Case "HEIGHT" : z7113.Height = Children(i).Data
                                Case "SIZENAME" : z7113.SizeName = Children(i).Data
                                Case "COLORNAME" : z7113.ColorName = Children(i).Data
                                Case "QTYSIZE" : z7113.QtySize = Children(i).Data
                                Case "LOSSSIZE" : z7113.LossSize = Children(i).Data
                                Case "QTYUSAGE" : z7113.QtyUsage = Children(i).Data
                                Case "DATEINSERT" : z7113.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z7113.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z7113.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z7113.InchargeUpdate = Children(i).Data
                            End Select
                End If
	End If
Catch ex As Exception

End Try
     Next
       	Exit Function 
Catch ex As Exception
      Call MsgBoxP("K7113_MOVE",vbCritical)
End Try
End Function 
    
End Module 
