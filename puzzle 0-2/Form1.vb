Imports System.Windows.Forms.VisualStyles.VisualStyleElement

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
    Dim AutoclickerSpeed As Integer = 5

#End Region

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
            Label4.Text = "You have Won the game! (Game has ended, Close this window.)"
            My.Settings.userXP = My.Settings.userXP + My.Settings.gameXP
            My.Settings.userCredit = My.Settings.userCredit + My.Settings.gameCredit
            My.Settings.Save()
            main.TextBox1.Text = My.Settings.userXP
            Abilities.CoinAmountText.Text = My.Settings.userCredit
            My.Computer.Audio.Play(My.Resources.gameWin, AudioPlayMode.Background)
        ElseIf gameResult = 2 Then
            Label4.Text = "You have Lost. Dont give up, keep trying! (Game has ended, Close this window.)"
            My.Settings.userXP = My.Settings.userXP - My.Settings.gameXP
            My.Settings.Save()
            main.TextBox1.Text = My.Settings.userXP
            My.Computer.Audio.Play(My.Resources.failure, AudioPlayMode.Background)
        ElseIf gameResult = 3 Then
            Label4.Text = "You have Forfited and lost. (Game has ended, Close this window.)"
            My.Settings.userXP = My.Settings.userXP - My.Settings.gameXP
            My.Settings.Save()
            main.TextBox1.Text = My.Settings.userXP
            My.Computer.Audio.Play(My.Resources.failure, AudioPlayMode.Background)
        End If

    End Function

    Function OpponentLogic()
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

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        ' Normal Attack
        If e.KeyChar = "j" Or e.KeyChar = "k" Or e.KeyChar = "l" Or e.KeyChar = "J" Or e.KeyChar = "K" Or e.KeyChar = "L" Then
            If GameStarted = True Then
                If ProgressBar1.Value = 100 Then
                    winEndProtocall(1)
                Else
                    ProgressBar1.Value = ProgressBar1.Value + 1
                End If
            End If
        End If

        ' Blunt Attack
        If e.KeyChar = "a" Or e.KeyChar = "A" Then
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
        If e.KeyChar = "s" Or e.KeyChar = "S" Then
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
        If e.KeyChar = "d" Or e.KeyChar = "D" Then
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
        If e.KeyChar = "q" Or e.KeyChar = "Q" Then
            If Autoclicker = True Then
                Button5.BackColor = Color.Green
                Autoclicker = False
            ElseIf Autoclicker = False Then
                Button5.BackColor = Color.Lime
                Autoclicker = True
            End If
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If GameStarted = True Then
            If ProgressBar1.Value = 100 Then
                winEndProtocall(1)
            Else
                ProgressBar1.Value = ProgressBar1.Value + 1
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If GameStarted = True Then
            If ProgressBar1.Value = 95 Or ProgressBar1.Value > 95 Then
                ProgressBar1.Value = 100
                winEndProtocall(1)
            Else
                ProgressBar1.Value = ProgressBar1.Value + 5
                Button2.Enabled = False
                Button2.Text = "15"
                UserA = 15
                AStatus = True
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If GameStarted = True Then
            If ProgressBar1.Value = 85 Or ProgressBar1.Value > 85 Then
                ProgressBar1.Value = 100
                winEndProtocall(1)
            Else
                ProgressBar1.Value = ProgressBar1.Value + 15
                Button3.Enabled = False
                Button3.Text = "25"
                UserB = 25
                BStatus = True
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If GameStarted = True Then
            If ProgressBar1.Value = 75 Or ProgressBar1.Value > 75 Then
                ProgressBar1.Value = 100
                winEndProtocall(1)
            Else
                ProgressBar1.Value = ProgressBar1.Value + 25
                Button4.Enabled = False
                Button4.Text = "35"
                UserC = 35
                CStatus = True
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

End Class
