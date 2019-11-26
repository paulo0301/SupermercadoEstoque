using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ItemVenda
    {
        public int IdVenda { get; set; }
        public int IdProduto { get; set; }
        public int Qtd { get; set; }
        public decimal Preco { get; set; }
    }
}
