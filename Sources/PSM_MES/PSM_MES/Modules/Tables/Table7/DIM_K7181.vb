'=========================================================================================================================================================
'   TABLE : (PFK7181)
'
'      WORKER : PEACE INFORMATION
'       WORK DATE : 2012/08/17 18
'       WORKER    : YOUNG
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7181

Structure T7181_AREA
'=========================================================================================================================================================
'       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
'=========================================================================================================================================================
Public 	ProcessDyeingSel	 AS String	'			char(3)		*
Public 	ProcessDyeingBOM	 AS String	'			char(6)		*
Public 	ProcessDyeingSeq	 AS Double	'			decimal		*
Public 	cdProcessProduction	 AS String	'			char(3)
Public 	RepeatProcess	 AS Double	'			decimal
Public 	PriceProcess	 AS Double	'			decimal
Public 	LossProcess	 AS Double	'			decimal
Public 	CheckProgress	 AS String	'			char(1)
Public 	CheckPrescription	 AS String	'			char(1)
Public 	CheckQuality	 AS String	'			char(1)
Public 	CheckPrice	 AS String	'			char(1)
Public 	CheckLoss	 AS String	'			char(1)
        Public CheckMachine As String  '			char(1)
        Public cdMachineType As String  '			char(3)
        Public Remark As String  '			nvarchar(200)
        '=========================================================================================================================================================
    End Structure

    Public D7181 As T7181_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK7181(PROCESSDYEINGSEL As String, PROCESSDYEINGBOM As String, PROCESSDYEINGSEQ As Double) As Boolean
        READ_PFK7181 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7181 "
            SQL = SQL & " WHERE K7181_ProcessDyeingSel		 = '" & ProcessDyeingSel & "' "
            SQL = SQL & "   AND K7181_ProcessDyeingBOM		 = '" & ProcessDyeingBOM & "' "
            SQL = SQL & "   AND K7181_ProcessDyeingSeq		 =  " & ProcessDyeingSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7181_CLEAR() : GoTo SKIP_READ_PFK7181

            Call K7181_MOVE(rd)
            READ_PFK7181 = True

