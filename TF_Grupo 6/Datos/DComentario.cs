using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Datos
{
    public class DComentario
    {
        public String Registrar(Comentario comentario)
        {
            try
            {
                using (var context = new dbTFEntities())
                {
                    context.Comentario.Add(comentario);
                    context.SaveChanges();
                }
                return "Registrado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message + "ptmr";
            }
        }
        public List<Comentario> ListarTodo()
        {
            List<Comentario> comentarioTemp = new List<Comentario>();
            try
            {
                using (var context = new dbTFEntities())
                {
                    comentarioTemp = context.Comentario.ToList();
                }
                return comentarioTemp;
            }
            catch 
            {
                return comentarioTemp;
            }
        }
    }
}
