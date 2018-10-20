Option Strict On
Imports System.Drawing.Drawing2D
Public Class PH_Clock
    Const Convert As Double = Math.PI / 180
    Const alarmRadius = 190
    Const SecRadius As Double = 185
    Const MinRadius As Double = 180
    Const HrRadius As Double = 155
    Dim AlarmAngle As Double
    Dim SecAngle As Double
    Dim MinAngle As Double
    Dim HrAngle As Double
    Dim AlarmX As Single = 220
    Dim AlarmY As Single = 20
    Dim SecX As Single = 220
    Dim SecY As Single = 20
    Dim MinX As Single = 220
    Dim MinY As Single = 20
    Dim HrX As Single = 220
    Dim HrY As Single = 20
    Dim ChimesCount As Integer
    Dim hrs, min, value As Integer
    Dim TimeString As String
    Dim ChimesFlag As Boolean
    Dim AlarmFlag As Boolean
    Dim WithEvents tmrClock As New Timer
    Dim WithEvents tmrChimes As New Timer
    Dim WithEvents TBAlarm As New TrackBar
    Dim WithEvents btnAlarm As New Button
    Dim WithEvents btnChimes As New Button
    Dim WithEvents lblPanel As New Label
    Dim lblTB As New Label
    Dim pnlExtras As New Panel
    Dim tTip As New ToolTip
    Dim StartPoint(60) As PointF
    Dim EndPoint(60) As PointF
    Dim NumberPoint() As PointF = {New PointF(285, 50), New PointF(350, 115), New PointF(376, 203),
                                   New PointF(350, 290), New PointF(285, 350), New PointF(205, 366),
                                   New PointF(125, 350), New PointF(60, 290), New PointF(38, 203),
                                   New PointF(55, 120), New PointF(112, 59), New PointF(196, 36)}
    'Create the Pens
    Dim RedPen As Pen = New Pen(Color.Red, 6)
    Dim GreenPen As Pen = New Pen(Color.Green, 6)
    Dim BluePen As Pen = New Pen(Color.Blue, 6)

    Dim TurquezaPen As Pen = New Pen(Color.DarkTurquoise, 6)
    Dim VerdePen As Pen = New Pen(Color.YellowGreen, 6)


    Dim OrangePen As Pen = New Pen(Color.Red, 5)
    Dim BlackPen As Pen = New Pen(Color.Black, 6)

    Dim myPen As New Pen(Color.DarkBlue, 8)
    Dim AlarmPen As New Pen(Color.Red, 4)
    'Create the Fonts
    Dim NumberFont As New Font("Arial", 25, FontStyle.Bold)
    Dim ClockFont As New Font("Arial", 18, FontStyle.Bold)
    Dim NameFont As New Font("Microsoft Sans Serif", 22, FontStyle.Italic)

    'Create the Bitmap to draw the clock face
    Dim ClockFace As New Bitmap(445, 445)
    Dim gr As Graphics = Graphics.FromImage(ClockFace)


    Private Sub PH_Clock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Add a ToolTip to the form
        '   tTip.SetToolTip(Me, "Double Click Clock Face To Close")
        tTip.Active = True
        '        BluePen.SetLineCap(LineCap.Round, LineCap.ArrowAnchor, DashCap.Flat)
        VerdePen.SetLineCap(LineCap.Round, LineCap.ArrowAnchor, DashCap.Flat)
        OrangePen.SetLineCap(LineCap.Round, LineCap.ArrowAnchor, DashCap.Flat)
        BlackPen.SetLineCap(LineCap.Round, LineCap.ArrowAnchor, DashCap.Flat)
        DoubleBuffered = True
        Me.Size = New Size(445, 445)
        'Me.PictureBox1 = FormBorderStyle.None
        'Me.TransparencyKey = SystemColors.Control
        'Me.CenterToScreen()
        '  CreatePanel()
        CalculateIncrements()
        DrawClockFace()
        tmrClock.Interval = 990
        tmrClock.Start()
    End Sub



    Private Sub TBAlarm_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBAlarm.Scroll
        value = CInt(TBAlarm.Value)
        hrs = CInt(Fix(value / 60))
        min = CInt(TBAlarm.Value - (hrs * 60))
        If hrs = 24 Then hrs = 0
        lblTB.Text = Format(hrs, "00") & ":" & Format(min, "00")
        AlarmAngle = (hrs + min / 60) * 30
        AlarmX = CInt(alarmRadius * Math.Cos((90 - AlarmAngle) * Convert)) + 220
        AlarmY = 220 - CInt(alarmRadius * Math.Sin((90 - AlarmAngle) * Convert))
    End Sub
   




    Sub DrawClockFace()
         gr.SmoothingMode = SmoothingMode.HighQuality
        'Draw Clock Background
        gr.FillEllipse(Brushes.White, 20, 20, 400, 400)
        gr.DrawEllipse(TurquezaPen, 20, 20, 400, 400)
        '        gr.DrawEllipse(Pens.Red, 120, 120, 200, 200)
        gr.DrawEllipse(TurquezaPen, 120, 120, 200, 200)
        'Draw Increments around cicumferance
        For I As Integer = 1 To 60
            gr.DrawLine(TurquezaPen, StartPoint(I), EndPoint(I))
        Next
        'Draw Numbers
        For I As Integer = 1 To 12
            gr.DrawString(I.ToString, NumberFont, Brushes.Black, NumberPoint(I - 1))
        Next
        'Draw Name
        gr.DrawString("", NameFont, Brushes.DarkBlue, 170, 85)
        'Draw Digital Clock Background
        gr.FillRectangle(Brushes.DarkBlue, 170, 260, 100, 30)
        myPen.LineJoin = LineJoin.Round
        gr.DrawRectangle(myPen, 170, 260, 100, 30)

    End Sub
    Sub CalculateIncrements() 'around clock perimeter
        Dim X, Y As Integer
        Dim radius As Integer
        For I As Integer = 1 To 60
            If I Mod 5 = 0 Then
                radius = 182
            Else
                radius = 190
            End If
            'Calculate Start Point
            X = CInt(radius * Math.Cos((90 - I * 6) * Convert)) + 220
            Y = 220 - CInt(radius * Math.Sin((90 - I * 6) * Convert))
            StartPoint(I) = New PointF(X, Y)
            'Calculate End Point
            X = CInt(200 * Math.Cos((90 - I * 6) * Convert)) + 220
            Y = 220 - CInt(200 * Math.Sin((90 - I * 6) * Convert))
            EndPoint(I) = New PointF(X, Y)
        Next
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        e.Graphics.SmoothingMode = SmoothingMode.HighQuality
        'Draw Clock Background
        e.Graphics.DrawImage(ClockFace, Point.Empty)
        'Draw Digital Time
        e.Graphics.DrawString(TimeString, ClockFont, Brushes.White, 170, 260)
      
        e.Graphics.DrawLine(BlackPen, 220, 220, HrX, HrY)
        e.Graphics.DrawLine(OrangePen, 220, 220, MinX, MinY)
        'e.Graphics.DrawLine(BluePen, 220, 220, SecX, SecY)
        e.Graphics.DrawLine(VerdePen, 220, 220, SecX, SecY)

        e.Graphics.FillEllipse(Brushes.Black, 210, 210, 20, 20)
        e.Graphics.FillEllipse(Brushes.Red, 212, 212, 16, 16)
        'e.Graphics.FillEllipse(Brushes.Blue, 215, 215, 10, 10)
        e.Graphics.FillEllipse(Brushes.YellowGreen, 215, 215, 10, 10)

    End Sub
    Private Sub tmrClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrClock.Tick
        TimeString = Now.ToString("HH:mm:ss")
        'Set The Angle of the Second, Minute and Hour hand according to the time
        SecAngle = (Now.Second * 6)
        MinAngle = (Now.Minute + Now.Second / 60) * 6
        HrAngle = (Now.Hour + Now.Minute / 60) * 30
        'Get the X,Y co-ordinates of the end point of each hand
        SecX = CInt(SecRadius * Math.Cos((90 - SecAngle) * Convert)) + 220
        SecY = 220 - CInt(SecRadius * Math.Sin((90 - SecAngle) * Convert))
        MinX = CInt(MinRadius * Math.Cos((90 - MinAngle) * Convert)) + 220
        MinY = 220 - CInt(MinRadius * Math.Sin((90 - MinAngle) * Convert))
        HrX = CInt(HrRadius * Math.Cos((90 - HrAngle) * Convert)) + 220
        HrY = 220 - CInt(HrRadius * Math.Sin((90 - HrAngle) * Convert))
        Refresh()
        'Play chimes if selected
        If ChimesFlag = True Then
            If Now.Minute = 0 And Now.Second = 0 Then
                ChimesCount = Now.Hour
                If ChimesCount > 12 Then ChimesCount -= 12
                If ChimesCount = 0 Then ChimesCount = 12
                tmrChimes.Start()
                ' My.Computer.Audio.Play(My.Resources.Chime, AudioPlayMode.Background)
            ElseIf Now.Minute = 30 And Now.Second = 0 Then
                ' My.Computer.Audio.Play(My.Resources.Chime, AudioPlayMode.Background)
            End If
        End If
        'Set off Alarm if selected
        If AlarmFlag = True Then
            If Now.Hour = hrs And Now.Minute = min And Now.Second = 0 Then
                '  My.Computer.Audio.Play(My.Resources.Alarm, AudioPlayMode.BackgroundLoop)
            End If
        End If
    End Sub
    Private Sub tmrChimes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrChimes.Tick
        Static count As Integer = 0
        count += 1
        If count < ChimesCount Then
            '  My.Computer.Audio.Play(My.Resources.Chime, AudioPlayMode.Background)
        Else
            count = 0
            tmrChimes.Stop()
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
