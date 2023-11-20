using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCitas
    {
        public string AddCita(Citas_Medicas c)
        {
            try
            {
                using (var contexto = new dbTFEntities())
                {
                    contexto.Citas_Medicas.Add(c);
                    contexto.SaveChanges();
                }
                return "Cita reservada exitosamente :D";

            }catch (Exception ex)
            {
                return ex.Message;
            }
        }

        










    }
}
