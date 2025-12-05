using System.Collections.Generic;
using FrontTcc_Luiz.Services;
using Microsoft.AspNetCore.Components;

namespace FrontTcc_Luiz.ViewModels
{
    public class ProdutosViewModel
    {
        // Dados do Produto
        public string Nome { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public int Estoque { get; set; }

        // Controle de edição
        public bool EmEdicao { get; set; } = false;
        public ProdutosViewModel? Backup { get; set; }

        // LISTA de produtos carregados
        public List<ProdutosViewModel> Produtos { get; private set; } = new();

        private NavigationManager? _navigation;
        private ProdutoService? _produtoService;

        public ProdutosViewModel() { }

        public ProdutosViewModel(NavigationManager navigation, ProdutoService produtoService)
        {
            _navigation = navigation;
            _produtoService = produtoService;
        }

        public void CarregarProdutos()
        {
            if (_produtoService == null)
            {
                Produtos = new List<ProdutosViewModel>();
                return;
            }

            Produtos = _produtoService.ObterProdutos();
        }
    }
}
