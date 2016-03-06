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
        Me.BT_IniziaPomodoro = New System.Windows.Forms.Button()
        Me.Bt_Esci = New System.Windows.Forms.Button()
        Me.Muoviti = New System.Windows.Forms.Panel()
        Me.Label_Pausa = New System.Windows.Forms.Label()
        Me.PomodoriLabel = New System.Windows.Forms.Label()
        Me.Time_Label = New System.Windows.Forms.Label()
        Me.Pausa = New System.Windows.Forms.Timer(Me.components)
        Me.Bt_Impostazioni = New System.Windows.Forms.Button()
        Me.Muoviti.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pomodoro
        '
        Me.Pomodoro.Interval = 1000
        '
        'BT_IniziaPomodoro
        '
        Me.BT_IniziaPomodoro.ForeColor = System.Drawing.Color.DarkRed
        Me.BT_IniziaPomodoro.Location = New System.Drawing.Point(13, 43)
        Me.BT_IniziaPomodoro.Name = "BT_IniziaPomodoro"
        Me.BT_IniziaPomodoro.Size = New System.Drawing.Size(139, 25)
        Me.BT_IniziaPomodoro.TabIndex = 1
        Me.BT_IniziaPomodoro.Text = "Inizia Pomodoro"
        Me.BT_IniziaPomodoro.UseVisualStyleBackColor = True
        '
        'Bt_Esci
        '
        Me.Bt_Esci.BackColor = System.Drawing.Color.Black
        Me.Bt_Esci.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Esci.ForeColor = System.Drawing.Color.White
        Me.Bt_Esci.Location = New System.Drawing.Point(141, -3)
        Me.Bt_Esci.Name = "Bt_Esci"
        Me.Bt_Esci.Size = New System.Drawing.Size(24, 25)
        Me.Bt_Esci.TabIndex = 3
        Me.Bt_Esci.Text = "X"
        Me.Bt_Esci.UseMnemonic = False
        Me.Bt_Esci.UseVisualStyleBackColor = False
        '
        'Muoviti
        '
        Me.Muoviti.BackColor = System.Drawing.Color.Transparent
        Me.Muoviti.Controls.Add(Me.Label_Pausa)
        Me.Muoviti.Controls.Add(Me.PomodoriLabel)
        Me.Muoviti.Controls.Add(Me.Time_Label)
        Me.Muoviti.ForeColor = System.Drawing.Color.Transparent
        Me.Muoviti.Location = New System.Drawing.Point(-3, -4)
        Me.Muoviti.Name = "Muoviti"
        Me.Muoviti.Size = New System.Drawing.Size(168, 102)
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
        Me.PomodoriLabel.Location = New System.Drawing.Point(27, 76)
        Me.PomodoriLabel.Name = "PomodoriLabel"
        Me.PomodoriLabel.Size = New System.Drawing.Size(116, 17)
        Me.PomodoriLabel.TabIndex = 8
        Me.PomodoriLabel.Text = "0 pomodori completati"
        Me.PomodoriLabel.UseCompatibleTextRendering = True
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
        'Bt_Impostazioni
        '
        Me.Bt_Impostazioni.BackColor = System.Drawing.Color.Black
        Me.Bt_Impostazioni.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Impostazioni.ForeColor = System.Drawing.Color.White
        Me.Bt_Impostazioni.Location = New System.Drawing.Point(-2, -3)
        Me.Bt_Impostazioni.Name = "Bt_Impostazioni"
        Me.Bt_Impostazioni.Size = New System.Drawing.Size(24, 25)
        Me.Bt_Impostazioni.TabIndex = 6
        Me.Bt_Impostazioni.Text = "*"
        Me.Bt_Impostazioni.UseMnemonic = False
        Me.Bt_Impostazioni.UseVisualStyleBackColor = False
        '
        'TomatoTimer
        '
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(163, 95)
        Me.ControlBox = False
        Me.Controls.Add(Me.Bt_Impostazioni)
        Me.Controls.Add(Me.Bt_Esci)
        Me.Controls.Add(Me.BT_IniziaPomodoro)
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
    Friend WithEvents BT_IniziaPomodoro As System.Windows.Forms.Button
    Friend WithEvents Bt_Esci As System.Windows.Forms.Button
    Friend WithEvents Muoviti As System.Windows.Forms.Panel
    Friend WithEvents Time_Label As System.Windows.Forms.Label
    Friend WithEvents PomodoriLabel As System.Windows.Forms.Label
    Friend WithEvents Pausa As System.Windows.Forms.Timer
    Friend WithEvents Label_Pausa As System.Windows.Forms.Label
    Friend WithEvents Bt_Impostazioni As Button
End Class
