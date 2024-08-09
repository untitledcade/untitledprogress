Public Class DuetGame
#Region "Variables"

    Dim GameStarted As Boolean = False
    Dim Countdown As Integer = 5

    Dim difLevel As Integer = My.Settings.chosenDifficulty

    ' Boolean to track whether a key is being held down
    Private keyIsHeld As Boolean = False

    ' Timer to manage key press intervals
    Private WithEvents keyHoldTimer As New Timer With {.Interval = 5000} ' Adjust interval as needed

    ' The key that is being tracked
    Private trackedKey As Keys

#End Region
    Private Sub DuetGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer3.Enabled = True
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Countdown > 0 Then
            Countdown = Countdown - 1
            Label4.Text = Countdown
            If Countdown = 3 Then
                My.Computer.Audio.Play(My.Resources.OnMark, AudioPlayMode.Background)
            End If
            If Countdown = 1 Then
                My.Computer.Audio.Play(My.Resources.GetSet, AudioPlayMode.Background)
            End If

        ElseIf Countdown = 0 Then
            Label4.Text = "Begin!"
            My.Computer.Audio.Play(My.Resources.GameStart, AudioPlayMode.Background)
            Timer1.Enabled = True
            Timer3.Enabled = False
            GameStarted = True
        End If

    End Sub

    Function winEndProtocall(ByVal gameResult As Integer)

        ' Stops the game from playing.

        Timer1.Enabled = False
        GameStarted = False

        ' Gives Game Result, and Adds a win or loss to the counter

        If gameResult = 1 Then
            Label4.Text = "Player 1 Wins"
            My.Computer.Audio.Play(My.Resources.Player1, AudioPlayMode.Background)
        ElseIf gameResult = 2 Then
            Label4.Text = "Player 2 Wins!"
            My.Computer.Audio.Play(My.Resources.Player2, AudioPlayMode.Background)

        End If

    End Function



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            winEndProtocall(1)
        End If
        If ProgressBar1.Value = 0 Then
            winEndProtocall(2)
        End If
    End Sub
    Private Sub Duet_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Check if the key is already being held down
        If keyIsHeld AndAlso e.KeyCode = trackedKey Then
            ' Ignore further processing if the key is held down
            e.SuppressKeyPress = True
            Return
        End If

        ' Set the key as held down and start the timer
        keyIsHeld = True
        trackedKey = e.KeyCode
        keyHoldTimer.Start()

        ' Process the key press
        ProcessKeyPress(e.KeyCode)
    End Sub

    Private Sub keyHoldTimer_Tick(sender As Object, e As EventArgs) Handles keyHoldTimer.Tick
        ' Reset the key hold flag after the interval
        keyIsHeld = False
        keyHoldTimer.Stop()
    End Sub

    Private Sub Duet_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        ' Stop the timer when the key is released
        If e.KeyCode = trackedKey Then
            keyIsHeld = False
            keyHoldTimer.Stop()
        End If
    End Sub

    Private Sub ProcessKeyPress(keyCode As Keys)
        ' Normal Attack
        If keyCode = Keys.J Or keyCode = Keys.K Or keyCode = Keys.L Then
            If GameStarted = True Then
                If ProgressBar1.Value = 0 Then
                    winEndProtocall(2)
                Else
                    ProgressBar1.Value = ProgressBar1.Value - 1
                End If
            End If
        End If

        If keyCode = Keys.A Or keyCode = Keys.S Or keyCode = Keys.D Then
            If GameStarted = True Then
                If ProgressBar1.Value = 100 Then
                    winEndProtocall(1)
                Else
                    ProgressBar1.Value = ProgressBar1.Value + 1
                End If
            End If
        End If

    End Sub

End Class