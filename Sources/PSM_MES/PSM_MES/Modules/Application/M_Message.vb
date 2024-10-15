Module M_MESSAGE

#Region "Variable"
    Private Declare Function MessageBox Lib "user32" Alias "MessageBoxA" (ByVal hwnd As Integer, ByVal lpText As String, ByVal lpCaption As String, ByVal wType As Integer) As Integer

#End Region

#Region "Methods"
    Public Function Select_Message(MsgSel As String, MsgTitle As String, xSELECT As String) As Boolean
        Select_Message = False
        Try

            Dim strMSG As String
            Dim dr As SqlClient.SqlDataReader
            Dim cmd As New SqlClient.SqlCommand

            SQL = " SELECT K9997_NAT01, K9997_NAT02 ,K9997_NAT03, K9997_NAT04 FROM PFK9997 "
            SQL = SQL & " WHERE K9997_CODE   = '" & MsgSel & "' "
            SQL = SQL & "   AND K9997_SELECT = '2' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                Select Case Pub.NAT
                    Case 1 : strMSG = dr("K9997_NAT01")
                    Case 2 : strMSG = dr("K9997_NAT02")
                    Case 3 : strMSG = dr("K9997_NAT03")
                    Case 4 : strMSG = dr("K9997_NAT04")
                    Case Else : strMSG = dr("K9997_NAT01")
                End Select

                If Trim(strMSG) = "" Then strMSG = dr("K9997_NAT01")
                dr.Close()
                Select Case xSELECT
                    Case "1"
                        Msg_Result = MsgBoxP(strMSG, vbQuestion + vbYesNoCancel + vbDefaultButton1, MsgTitle)
                    Case Else
                        Msg_Result = MsgBoxP(strMSG, vbQuestion + vbYesNo + vbDefaultButton2, MsgTitle)
                End Select

            Else
                MsgBoxP(" MESSAGE ERROR ", vbInformation, "MsgBoxP !!!!!  MENAGEMENT INPUT WANT !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!")

            End If
            Select_Message = True

        Catch ex As Exception
            MsgBoxP(" MESSAGE ERROR ", vbInformation, "MsgBoxP")
        End Try

    End Function
#End Region

End Module
