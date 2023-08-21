<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Bguardar = New Button()
        Beliminar = New Button()
        Tnombre = New TextBox()
        Tapellido = New TextBox()
        Tdni = New TextBox()
        Lmodificar = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Bguardar
        ' 
        Bguardar.Location = New Point(31, 283)
        Bguardar.Name = "Bguardar"
        Bguardar.Size = New Size(75, 23)
        Bguardar.TabIndex = 8
        Bguardar.Text = "Guardar"
        Bguardar.UseVisualStyleBackColor = True
        ' 
        ' Beliminar
        ' 
        Beliminar.Location = New Point(168, 283)
        Beliminar.Name = "Beliminar"
        Beliminar.Size = New Size(75, 23)
        Beliminar.TabIndex = 9
        Beliminar.Text = "Eliminar"
        Beliminar.UseVisualStyleBackColor = True
        ' 
        ' Tnombre
        ' 
        Tnombre.Location = New Point(168, 215)
        Tnombre.Name = "Tnombre"
        Tnombre.Size = New Size(100, 23)
        Tnombre.TabIndex = 22
        ' 
        ' Tapellido
        ' 
        Tapellido.Location = New Point(168, 151)
        Tapellido.Name = "Tapellido"
        Tapellido.Size = New Size(100, 23)
        Tapellido.TabIndex = 21
        ' 
        ' Tdni
        ' 
        Tdni.Location = New Point(168, 89)
        Tdni.Name = "Tdni"
        Tdni.Size = New Size(100, 23)
        Tdni.TabIndex = 20
        ' 
        ' Lmodificar
        ' 
        Lmodificar.AutoSize = True
        Lmodificar.ForeColor = Color.Red
        Lmodificar.Location = New Point(185, 38)
        Lmodificar.Name = "Lmodificar"
        Lmodificar.Size = New Size(58, 15)
        Lmodificar.TabIndex = 19
        Lmodificar.Text = "modificar"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(31, 218)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 18
        Label4.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(31, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 17
        Label3.Text = "Apellido"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(27, 15)
        Label2.TabIndex = 16
        Label2.Text = "DNI"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 15)
        Label1.TabIndex = 15
        Label1.Text = "Nombre y Apellido:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(319, 368)
        Controls.Add(Tnombre)
        Controls.Add(Tapellido)
        Controls.Add(Tdni)
        Controls.Add(Lmodificar)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Bguardar)
        Controls.Add(Beliminar)
        Name = "Form1"
        Text = "Pequeño Formulario"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Bguardar As Button
    Friend WithEvents Beliminar As Button
    Friend WithEvents Tnombre As TextBox
    Friend WithEvents Tapellido As TextBox
    Friend WithEvents Tdni As TextBox
    Friend WithEvents Lmodificar As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
