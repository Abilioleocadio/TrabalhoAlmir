using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Camadas.BLL
{
    public class Cliente
    {
        public List<MODEL.Cliente> Select()
        {
            DAL.Cliente daCli = new DAL.Cliente();
            return daCli.Select();
        }

        public List<MODEL.Cliente> SelectById(int codigoCliente)
        {
            DAL.Cliente daCli = new DAL.Cliente();
            return daCli.SelectById(codigoCliente);
        }
        public List<MODEL.Cliente> SelectByNome(string nome)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            return dalCli.SelectByNome(nome);
        }
        public void Insert (MODEL.Cliente cliente)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            dalCli.Insert(cliente);
        }
        public void UpDate (MODEL.Cliente cliente)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            dalCli.UpDate(cliente);
        }
        public void Delete (MODEL.Cliente cliente)
        {
            DAL.Cliente dalCLi = new DAL.Cliente();
            dalCLi.Delete(cliente);
        }
    }
}
