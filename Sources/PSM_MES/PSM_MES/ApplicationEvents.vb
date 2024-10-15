Namespace My
    Partial Friend Class MyApplication

        Private Sub MyApplication_StartupNextInstance(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance

            MsgBoxEx("I don't know. Contact ERP Team", vbCritical)

            APP_EXIT()

        End Sub

        Private Sub MyApplication_NetworkAvailabilityChanged(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.Devices.NetworkAvailableEventArgs) Handles Me.NetworkAvailabilityChanged

            If e.IsNetworkAvailable = False Then
                PSMGlobal.MdiMenu.lbl_StatusOnOff.Text = "Disconnected!"
                PSMGlobal.MdiMenu.lbl_StatusOnOff.Image = Resources.MoveDown_16x16
                'MsgBox("Disconnect from the server! Please wait for re-connection ! Mất kết nối từ máy chủ ! Vui lòng chợ đợi khi có kết nối lại !", vbCritical)

            ElseIf e.IsNetworkAvailable = True Then
                PSMGlobal.MdiMenu.lbl_StatusOnOff.Text = "Connected!"
                PSMGlobal.MdiMenu.lbl_StatusOnOff.Image = Resources.MoveUp_16x16
                'MsgBox("Re-Connection Sucessully ! Kết nối lại thành công !", vbInformation)

                Call kndl()

            End If

        End Sub

    End Class
End Namespace


