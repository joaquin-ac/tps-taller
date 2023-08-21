Public Class Form1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Form1_keyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown


        If (e.KeyCode = Keys.S AndAlso e.Modifiers = Keys.Control) Then
            e.Handled = True
            Button2_Click(sender, e) 'or cmdExit.PerformClick()'
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles LNombre.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles LApellido.TextChanged

    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        TResult.Text = LApellido.Text + " " + LNombre.Text
    End Sub

    Private Sub TResult_TextChanged(sender As Object, e As EventArgs) Handles TResult.TextChanged

    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        TResult.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BSalir.Click


        End
    End Sub
End Class
