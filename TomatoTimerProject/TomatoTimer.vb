
Public Class TomatoTimer

    Private Secondi As Integer
    Private Minuti As Integer

    Private pomodori As Integer = 0

    Dim primopiano As Long

    Private posizione As Point

    Private x As Integer
    Private y As Integer

    Dim dimensione As Integer

    ' mi serve per controllare se sta andando il timer "pomodoro" e fermare il timer "pausa"
    Dim controllo As Boolean = False


    Private Sub IniziaPomodoro_Click() Handles IniziaPomodoro.Click

        controllo = True
        Minuti = 24
        Secondi = 60
        IniziaPomodoro.Enabled = False
        IniziaPomodoro.Visible = False
        Interruzione.Visible = True
        Interruzione.Enabled = True
        Label_Pausa.Visible = False
        Time_Label.Text = "25 : 00"
        Pomodoro.Start()

    End Sub


    Private Sub Pomodoro_Tick() Handles Pomodoro.Tick

        If controllo = False Then
            Pomodoro.Stop()
            Exit Sub
        Else
            '24:59
            If Minuti > 9 And Secondi > 10 Then
                Secondi = Secondi - 1
                Time_Label.Text = Minuti & " : " & Secondi
            Else

                '24:09
                If Minuti > 9 And Secondi < 11 And Secondi > 0 Then
                    Secondi = Secondi - 1
                    Time_Label.Text = Minuti & " : 0" & Secondi
                Else

                    '24:00
                    If Minuti > 10 And Secondi = 0 Then
                        Secondi = 59
                        Minuti = Minuti - 1
                        Time_Label.Text = Minuti & " : " & Secondi
                    Else

                        '09:59
                        If Minuti > 0 And Minuti < 11 And Secondi = 0 Then
                            Secondi = 59
                            Minuti = Minuti - 1
                            Time_Label.Text = "0" & Minuti & " : " & Secondi
                        Else

                            '09:10
                            If Minuti < 10 And Secondi > 10 Then
                                Secondi = Secondi - 1
                                Time_Label.Text = "0" & Minuti & " : " & Secondi
                            Else

                                '09:09
                                If Minuti < 10 And Secondi > 0 And Secondi < 11 Then
                                    Secondi = Secondi - 1
                                    Time_Label.Text = "0" & Minuti & " : 0" & Secondi
                                Else

                                    '00:00
                                    If Minuti = 0 And Secondi = 0 Then
                                        Pomodoro.Stop()
                                        Time_Label.Text = "00 : 00"
                                        MessageBox.Show("Pomodoro finito", "Fine")
                                        pomodori = pomodori + 1
                                        If pomodori = 1 Then
                                            PomodoriLabel.Text = "1 pomodoro completato"
                                        Else
                                            PomodoriLabel.Text = pomodori & " pomodori completati"
                                        End If
                                        Interruzione.Visible = False
                                        Interruzione.Enabled = False
                                        IniziaPomodoro.Enabled = True
                                        IniziaPomodoro.Visible = True
                                        'fai partire i 5 minuti di pausa
                                        controllo = False
                                        Inizia_Pausa()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub


    Private Sub Esci_Click(sender As System.Object, e As System.EventArgs) Handles Esci.Click

        Pomodoro.Stop()
        controllo = False
        IniziaPomodoro.Enabled = True
        IniziaPomodoro.Visible = True
        Interruzione.Visible = False
        Interruzione.Enabled = False
        Label_Pausa.Visible = False
        Time_Label.Text = "25 : 00"
        IniziaPomodoro.Enabled = True
        Dim result As Integer = MessageBox.Show("Sei sicuro di voler uscire?", "Attenzione", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            End     'esce dal programma
        ElseIf result = DialogResult.No Then
            Exit Sub
        End If


    End Sub


    Private Sub Interruzione_Click(sender As System.Object, e As System.EventArgs) Handles Interruzione.Click

        Interruzione.Visible = False
        Interruzione.Enabled = False
        IniziaPomodoro.Enabled = True
        IniziaPomodoro.Visible = True
        Time_Label.Text = "25 : 00"
        Pomodoro.Stop()
        controllo = False

    End Sub

    Private Sub Inizia_Pausa()
        Minuti = 4
        Secondi = 60

        'DA AGGIUNGERE IN VBTIPS! (riduce dimensione font)
        'dimensione = Time_Label.Font.Size
        'dimensione -= 2.0F
        'Time_Label.Font = New Font(Time_Label.Font.Name, dimensione, Time_Label.Font.Style, Time_Label.Font.Unit)

        Time_Label.Text = "05 : 00"
        Label_Pausa.Visible = True
        Pausa.Start()
    End Sub

    Private Sub Pausa_Tick() Handles Pausa.Tick

        If controllo = True Then
            Pausa.Stop()
            Exit Sub
        Else

        End If

        If Minuti > 9 And Secondi > 10 Then
            Secondi = Secondi - 1
            Time_Label.Text = Minuti & " : " & Secondi
        Else

            '24:09
            If Minuti > 9 And Secondi < 11 And Secondi > 0 Then
                Secondi = Secondi - 1
                Time_Label.Text = Minuti & " : 0" & Secondi
            Else

                '24:00
                If Minuti > 10 And Secondi = 0 Then
                    Secondi = 59
                    Minuti = Minuti - 1
                    Time_Label.Text = Minuti & " : " & Secondi
                Else

                    '09:59
                    If Minuti > 0 And Minuti < 11 And Secondi = 0 Then
                        Secondi = 59
                        Minuti = Minuti - 1
                        Time_Label.Text = "0" & Minuti & " : " & Secondi
                    Else

                        '09:10
                        If Minuti < 10 And Secondi > 10 Then
                            Secondi = Secondi - 1
                            Time_Label.Text = "0" & Minuti & " : " & Secondi
                        Else

                            '09:09
                            If Minuti < 10 And Secondi > 0 And Secondi < 11 Then
                                Secondi = Secondi - 1
                                Time_Label.Text = "0" & Minuti & " : 0" & Secondi
                            Else

                                '00:00
                                If Minuti = 0 And Secondi = 0 Then
                                    Pausa.Stop()
                                    Time_Label.Text = "00 : 00"
                                    MessageBox.Show("Pausa finita, torna al lavoro! Clicca su ""Inizia Pomodoro""", "Fine")
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub


    '-------------------------------------------------------------------------------------------------------------------------------------
    '------------------------------- QUESTE SUB SERVONO SOLO A DARE LA POSSIBILITA' DI MUOVERE LA FORM -----------------------------------
    '-------------------------------------------------------------------------------------------------------------------------------------

    Private Sub Muoviti_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Muoviti.DoubleClick

        'doppio click sulla form: la sposta in basso adestra

        Me.Visible = True
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop

    End Sub

    Private Sub Time_Label_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Time_Label.DoubleClick

        Me.Visible = True
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop

    End Sub

    Private Sub Muoviti_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Muoviti.MouseDown

        'evento: pressione del tasto sinistro del mouse

        posizione = New Point(-e.X, -e.Y) 'assegna a diff la posizione del mouse (X; Y)

    End Sub

    Private Sub Muoviti_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Muoviti.MouseMove

        'evento: movimento del mouse

        If e.Button = MouseButtons.Left Then 'se il tasto è il sinistro...

            Dim mouse_loc As Point = Control.MousePosition

            mouse_loc.Offset(posizione.X, posizione.Y)

            Me.Location = mouse_loc 'assegna le coordinate alla posizione del form

        End If

    End Sub

    Private Sub Time_Label_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Time_Label.MouseDown

        posizione = New Point(-e.X, -e.Y)

    End Sub

    Private Sub Time_Label_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Time_Label.MouseMove

        If e.Button = MouseButtons.Left Then

            Dim mouse_loc As Point = Control.MousePosition

            mouse_loc.Offset(posizione.X, posizione.Y)

            Me.Location = mouse_loc

        End If

    End Sub

    Private Sub Label_Pausa_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label_Pausa.MouseDown

        posizione = New Point(-e.X, -e.Y)

    End Sub

    Private Sub Label_Pausa_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label_Pausa.MouseMove

        If e.Button = MouseButtons.Left Then

            Dim mouse_loc As Point = Control.MousePosition

            mouse_loc.Offset(posizione.X, posizione.Y)

            Me.Location = mouse_loc

        End If

    End Sub

    Private Sub PomodoriLabel_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PomodoriLabel.MouseDown

        posizione = New Point(-e.X, -e.Y)

    End Sub

    Private Sub PomodoriLabel_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PomodoriLabel.MouseMove

        If e.Button = MouseButtons.Left Then

            Dim mouse_loc As Point = Control.MousePosition

            mouse_loc.Offset(posizione.X, posizione.Y)

            Me.Location = mouse_loc

        End If

    End Sub

    Private Sub CB_PrimoPiano_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CB_PrimoPiano.MouseDown

        posizione = New Point(-e.X, -e.Y)

    End Sub

    Private Sub CB_PrimoPiano_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CB_PrimoPiano.MouseMove

        If e.Button = MouseButtons.Left Then

            Dim mouse_loc As Point = Control.MousePosition

            mouse_loc.Offset(posizione.X, posizione.Y)

            Me.Location = mouse_loc

        End If

    End Sub


    '-------------------------------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------- GESTISCE IL PRIMO PIANO ----------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------------------------------

    Private Sub CB_PrimoPiano_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CB_PrimoPiano.CheckedChanged
        If CB_PrimoPiano.Checked Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If

    End Sub

End Class
