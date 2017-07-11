<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_serivice_status = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_manage = New System.Windows.Forms.TabPage()
        Me.Button_edit_cfg = New System.Windows.Forms.Button()
        Me.Button_stop = New System.Windows.Forms.Button()
        Me.Button_start = New System.Windows.Forms.Button()
        Me.TabPage_install = New System.Windows.Forms.TabPage()
        Me.Button_crecat_share = New System.Windows.Forms.Button()
        Me.Button_uninstall = New System.Windows.Forms.Button()
        Me.Button_install = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_manage.SuspendLayout()
        Me.TabPage_install.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 412)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "服务状态："
        '
        'Label_serivice_status
        '
        Me.Label_serivice_status.AutoSize = True
        Me.Label_serivice_status.ForeColor = System.Drawing.Color.Red
        Me.Label_serivice_status.Location = New System.Drawing.Point(83, 412)
        Me.Label_serivice_status.Name = "Label_serivice_status"
        Me.Label_serivice_status.Size = New System.Drawing.Size(29, 12)
        Me.Label_serivice_status.TabIndex = 1
        Me.Label_serivice_status.Text = "未知"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_manage)
        Me.TabControl1.Controls.Add(Me.TabPage_install)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(542, 378)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage_manage
        '
        Me.TabPage_manage.Controls.Add(Me.Button_edit_cfg)
        Me.TabPage_manage.Controls.Add(Me.Button_stop)
        Me.TabPage_manage.Controls.Add(Me.Button_start)
        Me.TabPage_manage.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_manage.Name = "TabPage_manage"
        Me.TabPage_manage.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_manage.Size = New System.Drawing.Size(534, 352)
        Me.TabPage_manage.TabIndex = 0
        Me.TabPage_manage.Text = "维护"
        Me.TabPage_manage.UseVisualStyleBackColor = True
        '
        'Button_edit_cfg
        '
        Me.Button_edit_cfg.Location = New System.Drawing.Point(361, 165)
        Me.Button_edit_cfg.Name = "Button_edit_cfg"
        Me.Button_edit_cfg.Size = New System.Drawing.Size(75, 23)
        Me.Button_edit_cfg.TabIndex = 2
        Me.Button_edit_cfg.Text = "修改配置"
        Me.Button_edit_cfg.UseVisualStyleBackColor = True
        '
        'Button_stop
        '
        Me.Button_stop.Location = New System.Drawing.Point(229, 165)
        Me.Button_stop.Name = "Button_stop"
        Me.Button_stop.Size = New System.Drawing.Size(75, 23)
        Me.Button_stop.TabIndex = 1
        Me.Button_stop.Text = "停止服务"
        Me.Button_stop.UseVisualStyleBackColor = True
        '
        'Button_start
        '
        Me.Button_start.Location = New System.Drawing.Point(97, 165)
        Me.Button_start.Name = "Button_start"
        Me.Button_start.Size = New System.Drawing.Size(75, 23)
        Me.Button_start.TabIndex = 0
        Me.Button_start.Text = "启动服务"
        Me.Button_start.UseVisualStyleBackColor = True
        '
        'TabPage_install
        '
        Me.TabPage_install.Controls.Add(Me.Button_crecat_share)
        Me.TabPage_install.Controls.Add(Me.Button_uninstall)
        Me.TabPage_install.Controls.Add(Me.Button_install)
        Me.TabPage_install.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_install.Name = "TabPage_install"
        Me.TabPage_install.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_install.Size = New System.Drawing.Size(534, 352)
        Me.TabPage_install.TabIndex = 1
        Me.TabPage_install.Text = "安装"
        Me.TabPage_install.UseVisualStyleBackColor = True
        '
        'Button_crecat_share
        '
        Me.Button_crecat_share.Location = New System.Drawing.Point(223, 165)
        Me.Button_crecat_share.Name = "Button_crecat_share"
        Me.Button_crecat_share.Size = New System.Drawing.Size(87, 23)
        Me.Button_crecat_share.TabIndex = 2
        Me.Button_crecat_share.Text = "重建共享目录"
        Me.Button_crecat_share.UseVisualStyleBackColor = True
        '
        'Button_uninstall
        '
        Me.Button_uninstall.Location = New System.Drawing.Point(361, 165)
        Me.Button_uninstall.Name = "Button_uninstall"
        Me.Button_uninstall.Size = New System.Drawing.Size(75, 23)
        Me.Button_uninstall.TabIndex = 1
        Me.Button_uninstall.Text = "卸载服务"
        Me.Button_uninstall.UseVisualStyleBackColor = True
        '
        'Button_install
        '
        Me.Button_install.Location = New System.Drawing.Point(97, 165)
        Me.Button_install.Name = "Button_install"
        Me.Button_install.Size = New System.Drawing.Size(75, 23)
        Me.Button_install.TabIndex = 0
        Me.Button_install.Text = "安装服务"
        Me.Button_install.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(423, 412)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ver 0.1 By:疯掉的兔子"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(160, 407)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "刷新服务状态"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 433)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label_serivice_status)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "博惠网络安装系统管理器"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_manage.ResumeLayout(False)
        Me.TabPage_install.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label_serivice_status As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage_manage As TabPage
    Friend WithEvents TabPage_install As TabPage
    Friend WithEvents Button_edit_cfg As Button
    Friend WithEvents Button_stop As Button
    Friend WithEvents Button_start As Button
    Friend WithEvents Button_crecat_share As Button
    Friend WithEvents Button_uninstall As Button
    Friend WithEvents Button_install As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
