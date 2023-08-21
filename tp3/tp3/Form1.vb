Imports System.IO

Public Class Form1


    'Funcion para que solo permite el ingreso de caracteres tipo letra
    Sub SoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Error")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    'Funcion para que solo permite el ingreso de caracteres tipo numerico
    Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub



    Private Sub Bguardar_Click(sender As Object, e As EventArgs) Handles Bguardar.Click

        Lmodificar.Text = Tnombre.Text + " " + Tapellido.Text
        Dim ask As MsgBoxResult


        If (Tdni.Text Is "" OrElse Tnombre.Text Is "" OrElse Tapellido.Text Is "" OrElse Not (Ttelefono.Text.Length = 10)) Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Error")
        Else
            ask = MsgBox("¿Seguro desea insertar un nuevo cliente?", vbYesNo + vbQuestion, "confirmar insersion")

            If ask = vbYes Then
                MsgBox("El cliente: " + Lmodificar.Text + " se inserto correctamente", MsgBoxStyle.Information, "Guardar")
            End If
        End If






    End Sub

    Private Sub Beliminar_Click(sender As Object, e As EventArgs) Handles Beliminar.Click

        Dim ask As MsgBoxResult
        ask = MsgBox("Está apunto de eliminar el cliente: " + Tnombre.Text + " " + Tapellido.Text, vbYesNo + vbExclamation + vbDefaultButton2, "confirmar eliminacion")

        If ask = vbYes Then
            MsgBox("El cliente: " + Tnombre.Text + " " + Tapellido.Text + " se elimino correctamente", MsgBoxStyle.Information, "Eliminar")
            Lmodificar.Text = "modificar"
            Tnombre.Clear()
            Tapellido.Clear()
            Tdni.Clear()
        End If
    End Sub



    Private Sub Tapellido_TextChanged(sender As Object, e As KeyPressEventArgs) Handles Tapellido.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub Tnombre_TextChanged(sender As Object, e As KeyPressEventArgs) Handles Tnombre.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub Tdni_TextChanged(sender As Object, e As KeyPressEventArgs) Handles Tdni.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub Bsalir_Click(sender As Object, e As EventArgs) Handles Bsalir.Click
        Me.Close()
    End Sub

    Private Sub RBvaron_CheckedChanged(sender As Object, e As EventArgs) Handles RBvaron.CheckedChanged

        PictureBox1.Image = Image.FromFile("E:\Users\Usuario\source\repos\tp3\imagenes\hombre.png")

    End Sub

    Private Sub RBmujer_CheckedChanged(sender As Object, e As EventArgs) Handles RBmujer.CheckedChanged

        PictureBox1.Image = Image.FromFile("E:\Users\Usuario\source\repos\tp3\imagenes\mujer.png")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Ttelefono_TextChanged(sender As Object, e As KeyPressEventArgs) Handles Ttelefono.KeyPress
        SoloNumeros(e)
    End Sub
End Class
