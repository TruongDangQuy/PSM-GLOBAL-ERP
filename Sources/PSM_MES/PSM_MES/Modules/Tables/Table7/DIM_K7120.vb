'=========================================================================================================================================================
'   TABLE : (PFK7120)
'
'      WORKER : PSM GLOBAL ., LTD
'       WORK DATE : 2019 NEW
'       DEVELOPER    : MRNLV
'
'   1NO UPDATE DATE :
'=========================================================================================================================================================
Module DIM_K7120

    Structure T7120_AREA
        '=========================================================================================================================================================
        '       FIELD               EXPLANATION/DESCRIPTION      TYPE(WEIGHT)      KEY_CHECK      REMARK
        '=========================================================================================================================================================
        Public AutoKey As Double  '			decimal		*
        Public ShoesCode As String  '			char(6)
        Public seGroupJobProcess As String  '			char(3)
        Public cdGroupJobProcess As String  '			char(3)
        Public MAMaID As String  '			nvarchar(50)
        Public MAMahang As String  '			nvarchar(50)
        Public MATenhang As String  '			nvarchar(200)
        Public MAGhichu As String  '			nvarchar(2000)
        Public MBSTT As Double  '			decimal
        Public MBMathangID As String  '			nvarchar(50)
        Public MBNgayapdung As String  '			nvarchar(200)
        Public MBDongia_Giay As Double  '			decimal
        Public MBDongia_Mau As Double  '			decimal
        Public MBTongthoigian As Double  '			decimal
        Public MBSonguoi_Gio As Double  '			decimal
        Public MCMaID As String  '			nvarchar(50)
        Public MCMathangID As String  '			nvarchar(50)
        Public MCMacongdoan As String  '			nvarchar(50)
        Public MCTencongdoan As String  '			nvarchar(50)
        Public MCThoigiankiemtra As Double  '			decimal
        Public MCThoigian_datra As Double  '			decimal
        Public MCThoigian_chophep As Double  '			decimal
        Public MCDongia As Double  '			decimal
        Public MCSoConQuiDinh As Double  '			decimal
        Public MCSoConThucTe As Double  '			decimal
        Public MCGhichu As String  '			nvarchar(200)
        Public DateInsert As String  '			char(8)
        Public DateUpdate As String  '			char(8)
        Public InchargeInsert As String  '			char(8)
        Public InchargeUpdate As String  '			char(8)
        Public Remark As String  '			nvarchar(100)
        Public seSite As String  '			char(3)
        Public cdSite As String  '			char(3)
        Public TimeInsert As String  '			char(14)
        Public TimeUpdate As String  '			char(14)
        '=========================================================================================================================================================
    End Structure

    Public D7120 As T7120_AREA

    '=========================================================================================================================================================
    ' DIRECT READ 
    '=========================================================================================================================================================
    Public Function READ_PFK7120(AUTOKEY As Double) As Boolean
        READ_PFK7120 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7120 "
            SQL = SQL & " WHERE K7120_AutoKey		 =  " & AutoKey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then
                Call D7120_CLEAR()
                GoTo SKIP_READ_PFK7120
            End If

            Call K7120_MOVE(rd)
            READ_PFK7120 = True

