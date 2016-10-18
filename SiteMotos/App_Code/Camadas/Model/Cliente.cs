using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Camadas.MODEL
{
    public class Cliente
    {
        public int codigoCliente { get; set; }
        public string nome { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string nascimento { get; set; }
        public string cpf { get; set; }
    }
}
