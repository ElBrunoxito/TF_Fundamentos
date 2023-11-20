using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DServicios
    {
        public List<Servicios> getAll()
        {
            List<Servicios> servicios = new List<Servicios> ();
            try
            {
                using (var contexto = new dbTFEntities())
                {
                    servicios = contexto.Servicios.ToList ();
                }
                return servicios;
            }
            catch
            {
                return servicios;
            }
        }
        public void Agregar(Servicios s)
        {
            try
            {
                using (var contexto = new dbTFEntities())
                {
                    contexto.Servicios.Add(s);
                    contexto.SaveChanges();
                }
              
            }
            catch
            {

            }
        }


    }
}
