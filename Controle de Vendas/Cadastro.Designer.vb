<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.senha = New System.Windows.Forms.TextBox()
        Me.usuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.confirmarSenha = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nome = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(325, 345)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "cadastrar novo vendedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(291, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 29)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Cadastrar Vendedor"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(314, 392)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 40)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Cadastrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(270, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Senha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(270, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Usuário:"
        '
        'senha
        '
        Me.senha.Location = New System.Drawing.Point(274, 244)
        Me.senha.Name = "senha"
        Me.senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.senha.Size = New System.Drawing.Size(246, 20)
        Me.senha.TabIndex = 8
        '
        'usuario
        '
        Me.usuario.Location = New System.Drawing.Point(274, 175)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(246, 20)
        Me.usuario.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(270, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 24)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Repita a senha:"
        '
        'confirmarSenha
        '
        Me.confirmarSenha.Location = New System.Drawing.Point(274, 315)
        Me.confirmarSenha.Name = "confirmarSenha"
        Me.confirmarSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmarSenha.Size = New System.Drawing.Size(246, 20)
        Me.confirmarSenha.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(270, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 24)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Nome:"
        '
        'nome
        '
        Me.nome.Location = New System.Drawing.Point(274, 107)
        Me.nome.Name = "nome"
        Me.nome.Size = New System.Drawing.Size(246, 20)
        Me.nome.TabIndex = 16
        '
        'Cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nome)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.confirmarSenha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.senha)
        Me.Controls.Add(Me.usuario)
        Me.Name = "Cadastro"
        Me.Text = "Cadastro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents senha As TextBox
    Friend WithEvents usuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents confirmarSenha As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents nome As TextBox
End Class
