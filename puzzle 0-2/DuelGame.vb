Public Class DuetGame
#Region "Variables"

    Dim GameStarted As Boolean = False
    Dim Countdown As Integer = 5

    Dim difLevel As Integer = My.Settings.chosenDifficulty

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

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        ' Normal Attack
        If e.KeyChar = "j" Or e.KeyChar = "k" Or e.KeyChar = "l" Or e.KeyChar = "J" Or e.KeyChar = "K" Or e.KeyChar = "L" Then
            If GameStarted = True Then
                If ProgressBar1.Value = 0 Then
                    winEndProtocall(2)
                Else
                    ProgressBar1.Value = ProgressBar1.Value - 1
                End If
            End If
        End If

        If e.KeyChar = "a" Or e.KeyChar = "s" Or e.KeyChar = "d" Or e.KeyChar = "A" Or e.KeyChar = "S" Or e.KeyChar = "D" Then
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