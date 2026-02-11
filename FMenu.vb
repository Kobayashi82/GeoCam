
#Region " GeoCam "

Public Class FMenu

#Region " Variables "

#Region " Estructuras "

    Private Structure ST_Imagen
        Dim RutaOriginal As String
        Dim Ruta As String
        Dim Aircraft As String
        Dim Latitud As String
        Dim Longitud As String
        Dim Altitude As String
        Dim Speed As String
        Dim Heading As String
        Dim isNorth As Boolean
        Dim isEast As Boolean
        Dim FechaHora As String
        Dim Localidad As String
    End Structure

    Private Structure ST_Ordenador
        Dim RutaOriginal As String
        Dim Ruta As String
        Dim FechaHora As DateTime
    End Structure

#End Region

    Dim GeoPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\GeoCam\"
    'Dim GeoPath As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + "\GeoCam\"
    'Dim GeoPath As String = (Application.StartupPath + "\Iconos\").Replace("\\", "\")
    Dim TempPath As String = IO.Path.GetTempPath + "GeoCam\"
    Dim ImagenesPath As String
    Dim KMZPath As String
    Dim KMZFolderPath As String
    Dim Icono As Integer = 0
    Dim Iconos() As String
    Dim Imagenes() As ST_Imagen
    Dim Loaded As Boolean

#End Region

#Region " Formulario "

    Private Sub FMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        On Error Resume Next
        Left = CInt(GetRegKey("GeoCam", "Left", (Screen.PrimaryScreen.Bounds.Width - Width) / 2))
        Top = CInt(GetRegKey("GeoCam", "Top", (Screen.PrimaryScreen.Bounds.Height - Height) / 2))
        ImagenesPath = GetRegKey("GeoCam", "ImagenesPath", "") : TPicture.Text = ImagenesPath
        CSubfolders.Checked = CBool(GetRegKey("GeoCam", "CSubfolders", "True"))
        CAbrirFinConversion.Checked = CBool(GetRegKey("GeoCam", "CAbrirFinConversion", "True"))
        CAircraft.Checked = CBool(GetRegKey("GeoCam", "CAircraft", "True"))
        CHeading.Checked = CBool(GetRegKey("GeoCam", "CHeading", "True"))
        CVelocidad.Checked = CBool(GetRegKey("GeoCam", "CVelocidad", "True"))
        CMostrarNudos.Checked = CBool(GetRegKey("GeoCam", "CMostrarNudos", "True"))
        CAltitud.Checked = CBool(GetRegKey("GeoCam", "CAltitud", "True"))
        CAltitudMetros.Checked = CBool(GetRegKey("GeoCam", "CAltitudMetros", "True"))
        CLocalidad.Checked = CBool(GetRegKey("GeoCam", "CLocalidad", "True"))
        CTamaño.SelectedIndex = CInt(GetRegKey("GeoCam", "Tamaño", "3"))
        TEscala.Value = CDec(GetRegKey("GeoCam", "Escala", "0,7"))
    End Sub

    Private Sub FMenu_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Cargar_Iconos() : BConvertir.Refresh()
        Loaded = True
    End Sub


    Private Sub FMenu_Move(sender As Object, e As EventArgs) Handles Me.Move
        If Loaded = True Then SetRegKey("GeoCam", "Left", Left.ToString) : SetRegKey("GeoCam", "Top", Top.ToString)
    End Sub

    Private Sub HTexto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles HTexto.KeyPress
        e.Handled = True
    End Sub

    Private Sub FMenu_Click(sender As Object, e As EventArgs) Handles Me.Click, LMensaje.Click, LPicture.Click, LTamaño.Click, LIcono.Click, LEscala.Click, LAbout.Click, CSubfolders.Click, CAbrirFinConversion.Click, BPicture_Examinar.Click, BConvertir.Click, PIcon.Click, Me.DoubleClick, LMensaje.DoubleClick, LPicture.DoubleClick, LTamaño.DoubleClick, LIcono.DoubleClick, LEscala.DoubleClick, LAbout.DoubleClick, CSubfolders.DoubleClick, CAbrirFinConversion.DoubleClick, BPicture_Examinar.DoubleClick, BConvertir.DoubleClick, PIcon.DoubleClick, LNombre.DoubleClick, LNombre.Click, CVelocidad.DoubleClick, CVelocidad.Click, CLocalidad.DoubleClick, CLocalidad.Click, CHeading.DoubleClick, CHeading.Click, CAltitudMetros.DoubleClick, CAltitudMetros.Click, CAltitud.DoubleClick, CAltitud.Click, CAircraft.DoubleClick, CAircraft.Click, CMostrarNudos.DoubleClick, CMostrarNudos.Click
        HTexto.Focus()
    End Sub


