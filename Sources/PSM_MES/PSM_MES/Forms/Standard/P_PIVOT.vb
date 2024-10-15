Imports DevExpress.XtraPivotGrid

Public Class P_PIVOT
    Sub New()
        InitializeComponent()
    End Sub

    Dim dt As DataTable
    Public Sub Link_Pivot(_dt As DataTable)
        Me.dt = _dt
        Me.Pivot_Gird.DataSource = Nothing
        Me.Pivot_Gird.Fields.Clear()
        Me.ShowDialog()
    End Sub

    Private Sub Pivot_From_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Pivot_Gird.DataSource = Me.dt

        Me.Pivot_Gird.RetrieveFields()

       call FormatFieldsAsNumber()

        AddHandler Pivot_Gird.CustomCellDisplayText, AddressOf Pivot_Gird_CustomCellDisplayText
    End Sub

    Private Sub Pivot_Gird_CustomCellDisplayText(sender As Object, e As PivotCellDisplayTextEventArgs)
        Dim field As PivotGridField = e.DataField
        If field IsNot Nothing AndAlso e.Value IsNot Nothing Then
            If field.FieldName.ToLower().Contains("qty") OrElse field.FieldName.ToLower().Contains("total") Then
                e.DisplayText = String.Format("{0:n2}", e.Value) 
            ElseIf field.FieldName.ToLower().Contains("price") Then
                e.DisplayText = String.Format("{0:n2}", e.Value) 
            ElseIf field.FieldName.ToLower().Contains("amount") Then
                e.DisplayText = String.Format("{0:n0}", e.Value)
            ElseIf field.FieldName.ToLower().Contains("date") Then
                Try
                    
                    Dim dateValue As DateTime = DateTime.ParseExact(e.Value.ToString(), "yyyyMMdd", Nothing)
                    e.DisplayText = dateValue.ToString("yyyy/MM/dd")
                Catch ex As Exception
                    e.DisplayText = e.Value.ToString()
                End Try
            End If
        End If
    End Sub

    Private Sub FormatFieldsAsNumber()
        For Each field As PivotGridField In Me.Pivot_Gird.Fields
            If field IsNot Nothing Then
                If field.FieldName.ToLower().Contains("qty") OrElse field.FieldName.ToLower().Contains("total") Then
                    field.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    field.CellFormat.FormatString = "n2" 
                ElseIf field.FieldName.ToLower().Contains("price") Then
                    field.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    field.CellFormat.FormatString = "n2" 
                ElseIf field.FieldName.ToLower().Contains("amount") Then
                    field.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    field.CellFormat.FormatString = "n0" 
                ElseIf field.FieldName.ToLower().Contains("date") Then
                    field.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    field.CellFormat.FormatString = "yyyy/MM/dd"
                Else
                    field.CellFormat.FormatType = DevExpress.Utils.FormatType.None
                End If
            End If
        Next
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
End Class
