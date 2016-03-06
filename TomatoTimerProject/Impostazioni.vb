Imports System.Runtime.InteropServices
Imports System.IO

Public Class Impostazioni

    Dim directory As String = My.Application.Info.DirectoryPath


    '-------------------------------------------------------------------------------------------------------------------------------------
    ' GESTISCE IL PRIMO PIANO 
    '-------------------------------------------------------------------------------------------------------------------------------------

    Private Sub Impostazioni_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim testo As String = ""
        Dim contatore As Integer = 1


        Dim ImpostazioniTXT As String = directory & "\Impostazioni.txt"
        Dim lettore As New System.IO.StreamReader(ImpostazioniTXT)

        'controlla se il file esiste
        If System.IO.File.Exists(ImpostazioniTXT) = True Then

            Do While lettore.Peek() <> -1

                testo = lettore.ReadLine()

                'prima riga: leggo primo piano
                If contatore = 1 Then
                    If testo = "True" Then
                        CB_PrimoPiano.Checked = True
                    Else
                        CB_PrimoPiano.Checked = False
                    End If
                End If

                'seconda riga: leggo percorso csv
                If contatore = 2 Then
                    Percorso_CSV.Text = testo
                End If

                contatore += 1

            Loop

        Else

            MsgBox("File Impostazioni.txt non trovato nella cartella del programma! Ricrearlo?", vbYesNo)
            If vbYes Then
                'creare file impostazioni txt
            Else
                MsgBox("Impossibile caricare e salvare le impostazioni")
            End If

        End If

        lettore.Close()

    End Sub

    Private Sub bt_exit_Click(sender As System.Object, e As System.EventArgs) Handles bt_exit.Click

        Dim testoNEW As String = ""
        Dim contatore As Integer = 1
        Dim ImpostazioniTXT As String = directory & "\Impostazioni.txt"
        Dim scrittore As New System.IO.StreamWriter(ImpostazioniTXT)

        'controlla se il file esiste
        If System.IO.File.Exists(ImpostazioniTXT) = True Then

            If CB_PrimoPiano.Checked Then
                testoNEW = ("True") & vbNewLine & Percorso_CSV.Text
            Else
                testoNEW = ("False") & vbNewLine & Percorso_CSV.Text
            End If

            scrittore.Write(testoNEW)

        Else

            MsgBox("File Impostazioni.txt non trovato nella cartella del programma! Ricrearlo?", vbYesNo)
            If vbYes Then
                'creare file impostazioni txt
            Else
                MsgBox("Impossibile caricare e salvare le impostazioni")
            End If

        End If

        scrittore.Close()

        If CB_PrimoPiano.Checked Then
            TomatoTimer.TopMost = True
        Else
            TomatoTimer.TopMost = False
        End If

        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Percorso_CSV_TextChanged(sender As Object, e As EventArgs) Handles Percorso_CSV.TextChanged

    End Sub

    Private Sub CB_PrimoPiano_CheckedChanged(sender As Object, e As EventArgs) Handles CB_PrimoPiano.CheckedChanged

    End Sub
End Class