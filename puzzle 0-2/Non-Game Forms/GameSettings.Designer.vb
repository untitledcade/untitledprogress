<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameSettings))
        Me.SettingsTab = New System.Windows.Forms.TabControl()
        Me.UpdateTab = New System.Windows.Forms.TabPage()
        Me.ProfileSettings = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GameplaySettings = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.DataSettings = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ResetMASTERButton = New System.Windows.Forms.Button()
        Me.SettingsTab.SuspendLayout()
        Me.ProfileSettings.SuspendLayout()
        Me.GameplaySettings.SuspendLayout()
        Me.DataSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'SettingsTab
        '
        Me.SettingsTab.Controls.Add(Me.UpdateTab)
        Me.SettingsTab.Controls.Add(Me.ProfileSettings)
        Me.SettingsTab.Controls.Add(Me.GameplaySettings)
        Me.SettingsTab.Controls.Add(Me.DataSettings)
        Me.SettingsTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SettingsTab.Location = New System.Drawing.Point(0, 0)
        Me.SettingsTab.Name = "SettingsTab"
        Me.SettingsTab.SelectedIndex = 0
        Me.SettingsTab.Size = New System.Drawing.Size(800, 450)
        Me.SettingsTab.TabIndex = 0
        '
        'UpdateTab
        '
        Me.UpdateTab.Location = New System.Drawing.Point(4, 22)
        Me.UpdateTab.Name = "UpdateTab"
        Me.UpdateTab.Padding = New System.Windows.Forms.Padding(3)
        Me.UpdateTab.Size = New System.Drawing.Size(792, 424)
        Me.UpdateTab.TabIndex = 0
        Me.UpdateTab.Text = "Updates"
        Me.UpdateTab.UseVisualStyleBackColor = True
        '
        'ProfileSettings
        '
        Me.ProfileSettings.Controls.Add(Me.Label5)
        Me.ProfileSettings.Controls.Add(Me.Button3)
        Me.ProfileSettings.Controls.Add(Me.Button4)
        Me.ProfileSettings.Controls.Add(Me.TextBox2)
        Me.ProfileSettings.Controls.Add(Me.TextBox5)
        Me.ProfileSettings.Controls.Add(Me.Label6)
        Me.ProfileSettings.Controls.Add(Me.Label7)
        Me.ProfileSettings.Location = New System.Drawing.Point(4, 22)
        Me.ProfileSettings.Name = "ProfileSettings"
        Me.ProfileSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.ProfileSettings.Size = New System.Drawing.Size(792, 424)
        Me.ProfileSettings.TabIndex = 1
        Me.ProfileSettings.Text = "Profile"
        Me.ProfileSettings.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 21)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Profile Settings"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(389, 86)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 26)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(389, 56)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 27)
        Me.Button4.TabIndex = 27
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(137, 86)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(246, 22)
        Me.TextBox2.TabIndex = 26
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(137, 57)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(246, 22)
        Me.TextBox5.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(18, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 19)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Catchphrase:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(32, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 19)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Username:"
        '
        'GameplaySettings
        '
        Me.GameplaySettings.Controls.Add(Me.CheckBox1)
        Me.GameplaySettings.Location = New System.Drawing.Point(4, 22)
        Me.GameplaySettings.Name = "GameplaySettings"
        Me.GameplaySettings.Padding = New System.Windows.Forms.Padding(3)
        Me.GameplaySettings.Size = New System.Drawing.Size(792, 424)
        Me.GameplaySettings.TabIndex = 3
        Me.GameplaySettings.Text = "Gameplay"
        Me.GameplaySettings.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(18, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(209, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Legit Gamer Mode (prevents cheats)"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DataSettings
        '
        Me.DataSettings.Controls.Add(Me.Label8)
        Me.DataSettings.Controls.Add(Me.Label9)
        Me.DataSettings.Controls.Add(Me.TextBox1)
        Me.DataSettings.Controls.Add(Me.Label2)
        Me.DataSettings.Controls.Add(Me.Label1)
        Me.DataSettings.Controls.Add(Me.ResetMASTERButton)
        Me.DataSettings.Location = New System.Drawing.Point(4, 22)
        Me.DataSettings.Name = "DataSettings"
        Me.DataSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.DataSettings.Size = New System.Drawing.Size(792, 424)
        Me.DataSettings.TabIndex = 2
        Me.DataSettings.Text = "Save Data"
        Me.DataSettings.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(380, 52)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = resources.GetString("Label8.Text")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(182, 21)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "YOUR CURRENT SAVE: "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(250, 143)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(93, 22)
        Me.TextBox1.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 78)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Deletes your current save, including all " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of your Progress, as well as Stats, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "BugCoin, and Experience Points." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enter ""resetOK"", then click Reset to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wipe D" &
    "ata. (this is not undoable btw)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 21)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Reset EVERYTHING"
        '
        'ResetMASTERButton
        '
        Me.ResetMASTERButton.BackColor = System.Drawing.Color.IndianRed
        Me.ResetMASTERButton.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ResetMASTERButton.Location = New System.Drawing.Point(250, 171)
        Me.ResetMASTERButton.Name = "ResetMASTERButton"
        Me.ResetMASTERButton.Size = New System.Drawing.Size(93, 45)
        Me.ResetMASTERButton.TabIndex = 22
        Me.ResetMASTERButton.Text = "Reset"
        Me.ResetMASTERButton.UseVisualStyleBackColor = False
        '
        'GameSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SettingsTab)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GameSettings"
        Me.Text = "GameSettings"
        Me.TopMost = True
        Me.SettingsTab.ResumeLayout(False)
        Me.ProfileSettings.ResumeLayout(False)
        Me.ProfileSettings.PerformLayout()
        Me.GameplaySettings.ResumeLayout(False)
        Me.GameplaySettings.PerformLayout()
        Me.DataSettings.ResumeLayout(False)
        Me.DataSettings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SettingsTab As TabControl
    Friend WithEvents UpdateTab As TabPage
    Friend WithEvents ProfileSettings As TabPage
    Friend WithEvents DataSettings As TabPage
    Friend WithEvents GameplaySettings As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents ResetMASTERButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
