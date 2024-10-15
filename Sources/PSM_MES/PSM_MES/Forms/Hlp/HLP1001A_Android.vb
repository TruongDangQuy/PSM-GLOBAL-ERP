Public Class HLP1001A_Android

#Region "Variable"
    Public Posion As String = ""
    Public NameStoredProcedure As String = ""

    Public StoredProcedureFielName As String = ""
    Public TypePrint As String = ""
    Public TypeFace As String = ""
    Public TypeAlignment As String = ""
    Public CntLineEnter As String = ""

    Public CntTextFontSize As String = ""
    Public TypeTextFontBold As String = ""
    Public TypeTextUnderLine As String = ""

    Public CntBarSymbology As String = ""
    Public CntBarHeight As String = ""
    Public CntBarWidth As String = ""
    Public CntBarTextposition As String = ""

    Public CntQRModulesize As String = ""
    Public CntQRErrorlevel As String = ""
    Public Content As String = ""
#End Region

#Region "Link"
    Public Function Link_HLP1001A_Android(Posion As String, NameStoredProcedure As String, StoredProcedureFielName As String,
                                          TypePrint As String, TypeFace As String, TypeAlignment As String, CntLineEnter As String,
                                          CntTextFontSize As String, TypeTextFontBold As String, TypeTextUnderLine As String,
                                          CntBarSymbology As String, CntBarHeight As String, CntBarWidth As String,
                                          CntBarTextposition As String, CntQRModulesize As String, CntQRErrorlevel As String,
                                          Content As String) As Boolean
        Link_HLP1001A_Android = False
        Try
            Me.Posion = Posion
            Me.NameStoredProcedure = NameStoredProcedure

            Me.StoredProcedureFielName = StoredProcedureFielName
            Me.TypePrint = TypePrint
            Me.TypeFace = TypeFace
            Me.TypeAlignment = TypeAlignment
            Me.CntLineEnter = CntLineEnter

            Me.CntTextFontSize = CntTextFontSize
            Me.TypeTextFontBold = TypeTextFontBold
            Me.TypeTextUnderLine = TypeTextUnderLine

            Me.CntBarSymbology = CntBarSymbology
            Me.CntBarHeight = CntBarHeight
            Me.CntBarWidth = CntBarWidth
            Me.CntBarTextposition = CntBarTextposition

            Me.CntQRModulesize = CntQRModulesize
            Me.CntQRErrorlevel = CntQRErrorlevel
            Me.Content = Content
            Array_hlp0000SeVaTt.Clear()

            Me.ShowDialog()

            Link_HLP1001A_Android = hlpCHK
        Catch ex As Exception

        End Try

    End Function

#End Region


