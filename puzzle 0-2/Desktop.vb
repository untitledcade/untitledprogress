Imports puzzle_0_1.My

Public Class Desktop
    Private Sub QuitGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitGameToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub QuickGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuickGameToolStripMenuItem.Click
        QuickPlay.Show()
    End Sub

    Private Sub PowersAndAbilitiesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PowersAndAbilitiesToolStripMenuItem1.Click
        Abilities.Show()
    End Sub

    Private Sub DualStarter1v1GameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DualStarter1v1GameToolStripMenuItem.Click
        DuetGame.Show()
    End Sub

    Private Sub ResetSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetSettingsToolStripMenuItem.Click
        My.Settings.Reset()
    End Sub

    Private Sub AddCreditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCreditToolStripMenuItem.Click
        My.Settings.userCredit += 1000
        My.Settings.Save()
        Abilities.CoinAmountText.Text = My.Settings.userCredit
    End Sub

    Private Sub AllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllToolStripMenuItem.Click
        My.Settings.CooldownALevel = 15
        My.Settings.CooldownBLevel = 25
        My.Settings.CooldownCLevel = 30
        My.Settings.AutoclickerLevel = 5
        My.Settings.Save()
    End Sub

    Private Sub BluntToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BluntToolStripMenuItem.Click
        My.Settings.CooldownALevel = 15
        My.Settings.Save()
    End Sub

    Private Sub FireToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FireToolStripMenuItem.Click
        My.Settings.CooldownBLevel = 25
        My.Settings.Save()
    End Sub

    Private Sub ElectricToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElectricToolStripMenuItem.Click
        My.Settings.CooldownCLevel = 30
        My.Settings.Save()
    End Sub

    Private Sub AutoclickerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoclickerToolStripMenuItem.Click
        My.Settings.AutoclickerLevel = 5
        My.Settings.Save()
    End Sub

    Private Sub ViewLegacyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewLegacyToolStripMenuItem.Click
        main.Show()
    End Sub
End Class