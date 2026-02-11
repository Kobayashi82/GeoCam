
Public Class FNombre

    Public Cancelado As Boolean = True

    Private Sub BAceptar_Click(sender As Object, e As MouseEventArgs) Handles BAceptar.Click
        If e IsNot Nothing AndAlso e.Button <> MouseButtons.Left Then Exit Sub
        If TNombre.Text.Trim = "" Then Exit Sub
        Cancelado = False : Close()
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As MouseEventArgs) Handles BCancelar.Click
        If e.Button <> MouseButtons.Left Then Exit Sub
        Close()
    End Sub

    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        If Asc(e.KeyChar) = 13 Then e.Handled = True : BAceptar_Click(sender, Nothing)
        If Asc(e.KeyChar) = 27 Then e.Handled = True
    End Sub

    Private Sub FNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 27 Then Close()
    End Sub

End Class