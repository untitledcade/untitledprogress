<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Desktop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Desktop))
        Me.TaskBar = New System.Windows.Forms.MenuStrip()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CampaignToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuickGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DualStarter1v1GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PowersAndAbilitiesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhatsNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewLegacyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaxLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpecificToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BluntToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ElectricToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoclickerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCreditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EasterEggToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WheelOfAllOddsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'TaskBar
        '
        Me.TaskBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TaskBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TaskBar.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.TaskBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.UserToolStripMenuItem, Me.InformationToolStripMenuItem, Me.DebugToolStripMenuItem})
        Me.TaskBar.Location = New System.Drawing.Point(0, 497)
        Me.TaskBar.Name = "TaskBar"
        Me.TaskBar.Size = New System.Drawing.Size(1061, 40)
        Me.TaskBar.TabIndex = 1
        Me.TaskBar.Text = "MenuStrip1"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.BackColor = System.Drawing.Color.LimeGreen
        Me.StartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CampaignToolStripMenuItem, Me.QuickGameToolStripMenuItem, Me.CustomGameToolStripMenuItem, Me.DualStarter1v1GameToolStripMenuItem, Me.WheelOfAllOddsToolStripMenuItem, Me.QuitGameToolStripMenuItem})
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(74, 36)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'CampaignToolStripMenuItem
        '
        Me.CampaignToolStripMenuItem.Name = "CampaignToolStripMenuItem"
        Me.CampaignToolStripMenuItem.Size = New System.Drawing.Size(397, 36)
        Me.CampaignToolStripMenuItem.Text = "MalCure9000 (Campaign)"
        '
        'QuickGameToolStripMenuItem
        '
        Me.QuickGameToolStripMenuItem.Name = "QuickGameToolStripMenuItem"
        Me.QuickGameToolStripMenuItem.Size = New System.Drawing.Size(397, 36)
        Me.QuickGameToolStripMenuItem.Text = "QuickLanucher (Quick Game)"
        '
        'CustomGameToolStripMenuItem
        '
        Me.CustomGameToolStripMenuItem.Name = "CustomGameToolStripMenuItem"
        Me.CustomGameToolStripMenuItem.Size = New System.Drawing.Size(397, 36)
        Me.CustomGameToolStripMenuItem.Text = "PracticeBot (Custom)"
        '
        'DualStarter1v1GameToolStripMenuItem
        '
        Me.DualStarter1v1GameToolStripMenuItem.Name = "DualStarter1v1GameToolStripMenuItem"
        Me.DualStarter1v1GameToolStripMenuItem.Size = New System.Drawing.Size(397, 36)
        Me.DualStarter1v1GameToolStripMenuItem.Text = "DualStarter (1v1 game)"
        '
        'QuitGameToolStripMenuItem
        '
        Me.QuitGameToolStripMenuItem.Name = "QuitGameToolStripMenuItem"
        Me.QuitGameToolStripMenuItem.Size = New System.Drawing.Size(397, 36)
        Me.QuitGameToolStripMenuItem.Text = "Quit Game"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PowersAndAbilitiesToolStripMenuItem1, Me.StatsToolStripMenuItem1, Me.GameSettingsToolStripMenuItem})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(73, 36)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'PowersAndAbilitiesToolStripMenuItem1
        '
        Me.PowersAndAbilitiesToolStripMenuItem1.Name = "PowersAndAbilitiesToolStripMenuItem1"
        Me.PowersAndAbilitiesToolStripMenuItem1.Size = New System.Drawing.Size(300, 36)
        Me.PowersAndAbilitiesToolStripMenuItem1.Text = "Powers and Abilities"
        '
        'StatsToolStripMenuItem1
        '
        Me.StatsToolStripMenuItem1.Name = "StatsToolStripMenuItem1"
        Me.StatsToolStripMenuItem1.Size = New System.Drawing.Size(300, 36)
        Me.StatsToolStripMenuItem1.Text = "Stats"
        '
        'GameSettingsToolStripMenuItem
        '
        Me.GameSettingsToolStripMenuItem.Name = "GameSettingsToolStripMenuItem"
        Me.GameSettingsToolStripMenuItem.Size = New System.Drawing.Size(300, 36)
        Me.GameSettingsToolStripMenuItem.Text = "Game Settings"
        '
        'InformationToolStripMenuItem
        '
        Me.InformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WhatsNewToolStripMenuItem, Me.NewsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem"
        Me.InformationToolStripMenuItem.Size = New System.Drawing.Size(151, 36)
        Me.InformationToolStripMenuItem.Text = "Information"
        '
        'WhatsNewToolStripMenuItem
        '
        Me.WhatsNewToolStripMenuItem.Name = "WhatsNewToolStripMenuItem"
        Me.WhatsNewToolStripMenuItem.Size = New System.Drawing.Size(220, 36)
        Me.WhatsNewToolStripMenuItem.Text = "Whats New?"
        '
        'NewsToolStripMenuItem
        '
        Me.NewsToolStripMenuItem.Name = "NewsToolStripMenuItem"
        Me.NewsToolStripMenuItem.Size = New System.Drawing.Size(220, 36)
        Me.NewsToolStripMenuItem.Text = "News"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(220, 36)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'DebugToolStripMenuItem
        '
        Me.DebugToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewLegacyToolStripMenuItem, Me.MaxLevelToolStripMenuItem, Me.AddCreditToolStripMenuItem, Me.ResetSettingsToolStripMenuItem, Me.EasterEggToolStripMenuItem})
        Me.DebugToolStripMenuItem.Name = "DebugToolStripMenuItem"
        Me.DebugToolStripMenuItem.Size = New System.Drawing.Size(98, 36)
        Me.DebugToolStripMenuItem.Text = "Debug"
        '
        'ViewLegacyToolStripMenuItem
        '
        Me.ViewLegacyToolStripMenuItem.Name = "ViewLegacyToolStripMenuItem"
        Me.ViewLegacyToolStripMenuItem.Size = New System.Drawing.Size(238, 36)
        Me.ViewLegacyToolStripMenuItem.Text = "View Legacy"
        '
        'MaxLevelToolStripMenuItem
        '
        Me.MaxLevelToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllToolStripMenuItem, Me.SpecificToolStripMenuItem, Me.AutoclickerToolStripMenuItem})
        Me.MaxLevelToolStripMenuItem.Name = "MaxLevelToolStripMenuItem"
        Me.MaxLevelToolStripMenuItem.Size = New System.Drawing.Size(238, 36)
        Me.MaxLevelToolStripMenuItem.Text = "Max Level"
        '
        'AllToolStripMenuItem
        '
        Me.AllToolStripMenuItem.Name = "AllToolStripMenuItem"
        Me.AllToolStripMenuItem.Size = New System.Drawing.Size(206, 36)
        Me.AllToolStripMenuItem.Text = "All"
        '
        'SpecificToolStripMenuItem
        '
        Me.SpecificToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BluntToolStripMenuItem, Me.FireToolStripMenuItem, Me.ElectricToolStripMenuItem})
        Me.SpecificToolStripMenuItem.Name = "SpecificToolStripMenuItem"
        Me.SpecificToolStripMenuItem.Size = New System.Drawing.Size(206, 36)
        Me.SpecificToolStripMenuItem.Text = "Specific"
        '
        'BluntToolStripMenuItem
        '
        Me.BluntToolStripMenuItem.Name = "BluntToolStripMenuItem"
        Me.BluntToolStripMenuItem.Size = New System.Drawing.Size(163, 36)
        Me.BluntToolStripMenuItem.Text = "Blunt"
        '
        'FireToolStripMenuItem
        '
        Me.FireToolStripMenuItem.Name = "FireToolStripMenuItem"
        Me.FireToolStripMenuItem.Size = New System.Drawing.Size(163, 36)
        Me.FireToolStripMenuItem.Text = "Fire"
        '
        'ElectricToolStripMenuItem
        '
        Me.ElectricToolStripMenuItem.Name = "ElectricToolStripMenuItem"
        Me.ElectricToolStripMenuItem.Size = New System.Drawing.Size(163, 36)
        Me.ElectricToolStripMenuItem.Text = "Electric"
        '
        'AutoclickerToolStripMenuItem
        '
        Me.AutoclickerToolStripMenuItem.Name = "AutoclickerToolStripMenuItem"
        Me.AutoclickerToolStripMenuItem.Size = New System.Drawing.Size(206, 36)
        Me.AutoclickerToolStripMenuItem.Text = "Autoclicker"
        '
        'AddCreditToolStripMenuItem
        '
        Me.AddCreditToolStripMenuItem.Name = "AddCreditToolStripMenuItem"
        Me.AddCreditToolStripMenuItem.Size = New System.Drawing.Size(238, 36)
        Me.AddCreditToolStripMenuItem.Text = "Add Credit"
        '
        'ResetSettingsToolStripMenuItem
        '
        Me.ResetSettingsToolStripMenuItem.Name = "ResetSettingsToolStripMenuItem"
        Me.ResetSettingsToolStripMenuItem.Size = New System.Drawing.Size(238, 36)
        Me.ResetSettingsToolStripMenuItem.Text = "Reset Settings"
        '
        'EasterEggToolStripMenuItem
        '
        Me.EasterEggToolStripMenuItem.Name = "EasterEggToolStripMenuItem"
        Me.EasterEggToolStripMenuItem.Size = New System.Drawing.Size(238, 36)
        Me.EasterEggToolStripMenuItem.Text = "Easter Egg"
        '
        'WheelOfAllOddsToolStripMenuItem
        '
        Me.WheelOfAllOddsToolStripMenuItem.Name = "WheelOfAllOddsToolStripMenuItem"
        Me.WheelOfAllOddsToolStripMenuItem.Size = New System.Drawing.Size(397, 36)
        Me.WheelOfAllOddsToolStripMenuItem.Text = "Wheel of All Odds"
        '
        'Desktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1061, 537)
        Me.Controls.Add(Me.TaskBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Desktop"
        Me.Text = "Desktop"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TaskBar.ResumeLayout(False)
        Me.TaskBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TaskBar As MenuStrip
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PowersAndAbilitiesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StatsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhatsNewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CampaignToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuickGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GameSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DualStarter1v1GameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DebugToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddCreditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaxLevelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpecificToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BluntToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FireToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ElectricToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutoclickerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewLegacyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EasterEggToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WheelOfAllOddsToolStripMenuItem As ToolStripMenuItem
End Class
