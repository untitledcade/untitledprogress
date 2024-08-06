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
End Class