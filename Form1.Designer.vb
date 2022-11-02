<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.txtStory = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtStory
        '
        Me.txtStory.Location = New System.Drawing.Point(95, 26)
        Me.txtStory.Margin = New System.Windows.Forms.Padding(0)
        Me.txtStory.Multiline = True
        Me.txtStory.Name = "txtStory"
        Me.txtStory.Size = New System.Drawing.Size(360, 228)
        Me.txtStory.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExit.Location = New System.Drawing.Point(0, 257)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(580, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "&EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNext.Location = New System.Drawing.Point(459, 0)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(121, 257)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "&NEXT"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnStart.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnStart.Location = New System.Drawing.Point(0, 0)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(0)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(95, 257)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start ( only press at start please)"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReset.Location = New System.Drawing.Point(95, 0)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(364, 23)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 280)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtStory)
        Me.Name = "Form1"
        Me.Text = "Interactive Story !"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStory As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnReset As Button
End Class
