Imports RestSharp
Imports Newtonsoft.Json

Public Class Form1

#Region "fieldEvents"
    Private Sub txtSku_Enter(sender As Object, e As EventArgs) Handles txtSku.Enter
        If txtSku.Text = "SKU" Then
            txtSku.Text = ""
        End If
    End Sub

    Private Sub txtSku_Leave(sender As Object, e As EventArgs) Handles txtSku.Leave
        If txtSku.Text = "" Then
            txtSku.Text = "SKU"
        End If
    End Sub

    Private Sub txtNome_Enter(sender As Object, e As EventArgs) Handles txtNome.Enter
        If txtNome.Text = "Nome" Then
            txtNome.Text = ""
        End If
    End Sub

    Private Sub txtNome_Leave(sender As Object, e As EventArgs) Handles txtNome.Leave
        If txtNome.Text = "" Then
            txtNome.Text = "Nome"
        End If
    End Sub

    Private Sub txtDescricao_Enter(sender As Object, e As EventArgs) Handles txtDescricao.Enter
        If txtDescricao.Text = "Descrição" Then
            txtDescricao.Text = ""
        End If
    End Sub

    Private Sub txtDescricao_Leave(sender As Object, e As EventArgs) Handles txtDescricao.Leave
        If txtDescricao.Text = "" Then
            txtDescricao.Text = "Descrição"
        End If
    End Sub

    Private Sub txtStatus_Enter(sender As Object, e As EventArgs) Handles comboStatus.Enter
        If comboStatus.Text = "Status" Then
            comboStatus.Text = ""
        End If
    End Sub

    Private Sub txtStatus_Leave(sender As Object, e As EventArgs) Handles comboStatus.Leave
        If comboStatus.Text = "" Then
            comboStatus.Text = "Status"
        End If
    End Sub

    Private Sub txtQtde_Enter(sender As Object, e As EventArgs) Handles txtQtde.Enter
        If txtQtde.Text = "Quantidade" Then
            txtQtde.Text = ""
        End If
    End Sub

    Private Sub txtQtde_Leave(sender As Object, e As EventArgs) Handles txtQtde.Leave
        If txtQtde.Text = "" Then
            txtQtde.Text = "Quantidade"
        End If
    End Sub

    Private Sub txtPreco_Enter(sender As Object, e As EventArgs) Handles txtPreco.Enter
        If txtPreco.Text = "Preço" Then
            txtPreco.Text = ""
        End If
    End Sub

    Private Sub txtPreco_Leave(sender As Object, e As EventArgs) Handles txtPreco.Leave
        If txtPreco.Text = "" Then
            txtPreco.Text = "Preço"
        End If
    End Sub

    Private Sub txtPrecoEspecial_Enter(sender As Object, e As EventArgs) Handles txtPrecoEspecial.Enter
        If txtPrecoEspecial.Text = "Preço Especial" Then
            txtPrecoEspecial.Text = ""
        End If
    End Sub

    Private Sub txtPrecoEspecial_Leave(sender As Object, e As EventArgs) Handles txtPrecoEspecial.Leave
        If txtPrecoEspecial.Text = "" Then
            txtPrecoEspecial.Text = "Preço Especial"
        End If
    End Sub

    Private Sub txtCusto_Enter(sender As Object, e As EventArgs) Handles txtCusto.Enter
        If txtCusto.Text = "Custo" Then
            txtCusto.Text = ""
        End If
    End Sub

    Private Sub txtCusto_Leave(sender As Object, e As EventArgs) Handles txtCusto.Leave
        If txtCusto.Text = "" Then
            txtCusto.Text = "Custo"
        End If
    End Sub

    Private Sub txtPeso_Enter(sender As Object, e As EventArgs) Handles txtPeso.Enter
        If txtPeso.Text = "Peso" Then
            txtPeso.Text = ""
        End If
    End Sub

    Private Sub txtPeso_Leave(sender As Object, e As EventArgs) Handles txtPeso.Leave
        If txtPeso.Text = "" Then
            txtPeso.Text = "Peso"
        End If
    End Sub

    Private Sub txtAltura_Enter(sender As Object, e As EventArgs) Handles txtAltura.Enter
        If txtAltura.Text = "Altura" Then
            txtAltura.Text = ""
        End If
    End Sub

    Private Sub txtAltura_Leave(sender As Object, e As EventArgs) Handles txtAltura.Leave
        If txtAltura.Text = "" Then
            txtAltura.Text = "Altura"
        End If
    End Sub

    Private Sub txtLargura_Enter(sender As Object, e As EventArgs) Handles txtLargura.Enter
        If txtLargura.Text = "Largura" Then
            txtLargura.Text = ""
        End If
    End Sub

    Private Sub txtLargura_Leave(sender As Object, e As EventArgs) Handles txtLargura.Leave
        If txtLargura.Text = "" Then
            txtLargura.Text = "Largura"
        End If
    End Sub

    Private Sub txtComprimento_Enter(sender As Object, e As EventArgs) Handles txtComprimento.Enter
        If txtComprimento.Text = "Comprimento" Then
            txtComprimento.Text = ""
        End If
    End Sub

    Private Sub txtComprimento_Leave(sender As Object, e As EventArgs) Handles txtComprimento.Leave
        If txtComprimento.Text = "" Then
            txtComprimento.Text = "Comprimento"
        End If
    End Sub

    Private Sub txtMarca_Enter(sender As Object, e As EventArgs) Handles txtMarca.Enter
        If txtMarca.Text = "Marca" Then
            txtMarca.Text = ""
        End If
    End Sub

    Private Sub txtMarca_Leave(sender As Object, e As EventArgs) Handles txtMarca.Leave
        If txtMarca.Text = "" Then
            txtMarca.Text = "Marca"
        End If
    End Sub

    Private Sub txtEan_Enter(sender As Object, e As EventArgs) Handles txtEan.Enter
        If txtEan.Text = "EAN" Then
            txtEan.Text = ""
        End If
    End Sub

    Private Sub txtEan_Leave(sender As Object, e As EventArgs) Handles txtEan.Leave
        If txtEan.Text = "" Then
            txtEan.Text = "EAN"
        End If
    End Sub

    Private Sub txtNbm_Enter(sender As Object, e As EventArgs) Handles txtNbm.Enter
        If txtNbm.Text = "NBM" Then
            txtNbm.Text = ""
        End If
    End Sub

    Private Sub txtNbm_Leave(sender As Object, e As EventArgs) Handles txtNbm.Leave
        If txtNbm.Text = "" Then
            txtNbm.Text = "NBM"
        End If
    End Sub

    Private Sub txtImagem_Enter(sender As Object, e As EventArgs) Handles txtImagem.Enter
        If txtImagem.Text = "Link Imagem" Then
            txtImagem.Text = ""
        End If
    End Sub

    Private Sub txtImagem_Leave(sender As Object, e As EventArgs) Handles txtImagem.Leave
        If txtImagem.Text = "" Then
            txtImagem.Text = "Link Imagem"
        End If
    End Sub
