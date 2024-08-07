Public Class CampaignDialouge

    ' Declare variables to hold the text and the current position
    Private fullText As String
    Private currentIndex As Integer

    Dim StartGame As Boolean

    ' Event to start the typewriter effect
    Sub CampaignDialouge(Name As String, textToType As String, typingSpeed As Integer)

        Label1.Text = Name

        ' Initialize the variables
        fullText = textToType
        currentIndex = 0

        ' Set up the timer interval (typing speed in milliseconds)
        Timer1.Interval = typingSpeed
        Timer1.Start()
    End Sub

    Sub StartGamewithDialog(Name As String, textToType As String, typingSpeed As Integer)

        Label1.Text = Name
        StartGame = True

        ' Initialize the variables
        fullText = textToType
        currentIndex = 0

        ' Set up the timer interval (typing speed in milliseconds)
        Timer1.Interval = typingSpeed
        Timer1.Start()
    End Sub

    ' Timer Tick event to add one character at a time
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If currentIndex < fullText.Length Then
            ' Add one character to the RichTextBox
            RichTextBox1.AppendText(fullText(currentIndex))
            currentIndex += 1
        Else
            ' Stop the timer when all text has been added
            Timer1.Stop()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub



End Class