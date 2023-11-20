using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NCitas
    {
        private DCitas dCitas = new DCitas();
        public string AddCita(Citas_Medicas c)
        {
            return dCitas.AddCita(c);
        }
    }
}
