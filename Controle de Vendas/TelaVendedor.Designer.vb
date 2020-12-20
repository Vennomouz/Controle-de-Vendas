<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TelaVendedor
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabPage = New System.Windows.Forms.TabControl()
        Me.Cliente = New System.Windows.Forms.TabPage()
        Me.gravarGridCli = New System.Windows.Forms.Button()
        Me.gridClientes = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.telCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nomeCliente = New System.Windows.Forms.TextBox()
        Me.Produto = New System.Windows.Forms.TabPage()
        Me.gravarGridProd = New System.Windows.Forms.Button()
        Me.gridProdutos = New System.Windows.Forms.DataGridView()
        Me.tipoProduto = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.marcaProduto = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nomeProduto = New System.Windows.Forms.TextBox()
        Me.Pedidos = New System.Windows.Forms.TabPage()
        Me.tipoProd = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.marcaProd = New System.Windows.Forms.TextBox()
        Me.nomeProd = New System.Windows.Forms.TextBox()
        Me.idProd = New System.Windows.Forms.TextBox()
        Me.gravarGridPed = New System.Windows.Forms.Button()
        Me.gridPedidos = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.telCli = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nomeCli = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idCli = New System.Windows.Forms.TextBox()
        Me.TabPage.SuspendLayout()
        Me.Cliente.SuspendLayout()
        CType(Me.gridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Produto.SuspendLayout()
        CType(Me.gridProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pedidos.SuspendLayout()
        CType(Me.gridPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPage
        '
        Me.TabPage.Controls.Add(Me.Cliente)
        Me.TabPage.Controls.Add(Me.Produto)
        Me.TabPage.Controls.Add(Me.Pedidos)
        Me.TabPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPage.Location = New System.Drawing.Point(0, 0)
        Me.TabPage.Name = "TabPage"
        Me.TabPage.SelectedIndex = 0
        Me.TabPage.Size = New System.Drawing.Size(800, 450)
        Me.TabPage.TabIndex = 0
        '
        'Cliente
        '
        Me.Cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cliente.Controls.Add(Me.gravarGridCli)
        Me.Cliente.Controls.Add(Me.gridClientes)
        Me.Cliente.Controls.Add(Me.Label6)
        Me.Cliente.Controls.Add(Me.telCliente)
        Me.Cliente.Controls.Add(Me.Label5)
        Me.Cliente.Controls.Add(Me.nomeCliente)
        Me.Cliente.Location = New System.Drawing.Point(4, 22)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Padding = New System.Windows.Forms.Padding(3)
        Me.Cliente.Size = New System.Drawing.Size(792, 424)
        Me.Cliente.TabIndex = 0
        Me.Cliente.Text = "Cliente"
        Me.Cliente.UseVisualStyleBackColor = True
        '
        'gravarGridCli
        '
        Me.gravarGridCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gravarGridCli.Location = New System.Drawing.Point(644, 108)
        Me.gravarGridCli.Name = "gravarGridCli"
        Me.gravarGridCli.Size = New System.Drawing.Size(123, 48)
        Me.gravarGridCli.TabIndex = 568
        Me.gravarGridCli.Text = "GRAVAR"
        Me.gravarGridCli.UseVisualStyleBackColor = True
        '
        'gridClientes
        '
        Me.gridClientes.AllowUserToAddRows = False
        Me.gridClientes.AllowUserToDeleteRows = False
        Me.gridClientes.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridClientes.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.gridClientes.Location = New System.Drawing.Point(52, 108)
        Me.gridClientes.Name = "gridClientes"
        Me.gridClientes.ReadOnly = True
        Me.gridClientes.RowHeadersVisible = False
        Me.gridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridClientes.Size = New System.Drawing.Size(554, 217)
        Me.gridClientes.TabIndex = 566
        Me.gridClientes.Tag = "x"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(253, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tel / Cel:"
        '
        'telCliente
        '
        Me.telCliente.Location = New System.Drawing.Point(257, 49)
        Me.telCliente.Name = "telCliente"
        Me.telCliente.Size = New System.Drawing.Size(131, 20)
        Me.telCliente.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Nome do cliente:"
        '
        'nomeCliente
        '
        Me.nomeCliente.Location = New System.Drawing.Point(52, 49)
        Me.nomeCliente.Name = "nomeCliente"
        Me.nomeCliente.Size = New System.Drawing.Size(131, 20)
        Me.nomeCliente.TabIndex = 2
        '
        'Produto
        '
        Me.Produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Produto.Controls.Add(Me.gravarGridProd)
        Me.Produto.Controls.Add(Me.gridProdutos)
        Me.Produto.Controls.Add(Me.tipoProduto)
        Me.Produto.Controls.Add(Me.Label9)
        Me.Produto.Controls.Add(Me.marcaProduto)
        Me.Produto.Controls.Add(Me.Label7)
        Me.Produto.Controls.Add(Me.Label8)
        Me.Produto.Controls.Add(Me.nomeProduto)
        Me.Produto.Location = New System.Drawing.Point(4, 22)
        Me.Produto.Name = "Produto"
        Me.Produto.Padding = New System.Windows.Forms.Padding(3)
        Me.Produto.Size = New System.Drawing.Size(792, 424)
        Me.Produto.TabIndex = 1
        Me.Produto.Text = "Produtos"
        Me.Produto.UseVisualStyleBackColor = True
        '
        'gravarGridProd
        '
        Me.gravarGridProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gravarGridProd.Location = New System.Drawing.Point(641, 115)
        Me.gravarGridProd.Name = "gravarGridProd"
        Me.gravarGridProd.Size = New System.Drawing.Size(123, 48)
        Me.gravarGridProd.TabIndex = 567
        Me.gravarGridProd.Text = "GRAVAR"
        Me.gravarGridProd.UseVisualStyleBackColor = True
        '
        'gridProdutos
        '
        Me.gridProdutos.AllowUserToAddRows = False
        Me.gridProdutos.AllowUserToDeleteRows = False
        Me.gridProdutos.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridProdutos.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.gridProdutos.Location = New System.Drawing.Point(52, 115)
        Me.gridProdutos.Name = "gridProdutos"
        Me.gridProdutos.ReadOnly = True
        Me.gridProdutos.RowHeadersVisible = False
        Me.gridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridProdutos.Size = New System.Drawing.Size(554, 217)
        Me.gridProdutos.TabIndex = 566
        Me.gridProdutos.Tag = "x"
        '
        'tipoProduto
        '
        Me.tipoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tipoProduto.FormattingEnabled = True
        Me.tipoProduto.Items.AddRange(New Object() {"Camisa", "Calça", "Shorts", "Tenis"})
        Me.tipoProduto.Location = New System.Drawing.Point(479, 56)
        Me.tipoProduto.Name = "tipoProduto"
        Me.tipoProduto.Size = New System.Drawing.Size(127, 21)
        Me.tipoProduto.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(475, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Tipo:"
        '
        'marcaProduto
        '
        Me.marcaProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.marcaProduto.FormattingEnabled = True
        Me.marcaProduto.Items.AddRange(New Object() {"Nike", "Adidas", "DC", "Vans", "Hurley", "Puma"})
        Me.marcaProduto.Location = New System.Drawing.Point(267, 56)
        Me.marcaProduto.Name = "marcaProduto"
        Me.marcaProduto.Size = New System.Drawing.Size(127, 21)
        Me.marcaProduto.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(263, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Marca:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(48, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Nome do produto"
        '
        'nomeProduto
        '
        Me.nomeProduto.Location = New System.Drawing.Point(52, 56)
        Me.nomeProduto.Name = "nomeProduto"
        Me.nomeProduto.Size = New System.Drawing.Size(131, 20)
        Me.nomeProduto.TabIndex = 6
        '
        'Pedidos
        '
        Me.Pedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pedidos.Controls.Add(Me.tipoProd)
        Me.Pedidos.Controls.Add(Me.Label12)
        Me.Pedidos.Controls.Add(Me.marcaProd)
        Me.Pedidos.Controls.Add(Me.nomeProd)
        Me.Pedidos.Controls.Add(Me.idProd)
        Me.Pedidos.Controls.Add(Me.gravarGridPed)
        Me.Pedidos.Controls.Add(Me.gridPedidos)
        Me.Pedidos.Controls.Add(Me.Label10)
        Me.Pedidos.Controls.Add(Me.Label11)
        Me.Pedidos.Controls.Add(Me.telCli)
        Me.Pedidos.Controls.Add(Me.Label3)
        Me.Pedidos.Controls.Add(Me.Label4)
        Me.Pedidos.Controls.Add(Me.nomeCli)
        Me.Pedidos.Controls.Add(Me.Label2)
        Me.Pedidos.Controls.Add(Me.Label1)
        Me.Pedidos.Controls.Add(Me.idCli)
        Me.Pedidos.Location = New System.Drawing.Point(4, 22)
        Me.Pedidos.Name = "Pedidos"
        Me.Pedidos.Padding = New System.Windows.Forms.Padding(3)
        Me.Pedidos.Size = New System.Drawing.Size(792, 424)
        Me.Pedidos.TabIndex = 2
        Me.Pedidos.Text = "Pedidos"
        Me.Pedidos.UseVisualStyleBackColor = True
        '
        'tipoProd
        '
        Me.tipoProd.Location = New System.Drawing.Point(501, 116)
        Me.tipoProd.Name = "tipoProd"
        Me.tipoProd.ReadOnly = True
        Me.tipoProd.Size = New System.Drawing.Size(131, 20)
        Me.tipoProd.TabIndex = 573
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(497, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 20)
        Me.Label12.TabIndex = 572
        Me.Label12.Text = "Tipo:"
        '
        'marcaProd
        '
        Me.marcaProd.Location = New System.Drawing.Point(360, 116)
        Me.marcaProd.Name = "marcaProd"
        Me.marcaProd.ReadOnly = True
        Me.marcaProd.Size = New System.Drawing.Size(131, 20)
        Me.marcaProd.TabIndex = 571
        '
        'nomeProd
        '
        Me.nomeProd.Location = New System.Drawing.Point(211, 116)
        Me.nomeProd.Name = "nomeProd"
        Me.nomeProd.ReadOnly = True
        Me.nomeProd.Size = New System.Drawing.Size(131, 20)
        Me.nomeProd.TabIndex = 570
        '
        'idProd
        '
        Me.idProd.Location = New System.Drawing.Point(65, 116)
        Me.idProd.Name = "idProd"
        Me.idProd.Size = New System.Drawing.Size(131, 20)
        Me.idProd.TabIndex = 569
        '
        'gravarGridPed
        '
        Me.gravarGridPed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gravarGridPed.Location = New System.Drawing.Point(651, 166)
        Me.gravarGridPed.Name = "gravarGridPed"
        Me.gravarGridPed.Size = New System.Drawing.Size(123, 48)
        Me.gravarGridPed.TabIndex = 568
        Me.gravarGridPed.Text = "GRAVAR"
        Me.gravarGridPed.UseVisualStyleBackColor = True
        '
        'gridPedidos
        '
        Me.gridPedidos.AllowUserToAddRows = False
        Me.gridPedidos.AllowUserToDeleteRows = False
        Me.gridPedidos.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.gridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridPedidos.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.gridPedidos.Location = New System.Drawing.Point(65, 166)
        Me.gridPedidos.Name = "gridPedidos"
        Me.gridPedidos.ReadOnly = True
        Me.gridPedidos.RowHeadersVisible = False
        Me.gridPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridPedidos.Size = New System.Drawing.Size(567, 217)
        Me.gridPedidos.TabIndex = 565
        Me.gridPedidos.Tag = "x"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(356, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 20)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Marca:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(356, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 20)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Tel / Cel :"
        '
        'telCli
        '
        Me.telCli.Location = New System.Drawing.Point(360, 50)
        Me.telCli.Name = "telCli"
        Me.telCli.ReadOnly = True
        Me.telCli.Size = New System.Drawing.Size(131, 20)
        Me.telCli.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(207, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nome do produto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(207, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nome do cliente:"
        '
        'nomeCli
        '
        Me.nomeCli.Location = New System.Drawing.Point(211, 50)
        Me.nomeCli.Name = "nomeCli"
        Me.nomeCli.ReadOnly = True
        Me.nomeCli.Size = New System.Drawing.Size(131, 20)
        Me.nomeCli.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Id do produto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id do cliente:"
        '
        'idCli
        '
        Me.idCli.Location = New System.Drawing.Point(65, 50)
        Me.idCli.Name = "idCli"
        Me.idCli.Size = New System.Drawing.Size(131, 20)
        Me.idCli.TabIndex = 0
        '
        'TelaVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabPage)
        Me.Name = "TelaVendedor"
        Me.TabPage.ResumeLayout(False)
        Me.Cliente.ResumeLayout(False)
        Me.Cliente.PerformLayout()
        CType(Me.gridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Produto.ResumeLayout(False)
        Me.Produto.PerformLayout()
        CType(Me.gridProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pedidos.ResumeLayout(False)
        Me.Pedidos.PerformLayout()
        CType(Me.gridPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage As TabControl
    Friend WithEvents Cliente As TabPage
    Friend WithEvents Produto As TabPage
    Friend WithEvents Pedidos As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nomeCli As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents idCli As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents telCliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nomeCliente As TextBox
    Friend WithEvents tipoProduto As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents marcaProduto As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents nomeProduto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents telCli As TextBox
    Friend WithEvents gridPedidos As DataGridView
    Friend WithEvents gridClientes As DataGridView
    Friend WithEvents gridProdutos As DataGridView
    Friend WithEvents gravarGridCli As Button
    Friend WithEvents gravarGridProd As Button
    Friend WithEvents gravarGridPed As Button
    Friend WithEvents tipoProd As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents marcaProd As TextBox
    Friend WithEvents nomeProd As TextBox
    Friend WithEvents idProd As TextBox
End Class
