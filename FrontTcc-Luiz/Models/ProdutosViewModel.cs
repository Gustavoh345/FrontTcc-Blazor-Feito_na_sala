using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontTcc_Luiz.Models;
using Microsoft.AspNetCore.Components;

namespace FrontTcc_Luiz.Models
{
    public class ProdutosViewModel
    {
        // Propriedades do viewmodel (inicializadas para evitar warnings)
        public string Nome { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public decimal Preco { get; set; } = 0m;
        public int Estoque { get; set; } = 0;

        // Controle interno de edição
        public bool EmEdicao { get; set; } = false;
        public ProdutosViewModel? Backup { get; set; } = null;

        // NOTE: use o nome correto do seu modelo - ProdutoViewModel ou ProdutoModel.
        // Aqui assumo que existe ProdutoViewModel. Se preferir ProdutoModel, substitua abaixo.
        public List<ProdutosViewModel> Produtos { get; private set; } = new();

        // Campos que podem ser nulos se o viewmodel for criado sem DI
        private NavigationManager? _navigation;
        private ProdutoService? _produtoService;

        // Construtor sem parâmetros — compatível com locais que fazem "new ProdutosViewModel()"
        public ProdutosViewModel()
        {
            // nenhum serviço disponível por padrão — métodos que dependam deles devem checar null.
        }

        // Construtor com dependências (para injeção)
        public ProdutosViewModel(NavigationManager? navigation, ProdutoService? produtoService)
        {
            _navigation = navigation;
            _produtoService = produtoService;
        }

        // Método opcional para injetar dependências depois da criação
        public void Initialize(NavigationManager navigation, ProdutoService produtoService)
        {
            _navigation = navigation;
            _produtoService = produtoService;
        }

        public void CarregarProdutos()
        {
            if (_produtoService == null)
            {
                // Se não tiver o serviço, não tenta carregar (evita NullReferenceException)
                Produtos = new();
                return;
            }

            Produtos = _produtoService.ObterProdutos() ?? new List<ProdutoViewModel>();
        }

        public void NavegarParaCadastro()
        {
            if (_navigation != null)
                _navigation.NavigateTo("/cadastrar-produto");
        }

        public void NavegarParaDelecao()
        {
            if (_navigation != null)
                _navigation.NavigateTo("/deletar-produtos");
        }
    }
}
