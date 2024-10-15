Imports System.Data.SqlClient
Imports System.IO
Imports System
Imports Microsoft.VisualBasic.FileIO
Imports System.Resources
Imports System.Net
Imports System.Web
Public Class Etc_login

#Region "Variable"
    Private L9992 As T9992_AREA
    Private forma As Boolean = False
    Private isud As Boolean = False

#End Region

#Region "Form_load"
    Private Sub Etc_login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim SVR_EXE As String = ""
            Call LoadControlLanguage()
            Call SetConnect()
            Call ID_READ()
            Call FORM_INIT()
            Call PW_READ()
            Call ReadInfor()

            Call Verchk()
            Call NATION_READ()
            L9992 = D9992


        Catch ex As Exception
            MsgBoxP("ERROR")
        End Try
    End Sub

#End Region

#Region "Functions"

    Private Sub PW_WRITE(CHK As Long)
        Try
            If CHK = 1 Then
                txt_PASS.Text = txt_PASS.Text
            Else
                txt_PASS.Text = ""

            End If
            My.Computer.FileSystem.WriteAllText(App_Path & "\PW.DAT", txt_PASS.Text, False)

        Catch ex As Exception

        End Try

    End Sub
    Private Sub NAT_WRITE()
        Try

            My.Computer.FileSystem.WriteAllText(App_Path & "\NAT.DAT", cmb_NATION.SelectedIndex, False)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub ID_WRITE()
        Try
            Dim i As Integer
            Dim tmpID As String
            Dim IDCHK As String = ""
            tmpID = cmb_ID.Text

            For i = 0 To cmb_ID.Items.Count - 1
                If cmb_ID.Items(i) = tmpID Then IDCHK = "x" : Exit For
            Next
            My.Computer.FileSystem.WriteAllText(App_Path & "\ID.DAT", "", False)

            Dim wrt As System.IO.StreamWriter
            wrt = My.Computer.FileSystem.OpenTextFileWriter(App_Path & "\ID.DAT", False)
            wrt.WriteLine(tmpID)
            For i = 0 To cmb_ID.Items.Count - 1
                If cmb_ID.Items(i) <> tmpID Then
                    wrt.WriteLine(cmb_ID.Items(i))
                End If
            Next
            wrt.Close()
        Catch ex As Exception

        End Try


    End Sub
    Private Sub Verchk()

    End Sub
    Private Sub IPCheck()
        Try
            If cn Is Nothing Then Exit Sub
            If READ_PFK9992(Pub.SITE, Pub.SAW) = True Then
                L9992 = D9992
                L9992.IP = GetIPAddress()
                REWRITE_PFK9992(L9992)
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub ReadInfor()
        Try
            txt_Infor.Text = ""
            Dim swrt As StreamReader
            swrt = FileSystem.OpenTextFileReader(App_Path & "\Infor.txt")

            txt_Infor.Text = swrt.ReadToEnd
            swrt.Dispose()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub PW_READ()
        Try
            Dim wrt As System.IO.StreamReader
            wrt = My.Computer.FileSystem.OpenTextFileReader(App_Path & "\PW.DAT")
            txt_PASS.Text = wrt.ReadLine
            wrt.Close()
            If txt_PASS.Text.Trim <> "" Then chk_PW.Checked = True Else chk_PW.Checked = False
        Catch ex As Exception
            Exit Sub
        End Try


    End Sub
    Private Sub NATION_READ()
        Try
            Dim Pos As String
            Dim wrt As System.IO.StreamReader
            wrt = My.Computer.FileSystem.OpenTextFileReader(App_Path & "\NAT.DAT")
            Pos = wrt.ReadLine
            cmb_NATION.SelectedIndex = CIntp(Pos)
            wrt.Close()
        Catch ex As Exception
            Exit Sub
        End Try


    End Sub
    Private Function VERSION_READ() As Boolean
        VERSION_READ = False
        'VERSION_READ = True
        'Exit Function
        Try
            Dim wrt As System.IO.StreamReader
            wrt = My.Computer.FileSystem.OpenTextFileReader(App_Path & "\version.txt")
            Pub.VER = wrt.ReadLine
            wrt.Close()

            Dim mostRecent As String
            Dim sr1 As System.IO.StreamReader
            Dim client As WebClient = New WebClient()

            str = "http://"
            str += Pub.SER.Replace(",", ":")
            str += "/CS_WHM/version.txt"

            sr1 = New StreamReader(client.OpenRead(str))
            mostRecent = sr1.ReadToEnd
            sr1.Close()
            Pub.VER = mostRecent
            If Pub.VER = mostRecent Then VERSION_READ = True

        Catch ex As Exception

        Finally

            Pub.VER = "1"
        End Try


    End Function
    Private Sub FORM_INIT()
        cmb_NATION.Items.Add("English")
        cmb_NATION.Items.Add("Vietnamese")
        'cmb_NATION.Items.Add("Korean")
        cmb_NATION.Text = cmb_NATION.Items(0).ToString

        cmb_FACT.Items.Add("PSM WHM FOR CHANG SHUEN")
        cmb_FACT.Text = cmb_FACT.Items(0).ToString
        cmb_FACT.Enabled = False

        cmb_FACT.Text = VERNEW & "-" & cmb_FACT.Text
        cmb_POS.DataSource = ListConnectSql
        cmb_POS.DisplayMember = "Name"
        cmb_POS.ValueMember = "ID"
        cmb_POS.SelectedIndex = cmb_POS.FindStringExact(DefaultsValue)
        cmb_SET.Items.Add("SQL")
        cmb_SET.Text = "SQL"
        cmb_SET.Enabled = False
        ' cmb_SET.Items.Count = 0

        Pub.SITE = "001"
        cmb_ID.Focus()

    End Sub
    Private Sub ID_READ()
        Try
            Dim wrt As System.IO.StreamReader
            wrt = My.Computer.FileSystem.OpenTextFileReader(App_Path & "\ID.DAT")
            Do While wrt.EndOfStream = False
                cmb_ID.Items.Add(wrt.ReadLine)
            Loop
            wrt.Close()
            cmb_ID.SelectedIndex = 0
        Catch ex As Exception

        End Try

    End Sub

    Private Sub LoadControlLanguage()
        If cmb_NATION.SelectedIndex.ToString() = "0" Then 'Tiếng Anh

            lbl_Login.Text = "Login"
            lbl_DoHaveAcount.Text = "Doesn't have an account yet?"
            lbl_ContactERPTeam.Text = "Contact ERPTeam"

            lbl_Username.Text = "Username"
            lbl_Password.Text = "Password"
            lbl_ChangePassword.Text = "Change password !"

            chk_ShowPassword.Text = "Show password"
            chk_PW.Text = "Remember Me"

            cmd_Login.Text = "Login"
            cmd_Close.Text = "Close"
        End If

        If cmb_NATION.SelectedIndex.ToString() = "1" Then 'Tiếng Việt

            lbl_Login.Text = "Đăng nhập"
            lbl_DoHaveAcount.Text = "Không có tài khoản đăng nhập?"
            lbl_ContactERPTeam.Text = "Liên hệ ERP Team"

            lbl_Username.Text = "Tài khoản"
            lbl_Password.Text = "Mật khẩu"
            lbl_ChangePassword.Text = "Đổi mật khẩu !"

            chk_ShowPassword.Text = "Hiện mật khẩu"
            chk_PW.Text = "Nhớ mật khẩu"

            cmd_Login.Text = "Đăng nhập"
            cmd_Close.Text = "Thoát"
        End If

    End Sub

