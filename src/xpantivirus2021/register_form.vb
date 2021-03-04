Public Class register_form

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click
        If FlatTextBox1.Text = "4JKLM-89JKM-89KJG-78MJG-78LH3" Then
            My.Settings.isActivated = "Yes"
            validkey.Show()
            Me.Close()
        Else
            KeyNotValid.Show()
        End If
    End Sub

    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click
        navigator.Show()
    End Sub
End Class