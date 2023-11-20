using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DVoluntario
    {
        public String Registrar(Volunraio voluntariado)
        {
            try
            {
                using (var context = new dbTFEntities())
                {
                    context.Volunraio.Add(voluntariado);
                    context.SaveChanges();
                }
                return "Registrado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Volunraio voluntariado)
        {
            try
            {
                using (var context = new dbTFEntities())
                {
                    Volunraio voluntariadoTemp = context.Volunraio.Find(voluntariado.idVoluntario);
                    voluntariadoTemp.Nombre = voluntariado.Nombre;
                    voluntariadoTemp.Hospital_idHospital = voluntariado.Hospital_idHospital;
                    voluntariadoTemp.Tipo = voluntariado.Tipo;
                    voluntariadoTemp.Horario = voluntariado.Horario;
                    context.SaveChanges();
                }
                return "Modificado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int id)
        {
            try
            {
                using (var context = new dbTFEntities())
                {
                    Volunraio voluntariadoTemp = context.Volunraio.Find(id);
                    context.Volunraio.Remove(voluntariadoTemp);
                    context.SaveChanges();
                }
                return "Eliminado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Volunraio> ListarTodo()
        {
            List < Volunraio> voluntariados = new List<Volunraio>();
            try
            {
                using (var context = new dbTFEntities())
                {
                    voluntariados = context.Volunraio.ToList();
                }
                return voluntariados;
            }
            catch
            {
                return voluntariados;
            }
        }

    }
}
