using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NHospital
    {
        private DHospital dHospital = new DHospital();
        public List<Hospital> getAllPorMedico(int id)
        {
            return dHospital.getAllPorMedico(id);
        }
        public List<Hospital> getAll()
        {
            return dHospital.getAll();  
        }

    }
}
