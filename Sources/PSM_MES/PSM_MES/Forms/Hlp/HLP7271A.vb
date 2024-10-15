Public Class HLP7271A

#Region "Variable"
    Public W1_Head As Integer

    Private W7101 As T7101_AREA
    Private W7171 As T7171_AREA
    Private Group00, Code00 As String
#End Region

#Region "Form_Load"
    Public Sub Link_ISUD7271A(Const_WareHouseGroup_00 As String, Const_WarehouseCode_00 As String)
        Try
            Group00 = Const_WareHouseGroup_00
            Code00 = Const_WarehouseCode_00
            Me.Text = HLPNA
            hlp0000SeVaTt = ""
            hlp0000SeVa = ""
            DATA_SEARCH01(Const_WareHouseGroup_00, Const_WarehouseCode_00)
            Me.ShowDialog()
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("PROCESS PRODUCTION PROCESSING"))
        End Try


    End Sub
#End Region

#Region "Methods"
    Public Function DATA_SEARCH01(Const_WareHouseGroup_00 As String, Const_WarehouseCode_00 As String) As Boolean
        Dim SQl As String
        Dim cmd As New SqlClient.SqlCommand
        Dim i, MaxX, MaxY, MaxXY As Integer

        Dim PerC As Decimal

        DATA_SEARCH01 = False

        SPR_SET(Vs1, , , , OperationMode.Normal, True)
        Vs1.ActiveSheet.RowHeader.Visible = False
        Vs1.ActiveSheet.ColumnHeader.Visible = False

        Try
            SQl = "  SELECT MAX(CAST(K7271_HorizontalPosition AS INT)) MAXCODE FROM [SYVINA_MES].[dbo].[PFK7271]"
            SQl = SQl + " WHERE K7271_cdWarehouseGroup ='" + Const_WareHouseGroup_00 + "'"
            SQl = SQl + " AND  K7271_cdWarehouseCode ='" + Const_WarehouseCode_00 + "'"
            cmd = New SqlClient.SqlCommand(SQl, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAXCODE) Then MaxX = 0 Else MaxX = CIntp(rd!MAXCODE)
            rd.Close()

            SQl = "  SELECT MAX(CAST(K7271_VerticalPosition AS INT)) MAXCODE FROM [SYVINA_MES].[dbo].[PFK7271]"
            SQl = SQl + " WHERE K7271_cdWarehouseGroup ='" + Const_WareHouseGroup_00 + "'"
            SQl = SQl + " AND  K7271_cdWarehouseCode ='" + Const_WarehouseCode_00 + "'"
            cmd = New SqlClient.SqlCommand(SQl, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAXCODE) Then MaxY = 0 Else MaxY = CIntp(rd!MAXCODE)
            rd.Close()


            If MaxX >= MaxY Then MaxXY = MaxX Else MaxXY = MaxY
            Vs1.ActiveSheet.RowCount = MaxXY
            Vs1.ActiveSheet.ColumnCount = MaxXY

            For i = 0 To MaxXY - 1
                Vs1.ActiveSheet.Columns(i).Width = CIntp(800 / (MaxXY + 1))
                Vs1.ActiveSheet.Rows(i).Height = CIntp(700 / (MaxXY + 1))
                Vs1.ActiveSheet.Columns(i).VerticalAlignment = CellVerticalAlignment.Center
                Vs1.ActiveSheet.Columns(i).HorizontalAlignment = CellHorizontalAlignment.Center
            Next


            DS1 = PrcDS("USP_HLP7271_SEARCH_VS1_GROUP001", cn, "", Const_WareHouseGroup, Const_WareHouseGroup_00, Const_WarehouseCode_00)

            For i = 0 To GetDsRc(DS1) - 1
                setData(Vs1, CIntp(GetDsData(DS1, i, "HorizontalPosition")) - 1, CIntp(GetDsData(DS1, i, "VerticalPosition")) - 1, GetDsData(DS1, i, "WarehousePositionName"))
                setCell(Vs1, CIntp(GetDsData(DS1, i, "HorizontalPosition")) - 1, CIntp(GetDsData(DS1, i, "VerticalPosition")) - 1, GetDsData(DS1, i, "WarehousePositionCode"))
                PerC = (CDecp(GetDsData(DS1, i, "BoxInBoundYarn")) - CDecp(GetDsData(DS1, i, "BoxOutBoundYarn")))
                'setData(Vs1, CIntp(GetDsData(DS1, i, "HorizontalPosition")) - 1, CIntp(GetDsData(DS1, i, "VerticalPosition")) - 1, GetDsData(DS1, i, "WarehousePositionName") & " - " & _
                '                     FormatPercent(PerC / CDecp(GetDsData(DS1, i, "Remark")), 2))
                Select Case PerC
                    Case Is >= 48
                        SPR_BACKCOLORCELL(Vs1, Color.Red, CIntp(GetDsData(DS1, i, "HorizontalPosition")) - 1, CIntp(GetDsData(DS1, i, "VerticalPosition")) - 1)
                    Case Is >= 30
                        SPR_BACKCOLORCELL(Vs1, Color.Yellow, CIntp(GetDsData(DS1, i, "HorizontalPosition")) - 1, CIntp(GetDsData(DS1, i, "VerticalPosition")) - 1)
                    Case Is > 0
                        SPR_BACKCOLORCELL(Vs1, Color.Lime, CIntp(GetDsData(DS1, i, "HorizontalPosition")) - 1, CIntp(GetDsData(DS1, i, "VerticalPosition")) - 1)
                    Case Is = 0
                        SPR_BACKCOLORCELL(Vs1, Color.White, CIntp(GetDsData(DS1, i, "HorizontalPosition")) - 1, CIntp(GetDsData(DS1, i, "VerticalPosition")) - 1)
                End Select
            Next


        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function
#End Region

#Region "Events"
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        Me.Dispose()
    End Sub

    Private Sub SelectLabelSearch1_KeyDown(sender As Object, e As KeyPressEventArgs) Handles txt_Name.txtTextKeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cmd_SEARCH.PerformClick()
        End If
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        DATA_SEARCH01(Group00, Code00)
    End Sub

    Public Overridable Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If getData(Vs1, Vs1.ActiveSheet.ActiveColumnIndex, Vs1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            Exit Sub
        Else
            hlp0000SeVaTt = getCell(Vs1, Vs1.ActiveSheet.ActiveColumnIndex, Vs1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVa = getData(Vs1, Vs1.ActiveSheet.ActiveColumnIndex, Vs1.ActiveSheet.ActiveRowIndex)
        End If
        Me.Close()
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs)
        If e.Row < 0 Then Exit Sub
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If getData(Vs1, Vs1.ActiveSheet.ActiveColumnIndex, Vs1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            Exit Sub
        Else
            hlp0000SeVaTt = getCell(Vs1, Vs1.ActiveSheet.ActiveColumnIndex, Vs1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVa = getData(Vs1, Vs1.ActiveSheet.ActiveColumnIndex, Vs1.ActiveSheet.ActiveRowIndex)
        End If
        Me.Close()
    End Sub
#End Region

End Class