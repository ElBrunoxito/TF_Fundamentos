using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NInformacion
    {
        private DInformacion dInformacion = new DInformacion();
        public List<Informacion_Adm> getAll()
        {
            return dInformacion.getAll();   
        }

        public List<Informacion_Adm> getPorstring(string S)
        {
            return dInformacion.getPorstring(S);
        }
    }
}
