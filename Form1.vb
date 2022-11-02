Public Class Form1
    Public MainCharacter, animal, place, SecondaryCharacter As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainCharacter = Nothing
        animal = Nothing
        place = Nothing
        SecondaryCharacter = Nothing
    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If testerStart Then
            Form2.ShowDialog()
            testerStart = False
            If MainCharacter = Nothing Then
                testerStart = True
            End If
        Else
            MessageBox.Show("NO! I said just press it once!!! ", "Why are you messing with me ? ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private tester1 = True
    Private tester2 = True
    Private tester3 = True
    Private tester4 = True
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtStory.Clear()
        tester1 = True
        tester2 = True
        tester3 = True
        testerStart = True
        Form2.tester1 = True
        Form2.tester2 = True
        Form2.tester3 = True
        Form2.tester4 = True
        MainCharacter = Nothing
        animal = Nothing
        place = Nothing
        SecondaryCharacter = Nothing
        btnNext.Text = "Next"
        Form2.txtAnswer.Clear()
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MessageBox.Show("Have a good day!", "Goodbye!")
    End Sub
    Private testerStart = True
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If tester1 Then
            Form2.txtAnswer.Text = Nothing
            Me.TopMost = False
            Form2.ShowDialog()
            If animal = Nothing Then
                tester1 = True
                Exit Sub
            Else
                txtStory.Text = txtStory.Text & "'A " & animal & " ' thought " & MainCharacter
            End If
            tester1 = False
            Exit Sub
        End If
        If tester2 Then
            Form2.txtAnswer.Text = Nothing
            Me.TopMost = False
            Form2.ShowDialog()
            If place = Nothing Then
                tester2 = True
                Exit Sub
            End If
            tester2 = False
        End If
        If tester3 Then
            Form2.txtAnswer.Text = Nothing
            Me.TopMost = False
            Form2.ShowDialog()
            If SecondaryCharacter = Nothing Then
                tester3 = True
                Exit Sub
            End If
            btnNext.Text = "THE END !!! (EXIT)"
            tester3 = False
            Exit Sub
        End If
        If tester4 Then
            Me.Close()
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
