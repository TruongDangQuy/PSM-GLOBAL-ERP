Imports DevExpress.Pdf

Imports System.Drawing

Public Class ISUD1340U
#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String

    Enum colVS1


        intc_PONO = 0
        intc_ArticleNo = 1
        intc_ItemName = 2
        intc_SL = 3
        intc_TYPE = 4
        intc_Rcv_Date = 5
        intc_Orig_Date = 6
        intc_Plan_Date = 7
        intc_IKEA_WEEK = 8
        intc_ACTUAL_WEEK = 9
        intc_ORIGNAL_QTY = 10
        intc_ORDER_QTY = 11
        intc_DEVIATION_QTY = 12
        intc_PRICE = 13
        intc_VALUE = 14
        intc_Gross_WEIGHT = 15
        intc_Gross_VOLUME = 16
        intc_PALLET = 17
        intc_RECEIVER = 18
        intc_END_RECEIVER = 19
        intc_CSM_INVOICE = 20
        intc_DISPATCH_DATE = 21
        intc_DSTP = 22
        intc_SEQUENCE = 23
        intc_REMARK = 24
        intc_REMARK2 = 25

    End Enum

#End Region

#Region "Link"
    Public Function Link_ISUD1340U(job As Integer, strKey As String) As Boolean
        Me.Tag = Tag
        Link_ISUD1340U = False

        txt_WeekNO.Data = strKey

        Try
            formA = False
            Me.ShowDialog()

            Link_ISUD1340U = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("ProcessBOMCode"))
        End Try


    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_KeyDown()

        Call DATA_INIT()
        Call FORM_INIT()

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Try

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()

    End Sub
#End Region

#Region "Data_Search"

#End Region

#Region "Function"

#End Region

