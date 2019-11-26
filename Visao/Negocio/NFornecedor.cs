using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Persistencia;

namespace Negocio
{
    class NFornecedor
    {
        private List<Fornecedor> fornecedores = new List<Fornecedor>();

        public void Insert(Fornecedor f)
        {
            PFornecedor pf = new PFornecedor();
            fornecedores = pf.Open();
            int i = 0;
            foreach (Fornecedor x in fornecedores) if (Convert.ToInt32(x.Id) > i) i = Convert.ToInt32(x.Id);
            f.Id = (i + 1).ToString();
            fornecedores.Add(f);
            pf.Save(fornecedores);
        }

        public void Update(Fornecedor f)
        {
            PFornecedor pf = new PFornecedor();
            fornecedores = pf.Open();
            for (int i = 0; i < fornecedores.Count; i++)
                if (fornecedores[i].Id == f.Id)
                {
                    fornecedores.RemoveAt(i);
                    break;
                }
            fornecedores.Add(f);
            pf.Save(fornecedores);
        }
        public List<Fornecedor> Select()
        {
            PFornecedor pf = new PFornecedor();
            return pf.Open().OrderBy(c => c.Nome).ToList();
        }
        public void Delete(Fornecedor f)
        {
            PFornecedor pf = new PFornecedor();
            fornecedores = pf.Open();
            for (int i = 0; i < fornecedores.Count; i++)
                if (fornecedores[i].Id == f.Id)
                {
                    fornecedores.RemoveAt(i);
                    break;
                }
            pf.Save(fornecedores);
        }
    }
}
