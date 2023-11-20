using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NMedico
    {
        private DMedico dMedico = new DMedico();
        public List<Medico> getPorEspecialidad(int idEspecialidad)
        {
            return dMedico.getPorEspecialidad(idEspecialidad);
        }
    }
}
