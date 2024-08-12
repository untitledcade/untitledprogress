Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class Form1

#Region "Variables"

    Dim GameStarted As Boolean = False
    Dim Countdown As Integer = 5

    Dim difLevel As Integer = My.Settings.chosenDifficulty

    Dim opponentCooldownA As Integer
    Dim opponentCooldownB As Integer
    Dim opponentCooldownC As Integer

    Dim opponentCooldownRegulator As Integer = 0
    Dim opponentCooldownUsed As Boolean = True

    Dim UserA As Integer = 10
    Dim UserB As Integer = 20
    Dim UserC As Integer = 30
    Dim AStatus As Boolean = False
    Dim BStatus As Boolean = False
    Dim CStatus As Boolean = False

    Dim Autoclicker As Boolean = False
    Dim AutoclickerStatus As Boolean = False
    Dim AutoclickerSpeed As Integer = My.Settings.AutoclickerLevel

    ' Boolean to track whether a key is being held down
    Private keyIsHeld As Boolean = False

    ' Timer to manage key press intervals
    Private WithEvents keyHoldTimer As New Timer With {.Interval = 5000} ' Adjust interval as needed

    ' The key that is being tracked
    Private trackedKey As Keys

#End Region

    Private Declare Function Beep Lib "kernel32.dll" (ByVal dwFreq As Long, ByVal dwDuration As Long) As Long

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button2.Enabled = False
        Button2.Text = "20"
        UserA = 20 - My.Settings.CooldownALevel
        AStatus = True

        Button3.Enabled = False
        Button3.Text = "40"
        UserB = 40 - My.Settings.CooldownCLevel
        BStatus = True

        Button4.Enabled = False
        Button4.Text = "60"
        UserC = 60 - My.Settings.CooldownCLevel
        CStatus = True

        Label1.Text = My.Settings.userUsernane + " (YOU)"

        opponentCooldownA = My.Settings.OppCooldownA
        opponentCooldownB = My.Settings.OppCooldownB
        opponentCooldownC = My.Settings.OppCooldownC

        Dim rand As New Random()
        Dim musicSelect As Integer = rand.Next(1, 4)

        If musicSelect = 1 Then
            My.Computer.Audio.Play(My.Resources.DeepWave, AudioPlayMode.Background)
        ElseIf musicSelect = 2 Then
            My.Computer.Audio.Play(My.Resources.Trying_to_Keep_Up, AudioPlayMode.Background)
        ElseIf musicSelect = 3 Then
            My.Computer.Audio.Play(My.Resources.DualSynth, AudioPlayMode.Background)
        ElseIf musicSelect = 4 Then
            My.Computer.Audio.Play(My.Resources.Retaliation, AudioPlayMode.Background)
        End If


    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Countdown > 0 Then
            Countdown = Countdown - 1
            Label4.Text = Countdown
            If Countdown = 3 Then
                Call Beep(800, 125)
            End If
            If Countdown = 2 Then
                Call Beep(800, 125)
            End If
            If Countdown = 1 Then
                Call Beep(800, 125)
            End If
            If Countdown = 0 Then
                Call Beep(800, 125)
            End If
        ElseIf Countdown = 0 Then
            Label4.Text = "Begin!"
            Call Beep(800, 500)
            Timer1.Enabled = True
            Button1.Enabled = True
            RunAwayForefitToolStripMenuItem.Enabled = True
            Timer3.Enabled = False
            GameStarted = True
        End If

    End Sub

    Function difficultySetter(ByVal coolSelect As Integer)

        ' Sets Difficulty for the Game Session using the difLevel set from menu.

        If coolSelect = 1 Then
            opponentCooldownA = My.Settings.OppCooldownA
        End If

        If coolSelect = 2 Then
            opponentCooldownB = My.Settings.OppCooldownB
        End If

        If coolSelect = 3 Then
            opponentCooldownC = My.Settings.OppCooldownC
        End If

    End Function

    Function winEndProtocall(ByVal gameResult As Integer)

        ' Stops the game from playing.

        Timer1.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        RunAwayForefitToolStripMenuItem.Enabled = False
        GameStarted = False

        ' Gives Game Result, and Adds a win or loss to the counter

        If gameResult = 1 Then
            Label4.Text = "Win! " & "+" & My.Settings.gameXP & "XP " & "+" & My.Settings.gameCredit & " BugCoin"
            My.Settings.userXP = My.Settings.userXP + My.Settings.gameXP
            My.Settings.userCredit = My.Settings.userCredit + My.Settings.gameCredit
            My.Settings.Save()
            main.TextBox1.Text = My.Settings.userXP
            Campaign.CampaignGameProtocall(True)
            Abilities.CoinAmountText.Text = My.Settings.userCredit

            My.Computer.Audio.Stop()
            My.Computer.Audio.Play(My.Resources.win_untitledprogress, AudioPlayMode.Background)
        ElseIf gameResult = 2 Then
            Label4.Text = "Loss! " & "-" & My.Settings.gameXP & "XP"
            My.Settings.userXP = My.Settings.userXP - My.Settings.gameXP
            My.Settings.Save()
            main.TextBox1.Text = My.Settings.userXP
            Campaign.CampaignGameProtocall(False)
            My.Computer.Audio.Play(My.Resources.gameover_untitledprogress, AudioPlayMode.Background)
        ElseIf gameResult = 3 Then
            Label4.Text = "Forfit! " & "-" & My.Settings.gameXP & "XP"
            My.Settings.userXP = My.Settings.userXP - My.Settings.gameXP
            My.Settings.Save()
            main.TextBox1.Text = My.Settings.userXP
            Campaign.CampaignGameProtocall(False)
            My.Computer.Audio.Play(My.Resources.gameover_untitledprogress, AudioPlayMode.Background)
        End If

        ' Start the timer to close the form after 5 seconds
        EndTimer.Enabled = True

    End Function


    Function OpponentLogic()
        'OpponentLogic is called every tick.

        opponentCooldownRegulator = opponentCooldownRegulator + 1
        ToolStripMenuItem1.Text = opponentCooldownA
        ToolStripMenuItem2.Text = opponentCooldownB
        ToolStripMenuItem3.Text = opponentCooldownC
        ToolStripMenuItem4.Text = opponentCooldownRegulator

        If opponentCooldownRegulator = 5 Then
            opponentCooldownA = opponentCooldownA - 1
            opponentCooldownB = opponentCooldownB - 1
            opponentCooldownC = opponentCooldownC - 1
            opponentCooldownRegulator = 0
        End If


        If opponentCooldownC = 0 And opponentCooldownUsed = True Then
            opponentCooldownUsed = False
            If ProgressBar1.Value > 25 Then
                ProgressBar1.Value = ProgressBar1.Value - 25
            End If
            If ProgressBar1.Value = 25 Or ProgressBar1.Value < 25 Then
                ProgressBar1.Value = 0
                winEndProtocall(2)
            End If
            difficultySetter(3)
        End If

        If opponentCooldownB = 0 And opponentCooldownUsed = True Then
            opponentCooldownUsed = False
            If ProgressBar1.Value > 15 Then
                ProgressBar1.Value = ProgressBar1.Value - 15
            End If
            If ProgressBar1.Value = 15 Or ProgressBar1.Value < 15 Then
                ProgressBar1.Value = 0
                winEndProtocall(2)
            End If
            difficultySetter(2)
        End If

        If opponentCooldownA = 0 And opponentCooldownUsed = True Then
            opponentCooldownUsed = False
            If ProgressBar1.Value > 5 Then
                ProgressBar1.Value = ProgressBar1.Value - 5
            End If
            If ProgressBar1.Value = 5 Or ProgressBar1.Value < 5 Then
                ProgressBar1.Value = 0
                winEndProtocall(2)
            End If
            difficultySetter(1)
        End If

        opponentCooldownUsed = True



    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value > 0 Then
            If Autoclicker = True Then
                If ProgressBar1.Value < (100 - AutoclickerSpeed) Then
                    ProgressBar1.Value = ProgressBar1.Value + AutoclickerSpeed
                Else
                    ProgressBar1.Value = 100
                    winEndProtocall(1)
                End If
            End If
            If ProgressBar1.Value > My.Settings.OppClickSpeed Then
                ProgressBar1.Value = ProgressBar1.Value - My.Settings.OppClickSpeed
            Else
                ProgressBar1.Value = 0
            End If
            OpponentLogic()
        End If
        If ProgressBar1.Value = 100 Then
            winEndProtocall(1)
        End If
        If ProgressBar1.Value = 0 Then
            winEndProtocall(2)
        End If

        ToolStripMenuItem5.Text = ProgressBar1.Value

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        ' Power-Ups Logic

        If AStatus = True Then
            UserA = UserA - 1
            Button2.Text = UserA
        End If

        If BStatus = True Then
            UserB = UserB - 1
            Button3.Text = UserB
        End If

        If CStatus = True Then
            UserC = UserC - 1
            Button4.Text = UserC
        End If


        If UserA = 0 Then
            Button2.Enabled = True
            Button2.Text = "Blunt Attack (-5)"
            AStatus = False
        End If

        If UserB = 0 Then
            Button3.Enabled = True
            Button3.Text = "Flaming Fire (-15)"
            BStatus = False
        End If

        If UserC = 0 Then
            Button4.Enabled = True
            Button4.Text = "Electricution (-25)"
            CStatus = False
        End If

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        ' Stop the timer when the key is released
        If e.KeyCode = trackedKey Then
            keyIsHeld = False
            keyHoldTimer.Stop()
        End If
    End Sub

    Private Sub ProcessKeyPress(keyCode As Keys)
        If keyCode = Keys.J Or keyCode = Keys.K Or keyCode = Keys.L Then
            If GameStarted = True Then
                If ProgressBar1.Value = 100 Then
                    winEndProtocall(1)
                Else
                    ProgressBar1.Value = ProgressBar1.Value + 1
                End If
            End If
        End If

        ' Blunt Attack
        If keyCode = Keys.A Then
            If GameStarted = True And Button2.Enabled = True Then
                If ProgressBar1.Value = 95 Or ProgressBar1.Value > 95 Then
                    ProgressBar1.Value = 100
                    winEndProtocall(1)
                Else
                    ProgressBar1.Value = ProgressBar1.Value + 5
                    Button2.Enabled = False
                    UserA = 20 - My.Settings.CooldownALevel
                    Button2.Text = UserA
                    AStatus = True
                End If
            End If
        End If

        ' Flaming Fire
        If keyCode = Keys.S Then
            If GameStarted = True And Button3.Enabled = True Then
                If ProgressBar1.Value = 85 Or ProgressBar1.Value > 85 Then
                    ProgressBar1.Value = 100
                    winEndProtocall(1)
                Else
                    ProgressBar1.Value = ProgressBar1.Value + 15
                    Button3.Enabled = False
                    UserB = 40 - My.Settings.CooldownBLevel
                    Button3.Text = UserB
                    BStatus = True
                End If
            End If
        End If

        ' Electricution
        If keyCode = Keys.D Then
            If GameStarted = True And Button4.Enabled = True Then
                If ProgressBar1.Value = 75 Or ProgressBar1.Value > 75 Then
                    ProgressBar1.Value = 100
                    winEndProtocall(1)
                Else
                    ProgressBar1.Value = ProgressBar1.Value + 25
                    Button4.Enabled = False
                    UserC = 60 - My.Settings.CooldownCLevel
                    Button4.Text = UserC
                    CStatus = True
                End If
            End If
        End If

        ' Autoclicker
        If keyCode = Keys.Q Then
            If Autoclicker = True Then
                Button5.BackColor = Color.Green
                Autoclicker = False
            ElseIf Autoclicker = False And AutoclickerSpeed > 0 Then
                Button5.BackColor = Color.Lime
                Autoclicker = True
            End If
        End If

    End Sub

    Private Sub RunAwayForefitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunAwayForefitToolStripMenuItem.Click
        If GameStarted = True Then
            ProgressBar1.Value = 0
            winEndProtocall(3)
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If GameStarted = True Then
            Dim result = MsgBox("Exiting right now is a forfit. Are you sure?", vbYesNo)
            If result = DialogResult.Yes Then
                winEndProtocall(3)
                Me.Close()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub EndTimer_Tick(sender As Object, e As EventArgs) Handles EndTimer.Tick
        Me.Close()
    End Sub

End Class