#End Region

#Region "Events"
    Private Sub cmd_Login_Click(sender As Object, e As EventArgs) Handles cmd_Login.Click
        Try
            DBCONNECT_TYPE = "L"

            DbConnectCheck = False

            Pub.SAJ = "001"

            If cmb_FACT.Items.Count = 1 Then Pub.abc = 1
            If cmb_FACT.Items.Count = 2 Then Pub.abc = 2

            If cmb_POS.Items.Count = 1 Then Pub.pos = 1
            If cmb_POS.Items.Count = 2 Then Pub.pos = 2
            If cmb_POS.Items.Count = 3 Then Pub.pos = 3
            If cmb_POS.Items.Count = 4 Then Pub.pos = 4

            If cmb_SET.Items.Count = 0 Then Pub.SETCS = "2"
            If cmb_SET.Items.Count = 1 Then Pub.SETCS = "1"

            If Pub.SETCS = "1" Then KindDB = "SQL"
            If Pub.SETCS = "2" Then KindDB = "ORA"
            If Pub.SETCS = "3" Then KindDB = "MDB"

            Pub.CLI = "1"
            Pub.BNAT = "1"

            Pub.pos = cmb_POS.SelectedValue

            Call TRANSFER_R9700()

            Dim cnsql As ConnectSQL = GetConnect(Pub.pos)


            Pub.SSER = cnsql.SSER
            Pub.DBS = cnsql.DBS
            Pub.IDS = cnsql.IDS
            Pub.PWS = cnsql.PWS
            kndl()
            Pub.SER = cnsql.SER

            If Trim(cmb_ID.Text) = "" And Trim(txt_PASS.Text) = "" Then
                Call MsgBoxP("Wrong Id Or Pass Login ! Vui lòng kiểm tra thông tin đăng nhập !")
                cmb_ID.Focus()
                Exit Sub
            End If

            If Pub.SETCS = "1" Then Call SQLSERVER_DATE()
            If Pub.SETCS = "2" Then Call JOB_Date()
            If Pub.SETCS = "3" Then Call MDBSERVER_DATE()


            If txt_PASS.Text = "" Then txt_PASS.Text = " "
            If cmb_ID.Text = "" Then cmb_ID.Text = " "

            DS1 = PrcDS_Old("USP_ISUD9992A_SEARCH_VS1", cn, FormatCut(cmb_ID.Text), FormatCut(txt_PASS.Text), VERNEW)

            If GetDsRc(DS1) = 0 Then
                Call MsgBoxP("Wrong Login! Đăng nhập lại ! Sai mật khẩu !")
                txt_PASS.Focus()
                Exit Sub

            Else
                Pub.SAW = Trim(GetDsData(DS1, 0, "SANO"))
                Pub.SITE = Trim(GetDsData(DS1, 0, "SITE"))
                Pub.PWD = Trim(GetDsData(DS1, 0, "PW"))
                Pub.GRA = Trim(GetDsData(DS1, 0, "GRANT"))
                Pub.GRP = Trim(GetDsData(DS1, 0, "GROUP"))
                Pub.ERO = Trim(GetDsData(DS1, 0, "GROUP_ERO"))

                Pub.CUSCHK = Trim(GetDsData(DS1, 0, "CUSTOMER_CHK"))
                Pub.DEPARTMENTCHK = Trim(GetDsData(DS1, 0, "GROUP_BASIC"))
                Pub.SITECHK = Trim(GetDsData(DS1, 0, "CheckSite"))
                Pub.DEVCHK = Trim(GetDsData(DS1, 0, "CheckDev"))
                Pub.ADMCHK = Trim(GetDsData(DS1, 0, "CheckAdmin"))
            End If

            If READ_PFK7411(Pub.SAW) Then
                Pub.SAN = D7411.cdInCharge
                Pub.NAM = D7411.Name
                Pub.DEPARTMENT = D7411.cdDepartment
                Pub.SITE = D7411.cdSite
            End If

            If Pub.CUSCHK = "1" Then
                DS1 = READ_PFK9996_LIST(Pub.SITE, Pub.SAW, cn)

                If GetDsRc(DS1) > 0 Then
                    For Each RS01 As DataRow In DS1.Tables(0).Rows
                        K9996_MOVE(RS01)
                        LIST_D9996.Add(D9996)
                        If List_Customer.Contains(D9996.CustomerCode) = False Then
                            List_Customer.Add(D9996.CustomerCode)
                        End If

                    Next
                End If
            End If

            Call VERSION_READ()
            Call ID_WRITE()
            Call NAT_WRITE()

            If chk_PW.Checked = True Then
                Call PW_WRITE(1)
            Else
                Call PW_WRITE(2)
            End If

            Call IPCheck()

            PASSWORDCHECK = UCase(Trim(txt_PASS.Text))

            forma = True
            isud = True
            CheckConnect = True
            Me.Dispose()

        Catch ex As Exception

        Finally

            Call GetFullInformation(Me.Name, "Login", VERNEW & "-" & Pub.VER)

        End Try
    End Sub
    Private Sub cmd_Close_Click(sender As Object, e As EventArgs) Handles cmd_Close.Click
        IPCheck()
        Me.Dispose()
        APP_EXIT(True)
    End Sub
    Private Sub cmb_ID_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_ID.KeyDown, txt_PASS.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If

    End Sub
    Private Sub cmb_NATION_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_NATION.SelectedIndexChanged
        If cmb_NATION.SelectedIndex = 0 Then
            Pub.NAT = 1
            MdiMenu.M20001.Checked = True
            MdiMenu.M20002.Checked = False

        ElseIf cmb_NATION.SelectedIndex = 1 Then
            Pub.NAT = 2
            MdiMenu.M20001.Checked = False
            MdiMenu.M20002.Checked = True

        ElseIf cmb_NATION.SelectedIndex = 2 Then
            Pub.NAT = 3
            MdiMenu.M20001.Checked = False
            MdiMenu.M20002.Checked = False

        Else
            Pub.NAT = 1
            MdiMenu.M20001.Checked = True
            MdiMenu.M20002.Checked = False
        End If
        Call LoadControlLanguage()
    End Sub
    Private Sub cmd_Change_Click(sender As Object, e As EventArgs) Handles lbl_ChangePassword.Click

        Pub.pos = cmb_POS.SelectedValue

        Dim cn As ConnectSQL = GetConnect(Pub.pos)

        Pub.SSER = cn.SSER
        Pub.DBS = cn.DBS
        Pub.IDS = cn.IDS
        Pub.PWS = cn.PWS
        Call kndl()
        Pub.SER = cn.SER

        If FPassWord_Change.Link_PassWord() Then

        End If
    End Sub

    Private Sub chk_ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chk_ShowPassword.CheckedChanged
        Try
            txt_PASS.UseSystemPasswordChar = Not chk_ShowPassword.Checked
        Catch ex As Exception

        End Try
    End Sub
#End Region

End Class