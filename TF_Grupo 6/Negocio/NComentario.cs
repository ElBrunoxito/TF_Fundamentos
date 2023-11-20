using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NComentario
    {
        private DComentario dComentario = new DComentario();
        public String Registrar(Comentario comentario)
        {
            return dComentario.Registrar(comentario);
        }
        public List<Comentario> ListarTodo()
        {
            return dComentario.ListarTodo();
        }
    }
}
