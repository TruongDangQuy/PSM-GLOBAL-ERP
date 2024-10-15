Module M_Layout

#Region "Variable"
    Public Layout_FormName As String = String.Empty
    Public Layout_Version As String = String.Empty
    Public Layout_Remark As String = String.Empty
    Public Layout_Date As String = String.Empty
    Public Layout_GroupUser As String = String.Empty

#End Region

#Region "Methods"
    Public Sub LoadItemPEACE(Name As String, LayoutControl As DevExpress.XtraLayout.LayoutControl)
        Try
            LayoutControl.BeginUpdate()

            SQL = "select * from PFK9702 where K9702_FormName = '" & Name & "' and K9702_User = '" & Pub.SAW & "'"
            DS1 = SqlDS(SQL, cn)

            If GetDsRc(DS1) < 0 Then
                Exit Sub
            End If

            For Each RS01 As DataRow In DS1.Tables(0).Rows

                Select Case RS01!K9702_Type
                    Case "1" 'SelectLabelText
                        Dim item As New DevExpress.XtraLayout.LayoutControlItem
                        item.Name = RS01!K9702_ControlName
                        item.Text = RS01!K9702_ControlName
                        item.TextVisible = False


                        Dim tControl As New SelectLabelText
                        tControl.Name = RS01!K9702_ControlName
                        tControl.ButtonTitle = RS01!K9702_ControlData1
                        tControl.Data = RS01!K9702_DefaultValue1
                        tControl.Code = RS01!K9702_DefaultValue2

                        item.Control = tControl

                        LayoutControl.HiddenItems.AddRange({item})

                    Case "2" 'SelectPeaceCalDou
                        Dim item As New DevExpress.XtraLayout.LayoutControlItem
                        item.Name = RS01!K9702_ControlName
                        item.Text = RS01!K9702_ControlName
                        item.TextVisible = False

                        LayoutControl.HiddenItems.AddRange({item})

                        Dim tControl As New SelectPeaceCalDou
                        tControl.Name = RS01!K9702_ControlName
                        tControl.ButtonTitle = RS01!K9702_ControlData1

                        Select Case RS01!K9702_DefaultValue1
                            Case "System_Date"
                                tControl.text1 = System_Date()
                            Case "System_Date_time"
                                tControl.text1 = System_Date_time()
                            Case "System_Date_8"
                                tControl.text1 = System_Date_8()
                            Case "System_Date_6"
                                tControl.text1 = System_Date_6()
                            Case Else
                                tControl.text1 = System_Date_8()
                        End Select

                        Select Case RS01!K9702_DefaultValue1
                            Case "System_Date"
                                tControl.text2 = System_Date()
                            Case "System_Date_time"
                                tControl.text2 = System_Date_time()
                            Case "System_Date_8"
                                tControl.text2 = System_Date_8()
                            Case "System_Date_6"
                                tControl.text2 = System_Date_6()
                            Case Else
                                tControl.text2 = System_Date_8()
                        End Select

                        item.Control = tControl

                    Case "3" 'SelectPeaceCalSin
                        Dim item As New DevExpress.XtraLayout.LayoutControlItem
                        item.Name = RS01!K9702_ControlName
                        item.Text = RS01!K9702_ControlName
                        item.TextVisible = False

                        LayoutControl.HiddenItems.AddRange({item})

                        Dim tControl As New SelectPeaceCalSin
                        tControl.Name = RS01!K9702_ControlName
                        tControl.ButtonTitle = RS01!K9702_ControlData1

                        Select Case RS01!K9702_DefaultValue1
                            Case "System_Date"
                                tControl.Data = System_Date()
                            Case "System_Date_time"
                                tControl.Data = System_Date_time()
                            Case "System_Date_8"
                                tControl.Data = System_Date_8()
                            Case "System_Date_6"
                                tControl.Data = System_Date_6()
                            Case Else
                                tControl.Data = System_Date_8()
                        End Select

                        item.Control = tControl

                    Case "4" 'SelectPeaceHLPButton
                        Dim item As New DevExpress.XtraLayout.LayoutControlItem
                        item.Name = RS01!K9702_ControlName
                        item.Text = RS01!K9702_ControlName
                        item.TextVisible = False

                        LayoutControl.HiddenItems.AddRange({item})

                        Dim tControl As New SelectPeaceHLPButton
                        tControl.Name = RS01!K9702_ControlName
                        tControl.ButtonTitle = RS01!K9702_ControlData1
                        tControl.ButtonName = RS01!K9702_DefaultValue1

                        item.Control = tControl

                    Case "5" 'SelectLabelText
                        Dim item As New DevExpress.XtraLayout.LayoutControlItem
                        item.Name = RS01!K9702_ControlName
                        item.Text = RS01!K9702_ControlName
                        item.TextVisible = False

                        LayoutControl.HiddenItems.AddRange({item})

                        Dim tControl As New SelectLabelText
                        tControl.Name = RS01!K9702_ControlName
                        tControl.LableTitle = RS01!K9702_ControlData1

                        item.Control = tControl

                    Case Else
                        Dim item As New DevExpress.XtraLayout.LayoutControlItem
                        item.Name = RS01!K9702_ControlName
                        item.Text = RS01!K9702_ControlName
                        item.TextVisible = False

                        LayoutControl.HiddenItems.AddRange({item})

                        Dim tControl As New SelectLabelText
                        tControl.Name = RS01!K9702_ControlName
                        tControl.ButtonTitle = RS01!K9702_ControlData1
                        tControl.Data = RS01!K9702_DefaultValue1
                        tControl.Code = RS01!K9702_DefaultValue2

                        item.Control = tControl
                End Select

            Next

        Catch ex As Exception

        Finally
            LayoutControl.EndUpdate()
        End Try

    End Sub
    Public Sub LoadItemUser(Name As String, GroupUser As String, LayoutControl As DevExpress.XtraLayout.LayoutControl)
        Try
            LayoutControl.BeginUpdate()

            SQL = "select * from PFK9706 where K9706_FormName = '" & Name & "' and K9706_GroupUser = '" & GroupUser & "'"
            DS1 = SqlDS(SQL, cn)

            If GetDsRc(DS1) < 0 Then
                Exit Sub
            End If

            For Each RS01 As DataRow In DS1.Tables(0).Rows

                Select Case RS01!K9706_Type
                    Case "1" 'SelectLabelText
                        Dim item As New DevExpress.XtraLayout.LayoutControlItem
                        item.Name = RS01!K9706_ControlName
                        item.Text = RS01!K9706_ControlName
                        item.TextVisible = False


                        Dim tControl As New SelectLabelText
                        tControl.Name = RS01!K9706_ControlName
                        tControl.ButtonTitle = RS01!K9706_ControlData1
                        tControl.Data = RS01!K9706_DefaultValue1
                        tControl.Code = RS01!K9706_DefaultValue2

                        item.Control = tControl

                        LayoutControl.HiddenItems.AddRange({item})

                    Case "2" 'SelectPeaceCalDou
                        Dim item As New DevExpress.XtraLayout.LayoutControlItem
                        item.Name = RS01!K9706_ControlName
                        item.Text = RS01!K9706_ControlName
                        item.TextVisible = False

                        LayoutControl.HiddenItems.AddRange({item})

                        Dim tControl As New SelectPeaceCalDou
                        tControl.Name = RS01!K9706_ControlName
                        tControl.ButtonTitle = RS01!K9706_ControlData1

                        Select Case RS01!K9706_DefaultValue1
                            Case "System_Date"
                                tControl.text1 = System_Date()
                            Case "System_Date_time"
                                tControl.text1 = System_Date_time()
                            Case "System_Date_8"
                                tControl.text1 = System_Date_8()
                            Case "System_Date_6"
                                tControl.text1 = System_Date_6()
                            Case Else
                                tControl.text1 = System_Date_8()
                        End Select

                        Select Case RS01!K9706_DefaultValue1
                            Case "System_Date"
                                tControl.text2 = System_Date()
                            Case "System_Date_time"
                                tControl.text2 = System_Date_time()
                            Case "System_Date_8"
                                tControl.text2 = System_Date_8()
                            Case "System_Date_6"
                                tControl.text2 = System_Date_6()
                            Case Else
                                tControl.text2 = System_Date_8()
                        End Select

                        item.Control = tControl

                    Case "3" 'SelectPeaceCalSin
                        Dim item As New DevExpress.XtraLayout.LayoutControlItem
                        item.Name = RS01!K9706_ControlName
                        item.Text = RS01!K9706_ControlName
                        item.TextVisible = False

                        LayoutControl.HiddenItems.AddRange({item})

                        Dim tControl As New SelectPeaceCalSin
                        tControl.Name = RS01!K9706_ControlName
                        tControl.ButtonTitle = RS01!K9706_ControlData1

                        Select Case RS01!K9706_DefaultValue1
                            Case "System_Date"
                                tControl.Data = System_Date()
                            Case "System_Date_time"
                                tControl.Data = System_Date_time()
                            Case "System_Date_8"
                                tControl.Data = System_Date_8()
                            Case "System_Date_6"
                                tControl.Data = System_Date_6()
                            Case Else
                                tControl.Data = System_Date_8()
                        End Select

                        item.Control = tControl

                    Case "4" 'SelectPeaceHLPButton
                        Dim item As New DevExpress.XtraLayout.LayoutControlItem
                        item.Name = RS01!K9706_ControlName
                        item.Text = RS01!K9706_ControlName
                        item.TextVisible = False

                        LayoutControl.HiddenItems.AddRange({item})

                        Dim tControl As New SelectPeaceHLPButton
                        tControl.Name = RS01!K9706_ControlName
                        tControl.ButtonTitle = RS01!K9706_ControlData1
                        tControl.ButtonName = RS01!K9706_DefaultValue1

                        item.Control = tControl

                    Case "5" 'SelectLabelText
                        Dim item As New DevExpress.XtraLayout.LayoutControlItem
                        item.Name = RS01!K9706_ControlName
                        item.Text = RS01!K9706_ControlName
                        item.TextVisible = False

                        LayoutControl.HiddenItems.AddRange({item})

                        Dim tControl As New SelectLabelText
                        tControl.Name = RS01!K9706_ControlName
                        tControl.LableTitle = RS01!K9706_ControlData1

                        item.Control = tControl

                    Case Else
                        Dim item As New DevExpress.XtraLayout.LayoutControlItem
                        item.Name = RS01!K9706_ControlName
                        item.Text = RS01!K9706_ControlName
                        item.TextVisible = False

                        LayoutControl.HiddenItems.AddRange({item})

                        Dim tControl As New SelectLabelText
                        tControl.Name = RS01!K9706_ControlName
                        tControl.ButtonTitle = RS01!K9706_ControlData1
                        tControl.Data = RS01!K9706_DefaultValue1
                        tControl.Code = RS01!K9706_DefaultValue2

                        item.Control = tControl
                End Select

            Next

        Catch ex As Exception

        Finally
            LayoutControl.EndUpdate()
        End Try

    End Sub
#End Region

End Module