#Region "Form_Load"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        Try
            DATA_INIT()
            FORM_INIT()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Me_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            If Me.Width > 30 Then
                ItemMain.ItemSize = New Size((Me.Width - 30) / ItemMain.TabCount, 25)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DATA_INIT()
        Try
            getData01()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FORM_INIT()
        Try

        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Function"
    Private Sub SetTypePrint(typePrint As String)
        Try
            Select Case typePrint
                Case "1"
                    rad_TypePrint1.Checked = True
                    rad_TypePrint2.Checked = False
                    rad_TypePrint3.Checked = False
                Case "2"
                    rad_TypePrint1.Checked = False
                    rad_TypePrint2.Checked = True
                    rad_TypePrint3.Checked = False
                Case "3"
                    rad_TypePrint1.Checked = False
                    rad_TypePrint2.Checked = False
                    rad_TypePrint3.Checked = True
                Case Else
                    rad_TypePrint1.Checked = False
                    rad_TypePrint2.Checked = False
                    rad_TypePrint3.Checked = True
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Function getTypePrint() As String
        getTypePrint = "3"
        Try
            If rad_TypePrint1.Checked = True Then getTypePrint = "1"
            If rad_TypePrint2.Checked = True Then getTypePrint = "2"
            If rad_TypePrint3.Checked = True Then getTypePrint = "3"

        Catch ex As Exception

        End Try
    End Function

    Private Sub setAlignment(alignment As String)
        Try
            Select Case alignment
                Case "0"
                    rad_Alignment0.Checked = True
                    rad_Alignment1.Checked = False
                    rad_Alignment2.Checked = False
                Case "1"
                    rad_Alignment0.Checked = False
                    rad_Alignment1.Checked = True
                    rad_Alignment2.Checked = False
                Case "2"
                    rad_Alignment0.Checked = False
                    rad_Alignment1.Checked = False
                    rad_Alignment2.Checked = True
                Case Else
                    rad_Alignment0.Checked = True
                    rad_Alignment1.Checked = False
                    rad_Alignment2.Checked = False
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Function getAlignment() As String
        getAlignment = "0"
        Try
            If rad_Alignment0.Checked = True Then getAlignment = "0"
            If rad_Alignment1.Checked = True Then getAlignment = "1"
            If rad_Alignment2.Checked = True Then getAlignment = "2"

        Catch ex As Exception

        End Try
    End Function

    Private Sub setTypeTextFontBold(typeTextFontBold As String)
        Try
            Select Case typeTextFontBold
                Case "1"
                    rad_TypeTextFontBold1.Checked = True
                    rad_TypeTextFontBold2.Checked = False
                Case "2"
                    rad_TypeTextFontBold1.Checked = False
                    rad_TypeTextFontBold2.Checked = True
                Case Else
                    rad_TypeTextFontBold1.Checked = False
                    rad_TypeTextFontBold2.Checked = True
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Function getTypeTextFontBold() As String
        getTypeTextFontBold = "2"
        Try
            If rad_TypeTextFontBold1.Checked = True Then getTypeTextFontBold = "1"
            If rad_TypeTextFontBold2.Checked = True Then getTypeTextFontBold = "2"

        Catch ex As Exception

        End Try
    End Function

    Private Sub setTypeTextUnderLine(TypeTextUnderLine As String)
        Try
            Select Case TypeTextUnderLine
                Case "1"
                    rad_TypeTextUnderLine1.Checked = True
                    rad_TypeTextUnderLine2.Checked = False
                Case "2"
                    rad_TypeTextUnderLine1.Checked = False
                    rad_TypeTextUnderLine2.Checked = True
                Case Else
                    rad_TypeTextUnderLine1.Checked = False
                    rad_TypeTextUnderLine2.Checked = True
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Function getTypeTextUnderLine() As String
        getTypeTextUnderLine = "2"
        Try
            If rad_TypeTextUnderLine1.Checked = True Then getTypeTextUnderLine = "1"
            If rad_TypeTextUnderLine2.Checked = True Then getTypeTextUnderLine = "2"

        Catch ex As Exception

        End Try
    End Function

    Private Sub getData01()
        Try

            lbl_TitleaName.Text = String.Format("FontName: {0}, FielName: {0}", TypeFace, StoredProcedureFielName)

            ncd_CntLineEnter.Value = Integer.Parse(Me.CntLineEnter)
            ncd_Posion.Value = Integer.Parse(Me.Posion)

            setAlignment(Me.TypeAlignment)
            SetTypePrint(Me.TypePrint)

            Select Case Me.TypePrint
                Case "1"
                    Me.CntBarSymbology = "4"
                    Me.CntBarHeight = "162"
                    Me.CntBarWidth = "2"
                    Me.CntBarTextposition = "0"

                    Me.CntTextFontSize = "12"
                    Me.TypeTextFontBold = "2"
                    Me.TypeTextUnderLine = "2"

                    ItemMain.SelectedIndex = 0
                    PanelQRCode.Enabled = True
                    PanelBarcode.Enabled = False
                    PanelText.Enabled = False

                Case "2"
                    Me.CntQRModulesize = "1"
                    Me.CntQRErrorlevel = "0"

                    Me.CntTextFontSize = "12"
                    Me.TypeTextFontBold = "2"
                    Me.TypeTextUnderLine = "2"

                    ItemMain.SelectedIndex = 1
                    PanelQRCode.Enabled = False
                    PanelBarcode.Enabled = True
                    PanelText.Enabled = False

                Case "3"
                    Me.CntQRModulesize = "1"
                    Me.CntQRErrorlevel = "0"

                    Me.CntBarSymbology = "4"
                    Me.CntBarHeight = "162"
                    Me.CntBarWidth = "2"
                    Me.CntBarTextposition = "0"

                    ItemMain.SelectedIndex = 2
                    PanelQRCode.Enabled = False
                    PanelBarcode.Enabled = False
                    PanelText.Enabled = True

                Case Else
                    Me.CntQRModulesize = "1"
                    Me.CntQRErrorlevel = "0"

                    Me.CntBarSymbology = "4"
                    Me.CntBarHeight = "162"
                    Me.CntBarWidth = "2"
                    Me.CntBarTextposition = "0"

                    ItemMain.SelectedIndex = 2
                    PanelQRCode.Enabled = False
                    PanelBarcode.Enabled = False
                    PanelText.Enabled = True

            End Select

            ncd_CntQRModulesize.Value = Integer.Parse(Me.CntQRModulesize)
            cbx_CntQRErrorlevel.SelectedIndex = Integer.Parse(Me.CntQRErrorlevel)

            cbx_CntBarSymbology.SelectedIndex = Integer.Parse(Me.CntBarSymbology)
            ncd_CntBarHeight.Value = Integer.Parse(Me.CntBarHeight)
            ncd_CntBarWidth.Value = Integer.Parse(Me.CntBarWidth)
            cbx_CntBarTextposition.SelectedIndex = Integer.Parse(Me.CntBarTextposition)

            ncd_CntTextFontSize.Value = Integer.Parse(Me.CntTextFontSize)
            setTypeTextFontBold(Me.TypeTextFontBold)
            setTypeTextUnderLine(Me.TypeTextUnderLine)

            txt_Content.Data = Me.Content

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SetData01()
        Try

            Me.CntLineEnter = ncd_CntLineEnter.Value.ToString.Trim
            Me.Posion = ncd_Posion.Value.ToString.Trim

            Me.TypeAlignment = getAlignment()
            Me.TypePrint = getTypePrint()

            Me.CntQRModulesize = ncd_CntQRModulesize.Value.ToString.Trim
            Me.CntQRErrorlevel = cbx_CntQRErrorlevel.SelectedIndex.ToString.Trim

            Me.CntBarSymbology = cbx_CntBarSymbology.SelectedIndex.ToString.Trim
            Me.CntBarHeight = ncd_CntBarHeight.Value.ToString.Trim
            Me.CntBarWidth = ncd_CntBarWidth.Value.ToString.Trim
            Me.CntBarTextposition = cbx_CntBarTextposition.SelectedIndex.ToString.Trim

            Me.CntTextFontSize = ncd_CntTextFontSize.Value.ToString.Trim
            Me.TypeTextFontBold = getTypeTextFontBold()
            Me.TypeTextUnderLine = getTypeTextUnderLine()

            Select Case Me.TypePrint
                Case "1"
                    Me.CntBarSymbology = "0"
                    Me.CntBarHeight = "0"
                    Me.CntBarWidth = "0"
                    Me.CntBarTextposition = "0"

                    Me.CntTextFontSize = "0"
                    Me.TypeTextFontBold = "0"
                    Me.TypeTextUnderLine = "0"
                Case "2"
                    Me.CntQRModulesize = "0"
                    Me.CntQRErrorlevel = "0"

                    Me.CntTextFontSize = "0"
                    Me.TypeTextFontBold = "0"
                    Me.TypeTextUnderLine = "0"
                Case "3"
                    Me.CntQRModulesize = "0"
                    Me.CntQRErrorlevel = "0"

                    Me.CntBarSymbology = "0"
                    Me.CntBarHeight = "0"
                    Me.CntBarWidth = "0"
                    Me.CntBarTextposition = "0"
                Case Else
                    Me.CntQRModulesize = "0"
                    Me.CntQRErrorlevel = "0"

                    Me.CntBarSymbology = "0"
                    Me.CntBarHeight = "0"
                    Me.CntBarWidth = "0"
                    Me.CntBarTextposition = "0"
            End Select

            Me.Content = txt_Content.Data

            Array_hlp0000SeVaTt.Clear()

            Array_hlp0000SeVaTt.Add(Me.Posion)

            Array_hlp0000SeVaTt.Add(Me.TypePrint)
            Array_hlp0000SeVaTt.Add(Me.TypeAlignment)
            Array_hlp0000SeVaTt.Add(Me.CntLineEnter)

            Array_hlp0000SeVaTt.Add(Me.CntTextFontSize)
            Array_hlp0000SeVaTt.Add(Me.TypeTextFontBold)
            Array_hlp0000SeVaTt.Add(Me.TypeTextUnderLine)

            Array_hlp0000SeVaTt.Add(Me.CntBarSymbology)
            Array_hlp0000SeVaTt.Add(Me.CntBarHeight)
            Array_hlp0000SeVaTt.Add(Me.CntBarWidth)
            Array_hlp0000SeVaTt.Add(Me.CntBarTextposition)

            Array_hlp0000SeVaTt.Add(Me.CntQRModulesize)
            Array_hlp0000SeVaTt.Add(Me.CntQRErrorlevel)
            Array_hlp0000SeVaTt.Add(Me.Content)



        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Events"
    Private Sub cmd_SaveForm_Click(sender As Object, e As EventArgs) Handles cmd_SaveForm.Click
        Try
            SetData01()
            hlpCHK = True
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rad_TypePrint_CheckedChanged(sender As Object, e As EventArgs) Handles rad_TypePrint3.CheckedChanged, rad_TypePrint2.CheckedChanged, rad_TypePrint1.CheckedChanged
        If sender.Equals(rad_TypePrint1) Then
            ItemMain.SelectedIndex = 0
            PanelQRCode.Enabled = True
            PanelBarcode.Enabled = False
            PanelText.Enabled = False
        End If
        If sender.Equals(rad_TypePrint2) Then
            ItemMain.SelectedIndex = 1
            PanelQRCode.Enabled = False
            PanelBarcode.Enabled = True
            PanelText.Enabled = False
        End If
        If sender.Equals(rad_TypePrint3) Then
            ItemMain.SelectedIndex = 2
            PanelQRCode.Enabled = False
            PanelBarcode.Enabled = False
            PanelText.Enabled = True
        End If
    End Sub

#End Region

    
End Class