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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Lmodificar = New Label()
        Tdni = New TextBox()
        Tapellido = New TextBox()
        Tnombre = New TextBox()
        Bguardar = New Button()
        Beliminar = New Button()
        Panel1 = New Panel()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        Label6 = New Label()
        Ttelefono = New TextBox()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        RBvaron = New RadioButton()
        RBmujer = New RadioButton()
        Bsalir = New Button()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        Label7 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nombre y Apellido:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 15)
        Label2.TabIndex = 1
        Label2.Text = "* DNI"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 15)
        Label3.TabIndex = 2
        Label3.Text = "* Apellido"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 195)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 15)
        Label4.TabIndex = 3
        Label4.Text = "* Nombre"
        ' 
        ' Lmodificar
        ' 
        Lmodificar.AutoSize = True
        Lmodificar.ForeColor = Color.Red
        Lmodificar.Location = New Point(191, 15)
        Lmodificar.Name = "Lmodificar"
        Lmodificar.Size = New Size(58, 15)
        Lmodificar.TabIndex = 4
        Lmodificar.Text = "modificar"
        ' 
        ' Tdni
        ' 
        Tdni.Location = New Point(149, 66)
        Tdni.Name = "Tdni"
        Tdni.Size = New Size(100, 23)
        Tdni.TabIndex = 5
        ' 
        ' Tapellido
        ' 
        Tapellido.Location = New Point(149, 128)
        Tapellido.Name = "Tapellido"
        Tapellido.Size = New Size(100, 23)
        Tapellido.TabIndex = 6
        ' 
        ' Tnombre
        ' 
        Tnombre.Location = New Point(149, 192)
        Tnombre.Name = "Tnombre"
        Tnombre.Size = New Size(100, 23)
        Tnombre.TabIndex = 7
        ' 
        ' Bguardar
        ' 
        Bguardar.Image = CType(resources.GetObject("Bguardar.Image"), Image)
        Bguardar.ImageAlign = ContentAlignment.MiddleLeft
        Bguardar.Location = New Point(37, 512)
        Bguardar.Name = "Bguardar"
        Bguardar.Size = New Size(98, 49)
        Bguardar.TabIndex = 8
        Bguardar.Text = "Guardar"
        Bguardar.TextAlign = ContentAlignment.MiddleRight
        Bguardar.UseVisualStyleBackColor = True
        ' 
        ' Beliminar
        ' 
        Beliminar.Image = CType(resources.GetObject("Beliminar.Image"), Image)
        Beliminar.ImageAlign = ContentAlignment.MiddleLeft
        Beliminar.Location = New Point(174, 512)
        Beliminar.Name = "Beliminar"
        Beliminar.Size = New Size(100, 49)
        Beliminar.TabIndex = 9
        Beliminar.Text = "Eliminar"
        Beliminar.TextAlign = ContentAlignment.MiddleRight
        Beliminar.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.AppWorkspace
        Panel1.Controls.Add(CheckBox3)
        Panel1.Controls.Add(CheckBox2)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Ttelefono)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Tnombre)
        Panel1.Controls.Add(Tapellido)
        Panel1.Controls.Add(Tdni)
        Panel1.Controls.Add(Lmodificar)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(25, 80)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(287, 418)
        Panel1.TabIndex = 10
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(149, 370)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(85, 19)
        CheckBox3.TabIndex = 15
        CheckBox3.Text = "Mastercard"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(149, 345)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(47, 19)
        CheckBox2.TabIndex = 14
        CheckBox2.Text = "Visa"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(149, 320)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(67, 19)
        CheckBox1.TabIndex = 13
        CheckBox1.Text = "Naranja"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(19, 320)
        Label6.Name = "Label6"
        Label6.Size = New Size(105, 15)
        Label6.TabIndex = 12
        Label6.Text = "Tarjeta de creditos:"
        ' 
        ' Ttelefono
        ' 
        Ttelefono.Location = New Point(149, 253)
        Ttelefono.Name = "Ttelefono"
        Ttelefono.Size = New Size(100, 23)
        Ttelefono.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(19, 256)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 15)
        Label5.TabIndex = 10
        Label5.Text = "Telefono"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.ErrorImage = Nothing
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(341, 95)
        PictureBox1.MaximumSize = New Size(128, 128)
        PictureBox1.MinimumSize = New Size(128, 128)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(128, 128)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' RBvaron
        ' 
        RBvaron.AutoSize = True
        RBvaron.Checked = True
        RBvaron.Location = New Point(341, 266)
        RBvaron.Name = "RBvaron"
        RBvaron.Size = New Size(55, 19)
        RBvaron.TabIndex = 12
        RBvaron.TabStop = True
        RBvaron.Text = "Varon"
        RBvaron.UseVisualStyleBackColor = True
        ' 
        ' RBmujer
        ' 
        RBmujer.AutoSize = True
        RBmujer.Location = New Point(416, 266)
        RBmujer.Name = "RBmujer"
        RBmujer.Size = New Size(56, 19)
        RBmujer.TabIndex = 13
        RBmujer.Text = "Mujer"
        RBmujer.UseVisualStyleBackColor = True
        ' 
        ' Bsalir
        ' 
        Bsalir.Image = CType(resources.GetObject("Bsalir.Image"), Image)
        Bsalir.ImageAlign = ContentAlignment.MiddleLeft
        Bsalir.Location = New Point(369, 512)
        Bsalir.Name = "Bsalir"
        Bsalir.Size = New Size(81, 49)
        Bsalir.TabIndex = 14
        Bsalir.Text = "Salir"
        Bsalir.TextAlign = ContentAlignment.MiddleRight
        Bsalir.UseVisualStyleBackColor = True
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.Highlight
        Label7.Location = New Point(110, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(253, 47)
        Label7.TabIndex = 15
        Label7.Text = "Nuevo Cliente"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(491, 580)
        Controls.Add(Label7)
        Controls.Add(Bsalir)
        Controls.Add(RBmujer)
        Controls.Add(RBvaron)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(Bguardar)
        Controls.Add(Beliminar)
        Name = "Form1"
        Text = "Pequeño Formulario"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Lmodificar As Label
    Friend WithEvents Tdni As TextBox
    Friend WithEvents Tapellido As TextBox
    Friend WithEvents Tnombre As TextBox
    Friend WithEvents Bguardar As Button
    Friend WithEvents Beliminar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Ttelefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RBvaron As RadioButton
    Friend WithEvents RBmujer As RadioButton
    Friend WithEvents Bsalir As Button
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Label7 As Label
End Class
