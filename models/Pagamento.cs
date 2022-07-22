using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estoqueAPI.models
{
    public class Pagamento
    {
        public string Id { get; set; }
        public string FormaPagamento { get; set; }
        public string DataPagamento { get; set; }
    }
}