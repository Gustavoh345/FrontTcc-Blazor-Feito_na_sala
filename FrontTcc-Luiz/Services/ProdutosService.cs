using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using FrontTcc_Luiz.Models;

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
            },

            new ProdutosViewModel {
                Nome = "Relógio Casio",
                Categoria = "Acessórios",
                Descricao = "Relógio resistente à água",
                Preco = 199.90m,
                Estoque = 25
            },

            new ProdutosViewModel {
                Nome = "Cadeira Gamer ThunderX3",
                Categoria = "Móveis",
                Descricao = "Cadeira confortável com ajuste de altura",
                Preco = 999.00m,
                Estoque = 5
            }
        };
    }
}
