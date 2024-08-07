Public Class Abilities

    ' Load event for the form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPowerupStats()
    End Sub

    ' Load all power-up stats
    Private Sub LoadPowerupStats()
        LoadPowerup("Blunt Attack", My.Settings.CooldownALevel, 25, 20, 5, Label2, ProgressBar2, Button1)
        LoadPowerup("Flaming Fire", My.Settings.CooldownBLevel, 50, 40, 15, Label3, ProgressBar1, Button2)
        LoadPowerup("Electrocution", My.Settings.CooldownCLevel, 100, 60, 30, Label5, ProgressBar3, Button3)
        LoadAutoclickerRate("Autoclicker", My.Settings.AutoclickerLevel, 1000, 0, 5, Label7, ProgressBar4, Button4)
        CoinAmountText.Text = My.Settings.userCredit.ToString() & " coins"
    End Sub

    ' Function to load a specific power-up's stats
    Private Sub LoadPowerup(powerupName As String, userLevel As Integer, baseCost As Integer, baseCooldown As Integer, minCooldown As Integer, cooldownLabel As Label, progressBar As ProgressBar, upgradeButton As Button)
        ' Calculate the current cooldown based on the user level
        Dim cooldown As Integer
        If userLevel = 0 Then
            cooldown = baseCooldown
        Else
            cooldown = Math.Max(baseCooldown - userLevel, minCooldown)
        End If

        ' Update the label with the cooldown time
        cooldownLabel.Text = $"{powerupName.ToUpper()} COOLDOWN: {cooldown} seconds"

        ' Update the progress bar with the current level
        progressBar.Maximum = baseCooldown - minCooldown
        progressBar.Value = userLevel

        ' Update the upgrade button's text with the current cost
        UpdateUpgradeButton(upgradeButton, CalculateUpgradeCost(userLevel, baseCost), userLevel, baseCooldown, minCooldown)
    End Sub

    ' Function to load the Autoclicker power-up stats (rate increases with level)
    Private Sub LoadAutoclickerRate(powerupName As String, userLevel As Integer, baseCost As Integer, baseRate As Integer, maxRate As Integer, rateLabel As Label, progressBar As ProgressBar, upgradeButton As Button)
        ' Determine the rate or show as disabled if level is 0
        Dim rateText As String = If(userLevel = 0, "Disabled", (baseRate + userLevel).ToString() & " clicks per second")

        ' Update the label with the rate or disabled status
        rateLabel.Text = $"{powerupName.ToUpper()} RATE: {rateText}"

        ' Update the progress bar with the current level
        progressBar.Maximum = maxRate
        progressBar.Value = userLevel

        ' Update the upgrade button's text with the current cost
        UpdateUpgradeButton(upgradeButton, CalculateUpgradeCost(userLevel, baseCost), userLevel, maxRate)
    End Sub

    ' Function to update the upgrade button's state
    Private Sub UpdateUpgradeButton(button As Button, cost As Integer, currentLevel As Integer, Optional maxValue As Integer = 0, Optional minCooldown As Integer = 0)
        If My.Settings.userCredit < cost Then
            button.Text = $"Upgrade for {cost} coins"
            button.Enabled = False
        ElseIf currentLevel >= (maxValue - minCooldown) Then
            button.Text = "Max Level"
            button.Enabled = False
        Else
            button.Text = $"Upgrade for {cost} coins"
            button.Enabled = True
        End If
    End Sub

    ' Function to calculate the upgrade cost based on current level
    Private Function CalculateUpgradeCost(currentLevel As Integer, baseCost As Integer) As Integer
        ' Incremental cost calculation
        Return baseCost * (currentLevel + 1)
    End Function

    ' Upgrade button click events
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpgradePowerup("Blunt Attack", My.Settings.CooldownALevel, 25, 20, 5, Button1, Label2, ProgressBar2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UpgradePowerup("Flaming Fire", My.Settings.CooldownBLevel, 50, 40, 15, Button2, Label3, ProgressBar1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UpgradePowerup("Electrocution", My.Settings.CooldownCLevel, 100, 60, 30, Button3, Label5, ProgressBar3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        UpgradeAutoclicker("Autoclicker", My.Settings.AutoclickerLevel, 1000, 0, 5, Button4, Label7, ProgressBar4)
    End Sub

    ' Function to handle upgrading a power-up
    Private Sub UpgradePowerup(powerupName As String, ByRef powerupLevel As Integer, baseCost As Integer, baseCooldown As Integer, minCooldown As Integer, upgradeButton As Button, cooldownLabel As Label, progressBar As ProgressBar)
        Dim upgradeCost As Integer = CalculateUpgradeCost(powerupLevel, baseCost)

        ' Check if the user has enough credits to upgrade
        If My.Settings.userCredit >= upgradeCost AndAlso powerupLevel < (baseCooldown - minCooldown) Then
            ' Deduct the cost from the user's credit
            My.Settings.userCredit -= upgradeCost
            CoinAmountText.Text = My.Settings.userCredit.ToString() & " coins"

            ' Increase the power-up level
            powerupLevel += 1
            My.Settings.Save()

            ' Play system asterisk sound
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)

            ' Reload the current level and cooldown time
            LoadPowerup(powerupName, powerupLevel, baseCost, baseCooldown, minCooldown, cooldownLabel, progressBar, upgradeButton)

            ' Update the button state
            UpdateUpgradeButton(upgradeButton, upgradeCost, powerupLevel, baseCooldown, minCooldown)
        Else
            ' Update the button state for max level or insufficient credits
            UpdateUpgradeButton(upgradeButton, upgradeCost, powerupLevel, baseCooldown, minCooldown)
        End If
    End Sub

    ' Function to handle upgrading the Autoclicker
    Private Sub UpgradeAutoclicker(powerupName As String, ByRef autoclickerLevel As Integer, baseCost As Integer, baseRate As Integer, maxRate As Integer, upgradeButton As Button, rateLabel As Label, progressBar As ProgressBar)
        Dim upgradeCost As Integer = CalculateUpgradeCost(autoclickerLevel, baseCost)

        ' Check if the user has enough credits to upgrade
        If My.Settings.userCredit >= upgradeCost AndAlso autoclickerLevel < maxRate Then
            ' Deduct the cost from the user's credit
            My.Settings.userCredit -= upgradeCost
            CoinAmountText.Text = My.Settings.userCredit.ToString() & " coins"

            ' Increase the autoclicker level
            autoclickerLevel += 1
            My.Settings.Save()

            ' Play system asterisk sound
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)

            ' Reload the current level and rate
            LoadAutoclickerRate(powerupName, autoclickerLevel, baseCost, baseRate, maxRate, rateLabel, progressBar, upgradeButton)

            ' Update the button state
            UpdateUpgradeButton(upgradeButton, upgradeCost, autoclickerLevel, maxRate)
        Else
            ' Update the button state for max level or insufficient credits
            UpdateUpgradeButton(upgradeButton, upgradeCost, autoclickerLevel, maxRate)
        End If
    End Sub

End Class