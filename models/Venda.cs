using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estoqueAPI.models
{
    public class Venda
    {
        public string Id { get; set; }
        public string IdCliente { get; set; }
        public string IdPagamento { get; set; }
    }
}