<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerala
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenerala))
        Me.cmd1 = New System.Windows.Forms.Button()
        Me.cmd2 = New System.Windows.Forms.Button()
        Me.cmd3 = New System.Windows.Forms.Button()
        Me.cmd4 = New System.Windows.Forms.Button()
        Me.cmd5 = New System.Windows.Forms.Button()
        Me.cmdTodos = New System.Windows.Forms.Button()
        Me.cmdCambio = New System.Windows.Forms.Button()
        Me.lblEscaleraMay = New System.Windows.Forms.Label()
        Me.lblEscaleraMen = New System.Windows.Forms.Label()
        Me.lblGenerala = New System.Windows.Forms.Label()
        Me.lblPoker = New System.Windows.Forms.Label()
        Me.lblFull = New System.Windows.Forms.Label()
        Me.grpPuntajes = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpJ2 = New System.Windows.Forms.GroupBox()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.grpJ1 = New System.Windows.Forms.GroupBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.lblJugador = New System.Windows.Forms.Label()
        Me.cmdDefinir = New System.Windows.Forms.Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.pctIzq = New System.Windows.Forms.PictureBox()
        Me.pctDer = New System.Windows.Forms.PictureBox()
        Me.lblIntentos = New System.Windows.Forms.Label()
        Me.lblNumInten = New System.Windows.Forms.Label()
        Me.tmrTiempo = New System.Windows.Forms.Timer(Me.components)
        Me.grpPuntajes.SuspendLayout()
        Me.grpJ2.SuspendLayout()
        Me.grpJ1.SuspendLayout()
        CType(Me.pctIzq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctDer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd1
        '
        Me.cmd1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd1.BackgroundImage = CType(resources.GetObject("cmd1.BackgroundImage"), System.Drawing.Image)
        Me.cmd1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd1.Enabled = False
        Me.cmd1.Location = New System.Drawing.Point(12, 56)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(110, 116)
        Me.cmd1.TabIndex = 0
        Me.cmd1.UseVisualStyleBackColor = False
        '
        'cmd2
        '
        Me.cmd2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd2.BackgroundImage = CType(resources.GetObject("cmd2.BackgroundImage"), System.Drawing.Image)
        Me.cmd2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd2.Enabled = False
        Me.cmd2.Location = New System.Drawing.Point(128, 56)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(110, 116)
        Me.cmd2.TabIndex = 2
        Me.cmd2.UseVisualStyleBackColor = False
        '
        'cmd3
        '
        Me.cmd3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd3.BackgroundImage = CType(resources.GetObject("cmd3.BackgroundImage"), System.Drawing.Image)
        Me.cmd3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd3.Enabled = False
        Me.cmd3.Location = New System.Drawing.Point(244, 56)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(110, 116)
        Me.cmd3.TabIndex = 3
        Me.cmd3.UseVisualStyleBackColor = False
        '
        'cmd4
        '
        Me.cmd4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd4.BackgroundImage = CType(resources.GetObject("cmd4.BackgroundImage"), System.Drawing.Image)
        Me.cmd4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd4.Enabled = False
        Me.cmd4.Location = New System.Drawing.Point(360, 56)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(110, 116)
        Me.cmd4.TabIndex = 4
        Me.cmd4.UseVisualStyleBackColor = False
        '
        'cmd5
        '
        Me.cmd5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd5.BackgroundImage = CType(resources.GetObject("cmd5.BackgroundImage"), System.Drawing.Image)
        Me.cmd5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd5.Enabled = False
        Me.cmd5.Location = New System.Drawing.Point(476, 56)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(110, 116)
        Me.cmd5.TabIndex = 5
        Me.cmd5.UseVisualStyleBackColor = False
        '
        'cmdTodos
        '
        Me.cmdTodos.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdTodos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdTodos.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTodos.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdTodos.Location = New System.Drawing.Point(42, 178)
        Me.cmdTodos.Name = "cmdTodos"
        Me.cmdTodos.Size = New System.Drawing.Size(196, 39)
        Me.cmdTodos.TabIndex = 6
        Me.cmdTodos.Text = "Tirar Todos los Dados"
        Me.cmdTodos.UseVisualStyleBackColor = False
        '
        'cmdCambio
        '
        Me.cmdCambio.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdCambio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCambio.Enabled = False
        Me.cmdCambio.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCambio.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdCambio.Location = New System.Drawing.Point(476, 180)
        Me.cmdCambio.Name = "cmdCambio"
        Me.cmdCambio.Size = New System.Drawing.Size(87, 47)
        Me.cmdCambio.TabIndex = 7
        Me.cmdCambio.Text = "cambio Jugador"
        Me.cmdCambio.UseVisualStyleBackColor = False
        '
        'lblEscaleraMay
        '
        Me.lblEscaleraMay.AutoSize = True
        Me.lblEscaleraMay.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEscaleraMay.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEscaleraMay.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblEscaleraMay.Location = New System.Drawing.Point(17, 39)
        Me.lblEscaleraMay.Name = "lblEscaleraMay"
        Me.lblEscaleraMay.Size = New System.Drawing.Size(100, 14)
        Me.lblEscaleraMay.TabIndex = 8
        Me.lblEscaleraMay.Text = "Escalera Mayor"
        '
        'lblEscaleraMen
        '
        Me.lblEscaleraMen.AutoSize = True
        Me.lblEscaleraMen.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEscaleraMen.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEscaleraMen.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblEscaleraMen.Location = New System.Drawing.Point(16, 70)
        Me.lblEscaleraMen.Name = "lblEscaleraMen"
        Me.lblEscaleraMen.Size = New System.Drawing.Size(101, 14)
        Me.lblEscaleraMen.TabIndex = 9
        Me.lblEscaleraMen.Text = "Escalera Menor"
        '
        'lblGenerala
        '
        Me.lblGenerala.AutoSize = True
        Me.lblGenerala.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblGenerala.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenerala.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblGenerala.Location = New System.Drawing.Point(55, 103)
        Me.lblGenerala.Name = "lblGenerala"
        Me.lblGenerala.Size = New System.Drawing.Size(62, 14)
        Me.lblGenerala.TabIndex = 10
        Me.lblGenerala.Text = "Generala"
        '
        'lblPoker
        '
        Me.lblPoker.AutoSize = True
        Me.lblPoker.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPoker.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoker.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblPoker.Location = New System.Drawing.Point(73, 132)
        Me.lblPoker.Name = "lblPoker"
        Me.lblPoker.Size = New System.Drawing.Size(44, 14)
        Me.lblPoker.TabIndex = 11
        Me.lblPoker.Text = "Poker"
        '
        'lblFull
        '
        Me.lblFull.AutoSize = True
        Me.lblFull.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFull.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFull.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblFull.Location = New System.Drawing.Point(84, 164)
        Me.lblFull.Name = "lblFull"
        Me.lblFull.Size = New System.Drawing.Size(33, 14)
        Me.lblFull.TabIndex = 12
        Me.lblFull.Text = "Full"
        '
        'grpPuntajes
        '
        Me.grpPuntajes.BackgroundImage = Global.Generala_App.My.Resources.Resources.dice_fondo
        Me.grpPuntajes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpPuntajes.Controls.Add(Me.Label1)
        Me.grpPuntajes.Controls.Add(Me.grpJ2)
        Me.grpPuntajes.Controls.Add(Me.grpJ1)
        Me.grpPuntajes.Controls.Add(Me.lblFull)
        Me.grpPuntajes.Controls.Add(Me.lblPoker)
        Me.grpPuntajes.Controls.Add(Me.lblGenerala)
        Me.grpPuntajes.Controls.Add(Me.lblEscaleraMen)
        Me.grpPuntajes.Controls.Add(Me.lblEscaleraMay)
        Me.grpPuntajes.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPuntajes.ForeColor = System.Drawing.Color.RoyalBlue
        Me.grpPuntajes.Location = New System.Drawing.Point(60, 233)
        Me.grpPuntajes.Name = "grpPuntajes"
        Me.grpPuntajes.Size = New System.Drawing.Size(470, 206)
        Me.grpPuntajes.TabIndex = 13
        Me.grpPuntajes.TabStop = False
        Me.grpPuntajes.Text = "Puntajes"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(381, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 109)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Anota tu juego, el que completa primero gana!"
        '
        'grpJ2
        '
        Me.grpJ2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grpJ2.Controls.Add(Me.CheckedListBox2)
        Me.grpJ2.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpJ2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.grpJ2.Location = New System.Drawing.Point(281, 14)
        Me.grpJ2.Name = "grpJ2"
        Me.grpJ2.Size = New System.Drawing.Size(82, 186)
        Me.grpJ2.TabIndex = 14
        Me.grpJ2.TabStop = False
        Me.grpJ2.Text = "Jugador 2"
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.BackColor = System.Drawing.Color.RoyalBlue
        Me.CheckedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CheckedListBox2.CheckOnClick = True
        Me.CheckedListBox2.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Items.AddRange(New Object() {"", "", "", "", ""})
        Me.CheckedListBox2.Location = New System.Drawing.Point(31, 16)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(27, 162)
        Me.CheckedListBox2.TabIndex = 1
        '
        'grpJ1
        '
        Me.grpJ1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grpJ1.Controls.Add(Me.CheckedListBox1)
        Me.grpJ1.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpJ1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.grpJ1.Location = New System.Drawing.Point(165, 14)
        Me.grpJ1.Name = "grpJ1"
        Me.grpJ1.Size = New System.Drawing.Size(82, 186)
        Me.grpJ1.TabIndex = 13
        Me.grpJ1.TabStop = False
        Me.grpJ1.Text = "Jugador 1"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BackColor = System.Drawing.Color.RoyalBlue
        Me.CheckedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"", "", "", "", ""})
        Me.CheckedListBox1.Location = New System.Drawing.Point(24, 16)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(27, 162)
        Me.CheckedListBox1.TabIndex = 0
        '
        'lblJugador
        '
        Me.lblJugador.AutoSize = True
        Me.lblJugador.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblJugador.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJugador.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lblJugador.Location = New System.Drawing.Point(9, 7)
        Me.lblJugador.Name = "lblJugador"
        Me.lblJugador.Size = New System.Drawing.Size(70, 17)
        Me.lblJugador.TabIndex = 14
        Me.lblJugador.Text = "Jugador"
        '
        'cmdDefinir
        '
        Me.cmdDefinir.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdDefinir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDefinir.Enabled = False
        Me.cmdDefinir.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDefinir.ForeColor = System.Drawing.Color.DarkRed
        Me.cmdDefinir.Location = New System.Drawing.Point(253, 178)
        Me.cmdDefinir.Name = "cmdDefinir"
        Me.cmdDefinir.Size = New System.Drawing.Size(191, 39)
        Me.cmdDefinir.TabIndex = 15
        Me.cmdDefinir.Text = "DEFINIR JUGADA"
        Me.cmdDefinir.UseVisualStyleBackColor = False
        '
        'lblMensaje
        '
        Me.lblMensaje.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMensaje.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblMensaje.Location = New System.Drawing.Point(102, 9)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(333, 31)
        Me.lblMensaje.TabIndex = 16
        Me.lblMensaje.Text = "Puedes tirar todos los Dados o tocarlos de a UNO para que giren, solo tienes TRES" &
    " intentos."
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pctIzq
        '
        Me.pctIzq.BackgroundImage = Global.Generala_App.My.Resources.Resources.dice_fondo
        Me.pctIzq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctIzq.ErrorImage = CType(resources.GetObject("pctIzq.ErrorImage"), System.Drawing.Image)
        Me.pctIzq.InitialImage = CType(resources.GetObject("pctIzq.InitialImage"), System.Drawing.Image)
        Me.pctIzq.Location = New System.Drawing.Point(12, 263)
        Me.pctIzq.Name = "pctIzq"
        Me.pctIzq.Size = New System.Drawing.Size(31, 42)
        Me.pctIzq.TabIndex = 17
        Me.pctIzq.TabStop = False
        '
        'pctDer
        '
        Me.pctDer.BackgroundImage = Global.Generala_App.My.Resources.Resources.dice_fondo
        Me.pctDer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctDer.ErrorImage = CType(resources.GetObject("pctDer.ErrorImage"), System.Drawing.Image)
        Me.pctDer.InitialImage = CType(resources.GetObject("pctDer.InitialImage"), System.Drawing.Image)
        Me.pctDer.Location = New System.Drawing.Point(553, 263)
        Me.pctDer.Name = "pctDer"
        Me.pctDer.Size = New System.Drawing.Size(31, 42)
        Me.pctDer.TabIndex = 18
        Me.pctDer.TabStop = False
        '
        'lblIntentos
        '
        Me.lblIntentos.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblIntentos.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntentos.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lblIntentos.Location = New System.Drawing.Point(466, 9)
        Me.lblIntentos.Name = "lblIntentos"
        Me.lblIntentos.Size = New System.Drawing.Size(80, 31)
        Me.lblIntentos.TabIndex = 19
        Me.lblIntentos.Text = "Número de Intentos"
        '
        'lblNumInten
        '
        Me.lblNumInten.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNumInten.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumInten.ForeColor = System.Drawing.Color.Gold
        Me.lblNumInten.Location = New System.Drawing.Point(553, 9)
        Me.lblNumInten.Name = "lblNumInten"
        Me.lblNumInten.Size = New System.Drawing.Size(33, 31)
        Me.lblNumInten.TabIndex = 20
        Me.lblNumInten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrTiempo
        '
        Me.tmrTiempo.Interval = 1000
        '
        'frmGenerala
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Generala_App.My.Resources.Resources.dice_fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(596, 451)
        Me.Controls.Add(Me.lblNumInten)
        Me.Controls.Add(Me.lblIntentos)
        Me.Controls.Add(Me.pctDer)
        Me.Controls.Add(Me.pctIzq)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.cmdDefinir)
        Me.Controls.Add(Me.lblJugador)
        Me.Controls.Add(Me.grpPuntajes)
        Me.Controls.Add(Me.cmdCambio)
        Me.Controls.Add(Me.cmdTodos)
        Me.Controls.Add(Me.cmd5)
        Me.Controls.Add(Me.cmd4)
        Me.Controls.Add(Me.cmd3)
        Me.Controls.Add(Me.cmd2)
        Me.Controls.Add(Me.cmd1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmGenerala"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generala"
        Me.grpPuntajes.ResumeLayout(False)
        Me.grpPuntajes.PerformLayout()
        Me.grpJ2.ResumeLayout(False)
        Me.grpJ1.ResumeLayout(False)
        CType(Me.pctIzq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctDer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd1 As Button
    Friend WithEvents cmd2 As Button
    Friend WithEvents cmd3 As Button
    Friend WithEvents cmd4 As Button
    Friend WithEvents cmd5 As Button
    Friend WithEvents cmdTodos As Button
    Friend WithEvents cmdCambio As Button
    Friend WithEvents lblEscaleraMay As Label
    Friend WithEvents lblEscaleraMen As Label
    Friend WithEvents lblGenerala As Label
    Friend WithEvents lblPoker As Label
    Friend WithEvents lblFull As Label
    Friend WithEvents grpPuntajes As GroupBox
    Friend WithEvents grpJ2 As GroupBox
    Friend WithEvents grpJ1 As GroupBox
    Friend WithEvents lblJugador As Label
    Friend WithEvents cmdDefinir As Button
    Friend WithEvents lblMensaje As Label
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents pctIzq As PictureBox
    Friend WithEvents pctDer As PictureBox
    Friend WithEvents lblIntentos As Label
    Friend WithEvents lblNumInten As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tmrTiempo As Timer
End Class
