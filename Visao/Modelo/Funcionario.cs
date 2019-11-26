using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Funcionario
    {
        public string Formacao { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public DateTime DataIngresso { get; set; }
        public string NumeroConta { get; set; }
        public int IdSupermercado { get; set; }
    }
}
