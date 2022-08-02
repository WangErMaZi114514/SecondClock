Imports System.ComponentModel

Public Class Clock
    Dim TimeStr As String
    Private Const SWP_NOSIZE = &H1
    Private Const SWP_NOMOVE = &H2
    Private Const HWND_TOPMOST = -1
    Private Const HWND_NOTOPMOST = -2
    'Private Declare Function SetWindowPos Lib "user32" (ByVal hWnd As Long, ByVal hWndInsertAfter As Long, ByVal X As Long, ByVal Y As Long, ByVal cx As Long, ByVal cy As Long, ByVal wFlags As Long) As Long
    Private Sub Clock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        About.Visible = False
        Timer.Start()
        DateLabel.Text = My.Computer.Clock.LocalTime.Year.ToString + "-"
        If My.Computer.Clock.LocalTime.Month < 10 Then
            DateLabel.Text = DateLabel.Text + "0" + My.Computer.Clock.LocalTime.Month.ToString + "-"
        Else
            DateLabel.Text = DateLabel.Text + My.Computer.Clock.LocalTime.Month.ToString + "-"
        End If


        If My.Computer.Clock.LocalTime.Day < 10 Then
            DateLabel.Text = DateLabel.Text + "0" + My.Computer.Clock.LocalTime.Day.ToString
        Else
            DateLabel.Text = DateLabel.Text + My.Computer.Clock.LocalTime.Day.ToString
        End If
    End Sub

    Private Sub Clock_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Visible = False
    End Sub


    Private Sub TimerFocus_Tick(sender As Object, e As EventArgs) Handles TimerFocus.Tick
        Visible = False
        TimerFocus.Stop()
    End Sub

    Private Sub TaskbarIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TaskbarIcon.MouseDoubleClick
        Visible = True
        TimerFocus.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick


        If My.Computer.Clock.LocalTime.Second = 1 Then
            DateLabel.Text = My.Computer.Clock.LocalTime.Year.ToString + "-"
            If My.Computer.Clock.LocalTime.Month < 10 Then
                DateLabel.Text = DateLabel.Text + "0" + My.Computer.Clock.LocalTime.Month.ToString + "-"
            Else
                DateLabel.Text = DateLabel.Text + My.Computer.Clock.LocalTime.Month.ToString + "-"
            End If


            If My.Computer.Clock.LocalTime.Day < 10 Then
                DateLabel.Text = DateLabel.Text + "0" + My.Computer.Clock.LocalTime.Day.ToString
            Else
                DateLabel.Text = DateLabel.Text + My.Computer.Clock.LocalTime.Day.ToString
            End If
        End If
        '以上为日期初始化

        TimeStr = ""

        If My.Computer.Clock.LocalTime.Hour < 10 Then
            TimeStr = TimeStr + "0" + My.Computer.Clock.LocalTime.Hour.ToString + ":"
        Else
            TimeStr = TimeStr + My.Computer.Clock.LocalTime.Hour.ToString + ":"
        End If


        If My.Computer.Clock.LocalTime.Minute < 10 Then
            TimeStr = TimeStr + "0" + My.Computer.Clock.LocalTime.Minute.ToString + ":"
        Else
            TimeStr = TimeStr + My.Computer.Clock.LocalTime.Minute.ToString + ":"
        End If


        If My.Computer.Clock.LocalTime.Second < 10 Then
            TimeStr = TimeStr + "0" + My.Computer.Clock.LocalTime.Second.ToString
        Else
            TimeStr = TimeStr + My.Computer.Clock.LocalTime.Second.ToString
        End If

        TimeLabel.Text = TimeStr
        '下面是毫秒
        MSLabel.Text = CInt(My.Computer.Clock.LocalTime.Millisecond / 10)
        TaskbarIcon.Text = TimeLabel.Text
        TimeStripShow.Text = TimeLabel.Text
    End Sub

    Private Sub Run_Click(sender As Object, e As EventArgs) Handles Run.Click
        Visible = True
        TimerFocus.Interval = TimeSet.Text * 1000
        TimerFocus.Start()
        TimeSet.Text = "显示时长"
    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        End
    End Sub

    Private Sub AlwaysShow_Click(sender As Object, e As EventArgs) Handles AlwaysShow.Click
        Visible = True
        'SetWindowPos(hWnd, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE)
    End Sub

    Private Sub CloseShow_Click(sender As Object, e As EventArgs) Handles CloseShow.Click
        Visible = False
    End Sub

    Private Sub TimeSet_Click(sender As Object, e As EventArgs) Handles TimeSet.Click
        If Not TimeSet.Text = "显示时长" Then
            TimeSet.Text = ""
        End If
    End Sub

    Private Sub TimeSet_LostFocus(sender As Object, e As EventArgs) Handles TimeSet.LostFocus
        If TimeSet.Text = "" Then
            TimeSet.Text = "显示时长"
        End If
    End Sub

    Private Sub MoveWindow_Click(sender As Object, e As EventArgs) Handles MoveWindow.Click
        FormBorderStyle = FormBorderStyle.Sizable
        Visible = True
        Text = "移动完成后点击关闭键"
    End Sub

    Private Sub Clock_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
        FormBorderStyle = FormBorderStyle.None
        Text = "Clock"
    End Sub

    Private Sub TimeSet_KeyDown(sender As Object, e As KeyEventArgs) Handles TimeSet.KeyDown
        If TimeSet.Text = "显示时长" Then
            TimeSet.Text = ""
        End If
    End Sub

    Private Sub TimeStripShow_Click(sender As Object, e As EventArgs) Handles TimeStripShow.Click
        About.Visible = True
    End Sub

    Private Sub TimeStripShow_MouseEnter(sender As Object, e As EventArgs) Handles TimeStripShow.MouseEnter
        TimeStripShow.Text = "关于"
    End Sub
End Class
