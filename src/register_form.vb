Public Class register_form

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "4JKLM-89JKM-89KJG-78MJG-78LH3" Then
            My.Settings.isActivated = "Yes"
            validkey.Show()
            Me.Close()
        Else
            KeyNotValid.Show()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        navigator.Show()
    End Sub
End Class