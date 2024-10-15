Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class SPFP87002

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


        Dim i As Integer

        Me.WindowState = FormWindowState.Maximized
        Vs1.HorizontalScrollBarPolicy = ScrollBarPolicy.Never
        Vs1.VerticalScrollBarPolicy = ScrollBarPolicy.Never
        txt_DateReport.Data = Pub.DAT
        Call DATA_SEARCH_01()

        Try

        Catch ex As Exception

        End Try
    End Sub


    Private Sub DATA_INIT()

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


    Private Sub MAIN_JOB01()

    End Sub

    Private Sub MAIN_JOB02()

    End Sub

    Private Sub MAIN_JOB03()

    End Sub

    Private Sub MAIN_JOB04()

    End Sub

    Private Sub MAIN_JOB05()

    End Sub

#End Region

#Region "PFP_SEARCH"
    Private Function DATA_SEARCH_01() As Boolean
        DATA_SEARCH_01 = False
        Dim i As Integer

        Call system_as_date()

        DS1 = PrcDS("USP_SPFP87002_SEARCH_HEAD", cn, txt_DateReport.Data)

        If GetDsRc(DS1) > 0 Then lbl_Factory.Text = GetDsData(DS1, 0, 0)


        DS1 = PrcDS("USP_SPFP87002_SEARCH_VS1", cn, txt_DateReport.Data)

        Try

            SPR_PRO_NEW(Vs1, DS1, "USP_SPFP87002_SEARCH_VS1", "Vs1")

            DS1 = PrcDS("USP_SPFP87002_SEARCH_HEAD", cn, txt_DateReport.Data)
            Dim chkF5 As String = ""
            chkF5 = GetDsData(DS1, 0, 1)
            If chkF5 = "" Then chkF5 = False

            Dim decHeight As Decimal = 0
            Dim decWidth As Decimal = 0

            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If Vs1.ActiveSheet.Rows(i).Visible = True Then decHeight = decHeight + Vs1.ActiveSheet.Rows(i).Height

            Next

            decHeight = decHeight + 180

            For i = 0 To Vs1.ActiveSheet.ColumnCount - 1
                If Vs1.ActiveSheet.Columns(i).Visible = True Then decWidth = decWidth + Vs1.ActiveSheet.Columns(i).Width

            Next

            decWidth = decWidth + 30

            Dim decHeightScreen As Decimal = Me.Size.Height
            Dim decWidthScreen As Decimal = Me.Size.Width

            If decHeightScreen > 0 And decWidthScreen > 0 Then


                Dim ratHeight As Decimal
                Dim ratWidth As Decimal


                'If decHeightScreen >= decHeight Then ratHeight = Math.Round(decHeightScreen / decHeight, 2)
                'If decHeightScreen < decHeight Then ratHeight = Math.Round(decHeight / decHeightScreen, 2)

                ratHeight = Math.Round(decHeightScreen / decHeight, 2)

                'If decWidthScreen >= decWidth Then ratWidth = Math.Round(decWidthScreen / decWidth, 2)
                'If decWidthScreen < decWidth Then ratWidth = Math.Round(decWidth / decWidthScreen, 2)
                ratWidth = Math.Round(decWidthScreen / decWidth, 2)

                For i = 0 To Vs1.ActiveSheet.ColumnCount - 1
                    If chkF5 = "" Then
                        Me.Show()
                        Application.DoEvents()
                    End If
                  
                    Vs1.Select()
                    Vs1.ActiveSheet.Columns(i).Width = Vs1.ActiveSheet.Columns(i).Width * ratWidth

                Next

                For i = 0 To Vs1.ActiveSheet.RowCount - 1

                    If chkF5 = "" Then
                        Me.Show()
                        Application.DoEvents()
                    End If

                    Vs1.Select()
                    Vs1.ActiveSheet.Rows(i).Height = Vs1.ActiveSheet.Rows(i).Height * ratHeight

                Next

                If chkF5 = "" Then
                    Me.Show()
                    Application.DoEvents()
                End If




            End If


           
                tim_01.Enabled = True
                tim_01.Interval = 60000
                tim_01.Start()

                Timer2.Enabled = True
                Timer2.Interval = 2000
                Timer2.Start()

         

        Catch ex As Exception

        End Try


        DATA_SEARCH_01 = True
    End Function



#End Region

#Region "EVENT"

    'GOTFOCUS


#End Region


    Private Sub tim_01_Tick(sender As Object, e As EventArgs) Handles tim_01.Tick
        Try
            Call DATA_SEARCH_01()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            Dim i, j As Integer

            If Vs1.ActiveSheet.RowCount > 0 Then

                DS2 = PrcDS("USP_SPFP87002_SEARCH_BACKCOLOR", cn, txt_DateReport.Data)

                If GetDsRc(DS2) > 0 Then
                    For i = 0 To GetDsRc(DS2) - 1
                        Vs1.ActiveSheet.ColumnHeader.Cells(0, GetDsData(DS2, i, 0), 1, GetDsData(DS2, i, 0)).BackColor = FUNCTION_BACKCOLOR_SHEET(GetDsData(DS2, i, 1))
                        Vs1.ActiveSheet.ColumnHeader.Cells(0, GetDsData(DS2, i, 0), 1, GetDsData(DS2, i, 0)).ForeColor = FUNCTION_BACKCOLOR_SHEET(GetDsData(DS2, i, 2))
                    Next

                    DS2 = PrcDS("USP_SPFP87002_SEARCH_BACKCOLOR_ROWHEADER", cn, txt_DateReport.Data)

                    Vs1.Select()
                    Vs1.ActiveSheet.Rows(0).Font = New Font("Tahoma", CSng(GetDsData(DS2, 0, 3)), FontStyle.Bold)
                    Vs1.ActiveSheet.Rows(0).Visible = True
                    Vs1.ActiveSheet.ColumnHeader.Rows(-1).Font = New Font("Tahoma", CSng(GetDsData(DS2, 0, 3)), FontStyle.Bold)
                    Vs1.ActiveSheet.Rows(0).BackColor = FUNCTION_BACKCOLOR_SHEET(GetDsData(DS2, 0, 1))
                    Vs1.ActiveSheet.Rows(0).ForeColor = FUNCTION_BACKCOLOR_SHEET(GetDsData(DS2, 0, 2))

                End If


                For i = 0 To Vs1.ActiveSheet.RowCount - 1
                    For j = 0 To Vs1.ActiveSheet.ColumnCount - 4

                        If getColumName(Vs1, j).ToUpper.Contains("QTY") Then
                            If CDecp(getData(Vs1, j, i)) = 0 And getData(Vs1, j - 1, i) <> "" Then
                                If Vs1.ActiveSheet.Cells(i, j).BackColor <> Color.Red Then
                                    SPR_BACKCOLORCELL(Vs1, Color.Red, j, i)
                                Else
                                    SPR_BACKCOLORCELL(Vs1, Color.Empty, j, i)
                                End If

                            End If
                        End If

                    Next
                Next

            End If

        Catch ex As Exception

        End Try


    End Sub
End Class