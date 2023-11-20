using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NRespuesta
    {
        private DRespuesta dRespuesta = new DRespuesta();
        public String Asignar(Respuesta respuesta)
        {
            return dRespuesta.Asignar(respuesta);
        }
        public List<Respuesta> ListarTodo()
        {
            return dRespuesta.ListarTodo();
        }
    }
}
