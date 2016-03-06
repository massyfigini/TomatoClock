
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


    Private Sub TomatoTimer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Bt_Impostazioni_Click(Nothing, Nothing)
    End Sub


    Sub IniziaPomodoro_Click() Handles BT_IniziaPomodoro.Click

        If controllo = False Then
            controllo = True
            Minuti = 24
            Secondi = 60
            BT_IniziaPomodoro.Text = "Interruzione"
            Label_Pausa.Visible = False
            Time_Label.Text = "25 : 00"
            Pomodoro.Start()
        Else
            BT_IniziaPomodoro.Text = "Inizia Pomodoro"
            Label_Pausa.Visible = False
            Time_Label.Text = "25 : 00"
            Pomodoro.Stop()
            controllo = False
        End If

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
                                        BT_IniziaPomodoro.Text = "Inizia Pomodoro"
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


    Private Sub Esci_Click(sender As System.Object, e As System.EventArgs) Handles Bt_Esci.Click

        Pomodoro.Stop()
        controllo = False
        BT_IniziaPomodoro.Text = "Inizia Pomodoro"
        Label_Pausa.Visible = False
        Time_Label.Text = "25 : 00"
        BT_IniziaPomodoro.Enabled = True
        Dim result As Integer = MessageBox.Show("Sei sicuro di voler uscire?", "Attenzione", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            End     'esce dal programma
        ElseIf result = DialogResult.No Then
            Exit Sub
        End If


    End Sub


    Private Sub Interruzione_Click(sender As System.Object, e As System.EventArgs)

        BT_IniziaPomodoro.Text = "Interruzione"
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



    '--------------------------------------------------------------------------------------
    '               SALVA POMODORI IN DATATABLE ED IN CSV
    '--------------------------------------------------------------------------------------

    Sub GetTable()
        ' Create new DataTable instance.
        Dim table As New DataTable

        ' Create four typed columns in the DataTable.
        table.Columns.Add("Dosage", GetType(Integer))
        table.Columns.Add("Drug", GetType(String))
        table.Columns.Add("Patient", GetType(String))
        table.Columns.Add("Date", GetType(DateTime))

        ' Add five rows with those columns filled in the DataTable.
        table.Rows.Add(25, "Indocin", "David", DateTime.Now)
        table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now)
        table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now)
        table.Rows.Add(21, "Combivent", "Janet", DateTime.Now)
        table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now)
        'Return table

        DataTable2CSV(table, "D:\prova.csv", ";")

    End Sub

    Sub DataTable2CSV(ByVal table As DataTable, ByVal filename As String,
    ByVal sepChar As String)
        Dim writer As System.IO.StreamWriter
        Try
            writer = New System.IO.StreamWriter(filename)

            ' first write a line with the columns name
            Dim sep As String = ""
            Dim builder As New System.Text.StringBuilder
            For Each col As DataColumn In table.Columns
                builder.Append(sep).Append(col.ColumnName)
                sep = sepChar
            Next
            writer.WriteLine(builder.ToString())

            ' then write all the rows
            For Each row As DataRow In table.Rows
                sep = ""
                builder = New System.Text.StringBuilder

                For Each col As DataColumn In table.Columns
                    builder.Append(sep).Append(row(col.ColumnName))
                    sep = sepChar
                Next
                writer.WriteLine(builder.ToString())
            Next
        Finally
            MsgBox("Errore di esportazione! Controlla il percorso nelle impostazioni")
        End Try
    End Sub

    Private Sub Bt_Impostazioni_Click(sender As System.Object, e As System.EventArgs) Handles Bt_Impostazioni.Click
        Me.TopMost = False
        Impostazioni.ShowDialog()
    End Sub


End Class
