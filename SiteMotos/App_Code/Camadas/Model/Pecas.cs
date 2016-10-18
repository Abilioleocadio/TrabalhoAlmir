using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Camadas.MODEL
{
    public class Pecas
    {
        public int codigoPecas { get; set; }
        public string nome { get; set; }
        public string anoPeca { get; set; }
        public int quantidade { get; set; }
        public float preco { get; set; }
    }
}
