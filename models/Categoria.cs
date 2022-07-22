using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estoqueAPI.models
{
    public class Categoria
    {
        public string Id { get; set; }
        public string NomeCategoria { get; set; }
        public bool Ativo { get; set; }
    }
}