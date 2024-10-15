Public Class PIVOT_DATA

    Dim dt As DataTable
    Public Sub Link_Pivot(_dt As DataTable)
        Me.dt = _dt
        Me.Pivot_Gird.DataSource = Nothing
        Me.Pivot_Gird.Fields.Clear()
        Me.ShowDialog()

    End Sub

    Sub New()
        InitializeComponent()
    End Sub

    Private Sub Pivot_Gird_KeyDown(sender As Object, e As KeyEventArgs) Handles Pivot_Gird.KeyDown
        If e.Control = True And e.KeyCode = Keys.S Then
            Dim file As New SaveFileDialog()
            file.Filter = "Excel File|*.xlsx"
            If file.ShowDialog() = DialogResult.OK Then
                Pivot_Gird.ExportToXlsx(file.FileName)
                Select Case MsgBox("Do you want open folder save this file?", MsgBoxStyle.YesNo, "PSM")
                    Case MsgBoxResult.Yes
                        Process.Start("explorer.exe", file.FileName)
                End Select
            End If
        End If
    End Sub

    Private Sub PIVOT_DATA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Pivot_Gird.DataSource = Me.dt
        'Dim fieldDate As New PivotGridField("K1126_DateConfirm", PivotArea.RowArea)
        'fieldDate.Caption = "Ngày"

        'Dim SalesOrderNo As New PivotGridField("K1126_SalesOrderNo", PivotArea.FilterArea)
        'SalesOrderNo.Caption = "Order"

        'Dim PriceExchange As New PivotGridField("K1126_PriceExchange", PivotArea.RowArea)
        'PriceExchange.Caption = "PriceExchange"

        'Dim PriceFinalUsd As New PivotGridField("K1126_PriceFinalUsd", PivotArea.ColumnArea)
        'PriceFinalUsd.Caption = "PriceFinalUsd"

        'Me.Pivot_Gird.Fields.AddRange(New PivotGridField() {SalesOrderNo,fieldDate,PriceExchange,PriceFinalUsd})

        ' load lại các fiel trong datatable mới đưa vào.
        Me.Pivot_Gird.RetrieveFields()
        Me.WindowState = FormWindowState.Maximized

    End Sub

End Class