Imports EASendMail
Imports System.Data
Imports System.Text
Imports System.Configuration
Module M_Mail

#Region "Variable"

#End Region

#Region "Methods"
    Public Sub SendMail()
        Pub.DAT = System_Date_Add(0, -1)

        Dim oMail As New SmtpMail("TryIt")
        Dim oSmtp As New SmtpClient()
        ' Your gmail email address
        oMail.From = "nnkhanhhung@gmail.com"

        ' Set recipient email address, please change it to yours
        oMail.To = "director@psmvn.com"

        'oMail.To = "yc.cho@sh-group.biz; wy.hwang@sh-group.biz;sy.jung@sh-group.biz;shlee@sh-group.biz;ydhwang@sh-group.biz"
        'oMail.Cc = "president@psmvn.com;director@psmvn.com"

        ' Set email subject
        oMail.Subject = "Daily Production R & D " & FSDate(Pub.DAT) & " [ Send at : " & FSDateTime(System_Date_time()) & " ]"

        ' Set email body

        Dim html As New StringBuilder()

        'Table start.
        html.Append("**************************************************************")
        html.Append("<br></br>")
        html.Append("This is an automatically generated E-mail, please do NOT reply")
        html.Append("<br></br>")
        html.Append("**************************************************************")

        html.Append("<h1> 1. R & D PRODUCTION BY PROCESS-LINE </h1>")
        html.Append("<table border = '3'>")

        DS1 = PrcDS("USPM_PFP01600_SEARCH_VS10", cn, "050", Pub.DAT)

        'Building the Header row.
        html.Append("<tr style='background-color: #201677;color:white' >")
        For Each column As DataColumn In DS1.Tables(0).Columns
            html.Append("<th>")
            html.Append(column.ColumnName)
            html.Append("</th>")
        Next
        html.Append("</tr>")

        'Building the Data rows.
        For Each row As DataRow In DS1.Tables(0).Rows
            'html.Append("<tr>")
            If row.Item("CHK") = "TOTAL" Then
                html.Append("<tr style='background-color: yellow;color:black' >")
            Else
                html.Append("<tr>")
            End If

            For Each column As DataColumn In DS1.Tables(0).Columns
                html.Append("<td>")
                html.Append(row(column.ColumnName))
                html.Append("</td>")
            Next

            html.Append("</tr>")
        Next

        'Table end.
        html.Append("</table>")
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Table start.
        html.Append("<h1> 2. R & D PRODUCTION BY TOTAL </h1>")
        html.Append("<table border = '3'>")

        DS1 = PrcDS("USPM_PFP01600_SEARCH_VS20", cn, "050", Pub.DAT)

        'Building the Header row.
        html.Append("<tr style='background-color: #201677;color:white' >")
        For Each column As DataColumn In DS1.Tables(0).Columns
            html.Append("<th>")
            html.Append(column.ColumnName)
            html.Append("</th>")
        Next
        html.Append("</tr>")

        'Building the Data rows.
        For Each row As DataRow In DS1.Tables(0).Rows
            If row.Item("CHK") = "TOTAL" Then
                html.Append("<tr style='background-color: yellow;color:black' >")
            Else
                html.Append("<tr>")
            End If

            For Each column As DataColumn In DS1.Tables(0).Columns
                html.Append("<td>")
                html.Append(row(column.ColumnName))
                html.Append("</td>")
            Next


            html.Append("</tr>")
        Next

        'Table end.
        html.Append("</table>")
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Table start.
        html.Append("<h1> 3. R & D PRODUCTION BY TIME </h1>")
        html.Append("<table border = '3'>")

        DS1 = PrcDS("USPM_PFP01600_SEARCH_VS30", cn, "050", Pub.DAT)

        'Building the Header row.
        html.Append("<tr style='background-color: #201677;color:white' >")
        For Each column As DataColumn In DS1.Tables(0).Columns
            html.Append("<th>")
            html.Append(column.ColumnName)
            html.Append("</th>")
        Next
        html.Append("</tr>")

        'Building the Data rows.
        For Each row As DataRow In DS1.Tables(0).Rows
            'html.Append("<tr>")
            If row.Item("CHK") = "TOTAL" Then
                html.Append("<tr style='background-color: yellow;color:black' >")
            Else
                html.Append("<tr>")
            End If

            For Each column As DataColumn In DS1.Tables(0).Columns
                html.Append("<td>")
                html.Append(row(column.ColumnName))
                html.Append("</td>")
            Next
            html.Append("</tr>")
        Next

        'Table end.
        html.Append("</table>")

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        html.Append("**************************************************************")
        html.Append("<br></br>")
        html.Append("SUNG HYUN ERP")
        html.Append("<br></br>")
        html.Append("**************************************************************")
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        oMail.HtmlBody = html.ToString '"this is a test email sent from VB.NET project with gmail"


        'Gmail SMTP server address
        Dim oServer As New SmtpServer("smtp.gmail.com")

        ' set 465 port
        oServer.Port = 587

        ' detect SSL/TLS automatically
        oServer.ConnectType = SmtpConnectType.ConnectSSLAuto
        ' Gmail user authentication should use your
        ' Gmail email address as the user name.
        ' For example: your email is "gmailid@gmail.com", then the user should be "gmailid@gmail.com"
        oServer.User = "nnkhanhhung@gmail.com"
        oServer.Password = "3211232123"


        Try
            Console.WriteLine("start to send email over SSL ...")
            oSmtp.SendMail(oServer, oMail)
            Console.WriteLine("email was sent successfully!")
        Catch ep As Exception
            Console.WriteLine("failed to send email with the following error:")
            Console.WriteLine(ep.Message)
        End Try

        Pub.DAT = System_Date_8()

    End Sub

    Public Sub SendMail_Weekly()
        Dim Sdate As String
        Dim Edate As String

        Sdate = System_Date_Add(0, -7)
        Edate = System_Date_Add(0, -1)


        Dim oMail As New SmtpMail("TryIt")
        Dim oSmtp As New SmtpClient()
        ' Your gmail email address
        oMail.From = "nnkhanhhung@gmail.com"

        ' Set recipient email address, please change it to yours
        oMail.To = "director@psmvn.com;president@psmvn.com"
        'oMail.To = "yc.cho@sh-group.biz; wy.hwang@sh-group.biz;sy.jung@sh-group.biz;shlee@sh-group.biz;ydhwang@sh-group.biz"
        'oMail.Cc = "president@psmvn.com;director@psmvn.com"

        ' Set email subject
        oMail.Subject = "Weekly Production R & D from " & FSDate(Sdate) & " to " & FSDate(Edate) & "[ Send at : " & FSDateTime(System_Date_time()) & " ]"

        ' Set email body

        Dim html As New StringBuilder()

        'Table start.
        html.Append("**************************************************************")
        html.Append("<br></br>")
        html.Append("This is an automatically generated E-mail, please do NOT reply")
        html.Append("<br></br>")
        html.Append("**************************************************************")

        html.Append("<h1> 1. R & D PRODUCTION BY PROCESS-LINE </h1>")
        html.Append("<table border = '3'>")

        DS1 = PrcDS("USPM_PFP01600_SEARCH_VS10_WEEKLY", cn, "050", Sdate, Edate)

        'Building the Header row.
        html.Append("<tr style='background-color: #201677;color:white' >")
        For Each column As DataColumn In DS1.Tables(0).Columns
            html.Append("<th>")
            html.Append(column.ColumnName)
            html.Append("</th>")
        Next
        html.Append("</tr>")

        'Building the Data rows.
        For Each row As DataRow In DS1.Tables(0).Rows
            'html.Append("<tr>")
            If row.Item("CHK") = "TOTAL" Then
                html.Append("<tr style='background-color: yellow;color:black' >")
            Else
                html.Append("<tr>")
            End If

            For Each column As DataColumn In DS1.Tables(0).Columns
                html.Append("<td>")
                html.Append(row(column.ColumnName))
                html.Append("</td>")
            Next

            html.Append("</tr>")
        Next

        'Table end.
        html.Append("</table>")
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Table start.
        html.Append("<h1> 2. R & D PRODUCTION BY TOTAL </h1>")
        html.Append("<table border = '3'>")

        DS1 = PrcDS("USPM_PFP01600_SEARCH_VS20_WEEKLY", cn, "050", Sdate, Edate)

        'Building the Header row.
        html.Append("<tr style='background-color: #201677;color:white' >")
        For Each column As DataColumn In DS1.Tables(0).Columns
            html.Append("<th>")
            html.Append(column.ColumnName)
            html.Append("</th>")
        Next
        html.Append("</tr>")

        'Building the Data rows.
        For Each row As DataRow In DS1.Tables(0).Rows
            If row.Item("CHK") = "TOTAL" Then
                html.Append("<tr style='background-color: yellow;color:black' >")
            Else
                html.Append("<tr>")
            End If

            For Each column As DataColumn In DS1.Tables(0).Columns
                html.Append("<td>")
                html.Append(row(column.ColumnName))
                html.Append("</td>")
            Next


            html.Append("</tr>")
        Next

        'Table end.
        html.Append("</table>")
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Table start.
        html.Append("<h1> 3. R & D PRODUCTION BY TIME </h1>")
        html.Append("<table border = '3'>")

        DS1 = PrcDS("USPM_PFP01600_SEARCH_VS30_WEEKLY", cn, "050", Sdate, Edate)

        'Building the Header row.
        html.Append("<tr style='background-color: #201677;color:white' >")
        For Each column As DataColumn In DS1.Tables(0).Columns
            html.Append("<th>")
            html.Append(column.ColumnName)
            html.Append("</th>")
        Next
        html.Append("</tr>")

        'Building the Data rows.
        For Each row As DataRow In DS1.Tables(0).Rows
            'html.Append("<tr>")
            If row.Item("CHK") = "TOTAL" Then
                html.Append("<tr style='background-color: yellow;color:black' >")
            Else
                html.Append("<tr>")
            End If

            For Each column As DataColumn In DS1.Tables(0).Columns
                html.Append("<td>")
                html.Append(row(column.ColumnName))
                html.Append("</td>")
            Next
            html.Append("</tr>")
        Next

        'Table end.
        html.Append("</table>")

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        html.Append("**************************************************************")
        html.Append("<br></br>")
        html.Append("SUNG HYUN ERP")
        html.Append("<br></br>")
        html.Append("**************************************************************")
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        oMail.HtmlBody = html.ToString '"this is a test email sent from VB.NET project with gmail"


        'Gmail SMTP server address
        Dim oServer As New SmtpServer("smtp.gmail.com")

        ' set 465 port
        oServer.Port = 587

        ' detect SSL/TLS automatically
        oServer.ConnectType = SmtpConnectType.ConnectSSLAuto
        ' Gmail user authentication should use your
        ' Gmail email address as the user name.
        ' For example: your email is "gmailid@gmail.com", then the user should be "gmailid@gmail.com"
        oServer.User = "nnkhanhhung@gmail.com"
        oServer.Password = "3211232123"


        Try
            Console.WriteLine("start to send email over SSL ...")
            oSmtp.SendMail(oServer, oMail)
            Console.WriteLine("email was sent successfully!")
        Catch ep As Exception
            Console.WriteLine("failed to send email with the following error:")
            Console.WriteLine(ep.Message)
        End Try

        Pub.DAT = System_Date_8()

    End Sub
#End Region

    

End Module
