using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DEspecialidad
    {
        public List<Especialidad> getAll()
        {
            List<Especialidad> l = new List<Especialidad> ();
            try
            {
                using (var contexto = new dbTFEntities())
                {
                    l = contexto.Especialidad.ToList();
                }
                return l;
            }
            catch
            {
                return l;
            }
        }
    }
}
