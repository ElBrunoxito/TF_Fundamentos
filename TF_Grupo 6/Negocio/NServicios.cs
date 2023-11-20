using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NServicios
    { 
        private DServicios dServicios = new DServicios();
        public List<Servicios> getAll()
        {
            return dServicios.getAll();
        }
        public void agregar(Servicios servicios)
        {
            dServicios.Agregar(servicios);
        }
    }
}
