<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FNombre
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
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.LMensaje = New GeoCam.BonfireLabel()
        Me.BAceptar = New GeoCam.BonfireButton()
        Me.TAceptar = New System.Windows.Forms.TextBox()
        Me.TCancelar = New System.Windows.Forms.TextBox()
        Me.BCancelar = New GeoCam.BonfireButton()
        Me.SuspendLayout()
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(76, 64)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(206, 20)
        Me.TNombre.TabIndex = 10
        Me.TNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LMensaje
        '
        Me.LMensaje.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.LMensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.LMensaje.Location = New System.Drawing.Point(58, 12)
        Me.LMensaje.Name = "LMensaje"
        Me.LMensaje.Size = New System.Drawing.Size(241, 35)
        Me.LMensaje.TabIndex = 9
        Me.LMensaje.Text = "Escriba un nombre para la carpeta"
        Me.LMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BAceptar
        '
        Me.BAceptar.ButtonStyle = GeoCam.BonfireButton.Style.Blue
        Me.BAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BAceptar.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BAceptar.Image = Nothing
        Me.BAceptar.Location = New System.Drawing.Point(38, 109)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.RoundedCorners = False
        Me.BAceptar.Size = New System.Drawing.Size(120, 28)
        Me.BAceptar.TabIndex = 20
        Me.BAceptar.Text = "Aceptar"
        '
        'TAceptar
        '
        Me.TAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.TAceptar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TAceptar.Enabled = False
        Me.TAceptar.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.TAceptar.Location = New System.Drawing.Point(37, 108)
        Me.TAceptar.Name = "TAceptar"
        Me.TAceptar.ReadOnly = True
        Me.TAceptar.Size = New System.Drawing.Size(122, 30)
        Me.TAceptar.TabIndex = 21
        '
        'TCancelar
        '
        Me.TCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.TCancelar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TCancelar.Enabled = False
        Me.TCancelar.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.TCancelar.Location = New System.Drawing.Point(194, 107)
        Me.TCancelar.Name = "TCancelar"
        Me.TCancelar.ReadOnly = True
        Me.TCancelar.Size = New System.Drawing.Size(122, 30)
        Me.TCancelar.TabIndex = 21
        '
        'BCancelar
        '
        Me.BCancelar.ButtonStyle = GeoCam.BonfireButton.Style.Blue
        Me.BCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BCancelar.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BCancelar.Image = Nothing
        Me.BCancelar.Location = New System.Drawing.Point(195, 108)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.RoundedCorners = False
        Me.BCancelar.Size = New System.Drawing.Size(120, 28)
        Me.BCancelar.TabIndex = 20
        Me.BCancelar.Text = "Cancelar"
        '
        'FNombre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 153)
        Me.ControlBox = False
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.TCancelar)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.TAceptar)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.LMensaje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FNombre"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TNombre As TextBox
    Friend WithEvents LMensaje As BonfireLabel
    Friend WithEvents BAceptar As BonfireButton
    Friend WithEvents TAceptar As TextBox
    Friend WithEvents TCancelar As TextBox
    Friend WithEvents BCancelar As BonfireButton
End Class
