Imports System.Data.SqlClient
Imports System.Resources
Module M_ERPMODULE

#Region "Variable"

#End Region

#Region "Methods"
    Public Function SendTab(ByVal KeyCode As Keys) As Boolean

        Select Case KeyCode

            Case Keys.Return, Keys.F1, Keys.Tab, Keys.Enter

                System.Windows.Forms.SendKeys.Send("{TAB}")

                Return True

            Case Keys.ShiftKey + Keys.Tab

                System.Windows.Forms.SendKeys.Send("+{TAB}")

                Return True

            Case Else

                Return False

        End Select

    End Function
    Public Sub keypresserp(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Public Function docbang(ByVal lenh As String) As DataTable
        On Error Resume Next
        kndl()
        Dim bang As New DataTable()
        Dim bodocghi As New SqlDataAdapter(lenh, cn)
        bodocghi.FillSchema(bang, SchemaType.Source)
        bodocghi.Fill(bang)
        Return bang
    End Function

    'Public Sub TOOLBAR_CHECKSHOW(TOOLBAR As ToolStrip, _
    '                                    button1 As Boolean, button2 As Boolean, button3 As Boolean, _
    '                                    button4 As Boolean, button5 As Boolean, button6 As Boolean, _
    '                                    Optional name1 As String = "", Optional name2 As String = "", Optional name3 As String = "", _
    '                                    Optional name4 As String = "", Optional name5 As String = "", Optional name6 As String = "")
    '    Try
    '        TOOLBAR.Items(0).Visible = button1
    '        TOOLBAR.Items(1).Visible = button1
    '        TOOLBAR.Items(2).Visible = button2
    '        TOOLBAR.Items(3).Visible = button2
    '        TOOLBAR.Items(4).Visible = button3
    '        TOOLBAR.Items(5).Visible = button3
    '        TOOLBAR.Items(6).Visible = button4
    '        TOOLBAR.Items(7).Visible = button4
    '        TOOLBAR.Items(8).Visible = button5
    '        TOOLBAR.Items(9).Visible = button5
    '        TOOLBAR.Items(10).Visible = button6
    '        TOOLBAR.Items(11).Visible = button6
    '        If button1 = True And name1 = "" Then TOOLBAR.Items(0).Text = "INSERT(F5)"
    '        If button2 = True And name2 = "" Then TOOLBAR.Items(2).Text = "SEARCH(F6)"
    '        If button3 = True And name3 = "" Then TOOLBAR.Items(4).Text = "UPDATE(F7)"
    '        If button4 = True And name4 = "" Then TOOLBAR.Items(6).Text = "DELETE(F8)"
    '        If button5 = True And name5 = "" Then TOOLBAR.Items(8).Text = "PRINT(F9)"
    '        If button6 = True And name6 = "" Then TOOLBAR.Items(10).Text = "WORK(F10)"
    '        If name1 <> "" Then TOOLBAR.Items(0).Text = name1
    '        If name2 <> "" Then TOOLBAR.Items(2).Text = name2
    '        If name3 <> "" Then TOOLBAR.Items(4).Text = name3
    '        If name4 <> "" Then TOOLBAR.Items(6).Text = name4
    '        If name5 <> "" Then TOOLBAR.Items(8).Text = name5
    '        If name6 <> "" Then TOOLBAR.Items(10).Text = name6

    '    Catch ex As Exception

    '    End Try

    'End Sub
    Public Sub TOOLBAR_CHECKSHOW(TOOLBAR As ToolStrip, _
                                      button1 As Boolean, button2 As Boolean, button3 As Boolean, _
                                      button4 As Boolean, button5 As Boolean, button6 As Boolean, _
                                      Optional name1 As String = "", Optional name2 As String = "", Optional name3 As String = "", _
                                      Optional name4 As String = "", Optional name5 As String = "", Optional name6 As String = "")
        Try
            TOOLBAR.Items("tst_1").Visible = button1
            TOOLBAR.Items("ToolStripSeparator2").Visible = button1
            TOOLBAR.Items("tst_2").Visible = button2
            TOOLBAR.Items("ToolStripSeparator4").Visible = button2
            TOOLBAR.Items("tst_3").Visible = button3
            TOOLBAR.Items("ToolStripSeparator3").Visible = button3
            TOOLBAR.Items("tst_4").Visible = button4
            TOOLBAR.Items("ToolStripSeparator5").Visible = button4
            TOOLBAR.Items("tst_5").Visible = button5
            TOOLBAR.Items("ToolStripSeparator6").Visible = button5
            TOOLBAR.Items("tst_6").Visible = button6
            TOOLBAR.Items("ToolStripSeparator1").Visible = button6

            If button1 = True And name1 = "" Then TOOLBAR.Items("tst_1").Text = "INSERT(F5)"
            If button2 = True And name2 = "" Then TOOLBAR.Items("tst_2").Text = "SEARCH(F6)"
            If button3 = True And name3 = "" Then TOOLBAR.Items("tst_3").Text = "UPDATE(F7)"
            If button4 = True And name4 = "" Then TOOLBAR.Items("tst_4").Text = "DELETE(F8)"
            If button5 = True And name5 = "" Then TOOLBAR.Items("tst_5").Text = "PRINT(F9)"
            If button6 = True And name6 = "" Then TOOLBAR.Items("tst_6").Text = "WORK(F10)"
            If name1 <> "" Then TOOLBAR.Items("tst_1").Text = name1
            If name2 <> "" Then TOOLBAR.Items("tst_2").Text = name2
            If name3 <> "" Then TOOLBAR.Items("tst_3").Text = name3
            If name4 <> "" Then TOOLBAR.Items("tst_4").Text = name4
            If name5 <> "" Then TOOLBAR.Items("tst_5").Text = name5
            If name6 <> "" Then TOOLBAR.Items("tst_6").Text = name6

        Catch ex As Exception

        End Try

    End Sub

    Public Function GROUP_SETTING(FormName As String, ByRef CHK01 As String, ByRef CHK02 As String, ByRef CHK03 As String, ByRef CHK04 As String, ByRef CHK05 As String) As Boolean
        '  OLD Version Ver1.0
        'CHK01 = "1"
        'CHK02 = "1"
        'CHK03 = "1"
        'CHK04 = "1"
        'CHK05 = "1"

        'If Pub.NAM.ToUpper = "PSMADMIN" Then
        '    CHK01 = "1"
        '    CHK02 = "1"
        '    CHK03 = "1"
        '    CHK04 = "1"
        '    CHK05 = "1"
        'Else
        '    If READ_PFK9994(Pub.SITE, Pub.GRP, FormName) Then

        '        If D9994.AFTERPROG <> "" Then
        '            READ_PFK9993(Pub.SITE, Pub.GRP, FormName)

        '            If D9993.CHK01 = "1" Then CHK01 = "1" Else CHK01 = "2"
        '            If D9993.CHK02 = "1" Then CHK02 = "1" Else CHK02 = "2"
        '            If D9993.CHK03 = "1" Then CHK03 = "1" Else CHK03 = "2"
        '            If D9993.CHK04 = "1" Then CHK04 = "1" Else CHK04 = "2"
        '            If D9993.CHK05 = "1" Then CHK05 = "1" Else CHK05 = "2"
        '        End If

        '    End If

        'End If

        GROUP_SETTING = True
        Try

            CHK01 = "1"
            CHK02 = "1"
            CHK03 = "1"
            CHK04 = "1"
            CHK05 = "1"

            If Pub.NAM.ToUpper = "PSMADMIN" Then
                CHK01 = "1"
                CHK02 = "1"
                CHK03 = "1"
                CHK04 = "1"
                CHK05 = "1"
            Else

                If CIntp(Pub.VER) > 200 Then
                    If READ_PFK9985(Pub.SITE, Pub.SAW, "2", FormName) Then
                        If D9985.CHK01 = "1" Then CHK01 = "1" Else CHK01 = "2"
                        If D9985.CHK02 = "1" Then CHK02 = "1" Else CHK02 = "2"
                        If D9985.CHK03 = "1" Then CHK03 = "1" Else CHK03 = "2"
                        If D9985.CHK04 = "1" Then CHK04 = "1" Else CHK04 = "2"
                        If D9985.CHK05 = "1" Then CHK05 = "1" Else CHK05 = "2"

                        If CHK01 = "2" And CHK02 = "2" And CHK03 = "2" And CHK04 = "2" And CHK05 = "2" Then Exit Function
                    Else
                        Exit Function
                    End If

                Else
                    CHK01 = "1"
                    CHK02 = "1"
                    CHK03 = "1"
                    CHK04 = "1"
                    CHK05 = "1"
                End If
              
            End If

            GROUP_SETTING = True
        Catch ex As Exception

        End Try
    End Function
    Public Function GROUP_SETTING_VER2(FormName As String, ByRef CHK01 As String, ByRef CHK02 As String, ByRef CHK03 As String, ByRef CHK04 As String, ByRef CHK05 As String) As Boolean
        GROUP_SETTING_VER2 = False
        Try

            CHK01 = "1"
            CHK02 = "1"
            CHK03 = "1"
            CHK04 = "1"
            CHK05 = "1"

            If Pub.NAM.ToUpper = "PSMADMIN" Then
                CHK01 = "1"
                CHK02 = "1"
                CHK03 = "1"
                CHK04 = "1"
                CHK05 = "1"
            Else
                If READ_PFK9985(Pub.SITE, Pub.SAW, "2", FormName) Then
                    If D9985.CHK01 = "1" Then CHK01 = "1" Else CHK01 = "2"
                    If D9985.CHK02 = "1" Then CHK02 = "1" Else CHK02 = "2"
                    If D9985.CHK03 = "1" Then CHK03 = "1" Else CHK03 = "2"
                    If D9985.CHK04 = "1" Then CHK04 = "1" Else CHK04 = "2"
                    If D9985.CHK05 = "1" Then CHK05 = "1" Else CHK05 = "2"

                    If CHK01 = "2" And CHK02 = "2" And CHK03 = "2" And CHK04 = "2" And CHK05 = "2" Then Exit Function
                Else
                    Exit Function
                End If

            End If

            GROUP_SETTING_VER2 = True
        Catch ex As Exception

        End Try
    End Function
    Public Function Peace_MCT(ByVal mct As ContextMenuStrip, ByVal ParamArray Menu() As Object) As Boolean
        Dim i As Integer
        Peace_MCT = False
        Try
            For i = 0 To UBound(Menu)
                mct.Items.Add(Menu(i))
                '  AddHandler mct.Items(0).Click, AddressOf mctclick
            Next
            Peace_MCT = True
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Sub TAB_NAME(tab As PeaceTabControl, ParamArray name() As String)
        Dim i As Integer
        For i = 0 To UBound(name)
            tab.TabPages(i).Text = name(i)
        Next
    End Sub

    Public Sub HISTORY_DATA(FLNO As String, tmpSQL As String, ISUD As String)
        If FLNO = "1111" Then GoTo Start
        If FLNO = "1112" Then GoTo Start
        If FLNO = "1114" Then GoTo Start
        If FLNO = "1115" Then GoTo Start
        If FLNO = "1116" Then GoTo Start
        If FLNO = "1117" Then GoTo Start
        If FLNO = "1131" Then GoTo Start
        If FLNO = "1145" Then GoTo Start
        If FLNO = "1291" Then GoTo Start
        If FLNO = "1314" Then GoTo Start
        If FLNO = "1331" Then GoTo Start
        If FLNO = "1332" Then GoTo Start
        If FLNO = "1333" Then GoTo Start
        If FLNO = "1334" Then GoTo Start
        If FLNO = "1338" Then GoTo Start
        If FLNO = "1345" Then GoTo Start
        If FLNO = "1346" Then GoTo Start
        If FLNO = "1351" Then GoTo Start
        If FLNO = "7411" Then GoTo Start
        If FLNO = "4471" Then GoTo Start
        If FLNO = "6334" Then GoTo Start
        If FLNO = "7101" Then GoTo Start
        If FLNO = "7107" Then GoTo Start
        If FLNO = "7108" Then GoTo Start
        If FLNO = "7109" Then GoTo Start
        If FLNO = "7111" Then GoTo Start
        If FLNO = "7121" Then GoTo Start
        If FLNO = "7171" Then GoTo Start

        Exit Sub

Start:
        'sau
        '  Call D9955_CLEAR()

restart:
        'D9955.KEYNO = GET_DTTM

        'If READ_PFK9955(D9955.KEYNO) = True Then GoTo restart

        'D9955.ISUD = ISUD
        'D9955.USERID = Pub.SAW
        'D9955.USERIP = Pub.IPS
        'D9955.FLNO = FLNO

        'D9955.FDATA = Replace(tmpSQL, Chr(39), Chr(34))

        'D9955.SEND = "1"

        'Call WRITE_PFK9955(D9955)

    End Sub
#End Region


End Module

