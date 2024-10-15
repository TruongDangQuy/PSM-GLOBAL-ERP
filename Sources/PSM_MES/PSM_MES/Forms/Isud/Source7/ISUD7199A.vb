Public Class ISUD7199A

#Region "Variable"

    Private wJOB As Integer

    Private W7199 As T7199_AREA
    Private L7199 As T7199_AREA

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private forma As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7199A(job As Integer, DateExchange As String, Optional ByVal TAG As String = "") As Boolean
        forma = False
        Me.Tag = TAG
        D7199.DateExchange = DateExchange
        txt_DateExchange.Data = DateExchange
        wJOB = job : L7199 = D7199

        Link_ISUD7199A = False

        Select Case job
            Case 1
            Case Else

        End Select

        Me.ShowDialog()

        Link_ISUD7199A = isudCHK

    End Function
#End Region

#Region "Form_Load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        If forma = True Then Exit Sub
        Me.Form_KeyDown()

        Call FORM_INIT()
        Call DATA_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"
                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    forma = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                txt_DateExchange.Data = Pub.DAT

                tst_iDelete.Visible = False
                tst_iSave.Visible = True

                Call DATA_SEARCH01()

                Setfocus(txt_DateExchange)
            Case 2
                Me.Text = Me.Text & " - SEARCH"

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    forma = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                tst_iDelete.Visible = False
                tst_iSave.Visible = False

                Call DATA_SEARCH01()

            Case 3
                Me.Text = Me.Text & " - UPDATE"

                If CHK(3) <> "1" Then
                    isudCHK = False
                    forma = True
                    Me.Dispose()
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                txt_DateExchange.Enabled = False

                tst_iDelete.Visible = False
                tst_iSave.Visible = True

                Call DATA_SEARCH01()
            Case 4
                Me.Text = Me.Text & " - DELETE"
                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    forma = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                tst_iDelete.Visible = True
                tst_iSave.Visible = False

                Call DATA_SEARCH01()

        End Select

        forma = True
    End Sub

    Private Sub DATA_INIT()
        Call D7199_CLEAR()
        W7199 = D7199

        WRITE_CHK = ""
        KEY_CHK = ""
    End Sub

    Private Sub FORM_INIT()
        tst_iPrint.Visible = False
        tst_iPrint_Print.Visible = False
    End Sub
#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        Try
            DS1 = PrcDS("USP_ISUD7911A_SEARCH_VS1", cn, txt_DateExchange.Data)

            If GetDsRc(DS1) = 0 Then
                DS2 = PrcDS("USP_ISUD7911A_SEARCH_VS1_INSERT", cn, txt_DateExchange.Data, ListCode("UnitPrice"))
                SPR_PRO_NEW(Vs1, DS2, "USP_ISUD7911A_SEARCH_VS1", "Vs1")
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7911A_SEARCH_VS1", "Vs1")

            DATA_SEARCH01 = True


        Catch ex As Exception

        End Try

    End Function
#End Region

#Region "Function"
    Private Function Data_Check() As Boolean
        Data_Check = True
    End Function

    Private Sub DATA_MOVE()
        Dim i As Integer
        If Data_Check() = False Then Exit Sub

        Try
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                W7199.DateExchange = txt_DateExchange.Data
                W7199.seUnitPrice = ListCode("UnitPrice")
                W7199.cdUnitPrice = getData(Vs1, getColumIndex(Vs1, "cdUnitPrice"), i)
                W7199.Value = CDecp(getData(Vs1, getColumIndex(Vs1, "Value"), i))
                W7199.Value1 = CDecp(getData(Vs1, getColumIndex(Vs1, "Value1"), i))
                W7199.Value2 = CDecp(getData(Vs1, getColumIndex(Vs1, "Value2"), i))
                W7199.Value3 = CDecp(getData(Vs1, getColumIndex(Vs1, "Value3"), i))
                W7199.Value4 = CDecp(getData(Vs1, getColumIndex(Vs1, "Value4"), i))
                W7199.Value5 = CDecp(getData(Vs1, getColumIndex(Vs1, "Value5"), i))
                W7199.Value6 = CDecp(getData(Vs1, getColumIndex(Vs1, "Value6"), i))
                W7199.Value7 = CDecp(getData(Vs1, getColumIndex(Vs1, "Value7"), i))
                W7199.Value8 = CDecp(getData(Vs1, getColumIndex(Vs1, "Value8"), i))
                W7199.Value9 = CDecp(getData(Vs1, getColumIndex(Vs1, "Value9"), i))
                W7199.Remark = getData(Vs1, getColumIndex(Vs1, "Remark"), i)

                If READ_PFK7199_IU(W7199.DateExchange, W7199.seUnitPrice, W7199.cdUnitPrice) Then
                    If REWRITE_PFK7199(W7199) = True Then isudCHK = True : WRITE_CHK = "*"
                Else
                    If WRITE_PFK7199(W7199) = True Then isudCHK = True : WRITE_CHK = "*"
                End If
            Next
            Me.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DATA_UPDATE()

        If Data_Check() = False Then Exit Sub

        Call DATA_MOVE()

        Me.Dispose()

    End Sub

    Private Sub DATA_DELETE()
        W7199.DateExchange = txt_DateExchange.Data
        If DELETE_PFK7199_ALL(W7199) = True Then isudCHK = True
        Me.Dispose()

    End Sub

    Private Sub KEY_COUNT()

    End Sub
#End Region

#Region "Events"
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click

        Select Case wJOB
            Case 1
                Call DATA_MOVE()
                Setfocus(txt_DateExchange)
            Case 2 : Me.Dispose()
            Case 3 : Call DATA_UPDATE()
            Case 4 : Call DATA_DELETE()
        End Select

    End Sub

    Private Sub tst_iDelete_Click(sender As Object, e As EventArgs) Handles tst_iDelete.Click

        Select Case MsgBoxP("Do you want to delete ?", vbYesNo)
            Case vbYes
            Case vbNo : Exit Sub
        End Select
        Call DATA_DELETE()

    End Sub

    Private Sub tst_iClose_Click(sender As Object, e As EventArgs) Handles tst_iClose.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub

    Private Sub txt_DateExchange_m_Textchange(sender As Object, e As EventArgs) Handles txt_DateExchange.m_Textchange
        Call DATA_SEARCH01()
    End Sub
#End Region

End Class