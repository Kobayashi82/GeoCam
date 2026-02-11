<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMenu))
        Me.TEscala = New System.Windows.Forms.NumericUpDown()
        Me.PIcon = New System.Windows.Forms.PictureBox()
        Me.TPicture_Examinar = New System.Windows.Forms.TextBox()
        Me.TPicture = New System.Windows.Forms.TextBox()
        Me.TCabecera = New System.Windows.Forms.TextBox()
        Me.TTemplate = New System.Windows.Forms.TextBox()
        Me.TConvertir = New System.Windows.Forms.TextBox()
        Me.HTexto = New System.Windows.Forms.TextBox()
        Me.CVelocidad = New GeoCam.BonfireCheckbox()
        Me.CHeading = New GeoCam.BonfireCheckbox()
        Me.CMostrarNudos = New GeoCam.BonfireCheckbox()
        Me.CAltitudMetros = New GeoCam.BonfireCheckbox()
        Me.CAltitud = New GeoCam.BonfireCheckbox()
        Me.BonfireGroupBox6 = New GeoCam.BonfireGroupBox()
        Me.BonfireGroupBox3 = New GeoCam.BonfireGroupBox()
        Me.BonfireGroupBox2 = New GeoCam.BonfireGroupBox()
        Me.BonfireGroupBox4 = New GeoCam.BonfireGroupBox()
        Me.BonfireGroupBox1 = New GeoCam.BonfireGroupBox()
        Me.LAbout = New GeoCam.BonfireLabel()
        Me.CAbrirFinConversion = New GeoCam.BonfireCheckbox()
        Me.CAircraft = New GeoCam.BonfireCheckbox()
        Me.CLocalidad = New GeoCam.BonfireCheckbox()
        Me.LNombre = New GeoCam.BonfireLabel()
        Me.LTamaño = New GeoCam.BonfireLabel()
        Me.LPicture = New GeoCam.BonfireLabel()
        Me.CTamaño = New GeoCam.BonfireCombo()
        Me.LIcono = New GeoCam.BonfireLabel()
        Me.LMensaje = New GeoCam.BonfireLabel()
        Me.LEscala = New GeoCam.BonfireLabel()
        Me.CSubfolders = New GeoCam.BonfireCheckbox()
        Me.BConvertir = New GeoCam.BonfireButton()
        Me.BPicture_Examinar = New GeoCam.BonfireButton()
        Me.BonfireGroupBox5 = New GeoCam.BonfireGroupBox()
        CType(Me.TEscala, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TEscala
        '
        Me.TEscala.DecimalPlaces = 1
        Me.TEscala.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.TEscala.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.TEscala.Location = New System.Drawing.Point(483, 175)
        Me.TEscala.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.TEscala.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.TEscala.Name = "TEscala"
        Me.TEscala.Size = New System.Drawing.Size(42, 20)
        Me.TEscala.TabIndex = 20
        Me.TEscala.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TEscala.Value = New Decimal(New Integer() {7, 0, 0, 65536})
        '
        'PIcon
        '
        Me.PIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PIcon.Location = New System.Drawing.Point(403, 173)
        Me.PIcon.Name = "PIcon"
        Me.PIcon.Size = New System.Drawing.Size(25, 25)
        Me.PIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PIcon.TabIndex = 10
        Me.PIcon.TabStop = False
        '
        'TPicture_Examinar
        '
        Me.TPicture_Examinar.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.TPicture_Examinar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TPicture_Examinar.Enabled = False
        Me.TPicture_Examinar.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.TPicture_Examinar.Location = New System.Drawing.Point(482, 110)
        Me.TPicture_Examinar.Name = "TPicture_Examinar"
        Me.TPicture_Examinar.ReadOnly = True
        Me.TPicture_Examinar.Size = New System.Drawing.Size(24, 20)
        Me.TPicture_Examinar.TabIndex = 7
        '
        'TPicture
        '
        Me.TPicture.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.TPicture.Location = New System.Drawing.Point(166, 110)
        Me.TPicture.Name = "TPicture"
        Me.TPicture.Size = New System.Drawing.Size(317, 20)
        Me.TPicture.TabIndex = 8
        '
        'TCabecera
        '
        Me.TCabecera.Location = New System.Drawing.Point(596, 169)
        Me.TCabecera.Multiline = True
        Me.TCabecera.Name = "TCabecera"
        Me.TCabecera.Size = New System.Drawing.Size(68, 184)
        Me.TCabecera.TabIndex = 18
        Me.TCabecera.Text = resources.GetString("TCabecera.Text")
        Me.TCabecera.Visible = False
        '
        'TTemplate
        '
        Me.TTemplate.Location = New System.Drawing.Point(596, 5)
        Me.TTemplate.Multiline = True
        Me.TTemplate.Name = "TTemplate"
        Me.TTemplate.Size = New System.Drawing.Size(68, 161)
        Me.TTemplate.TabIndex = 18
        Me.TTemplate.Text = resources.GetString("TTemplate.Text")
        Me.TTemplate.Visible = False
        '
        'TConvertir
        '
        Me.TConvertir.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.TConvertir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TConvertir.Enabled = False
        Me.TConvertir.Font = New System.Drawing.Font("Verdana", 25.0!)
        Me.TConvertir.Location = New System.Drawing.Point(85, 280)
        Me.TConvertir.Name = "TConvertir"
        Me.TConvertir.ReadOnly = True
        Me.TConvertir.Size = New System.Drawing.Size(224, 48)
        Me.TConvertir.TabIndex = 19
        '
        'HTexto
        '
        Me.HTexto.Location = New System.Drawing.Point(655, 316)
        Me.HTexto.Name = "HTexto"
        Me.HTexto.ReadOnly = True
        Me.HTexto.Size = New System.Drawing.Size(52, 20)
        Me.HTexto.TabIndex = 0
        '
        'CVelocidad
        '
        Me.CVelocidad.Checked = True
        Me.CVelocidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CVelocidad.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CVelocidad.Location = New System.Drawing.Point(374, 224)
        Me.CVelocidad.Name = "CVelocidad"
        Me.CVelocidad.Size = New System.Drawing.Size(90, 20)
        Me.CVelocidad.TabIndex = 13
        Me.CVelocidad.Text = "Velocidad"
        '
        'CHeading
        '
        Me.CHeading.Checked = True
        Me.CHeading.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CHeading.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CHeading.Location = New System.Drawing.Point(285, 224)
        Me.CHeading.Name = "CHeading"
        Me.CHeading.Size = New System.Drawing.Size(83, 20)
        Me.CHeading.TabIndex = 13
        Me.CHeading.Text = "Heading"
        '
        'CMostrarNudos
        '
        Me.CMostrarNudos.Checked = True
        Me.CMostrarNudos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMostrarNudos.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CMostrarNudos.Location = New System.Drawing.Point(356, 291)
        Me.CMostrarNudos.Name = "CMostrarNudos"
        Me.CMostrarNudos.Size = New System.Drawing.Size(186, 20)
        Me.CMostrarNudos.TabIndex = 13
        Me.CMostrarNudos.Text = "Mostrar Velocidad en nudos"
        '
        'CAltitudMetros
        '
        Me.CAltitudMetros.Checked = True
        Me.CAltitudMetros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CAltitudMetros.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CAltitudMetros.Location = New System.Drawing.Point(410, 265)
        Me.CAltitudMetros.Name = "CAltitudMetros"
        Me.CAltitudMetros.Size = New System.Drawing.Size(174, 20)
        Me.CAltitudMetros.TabIndex = 13
        Me.CAltitudMetros.Text = "Mostrar Altitud en metros"
        '
        'CAltitud
        '
        Me.CAltitud.Checked = True
        Me.CAltitud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CAltitud.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CAltitud.Location = New System.Drawing.Point(470, 224)
        Me.CAltitud.Name = "CAltitud"
        Me.CAltitud.Size = New System.Drawing.Size(74, 20)
        Me.CAltitud.TabIndex = 13
        Me.CAltitud.Text = "Altitud"
        '
        'BonfireGroupBox6
        '
        Me.BonfireGroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BonfireGroupBox6.Location = New System.Drawing.Point(365, 254)
        Me.BonfireGroupBox6.Name = "BonfireGroupBox6"
        Me.BonfireGroupBox6.Size = New System.Drawing.Size(21, 2)
        Me.BonfireGroupBox6.TabIndex = 21
        '
        'BonfireGroupBox3
        '
        Me.BonfireGroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BonfireGroupBox3.Location = New System.Drawing.Point(420, 254)
        Me.BonfireGroupBox3.Name = "BonfireGroupBox3"
        Me.BonfireGroupBox3.Size = New System.Drawing.Size(62, 2)
        Me.BonfireGroupBox3.TabIndex = 21
        '
        'BonfireGroupBox2
        '
        Me.BonfireGroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BonfireGroupBox2.Location = New System.Drawing.Point(420, 254)
        Me.BonfireGroupBox2.Name = "BonfireGroupBox2"
        Me.BonfireGroupBox2.Size = New System.Drawing.Size(2, 20)
        Me.BonfireGroupBox2.TabIndex = 21
        '
        'BonfireGroupBox4
        '
        Me.BonfireGroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BonfireGroupBox4.Location = New System.Drawing.Point(384, 238)
        Me.BonfireGroupBox4.Name = "BonfireGroupBox4"
        Me.BonfireGroupBox4.Size = New System.Drawing.Size(2, 17)
        Me.BonfireGroupBox4.TabIndex = 21
        '
        'BonfireGroupBox1
        '
        Me.BonfireGroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BonfireGroupBox1.Location = New System.Drawing.Point(480, 238)
        Me.BonfireGroupBox1.Name = "BonfireGroupBox1"
        Me.BonfireGroupBox1.Size = New System.Drawing.Size(2, 17)
        Me.BonfireGroupBox1.TabIndex = 21
        '
        'LAbout
        '
        Me.LAbout.AutoSize = True
        Me.LAbout.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.LAbout.ForeColor = System.Drawing.Color.Silver
        Me.LAbout.Location = New System.Drawing.Point(511, 343)
        Me.LAbout.Name = "LAbout"
        Me.LAbout.Size = New System.Drawing.Size(110, 12)
        Me.LAbout.TabIndex = 6
        Me.LAbout.Text = "Kobayashi Corp. ©"
        '
        'CAbrirFinConversion
        '
        Me.CAbrirFinConversion.Checked = True
        Me.CAbrirFinConversion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CAbrirFinConversion.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CAbrirFinConversion.Location = New System.Drawing.Point(342, 137)
        Me.CAbrirFinConversion.Name = "CAbrirFinConversion"
        Me.CAbrirFinConversion.Size = New System.Drawing.Size(200, 20)
        Me.CAbrirFinConversion.TabIndex = 13
        Me.CAbrirFinConversion.Text = "Abrir al finalizar la conversión"
        '
        'CAircraft
        '
        Me.CAircraft.Checked = True
        Me.CAircraft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CAircraft.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CAircraft.Location = New System.Drawing.Point(205, 224)
        Me.CAircraft.Name = "CAircraft"
        Me.CAircraft.Size = New System.Drawing.Size(74, 20)
        Me.CAircraft.TabIndex = 13
        Me.CAircraft.Text = "Aircraft"
        '
        'CLocalidad
        '
        Me.CLocalidad.Checked = True
        Me.CLocalidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CLocalidad.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CLocalidad.Location = New System.Drawing.Point(109, 224)
        Me.CLocalidad.Name = "CLocalidad"
        Me.CLocalidad.Size = New System.Drawing.Size(90, 20)
        Me.CLocalidad.TabIndex = 13
        Me.CLocalidad.Text = "Localidad"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.LNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.LNombre.Location = New System.Drawing.Point(46, 227)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(57, 13)
        Me.LNombre.TabIndex = 16
        Me.LNombre.Text = "Nombre:"
        '
        'LTamaño
        '
        Me.LTamaño.AutoSize = True
        Me.LTamaño.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.LTamaño.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.LTamaño.Location = New System.Drawing.Point(103, 181)
        Me.LTamaño.Name = "LTamaño"
        Me.LTamaño.Size = New System.Drawing.Size(57, 13)
        Me.LTamaño.TabIndex = 16
        Me.LTamaño.Text = "Tamaño:"
        '
        'LPicture
        '
        Me.LPicture.AutoSize = True
        Me.LPicture.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.LPicture.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.LPicture.Location = New System.Drawing.Point(91, 113)
        Me.LPicture.Name = "LPicture"
        Me.LPicture.Size = New System.Drawing.Size(69, 13)
        Me.LPicture.TabIndex = 6
        Me.LPicture.Text = "Imagenes:"
        '
        'CTamaño
        '
        Me.CTamaño.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CTamaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CTamaño.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CTamaño.FormattingEnabled = True
        Me.CTamaño.ItemHeight = 20
        Me.CTamaño.Items.AddRange(New Object() {"Mínimo", "Pequeño", "Mediano", "Grande"})
        Me.CTamaño.Location = New System.Drawing.Point(166, 175)
        Me.CTamaño.Name = "CTamaño"
        Me.CTamaño.Size = New System.Drawing.Size(98, 26)
        Me.CTamaño.TabIndex = 15
        '
        'LIcono
        '
        Me.LIcono.AutoSize = True
        Me.LIcono.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.LIcono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.LIcono.Location = New System.Drawing.Point(353, 178)
        Me.LIcono.Name = "LIcono"
        Me.LIcono.Size = New System.Drawing.Size(44, 13)
        Me.LIcono.TabIndex = 5
        Me.LIcono.Text = "Icono:"
        '
        'LMensaje
        '
        Me.LMensaje.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.LMensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.LMensaje.Location = New System.Drawing.Point(62, 21)
        Me.LMensaje.Name = "LMensaje"
        Me.LMensaje.Size = New System.Drawing.Size(503, 60)
        Me.LMensaje.TabIndex = 14
        Me.LMensaje.Text = "Convierte imagenes con datos de geolocalización a un archivo ZIP, KMZ o una carpe" &
    "ta"
        Me.LMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LEscala
        '
        Me.LEscala.AutoSize = True
        Me.LEscala.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.LEscala.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.LEscala.Location = New System.Drawing.Point(435, 178)
        Me.LEscala.Name = "LEscala"
        Me.LEscala.Size = New System.Drawing.Size(48, 13)
        Me.LEscala.TabIndex = 5
        Me.LEscala.Text = "Escala:"
        '
        'CSubfolders
        '
        Me.CSubfolders.Checked = True
        Me.CSubfolders.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CSubfolders.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CSubfolders.Location = New System.Drawing.Point(166, 137)
        Me.CSubfolders.Name = "CSubfolders"
        Me.CSubfolders.Size = New System.Drawing.Size(157, 20)
        Me.CSubfolders.TabIndex = 13
        Me.CSubfolders.Text = "Buscar en subcarpetas"
        '
        'BConvertir
        '
        Me.BConvertir.ButtonStyle = GeoCam.BonfireButton.Style.Blue
        Me.BConvertir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BConvertir.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BConvertir.Image = Nothing
        Me.BConvertir.Location = New System.Drawing.Point(86, 281)
        Me.BConvertir.Name = "BConvertir"
        Me.BConvertir.RoundedCorners = False
        Me.BConvertir.Size = New System.Drawing.Size(222, 46)
        Me.BConvertir.TabIndex = 11
        Me.BConvertir.Text = "Convertir"
        '
        'BPicture_Examinar
        '
        Me.BPicture_Examinar.ButtonStyle = GeoCam.BonfireButton.Style.Blue
        Me.BPicture_Examinar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BPicture_Examinar.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BPicture_Examinar.Image = Nothing
        Me.BPicture_Examinar.Location = New System.Drawing.Point(483, 111)
        Me.BPicture_Examinar.Name = "BPicture_Examinar"
        Me.BPicture_Examinar.RoundedCorners = False
        Me.BPicture_Examinar.Size = New System.Drawing.Size(22, 18)
        Me.BPicture_Examinar.TabIndex = 9
        Me.BPicture_Examinar.Text = "..."
        '
        'BonfireGroupBox5
        '
        Me.BonfireGroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BonfireGroupBox5.Location = New System.Drawing.Point(365, 255)
        Me.BonfireGroupBox5.Name = "BonfireGroupBox5"
        Me.BonfireGroupBox5.Size = New System.Drawing.Size(2, 40)
        Me.BonfireGroupBox5.TabIndex = 21
        '
        'FMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 361)
        Me.Controls.Add(Me.CVelocidad)
        Me.Controls.Add(Me.CHeading)
        Me.Controls.Add(Me.CMostrarNudos)
        Me.Controls.Add(Me.CAltitudMetros)
        Me.Controls.Add(Me.CAltitud)
        Me.Controls.Add(Me.BonfireGroupBox6)
        Me.Controls.Add(Me.BonfireGroupBox3)
        Me.Controls.Add(Me.BonfireGroupBox2)
        Me.Controls.Add(Me.BonfireGroupBox4)
        Me.Controls.Add(Me.BonfireGroupBox1)
        Me.Controls.Add(Me.LAbout)
        Me.Controls.Add(Me.HTexto)
        Me.Controls.Add(Me.TEscala)
        Me.Controls.Add(Me.TCabecera)
        Me.Controls.Add(Me.CAbrirFinConversion)
        Me.Controls.Add(Me.CAircraft)
        Me.Controls.Add(Me.CLocalidad)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.TTemplate)
        Me.Controls.Add(Me.LTamaño)
        Me.Controls.Add(Me.LPicture)
        Me.Controls.Add(Me.CTamaño)
        Me.Controls.Add(Me.LIcono)
        Me.Controls.Add(Me.LMensaje)
        Me.Controls.Add(Me.LEscala)
        Me.Controls.Add(Me.CSubfolders)
        Me.Controls.Add(Me.TPicture)
        Me.Controls.Add(Me.BConvertir)
        Me.Controls.Add(Me.BPicture_Examinar)
        Me.Controls.Add(Me.PIcon)
        Me.Controls.Add(Me.TConvertir)
        Me.Controls.Add(Me.TPicture_Examinar)
        Me.Controls.Add(Me.BonfireGroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "GeoCam"
        CType(Me.TEscala, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BConvertir As BonfireButton
    Friend WithEvents PIcon As PictureBox
    Friend WithEvents BPicture_Examinar As BonfireButton
    Friend WithEvents TPicture_Examinar As TextBox
    Friend WithEvents TPicture As TextBox
    Friend WithEvents LIcono As BonfireLabel
    Friend WithEvents LPicture As BonfireLabel
    Friend WithEvents LTamaño As BonfireLabel
    Friend WithEvents CTamaño As BonfireCombo
    Friend WithEvents LMensaje As BonfireLabel
    Friend WithEvents CSubfolders As BonfireCheckbox
    Friend WithEvents TTemplate As TextBox
    Friend WithEvents TCabecera As TextBox
    Friend WithEvents TConvertir As TextBox
    Friend WithEvents CAbrirFinConversion As BonfireCheckbox
    Friend WithEvents TEscala As NumericUpDown
    Friend WithEvents LEscala As BonfireLabel
    Friend WithEvents HTexto As TextBox
    Friend WithEvents LAbout As BonfireLabel
    Friend WithEvents CLocalidad As BonfireCheckbox
    Friend WithEvents CAltitud As BonfireCheckbox
    Friend WithEvents CVelocidad As BonfireCheckbox
    Friend WithEvents CHeading As BonfireCheckbox
    Friend WithEvents CAltitudMetros As BonfireCheckbox
    Friend WithEvents BonfireGroupBox1 As BonfireGroupBox
    Friend WithEvents LNombre As BonfireLabel
    Friend WithEvents CAircraft As BonfireCheckbox
    Friend WithEvents BonfireGroupBox2 As BonfireGroupBox
    Friend WithEvents BonfireGroupBox3 As BonfireGroupBox
    Friend WithEvents CMostrarNudos As BonfireCheckbox
    Friend WithEvents BonfireGroupBox4 As BonfireGroupBox
    Friend WithEvents BonfireGroupBox5 As BonfireGroupBox
    Friend WithEvents BonfireGroupBox6 As BonfireGroupBox
End Class
