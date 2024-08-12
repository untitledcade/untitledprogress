Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles

Public Class XPConverter

    Dim XPBetted As Integer

    Function UpdateCounters()
        CoinAmountText.Text = My.Settings.userCredit
        Label1.Text = My.Settings.userXP
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        XPBetted = NumericUpDown1.Value
        If XPBetted = 0 Then
            CampaignDialouge.Show()
            CampaignDialouge.CampaignDialouge("The Wheel of Odds", "Yeaaaa you can bet nothing. Please put at least 1 XP there.", 25)
        ElseIf My.Settings.userXP < XPBetted Then
            Campaign.StartGameDialouge(0, 3, 5, 15, 30, 600, 50, "The Wheel of Odds", "You think your slick? You think you can finess me? HELL NAH.", 25)
            Me.Close()
        ElseIf My.Settings.userXP >= XPBetted Then
            My.Settings.userXP = My.Settings.userXP - XPBetted
            My.Settings.Save()
            Dim rand As New Random()

            Dim actionWheel As Integer = rand.Next(1, 4)
            Dim amountWheel As Integer = rand.Next(1, XPBetted)

            If actionWheel = 1 Then
                My.Settings.userCredit = My.Settings.userCredit + amountWheel
                WheelText.Text = "Earned " & amountWheel & " BugCoin!"
            ElseIf actionWheel = 3 Then
                My.Settings.userXP = My.Settings.userXP + amountWheel
                WheelText.Text = "Earned " & amountWheel & " XP!"
            ElseIf actionWheel = 2 Then
                My.Settings.userCredit = My.Settings.userCredit - amountWheel
                WheelText.Text = "Lost " & amountWheel & " BugCoin!"
            ElseIf actionWheel = 4 Then
                My.Settings.userXP = My.Settings.userXP - amountWheel
                WheelText.Text = "Lost " & amountWheel & " XP!"
            End If

            actionWheel = 0
            amountWheel = 0
            NumericUpDown1.Value = 0
            UpdateCounters()

        End If

    End Sub

    Private Sub XPConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateCounters()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class