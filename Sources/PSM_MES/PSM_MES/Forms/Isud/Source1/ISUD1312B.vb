Imports System.Net.Mail
Imports System.Text
Imports System.IO.Ports

Public Class ISUD1312B

#Region "Variable"
    'Private wJOB As Integer
    Private W7106 As T7106_AREA

    Private W0102 As New T0102_AREA

    Private W1311 As New T1311_AREA
    Private L1311 As New T1311_AREA

    Private W1312 As New T1312_AREA
    Private L1312 As New T1312_AREA

    Private W1313 As New T1313_AREA
    Private L1313 As New T1313_AREA

    Private W1314 As New T1314_AREA
    Private L1314 As New T1314_AREA

    Private W1315 As New T1315_AREA
    Private L1315 As New T1315_AREA

    Private W1316 As New T1316_AREA
    Private L1316 As New T1316_AREA

    Private W7156 As New T7156_AREA
    Private W7104 As New T7104_AREA

    Private W0111 As T0111_AREA
    Private L0111 As T0111_AREA

    Private WRITE_CHK As String
    Private ImportTax As Decimal
    Private EnvironmentTax As Decimal
    Private VatTax As Decimal
    Private formA As Boolean
    Private CHK(0 To 5) As String

    Private sizeInfo As Boolean = False
    Private specInfo As Boolean = False
    Private schedulaInfo As Boolean = False
    Private remarkInfo As Boolean = False

    Private OrderNoSeq As String = ""

    Private Schedula As String = ""

    Private Link_W1311 As T1311_AREA
    Private Link_W1312 As List(Of T1312_AREA)

    Dim rowList As Integer
    Dim rowChk As Integer
    Dim List1312KW As New List(Of T1312_AREA)

#End Region

#Region "Link"
    Public Function Link_ISUD1312B(job As Integer, OrderNo As String, OrderNoSeq As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D1312.OrderNo = OrderNo
        D1312.OrderNoSeq = OrderNoSeq

        wJOB = job : L1311 = D1311

        Link_ISUD1312B = False
        Try

            Select Case job
                Case 1, 11


                Case Else


            End Select


            formA = False
            Me.ShowDialog()
            Application.DoEvents()
            Cursor = Cursors.Default

            Link_ISUD1312B = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try

    End Function
    Private Check_AutoLink As Boolean = False
    Private str_AutoLink As String
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_KeyDown()

        Call DATA_INIT()
        Call FORM_INIT()

        If GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5)) = False Then
            isudCHK = False
            Me.Dispose()
            formA = True

            Call MsgBoxP("You have no right is this program !")
            Exit Sub
        End If

        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"

                tst_iDelete.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                txt_DateSRD1.Data = Pub.DAT


            Case 2
                Me.Text = Me.Text & " - SEARCH"

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If


                Call DATA_SEARCH01()

                tst_iDelete.Visible = False
                tst_iSave.Visible = False


            Case 3
                Me.Text = Me.Text & " - UPDATE"

                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                End If


                Call DATA_SEARCH01()

                tst_iDelete.Visible = False

            Case 4
                Me.Text = Me.Text & " - DELETE"

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                tst_iDelete.Visible = True
                tst_iSave.Visible = False

        End Select

        formA = True
    End Sub

    Private Sub DATA_INIT()
        Try
   
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try
    End Sub

    Private Sub FORM_INIT()

        Me.chk_Attach = False
    End Sub

#End Region

#Region "Search"

    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Try
            DS1 = READ_PFK1312(L1312.OrderNo, L1312.OrderNoSeq, cn)

            If GetDsRc(DS1) = 0 Then
                Exit Function
                isudCHK = False
            End If

            READER_MOVE(Me, DS1)

            DATA_SEARCH01 = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH01")
        End Try

    End Function



#End Region

#Region "Function"
    Private Sub DATA_MOVE_DEFAULT()
        Try

         
        Catch ex As Exception
            Call Error_Message("62", "DATA_MOVE_DEFAULT")
        End Try

    End Sub
    Private Function DATA_MOVE_WRITE01() As Boolean
     
    End Function
    Private Sub DATA_INSERT()
        Try
            Call PrcExeNoError("USP_PFK1312_UPDATE_RND_PROCESS", cn, L1312.OrderNo, L1312.OrderNoSeq, txt_InchargeRD1.Code, txt_InchargeRD2.Code, txt_InchargeRD3.Code, txt_InchargeRD4.Code, _
                                txt_DateSRD1.Data, txt_DateERD1.Data, txt_DateSRD2.Data, txt_DateERD2.Data, _
                                txt_DateSRD3.Data, txt_DateERD3.Data, txt_DateSRD4.Data, txt_DateERD4.Data)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub DATA_UPDATE()
        Try


        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub
    Private Sub DATA_DELETE()
       

    End Sub

   

#End Region


    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Try
            Select Case wJOB
                Case 1

                    Call DATA_INSERT()

                Case 2
                    Me.Dispose()
                Case 3
                    Call DATA_UPDATE()
                    isudCHK = True
                    Me.Dispose()

                Case 4
            End Select
        Catch ex As Exception
            MsgBoxP("tst_iSave_Click")
        End Try

    End Sub
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles tst_iClose.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub
    Private Sub tst_iDelete_Click(sender As Object, e As EventArgs) Handles tst_iDelete.Click

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "tst_iDelete_Click")
            Exit Sub
        End If

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub
        Try
            Call DATA_DELETE()
        Catch ex As Exception
            MsgBoxP("tst_iDelete_Click")
        End Try

    End Sub






End Class