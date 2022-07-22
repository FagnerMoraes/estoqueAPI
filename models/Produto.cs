using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estoqueAPI.models
{
    public class Produto
    {
        public string Id { get; set; }        
        public string IdFornecedor { get; set; }
        public string IdCategoria {get; set;}
        public string NomeProduto { get; set; }
        public string Preco  { get; set; }
        public string Quantidade { get; set; }
        public bool Ativo { get; set; }
    }
}