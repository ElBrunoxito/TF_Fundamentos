using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NVoluntario
    {
        private DVoluntario dVoluntariado = new DVoluntario();

        public String Registrar(Volunraio v) 
        { 
        
            return dVoluntariado.Registrar(v);
        }

        public String Modificar(Volunraio v)
        {
            return dVoluntariado.Modificar(v);
        }

        public String Eliminar(int id)
        {
            return dVoluntariado.Eliminar(id);
        }

        public List<Volunraio> ListarTodo()
        {
            return dVoluntariado.ListarTodo();
        }
    }
}