#Region "Event"
   
    Private Sub KEY_COUNT()


    End Sub


    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Try
            Call system_as_date()

            Dim xrow As Integer
            Dim WeekNO As String
            Dim PONO As String
            Dim ArticleNo As String
            Dim ItemName As String
            Dim SL As String
            Dim TYPE As String
            Dim Rcv_Date As String
            Dim Orig_Date As String
            Dim Plan_Date As String
            Dim IKEA_WEEK As String
            Dim ACTUAL_WEEK As String
            Dim ORIGNAL_QTY As String
            Dim ORDER_QTY As String
            Dim DEVIATION_QTY As String
            Dim PRICE As String
            Dim VALUE As String
            Dim Gross_WEIGHT As String
            Dim Gross_VOLUME As String
            Dim PALLET As String
            Dim RECEIVER As String
            Dim END_RECEIVER As String
            Dim CSM_INVOICE As String
            Dim DISPATCH_DATE As String
            Dim DSTP As String
            Dim SEQUENCE As String
            Dim REMARK As String
            Dim REMARK2 As String
            Dim DateInsert As String
            Dim InchargeInsert As String
            Dim TimeInsert As String

            Dim strResult As String

            For xrow = NumericUpDown1.Value To NumericUpDown2.Value - 1
                WeekNO = txt_WeekNO.Data

                PONO = getData(Vs1, colVS1.intc_PONO, xrow)
                ArticleNo = getData(Vs1, colVS1.intc_ArticleNo, xrow)
                ItemName = getData(Vs1, colVS1.intc_ItemName, xrow)
                SL = getData(Vs1, colVS1.intc_SL, xrow)
                TYPE = getData(Vs1, colVS1.intc_TYPE, xrow)
                Rcv_Date = getData(Vs1, colVS1.intc_Rcv_Date, xrow)
                Orig_Date = getData(Vs1, colVS1.intc_Orig_Date, xrow)
                Plan_Date = getData(Vs1, colVS1.intc_Plan_Date, xrow)
                IKEA_WEEK = getData(Vs1, colVS1.intc_IKEA_WEEK, xrow)
                ACTUAL_WEEK = getData(Vs1, colVS1.intc_ACTUAL_WEEK, xrow)
                ORIGNAL_QTY = CDecp(getData(Vs1, colVS1.intc_ORIGNAL_QTY, xrow))
                ORDER_QTY = CDecp(getData(Vs1, colVS1.intc_ORDER_QTY, xrow))
                DEVIATION_QTY = CDecp(getData(Vs1, colVS1.intc_DEVIATION_QTY, xrow))
                PRICE = CDecp(getData(Vs1, colVS1.intc_PRICE, xrow))
                VALUE = CDecp(getData(Vs1, colVS1.intc_VALUE, xrow))
                Gross_WEIGHT = CDecp(getData(Vs1, colVS1.intc_Gross_WEIGHT, xrow))
                Gross_VOLUME = CDecp(getData(Vs1, colVS1.intc_Gross_VOLUME, xrow))
                PALLET = CDecp(getData(Vs1, colVS1.intc_PALLET, xrow))
                RECEIVER = getData(Vs1, colVS1.intc_RECEIVER, xrow)
                END_RECEIVER = getData(Vs1, colVS1.intc_END_RECEIVER, xrow)
                CSM_INVOICE = getData(Vs1, colVS1.intc_CSM_INVOICE, xrow)
                DISPATCH_DATE = getData(Vs1, colVS1.intc_DISPATCH_DATE, xrow)
                DSTP = getData(Vs1, colVS1.intc_DSTP, xrow)
                SEQUENCE = getData(Vs1, colVS1.intc_SEQUENCE, xrow)
                REMARK = getData(Vs1, colVS1.intc_REMARK, xrow)
                REMARK2 = getData(Vs1, colVS1.intc_REMARK2, xrow)

                DateInsert = Pub.DAT
                InchargeInsert = Pub.SAW
                TimeInsert = Pub.TIM


                strResult = PrcExeNoError_Value("USP_PFL13405_INSERT_WEEKNO", cn _
                 , WeekNO _
                 , FormatSQL(PONO) _
                 , FormatSQL(ArticleNo) _
                 , FormatSQL(ItemName) _
                 , SL _
                 , TYPE _
                 , Rcv_Date _
                 , Orig_Date _
                 , Plan_Date _
                 , IKEA_WEEK _
                 , ACTUAL_WEEK _
                 , ORIGNAL_QTY _
                 , ORDER_QTY _
                 , DEVIATION_QTY _
                 , PRICE _
                 , VALUE _
                 , Gross_WEIGHT _
                 , Gross_VOLUME _
                 , PALLET _
                 , RECEIVER _
                 , END_RECEIVER _
                 , FormatSQL(CSM_INVOICE) _
                 , DISPATCH_DATE _
                 , DSTP _
                 , SEQUENCE _
                 , FormatSQL(REMARK) _
                 , FormatSQL(REMARK2) _
                   , DateInsert _
                 , InchargeInsert _
                 , TimeInsert)


                If strResult = "1" Then
                   
                Else
                    SPR_BACKCOLOR(Vs1, Color.Red, xrow)
                    MsgBoxP("Failure to upload !")
                    Call PrcExeNoError("USP_PFL13405_DELETE_WEEKNO", cn, txt_WeekNO.Data)
                    Exit Sub

                End If

            Next
            Call PrcExeNoError("USP_PFL13405_CLOSSING", cn, txt_WeekNO.Data)
            MsgBoxP("Succeed to upload !", vbInformation)
        Catch ex As Exception

        End Try
        Me.Dispose()
    End Sub

    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub
    Private Function GetOpenFileDialog() As OpenFileDialog

        Dim openFileDialog As New OpenFileDialog

        openFileDialog.CheckFileExists = True
        openFileDialog.Multiselect = False
        openFileDialog.AddExtension = True
        openFileDialog.ValidateNames = True
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        Return openFileDialog


    End Function

#End Region

   

    Private Sub cmd_Upload_Click(sender As Object, e As EventArgs) Handles cmd_Upload.Click
        Try

            Using OpenFileDialog As OpenFileDialog = Me.GetOpenFileDialog()


                If (OpenFileDialog.ShowDialog(Me) = DialogResult.OK) Then
                    If IO.Path.GetExtension(OpenFileDialog.FileName).ToUpper.Contains("XLS") Then
                        Vs1.Reset()

                        Vs1.OpenExcel(OpenFileDialog.FileName)


                    End If



                Else 'Cancel

                    Exit Sub

                End If

            End Using


        Catch ex As Exception

        End Try
    End Sub
End Class