Public Class PeaceComboboxSearch
    Public Sub OnTextUpdate(ByVal e As EventArgs)
        Dim Values As IList(Of Object) = collectionList.Where(Function(x) x.ToString().ToLower().Contains(Text.ToLower())).ToList(Of Object)()
        Me.Items.Clear()

        If Me.Text <> String.Empty Then
            Me.Items.AddRange(Values.ToArray())
        Else
            Me.Items.AddRange(collectionList.ToArray())
        End If

        Me.SelectionStart = Me.Text.Length
        Me.DroppedDown = True
    End Sub

    Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
        If Me.Text = String.Empty Then
            Me.Items.Clear()
            Me.Items.AddRange(collectionList.ToArray())
        End If
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        collectionList = Me.Items.OfType(Of Object)().ToList()
    End Sub
End Class
