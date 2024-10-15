Imports System.Windows.Forms
Imports System.Resources
Imports System.Reflection
Imports DevExpress.XtraTab
Imports System.Net
Imports System.IO
Imports System.Threading
Imports System.Web

Public Class MdiMenu

#Region "Variable"

    Private TIMER_CHK As Integer
    Private fullscreen As Boolean = False
    Private PG_CNT(0 To 2) As Integer
    Private OSVER As String
    Private L9992 As T9992_AREA

    Const MF_BYPOSITION As Long = &H400&
    Const MF_MENUBARBREAK As Long = &H20&
    Const MF_MENUBREAK As Long = &H40&
    Const SM_CYFULLSCREEN As Long = 17&
    Const SM_CYMENU As Long = 15&

    Dim menuheight As Integer
    Dim breakpoint As Integer
    Dim menuhWnd As Long
    Dim submenuhWnd As Long
    Dim thread As System.Threading.Thread

    'OS VERSION
    Private Declare Function GetVersionEx Lib "kernel32" Alias "GetVersionExA" _
                             (lpVersionInformation As OSVERSIONINFO) As Long

    Private Structure OSVERSIONINFO
        Public dwOSVersionInfoSize As Long
        Public dwMajorVersion As Long
        Public dwMinorVersion As Long
        Public dwBuildNumber As Long
        Public dwPlatformId As Long
        Public szCSDVersion As String
    End Structure


    Private Declare Function GetMenu& Lib "user32" (ByVal hwnd&)
    Private Declare Function GetSubMenu& Lib "user32" (ByVal hMenu&, ByVal nPos&)
    Private Declare Function GetMenuItemID& Lib "user32" (ByVal hMenu&, ByVal nPos&)
    Private Declare Function ModifyMenu& Lib "user32" Alias "ModifyMenuA" (ByVal hMenu&, _
                            ByVal nPosition&, ByVal wFlags&, ByVal wIDNewItem&, ByVal lpString$)
    Private Declare Function GetSystemMetrics& Lib "user32" (ByVal nIndex&)

    Private formA As Boolean = False

    Private chk_ItemAdd_PFP83000 As Boolean = False
    Private chk_ItemAdd_PFP84000 As Boolean = False
    Private chk_ItemAdd_PFP85000 As Boolean = False
#End Region

#Region "Form_load"
    Private Sub MdiMenuormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        IPCheck()
        If cn IsNot Nothing Then
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End If
    End Sub
    Private Function CheckMenu() As Boolean
        CheckMenu = False
        Dim i As Integer = 0

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf CheckMenu))
        Else
            L9992 = D9992

            If FormatCut(Pub.GRP) <> "" Then
                If Pub.ADMCHK <> "1" Then
                    Dim Children As New List(Of ToolStripMenuItem)

                    Children = MenuStrip1.FindAllToolStripMenuItem()

                    For i = 0 To Children.Count - 1
                        If READ_PFK9994("001", Pub.GRP, Trim(Children(i).Name)) = True Then
                            If D9994.PCHK = "1" Then
                                Children(i).Visible = True
                                Children(i).Enabled = True
                            Else
                                Children(i).Enabled = False
                                Children(i).Visible = False
                            End If
                        Else
                            Children(i).Enabled = False
                            Children(i).Visible = False
                        End If

                        If Strings.Left(Children(i).Name, 1) = "P" Then
                            AddHandler Children(i).Click, AddressOf MenuClick

                        End If

                    Next
                Else
                    Dim Children As New List(Of ToolStripMenuItem)

                    Children = MenuStrip1.FindAllToolStripMenuItem()

                    For i = 0 To Children.Count - 1
                        If Children(i).Name = "" Then GoTo NEXT21
                        If Strings.Left(Children(i).Name, 1) = "P" Then
                            AddHandler Children(i).Click, AddressOf MenuClick
                        End If
