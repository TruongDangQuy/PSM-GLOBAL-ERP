Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.ComponentModel

Public Class PeaceButton
    'Inherits PSMGlobal.PeaceButton
    Inherits DevExpress.XtraEditors.SimpleButton

    Private FontOri As Font
    Private m_Data As New DATASPACE

    Private m_ButtonTitle As String


    Public Property ButtonTitle() As String
        Get
            Return m_ButtonTitle
        End Get
        Set(ByVal Value As String)
            m_ButtonTitle = Value
            Me.Text = Value
        End Set
    End Property

    Public Property UseVisualStyleBackColor As Boolean
    Public Property ImageAlign As Integer

    Public Property Code() As String
        Get
            Return m_Data.CODE
        End Get
        Set(ByVal Value As String)

            m_Data.CODE = Value
            Me.Tag = Value

        End Set
    End Property
    Public Property Data() As String
        Get
            Return m_Data.NAME
        End Get
        Set(ByVal Value As String)

            m_Data.NAME = Value
            Me.Text = Value

        End Set
    End Property
    Public Sub New()
        InitializeComponent()
        Me.Font = New Font("Tahoma", 9, FontStyle.Bold)
        Me.Size = New Size(138, 30)
        Me.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.Appearance.BackColor = Color.White
    End Sub

    Private Sub PeaceButton_Click(sender As Object, e As EventArgs) Handles Me.Click
        Try
            If Me.Name.ToUpper.Contains("BTN") Or Me.Name.ToUpper.Contains("CMD") Then
                D9700_CLEAR()
                D9700.ActionName = wJOB & Me.Name
                D9700.DateCreate = Pub.DAT
                D9700.UserCode = Pub.SAW
                D9700.FormName = Me.FindForm.Name
                D9700.Reference = getPrimaryKey(Me.FindForm)

                D9700.DeviceName = R9700.DeviceName
                D9700.MACAddress = R9700.MACAddress
                D9700.IPv4Address = R9700.IPv4Address
                D9700.DHCPServer = R9700.DHCPServer
                D9700.IPWan = R9700.IPWan

                D9700.DNSdomain = R9700.DNSdomain
                D9700.DHCPServer = R9700.DHCPServer

                D9700.HDDSerialNo = R9700.HDDSerialNo
                D9700.ComputerName = R9700.ComputerName
                D9700.AccountWin = R9700.AccountWin

                D9700.UserCode = Pub.SAW
                D9700.DateTimeCreate = System_Date_time()

                Call WRITE_PFK9700(D9700)
            End If

            If Me.Name = "cmd_OK" Then
                DS1 = PrcDS("EXP_CLOSSING_TABLE", cn, Me.FindForm.Name)
                If GetDsRc(DS1) > 0 Then
                    Dim i As Integer
                    Dim Arr_String As New List(Of String)

                    For i = 0 To GetDsRc(DS1) - 1
                        Arr_String.Add(Me.FindForm.FindCodeExactily(DS1.Tables(0).Rows(i).Item(1)).Data)
                    Next

                    Call PrcExeNoError(GetDsData(DS1, 0, 0), cn, Arr_String.ToArray)

                End If


                Exit Sub
            End If


            If Me.Name = "btn_Exit" Then
                Dim i As Object
                i = CType(Me.FindForm, Form)
                i.close()
                Exit Sub

            ElseIf Me.Name = "cmd_AttachID" Then
                Dim i As PeaceForm
                i = CType(Me.FindForm, PeaceForm)

                If i.chk_Attach = False Then Exit Sub
                If ISUD7555A.Link_ISUD7555A(3, Me.FindForm.Name, getPrimaryKey(Me.FindForm)) = False Then Exit Sub


            ElseIf Me.Name.ToUpper = "CMD_PRINT" Or Me.Name.ToUpper = "BTN_PRINT" Or Me.Name.ToUpper = "CMDSPREADPRINT" Then
                Dim f As New Form
                f = Me.FindForm

                Pub.CLI = "1"

                If f.Tag = "" Then f.Tag = f.Name

                If READ_FROM_MULTI(f.Tag) Then Pub.CLI = "2"

                If Pub.CLI = "1" Then
                    If Not f.Tag Is Nothing Then
                        If READ_SHEETPRINT_MATCHING(f.Tag) = True Then
                            If SheetReport.Link_SheetReport(3, f.Tag, f) = True Then

                                If READ_SHEETPRINT_MATCHING_MULTI(f.Tag, SheetReportName) = True Then
                                    ChuoiValue1 = ""
                                    ChuoiValue2 = ""

                                    If PRINTSHEET_MULTI.Link_PrintSheet(SheetReportName, ChuoiValue1, ChuoiValue2, f) = True Then
                                    End If
                                Else
                                    ChuoiValue1 = ""
                                    ChuoiValue2 = ""

                                    If GETCHUOI1(ChuoiValue1, SheetReportName) = False Then Exit Sub

                                    If GETCHUOI2_01(f, ChuoiValue2, SheetReportName, ChuoiValue1) = False Then Exit Sub

                                    If PRINTSHEET.Link_PrintSheet(SheetReportName, ChuoiValue1, ChuoiValue2) = True Then

                                    End If
                                End If
                            End If
                        Else

                        End If
                    Else

                    End If

                ElseIf Pub.CLI = "2" Then
                    If PRINTSHEET_NEW_F1.Link_SheetReport(3, f.Tag, f) = True Then

                    End If
                End If
            End If

        Catch ex As Exception
            MsgBoxP("No data !", vbInformation)
        End Try
    End Sub

   

End Class
