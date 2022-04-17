Imports System.Media

Public Class frmGenerala
    Private X As New Random
    Dim D1 As Integer = 0
    Dim D2 As Integer = 0
    Dim D3 As Integer = 0
    Dim D4 As Integer = 0
    Dim D5 As Integer = 0
    Dim T As Integer = 0
    Dim segundos As Integer = 0
    Dim Sonido As New SoundPlayer()



    Private Sub cmdTodos_Click(sender As Object, e As EventArgs) Handles cmdTodos.Click

        D1 = X.Next(1, 7)
        D2 = X.Next(1, 7)
        D3 = X.Next(1, 7)
        D4 = X.Next(1, 7)
        D5 = X.Next(1, 7)

        cmd1.Enabled = True
        cmd2.Enabled = True
        cmd3.Enabled = True
        cmd4.Enabled = True
        cmd5.Enabled = True
        cmdDefinir.Enabled = True
        T = (T + 1)
        lblNumInten.Text = T
        pctDer.BackgroundImage = My.Resources.dice_169063
        pctIzq.BackgroundImage = My.Resources.dice_169063
        Sonido.SoundLocation = "cartoon-00073.wav"
        Sonido.Play()
        segundos = 15
        tmrTiempo.Start()

        If T = 3 Then
            cmdCambio.Enabled = True
            cmd1.Enabled = False
            cmd2.Enabled = False
            cmd3.Enabled = False
            cmd4.Enabled = False
            cmd5.Enabled = False
            cmdTodos.Enabled = False
            lblNumInten.Text = T

        End If

        Select Case D1
            Case 1
                cmd1.BackgroundImage = My.Resources.dado1

            Case 2
                cmd1.BackgroundImage = My.Resources.dado2
            Case 3
                cmd1.BackgroundImage = My.Resources.dado3
            Case 4
                cmd1.BackgroundImage = My.Resources.dado4
            Case 5
                cmd1.BackgroundImage = My.Resources.dado5
            Case 6
                cmd1.BackgroundImage = My.Resources.dado6

        End Select
        Select Case D2
            Case 1
                cmd2.BackgroundImage = My.Resources.dado1

            Case 2
                cmd2.BackgroundImage = My.Resources.dado2
            Case 3
                cmd2.BackgroundImage = My.Resources.dado3
            Case 4
                cmd2.BackgroundImage = My.Resources.dado4
            Case 5
                cmd2.BackgroundImage = My.Resources.dado5
            Case 6
                cmd2.BackgroundImage = My.Resources.dado6

        End Select

        Select Case D3
            Case 1
                cmd3.BackgroundImage = My.Resources.dado1

            Case 2
                cmd3.BackgroundImage = My.Resources.dado2
            Case 3
                cmd3.BackgroundImage = My.Resources.dado3
            Case 4
                cmd3.BackgroundImage = My.Resources.dado4
            Case 5
                cmd3.BackgroundImage = My.Resources.dado5
            Case 6
                cmd3.BackgroundImage = My.Resources.dado6

        End Select

        Select Case D4
            Case 1
                cmd4.BackgroundImage = My.Resources.dado1

            Case 2
                cmd4.BackgroundImage = My.Resources.dado2
            Case 3
                cmd4.BackgroundImage = My.Resources.dado3
            Case 4
                cmd4.BackgroundImage = My.Resources.dado4
            Case 5
                cmd4.BackgroundImage = My.Resources.dado5
            Case 6
                cmd4.BackgroundImage = My.Resources.dado6

        End Select

        Select Case D5
            Case 1
                cmd5.BackgroundImage = My.Resources.dado1

            Case 2
                cmd5.BackgroundImage = My.Resources.dado2
            Case 3
                cmd5.BackgroundImage = My.Resources.dado3
            Case 4
                cmd5.BackgroundImage = My.Resources.dado4
            Case 5
                cmd5.BackgroundImage = My.Resources.dado5
            Case 6
                cmd5.BackgroundImage = My.Resources.dado6

        End Select

    End Sub

    Private Sub cmdCambio_Click(sender As Object, e As EventArgs) Handles cmdCambio.Click

        cmd1.BackgroundImage = My.Resources.dice_169063
        cmd2.BackgroundImage = My.Resources.dice_169063
        cmd3.BackgroundImage = My.Resources.dice_169063
        cmd4.BackgroundImage = My.Resources.dice_169063
        cmd5.BackgroundImage = My.Resources.dice_169063
        cmdTodos.Enabled = True
        lblMensaje.Text = "Puedes tirar todos los Dados o tocarlos de a UNO para que giren, solo tienes TRES intentos."
        lblJugador.Text = "Jugador"
        T = 0
        lblNumInten.Text = T
        Sonido.SoundLocation = "cartoon-00031.wav"
        Sonido.Play()
        cmdCambio.BackColor = Color.Black

    End Sub

    Private Sub cmd1_Click(sender As Object, e As EventArgs) Handles cmd1.Click
        D1 = X.Next(1, 7)
        T = (T + 1)
        lblNumInten.Text = T
        Sonido.SoundLocation = "cartoon-00265.wav"
        Sonido.Play()
        If T = 3 Then
            cmdCambio.Enabled = True
            cmd1.Enabled = False
            cmd2.Enabled = False
            cmd3.Enabled = False
            cmd4.Enabled = False
            cmd5.Enabled = False
            cmdTodos.Enabled = False
            lblNumInten.Text = T

        End If
        Select Case D1
            Case 1
                cmd1.BackgroundImage = My.Resources.dado1

            Case 2
                cmd1.BackgroundImage = My.Resources.dado2
            Case 3
                cmd1.BackgroundImage = My.Resources.dado3
            Case 4
                cmd1.BackgroundImage = My.Resources.dado4
            Case 5
                cmd1.BackgroundImage = My.Resources.dado5
            Case 6
                cmd1.BackgroundImage = My.Resources.dado6

        End Select
    End Sub

    Private Sub cmd2_Click(sender As Object, e As EventArgs) Handles cmd2.Click
        D2 = X.Next(1, 7)
        T = (T + 1)
        lblNumInten.Text = T
        Sonido.SoundLocation = "cartoon-00265.wav"
        Sonido.Play()
        If T = 3 Then
            cmdCambio.Enabled = True
            cmd1.Enabled = False
            cmd2.Enabled = False
            cmd3.Enabled = False
            cmd4.Enabled = False
            cmd5.Enabled = False
            cmdTodos.Enabled = False
            lblNumInten.Text = T
        End If
        Select Case D2
            Case 1
                cmd2.BackgroundImage = My.Resources.dado1

            Case 2
                cmd2.BackgroundImage = My.Resources.dado2
            Case 3
                cmd2.BackgroundImage = My.Resources.dado3
            Case 4
                cmd2.BackgroundImage = My.Resources.dado4
            Case 5
                cmd2.BackgroundImage = My.Resources.dado5
            Case 6
                cmd2.BackgroundImage = My.Resources.dado6

        End Select

    End Sub

    Private Sub cmd3_Click(sender As Object, e As EventArgs) Handles cmd3.Click
        D3 = X.Next(1, 7)
        T = (T + 1)
        lblNumInten.Text = T
        If T = 3 Then
            cmdCambio.Enabled = True
            cmd1.Enabled = False
            cmd2.Enabled = False
            cmd3.Enabled = False
            cmd4.Enabled = False
            cmd5.Enabled = False
            cmdTodos.Enabled = False
            lblNumInten.Text = T
            Sonido.SoundLocation = "cartoon-00265.wav"
            Sonido.Play()
        End If
        Select Case D3
            Case 1
                cmd3.BackgroundImage = My.Resources.dado1

            Case 2
                cmd3.BackgroundImage = My.Resources.dado2
            Case 3
                cmd3.BackgroundImage = My.Resources.dado3
            Case 4
                cmd3.BackgroundImage = My.Resources.dado4
            Case 5
                cmd3.BackgroundImage = My.Resources.dado5
            Case 6
                cmd3.BackgroundImage = My.Resources.dado6

        End Select

    End Sub

    Private Sub cmd4_Click(sender As Object, e As EventArgs) Handles cmd4.Click
        D4 = X.Next(1, 7)
        T = (T + 1)
        lblNumInten.Text = T
        If T = 3 Then
            cmdCambio.Enabled = True
            cmd1.Enabled = False
            cmd2.Enabled = False
            cmd3.Enabled = False
            cmd4.Enabled = False
            cmd5.Enabled = False
            cmdTodos.Enabled = False
            lblNumInten.Text = T
            Sonido.SoundLocation = "cartoon-00265.wav"
            Sonido.Play()
        End If
        Select Case D4
            Case 1
                cmd4.BackgroundImage = My.Resources.dado1

            Case 2
                cmd4.BackgroundImage = My.Resources.dado2
            Case 3
                cmd4.BackgroundImage = My.Resources.dado3
            Case 4
                cmd4.BackgroundImage = My.Resources.dado4
            Case 5
                cmd4.BackgroundImage = My.Resources.dado5
            Case 6
                cmd4.BackgroundImage = My.Resources.dado6

        End Select
    End Sub

    Private Sub cmd5_Click(sender As Object, e As EventArgs) Handles cmd5.Click
        D5 = X.Next(1, 7)
        T = (T + 1)
        lblNumInten.Text = T
        If T = 3 Then
            cmdCambio.Enabled = True
            cmd1.Enabled = False
            cmd2.Enabled = False
            cmd3.Enabled = False
            cmd4.Enabled = False
            cmd5.Enabled = False
            cmdTodos.Enabled = False
            lblNumInten.Text = T
            Sonido.SoundLocation = "cartoon-00265.wav"
            Sonido.Play()
        End If
        Select Case D5
            Case 1
                cmd5.BackgroundImage = My.Resources.dado1

            Case 2
                cmd5.BackgroundImage = My.Resources.dado2
            Case 3
                cmd5.BackgroundImage = My.Resources.dado3
            Case 4
                cmd5.BackgroundImage = My.Resources.dado4
            Case 5
                cmd5.BackgroundImage = My.Resources.dado5
            Case 6
                cmd5.BackgroundImage = My.Resources.dado6

        End Select
    End Sub

    Private Sub cmdDefinir_Click(sender As Object, e As EventArgs) Handles cmdDefinir.Click

        cmdCambio.Enabled = True
        Dim S As Integer = 0
        S = (D1 + D2 + D3 + D4 + D5)
        cmd1.Enabled = False
        cmd2.Enabled = False
        cmd3.Enabled = False
        cmd4.Enabled = False
        cmd5.Enabled = False
        Sonido.SoundLocation = "cartoon-00243.wav"
        Sonido.Play()
        If (D1 = D2 And D2 = D3 And D3 = D4 And D4 = D5) Then

            lblMensaje.Text = "Generala!"
            cmdTodos.Enabled = False
            lblJugador.Text = "Generala!"

        Else
            If (D1 = D2 And D2 = D3 And D3 = D4) Or (D2 = D3 And D3 = D4 And D4 = D5) Or (D1 = D3 And D3 = D4 And D4 = D5) Or
            (D1 = D2 And D2 = D4 And D4 = D5) Or (D1 = D2 And D2 = D3 And D3 = D5) Or (D1 = D2 And D2 = D3 And D3 = D4) Then
                lblMensaje.Text = "Poker!"
                cmdTodos.Enabled = False
                lblJugador.Text = "Poker!"
            Else
                If (D1 = D2 And D2 <> D3 And D3 = D4 And D4 = D5) Or
                (D1 = D2 And D2 = D3 And D3 <> D4 And D4 = D5) Or
                (D1 <> D2 And D2 = D3 And D3 = D4 And D1 = D5) Or
                (D1 <> D2 And D1 = D3 And D1 = D5 And D2 = D4) Or
                (D1 <> D2 And D2 = D3 And D1 = D4 And D4 = D5) Or
                (D1 <> D2 And D2 = D3 And D1 = D4 And D3 = D5) Or
                (D1 = D2 And D2 <> D3 And D3 = D5 And D2 = D4) Or
                (D1 <> D2 And D2 = D4 And D1 = D3 And D1 = D5) Then

                    lblMensaje.Text = "Full!"
                    cmdTodos.Enabled = False
                    lblJugador.Text = "Full!"
                Else
                    If (D1 <> D2 And D1 <> D3 And D1 <> D4 And D1 <> D5 And D2 <> D3 And
                    D2 <> D4 And D2 <> D5 And D3 <> D4 And D3 <> D5 And D4 <> D5) Then
                        Select Case S
                            Case 20
                                lblMensaje.Text = "Escalera Mayor"
                                lblJugador.Text = "Mayor"
                                cmdTodos.Enabled = False
                            Case 15
                                lblMensaje.Text = "Escalera Menor"
                                lblJugador.Text = "Menor"
                                cmdTodos.Enabled = False

                        End Select
                    Else
                        lblMensaje.Text = "Sigue Participando :P"

                    End If

                End If
            End If
        End If

    End Sub

    Private Sub frmGenerala_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sonido.SoundLocation = "cartoon-00429.wav"
        Sonido.Play()
    End Sub

    Private Sub tmrTiempo_Tick(sender As Object, e As EventArgs) Handles tmrTiempo.Tick

        If segundos < 1 Then
            segundos = 15
            tmrTiempo.Stop()
            cmdCambio.Enabled = True
            cmd1.Enabled = False
            cmd2.Enabled = False
            cmd3.Enabled = False
            cmd4.Enabled = False
            cmd5.Enabled = False
            cmdTodos.Enabled = False
            Sonido.SoundLocation = "cartoon-00243.wav"
            Sonido.Play()
            cmdCambio.BackColor = Color.Yellow
            lblMensaje.Text = "se termino el tiempo!!"

        Else
            segundos = segundos - 1

        End If
        lblJugador.Text = segundos

    End Sub
End Class
