<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Impostazioni
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Impostazioni))
        Me.bt_exit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Percorso_CSV = New System.Windows.Forms.TextBox()
        Me.CB_PrimoPiano = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'bt_exit
        '
        Me.bt_exit.Location = New System.Drawing.Point(42, 103)
        Me.bt_exit.Name = "bt_exit"
        Me.bt_exit.Size = New System.Drawing.Size(120, 23)
        Me.bt_exit.TabIndex = 15
        Me.bt_exit.Text = "Salva impostazioni"
        Me.bt_exit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Percorso CSV pomodori"
        '
        'Percorso_CSV
        '
        Me.Percorso_CSV.Location = New System.Drawing.Point(14, 68)
        Me.Percorso_CSV.Name = "Percorso_CSV"
        Me.Percorso_CSV.Size = New System.Drawing.Size(178, 20)
        Me.Percorso_CSV.TabIndex = 13
        '
        'CB_PrimoPiano
        '
        Me.CB_PrimoPiano.AutoSize = True
        Me.CB_PrimoPiano.Checked = True
        Me.CB_PrimoPiano.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CB_PrimoPiano.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_PrimoPiano.Location = New System.Drawing.Point(15, 17)
        Me.CB_PrimoPiano.Name = "CB_PrimoPiano"
        Me.CB_PrimoPiano.Size = New System.Drawing.Size(157, 17)
        Me.CB_PrimoPiano.TabIndex = 12
        Me.CB_PrimoPiano.Text = "Timer sempre in primo piano"
        Me.CB_PrimoPiano.UseVisualStyleBackColor = True
        '
        'Impostazioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(203, 139)
        Me.Controls.Add(Me.bt_exit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Percorso_CSV)
        Me.Controls.Add(Me.CB_PrimoPiano)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Impostazioni"
        Me.Text = "Impostazioni"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_exit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Percorso_CSV As TextBox
    Friend WithEvents CB_PrimoPiano As CheckBox
End Class
