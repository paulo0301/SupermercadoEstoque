using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Produto
    {
        public string Descricao { get; set; }
        public int Qtd { get; set; }
        public decimal Preco { get; set; }
        public DateTime Validade { get; set; }
        public int Id { get; set; }
        public int IdFornecedor { get; set; }
        public int IdSupermercado { get; set; }
    }
}
