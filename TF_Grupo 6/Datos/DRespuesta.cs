using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DRespuesta
    {
        public String Asignar(Respuesta respuesta)
        {
            try
            {
                using (var context = new dbTFEntities())
                {
                    context.Respuesta.Add(respuesta);
                    context.SaveChanges();
                }
                return "Asignado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Respuesta> ListarTodo()
        {
            List<Respuesta> respuesta = new List<Respuesta>();
            try
            {
                using (var context = new dbTFEntities())
                {
                    respuesta = context.Respuesta.ToList();
                }
                return respuesta;
            }
            catch
            {
                return respuesta;
            }
        }
    }
}
