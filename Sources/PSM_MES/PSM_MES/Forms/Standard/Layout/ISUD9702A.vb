Public Class ISUD9702A
    Private Enum colvS1
        LayoutNo_Key = 0
        FormName = 1
        User = 2
        ItemName = 3
        ControlName = 4
        ControlData1 = 5
        ControlData2 = 6
        ControlData3 = 7
        ControlData4 = 8
        Type = 9
        DefaultValue1 = 10
        DefaultValue2 = 11
        DefaultValue3 = 12
        CreateDate = 13
        Active = 14
    End Enum


    Private W9702 As T9702_AREA
    Private W9706 As T9706_AREA

    Private FormName As String = String.Empty
    Private xCOL As Long
    Private xRow As Long
    Public Sub Link_COUSTOMIZATION_ISUD(_FormName As String)

        FormName = _FormName
        Me.Text = Me.Text & "-" & FormName
        Me.ShowDialog()
    End Sub

    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        Vs1.Enabled = False

        DS1 = PrcDS("USP_ISUD9702A_SEARCH_VS1", cn, FormName)

        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            Vs1.ActiveSheet.RowCount = 0
            Exit Function
        End If

        Dim i As Integer = 0
        For Each RS01 As DataRow In DS1.Tables(0).Rows

            Call setData(Vs1, colvS1.LayoutNo_Key, i, RS01!Key_LayoutNo)

            Call setData(Vs1, colvS1.FormName, i, RS01!FormName)
            Call setData(Vs1, colvS1.User, i, RS01!User)
            Call setData(Vs1, colvS1.ItemName, i, RS01!ItemName)
            Call setData(Vs1, colvS1.ControlName, i, RS01!ControlName)
            Call setData(Vs1, colvS1.ControlData1, i, RS01!ControlData1)
            Call setData(Vs1, colvS1.ControlData2, i, RS01!ControlData2)
            Call setData(Vs1, colvS1.ControlData3, i, RS01!ControlData3)
            Call setData(Vs1, colvS1.ControlData4, i, RS01!ControlData4)

            Select Case RS01!Type
                Case "1" 'SelectLabelText
                    Call setData(Vs1, colvS1.Type, i, "SelectLabelText")
                Case "2" 'SelectPeaceCalDou
                    Call setData(Vs1, colvS1.Type, i, "SelectPeaceCalDou")
                Case "3" 'SelectPeaceCalSin
                    Call setData(Vs1, colvS1.Type, i, "SelectPeaceCalSin")
                Case "4" 'SelectPeaceHLPButton
                    Call setData(Vs1, colvS1.Type, i, "SelectPeaceHLPButton")
            End Select

            Call setData(Vs1, colvS1.DefaultValue1, i, RS01!DefaultValue1)
            Call setData(Vs1, colvS1.DefaultValue2, i, RS01!DefaultValue2)
            Call setData(Vs1, colvS1.DefaultValue3, i, RS01!DefaultValue3)
            Call setData(Vs1, colvS1.CreateDate, i, RS01!CreateDate)
            Call setData(Vs1, colvS1.Active, i, RS01!Active)

            i += 1
        Next

        Vs1.ActiveSheet.RowCount = i

        Vs1.ActiveSheet.OperationMode = OperationMode.Normal
        Vs1.Enabled = True
        DATA_SEARCH01 = True
    End Function

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Call DATA_SEARCH01()
    End Sub

    Private Sub COUSTOMIZATION_ISUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd_SEARCH.PerformClick()
    End Sub

    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change

        Try
            If Trim$(getData(Vs1, colvS1.LayoutNo_Key, xRow)) = "" Then Exit Sub

            W9702.LayoutNo = getData(Vs1, colvS1.LayoutNo_Key, xRow)

            W9702.FormName = getData(Vs1, colvS1.FormName, xRow)
            W9702.User = getData(Vs1, colvS1.User, xRow)
            W9702.ItemName = getData(Vs1, colvS1.ItemName, xRow)
            W9702.ControlName = getData(Vs1, colvS1.ControlName, xRow)
            W9702.ControlData1 = getData(Vs1, colvS1.ControlData1, xRow)
            W9702.ControlData2 = getData(Vs1, colvS1.ControlData2, xRow)
            W9702.ControlData3 = getData(Vs1, colvS1.ControlData3, xRow)
            W9702.ControlData4 = getData(Vs1, colvS1.ControlData4, xRow)

            Dim tmp As String = getData(Vs1, colvS1.Type, xRow)

            Select Case tmp
                Case "SelectLabelText" 'SelectLabelText
                    W9702.Type = "1"
                Case "SelectPeaceCalDou" 'SelectPeaceCalDou
                    W9702.Type = "2"
                Case "SelectPeaceCalSin" 'SelectPeaceCalSin
                    W9702.Type = "3"
                Case "SelectPeaceHLPButton" 'SelectPeaceHLPButton
                    W9702.Type = "4"
                Case Else
                    W9702.Type = "1"
            End Select

            W9702.DefaultValue1 = getData(Vs1, colvS1.DefaultValue1, xRow)
            W9702.DefaultValue2 = getData(Vs1, colvS1.DefaultValue2, xRow)
            W9702.DefaultValue3 = getData(Vs1, colvS1.DefaultValue3, xRow)

            W9702.CreateDate = System_Date_8()

            W9702.Active = getData(Vs1, colvS1.Active, xRow)

            Call REWRITE_PFK9702(W9702)

            W9706.LayoutNoRef = W9702.LayoutNo
            W9706.FormName = W9702.FormName
            W9706.GroupUser = Layout_GroupUser
            W9706.ItemName = W9702.ItemName
            W9706.ControlName = W9702.ControlName
            W9706.ControlData1 = W9702.ControlData1
            W9706.ControlData2 = W9702.ControlData2
            W9706.ControlData3 = W9702.ControlData3
            W9706.ControlData4 = W9702.ControlData4
            W9706.Type = W9702.Type
            W9706.DefaultValue1 = W9702.DefaultValue1
            W9706.DefaultValue2 = W9702.DefaultValue2
            W9706.DefaultValue3 = W9702.DefaultValue3
            W9706.CreateDate = W9702.CreateDate
            W9706.Active = W9702.Active

            Call REWRITE_PFK9706(W9706)

        Catch ex As Exception
            Call Error_Message("37", "Vs1_Change")
        End Try

    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        xCOL = Vs1.ActiveSheet.ActiveColumnIndex
        xRow = Vs1.ActiveSheet.ActiveRowIndex
    End Sub

    Private Sub COUSTOMIZATION_ISUD_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class