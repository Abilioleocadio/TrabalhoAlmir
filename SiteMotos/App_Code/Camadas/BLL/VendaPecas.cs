using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Camadas.BLL
{
    public class VendaPecas
    {
        public List<MODEL.VendaPecas> Select()
        {
            DAL.VendaPecas dalVenda = new DAL.VendaPecas();
            return dalVenda.Select();
        }

        public List<MODEL.VendaPecas> SelectById(int codigoVenda)
        {
            DAL.VendaPecas dalVenda = new DAL.VendaPecas();
            return dalVenda.SelectById(codigoVenda);
        }

        public void Insert(MODEL.VendaPecas venpecas)
        {
            DAL.VendaPecas dalVenda = new DAL.VendaPecas();
            dalVenda.Insert(venpecas);
        }
        public void Update(MODEL.VendaPecas venpecas)
        {
            DAL.VendaPecas dalVenda = new DAL.VendaPecas();
            dalVenda.UpDate(venpecas);
        }
        public void Delete(MODEL.VendaPecas venpecas)
        {
            DAL.VendaPecas dalVenda = new DAL.VendaPecas();
            dalVenda.Delete(venpecas);
        }
    }
}