SKIP_READ_PFK7120:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7120", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DIRECT READ DATASET
    '=========================================================================================================================================================
    Public Function READ_PFK7120(AUTOKEY As Double, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7120 "
            SQL = SQL & " WHERE K7120_AutoKey		 =  " & AutoKey & "  "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK7120", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA WRITE 
    '=========================================================================================================================================================
    Public Function WRITE_PFK7120(z7120 As T7120_AREA) As Boolean
        WRITE_PFK7120 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7120)

            SQL = " INSERT INTO PFK7120 "
            SQL = SQL & " ( "
            SQL = SQL & " K7120_ShoesCode,"
            SQL = SQL & " K7120_seGroupJobProcess,"
            SQL = SQL & " K7120_cdGroupJobProcess,"
            SQL = SQL & " K7120_MAMaID,"
            SQL = SQL & " K7120_MAMahang,"
            SQL = SQL & " K7120_MATenhang,"
            SQL = SQL & " K7120_MAGhichu,"
            SQL = SQL & " K7120_MBSTT,"
            SQL = SQL & " K7120_MBMathangID,"
            SQL = SQL & " K7120_MBNgayapdung,"
            SQL = SQL & " K7120_MBDongia_Giay,"
            SQL = SQL & " K7120_MBDongia_Mau,"
            SQL = SQL & " K7120_MBTongthoigian,"
            SQL = SQL & " K7120_MBSonguoi_Gio,"
            SQL = SQL & " K7120_MCMaID,"
            SQL = SQL & " K7120_MCMathangID,"
            SQL = SQL & " K7120_MCMacongdoan,"
            SQL = SQL & " K7120_MCTencongdoan,"
            SQL = SQL & " K7120_MCThoigiankiemtra,"
            SQL = SQL & " K7120_MCThoigian_datra,"
            SQL = SQL & " K7120_MCThoigian_chophep,"
            SQL = SQL & " K7120_MCDongia,"
            SQL = SQL & " K7120_MCSoConQuiDinh,"
            SQL = SQL & " K7120_MCSoConThucTe,"
            SQL = SQL & " K7120_MCGhichu,"
            SQL = SQL & " K7120_DateInsert,"
            SQL = SQL & " K7120_DateUpdate,"
            SQL = SQL & " K7120_InchargeInsert,"
            SQL = SQL & " K7120_InchargeUpdate,"
            SQL = SQL & " K7120_Remark,"
            SQL = SQL & " K7120_seSite,"
            SQL = SQL & " K7120_cdSite,"
            SQL = SQL & " K7120_TimeInsert,"
            SQL = SQL & " K7120_TimeUpdate "
            SQL = SQL & " ) VALUES ( "
            If Trim$(z7120.ShoesCode) = "" Then
                SQL = SQL & "  NULL , "
            Else
                SQL = SQL & "  N'" & FormatSQL(z7120.ShoesCode) & "', "
            End If
            SQL = SQL & "  N'" & FormatSQL(z7120.seGroupJobProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7120.cdGroupJobProcess) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7120.MAMaID) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7120.MAMahang) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7120.MATenhang) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7120.MAGhichu) & "', "
            SQL = SQL & "   " & FormatSQL(z7120.MBSTT) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7120.MBMathangID) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7120.MBNgayapdung) & "', "
            SQL = SQL & "   " & FormatSQL(z7120.MBDongia_Giay) & ", "
            SQL = SQL & "   " & FormatSQL(z7120.MBDongia_Mau) & ", "
            SQL = SQL & "   " & FormatSQL(z7120.MBTongthoigian) & ", "
            SQL = SQL & "   " & FormatSQL(z7120.MBSonguoi_Gio) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7120.MCMaID) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7120.MCMathangID) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7120.MCMacongdoan) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7120.MCTencongdoan) & "', "
            SQL = SQL & "   " & FormatSQL(z7120.MCThoigiankiemtra) & ", "
            SQL = SQL & "   " & FormatSQL(z7120.MCThoigian_datra) & ", "
            SQL = SQL & "   " & FormatSQL(z7120.MCThoigian_chophep) & ", "
            SQL = SQL & "   " & FormatSQL(z7120.MCDongia) & ", "
            SQL = SQL & "   " & FormatSQL(z7120.MCSoConQuiDinh) & ", "
            SQL = SQL & "   " & FormatSQL(z7120.MCSoConThucTe) & ", "
            SQL = SQL & "  N'" & FormatSQL(z7120.MCGhichu) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.DAT) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7120.DateUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.SAW) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7120.InchargeUpdate) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7120.Remark) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7120.seSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7120.cdSite) & "', "
            SQL = SQL & "  N'" & FormatSQL(PUB.TIME) & "', "
            SQL = SQL & "  N'" & FormatSQL(z7120.TimeUpdate) & "'  "
            SQL = SQL & " ) "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            WRITE_PFK7120 = True
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("WRITE_PFK7120", vbCritical)
        End Try

    End Function

    '=========================================================================================================================================================
    ' DATA REWRITE 
    '=========================================================================================================================================================
    Public Function REWRITE_PFK7120(z7120 As T7120_AREA) As Boolean
        REWRITE_PFK7120 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7120)

            SQL = " UPDATE PFK7120 SET "
            If Trim$(z7120.ShoesCode) = "" Then
                SQL = SQL & " K7120_ShoesCode      =  NULL , "
            Else
                SQL = SQL & "    K7120_ShoesCode      =  N'" & FormatSQL(z7120.ShoesCode) & "', "
            End If
            SQL = SQL & "    K7120_seGroupJobProcess      = N'" & FormatSQL(z7120.seGroupJobProcess) & "', "
            SQL = SQL & "    K7120_cdGroupJobProcess      = N'" & FormatSQL(z7120.cdGroupJobProcess) & "', "
            SQL = SQL & "    K7120_MAMaID      = N'" & FormatSQL(z7120.MAMaID) & "', "
            SQL = SQL & "    K7120_MAMahang      = N'" & FormatSQL(z7120.MAMahang) & "', "
            SQL = SQL & "    K7120_MATenhang      = N'" & FormatSQL(z7120.MATenhang) & "', "
            SQL = SQL & "    K7120_MAGhichu      = N'" & FormatSQL(z7120.MAGhichu) & "', "
            SQL = SQL & "    K7120_MBSTT      =  " & FormatSQL(z7120.MBSTT) & ", "
            SQL = SQL & "    K7120_MBMathangID      = N'" & FormatSQL(z7120.MBMathangID) & "', "
            SQL = SQL & "    K7120_MBNgayapdung      = N'" & FormatSQL(z7120.MBNgayapdung) & "', "
            SQL = SQL & "    K7120_MBDongia_Giay      =  " & FormatSQL(z7120.MBDongia_Giay) & ", "
            SQL = SQL & "    K7120_MBDongia_Mau      =  " & FormatSQL(z7120.MBDongia_Mau) & ", "
            SQL = SQL & "    K7120_MBTongthoigian      =  " & FormatSQL(z7120.MBTongthoigian) & ", "
            SQL = SQL & "    K7120_MBSonguoi_Gio      =  " & FormatSQL(z7120.MBSonguoi_Gio) & ", "
            SQL = SQL & "    K7120_MCMaID      = N'" & FormatSQL(z7120.MCMaID) & "', "
            SQL = SQL & "    K7120_MCMathangID      = N'" & FormatSQL(z7120.MCMathangID) & "', "
            SQL = SQL & "    K7120_MCMacongdoan      = N'" & FormatSQL(z7120.MCMacongdoan) & "', "
            SQL = SQL & "    K7120_MCTencongdoan      = N'" & FormatSQL(z7120.MCTencongdoan) & "', "
            SQL = SQL & "    K7120_MCThoigiankiemtra      =  " & FormatSQL(z7120.MCThoigiankiemtra) & ", "
            SQL = SQL & "    K7120_MCThoigian_datra      =  " & FormatSQL(z7120.MCThoigian_datra) & ", "
            SQL = SQL & "    K7120_MCThoigian_chophep      =  " & FormatSQL(z7120.MCThoigian_chophep) & ", "
            SQL = SQL & "    K7120_MCDongia      =  " & FormatSQL(z7120.MCDongia) & ", "
            SQL = SQL & "    K7120_MCSoConQuiDinh      =  " & FormatSQL(z7120.MCSoConQuiDinh) & ", "
            SQL = SQL & "    K7120_MCSoConThucTe      =  " & FormatSQL(z7120.MCSoConThucTe) & ", "
            SQL = SQL & "    K7120_MCGhichu      = N'" & FormatSQL(z7120.MCGhichu) & "', "
            SQL = SQL & "    K7120_DateInsert      = N'" & FormatSQL(z7120.DateInsert) & "', "
            SQL = SQL & "    K7120_DateUpdate      = N'" & FormatSQL(PUB.DAT) & "', "
            SQL = SQL & "    K7120_InchargeInsert      = N'" & FormatSQL(z7120.InchargeInsert) & "', "
            SQL = SQL & "    K7120_InchargeUpdate      = N'" & FormatSQL(PUB.SAW) & "', "
            SQL = SQL & "    K7120_Remark      = N'" & FormatSQL(z7120.Remark) & "', "
            SQL = SQL & "    K7120_seSite      = N'" & FormatSQL(z7120.seSite) & "', "
            SQL = SQL & "    K7120_cdSite      = N'" & FormatSQL(z7120.cdSite) & "', "
            SQL = SQL & "    K7120_TimeInsert      = N'" & FormatSQL(z7120.TimeInsert) & "', "
            SQL = SQL & "    K7120_TimeUpdate      = N'" & FormatSQL(PUB.TIME) & "'  "
            SQL = SQL & " WHERE K7120_AutoKey		 =  " & z7120.AutoKey & "  "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()


            REWRITE_PFK7120 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("REWRITE_PFK7120", vbCritical)

        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA DELETE 
    '=========================================================================================================================================================
    Public Function DELETE_PFK7120(z7120 As T7120_AREA) As Boolean
        DELETE_PFK7120 = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            Call NULL_ZERO(z7120)

            SQL = " DELETE FROM PFK7120  "
            SQL = SQL & " WHERE K7120_AutoKey		 =  " & z7120.AutoKey & "  "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            DELETE_PFK7120 = True

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("DELETE_PFK7120", vbCritical)
        Finally
            Call GetFullInformation("PFK7120", "D", SQL)
        End Try
    End Function

    '=========================================================================================================================================================
    ' CLEAR 
    '=========================================================================================================================================================
    Public Sub D7120_CLEAR()
        Try

            D7120.AutoKey = 0
            D7120.ShoesCode = ""
            D7120.seGroupJobProcess = ""
            D7120.cdGroupJobProcess = ""
            D7120.MAMaID = ""
            D7120.MAMahang = ""
            D7120.MATenhang = ""
            D7120.MAGhichu = ""
            D7120.MBSTT = 0
            D7120.MBMathangID = ""
            D7120.MBNgayapdung = ""
            D7120.MBDongia_Giay = 0
            D7120.MBDongia_Mau = 0
            D7120.MBTongthoigian = 0
            D7120.MBSonguoi_Gio = 0
            D7120.MCMaID = ""
            D7120.MCMathangID = ""
            D7120.MCMacongdoan = ""
            D7120.MCTencongdoan = ""
            D7120.MCThoigiankiemtra = 0
            D7120.MCThoigian_datra = 0
            D7120.MCThoigian_chophep = 0
            D7120.MCDongia = 0
            D7120.MCSoConQuiDinh = 0
            D7120.MCSoConThucTe = 0
            D7120.MCGhichu = ""
            D7120.DateInsert = ""
            D7120.DateUpdate = ""
            D7120.InchargeInsert = ""
            D7120.InchargeUpdate = ""
            D7120.Remark = ""
            D7120.seSite = ""
            D7120.cdSite = ""
            D7120.TimeInsert = ""
            D7120.TimeUpdate = ""


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("D7120_CLEAR", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' NULL ZERO
    '=========================================================================================================================================================
    Private Sub NULL_ZERO(ByRef x7120 As T7120_AREA)
        Try

            x7120.AutoKey = trim$(x7120.AutoKey)
            x7120.ShoesCode = trim$(x7120.ShoesCode)
            x7120.seGroupJobProcess = trim$(x7120.seGroupJobProcess)
            x7120.cdGroupJobProcess = trim$(x7120.cdGroupJobProcess)
            x7120.MAMaID = trim$(x7120.MAMaID)
            x7120.MAMahang = trim$(x7120.MAMahang)
            x7120.MATenhang = trim$(x7120.MATenhang)
            x7120.MAGhichu = trim$(x7120.MAGhichu)
            x7120.MBSTT = trim$(x7120.MBSTT)
            x7120.MBMathangID = trim$(x7120.MBMathangID)
            x7120.MBNgayapdung = trim$(x7120.MBNgayapdung)
            x7120.MBDongia_Giay = trim$(x7120.MBDongia_Giay)
            x7120.MBDongia_Mau = trim$(x7120.MBDongia_Mau)
            x7120.MBTongthoigian = trim$(x7120.MBTongthoigian)
            x7120.MBSonguoi_Gio = trim$(x7120.MBSonguoi_Gio)
            x7120.MCMaID = trim$(x7120.MCMaID)
            x7120.MCMathangID = trim$(x7120.MCMathangID)
            x7120.MCMacongdoan = trim$(x7120.MCMacongdoan)
            x7120.MCTencongdoan = trim$(x7120.MCTencongdoan)
            x7120.MCThoigiankiemtra = trim$(x7120.MCThoigiankiemtra)
            x7120.MCThoigian_datra = trim$(x7120.MCThoigian_datra)
            x7120.MCThoigian_chophep = trim$(x7120.MCThoigian_chophep)
            x7120.MCDongia = trim$(x7120.MCDongia)
            x7120.MCSoConQuiDinh = trim$(x7120.MCSoConQuiDinh)
            x7120.MCSoConThucTe = trim$(x7120.MCSoConThucTe)
            x7120.MCGhichu = trim$(x7120.MCGhichu)
            x7120.DateInsert = trim$(x7120.DateInsert)
            x7120.DateUpdate = trim$(x7120.DateUpdate)
            x7120.InchargeInsert = trim$(x7120.InchargeInsert)
            x7120.InchargeUpdate = trim$(x7120.InchargeUpdate)
            x7120.Remark = trim$(x7120.Remark)
            x7120.seSite = trim$(x7120.seSite)
            x7120.cdSite = trim$(x7120.cdSite)
            x7120.TimeInsert = trim$(x7120.TimeInsert)
            x7120.TimeUpdate = trim$(x7120.TimeUpdate)

            If trim$(x7120.AutoKey) = "" Then x7120.AutoKey = 0
            If trim$(x7120.ShoesCode) = "" Then x7120.ShoesCode = Space(1)
            If trim$(x7120.seGroupJobProcess) = "" Then x7120.seGroupJobProcess = Space(1)
            If trim$(x7120.cdGroupJobProcess) = "" Then x7120.cdGroupJobProcess = Space(1)
            If trim$(x7120.MAMaID) = "" Then x7120.MAMaID = Space(1)
            If trim$(x7120.MAMahang) = "" Then x7120.MAMahang = Space(1)
            If trim$(x7120.MATenhang) = "" Then x7120.MATenhang = Space(1)
            If trim$(x7120.MAGhichu) = "" Then x7120.MAGhichu = Space(1)
            If trim$(x7120.MBSTT) = "" Then x7120.MBSTT = 0
            If trim$(x7120.MBMathangID) = "" Then x7120.MBMathangID = Space(1)
            If trim$(x7120.MBNgayapdung) = "" Then x7120.MBNgayapdung = Space(1)
            If trim$(x7120.MBDongia_Giay) = "" Then x7120.MBDongia_Giay = 0
            If trim$(x7120.MBDongia_Mau) = "" Then x7120.MBDongia_Mau = 0
            If trim$(x7120.MBTongthoigian) = "" Then x7120.MBTongthoigian = 0
            If trim$(x7120.MBSonguoi_Gio) = "" Then x7120.MBSonguoi_Gio = 0
            If trim$(x7120.MCMaID) = "" Then x7120.MCMaID = Space(1)
            If trim$(x7120.MCMathangID) = "" Then x7120.MCMathangID = Space(1)
            If trim$(x7120.MCMacongdoan) = "" Then x7120.MCMacongdoan = Space(1)
            If trim$(x7120.MCTencongdoan) = "" Then x7120.MCTencongdoan = Space(1)
            If trim$(x7120.MCThoigiankiemtra) = "" Then x7120.MCThoigiankiemtra = 0
            If trim$(x7120.MCThoigian_datra) = "" Then x7120.MCThoigian_datra = 0
            If trim$(x7120.MCThoigian_chophep) = "" Then x7120.MCThoigian_chophep = 0
            If trim$(x7120.MCDongia) = "" Then x7120.MCDongia = 0
            If trim$(x7120.MCSoConQuiDinh) = "" Then x7120.MCSoConQuiDinh = 0
            If trim$(x7120.MCSoConThucTe) = "" Then x7120.MCSoConThucTe = 0
            If trim$(x7120.MCGhichu) = "" Then x7120.MCGhichu = Space(1)
            If trim$(x7120.DateInsert) = "" Then x7120.DateInsert = Space(1)
            If trim$(x7120.DateUpdate) = "" Then x7120.DateUpdate = Space(1)
            If trim$(x7120.InchargeInsert) = "" Then x7120.InchargeInsert = Space(1)
            If trim$(x7120.InchargeUpdate) = "" Then x7120.InchargeUpdate = Space(1)
            If trim$(x7120.Remark) = "" Then x7120.Remark = Space(1)
            If trim$(x7120.seSite) = "" Then x7120.seSite = Space(1)
            If trim$(x7120.cdSite) = "" Then x7120.cdSite = Space(1)
            If trim$(x7120.TimeInsert) = "" Then x7120.TimeInsert = Space(1)
            If trim$(x7120.TimeUpdate) = "" Then x7120.TimeUpdate = Space(1)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("NULL_ZERO", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE DATAREADER
    '=========================================================================================================================================================
    Public Sub K7120_MOVE(rs7120 As SqlClient.SqlDataReader)
        Try

            Call D7120_CLEAR()

            If IsdbNull(rs7120!K7120_AutoKey) = False Then D7120.AutoKey = Trim$(rs7120!K7120_AutoKey)
            If IsdbNull(rs7120!K7120_ShoesCode) = False Then D7120.ShoesCode = Trim$(rs7120!K7120_ShoesCode)
            If IsdbNull(rs7120!K7120_seGroupJobProcess) = False Then D7120.seGroupJobProcess = Trim$(rs7120!K7120_seGroupJobProcess)
            If IsdbNull(rs7120!K7120_cdGroupJobProcess) = False Then D7120.cdGroupJobProcess = Trim$(rs7120!K7120_cdGroupJobProcess)
            If IsdbNull(rs7120!K7120_MAMaID) = False Then D7120.MAMaID = Trim$(rs7120!K7120_MAMaID)
            If IsdbNull(rs7120!K7120_MAMahang) = False Then D7120.MAMahang = Trim$(rs7120!K7120_MAMahang)
            If IsdbNull(rs7120!K7120_MATenhang) = False Then D7120.MATenhang = Trim$(rs7120!K7120_MATenhang)
            If IsdbNull(rs7120!K7120_MAGhichu) = False Then D7120.MAGhichu = Trim$(rs7120!K7120_MAGhichu)
            If IsdbNull(rs7120!K7120_MBSTT) = False Then D7120.MBSTT = Trim$(rs7120!K7120_MBSTT)
            If IsdbNull(rs7120!K7120_MBMathangID) = False Then D7120.MBMathangID = Trim$(rs7120!K7120_MBMathangID)
            If IsdbNull(rs7120!K7120_MBNgayapdung) = False Then D7120.MBNgayapdung = Trim$(rs7120!K7120_MBNgayapdung)
            If IsdbNull(rs7120!K7120_MBDongia_Giay) = False Then D7120.MBDongia_Giay = Trim$(rs7120!K7120_MBDongia_Giay)
            If IsdbNull(rs7120!K7120_MBDongia_Mau) = False Then D7120.MBDongia_Mau = Trim$(rs7120!K7120_MBDongia_Mau)
            If IsdbNull(rs7120!K7120_MBTongthoigian) = False Then D7120.MBTongthoigian = Trim$(rs7120!K7120_MBTongthoigian)
            If IsdbNull(rs7120!K7120_MBSonguoi_Gio) = False Then D7120.MBSonguoi_Gio = Trim$(rs7120!K7120_MBSonguoi_Gio)
            If IsdbNull(rs7120!K7120_MCMaID) = False Then D7120.MCMaID = Trim$(rs7120!K7120_MCMaID)
            If IsdbNull(rs7120!K7120_MCMathangID) = False Then D7120.MCMathangID = Trim$(rs7120!K7120_MCMathangID)
            If IsdbNull(rs7120!K7120_MCMacongdoan) = False Then D7120.MCMacongdoan = Trim$(rs7120!K7120_MCMacongdoan)
            If IsdbNull(rs7120!K7120_MCTencongdoan) = False Then D7120.MCTencongdoan = Trim$(rs7120!K7120_MCTencongdoan)
            If IsdbNull(rs7120!K7120_MCThoigiankiemtra) = False Then D7120.MCThoigiankiemtra = Trim$(rs7120!K7120_MCThoigiankiemtra)
            If IsdbNull(rs7120!K7120_MCThoigian_datra) = False Then D7120.MCThoigian_datra = Trim$(rs7120!K7120_MCThoigian_datra)
            If IsdbNull(rs7120!K7120_MCThoigian_chophep) = False Then D7120.MCThoigian_chophep = Trim$(rs7120!K7120_MCThoigian_chophep)
            If IsdbNull(rs7120!K7120_MCDongia) = False Then D7120.MCDongia = Trim$(rs7120!K7120_MCDongia)
            If IsdbNull(rs7120!K7120_MCSoConQuiDinh) = False Then D7120.MCSoConQuiDinh = Trim$(rs7120!K7120_MCSoConQuiDinh)
            If IsdbNull(rs7120!K7120_MCSoConThucTe) = False Then D7120.MCSoConThucTe = Trim$(rs7120!K7120_MCSoConThucTe)
            If IsdbNull(rs7120!K7120_MCGhichu) = False Then D7120.MCGhichu = Trim$(rs7120!K7120_MCGhichu)
            If IsdbNull(rs7120!K7120_DateInsert) = False Then D7120.DateInsert = Trim$(rs7120!K7120_DateInsert)
            If IsdbNull(rs7120!K7120_DateUpdate) = False Then D7120.DateUpdate = Trim$(rs7120!K7120_DateUpdate)
            If IsdbNull(rs7120!K7120_InchargeInsert) = False Then D7120.InchargeInsert = Trim$(rs7120!K7120_InchargeInsert)
            If IsdbNull(rs7120!K7120_InchargeUpdate) = False Then D7120.InchargeUpdate = Trim$(rs7120!K7120_InchargeUpdate)
            If IsdbNull(rs7120!K7120_Remark) = False Then D7120.Remark = Trim$(rs7120!K7120_Remark)
            If IsdbNull(rs7120!K7120_seSite) = False Then D7120.seSite = Trim$(rs7120!K7120_seSite)
            If IsdbNull(rs7120!K7120_cdSite) = False Then D7120.cdSite = Trim$(rs7120!K7120_cdSite)
            If IsdbNull(rs7120!K7120_TimeInsert) = False Then D7120.TimeInsert = Trim$(rs7120!K7120_TimeInsert)
            If IsdbNull(rs7120!K7120_TimeUpdate) = False Then D7120.TimeUpdate = Trim$(rs7120!K7120_TimeUpdate)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7120_MOVE", vbCritical)
        End Try
    End Sub
    '=========================================================================================================================================================
    ' DATA MOVE DATAROW
    '=========================================================================================================================================================
    Public Sub K7120_MOVE(rs7120 As DataRow)
        Try

            Call D7120_CLEAR()

            If IsdbNull(rs7120!K7120_AutoKey) = False Then D7120.AutoKey = Trim$(rs7120!K7120_AutoKey)
            If IsdbNull(rs7120!K7120_ShoesCode) = False Then D7120.ShoesCode = Trim$(rs7120!K7120_ShoesCode)
            If IsdbNull(rs7120!K7120_seGroupJobProcess) = False Then D7120.seGroupJobProcess = Trim$(rs7120!K7120_seGroupJobProcess)
            If IsdbNull(rs7120!K7120_cdGroupJobProcess) = False Then D7120.cdGroupJobProcess = Trim$(rs7120!K7120_cdGroupJobProcess)
            If IsdbNull(rs7120!K7120_MAMaID) = False Then D7120.MAMaID = Trim$(rs7120!K7120_MAMaID)
            If IsdbNull(rs7120!K7120_MAMahang) = False Then D7120.MAMahang = Trim$(rs7120!K7120_MAMahang)
            If IsdbNull(rs7120!K7120_MATenhang) = False Then D7120.MATenhang = Trim$(rs7120!K7120_MATenhang)
            If IsdbNull(rs7120!K7120_MAGhichu) = False Then D7120.MAGhichu = Trim$(rs7120!K7120_MAGhichu)
            If IsdbNull(rs7120!K7120_MBSTT) = False Then D7120.MBSTT = Trim$(rs7120!K7120_MBSTT)
            If IsdbNull(rs7120!K7120_MBMathangID) = False Then D7120.MBMathangID = Trim$(rs7120!K7120_MBMathangID)
            If IsdbNull(rs7120!K7120_MBNgayapdung) = False Then D7120.MBNgayapdung = Trim$(rs7120!K7120_MBNgayapdung)
            If IsdbNull(rs7120!K7120_MBDongia_Giay) = False Then D7120.MBDongia_Giay = Trim$(rs7120!K7120_MBDongia_Giay)
            If IsdbNull(rs7120!K7120_MBDongia_Mau) = False Then D7120.MBDongia_Mau = Trim$(rs7120!K7120_MBDongia_Mau)
            If IsdbNull(rs7120!K7120_MBTongthoigian) = False Then D7120.MBTongthoigian = Trim$(rs7120!K7120_MBTongthoigian)
            If IsdbNull(rs7120!K7120_MBSonguoi_Gio) = False Then D7120.MBSonguoi_Gio = Trim$(rs7120!K7120_MBSonguoi_Gio)
            If IsdbNull(rs7120!K7120_MCMaID) = False Then D7120.MCMaID = Trim$(rs7120!K7120_MCMaID)
            If IsdbNull(rs7120!K7120_MCMathangID) = False Then D7120.MCMathangID = Trim$(rs7120!K7120_MCMathangID)
            If IsdbNull(rs7120!K7120_MCMacongdoan) = False Then D7120.MCMacongdoan = Trim$(rs7120!K7120_MCMacongdoan)
            If IsdbNull(rs7120!K7120_MCTencongdoan) = False Then D7120.MCTencongdoan = Trim$(rs7120!K7120_MCTencongdoan)
            If IsdbNull(rs7120!K7120_MCThoigiankiemtra) = False Then D7120.MCThoigiankiemtra = Trim$(rs7120!K7120_MCThoigiankiemtra)
            If IsdbNull(rs7120!K7120_MCThoigian_datra) = False Then D7120.MCThoigian_datra = Trim$(rs7120!K7120_MCThoigian_datra)
            If IsdbNull(rs7120!K7120_MCThoigian_chophep) = False Then D7120.MCThoigian_chophep = Trim$(rs7120!K7120_MCThoigian_chophep)
            If IsdbNull(rs7120!K7120_MCDongia) = False Then D7120.MCDongia = Trim$(rs7120!K7120_MCDongia)
            If IsdbNull(rs7120!K7120_MCSoConQuiDinh) = False Then D7120.MCSoConQuiDinh = Trim$(rs7120!K7120_MCSoConQuiDinh)
            If IsdbNull(rs7120!K7120_MCSoConThucTe) = False Then D7120.MCSoConThucTe = Trim$(rs7120!K7120_MCSoConThucTe)
            If IsdbNull(rs7120!K7120_MCGhichu) = False Then D7120.MCGhichu = Trim$(rs7120!K7120_MCGhichu)
            If IsdbNull(rs7120!K7120_DateInsert) = False Then D7120.DateInsert = Trim$(rs7120!K7120_DateInsert)
            If IsdbNull(rs7120!K7120_DateUpdate) = False Then D7120.DateUpdate = Trim$(rs7120!K7120_DateUpdate)
            If IsdbNull(rs7120!K7120_InchargeInsert) = False Then D7120.InchargeInsert = Trim$(rs7120!K7120_InchargeInsert)
            If IsdbNull(rs7120!K7120_InchargeUpdate) = False Then D7120.InchargeUpdate = Trim$(rs7120!K7120_InchargeUpdate)
            If IsdbNull(rs7120!K7120_Remark) = False Then D7120.Remark = Trim$(rs7120!K7120_Remark)
            If IsdbNull(rs7120!K7120_seSite) = False Then D7120.seSite = Trim$(rs7120!K7120_seSite)
            If IsdbNull(rs7120!K7120_cdSite) = False Then D7120.cdSite = Trim$(rs7120!K7120_cdSite)
            If IsdbNull(rs7120!K7120_TimeInsert) = False Then D7120.TimeInsert = Trim$(rs7120!K7120_TimeInsert)
            If IsdbNull(rs7120!K7120_TimeUpdate) = False Then D7120.TimeUpdate = Trim$(rs7120!K7120_TimeUpdate)


            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("K7120_MOVE", vbCritical)
        End Try
    End Sub

    '=========================================================================================================================================================
    ' DATA MOVE SPREAD
    '=========================================================================================================================================================
    Public Function K7120_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7120 As T7120_AREA, AUTOKEY As Double) As Boolean

        K7120_MOVE = False

        Try
            If READ_PFK7120(AUTOKEY) = True Then
                z7120 = D7120
                K7120_MOVE = True
            Else
                z7120 = Nothing
            End If

            If getColumnIndex(spr, "AutoKey") > -1 Then z7120.AutoKey = Cdecp(getDataM(spr, getColumnIndex(spr, "AutoKey"), xRow))
            If getColumnIndex(spr, "ShoesCode") > -1 Then z7120.ShoesCode = getDataM(spr, getColumnIndex(spr, "ShoesCode"), xRow)
            If getColumnIndex(spr, "seGroupJobProcess") > -1 Then z7120.seGroupJobProcess = getDataM(spr, getColumnIndex(spr, "seGroupJobProcess"), xRow)
            If getColumnIndex(spr, "cdGroupJobProcess") > -1 Then z7120.cdGroupJobProcess = getDataM(spr, getColumnIndex(spr, "cdGroupJobProcess"), xRow)
            If getColumnIndex(spr, "MAMaID") > -1 Then z7120.MAMaID = getDataM(spr, getColumnIndex(spr, "MAMaID"), xRow)
            If getColumnIndex(spr, "MAMahang") > -1 Then z7120.MAMahang = getDataM(spr, getColumnIndex(spr, "MAMahang"), xRow)
            If getColumnIndex(spr, "MATenhang") > -1 Then z7120.MATenhang = getDataM(spr, getColumnIndex(spr, "MATenhang"), xRow)
            If getColumnIndex(spr, "MAGhichu") > -1 Then z7120.MAGhichu = getDataM(spr, getColumnIndex(spr, "MAGhichu"), xRow)
            If getColumnIndex(spr, "MBSTT") > -1 Then z7120.MBSTT = Cdecp(getDataM(spr, getColumnIndex(spr, "MBSTT"), xRow))
            If getColumnIndex(spr, "MBMathangID") > -1 Then z7120.MBMathangID = getDataM(spr, getColumnIndex(spr, "MBMathangID"), xRow)
            If getColumnIndex(spr, "MBNgayapdung") > -1 Then z7120.MBNgayapdung = getDataM(spr, getColumnIndex(spr, "MBNgayapdung"), xRow)
            If getColumnIndex(spr, "MBDongia_Giay") > -1 Then z7120.MBDongia_Giay = Cdecp(getDataM(spr, getColumnIndex(spr, "MBDongia_Giay"), xRow))
            If getColumnIndex(spr, "MBDongia_Mau") > -1 Then z7120.MBDongia_Mau = Cdecp(getDataM(spr, getColumnIndex(spr, "MBDongia_Mau"), xRow))
            If getColumnIndex(spr, "MBTongthoigian") > -1 Then z7120.MBTongthoigian = Cdecp(getDataM(spr, getColumnIndex(spr, "MBTongthoigian"), xRow))
            If getColumnIndex(spr, "MBSonguoi_Gio") > -1 Then z7120.MBSonguoi_Gio = Cdecp(getDataM(spr, getColumnIndex(spr, "MBSonguoi_Gio"), xRow))
            If getColumnIndex(spr, "MCMaID") > -1 Then z7120.MCMaID = getDataM(spr, getColumnIndex(spr, "MCMaID"), xRow)
            If getColumnIndex(spr, "MCMathangID") > -1 Then z7120.MCMathangID = getDataM(spr, getColumnIndex(spr, "MCMathangID"), xRow)
            If getColumnIndex(spr, "MCMacongdoan") > -1 Then z7120.MCMacongdoan = getDataM(spr, getColumnIndex(spr, "MCMacongdoan"), xRow)
            If getColumnIndex(spr, "MCTencongdoan") > -1 Then z7120.MCTencongdoan = getDataM(spr, getColumnIndex(spr, "MCTencongdoan"), xRow)
            If getColumnIndex(spr, "MCThoigiankiemtra") > -1 Then z7120.MCThoigiankiemtra = Cdecp(getDataM(spr, getColumnIndex(spr, "MCThoigiankiemtra"), xRow))
            If getColumnIndex(spr, "MCThoigian_datra") > -1 Then z7120.MCThoigian_datra = Cdecp(getDataM(spr, getColumnIndex(spr, "MCThoigian_datra"), xRow))
            If getColumnIndex(spr, "MCThoigian_chophep") > -1 Then z7120.MCThoigian_chophep = Cdecp(getDataM(spr, getColumnIndex(spr, "MCThoigian_chophep"), xRow))
            If getColumnIndex(spr, "MCDongia") > -1 Then z7120.MCDongia = Cdecp(getDataM(spr, getColumnIndex(spr, "MCDongia"), xRow))
            If getColumnIndex(spr, "MCSoConQuiDinh") > -1 Then z7120.MCSoConQuiDinh = Cdecp(getDataM(spr, getColumnIndex(spr, "MCSoConQuiDinh"), xRow))
            If getColumnIndex(spr, "MCSoConThucTe") > -1 Then z7120.MCSoConThucTe = Cdecp(getDataM(spr, getColumnIndex(spr, "MCSoConThucTe"), xRow))
            If getColumnIndex(spr, "MCGhichu") > -1 Then z7120.MCGhichu = getDataM(spr, getColumnIndex(spr, "MCGhichu"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z7120.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z7120.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z7120.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z7120.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z7120.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z7120.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z7120.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)
            If getColumnIndex(spr, "TimeInsert") > -1 Then z7120.TimeInsert = getDataM(spr, getColumnIndex(spr, "TimeInsert"), xRow)
            If getColumnIndex(spr, "TimeUpdate") > -1 Then z7120.TimeUpdate = getDataM(spr, getColumnIndex(spr, "TimeUpdate"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7120_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE SPREAD NEW
    '=========================================================================================================================================================
    Public Function K7120_MOVE(ByRef spr As FarPoint.Win.Spread.FpSpread, xRow As Integer, ByRef z7120 As T7120_AREA, CheckClear As Boolean, AUTOKEY As Double) As Boolean

        K7120_MOVE = False

        Try
            If READ_PFK7120(AUTOKEY) = True Then
                z7120 = D7120
                K7120_MOVE = True
            Else
                If CheckClear = True Then z7120 = Nothing
            End If

            If getColumnIndex(spr, "AutoKey") > -1 Then z7120.AutoKey = Cdecp(getDataM(spr, getColumnIndex(spr, "AutoKey"), xRow))
            If getColumnIndex(spr, "ShoesCode") > -1 Then z7120.ShoesCode = getDataM(spr, getColumnIndex(spr, "ShoesCode"), xRow)
            If getColumnIndex(spr, "seGroupJobProcess") > -1 Then z7120.seGroupJobProcess = getDataM(spr, getColumnIndex(spr, "seGroupJobProcess"), xRow)
            If getColumnIndex(spr, "cdGroupJobProcess") > -1 Then z7120.cdGroupJobProcess = getDataM(spr, getColumnIndex(spr, "cdGroupJobProcess"), xRow)
            If getColumnIndex(spr, "MAMaID") > -1 Then z7120.MAMaID = getDataM(spr, getColumnIndex(spr, "MAMaID"), xRow)
            If getColumnIndex(spr, "MAMahang") > -1 Then z7120.MAMahang = getDataM(spr, getColumnIndex(spr, "MAMahang"), xRow)
            If getColumnIndex(spr, "MATenhang") > -1 Then z7120.MATenhang = getDataM(spr, getColumnIndex(spr, "MATenhang"), xRow)
            If getColumnIndex(spr, "MAGhichu") > -1 Then z7120.MAGhichu = getDataM(spr, getColumnIndex(spr, "MAGhichu"), xRow)
            If getColumnIndex(spr, "MBSTT") > -1 Then z7120.MBSTT = Cdecp(getDataM(spr, getColumnIndex(spr, "MBSTT"), xRow))
            If getColumnIndex(spr, "MBMathangID") > -1 Then z7120.MBMathangID = getDataM(spr, getColumnIndex(spr, "MBMathangID"), xRow)
            If getColumnIndex(spr, "MBNgayapdung") > -1 Then z7120.MBNgayapdung = getDataM(spr, getColumnIndex(spr, "MBNgayapdung"), xRow)
            If getColumnIndex(spr, "MBDongia_Giay") > -1 Then z7120.MBDongia_Giay = Cdecp(getDataM(spr, getColumnIndex(spr, "MBDongia_Giay"), xRow))
            If getColumnIndex(spr, "MBDongia_Mau") > -1 Then z7120.MBDongia_Mau = Cdecp(getDataM(spr, getColumnIndex(spr, "MBDongia_Mau"), xRow))
            If getColumnIndex(spr, "MBTongthoigian") > -1 Then z7120.MBTongthoigian = Cdecp(getDataM(spr, getColumnIndex(spr, "MBTongthoigian"), xRow))
            If getColumnIndex(spr, "MBSonguoi_Gio") > -1 Then z7120.MBSonguoi_Gio = Cdecp(getDataM(spr, getColumnIndex(spr, "MBSonguoi_Gio"), xRow))
            If getColumnIndex(spr, "MCMaID") > -1 Then z7120.MCMaID = getDataM(spr, getColumnIndex(spr, "MCMaID"), xRow)
            If getColumnIndex(spr, "MCMathangID") > -1 Then z7120.MCMathangID = getDataM(spr, getColumnIndex(spr, "MCMathangID"), xRow)
            If getColumnIndex(spr, "MCMacongdoan") > -1 Then z7120.MCMacongdoan = getDataM(spr, getColumnIndex(spr, "MCMacongdoan"), xRow)
            If getColumnIndex(spr, "MCTencongdoan") > -1 Then z7120.MCTencongdoan = getDataM(spr, getColumnIndex(spr, "MCTencongdoan"), xRow)
            If getColumnIndex(spr, "MCThoigiankiemtra") > -1 Then z7120.MCThoigiankiemtra = Cdecp(getDataM(spr, getColumnIndex(spr, "MCThoigiankiemtra"), xRow))
            If getColumnIndex(spr, "MCThoigian_datra") > -1 Then z7120.MCThoigian_datra = Cdecp(getDataM(spr, getColumnIndex(spr, "MCThoigian_datra"), xRow))
            If getColumnIndex(spr, "MCThoigian_chophep") > -1 Then z7120.MCThoigian_chophep = Cdecp(getDataM(spr, getColumnIndex(spr, "MCThoigian_chophep"), xRow))
            If getColumnIndex(spr, "MCDongia") > -1 Then z7120.MCDongia = Cdecp(getDataM(spr, getColumnIndex(spr, "MCDongia"), xRow))
            If getColumnIndex(spr, "MCSoConQuiDinh") > -1 Then z7120.MCSoConQuiDinh = Cdecp(getDataM(spr, getColumnIndex(spr, "MCSoConQuiDinh"), xRow))
            If getColumnIndex(spr, "MCSoConThucTe") > -1 Then z7120.MCSoConThucTe = Cdecp(getDataM(spr, getColumnIndex(spr, "MCSoConThucTe"), xRow))
            If getColumnIndex(spr, "MCGhichu") > -1 Then z7120.MCGhichu = getDataM(spr, getColumnIndex(spr, "MCGhichu"), xRow)
            If getColumnIndex(spr, "DateInsert") > -1 Then z7120.DateInsert = getDataM(spr, getColumnIndex(spr, "DateInsert"), xRow)
            If getColumnIndex(spr, "DateUpdate") > -1 Then z7120.DateUpdate = getDataM(spr, getColumnIndex(spr, "DateUpdate"), xRow)
            If getColumnIndex(spr, "InchargeInsert") > -1 Then z7120.InchargeInsert = getDataM(spr, getColumnIndex(spr, "InchargeInsert"), xRow)
            If getColumnIndex(spr, "InchargeUpdate") > -1 Then z7120.InchargeUpdate = getDataM(spr, getColumnIndex(spr, "InchargeUpdate"), xRow)
            If getColumnIndex(spr, "Remark") > -1 Then z7120.Remark = getDataM(spr, getColumnIndex(spr, "Remark"), xRow)
            If getColumnIndex(spr, "seSite") > -1 Then z7120.seSite = getDataM(spr, getColumnIndex(spr, "seSite"), xRow)
            If getColumnIndex(spr, "cdSite") > -1 Then z7120.cdSite = getDataM(spr, getColumnIndex(spr, "cdSite"), xRow)
            If getColumnIndex(spr, "TimeInsert") > -1 Then z7120.TimeInsert = getDataM(spr, getColumnIndex(spr, "TimeInsert"), xRow)
            If getColumnIndex(spr, "TimeUpdate") > -1 Then z7120.TimeUpdate = getDataM(spr, getColumnIndex(spr, "TimeUpdate"), xRow)


            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7120_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM
    '=========================================================================================================================================================
    Public Function K7120_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7120 As T7120_AREA, Job As String, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7120_MOVE = False

        Try
            If READ_PFK7120(AUTOKEY) = True Then
                z7120 = D7120
                K7120_MOVE = True
            Else
                z7120 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7120")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                temp1 = temp1.ToUpper
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z7120.AutoKey = Children(i).Code
                                Case "SHOESCODE" : z7120.ShoesCode = Children(i).Code
                                Case "SEGROUPJOBPROCESS" : z7120.seGroupJobProcess = Children(i).Code
                                Case "CDGROUPJOBPROCESS" : z7120.cdGroupJobProcess = Children(i).Code
                                Case "MAMAID" : z7120.MAMaID = Children(i).Code
                                Case "MAMAHANG" : z7120.MAMahang = Children(i).Code
                                Case "MATENHANG" : z7120.MATenhang = Children(i).Code
                                Case "MAGHICHU" : z7120.MAGhichu = Children(i).Code
                                Case "MBSTT" : z7120.MBSTT = Children(i).Code
                                Case "MBMATHANGID" : z7120.MBMathangID = Children(i).Code
                                Case "MBNGAYAPDUNG" : z7120.MBNgayapdung = Children(i).Code
                                Case "MBDONGIA_GIAY" : z7120.MBDongia_Giay = Children(i).Code
                                Case "MBDONGIA_MAU" : z7120.MBDongia_Mau = Children(i).Code
                                Case "MBTONGTHOIGIAN" : z7120.MBTongthoigian = Children(i).Code
                                Case "MBSONGUOI_GIO" : z7120.MBSonguoi_Gio = Children(i).Code
                                Case "MCMAID" : z7120.MCMaID = Children(i).Code
                                Case "MCMATHANGID" : z7120.MCMathangID = Children(i).Code
                                Case "MCMACONGDOAN" : z7120.MCMacongdoan = Children(i).Code
                                Case "MCTENCONGDOAN" : z7120.MCTencongdoan = Children(i).Code
                                Case "MCTHOIGIANKIEMTRA" : z7120.MCThoigiankiemtra = Children(i).Code
                                Case "MCTHOIGIAN_DATRA" : z7120.MCThoigian_datra = Children(i).Code
                                Case "MCTHOIGIAN_CHOPHEP" : z7120.MCThoigian_chophep = Children(i).Code
                                Case "MCDONGIA" : z7120.MCDongia = Children(i).Code
                                Case "MCSOCONQUIDINH" : z7120.MCSoConQuiDinh = Children(i).Code
                                Case "MCSOCONTHUCTE" : z7120.MCSoConThucTe = Children(i).Code
                                Case "MCGHICHU" : z7120.MCGhichu = Children(i).Code
                                Case "DATEINSERT" : z7120.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z7120.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z7120.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z7120.InchargeUpdate = Children(i).Code
                                Case "REMARK" : z7120.Remark = Children(i).Code
                                Case "SESITE" : z7120.seSite = Children(i).Code
                                Case "CDSITE" : z7120.cdSite = Children(i).Code
                                Case "TIMEINSERT" : z7120.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z7120.TimeUpdate = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z7120.AutoKey = Cdecp(Children(i).Data)
                                Case "SHOESCODE" : z7120.ShoesCode = Children(i).Data
                                Case "SEGROUPJOBPROCESS" : z7120.seGroupJobProcess = Children(i).Data
                                Case "CDGROUPJOBPROCESS" : z7120.cdGroupJobProcess = Children(i).Data
                                Case "MAMAID" : z7120.MAMaID = Children(i).Data
                                Case "MAMAHANG" : z7120.MAMahang = Children(i).Data
                                Case "MATENHANG" : z7120.MATenhang = Children(i).Data
                                Case "MAGHICHU" : z7120.MAGhichu = Children(i).Data
                                Case "MBSTT" : z7120.MBSTT = Cdecp(Children(i).Data)
                                Case "MBMATHANGID" : z7120.MBMathangID = Children(i).Data
                                Case "MBNGAYAPDUNG" : z7120.MBNgayapdung = Children(i).Data
                                Case "MBDONGIA_GIAY" : z7120.MBDongia_Giay = Cdecp(Children(i).Data)
                                Case "MBDONGIA_MAU" : z7120.MBDongia_Mau = Cdecp(Children(i).Data)
                                Case "MBTONGTHOIGIAN" : z7120.MBTongthoigian = Cdecp(Children(i).Data)
                                Case "MBSONGUOI_GIO" : z7120.MBSonguoi_Gio = Cdecp(Children(i).Data)
                                Case "MCMAID" : z7120.MCMaID = Children(i).Data
                                Case "MCMATHANGID" : z7120.MCMathangID = Children(i).Data
                                Case "MCMACONGDOAN" : z7120.MCMacongdoan = Children(i).Data
                                Case "MCTENCONGDOAN" : z7120.MCTencongdoan = Children(i).Data
                                Case "MCTHOIGIANKIEMTRA" : z7120.MCThoigiankiemtra = Cdecp(Children(i).Data)
                                Case "MCTHOIGIAN_DATRA" : z7120.MCThoigian_datra = Cdecp(Children(i).Data)
                                Case "MCTHOIGIAN_CHOPHEP" : z7120.MCThoigian_chophep = Cdecp(Children(i).Data)
                                Case "MCDONGIA" : z7120.MCDongia = Cdecp(Children(i).Data)
                                Case "MCSOCONQUIDINH" : z7120.MCSoConQuiDinh = Cdecp(Children(i).Data)
                                Case "MCSOCONTHUCTE" : z7120.MCSoConThucTe = Cdecp(Children(i).Data)
                                Case "MCGHICHU" : z7120.MCGhichu = Children(i).Data
                                Case "DATEINSERT" : z7120.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z7120.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z7120.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z7120.InchargeUpdate = Children(i).Data
                                Case "REMARK" : z7120.Remark = Children(i).Data
                                Case "SESITE" : z7120.seSite = Children(i).Data
                                Case "CDSITE" : z7120.cdSite = Children(i).Data
                                Case "TIMEINSERT" : z7120.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z7120.TimeUpdate = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7120_MOVE", vbCritical)
        End Try
    End Function

    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW
    '=========================================================================================================================================================
    Public Function K7120_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, ByRef z7120 As T7120_AREA, Job As String, CheckClear As Boolean, AUTOKEY As Double) As Boolean
        Dim temp1 As String
        Dim i As Integer
        Dim Children As New List(Of Object)
        Dim newds As New DataSet

        K7120_MOVE = False

        Try
            If READ_PFK7120(AUTOKEY) = True Then
                z7120 = D7120
                K7120_MOVE = True
            Else
                If CheckClear = True Then z7120 = Nothing
            End If

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, "PFK7120")
            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                Try
                    If Children(i).DataLen <> Job Then
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            Select Case temp1
                                Case "AUTOKEY" : z7120.AutoKey = Children(i).Code
                                Case "SHOESCODE" : z7120.ShoesCode = Children(i).Code
                                Case "SEGROUPJOBPROCESS" : z7120.seGroupJobProcess = Children(i).Code
                                Case "CDGROUPJOBPROCESS" : z7120.cdGroupJobProcess = Children(i).Code
                                Case "MAMAID" : z7120.MAMaID = Children(i).Code
                                Case "MAMAHANG" : z7120.MAMahang = Children(i).Code
                                Case "MATENHANG" : z7120.MATenhang = Children(i).Code
                                Case "MAGHICHU" : z7120.MAGhichu = Children(i).Code
                                Case "MBSTT" : z7120.MBSTT = Children(i).Code
                                Case "MBMATHANGID" : z7120.MBMathangID = Children(i).Code
                                Case "MBNGAYAPDUNG" : z7120.MBNgayapdung = Children(i).Code
                                Case "MBDONGIA_GIAY" : z7120.MBDongia_Giay = Children(i).Code
                                Case "MBDONGIA_MAU" : z7120.MBDongia_Mau = Children(i).Code
                                Case "MBTONGTHOIGIAN" : z7120.MBTongthoigian = Children(i).Code
                                Case "MBSONGUOI_GIO" : z7120.MBSonguoi_Gio = Children(i).Code
                                Case "MCMAID" : z7120.MCMaID = Children(i).Code
                                Case "MCMATHANGID" : z7120.MCMathangID = Children(i).Code
                                Case "MCMACONGDOAN" : z7120.MCMacongdoan = Children(i).Code
                                Case "MCTENCONGDOAN" : z7120.MCTencongdoan = Children(i).Code
                                Case "MCTHOIGIANKIEMTRA" : z7120.MCThoigiankiemtra = Children(i).Code
                                Case "MCTHOIGIAN_DATRA" : z7120.MCThoigian_datra = Children(i).Code
                                Case "MCTHOIGIAN_CHOPHEP" : z7120.MCThoigian_chophep = Children(i).Code
                                Case "MCDONGIA" : z7120.MCDongia = Children(i).Code
                                Case "MCSOCONQUIDINH" : z7120.MCSoConQuiDinh = Children(i).Code
                                Case "MCSOCONTHUCTE" : z7120.MCSoConThucTe = Children(i).Code
                                Case "MCGHICHU" : z7120.MCGhichu = Children(i).Code
                                Case "DATEINSERT" : z7120.DateInsert = Children(i).Code
                                Case "DATEUPDATE" : z7120.DateUpdate = Children(i).Code
                                Case "INCHARGEINSERT" : z7120.InchargeInsert = Children(i).Code
                                Case "INCHARGEUPDATE" : z7120.InchargeUpdate = Children(i).Code
                                Case "REMARK" : z7120.Remark = Children(i).Code
                                Case "SESITE" : z7120.seSite = Children(i).Code
                                Case "CDSITE" : z7120.cdSite = Children(i).Code
                                Case "TIMEINSERT" : z7120.TimeInsert = Children(i).Code
                                Case "TIMEUPDATE" : z7120.TimeUpdate = Children(i).Code
                            End Select
                        Else
                            Select Case temp1
                                Case "AUTOKEY" : z7120.AutoKey = Cdecp(Children(i).Data)
                                Case "SHOESCODE" : z7120.ShoesCode = Children(i).Data
                                Case "SEGROUPJOBPROCESS" : z7120.seGroupJobProcess = Children(i).Data
                                Case "CDGROUPJOBPROCESS" : z7120.cdGroupJobProcess = Children(i).Data
                                Case "MAMAID" : z7120.MAMaID = Children(i).Data
                                Case "MAMAHANG" : z7120.MAMahang = Children(i).Data
                                Case "MATENHANG" : z7120.MATenhang = Children(i).Data
                                Case "MAGHICHU" : z7120.MAGhichu = Children(i).Data
                                Case "MBSTT" : z7120.MBSTT = Cdecp(Children(i).Data)
                                Case "MBMATHANGID" : z7120.MBMathangID = Children(i).Data
                                Case "MBNGAYAPDUNG" : z7120.MBNgayapdung = Children(i).Data
                                Case "MBDONGIA_GIAY" : z7120.MBDongia_Giay = Cdecp(Children(i).Data)
                                Case "MBDONGIA_MAU" : z7120.MBDongia_Mau = Cdecp(Children(i).Data)
                                Case "MBTONGTHOIGIAN" : z7120.MBTongthoigian = Cdecp(Children(i).Data)
                                Case "MBSONGUOI_GIO" : z7120.MBSonguoi_Gio = Cdecp(Children(i).Data)
                                Case "MCMAID" : z7120.MCMaID = Children(i).Data
                                Case "MCMATHANGID" : z7120.MCMathangID = Children(i).Data
                                Case "MCMACONGDOAN" : z7120.MCMacongdoan = Children(i).Data
                                Case "MCTENCONGDOAN" : z7120.MCTencongdoan = Children(i).Data
                                Case "MCTHOIGIANKIEMTRA" : z7120.MCThoigiankiemtra = Cdecp(Children(i).Data)
                                Case "MCTHOIGIAN_DATRA" : z7120.MCThoigian_datra = Cdecp(Children(i).Data)
                                Case "MCTHOIGIAN_CHOPHEP" : z7120.MCThoigian_chophep = Cdecp(Children(i).Data)
                                Case "MCDONGIA" : z7120.MCDongia = Cdecp(Children(i).Data)
                                Case "MCSOCONQUIDINH" : z7120.MCSoConQuiDinh = Cdecp(Children(i).Data)
                                Case "MCSOCONTHUCTE" : z7120.MCSoConThucTe = Cdecp(Children(i).Data)
                                Case "MCGHICHU" : z7120.MCGhichu = Children(i).Data
                                Case "DATEINSERT" : z7120.DateInsert = Children(i).Data
                                Case "DATEUPDATE" : z7120.DateUpdate = Children(i).Data
                                Case "INCHARGEINSERT" : z7120.InchargeInsert = Children(i).Data
                                Case "INCHARGEUPDATE" : z7120.InchargeUpdate = Children(i).Data
                                Case "REMARK" : z7120.Remark = Children(i).Data
                                Case "SESITE" : z7120.seSite = Children(i).Data
                                Case "CDSITE" : z7120.cdSite = Children(i).Data
                                Case "TIMEINSERT" : z7120.TimeInsert = Children(i).Data
                                Case "TIMEUPDATE" : z7120.TimeUpdate = Children(i).Data
                            End Select
                        End If
                    End If
                Catch ex As Exception

                End Try
            Next
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("K7120_MOVE", vbCritical)
        End Try
    End Function


    '=========================================================================================================================================================
    ' DATA MOVE FORM NEW AREA
    '=========================================================================================================================================================
    Public Sub K7120_MOVE(ByRef a7120 As T7120_AREA, ByRef b7120 As T7120_AREA)
        Try
            If trim$(a7120.AutoKey) = "" Then b7120.AutoKey = "" Else b7120.AutoKey = a7120.AutoKey
            If trim$(a7120.ShoesCode) = "" Then b7120.ShoesCode = "" Else b7120.ShoesCode = a7120.ShoesCode
            If trim$(a7120.seGroupJobProcess) = "" Then b7120.seGroupJobProcess = "" Else b7120.seGroupJobProcess = a7120.seGroupJobProcess
            If trim$(a7120.cdGroupJobProcess) = "" Then b7120.cdGroupJobProcess = "" Else b7120.cdGroupJobProcess = a7120.cdGroupJobProcess
            If trim$(a7120.MAMaID) = "" Then b7120.MAMaID = "" Else b7120.MAMaID = a7120.MAMaID
            If trim$(a7120.MAMahang) = "" Then b7120.MAMahang = "" Else b7120.MAMahang = a7120.MAMahang
            If trim$(a7120.MATenhang) = "" Then b7120.MATenhang = "" Else b7120.MATenhang = a7120.MATenhang
            If trim$(a7120.MAGhichu) = "" Then b7120.MAGhichu = "" Else b7120.MAGhichu = a7120.MAGhichu
            If trim$(a7120.MBSTT) = "" Then b7120.MBSTT = "" Else b7120.MBSTT = a7120.MBSTT
            If trim$(a7120.MBMathangID) = "" Then b7120.MBMathangID = "" Else b7120.MBMathangID = a7120.MBMathangID
            If trim$(a7120.MBNgayapdung) = "" Then b7120.MBNgayapdung = "" Else b7120.MBNgayapdung = a7120.MBNgayapdung
            If trim$(a7120.MBDongia_Giay) = "" Then b7120.MBDongia_Giay = "" Else b7120.MBDongia_Giay = a7120.MBDongia_Giay
            If trim$(a7120.MBDongia_Mau) = "" Then b7120.MBDongia_Mau = "" Else b7120.MBDongia_Mau = a7120.MBDongia_Mau
            If trim$(a7120.MBTongthoigian) = "" Then b7120.MBTongthoigian = "" Else b7120.MBTongthoigian = a7120.MBTongthoigian
            If trim$(a7120.MBSonguoi_Gio) = "" Then b7120.MBSonguoi_Gio = "" Else b7120.MBSonguoi_Gio = a7120.MBSonguoi_Gio
            If trim$(a7120.MCMaID) = "" Then b7120.MCMaID = "" Else b7120.MCMaID = a7120.MCMaID
            If trim$(a7120.MCMathangID) = "" Then b7120.MCMathangID = "" Else b7120.MCMathangID = a7120.MCMathangID
            If trim$(a7120.MCMacongdoan) = "" Then b7120.MCMacongdoan = "" Else b7120.MCMacongdoan = a7120.MCMacongdoan
            If trim$(a7120.MCTencongdoan) = "" Then b7120.MCTencongdoan = "" Else b7120.MCTencongdoan = a7120.MCTencongdoan
            If trim$(a7120.MCThoigiankiemtra) = "" Then b7120.MCThoigiankiemtra = "" Else b7120.MCThoigiankiemtra = a7120.MCThoigiankiemtra
            If trim$(a7120.MCThoigian_datra) = "" Then b7120.MCThoigian_datra = "" Else b7120.MCThoigian_datra = a7120.MCThoigian_datra
            If trim$(a7120.MCThoigian_chophep) = "" Then b7120.MCThoigian_chophep = "" Else b7120.MCThoigian_chophep = a7120.MCThoigian_chophep
            If trim$(a7120.MCDongia) = "" Then b7120.MCDongia = "" Else b7120.MCDongia = a7120.MCDongia
            If trim$(a7120.MCSoConQuiDinh) = "" Then b7120.MCSoConQuiDinh = "" Else b7120.MCSoConQuiDinh = a7120.MCSoConQuiDinh
            If trim$(a7120.MCSoConThucTe) = "" Then b7120.MCSoConThucTe = "" Else b7120.MCSoConThucTe = a7120.MCSoConThucTe
            If trim$(a7120.MCGhichu) = "" Then b7120.MCGhichu = "" Else b7120.MCGhichu = a7120.MCGhichu
            If trim$(a7120.DateInsert) = "" Then b7120.DateInsert = "" Else b7120.DateInsert = a7120.DateInsert
            If trim$(a7120.DateUpdate) = "" Then b7120.DateUpdate = "" Else b7120.DateUpdate = a7120.DateUpdate
            If trim$(a7120.InchargeInsert) = "" Then b7120.InchargeInsert = "" Else b7120.InchargeInsert = a7120.InchargeInsert
            If trim$(a7120.InchargeUpdate) = "" Then b7120.InchargeUpdate = "" Else b7120.InchargeUpdate = a7120.InchargeUpdate
            If trim$(a7120.Remark) = "" Then b7120.Remark = "" Else b7120.Remark = a7120.Remark
            If trim$(a7120.seSite) = "" Then b7120.seSite = "" Else b7120.seSite = a7120.seSite
            If trim$(a7120.cdSite) = "" Then b7120.cdSite = "" Else b7120.cdSite = a7120.cdSite
            If trim$(a7120.TimeInsert) = "" Then b7120.TimeInsert = "" Else b7120.TimeInsert = a7120.TimeInsert
            If trim$(a7120.TimeUpdate) = "" Then b7120.TimeUpdate = "" Else b7120.TimeUpdate = a7120.TimeUpdate
        Catch ex As Exception
            Call MsgBoxP("K7120_MOVE", vbCritical)
        End Try
    End Sub


End Module
