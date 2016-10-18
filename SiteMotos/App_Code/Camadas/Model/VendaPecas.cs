using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Camadas.MODEL
{
    public class VendaPecas
    {
        public int codigoVenda { get; set; }
        public int idCliente { get; set; }
        public int idPecas { get; set; }
        public int idMoto { get; set; }
    }
}
