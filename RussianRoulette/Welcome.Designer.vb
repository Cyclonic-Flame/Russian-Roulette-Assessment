<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnScore = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnRules = New System.Windows.Forms.Button()
        Me.pbWelcome = New System.Windows.Forms.PictureBox()
        CType(Me.pbWelcome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Sitka Small", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(66, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(305, 28)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome to Russian Roulette"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(150, 51)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(116, 23)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start Game"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnScore
        '
        Me.btnScore.Location = New System.Drawing.Point(150, 101)
        Me.btnScore.Name = "btnScore"
        Me.btnScore.Size = New System.Drawing.Size(116, 23)
        Me.btnScore.TabIndex = 4
        Me.btnScore.Text = "Scores"
        Me.btnScore.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(150, 201)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(116, 23)
        Me.btnQuit.TabIndex = 5
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnRules
        '
        Me.btnRules.Location = New System.Drawing.Point(150, 151)
        Me.btnRules.Name = "btnRules"
        Me.btnRules.Size = New System.Drawing.Size(116, 23)
        Me.btnRules.TabIndex = 6
        Me.btnRules.Text = "Rules"
        Me.btnRules.UseVisualStyleBackColor = True
        '
        'pbWelcome
        '
        Me.pbWelcome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbWelcome.Image = Global.RussianRoulette.My.Resources.Resources.revolversinglebullet
        Me.pbWelcome.InitialImage = Nothing
        Me.pbWelcome.Location = New System.Drawing.Point(0, 0)
        Me.pbWelcome.Name = "pbWelcome"
        Me.pbWelcome.Size = New System.Drawing.Size(434, 261)
        Me.pbWelcome.TabIndex = 1
        Me.pbWelcome.TabStop = False
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 261)
        Me.Controls.Add(Me.btnRules)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnScore)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.pbWelcome)
        Me.Name = "Welcome"
        Me.Text = "Youtube Roulette"
        CType(Me.pbWelcome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents pbWelcome As PictureBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnScore As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnRules As Button
End Class