next21:
                    Next


                End If
            Else
                If Pub.ADMCHK <> "1" And CIntp(Pub.VER) > 0 Then
                    Dim Children As New List(Of ToolStripMenuItem)

                    Children = MenuStrip1.FindAllToolStripMenuItem()

                    For i = 0 To Children.Count - 1
                        If READ_PFK9985(Pub.SITE, Pub.SAW, "1", Trim(Children(i).Name)) = True Then
                            If D9985.PCHK = "1" Then
                                Children(i).Visible = True
                                Children(i).Enabled = True
                            Else
                                Children(i).Enabled = False
                                Children(i).Visible = False
                            End If
                        Else
                            Children(i).Enabled = False
                            Children(i).Visible = False
                        End If

                        If Strings.Left(Children(i).Name, 1) = "P" Then
                            AddHandler Children(i).Click, AddressOf MenuClick

                        End If

                    Next
                Else
                    Dim Children As New List(Of ToolStripMenuItem)

                    Children = MenuStrip1.FindAllToolStripMenuItem()

                    For i = 0 To Children.Count - 1
                        If Children(i).Name = "" Then GoTo NEXT2
                        If Strings.Left(Children(i).Name, 1) = "P" Then
                            AddHandler Children(i).Click, AddressOf MenuClick
                        End If
next2:
                    Next


                End If
            End If
         

            Dim OSInfo As OSVERSIONINFO
            OSVER = OSInfo.dwPlatformId

        End If
    End Function

    Private list_suggestions As New AutoCompleteStringCollection

    Public Sub LoadSearch()
      
    End Sub

    Private Sub MDMENU_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim Starting As Object
        Try


            Me.SuspendLayout()

            Dim NewFrom As Etc_login

            NewFrom = New Etc_login

            NewFrom.ShowDialog()

            Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

            If CheckConnect = False Then APP_EXIT(True) : Exit Sub

            Call LoadBackground()
            Call ListMenu()
            Call OpenMenu()

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

            Dim thread = New System.Threading.Thread(AddressOf CheckMenu)
            thread.start()

            'Me.Text = Me.Text & "- MIP: " & "-" & Pub.SER & "- VERSION: " & VERNEW & " VER - " & Pub.VER

            If READ_PFK7171(ListCode("Site"), Pub.SITE) Then
                Me.lbl_Status2.Text = D7171.BasicName
                Pub.SITENAME = D7171.BasicName
                Me.cmb_Com.Text = Pub.SITENAME
            End If

            If READ_PFK7171(ListCode("WarningBlock"), 600) Then
                chk_TradingExportColor = True
            End If

            If Pub.SITE = "001" Then cmd_Com1.Checked = True
            If Pub.SITE = "002" Then cmd_Com2.Checked = True
            If Pub.SITE = "003" Then cmd_Com3.Checked = True

            If Pub.SITE <> "001" Then
                cmb_Com.Visible = False
            End If

            Me.lbl_Status3.Text = GetIPAddress()

            Me.lbl_Status4.Text = Pub.SAW & "/" & Pub.NAM
            Me.lbl_Status5.Text = Pub.DBS
            Me.lbl_Status6.Text = FSDateHour(System_Date_time())

            If Me.M20001.Checked = False Then Call Me.MenuStrip1.MDI_Tran()

            Me.Refresh()

            Me.ResumeLayout(True)
            Me.WindowState = FormWindowState.Maximized

            Call LoadSearch()

            Tim_02.Interval = 1000
            Tim_02.Start()

            If Pub.DEVCHK = "1" Then
                Dim str As String = MsgBoxP("Do you want to Save it?", vbYesNo)

                If str <> vbYes Then Exit Sub

                '''''''''''''''''''''''''
                Dim myAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                Dim types As Type() = myAssembly.GetTypes()

                For i As Integer = 0 To types.Length - 1

                    Try
                        If types(i).Name.Contains("ISUD") = True Then

                            Dim ProjAndForm = "PSMGlobal." & types(i).Name
                            Dim objType As Type = Type.[GetType](ProjAndForm) '

                            Try
                                Dim objForm As Form = DirectCast(Activator.CreateInstance(objType), Form)

                                If READ_PFK9981("001", "2", objForm.Name) = False Then
                                    D9981.SITE = "001"
                                    D9981.SEL = "2"
                                    D9981.PROG = objForm.Name
                                    D9981.NAME = objForm.Text
                                    D9981.NAME1 = objForm.Text
                                    D9981.NAME2 = objForm.Text
                                    D9981.REMARK = ""

                                    Call WRITE_PFK9981(D9981)
                                Else
                                    D9981.SITE = "001"
                                    D9981.SEL = "2"
                                    D9981.PROG = objForm.Name
                                    D9981.NAME = objForm.Text
                                    D9981.NAME1 = objForm.Text
                                    D9981.NAME2 = objForm.Text
                                    D9981.REMARK = ""

                                    Call REWRITE_PFK9981(D9981)
                                End If
                            Catch ex As Exception

                            End Try

                        End If
                    Catch ex As Exception

                    End Try

                Next

            End If

            '''''''''''''''''''''''''
            Me.Text = Me.Text & " - [" & VERNEW & "] - " & VERCONTEN

        Catch ex As Exception

        Finally
            Starting.close()
        End Try
    End Sub
