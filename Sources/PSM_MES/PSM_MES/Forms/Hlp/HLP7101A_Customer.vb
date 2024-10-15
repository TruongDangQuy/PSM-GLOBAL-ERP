Public Class HLP7101A_Customer

#Region "Variable"
    Public Structure KIEMTRA
        Public check1 As Integer
        Public check2 As Integer
        Public check3 As Integer
        Public check4 As Integer
        Public check5 As Integer
        Public check6 As Integer
    End Structure
    Public W1_Head As Integer

    Private W7101 As T7101_AREA
    Private W7171 As T7171_AREA
    Public HLP0001_KIEMTRA As KIEMTRA
#End Region

#Region "Form_Load"
    Public Function Link_HLP7101A_Customer(CustomerName As String) As Boolean
        W7101.CustomerName = CustomerName
        txt_CustomerName.Data = CustomerName
        hlpCHK = False

        If Pub.CUSCHK = "1" Then
            PeaceCheckbox2.Checked = False
            PeaceCheckbox3.Checked = False
            PeaceCheckbox4.Checked = False
            PeaceCheckbox5.Checked = False
            PeaceCheckbox6.Checked = False

            PeaceCheckbox2.Visible = False
            PeaceCheckbox3.Visible = False
            PeaceCheckbox4.Visible = False
            PeaceCheckbox5.Visible = False
            PeaceCheckbox6.Visible = False
        Else
            PeaceCheckbox2.Checked = True
            PeaceCheckbox3.Checked = True
            PeaceCheckbox4.Checked = True
            PeaceCheckbox5.Checked = True
            PeaceCheckbox6.Checked = True

            PeaceCheckbox2.Visible = True
            PeaceCheckbox3.Visible = True
            PeaceCheckbox4.Visible = True
            PeaceCheckbox5.Visible = True
            PeaceCheckbox6.Visible = True
        End If

        Me.ShowDialog()

        Link_HLP7101A_Customer = hlpCHK
    End Function

    Public Function Link_HLP7101B(Type As String) As Boolean
        hlpCHK = False

        PeaceCheckbox1.Checked = False
        PeaceCheckbox2.Checked = False
        PeaceCheckbox3.Checked = False
        PeaceCheckbox4.Checked = False
        PeaceCheckbox5.Checked = False
        PeaceCheckbox6.Checked = False

        If Type = "1" Then PeaceCheckbox1.Checked = True
        If Type = "2" Then PeaceCheckbox2.Checked = True
        If Type = "3" Then PeaceCheckbox3.Checked = True
        If Type = "4" Then PeaceCheckbox4.Checked = True
        If Type = "5" Then PeaceCheckbox5.Checked = True
        If Type = "6" Then PeaceCheckbox6.Checked = True

        Me.ShowDialog()

        Link_HLP7101B = hlpCHK
    End Function

    Public Function Link_HLP7101M(Type1 As String, Type2 As String, Type3 As String, Type4 As String, Type5 As String, Type6 As String) As Boolean
        hlpCHK = False

        PeaceCheckbox1.Checked = False
        PeaceCheckbox2.Checked = False
        PeaceCheckbox3.Checked = False
        PeaceCheckbox4.Checked = False
        PeaceCheckbox5.Checked = False
        PeaceCheckbox6.Checked = False

        If Type1 = "1" Then PeaceCheckbox1.Checked = True
        If Type2 = "1" Then PeaceCheckbox3.Checked = True
        If Type3 = "1" Then PeaceCheckbox2.Checked = True
        If Type4 = "1" Then PeaceCheckbox4.Checked = True
        If Type5 = "1" Then PeaceCheckbox5.Checked = True
        If Type6 = "1" Then PeaceCheckbox6.Checked = True

        Me.ShowDialog()

        Link_HLP7101M = hlpCHK
    End Function

    Public Overridable Sub HLP0001_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hlp0000SeVaTt = ""
        hlp0000SeVa = ""

        Me.Show()
        Application.DoEvents()
        Setfocus(txt_CustomerName)
    End Sub
#End Region

