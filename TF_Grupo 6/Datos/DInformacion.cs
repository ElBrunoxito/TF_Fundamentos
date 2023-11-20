using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DInformacion
    {
        public List<Informacion_Adm> getAll()
        {

            List<Informacion_Adm> info = new List<Informacion_Adm>();
            try
            {
                using (var contexto = new dbTFEntities())
                {
                    info = contexto.Informacion_Adm.ToList();
                }
                return info;
            }
            catch
            {
                return info;
            }
        }

        public List<Informacion_Adm> getPorstring(string S)
        {
            List<Informacion_Adm> info = new List<Informacion_Adm> ();
            try
            {
                using (var contexto = new dbTFEntities())
                {
                    info = contexto.Informacion_Adm.Where(i => i.descripcion.Contains(S)).ToList();
                }
                return info;
            }
            catch
            {
                return info;
            }
        }


    }
}
