using FrontTcc_Luiz.ViewModels;
using System.Collections.Generic;

namespace FrontTcc_Luiz.Services
{
    public class ProdutoService
    {
        public List<ProdutosViewModel> ObterProdutos()
        {
            return new List<ProdutosViewModel>()
            {
                new ProdutosViewModel {
                    Nome = "Notebook Dell Inspiron",
                    Categoria = "Eletrônicos",
                    Descricao = "Notebook com 8GB RAM e SSD 256GB",
                    Preco = 3500.90m,
                    Estoque = 10
                },
                new ProdutosViewModel {
                    Nome = "Camiseta Nike DryFit",
                    Categoria = "Roupas",
                    Descricao = "Camiseta esportiva respirável",
                    Preco = 89.99m,
                    Estoque = 50
                }
            };
        }
    }
}
