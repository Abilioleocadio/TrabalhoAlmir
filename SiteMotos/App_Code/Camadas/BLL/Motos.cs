using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Camadas.BLL
{
    public class Motos
    {
        public List<MODEL.Motos> Select()
        {
            DAL.Motos dalMoto = new DAL.Motos();
            return dalMoto.Select();
        }

    public List<MODEL.Motos> SelectById(int codigoMoto)
    {
        DAL.Motos dalMoto = new DAL.Motos();
        return dalMoto.SelectById(codigoMoto);
    }
    
    public void Insert(MODEL.Motos motos)
    {
        DAL.Motos dalMoto = new DAL.Motos();
        dalMoto.Insert(motos);
    }
    public void UpDate(MODEL.Motos motos)
    {
        DAL.Motos dalMoto = new DAL.Motos();
        dalMoto.UpDate(motos);
    }
    public void Delete(MODEL.Motos motos)
    {
        DAL.Motos dalMoto = new DAL.Motos();
        dalMoto.Delete(motos);
    }
}
}
