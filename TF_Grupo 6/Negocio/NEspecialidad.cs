using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NEspecialidad
    {
        private DEspecialidad dEspecialidad = new DEspecialidad();
        public List<Especialidad> getAll()
        {
            return dEspecialidad.getAll();
        }
    }
}
