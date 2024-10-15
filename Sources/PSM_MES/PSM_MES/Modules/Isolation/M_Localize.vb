Imports System.Resources

Module Localize

#Region "Variable"
    Public manager As ResourceManager

    Public Enum StringId
        hello
    End Enum

#End Region

#Region "Methods"
    Public Function GetIPAddress() As String
        Dim strHostName As String
        strHostName = System.Net.Dns.GetHostName()
        Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)

        For Each ipheal As System.Net.IPAddress In iphe.AddressList
            If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                strHostName = ipheal.ToString()
            End If
        Next

        GetIPAddress = strHostName
    End Function
    
#End Region

    Public Class Localizer

#Region "Variable"
        Shared localizer As Localizer = New Localizer()

#End Region

#Region "Methods"
        Private Sub New(Optional a As String = "1")
            Select Case a
                Case "1" : manager = New ResourceManager("PSMGlobal.UserMessages", Me.GetType().Assembly)
                Case Else : manager = New ResourceManager("PSMGlobal.UserMessages1", Me.GetType().Assembly)
            End Select
        End Sub

        Public Shared Function GetString(ByVal id As StringId) As String

            Dim ret As String = manager.GetString(id.ToString())

            If ret Is Nothing Then

                Throw New Exception(String.Format("The localized string for {0} is not found", id))

            End If

            Return ret

        End Function
#End Region

      

    End Class

End Module
Module WinformControlExtensions

#Region "Variable"

#End Region

#Region "Methods"

