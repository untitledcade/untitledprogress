Imports System.Reflection.Emit
Imports System.Runtime.Remoting

Public Class Campaign
    Private Sub Campaign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateLevelButtons()
    End Sub

    Private Sub UpdateLevelButtons()
        ' Retrieve the current progress level from settings
        Dim currentLevel As Integer = My.Settings.userGameLevel

        ' Loop through each TabPage in the TabControl
        For Each tab As TabPage In TabControl1.TabPages
            ' Loop through each control in the current TabPage
            For Each ctrl As Control In tab.Controls
                ' Check if the control is a button and if its name starts with "Level"
                If TypeOf ctrl Is Button AndAlso ctrl.Name.StartsWith("Level") Then
                    ' Extract the level number from the button's name
                    Dim levelNumber As Integer
                    If Integer.TryParse(ctrl.Name.Replace("Level", ""), levelNumber) Then
                        ' Enable or disable the button based on the current progress level
                        If levelNumber = currentLevel Then
                            ctrl.Enabled = True
                            ctrl.BackColor = Color.LimeGreen
                        ElseIf levelNumber < currentLevel Then
                            ctrl.Enabled = True
                            ctrl.BackColor = Color.PaleGreen
                        Else
                            ctrl.Enabled = False
                            ctrl.BackColor = Color.LightCoral
                        End If
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub StartGame(ByVal Level As Integer, ByVal OppClick As Integer, ByVal OppA As Integer, ByVal OppB As Integer, ByVal OppC As Integer, ByVal XPAmt As Integer, ByVal CreditAmt As Integer)
        My.Settings.PlayingGameLevel = Level
        My.Settings.OppClickSpeed = OppClick
        My.Settings.OppCooldownA = OppA
        My.Settings.OppCooldownB = OppB
        My.Settings.OppCooldownC = OppC
        My.Settings.gameXP = XPAmt
        My.Settings.gameCredit = CreditAmt
        My.Settings.Save()
        Form1.Show()
    End Sub

    Sub StartGameDialouge(ByVal Level As Integer, ByVal OppClick As Integer, ByVal OppA As Integer, ByVal OppB As Integer, ByVal OppC As Integer, ByVal XPAmt As Integer, ByVal CreditAmt As Integer, Name As String, textToType As String, typingSpeed As Integer)
        My.Settings.PlayingGameLevel = Level
        My.Settings.OppClickSpeed = OppClick
        My.Settings.OppCooldownA = OppA
        My.Settings.OppCooldownB = OppB
        My.Settings.OppCooldownC = OppC
        My.Settings.gameXP = XPAmt
        My.Settings.gameCredit = CreditAmt
        My.Settings.Save()
        CampaignDialouge.Show()
        CampaignDialouge.StartGamewithDialog(Name, textToType, typingSpeed)

    End Sub

    Sub CampaignGameProtocall(ByVal Win As Boolean)
        If Win = True And My.Settings.PlayingGameLevel = My.Settings.userGameLevel Then
            My.Settings.userGameLevel = My.Settings.userGameLevel + 1
            UpdateLevelButtons()
            My.Settings.PlayingGameLevel = 0
        End If
    End Sub

#Region "Beginning"
    Private Sub Level1_Click(sender As Object, e As EventArgs) Handles Level1.Click
        StartGameDialouge(1, 1, 25, 50, 75, 10, 1, "Me", "Well, its time to test this out....", 20)
    End Sub

    Private Sub Level2_Click(sender As Object, e As EventArgs) Handles Level2.Click
        StartGame(2, 1, 20, 40, 60, 10, 3)
    End Sub

    Private Sub Level3_Click(sender As Object, e As EventArgs) Handles Level3.Click
        StartGame(3, 1, 20, 40, 60, 10, 3)
    End Sub

    Private Sub Level4_Click(sender As Object, e As EventArgs) Handles Level4.Click
        StartGame(4, 1, 18, 38, 58, 20, 5)
    End Sub

    Private Sub Level5_Click(sender As Object, e As EventArgs) Handles Level5.Click
        StartGameDialouge(5, 1, 17, 35, 50, 30, 5, "HoseVirus8000", "Well,look what we have here, an intruder! looks like fresh meat to me.", 20)
    End Sub

    Private Sub Level6_Click(sender As Object, e As EventArgs) Handles Level6.Click
        StartGameDialouge(6, 1, 15, 30, 45, 50, 10, "HoseVirus8000", "Shit! Looks like your little program is trying to defeat... Me??? HA! You dont stand a chance, and I cant let you go on the internet with that.... thing!", 20)

    End Sub

#End Region


    Private Sub Level7_Click(sender As Object, e As EventArgs) Handles Level7.Click
        StartGame(7, 1, 15, 30, 45, 50, 10)
    End Sub

    Private Sub Level8_Click(sender As Object, e As EventArgs) Handles Level8.Click
        StartGame(8, 1, 10, 20, 30, 55, 12)
    End Sub

    Private Sub Level9_Click(sender As Object, e As EventArgs) Handles Level9.Click
        StartGame(9, 1, 10, 25, 40, 55, 13)
    End Sub

    Private Sub Level10_Click(sender As Object, e As EventArgs) Handles Level10.Click
        StartGame(10, 1, 10, 25, 40, 55, 13)
    End Sub

    Private Sub Level11_Click(sender As Object, e As EventArgs) Handles Level11.Click
        StartGameDialouge(11, 2, 5, 10, 10, 50, 10, "HoseVirus8000", "HA! Found you now, scamp! your not ruining my chances of victory any longer!", 20)
    End Sub

    Private Sub Level12_Click(sender As Object, e As EventArgs) Handles Level12.Click
        StartGame(12, 1, 10, 15, 20, 60, 15)
    End Sub

    Private Sub Level13_Click(sender As Object, e As EventArgs) Handles Level13.Click
        StartGame(13, 1, 2, 30, 60, 60, 15)
    End Sub

    Private Sub Level14_Click(sender As Object, e As EventArgs) Handles Level14.Click
        StartGameDialouge(14, 2, 5, 10, 10, 70, 18, "HoseVirus8000", "Intrusion into Virus Distribution Center Detected! Your not going ANYWHERE.", 20)
    End Sub
End Class