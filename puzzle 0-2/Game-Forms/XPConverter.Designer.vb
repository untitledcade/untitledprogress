<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XPConverter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XPConverter))
        Me.CoinAmountText = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.WheelText = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CoinAmountText
        '
        Me.CoinAmountText.AutoSize = True
        Me.CoinAmountText.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoinAmountText.Location = New System.Drawing.Point(10, 25)
        Me.CoinAmountText.Name = "CoinAmountText"
        Me.CoinAmountText.Size = New System.Drawing.Size(24, 30)
        Me.CoinAmountText.TabIndex = 21
        Me.CoinAmountText.Text = "1"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(12, 9)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(56, 13)
        Me.Label34.TabIndex = 20
        Me.Label34.Text = "BUGCOIN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 30)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "XP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 30)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Low on BugCoin?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(456, 78)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(237, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Amount of XP to bet:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(240, 111)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(251, 31)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Spin the wheel of odds"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(382, 83)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(109, 22)
        Me.NumericUpDown1.TabIndex = 29
        '
        'WheelText
        '
        Me.WheelText.AutoSize = True
        Me.WheelText.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WheelText.Location = New System.Drawing.Point(235, 28)
        Me.WheelText.Name = "WheelText"
        Me.WheelText.Size = New System.Drawing.Size(30, 30)
        Me.WheelText.TabIndex = 30
        Me.WheelText.Text = "hi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(238, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "WHEEL SAYS:"
        '
        'XPConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 291)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.WheelText)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CoinAmountText)
        Me.Controls.Add(Me.Label34)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "XPConverter"
        Me.Text = "XPConverter"
        Me.TopMost = True
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CoinAmountText As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents WheelText As Label
    Friend WithEvents Label7 As Label
End Class
