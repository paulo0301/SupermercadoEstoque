﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class ItemCompra
    {
        public int IdProduto { get; set; }
        public int IdCompra { get; set; }
        public int Qtd { get; set; }
        public decimal Preco { get; set; }
    }
}
