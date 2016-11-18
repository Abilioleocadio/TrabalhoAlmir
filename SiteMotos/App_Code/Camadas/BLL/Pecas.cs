using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Camadas.BLL
{
    public class Pecas
    {
        public List<MODEL.Pecas> Select()
        {
            DAL.Pecas dalPeca = new DAL.Pecas();
            return dalPeca.Select();
        }

        public MODEL.Pecas SelectById(int codigoPecas)
        {
            DAL.Pecas dalPeca = new DAL.Pecas();
            return dalPeca.SelectById(codigoPecas);
        }

        public void Insert(MODEL.Pecas pecas)
        {
            DAL.Pecas dalPeca = new DAL.Pecas();
            dalPeca.Insert(pecas);
        }
        public void UpDate(MODEL.Pecas pecas)
        {
            DAL.Pecas dalPeca = new DAL.Pecas();
            dalPeca.UpDate(pecas);
        }
        public void Delete(MODEL.Pecas pecas)
        {
            DAL.Pecas dalPeca = new DAL.Pecas();
            dalPeca.Delete(pecas);
        }
    }
}