#End Region

    ''' <summary>
    ''' Recursively find all child controls for a form
    ''' </summary>
    ''' <param name="StartingContainer"><c><seealso cref="SelectPeaceForm">Form</seealso></c> that is the starting container to check for children.</param>
    ''' <returns><c><seealso cref="List(Of System.Windows.Forms.Control)">List(Of Control)</seealso></c> that contains a reference to all child controls.</returns>
    ''' <remarks>If you put this module in a separate namespace from your form, Visual Studio 2010 does not recognize the extension to the form.</remarks>
    <System.Runtime.CompilerServices.Extension()>
    Public Function FindAllChildren(ByRef StartingContainer As PeaceForm) As List(Of System.Windows.Forms.Control)
        Dim Children As New List(Of System.Windows.Forms.Control)

        Dim oControl As System.Windows.Forms.Control
        For Each oControl In StartingContainer.Controls
            Children.Add(oControl)
            If oControl.HasChildren Then
                Children.AddRange(oControl.FindAllChildren())
            End If
        Next

        Return Children
    End Function

    ''' <summary>
    ''' Recursively find all child controls for a control
    ''' </summary>
    ''' <param name="StartingContainer"><c><seealso cref="System.Windows.Forms.Control">Control</seealso></c> that is the starting container to check for children.</param>
    ''' <returns><c><seealso cref="List(Of System.Windows.Forms.Control)">List(Of Control)</seealso></c> that contains a reference to all child controls.</returns>
    ''' <remarks></remarks>
    <System.Runtime.CompilerServices.Extension()>
    Public Function FindAllChildren(ByRef StartingContainer As System.Windows.Forms.Control) As List(Of System.Windows.Forms.Control)
        Dim Children As New List(Of System.Windows.Forms.Control)

        If StartingContainer.HasChildren = False Then
            Return Nothing
        Else
            Dim oControl As System.Windows.Forms.Control
            For Each oControl In StartingContainer.Controls
                Children.Add(oControl)
                If oControl.HasChildren Then
                    Children.AddRange(oControl.FindAllChildren())
                End If
            Next
        End If

        Return Children
    End Function

    Public Function FindAllTextBox(ByRef StartingContainer As PeaceForm) As List(Of PeaceTextbox)
        Dim Children As New List(Of PeaceTextbox)

        Dim oControl As System.Windows.Forms.Control
        For Each oControl In StartingContainer.Controls
            If TypeOf (oControl) Is PeaceTextbox Then
                Children.Add(oControl)
            End If
            If oControl.HasChildren Then
                Children.AddRange(oControl.FindAllChildren())
            End If
        Next

        Return Children
    End Function

    <System.Runtime.CompilerServices.Extension()>
    Public Function FindAllNavBarItem(ByRef StartingContainer As DevExpress.XtraNavBar.NavBarControl) As List(Of DevExpress.XtraNavBar.NavBarItem)
        Dim Children As New List(Of DevExpress.XtraNavBar.NavBarItem)

        Dim oControl As DevExpress.XtraNavBar.NavBarItem
        Dim ooControl As DevExpress.XtraNavBar.NavBarItem
        Try

            For Each oControl In StartingContainer.Items
                Children.Add(oControl)
                If oControl.Name <> "" Then
                    Try
                        Children.Add(ooControl)
                    Catch ex As Exception

                    End Try
                End If
            Next

        Catch ex As Exception

        End Try
        Return Children
    End Function

    ''' <summary>
    ''' Recursively find all child controls for a control
    ''' </summary>
    ''' <param name="StartingContainer"><c><seealso cref="System.Windows.Forms.Control">Control</seealso></c> that is the starting container to check for children.</param>
    ''' <returns><c><seealso cref="List(Of System.Windows.Forms.Control)">List(Of Control)</seealso></c> that contains a reference to all child controls.</returns>
    ''' <remarks></remarks>
    <System.Runtime.CompilerServices.Extension()>
    Public Function FindAllTextBox(ByRef StartingContainer As System.Windows.Forms.Control) As List(Of PeaceTextbox)
        Dim Children As New List(Of PeaceTextbox)

        If StartingContainer.HasChildren = False Then
            Return Nothing
        Else
            Dim oControl As System.Windows.Forms.Control
            For Each oControl In StartingContainer.Controls
                If TypeOf (oControl) Is PeaceTextbox Then
                    Children.Add(oControl)
                End If
                If oControl.HasChildren Then
                    Children.AddRange(oControl.FindAllTextBox())
                End If
            Next
        End If

        Return Children
    End Function


    ''' <summary>
    ''' Recursively find all child controls for a control
    ''' </summary>
    ''' <param name="StartingContainer"><c><seealso cref="System.Windows.Forms.Control">Control</seealso></c> that is the starting container to check for children.</param>
    ''' <returns><c><seealso cref="List(Of System.Windows.Forms.Control)">List(Of Control)</seealso></c> that contains a reference to all child controls.</returns>
    ''' <remarks></remarks>
    <System.Runtime.CompilerServices.Extension()>
    Public Function FindAllContainer(ByRef StartingContainer As System.Windows.Forms.Control) As List(Of SplitContainer)
        Dim Children As New List(Of SplitContainer)

        Dim oControl As Object
        For Each oControl In StartingContainer.Controls
            If TypeOf (oControl) Is SplitContainer Then
                Children.Add(oControl)
            End If
            If oControl.HasChildren Then
                Children.AddRange(oControl.FindAllContainer())
            End If
        Next
        Return Children
    End Function

    '    ''' <remarks></remarks>
    '    <System.Runtime.CompilerServices.Extension()>
    '    Public Function FindAllToolStripMenuItem(ByRef StartingContainer As System.Windows.Forms.MenuStrip) As List(Of ToolStripMenuItem)
    '        Dim Children As New List(Of ToolStripMenuItem)

    '        Dim oControl As ToolStripMenuItem
    '        Dim ooControl As ToolStripMenuItem
    '        Try

    '            For Each oControl In StartingContainer.Items
    '                Children.Add(oControl)
    '                If oControl.Text <> "" Then
    '                    Try
    'next1:
    '                        For Each ooControl In oControl.DropDownItems.OfType(Of ToolStripMenuItem)()
    '                            Children.Add(ooControl)
    '                        Next
    '                    Catch ex As Exception
    '                        GoTo next1
    '                    End Try
    '                End If
    '            Next

    '        Catch ex As Exception

    '        End Try
    '        Return Children
    '    End Function

    ''' <remarks></remarks>
    <System.Runtime.CompilerServices.Extension()>
    Public Function FindAllToolStripMenuItem(ByRef StartingContainer As System.Windows.Forms.MenuStrip) As List(Of ToolStripMenuItem)
        Dim Children As New List(Of ToolStripMenuItem)

        Dim oControl As ToolStripMenuItem
        'Dim ooControl As Object

        Try

            For Each oControl In StartingContainer.Items
                Children.Add(oControl)
                If oControl.Text <> "" Then
                    Try
                        For Each ooControl As Object In oControl.DropDownItems
                            If (TypeOf ooControl Is ToolStripMenuItem) Then

                                ooControl.tag = oControl.Name
                                Children.Add(ooControl)
                                Try
                                    If ooControl.HasDropDownItems Then
                                        Try
                                            Children.AddRange(CType(ooControl, ToolStripMenuItem).FindAllToolStripMenuItemChildren())
                                        Catch ex As Exception

                                        End Try

                                    End If
                                Catch ex As Exception

                                End Try

                            End If
                        Next

                    Catch ex As Exception

                    End Try
                End If
            Next

        Catch ex As Exception

        End Try
        Return Children
    End Function


    ''' <remarks></remarks>
    <System.Runtime.CompilerServices.Extension()>
    Public Function FindAllToolStripMenuItemChildren(ByRef StartingContainer As System.Windows.Forms.ToolStripMenuItem) As List(Of ToolStripMenuItem)
        Dim Children As New List(Of ToolStripMenuItem)

        Dim oControl As Object
        'Dim ooControl As Object

        Try

            For Each oControl In StartingContainer.DropDownItems
                If (TypeOf oControl Is ToolStripMenuItem) Then
                    Children.Add(oControl)
                    Try
                        If oControl.HasDropDownItems Then
                            Children.AddRange(CType(oControl, ToolStripMenuItem).FindAllToolStripMenuItemChildren())
                            'oControl.FindAllToolStripMenuItemChildren()
                        End If
                    Catch ex As Exception
                    End Try
                End If
            Next

        Catch ex As Exception

        End Try
        Return Children
    End Function


    ''' <remarks></remarks>
    <System.Runtime.CompilerServices.Extension()>
    Public Function Find1TextBox(ByRef StartingContainer As System.Windows.Forms.Control) As TextBox
        Dim Children As TextBox
        Children = Nothing
        If StartingContainer.HasChildren = False Then
            Return Nothing
        Else
            Dim oControl As System.Windows.Forms.Control
            For Each oControl In StartingContainer.Controls
                If TypeOf (oControl) Is TextBox Then
                    Children = oControl
                End If
            Next
        End If

        Return Children
    End Function

    <System.Runtime.CompilerServices.Extension()>
    Public Function Find1RichText(ByRef StartingContainer As System.Windows.Forms.Control) As RichTextBox
        Dim Children As RichTextBox
        Children = Nothing
        If StartingContainer.HasChildren = False Then
            Return Nothing
        Else
            Dim oControl As System.Windows.Forms.Control
            For Each oControl In StartingContainer.Controls
                If TypeOf (oControl) Is RichTextBox Then
                    Children = oControl
                End If
            Next
        End If

        Return Children
    End Function


#Region "Form_Initial"
    Private MM9911 As T9911_AREA
    Private MM9912 As T9912_AREA

    Private Function key_count9911() As String
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        SQL = "SELECT MAX(CAST(K9911_ItemCode AS DECIMAL)) AS MAX_CODE FROM PFK9911 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            key_count9911 = "000001"
        Else
            key_count9911 = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If
        rd.Close()
    End Function

    <System.Runtime.CompilerServices.Extension()>
    Public Sub MDI_Tran(ByRef StartingContainer As System.Windows.Forms.MenuStrip)

        Dim i As Integer
        Dim Children2 As New List(Of ToolStripMenuItem)
        Dim temp1 As String
        'Dim DATAreader As SqlClient.SqlDataReader


        Children2 = StartingContainer.FindAllToolStripMenuItem

        For i = 0 To Children2.Count - 1
            temp1 = Children2(i).Name.ToString
            Try
                If READ_PFK9911(temp1) = True Then
                    If MdiMenu.M20002.Checked = True Then
                        Children2(i).Text = D9911.ItemNameForeign1

                    ElseIf MdiMenu.M20001.Checked = True Then
                        Children2(i).Text = D9911.ItemNameSimply

                    End If
                Else
                    D9911_CLEAR()

                    MM9911 = D9911
                    MM9911.ItemName = temp1
                    MM9911.ItemCode = key_count9911()
                    MM9911.ItemNameSimply = Children2(i).Text.ToString
                    MM9911.ItemNameForeign1 = temp1
                    MM9911.ItemNameForeign2 = temp1
                    MM9911.ProdjectName = "DMS"
                    MM9911.DataType = 0
                    MM9911.DataSize = 100
                    MM9911.DataDecimal = 2
                    MM9911.TextAlign = 2
                    MM9911.HorizontalAlignment = 2
                    MM9911.VerticalAlignment = 2
                    MM9911.SizeWidth = 100
                    MM9911.SizeHeight = 30
                    MM9911.BackColot = "255-255-255"
                    MM9911.ForeColor = "0-0-0"
                    MM9911.FontName = "Tahoma"
                    MM9911.FontSize = "9.00"
                    MM9911.FontBold = "0"
                    MM9911.Lock = "1"
                    MM9911.Hidden = "1"
                    If Strings.Left(MM9911.ItemName, 4).ToUpper = "KEY_" Then MM9911.Hidden = "0"

                    If MM9911.ItemName.Contains("Amount") Or MM9911.ItemName.Contains("amount") _
                      Or MM9911.ItemName.Contains("Price") _
                     Or MM9911.ItemName.Contains("price") _
                      Or MM9911.ItemName.Contains("quantity") _
                      Or MM9911.ItemName.Contains("Balance") _
                      Or MM9911.ItemName.Contains("balance") _
                      Or MM9911.ItemName.Contains("Qty") _
                      Or MM9911.ItemName.Contains("qty") _
                       Or MM9911.ItemName.Contains("Quantity") Then
                        MM9911.DataType = 1
                        MM9911.HorizontalAlignment = 3
                    End If

                    MM9911.REMK = "MENU"
                    WRITE_PFK9911(MM9911)
                End If

            Catch ex As Exception

            End Try

        Next
    End Sub

    <System.Runtime.CompilerServices.Extension()>
    Public Sub Form_Initial(ByRef StartingContainer As System.Windows.Forms.Control)
        Dim Children As New List(Of System.Windows.Forms.Control)

        If StartingContainer.HasChildren = False Then
        Else
            Dim oControl As System.Windows.Forms.Control
            For Each oControl In StartingContainer.Controls
                Children.Add(oControl)
                If oControl.HasChildren Then
                    Children.AddRange(oControl.FindAllChildren())
                End If
            Next
        End If
        Dim i As Integer
        For i = 0 To Children.Count - 1
            If TypeOf (Children(i)) Is PeaceTextbox Then
                Dim c As Object
                c = CType(Children(i), PeaceTextbox)
                If c.NoClear = True Then GoTo next1
                c.data = ""
                If c.DTLen <> 1 Then
                    Children(i).Enabled = True
                    Children(i).Visible = True
                End If
            ElseIf TypeOf (Children(i)) Is PeaceMaskedtextbox Then
                Dim c As Object
                c = CType(Children(i), PeaceMaskedtextbox)
                Children(i).Text = ""
            End If

next1:
        Next

    End Sub
    <System.Runtime.CompilerServices.Extension()>
    Public Sub Form_Initial_NoChange(ByRef StartingContainer As System.Windows.Forms.Control)
        Dim Children As New List(Of System.Windows.Forms.Control)

        If StartingContainer.HasChildren = False Then
        Else
            Dim oControl As System.Windows.Forms.Control
            For Each oControl In StartingContainer.Controls
                Children.Add(oControl)
                If oControl.HasChildren Then
                    Children.AddRange(oControl.FindAllChildren())
                End If
            Next
        End If
        Dim i As Integer
        For i = 0 To Children.Count - 1
            If TypeOf (Children(i)) Is PeaceTextbox Then
                Dim c As Object
                c = CType(Children(i), PeaceTextbox)
                c.data = ""

            ElseIf TypeOf (Children(i)) Is PeaceMaskedtextbox Then
                Dim c As Object
                c = CType(Children(i), PeaceMaskedtextbox)
                Children(i).Text = ""
            End If


        Next

    End Sub
    <System.Runtime.CompilerServices.Extension()>
    Public Sub Form_ClearData(ByRef StartingContainer As System.Windows.Forms.Control)
        Dim Children As New List(Of System.Windows.Forms.Control)

        If StartingContainer.HasChildren = False Then
        Else
            Dim oControl As System.Windows.Forms.Control
            For Each oControl In StartingContainer.Controls
                Children.Add(oControl)
                If oControl.HasChildren Then
                    Children.AddRange(oControl.FindAllChildren())
                End If
            Next
        End If
        Dim i As Integer
        For i = 0 To Children.Count - 1
            If TypeOf (Children(i)) Is PeaceTextbox Then
                Dim c As Object
                c = CType(Children(i), PeaceTextbox)
                If c.NoClear = False Then
                    c.Code = ""
                    c.Data = ""
                End If
                'If c.DTLen <> 1 Then
                '    Children(i).Enabled = True
                '    Children(i).Visible = True
                'End If
            ElseIf TypeOf (Children(i)) Is PeaceMaskedtextbox Then
                Dim c As Object
                c = CType(Children(i), PeaceMaskedtextbox)
                If c.NoClear = False Then
                    Children(i).Text = ""
                    Children(i).Tag = ""
                End If
            End If
        Next

    End Sub
    <System.Runtime.CompilerServices.Extension()>
    Public Sub Form_KeyDown(ByRef StartingContainer As PeaceForm)

    End Sub

    <System.Runtime.CompilerServices.Extension()>
    Public Sub Form_KeyDown_BK(ByRef StartingContainer As PeaceForm)

        'EnableMenuItem(GetSystemMenu(StartingContainer.Handle, False), &H200, MF_GRAYED)

        'If StartingContainer.chk_Resize = False Then
        '    StartingContainer.rs = New Resizer
        '    StartingContainer.rs.FindAllControls(StartingContainer) : StartingContainer.chk_Resize = True
        '    StartingContainer.FormBorderStyle = FormBorderStyle.Sizable
        '    StartingContainer.MaximizeBox = True
        '    StartingContainer.MinimizeBox = True
        'End If


        'Disable(StartingContainer)

        Dim i As Integer
        Dim Children As New List(Of System.Windows.Forms.Control)
        Dim Children2 As New List(Of Object)
        Dim temp1 As String
        Dim DATAreader As SqlClient.SqlDataReader

        If StartingContainer.HasChildren = False Then
        Else
            Dim oControl As System.Windows.Forms.Control
            For Each oControl In StartingContainer.Controls
                Children.Add(oControl)
                If oControl.HasChildren Then
                    Children.AddRange(oControl.FindAllChildren())
                End If
            Next
        End If

        For i = 0 To Children.Count - 1
            If TypeOf (Children(i)) Is PeaceTextbox Then
                Try
                    If Right(Children(i).Parent.Parent.Name, 6).ToUpper = "REMARK" Then GoTo nextx
                Catch ex As Exception
                End Try
                RemoveHandler Children(i).KeyDown, AddressOf standard_KeyDown
                AddHandler Children(i).KeyDown, AddressOf standard_KeyDown

            ElseIf TypeOf (Children(i)) Is TextBox Then
                Try
                    If Right(Children(i).Parent.Parent.Name, 6).ToUpper = "REMARK" Then GoTo nextx
                Catch ex As Exception
                End Try

                RemoveHandler Children(i).KeyDown, AddressOf standard_KeyDown
                AddHandler Children(i).KeyDown, AddressOf standard_KeyDown

            ElseIf TypeOf (Children(i)) Is PeaceRadioButton Or TypeOf (Children(i)) Is RadioButton Then
                RemoveHandler Children(i).KeyDown, AddressOf standard_KeyDown
                AddHandler Children(i).KeyDown, AddressOf standard_KeyDown
            End If

            If Children(i).Name.Length > 5 Then
                If READ_PFK9911(Mid(Children(i).Name, 5)) Then
                    If D9911.DataType = "1" Then
                        CType(Children(i), Object).FormatValue = True : CType(Children(i), Object).FormatDecimal = D9911.DataDecimal
                    End If
                End If
            End If
nextx:
        Next

        Dim scheme As TabOrderManager.TabScheme
        scheme = TabOrderManager.TabScheme.AcrossFirst
        Dim tom As New TabOrderManager(StartingContainer)
        tom.SetTabOrder(scheme)

        If MdiMenu.M20001.Checked = True Then Exit Sub

        Children2 = StartingContainer.FindAllType
        For i = 0 To Children2.Count - 1
            temp1 = Children2(i).Name.Substring(4)
            Try
                DATAreader = PrcDR("USP_SPREAD_PROGRAM_ITEM_SEARCH_ONE", cn, temp1)

                DATAreader.Read()
                If DATAreader.HasRows And MdiMenu.M20002.Checked = True Then
                    Children2(i).ButtonTitle = DATAreader("ItemNameForeign1").ToString
                End If


            Catch ex As Exception

            Finally
                DATAreader.Close()
            End Try


        Next
    End Sub
    'Public Sub Form_Translate(ByRef StartingContainer As System.Windows.Forms.Control)
    '    If Mdimenu.M20001.Checked = True Then Exit Sub

    '    Dim Children2 As New List(Of Object)
    '    Dim temp1 As String
    '    Dim i As Integer

    '    Children2 = StartingContainer.FindAllType

    '    For i = 0 To Children2.Count - 1
    '        temp1 = Children2(i).Name.Substring(4)
    '        Try
    '            If READ_PFK9911(temp1) = True Then
    '                If Mdimenu.M20002.Checked = True Then
    '                    Children2(i).ButtonTitle = D9911.ItemNameForeign1

    '                ElseIf Mdimenu.M20003.Checked = True Then
    '                    Children2(i).ButtonTitle = D9911.ItemNameForeign2

    '                ElseIf Mdimenu.M20001.Checked = True Then
    '                    Children2(i).ButtonTitle = D9911.ItemNameSimply

    '                End If
    '            Else
    '                D9911_CLEAR()

    '                MM9911 = D9911
    '                MM9911.ItemName = temp1
    '                MM9911.ItemCode = key_count9911()
    '                MM9911.ItemNameSimply = Children2(i).Text.ToString
    '                MM9911.ItemNameForeign1 = temp1
    '                MM9911.ItemNameForeign2 = temp1
    '                MM9911.ProdjectName = "DMS"
    '                MM9911.DataType = 0
    '                MM9911.DataSize = 100
    '                MM9911.DataDecimal = 2
    '                MM9911.TextAlign = 2
    '                MM9911.HorizontalAlignment = 2
    '                MM9911.VerticalAlignment = 2
    '                MM9911.SizeWidth = 100
    '                MM9911.SizeHeight = 30
    '                MM9911.BackColot = "255-255-255"
    '                MM9911.ForeColor = "0-0-0"
    '                MM9911.FontName = "Tahoma"
    '                MM9911.FontSize = "9.00"
    '                MM9911.FontBold = "0"
    '                MM9911.Lock = "1"
    '                MM9911.Hidden = "1"
    '                If Strings.Left(MM9911.ItemName, 4).ToUpper = "KEY_" Then MM9911.Hidden = "0"

    '                If MM9911.ItemName.Contains("Amount") Or MM9911.ItemName.Contains("amount") _
    '                  Or MM9911.ItemName.Contains("Price") _
    '                 Or MM9911.ItemName.Contains("price") _
    '                  Or MM9911.ItemName.Contains("quantity") _
    '                  Or MM9911.ItemName.Contains("Balance") _
    '                  Or MM9911.ItemName.Contains("balance") _
    '                  Or MM9911.ItemName.Contains("Qty") _
    '                  Or MM9911.ItemName.Contains("qty") _
    '                   Or MM9911.ItemName.Contains("Quantity") Then
    '                    MM9911.DataType = 1
    '                    MM9911.HorizontalAlignment = 3
    '                End If

    '                MM9911.REMK = ""
    '                WRITE_PFK9911(MM9911)
    '            End If

    '        Catch ex As Exception

    '        End Try

    '        'Try
    '        '    DATAreader = PrcDR("USP_SPREAD_PROGRAM_ITEM_SEARCH_ONE", cn, temp1)

    '        '    DATAreader.Read()
    '        '    If DATAreader.HasRows And Mdimenu.VIETNAMCHK.Checked = True Then
    '        '        Children2(i).ButtonTitle = DATAreader("ItemNameForeign1").ToString

    '        '    ElseIf DATAreader.HasRows And Mdimenu.KOREANCHK.Checked = True Then
    '        '        Children2(i).ButtonTitle = DATAreader("ItemNameForeign2").ToString
    '        '    End If
    '        '    DATAreader.Close()

    '        'Catch ex As Exception

    '        'End Try
    '    Next
    'End Sub

    <System.Runtime.CompilerServices.Extension()>
    Public Function FindAllChildrenObject(ByRef StartingContainer As System.Windows.Forms.Control) As List(Of Object)
        Dim Children As New List(Of Object)

        If StartingContainer.HasChildren = False Then
            Return Nothing
        Else
            Dim oControl As System.Windows.Forms.Control
            For Each oControl In StartingContainer.Controls
                Children.Add(CType(oControl, Object))
                If oControl.HasChildren And oControl.GetType.ToString.Contains("Select") = False Then
                    Children.AddRange(oControl.FindAllChildrenObject())
                End If
            Next
        End If

        Return Children
    End Function

    Public Sub Form_Translate(ByRef StartingContainer As System.Windows.Forms.Control)
        If MdiMenu.M20001.Checked = True Then Exit Sub

        Dim Children2 As New List(Of Object)
        Dim temp1 As String
        Dim i As Integer
        Dim StrName As String

        Children2 = StartingContainer.FindAllChildrenObject

        For i = 0 To Children2.Count - 1
            Try
                StrName = Children2(i).Name
                If READ_PFK9919_1(StartingContainer.Name, Children2(i).Name) = True Then
                    If MdiMenu.M20002.Checked = True Then
                        If TypeOf (Children2(i)) Is TabPage Then Children2(i).Text = D9919.ItemNameForeign1 Else Children2(i).ButtonTitle = D9919.ItemNameForeign1

                    ElseIf MdiMenu.M20001.Checked = True Then
                        If TypeOf (Children2(i)) Is TabPage Then Children2(i).Text = D9919.ItemNameSimply Else Children2(i).ButtonTitle = D9919.ItemNameSimply

                    End If
                ElseIf Children2(i).Name.ToString.Length > 4 Then
                    temp1 = Children2(i).Name.Substring(4)
                    If READ_PFK9911(temp1) = True Then
                        If MdiMenu.M20002.Checked = True Then
                            If TypeOf (Children2(i)) Is TabPage Then Children2(i).Text = D9911.ItemNameForeign1 Else Children2(i).ButtonTitle = D9911.ItemNameForeign1

                        ElseIf MdiMenu.M20001.Checked = True Then
                            If TypeOf (Children2(i)) Is TabPage Then Children2(i).Text = D9911.ItemNameSimply Else Children2(i).ButtonTitle = D9911.ItemNameSimply

                        End If
                    End If
                End If

            Catch ex As Exception

            End Try

        Next
    End Sub
    Public Sub standard_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Down, Keys.Enter
                SendKeys.Send("{TAB}")
            Case Keys.Shift + Keys.Tab, Keys.Up
                SendKeys.Send("{TAB}")
        End Select
    End Sub
#End Region

#Region "Getdata form datareader"
    Public Sub READER_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, READER As DataSet)
        Dim Children As New List(Of System.Windows.Forms.Control)
        Dim str As String = ""
        Dim co As Object
        Dim i, j As Integer
        Dim DSNEW As New DataSet
        Dim Value() As String

        Try

            Children = StartingContainer.FindAllChildren

            For i = 0 To Children.Count - 1
                If TypeOf (Children(i)) Is PeaceLabel Or TypeOf (Children(i)) Is Label Or TypeOf (Children(i)) Is Button Or TypeOf (Children(i)) Is PeaceButton Then GoTo pass2
                If Children(i).Name.Trim = "" Then GoTo pass2
                If Len(Children(i).Name) < 6 Then GoTo pass2
                str = Strings.Right(Children(i).Name, Len(Children(i).Name) - 4)
                For j = 0 To GetDsCc(READER) - 1
                    Dim str1, str2 As String
                    Dim clname As String
                    clname = READER.Tables(0).Columns(j).ColumnName
                    str1 = Strings.Right(clname, Len(clname) - 6).ToUpper
                    If str.ToUpper = str1 Then
                        co = CType(Children(i), Object)
                        If TypeOf (Children(i)) Is PeaceCheckbox Or TypeOf (Children(i)) Is CheckBox Then
                            str2 = READER.Tables(0).Rows(0).Item(j).ToString
                            If str2 = "1" Then co.Checked = True Else co.Checked = False
                            GoTo pass
                        End If
                        If TypeOf (Children(i)) Is SelectPeaceCombo Then
                            str2 = READER.Tables(0).Rows(0).Item(j).ToString
                            If CIntp(str2) >= 1 Then
                                co.InSelected = CIntp(str2) - 1
                            End If

                            GoTo pass
                        End If
                        If TypeOf (Children(i)) Is RadioButton Or TypeOf (Children(i)) Is PeaceRadioButton Then
                            str2 = READER.Tables(0).Rows(0).Item(j).ToString
                            GoTo pass
                        End If
                        If TypeOf (Children(i)) Is PeaceNumericupdown Then
                            GoTo pass
                        End If

                        co.Code = READER.Tables(0).Rows(0).Item(j).ToString
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                            'Select Case Len(co.Code)
                            '    Case 3

                            '        If READ_PFK9916_1(StartingContainer.Name, Strings.Mid(co.Name, 5)) Then

                            '        End If

                            '        If co.Name.ToString.Length > 6 Then
                            '            If READ_PFK7171(ListCode(Strings.Mid(co.Name.ToString, 7)), READER.Tables(0).Rows(0).Item(j).ToString) Then
                            '                co.Data = D7171.BasicName
                            '            End If
                            '        End If

                            '    Case 6
                            '        Select Case co.ButtonName
                            '            Case "btn_Customer"

                            '                If READ_PFK7101(co.Code) Then
                            '                    co.Data = IIf(FormatCut(D7101.CustomerNameSimply) = "", D7101.CustomerName, D7101.CustomerNameSimply)
                            '                End If


                            '            Case "btn_MaterialCode", "btn_Material"

                            '                If READ_PFK7231(co.Code) Then
                            '                    co.Data = D7231.MaterialName
                            '                End If

                            '        End Select

                            '    Case 8
                            '        If READ_PFK7411(co.Code) Then
                            '            co.Data = D7411.Name
                            '        End If

                            '    Case Else
                            '        co.Data = READER.Tables(0).Rows(0).Item(j).ToString

                            If READ_PFK9916_1(StartingContainer.Name, Strings.Mid(co.Name, 5)) Then
                                If D9916.CheckDev = "1" Then

                                    Value = D9916.REMK.Split(";")
                                    Select Case Value(0)
                                        Case 1
                                            If READ_PFK7101(co.Code) Then
                                                co.Data = IIf(FormatCut(D7101.CustomerNameSimply) = "", D7101.CustomerName, D7101.CustomerNameSimply)
                                            End If

                                        Case 2
                                            If READ_PFK7104(co.Code) Then
                                                co.Data = D7104.SizeRangeName
                                            End If

                                        Case 3
                                            If Value.Length > 1 Then HLPNA = Value(1)
                                            If READ_PFK7103_TYPECODE(HLPNA, co.Code) Then
                                                co.Data = D7103.TypeName
                                            End If

                                        Case 4
                                            If Value.Length > 1 Then HLPNA = Value(1)
                                            If READ_PFK7156_CODE(HLPNA, co.Code) Then
                                                co.Data = D7156.ToolName
                                            End If

                                        Case 6
                                            If READ_PFK7411(co.Code) Then
                                                co.Data = D7411.Name
                                            End If

                                        Case 7
                                            If READ_PFK7231(co.Code) Then
                                                co.Data = D7231.MaterialName & " " & D7231.MaterialPName
                                            End If

                                        Case 8
                                            If co.Name.ToString.Length > 6 Then
                                                If READ_PFK7171(ListCode(Strings.Mid(co.Name.ToString, 7)), READER.Tables(0).Rows(0).Item(j).ToString) Then
                                                    co.Data = D7171.BasicName
                                                End If
                                            End If

                                        Case "C"
                                            If READ_PFK7105(co.Code) Then
                                                co.Data = D7105.SizeRangeToolName
                                            End If

                                        Case Else

                                            co.Data = READER.Tables(0).Rows(0).Item(j).ToString

                                    End Select

                                Else : co.Data = READER.Tables(0).Rows(0).Item(j).ToString
                                End If

                            Else : co.Data = READER.Tables(0).Rows(0).Item(j).ToString
                            End If

                            GoTo pass
                        Else
                            co.Code = READER.Tables(0).Rows(0).Item(j).ToString
                            co.Data = READER.Tables(0).Rows(0).Item(j).ToString
                        End If
pass:

                    End If

                Next
pass2:
            Next

        Catch ex As Exception
            MsgBoxP("ReadData Error!")
        End Try
    End Sub


#End Region

#Region "Getdata form Store"
    Public Sub STORE_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, READER As DataSet)
        Dim Children As New List(Of System.Windows.Forms.Control)
        Dim str As String = ""
        Dim co As Object
        Dim i, j As Integer
        Dim Value() As String
        Dim DSNEW As New DataSet
        Try

            Children = StartingContainer.FindAllChildren
            For i = 0 To Children.Count - 1
                If TypeOf (Children(i)) Is PeaceLabel Or TypeOf (Children(i)) Is Label Then GoTo pass2
                If Children(i).Name.Trim = "" Then GoTo pass2
                If Len(Children(i).Name) < 5 Then GoTo pass2
                str = Strings.Right(Children(i).Name, Len(Children(i).Name) - 4)
                For j = 0 To GetDsCc(READER) - 1
                    Dim str1, str2 As String
                    Dim clname As String
                    clname = READER.Tables(0).Columns(j).ColumnName
                    str1 = clname.ToUpper
                    If str.ToUpper = str1 Then

                        co = CType(Children(i), Object)
                        If TypeOf (Children(i)) Is PeaceCheckbox Or TypeOf (Children(i)) Is CheckBox Then
                            str2 = READER.Tables(0).Rows(0).Item(j).ToString
                            If str2 = "1" Then co.Checked = True Else co.Checked = False
                            GoTo pass
                        End If

                        If TypeOf (Children(i)) Is SelectPeaceCombo Then
                            str2 = READER.Tables(0).Rows(0).Item(j).ToString
                            If CIntp(str2) >= 1 Then
                                co.InSelected = CIntp(str2) - 1
                            End If

                            GoTo pass
                        End If
                        co.Code = READER.Tables(0).Rows(0).Item(j).ToString

                        If READ_PFK9916_1(StartingContainer.Name, Strings.Mid(co.Name, 5)) Then

                            Value = D9916.REMK.Split(";")

                            If D9916.CheckDev = "1" Then
                                Select Case D9916.REMK.Split(";")(0)
                                    Case 1
                                        If READ_PFK7101(co.Code) Then
                                            co.Data = IIf(FormatCut(D7101.CustomerNameSimply) = "", D7101.CustomerName, D7101.CustomerNameSimply)
                                        End If

                                    Case "1B" ' Jun add new by Mr Hung code 2018/07/11 10:50 AM
                                        If READ_PFK7101(co.Code) Then
                                            co.Data = IIf(FormatCut(D7101.CustomerNameSimply) = "", D7101.CustomerName, D7101.CustomerNameSimply)
                                        End If

                                    Case 2
                                        If READ_PFK7104(co.Code) Then
                                            co.Data = D7104.SizeRangeName
                                        End If

                                    Case 3
                                        If Value.Length > 1 Then HLPNA = Value(1)
                                        If READ_PFK7103_TYPECODE(HLPNA, co.Code) Then
                                            co.Data = D7103.TypeName
                                        End If

                                    Case 4
                                        If Value.Length > 1 Then HLPNA = Value(1)
                                        If READ_PFK7156_CODE(HLPNA, co.Code) Then
                                            co.Data = D7156.ToolName
                                        End If

                                    Case 6
                                        If READ_PFK7411(co.Code) Then
                                            co.Data = D7411.Name
                                        End If

                                    Case 7
                                        If READ_PFK7231(co.Code) Then
                                            co.Data = D7231.MaterialName & " " & D7231.MaterialPName
                                        End If

                                    Case 8
                                        If co.Name.ToString.Length > 6 Then
                                            If READ_PFK7171(ListCode(Strings.Mid(co.Name.ToString, 7)), READER.Tables(0).Rows(0).Item(j).ToString) Then
                                                co.Data = D7171.BasicName
                                            End If
                                        End If

                                    Case "C"
                                        If READ_PFK7105(co.Code) Then
                                            co.Data = D7105.SizeRangeToolName
                                        End If

                                    Case Else

                                        co.Data = READER.Tables(0).Rows(0).Item(j).ToString

                                End Select

                            Else : co.Data = READER.Tables(0).Rows(0).Item(j).ToString
                            End If

                        Else : co.Data = READER.Tables(0).Rows(0).Item(j).ToString
                        End If

                        'If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                        '    If co.DataDecimal <> "2" Then
                        '        If co.ButtonName <> "" Then
                        '            If Len(co.Code) = 3 Then
                        '                DSNEW = PrcDS("USP_ISUD7171A_SEARCH_LINE", cn, SELCON(co.ButtonName), READER.Tables(0).Rows(0).Item(j).ToString)
                        '                If GetDsRc(DSNEW) > 0 Then co.Data = GetDsData(DSNEW, 0, "BasicName")

                        '            ElseIf Len(co.Code) = 6 And co.ButtonName = "btn_Customer" Then
                        '                co.Data = GetDsData(READ_PFK7101(co.Code, cn), 0, "K7101_CustomerName")

                        '            ElseIf Len(co.Code) = 8 Then
                        '                co.Data = GetDsData(READ_PFK7411(co.Code, cn), 0, "K7411_Name")

                        '            ElseIf Len(co.Code) = 6 And (co.ButtonName = "btn_MaterialCode" Or co.ButtonName = "btn_Material") Then
                        '                If READ_PFK7231(co.Code) = True Then
                        '                    co.Data = D7231.MaterialName
                        '                End If
                        '            Else
                        '                co.Data = READER.Tables(0).Rows(0).Item(j).ToString
                        '            End If
                        '            GoTo pass
                        '        Else
                        '            co.Code = READER.Tables(0).Rows(0).Item(j).ToString
                        '            co.Data = READER.Tables(0).Rows(0).Item(j).ToString
                        '        End If
                        '    End If
                        'Else
                        '    co.Code = READER.Tables(0).Rows(0).Item(j).ToString
                        '    co.Data = READER.Tables(0).Rows(0).Item(j).ToString
                        'End If
pass:

                    End If

                Next
pass2:
            Next

        Catch ex As Exception
            MsgBoxP("ReadData Error!")
        End Try
    End Sub

    Public Sub DATASET_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, READER As DataSet)
        Dim Children As New List(Of System.Windows.Forms.Control)
        Dim str As String = ""
        Dim co As Object
        Dim i, j As Integer
        Dim DSNEW As New DataSet
        Try

            Children = StartingContainer.FindAllChildren
            For i = 0 To Children.Count - 1
                If TypeOf (Children(i)) Is PeaceLabel Or TypeOf (Children(i)) Is Label Then GoTo pass2
                If Children(i).Name.Trim = "" Then GoTo pass2
                If Len(Children(i).Name) < 5 Then GoTo pass2
                str = Strings.Right(Children(i).Name, Len(Children(i).Name) - 4)
                For j = 0 To GetDsCc(READER) - 1
                    Dim str1, str2 As String
                    Dim clname As String
                    clname = READER.Tables(0).Columns(j).ColumnName
                    str1 = Strings.Mid(clname.ToUpper, 7)

                    If str.ToUpper = str1 Then
                        co = CType(Children(i), Object)
                        If TypeOf (Children(i)) Is PeaceCheckbox Or TypeOf (Children(i)) Is CheckBox Then
                            str2 = READER.Tables(0).Rows(0).Item(j).ToString
                            If str2 = "1" Then co.Checked = True Else co.Checked = False
                            GoTo pass
                        End If
                        If TypeOf (Children(i)) Is SelectPeaceCombo Then
                            str2 = READER.Tables(0).Rows(0).Item(j).ToString
                            If CIntp(str2) >= 1 Then
                                co.InSelected = CIntp(str2) - 1
                            End If

                            GoTo pass
                        End If
                        If TypeOf (Children(i)) Is RadioButton Or TypeOf (Children(i)) Is PeaceRadioButton Then
                            str2 = READER.Tables(0).Rows(0).Item(j).ToString
                            GoTo pass
                        End If
                        co.Code = READER.Tables(0).Rows(0).Item(j).ToString

                        If READ_PFK9916_1(StartingContainer.Name, Strings.Mid(co.Name, 5)) Then
                            If D9916.CheckDev = "1" Then
                                Select Case D9916.REMK.Split(";")(0)
                                    Case 1
                                        If READ_PFK7101(co.Code) Then
                                            co.Data = IIf(FormatCut(D7101.CustomerNameSimply) = "", D7101.CustomerName, D7101.CustomerNameSimply)
                                        End If

                                    Case 6
                                        If READ_PFK7411(co.Code) Then
                                            co.Data = D7411.Name
                                        End If

                                    Case 7
                                        If READ_PFK7231(co.Code) Then
                                            co.Data = D7231.MaterialName & " " & D7231.MaterialPName
                                        End If

                                    Case 8
                                        If co.Name.ToString.Length > 6 Then
                                            If READ_PFK7171(ListCode(Strings.Mid(co.Name.ToString, 7)), READER.Tables(0).Rows(0).Item(j).ToString) Then
                                                co.Data = D7171.BasicName
                                            End If
                                        End If


                                    Case Else

                                        co.Data = READER.Tables(0).Rows(0).Item(j).ToString

                                End Select

                            Else : co.Data = READER.Tables(0).Rows(0).Item(j).ToString
                            End If

                        Else : co.Data = READER.Tables(0).Rows(0).Item(j).ToString
                        End If

pass:

                    End If

                Next
pass2:
            Next

        Catch ex As Exception
            MsgBoxP("ReadData Error!")
        End Try
    End Sub
#End Region

#Region "Find all object"
    <System.Runtime.CompilerServices.Extension()>
    Public Function FindCode(ByRef StartingContainer As System.Windows.Forms.Control, Type As String) As Object
        Dim oControl As System.Windows.Forms.Control

        For Each oControl In StartingContainer.FindAllType
            If oControl.Name.Contains(Type) Then Return oControl : Exit Function
        Next

        Return Nothing
    End Function

    <System.Runtime.CompilerServices.Extension()>
    Public Function FindCodeExactily(ByRef StartingContainer As System.Windows.Forms.Control, Type As String) As Object
        Dim oControl As System.Windows.Forms.Control

        For Each oControl In StartingContainer.FindAllType
            If oControl.Name.ToUpper = Type.ToUpper Then Return oControl : Exit Function
        Next

        Return Nothing
    End Function

    <System.Runtime.CompilerServices.Extension()>
    Public Function FindAllObject(ByRef StartingContainer As System.Windows.Forms.Control) As List(Of Object)
        Dim Children As New List(Of Object)

        Dim oControl As System.Windows.Forms.Control
        For Each oControl In StartingContainer.Controls
            Children.Add(oControl)
            If oControl.HasChildren Then
                Children.AddRange(oControl.FindAllObject())
            End If
        Next

        Return Children
    End Function

    <System.Runtime.CompilerServices.Extension()>
    Public Function FindAllNode(ByRef StartingContainer As Object) As List(Of TreeNode)
        Dim Children As New List(Of TreeNode)

        Dim oControl As System.Windows.Forms.TreeNode
        For Each oControl In StartingContainer.Nodes
            Children.Add(oControl)
            If oControl.Nodes.Count > 1 Then
                Children.AddRange(oControl.FindAllNode())
            End If
        Next

        Return Children
    End Function
    '<System.Runtime.CompilerServices.Extension()>
    'Public Function FindAllObject(ByRef StartingContainer As SelectPeaceForm) As List(Of Object)
    '    Dim Children As New List(Of Object)

    '    Dim oControl As System.Windows.Forms.Control
    '    For Each oControl In StartingContainer.Controls
    '        Children.Add(oControl)
    '        If oControl.HasChildren Then
    '            Children.AddRange(oControl.FindAllChildren())
    '        End If
    '    Next

    '    Return Children
    'End Function
#End Region

#Region "Data_Check For Form"
    <System.Runtime.CompilerServices.Extension()>
    Public Sub DisableAllType(ByRef StartingContainer As System.Windows.Forms.Control)
        Dim oControl As System.Windows.Forms.Control
        Try
            For Each oControl In StartingContainer.Controls
                If oControl.GetType.ToString.Contains("Select") Then
                    oControl.Enabled = False
                End If
                If oControl.HasChildren Then
                    DisableAllType(oControl)
                End If
            Next
        Catch ex As Exception
            MsgBoxP("DisableAllType")
        End Try
    End Sub

    <System.Runtime.CompilerServices.Extension()>
    Public Function FindAllType(ByRef StartingContainer As PeaceForm) As List(Of Object)
        Dim Children As New List(Of Object)

        Dim oControl As System.Windows.Forms.Control
        For Each oControl In StartingContainer.Controls
            If oControl.GetType.ToString.Contains("Select") Then
                Children.Add(oControl)
            End If
            If oControl.HasChildren Then
                Children.AddRange(oControl.FindAllType())
            End If
        Next

        Return Children
    End Function

    ''' <summary>
    ''' Recursively find all child controls for a control
    ''' </summary>
    ''' <param name="StartingContainer"><c><seealso cref="System.Windows.Forms.Control">Control</seealso></c> that is the starting container to check for children.</param>
    ''' <returns><c><seealso cref="List(Of System.Windows.Forms.Control)">List(Of Control)</seealso></c> that contains a reference to all child controls.</returns>
    ''' <remarks></remarks>
    <System.Runtime.CompilerServices.Extension()>
    Public Function FindAllType(ByRef StartingContainer As System.Windows.Forms.Control) As List(Of Object)
        Dim Children As New List(Of Object)

        If StartingContainer.HasChildren = False Then
            Return Nothing
        Else
            Dim oControl As System.Windows.Forms.Control
            For Each oControl In StartingContainer.Controls
                If oControl.GetType.ToString.Contains("Select") Then
                    Children.Add(oControl)
                End If
                If oControl.HasChildren Then
                    Children.AddRange(oControl.FindAllType())
                End If
            Next
        End If

        Return Children
    End Function

    Public Function DataCheck(ByRef StartingContainer As PeaceForm) As Boolean
        DataCheck = False
        'Dim i As Integer = 0
        'Dim Children As New List(Of PeaceTextbox)
        'Children = StartingContainer.FindAllTextBox
        'For i = 0 To Children.Count - 1
        '    Select Case Children(i).DTValue
        '        Case 1
        '            Children(i).Data = Trim(Children(i).Data)
        '            If Children(i).Data.Length > Children(i).DTLen Then Children(i).Data = "" : Children(i).Focus() : Exit Function
        '        Case 2
        '            Children(i).Data = Trim(Children(i).Data)
        '            If IsNumeric(Children(i).Data) = False Then Children(i).Data = "" : Children(i).Focus() : Exit Function
        '    End Select
        'Next
        DataCheck = True

    End Function
    Public Function DataCheck(ByRef StartingContainer As System.Windows.Forms.Control, ByVal Tablename As String) As Boolean
        DataCheck = False
        Try

            Dim temp1, temp2 As String

            Dim newds As New DataSet
            Dim CheckArray As String() = {"char", "varchar", "nvarchar", "nchar"}
            Dim i, j As Integer
            Dim Children As New List(Of Object)


            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, Tablename)

            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                For j = 0 To GetDsRc(newds) - 1
                    If TypeOf (Children(i)) Is SelectPeaceCombo Then Exit For
                    temp2 = GetDsData(newds, j, "FNAME").Substring(6)
                    If temp1 = temp2 And Children(i).DataLen <> "1" Then
                        If CheckArray.Contains(GetDsData(newds, j, "DTYPE")) Then
                            Children(i).Data = Trim(Children(i).Data)
                            Try
                                If TypeOf (Children(i)) Is SelectPeaceHLPButton Then
                                    If Children(i).Code = "" And Children(i).DataValue = "1" Then
                                        Children(i).Code = ""
                                        MsgBoxP(Children(i).ButtonTitle + ": Please fill this data by click! No type !")
                                        Children(i).Focus()
                                        Exit Function
                                    End If
                                Else
                                    If Children(i).Data = "" And Children(i).DataValue = "1" Then
                                        Children(i).Data = ""
                                        MsgBoxP(Children(i).LableTitle + ": Please fill this data!")
                                        Children(i).Focus()
                                        Exit Function
                                    End If
                                    If Children(i).Data.Length > GetDsData(newds, j, "MSIZE") Then
                                        If GetDsData(newds, j, "MSIZE") > -1 Then
                                            Children(i).Data = ""
                                            MsgBoxP(Children(i).LableTitle + ": Maximun character length is " + GetDsData(newds, j, "MSIZE"))
                                            Children(i).Focus()
                                            Exit Function
                                        End If
                                    End If
                                End If
                            Catch ex As Exception

                            End Try
                            
                        Else
                            Try
                                Children(i).Data = Trim(Children(i).Data)
                                If Children(i).Data = "" And Children(i).DataValue = "1" Then
                                    Children(i).Data = 0
                                    MsgBoxP(Children(i).LableTitle + ": Please fill this data!")
                                    Children(i).Focus()
                                    Exit Function
                                End If
                                If IsNumeric(Children(i).Data) = False Then
                                    Children(i).Data = 0
                                    MsgBoxP(Children(i).LableTitle + ": Number only !")
                                    Children(i).Focus()
                                    Exit Function
                                End If
                                If CInt(Children(i).Data).ToString.Length > GetDsData(newds, j, "MNSIZE") Then
                                    Children(i).Data = 0
                                    MsgBoxP(Children(i).LableTitle + ": Maximum number length is " + GetDsData(newds, j, "MNSIZE"))
                                    Children(i).Focus()
                                    Exit Function
                                End If
                                Children(i).Data = FormatNumber(Children(i).Data, GetDsData(newds, j, "MSCALE"))
                            Catch ex As Exception

                            End Try
                            
                        End If

                        Exit For
                    End If
                Next
            Next
            DataCheck = True

        Catch ex As Exception
            MsgBoxP("DataCheck")
        End Try
    End Function
    Public Sub DataFormat(ByRef StartingContainer As System.Windows.Forms.Control, ByVal Tablename As String)
        Dim temp1, temp2 As String
        Try


            Dim newds As New DataSet
            Dim CheckArray As String() = {"char", "varchar", "nvarchar", "nchar"}
            Dim i, j As Integer
            Dim Children As New List(Of Object)

            newds = PrcDS("USP_SPREAD_PROGRAM_SEARCH_TABLE", cn, Tablename)

            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                temp1 = Children(i).Name.Substring(4)
                For j = 0 To GetDsRc(newds) - 1
                    If TypeOf (Children(i)) Is SelectPeaceCombo Then Exit For
                    temp2 = GetDsData(newds, j, "FNAME").Substring(6)
                    If temp1 = temp2 Then
                        If CheckArray.Contains(GetDsData(newds, j, "DTYPE")) Then
                            Children(i).Data = Trim(Children(i).Data)
                        Else
                            Children(i).Data = Trim(Children(i).Data)
                            Children(i).Data = FormatNumber(Children(i).Data, GetDsData(newds, j, "MSCALE"))
                        End If

                        Exit For
                    End If
                Next
            Next

        Catch ex As Exception
            MsgBoxP("DataFormat")
        End Try
    End Sub

    Public Sub StoreFormat(ByRef StartingContainer As System.Windows.Forms.Control)
        Try
            Dim i As Integer
            Dim Children As New List(Of Object)

            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                Try
                    If IsNumeric(Children(i).Data) And Children(i).DataDecimal <> "1" Then
                        Children(i).Data = FormatNumber(Children(i).Data)
                    End If
                Catch ex As Exception

                End Try
            Next
        Catch ex As Exception
            MsgBoxP("DataFormat")
        End Try
    End Sub

    Public Sub StoreFormat_New(ByRef StartingContainer As System.Windows.Forms.Control)
        Try
            Dim i As Integer
            Dim Children As New List(Of Object)

            Children = StartingContainer.FindAllType
            For i = 0 To Children.Count - 1
                Try
                    If IsNumeric(Children(i).Data) And Children(i).FormatValue = True Then
                        If READ_PFK9911(Mid(Children(i).Name, 5)) Then
                            Children(i).Data = FormatNumber(Children(i).Data, D9911.DataDecimal)
                        End If

                    End If
                Catch ex As Exception

                End Try
            Next
        Catch ex As Exception
            MsgBoxP("DataFormat")
        End Try
    End Sub


#End Region


#Region "Disable X on form"
    'Private Const SC_CLOSE As Integer = &HF060

    'Private Const MF_GRAYED As Integer = &H1

    'Private Declare Function GetSystemMenu Lib "user32" (ByVal hwnd As Long, ByVal bRevert As Long) As Long

    'Private Declare Function EnableMenuItem Lib "user32" (ByVal hMenu As Long, ByVal wIDEnableItem As Long, ByVal wEnable As Long) As Long


    Private Declare Function GetSystemMenu Lib "user32" (ByVal hwnd As Integer, ByVal revert As Integer) As Integer
    Private Declare Function EnableMenuItem Lib "user32" (ByVal menu As Integer, ByVal ideEnableItem As Integer, ByVal enable As Integer) As Integer
    Private Const SC_CLOSE As Integer = &HF060
    Private Const MF_BYCOMMAND As Integer = &H0
    Private Const MF_GRAYED As Integer = &H1
    Private Const MF_ENABLED As Integer = &H0
    Public Sub Disable(ByVal form As PeaceForm)

        Select Case EnableMenuItem(GetSystemMenu(form.Handle.ToInt32, 0), SC_CLOSE, MF_BYCOMMAND Or MF_GRAYED)
            Case MF_ENABLED
            Case MF_GRAYED
            Case &HFFFFFFFF
                Throw New Exception("The Close menu item does not exist.")
            Case Else
        End Select

    End Sub

#End Region

#Region "Price Exchange"
    Public Sub PriceExchange(ByVal Day As String, ByRef PriceEx As SelectLabelText, ByRef PriceDate As SelectPeaceCalSin)
        Dim SQL As String
        Dim cmd As New SqlClient.SqlCommand
        Dim NewDay As String = Day

        Try


            SQL = "SELECT TOP 1 K7199_DateExchange,K7199_VND,K7199_KOR,K7199_EURO"
            SQL = SQL + " FROM PFK7199 WHERE K7199_DateExchange <= '" + Day + "'"
            SQL = SQL + " ORDER BY K7199_DateExchange DESC "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = True Then
                PriceEx.Data = FormatNumber(rd("K7199_VND"), 4)
                NewDay = rd("K7199_DateExchange")
            End If


        Catch ex As Exception
            MsgBoxP("PriceExchange", vbCritical)
        Finally
            rd.Close()
            PriceDate.Data = NewDay
        End Try

    End Sub
    Public Sub PriceExchange(ByVal Day As String, ByRef PriceEx As SelectLabelTextLable, ByRef PriceDate As SelectPeaceCalSin)
        Dim SQL As String
        Dim cmd As New SqlClient.SqlCommand
        Dim NewDay As String = Day

        Try


            SQL = "SELECT TOP 1 K7199_DateExchange,K7199_VND,K7199_KOR,K7199_EURO"
            SQL = SQL + " FROM PFK7199 WHERE K7199_DateExchange <= '" + Day + "'"
            SQL = SQL + " ORDER BY K7199_DateExchange DESC "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = True Then
                PriceEx.Data = FormatNumber(rd("K7199_VND"), 4)
                NewDay = rd("K7199_DateExchange")
            End If


        Catch ex As Exception
            MsgBoxP("PriceExchange", vbCritical)
        Finally
            rd.Close()
            PriceDate.Data = NewDay
        End Try

    End Sub
#End Region


#Region "Print Module for User"
    Public Function GETCHUOI1(ByRef chuoi1 As String, sheetname As String) As Boolean
        GETCHUOI1 = False

        Dim ds As New DataSet
        Dim dsbackup As New DataSet
        Dim cmd As New SqlClient.SqlCommand
        Dim SQL As String
        Dim i As Integer

        Try
            'SQL = "SELECT SHEETNAME FROM [CS_PRINT].[dbo].[A_SHEETNAME_PARA]"
            'SQL = SQL + " WHERE SHEETREPORT = '" + sheetname + "'"
            'SQL = SQL + " GROUP BY  SHEETNAME "
            chuoi1 = ""
            SQL = "SELECT SHEETNAME FROM [CS_PRINT].[dbo].[A_SHEETPRINT]"
            SQL = SQL + " WHERE SHEETREPORT = '" + sheetname + "'"
            SQL = SQL + " GROUP BY  SHEETNAME "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            da.SelectCommand = cmd
            da.Fill(ds)

            'If GetDsRc(ds) = 0 Then
            '    chuoi1 = ""
            '    DS1 = DATA_PARAMETER(sheetname)
            '    For i = 0 To GetDsRc(DS1) - 1
            '        If i = GetDsRc(ds) - 1 Then chuoi1 += GetDsData(ds, i, 0) : Exit For
            '        chuoi1 += GetDsData(ds, i, 0) + ";"
            '    Next
            '    GETCHUOI1 = True
            '    Exit Function
            'End If
            'chuoi1 = ""

            For i = 0 To GetDsRc(ds) - 1
                If i = GetDsRc(ds) - 1 Then chuoi1 += GetDsData(ds, i, 0) : Exit For
                chuoi1 += GetDsData(ds, i, 0) + ";"
            Next
            GETCHUOI1 = True
        Catch ex As Exception
            MsgBoxP("GETCHUOI1")
        End Try
    End Function
    Public Function DATA_PARAMETER(name As String) As DataSet
        Dim ds As New DataSet
        Dim SQL As String
        Dim RS01 As DataRow = Nothing
        Dim da As New SqlClient.SqlDataAdapter

        Try
            SQL = ""
            SQL = SQL + "SELECT A.name as ID "
            SQL = SQL + "      ,B.name AS IDNAME "
            SQL = SQL + "     ,C.name AS IDTYPE "
            SQL = SQL + "      FROM [sys].[procedures] A   "
            SQL = SQL + "       INNER JOIN [sys].[parameters] B "
            SQL = SQL + "       ON A.object_id = B.object_id  "
            SQL = SQL + "       INNER JOIN [sys].[types] C"
            SQL = SQL + "       ON B.user_type_id = C.user_type_id"
            SQL = SQL + "      WHERE A.name = '" + name + "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            da.SelectCommand = cmd
            da.Fill(ds, "SP")
            Return ds

        Catch ex As Exception
            MsgBoxP("DATA_PARAMETER", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            ds = Nothing

        End Try
    End Function
    Public Function FindTypeValue(AllType As List(Of Object), Value As String) As String
        FindTypeValue = ""
        Dim i As Integer
        For i = 0 To AllType.Count - 1
            If Mid(AllType(i).Name, 5) = Value Then
                If TypeOf (AllType(i)) Is SelectPeaceHLPButton Then
                    Return AllType(i).Code
                Else
                    Return AllType(i).Data
                End If

            End If
        Next
    End Function
    Public Function FindTypeValue(Spread As PeaceFarpoint, Value As String) As String
        FindTypeValue = ""

        FindTypeValue = getData(Spread, getColumIndex(Spread, Value), Spread.ActiveSheet.ActiveRowIndex)
    End Function
    Public Function GETCHUOI2(StartingContainer As PeaceForm, ByRef chuoi2 As String, sheetname As String, chuoi1 As String) As Boolean
        GETCHUOI2 = False
        Dim cmd As New SqlClient.SqlCommand
        Dim SQL As String
        Dim i, j As Integer
        Dim StoreNo As Integer
        Dim AllType As List(Of Object)

        StoreNo = Split(chuoi1, ";").Length
        AllType = StartingContainer.FindAllType

        Try
            chuoi2 = ""
            For i = 0 To StoreNo - 1

                Dim ds As New DataSet
                SQL = "SELECT REPLACE([PARANAME],'@','') AS PARANAME  FROM [CS_PRINT].[dbo].[A_SHEETNAME_PARA] "
                SQL = SQL + " WHERE SHEETREPORT = '" + sheetname + "'"
                SQL = SQL + " AND SHEETNAME = '" + Split(chuoi1, ";")(i) + "'"

                cmd = New SqlClient.SqlCommand(SQL, cn)
                da.SelectCommand = cmd
                da.Fill(ds)

                For j = 0 To GetDsRc(ds) - 1
                    Dim Value As String
                    Value = GetDsData(ds, j, 0)
                    If j = GetDsRc(ds) - 1 Then
                        If Value.Contains("Const") Then
                            chuoi2 += SELCON(GetDsData(ds, j, 0))
                        Else
                            chuoi2 += FindTypeValue(AllType, Value)
                        End If
                    Else
                        If Value.Contains("Const") Then
                            chuoi2 += SELCON(GetDsData(ds, j, 0)) + ","
                        Else
                            chuoi2 += FindTypeValue(AllType, Value) + ","
                        End If
                    End If
                Next

                If i = StoreNo - 1 Then Exit For
                chuoi2 += ";"
            Next

            GETCHUOI2 = True
        Catch ex As Exception
            MsgBoxP("GETCHUOI2")
        End Try
    End Function
    Public Function GETCHUOI2_01(StartingContainer As PeaceForm, ByRef chuoi2 As String, sheetname As String, chuoi1 As String) As Boolean
        GETCHUOI2_01 = False
        Dim cmd As New SqlClient.SqlCommand
        Dim i, j As Integer
        Dim StoreNo As Integer
        Dim AllType As List(Of Object)

        StoreNo = Split(chuoi1, ";").Length
        AllType = StartingContainer.FindAllType

        Try
            chuoi2 = ""
            For i = 0 To StoreNo - 1
                Dim ds As New DataSet
                ds = DATA_PARAMETER(Split(chuoi1, ";")(i))

                For j = 0 To GetDsRc(ds) - 1
                    Dim Value As String
                    Value = GetDsData(ds, j, 1).Replace("@", "")
                    If j = GetDsRc(ds) - 1 Then
                        If Value.Contains("Const") Then
                            chuoi2 += SELCON(Value)
                        Else
                            chuoi2 += FindTypeValue(AllType, Value)
                        End If
                    Else
                        If Value.Contains("Const") Then
                            chuoi2 += SELCON(Value) + ","
                        Else
                            chuoi2 += FindTypeValue(AllType, Value) + ","
                        End If
                    End If
                Next

                If i = StoreNo - 1 Then Exit For
                chuoi2 += ";"
            Next

            GETCHUOI2_01 = True
        Catch ex As Exception
            MsgBoxP("GETCHUOI2")
        End Try
    End Function

    Public Function GETCHUOI2_ShoesCode(StartingContainer As PeaceForm) As String
        GETCHUOI2_ShoesCode = ""
        Dim cmd As New SqlClient.SqlCommand
        Dim i, j As Integer
        Dim StoreNo As Integer
        Dim AllType As List(Of Object)

        AllType = StartingContainer.FindAllType

        GETCHUOI2_ShoesCode = FindTypeValue(AllType, "ShoesCode")

    End Function

    Public Function GETCHUOI2_01(StartingContainer As PeaceFarpoint, ByRef chuoi2 As String, sheetname As String, chuoi1 As String) As Boolean
        GETCHUOI2_01 = False
        Dim cmd As New SqlClient.SqlCommand
        Dim i, j As Integer
        Dim StoreNo As Integer
        StoreNo = Split(chuoi1, ";").Length


        Try
            chuoi2 = ""
            For i = 0 To StoreNo - 1
                Dim ds As New DataSet
                ds = DATA_PARAMETER(Split(chuoi1, ";")(i))

                For j = 0 To GetDsRc(ds) - 1
                    Dim Value As String
                    Value = GetDsData(ds, j, 1).Replace("@", "")
                    If j = GetDsRc(ds) - 1 Then
                        If Value.Contains("Const") Then
                            chuoi2 += SELCON(Value)
                        Else
                            chuoi2 += FindTypeValue(StartingContainer, Value)
                        End If
                    Else
                        If Value.Contains("Const") Then
                            chuoi2 += SELCON(Value) + ","
                        Else
                            chuoi2 += FindTypeValue(StartingContainer, Value) + ","
                        End If
                    End If
                Next

                If i = StoreNo - 1 Then Exit For
                chuoi2 += ";"
            Next

            GETCHUOI2_01 = True
        Catch ex As Exception
            MsgBoxP("GETCHUOI2")
        End Try
    End Function

    Public Sub DATAROW_MOVE(ByRef StartingContainer As System.Windows.Forms.Control, READER As DataRow)
        Dim Children As New List(Of System.Windows.Forms.Control)
        Dim str As String = ""
        Dim co As Object
        Dim i, j As Integer
        Dim DSNEW As New DataSet
        Try

            Children = StartingContainer.FindAllChildren
            For i = 0 To Children.Count - 1
                If TypeOf (Children(i)) Is PeaceLabel Or TypeOf (Children(i)) Is Label Or TypeOf (Children(i)) Is Button Or TypeOf (Children(i)) Is PeaceButton Then GoTo pass2
                If Children(i).Name.Trim = "" Then GoTo pass2
                If Len(Children(i).Name) < 6 Then GoTo pass2
                str = Strings.Right(Children(i).Name, Len(Children(i).Name) - 4)

                For j = 0 To READER.Table.Columns.Count - 1
                    Dim str1, str2 As String
                    Dim clname As String

                    clname = READER.Table.Columns(j).ColumnName
                    str1 = clname.ToUpper

                    If str.ToUpper = str1 Then
                        co = CType(Children(i), Object)

                        If TypeOf (Children(i)) Is PeaceCheckbox Or TypeOf (Children(i)) Is CheckBox Then
                            str2 = READER.Item(j).ToString
                            If str2 = "1" Then co.Checked = True Else co.Checked = False
                            GoTo pass
                        End If
                        If TypeOf (Children(i)) Is SelectPeaceCombo Then
                            str2 = READER.Item(j).ToString
                            If CIntp(str2) >= 1 Then
                                co.InSelected = CIntp(str2) - 1
                            End If

                            GoTo pass
                        End If

                        co.Code = READER.Item(j).ToString

                        If TypeOf (Children(i)) Is SelectPeaceHLPButton And co.DataDecimal <> "2" Then
                            If Len(co.Code) = 3 Then
                                If READ_PFK7171(SELCON(co.ButtonName), READER.Item(j).ToString) Then
                                    co.Data = D7171.BasicName
                                    co.Code = D7171.BasicCode
                                Else
                                    If co.Name.Length > 5 Then
                                        If READ_PFK9916_1(co.ParentForm.Name, Strings.Mid(co.Name, 5)) Then
                                            If D9916.CheckDev = "1" Then
                                                Dim Value() As String
                                                Value = D9916.REMK.Split(";")

                                                If READ_PFK7171(Value(1), READER.Item(j).ToString) Then
                                                    co.Data = D7171.BasicName
                                                    co.Code = D7171.BasicCode
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            ElseIf Len(co.Code) = 6 And co.ButtonName = "btn_Customer" Then
                                co.Data = GetDsData(READ_PFK7101(co.Code, cn), 0, "K7101_GName")
                            ElseIf Len(co.Code) = 8 Then
                                co.Data = GetDsData(READ_PFK7411(co.Code, cn), 0, "K7411_Name")
                            Else
                                co.Data = READER.Item(j).ToString
                            End If
                            GoTo pass
                        Else
                            co.Code = READER.Item(j).ToString
                            co.Data = READER.Item(j).ToString
                        End If
                        If TypeOf (Children(i)) Is SelectPeaceHLPButton_New And co.DataDecimal <> "2" Then
                            If Len(co.Code) = 3 Then
                                If READ_PFK7171(SELCON(co.ButtonName), READER.Item(j).ToString) Then
                                    co.Data = D7171.BasicName
                                    co.Code = D7171.BasicCode
                                Else
                                    If co.Name.Length > 5 Then
                                        If READ_PFK9916_1(co.ParentForm.Name, Strings.Mid(co.Name, 5)) Then
                                            If D9916.CheckDev = "1" Then
                                                Dim Value() As String
                                                Value = D9916.REMK.Split(";")

                                                If READ_PFK7171(Value(1), READER.Item(j).ToString) Then
                                                    co.Data = D7171.BasicName
                                                    co.Code = D7171.BasicCode
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            ElseIf Len(co.Code) = 6 And co.ButtonName = "btn_Customer" Then
                                co.Data = GetDsData(READ_PFK7101(co.Code, cn), 0, "K7101_GName")
                            ElseIf Len(co.Code) = 8 Then
                                co.Data = GetDsData(READ_PFK7411(co.Code, cn), 0, "K7411_Name")
                            Else
                                co.Data = READER.Item(j).ToString
                            End If
                            GoTo pass
                        Else
                            co.Code = READER.Item(j).ToString
                            co.Data = READER.Item(j).ToString
                        End If
pass:

                    End If

                Next
pass2:
            Next

        Catch ex As Exception
            MsgBoxP("ReadData Error!")
        End Try
    End Sub

    Public Function Bangchu(so As Decimal)
        Dim i As Integer
        Dim kq, viet, dai, tung As String
        kq = ""
        viet = ""
        dai = ""
        tung = ""
        'Làm tròn, biến thành chuỗi để đưa vào biến viet

        viet = "0" & so.ToString

        'độ dài của chuỗi đă biến thành...

        dai = Len(viet)

        'Đánh vần từng con số một theo chiều dài của chuỗi "số"...

        For i = 1 To dai - 1

            tung = doc(Right(Left(viet, dai - i + 1), 1), i)

            kq = tung + " " + kq

            'Thêm tiêu đề hàng ngàn triệu tỷ đối với từng nhóm 3 con số

            Select Case i

                Case 3

                    If (i + 1) < dai Then

                        kq = "ngàn " + kq

                    End If

                Case 6

                    If (i + 1) < dai Then

                        kq = "triệu " + kq

                    End If

                Case 9

                    If (i + 1) < dai Then

                        kq = "tỷ " + kq

                    End If

                Case 12

                    If (i + 1) < dai Then

                        kq = "nghìn tỉ " + kq

                    End If

            End Select

        Next

        ' Đặt trạng thái nếu có lỗi thì bỏ qua.

        On Error Resume Next

        'Tiến hành thay thế các cụm từ ngang ngang thành từ ngữ giao tiếp 'thông thường. Thông qua hàm Replace.

        If Left(Trim(kq), 3) = "mốt" Then

            kq = "Một" + Mid(LTrim(kq), 4, Len(kq) - 4)

        End If

        kq = kq + " đồng chẵn"

        kq = Replace(kq, " ", " ")

        kq = Replace(kq, "mươi mươi", "mươi")

        kq = Replace(kq, "mươi năm", "mươi lăm")

        kq = Replace(kq, "mười năm", "mười lăm")

        kq = Replace(kq, "mười mươi", "mười")

        kq = Replace(kq, "mười mốt", "mười một")

        kq = Replace(kq, " linh mươi", "")

        kq = Replace(kq, " linh đồng", "đồng")

        kq = Replace(kq, " không trăm tỷ", "")

        kq = Replace(kq, " không trăm triệu", "")

        kq = Replace(kq, " không trăm ngàn", "")

        kq = Replace(kq, " không trăm đồng", " đồng")

        kq = Replace(kq, " trăm mốt", " trăm một")

        Bangchu = UCase(Left(kq, 1)) + Mid(kq, 2, Len(kq) - 1)

    End Function

    'Hàm doc để đánh vần từng con số 1

    Public Function doc(s, i)

        Dim kq

        Select Case s

            Case "0"

                If (i Mod 3) = 1 Then

                    kq = "mươi"

                ElseIf (i Mod 3) = 2 Then

                    kq = "linh"

                Else

                    kq = "không"

                End If

            Case "1"

                If (i Mod 3) = 1 Then

                    kq = "mốt"

                ElseIf (i Mod 3) = 2 Then

                    kq = "mười"

                Else

                    kq = "một"

                End If

            Case "2"

                kq = "hai"

            Case "3"

                kq = "ba"

            Case "4"

                kq = "bốn"

            Case "5"

                kq = "năm"

            Case "6"

                kq = "sáu"

            Case "7"

                kq = "bảy"

            Case "8"

                kq = "tám"

            Case "9"

                kq = "chín"

        End Select

        If ((i Mod 3) = 0) And (kq <> "linh") Then

            kq = kq + " trăm"

        ElseIf (i Mod 3) = 2 And (kq <> "mươi") Then

            kq = kq + " mươi"

        End If

        doc = kq

    End Function


    Dim ChuSo() As String = {"", "một ", "hai ", "ba ", "bốn ", "năm ", "sáu ", "bảy ", "tám ", "chín "}
    Dim SoTien() As String = {"nghìn ", "triệu ", "tỉ ", "nghìn "}

    Function Doc3So(ByVal so As Integer, Optional ByVal n As Boolean = False) As String
        Doc3So = ""
        Dim Tram, Chuc, Dvi As Byte
        Tram = so \ 100
        Dvi = so Mod 10
        Chuc = ((so - Dvi) \ 10) Mod 10

        'Xử lý hàng trăm
        If Tram = 0 Then
            If n Then
                Doc3So = "không trăm "
                If Chuc = 0 AndAlso Dvi > 0 Then Doc3So = Doc3So & "linh "
            End If
        Else
            Doc3So = ChuSo(Tram) & "trăm "
        End If

        'Xử lý hàng chục
        Select Case Chuc
            Case 0
                If Tram > 0 AndAlso Dvi <> 0 Then
                    Doc3So = Doc3So & "linh "
                End If
            Case 1 : Doc3So = Doc3So & "mười "
            Case Else : Doc3So = Doc3So & ChuSo(Chuc) & "mươi "
        End Select

        'Xử lý hàng đơn vị
        Select Case Dvi
            Case 1 : Doc3So = Doc3So & IIf(Chuc <= 1, "một ", "mốt ")
            Case 4
                Select Case Chuc
                    Case 0 : If Tram = 0 Or Tram = 4 Then Doc3So = Doc3So & "bốn " Else Doc3So = Doc3So & "tư "
                    Case 1, 4 : Doc3So = Doc3So & "bốn "
                    Case Else : Doc3So = Doc3So & "tư "
                End Select
            Case 5 : Doc3So = Doc3So & IIf(Chuc = 0, "năm ", "lăm ")
            Case Else : Doc3So = Doc3So & ChuSo(Dvi)
        End Select
        If Tram = 0 AndAlso Chuc = 0 AndAlso Dvi = 0 Then Doc3So = ""
    End Function

    Function DocnSo(ByVal so As Long) As String
        DocnSo = ""
        Dim cso As String = so.ToString ' Trim(Str(so))
        Select Case Len(cso)
            Case 1, 2, 3 : DocnSo = Doc3So(so) & SoTien(0)
            Case Else
                Do While Len(cso) Mod 3 <> 0
                    cso = "0" & cso
                Loop

                Dim n As Byte = 0
                For i As Integer = Len(cso) - 2 To 1 Step -3
                    DocnSo = Doc3So(Val(Mid(cso, i, 3)), IIf(i = 1, 0, 1)) & IIf(Val(Mid(cso, i, 3)) = 0, "", SoTien(n)) & DocnSo
                    n += 1
                Next
        End Select
    End Function




    Dim chữsố() As String = {"không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín"}
    Dim đơnvị() As String = {"đơn vị", "ngàn", "triệu", "tỉ"}

    Function đọc(ByVal số As String) As String
        số = số.TrimStart("0")
        'bỏ những số "0" ở đầu tiên

        If số.Length = 0 Then Return ""

        số = số.Replace(" ", "").Replace(",", "").Replace(".", "")
        'nếu muốn cho phép có dấu " " hay "," hay "." trong số để dễ nhìn thì uncomment dòng đây

        Dim kq As String = ""
        Dim chiềudài As Integer = số.Length

        'dùng biến để lưu lại từng nhóm ba chữ số dể dễ xài
        Dim sốnhóm As Integer = Math.Ceiling(chiềudài / 3)
        'tính số lượng nhóm 3 chữ số
        Dim nhóm(sốnhóm - 1) As String

        'cóp nhóm đầu tiên , rồi lần lượt những nhóm còn lại , j là chiều dài nhóm đầu tiên
        Dim j As Integer = chiềudài - (sốnhóm - 1) * 3
        nhóm(0) = số.Substring(0, j)
        For i As Integer = 1 To sốnhóm - 1
            nhóm(i) = số.Substring(j + (i - 1) * 3, 3)
        Next

        For i As Integer = 0 To nhóm.Length - 1
            kq &= đọcnhóm3số(nhóm(i), tínhđơnvị(nhóm.Length - 1 - i)) & " "
        Next

        kq = kq + " đồng"

        kq = Replace(kq, "đơn vị", "")

        kq = UCase(Left(kq, 1)) + Mid(kq, 2, Len(kq) - 1)

        Return kq.Trim.Replace("  ", " ")
        'để chắc chắn không có 2 dấu cách đứng liền nhau và 0 có dấu cách ở 2 đầu
    End Function

    Function tínhđơnvị(ByVal n As Integer) As String
        'hàm đệ qui rất đơn giản
        If n <= 3 Then
            Return đơnvị(n)
        Else
            Return tínhđơnvị(n - 3) & " " & đơnvị(3)
        End If
    End Function

    Function đọcnhóm3số(ByVal số As String, ByVal đơnvị As String) As String
        Dim kq As String = ""
        Dim l As Integer = số.Length

        số = số.PadLeft(3, "0")

        If số = "000" Then Return ""
        'không đọc những nhóm "000" như trong "1.000.000.000"

        If số.StartsWith("00") Then Return đọcsốhàngđơnvị(Val(số(2)), 0, l = 3) & " " & đơnvị
        'chỗ này để tránh khó nghe khi đọc "1.000.000.001" , nó sẽ bỏ qua từ "không trăm" và chỉ đọc "một tỉ lẻ một đơn vị" , nếu không thích thì xóa dòng đây đi cũng được

        kq &= đọcsốhàngtrăm(Val(số(0)), l = 3)
        kq &= đọcsốhàngchục(Val(số(1)))
        kq &= đọcsốhàngđơnvị(Val(số(2)), Val(số(1)), l = 3)

        Return kq & " " & đơnvị
    End Function

    Function đọcsốhàngtrăm(ByVal i As Integer, ByVal đọcsốkhông As Boolean) As String
        'biến đọcsốkhông để tránh đọc chữ "không trăm" trong số < 100 như "75" , nếu không dùng biến này thì sẽ đọc là "không trăm bảy mươi lăm"

        If i = 0 Then
            If đọcsốkhông Then
                Return "không trăm "
            Else
                Return ""
            End If
        Else
            Return chữsố(i) & " trăm "
        End If
    End Function

    Function đọcsốhàngchục(ByVal i As Integer) As String
        Select Case i
            Case 0
                Return ""
            Case 1
                Return "mười "
            Case Else
                Return chữsố(i) & " mươi "
        End Select
    End Function

    Function đọcsốhàngđơnvị(ByVal i As Integer, ByVal hàngchục As Integer, ByVal đọcchữlẻ As Boolean) As String
        'biến đọcchữlẻ để tránh đọc chữ "lẻ" trong số < 10 như "2" , nếu không dùng biến này thì sẽ đọc là "lẻ hai"
        'các lệnh điều khiển If...then và select...case chỉ là để đọc cho giống tiếng việt

        If i = 0 Then
            Return ""
        Else
            If hàngchục = 0 Then
                If đọcchữlẻ Then
                    Return "linh " & chữsố(i)
                Else
                    Return chữsố(i)
                End If
            Else
                Select Case i
                    Case 1
                        If hàngchục = 1 Then
                            Return "một"
                        Else
                            Return "mốt"
                        End If
                    Case 5
                        Return "lăm"
                    Case Else
                        Return chữsố(i)
                End Select
            End If
        End If

    End Function


#End Region



End Module