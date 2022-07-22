using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estoqueAPI.models
{
    public class Fonecedor
    {
        public string Id { get; set; }
        public string NomeFornecedor { get; set; }
        public string CNPJ { get; set; }
        public bool Ativo { get; set; }
    }
}