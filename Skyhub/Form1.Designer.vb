<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnEnviar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnLimpar = New System.Windows.Forms.ToolStripButton()
        Me.comboStatus = New System.Windows.Forms.ComboBox()
        Me.lblAtributos = New System.Windows.Forms.Label()
        Me.dgvAtributos = New System.Windows.Forms.DataGridView()
        Me.colAtributo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtImagem = New System.Windows.Forms.TextBox()
        Me.txtNbm = New System.Windows.Forms.TextBox()
        Me.txtComprimento = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtEan = New System.Windows.Forms.TextBox()
        Me.txtLargura = New System.Windows.Forms.TextBox()
        Me.txtCusto = New System.Windows.Forms.TextBox()
        Me.txtQtde = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.txtPrecoEspecial = New System.Windows.Forms.TextBox()
        Me.txtSku = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblPreco = New System.Windows.Forms.Label()
        Me.lblSku = New System.Windows.Forms.Label()
        Me.txtPreco2 = New System.Windows.Forms.TextBox()
        Me.txtSku2 = New System.Windows.Forms.TextBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnAtualiza = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.btnInativa = New System.Windows.Forms.ToolStripButton()
        Me.tabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvAtributos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.TabPage1)
        Me.tabControl.Controls.Add(Me.TabPage2)
        Me.tabControl.Controls.Add(Me.TabPage3)
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl.Location = New System.Drawing.Point(0, 0)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(800, 450)
        Me.tabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ToolStrip1)
        Me.TabPage1.Controls.Add(Me.comboStatus)
        Me.TabPage1.Controls.Add(Me.lblAtributos)
        Me.TabPage1.Controls.Add(Me.dgvAtributos)
        Me.TabPage1.Controls.Add(Me.txtImagem)
        Me.TabPage1.Controls.Add(Me.txtNbm)
        Me.TabPage1.Controls.Add(Me.txtComprimento)
        Me.TabPage1.Controls.Add(Me.txtPeso)
        Me.TabPage1.Controls.Add(Me.txtPreco)
        Me.TabPage1.Controls.Add(Me.txtDescricao)
        Me.TabPage1.Controls.Add(Me.txtEan)
        Me.TabPage1.Controls.Add(Me.txtLargura)
        Me.TabPage1.Controls.Add(Me.txtCusto)
        Me.TabPage1.Controls.Add(Me.txtQtde)
        Me.TabPage1.Controls.Add(Me.txtNome)
        Me.TabPage1.Controls.Add(Me.txtMarca)
        Me.TabPage1.Controls.Add(Me.txtAltura)
        Me.TabPage1.Controls.Add(Me.txtPrecoEspecial)
        Me.TabPage1.Controls.Add(Me.txtSku)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(792, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro Produto"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEnviar, Me.ToolStripSeparator1, Me.btnLimpar})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(786, 25)
        Me.ToolStrip1.TabIndex = 18
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnEnviar
        '
        Me.btnEnviar.Image = CType(resources.GetObject("btnEnviar.Image"), System.Drawing.Image)
        Me.btnEnviar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(59, 22)
        Me.btnEnviar.Text = "Enviar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnLimpar
        '
        Me.btnLimpar.Image = CType(resources.GetObject("btnLimpar.Image"), System.Drawing.Image)
        Me.btnLimpar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(64, 22)
        Me.btnLimpar.Text = "Limpar"
        '
        'comboStatus
        '
        Me.comboStatus.FormattingEnabled = True
        Me.comboStatus.Items.AddRange(New Object() {"Enabled", "Disabled"})
        Me.comboStatus.Location = New System.Drawing.Point(9, 67)
        Me.comboStatus.Name = "comboStatus"
        Me.comboStatus.Size = New System.Drawing.Size(164, 23)
        Me.comboStatus.TabIndex = 3
        Me.comboStatus.Text = "Status"
        '
        'lblAtributos
        '
        Me.lblAtributos.AutoSize = True
        Me.lblAtributos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtributos.Location = New System.Drawing.Point(241, 219)
        Me.lblAtributos.Name = "lblAtributos"
        Me.lblAtributos.Size = New System.Drawing.Size(63, 15)
        Me.lblAtributos.TabIndex = 17
        Me.lblAtributos.Text = "Atributos"
        '
        'dgvAtributos
        '
        Me.dgvAtributos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAtributos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colAtributo, Me.colValor})
        Me.dgvAtributos.Location = New System.Drawing.Point(244, 237)
        Me.dgvAtributos.Name = "dgvAtributos"
        Me.dgvAtributos.Size = New System.Drawing.Size(424, 179)
        Me.dgvAtributos.TabIndex = 16
        '
        'colAtributo
        '
        Me.colAtributo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colAtributo.HeaderText = "Atributo"
        Me.colAtributo.Name = "colAtributo"
        '
        'colValor
        '
        Me.colValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colValor.HeaderText = "Valor"
        Me.colValor.Name = "colValor"
        '
        'txtImagem
        '
        Me.txtImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImagem.Location = New System.Drawing.Point(7, 217)
        Me.txtImagem.Name = "txtImagem"
        Me.txtImagem.Size = New System.Drawing.Size(166, 21)
        Me.txtImagem.TabIndex = 15
        Me.txtImagem.Text = "Link Imagem"
        '
        'txtNbm
        '
        Me.txtNbm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNbm.Location = New System.Drawing.Point(502, 181)
        Me.txtNbm.Name = "txtNbm"
        Me.txtNbm.Size = New System.Drawing.Size(166, 21)
        Me.txtNbm.TabIndex = 14
        Me.txtNbm.Text = "NBM"
        '
        'txtComprimento
        '
        Me.txtComprimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComprimento.Location = New System.Drawing.Point(502, 140)
        Me.txtComprimento.Name = "txtComprimento"
        Me.txtComprimento.Size = New System.Drawing.Size(166, 21)
        Me.txtComprimento.TabIndex = 11
        Me.txtComprimento.Text = "Comprimento"
        '
        'txtPeso
        '
        Me.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPeso.Location = New System.Drawing.Point(502, 104)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(166, 21)
        Me.txtPeso.TabIndex = 8
        Me.txtPeso.Text = "Peso"
        '
        'txtPreco
        '
        Me.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPreco.Location = New System.Drawing.Point(502, 67)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(166, 21)
        Me.txtPreco.TabIndex = 5
        Me.txtPreco.Text = "Preço"
        '
        'txtDescricao
        '
        Me.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescricao.Location = New System.Drawing.Point(502, 31)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(166, 21)
        Me.txtDescricao.TabIndex = 2
        Me.txtDescricao.Text = "Descrição"
        '
        'txtEan
        '
        Me.txtEan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEan.Location = New System.Drawing.Point(244, 181)
        Me.txtEan.Name = "txtEan"
        Me.txtEan.Size = New System.Drawing.Size(166, 21)
        Me.txtEan.TabIndex = 13
        Me.txtEan.Text = "EAN"
        '
        'txtLargura
        '
        Me.txtLargura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLargura.Location = New System.Drawing.Point(244, 140)
        Me.txtLargura.Name = "txtLargura"
        Me.txtLargura.Size = New System.Drawing.Size(166, 21)
        Me.txtLargura.TabIndex = 10
        Me.txtLargura.Text = "Largura"
        '
        'txtCusto
        '
        Me.txtCusto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCusto.Location = New System.Drawing.Point(244, 104)
        Me.txtCusto.Name = "txtCusto"
        Me.txtCusto.Size = New System.Drawing.Size(166, 21)
        Me.txtCusto.TabIndex = 7
        Me.txtCusto.Text = "Custo"
        '
        'txtQtde
        '
        Me.txtQtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQtde.Location = New System.Drawing.Point(244, 67)
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.Size = New System.Drawing.Size(166, 21)
        Me.txtQtde.TabIndex = 4
        Me.txtQtde.Text = "Quantidade"
        '
        'txtNome
        '
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNome.Location = New System.Drawing.Point(244, 31)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(166, 21)
        Me.txtNome.TabIndex = 1
        Me.txtNome.Text = "Nome"
        '
        'txtMarca
        '
        Me.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMarca.Location = New System.Drawing.Point(7, 181)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(166, 21)
        Me.txtMarca.TabIndex = 12
        Me.txtMarca.Text = "Marca"
        '
        'txtAltura
        '
        Me.txtAltura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAltura.Location = New System.Drawing.Point(7, 140)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(166, 21)
        Me.txtAltura.TabIndex = 9
        Me.txtAltura.Text = "Altura"
        '
        'txtPrecoEspecial
        '
        Me.txtPrecoEspecial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecoEspecial.Location = New System.Drawing.Point(7, 104)
        Me.txtPrecoEspecial.Name = "txtPrecoEspecial"
        Me.txtPrecoEspecial.Size = New System.Drawing.Size(166, 21)
        Me.txtPrecoEspecial.TabIndex = 6
        Me.txtPrecoEspecial.Text = "Preço Especial"
        '
        'txtSku
        '
        Me.txtSku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSku.Location = New System.Drawing.Point(7, 31)
        Me.txtSku.Name = "txtSku"
        Me.txtSku.Size = New System.Drawing.Size(166, 21)
        Me.txtSku.TabIndex = 0
        Me.txtSku.Text = "SKU"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblPreco)
        Me.TabPage2.Controls.Add(Me.lblSku)
        Me.TabPage2.Controls.Add(Me.txtPreco2)
        Me.TabPage2.Controls.Add(Me.txtSku2)
        Me.TabPage2.Controls.Add(Me.ToolStrip2)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(792, 424)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Atualiza Preço"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblPreco
        '
        Me.lblPreco.AutoSize = True
        Me.lblPreco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreco.Location = New System.Drawing.Point(226, 49)
        Me.lblPreco.Name = "lblPreco"
        Me.lblPreco.Size = New System.Drawing.Size(49, 16)
        Me.lblPreco.TabIndex = 23
        Me.lblPreco.Text = "Preço"
        '
        'lblSku
        '
        Me.lblSku.AutoSize = True
        Me.lblSku.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSku.Location = New System.Drawing.Point(8, 49)
        Me.lblSku.Name = "lblSku"
        Me.lblSku.Size = New System.Drawing.Size(38, 16)
        Me.lblSku.TabIndex = 22
        Me.lblSku.Text = "SKU"
        '
        'txtPreco2
        '
        Me.txtPreco2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPreco2.Location = New System.Drawing.Point(229, 67)
        Me.txtPreco2.Name = "txtPreco2"
        Me.txtPreco2.Size = New System.Drawing.Size(166, 21)
        Me.txtPreco2.TabIndex = 21
        '
        'txtSku2
        '
        Me.txtSku2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSku2.Location = New System.Drawing.Point(8, 67)
        Me.txtSku2.Name = "txtSku2"
        Me.txtSku2.Size = New System.Drawing.Size(166, 21)
        Me.txtSku2.TabIndex = 20
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAtualiza, Me.ToolStripSeparator2, Me.ToolStripButton2})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(786, 25)
        Me.ToolStrip2.TabIndex = 19
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnAtualiza
        '
        Me.btnAtualiza.Image = CType(resources.GetObject("btnAtualiza.Image"), System.Drawing.Image)
        Me.btnAtualiza.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAtualiza.Name = "btnAtualiza"
        Me.btnAtualiza.Size = New System.Drawing.Size(69, 22)
        Me.btnAtualiza.Text = "Atualiza"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(64, 22)
        Me.ToolStripButton2.Text = "Limpar"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ToolStrip3)
        Me.TabPage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(792, 424)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Inativa Produtos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnInativa})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(786, 25)
        Me.ToolStrip3.TabIndex = 0
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'btnInativa
        '
        Me.btnInativa.Image = CType(resources.GetObject("btnInativa.Image"), System.Drawing.Image)
        Me.btnInativa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInativa.Name = "btnInativa"
        Me.btnInativa.Size = New System.Drawing.Size(117, 22)
        Me.btnInativa.Text = "Inativa Final 1 e 3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tabControl)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.tabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvAtributos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtNbm As TextBox
    Friend WithEvents txtComprimento As TextBox
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents txtPreco As TextBox
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents txtEan As TextBox
    Friend WithEvents txtLargura As TextBox
    Friend WithEvents txtCusto As TextBox
    Friend WithEvents txtQtde As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents txtPrecoEspecial As TextBox
    Friend WithEvents txtSku As TextBox
    Friend WithEvents txtImagem As TextBox
    Friend WithEvents dgvAtributos As DataGridView
    Friend WithEvents lblAtributos As Label
    Friend WithEvents colAtributo As DataGridViewTextBoxColumn
    Friend WithEvents colValor As DataGridViewTextBoxColumn
    Friend WithEvents comboStatus As ComboBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnEnviar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnLimpar As ToolStripButton
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents btnAtualiza As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents txtPreco2 As TextBox
    Friend WithEvents txtSku2 As TextBox
    Friend WithEvents lblPreco As Label
    Friend WithEvents lblSku As Label
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents btnInativa As ToolStripButton
End Class
