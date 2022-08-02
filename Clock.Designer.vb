<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clock
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clock))
        Me.TaskbarIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TimeStripShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.Quit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MoveWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AlwaysShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.TimeSet = New System.Windows.Forms.ToolStripTextBox()
        Me.Run = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.TimerFocus = New System.Windows.Forms.Timer(Me.components)
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.MSLabel = New System.Windows.Forms.Label()
        Me.ContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TaskbarIcon
        '
        Me.TaskbarIcon.ContextMenuStrip = Me.ContextMenuStrip
        Me.TaskbarIcon.Icon = CType(resources.GetObject("TaskbarIcon.Icon"), System.Drawing.Icon)
        Me.TaskbarIcon.Text = "正在初始化"
        Me.TaskbarIcon.Visible = True
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimeStripShow, Me.Quit, Me.ToolStripSeparator3, Me.MoveWindow, Me.ToolStripSeparator1, Me.AlwaysShow, Me.CloseShow, Me.ToolStripSeparator, Me.TimeSet, Me.Run})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(241, 269)
        '
        'TimeStripShow
        '
        Me.TimeStripShow.Name = "TimeStripShow"
        Me.TimeStripShow.Size = New System.Drawing.Size(240, 30)
        Me.TimeStripShow.Text = "正在初始化"
        '
        'Quit
        '
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(240, 30)
        Me.Quit.Text = "退出"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(237, 6)
        '
        'MoveWindow
        '
        Me.MoveWindow.Name = "MoveWindow"
        Me.MoveWindow.Size = New System.Drawing.Size(240, 30)
        Me.MoveWindow.Text = "移动窗体"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(237, 6)
        '
        'AlwaysShow
        '
        Me.AlwaysShow.Name = "AlwaysShow"
        Me.AlwaysShow.Size = New System.Drawing.Size(240, 30)
        Me.AlwaysShow.Text = "保持显示"
        '
        'CloseShow
        '
        Me.CloseShow.Name = "CloseShow"
        Me.CloseShow.Size = New System.Drawing.Size(240, 30)
        Me.CloseShow.Text = "立即关闭"
        '
        'ToolStripSeparator
        '
        Me.ToolStripSeparator.Name = "ToolStripSeparator"
        Me.ToolStripSeparator.Size = New System.Drawing.Size(237, 6)
        '
        'TimeSet
        '
        Me.TimeSet.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!)
        Me.TimeSet.Name = "TimeSet"
        Me.TimeSet.Size = New System.Drawing.Size(100, 30)
        Me.TimeSet.Text = "显示时长"
        '
        'Run
        '
        Me.Run.Name = "Run"
        Me.Run.Size = New System.Drawing.Size(240, 30)
        Me.Run.Text = "开始"
        '
        'Timer
        '
        Me.Timer.Interval = 1
        '
        'TimerFocus
        '
        Me.TimerFocus.Interval = 1000
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Font = New System.Drawing.Font("宋体", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DateLabel.Location = New System.Drawing.Point(12, 9)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(272, 50)
        Me.DateLabel.TabIndex = 0
        Me.DateLabel.Text = "20XX-XX-XX"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font("宋体", 31.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(12, 129)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(275, 62)
        Me.TimeLabel.TabIndex = 1
        Me.TimeLabel.Text = "XX:XX:XX"
        Me.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MSLabel
        '
        Me.MSLabel.AutoSize = True
        Me.MSLabel.Font = New System.Drawing.Font("宋体", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MSLabel.Location = New System.Drawing.Point(237, 96)
        Me.MSLabel.Name = "MSLabel"
        Me.MSLabel.Size = New System.Drawing.Size(47, 33)
        Me.MSLabel.TabIndex = 2
        Me.MSLabel.Text = "XX"
        Me.MSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Clock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(300, 200)
        Me.Controls.Add(Me.MSLabel)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.DateLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 200)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 200)
        Me.Name = "Clock"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clock"
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.ContextMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TaskbarIcon As NotifyIcon
    Friend WithEvents Timer As Timer
    Friend WithEvents TimerFocus As Timer
    Friend WithEvents DateLabel As Label
    Friend WithEvents TimeLabel As Label
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents AlwaysShow As ToolStripMenuItem
    Friend WithEvents CloseShow As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator As ToolStripSeparator
    Friend WithEvents TimeSet As ToolStripTextBox
    Friend WithEvents Run As ToolStripMenuItem
    Friend WithEvents Quit As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents MSLabel As Label
    Friend WithEvents TimeStripShow As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents MoveWindow As ToolStripMenuItem
End Class
