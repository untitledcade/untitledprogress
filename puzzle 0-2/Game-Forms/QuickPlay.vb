Public Class QuickPlay

    Function StartGame(ByVal OppClick As Integer, ByVal OppA As Integer, ByVal OppB As Integer, ByVal OppC As Integer, ByVal XPAmt As Integer, ByVal CreditAmt As Integer)
        My.Settings.OppClickSpeed = OppClick
        My.Settings.OppCooldownA = OppA
        My.Settings.OppCooldownB = OppB
        My.Settings.OppCooldownC = OppC
        My.Settings.gameXP = XPAmt
        My.Settings.gameCredit = CreditAmt
        My.Settings.Save()
        Form1.Show()
    End Function

    Private Sub BabyModeButton_Click(sender As Object, e As EventArgs) Handles BabyModeButton.Click
        StartGame(1, 15, 25, 35, 25, 0.5)
    End Sub

    Private Sub NormalButton_Click(sender As Object, e As EventArgs) Handles NormalButton.Click
        StartGame(1, 9, 15, 25, 50, 5)
    End Sub

    Private Sub ModerateButton_Click(sender As Object, e As EventArgs) Handles ModerateButton.Click
        StartGame(1, 5, 10, 15, 100, 10)
    End Sub

    Private Sub HardButton_Click(sender As Object, e As EventArgs) Handles HardButton.Click
        StartGame(2, 3, 6, 9, 200, 20)
    End Sub

    Private Sub GamerButton_Click(sender As Object, e As EventArgs) Handles GamerButton.Click
        StartGame(1, 1, 3, 5, 500, 50)
    End Sub

    Private Sub MarvButton_Click(sender As Object, e As EventArgs) Handles MarvButton.Click
        StartGame(5, 5, 10, 15, 1000, 100)
    End Sub
End Class