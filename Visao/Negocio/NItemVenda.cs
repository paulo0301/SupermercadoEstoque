using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Negocio
{
    class NItemVenda
    {
        public List<ItemVenda> itensvendas = new List<ItemVenda>();
        public void SetItemVenda(int idv, int idp, int qt, decimal pr)
        {
            ItemVenda it = new ItemVenda();
            it.IdVenda = idv;
            it.IdProduto = idp;
            it.Qtd = qt;
            it.Preco = pr;
            itensvendas.Add(it);
        }
        public void SetVenda(ItemVenda it)
        {
            Venda v = new Venda();
            v.Data = DateTime.Now;
            v.Id = it.IdVenda;
        }
        public int Vender()
        {

        }
    }
}
