<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Score
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
        Me.dgvScore = New System.Windows.Forms.DataGridView()
        Me.clmName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTriggerPulls = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmResult = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnHighestShot = New System.Windows.Forms.Button()
        Me.btnLowestShot = New System.Windows.Forms.Button()
        Me.btnName = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.dgvScore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvScore
        '
        Me.dgvScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvScore.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmName, Me.clmTriggerPulls, Me.clmResult})
        Me.dgvScore.Location = New System.Drawing.Point(12, 12)
        Me.dgvScore.Name = "dgvScore"
        Me.dgvScore.Size = New System.Drawing.Size(345, 275)
        Me.dgvScore.TabIndex = 5
        '
        'clmName
        '
        Me.clmName.HeaderText = "Name"
        Me.clmName.Name = "clmName"
        '
        'clmTriggerPulls
        '
        Me.clmTriggerPulls.HeaderText = "Trigger Pulls"
        Me.clmTriggerPulls.Name = "clmTriggerPulls"
        '
        'clmResult
        '
        Me.clmResult.HeaderText = "Win/Loss"
        Me.clmResult.Name = "clmResult"
        '
        'btnHighestShot
        '
        Me.btnHighestShot.Location = New System.Drawing.Point(363, 12)
        Me.btnHighestShot.Name = "btnHighestShot"
        Me.btnHighestShot.Size = New System.Drawing.Size(129, 23)
        Me.btnHighestShot.TabIndex = 6
        Me.btnHighestShot.Text = "Highest Trigger Pulls"
        Me.btnHighestShot.UseVisualStyleBackColor = True
        '
        'btnLowestShot
        '
        Me.btnLowestShot.Location = New System.Drawing.Point(363, 41)
        Me.btnLowestShot.Name = "btnLowestShot"
        Me.btnLowestShot.Size = New System.Drawing.Size(129, 23)
        Me.btnLowestShot.TabIndex = 7
        Me.btnLowestShot.Text = "Lowest Trigger Pulls"
        Me.btnLowestShot.UseVisualStyleBackColor = True
        '
        'btnName
        '
        Me.btnName.Location = New System.Drawing.Point(363, 70)
        Me.btnName.Name = "btnName"
        Me.btnName.Size = New System.Drawing.Size(129, 23)
        Me.btnName.TabIndex = 8
        Me.btnName.Text = "Name Sort"
        Me.btnName.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(363, 264)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(129, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Score
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 299)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnName)
        Me.Controls.Add(Me.btnLowestShot)
        Me.Controls.Add(Me.btnHighestShot)
        Me.Controls.Add(Me.dgvScore)
        Me.Name = "Score"
        Me.Text = "Score"
        CType(Me.dgvScore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvScore As DataGridView
    Friend WithEvents clmName As DataGridViewTextBoxColumn
    Friend WithEvents clmTriggerPulls As DataGridViewTextBoxColumn
    Friend WithEvents clmResult As DataGridViewTextBoxColumn
    Friend WithEvents btnHighestShot As Button
    Friend WithEvents btnLowestShot As Button
    Friend WithEvents btnName As Button
    Friend WithEvents btnExit As Button
End Class
