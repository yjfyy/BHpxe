Imports System.ServiceProcess

Public Class Form1
    Dim medir = Application.StartupPath
    Private Sub Button_install_Click(sender As Object, e As EventArgs) Handles Button_install.Click
        Shell("nssm install bhpxe " & medir & "\pxesrv\pxesrv.exe")
        MsgBox("服务已安装成功")
        shuaxin()
    End Sub

    Private Sub Button_uninstall_Click(sender As Object, e As EventArgs) Handles Button_uninstall.Click
        Shell("nssm remove bhpxe")
        shuaxin()
    End Sub

    Private Sub Button_crecat_share_Click(sender As Object, e As EventArgs) Handles Button_crecat_share.Click
        Shell("net share instiso=" & medir & "\instiso")
        MsgBox("安装源已共享")
    End Sub

    Private Sub Button_start_Click(sender As Object, e As EventArgs) Handles Button_start.Click
        Shell("nssm start bhpxe")
        MsgBox("服务已启动")
        shuaxin()
    End Sub

    Private Sub Button_stop_Click(sender As Object, e As EventArgs) Handles Button_stop.Click
        Shell("nssm stop bhpxe")
        MsgBox("服务已停止")
        shuaxin()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shuaxin()
    End Sub
    Private Sub shuaxin()
        Dim ssbhpxe As New ServiceController("bhpxe")
        Try
            Select Case ssbhpxe.Status
                Case ServiceControllerStatus.Running
                    Label_serivice_status.Text = "正在运行"
                Case ServiceControllerStatus.Stopped
                    Label_serivice_status.Text = "已停止"
            End Select
        Catch ex As Exception
            Label_serivice_status.Text = "状态未知"
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        shuaxin()
    End Sub

    Private Sub Button_edit_cfg_Click(sender As Object, e As EventArgs) Handles Button_edit_cfg.Click
        Shell("notepad.exe " & medir & "\pxesrv\config.ini", vbNormalFocus)
    End Sub
End Class
