using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Modelo;

namespace Persistencia
{
    public class PFornecedor
    {
        private string arquivo = "arquivo.xml";
        public List<Fornecedor> Open()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Fornecedor>));
            StreamReader f = null;
            List<Fornecedor> l = null;
            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                l = x.Deserialize(f) as List<Fornecedor>;
            }
            catch
            {
                l = new List<Fornecedor>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return l;
        }
        public void Save(List<Fornecedor> l)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<Fornecedor>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, l);
            f.Close();
        }
    }
}
