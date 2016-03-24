<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CharacterSelect
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
        Me.lblCharacter = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.rtbName = New System.Windows.Forms.RichTextBox()
        Me.btnPicture = New System.Windows.Forms.Button()
        Me.pbCharacter = New System.Windows.Forms.PictureBox()
        CType(Me.pbCharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCharacter
        '
        Me.lblCharacter.AutoSize = True
        Me.lblCharacter.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharacter.Location = New System.Drawing.Point(133, 15)
        Me.lblCharacter.Name = "lblCharacter"
        Me.lblCharacter.Size = New System.Drawing.Size(52, 19)
        Me.lblCharacter.TabIndex = 1
        Me.lblCharacter.Text = "Name:"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(137, 87)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(107, 23)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnProceed
        '
        Me.btnProceed.Location = New System.Drawing.Point(255, 49)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(107, 23)
        Me.btnProceed.TabIndex = 5
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'rtbName
        '
        Me.rtbName.Location = New System.Drawing.Point(191, 16)
        Me.rtbName.Name = "rtbName"
        Me.rtbName.Size = New System.Drawing.Size(171, 20)
        Me.rtbName.TabIndex = 7
        Me.rtbName.Text = ""
        '
        'btnPicture
        '
        Me.btnPicture.Location = New System.Drawing.Point(137, 49)
        Me.btnPicture.Name = "btnPicture"
        Me.btnPicture.Size = New System.Drawing.Size(107, 23)
        Me.btnPicture.TabIndex = 8
        Me.btnPicture.Text = "Choose a Picture"
        Me.btnPicture.UseVisualStyleBackColor = True
        '
        'pbCharacter
        '
        Me.pbCharacter.Location = New System.Drawing.Point(12, 12)
        Me.pbCharacter.Name = "pbCharacter"
        Me.pbCharacter.Size = New System.Drawing.Size(98, 98)
        Me.pbCharacter.TabIndex = 0
        Me.pbCharacter.TabStop = False
        '
        'CharacterSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 140)
        Me.Controls.Add(Me.btnPicture)
        Me.Controls.Add(Me.rtbName)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblCharacter)
        Me.Controls.Add(Me.pbCharacter)
        Me.Name = "CharacterSelect"
        Me.Text = "Russian Roulette Character"
        CType(Me.pbCharacter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbCharacter As PictureBox
    Friend WithEvents lblCharacter As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnProceed As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents rtbName As RichTextBox
    Friend WithEvents btnPicture As Button
End Class