#Region "Methods"
    Public Function DATA_SEARCH01(Head_No As Long) As Boolean
        DATA_SEARCH01 = False
        hlp0000SeVaTt = ""
        hlp0000SeVa = ""

        Try
            If Pub.CUSCHK = "1" Then
                DS1 = PrcDS("USP_HLP7101A_SEARCH_VS1_CUSTOMER", cn, "*" & txt_CustomerName.PeaceTextbox1.Text.Trim, _
                                        Pub.SITE, Pub.SAW
                                      )
            Else
                DS1 = PrcDS("USP_HLP7101A_SEARCH_VS1", cn, "*" & txt_CustomerName.PeaceTextbox1.Text.Trim, _
                                          HLP0001_KIEMTRA.check1, HLP0001_KIEMTRA.check3, HLP0001_KIEMTRA.check5, _
                                          HLP0001_KIEMTRA.check2, HLP0001_KIEMTRA.check4, HLP0001_KIEMTRA.check6)
            End If

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_HLP7101A_SEARCH_VS1", "Vs1")
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_HLP7101A_SEARCH_VS1", "Vs1")
            DATA_SEARCH01 = True

            Me.Show()
            Application.DoEvents()
            Vs1.Focus()

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function
#End Region

#Region "Events"
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        Me.Close()
    End Sub

    Private Sub PeaceCheckbox1_CheckedChanged(sender As Object, e As EventArgs) Handles PeaceCheckbox1.CheckedChanged, _
        PeaceCheckbox2.CheckedChanged, PeaceCheckbox3.CheckedChanged, PeaceCheckbox4.CheckedChanged, PeaceCheckbox5.CheckedChanged, PeaceCheckbox6.CheckedChanged
        Select Case True
            Case sender Is PeaceCheckbox1
                If PeaceCheckbox1.Checked = True Then
                    HLP0001_KIEMTRA.check1 = 1
                Else
                    HLP0001_KIEMTRA.check1 = 0
                End If
            Case sender Is PeaceCheckbox2
                If PeaceCheckbox2.Checked = True Then
                    HLP0001_KIEMTRA.check2 = 1
                Else
                    HLP0001_KIEMTRA.check2 = 0
                End If
            Case sender Is PeaceCheckbox3
                If PeaceCheckbox3.Checked = True Then
                    HLP0001_KIEMTRA.check3 = 1
                Else
                    HLP0001_KIEMTRA.check3 = 0
                End If
            Case sender Is PeaceCheckbox4
                If PeaceCheckbox4.Checked = True Then
                    HLP0001_KIEMTRA.check4 = 1
                Else
                    HLP0001_KIEMTRA.check4 = 0
                End If
            Case sender Is PeaceCheckbox5
                If PeaceCheckbox5.Checked = True Then
                    HLP0001_KIEMTRA.check5 = 1
                Else
                    HLP0001_KIEMTRA.check5 = 0
                End If
            Case sender Is PeaceCheckbox6
                If PeaceCheckbox6.Checked = True Then
                    HLP0001_KIEMTRA.check6 = 1
                Else
                    HLP0001_KIEMTRA.check6 = 0
                End If
        End Select

    End Sub

    Private Sub SelectLabelSearch1_KeyDown(sender As Object, e As KeyPressEventArgs) Handles txt_CustomerName.txtTextKeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cmd_SEARCH.PerformClick()
        End If
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        DATA_SEARCH01(W1_Head)
    End Sub

    Public Overridable Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If getData(Vs1, getColumIndex(Vs1, "CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            hlpCHK = False
            Exit Sub
        Else
            hlp0000SeVaTt = getData(Vs1, getColumIndex(Vs1, "CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVa = getData(Vs1, getColumIndex(Vs1, "CustomerName"), Vs1.ActiveSheet.ActiveRowIndex)
            hlpCHK = True
        End If
        Me.Close()
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If e.Row < 0 Then Exit Sub
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If getData(Vs1, getColumIndex(Vs1, "CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex) Is Nothing Then
            MsgBoxP("NO VALUE !")
            hlpCHK = False
            Exit Sub
        Else
            hlp0000SeVaTt = getData(Vs1, getColumIndex(Vs1, "CustomerCode"), Vs1.ActiveSheet.ActiveRowIndex)
            hlp0000SeVa = getData(Vs1, getColumIndex(Vs1, "CustomerName"), Vs1.ActiveSheet.ActiveRowIndex)
            hlpCHK = True
        End If
        Me.Close()
    End Sub

    Private Sub Vs1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Vs1.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Enter), ChrW(Keys.Escape) : cmd_OK.PerformClick()

        End Select
    End Sub

    Private Sub cmd_Cancel_Click_1(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlpCHK = False
        Me.Close()
    End Sub

    Private Sub PeaceButton2_Click(sender As Object, e As EventArgs) Handles PeaceButton2.Click
        Call ISUD7101B.Link_ISUD7101A(1, "000000", "PFP70101")
    End Sub
#End Region
    
End Class