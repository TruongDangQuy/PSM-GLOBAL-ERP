Public Class PeaceForm
    Public strFormType As String
    Public rs As New Resizer
    Public chk_Resize As Boolean = False
    Public chk_Alt As Boolean = False

    Private ActivateChk As Boolean = False
    Private M9911 As T9911_AREA
    Public PeaceFormType As String
    Public strFormOriginName As String

    Public chk_Attach As Boolean = True
    Public form_Close As Boolean = False

    Public PeaceReportName As String

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.F4) Then Return True
        'Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub SelectPeaceForm_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Try

            If Me.Name.Contains("ISUD") Then
                If (Not System.IO.Directory.Exists(App_Path & "\UserDesigner")) Then
                    System.IO.Directory.CreateDirectory(App_Path & "\UserDesigner")
                End If

                If System.IO.File.Exists(App_Path & "\UserDesigner\" & Me.Name & ".txt") = False Then
                    System.IO.File.Create(App_Path & "\UserDesigner\" & Me.Name & ".txt").Dispose()

                End If

                Dim objWriter As New System.IO.StreamWriter(App_Path & "\UserDesigner\" & Me.Name & ".txt", False)
                Dim ValueStr As String
                ValueStr = Me.Size.Width
                ValueStr &= ";" & Me.Size.Height
                ValueStr &= ";" & Me.Location.X
                ValueStr &= ";" & Me.Location.Y

                'Laser Dim Childer As List(Of SplitContainer)
                'Childer = Me.FindAllContainer

                'For i As Integer = 0 To Childer.Count - 1
                '    ValueStr &= ";" & Childer(0).SplitterDistance
                'Next

                objWriter.WriteLine(ValueStr)
                objWriter.Close()

                Me.Dispose()

            ElseIf Me.Name.Contains("HLP") Then
                If (Not System.IO.Directory.Exists(App_Path & "\UserDesigner")) Then
                    System.IO.Directory.CreateDirectory(App_Path & "\UserDesigner")
                End If

                If System.IO.File.Exists(App_Path & "\UserDesigner\" & Me.Name & ".txt") = False Then
                    System.IO.File.Create(App_Path & "\UserDesigner\" & Me.Name & ".txt").Dispose()

                End If

                Dim objWriter As New System.IO.StreamWriter(App_Path & "\UserDesigner\" & Me.Name & ".txt", False)
                Dim ValueStr As String
                ValueStr = Me.Size.Width
                ValueStr &= ";" & Me.Size.Height
                ValueStr &= ";" & Me.Location.X
                ValueStr &= ";" & Me.Location.Y

                objWriter.WriteLine(ValueStr)
                objWriter.Close()

                Me.Dispose()

            ElseIf Me.Name.Contains("SPFP") Then
                If (Not System.IO.Directory.Exists(App_Path & "\UserDesigner")) Then
                    System.IO.Directory.CreateDirectory(App_Path & "\UserDesigner")
                End If

                If System.IO.File.Exists(App_Path & "\UserDesigner\" & Me.Name & ".txt") = False Then
                    System.IO.File.Create(App_Path & "\UserDesigner\" & Me.Name & ".txt").Dispose()

                End If

                Dim objWriter As New System.IO.StreamWriter(App_Path & "\UserDesigner\" & Me.Name & ".txt", False)
                Dim ValueStr As String
                ValueStr = Me.Size.Width
                ValueStr &= ";" & Me.Size.Height
                ValueStr &= ";" & Me.Location.X
                ValueStr &= ";" & Me.Location.Y

                objWriter.WriteLine(ValueStr)
                objWriter.Close()

                Me.Dispose()
            ElseIf Me.Name.Contains("PFP") Then



            End If


            form_Close = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SelectPeaceForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If chk_Alt = True Then e.Cancel = True
        form_Close = True
    End Sub

    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Alt And e.KeyCode = Keys.F4 Then chk_Alt = True
        If e.Control And e.KeyCode = Keys.F4 Then chk_Alt = True

      
    End Sub

    Public chk_FormEnterkey As Boolean = True
    Private Sub PeaceForm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Enter And chk_FormEnterkey = True Then

            If Me.Name.Contains("PFP") Then
                Try
                    Dim Children As New List(Of Object)
                    Children = Me.FindAllObject

                    Dim i As Integer
                    For i = 0 To Children.Count - 1
                        If Children(i).Name.ToString.ToUpper.Contains("SEARCH") Then
                            Children(i).select()
                            Exit Sub
                        End If

                    Next
                Catch ex As Exception

                End Try

            End If
        End If
    End Sub

    Private Sub PeaceForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If cn Is Nothing Then Exit Sub

        Dim FormName As String
        Dim tmpPW_CHK As String = ""
        tmpPW_CHK = "PSM@."

        If Me.Name.Contains("PFP") Then FormName = Strings.Left(Me.Name, 8) Else FormName = Me.Name

        If e.Alt = True And e.KeyCode = Keys.F4 Then
            Me.Close()

        ElseIf e.Control = True And e.KeyCode = Keys.G Then
            If READ_PFK9950_ProgramNo(Me.Name) Then
                If FPopUp.Link_FPopUp(Me.Name) = False Then Exit Sub
            End If

        ElseIf e.Control = True And e.Shift = True And e.KeyCode = Keys.H Then
            If Pub.DEVCHK <> "1" Then Exit Sub

            If FPopUpCreate.Link_FPopUpCreate(Me.Name) = False Then Exit Sub

        ElseIf e.Control = True And e.Shift = True And e.KeyCode = Keys.E Then
            CheckPFPAll = Not CheckPFPAll

        ElseIf e.Control = True And e.Shift = True And e.KeyCode = Keys.I Then
            If Pub.DEVCHK <> "1" Then
                Dim f As Form
                f = New FPassWord
                f.ShowDialog()
                If PASSWORDCHECK.Trim = "" Then Exit Sub
                If PASSWORDCHECK <> tmpPW_CHK Then MsgBoxP("WRONG PASS!") : Exit Sub
            End If

            Call P_FORM_USER_NEW.Link_ISUD_P_FORM_USER(3, FormName)

        ElseIf e.Control = True And e.Shift = True And e.KeyCode = Keys.L Then
            If Pub.DEVCHK <> "1" Then
                Dim f As Form
                f = New FPassWord
                f.ShowDialog()
                If PASSWORDCHECK.Trim = "" Then Exit Sub
                If PASSWORDCHECK <> tmpPW_CHK Then MsgBoxP("WRONG PASS!") : Exit Sub
            End If

            Call P_FORM_USER.Link_ISUD_P_FORM_USER(3, FormName)

        ElseIf e.Control = True And e.Shift = True And e.KeyCode = Keys.M Then
            Call ISUD7421A.Link_ISUD7421A(3, Pub.NAM)

        ElseIf e.Control = True And e.Shift = True And e.KeyCode = Keys.P Then
            If Pub.DEVCHK <> "1" Then
                Dim f As Form
                f = New FPassWord
                f.ShowDialog()
                If PASSWORDCHECK.Trim = "" Then Exit Sub
                If PASSWORDCHECK <> tmpPW_CHK Then MsgBoxP("WRONG PASS!") : Exit Sub
            End If

            Dim StrMsg As String = MsgBox("Do you want to create new form user?", vbYesNo)
            If StrMsg <> vbYes Then Exit Sub

            Dim Children As New List(Of System.Windows.Forms.Control)
            Dim str As String = ""

            Dim i As Integer
            Dim DSNEW As New DataSet

            Try

                Children = Me.FindAllChildren

                For i = 0 To Children.Count - 1
                    If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                        If Children(i).Name.Length > 5 Then
                            If READ_PFK9916_1(FormName, Mid(Children(i).Name, 5)) = False Then
next1:
                                If READ_PFK9911(Mid(Children(i).Name, 5)) Then
                                    If READ_PFK9916_3(Mid(Children(i).Name, 5)) Then
                                        D9916.CheckDev = D9916.CheckDev
                                        D9916.REMK = D9916.REMK
                                    Else
                                        D9916.CheckDev = D9911.CheckDev
                                        D9916.REMK = D9911.REMK
                                    End If
                                    D9916.ProgramNo = FormName
                                    D9916.ItemCode = D9911.ItemCode
                                    D9916.ItemName = D9911.ItemName
                                    D9916.ItemNameSimply = D9911.ItemNameSimply
                                    D9916.ItemNameForeign1 = D9911.ItemNameForeign1
                                    D9916.ItemNameForeign2 = D9911.ItemNameForeign2
                                    D9916.ProdjectName = D9911.ProdjectName
                                    D9916.DataType = D9911.DataType
                                    D9916.DataSize = D9911.DataSize
                                    D9916.DataDecimal = D9911.DataDecimal
                                    D9916.TextAlign = D9911.TextAlign
                                    D9916.HorizontalAlignment = D9911.HorizontalAlignment
                                    D9916.VerticalAlignment = D9911.VerticalAlignment
                                    D9916.SizeWidth = D9911.SizeWidth
                                    D9916.SizeHeight = D9911.SizeHeight
                                    D9916.BackColot = D9911.BackColot
                                    D9916.ForeColor = D9911.ForeColor
                                    D9916.FontName = D9911.FontName
                                    D9916.FontSize = D9911.FontSize
                                    D9916.FontBold = D9911.FontBold
                                    D9916.Lock = D9911.Lock
                                    D9916.Hidden = D9911.Hidden
                                    D9916.CheckMerge = D9911.CheckMerge
                                    D9916.CheckMergePolicy = D9911.CheckMergePolicy
                                    D9916.CheckHead = D9911.CheckHead
                                    D9916.CheckHeadType = D9911.CheckHeadType

                                    Call WRITE_PFK9916(D9916)

                                Else

                                    M9911 = D9911
                                    M9911.ItemName = Mid(Children(i).Name, 5)
                                    M9911.ItemCode = key_count()
                                    M9911.ItemNameSimply = Mid(Children(i).Name, 5)
                                    M9911.ItemNameForeign1 = Mid(Children(i).Name, 5)
                                    M9911.ItemNameForeign2 = Mid(Children(i).Name, 5)
                                    M9911.ProdjectName = "DMS"
                                    M9911.DataType = 0
                                    M9911.DataSize = 100
                                    M9911.DataDecimal = 2
                                    M9911.TextAlign = 2
                                    M9911.HorizontalAlignment = 2
                                    M9911.VerticalAlignment = 2
                                    M9911.SizeWidth = 100
                                    M9911.SizeHeight = 30
                                    M9911.BackColot = "255-255-255"
                                    M9911.ForeColor = "0-0-0"
                                    M9911.FontName = "Tahoma"
                                    M9911.FontSize = "9.00"
                                    M9911.FontBold = "0"
                                    M9911.Lock = "1"
                                    M9911.Hidden = "1"

                                    M9911.REMK = ""

                                    If WRITE_PFK9911(M9911) = True Then
                                        GoTo next1
                                    End If
                                End If
                            End If

                        End If

                    End If

                    If TypeOf (Children(i)) Is SelectPeaceHLPButton_New Then
                        If Children(i).Name.Length > 5 Then
                            If READ_PFK9916_1(FormName, Mid(Children(i).Name, 5)) = False Then
nextZ:
                                If READ_PFK9911(Mid(Children(i).Name, 5)) Then
                                    If READ_PFK9916_3(Mid(Children(i).Name, 5)) Then
                                        D9916.CheckDev = D9916.CheckDev
                                        D9916.REMK = D9916.REMK
                                    Else
                                        D9916.CheckDev = D9911.CheckDev
                                        D9916.REMK = D9911.REMK
                                    End If
                                    D9916.ProgramNo = FormName
                                    D9916.ItemCode = D9911.ItemCode
                                    D9916.ItemName = D9911.ItemName
                                    D9916.ItemNameSimply = D9911.ItemNameSimply
                                    D9916.ItemNameForeign1 = D9911.ItemNameForeign1
                                    D9916.ItemNameForeign2 = D9911.ItemNameForeign2
                                    D9916.ProdjectName = D9911.ProdjectName
                                    D9916.DataType = D9911.DataType
                                    D9916.DataSize = D9911.DataSize
                                    D9916.DataDecimal = D9911.DataDecimal
                                    D9916.TextAlign = D9911.TextAlign
                                    D9916.HorizontalAlignment = D9911.HorizontalAlignment
                                    D9916.VerticalAlignment = D9911.VerticalAlignment
                                    D9916.SizeWidth = D9911.SizeWidth
                                    D9916.SizeHeight = D9911.SizeHeight
                                    D9916.BackColot = D9911.BackColot
                                    D9916.ForeColor = D9911.ForeColor
                                    D9916.FontName = D9911.FontName
                                    D9916.FontSize = D9911.FontSize
                                    D9916.FontBold = D9911.FontBold
                                    D9916.Lock = D9911.Lock
                                    D9916.Hidden = D9911.Hidden
                                    D9916.CheckMerge = D9911.CheckMerge
                                    D9916.CheckMergePolicy = D9911.CheckMergePolicy
                                    D9916.CheckHead = D9911.CheckHead
                                    D9916.CheckHeadType = D9911.CheckHeadType

                                    Call WRITE_PFK9916(D9916)

                                Else

                                    M9911 = D9911
                                    M9911.ItemName = Mid(Children(i).Name, 5)
                                    M9911.ItemCode = key_count()
                                    M9911.ItemNameSimply = Mid(Children(i).Name, 5)
                                    M9911.ItemNameForeign1 = Mid(Children(i).Name, 5)
                                    M9911.ItemNameForeign2 = Mid(Children(i).Name, 5)
                                    M9911.ProdjectName = "DMS"
                                    M9911.DataType = 0
                                    M9911.DataSize = 100
                                    M9911.DataDecimal = 2
                                    M9911.TextAlign = 2
                                    M9911.HorizontalAlignment = 2
                                    M9911.VerticalAlignment = 2
                                    M9911.SizeWidth = 100
                                    M9911.SizeHeight = 30
                                    M9911.BackColot = "255-255-255"
                                    M9911.ForeColor = "0-0-0"
                                    M9911.FontName = "Tahoma"
                                    M9911.FontSize = "9.00"
                                    M9911.FontBold = "0"
                                    M9911.Lock = "1"
                                    M9911.Hidden = "1"

                                    M9911.REMK = ""

                                    If WRITE_PFK9911(M9911) = True Then
                                        GoTo nextZ
                                    End If
                                End If
                            End If

                        End If

                    End If

                    If TypeOf (Children(i)) Is PeaceFarpoint Then
                        If Children(i).Name.Length > 2 Then
                            If READ_PFK9916_1(FormName, Children(i).Name) = False Then
next2:
                                If READ_PFK9911(Children(i).Name) Then
                                    D9916.ProgramNo = FormName
                                    D9916.ItemCode = D9911.ItemCode
                                    D9916.ItemName = D9911.ItemName
                                    D9916.ItemNameSimply = D9911.ItemNameSimply
                                    D9916.ItemNameForeign1 = D9911.ItemNameForeign1
                                    D9916.ItemNameForeign2 = D9911.ItemNameForeign2
                                    D9916.ProdjectName = D9911.ProdjectName
                                    D9916.DataType = D9911.DataType
                                    D9916.DataSize = D9911.DataSize
                                    D9916.DataDecimal = D9911.DataDecimal
                                    D9916.TextAlign = D9911.TextAlign
                                    D9916.HorizontalAlignment = D9911.HorizontalAlignment
                                    D9916.VerticalAlignment = D9911.VerticalAlignment
                                    D9916.SizeWidth = D9911.SizeWidth
                                    D9916.SizeHeight = D9911.SizeHeight
                                    D9916.BackColot = D9911.BackColot
                                    D9916.ForeColor = D9911.ForeColor
                                    D9916.FontName = D9911.FontName
                                    D9916.FontSize = D9911.FontSize
                                    D9916.FontBold = D9911.FontBold
                                    D9916.Lock = D9911.Lock
                                    D9916.Hidden = D9911.Hidden
                                    D9916.CheckMerge = D9911.CheckMerge
                                    D9916.CheckMergePolicy = D9911.CheckMergePolicy
                                    D9916.CheckHead = D9911.CheckHead
                                    D9916.CheckHeadType = D9911.CheckHeadType
                                    D9916.CheckDev = D9911.CheckDev
                                    D9916.REMK = D9911.REMK
                                    Call WRITE_PFK9916(D9916)

                                Else

                                    M9911 = D9911
                                    M9911.ItemName = Children(i).Name
                                    M9911.ItemCode = key_count()
                                    M9911.ItemNameSimply = Children(i).Name
                                    M9911.ItemNameForeign1 = Children(i).Name
                                    M9911.ItemNameForeign2 = Children(i).Name
                                    M9911.ProdjectName = "DMS"
                                    M9911.DataType = 0
                                    M9911.DataSize = 100
                                    M9911.DataDecimal = 2
                                    M9911.TextAlign = 2
                                    M9911.HorizontalAlignment = 2
                                    M9911.VerticalAlignment = 2
                                    M9911.SizeWidth = 100
                                    M9911.SizeHeight = 30
                                    M9911.BackColot = "255-255-255"
                                    M9911.ForeColor = "0-0-0"
                                    M9911.FontName = "Tahoma"
                                    M9911.FontSize = "9.00"
                                    M9911.FontBold = "0"
                                    M9911.Lock = "1"
                                    M9911.Hidden = "1"

                                    If M9911.ItemName.Contains("Amount") Or M9911.ItemName.Contains("amount") _
                                      Or M9911.ItemName.Contains("Price") _
                                     Or M9911.ItemName.Contains("price") _
                                      Or M9911.ItemName.Contains("quantity") _
                                      Or M9911.ItemName.Contains("Balance") _
                                      Or M9911.ItemName.Contains("balance") _
                                      Or M9911.ItemName.Contains("Qty") _
                                      Or M9911.ItemName.Contains("qty") _
                                       Or M9911.ItemName.Contains("Quantity") Then
                                        M9911.DataType = 1
                                        M9911.HorizontalAlignment = 3
                                    End If

                                    M9911.REMK = ""
                                    If WRITE_PFK9911(M9911) = True Then
                                        GoTo next2
                                    End If
                                End If
                            End If

                        End If

                    End If
                Next


                Call SAVEPFK9919()
            Catch ex As Exception

            End Try
        End If

    End Sub
    Private Sub SAVEPFK9919()
        Try
            Dim W9919 As New T9919_AREA

            Dim Children As New List(Of Object)
            Dim I As Integer

            Dim FormName As String

            If Me.Name.Contains("PFP") Then FormName = Strings.Left(Me.Name, 8) Else FormName = Me.Name

            Children = Me.FindAllChildrenObject
            For I = 0 To Children.Count - 1
                Try

                    If READ_PFK9919_3(Children(I).Name) = True Then
next1:
                        W9919 = D9919
                        If READ_PFK9919_1(FormName, Children(I).Name) = False Then
                            READ_PFK9919_3(Children(I).Name)
                            D9919.ProgramNo = FormName
                            D9919.ItemName = Children(I).Name
                            D9919.ItemCode = key_count_9919()

                            If TypeOf (Children(I)) Is Label Then
                                D9919.ItemNameSimply = Children(I).Text
                                D9919.ItemNameForeign1 = Children(I).Text
                                D9919.ItemNameForeign2 = Children(I).Text
                                If D9919.ItemNameForeign2 = "" Then
                                    If W9919.ItemNameForeign2 <> "" Then
                                        D9919.ItemNameForeign2 = W9919.ItemNameForeign2
                                    End If
                                End If
                            End If

                            If D9919.ItemNameForeign2 = "" Then
                                D9919.ItemNameForeign2 = Children(I).Text
                            End If

                            If D9919.ItemNameForeign1 = "" Then
                                D9919.ItemNameForeign1 = Children(I).Text
                            End If

                            If D9919.ItemNameSimply = "" Then
                                D9919.ItemNameSimply = Children(I).Text
                            End If

                            Call WRITE_PFK9919(D9919)

                            'Else
                            '    D9919.ProgramNo = FormName
                            '    D9919.ItemCode = key_count_9919()
                            '    D9919.ItemName = Children(I).Name
                            '    D9919.ItemNameSimply = Children(I).Text
                            '    D9919.ItemNameForeign1 = Children(I).Text
                            '    D9919.ItemNameForeign2 = Children(I).Text

                            '    Call WRITE_PFK9919(D9919)
                        End If

                    Else
                        D9919.ProgramNo = FormName
                        D9919.ItemCode = key_count_9919()
                        D9919.ItemName = Children(I).Name
                        D9919.ItemNameSimply = Children(I).Text
                        D9919.ItemNameForeign1 = Children(I).Text
                        D9919.ItemNameForeign2 = Children(I).Text

                        Call WRITE_PFK9919(D9919)
                    End If

                Catch ex As Exception

                End Try
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Function key_count() As String
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        SQL = "SELECT MAX(CAST(K9911_ItemCode AS DECIMAL)) AS MAX_CODE FROM PFK9911 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            key_count = "000001"
        Else
            key_count = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If
        rd.Close()
    End Function
    Private Function key_count_9919() As String
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        SQL = "SELECT MAX(CAST(K9919_ItemCode AS DECIMAL)) AS MAX_CODE FROM PFK9919 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            key_count_9919 = "900001"
        Else
            key_count_9919 = Format(CInt(rd!MAX_CODE + 1), "000000")

        End If
        If key_count_9919 < "900001" Then key_count_9919 = "900001"

        rd.Close()
    End Function
    Overridable Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey

            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Peaceformz_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call System_Date_time()
        Pub.CLI = "1"
        Me.KeyPreview = True
        Me.Name &= Me.PeaceFormType

        If cn IsNot Nothing Then
            If Me.FindForm.FindCode("cdSite") IsNot Nothing Then

                If FormatCut(Me.FindForm.FindCode("cdSite").Code) = "" Then
                    Me.FindForm.FindCode("cdSite").Code = Pub.SITE
                    Me.FindForm.FindCode("cdSite").Data = Pub.SITENAME

                    If Pub.SITE <> "001" Then
                        Me.FindForm.FindCode("cdSite").Enabled = False
                    End If

                End If

            End If

        End If

    End Sub


    Private Sub SelectPeaceForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If chk_Resize = False Then Exit Sub
        'rs.ResizeAllControls(Me)
    End Sub

    Private Sub PeaceForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        If cn Is Nothing Then Exit Sub

        If READ_PFK9950_ProgramNo(Me.Name) Then
            If READ_PFK9951(D9950.Autokey, Pub.SAW) = False Then
                If FPopUp.Link_FPopUp(Me.Name) = False Then Exit Sub
            End If
        End If

        'If MdiMenu.M20001.Checked = True Then Exit Sub

        If Me.Name.Contains("ISUD") Or Me.Name.Contains("HLP") Then

            Dim Children2 As New List(Of Object)
            Dim temp1 As String
            Dim i As Integer
            Dim StrName As String

            Children2 = Me.FindAllChildrenObject

            For i = 0 To Children2.Count - 1
                Try
                    StrName = Children2(i).Name
                    If READ_PFK9919_1(Me.Name, Children2(i).Name) = True Then

                        If MdiMenu.M20002.Checked = True Then
                            If D9919.ItemNameSimply = "" Then GoTo next1
                            If TypeOf (Children2(i)) Is TabPage Then Children2(i).Text = D9919.ItemNameSimply Else Children2(i).ButtonTitle = D9919.ItemNameSimply

                        ElseIf MdiMenu.M20001.Checked = True Then
                            If D9919.ItemNameForeign1 = "" Then GoTo next1

                            If TypeOf (Children2(i)) Is TabPage Then Children2(i).Text = D9919.ItemNameForeign1 Else Children2(i).ButtonTitle = D9919.ItemNameForeign1

                        End If
                    ElseIf Children2(i).Name.ToString.Length > 4 Then
                        temp1 = Children2(i).Name.Substring(4)
                        If READ_PFK9911(temp1) = True Then
                            If MdiMenu.M20002.Checked = True Then
                                If D9919.ItemNameSimply = "" Then GoTo next1
                                If TypeOf (Children2(i)) Is TabPage Then Children2(i).Text = D9911.ItemNameSimply Else Children2(i).ButtonTitle = D9911.ItemNameSimply
                            ElseIf MdiMenu.M20001.Checked = True Then
                                If D9919.ItemNameForeign1 = "" Then GoTo next1
                                If TypeOf (Children2(i)) Is TabPage Then Children2(i).Text = D9911.ItemNameForeign1 Else Children2(i).ButtonTitle = D9911.ItemNameForeign1
                            End If
                        End If
                    End If

                Catch ex As Exception

                End Try
next1:
            Next

        ElseIf Me.Name.Contains("PFP") Then

        End If
    End Sub
End Class