#End Region

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Limpar()
    End Sub

    Private Sub Limpar()
        txtSku.Text = "SKU"
        txtNome.Text = "Nome"
        txtDescricao.Text = "Descrição"
        comboStatus.Text = "Status"
        txtQtde.Text = "Quantidade"
        txtPreco.Text = "Preço"
        txtPrecoEspecial.Text = "Preço Especial"
        txtCusto.Text = "Custo"
        txtPeso.Text = "Peso"
        txtAltura.Text = "Altura"
        txtLargura.Text = "Largura"
        txtComprimento.Text = "Comprimento"
        txtMarca.Text = "Marca"
        txtEan.Text = "EAN"
        txtNbm.Text = "NBM"
        txtImagem.Text = "Link Imagem"
        dgvAtributos.Rows.Clear()
    End Sub

    Private Function pegaAtributos()
        Dim atributos As List(Of Atributos) = New List(Of Atributos)
        Dim atributo As Atributos = New Atributos

        For Each row As DataGridViewRow In dgvAtributos.Rows
            If row.Cells(0).Value = Nothing Then
                Exit For
            End If
            atributo.key = row.Cells(0).Value
            atributo.value = row.Cells(1).Value

            atributos.Add(atributo)

            atributo = New Atributos
        Next

        Return atributos
    End Function

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim response As RestResponse = New RestResponse
        Dim atributos As List(Of Atributos) = pegaAtributos()

        Dim categoria As Categorias = New Categorias
        categoria.code = "1"
        categoria.name = "Skyhub Teste"
        Dim categorias As List(Of Categorias) = New List(Of Categorias)
        categorias.Add(categoria)

        Dim images As List(Of String) = New List(Of String)
        images.Add(txtImagem.Text)

        Dim produto As Produto = New Produto(txtSku.Text, txtNome.Text, txtDescricao.Text, comboStatus.SelectedItem.ToString(), txtQtde.Text, txtPreco.Text, txtPrecoEspecial.Text, txtCusto.Text, txtPeso.Text, txtAltura.Text, txtLargura.Text, txtComprimento.Text, txtMarca.Text, txtEan.Text, txtNbm.Text, categorias, images, atributos)

        Dim produtos As Product = New Product
        produtos.product = produto

        response = enviaProduto(produtos)

        If response.IsSuccessful Then
            MsgBox("Produto Criado!")
        Else
            MsgBox("Deu Erro: " + response.StatusCode.ToString + " - " + response.Content.ToString)
        End If
    End Sub

    Private Function enviaProduto(ByRef produtos As Product)
        Dim client As RestClient = New RestClient("https://api.skyhub.com.br/products")
        Dim request As RestRequest = New RestRequest

        request.Method = Method.POST
        request.AddHeader("Accept", "application/json")
        request.AddHeader("Content-Type", "application/json")
        request.AddHeader("X-User-Email", "tadeu.bonato@b2wdigital.com")
        request.AddHeader("X-Api-Key", "hAm6Zty6V3xxy5aENTis")
        request.AddHeader("x-accountmanager-key", "Skyhub")

        Dim response As RestResponse = New RestResponse

        request.AddJsonBody(produtos)

        response = client.Execute(request)

        Return response
    End Function

    Private Sub btnAtualiza_Click(sender As Object, e As EventArgs) Handles btnAtualiza.Click
        Dim response As RestResponse = New RestResponse
        Dim produto As Produto = New Produto(Convert.ToInt32(txtPreco2.Text))
        Dim produtos As Product = New Product
        produtos.product = produto

        response = atualizaProduto(produtos, txtSku2.Text)

        If response.IsSuccessful Then
            MsgBox("Produto Atualizado!")
        Else
            MsgBox("Deu Erro: " + response.StatusCode.ToString + " - " + response.Content.ToString)
        End If
    End Sub

    Private Function atualizaProduto(ByRef produto As Product, ByRef sku As String)
        Dim client As RestClient = New RestClient("https://api.skyhub.com.br/products/" + sku)
        Dim request As RestRequest = New RestRequest
        Dim settings As JsonSerializerSettings = New JsonSerializerSettings
        settings.NullValueHandling = NullValueHandling.Ignore
        settings.DefaultValueHandling = DefaultValueHandling.Ignore

        request.Method = Method.PUT
        request.AddHeader("Accept", "application/json")
        request.AddHeader("Content-Type", "application/json")
        request.AddHeader("X-User-Email", "tadeu.bonato@b2wdigital.com")
        request.AddHeader("X-Api-Key", "hAm6Zty6V3xxy5aENTis")
        request.AddHeader("x-accountmanager-key", "Skyhub")

        Dim response As RestResponse = New RestResponse

        Dim formatado As String = JsonConvert.SerializeObject(produto, Formatting.Indented, settings)

        request.AddParameter("application/json", formatado, ParameterType.RequestBody)

        response = client.Execute(request)

        Return response
    End Function

    Private Sub btnInativa_Click(sender As Object, e As EventArgs) Handles btnInativa.Click
        inativaProdutos()
        MsgBox("Status Alterado")
    End Sub

    Private Function inativaProdutos()
        Dim responseBusca As RestResponse = New RestResponse
        responseBusca = buscaProdutos()
        If responseBusca.IsSuccessful Then
            Dim produtos As New List(Of Product)
            produtos.Add(JsonConvert.DeserializeObject(Of Product)(responseBusca.Content))
            Dim stringTeste As New List(Of String)
            For Each teste As String In responseBusca.Content.Split("{")
                If teste.Contains("sku") And teste.Contains("victorbou") Then
                    teste = teste.Replace("""sku"":""", "").Replace("""},", "")
                    If teste.Contains("""next"":""https://") Then
                        teste = teste.Split("""")(0).ToString()
                    End If
                    stringTeste.Add(teste)
                End If
            Next

            For Each skuString As String In stringTeste
                If Not skuString.EndsWith("2") Then
                    Dim produto As New Produto(skuString)
                    Dim products As Product = New Product
                    products.product = produto

                    atualizaProdutoStatus(products, skuString)
                End If
            Next

        End If

        Return True
    End Function

    Private Function buscaProdutos()
        Dim client As RestClient = New RestClient("https://api.skyhub.com.br/products?only[]=sku")
        Dim request As RestRequest = New RestRequest
        Dim response As RestResponse = New RestResponse

        request.Method = Method.GET
        request.AddHeader("Accept", "application/json")
        request.AddHeader("Content-Type", "application/json")
        request.AddHeader("X-User-Email", "tadeu.bonato@b2wdigital.com")
        request.AddHeader("X-Api-Key", "hAm6Zty6V3xxy5aENTis")
        request.AddHeader("x-accountmanager-key", "Skyhub")

        response = client.Execute(request)

        Return response
    End Function

    Private Function atualizaProdutoStatus(ByRef produto As Product, ByRef sku As String)
        Dim client As RestClient = New RestClient("https://api.skyhub.com.br/products/" + sku)
        Dim request As RestRequest = New RestRequest
        Dim settings As JsonSerializerSettings = New JsonSerializerSettings
        settings.NullValueHandling = NullValueHandling.Ignore
        settings.DefaultValueHandling = DefaultValueHandling.Ignore

        request.Method = Method.PUT
        request.AddHeader("Accept", "application/json")
        request.AddHeader("Content-Type", "application/json")
        request.AddHeader("X-User-Email", "tadeu.bonato@b2wdigital.com")
        request.AddHeader("X-Api-Key", "hAm6Zty6V3xxy5aENTis")
        request.AddHeader("x-accountmanager-key", "Skyhub")

        Dim response As RestResponse = New RestResponse

        produto.product.sku = Nothing
        Dim formatado As String = JsonConvert.SerializeObject(produto, Formatting.Indented, settings)

        request.AddParameter("application/json", formatado, ParameterType.RequestBody)

        response = client.Execute(request)

        Return response
    End Function

End Class

Public Class Produto

    Private skuProd As String
    Public Property sku As String
        Get
            Return skuProd
        End Get
        Set(ByVal value As String)
            skuProd = value
        End Set
    End Property

    Private nameProd As String
    Public Property name As String
        Get
            Return nameProd
        End Get
        Set(ByVal value As String)
            nameProd = value
        End Set
    End Property

    Private descricaoProd As String
    Public Property description As String
        Get
            Return descricaoProd
        End Get
        Set(ByVal value As String)
            descricaoProd = value
        End Set
    End Property

    Private statusProd As String
    Public Property status As String
        Get
            Return statusProd
        End Get
        Set(ByVal value As String)
            statusProd = value
        End Set
    End Property

    Private qtdeProd As Integer
    Public Property qty As Integer
        Get
            Return qtdeProd
        End Get
        Set(ByVal value As Integer)
            qtdeProd = value
        End Set
    End Property

    Private precoProd As Integer
    Public Property price As Integer
        Get
            Return precoProd
        End Get
        Set(ByVal value As Integer)
            precoProd = value
        End Set
    End Property

    Private precoPromo As Integer
    Public Property promotional_price As Integer
        Get
            Return precoPromo
        End Get
        Set(ByVal value As Integer)
            precoPromo = value
        End Set
    End Property

    Private custo As Integer
    Public Property cost As Integer
        Get
            Return custo
        End Get
        Set(ByVal value As Integer)
            custo = value
        End Set
    End Property

    Private peso As Integer
    Public Property weight As Integer
        Get
            Return peso
        End Get
        Set(ByVal value As Integer)
            peso = value
        End Set
    End Property

    Private altura As Integer
    Public Property height As Integer
        Get
            Return altura
        End Get
        Set(ByVal value As Integer)
            peso = altura
        End Set
    End Property

    Private largura As Integer
    Public Property width As Integer
        Get
            Return largura
        End Get
        Set(ByVal value As Integer)
            largura = value
        End Set
    End Property

    Private comprimento As Integer
    Public Property length As Integer
        Get
            Return comprimento
        End Get
        Set(ByVal value As Integer)
            comprimento = value
        End Set
    End Property

    Private marca As String
    Public Property brand As String
        Get
            Return marca
        End Get
        Set(ByVal value As String)
            marca = value
        End Set
    End Property

    Private eanProd As String
    Public Property ean As String
        Get
            Return eanProd
        End Get
        Set(ByVal value As String)
            eanProd = value
        End Set
    End Property

    Private nbmProd As String
    Public Property nbm As String
        Get
            Return nbmProd
        End Get
        Set(ByVal value As String)
            nbmProd = value
        End Set
    End Property

    Private categorias As List(Of Categorias)
    Public Property categories() As List(Of Categorias)
        Get
            Return categorias
        End Get
        Set(ByVal value As List(Of Categorias))
            categorias = value
        End Set
    End Property

    Private imagens As List(Of String)
    Public Property images As List(Of String)
        Get
            Return imagens
        End Get
        Set(ByVal value As List(Of String))
            imagens = value
        End Set
    End Property

    Private atributos As List(Of Atributos)
    Public Property specifications() As List(Of Atributos)
        Get
            Return atributos
        End Get
        Set(ByVal value As List(Of Atributos))
            atributos = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByRef sku1 As String, ByRef name1 As String, ByRef descricao1 As String, ByRef status1 As String, ByRef qtde1 As Integer, ByRef preco1 As Integer, ByRef promo1 As Integer, ByRef custo1 As Integer, ByRef peso1 As Integer, ByRef altura1 As Integer, ByRef largura1 As Integer, ByRef comprimento1 As Integer, ByRef marca1 As String, ByRef ean1 As String, ByRef nbm1 As String, ByRef categorias1 As List(Of Categorias), ByRef imagens1 As List(Of String), ByRef atributos1 As List(Of Atributos))
        sku = sku1
        name = name1
        description = descricao1
        status = status1
        qty = qtde1
        price = preco1
        promotional_price = promo1
        cost = custo1
        weight = peso1
        height = altura1
        width = largura1
        length = comprimento1
        brand = marca1
        ean = nbm1
        categories = categorias1
        images = imagens1
        specifications = atributos1
    End Sub

    Public Sub New(ByRef sku1 As String)
        sku = sku1
        status = "Disabled"
    End Sub

    Public Sub New(ByRef preco1 As Integer)
        price = preco1
    End Sub
End Class

Public Class Atributos
    Private keyAt As String
    Public Property key As String
        Get
            Return keyAt
        End Get
        Set(ByVal value As String)
            keyAt = value
        End Set
    End Property

    Private valueAt As String
    Public Property value As String
        Get
            Return valueAt
        End Get
        Set(ByVal value1 As String)
            valueAt = value1
        End Set
    End Property
End Class

Public Class Categorias
    Private codeCat As String
    Public Property code As String
        Get
            Return codeCat
        End Get
        Set(ByVal value As String)
            codeCat = value
        End Set
    End Property

    Private nameCat As String
    Public Property name As String
        Get
            Return nameCat
        End Get
        Set(ByVal value1 As String)
            nameCat = value1
        End Set
    End Property
End Class

Public Class Product
    Private produto As Produto
    Public Property product As Produto
        Get
            Return produto
        End Get
        Set(value As Produto)
            produto = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByRef produto As Produto)
        product.sku = produto.sku
    End Sub
End Class