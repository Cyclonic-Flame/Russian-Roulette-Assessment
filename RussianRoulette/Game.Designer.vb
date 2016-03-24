<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game
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
        Me.btnSelfShot = New System.Windows.Forms.Button()
        Me.btnAwayShot = New System.Windows.Forms.Button()
        Me.btnLoadBullet = New System.Windows.Forms.Button()
        Me.btnSpinChamber = New System.Windows.Forms.Button()
        Me.pbChance2 = New System.Windows.Forms.PictureBox()
        Me.pbChance1 = New System.Windows.Forms.PictureBox()
        Me.pbBullet6 = New System.Windows.Forms.PictureBox()
        Me.pbBullet5 = New System.Windows.Forms.PictureBox()
        Me.pbBullet4 = New System.Windows.Forms.PictureBox()
        Me.pbBullet3 = New System.Windows.Forms.PictureBox()
        Me.pbBullet2 = New System.Windows.Forms.PictureBox()
        Me.pbBullet1 = New System.Windows.Forms.PictureBox()
        Me.pbGun = New System.Windows.Forms.PictureBox()
        Me.pbCharacter = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pbChance2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbChance1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBullet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBullet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBullet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBullet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBullet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBullet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelfShot
        '
        Me.btnSelfShot.Location = New System.Drawing.Point(12, 242)
        Me.btnSelfShot.Name = "btnSelfShot"
        Me.btnSelfShot.Size = New System.Drawing.Size(98, 50)
        Me.btnSelfShot.TabIndex = 8
        Me.btnSelfShot.Text = "Shoot at self"
        Me.btnSelfShot.UseVisualStyleBackColor = True
        '
        'btnAwayShot
        '
        Me.btnAwayShot.Location = New System.Drawing.Point(474, 242)
        Me.btnAwayShot.Name = "btnAwayShot"
        Me.btnAwayShot.Size = New System.Drawing.Size(98, 50)
        Me.btnAwayShot.TabIndex = 9
        Me.btnAwayShot.Text = "Shoot Away"
        Me.btnAwayShot.UseVisualStyleBackColor = True
        '
        'btnLoadBullet
        '
        Me.btnLoadBullet.Location = New System.Drawing.Point(131, 147)
        Me.btnLoadBullet.Name = "btnLoadBullet"
        Me.btnLoadBullet.Size = New System.Drawing.Size(98, 50)
        Me.btnLoadBullet.TabIndex = 12
        Me.btnLoadBullet.Text = "Load Bullet"
        Me.btnLoadBullet.UseVisualStyleBackColor = True
        '
        'btnSpinChamber
        '
        Me.btnSpinChamber.BackColor = System.Drawing.Color.Transparent
        Me.btnSpinChamber.Location = New System.Drawing.Point(235, 147)
        Me.btnSpinChamber.Name = "btnSpinChamber"
        Me.btnSpinChamber.Size = New System.Drawing.Size(98, 50)
        Me.btnSpinChamber.TabIndex = 13
        Me.btnSpinChamber.Text = "Spin Chamber"
        Me.btnSpinChamber.UseVisualStyleBackColor = False
        '
        'pbChance2
        '
        Me.pbChance2.BackColor = System.Drawing.Color.White
        Me.pbChance2.Location = New System.Drawing.Point(418, 242)
        Me.pbChance2.Name = "pbChance2"
        Me.pbChance2.Size = New System.Drawing.Size(50, 50)
        Me.pbChance2.TabIndex = 11
        Me.pbChance2.TabStop = False
        '
        'pbChance1
        '
        Me.pbChance1.BackColor = System.Drawing.Color.White
        Me.pbChance1.Location = New System.Drawing.Point(362, 242)
        Me.pbChance1.Name = "pbChance1"
        Me.pbChance1.Size = New System.Drawing.Size(50, 50)
        Me.pbChance1.TabIndex = 10
        Me.pbChance1.TabStop = False
        '
        'pbBullet6
        '
        Me.pbBullet6.BackColor = System.Drawing.Color.Transparent
        Me.pbBullet6.Image = Global.RussianRoulette.My.Resources.Resources.Bullet
        Me.pbBullet6.Location = New System.Drawing.Point(541, 12)
        Me.pbBullet6.Name = "pbBullet6"
        Me.pbBullet6.Size = New System.Drawing.Size(32, 129)
        Me.pbBullet6.TabIndex = 7
        Me.pbBullet6.TabStop = False
        '
        'pbBullet5
        '
        Me.pbBullet5.BackColor = System.Drawing.Color.Transparent
        Me.pbBullet5.Image = Global.RussianRoulette.My.Resources.Resources.Bullet
        Me.pbBullet5.Location = New System.Drawing.Point(503, 12)
        Me.pbBullet5.Name = "pbBullet5"
        Me.pbBullet5.Size = New System.Drawing.Size(32, 129)
        Me.pbBullet5.TabIndex = 6
        Me.pbBullet5.TabStop = False
        '
        'pbBullet4
        '
        Me.pbBullet4.BackColor = System.Drawing.Color.Transparent
        Me.pbBullet4.Image = Global.RussianRoulette.My.Resources.Resources.Bullet
        Me.pbBullet4.Location = New System.Drawing.Point(465, 12)
        Me.pbBullet4.Name = "pbBullet4"
        Me.pbBullet4.Size = New System.Drawing.Size(32, 129)
        Me.pbBullet4.TabIndex = 5
        Me.pbBullet4.TabStop = False
        '
        'pbBullet3
        '
        Me.pbBullet3.BackColor = System.Drawing.Color.Transparent
        Me.pbBullet3.Image = Global.RussianRoulette.My.Resources.Resources.Bullet
        Me.pbBullet3.Location = New System.Drawing.Point(427, 12)
        Me.pbBullet3.Name = "pbBullet3"
        Me.pbBullet3.Size = New System.Drawing.Size(32, 129)
        Me.pbBullet3.TabIndex = 4
        Me.pbBullet3.TabStop = False
        '
        'pbBullet2
        '
        Me.pbBullet2.BackColor = System.Drawing.Color.Transparent
        Me.pbBullet2.Image = Global.RussianRoulette.My.Resources.Resources.Bullet
        Me.pbBullet2.Location = New System.Drawing.Point(389, 12)
        Me.pbBullet2.Name = "pbBullet2"
        Me.pbBullet2.Size = New System.Drawing.Size(32, 129)
        Me.pbBullet2.TabIndex = 3
        Me.pbBullet2.TabStop = False
        '
        'pbBullet1
        '
        Me.pbBullet1.BackColor = System.Drawing.Color.Transparent
        Me.pbBullet1.Image = Global.RussianRoulette.My.Resources.Resources.Bullet
        Me.pbBullet1.Location = New System.Drawing.Point(351, 12)
        Me.pbBullet1.Name = "pbBullet1"
        Me.pbBullet1.Size = New System.Drawing.Size(32, 129)
        Me.pbBullet1.TabIndex = 2
        Me.pbBullet1.TabStop = False
        '
        'pbGun
        '
        Me.pbGun.BackColor = System.Drawing.Color.White
        Me.pbGun.Image = Global.RussianRoulette.My.Resources.Resources.GunImage1
        Me.pbGun.Location = New System.Drawing.Point(131, 12)
        Me.pbGun.Name = "pbGun"
        Me.pbGun.Size = New System.Drawing.Size(200, 129)
        Me.pbGun.TabIndex = 1
        Me.pbGun.TabStop = False
        '
        'pbCharacter
        '
        Me.pbCharacter.BackColor = System.Drawing.Color.Transparent
        Me.pbCharacter.Location = New System.Drawing.Point(12, 12)
        Me.pbCharacter.Name = "pbCharacter"
        Me.pbCharacter.Size = New System.Drawing.Size(98, 98)
        Me.pbCharacter.TabIndex = 0
        Me.pbCharacter.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.RussianRoulette.My.Resources.Resources.GameBackground
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(584, 304)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 304)
        Me.Controls.Add(Me.btnSpinChamber)
        Me.Controls.Add(Me.btnLoadBullet)
        Me.Controls.Add(Me.pbChance2)
        Me.Controls.Add(Me.pbChance1)
        Me.Controls.Add(Me.btnAwayShot)
        Me.Controls.Add(Me.btnSelfShot)
        Me.Controls.Add(Me.pbBullet6)
        Me.Controls.Add(Me.pbBullet5)
        Me.Controls.Add(Me.pbBullet4)
        Me.Controls.Add(Me.pbBullet3)
        Me.Controls.Add(Me.pbBullet2)
        Me.Controls.Add(Me.pbBullet1)
        Me.Controls.Add(Me.pbGun)
        Me.Controls.Add(Me.pbCharacter)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Game"
        Me.Text = "Game"
        CType(Me.pbChance2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbChance1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBullet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBullet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBullet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBullet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBullet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBullet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCharacter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbCharacter As PictureBox
    Friend WithEvents pbGun As PictureBox
    Friend WithEvents pbBullet1 As PictureBox
    Friend WithEvents pbBullet2 As PictureBox
    Friend WithEvents pbBullet3 As PictureBox
    Friend WithEvents pbBullet4 As PictureBox
    Friend WithEvents pbBullet5 As PictureBox
    Friend WithEvents pbBullet6 As PictureBox
    Friend WithEvents btnSelfShot As Button
    Friend WithEvents btnAwayShot As Button
    Friend WithEvents pbChance1 As PictureBox
    Friend WithEvents pbChance2 As PictureBox
    Friend WithEvents btnLoadBullet As Button
    Friend WithEvents btnSpinChamber As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
