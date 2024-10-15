Public Class HLP3428B

#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Protected prg As E_PRG

    Private W3421 As New T3421_AREA
    Private L3421 As New T3421_AREA

    Private W3422 As New T3422_AREA
    Private L3422 As New T3422_AREA

    Private Form_Close As Boolean
    Private PayableType As Integer
    Private cdSeason As String
    Private SupplierCode As String

#End Region

#Region "Form_load"
    Friend Function Link_HLP3428B(Chk_PayType As Integer) As Boolean

        Link_HLP3428B = False
        PayableType = Chk_PayType

        Try
            Me.ShowDialog()

            Link_HLP3428B = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_HLP2331Material"))
        End Try


    End Function

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.KeyPreview = True

        Call DATA_INIT()


    End Sub
    Private Sub HLP2331A_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub
    Overrides Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey

            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DATA_INIT()
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
      

    End Sub

#End Region

#Region "Function"

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH01(Optional ByVal xsort As String = "1") As Boolean

        DATA_SEARCH01 = False

        PeacePanalSeach.Enabled = False

        Select Case True
            Case PayableType = 3

                DS1 = PrcDSVN("USP_HLP3428B_SEARCH_VS1", cn, "510", "*" & txt_MaterialName.Data)

                If GetDsRc(DS1) = 0 Then
                    SPR_PRO_NEW(PeacePanalSeach, DS1, "USP_HLP3428B_SEARCH_VS1", "Vs1")
                    PeacePanalSeach.Enabled = True

                    Exit Function
                End If

                SPR_PRO_NEW(PeacePanalSeach, DS1, "USP_HLP3428B_SEARCH_VS1", "Vs1")
                DATA_SEARCH01 = True

        End Select

        PeacePanalSeach.Enabled = True
    End Function

    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False

    End Function
    Private Function CustomerPurchasing_CHK() As String
        CustomerPurchasing_CHK = "1"
        Return CustomerPurchasing_CHK
    End Function
#End Region

#Region "Event"

    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles PeacePanalSeach.GotFocus


    End Sub

    Private Sub chk_FSEL_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click


        Call DATA_SEARCH01()
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Try
            hlp0000SeVa = ""
            hlp0000SeVaTt = ""
            Dim i As Integer
            Dim CheckValue As Boolean = False

            For i = 0 To PeacePanalSeach.ActiveSheet.RowCount - 1
                If getDataM(PeacePanalSeach, getColumIndex(PeacePanalSeach, "DCHK"), i) = "1" Then
                    CheckValue = True
                    Select Case True
                        Case PayableType = "3"
                            hlp0000SeVa &= getData(PeacePanalSeach, getColumIndex(PeacePanalSeach, "KEY_BasicCode"), i) & ","
                    End Select

                End If
            Next

            hlp0000SeVa = Strings.Left(hlp0000SeVa, Len(hlp0000SeVa) - 1)
            hlp0000SeVaTt = hlp0000SeVa
            isudCHK = True

            If CheckValue = False Then
                hlp0000SeVa = ""
                hlp0000SeVaTt = ""
                isudCHK = False
            End If
            Me.Dispose()
        Catch ex As Exception
            MsgBoxP("cmd_OK_Click!", vbCritical)
        End Try
    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        isudCHK = False
        Me.Dispose()
    End Sub

#End Region


End Class