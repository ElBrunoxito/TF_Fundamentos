using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DMedico
    {
        public List<Medico> getPorEspecialidad(int idEspecialidad)
        {
            List<Medico> l = new List<Medico>();
            try
            {
                using (var contexto = new dbTFEntities())
                {
                    l = contexto.Medico
                        .Where(m => m.Especialidad.Any(e => e.idEspecialidad == idEspecialidad)).ToList();
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
