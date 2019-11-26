using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class OperadorDeCaixa : Funcionario
    {
        public int IdGerente { get; set; }
        public int Numerocaixa { get; set; }
    }
}