#End Region

#Region "Function"
    Private Sub ListMenu()
        Try
            SQL = " SELECT K7171_BasicCode AS CODE, ISNULL(K7171_NameHLPButton,'') as  NAME FROM PFK7171 "
            SQL = SQL & " WHERE K7171_BasicSel = '000' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            DS1 = PrcDS(cmd, cn)

            For Each RS01 As DataRow In DS1.Tables(0).Rows
                ListCons.Add(New ListConstant With {.Code = RS01!CODE, .Name = RS01!NAME.ToString.ToUpper})
            Next

        Catch ex As Exception

        Finally
            DS1 = Nothing
        End Try

    End Sub
    Private Sub IPCheck()
        If cn Is Nothing Then Exit Sub
        If READ_PFK9992(Pub.SITE, Pub.SAW) = True Then
            L9992 = D9992
            L9992.IP = ""
            REWRITE_PFK9992(L9992)
        End If

    End Sub

    Private Sub menu_Translator()
        Dim i1, j1 As Integer
        'test multi
        Dim bbb As New ToolStripMenuItem
        For i1 = 0 To Me.MenuStrip1.Items.Count - 1
            If Me.MenuStrip1.Items(i1).Name <> "" Then
                bbb = Me.MenuStrip1.Items(i1)
                For j1 = 0 To bbb.DropDownItems.Count - 1
                    If bbb.DropDownItems(j1).Text.Length <> 0 Then
                        If IsDBNull(manager.GetString(bbb.DropDownItems(j1).Name)) = False Then
                            If manager.GetString(bbb.DropDownItems(j1).Name) <> "" Then
                                bbb.DropDownItems(j1).Text = manager.GetString(bbb.DropDownItems(j1).Name)
                            End If
                        End If
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub translate_formopen()
        'Dim frm As Form

        'For Each frm In My.Application.OpenForms
        '    Dim oList As List(Of Control) = frm.FindAllChildren()
        '    Dim i As Integer
        '    For i = 0 To oList.Count - 1
        '        If IsDBNull(manager.GetString(oList(i).Name.ToLower)) = False Then
        '            If TypeOf oList(i) Is FarPoint.Win.Spread.FpSpread Then
        '                SheetTranslate(oList(i))
        '            End If
        '            Dim str As String
        '            str = oList(i).Name.ToLower
        '            If manager.GetString(str) <> "" Then
        '                oList(i).Text = manager.GetString(str)
        '            End If
        '        End If
        '    Next
        '    oList.Clear()
        'Next
    End Sub

    Private Function CheckExists(TabControlName As XtraTabControl, TabName As String) As Integer
        Dim temp As Integer = -1
        For i As Integer = 0 To TabControlName.TabPages.Count - 1
            If TabControlName.TabPages(i).Text = TabName Then
                temp = i
                Exit For
            End If
        Next
        Return temp
    End Function

    Private Function CheckExists_FormName(TabControlName As XtraTabControl, TabName As String) As Integer
        Dim temp As Integer = -1
        For i As Integer = 0 To TabControlName.TabPages.Count - 1
            If TabControlName.TabPages(i).Text = TabName Then
                temp = i
                Exit For
            End If
        Next
        Return temp
    End Function

    Private Sub OpenMenu()
        Dim Starting = New DevExpress.Utils.WaitDialogForm("Loading history form!", "PSM")
        Dim i As Integer = 0

        Try
            If System.IO.File.Exists(App_Path & "\UserDesigner\" & Me.Name & ".txt") = True Then
                Dim wrt As System.IO.StreamReader
                Dim Value() As String

                wrt = My.Computer.FileSystem.OpenTextFileReader(App_Path & "\UserDesigner\" & Me.Name & ".txt")
                Value = wrt.ReadLine.Split("-")

                If Value(0) = "" Then Exit Sub

                wrt.Close()

                For i = 0 To Value.Length - 1
                    Dim f As New PeaceForm
                    Dim FullTypeName As String
                    If Value(i).Length >= 8 Then FullTypeName = "PSMGlobal" & "." & Strings.Left(Value(i), 8)
                    Dim objType As Type = Type.[GetType](FullTypeName)
                    f = DirectCast(Activator.CreateInstance(objType), PeaceForm)
                    f.PeaceFormType = ""
                    f.PeaceReportName = f.Text
                    If Value(i).Length > 8 Then f.PeaceFormType = Mid(Value(i), 9)

                    If Me.M20001.Checked = False Then Form_Translate(f)

                    Me.TabCreating(xTabMain, f.Text & " " & f.PeaceFormType, f, f.PeaceFormType)
                Next
            End If

        Catch ex As Exception

        Finally
            Starting.Close()
        End Try

    End Sub

    Public Sub TabCreating(TabControl As XtraTabControl, Text As String, Form As PeaceForm, FormType As String)
        Dim Index As Integer = Me.CheckExists(TabControl, Text)

        If Index < 0 Then Index = Me.CheckExists(TabControl, Form.Name & "-" & Form.PeaceReportName)

        If Index >= 0 Then
            TabControl.SelectedTabPage = TabControl.TabPages(Index)
            TabControl.SelectedTabPage.Text = Text
            TabControl.SelectedTabPage.Tag = Form.Name

            If Form.Name.Contains("PFP8") Then
                TabControl.SelectedTabPage.Text = Form.Name & "-" & Form.PeaceReportName
            End If

        Else
            Dim TabPage As New XtraTabPage()
            TabPage.Text = Form.PeaceReportName & "-(" & Form.Name & ")"
            TabPage.Tag = Form.Name

            If Form.Name.Contains("PFP8") Then
                TabPage.Text = Form.Name & "-" & Form.PeaceReportName
            End If

            TabPage.AutoScroll = True
            TabControl.TabPages.Add(TabPage)
            TabControl.SelectedTabPage = TabPage
            TabControl.AppearancePage.HeaderActive.Font = New Font(TabControl.AppearancePage.HeaderActive.Font, FontStyle.Bold)
            Form.TopLevel = False
            Form.Parent = TabPage
            Form.Dock = DockStyle.Fill
            Form.FormBorderStyle = Windows.Forms.FormBorderStyle.None

            Form.Show()
        End If
    End Sub

    Private Sub KillPro()
        Try
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName = "ERP_PSM" Then
                    prog.Kill()
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadBackground()
        Try
            If Screen.PrimaryScreen.Bounds.Height >= 1080 Then
                Me.BackgroundImage = Global.PSMGlobal.My.Resources.Resources.bg1
                Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            ElseIf Screen.PrimaryScreen.Bounds.Height >= 720 Then
                Me.BackgroundImage = Global.PSMGlobal.My.Resources.Resources.bg1
                Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Else
                Me.BackgroundImage = Global.PSMGlobal.My.Resources.Resources.bg1
                Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            End If

        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Event"
    Private Sub SPFP_Click(sender As Object, e As EventArgs)
        Try
            Dim c, d As Form
            Dim FullTypeName As String
            If (TypeOf (sender) Is ToolStripMenuItem) = False Then Exit Sub
            FullTypeName = "PSMGlobal" & "." & sender.name

            For Each d In My.Application.OpenForms
                If d.Name = sender.Name Then
                    d.Activate()
                    d.BringToFront()
                    Exit Sub
                End If
            Next

            Dim objType As Type = Type.[GetType](FullTypeName)
            c = DirectCast(Activator.CreateInstance(objType), Form)
            c.SuspendLayout()
            c.Show()
            c.StartPosition = FormStartPosition.CenterScreen
            c.BringToFront()
            c.ResumeLayout()

            If Me.M20001.Checked = False Then Form_Translate(c)
            c.Focus()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub MenuClick(sender As Object, e As EventArgs)
        Dim Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")
        Try
            Dim f As PeaceForm
            Dim FullTypeName As String
            If (TypeOf (sender) Is ToolStripMenuItem) = False Then Exit Sub

            If sender.name.Length >= 8 Then FullTypeName = "PSMGlobal" & "." & Strings.Left(sender.name, 8)


            If READ_PFK9970(Pub.SITE, Strings.Left(sender.name, 8)) Then
                FullTypeName = "PSMGlobal" & "." & D9970.ProgramFix

            End If

            Dim objType As Type = Type.[GetType](FullTypeName)
            f = DirectCast(Activator.CreateInstance(objType), PeaceForm)

            If sender.name.Length > 8 Then f.PeaceFormType = Mid(sender.Name, 9)

            If Me.M20001.Checked = False Then Form_Translate(f)
            f.PeaceReportName = sender.Text
            f.strFormOriginName = Strings.Left(sender.name, 8)

            If chk_PLM = True Then
                f.Show()
                f.Select()
                Exit Sub
            End If

            Me.TabCreating(xTabMain, f.Text & " " & f.PeaceFormType, f, f.PeaceFormType)

        Catch ex As Exception

        Finally
            Starting.close()
        End Try
    End Sub
    Private Sub ENGLISHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles M20001.Click
        M20001.Checked = True

        If M20001.Checked = True Then
            Pub.NAT = "0"
            M20002.Checked = False
            Call Me.MenuStrip1.MDI_Tran()
        End If
    End Sub

    Private Sub VIETNAMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles M20002.Click
        M20002.Checked = True
        If M20002.Checked = True Then
            Pub.NAT = "1"
            M20001.Checked = False
            Call Me.MenuStrip1.MDI_Tran()
        End If
    End Sub
    Private Sub N01001_Click(sender As Object, e As EventArgs) Handles N01001.Click
        Me.Dispose()
    End Sub
    Private Sub CASCADEVIEWToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub
    Private Sub SIDEVIEWToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
    Private Sub STACKVIEWToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
    Private Sub ICONVIEWToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub
    Private Sub DATABASEBACKUPToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim f As Form
        f = New BackUpDB
        f.Show()

    End Sub
    Private Sub Mdimenu_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Refresh()
    End Sub
    Private Sub xTabMain_CloseButtonClick(sender As Object, e As EventArgs) Handles xTabMain.CloseButtonClick
        Try
            Dim xtab As DevExpress.XtraTab.XtraTabControl = DirectCast(sender, DevExpress.XtraTab.XtraTabControl)
            If xtab.TabPages.Count = 1 Then
                Return
            End If
            Dim i As Integer = xtab.SelectedTabPageIndex

            xtab.SelectedTabPage.Controls.Clear()

            xtab.TabPages.RemoveAt(xtab.SelectedTabPageIndex)
            xtab.SelectedTabPageIndex = i - 1
        Catch
        End Try
    End Sub
    Private Sub xTabMain_MouseClick(sender As Object, e As MouseEventArgs) Handles xTabMain.MouseClick
        Try
            Select Case e.Button
                Case Windows.Forms.MouseButtons.Middle
                    Dim xtab As DevExpress.XtraTab.XtraTabControl = DirectCast(sender, DevExpress.XtraTab.XtraTabControl)
                    If xtab.TabPages.Count = 1 Then
                        Return
                    End If
                    Dim i As Integer = xtab.SelectedTabPageIndex

                    xtab.SelectedTabPage.Controls.Clear()

                    xtab.TabPages.RemoveAt(xtab.SelectedTabPageIndex)
                    xtab.SelectedTabPageIndex = i - 1
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_SaveLayout_Click(sender As Object, e As EventArgs) Handles cmd_SaveLayout.Click
        Try
            Dim StrMsg As String = MsgBox("Do you want to save desiger!", vbYesNo)
            If StrMsg = vbYes Then
                If (Not System.IO.Directory.Exists(App_Path & "\UserDesigner")) Then
                    System.IO.Directory.CreateDirectory(App_Path & "\UserDesigner")
                End If

                If System.IO.File.Exists(App_Path & "\UserDesigner\" & Me.Name & ".txt") = False Then
                    System.IO.File.Create(App_Path & "\UserDesigner\" & Me.Name & ".txt").Dispose()

                End If

                Dim objWriter As New System.IO.StreamWriter(App_Path & "\UserDesigner\" & Me.Name & ".txt", False)
                Dim ValueStr As String

                For Each f As PeaceForm In Application.OpenForms
                    If TypeOf (f.Parent) Is XtraTabPage Then ValueStr &= "-" & f.Name

                Next

                ValueStr = Strings.Right(ValueStr, Len(ValueStr) - 1)

                objWriter.WriteLine(ValueStr)
                objWriter.Close()
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmd_ClearLayout_Click(sender As Object, e As EventArgs) Handles cmd_ClearLayout.Click
        Try
            If System.IO.File.Exists(App_Path & "\UserDesigner\" & Me.Name & ".txt") = False Then
                System.IO.File.Create(App_Path & "\UserDesigner\" & Me.Name & ".txt").Dispose()

            End If

            Dim objWriter As New System.IO.StreamWriter(App_Path & "\UserDesigner\" & Me.Name & ".txt", False)

            objWriter.WriteLine("")
            objWriter.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub WEBSITE_Click(sender As Object, e As EventArgs)
        Try
            Dim strLink As String

            strLink = "http://" & Pub.SSER & ":9999/Dashboard"

            Process.Start(strLink)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ISUDU_Click(sender As Object, e As EventArgs) Handles ISUDU.Click
        Try
            Dim MsgStr As String = MsgBox("Do you want to re-version?", vbYesNo)
            If vbNo = MsgStr Then Exit Sub

            Dim srw As System.IO.StreamWriter
            srw = My.Computer.FileSystem.OpenTextFileWriter(App_Path & "\version.txt", False)
            srw.Write(0)
            srw.Close()

            Process.Start(App_Path & "\" & "PSM_UPDATE.exe")
            Call KillPro()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub Tim_01_Tick(sender As Object, e As EventArgs) Handles Tim_01.Tick
        Try
            lbl_Status6.Text = FSDateHour(System_Date_time)
        Catch ex As Exception

        End Try
    End Sub
    Private chkFormEB As Boolean = False
    Private chkConnection As Boolean = True
    Private cntConnection As Integer = 0
    Private Sub Tim_02_Tick(sender As Object, e As EventArgs) Handles Tim_02.Tick
        'Exit Sub

        Try
            Dim IPAddress As String
            Dim SendPing As New Net.NetworkInformation.Ping
            Dim Result As Net.NetworkInformation.PingReply

            IPAddress = Pub.SER.Split(",")(0)
            'Result = SendPing.Send(IPAddress)


            Dim hostname As String = IPAddress
            Dim portno As Integer

            If Pub.SER.Split(",").Length > 1 Then portno = Pub.SER.Split(",")(1)

            If ScanPort(hostname, portno) = False And hostname <> "127.0.0.1" Then
                If lbl_StatusOnOff.Text <> "Disconnected!" Then
                    chkConnection = False
                    Tim_01.Stop()
                    lbl_StatusOnOff.Text = "Disconnected!"
                    lbl_StatusOnOff.ForeColor = Color.Red
                    lbl_StatusOnOff.Image = My.Resources.MoveDown_16x16

                    Me.MenuStrip1.Enabled = False
                    mainPage.PageEnabled = False

                    If chkFormEB = False Then
                        Call FormED(False) : chkFormEB = True
                    End If


                End If

                Tim_02.Stop()
                Call kndl()
                Tim_02.Start()
            Else
                If lbl_StatusOnOff.Text <> "Connected!" Then
                    cntConnection = 0
                    chkConnection = True
                    Tim_01.Start()
                    lbl_StatusOnOff.Text = "Connected!"
                    lbl_StatusOnOff.ForeColor = Color.Blue
                    lbl_StatusOnOff.Image = My.Resources.MoveUp_16x16
                    Me.MenuStrip1.Enabled = True
                    mainPage.PageEnabled = True
                    If chkFormEB = True Then Call FormED(True) : chkFormEB = False
                End If
            End If

        Catch ex As Exception
            Tim_02.Start()
            chkConnection = False
            Me.MenuStrip1.Enabled = False
            mainPage.PageEnabled = False
            Tim_01.Stop()
            lbl_StatusOnOff.Text = "Disconnected!"
            lbl_StatusOnOff.ForeColor = Color.Red
            lbl_StatusOnOff.Image = My.Resources.MoveDown_16x16
            If chkFormEB = False Then Call FormED(False) : chkFormEB = True
        End Try
    End Sub

    Private Function ScanPort(hostname As String, portno As Integer) As Boolean
        ScanPort = False
        Try

            Dim ipa As IPAddress = DirectCast(Dns.GetHostAddresses(hostname)(0), IPAddress)
            Try
                Dim sock As New System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp)
                sock.Connect(ipa, portno)
                If sock.Connected = True Then
                    ScanPort = True
                Else
                    ScanPort = False
                End If

                sock.Close()
            Catch ex As System.Net.Sockets.SocketException
                ScanPort = False
            End Try

        Catch ex As Exception

        End Try
    End Function

    Private Sub FormED(checkState As Boolean)
        Try
            For Each frm As Form In My.Application.OpenForms
                If frm.Name <> "MdiMenu" Then frm.Enabled = checkState
            Next

        Catch ex As Exception

        End Try

    End Sub


    Private Sub cmd_Com1_Click(sender As Object, e As EventArgs) Handles cmd_Com1.Click
        cmd_Com1.Checked = True
        cmd_Com2.Checked = False
        cmd_Com3.Checked = False

    End Sub


    Private Sub cmd_Com2_Click(sender As Object, e As EventArgs) Handles cmd_Com2.Click
        cmd_Com1.Checked = False
        cmd_Com2.Checked = True
        cmd_Com3.Checked = False

    End Sub

    Private Sub cmd_Com3_Click(sender As Object, e As EventArgs) Handles cmd_Com3.Click
        cmd_Com1.Checked = False
        cmd_Com2.Checked = False
        cmd_Com3.Checked = True

    End Sub


    Private Sub cmd_Com1_CheckedChanged(sender As Object, e As EventArgs) Handles cmd_Com1.CheckedChanged, cmd_Com2.CheckedChanged, cmd_Com3.CheckedChanged
        If cn Is Nothing Then Exit Sub

        If cmd_Com1.Checked Then
            Pub.SITE = "001"

        ElseIf cmd_Com2.Checked Then
            Pub.SITE = "002"

        ElseIf cmd_Com3.Checked Then
            Pub.SITE = "003"
        End If

        If READ_PFK7171(ListCode("Site"), Pub.SITE) Then
            Pub.SITENAME = D7171.BasicName
            Me.lbl_Status2.Text = D7171.BasicName
        End If

        Dim Starting As Object
        Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")
        Try


            Dim frm As PeaceForm
            For Each frm In My.Application.OpenForms
                If frm.FindCode("cdSite") IsNot Nothing Then
                    frm.FindCode("cdSite").Code = Pub.SITE
                    frm.FindCode("cdSite").Data = Pub.SITENAME

                End If

            Next

        Catch ex As Exception

        Finally
            Starting.close()
        End Try

    End Sub
 
    Private Sub ISUD1010A_Click(sender As Object, e As EventArgs)
        Try
            ISUD1001A_Android.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub


    Private Sub lbl_Status1_TextChanged(sender As Object, e As EventArgs) Handles lbl_Status1.TextChanged
        Try

            If cn Is Nothing Then Exit Sub

            Call READ_PFK7171(ListCode("WarningBlock"), 900)
            If D7171.NameSimply = "1" Then Exit Sub

            Tim_03.Interval = CDecp(D7171.CheckName1)

            If Tim_03.Interval < 1000 Then Tim_03.Interval = 1000


            If lbl_Status1.Text = "" Then
                Tim_03.Stop()

            Else
                Tim_03.Start()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tim_03_Tick(sender As Object, e As EventArgs) Handles Tim_03.Tick
        Try

            If lbl_Status1.Text <> "" Then
                lbl_Status1.Text = ""
                Tim_03.Stop()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ISUD0101U_Click(sender As Object, e As EventArgs) Handles ISUD0101U.Click
        Dim f As Form
        f = New ISUD0101U
        f.Show()
    End Sub

#End Region


  
End Class