SKIP_READ_PFK7181:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("37", "READ_PFK7181")
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK7181(PROCESSDYEINGSEL As String, PROCESSDYEINGBOM As String, PROCESSDYEINGSEQ As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7181 "
            SQL = SQL & " WHERE K7181_ProcessDyeingSel		 = '" & ProcessDyeingSel & "' "
            SQL = SQL & "   AND K7181_ProcessDyeingBOM		 = '" & ProcessDyeingBOM & "' "
            SQL = SQL & "   AND K7181_ProcessDyeingSeq		 =  " & ProcessDyeingSeq & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("37", "READ_PFK7101")
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK7181(z7181 As T7181_AREA) As Boolean
        WRITE_PFK7181 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7181)

            SQL = " INSERT INTO PFK7181 "
            SQL = SQL & " ( "
            SQL = SQL & " K7181_ProcessDyeingSel,"
            SQL = SQL & " K7181_ProcessDyeingBOM,"
            SQL = SQL & " K7181_ProcessDyeingSeq,"
            SQL = SQL & " K7181_cdProcessProduction,"
            SQL = SQL & " K7181_RepeatProcess,"
            SQL = SQL & " K7181_PriceProcess,"
            SQL = SQL & " K7181_LossProcess,"
            SQL = SQL & " K7181_CheckProgress,"
            SQL = SQL & " K7181_CheckPrescription,"
            SQL = SQL & " K7181_CheckQuality,"
            SQL = SQL & " K7181_CheckPrice,"
            SQL = SQL & " K7181_CheckLoss,"
            SQL = SQL & " K7181_CheckMachine,"
            SQL = SQL & " K7181_cdMachineType,"
            SQL = SQL & " K7181_Remark "
            SQL = SQL & " ) VALUES ( "
            SQL = SQL & "  '" & z7181.ProcessDyeingSel & "', "
            SQL = SQL & "  '" & z7181.ProcessDyeingBOM & "', "
            SQL = SQL & "   " & z7181.ProcessDyeingSeq & " , "
            SQL = SQL & "  '" & z7181.cdProcessProduction & "', "
            SQL = SQL & "   " & z7181.RepeatProcess & " , "
            SQL = SQL & "   " & z7181.PriceProcess & " , "
            SQL = SQL & "   " & z7181.LossProcess & " , "
            SQL = SQL & "  '" & z7181.CheckProgress & "', "
            SQL = SQL & "  '" & z7181.CheckPrescription & "', "
            SQL = SQL & "  '" & z7181.CheckQuality & "', "
            SQL = SQL & "  '" & z7181.CheckPrice & "', "
            SQL = SQL & "  '" & z7181.CheckLoss & "', "
            SQL = SQL & "  '" & z7181.CheckMachine & "', "
            SQL = SQL & "  '" & z7181.cdMachineType & "', "
            SQL = SQL & "  '" & z7181.Remark & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK7181 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("35", "WRITE_PFK7181")
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK7181(z7181 As T7181_AREA) As Boolean
        REWRITE_PFK7181 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7181)

            SQL = " UPDATE PFK7181 SET "
            SQL = SQL & "    K7181_cdProcessProduction      = '" & z7181.cdProcessProduction & "', "
            SQL = SQL & "    K7181_RepeatProcess      =  " & z7181.RepeatProcess & " , "
            SQL = SQL & "    K7181_PriceProcess      =  " & z7181.PriceProcess & " , "
            SQL = SQL & "    K7181_LossProcess      =  " & z7181.LossProcess & " , "
            SQL = SQL & "    K7181_CheckProgress      = '" & z7181.CheckProgress & "', "
            SQL = SQL & "    K7181_CheckPrescription      = '" & z7181.CheckPrescription & "', "
            SQL = SQL & "    K7181_CheckQuality      = '" & z7181.CheckQuality & "', "
            SQL = SQL & "    K7181_CheckPrice      = '" & z7181.CheckPrice & "', "
            SQL = SQL & "    K7181_CheckLoss      = '" & z7181.CheckLoss & "', "
            SQL = SQL & "    K7181_CheckMachine      = '" & z7181.CheckMachine & "', "
            SQL = SQL & "    K7181_cdMachineType      = '" & z7181.cdMachineType & "', "
            SQL = SQL & "    K7181_Remark      = '" & z7181.Remark & "'  "
            SQL = SQL & " WHERE K7181_ProcessDyeingSel		 = '" & z7181.ProcessDyeingSel & "' "
            SQL = SQL & "   AND K7181_ProcessDyeingBOM		 = '" & z7181.ProcessDyeingBOM & "' "
            SQL = SQL & "   AND K7181_ProcessDyeingSeq		 =  " & z7181.ProcessDyeingSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            REWRITE_PFK7181 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("36", "REWRITE_PFK7181")
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK7181(z7181 As T7181_AREA) As Boolean
        DELETE_PFK7181 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " DELETE FROM PFK7181 "
            SQL = SQL & " WHERE K7181_ProcessDyeingSel		 = '" & z7181.ProcessDyeingSel & "' "
            SQL = SQL & "   AND K7181_ProcessDyeingBOM		 = '" & z7181.ProcessDyeingBOM & "' "
            SQL = SQL & "   AND K7181_ProcessDyeingSeq		 =  " & z7181.ProcessDyeingSeq & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7181 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7181")
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D7181_CLEAR()
        Try

            D7181.ProcessDyeingSel = ""
            D7181.ProcessDyeingBOM = ""
            D7181.ProcessDyeingSeq = 0
            D7181.cdProcessProduction = ""
            D7181.RepeatProcess = 0
            D7181.PriceProcess = 0
            D7181.LossProcess = 0
            D7181.CheckProgress = ""
            D7181.CheckPrescription = ""
            D7181.CheckQuality = ""
            D7181.CheckPrice = ""
            D7181.CheckLoss = ""
            D7181.CheckMachine = ""
            D7181.cdMachineType = ""
            D7181.Remark = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("39", "D7181_CLEAR")
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x7181 As T7181_AREA)
        Try

            x7181.ProcessDyeingSel = trim$(x7181.ProcessDyeingSel)
            x7181.ProcessDyeingBOM = trim$(x7181.ProcessDyeingBOM)
            x7181.ProcessDyeingSeq = trim$(x7181.ProcessDyeingSeq)
            x7181.cdProcessProduction = trim$(x7181.cdProcessProduction)
            x7181.RepeatProcess = trim$(x7181.RepeatProcess)
            x7181.PriceProcess = trim$(x7181.PriceProcess)
            x7181.LossProcess = trim$(x7181.LossProcess)
            x7181.CheckProgress = trim$(x7181.CheckProgress)
            x7181.CheckPrescription = trim$(x7181.CheckPrescription)
            x7181.CheckQuality = trim$(x7181.CheckQuality)
            x7181.CheckPrice = trim$(x7181.CheckPrice)
            x7181.CheckLoss = trim$(x7181.CheckLoss)
            x7181.CheckMachine = trim$(x7181.CheckMachine)
            x7181.cdMachineType = trim$(x7181.cdMachineType)
            x7181.Remark = trim$(x7181.Remark)

            If trim$(x7181.ProcessDyeingSel) = "" Then x7181.ProcessDyeingSel = Space(1)
            If trim$(x7181.ProcessDyeingBOM) = "" Then x7181.ProcessDyeingBOM = Space(1)
            If trim$(x7181.ProcessDyeingSeq) = "" Then x7181.ProcessDyeingSeq = 0
            If trim$(x7181.cdProcessProduction) = "" Then x7181.cdProcessProduction = Space(1)
            If trim$(x7181.RepeatProcess) = "" Then x7181.RepeatProcess = 0
            If trim$(x7181.PriceProcess) = "" Then x7181.PriceProcess = 0
            If trim$(x7181.LossProcess) = "" Then x7181.LossProcess = 0
            If trim$(x7181.CheckProgress) = "" Then x7181.CheckProgress = Space(1)
            If trim$(x7181.CheckPrescription) = "" Then x7181.CheckPrescription = Space(1)
            If trim$(x7181.CheckQuality) = "" Then x7181.CheckQuality = Space(1)
            If trim$(x7181.CheckPrice) = "" Then x7181.CheckPrice = Space(1)
            If trim$(x7181.CheckLoss) = "" Then x7181.CheckLoss = Space(1)
            If trim$(x7181.CheckMachine) = "" Then x7181.CheckMachine = Space(1)
            If trim$(x7181.cdMachineType) = "" Then x7181.cdMachineType = Space(1)
            If trim$(x7181.Remark) = "" Then x7181.Remark = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("40", "NULL_ZERO")
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K7181_MOVE(rs7181 As SqlClient.SqlDataReader)
        Try

            Call D7181_CLEAR()

            If IsdbNull(rs7181!K7181_ProcessDyeingSel) = False Then D7181.ProcessDyeingSel = Trim$(rs7181!K7181_ProcessDyeingSel)
            If IsdbNull(rs7181!K7181_ProcessDyeingBOM) = False Then D7181.ProcessDyeingBOM = Trim$(rs7181!K7181_ProcessDyeingBOM)
            If IsdbNull(rs7181!K7181_ProcessDyeingSeq) = False Then D7181.ProcessDyeingSeq = Trim$(rs7181!K7181_ProcessDyeingSeq)
            If IsdbNull(rs7181!K7181_cdProcessProduction) = False Then D7181.cdProcessProduction = Trim$(rs7181!K7181_cdProcessProduction)
            If IsdbNull(rs7181!K7181_RepeatProcess) = False Then D7181.RepeatProcess = Trim$(rs7181!K7181_RepeatProcess)
            If IsdbNull(rs7181!K7181_PriceProcess) = False Then D7181.PriceProcess = Trim$(rs7181!K7181_PriceProcess)
            If IsdbNull(rs7181!K7181_LossProcess) = False Then D7181.LossProcess = Trim$(rs7181!K7181_LossProcess)
            If IsdbNull(rs7181!K7181_CheckProgress) = False Then D7181.CheckProgress = Trim$(rs7181!K7181_CheckProgress)
            If IsdbNull(rs7181!K7181_CheckPrescription) = False Then D7181.CheckPrescription = Trim$(rs7181!K7181_CheckPrescription)
            If IsdbNull(rs7181!K7181_CheckQuality) = False Then D7181.CheckQuality = Trim$(rs7181!K7181_CheckQuality)
            If IsdbNull(rs7181!K7181_CheckPrice) = False Then D7181.CheckPrice = Trim$(rs7181!K7181_CheckPrice)
            If IsdbNull(rs7181!K7181_CheckLoss) = False Then D7181.CheckLoss = Trim$(rs7181!K7181_CheckLoss)
            If IsdbNull(rs7181!K7181_CheckMachine) = False Then D7181.CheckMachine = Trim$(rs7181!K7181_CheckMachine)
            If IsdbNull(rs7181!K7181_cdMachineType) = False Then D7181.cdMachineType = Trim$(rs7181!K7181_cdMachineType)
            If IsdbNull(rs7181!K7181_Remark) = False Then D7181.Remark = Trim$(rs7181!K7181_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("41", "K7181_MOVE")
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K7181_MOVE(rs7181 As DataRow)
        Try

            Call D7181_CLEAR()

            If IsdbNull(rs7181!K7181_ProcessDyeingSel) = False Then D7181.ProcessDyeingSel = Trim$(rs7181!K7181_ProcessDyeingSel)
            If IsdbNull(rs7181!K7181_ProcessDyeingBOM) = False Then D7181.ProcessDyeingBOM = Trim$(rs7181!K7181_ProcessDyeingBOM)
            If IsdbNull(rs7181!K7181_ProcessDyeingSeq) = False Then D7181.ProcessDyeingSeq = Trim$(rs7181!K7181_ProcessDyeingSeq)
            If IsdbNull(rs7181!K7181_cdProcessProduction) = False Then D7181.cdProcessProduction = Trim$(rs7181!K7181_cdProcessProduction)
            If IsdbNull(rs7181!K7181_RepeatProcess) = False Then D7181.RepeatProcess = Trim$(rs7181!K7181_RepeatProcess)
            If IsdbNull(rs7181!K7181_PriceProcess) = False Then D7181.PriceProcess = Trim$(rs7181!K7181_PriceProcess)
            If IsdbNull(rs7181!K7181_LossProcess) = False Then D7181.LossProcess = Trim$(rs7181!K7181_LossProcess)
            If IsdbNull(rs7181!K7181_CheckProgress) = False Then D7181.CheckProgress = Trim$(rs7181!K7181_CheckProgress)
            If IsdbNull(rs7181!K7181_CheckPrescription) = False Then D7181.CheckPrescription = Trim$(rs7181!K7181_CheckPrescription)
            If IsdbNull(rs7181!K7181_CheckQuality) = False Then D7181.CheckQuality = Trim$(rs7181!K7181_CheckQuality)
            If IsdbNull(rs7181!K7181_CheckPrice) = False Then D7181.CheckPrice = Trim$(rs7181!K7181_CheckPrice)
            If IsdbNull(rs7181!K7181_CheckLoss) = False Then D7181.CheckLoss = Trim$(rs7181!K7181_CheckLoss)
            If IsdbNull(rs7181!K7181_CheckMachine) = False Then D7181.CheckMachine = Trim$(rs7181!K7181_CheckMachine)
            If IsdbNull(rs7181!K7181_cdMachineType) = False Then D7181.cdMachineType = Trim$(rs7181!K7181_cdMachineType)
            If IsdbNull(rs7181!K7181_Remark) = False Then D7181.Remark = Trim$(rs7181!K7181_Remark)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("41", "K7181_MOVE")
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Sub K7181_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7181 As T7181_AREA)

        Try
            Call NULL_ZERO(z7181)

            z7181.ProcessDyeingSel = getDataM(spr, getColumIndex(spr, "ProcessDyeingSel"), xRow)
            z7181.ProcessDyeingBOM = getDataM(spr, getColumIndex(spr, "ProcessDyeingBOM"), xRow)
            z7181.ProcessDyeingSeq = getDataM(spr, getColumIndex(spr, "ProcessDyeingSeq"), xRow)
            z7181.cdProcessProduction = getDataM(spr, getColumIndex(spr, "cdProcessProduction"), xRow)
            z7181.RepeatProcess = getDataM(spr, getColumIndex(spr, "RepeatProcess"), xRow)
            z7181.PriceProcess = getDataM(spr, getColumIndex(spr, "PriceProcess"), xRow)
            z7181.LossProcess = getDataM(spr, getColumIndex(spr, "LossProcess"), xRow)
            z7181.CheckProgress = getDataM(spr, getColumIndex(spr, "CheckProgress"), xRow)
            z7181.CheckPrescription = getDataM(spr, getColumIndex(spr, "CheckPrescription"), xRow)
            z7181.CheckQuality = getDataM(spr, getColumIndex(spr, "CheckQuality"), xRow)
            z7181.CheckPrice = getDataM(spr, getColumIndex(spr, "CheckPrice"), xRow)
            z7181.CheckLoss = getDataM(spr, getColumIndex(spr, "CheckLoss"), xRow)
            z7181.CheckMachine = getDataM(spr, getColumIndex(spr, "CheckMachine"), xRow)
            z7181.cdMachineType = getDataM(spr, getColumIndex(spr, "cdMachineType"), xRow)
            z7181.Remark = getDataM(spr, getColumIndex(spr, "Remark"), xRow)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("41", "K7181_MOVE")
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Sub K7181_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7181 As T7181_AREA, Job As String)
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet
        Try
            Call NULL_ZERO(z7181)

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7181")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "ProcessDyeingSel" : z7181.ProcessDyeingSel = Children(i).Code
                                Case "ProcessDyeingBOM" : z7181.ProcessDyeingBOM = Children(i).Code
                                Case "ProcessDyeingSeq" : z7181.ProcessDyeingSeq = Children(i).Code
                                Case "cdProcessProduction" : z7181.cdProcessProduction = Children(i).Code
                                Case "RepeatProcess" : z7181.RepeatProcess = Children(i).Code
                                Case "PriceProcess" : z7181.PriceProcess = Children(i).Code
                                Case "LossProcess" : z7181.LossProcess = Children(i).Code
                                Case "CheckProgress" : z7181.CheckProgress = Children(i).Code
                                Case "CheckPrescription" : z7181.CheckPrescription = Children(i).Code
                                Case "CheckQuality" : z7181.CheckQuality = Children(i).Code
                                Case "CheckPrice" : z7181.CheckPrice = Children(i).Code
                                Case "CheckLoss" : z7181.CheckLoss = Children(i).Code
                                Case "CheckMachine" : z7181.CheckMachine = Children(i).Code
                                Case "cdMachineType" : z7181.cdMachineType = Children(i).Code
                                Case "Remark" : z7181.Remark = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "ProcessDyeingSel" : z7181.ProcessDyeingSel = Children(i).Data
                                Case "ProcessDyeingBOM" : z7181.ProcessDyeingBOM = Children(i).Data
                                Case "ProcessDyeingSeq" : z7181.ProcessDyeingSeq = Children(i).Data
                                Case "cdProcessProduction" : z7181.cdProcessProduction = Children(i).Data
                                Case "RepeatProcess" : z7181.RepeatProcess = Children(i).Data
                                Case "PriceProcess" : z7181.PriceProcess = Children(i).Data
                                Case "LossProcess" : z7181.LossProcess = Children(i).Data
                                Case "CheckProgress" : z7181.CheckProgress = Children(i).Data
                                Case "CheckPrescription" : z7181.CheckPrescription = Children(i).Data
                                Case "CheckQuality" : z7181.CheckQuality = Children(i).Data
                                Case "CheckPrice" : z7181.CheckPrice = Children(i).Data
                                Case "CheckLoss" : z7181.CheckLoss = Children(i).Data
                                Case "CheckMachine" : z7181.CheckMachine = Children(i).Data
                                Case "cdMachineType" : z7181.cdMachineType = Children(i).Data
                                Case "Remark" : z7181.Remark = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("41", "K7811_MOVE")
        End Try
    End Sub

End Module
