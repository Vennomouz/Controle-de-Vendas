<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.usuario = New System.Windows.Forms.TextBox()
        Me.senha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'usuario
        '
        Me.usuario.Location = New System.Drawing.Point(285, 141)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(246, 20)
        Me.usuario.TabIndex = 0
        '
        'senha
        '
        Me.senha.Location = New System.Drawing.Point(285, 210)
        Me.senha.Name = "senha"
        Me.senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.senha.Size = New System.Drawing.Size(246, 20)
        Me.senha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(281, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuário:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(281, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Senha:"
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.Crimson
        Me.btnEntrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrar.ForeColor = System.Drawing.Color.White
        Me.btnEntrar.Location = New System.Drawing.Point(325, 293)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(167, 40)
        Me.btnEntrar.TabIndex = 4
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(243, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(334, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Painel de Controle de Vendas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(336, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "cadastrar novo vendedor"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 389)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.senha)
        Me.Controls.Add(Me.usuario)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents usuario As TextBox
    Friend WithEvents senha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEntrar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
