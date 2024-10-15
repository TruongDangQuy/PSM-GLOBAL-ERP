Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class PFP79000

#Region "Variable"
    Protected prg As E_PRG
    Private Dsu01 As Long     'Data Su
    Private Dsu02 As Long     'Data Su
    Private Dsu03 As Long     'Data Su
    Private KEY_SEQ As String

    Private Form_Close As Boolean
#End Region

#Region "Formload"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)
        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()


    End Sub

    Private Sub PFP17811_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub
    Private Function Clone(ByVal sheetView As SheetView) As SheetView
        Dim m As New MemoryStream
        Dim b As New BinaryFormatter
        sheetView.SheetName = "New"
        b.Serialize(m, sheetView)
        m.Position = 0

        Return b.Deserialize(m)
    End Function
    Private Sub FORM_INIT()

        DS1 = PrcDS("USP_PFP79000_SEARCH_HEAD", cn)
        Dim i As Integer


        Try
            If GetDsRc(DS1) = 0 Then Exit Sub
            If GetDsRc(DS1) > 0 Then ItemMain.SelectedTab.Text = GetDsData(DS1, 0, 1)

            If GetDsRc(DS1) > 1 Then
                For i = 1 To GetDsRc(DS1) - 1
                    ItemMain.TabPages.Add(GetDsData(DS1, i, 1))

                    Dim obj_a As New PSMGlobal.PeaceFarpoint
                    obj_a.Sheets.Add(Clone(Vs1.ActiveSheet))
                    obj_a.Dock = DockStyle.Fill

                    ItemMain.TabPages(i).Controls.Add(obj_a)
                    'ItemMain.TabPages(i).ToolTipText = CStrp(GetDsData(DS1, i, 3))
                Next
            End If
            If ItemMain.TabCount > 0 Then ItemMain.ItemSize = New Size((Me.Width - 30) / ItemMain.TabCount, 25)

        Catch ex As Exception

        End Try
    End Sub


    Private Sub DATA_INIT()
        txt_DateReport.Data = Pub.DAT
    End Sub

#End Region

#Region "Link_ISUD"
    Overrides Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey
                Case Keys.F5 : Call MAIN_JOB01()
                Case Keys.F6 : Call MAIN_JOB02()
                Case Keys.F7 : Call MAIN_JOB03()
                Case Keys.F8 : Call MAIN_JOB04()
                Case Keys.F9 : Call MAIN_JOB05()
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click, tst_5.Click, tst_6.Click
        If sender.Equals(tst_1) Then
            MAIN_JOB01()
        End If
        If sender.Equals(tst_2) Then
            MAIN_JOB02()
        End If
        If sender.Equals(tst_3) Then
            MAIN_JOB03()
        End If
        If sender.Equals(tst_4) Then
            MAIN_JOB04()
        End If
    End Sub

    Private Sub MAIN_JOB01()

    End Sub

    Private Sub MAIN_JOB02()

    End Sub

    Private Sub MAIN_JOB03()

    End Sub

    Private Sub MAIN_JOB04()

    End Sub

    Private Sub MAIN_JOB05()
        If getData(Vs1, 12, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
    End Sub

#End Region

#Region "PFP_SEARCH"
    Private Function DATA_SEARCH(sender As Object) As Boolean
        DATA_SEARCH = False
        Dim i As Integer

        sender.Enabled = False

        Dim ProcName As String

        ProcName = "USP_PFP79000_SEARCH_VS00"

        If READ_PFK7101_NAME(ItemMain.SelectedTab.Text) Then
            DS1 = PrcDS(ProcName, cn, txt_DateReport.Data, txt_cdSite.Code, D7101.CustomerCode)

            sender.ActiveSheet.GrayAreaBackColor = Color.White

            If GetDsRc(DS1) = 0 Then
                sender.Enabled = True
                SPR_PRO_NEW(sender, DS1, ProcName, "VS00")
                Exit Function
            End If

            SPR_PRO_NEW(sender, DS1, ProcName, "VS00")

            sender.Enabled = True
            DATA_SEARCH = True
        End If

      
    End Function



#End Region

#Region "EVENT"

    'GOTFOCUS
    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False, WordConv("INSERT") & "(F5)")
    End Sub

    'LOSTFOCUS
    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles Vs1.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INSERT") & "(F5)")
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Try
            Dim child As List(Of System.Windows.Forms.Control)
            Dim i As Integer
            Dim b As Object

            child = ItemMain.SelectedTab.FindAllChildren()

            For i = 0 To child.Count - 1
                If TypeOf child(i) Is FarPoint.Win.Spread.FpSpread Then
                    b = CType(child(i), FarPoint.Win.Spread.FpSpread)
                    Call DATA_SEARCH(b)
                End If
            Next

        Catch ex As Exception

        End Try


    End Sub
    Private Sub Me_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width > 30 Then
            If ItemMain.TabCount > 0 Then ItemMain.ItemSize = New Size((Me.Width - 30) / ItemMain.TabCount, 25)
        End If
    End Sub

#End Region



    Private Sub ItemMain_DoubleClick(sender As Object, e As EventArgs) Handles ItemMain.DoubleClick
        Try
            Dim child As List(Of System.Windows.Forms.Control)
            Dim i As Integer
            Dim b As Object

            child = ItemMain.SelectedTab.FindAllChildren()

            For i = 0 To child.Count - 1
                If TypeOf child(i) Is FarPoint.Win.Spread.FpSpread Then
                    b = CType(child(i), FarPoint.Win.Spread.FpSpread)
                    Call DATA_SEARCH(b)
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class