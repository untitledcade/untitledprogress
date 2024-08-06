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
        Me.QuitGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PowersAndAbilitiesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhatsNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DualStarter1v1GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'TaskBar
        '
        Me.TaskBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TaskBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TaskBar.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.TaskBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.UserToolStripMenuItem, Me.InformationToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.TaskBar.Location = New System.Drawing.Point(0, 497)
        Me.TaskBar.Name = "TaskBar"
        Me.TaskBar.Size = New System.Drawing.Size(1061, 40)
        Me.TaskBar.TabIndex = 1
        Me.TaskBar.Text = "MenuStrip1"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.BackColor = System.Drawing.Color.LimeGreen
        Me.StartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CampaignToolStripMenuItem, Me.QuickGameToolStripMenuItem, Me.CustomGameToolStripMenuItem, Me.DualStarter1v1GameToolStripMenuItem, Me.QuitGameToolStripMenuItem})
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
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 36)
        '
        'DualStarter1v1GameToolStripMenuItem
        '
        Me.DualStarter1v1GameToolStripMenuItem.Name = "DualStarter1v1GameToolStripMenuItem"
        Me.DualStarter1v1GameToolStripMenuItem.Size = New System.Drawing.Size(397, 36)
        Me.DualStarter1v1GameToolStripMenuItem.Text = "DualStarter (1v1 game)"
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
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GameSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DualStarter1v1GameToolStripMenuItem As ToolStripMenuItem
End Class
