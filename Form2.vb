Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.MainCharacter = Nothing Then
            lblHelp.Text = "Please input name of main character"
            Exit Sub
        End If
        If Form1.animal = Nothing Then
            lblHelp.Text = "Please input animal "
            Exit Sub
        End If
        If Form1.place = Nothing Then
            lblHelp.Text = "Please input a place such as desert or jungle"
            Exit Sub
        End If
        If Form1.SecondaryCharacter = Nothing Then
            lblHelp.Text = "please input name of secondary character "
            Exit Sub
        End If
    End Sub
    Public tester1 = True
    Public tester2 = True
    Public tester3 = True
    Public tester4 = True
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If tester1 = True Then
            Form1.MainCharacter = txtAnswer.Text
            If txtAnswer.Text = Nothing Or IsNumeric(txtAnswer.Text) Then
                MessageBox.Show("please enter something (names not numbers) !", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                tester1 = False
                Me.Hide()
                Form1.Show()
                Form1.txtStory.Text = Form1.MainCharacter & " walked for several hours without a glimpse of any sign of life. Suddenly, something moved in the bush and a small animal with a yellow - striped tail flashed down a barely visible track."
                Exit Sub
            End If
        End If
        If tester2 Then
            Form1.animal = txtAnswer.Text
            If txtAnswer.Text = Nothing Or IsNumeric(txtAnswer.Text) Then
                MessageBox.Show("please enter something (names not numbers) !", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                tester2 = False
                Me.Hide()
                Form1.Show()
                Exit Sub
            End If
        End If
        If tester3 Then
            Form1.place = txtAnswer.Text
            If txtAnswer.Text = Nothing Or IsNumeric(txtAnswer.Text) Then
                MessageBox.Show("please enter something (names not numbers) !", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                tester3 = False
                Me.Hide()
                Form1.Show()
                Exit Sub
            End If
        End If
        If tester4 Then
            Form1.SecondaryCharacter = txtAnswer.Text
            If txtAnswer.Text = Nothing Or IsNumeric(txtAnswer.Text) Then
                MessageBox.Show("please enter something (names not numbers) !", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                tester4 = False
                Me.Hide()
                Form1.txtStory.Text = Form1.txtStory.Text & "  - Maybe it will lead me to some people? He dived through the thick foliage. Just as he lost sight of the " & Form1.place & ", he heard a sharp scream."
                Form1.txtStory.Text = Form1.txtStory.Text & Form1.MainCharacter & " stopped, cocked his head, and tried to locate the source of the sound. "
                Form1.txtStory.Text = Form1.txtStory.Text & "Directly ahead, " & Form1.MainCharacter & " heard another shrill cry for help. "
                Form1.txtStory.Text = Form1.txtStory.Text & "Pushing up an incline and through a mass of branches and vines, " & Form1.MainCharacter & " clawed his way forward and stumbled onto a wider path. "
                Form1.txtStory.Text = Form1.txtStory.Text & "As he rounded a sharp bend in the trail, " & Form1.MainCharacter & " ran full tilt into the side of a burly man. "
                Form1.txtStory.Text = Form1.txtStory.Text & " - Out of my way, chump!  bellowed the man, brushing him aside like a gnat. "
                Form1.txtStory.Text = Form1.txtStory.Text & "Dazed, " & Form1.MainCharacter & " looked up and saw two men dragging " & Form1.SecondaryCharacter & " , kicking and yelling, down the trail. "
                Form1.txtStory.Text = Form1.txtStory.Text & "By the time " & Form1.MainCharacter & " caught his breath, the trio had disappeared. "
                Form1.Show()
                Exit Sub
            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class