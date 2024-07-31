<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Desktop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Desktop))
        Me.TaskBar = New System.Windows.Forms.MenuStrip()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CampaignToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuickGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PowersAndAbilitiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotYouSaveDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'TaskBar
        '
        Me.TaskBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TaskBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TaskBar.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.TaskBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.ToolStripMenuItem1, Me.UserToolStripMenuItem})
        Me.TaskBar.Location = New System.Drawing.Point(0, 509)
        Me.TaskBar.Name = "TaskBar"
        Me.TaskBar.Size = New System.Drawing.Size(1061, 28)
        Me.TaskBar.TabIndex = 1
        Me.TaskBar.Text = "MenuStrip1"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.BackColor = System.Drawing.Color.LimeGreen
        Me.StartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayGameToolStripMenuItem, Me.PowersAndAbilitiesToolStripMenuItem, Me.StatsToolStripMenuItem, Me.HelpButton, Me.GameSettingsToolStripMenuItem, Me.QuitGameToolStripMenuItem})
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'PlayGameToolStripMenuItem
        '
        Me.PlayGameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CampaignToolStripMenuItem, Me.QuickGameToolStripMenuItem, Me.CustomGameToolStripMenuItem})
        Me.PlayGameToolStripMenuItem.Name = "PlayGameToolStripMenuItem"
        Me.PlayGameToolStripMenuItem.Size = New System.Drawing.Size(211, 24)
        Me.PlayGameToolStripMenuItem.Text = "Play Game"
        '
        'CampaignToolStripMenuItem
        '
        Me.CampaignToolStripMenuItem.Name = "CampaignToolStripMenuItem"
        Me.CampaignToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.CampaignToolStripMenuItem.Text = "Campaign"
        '
        'QuickGameToolStripMenuItem
        '
        Me.QuickGameToolStripMenuItem.Name = "QuickGameToolStripMenuItem"
        Me.QuickGameToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.QuickGameToolStripMenuItem.Text = "Quick Game"
        '
        'CustomGameToolStripMenuItem
        '
        Me.CustomGameToolStripMenuItem.Name = "CustomGameToolStripMenuItem"
        Me.CustomGameToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.CustomGameToolStripMenuItem.Text = "Custom Game"
        '
        'PowersAndAbilitiesToolStripMenuItem
        '
        Me.PowersAndAbilitiesToolStripMenuItem.Name = "PowersAndAbilitiesToolStripMenuItem"
        Me.PowersAndAbilitiesToolStripMenuItem.Size = New System.Drawing.Size(211, 24)
        Me.PowersAndAbilitiesToolStripMenuItem.Text = "Powers and Abilities"
        '
        'StatsToolStripMenuItem
        '
        Me.StatsToolStripMenuItem.Name = "StatsToolStripMenuItem"
        Me.StatsToolStripMenuItem.Size = New System.Drawing.Size(211, 24)
        Me.StatsToolStripMenuItem.Text = "Stats"
        '
        'HelpButton
        '
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(211, 24)
        Me.HelpButton.Text = "Help"
        '
        'GameSettingsToolStripMenuItem
        '
        Me.GameSettingsToolStripMenuItem.Name = "GameSettingsToolStripMenuItem"
        Me.GameSettingsToolStripMenuItem.Size = New System.Drawing.Size(211, 24)
        Me.GameSettingsToolStripMenuItem.Text = "Game Settings"
        '
        'QuitGameToolStripMenuItem
        '
        Me.QuitGameToolStripMenuItem.Name = "QuitGameToolStripMenuItem"
        Me.QuitGameToolStripMenuItem.Size = New System.Drawing.Size(211, 24)
        Me.QuitGameToolStripMenuItem.Text = "Quit Game"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 24)
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NotYouSaveDataToolStripMenuItem})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(50, 24)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'NotYouSaveDataToolStripMenuItem
        '
        Me.NotYouSaveDataToolStripMenuItem.Name = "NotYouSaveDataToolStripMenuItem"
        Me.NotYouSaveDataToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.NotYouSaveDataToolStripMenuItem.Text = "Not You? Save Data"
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
    Friend WithEvents PlayGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CampaignToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuickGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PowersAndAbilitiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GameSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpButton As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotYouSaveDataToolStripMenuItem As ToolStripMenuItem
End Class
