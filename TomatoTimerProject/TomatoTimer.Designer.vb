<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TomatoTimer
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TomatoTimer))
        Me.Pomodoro = New System.Windows.Forms.Timer(Me.components)
        Me.IniziaPomodoro = New System.Windows.Forms.Button()
        Me.Esci = New System.Windows.Forms.Button()
        Me.Interruzione = New System.Windows.Forms.Button()
        Me.Muoviti = New System.Windows.Forms.Panel()
        Me.Label_Pausa = New System.Windows.Forms.Label()
        Me.PomodoriLabel = New System.Windows.Forms.Label()
        Me.CB_PrimoPiano = New System.Windows.Forms.CheckBox()
        Me.Time_Label = New System.Windows.Forms.Label()
        Me.Pausa = New System.Windows.Forms.Timer(Me.components)
        Me.Muoviti.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pomodoro
        '
        Me.Pomodoro.Interval = 1000
        '
        'IniziaPomodoro
        '
        Me.IniziaPomodoro.ForeColor = System.Drawing.Color.DarkRed
        Me.IniziaPomodoro.Location = New System.Drawing.Point(13, 41)
        Me.IniziaPomodoro.Name = "IniziaPomodoro"
        Me.IniziaPomodoro.Size = New System.Drawing.Size(139, 25)
        Me.IniziaPomodoro.TabIndex = 1
        Me.IniziaPomodoro.Text = "Inizia Pomodoro"
        Me.IniziaPomodoro.UseVisualStyleBackColor = True
        '
        'Esci
        '
        Me.Esci.BackColor = System.Drawing.Color.Black
        Me.Esci.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Esci.ForeColor = System.Drawing.Color.White
        Me.Esci.Location = New System.Drawing.Point(141, -3)
        Me.Esci.Name = "Esci"
        Me.Esci.Size = New System.Drawing.Size(24, 25)
        Me.Esci.TabIndex = 3
        Me.Esci.Text = "X"
        Me.Esci.UseMnemonic = False
        Me.Esci.UseVisualStyleBackColor = False
        '
        'Interruzione
        '
        Me.Interruzione.Enabled = False
        Me.Interruzione.ForeColor = System.Drawing.Color.DarkRed
        Me.Interruzione.Location = New System.Drawing.Point(13, 40)
        Me.Interruzione.Name = "Interruzione"
        Me.Interruzione.Size = New System.Drawing.Size(139, 25)
        Me.Interruzione.TabIndex = 4
        Me.Interruzione.Text = "Interruzione"
        Me.Interruzione.UseVisualStyleBackColor = True
        Me.Interruzione.Visible = False
        '
        'Muoviti
        '
        Me.Muoviti.BackColor = System.Drawing.Color.Transparent
        Me.Muoviti.Controls.Add(Me.Label_Pausa)
        Me.Muoviti.Controls.Add(Me.PomodoriLabel)
        Me.Muoviti.Controls.Add(Me.CB_PrimoPiano)
        Me.Muoviti.Controls.Add(Me.Time_Label)
        Me.Muoviti.ForeColor = System.Drawing.Color.Transparent
        Me.Muoviti.Location = New System.Drawing.Point(-3, -3)
        Me.Muoviti.Name = "Muoviti"
        Me.Muoviti.Size = New System.Drawing.Size(168, 119)
        Me.Muoviti.TabIndex = 5
        '
        'Label_Pausa
        '
        Me.Label_Pausa.AutoSize = True
        Me.Label_Pausa.Location = New System.Drawing.Point(64, 6)
        Me.Label_Pausa.Name = "Label_Pausa"
        Me.Label_Pausa.Size = New System.Drawing.Size(43, 13)
        Me.Label_Pausa.TabIndex = 9
        Me.Label_Pausa.Text = "PAUSA"
        Me.Label_Pausa.Visible = False
        '
        'PomodoriLabel
        '
        Me.PomodoriLabel.AutoSize = True
        Me.PomodoriLabel.Location = New System.Drawing.Point(27, 94)
        Me.PomodoriLabel.Name = "PomodoriLabel"
        Me.PomodoriLabel.Size = New System.Drawing.Size(116, 17)
        Me.PomodoriLabel.TabIndex = 8
        Me.PomodoriLabel.Text = "0 pomodori completati"
        Me.PomodoriLabel.UseCompatibleTextRendering = True
        '
        'CB_PrimoPiano
        '
        Me.CB_PrimoPiano.AutoSize = True
        Me.CB_PrimoPiano.Checked = True
        Me.CB_PrimoPiano.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CB_PrimoPiano.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_PrimoPiano.Location = New System.Drawing.Point(28, 73)
        Me.CB_PrimoPiano.Name = "CB_PrimoPiano"
        Me.CB_PrimoPiano.Size = New System.Drawing.Size(114, 16)
        Me.CB_PrimoPiano.TabIndex = 7
        Me.CB_PrimoPiano.Text = "Sempre in primo piano"
        Me.CB_PrimoPiano.UseVisualStyleBackColor = True
        '
        'Time_Label
        '
        Me.Time_Label.AutoSize = True
        Me.Time_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Time_Label.Location = New System.Drawing.Point(53, 20)
        Me.Time_Label.Name = "Time_Label"
        Me.Time_Label.Size = New System.Drawing.Size(64, 20)
        Me.Time_Label.TabIndex = 6
        Me.Time_Label.Text = "25 : 00"
        '
        'Pausa
        '
        Me.Pausa.Interval = 1000
        '
        'TomatoTimer
        '
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(163, 113)
        Me.ControlBox = False
        Me.Controls.Add(Me.Esci)
        Me.Controls.Add(Me.IniziaPomodoro)
        Me.Controls.Add(Me.Interruzione)
        Me.Controls.Add(Me.Muoviti)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TomatoTimer"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Pomodoro"
        Me.Muoviti.ResumeLayout(False)
        Me.Muoviti.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pomodoro As System.Windows.Forms.Timer
    Friend WithEvents IniziaPomodoro As System.Windows.Forms.Button
    Friend WithEvents Esci As System.Windows.Forms.Button
    Friend WithEvents Interruzione As System.Windows.Forms.Button
    Friend WithEvents Muoviti As System.Windows.Forms.Panel
    Friend WithEvents Time_Label As System.Windows.Forms.Label
    Friend WithEvents CB_PrimoPiano As System.Windows.Forms.CheckBox
    Friend WithEvents PomodoriLabel As System.Windows.Forms.Label
    Friend WithEvents Pausa As System.Windows.Forms.Timer
    Friend WithEvents Label_Pausa As System.Windows.Forms.Label

End Class
