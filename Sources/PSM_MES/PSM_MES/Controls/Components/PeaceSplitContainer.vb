Public Class PeaceSplitContainer

    Private chkHandle As Boolean = False
    'Private Sub PeaceSplitContainer_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
    '    If chkHandle = True Then Exit Sub
    '    If Me IsNot Nothing Then
    '        If Me.ParentForm IsNot Nothing Then
    '            If READ_PFK9921(Me.FindForm.Name, Me.Name) = True Then
    '                Me.SplitterDistance = D9921.Distance
    '                chkHandle = True
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub PeaceSplitContainer_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles Me.SplitterMoved
    '    If Me IsNot Nothing Then
    '        If Me.FindForm IsNot Nothing Then
    '            If READ_PFK9921(Me.ParentForm.Name, Me.Name) = False Then
    '                D9921.ProgramNo = Me.FindForm.Name
    '                D9921.SplitName = Me.Name
    '                D9921.Distance = Me.SplitterDistance

    '                Call WRITE_PFK9921(D9921)
    '            Else
    '                D9921.Distance = Me.SplitterDistance
    '                Call REWRITE_PFK9921(D9921)
    '            End If
    '        End If
    '    End If
    'End Sub

   
End Class