#Region " Registro "

    Private Function GetRegKey(SubKey As String, Name As String, Optional DefaultValue As String = "") As String
        Try : My.Computer.Registry.CurrentUser.CreateSubKey("Software\" + SubKey) : Using Reg = My.Computer.Registry.CurrentUser.OpenSubKey("Software\" + SubKey, True)
                If Reg.GetValue(Name) = "" Then Reg.SetValue(Name, DefaultValue)
                Return Reg.GetValue(Name) : End Using
        Catch : Return "" : End Try
    End Function

    Private Sub SetRegKey(SubKey As String, Name As String, Value As String)
        Try : My.Computer.Registry.CurrentUser.CreateSubKey("Software\" + SubKey) : Using Reg = My.Computer.Registry.CurrentUser.OpenSubKey("Software\" + SubKey, True)
                Reg.SetValue(Name, Value) : End Using
        Catch : End Try
    End Sub

#End Region

#End Region

#Region " Imagenes  "

    Private Sub TPicture_LostFocus(sender As Object, e As EventArgs) Handles TPicture.LostFocus
        ImagenesPath = TPicture.Text : SetRegKey("GeoCam", "ImagenesPath", ImagenesPath)
    End Sub

    Private Sub TPicture_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TPicture.KeyPress
        If Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 27 Then e.Handled = True : HTexto.Focus()
    End Sub

    Private Sub BPicture_Examinar_Click(sender As Object, e As MouseEventArgs) Handles BPicture_Examinar.Click, BPicture_Examinar.DoubleClick
        If e.Button <> MouseButtons.Left Then Exit Sub
        Dim AbrirCarpeta As New FolderBrowserDialog With {.Description = "Seleccione la carpeta de imagenes", .SelectedPath = TPicture.Text}
        If AbrirCarpeta.ShowDialog() = DialogResult.Cancel Then Exit Sub
        TPicture.Text = AbrirCarpeta.SelectedPath : ImagenesPath = TPicture.Text : SetRegKey("GeoCam", "ImagenesPath", ImagenesPath)
    End Sub

#End Region

#Region " Checks "

    Private Sub Checks_CheckedChanged(sender As Object) Handles CSubfolders.CheckedChanged, CAbrirFinConversion.CheckedChanged, CVelocidad.CheckedChanged, CLocalidad.CheckedChanged, CHeading.CheckedChanged, CAltitudMetros.CheckedChanged, CAltitud.CheckedChanged, CAircraft.CheckedChanged, CMostrarNudos.CheckedChanged
        SetRegKey("GeoCam", CType(sender, BonfireCheckbox).Name, CType(sender, BonfireCheckbox).Checked.ToString)
    End Sub

    Private Sub CTamaño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CTamaño.SelectedIndexChanged
        SetRegKey("GeoCam", "Tamaño", CTamaño.SelectedIndex.ToString)
    End Sub

#End Region

#Region " Iconos "

    Private Sub Cargar_Iconos()
        If IO.Directory.Exists(GeoPath) = False Then IO.Directory.CreateDirectory(GeoPath)
        If IO.File.Exists(GeoPath + "IconoA.png") = False Then Guardar_Icono(My.Resources.Icono0, "IconoA")
        If IO.File.Exists(GeoPath + "IconoB.png") = False Then Guardar_Icono(My.Resources.Icono1, "IconoB")
        If IO.File.Exists(GeoPath + "IconoC.png") = False Then Guardar_Icono(My.Resources.Icono2, "IconoC")
        If IO.File.Exists(GeoPath + "IconoD.png") = False Then Guardar_Icono(My.Resources.Icono3, "IconoD")
        If IO.File.Exists(GeoPath + "IconoE.png") = False Then Guardar_Icono(My.Resources.Icono4, "IconoE")
        If IO.File.Exists(GeoPath + "IconoF.png") = False Then Guardar_Icono(My.Resources.Icono5, "IconoF")
        If IO.File.Exists(GeoPath + "IconoG.png") = False Then Guardar_Icono(My.Resources.Icono6, "IconoG")
        If IO.File.Exists(GeoPath + "IconoH.png") = False Then Guardar_Icono(My.Resources.Icono7, "IconoH")
        If IO.File.Exists(GeoPath + "IconoI.png") = False Then Guardar_Icono(My.Resources.Icono8, "IconoI")
        If IO.File.Exists(GeoPath + "IconoJ.png") = False Then Guardar_Icono(My.Resources.Icono9, "IconoJ")
        If IO.File.Exists(GeoPath + "IconoK.png") = False Then Guardar_Icono(My.Resources.Icono10, "IconoK")
        If IO.File.Exists(GeoPath + "IconoL.png") = False Then Guardar_Icono(My.Resources.Icono11, "IconoL")
        If IO.File.Exists(GeoPath + "IconoM.png") = False Then Guardar_Icono(My.Resources.Icono12, "IconoM")
        If IO.File.Exists(GeoPath + "IconoN.png") = False Then Guardar_Icono(My.Resources.Icono13, "IconoN")
        If IO.File.Exists(GeoPath + "IconoO.png") = False Then Guardar_Icono(My.Resources.Icono14, "IconoO")
        If IO.File.Exists(GeoPath + "IconoP.png") = False Then Guardar_Icono(My.Resources.Icono15, "IconoP")
        Iconos = IO.Directory.GetFiles(GeoPath, "*.png", IO.SearchOption.TopDirectoryOnly)
        If IO.File.Exists(GetRegKey("GeoCam", "Icono", "")) = False Then
            Icono = 0 : PIcon.Image = LoadImageClone(Iconos(0)) : SetRegKey("GeoCam", "Icono", Iconos(Icono))
        Else
            For Cuenta = 0 To Iconos.Length - 1
                If Iconos(Cuenta).ToLower = GetRegKey("GeoCam", "Icono", "").ToLower Then Icono = Cuenta : PIcon.Image = LoadImageClone(Iconos(Cuenta)) : Exit Sub
            Next
            Icono = 0 : PIcon.Image = LoadImageClone(Iconos(0)) : SetRegKey("GeoCam", "Icono", Iconos(Icono))
        End If
    End Sub

    Private Sub Guardar_Icono(Imagen As Bitmap, Nombre As String, Optional Completa As Boolean = False)
        Dim TempBMP As New Bitmap(Imagen, New Size(32, 32))
        If Completa = False Then TempBMP.Save(GeoPath + Nombre + ".png", Imaging.ImageFormat.Png) Else TempBMP.Save(Nombre, Imaging.ImageFormat.Png)
    End Sub

    Private Sub PIcon_Click(sender As Object, e As MouseEventArgs) Handles PIcon.Click, PIcon.DoubleClick
        If BConvertir.Text = "Convirtiendo..." Or BConvertir.Text = "Guardando..." Then Exit Sub
        If e.Button = MouseButtons.Left Then
            Icono += 1 : If Icono = Iconos.Length Then Icono = 0
            PIcon.Image = LoadImageClone(Iconos(Icono))
            SetRegKey("GeoCam", "Icono", Iconos(Icono))
        ElseIf e.Button = MouseButtons.Right Then
            Try : Dim Abrir As New OpenFileDialog With {.Title = "Seleccione un icono", .CheckFileExists = True, .Filter = "Iconos|*.ico;*.png"}
                If Abrir.ShowDialog() = DialogResult.Cancel Then Exit Sub
                Dim Contador As Integer = 1
                If IO.Directory.Exists(GeoPath) = False Then IO.Directory.CreateDirectory(GeoPath)
                Do Until IO.File.Exists(GeoPath + "zCustomIcon" + Contador.ToString + ".png") = False : Contador += 1 : Loop
                If Abrir.FileName.ToLower.EndsWith(".ico") Then PIcon.Image = New Icon(Abrir.FileName).ToBitmap Else PIcon.Image = LoadImageClone(Abrir.FileName)
                Guardar_Icono(PIcon.Image, "zCustomIcon" + Contador.ToString)

                For Cuenta = 0 To Iconos.Length - 1
                    If Iconos(Cuenta).ToLower = (GeoPath + "zCustomIcon" + Contador.ToString + ".png").ToLower Then SetRegKey("GeoCam", "Icono", GeoPath + "zCustomIcon" + Contador.ToString + ".png") : Icono = Cuenta : Exit Sub
                Next
                ReDim Preserve Iconos(Iconos.Length)
                Iconos(Iconos.Length - 1) = GeoPath + "zCustomIcon" + Contador.ToString + ".png" : Icono = Iconos.Length - 1
                SetRegKey("GeoCam", "Icono", GeoPath + "zCustomIcon" + Contador.ToString + ".png") : Exit Sub
            Catch : End Try
            PIcon.Image = LoadImageClone(Iconos(0)) : Icono = 0 : SetRegKey("GeoCam", "Icono", Iconos(0))
        ElseIf e.Button = MouseButtons.Middle Then
            If IO.Path.GetFileName(Iconos(Icono)).StartsWith("Icono") = False Then
                IO.File.Delete(Iconos(Icono))
                Icono -= 1 : PIcon.Image = LoadImageClone(Iconos(Icono)) : SetRegKey("GeoCam", "Icono", Iconos(Icono))
                Cargar_Iconos()
            End If
        End If
    End Sub

    Private Sub PIcon_MouseWheel(sender As Object, e As MouseEventArgs) Handles PIcon.MouseWheel
        If BConvertir.Text = "Convirtiendo..." Or BConvertir.Text = "Guardando..." Then Exit Sub
        If e.Delta < 0 Then
            Icono += 1 : If Icono = Iconos.Length Then Icono = 0
            PIcon.Image = LoadImageClone(Iconos(Icono))
            SetRegKey("GeoCam", "Icono", Iconos(Icono))
        Else
            Icono -= 1 : If Icono = -1 Then Icono = Iconos.Length - 1
            PIcon.Image = LoadImageClone(Iconos(Icono))
            SetRegKey("GeoCam", "Icono", Iconos(Icono))
        End If
    End Sub

    Private Sub TEscala_TextChanged(sender As Object, e As EventArgs) Handles TEscala.TextChanged
        If Loaded = True Then SetRegKey("GeoCam", "Escala", TEscala.Value.ToString)
    End Sub

    Private Sub TEscala_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TEscala.KeyPress
        If Asc(e.KeyChar) = 13 Or Asc(e.KeyChar) = 27 Then e.Handled = True : HTexto.Focus()
    End Sub

    Private Function LoadImageClone(sPath As String) As Image
        If Not IO.File.Exists(sPath) Then Return Nothing
        Dim bmpOriginal As Image = Image.FromFile(sPath) : Dim bmpClone As New Bitmap(bmpOriginal.Width, bmpOriginal.Height) : Dim g As Graphics = Graphics.FromImage(bmpClone)
        g.SmoothingMode = Drawing2D.SmoothingMode.None : g.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor : g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighSpeed
        g.DrawImage(bmpOriginal, 0, 0, bmpOriginal.Width, bmpOriginal.Height) : g.Dispose() : bmpOriginal.Dispose() : Return bmpClone
    End Function

#End Region

#Region " Convertir "

    Private Sub BConvertir_Click(sender As Object, e As MouseEventArgs) Handles BConvertir.Click, BConvertir.DoubleClick

        Dim filePaths() As String = IO.Directory.GetFiles(ImagenesPath, IO.SearchOption.AllDirectories).Where(Function(s) {".jpg", ".png"}.Contains(IO.Path.GetExtension(s))).ToArray()

        Try : If e.Button <> MouseButtons.Left Or BConvertir.Text = "Convirtiendo..." Or BConvertir.Text = "Guardando..." Then Exit Sub
            If IO.Directory.Exists(ImagenesPath) = False Then MsgBox("No se encuentran imagenes en la carpeta seleccionada", MsgBoxStyle.Exclamation, "GeoCam") : Exit Sub
            Dim supportedExtensions As String = "*.jpg,*.png"
            Dim Contador As Integer = 1 : Dim str1() As String : Dim str As New List(Of String)
            If CSubfolders.Checked = True Then str1 = IO.Directory.GetFiles(ImagenesPath, "*.*", IO.SearchOption.AllDirectories) Else str1 = IO.Directory.GetFiles(ImagenesPath, "*.*", IO.SearchOption.TopDirectoryOnly)
            For Each fi As String In str1
                If supportedExtensions.ToLower.Contains(IO.Path.GetExtension(fi).ToLower) Then str.Add(fi)
            Next : If str.Count = 0 Then MsgBox("No se encuentran imagenes en la carpeta seleccionada", MsgBoxStyle.Exclamation, "GeoCam") : Exit Sub

            Dim Abrir As New SaveFileDialog With {.Title = "Crear en...", .CheckPathExists = True, .OverwritePrompt = True, .FileName = IO.Path.GetFileName(ImagenesPath), .Filter = "Archivo de Google Earth|*.kmz|Archivo comprimido|*.zip"}
            If Abrir.ShowDialog() = DialogResult.Cancel Then Exit Sub
            KMZPath = Abrir.FileName
            If IO.Directory.Exists(TempPath) = True Then IO.Directory.Delete(TempPath, True)
            IO.Directory.CreateDirectory(TempPath) : IO.Directory.CreateDirectory(TempPath + "images")
            Guardar_Icono(PIcon.Image, TempPath + "Icono.png", True)

            ReDim Imagenes(str.Count - 1)
            BConvertir.Text = "Convirtiendo..." : BConvertir.Refresh()
            BConvertir.Enabled = False
            TPicture.Enabled = False
            BPicture_Examinar.Enabled = False
            CSubfolders.Enabled = False
            CAbrirFinConversion.Enabled = False
            CTamaño.Enabled = False
            PIcon.Enabled = False
            TEscala.Enabled = False
            CHeading.Enabled = False
            CVelocidad.Enabled = False
            CAltitud.Enabled = False
            CLocalidad.Enabled = False
            CAltitudMetros.Enabled = False

            Dim Ordenador(str.Count - 1) As ST_Ordenador
            Dim FechaHoras As New List(Of Date)
            For Cuenta = 0 To Ordenador.Count - 1
                For Each Tag As LevDan.Exif.ExifTag In New LevDan.Exif.ExifTagCollection(str(Cuenta))
                    If Tag.FieldName = "DateTimeOriginal" Then
                        Ordenador(Cuenta).RutaOriginal = str(Cuenta)
                        Ordenador(Cuenta).Ruta = str(Cuenta)
                        Ordenador(Cuenta).FechaHora = DateTime.ParseExact(Tag.Value, "yyyy:MM:dd HH:mm:ss", Nothing)
                        FechaHoras.Add(DateTime.ParseExact(Tag.Value, "yyyy:MM:dd HH:mm:ss", Nothing))
                    End If
                Next : Application.DoEvents()
            Next

            FechaHoras.Sort()
            For Cuenta = 0 To FechaHoras.Count - 1
                For Cuenta2 = 0 To Ordenador.Length - 1
                    If FechaHoras(Cuenta) = Ordenador(Cuenta2).FechaHora Then Imagenes(Cuenta).Ruta = Ordenador(Cuenta2).Ruta : Imagenes(Cuenta).RutaOriginal = Ordenador(Cuenta2).RutaOriginal : Exit For
                    Application.DoEvents()
                Next
            Next

            For Cuenta = 0 To Imagenes.Length - 1
                Dim SacaLocalidad() As String = Imagenes(Cuenta).Ruta.Split("-")
                If SacaLocalidad.Length > 0 Then Imagenes(Cuenta).Localidad = SacaLocalidad(SacaLocalidad.Length - 1).Split(".")(0).Replace("_", " ").Replace(")", "").Replace("á", "a").Replace("Á", "A").Replace("é", "e").Replace("É", "E").Replace("í", "i").Replace("Í", "I").Replace("ó", "o").Replace("Ó", "O").Replace("ú", "u").Replace("Ú", "U").Replace("â", "a").Replace("Â", "A").Replace("ê", "e").Replace("Ê", "E").Replace("î", "i").Replace("Î", "I").Replace("ô", "o").Replace("Ô", "O").Replace("û", "u").Replace("Û", "U").Trim
                Imagenes(Cuenta).Ruta = TempPath + "images\" + IO.Path.GetFileName((IO.Path.GetFileName(ImagenesPath) + " - " + (Cuenta + 1).ToString + " - " + Imagenes(Cuenta).Localidad + IO.Path.GetExtension(Imagenes(Cuenta).Ruta)).Replace("\\", "\"))

                IO.File.Copy(Imagenes(Cuenta).RutaOriginal, Imagenes(Cuenta).Ruta, True)
                Application.DoEvents()
            Next

            For Cuenta = 0 To Imagenes.Length - 1
                For Each Tag As LevDan.Exif.ExifTag In New LevDan.Exif.ExifTagCollection(Imagenes(Cuenta).Ruta)
                    Select Case Tag.FieldName
                        Case "DateTimeOriginal" : Imagenes(Cuenta).FechaHora = Tag.Value.Split(" ")(0).Replace(":", "-") + "T" + Tag.Value.Split(" ")(1) + "Z"
                        Case "ImageDescription" : Imagenes(Cuenta).Aircraft = Tag.Value
                        Case "GPSLatitudeRef" : If Tag.Value.ToLower.Contains("north") Then Imagenes(Cuenta).isNorth = True Else Imagenes(Cuenta).isNorth = False
                        Case "GPSLongitudeRef" : If Tag.Value.ToLower.Contains("east") Then Imagenes(Cuenta).isEast = True Else Imagenes(Cuenta).isEast = False
                        Case "GPSLatitude" : Imagenes(Cuenta).Latitud = ToDec(Tag.Value) : If Imagenes(Cuenta).isNorth = False Then Imagenes(Cuenta).Latitud = "-" + Imagenes(Cuenta).Latitud
                        Case "GPSLongitude" : Imagenes(Cuenta).Longitud = ToDec(Tag.Value) : If Imagenes(Cuenta).isEast = False Then Imagenes(Cuenta).Longitud = "-" + Imagenes(Cuenta).Longitud
                        Case "GPSAltitude" : Imagenes(Cuenta).Altitude = Math.Round(Decimal.Parse(Tag.Value.Replace(" meters", ""))).ToString
                        Case "GPSSpeed" : Imagenes(Cuenta).Speed = Math.Round(Decimal.Parse(Tag.Value)).ToString
                        Case "GPSImgDirection" : Imagenes(Cuenta).Heading = Math.Round(Decimal.Parse(Tag.Value)).ToString
                    End Select
                Next : Application.DoEvents()
            Next

            Dim TotalTexto As String = TCabecera.Text
            For Cuenta = 0 To Imagenes.Length - 1
                Dim Texto As String = TTemplate.Text
                Texto = Texto.Replace("[fechahora]", Imagenes(Cuenta).FechaHora)
                Texto = Texto.Replace("[ruta]", "images/" + IO.Path.GetFileName(Imagenes(Cuenta).Ruta))
                Dim TempTexto As String = ""
                If CAircraft.Checked = True Then TempTexto += ", (" + Imagenes(Cuenta).Aircraft + ")"
                If CHeading.Checked = True Then TempTexto += ", (Heading: " + Imagenes(Cuenta).Heading + "º)"
                If CVelocidad.Checked = True Then
                    If CMostrarNudos.Checked = False Then
                        TempTexto += ", (Speed: " + String.Format("{0:n0}", CInt(Imagenes(Cuenta).Speed)) + " km/h)"
                    Else
                        TempTexto += ", (Speed: " + String.Format("{0:n0}", CInt(CInt(Imagenes(Cuenta).Speed) * 0.539957)) + " kt)"
                    End If
                End If
                If CAltitud.Checked = True Then
                    If CAltitudMetros.Checked = True Then
                        TempTexto += ", (Altitude: " + String.Format("{0:n0}", CInt(Imagenes(Cuenta).Altitude)) + " m.)"
                    Else
                        TempTexto += ", (Altitude: " + String.Format("{0:n0}", CInt(CInt(Imagenes(Cuenta).Altitude) * 3.28084)) + " ft.)"
                    End If
                End If
                If TempTexto.Length > 0 Then TempTexto = (" - " + TempTexto.Substring(1))
                If CLocalidad.Checked = True AndAlso Imagenes(Cuenta).Localidad <> "" Then TempTexto = " - " + Imagenes(Cuenta).Localidad + TempTexto
                TempTexto = (Cuenta + 1).ToString + TempTexto

                Texto = Texto.Replace("[name]", TempTexto)

                Texto = Texto.Replace("[size]", 250 * (CTamaño.SelectedIndex + 1)).ToString
                Texto = Texto.Replace("[longitude]", Imagenes(Cuenta).Longitud)
                Texto = Texto.Replace("[latitude]", Imagenes(Cuenta).Latitud)
                Texto = Texto.Replace("[altitude]", Imagenes(Cuenta).Altitude)
                Texto = Texto.Replace("[heading]", Imagenes(Cuenta).Heading)
                TotalTexto += vbCrLf + Texto
                Application.DoEvents()
            Next : TotalTexto = TotalTexto.Replace("[titulo]", IO.Path.GetFileNameWithoutExtension(KMZPath)).Replace("[escala]", TEscala.Value.ToString.Replace(",", ".")) + vbCrLf + "</Document>" + vbCrLf + "</kml>"

            Dim Guardar As New IO.StreamWriter(TempPath + IO.Path.GetFileNameWithoutExtension(Abrir.FileName) + ".kml") : Guardar.Write(TotalTexto) : Guardar.Close()
            If IO.File.Exists(Abrir.FileName) = True Then IO.File.Delete(Abrir.FileName)
            IO.Compression.ZipFile.CreateFromDirectory(TempPath, Abrir.FileName, IO.Compression.CompressionLevel.Optimal, False)
            BConvertir.Text = "Convertir"
            BConvertir.Enabled = True : BConvertir.Refresh()
            TPicture.Enabled = True
            BPicture_Examinar.Enabled = True
            CSubfolders.Enabled = True
            CAbrirFinConversion.Enabled = True
            CTamaño.Enabled = True
            PIcon.Enabled = True
            TEscala.Enabled = True
            CHeading.Enabled = True
            CVelocidad.Enabled = True
            CAltitud.Enabled = True
            CLocalidad.Enabled = True
            CAltitudMetros.Enabled = True

            If CAbrirFinConversion.Checked = True Then If Abrir.FileName.ToLower.EndsWith(".kmz") Then Process.Start(Abrir.FileName) Else Process.Start(IO.Path.GetDirectoryName(Abrir.FileName))
            My.Computer.Audio.Play(My.Resources.BatteryLow, AudioPlayMode.Background)

        Catch ex As Exception : MsgBox("Algo ha salido mal..." + vbCrLf + vbCrLf + ex.Message, MsgBoxStyle.Critical, "GeoCam") : End Try
    End Sub

    Private Function ToDec(Coordinate As String) As String
        Try : Dim CoorHour As Decimal = Decimal.Parse(System.Text.RegularExpressions.Regex.Replace(Coordinate.Split(" ")(0), "[^\d]", ""))
            Dim CoorMinute As Decimal = Decimal.Parse(System.Text.RegularExpressions.Regex.Replace(Coordinate.Split(" ")(1), "[^\d]", ""))
            Dim CoorSeconds As Decimal = Decimal.Parse(Coordinate.Split(" ")(2).Replace("""", ""))

            Return Math.Round((CoorHour + (CoorMinute / 60) + (CoorSeconds / 3600)), 6).ToString.Replace(",", ".")
        Catch : End Try : Return ""
    End Function

#End Region

End Class

#End Region